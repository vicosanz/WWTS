Imports Infoware.Controles.Base

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNomina
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNomina))
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.DataGridView1 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSRubroDet = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.lbl_descripcion = New System.Windows.Forms.Label()
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
    Me.btnabrir = New System.Windows.Forms.ToolStripButton()
    Me.btnExcel = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btngrabar = New System.Windows.Forms.ToolStripButton()
    Me.btneliminar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.PagarLiquidacion = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnNoMensualizar = New System.Windows.Forms.ToolStripButton()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.txtIngresos = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.txtEgresos = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.txtTotal = New System.Windows.Forms.ToolStripStatusLabel()
    Me.CtlBuscaEmpleadosPeriodo1 = New CtlBuscaEmpleadosPeriodo()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
    Me.NominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSobreMensual = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuPagoEfectivo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPagoCheque = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPagoDeposito = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.AsientoContableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSRubroDet, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip2.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.TabControl1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 33)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(1101, 832)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 32)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1101, 800)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Controls.Add(Me.CtlBuscaEmpleadosPeriodo1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 25)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage1.Size = New System.Drawing.Size(1093, 771)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Mantenimiento de Nómina"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.DataGridView1)
    Me.Panel1.Controls.Add(Me.lbl_descripcion)
    Me.Panel1.Controls.Add(Me.HeaderStrip2)
    Me.Panel1.Controls.Add(Me.StatusStrip1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Enabled = False
    Me.Panel1.Location = New System.Drawing.Point(266, 5)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
    Me.Panel1.Size = New System.Drawing.Size(823, 761)
    Me.Panel1.TabIndex = 1
    '
    'DataGridView1
    '
    Me.DataGridView1.AgruparRepetidos = False
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn86})
    Me.DataGridView1.DataSource = Me.BSRubroDet
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(8, 58)
    Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(815, 678)
    Me.DataGridView1.TabIndex = 2
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
    'lbl_descripcion
    '
    Me.lbl_descripcion.BackColor = System.Drawing.SystemColors.Info
    Me.lbl_descripcion.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbl_descripcion.Location = New System.Drawing.Point(8, 26)
    Me.lbl_descripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lbl_descripcion.Name = "lbl_descripcion"
    Me.lbl_descripcion.Size = New System.Drawing.Size(815, 32)
    Me.lbl_descripcion.TabIndex = 1
    Me.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.lbl_descripcion.Visible = False
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.btnabrir, Me.btnExcel, Me.ToolStripSeparator1, Me.btngrabar, Me.btneliminar, Me.ToolStripSeparator2, Me.PagarLiquidacion, Me.ToolStripSeparator4, Me.btnNoMensualizar})
    Me.HeaderStrip2.Location = New System.Drawing.Point(8, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
    Me.HeaderStrip2.Size = New System.Drawing.Size(815, 26)
    Me.HeaderStrip2.TabIndex = 0
    Me.HeaderStrip2.Text = "HeaderStrip2"
    '
    'btnnuevo
    '
    Me.btnnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevo.Image = My.Resources.Resources._new
    Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(24, 23)
    Me.btnnuevo.Text = "Nuevo"
    Me.btnnuevo.ToolTipText = "Nuevo"
    '
    'btnabrir
    '
    Me.btnabrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnabrir.Image = My.Resources.Resources.open
    Me.btnabrir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnabrir.Name = "btnabrir"
    Me.btnabrir.Size = New System.Drawing.Size(24, 23)
    Me.btnabrir.Text = "Abrir"
    '
    'btnExcel
    '
    Me.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnExcel.Image = My.Resources.Resources.docexcel
    Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnExcel.Name = "btnExcel"
    Me.btnExcel.Size = New System.Drawing.Size(24, 23)
    Me.btnExcel.Text = "Exportar a Excel"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
    '
    'btngrabar
    '
    Me.btngrabar.Image = My.Resources.Resources.save
    Me.btngrabar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btngrabar.Name = "btngrabar"
    Me.btngrabar.Size = New System.Drawing.Size(135, 23)
    Me.btngrabar.Text = "Grabar Nómina"
    '
    'btneliminar
    '
    Me.btneliminar.Image = My.Resources.Resources.eliminar
    Me.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(144, 23)
    Me.btneliminar.Text = "Eliminar Nómina"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
    '
    'PagarLiquidacion
    '
    Me.PagarLiquidacion.CheckOnClick = True
    Me.PagarLiquidacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.PagarLiquidacion.Image = CType(resources.GetObject("PagarLiquidacion.Image"), System.Drawing.Image)
    Me.PagarLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.PagarLiquidacion.Name = "PagarLiquidacion"
    Me.PagarLiquidacion.Size = New System.Drawing.Size(127, 23)
    Me.PagarLiquidacion.Text = "Pagar en Nómina"
    Me.PagarLiquidacion.ToolTipText = "Pagadero en Liquidación"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 26)
    '
    'btnNoMensualizar
    '
    Me.btnNoMensualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnNoMensualizar.Image = CType(resources.GetObject("btnNoMensualizar.Image"), System.Drawing.Image)
    Me.btnNoMensualizar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnNoMensualizar.Name = "btnNoMensualizar"
    Me.btnNoMensualizar.Size = New System.Drawing.Size(116, 23)
    Me.btnNoMensualizar.Text = "No mensualizar"
    '
    'StatusStrip1
    '
    Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtIngresos, Me.ToolStripStatusLabel3, Me.txtEgresos, Me.ToolStripStatusLabel5, Me.txtTotal})
    Me.StatusStrip1.Location = New System.Drawing.Point(8, 736)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(815, 25)
    Me.StatusStrip1.TabIndex = 6
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'ToolStripStatusLabel1
    '
    Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
    Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(67, 20)
    Me.ToolStripStatusLabel1.Text = "Ingresos:"
    '
    'txtIngresos
    '
    Me.txtIngresos.Name = "txtIngresos"
    Me.txtIngresos.Size = New System.Drawing.Size(17, 20)
    Me.txtIngresos.Text = "0"
    '
    'ToolStripStatusLabel3
    '
    Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
    Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(63, 20)
    Me.ToolStripStatusLabel3.Text = "Egresos:"
    '
    'txtEgresos
    '
    Me.txtEgresos.Name = "txtEgresos"
    Me.txtEgresos.Size = New System.Drawing.Size(17, 20)
    Me.txtEgresos.Text = "0"
    '
    'ToolStripStatusLabel5
    '
    Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
    Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(45, 20)
    Me.ToolStripStatusLabel5.Text = "Total:"
    '
    'txtTotal
    '
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Size = New System.Drawing.Size(17, 20)
    Me.txtTotal.Text = "0"
    '
    'CtlBuscaEmpleadosPeriodo1
    '
    Me.CtlBuscaEmpleadosPeriodo1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleadosPeriodo1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleadosPeriodo1.Location = New System.Drawing.Point(4, 5)
    Me.CtlBuscaEmpleadosPeriodo1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.CtlBuscaEmpleadosPeriodo1.Name = "CtlBuscaEmpleadosPeriodo1"
    Me.CtlBuscaEmpleadosPeriodo1.Op = Nothing
    Me.CtlBuscaEmpleadosPeriodo1.Size = New System.Drawing.Size(262, 761)
    Me.CtlBuscaEmpleadosPeriodo1.TabIndex = 0
    Me.CtlBuscaEmpleadosPeriodo1.Usuario = Nothing
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
    Me.HeaderStrip1.Size = New System.Drawing.Size(1101, 32)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(90, 29)
    Me.ToolStripLabel1.Text = "Nómina"
    '
    'DataGridViewTextBoxColumn84
    '
    Me.DataGridViewTextBoxColumn84.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
    '
    'DataGridViewTextBoxColumn83
    '
    Me.DataGridViewTextBoxColumn83.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
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
    'DataGridViewTextBoxColumn80
    '
    Me.DataGridViewTextBoxColumn80.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
    '
    'DataGridViewTextBoxColumn79
    '
    Me.DataGridViewTextBoxColumn79.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
    '
    'DataGridViewTextBoxColumn78
    '
    Me.DataGridViewTextBoxColumn78.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
    '
    'DataGridViewTextBoxColumn77
    '
    Me.DataGridViewTextBoxColumn77.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
    '
    'DataGridViewTextBoxColumn76
    '
    Me.DataGridViewTextBoxColumn76.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
    '
    'DataGridViewTextBoxColumn75
    '
    Me.DataGridViewTextBoxColumn75.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
    '
    'DataGridViewTextBoxColumn74
    '
    Me.DataGridViewTextBoxColumn74.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
    '
    'DataGridViewTextBoxColumn73
    '
    Me.DataGridViewTextBoxColumn73.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
    '
    'DataGridViewTextBoxColumn72
    '
    Me.DataGridViewTextBoxColumn72.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
    '
    'DataGridViewTextBoxColumn71
    '
    Me.DataGridViewTextBoxColumn71.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
    '
    'DataGridViewTextBoxColumn70
    '
    Me.DataGridViewTextBoxColumn70.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
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
    'DataGridViewTextBoxColumn67
    '
    Me.DataGridViewTextBoxColumn67.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
    '
    'DataGridViewTextBoxColumn66
    '
    Me.DataGridViewTextBoxColumn66.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
    '
    'DataGridViewTextBoxColumn65
    '
    Me.DataGridViewTextBoxColumn65.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
    '
    'DataGridViewTextBoxColumn64
    '
    Me.DataGridViewTextBoxColumn64.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
    '
    'DataGridViewTextBoxColumn63
    '
    Me.DataGridViewTextBoxColumn63.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
    '
    'DataGridViewTextBoxColumn62
    '
    Me.DataGridViewTextBoxColumn62.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
    '
    'DataGridViewTextBoxColumn61
    '
    Me.DataGridViewTextBoxColumn61.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
    '
    'DataGridViewTextBoxColumn60
    '
    Me.DataGridViewTextBoxColumn60.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
    '
    'DataGridViewTextBoxColumn59
    '
    Me.DataGridViewTextBoxColumn59.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
    '
    'DataGridViewTextBoxColumn58
    '
    Me.DataGridViewTextBoxColumn58.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
    '
    'DataGridViewTextBoxColumn57
    '
    Me.DataGridViewTextBoxColumn57.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
    '
    'DataGridViewTextBoxColumn56
    '
    Me.DataGridViewTextBoxColumn56.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
    '
    'DataGridViewTextBoxColumn55
    '
    Me.DataGridViewTextBoxColumn55.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
    '
    'DataGridViewTextBoxColumn54
    '
    Me.DataGridViewTextBoxColumn54.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
    '
    'DataGridViewTextBoxColumn53
    '
    Me.DataGridViewTextBoxColumn53.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
    '
    'DataGridViewTextBoxColumn52
    '
    Me.DataGridViewTextBoxColumn52.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
    '
    'DataGridViewTextBoxColumn51
    '
    Me.DataGridViewTextBoxColumn51.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
    '
    'DataGridViewTextBoxColumn50
    '
    Me.DataGridViewTextBoxColumn50.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
    '
    'DataGridViewTextBoxColumn49
    '
    Me.DataGridViewTextBoxColumn49.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
    '
    'DataGridViewTextBoxColumn48
    '
    Me.DataGridViewTextBoxColumn48.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
    '
    'DataGridViewTextBoxColumn47
    '
    Me.DataGridViewTextBoxColumn47.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
    '
    'DataGridViewTextBoxColumn46
    '
    Me.DataGridViewTextBoxColumn46.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
    '
    'DataGridViewTextBoxColumn45
    '
    Me.DataGridViewTextBoxColumn45.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
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
    'DataGridViewTextBoxColumn42
    '
    Me.DataGridViewTextBoxColumn42.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
    '
    'DataGridViewTextBoxColumn41
    '
    Me.DataGridViewTextBoxColumn41.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
    '
    'DataGridViewTextBoxColumn40
    '
    Me.DataGridViewTextBoxColumn40.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
    '
    'DataGridViewTextBoxColumn39
    '
    Me.DataGridViewTextBoxColumn39.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
    '
    'DataGridViewTextBoxColumn38
    '
    Me.DataGridViewTextBoxColumn38.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
    '
    'DataGridViewTextBoxColumn37
    '
    Me.DataGridViewTextBoxColumn37.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
    '
    'DataGridViewTextBoxColumn36
    '
    Me.DataGridViewTextBoxColumn36.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
    '
    'DataGridViewTextBoxColumn35
    '
    Me.DataGridViewTextBoxColumn35.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
    '
    'DataGridViewTextBoxColumn34
    '
    Me.DataGridViewTextBoxColumn34.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
    '
    'DataGridViewTextBoxColumn33
    '
    Me.DataGridViewTextBoxColumn33.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
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
    'DataGridViewTextBoxColumn30
    '
    Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
    '
    'DataGridViewTextBoxColumn29
    '
    Me.DataGridViewTextBoxColumn29.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
    '
    'DataGridViewTextBoxColumn28
    '
    Me.DataGridViewTextBoxColumn28.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
    '
    'DataGridViewTextBoxColumn27
    '
    Me.DataGridViewTextBoxColumn27.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
    '
    'DataGridViewTextBoxColumn26
    '
    Me.DataGridViewTextBoxColumn26.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
    '
    'DataGridViewTextBoxColumn25
    '
    Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
    '
    'DataGridViewTextBoxColumn24
    '
    Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
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
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    '
    'btnReporte
    '
    Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NominaToolStripMenuItem, Me.mnuSobreMensual, Me.ToolStripMenuItem2, Me.mnuPagoEfectivo, Me.mnuPagoCheque, Me.mnuPagoDeposito, Me.ToolStripSeparator3, Me.AsientoContableToolStripMenuItem})
    Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
    Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReporte.MergeIndex = 3
    Me.btnReporte.Name = "btnReporte"
    Me.btnReporte.Size = New System.Drawing.Size(102, 24)
    Me.btnReporte.Text = "Reportes"
    '
    'NominaToolStripMenuItem
    '
    Me.NominaToolStripMenuItem.Name = "NominaToolStripMenuItem"
    Me.NominaToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
    Me.NominaToolStripMenuItem.Text = "Sobres de pago Periodo"
    '
    'mnuSobreMensual
    '
    Me.mnuSobreMensual.Name = "mnuSobreMensual"
    Me.mnuSobreMensual.Size = New System.Drawing.Size(248, 26)
    Me.mnuSobreMensual.Text = "Sobres de pago Mensual"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(245, 6)
    '
    'mnuPagoEfectivo
    '
    Me.mnuPagoEfectivo.Name = "mnuPagoEfectivo"
    Me.mnuPagoEfectivo.Size = New System.Drawing.Size(248, 26)
    Me.mnuPagoEfectivo.Text = "Pago Efectivo"
    '
    'mnuPagoCheque
    '
    Me.mnuPagoCheque.Name = "mnuPagoCheque"
    Me.mnuPagoCheque.Size = New System.Drawing.Size(248, 26)
    Me.mnuPagoCheque.Text = "Pago Cheque"
    '
    'mnuPagoDeposito
    '
    Me.mnuPagoDeposito.Name = "mnuPagoDeposito"
    Me.mnuPagoDeposito.Size = New System.Drawing.Size(248, 26)
    Me.mnuPagoDeposito.Text = "Pago Deposito"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(245, 6)
    '
    'AsientoContableToolStripMenuItem
    '
    Me.AsientoContableToolStripMenuItem.Name = "AsientoContableToolStripMenuItem"
    Me.AsientoContableToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
    Me.AsientoContableToolStripMenuItem.Text = "Asiento Contable"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
    Me.MenuStrip1.Size = New System.Drawing.Size(1101, 33)
    Me.MenuStrip1.TabIndex = 2
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'FrmNomina
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1101, 865)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "FrmNomina"
    Me.Text = "FrmNomina"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSRubroDet, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaEmpleadosPeriodo1 As CtlBuscaEmpleadosPeriodo
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PprsecuencialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PprfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PprvalorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrsfecsolicitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrsfecaprobacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrsvalorsolicitadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrsvalorcuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrsaprobadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents PrsvaloraprobadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrsmotivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSRubroDet As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents DataGridView1 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnabrir As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btneliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btngrabar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents NominaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents PagarLiquidacion As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents mnuPagoEfectivo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents mnuPagoCheque As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents mnuPagoDeposito As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents mnuSobreMensual As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents AsientoContableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents txtIngresos As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents txtEgresos As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents txtTotal As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn83 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnNoMensualizar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn84 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn85 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn86 As DataGridViewTextBoxColumn
End Class
