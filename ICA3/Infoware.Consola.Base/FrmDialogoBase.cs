using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoware.Consola.Base
{
    public partial class FrmDialogoBase : FrmFormaBase
    {
        public event CancelEventHandler AntesAceptar;
        public event CancelEventHandler AntesCancelar;

        public string TextoAceptar
        {
            get
            {
                return OK_Button.Text;
            }
            set
            {
                OK_Button.Text = value;
            }
        }

        public FrmDialogoBase()
        {
            InitializeComponent();
        }

        private void FrmDialogoBase_Load(object sender, EventArgs e)
        {

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            AntesAceptar?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            AntesCancelar?.Invoke(this, ev);
            if (!ev.Cancel)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
