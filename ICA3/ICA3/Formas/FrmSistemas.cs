using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Consola.Base;
using Infoware.Datos;

namespace ICA3.Formas
{
    public partial class FrmSistemas : Form
    {
        private Sistema mSistema;
        //private bool _cargolistasql = false;

        public Sistema Sistema
        {
            get { return mSistema; }
            set
            {
                mSistema = value;
                llenar_datos();
            }
        }

        public string Ensamblado
        {
            get => txtarchivoensamblado.Text;
            set => txtarchivoensamblado.Text = value;
        }

        private void llenar_datos()
        {
            txtnombresistema.Text = mSistema.NombreSistema;
            txtdescripcionsistema.Text = mSistema.DescripcionSistema;
            chkSeguridadWindows.Checked = mSistema.SeguridadWindows;
            txtnombreusuario.Text = mSistema.UsuarioString;
            txtcontrasena.Text = mSistema.ContrasenaString;
            chkguardarcontrasena.Checked = mSistema.GuardarContrasena;
            chkcargaraliniciar.Checked = mSistema.CargaralIniciar;

            txtarchivoensamblado.Text = mSistema.Ensamblado;

            cboproveedor.ComboBoxStd1.Items.Clear();
            cboproveedor.ComboBoxStd1.Items.Add("SQL Server");
            cboproveedor.ComboBoxStd1.Items.Add("Oracle");
            cboproveedor.ComboBoxStd1.Items.Add("Sybase");
            cboproveedor.ComboBoxStd1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboproveedor.ComboBoxStd1.SelectedIndex = 0;

            if (mSistema.OperadorDatos != null)
            {
                cboproveedor.ComboBoxStd1.SelectedIndex = (int)mSistema.OperadorDatos.Proveedor;
                cboservidor.Text = mSistema.OperadorDatos.Servidor;
                txtnombreusuariobd.Text = mSistema.OperadorDatos.Usuario;
                txtcontrasenabd.Text = mSistema.OperadorDatos.Clave;
                chkSeguridadIntegrada.Checked = mSistema.OperadorDatos.SeguridadIntegrada;
                txtbasedatos.Text = mSistema.OperadorDatos.Base;
                chkguardarcontrasenabd.Checked = mSistema.OperadorDatos.GuardarContrasena;
                txtDirectorioReplicacion.Text = mSistema.OperadorDatos.DirectorioReplicacion;
                txtSufijoReplicacion.Text = mSistema.OperadorDatos.SufijoReplicacion;
            }

            if (!string.IsNullOrEmpty(txtnombreusuario.Text))
            {
                txtcontrasena.Select();
            }
        }

        private void mapear_datos()
        {
            mSistema.NombreSistema = txtnombresistema.Text;
            mSistema.DescripcionSistema = txtdescripcionsistema.Text;
            mSistema.SeguridadWindows = chkSeguridadWindows.Checked;
            mSistema.UsuarioString = txtnombreusuario.Text;
            mSistema.ContrasenaString = txtcontrasena.Text;
            mSistema.GuardarContrasena = chkguardarcontrasena.Checked;
            mSistema.CargaralIniciar = chkguardarcontrasena.Checked && chkcargaraliniciar.Checked;

            mSistema.Ensamblado = txtarchivoensamblado.Text;
            mSistema.OperadorDatos = OperadorDatosFactory.CrearInstancia((enumProveedorDatos)cboproveedor.ComboBoxStd1.SelectedIndex, cboservidor.Text, txtbasedatos.Text, 
                txtnombreusuariobd.Text, txtcontrasenabd.Text, chkSeguridadIntegrada.Checked);
            mSistema.OperadorDatos.DirectorioReplicacion = txtDirectorioReplicacion.Text;
            mSistema.OperadorDatos.SufijoReplicacion = txtSufijoReplicacion.Text;
            if (!string.IsNullOrWhiteSpace(txtDirectorioReplicacion.Text))
                if (!Directory.Exists(txtDirectorioReplicacion.Text) || string.IsNullOrWhiteSpace(txtSufijoReplicacion.Text))
                    throw new Exception("Debe ingresar un directorio de replicación váldo y un Sufijo");

        }

        public FrmSistemas()
        {
            InitializeComponent();
        }

        private void btnprobar_Click(object sender, EventArgs e)
        {
            try
            {
                mapear_datos();
                if (!Sistema.Probarconexion())
                {
                    throw new Exception($"{mSistema.MensajeError} {mSistema.OperadorDatos.MsgError}");
                }
                if (!Sistema.SeguridadWindows && mSistema.Usuario.Usuari_CambiarContrasena)
                {
                    FrmCambiarContrasena f = new FrmCambiarContrasena()
                    {
                        Usuario = mSistema.Usuario
                    };
                    if (f.ShowDialog() != DialogResult.OK)
                    {
                        throw new Exception("Error al cambiar la contraseña");
                    }
                }
                MessageBox.Show("Todas las pruebas fueron satisfactorias", "Información");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                mapear_datos();
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
            flowUserPassword.Enabled = !chkSeguridadWindows.Checked;
        }

        private void chkSeguridadIntegrada_CheckedChanged(object sender, EventArgs e)
        {
            txtnombreusuariobd.Enabled = !chkSeguridadIntegrada.Checked;
            txtcontrasenabd.Enabled = !chkSeguridadIntegrada.Checked;
        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Multiselect = false;
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "Ejecutable compatible (*.exe)|*.exe|Libreria compatible (*.dll)|*.dll|Todos los archivos (*.*)|*.*";

            if (OpenFileDialog1.ShowDialog()== DialogResult.OK)
            {
                txtarchivoensamblado.Text = OpenFileDialog1.FileName;
            }
        }

        private void chkguardarcontrasena_CheckedChanged(object sender, EventArgs e)
        {
            chkcargaraliniciar.Enabled = chkguardarcontrasena.Checked;
        }

        private void ButtonStd1_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectorioReplicacion.Text = FolderBrowserDialog1.SelectedPath;
            }
        }

        private void FlowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Servidor_AbrioCombo(object sender, EventArgs e)
        {
            //if (cboproveedor.ComboBoxStd1.SelectedIndex == 0 && !_cargolistasql)
            //{
            //    cboservidor.ComboBoxStd1.Items.Clear();
            //    AutoCompleteStringCollection _complete = new AutoCompleteStringCollection();
                
            //    System.Data.Sql.SqlDataSourceEnumerator x = System.Data.Sql.SqlDataSourceEnumerator.Instance;
            //    foreach(DataRow _dr in x.GetDataSources().Rows)
            //    {
            //        string _servidor;
            //        if (_dr[1] is DBNull)
            //        {
            //            _servidor = $"{_dr[0].ToString().Trim()}";
            //        }
            //        else
            //        {
            //            _servidor = $"{_dr[0].ToString().Trim()}\\{_dr[1].ToString().Trim()}";
            //        }
            //        _complete.Add(_servidor);
            //        cboservidor.ComboBoxStd1.Items.Add(_servidor);
            //    }

            //    cboservidor.ComboBoxStd1.AutoCompleteCustomSource = _complete;
            //    _cargolistasql = true;
            //}
            //if (cboproveedor.ComboBoxStd1.SelectedIndex != 0 && _cargolistasql)
            //{
            //    cboservidor.ComboBoxStd1.Items.Clear();
            //    cboservidor.ComboBoxStd1.AutoCompleteCustomSource = null;
            //    _cargolistasql = false;
            //}
        }
    }
}
