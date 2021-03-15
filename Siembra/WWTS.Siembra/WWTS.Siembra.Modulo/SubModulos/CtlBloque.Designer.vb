<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBloque
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlBloque))
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.rdoroto = New System.Windows.Forms.RadioButton
    Me.rdosano = New System.Windows.Forms.RadioButton
    Me.txtobservaciones = New System.Windows.Forms.TextBox
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.rdopintado = New System.Windows.Forms.RadioButton
    Me.rdolimpio = New System.Windows.Forms.RadioButton
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Label13 = New System.Windows.Forms.Label
    Me.Label10 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.grpmovimientos = New System.Windows.Forms.GroupBox
    Me.dgmovimientos = New System.Windows.Forms.DataGridView
    Me.ToolStrip = New System.Windows.Forms.ToolStrip
    Me.btnanadir = New System.Windows.Forms.ToolStripButton
    Me.btnmodificar = New System.Windows.Forms.ToolStripButton
    Me.btneliminar = New System.Windows.Forms.ToolStripButton
    Me.pn1 = New System.Windows.Forms.Panel
    Me.CtlZafra1 = New WWTS.Siembra.Modulo.CtlZafra
    Me.Label14 = New System.Windows.Forms.Label
    Me.txtNumBloque = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.pn3 = New System.Windows.Forms.Panel
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
    Me.btnnuevo = New System.Windows.Forms.ToolStripButton
    Me.btneli = New System.Windows.Forms.ToolStripButton
    Me.btnguardar = New System.Windows.Forms.ToolStripButton
    Me.grabar = New System.Windows.Forms.PictureBox
    Me.nuevo = New System.Windows.Forms.PictureBox
    Me.Panel4 = New System.Windows.Forms.Panel
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.CtlSemilla1 = New WWTS.Siembra.Modulo.CtlSemilla
    Me.CtlLote1 = New WWTS.Siembra.Modulo.CtlLote
    Me.CtlCorte1 = New WWTS.Siembra.Modulo.CtlCorte
    Me.Label2 = New System.Windows.Forms.Label
    Me.ElementoListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BloqueMovCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BlmtipoIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.BlmfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CuartoOrigenStrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CuartoDestinoStrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.BlmnumcajasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.BlmlibrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Panel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.grpmovimientos.SuspendLayout()
    CType(Me.dgmovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip.SuspendLayout()
    Me.pn1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    CType(Me.grabar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel4.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.ElementoListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BloqueMovCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'rdoroto
    '
    Me.rdoroto.Location = New System.Drawing.Point(84, 0)
    Me.rdoroto.Name = "rdoroto"
    Me.rdoroto.Size = New System.Drawing.Size(60, 16)
    Me.rdoroto.TabIndex = 1
    Me.rdoroto.Text = "Roto"
    '
    'rdosano
    '
    Me.rdosano.Checked = True
    Me.rdosano.Location = New System.Drawing.Point(4, 0)
    Me.rdosano.Name = "rdosano"
    Me.rdosano.Size = New System.Drawing.Size(60, 16)
    Me.rdosano.TabIndex = 0
    Me.rdosano.TabStop = True
    Me.rdosano.Text = "Sano"
    '
    'txtobservaciones
    '
    Me.txtobservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtobservaciones.Location = New System.Drawing.Point(87, 132)
    Me.txtobservaciones.Name = "txtobservaciones"
    Me.txtobservaciones.Size = New System.Drawing.Size(445, 20)
    Me.txtobservaciones.TabIndex = 16
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.rdopintado)
    Me.Panel2.Controls.Add(Me.rdolimpio)
    Me.Panel2.Location = New System.Drawing.Point(359, 94)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(152, 20)
    Me.Panel2.TabIndex = 11
    '
    'rdopintado
    '
    Me.rdopintado.Location = New System.Drawing.Point(84, 0)
    Me.rdopintado.Name = "rdopintado"
    Me.rdopintado.Size = New System.Drawing.Size(68, 16)
    Me.rdopintado.TabIndex = 1
    Me.rdopintado.Text = "Pintado"
    '
    'rdolimpio
    '
    Me.rdolimpio.Checked = True
    Me.rdolimpio.Location = New System.Drawing.Point(4, 0)
    Me.rdolimpio.Name = "rdolimpio"
    Me.rdolimpio.Size = New System.Drawing.Size(68, 16)
    Me.rdolimpio.TabIndex = 0
    Me.rdolimpio.TabStop = True
    Me.rdolimpio.Text = "Limpio"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Transparent
    Me.Panel1.Controls.Add(Me.rdoroto)
    Me.Panel1.Controls.Add(Me.rdosano)
    Me.Panel1.Location = New System.Drawing.Point(359, 70)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(152, 20)
    Me.Panel1.TabIndex = 10
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.BackColor = System.Drawing.Color.Transparent
    Me.Label13.Location = New System.Drawing.Point(271, 19)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(32, 13)
    Me.Label13.TabIndex = 2
    Me.Label13.Text = "Corte"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.BackColor = System.Drawing.Color.Transparent
    Me.Label10.Location = New System.Drawing.Point(271, 46)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(43, 13)
    Me.Label10.TabIndex = 4
    Me.Label10.Text = "Semilla:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 135)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(81, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Observaciones:"
    '
    'grpmovimientos
    '
    Me.grpmovimientos.BackColor = System.Drawing.Color.Transparent
    Me.grpmovimientos.Controls.Add(Me.dgmovimientos)
    Me.grpmovimientos.Controls.Add(Me.ToolStrip)
    Me.grpmovimientos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpmovimientos.Location = New System.Drawing.Point(0, 247)
    Me.grpmovimientos.Name = "grpmovimientos"
    Me.grpmovimientos.Size = New System.Drawing.Size(548, 265)
    Me.grpmovimientos.TabIndex = 24
    Me.grpmovimientos.TabStop = False
    Me.grpmovimientos.Text = "Movimientos"
    Me.grpmovimientos.Visible = False
    '
    'dgmovimientos
    '
    Me.dgmovimientos.AllowUserToAddRows = False
    Me.dgmovimientos.AutoGenerateColumns = False
    Me.dgmovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgmovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BlmtipoIntDataGridViewTextBoxColumn, Me.BlmfechaDataGridViewTextBoxColumn, Me.CuartoOrigenStrDataGridViewTextBoxColumn, Me.CuartoDestinoStrDataGridViewTextBoxColumn, Me.BlmnumcajasDataGridViewTextBoxColumn, Me.BlmlibrasDataGridViewTextBoxColumn})
    Me.dgmovimientos.DataSource = Me.BloqueMovCollectionBindingSource
    Me.dgmovimientos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgmovimientos.Location = New System.Drawing.Point(27, 16)
    Me.dgmovimientos.Name = "dgmovimientos"
    Me.dgmovimientos.ReadOnly = True
    Me.dgmovimientos.Size = New System.Drawing.Size(518, 246)
    Me.dgmovimientos.TabIndex = 24
    '
    'ToolStrip
    '
    Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.Left
    Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnanadir, Me.btnmodificar, Me.btneliminar})
    Me.ToolStrip.Location = New System.Drawing.Point(3, 16)
    Me.ToolStrip.Name = "ToolStrip"
    Me.ToolStrip.Size = New System.Drawing.Size(24, 246)
    Me.ToolStrip.TabIndex = 23
    Me.ToolStrip.Text = "ToolStrip1"
    '
    'btnanadir
    '
    Me.btnanadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnanadir.Image = My.Resources.nuevo
    Me.btnanadir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnanadir.Name = "btnanadir"
    Me.btnanadir.Size = New System.Drawing.Size(21, 20)
    Me.btnanadir.Text = "Nuevo"
    '
    'btnmodificar
    '
    Me.btnmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnmodificar.Image = My.Resources.abrir
    Me.btnmodificar.ImageTransparentColor = System.Drawing.Color.White
    Me.btnmodificar.Name = "btnmodificar"
    Me.btnmodificar.Size = New System.Drawing.Size(21, 20)
    Me.btnmodificar.Text = "Modificar"
    '
    'btneliminar
    '
    Me.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminar.Image = My.Resources.eliminar
    Me.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(21, 20)
    Me.btneliminar.Text = "Eliminar"
    '
    'pn1
    '
    Me.pn1.Controls.Add(Me.CtlZafra1)
    Me.pn1.Controls.Add(Me.Label14)
    Me.pn1.Controls.Add(Me.txtNumBloque)
    Me.pn1.Controls.Add(Me.Label1)
    Me.pn1.Location = New System.Drawing.Point(11, 16)
    Me.pn1.Name = "pn1"
    Me.pn1.Size = New System.Drawing.Size(229, 52)
    Me.pn1.TabIndex = 0
    '
    'CtlZafra1
    '
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(96, 4)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(121, 21)
    Me.CtlZafra1.TabIndex = 4
    Me.CtlZafra1.Zafra = Nothing
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(3, 7)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(32, 13)
    Me.Label14.TabIndex = 0
    Me.Label14.Text = "Zafra"
    '
    'txtNumBloque
    '
    Me.txtNumBloque.Location = New System.Drawing.Point(96, 28)
    Me.txtNumBloque.Name = "txtNumBloque"
    Me.txtNumBloque.Size = New System.Drawing.Size(80, 20)
    Me.txtNumBloque.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.Location = New System.Drawing.Point(3, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Bloque"
    '
    'pn3
    '
    Me.pn3.BackColor = System.Drawing.Color.Transparent
    Me.pn3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pn3.Enabled = False
    Me.pn3.Location = New System.Drawing.Point(3, 16)
    Me.pn3.Name = "pn3"
    Me.pn3.Size = New System.Drawing.Size(375, 64)
    Me.pn3.TabIndex = 1
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "")
    Me.ImageList1.Images.SetKeyName(1, "")
    Me.ImageList1.Images.SetKeyName(2, "")
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.pn1)
    Me.GroupBox2.Controls.Add(Me.pn3)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(167, 0)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(381, 83)
    Me.GroupBox2.TabIndex = 20
    Me.GroupBox2.TabStop = False
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.ToolStrip2)
    Me.Panel3.Controls.Add(Me.grabar)
    Me.Panel3.Controls.Add(Me.nuevo)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(167, 83)
    Me.Panel3.TabIndex = 21
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.btneli, Me.btnguardar})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(167, 25)
    Me.ToolStrip2.TabIndex = 26
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnnuevo
    '
    Me.btnnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevo.Image = My.Resources.nuevo
    Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(23, 22)
    Me.btnnuevo.Text = "ToolStripButton1"
    '
    'btneli
    '
    Me.btneli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneli.Image = My.Resources.eliminar
    Me.btneli.ImageTransparentColor = System.Drawing.Color.White
    Me.btneli.Name = "btneli"
    Me.btneli.Size = New System.Drawing.Size(23, 22)
    Me.btneli.Text = "ToolStripButton2"
    '
    'btnguardar
    '
    Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnguardar.Image = My.Resources.save16
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(23, 22)
    Me.btnguardar.Text = "ToolStripButton3"
    '
    'grabar
    '
    Me.grabar.Image = CType(resources.GetObject("grabar.Image"), System.Drawing.Image)
    Me.grabar.Location = New System.Drawing.Point(64, 40)
    Me.grabar.Name = "grabar"
    Me.grabar.Size = New System.Drawing.Size(32, 32)
    Me.grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.grabar.TabIndex = 21
    Me.grabar.TabStop = False
    '
    'nuevo
    '
    Me.nuevo.Image = CType(resources.GetObject("nuevo.Image"), System.Drawing.Image)
    Me.nuevo.Location = New System.Drawing.Point(64, 40)
    Me.nuevo.Name = "nuevo"
    Me.nuevo.Size = New System.Drawing.Size(32, 32)
    Me.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.nuevo.TabIndex = 22
    Me.nuevo.TabStop = False
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.Color.Transparent
    Me.Panel4.Controls.Add(Me.GroupBox2)
    Me.Panel4.Controls.Add(Me.Panel3)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel4.Location = New System.Drawing.Point(0, 0)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(548, 83)
    Me.Panel4.TabIndex = 25
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Panel2)
    Me.GroupBox1.Controls.Add(Me.CtlSemilla1)
    Me.GroupBox1.Controls.Add(Me.Panel1)
    Me.GroupBox1.Controls.Add(Me.CtlLote1)
    Me.GroupBox1.Controls.Add(Me.CtlCorte1)
    Me.GroupBox1.Controls.Add(Me.txtobservaciones)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label13)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Location = New System.Drawing.Point(0, 83)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(548, 164)
    Me.GroupBox1.TabIndex = 26
    Me.GroupBox1.TabStop = False
    '
    'CtlSemilla1
    '
    Me.CtlSemilla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSemilla1.FormattingEnabled = True
    Me.CtlSemilla1.Location = New System.Drawing.Point(359, 43)
    Me.CtlSemilla1.Name = "CtlSemilla1"
    Me.CtlSemilla1.Op = Nothing
    Me.CtlSemilla1.PuedeActualizar = True
    Me.CtlSemilla1.PuedeEliminar = True
    Me.CtlSemilla1.PuedeModificar = True
    Me.CtlSemilla1.PuedeNuevo = True
    Me.CtlSemilla1.Semilla = Nothing
    Me.CtlSemilla1.Size = New System.Drawing.Size(121, 21)
    Me.CtlSemilla1.TabIndex = 19
    '
    'CtlLote1
    '
    Me.CtlLote1.Location = New System.Drawing.Point(87, 16)
    Me.CtlLote1.Lote = Nothing
    Me.CtlLote1.Name = "CtlLote1"
    Me.CtlLote1.Op = Nothing
    Me.CtlLote1.Size = New System.Drawing.Size(158, 110)
    Me.CtlLote1.TabIndex = 20
    '
    'CtlCorte1
    '
    Me.CtlCorte1.Corte = Nothing
    Me.CtlCorte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlCorte1.FormattingEnabled = True
    Me.CtlCorte1.Location = New System.Drawing.Point(359, 16)
    Me.CtlCorte1.Name = "CtlCorte1"
    Me.CtlCorte1.Op = Nothing
    Me.CtlCorte1.PuedeActualizar = True
    Me.CtlCorte1.PuedeEliminar = True
    Me.CtlCorte1.PuedeModificar = True
    Me.CtlCorte1.PuedeNuevo = True
    Me.CtlCorte1.Size = New System.Drawing.Size(121, 21)
    Me.CtlCorte1.TabIndex = 18
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(6, 19)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Lote"
    '
    'ElementoListBindingSource
    '
    Me.ElementoListBindingSource.DataSource = GetType(WWTS.General.Reglas.ElementoList)
    '
    'BloqueMovCollectionBindingSource
    '
    Me.BloqueMovCollectionBindingSource.DataSource = GetType(WWTS.Siembra.Reglas.BloqueMovCollection)
    '
    'BlmtipoIntDataGridViewTextBoxColumn
    '
    Me.BlmtipoIntDataGridViewTextBoxColumn.DataPropertyName = "Blm_tipoInt"
    Me.BlmtipoIntDataGridViewTextBoxColumn.DataSource = Me.ElementoListBindingSource
    Me.BlmtipoIntDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
    Me.BlmtipoIntDataGridViewTextBoxColumn.HeaderText = "Tipo"
    Me.BlmtipoIntDataGridViewTextBoxColumn.Name = "BlmtipoIntDataGridViewTextBoxColumn"
    Me.BlmtipoIntDataGridViewTextBoxColumn.ReadOnly = True
    Me.BlmtipoIntDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.BlmtipoIntDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.BlmtipoIntDataGridViewTextBoxColumn.ValueMember = "Numero"
    '
    'BlmfechaDataGridViewTextBoxColumn
    '
    Me.BlmfechaDataGridViewTextBoxColumn.DataPropertyName = "Blm_fecha"
    DataGridViewCellStyle1.Format = "d"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.BlmfechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
    Me.BlmfechaDataGridViewTextBoxColumn.FillWeight = 90.0!
    Me.BlmfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
    Me.BlmfechaDataGridViewTextBoxColumn.Name = "BlmfechaDataGridViewTextBoxColumn"
    Me.BlmfechaDataGridViewTextBoxColumn.ReadOnly = True
    Me.BlmfechaDataGridViewTextBoxColumn.Width = 90
    '
    'CuartoOrigenStrDataGridViewTextBoxColumn
    '
    Me.CuartoOrigenStrDataGridViewTextBoxColumn.DataPropertyName = "CuartoOrigenStr"
    Me.CuartoOrigenStrDataGridViewTextBoxColumn.FillWeight = 75.0!
    Me.CuartoOrigenStrDataGridViewTextBoxColumn.HeaderText = "De cuarto"
    Me.CuartoOrigenStrDataGridViewTextBoxColumn.Name = "CuartoOrigenStrDataGridViewTextBoxColumn"
    Me.CuartoOrigenStrDataGridViewTextBoxColumn.ReadOnly = True
    Me.CuartoOrigenStrDataGridViewTextBoxColumn.Width = 75
    '
    'CuartoDestinoStrDataGridViewTextBoxColumn
    '
    Me.CuartoDestinoStrDataGridViewTextBoxColumn.DataPropertyName = "CuartoDestinoStr"
    Me.CuartoDestinoStrDataGridViewTextBoxColumn.FillWeight = 75.0!
    Me.CuartoDestinoStrDataGridViewTextBoxColumn.HeaderText = "a cuarto"
    Me.CuartoDestinoStrDataGridViewTextBoxColumn.Name = "CuartoDestinoStrDataGridViewTextBoxColumn"
    Me.CuartoDestinoStrDataGridViewTextBoxColumn.ReadOnly = True
    Me.CuartoDestinoStrDataGridViewTextBoxColumn.Width = 75
    '
    'BlmnumcajasDataGridViewTextBoxColumn
    '
    Me.BlmnumcajasDataGridViewTextBoxColumn.DataPropertyName = "Blm_numcajas"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N0"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.BlmnumcajasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
    Me.BlmnumcajasDataGridViewTextBoxColumn.FillWeight = 80.0!
    Me.BlmnumcajasDataGridViewTextBoxColumn.HeaderText = "Cajas"
    Me.BlmnumcajasDataGridViewTextBoxColumn.Name = "BlmnumcajasDataGridViewTextBoxColumn"
    Me.BlmnumcajasDataGridViewTextBoxColumn.ReadOnly = True
    Me.BlmnumcajasDataGridViewTextBoxColumn.Width = 80
    '
    'BlmlibrasDataGridViewTextBoxColumn
    '
    Me.BlmlibrasDataGridViewTextBoxColumn.DataPropertyName = "Blm_libras"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "N2"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.BlmlibrasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
    Me.BlmlibrasDataGridViewTextBoxColumn.FillWeight = 80.0!
    Me.BlmlibrasDataGridViewTextBoxColumn.HeaderText = "Kilos"
    Me.BlmlibrasDataGridViewTextBoxColumn.Name = "BlmlibrasDataGridViewTextBoxColumn"
    Me.BlmlibrasDataGridViewTextBoxColumn.ReadOnly = True
    Me.BlmlibrasDataGridViewTextBoxColumn.Width = 80
    '
    'CtlBloque
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.grpmovimientos)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Panel4)
    Me.Name = "CtlBloque"
    Me.Size = New System.Drawing.Size(548, 512)
    Me.Panel2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.grpmovimientos.ResumeLayout(False)
    Me.grpmovimientos.PerformLayout()
    CType(Me.dgmovimientos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip.ResumeLayout(False)
    Me.ToolStrip.PerformLayout()
    Me.pn1.ResumeLayout(False)
    Me.pn1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    CType(Me.grabar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nuevo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel4.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.ElementoListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BloqueMovCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents rdoroto As System.Windows.Forms.RadioButton
  Friend WithEvents rdosano As System.Windows.Forms.RadioButton
  Friend WithEvents CtlSemilla1 As WWTS.Siembra.Modulo.CtlSemilla
  Friend WithEvents CtlCorte1 As WWTS.Siembra.Modulo.CtlCorte
  Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents rdopintado As System.Windows.Forms.RadioButton
  Friend WithEvents rdolimpio As System.Windows.Forms.RadioButton
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents grpmovimientos As System.Windows.Forms.GroupBox
  Friend WithEvents pn1 As System.Windows.Forms.Panel
  Friend WithEvents CtlZafra1 As WWTS.Siembra.Modulo.CtlZafra
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txtNumBloque As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pn3 As System.Windows.Forms.Panel
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents grabar As System.Windows.Forms.PictureBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents nuevo As System.Windows.Forms.PictureBox
  Friend WithEvents CtlLote1 As WWTS.Siembra.Modulo.CtlLote
  Friend WithEvents dgmovimientos As System.Windows.Forms.DataGridView
  Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents btnanadir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnmodificar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneli As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ElementoListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents BloqueMovCollectionBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents BlmtipoIntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents BlmfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuartoOrigenStrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuartoDestinoStrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BlmnumcajasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BlmlibrasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
