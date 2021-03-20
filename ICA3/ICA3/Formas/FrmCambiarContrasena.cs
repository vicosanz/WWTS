using System;
using System.Windows.Forms;
using Infoware.Reglas.General;

namespace ICA3.Formas
{
    public partial class FrmCambiarContrasena : Form
    {
        public Usuario Usuario { get; set; }
        public FrmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnueva.Text != txtconfirmar.Text)
                {
                    throw new Exception("La contraseña nueva y la confirmación deben ser iguales. Por favor redigítelas");
                }
                if (string.IsNullOrWhiteSpace(txtnueva.Text))
                {
                    throw new Exception("La contraseña no puede estar en blanco");
                }
                Usuario.Usuari_Password = txtnueva.Text.Trim();
                if (!Usuario.CambiarContrasena())
                {
                    throw new Exception("La contraseña no pudo ser cambiada, debe ser diferente a las últimas ingresadas");
                }
                Usuario.Usuari_CambiarContrasena = false;
                Usuario.Guardar();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Usuario.Usuari_CambiarContrasena = false;
            Usuario.Guardar();
            DialogResult = DialogResult.Cancel;
        }
    }
}
