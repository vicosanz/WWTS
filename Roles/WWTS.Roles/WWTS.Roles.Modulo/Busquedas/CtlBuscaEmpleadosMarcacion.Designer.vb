<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaEmpleadosMarcacion
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
    Me.chknograbados = New System.Windows.Forms.CheckBox()
    Me.pnlpersactsec = New System.Windows.Forms.Panel()
    Me.CtlSeccion1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label44 = New System.Windows.Forms.Label()
    Me.Label43 = New System.Windows.Forms.Label()
    Me.chksolograbados = New System.Windows.Forms.CheckBox()
    Me.chktodos = New System.Windows.Forms.CheckBox()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.pnltipocontrato = New System.Windows.Forms.Panel()
    Me.CtlTipoContrato1 = New WWTS.Roles.Controles.CtlTipoContrato()
    Me.chksolotipocontrato = New System.Windows.Forms.CheckBox()
    Me.btnbuscar = New Infoware.Controles.Base.ButtonStd()
    Me.Label42 = New System.Windows.Forms.Label()
    Me.rdopersactsec = New System.Windows.Forms.RadioButton()
    Me.Label45 = New System.Windows.Forms.Label()
    Me.pnlpersentreedad = New System.Windows.Forms.Panel()
    Me.txtedadf = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.txtedadi = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.tvEmpleados = New System.Windows.Forms.DataGridView()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnugenerar = New System.Windows.Forms.ToolStripMenuItem()
    Me.ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnlpersac = New System.Windows.Forms.Panel()
    Me.pnlfiltrar = New System.Windows.Forms.Panel()
    Me.pnlfiltrarfin = New System.Windows.Forms.Panel()
    Me.chkpersentreedad = New System.Windows.Forms.CheckBox()
    Me.pnlsoloclase = New System.Windows.Forms.Panel()
    Me.ComboBoxClaseEmpleado = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.chksoloclase = New System.Windows.Forms.CheckBox()
    Me.pnlseccionfecing = New System.Windows.Forms.Panel()
    Me.pnlseccionfecingfin = New System.Windows.Forms.Panel()
    Me.rdopersacttodos = New System.Windows.Forms.RadioButton()
    Me.pnlpersactfecing = New System.Windows.Forms.Panel()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
        Me.CtlPeriodo1 = New Roles.CtlMarcacion()
        Me.CtlPatrono1 = New WWTS.Roles.Controles.CtlPatrono()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.mnugenerararealote = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeaderStrip2.SuspendLayout()
        Me.pnlpersactsec.SuspendLayout()
        Me.pnltipocontrato.SuspendLayout()
        Me.pnlpersentreedad.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.tvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlpersac.SuspendLayout()
        Me.pnlfiltrar.SuspendLayout()
        Me.pnlsoloclase.SuspendLayout()
        Me.pnlseccionfecing.SuspendLayout()
        Me.pnlpersactfecing.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderStrip2
        '
        Me.HeaderStrip2.AutoSize = False
        Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip2.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip2.Name = "HeaderStrip2"
        Me.HeaderStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.HeaderStrip2.Size = New System.Drawing.Size(411, 39)
        Me.HeaderStrip2.TabIndex = 0
        Me.HeaderStrip2.Text = "Opciones"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(240, 33)
        Me.ToolStripLabel2.Text = "Búsqueda de Empleados"
        '
        'rdopersactfecing
        '
        Me.rdopersactfecing.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdopersactfecing.Location = New System.Drawing.Point(0, 75)
        Me.rdopersactfecing.Margin = New System.Windows.Forms.Padding(6)
        Me.rdopersactfecing.Name = "rdopersactfecing"
        Me.rdopersactfecing.Size = New System.Drawing.Size(411, 33)
        Me.rdopersactfecing.TabIndex = 2
        Me.rdopersactfecing.Text = "Por fecha de ingreso"
        '
        'chknograbados
        '
        Me.chknograbados.Dock = System.Windows.Forms.DockStyle.Top
        Me.chknograbados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chknograbados.Location = New System.Drawing.Point(0, 30)
        Me.chknograbados.Margin = New System.Windows.Forms.Padding(6)
        Me.chknograbados.Name = "chknograbados"
        Me.chknograbados.Size = New System.Drawing.Size(411, 30)
        Me.chknograbados.TabIndex = 1
        Me.chknograbados.Text = "Mostrar faltan días grabar"
        '
        'pnlpersactsec
        '
        Me.pnlpersactsec.Controls.Add(Me.CtlSeccion1)
        Me.pnlpersactsec.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlpersactsec.Location = New System.Drawing.Point(0, 33)
        Me.pnlpersactsec.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlpersactsec.Name = "pnlpersactsec"
        Me.pnlpersactsec.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.pnlpersactsec.Size = New System.Drawing.Size(411, 42)
        Me.pnlpersactsec.TabIndex = 1
        '
        'CtlSeccion1
        '
        Me.CtlSeccion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlSeccion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlSeccion1.FormattingEnabled = True
        Me.CtlSeccion1.Location = New System.Drawing.Point(28, 0)
        Me.CtlSeccion1.Margin = New System.Windows.Forms.Padding(6)
        Me.CtlSeccion1.Name = "CtlSeccion1"
        Me.CtlSeccion1.OperadorDatos = Nothing
        Me.CtlSeccion1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.CtlSeccion1.ParametroDet = Nothing
        Me.CtlSeccion1.PuedeActualizar = True
        Me.CtlSeccion1.PuedeEliminar = True
        Me.CtlSeccion1.PuedeModificar = True
        Me.CtlSeccion1.PuedeNuevo = True
        Me.CtlSeccion1.Size = New System.Drawing.Size(383, 32)
        Me.CtlSeccion1.TabIndex = 0
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.Info
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label44.Location = New System.Drawing.Point(28, 51)
        Me.Label44.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(383, 30)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Hasta:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Info
        Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label43.Location = New System.Drawing.Point(28, 0)
        Me.Label43.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(383, 22)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Desde:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chksolograbados
        '
        Me.chksolograbados.Dock = System.Windows.Forms.DockStyle.Top
        Me.chksolograbados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chksolograbados.Location = New System.Drawing.Point(0, 0)
        Me.chksolograbados.Margin = New System.Windows.Forms.Padding(6)
        Me.chksolograbados.Name = "chksolograbados"
        Me.chksolograbados.Size = New System.Drawing.Size(411, 30)
        Me.chksolograbados.TabIndex = 0
        Me.chksolograbados.Text = "Mostrar sólo reg. grabados "
        '
        'chktodos
        '
        Me.chktodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chktodos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chktodos.Location = New System.Drawing.Point(11, 83)
        Me.chktodos.Margin = New System.Windows.Forms.Padding(6)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(22, 33)
        Me.chktodos.TabIndex = 2
        '
        'dtfecdesde
        '
        Me.dtfecdesde.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecdesde.Location = New System.Drawing.Point(28, 22)
        Me.dtfecdesde.Margin = New System.Windows.Forms.Padding(6)
        Me.dtfecdesde.Name = "dtfecdesde"
        Me.dtfecdesde.Size = New System.Drawing.Size(383, 29)
        Me.dtfecdesde.TabIndex = 1
        Me.dtfecdesde.Value = New Date(2005, 3, 13, 20, 27, 9, 968)
        '
        'pnltipocontrato
        '
        Me.pnltipocontrato.Controls.Add(Me.CtlTipoContrato1)
        Me.pnltipocontrato.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltipocontrato.Location = New System.Drawing.Point(0, 187)
        Me.pnltipocontrato.Margin = New System.Windows.Forms.Padding(6)
        Me.pnltipocontrato.Name = "pnltipocontrato"
        Me.pnltipocontrato.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.pnltipocontrato.Size = New System.Drawing.Size(411, 42)
        Me.pnltipocontrato.TabIndex = 3
        '
        'CtlTipoContrato1
        '
        Me.CtlTipoContrato1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlTipoContrato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlTipoContrato1.FormattingEnabled = True
        Me.CtlTipoContrato1.Location = New System.Drawing.Point(28, 0)
        Me.CtlTipoContrato1.Margin = New System.Windows.Forms.Padding(6)
        Me.CtlTipoContrato1.Name = "CtlTipoContrato1"
        Me.CtlTipoContrato1.Op = Nothing
        Me.CtlTipoContrato1.Patrono = Nothing
        Me.CtlTipoContrato1.PuedeActualizar = True
        Me.CtlTipoContrato1.PuedeEliminar = True
        Me.CtlTipoContrato1.PuedeModificar = True
        Me.CtlTipoContrato1.PuedeNuevo = True
        Me.CtlTipoContrato1.Size = New System.Drawing.Size(383, 32)
        Me.CtlTipoContrato1.TabIndex = 0
        Me.CtlTipoContrato1.TipoContrato = Nothing
        '
        'chksolotipocontrato
        '
        Me.chksolotipocontrato.Checked = True
        Me.chksolotipocontrato.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksolotipocontrato.Dock = System.Windows.Forms.DockStyle.Top
        Me.chksolotipocontrato.Location = New System.Drawing.Point(0, 157)
        Me.chksolotipocontrato.Margin = New System.Windows.Forms.Padding(6)
        Me.chksolotipocontrato.Name = "chksolotipocontrato"
        Me.chksolotipocontrato.Size = New System.Drawing.Size(411, 30)
        Me.chksolotipocontrato.TabIndex = 2
        Me.chksolotipocontrato.Text = "Tipo de contrato:"
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnbuscar.Location = New System.Drawing.Point(103, 68)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(138, 46)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "&Buscar"
        '
        'Label42
        '
        Me.Label42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label42.Location = New System.Drawing.Point(0, 0)
        Me.Label42.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(411, 33)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Patrono:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdopersactsec
        '
        Me.rdopersactsec.Checked = True
        Me.rdopersactsec.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdopersactsec.Location = New System.Drawing.Point(0, 0)
        Me.rdopersactsec.Margin = New System.Windows.Forms.Padding(6)
        Me.rdopersactsec.Name = "rdopersactsec"
        Me.rdopersactsec.Size = New System.Drawing.Size(411, 33)
        Me.rdopersactsec.TabIndex = 0
        Me.rdopersactsec.TabStop = True
        Me.rdopersactsec.Text = "Por sección"
        '
        'Label45
        '
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label45.Location = New System.Drawing.Point(0, 229)
        Me.Label45.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(411, 30)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Marcacion:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlpersentreedad
        '
        Me.pnlpersentreedad.Controls.Add(Me.txtedadf)
        Me.pnlpersentreedad.Controls.Add(Me.Panel1)
        Me.pnlpersentreedad.Controls.Add(Me.txtedadi)
        Me.pnlpersentreedad.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlpersentreedad.Location = New System.Drawing.Point(0, 383)
        Me.pnlpersentreedad.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlpersentreedad.Name = "pnlpersentreedad"
        Me.pnlpersentreedad.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.pnlpersentreedad.Size = New System.Drawing.Size(411, 44)
        Me.pnlpersentreedad.TabIndex = 3
        Me.pnlpersentreedad.Visible = False
        '
        'txtedadf
        '
        Me.txtedadf.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtedadf.Location = New System.Drawing.Point(161, 0)
        Me.txtedadf.Margin = New System.Windows.Forms.Padding(6)
        Me.txtedadf.Mensaje = ""
        Me.txtedadf.Name = "txtedadf"
        Me.txtedadf.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedadf.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtedadf.PromptText = ""
        Me.txtedadf.Size = New System.Drawing.Size(74, 29)
        Me.txtedadf.TabIndex = 2
        Me.txtedadf.Text = "0"
        Me.txtedadf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtedadf.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtedadf.Value = 0R
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(104, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(57, 44)
        Me.Panel1.TabIndex = 1
        '
        'txtedadi
        '
        Me.txtedadi.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtedadi.Location = New System.Drawing.Point(28, 0)
        Me.txtedadi.Margin = New System.Windows.Forms.Padding(6)
        Me.txtedadi.Mensaje = ""
        Me.txtedadi.Name = "txtedadi"
        Me.txtedadi.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedadi.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtedadi.PromptText = ""
        Me.txtedadi.Size = New System.Drawing.Size(76, 29)
        Me.txtedadi.TabIndex = 0
        Me.txtedadi.Text = "0"
        Me.txtedadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtedadi.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtedadi.Value = 0R
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.chknograbados)
        Me.Panel7.Controls.Add(Me.chksolograbados)
        Me.Panel7.Controls.Add(Me.chktodos)
        Me.Panel7.Controls.Add(Me.btnbuscar)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 920)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(411, 118)
        Me.Panel7.TabIndex = 48
        '
        'tvEmpleados
        '
        Me.tvEmpleados.AllowUserToAddRows = False
        Me.tvEmpleados.AllowUserToDeleteRows = False
        Me.tvEmpleados.AllowUserToResizeRows = False
        Me.tvEmpleados.AutoGenerateColumns = False
        Me.tvEmpleados.ColumnHeadersHeight = 40
        Me.tvEmpleados.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvEmpleados.DataSource = Me.ListBindingSource
        Me.tvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvEmpleados.Location = New System.Drawing.Point(0, 1038)
        Me.tvEmpleados.Margin = New System.Windows.Forms.Padding(6)
        Me.tvEmpleados.MultiSelect = False
        Me.tvEmpleados.Name = "tvEmpleados"
        Me.tvEmpleados.RowHeadersVisible = False
        Me.tvEmpleados.RowHeadersWidth = 72
        Me.tvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tvEmpleados.Size = New System.Drawing.Size(411, 169)
        Me.tvEmpleados.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnugenerar, Me.mnugenerararealote})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(331, 114)
        '
        'mnugenerar
        '
        Me.mnugenerar.Enabled = False
        Me.mnugenerar.Name = "mnugenerar"
        Me.mnugenerar.Size = New System.Drawing.Size(330, 36)
        Me.mnugenerar.Text = "&Generar Asistencia"
        '
        'ListBindingSource
        '
        '
        'pnlpersac
        '
        Me.pnlpersac.Controls.Add(Me.pnlfiltrar)
        Me.pnlpersac.Controls.Add(Me.CtlPeriodo1)
        Me.pnlpersac.Controls.Add(Me.Label45)
        Me.pnlpersac.Controls.Add(Me.pnltipocontrato)
        Me.pnlpersac.Controls.Add(Me.chksolotipocontrato)
        Me.pnlpersac.Controls.Add(Me.CtlPatrono1)
        Me.pnlpersac.Controls.Add(Me.Label42)
        Me.pnlpersac.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlpersac.Location = New System.Drawing.Point(0, 39)
        Me.pnlpersac.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlpersac.Name = "pnlpersac"
        Me.pnlpersac.Size = New System.Drawing.Size(411, 881)
        Me.pnlpersac.TabIndex = 50
        '
        'pnlfiltrar
        '
        Me.pnlfiltrar.Controls.Add(Me.pnlfiltrarfin)
        Me.pnlfiltrar.Controls.Add(Me.pnlpersentreedad)
        Me.pnlfiltrar.Controls.Add(Me.chkpersentreedad)
        Me.pnlfiltrar.Controls.Add(Me.pnlsoloclase)
        Me.pnlfiltrar.Controls.Add(Me.chksoloclase)
        Me.pnlfiltrar.Controls.Add(Me.pnlseccionfecing)
        Me.pnlfiltrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfiltrar.Location = New System.Drawing.Point(0, 359)
        Me.pnlfiltrar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlfiltrar.Name = "pnlfiltrar"
        Me.pnlfiltrar.Size = New System.Drawing.Size(411, 462)
        Me.pnlfiltrar.TabIndex = 62
        '
        'pnlfiltrarfin
        '
        Me.pnlfiltrarfin.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfiltrarfin.Location = New System.Drawing.Point(0, 427)
        Me.pnlfiltrarfin.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlfiltrarfin.Name = "pnlfiltrarfin"
        Me.pnlfiltrarfin.Size = New System.Drawing.Size(411, 15)
        Me.pnlfiltrarfin.TabIndex = 4
        '
        'chkpersentreedad
        '
        Me.chkpersentreedad.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkpersentreedad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkpersentreedad.Location = New System.Drawing.Point(0, 350)
        Me.chkpersentreedad.Margin = New System.Windows.Forms.Padding(6)
        Me.chkpersentreedad.Name = "chkpersentreedad"
        Me.chkpersentreedad.Size = New System.Drawing.Size(411, 33)
        Me.chkpersentreedad.TabIndex = 2
        Me.chkpersentreedad.Text = "Edad entre"
        '
        'pnlsoloclase
        '
        Me.pnlsoloclase.Controls.Add(Me.ComboBoxClaseEmpleado)
        Me.pnlsoloclase.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsoloclase.Location = New System.Drawing.Point(0, 306)
        Me.pnlsoloclase.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlsoloclase.Name = "pnlsoloclase"
        Me.pnlsoloclase.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.pnlsoloclase.Size = New System.Drawing.Size(411, 44)
        Me.pnlsoloclase.TabIndex = 1
        Me.pnlsoloclase.Visible = False
        '
        'ComboBoxClaseEmpleado
        '
        Me.ComboBoxClaseEmpleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxClaseEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxClaseEmpleado.FormattingEnabled = True
        Me.ComboBoxClaseEmpleado.Location = New System.Drawing.Point(28, 0)
        Me.ComboBoxClaseEmpleado.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBoxClaseEmpleado.Name = "ComboBoxClaseEmpleado"
        Me.ComboBoxClaseEmpleado.OperadorDatos = Nothing
        Me.ComboBoxClaseEmpleado.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxClaseEmpleado.ParametroDet = Nothing
        Me.ComboBoxClaseEmpleado.PuedeActualizar = True
        Me.ComboBoxClaseEmpleado.PuedeEliminar = True
        Me.ComboBoxClaseEmpleado.PuedeModificar = True
        Me.ComboBoxClaseEmpleado.PuedeNuevo = True
        Me.ComboBoxClaseEmpleado.Size = New System.Drawing.Size(383, 32)
        Me.ComboBoxClaseEmpleado.TabIndex = 0
        '
        'chksoloclase
        '
        Me.chksoloclase.Dock = System.Windows.Forms.DockStyle.Top
        Me.chksoloclase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chksoloclase.Location = New System.Drawing.Point(0, 273)
        Me.chksoloclase.Margin = New System.Windows.Forms.Padding(6)
        Me.chksoloclase.Name = "chksoloclase"
        Me.chksoloclase.Size = New System.Drawing.Size(411, 33)
        Me.chksoloclase.TabIndex = 0
        Me.chksoloclase.Text = "Sólo de la clase"
        '
        'pnlseccionfecing
        '
        Me.pnlseccionfecing.Controls.Add(Me.pnlseccionfecingfin)
        Me.pnlseccionfecing.Controls.Add(Me.rdopersacttodos)
        Me.pnlseccionfecing.Controls.Add(Me.pnlpersactfecing)
        Me.pnlseccionfecing.Controls.Add(Me.rdopersactfecing)
        Me.pnlseccionfecing.Controls.Add(Me.pnlpersactsec)
        Me.pnlseccionfecing.Controls.Add(Me.rdopersactsec)
        Me.pnlseccionfecing.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlseccionfecing.Location = New System.Drawing.Point(0, 0)
        Me.pnlseccionfecing.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlseccionfecing.Name = "pnlseccionfecing"
        Me.pnlseccionfecing.Size = New System.Drawing.Size(411, 273)
        Me.pnlseccionfecing.TabIndex = 61
        '
        'pnlseccionfecingfin
        '
        Me.pnlseccionfecingfin.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlseccionfecingfin.Location = New System.Drawing.Point(0, 268)
        Me.pnlseccionfecingfin.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlseccionfecingfin.Name = "pnlseccionfecingfin"
        Me.pnlseccionfecingfin.Size = New System.Drawing.Size(411, 15)
        Me.pnlseccionfecingfin.TabIndex = 5
        '
        'rdopersacttodos
        '
        Me.rdopersacttodos.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdopersacttodos.Location = New System.Drawing.Point(0, 235)
        Me.rdopersacttodos.Margin = New System.Windows.Forms.Padding(6)
        Me.rdopersacttodos.Name = "rdopersacttodos"
        Me.rdopersacttodos.Size = New System.Drawing.Size(411, 33)
        Me.rdopersacttodos.TabIndex = 4
        Me.rdopersacttodos.Text = "Todos"
        '
        'pnlpersactfecing
        '
        Me.pnlpersactfecing.Controls.Add(Me.dtfechasta)
        Me.pnlpersactfecing.Controls.Add(Me.Label44)
        Me.pnlpersactfecing.Controls.Add(Me.dtfecdesde)
        Me.pnlpersactfecing.Controls.Add(Me.Label43)
        Me.pnlpersactfecing.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlpersactfecing.Location = New System.Drawing.Point(0, 108)
        Me.pnlpersactfecing.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlpersactfecing.Name = "pnlpersactfecing"
        Me.pnlpersactfecing.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.pnlpersactfecing.Size = New System.Drawing.Size(411, 127)
        Me.pnlpersactfecing.TabIndex = 3
        Me.pnlpersactfecing.Visible = False
        '
        'dtfechasta
        '
        Me.dtfechasta.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechasta.Location = New System.Drawing.Point(28, 81)
        Me.dtfechasta.Margin = New System.Windows.Forms.Padding(6)
        Me.dtfechasta.Name = "dtfechasta"
        Me.dtfechasta.Size = New System.Drawing.Size(383, 29)
        Me.dtfechasta.TabIndex = 3
        Me.dtfechasta.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
        '
        'CtlPeriodo1
        '
        Me.CtlPeriodo1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlPeriodo1.FormattingEnabled = True
        Me.CtlPeriodo1.ItemHeight = 24
        Me.CtlPeriodo1.Location = New System.Drawing.Point(0, 259)
        Me.CtlPeriodo1.Margin = New System.Windows.Forms.Padding(6)
        Me.CtlPeriodo1.Name = "CtlPeriodo1"
        Me.CtlPeriodo1.Op = Nothing
        Me.CtlPeriodo1.PardetPeriodoPago = Nothing
        Me.CtlPeriodo1.PeriodoPago = Nothing
        Me.CtlPeriodo1.PuedeActualizar = True
        Me.CtlPeriodo1.PuedeEliminar = True
        Me.CtlPeriodo1.PuedeModificar = True
        Me.CtlPeriodo1.PuedeNuevo = True
        Me.CtlPeriodo1.Size = New System.Drawing.Size(411, 100)
        Me.CtlPeriodo1.TabIndex = 5
        '
        'CtlPatrono1
        '
        Me.CtlPatrono1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlPatrono1.Location = New System.Drawing.Point(0, 33)
        Me.CtlPatrono1.Margin = New System.Windows.Forms.Padding(11)
        Me.CtlPatrono1.Name = "CtlPatrono1"
        Me.CtlPatrono1.Op = Nothing
        Me.CtlPatrono1.Patrono = Nothing
        Me.CtlPatrono1.Size = New System.Drawing.Size(411, 124)
        Me.CtlPatrono1.TabIndex = 1
        Me.CtlPatrono1.Usuario = Nothing
        '
        'lblstatus
        '
        Me.lblstatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblstatus.Location = New System.Drawing.Point(0, 1207)
        Me.lblstatus.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(411, 30)
        Me.lblstatus.TabIndex = 2
        '
        'mnugenerararealote
        '
        Me.mnugenerararealote.Enabled = False
        Me.mnugenerararealote.Name = "mnugenerararealote"
        Me.mnugenerararealote.Size = New System.Drawing.Size(330, 36)
        Me.mnugenerararealote.Text = "Asistencia con Area y Lote"
        '
        'CtlBuscaEmpleadosMarcacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.tvEmpleados)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.pnlpersac)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.HeaderStrip2)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "CtlBuscaEmpleadosMarcacion"
        Me.Size = New System.Drawing.Size(411, 1237)
        Me.HeaderStrip2.ResumeLayout(False)
        Me.HeaderStrip2.PerformLayout()
        Me.pnlpersactsec.ResumeLayout(False)
        Me.pnltipocontrato.ResumeLayout(False)
        Me.pnlpersentreedad.ResumeLayout(False)
        Me.pnlpersentreedad.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.tvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlpersac.ResumeLayout(False)
        Me.pnlfiltrar.ResumeLayout(False)
        Me.pnlsoloclase.ResumeLayout(False)
        Me.pnlseccionfecing.ResumeLayout(False)
        Me.pnlpersactfecing.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents rdopersactfecing As System.Windows.Forms.RadioButton
  Friend WithEvents chknograbados As System.Windows.Forms.CheckBox
  Friend WithEvents pnlpersactsec As System.Windows.Forms.Panel
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents chksolograbados As System.Windows.Forms.CheckBox
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents pnltipocontrato As System.Windows.Forms.Panel
  Friend WithEvents CtlTipoContrato1 As WWTS.Roles.Controles.CtlTipoContrato
  Friend WithEvents chksolotipocontrato As System.Windows.Forms.CheckBox
  Friend WithEvents btnbuscar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label42 As System.Windows.Forms.Label
  Friend WithEvents rdopersactsec As System.Windows.Forms.RadioButton
  Friend WithEvents Label45 As System.Windows.Forms.Label
  Friend WithEvents pnlpersentreedad As System.Windows.Forms.Panel
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents tvEmpleados As System.Windows.Forms.DataGridView
  Friend WithEvents pnlpersac As System.Windows.Forms.Panel
  Friend WithEvents pnlfiltrar As System.Windows.Forms.Panel
  Friend WithEvents pnlfiltrarfin As System.Windows.Forms.Panel
  Friend WithEvents chkpersentreedad As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsoloclase As System.Windows.Forms.Panel
  Friend WithEvents chksoloclase As System.Windows.Forms.CheckBox
  Friend WithEvents pnlseccionfecing As System.Windows.Forms.Panel
  Friend WithEvents pnlseccionfecingfin As System.Windows.Forms.Panel
  Friend WithEvents rdopersacttodos As System.Windows.Forms.RadioButton
  Friend WithEvents pnlpersactfecing As System.Windows.Forms.Panel
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblstatus As System.Windows.Forms.Label
  Friend WithEvents CtlPeriodo1 As CtlMarcacion
  Friend WithEvents CtlSeccion1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents txtedadf As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtedadi As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents ComboBoxClaseEmpleado As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlPatrono1 As WWTS.Roles.Controles.CtlPatrono
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnugenerar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mnugenerararealote As ToolStripMenuItem
End Class
