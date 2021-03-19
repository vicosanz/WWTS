namespace ICA3.Formas
{
    partial class FrmSistemasLogin
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnayuda = new Infoware.Controles.Base.ButtonStd();
            this.btncancelar = new Infoware.Controles.Base.ButtonStd();
            this.btnguardar = new Infoware.Controles.Base.ButtonStd();
            this.GroupBoxHeader1 = new Infoware.Controles.Base.GroupBoxHeader();
            this.FlowUserPassword = new System.Windows.Forms.FlowLayoutPanel();
            this.txtnombreusuario = new Infoware.Controles.Base.LblTextBoxStd();
            this.txtcontrasena = new Infoware.Controles.Base.LblTextBoxStd();
            this.chkguardarcontrasena = new Infoware.Controles.Base.CheckBoxStd();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSeguridadWindows = new Infoware.Controles.Base.CheckBoxStd();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBoxHeader1.SuspendLayout();
            this.FlowUserPassword.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBox1.Image = global::ICA3.Properties.Resources.integra;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(569, 135);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Panel1);
            this.Panel2.Controls.Add(this.GroupBoxHeader1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 135);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Panel2.Size = new System.Drawing.Size(569, 253);
            this.Panel2.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnayuda);
            this.Panel1.Controls.Add(this.btncancelar);
            this.Panel1.Controls.Add(this.btnguardar);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Panel1.Location = new System.Drawing.Point(13, 202);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(543, 39);
            this.Panel1.TabIndex = 1;
            // 
            // btnayuda
            // 
            this.btnayuda.Location = new System.Drawing.Point(419, 4);
            this.btnayuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(120, 23);
            this.btnayuda.TabIndex = 3;
            this.btnayuda.Text = "&Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(291, 4);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(120, 23);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(163, 4);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(120, 23);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "&Conectar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // GroupBoxHeader1
            // 
            this.GroupBoxHeader1.Controls.Add(this.FlowUserPassword);
            this.GroupBoxHeader1.Controls.Add(this.FlowLayoutPanel2);
            this.GroupBoxHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxHeader1.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHeader1.Name = "GroupBoxHeader1";
            this.GroupBoxHeader1.Padding = new System.Windows.Forms.Padding(20, 12, 4, 4);
            this.GroupBoxHeader1.Size = new System.Drawing.Size(543, 162);
            this.GroupBoxHeader1.TabIndex = 0;
            this.GroupBoxHeader1.TabStop = false;
            this.GroupBoxHeader1.Text = "Inicio de sesión";
            // 
            // FlowUserPassword
            // 
            this.FlowUserPassword.Controls.Add(this.txtnombreusuario);
            this.FlowUserPassword.Controls.Add(this.txtcontrasena);
            this.FlowUserPassword.Controls.Add(this.chkguardarcontrasena);
            this.FlowUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowUserPassword.Location = new System.Drawing.Point(20, 56);
            this.FlowUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.FlowUserPassword.Name = "FlowUserPassword";
            this.FlowUserPassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.FlowUserPassword.Size = new System.Drawing.Size(519, 102);
            this.FlowUserPassword.TabIndex = 1;
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
            this.txtnombreusuario.TabIndex = 0;
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
            this.txtcontrasena.TabIndex = 1;
            // 
            // chkguardarcontrasena
            // 
            this.chkguardarcontrasena.AutoSize = true;
            this.chkguardarcontrasena.Location = new System.Drawing.Point(24, 68);
            this.chkguardarcontrasena.Margin = new System.Windows.Forms.Padding(4);
            this.chkguardarcontrasena.Name = "chkguardarcontrasena";
            this.chkguardarcontrasena.Size = new System.Drawing.Size(256, 21);
            this.chkguardarcontrasena.TabIndex = 2;
            this.chkguardarcontrasena.Text = "&Guardar contraseña en este equipo";
            this.chkguardarcontrasena.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Controls.Add(this.chkSeguridadWindows);
            this.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(20, 27);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(519, 29);
            this.FlowLayoutPanel2.TabIndex = 0;
            // 
            // chkSeguridadWindows
            // 
            this.chkSeguridadWindows.AutoSize = true;
            this.chkSeguridadWindows.Location = new System.Drawing.Point(4, 4);
            this.chkSeguridadWindows.Margin = new System.Windows.Forms.Padding(4);
            this.chkSeguridadWindows.Name = "chkSeguridadWindows";
            this.chkSeguridadWindows.Size = new System.Drawing.Size(270, 21);
            this.chkSeguridadWindows.TabIndex = 0;
            this.chkSeguridadWindows.Text = "&Usar Seguridad de Microsoft Windows";
            this.chkSeguridadWindows.UseVisualStyleBackColor = true;
            this.chkSeguridadWindows.CheckedChanged += new System.EventHandler(this.chkSeguridadWindows_CheckedChanged);
            // 
            // FrmSistemasLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(569, 388);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSistemasLogin";
            this.Text = "Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.GroupBoxHeader1.ResumeLayout(false);
            this.FlowUserPassword.ResumeLayout(false);
            this.FlowUserPassword.PerformLayout();
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.FlowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.FlowLayoutPanel Panel1;
        internal Infoware.Controles.Base.ButtonStd btnayuda;
        internal Infoware.Controles.Base.ButtonStd btncancelar;
        internal Infoware.Controles.Base.ButtonStd btnguardar;
        internal Infoware.Controles.Base.GroupBoxHeader GroupBoxHeader1;
        internal System.Windows.Forms.FlowLayoutPanel FlowUserPassword;
        internal Infoware.Controles.Base.LblTextBoxStd txtnombreusuario;
        internal Infoware.Controles.Base.LblTextBoxStd txtcontrasena;
        internal Infoware.Controles.Base.CheckBoxStd chkguardarcontrasena;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
        internal Infoware.Controles.Base.CheckBoxStd chkSeguridadWindows;
    }
}