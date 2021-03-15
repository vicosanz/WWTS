using Infoware.Reglas.General;
using System.Collections.Generic;

namespace Infoware.Consola.Base
{
    public class GrupoOpcion
    {
        private ParametroDet mGrupoOpcion;
        private List<Opcion> mOpciones;
        private List<Opcion> mOpcionesFavoritos;
        private List<Opcion> mOpcionesReportes;

        public ParametroDet GrupoOpciones
        {
            get => this.mGrupoOpcion;
            set => this.mGrupoOpcion = value;
        }

        public List<Opcion> Opciones
        {
            get => this.mOpciones;
            set => this.mOpciones = value;
        }

        public List<Opcion> OpcionesFavoritos
        {
            get => this.mOpcionesFavoritos;
            set => this.mOpcionesFavoritos = value;
        }

        public List<Opcion> OpcionesReportes
        {
            get => this.mOpcionesReportes;
            set => this.mOpcionesReportes = value;
        }

        public GrupoOpcion(ParametroDet _GrupoOpcion, List<Opcion> _Opciones)
        {
            this.GrupoOpciones = _GrupoOpcion;
            this.Opciones = _Opciones;
            this.OpcionesFavoritos = new List<Opcion>();
            this.OpcionesReportes = new List<Opcion>();
        }

        public GrupoOpcion(
          ParametroDet _GrupoOpcion,
          List<Opcion> _Opciones,
          List<Opcion> _OpcionesFavoritos,
          List<Opcion> _OpcionesReportes)
        {
            this.GrupoOpciones = _GrupoOpcion;
            this.Opciones = _Opciones;
            this.OpcionesFavoritos = _OpcionesFavoritos;
            this.OpcionesReportes = _OpcionesReportes;
        }
    }
}
