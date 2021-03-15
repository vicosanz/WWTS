using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Consola.Base;

namespace ICA3.Formas
{
    public partial class FrmSistemasLogin : Form
    {
        private Sistema mSistema;

        public Sistema Sistema
        {
            get { return mSistema; }
            set
            {
                mSistema = value;
                llenar_datos();
            }
        }

        private void llenar_datos()
        {
            chkSeguridadWindows.Checked = mSistema.SeguridadWindows;
            txtnombreusuario.Text = mSistema.UsuarioString;
            txtcontrasena.Text = mSistema.ContrasenaString;
            chkguardarcontrasena.Checked = mSistema.GuardarContrasena;
            if (!string.IsNullOrEmpty(txtnombreusuario.Text))
                txtcontrasena.Select();
        }

        private void mapear_datos()
        {
            mSistema.SeguridadWindows = chkSeguridadWindows.Checked;
            mSistema.UsuarioString = txtnombreusuario.Text;
            mSistema.ContrasenaString = txtcontrasena.Text;

            mSistema.GuardarContrasena = chkguardarcontrasena.Checked;
        }


        public FrmSistemasLogin()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                mapear_datos();
                if (!mSistema.Probarconexion())
                {
                    throw new Exception(mSistema.MensajeError);
                }

                if (mSistema.Usuario.Usuari_CambiarContrasena)
                {
                    FrmCambiarContrasena f = new FrmCambiarContrasena()
                    {
                        Usuario = mSistema.Usuario
                    };
                    if (f.ShowDialog() != DialogResult.OK)
                    {
                        mSistema.ContrasenaString = string.Empty;
                        throw new Exception("Error al cambiar la contraseña");
                    }
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void chkSeguridadWindows_CheckedChanged(object sender, EventArgs e)
        {
            FlowUserPassword.Enabled = !chkSeguridadWindows.Checked;
        }
    }
}
