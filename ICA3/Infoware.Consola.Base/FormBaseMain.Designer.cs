namespace Infoware.Consola.Base
{
    partial class FormBaseMain
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblNoConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_contectadoa = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblok = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraEstandar = new System.Windows.Forms.ToolStrip();
            this.pnlhidemenu = new System.Windows.Forms.Panel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMinimizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaximizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparadorNuevo = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new Infoware.Consola.Base.MenuEditarHelper();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EstandarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraDeEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.PantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PantallaCompletaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNoConectado,
            this.lbl_contectadoa,
            this.lblok,
            this.lblerror});
            this.StatusStrip.Location = new System.Drawing.Point(0, 424);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusStrip.Size = new System.Drawing.Size(796, 26);
            this.StatusStrip.TabIndex = 9;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // lblNoConectado
            // 
            this.lblNoConectado.ForeColor = System.Drawing.Color.Red;
            this.lblNoConectado.Name = "lblNoConectado";
            this.lblNoConectado.Size = new System.Drawing.Size(103, 20);
            this.lblNoConectado.Text = "No conectado";
            // 
            // lbl_contectadoa
            // 
            this.lbl_contectadoa.Name = "lbl_contectadoa";
            this.lbl_contectadoa.Size = new System.Drawing.Size(96, 20);
            this.lbl_contectadoa.Text = "Conectado a:";
            this.lbl_contectadoa.Visible = false;
            // 
            // lblok
            // 
            this.lblok.Name = "lblok";
            this.lblok.Size = new System.Drawing.Size(40, 20);
            this.lblok.Text = "Listo";
            // 
            // lblerror
            // 
            this.lblerror.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(41, 20);
            this.lblerror.Text = "Error";
            this.lblerror.Visible = false;
            // 
            // BarraEstandar
            // 
            this.BarraEstandar.AllowItemReorder = true;
            this.BarraEstandar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraEstandar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BarraEstandar.Location = new System.Drawing.Point(0, 41);
            this.BarraEstandar.Name = "BarraEstandar";
            this.BarraEstandar.Size = new System.Drawing.Size(796, 25);
            this.BarraEstandar.TabIndex = 11;
            this.BarraEstandar.Text = "ToolStrip1";
            // 
            // pnlhidemenu
            // 
            this.pnlhidemenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlhidemenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhidemenu.Location = new System.Drawing.Point(0, 0);
            this.pnlhidemenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlhidemenu.Name = "pnlhidemenu";
            this.pnlhidemenu.Size = new System.Drawing.Size(796, 12);
            this.pnlhidemenu.TabIndex = 12;
            this.pnlhidemenu.Visible = false;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 66);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(796, 358);
            this.dockPanel1.TabIndex = 13;
            this.dockPanel1.ActiveContentChanged += new System.EventHandler(this.dockPanel1_ActiveContentChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.MenuStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 29);
            this.panel1.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(231, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(381, 29);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Infoware Consola Administrativa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.DoubleClick += new System.EventHandler(this.lblTitle_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMinimizar,
            this.mnuMaximizar,
            this.mnuRestaurar,
            this.mnuCerrar});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(612, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(184, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMinimizar
            // 
            this.mnuMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuMinimizar.Image = global::Infoware.Consola.Base.Properties.Resources.minimize;
            this.mnuMinimizar.Name = "mnuMinimizar";
            this.mnuMinimizar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mnuMinimizar.Size = new System.Drawing.Size(44, 25);
            this.mnuMinimizar.Text = "Minimizar";
            this.mnuMinimizar.Click += new System.EventHandler(this.mnuMinimizar_Click);
            // 
            // mnuMaximizar
            // 
            this.mnuMaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuMaximizar.Image = global::Infoware.Consola.Base.Properties.Resources.maximize;
            this.mnuMaximizar.Name = "mnuMaximizar";
            this.mnuMaximizar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mnuMaximizar.Size = new System.Drawing.Size(44, 25);
            this.mnuMaximizar.Text = "Maximizar";
            this.mnuMaximizar.Click += new System.EventHandler(this.mnuMaximizar_Click);
            // 
            // mnuRestaurar
            // 
            this.mnuRestaurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuRestaurar.Image = global::Infoware.Consola.Base.Properties.Resources.restore;
            this.mnuRestaurar.Name = "mnuRestaurar";
            this.mnuRestaurar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mnuRestaurar.Size = new System.Drawing.Size(44, 25);
            this.mnuRestaurar.Text = "Restaurar";
            this.mnuRestaurar.Click += new System.EventHandler(this.mnuRestaurar_Click);
            // 
            // mnuCerrar
            // 
            this.mnuCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCerrar.Image = global::Infoware.Consola.Base.Properties.Resources.close;
            this.mnuCerrar.Name = "mnuCerrar";
            this.mnuCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mnuCerrar.Size = new System.Drawing.Size(44, 25);
            this.mnuCerrar.Text = "Cerrar";
            this.mnuCerrar.Click += new System.EventHandler(this.mnuCerrar_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.AllowItemReorder = true;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogo,
            this.FileToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.IrToolStripMenuItem,
            this.PantallaCompletaToolStripMenuItem1});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(231, 29);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // mnuLogo
            // 
            this.mnuLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuLogo.Image = global::Infoware.Consola.Base.Properties.Resources.ica3icon;
            this.mnuLogo.Name = "mnuLogo";
            this.mnuLogo.Size = new System.Drawing.Size(34, 25);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNuevo,
            this.SeparadorNuevo,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.FileToolStripMenuItem.MergeIndex = 0;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.FileToolStripMenuItem.Text = "&Archivo";
            // 
            // MenuNuevo
            // 
            this.MenuNuevo.Image = global::Infoware.Consola.Base.Properties.Resources._new;
            this.MenuNuevo.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuNuevo.MergeIndex = 0;
            this.MenuNuevo.Name = "MenuNuevo";
            this.MenuNuevo.Size = new System.Drawing.Size(135, 26);
            this.MenuNuevo.Text = "&Nuevo";
            this.MenuNuevo.ToolTipText = "Crea un nuevo elemento del sistema";
            this.MenuNuevo.Visible = false;
            // 
            // SeparadorNuevo
            // 
            this.SeparadorNuevo.MergeIndex = 999;
            this.SeparadorNuevo.Name = "SeparadorNuevo";
            this.SeparadorNuevo.Size = new System.Drawing.Size(132, 6);
            this.SeparadorNuevo.Visible = false;
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.MergeIndex = 999;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.ExitToolStripMenuItem.Text = "&Salir";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ediciónToolStripMenuItem.MergeIndex = 1;
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.ediciónToolStripMenuItem.Text = "&Edición";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarToolStripMenuItem,
            this.BarraDeEstadoToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.PantallaCompletaToolStripMenuItem});
            this.ViewToolStripMenuItem.MergeIndex = 2;
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 25);
            this.ViewToolStripMenuItem.Text = "&Ver";
            // 
            // StatusBarToolStripMenuItem
            // 
            this.StatusBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstandarToolStripMenuItem});
            this.StatusBarToolStripMenuItem.MergeIndex = 1000;
            this.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
            this.StatusBarToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.StatusBarToolStripMenuItem.Text = "&Barras de herramientas";
            // 
            // EstandarToolStripMenuItem
            // 
            this.EstandarToolStripMenuItem.Checked = true;
            this.EstandarToolStripMenuItem.CheckOnClick = true;
            this.EstandarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EstandarToolStripMenuItem.MergeIndex = 1001;
            this.EstandarToolStripMenuItem.Name = "EstandarToolStripMenuItem";
            this.EstandarToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.EstandarToolStripMenuItem.Text = "Estándar";
            this.EstandarToolStripMenuItem.Click += new System.EventHandler(this.EstandarToolStripMenuItem_Click);
            // 
            // BarraDeEstadoToolStripMenuItem
            // 
            this.BarraDeEstadoToolStripMenuItem.Checked = true;
            this.BarraDeEstadoToolStripMenuItem.CheckOnClick = true;
            this.BarraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BarraDeEstadoToolStripMenuItem.MergeIndex = 1100;
            this.BarraDeEstadoToolStripMenuItem.Name = "BarraDeEstadoToolStripMenuItem";
            this.BarraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.BarraDeEstadoToolStripMenuItem.Text = "Barra de es&tado";
            this.BarraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.BarraDeEstadoToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.MergeIndex = 1101;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(241, 6);
            // 
            // PantallaCompletaToolStripMenuItem
            // 
            this.PantallaCompletaToolStripMenuItem.CheckOnClick = true;
            this.PantallaCompletaToolStripMenuItem.MergeIndex = 1102;
            this.PantallaCompletaToolStripMenuItem.Name = "PantallaCompletaToolStripMenuItem";
            this.PantallaCompletaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.PantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.PantallaCompletaToolStripMenuItem.Text = "Pantalla completa";
            this.PantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.PantallaCompletaToolStripMenuItem_Click);
            // 
            // IrToolStripMenuItem
            // 
            this.IrToolStripMenuItem.MergeIndex = 4;
            this.IrToolStripMenuItem.Name = "IrToolStripMenuItem";
            this.IrToolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.IrToolStripMenuItem.Text = "&Ir";
            this.IrToolStripMenuItem.Visible = false;
            // 
            // PantallaCompletaToolStripMenuItem1
            // 
            this.PantallaCompletaToolStripMenuItem1.Checked = true;
            this.PantallaCompletaToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PantallaCompletaToolStripMenuItem1.Name = "PantallaCompletaToolStripMenuItem1";
            this.PantallaCompletaToolStripMenuItem1.Size = new System.Drawing.Size(142, 25);
            this.PantallaCompletaToolStripMenuItem1.Text = "Pantalla completa";
            this.PantallaCompletaToolStripMenuItem1.Visible = false;
            this.PantallaCompletaToolStripMenuItem1.Click += new System.EventHandler(this.PantallaCompletaToolStripMenuItem1_Click);
            // 
            // FormBaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.BarraEstandar);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlhidemenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormBaseMain";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip;
        public System.Windows.Forms.ToolStripStatusLabel lblNoConectado;
        public System.Windows.Forms.ToolStripStatusLabel lbl_contectadoa;
        public System.Windows.Forms.ToolStripStatusLabel lblerror;
        public System.Windows.Forms.ToolStrip BarraEstandar;
        public System.Windows.Forms.Panel pnlhidemenu;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        public System.Windows.Forms.ToolStripStatusLabel lblok;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuNuevo;
        internal System.Windows.Forms.ToolStripSeparator SeparadorNuevo;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private MenuEditarHelper ediciónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StatusBarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EstandarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BarraDeEstadoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem PantallaCompletaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem IrToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PantallaCompletaToolStripMenuItem1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMinimizar;
        private System.Windows.Forms.ToolStripMenuItem mnuMaximizar;
        private System.Windows.Forms.ToolStripMenuItem mnuRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrar;
        private System.Windows.Forms.ToolStripMenuItem mnuLogo;
    }
}