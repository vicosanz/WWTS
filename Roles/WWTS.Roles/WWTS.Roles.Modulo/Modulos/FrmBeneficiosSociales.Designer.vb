Imports WWTS.General.Controles

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBeneficiosSociales
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBeneficiosSociales))
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabControl2 = New System.Windows.Forms.TabControl()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.HeaderStrip3 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnExcel = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.btncerrar = New System.Windows.Forms.ToolStripButton()
    Me.tbtipobenacum = New System.Windows.Forms.TabControl()
    Me.tbd3g = New System.Windows.Forms.TabPage()
    Me.DataGridViewD3 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsD3 = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.tbd4g = New System.Windows.Forms.TabPage()
    Me.DataGridViewD4 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsD4 = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.tbvacg = New System.Windows.Forms.TabPage()
    Me.DataGridViewVaca = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsVacacion = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.tbutig = New System.Windows.Forms.TabPage()
    Me.DataGridViewUti = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsUtilidad = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.CtlPatronoCombo1 = New WWTS.Roles.Modulo.CtlPatronoCombo()
    Me.txtUtiBonoCargas = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtUtiBono = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtMinimoUtilidad = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtUti = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.btncalcularuti = New Infoware.Controles.Base.ButtonStd()
    Me.tbotros = New System.Windows.Forms.TabPage()
    Me.DataGridViewOtros = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsOtrosPagos = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.ComboBoxOtrosPagos = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.TextBoxCalculator6 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btncalcularotros = New Infoware.Controles.Base.ButtonStd()
    Me.Panel6 = New System.Windows.Forms.Panel()
    Me.pnlrangoperiodos = New System.Windows.Forms.Panel()
    Me.rdocortadoa = New System.Windows.Forms.RadioButton()
    Me.rdorangoper = New System.Windows.Forms.RadioButton()
    Me.rdobennopag = New System.Windows.Forms.RadioButton()
    Me.pnlperiododesde = New System.Windows.Forms.Panel()
    Me.dtFechadesde = New System.Windows.Forms.DateTimePicker()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.pnlperiodohasta = New System.Windows.Forms.Panel()
    Me.dtFechahasta = New System.Windows.Forms.DateTimePicker()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.btnconsbenacum = New Infoware.Controles.Base.ButtonStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.CtlBuscaEmpleados1 = New WWTS.Roles.Modulo.CtlBuscaEmpleados()
    Me.TabPage5 = New System.Windows.Forms.TabPage()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.DataGridViewVacaDetalle = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsperiodovacacion = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnLiquidarVacaciones = New System.Windows.Forms.ToolStripButton()
    Me.btnimprimirvacacion = New System.Windows.Forms.ToolStripButton()
    Me.CtlPeriodoVacacion1 = New WWTS.Roles.Modulo.CtlPeriodoVacacion()
    Me.CtlBuscaEmpleados2 = New WWTS.Roles.Modulo.CtlBuscaEmpleados()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
    Me.BeneficioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RecibosLiquidaciónVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.PersonalAdicionalParaUtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.BSBeneficiosxLote = New System.Windows.Forms.BindingSource(Me.components)
    Me.bslote = New System.Windows.Forms.BindingSource(Me.components)
    Me.LiquidacionListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabControl2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.HeaderStrip3.SuspendLayout()
    Me.tbtipobenacum.SuspendLayout()
    Me.tbd3g.SuspendLayout()
    CType(Me.DataGridViewD3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsD3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbd4g.SuspendLayout()
    CType(Me.DataGridViewD4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsD4, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbvacg.SuspendLayout()
    CType(Me.DataGridViewVaca, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsVacacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbutig.SuspendLayout()
    CType(Me.DataGridViewUti, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsUtilidad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.tbotros.SuspendLayout()
    CType(Me.DataGridViewOtros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsOtrosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.pnlrangoperiodos.SuspendLayout()
    Me.pnlperiododesde.SuspendLayout()
    Me.pnlperiodohasta.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.Panel5.SuspendLayout()
    CType(Me.DataGridViewVacaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsperiodovacacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip2.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    CType(Me.BSBeneficiosxLote, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bslote, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LiquidacionListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.TabControl1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(4)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(1272, 693)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage5)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 32)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1272, 661)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TabControl2)
    Me.TabPage1.Location = New System.Drawing.Point(4, 25)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage1.Size = New System.Drawing.Size(1264, 632)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Listado/Pago de beneficios"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabControl2
    '
    Me.TabControl2.Controls.Add(Me.TabPage3)
    Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl2.Location = New System.Drawing.Point(4, 4)
    Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
    Me.TabControl2.Name = "TabControl2"
    Me.TabControl2.SelectedIndex = 0
    Me.TabControl2.Size = New System.Drawing.Size(1256, 624)
    Me.TabControl2.TabIndex = 1
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.Panel2)
    Me.TabPage3.Controls.Add(Me.CtlBuscaEmpleados1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 25)
    Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage3.Size = New System.Drawing.Size(1248, 595)
    Me.TabPage3.TabIndex = 3
    Me.TabPage3.Text = "Beneficios no pagados"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.tbtipobenacum)
    Me.Panel2.Controls.Add(Me.HeaderStrip3)
    Me.Panel2.Controls.Add(Me.Panel6)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(252, 4)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
    Me.Panel2.Size = New System.Drawing.Size(992, 587)
    Me.Panel2.TabIndex = 46
    '
    'HeaderStrip3
    '
    Me.HeaderStrip3.AutoSize = False
    Me.HeaderStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip3.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip3.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.btnExcel, Me.ToolStripSeparator3, Me.btncerrar})
    Me.HeaderStrip3.Location = New System.Drawing.Point(4, 115)
    Me.HeaderStrip3.Name = "HeaderStrip3"
    Me.HeaderStrip3.Size = New System.Drawing.Size(988, 26)
    Me.HeaderStrip3.TabIndex = 46
    Me.HeaderStrip3.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(57, 23)
    Me.ToolStripLabel2.Text = "Detalle"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
    '
    'btnExcel
    '
    Me.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnExcel.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.docexcel
    Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnExcel.Name = "btnExcel"
    Me.btnExcel.Size = New System.Drawing.Size(23, 23)
    Me.btnExcel.Text = "Exportar a Excel"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
    '
    'btncerrar
    '
    Me.btncerrar.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.save16
    Me.btncerrar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncerrar.Name = "btncerrar"
    Me.btncerrar.Size = New System.Drawing.Size(285, 23)
    Me.btncerrar.Text = "Marcar como pagado y Generar pagos"
    '
    'tbtipobenacum
    '
    Me.tbtipobenacum.Controls.Add(Me.tbd3g)
    Me.tbtipobenacum.Controls.Add(Me.tbd4g)
    Me.tbtipobenacum.Controls.Add(Me.tbvacg)
    Me.tbtipobenacum.Controls.Add(Me.tbutig)
    Me.tbtipobenacum.Controls.Add(Me.tbotros)
    Me.tbtipobenacum.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbtipobenacum.Location = New System.Drawing.Point(4, 141)
    Me.tbtipobenacum.Margin = New System.Windows.Forms.Padding(4)
    Me.tbtipobenacum.Name = "tbtipobenacum"
    Me.tbtipobenacum.SelectedIndex = 0
    Me.tbtipobenacum.Size = New System.Drawing.Size(988, 446)
    Me.tbtipobenacum.TabIndex = 45
    '
    'tbd3g
    '
    Me.tbd3g.Controls.Add(Me.DataGridViewD3)
    Me.tbd3g.Location = New System.Drawing.Point(4, 25)
    Me.tbd3g.Margin = New System.Windows.Forms.Padding(4)
    Me.tbd3g.Name = "tbd3g"
    Me.tbd3g.Padding = New System.Windows.Forms.Padding(4)
    Me.tbd3g.Size = New System.Drawing.Size(980, 417)
    Me.tbd3g.TabIndex = 4
    Me.tbd3g.Text = "Décimo tercero"
    Me.tbd3g.UseVisualStyleBackColor = True
    '
    'DataGridViewD3
    '
    Me.DataGridViewD3.AgruparRepetidos = False
    Me.DataGridViewD3.AllowUserToAddRows = False
    Me.DataGridViewD3.AutoGenerateColumns = False
    Me.DataGridViewD3.BackgroundColor = System.Drawing.SystemColors.HighlightText
    Me.DataGridViewD3.BorderStyle = System.Windows.Forms.BorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewD3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridViewD3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn67})
    Me.DataGridViewD3.DataSource = Me.bsD3
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewD3.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridViewD3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewD3.Location = New System.Drawing.Point(4, 4)
    Me.DataGridViewD3.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridViewD3.Name = "DataGridViewD3"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewD3.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridViewD3.RowHeadersVisible = False
    Me.DataGridViewD3.Size = New System.Drawing.Size(972, 409)
    Me.DataGridViewD3.TabIndex = 0
    '
    'DataGridViewTextBoxColumn61
    '
    Me.DataGridViewTextBoxColumn61.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
    '
    'DataGridViewTextBoxColumn67
    '
    Me.DataGridViewTextBoxColumn67.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
    '
    'tbd4g
    '
    Me.tbd4g.Controls.Add(Me.DataGridViewD4)
    Me.tbd4g.Location = New System.Drawing.Point(4, 25)
    Me.tbd4g.Margin = New System.Windows.Forms.Padding(4)
    Me.tbd4g.Name = "tbd4g"
    Me.tbd4g.Padding = New System.Windows.Forms.Padding(4)
    Me.tbd4g.Size = New System.Drawing.Size(980, 417)
    Me.tbd4g.TabIndex = 5
    Me.tbd4g.Text = "Décimo cuarto"
    Me.tbd4g.UseVisualStyleBackColor = True
    '
    'DataGridViewD4
    '
    Me.DataGridViewD4.AgruparRepetidos = False
    Me.DataGridViewD4.AllowUserToAddRows = False
    Me.DataGridViewD4.AutoGenerateColumns = False
    Me.DataGridViewD4.BackgroundColor = System.Drawing.SystemColors.HighlightText
    Me.DataGridViewD4.BorderStyle = System.Windows.Forms.BorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewD4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.DataGridViewD4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewD4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn68})
    Me.DataGridViewD4.DataSource = Me.bsD4
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewD4.DefaultCellStyle = DataGridViewCellStyle5
    Me.DataGridViewD4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewD4.Location = New System.Drawing.Point(4, 4)
    Me.DataGridViewD4.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridViewD4.Name = "DataGridViewD4"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewD4.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.DataGridViewD4.RowHeadersVisible = False
    Me.DataGridViewD4.Size = New System.Drawing.Size(972, 409)
    Me.DataGridViewD4.TabIndex = 1
    '
    'DataGridViewTextBoxColumn62
    '
    Me.DataGridViewTextBoxColumn62.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
    '
    'DataGridViewTextBoxColumn68
    '
    Me.DataGridViewTextBoxColumn68.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
    '
    'tbvacg
    '
    Me.tbvacg.Controls.Add(Me.DataGridViewVaca)
    Me.tbvacg.Location = New System.Drawing.Point(4, 25)
    Me.tbvacg.Margin = New System.Windows.Forms.Padding(4)
    Me.tbvacg.Name = "tbvacg"
    Me.tbvacg.Padding = New System.Windows.Forms.Padding(4)
    Me.tbvacg.Size = New System.Drawing.Size(980, 417)
    Me.tbvacg.TabIndex = 6
    Me.tbvacg.Text = "Vacaciones"
    Me.tbvacg.UseVisualStyleBackColor = True
    '
    'DataGridViewVaca
    '
    Me.DataGridViewVaca.AgruparRepetidos = False
    Me.DataGridViewVaca.AllowUserToAddRows = False
    Me.DataGridViewVaca.AutoGenerateColumns = False
    Me.DataGridViewVaca.BackgroundColor = System.Drawing.SystemColors.HighlightText
    Me.DataGridViewVaca.BorderStyle = System.Windows.Forms.BorderStyle.None
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewVaca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.DataGridViewVaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn69})
    Me.DataGridViewVaca.DataSource = Me.bsVacacion
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewVaca.DefaultCellStyle = DataGridViewCellStyle8
    Me.DataGridViewVaca.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewVaca.Location = New System.Drawing.Point(4, 4)
    Me.DataGridViewVaca.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridViewVaca.Name = "DataGridViewVaca"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewVaca.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
    Me.DataGridViewVaca.RowHeadersVisible = False
    Me.DataGridViewVaca.Size = New System.Drawing.Size(972, 409)
    Me.DataGridViewVaca.TabIndex = 2
    '
    'DataGridViewTextBoxColumn63
    '
    Me.DataGridViewTextBoxColumn63.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
    '
    'DataGridViewTextBoxColumn69
    '
    Me.DataGridViewTextBoxColumn69.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
    '
    'tbutig
    '
    Me.tbutig.Controls.Add(Me.DataGridViewUti)
    Me.tbutig.Controls.Add(Me.Panel1)
    Me.tbutig.Location = New System.Drawing.Point(4, 25)
    Me.tbutig.Margin = New System.Windows.Forms.Padding(4)
    Me.tbutig.Name = "tbutig"
    Me.tbutig.Padding = New System.Windows.Forms.Padding(4)
    Me.tbutig.Size = New System.Drawing.Size(980, 417)
    Me.tbutig.TabIndex = 7
    Me.tbutig.Text = "Utilidades"
    Me.tbutig.UseVisualStyleBackColor = True
    '
    'DataGridViewUti
    '
    Me.DataGridViewUti.AgruparRepetidos = False
    Me.DataGridViewUti.AllowUserToAddRows = False
    Me.DataGridViewUti.AutoGenerateColumns = False
    Me.DataGridViewUti.BackgroundColor = System.Drawing.SystemColors.HighlightText
    Me.DataGridViewUti.BorderStyle = System.Windows.Forms.BorderStyle.None
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewUti.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
    Me.DataGridViewUti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn70})
    Me.DataGridViewUti.DataSource = Me.bsUtilidad
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewUti.DefaultCellStyle = DataGridViewCellStyle11
    Me.DataGridViewUti.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewUti.Location = New System.Drawing.Point(4, 185)
    Me.DataGridViewUti.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridViewUti.Name = "DataGridViewUti"
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewUti.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
    Me.DataGridViewUti.RowHeadersVisible = False
    Me.DataGridViewUti.Size = New System.Drawing.Size(972, 228)
    Me.DataGridViewUti.TabIndex = 48
    '
    'DataGridViewTextBoxColumn64
    '
    Me.DataGridViewTextBoxColumn64.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
    '
    'DataGridViewTextBoxColumn70
    '
    Me.DataGridViewTextBoxColumn70.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlPatronoCombo1)
    Me.Panel1.Controls.Add(Me.txtUtiBonoCargas)
    Me.Panel1.Controls.Add(Me.txtUtiBono)
    Me.Panel1.Controls.Add(Me.txtMinimoUtilidad)
    Me.Panel1.Controls.Add(Me.txtUti)
    Me.Panel1.Controls.Add(Me.Label14)
    Me.Panel1.Controls.Add(Me.Label15)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label16)
    Me.Panel1.Controls.Add(Me.btncalcularuti)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(4, 4)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(972, 181)
    Me.Panel1.TabIndex = 47
    '
    'CtlPatronoCombo1
    '
    Me.CtlPatronoCombo1.AbriralEntrar = False
    Me.CtlPatronoCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlPatronoCombo1.FormattingEnabled = True
    Me.CtlPatronoCombo1.Location = New System.Drawing.Point(156, 15)
    Me.CtlPatronoCombo1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlPatronoCombo1.Name = "CtlPatronoCombo1"
    Me.CtlPatronoCombo1.Op = Nothing
    Me.CtlPatronoCombo1.Patrono = Nothing
    Me.CtlPatronoCombo1.PuedeActualizar = True
    Me.CtlPatronoCombo1.PuedeEliminar = True
    Me.CtlPatronoCombo1.PuedeModificar = True
    Me.CtlPatronoCombo1.PuedeNuevo = True
    Me.CtlPatronoCombo1.Size = New System.Drawing.Size(217, 24)
    Me.CtlPatronoCombo1.TabIndex = 1
    Me.CtlPatronoCombo1.Usuario = Nothing
    '
    'txtUtiBonoCargas
    '
    Me.txtUtiBonoCargas.Location = New System.Drawing.Point(156, 112)
    Me.txtUtiBonoCargas.Margin = New System.Windows.Forms.Padding(4)
    Me.txtUtiBonoCargas.Mensaje = ""
    Me.txtUtiBonoCargas.Name = "txtUtiBonoCargas"
    Me.txtUtiBonoCargas.NumeroDecimales = 6
    Me.txtUtiBonoCargas.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUtiBonoCargas.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtUtiBonoCargas.PromptText = ""
    Me.txtUtiBonoCargas.Size = New System.Drawing.Size(125, 22)
    Me.txtUtiBonoCargas.TabIndex = 7
    Me.txtUtiBonoCargas.Text = "0,000000"
    Me.txtUtiBonoCargas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtUtiBonoCargas.Value = 0.0R
    '
    'txtUtiBono
    '
    Me.txtUtiBono.Location = New System.Drawing.Point(156, 80)
    Me.txtUtiBono.Margin = New System.Windows.Forms.Padding(4)
    Me.txtUtiBono.Mensaje = ""
    Me.txtUtiBono.Name = "txtUtiBono"
    Me.txtUtiBono.NumeroDecimales = 6
    Me.txtUtiBono.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUtiBono.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtUtiBono.PromptText = ""
    Me.txtUtiBono.Size = New System.Drawing.Size(125, 22)
    Me.txtUtiBono.TabIndex = 5
    Me.txtUtiBono.Text = "0,000000"
    Me.txtUtiBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtUtiBono.Value = 0.0R
    '
    'txtMinimoUtilidad
    '
    Me.txtMinimoUtilidad.Location = New System.Drawing.Point(156, 144)
    Me.txtMinimoUtilidad.Margin = New System.Windows.Forms.Padding(4)
    Me.txtMinimoUtilidad.Mensaje = ""
    Me.txtMinimoUtilidad.Name = "txtMinimoUtilidad"
    Me.txtMinimoUtilidad.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMinimoUtilidad.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtMinimoUtilidad.PromptText = ""
    Me.txtMinimoUtilidad.Size = New System.Drawing.Size(125, 22)
    Me.txtMinimoUtilidad.TabIndex = 9
    Me.txtMinimoUtilidad.Text = "0,00"
    Me.txtMinimoUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtMinimoUtilidad.Value = 0.0R
    '
    'txtUti
    '
    Me.txtUti.Location = New System.Drawing.Point(156, 48)
    Me.txtUti.Margin = New System.Windows.Forms.Padding(4)
    Me.txtUti.Mensaje = ""
    Me.txtUti.Name = "txtUti"
    Me.txtUti.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUti.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtUti.PromptText = ""
    Me.txtUti.Size = New System.Drawing.Size(125, 22)
    Me.txtUti.TabIndex = 3
    Me.txtUti.Text = "0,00"
    Me.txtUti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtUti.Value = 0.0R
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label14.Location = New System.Drawing.Point(4, 116)
    Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(136, 17)
    Me.Label14.TabIndex = 6
    Me.Label14.Text = "Factor Bono cargas:"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.Location = New System.Drawing.Point(4, 84)
    Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(149, 17)
    Me.Label15.TabIndex = 4
    Me.Label15.Text = "Factor Bono adicional:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(4, 148)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(56, 17)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Mínimo:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(4, 18)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(62, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Patrono:"
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.Location = New System.Drawing.Point(4, 52)
    Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(113, 17)
    Me.Label16.TabIndex = 2
    Me.Label16.Text = "Monto a repartir:"
    '
    'btncalcularuti
    '
    Me.btncalcularuti.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btncalcularuti.Location = New System.Drawing.Point(404, 145)
    Me.btncalcularuti.Margin = New System.Windows.Forms.Padding(4)
    Me.btncalcularuti.Name = "btncalcularuti"
    Me.btncalcularuti.Size = New System.Drawing.Size(160, 23)
    Me.btncalcularuti.TabIndex = 10
    Me.btncalcularuti.Text = "Calcular"
    '
    'tbotros
    '
    Me.tbotros.Controls.Add(Me.DataGridViewOtros)
    Me.tbotros.Controls.Add(Me.Panel3)
    Me.tbotros.Location = New System.Drawing.Point(4, 25)
    Me.tbotros.Margin = New System.Windows.Forms.Padding(4)
    Me.tbotros.Name = "tbotros"
    Me.tbotros.Padding = New System.Windows.Forms.Padding(4)
    Me.tbotros.Size = New System.Drawing.Size(980, 417)
    Me.tbotros.TabIndex = 8
    Me.tbotros.Text = "Otros Pagos"
    Me.tbotros.UseVisualStyleBackColor = True
    '
    'DataGridViewOtros
    '
    Me.DataGridViewOtros.AgruparRepetidos = False
    Me.DataGridViewOtros.AllowUserToAddRows = False
    Me.DataGridViewOtros.AutoGenerateColumns = False
    Me.DataGridViewOtros.BackgroundColor = System.Drawing.SystemColors.HighlightText
    Me.DataGridViewOtros.BorderStyle = System.Windows.Forms.BorderStyle.None
    DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewOtros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
    Me.DataGridViewOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn71})
    Me.DataGridViewOtros.DataSource = Me.bsOtrosPagos
    DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewOtros.DefaultCellStyle = DataGridViewCellStyle14
    Me.DataGridViewOtros.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewOtros.Location = New System.Drawing.Point(4, 82)
    Me.DataGridViewOtros.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridViewOtros.Name = "DataGridViewOtros"
    DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewOtros.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
    Me.DataGridViewOtros.RowHeadersVisible = False
    Me.DataGridViewOtros.Size = New System.Drawing.Size(972, 331)
    Me.DataGridViewOtros.TabIndex = 49
    '
    'DataGridViewTextBoxColumn65
    '
    Me.DataGridViewTextBoxColumn65.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
    '
    'DataGridViewTextBoxColumn71
    '
    Me.DataGridViewTextBoxColumn71.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.ComboBoxOtrosPagos)
    Me.Panel3.Controls.Add(Me.TextBoxCalculator6)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Controls.Add(Me.Label10)
    Me.Panel3.Controls.Add(Me.btncalcularotros)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(4, 4)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(972, 78)
    Me.Panel3.TabIndex = 48
    '
    'ComboBoxOtrosPagos
    '
    Me.ComboBoxOtrosPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxOtrosPagos.FormattingEnabled = True
    Me.ComboBoxOtrosPagos.Location = New System.Drawing.Point(93, 43)
    Me.ComboBoxOtrosPagos.Margin = New System.Windows.Forms.Padding(4)
    Me.ComboBoxOtrosPagos.Name = "ComboBoxOtrosPagos"
    Me.ComboBoxOtrosPagos.OperadorDatos = Nothing
    Me.ComboBoxOtrosPagos.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxOtrosPagos.ParametroDet = Nothing
    Me.ComboBoxOtrosPagos.PuedeActualizar = True
    Me.ComboBoxOtrosPagos.PuedeEliminar = True
    Me.ComboBoxOtrosPagos.PuedeModificar = True
    Me.ComboBoxOtrosPagos.PuedeNuevo = True
    Me.ComboBoxOtrosPagos.Size = New System.Drawing.Size(160, 24)
    Me.ComboBoxOtrosPagos.TabIndex = 3
    '
    'TextBoxCalculator6
    '
    Me.TextBoxCalculator6.Location = New System.Drawing.Point(93, 10)
    Me.TextBoxCalculator6.Margin = New System.Windows.Forms.Padding(4)
    Me.TextBoxCalculator6.Mensaje = ""
    Me.TextBoxCalculator6.Name = "TextBoxCalculator6"
    Me.TextBoxCalculator6.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxCalculator6.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBoxCalculator6.PromptText = ""
    Me.TextBoxCalculator6.Size = New System.Drawing.Size(132, 22)
    Me.TextBoxCalculator6.TabIndex = 1
    Me.TextBoxCalculator6.Text = "0,00"
    Me.TextBoxCalculator6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.TextBoxCalculator6.Value = 0.0R
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(5, 46)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(51, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Rubro:"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(5, 14)
    Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(45, 17)
    Me.Label10.TabIndex = 0
    Me.Label10.Text = "Valor:"
    '
    'btncalcularotros
    '
    Me.btncalcularotros.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btncalcularotros.Location = New System.Drawing.Point(329, 7)
    Me.btncalcularotros.Margin = New System.Windows.Forms.Padding(4)
    Me.btncalcularotros.Name = "btncalcularotros"
    Me.btncalcularotros.Size = New System.Drawing.Size(160, 23)
    Me.btncalcularotros.TabIndex = 4
    Me.btncalcularotros.Text = "Calcular"
    '
    'Panel6
    '
    Me.Panel6.Controls.Add(Me.pnlrangoperiodos)
    Me.Panel6.Controls.Add(Me.btnconsbenacum)
    Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel6.Location = New System.Drawing.Point(4, 26)
    Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(988, 89)
    Me.Panel6.TabIndex = 43
    '
    'pnlrangoperiodos
    '
    Me.pnlrangoperiodos.Controls.Add(Me.rdocortadoa)
    Me.pnlrangoperiodos.Controls.Add(Me.rdorangoper)
    Me.pnlrangoperiodos.Controls.Add(Me.rdobennopag)
    Me.pnlrangoperiodos.Controls.Add(Me.pnlperiododesde)
    Me.pnlrangoperiodos.Controls.Add(Me.pnlperiodohasta)
    Me.pnlrangoperiodos.Dock = System.Windows.Forms.DockStyle.Left
    Me.pnlrangoperiodos.Location = New System.Drawing.Point(0, 0)
    Me.pnlrangoperiodos.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlrangoperiodos.Name = "pnlrangoperiodos"
    Me.pnlrangoperiodos.Size = New System.Drawing.Size(599, 89)
    Me.pnlrangoperiodos.TabIndex = 7
    '
    'rdocortadoa
    '
    Me.rdocortadoa.AutoSize = True
    Me.rdocortadoa.Location = New System.Drawing.Point(9, 60)
    Me.rdocortadoa.Margin = New System.Windows.Forms.Padding(4)
    Me.rdocortadoa.Name = "rdocortadoa"
    Me.rdocortadoa.Size = New System.Drawing.Size(185, 21)
    Me.rdocortadoa.TabIndex = 0
    Me.rdocortadoa.Text = "Cortado hasta el periodo"
    '
    'rdorangoper
    '
    Me.rdorangoper.AutoSize = True
    Me.rdorangoper.Location = New System.Drawing.Point(9, 32)
    Me.rdorangoper.Margin = New System.Windows.Forms.Padding(4)
    Me.rdorangoper.Name = "rdorangoper"
    Me.rdorangoper.Size = New System.Drawing.Size(150, 21)
    Me.rdorangoper.TabIndex = 0
    Me.rdorangoper.Text = "Rango de periodos"
    '
    'rdobennopag
    '
    Me.rdobennopag.AutoSize = True
    Me.rdobennopag.Checked = True
    Me.rdobennopag.Location = New System.Drawing.Point(9, 4)
    Me.rdobennopag.Margin = New System.Windows.Forms.Padding(4)
    Me.rdobennopag.Name = "rdobennopag"
    Me.rdobennopag.Size = New System.Drawing.Size(173, 21)
    Me.rdobennopag.TabIndex = 0
    Me.rdobennopag.TabStop = True
    Me.rdobennopag.Text = "Beneficios no pagados"
    '
    'pnlperiododesde
    '
    Me.pnlperiododesde.Controls.Add(Me.dtFechadesde)
    Me.pnlperiododesde.Controls.Add(Me.Label8)
    Me.pnlperiododesde.Location = New System.Drawing.Point(280, 18)
    Me.pnlperiododesde.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlperiododesde.Name = "pnlperiododesde"
    Me.pnlperiododesde.Size = New System.Drawing.Size(272, 34)
    Me.pnlperiododesde.TabIndex = 5
    '
    'dtFechadesde
    '
    Me.dtFechadesde.CustomFormat = "yyyy MMMM"
    Me.dtFechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtFechadesde.Location = New System.Drawing.Point(77, 5)
    Me.dtFechadesde.Margin = New System.Windows.Forms.Padding(4)
    Me.dtFechadesde.Name = "dtFechadesde"
    Me.dtFechadesde.Size = New System.Drawing.Size(152, 22)
    Me.dtFechadesde.TabIndex = 7
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(5, 5)
    Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(64, 25)
    Me.Label8.TabIndex = 4
    Me.Label8.Text = "Desde:"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlperiodohasta
    '
    Me.pnlperiodohasta.Controls.Add(Me.dtFechahasta)
    Me.pnlperiodohasta.Controls.Add(Me.Label13)
    Me.pnlperiodohasta.Location = New System.Drawing.Point(280, 52)
    Me.pnlperiodohasta.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlperiodohasta.Name = "pnlperiodohasta"
    Me.pnlperiodohasta.Size = New System.Drawing.Size(272, 34)
    Me.pnlperiodohasta.TabIndex = 6
    '
    'dtFechahasta
    '
    Me.dtFechahasta.CustomFormat = "yyyy MMMM"
    Me.dtFechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtFechahasta.Location = New System.Drawing.Point(77, 5)
    Me.dtFechahasta.Margin = New System.Windows.Forms.Padding(4)
    Me.dtFechahasta.Name = "dtFechahasta"
    Me.dtFechahasta.Size = New System.Drawing.Size(152, 22)
    Me.dtFechahasta.TabIndex = 8
    '
    'Label13
    '
    Me.Label13.Location = New System.Drawing.Point(5, 5)
    Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(64, 25)
    Me.Label13.TabIndex = 4
    Me.Label13.Text = "Hasta:"
    Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'btnconsbenacum
    '
    Me.btnconsbenacum.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnconsbenacum.Location = New System.Drawing.Point(603, 4)
    Me.btnconsbenacum.Margin = New System.Windows.Forms.Padding(4)
    Me.btnconsbenacum.Name = "btnconsbenacum"
    Me.btnconsbenacum.Size = New System.Drawing.Size(160, 23)
    Me.btnconsbenacum.TabIndex = 1
    Me.btnconsbenacum.Text = "&Consultar"
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.SystemColors.Info
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label4.Location = New System.Drawing.Point(4, 0)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(988, 26)
    Me.Label4.TabIndex = 42
    Me.Label4.Text = "Seleccione con un visto los registros que desee que aparezcan en el reporte"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CtlBuscaEmpleados1
    '
    Me.CtlBuscaEmpleados1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleados1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleados1.Empleado = Nothing
    Me.CtlBuscaEmpleados1.Location = New System.Drawing.Point(4, 4)
    Me.CtlBuscaEmpleados1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlBuscaEmpleados1.Name = "CtlBuscaEmpleados1"
    Me.CtlBuscaEmpleados1.Op = Nothing
    Me.CtlBuscaEmpleados1.Size = New System.Drawing.Size(248, 587)
    Me.CtlBuscaEmpleados1.TabIndex = 47
    Me.CtlBuscaEmpleados1.Usuario = Nothing
    '
    'TabPage5
    '
    Me.TabPage5.Controls.Add(Me.Panel4)
    Me.TabPage5.Controls.Add(Me.CtlBuscaEmpleados2)
    Me.TabPage5.Location = New System.Drawing.Point(4, 25)
    Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage5.Size = New System.Drawing.Size(1264, 632)
    Me.TabPage5.TabIndex = 1
    Me.TabPage5.Text = "Vacaciones"
    Me.TabPage5.UseVisualStyleBackColor = True
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.Panel5)
    Me.Panel4.Controls.Add(Me.CtlPeriodoVacacion1)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel4.Location = New System.Drawing.Point(252, 4)
    Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
    Me.Panel4.Size = New System.Drawing.Size(1008, 624)
    Me.Panel4.TabIndex = 6
    '
    'Panel5
    '
    Me.Panel5.Controls.Add(Me.DataGridViewVacaDetalle)
    Me.Panel5.Controls.Add(Me.HeaderStrip2)
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel5.Location = New System.Drawing.Point(4, 222)
    Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Padding = New System.Windows.Forms.Padding(88, 0, 0, 0)
    Me.Panel5.Size = New System.Drawing.Size(1004, 402)
    Me.Panel5.TabIndex = 6
    '
    'DataGridViewVacaDetalle
    '
    Me.DataGridViewVacaDetalle.AgruparRepetidos = False
    Me.DataGridViewVacaDetalle.AllowUserToAddRows = False
    Me.DataGridViewVacaDetalle.AutoGenerateColumns = False
    DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewVacaDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
    Me.DataGridViewVacaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewVacaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn72})
    Me.DataGridViewVacaDetalle.DataSource = Me.bsperiodovacacion
    DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewVacaDetalle.DefaultCellStyle = DataGridViewCellStyle17
    Me.DataGridViewVacaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewVacaDetalle.Location = New System.Drawing.Point(88, 26)
    Me.DataGridViewVacaDetalle.Margin = New System.Windows.Forms.Padding(4)
    Me.DataGridViewVacaDetalle.Name = "DataGridViewVacaDetalle"
    DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewVacaDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
    Me.DataGridViewVacaDetalle.Size = New System.Drawing.Size(916, 376)
    Me.DataGridViewVacaDetalle.TabIndex = 3
    '
    'DataGridViewTextBoxColumn66
    '
    Me.DataGridViewTextBoxColumn66.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
    '
    'DataGridViewTextBoxColumn72
    '
    Me.DataGridViewTextBoxColumn72.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.ToolStripSeparator1, Me.btnLiquidarVacaciones, Me.btnimprimirvacacion})
    Me.HeaderStrip2.Location = New System.Drawing.Point(88, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(916, 26)
    Me.HeaderStrip2.TabIndex = 6
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel6
    '
    Me.ToolStripLabel6.Name = "ToolStripLabel6"
    Me.ToolStripLabel6.Size = New System.Drawing.Size(57, 23)
    Me.ToolStripLabel6.Text = "Detalle"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
    '
    'btnLiquidarVacaciones
    '
    Me.btnLiquidarVacaciones.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.save16
    Me.btnLiquidarVacaciones.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnLiquidarVacaciones.Name = "btnLiquidarVacaciones"
    Me.btnLiquidarVacaciones.Size = New System.Drawing.Size(146, 23)
    Me.btnLiquidarVacaciones.Text = "Liquidar Vacación"
    '
    'btnimprimirvacacion
    '
    Me.btnimprimirvacacion.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.print
    Me.btnimprimirvacacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimirvacacion.Name = "btnimprimirvacacion"
    Me.btnimprimirvacacion.Size = New System.Drawing.Size(145, 23)
    Me.btnimprimirvacacion.Text = "Reporte Vacación"
    '
    'CtlPeriodoVacacion1
    '
    Me.CtlPeriodoVacacion1.Contrato = Nothing
    Me.CtlPeriodoVacacion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlPeriodoVacacion1.Location = New System.Drawing.Point(4, 0)
    Me.CtlPeriodoVacacion1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlPeriodoVacacion1.Name = "CtlPeriodoVacacion1"
    Me.CtlPeriodoVacacion1.Size = New System.Drawing.Size(1004, 222)
    Me.CtlPeriodoVacacion1.TabIndex = 2
    '
    'CtlBuscaEmpleados2
    '
    Me.CtlBuscaEmpleados2.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleados2.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleados2.Empleado = Nothing
    Me.CtlBuscaEmpleados2.Location = New System.Drawing.Point(4, 4)
    Me.CtlBuscaEmpleados2.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlBuscaEmpleados2.Name = "CtlBuscaEmpleados2"
    Me.CtlBuscaEmpleados2.Op = Nothing
    Me.CtlBuscaEmpleados2.Size = New System.Drawing.Size(248, 624)
    Me.CtlBuscaEmpleados2.TabIndex = 48
    Me.CtlBuscaEmpleados2.Usuario = Nothing
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(1272, 32)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(208, 29)
    Me.ToolStripLabel1.Text = "Beneficios sociales"
    '
    'DataGridViewTextBoxColumn55
    '
    Me.DataGridViewTextBoxColumn55.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
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
    'DataGridViewTextBoxColumn60
    '
    Me.DataGridViewTextBoxColumn60.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
    '
    'DataGridViewTextBoxColumn49
    '
    Me.DataGridViewTextBoxColumn49.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
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
    'DataGridViewTextBoxColumn54
    '
    Me.DataGridViewTextBoxColumn54.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
    '
    'DataGridViewTextBoxColumn43
    '
    Me.DataGridViewTextBoxColumn43.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
    '
    'DataGridViewTextBoxColumn44
    '
    Me.DataGridViewTextBoxColumn44.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
    '
    'DataGridViewTextBoxColumn45
    '
    Me.DataGridViewTextBoxColumn45.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
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
    'DataGridViewTextBoxColumn48
    '
    Me.DataGridViewTextBoxColumn48.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
    '
    'DataGridViewTextBoxColumn37
    '
    Me.DataGridViewTextBoxColumn37.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
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
    'DataGridViewTextBoxColumn42
    '
    Me.DataGridViewTextBoxColumn42.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
    '
    'DataGridViewTextBoxColumn31
    '
    Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
    '
    'DataGridViewTextBoxColumn32
    '
    Me.DataGridViewTextBoxColumn32.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
    '
    'DataGridViewTextBoxColumn33
    '
    Me.DataGridViewTextBoxColumn33.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
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
    'DataGridViewTextBoxColumn36
    '
    Me.DataGridViewTextBoxColumn36.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
    '
    'DataGridViewTextBoxColumn25
    '
    Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
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
    'DataGridViewTextBoxColumn30
    '
    Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
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
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    '
    'DataGridViewTextBoxColumn24
    '
    Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
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
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
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
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 2, 0, 2)
    Me.MenuStrip1.Size = New System.Drawing.Size(1272, 31)
    Me.MenuStrip1.TabIndex = 2
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'btnReporte
    '
    Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeneficioToolStripMenuItem, Me.RecibosLiquidaciónVacacionesToolStripMenuItem, Me.ToolStripMenuItem1, Me.PersonalAdicionalParaUtilidadesToolStripMenuItem})
    Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
    Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReporte.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnReporte.MergeIndex = 5
    Me.btnReporte.Name = "btnReporte"
    Me.btnReporte.Size = New System.Drawing.Size(97, 24)
    Me.btnReporte.Text = "Reportes"
    '
    'BeneficioToolStripMenuItem
    '
    Me.BeneficioToolStripMenuItem.Name = "BeneficioToolStripMenuItem"
    Me.BeneficioToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
    Me.BeneficioToolStripMenuItem.Text = "Beneficios Sociales"
    '
    'RecibosLiquidaciónVacacionesToolStripMenuItem
    '
    Me.RecibosLiquidaciónVacacionesToolStripMenuItem.Name = "RecibosLiquidaciónVacacionesToolStripMenuItem"
    Me.RecibosLiquidaciónVacacionesToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
    Me.RecibosLiquidaciónVacacionesToolStripMenuItem.Text = "Recibos liquidación vacaciones"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(300, 6)
    '
    'PersonalAdicionalParaUtilidadesToolStripMenuItem
    '
    Me.PersonalAdicionalParaUtilidadesToolStripMenuItem.Name = "PersonalAdicionalParaUtilidadesToolStripMenuItem"
    Me.PersonalAdicionalParaUtilidadesToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
    Me.PersonalAdicionalParaUtilidadesToolStripMenuItem.Text = "Personal adicional para Utilidades"
    '
    'LiquidacionListBindingSource
    '
    Me.LiquidacionListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.LiquidacionList)
    '
    'FrmBeneficiosSociales
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1272, 693)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "FrmBeneficiosSociales"
    Me.Text = "Beneficios Sociales"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabControl2.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.HeaderStrip3.ResumeLayout(False)
    Me.HeaderStrip3.PerformLayout()
    Me.tbtipobenacum.ResumeLayout(False)
    Me.tbd3g.ResumeLayout(False)
    CType(Me.DataGridViewD3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsD3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbd4g.ResumeLayout(False)
    CType(Me.DataGridViewD4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsD4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbvacg.ResumeLayout(False)
    CType(Me.DataGridViewVaca, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsVacacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbutig.ResumeLayout(False)
    CType(Me.DataGridViewUti, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsUtilidad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.tbotros.ResumeLayout(False)
    CType(Me.DataGridViewOtros, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsOtrosPagos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.Panel6.ResumeLayout(False)
    Me.pnlrangoperiodos.ResumeLayout(False)
    Me.pnlrangoperiodos.PerformLayout()
    Me.pnlperiododesde.ResumeLayout(False)
    Me.pnlperiodohasta.ResumeLayout(False)
    Me.TabPage5.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.Panel5.ResumeLayout(False)
    CType(Me.DataGridViewVacaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsperiodovacacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    CType(Me.BSBeneficiosxLote, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bslote, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LiquidacionListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents LiquidacionListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents LiqdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqvalorcalcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqvalorpagarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsD3 As System.Windows.Forms.BindingSource
  Friend WithEvents bsD4 As System.Windows.Forms.BindingSource
  Friend WithEvents bsVacacion As System.Windows.Forms.BindingSource
  Friend WithEvents bsUtilidad As System.Windows.Forms.BindingSource
  Friend WithEvents bslote As System.Windows.Forms.BindingSource
  Friend WithEvents BSBeneficiosxLote As System.Windows.Forms.BindingSource
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents tbtipobenacum As System.Windows.Forms.TabControl
  Friend WithEvents tbd3g As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewD3 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents tbd4g As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewD4 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents tbvacg As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewVaca As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents tbutig As System.Windows.Forms.TabPage
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents pnlperiodohasta As System.Windows.Forms.Panel
  Friend WithEvents dtFechahasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents pnlperiododesde As System.Windows.Forms.Panel
  Friend WithEvents dtFechadesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents btnconsbenacum As Infoware.Controles.Base.ButtonStd
  Friend WithEvents rdobennopag As System.Windows.Forms.RadioButton
  Friend WithEvents rdorangoper As System.Windows.Forms.RadioButton
  Friend WithEvents rdocortadoa As System.Windows.Forms.RadioButton
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtUtiBonoCargas As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtUtiBono As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtUti As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents btncalcularuti As Infoware.Controles.Base.ButtonStd
  Friend WithEvents DataGridViewUti As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents CtlPeriodoVacacion1 As WWTS.Roles.Modulo.CtlPeriodoVacacion
  Friend WithEvents DataGridViewVacaDetalle As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents bsperiodovacacion As System.Windows.Forms.BindingSource
  Friend WithEvents tbotros As System.Windows.Forms.TabPage
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxOtrosPagos As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents TextBoxCalculator6 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents btncalcularotros As Infoware.Controles.Base.ButtonStd
  Friend WithEvents DataGridViewOtros As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents bsOtrosPagos As System.Windows.Forms.BindingSource
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnimprimirvacacion As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents BeneficioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CtlPatronoCombo1 As WWTS.Roles.Modulo.CtlPatronoCombo
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnLiquidarVacaciones As System.Windows.Forms.ToolStripButton
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
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents pnlrangoperiodos As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents RecibosLiquidaciónVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents PersonalAdicionalParaUtilidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CtlBuscaEmpleados1 As WWTS.Roles.Modulo.CtlBuscaEmpleados
  Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlBuscaEmpleados2 As WWTS.Roles.Modulo.CtlBuscaEmpleados
  Friend WithEvents txtMinimoUtilidad As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
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
  Friend WithEvents HeaderStrip3 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
  Friend WithEvents btncerrar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
