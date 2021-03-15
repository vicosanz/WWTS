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
    public partial class FrmAyuda : Form
    {
        public string Titulo
        {
            get
            {
                return lbltitulo.Text;
            }
            set
            {
                lbltitulo.Text = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return txtdescripcion.Text;
            }
            set
            {
                txtdescripcion.Text = value;
            }
        }

        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
