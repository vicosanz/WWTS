using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infoware.Datos;
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public interface ISistema
    {
        string DirectorioRaiz { get; }

        string NombrePublico { get; }

        string NombreSistema { get; set; }

        string DescripcionSistema { get; set; }

        OperadorDatos OperadorDatos { get; set; }

        string Ensamblado { get; set; }

        Usuario Usuario { get; set; }

        string UsuarioString { get; set; }

        string ContrasenaString { get; set; }

        bool GuardarContrasena { get; set; }

        bool CargaralIniciar { get; set; }

        bool Probarconexion();

        IAplicacion SistemaObjeto { get; }
    }
}
