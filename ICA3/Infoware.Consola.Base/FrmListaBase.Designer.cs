﻿namespace Infoware.Consola.Base
{
    partial class FrmListaBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerStrip1 = new Infoware.Consola.Base.HeaderStrip();
            this.ToolStriptitulo = new System.Windows.Forms.ToolStripLabel();
            this.btnbuscar = new System.Windows.Forms.ToolStripButton();
            this.btncancelarbuscar = new System.Windows.Forms.ToolStripButton();
            this.combobuscar = new System.Windows.Forms.ToolStripComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pnlcuerpo = new System.Windows.Forms.Panel();
            this.DataGridView1 = new Infoware.Consola.Base.DataGridViewAutoDiscover();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LinkAgregar = new System.Windows.Forms.LinkLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnexportar = new System.Windows.Forms.ToolStripButton();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btncorreo = new System.Windows.Forms.ToolStripButton();
            this.btnword = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnseleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btnrefrescar = new System.Windows.Forms.ToolStripButton();
            this.lblmessage = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CorreoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionToolStripMenuItem = new Infoware.Consola.Base.MenuEditarHelper();
            this.VerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.headerStrip1.SuspendLayout();
            this.pnlcuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
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
            this.ToolStriptitulo,
            this.btnbuscar,
            this.btncancelarbuscar,
            this.combobuscar});
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
            // btnbuscar
            // 
            this.btnbuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbuscar.Image = global::Infoware.Consola.Base.Properties.Resources.search;
            this.btnbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(29, 29);
            this.btnbuscar.Text = "Buscar ahora";
            // 
            // btncancelarbuscar
            // 
            this.btncancelarbuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btncancelarbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncancelarbuscar.Image = global::Infoware.Consola.Base.Properties.Resources.cancel;
            this.btncancelarbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancelarbuscar.Name = "btncancelarbuscar";
            this.btncancelarbuscar.Size = new System.Drawing.Size(29, 29);
            this.btncancelarbuscar.Text = "Cancelar búsqueda";
            this.btncancelarbuscar.Visible = false;
            this.btncancelarbuscar.Click += new System.EventHandler(this.btncancelarbuscar_Click);
            // 
            // combobuscar
            // 
            this.combobuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.combobuscar.Name = "combobuscar";
            this.combobuscar.Size = new System.Drawing.Size(199, 32);
            this.combobuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combobuscar_KeyPress);
            this.combobuscar.Validated += new System.EventHandler(this.Combobuscar_Validated);
            this.combobuscar.TextChanged += new System.EventHandler(this.Combobuscar_TextChanged);
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
            this.pnlcuerpo.Controls.Add(this.DataGridView1);
            this.pnlcuerpo.Controls.Add(this.LinkAgregar);
            this.pnlcuerpo.Controls.Add(this.Panel1);
            this.pnlcuerpo.Controls.Add(this.headerStrip1);
            this.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcuerpo.Location = new System.Drawing.Point(0, 55);
            this.pnlcuerpo.Name = "pnlcuerpo";
            this.pnlcuerpo.Size = new System.Drawing.Size(924, 458);
            this.pnlcuerpo.TabIndex = 9;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AgruparRepetidos = false;
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.DataSource = this.BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.Location = new System.Drawing.Point(0, 131);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(924, 327);
            this.DataGridView1.StandardTab = true;
            this.DataGridView1.TabIndex = 8;
            this.DataGridView1.DespuesSeleccionarCampos += new System.EventHandler(this.DataGridView1_DespuesSeleccionarCampos);
            this.DataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // LinkAgregar
            // 
            this.LinkAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LinkAgregar.Location = new System.Drawing.Point(0, 113);
            this.LinkAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkAgregar.Name = "LinkAgregar";
            this.LinkAgregar.Size = new System.Drawing.Size(924, 18);
            this.LinkAgregar.TabIndex = 9;
            this.LinkAgregar.TabStop = true;
            this.LinkAgregar.Text = "Agregar";
            this.LinkAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAgregar_LinkClicked);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnexportar,
            this.btnimprimir,
            this.btncorreo,
            this.btnword,
            this.toolStripSeparator1,
            this.ToolStripAbrir,
            this.btnseleccionar,
            this.toolStripSeparator3,
            this.btneliminar,
            this.btnrefrescar,
            this.lblmessage,
            this.ToolStripSeparator2,
            this.ToolStripButtonAyuda});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(924, 27);
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
            this.btnexportar.Size = new System.Drawing.Size(29, 24);
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
            this.btnimprimir.Size = new System.Drawing.Size(29, 24);
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // btncorreo
            // 
            this.btncorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncorreo.Image = global::Infoware.Consola.Base.Properties.Resources.attach;
            this.btncorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncorreo.Name = "btncorreo";
            this.btncorreo.Size = new System.Drawing.Size(29, 24);
            this.btncorreo.Text = "Enviar por correo";
            this.btncorreo.Click += new System.EventHandler(this.Correo_Click);
            // 
            // btnword
            // 
            this.btnword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnword.Image = global::Infoware.Consola.Base.Properties.Resources.docword;
            this.btnword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(29, 24);
            this.btnword.Text = "Enviar a Microsoft Word";
            this.btnword.Visible = false;
            this.btnword.Click += new System.EventHandler(this.Word_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripAbrir
            // 
            this.ToolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripAbrir.Image = global::Infoware.Consola.Base.Properties.Resources.open;
            this.ToolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAbrir.MergeIndex = 0;
            this.ToolStripAbrir.Name = "ToolStripAbrir";
            this.ToolStripAbrir.Size = new System.Drawing.Size(29, 24);
            this.ToolStripAbrir.Text = "Abrir elemento seleccionado";
            this.ToolStripAbrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnseleccionar.MergeIndex = 99;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(89, 24);
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.Visible = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.MergeIndex = 0;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btneliminar
            // 
            this.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btneliminar.Image = global::Infoware.Consola.Base.Properties.Resources.delete;
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.MergeIndex = 0;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btneliminar.Size = new System.Drawing.Size(29, 24);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrefrescar.Image = global::Infoware.Consola.Base.Properties.Resources.refresh;
            this.btnrefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefrescar.MergeIndex = 0;
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(29, 24);
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 24);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.MergeIndex = 99;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EdicionToolStripMenuItem,
            this.VerToolStripMenuItem,
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
            this.abrirToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExportarToolStripMenuItem,
            this.CorreoToolStripMenuItem1,
            this.WordToolStripMenuItem1,
            this.ImprimirToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.CerrarToolStripMenuItem});
            this.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // ExportarToolStripMenuItem
            // 
            this.ExportarToolStripMenuItem.Image = global::Infoware.Consola.Base.Properties.Resources.docexcel;
            this.ExportarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ExportarToolStripMenuItem.MergeIndex = 1;
            this.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem";
            this.ExportarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ExportarToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
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
            this.CorreoToolStripMenuItem1.Size = new System.Drawing.Size(261, 26);
            this.CorreoToolStripMenuItem1.Text = "En&viar por correo";
            this.CorreoToolStripMenuItem1.Click += new System.EventHandler(this.Correo_Click);
            // 
            // WordToolStripMenuItem1
            // 
            this.WordToolStripMenuItem1.Image = global::Infoware.Consola.Base.Properties.Resources.docword;
            this.WordToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.WordToolStripMenuItem1.MergeIndex = 2;
            this.WordToolStripMenuItem1.Name = "WordToolStripMenuItem1";
            this.WordToolStripMenuItem1.Size = new System.Drawing.Size(261, 26);
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
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.ImprimirToolStripMenuItem.Text = "&Imprimir";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(258, 6);
            // 
            // CerrarToolStripMenuItem
            // 
            this.CerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem";
            this.CerrarToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.CerrarToolStripMenuItem.Text = "&Cerrar";
            this.CerrarToolStripMenuItem.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // EdicionToolStripMenuItem
            // 
            this.EdicionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.EdicionToolStripMenuItem.MergeIndex = 1;
            this.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem";
            this.EdicionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.EdicionToolStripMenuItem.Text = "&Edición";
            // 
            // VerToolStripMenuItem
            // 
            this.VerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActualizarToolStripMenuItem});
            this.VerToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.VerToolStripMenuItem.MergeIndex = 2;
            this.VerToolStripMenuItem.Name = "VerToolStripMenuItem";
            this.VerToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.VerToolStripMenuItem.Text = "&Ver";
            // 
            // ActualizarToolStripMenuItem
            // 
            this.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem";
            this.ActualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.ActualizarToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.ActualizarToolStripMenuItem.Text = "&Actualizar";
            this.ActualizarToolStripMenuItem.Click += new System.EventHandler(this.Actualizar_Click);
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
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmListaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.pnlcuerpo);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "FrmListaBase";
            this.headerStrip1.ResumeLayout(false);
            this.headerStrip1.PerformLayout();
            this.pnlcuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
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
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnexportar;
        internal System.Windows.Forms.ToolStripButton btnimprimir;
        internal System.Windows.Forms.ToolStripButton btncorreo;
        internal System.Windows.Forms.ToolStripButton btnword;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
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
        private MenuEditarHelper EdicionToolStripMenuItem;
        public DataGridViewAutoDiscover DataGridView1;
        internal System.Windows.Forms.LinkLabel LinkAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripAbrir;
        internal System.Windows.Forms.ToolStripButton btnseleccionar;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton btneliminar;
        internal System.Windows.Forms.ToolStripButton btnrefrescar;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem VerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ActualizarToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripButton btnbuscar;
        internal System.Windows.Forms.ToolStripButton btncancelarbuscar;
        public System.Windows.Forms.ToolStripComboBox combobuscar;
        private System.Windows.Forms.ToolStripLabel lblmessage;
        public System.Windows.Forms.Panel pnlcuerpo;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}