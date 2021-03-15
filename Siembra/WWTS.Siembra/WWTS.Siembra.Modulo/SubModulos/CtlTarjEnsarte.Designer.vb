<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlTarjEnsarte
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlTarjEnsarte))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.pn1 = New System.Windows.Forms.Panel()
    Me.CtlZafra1 = New WWTS.Siembra.Modulo.CtlZafra()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.txtNumEns = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.pn3 = New System.Windows.Forms.Panel()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.nuevo = New System.Windows.Forms.PictureBox()
    Me.grabar = New System.Windows.Forms.PictureBox()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
    Me.btneli = New System.Windows.Forms.ToolStripButton()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.txtcujescand = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtcujesnat = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.CtlSeccionHorno1 = New WWTS.Siembra.Modulo.CtlSeccionHorno()
    Me.CtlCorte1 = New WWTS.Siembra.Modulo.CtlCorte()
    Me.CtlSemilla1 = New WWTS.Siembra.Modulo.CtlSemilla()
    Me.CtlLote1 = New WWTS.Siembra.Modulo.CtlLote()
    Me.chkestazafada = New System.Windows.Forms.CheckBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.grpzafada = New System.Windows.Forms.GroupBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.grptabnat = New System.Windows.Forms.GroupBox()
    Me.txtlibzafnat = New Infoware.Controles.Base.TextBoxCalculator()
    Me.dtfeczafnat = New System.Windows.Forms.DateTimePicker()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.grptabcand = New System.Windows.Forms.GroupBox()
    Me.txtlibzafcand = New Infoware.Controles.Base.TextBoxCalculator()
    Me.dtfeczafcand = New System.Windows.Forms.DateTimePicker()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cboCicloEnsarte = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Panel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.pn1.SuspendLayout()
    Me.pn3.SuspendLayout()
    Me.Panel3.SuspendLayout()
    CType(Me.nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grabar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.grpzafada.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.grptabnat.SuspendLayout()
    Me.grptabcand.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.Panel3)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(748, 148)
    Me.Panel1.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.pn1)
    Me.GroupBox2.Controls.Add(Me.pn3)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(223, 0)
    Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox2.Size = New System.Drawing.Size(525, 148)
    Me.GroupBox2.TabIndex = 24
    Me.GroupBox2.TabStop = False
    '
    'pn1
    '
    Me.pn1.Controls.Add(Me.CtlZafra1)
    Me.pn1.Controls.Add(Me.Label14)
    Me.pn1.Controls.Add(Me.txtNumEns)
    Me.pn1.Controls.Add(Me.Label1)
    Me.pn1.Location = New System.Drawing.Point(15, 20)
    Me.pn1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.pn1.Name = "pn1"
    Me.pn1.Size = New System.Drawing.Size(305, 60)
    Me.pn1.TabIndex = 0
    '
    'CtlZafra1
    '
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(128, 1)
    Me.CtlZafra1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(160, 24)
    Me.CtlZafra1.TabIndex = 4
    Me.CtlZafra1.Zafra = Nothing
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(0, 5)
    Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(42, 17)
    Me.Label14.TabIndex = 0
    Me.Label14.Text = "Zafra"
    '
    'txtNumEns
    '
    Me.txtNumEns.Location = New System.Drawing.Point(128, 33)
    Me.txtNumEns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtNumEns.Name = "txtNumEns"
    Me.txtNumEns.Size = New System.Drawing.Size(160, 22)
    Me.txtNumEns.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.Location = New System.Drawing.Point(0, 36)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(128, 20)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Num. Ensarte"
    '
    'pn3
    '
    Me.pn3.Controls.Add(Me.cboCicloEnsarte)
    Me.pn3.Controls.Add(Me.dtpFecha)
    Me.pn3.Controls.Add(Me.Label12)
    Me.pn3.Controls.Add(Me.Label3)
    Me.pn3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pn3.Enabled = False
    Me.pn3.Location = New System.Drawing.Point(4, 19)
    Me.pn3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.pn3.Name = "pn3"
    Me.pn3.Size = New System.Drawing.Size(517, 125)
    Me.pn3.TabIndex = 1
    '
    'dtpFecha
    '
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(139, 64)
    Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(160, 22)
    Me.dtpFecha.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(11, 69)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(128, 20)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Fecha Ensarte"
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.nuevo)
    Me.Panel3.Controls.Add(Me.grabar)
    Me.Panel3.Controls.Add(Me.ToolStrip2)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(223, 148)
    Me.Panel3.TabIndex = 23
    '
    'nuevo
    '
    Me.nuevo.Image = CType(resources.GetObject("nuevo.Image"), System.Drawing.Image)
    Me.nuevo.Location = New System.Drawing.Point(80, 66)
    Me.nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.nuevo.Name = "nuevo"
    Me.nuevo.Size = New System.Drawing.Size(53, 39)
    Me.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.nuevo.TabIndex = 28
    Me.nuevo.TabStop = False
    '
    'grabar
    '
    Me.grabar.Image = CType(resources.GetObject("grabar.Image"), System.Drawing.Image)
    Me.grabar.Location = New System.Drawing.Point(80, 66)
    Me.grabar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.grabar.Name = "grabar"
    Me.grabar.Size = New System.Drawing.Size(53, 39)
    Me.grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.grabar.TabIndex = 27
    Me.grabar.TabStop = False
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.btneli, Me.btnguardar})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(223, 25)
    Me.ToolStrip2.TabIndex = 26
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnnuevo
    '
    Me.btnnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevo.Image = Global.WWTS.Siembra.Modulo.My.Resources.Resources.nuevo
    Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(23, 22)
    Me.btnnuevo.Text = "ToolStripButton1"
    '
    'btneli
    '
    Me.btneli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneli.Image = Global.WWTS.Siembra.Modulo.My.Resources.Resources.eliminar
    Me.btneli.ImageTransparentColor = System.Drawing.Color.White
    Me.btneli.Name = "btneli"
    Me.btneli.Size = New System.Drawing.Size(23, 22)
    Me.btneli.Text = "ToolStripButton2"
    '
    'btnguardar
    '
    Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnguardar.Image = Global.WWTS.Siembra.Modulo.My.Resources.Resources.save16
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(23, 22)
    Me.btnguardar.Text = "ToolStripButton3"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.GroupBox3)
    Me.GroupBox1.Controls.Add(Me.CtlSeccionHorno1)
    Me.GroupBox1.Controls.Add(Me.CtlCorte1)
    Me.GroupBox1.Controls.Add(Me.CtlSemilla1)
    Me.GroupBox1.Controls.Add(Me.CtlLote1)
    Me.GroupBox1.Controls.Add(Me.chkestazafada)
    Me.GroupBox1.Controls.Add(Me.Label13)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Controls.Add(Me.Label11)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Enabled = False
    Me.GroupBox1.Location = New System.Drawing.Point(0, 148)
    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox1.Size = New System.Drawing.Size(748, 299)
    Me.GroupBox1.TabIndex = 18
    Me.GroupBox1.TabStop = False
    '
    'GroupBox3
    '
    Me.GroupBox3.AutoSize = True
    Me.GroupBox3.Controls.Add(Me.txtcujescand)
    Me.GroupBox3.Controls.Add(Me.txtcujesnat)
    Me.GroupBox3.Controls.Add(Me.Label2)
    Me.GroupBox3.Controls.Add(Me.Label4)
    Me.GroupBox3.Location = New System.Drawing.Point(63, 223)
    Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox3.Size = New System.Drawing.Size(615, 71)
    Me.GroupBox3.TabIndex = 13
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Tabaco Ensartado"
    '
    'txtcujescand
    '
    Me.txtcujescand.Location = New System.Drawing.Point(471, 26)
    Me.txtcujescand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtcujescand.Mensaje = ""
    Me.txtcujescand.Name = "txtcujescand"
    Me.txtcujescand.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcujescand.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcujescand.PromptText = ""
    Me.txtcujescand.Size = New System.Drawing.Size(132, 22)
    Me.txtcujescand.TabIndex = 5
    Me.txtcujescand.Text = "0"
    Me.txtcujescand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcujescand.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcujescand.Value = 0.0R
    '
    'txtcujesnat
    '
    Me.txtcujesnat.Location = New System.Drawing.Point(124, 26)
    Me.txtcujesnat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtcujesnat.Mensaje = ""
    Me.txtcujesnat.Name = "txtcujesnat"
    Me.txtcujesnat.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcujesnat.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcujesnat.PromptText = ""
    Me.txtcujesnat.Size = New System.Drawing.Size(132, 22)
    Me.txtcujesnat.TabIndex = 5
    Me.txtcujesnat.Text = "0"
    Me.txtcujesnat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcujesnat.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcujesnat.Value = 0.0R
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(8, 30)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(95, 17)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Cujes natural:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(340, 30)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(101, 17)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Cujes candela:"
    '
    'CtlSeccionHorno1
    '
    Me.CtlSeccionHorno1.Location = New System.Drawing.Point(477, 13)
    Me.CtlSeccionHorno1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.CtlSeccionHorno1.Name = "CtlSeccionHorno1"
    Me.CtlSeccionHorno1.Op = Nothing
    Me.CtlSeccionHorno1.SeccionHorno = Nothing
    Me.CtlSeccionHorno1.Size = New System.Drawing.Size(248, 182)
    Me.CtlSeccionHorno1.TabIndex = 12
    '
    'CtlCorte1
    '
    Me.CtlCorte1.Corte = Nothing
    Me.CtlCorte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlCorte1.FormattingEnabled = True
    Me.CtlCorte1.Location = New System.Drawing.Point(111, 146)
    Me.CtlCorte1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.CtlCorte1.Name = "CtlCorte1"
    Me.CtlCorte1.Op = Nothing
    Me.CtlCorte1.PuedeActualizar = True
    Me.CtlCorte1.PuedeEliminar = True
    Me.CtlCorte1.PuedeModificar = True
    Me.CtlCorte1.PuedeNuevo = True
    Me.CtlCorte1.Size = New System.Drawing.Size(221, 24)
    Me.CtlCorte1.TabIndex = 11
    '
    'CtlSemilla1
    '
    Me.CtlSemilla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSemilla1.FormattingEnabled = True
    Me.CtlSemilla1.Location = New System.Drawing.Point(111, 112)
    Me.CtlSemilla1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.CtlSemilla1.Name = "CtlSemilla1"
    Me.CtlSemilla1.Op = Nothing
    Me.CtlSemilla1.PuedeActualizar = True
    Me.CtlSemilla1.PuedeEliminar = True
    Me.CtlSemilla1.PuedeModificar = True
    Me.CtlSemilla1.PuedeNuevo = True
    Me.CtlSemilla1.Semilla = Nothing
    Me.CtlSemilla1.Size = New System.Drawing.Size(221, 24)
    Me.CtlSemilla1.TabIndex = 10
    '
    'CtlLote1
    '
    Me.CtlLote1.Location = New System.Drawing.Point(111, 13)
    Me.CtlLote1.Lote = Nothing
    Me.CtlLote1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.CtlLote1.Name = "CtlLote1"
    Me.CtlLote1.Op = Nothing
    Me.CtlLote1.Size = New System.Drawing.Size(223, 92)
    Me.CtlLote1.TabIndex = 9
    '
    'chkestazafada
    '
    Me.chkestazafada.AutoSize = True
    Me.chkestazafada.Location = New System.Drawing.Point(477, 201)
    Me.chkestazafada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.chkestazafada.Name = "chkestazafada"
    Me.chkestazafada.Size = New System.Drawing.Size(199, 21)
    Me.chkestazafada.TabIndex = 8
    Me.chkestazafada.Text = "Esta tarjeta ha sido zafada"
    '
    'Label13
    '
    Me.Label13.Location = New System.Drawing.Point(10, 149)
    Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(91, 25)
    Me.Label13.TabIndex = 4
    Me.Label13.Text = "Corte"
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(359, 13)
    Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(107, 25)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Horno/Sección:"
    '
    'Label10
    '
    Me.Label10.Location = New System.Drawing.Point(10, 116)
    Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(91, 25)
    Me.Label10.TabIndex = 2
    Me.Label10.Text = "Semilla:"
    '
    'Label11
    '
    Me.Label11.Location = New System.Drawing.Point(10, 13)
    Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(91, 25)
    Me.Label11.TabIndex = 0
    Me.Label11.Text = "Lote:"
    '
    'grpzafada
    '
    Me.grpzafada.Controls.Add(Me.TableLayoutPanel1)
    Me.grpzafada.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpzafada.Location = New System.Drawing.Point(0, 447)
    Me.grpzafada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.grpzafada.Name = "grpzafada"
    Me.grpzafada.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
    Me.grpzafada.Size = New System.Drawing.Size(748, 208)
    Me.grpzafada.TabIndex = 19
    Me.grpzafada.TabStop = False
    Me.grpzafada.Text = "Zafadura"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.grptabnat, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.grptabcand, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 21)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(734, 181)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'grptabnat
    '
    Me.grptabnat.Controls.Add(Me.txtlibzafnat)
    Me.grptabnat.Controls.Add(Me.dtfeczafnat)
    Me.grptabnat.Controls.Add(Me.Label6)
    Me.grptabnat.Controls.Add(Me.Label7)
    Me.grptabnat.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grptabnat.Location = New System.Drawing.Point(4, 4)
    Me.grptabnat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.grptabnat.Name = "grptabnat"
    Me.grptabnat.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.grptabnat.Size = New System.Drawing.Size(359, 173)
    Me.grptabnat.TabIndex = 0
    Me.grptabnat.TabStop = False
    Me.grptabnat.Text = "Tabaco Natural"
    '
    'txtlibzafnat
    '
    Me.txtlibzafnat.Location = New System.Drawing.Point(136, 63)
    Me.txtlibzafnat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtlibzafnat.Mensaje = ""
    Me.txtlibzafnat.Name = "txtlibzafnat"
    Me.txtlibzafnat.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtlibzafnat.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtlibzafnat.PromptText = ""
    Me.txtlibzafnat.Size = New System.Drawing.Size(127, 22)
    Me.txtlibzafnat.TabIndex = 20
    Me.txtlibzafnat.Text = "0,00"
    Me.txtlibzafnat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtlibzafnat.Value = 0.0R
    '
    'dtfeczafnat
    '
    Me.dtfeczafnat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfeczafnat.Location = New System.Drawing.Point(136, 31)
    Me.dtfeczafnat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.dtfeczafnat.Name = "dtfeczafnat"
    Me.dtfeczafnat.Size = New System.Drawing.Size(127, 22)
    Me.dtfeczafnat.TabIndex = 19
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(19, 36)
    Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(98, 17)
    Me.Label6.TabIndex = 18
    Me.Label6.Text = "Fecha zafado:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(19, 65)
    Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(105, 17)
    Me.Label7.TabIndex = 17
    Me.Label7.Text = "Libras zafadas:"
    '
    'grptabcand
    '
    Me.grptabcand.Controls.Add(Me.txtlibzafcand)
    Me.grptabcand.Controls.Add(Me.dtfeczafcand)
    Me.grptabcand.Controls.Add(Me.Label8)
    Me.grptabcand.Controls.Add(Me.Label9)
    Me.grptabcand.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grptabcand.Location = New System.Drawing.Point(371, 4)
    Me.grptabcand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.grptabcand.Name = "grptabcand"
    Me.grptabcand.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.grptabcand.Size = New System.Drawing.Size(359, 173)
    Me.grptabcand.TabIndex = 0
    Me.grptabcand.TabStop = False
    Me.grptabcand.Text = "Tabaco Candela"
    '
    'txtlibzafcand
    '
    Me.txtlibzafcand.Location = New System.Drawing.Point(144, 63)
    Me.txtlibzafcand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtlibzafcand.Mensaje = ""
    Me.txtlibzafcand.Name = "txtlibzafcand"
    Me.txtlibzafcand.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtlibzafcand.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtlibzafcand.PromptText = ""
    Me.txtlibzafcand.Size = New System.Drawing.Size(127, 22)
    Me.txtlibzafcand.TabIndex = 24
    Me.txtlibzafcand.Text = "0,00"
    Me.txtlibzafcand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtlibzafcand.Value = 0.0R
    '
    'dtfeczafcand
    '
    Me.dtfeczafcand.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfeczafcand.Location = New System.Drawing.Point(144, 31)
    Me.dtfeczafcand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.dtfeczafcand.Name = "dtfeczafcand"
    Me.dtfeczafcand.Size = New System.Drawing.Size(127, 22)
    Me.dtfeczafcand.TabIndex = 23
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(27, 36)
    Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(98, 17)
    Me.Label8.TabIndex = 22
    Me.Label8.Text = "Fecha zafado:"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(27, 65)
    Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(105, 17)
    Me.Label9.TabIndex = 21
    Me.Label9.Text = "Libras zafadas:"
    '
    'cboCicloEnsarte
    '
    Me.cboCicloEnsarte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCicloEnsarte.FormattingEnabled = True
    Me.cboCicloEnsarte.Location = New System.Drawing.Point(139, 93)
    Me.cboCicloEnsarte.Name = "cboCicloEnsarte"
    Me.cboCicloEnsarte.OperadorDatos = Nothing
    Me.cboCicloEnsarte.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboCicloEnsarte.ParametroDet = Nothing
    Me.cboCicloEnsarte.PuedeActualizar = True
    Me.cboCicloEnsarte.PuedeEliminar = True
    Me.cboCicloEnsarte.PuedeModificar = True
    Me.cboCicloEnsarte.PuedeNuevo = True
    Me.cboCicloEnsarte.Size = New System.Drawing.Size(160, 24)
    Me.cboCicloEnsarte.TabIndex = 3
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(11, 96)
    Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(128, 20)
    Me.Label12.TabIndex = 2
    Me.Label12.Text = "Ciclo Ensarte"
    '
    'CtlTarjEnsarte
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.grpzafada)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Panel1)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "CtlTarjEnsarte"
    Me.Size = New System.Drawing.Size(748, 655)
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.pn1.ResumeLayout(False)
    Me.pn1.PerformLayout()
    Me.pn3.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    CType(Me.nuevo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grabar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.grpzafada.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.grptabnat.ResumeLayout(False)
    Me.grptabnat.PerformLayout()
    Me.grptabcand.ResumeLayout(False)
    Me.grptabcand.PerformLayout()
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
  Friend WithEvents CtlZafra1 As WWTS.Siembra.Modulo.CtlZafra
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents CtlSeccionHorno1 As WWTS.Siembra.Modulo.CtlSeccionHorno
  Friend WithEvents CtlCorte1 As WWTS.Siembra.Modulo.CtlCorte
  Friend WithEvents CtlSemilla1 As WWTS.Siembra.Modulo.CtlSemilla
  Friend WithEvents CtlLote1 As WWTS.Siembra.Modulo.CtlLote
  Friend WithEvents chkestazafada As System.Windows.Forms.CheckBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txtcujescand As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtcujesnat As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents grpzafada As System.Windows.Forms.GroupBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents grptabnat As System.Windows.Forms.GroupBox
  Friend WithEvents grptabcand As System.Windows.Forms.GroupBox
  Friend WithEvents txtlibzafnat As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents dtfeczafnat As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtlibzafcand As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents dtfeczafcand As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents cboCicloEnsarte As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
