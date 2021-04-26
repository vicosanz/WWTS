<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaEmpleados
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
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.rdopersactfecing = New System.Windows.Forms.RadioButton()
    Me.pnlpersactsec = New System.Windows.Forms.Panel()
    Me.CtlSeccion1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.rdopersactsec = New System.Windows.Forms.RadioButton()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.chkincsueldos = New System.Windows.Forms.CheckBox()
    Me.chktodos = New System.Windows.Forms.CheckBox()
    Me.btnbuscar = New Infoware.Controles.Base.ButtonStd()
    Me.btnexportar = New Infoware.Controles.Base.ButtonStd()
    Me.Label42 = New System.Windows.Forms.Label()
    Me.tvEmpleados = New System.Windows.Forms.DataGridView()
    Me.mnuimpresion = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuimpcont = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuimpetiq = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnudocfalta = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnurepasis = New System.Windows.Forms.ToolStripMenuItem()
    Me.ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.pnlresumen = New System.Windows.Forms.Panel()
    Me.lnkresumen = New System.Windows.Forms.LinkLabel()
    Me.rdopersactfecsal = New System.Windows.Forms.RadioButton()
    Me.Label44 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label43 = New System.Windows.Forms.Label()
    Me.pnlpersactfecing = New System.Windows.Forms.Panel()
    Me.lblstatus = New System.Windows.Forms.Label()
    Me.pnlbusqueda = New System.Windows.Forms.Panel()
    Me.pnlpersinac = New System.Windows.Forms.Panel()
    Me.pnlanioactivo = New System.Windows.Forms.Panel()
    Me.numanioact = New System.Windows.Forms.NumericUpDown()
    Me.chkanioactivo = New System.Windows.Forms.CheckBox()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.numanioinac = New System.Windows.Forms.NumericUpDown()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.rdopersinac = New System.Windows.Forms.RadioButton()
    Me.pnlpersac = New System.Windows.Forms.Panel()
    Me.chkDiscapacidad = New System.Windows.Forms.CheckBox()
    Me.pnlpersentreedad = New System.Windows.Forms.Panel()
    Me.txtedadf = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtedadi = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chkpersentreedad = New System.Windows.Forms.CheckBox()
    Me.pnlsoloPatrono = New System.Windows.Forms.Panel()
    Me.CtlTipoContrato1 = New WWTS.Roles.Controles.CtlTipoContrato()
    Me.chkSoloContrato = New System.Windows.Forms.CheckBox()
    Me.pnlsoloclase = New System.Windows.Forms.Panel()
    Me.ComboBoxClase1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.chksoloclase = New System.Windows.Forms.CheckBox()
    Me.rdopersacttodos = New System.Windows.Forms.RadioButton()
    Me.pnlpersactfecsal = New System.Windows.Forms.Panel()
    Me.dtfechastasal = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtfecdesdesal = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.CtlPatrono1 = New WWTS.Roles.Controles.CtlPatrono()
    Me.dtfecactivo = New System.Windows.Forms.DateTimePicker()
    Me.Label45 = New System.Windows.Forms.Label()
    Me.rdopersact = New System.Windows.Forms.RadioButton()
    Me.pnldescparc = New System.Windows.Forms.Panel()
    Me.txtedad = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chkficharoja = New System.Windows.Forms.CheckBox()
    Me.cbomayorque = New System.Windows.Forms.ComboBox()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtcedula = New Infoware.Controles.Base.TextBoxStd()
    Me.Label38 = New System.Windows.Forms.Label()
    Me.Label39 = New System.Windows.Forms.Label()
    Me.Label41 = New System.Windows.Forms.Label()
    Me.Label37 = New System.Windows.Forms.Label()
    Me.txtnombre = New Infoware.Controles.Base.TextBoxStd()
    Me.Label49 = New System.Windows.Forms.Label()
    Me.rdodescparc = New System.Windows.Forms.RadioButton()
    Me.HeaderStrip2.SuspendLayout()
    Me.pnlpersactsec.SuspendLayout()
    Me.Panel7.SuspendLayout()
    CType(Me.tvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.mnuimpresion.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlresumen.SuspendLayout()
    Me.pnlpersactfecing.SuspendLayout()
    Me.pnlbusqueda.SuspendLayout()
    Me.pnlpersinac.SuspendLayout()
    Me.pnlanioactivo.SuspendLayout()
    CType(Me.numanioact, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel4.SuspendLayout()
    CType(Me.numanioinac, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlpersac.SuspendLayout()
    Me.pnlpersentreedad.SuspendLayout()
    Me.pnlsoloPatrono.SuspendLayout()
    Me.pnlsoloclase.SuspendLayout()
    Me.pnlpersactfecsal.SuspendLayout()
    Me.pnldescparc.SuspendLayout()
    Me.SuspendLayout()
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(264, 26)
    Me.HeaderStrip2.TabIndex = 0
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(173, 23)
    Me.ToolStripLabel2.Text = "Búsqueda de Empleados"
    '
    'rdopersactfecing
    '
    Me.rdopersactfecing.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersactfecing.Location = New System.Drawing.Point(20, 191)
    Me.rdopersactfecing.Margin = New System.Windows.Forms.Padding(4)
    Me.rdopersactfecing.Name = "rdopersactfecing"
    Me.rdopersactfecing.Size = New System.Drawing.Size(238, 22)
    Me.rdopersactfecing.TabIndex = 6
    Me.rdopersactfecing.Text = "Por fecha de ingreso"
    '
    'pnlpersactsec
    '
    Me.pnlpersactsec.Controls.Add(Me.CtlSeccion1)
    Me.pnlpersactsec.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersactsec.Location = New System.Drawing.Point(20, 163)
    Me.pnlpersactsec.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlpersactsec.Name = "pnlpersactsec"
    Me.pnlpersactsec.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlpersactsec.Size = New System.Drawing.Size(238, 28)
    Me.pnlpersactsec.TabIndex = 5
    '
    'CtlSeccion1
    '
    Me.CtlSeccion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlSeccion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSeccion1.FormattingEnabled = True
    Me.CtlSeccion1.Location = New System.Drawing.Point(20, 0)
    Me.CtlSeccion1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlSeccion1.Name = "CtlSeccion1"
    Me.CtlSeccion1.OperadorDatos = Nothing
    Me.CtlSeccion1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlSeccion1.ParametroDet = Nothing
    Me.CtlSeccion1.PuedeActualizar = True
    Me.CtlSeccion1.PuedeEliminar = True
    Me.CtlSeccion1.PuedeModificar = True
    Me.CtlSeccion1.PuedeNuevo = True
    Me.CtlSeccion1.Size = New System.Drawing.Size(218, 24)
    Me.CtlSeccion1.TabIndex = 0
    '
    'rdopersactsec
    '
    Me.rdopersactsec.Checked = True
    Me.rdopersactsec.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersactsec.Location = New System.Drawing.Point(20, 143)
    Me.rdopersactsec.Margin = New System.Windows.Forms.Padding(4)
    Me.rdopersactsec.Name = "rdopersactsec"
    Me.rdopersactsec.Size = New System.Drawing.Size(238, 20)
    Me.rdopersactsec.TabIndex = 4
    Me.rdopersactsec.TabStop = True
    Me.rdopersactsec.Text = "Por sección"
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.chkincsueldos)
    Me.Panel7.Controls.Add(Me.chktodos)
    Me.Panel7.Controls.Add(Me.btnbuscar)
    Me.Panel7.Controls.Add(Me.btnexportar)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 1123)
    Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.Panel7.Size = New System.Drawing.Size(264, 63)
    Me.Panel7.TabIndex = 50
    '
    'chkincsueldos
    '
    Me.chkincsueldos.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkincsueldos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkincsueldos.Location = New System.Drawing.Point(3, 2)
    Me.chkincsueldos.Margin = New System.Windows.Forms.Padding(4)
    Me.chkincsueldos.Name = "chkincsueldos"
    Me.chkincsueldos.Size = New System.Drawing.Size(258, 22)
    Me.chkincsueldos.TabIndex = 13
    Me.chkincsueldos.Text = "Incluir información de sueldos"
    '
    'chktodos
    '
    Me.chktodos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chktodos.Location = New System.Drawing.Point(8, 39)
    Me.chktodos.Margin = New System.Windows.Forms.Padding(4)
    Me.chktodos.Name = "chktodos"
    Me.chktodos.Size = New System.Drawing.Size(16, 22)
    Me.chktodos.TabIndex = 3
    '
    'btnbuscar
    '
    Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnbuscar.Location = New System.Drawing.Point(32, 30)
    Me.btnbuscar.Margin = New System.Windows.Forms.Padding(4)
    Me.btnbuscar.Name = "btnbuscar"
    Me.btnbuscar.Size = New System.Drawing.Size(120, 23)
    Me.btnbuscar.TabIndex = 0
    Me.btnbuscar.Text = "&Buscar"
    '
    'btnexportar
    '
    Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnexportar.Location = New System.Drawing.Point(139, 30)
    Me.btnexportar.Margin = New System.Windows.Forms.Padding(4)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(120, 23)
    Me.btnexportar.TabIndex = 2
    Me.btnexportar.Text = "&Exportar"
    '
    'Label42
    '
    Me.Label42.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label42.Location = New System.Drawing.Point(20, 42)
    Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label42.Name = "Label42"
    Me.Label42.Size = New System.Drawing.Size(238, 22)
    Me.Label42.TabIndex = 2
    Me.Label42.Text = "Patrono:"
    Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'tvEmpleados
    '
    Me.tvEmpleados.AllowUserToAddRows = False
    Me.tvEmpleados.AllowUserToDeleteRows = False
    Me.tvEmpleados.AllowUserToResizeRows = False
    Me.tvEmpleados.AutoGenerateColumns = False
    Me.tvEmpleados.ColumnHeadersHeight = 29
    Me.tvEmpleados.ContextMenuStrip = Me.mnuimpresion
    Me.tvEmpleados.DataSource = Me.ListBindingSource
    Me.tvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvEmpleados.Location = New System.Drawing.Point(0, 1186)
    Me.tvEmpleados.Margin = New System.Windows.Forms.Padding(4)
    Me.tvEmpleados.MultiSelect = False
    Me.tvEmpleados.Name = "tvEmpleados"
    Me.tvEmpleados.RowHeadersVisible = False
    Me.tvEmpleados.RowHeadersWidth = 51
    Me.tvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.tvEmpleados.Size = New System.Drawing.Size(264, 140)
    Me.tvEmpleados.TabIndex = 49
    '
    'mnuimpresion
    '
    Me.mnuimpresion.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.mnuimpresion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuimpcont, Me.mnuimpetiq, Me.mnudocfalta, Me.mnurepasis})
    Me.mnuimpresion.Name = "mnuimpresion"
    Me.mnuimpresion.Size = New System.Drawing.Size(261, 100)
    '
    'mnuimpcont
    '
    Me.mnuimpcont.Enabled = False
    Me.mnuimpcont.Name = "mnuimpcont"
    Me.mnuimpcont.Size = New System.Drawing.Size(260, 24)
    Me.mnuimpcont.Text = "&Imprimir contratos"
    '
    'mnuimpetiq
    '
    Me.mnuimpetiq.Enabled = False
    Me.mnuimpetiq.Name = "mnuimpetiq"
    Me.mnuimpetiq.Size = New System.Drawing.Size(260, 24)
    Me.mnuimpetiq.Text = "&Imprimir etiquetas"
    '
    'mnudocfalta
    '
    Me.mnudocfalta.Enabled = False
    Me.mnudocfalta.Name = "mnudocfalta"
    Me.mnudocfalta.Size = New System.Drawing.Size(260, 24)
    Me.mnudocfalta.Text = "&Listar documentos faltantes"
    '
    'mnurepasis
    '
    Me.mnurepasis.Enabled = False
    Me.mnurepasis.Name = "mnurepasis"
    Me.mnurepasis.Size = New System.Drawing.Size(260, 24)
    Me.mnurepasis.Text = "&Reporte toma de asistencia"
    '
    'ListBindingSource
    '
    '
    'dtfechasta
    '
    Me.dtfechasta.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(20, 57)
    Me.dtfechasta.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(218, 22)
    Me.dtfechasta.TabIndex = 3
    Me.dtfechasta.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
    '
    'pnlresumen
    '
    Me.pnlresumen.Controls.Add(Me.lnkresumen)
    Me.pnlresumen.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlresumen.Location = New System.Drawing.Point(0, 1000)
    Me.pnlresumen.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlresumen.Name = "pnlresumen"
    Me.pnlresumen.Size = New System.Drawing.Size(264, 123)
    Me.pnlresumen.TabIndex = 52
    Me.pnlresumen.Visible = False
    '
    'lnkresumen
    '
    Me.lnkresumen.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lnkresumen.Location = New System.Drawing.Point(0, 0)
    Me.lnkresumen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lnkresumen.Name = "lnkresumen"
    Me.lnkresumen.Size = New System.Drawing.Size(264, 123)
    Me.lnkresumen.TabIndex = 0
    Me.lnkresumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'rdopersactfecsal
    '
    Me.rdopersactfecsal.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersactfecsal.Location = New System.Drawing.Point(20, 300)
    Me.rdopersactfecsal.Margin = New System.Windows.Forms.Padding(4)
    Me.rdopersactfecsal.Name = "rdopersactfecsal"
    Me.rdopersactfecsal.Size = New System.Drawing.Size(238, 22)
    Me.rdopersactfecsal.TabIndex = 8
    Me.rdopersactfecsal.Text = "Por fecha de salida"
    '
    'Label44
    '
    Me.Label44.BackColor = System.Drawing.SystemColors.Info
    Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label44.Location = New System.Drawing.Point(20, 37)
    Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label44.Name = "Label44"
    Me.Label44.Size = New System.Drawing.Size(218, 20)
    Me.Label44.TabIndex = 2
    Me.Label44.Text = "Hasta:"
    Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(20, 15)
    Me.dtfecdesde.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(218, 22)
    Me.dtfecdesde.TabIndex = 1
    Me.dtfecdesde.Value = New Date(2005, 3, 13, 20, 27, 9, 968)
    '
    'Label43
    '
    Me.Label43.BackColor = System.Drawing.SystemColors.Info
    Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label43.Location = New System.Drawing.Point(20, 0)
    Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label43.Name = "Label43"
    Me.Label43.Size = New System.Drawing.Size(218, 15)
    Me.Label43.TabIndex = 0
    Me.Label43.Text = "Desde:"
    Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlpersactfecing
    '
    Me.pnlpersactfecing.Controls.Add(Me.dtfechasta)
    Me.pnlpersactfecing.Controls.Add(Me.Label44)
    Me.pnlpersactfecing.Controls.Add(Me.dtfecdesde)
    Me.pnlpersactfecing.Controls.Add(Me.Label43)
    Me.pnlpersactfecing.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersactfecing.Location = New System.Drawing.Point(20, 213)
    Me.pnlpersactfecing.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlpersactfecing.Name = "pnlpersactfecing"
    Me.pnlpersactfecing.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlpersactfecing.Size = New System.Drawing.Size(238, 87)
    Me.pnlpersactfecing.TabIndex = 7
    Me.pnlpersactfecing.Visible = False
    '
    'lblstatus
    '
    Me.lblstatus.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblstatus.Location = New System.Drawing.Point(0, 1326)
    Me.lblstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblstatus.Name = "lblstatus"
    Me.lblstatus.Size = New System.Drawing.Size(264, 20)
    Me.lblstatus.TabIndex = 51
    '
    'pnlbusqueda
    '
    Me.pnlbusqueda.Controls.Add(Me.pnlpersinac)
    Me.pnlbusqueda.Controls.Add(Me.rdopersinac)
    Me.pnlbusqueda.Controls.Add(Me.pnlpersac)
    Me.pnlbusqueda.Controls.Add(Me.rdopersact)
    Me.pnlbusqueda.Controls.Add(Me.pnldescparc)
    Me.pnlbusqueda.Controls.Add(Me.rdodescparc)
    Me.pnlbusqueda.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlbusqueda.Location = New System.Drawing.Point(0, 26)
    Me.pnlbusqueda.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlbusqueda.Name = "pnlbusqueda"
    Me.pnlbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.pnlbusqueda.Size = New System.Drawing.Size(264, 974)
    Me.pnlbusqueda.TabIndex = 53
    '
    'pnlpersinac
    '
    Me.pnlpersinac.Controls.Add(Me.pnlanioactivo)
    Me.pnlpersinac.Controls.Add(Me.chkanioactivo)
    Me.pnlpersinac.Controls.Add(Me.Panel4)
    Me.pnlpersinac.Controls.Add(Me.Label3)
    Me.pnlpersinac.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersinac.Location = New System.Drawing.Point(3, 857)
    Me.pnlpersinac.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlpersinac.Name = "pnlpersinac"
    Me.pnlpersinac.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlpersinac.Size = New System.Drawing.Size(258, 103)
    Me.pnlpersinac.TabIndex = 5
    Me.pnlpersinac.Visible = False
    '
    'pnlanioactivo
    '
    Me.pnlanioactivo.Controls.Add(Me.numanioact)
    Me.pnlanioactivo.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlanioactivo.Location = New System.Drawing.Point(20, 69)
    Me.pnlanioactivo.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlanioactivo.Name = "pnlanioactivo"
    Me.pnlanioactivo.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlanioactivo.Size = New System.Drawing.Size(238, 28)
    Me.pnlanioactivo.TabIndex = 1
    Me.pnlanioactivo.Visible = False
    '
    'numanioact
    '
    Me.numanioact.Location = New System.Drawing.Point(21, 4)
    Me.numanioact.Margin = New System.Windows.Forms.Padding(4)
    Me.numanioact.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
    Me.numanioact.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
    Me.numanioact.Name = "numanioact"
    Me.numanioact.Size = New System.Drawing.Size(87, 22)
    Me.numanioact.TabIndex = 0
    Me.numanioact.Value = New Decimal(New Integer() {1900, 0, 0, 0})
    '
    'chkanioactivo
    '
    Me.chkanioactivo.AutoSize = True
    Me.chkanioactivo.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkanioactivo.Location = New System.Drawing.Point(20, 48)
    Me.chkanioactivo.Margin = New System.Windows.Forms.Padding(4)
    Me.chkanioactivo.Name = "chkanioactivo"
    Me.chkanioactivo.Size = New System.Drawing.Size(238, 21)
    Me.chkanioactivo.TabIndex = 0
    Me.chkanioactivo.Text = "que estuvo activo en el año"
    Me.chkanioactivo.UseVisualStyleBackColor = True
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.numanioinac)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel4.Location = New System.Drawing.Point(20, 20)
    Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.Panel4.Size = New System.Drawing.Size(238, 28)
    Me.Panel4.TabIndex = 1
    '
    'numanioinac
    '
    Me.numanioinac.Location = New System.Drawing.Point(21, 4)
    Me.numanioinac.Margin = New System.Windows.Forms.Padding(4)
    Me.numanioinac.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
    Me.numanioinac.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
    Me.numanioinac.Name = "numanioinac"
    Me.numanioinac.Size = New System.Drawing.Size(87, 22)
    Me.numanioinac.TabIndex = 0
    Me.numanioinac.Value = New Decimal(New Integer() {1900, 0, 0, 0})
    '
    'Label3
    '
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label3.Location = New System.Drawing.Point(20, 0)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(238, 20)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Inactivo en el año:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'rdopersinac
    '
    Me.rdopersinac.AutoSize = True
    Me.rdopersinac.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersinac.Location = New System.Drawing.Point(3, 836)
    Me.rdopersinac.Margin = New System.Windows.Forms.Padding(4)
    Me.rdopersinac.Name = "rdopersinac"
    Me.rdopersinac.Size = New System.Drawing.Size(258, 21)
    Me.rdopersinac.TabIndex = 4
    Me.rdopersinac.Text = "Empleados inactivos"
    Me.rdopersinac.UseVisualStyleBackColor = True
    '
    'pnlpersac
    '
    Me.pnlpersac.Controls.Add(Me.chkDiscapacidad)
    Me.pnlpersac.Controls.Add(Me.pnlpersentreedad)
    Me.pnlpersac.Controls.Add(Me.chkpersentreedad)
    Me.pnlpersac.Controls.Add(Me.pnlsoloPatrono)
    Me.pnlpersac.Controls.Add(Me.chkSoloContrato)
    Me.pnlpersac.Controls.Add(Me.pnlsoloclase)
    Me.pnlpersac.Controls.Add(Me.chksoloclase)
    Me.pnlpersac.Controls.Add(Me.rdopersacttodos)
    Me.pnlpersac.Controls.Add(Me.pnlpersactfecsal)
    Me.pnlpersac.Controls.Add(Me.rdopersactfecsal)
    Me.pnlpersac.Controls.Add(Me.pnlpersactfecing)
    Me.pnlpersac.Controls.Add(Me.rdopersactfecing)
    Me.pnlpersac.Controls.Add(Me.pnlpersactsec)
    Me.pnlpersac.Controls.Add(Me.rdopersactsec)
    Me.pnlpersac.Controls.Add(Me.CtlPatrono1)
    Me.pnlpersac.Controls.Add(Me.Label42)
    Me.pnlpersac.Controls.Add(Me.dtfecactivo)
    Me.pnlpersac.Controls.Add(Me.Label45)
    Me.pnlpersac.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersac.Location = New System.Drawing.Point(3, 222)
    Me.pnlpersac.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlpersac.Name = "pnlpersac"
    Me.pnlpersac.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlpersac.Size = New System.Drawing.Size(258, 614)
    Me.pnlpersac.TabIndex = 3
    '
    'chkDiscapacidad
    '
    Me.chkDiscapacidad.Checked = True
    Me.chkDiscapacidad.CheckState = System.Windows.Forms.CheckState.Indeterminate
    Me.chkDiscapacidad.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkDiscapacidad.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkDiscapacidad.Location = New System.Drawing.Point(20, 588)
    Me.chkDiscapacidad.Margin = New System.Windows.Forms.Padding(4)
    Me.chkDiscapacidad.Name = "chkDiscapacidad"
    Me.chkDiscapacidad.Size = New System.Drawing.Size(238, 22)
    Me.chkDiscapacidad.TabIndex = 14
    Me.chkDiscapacidad.Text = "No tomar en cuenta discapacidad"
    Me.chkDiscapacidad.ThreeState = True
    '
    'pnlpersentreedad
    '
    Me.pnlpersentreedad.Controls.Add(Me.txtedadf)
    Me.pnlpersentreedad.Controls.Add(Me.txtedadi)
    Me.pnlpersentreedad.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersentreedad.Location = New System.Drawing.Point(20, 558)
    Me.pnlpersentreedad.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlpersentreedad.Name = "pnlpersentreedad"
    Me.pnlpersentreedad.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlpersentreedad.Size = New System.Drawing.Size(238, 30)
    Me.pnlpersentreedad.TabIndex = 16
    Me.pnlpersentreedad.Visible = False
    '
    'txtedadf
    '
    Me.txtedadf.Location = New System.Drawing.Point(115, 4)
    Me.txtedadf.Margin = New System.Windows.Forms.Padding(4)
    Me.txtedadf.Mensaje = ""
    Me.txtedadf.Name = "txtedadf"
    Me.txtedadf.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtedadf.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtedadf.PromptText = ""
    Me.txtedadf.Size = New System.Drawing.Size(65, 22)
    Me.txtedadf.TabIndex = 1
    Me.txtedadf.Text = "0"
    Me.txtedadf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtedadf.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtedadf.Value = 0R
    '
    'txtedadi
    '
    Me.txtedadi.Location = New System.Drawing.Point(21, 4)
    Me.txtedadi.Margin = New System.Windows.Forms.Padding(4)
    Me.txtedadi.Mensaje = ""
    Me.txtedadi.Name = "txtedadi"
    Me.txtedadi.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtedadi.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtedadi.PromptText = ""
    Me.txtedadi.Size = New System.Drawing.Size(65, 22)
    Me.txtedadi.TabIndex = 0
    Me.txtedadi.Text = "0"
    Me.txtedadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtedadi.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtedadi.Value = 0R
    '
    'chkpersentreedad
    '
    Me.chkpersentreedad.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkpersentreedad.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkpersentreedad.Location = New System.Drawing.Point(20, 536)
    Me.chkpersentreedad.Margin = New System.Windows.Forms.Padding(4)
    Me.chkpersentreedad.Name = "chkpersentreedad"
    Me.chkpersentreedad.Size = New System.Drawing.Size(238, 22)
    Me.chkpersentreedad.TabIndex = 15
    Me.chkpersentreedad.Text = "Empleados con edades entre"
    '
    'pnlsoloPatrono
    '
    Me.pnlsoloPatrono.BackColor = System.Drawing.SystemColors.Info
    Me.pnlsoloPatrono.Controls.Add(Me.CtlTipoContrato1)
    Me.pnlsoloPatrono.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsoloPatrono.Location = New System.Drawing.Point(20, 504)
    Me.pnlsoloPatrono.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlsoloPatrono.Name = "pnlsoloPatrono"
    Me.pnlsoloPatrono.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlsoloPatrono.Size = New System.Drawing.Size(238, 32)
    Me.pnlsoloPatrono.TabIndex = 14
    Me.pnlsoloPatrono.Visible = False
    '
    'CtlTipoContrato1
    '
    Me.CtlTipoContrato1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTipoContrato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlTipoContrato1.FormattingEnabled = True
    Me.CtlTipoContrato1.Location = New System.Drawing.Point(20, 0)
    Me.CtlTipoContrato1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlTipoContrato1.Name = "CtlTipoContrato1"
    Me.CtlTipoContrato1.Op = Nothing
    Me.CtlTipoContrato1.Patrono = Nothing
    Me.CtlTipoContrato1.PuedeActualizar = True
    Me.CtlTipoContrato1.PuedeEliminar = True
    Me.CtlTipoContrato1.PuedeModificar = True
    Me.CtlTipoContrato1.PuedeNuevo = True
    Me.CtlTipoContrato1.Size = New System.Drawing.Size(218, 24)
    Me.CtlTipoContrato1.TabIndex = 0
    Me.CtlTipoContrato1.TipoContrato = Nothing
    '
    'chkSoloContrato
    '
    Me.chkSoloContrato.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkSoloContrato.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkSoloContrato.Location = New System.Drawing.Point(20, 482)
    Me.chkSoloContrato.Margin = New System.Windows.Forms.Padding(4)
    Me.chkSoloContrato.Name = "chkSoloContrato"
    Me.chkSoloContrato.Size = New System.Drawing.Size(238, 22)
    Me.chkSoloContrato.TabIndex = 13
    Me.chkSoloContrato.Text = "Sólo este tipo de contrato"
    '
    'pnlsoloclase
    '
    Me.pnlsoloclase.Controls.Add(Me.ComboBoxClase1)
    Me.pnlsoloclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsoloclase.Location = New System.Drawing.Point(20, 452)
    Me.pnlsoloclase.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlsoloclase.Name = "pnlsoloclase"
    Me.pnlsoloclase.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlsoloclase.Size = New System.Drawing.Size(238, 30)
    Me.pnlsoloclase.TabIndex = 12
    Me.pnlsoloclase.Visible = False
    '
    'ComboBoxClase1
    '
    Me.ComboBoxClase1.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBoxClase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxClase1.FormattingEnabled = True
    Me.ComboBoxClase1.Location = New System.Drawing.Point(20, 0)
    Me.ComboBoxClase1.Margin = New System.Windows.Forms.Padding(4)
    Me.ComboBoxClase1.Name = "ComboBoxClase1"
    Me.ComboBoxClase1.OperadorDatos = Nothing
    Me.ComboBoxClase1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxClase1.ParametroDet = Nothing
    Me.ComboBoxClase1.PuedeActualizar = True
    Me.ComboBoxClase1.PuedeEliminar = True
    Me.ComboBoxClase1.PuedeModificar = True
    Me.ComboBoxClase1.PuedeNuevo = True
    Me.ComboBoxClase1.Size = New System.Drawing.Size(218, 24)
    Me.ComboBoxClase1.TabIndex = 0
    '
    'chksoloclase
    '
    Me.chksoloclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksoloclase.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksoloclase.Location = New System.Drawing.Point(20, 430)
    Me.chksoloclase.Margin = New System.Windows.Forms.Padding(4)
    Me.chksoloclase.Name = "chksoloclase"
    Me.chksoloclase.Size = New System.Drawing.Size(238, 22)
    Me.chksoloclase.TabIndex = 11
    Me.chksoloclase.Text = "Sólo de la clase"
    '
    'rdopersacttodos
    '
    Me.rdopersacttodos.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersacttodos.Location = New System.Drawing.Point(20, 408)
    Me.rdopersacttodos.Margin = New System.Windows.Forms.Padding(4)
    Me.rdopersacttodos.Name = "rdopersacttodos"
    Me.rdopersacttodos.Size = New System.Drawing.Size(238, 22)
    Me.rdopersacttodos.TabIndex = 10
    Me.rdopersacttodos.Text = "Todos"
    '
    'pnlpersactfecsal
    '
    Me.pnlpersactfecsal.Controls.Add(Me.dtfechastasal)
    Me.pnlpersactfecsal.Controls.Add(Me.Label1)
    Me.pnlpersactfecsal.Controls.Add(Me.dtfecdesdesal)
    Me.pnlpersactfecsal.Controls.Add(Me.Label2)
    Me.pnlpersactfecsal.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersactfecsal.Location = New System.Drawing.Point(20, 322)
    Me.pnlpersactfecsal.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlpersactfecsal.Name = "pnlpersactfecsal"
    Me.pnlpersactfecsal.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlpersactfecsal.Size = New System.Drawing.Size(238, 86)
    Me.pnlpersactfecsal.TabIndex = 9
    Me.pnlpersactfecsal.Visible = False
    '
    'dtfechastasal
    '
    Me.dtfechastasal.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfechastasal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechastasal.Location = New System.Drawing.Point(20, 57)
    Me.dtfechastasal.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfechastasal.Name = "dtfechastasal"
    Me.dtfechastasal.Size = New System.Drawing.Size(218, 22)
    Me.dtfechastasal.TabIndex = 3
    Me.dtfechastasal.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.Info
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(20, 37)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(218, 20)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Hasta:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecdesdesal
    '
    Me.dtfecdesdesal.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecdesdesal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesdesal.Location = New System.Drawing.Point(20, 15)
    Me.dtfecdesdesal.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfecdesdesal.Name = "dtfecdesdesal"
    Me.dtfecdesdesal.Size = New System.Drawing.Size(218, 22)
    Me.dtfecdesdesal.TabIndex = 1
    Me.dtfecdesdesal.Value = New Date(2005, 3, 13, 20, 27, 9, 968)
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.SystemColors.Info
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.Location = New System.Drawing.Point(20, 0)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(218, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Desde:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CtlPatrono1
    '
    Me.CtlPatrono1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlPatrono1.Location = New System.Drawing.Point(20, 64)
    Me.CtlPatrono1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlPatrono1.Name = "CtlPatrono1"
    Me.CtlPatrono1.Op = Nothing
    Me.CtlPatrono1.Patrono = Nothing
    Me.CtlPatrono1.Size = New System.Drawing.Size(238, 79)
    Me.CtlPatrono1.TabIndex = 3
    Me.CtlPatrono1.Usuario = Nothing
    '
    'dtfecactivo
    '
    Me.dtfecactivo.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecactivo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecactivo.Location = New System.Drawing.Point(20, 20)
    Me.dtfecactivo.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfecactivo.Name = "dtfecactivo"
    Me.dtfecactivo.Size = New System.Drawing.Size(238, 22)
    Me.dtfecactivo.TabIndex = 1
    '
    'Label45
    '
    Me.Label45.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label45.Location = New System.Drawing.Point(20, 0)
    Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label45.Name = "Label45"
    Me.Label45.Size = New System.Drawing.Size(238, 20)
    Me.Label45.TabIndex = 0
    Me.Label45.Text = "Activo a la fecha:"
    Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'rdopersact
    '
    Me.rdopersact.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersact.Location = New System.Drawing.Point(3, 200)
    Me.rdopersact.Margin = New System.Windows.Forms.Padding(4)
    Me.rdopersact.Name = "rdopersact"
    Me.rdopersact.Size = New System.Drawing.Size(258, 22)
    Me.rdopersact.TabIndex = 2
    Me.rdopersact.Text = "Empleados con contrato activo"
    '
    'pnldescparc
    '
    Me.pnldescparc.Controls.Add(Me.txtedad)
    Me.pnldescparc.Controls.Add(Me.chkficharoja)
    Me.pnldescparc.Controls.Add(Me.cbomayorque)
    Me.pnldescparc.Controls.Add(Me.txtcodigo)
    Me.pnldescparc.Controls.Add(Me.txtcedula)
    Me.pnldescparc.Controls.Add(Me.Label38)
    Me.pnldescparc.Controls.Add(Me.Label39)
    Me.pnldescparc.Controls.Add(Me.Label41)
    Me.pnldescparc.Controls.Add(Me.Label37)
    Me.pnldescparc.Controls.Add(Me.txtnombre)
    Me.pnldescparc.Controls.Add(Me.Label49)
    Me.pnldescparc.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldescparc.Location = New System.Drawing.Point(3, 30)
    Me.pnldescparc.Margin = New System.Windows.Forms.Padding(4)
    Me.pnldescparc.Name = "pnldescparc"
    Me.pnldescparc.Size = New System.Drawing.Size(258, 170)
    Me.pnldescparc.TabIndex = 1
    Me.pnldescparc.Visible = False
    '
    'txtedad
    '
    Me.txtedad.Location = New System.Drawing.Point(88, 119)
    Me.txtedad.Margin = New System.Windows.Forms.Padding(4)
    Me.txtedad.Mensaje = ""
    Me.txtedad.Name = "txtedad"
    Me.txtedad.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtedad.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtedad.PromptText = ""
    Me.txtedad.Size = New System.Drawing.Size(64, 22)
    Me.txtedad.TabIndex = 8
    Me.txtedad.Text = "0"
    Me.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtedad.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtedad.Value = 0R
    '
    'chkficharoja
    '
    Me.chkficharoja.AutoSize = True
    Me.chkficharoja.Checked = True
    Me.chkficharoja.CheckState = System.Windows.Forms.CheckState.Indeterminate
    Me.chkficharoja.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkficharoja.Location = New System.Drawing.Point(91, 148)
    Me.chkficharoja.Margin = New System.Windows.Forms.Padding(4)
    Me.chkficharoja.Name = "chkficharoja"
    Me.chkficharoja.Size = New System.Drawing.Size(101, 22)
    Me.chkficharoja.TabIndex = 10
    Me.chkficharoja.Text = "Ficha roja"
    Me.chkficharoja.ThreeState = True
    '
    'cbomayorque
    '
    Me.cbomayorque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomayorque.Items.AddRange(New Object() {"Mayor o igual a", "Menor o igual a"})
    Me.cbomayorque.Location = New System.Drawing.Point(88, 89)
    Me.cbomayorque.Margin = New System.Windows.Forms.Padding(4)
    Me.cbomayorque.Name = "cbomayorque"
    Me.cbomayorque.Size = New System.Drawing.Size(135, 24)
    Me.cbomayorque.TabIndex = 7
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(88, 0)
    Me.txtcodigo.Margin = New System.Windows.Forms.Padding(4)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(95, 22)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcodigo.Value = 0R
    '
    'txtcedula
    '
    Me.txtcedula.Location = New System.Drawing.Point(88, 59)
    Me.txtcedula.Margin = New System.Windows.Forms.Padding(4)
    Me.txtcedula.Mensaje = ""
    Me.txtcedula.Name = "txtcedula"
    Me.txtcedula.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcedula.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcedula.PromptText = ""
    Me.txtcedula.Size = New System.Drawing.Size(127, 22)
    Me.txtcedula.TabIndex = 5
    '
    'Label38
    '
    Me.Label38.AutoSize = True
    Me.Label38.Location = New System.Drawing.Point(21, 30)
    Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label38.Name = "Label38"
    Me.Label38.Size = New System.Drawing.Size(62, 17)
    Me.Label38.TabIndex = 2
    Me.Label38.Text = "Nombre:"
    '
    'Label39
    '
    Me.Label39.AutoSize = True
    Me.Label39.Location = New System.Drawing.Point(21, 59)
    Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label39.Name = "Label39"
    Me.Label39.Size = New System.Drawing.Size(52, 17)
    Me.Label39.TabIndex = 4
    Me.Label39.Text = "Céd/Id:"
    '
    'Label41
    '
    Me.Label41.AutoSize = True
    Me.Label41.Location = New System.Drawing.Point(21, 89)
    Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label41.Name = "Label41"
    Me.Label41.Size = New System.Drawing.Size(45, 17)
    Me.Label41.TabIndex = 6
    Me.Label41.Text = "Edad:"
    '
    'Label37
    '
    Me.Label37.AutoSize = True
    Me.Label37.Location = New System.Drawing.Point(21, 0)
    Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label37.Name = "Label37"
    Me.Label37.Size = New System.Drawing.Size(56, 17)
    Me.Label37.TabIndex = 0
    Me.Label37.Text = "Código:"
    '
    'txtnombre
    '
    Me.txtnombre.Location = New System.Drawing.Point(88, 30)
    Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
    Me.txtnombre.Mensaje = ""
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnombre.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtnombre.PromptText = ""
    Me.txtnombre.Size = New System.Drawing.Size(151, 22)
    Me.txtnombre.TabIndex = 3
    '
    'Label49
    '
    Me.Label49.AutoSize = True
    Me.Label49.Location = New System.Drawing.Point(160, 123)
    Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label49.Name = "Label49"
    Me.Label49.Size = New System.Drawing.Size(39, 17)
    Me.Label49.TabIndex = 9
    Me.Label49.Text = "años"
    '
    'rdodescparc
    '
    Me.rdodescparc.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdodescparc.Location = New System.Drawing.Point(3, 2)
    Me.rdodescparc.Margin = New System.Windows.Forms.Padding(4)
    Me.rdodescparc.Name = "rdodescparc"
    Me.rdodescparc.Size = New System.Drawing.Size(258, 28)
    Me.rdodescparc.TabIndex = 0
    Me.rdodescparc.Text = "Descripción parcial"
    '
    'CtlBuscaEmpleados
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Info
    Me.Controls.Add(Me.tvEmpleados)
    Me.Controls.Add(Me.Panel7)
    Me.Controls.Add(Me.pnlresumen)
    Me.Controls.Add(Me.lblstatus)
    Me.Controls.Add(Me.pnlbusqueda)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "CtlBuscaEmpleados"
    Me.Size = New System.Drawing.Size(264, 1346)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.pnlpersactsec.ResumeLayout(False)
    Me.Panel7.ResumeLayout(False)
    CType(Me.tvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.mnuimpresion.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlresumen.ResumeLayout(False)
    Me.pnlpersactfecing.ResumeLayout(False)
    Me.pnlbusqueda.ResumeLayout(False)
    Me.pnlbusqueda.PerformLayout()
    Me.pnlpersinac.ResumeLayout(False)
    Me.pnlpersinac.PerformLayout()
    Me.pnlanioactivo.ResumeLayout(False)
    CType(Me.numanioact, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel4.ResumeLayout(False)
    CType(Me.numanioinac, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlpersac.ResumeLayout(False)
    Me.pnlpersentreedad.ResumeLayout(False)
    Me.pnlpersentreedad.PerformLayout()
    Me.pnlsoloPatrono.ResumeLayout(False)
    Me.pnlsoloclase.ResumeLayout(False)
    Me.pnlpersactfecsal.ResumeLayout(False)
    Me.pnldescparc.ResumeLayout(False)
    Me.pnldescparc.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents rdopersactfecing As System.Windows.Forms.RadioButton
  Friend WithEvents pnlpersactsec As System.Windows.Forms.Panel
  Friend WithEvents rdopersactsec As System.Windows.Forms.RadioButton
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Friend WithEvents btnbuscar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnexportar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label42 As System.Windows.Forms.Label
  Friend WithEvents tvEmpleados As System.Windows.Forms.DataGridView
  Friend WithEvents mnuimpresion As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuimpcont As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuimpetiq As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnudocfalta As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnurepasis As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents pnlresumen As System.Windows.Forms.Panel
  Friend WithEvents lnkresumen As System.Windows.Forms.LinkLabel
  Friend WithEvents rdopersactfecsal As System.Windows.Forms.RadioButton
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents pnlpersactfecing As System.Windows.Forms.Panel
  Friend WithEvents lblstatus As System.Windows.Forms.Label
  Friend WithEvents pnlbusqueda As System.Windows.Forms.Panel
  Friend WithEvents pnlpersac As System.Windows.Forms.Panel
  Friend WithEvents pnlpersentreedad As System.Windows.Forms.Panel
  Friend WithEvents chkpersentreedad As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsoloPatrono As System.Windows.Forms.Panel
  Friend WithEvents chkSoloContrato As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsoloclase As System.Windows.Forms.Panel
  Friend WithEvents chksoloclase As System.Windows.Forms.CheckBox
  Friend WithEvents rdopersacttodos As System.Windows.Forms.RadioButton
  Friend WithEvents pnlpersactfecsal As System.Windows.Forms.Panel
  Friend WithEvents dtfechastasal As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesdesal As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfecactivo As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label45 As System.Windows.Forms.Label
  Friend WithEvents rdopersact As System.Windows.Forms.RadioButton
  Friend WithEvents pnldescparc As System.Windows.Forms.Panel
  Friend WithEvents chkficharoja As System.Windows.Forms.CheckBox
  Friend WithEvents cbomayorque As System.Windows.Forms.ComboBox
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtcedula As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label38 As System.Windows.Forms.Label
  Friend WithEvents Label39 As System.Windows.Forms.Label
  Friend WithEvents Label41 As System.Windows.Forms.Label
  Friend WithEvents Label37 As System.Windows.Forms.Label
  Friend WithEvents txtnombre As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label49 As System.Windows.Forms.Label
  Friend WithEvents rdodescparc As System.Windows.Forms.RadioButton
  Friend WithEvents CtlSeccion1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents ComboBoxClase1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents txtedad As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtedadf As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtedadi As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents CtlTipoContrato1 As Controles.CtlTipoContrato
  Friend WithEvents rdopersinac As System.Windows.Forms.RadioButton
  Friend WithEvents pnlpersinac As System.Windows.Forms.Panel
  Friend WithEvents pnlanioactivo As System.Windows.Forms.Panel
  Friend WithEvents numanioact As System.Windows.Forms.NumericUpDown
  Friend WithEvents chkanioactivo As System.Windows.Forms.CheckBox
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents numanioinac As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Public WithEvents CtlPatrono1 As CtlPatrono
  Friend WithEvents chkincsueldos As System.Windows.Forms.CheckBox
  Friend WithEvents chkDiscapacidad As System.Windows.Forms.CheckBox
  Private WithEvents ListBindingSource As BindingSource
End Class
