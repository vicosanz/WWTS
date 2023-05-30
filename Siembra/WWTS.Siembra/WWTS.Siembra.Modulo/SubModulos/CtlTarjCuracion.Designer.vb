<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlTarjCuracion
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlTarjCuracion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pn1 = New System.Windows.Forms.Panel()
        Me.txtNumEns = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn3 = New System.Windows.Forms.Panel()
        Me.CtlZafra1 = New Siembra.CtlZafra()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboTipoTabaco = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.nuevo = New System.Windows.Forms.PictureBox()
        Me.grabar = New System.Windows.Forms.PictureBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btneli = New System.Windows.Forms.ToolStripButton()
        Me.btnguardar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CtlSeccionHorno1 = New Siembra.CtlSeccionHorno()
        Me.CtlSemilla1 = New Siembra.CtlSemilla()
        Me.CtlLote1 = New Siembra.CtlLote()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDetalles = New System.Windows.Forms.Button()
        Me.DGDetalles = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.BSDetalles = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpCortes = New System.Windows.Forms.GroupBox()
        Me.DGCortes = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.BSCortes = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSCortes = New System.Windows.Forms.ToolStrip()
        Me.btnnuevocorte = New System.Windows.Forms.ToolStripButton()
        Me.btneliminarcorte = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.crpTarjeta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pn1.SuspendLayout()
        Me.pn3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grabar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCortes.SuspendLayout()
        CType(Me.DGCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSCortes.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 185)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pn1)
        Me.GroupBox2.Controls.Add(Me.pn3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(250, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(578, 185)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'pn1
        '
        Me.pn1.Controls.Add(Me.txtNumEns)
        Me.pn1.Controls.Add(Me.Label1)
        Me.pn1.Location = New System.Drawing.Point(16, 25)
        Me.pn1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pn1.Name = "pn1"
        Me.pn1.Size = New System.Drawing.Size(344, 40)
        Me.pn1.TabIndex = 0
        '
        'txtNumEns
        '
        Me.txtNumEns.Location = New System.Drawing.Point(144, 5)
        Me.txtNumEns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumEns.Name = "txtNumEns"
        Me.txtNumEns.Size = New System.Drawing.Size(180, 26)
        Me.txtNumEns.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num. Curación"
        '
        'pn3
        '
        Me.pn3.Controls.Add(Me.CtlZafra1)
        Me.pn3.Controls.Add(Me.Label14)
        Me.pn3.Controls.Add(Me.cboTipoTabaco)
        Me.pn3.Controls.Add(Me.dtpFecha)
        Me.pn3.Controls.Add(Me.Label12)
        Me.pn3.Controls.Add(Me.Label3)
        Me.pn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn3.Enabled = False
        Me.pn3.Location = New System.Drawing.Point(4, 24)
        Me.pn3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pn3.Name = "pn3"
        Me.pn3.Size = New System.Drawing.Size(570, 156)
        Me.pn3.TabIndex = 1
        '
        'CtlZafra1
        '
        Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlZafra1.FormattingEnabled = True
        Me.CtlZafra1.Location = New System.Drawing.Point(156, 42)
        Me.CtlZafra1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CtlZafra1.Name = "CtlZafra1"
        Me.CtlZafra1.Op = Nothing
        Me.CtlZafra1.PuedeActualizar = True
        Me.CtlZafra1.PuedeEliminar = True
        Me.CtlZafra1.PuedeModificar = True
        Me.CtlZafra1.PuedeNuevo = True
        Me.CtlZafra1.Size = New System.Drawing.Size(180, 28)
        Me.CtlZafra1.TabIndex = 1
        Me.CtlZafra1.Zafra = Nothing
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 46)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Zafra"
        '
        'cboTipoTabaco
        '
        Me.cboTipoTabaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoTabaco.FormattingEnabled = True
        Me.cboTipoTabaco.Location = New System.Drawing.Point(156, 117)
        Me.cboTipoTabaco.Name = "cboTipoTabaco"
        Me.cboTipoTabaco.OperadorDatos = Nothing
        Me.cboTipoTabaco.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboTipoTabaco.ParametroDet = Nothing
        Me.cboTipoTabaco.PuedeActualizar = True
        Me.cboTipoTabaco.PuedeEliminar = True
        Me.cboTipoTabaco.PuedeModificar = True
        Me.cboTipoTabaco.PuedeNuevo = True
        Me.cboTipoTabaco.Size = New System.Drawing.Size(180, 28)
        Me.cboTipoTabaco.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(156, 80)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(180, 26)
        Me.dtpFecha.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 120)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Tipo de tabaco"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Curación"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.nuevo)
        Me.Panel3.Controls.Add(Me.grabar)
        Me.Panel3.Controls.Add(Me.ToolStrip2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 185)
        Me.Panel3.TabIndex = 23
        '
        'nuevo
        '
        Me.nuevo.Image = CType(resources.GetObject("nuevo.Image"), System.Drawing.Image)
        Me.nuevo.Location = New System.Drawing.Point(90, 83)
        Me.nuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(60, 49)
        Me.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nuevo.TabIndex = 28
        Me.nuevo.TabStop = False
        '
        'grabar
        '
        Me.grabar.Image = CType(resources.GetObject("grabar.Image"), System.Drawing.Image)
        Me.grabar.Location = New System.Drawing.Point(90, 83)
        Me.grabar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(60, 49)
        Me.grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.grabar.TabIndex = 27
        Me.grabar.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.btneli, Me.btnguardar, Me.btnImprimir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(250, 33)
        Me.ToolStrip2.TabIndex = 26
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnnuevo
        '
        Me.btnnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevo.Image = Global.Siembra.My.Resources.Resources.nuevo
        Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(34, 28)
        Me.btnnuevo.Text = "Nueva tarjeta"
        '
        'btneli
        '
        Me.btneli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneli.Image = Global.Siembra.My.Resources.Resources.eliminar
        Me.btneli.ImageTransparentColor = System.Drawing.Color.White
        Me.btneli.Name = "btneli"
        Me.btneli.Size = New System.Drawing.Size(34, 28)
        Me.btneli.Text = "Eliminar tarjeta"
        '
        'btnguardar
        '
        Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnguardar.Image = Global.Siembra.My.Resources.Resources.save16
        Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(34, 28)
        Me.btnguardar.Text = "Guardar cambios"
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = Global.Siembra.My.Resources.Resources.print
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(34, 28)
        Me.btnImprimir.Text = "Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CtlSeccionHorno1)
        Me.GroupBox1.Controls.Add(Me.CtlSemilla1)
        Me.GroupBox1.Controls.Add(Me.CtlLote1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(3, 188)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(828, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CtlSeccionHorno1
        '
        Me.CtlSeccionHorno1.Location = New System.Drawing.Point(537, 17)
        Me.CtlSeccionHorno1.Margin = New System.Windows.Forms.Padding(6)
        Me.CtlSeccionHorno1.Name = "CtlSeccionHorno1"
        Me.CtlSeccionHorno1.Op = Nothing
        Me.CtlSeccionHorno1.SeccionHorno = Nothing
        Me.CtlSeccionHorno1.Size = New System.Drawing.Size(279, 228)
        Me.CtlSeccionHorno1.TabIndex = 7
        '
        'CtlSemilla1
        '
        Me.CtlSemilla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlSemilla1.FormattingEnabled = True
        Me.CtlSemilla1.Location = New System.Drawing.Point(124, 140)
        Me.CtlSemilla1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CtlSemilla1.Name = "CtlSemilla1"
        Me.CtlSemilla1.Op = Nothing
        Me.CtlSemilla1.PuedeActualizar = True
        Me.CtlSemilla1.PuedeEliminar = True
        Me.CtlSemilla1.PuedeModificar = True
        Me.CtlSemilla1.PuedeNuevo = True
        Me.CtlSemilla1.Semilla = Nothing
        Me.CtlSemilla1.Size = New System.Drawing.Size(248, 28)
        Me.CtlSemilla1.TabIndex = 3
        '
        'CtlLote1
        '
        Me.CtlLote1.Location = New System.Drawing.Point(124, 17)
        Me.CtlLote1.Lote = Nothing
        Me.CtlLote1.Margin = New System.Windows.Forms.Padding(6)
        Me.CtlLote1.Name = "CtlLote1"
        Me.CtlLote1.Op = Nothing
        Me.CtlLote1.Size = New System.Drawing.Size(250, 115)
        Me.CtlLote1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(404, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 31)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Horno/Sección:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 145)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 31)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Semilla:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 17)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 31)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lote:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(124, 622)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(180, 26)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 623)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha inicio"
        '
        'btnDetalles
        '
        Me.btnDetalles.Location = New System.Drawing.Point(315, 620)
        Me.btnDetalles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(182, 35)
        Me.btnDetalles.TabIndex = 8
        Me.btnDetalles.Text = "Generar detalles"
        Me.btnDetalles.UseVisualStyleBackColor = True
        Me.btnDetalles.Visible = False
        '
        'DGDetalles
        '
        Me.DGDetalles.AgruparRepetidos = False
        Me.DGDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDetalles.AutoGenerateColumns = False
        Me.DGDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDetalles.DataSource = Me.BSDetalles
        Me.DGDetalles.Location = New System.Drawing.Point(2, 665)
        Me.DGDetalles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGDetalles.Name = "DGDetalles"
        Me.DGDetalles.RowHeadersWidth = 62
        Me.DGDetalles.Size = New System.Drawing.Size(832, 340)
        Me.DGDetalles.TabIndex = 10
        '
        'BSDetalles
        '
        Me.BSDetalles.AllowNew = False
        '
        'grpCortes
        '
        Me.grpCortes.Controls.Add(Me.DGCortes)
        Me.grpCortes.Controls.Add(Me.TSCortes)
        Me.grpCortes.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpCortes.Location = New System.Drawing.Point(3, 439)
        Me.grpCortes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpCortes.Name = "grpCortes"
        Me.grpCortes.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpCortes.Size = New System.Drawing.Size(828, 182)
        Me.grpCortes.TabIndex = 1
        Me.grpCortes.TabStop = False
        Me.grpCortes.Text = "Cortes"
        '
        'DGCortes
        '
        Me.DGCortes.AgruparRepetidos = False
        Me.DGCortes.AutoGenerateColumns = False
        Me.DGCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCortes.DataSource = Me.BSCortes
        Me.DGCortes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGCortes.Location = New System.Drawing.Point(4, 57)
        Me.DGCortes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGCortes.Name = "DGCortes"
        Me.DGCortes.RowHeadersWidth = 62
        Me.DGCortes.Size = New System.Drawing.Size(820, 120)
        Me.DGCortes.TabIndex = 10
        '
        'BSCortes
        '
        Me.BSCortes.AllowNew = False
        '
        'TSCortes
        '
        Me.TSCortes.Enabled = False
        Me.TSCortes.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TSCortes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevocorte, Me.btneliminarcorte})
        Me.TSCortes.Location = New System.Drawing.Point(4, 24)
        Me.TSCortes.Name = "TSCortes"
        Me.TSCortes.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.TSCortes.Size = New System.Drawing.Size(820, 33)
        Me.TSCortes.TabIndex = 27
        Me.TSCortes.Text = "ToolStrip1"
        '
        'btnnuevocorte
        '
        Me.btnnuevocorte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevocorte.Image = Global.Siembra.My.Resources.Resources.nuevo
        Me.btnnuevocorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevocorte.Name = "btnnuevocorte"
        Me.btnnuevocorte.Size = New System.Drawing.Size(34, 28)
        Me.btnnuevocorte.Text = "Nuevo corte"
        '
        'btneliminarcorte
        '
        Me.btneliminarcorte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneliminarcorte.Image = Global.Siembra.My.Resources.Resources.eliminar
        Me.btneliminarcorte.ImageTransparentColor = System.Drawing.Color.White
        Me.btneliminarcorte.Name = "btneliminarcorte"
        Me.btneliminarcorte.Size = New System.Drawing.Size(34, 28)
        Me.btneliminarcorte.Text = "Eliminar corte"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 1046)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGDetalles)
        Me.TabPage1.Controls.Add(Me.grpCortes)
        Me.TabPage1.Controls.Add(Me.btnDetalles)
        Me.TabPage1.Controls.Add(Me.dtpFechaInicio)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(834, 1013)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tarjeta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.crpTarjeta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(834, 1013)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vista previa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'crpTarjeta
        '
        Me.crpTarjeta.ActiveViewIndex = -1
        Me.crpTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpTarjeta.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpTarjeta.Location = New System.Drawing.Point(3, 3)
        Me.crpTarjeta.Name = "crpTarjeta"
        Me.crpTarjeta.Size = New System.Drawing.Size(828, 1007)
        Me.crpTarjeta.TabIndex = 0
        '
        'CtlTarjCuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CtlTarjCuracion"
        Me.Size = New System.Drawing.Size(842, 1046)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.pn1.ResumeLayout(False)
        Me.pn1.PerformLayout()
        Me.pn3.ResumeLayout(False)
        Me.pn3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grabar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCortes.ResumeLayout(False)
        Me.grpCortes.PerformLayout()
        CType(Me.DGCortes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSCortes.ResumeLayout(False)
        Me.TSCortes.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneli As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents pn1 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txtNumEns As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pn3 As System.Windows.Forms.Panel
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents nuevo As System.Windows.Forms.PictureBox
  Friend WithEvents grabar As System.Windows.Forms.PictureBox
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CtlSeccionHorno1 As CtlSeccionHorno
    Friend WithEvents CtlSemilla1 As CtlSemilla
    Friend WithEvents CtlLote1 As CtlLote
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTipoTabaco As WWTS.General.Controles.ComboBoxParametroDet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DGDetalles As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents btnDetalles As Button
    Friend WithEvents BSDetalles As BindingSource
    Friend WithEvents BSCortes As BindingSource
    Friend WithEvents grpCortes As GroupBox
    Friend WithEvents DGCortes As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents TSCortes As ToolStrip
    Friend WithEvents btnnuevocorte As ToolStripButton
    Friend WithEvents btneliminarcorte As ToolStripButton
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents crpTarjeta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
