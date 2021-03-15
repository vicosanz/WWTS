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
        private string mUsuarioString;
        private string mContrasenaString;
        private bool mGuardarContrasena;
        private bool mCargaraliniciar;
        private bool mCargarAhora;
        private string mNombreSistema;
        private string mDescripcionSistema;
        private string mEnsamblado;
        private OperadorDatos mOperadorDatos;
        private Usuario mUsuario;
        private IAplicacion mSistemaObjeto;
        private string mMensajeError;
        private bool mSeguridadWindows;

        public Sistema()
        {
            this.mUsuarioString = "";
            this.mContrasenaString = "";
            this.mGuardarContrasena = false;
            this.mCargaraliniciar = false;
            this.mCargarAhora = false;
            this.mNombreSistema = "";
            this.mDescripcionSistema = "";
            this.mEnsamblado = "";
            this.mOperadorDatos = (OperadorDatos)null;
            this.mUsuario = (Usuario)null;
            this.mSistemaObjeto = (IAplicacion)null;
            this.mMensajeError = "";
            this.mSeguridadWindows = false;
        }

        public string NombrePublico => string.IsNullOrEmpty(this.mNombreSistema) ? string.Format("{0} {1}", (object)Path.GetFileNameWithoutExtension(this.mEnsamblado), (object)this.OperadorDatos.Descripcion) : this.mNombreSistema.Trim();

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
        public string DescripcionSistema
        {
            get => this.mDescripcionSistema;
            set => this.mDescripcionSistema = value;
        }

        [XmlElement]
        public string Ensamblado
        {
            get => this.mEnsamblado;
            set => this.mEnsamblado = value;
        }

        [XmlElement]
        public string NombreSistema
        {
            get => this.mNombreSistema;
            set => this.mNombreSistema = value;
        }

        [XmlElement]
        public bool GuardarContrasena
        {
            get => this.mGuardarContrasena;
            set => this.mGuardarContrasena = value;
        }

        [XmlElement]
        public bool CargaralIniciar
        {
            get => this.mCargaraliniciar;
            set => this.mCargaraliniciar = value;
        }

        [XmlIgnore]
        public bool CargarAhora
        {
            get => this.mCargarAhora;
            set => this.mCargarAhora = value;
        }

        [XmlIgnore]
        public string ContrasenaString
        {
            get => this.mContrasenaString;
            set => this.mContrasenaString = value;
        }

        [XmlElement]
        public string ContrasenaString2
        {
            get => this.GuardarContrasena ? this.mContrasenaString : string.Empty;
            set
            {
                if (!this.GuardarContrasena)
                    return;
                this.mContrasenaString = value;
            }
        }

        public OperadorDatos OperadorDatos
        {
            get
            {
                if (this.mOperadorDatos == null)
                    this.mOperadorDatos = (OperadorDatos)null;
                return this.mOperadorDatos;
            }
            set => this.mOperadorDatos = value;
        }

        [XmlIgnore]
        public Usuario Usuario
        {
            get => this.mUsuario;
            set => this.mUsuario = value;
        }

        [XmlElement]
        public string UsuarioString
        {
            get => this.mUsuarioString;
            set => this.mUsuarioString = value;
        }

        public bool Probarconexion()
        {
            bool flag;
            try
            {
                if (this.SeguridadWindows)
                    this.mUsuarioString = WindowsIdentity.GetCurrent().Name.ToString();
                else if (this.mUsuarioString.Contains("\\"))
                    throw new Exception("No se permite la utilización del signo \\ fuera del contexto de la Seguridad de Windows");
                this.mUsuario = new Usuario(this.OperadorDatos, this.mUsuarioString);
                if (!this.SeguridadWindows && !this.mUsuario.VerificarPassword(this.mContrasenaString))
                    throw new Exception("Error al autenticarse" + Environment.NewLine + "Posibles causas:" + Environment.NewLine + "Revise que tenga acceso al servidor, que el servidor de datos este activo " + Environment.NewLine + "y además que el usuario y la clave sean correctas");
                if (this.SistemaObjeto == null)
                    throw new Exception(string.Format("Error al cargar aplicación {0}. Por favor vuelva a intentarlo más tarde o remueva la aplicación. {1}", (object)this.NombrePublico, (object)this.MensajeError));
                flag = true;
            }
            catch (Exception ex)
            {
                this.mMensajeError = ex.Message;
                flag = false;
            }
            return flag;
        }

        [XmlIgnore]
        public string MensajeError => this.mMensajeError;

        [XmlIgnore]
        public RestriccionList Restricciones => this.mUsuario == null ? (RestriccionList)null : this.mUsuario.Restricciones;

        public IAplicacion SistemaObjeto
        {
            get
            {
                if (this.mSistemaObjeto == null)
                {
                    if (string.IsNullOrEmpty(this.mEnsamblado))
                    {
                        this.mMensajeError = "No se ha especificado la ruta del ensamblado";
                        return (IAplicacion)null;
                    }
                    foreach(Type _type in Assembly.LoadFrom(this.mEnsamblado).GetTypes())
                    {
                        if (_type.Name.Trim().ToUpper() == "INICIALIZACION")
                        {
                            IAplicacion instance = (IAplicacion)Activator.CreateInstance(_type);
                            if (instance.Validacion(this.Usuario))
                                this.mSistemaObjeto = instance;
                        }
                    }
                     
                }
                return this.mSistemaObjeto;
            }
        }

        public bool SeguridadWindows
        {
            get => this.mSeguridadWindows;
            set => this.mSeguridadWindows = value;
        }
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
            TextWriter textWriter = (TextWriter)new StreamWriter(filename);
            xmlSerializer.Serialize(textWriter, (object)_SistemaList);
            textWriter.Close();
        }

        public static SistemaList DeSerializeList(string filename)
        {
            SistemaList sistemaList = new SistemaList();
            try
            {
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                XmlTextReader xmlTextReader = new XmlTextReader((Stream)fileStream);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SistemaList), new Type[2]
                {
                    typeof (SQLOperadorDatos),
                    typeof (SybaseOperadorDatos)
                });
                if (xmlSerializer.CanDeserialize((XmlReader)xmlTextReader))
                    sistemaList = (SistemaList)xmlSerializer.Deserialize((XmlReader)xmlTextReader);
                fileStream.Close();
            }
            catch (Exception)
            {
                 
            }
            return sistemaList;
        }
    }
}
