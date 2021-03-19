namespace Infoware.Consola.Base
{
    partial class FrmMantenimientoBase
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSepNuevo = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarYcerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarYNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new Infoware.Consola.Base.MenuEditarHelper();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripNuevoGeneral = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripNuevo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripGuardarcerrar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripGuardarnuevo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripAnular = new System.Windows.Forms.ToolStripButton();
            this.ToolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparatorImprimir = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripFormato = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparatorMover = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripAnterior = new System.Windows.Forms.ToolStripSplitButton();
            this.IrAlElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IrAlPrimerElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSiguiente = new System.Windows.Forms.ToolStripSplitButton();
            this.IrAlElementoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IrAlÚltimoElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.MenuStrip1.Size = new System.Drawing.Size(924, 28);
            this.MenuStrip1.TabIndex = 10;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripMenuItem,
            this.ToolStripMenuItemSepNuevo,
            this.guardarToolStripMenuItem,
            this.guardarYcerrarToolStripMenuItem,
            this.guardarYNuevoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem4,
            this.closeToolStripMenuItem});
            this.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // NuevoToolStripMenuItem
            // 
            this.NuevoToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources._new;
            this.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem";
            this.NuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NuevoToolStripMenuItem.Text = "&Nuevo";
            this.NuevoToolStripMenuItem.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // ToolStripMenuItemSepNuevo
            // 
            this.ToolStripMenuItemSepNuevo.Name = "ToolStripMenuItemSepNuevo";
            this.ToolStripMenuItemSepNuevo.Size = new System.Drawing.Size(221, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.save;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // guardarYcerrarToolStripMenuItem
            // 
            this.guardarYcerrarToolStripMenuItem.Name = "guardarYcerrarToolStripMenuItem";
            this.guardarYcerrarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.guardarYcerrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarYcerrarToolStripMenuItem.Text = "Guardar y &cerrar";
            this.guardarYcerrarToolStripMenuItem.Click += new System.EventHandler(this.Guardarcerrar_Click);
            // 
            // guardarYNuevoToolStripMenuItem
            // 
            this.guardarYNuevoToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.saveandnew;
            this.guardarYNuevoToolStripMenuItem.Name = "guardarYNuevoToolStripMenuItem";
            this.guardarYNuevoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.guardarYNuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarYNuevoToolStripMenuItem.Text = "G&uardar y nuevo";
            this.guardarYNuevoToolStripMenuItem.Click += new System.EventHandler(this.Guardarnuevo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.delete;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "&Cerrar";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.EditToolStripMenuItem.MergeIndex = 1;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.EditToolStripMenuItem.Text = "&Edición";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaDinamicaToolStripMenuItem});
            this.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
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
            this.AyudaDinamicaToolStripMenuItem.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNuevoGeneral,
            this.ToolStripNuevo,
            this.ToolStripGuardar,
            this.ToolStripGuardarcerrar,
            this.ToolStripGuardarnuevo,
            this.ToolStripAnular,
            this.ToolStripRefrescar,
            this.ToolStripSeparatorImprimir,
            this.ToolStripImprimir,
            this.ToolStripFormato,
            this.ToolStripSeparatorMover,
            this.ToolStripAnterior,
            this.ToolStripSiguiente,
            this.toolStripSeparator1,
            this.ToolStripButtonAyuda});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(924, 27);
            this.ToolStrip1.TabIndex = 12;
            this.ToolStrip1.Text = "toolStrip2";
            // 
            // ToolStripNuevoGeneral
            // 
            this.ToolStripNuevoGeneral.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripNuevoGeneral.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ToolStripNuevoGeneral.MergeIndex = 0;
            this.ToolStripNuevoGeneral.Name = "ToolStripNuevoGeneral";
            this.ToolStripNuevoGeneral.Size = new System.Drawing.Size(71, 24);
            this.ToolStripNuevoGeneral.Text = "Nuevo";
            this.ToolStripNuevoGeneral.Visible = false;
            // 
            // ToolStripNuevo
            // 
            this.ToolStripNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripNuevo.Image = global::Infoware.Consola.Base.Properties.Resources._new;
            this.ToolStripNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripNuevo.MergeIndex = 0;
            this.ToolStripNuevo.Name = "ToolStripNuevo";
            this.ToolStripNuevo.Size = new System.Drawing.Size(29, 24);
            this.ToolStripNuevo.Text = "Nuevo";
            this.ToolStripNuevo.Visible = false;
            this.ToolStripNuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // ToolStripGuardar
            // 
            this.ToolStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripGuardar.Image = global::Infoware.Consola.Base.Properties.Resources.save;
            this.ToolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripGuardar.MergeIndex = 1;
            this.ToolStripGuardar.Name = "ToolStripGuardar";
            this.ToolStripGuardar.Size = new System.Drawing.Size(29, 24);
            this.ToolStripGuardar.Text = "Guardar";
            this.ToolStripGuardar.Visible = false;
            this.ToolStripGuardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // ToolStripGuardarcerrar
            // 
            this.ToolStripGuardarcerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripGuardarcerrar.MergeIndex = 1;
            this.ToolStripGuardarcerrar.Name = "ToolStripGuardarcerrar";
            this.ToolStripGuardarcerrar.Size = new System.Drawing.Size(158, 24);
            this.ToolStripGuardarcerrar.Text = "Guardar y cerrar <F5>";
            this.ToolStripGuardarcerrar.Visible = false;
            this.ToolStripGuardarcerrar.Click += new System.EventHandler(this.Guardarcerrar_Click);
            // 
            // ToolStripGuardarnuevo
            // 
            this.ToolStripGuardarnuevo.Image = global::Infoware.Consola.Base.Properties.Resources.saveandnew;
            this.ToolStripGuardarnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripGuardarnuevo.MergeIndex = 1;
            this.ToolStripGuardarnuevo.Name = "ToolStripGuardarnuevo";
            this.ToolStripGuardarnuevo.Size = new System.Drawing.Size(180, 24);
            this.ToolStripGuardarnuevo.Text = "Guardar y nuevo <F2>";
            this.ToolStripGuardarnuevo.Click += new System.EventHandler(this.Guardarnuevo_Click);
            // 
            // ToolStripAnular
            // 
            this.ToolStripAnular.Image = global::Infoware.Consola.Base.Properties.Resources.undo;
            this.ToolStripAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAnular.MergeIndex = 2;
            this.ToolStripAnular.Name = "ToolStripAnular";
            this.ToolStripAnular.Size = new System.Drawing.Size(76, 24);
            this.ToolStripAnular.Text = "Anular";
            this.ToolStripAnular.Visible = false;
            this.ToolStripAnular.Click += new System.EventHandler(this.Anular_Click);
            // 
            // ToolStripRefrescar
            // 
            this.ToolStripRefrescar.Image = global::Infoware.Consola.Base.Properties.Resources.refresh;
            this.ToolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripRefrescar.MergeIndex = 2;
            this.ToolStripRefrescar.Name = "ToolStripRefrescar";
            this.ToolStripRefrescar.Size = new System.Drawing.Size(94, 24);
            this.ToolStripRefrescar.Text = "Refrescar";
            this.ToolStripRefrescar.Visible = false;
            this.ToolStripRefrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // ToolStripSeparatorImprimir
            // 
            this.ToolStripSeparatorImprimir.MergeIndex = 3;
            this.ToolStripSeparatorImprimir.Name = "ToolStripSeparatorImprimir";
            this.ToolStripSeparatorImprimir.Size = new System.Drawing.Size(6, 27);
            this.ToolStripSeparatorImprimir.Visible = false;
            // 
            // ToolStripImprimir
            // 
            this.ToolStripImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripImprimir.Image = global::Infoware.Consola.Base.Properties.Resources.print;
            this.ToolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripImprimir.MergeIndex = 3;
            this.ToolStripImprimir.Name = "ToolStripImprimir";
            this.ToolStripImprimir.Size = new System.Drawing.Size(29, 24);
            this.ToolStripImprimir.Text = "Imprimir";
            this.ToolStripImprimir.Visible = false;
            this.ToolStripImprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // ToolStripFormato
            // 
            this.ToolStripFormato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripFormato.Image = global::Infoware.Consola.Base.Properties.Resources.format;
            this.ToolStripFormato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripFormato.MergeIndex = 3;
            this.ToolStripFormato.Name = "ToolStripFormato";
            this.ToolStripFormato.Size = new System.Drawing.Size(29, 24);
            this.ToolStripFormato.Text = "Modificar formato";
            this.ToolStripFormato.Visible = false;
            this.ToolStripFormato.Click += new System.EventHandler(this.Formato_Click);
            // 
            // ToolStripSeparatorMover
            // 
            this.ToolStripSeparatorMover.MergeIndex = 4;
            this.ToolStripSeparatorMover.Name = "ToolStripSeparatorMover";
            this.ToolStripSeparatorMover.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripAnterior
            // 
            this.ToolStripAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripAnterior.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IrAlElementoToolStripMenuItem,
            this.IrAlPrimerElementoToolStripMenuItem});
            this.ToolStripAnterior.Image = global::Infoware.Consola.Base.Properties.Resources.arrowfirst;
            this.ToolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAnterior.MergeIndex = 4;
            this.ToolStripAnterior.Name = "ToolStripAnterior";
            this.ToolStripAnterior.Size = new System.Drawing.Size(39, 24);
            this.ToolStripAnterior.Text = "Ir al elemento anterior";
            this.ToolStripAnterior.ButtonClick += new System.EventHandler(this.Anterior_Click);
            // 
            // IrAlElementoToolStripMenuItem
            // 
            this.IrAlElementoToolStripMenuItem.Name = "IrAlElementoToolStripMenuItem";
            this.IrAlElementoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.IrAlElementoToolStripMenuItem.Text = "Anterior";
            this.IrAlElementoToolStripMenuItem.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // IrAlPrimerElementoToolStripMenuItem
            // 
            this.IrAlPrimerElementoToolStripMenuItem.Name = "IrAlPrimerElementoToolStripMenuItem";
            this.IrAlPrimerElementoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.IrAlPrimerElementoToolStripMenuItem.Text = "Ir al primer elemento";
            this.IrAlPrimerElementoToolStripMenuItem.Click += new System.EventHandler(this.Primero_Click);
            // 
            // ToolStripSiguiente
            // 
            this.ToolStripSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripSiguiente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IrAlElementoToolStripMenuItem1,
            this.IrAlÚltimoElementoToolStripMenuItem});
            this.ToolStripSiguiente.Image = global::Infoware.Consola.Base.Properties.Resources.arrowlast;
            this.ToolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSiguiente.MergeIndex = 4;
            this.ToolStripSiguiente.Name = "ToolStripSiguiente";
            this.ToolStripSiguiente.Size = new System.Drawing.Size(39, 24);
            this.ToolStripSiguiente.Text = "Ir al elemento siguiente";
            this.ToolStripSiguiente.ButtonClick += new System.EventHandler(this.Siguiente_Click);
            // 
            // IrAlElementoToolStripMenuItem1
            // 
            this.IrAlElementoToolStripMenuItem1.Name = "IrAlElementoToolStripMenuItem1";
            this.IrAlElementoToolStripMenuItem1.Size = new System.Drawing.Size(231, 26);
            this.IrAlElementoToolStripMenuItem1.Text = "Siguiente";
            this.IrAlElementoToolStripMenuItem1.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // IrAlÚltimoElementoToolStripMenuItem
            // 
            this.IrAlÚltimoElementoToolStripMenuItem.Name = "IrAlÚltimoElementoToolStripMenuItem";
            this.IrAlÚltimoElementoToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.IrAlÚltimoElementoToolStripMenuItem.Text = "Ir al último elemento";
            this.IrAlÚltimoElementoToolStripMenuItem.Click += new System.EventHandler(this.Ultimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeIndex = 999;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripButtonAyuda
            // 
            this.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAyuda.Image = global::Infoware.Consola.Base.Properties.Resources.help;
            this.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAyuda.MergeIndex = 99;
            this.ToolStripButtonAyuda.Name = "ToolStripButtonAyuda";
            this.ToolStripButtonAyuda.Size = new System.Drawing.Size(29, 24);
            this.ToolStripButtonAyuda.Text = "Ayuda dinámica";
            this.ToolStripButtonAyuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // FrmMantenimientoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "FrmMantenimientoBase";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AyudaDinamicaToolStripMenuItem;
        private MenuEditarHelper EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItemSepNuevo;
        private System.Windows.Forms.ToolStripMenuItem guardarYcerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarYNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripSplitButton ToolStripNuevoGeneral;
        internal System.Windows.Forms.ToolStripButton ToolStripNuevo;
        internal System.Windows.Forms.ToolStripButton ToolStripGuardar;
        internal System.Windows.Forms.ToolStripButton ToolStripGuardarcerrar;
        internal System.Windows.Forms.ToolStripButton ToolStripGuardarnuevo;
        internal System.Windows.Forms.ToolStripButton ToolStripAnular;
        internal System.Windows.Forms.ToolStripButton ToolStripRefrescar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparatorImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripFormato;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparatorMover;
        internal System.Windows.Forms.ToolStripSplitButton ToolStripAnterior;
        internal System.Windows.Forms.ToolStripMenuItem IrAlElementoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem IrAlPrimerElementoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSplitButton ToolStripSiguiente;
        internal System.Windows.Forms.ToolStripMenuItem IrAlElementoToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem IrAlÚltimoElementoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonAyuda;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}