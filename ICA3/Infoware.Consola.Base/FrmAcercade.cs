using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoware.Consola.Base
{
    public partial class FrmAcercade : Form
    {
        public FrmAcercade()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAcercade_Load(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string ApplicationTitle = ((AssemblyTitleAttribute)asm.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title;
            if (string.IsNullOrWhiteSpace(ApplicationTitle)){
                ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().FullName);
            }
            Text = string.Format("Acerca de {0}", ApplicationTitle);
            LabelProductName.Text = FileVersionInfo.GetVersionInfo(asm.Location).ProductName;
            LabelVersion.Text = string.Format("Version {0}", FileVersionInfo.GetVersionInfo(asm.Location).FileVersion);
            LabelCopyright.Text = GetCopyright();
            LabelCompanyName.Text = GetCompany();
            TextBoxDescription.Text = FileVersionInfo.GetVersionInfo(asm.Location).FileDescription;
        }

        private string GetCopyright()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            object[] obj = asm.GetCustomAttributes(false);
            foreach (object o in obj)
            {
                if (o.GetType() == typeof(AssemblyCopyrightAttribute))
                {
                    AssemblyCopyrightAttribute aca = (AssemblyCopyrightAttribute)o;
                    return aca.Copyright;
                }
            }
            return string.Empty;
        }

        private string GetCompany()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            object[] obj = asm.GetCustomAttributes(false);
            foreach (object o in obj)
            {
                if (o.GetType() == typeof(AssemblyCompanyAttribute))
                {
                    AssemblyCompanyAttribute aca = (AssemblyCompanyAttribute)o;
                    return aca.Company;
                }
            }
            return string.Empty;
        }

    }
}
