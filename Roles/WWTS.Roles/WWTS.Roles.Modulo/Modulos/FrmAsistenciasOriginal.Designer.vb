<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsistenciasO
  Inherits Infoware.Consola.Base.FrmFormaBase

  'Form overrides dispose to clean up the component list.
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
    Me.Pnlcuerpo = New System.Windows.Forms.Panel
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.TabControl2 = New System.Windows.Forms.TabControl
    Me.TabPage3 = New System.Windows.Forms.TabPage
    Me.CtlAsistencia1 = New WWTS.Roles.Modulo.CtlAsistencia
    Me.TabPage4 = New System.Windows.Forms.TabPage
    Me.crv_resumenperiodo = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.CtlSeccion1 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.CtlClase1 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.chkno0neto = New System.Windows.Forms.CheckBox
    Me.cbosemana = New System.Windows.Forms.ComboBox
    Me.chksoloclase = New System.Windows.Forms.CheckBox
    Me.btnlistfirmatarea = New System.Windows.Forms.Button
    Me.btnlistfirma = New System.Windows.Forms.Button
    Me.cbosexo = New WWTS.General.Controles.ComboBoxParametroDet
    Me.rdosolosexo = New System.Windows.Forms.RadioButton
    Me.rdotodos = New System.Windows.Forms.RadioButton
    Me.rdosoloseccion = New System.Windows.Forms.RadioButton
    Me.btnlistresumentarea = New System.Windows.Forms.Button
    Me.btnlistresumen = New System.Windows.Forms.Button
    Me.btnexportar = New System.Windows.Forms.Button
    Me.btnrecibosemanal = New System.Windows.Forms.Button
    Me.btnrecibospago = New System.Windows.Forms.Button
    Me.btngenerarlote = New System.Windows.Forms.Button
    Me.btnasisfaltas = New System.Windows.Forms.Button
    Me.btnfaltas = New System.Windows.Forms.Button
    Me.chknoninguncero = New System.Windows.Forms.CheckBox
    Me.TabPage5 = New System.Windows.Forms.TabPage
    Me.crv_contable = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.btnprestquirog = New System.Windows.Forms.Button
    Me.btnmostrarctble = New System.Windows.Forms.Button
    Me.CtlBuscaEmpleadosPeriodo1 = New WWTS.Roles.Modulo.CtlBuscaEmpleadosPeriodo
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.TabControl3 = New System.Windows.Forms.TabControl
    Me.TabPage6 = New System.Windows.Forms.TabPage
    Me.crvcontador = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.CtlClase2 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.CtlPeriodo2 = New WWTS.Roles.Modulo.CtlPeriodo
    Me.CtlPatrono2 = New WWTS.Roles.Modulo.CtlPatrono
    Me.Label1 = New System.Windows.Forms.Label
    Me.btncontador = New System.Windows.Forms.Button
    Me.chksoloclase2 = New System.Windows.Forms.CheckBox
    Me.cbosexo2 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.rdosolosexo2 = New System.Windows.Forms.RadioButton
    Me.rdotodos2 = New System.Windows.Forms.RadioButton
    Me.Label2 = New System.Windows.Forms.Label
    Me.TabPage7 = New System.Windows.Forms.TabPage
    Me.crvgastosporseccion = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.Panel4 = New System.Windows.Forms.Panel
    Me.CtlTipoContrato1 = New WWTS.Roles.Modulo.CtlTipoContrato
    Me.CtlClase3 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.CtlPatrono3 = New WWTS.Roles.Modulo.CtlPatrono
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker
    Me.Label3 = New System.Windows.Forms.Label
    Me.btngastosseccion = New System.Windows.Forms.Button
    Me.chksoloclase3 = New System.Windows.Forms.CheckBox
    Me.cbosexo3 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.rdosolosexo3 = New System.Windows.Forms.RadioButton
    Me.rdotodos3 = New System.Windows.Forms.RadioButton
    Me.Label4 = New System.Windows.Forms.Label
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker
    Me.chksolotipocontrato = New System.Windows.Forms.CheckBox
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.Pnlcuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabControl2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TabControl3.SuspendLayout()
    Me.TabPage6.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.TabPage7.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.TabControl1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(780, 510)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(780, 485)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TabControl2)
    Me.TabPage1.Controls.Add(Me.CtlBuscaEmpleadosPeriodo1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(772, 459)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Generación de pagos de periodo"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabControl2
    '
    Me.TabControl2.Controls.Add(Me.TabPage3)
    Me.TabControl2.Controls.Add(Me.TabPage4)
    Me.TabControl2.Controls.Add(Me.TabPage5)
    Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl2.Location = New System.Drawing.Point(150, 3)
    Me.TabControl2.Name = "TabControl2"
    Me.TabControl2.SelectedIndex = 0
    Me.TabControl2.Size = New System.Drawing.Size(619, 453)
    Me.TabControl2.TabIndex = 1
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.CtlAsistencia1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(611, 427)
    Me.TabPage3.TabIndex = 0
    Me.TabPage3.Text = "Generar periodo"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'CtlAsistencia1
    '
    Me.CtlAsistencia1.Asistencia = Nothing
    Me.CtlAsistencia1.Contrato = Nothing
    Me.CtlAsistencia1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlAsistencia1.Empleado = Nothing
    Me.CtlAsistencia1.Enabled = False
    Me.CtlAsistencia1.Location = New System.Drawing.Point(3, 3)
    Me.CtlAsistencia1.Name = "CtlAsistencia1"
    Me.CtlAsistencia1.Op = Nothing
    Me.CtlAsistencia1.patrono = Nothing
    Me.CtlAsistencia1.Periodo = Nothing
    Me.CtlAsistencia1.Size = New System.Drawing.Size(605, 421)
    Me.CtlAsistencia1.TabIndex = 0
    Me.CtlAsistencia1.TipoContrato = Nothing
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.crv_resumenperiodo)
    Me.TabPage4.Controls.Add(Me.Panel1)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(611, 427)
    Me.TabPage4.TabIndex = 1
    Me.TabPage4.Text = "Resumen de periodo"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'crv_resumenperiodo
    '
    Me.crv_resumenperiodo.ActiveViewIndex = -1
    Me.crv_resumenperiodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    'Me.crv_resumenperiodo.DisplayGroupTree = False
    Me.crv_resumenperiodo.DisplayStatusBar = False
    Me.crv_resumenperiodo.DisplayToolbar = False
    Me.crv_resumenperiodo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crv_resumenperiodo.Location = New System.Drawing.Point(3, 146)
    Me.crv_resumenperiodo.Name = "crv_resumenperiodo"
    Me.crv_resumenperiodo.SelectionFormula = ""
    Me.crv_resumenperiodo.Size = New System.Drawing.Size(605, 278)
    Me.crv_resumenperiodo.TabIndex = 2
    Me.crv_resumenperiodo.ViewTimeSelectionFormula = ""
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlSeccion1)
    Me.Panel1.Controls.Add(Me.CtlClase1)
    Me.Panel1.Controls.Add(Me.chkno0neto)
    Me.Panel1.Controls.Add(Me.cbosemana)
    Me.Panel1.Controls.Add(Me.chksoloclase)
    Me.Panel1.Controls.Add(Me.btnlistfirmatarea)
    Me.Panel1.Controls.Add(Me.btnlistfirma)
    Me.Panel1.Controls.Add(Me.cbosexo)
    Me.Panel1.Controls.Add(Me.rdosolosexo)
    Me.Panel1.Controls.Add(Me.rdotodos)
    Me.Panel1.Controls.Add(Me.rdosoloseccion)
    Me.Panel1.Controls.Add(Me.btnlistresumentarea)
    Me.Panel1.Controls.Add(Me.btnlistresumen)
    Me.Panel1.Controls.Add(Me.btnexportar)
    Me.Panel1.Controls.Add(Me.btnrecibosemanal)
    Me.Panel1.Controls.Add(Me.btnrecibospago)
    Me.Panel1.Controls.Add(Me.btngenerarlote)
    Me.Panel1.Controls.Add(Me.btnasisfaltas)
    Me.Panel1.Controls.Add(Me.btnfaltas)
    Me.Panel1.Controls.Add(Me.chknoninguncero)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(605, 143)
    Me.Panel1.TabIndex = 1
    '
    'CtlSeccion1
    '
    Me.CtlSeccion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSeccion1.Enabled = False
    Me.CtlSeccion1.FormattingEnabled = True
    Me.CtlSeccion1.Location = New System.Drawing.Point(196, 23)
    Me.CtlSeccion1.Name = "CtlSeccion1"
    Me.CtlSeccion1.OperadorDatos = Nothing
    Me.CtlSeccion1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlSeccion1.ParametroDet = Nothing
    Me.CtlSeccion1.PuedeActualizar = True
    Me.CtlSeccion1.PuedeEliminar = True
    Me.CtlSeccion1.PuedeModificar = True
    Me.CtlSeccion1.PuedeNuevo = True
    Me.CtlSeccion1.Size = New System.Drawing.Size(144, 21)
    Me.CtlSeccion1.TabIndex = 2
    '
    'CtlClase1
    '
    Me.CtlClase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlClase1.Enabled = False
    Me.CtlClase1.FormattingEnabled = True
    Me.CtlClase1.Location = New System.Drawing.Point(196, 63)
    Me.CtlClase1.Name = "CtlClase1"
    Me.CtlClase1.OperadorDatos = Nothing
    Me.CtlClase1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlClase1.ParametroDet = Nothing
    Me.CtlClase1.PuedeActualizar = True
    Me.CtlClase1.PuedeEliminar = True
    Me.CtlClase1.PuedeModificar = True
    Me.CtlClase1.PuedeNuevo = True
    Me.CtlClase1.Size = New System.Drawing.Size(144, 21)
    Me.CtlClase1.TabIndex = 6
    '
    'chkno0neto
    '
    Me.chkno0neto.AutoSize = True
    Me.chkno0neto.Location = New System.Drawing.Point(5, 89)
    Me.chkno0neto.Margin = New System.Windows.Forms.Padding(2)
    Me.chkno0neto.Name = "chkno0neto"
    Me.chkno0neto.Size = New System.Drawing.Size(347, 17)
    Me.chkno0neto.TabIndex = 7
    Me.chkno0neto.Text = "No mostrar ceros (Excepto cuando después de descuentos sea = 0)"
    '
    'cbosemana
    '
    Me.cbosemana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbosemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbosemana.Items.AddRange(New Object() {"Primera semana", "Segunda semana"})
    Me.cbosemana.Location = New System.Drawing.Point(489, 4)
    Me.cbosemana.Name = "cbosemana"
    Me.cbosemana.Size = New System.Drawing.Size(108, 21)
    Me.cbosemana.TabIndex = 12
    '
    'chksoloclase
    '
    Me.chksoloclase.AutoSize = True
    Me.chksoloclase.Location = New System.Drawing.Point(5, 68)
    Me.chksoloclase.Name = "chksoloclase"
    Me.chksoloclase.Size = New System.Drawing.Size(155, 17)
    Me.chksoloclase.TabIndex = 5
    Me.chksoloclase.Text = "Sólo empleados de la clase"
    '
    'btnlistfirmatarea
    '
    Me.btnlistfirmatarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnlistfirmatarea.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlistfirmatarea.Location = New System.Drawing.Point(373, 26)
    Me.btnlistfirmatarea.Name = "btnlistfirmatarea"
    Me.btnlistfirmatarea.Size = New System.Drawing.Size(113, 23)
    Me.btnlistfirmatarea.TabIndex = 9
    Me.btnlistfirmatarea.Text = "Listado firmas tarea"
    '
    'btnlistfirma
    '
    Me.btnlistfirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnlistfirma.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlistfirma.Location = New System.Drawing.Point(373, 4)
    Me.btnlistfirma.Name = "btnlistfirma"
    Me.btnlistfirma.Size = New System.Drawing.Size(113, 23)
    Me.btnlistfirma.TabIndex = 9
    Me.btnlistfirma.Text = "Listado firmas"
    '
    'cbosexo
    '
    Me.cbosexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbosexo.Enabled = False
    Me.cbosexo.ItemHeight = 13
    Me.cbosexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
    Me.cbosexo.Location = New System.Drawing.Point(196, 43)
    Me.cbosexo.Name = "cbosexo"
    Me.cbosexo.OperadorDatos = Nothing
    Me.cbosexo.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbosexo.ParametroDet = Nothing
    Me.cbosexo.PuedeActualizar = True
    Me.cbosexo.PuedeEliminar = True
    Me.cbosexo.PuedeModificar = True
    Me.cbosexo.PuedeNuevo = True
    Me.cbosexo.Size = New System.Drawing.Size(144, 21)
    Me.cbosexo.TabIndex = 4
    '
    'rdosolosexo
    '
    Me.rdosolosexo.AutoSize = True
    Me.rdosolosexo.Location = New System.Drawing.Point(5, 44)
    Me.rdosolosexo.Name = "rdosolosexo"
    Me.rdosolosexo.Size = New System.Drawing.Size(159, 17)
    Me.rdosolosexo.TabIndex = 3
    Me.rdosolosexo.Text = "Sólo los empleados de sexo "
    '
    'rdotodos
    '
    Me.rdotodos.AutoSize = True
    Me.rdotodos.Checked = True
    Me.rdotodos.Location = New System.Drawing.Point(5, 7)
    Me.rdotodos.Name = "rdotodos"
    Me.rdotodos.Size = New System.Drawing.Size(89, 17)
    Me.rdotodos.TabIndex = 0
    Me.rdotodos.TabStop = True
    Me.rdotodos.Text = "Mostrar todos"
    '
    'rdosoloseccion
    '
    Me.rdosoloseccion.AutoSize = True
    Me.rdosoloseccion.Location = New System.Drawing.Point(5, 26)
    Me.rdosoloseccion.Name = "rdosoloseccion"
    Me.rdosoloseccion.Size = New System.Drawing.Size(182, 17)
    Me.rdosoloseccion.TabIndex = 1
    Me.rdosoloseccion.Text = "Sólo los empleados de la sección"
    '
    'btnlistresumentarea
    '
    Me.btnlistresumentarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnlistresumentarea.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlistresumentarea.Location = New System.Drawing.Point(373, 70)
    Me.btnlistresumentarea.Name = "btnlistresumentarea"
    Me.btnlistresumentarea.Size = New System.Drawing.Size(113, 23)
    Me.btnlistresumentarea.TabIndex = 10
    Me.btnlistresumentarea.Text = "Listado resumen tarea"
    '
    'btnlistresumen
    '
    Me.btnlistresumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnlistresumen.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlistresumen.Location = New System.Drawing.Point(373, 48)
    Me.btnlistresumen.Name = "btnlistresumen"
    Me.btnlistresumen.Size = New System.Drawing.Size(113, 23)
    Me.btnlistresumen.TabIndex = 10
    Me.btnlistresumen.Text = "Listado resumen"
    '
    'btnexportar
    '
    Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnexportar.Location = New System.Drawing.Point(373, 114)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(113, 23)
    Me.btnexportar.TabIndex = 16
    Me.btnexportar.Text = "Exportar resumen"
    '
    'btnrecibosemanal
    '
    Me.btnrecibosemanal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnrecibosemanal.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnrecibosemanal.Location = New System.Drawing.Point(490, 92)
    Me.btnrecibosemanal.Name = "btnrecibosemanal"
    Me.btnrecibosemanal.Size = New System.Drawing.Size(112, 23)
    Me.btnrecibosemanal.TabIndex = 15
    Me.btnrecibosemanal.Text = "Recibos semanales"
    '
    'btnrecibospago
    '
    Me.btnrecibospago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnrecibospago.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnrecibospago.Location = New System.Drawing.Point(490, 70)
    Me.btnrecibospago.Name = "btnrecibospago"
    Me.btnrecibospago.Size = New System.Drawing.Size(112, 23)
    Me.btnrecibospago.TabIndex = 15
    Me.btnrecibospago.Text = "Recibos pago"
    '
    'btngenerarlote
    '
    Me.btngenerarlote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btngenerarlote.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btngenerarlote.Location = New System.Drawing.Point(373, 92)
    Me.btngenerarlote.Name = "btngenerarlote"
    Me.btngenerarlote.Size = New System.Drawing.Size(113, 23)
    Me.btngenerarlote.TabIndex = 11
    Me.btngenerarlote.Text = "Generar pagos"
    '
    'btnasisfaltas
    '
    Me.btnasisfaltas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnasisfaltas.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnasisfaltas.Location = New System.Drawing.Point(490, 26)
    Me.btnasisfaltas.Name = "btnasisfaltas"
    Me.btnasisfaltas.Size = New System.Drawing.Size(112, 23)
    Me.btnasisfaltas.TabIndex = 13
    Me.btnasisfaltas.Text = "Listado asistencias"
    '
    'btnfaltas
    '
    Me.btnfaltas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnfaltas.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnfaltas.Location = New System.Drawing.Point(490, 48)
    Me.btnfaltas.Name = "btnfaltas"
    Me.btnfaltas.Size = New System.Drawing.Size(112, 23)
    Me.btnfaltas.TabIndex = 14
    Me.btnfaltas.Text = "Listado faltas"
    '
    'chknoninguncero
    '
    Me.chknoninguncero.AutoSize = True
    Me.chknoninguncero.Location = New System.Drawing.Point(5, 110)
    Me.chknoninguncero.Margin = New System.Windows.Forms.Padding(2)
    Me.chknoninguncero.Name = "chknoninguncero"
    Me.chknoninguncero.Size = New System.Drawing.Size(185, 17)
    Me.chknoninguncero.TabIndex = 8
    Me.chknoninguncero.Text = "No mostrar ningún sueldo en cero"
    '
    'TabPage5
    '
    Me.TabPage5.Controls.Add(Me.crv_contable)
    Me.TabPage5.Controls.Add(Me.Panel2)
    Me.TabPage5.Location = New System.Drawing.Point(4, 22)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage5.Size = New System.Drawing.Size(611, 427)
    Me.TabPage5.TabIndex = 2
    Me.TabPage5.Text = "Otros reportes"
    Me.TabPage5.UseVisualStyleBackColor = True
    '
    'crv_contable
    '
    Me.crv_contable.ActiveViewIndex = -1
    Me.crv_contable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    'Me.crv_contable.DisplayGroupTree = False
    Me.crv_contable.DisplayStatusBar = False
    Me.crv_contable.DisplayToolbar = False
    Me.crv_contable.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crv_contable.Location = New System.Drawing.Point(3, 35)
    Me.crv_contable.Name = "crv_contable"
    Me.crv_contable.SelectionFormula = ""
    Me.crv_contable.Size = New System.Drawing.Size(605, 389)
    Me.crv_contable.TabIndex = 4
    Me.crv_contable.ViewTimeSelectionFormula = ""
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btnprestquirog)
    Me.Panel2.Controls.Add(Me.btnmostrarctble)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(3, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(605, 32)
    Me.Panel2.TabIndex = 3
    '
    'btnprestquirog
    '
    Me.btnprestquirog.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnprestquirog.Location = New System.Drawing.Point(135, 4)
    Me.btnprestquirog.Name = "btnprestquirog"
    Me.btnprestquirog.Size = New System.Drawing.Size(205, 23)
    Me.btnprestquirog.TabIndex = 0
    Me.btnprestquirog.Text = "&Listado de préstamos quirografarios"
    '
    'btnmostrarctble
    '
    Me.btnmostrarctble.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrarctble.Location = New System.Drawing.Point(8, 4)
    Me.btnmostrarctble.Name = "btnmostrarctble"
    Me.btnmostrarctble.Size = New System.Drawing.Size(121, 23)
    Me.btnmostrarctble.TabIndex = 0
    Me.btnmostrarctble.Text = "&Resumen contable"
    '
    'CtlBuscaEmpleadosPeriodo1
    '
    Me.CtlBuscaEmpleadosPeriodo1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleadosPeriodo1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleadosPeriodo1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaEmpleadosPeriodo1.Name = "CtlBuscaEmpleadosPeriodo1"
    Me.CtlBuscaEmpleadosPeriodo1.Op = Nothing
    Me.CtlBuscaEmpleadosPeriodo1.Size = New System.Drawing.Size(147, 453)
    Me.CtlBuscaEmpleadosPeriodo1.TabIndex = 0
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.TabControl3)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(772, 459)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Otros listados"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'TabControl3
    '
    Me.TabControl3.Controls.Add(Me.TabPage6)
    Me.TabControl3.Controls.Add(Me.TabPage7)
    Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl3.Location = New System.Drawing.Point(3, 3)
    Me.TabControl3.Name = "TabControl3"
    Me.TabControl3.SelectedIndex = 0
    Me.TabControl3.Size = New System.Drawing.Size(766, 453)
    Me.TabControl3.TabIndex = 0
    '
    'TabPage6
    '
    Me.TabPage6.Controls.Add(Me.crvcontador)
    Me.TabPage6.Controls.Add(Me.Panel3)
    Me.TabPage6.Location = New System.Drawing.Point(4, 22)
    Me.TabPage6.Name = "TabPage6"
    Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage6.Size = New System.Drawing.Size(758, 427)
    Me.TabPage6.TabIndex = 0
    Me.TabPage6.Text = "Contador de personal"
    Me.TabPage6.UseVisualStyleBackColor = True
    '
    'crvcontador
    '
    Me.crvcontador.ActiveViewIndex = -1
    Me.crvcontador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    'Me.crvcontador.DisplayGroupTree = False
    Me.crvcontador.DisplayStatusBar = False
    Me.crvcontador.DisplayToolbar = False
    Me.crvcontador.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvcontador.Location = New System.Drawing.Point(3, 107)
    Me.crvcontador.Name = "crvcontador"
    Me.crvcontador.SelectionFormula = ""
    Me.crvcontador.Size = New System.Drawing.Size(752, 317)
    Me.crvcontador.TabIndex = 2
    Me.crvcontador.ViewTimeSelectionFormula = ""
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.CtlClase2)
    Me.Panel3.Controls.Add(Me.CtlPeriodo2)
    Me.Panel3.Controls.Add(Me.CtlPatrono2)
    Me.Panel3.Controls.Add(Me.Label1)
    Me.Panel3.Controls.Add(Me.btncontador)
    Me.Panel3.Controls.Add(Me.chksoloclase2)
    Me.Panel3.Controls.Add(Me.cbosexo2)
    Me.Panel3.Controls.Add(Me.rdosolosexo2)
    Me.Panel3.Controls.Add(Me.rdotodos2)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(3, 3)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(752, 104)
    Me.Panel3.TabIndex = 1
    '
    'CtlClase2
    '
    Me.CtlClase2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlClase2.FormattingEnabled = True
    Me.CtlClase2.Location = New System.Drawing.Point(468, 46)
    Me.CtlClase2.Name = "CtlClase2"
    Me.CtlClase2.OperadorDatos = Nothing
    Me.CtlClase2.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlClase2.ParametroDet = Nothing
    Me.CtlClase2.PuedeActualizar = True
    Me.CtlClase2.PuedeEliminar = True
    Me.CtlClase2.PuedeModificar = True
    Me.CtlClase2.PuedeNuevo = True
    Me.CtlClase2.Size = New System.Drawing.Size(144, 21)
    Me.CtlClase2.TabIndex = 18
    '
    'CtlPeriodo2
    '
    Me.CtlPeriodo2.FormattingEnabled = True
    Me.CtlPeriodo2.Location = New System.Drawing.Point(167, 19)
    Me.CtlPeriodo2.Name = "CtlPeriodo2"
    Me.CtlPeriodo2.Op = Nothing
    Me.CtlPeriodo2.PardetPeriodoPago = Nothing
    Me.CtlPeriodo2.PeriodoPago = Nothing
    Me.CtlPeriodo2.PuedeActualizar = True
    Me.CtlPeriodo2.PuedeEliminar = True
    Me.CtlPeriodo2.PuedeModificar = True
    Me.CtlPeriodo2.PuedeNuevo = True
    Me.CtlPeriodo2.Size = New System.Drawing.Size(121, 82)
    Me.CtlPeriodo2.TabIndex = 17
    '
    'CtlPatrono2
    '
    Me.CtlPatrono2.Location = New System.Drawing.Point(7, 20)
    Me.CtlPatrono2.Name = "CtlPatrono2"
    Me.CtlPatrono2.Op = Nothing
    Me.CtlPatrono2.Patrono = Nothing
    Me.CtlPatrono2.Size = New System.Drawing.Size(154, 81)
    Me.CtlPatrono2.TabIndex = 16
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(4, 4)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(152, 16)
    Me.Label1.TabIndex = 15
    Me.Label1.Text = "Patrono"
    '
    'btncontador
    '
    Me.btncontador.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btncontador.Location = New System.Drawing.Point(300, 72)
    Me.btncontador.Name = "btncontador"
    Me.btncontador.Size = New System.Drawing.Size(75, 23)
    Me.btncontador.TabIndex = 13
    Me.btncontador.Text = "Mostrar"
    '
    'chksoloclase2
    '
    Me.chksoloclase2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksoloclase2.Location = New System.Drawing.Point(300, 48)
    Me.chksoloclase2.Name = "chksoloclase2"
    Me.chksoloclase2.Size = New System.Drawing.Size(172, 16)
    Me.chksoloclase2.TabIndex = 10
    Me.chksoloclase2.Text = "Sólo empleados de la clase"
    '
    'cbosexo2
    '
    Me.cbosexo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbosexo2.Enabled = False
    Me.cbosexo2.ItemHeight = 13
    Me.cbosexo2.Items.AddRange(New Object() {"Masculino", "Femenino"})
    Me.cbosexo2.Location = New System.Drawing.Point(468, 20)
    Me.cbosexo2.Name = "cbosexo2"
    Me.cbosexo2.OperadorDatos = Nothing
    Me.cbosexo2.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbosexo2.ParametroDet = Nothing
    Me.cbosexo2.PuedeActualizar = True
    Me.cbosexo2.PuedeEliminar = True
    Me.cbosexo2.PuedeModificar = True
    Me.cbosexo2.PuedeNuevo = True
    Me.cbosexo2.Size = New System.Drawing.Size(144, 21)
    Me.cbosexo2.TabIndex = 9
    '
    'rdosolosexo2
    '
    Me.rdosolosexo2.Location = New System.Drawing.Point(300, 24)
    Me.rdosolosexo2.Name = "rdosolosexo2"
    Me.rdosolosexo2.Size = New System.Drawing.Size(168, 16)
    Me.rdosolosexo2.TabIndex = 8
    Me.rdosolosexo2.Text = "Sólo los empleados de sexo "
    '
    'rdotodos2
    '
    Me.rdotodos2.Checked = True
    Me.rdotodos2.Location = New System.Drawing.Point(300, 4)
    Me.rdotodos2.Name = "rdotodos2"
    Me.rdotodos2.Size = New System.Drawing.Size(120, 16)
    Me.rdotodos2.TabIndex = 7
    Me.rdotodos2.TabStop = True
    Me.rdotodos2.Text = "Mostrar todos"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(164, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(124, 16)
    Me.Label2.TabIndex = 15
    Me.Label2.Text = "Periodo"
    '
    'TabPage7
    '
    Me.TabPage7.Controls.Add(Me.crvgastosporseccion)
    Me.TabPage7.Controls.Add(Me.Panel4)
    Me.TabPage7.Location = New System.Drawing.Point(4, 22)
    Me.TabPage7.Name = "TabPage7"
    Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage7.Size = New System.Drawing.Size(758, 427)
    Me.TabPage7.TabIndex = 1
    Me.TabPage7.Text = "Análisis de gastos por sección"
    Me.TabPage7.UseVisualStyleBackColor = True
    '
    'crvgastosporseccion
    '
    Me.crvgastosporseccion.ActiveViewIndex = -1
    Me.crvgastosporseccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    'Me.crvgastosporseccion.DisplayGroupTree = False
    Me.crvgastosporseccion.DisplayStatusBar = False
    Me.crvgastosporseccion.DisplayToolbar = False
    Me.crvgastosporseccion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvgastosporseccion.Location = New System.Drawing.Point(3, 107)
    Me.crvgastosporseccion.Name = "crvgastosporseccion"
    Me.crvgastosporseccion.SelectionFormula = ""
    Me.crvgastosporseccion.Size = New System.Drawing.Size(752, 317)
    Me.crvgastosporseccion.TabIndex = 2
    Me.crvgastosporseccion.ViewTimeSelectionFormula = ""
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.CtlTipoContrato1)
    Me.Panel4.Controls.Add(Me.CtlClase3)
    Me.Panel4.Controls.Add(Me.CtlPatrono3)
    Me.Panel4.Controls.Add(Me.dtfecdesde)
    Me.Panel4.Controls.Add(Me.Label3)
    Me.Panel4.Controls.Add(Me.btngastosseccion)
    Me.Panel4.Controls.Add(Me.chksoloclase3)
    Me.Panel4.Controls.Add(Me.cbosexo3)
    Me.Panel4.Controls.Add(Me.rdosolosexo3)
    Me.Panel4.Controls.Add(Me.rdotodos3)
    Me.Panel4.Controls.Add(Me.Label4)
    Me.Panel4.Controls.Add(Me.dtfechasta)
    Me.Panel4.Controls.Add(Me.chksolotipocontrato)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel4.Location = New System.Drawing.Point(3, 3)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(752, 104)
    Me.Panel4.TabIndex = 1
    '
    'CtlTipoContrato1
    '
    Me.CtlTipoContrato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlTipoContrato1.FormattingEnabled = True
    Me.CtlTipoContrato1.Location = New System.Drawing.Point(456, 70)
    Me.CtlTipoContrato1.Name = "CtlTipoContrato1"
    Me.CtlTipoContrato1.Op = Nothing
    Me.CtlTipoContrato1.PuedeActualizar = True
    Me.CtlTipoContrato1.PuedeEliminar = True
    Me.CtlTipoContrato1.PuedeModificar = True
    Me.CtlTipoContrato1.PuedeNuevo = True
    Me.CtlTipoContrato1.Size = New System.Drawing.Size(144, 21)
    Me.CtlTipoContrato1.TabIndex = 14
    Me.CtlTipoContrato1.TipoContrato = Nothing
    '
    'CtlClase3
    '
    Me.CtlClase3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlClase3.FormattingEnabled = True
    Me.CtlClase3.Location = New System.Drawing.Point(456, 45)
    Me.CtlClase3.Name = "CtlClase3"
    Me.CtlClase3.OperadorDatos = Nothing
    Me.CtlClase3.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlClase3.ParametroDet = Nothing
    Me.CtlClase3.PuedeActualizar = True
    Me.CtlClase3.PuedeEliminar = True
    Me.CtlClase3.PuedeModificar = True
    Me.CtlClase3.PuedeNuevo = True
    Me.CtlClase3.Size = New System.Drawing.Size(144, 21)
    Me.CtlClase3.TabIndex = 13
    '
    'CtlPatrono3
    '
    Me.CtlPatrono3.Location = New System.Drawing.Point(7, 20)
    Me.CtlPatrono3.Name = "CtlPatrono3"
    Me.CtlPatrono3.Op = Nothing
    Me.CtlPatrono3.Patrono = Nothing
    Me.CtlPatrono3.Size = New System.Drawing.Size(151, 81)
    Me.CtlPatrono3.TabIndex = 12
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(164, 20)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(116, 20)
    Me.dtfecdesde.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(4, 4)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(152, 16)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Patrono"
    '
    'btngastosseccion
    '
    Me.btngastosseccion.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btngastosseccion.Location = New System.Drawing.Point(168, 72)
    Me.btngastosseccion.Name = "btngastosseccion"
    Me.btngastosseccion.Size = New System.Drawing.Size(75, 23)
    Me.btngastosseccion.TabIndex = 5
    Me.btngastosseccion.Text = "Mostrar"
    '
    'chksoloclase3
    '
    Me.chksoloclase3.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksoloclase3.Location = New System.Drawing.Point(288, 48)
    Me.chksoloclase3.Name = "chksoloclase3"
    Me.chksoloclase3.Size = New System.Drawing.Size(164, 16)
    Me.chksoloclase3.TabIndex = 9
    Me.chksoloclase3.Text = "Sólo empleados de la clase"
    '
    'cbosexo3
    '
    Me.cbosexo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbosexo3.Enabled = False
    Me.cbosexo3.ItemHeight = 13
    Me.cbosexo3.Items.AddRange(New Object() {"Masculino", "Femenino"})
    Me.cbosexo3.Location = New System.Drawing.Point(456, 20)
    Me.cbosexo3.Name = "cbosexo3"
    Me.cbosexo3.OperadorDatos = Nothing
    Me.cbosexo3.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbosexo3.ParametroDet = Nothing
    Me.cbosexo3.PuedeActualizar = True
    Me.cbosexo3.PuedeEliminar = True
    Me.cbosexo3.PuedeModificar = True
    Me.cbosexo3.PuedeNuevo = True
    Me.cbosexo3.Size = New System.Drawing.Size(144, 21)
    Me.cbosexo3.TabIndex = 8
    '
    'rdosolosexo3
    '
    Me.rdosolosexo3.Location = New System.Drawing.Point(288, 24)
    Me.rdosolosexo3.Name = "rdosolosexo3"
    Me.rdosolosexo3.Size = New System.Drawing.Size(168, 16)
    Me.rdosolosexo3.TabIndex = 7
    Me.rdosolosexo3.Text = "Sólo los empleados de sexo "
    '
    'rdotodos3
    '
    Me.rdotodos3.Checked = True
    Me.rdotodos3.Location = New System.Drawing.Point(288, 8)
    Me.rdotodos3.Name = "rdotodos3"
    Me.rdotodos3.Size = New System.Drawing.Size(120, 16)
    Me.rdotodos3.TabIndex = 6
    Me.rdotodos3.TabStop = True
    Me.rdotodos3.Text = "Mostrar todos"
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(164, 4)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(116, 16)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Rango de fechas:"
    '
    'dtfechasta
    '
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(164, 44)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(116, 20)
    Me.dtfechasta.TabIndex = 4
    '
    'chksolotipocontrato
    '
    Me.chksolotipocontrato.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chksolotipocontrato.Location = New System.Drawing.Point(288, 72)
    Me.chksolotipocontrato.Name = "chksolotipocontrato"
    Me.chksolotipocontrato.Size = New System.Drawing.Size(164, 16)
    Me.chksolotipocontrato.TabIndex = 11
    Me.chksolotipocontrato.Text = "Sólo este tipo de contrato"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(780, 25)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(178, 22)
    Me.ToolStripLabel1.Text = "Registro de asistencia"
    '
    'FrmAsistencias
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(780, 510)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Name = "FrmAsistencias"
    Me.Text = "Registro de asistencia"
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabControl2.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage4.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.TabPage5.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.TabControl3.ResumeLayout(False)
    Me.TabPage6.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.TabPage7.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaEmpleadosPeriodo1 As CtlBuscaEmpleadosPeriodo
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents CtlAsistencia1 As CtlAsistencia
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlClase1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlSeccion1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chkno0neto As System.Windows.Forms.CheckBox
  Friend WithEvents cbosemana As System.Windows.Forms.ComboBox
  Friend WithEvents chksoloclase As System.Windows.Forms.CheckBox
  Friend WithEvents btnlistfirma As System.Windows.Forms.Button
  Friend WithEvents cbosexo As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents rdosolosexo As System.Windows.Forms.RadioButton
  Friend WithEvents rdotodos As System.Windows.Forms.RadioButton
  Friend WithEvents rdosoloseccion As System.Windows.Forms.RadioButton
  Friend WithEvents btnlistresumen As System.Windows.Forms.Button
  Friend WithEvents btnrecibospago As System.Windows.Forms.Button
  Friend WithEvents btngenerarlote As System.Windows.Forms.Button
  Friend WithEvents btnasisfaltas As System.Windows.Forms.Button
  Friend WithEvents btnfaltas As System.Windows.Forms.Button
  Friend WithEvents chknoninguncero As System.Windows.Forms.CheckBox
  Friend WithEvents crv_resumenperiodo As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents crv_contable As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents btnmostrarctble As System.Windows.Forms.Button
  Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents CtlClase2 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlPeriodo2 As CtlPeriodo
  Friend WithEvents CtlPatrono2 As CtlPatrono
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btncontador As System.Windows.Forms.Button
  Friend WithEvents chksoloclase2 As System.Windows.Forms.CheckBox
  Friend WithEvents cbosexo2 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents rdosolosexo2 As System.Windows.Forms.RadioButton
  Friend WithEvents rdotodos2 As System.Windows.Forms.RadioButton
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents CtlClase3 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlPatrono3 As CtlPatrono
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btngastosseccion As System.Windows.Forms.Button
  Friend WithEvents chksoloclase3 As System.Windows.Forms.CheckBox
  Friend WithEvents cbosexo3 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents rdosolosexo3 As System.Windows.Forms.RadioButton
  Friend WithEvents rdotodos3 As System.Windows.Forms.RadioButton
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents chksolotipocontrato As System.Windows.Forms.CheckBox
  Friend WithEvents crvcontador As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents crvgastosporseccion As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents CtlTipoContrato1 As CtlTipoContrato
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents btnprestquirog As System.Windows.Forms.Button
  Friend WithEvents btnrecibosemanal As System.Windows.Forms.Button
  Friend WithEvents btnlistfirmatarea As System.Windows.Forms.Button
  Friend WithEvents btnlistresumentarea As System.Windows.Forms.Button
End Class
