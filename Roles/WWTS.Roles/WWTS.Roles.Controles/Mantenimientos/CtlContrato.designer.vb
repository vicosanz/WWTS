<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlContrato
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlContrato))
    Me.tvcontratos = New System.Windows.Forms.TreeView()
    Me.ilestadocontrato = New System.Windows.Forms.ImageList(Me.components)
    Me.tb = New System.Windows.Forms.TabControl()
    Me.TabDatos = New System.Windows.Forms.TabPage()
    Me.pnldatos = New System.Windows.Forms.Panel()
    Me.LnkSeleccion = New System.Windows.Forms.LinkLabel()
    Me.pnlcierre = New System.Windows.Forms.Panel()
    Me.lblfeccierre = New System.Windows.Forms.Label()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.cbotipoliq = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cbotiposalida = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.chkMensualizarVac = New System.Windows.Forms.CheckBox()
    Me.chkMensualizarFR = New System.Windows.Forms.CheckBox()
    Me.chkMensualizarD4 = New System.Windows.Forms.CheckBox()
    Me.chkMensualizarD3 = New System.Windows.Forms.CheckBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
        Me.CtlTipoContrato1 = New WWTS.Roles.Controles.CtlTipoContrato()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
        Me.Cerrado = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboSubCentroCosto = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.CtlPatronoCombo1 = New WWTS.Roles.Controles.CtlPatronoCombo()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboDepartamento = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.CtlArea1 = New WWTS.Roles.Controles.CtlArea()
        Me.cboSeccion = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.CtlCargo1 = New WWTS.Roles.Controles.CtlCargo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabOtros = New System.Windows.Forms.TabPage()
        Me.pnlotros = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxEstadoContrato = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
        Me.chkDescontarir = New System.Windows.Forms.CheckBox()
        Me.ComboBoxSucursal1 = New WWTS.General.Controles.ComboBoxSucursal()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxEmpresa1 = New WWTS.General.Controles.ComboBoxEmpresa()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabObservaciones = New System.Windows.Forms.TabPage()
        Me.dtfecafiliess = New System.Windows.Forms.DateTimePicker()
        Me.chkreglamentointerno = New System.Windows.Forms.CheckBox()
        Me.chkrecordpolicial = New System.Windows.Forms.CheckBox()
        Me.chkcertvot = New System.Windows.Forms.CheckBox()
        Me.chkcertsalud = New System.Windows.Forms.CheckBox()
        Me.chkafiliess = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.chkpertsind = New System.Windows.Forms.CheckBox()
        Me.chkjuicio = New System.Windows.Forms.CheckBox()
        Me.txtmotsal = New Infoware.Controles.Base.TextBoxStd()
        Me.TabRubros = New System.Windows.Forms.TabPage()
        Me.pnlrubros = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn362 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSrubro = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn366 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnuevorubro = New System.Windows.Forms.ToolStripButton()
        Me.btnabrirrubro = New System.Windows.Forms.ToolStripButton()
        Me.btneliminarrubro = New System.Windows.Forms.ToolStripButton()
        Me.TabEvaluaciones = New System.Windows.Forms.TabPage()
        Me.txtevaanual = New Infoware.Controles.Base.TextBoxCalculator()
        Me.txtevatrimestral = New Infoware.Controles.Base.TextBoxCalculator()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CtlAdjunto1 = New WWTS.General.Controles.CtlAdjunto()
        Me.TabLlamadas = New System.Windows.Forms.TabPage()
        Me.pnlLlamadas = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn363 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSLlamadaAtencion = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn367 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderStrip3 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnuevollamado = New System.Windows.Forms.ToolStripButton()
        Me.btnabrirllamado = New System.Windows.Forms.ToolStripButton()
        Me.btneliminarllamado = New System.Windows.Forms.ToolStripButton()
        Me.btnimprimirllamado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnuevomulta = New System.Windows.Forms.ToolStripButton()
        Me.TabVacacion = New System.Windows.Forms.TabPage()
        Me.CtlPeriodoVacacion1 = New WWTS.Roles.Controles.CtlPeriodoVacacion()
        Me.TabLicencias = New System.Windows.Forms.TabPage()
        Me.pnlLicencias = New System.Windows.Forms.Panel()
        Me.DataGridView5 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn364 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSLicencia = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn368 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderStrip4 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnuevolicencia = New System.Windows.Forms.ToolStripButton()
        Me.btnabrirlicencia = New System.Windows.Forms.ToolStripButton()
        Me.btneliminarlicencia = New System.Windows.Forms.ToolStripButton()
        Me.btnimprimirlicencia = New System.Windows.Forms.ToolStripButton()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.BSauditorias = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabSueldos = New System.Windows.Forms.TabPage()
        Me.dgsueldos = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn365 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSSueldos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn369 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderStrip5 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSueldosExcel = New System.Windows.Forms.ToolStripButton()
        Me.btn_FondosReserva = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn358 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn359 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn360 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn361 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn354 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn355 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn356 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn357 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn350 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn351 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn352 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn353 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn346 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn347 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn348 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn349 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn342 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn343 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn344 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn345 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn338 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn339 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn340 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn341 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn334 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn335 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn336 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn337 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn330 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn331 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn332 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn333 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn326 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn327 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn328 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn329 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn322 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn323 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn324 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn325 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn318 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn319 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn320 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn321 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn314 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn315 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn316 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn317 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn310 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn311 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn312 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn313 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn306 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn307 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn308 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn309 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn302 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn303 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn304 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn305 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn298 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn299 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn300 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn301 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn294 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn295 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn296 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn297 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn290 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn291 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn292 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn293 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn286 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn287 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn288 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn289 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn282 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn283 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn284 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn285 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn278 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn279 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn280 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn281 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn274 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn275 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn276 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn277 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn270 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn271 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn272 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn273 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn266 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn267 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn268 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn269 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn262 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn263 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn264 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn265 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn257 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn258 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn259 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn254 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn255 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn256 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn250 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn252 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn253 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn248 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn249 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn251 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn244 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn245 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn246 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSVacacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn247 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn240 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn241 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn242 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn243 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn236 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn237 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn238 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn239 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn232 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn233 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn234 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn235 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn228 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn229 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn230 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn231 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn224 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn225 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn226 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn227 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn220 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn221 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn222 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn223 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn216 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn217 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn218 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn219 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn212 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn213 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn214 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn215 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn208 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn209 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn210 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn211 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn204 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn205 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn206 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn207 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn200 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn201 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn202 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn203 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn196 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn197 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn198 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn199 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn184 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn188 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn185 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn189 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn186 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn190 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn187 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn191 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn180 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn181 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn182 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn183 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn176 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn177 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn178 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn179 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn172 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn173 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn174 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn175 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn168 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn169 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn170 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn171 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn164 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn165 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn166 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn167 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn160 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn161 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn162 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn163 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn156 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn157 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn158 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn159 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn152 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn153 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn154 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn155 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn148 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn149 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn150 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn151 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn144 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn145 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn146 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn147 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn140 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn141 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn142 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn143 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn136 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn137 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn138 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn139 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn132 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn133 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn135 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn134 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn128 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn129 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn130 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn131 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn124 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn125 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn126 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn127 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn120 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn121 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn122 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn123 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn117 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn118 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn119 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn114 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn115 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn116 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn111 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn112 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn113 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn108 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn109 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn110 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn105 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn106 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn107 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn104 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn99 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn101 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn96 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn97 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn98 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn93 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn95 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn90 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn91 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn92 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnguardar = New System.Windows.Forms.ToolStripButton()
        Me.btneliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnimprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificadosDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizaciónClaveIESSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaCuentaBancacriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferenciaDeSalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionLaboralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn192 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn193 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn194 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn195 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn260 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn261 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabFichasMedicas = New System.Windows.Forms.TabPage()
        Me.CtlFichasMedicas1 = New WWTS.FichasMedicas.Controles.CtlFichasMedicas()
        Me.tb.SuspendLayout()
        Me.TabDatos.SuspendLayout()
        Me.pnldatos.SuspendLayout()
        Me.pnlcierre.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabOtros.SuspendLayout()
        Me.pnlotros.SuspendLayout()
        Me.TabObservaciones.SuspendLayout()
        Me.TabRubros.SuspendLayout()
        Me.pnlrubros.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSrubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderStrip2.SuspendLayout()
        Me.TabEvaluaciones.SuspendLayout()
        Me.TabLlamadas.SuspendLayout()
        Me.pnlLlamadas.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSLlamadaAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderStrip3.SuspendLayout()
        Me.TabVacacion.SuspendLayout()
        Me.TabLicencias.SuspendLayout()
        Me.pnlLicencias.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderStrip4.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSauditorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSueldos.SuspendLayout()
        CType(Me.dgsueldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSSueldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderStrip5.SuspendLayout()
        CType(Me.BSVacacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderStrip1.SuspendLayout()
        Me.TabFichasMedicas.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvcontratos
        '
        Me.tvcontratos.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvcontratos.HideSelection = False
        Me.tvcontratos.ImageIndex = 0
        Me.tvcontratos.ImageList = Me.ilestadocontrato
        Me.tvcontratos.Location = New System.Drawing.Point(0, 26)
        Me.tvcontratos.Margin = New System.Windows.Forms.Padding(4)
        Me.tvcontratos.Name = "tvcontratos"
        Me.tvcontratos.SelectedImageIndex = 0
        Me.tvcontratos.ShowLines = False
        Me.tvcontratos.ShowPlusMinus = False
        Me.tvcontratos.ShowRootLines = False
        Me.tvcontratos.Size = New System.Drawing.Size(159, 260)
        Me.tvcontratos.TabIndex = 0
        '
        'ilestadocontrato
        '
        Me.ilestadocontrato.ImageStream = CType(resources.GetObject("ilestadocontrato.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilestadocontrato.TransparentColor = System.Drawing.Color.Transparent
        Me.ilestadocontrato.Images.SetKeyName(0, "")
        Me.ilestadocontrato.Images.SetKeyName(1, "")
        '
        'tb
        '
        Me.tb.Controls.Add(Me.TabDatos)
        Me.tb.Controls.Add(Me.TabOtros)
        Me.tb.Controls.Add(Me.TabObservaciones)
        Me.tb.Controls.Add(Me.TabRubros)
        Me.tb.Controls.Add(Me.TabEvaluaciones)
        Me.tb.Controls.Add(Me.TabLlamadas)
        Me.tb.Controls.Add(Me.TabVacacion)
        Me.tb.Controls.Add(Me.TabLicencias)
        Me.tb.Controls.Add(Me.TabPage9)
        Me.tb.Controls.Add(Me.tabSueldos)
        Me.tb.Controls.Add(Me.TabFichasMedicas)
        Me.tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb.Location = New System.Drawing.Point(159, 26)
        Me.tb.Margin = New System.Windows.Forms.Padding(4)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(1046, 260)
        Me.tb.TabIndex = 1
        '
        'TabDatos
        '
        Me.TabDatos.Controls.Add(Me.pnldatos)
        Me.TabDatos.Location = New System.Drawing.Point(4, 25)
        Me.TabDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.TabDatos.Name = "TabDatos"
        Me.TabDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.TabDatos.Size = New System.Drawing.Size(1038, 231)
        Me.TabDatos.TabIndex = 1
        Me.TabDatos.Text = "Datos"
        Me.TabDatos.UseVisualStyleBackColor = True
        '
        'pnldatos
        '
        Me.pnldatos.Controls.Add(Me.LnkSeleccion)
        Me.pnldatos.Controls.Add(Me.pnlcierre)
        Me.pnldatos.Controls.Add(Me.Panel1)
        Me.pnldatos.Controls.Add(Me.Panel3)
        Me.pnldatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnldatos.Location = New System.Drawing.Point(4, 4)
        Me.pnldatos.Margin = New System.Windows.Forms.Padding(4)
        Me.pnldatos.Name = "pnldatos"
        Me.pnldatos.Size = New System.Drawing.Size(1030, 223)
        Me.pnldatos.TabIndex = 4
        '
        'LnkSeleccion
        '
        Me.LnkSeleccion.AutoSize = True
        Me.LnkSeleccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.LnkSeleccion.Location = New System.Drawing.Point(288, 188)
        Me.LnkSeleccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LnkSeleccion.Name = "LnkSeleccion"
        Me.LnkSeleccion.Size = New System.Drawing.Size(151, 17)
        Me.LnkSeleccion.TabIndex = 3
        Me.LnkSeleccion.TabStop = True
        Me.LnkSeleccion.Text = "Ver Proceso Selección"
        Me.LnkSeleccion.Visible = False
        '
        'pnlcierre
        '
        Me.pnlcierre.Controls.Add(Me.lblfeccierre)
        Me.pnlcierre.Controls.Add(Me.dtfechasta)
        Me.pnlcierre.Controls.Add(Me.cbotipoliq)
        Me.pnlcierre.Controls.Add(Me.Label4)
        Me.pnlcierre.Controls.Add(Me.cbotiposalida)
        Me.pnlcierre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlcierre.Location = New System.Drawing.Point(288, 126)
        Me.pnlcierre.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlcierre.Name = "pnlcierre"
        Me.pnlcierre.Size = New System.Drawing.Size(742, 62)
        Me.pnlcierre.TabIndex = 2
        '
        'lblfeccierre
        '
        Me.lblfeccierre.AutoSize = True
        Me.lblfeccierre.Location = New System.Drawing.Point(8, 5)
        Me.lblfeccierre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfeccierre.Name = "lblfeccierre"
        Me.lblfeccierre.Size = New System.Drawing.Size(91, 17)
        Me.lblfeccierre.TabIndex = 0
        Me.lblfeccierre.Text = "Fecha cierre:"
        '
        'dtfechasta
        '
        Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechasta.Location = New System.Drawing.Point(144, 2)
        Me.dtfechasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfechasta.Name = "dtfechasta"
        Me.dtfechasta.Size = New System.Drawing.Size(127, 22)
        Me.dtfechasta.TabIndex = 1
        '
        'cbotipoliq
        '
        Me.cbotipoliq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipoliq.Location = New System.Drawing.Point(144, 30)
        Me.cbotipoliq.Margin = New System.Windows.Forms.Padding(4)
        Me.cbotipoliq.Name = "cbotipoliq"
        Me.cbotipoliq.OperadorDatos = Nothing
        Me.cbotipoliq.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cbotipoliq.ParametroDet = Nothing
        Me.cbotipoliq.PuedeActualizar = True
        Me.cbotipoliq.PuedeEliminar = True
        Me.cbotipoliq.PuedeModificar = True
        Me.cbotipoliq.PuedeNuevo = True
        Me.cbotipoliq.Size = New System.Drawing.Size(185, 24)
        Me.cbotipoliq.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Liquidado:"
        '
        'cbotiposalida
        '
        Me.cbotiposalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotiposalida.Location = New System.Drawing.Point(339, 30)
        Me.cbotiposalida.Margin = New System.Windows.Forms.Padding(4)
        Me.cbotiposalida.Name = "cbotiposalida"
        Me.cbotiposalida.OperadorDatos = Nothing
        Me.cbotiposalida.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cbotiposalida.ParametroDet = Nothing
        Me.cbotiposalida.PuedeActualizar = True
        Me.cbotiposalida.PuedeEliminar = True
        Me.cbotiposalida.PuedeModificar = True
        Me.cbotiposalida.PuedeNuevo = True
        Me.cbotiposalida.Size = New System.Drawing.Size(272, 24)
        Me.cbotiposalida.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkMensualizarVac)
        Me.Panel1.Controls.Add(Me.chkMensualizarFR)
        Me.Panel1.Controls.Add(Me.chkMensualizarD4)
        Me.Panel1.Controls.Add(Me.chkMensualizarD3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CtlTipoContrato1)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.dtfecdesde)
        Me.Panel1.Controls.Add(Me.Cerrado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(288, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 126)
        Me.Panel1.TabIndex = 1
        '
        'chkMensualizarVac
        '
        Me.chkMensualizarVac.AutoSize = True
        Me.chkMensualizarVac.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMensualizarVac.Location = New System.Drawing.Point(291, 36)
        Me.chkMensualizarVac.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMensualizarVac.Name = "chkMensualizarVac"
        Me.chkMensualizarVac.Size = New System.Drawing.Size(112, 22)
        Me.chkMensualizarVac.TabIndex = 5
        Me.chkMensualizarVac.Text = "Vacaciones"
        '
        'chkMensualizarFR
        '
        Me.chkMensualizarFR.AutoSize = True
        Me.chkMensualizarFR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMensualizarFR.Location = New System.Drawing.Point(291, 64)
        Me.chkMensualizarFR.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMensualizarFR.Name = "chkMensualizarFR"
        Me.chkMensualizarFR.Size = New System.Drawing.Size(151, 22)
        Me.chkMensualizarFR.TabIndex = 6
        Me.chkMensualizarFR.Text = "Fondo de reserva"
        '
        'chkMensualizarD4
        '
        Me.chkMensualizarD4.AutoSize = True
        Me.chkMensualizarD4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMensualizarD4.Location = New System.Drawing.Point(144, 64)
        Me.chkMensualizarD4.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMensualizarD4.Name = "chkMensualizarD4"
        Me.chkMensualizarD4.Size = New System.Drawing.Size(130, 22)
        Me.chkMensualizarD4.TabIndex = 4
        Me.chkMensualizarD4.Text = "Décimo cuarto"
        '
        'chkMensualizarD3
        '
        Me.chkMensualizarD3.AutoSize = True
        Me.chkMensualizarD3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMensualizarD3.Location = New System.Drawing.Point(144, 34)
        Me.chkMensualizarD3.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMensualizarD3.Name = "chkMensualizarD3"
        Me.chkMensualizarD3.Size = New System.Drawing.Size(135, 22)
        Me.chkMensualizarD3.TabIndex = 3
        Me.chkMensualizarD3.Text = "Décimo tercero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Mensualizar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de contrato:"
        '
        'CtlTipoContrato1
        '
        Me.CtlTipoContrato1.AbriralEntrar = False
        Me.CtlTipoContrato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlTipoContrato1.FormattingEnabled = True
        Me.CtlTipoContrato1.Location = New System.Drawing.Point(144, 4)
        Me.CtlTipoContrato1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtlTipoContrato1.Name = "CtlTipoContrato1"
        Me.CtlTipoContrato1.Op = Nothing
        Me.CtlTipoContrato1.Patrono = Nothing
        Me.CtlTipoContrato1.PuedeActualizar = True
        Me.CtlTipoContrato1.PuedeEliminar = True
        Me.CtlTipoContrato1.PuedeModificar = True
        Me.CtlTipoContrato1.PuedeNuevo = True
        Me.CtlTipoContrato1.Size = New System.Drawing.Size(185, 24)
        Me.CtlTipoContrato1.TabIndex = 1
        Me.CtlTipoContrato1.TipoContrato = Nothing
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 98)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(107, 17)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Fecha contrato:"
        '
        'dtfecdesde
        '
        Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecdesde.Location = New System.Drawing.Point(144, 94)
        Me.dtfecdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfecdesde.Name = "dtfecdesde"
        Me.dtfecdesde.Size = New System.Drawing.Size(127, 22)
        Me.dtfecdesde.TabIndex = 8
        '
        'Cerrado
        '
        Me.Cerrado.AutoSize = True
        Me.Cerrado.Checked = True
        Me.Cerrado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Cerrado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cerrado.Location = New System.Drawing.Point(280, 96)
        Me.Cerrado.Margin = New System.Windows.Forms.Padding(4)
        Me.Cerrado.Name = "Cerrado"
        Me.Cerrado.Size = New System.Drawing.Size(118, 22)
        Me.Cerrado.TabIndex = 9
        Me.Cerrado.Text = "&Fecha cierre"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.cboSubCentroCosto)
        Me.Panel3.Controls.Add(Me.CtlPatronoCombo1)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.cboDepartamento)
        Me.Panel3.Controls.Add(Me.CtlArea1)
        Me.Panel3.Controls.Add(Me.cboSeccion)
        Me.Panel3.Controls.Add(Me.CtlCargo1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(288, 223)
        Me.Panel3.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 38)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "C. Costo:"
        '
        'cboSubCentroCosto
        '
        Me.cboSubCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubCentroCosto.FormattingEnabled = True
        Me.cboSubCentroCosto.Location = New System.Drawing.Point(80, 34)
        Me.cboSubCentroCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSubCentroCosto.Name = "cboSubCentroCosto"
        Me.cboSubCentroCosto.OperadorDatos = Nothing
        Me.cboSubCentroCosto.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboSubCentroCosto.ParametroDet = Nothing
        Me.cboSubCentroCosto.PuedeActualizar = True
        Me.cboSubCentroCosto.PuedeEliminar = True
        Me.cboSubCentroCosto.PuedeModificar = True
        Me.cboSubCentroCosto.PuedeNuevo = True
        Me.cboSubCentroCosto.Size = New System.Drawing.Size(203, 24)
        Me.cboSubCentroCosto.TabIndex = 11
        '
        'CtlPatronoCombo1
        '
        Me.CtlPatronoCombo1.AbriralEntrar = False
        Me.CtlPatronoCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlPatronoCombo1.FormattingEnabled = True
        Me.CtlPatronoCombo1.Location = New System.Drawing.Point(80, 7)
        Me.CtlPatronoCombo1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtlPatronoCombo1.Name = "CtlPatronoCombo1"
        Me.CtlPatronoCombo1.Op = Nothing
        Me.CtlPatronoCombo1.Patrono = Nothing
        Me.CtlPatronoCombo1.PuedeActualizar = True
        Me.CtlPatronoCombo1.PuedeEliminar = True
        Me.CtlPatronoCombo1.PuedeModificar = True
        Me.CtlPatronoCombo1.PuedeNuevo = True
        Me.CtlPatronoCombo1.Size = New System.Drawing.Size(203, 24)
        Me.CtlPatronoCombo1.TabIndex = 10
        Me.CtlPatronoCombo1.Usuario = Nothing
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 123)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 17)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Dpto:"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AbriralEntrar = False
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(80, 119)
        Me.cboDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.OperadorDatos = Nothing
        Me.cboDepartamento.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboDepartamento.ParametroDet = Nothing
        Me.cboDepartamento.PuedeActualizar = True
        Me.cboDepartamento.PuedeEliminar = True
        Me.cboDepartamento.PuedeModificar = True
        Me.cboDepartamento.PuedeNuevo = True
        Me.cboDepartamento.Size = New System.Drawing.Size(203, 24)
        Me.cboDepartamento.TabIndex = 5
        '
        'CtlArea1
        '
        Me.CtlArea1.AbriralEntrar = False
        Me.CtlArea1.Area = Nothing
        Me.CtlArea1.Departamento = Nothing
        Me.CtlArea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlArea1.FormattingEnabled = True
        Me.CtlArea1.Location = New System.Drawing.Point(80, 146)
        Me.CtlArea1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtlArea1.Name = "CtlArea1"
        Me.CtlArea1.Op = Nothing
        Me.CtlArea1.PuedeActualizar = True
        Me.CtlArea1.PuedeEliminar = False
        Me.CtlArea1.PuedeModificar = True
        Me.CtlArea1.PuedeNuevo = True
        Me.CtlArea1.Seccion = Nothing
        Me.CtlArea1.Size = New System.Drawing.Size(203, 24)
        Me.CtlArea1.TabIndex = 7
        '
        'cboSeccion
        '
        Me.cboSeccion.AbriralEntrar = False
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(80, 92)
        Me.cboSeccion.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.OperadorDatos = Nothing
        Me.cboSeccion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
        Me.cboSeccion.ParametroDet = Nothing
        Me.cboSeccion.PuedeActualizar = True
        Me.cboSeccion.PuedeEliminar = True
        Me.cboSeccion.PuedeModificar = True
        Me.cboSeccion.PuedeNuevo = True
        Me.cboSeccion.Size = New System.Drawing.Size(203, 24)
        Me.cboSeccion.TabIndex = 3
        '
        'CtlCargo1
        '
        Me.CtlCargo1.AbriralEntrar = False
        Me.CtlCargo1.Area = Nothing
        Me.CtlCargo1.Cargo = Nothing
        Me.CtlCargo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtlCargo1.FormattingEnabled = True
        Me.CtlCargo1.Location = New System.Drawing.Point(80, 174)
        Me.CtlCargo1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtlCargo1.Name = "CtlCargo1"
        Me.CtlCargo1.Op = Nothing
        Me.CtlCargo1.PuedeActualizar = True
        Me.CtlCargo1.PuedeEliminar = True
        Me.CtlCargo1.PuedeModificar = True
        Me.CtlCargo1.PuedeNuevo = True
        Me.CtlCargo1.Size = New System.Drawing.Size(203, 24)
        Me.CtlCargo1.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 150)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 17)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Área:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 96)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Sección:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 178)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Cargo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Patrono:"
        '
        'TabOtros
        '
        Me.TabOtros.Controls.Add(Me.pnlotros)
        Me.TabOtros.Location = New System.Drawing.Point(4, 25)
        Me.TabOtros.Margin = New System.Windows.Forms.Padding(4)
        Me.TabOtros.Name = "TabOtros"
        Me.TabOtros.Size = New System.Drawing.Size(1038, 231)
        Me.TabOtros.TabIndex = 2
        Me.TabOtros.Text = "Otros"
        Me.TabOtros.UseVisualStyleBackColor = True
        '
        'pnlotros
        '
        Me.pnlotros.Controls.Add(Me.Label16)
        Me.pnlotros.Controls.Add(Me.ComboBoxEstadoContrato)
        Me.pnlotros.Controls.Add(Me.Label8)
        Me.pnlotros.Controls.Add(Me.txtobservacion)
        Me.pnlotros.Controls.Add(Me.chkDescontarir)
        Me.pnlotros.Controls.Add(Me.ComboBoxSucursal1)
        Me.pnlotros.Controls.Add(Me.Label6)
        Me.pnlotros.Controls.Add(Me.ComboBoxEmpresa1)
        Me.pnlotros.Controls.Add(Me.Label7)
        Me.pnlotros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlotros.Location = New System.Drawing.Point(0, 0)
        Me.pnlotros.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlotros.Name = "pnlotros"
        Me.pnlotros.Size = New System.Drawing.Size(1038, 231)
        Me.pnlotros.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(51, 182)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 17)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Estado Contrato:"
        '
        'ComboBoxEstadoContrato
        '
        Me.ComboBoxEstadoContrato.AbriralEntrar = False
        Me.ComboBoxEstadoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstadoContrato.FormattingEnabled = True
        Me.ComboBoxEstadoContrato.Location = New System.Drawing.Point(187, 178)
        Me.ComboBoxEstadoContrato.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEstadoContrato.Name = "ComboBoxEstadoContrato"
        Me.ComboBoxEstadoContrato.OperadorDatos = Nothing
        Me.ComboBoxEstadoContrato.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxEstadoContrato.ParametroDet = Nothing
        Me.ComboBoxEstadoContrato.PuedeActualizar = True
        Me.ComboBoxEstadoContrato.PuedeEliminar = True
        Me.ComboBoxEstadoContrato.PuedeModificar = True
        Me.ComboBoxEstadoContrato.PuedeNuevo = True
        Me.ComboBoxEstadoContrato.Size = New System.Drawing.Size(199, 24)
        Me.ComboBoxEstadoContrato.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Observaciones"
        '
        'txtobservacion
        '
        Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtobservacion.Location = New System.Drawing.Point(187, 87)
        Me.txtobservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobservacion.Mensaje = ""
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtobservacion.PromptText = ""
        Me.txtobservacion.Size = New System.Drawing.Size(603, 86)
        Me.txtobservacion.TabIndex = 6
        '
        'chkDescontarir
        '
        Me.chkDescontarir.AutoSize = True
        Me.chkDescontarir.Location = New System.Drawing.Point(55, 4)
        Me.chkDescontarir.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDescontarir.Name = "chkDescontarir"
        Me.chkDescontarir.Size = New System.Drawing.Size(193, 21)
        Me.chkDescontarir.TabIndex = 0
        Me.chkDescontarir.Text = "Descontar impuesto renta"
        '
        'ComboBoxSucursal1
        '
        Me.ComboBoxSucursal1.AbriralEntrar = False
        Me.ComboBoxSucursal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSucursal1.Empresa = Nothing
        Me.ComboBoxSucursal1.FormattingEnabled = True
        Me.ComboBoxSucursal1.Location = New System.Drawing.Point(187, 58)
        Me.ComboBoxSucursal1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSucursal1.Name = "ComboBoxSucursal1"
        Me.ComboBoxSucursal1.PuedeActualizar = False
        Me.ComboBoxSucursal1.PuedeEliminar = False
        Me.ComboBoxSucursal1.PuedeModificar = False
        Me.ComboBoxSucursal1.PuedeNuevo = False
        Me.ComboBoxSucursal1.Size = New System.Drawing.Size(257, 24)
        Me.ComboBoxSucursal1.Sucursal = Nothing
        Me.ComboBoxSucursal1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "&Empresa"
        '
        'ComboBoxEmpresa1
        '
        Me.ComboBoxEmpresa1.AbriralEntrar = False
        Me.ComboBoxEmpresa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEmpresa1.Empresa = Nothing
        Me.ComboBoxEmpresa1.FormattingEnabled = True
        Me.ComboBoxEmpresa1.Location = New System.Drawing.Point(187, 28)
        Me.ComboBoxEmpresa1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEmpresa1.Name = "ComboBoxEmpresa1"
        Me.ComboBoxEmpresa1.Op = Nothing
        Me.ComboBoxEmpresa1.PuedeActualizar = False
        Me.ComboBoxEmpresa1.PuedeEliminar = False
        Me.ComboBoxEmpresa1.PuedeModificar = False
        Me.ComboBoxEmpresa1.PuedeNuevo = False
        Me.ComboBoxEmpresa1.Size = New System.Drawing.Size(257, 24)
        Me.ComboBoxEmpresa1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "&Sucursal"
        '
        'TabObservaciones
        '
        Me.TabObservaciones.Controls.Add(Me.dtfecafiliess)
        Me.TabObservaciones.Controls.Add(Me.chkreglamentointerno)
        Me.TabObservaciones.Controls.Add(Me.chkrecordpolicial)
        Me.TabObservaciones.Controls.Add(Me.chkcertvot)
        Me.TabObservaciones.Controls.Add(Me.chkcertsalud)
        Me.TabObservaciones.Controls.Add(Me.chkafiliess)
        Me.TabObservaciones.Controls.Add(Me.Label35)
        Me.TabObservaciones.Controls.Add(Me.chkpertsind)
        Me.TabObservaciones.Controls.Add(Me.chkjuicio)
        Me.TabObservaciones.Controls.Add(Me.txtmotsal)
        Me.TabObservaciones.Location = New System.Drawing.Point(4, 25)
        Me.TabObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.TabObservaciones.Name = "TabObservaciones"
        Me.TabObservaciones.Size = New System.Drawing.Size(1038, 231)
        Me.TabObservaciones.TabIndex = 3
        Me.TabObservaciones.Text = "Observaciones"
        Me.TabObservaciones.UseVisualStyleBackColor = True
        '
        'dtfecafiliess
        '
        Me.dtfecafiliess.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecafiliess.Location = New System.Drawing.Point(140, 7)
        Me.dtfecafiliess.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfecafiliess.Name = "dtfecafiliess"
        Me.dtfecafiliess.Size = New System.Drawing.Size(127, 22)
        Me.dtfecafiliess.TabIndex = 1
        Me.dtfecafiliess.Visible = False
        '
        'chkreglamentointerno
        '
        Me.chkreglamentointerno.AutoSize = True
        Me.chkreglamentointerno.Location = New System.Drawing.Point(4, 153)
        Me.chkreglamentointerno.Margin = New System.Windows.Forms.Padding(4)
        Me.chkreglamentointerno.Name = "chkreglamentointerno"
        Me.chkreglamentointerno.Size = New System.Drawing.Size(154, 21)
        Me.chkreglamentointerno.TabIndex = 6
        Me.chkreglamentointerno.Text = "Reglamento interno"
        '
        'chkrecordpolicial
        '
        Me.chkrecordpolicial.AutoSize = True
        Me.chkrecordpolicial.Location = New System.Drawing.Point(4, 181)
        Me.chkrecordpolicial.Margin = New System.Windows.Forms.Padding(4)
        Me.chkrecordpolicial.Name = "chkrecordpolicial"
        Me.chkrecordpolicial.Size = New System.Drawing.Size(123, 21)
        Me.chkrecordpolicial.TabIndex = 7
        Me.chkrecordpolicial.Text = "Record policial"
        '
        'chkcertvot
        '
        Me.chkcertvot.AutoSize = True
        Me.chkcertvot.Location = New System.Drawing.Point(4, 96)
        Me.chkcertvot.Margin = New System.Windows.Forms.Padding(4)
        Me.chkcertvot.Name = "chkcertvot"
        Me.chkcertvot.Size = New System.Drawing.Size(174, 21)
        Me.chkcertvot.TabIndex = 4
        Me.chkcertvot.Text = "Certificado de votación"
        '
        'chkcertsalud
        '
        Me.chkcertsalud.AutoSize = True
        Me.chkcertsalud.Location = New System.Drawing.Point(4, 124)
        Me.chkcertsalud.Margin = New System.Windows.Forms.Padding(4)
        Me.chkcertsalud.Name = "chkcertsalud"
        Me.chkcertsalud.Size = New System.Drawing.Size(155, 21)
        Me.chkcertsalud.TabIndex = 5
        Me.chkcertsalud.Text = "Certificado de salud"
        '
        'chkafiliess
        '
        Me.chkafiliess.AutoSize = True
        Me.chkafiliess.Location = New System.Drawing.Point(4, 11)
        Me.chkafiliess.Margin = New System.Windows.Forms.Padding(4)
        Me.chkafiliess.Name = "chkafiliess"
        Me.chkafiliess.Size = New System.Drawing.Size(125, 21)
        Me.chkafiliess.TabIndex = 0
        Me.chkafiliess.Text = "Afiliado al IESS"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(288, 11)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(114, 17)
        Me.Label35.TabIndex = 8
        Me.Label35.Text = "Motivo de salida:"
        '
        'chkpertsind
        '
        Me.chkpertsind.AutoSize = True
        Me.chkpertsind.Location = New System.Drawing.Point(4, 39)
        Me.chkpertsind.Margin = New System.Windows.Forms.Padding(4)
        Me.chkpertsind.Name = "chkpertsind"
        Me.chkpertsind.Size = New System.Drawing.Size(155, 21)
        Me.chkpertsind.TabIndex = 2
        Me.chkpertsind.Text = "Pertenece sindicato"
        '
        'chkjuicio
        '
        Me.chkjuicio.AutoSize = True
        Me.chkjuicio.Location = New System.Drawing.Point(4, 68)
        Me.chkjuicio.Margin = New System.Windows.Forms.Padding(4)
        Me.chkjuicio.Name = "chkjuicio"
        Me.chkjuicio.Size = New System.Drawing.Size(118, 21)
        Me.chkjuicio.TabIndex = 3
        Me.chkjuicio.Text = "Juicio Laboral"
        '
        'txtmotsal
        '
        Me.txtmotsal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmotsal.Location = New System.Drawing.Point(292, 34)
        Me.txtmotsal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmotsal.Mensaje = ""
        Me.txtmotsal.Multiline = True
        Me.txtmotsal.Name = "txtmotsal"
        Me.txtmotsal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmotsal.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtmotsal.PromptText = ""
        Me.txtmotsal.Size = New System.Drawing.Size(723, 178)
        Me.txtmotsal.TabIndex = 9
        '
        'TabRubros
        '
        Me.TabRubros.Controls.Add(Me.pnlrubros)
        Me.TabRubros.Location = New System.Drawing.Point(4, 25)
        Me.TabRubros.Margin = New System.Windows.Forms.Padding(4)
        Me.TabRubros.Name = "TabRubros"
        Me.TabRubros.Padding = New System.Windows.Forms.Padding(4)
        Me.TabRubros.Size = New System.Drawing.Size(1038, 231)
        Me.TabRubros.TabIndex = 4
        Me.TabRubros.Text = "Rubros"
        Me.TabRubros.UseVisualStyleBackColor = True
        '
        'pnlrubros
        '
        Me.pnlrubros.Controls.Add(Me.DataGridView3)
        Me.pnlrubros.Controls.Add(Me.HeaderStrip2)
        Me.pnlrubros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlrubros.Location = New System.Drawing.Point(4, 4)
        Me.pnlrubros.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlrubros.Name = "pnlrubros"
        Me.pnlrubros.Size = New System.Drawing.Size(1030, 223)
        Me.pnlrubros.TabIndex = 2
        '
        'DataGridView3
        '
        Me.DataGridView3.AgruparRepetidos = False
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn366})
        Me.DataGridView3.DataSource = Me.BSrubro
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(1030, 197)
        Me.DataGridView3.TabIndex = 1
        '
        'DataGridViewTextBoxColumn362
        '
        Me.DataGridViewTextBoxColumn362.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn362.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn362.Name = "DataGridViewTextBoxColumn362"
        Me.DataGridViewTextBoxColumn362.Width = 125
        '
        'DataGridViewTextBoxColumn366
        '
        Me.DataGridViewTextBoxColumn366.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn366.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn366.Name = "DataGridViewTextBoxColumn366"
        Me.DataGridViewTextBoxColumn366.Width = 125
        '
        'HeaderStrip2
        '
        Me.HeaderStrip2.AutoSize = False
        Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.btnnuevorubro, Me.btnabrirrubro, Me.btneliminarrubro})
        Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip2.Name = "HeaderStrip2"
        Me.HeaderStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.HeaderStrip2.Size = New System.Drawing.Size(1030, 26)
        Me.HeaderStrip2.TabIndex = 0
        Me.HeaderStrip2.Text = "Opciones"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(55, 23)
        Me.ToolStripLabel2.Text = "Rubros"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'btnnuevorubro
        '
        Me.btnnuevorubro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevorubro.Image = Global.WWTS.Roles.Controles.My.Resources.Resources._new
        Me.btnnuevorubro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevorubro.Name = "btnnuevorubro"
        Me.btnnuevorubro.Size = New System.Drawing.Size(29, 23)
        Me.btnnuevorubro.Text = "Nuevo"
        '
        'btnabrirrubro
        '
        Me.btnabrirrubro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirrubro.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.open
        Me.btnabrirrubro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirrubro.Name = "btnabrirrubro"
        Me.btnabrirrubro.Size = New System.Drawing.Size(29, 23)
        Me.btnabrirrubro.Text = "Abrir"
        '
        'btneliminarrubro
        '
        Me.btneliminarrubro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneliminarrubro.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.delete
        Me.btneliminarrubro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btneliminarrubro.Name = "btneliminarrubro"
        Me.btneliminarrubro.Size = New System.Drawing.Size(29, 23)
        Me.btneliminarrubro.Text = "Eliminar"
        '
        'TabEvaluaciones
        '
        Me.TabEvaluaciones.Controls.Add(Me.txtevaanual)
        Me.TabEvaluaciones.Controls.Add(Me.txtevatrimestral)
        Me.TabEvaluaciones.Controls.Add(Me.Label11)
        Me.TabEvaluaciones.Controls.Add(Me.Label10)
        Me.TabEvaluaciones.Controls.Add(Me.Label9)
        Me.TabEvaluaciones.Controls.Add(Me.CtlAdjunto1)
        Me.TabEvaluaciones.Location = New System.Drawing.Point(4, 25)
        Me.TabEvaluaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.TabEvaluaciones.Name = "TabEvaluaciones"
        Me.TabEvaluaciones.Padding = New System.Windows.Forms.Padding(4)
        Me.TabEvaluaciones.Size = New System.Drawing.Size(1038, 231)
        Me.TabEvaluaciones.TabIndex = 5
        Me.TabEvaluaciones.Text = "Evaluaciones"
        Me.TabEvaluaciones.UseVisualStyleBackColor = True
        '
        'txtevaanual
        '
        Me.txtevaanual.Location = New System.Drawing.Point(89, 44)
        Me.txtevaanual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtevaanual.Mensaje = ""
        Me.txtevaanual.Name = "txtevaanual"
        Me.txtevaanual.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtevaanual.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtevaanual.PromptText = ""
        Me.txtevaanual.Size = New System.Drawing.Size(71, 22)
        Me.txtevaanual.TabIndex = 3
        Me.txtevaanual.Text = "0"
        Me.txtevaanual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtevaanual.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtevaanual.Value = 0R
        '
        'txtevatrimestral
        '
        Me.txtevatrimestral.BackColor = System.Drawing.SystemColors.Window
        Me.txtevatrimestral.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtevatrimestral.Location = New System.Drawing.Point(89, 12)
        Me.txtevatrimestral.Margin = New System.Windows.Forms.Padding(4)
        Me.txtevatrimestral.Mensaje = ""
        Me.txtevatrimestral.Name = "txtevatrimestral"
        Me.txtevatrimestral.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtevatrimestral.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtevatrimestral.PromptText = ""
        Me.txtevatrimestral.Size = New System.Drawing.Size(71, 22)
        Me.txtevatrimestral.TabIndex = 1
        Me.txtevatrimestral.Text = "0"
        Me.txtevatrimestral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtevatrimestral.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtevatrimestral.Value = 0R
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 76)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Adjuntos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Anual:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Trimestral:"
        '
        'CtlAdjunto1
        '
        Me.CtlAdjunto1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtlAdjunto1.HideSelection = False
        Me.CtlAdjunto1.Location = New System.Drawing.Point(89, 76)
        Me.CtlAdjunto1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtlAdjunto1.Name = "CtlAdjunto1"
        Me.CtlAdjunto1.ParameAdjunto = Nothing
        Me.CtlAdjunto1.Size = New System.Drawing.Size(935, 143)
        Me.CtlAdjunto1.TabIndex = 5
        Me.CtlAdjunto1.UseCompatibleStateImageBehavior = False
        '
        'TabLlamadas
        '
        Me.TabLlamadas.Controls.Add(Me.pnlLlamadas)
        Me.TabLlamadas.Location = New System.Drawing.Point(4, 25)
        Me.TabLlamadas.Margin = New System.Windows.Forms.Padding(4)
        Me.TabLlamadas.Name = "TabLlamadas"
        Me.TabLlamadas.Padding = New System.Windows.Forms.Padding(4)
        Me.TabLlamadas.Size = New System.Drawing.Size(1038, 231)
        Me.TabLlamadas.TabIndex = 6
        Me.TabLlamadas.Text = "Llamados atención"
        Me.TabLlamadas.UseVisualStyleBackColor = True
        '
        'pnlLlamadas
        '
        Me.pnlLlamadas.Controls.Add(Me.DataGridView2)
        Me.pnlLlamadas.Controls.Add(Me.HeaderStrip3)
        Me.pnlLlamadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLlamadas.Location = New System.Drawing.Point(4, 4)
        Me.pnlLlamadas.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLlamadas.Name = "pnlLlamadas"
        Me.pnlLlamadas.Size = New System.Drawing.Size(1030, 223)
        Me.pnlLlamadas.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AgruparRepetidos = False
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn367})
        Me.DataGridView2.DataSource = Me.BSLlamadaAtencion
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(1030, 197)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridViewTextBoxColumn363
        '
        Me.DataGridViewTextBoxColumn363.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn363.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn363.Name = "DataGridViewTextBoxColumn363"
        Me.DataGridViewTextBoxColumn363.Width = 125
        '
        'DataGridViewTextBoxColumn367
        '
        Me.DataGridViewTextBoxColumn367.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn367.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn367.Name = "DataGridViewTextBoxColumn367"
        Me.DataGridViewTextBoxColumn367.Width = 125
        '
        'HeaderStrip3
        '
        Me.HeaderStrip3.AutoSize = False
        Me.HeaderStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip3.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip3.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HeaderStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.btnnuevollamado, Me.btnabrirllamado, Me.btneliminarllamado, Me.btnimprimirllamado, Me.ToolStripSeparator6, Me.btnnuevomulta})
        Me.HeaderStrip3.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip3.Name = "HeaderStrip3"
        Me.HeaderStrip3.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.HeaderStrip3.Size = New System.Drawing.Size(1030, 26)
        Me.HeaderStrip3.TabIndex = 0
        Me.HeaderStrip3.Text = "Opciones"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(155, 23)
        Me.ToolStripLabel1.Text = "Llamados de atención"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'btnnuevollamado
        '
        Me.btnnuevollamado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevollamado.Image = Global.WWTS.Roles.Controles.My.Resources.Resources._new
        Me.btnnuevollamado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevollamado.Name = "btnnuevollamado"
        Me.btnnuevollamado.Size = New System.Drawing.Size(29, 23)
        Me.btnnuevollamado.Text = "Nuevo"
        '
        'btnabrirllamado
        '
        Me.btnabrirllamado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirllamado.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.open
        Me.btnabrirllamado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirllamado.Name = "btnabrirllamado"
        Me.btnabrirllamado.Size = New System.Drawing.Size(29, 23)
        Me.btnabrirllamado.Text = "Abrir"
        '
        'btneliminarllamado
        '
        Me.btneliminarllamado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneliminarllamado.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.delete
        Me.btneliminarllamado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btneliminarllamado.Name = "btneliminarllamado"
        Me.btneliminarllamado.Size = New System.Drawing.Size(29, 23)
        Me.btneliminarllamado.Text = "Eliminar"
        '
        'btnimprimirllamado
        '
        Me.btnimprimirllamado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnimprimirllamado.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.print
        Me.btnimprimirllamado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnimprimirllamado.Name = "btnimprimirllamado"
        Me.btnimprimirllamado.Size = New System.Drawing.Size(29, 23)
        Me.btnimprimirllamado.Text = "Imprimir llamado de atención"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 26)
        '
        'btnnuevomulta
        '
        Me.btnnuevomulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevomulta.Image = CType(resources.GetObject("btnnuevomulta.Image"), System.Drawing.Image)
        Me.btnnuevomulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevomulta.Name = "btnnuevomulta"
        Me.btnnuevomulta.Size = New System.Drawing.Size(29, 23)
        Me.btnnuevomulta.Text = "Crear Multa"
        '
        'TabVacacion
        '
        Me.TabVacacion.Controls.Add(Me.CtlPeriodoVacacion1)
        Me.TabVacacion.Location = New System.Drawing.Point(4, 25)
        Me.TabVacacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TabVacacion.Name = "TabVacacion"
        Me.TabVacacion.Padding = New System.Windows.Forms.Padding(4)
        Me.TabVacacion.Size = New System.Drawing.Size(1038, 231)
        Me.TabVacacion.TabIndex = 10
        Me.TabVacacion.Text = "Periodo Vacación"
        Me.TabVacacion.UseVisualStyleBackColor = True
        '
        'CtlPeriodoVacacion1
        '
        Me.CtlPeriodoVacacion1.Contrato = Nothing
        Me.CtlPeriodoVacacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlPeriodoVacacion1.Location = New System.Drawing.Point(4, 4)
        Me.CtlPeriodoVacacion1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CtlPeriodoVacacion1.Name = "CtlPeriodoVacacion1"
        Me.CtlPeriodoVacacion1.Size = New System.Drawing.Size(1030, 223)
        Me.CtlPeriodoVacacion1.TabIndex = 0
        '
        'TabLicencias
        '
        Me.TabLicencias.Controls.Add(Me.pnlLicencias)
        Me.TabLicencias.Location = New System.Drawing.Point(4, 25)
        Me.TabLicencias.Margin = New System.Windows.Forms.Padding(4)
        Me.TabLicencias.Name = "TabLicencias"
        Me.TabLicencias.Size = New System.Drawing.Size(1038, 231)
        Me.TabLicencias.TabIndex = 8
        Me.TabLicencias.Text = "Licencias/Permisos"
        Me.TabLicencias.UseVisualStyleBackColor = True
        '
        'pnlLicencias
        '
        Me.pnlLicencias.Controls.Add(Me.DataGridView5)
        Me.pnlLicencias.Controls.Add(Me.HeaderStrip4)
        Me.pnlLicencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLicencias.Location = New System.Drawing.Point(0, 0)
        Me.pnlLicencias.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLicencias.Name = "pnlLicencias"
        Me.pnlLicencias.Size = New System.Drawing.Size(1038, 231)
        Me.pnlLicencias.TabIndex = 2
        '
        'DataGridView5
        '
        Me.DataGridView5.AgruparRepetidos = False
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn368})
        Me.DataGridView5.DataSource = Me.BSLicencia
        Me.DataGridView5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView5.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.Size = New System.Drawing.Size(1038, 205)
        Me.DataGridView5.TabIndex = 1
        '
        'DataGridViewTextBoxColumn364
        '
        Me.DataGridViewTextBoxColumn364.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn364.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn364.Name = "DataGridViewTextBoxColumn364"
        Me.DataGridViewTextBoxColumn364.Width = 125
        '
        'DataGridViewTextBoxColumn368
        '
        Me.DataGridViewTextBoxColumn368.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn368.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn368.Name = "DataGridViewTextBoxColumn368"
        Me.DataGridViewTextBoxColumn368.Width = 125
        '
        'HeaderStrip4
        '
        Me.HeaderStrip4.AutoSize = False
        Me.HeaderStrip4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip4.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip4.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HeaderStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator4, Me.btnnuevolicencia, Me.btnabrirlicencia, Me.btneliminarlicencia, Me.btnimprimirlicencia})
        Me.HeaderStrip4.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip4.Name = "HeaderStrip4"
        Me.HeaderStrip4.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.HeaderStrip4.Size = New System.Drawing.Size(1038, 26)
        Me.HeaderStrip4.TabIndex = 0
        Me.HeaderStrip4.Text = "HeaderStrip3"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(132, 23)
        Me.ToolStripLabel3.Text = "Licencias/Permisos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 26)
        '
        'btnnuevolicencia
        '
        Me.btnnuevolicencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevolicencia.Image = Global.WWTS.Roles.Controles.My.Resources.Resources._new
        Me.btnnuevolicencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevolicencia.Name = "btnnuevolicencia"
        Me.btnnuevolicencia.Size = New System.Drawing.Size(29, 23)
        Me.btnnuevolicencia.Text = "Nuevo"
        '
        'btnabrirlicencia
        '
        Me.btnabrirlicencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirlicencia.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.open
        Me.btnabrirlicencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirlicencia.Name = "btnabrirlicencia"
        Me.btnabrirlicencia.Size = New System.Drawing.Size(29, 23)
        Me.btnabrirlicencia.Text = "Abrir"
        '
        'btneliminarlicencia
        '
        Me.btneliminarlicencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneliminarlicencia.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.delete
        Me.btneliminarlicencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btneliminarlicencia.Name = "btneliminarlicencia"
        Me.btneliminarlicencia.Size = New System.Drawing.Size(29, 23)
        Me.btneliminarlicencia.Text = "Eliminar"
        '
        'btnimprimirlicencia
        '
        Me.btnimprimirlicencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnimprimirlicencia.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.print
        Me.btnimprimirlicencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnimprimirlicencia.Name = "btnimprimirlicencia"
        Me.btnimprimirlicencia.Size = New System.Drawing.Size(29, 23)
        Me.btnimprimirlicencia.Text = "Imprimir Licencia"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.DataGridView4)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage9.Size = New System.Drawing.Size(1038, 231)
        Me.TabPage9.TabIndex = 9
        Me.TabPage9.Text = "Auditoría"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.DataSource = Me.BSauditorias
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.Size = New System.Drawing.Size(1030, 223)
        Me.DataGridView4.TabIndex = 0
        '
        'tabSueldos
        '
        Me.tabSueldos.Controls.Add(Me.dgsueldos)
        Me.tabSueldos.Controls.Add(Me.HeaderStrip5)
        Me.tabSueldos.Location = New System.Drawing.Point(4, 25)
        Me.tabSueldos.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSueldos.Name = "tabSueldos"
        Me.tabSueldos.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSueldos.Size = New System.Drawing.Size(1038, 231)
        Me.tabSueldos.TabIndex = 11
        Me.tabSueldos.Text = "Sueldos"
        Me.tabSueldos.UseVisualStyleBackColor = True
        '
        'dgsueldos
        '
        Me.dgsueldos.AgruparRepetidos = False
        Me.dgsueldos.AllowUserToAddRows = False
        Me.dgsueldos.AllowUserToDeleteRows = False
        Me.dgsueldos.AutoGenerateColumns = False
        Me.dgsueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsueldos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn369})
        Me.dgsueldos.DataSource = Me.BSSueldos
        Me.dgsueldos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgsueldos.Location = New System.Drawing.Point(4, 30)
        Me.dgsueldos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgsueldos.Name = "dgsueldos"
        Me.dgsueldos.ReadOnly = True
        Me.dgsueldos.RowHeadersVisible = False
        Me.dgsueldos.RowHeadersWidth = 51
        Me.dgsueldos.Size = New System.Drawing.Size(1030, 197)
        Me.dgsueldos.TabIndex = 2
        '
        'DataGridViewTextBoxColumn365
        '
        Me.DataGridViewTextBoxColumn365.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn365.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn365.Name = "DataGridViewTextBoxColumn365"
        Me.DataGridViewTextBoxColumn365.ReadOnly = True
        Me.DataGridViewTextBoxColumn365.Width = 125
        '
        'DataGridViewTextBoxColumn369
        '
        Me.DataGridViewTextBoxColumn369.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn369.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn369.Name = "DataGridViewTextBoxColumn369"
        Me.DataGridViewTextBoxColumn369.ReadOnly = True
        Me.DataGridViewTextBoxColumn369.Width = 125
        '
        'HeaderStrip5
        '
        Me.HeaderStrip5.AutoSize = False
        Me.HeaderStrip5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip5.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip5.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HeaderStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.ToolStripSeparator5, Me.btnSueldosExcel, Me.btn_FondosReserva})
        Me.HeaderStrip5.Location = New System.Drawing.Point(4, 4)
        Me.HeaderStrip5.Name = "HeaderStrip5"
        Me.HeaderStrip5.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.HeaderStrip5.Size = New System.Drawing.Size(1030, 26)
        Me.HeaderStrip5.TabIndex = 3
        Me.HeaderStrip5.Text = "Opciones"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(61, 23)
        Me.ToolStripLabel4.Text = "Sueldos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 26)
        '
        'btnSueldosExcel
        '
        Me.btnSueldosExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSueldosExcel.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.docexcel
        Me.btnSueldosExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSueldosExcel.Name = "btnSueldosExcel"
        Me.btnSueldosExcel.Size = New System.Drawing.Size(29, 23)
        Me.btnSueldosExcel.Text = "Nuevo"
        '
        'btn_FondosReserva
        '
        Me.btn_FondosReserva.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.report
        Me.btn_FondosReserva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_FondosReserva.Name = "btn_FondosReserva"
        Me.btn_FondosReserva.Size = New System.Drawing.Size(153, 23)
        Me.btn_FondosReserva.Text = "Fondos de reserva"
        '
        'DataGridViewTextBoxColumn358
        '
        Me.DataGridViewTextBoxColumn358.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn358.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn358.Name = "DataGridViewTextBoxColumn358"
        Me.DataGridViewTextBoxColumn358.Width = 125
        '
        'DataGridViewTextBoxColumn359
        '
        Me.DataGridViewTextBoxColumn359.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn359.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn359.Name = "DataGridViewTextBoxColumn359"
        Me.DataGridViewTextBoxColumn359.Width = 125
        '
        'DataGridViewTextBoxColumn360
        '
        Me.DataGridViewTextBoxColumn360.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn360.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn360.Name = "DataGridViewTextBoxColumn360"
        Me.DataGridViewTextBoxColumn360.Width = 125
        '
        'DataGridViewTextBoxColumn361
        '
        Me.DataGridViewTextBoxColumn361.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn361.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn361.Name = "DataGridViewTextBoxColumn361"
        Me.DataGridViewTextBoxColumn361.ReadOnly = True
        Me.DataGridViewTextBoxColumn361.Width = 125
        '
        'DataGridViewTextBoxColumn354
        '
        Me.DataGridViewTextBoxColumn354.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn354.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn354.Name = "DataGridViewTextBoxColumn354"
        Me.DataGridViewTextBoxColumn354.Width = 125
        '
        'DataGridViewTextBoxColumn355
        '
        Me.DataGridViewTextBoxColumn355.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn355.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn355.Name = "DataGridViewTextBoxColumn355"
        Me.DataGridViewTextBoxColumn355.Width = 125
        '
        'DataGridViewTextBoxColumn356
        '
        Me.DataGridViewTextBoxColumn356.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn356.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn356.Name = "DataGridViewTextBoxColumn356"
        Me.DataGridViewTextBoxColumn356.Width = 125
        '
        'DataGridViewTextBoxColumn357
        '
        Me.DataGridViewTextBoxColumn357.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn357.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn357.Name = "DataGridViewTextBoxColumn357"
        Me.DataGridViewTextBoxColumn357.ReadOnly = True
        Me.DataGridViewTextBoxColumn357.Width = 125
        '
        'DataGridViewTextBoxColumn350
        '
        Me.DataGridViewTextBoxColumn350.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn350.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn350.Name = "DataGridViewTextBoxColumn350"
        Me.DataGridViewTextBoxColumn350.Width = 125
        '
        'DataGridViewTextBoxColumn351
        '
        Me.DataGridViewTextBoxColumn351.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn351.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn351.Name = "DataGridViewTextBoxColumn351"
        Me.DataGridViewTextBoxColumn351.Width = 125
        '
        'DataGridViewTextBoxColumn352
        '
        Me.DataGridViewTextBoxColumn352.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn352.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn352.Name = "DataGridViewTextBoxColumn352"
        Me.DataGridViewTextBoxColumn352.Width = 125
        '
        'DataGridViewTextBoxColumn353
        '
        Me.DataGridViewTextBoxColumn353.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn353.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn353.Name = "DataGridViewTextBoxColumn353"
        Me.DataGridViewTextBoxColumn353.ReadOnly = True
        Me.DataGridViewTextBoxColumn353.Width = 125
        '
        'DataGridViewTextBoxColumn346
        '
        Me.DataGridViewTextBoxColumn346.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn346.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn346.Name = "DataGridViewTextBoxColumn346"
        Me.DataGridViewTextBoxColumn346.Width = 125
        '
        'DataGridViewTextBoxColumn347
        '
        Me.DataGridViewTextBoxColumn347.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn347.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn347.Name = "DataGridViewTextBoxColumn347"
        Me.DataGridViewTextBoxColumn347.Width = 125
        '
        'DataGridViewTextBoxColumn348
        '
        Me.DataGridViewTextBoxColumn348.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn348.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn348.Name = "DataGridViewTextBoxColumn348"
        Me.DataGridViewTextBoxColumn348.Width = 125
        '
        'DataGridViewTextBoxColumn349
        '
        Me.DataGridViewTextBoxColumn349.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn349.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn349.Name = "DataGridViewTextBoxColumn349"
        Me.DataGridViewTextBoxColumn349.ReadOnly = True
        Me.DataGridViewTextBoxColumn349.Width = 125
        '
        'DataGridViewTextBoxColumn342
        '
        Me.DataGridViewTextBoxColumn342.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn342.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn342.Name = "DataGridViewTextBoxColumn342"
        Me.DataGridViewTextBoxColumn342.Width = 125
        '
        'DataGridViewTextBoxColumn343
        '
        Me.DataGridViewTextBoxColumn343.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn343.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn343.Name = "DataGridViewTextBoxColumn343"
        Me.DataGridViewTextBoxColumn343.Width = 125
        '
        'DataGridViewTextBoxColumn344
        '
        Me.DataGridViewTextBoxColumn344.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn344.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn344.Name = "DataGridViewTextBoxColumn344"
        Me.DataGridViewTextBoxColumn344.Width = 125
        '
        'DataGridViewTextBoxColumn345
        '
        Me.DataGridViewTextBoxColumn345.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn345.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn345.Name = "DataGridViewTextBoxColumn345"
        Me.DataGridViewTextBoxColumn345.ReadOnly = True
        Me.DataGridViewTextBoxColumn345.Width = 125
        '
        'DataGridViewTextBoxColumn338
        '
        Me.DataGridViewTextBoxColumn338.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn338.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn338.Name = "DataGridViewTextBoxColumn338"
        Me.DataGridViewTextBoxColumn338.Width = 125
        '
        'DataGridViewTextBoxColumn339
        '
        Me.DataGridViewTextBoxColumn339.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn339.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn339.Name = "DataGridViewTextBoxColumn339"
        Me.DataGridViewTextBoxColumn339.Width = 125
        '
        'DataGridViewTextBoxColumn340
        '
        Me.DataGridViewTextBoxColumn340.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn340.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn340.Name = "DataGridViewTextBoxColumn340"
        Me.DataGridViewTextBoxColumn340.Width = 125
        '
        'DataGridViewTextBoxColumn341
        '
        Me.DataGridViewTextBoxColumn341.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn341.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn341.Name = "DataGridViewTextBoxColumn341"
        Me.DataGridViewTextBoxColumn341.ReadOnly = True
        Me.DataGridViewTextBoxColumn341.Width = 125
        '
        'DataGridViewTextBoxColumn334
        '
        Me.DataGridViewTextBoxColumn334.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn334.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn334.Name = "DataGridViewTextBoxColumn334"
        Me.DataGridViewTextBoxColumn334.Width = 125
        '
        'DataGridViewTextBoxColumn335
        '
        Me.DataGridViewTextBoxColumn335.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn335.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn335.Name = "DataGridViewTextBoxColumn335"
        Me.DataGridViewTextBoxColumn335.Width = 125
        '
        'DataGridViewTextBoxColumn336
        '
        Me.DataGridViewTextBoxColumn336.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn336.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn336.Name = "DataGridViewTextBoxColumn336"
        Me.DataGridViewTextBoxColumn336.Width = 125
        '
        'DataGridViewTextBoxColumn337
        '
        Me.DataGridViewTextBoxColumn337.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn337.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn337.Name = "DataGridViewTextBoxColumn337"
        Me.DataGridViewTextBoxColumn337.ReadOnly = True
        Me.DataGridViewTextBoxColumn337.Width = 125
        '
        'DataGridViewTextBoxColumn330
        '
        Me.DataGridViewTextBoxColumn330.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn330.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn330.Name = "DataGridViewTextBoxColumn330"
        Me.DataGridViewTextBoxColumn330.Width = 125
        '
        'DataGridViewTextBoxColumn331
        '
        Me.DataGridViewTextBoxColumn331.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn331.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn331.Name = "DataGridViewTextBoxColumn331"
        Me.DataGridViewTextBoxColumn331.Width = 125
        '
        'DataGridViewTextBoxColumn332
        '
        Me.DataGridViewTextBoxColumn332.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn332.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn332.Name = "DataGridViewTextBoxColumn332"
        Me.DataGridViewTextBoxColumn332.Width = 125
        '
        'DataGridViewTextBoxColumn333
        '
        Me.DataGridViewTextBoxColumn333.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn333.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn333.Name = "DataGridViewTextBoxColumn333"
        Me.DataGridViewTextBoxColumn333.ReadOnly = True
        Me.DataGridViewTextBoxColumn333.Width = 125
        '
        'DataGridViewTextBoxColumn326
        '
        Me.DataGridViewTextBoxColumn326.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn326.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn326.Name = "DataGridViewTextBoxColumn326"
        Me.DataGridViewTextBoxColumn326.Width = 125
        '
        'DataGridViewTextBoxColumn327
        '
        Me.DataGridViewTextBoxColumn327.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn327.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn327.Name = "DataGridViewTextBoxColumn327"
        Me.DataGridViewTextBoxColumn327.Width = 125
        '
        'DataGridViewTextBoxColumn328
        '
        Me.DataGridViewTextBoxColumn328.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn328.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn328.Name = "DataGridViewTextBoxColumn328"
        Me.DataGridViewTextBoxColumn328.Width = 125
        '
        'DataGridViewTextBoxColumn329
        '
        Me.DataGridViewTextBoxColumn329.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn329.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn329.Name = "DataGridViewTextBoxColumn329"
        Me.DataGridViewTextBoxColumn329.ReadOnly = True
        Me.DataGridViewTextBoxColumn329.Width = 125
        '
        'DataGridViewTextBoxColumn322
        '
        Me.DataGridViewTextBoxColumn322.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn322.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn322.Name = "DataGridViewTextBoxColumn322"
        Me.DataGridViewTextBoxColumn322.Width = 125
        '
        'DataGridViewTextBoxColumn323
        '
        Me.DataGridViewTextBoxColumn323.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn323.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn323.Name = "DataGridViewTextBoxColumn323"
        Me.DataGridViewTextBoxColumn323.Width = 125
        '
        'DataGridViewTextBoxColumn324
        '
        Me.DataGridViewTextBoxColumn324.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn324.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn324.Name = "DataGridViewTextBoxColumn324"
        Me.DataGridViewTextBoxColumn324.Width = 125
        '
        'DataGridViewTextBoxColumn325
        '
        Me.DataGridViewTextBoxColumn325.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn325.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn325.Name = "DataGridViewTextBoxColumn325"
        Me.DataGridViewTextBoxColumn325.ReadOnly = True
        Me.DataGridViewTextBoxColumn325.Width = 125
        '
        'DataGridViewTextBoxColumn318
        '
        Me.DataGridViewTextBoxColumn318.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn318.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn318.Name = "DataGridViewTextBoxColumn318"
        Me.DataGridViewTextBoxColumn318.Width = 125
        '
        'DataGridViewTextBoxColumn319
        '
        Me.DataGridViewTextBoxColumn319.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn319.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn319.Name = "DataGridViewTextBoxColumn319"
        Me.DataGridViewTextBoxColumn319.Width = 125
        '
        'DataGridViewTextBoxColumn320
        '
        Me.DataGridViewTextBoxColumn320.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn320.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn320.Name = "DataGridViewTextBoxColumn320"
        Me.DataGridViewTextBoxColumn320.Width = 125
        '
        'DataGridViewTextBoxColumn321
        '
        Me.DataGridViewTextBoxColumn321.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn321.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn321.Name = "DataGridViewTextBoxColumn321"
        Me.DataGridViewTextBoxColumn321.ReadOnly = True
        Me.DataGridViewTextBoxColumn321.Width = 125
        '
        'DataGridViewTextBoxColumn314
        '
        Me.DataGridViewTextBoxColumn314.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn314.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn314.Name = "DataGridViewTextBoxColumn314"
        Me.DataGridViewTextBoxColumn314.Width = 125
        '
        'DataGridViewTextBoxColumn315
        '
        Me.DataGridViewTextBoxColumn315.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn315.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn315.Name = "DataGridViewTextBoxColumn315"
        Me.DataGridViewTextBoxColumn315.Width = 125
        '
        'DataGridViewTextBoxColumn316
        '
        Me.DataGridViewTextBoxColumn316.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn316.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn316.Name = "DataGridViewTextBoxColumn316"
        Me.DataGridViewTextBoxColumn316.Width = 125
        '
        'DataGridViewTextBoxColumn317
        '
        Me.DataGridViewTextBoxColumn317.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn317.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn317.Name = "DataGridViewTextBoxColumn317"
        Me.DataGridViewTextBoxColumn317.ReadOnly = True
        Me.DataGridViewTextBoxColumn317.Width = 125
        '
        'DataGridViewTextBoxColumn310
        '
        Me.DataGridViewTextBoxColumn310.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn310.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn310.Name = "DataGridViewTextBoxColumn310"
        Me.DataGridViewTextBoxColumn310.Width = 125
        '
        'DataGridViewTextBoxColumn311
        '
        Me.DataGridViewTextBoxColumn311.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn311.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn311.Name = "DataGridViewTextBoxColumn311"
        Me.DataGridViewTextBoxColumn311.Width = 125
        '
        'DataGridViewTextBoxColumn312
        '
        Me.DataGridViewTextBoxColumn312.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn312.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn312.Name = "DataGridViewTextBoxColumn312"
        Me.DataGridViewTextBoxColumn312.Width = 125
        '
        'DataGridViewTextBoxColumn313
        '
        Me.DataGridViewTextBoxColumn313.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn313.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn313.Name = "DataGridViewTextBoxColumn313"
        Me.DataGridViewTextBoxColumn313.ReadOnly = True
        Me.DataGridViewTextBoxColumn313.Width = 125
        '
        'DataGridViewTextBoxColumn306
        '
        Me.DataGridViewTextBoxColumn306.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn306.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn306.Name = "DataGridViewTextBoxColumn306"
        Me.DataGridViewTextBoxColumn306.Width = 125
        '
        'DataGridViewTextBoxColumn307
        '
        Me.DataGridViewTextBoxColumn307.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn307.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn307.Name = "DataGridViewTextBoxColumn307"
        Me.DataGridViewTextBoxColumn307.Width = 125
        '
        'DataGridViewTextBoxColumn308
        '
        Me.DataGridViewTextBoxColumn308.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn308.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn308.Name = "DataGridViewTextBoxColumn308"
        Me.DataGridViewTextBoxColumn308.Width = 125
        '
        'DataGridViewTextBoxColumn309
        '
        Me.DataGridViewTextBoxColumn309.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn309.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn309.Name = "DataGridViewTextBoxColumn309"
        Me.DataGridViewTextBoxColumn309.ReadOnly = True
        Me.DataGridViewTextBoxColumn309.Width = 125
        '
        'DataGridViewTextBoxColumn302
        '
        Me.DataGridViewTextBoxColumn302.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn302.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn302.Name = "DataGridViewTextBoxColumn302"
        Me.DataGridViewTextBoxColumn302.Width = 125
        '
        'DataGridViewTextBoxColumn303
        '
        Me.DataGridViewTextBoxColumn303.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn303.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn303.Name = "DataGridViewTextBoxColumn303"
        Me.DataGridViewTextBoxColumn303.Width = 125
        '
        'DataGridViewTextBoxColumn304
        '
        Me.DataGridViewTextBoxColumn304.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn304.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn304.Name = "DataGridViewTextBoxColumn304"
        Me.DataGridViewTextBoxColumn304.Width = 125
        '
        'DataGridViewTextBoxColumn305
        '
        Me.DataGridViewTextBoxColumn305.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn305.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn305.Name = "DataGridViewTextBoxColumn305"
        Me.DataGridViewTextBoxColumn305.ReadOnly = True
        Me.DataGridViewTextBoxColumn305.Width = 125
        '
        'DataGridViewTextBoxColumn298
        '
        Me.DataGridViewTextBoxColumn298.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn298.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn298.Name = "DataGridViewTextBoxColumn298"
        Me.DataGridViewTextBoxColumn298.Width = 125
        '
        'DataGridViewTextBoxColumn299
        '
        Me.DataGridViewTextBoxColumn299.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn299.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn299.Name = "DataGridViewTextBoxColumn299"
        Me.DataGridViewTextBoxColumn299.Width = 125
        '
        'DataGridViewTextBoxColumn300
        '
        Me.DataGridViewTextBoxColumn300.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn300.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn300.Name = "DataGridViewTextBoxColumn300"
        Me.DataGridViewTextBoxColumn300.Width = 125
        '
        'DataGridViewTextBoxColumn301
        '
        Me.DataGridViewTextBoxColumn301.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn301.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn301.Name = "DataGridViewTextBoxColumn301"
        Me.DataGridViewTextBoxColumn301.ReadOnly = True
        Me.DataGridViewTextBoxColumn301.Width = 125
        '
        'DataGridViewTextBoxColumn294
        '
        Me.DataGridViewTextBoxColumn294.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn294.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn294.Name = "DataGridViewTextBoxColumn294"
        Me.DataGridViewTextBoxColumn294.Width = 125
        '
        'DataGridViewTextBoxColumn295
        '
        Me.DataGridViewTextBoxColumn295.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn295.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn295.Name = "DataGridViewTextBoxColumn295"
        Me.DataGridViewTextBoxColumn295.Width = 125
        '
        'DataGridViewTextBoxColumn296
        '
        Me.DataGridViewTextBoxColumn296.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn296.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn296.Name = "DataGridViewTextBoxColumn296"
        Me.DataGridViewTextBoxColumn296.Width = 125
        '
        'DataGridViewTextBoxColumn297
        '
        Me.DataGridViewTextBoxColumn297.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn297.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn297.Name = "DataGridViewTextBoxColumn297"
        Me.DataGridViewTextBoxColumn297.ReadOnly = True
        Me.DataGridViewTextBoxColumn297.Width = 125
        '
        'DataGridViewTextBoxColumn290
        '
        Me.DataGridViewTextBoxColumn290.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn290.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn290.Name = "DataGridViewTextBoxColumn290"
        Me.DataGridViewTextBoxColumn290.Width = 125
        '
        'DataGridViewTextBoxColumn291
        '
        Me.DataGridViewTextBoxColumn291.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn291.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn291.Name = "DataGridViewTextBoxColumn291"
        Me.DataGridViewTextBoxColumn291.Width = 125
        '
        'DataGridViewTextBoxColumn292
        '
        Me.DataGridViewTextBoxColumn292.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn292.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn292.Name = "DataGridViewTextBoxColumn292"
        Me.DataGridViewTextBoxColumn292.Width = 125
        '
        'DataGridViewTextBoxColumn293
        '
        Me.DataGridViewTextBoxColumn293.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn293.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn293.Name = "DataGridViewTextBoxColumn293"
        Me.DataGridViewTextBoxColumn293.ReadOnly = True
        Me.DataGridViewTextBoxColumn293.Width = 125
        '
        'DataGridViewTextBoxColumn286
        '
        Me.DataGridViewTextBoxColumn286.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn286.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn286.Name = "DataGridViewTextBoxColumn286"
        Me.DataGridViewTextBoxColumn286.Width = 125
        '
        'DataGridViewTextBoxColumn287
        '
        Me.DataGridViewTextBoxColumn287.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn287.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn287.Name = "DataGridViewTextBoxColumn287"
        Me.DataGridViewTextBoxColumn287.Width = 125
        '
        'DataGridViewTextBoxColumn288
        '
        Me.DataGridViewTextBoxColumn288.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn288.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn288.Name = "DataGridViewTextBoxColumn288"
        Me.DataGridViewTextBoxColumn288.Width = 125
        '
        'DataGridViewTextBoxColumn289
        '
        Me.DataGridViewTextBoxColumn289.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn289.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn289.Name = "DataGridViewTextBoxColumn289"
        Me.DataGridViewTextBoxColumn289.ReadOnly = True
        Me.DataGridViewTextBoxColumn289.Width = 125
        '
        'DataGridViewTextBoxColumn282
        '
        Me.DataGridViewTextBoxColumn282.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn282.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn282.Name = "DataGridViewTextBoxColumn282"
        Me.DataGridViewTextBoxColumn282.Width = 125
        '
        'DataGridViewTextBoxColumn283
        '
        Me.DataGridViewTextBoxColumn283.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn283.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn283.Name = "DataGridViewTextBoxColumn283"
        Me.DataGridViewTextBoxColumn283.Width = 125
        '
        'DataGridViewTextBoxColumn284
        '
        Me.DataGridViewTextBoxColumn284.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn284.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn284.Name = "DataGridViewTextBoxColumn284"
        Me.DataGridViewTextBoxColumn284.Width = 125
        '
        'DataGridViewTextBoxColumn285
        '
        Me.DataGridViewTextBoxColumn285.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn285.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn285.Name = "DataGridViewTextBoxColumn285"
        Me.DataGridViewTextBoxColumn285.ReadOnly = True
        Me.DataGridViewTextBoxColumn285.Width = 125
        '
        'DataGridViewTextBoxColumn278
        '
        Me.DataGridViewTextBoxColumn278.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn278.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn278.Name = "DataGridViewTextBoxColumn278"
        Me.DataGridViewTextBoxColumn278.Width = 125
        '
        'DataGridViewTextBoxColumn279
        '
        Me.DataGridViewTextBoxColumn279.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn279.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn279.Name = "DataGridViewTextBoxColumn279"
        Me.DataGridViewTextBoxColumn279.Width = 125
        '
        'DataGridViewTextBoxColumn280
        '
        Me.DataGridViewTextBoxColumn280.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn280.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn280.Name = "DataGridViewTextBoxColumn280"
        Me.DataGridViewTextBoxColumn280.Width = 125
        '
        'DataGridViewTextBoxColumn281
        '
        Me.DataGridViewTextBoxColumn281.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn281.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn281.Name = "DataGridViewTextBoxColumn281"
        Me.DataGridViewTextBoxColumn281.ReadOnly = True
        Me.DataGridViewTextBoxColumn281.Width = 125
        '
        'DataGridViewTextBoxColumn274
        '
        Me.DataGridViewTextBoxColumn274.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn274.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn274.Name = "DataGridViewTextBoxColumn274"
        Me.DataGridViewTextBoxColumn274.Width = 125
        '
        'DataGridViewTextBoxColumn275
        '
        Me.DataGridViewTextBoxColumn275.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn275.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn275.Name = "DataGridViewTextBoxColumn275"
        Me.DataGridViewTextBoxColumn275.Width = 125
        '
        'DataGridViewTextBoxColumn276
        '
        Me.DataGridViewTextBoxColumn276.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn276.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn276.Name = "DataGridViewTextBoxColumn276"
        Me.DataGridViewTextBoxColumn276.Width = 125
        '
        'DataGridViewTextBoxColumn277
        '
        Me.DataGridViewTextBoxColumn277.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn277.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn277.Name = "DataGridViewTextBoxColumn277"
        Me.DataGridViewTextBoxColumn277.ReadOnly = True
        Me.DataGridViewTextBoxColumn277.Width = 125
        '
        'DataGridViewTextBoxColumn270
        '
        Me.DataGridViewTextBoxColumn270.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn270.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn270.Name = "DataGridViewTextBoxColumn270"
        Me.DataGridViewTextBoxColumn270.Width = 125
        '
        'DataGridViewTextBoxColumn271
        '
        Me.DataGridViewTextBoxColumn271.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn271.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn271.Name = "DataGridViewTextBoxColumn271"
        Me.DataGridViewTextBoxColumn271.Width = 125
        '
        'DataGridViewTextBoxColumn272
        '
        Me.DataGridViewTextBoxColumn272.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn272.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn272.Name = "DataGridViewTextBoxColumn272"
        Me.DataGridViewTextBoxColumn272.Width = 125
        '
        'DataGridViewTextBoxColumn273
        '
        Me.DataGridViewTextBoxColumn273.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn273.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn273.Name = "DataGridViewTextBoxColumn273"
        Me.DataGridViewTextBoxColumn273.ReadOnly = True
        Me.DataGridViewTextBoxColumn273.Width = 125
        '
        'DataGridViewTextBoxColumn266
        '
        Me.DataGridViewTextBoxColumn266.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn266.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn266.Name = "DataGridViewTextBoxColumn266"
        Me.DataGridViewTextBoxColumn266.Width = 125
        '
        'DataGridViewTextBoxColumn267
        '
        Me.DataGridViewTextBoxColumn267.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn267.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn267.Name = "DataGridViewTextBoxColumn267"
        Me.DataGridViewTextBoxColumn267.Width = 125
        '
        'DataGridViewTextBoxColumn268
        '
        Me.DataGridViewTextBoxColumn268.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn268.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn268.Name = "DataGridViewTextBoxColumn268"
        Me.DataGridViewTextBoxColumn268.Width = 125
        '
        'DataGridViewTextBoxColumn269
        '
        Me.DataGridViewTextBoxColumn269.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn269.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn269.Name = "DataGridViewTextBoxColumn269"
        Me.DataGridViewTextBoxColumn269.ReadOnly = True
        Me.DataGridViewTextBoxColumn269.Width = 125
        '
        'DataGridViewTextBoxColumn262
        '
        Me.DataGridViewTextBoxColumn262.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn262.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn262.Name = "DataGridViewTextBoxColumn262"
        Me.DataGridViewTextBoxColumn262.Width = 125
        '
        'DataGridViewTextBoxColumn263
        '
        Me.DataGridViewTextBoxColumn263.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn263.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn263.Name = "DataGridViewTextBoxColumn263"
        Me.DataGridViewTextBoxColumn263.Width = 125
        '
        'DataGridViewTextBoxColumn264
        '
        Me.DataGridViewTextBoxColumn264.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn264.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn264.Name = "DataGridViewTextBoxColumn264"
        Me.DataGridViewTextBoxColumn264.Width = 125
        '
        'DataGridViewTextBoxColumn265
        '
        Me.DataGridViewTextBoxColumn265.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn265.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn265.Name = "DataGridViewTextBoxColumn265"
        Me.DataGridViewTextBoxColumn265.ReadOnly = True
        Me.DataGridViewTextBoxColumn265.Width = 125
        '
        'DataGridViewTextBoxColumn257
        '
        Me.DataGridViewTextBoxColumn257.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn257.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn257.Name = "DataGridViewTextBoxColumn257"
        Me.DataGridViewTextBoxColumn257.Width = 125
        '
        'DataGridViewTextBoxColumn258
        '
        Me.DataGridViewTextBoxColumn258.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn258.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn258.Name = "DataGridViewTextBoxColumn258"
        Me.DataGridViewTextBoxColumn258.Width = 125
        '
        'DataGridViewTextBoxColumn259
        '
        Me.DataGridViewTextBoxColumn259.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn259.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn259.Name = "DataGridViewTextBoxColumn259"
        Me.DataGridViewTextBoxColumn259.Width = 125
        '
        'DataGridViewTextBoxColumn254
        '
        Me.DataGridViewTextBoxColumn254.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn254.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn254.Name = "DataGridViewTextBoxColumn254"
        Me.DataGridViewTextBoxColumn254.Width = 125
        '
        'DataGridViewTextBoxColumn255
        '
        Me.DataGridViewTextBoxColumn255.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn255.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn255.Name = "DataGridViewTextBoxColumn255"
        Me.DataGridViewTextBoxColumn255.Width = 125
        '
        'DataGridViewTextBoxColumn256
        '
        Me.DataGridViewTextBoxColumn256.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn256.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn256.Name = "DataGridViewTextBoxColumn256"
        Me.DataGridViewTextBoxColumn256.Width = 125
        '
        'DataGridViewTextBoxColumn250
        '
        Me.DataGridViewTextBoxColumn250.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn250.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn250.Name = "DataGridViewTextBoxColumn250"
        Me.DataGridViewTextBoxColumn250.Width = 125
        '
        'DataGridViewTextBoxColumn252
        '
        Me.DataGridViewTextBoxColumn252.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn252.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn252.Name = "DataGridViewTextBoxColumn252"
        Me.DataGridViewTextBoxColumn252.Width = 125
        '
        'DataGridViewTextBoxColumn253
        '
        Me.DataGridViewTextBoxColumn253.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn253.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn253.Name = "DataGridViewTextBoxColumn253"
        Me.DataGridViewTextBoxColumn253.Width = 125
        '
        'DataGridViewTextBoxColumn248
        '
        Me.DataGridViewTextBoxColumn248.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn248.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn248.Name = "DataGridViewTextBoxColumn248"
        Me.DataGridViewTextBoxColumn248.Width = 125
        '
        'DataGridViewTextBoxColumn249
        '
        Me.DataGridViewTextBoxColumn249.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn249.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn249.Name = "DataGridViewTextBoxColumn249"
        Me.DataGridViewTextBoxColumn249.Width = 125
        '
        'DataGridViewTextBoxColumn251
        '
        Me.DataGridViewTextBoxColumn251.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn251.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn251.Name = "DataGridViewTextBoxColumn251"
        Me.DataGridViewTextBoxColumn251.Width = 125
        '
        'DataGridViewTextBoxColumn244
        '
        Me.DataGridViewTextBoxColumn244.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn244.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn244.Name = "DataGridViewTextBoxColumn244"
        Me.DataGridViewTextBoxColumn244.Width = 125
        '
        'DataGridViewTextBoxColumn245
        '
        Me.DataGridViewTextBoxColumn245.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn245.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn245.Name = "DataGridViewTextBoxColumn245"
        Me.DataGridViewTextBoxColumn245.Width = 125
        '
        'DataGridViewTextBoxColumn246
        '
        Me.DataGridViewTextBoxColumn246.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn246.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn246.Name = "DataGridViewTextBoxColumn246"
        Me.DataGridViewTextBoxColumn246.Width = 125
        '
        'DataGridViewTextBoxColumn247
        '
        Me.DataGridViewTextBoxColumn247.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn247.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn247.Name = "DataGridViewTextBoxColumn247"
        Me.DataGridViewTextBoxColumn247.Width = 125
        '
        'DataGridViewTextBoxColumn240
        '
        Me.DataGridViewTextBoxColumn240.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn240.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn240.Name = "DataGridViewTextBoxColumn240"
        Me.DataGridViewTextBoxColumn240.Width = 125
        '
        'DataGridViewTextBoxColumn241
        '
        Me.DataGridViewTextBoxColumn241.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn241.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn241.Name = "DataGridViewTextBoxColumn241"
        Me.DataGridViewTextBoxColumn241.Width = 125
        '
        'DataGridViewTextBoxColumn242
        '
        Me.DataGridViewTextBoxColumn242.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn242.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn242.Name = "DataGridViewTextBoxColumn242"
        Me.DataGridViewTextBoxColumn242.Width = 125
        '
        'DataGridViewTextBoxColumn243
        '
        Me.DataGridViewTextBoxColumn243.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn243.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn243.Name = "DataGridViewTextBoxColumn243"
        Me.DataGridViewTextBoxColumn243.Width = 125
        '
        'DataGridViewTextBoxColumn236
        '
        Me.DataGridViewTextBoxColumn236.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn236.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn236.Name = "DataGridViewTextBoxColumn236"
        Me.DataGridViewTextBoxColumn236.Width = 125
        '
        'DataGridViewTextBoxColumn237
        '
        Me.DataGridViewTextBoxColumn237.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn237.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn237.Name = "DataGridViewTextBoxColumn237"
        Me.DataGridViewTextBoxColumn237.Width = 125
        '
        'DataGridViewTextBoxColumn238
        '
        Me.DataGridViewTextBoxColumn238.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn238.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn238.Name = "DataGridViewTextBoxColumn238"
        Me.DataGridViewTextBoxColumn238.Width = 125
        '
        'DataGridViewTextBoxColumn239
        '
        Me.DataGridViewTextBoxColumn239.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn239.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn239.Name = "DataGridViewTextBoxColumn239"
        Me.DataGridViewTextBoxColumn239.Width = 125
        '
        'DataGridViewTextBoxColumn232
        '
        Me.DataGridViewTextBoxColumn232.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn232.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn232.Name = "DataGridViewTextBoxColumn232"
        Me.DataGridViewTextBoxColumn232.Width = 125
        '
        'DataGridViewTextBoxColumn233
        '
        Me.DataGridViewTextBoxColumn233.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn233.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn233.Name = "DataGridViewTextBoxColumn233"
        Me.DataGridViewTextBoxColumn233.Width = 125
        '
        'DataGridViewTextBoxColumn234
        '
        Me.DataGridViewTextBoxColumn234.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn234.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn234.Name = "DataGridViewTextBoxColumn234"
        Me.DataGridViewTextBoxColumn234.Width = 125
        '
        'DataGridViewTextBoxColumn235
        '
        Me.DataGridViewTextBoxColumn235.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn235.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn235.Name = "DataGridViewTextBoxColumn235"
        Me.DataGridViewTextBoxColumn235.Width = 125
        '
        'DataGridViewTextBoxColumn228
        '
        Me.DataGridViewTextBoxColumn228.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn228.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn228.Name = "DataGridViewTextBoxColumn228"
        Me.DataGridViewTextBoxColumn228.Width = 125
        '
        'DataGridViewTextBoxColumn229
        '
        Me.DataGridViewTextBoxColumn229.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn229.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn229.Name = "DataGridViewTextBoxColumn229"
        Me.DataGridViewTextBoxColumn229.Width = 125
        '
        'DataGridViewTextBoxColumn230
        '
        Me.DataGridViewTextBoxColumn230.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn230.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn230.Name = "DataGridViewTextBoxColumn230"
        Me.DataGridViewTextBoxColumn230.Width = 125
        '
        'DataGridViewTextBoxColumn231
        '
        Me.DataGridViewTextBoxColumn231.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn231.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn231.Name = "DataGridViewTextBoxColumn231"
        Me.DataGridViewTextBoxColumn231.Width = 125
        '
        'DataGridViewTextBoxColumn224
        '
        Me.DataGridViewTextBoxColumn224.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn224.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn224.Name = "DataGridViewTextBoxColumn224"
        Me.DataGridViewTextBoxColumn224.Width = 125
        '
        'DataGridViewTextBoxColumn225
        '
        Me.DataGridViewTextBoxColumn225.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn225.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn225.Name = "DataGridViewTextBoxColumn225"
        Me.DataGridViewTextBoxColumn225.Width = 125
        '
        'DataGridViewTextBoxColumn226
        '
        Me.DataGridViewTextBoxColumn226.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn226.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn226.Name = "DataGridViewTextBoxColumn226"
        Me.DataGridViewTextBoxColumn226.Width = 125
        '
        'DataGridViewTextBoxColumn227
        '
        Me.DataGridViewTextBoxColumn227.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn227.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn227.Name = "DataGridViewTextBoxColumn227"
        Me.DataGridViewTextBoxColumn227.Width = 125
        '
        'DataGridViewTextBoxColumn220
        '
        Me.DataGridViewTextBoxColumn220.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn220.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn220.Name = "DataGridViewTextBoxColumn220"
        Me.DataGridViewTextBoxColumn220.Width = 125
        '
        'DataGridViewTextBoxColumn221
        '
        Me.DataGridViewTextBoxColumn221.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn221.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn221.Name = "DataGridViewTextBoxColumn221"
        Me.DataGridViewTextBoxColumn221.Width = 125
        '
        'DataGridViewTextBoxColumn222
        '
        Me.DataGridViewTextBoxColumn222.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn222.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn222.Name = "DataGridViewTextBoxColumn222"
        Me.DataGridViewTextBoxColumn222.Width = 125
        '
        'DataGridViewTextBoxColumn223
        '
        Me.DataGridViewTextBoxColumn223.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn223.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn223.Name = "DataGridViewTextBoxColumn223"
        Me.DataGridViewTextBoxColumn223.Width = 125
        '
        'DataGridViewTextBoxColumn216
        '
        Me.DataGridViewTextBoxColumn216.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn216.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn216.Name = "DataGridViewTextBoxColumn216"
        Me.DataGridViewTextBoxColumn216.Width = 125
        '
        'DataGridViewTextBoxColumn217
        '
        Me.DataGridViewTextBoxColumn217.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn217.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn217.Name = "DataGridViewTextBoxColumn217"
        Me.DataGridViewTextBoxColumn217.Width = 125
        '
        'DataGridViewTextBoxColumn218
        '
        Me.DataGridViewTextBoxColumn218.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn218.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn218.Name = "DataGridViewTextBoxColumn218"
        Me.DataGridViewTextBoxColumn218.Width = 125
        '
        'DataGridViewTextBoxColumn219
        '
        Me.DataGridViewTextBoxColumn219.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn219.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn219.Name = "DataGridViewTextBoxColumn219"
        Me.DataGridViewTextBoxColumn219.Width = 125
        '
        'DataGridViewTextBoxColumn212
        '
        Me.DataGridViewTextBoxColumn212.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn212.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn212.Name = "DataGridViewTextBoxColumn212"
        Me.DataGridViewTextBoxColumn212.Width = 125
        '
        'DataGridViewTextBoxColumn213
        '
        Me.DataGridViewTextBoxColumn213.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn213.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn213.Name = "DataGridViewTextBoxColumn213"
        Me.DataGridViewTextBoxColumn213.Width = 125
        '
        'DataGridViewTextBoxColumn214
        '
        Me.DataGridViewTextBoxColumn214.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn214.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn214.Name = "DataGridViewTextBoxColumn214"
        Me.DataGridViewTextBoxColumn214.Width = 125
        '
        'DataGridViewTextBoxColumn215
        '
        Me.DataGridViewTextBoxColumn215.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn215.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn215.Name = "DataGridViewTextBoxColumn215"
        Me.DataGridViewTextBoxColumn215.Width = 125
        '
        'DataGridViewTextBoxColumn208
        '
        Me.DataGridViewTextBoxColumn208.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn208.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn208.Name = "DataGridViewTextBoxColumn208"
        Me.DataGridViewTextBoxColumn208.Width = 125
        '
        'DataGridViewTextBoxColumn209
        '
        Me.DataGridViewTextBoxColumn209.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn209.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn209.Name = "DataGridViewTextBoxColumn209"
        Me.DataGridViewTextBoxColumn209.Width = 125
        '
        'DataGridViewTextBoxColumn210
        '
        Me.DataGridViewTextBoxColumn210.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn210.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn210.Name = "DataGridViewTextBoxColumn210"
        Me.DataGridViewTextBoxColumn210.Width = 125
        '
        'DataGridViewTextBoxColumn211
        '
        Me.DataGridViewTextBoxColumn211.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn211.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn211.Name = "DataGridViewTextBoxColumn211"
        Me.DataGridViewTextBoxColumn211.Width = 125
        '
        'DataGridViewTextBoxColumn204
        '
        Me.DataGridViewTextBoxColumn204.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn204.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn204.Name = "DataGridViewTextBoxColumn204"
        Me.DataGridViewTextBoxColumn204.Width = 125
        '
        'DataGridViewTextBoxColumn205
        '
        Me.DataGridViewTextBoxColumn205.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn205.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn205.Name = "DataGridViewTextBoxColumn205"
        Me.DataGridViewTextBoxColumn205.Width = 125
        '
        'DataGridViewTextBoxColumn206
        '
        Me.DataGridViewTextBoxColumn206.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn206.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn206.Name = "DataGridViewTextBoxColumn206"
        Me.DataGridViewTextBoxColumn206.Width = 125
        '
        'DataGridViewTextBoxColumn207
        '
        Me.DataGridViewTextBoxColumn207.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn207.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn207.Name = "DataGridViewTextBoxColumn207"
        Me.DataGridViewTextBoxColumn207.Width = 125
        '
        'DataGridViewTextBoxColumn200
        '
        Me.DataGridViewTextBoxColumn200.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn200.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn200.Name = "DataGridViewTextBoxColumn200"
        Me.DataGridViewTextBoxColumn200.Width = 125
        '
        'DataGridViewTextBoxColumn201
        '
        Me.DataGridViewTextBoxColumn201.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn201.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn201.Name = "DataGridViewTextBoxColumn201"
        Me.DataGridViewTextBoxColumn201.Width = 125
        '
        'DataGridViewTextBoxColumn202
        '
        Me.DataGridViewTextBoxColumn202.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn202.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn202.Name = "DataGridViewTextBoxColumn202"
        Me.DataGridViewTextBoxColumn202.Width = 125
        '
        'DataGridViewTextBoxColumn203
        '
        Me.DataGridViewTextBoxColumn203.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn203.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn203.Name = "DataGridViewTextBoxColumn203"
        Me.DataGridViewTextBoxColumn203.Width = 125
        '
        'DataGridViewTextBoxColumn196
        '
        Me.DataGridViewTextBoxColumn196.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn196.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn196.Name = "DataGridViewTextBoxColumn196"
        Me.DataGridViewTextBoxColumn196.Width = 125
        '
        'DataGridViewTextBoxColumn197
        '
        Me.DataGridViewTextBoxColumn197.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn197.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn197.Name = "DataGridViewTextBoxColumn197"
        Me.DataGridViewTextBoxColumn197.Width = 125
        '
        'DataGridViewTextBoxColumn198
        '
        Me.DataGridViewTextBoxColumn198.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn198.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn198.Name = "DataGridViewTextBoxColumn198"
        Me.DataGridViewTextBoxColumn198.Width = 125
        '
        'DataGridViewTextBoxColumn199
        '
        Me.DataGridViewTextBoxColumn199.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn199.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn199.Name = "DataGridViewTextBoxColumn199"
        Me.DataGridViewTextBoxColumn199.Width = 125
        '
        'DataGridViewTextBoxColumn184
        '
        Me.DataGridViewTextBoxColumn184.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn184.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn184.Name = "DataGridViewTextBoxColumn184"
        Me.DataGridViewTextBoxColumn184.Width = 125
        '
        'DataGridViewTextBoxColumn188
        '
        Me.DataGridViewTextBoxColumn188.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn188.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn188.Name = "DataGridViewTextBoxColumn188"
        Me.DataGridViewTextBoxColumn188.Width = 125
        '
        'DataGridViewTextBoxColumn185
        '
        Me.DataGridViewTextBoxColumn185.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn185.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn185.Name = "DataGridViewTextBoxColumn185"
        Me.DataGridViewTextBoxColumn185.Width = 125
        '
        'DataGridViewTextBoxColumn189
        '
        Me.DataGridViewTextBoxColumn189.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn189.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn189.Name = "DataGridViewTextBoxColumn189"
        Me.DataGridViewTextBoxColumn189.Width = 125
        '
        'DataGridViewTextBoxColumn186
        '
        Me.DataGridViewTextBoxColumn186.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn186.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn186.Name = "DataGridViewTextBoxColumn186"
        Me.DataGridViewTextBoxColumn186.Width = 125
        '
        'DataGridViewTextBoxColumn190
        '
        Me.DataGridViewTextBoxColumn190.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn190.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn190.Name = "DataGridViewTextBoxColumn190"
        Me.DataGridViewTextBoxColumn190.Width = 125
        '
        'DataGridViewTextBoxColumn187
        '
        Me.DataGridViewTextBoxColumn187.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn187.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn187.Name = "DataGridViewTextBoxColumn187"
        Me.DataGridViewTextBoxColumn187.Width = 125
        '
        'DataGridViewTextBoxColumn191
        '
        Me.DataGridViewTextBoxColumn191.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn191.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn191.Name = "DataGridViewTextBoxColumn191"
        Me.DataGridViewTextBoxColumn191.Width = 125
        '
        'DataGridViewTextBoxColumn180
        '
        Me.DataGridViewTextBoxColumn180.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn180.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn180.Name = "DataGridViewTextBoxColumn180"
        Me.DataGridViewTextBoxColumn180.Width = 125
        '
        'DataGridViewTextBoxColumn181
        '
        Me.DataGridViewTextBoxColumn181.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn181.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn181.Name = "DataGridViewTextBoxColumn181"
        Me.DataGridViewTextBoxColumn181.Width = 125
        '
        'DataGridViewTextBoxColumn182
        '
        Me.DataGridViewTextBoxColumn182.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn182.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn182.Name = "DataGridViewTextBoxColumn182"
        Me.DataGridViewTextBoxColumn182.Width = 125
        '
        'DataGridViewTextBoxColumn183
        '
        Me.DataGridViewTextBoxColumn183.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn183.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn183.Name = "DataGridViewTextBoxColumn183"
        Me.DataGridViewTextBoxColumn183.Width = 125
        '
        'DataGridViewTextBoxColumn176
        '
        Me.DataGridViewTextBoxColumn176.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn176.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn176.Name = "DataGridViewTextBoxColumn176"
        Me.DataGridViewTextBoxColumn176.Width = 125
        '
        'DataGridViewTextBoxColumn177
        '
        Me.DataGridViewTextBoxColumn177.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn177.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn177.Name = "DataGridViewTextBoxColumn177"
        Me.DataGridViewTextBoxColumn177.Width = 125
        '
        'DataGridViewTextBoxColumn178
        '
        Me.DataGridViewTextBoxColumn178.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn178.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn178.Name = "DataGridViewTextBoxColumn178"
        Me.DataGridViewTextBoxColumn178.Width = 125
        '
        'DataGridViewTextBoxColumn179
        '
        Me.DataGridViewTextBoxColumn179.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn179.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn179.Name = "DataGridViewTextBoxColumn179"
        Me.DataGridViewTextBoxColumn179.Width = 125
        '
        'DataGridViewTextBoxColumn172
        '
        Me.DataGridViewTextBoxColumn172.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn172.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn172.Name = "DataGridViewTextBoxColumn172"
        Me.DataGridViewTextBoxColumn172.Width = 125
        '
        'DataGridViewTextBoxColumn173
        '
        Me.DataGridViewTextBoxColumn173.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn173.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn173.Name = "DataGridViewTextBoxColumn173"
        Me.DataGridViewTextBoxColumn173.Width = 125
        '
        'DataGridViewTextBoxColumn174
        '
        Me.DataGridViewTextBoxColumn174.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn174.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn174.Name = "DataGridViewTextBoxColumn174"
        Me.DataGridViewTextBoxColumn174.Width = 125
        '
        'DataGridViewTextBoxColumn175
        '
        Me.DataGridViewTextBoxColumn175.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn175.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn175.Name = "DataGridViewTextBoxColumn175"
        Me.DataGridViewTextBoxColumn175.Width = 125
        '
        'DataGridViewTextBoxColumn168
        '
        Me.DataGridViewTextBoxColumn168.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn168.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn168.Name = "DataGridViewTextBoxColumn168"
        Me.DataGridViewTextBoxColumn168.Width = 125
        '
        'DataGridViewTextBoxColumn169
        '
        Me.DataGridViewTextBoxColumn169.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn169.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn169.Name = "DataGridViewTextBoxColumn169"
        Me.DataGridViewTextBoxColumn169.Width = 125
        '
        'DataGridViewTextBoxColumn170
        '
        Me.DataGridViewTextBoxColumn170.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn170.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn170.Name = "DataGridViewTextBoxColumn170"
        Me.DataGridViewTextBoxColumn170.Width = 125
        '
        'DataGridViewTextBoxColumn171
        '
        Me.DataGridViewTextBoxColumn171.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn171.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn171.Name = "DataGridViewTextBoxColumn171"
        Me.DataGridViewTextBoxColumn171.Width = 125
        '
        'DataGridViewTextBoxColumn164
        '
        Me.DataGridViewTextBoxColumn164.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn164.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn164.Name = "DataGridViewTextBoxColumn164"
        Me.DataGridViewTextBoxColumn164.Width = 125
        '
        'DataGridViewTextBoxColumn165
        '
        Me.DataGridViewTextBoxColumn165.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn165.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn165.Name = "DataGridViewTextBoxColumn165"
        Me.DataGridViewTextBoxColumn165.Width = 125
        '
        'DataGridViewTextBoxColumn166
        '
        Me.DataGridViewTextBoxColumn166.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn166.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn166.Name = "DataGridViewTextBoxColumn166"
        Me.DataGridViewTextBoxColumn166.Width = 125
        '
        'DataGridViewTextBoxColumn167
        '
        Me.DataGridViewTextBoxColumn167.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn167.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn167.Name = "DataGridViewTextBoxColumn167"
        Me.DataGridViewTextBoxColumn167.Width = 125
        '
        'DataGridViewTextBoxColumn160
        '
        Me.DataGridViewTextBoxColumn160.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn160.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn160.Name = "DataGridViewTextBoxColumn160"
        Me.DataGridViewTextBoxColumn160.Width = 125
        '
        'DataGridViewTextBoxColumn161
        '
        Me.DataGridViewTextBoxColumn161.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn161.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn161.Name = "DataGridViewTextBoxColumn161"
        Me.DataGridViewTextBoxColumn161.Width = 125
        '
        'DataGridViewTextBoxColumn162
        '
        Me.DataGridViewTextBoxColumn162.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn162.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn162.Name = "DataGridViewTextBoxColumn162"
        Me.DataGridViewTextBoxColumn162.Width = 125
        '
        'DataGridViewTextBoxColumn163
        '
        Me.DataGridViewTextBoxColumn163.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn163.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn163.Name = "DataGridViewTextBoxColumn163"
        Me.DataGridViewTextBoxColumn163.Width = 125
        '
        'DataGridViewTextBoxColumn156
        '
        Me.DataGridViewTextBoxColumn156.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn156.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn156.Name = "DataGridViewTextBoxColumn156"
        Me.DataGridViewTextBoxColumn156.Width = 125
        '
        'DataGridViewTextBoxColumn157
        '
        Me.DataGridViewTextBoxColumn157.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn157.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn157.Name = "DataGridViewTextBoxColumn157"
        Me.DataGridViewTextBoxColumn157.Width = 125
        '
        'DataGridViewTextBoxColumn158
        '
        Me.DataGridViewTextBoxColumn158.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn158.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn158.Name = "DataGridViewTextBoxColumn158"
        Me.DataGridViewTextBoxColumn158.Width = 125
        '
        'DataGridViewTextBoxColumn159
        '
        Me.DataGridViewTextBoxColumn159.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn159.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn159.Name = "DataGridViewTextBoxColumn159"
        Me.DataGridViewTextBoxColumn159.Width = 125
        '
        'DataGridViewTextBoxColumn152
        '
        Me.DataGridViewTextBoxColumn152.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn152.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn152.Name = "DataGridViewTextBoxColumn152"
        Me.DataGridViewTextBoxColumn152.Width = 125
        '
        'DataGridViewTextBoxColumn153
        '
        Me.DataGridViewTextBoxColumn153.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn153.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn153.Name = "DataGridViewTextBoxColumn153"
        Me.DataGridViewTextBoxColumn153.Width = 125
        '
        'DataGridViewTextBoxColumn154
        '
        Me.DataGridViewTextBoxColumn154.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn154.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn154.Name = "DataGridViewTextBoxColumn154"
        Me.DataGridViewTextBoxColumn154.Width = 125
        '
        'DataGridViewTextBoxColumn155
        '
        Me.DataGridViewTextBoxColumn155.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn155.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn155.Name = "DataGridViewTextBoxColumn155"
        Me.DataGridViewTextBoxColumn155.Width = 125
        '
        'DataGridViewTextBoxColumn148
        '
        Me.DataGridViewTextBoxColumn148.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn148.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn148.Name = "DataGridViewTextBoxColumn148"
        Me.DataGridViewTextBoxColumn148.Width = 125
        '
        'DataGridViewTextBoxColumn149
        '
        Me.DataGridViewTextBoxColumn149.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn149.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn149.Name = "DataGridViewTextBoxColumn149"
        Me.DataGridViewTextBoxColumn149.Width = 125
        '
        'DataGridViewTextBoxColumn150
        '
        Me.DataGridViewTextBoxColumn150.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn150.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn150.Name = "DataGridViewTextBoxColumn150"
        Me.DataGridViewTextBoxColumn150.Width = 125
        '
        'DataGridViewTextBoxColumn151
        '
        Me.DataGridViewTextBoxColumn151.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn151.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn151.Name = "DataGridViewTextBoxColumn151"
        Me.DataGridViewTextBoxColumn151.Width = 125
        '
        'DataGridViewTextBoxColumn144
        '
        Me.DataGridViewTextBoxColumn144.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn144.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn144.Name = "DataGridViewTextBoxColumn144"
        Me.DataGridViewTextBoxColumn144.Width = 125
        '
        'DataGridViewTextBoxColumn145
        '
        Me.DataGridViewTextBoxColumn145.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn145.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn145.Name = "DataGridViewTextBoxColumn145"
        Me.DataGridViewTextBoxColumn145.Width = 125
        '
        'DataGridViewTextBoxColumn146
        '
        Me.DataGridViewTextBoxColumn146.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn146.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn146.Name = "DataGridViewTextBoxColumn146"
        Me.DataGridViewTextBoxColumn146.Width = 125
        '
        'DataGridViewTextBoxColumn147
        '
        Me.DataGridViewTextBoxColumn147.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn147.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn147.Name = "DataGridViewTextBoxColumn147"
        Me.DataGridViewTextBoxColumn147.Width = 125
        '
        'DataGridViewTextBoxColumn140
        '
        Me.DataGridViewTextBoxColumn140.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn140.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn140.Name = "DataGridViewTextBoxColumn140"
        Me.DataGridViewTextBoxColumn140.Width = 125
        '
        'DataGridViewTextBoxColumn141
        '
        Me.DataGridViewTextBoxColumn141.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn141.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn141.Name = "DataGridViewTextBoxColumn141"
        Me.DataGridViewTextBoxColumn141.Width = 125
        '
        'DataGridViewTextBoxColumn142
        '
        Me.DataGridViewTextBoxColumn142.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn142.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn142.Name = "DataGridViewTextBoxColumn142"
        Me.DataGridViewTextBoxColumn142.Width = 125
        '
        'DataGridViewTextBoxColumn143
        '
        Me.DataGridViewTextBoxColumn143.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn143.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn143.Name = "DataGridViewTextBoxColumn143"
        Me.DataGridViewTextBoxColumn143.Width = 125
        '
        'DataGridViewTextBoxColumn136
        '
        Me.DataGridViewTextBoxColumn136.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn136.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn136.Name = "DataGridViewTextBoxColumn136"
        Me.DataGridViewTextBoxColumn136.Width = 125
        '
        'DataGridViewTextBoxColumn137
        '
        Me.DataGridViewTextBoxColumn137.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn137.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn137.Name = "DataGridViewTextBoxColumn137"
        Me.DataGridViewTextBoxColumn137.Width = 125
        '
        'DataGridViewTextBoxColumn138
        '
        Me.DataGridViewTextBoxColumn138.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn138.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn138.Name = "DataGridViewTextBoxColumn138"
        Me.DataGridViewTextBoxColumn138.Width = 125
        '
        'DataGridViewTextBoxColumn139
        '
        Me.DataGridViewTextBoxColumn139.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn139.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn139.Name = "DataGridViewTextBoxColumn139"
        Me.DataGridViewTextBoxColumn139.Width = 125
        '
        'DataGridViewTextBoxColumn132
        '
        Me.DataGridViewTextBoxColumn132.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn132.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn132.Name = "DataGridViewTextBoxColumn132"
        Me.DataGridViewTextBoxColumn132.Width = 125
        '
        'DataGridViewTextBoxColumn133
        '
        Me.DataGridViewTextBoxColumn133.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn133.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn133.Name = "DataGridViewTextBoxColumn133"
        Me.DataGridViewTextBoxColumn133.Width = 125
        '
        'DataGridViewTextBoxColumn135
        '
        Me.DataGridViewTextBoxColumn135.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn135.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn135.Name = "DataGridViewTextBoxColumn135"
        Me.DataGridViewTextBoxColumn135.Width = 125
        '
        'DataGridViewTextBoxColumn134
        '
        Me.DataGridViewTextBoxColumn134.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn134.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn134.Name = "DataGridViewTextBoxColumn134"
        Me.DataGridViewTextBoxColumn134.Width = 125
        '
        'DataGridViewTextBoxColumn128
        '
        Me.DataGridViewTextBoxColumn128.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn128.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn128.Name = "DataGridViewTextBoxColumn128"
        Me.DataGridViewTextBoxColumn128.Width = 125
        '
        'DataGridViewTextBoxColumn129
        '
        Me.DataGridViewTextBoxColumn129.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn129.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn129.Name = "DataGridViewTextBoxColumn129"
        Me.DataGridViewTextBoxColumn129.Width = 125
        '
        'DataGridViewTextBoxColumn130
        '
        Me.DataGridViewTextBoxColumn130.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn130.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn130.Name = "DataGridViewTextBoxColumn130"
        Me.DataGridViewTextBoxColumn130.Width = 125
        '
        'DataGridViewTextBoxColumn131
        '
        Me.DataGridViewTextBoxColumn131.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn131.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn131.Name = "DataGridViewTextBoxColumn131"
        Me.DataGridViewTextBoxColumn131.Width = 125
        '
        'DataGridViewTextBoxColumn124
        '
        Me.DataGridViewTextBoxColumn124.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn124.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn124.Name = "DataGridViewTextBoxColumn124"
        Me.DataGridViewTextBoxColumn124.Width = 125
        '
        'DataGridViewTextBoxColumn125
        '
        Me.DataGridViewTextBoxColumn125.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn125.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn125.Name = "DataGridViewTextBoxColumn125"
        Me.DataGridViewTextBoxColumn125.Width = 125
        '
        'DataGridViewTextBoxColumn126
        '
        Me.DataGridViewTextBoxColumn126.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn126.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn126.Name = "DataGridViewTextBoxColumn126"
        Me.DataGridViewTextBoxColumn126.Width = 125
        '
        'DataGridViewTextBoxColumn127
        '
        Me.DataGridViewTextBoxColumn127.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn127.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn127.Name = "DataGridViewTextBoxColumn127"
        Me.DataGridViewTextBoxColumn127.Width = 125
        '
        'DataGridViewTextBoxColumn120
        '
        Me.DataGridViewTextBoxColumn120.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn120.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn120.Name = "DataGridViewTextBoxColumn120"
        Me.DataGridViewTextBoxColumn120.Width = 125
        '
        'DataGridViewTextBoxColumn121
        '
        Me.DataGridViewTextBoxColumn121.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn121.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn121.Name = "DataGridViewTextBoxColumn121"
        Me.DataGridViewTextBoxColumn121.Width = 125
        '
        'DataGridViewTextBoxColumn122
        '
        Me.DataGridViewTextBoxColumn122.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn122.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn122.Name = "DataGridViewTextBoxColumn122"
        Me.DataGridViewTextBoxColumn122.Width = 125
        '
        'DataGridViewTextBoxColumn123
        '
        Me.DataGridViewTextBoxColumn123.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn123.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn123.Name = "DataGridViewTextBoxColumn123"
        Me.DataGridViewTextBoxColumn123.Width = 125
        '
        'DataGridViewTextBoxColumn117
        '
        Me.DataGridViewTextBoxColumn117.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn117.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn117.Name = "DataGridViewTextBoxColumn117"
        Me.DataGridViewTextBoxColumn117.Width = 125
        '
        'DataGridViewTextBoxColumn118
        '
        Me.DataGridViewTextBoxColumn118.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn118.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn118.Name = "DataGridViewTextBoxColumn118"
        Me.DataGridViewTextBoxColumn118.Width = 125
        '
        'DataGridViewTextBoxColumn119
        '
        Me.DataGridViewTextBoxColumn119.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn119.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn119.Name = "DataGridViewTextBoxColumn119"
        Me.DataGridViewTextBoxColumn119.Width = 125
        '
        'DataGridViewTextBoxColumn114
        '
        Me.DataGridViewTextBoxColumn114.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn114.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn114.Name = "DataGridViewTextBoxColumn114"
        Me.DataGridViewTextBoxColumn114.Width = 125
        '
        'DataGridViewTextBoxColumn115
        '
        Me.DataGridViewTextBoxColumn115.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn115.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn115.Name = "DataGridViewTextBoxColumn115"
        Me.DataGridViewTextBoxColumn115.Width = 125
        '
        'DataGridViewTextBoxColumn116
        '
        Me.DataGridViewTextBoxColumn116.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn116.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn116.Name = "DataGridViewTextBoxColumn116"
        Me.DataGridViewTextBoxColumn116.Width = 125
        '
        'DataGridViewTextBoxColumn111
        '
        Me.DataGridViewTextBoxColumn111.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn111.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn111.Name = "DataGridViewTextBoxColumn111"
        Me.DataGridViewTextBoxColumn111.Width = 125
        '
        'DataGridViewTextBoxColumn112
        '
        Me.DataGridViewTextBoxColumn112.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn112.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn112.Name = "DataGridViewTextBoxColumn112"
        Me.DataGridViewTextBoxColumn112.Width = 125
        '
        'DataGridViewTextBoxColumn113
        '
        Me.DataGridViewTextBoxColumn113.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn113.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn113.Name = "DataGridViewTextBoxColumn113"
        Me.DataGridViewTextBoxColumn113.Width = 125
        '
        'DataGridViewTextBoxColumn108
        '
        Me.DataGridViewTextBoxColumn108.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn108.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn108.Name = "DataGridViewTextBoxColumn108"
        Me.DataGridViewTextBoxColumn108.Width = 125
        '
        'DataGridViewTextBoxColumn109
        '
        Me.DataGridViewTextBoxColumn109.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn109.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn109.Name = "DataGridViewTextBoxColumn109"
        Me.DataGridViewTextBoxColumn109.Width = 125
        '
        'DataGridViewTextBoxColumn110
        '
        Me.DataGridViewTextBoxColumn110.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn110.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
        Me.DataGridViewTextBoxColumn110.Width = 125
        '
        'DataGridViewTextBoxColumn105
        '
        Me.DataGridViewTextBoxColumn105.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn105.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
        Me.DataGridViewTextBoxColumn105.Width = 125
        '
        'DataGridViewTextBoxColumn106
        '
        Me.DataGridViewTextBoxColumn106.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn106.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn106.Name = "DataGridViewTextBoxColumn106"
        Me.DataGridViewTextBoxColumn106.Width = 125
        '
        'DataGridViewTextBoxColumn107
        '
        Me.DataGridViewTextBoxColumn107.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn107.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn107.Name = "DataGridViewTextBoxColumn107"
        Me.DataGridViewTextBoxColumn107.Width = 125
        '
        'DataGridViewTextBoxColumn102
        '
        Me.DataGridViewTextBoxColumn102.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn102.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
        Me.DataGridViewTextBoxColumn102.Width = 125
        '
        'DataGridViewTextBoxColumn103
        '
        Me.DataGridViewTextBoxColumn103.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn103.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
        Me.DataGridViewTextBoxColumn103.Width = 125
        '
        'DataGridViewTextBoxColumn104
        '
        Me.DataGridViewTextBoxColumn104.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn104.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
        Me.DataGridViewTextBoxColumn104.Width = 125
        '
        'DataGridViewTextBoxColumn99
        '
        Me.DataGridViewTextBoxColumn99.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn99.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn99.Name = "DataGridViewTextBoxColumn99"
        Me.DataGridViewTextBoxColumn99.Width = 125
        '
        'DataGridViewTextBoxColumn100
        '
        Me.DataGridViewTextBoxColumn100.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn100.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn100.Name = "DataGridViewTextBoxColumn100"
        Me.DataGridViewTextBoxColumn100.Width = 125
        '
        'DataGridViewTextBoxColumn101
        '
        Me.DataGridViewTextBoxColumn101.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn101.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn101.Name = "DataGridViewTextBoxColumn101"
        Me.DataGridViewTextBoxColumn101.Width = 125
        '
        'DataGridViewTextBoxColumn96
        '
        Me.DataGridViewTextBoxColumn96.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn96.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn96.Name = "DataGridViewTextBoxColumn96"
        Me.DataGridViewTextBoxColumn96.Width = 125
        '
        'DataGridViewTextBoxColumn97
        '
        Me.DataGridViewTextBoxColumn97.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn97.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn97.Name = "DataGridViewTextBoxColumn97"
        Me.DataGridViewTextBoxColumn97.Width = 125
        '
        'DataGridViewTextBoxColumn98
        '
        Me.DataGridViewTextBoxColumn98.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn98.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn98.Name = "DataGridViewTextBoxColumn98"
        Me.DataGridViewTextBoxColumn98.Width = 125
        '
        'DataGridViewTextBoxColumn93
        '
        Me.DataGridViewTextBoxColumn93.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn93.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
        Me.DataGridViewTextBoxColumn93.Width = 125
        '
        'DataGridViewTextBoxColumn94
        '
        Me.DataGridViewTextBoxColumn94.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn94.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
        Me.DataGridViewTextBoxColumn94.Width = 125
        '
        'DataGridViewTextBoxColumn95
        '
        Me.DataGridViewTextBoxColumn95.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn95.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn95.Name = "DataGridViewTextBoxColumn95"
        Me.DataGridViewTextBoxColumn95.Width = 125
        '
        'DataGridViewTextBoxColumn90
        '
        Me.DataGridViewTextBoxColumn90.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn90.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
        Me.DataGridViewTextBoxColumn90.Width = 125
        '
        'DataGridViewTextBoxColumn91
        '
        Me.DataGridViewTextBoxColumn91.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn91.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
        Me.DataGridViewTextBoxColumn91.Width = 125
        '
        'DataGridViewTextBoxColumn92
        '
        Me.DataGridViewTextBoxColumn92.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn92.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
        Me.DataGridViewTextBoxColumn92.Width = 125
        '
        'DataGridViewTextBoxColumn87
        '
        Me.DataGridViewTextBoxColumn87.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn87.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
        Me.DataGridViewTextBoxColumn87.Width = 125
        '
        'DataGridViewTextBoxColumn88
        '
        Me.DataGridViewTextBoxColumn88.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn88.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
        Me.DataGridViewTextBoxColumn88.Width = 125
        '
        'DataGridViewTextBoxColumn89
        '
        Me.DataGridViewTextBoxColumn89.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn89.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
        Me.DataGridViewTextBoxColumn89.Width = 125
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn80.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        Me.DataGridViewTextBoxColumn80.Width = 125
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn82.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        Me.DataGridViewTextBoxColumn82.Width = 125
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn81.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        Me.DataGridViewTextBoxColumn81.Width = 125
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn83.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        Me.DataGridViewTextBoxColumn83.Width = 125
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn78.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        Me.DataGridViewTextBoxColumn78.Width = 125
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn79.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        Me.DataGridViewTextBoxColumn79.Width = 125
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn76.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        Me.DataGridViewTextBoxColumn76.Width = 125
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn77.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        Me.DataGridViewTextBoxColumn77.Width = 125
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn74.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        Me.DataGridViewTextBoxColumn74.Width = 125
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn75.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        Me.DataGridViewTextBoxColumn75.Width = 125
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn72.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.Width = 125
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn73.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.Width = 125
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn70.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.Width = 125
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn71.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.Width = 125
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn69.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        Me.DataGridViewTextBoxColumn69.Width = 125
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn68.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.Width = 125
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn66.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.Width = 125
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn67.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.Width = 125
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn64.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.Width = 125
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn65.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.Width = 125
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn62.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.Width = 125
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn63.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.Width = 125
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn60.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.Width = 125
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn61.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.Width = 125
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn58.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 125
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn59.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.Width = 125
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn56.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 125
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn57.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Width = 125
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn54.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 125
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn55.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Width = 125
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn52.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 125
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn53.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 125
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn50.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 125
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn51.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 125
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn48.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Width = 125
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn49.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 125
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn42.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 125
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn44.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 125
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn43.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 125
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn45.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 125
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn40.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 125
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn41.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 125
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 125
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'HeaderStrip1
        '
        Me.HeaderStrip1.AutoSize = False
        Me.HeaderStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip1.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip1.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.ToolStripSeparator1, Me.btnnuevo, Me.btnguardar, Me.btneliminar, Me.btnimprimir})
        Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip1.Name = "HeaderStrip1"
        Me.HeaderStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.HeaderStrip1.Size = New System.Drawing.Size(1205, 26)
        Me.HeaderStrip1.TabIndex = 2
        Me.HeaderStrip1.Text = "Opciones"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(73, 23)
        Me.ToolStripLabel6.Text = "Contratos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'btnnuevo
        '
        Me.btnnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevo.Image = Global.WWTS.Roles.Controles.My.Resources.Resources._new
        Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(29, 23)
        Me.btnnuevo.Text = "Nuevo"
        '
        'btnguardar
        '
        Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnguardar.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.save
        Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(29, 23)
        Me.btnguardar.Text = "Guardar"
        '
        'btneliminar
        '
        Me.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneliminar.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.delete
        Me.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(29, 23)
        Me.btneliminar.Text = "Eliminar"
        '
        'btnimprimir
        '
        Me.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnimprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratosToolStripMenuItem, Me.CertificadosDeTrabajoToolStripMenuItem, Me.AutorizaciónClaveIESSToolStripMenuItem, Me.AperturaCuentaBancacriaToolStripMenuItem, Me.TransferenciaDeSalaToolStripMenuItem, Me.TransaccionLaboralToolStripMenuItem})
        Me.btnimprimir.Image = Global.WWTS.Roles.Controles.My.Resources.Resources.print
        Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(34, 23)
        Me.btnimprimir.Text = "Imprimir contrato"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'CertificadosDeTrabajoToolStripMenuItem
        '
        Me.CertificadosDeTrabajoToolStripMenuItem.Name = "CertificadosDeTrabajoToolStripMenuItem"
        Me.CertificadosDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.CertificadosDeTrabajoToolStripMenuItem.Text = "Certificados de trabajo"
        '
        'AutorizaciónClaveIESSToolStripMenuItem
        '
        Me.AutorizaciónClaveIESSToolStripMenuItem.Name = "AutorizaciónClaveIESSToolStripMenuItem"
        Me.AutorizaciónClaveIESSToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.AutorizaciónClaveIESSToolStripMenuItem.Text = "Renuncia"
        '
        'AperturaCuentaBancacriaToolStripMenuItem
        '
        Me.AperturaCuentaBancacriaToolStripMenuItem.Name = "AperturaCuentaBancacriaToolStripMenuItem"
        Me.AperturaCuentaBancacriaToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.AperturaCuentaBancacriaToolStripMenuItem.Text = "Apertura Cuenta Bancacria"
        '
        'TransferenciaDeSalaToolStripMenuItem
        '
        Me.TransferenciaDeSalaToolStripMenuItem.Name = "TransferenciaDeSalaToolStripMenuItem"
        Me.TransferenciaDeSalaToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.TransferenciaDeSalaToolStripMenuItem.Text = "Transferencia de Sala"
        '
        'TransaccionLaboralToolStripMenuItem
        '
        Me.TransaccionLaboralToolStripMenuItem.Name = "TransaccionLaboralToolStripMenuItem"
        Me.TransaccionLaboralToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.TransaccionLaboralToolStripMenuItem.Text = "Transaccion Laboral"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn46.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 125
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn47.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 125
        '
        'DataGridViewTextBoxColumn84
        '
        Me.DataGridViewTextBoxColumn84.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn84.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
        Me.DataGridViewTextBoxColumn84.Width = 125
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn85.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        Me.DataGridViewTextBoxColumn85.Width = 125
        '
        'DataGridViewTextBoxColumn86
        '
        Me.DataGridViewTextBoxColumn86.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn86.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
        Me.DataGridViewTextBoxColumn86.Width = 125
        '
        'DataGridViewTextBoxColumn192
        '
        Me.DataGridViewTextBoxColumn192.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn192.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn192.Name = "DataGridViewTextBoxColumn192"
        Me.DataGridViewTextBoxColumn192.Width = 125
        '
        'DataGridViewTextBoxColumn193
        '
        Me.DataGridViewTextBoxColumn193.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn193.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn193.Name = "DataGridViewTextBoxColumn193"
        Me.DataGridViewTextBoxColumn193.Width = 125
        '
        'DataGridViewTextBoxColumn194
        '
        Me.DataGridViewTextBoxColumn194.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn194.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn194.Name = "DataGridViewTextBoxColumn194"
        Me.DataGridViewTextBoxColumn194.Width = 125
        '
        'DataGridViewTextBoxColumn195
        '
        Me.DataGridViewTextBoxColumn195.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn195.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn195.Name = "DataGridViewTextBoxColumn195"
        Me.DataGridViewTextBoxColumn195.Width = 125
        '
        'DataGridViewTextBoxColumn260
        '
        Me.DataGridViewTextBoxColumn260.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn260.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn260.Name = "DataGridViewTextBoxColumn260"
        Me.DataGridViewTextBoxColumn260.Width = 125
        '
        'DataGridViewTextBoxColumn261
        '
        Me.DataGridViewTextBoxColumn261.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn261.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn261.Name = "DataGridViewTextBoxColumn261"
        Me.DataGridViewTextBoxColumn261.Width = 125
        '
        'TabFichasMedicas
        '
        Me.TabFichasMedicas.Controls.Add(Me.CtlFichasMedicas1)
        Me.TabFichasMedicas.Location = New System.Drawing.Point(4, 25)
        Me.TabFichasMedicas.Name = "TabFichasMedicas"
        Me.TabFichasMedicas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFichasMedicas.Size = New System.Drawing.Size(1038, 231)
        Me.TabFichasMedicas.TabIndex = 12
        Me.TabFichasMedicas.Text = "Fichas Médicas"
        Me.TabFichasMedicas.UseVisualStyleBackColor = True
        '
        'CtlFichasMedicas1
        '
        Me.CtlFichasMedicas1.Contrato = Nothing
        Me.CtlFichasMedicas1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlFichasMedicas1.Location = New System.Drawing.Point(3, 3)
        Me.CtlFichasMedicas1.ModoenSeleccion = False
        Me.CtlFichasMedicas1.Name = "CtlFichasMedicas1"
        Me.CtlFichasMedicas1.Size = New System.Drawing.Size(1032, 225)
        Me.CtlFichasMedicas1.TabIndex = 0
        '
        'CtlContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.tvcontratos)
        Me.Controls.Add(Me.HeaderStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtlContrato"
        Me.Size = New System.Drawing.Size(1205, 286)
        Me.tb.ResumeLayout(False)
        Me.TabDatos.ResumeLayout(False)
        Me.pnldatos.ResumeLayout(False)
        Me.pnldatos.PerformLayout()
        Me.pnlcierre.ResumeLayout(False)
        Me.pnlcierre.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabOtros.ResumeLayout(False)
        Me.pnlotros.ResumeLayout(False)
        Me.pnlotros.PerformLayout()
        Me.TabObservaciones.ResumeLayout(False)
        Me.TabObservaciones.PerformLayout()
        Me.TabRubros.ResumeLayout(False)
        Me.pnlrubros.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSrubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderStrip2.ResumeLayout(False)
        Me.HeaderStrip2.PerformLayout()
        Me.TabEvaluaciones.ResumeLayout(False)
        Me.TabEvaluaciones.PerformLayout()
        Me.TabLlamadas.ResumeLayout(False)
        Me.pnlLlamadas.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSLlamadaAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderStrip3.ResumeLayout(False)
        Me.HeaderStrip3.PerformLayout()
        Me.TabVacacion.ResumeLayout(False)
        Me.TabLicencias.ResumeLayout(False)
        Me.pnlLicencias.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderStrip4.ResumeLayout(False)
        Me.HeaderStrip4.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSauditorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSueldos.ResumeLayout(False)
        CType(Me.dgsueldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSSueldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderStrip5.ResumeLayout(False)
        Me.HeaderStrip5.PerformLayout()
        CType(Me.BSVacacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderStrip1.ResumeLayout(False)
        Me.HeaderStrip1.PerformLayout()
        Me.TabFichasMedicas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvcontratos As System.Windows.Forms.TreeView
  Friend WithEvents ilestadocontrato As System.Windows.Forms.ImageList
  Friend WithEvents tb As System.Windows.Forms.TabControl
  Friend WithEvents CtlTipoContrato1 As Controles.CtlTipoContrato
  Friend WithEvents pnlcierre As System.Windows.Forms.Panel
  Friend WithEvents lblfeccierre As System.Windows.Forms.Label
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents cbotipoliq As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cbotiposalida As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Cerrado As System.Windows.Forms.CheckBox
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TabDatos As System.Windows.Forms.TabPage
  Friend WithEvents TabOtros As System.Windows.Forms.TabPage
  Friend WithEvents TabObservaciones As System.Windows.Forms.TabPage
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkafiliess As System.Windows.Forms.CheckBox
  Friend WithEvents Label35 As System.Windows.Forms.Label
  Friend WithEvents txtmotsal As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents chkpertsind As System.Windows.Forms.CheckBox
  Friend WithEvents chkjuicio As System.Windows.Forms.CheckBox
  Friend WithEvents chkcertvot As System.Windows.Forms.CheckBox
  Friend WithEvents chkcertsalud As System.Windows.Forms.CheckBox
  Friend WithEvents SmeanioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SmemesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SmediastrabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SmediasvacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SmesueldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SmeantiguedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SmevacacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstaPagadoD3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents EstaPagadoD4DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents EstaPagadoVacDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents EstaPagadoUtiDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents ComboBoxEmpresa1 As WWTS.General.Controles.ComboBoxEmpresa
  Friend WithEvents ComboBoxSucursal1 As WWTS.General.Controles.ComboBoxSucursal
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents dtfecafiliess As System.Windows.Forms.DateTimePicker
  Friend WithEvents pnlotros As System.Windows.Forms.Panel
  Friend WithEvents chkDescontarir As System.Windows.Forms.CheckBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents chkreglamentointerno As System.Windows.Forms.CheckBox
  Friend WithEvents chkrecordpolicial As System.Windows.Forms.CheckBox
  Friend WithEvents TabEvaluaciones As System.Windows.Forms.TabPage
  Friend WithEvents TabLlamadas As System.Windows.Forms.TabPage
  Friend WithEvents txtevaanual As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtevatrimestral As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents CtlAdjunto1 As WWTS.General.Controles.CtlAdjunto
  Friend WithEvents DataGridView2 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HeaderStrip3 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnnuevollamado As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminarllamado As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnimprimirllamado As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSLlamadaAtencion As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents ContratosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CertificadosDeTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabRubros As System.Windows.Forms.TabPage
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnnuevorubro As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminarrubro As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridView3 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSrubro As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSauditorias As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnabrirrubro As System.Windows.Forms.ToolStripButton
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboSeccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlCargo1 As Controles.CtlCargo
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlArea1 As Controles.CtlArea
  Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents cboDepartamento As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LnkSeleccion As System.Windows.Forms.LinkLabel
  Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabLicencias As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn83 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HeaderStrip4 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnnuevolicencia As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnabrirlicencia As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridView5 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents BSLicencia As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn87 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn88 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn89 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn84 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn85 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn86 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn90 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn91 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn92 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn93 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn94 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn95 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn96 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn97 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn98 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btneliminarlicencia As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn99 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn100 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn101 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn102 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn103 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn104 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn105 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn106 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn107 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn108 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn109 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn110 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn111 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn112 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn113 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn114 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn115 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn116 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn117 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn118 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn119 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSVacacion As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn120 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn121 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn122 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn123 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn124 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn125 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn126 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn127 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn128 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn129 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn130 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn131 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn132 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn133 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn134 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn135 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnnuevomulta As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn136 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn137 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn138 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn139 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnimprimirlicencia As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn140 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn141 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnabrirllamado As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn142 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn143 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxEstadoContrato As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents DataGridViewTextBoxColumn144 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn145 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn146 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn147 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn148 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn149 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn150 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn151 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn152 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn153 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn154 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn155 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn156 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn157 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn158 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn159 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn160 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn161 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn162 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn163 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn164 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn165 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn166 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn167 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn168 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn169 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn170 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn171 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn172 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn173 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn174 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn175 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn176 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn177 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn178 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn179 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn180 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn181 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn182 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn183 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn184 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn185 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn186 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn187 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn196 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn197 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn198 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn199 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabVacacion As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewTextBoxColumn188 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn189 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn190 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn191 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn192 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn193 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn194 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn195 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn200 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn201 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn202 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn203 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlPeriodoVacacion1 As CtlPeriodoVacacion
  Friend WithEvents DataGridViewTextBoxColumn204 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn205 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn206 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn207 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn208 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn209 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn210 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn211 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn212 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn213 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn214 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn215 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents AutorizaciónClaveIESSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn216 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn217 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn218 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn219 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn220 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn221 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn222 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn223 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlPatronoCombo1 As Controles.CtlPatronoCombo
  Friend WithEvents DataGridViewTextBoxColumn224 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn225 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn226 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn227 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents cboSubCentroCosto As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents DataGridViewTextBoxColumn228 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn229 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn230 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn231 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn232 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn233 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn234 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn235 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents AperturaCuentaBancacriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn236 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn237 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn238 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn239 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn240 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn241 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn242 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn243 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TransferenciaDeSalaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents pnldatos As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn244 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn245 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn246 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn247 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn248 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn249 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn251 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents pnlrubros As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn250 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn252 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn253 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents pnlLlamadas As System.Windows.Forms.Panel
  Friend WithEvents pnlLicencias As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn254 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn255 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn256 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TransaccionLaboralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn257 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn258 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn259 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents tabSueldos As System.Windows.Forms.TabPage
  Friend WithEvents dgsueldos As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn261 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn260 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSSueldos As System.Windows.Forms.BindingSource
  Friend WithEvents chkMensualizarVac As System.Windows.Forms.CheckBox
  Friend WithEvents chkMensualizarD4 As System.Windows.Forms.CheckBox
  Friend WithEvents chkMensualizarD3 As System.Windows.Forms.CheckBox
  Friend WithEvents DataGridViewTextBoxColumn262 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn263 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn264 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn265 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chkMensualizarFR As System.Windows.Forms.CheckBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn266 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn267 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn268 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn269 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn270 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn271 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn272 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn273 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn274 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn275 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn276 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn277 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn278 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn279 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn280 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn281 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn282 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn283 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn284 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn285 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn286 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn287 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn288 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn289 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn290 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn291 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn292 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn293 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn294 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn295 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn296 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn297 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn298 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn299 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn300 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn301 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn302 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn303 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn304 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn305 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn306 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn307 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn308 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn309 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn310 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn311 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn312 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn313 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn314 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn315 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn316 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn317 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn318 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn319 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn320 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn321 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn322 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn323 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn324 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn325 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn326 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn327 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn328 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn329 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn330 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn331 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn332 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn333 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HeaderStrip5 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnSueldosExcel As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn334 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn335 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn336 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn337 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btn_FondosReserva As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn338 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn339 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn340 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn341 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn342 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn343 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn344 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn345 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn346 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn347 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn348 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn349 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn350 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn351 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn352 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn353 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn354 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn355 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn356 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn357 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn358 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn359 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn360 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn361 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn362 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn363 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn364 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn365 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn366 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn367 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn368 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn369 As DataGridViewTextBoxColumn
    Friend WithEvents TabFichasMedicas As TabPage
    Friend WithEvents CtlFichasMedicas1 As FichasMedicas.Controles.CtlFichasMedicas
End Class
