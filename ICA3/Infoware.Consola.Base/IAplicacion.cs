using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public interface IAplicacion
    {
        bool Validacion(Usuario _Usuario);

        List<GrupoOpcion> CargarListaGrupoOpciones(Sistema _Sistema);

        event EventHandler<string> ActualizacionesMensaje;

        Task<bool> ComprobarActualizaciones();
    }
}
