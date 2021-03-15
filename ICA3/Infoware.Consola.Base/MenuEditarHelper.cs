using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Infoware.Consola.Base
{
    public partial class MenuEditarHelper : System.Windows.Forms.ToolStripMenuItem
    {
        public const int WM_USER = 1024;
        public const int EM_CUT = 768;
        public const int EM_COPY = 769;
        public const int EM_PASTE = 770;
        public const int EM_CLEAR = 771;
        public const int EM_UNDO = 772;
        public const int EM_CANUNDO = 198;
        public const int EM_CANPASTE = 1074;
        public const int EM_GETTEXTLENGTHEX = 1119;

        public enum EnumOpcionesEdicion
        {
            Deshacer,
            Rehacer,
            Cortar,
            Copiar,
            Pegar,
            SeleccionarTodo,
        }

        public MenuEditarHelper()
        {
            InitializeComponent();
            DropDownOpening += MenuEditarHelper_DropDownOpening;
            DropDownClosed += MenuEditarHelper_DropDownClosed;
            DeshacerToolStripMenuItem.Click += DeshacerToolStripMenuItem_Click;
            RehacerToolStripMenuItem.Click += RehacerToolStripMenuItem_Click;
            CortarToolStripMenuItem.Click += CortarToolStripMenuItem_Click;
            CopiarToolStripMenuItem.Click += CopiarToolStripMenuItem_Click;
            PegarToolStripMenuItem.Click += PegarToolStripMenuItem_Click;
            SelectallToolStripMenuItem.Click += SelectallToolStripMenuItem_Click;
        }

        #region MenuAcciones
        private void SelectallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEdicion(EnumOpcionesEdicion.SeleccionarTodo);
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEdicion(EnumOpcionesEdicion.Pegar);
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEdicion(EnumOpcionesEdicion.Copiar);
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEdicion(EnumOpcionesEdicion.Cortar);
        }

        private void RehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEdicion(EnumOpcionesEdicion.Rehacer);
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEdicion(EnumOpcionesEdicion.Deshacer);
        }

        private void AccionEdicion(EnumOpcionesEdicion opcion)
        {
            IntPtr hControl = GetFocus();
            Control ctlFocus = GetFrameworkControl(hControl);
            if (ctlFocus is TextBoxBase)
            {
                DoTextBoxCommand((TextBoxBase)ctlFocus, opcion);
            }
            else if (ctlFocus is ComboBox && ((ComboBox)ctlFocus).DropDownStyle == ComboBoxStyle.DropDown)
            {
                DoComboBoxCommand(hControl, (ComboBox)ctlFocus, opcion);
            }
            else
            {
                ISupportsEdit ctlEdit = GetISupportsEditControl(ctlFocus);
                if (ctlEdit != null)
                {
                    DoISupportEditCommand(ctlEdit, opcion);
                }
            }
        }

        private void DoISupportEditCommand(ISupportsEdit ctlEdit, EnumOpcionesEdicion opcion)
        {
            switch (opcion)
            {
                case EnumOpcionesEdicion.Deshacer:
                    ctlEdit.Undo();
                    break;
                case EnumOpcionesEdicion.Rehacer:
                    ctlEdit.Redo();
                    break;
                case EnumOpcionesEdicion.Cortar:
                    ctlEdit.Cut();
                    break;
                case EnumOpcionesEdicion.Copiar:
                    ctlEdit.Copy();
                    break;
                case EnumOpcionesEdicion.Pegar:
                    ctlEdit.Paste();
                    break;
                case EnumOpcionesEdicion.SeleccionarTodo:
                    ctlEdit.SelectAll();
                    break;
            }
        }

        private void DoComboBoxCommand(IntPtr hControl, ComboBox ctlFocus, EnumOpcionesEdicion opcion)
        {
            switch (opcion)
            {
                case EnumOpcionesEdicion.Deshacer:
                    SendMessage(hControl, EM_UNDO, 0, 0);
                    break;
                case EnumOpcionesEdicion.Cortar:
                    SendMessage(hControl, EM_CUT, 0, 0);
                    break;
                case EnumOpcionesEdicion.Copiar:
                    SendMessage(hControl, EM_COPY, 0, 0);
                    break;
                case EnumOpcionesEdicion.Pegar:
                    SendMessage(hControl, EM_PASTE, 0, 0);
                    break;
                case EnumOpcionesEdicion.SeleccionarTodo:
                    ctlFocus.SelectAll();
                    break;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);


        private void DoTextBoxCommand(TextBoxBase ctlFocus, EnumOpcionesEdicion opcion)
        {
            switch (opcion)
            {
                case EnumOpcionesEdicion.Deshacer:
                    ctlFocus.Undo();
                    break;
                case EnumOpcionesEdicion.Rehacer:
                    if (!(ctlFocus is RichTextBox))
                        break;
                    ((RichTextBox)ctlFocus).Redo();
                    break;
                case EnumOpcionesEdicion.Cortar:
                    ctlFocus.Cut();
                    break;
                case EnumOpcionesEdicion.Copiar:
                    ctlFocus.Copy();
                    break;
                case EnumOpcionesEdicion.Pegar:
                    ctlFocus.Paste();
                    break;
                case EnumOpcionesEdicion.SeleccionarTodo:
                    ctlFocus.SelectAll();
                    break;
            }
        }
        #endregion

        #region Enable
        private void MenuEditarHelper_DropDownClosed(object sender, EventArgs e)
        {
            this.DeshacerToolStripMenuItem.Enabled = true;
            this.RehacerToolStripMenuItem.Enabled = true;
            this.CortarToolStripMenuItem.Enabled = true;
            this.CopiarToolStripMenuItem.Enabled = true;
            this.PegarToolStripMenuItem.Enabled = true;
            this.SelectallToolStripMenuItem.Enabled = true;
        }

        private void MenuEditarHelper_DropDownOpening(object sender, EventArgs e)
        {
            this.DeshacerToolStripMenuItem.Enabled = this.PuedeEdicion();
            this.RehacerToolStripMenuItem.Enabled = this.PuedeEdicion();
            this.CortarToolStripMenuItem.Enabled = this.PuedeEdicion();
            this.CopiarToolStripMenuItem.Enabled = this.PuedeEdicion();
            this.PegarToolStripMenuItem.Enabled = this.PuedeEdicion();
            this.SelectallToolStripMenuItem.Enabled = this.PuedeEdicion();
        }
        #endregion

        private bool PuedeEdicion()
        {
            bool result = false;
            Control ctlFocus = GetFrameworkControl(GetFocus());
            if (ctlFocus is TextBoxBase)
                result = true;
            else if (ctlFocus is ComboBox && ((ComboBox)ctlFocus).DropDownStyle == ComboBoxStyle.DropDown)
                result = true;
            else if (ctlFocus is DataGridView)
                result = true;
            else if (GetISupportsEditControl(ctlFocus) != null)
                result = true;
            return result;
        }

        private Control GetFrameworkControl(IntPtr hControl)
        {
            Control control = null;
            if (hControl.ToInt32() != 0)
                control = Control.FromHandle(hControl) ?? GetFrameworkControl(GetParent(hControl));
            return control;
        }

        [DllImport("user32", SetLastError = true)]
        public static extern IntPtr GetParent(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetFocus();

        public ISupportsEdit GetISupportsEditControl(Control ctlFocus)
        {
            while (!(ctlFocus is ISupportsEdit) && ctlFocus != null)
                ctlFocus = ctlFocus.Parent;
            return (ISupportsEdit)ctlFocus;
        }

    }
}
