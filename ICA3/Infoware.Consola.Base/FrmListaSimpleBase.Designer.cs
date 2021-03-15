namespace Infoware.Consola.Base
{
    partial class FrmListaSimpleBase
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
            this.headerStrip1 = new Infoware.Consola.Base.HeaderStrip();
            this.ToolStriptitulo = new System.Windows.Forms.ToolStripLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pnlcuerpo = new System.Windows.Forms.Panel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnexportar = new System.Windows.Forms.ToolStripButton();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btncorreo = new System.Windows.Forms.ToolStripButton();
            this.btnword = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnenviomails = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CorreoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new Infoware.Consola.Base.MenuEditarHelper();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListBindingSource)).BeginInit();
            this.headerStrip1.SuspendLayout();
            this.pnlcuerpo.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.ToolStriptitulo.Size = new System.Drawing.Size(124, 29);
            this.ToolStriptitulo.Text = "Reporte de";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 32);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Panel1.Size = new System.Drawing.Size(924, 81);
            this.Panel1.TabIndex = 7;
            // 
            // pnlcuerpo
            // 
            this.pnlcuerpo.Controls.Add(this.TabControl1);
            this.pnlcuerpo.Controls.Add(this.Panel2);
            this.pnlcuerpo.Controls.Add(this.Panel1);
            this.pnlcuerpo.Controls.Add(this.headerStrip1);
            this.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcuerpo.Location = new System.Drawing.Point(0, 58);
            this.pnlcuerpo.Name = "pnlcuerpo";
            this.pnlcuerpo.Size = new System.Drawing.Size(924, 455);
            this.pnlcuerpo.TabIndex = 9;
            // 
            // TabControl1
            // 
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 147);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(924, 308);
            this.TabControl1.TabIndex = 8;
            // 
            // Panel2
            // 
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 113);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(924, 34);
            this.Panel2.TabIndex = 9;
            this.Panel2.Visible = false;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnexportar,
            this.btncorreo,
            this.btnword,
            this.btnimprimir,
            this.ToolStripSeparator2,
            this.ToolStripProgressBar1,
            this.btnenviomails,
            this.ToolStripButtonAyuda});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(924, 30);
            this.ToolStrip1.TabIndex = 11;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnexportar
            // 
            this.btnexportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnexportar.Image = global::Infoware.Consola.Base.Properties.Resources.docexcel;
            this.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexportar.MergeIndex = 0;
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(24, 27);
            this.btnexportar.Text = "Exportar a Microsoft Excel";
            this.btnexportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnimprimir.Image = global::Infoware.Consola.Base.Properties.Resources.print;
            this.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnimprimir.MergeIndex = 0;
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(24, 27);
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // btncorreo
            // 
            this.btncorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncorreo.Image = global::Infoware.Consola.Base.Properties.Resources.attach;
            this.btncorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncorreo.Name = "btncorreo";
            this.btncorreo.Size = new System.Drawing.Size(24, 27);
            this.btncorreo.Text = "Enviar por correo";
            this.btncorreo.Click += new System.EventHandler(this.Correo_Click);
            // 
            // btnword
            // 
            this.btnword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnword.Image = global::Infoware.Consola.Base.Properties.Resources.docword;
            this.btnword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(24, 27);
            this.btnword.Text = "Enviar a Microsoft Word";
            this.btnword.Visible = false;
            this.btnword.Click += new System.EventHandler(this.Word_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.MergeIndex = 99;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // ToolStripProgressBar1
            // 
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new System.Drawing.Size(133, 27);
            this.ToolStripProgressBar1.Visible = false;
            // 
            // btnenviomails
            // 
            this.btnenviomails.Image = global::Infoware.Consola.Base.Properties.Resources.attach;
            this.btnenviomails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnenviomails.Name = "btnenviomails";
            this.btnenviomails.Size = new System.Drawing.Size(271, 27);
            this.btnenviomails.Text = "No se ha definido envío automático";
            this.btnenviomails.ToolTipText = "Clic aquí para iniciar el envío manualmente";
            this.btnenviomails.Visible = false;
            // 
            // ToolStripButtonAyuda
            // 
            this.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAyuda.Image = global::Infoware.Consola.Base.Properties.Resources.help;
            this.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAyuda.MergeIndex = 99;
            this.ToolStripButtonAyuda.Name = "ToolStripButtonAyuda";
            this.ToolStripButtonAyuda.Size = new System.Drawing.Size(24, 27);
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
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(924, 28);
            this.MenuStrip1.TabIndex = 10;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportarToolStripMenuItem,
            this.CorreoToolStripMenuItem1,
            this.WordToolStripMenuItem1,
            this.ImprimirToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.CerrarToolStripMenuItem});
            this.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // ExportarToolStripMenuItem
            // 
            this.ExportarToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.docexcel;
            this.ExportarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ExportarToolStripMenuItem.MergeIndex = 1;
            this.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem";
            this.ExportarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExportarToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.ExportarToolStripMenuItem.Text = "&Exportar a Excel";
            this.ExportarToolStripMenuItem.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // CorreoToolStripMenuItem1
            // 
            this.CorreoToolStripMenuItem1.Image = global::Infoware.Consola.Base.Properties.Resources.attach;
            this.CorreoToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.CorreoToolStripMenuItem1.MergeIndex = 2;
            this.CorreoToolStripMenuItem1.Name = "CorreoToolStripMenuItem1";
            this.CorreoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.CorreoToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.CorreoToolStripMenuItem1.Text = "En&viar por correo";
            this.CorreoToolStripMenuItem1.Click += new System.EventHandler(this.Correo_Click);
            // 
            // WordToolStripMenuItem1
            // 
            this.WordToolStripMenuItem1.Image = global::Infoware.Consola.Base.Properties.Resources.docword;
            this.WordToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.WordToolStripMenuItem1.MergeIndex = 2;
            this.WordToolStripMenuItem1.Name = "WordToolStripMenuItem1";
            this.WordToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.WordToolStripMenuItem1.Text = "Enviar por &Word";
            this.WordToolStripMenuItem1.Visible = false;
            this.WordToolStripMenuItem1.Click += new System.EventHandler(this.Word_Click);
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.print;
            this.ImprimirToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImprimirToolStripMenuItem.MergeIndex = 3;
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ImprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.ImprimirToolStripMenuItem.Text = "&Imprimir";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(250, 6);
            // 
            // CerrarToolStripMenuItem
            // 
            this.CerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem";
            this.CerrarToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.CerrarToolStripMenuItem.Text = "&Cerrar";
            this.CerrarToolStripMenuItem.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.EditToolStripMenuItem.MergeIndex = 1;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.EditToolStripMenuItem.Text = "&Edición";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaDinamicaToolStripMenuItem});
            this.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.AyudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // AyudaDinamicaToolStripMenuItem
            // 
            this.AyudaDinamicaToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.help;
            this.AyudaDinamicaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.AyudaDinamicaToolStripMenuItem.MergeIndex = 1;
            this.AyudaDinamicaToolStripMenuItem.Name = "AyudaDinamicaToolStripMenuItem";
            this.AyudaDinamicaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AyudaDinamicaToolStripMenuItem.Text = "&Ayuda dinámica";
            this.AyudaDinamicaToolStripMenuItem.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1001;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // FrmListaSimpleBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.pnlcuerpo);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "FrmListaSimpleBase";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.ListBindingSource)).EndInit();
            this.headerStrip1.ResumeLayout(false);
            this.headerStrip1.PerformLayout();
            this.pnlcuerpo.ResumeLayout(false);
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
        public System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.TabControl TabControl1;
        public System.Windows.Forms.Panel Panel2;
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnexportar;
        internal System.Windows.Forms.ToolStripButton btnimprimir;
        internal System.Windows.Forms.ToolStripButton btncorreo;
        internal System.Windows.Forms.ToolStripButton btnword;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar1;
        internal System.Windows.Forms.ToolStripButton btnenviomails;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonAyuda;
        public System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CorreoToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem WordToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem CerrarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaDinamicaToolStripMenuItem;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.Timer Timer2;
        private MenuEditarHelper EditToolStripMenuItem;
        public System.Windows.Forms.Panel pnlcuerpo;
    }
}