namespace Infoware.Consola.Base
{
    partial class FrmMantenimientoSimpleBase
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
            this.components = new System.ComponentModel.Container();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlcuerpo = new System.Windows.Forms.Panel();
            this.headerStrip1 = new Infoware.Consola.Base.HeaderStrip();
            this.ToolStriptitulo = new System.Windows.Forms.ToolStripLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnguardarnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnguardar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new Infoware.Consola.Base.MenuEditarHelper();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.pnlcuerpo.SuspendLayout();
            this.headerStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlcuerpo
            // 
            this.pnlcuerpo.Controls.Add(this.headerStrip1);
            this.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcuerpo.Location = new System.Drawing.Point(0, 61);
            this.pnlcuerpo.Name = "pnlcuerpo";
            this.pnlcuerpo.Size = new System.Drawing.Size(924, 452);
            this.pnlcuerpo.TabIndex = 9;
            // 
            // headerStrip1
            // 
            this.headerStrip1.AutoSize = false;
            this.headerStrip1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.headerStrip1.ForeColor = System.Drawing.Color.White;
            this.headerStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.headerStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.headerStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStriptitulo});
            this.headerStrip1.Location = new System.Drawing.Point(0, 0);
            this.headerStrip1.Name = "headerStrip1";
            this.headerStrip1.Size = new System.Drawing.Size(924, 32);
            this.headerStrip1.TabIndex = 6;
            this.headerStrip1.Text = "headerStrip1";
            // 
            // ToolStriptitulo
            // 
            this.ToolStriptitulo.Name = "ToolStriptitulo";
            this.ToolStriptitulo.Size = new System.Drawing.Size(0, 29);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnguardarnuevo,
            this.btnguardar,
            this.ToolStripSeparator2,
            this.ToolStripButtonAyuda});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 30);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(924, 31);
            this.ToolStrip1.TabIndex = 11;
            this.ToolStrip1.Text = "ToolStrip1";
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Guardarnuevo_Click);
            // 
            // btnguardarnuevo
            // 
            this.btnguardarnuevo.Image = global::Infoware.Consola.Base.Properties.Resources.saveandnew;
            this.btnguardarnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnguardarnuevo.MergeIndex = 1;
            this.btnguardarnuevo.Name = "btnguardarnuevo";
            this.btnguardarnuevo.Size = new System.Drawing.Size(141, 28);
            this.btnguardarnuevo.Text = "Guardar y nuevo";
            this.btnguardarnuevo.Visible = false;
            this.btnguardarnuevo.Click += new System.EventHandler(this.Guardarnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::Infoware.Consola.Base.Properties.Resources.save;
            this.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnguardar.MergeIndex = 0;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(86, 28);
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.MergeIndex = 99;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButtonAyuda
            // 
            this.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAyuda.Image = global::Infoware.Consola.Base.Properties.Resources.help;
            this.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAyuda.MergeIndex = 99;
            this.ToolStripButtonAyuda.Name = "ToolStripButtonAyuda";
            this.ToolStripButtonAyuda.Size = new System.Drawing.Size(29, 28);
            this.ToolStripButtonAyuda.Text = "Ayuda dinámica";
            this.ToolStripButtonAyuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(924, 30);
            this.MenuStrip1.TabIndex = 10;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.save;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.closeToolStripMenuItem.Text = "&Cerrar";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.EditToolStripMenuItem.MergeIndex = 1;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.EditToolStripMenuItem.Text = "&Edición";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaDinamicaToolStripMenuItem});
            this.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.AyudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // AyudaDinamicaToolStripMenuItem
            // 
            this.AyudaDinamicaToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.help;
            this.AyudaDinamicaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.AyudaDinamicaToolStripMenuItem.MergeIndex = 1;
            this.AyudaDinamicaToolStripMenuItem.Name = "AyudaDinamicaToolStripMenuItem";
            this.AyudaDinamicaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.AyudaDinamicaToolStripMenuItem.Text = "&Ayuda dinámica";
            this.AyudaDinamicaToolStripMenuItem.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // FrmMantenimientoSimpleBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.pnlcuerpo);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "FrmMantenimientoSimpleBase";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.pnlcuerpo.ResumeLayout(false);
            this.headerStrip1.ResumeLayout(false);
            this.headerStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HeaderStrip headerStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStriptitulo;
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonAyuda;
        public System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaDinamicaToolStripMenuItem;
        private MenuEditarHelper EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton btnguardarnuevo;
        internal System.Windows.Forms.ToolStripButton btnguardar;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        public System.Windows.Forms.Panel pnlcuerpo;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}