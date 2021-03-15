<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlInvCajas
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlInvCajas))
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.pn1 = New System.Windows.Forms.Panel
    Me.CtlZafra1 = New WWTS.Siembra.Modulo.CtlZafra
    Me.Label14 = New System.Windows.Forms.Label
    Me.txtNumEmp = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.pn3 = New System.Windows.Forms.Panel
    Me.rdonatural = New System.Windows.Forms.RadioButton
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtNumEmb = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.rdocandela = New System.Windows.Forms.RadioButton
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.pictnuevo = New System.Windows.Forms.PictureBox
    Me.pictgrabar = New System.Windows.Forms.PictureBox
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
    Me.btnnuevo = New System.Windows.Forms.ToolStripButton
    Me.btneli = New System.Windows.Forms.ToolStripButton
    Me.btnguardar = New System.Windows.Forms.ToolStripButton
    Me.groupbox1 = New System.Windows.Forms.GroupBox
    Me.pnlcolor = New System.Windows.Forms.Panel
    Me.CtlColorHoja1 = New WWTS.Siembra.Modulo.CtlColorHoja
    Me.Label4 = New System.Windows.Forms.Label
    Me.CtlTerreno1 = New WWTS.Siembra.Modulo.CtlTerreno
    Me.CtlBodega1 = New WWTS.Siembra.Modulo.CtlBodega
    Me.CtlSemilla1 = New WWTS.Siembra.Modulo.CtlSemilla
    Me.CtlCorte1 = New WWTS.Siembra.Modulo.CtlCorte
    Me.CtlClaseHoja1 = New WWTS.Siembra.Modulo.CtlClaseHoja
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label13 = New System.Windows.Forms.Label
    Me.Label9 = New System.Windows.Forms.Label
    Me.Label10 = New System.Windows.Forms.Label
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.txtpeson = New Infoware.Controles.Base.TextBoxCalculator
    Me.txttara = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtprecio = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtpesob = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label15 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label18 = New System.Windows.Forms.Label
    Me.pn2 = New System.Windows.Forms.Panel
    Me.Panel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.pn1.SuspendLayout()
    Me.pn3.SuspendLayout()
    Me.Panel3.SuspendLayout()
    CType(Me.pictnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pictgrabar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.groupbox1.SuspendLayout()
    Me.pnlcolor.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.pn2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.Panel3)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(597, 108)
    Me.Panel1.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.pn1)
    Me.GroupBox2.Controls.Add(Me.pn3)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(167, 0)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(430, 108)
    Me.GroupBox2.TabIndex = 23
    Me.GroupBox2.TabStop = False
    '
    'pn1
    '
    Me.pn1.Controls.Add(Me.CtlZafra1)
    Me.pn1.Controls.Add(Me.Label14)
    Me.pn1.Controls.Add(Me.txtNumEmp)
    Me.pn1.Controls.Add(Me.Label1)
    Me.pn1.Location = New System.Drawing.Point(11, 16)
    Me.pn1.Name = "pn1"
    Me.pn1.Size = New System.Drawing.Size(226, 52)
    Me.pn1.TabIndex = 0
    '
    'CtlZafra1
    '
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(96, 1)
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
    Me.Label14.Location = New System.Drawing.Point(0, 3)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(33, 13)
    Me.Label14.TabIndex = 0
    Me.Label14.Text = "Zafra"
    '
    'txtNumEmp
    '
    Me.txtNumEmp.Location = New System.Drawing.Point(96, 28)
    Me.txtNumEmp.Name = "txtNumEmp"
    Me.txtNumEmp.Size = New System.Drawing.Size(80, 22)
    Me.txtNumEmp.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.Location = New System.Drawing.Point(0, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(85, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Num. Empaque"
    '
    'pn3
    '
    Me.pn3.Controls.Add(Me.rdonatural)
    Me.pn3.Controls.Add(Me.dtpFecha)
    Me.pn3.Controls.Add(Me.Label3)
    Me.pn3.Controls.Add(Me.txtNumEmb)
    Me.pn3.Controls.Add(Me.Label2)
    Me.pn3.Controls.Add(Me.rdocandela)
    Me.pn3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pn3.Enabled = False
    Me.pn3.Location = New System.Drawing.Point(3, 18)
    Me.pn3.Name = "pn3"
    Me.pn3.Size = New System.Drawing.Size(424, 87)
    Me.pn3.TabIndex = 1
    '
    'rdonatural
    '
    Me.rdonatural.Checked = True
    Me.rdonatural.Location = New System.Drawing.Point(329, 27)
    Me.rdonatural.Name = "rdonatural"
    Me.rdonatural.Size = New System.Drawing.Size(80, 16)
    Me.rdonatural.TabIndex = 6
    Me.rdonatural.TabStop = True
    Me.rdonatural.Text = "Natural"
    '
    'dtpFecha
    '
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(104, 56)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(104, 22)
    Me.dtpFecha.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(8, 60)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(88, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Fecha Empaque"
    '
    'txtNumEmb
    '
    Me.txtNumEmb.Location = New System.Drawing.Point(329, 1)
    Me.txtNumEmb.Name = "txtNumEmb"
    Me.txtNumEmb.Size = New System.Drawing.Size(80, 22)
    Me.txtNumEmb.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.ForeColor = System.Drawing.Color.Black
    Me.Label2.Location = New System.Drawing.Point(240, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(89, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Num. Embarque"
    '
    'rdocandela
    '
    Me.rdocandela.Location = New System.Drawing.Point(329, 49)
    Me.rdocandela.Name = "rdocandela"
    Me.rdocandela.Size = New System.Drawing.Size(80, 16)
    Me.rdocandela.TabIndex = 7
    Me.rdocandela.Text = "Candela"
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.pictnuevo)
    Me.Panel3.Controls.Add(Me.pictgrabar)
    Me.Panel3.Controls.Add(Me.ToolStrip2)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(167, 108)
    Me.Panel3.TabIndex = 22
    '
    'pictnuevo
    '
    Me.pictnuevo.Image = CType(resources.GetObject("pictnuevo.Image"), System.Drawing.Image)
    Me.pictnuevo.Location = New System.Drawing.Point(63, 57)
    Me.pictnuevo.Name = "pictnuevo"
    Me.pictnuevo.Size = New System.Drawing.Size(40, 32)
    Me.pictnuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pictnuevo.TabIndex = 28
    Me.pictnuevo.TabStop = False
    '
    'pictgrabar
    '
    Me.pictgrabar.Image = CType(resources.GetObject("pictgrabar.Image"), System.Drawing.Image)
    Me.pictgrabar.Location = New System.Drawing.Point(63, 57)
    Me.pictgrabar.Name = "pictgrabar"
    Me.pictgrabar.Size = New System.Drawing.Size(40, 32)
    Me.pictgrabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pictgrabar.TabIndex = 27
    Me.pictgrabar.TabStop = False
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
    'groupbox1
    '
    Me.groupbox1.Controls.Add(Me.pnlcolor)
    Me.groupbox1.Controls.Add(Me.CtlTerreno1)
    Me.groupbox1.Controls.Add(Me.CtlBodega1)
    Me.groupbox1.Controls.Add(Me.CtlSemilla1)
    Me.groupbox1.Controls.Add(Me.CtlCorte1)
    Me.groupbox1.Controls.Add(Me.CtlClaseHoja1)
    Me.groupbox1.Controls.Add(Me.Label11)
    Me.groupbox1.Controls.Add(Me.Label8)
    Me.groupbox1.Controls.Add(Me.Label13)
    Me.groupbox1.Controls.Add(Me.Label9)
    Me.groupbox1.Controls.Add(Me.Label10)
    Me.groupbox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.groupbox1.Location = New System.Drawing.Point(0, 0)
    Me.groupbox1.Name = "groupbox1"
    Me.groupbox1.Size = New System.Drawing.Size(597, 190)
    Me.groupbox1.TabIndex = 1
    Me.groupbox1.TabStop = False
    '
    'pnlcolor
    '
    Me.pnlcolor.Controls.Add(Me.CtlColorHoja1)
    Me.pnlcolor.Controls.Add(Me.Label4)
    Me.pnlcolor.Location = New System.Drawing.Point(0, 90)
    Me.pnlcolor.Name = "pnlcolor"
    Me.pnlcolor.Size = New System.Drawing.Size(274, 96)
    Me.pnlcolor.TabIndex = 2
    '
    'CtlColorHoja1
    '
    Me.CtlColorHoja1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.CtlColorHoja1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CtlColorHoja1.ColorHoja = Nothing
    Me.CtlColorHoja1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.CtlColorHoja1.FormattingEnabled = True
    Me.CtlColorHoja1.Location = New System.Drawing.Point(67, 3)
    Me.CtlColorHoja1.Name = "CtlColorHoja1"
    Me.CtlColorHoja1.Op = Nothing
    Me.CtlColorHoja1.PuedeActualizar = True
    Me.CtlColorHoja1.PuedeEliminar = True
    Me.CtlColorHoja1.PuedeModificar = True
    Me.CtlColorHoja1.PuedeNuevo = True
    Me.CtlColorHoja1.Size = New System.Drawing.Size(181, 91)
    Me.CtlColorHoja1.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 7)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(35, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Color"
    '
    'CtlTerreno1
    '
    Me.CtlTerreno1.Location = New System.Drawing.Point(353, 104)
    Me.CtlTerreno1.Name = "CtlTerreno1"
    Me.CtlTerreno1.Op = Nothing
    Me.CtlTerreno1.Size = New System.Drawing.Size(192, 83)
    Me.CtlTerreno1.TabIndex = 10
    Me.CtlTerreno1.Terreno = Nothing
    '
    'CtlBodega1
    '
    Me.CtlBodega1.Bodega = Nothing
    Me.CtlBodega1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlBodega1.FormattingEnabled = True
    Me.CtlBodega1.Location = New System.Drawing.Point(353, 77)
    Me.CtlBodega1.Name = "CtlBodega1"
    Me.CtlBodega1.Op = Nothing
    Me.CtlBodega1.PuedeActualizar = True
    Me.CtlBodega1.PuedeEliminar = True
    Me.CtlBodega1.PuedeModificar = True
    Me.CtlBodega1.PuedeNuevo = True
    Me.CtlBodega1.Size = New System.Drawing.Size(192, 21)
    Me.CtlBodega1.TabIndex = 8
    '
    'CtlSemilla1
    '
    Me.CtlSemilla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSemilla1.FormattingEnabled = True
    Me.CtlSemilla1.Location = New System.Drawing.Point(353, 45)
    Me.CtlSemilla1.Name = "CtlSemilla1"
    Me.CtlSemilla1.Op = Nothing
    Me.CtlSemilla1.PuedeActualizar = True
    Me.CtlSemilla1.PuedeEliminar = True
    Me.CtlSemilla1.PuedeModificar = True
    Me.CtlSemilla1.PuedeNuevo = True
    Me.CtlSemilla1.Semilla = Nothing
    Me.CtlSemilla1.Size = New System.Drawing.Size(192, 21)
    Me.CtlSemilla1.TabIndex = 6
    '
    'CtlCorte1
    '
    Me.CtlCorte1.Corte = Nothing
    Me.CtlCorte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlCorte1.FormattingEnabled = True
    Me.CtlCorte1.Location = New System.Drawing.Point(353, 13)
    Me.CtlCorte1.Name = "CtlCorte1"
    Me.CtlCorte1.Op = Nothing
    Me.CtlCorte1.PuedeActualizar = True
    Me.CtlCorte1.PuedeEliminar = True
    Me.CtlCorte1.PuedeModificar = True
    Me.CtlCorte1.PuedeNuevo = True
    Me.CtlCorte1.Size = New System.Drawing.Size(192, 21)
    Me.CtlCorte1.TabIndex = 4
    '
    'CtlClaseHoja1
    '
    Me.CtlClaseHoja1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.CtlClaseHoja1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CtlClaseHoja1.ClaseHoja = Nothing
    Me.CtlClaseHoja1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.CtlClaseHoja1.FormattingEnabled = True
    Me.CtlClaseHoja1.Location = New System.Drawing.Point(67, 13)
    Me.CtlClaseHoja1.Name = "CtlClaseHoja1"
    Me.CtlClaseHoja1.Op = Nothing
    Me.CtlClaseHoja1.PuedeActualizar = True
    Me.CtlClaseHoja1.PuedeEliminar = True
    Me.CtlClaseHoja1.PuedeModificar = True
    Me.CtlClaseHoja1.PuedeNuevo = True
    Me.CtlClaseHoja1.Size = New System.Drawing.Size(181, 65)
    Me.CtlClaseHoja1.TabIndex = 1
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(286, 48)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(43, 13)
    Me.Label11.TabIndex = 5
    Me.Label11.Text = "Semilla"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(6, 16)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(34, 13)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "Clase"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(286, 16)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(35, 13)
    Me.Label13.TabIndex = 3
    Me.Label13.Text = "Corte"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(286, 80)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(47, 13)
    Me.Label9.TabIndex = 7
    Me.Label9.Text = "Bodega"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.ForeColor = System.Drawing.Color.Black
    Me.Label10.Location = New System.Drawing.Point(286, 104)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(34, 13)
    Me.Label10.TabIndex = 9
    Me.Label10.Text = "Finca"
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.txtpeson)
    Me.GroupBox3.Controls.Add(Me.txttara)
    Me.GroupBox3.Controls.Add(Me.txtprecio)
    Me.GroupBox3.Controls.Add(Me.txtpesob)
    Me.GroupBox3.Controls.Add(Me.Label15)
    Me.GroupBox3.Controls.Add(Me.Label5)
    Me.GroupBox3.Controls.Add(Me.Label6)
    Me.GroupBox3.Controls.Add(Me.Label18)
    Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox3.Location = New System.Drawing.Point(0, 190)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(597, 169)
    Me.GroupBox3.TabIndex = 2
    Me.GroupBox3.TabStop = False
    '
    'txtpeson
    '
    Me.txtpeson.Location = New System.Drawing.Point(479, 13)
    Me.txtpeson.Name = "txtpeson"
    Me.txtpeson.Size = New System.Drawing.Size(100, 22)
    Me.txtpeson.TabIndex = 11
    Me.txtpeson.Text = "0"
    Me.txtpeson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtpeson.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtpeson.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'txttara
    '
    Me.txttara.Location = New System.Drawing.Point(274, 13)
    Me.txttara.Name = "txttara"
    Me.txttara.Size = New System.Drawing.Size(100, 22)
    Me.txttara.TabIndex = 11
    Me.txttara.Text = "0"
    Me.txttara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttara.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txttara.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'txtprecio
    '
    Me.txtprecio.Location = New System.Drawing.Point(67, 45)
    Me.txtprecio.Name = "txtprecio"
    Me.txtprecio.Size = New System.Drawing.Size(100, 22)
    Me.txtprecio.TabIndex = 11
    Me.txtprecio.Text = "0"
    Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtprecio.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtprecio.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'txtpesob
    '
    Me.txtpesob.Location = New System.Drawing.Point(67, 13)
    Me.txtpesob.Name = "txtpesob"
    Me.txtpesob.Size = New System.Drawing.Size(100, 22)
    Me.txtpesob.TabIndex = 11
    Me.txtpesob.Text = "0"
    Me.txtpesob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtpesob.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtpesob.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(6, 16)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(63, 13)
    Me.Label15.TabIndex = 7
    Me.Label15.Text = "Peso Bruto"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(206, 16)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(28, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Tara"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(6, 48)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(38, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Precio"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(398, 16)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(62, 13)
    Me.Label18.TabIndex = 9
    Me.Label18.Text = "Peso Neto "
    '
    'pn2
    '
    Me.pn2.Controls.Add(Me.GroupBox3)
    Me.pn2.Controls.Add(Me.groupbox1)
    Me.pn2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pn2.Location = New System.Drawing.Point(0, 108)
    Me.pn2.Name = "pn2"
    Me.pn2.Size = New System.Drawing.Size(597, 359)
    Me.pn2.TabIndex = 3
    '
    'CtlInvCajas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.pn2)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "CtlInvCajas"
    Me.Size = New System.Drawing.Size(597, 467)
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.pn1.ResumeLayout(False)
    Me.pn1.PerformLayout()
    Me.pn3.ResumeLayout(False)
    Me.pn3.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    CType(Me.pictnuevo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pictgrabar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.groupbox1.ResumeLayout(False)
    Me.groupbox1.PerformLayout()
    Me.pnlcolor.ResumeLayout(False)
    Me.pnlcolor.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.pn2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents pn1 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txtNumEmp As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pn3 As System.Windows.Forms.Panel
  Friend WithEvents rdonatural As System.Windows.Forms.RadioButton
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtNumEmb As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents rdocandela As System.Windows.Forms.RadioButton
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents pictnuevo As System.Windows.Forms.PictureBox
  Friend WithEvents pictgrabar As System.Windows.Forms.PictureBox
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneli As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents CtlZafra1 As WWTS.Siembra.Modulo.CtlZafra
  Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
  Friend WithEvents pnlcolor As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents CtlTerreno1 As WWTS.Siembra.Modulo.CtlTerreno
  Friend WithEvents CtlBodega1 As WWTS.Siembra.Modulo.CtlBodega
  Friend WithEvents CtlSemilla1 As WWTS.Siembra.Modulo.CtlSemilla
  Friend WithEvents CtlCorte1 As WWTS.Siembra.Modulo.CtlCorte
  Friend WithEvents CtlClaseHoja1 As WWTS.Siembra.Modulo.CtlClaseHoja
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents CtlColorHoja1 As WWTS.Siembra.Modulo.CtlColorHoja
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents txtpeson As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txttara As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtprecio As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtpesob As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents pn2 As System.Windows.Forms.Panel

End Class
