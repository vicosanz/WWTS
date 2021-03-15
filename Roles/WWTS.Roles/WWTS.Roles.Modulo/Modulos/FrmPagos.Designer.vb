Imports WWTS.General.Controles
Imports Infoware.Consola.Base

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagos))
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.TabControl2 = New System.Windows.Forms.TabControl()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.lvpagosvarios = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.pnlmantloteaction = New System.Windows.Forms.Panel()
    Me.btnnuevopago = New Infoware.Controles.Base.ButtonStd()
    Me.btnmodifpago = New Infoware.Controles.Base.ButtonStd()
    Me.btnelimpago = New Infoware.Controles.Base.ButtonStd()
    Me.btnlotepago = New Infoware.Controles.Base.ButtonStd()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.btnnuevolote = New Infoware.Controles.Base.ButtonStd()
    Me.CtlLotePago2 = New WWTS.Roles.Modulo.CtlLotePago()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.CtlPatrono2 = New WWTS.Roles.Modulo.CtlPatrono()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TabPage5 = New System.Windows.Forms.TabPage()
    Me.TabControl3 = New System.Windows.Forms.TabControl()
    Me.TabPage7 = New System.Windows.Forms.TabPage()
    Me.crvlistadocheques = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.Panel6 = New System.Windows.Forms.Panel()
    Me.btnmostrar = New Infoware.Controles.Base.ButtonStd()
    Me.btnexportar = New Infoware.Controles.Base.ButtonStd()
    Me.pnlajustable = New System.Windows.Forms.Panel()
    Me.cboCtaBancaria = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboBanco = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.pnlseltipocontrato = New System.Windows.Forms.Panel()
    Me.pnltipocontrato = New System.Windows.Forms.Panel()
    Me.CtlTipoContrato1 = New WWTS.Roles.Modulo.CtlTipoContrato()
    Me.chktipocontrato = New System.Windows.Forms.CheckBox()
    Me.CtlPatrono1 = New WWTS.Roles.Modulo.CtlPatrono()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.pnlgroupconcepto = New System.Windows.Forms.Panel()
    Me.pnlconcepto = New System.Windows.Forms.Panel()
    Me.cboconcepto = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.chkconcepto = New System.Windows.Forms.CheckBox()
    Me.cbotipocheque = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.tabprovisiones = New System.Windows.Forms.TabControl()
    Me.TabPage8 = New System.Windows.Forms.TabPage()
    Me.dgprovisiones = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProvisionCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.btnmostrarprov = New Infoware.Controles.Base.ButtonStd()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.CtlPatronoProv = New WWTS.Roles.Modulo.CtlPatrono()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.dtfechastaprov = New System.Windows.Forms.DateTimePicker()
    Me.dtfecdesdeprov = New System.Windows.Forms.DateTimePicker()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.HeaderStrip3 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
    Me.tbreporteprov = New System.Windows.Forms.TabPage()
    Me.crv_provision = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
    Me.mnuPagoCheque = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnulistapagos = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.TabControl2.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.pnlmantloteaction.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.TabControl3.SuspendLayout()
    Me.TabPage7.SuspendLayout()
    Me.Panel5.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.pnlajustable.SuspendLayout()
    Me.pnlseltipocontrato.SuspendLayout()
    Me.pnltipocontrato.SuspendLayout()
    Me.pnlgroupconcepto.SuspendLayout()
    Me.pnlconcepto.SuspendLayout()
    Me.HeaderStrip2.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.tabprovisiones.SuspendLayout()
    Me.TabPage8.SuspendLayout()
    CType(Me.dgprovisiones, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ProvisionCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.Panel7.SuspendLayout()
    Me.HeaderStrip3.SuspendLayout()
    Me.tbreporteprov.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.TabControl2)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(1605, 1037)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TabControl2
    '
    Me.TabControl2.Controls.Add(Me.TabPage4)
    Me.TabControl2.Controls.Add(Me.TabPage5)
    Me.TabControl2.Controls.Add(Me.TabPage1)
    Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl2.Location = New System.Drawing.Point(0, 31)
    Me.TabControl2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabControl2.Name = "TabControl2"
    Me.TabControl2.SelectedIndex = 0
    Me.TabControl2.Size = New System.Drawing.Size(1605, 1006)
    Me.TabControl2.TabIndex = 0
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.lvpagosvarios)
    Me.TabPage4.Controls.Add(Me.pnlmantloteaction)
    Me.TabPage4.Controls.Add(Me.Panel3)
    Me.TabPage4.Location = New System.Drawing.Point(4, 25)
    Me.TabPage4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage4.Size = New System.Drawing.Size(1597, 977)
    Me.TabPage4.TabIndex = 1
    Me.TabPage4.Text = "Mantenimiento de lotes"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'lvpagosvarios
    '
    Me.lvpagosvarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
    Me.lvpagosvarios.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvpagosvarios.FullRowSelect = True
    Me.lvpagosvarios.HideSelection = False
    Me.lvpagosvarios.Location = New System.Drawing.Point(302, 52)
    Me.lvpagosvarios.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.lvpagosvarios.Name = "lvpagosvarios"
    Me.lvpagosvarios.Size = New System.Drawing.Size(1290, 920)
    Me.lvpagosvarios.TabIndex = 4
    Me.lvpagosvarios.UseCompatibleStateImageBehavior = False
    Me.lvpagosvarios.View = System.Windows.Forms.View.Details
    Me.lvpagosvarios.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Beneficiario"
    Me.ColumnHeader1.Width = 250
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Valor"
    Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader2.Width = 80
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Observación"
    Me.ColumnHeader3.Width = 250
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Motivo"
    Me.ColumnHeader4.Width = 140
    '
    'pnlmantloteaction
    '
    Me.pnlmantloteaction.Controls.Add(Me.btnnuevopago)
    Me.pnlmantloteaction.Controls.Add(Me.btnmodifpago)
    Me.pnlmantloteaction.Controls.Add(Me.btnelimpago)
    Me.pnlmantloteaction.Controls.Add(Me.btnlotepago)
    Me.pnlmantloteaction.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlmantloteaction.Location = New System.Drawing.Point(302, 5)
    Me.pnlmantloteaction.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.pnlmantloteaction.Name = "pnlmantloteaction"
    Me.pnlmantloteaction.Size = New System.Drawing.Size(1290, 47)
    Me.pnlmantloteaction.TabIndex = 3
    '
    'btnnuevopago
    '
    Me.btnnuevopago.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnnuevopago.Location = New System.Drawing.Point(11, 5)
    Me.btnnuevopago.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnnuevopago.Name = "btnnuevopago"
    Me.btnnuevopago.Size = New System.Drawing.Size(160, 23)
    Me.btnnuevopago.TabIndex = 4
    Me.btnnuevopago.Text = "Nuevo pago"
    '
    'btnmodifpago
    '
    Me.btnmodifpago.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmodifpago.Location = New System.Drawing.Point(352, 5)
    Me.btnmodifpago.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnmodifpago.Name = "btnmodifpago"
    Me.btnmodifpago.Size = New System.Drawing.Size(160, 23)
    Me.btnmodifpago.TabIndex = 6
    Me.btnmodifpago.Text = "Modificar"
    Me.btnmodifpago.Visible = False
    '
    'btnelimpago
    '
    Me.btnelimpago.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnelimpago.Location = New System.Drawing.Point(523, 5)
    Me.btnelimpago.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnelimpago.Name = "btnelimpago"
    Me.btnelimpago.Size = New System.Drawing.Size(160, 23)
    Me.btnelimpago.TabIndex = 7
    Me.btnelimpago.Text = "Eliminar pago"
    Me.btnelimpago.Visible = False
    '
    'btnlotepago
    '
    Me.btnlotepago.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlotepago.Location = New System.Drawing.Point(181, 5)
    Me.btnlotepago.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnlotepago.Name = "btnlotepago"
    Me.btnlotepago.Size = New System.Drawing.Size(160, 23)
    Me.btnlotepago.TabIndex = 5
    Me.btnlotepago.Text = "Ingresar lote"
    Me.btnlotepago.Visible = False
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.SystemColors.Info
    Me.Panel3.Controls.Add(Me.btnnuevolote)
    Me.Panel3.Controls.Add(Me.CtlLotePago2)
    Me.Panel3.Controls.Add(Me.Label10)
    Me.Panel3.Controls.Add(Me.CtlPatrono2)
    Me.Panel3.Controls.Add(Me.Label1)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel3.Location = New System.Drawing.Point(5, 5)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Padding = New System.Windows.Forms.Padding(9, 7, 9, 7)
    Me.Panel3.Size = New System.Drawing.Size(297, 967)
    Me.Panel3.TabIndex = 2
    '
    'btnnuevolote
    '
    Me.btnnuevolote.Dock = System.Windows.Forms.DockStyle.Top
    Me.btnnuevolote.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnnuevolote.Location = New System.Drawing.Point(9, 371)
    Me.btnnuevolote.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnnuevolote.Name = "btnnuevolote"
    Me.btnnuevolote.Size = New System.Drawing.Size(279, 23)
    Me.btnnuevolote.TabIndex = 9
    Me.btnnuevolote.Text = "Nuevo lote"
    '
    'CtlLotePago2
    '
    Me.CtlLotePago2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlLotePago2.Location = New System.Drawing.Point(9, 207)
    Me.CtlLotePago2.LotePago = Nothing
    Me.CtlLotePago2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
    Me.CtlLotePago2.Name = "CtlLotePago2"
    Me.CtlLotePago2.Patrono = Nothing
    Me.CtlLotePago2.Size = New System.Drawing.Size(279, 164)
    Me.CtlLotePago2.TabIndex = 10
    '
    'Label10
    '
    Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label10.Location = New System.Drawing.Point(9, 180)
    Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(279, 27)
    Me.Label10.TabIndex = 7
    Me.Label10.Text = "Lote:"
    '
    'CtlPatrono2
    '
    Me.CtlPatrono2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlPatrono2.Location = New System.Drawing.Point(9, 34)
    Me.CtlPatrono2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
    Me.CtlPatrono2.Name = "CtlPatrono2"
    Me.CtlPatrono2.Op = Nothing
    Me.CtlPatrono2.Patrono = Nothing
    Me.CtlPatrono2.Size = New System.Drawing.Size(279, 146)
    Me.CtlPatrono2.TabIndex = 12
    Me.CtlPatrono2.Usuario = Nothing
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(9, 7)
    Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(279, 27)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Patrono:"
    '
    'TabPage5
    '
    Me.TabPage5.Controls.Add(Me.TabControl3)
    Me.TabPage5.Location = New System.Drawing.Point(4, 25)
    Me.TabPage5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage5.Size = New System.Drawing.Size(1597, 977)
    Me.TabPage5.TabIndex = 2
    Me.TabPage5.Text = "Cheques generados"
    Me.TabPage5.UseVisualStyleBackColor = True
    '
    'TabControl3
    '
    Me.TabControl3.Controls.Add(Me.TabPage7)
    Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl3.Location = New System.Drawing.Point(5, 5)
    Me.TabControl3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabControl3.Name = "TabControl3"
    Me.TabControl3.SelectedIndex = 0
    Me.TabControl3.Size = New System.Drawing.Size(1587, 967)
    Me.TabControl3.TabIndex = 0
    '
    'TabPage7
    '
    Me.TabPage7.Controls.Add(Me.crvlistadocheques)
    Me.TabPage7.Controls.Add(Me.Panel5)
    Me.TabPage7.Location = New System.Drawing.Point(4, 25)
    Me.TabPage7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage7.Name = "TabPage7"
    Me.TabPage7.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage7.Size = New System.Drawing.Size(1579, 938)
    Me.TabPage7.TabIndex = 1
    Me.TabPage7.Text = "Listado de cheques"
    Me.TabPage7.UseVisualStyleBackColor = True
    '
    'crvlistadocheques
    '
    Me.crvlistadocheques.ActiveViewIndex = -1
    Me.crvlistadocheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvlistadocheques.Cursor = System.Windows.Forms.Cursors.Default
    Me.crvlistadocheques.DisplayStatusBar = False
    Me.crvlistadocheques.DisplayToolbar = False
    Me.crvlistadocheques.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvlistadocheques.Location = New System.Drawing.Point(304, 5)
    Me.crvlistadocheques.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.crvlistadocheques.Name = "crvlistadocheques"
    Me.crvlistadocheques.SelectionFormula = ""
    Me.crvlistadocheques.Size = New System.Drawing.Size(1270, 928)
    Me.crvlistadocheques.TabIndex = 4
    Me.crvlistadocheques.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    Me.crvlistadocheques.ToolPanelWidth = 267
    Me.crvlistadocheques.ViewTimeSelectionFormula = ""
    '
    'Panel5
    '
    Me.Panel5.BackColor = System.Drawing.SystemColors.Info
    Me.Panel5.Controls.Add(Me.Panel6)
    Me.Panel5.Controls.Add(Me.pnlajustable)
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel5.Location = New System.Drawing.Point(5, 5)
    Me.Panel5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel5.Size = New System.Drawing.Size(299, 928)
    Me.Panel5.TabIndex = 3
    '
    'Panel6
    '
    Me.Panel6.Controls.Add(Me.btnmostrar)
    Me.Panel6.Controls.Add(Me.btnexportar)
    Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel6.Location = New System.Drawing.Point(5, 692)
    Me.Panel6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(289, 110)
    Me.Panel6.TabIndex = 3
    '
    'btnmostrar
    '
    Me.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrar.Location = New System.Drawing.Point(149, 12)
    Me.btnmostrar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(160, 23)
    Me.btnmostrar.TabIndex = 0
    Me.btnmostrar.Text = "&Mostrar"
    '
    'btnexportar
    '
    Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnexportar.Location = New System.Drawing.Point(149, 60)
    Me.btnexportar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(160, 23)
    Me.btnexportar.TabIndex = 0
    Me.btnexportar.Text = "&Exportar"
    Me.btnexportar.Visible = False
    '
    'pnlajustable
    '
    Me.pnlajustable.Controls.Add(Me.cboCtaBancaria)
    Me.pnlajustable.Controls.Add(Me.cboBanco)
    Me.pnlajustable.Controls.Add(Me.Label9)
    Me.pnlajustable.Controls.Add(Me.dtfechasta)
    Me.pnlajustable.Controls.Add(Me.Label7)
    Me.pnlajustable.Controls.Add(Me.dtfecdesde)
    Me.pnlajustable.Controls.Add(Me.Label6)
    Me.pnlajustable.Controls.Add(Me.pnlseltipocontrato)
    Me.pnlajustable.Controls.Add(Me.pnlgroupconcepto)
    Me.pnlajustable.Controls.Add(Me.cbotipocheque)
    Me.pnlajustable.Controls.Add(Me.Label5)
    Me.pnlajustable.Controls.Add(Me.HeaderStrip2)
    Me.pnlajustable.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlajustable.Location = New System.Drawing.Point(5, 5)
    Me.pnlajustable.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.pnlajustable.Name = "pnlajustable"
    Me.pnlajustable.Size = New System.Drawing.Size(289, 687)
    Me.pnlajustable.TabIndex = 2
    '
    'cboCtaBancaria
    '
    Me.cboCtaBancaria.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboCtaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCtaBancaria.Location = New System.Drawing.Point(0, 526)
    Me.cboCtaBancaria.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.cboCtaBancaria.Name = "cboCtaBancaria"
    Me.cboCtaBancaria.OperadorDatos = Nothing
    Me.cboCtaBancaria.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboCtaBancaria.ParametroDet = Nothing
    Me.cboCtaBancaria.PuedeActualizar = True
    Me.cboCtaBancaria.PuedeEliminar = True
    Me.cboCtaBancaria.PuedeModificar = True
    Me.cboCtaBancaria.PuedeNuevo = True
    Me.cboCtaBancaria.Size = New System.Drawing.Size(289, 24)
    Me.cboCtaBancaria.TabIndex = 18
    '
    'cboBanco
    '
    Me.cboBanco.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboBanco.Location = New System.Drawing.Point(0, 502)
    Me.cboBanco.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.cboBanco.Name = "cboBanco"
    Me.cboBanco.OperadorDatos = Nothing
    Me.cboBanco.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboBanco.ParametroDet = Nothing
    Me.cboBanco.PuedeActualizar = True
    Me.cboBanco.PuedeEliminar = True
    Me.cboBanco.PuedeModificar = True
    Me.cboBanco.PuedeNuevo = True
    Me.cboBanco.Size = New System.Drawing.Size(289, 24)
    Me.cboBanco.TabIndex = 17
    '
    'Label9
    '
    Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label9.Location = New System.Drawing.Point(0, 471)
    Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(289, 31)
    Me.Label9.TabIndex = 12
    Me.Label9.Text = "de la cuenta bancaria"
    Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfechasta
    '
    Me.dtfechasta.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(0, 449)
    Me.dtfechasta.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(289, 22)
    Me.dtfechasta.TabIndex = 5
    '
    'Label7
    '
    Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label7.Location = New System.Drawing.Point(0, 418)
    Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(289, 31)
    Me.Label7.TabIndex = 4
    Me.Label7.Text = "hasta:"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(0, 396)
    Me.dtfecdesde.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(289, 22)
    Me.dtfecdesde.TabIndex = 3
    '
    'Label6
    '
    Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label6.Location = New System.Drawing.Point(0, 365)
    Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(289, 31)
    Me.Label6.TabIndex = 2
    Me.Label6.Text = "Rango de fecha desde:"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlseltipocontrato
    '
    Me.pnlseltipocontrato.Controls.Add(Me.pnltipocontrato)
    Me.pnlseltipocontrato.Controls.Add(Me.chktipocontrato)
    Me.pnlseltipocontrato.Controls.Add(Me.CtlPatrono1)
    Me.pnlseltipocontrato.Controls.Add(Me.Label8)
    Me.pnlseltipocontrato.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlseltipocontrato.Location = New System.Drawing.Point(0, 146)
    Me.pnlseltipocontrato.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.pnlseltipocontrato.Name = "pnlseltipocontrato"
    Me.pnlseltipocontrato.Size = New System.Drawing.Size(289, 219)
    Me.pnlseltipocontrato.TabIndex = 14
    Me.pnlseltipocontrato.Visible = False
    '
    'pnltipocontrato
    '
    Me.pnltipocontrato.Controls.Add(Me.CtlTipoContrato1)
    Me.pnltipocontrato.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnltipocontrato.Location = New System.Drawing.Point(0, 182)
    Me.pnltipocontrato.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.pnltipocontrato.Name = "pnltipocontrato"
    Me.pnltipocontrato.Size = New System.Drawing.Size(289, 38)
    Me.pnltipocontrato.TabIndex = 11
    Me.pnltipocontrato.Visible = False
    '
    'CtlTipoContrato1
    '
    Me.CtlTipoContrato1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTipoContrato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlTipoContrato1.FormattingEnabled = True
    Me.CtlTipoContrato1.Location = New System.Drawing.Point(0, 0)
    Me.CtlTipoContrato1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.CtlTipoContrato1.Name = "CtlTipoContrato1"
    Me.CtlTipoContrato1.Op = Nothing
    Me.CtlTipoContrato1.Patrono = Nothing
    Me.CtlTipoContrato1.PuedeActualizar = True
    Me.CtlTipoContrato1.PuedeEliminar = True
    Me.CtlTipoContrato1.PuedeModificar = True
    Me.CtlTipoContrato1.PuedeNuevo = True
    Me.CtlTipoContrato1.Size = New System.Drawing.Size(289, 24)
    Me.CtlTipoContrato1.TabIndex = 0
    Me.CtlTipoContrato1.TipoContrato = Nothing
    '
    'chktipocontrato
    '
    Me.chktipocontrato.Dock = System.Windows.Forms.DockStyle.Top
    Me.chktipocontrato.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chktipocontrato.Location = New System.Drawing.Point(0, 154)
    Me.chktipocontrato.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.chktipocontrato.Name = "chktipocontrato"
    Me.chktipocontrato.Size = New System.Drawing.Size(289, 28)
    Me.chktipocontrato.TabIndex = 10
    Me.chktipocontrato.Text = "por tipo de contrato:"
    '
    'CtlPatrono1
    '
    Me.CtlPatrono1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlPatrono1.Location = New System.Drawing.Point(0, 31)
    Me.CtlPatrono1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
    Me.CtlPatrono1.Name = "CtlPatrono1"
    Me.CtlPatrono1.Op = Nothing
    Me.CtlPatrono1.Patrono = Nothing
    Me.CtlPatrono1.Size = New System.Drawing.Size(289, 123)
    Me.CtlPatrono1.TabIndex = 13
    Me.CtlPatrono1.Usuario = Nothing
    '
    'Label8
    '
    Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label8.Location = New System.Drawing.Point(0, 0)
    Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(289, 31)
    Me.Label8.TabIndex = 12
    Me.Label8.Text = "Patrono"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlgroupconcepto
    '
    Me.pnlgroupconcepto.Controls.Add(Me.pnlconcepto)
    Me.pnlgroupconcepto.Controls.Add(Me.chkconcepto)
    Me.pnlgroupconcepto.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlgroupconcepto.Location = New System.Drawing.Point(0, 81)
    Me.pnlgroupconcepto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.pnlgroupconcepto.Name = "pnlgroupconcepto"
    Me.pnlgroupconcepto.Size = New System.Drawing.Size(289, 65)
    Me.pnlgroupconcepto.TabIndex = 15
    '
    'pnlconcepto
    '
    Me.pnlconcepto.Controls.Add(Me.cboconcepto)
    Me.pnlconcepto.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlconcepto.Location = New System.Drawing.Point(0, 28)
    Me.pnlconcepto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.pnlconcepto.Name = "pnlconcepto"
    Me.pnlconcepto.Size = New System.Drawing.Size(289, 37)
    Me.pnlconcepto.TabIndex = 7
    Me.pnlconcepto.Visible = False
    '
    'cboconcepto
    '
    Me.cboconcepto.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboconcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboconcepto.Location = New System.Drawing.Point(0, 0)
    Me.cboconcepto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.cboconcepto.Name = "cboconcepto"
    Me.cboconcepto.OperadorDatos = Nothing
    Me.cboconcepto.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboconcepto.ParametroDet = Nothing
    Me.cboconcepto.PuedeActualizar = True
    Me.cboconcepto.PuedeEliminar = True
    Me.cboconcepto.PuedeModificar = True
    Me.cboconcepto.PuedeNuevo = True
    Me.cboconcepto.Size = New System.Drawing.Size(289, 24)
    Me.cboconcepto.TabIndex = 0
    '
    'chkconcepto
    '
    Me.chkconcepto.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkconcepto.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkconcepto.Location = New System.Drawing.Point(0, 0)
    Me.chkconcepto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.chkconcepto.Name = "chkconcepto"
    Me.chkconcepto.Size = New System.Drawing.Size(289, 28)
    Me.chkconcepto.TabIndex = 6
    Me.chkconcepto.Text = "por concepto de:"
    '
    'cbotipocheque
    '
    Me.cbotipocheque.Dock = System.Windows.Forms.DockStyle.Top
    Me.cbotipocheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipocheque.ItemHeight = 16
    Me.cbotipocheque.Items.AddRange(New Object() {"Emitidos y anulados", "Solo emitidos", "Solo anulados"})
    Me.cbotipocheque.Location = New System.Drawing.Point(0, 57)
    Me.cbotipocheque.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.cbotipocheque.Name = "cbotipocheque"
    Me.cbotipocheque.OperadorDatos = Nothing
    Me.cbotipocheque.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipocheque.ParametroDet = Nothing
    Me.cbotipocheque.PuedeActualizar = True
    Me.cbotipocheque.PuedeEliminar = True
    Me.cbotipocheque.PuedeModificar = True
    Me.cbotipocheque.PuedeNuevo = True
    Me.cbotipocheque.Size = New System.Drawing.Size(289, 24)
    Me.cbotipocheque.TabIndex = 1
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.SystemColors.Info
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label5.Location = New System.Drawing.Point(0, 26)
    Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(289, 31)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Reportar cheques"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
    Me.HeaderStrip2.Size = New System.Drawing.Size(289, 26)
    Me.HeaderStrip2.TabIndex = 16
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(128, 23)
    Me.ToolStripLabel2.Text = "Filtros de cheques"
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.tabprovisiones)
    Me.TabPage1.Location = New System.Drawing.Point(4, 25)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage1.Size = New System.Drawing.Size(1597, 981)
    Me.TabPage1.TabIndex = 3
    Me.TabPage1.Text = "Provisiones"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'tabprovisiones
    '
    Me.tabprovisiones.Controls.Add(Me.TabPage8)
    Me.tabprovisiones.Controls.Add(Me.tbreporteprov)
    Me.tabprovisiones.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tabprovisiones.Location = New System.Drawing.Point(5, 5)
    Me.tabprovisiones.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.tabprovisiones.Name = "tabprovisiones"
    Me.tabprovisiones.SelectedIndex = 0
    Me.tabprovisiones.Size = New System.Drawing.Size(1587, 971)
    Me.tabprovisiones.TabIndex = 7
    '
    'TabPage8
    '
    Me.TabPage8.Controls.Add(Me.dgprovisiones)
    Me.TabPage8.Controls.Add(Me.Panel1)
    Me.TabPage8.Location = New System.Drawing.Point(4, 25)
    Me.TabPage8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage8.Name = "TabPage8"
    Me.TabPage8.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.TabPage8.Size = New System.Drawing.Size(1579, 942)
    Me.TabPage8.TabIndex = 0
    Me.TabPage8.Text = "Provisiones extras"
    Me.TabPage8.UseVisualStyleBackColor = True
    '
    'dgprovisiones
    '
    Me.dgprovisiones.AgruparRepetidos = False
    Me.dgprovisiones.AutoGenerateColumns = False
    Me.dgprovisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgprovisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8})
    Me.dgprovisiones.DataSource = Me.ProvisionCollectionBindingSource
    Me.dgprovisiones.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgprovisiones.Location = New System.Drawing.Point(304, 5)
    Me.dgprovisiones.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.dgprovisiones.Name = "dgprovisiones"
    Me.dgprovisiones.Size = New System.Drawing.Size(1270, 932)
    Me.dgprovisiones.TabIndex = 0
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.Info
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.Panel4)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Location = New System.Drawing.Point(5, 5)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel1.Size = New System.Drawing.Size(299, 932)
    Me.Panel1.TabIndex = 4
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btnmostrarprov)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(5, 371)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(289, 58)
    Me.Panel2.TabIndex = 3
    '
    'btnmostrarprov
    '
    Me.btnmostrarprov.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrarprov.Location = New System.Drawing.Point(149, 12)
    Me.btnmostrarprov.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.btnmostrarprov.Name = "btnmostrarprov"
    Me.btnmostrarprov.Size = New System.Drawing.Size(160, 23)
    Me.btnmostrarprov.TabIndex = 0
    Me.btnmostrarprov.Text = "&Mostrar"
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.Panel7)
    Me.Panel4.Controls.Add(Me.dtfechastaprov)
    Me.Panel4.Controls.Add(Me.dtfecdesdeprov)
    Me.Panel4.Controls.Add(Me.Label12)
    Me.Panel4.Controls.Add(Me.HeaderStrip3)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel4.Location = New System.Drawing.Point(5, 5)
    Me.Panel4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(289, 366)
    Me.Panel4.TabIndex = 2
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.CtlPatronoProv)
    Me.Panel7.Controls.Add(Me.Label11)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 116)
    Me.Panel7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(289, 219)
    Me.Panel7.TabIndex = 14
    '
    'CtlPatronoProv
    '
    Me.CtlPatronoProv.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPatronoProv.Location = New System.Drawing.Point(0, 31)
    Me.CtlPatronoProv.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
    Me.CtlPatronoProv.Name = "CtlPatronoProv"
    Me.CtlPatronoProv.Op = Nothing
    Me.CtlPatronoProv.Patrono = Nothing
    Me.CtlPatronoProv.Size = New System.Drawing.Size(289, 188)
    Me.CtlPatronoProv.TabIndex = 13
    Me.CtlPatronoProv.Usuario = Nothing
    '
    'Label11
    '
    Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label11.Location = New System.Drawing.Point(0, 0)
    Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(289, 31)
    Me.Label11.TabIndex = 12
    Me.Label11.Text = "Patrono"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtfechastaprov
    '
    Me.dtfechastaprov.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfechastaprov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechastaprov.Location = New System.Drawing.Point(0, 94)
    Me.dtfechastaprov.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.dtfechastaprov.Name = "dtfechastaprov"
    Me.dtfechastaprov.Size = New System.Drawing.Size(289, 22)
    Me.dtfechastaprov.TabIndex = 5
    '
    'dtfecdesdeprov
    '
    Me.dtfecdesdeprov.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecdesdeprov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesdeprov.Location = New System.Drawing.Point(0, 72)
    Me.dtfecdesdeprov.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.dtfecdesdeprov.Name = "dtfecdesdeprov"
    Me.dtfecdesdeprov.Size = New System.Drawing.Size(289, 22)
    Me.dtfecdesdeprov.TabIndex = 3
    '
    'Label12
    '
    Me.Label12.BackColor = System.Drawing.SystemColors.Info
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label12.Location = New System.Drawing.Point(0, 26)
    Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(289, 46)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "Mostrar provisiones para el rango de fechas"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'HeaderStrip3
    '
    Me.HeaderStrip3.AutoSize = False
    Me.HeaderStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip3.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip3.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
    Me.HeaderStrip3.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip3.Name = "HeaderStrip3"
    Me.HeaderStrip3.Size = New System.Drawing.Size(289, 26)
    Me.HeaderStrip3.TabIndex = 16
    Me.HeaderStrip3.Text = "Opciones"
    '
    'ToolStripLabel3
    '
    Me.ToolStripLabel3.Name = "ToolStripLabel3"
    Me.ToolStripLabel3.Size = New System.Drawing.Size(143, 23)
    Me.ToolStripLabel3.Text = "Filtro de provisiones"
    '
    'tbreporteprov
    '
    Me.tbreporteprov.Controls.Add(Me.crv_provision)
    Me.tbreporteprov.Location = New System.Drawing.Point(4, 25)
    Me.tbreporteprov.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.tbreporteprov.Name = "tbreporteprov"
    Me.tbreporteprov.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.tbreporteprov.Size = New System.Drawing.Size(1576, 940)
    Me.tbreporteprov.TabIndex = 1
    Me.tbreporteprov.Text = "Reportes"
    Me.tbreporteprov.UseVisualStyleBackColor = True
    '
    'crv_provision
    '
    Me.crv_provision.ActiveViewIndex = -1
    Me.crv_provision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crv_provision.Cursor = System.Windows.Forms.Cursors.Default
    Me.crv_provision.DisplayStatusBar = False
    Me.crv_provision.DisplayToolbar = False
    Me.crv_provision.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crv_provision.Location = New System.Drawing.Point(5, 5)
    Me.crv_provision.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.crv_provision.Name = "crv_provision"
    Me.crv_provision.ShowGroupTreeButton = False
    Me.crv_provision.Size = New System.Drawing.Size(1566, 930)
    Me.crv_provision.TabIndex = 0
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(1605, 31)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(146, 28)
    Me.ToolStripLabel1.Text = "Pagos varios"
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
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 2, 0, 2)
    Me.MenuStrip1.Size = New System.Drawing.Size(1605, 33)
    Me.MenuStrip1.TabIndex = 3
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'btnReporte
    '
    Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPagoCheque, Me.ToolStripSeparator1, Me.mnulistapagos})
    Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
    Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReporte.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnReporte.MergeIndex = 5
    Me.btnReporte.Name = "btnReporte"
    Me.btnReporte.Size = New System.Drawing.Size(97, 26)
    Me.btnReporte.Text = "Reportes"
    '
    'mnuPagoCheque
    '
    Me.mnuPagoCheque.Name = "mnuPagoCheque"
    Me.mnuPagoCheque.Size = New System.Drawing.Size(192, 24)
    Me.mnuPagoCheque.Text = "Pago Cheque"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
    '
    'mnulistapagos
    '
    Me.mnulistapagos.Name = "mnulistapagos"
    Me.mnulistapagos.Size = New System.Drawing.Size(192, 24)
    Me.mnulistapagos.Text = "Listado de pagos"
    '
    'FrmPagos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1605, 1037)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Name = "FrmPagos"
    Me.Text = "Pagos"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TabControl2.ResumeLayout(False)
    Me.TabPage4.ResumeLayout(False)
    Me.pnlmantloteaction.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.TabPage5.ResumeLayout(False)
    Me.TabControl3.ResumeLayout(False)
    Me.TabPage7.ResumeLayout(False)
    Me.Panel5.ResumeLayout(False)
    Me.Panel6.ResumeLayout(False)
    Me.pnlajustable.ResumeLayout(False)
    Me.pnlseltipocontrato.ResumeLayout(False)
    Me.pnltipocontrato.ResumeLayout(False)
    Me.pnlgroupconcepto.ResumeLayout(False)
    Me.pnlconcepto.ResumeLayout(False)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.TabPage1.ResumeLayout(False)
    Me.tabprovisiones.ResumeLayout(False)
    Me.TabPage8.ResumeLayout(False)
    CType(Me.dgprovisiones, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ProvisionCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.Panel7.ResumeLayout(False)
    Me.HeaderStrip3.ResumeLayout(False)
    Me.HeaderStrip3.PerformLayout()
    Me.tbreporteprov.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents CtlLotePago2 As CtlLotePago
  Friend WithEvents btnnuevolote As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents lvpagosvarios As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents pnlmantloteaction As System.Windows.Forms.Panel
  Friend WithEvents btnnuevopago As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnmodifpago As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnelimpago As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnlotepago As Infoware.Controles.Base.ButtonStd
  Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents btnmostrar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnexportar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents pnlajustable As System.Windows.Forms.Panel
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents pnlseltipocontrato As System.Windows.Forms.Panel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents pnltipocontrato As System.Windows.Forms.Panel
  Friend WithEvents chktipocontrato As System.Windows.Forms.CheckBox
  Friend WithEvents pnlgroupconcepto As System.Windows.Forms.Panel
  Friend WithEvents pnlconcepto As System.Windows.Forms.Panel
  Friend WithEvents cboconcepto As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chkconcepto As System.Windows.Forms.CheckBox
  Friend WithEvents cbotipocheque As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents crvlistadocheques As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents CtlPatrono1 As CtlPatrono
  Friend WithEvents CtlTipoContrato1 As CtlTipoContrato
  Friend WithEvents ProvisionCollectionBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents PrvfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrvobservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrvvalorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents mnuPagoCheque As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnulistapagos As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CtlPatrono2 As WWTS.Roles.Modulo.CtlPatrono
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents tabprovisiones As System.Windows.Forms.TabControl
  Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
  Friend WithEvents dgprovisiones As DataGridViewAutoDiscover
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents btnmostrarprov As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents CtlPatronoProv As WWTS.Roles.Modulo.CtlPatrono
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents dtfechastaprov As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfecdesdeprov As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip3 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents tbreporteprov As System.Windows.Forms.TabPage
  Friend WithEvents crv_provision As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents cboCtaBancaria As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents cboBanco As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
