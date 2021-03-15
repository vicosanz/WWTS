using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Reglas;
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public partial class FrmMantenimientoBase : FrmFormaBase, IOpcion
    {
        public string Tabla
        {
            set
            {
                string _titulo = value;
                Text = _titulo;
            }
        }

        private bool mEsNuevo = false;
        public bool EsNuevo
        {
            get
            {
                return mEsNuevo;
            }
            set
            {
                mEsNuevo = value;
                Frm_AplicarRestricciones(this, null);
            }
        }

        #region RestriccionesPorCodigo

        private bool mPuedeGuardaryNuevo = true;
        public bool PuedeGuardaryNuevo
        {
            get { return mPuedeGuardaryNuevo; }
            set
            {
                mPuedeGuardaryNuevo = value;
                guardarYNuevoToolStripMenuItem.Visible = value;
                ToolStripGuardarnuevo.Visible = value;
            }
        }

        private bool mPuedeGuardar = true;
        public bool PuedeGuardar
        {
            get { return mPuedeGuardar; }
            set
            {
                mPuedeGuardar = value;
                guardarToolStripMenuItem.Visible = value;
                ToolStripGuardar.Visible = value;
            }
        }

        private bool mPuedeGuardaryCerrar = true;
        public bool PuedeGuardaryCerrar
        {
            get { return mPuedeGuardaryCerrar; }
            set
            {
                mPuedeGuardaryCerrar = value;
                guardarYcerrarToolStripMenuItem.Visible = value;
                ToolStripGuardarcerrar.Visible = value;
            }
        }

        private bool mPuedeMover = true;
        public bool PuedeMover
        {
            get { return mPuedeMover; }
            set
            {
                mPuedeMover = value;
                ToolStripAnterior.Visible = value;
                ToolStripSiguiente.Visible = value;
                ToolStripSeparatorMover.Visible = value;
            }
        }

        private bool mPuedeNuevo = true;
        public bool PuedeNuevo
        {
            get { return mPuedeNuevo; }
            set
            {
                mPuedeNuevo = value;
                ToolStripNuevo.Visible = value;
                NuevoToolStripMenuItem.Visible = value;
                ToolStripMenuItemSepNuevo.Visible = value;
            }
        }

        private bool mPuedeNuevoGeneral = true;
        public bool PuedeNuevoGeneral
        {
            get { return mPuedeNuevoGeneral; }
            set
            {
                mPuedeNuevoGeneral = value;
                ToolStripNuevoGeneral.Visible = value;
            }
        }

        private bool mPuedeEliminar = true;
        public bool PuedeEliminar
        {
            get { return mPuedeEliminar; }
            set
            {
                mPuedeEliminar = value;
                eliminarToolStripMenuItem.Visible = value;
            }
        }

        private bool mPuedeAnular = true;
        public bool PuedeAnular
        {
            get { return mPuedeAnular; }
            set
            {
                mPuedeAnular = value;
                ToolStripAnular.Visible = value;
            }
        }

        private bool mPuedeRefrescar = true;
        public bool PuedeRefrescar
        {
            get { return mPuedeRefrescar; }
            set
            {
                mPuedeRefrescar = value;
                ToolStripRefrescar.Visible = value;
            }
        }

        private bool mPuedeImprimir = true;
        public bool PuedeImprimir
        {
            get { return mPuedeImprimir; }
            set
            {
                mPuedeImprimir = value;
                ToolStripImprimir.Visible = value;
                ToolStripSeparatorImprimir.Visible = value;
            }
        }

        private bool mPuedeFormato = true;
        public bool PuedeFormato
        {
            get { return mPuedeFormato; }
            set
            {
                mPuedeFormato = value;
                ToolStripFormato.Visible = value;
            }
        }
        #endregion

        public ToolStrip ToolStrip => ToolStrip1;

        public MenuStrip MenuStrip => MenuStrip1;

        public Control Control => null;

        public FrmMantenimientoBase()
        {
            InitializeComponent();

            AplicarRestricciones += Frm_AplicarRestricciones;
        }

        public FrmMantenimientoBase(Sistema sistema, Restriccion restriccion)
        {
            InitializeComponent();

            AplicarRestricciones += Frm_AplicarRestricciones;
            Sistema = sistema;
            Restriccion = restriccion;
        }

        private void Frm_AplicarRestricciones(object sender, EventArgs e)
        {
            bool restrinuevo = (EsNuevo && Restriccion.Restri_Ingreso) || (!EsNuevo && Restriccion.Restri_Modificacion);
            guardarToolStripMenuItem.Enabled = restrinuevo;
            guardarYcerrarToolStripMenuItem.Enabled = restrinuevo;
            guardarYNuevoToolStripMenuItem.Enabled = restrinuevo;
            ToolStripGuardar.Enabled = restrinuevo;
            ToolStripGuardarcerrar.Enabled = restrinuevo;
            ToolStripGuardarnuevo.Enabled = restrinuevo;

            ToolStripImprimir.Enabled = Restriccion.Restri_Impresion;

            ToolStripAnular.Enabled = Restriccion.Restri_Eliminacion;
            eliminarToolStripMenuItem.Enabled = Restriccion.Restri_Eliminacion;
        }

        #region Ayuda
        private void Ayuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }
        #endregion

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Guardar
        public event CancelEventHandler Guardar;

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private bool GuardarCambios()
        {
            CancelEventArgs ev = new CancelEventArgs();
            Guardar?.Invoke(this, ev);
            return !ev.Cancel;
        }

        private void Guardarnuevo_Click(object sender, EventArgs e)
        {
            if (GuardarCambios())
            {
                Crear_Nuevo();
            }
        }
        
        private void Guardarcerrar_Click(object sender, EventArgs e)
        {
            if (GuardarCambios())
            {
                Close();
            }
        }
        #endregion

        #region Nuevo
        public event AddingNewEventHandler CrearNuevo;

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Crear_Nuevo();
        }

        public void Crear_Nuevo()
        {
            AddingNewEventArgs ev = new AddingNewEventArgs();
            CrearNuevo?.Invoke(this, ev);
            ListBindingSource.Add(ev.NewObject);
            ListBindingSource.MoveLast();
        }
        #endregion

        #region Events
        public event EventHandler Imprimir;

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Imprimir?.Invoke(this, null);
        }

        public event EventHandler ModificarFormato;

        private void Formato_Click(object sender, EventArgs e)
        {
            ModificarFormato?.Invoke(this, null);
        }

        public event EventHandler Eliminar;

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar?.Invoke(this, null);
        }
        #endregion

        #region Actualizar
        public event EventHandler Refrescar;

        private void Refrescar_Click(object sender, EventArgs e)
        {
            Refrescar?.Invoke(this, null);
        }
        #endregion

        #region Anular
        public event EventHandler Anular;

        private void Anular_Click(object sender, EventArgs e)
        {
            Anular?.Invoke(this, null);
        }
        #endregion

        #region Binding
        public event EventHandler Actualizar;
        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            ValidarRegistro();
            Actualizar?.Invoke(this, null);
        }

        private void ValidarRegistro()
        {
            ToolStripAnterior.Enabled = false;
            ToolStripSiguiente.Enabled = false;
            if (ListBindingSource == null || ListBindingSource.Current == null)
            {
                return;
            }
            if (PuedeMover)
            {
                ToolStripAnterior.Enabled = true;
                ToolStripSiguiente.Enabled = true;
            }

            mEsNuevo = false;
            if (ListBindingSource.Current is _Database)
            {
                mEsNuevo = ((_Database)ListBindingSource.Current).EsNuevo;
            }
            Frm_AplicarRestricciones(this, null);
        }
        #endregion

        #region Mover
        public event CancelEventHandler Anterior;

        private void Anterior_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            Anterior?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                ListBindingSource.MovePrevious();
            }
        }

        public event CancelEventHandler Siguiente;

        private void Siguiente_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            Siguiente?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                ListBindingSource.MoveNext();
            }
        }

        public event CancelEventHandler Primero;

        private void Primero_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            Primero?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                ListBindingSource.MoveFirst();
            }
        }

        public event CancelEventHandler Ultimo;

        private void Ultimo_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            Ultimo?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                ListBindingSource.MoveLast();
            }
        }

        #endregion

    }
}
