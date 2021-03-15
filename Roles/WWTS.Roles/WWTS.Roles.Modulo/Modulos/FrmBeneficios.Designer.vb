Imports WWTS.General.Controles

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBeneficios
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
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabControl2 = New System.Windows.Forms.TabControl()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.tbtipobenacum = New System.Windows.Forms.TabControl()
    Me.tbd3 = New System.Windows.Forms.TabPage()
    Me.lvd3 = New System.Windows.Forms.ListView()
    Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.tbd4 = New System.Windows.Forms.TabPage()
    Me.lvd4 = New System.Windows.Forms.ListView()
    Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.tbvac = New System.Windows.Forms.TabPage()
    Me.lvvac = New System.Windows.Forms.ListView()
    Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.txtdiasvac = New Infoware.Controles.Base.TextBoxCalculator()
    Me.dtfecvacdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.tbuti = New System.Windows.Forms.TabPage()
    Me.lvUti = New System.Windows.Forms.ListView()
    Me.coluti1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.coluti10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.txtutibonocargas = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtutibono = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtUti = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.btnCalcular = New System.Windows.Forms.Button()
    Me.Panel10 = New System.Windows.Forms.Panel()
    Me.btnRecibosVac = New System.Windows.Forms.Button()
    Me.btnRecibosBono = New System.Windows.Forms.Button()
    Me.btngrabarbenacum = New System.Windows.Forms.Button()
    Me.btnexportarbenac = New System.Windows.Forms.Button()
    Me.btngenpagos = New System.Windows.Forms.Button()
    Me.Panel6 = New System.Windows.Forms.Panel()
    Me.pnlperiodohasta = New System.Windows.Forms.Panel()
    Me.numaniohasta = New System.Windows.Forms.NumericUpDown()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.cbomeshasta = New System.Windows.Forms.ComboBox()
    Me.pnlperiododesde = New System.Windows.Forms.Panel()
    Me.cbomesdesde = New System.Windows.Forms.ComboBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.numaniodesde = New System.Windows.Forms.NumericUpDown()
    Me.btnconsbenacum = New System.Windows.Forms.Button()
    Me.rdobennopag = New System.Windows.Forms.RadioButton()
    Me.rdorangoper = New System.Windows.Forms.RadioButton()
    Me.rdocortadoa = New System.Windows.Forms.RadioButton()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TabControl4 = New System.Windows.Forms.TabControl()
    Me.TabPage8 = New System.Windows.Forms.TabPage()
    Me.dgdetliq = New System.Windows.Forms.DataGridView()
    Me.ContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PatronCodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EsNuevoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.LiquidValorCalcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LiquiddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LiquidSecuenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LiquidValorPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.OperadorDatosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EntidaCodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ContraSecuenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EsModificadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.LiquidacionListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.chkfiniq = New System.Windows.Forms.CheckBox()
    Me.lvfiniq = New System.Windows.Forms.ListView()
    Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.dtfecliq = New System.Windows.Forms.DateTimePicker()
    Me.cbotipoliq = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.btnfiniquito = New System.Windows.Forms.Button()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.cbotiposalida = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfeccheque = New System.Windows.Forms.DateTimePicker()
    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.CtlCuentaBancaria1 = New WWTS.General.Controles.CtlCuentaBancaria()
    Me.btnlistafiniq = New System.Windows.Forms.Button()
    Me.btnpagofiniq = New System.Windows.Forms.Button()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.CtlBuscaEmpleados1 = New WWTS.Roles.Modulo.CtlBuscaEmpleados()
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.Pnlcuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabControl2.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.tbtipobenacum.SuspendLayout()
    Me.tbd3.SuspendLayout()
    Me.tbd4.SuspendLayout()
    Me.tbvac.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.tbuti.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel10.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.pnlperiodohasta.SuspendLayout()
    CType(Me.numaniohasta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlperiododesde.SuspendLayout()
    CType(Me.numaniodesde, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage3.SuspendLayout()
    Me.TabControl4.SuspendLayout()
    Me.TabPage8.SuspendLayout()
    CType(Me.dgdetliq, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LiquidacionListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel7.SuspendLayout()
    Me.Panel5.SuspendLayout()
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
    Me.Pnlcuerpo.Size = New System.Drawing.Size(716, 563)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(716, 538)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TabControl2)
    Me.TabPage1.Controls.Add(Me.CtlBuscaEmpleados1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(708, 512)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Listado/Pago de beneficios"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabControl2
    '
    Me.TabControl2.Controls.Add(Me.TabPage2)
    Me.TabControl2.Controls.Add(Me.TabPage3)
    Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl2.Location = New System.Drawing.Point(201, 3)
    Me.TabControl2.Name = "TabControl2"
    Me.TabControl2.SelectedIndex = 0
    Me.TabControl2.Size = New System.Drawing.Size(504, 506)
    Me.TabControl2.TabIndex = 1
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.tbtipobenacum)
    Me.TabPage2.Controls.Add(Me.Panel10)
    Me.TabPage2.Controls.Add(Me.Panel6)
    Me.TabPage2.Controls.Add(Me.Label5)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(496, 480)
    Me.TabPage2.TabIndex = 0
    Me.TabPage2.Text = "Beneficios acumulados"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'tbtipobenacum
    '
    Me.tbtipobenacum.Controls.Add(Me.tbd3)
    Me.tbtipobenacum.Controls.Add(Me.tbd4)
    Me.tbtipobenacum.Controls.Add(Me.tbvac)
    Me.tbtipobenacum.Controls.Add(Me.tbuti)
    Me.tbtipobenacum.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbtipobenacum.Location = New System.Drawing.Point(3, 96)
    Me.tbtipobenacum.Name = "tbtipobenacum"
    Me.tbtipobenacum.SelectedIndex = 0
    Me.tbtipobenacum.Size = New System.Drawing.Size(370, 381)
    Me.tbtipobenacum.TabIndex = 5
    '
    'tbd3
    '
    Me.tbd3.Controls.Add(Me.lvd3)
    Me.tbd3.Location = New System.Drawing.Point(4, 22)
    Me.tbd3.Name = "tbd3"
    Me.tbd3.Padding = New System.Windows.Forms.Padding(3)
    Me.tbd3.Size = New System.Drawing.Size(362, 355)
    Me.tbd3.TabIndex = 0
    Me.tbd3.Text = "Décimo tercero"
    Me.tbd3.UseVisualStyleBackColor = True
    '
    'lvd3
    '
    Me.lvd3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
    Me.lvd3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvd3.FullRowSelect = True
    Me.lvd3.HideSelection = False
    Me.lvd3.Location = New System.Drawing.Point(3, 3)
    Me.lvd3.MultiSelect = False
    Me.lvd3.Name = "lvd3"
    Me.lvd3.Size = New System.Drawing.Size(356, 349)
    Me.lvd3.TabIndex = 19
    Me.lvd3.UseCompatibleStateImageBehavior = False
    Me.lvd3.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader22
    '
    Me.ColumnHeader22.Text = "Código"
    Me.ColumnHeader22.Width = 70
    '
    'ColumnHeader23
    '
    Me.ColumnHeader23.Text = "Cédula"
    Me.ColumnHeader23.Width = 75
    '
    'ColumnHeader24
    '
    Me.ColumnHeader24.Text = "Empleado"
    Me.ColumnHeader24.Width = 190
    '
    'ColumnHeader25
    '
    Me.ColumnHeader25.Text = "Monto Recibido"
    Me.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader25.Width = 90
    '
    'ColumnHeader26
    '
    Me.ColumnHeader26.Text = "IESS "
    Me.ColumnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader26.Width = 70
    '
    'ColumnHeader27
    '
    Me.ColumnHeader27.Text = "Décimo"
    Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader27.Width = 70
    '
    'tbd4
    '
    Me.tbd4.Controls.Add(Me.lvd4)
    Me.tbd4.Location = New System.Drawing.Point(4, 22)
    Me.tbd4.Name = "tbd4"
    Me.tbd4.Padding = New System.Windows.Forms.Padding(3)
    Me.tbd4.Size = New System.Drawing.Size(362, 355)
    Me.tbd4.TabIndex = 1
    Me.tbd4.Text = "Décimo cuarto"
    Me.tbd4.UseVisualStyleBackColor = True
    '
    'lvd4
    '
    Me.lvd4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33})
    Me.lvd4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvd4.FullRowSelect = True
    Me.lvd4.HideSelection = False
    Me.lvd4.Location = New System.Drawing.Point(3, 3)
    Me.lvd4.MultiSelect = False
    Me.lvd4.Name = "lvd4"
    Me.lvd4.Size = New System.Drawing.Size(356, 349)
    Me.lvd4.TabIndex = 22
    Me.lvd4.UseCompatibleStateImageBehavior = False
    Me.lvd4.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader28
    '
    Me.ColumnHeader28.Text = "Código"
    Me.ColumnHeader28.Width = 70
    '
    'ColumnHeader29
    '
    Me.ColumnHeader29.Text = "Cédula"
    Me.ColumnHeader29.Width = 75
    '
    'ColumnHeader30
    '
    Me.ColumnHeader30.Text = "Empleado"
    Me.ColumnHeader30.Width = 190
    '
    'ColumnHeader31
    '
    Me.ColumnHeader31.Text = "Monto Recibido"
    Me.ColumnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader31.Width = 90
    '
    'ColumnHeader32
    '
    Me.ColumnHeader32.Text = "IESS "
    Me.ColumnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'ColumnHeader33
    '
    Me.ColumnHeader33.Text = "Décimo"
    Me.ColumnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'tbvac
    '
    Me.tbvac.Controls.Add(Me.lvvac)
    Me.tbvac.Controls.Add(Me.Panel3)
    Me.tbvac.Location = New System.Drawing.Point(4, 22)
    Me.tbvac.Name = "tbvac"
    Me.tbvac.Padding = New System.Windows.Forms.Padding(3)
    Me.tbvac.Size = New System.Drawing.Size(362, 355)
    Me.tbvac.TabIndex = 2
    Me.tbvac.Text = "Vacaciones"
    Me.tbvac.UseVisualStyleBackColor = True
    '
    'lvvac
    '
    Me.lvvac.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader39})
    Me.lvvac.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvvac.FullRowSelect = True
    Me.lvvac.HideSelection = False
    Me.lvvac.Location = New System.Drawing.Point(3, 65)
    Me.lvvac.MultiSelect = False
    Me.lvvac.Name = "lvvac"
    Me.lvvac.Size = New System.Drawing.Size(356, 287)
    Me.lvvac.TabIndex = 25
    Me.lvvac.UseCompatibleStateImageBehavior = False
    Me.lvvac.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader34
    '
    Me.ColumnHeader34.Text = "Código"
    Me.ColumnHeader34.Width = 70
    '
    'ColumnHeader35
    '
    Me.ColumnHeader35.Text = "Cédula"
    Me.ColumnHeader35.Width = 75
    '
    'ColumnHeader36
    '
    Me.ColumnHeader36.Text = "Empleado"
    Me.ColumnHeader36.Width = 180
    '
    'ColumnHeader37
    '
    Me.ColumnHeader37.Text = "Años Trabajados"
    Me.ColumnHeader37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader37.Width = 95
    '
    'ColumnHeader38
    '
    Me.ColumnHeader38.Text = "Dias "
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Fecha desde"
    Me.ColumnHeader1.Width = 110
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Fecha hasta"
    Me.ColumnHeader2.Width = 110
    '
    'ColumnHeader39
    '
    Me.ColumnHeader39.Text = "Valor de vacacion"
    Me.ColumnHeader39.Width = 110
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.txtdiasvac)
    Me.Panel3.Controls.Add(Me.dtfecvacdesde)
    Me.Panel3.Controls.Add(Me.Label9)
    Me.Panel3.Controls.Add(Me.Label7)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(3, 3)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(356, 62)
    Me.Panel3.TabIndex = 26
    '
    'txtdiasvac
    '
    Me.txtdiasvac.Location = New System.Drawing.Point(81, 32)
    Me.txtdiasvac.Mensaje = ""
    Me.txtdiasvac.Name = "txtdiasvac"
    Me.txtdiasvac.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdiasvac.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdiasvac.PromptText = ""
    Me.txtdiasvac.Size = New System.Drawing.Size(33, 20)
    Me.txtdiasvac.TabIndex = 3
    Me.txtdiasvac.Text = "15"
    Me.txtdiasvac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdiasvac.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtdiasvac.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtdiasvac.Value = 15.0R
    '
    'dtfecvacdesde
    '
    Me.dtfecvacdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecvacdesde.Location = New System.Drawing.Point(81, 6)
    Me.dtfecvacdesde.Name = "dtfecvacdesde"
    Me.dtfecvacdesde.Size = New System.Drawing.Size(92, 20)
    Me.dtfecvacdesde.TabIndex = 2
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(3, 35)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(69, 13)
    Me.Label9.TabIndex = 1
    Me.Label9.Text = "Fecha hasta:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(3, 10)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 13)
    Me.Label7.TabIndex = 1
    Me.Label7.Text = "Fecha desde:"
    '
    'tbuti
    '
    Me.tbuti.Controls.Add(Me.lvUti)
    Me.tbuti.Controls.Add(Me.Panel2)
    Me.tbuti.Location = New System.Drawing.Point(4, 22)
    Me.tbuti.Name = "tbuti"
    Me.tbuti.Padding = New System.Windows.Forms.Padding(3)
    Me.tbuti.Size = New System.Drawing.Size(362, 355)
    Me.tbuti.TabIndex = 3
    Me.tbuti.Text = "Utilidades"
    Me.tbuti.UseVisualStyleBackColor = True
    '
    'lvUti
    '
    Me.lvUti.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.coluti1, Me.coluti2, Me.coluti3, Me.coluti4, Me.coluti5, Me.coluti6, Me.coluti7, Me.coluti8, Me.coluti9, Me.coluti10})
    Me.lvUti.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvUti.FullRowSelect = True
    Me.lvUti.HideSelection = False
    Me.lvUti.Location = New System.Drawing.Point(3, 67)
    Me.lvUti.MultiSelect = False
    Me.lvUti.Name = "lvUti"
    Me.lvUti.Size = New System.Drawing.Size(356, 285)
    Me.lvUti.TabIndex = 42
    Me.lvUti.UseCompatibleStateImageBehavior = False
    Me.lvUti.View = System.Windows.Forms.View.Details
    '
    'coluti1
    '
    Me.coluti1.Text = "Código"
    Me.coluti1.Width = 70
    '
    'coluti2
    '
    Me.coluti2.Text = "Cédula"
    Me.coluti2.Width = 75
    '
    'coluti3
    '
    Me.coluti3.Text = "Empleado"
    Me.coluti3.Width = 180
    '
    'coluti4
    '
    Me.coluti4.Text = "Días trabajados"
    '
    'coluti5
    '
    Me.coluti5.Text = "Año"
    Me.coluti5.Width = 50
    '
    'coluti6
    '
    Me.coluti6.Text = "Cargas"
    '
    'coluti7
    '
    Me.coluti7.Text = "Utilidad"
    Me.coluti7.Width = 80
    '
    'coluti8
    '
    Me.coluti8.Text = "Utilidad cargas"
    Me.coluti8.Width = 80
    '
    'coluti9
    '
    Me.coluti9.Text = "Bono"
    Me.coluti9.Width = 80
    '
    'coluti10
    '
    Me.coluti10.Text = "Bono cargas"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.txtutibonocargas)
    Me.Panel2.Controls.Add(Me.txtutibono)
    Me.Panel2.Controls.Add(Me.txtUti)
    Me.Panel2.Controls.Add(Me.Label6)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.btnCalcular)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(3, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(356, 64)
    Me.Panel2.TabIndex = 45
    '
    'txtutibonocargas
    '
    Me.txtutibonocargas.Location = New System.Drawing.Point(247, 37)
    Me.txtutibonocargas.Mensaje = ""
    Me.txtutibonocargas.Name = "txtutibonocargas"
    Me.txtutibonocargas.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtutibonocargas.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtutibonocargas.PromptText = ""
    Me.txtutibonocargas.Size = New System.Drawing.Size(63, 20)
    Me.txtutibonocargas.TabIndex = 5
    Me.txtutibonocargas.Text = "0,00"
    Me.txtutibonocargas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtutibonocargas.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtutibonocargas.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtutibonocargas.Value = 0.0R
    '
    'txtutibono
    '
    Me.txtutibono.Location = New System.Drawing.Point(90, 35)
    Me.txtutibono.Mensaje = ""
    Me.txtutibono.Name = "txtutibono"
    Me.txtutibono.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtutibono.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtutibono.PromptText = ""
    Me.txtutibono.Size = New System.Drawing.Size(63, 20)
    Me.txtutibono.TabIndex = 3
    Me.txtutibono.Text = "0,00"
    Me.txtutibono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtutibono.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtutibono.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtutibono.Value = 0.0R
    '
    'txtUti
    '
    Me.txtUti.Location = New System.Drawing.Point(111, 8)
    Me.txtUti.Mensaje = ""
    Me.txtUti.Name = "txtUti"
    Me.txtUti.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUti.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtUti.PromptText = ""
    Me.txtUti.Size = New System.Drawing.Size(100, 20)
    Me.txtUti.TabIndex = 1
    Me.txtUti.Text = "0,00"
    Me.txtUti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtUti.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtUti.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtUti.Value = 0.0R
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(161, 39)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(70, 13)
    Me.Label6.TabIndex = 4
    Me.Label6.Text = "Bono cargas:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(4, 37)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(80, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Bono adicional:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(4, 11)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(89, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Utilidad a repartir:"
    '
    'btnCalcular
    '
    Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnCalcular.Location = New System.Drawing.Point(247, 6)
    Me.btnCalcular.Name = "btnCalcular"
    Me.btnCalcular.Size = New System.Drawing.Size(100, 23)
    Me.btnCalcular.TabIndex = 6
    Me.btnCalcular.Text = "Calcular"
    '
    'Panel10
    '
    Me.Panel10.Controls.Add(Me.btnRecibosVac)
    Me.Panel10.Controls.Add(Me.btnRecibosBono)
    Me.Panel10.Controls.Add(Me.btngrabarbenacum)
    Me.Panel10.Controls.Add(Me.btnexportarbenac)
    Me.Panel10.Controls.Add(Me.btngenpagos)
    Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
    Me.Panel10.Location = New System.Drawing.Point(373, 96)
    Me.Panel10.Name = "Panel10"
    Me.Panel10.Size = New System.Drawing.Size(120, 381)
    Me.Panel10.TabIndex = 4
    '
    'btnRecibosVac
    '
    Me.btnRecibosVac.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnRecibosVac.Location = New System.Drawing.Point(6, 145)
    Me.btnRecibosVac.Name = "btnRecibosVac"
    Me.btnRecibosVac.Size = New System.Drawing.Size(111, 23)
    Me.btnRecibosVac.TabIndex = 3
    Me.btnRecibosVac.Text = "Recibos vacaciones"
    Me.btnRecibosVac.Visible = False
    '
    'btnRecibosBono
    '
    Me.btnRecibosBono.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnRecibosBono.Location = New System.Drawing.Point(6, 116)
    Me.btnRecibosBono.Name = "btnRecibosBono"
    Me.btnRecibosBono.Size = New System.Drawing.Size(111, 23)
    Me.btnRecibosBono.TabIndex = 3
    Me.btnRecibosBono.Text = "Recibos de bono"
    Me.btnRecibosBono.Visible = False
    '
    'btngrabarbenacum
    '
    Me.btngrabarbenacum.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btngrabarbenacum.Location = New System.Drawing.Point(6, 64)
    Me.btngrabarbenacum.Name = "btngrabarbenacum"
    Me.btngrabarbenacum.Size = New System.Drawing.Size(111, 23)
    Me.btngrabarbenacum.TabIndex = 2
    Me.btngrabarbenacum.Text = "Dar de baja"
    '
    'btnexportarbenac
    '
    Me.btnexportarbenac.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnexportarbenac.Location = New System.Drawing.Point(6, 35)
    Me.btnexportarbenac.Name = "btnexportarbenac"
    Me.btnexportarbenac.Size = New System.Drawing.Size(111, 23)
    Me.btnexportarbenac.TabIndex = 1
    Me.btnexportarbenac.Text = "Exportar"
    '
    'btngenpagos
    '
    Me.btngenpagos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btngenpagos.Location = New System.Drawing.Point(6, 6)
    Me.btngenpagos.Name = "btngenpagos"
    Me.btngenpagos.Size = New System.Drawing.Size(111, 23)
    Me.btngenpagos.TabIndex = 0
    Me.btngenpagos.Text = "Generar pagos"
    '
    'Panel6
    '
    Me.Panel6.Controls.Add(Me.pnlperiodohasta)
    Me.Panel6.Controls.Add(Me.pnlperiododesde)
    Me.Panel6.Controls.Add(Me.btnconsbenacum)
    Me.Panel6.Controls.Add(Me.rdobennopag)
    Me.Panel6.Controls.Add(Me.rdorangoper)
    Me.Panel6.Controls.Add(Me.rdocortadoa)
    Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel6.Location = New System.Drawing.Point(3, 24)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(490, 72)
    Me.Panel6.TabIndex = 2
    '
    'pnlperiodohasta
    '
    Me.pnlperiodohasta.Controls.Add(Me.numaniohasta)
    Me.pnlperiodohasta.Controls.Add(Me.Label13)
    Me.pnlperiodohasta.Controls.Add(Me.cbomeshasta)
    Me.pnlperiodohasta.Location = New System.Drawing.Point(164, 40)
    Me.pnlperiodohasta.Name = "pnlperiodohasta"
    Me.pnlperiodohasta.Size = New System.Drawing.Size(204, 28)
    Me.pnlperiodohasta.TabIndex = 6
    '
    'numaniohasta
    '
    Me.numaniohasta.Location = New System.Drawing.Point(60, 4)
    Me.numaniohasta.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
    Me.numaniohasta.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
    Me.numaniohasta.Name = "numaniohasta"
    Me.numaniohasta.Size = New System.Drawing.Size(56, 20)
    Me.numaniohasta.TabIndex = 2
    Me.numaniohasta.Value = New Decimal(New Integer() {1900, 0, 0, 0})
    '
    'Label13
    '
    Me.Label13.Location = New System.Drawing.Point(4, 4)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(48, 20)
    Me.Label13.TabIndex = 4
    Me.Label13.Text = "Hasta:"
    Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cbomeshasta
    '
    Me.cbomeshasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomeshasta.Location = New System.Drawing.Point(120, 4)
    Me.cbomeshasta.Name = "cbomeshasta"
    Me.cbomeshasta.Size = New System.Drawing.Size(80, 21)
    Me.cbomeshasta.TabIndex = 3
    '
    'pnlperiododesde
    '
    Me.pnlperiododesde.Controls.Add(Me.cbomesdesde)
    Me.pnlperiododesde.Controls.Add(Me.Label8)
    Me.pnlperiododesde.Controls.Add(Me.numaniodesde)
    Me.pnlperiododesde.Location = New System.Drawing.Point(164, 12)
    Me.pnlperiododesde.Name = "pnlperiododesde"
    Me.pnlperiododesde.Size = New System.Drawing.Size(204, 28)
    Me.pnlperiododesde.TabIndex = 5
    '
    'cbomesdesde
    '
    Me.cbomesdesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomesdesde.Location = New System.Drawing.Point(120, 4)
    Me.cbomesdesde.Name = "cbomesdesde"
    Me.cbomesdesde.Size = New System.Drawing.Size(80, 21)
    Me.cbomesdesde.TabIndex = 3
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(4, 4)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(48, 20)
    Me.Label8.TabIndex = 4
    Me.Label8.Text = "Desde:"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'numaniodesde
    '
    Me.numaniodesde.Location = New System.Drawing.Point(60, 4)
    Me.numaniodesde.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
    Me.numaniodesde.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
    Me.numaniodesde.Name = "numaniodesde"
    Me.numaniodesde.Size = New System.Drawing.Size(56, 20)
    Me.numaniodesde.TabIndex = 2
    Me.numaniodesde.Value = New Decimal(New Integer() {2000, 0, 0, 0})
    '
    'btnconsbenacum
    '
    Me.btnconsbenacum.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnconsbenacum.Location = New System.Drawing.Point(380, 8)
    Me.btnconsbenacum.Name = "btnconsbenacum"
    Me.btnconsbenacum.Size = New System.Drawing.Size(75, 23)
    Me.btnconsbenacum.TabIndex = 1
    Me.btnconsbenacum.Text = "&Consultar"
    '
    'rdobennopag
    '
    Me.rdobennopag.AutoSize = True
    Me.rdobennopag.Checked = True
    Me.rdobennopag.Location = New System.Drawing.Point(7, 3)
    Me.rdobennopag.Name = "rdobennopag"
    Me.rdobennopag.Size = New System.Drawing.Size(133, 17)
    Me.rdobennopag.TabIndex = 0
    Me.rdobennopag.TabStop = True
    Me.rdobennopag.Text = "Beneficios no pagados"
    '
    'rdorangoper
    '
    Me.rdorangoper.AutoSize = True
    Me.rdorangoper.Location = New System.Drawing.Point(7, 26)
    Me.rdorangoper.Name = "rdorangoper"
    Me.rdorangoper.Size = New System.Drawing.Size(115, 17)
    Me.rdorangoper.TabIndex = 0
    Me.rdorangoper.Text = "Rango de periodos"
    '
    'rdocortadoa
    '
    Me.rdocortadoa.AutoSize = True
    Me.rdocortadoa.Location = New System.Drawing.Point(7, 49)
    Me.rdocortadoa.Name = "rdocortadoa"
    Me.rdocortadoa.Size = New System.Drawing.Size(140, 17)
    Me.rdocortadoa.TabIndex = 0
    Me.rdocortadoa.Text = "Cortado hasta el periodo"
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.SystemColors.Info
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label5.Location = New System.Drawing.Point(3, 3)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(490, 21)
    Me.Label5.TabIndex = 41
    Me.Label5.Text = "Seleccione con un visto los registros que desee que aparezcan en el reporte"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.TabControl4)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(496, 480)
    Me.TabPage3.TabIndex = 1
    Me.TabPage3.Text = "Otros beneficios"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'TabControl4
    '
    Me.TabControl4.Controls.Add(Me.TabPage8)
    Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl4.Location = New System.Drawing.Point(3, 3)
    Me.TabControl4.Name = "TabControl4"
    Me.TabControl4.SelectedIndex = 0
    Me.TabControl4.Size = New System.Drawing.Size(490, 474)
    Me.TabControl4.TabIndex = 0
    '
    'TabPage8
    '
    Me.TabPage8.Controls.Add(Me.dgdetliq)
    Me.TabPage8.Controls.Add(Me.chkfiniq)
    Me.TabPage8.Controls.Add(Me.lvfiniq)
    Me.TabPage8.Controls.Add(Me.Panel7)
    Me.TabPage8.Controls.Add(Me.Panel5)
    Me.TabPage8.Controls.Add(Me.Label11)
    Me.TabPage8.Location = New System.Drawing.Point(4, 22)
    Me.TabPage8.Name = "TabPage8"
    Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage8.Size = New System.Drawing.Size(482, 448)
    Me.TabPage8.TabIndex = 1
    Me.TabPage8.Text = "Actas de finiquito"
    Me.TabPage8.UseVisualStyleBackColor = True
    '
    'dgdetliq
    '
    Me.dgdetliq.AllowUserToAddRows = False
    Me.dgdetliq.AllowUserToDeleteRows = False
    Me.dgdetliq.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdetliq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgdetliq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContratoDataGridViewTextBoxColumn, Me.PatronCodigoDataGridViewTextBoxColumn, Me.EsNuevoDataGridViewCheckBoxColumn, Me.LiquidValorCalcDataGridViewTextBoxColumn, Me.LiquiddescripcionDataGridViewTextBoxColumn, Me.LiquidSecuenciaDataGridViewTextBoxColumn, Me.LiquidValorPagadoDataGridViewTextBoxColumn, Me.OperadorDatosDataGridViewTextBoxColumn, Me.EntidaCodigoDataGridViewTextBoxColumn, Me.ContraSecuenciaDataGridViewTextBoxColumn, Me.EsModificadoDataGridViewCheckBoxColumn})
    Me.dgdetliq.DataSource = Me.LiquidacionListBindingSource
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdetliq.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgdetliq.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.dgdetliq.Location = New System.Drawing.Point(3, 262)
    Me.dgdetliq.Name = "dgdetliq"
    Me.dgdetliq.RowTemplate.Height = 25
    Me.dgdetliq.Size = New System.Drawing.Size(344, 183)
    Me.dgdetliq.TabIndex = 32
    '
    'ContratoDataGridViewTextBoxColumn
    '
    Me.ContratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato"
    Me.ContratoDataGridViewTextBoxColumn.HeaderText = "Contrato"
    Me.ContratoDataGridViewTextBoxColumn.Name = "ContratoDataGridViewTextBoxColumn"
    '
    'PatronCodigoDataGridViewTextBoxColumn
    '
    Me.PatronCodigoDataGridViewTextBoxColumn.DataPropertyName = "Patron_Codigo"
    Me.PatronCodigoDataGridViewTextBoxColumn.HeaderText = "Patron_Codigo"
    Me.PatronCodigoDataGridViewTextBoxColumn.Name = "PatronCodigoDataGridViewTextBoxColumn"
    '
    'EsNuevoDataGridViewCheckBoxColumn
    '
    Me.EsNuevoDataGridViewCheckBoxColumn.DataPropertyName = "EsNuevo"
    Me.EsNuevoDataGridViewCheckBoxColumn.HeaderText = "EsNuevo"
    Me.EsNuevoDataGridViewCheckBoxColumn.Name = "EsNuevoDataGridViewCheckBoxColumn"
    '
    'LiquidValorCalcDataGridViewTextBoxColumn
    '
    Me.LiquidValorCalcDataGridViewTextBoxColumn.DataPropertyName = "Liquid_ValorCalc"
    Me.LiquidValorCalcDataGridViewTextBoxColumn.HeaderText = "Liquid_ValorCalc"
    Me.LiquidValorCalcDataGridViewTextBoxColumn.Name = "LiquidValorCalcDataGridViewTextBoxColumn"
    '
    'LiquiddescripcionDataGridViewTextBoxColumn
    '
    Me.LiquiddescripcionDataGridViewTextBoxColumn.DataPropertyName = "Liquid_descripcion"
    Me.LiquiddescripcionDataGridViewTextBoxColumn.HeaderText = "Liquid_descripcion"
    Me.LiquiddescripcionDataGridViewTextBoxColumn.Name = "LiquiddescripcionDataGridViewTextBoxColumn"
    '
    'LiquidSecuenciaDataGridViewTextBoxColumn
    '
    Me.LiquidSecuenciaDataGridViewTextBoxColumn.DataPropertyName = "Liquid_Secuencia"
    Me.LiquidSecuenciaDataGridViewTextBoxColumn.HeaderText = "Liquid_Secuencia"
    Me.LiquidSecuenciaDataGridViewTextBoxColumn.Name = "LiquidSecuenciaDataGridViewTextBoxColumn"
    '
    'LiquidValorPagadoDataGridViewTextBoxColumn
    '
    Me.LiquidValorPagadoDataGridViewTextBoxColumn.DataPropertyName = "Liquid_ValorPagado"
    Me.LiquidValorPagadoDataGridViewTextBoxColumn.HeaderText = "Liquid_ValorPagado"
    Me.LiquidValorPagadoDataGridViewTextBoxColumn.Name = "LiquidValorPagadoDataGridViewTextBoxColumn"
    '
    'OperadorDatosDataGridViewTextBoxColumn
    '
    Me.OperadorDatosDataGridViewTextBoxColumn.DataPropertyName = "OperadorDatos"
    Me.OperadorDatosDataGridViewTextBoxColumn.HeaderText = "OperadorDatos"
    Me.OperadorDatosDataGridViewTextBoxColumn.Name = "OperadorDatosDataGridViewTextBoxColumn"
    '
    'EntidaCodigoDataGridViewTextBoxColumn
    '
    Me.EntidaCodigoDataGridViewTextBoxColumn.DataPropertyName = "Entida_Codigo"
    Me.EntidaCodigoDataGridViewTextBoxColumn.HeaderText = "Entida_Codigo"
    Me.EntidaCodigoDataGridViewTextBoxColumn.Name = "EntidaCodigoDataGridViewTextBoxColumn"
    '
    'ContraSecuenciaDataGridViewTextBoxColumn
    '
    Me.ContraSecuenciaDataGridViewTextBoxColumn.DataPropertyName = "Contra_Secuencia"
    Me.ContraSecuenciaDataGridViewTextBoxColumn.HeaderText = "Contra_Secuencia"
    Me.ContraSecuenciaDataGridViewTextBoxColumn.Name = "ContraSecuenciaDataGridViewTextBoxColumn"
    '
    'EsModificadoDataGridViewCheckBoxColumn
    '
    Me.EsModificadoDataGridViewCheckBoxColumn.DataPropertyName = "EsModificado"
    Me.EsModificadoDataGridViewCheckBoxColumn.HeaderText = "EsModificado"
    Me.EsModificadoDataGridViewCheckBoxColumn.Name = "EsModificadoDataGridViewCheckBoxColumn"
    '
    'LiquidacionListBindingSource
    '
    Me.LiquidacionListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.LiquidacionList)
    '
    'chkfiniq
    '
    Me.chkfiniq.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkfiniq.Location = New System.Drawing.Point(7, 134)
    Me.chkfiniq.Name = "chkfiniq"
    Me.chkfiniq.Size = New System.Drawing.Size(12, 14)
    Me.chkfiniq.TabIndex = 31
    '
    'lvfiniq
    '
    Me.lvfiniq.CheckBoxes = True
    Me.lvfiniq.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
    Me.lvfiniq.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvfiniq.FullRowSelect = True
    Me.lvfiniq.HideSelection = False
    Me.lvfiniq.Location = New System.Drawing.Point(3, 125)
    Me.lvfiniq.MultiSelect = False
    Me.lvfiniq.Name = "lvfiniq"
    Me.lvfiniq.Size = New System.Drawing.Size(344, 320)
    Me.lvfiniq.TabIndex = 28
    Me.lvfiniq.UseCompatibleStateImageBehavior = False
    Me.lvfiniq.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader19
    '
    Me.ColumnHeader19.Text = "     Código"
    Me.ColumnHeader19.Width = 70
    '
    'ColumnHeader20
    '
    Me.ColumnHeader20.Text = "Cédula"
    Me.ColumnHeader20.Width = 75
    '
    'ColumnHeader21
    '
    Me.ColumnHeader21.Text = "Empleado"
    Me.ColumnHeader21.Width = 190
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.dtfecliq)
    Me.Panel7.Controls.Add(Me.cbotipoliq)
    Me.Panel7.Controls.Add(Me.Label12)
    Me.Panel7.Controls.Add(Me.btnfiniquito)
    Me.Panel7.Controls.Add(Me.Label10)
    Me.Panel7.Controls.Add(Me.cbotiposalida)
    Me.Panel7.Controls.Add(Me.Label1)
    Me.Panel7.Controls.Add(Me.Label2)
    Me.Panel7.Controls.Add(Me.dtfeccheque)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(3, 24)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(344, 101)
    Me.Panel7.TabIndex = 29
    '
    'dtfecliq
    '
    Me.dtfecliq.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecliq.Location = New System.Drawing.Point(108, 32)
    Me.dtfecliq.Name = "dtfecliq"
    Me.dtfecliq.Size = New System.Drawing.Size(100, 20)
    Me.dtfecliq.TabIndex = 4
    '
    'cbotipoliq
    '
    Me.cbotipoliq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipoliq.Location = New System.Drawing.Point(108, 4)
    Me.cbotipoliq.Name = "cbotipoliq"
    Me.cbotipoliq.OperadorDatos = Nothing
    Me.cbotipoliq.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipoliq.ParametroDet = Nothing
    Me.cbotipoliq.PuedeActualizar = True
    Me.cbotipoliq.PuedeEliminar = True
    Me.cbotipoliq.PuedeModificar = True
    Me.cbotipoliq.PuedeNuevo = True
    Me.cbotipoliq.Size = New System.Drawing.Size(136, 21)
    Me.cbotipoliq.TabIndex = 1
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(8, 8)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(96, 18)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "Liquidado:"
    '
    'btnfiniquito
    '
    Me.btnfiniquito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnfiniquito.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnfiniquito.Location = New System.Drawing.Point(263, 4)
    Me.btnfiniquito.Name = "btnfiniquito"
    Me.btnfiniquito.Size = New System.Drawing.Size(75, 23)
    Me.btnfiniquito.TabIndex = 2
    Me.btnfiniquito.Text = "Consultar"
    '
    'Label10
    '
    Me.Label10.Location = New System.Drawing.Point(8, 32)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(96, 18)
    Me.Label10.TabIndex = 3
    Me.Label10.Text = "Fecha liquidación:"
    '
    'cbotiposalida
    '
    Me.cbotiposalida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbotiposalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotiposalida.Location = New System.Drawing.Point(108, 80)
    Me.cbotiposalida.Name = "cbotiposalida"
    Me.cbotiposalida.OperadorDatos = Nothing
    Me.cbotiposalida.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotiposalida.ParametroDet = Nothing
    Me.cbotiposalida.PuedeActualizar = True
    Me.cbotiposalida.PuedeEliminar = True
    Me.cbotiposalida.PuedeModificar = True
    Me.cbotiposalida.PuedeNuevo = True
    Me.cbotiposalida.Size = New System.Drawing.Size(231, 21)
    Me.cbotiposalida.TabIndex = 8
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(8, 80)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(96, 18)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Motivo de salida:"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(8, 56)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(96, 18)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Fecha cheque:"
    '
    'dtfeccheque
    '
    Me.dtfeccheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfeccheque.Location = New System.Drawing.Point(108, 56)
    Me.dtfeccheque.Name = "dtfeccheque"
    Me.dtfeccheque.Size = New System.Drawing.Size(100, 20)
    Me.dtfeccheque.TabIndex = 6
    '
    'Panel5
    '
    Me.Panel5.Controls.Add(Me.CtlCuentaBancaria1)
    Me.Panel5.Controls.Add(Me.btnlistafiniq)
    Me.Panel5.Controls.Add(Me.btnpagofiniq)
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
    Me.Panel5.Location = New System.Drawing.Point(347, 24)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(132, 421)
    Me.Panel5.TabIndex = 27
    '
    'CtlCuentaBancaria1
    '
    Me.CtlCuentaBancaria1.CuentaBancaria = Nothing
    Me.CtlCuentaBancaria1.Location = New System.Drawing.Point(6, 113)
    Me.CtlCuentaBancaria1.Name = "CtlCuentaBancaria1"
    Me.CtlCuentaBancaria1.Size = New System.Drawing.Size(121, 132)
    Me.CtlCuentaBancaria1.TabIndex = 1
    '
    'btnlistafiniq
    '
    Me.btnlistafiniq.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlistafiniq.Location = New System.Drawing.Point(16, 16)
    Me.btnlistafiniq.Name = "btnlistafiniq"
    Me.btnlistafiniq.Size = New System.Drawing.Size(100, 23)
    Me.btnlistafiniq.TabIndex = 0
    Me.btnlistafiniq.Text = "Imprimir finiquito"
    '
    'btnpagofiniq
    '
    Me.btnpagofiniq.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnpagofiniq.Location = New System.Drawing.Point(16, 48)
    Me.btnpagofiniq.Name = "btnpagofiniq"
    Me.btnpagofiniq.Size = New System.Drawing.Size(100, 23)
    Me.btnpagofiniq.TabIndex = 0
    Me.btnpagofiniq.Text = "Generar pagos"
    '
    'Label11
    '
    Me.Label11.BackColor = System.Drawing.SystemColors.Info
    Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label11.Location = New System.Drawing.Point(3, 3)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(476, 21)
    Me.Label11.TabIndex = 26
    Me.Label11.Text = "Seleccione con un visto los registros que desee que aparezcan en el reporte"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CtlBuscaEmpleados1
    '
    Me.CtlBuscaEmpleados1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleados1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleados1.Empleado = Nothing
    Me.CtlBuscaEmpleados1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaEmpleados1.Name = "CtlBuscaEmpleados1"
    Me.CtlBuscaEmpleados1.Op = Nothing
    Me.CtlBuscaEmpleados1.Size = New System.Drawing.Size(198, 506)
    Me.CtlBuscaEmpleados1.TabIndex = 0
    Me.CtlBuscaEmpleados1.Usuario = Nothing
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(716, 25)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(157, 22)
    Me.ToolStripLabel1.Text = "Beneficios sociales"
    '
    'FrmBeneficios
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(716, 563)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Name = "FrmBeneficios"
    Me.Text = "FrmBeneficios"
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabControl2.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.tbtipobenacum.ResumeLayout(False)
    Me.tbd3.ResumeLayout(False)
    Me.tbd4.ResumeLayout(False)
    Me.tbvac.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.tbuti.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel10.ResumeLayout(False)
    Me.Panel6.ResumeLayout(False)
    Me.Panel6.PerformLayout()
    Me.pnlperiodohasta.ResumeLayout(False)
    CType(Me.numaniohasta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlperiododesde.ResumeLayout(False)
    CType(Me.numaniodesde, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage3.ResumeLayout(False)
    Me.TabControl4.ResumeLayout(False)
    Me.TabPage8.ResumeLayout(False)
    CType(Me.dgdetliq, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LiquidacionListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel7.ResumeLayout(False)
    Me.Panel5.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents pnlperiodohasta As System.Windows.Forms.Panel
  Friend WithEvents numaniohasta As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents cbomeshasta As System.Windows.Forms.ComboBox
  Friend WithEvents pnlperiododesde As System.Windows.Forms.Panel
  Friend WithEvents cbomesdesde As System.Windows.Forms.ComboBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents numaniodesde As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnconsbenacum As System.Windows.Forms.Button
  Friend WithEvents rdobennopag As System.Windows.Forms.RadioButton
  Friend WithEvents rdorangoper As System.Windows.Forms.RadioButton
  Friend WithEvents rdocortadoa As System.Windows.Forms.RadioButton
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaEmpleados1 As CtlBuscaEmpleados
  Friend WithEvents tbtipobenacum As System.Windows.Forms.TabControl
  Friend WithEvents tbd3 As System.Windows.Forms.TabPage
  Friend WithEvents lvd3 As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
  Friend WithEvents tbd4 As System.Windows.Forms.TabPage
  Friend WithEvents lvd4 As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
  Friend WithEvents tbvac As System.Windows.Forms.TabPage
  Friend WithEvents lvvac As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Panel10 As System.Windows.Forms.Panel
  Friend WithEvents btngrabarbenacum As System.Windows.Forms.Button
  Friend WithEvents btnexportarbenac As System.Windows.Forms.Button
  Friend WithEvents btngenpagos As System.Windows.Forms.Button
  Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
  Friend WithEvents lvfiniq As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents dtfecliq As System.Windows.Forms.DateTimePicker
  Friend WithEvents cbotipoliq As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents cbotiposalida As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfeccheque As System.Windows.Forms.DateTimePicker
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents btnlistafiniq As System.Windows.Forms.Button
  Friend WithEvents btnpagofiniq As System.Windows.Forms.Button
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents CtlCuentaBancaria1 As CtlCuentaBancaria
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents chkfiniq As System.Windows.Forms.CheckBox
  Friend WithEvents dgdetliq As System.Windows.Forms.DataGridView
  Friend WithEvents LiquidacionListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents tbuti As System.Windows.Forms.TabPage
  Friend WithEvents lvUti As System.Windows.Forms.ListView
  Friend WithEvents coluti1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti5 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti6 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti7 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents btnCalcular As System.Windows.Forms.Button
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtutibono As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtUti As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnfiniquito As System.Windows.Forms.Button
  Friend WithEvents coluti9 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti8 As System.Windows.Forms.ColumnHeader
  Friend WithEvents coluti10 As System.Windows.Forms.ColumnHeader
  Friend WithEvents btnRecibosBono As System.Windows.Forms.Button
  Friend WithEvents txtutibonocargas As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents btnRecibosVac As System.Windows.Forms.Button
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents dtfecvacdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtdiasvac As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents LiqdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqvalorcalcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqvalorpagarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PatronCodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EsNuevoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents LiquidValorCalcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiquiddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiquidSecuenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiquidValorPagadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents OperadorDatosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EntidaCodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ContraSecuenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EsModificadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
