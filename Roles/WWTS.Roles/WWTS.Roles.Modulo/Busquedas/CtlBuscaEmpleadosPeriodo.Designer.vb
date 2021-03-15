<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaEmpleadosPeriodo
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
    Dim Patrono1 As WWTS.General.Reglas.Patrono = New WWTS.General.Reglas.Patrono()
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.chknograbados = New System.Windows.Forms.CheckBox()
    Me.chksolograbados = New System.Windows.Forms.CheckBox()
    Me.chktodos = New System.Windows.Forms.CheckBox()
    Me.pnltipocontrato = New System.Windows.Forms.Panel()
    Me.CtlTipoContrato1 = New WWTS.Roles.Modulo.CtlTipoContrato()
    Me.chksolotipocontrato = New System.Windows.Forms.CheckBox()
    Me.btnbuscar = New Infoware.Controles.Base.ButtonStd()
    Me.Label42 = New System.Windows.Forms.Label()
    Me.Label45 = New System.Windows.Forms.Label()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.tvEmpleados = New System.Windows.Forms.DataGridView()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnugenerar = New System.Windows.Forms.ToolStripMenuItem()
    Me.ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnlpersac = New System.Windows.Forms.Panel()
    Me.pnlfiltrar = New System.Windows.Forms.Panel()
    Me.pnlfiltrarfin = New System.Windows.Forms.Panel()
    Me.pnlpersentreedad = New System.Windows.Forms.Panel()
    Me.txtedadf = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.txtedadi = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chkpersentreedad = New System.Windows.Forms.CheckBox()
    Me.pnlsoloclase = New System.Windows.Forms.Panel()
    Me.ComboBoxClaseEmpleado = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.chksoloclase = New System.Windows.Forms.CheckBox()
    Me.pnlseccionfecing = New System.Windows.Forms.Panel()
    Me.pnlseccionfecingfin = New System.Windows.Forms.Panel()
    Me.rdopersacttodos = New System.Windows.Forms.RadioButton()
    Me.pnlpersactfecing = New System.Windows.Forms.Panel()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.Label44 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label43 = New System.Windows.Forms.Label()
    Me.rdopersactfecing = New System.Windows.Forms.RadioButton()
    Me.pnlpersactsec = New System.Windows.Forms.Panel()
    Me.CtlSeccion1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.rdopersactsec = New System.Windows.Forms.RadioButton()
    Me.CtlPeriodo1 = New WWTS.Roles.Modulo.CtlPeriodo()
    Me.CtlPatrono1 = New WWTS.Roles.Modulo.CtlPatrono()
    Me.lblstatus = New System.Windows.Forms.Label()
    Me.HeaderStrip2.SuspendLayout()
    Me.pnltipocontrato.SuspendLayout()
    Me.Panel7.SuspendLayout()
    CType(Me.tvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStrip1.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlpersac.SuspendLayout()
    Me.pnlfiltrar.SuspendLayout()
    Me.pnlpersentreedad.SuspendLayout()
    Me.pnlsoloclase.SuspendLayout()
    Me.pnlseccionfecing.SuspendLayout()
    Me.pnlpersactfecing.SuspendLayout()
    Me.pnlpersactsec.SuspendLayout()
    Me.SuspendLayout()
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(224, 21)
    Me.HeaderStrip2.TabIndex = 0
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(136, 18)
    Me.ToolStripLabel2.Text = "Búsqueda de Empleados"
    '
    'chknograbados
    '
    Me.chknograbados.Dock = System.Windows.Forms.DockStyle.Top
    Me.chknograbados.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chknograbados.Location = New System.Drawing.Point(0, 16)
    Me.chknograbados.Name = "chknograbados"
    Me.chknograbados.Size = New System.Drawing.Size(224, 16)
    Me.chknograbados.TabIndex = 1
    Me.chknograbados.Text = "Mostrar faltan días grabar"
    '
    'chksolograbados
    '
    Me.chksolograbados.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolograbados.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolograbados.Location = New System.Drawing.Point(0, 0)
    Me.chksolograbados.Name = "chksolograbados"
    Me.chksolograbados.Size = New System.Drawing.Size(224, 16)
    Me.chksolograbados.TabIndex = 0
    Me.chksolograbados.Text = "Mostrar sólo reg. grabados "
    '
    'chktodos
    '
    Me.chktodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chktodos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chktodos.Location = New System.Drawing.Point(6, 45)
    Me.chktodos.Name = "chktodos"
    Me.chktodos.Size = New System.Drawing.Size(12, 18)
    Me.chktodos.TabIndex = 2
    '
    'pnltipocontrato
    '
    Me.pnltipocontrato.Controls.Add(Me.CtlTipoContrato1)
    Me.pnltipocontrato.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnltipocontrato.Location = New System.Drawing.Point(0, 90)
    Me.pnltipocontrato.Name = "pnltipocontrato"
    Me.pnltipocontrato.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnltipocontrato.Size = New System.Drawing.Size(224, 23)
    Me.pnltipocontrato.TabIndex = 3
    '
    'CtlTipoContrato1
    '
    Me.CtlTipoContrato1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTipoContrato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlTipoContrato1.FormattingEnabled = True
    Me.CtlTipoContrato1.Location = New System.Drawing.Point(15, 0)
    Me.CtlTipoContrato1.Name = "CtlTipoContrato1"
    Me.CtlTipoContrato1.Op = Nothing
    Patrono1.Entida_Patrono = 0
    Patrono1.Entidadjuridica = Nothing
    Patrono1.EsEliminado = False
    Patrono1.EsModificado = True
    Patrono1.EsNuevo = True
    Patrono1.OperadorDatos = Nothing
    Patrono1.Parame_Parroquia = 0
    Patrono1.Pardet_Parroquia = 0
    Patrono1.PardetParroquia = Nothing
    Patrono1.Patron_Codigo = 0
    Patrono1.Patron_CodigoContable = ""
    Patrono1.Patron_NumeroCuentaBancaria = ""
    Patrono1.Patron_NumeroPatronal = ""
    Me.CtlTipoContrato1.Patrono = Patrono1
    Me.CtlTipoContrato1.PuedeActualizar = True
    Me.CtlTipoContrato1.PuedeEliminar = True
    Me.CtlTipoContrato1.PuedeModificar = True
    Me.CtlTipoContrato1.PuedeNuevo = True
    Me.CtlTipoContrato1.Size = New System.Drawing.Size(209, 21)
    Me.CtlTipoContrato1.TabIndex = 0
    Me.CtlTipoContrato1.TipoContrato = Nothing
    '
    'chksolotipocontrato
    '
    Me.chksolotipocontrato.Checked = True
    Me.chksolotipocontrato.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chksolotipocontrato.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolotipocontrato.Location = New System.Drawing.Point(0, 74)
    Me.chksolotipocontrato.Name = "chksolotipocontrato"
    Me.chksolotipocontrato.Size = New System.Drawing.Size(224, 16)
    Me.chksolotipocontrato.TabIndex = 2
    Me.chksolotipocontrato.Text = "Tipo de contrato:"
    '
    'btnbuscar
    '
    Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnbuscar.Location = New System.Drawing.Point(56, 37)
    Me.btnbuscar.Name = "btnbuscar"
    Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
    Me.btnbuscar.TabIndex = 3
    Me.btnbuscar.Text = "&Buscar"
    '
    'Label42
    '
    Me.Label42.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label42.Location = New System.Drawing.Point(0, 0)
    Me.Label42.Name = "Label42"
    Me.Label42.Size = New System.Drawing.Size(224, 18)
    Me.Label42.TabIndex = 0
    Me.Label42.Text = "Patrono:"
    Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label45
    '
    Me.Label45.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label45.Location = New System.Drawing.Point(0, 113)
    Me.Label45.Name = "Label45"
    Me.Label45.Size = New System.Drawing.Size(224, 16)
    Me.Label45.TabIndex = 4
    Me.Label45.Text = "Periodo:"
    Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.chknograbados)
    Me.Panel7.Controls.Add(Me.chksolograbados)
    Me.Panel7.Controls.Add(Me.chktodos)
    Me.Panel7.Controls.Add(Me.btnbuscar)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 482)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(224, 64)
    Me.Panel7.TabIndex = 48
    '
    'tvEmpleados
    '
    Me.tvEmpleados.AllowUserToAddRows = False
    Me.tvEmpleados.AllowUserToDeleteRows = False
    Me.tvEmpleados.AllowUserToResizeRows = False
    Me.tvEmpleados.AutoGenerateColumns = False
    Me.tvEmpleados.ContextMenuStrip = Me.ContextMenuStrip1
    Me.tvEmpleados.DataSource = Me.ListBindingSource
    Me.tvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvEmpleados.Location = New System.Drawing.Point(0, 546)
    Me.tvEmpleados.MultiSelect = False
    Me.tvEmpleados.Name = "tvEmpleados"
    Me.tvEmpleados.RowHeadersVisible = False
    Me.tvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.tvEmpleados.Size = New System.Drawing.Size(224, 108)
    Me.tvEmpleados.TabIndex = 1
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnugenerar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(116, 26)
    '
    'mnugenerar
    '
    Me.mnugenerar.Enabled = False
    Me.mnugenerar.Name = "mnugenerar"
    Me.mnugenerar.Size = New System.Drawing.Size(115, 22)
    Me.mnugenerar.Text = "&Generar"
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
    Me.pnlpersac.Location = New System.Drawing.Point(0, 21)
    Me.pnlpersac.Name = "pnlpersac"
    Me.pnlpersac.Size = New System.Drawing.Size(224, 461)
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
    Me.pnlfiltrar.Location = New System.Drawing.Point(0, 185)
    Me.pnlfiltrar.Name = "pnlfiltrar"
    Me.pnlfiltrar.Size = New System.Drawing.Size(224, 250)
    Me.pnlfiltrar.TabIndex = 62
    '
    'pnlfiltrarfin
    '
    Me.pnlfiltrarfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlfiltrarfin.Location = New System.Drawing.Point(0, 232)
    Me.pnlfiltrarfin.Name = "pnlfiltrarfin"
    Me.pnlfiltrarfin.Size = New System.Drawing.Size(224, 8)
    Me.pnlfiltrarfin.TabIndex = 4
    '
    'pnlpersentreedad
    '
    Me.pnlpersentreedad.Controls.Add(Me.txtedadf)
    Me.pnlpersentreedad.Controls.Add(Me.Panel1)
    Me.pnlpersentreedad.Controls.Add(Me.txtedadi)
    Me.pnlpersentreedad.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersentreedad.Location = New System.Drawing.Point(0, 208)
    Me.pnlpersentreedad.Name = "pnlpersentreedad"
    Me.pnlpersentreedad.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnlpersentreedad.Size = New System.Drawing.Size(224, 24)
    Me.pnlpersentreedad.TabIndex = 3
    Me.pnlpersentreedad.Visible = False
    '
    'txtedadf
    '
    Me.txtedadf.Dock = System.Windows.Forms.DockStyle.Left
    Me.txtedadf.Location = New System.Drawing.Point(89, 0)
    Me.txtedadf.Mensaje = ""
    Me.txtedadf.Name = "txtedadf"
    Me.txtedadf.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtedadf.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtedadf.PromptText = ""
    Me.txtedadf.Size = New System.Drawing.Size(42, 20)
    Me.txtedadf.TabIndex = 2
    Me.txtedadf.Text = "0"
    Me.txtedadf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtedadf.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtedadf.Value = 0.0R
    '
    'Panel1
    '
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Location = New System.Drawing.Point(58, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(31, 24)
    Me.Panel1.TabIndex = 1
    '
    'txtedadi
    '
    Me.txtedadi.Dock = System.Windows.Forms.DockStyle.Left
    Me.txtedadi.Location = New System.Drawing.Point(15, 0)
    Me.txtedadi.Mensaje = ""
    Me.txtedadi.Name = "txtedadi"
    Me.txtedadi.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtedadi.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtedadi.PromptText = ""
    Me.txtedadi.Size = New System.Drawing.Size(43, 20)
    Me.txtedadi.TabIndex = 0
    Me.txtedadi.Text = "0"
    Me.txtedadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtedadi.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtedadi.Value = 0.0R
    '
    'chkpersentreedad
    '
    Me.chkpersentreedad.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkpersentreedad.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkpersentreedad.Location = New System.Drawing.Point(0, 190)
    Me.chkpersentreedad.Name = "chkpersentreedad"
    Me.chkpersentreedad.Size = New System.Drawing.Size(224, 18)
    Me.chkpersentreedad.TabIndex = 2
    Me.chkpersentreedad.Text = "Edad entre"
    '
    'pnlsoloclase
    '
    Me.pnlsoloclase.Controls.Add(Me.ComboBoxClaseEmpleado)
    Me.pnlsoloclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlsoloclase.Location = New System.Drawing.Point(0, 166)
    Me.pnlsoloclase.Name = "pnlsoloclase"
    Me.pnlsoloclase.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnlsoloclase.Size = New System.Drawing.Size(224, 24)
    Me.pnlsoloclase.TabIndex = 1
    Me.pnlsoloclase.Visible = False
    '
    'ComboBoxClaseEmpleado
    '
    Me.ComboBoxClaseEmpleado.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBoxClaseEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxClaseEmpleado.FormattingEnabled = True
    Me.ComboBoxClaseEmpleado.Location = New System.Drawing.Point(15, 0)
    Me.ComboBoxClaseEmpleado.Name = "ComboBoxClaseEmpleado"
    Me.ComboBoxClaseEmpleado.OperadorDatos = Nothing
    Me.ComboBoxClaseEmpleado.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxClaseEmpleado.ParametroDet = Nothing
    Me.ComboBoxClaseEmpleado.PuedeActualizar = True
    Me.ComboBoxClaseEmpleado.PuedeEliminar = True
    Me.ComboBoxClaseEmpleado.PuedeModificar = True
    Me.ComboBoxClaseEmpleado.PuedeNuevo = True
    Me.ComboBoxClaseEmpleado.Size = New System.Drawing.Size(209, 21)
    Me.ComboBoxClaseEmpleado.TabIndex = 0
    '
    'chksoloclase
    '
    Me.chksoloclase.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksoloclase.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksoloclase.Location = New System.Drawing.Point(0, 148)
    Me.chksoloclase.Name = "chksoloclase"
    Me.chksoloclase.Size = New System.Drawing.Size(224, 18)
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
    Me.pnlseccionfecing.Name = "pnlseccionfecing"
    Me.pnlseccionfecing.Size = New System.Drawing.Size(224, 148)
    Me.pnlseccionfecing.TabIndex = 61
    '
    'pnlseccionfecingfin
    '
    Me.pnlseccionfecingfin.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlseccionfecingfin.Location = New System.Drawing.Point(0, 146)
    Me.pnlseccionfecingfin.Name = "pnlseccionfecingfin"
    Me.pnlseccionfecingfin.Size = New System.Drawing.Size(224, 8)
    Me.pnlseccionfecingfin.TabIndex = 5
    '
    'rdopersacttodos
    '
    Me.rdopersacttodos.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersacttodos.Location = New System.Drawing.Point(0, 128)
    Me.rdopersacttodos.Name = "rdopersacttodos"
    Me.rdopersacttodos.Size = New System.Drawing.Size(224, 18)
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
    Me.pnlpersactfecing.Location = New System.Drawing.Point(0, 59)
    Me.pnlpersactfecing.Name = "pnlpersactfecing"
    Me.pnlpersactfecing.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnlpersactfecing.Size = New System.Drawing.Size(224, 69)
    Me.pnlpersactfecing.TabIndex = 3
    Me.pnlpersactfecing.Visible = False
    '
    'dtfechasta
    '
    Me.dtfechasta.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(15, 48)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(209, 20)
    Me.dtfechasta.TabIndex = 3
    Me.dtfechasta.Value = New Date(2005, 3, 13, 20, 27, 9, 953)
    '
    'Label44
    '
    Me.Label44.BackColor = System.Drawing.SystemColors.Info
    Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label44.Location = New System.Drawing.Point(15, 32)
    Me.Label44.Name = "Label44"
    Me.Label44.Size = New System.Drawing.Size(209, 16)
    Me.Label44.TabIndex = 2
    Me.Label44.Text = "Hasta:"
    Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(15, 12)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(209, 20)
    Me.dtfecdesde.TabIndex = 1
    Me.dtfecdesde.Value = New Date(2005, 3, 13, 20, 27, 9, 968)
    '
    'Label43
    '
    Me.Label43.BackColor = System.Drawing.SystemColors.Info
    Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label43.Location = New System.Drawing.Point(15, 0)
    Me.Label43.Name = "Label43"
    Me.Label43.Size = New System.Drawing.Size(209, 12)
    Me.Label43.TabIndex = 0
    Me.Label43.Text = "Desde:"
    Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'rdopersactfecing
    '
    Me.rdopersactfecing.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersactfecing.Location = New System.Drawing.Point(0, 41)
    Me.rdopersactfecing.Name = "rdopersactfecing"
    Me.rdopersactfecing.Size = New System.Drawing.Size(224, 18)
    Me.rdopersactfecing.TabIndex = 2
    Me.rdopersactfecing.Text = "Por fecha de ingreso"
    '
    'pnlpersactsec
    '
    Me.pnlpersactsec.Controls.Add(Me.CtlSeccion1)
    Me.pnlpersactsec.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpersactsec.Location = New System.Drawing.Point(0, 18)
    Me.pnlpersactsec.Name = "pnlpersactsec"
    Me.pnlpersactsec.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnlpersactsec.Size = New System.Drawing.Size(224, 23)
    Me.pnlpersactsec.TabIndex = 1
    '
    'CtlSeccion1
    '
    Me.CtlSeccion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlSeccion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSeccion1.FormattingEnabled = True
    Me.CtlSeccion1.Location = New System.Drawing.Point(15, 0)
    Me.CtlSeccion1.Name = "CtlSeccion1"
    Me.CtlSeccion1.OperadorDatos = Nothing
    Me.CtlSeccion1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlSeccion1.ParametroDet = Nothing
    Me.CtlSeccion1.PuedeActualizar = True
    Me.CtlSeccion1.PuedeEliminar = True
    Me.CtlSeccion1.PuedeModificar = True
    Me.CtlSeccion1.PuedeNuevo = True
    Me.CtlSeccion1.Size = New System.Drawing.Size(209, 21)
    Me.CtlSeccion1.TabIndex = 0
    '
    'rdopersactsec
    '
    Me.rdopersactsec.Checked = True
    Me.rdopersactsec.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdopersactsec.Location = New System.Drawing.Point(0, 0)
    Me.rdopersactsec.Name = "rdopersactsec"
    Me.rdopersactsec.Size = New System.Drawing.Size(224, 18)
    Me.rdopersactsec.TabIndex = 0
    Me.rdopersactsec.TabStop = True
    Me.rdopersactsec.Text = "Por sección"
    '
    'CtlPeriodo1
    '
    Me.CtlPeriodo1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlPeriodo1.FormattingEnabled = True
    Me.CtlPeriodo1.Location = New System.Drawing.Point(0, 129)
    Me.CtlPeriodo1.Name = "CtlPeriodo1"
    Me.CtlPeriodo1.Op = Nothing
    Me.CtlPeriodo1.PardetPeriodoPago = Nothing
    Me.CtlPeriodo1.PeriodoPago = Nothing
    Me.CtlPeriodo1.PuedeActualizar = True
    Me.CtlPeriodo1.PuedeEliminar = True
    Me.CtlPeriodo1.PuedeModificar = True
    Me.CtlPeriodo1.PuedeNuevo = True
    Me.CtlPeriodo1.Size = New System.Drawing.Size(224, 56)
    Me.CtlPeriodo1.TabIndex = 5
    '
    'CtlPatrono1
    '
    Me.CtlPatrono1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlPatrono1.Location = New System.Drawing.Point(0, 18)
    Me.CtlPatrono1.Name = "CtlPatrono1"
    Me.CtlPatrono1.Op = Nothing
    Me.CtlPatrono1.Patrono = Nothing
    Me.CtlPatrono1.Size = New System.Drawing.Size(224, 56)
    Me.CtlPatrono1.TabIndex = 1
    Me.CtlPatrono1.Usuario = Nothing
    '
    'lblstatus
    '
    Me.lblstatus.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblstatus.Location = New System.Drawing.Point(0, 654)
    Me.lblstatus.Name = "lblstatus"
    Me.lblstatus.Size = New System.Drawing.Size(224, 16)
    Me.lblstatus.TabIndex = 2
    '
    'CtlBuscaEmpleadosPeriodo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Info
    Me.Controls.Add(Me.tvEmpleados)
    Me.Controls.Add(Me.Panel7)
    Me.Controls.Add(Me.pnlpersac)
    Me.Controls.Add(Me.lblstatus)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlBuscaEmpleadosPeriodo"
    Me.Size = New System.Drawing.Size(224, 670)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.pnltipocontrato.ResumeLayout(False)
    Me.Panel7.ResumeLayout(False)
    CType(Me.tvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStrip1.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlpersac.ResumeLayout(False)
    Me.pnlfiltrar.ResumeLayout(False)
    Me.pnlpersentreedad.ResumeLayout(False)
    Me.pnlpersentreedad.PerformLayout()
    Me.pnlsoloclase.ResumeLayout(False)
    Me.pnlseccionfecing.ResumeLayout(False)
    Me.pnlpersactfecing.ResumeLayout(False)
    Me.pnlpersactsec.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents chknograbados As System.Windows.Forms.CheckBox
  Friend WithEvents chksolograbados As System.Windows.Forms.CheckBox
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Friend WithEvents pnltipocontrato As System.Windows.Forms.Panel
  Friend WithEvents CtlTipoContrato1 As CtlTipoContrato
  Friend WithEvents chksolotipocontrato As System.Windows.Forms.CheckBox
  Friend WithEvents btnbuscar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label42 As System.Windows.Forms.Label
  Friend WithEvents Label45 As System.Windows.Forms.Label
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents tvEmpleados As System.Windows.Forms.DataGridView
  Friend WithEvents pnlpersac As System.Windows.Forms.Panel
  Friend WithEvents lblstatus As System.Windows.Forms.Label
  Friend WithEvents CtlPeriodo1 As CtlPeriodo
  Friend WithEvents CtlPatrono1 As CtlPatrono
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnugenerar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents pnlfiltrar As System.Windows.Forms.Panel
  Friend WithEvents pnlfiltrarfin As System.Windows.Forms.Panel
  Friend WithEvents pnlpersentreedad As System.Windows.Forms.Panel
  Friend WithEvents txtedadf As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtedadi As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents chkpersentreedad As System.Windows.Forms.CheckBox
  Friend WithEvents pnlsoloclase As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxClaseEmpleado As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chksoloclase As System.Windows.Forms.CheckBox
  Friend WithEvents pnlseccionfecing As System.Windows.Forms.Panel
  Friend WithEvents pnlseccionfecingfin As System.Windows.Forms.Panel
  Friend WithEvents rdopersacttodos As System.Windows.Forms.RadioButton
  Friend WithEvents pnlpersactfecing As System.Windows.Forms.Panel
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents rdopersactfecing As System.Windows.Forms.RadioButton
  Friend WithEvents pnlpersactsec As System.Windows.Forms.Panel
  Friend WithEvents CtlSeccion1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents rdopersactsec As System.Windows.Forms.RadioButton

End Class
