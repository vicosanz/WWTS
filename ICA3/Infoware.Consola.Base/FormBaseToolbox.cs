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
    public partial class FormBaseToolbox : DockContent
    {
        public FormBaseToolbox()
        {
            InitializeComponent();
            HideOnClose = true;
        }
    }
}
