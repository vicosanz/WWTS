using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Infoware.Consola.Base
{
    public partial class FormBaseMain : FrmFormaBase, IMessageFilter
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
            MoveFromControls.Add(lblTitle);
            Resize += FrmHome_Resize;
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

        #region controlbox
        private void mnuMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mnuMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void mnuRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region MoveForm Title less
        private void FrmHome_Resize(object sender, EventArgs e)
        {
            mnuMaximizar.Visible = WindowState != FormWindowState.Maximized;
            mnuRestaurar.Visible = WindowState == FormWindowState.Maximized;
        }

        private HashSet<Control> MoveFromControls = new HashSet<Control>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN && MoveFromControls.Contains(FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
        }
        #endregion

    }
}
