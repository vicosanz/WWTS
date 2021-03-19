namespace Infoware.Consola.Base
{
    partial class FrmReporteBase
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnexportar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.headerStrip1 = new Infoware.Consola.Base.HeaderStrip();
            this.ToolStriptitulo = new System.Windows.Forms.ToolStripLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlcuerpo = new System.Windows.Forms.Panel();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.headerStrip1.SuspendLayout();
            this.pnlcuerpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EdicionToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(924, 28);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImprimirToolStripMenuItem,
            this.ExportarToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.CerrarToolStripMenuItem});
            this.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.print;
            this.ImprimirToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImprimirToolStripMenuItem.MergeIndex = 1;
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ImprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.ImprimirToolStripMenuItem.Text = "&Imprimir";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // ExportarToolStripMenuItem
            // 
            this.ExportarToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.acrobat;
            this.ExportarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ExportarToolStripMenuItem.MergeIndex = 2;
            this.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem";
            this.ExportarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExportarToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.ExportarToolStripMenuItem.Text = "&Exportar a Acrobat PDF";
            this.ExportarToolStripMenuItem.Click += new System.EventHandler(this.ExportarToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(294, 6);
            // 
            // CerrarToolStripMenuItem
            // 
            this.CerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem";
            this.CerrarToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.CerrarToolStripMenuItem.Text = "&Cerrar";
            this.CerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // EdicionToolStripMenuItem
            // 
            this.EdicionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.EdicionToolStripMenuItem.MergeIndex = 1;
            this.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem";
            this.EdicionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.EdicionToolStripMenuItem.Text = "&Edición";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaDinamicaToolStripMenuItem});
            this.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.AyudaToolStripMenuItem.MergeIndex = 5;
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
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
            this.AyudaDinamicaToolStripMenuItem.Click += new System.EventHandler(this.AyudaDinamicaToolStripMenuItem_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnimprimir,
            this.btnexportar,
            this.ToolStripSeparator2,
            this.ToolStripButtonAyuda});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(924, 27);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnimprimir
            // 
            this.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnimprimir.Image = global::Infoware.Consola.Base.Properties.Resources.print;
            this.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(29, 24);
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnexportar.Image = global::Infoware.Consola.Base.Properties.Resources.acrobat;
            this.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(29, 24);
            this.btnexportar.Text = "Exportar";
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripButtonAyuda
            // 
            this.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAyuda.Image = global::Infoware.Consola.Base.Properties.Resources.help;
            this.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAyuda.Name = "ToolStripButtonAyuda";
            this.ToolStripButtonAyuda.Size = new System.Drawing.Size(29, 24);
            this.ToolStripButtonAyuda.Text = "Ayuda dinámica";
            this.ToolStripButtonAyuda.Click += new System.EventHandler(this.ToolStripButtonAyuda_Click);
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
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 113);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(924, 345);
            this.crystalReportViewer1.TabIndex = 8;
            // 
            // pnlcuerpo
            // 
            this.pnlcuerpo.Controls.Add(this.crystalReportViewer1);
            this.pnlcuerpo.Controls.Add(this.Panel1);
            this.pnlcuerpo.Controls.Add(this.headerStrip1);
            this.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcuerpo.Location = new System.Drawing.Point(0, 55);
            this.pnlcuerpo.Name = "pnlcuerpo";
            this.pnlcuerpo.Size = new System.Drawing.Size(924, 458);
            this.pnlcuerpo.TabIndex = 9;
            // 
            // FrmReporteBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.pnlcuerpo);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "FrmReporteBase";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.headerStrip1.ResumeLayout(false);
            this.headerStrip1.PerformLayout();
            this.pnlcuerpo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem CerrarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdicionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaDinamicaToolStripMenuItem;
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnimprimir;
        internal System.Windows.Forms.ToolStripButton btnexportar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonAyuda;
        private HeaderStrip headerStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStriptitulo;
        public System.Windows.Forms.Panel Panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public System.Windows.Forms.Panel pnlcuerpo;
    }
}