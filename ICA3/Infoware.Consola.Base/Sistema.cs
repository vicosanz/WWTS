using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Infoware.Datos;
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public class Sistema : ISistema
    {
        private IAplicacion mSistemaObjeto;
        private string mMensajeError;

        public Sistema()
        {
            UsuarioString = "";
            ContrasenaString = "";
            GuardarContrasena = false;
            CargaralIniciar = false;
            CargarAhora = false;
            NombreSistema = "";
            DescripcionSistema = "";
            Ensamblado = "";
            OperadorDatos = null;
            Usuario = null;
            mSistemaObjeto = null;
            mMensajeError = "";
            SeguridadWindows = false;
        }

        public string NombrePublico => string.IsNullOrEmpty(this.NombreSistema) ? string.Format("{0} {1}", (object)Path.GetFileNameWithoutExtension(this.Ensamblado), (object)this.OperadorDatos.Descripcion) : this.NombreSistema.Trim();

        public string DirectorioRaiz
        {
            get
            {
                string path2 = this.NombrePublico;
                char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
                int index = 0;
                while (index < invalidFileNameChars.Length)
                {
                    char ch = invalidFileNameChars[index];
                    path2 = path2.Replace(ch+"", "");
                    checked { ++index; }
                }
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), path2);
            }
        }

        [XmlElement]
        public string DescripcionSistema { get; set; }

        [XmlElement]
        public string Ensamblado { get; set; }

        [XmlElement]
        public string NombreSistema { get; set; }

        [XmlElement]
        public bool GuardarContrasena { get; set; }

        [XmlElement]
        public bool CargaralIniciar { get; set; }

        [XmlIgnore]
        public bool CargarAhora { get; set; }

        [XmlIgnore]
        public string ContrasenaString { get; set; }

        [XmlElement]
        public string ContrasenaString2
        {
            get => GuardarContrasena ? ContrasenaString : string.Empty;
            set
            {
                if (!GuardarContrasena)
                {
                    return;
                }

                ContrasenaString = value;
            }
        }

        public OperadorDatos OperadorDatos { get; set; }

        [XmlIgnore]
        public Usuario Usuario { get; set; }

        [XmlElement]
        public string UsuarioString { get; set; }

        public bool Probarconexion()
        {
            bool flag=false;
            try
            {
                if (SeguridadWindows)
                {
                    UsuarioString = WindowsIdentity.GetCurrent().Name.ToString();
                }
                else if (UsuarioString.Contains("\\"))
                {
                    throw new Exception("No se permite la utilización del signo \\ fuera del contexto de la Seguridad de Windows");
                }

                Usuario = new Usuario(OperadorDatos, UsuarioString);
                if (!SeguridadWindows && !Usuario.VerificarPassword(ContrasenaString))
                {
                    throw new Exception("Error al autenticarse" + Environment.NewLine + "Posibles causas:" + Environment.NewLine + "Revise que tenga acceso al servidor, que el servidor de datos este activo " + Environment.NewLine + "y además que el usuario y la clave sean correctas");
                }

                if (SistemaObjeto == null)
                {
                    throw new Exception(string.Format("Error al cargar aplicación {0}. Por favor vuelva a intentarlo más tarde o remueva la aplicación. {1}", (object)this.NombrePublico, (object)this.MensajeError));
                }
                flag = true;
            }
            catch (Exception ex)
            {
                mMensajeError = ex.Message;
            }
            return flag;
        }

        [XmlIgnore]
        public string MensajeError => mMensajeError;

        [XmlIgnore]
        public RestriccionList Restricciones => Usuario?.Restricciones;

        public IAplicacion SistemaObjeto
        {
            get
            {
                if (mSistemaObjeto == null)
                {
                    if (string.IsNullOrEmpty(Ensamblado))
                    {
                        mMensajeError = "No se ha especificado la ruta del ensamblado";
                        return null;
                    }
                    foreach (Type _type in Assembly.LoadFrom(Ensamblado).GetTypes())
                    {
                        if (_type.Name.Trim().ToUpper() == "INICIALIZACION")
                        {
                            IAplicacion instance = (IAplicacion)Activator.CreateInstance(_type);
                            if (instance.Validacion(Usuario))
                                mSistemaObjeto = instance;
                        }
                    }
                     
                }
                return mSistemaObjeto;
            }
        }

        public bool SeguridadWindows { get; set; }
    }

    public class SistemaList : BindingList<Sistema>
    {
        public static void SerializeList(SistemaList _SistemaList, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SistemaList), new Type[2]
            {
                typeof (SQLOperadorDatos),
                typeof (SybaseOperadorDatos)
            });
            TextWriter textWriter = new StreamWriter(filename);
            xmlSerializer.Serialize(textWriter, _SistemaList);
            textWriter.Close();
        }

        public static SistemaList DeSerializeList(string filename)
        {
            SistemaList sistemaList = new SistemaList();
            try
            {
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                XmlTextReader xmlTextReader = new XmlTextReader(fileStream);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SistemaList), new Type[2]
                {
                    typeof (SQLOperadorDatos),
                    typeof (SybaseOperadorDatos)
                });
                if (xmlSerializer.CanDeserialize(xmlTextReader))
                {
                    sistemaList = (SistemaList)xmlSerializer.Deserialize(xmlTextReader);
                }
                fileStream.Close();
            }
            catch (Exception)
            {
                 
            }
            return sistemaList;
        }
    }
}
