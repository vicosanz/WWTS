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
    public partial class FrmMantenimientoSimpleBase : FrmFormaBase, IOpcion
    {
        public string Tabla
        {
            set
            {
                string _titulo = value;
                Text = _titulo;
                ToolStriptitulo.Text = _titulo;
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
                FrmReporteBase_AplicarRestricciones(this, null);
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
                btnguardarnuevo.Visible = value;
            }
        }
        #endregion

        public ToolStrip ToolStrip => ToolStrip1;

        public MenuStrip MenuStrip => MenuStrip1;

        public Control Control => pnlcuerpo;

        public FrmMantenimientoSimpleBase()
        {
            InitializeComponent();

            AplicarRestricciones += FrmReporteBase_AplicarRestricciones;
        }

        private void FrmReporteBase_AplicarRestricciones(object sender, EventArgs e)
        {
            bool restrinuevo = (EsNuevo && Restriccion.Restri_Ingreso) || (!EsNuevo && Restriccion.Restri_Modificacion);
            btnguardar.Enabled = restrinuevo;
            guardarToolStripMenuItem.Enabled = restrinuevo;
            btnguardarnuevo.Enabled = restrinuevo;
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

        public event EventHandler GuardaryNuevo;
        private void Guardarnuevo_Click(object sender, EventArgs e)
        {
            GuardaryNuevo?.Invoke(this, null);
        }

        public event EventHandler Guardar;

        private void Guardar_Click(object sender, EventArgs e)
        {
            Guardar?.Invoke(this, null);
        }
    }
}
