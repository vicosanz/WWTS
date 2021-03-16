<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaBloqueFermentacion
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
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.pnlbusqbloque = New System.Windows.Forms.Panel
    Me.pnlfin = New System.Windows.Forms.Panel
    Me.pnlnumeroembarque = New System.Windows.Forms.Panel
    Me.txthasta = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtdesde = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label4 = New System.Windows.Forms.Label
    Me.Panel6 = New System.Windows.Forms.Panel
    Me.Label5 = New System.Windows.Forms.Label
    Me.chknumerobloque = New System.Windows.Forms.CheckBox
    Me.pnlsolocorte = New System.Windows.Forms.Panel
    Me.CtlCorte1 = New CtlCorte
    Me.Panel12 = New System.Windows.Forms.Panel
    Me.chksolocorte = New System.Windows.Forms.CheckBox
    Me.pnlsolosemilla = New System.Windows.Forms.Panel
    Me.CtlSemilla1 = New CtlSemilla
    Me.Panel5 = New System.Windows.Forms.Panel
    Me.chksolosemilla = New System.Windows.Forms.CheckBox
    Me.pnlfechatipomov = New System.Windows.Forms.Panel
    Me.dtfecbloqfin = New System.Windows.Forms.DateTimePicker
    Me.Label44 = New System.Windows.Forms.Label
    Me.dtfecbloqini = New System.Windows.Forms.DateTimePicker
    Me.Label43 = New System.Windows.Forms.Label
    Me.cbotipomovinv = New System.Windows.Forms.ComboBox
    Me.Panel11 = New System.Windows.Forms.Panel
    Me.chkfechatipomov = New System.Windows.Forms.CheckBox
    Me.pnlsololote = New System.Windows.Forms.Panel
    Me.CtlLote1 = New CtlLote
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.chksololote = New System.Windows.Forms.CheckBox
    Me.pnlsolofinca = New System.Windows.Forms.Panel
    Me.CtlTerreno1 = New CtlTerreno
    Me.Panel16 = New System.Windows.Forms.Panel
    Me.chksolofinca = New System.Windows.Forms.CheckBox
    Me.CtlZafra1 = New CtlZafra
    Me.Label1 = New System.Windows.Forms.Label
    Me.tvbloques = New System.Windows.Forms.TreeView
    Me.Panel7 = New System.Windows.Forms.Panel
    Me.chktodos = New System.Windows.Forms.CheckBox
    Me.btnbuscar = New System.Windows.Forms.Button
    Me.btnexportar = New System.Windows.Forms.Button
    Me.lblstatus = New System.Windows.Forms.Label
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.SeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnu25 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnu50 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnu100 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnu250 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnu500 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnu1000 = New System.Windows.Forms.ToolStripMenuItem
    Me.HeaderStrip2.SuspendLayout()
    Me.pnlbusqbloque.SuspendLayout()
    Me.pnlnumeroembarque.SuspendLayout()
    Me.pnlsolocorte.SuspendLayout()
    Me.pnlsolosemilla.SuspendLayout()
    Me.pnlfechatipomov.SuspendLayout()
    Me.pnlsololote.SuspendLayout()
    Me.pnlsolofinca.SuspendLayout()
    Me.Panel7.SuspendLayout()
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Tahoma", 8.25!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(187, 19)
    Me.HeaderStrip2.TabIndex = 4
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(109, 16)
    Me.ToolStripLabel1.Text = "Búsqueda de bloques"
    '
    'pnlbusqbloque
    '
    Me.pnlbusqbloque.Controls.Add(Me.pnlfin)
    Me.pnlbusqbloque.Controls.Add(Me.pnlnumeroembarque)
    Me.pnlbusqbloque.Controls.Add(Me.chknumerobloque)
    Me.pnlbusqbloque.Controls.Add(Me.pnlsolocorte)
    Me.pnlbusqbloque.Controls.Add(Me.chksolocorte)
    Me.pnlbusqbloque.Controls.Add(Me.pnlsolosemilla)
    Me.pnlbusqbloque.Controls.Add(Me.chksolosemilla)
    Me.pnlbusqbloque.Controls.Add(Me.pnlfechatipomov)
    Me.pnlbusqbloque.Controls.Add(Me.chkfechatipomov)
    Me.pnlbusqbloque.Controls.Add(Me.pnlsololote)
    Me.pnlbusqbloque.Controls.Add(Me.chksololote)
    Me.pnlbusqbloque.Controls.Add(Me.pnlsolofinca)
    Me.pnlbusqbloque.Controls.Add(Me.chksolofinca)
    Me.pnlbusqbloque.Controls.Add(Me.CtlZafra1)
    Me.pnlbusqbloque.Controls.Add(Me.Label1)
    Me.pnlbusqbloque.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlbusqbloque.Location = New System.Drawing.Point(0, 19)
    Me.pnlbusqbloque.Name = "pnlbusqbloque"
    Me.pnlbusqbloque.Size = New System.Drawing.Size(187, 472)
    Me.pnlbusqbloque.TabIndex = 45
    '
    'pnlfin
    '
    Me.pnlfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfin.Location = New System.Drawing.Point(0, 452)
    Me.pnlfin.Name = "pnlfin"
    Me.pnlfin.Size = New System.Drawing.Size(187, 8)
    Me.pnlfin.TabIndex = 75
    '
    'pnlnumeroembarque
    '
    Me.pnlnumeroembarque.Controls.Add(Me.txthasta)
    Me.pnlnumeroembarque.Controls.Add(Me.txtdesde)
    Me.pnlnumeroembarque.Controls.Add(Me.Label4)
    Me.pnlnumeroembarque.Controls.Add(Me.Panel6)
    Me.pnlnumeroembarque.Controls.Add(Me.Label5)
    Me.pnlnumeroembarque.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlnumeroembarque.Location = New System.Drawing.Point(0, 406)
    Me.pnlnumeroembarque.Name = "pnlnumeroembarque"
    Me.pnlnumeroembarque.Size = New System.Drawing.Size(187, 46)
    Me.pnlnumeroembarque.TabIndex = 80
    Me.pnlnumeroembarque.Visible = False
    '
    'txthasta
    '
    Me.txthasta.Location = New System.Drawing.Point(62, 25)
    Me.txthasta.Name = "txthasta"
    Me.txthasta.Size = New System.Drawing.Size(61, 20)
    Me.txthasta.TabIndex = 82
    Me.txthasta.Text = "0"
    Me.txthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthasta.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'txtdesde
    '
    Me.txtdesde.Location = New System.Drawing.Point(62, 1)
    Me.txtdesde.Name = "txtdesde"
    Me.txtdesde.Size = New System.Drawing.Size(61, 20)
    Me.txtdesde.TabIndex = 82
    Me.txtdesde.Text = "0"
    Me.txtdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdesde.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(16, 4)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(40, 16)
    Me.Label4.TabIndex = 81
    Me.Label4.Text = "Desde:"
    '
    'Panel6
    '
    Me.Panel6.BackColor = System.Drawing.SystemColors.Info
    Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel6.Location = New System.Drawing.Point(0, 0)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(16, 46)
    Me.Panel6.TabIndex = 80
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(16, 28)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(40, 16)
    Me.Label5.TabIndex = 81
    Me.Label5.Text = "Hasta:"
    '
    'chknumerobloque
    '
    Me.chknumerobloque.BackColor = System.Drawing.SystemColors.Info
    Me.chknumerobloque.Dock = System.Windows.Forms.DockStyle.Top
    Me.chknumerobloque.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chknumerobloque.Location = New System.Drawing.Point(0, 392)
    Me.chknumerobloque.Name = "chknumerobloque"
    Me.chknumerobloque.Size = New System.Drawing.Size(187, 14)
    Me.chknumerobloque.TabIndex = 79
    Me.chknumerobloque.Text = "Por número de bloque"
    Me.chknumerobloque.UseVisualStyleBackColor = False
    '
    'pnlsolocorte
    '
    Me.pnlsolocorte.Controls.Add(Me.CtlCorte1)
    Me.pnlsolocorte.Controls.Add(Me.Panel12)
    Me.pnlsolocorte.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolocorte.Location = New System.Drawing.Point(0, 368)
    Me.pnlsolocorte.Name = "pnlsolocorte"
    Me.pnlsolocorte.Size = New System.Drawing.Size(187, 24)
    Me.pnlsolocorte.TabIndex = 66
    Me.pnlsolocorte.Visible = False
    '
    'CtlCorte1
    '
    Me.CtlCorte1.Corte = Nothing
    Me.CtlCorte1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlCorte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlCorte1.FormattingEnabled = True
    Me.CtlCorte1.Location = New System.Drawing.Point(16, 0)
    Me.CtlCorte1.Name = "CtlCorte1"
    Me.CtlCorte1.Op = Nothing
    Me.CtlCorte1.PuedeActualizar = True
    Me.CtlCorte1.PuedeEliminar = True
    Me.CtlCorte1.PuedeModificar = True
    Me.CtlCorte1.PuedeNuevo = True
    Me.CtlCorte1.Size = New System.Drawing.Size(171, 21)
    Me.CtlCorte1.TabIndex = 1
    '
    'Panel12
    '
    Me.Panel12.BackColor = System.Drawing.SystemColors.Info
    Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel12.Location = New System.Drawing.Point(0, 0)
    Me.Panel12.Name = "Panel12"
    Me.Panel12.Size = New System.Drawing.Size(16, 24)
    Me.Panel12.TabIndex = 0
    '
    'chksolocorte
    '
    Me.chksolocorte.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolocorte.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolocorte.Location = New System.Drawing.Point(0, 352)
    Me.chksolocorte.Name = "chksolocorte"
    Me.chksolocorte.Size = New System.Drawing.Size(187, 16)
    Me.chksolocorte.TabIndex = 65
    Me.chksolocorte.Text = "Sólo del corte"
    '
    'pnlsolosemilla
    '
    Me.pnlsolosemilla.Controls.Add(Me.CtlSemilla1)
    Me.pnlsolosemilla.Controls.Add(Me.Panel5)
    Me.pnlsolosemilla.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolosemilla.Location = New System.Drawing.Point(0, 328)
    Me.pnlsolosemilla.Name = "pnlsolosemilla"
    Me.pnlsolosemilla.Size = New System.Drawing.Size(187, 24)
    Me.pnlsolosemilla.TabIndex = 62
    Me.pnlsolosemilla.Visible = False
    '
    'CtlSemilla1
    '
    Me.CtlSemilla1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlSemilla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSemilla1.FormattingEnabled = True
    Me.CtlSemilla1.Location = New System.Drawing.Point(16, 0)
    Me.CtlSemilla1.Name = "CtlSemilla1"
    Me.CtlSemilla1.Op = Nothing
    Me.CtlSemilla1.PuedeActualizar = True
    Me.CtlSemilla1.PuedeEliminar = True
    Me.CtlSemilla1.PuedeModificar = True
    Me.CtlSemilla1.PuedeNuevo = True
    Me.CtlSemilla1.Semilla = Nothing
    Me.CtlSemilla1.Size = New System.Drawing.Size(171, 21)
    Me.CtlSemilla1.TabIndex = 1
    '
    'Panel5
    '
    Me.Panel5.BackColor = System.Drawing.SystemColors.Info
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel5.Location = New System.Drawing.Point(0, 0)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(16, 24)
    Me.Panel5.TabIndex = 0
    '
    'chksolosemilla
    '
    Me.chksolosemilla.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolosemilla.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolosemilla.Location = New System.Drawing.Point(0, 315)
    Me.chksolosemilla.Name = "chksolosemilla"
    Me.chksolosemilla.Size = New System.Drawing.Size(187, 13)
    Me.chksolosemilla.TabIndex = 61
    Me.chksolosemilla.Text = "Sólo de la semilla"
    '
    'pnlfechatipomov
    '
    Me.pnlfechatipomov.Controls.Add(Me.dtfecbloqfin)
    Me.pnlfechatipomov.Controls.Add(Me.Label44)
    Me.pnlfechatipomov.Controls.Add(Me.dtfecbloqini)
    Me.pnlfechatipomov.Controls.Add(Me.Label43)
    Me.pnlfechatipomov.Controls.Add(Me.cbotipomovinv)
    Me.pnlfechatipomov.Controls.Add(Me.Panel11)
    Me.pnlfechatipomov.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfechatipomov.Location = New System.Drawing.Point(0, 217)
    Me.pnlfechatipomov.Name = "pnlfechatipomov"
    Me.pnlfechatipomov.Size = New System.Drawing.Size(187, 98)
    Me.pnlfechatipomov.TabIndex = 52
    Me.pnlfechatipomov.Visible = False
    '
    'dtfecbloqfin
    '
    Me.dtfecbloqfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecbloqfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecbloqfin.Location = New System.Drawing.Point(16, 69)
    Me.dtfecbloqfin.Name = "dtfecbloqfin"
    Me.dtfecbloqfin.Size = New System.Drawing.Size(171, 20)
    Me.dtfecbloqfin.TabIndex = 4
    Me.dtfecbloqfin.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
    '
    'Label44
    '
    Me.Label44.BackColor = System.Drawing.SystemColors.Info
    Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label44.Location = New System.Drawing.Point(16, 53)
    Me.Label44.Name = "Label44"
    Me.Label44.Size = New System.Drawing.Size(171, 16)
    Me.Label44.TabIndex = 3
    Me.Label44.Text = "Hasta:"
    Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecbloqini
    '
    Me.dtfecbloqini.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecbloqini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecbloqini.Location = New System.Drawing.Point(16, 33)
    Me.dtfecbloqini.Name = "dtfecbloqini"
    Me.dtfecbloqini.Size = New System.Drawing.Size(171, 20)
    Me.dtfecbloqini.TabIndex = 2
    Me.dtfecbloqini.Value = New Date(2005, 11, 30, 0, 0, 0, 0)
    '
    'Label43
    '
    Me.Label43.BackColor = System.Drawing.SystemColors.Info
    Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label43.Location = New System.Drawing.Point(16, 21)
    Me.Label43.Name = "Label43"
    Me.Label43.Size = New System.Drawing.Size(171, 12)
    Me.Label43.TabIndex = 1
    Me.Label43.Text = "Desde:"
    Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cbotipomovinv
    '
    Me.cbotipomovinv.Dock = System.Windows.Forms.DockStyle.Top
    Me.cbotipomovinv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipomovinv.Location = New System.Drawing.Point(16, 0)
    Me.cbotipomovinv.Name = "cbotipomovinv"
    Me.cbotipomovinv.Size = New System.Drawing.Size(171, 21)
    Me.cbotipomovinv.TabIndex = 5
    '
    'Panel11
    '
    Me.Panel11.BackColor = System.Drawing.SystemColors.Info
    Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel11.Location = New System.Drawing.Point(0, 0)
    Me.Panel11.Name = "Panel11"
    Me.Panel11.Size = New System.Drawing.Size(16, 98)
    Me.Panel11.TabIndex = 0
    '
    'chkfechatipomov
    '
    Me.chkfechatipomov.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkfechatipomov.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkfechatipomov.Location = New System.Drawing.Point(0, 201)
    Me.chkfechatipomov.Name = "chkfechatipomov"
    Me.chkfechatipomov.Size = New System.Drawing.Size(187, 16)
    Me.chkfechatipomov.TabIndex = 71
    Me.chkfechatipomov.Text = "Por rango de fecha"
    '
    'pnlsololote
    '
    Me.pnlsololote.Controls.Add(Me.CtlLote1)
    Me.pnlsololote.Controls.Add(Me.Panel2)
    Me.pnlsololote.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsololote.Location = New System.Drawing.Point(0, 131)
    Me.pnlsololote.Name = "pnlsololote"
    Me.pnlsololote.Size = New System.Drawing.Size(187, 70)
    Me.pnlsololote.TabIndex = 60
    Me.pnlsololote.Visible = False
    '
    'CtlLote1
    '
    Me.CtlLote1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlLote1.Location = New System.Drawing.Point(16, 0)
    Me.CtlLote1.Lote = Nothing
    Me.CtlLote1.Name = "CtlLote1"
    Me.CtlLote1.Op = Nothing
    Me.CtlLote1.Size = New System.Drawing.Size(171, 70)
    Me.CtlLote1.TabIndex = 1
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.Info
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(16, 70)
    Me.Panel2.TabIndex = 0
    '
    'chksololote
    '
    Me.chksololote.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksololote.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksololote.Location = New System.Drawing.Point(0, 117)
    Me.chksololote.Name = "chksololote"
    Me.chksololote.Size = New System.Drawing.Size(187, 14)
    Me.chksololote.TabIndex = 59
    Me.chksololote.Text = "Sólo del lote"
    '
    'pnlsolofinca
    '
    Me.pnlsolofinca.Controls.Add(Me.CtlTerreno1)
    Me.pnlsolofinca.Controls.Add(Me.Panel16)
    Me.pnlsolofinca.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolofinca.Location = New System.Drawing.Point(0, 53)
    Me.pnlsolofinca.Name = "pnlsolofinca"
    Me.pnlsolofinca.Size = New System.Drawing.Size(187, 64)
    Me.pnlsolofinca.TabIndex = 70
    Me.pnlsolofinca.Visible = False
    '
    'CtlTerreno1
    '
    Me.CtlTerreno1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTerreno1.Location = New System.Drawing.Point(16, 0)
    Me.CtlTerreno1.Name = "CtlTerreno1"
    Me.CtlTerreno1.Op = Nothing
    Me.CtlTerreno1.Size = New System.Drawing.Size(171, 64)
    Me.CtlTerreno1.TabIndex = 1
    Me.CtlTerreno1.Terreno = Nothing
    '
    'Panel16
    '
    Me.Panel16.BackColor = System.Drawing.SystemColors.Info
    Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel16.Location = New System.Drawing.Point(0, 0)
    Me.Panel16.Name = "Panel16"
    Me.Panel16.Size = New System.Drawing.Size(16, 64)
    Me.Panel16.TabIndex = 0
    '
    'chksolofinca
    '
    Me.chksolofinca.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolofinca.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolofinca.Location = New System.Drawing.Point(0, 37)
    Me.chksolofinca.Name = "chksolofinca"
    Me.chksolofinca.Size = New System.Drawing.Size(187, 16)
    Me.chksolofinca.TabIndex = 69
    Me.chksolofinca.Text = "Sólo de la finca"
    '
    'CtlZafra1
    '
    Me.CtlZafra1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(0, 16)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(187, 21)
    Me.CtlZafra1.TabIndex = 81
    Me.CtlZafra1.Zafra = Nothing
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(187, 16)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Zafra:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'tvbloques
    '
    Me.tvbloques.CheckBoxes = True
    Me.tvbloques.ContextMenuStrip = Me.ContextMenuStrip1
    Me.tvbloques.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvbloques.HideSelection = False
    Me.tvbloques.Location = New System.Drawing.Point(0, 521)
    Me.tvbloques.Name = "tvbloques"
    Me.tvbloques.ShowLines = False
    Me.tvbloques.ShowPlusMinus = False
    Me.tvbloques.ShowRootLines = False
    Me.tvbloques.Size = New System.Drawing.Size(187, 159)
    Me.tvbloques.TabIndex = 49
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.chktodos)
    Me.Panel7.Controls.Add(Me.btnbuscar)
    Me.Panel7.Controls.Add(Me.btnexportar)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 491)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(187, 30)
    Me.Panel7.TabIndex = 48
    '
    'chktodos
    '
    Me.chktodos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chktodos.Location = New System.Drawing.Point(0, 12)
    Me.chktodos.Name = "chktodos"
    Me.chktodos.Size = New System.Drawing.Size(12, 18)
    Me.chktodos.TabIndex = 0
    '
    'btnbuscar
    '
    Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnbuscar.Location = New System.Drawing.Point(16, 0)
    Me.btnbuscar.Name = "btnbuscar"
    Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
    Me.btnbuscar.TabIndex = 0
    Me.btnbuscar.Text = "&Buscar"
    '
    'btnexportar
    '
    Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnexportar.Location = New System.Drawing.Point(96, 0)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(75, 23)
    Me.btnexportar.TabIndex = 0
    Me.btnexportar.Text = "&Exportar"
    '
    'lblstatus
    '
    Me.lblstatus.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblstatus.Location = New System.Drawing.Point(0, 680)
    Me.lblstatus.Name = "lblstatus"
    Me.lblstatus.Size = New System.Drawing.Size(187, 16)
    Me.lblstatus.TabIndex = 50
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarToolStripMenuItem})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 26)
    '
    'SeleccionarToolStripMenuItem
    '
    Me.SeleccionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu25, Me.mnu50, Me.mnu100, Me.mnu250, Me.mnu500, Me.mnu1000})
    Me.SeleccionarToolStripMenuItem.Name = "SeleccionarToolStripMenuItem"
    Me.SeleccionarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
    Me.SeleccionarToolStripMenuItem.Text = "Seleccionar"
    '
    'mnu25
    '
    Me.mnu25.Name = "mnu25"
    Me.mnu25.Size = New System.Drawing.Size(152, 22)
    Me.mnu25.Text = "25"
    '
    'mnu50
    '
    Me.mnu50.Name = "mnu50"
    Me.mnu50.Size = New System.Drawing.Size(152, 22)
    Me.mnu50.Text = "50"
    '
    'mnu100
    '
    Me.mnu100.Name = "mnu100"
    Me.mnu100.Size = New System.Drawing.Size(152, 22)
    Me.mnu100.Text = "100"
    '
    'mnu250
    '
    Me.mnu250.Name = "mnu250"
    Me.mnu250.Size = New System.Drawing.Size(152, 22)
    Me.mnu250.Text = "250"
    '
    'mnu500
    '
    Me.mnu500.Name = "mnu500"
    Me.mnu500.Size = New System.Drawing.Size(152, 22)
    Me.mnu500.Text = "500"
    '
    'mnu1000
    '
    Me.mnu1000.Name = "mnu1000"
    Me.mnu1000.Size = New System.Drawing.Size(152, 22)
    Me.mnu1000.Text = "1000"
    '
    'CtlBuscaBloqueFermentacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Info
    Me.Controls.Add(Me.tvbloques)
    Me.Controls.Add(Me.Panel7)
    Me.Controls.Add(Me.lblstatus)
    Me.Controls.Add(Me.pnlbusqbloque)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlBuscaBloqueFermentacion"
    Me.Size = New System.Drawing.Size(187, 696)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.pnlbusqbloque.ResumeLayout(False)
    Me.pnlnumeroembarque.ResumeLayout(False)
    Me.pnlnumeroembarque.PerformLayout()
    Me.pnlsolocorte.ResumeLayout(False)
    Me.pnlsolosemilla.ResumeLayout(False)
    Me.pnlfechatipomov.ResumeLayout(False)
    Me.pnlsololote.ResumeLayout(False)
    Me.pnlsolofinca.ResumeLayout(False)
    Me.Panel7.ResumeLayout(False)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents pnlbusqbloque As System.Windows.Forms.Panel
  Friend WithEvents pnlfin As System.Windows.Forms.Panel
  Friend WithEvents pnlnumeroembarque As System.Windows.Forms.Panel
  Friend WithEvents txthasta As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtdesde As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents chknumerobloque As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolocorte As System.Windows.Forms.Panel
  Friend WithEvents CtlCorte1 As CtlCorte
  Friend WithEvents Panel12 As System.Windows.Forms.Panel
  Friend WithEvents chksolocorte As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolosemilla As System.Windows.Forms.Panel
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents chksolosemilla As System.Windows.Forms.CheckBox
  Friend WithEvents pnlfechatipomov As System.Windows.Forms.Panel
  Friend WithEvents dtfecbloqfin As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents dtfecbloqini As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents cbotipomovinv As System.Windows.Forms.ComboBox
  Friend WithEvents Panel11 As System.Windows.Forms.Panel
  Friend WithEvents chkfechatipomov As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsololote As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents chksololote As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolofinca As System.Windows.Forms.Panel
  Friend WithEvents Panel16 As System.Windows.Forms.Panel
  Friend WithEvents chksolofinca As System.Windows.Forms.CheckBox
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents CtlTerreno1 As CtlTerreno
  Friend WithEvents CtlLote1 As CtlLote
  Friend WithEvents CtlSemilla1 As CtlSemilla
  Friend WithEvents tvbloques As System.Windows.Forms.TreeView
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Friend WithEvents btnbuscar As System.Windows.Forms.Button
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents lblstatus As System.Windows.Forms.Label
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents SeleccionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu25 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu50 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu100 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu250 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu500 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu1000 As System.Windows.Forms.ToolStripMenuItem

End Class
