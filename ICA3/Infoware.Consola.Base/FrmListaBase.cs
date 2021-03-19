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
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public partial class FrmListaBase : FrmFormaBase, IOpcion
    {
        public BindingSource ListBindingSource
        {
            get => BindingSource;
            set
            {
                BindingSource = value;
                if (value != null)
                {
                    BindingSource.CurrentChanged += Actualizar_Click;
                    BindingSource.DataSourceChanged += ListBindingSource_DataSourceChanged;
                }
            }
        }
        
        public string Titulo
        {
            set
            {
                string _titulo = value;
                Text = _titulo;
                ToolStriptitulo.Text = _titulo;
            }
        }

        public string AgregarLeyenda
        {
            set
            {
                LinkAgregar.Text = value;
            }
        }

        private bool mEsBusqueda = true;
        public bool EsBusqueda
        {
            get
            {
                return mEsBusqueda;
            }
            set
            {
                mEsBusqueda = value;
                btnseleccionar.Visible = mEsBusqueda;
            }
        }

        private string mDocSalida;
        public string DocSalida
        {
            get
            {
                return mDocSalida;
            }
            set
            {
                mDocSalida = value;
                btnword.Visible = !string.IsNullOrWhiteSpace(value);
                WordToolStripMenuItem1.Visible = !string.IsNullOrWhiteSpace(value);
            }
        }

        #region RestriccionesPorCodigo

        private bool mPuedeImprimir = true;
        public bool PuedeImprimir
        {
            get { return mPuedeImprimir; }
            set
            {
                mPuedeImprimir = value;
                btnimprimir.Visible = value;
                ImprimirToolStripMenuItem.Visible = value;
            }
        }

        private bool mPuedeNuevo = true;
        public bool PuedeNuevo
        {
            get { return mPuedeNuevo; }
            set
            {
                mPuedeNuevo = value;
                LinkAgregar.Visible = value;
                nuevoToolStripMenuItem.Visible = value;
            }
        }

        private bool mPuedeEliminar = true;
        public bool PuedeEliminar
        {
            get { return mPuedeEliminar; }
            set
            {
                mPuedeEliminar = value;
                btneliminar.Visible = value;
                eliminarToolStripMenuItem.Visible = value;
            }
        }

        private bool mPuedeRefrescar = true;
        public bool PuedeRefrescar
        {
            get { return mPuedeRefrescar; }
            set
            {
                mPuedeRefrescar = value;
                btnrefrescar.Visible = value;
                ActualizarToolStripMenuItem.Visible = value;
            }
        }
        #endregion

        public ToolStrip ToolStrip => ToolStrip1;

        public MenuStrip MenuStrip => MenuStrip1;

        public Control Control => pnlcuerpo;

        public FrmListaBase()
        {
            InitializeComponent();

            AplicarRestricciones += FrmReporteBase_AplicarRestricciones;
        }

        private void ListBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView1.AutoDiscover();
            lblmessage.Text = BindingSource !=null && BindingSource.Count>0 ? "" : $"{BindingSource.Count} registros presentados";
        }

        public void InitSistema(Sistema sistema, Restriccion restriccion, bool esBusqueda)
        {
            Sistema = sistema;
            Restriccion = restriccion;
            EsBusqueda = esBusqueda;
        }

        private void FrmReporteBase_AplicarRestricciones(object sender, EventArgs e)
        {
            btnimprimir.Enabled = Restriccion.Restri_Impresion;
            ImprimirToolStripMenuItem.Enabled = Restriccion.Restri_Impresion;

            ExportarToolStripMenuItem.Enabled = Restriccion.Restri_Impresion;
            btnexportar.Enabled = Restriccion.Restri_Impresion;

            btncorreo.Enabled = Restriccion.Restri_Impresion;
            CorreoToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion;

            btnword.Enabled = Restriccion.Restri_Impresion;
            WordToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion;
        }


        #region ExportarReporte
        private void Exportar_Click(object sender, EventArgs e)
        {
            ExportarReporte();
        }

        private void ExportarReporte()
        {
            DataGridView1.Excel(EnumSalida.Excel);
        }
        #endregion

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Imprimir
        private void Imprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
        }

        private void ImprimirReporte()
        {
            base.ImprimiReporte(DataGridView1);
            Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion);
        }
        #endregion

        #region Ayuda
        private void Ayuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }
        #endregion

        #region Word
        private void Word_Click(object sender, EventArgs e)
        {
            DataGridView1.Excel(EnumSalida.MailMerge, mDocSalida);
        }
        #endregion

        #region Correo
        private void Correo_Click(object sender, EventArgs e)
        {
            DataGridView1.Excel(EnumSalida.Correo);
        }
        #endregion

        #region Actualizar
        public event EventHandler Actualizar;

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Actualizar?.Invoke(this, null);
            SeleccionoFila?.Invoke(this, null);
        }
        #endregion

        #region SeleccionarAbrir
        public event EventHandler Seleccionar;
        public event EventHandler Abrir;

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.Handled = true;
                    if (mEsBusqueda)
                    {
                        Seleccionar?.Invoke(this, null);
                    }
                    else
                    {
                        OnAbrir();
                    }
                    break;
                case Keys.Insert:
                    e.Handled = true;
                    if (PuedeNuevo && Restriccion.Restri_Ingreso)
                    {
                        Agregar?.Invoke(this, null);
                    }
                    break;
                case Keys.Delete:
                    e.Handled = true;
                    if (PuedeEliminar && Restriccion.Restri_Eliminacion)
                    {
                        Eliminar?.Invoke(this, null);
                    }
                    break;
                default:
                    if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                    {
                        e.Handled = true;
                        btnbuscar.Visible = true;
                        btncancelarbuscar.Visible = false;
                        combobuscar.Focus();
                        if (e.KeyCode >= Keys.NumPad0 & e.KeyCode <= Keys.NumPad9)
                            combobuscar.Text = Convert.ToChar(Keys.D0 + (e.KeyCode - Keys.NumPad0)).ToString();
                        else
                            combobuscar.Text = Convert.ToChar(e.KeyCode).ToString();
                        combobuscar.SelectionStart = 1;
                        break;
                    }
                    e.Handled = false;
                    break;
            }
        }
        private void OnAbrir()
        {
            Abrir?.Invoke(this, null);
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnAbrir();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (EsBusqueda)
            {
                Seleccionar?.Invoke(this, null);
            }
            else
                OnAbrir();
        }
        #endregion

        #region Agregar
        public event EventHandler Agregar;

        private void LinkAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Agregar?.Invoke(this, null);
        }
        #endregion

        #region Eliminar
        public event EventHandler Eliminar;

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar?.Invoke(this, null);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar?.Invoke(this, null);
        }
        #endregion

        #region SeleccionoFila
        public event EventHandler SeleccionoFila;

        #endregion

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Buscar
        public event CancelEventHandler Buscar;

        private void Combobuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == "\r"[0])
            {
                Hacer_busqueda();
                e.Handled = true;
            }
        }

        private void Combobuscar_TextChanged(object sender, EventArgs e)
        {
            if (btncancelarbuscar.Visible)
            {
                btncancelarbuscar.Visible = false;
                btnbuscar.Visible = true;
            }
        }

        public void Hacer_busqueda()
        {
            CancelEventArgs ev = new CancelEventArgs();
            Buscar?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                if (!string.IsNullOrWhiteSpace(combobuscar.Text))
                {
                    headerStrip1.esBusqueda = true;
                    combobuscar.Items.Add(combobuscar.Text);
                    btncancelarbuscar.Visible = true;
                    btnbuscar.Visible = false;
                }
                else
                {
                    headerStrip1.esBusqueda = false;
                    btncancelarbuscar.Visible = false;
                    btnbuscar.Visible = true;
                }
                DataGridView1.Select();
            }
        }

        private void Combobuscar_Validated(object sender, EventArgs e)
        {
            Hacer_busqueda();
        }

        public event EventHandler CancelarBuscar;

        private void btncancelarbuscar_Click(object sender, EventArgs e)
        {
            headerStrip1.Visible = true;
            btnbuscar.Visible = true;
            btncancelarbuscar.Visible = false;
            CancelarBuscar?.Invoke(this, null);
        }
        #endregion

        #region Refrescar
        public event EventHandler Refrescar;
        public void RefrescarLista()
        {
            Refrescar?.Invoke(this, null);
        }
        #endregion

        public event EventHandler DespuesSeleccionarCampos;

        private void DataGridView1_DespuesSeleccionarCampos(object sender, EventArgs e)
        {
            DespuesSeleccionarCampos?.Invoke(this, null);
        }

    }
}
