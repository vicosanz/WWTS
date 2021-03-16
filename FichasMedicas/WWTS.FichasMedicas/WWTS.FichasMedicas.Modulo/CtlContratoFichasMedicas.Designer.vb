
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlContratoFichasMedicas
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlContratoFichasMedicas))
    Me.tvcontratos = New System.Windows.Forms.TreeView()
    Me.ilestadocontrato = New System.Windows.Forms.ImageList(Me.components)
    Me.tb = New System.Windows.Forms.TabControl()
    Me.TabDatos = New System.Windows.Forms.TabPage()
    Me.pnldatos = New System.Windows.Forms.Panel()
    Me.pnlcierre = New System.Windows.Forms.Panel()
    Me.lblfeccierre = New System.Windows.Forms.Label()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.cbotipoliq = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cbotiposalida = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Panel1 = New System.Windows.Forms.Panel()
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
    Me.TabRubros = New System.Windows.Forms.TabPage()
    Me.pnlrubros = New System.Windows.Forms.Panel()
    Me.DataGridView3 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn379 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSFichas = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn380 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnnuevaficha = New System.Windows.Forms.ToolStripDropDownButton()
    Me.FichaPreocupacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.FichaOcupacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.FichaDeReintegroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.FichaDeRetiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.btnabrirficha = New System.Windows.Forms.ToolStripButton()
    Me.btneliminarficha = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnimprimirficha = New System.Windows.Forms.ToolStripDropDownButton()
    Me.btnpag1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.btnpag2 = New System.Windows.Forms.ToolStripMenuItem()
    Me.btnpag3 = New System.Windows.Forms.ToolStripMenuItem()
    Me.DataGridViewTextBoxColumn378 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn377 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn376 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn375 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn374 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn373 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn372 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn371 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn370 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn366 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn367 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn368 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn369 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn362 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn363 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn364 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn365 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.tb.SuspendLayout()
    Me.TabDatos.SuspendLayout()
    Me.pnldatos.SuspendLayout()
    Me.pnlcierre.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.TabRubros.SuspendLayout()
    Me.pnlrubros.SuspendLayout()
    CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSFichas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip2.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
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
    Me.tb.Controls.Add(Me.TabRubros)
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
    'pnlcierre
    '
    Me.pnlcierre.Controls.Add(Me.lblfeccierre)
    Me.pnlcierre.Controls.Add(Me.dtfechasta)
    Me.pnlcierre.Controls.Add(Me.cbotipoliq)
    Me.pnlcierre.Controls.Add(Me.Label4)
    Me.pnlcierre.Controls.Add(Me.cbotiposalida)
    Me.pnlcierre.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcierre.Enabled = False
    Me.pnlcierre.Location = New System.Drawing.Point(288, 72)
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
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.CtlTipoContrato1)
    Me.Panel1.Controls.Add(Me.Label24)
    Me.Panel1.Controls.Add(Me.dtfecdesde)
    Me.Panel1.Controls.Add(Me.Cerrado)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Enabled = False
    Me.Panel1.Location = New System.Drawing.Point(288, 0)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(742, 72)
    Me.Panel1.TabIndex = 1
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
    Me.Label24.Location = New System.Drawing.Point(8, 40)
    Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(107, 17)
    Me.Label24.TabIndex = 7
    Me.Label24.Text = "Fecha contrato:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(144, 36)
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
    Me.Cerrado.Location = New System.Drawing.Point(280, 38)
    Me.Cerrado.Margin = New System.Windows.Forms.Padding(4)
    Me.Cerrado.Name = "Cerrado"
    Me.Cerrado.Size = New System.Drawing.Size(112, 22)
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
    Me.Panel3.Enabled = False
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
    'TabRubros
    '
    Me.TabRubros.Controls.Add(Me.pnlrubros)
    Me.TabRubros.Location = New System.Drawing.Point(4, 25)
    Me.TabRubros.Margin = New System.Windows.Forms.Padding(4)
    Me.TabRubros.Name = "TabRubros"
    Me.TabRubros.Padding = New System.Windows.Forms.Padding(4)
    Me.TabRubros.Size = New System.Drawing.Size(1038, 231)
    Me.TabRubros.TabIndex = 4
    Me.TabRubros.Text = "Fichas médicas"
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
    Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn380})
    Me.DataGridView3.DataSource = Me.BSFichas
    Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView3.Location = New System.Drawing.Point(0, 26)
    Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridView3.Name = "DataGridView3"
    Me.DataGridView3.RowHeadersVisible = False
    Me.DataGridView3.Size = New System.Drawing.Size(1030, 197)
    Me.DataGridView3.TabIndex = 1
    '
    'DataGridViewTextBoxColumn379
    '
    Me.DataGridViewTextBoxColumn379.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn379.Name = "DataGridViewTextBoxColumn379"
    '
    'DataGridViewTextBoxColumn380
    '
    Me.DataGridViewTextBoxColumn380.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn380.Name = "DataGridViewTextBoxColumn380"
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.btnnuevaficha, Me.btnabrirficha, Me.btneliminarficha, Me.ToolStripSeparator2, Me.btnimprimirficha})
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
    Me.ToolStripLabel2.Size = New System.Drawing.Size(108, 23)
    Me.ToolStripLabel2.Text = "Fichas médicas"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
    '
    'btnnuevaficha
    '
    Me.btnnuevaficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevaficha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichaPreocupacionalToolStripMenuItem, Me.FichaOcupacionalToolStripMenuItem, Me.FichaDeReintegroToolStripMenuItem, Me.FichaDeRetiroToolStripMenuItem})
    Me.btnnuevaficha.Image = My.Resources.Resources.nuevo
    Me.btnnuevaficha.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevaficha.Name = "btnnuevaficha"
    Me.btnnuevaficha.Size = New System.Drawing.Size(34, 23)
    Me.btnnuevaficha.Text = "Nuevo"
    '
    'FichaPreocupacionalToolStripMenuItem
    '
    Me.FichaPreocupacionalToolStripMenuItem.Name = "FichaPreocupacionalToolStripMenuItem"
    Me.FichaPreocupacionalToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
    Me.FichaPreocupacionalToolStripMenuItem.Text = "Ficha preocupacional"
    '
    'FichaOcupacionalToolStripMenuItem
    '
    Me.FichaOcupacionalToolStripMenuItem.Name = "FichaOcupacionalToolStripMenuItem"
    Me.FichaOcupacionalToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
    Me.FichaOcupacionalToolStripMenuItem.Text = "Ficha ocupacional"
    '
    'FichaDeReintegroToolStripMenuItem
    '
    Me.FichaDeReintegroToolStripMenuItem.Name = "FichaDeReintegroToolStripMenuItem"
    Me.FichaDeReintegroToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
    Me.FichaDeReintegroToolStripMenuItem.Text = "Ficha de reintegro"
    '
    'FichaDeRetiroToolStripMenuItem
    '
    Me.FichaDeRetiroToolStripMenuItem.Name = "FichaDeRetiroToolStripMenuItem"
    Me.FichaDeRetiroToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
    Me.FichaDeRetiroToolStripMenuItem.Text = "Ficha de retiro"
    '
    'btnabrirficha
    '
    Me.btnabrirficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnabrirficha.Image = My.Resources.Resources.abrir
    Me.btnabrirficha.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnabrirficha.Name = "btnabrirficha"
    Me.btnabrirficha.Size = New System.Drawing.Size(24, 23)
    Me.btnabrirficha.Text = "Abrir"
    '
    'btneliminarficha
    '
    Me.btneliminarficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminarficha.Image = My.Resources.Resources.eliminar
    Me.btneliminarficha.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminarficha.Name = "btneliminarficha"
    Me.btneliminarficha.Size = New System.Drawing.Size(24, 23)
    Me.btneliminarficha.Text = "Eliminar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
    '
    'btnimprimirficha
    '
    Me.btnimprimirficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprimirficha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnpag1, Me.btnpag2, Me.btnpag3})
    Me.btnimprimirficha.Image = My.Resources.Resources.print
    Me.btnimprimirficha.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimirficha.Name = "btnimprimirficha"
    Me.btnimprimirficha.Size = New System.Drawing.Size(34, 23)
    Me.btnimprimirficha.Text = "Imprimir"
    '
    'btnpag1
    '
    Me.btnpag1.Name = "btnpag1"
    Me.btnpag1.Size = New System.Drawing.Size(140, 26)
    Me.btnpag1.Text = "Página 1"
    '
    'btnpag2
    '
    Me.btnpag2.Name = "btnpag2"
    Me.btnpag2.Size = New System.Drawing.Size(140, 26)
    Me.btnpag2.Text = "Página 2"
    '
    'btnpag3
    '
    Me.btnpag3.Name = "btnpag3"
    Me.btnpag3.Size = New System.Drawing.Size(140, 26)
    Me.btnpag3.Text = "Página 3"
    '
    'DataGridViewTextBoxColumn378
    '
    Me.DataGridViewTextBoxColumn378.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn378.Name = "DataGridViewTextBoxColumn378"
    '
    'DataGridViewTextBoxColumn377
    '
    Me.DataGridViewTextBoxColumn377.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn377.Name = "DataGridViewTextBoxColumn377"
    '
    'DataGridViewTextBoxColumn376
    '
    Me.DataGridViewTextBoxColumn376.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn376.Name = "DataGridViewTextBoxColumn376"
    '
    'DataGridViewTextBoxColumn375
    '
    Me.DataGridViewTextBoxColumn375.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn375.Name = "DataGridViewTextBoxColumn375"
    '
    'DataGridViewTextBoxColumn374
    '
    Me.DataGridViewTextBoxColumn374.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn374.Name = "DataGridViewTextBoxColumn374"
    '
    'DataGridViewTextBoxColumn373
    '
    Me.DataGridViewTextBoxColumn373.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn373.Name = "DataGridViewTextBoxColumn373"
    '
    'DataGridViewTextBoxColumn372
    '
    Me.DataGridViewTextBoxColumn372.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn372.Name = "DataGridViewTextBoxColumn372"
    '
    'DataGridViewTextBoxColumn371
    '
    Me.DataGridViewTextBoxColumn371.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn371.Name = "DataGridViewTextBoxColumn371"
    '
    'DataGridViewTextBoxColumn370
    '
    Me.DataGridViewTextBoxColumn370.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn370.Name = "DataGridViewTextBoxColumn370"
    '
    'DataGridViewTextBoxColumn366
    '
    Me.DataGridViewTextBoxColumn366.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn366.Name = "DataGridViewTextBoxColumn366"
    '
    'DataGridViewTextBoxColumn367
    '
    Me.DataGridViewTextBoxColumn367.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn367.Name = "DataGridViewTextBoxColumn367"
    '
    'DataGridViewTextBoxColumn368
    '
    Me.DataGridViewTextBoxColumn368.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn368.Name = "DataGridViewTextBoxColumn368"
    '
    'DataGridViewTextBoxColumn369
    '
    Me.DataGridViewTextBoxColumn369.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn369.Name = "DataGridViewTextBoxColumn369"
    Me.DataGridViewTextBoxColumn369.ReadOnly = True
    '
    'DataGridViewTextBoxColumn362
    '
    Me.DataGridViewTextBoxColumn362.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn362.Name = "DataGridViewTextBoxColumn362"
    '
    'DataGridViewTextBoxColumn363
    '
    Me.DataGridViewTextBoxColumn363.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn363.Name = "DataGridViewTextBoxColumn363"
    '
    'DataGridViewTextBoxColumn364
    '
    Me.DataGridViewTextBoxColumn364.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn364.Name = "DataGridViewTextBoxColumn364"
    '
    'DataGridViewTextBoxColumn365
    '
    Me.DataGridViewTextBoxColumn365.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn365.Name = "DataGridViewTextBoxColumn365"
    Me.DataGridViewTextBoxColumn365.ReadOnly = True
    '
    'DataGridViewTextBoxColumn358
    '
    Me.DataGridViewTextBoxColumn358.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn358.Name = "DataGridViewTextBoxColumn358"
    '
    'DataGridViewTextBoxColumn359
    '
    Me.DataGridViewTextBoxColumn359.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn359.Name = "DataGridViewTextBoxColumn359"
    '
    'DataGridViewTextBoxColumn360
    '
    Me.DataGridViewTextBoxColumn360.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn360.Name = "DataGridViewTextBoxColumn360"
    '
    'DataGridViewTextBoxColumn361
    '
    Me.DataGridViewTextBoxColumn361.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn361.Name = "DataGridViewTextBoxColumn361"
    Me.DataGridViewTextBoxColumn361.ReadOnly = True
    '
    'DataGridViewTextBoxColumn354
    '
    Me.DataGridViewTextBoxColumn354.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn354.Name = "DataGridViewTextBoxColumn354"
    '
    'DataGridViewTextBoxColumn355
    '
    Me.DataGridViewTextBoxColumn355.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn355.Name = "DataGridViewTextBoxColumn355"
    '
    'DataGridViewTextBoxColumn356
    '
    Me.DataGridViewTextBoxColumn356.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn356.Name = "DataGridViewTextBoxColumn356"
    '
    'DataGridViewTextBoxColumn357
    '
    Me.DataGridViewTextBoxColumn357.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn357.Name = "DataGridViewTextBoxColumn357"
    Me.DataGridViewTextBoxColumn357.ReadOnly = True
    '
    'DataGridViewTextBoxColumn350
    '
    Me.DataGridViewTextBoxColumn350.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn350.Name = "DataGridViewTextBoxColumn350"
    '
    'DataGridViewTextBoxColumn351
    '
    Me.DataGridViewTextBoxColumn351.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn351.Name = "DataGridViewTextBoxColumn351"
    '
    'DataGridViewTextBoxColumn352
    '
    Me.DataGridViewTextBoxColumn352.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn352.Name = "DataGridViewTextBoxColumn352"
    '
    'DataGridViewTextBoxColumn353
    '
    Me.DataGridViewTextBoxColumn353.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn353.Name = "DataGridViewTextBoxColumn353"
    Me.DataGridViewTextBoxColumn353.ReadOnly = True
    '
    'DataGridViewTextBoxColumn346
    '
    Me.DataGridViewTextBoxColumn346.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn346.Name = "DataGridViewTextBoxColumn346"
    '
    'DataGridViewTextBoxColumn347
    '
    Me.DataGridViewTextBoxColumn347.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn347.Name = "DataGridViewTextBoxColumn347"
    '
    'DataGridViewTextBoxColumn348
    '
    Me.DataGridViewTextBoxColumn348.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn348.Name = "DataGridViewTextBoxColumn348"
    '
    'DataGridViewTextBoxColumn349
    '
    Me.DataGridViewTextBoxColumn349.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn349.Name = "DataGridViewTextBoxColumn349"
    Me.DataGridViewTextBoxColumn349.ReadOnly = True
    '
    'DataGridViewTextBoxColumn342
    '
    Me.DataGridViewTextBoxColumn342.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn342.Name = "DataGridViewTextBoxColumn342"
    '
    'DataGridViewTextBoxColumn343
    '
    Me.DataGridViewTextBoxColumn343.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn343.Name = "DataGridViewTextBoxColumn343"
    '
    'DataGridViewTextBoxColumn344
    '
    Me.DataGridViewTextBoxColumn344.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn344.Name = "DataGridViewTextBoxColumn344"
    '
    'DataGridViewTextBoxColumn345
    '
    Me.DataGridViewTextBoxColumn345.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn345.Name = "DataGridViewTextBoxColumn345"
    Me.DataGridViewTextBoxColumn345.ReadOnly = True
    '
    'DataGridViewTextBoxColumn338
    '
    Me.DataGridViewTextBoxColumn338.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn338.Name = "DataGridViewTextBoxColumn338"
    '
    'DataGridViewTextBoxColumn339
    '
    Me.DataGridViewTextBoxColumn339.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn339.Name = "DataGridViewTextBoxColumn339"
    '
    'DataGridViewTextBoxColumn340
    '
    Me.DataGridViewTextBoxColumn340.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn340.Name = "DataGridViewTextBoxColumn340"
    '
    'DataGridViewTextBoxColumn341
    '
    Me.DataGridViewTextBoxColumn341.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn341.Name = "DataGridViewTextBoxColumn341"
    Me.DataGridViewTextBoxColumn341.ReadOnly = True
    '
    'DataGridViewTextBoxColumn334
    '
    Me.DataGridViewTextBoxColumn334.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn334.Name = "DataGridViewTextBoxColumn334"
    '
    'DataGridViewTextBoxColumn335
    '
    Me.DataGridViewTextBoxColumn335.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn335.Name = "DataGridViewTextBoxColumn335"
    '
    'DataGridViewTextBoxColumn336
    '
    Me.DataGridViewTextBoxColumn336.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn336.Name = "DataGridViewTextBoxColumn336"
    '
    'DataGridViewTextBoxColumn337
    '
    Me.DataGridViewTextBoxColumn337.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn337.Name = "DataGridViewTextBoxColumn337"
    Me.DataGridViewTextBoxColumn337.ReadOnly = True
    '
    'DataGridViewTextBoxColumn330
    '
    Me.DataGridViewTextBoxColumn330.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn330.Name = "DataGridViewTextBoxColumn330"
    '
    'DataGridViewTextBoxColumn331
    '
    Me.DataGridViewTextBoxColumn331.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn331.Name = "DataGridViewTextBoxColumn331"
    '
    'DataGridViewTextBoxColumn332
    '
    Me.DataGridViewTextBoxColumn332.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn332.Name = "DataGridViewTextBoxColumn332"
    '
    'DataGridViewTextBoxColumn333
    '
    Me.DataGridViewTextBoxColumn333.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn333.Name = "DataGridViewTextBoxColumn333"
    Me.DataGridViewTextBoxColumn333.ReadOnly = True
    '
    'DataGridViewTextBoxColumn326
    '
    Me.DataGridViewTextBoxColumn326.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn326.Name = "DataGridViewTextBoxColumn326"
    '
    'DataGridViewTextBoxColumn327
    '
    Me.DataGridViewTextBoxColumn327.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn327.Name = "DataGridViewTextBoxColumn327"
    '
    'DataGridViewTextBoxColumn328
    '
    Me.DataGridViewTextBoxColumn328.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn328.Name = "DataGridViewTextBoxColumn328"
    '
    'DataGridViewTextBoxColumn329
    '
    Me.DataGridViewTextBoxColumn329.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn329.Name = "DataGridViewTextBoxColumn329"
    Me.DataGridViewTextBoxColumn329.ReadOnly = True
    '
    'DataGridViewTextBoxColumn322
    '
    Me.DataGridViewTextBoxColumn322.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn322.Name = "DataGridViewTextBoxColumn322"
    '
    'DataGridViewTextBoxColumn323
    '
    Me.DataGridViewTextBoxColumn323.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn323.Name = "DataGridViewTextBoxColumn323"
    '
    'DataGridViewTextBoxColumn324
    '
    Me.DataGridViewTextBoxColumn324.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn324.Name = "DataGridViewTextBoxColumn324"
    '
    'DataGridViewTextBoxColumn325
    '
    Me.DataGridViewTextBoxColumn325.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn325.Name = "DataGridViewTextBoxColumn325"
    Me.DataGridViewTextBoxColumn325.ReadOnly = True
    '
    'DataGridViewTextBoxColumn318
    '
    Me.DataGridViewTextBoxColumn318.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn318.Name = "DataGridViewTextBoxColumn318"
    '
    'DataGridViewTextBoxColumn319
    '
    Me.DataGridViewTextBoxColumn319.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn319.Name = "DataGridViewTextBoxColumn319"
    '
    'DataGridViewTextBoxColumn320
    '
    Me.DataGridViewTextBoxColumn320.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn320.Name = "DataGridViewTextBoxColumn320"
    '
    'DataGridViewTextBoxColumn321
    '
    Me.DataGridViewTextBoxColumn321.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn321.Name = "DataGridViewTextBoxColumn321"
    Me.DataGridViewTextBoxColumn321.ReadOnly = True
    '
    'DataGridViewTextBoxColumn314
    '
    Me.DataGridViewTextBoxColumn314.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn314.Name = "DataGridViewTextBoxColumn314"
    '
    'DataGridViewTextBoxColumn315
    '
    Me.DataGridViewTextBoxColumn315.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn315.Name = "DataGridViewTextBoxColumn315"
    '
    'DataGridViewTextBoxColumn316
    '
    Me.DataGridViewTextBoxColumn316.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn316.Name = "DataGridViewTextBoxColumn316"
    '
    'DataGridViewTextBoxColumn317
    '
    Me.DataGridViewTextBoxColumn317.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn317.Name = "DataGridViewTextBoxColumn317"
    Me.DataGridViewTextBoxColumn317.ReadOnly = True
    '
    'DataGridViewTextBoxColumn310
    '
    Me.DataGridViewTextBoxColumn310.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn310.Name = "DataGridViewTextBoxColumn310"
    '
    'DataGridViewTextBoxColumn311
    '
    Me.DataGridViewTextBoxColumn311.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn311.Name = "DataGridViewTextBoxColumn311"
    '
    'DataGridViewTextBoxColumn312
    '
    Me.DataGridViewTextBoxColumn312.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn312.Name = "DataGridViewTextBoxColumn312"
    '
    'DataGridViewTextBoxColumn313
    '
    Me.DataGridViewTextBoxColumn313.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn313.Name = "DataGridViewTextBoxColumn313"
    Me.DataGridViewTextBoxColumn313.ReadOnly = True
    '
    'DataGridViewTextBoxColumn306
    '
    Me.DataGridViewTextBoxColumn306.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn306.Name = "DataGridViewTextBoxColumn306"
    '
    'DataGridViewTextBoxColumn307
    '
    Me.DataGridViewTextBoxColumn307.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn307.Name = "DataGridViewTextBoxColumn307"
    '
    'DataGridViewTextBoxColumn308
    '
    Me.DataGridViewTextBoxColumn308.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn308.Name = "DataGridViewTextBoxColumn308"
    '
    'DataGridViewTextBoxColumn309
    '
    Me.DataGridViewTextBoxColumn309.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn309.Name = "DataGridViewTextBoxColumn309"
    Me.DataGridViewTextBoxColumn309.ReadOnly = True
    '
    'DataGridViewTextBoxColumn302
    '
    Me.DataGridViewTextBoxColumn302.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn302.Name = "DataGridViewTextBoxColumn302"
    '
    'DataGridViewTextBoxColumn303
    '
    Me.DataGridViewTextBoxColumn303.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn303.Name = "DataGridViewTextBoxColumn303"
    '
    'DataGridViewTextBoxColumn304
    '
    Me.DataGridViewTextBoxColumn304.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn304.Name = "DataGridViewTextBoxColumn304"
    '
    'DataGridViewTextBoxColumn305
    '
    Me.DataGridViewTextBoxColumn305.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn305.Name = "DataGridViewTextBoxColumn305"
    Me.DataGridViewTextBoxColumn305.ReadOnly = True
    '
    'DataGridViewTextBoxColumn298
    '
    Me.DataGridViewTextBoxColumn298.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn298.Name = "DataGridViewTextBoxColumn298"
    '
    'DataGridViewTextBoxColumn299
    '
    Me.DataGridViewTextBoxColumn299.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn299.Name = "DataGridViewTextBoxColumn299"
    '
    'DataGridViewTextBoxColumn300
    '
    Me.DataGridViewTextBoxColumn300.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn300.Name = "DataGridViewTextBoxColumn300"
    '
    'DataGridViewTextBoxColumn301
    '
    Me.DataGridViewTextBoxColumn301.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn301.Name = "DataGridViewTextBoxColumn301"
    Me.DataGridViewTextBoxColumn301.ReadOnly = True
    '
    'DataGridViewTextBoxColumn294
    '
    Me.DataGridViewTextBoxColumn294.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn294.Name = "DataGridViewTextBoxColumn294"
    '
    'DataGridViewTextBoxColumn295
    '
    Me.DataGridViewTextBoxColumn295.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn295.Name = "DataGridViewTextBoxColumn295"
    '
    'DataGridViewTextBoxColumn296
    '
    Me.DataGridViewTextBoxColumn296.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn296.Name = "DataGridViewTextBoxColumn296"
    '
    'DataGridViewTextBoxColumn297
    '
    Me.DataGridViewTextBoxColumn297.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn297.Name = "DataGridViewTextBoxColumn297"
    Me.DataGridViewTextBoxColumn297.ReadOnly = True
    '
    'DataGridViewTextBoxColumn290
    '
    Me.DataGridViewTextBoxColumn290.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn290.Name = "DataGridViewTextBoxColumn290"
    '
    'DataGridViewTextBoxColumn291
    '
    Me.DataGridViewTextBoxColumn291.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn291.Name = "DataGridViewTextBoxColumn291"
    '
    'DataGridViewTextBoxColumn292
    '
    Me.DataGridViewTextBoxColumn292.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn292.Name = "DataGridViewTextBoxColumn292"
    '
    'DataGridViewTextBoxColumn293
    '
    Me.DataGridViewTextBoxColumn293.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn293.Name = "DataGridViewTextBoxColumn293"
    Me.DataGridViewTextBoxColumn293.ReadOnly = True
    '
    'DataGridViewTextBoxColumn286
    '
    Me.DataGridViewTextBoxColumn286.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn286.Name = "DataGridViewTextBoxColumn286"
    '
    'DataGridViewTextBoxColumn287
    '
    Me.DataGridViewTextBoxColumn287.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn287.Name = "DataGridViewTextBoxColumn287"
    '
    'DataGridViewTextBoxColumn288
    '
    Me.DataGridViewTextBoxColumn288.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn288.Name = "DataGridViewTextBoxColumn288"
    '
    'DataGridViewTextBoxColumn289
    '
    Me.DataGridViewTextBoxColumn289.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn289.Name = "DataGridViewTextBoxColumn289"
    Me.DataGridViewTextBoxColumn289.ReadOnly = True
    '
    'DataGridViewTextBoxColumn282
    '
    Me.DataGridViewTextBoxColumn282.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn282.Name = "DataGridViewTextBoxColumn282"
    '
    'DataGridViewTextBoxColumn283
    '
    Me.DataGridViewTextBoxColumn283.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn283.Name = "DataGridViewTextBoxColumn283"
    '
    'DataGridViewTextBoxColumn284
    '
    Me.DataGridViewTextBoxColumn284.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn284.Name = "DataGridViewTextBoxColumn284"
    '
    'DataGridViewTextBoxColumn285
    '
    Me.DataGridViewTextBoxColumn285.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn285.Name = "DataGridViewTextBoxColumn285"
    Me.DataGridViewTextBoxColumn285.ReadOnly = True
    '
    'DataGridViewTextBoxColumn278
    '
    Me.DataGridViewTextBoxColumn278.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn278.Name = "DataGridViewTextBoxColumn278"
    '
    'DataGridViewTextBoxColumn279
    '
    Me.DataGridViewTextBoxColumn279.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn279.Name = "DataGridViewTextBoxColumn279"
    '
    'DataGridViewTextBoxColumn280
    '
    Me.DataGridViewTextBoxColumn280.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn280.Name = "DataGridViewTextBoxColumn280"
    '
    'DataGridViewTextBoxColumn281
    '
    Me.DataGridViewTextBoxColumn281.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn281.Name = "DataGridViewTextBoxColumn281"
    Me.DataGridViewTextBoxColumn281.ReadOnly = True
    '
    'DataGridViewTextBoxColumn274
    '
    Me.DataGridViewTextBoxColumn274.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn274.Name = "DataGridViewTextBoxColumn274"
    '
    'DataGridViewTextBoxColumn275
    '
    Me.DataGridViewTextBoxColumn275.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn275.Name = "DataGridViewTextBoxColumn275"
    '
    'DataGridViewTextBoxColumn276
    '
    Me.DataGridViewTextBoxColumn276.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn276.Name = "DataGridViewTextBoxColumn276"
    '
    'DataGridViewTextBoxColumn277
    '
    Me.DataGridViewTextBoxColumn277.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn277.Name = "DataGridViewTextBoxColumn277"
    Me.DataGridViewTextBoxColumn277.ReadOnly = True
    '
    'DataGridViewTextBoxColumn270
    '
    Me.DataGridViewTextBoxColumn270.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn270.Name = "DataGridViewTextBoxColumn270"
    '
    'DataGridViewTextBoxColumn271
    '
    Me.DataGridViewTextBoxColumn271.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn271.Name = "DataGridViewTextBoxColumn271"
    '
    'DataGridViewTextBoxColumn272
    '
    Me.DataGridViewTextBoxColumn272.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn272.Name = "DataGridViewTextBoxColumn272"
    '
    'DataGridViewTextBoxColumn273
    '
    Me.DataGridViewTextBoxColumn273.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn273.Name = "DataGridViewTextBoxColumn273"
    Me.DataGridViewTextBoxColumn273.ReadOnly = True
    '
    'DataGridViewTextBoxColumn266
    '
    Me.DataGridViewTextBoxColumn266.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn266.Name = "DataGridViewTextBoxColumn266"
    '
    'DataGridViewTextBoxColumn267
    '
    Me.DataGridViewTextBoxColumn267.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn267.Name = "DataGridViewTextBoxColumn267"
    '
    'DataGridViewTextBoxColumn268
    '
    Me.DataGridViewTextBoxColumn268.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn268.Name = "DataGridViewTextBoxColumn268"
    '
    'DataGridViewTextBoxColumn269
    '
    Me.DataGridViewTextBoxColumn269.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn269.Name = "DataGridViewTextBoxColumn269"
    Me.DataGridViewTextBoxColumn269.ReadOnly = True
    '
    'DataGridViewTextBoxColumn262
    '
    Me.DataGridViewTextBoxColumn262.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn262.Name = "DataGridViewTextBoxColumn262"
    '
    'DataGridViewTextBoxColumn263
    '
    Me.DataGridViewTextBoxColumn263.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn263.Name = "DataGridViewTextBoxColumn263"
    '
    'DataGridViewTextBoxColumn264
    '
    Me.DataGridViewTextBoxColumn264.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn264.Name = "DataGridViewTextBoxColumn264"
    '
    'DataGridViewTextBoxColumn265
    '
    Me.DataGridViewTextBoxColumn265.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn265.Name = "DataGridViewTextBoxColumn265"
    Me.DataGridViewTextBoxColumn265.ReadOnly = True
    '
    'DataGridViewTextBoxColumn257
    '
    Me.DataGridViewTextBoxColumn257.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn257.Name = "DataGridViewTextBoxColumn257"
    '
    'DataGridViewTextBoxColumn258
    '
    Me.DataGridViewTextBoxColumn258.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn258.Name = "DataGridViewTextBoxColumn258"
    '
    'DataGridViewTextBoxColumn259
    '
    Me.DataGridViewTextBoxColumn259.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn259.Name = "DataGridViewTextBoxColumn259"
    '
    'DataGridViewTextBoxColumn254
    '
    Me.DataGridViewTextBoxColumn254.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn254.Name = "DataGridViewTextBoxColumn254"
    '
    'DataGridViewTextBoxColumn255
    '
    Me.DataGridViewTextBoxColumn255.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn255.Name = "DataGridViewTextBoxColumn255"
    '
    'DataGridViewTextBoxColumn256
    '
    Me.DataGridViewTextBoxColumn256.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn256.Name = "DataGridViewTextBoxColumn256"
    '
    'DataGridViewTextBoxColumn250
    '
    Me.DataGridViewTextBoxColumn250.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn250.Name = "DataGridViewTextBoxColumn250"
    '
    'DataGridViewTextBoxColumn252
    '
    Me.DataGridViewTextBoxColumn252.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn252.Name = "DataGridViewTextBoxColumn252"
    '
    'DataGridViewTextBoxColumn253
    '
    Me.DataGridViewTextBoxColumn253.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn253.Name = "DataGridViewTextBoxColumn253"
    '
    'DataGridViewTextBoxColumn248
    '
    Me.DataGridViewTextBoxColumn248.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn248.Name = "DataGridViewTextBoxColumn248"
    '
    'DataGridViewTextBoxColumn249
    '
    Me.DataGridViewTextBoxColumn249.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn249.Name = "DataGridViewTextBoxColumn249"
    '
    'DataGridViewTextBoxColumn251
    '
    Me.DataGridViewTextBoxColumn251.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn251.Name = "DataGridViewTextBoxColumn251"
    '
    'DataGridViewTextBoxColumn244
    '
    Me.DataGridViewTextBoxColumn244.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn244.Name = "DataGridViewTextBoxColumn244"
    '
    'DataGridViewTextBoxColumn245
    '
    Me.DataGridViewTextBoxColumn245.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn245.Name = "DataGridViewTextBoxColumn245"
    '
    'DataGridViewTextBoxColumn246
    '
    Me.DataGridViewTextBoxColumn246.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn246.Name = "DataGridViewTextBoxColumn246"
    '
    'DataGridViewTextBoxColumn247
    '
    Me.DataGridViewTextBoxColumn247.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn247.Name = "DataGridViewTextBoxColumn247"
    '
    'DataGridViewTextBoxColumn240
    '
    Me.DataGridViewTextBoxColumn240.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn240.Name = "DataGridViewTextBoxColumn240"
    '
    'DataGridViewTextBoxColumn241
    '
    Me.DataGridViewTextBoxColumn241.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn241.Name = "DataGridViewTextBoxColumn241"
    '
    'DataGridViewTextBoxColumn242
    '
    Me.DataGridViewTextBoxColumn242.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn242.Name = "DataGridViewTextBoxColumn242"
    '
    'DataGridViewTextBoxColumn243
    '
    Me.DataGridViewTextBoxColumn243.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn243.Name = "DataGridViewTextBoxColumn243"
    '
    'DataGridViewTextBoxColumn236
    '
    Me.DataGridViewTextBoxColumn236.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn236.Name = "DataGridViewTextBoxColumn236"
    '
    'DataGridViewTextBoxColumn237
    '
    Me.DataGridViewTextBoxColumn237.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn237.Name = "DataGridViewTextBoxColumn237"
    '
    'DataGridViewTextBoxColumn238
    '
    Me.DataGridViewTextBoxColumn238.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn238.Name = "DataGridViewTextBoxColumn238"
    '
    'DataGridViewTextBoxColumn239
    '
    Me.DataGridViewTextBoxColumn239.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn239.Name = "DataGridViewTextBoxColumn239"
    '
    'DataGridViewTextBoxColumn232
    '
    Me.DataGridViewTextBoxColumn232.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn232.Name = "DataGridViewTextBoxColumn232"
    '
    'DataGridViewTextBoxColumn233
    '
    Me.DataGridViewTextBoxColumn233.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn233.Name = "DataGridViewTextBoxColumn233"
    '
    'DataGridViewTextBoxColumn234
    '
    Me.DataGridViewTextBoxColumn234.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn234.Name = "DataGridViewTextBoxColumn234"
    '
    'DataGridViewTextBoxColumn235
    '
    Me.DataGridViewTextBoxColumn235.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn235.Name = "DataGridViewTextBoxColumn235"
    '
    'DataGridViewTextBoxColumn228
    '
    Me.DataGridViewTextBoxColumn228.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn228.Name = "DataGridViewTextBoxColumn228"
    '
    'DataGridViewTextBoxColumn229
    '
    Me.DataGridViewTextBoxColumn229.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn229.Name = "DataGridViewTextBoxColumn229"
    '
    'DataGridViewTextBoxColumn230
    '
    Me.DataGridViewTextBoxColumn230.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn230.Name = "DataGridViewTextBoxColumn230"
    '
    'DataGridViewTextBoxColumn231
    '
    Me.DataGridViewTextBoxColumn231.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn231.Name = "DataGridViewTextBoxColumn231"
    '
    'DataGridViewTextBoxColumn224
    '
    Me.DataGridViewTextBoxColumn224.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn224.Name = "DataGridViewTextBoxColumn224"
    '
    'DataGridViewTextBoxColumn225
    '
    Me.DataGridViewTextBoxColumn225.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn225.Name = "DataGridViewTextBoxColumn225"
    '
    'DataGridViewTextBoxColumn226
    '
    Me.DataGridViewTextBoxColumn226.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn226.Name = "DataGridViewTextBoxColumn226"
    '
    'DataGridViewTextBoxColumn227
    '
    Me.DataGridViewTextBoxColumn227.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn227.Name = "DataGridViewTextBoxColumn227"
    '
    'DataGridViewTextBoxColumn220
    '
    Me.DataGridViewTextBoxColumn220.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn220.Name = "DataGridViewTextBoxColumn220"
    '
    'DataGridViewTextBoxColumn221
    '
    Me.DataGridViewTextBoxColumn221.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn221.Name = "DataGridViewTextBoxColumn221"
    '
    'DataGridViewTextBoxColumn222
    '
    Me.DataGridViewTextBoxColumn222.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn222.Name = "DataGridViewTextBoxColumn222"
    '
    'DataGridViewTextBoxColumn223
    '
    Me.DataGridViewTextBoxColumn223.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn223.Name = "DataGridViewTextBoxColumn223"
    '
    'DataGridViewTextBoxColumn216
    '
    Me.DataGridViewTextBoxColumn216.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn216.Name = "DataGridViewTextBoxColumn216"
    '
    'DataGridViewTextBoxColumn217
    '
    Me.DataGridViewTextBoxColumn217.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn217.Name = "DataGridViewTextBoxColumn217"
    '
    'DataGridViewTextBoxColumn218
    '
    Me.DataGridViewTextBoxColumn218.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn218.Name = "DataGridViewTextBoxColumn218"
    '
    'DataGridViewTextBoxColumn219
    '
    Me.DataGridViewTextBoxColumn219.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn219.Name = "DataGridViewTextBoxColumn219"
    '
    'DataGridViewTextBoxColumn212
    '
    Me.DataGridViewTextBoxColumn212.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn212.Name = "DataGridViewTextBoxColumn212"
    '
    'DataGridViewTextBoxColumn213
    '
    Me.DataGridViewTextBoxColumn213.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn213.Name = "DataGridViewTextBoxColumn213"
    '
    'DataGridViewTextBoxColumn214
    '
    Me.DataGridViewTextBoxColumn214.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn214.Name = "DataGridViewTextBoxColumn214"
    '
    'DataGridViewTextBoxColumn215
    '
    Me.DataGridViewTextBoxColumn215.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn215.Name = "DataGridViewTextBoxColumn215"
    '
    'DataGridViewTextBoxColumn208
    '
    Me.DataGridViewTextBoxColumn208.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn208.Name = "DataGridViewTextBoxColumn208"
    '
    'DataGridViewTextBoxColumn209
    '
    Me.DataGridViewTextBoxColumn209.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn209.Name = "DataGridViewTextBoxColumn209"
    '
    'DataGridViewTextBoxColumn210
    '
    Me.DataGridViewTextBoxColumn210.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn210.Name = "DataGridViewTextBoxColumn210"
    '
    'DataGridViewTextBoxColumn211
    '
    Me.DataGridViewTextBoxColumn211.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn211.Name = "DataGridViewTextBoxColumn211"
    '
    'DataGridViewTextBoxColumn204
    '
    Me.DataGridViewTextBoxColumn204.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn204.Name = "DataGridViewTextBoxColumn204"
    '
    'DataGridViewTextBoxColumn205
    '
    Me.DataGridViewTextBoxColumn205.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn205.Name = "DataGridViewTextBoxColumn205"
    '
    'DataGridViewTextBoxColumn206
    '
    Me.DataGridViewTextBoxColumn206.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn206.Name = "DataGridViewTextBoxColumn206"
    '
    'DataGridViewTextBoxColumn207
    '
    Me.DataGridViewTextBoxColumn207.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn207.Name = "DataGridViewTextBoxColumn207"
    '
    'DataGridViewTextBoxColumn200
    '
    Me.DataGridViewTextBoxColumn200.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn200.Name = "DataGridViewTextBoxColumn200"
    '
    'DataGridViewTextBoxColumn201
    '
    Me.DataGridViewTextBoxColumn201.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn201.Name = "DataGridViewTextBoxColumn201"
    '
    'DataGridViewTextBoxColumn202
    '
    Me.DataGridViewTextBoxColumn202.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn202.Name = "DataGridViewTextBoxColumn202"
    '
    'DataGridViewTextBoxColumn203
    '
    Me.DataGridViewTextBoxColumn203.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn203.Name = "DataGridViewTextBoxColumn203"
    '
    'DataGridViewTextBoxColumn196
    '
    Me.DataGridViewTextBoxColumn196.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn196.Name = "DataGridViewTextBoxColumn196"
    '
    'DataGridViewTextBoxColumn197
    '
    Me.DataGridViewTextBoxColumn197.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn197.Name = "DataGridViewTextBoxColumn197"
    '
    'DataGridViewTextBoxColumn198
    '
    Me.DataGridViewTextBoxColumn198.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn198.Name = "DataGridViewTextBoxColumn198"
    '
    'DataGridViewTextBoxColumn199
    '
    Me.DataGridViewTextBoxColumn199.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn199.Name = "DataGridViewTextBoxColumn199"
    '
    'DataGridViewTextBoxColumn184
    '
    Me.DataGridViewTextBoxColumn184.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn184.Name = "DataGridViewTextBoxColumn184"
    '
    'DataGridViewTextBoxColumn188
    '
    Me.DataGridViewTextBoxColumn188.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn188.Name = "DataGridViewTextBoxColumn188"
    '
    'DataGridViewTextBoxColumn185
    '
    Me.DataGridViewTextBoxColumn185.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn185.Name = "DataGridViewTextBoxColumn185"
    '
    'DataGridViewTextBoxColumn189
    '
    Me.DataGridViewTextBoxColumn189.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn189.Name = "DataGridViewTextBoxColumn189"
    '
    'DataGridViewTextBoxColumn186
    '
    Me.DataGridViewTextBoxColumn186.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn186.Name = "DataGridViewTextBoxColumn186"
    '
    'DataGridViewTextBoxColumn190
    '
    Me.DataGridViewTextBoxColumn190.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn190.Name = "DataGridViewTextBoxColumn190"
    '
    'DataGridViewTextBoxColumn187
    '
    Me.DataGridViewTextBoxColumn187.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn187.Name = "DataGridViewTextBoxColumn187"
    '
    'DataGridViewTextBoxColumn191
    '
    Me.DataGridViewTextBoxColumn191.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn191.Name = "DataGridViewTextBoxColumn191"
    '
    'DataGridViewTextBoxColumn180
    '
    Me.DataGridViewTextBoxColumn180.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn180.Name = "DataGridViewTextBoxColumn180"
    '
    'DataGridViewTextBoxColumn181
    '
    Me.DataGridViewTextBoxColumn181.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn181.Name = "DataGridViewTextBoxColumn181"
    '
    'DataGridViewTextBoxColumn182
    '
    Me.DataGridViewTextBoxColumn182.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn182.Name = "DataGridViewTextBoxColumn182"
    '
    'DataGridViewTextBoxColumn183
    '
    Me.DataGridViewTextBoxColumn183.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn183.Name = "DataGridViewTextBoxColumn183"
    '
    'DataGridViewTextBoxColumn176
    '
    Me.DataGridViewTextBoxColumn176.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn176.Name = "DataGridViewTextBoxColumn176"
    '
    'DataGridViewTextBoxColumn177
    '
    Me.DataGridViewTextBoxColumn177.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn177.Name = "DataGridViewTextBoxColumn177"
    '
    'DataGridViewTextBoxColumn178
    '
    Me.DataGridViewTextBoxColumn178.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn178.Name = "DataGridViewTextBoxColumn178"
    '
    'DataGridViewTextBoxColumn179
    '
    Me.DataGridViewTextBoxColumn179.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn179.Name = "DataGridViewTextBoxColumn179"
    '
    'DataGridViewTextBoxColumn172
    '
    Me.DataGridViewTextBoxColumn172.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn172.Name = "DataGridViewTextBoxColumn172"
    '
    'DataGridViewTextBoxColumn173
    '
    Me.DataGridViewTextBoxColumn173.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn173.Name = "DataGridViewTextBoxColumn173"
    '
    'DataGridViewTextBoxColumn174
    '
    Me.DataGridViewTextBoxColumn174.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn174.Name = "DataGridViewTextBoxColumn174"
    '
    'DataGridViewTextBoxColumn175
    '
    Me.DataGridViewTextBoxColumn175.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn175.Name = "DataGridViewTextBoxColumn175"
    '
    'DataGridViewTextBoxColumn168
    '
    Me.DataGridViewTextBoxColumn168.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn168.Name = "DataGridViewTextBoxColumn168"
    '
    'DataGridViewTextBoxColumn169
    '
    Me.DataGridViewTextBoxColumn169.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn169.Name = "DataGridViewTextBoxColumn169"
    '
    'DataGridViewTextBoxColumn170
    '
    Me.DataGridViewTextBoxColumn170.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn170.Name = "DataGridViewTextBoxColumn170"
    '
    'DataGridViewTextBoxColumn171
    '
    Me.DataGridViewTextBoxColumn171.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn171.Name = "DataGridViewTextBoxColumn171"
    '
    'DataGridViewTextBoxColumn164
    '
    Me.DataGridViewTextBoxColumn164.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn164.Name = "DataGridViewTextBoxColumn164"
    '
    'DataGridViewTextBoxColumn165
    '
    Me.DataGridViewTextBoxColumn165.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn165.Name = "DataGridViewTextBoxColumn165"
    '
    'DataGridViewTextBoxColumn166
    '
    Me.DataGridViewTextBoxColumn166.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn166.Name = "DataGridViewTextBoxColumn166"
    '
    'DataGridViewTextBoxColumn167
    '
    Me.DataGridViewTextBoxColumn167.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn167.Name = "DataGridViewTextBoxColumn167"
    '
    'DataGridViewTextBoxColumn160
    '
    Me.DataGridViewTextBoxColumn160.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn160.Name = "DataGridViewTextBoxColumn160"
    '
    'DataGridViewTextBoxColumn161
    '
    Me.DataGridViewTextBoxColumn161.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn161.Name = "DataGridViewTextBoxColumn161"
    '
    'DataGridViewTextBoxColumn162
    '
    Me.DataGridViewTextBoxColumn162.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn162.Name = "DataGridViewTextBoxColumn162"
    '
    'DataGridViewTextBoxColumn163
    '
    Me.DataGridViewTextBoxColumn163.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn163.Name = "DataGridViewTextBoxColumn163"
    '
    'DataGridViewTextBoxColumn156
    '
    Me.DataGridViewTextBoxColumn156.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn156.Name = "DataGridViewTextBoxColumn156"
    '
    'DataGridViewTextBoxColumn157
    '
    Me.DataGridViewTextBoxColumn157.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn157.Name = "DataGridViewTextBoxColumn157"
    '
    'DataGridViewTextBoxColumn158
    '
    Me.DataGridViewTextBoxColumn158.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn158.Name = "DataGridViewTextBoxColumn158"
    '
    'DataGridViewTextBoxColumn159
    '
    Me.DataGridViewTextBoxColumn159.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn159.Name = "DataGridViewTextBoxColumn159"
    '
    'DataGridViewTextBoxColumn152
    '
    Me.DataGridViewTextBoxColumn152.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn152.Name = "DataGridViewTextBoxColumn152"
    '
    'DataGridViewTextBoxColumn153
    '
    Me.DataGridViewTextBoxColumn153.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn153.Name = "DataGridViewTextBoxColumn153"
    '
    'DataGridViewTextBoxColumn154
    '
    Me.DataGridViewTextBoxColumn154.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn154.Name = "DataGridViewTextBoxColumn154"
    '
    'DataGridViewTextBoxColumn155
    '
    Me.DataGridViewTextBoxColumn155.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn155.Name = "DataGridViewTextBoxColumn155"
    '
    'DataGridViewTextBoxColumn148
    '
    Me.DataGridViewTextBoxColumn148.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn148.Name = "DataGridViewTextBoxColumn148"
    '
    'DataGridViewTextBoxColumn149
    '
    Me.DataGridViewTextBoxColumn149.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn149.Name = "DataGridViewTextBoxColumn149"
    '
    'DataGridViewTextBoxColumn150
    '
    Me.DataGridViewTextBoxColumn150.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn150.Name = "DataGridViewTextBoxColumn150"
    '
    'DataGridViewTextBoxColumn151
    '
    Me.DataGridViewTextBoxColumn151.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn151.Name = "DataGridViewTextBoxColumn151"
    '
    'DataGridViewTextBoxColumn144
    '
    Me.DataGridViewTextBoxColumn144.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn144.Name = "DataGridViewTextBoxColumn144"
    '
    'DataGridViewTextBoxColumn145
    '
    Me.DataGridViewTextBoxColumn145.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn145.Name = "DataGridViewTextBoxColumn145"
    '
    'DataGridViewTextBoxColumn146
    '
    Me.DataGridViewTextBoxColumn146.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn146.Name = "DataGridViewTextBoxColumn146"
    '
    'DataGridViewTextBoxColumn147
    '
    Me.DataGridViewTextBoxColumn147.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn147.Name = "DataGridViewTextBoxColumn147"
    '
    'DataGridViewTextBoxColumn140
    '
    Me.DataGridViewTextBoxColumn140.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn140.Name = "DataGridViewTextBoxColumn140"
    '
    'DataGridViewTextBoxColumn141
    '
    Me.DataGridViewTextBoxColumn141.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn141.Name = "DataGridViewTextBoxColumn141"
    '
    'DataGridViewTextBoxColumn142
    '
    Me.DataGridViewTextBoxColumn142.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn142.Name = "DataGridViewTextBoxColumn142"
    '
    'DataGridViewTextBoxColumn143
    '
    Me.DataGridViewTextBoxColumn143.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn143.Name = "DataGridViewTextBoxColumn143"
    '
    'DataGridViewTextBoxColumn136
    '
    Me.DataGridViewTextBoxColumn136.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn136.Name = "DataGridViewTextBoxColumn136"
    '
    'DataGridViewTextBoxColumn137
    '
    Me.DataGridViewTextBoxColumn137.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn137.Name = "DataGridViewTextBoxColumn137"
    '
    'DataGridViewTextBoxColumn138
    '
    Me.DataGridViewTextBoxColumn138.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn138.Name = "DataGridViewTextBoxColumn138"
    '
    'DataGridViewTextBoxColumn139
    '
    Me.DataGridViewTextBoxColumn139.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn139.Name = "DataGridViewTextBoxColumn139"
    '
    'DataGridViewTextBoxColumn132
    '
    Me.DataGridViewTextBoxColumn132.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn132.Name = "DataGridViewTextBoxColumn132"
    '
    'DataGridViewTextBoxColumn133
    '
    Me.DataGridViewTextBoxColumn133.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn133.Name = "DataGridViewTextBoxColumn133"
    '
    'DataGridViewTextBoxColumn135
    '
    Me.DataGridViewTextBoxColumn135.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn135.Name = "DataGridViewTextBoxColumn135"
    '
    'DataGridViewTextBoxColumn134
    '
    Me.DataGridViewTextBoxColumn134.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn134.Name = "DataGridViewTextBoxColumn134"
    '
    'DataGridViewTextBoxColumn128
    '
    Me.DataGridViewTextBoxColumn128.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn128.Name = "DataGridViewTextBoxColumn128"
    '
    'DataGridViewTextBoxColumn129
    '
    Me.DataGridViewTextBoxColumn129.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn129.Name = "DataGridViewTextBoxColumn129"
    '
    'DataGridViewTextBoxColumn130
    '
    Me.DataGridViewTextBoxColumn130.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn130.Name = "DataGridViewTextBoxColumn130"
    '
    'DataGridViewTextBoxColumn131
    '
    Me.DataGridViewTextBoxColumn131.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn131.Name = "DataGridViewTextBoxColumn131"
    '
    'DataGridViewTextBoxColumn124
    '
    Me.DataGridViewTextBoxColumn124.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn124.Name = "DataGridViewTextBoxColumn124"
    '
    'DataGridViewTextBoxColumn125
    '
    Me.DataGridViewTextBoxColumn125.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn125.Name = "DataGridViewTextBoxColumn125"
    '
    'DataGridViewTextBoxColumn126
    '
    Me.DataGridViewTextBoxColumn126.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn126.Name = "DataGridViewTextBoxColumn126"
    '
    'DataGridViewTextBoxColumn127
    '
    Me.DataGridViewTextBoxColumn127.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn127.Name = "DataGridViewTextBoxColumn127"
    '
    'DataGridViewTextBoxColumn120
    '
    Me.DataGridViewTextBoxColumn120.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn120.Name = "DataGridViewTextBoxColumn120"
    '
    'DataGridViewTextBoxColumn121
    '
    Me.DataGridViewTextBoxColumn121.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn121.Name = "DataGridViewTextBoxColumn121"
    '
    'DataGridViewTextBoxColumn122
    '
    Me.DataGridViewTextBoxColumn122.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn122.Name = "DataGridViewTextBoxColumn122"
    '
    'DataGridViewTextBoxColumn123
    '
    Me.DataGridViewTextBoxColumn123.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn123.Name = "DataGridViewTextBoxColumn123"
    '
    'DataGridViewTextBoxColumn117
    '
    Me.DataGridViewTextBoxColumn117.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn117.Name = "DataGridViewTextBoxColumn117"
    '
    'DataGridViewTextBoxColumn118
    '
    Me.DataGridViewTextBoxColumn118.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn118.Name = "DataGridViewTextBoxColumn118"
    '
    'DataGridViewTextBoxColumn119
    '
    Me.DataGridViewTextBoxColumn119.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn119.Name = "DataGridViewTextBoxColumn119"
    '
    'DataGridViewTextBoxColumn114
    '
    Me.DataGridViewTextBoxColumn114.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn114.Name = "DataGridViewTextBoxColumn114"
    '
    'DataGridViewTextBoxColumn115
    '
    Me.DataGridViewTextBoxColumn115.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn115.Name = "DataGridViewTextBoxColumn115"
    '
    'DataGridViewTextBoxColumn116
    '
    Me.DataGridViewTextBoxColumn116.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn116.Name = "DataGridViewTextBoxColumn116"
    '
    'DataGridViewTextBoxColumn111
    '
    Me.DataGridViewTextBoxColumn111.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn111.Name = "DataGridViewTextBoxColumn111"
    '
    'DataGridViewTextBoxColumn112
    '
    Me.DataGridViewTextBoxColumn112.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn112.Name = "DataGridViewTextBoxColumn112"
    '
    'DataGridViewTextBoxColumn113
    '
    Me.DataGridViewTextBoxColumn113.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn113.Name = "DataGridViewTextBoxColumn113"
    '
    'DataGridViewTextBoxColumn108
    '
    Me.DataGridViewTextBoxColumn108.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn108.Name = "DataGridViewTextBoxColumn108"
    '
    'DataGridViewTextBoxColumn109
    '
    Me.DataGridViewTextBoxColumn109.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn109.Name = "DataGridViewTextBoxColumn109"
    '
    'DataGridViewTextBoxColumn110
    '
    Me.DataGridViewTextBoxColumn110.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
    '
    'DataGridViewTextBoxColumn105
    '
    Me.DataGridViewTextBoxColumn105.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
    '
    'DataGridViewTextBoxColumn106
    '
    Me.DataGridViewTextBoxColumn106.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn106.Name = "DataGridViewTextBoxColumn106"
    '
    'DataGridViewTextBoxColumn107
    '
    Me.DataGridViewTextBoxColumn107.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn107.Name = "DataGridViewTextBoxColumn107"
    '
    'DataGridViewTextBoxColumn102
    '
    Me.DataGridViewTextBoxColumn102.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
    '
    'DataGridViewTextBoxColumn103
    '
    Me.DataGridViewTextBoxColumn103.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
    '
    'DataGridViewTextBoxColumn104
    '
    Me.DataGridViewTextBoxColumn104.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
    '
    'DataGridViewTextBoxColumn99
    '
    Me.DataGridViewTextBoxColumn99.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn99.Name = "DataGridViewTextBoxColumn99"
    '
    'DataGridViewTextBoxColumn100
    '
    Me.DataGridViewTextBoxColumn100.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn100.Name = "DataGridViewTextBoxColumn100"
    '
    'DataGridViewTextBoxColumn101
    '
    Me.DataGridViewTextBoxColumn101.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn101.Name = "DataGridViewTextBoxColumn101"
    '
    'DataGridViewTextBoxColumn96
    '
    Me.DataGridViewTextBoxColumn96.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn96.Name = "DataGridViewTextBoxColumn96"
    '
    'DataGridViewTextBoxColumn97
    '
    Me.DataGridViewTextBoxColumn97.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn97.Name = "DataGridViewTextBoxColumn97"
    '
    'DataGridViewTextBoxColumn98
    '
    Me.DataGridViewTextBoxColumn98.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn98.Name = "DataGridViewTextBoxColumn98"
    '
    'DataGridViewTextBoxColumn93
    '
    Me.DataGridViewTextBoxColumn93.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
    '
    'DataGridViewTextBoxColumn94
    '
    Me.DataGridViewTextBoxColumn94.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
    '
    'DataGridViewTextBoxColumn95
    '
    Me.DataGridViewTextBoxColumn95.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn95.Name = "DataGridViewTextBoxColumn95"
    '
    'DataGridViewTextBoxColumn90
    '
    Me.DataGridViewTextBoxColumn90.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
    '
    'DataGridViewTextBoxColumn91
    '
    Me.DataGridViewTextBoxColumn91.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
    '
    'DataGridViewTextBoxColumn92
    '
    Me.DataGridViewTextBoxColumn92.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
    '
    'DataGridViewTextBoxColumn87
    '
    Me.DataGridViewTextBoxColumn87.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
    '
    'DataGridViewTextBoxColumn88
    '
    Me.DataGridViewTextBoxColumn88.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
    '
    'DataGridViewTextBoxColumn89
    '
    Me.DataGridViewTextBoxColumn89.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
    '
    'DataGridViewTextBoxColumn80
    '
    Me.DataGridViewTextBoxColumn80.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
    '
    'DataGridViewTextBoxColumn82
    '
    Me.DataGridViewTextBoxColumn82.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
    '
    'DataGridViewTextBoxColumn81
    '
    Me.DataGridViewTextBoxColumn81.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
    '
    'DataGridViewTextBoxColumn83
    '
    Me.DataGridViewTextBoxColumn83.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
    '
    'DataGridViewTextBoxColumn78
    '
    Me.DataGridViewTextBoxColumn78.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
    '
    'DataGridViewTextBoxColumn79
    '
    Me.DataGridViewTextBoxColumn79.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
    '
    'DataGridViewTextBoxColumn76
    '
    Me.DataGridViewTextBoxColumn76.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
    '
    'DataGridViewTextBoxColumn77
    '
    Me.DataGridViewTextBoxColumn77.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
    '
    'DataGridViewTextBoxColumn74
    '
    Me.DataGridViewTextBoxColumn74.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
    '
    'DataGridViewTextBoxColumn75
    '
    Me.DataGridViewTextBoxColumn75.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
    '
    'DataGridViewTextBoxColumn72
    '
    Me.DataGridViewTextBoxColumn72.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
    '
    'DataGridViewTextBoxColumn73
    '
    Me.DataGridViewTextBoxColumn73.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
    '
    'DataGridViewTextBoxColumn70
    '
    Me.DataGridViewTextBoxColumn70.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
    '
    'DataGridViewTextBoxColumn71
    '
    Me.DataGridViewTextBoxColumn71.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
    '
    'DataGridViewTextBoxColumn69
    '
    Me.DataGridViewTextBoxColumn69.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
    '
    'DataGridViewTextBoxColumn68
    '
    Me.DataGridViewTextBoxColumn68.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
    '
    'DataGridViewTextBoxColumn66
    '
    Me.DataGridViewTextBoxColumn66.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
    '
    'DataGridViewTextBoxColumn67
    '
    Me.DataGridViewTextBoxColumn67.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
    '
    'DataGridViewTextBoxColumn64
    '
    Me.DataGridViewTextBoxColumn64.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
    '
    'DataGridViewTextBoxColumn65
    '
    Me.DataGridViewTextBoxColumn65.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
    '
    'DataGridViewTextBoxColumn62
    '
    Me.DataGridViewTextBoxColumn62.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
    '
    'DataGridViewTextBoxColumn63
    '
    Me.DataGridViewTextBoxColumn63.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
    '
    'DataGridViewTextBoxColumn60
    '
    Me.DataGridViewTextBoxColumn60.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
    '
    'DataGridViewTextBoxColumn61
    '
    Me.DataGridViewTextBoxColumn61.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
    '
    'DataGridViewTextBoxColumn58
    '
    Me.DataGridViewTextBoxColumn58.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
    '
    'DataGridViewTextBoxColumn59
    '
    Me.DataGridViewTextBoxColumn59.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
    '
    'DataGridViewTextBoxColumn56
    '
    Me.DataGridViewTextBoxColumn56.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
    '
    'DataGridViewTextBoxColumn57
    '
    Me.DataGridViewTextBoxColumn57.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
    '
    'DataGridViewTextBoxColumn54
    '
    Me.DataGridViewTextBoxColumn54.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
    '
    'DataGridViewTextBoxColumn55
    '
    Me.DataGridViewTextBoxColumn55.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
    '
    'DataGridViewTextBoxColumn52
    '
    Me.DataGridViewTextBoxColumn52.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
    '
    'DataGridViewTextBoxColumn53
    '
    Me.DataGridViewTextBoxColumn53.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
    '
    'DataGridViewTextBoxColumn50
    '
    Me.DataGridViewTextBoxColumn50.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
    '
    'DataGridViewTextBoxColumn51
    '
    Me.DataGridViewTextBoxColumn51.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
    '
    'DataGridViewTextBoxColumn48
    '
    Me.DataGridViewTextBoxColumn48.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
    '
    'DataGridViewTextBoxColumn49
    '
    Me.DataGridViewTextBoxColumn49.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
    '
    'DataGridViewTextBoxColumn42
    '
    Me.DataGridViewTextBoxColumn42.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
    '
    'DataGridViewTextBoxColumn44
    '
    Me.DataGridViewTextBoxColumn44.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
    '
    'DataGridViewTextBoxColumn43
    '
    Me.DataGridViewTextBoxColumn43.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
    '
    'DataGridViewTextBoxColumn45
    '
    Me.DataGridViewTextBoxColumn45.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
    '
    'DataGridViewTextBoxColumn40
    '
    Me.DataGridViewTextBoxColumn40.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
    '
    'DataGridViewTextBoxColumn41
    '
    Me.DataGridViewTextBoxColumn41.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
    '
    'DataGridViewTextBoxColumn38
    '
    Me.DataGridViewTextBoxColumn38.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
    '
    'DataGridViewTextBoxColumn39
    '
    Me.DataGridViewTextBoxColumn39.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
    '
    'DataGridViewTextBoxColumn36
    '
    Me.DataGridViewTextBoxColumn36.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
    '
    'DataGridViewTextBoxColumn37
    '
    Me.DataGridViewTextBoxColumn37.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
    '
    'DataGridViewTextBoxColumn30
    '
    Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
    '
    'DataGridViewTextBoxColumn32
    '
    Me.DataGridViewTextBoxColumn32.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
    '
    'DataGridViewTextBoxColumn31
    '
    Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
    '
    'DataGridViewTextBoxColumn33
    '
    Me.DataGridViewTextBoxColumn33.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
    '
    'DataGridViewTextBoxColumn28
    '
    Me.DataGridViewTextBoxColumn28.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
    '
    'DataGridViewTextBoxColumn29
    '
    Me.DataGridViewTextBoxColumn29.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
    '
    'DataGridViewTextBoxColumn26
    '
    Me.DataGridViewTextBoxColumn26.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
    '
    'DataGridViewTextBoxColumn27
    '
    Me.DataGridViewTextBoxColumn27.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
    '
    'DataGridViewTextBoxColumn24
    '
    Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
    '
    'DataGridViewTextBoxColumn25
    '
    Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    '
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.ToolStripSeparator1})
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
    'DataGridViewTextBoxColumn34
    '
    Me.DataGridViewTextBoxColumn34.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
    '
    'DataGridViewTextBoxColumn35
    '
    Me.DataGridViewTextBoxColumn35.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
    '
    'DataGridViewTextBoxColumn46
    '
    Me.DataGridViewTextBoxColumn46.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
    '
    'DataGridViewTextBoxColumn47
    '
    Me.DataGridViewTextBoxColumn47.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
    '
    'DataGridViewTextBoxColumn84
    '
    Me.DataGridViewTextBoxColumn84.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
    '
    'DataGridViewTextBoxColumn85
    '
    Me.DataGridViewTextBoxColumn85.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
    '
    'DataGridViewTextBoxColumn86
    '
    Me.DataGridViewTextBoxColumn86.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
    '
    'DataGridViewTextBoxColumn192
    '
    Me.DataGridViewTextBoxColumn192.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn192.Name = "DataGridViewTextBoxColumn192"
    '
    'DataGridViewTextBoxColumn193
    '
    Me.DataGridViewTextBoxColumn193.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn193.Name = "DataGridViewTextBoxColumn193"
    '
    'DataGridViewTextBoxColumn194
    '
    Me.DataGridViewTextBoxColumn194.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn194.Name = "DataGridViewTextBoxColumn194"
    '
    'DataGridViewTextBoxColumn195
    '
    Me.DataGridViewTextBoxColumn195.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn195.Name = "DataGridViewTextBoxColumn195"
    '
    'DataGridViewTextBoxColumn260
    '
    Me.DataGridViewTextBoxColumn260.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn260.Name = "DataGridViewTextBoxColumn260"
    '
    'DataGridViewTextBoxColumn261
    '
    Me.DataGridViewTextBoxColumn261.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn261.Name = "DataGridViewTextBoxColumn261"
    '
    'CtlContratoFichasMedicas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.tb)
    Me.Controls.Add(Me.tvcontratos)
    Me.Controls.Add(Me.HeaderStrip1)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "CtlContratoFichasMedicas"
    Me.Size = New System.Drawing.Size(1205, 286)
    Me.tb.ResumeLayout(False)
    Me.TabDatos.ResumeLayout(False)
    Me.pnldatos.ResumeLayout(False)
    Me.pnlcierre.ResumeLayout(False)
    Me.pnlcierre.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.TabRubros.ResumeLayout(False)
    Me.pnlrubros.ResumeLayout(False)
    CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSFichas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tvcontratos As System.Windows.Forms.TreeView
  Friend WithEvents ilestadocontrato As System.Windows.Forms.ImageList
  Friend WithEvents tb As System.Windows.Forms.TabControl
  Friend WithEvents TabDatos As System.Windows.Forms.TabPage
  Friend WithEvents Label2 As System.Windows.Forms.Label
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
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabRubros As System.Windows.Forms.TabPage
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btneliminarficha As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridView3 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSFichas As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents btnabrirficha As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn83 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents DataGridViewTextBoxColumn136 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn137 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn138 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn139 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn140 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn141 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn142 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn143 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents DataGridViewTextBoxColumn216 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn217 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn218 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn219 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn220 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn221 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn222 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn223 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn224 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn225 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn226 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn227 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn228 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn229 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn230 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn231 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn232 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn233 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn234 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn235 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn236 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn237 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn238 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn239 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn240 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn241 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn242 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn243 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents DataGridViewTextBoxColumn254 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn255 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn256 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn257 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn258 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn259 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn261 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn260 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn262 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn263 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn264 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn265 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents DataGridViewTextBoxColumn334 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn335 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn336 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn337 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents DataGridViewTextBoxColumn370 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn371 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn372 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn373 As DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn374 As DataGridViewTextBoxColumn
  Friend WithEvents pnldatos As Panel
  Friend WithEvents pnlcierre As Panel
  Friend WithEvents lblfeccierre As Label
  Friend WithEvents dtfechasta As DateTimePicker
  Friend WithEvents cbotipoliq As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label4 As Label
  Friend WithEvents cbotiposalida As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Label1 As Label
  Friend WithEvents CtlTipoContrato1 As WWTS.Roles.Controles.CtlTipoContrato
  Friend WithEvents Label24 As Label
  Friend WithEvents dtfecdesde As DateTimePicker
  Friend WithEvents Cerrado As CheckBox
  Friend WithEvents Panel3 As Panel
  Friend WithEvents Label17 As Label
  Friend WithEvents cboSubCentroCosto As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlPatronoCombo1 As WWTS.Roles.Controles.CtlPatronoCombo
  Friend WithEvents Label15 As Label
  Friend WithEvents cboDepartamento As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlArea1 As WWTS.Roles.Controles.CtlArea
  Friend WithEvents cboSeccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlCargo1 As WWTS.Roles.Controles.CtlCargo
  Friend WithEvents Label14 As Label
  Friend WithEvents Label13 As Label
  Friend WithEvents Label12 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents DataGridViewTextBoxColumn375 As DataGridViewTextBoxColumn
  Friend WithEvents btnnuevaficha As ToolStripDropDownButton
  Friend WithEvents FichaPreocupacionalToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FichaOcupacionalToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FichaDeReintegroToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FichaDeRetiroToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn376 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn377 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn378 As DataGridViewTextBoxColumn
  Friend WithEvents btnimprimirficha As ToolStripDropDownButton
  Friend WithEvents btnpag1 As ToolStripMenuItem
  Friend WithEvents btnpag2 As ToolStripMenuItem
  Friend WithEvents btnpag3 As ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn379 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn380 As DataGridViewTextBoxColumn
End Class
