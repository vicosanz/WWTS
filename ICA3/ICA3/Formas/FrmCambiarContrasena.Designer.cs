namespace ICA3.Formas
{
    partial class FrmCambiarContrasena
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
            this.Cancel = new Infoware.Controles.Base.ButtonStd();
            this.OK = new Infoware.Controles.Base.ButtonStd();
            this.txtconfirmar = new Infoware.Controles.Base.TextBoxStd();
            this.txtnueva = new Infoware.Controles.Base.TextBoxStd();
            this.Label1 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(329, 120);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "&Cancelar";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(192, 120);
            this.OK.Margin = new System.Windows.Forms.Padding(4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(120, 23);
            this.OK.TabIndex = 12;
            this.OK.Text = "&Aceptar";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Location = new System.Drawing.Point(206, 68);
            this.txtconfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirmar.Mensaje = "";
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.PasswordChar = '*';
            this.txtconfirmar.PromptFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmar.PromptForeColor = System.Drawing.SystemColors.GrayText;
            this.txtconfirmar.PromptText = "";
            this.txtconfirmar.Size = new System.Drawing.Size(209, 22);
            this.txtconfirmar.TabIndex = 11;
            this.txtconfirmar.UseSystemPasswordChar = true;
            // 
            // txtnueva
            // 
            this.txtnueva.Location = new System.Drawing.Point(206, 36);
            this.txtnueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtnueva.Mensaje = "";
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.PasswordChar = '*';
            this.txtnueva.PromptFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnueva.PromptForeColor = System.Drawing.SystemColors.GrayText;
            this.txtnueva.PromptText = "";
            this.txtnueva.Size = new System.Drawing.Size(209, 22);
            this.txtnueva.TabIndex = 9;
            this.txtnueva.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 73);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(148, 17);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Co&nfirmar contraseña:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(17, 41);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 17);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "C&ontraseña nueva:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(462, 156);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarContrasena";
            this.Text = "Cambiar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Infoware.Controles.Base.ButtonStd Cancel;
        internal Infoware.Controles.Base.ButtonStd OK;
        internal Infoware.Controles.Base.TextBoxStd txtconfirmar;
        internal Infoware.Controles.Base.TextBoxStd txtnueva;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label PasswordLabel;
    }
}