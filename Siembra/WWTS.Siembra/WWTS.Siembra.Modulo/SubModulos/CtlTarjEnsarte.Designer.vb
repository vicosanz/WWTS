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
        Me.CtlZafra1 = New Siembra.CtlZafra()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNumEns = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn3 = New System.Windows.Forms.Panel()
        Me.cboCicloEnsarte = New WWTS.General.Controles.ComboBoxParametroDet()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtcujescand = New Infoware.Controles.Base.TextBoxCalculator()
        Me.txtcujesnat = New Infoware.Controles.Base.TextBoxCalculator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CtlSeccionHorno1 = New Siembra.CtlSeccionHorno()
        Me.CtlCorte1 = New Siembra.CtlCorte()
        Me.CtlSemilla1 = New Siembra.CtlSemilla()
        Me.CtlLote1 = New Siembra.CtlLote()
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 120)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pn1)
        Me.GroupBox2.Controls.Add(Me.pn3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(167, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 120)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'pn1
        '
        Me.pn1.Controls.Add(Me.txtNumEns)
        Me.pn1.Controls.Add(Me.Label1)
        Me.pn1.Location = New System.Drawing.Point(11, 16)
        Me.pn1.Name = "pn1"
        Me.pn1.Size = New System.Drawing.Size(229, 26)
        Me.pn1.TabIndex = 0
        '
        'CtlZafra1
        '
        Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlZafra1.FormattingEnabled = True
        Me.CtlZafra1.Location = New System.Drawing.Point(104, 27)
        Me.CtlZafra1.Name = "CtlZafra1"
        Me.CtlZafra1.Op = Nothing
        Me.CtlZafra1.PuedeActualizar = True
        Me.CtlZafra1.PuedeEliminar = True
        Me.CtlZafra1.PuedeModificar = True
        Me.CtlZafra1.PuedeNuevo = True
        Me.CtlZafra1.Size = New System.Drawing.Size(121, 21)
        Me.CtlZafra1.TabIndex = 1
        Me.CtlZafra1.Zafra = Nothing
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Zafra"
        '
        'txtNumEns
        '
        Me.txtNumEns.Location = New System.Drawing.Point(96, 3)
        Me.txtNumEns.Name = "txtNumEns"
        Me.txtNumEns.Size = New System.Drawing.Size(121, 20)
        Me.txtNumEns.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num. Ensarte"
        '
        'pn3
        '
        Me.pn3.Controls.Add(Me.CtlZafra1)
        Me.pn3.Controls.Add(Me.Label14)
        Me.pn3.Controls.Add(Me.cboCicloEnsarte)
        Me.pn3.Controls.Add(Me.dtpFecha)
        Me.pn3.Controls.Add(Me.Label12)
        Me.pn3.Controls.Add(Me.Label3)
        Me.pn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn3.Enabled = False
        Me.pn3.Location = New System.Drawing.Point(3, 16)
        Me.pn3.Name = "pn3"
        Me.pn3.Size = New System.Drawing.Size(388, 101)
        Me.pn3.TabIndex = 1
        '
        'cboCicloEnsarte
        '
        Me.cboCicloEnsarte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCicloEnsarte.FormattingEnabled = True
        Me.cboCicloEnsarte.Location = New System.Drawing.Point(104, 76)
        Me.cboCicloEnsarte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCicloEnsarte.Name = "cboCicloEnsarte"
        Me.cboCicloEnsarte.OperadorDatos = Nothing
        Me.cboCicloEnsarte.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboCicloEnsarte.ParametroDet = Nothing
        Me.cboCicloEnsarte.PuedeActualizar = True
        Me.cboCicloEnsarte.PuedeEliminar = True
        Me.cboCicloEnsarte.PuedeModificar = True
        Me.cboCicloEnsarte.PuedeNuevo = True
        Me.cboCicloEnsarte.Size = New System.Drawing.Size(121, 21)
        Me.cboCicloEnsarte.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(104, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Ciclo Ensarte"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Ensarte"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.nuevo)
        Me.Panel3.Controls.Add(Me.grabar)
        Me.Panel3.Controls.Add(Me.ToolStrip2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(167, 120)
        Me.Panel3.TabIndex = 23
        '
        'nuevo
        '
        Me.nuevo.Image = CType(resources.GetObject("nuevo.Image"), System.Drawing.Image)
        Me.nuevo.Location = New System.Drawing.Point(60, 54)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(40, 32)
        Me.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nuevo.TabIndex = 28
        Me.nuevo.TabStop = False
        '
        'grabar
        '
        Me.grabar.Image = CType(resources.GetObject("grabar.Image"), System.Drawing.Image)
        Me.grabar.Location = New System.Drawing.Point(60, 54)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(40, 32)
        Me.grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.grabar.TabIndex = 27
        Me.grabar.TabStop = False
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
        Me.btnnuevo.Image = Global.Siembra.My.Resources.Resources.nuevo
        Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(23, 22)
        Me.btnnuevo.Text = "ToolStripButton1"
        '
        'btneli
        '
        Me.btneli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneli.Image = Global.Siembra.My.Resources.Resources.eliminar
        Me.btneli.ImageTransparentColor = System.Drawing.Color.White
        Me.btneli.Name = "btneli"
        Me.btneli.Size = New System.Drawing.Size(23, 22)
        Me.btneli.Text = "ToolStripButton2"
        '
        'btnguardar
        '
        Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnguardar.Image = Global.Siembra.My.Resources.Resources.save16
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 243)
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
        Me.GroupBox3.Location = New System.Drawing.Point(47, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(461, 60)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabaco Ensartado"
        '
        'txtcujescand
        '
        Me.txtcujescand.Location = New System.Drawing.Point(353, 21)
        Me.txtcujescand.Mensaje = ""
        Me.txtcujescand.Name = "txtcujescand"
        Me.txtcujescand.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcujescand.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcujescand.PromptText = ""
        Me.txtcujescand.Size = New System.Drawing.Size(100, 20)
        Me.txtcujescand.TabIndex = 5
        Me.txtcujescand.Text = "0"
        Me.txtcujescand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcujescand.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtcujescand.Value = 0R
        '
        'txtcujesnat
        '
        Me.txtcujesnat.Location = New System.Drawing.Point(93, 21)
        Me.txtcujesnat.Mensaje = ""
        Me.txtcujesnat.Name = "txtcujesnat"
        Me.txtcujesnat.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcujesnat.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcujesnat.PromptText = ""
        Me.txtcujesnat.Size = New System.Drawing.Size(100, 20)
        Me.txtcujesnat.TabIndex = 5
        Me.txtcujesnat.Text = "0"
        Me.txtcujesnat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcujesnat.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtcujesnat.Value = 0R
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cujes natural:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cujes candela:"
        '
        'CtlSeccionHorno1
        '
        Me.CtlSeccionHorno1.Location = New System.Drawing.Point(358, 11)
        Me.CtlSeccionHorno1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CtlSeccionHorno1.Name = "CtlSeccionHorno1"
        Me.CtlSeccionHorno1.Op = Nothing
        Me.CtlSeccionHorno1.SeccionHorno = Nothing
        Me.CtlSeccionHorno1.Size = New System.Drawing.Size(186, 148)
        Me.CtlSeccionHorno1.TabIndex = 12
        '
        'CtlCorte1
        '
        Me.CtlCorte1.Corte = Nothing
        Me.CtlCorte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlCorte1.FormattingEnabled = True
        Me.CtlCorte1.Location = New System.Drawing.Point(83, 119)
        Me.CtlCorte1.Name = "CtlCorte1"
        Me.CtlCorte1.Op = Nothing
        Me.CtlCorte1.PuedeActualizar = True
        Me.CtlCorte1.PuedeEliminar = True
        Me.CtlCorte1.PuedeModificar = True
        Me.CtlCorte1.PuedeNuevo = True
        Me.CtlCorte1.Size = New System.Drawing.Size(167, 21)
        Me.CtlCorte1.TabIndex = 11
        '
        'CtlSemilla1
        '
        Me.CtlSemilla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlSemilla1.FormattingEnabled = True
        Me.CtlSemilla1.Location = New System.Drawing.Point(83, 91)
        Me.CtlSemilla1.Name = "CtlSemilla1"
        Me.CtlSemilla1.Op = Nothing
        Me.CtlSemilla1.PuedeActualizar = True
        Me.CtlSemilla1.PuedeEliminar = True
        Me.CtlSemilla1.PuedeModificar = True
        Me.CtlSemilla1.PuedeNuevo = True
        Me.CtlSemilla1.Semilla = Nothing
        Me.CtlSemilla1.Size = New System.Drawing.Size(167, 21)
        Me.CtlSemilla1.TabIndex = 10
        '
        'CtlLote1
        '
        Me.CtlLote1.Location = New System.Drawing.Point(83, 11)
        Me.CtlLote1.Lote = Nothing
        Me.CtlLote1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CtlLote1.Name = "CtlLote1"
        Me.CtlLote1.Op = Nothing
        Me.CtlLote1.Size = New System.Drawing.Size(167, 75)
        Me.CtlLote1.TabIndex = 9
        '
        'chkestazafada
        '
        Me.chkestazafada.AutoSize = True
        Me.chkestazafada.Location = New System.Drawing.Point(358, 163)
        Me.chkestazafada.Name = "chkestazafada"
        Me.chkestazafada.Size = New System.Drawing.Size(151, 17)
        Me.chkestazafada.TabIndex = 8
        Me.chkestazafada.Text = "Esta tarjeta ha sido zafada"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Corte"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(269, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Horno/Sección:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Semilla:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lote:"
        '
        'grpzafada
        '
        Me.grpzafada.Controls.Add(Me.TableLayoutPanel1)
        Me.grpzafada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpzafada.Location = New System.Drawing.Point(0, 363)
        Me.grpzafada.Name = "grpzafada"
        Me.grpzafada.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpzafada.Size = New System.Drawing.Size(561, 169)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(551, 146)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'grptabnat
        '
        Me.grptabnat.Controls.Add(Me.txtlibzafnat)
        Me.grptabnat.Controls.Add(Me.dtfeczafnat)
        Me.grptabnat.Controls.Add(Me.Label6)
        Me.grptabnat.Controls.Add(Me.Label7)
        Me.grptabnat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grptabnat.Location = New System.Drawing.Point(3, 3)
        Me.grptabnat.Name = "grptabnat"
        Me.grptabnat.Size = New System.Drawing.Size(269, 140)
        Me.grptabnat.TabIndex = 0
        Me.grptabnat.TabStop = False
        Me.grptabnat.Text = "Tabaco Natural"
        '
        'txtlibzafnat
        '
        Me.txtlibzafnat.Location = New System.Drawing.Point(102, 51)
        Me.txtlibzafnat.Mensaje = ""
        Me.txtlibzafnat.Name = "txtlibzafnat"
        Me.txtlibzafnat.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlibzafnat.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtlibzafnat.PromptText = ""
        Me.txtlibzafnat.Size = New System.Drawing.Size(96, 20)
        Me.txtlibzafnat.TabIndex = 20
        Me.txtlibzafnat.Text = "0.00"
        Me.txtlibzafnat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtlibzafnat.Value = 0R
        '
        'dtfeczafnat
        '
        Me.dtfeczafnat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfeczafnat.Location = New System.Drawing.Point(102, 25)
        Me.dtfeczafnat.Name = "dtfeczafnat"
        Me.dtfeczafnat.Size = New System.Drawing.Size(96, 20)
        Me.dtfeczafnat.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fecha zafado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
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
        Me.grptabcand.Location = New System.Drawing.Point(278, 3)
        Me.grptabcand.Name = "grptabcand"
        Me.grptabcand.Size = New System.Drawing.Size(270, 140)
        Me.grptabcand.TabIndex = 0
        Me.grptabcand.TabStop = False
        Me.grptabcand.Text = "Tabaco Candela"
        '
        'txtlibzafcand
        '
        Me.txtlibzafcand.Location = New System.Drawing.Point(108, 51)
        Me.txtlibzafcand.Mensaje = ""
        Me.txtlibzafcand.Name = "txtlibzafcand"
        Me.txtlibzafcand.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlibzafcand.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtlibzafcand.PromptText = ""
        Me.txtlibzafcand.Size = New System.Drawing.Size(96, 20)
        Me.txtlibzafcand.TabIndex = 24
        Me.txtlibzafcand.Text = "0.00"
        Me.txtlibzafcand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtlibzafcand.Value = 0R
        '
        'dtfeczafcand
        '
        Me.dtfeczafcand.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfeczafcand.Location = New System.Drawing.Point(108, 25)
        Me.dtfeczafcand.Name = "dtfeczafcand"
        Me.dtfeczafcand.Size = New System.Drawing.Size(96, 20)
        Me.dtfeczafcand.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Fecha zafado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Libras zafadas:"
        '
        'CtlTarjEnsarte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.grpzafada)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CtlTarjEnsarte"
        Me.Size = New System.Drawing.Size(561, 532)
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
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents CtlSeccionHorno1 As CtlSeccionHorno
  Friend WithEvents CtlCorte1 As CtlCorte
  Friend WithEvents CtlSemilla1 As CtlSemilla
  Friend WithEvents CtlLote1 As CtlLote
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
