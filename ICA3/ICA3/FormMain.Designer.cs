namespace ICA3
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrasOtrasVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExplorador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFavoritos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSep = new System.Windows.Forms.ToolStripSeparator();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerEsquemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vsToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SistemasToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ModulosToolStrip = new System.Windows.Forms.ToolStripButton();
            this.FavoritosToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ReportesToolStrip = new System.Windows.Forms.ToolStripButton();
            this.tmr_error = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlhidemenu
            // 
            this.pnlhidemenu.Location = new System.Drawing.Point(0, 61);
            this.pnlhidemenu.Size = new System.Drawing.Size(1059, 12);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 53);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barrasOtrasVentanasToolStripMenuItem,
            this.toolStripMenuItemSep});
            this.verToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.verToolStripMenuItem.MergeIndex = 2;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // barrasOtrasVentanasToolStripMenuItem
            // 
            this.barrasOtrasVentanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSistemas,
            this.MenuExplorador,
            this.MenuFavoritos,
            this.MenuReportes});
            this.barrasOtrasVentanasToolStripMenuItem.Name = "barrasOtrasVentanasToolStripMenuItem";
            this.barrasOtrasVentanasToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.barrasOtrasVentanasToolStripMenuItem.Text = "Otras ventanas";
            // 
            // MenuSistemas
            // 
            this.MenuSistemas.Image = global::ICA3.Properties.Resources.db;
            this.MenuSistemas.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuSistemas.MergeIndex = 0;
            this.MenuSistemas.Name = "MenuSistemas";
            this.MenuSistemas.Size = new System.Drawing.Size(244, 26);
            this.MenuSistemas.Text = "&Sistemas Registrados";
            this.MenuSistemas.ToolTipText = "Muestra la lista de sistemas registrados";
            this.MenuSistemas.Click += new System.EventHandler(this.MenuSistemas_Click);
            // 
            // MenuExplorador
            // 
            this.MenuExplorador.Image = global::ICA3.Properties.Resources.table;
            this.MenuExplorador.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuExplorador.MergeIndex = 1;
            this.MenuExplorador.Name = "MenuExplorador";
            this.MenuExplorador.Size = new System.Drawing.Size(244, 26);
            this.MenuExplorador.Text = "&Explorador del sistema";
            this.MenuExplorador.ToolTipText = "Muestra la lista de opciones del sistema seleccionado";
            this.MenuExplorador.Click += new System.EventHandler(this.MenuExplorador_Click);
            // 
            // MenuFavoritos
            // 
            this.MenuFavoritos.Image = global::ICA3.Properties.Resources.favorites;
            this.MenuFavoritos.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuFavoritos.MergeIndex = 2;
            this.MenuFavoritos.Name = "MenuFavoritos";
            this.MenuFavoritos.Size = new System.Drawing.Size(244, 26);
            this.MenuFavoritos.Text = "&Favoritos";
            this.MenuFavoritos.ToolTipText = "Muestra las opciones favoritas del sistema seleccionado";
            this.MenuFavoritos.Click += new System.EventHandler(this.MenuFavoritos_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.Image = global::ICA3.Properties.Resources.print;
            this.MenuReportes.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuReportes.MergeIndex = 3;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(244, 26);
            this.MenuReportes.Text = "&Reportes";
            this.MenuReportes.ToolTipText = "Muestra los reportes del sistema seleccionado";
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // toolStripMenuItemSep
            // 
            this.toolStripMenuItemSep.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItemSep.MergeIndex = 4;
            this.toolStripMenuItemSep.Name = "toolStripMenuItemSep";
            this.toolStripMenuItemSep.Size = new System.Drawing.Size(186, 6);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restablecerEsquemaToolStripMenuItem});
            this.ventanaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ventanaToolStripMenuItem.MergeIndex = 3;
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.ventanaToolStripMenuItem.Text = "V&entanas";
            // 
            // restablecerEsquemaToolStripMenuItem
            // 
            this.restablecerEsquemaToolStripMenuItem.Name = "restablecerEsquemaToolStripMenuItem";
            this.restablecerEsquemaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.restablecerEsquemaToolStripMenuItem.Text = "Restablecer esquema";
            this.restablecerEsquemaToolStripMenuItem.Click += new System.EventHandler(this.RestablecerEsquemaToolStripMenuItem_Click);
            // 
            // vsToolStripExtender1
            // 
            this.vsToolStripExtender1.DefaultRenderer = null;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SistemasToolStrip,
            this.ModulosToolStrip,
            this.FavoritosToolStrip,
            this.ReportesToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 73);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1059, 31);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SistemasToolStrip
            // 
            this.SistemasToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SistemasToolStrip.Image = global::ICA3.Properties.Resources.db;
            this.SistemasToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SistemasToolStrip.Name = "SistemasToolStrip";
            this.SistemasToolStrip.Size = new System.Drawing.Size(29, 28);
            this.SistemasToolStrip.Text = "Sistemas registrados";
            this.SistemasToolStrip.Click += new System.EventHandler(this.SistemasToolStrip_Click);
            // 
            // ModulosToolStrip
            // 
            this.ModulosToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModulosToolStrip.Image = global::ICA3.Properties.Resources.table;
            this.ModulosToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModulosToolStrip.Name = "ModulosToolStrip";
            this.ModulosToolStrip.Size = new System.Drawing.Size(29, 28);
            this.ModulosToolStrip.Text = "Explorador de sistema";
            this.ModulosToolStrip.Click += new System.EventHandler(this.ModulosToolStrip_Click);
            // 
            // FavoritosToolStrip
            // 
            this.FavoritosToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FavoritosToolStrip.Image = global::ICA3.Properties.Resources.favorites;
            this.FavoritosToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FavoritosToolStrip.Name = "FavoritosToolStrip";
            this.FavoritosToolStrip.Size = new System.Drawing.Size(29, 28);
            this.FavoritosToolStrip.Text = "Favoritos";
            this.FavoritosToolStrip.Click += new System.EventHandler(this.FavoritosToolStrip_Click);
            // 
            // ReportesToolStrip
            // 
            this.ReportesToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReportesToolStrip.Image = global::ICA3.Properties.Resources.print;
            this.ReportesToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportesToolStrip.Name = "ReportesToolStrip";
            this.ReportesToolStrip.Size = new System.Drawing.Size(29, 28);
            this.ReportesToolStrip.Text = "Reportes";
            this.ReportesToolStrip.Click += new System.EventHandler(this.ReportesToolStrip_Click);
            // 
            // tmr_error
            // 
            this.tmr_error.Interval = 60000;
            this.tmr_error.Tick += new System.EventHandler(this.tmr_error_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 698);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormMain";
            this.Text = "Infoware Consola Administrativa 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.pnlhidemenu, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSep;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender vsToolStripExtender1;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SistemasToolStrip;
        private System.Windows.Forms.ToolStripButton ModulosToolStrip;
        private System.Windows.Forms.ToolStripButton FavoritosToolStrip;
        private System.Windows.Forms.ToolStripButton ReportesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restablecerEsquemaToolStripMenuItem;
        internal System.Windows.Forms.Timer tmr_error;
        private System.Windows.Forms.ToolStripMenuItem barrasOtrasVentanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSistemas;
        private System.Windows.Forms.ToolStripMenuItem MenuExplorador;
        private System.Windows.Forms.ToolStripMenuItem MenuFavoritos;
        private System.Windows.Forms.ToolStripMenuItem MenuReportes;
    }
}