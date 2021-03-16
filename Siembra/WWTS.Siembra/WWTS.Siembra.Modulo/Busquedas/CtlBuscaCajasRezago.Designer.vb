<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaCajasRezago
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
    Me.pnlbusqcajas = New System.Windows.Forms.Panel
    Me.pnlfin = New System.Windows.Forms.Panel
    Me.pnlsolocajasembarcadas = New System.Windows.Forms.Panel
    Me.pnlnumeroembarque = New System.Windows.Forms.Panel
    Me.txthasta = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtdesde = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label4 = New System.Windows.Forms.Label
    Me.Panel6 = New System.Windows.Forms.Panel
    Me.Label5 = New System.Windows.Forms.Label
    Me.chknumeroembarque = New System.Windows.Forms.CheckBox
    Me.Panel19 = New System.Windows.Forms.Panel
    Me.chksolocajasembarcadas = New System.Windows.Forms.CheckBox
    Me.pnlsolofinca = New System.Windows.Forms.Panel
    Me.CtlTerreno1 = New CtlTerreno
    Me.Panel16 = New System.Windows.Forms.Panel
    Me.chksolofinca = New System.Windows.Forms.CheckBox
    Me.pnlsolocorte = New System.Windows.Forms.Panel
    Me.CtlCorte1 = New CtlCorte
    Me.Panel12 = New System.Windows.Forms.Panel
    Me.chksolocorte = New System.Windows.Forms.CheckBox
    Me.pnlsolobodega = New System.Windows.Forms.Panel
    Me.CtlBodega1 = New CtlBodega
    Me.Panel8 = New System.Windows.Forms.Panel
    Me.chksolobodega = New System.Windows.Forms.CheckBox
    Me.pnlsolosemilla = New System.Windows.Forms.Panel
    Me.CtlSemilla1 = New CtlSemilla
    Me.Panel5 = New System.Windows.Forms.Panel
    Me.chksolosemilla = New System.Windows.Forms.CheckBox
    Me.pnlsolocolor = New System.Windows.Forms.Panel
    Me.CtlColorHoja1 = New CtlColorHoja
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.chksolocolor = New System.Windows.Forms.CheckBox
    Me.pnlsoloclase = New System.Windows.Forms.Panel
    Me.CtlClaseHoja1 = New CtlClaseHoja
    Me.chknoestaclase = New System.Windows.Forms.CheckBox
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.chksoloclase = New System.Windows.Forms.CheckBox
    Me.pnlfechaempaque = New System.Windows.Forms.Panel
    Me.dtfecempfin = New System.Windows.Forms.DateTimePicker
    Me.Label44 = New System.Windows.Forms.Label
    Me.dtfecempini = New System.Windows.Forms.DateTimePicker
    Me.Label43 = New System.Windows.Forms.Label
    Me.Panel11 = New System.Windows.Forms.Panel
    Me.chkfechaempaque = New System.Windows.Forms.CheckBox
    Me.CtlZafra1 = New CtlZafra
    Me.Label1 = New System.Windows.Forms.Label
    Me.pnltipotabaco = New System.Windows.Forms.Panel
    Me.rdotabnatural = New System.Windows.Forms.RadioButton
    Me.rdotabcandela = New System.Windows.Forms.RadioButton
    Me.tvcajas = New System.Windows.Forms.TreeView
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
    Me.pnlbusqcajas.SuspendLayout()
    Me.pnlsolocajasembarcadas.SuspendLayout()
    Me.pnlnumeroembarque.SuspendLayout()
    Me.pnlsolofinca.SuspendLayout()
    Me.pnlsolocorte.SuspendLayout()
    Me.pnlsolobodega.SuspendLayout()
    Me.pnlsolosemilla.SuspendLayout()
    Me.pnlsolocolor.SuspendLayout()
    Me.pnlsoloclase.SuspendLayout()
    Me.pnlfechaempaque.SuspendLayout()
    Me.pnltipotabaco.SuspendLayout()
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
    Me.HeaderStrip2.Size = New System.Drawing.Size(176, 19)
    Me.HeaderStrip2.TabIndex = 5
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(97, 16)
    Me.ToolStripLabel1.Text = "Búsqueda de cajas"
    '
    'pnlbusqcajas
    '
    Me.pnlbusqcajas.Controls.Add(Me.pnlfin)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsolocajasembarcadas)
    Me.pnlbusqcajas.Controls.Add(Me.chksolocajasembarcadas)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsolofinca)
    Me.pnlbusqcajas.Controls.Add(Me.chksolofinca)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsolocorte)
    Me.pnlbusqcajas.Controls.Add(Me.chksolocorte)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsolobodega)
    Me.pnlbusqcajas.Controls.Add(Me.chksolobodega)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsolosemilla)
    Me.pnlbusqcajas.Controls.Add(Me.chksolosemilla)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsolocolor)
    Me.pnlbusqcajas.Controls.Add(Me.chksolocolor)
    Me.pnlbusqcajas.Controls.Add(Me.pnlsoloclase)
    Me.pnlbusqcajas.Controls.Add(Me.chksoloclase)
    Me.pnlbusqcajas.Controls.Add(Me.pnlfechaempaque)
    Me.pnlbusqcajas.Controls.Add(Me.chkfechaempaque)
    Me.pnlbusqcajas.Controls.Add(Me.CtlZafra1)
    Me.pnlbusqcajas.Controls.Add(Me.Label1)
    Me.pnlbusqcajas.Controls.Add(Me.pnltipotabaco)
    Me.pnlbusqcajas.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlbusqcajas.Location = New System.Drawing.Point(0, 19)
    Me.pnlbusqcajas.Name = "pnlbusqcajas"
    Me.pnlbusqcajas.Size = New System.Drawing.Size(176, 615)
    Me.pnlbusqcajas.TabIndex = 45
    '
    'pnlfin
    '
    Me.pnlfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfin.Location = New System.Drawing.Point(0, 580)
    Me.pnlfin.Name = "pnlfin"
    Me.pnlfin.Size = New System.Drawing.Size(176, 8)
    Me.pnlfin.TabIndex = 75
    '
    'pnlsolocajasembarcadas
    '
    Me.pnlsolocajasembarcadas.BackColor = System.Drawing.SystemColors.Info
    Me.pnlsolocajasembarcadas.Controls.Add(Me.pnlnumeroembarque)
    Me.pnlsolocajasembarcadas.Controls.Add(Me.chknumeroembarque)
    Me.pnlsolocajasembarcadas.Controls.Add(Me.Panel19)
    Me.pnlsolocajasembarcadas.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolocajasembarcadas.Location = New System.Drawing.Point(0, 500)
    Me.pnlsolocajasembarcadas.Name = "pnlsolocajasembarcadas"
    Me.pnlsolocajasembarcadas.Size = New System.Drawing.Size(176, 80)
    Me.pnlsolocajasembarcadas.TabIndex = 74
    Me.pnlsolocajasembarcadas.Visible = False
    '
    'pnlnumeroembarque
    '
    Me.pnlnumeroembarque.Controls.Add(Me.txthasta)
    Me.pnlnumeroembarque.Controls.Add(Me.txtdesde)
    Me.pnlnumeroembarque.Controls.Add(Me.Label4)
    Me.pnlnumeroembarque.Controls.Add(Me.Panel6)
    Me.pnlnumeroembarque.Controls.Add(Me.Label5)
    Me.pnlnumeroembarque.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlnumeroembarque.Location = New System.Drawing.Point(16, 18)
    Me.pnlnumeroembarque.Name = "pnlnumeroembarque"
    Me.pnlnumeroembarque.Size = New System.Drawing.Size(160, 54)
    Me.pnlnumeroembarque.TabIndex = 78
    Me.pnlnumeroembarque.Visible = False
    '
    'txthasta
    '
    Me.txthasta.Location = New System.Drawing.Point(76, 29)
    Me.txthasta.Name = "txthasta"
    Me.txthasta.Size = New System.Drawing.Size(68, 20)
    Me.txthasta.TabIndex = 82
    Me.txthasta.Text = "0"
    Me.txthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthasta.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'txtdesde
    '
    Me.txtdesde.Location = New System.Drawing.Point(76, 5)
    Me.txtdesde.Name = "txtdesde"
    Me.txtdesde.Size = New System.Drawing.Size(68, 20)
    Me.txtdesde.TabIndex = 82
    Me.txtdesde.Text = "0"
    Me.txtdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdesde.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(16, 8)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(41, 13)
    Me.Label4.TabIndex = 81
    Me.Label4.Text = "Desde:"
    '
    'Panel6
    '
    Me.Panel6.BackColor = System.Drawing.SystemColors.Info
    Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel6.Location = New System.Drawing.Point(0, 0)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(16, 54)
    Me.Panel6.TabIndex = 80
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(16, 32)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(38, 13)
    Me.Label5.TabIndex = 81
    Me.Label5.Text = "Hasta:"
    '
    'chknumeroembarque
    '
    Me.chknumeroembarque.BackColor = System.Drawing.SystemColors.Info
    Me.chknumeroembarque.Dock = System.Windows.Forms.DockStyle.Top
    Me.chknumeroembarque.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chknumeroembarque.Location = New System.Drawing.Point(16, 0)
    Me.chknumeroembarque.Name = "chknumeroembarque"
    Me.chknumeroembarque.Size = New System.Drawing.Size(160, 18)
    Me.chknumeroembarque.TabIndex = 77
    Me.chknumeroembarque.Text = "Por número de embarque"
    Me.chknumeroembarque.UseVisualStyleBackColor = False
    '
    'Panel19
    '
    Me.Panel19.BackColor = System.Drawing.SystemColors.Info
    Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel19.Location = New System.Drawing.Point(0, 0)
    Me.Panel19.Name = "Panel19"
    Me.Panel19.Size = New System.Drawing.Size(16, 80)
    Me.Panel19.TabIndex = 75
    '
    'chksolocajasembarcadas
    '
    Me.chksolocajasembarcadas.Checked = True
    Me.chksolocajasembarcadas.CheckState = System.Windows.Forms.CheckState.Indeterminate
    Me.chksolocajasembarcadas.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolocajasembarcadas.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolocajasembarcadas.Location = New System.Drawing.Point(0, 482)
    Me.chksolocajasembarcadas.Name = "chksolocajasembarcadas"
    Me.chksolocajasembarcadas.Size = New System.Drawing.Size(176, 18)
    Me.chksolocajasembarcadas.TabIndex = 72
    Me.chksolocajasembarcadas.Text = "Sólo cajas embarcadas"
    Me.chksolocajasembarcadas.ThreeState = True
    '
    'pnlsolofinca
    '
    Me.pnlsolofinca.Controls.Add(Me.CtlTerreno1)
    Me.pnlsolofinca.Controls.Add(Me.Panel16)
    Me.pnlsolofinca.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolofinca.Location = New System.Drawing.Point(0, 399)
    Me.pnlsolofinca.Name = "pnlsolofinca"
    Me.pnlsolofinca.Size = New System.Drawing.Size(176, 83)
    Me.pnlsolofinca.TabIndex = 70
    Me.pnlsolofinca.Visible = False
    '
    'CtlTerreno1
    '
    Me.CtlTerreno1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTerreno1.Location = New System.Drawing.Point(16, 0)
    Me.CtlTerreno1.Name = "CtlTerreno1"
    Me.CtlTerreno1.Op = Nothing
    Me.CtlTerreno1.Size = New System.Drawing.Size(160, 83)
    Me.CtlTerreno1.TabIndex = 1
    Me.CtlTerreno1.Terreno = Nothing
    '
    'Panel16
    '
    Me.Panel16.BackColor = System.Drawing.SystemColors.Info
    Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel16.Location = New System.Drawing.Point(0, 0)
    Me.Panel16.Name = "Panel16"
    Me.Panel16.Size = New System.Drawing.Size(16, 83)
    Me.Panel16.TabIndex = 0
    '
    'chksolofinca
    '
    Me.chksolofinca.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolofinca.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolofinca.Location = New System.Drawing.Point(0, 381)
    Me.chksolofinca.Name = "chksolofinca"
    Me.chksolofinca.Size = New System.Drawing.Size(176, 18)
    Me.chksolofinca.TabIndex = 69
    Me.chksolofinca.Text = "Sólo de la finca"
    '
    'pnlsolocorte
    '
    Me.pnlsolocorte.Controls.Add(Me.CtlCorte1)
    Me.pnlsolocorte.Controls.Add(Me.Panel12)
    Me.pnlsolocorte.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolocorte.Location = New System.Drawing.Point(0, 357)
    Me.pnlsolocorte.Name = "pnlsolocorte"
    Me.pnlsolocorte.Size = New System.Drawing.Size(176, 24)
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
    Me.CtlCorte1.Size = New System.Drawing.Size(160, 21)
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
    Me.chksolocorte.Location = New System.Drawing.Point(0, 339)
    Me.chksolocorte.Name = "chksolocorte"
    Me.chksolocorte.Size = New System.Drawing.Size(176, 18)
    Me.chksolocorte.TabIndex = 65
    Me.chksolocorte.Text = "Sólo del corte"
    '
    'pnlsolobodega
    '
    Me.pnlsolobodega.Controls.Add(Me.CtlBodega1)
    Me.pnlsolobodega.Controls.Add(Me.Panel8)
    Me.pnlsolobodega.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolobodega.Location = New System.Drawing.Point(0, 315)
    Me.pnlsolobodega.Name = "pnlsolobodega"
    Me.pnlsolobodega.Size = New System.Drawing.Size(176, 24)
    Me.pnlsolobodega.TabIndex = 64
    Me.pnlsolobodega.Visible = False
    '
    'CtlBodega1
    '
    Me.CtlBodega1.Bodega = Nothing
    Me.CtlBodega1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlBodega1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlBodega1.FormattingEnabled = True
    Me.CtlBodega1.Location = New System.Drawing.Point(16, 0)
    Me.CtlBodega1.Name = "CtlBodega1"
    Me.CtlBodega1.Op = Nothing
    Me.CtlBodega1.PuedeActualizar = True
    Me.CtlBodega1.PuedeEliminar = True
    Me.CtlBodega1.PuedeModificar = True
    Me.CtlBodega1.PuedeNuevo = True
    Me.CtlBodega1.Size = New System.Drawing.Size(160, 21)
    Me.CtlBodega1.TabIndex = 1
    '
    'Panel8
    '
    Me.Panel8.BackColor = System.Drawing.SystemColors.Info
    Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel8.Location = New System.Drawing.Point(0, 0)
    Me.Panel8.Name = "Panel8"
    Me.Panel8.Size = New System.Drawing.Size(16, 24)
    Me.Panel8.TabIndex = 0
    '
    'chksolobodega
    '
    Me.chksolobodega.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolobodega.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolobodega.Location = New System.Drawing.Point(0, 297)
    Me.chksolobodega.Name = "chksolobodega"
    Me.chksolobodega.Size = New System.Drawing.Size(176, 18)
    Me.chksolobodega.TabIndex = 63
    Me.chksolobodega.Text = "Sólo de la bodega"
    '
    'pnlsolosemilla
    '
    Me.pnlsolosemilla.Controls.Add(Me.CtlSemilla1)
    Me.pnlsolosemilla.Controls.Add(Me.Panel5)
    Me.pnlsolosemilla.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolosemilla.Location = New System.Drawing.Point(0, 273)
    Me.pnlsolosemilla.Name = "pnlsolosemilla"
    Me.pnlsolosemilla.Size = New System.Drawing.Size(176, 24)
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
    Me.CtlSemilla1.Size = New System.Drawing.Size(160, 21)
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
    Me.chksolosemilla.Location = New System.Drawing.Point(0, 255)
    Me.chksolosemilla.Name = "chksolosemilla"
    Me.chksolosemilla.Size = New System.Drawing.Size(176, 18)
    Me.chksolosemilla.TabIndex = 61
    Me.chksolosemilla.Text = "Sólo de la semilla"
    '
    'pnlsolocolor
    '
    Me.pnlsolocolor.Controls.Add(Me.CtlColorHoja1)
    Me.pnlsolocolor.Controls.Add(Me.Panel2)
    Me.pnlsolocolor.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolocolor.Location = New System.Drawing.Point(0, 231)
    Me.pnlsolocolor.Name = "pnlsolocolor"
    Me.pnlsolocolor.Size = New System.Drawing.Size(176, 24)
    Me.pnlsolocolor.TabIndex = 60
    Me.pnlsolocolor.Visible = False
    '
    'CtlColorHoja1
    '
    Me.CtlColorHoja1.ColorHoja = Nothing
    Me.CtlColorHoja1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlColorHoja1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlColorHoja1.FormattingEnabled = True
    Me.CtlColorHoja1.Location = New System.Drawing.Point(16, 0)
    Me.CtlColorHoja1.Name = "CtlColorHoja1"
    Me.CtlColorHoja1.Op = Nothing
    Me.CtlColorHoja1.PuedeActualizar = True
    Me.CtlColorHoja1.PuedeEliminar = True
    Me.CtlColorHoja1.PuedeModificar = True
    Me.CtlColorHoja1.PuedeNuevo = True
    Me.CtlColorHoja1.Size = New System.Drawing.Size(160, 21)
    Me.CtlColorHoja1.TabIndex = 1
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.Info
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(16, 24)
    Me.Panel2.TabIndex = 0
    '
    'chksolocolor
    '
    Me.chksolocolor.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolocolor.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolocolor.Location = New System.Drawing.Point(0, 213)
    Me.chksolocolor.Name = "chksolocolor"
    Me.chksolocolor.Size = New System.Drawing.Size(176, 18)
    Me.chksolocolor.TabIndex = 59
    Me.chksolocolor.Text = "Sólo del color"
    '
    'pnlsoloclase
    '
    Me.pnlsoloclase.Controls.Add(Me.CtlClaseHoja1)
    Me.pnlsoloclase.Controls.Add(Me.chknoestaclase)
    Me.pnlsoloclase.Controls.Add(Me.Panel3)
    Me.pnlsoloclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsoloclase.Location = New System.Drawing.Point(0, 174)
    Me.pnlsoloclase.Name = "pnlsoloclase"
    Me.pnlsoloclase.Size = New System.Drawing.Size(176, 39)
    Me.pnlsoloclase.TabIndex = 58
    Me.pnlsoloclase.Visible = False
    '
    'CtlClaseHoja1
    '
    Me.CtlClaseHoja1.ClaseHoja = Nothing
    Me.CtlClaseHoja1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.CtlClaseHoja1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlClaseHoja1.FormattingEnabled = True
    Me.CtlClaseHoja1.Location = New System.Drawing.Point(16, 18)
    Me.CtlClaseHoja1.Name = "CtlClaseHoja1"
    Me.CtlClaseHoja1.Op = Nothing
    Me.CtlClaseHoja1.PuedeActualizar = True
    Me.CtlClaseHoja1.PuedeEliminar = True
    Me.CtlClaseHoja1.PuedeModificar = True
    Me.CtlClaseHoja1.PuedeNuevo = True
    Me.CtlClaseHoja1.Size = New System.Drawing.Size(160, 21)
    Me.CtlClaseHoja1.TabIndex = 3
    '
    'chknoestaclase
    '
    Me.chknoestaclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.chknoestaclase.Location = New System.Drawing.Point(16, 0)
    Me.chknoestaclase.Name = "chknoestaclase"
    Me.chknoestaclase.Size = New System.Drawing.Size(160, 16)
    Me.chknoestaclase.TabIndex = 2
    Me.chknoestaclase.Text = "Todas menos"
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.SystemColors.Info
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(16, 39)
    Me.Panel3.TabIndex = 0
    '
    'chksoloclase
    '
    Me.chksoloclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksoloclase.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksoloclase.Location = New System.Drawing.Point(0, 156)
    Me.chksoloclase.Name = "chksoloclase"
    Me.chksoloclase.Size = New System.Drawing.Size(176, 18)
    Me.chksoloclase.TabIndex = 9
    Me.chksoloclase.Text = "Sólo de la clase"
    '
    'pnlfechaempaque
    '
    Me.pnlfechaempaque.Controls.Add(Me.dtfecempfin)
    Me.pnlfechaempaque.Controls.Add(Me.Label44)
    Me.pnlfechaempaque.Controls.Add(Me.dtfecempini)
    Me.pnlfechaempaque.Controls.Add(Me.Label43)
    Me.pnlfechaempaque.Controls.Add(Me.Panel11)
    Me.pnlfechaempaque.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfechaempaque.Location = New System.Drawing.Point(0, 87)
    Me.pnlfechaempaque.Name = "pnlfechaempaque"
    Me.pnlfechaempaque.Size = New System.Drawing.Size(176, 69)
    Me.pnlfechaempaque.TabIndex = 52
    Me.pnlfechaempaque.Visible = False
    '
    'dtfecempfin
    '
    Me.dtfecempfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecempfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecempfin.Location = New System.Drawing.Point(16, 48)
    Me.dtfecempfin.Name = "dtfecempfin"
    Me.dtfecempfin.Size = New System.Drawing.Size(160, 20)
    Me.dtfecempfin.TabIndex = 4
    Me.dtfecempfin.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
    '
    'Label44
    '
    Me.Label44.BackColor = System.Drawing.SystemColors.Info
    Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label44.Location = New System.Drawing.Point(16, 32)
    Me.Label44.Name = "Label44"
    Me.Label44.Size = New System.Drawing.Size(160, 16)
    Me.Label44.TabIndex = 3
    Me.Label44.Text = "Hasta:"
    Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecempini
    '
    Me.dtfecempini.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecempini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecempini.Location = New System.Drawing.Point(16, 12)
    Me.dtfecempini.Name = "dtfecempini"
    Me.dtfecempini.Size = New System.Drawing.Size(160, 20)
    Me.dtfecempini.TabIndex = 2
    Me.dtfecempini.Value = New Date(2005, 3, 13, 20, 27, 9, 968)
    '
    'Label43
    '
    Me.Label43.BackColor = System.Drawing.SystemColors.Info
    Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label43.Location = New System.Drawing.Point(16, 0)
    Me.Label43.Name = "Label43"
    Me.Label43.Size = New System.Drawing.Size(160, 12)
    Me.Label43.TabIndex = 1
    Me.Label43.Text = "Desde:"
    Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel11
    '
    Me.Panel11.BackColor = System.Drawing.SystemColors.Info
    Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel11.Location = New System.Drawing.Point(0, 0)
    Me.Panel11.Name = "Panel11"
    Me.Panel11.Size = New System.Drawing.Size(16, 69)
    Me.Panel11.TabIndex = 0
    '
    'chkfechaempaque
    '
    Me.chkfechaempaque.Checked = True
    Me.chkfechaempaque.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkfechaempaque.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkfechaempaque.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkfechaempaque.Location = New System.Drawing.Point(0, 69)
    Me.chkfechaempaque.Name = "chkfechaempaque"
    Me.chkfechaempaque.Size = New System.Drawing.Size(176, 18)
    Me.chkfechaempaque.TabIndex = 71
    Me.chkfechaempaque.Text = "Por fecha de empaque"
    '
    'CtlZafra1
    '
    Me.CtlZafra1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(0, 48)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(176, 21)
    Me.CtlZafra1.TabIndex = 77
    Me.CtlZafra1.Zafra = Nothing
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 32)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(176, 16)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Zafra:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnltipotabaco
    '
    Me.pnltipotabaco.Controls.Add(Me.rdotabnatural)
    Me.pnltipotabaco.Controls.Add(Me.rdotabcandela)
    Me.pnltipotabaco.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnltipotabaco.Location = New System.Drawing.Point(0, 0)
    Me.pnltipotabaco.Name = "pnltipotabaco"
    Me.pnltipotabaco.Size = New System.Drawing.Size(176, 32)
    Me.pnltipotabaco.TabIndex = 76
    '
    'rdotabnatural
    '
    Me.rdotabnatural.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdotabnatural.Location = New System.Drawing.Point(0, 16)
    Me.rdotabnatural.Name = "rdotabnatural"
    Me.rdotabnatural.Size = New System.Drawing.Size(176, 16)
    Me.rdotabnatural.TabIndex = 0
    Me.rdotabnatural.Text = "Tabaco Natural"
    '
    'rdotabcandela
    '
    Me.rdotabcandela.Checked = True
    Me.rdotabcandela.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdotabcandela.Location = New System.Drawing.Point(0, 0)
    Me.rdotabcandela.Name = "rdotabcandela"
    Me.rdotabcandela.Size = New System.Drawing.Size(176, 16)
    Me.rdotabcandela.TabIndex = 1
    Me.rdotabcandela.TabStop = True
    Me.rdotabcandela.Text = "Tabaco Candela"
    '
    'tvcajas
    '
    Me.tvcajas.CheckBoxes = True
    Me.tvcajas.ContextMenuStrip = Me.ContextMenuStrip1
    Me.tvcajas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvcajas.HideSelection = False
    Me.tvcajas.Location = New System.Drawing.Point(0, 664)
    Me.tvcajas.Name = "tvcajas"
    Me.tvcajas.ShowLines = False
    Me.tvcajas.ShowPlusMinus = False
    Me.tvcajas.ShowRootLines = False
    Me.tvcajas.Size = New System.Drawing.Size(176, 141)
    Me.tvcajas.TabIndex = 49
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.chktodos)
    Me.Panel7.Controls.Add(Me.btnbuscar)
    Me.Panel7.Controls.Add(Me.btnexportar)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 634)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(176, 30)
    Me.Panel7.TabIndex = 48
    '
    'chktodos
    '
    Me.chktodos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chktodos.Location = New System.Drawing.Point(6, 12)
    Me.chktodos.Name = "chktodos"
    Me.chktodos.Size = New System.Drawing.Size(12, 18)
    Me.chktodos.TabIndex = 0
    '
    'btnbuscar
    '
    Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.btnbuscar.Location = New System.Drawing.Point(24, 0)
    Me.btnbuscar.Name = "btnbuscar"
    Me.btnbuscar.Size = New System.Drawing.Size(64, 24)
    Me.btnbuscar.TabIndex = 0
    Me.btnbuscar.Text = "&Buscar"
    '
    'btnexportar
    '
    Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.btnexportar.Location = New System.Drawing.Point(96, 0)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(64, 24)
    Me.btnexportar.TabIndex = 0
    Me.btnexportar.Text = "&Exportar"
    '
    'lblstatus
    '
    Me.lblstatus.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblstatus.Location = New System.Drawing.Point(0, 805)
    Me.lblstatus.Name = "lblstatus"
    Me.lblstatus.Size = New System.Drawing.Size(176, 16)
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
    Me.mnu25.Size = New System.Drawing.Size(98, 22)
    Me.mnu25.Text = "25"
    '
    'mnu50
    '
    Me.mnu50.Name = "mnu50"
    Me.mnu50.Size = New System.Drawing.Size(98, 22)
    Me.mnu50.Text = "50"
    '
    'mnu100
    '
    Me.mnu100.Name = "mnu100"
    Me.mnu100.Size = New System.Drawing.Size(98, 22)
    Me.mnu100.Text = "100"
    '
    'mnu250
    '
    Me.mnu250.Name = "mnu250"
    Me.mnu250.Size = New System.Drawing.Size(98, 22)
    Me.mnu250.Text = "250"
    '
    'mnu500
    '
    Me.mnu500.Name = "mnu500"
    Me.mnu500.Size = New System.Drawing.Size(98, 22)
    Me.mnu500.Text = "500"
    '
    'mnu1000
    '
    Me.mnu1000.Name = "mnu1000"
    Me.mnu1000.Size = New System.Drawing.Size(98, 22)
    Me.mnu1000.Text = "1000"
    '
    'CtlBuscaCajasRezago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Info
    Me.Controls.Add(Me.tvcajas)
    Me.Controls.Add(Me.Panel7)
    Me.Controls.Add(Me.lblstatus)
    Me.Controls.Add(Me.pnlbusqcajas)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlBuscaCajasRezago"
    Me.Size = New System.Drawing.Size(176, 821)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.pnlbusqcajas.ResumeLayout(False)
    Me.pnlsolocajasembarcadas.ResumeLayout(False)
    Me.pnlnumeroembarque.ResumeLayout(False)
    Me.pnlnumeroembarque.PerformLayout()
    Me.pnlsolofinca.ResumeLayout(False)
    Me.pnlsolocorte.ResumeLayout(False)
    Me.pnlsolobodega.ResumeLayout(False)
    Me.pnlsolosemilla.ResumeLayout(False)
    Me.pnlsolocolor.ResumeLayout(False)
    Me.pnlsoloclase.ResumeLayout(False)
    Me.pnlfechaempaque.ResumeLayout(False)
    Me.pnltipotabaco.ResumeLayout(False)
    Me.Panel7.ResumeLayout(False)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents pnlbusqcajas As System.Windows.Forms.Panel
  Friend WithEvents pnlfin As System.Windows.Forms.Panel
  Friend WithEvents pnlsolocajasembarcadas As System.Windows.Forms.Panel
  Friend WithEvents pnlnumeroembarque As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents chknumeroembarque As System.Windows.Forms.CheckBox
  Friend WithEvents Panel19 As System.Windows.Forms.Panel
  Friend WithEvents chksolocajasembarcadas As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolofinca As System.Windows.Forms.Panel
  Friend WithEvents Panel16 As System.Windows.Forms.Panel
  Friend WithEvents chksolofinca As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolocorte As System.Windows.Forms.Panel
  Friend WithEvents Panel12 As System.Windows.Forms.Panel
  Friend WithEvents chksolocorte As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolobodega As System.Windows.Forms.Panel
  Friend WithEvents Panel8 As System.Windows.Forms.Panel
  Friend WithEvents chksolobodega As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolosemilla As System.Windows.Forms.Panel
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents chksolosemilla As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolocolor As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents chksolocolor As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsoloclase As System.Windows.Forms.Panel
  Friend WithEvents chknoestaclase As System.Windows.Forms.CheckBox
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents chksoloclase As System.Windows.Forms.CheckBox
  Friend WithEvents pnlfechaempaque As System.Windows.Forms.Panel
  Friend WithEvents dtfecempfin As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents dtfecempini As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents Panel11 As System.Windows.Forms.Panel
  Friend WithEvents chkfechaempaque As System.Windows.Forms.CheckBox
  Friend WithEvents pnltipotabaco As System.Windows.Forms.Panel
  Friend WithEvents rdotabnatural As System.Windows.Forms.RadioButton
  Friend WithEvents rdotabcandela As System.Windows.Forms.RadioButton
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txthasta As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtdesde As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents CtlTerreno1 As CtlTerreno
  Friend WithEvents CtlCorte1 As CtlCorte
  Friend WithEvents CtlBodega1 As CtlBodega
  Friend WithEvents CtlSemilla1 As CtlSemilla
  Friend WithEvents tvcajas As System.Windows.Forms.TreeView
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Friend WithEvents btnbuscar As System.Windows.Forms.Button
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents lblstatus As System.Windows.Forms.Label
  Friend WithEvents CtlColorHoja1 As CtlColorHoja
  Friend WithEvents CtlClaseHoja1 As CtlClaseHoja
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents SeleccionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu25 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu50 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu100 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu250 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu500 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu1000 As System.Windows.Forms.ToolStripMenuItem

End Class
