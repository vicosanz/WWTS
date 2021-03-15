<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaTarjetaEnsZaf
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
    Me.tvtarjetas = New System.Windows.Forms.TreeView
    Me.Panel7 = New System.Windows.Forms.Panel
    Me.chktodos = New System.Windows.Forms.CheckBox
    Me.btnbuscar = New System.Windows.Forms.Button
    Me.btnexportar = New System.Windows.Forms.Button
    Me.pnlbusqtarj = New System.Windows.Forms.Panel
    Me.pnlfin = New System.Windows.Forms.Panel
    Me.pnlsolotarjetaszafadas = New System.Windows.Forms.Panel
    Me.pnlfinzafada = New System.Windows.Forms.Panel
    Me.pnlfechazafada = New System.Windows.Forms.Panel
    Me.dtfeczafini = New System.Windows.Forms.DateTimePicker
    Me.Label6 = New System.Windows.Forms.Label
    Me.Panel4 = New System.Windows.Forms.Panel
    Me.Label7 = New System.Windows.Forms.Label
    Me.dtfeczaffin = New System.Windows.Forms.DateTimePicker
    Me.chkfechazafada = New System.Windows.Forms.CheckBox
    Me.Panel19 = New System.Windows.Forms.Panel
    Me.chksolotarjetaszafadas = New System.Windows.Forms.CheckBox
    Me.pnlnumeroembarque = New System.Windows.Forms.Panel
    Me.txthasta = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtdesde = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label4 = New System.Windows.Forms.Label
    Me.Panel6 = New System.Windows.Forms.Panel
    Me.Label5 = New System.Windows.Forms.Label
    Me.chknumerozafada = New System.Windows.Forms.CheckBox
    Me.pnlsolocorte = New System.Windows.Forms.Panel
    Me.CtlCorte1 = New WWTS.Siembra.Modulo.CtlCorte
    Me.Panel12 = New System.Windows.Forms.Panel
    Me.chksolocorte = New System.Windows.Forms.CheckBox
    Me.pnlsolosemilla = New System.Windows.Forms.Panel
    Me.CtlSemilla1 = New WWTS.Siembra.Modulo.CtlSemilla
    Me.Panel5 = New System.Windows.Forms.Panel
    Me.chksolosemilla = New System.Windows.Forms.CheckBox
    Me.pnlsolohorno = New System.Windows.Forms.Panel
    Me.CtlSeccionHorno1 = New WWTS.Siembra.Modulo.CtlSeccionHorno
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.chksolohornosec = New System.Windows.Forms.CheckBox
    Me.pnlfechaensarte = New System.Windows.Forms.Panel
    Me.dtfecensfin = New System.Windows.Forms.DateTimePicker
    Me.Label44 = New System.Windows.Forms.Label
    Me.dtfecensini = New System.Windows.Forms.DateTimePicker
    Me.Label43 = New System.Windows.Forms.Label
    Me.Panel11 = New System.Windows.Forms.Panel
    Me.chkfechaensarte = New System.Windows.Forms.CheckBox
    Me.pnlsololote = New System.Windows.Forms.Panel
    Me.CtlLote1 = New WWTS.Siembra.Modulo.CtlLote
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.chksololote = New System.Windows.Forms.CheckBox
    Me.pnlsolofinca = New System.Windows.Forms.Panel
    Me.CtlTerreno1 = New WWTS.Siembra.Modulo.CtlTerreno
    Me.Panel16 = New System.Windows.Forms.Panel
    Me.chksolofinca = New System.Windows.Forms.CheckBox
    Me.CtlZafra1 = New WWTS.Siembra.Modulo.CtlZafra
    Me.Label1 = New System.Windows.Forms.Label
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
    Me.Panel7.SuspendLayout()
    Me.pnlbusqtarj.SuspendLayout()
    Me.pnlsolotarjetaszafadas.SuspendLayout()
    Me.pnlfechazafada.SuspendLayout()
    Me.pnlnumeroembarque.SuspendLayout()
    Me.pnlsolocorte.SuspendLayout()
    Me.pnlsolosemilla.SuspendLayout()
    Me.pnlsolohorno.SuspendLayout()
    Me.pnlfechaensarte.SuspendLayout()
    Me.pnlsololote.SuspendLayout()
    Me.pnlsolofinca.SuspendLayout()
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
    Me.HeaderStrip2.Size = New System.Drawing.Size(197, 19)
    Me.HeaderStrip2.TabIndex = 6
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(110, 16)
    Me.ToolStripLabel1.Text = "Búsqueda de tarjetas"
    '
    'tvtarjetas
    '
    Me.tvtarjetas.CheckBoxes = True
    Me.tvtarjetas.ContextMenuStrip = Me.ContextMenuStrip1
    Me.tvtarjetas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvtarjetas.HideSelection = False
    Me.tvtarjetas.Location = New System.Drawing.Point(0, 702)
    Me.tvtarjetas.Name = "tvtarjetas"
    Me.tvtarjetas.ShowLines = False
    Me.tvtarjetas.ShowPlusMinus = False
    Me.tvtarjetas.ShowRootLines = False
    Me.tvtarjetas.Size = New System.Drawing.Size(197, 67)
    Me.tvtarjetas.TabIndex = 49
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.chktodos)
    Me.Panel7.Controls.Add(Me.btnbuscar)
    Me.Panel7.Controls.Add(Me.btnexportar)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 672)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(197, 30)
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
    'pnlbusqtarj
    '
    Me.pnlbusqtarj.Controls.Add(Me.pnlfin)
    Me.pnlbusqtarj.Controls.Add(Me.pnlsolotarjetaszafadas)
    Me.pnlbusqtarj.Controls.Add(Me.chksolotarjetaszafadas)
    Me.pnlbusqtarj.Controls.Add(Me.pnlnumeroembarque)
    Me.pnlbusqtarj.Controls.Add(Me.chknumerozafada)
    Me.pnlbusqtarj.Controls.Add(Me.pnlsolocorte)
    Me.pnlbusqtarj.Controls.Add(Me.chksolocorte)
    Me.pnlbusqtarj.Controls.Add(Me.pnlsolosemilla)
    Me.pnlbusqtarj.Controls.Add(Me.chksolosemilla)
    Me.pnlbusqtarj.Controls.Add(Me.pnlsolohorno)
    Me.pnlbusqtarj.Controls.Add(Me.chksolohornosec)
    Me.pnlbusqtarj.Controls.Add(Me.pnlfechaensarte)
    Me.pnlbusqtarj.Controls.Add(Me.chkfechaensarte)
    Me.pnlbusqtarj.Controls.Add(Me.pnlsololote)
    Me.pnlbusqtarj.Controls.Add(Me.chksololote)
    Me.pnlbusqtarj.Controls.Add(Me.pnlsolofinca)
    Me.pnlbusqtarj.Controls.Add(Me.chksolofinca)
    Me.pnlbusqtarj.Controls.Add(Me.CtlZafra1)
    Me.pnlbusqtarj.Controls.Add(Me.Label1)
    Me.pnlbusqtarj.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlbusqtarj.Location = New System.Drawing.Point(0, 19)
    Me.pnlbusqtarj.Name = "pnlbusqtarj"
    Me.pnlbusqtarj.Size = New System.Drawing.Size(197, 653)
    Me.pnlbusqtarj.TabIndex = 50
    '
    'pnlfin
    '
    Me.pnlfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfin.Location = New System.Drawing.Point(0, 625)
    Me.pnlfin.Name = "pnlfin"
    Me.pnlfin.Size = New System.Drawing.Size(197, 8)
    Me.pnlfin.TabIndex = 75
    '
    'pnlsolotarjetaszafadas
    '
    Me.pnlsolotarjetaszafadas.BackColor = System.Drawing.SystemColors.Info
    Me.pnlsolotarjetaszafadas.Controls.Add(Me.pnlfinzafada)
    Me.pnlsolotarjetaszafadas.Controls.Add(Me.pnlfechazafada)
    Me.pnlsolotarjetaszafadas.Controls.Add(Me.chkfechazafada)
    Me.pnlsolotarjetaszafadas.Controls.Add(Me.Panel19)
    Me.pnlsolotarjetaszafadas.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolotarjetaszafadas.Location = New System.Drawing.Point(0, 545)
    Me.pnlsolotarjetaszafadas.Name = "pnlsolotarjetaszafadas"
    Me.pnlsolotarjetaszafadas.Size = New System.Drawing.Size(197, 80)
    Me.pnlsolotarjetaszafadas.TabIndex = 74
    Me.pnlsolotarjetaszafadas.Visible = False
    '
    'pnlfinzafada
    '
    Me.pnlfinzafada.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfinzafada.Location = New System.Drawing.Point(16, 64)
    Me.pnlfinzafada.Name = "pnlfinzafada"
    Me.pnlfinzafada.Size = New System.Drawing.Size(181, 8)
    Me.pnlfinzafada.TabIndex = 81
    '
    'pnlfechazafada
    '
    Me.pnlfechazafada.Controls.Add(Me.dtfeczafini)
    Me.pnlfechazafada.Controls.Add(Me.Label6)
    Me.pnlfechazafada.Controls.Add(Me.Panel4)
    Me.pnlfechazafada.Controls.Add(Me.Label7)
    Me.pnlfechazafada.Controls.Add(Me.dtfeczaffin)
    Me.pnlfechazafada.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfechazafada.Location = New System.Drawing.Point(16, 16)
    Me.pnlfechazafada.Name = "pnlfechazafada"
    Me.pnlfechazafada.Size = New System.Drawing.Size(181, 48)
    Me.pnlfechazafada.TabIndex = 80
    Me.pnlfechazafada.Visible = False
    '
    'dtfeczafini
    '
    Me.dtfeczafini.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dtfeczafini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfeczafini.Location = New System.Drawing.Point(56, 0)
    Me.dtfeczafini.Name = "dtfeczafini"
    Me.dtfeczafini.Size = New System.Drawing.Size(123, 20)
    Me.dtfeczafini.TabIndex = 82
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(16, 4)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(40, 16)
    Me.Label6.TabIndex = 81
    Me.Label6.Text = "Desde:"
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.SystemColors.Info
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel4.Location = New System.Drawing.Point(0, 0)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(16, 48)
    Me.Panel4.TabIndex = 80
    '
    'Label7
    '
    Me.Label7.Location = New System.Drawing.Point(16, 28)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(40, 16)
    Me.Label7.TabIndex = 81
    Me.Label7.Text = "Hasta:"
    '
    'dtfeczaffin
    '
    Me.dtfeczaffin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dtfeczaffin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfeczaffin.Location = New System.Drawing.Point(56, 24)
    Me.dtfeczaffin.Name = "dtfeczaffin"
    Me.dtfeczaffin.Size = New System.Drawing.Size(123, 20)
    Me.dtfeczaffin.TabIndex = 82
    '
    'chkfechazafada
    '
    Me.chkfechazafada.BackColor = System.Drawing.SystemColors.Info
    Me.chkfechazafada.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkfechazafada.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkfechazafada.Location = New System.Drawing.Point(16, 0)
    Me.chkfechazafada.Name = "chkfechazafada"
    Me.chkfechazafada.Size = New System.Drawing.Size(181, 16)
    Me.chkfechazafada.TabIndex = 79
    Me.chkfechazafada.Text = "Por fecha de zafada"
    Me.chkfechazafada.UseVisualStyleBackColor = False
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
    'chksolotarjetaszafadas
    '
    Me.chksolotarjetaszafadas.Checked = True
    Me.chksolotarjetaszafadas.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chksolotarjetaszafadas.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolotarjetaszafadas.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolotarjetaszafadas.Location = New System.Drawing.Point(0, 531)
    Me.chksolotarjetaszafadas.Name = "chksolotarjetaszafadas"
    Me.chksolotarjetaszafadas.Size = New System.Drawing.Size(197, 14)
    Me.chksolotarjetaszafadas.TabIndex = 72
    Me.chksolotarjetaszafadas.Text = "Sólo tarjetas zafadas"
    Me.chksolotarjetaszafadas.ThreeState = True
    '
    'pnlnumeroembarque
    '
    Me.pnlnumeroembarque.Controls.Add(Me.txthasta)
    Me.pnlnumeroembarque.Controls.Add(Me.txtdesde)
    Me.pnlnumeroembarque.Controls.Add(Me.Label4)
    Me.pnlnumeroembarque.Controls.Add(Me.Panel6)
    Me.pnlnumeroembarque.Controls.Add(Me.Label5)
    Me.pnlnumeroembarque.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlnumeroembarque.Location = New System.Drawing.Point(0, 485)
    Me.pnlnumeroembarque.Name = "pnlnumeroembarque"
    Me.pnlnumeroembarque.Size = New System.Drawing.Size(197, 46)
    Me.pnlnumeroembarque.TabIndex = 80
    Me.pnlnumeroembarque.Visible = False
    '
    'txthasta
    '
    Me.txthasta.Location = New System.Drawing.Point(62, 24)
    Me.txthasta.Name = "txthasta"
    Me.txthasta.Size = New System.Drawing.Size(74, 20)
    Me.txthasta.TabIndex = 82
    Me.txthasta.Text = "0"
    Me.txthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthasta.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'txtdesde
    '
    Me.txtdesde.Location = New System.Drawing.Point(62, 1)
    Me.txtdesde.Name = "txtdesde"
    Me.txtdesde.Size = New System.Drawing.Size(74, 20)
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
    Me.Label5.Location = New System.Drawing.Point(16, 27)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(40, 16)
    Me.Label5.TabIndex = 81
    Me.Label5.Text = "Hasta:"
    '
    'chknumerozafada
    '
    Me.chknumerozafada.BackColor = System.Drawing.SystemColors.Info
    Me.chknumerozafada.Dock = System.Windows.Forms.DockStyle.Top
    Me.chknumerozafada.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chknumerozafada.Location = New System.Drawing.Point(0, 471)
    Me.chknumerozafada.Name = "chknumerozafada"
    Me.chknumerozafada.Size = New System.Drawing.Size(197, 14)
    Me.chknumerozafada.TabIndex = 79
    Me.chknumerozafada.Text = "Por número de tarjeta"
    Me.chknumerozafada.UseVisualStyleBackColor = False
    '
    'pnlsolocorte
    '
    Me.pnlsolocorte.Controls.Add(Me.CtlCorte1)
    Me.pnlsolocorte.Controls.Add(Me.Panel12)
    Me.pnlsolocorte.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolocorte.Location = New System.Drawing.Point(0, 447)
    Me.pnlsolocorte.Name = "pnlsolocorte"
    Me.pnlsolocorte.Size = New System.Drawing.Size(197, 24)
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
    Me.CtlCorte1.Size = New System.Drawing.Size(181, 21)
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
    Me.chksolocorte.Location = New System.Drawing.Point(0, 431)
    Me.chksolocorte.Name = "chksolocorte"
    Me.chksolocorte.Size = New System.Drawing.Size(197, 16)
    Me.chksolocorte.TabIndex = 65
    Me.chksolocorte.Text = "Sólo del corte"
    '
    'pnlsolosemilla
    '
    Me.pnlsolosemilla.Controls.Add(Me.CtlSemilla1)
    Me.pnlsolosemilla.Controls.Add(Me.Panel5)
    Me.pnlsolosemilla.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolosemilla.Location = New System.Drawing.Point(0, 407)
    Me.pnlsolosemilla.Name = "pnlsolosemilla"
    Me.pnlsolosemilla.Size = New System.Drawing.Size(197, 24)
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
    Me.CtlSemilla1.Size = New System.Drawing.Size(181, 21)
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
    Me.chksolosemilla.Location = New System.Drawing.Point(0, 394)
    Me.chksolosemilla.Name = "chksolosemilla"
    Me.chksolosemilla.Size = New System.Drawing.Size(197, 13)
    Me.chksolosemilla.TabIndex = 61
    Me.chksolosemilla.Text = "Sólo de la semilla"
    '
    'pnlsolohorno
    '
    Me.pnlsolohorno.Controls.Add(Me.CtlSeccionHorno1)
    Me.pnlsolohorno.Controls.Add(Me.Panel3)
    Me.pnlsolohorno.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsolohorno.Location = New System.Drawing.Point(0, 292)
    Me.pnlsolohorno.Name = "pnlsolohorno"
    Me.pnlsolohorno.Size = New System.Drawing.Size(197, 102)
    Me.pnlsolohorno.TabIndex = 58
    Me.pnlsolohorno.Visible = False
    '
    'CtlSeccionHorno1
    '
    Me.CtlSeccionHorno1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlSeccionHorno1.Location = New System.Drawing.Point(16, 0)
    Me.CtlSeccionHorno1.Name = "CtlSeccionHorno1"
    Me.CtlSeccionHorno1.Op = Nothing
    Me.CtlSeccionHorno1.SeccionHorno = Nothing
    Me.CtlSeccionHorno1.Size = New System.Drawing.Size(181, 102)
    Me.CtlSeccionHorno1.TabIndex = 1
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.SystemColors.Info
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(16, 102)
    Me.Panel3.TabIndex = 0
    '
    'chksolohornosec
    '
    Me.chksolohornosec.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolohornosec.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolohornosec.Location = New System.Drawing.Point(0, 277)
    Me.chksolohornosec.Name = "chksolohornosec"
    Me.chksolohornosec.Size = New System.Drawing.Size(197, 15)
    Me.chksolohornosec.TabIndex = 9
    Me.chksolohornosec.Text = "Sólo del horno/sección"
    '
    'pnlfechaensarte
    '
    Me.pnlfechaensarte.Controls.Add(Me.dtfecensfin)
    Me.pnlfechaensarte.Controls.Add(Me.Label44)
    Me.pnlfechaensarte.Controls.Add(Me.dtfecensini)
    Me.pnlfechaensarte.Controls.Add(Me.Label43)
    Me.pnlfechaensarte.Controls.Add(Me.Panel11)
    Me.pnlfechaensarte.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfechaensarte.Location = New System.Drawing.Point(0, 207)
    Me.pnlfechaensarte.Name = "pnlfechaensarte"
    Me.pnlfechaensarte.Size = New System.Drawing.Size(197, 70)
    Me.pnlfechaensarte.TabIndex = 52
    Me.pnlfechaensarte.Visible = False
    '
    'dtfecensfin
    '
    Me.dtfecensfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecensfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecensfin.Location = New System.Drawing.Point(16, 48)
    Me.dtfecensfin.Name = "dtfecensfin"
    Me.dtfecensfin.Size = New System.Drawing.Size(181, 20)
    Me.dtfecensfin.TabIndex = 4
    Me.dtfecensfin.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
    '
    'Label44
    '
    Me.Label44.BackColor = System.Drawing.SystemColors.Info
    Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label44.Location = New System.Drawing.Point(16, 32)
    Me.Label44.Name = "Label44"
    Me.Label44.Size = New System.Drawing.Size(181, 16)
    Me.Label44.TabIndex = 3
    Me.Label44.Text = "Hasta:"
    Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecensini
    '
    Me.dtfecensini.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecensini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecensini.Location = New System.Drawing.Point(16, 12)
    Me.dtfecensini.Name = "dtfecensini"
    Me.dtfecensini.Size = New System.Drawing.Size(181, 20)
    Me.dtfecensini.TabIndex = 2
    Me.dtfecensini.Value = New Date(2005, 3, 13, 20, 27, 9, 968)
    '
    'Label43
    '
    Me.Label43.BackColor = System.Drawing.SystemColors.Info
    Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label43.Location = New System.Drawing.Point(16, 0)
    Me.Label43.Name = "Label43"
    Me.Label43.Size = New System.Drawing.Size(181, 12)
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
    Me.Panel11.Size = New System.Drawing.Size(16, 70)
    Me.Panel11.TabIndex = 0
    '
    'chkfechaensarte
    '
    Me.chkfechaensarte.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkfechaensarte.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkfechaensarte.Location = New System.Drawing.Point(0, 193)
    Me.chkfechaensarte.Name = "chkfechaensarte"
    Me.chkfechaensarte.Size = New System.Drawing.Size(197, 14)
    Me.chkfechaensarte.TabIndex = 71
    Me.chkfechaensarte.Text = "Por fecha de ensarte"
    '
    'pnlsololote
    '
    Me.pnlsololote.Controls.Add(Me.CtlLote1)
    Me.pnlsololote.Controls.Add(Me.Panel2)
    Me.pnlsololote.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsololote.Location = New System.Drawing.Point(0, 123)
    Me.pnlsololote.Name = "pnlsololote"
    Me.pnlsololote.Size = New System.Drawing.Size(197, 70)
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
    Me.CtlLote1.Size = New System.Drawing.Size(181, 70)
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
    Me.chksololote.Location = New System.Drawing.Point(0, 109)
    Me.chksololote.Name = "chksololote"
    Me.chksololote.Size = New System.Drawing.Size(197, 14)
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
    Me.pnlsolofinca.Size = New System.Drawing.Size(197, 56)
    Me.pnlsolofinca.TabIndex = 70
    Me.pnlsolofinca.Visible = False
    '
    'CtlTerreno1
    '
    Me.CtlTerreno1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTerreno1.Location = New System.Drawing.Point(16, 0)
    Me.CtlTerreno1.Name = "CtlTerreno1"
    Me.CtlTerreno1.Op = Nothing
    Me.CtlTerreno1.Size = New System.Drawing.Size(181, 56)
    Me.CtlTerreno1.TabIndex = 1
    Me.CtlTerreno1.Terreno = Nothing
    '
    'Panel16
    '
    Me.Panel16.BackColor = System.Drawing.SystemColors.Info
    Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel16.Location = New System.Drawing.Point(0, 0)
    Me.Panel16.Name = "Panel16"
    Me.Panel16.Size = New System.Drawing.Size(16, 56)
    Me.Panel16.TabIndex = 0
    '
    'chksolofinca
    '
    Me.chksolofinca.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolofinca.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolofinca.Location = New System.Drawing.Point(0, 37)
    Me.chksolofinca.Name = "chksolofinca"
    Me.chksolofinca.Size = New System.Drawing.Size(197, 16)
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
    Me.CtlZafra1.Size = New System.Drawing.Size(197, 21)
    Me.CtlZafra1.TabIndex = 81
    Me.CtlZafra1.Zafra = Nothing
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(197, 16)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Zafra:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblstatus
    '
    Me.lblstatus.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblstatus.Location = New System.Drawing.Point(0, 769)
    Me.lblstatus.Name = "lblstatus"
    Me.lblstatus.Size = New System.Drawing.Size(197, 16)
    Me.lblstatus.TabIndex = 51
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
    'CtlBuscaTarjetaEnsZaf
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Info
    Me.Controls.Add(Me.tvtarjetas)
    Me.Controls.Add(Me.Panel7)
    Me.Controls.Add(Me.pnlbusqtarj)
    Me.Controls.Add(Me.lblstatus)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlBuscaTarjetaEnsZaf"
    Me.Size = New System.Drawing.Size(197, 785)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.Panel7.ResumeLayout(False)
    Me.pnlbusqtarj.ResumeLayout(False)
    Me.pnlsolotarjetaszafadas.ResumeLayout(False)
    Me.pnlfechazafada.ResumeLayout(False)
    Me.pnlnumeroembarque.ResumeLayout(False)
    Me.pnlnumeroembarque.PerformLayout()
    Me.pnlsolocorte.ResumeLayout(False)
    Me.pnlsolosemilla.ResumeLayout(False)
    Me.pnlsolohorno.ResumeLayout(False)
    Me.pnlfechaensarte.ResumeLayout(False)
    Me.pnlsololote.ResumeLayout(False)
    Me.pnlsolofinca.ResumeLayout(False)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents tvtarjetas As System.Windows.Forms.TreeView
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Friend WithEvents btnbuscar As System.Windows.Forms.Button
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents pnlbusqtarj As System.Windows.Forms.Panel
  Friend WithEvents pnlfin As System.Windows.Forms.Panel
  Friend WithEvents pnlsolotarjetaszafadas As System.Windows.Forms.Panel
  Friend WithEvents pnlfinzafada As System.Windows.Forms.Panel
  Friend WithEvents pnlfechazafada As System.Windows.Forms.Panel
  Friend WithEvents dtfeczafini As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents dtfeczaffin As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkfechazafada As System.Windows.Forms.CheckBox
  Friend WithEvents Panel19 As System.Windows.Forms.Panel
  Friend WithEvents chksolotarjetaszafadas As System.Windows.Forms.CheckBox
  Friend WithEvents pnlnumeroembarque As System.Windows.Forms.Panel
  Friend WithEvents txthasta As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtdesde As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents chknumerozafada As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolocorte As System.Windows.Forms.Panel
  Friend WithEvents CtlCorte1 As WWTS.Siembra.Modulo.CtlCorte
  Friend WithEvents Panel12 As System.Windows.Forms.Panel
  Friend WithEvents chksolocorte As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolosemilla As System.Windows.Forms.Panel
  Friend WithEvents CtlSemilla1 As WWTS.Siembra.Modulo.CtlSemilla
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents chksolosemilla As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolohorno As System.Windows.Forms.Panel
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents chksolohornosec As System.Windows.Forms.CheckBox
  Friend WithEvents pnlfechaensarte As System.Windows.Forms.Panel
  Friend WithEvents dtfecensfin As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents dtfecensini As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents Panel11 As System.Windows.Forms.Panel
  Friend WithEvents chkfechaensarte As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsololote As System.Windows.Forms.Panel
  Friend WithEvents CtlLote1 As WWTS.Siembra.Modulo.CtlLote
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents chksololote As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsolofinca As System.Windows.Forms.Panel
  Friend WithEvents CtlTerreno1 As WWTS.Siembra.Modulo.CtlTerreno
  Friend WithEvents Panel16 As System.Windows.Forms.Panel
  Friend WithEvents chksolofinca As System.Windows.Forms.CheckBox
  Friend WithEvents CtlZafra1 As WWTS.Siembra.Modulo.CtlZafra
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblstatus As System.Windows.Forms.Label
  Friend WithEvents CtlSeccionHorno1 As WWTS.Siembra.Modulo.CtlSeccionHorno
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents SeleccionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu25 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu50 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu100 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu250 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu500 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu1000 As System.Windows.Forms.ToolStripMenuItem

End Class
