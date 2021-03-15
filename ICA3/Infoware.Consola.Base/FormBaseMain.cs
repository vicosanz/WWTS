using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Infoware.Consola.Base
{
    public partial class FormBaseMain : FrmFormaBase
    {
        public DockPanel MainDockPanel {
            get
            {
                return dockPanel1;
            }
        }

        public FormBaseMain()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region BarraDeEstado
        private void BarraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraDeEstadoToogle(BarraDeEstadoToolStripMenuItem.Checked);
        }

        private void BarraDeEstadoToogle(bool status)
        {
            StatusStrip.Visible = status;
            BarraDeEstadoToolStripMenuItem.Checked = status;
        }
        #endregion

        #region PantallaCompleta
        public bool EsPantallaCompleta { get; set; } = false;
        public event EventHandler<bool> OnPantallaCompleta;

        private void PantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaCompletaToogle(!EsPantallaCompleta);
        }

        private void PantallaCompletaToogle(bool status)
        {
            Visible = false;
            EsPantallaCompleta = status;
            PantallaCompletaToolStripMenuItem1.Visible = status;
            PantallaCompletaToolStripMenuItem1.Checked = status;

            BarraDeEstadoToogle(!status);
            BarraEstandarToogle(!status);

            PerformPantallaCompleta(EsPantallaCompleta);
            Visible = true;
        }

        protected virtual void PerformPantallaCompleta(bool status)
        {
            OnPantallaCompleta?.Invoke(this, status);
        }

        private void PantallaCompletaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PantallaCompletaToogle(!EsPantallaCompleta);

        }
        #endregion

        #region BarraEstandar
        private void EstandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstandarToogle(EstandarToolStripMenuItem.Checked);
        }

        private void BarraEstandarToogle(bool status)
        {
            BarraEstandar.Visible = status;
            EstandarToolStripMenuItem.Checked = status;
        }
        #endregion

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {
            Conectadoa("");
            if (!(sender is DockPanel))
            {
                return;
            }
            DockPanel _panel = (DockPanel)sender;
            if (_panel.ActiveDocument is null)
            {
                return;
            }
            FrmFormaBase _formabase = (FrmFormaBase)_panel.ActiveDocument;
            Conectadoa(_formabase.Sistema.OperadorDatos.Descripcion);
        }

        private void Conectadoa(string _mensaje)
        {
            if (string.IsNullOrWhiteSpace(_mensaje))
            {
                lblNoConectado.Visible = true;
                lbl_contectadoa.Visible = false;
            }
            else
            {
                lblNoConectado.Visible = false;
                lbl_contectadoa.Visible = true;
                lbl_contectadoa.Text = $"Conectado a: {_mensaje}";
            }
        }
    }
}
