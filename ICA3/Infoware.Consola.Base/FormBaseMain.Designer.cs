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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
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
            this.pnlhidemenu = new System.Windows.Forms.Panel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ListBindingSource)).BeginInit();
            this.StatusStrip.SuspendLayout();
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
            this.StatusStrip.Location = new System.Drawing.Point(0, 425);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusStrip.Size = new System.Drawing.Size(800, 25);
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
            this.BarraEstandar.Location = new System.Drawing.Point(0, 40);
            this.BarraEstandar.Name = "BarraEstandar";
            this.BarraEstandar.Size = new System.Drawing.Size(800, 25);
            this.BarraEstandar.TabIndex = 11;
            this.BarraEstandar.Text = "ToolStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.AllowItemReorder = true;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.IrToolStripMenuItem,
            this.PantallaCompletaToolStripMenuItem1});
            this.MenuStrip.Location = new System.Drawing.Point(0, 12);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip.TabIndex = 10;
            this.MenuStrip.Text = "MenuStrip1";
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
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.FileToolStripMenuItem.Text = "&Archivo";
            // 
            // MenuNuevo
            // 
            this.MenuNuevo.Image = global::Infoware.Consola.Base.Properties.Resources._new;
            this.MenuNuevo.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuNuevo.MergeIndex = 0;
            this.MenuNuevo.Name = "MenuNuevo";
            this.MenuNuevo.Size = new System.Drawing.Size(127, 26);
            this.MenuNuevo.Text = "&Nuevo";
            this.MenuNuevo.ToolTipText = "Crea un nuevo elemento del sistema";
            this.MenuNuevo.Visible = false;
            // 
            // SeparadorNuevo
            // 
            this.SeparadorNuevo.MergeIndex = 999;
            this.SeparadorNuevo.Name = "SeparadorNuevo";
            this.SeparadorNuevo.Size = new System.Drawing.Size(124, 6);
            this.SeparadorNuevo.Visible = false;
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.MergeIndex = 999;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.ExitToolStripMenuItem.Text = "&Salir";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ediciónToolStripMenuItem.MergeIndex = 1;
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
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
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.ViewToolStripMenuItem.Text = "&Ver";
            // 
            // StatusBarToolStripMenuItem
            // 
            this.StatusBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstandarToolStripMenuItem});
            this.StatusBarToolStripMenuItem.MergeIndex = 1000;
            this.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
            this.StatusBarToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.StatusBarToolStripMenuItem.Text = "&Barras de herramientas";
            // 
            // EstandarToolStripMenuItem
            // 
            this.EstandarToolStripMenuItem.Checked = true;
            this.EstandarToolStripMenuItem.CheckOnClick = true;
            this.EstandarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EstandarToolStripMenuItem.MergeIndex = 1001;
            this.EstandarToolStripMenuItem.Name = "EstandarToolStripMenuItem";
            this.EstandarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
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
            this.BarraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.BarraDeEstadoToolStripMenuItem.Text = "Barra de es&tado";
            this.BarraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.BarraDeEstadoToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.MergeIndex = 1101;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // PantallaCompletaToolStripMenuItem
            // 
            this.PantallaCompletaToolStripMenuItem.CheckOnClick = true;
            this.PantallaCompletaToolStripMenuItem.MergeIndex = 1102;
            this.PantallaCompletaToolStripMenuItem.Name = "PantallaCompletaToolStripMenuItem";
            this.PantallaCompletaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.PantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.PantallaCompletaToolStripMenuItem.Text = "Pantalla completa";
            this.PantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.PantallaCompletaToolStripMenuItem_Click);
            // 
            // IrToolStripMenuItem
            // 
            this.IrToolStripMenuItem.MergeIndex = 4;
            this.IrToolStripMenuItem.Name = "IrToolStripMenuItem";
            this.IrToolStripMenuItem.Size = new System.Drawing.Size(30, 24);
            this.IrToolStripMenuItem.Text = "&Ir";
            this.IrToolStripMenuItem.Visible = false;
            // 
            // PantallaCompletaToolStripMenuItem1
            // 
            this.PantallaCompletaToolStripMenuItem1.Checked = true;
            this.PantallaCompletaToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PantallaCompletaToolStripMenuItem1.Name = "PantallaCompletaToolStripMenuItem1";
            this.PantallaCompletaToolStripMenuItem1.Size = new System.Drawing.Size(140, 24);
            this.PantallaCompletaToolStripMenuItem1.Text = "Pantalla completa";
            this.PantallaCompletaToolStripMenuItem1.Visible = false;
            this.PantallaCompletaToolStripMenuItem1.Click += new System.EventHandler(this.PantallaCompletaToolStripMenuItem1_Click);
            // 
            // pnlhidemenu
            // 
            this.pnlhidemenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlhidemenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhidemenu.Location = new System.Drawing.Point(0, 0);
            this.pnlhidemenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlhidemenu.Name = "pnlhidemenu";
            this.pnlhidemenu.Size = new System.Drawing.Size(800, 12);
            this.pnlhidemenu.TabIndex = 12;
            this.pnlhidemenu.Visible = false;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 65);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(800, 360);
            this.dockPanel1.TabIndex = 13;
            this.dockPanel1.ActiveContentChanged += new System.EventHandler(this.dockPanel1_ActiveContentChanged);
            // 
            // FormBaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.BarraEstandar);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.pnlhidemenu);
            this.Controls.Add(this.StatusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormBaseMain";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.ListBindingSource)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
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
        public System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuNuevo;
        internal System.Windows.Forms.ToolStripSeparator SeparadorNuevo;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StatusBarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EstandarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BarraDeEstadoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem PantallaCompletaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem IrToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PantallaCompletaToolStripMenuItem1;
        public System.Windows.Forms.Panel pnlhidemenu;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private MenuEditarHelper ediciónToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel lblok;
    }
}