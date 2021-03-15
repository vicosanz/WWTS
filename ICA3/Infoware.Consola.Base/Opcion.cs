using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Infoware.Reglas.General;
using WeifenLuo.WinFormsUI.Docking;

namespace Infoware.Consola.Base
{
    public class Opcion
    {
        private Opcion.DelegadoCargarOpcion mObjCargarOpcion;
        private Restriccion mRestriccion;
        private string mDescripcionAlternativa;
        private object mTag;

        public Restriccion Restriccion
        {
            get => this.mRestriccion;
            set => this.mRestriccion = value;
        }

        public string DescripcionAlternativa
        {
            get => this.mDescripcionAlternativa;
            set => this.mDescripcionAlternativa = value;
        }

        public Opcion.DelegadoCargarOpcion ObjCargarOpcion
        {
            get => this.mObjCargarOpcion;
            set => this.mObjCargarOpcion = value;
        }

        public object Tag
        {
            get => this.mTag;
            set => this.mTag = RuntimeHelpers.GetObjectValue(value);
        }

        public IDockContent CargarOpcion(Sistema _Sistema, Restriccion _Restriccion) => this.mObjCargarOpcion(_Sistema, _Restriccion, this);

        public Opcion(
          Restriccion _Restriccion,
          Opcion.DelegadoCargarOpcion _ObjCargarOpcion,
          string _DescripcionAlternativa = "",
          object _Tag = null)
        {
            this.Restriccion = _Restriccion;
            this.ObjCargarOpcion = _ObjCargarOpcion;
            this.DescripcionAlternativa = _DescripcionAlternativa;
            this.Tag = RuntimeHelpers.GetObjectValue(_Tag);
        }

        public delegate IDockContent DelegadoCargarOpcion(
          Sistema _Sistema,
          Restriccion _Restriccion,
          Opcion _Opcion);
    }
}
