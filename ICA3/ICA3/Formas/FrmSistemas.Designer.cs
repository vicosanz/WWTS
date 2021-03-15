namespace ICA3.Formas
{
    partial class FrmSistemas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxHeader4 = new Infoware.Controles.Base.GroupBoxHeader();
            this.FlowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtarchivoensamblado = new Infoware.Controles.Base.LblTextBoxStd();
            this.btnexaminar = new Infoware.Controles.Base.ButtonStd();
            this.GroupBoxHeader3 = new Infoware.Controles.Base.GroupBoxHeader();
            this.FlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboproveedor = new Infoware.Controles.Base.LblComboBoxStd();
            this.cboservidor = new Infoware.Controles.Base.LblComboBoxStd();
            this.txtbasedatos = new Infoware.Controles.Base.LblTextBoxStd();
            this.txtnombreusuariobd = new Infoware.Controles.Base.LblTextBoxStd();
            this.txtcontrasenabd = new Infoware.Controles.Base.LblTextBoxStd();
            this.chkSeguridadIntegrada = new Infoware.Controles.Base.CheckBoxStd();
            this.chkguardarcontrasenabd = new Infoware.Controles.Base.CheckBoxStd();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBoxHeader2 = new Infoware.Controles.Base.GroupBoxHeader();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnombresistema = new Infoware.Controles.Base.LblTextBoxStd();
            this.txtdescripcionsistema = new Infoware.Controles.Base.LblTextBoxStd();
            this.GroupBoxHeader1 = new Infoware.Controles.Base.GroupBoxHeader();
            this.flowUserPassword = new System.Windows.Forms.FlowLayoutPanel();
            this.txtnombreusuario = new Infoware.Controles.Base.LblTextBoxStd();
            this.txtcontrasena = new Infoware.Controles.Base.LblTextBoxStd();
            this.chkguardarcontrasena = new Infoware.Controles.Base.CheckBoxStd();
            this.chkcargaraliniciar = new Infoware.Controles.Base.CheckBoxStd();
            this.FlowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSeguridadWindows = new Infoware.Controles.Base.CheckBoxStd();
            this.GroupBoxHeader5 = new Infoware.Controles.Base.GroupBoxHeader();
            this.FlowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDirectorioReplicacion = new Infoware.Controles.Base.LblTextBoxStd();
            this.ButtonStd1 = new Infoware.Controles.Base.ButtonStd();
            this.txtSufijoReplicacion = new Infoware.Controles.Base.LblTextBoxStd();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btncancelar = new Infoware.Controles.Base.ButtonStd();
            this.btnguardar = new Infoware.Controles.Base.ButtonStd();
            this.btnprobar = new Infoware.Controles.Base.ButtonStd();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupBoxHeader4.SuspendLayout();
            this.FlowLayoutPanel4.SuspendLayout();
            this.GroupBoxHeader3.SuspendLayout();
            this.FlowLayoutPanel3.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBoxHeader2.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.GroupBoxHeader1.SuspendLayout();
            this.flowUserPassword.SuspendLayout();
            this.FlowLayoutPanel6.SuspendLayout();
            this.GroupBoxHeader5.SuspendLayout();
            this.FlowLayoutPanel5.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxHeader4
            // 
            this.GroupBoxHeader4.Controls.Add(this.FlowLayoutPanel4);
            this.GroupBoxHeader4.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxHeader4.Location = new System.Drawing.Point(13, 245);
            this.GroupBoxHeader4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHeader4.Name = "GroupBoxHeader4";
            this.GroupBoxHeader4.Padding = new System.Windows.Forms.Padding(20, 12, 4, 4);
            this.GroupBoxHeader4.Size = new System.Drawing.Size(501, 113);
            this.GroupBoxHeader4.TabIndex = 1;
            this.GroupBoxHeader4.TabStop = false;
            this.GroupBoxHeader4.Text = "Directorio";
            // 
            // FlowLayoutPanel4
            // 
            this.FlowLayoutPanel4.Controls.Add(this.txtarchivoensamblado);
            this.FlowLayoutPanel4.Controls.Add(this.btnexaminar);
            this.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel4.Location = new System.Drawing.Point(20, 27);
            this.FlowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanel4.Name = "FlowLayoutPanel4";
            this.FlowLayoutPanel4.Size = new System.Drawing.Size(477, 82);
            this.FlowLayoutPanel4.TabIndex = 0;
            // 
            // txtarchivoensamblado
            // 
            this.txtarchivoensamblado.Caption = "&Directorio de ensamblados:";
            this.txtarchivoensamblado.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtarchivoensamblado.esPassword = false;
            this.txtarchivoensamblado.Location = new System.Drawing.Point(5, 5);
            this.txtarchivoensamblado.Margin = new System.Windows.Forms.Padding(5);
            this.txtarchivoensamblado.MultiLine = false;
            this.txtarchivoensamblado.Name = "txtarchivoensamblado";
            this.txtarchivoensamblado.Size = new System.Drawing.Size(330, 22);
            this.txtarchivoensamblado.TabIndex = 0;
            // 
            // btnexaminar
            // 
            this.btnexaminar.Location = new System.Drawing.Point(4, 36);
            this.btnexaminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(160, 23);
            this.btnexaminar.TabIndex = 1;
            this.btnexaminar.Text = "&Examinar";
            this.btnexaminar.UseVisualStyleBackColor = true;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click);
            // 
            // GroupBoxHeader3
            // 
            this.GroupBoxHeader3.Controls.Add(this.FlowLayoutPanel3);
            this.GroupBoxHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxHeader3.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxHeader3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHeader3.Name = "GroupBoxHeader3";
            this.GroupBoxHeader3.Padding = new System.Windows.Forms.Padding(20, 12, 4, 4);
            this.GroupBoxHeader3.Size = new System.Drawing.Size(501, 233);
            this.GroupBoxHeader3.TabIndex = 0;
            this.GroupBoxHeader3.TabStop = false;
            this.GroupBoxHeader3.Text = "Conectar a base de datos";
            // 
            // FlowLayoutPanel3
            // 
            this.FlowLayoutPanel3.Controls.Add(this.cboproveedor);
            this.FlowLayoutPanel3.Controls.Add(this.cboservidor);
            this.FlowLayoutPanel3.Controls.Add(this.txtbasedatos);
            this.FlowLayoutPanel3.Controls.Add(this.txtnombreusuariobd);
            this.FlowLayoutPanel3.Controls.Add(this.txtcontrasenabd);
            this.FlowLayoutPanel3.Controls.Add(this.chkSeguridadIntegrada);
            this.FlowLayoutPanel3.Controls.Add(this.chkguardarcontrasenabd);
            this.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel3.Location = new System.Drawing.Point(20, 27);
            this.FlowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            this.FlowLayoutPanel3.Size = new System.Drawing.Size(477, 202);
            this.FlowLayoutPanel3.TabIndex = 0;
            // 
            // cboproveedor
            // 
            this.cboproveedor.Caption = "Proveedor de datos:";
            this.cboproveedor.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.cboproveedor.Location = new System.Drawing.Point(5, 5);
            this.cboproveedor.Margin = new System.Windows.Forms.Padding(5);
            this.cboproveedor.Name = "cboproveedor";
            this.cboproveedor.Size = new System.Drawing.Size(330, 25);
            this.cboproveedor.TabIndex = 0;
            // 
            // cboservidor
            // 
            this.cboservidor.Caption = "Servidor:";
            this.cboservidor.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.cboservidor.Location = new System.Drawing.Point(5, 40);
            this.cboservidor.Margin = new System.Windows.Forms.Padding(5);
            this.cboservidor.Name = "cboservidor";
            this.cboservidor.Size = new System.Drawing.Size(330, 25);
            this.cboservidor.TabIndex = 1;
            this.cboservidor.AbrioCombo += new System.EventHandler(this.Servidor_AbrioCombo);
            // 
            // txtbasedatos
            // 
            this.txtbasedatos.Caption = "&Base de datos:";
            this.txtbasedatos.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtbasedatos.esPassword = false;
            this.txtbasedatos.Location = new System.Drawing.Point(5, 75);
            this.txtbasedatos.Margin = new System.Windows.Forms.Padding(5);
            this.txtbasedatos.MultiLine = false;
            this.txtbasedatos.Name = "txtbasedatos";
            this.txtbasedatos.Size = new System.Drawing.Size(330, 22);
            this.txtbasedatos.TabIndex = 2;
            // 
            // txtnombreusuariobd
            // 
            this.txtnombreusuariobd.Caption = "&Nombre de usuario:";
            this.txtnombreusuariobd.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtnombreusuariobd.esPassword = false;
            this.txtnombreusuariobd.Location = new System.Drawing.Point(5, 107);
            this.txtnombreusuariobd.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombreusuariobd.MultiLine = false;
            this.txtnombreusuariobd.Name = "txtnombreusuariobd";
            this.txtnombreusuariobd.Size = new System.Drawing.Size(330, 22);
            this.txtnombreusuariobd.TabIndex = 3;
            // 
            // txtcontrasenabd
            // 
            this.txtcontrasenabd.Caption = "&Contraseña:";
            this.txtcontrasenabd.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtcontrasenabd.esPassword = true;
            this.txtcontrasenabd.Location = new System.Drawing.Point(5, 139);
            this.txtcontrasenabd.Margin = new System.Windows.Forms.Padding(5);
            this.txtcontrasenabd.MultiLine = false;
            this.txtcontrasenabd.Name = "txtcontrasenabd";
            this.txtcontrasenabd.Size = new System.Drawing.Size(330, 22);
            this.txtcontrasenabd.TabIndex = 4;
            // 
            // chkSeguridadIntegrada
            // 
            this.chkSeguridadIntegrada.AutoSize = true;
            this.chkSeguridadIntegrada.Location = new System.Drawing.Point(4, 170);
            this.chkSeguridadIntegrada.Margin = new System.Windows.Forms.Padding(4);
            this.chkSeguridadIntegrada.Name = "chkSeguridadIntegrada";
            this.chkSeguridadIntegrada.Size = new System.Drawing.Size(159, 21);
            this.chkSeguridadIntegrada.TabIndex = 5;
            this.chkSeguridadIntegrada.Text = "&Seguridad integrada";
            this.chkSeguridadIntegrada.UseVisualStyleBackColor = true;
            this.chkSeguridadIntegrada.CheckedChanged += new System.EventHandler(this.chkSeguridadIntegrada_CheckedChanged);
            // 
            // chkguardarcontrasenabd
            // 
            this.chkguardarcontrasenabd.AutoSize = true;
            this.chkguardarcontrasenabd.Checked = true;
            this.chkguardarcontrasenabd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkguardarcontrasenabd.Location = new System.Drawing.Point(171, 170);
            this.chkguardarcontrasenabd.Margin = new System.Windows.Forms.Padding(4);
            this.chkguardarcontrasenabd.Name = "chkguardarcontrasenabd";
            this.chkguardarcontrasenabd.Size = new System.Drawing.Size(256, 21);
            this.chkguardarcontrasenabd.TabIndex = 6;
            this.chkguardarcontrasenabd.Text = "&Guardar contraseña en este equipo";
            this.chkguardarcontrasenabd.UseVisualStyleBackColor = true;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBoxHeader2);
            this.TabPage1.Controls.Add(this.GroupBoxHeader1);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPage1.Size = new System.Drawing.Size(527, 439);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            // 
            // GroupBoxHeader2
            // 
            this.GroupBoxHeader2.Controls.Add(this.FlowLayoutPanel2);
            this.GroupBoxHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxHeader2.Location = new System.Drawing.Point(13, 175);
            this.GroupBoxHeader2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHeader2.Name = "GroupBoxHeader2";
            this.GroupBoxHeader2.Padding = new System.Windows.Forms.Padding(20, 12, 4, 4);
            this.GroupBoxHeader2.Size = new System.Drawing.Size(501, 212);
            this.GroupBoxHeader2.TabIndex = 4;
            this.GroupBoxHeader2.TabStop = false;
            this.GroupBoxHeader2.Text = "Sistema registrado";
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Controls.Add(this.Label1);
            this.FlowLayoutPanel2.Controls.Add(this.txtnombresistema);
            this.FlowLayoutPanel2.Controls.Add(this.txtdescripcionsistema);
            this.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(20, 27);
            this.FlowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(477, 181);
            this.FlowLayoutPanel2.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(426, 34);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Puede reemplazar el nombre del sistema registrado por un nuevo nombre y descripci" +
    "ón";
            // 
            // txtnombresistema
            // 
            this.txtnombresistema.Caption = "Nombre del &sistema registrado:";
            this.txtnombresistema.Direccion = Infoware.Controles.Base.enumDireccion.Abajo;
            this.txtnombresistema.esPassword = false;
            this.txtnombresistema.Location = new System.Drawing.Point(5, 39);
            this.txtnombresistema.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombresistema.MultiLine = false;
            this.txtnombresistema.Name = "txtnombresistema";
            this.txtnombresistema.Size = new System.Drawing.Size(440, 42);
            this.txtnombresistema.TabIndex = 0;
            // 
            // txtdescripcionsistema
            // 
            this.txtdescripcionsistema.Caption = "&Descripción del sistema registrado:";
            this.txtdescripcionsistema.Direccion = Infoware.Controles.Base.enumDireccion.Abajo;
            this.txtdescripcionsistema.esPassword = false;
            this.txtdescripcionsistema.Location = new System.Drawing.Point(5, 91);
            this.txtdescripcionsistema.Margin = new System.Windows.Forms.Padding(5);
            this.txtdescripcionsistema.MultiLine = true;
            this.txtdescripcionsistema.Name = "txtdescripcionsistema";
            this.txtdescripcionsistema.Size = new System.Drawing.Size(440, 60);
            this.txtdescripcionsistema.TabIndex = 1;
            // 
            // GroupBoxHeader1
            // 
            this.GroupBoxHeader1.Controls.Add(this.flowUserPassword);
            this.GroupBoxHeader1.Controls.Add(this.FlowLayoutPanel6);
            this.GroupBoxHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxHeader1.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHeader1.Name = "GroupBoxHeader1";
            this.GroupBoxHeader1.Padding = new System.Windows.Forms.Padding(20, 12, 4, 4);
            this.GroupBoxHeader1.Size = new System.Drawing.Size(501, 163);
            this.GroupBoxHeader1.TabIndex = 3;
            this.GroupBoxHeader1.TabStop = false;
            this.GroupBoxHeader1.Text = "Inicio de sesión";
            // 
            // flowUserPassword
            // 
            this.flowUserPassword.Controls.Add(this.txtnombreusuario);
            this.flowUserPassword.Controls.Add(this.txtcontrasena);
            this.flowUserPassword.Controls.Add(this.chkguardarcontrasena);
            this.flowUserPassword.Controls.Add(this.chkcargaraliniciar);
            this.flowUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUserPassword.Location = new System.Drawing.Point(20, 56);
            this.flowUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.flowUserPassword.Name = "flowUserPassword";
            this.flowUserPassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowUserPassword.Size = new System.Drawing.Size(477, 103);
            this.flowUserPassword.TabIndex = 1;
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Caption = "&Nombre de usuario:";
            this.txtnombreusuario.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtnombreusuario.esPassword = false;
            this.txtnombreusuario.Location = new System.Drawing.Point(25, 5);
            this.txtnombreusuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombreusuario.MultiLine = false;
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(330, 22);
            this.txtnombreusuario.TabIndex = 1;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Caption = "&Contraseña:";
            this.txtcontrasena.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtcontrasena.esPassword = true;
            this.txtcontrasena.Location = new System.Drawing.Point(25, 37);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(5);
            this.txtcontrasena.MultiLine = false;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(330, 22);
            this.txtcontrasena.TabIndex = 2;
            // 
            // chkguardarcontrasena
            // 
            this.chkguardarcontrasena.AutoSize = true;
            this.chkguardarcontrasena.Location = new System.Drawing.Point(24, 68);
            this.chkguardarcontrasena.Margin = new System.Windows.Forms.Padding(4);
            this.chkguardarcontrasena.Name = "chkguardarcontrasena";
            this.chkguardarcontrasena.Size = new System.Drawing.Size(256, 21);
            this.chkguardarcontrasena.TabIndex = 3;
            this.chkguardarcontrasena.Text = "&Guardar contraseña en este equipo";
            this.chkguardarcontrasena.UseVisualStyleBackColor = true;
            this.chkguardarcontrasena.CheckedChanged += new System.EventHandler(this.chkguardarcontrasena_CheckedChanged);
            // 
            // chkcargaraliniciar
            // 
            this.chkcargaraliniciar.AutoSize = true;
            this.chkcargaraliniciar.Enabled = false;
            this.chkcargaraliniciar.Location = new System.Drawing.Point(288, 68);
            this.chkcargaraliniciar.Margin = new System.Windows.Forms.Padding(4);
            this.chkcargaraliniciar.Name = "chkcargaraliniciar";
            this.chkcargaraliniciar.Size = new System.Drawing.Size(129, 21);
            this.chkcargaraliniciar.TabIndex = 4;
            this.chkcargaraliniciar.Text = "&Cargar al iniciar";
            this.chkcargaraliniciar.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanel6
            // 
            this.FlowLayoutPanel6.Controls.Add(this.chkSeguridadWindows);
            this.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanel6.Location = new System.Drawing.Point(20, 27);
            this.FlowLayoutPanel6.Name = "FlowLayoutPanel6";
            this.FlowLayoutPanel6.Size = new System.Drawing.Size(477, 29);
            this.FlowLayoutPanel6.TabIndex = 4;
            // 
            // chkSeguridadWindows
            // 
            this.chkSeguridadWindows.AutoSize = true;
            this.chkSeguridadWindows.Location = new System.Drawing.Point(4, 4);
            this.chkSeguridadWindows.Margin = new System.Windows.Forms.Padding(4);
            this.chkSeguridadWindows.Name = "chkSeguridadWindows";
            this.chkSeguridadWindows.Size = new System.Drawing.Size(270, 21);
            this.chkSeguridadWindows.TabIndex = 4;
            this.chkSeguridadWindows.Text = "&Usar Seguridad de Microsoft Windows";
            this.chkSeguridadWindows.UseVisualStyleBackColor = true;
            this.chkSeguridadWindows.CheckedChanged += new System.EventHandler(this.chkSeguridadWindows_CheckedChanged);
            // 
            // GroupBoxHeader5
            // 
            this.GroupBoxHeader5.Controls.Add(this.FlowLayoutPanel5);
            this.GroupBoxHeader5.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxHeader5.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxHeader5.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHeader5.Name = "GroupBoxHeader5";
            this.GroupBoxHeader5.Padding = new System.Windows.Forms.Padding(20, 12, 4, 4);
            this.GroupBoxHeader5.Size = new System.Drawing.Size(501, 139);
            this.GroupBoxHeader5.TabIndex = 2;
            this.GroupBoxHeader5.TabStop = false;
            this.GroupBoxHeader5.Text = "Directorio";
            // 
            // FlowLayoutPanel5
            // 
            this.FlowLayoutPanel5.Controls.Add(this.txtDirectorioReplicacion);
            this.FlowLayoutPanel5.Controls.Add(this.ButtonStd1);
            this.FlowLayoutPanel5.Controls.Add(this.txtSufijoReplicacion);
            this.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel5.Location = new System.Drawing.Point(20, 27);
            this.FlowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanel5.Name = "FlowLayoutPanel5";
            this.FlowLayoutPanel5.Size = new System.Drawing.Size(477, 108);
            this.FlowLayoutPanel5.TabIndex = 0;
            this.FlowLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel5_Paint);
            // 
            // txtDirectorioReplicacion
            // 
            this.txtDirectorioReplicacion.Caption = "&Directorio de replicación:";
            this.txtDirectorioReplicacion.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtDirectorioReplicacion.esPassword = false;
            this.txtDirectorioReplicacion.Location = new System.Drawing.Point(5, 5);
            this.txtDirectorioReplicacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDirectorioReplicacion.MultiLine = false;
            this.txtDirectorioReplicacion.Name = "txtDirectorioReplicacion";
            this.txtDirectorioReplicacion.Size = new System.Drawing.Size(330, 22);
            this.txtDirectorioReplicacion.TabIndex = 0;
            // 
            // ButtonStd1
            // 
            this.ButtonStd1.Location = new System.Drawing.Point(4, 36);
            this.ButtonStd1.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStd1.Name = "ButtonStd1";
            this.ButtonStd1.Size = new System.Drawing.Size(160, 23);
            this.ButtonStd1.TabIndex = 1;
            this.ButtonStd1.Text = "&Examinar";
            this.ButtonStd1.UseVisualStyleBackColor = true;
            this.ButtonStd1.Click += new System.EventHandler(this.ButtonStd1_Click);
            // 
            // txtSufijoReplicacion
            // 
            this.txtSufijoReplicacion.Caption = "&Sufijo";
            this.txtSufijoReplicacion.Direccion = Infoware.Controles.Base.enumDireccion.Derecha;
            this.txtSufijoReplicacion.esPassword = false;
            this.txtSufijoReplicacion.Location = new System.Drawing.Point(5, 68);
            this.txtSufijoReplicacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtSufijoReplicacion.MultiLine = false;
            this.txtSufijoReplicacion.Name = "txtSufijoReplicacion";
            this.txtSufijoReplicacion.Size = new System.Drawing.Size(330, 22);
            this.txtSufijoReplicacion.TabIndex = 3;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBoxHeader4);
            this.TabPage2.Controls.Add(this.GroupBoxHeader3);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPage2.Size = new System.Drawing.Size(527, 439);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Conexión";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btncancelar);
            this.Panel1.Controls.Add(this.btnguardar);
            this.Panel1.Controls.Add(this.btnprobar);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Panel1.Location = new System.Drawing.Point(0, 429);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(535, 39);
            this.Panel1.TabIndex = 3;
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(411, 4);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(120, 23);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(283, 4);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(120, 23);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnprobar
            // 
            this.btnprobar.Location = new System.Drawing.Point(155, 4);
            this.btnprobar.Margin = new System.Windows.Forms.Padding(4);
            this.btnprobar.Name = "btnprobar";
            this.btnprobar.Size = new System.Drawing.Size(120, 23);
            this.btnprobar.TabIndex = 0;
            this.btnprobar.Text = "&Probar";
            this.btnprobar.UseVisualStyleBackColor = true;
            this.btnprobar.Click += new System.EventHandler(this.btnprobar_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(535, 468);
            this.TabControl1.TabIndex = 2;
            this.TabControl1.TabStop = false;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage3.Controls.Add(this.GroupBoxHeader5);
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPage3.Size = new System.Drawing.Size(527, 439);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Replicación";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // FrmSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(535, 468);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSistemas";
            this.Text = "Registro de sistema";
            this.GroupBoxHeader4.ResumeLayout(false);
            this.FlowLayoutPanel4.ResumeLayout(false);
            this.GroupBoxHeader3.ResumeLayout(false);
            this.FlowLayoutPanel3.ResumeLayout(false);
            this.FlowLayoutPanel3.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.GroupBoxHeader2.ResumeLayout(false);
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.FlowLayoutPanel2.PerformLayout();
            this.GroupBoxHeader1.ResumeLayout(false);
            this.flowUserPassword.ResumeLayout(false);
            this.flowUserPassword.PerformLayout();
            this.FlowLayoutPanel6.ResumeLayout(false);
            this.FlowLayoutPanel6.PerformLayout();
            this.GroupBoxHeader5.ResumeLayout(false);
            this.FlowLayoutPanel5.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Infoware.Controles.Base.GroupBoxHeader GroupBoxHeader4;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel4;
        internal Infoware.Controles.Base.LblTextBoxStd txtarchivoensamblado;
        internal Infoware.Controles.Base.ButtonStd btnexaminar;
        internal Infoware.Controles.Base.GroupBoxHeader GroupBoxHeader3;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel3;
        internal Infoware.Controles.Base.LblComboBoxStd cboproveedor;
        internal Infoware.Controles.Base.LblComboBoxStd cboservidor;
        internal Infoware.Controles.Base.LblTextBoxStd txtbasedatos;
        internal Infoware.Controles.Base.LblTextBoxStd txtnombreusuariobd;
        internal Infoware.Controles.Base.LblTextBoxStd txtcontrasenabd;
        internal Infoware.Controles.Base.CheckBoxStd chkSeguridadIntegrada;
        internal Infoware.Controles.Base.CheckBoxStd chkguardarcontrasenabd;
        internal System.Windows.Forms.TabPage TabPage1;
        internal Infoware.Controles.Base.GroupBoxHeader GroupBoxHeader2;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
        internal System.Windows.Forms.Label Label1;
        internal Infoware.Controles.Base.LblTextBoxStd txtnombresistema;
        internal Infoware.Controles.Base.LblTextBoxStd txtdescripcionsistema;
        internal Infoware.Controles.Base.GroupBoxHeader GroupBoxHeader1;
        internal System.Windows.Forms.FlowLayoutPanel flowUserPassword;
        internal Infoware.Controles.Base.LblTextBoxStd txtnombreusuario;
        internal Infoware.Controles.Base.LblTextBoxStd txtcontrasena;
        internal Infoware.Controles.Base.CheckBoxStd chkguardarcontrasena;
        internal Infoware.Controles.Base.CheckBoxStd chkcargaraliniciar;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel6;
        internal Infoware.Controles.Base.CheckBoxStd chkSeguridadWindows;
        internal Infoware.Controles.Base.GroupBoxHeader GroupBoxHeader5;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel5;
        internal Infoware.Controles.Base.LblTextBoxStd txtDirectorioReplicacion;
        internal Infoware.Controles.Base.ButtonStd ButtonStd1;
        internal Infoware.Controles.Base.LblTextBoxStd txtSufijoReplicacion;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.FlowLayoutPanel Panel1;
        internal Infoware.Controles.Base.ButtonStd btncancelar;
        internal Infoware.Controles.Base.ButtonStd btnguardar;
        internal Infoware.Controles.Base.ButtonStd btnprobar;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    }
}