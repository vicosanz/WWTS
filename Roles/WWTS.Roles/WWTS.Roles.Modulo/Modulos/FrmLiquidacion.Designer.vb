Imports WWTS.General.Controles

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiquidacion
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidacion))
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.pnlConsulta = New System.Windows.Forms.Panel()
    Me.dtfechasalida = New System.Windows.Forms.DateTimePicker()
    Me.lblMensaje = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.dgdetliq = New System.Windows.Forms.DataGridView()
    Me.BSRubroDet = New System.Windows.Forms.BindingSource(Me.components)
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btncalcular = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.btncerrar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripDropDownButton()
    Me.ReporteLiquidacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MedioDeAprobacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
    Me.LiquidacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cbomotivosalida = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cbotipoliquidacion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.CtlBuscaEmpleados1 = New WWTS.Roles.Controles.CtlBuscaEmpleados()
    Me.ComboBoxLoteLiquidacion1 = New ComboBoxLoteLiquidacion()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.pnlConsulta.SuspendLayout()
    Me.Panel4.SuspendLayout()
    CType(Me.dgdetliq, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSRubroDet, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip2.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.Panel1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(4)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(1199, 693)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.TabControl1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 32)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1199, 661)
    Me.Panel1.TabIndex = 3
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1199, 661)
    Me.TabControl1.TabIndex = 1
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.Panel2)
    Me.TabPage1.Controls.Add(Me.CtlBuscaEmpleados1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 25)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage1.Size = New System.Drawing.Size(1191, 632)
    Me.TabPage1.TabIndex = 1
    Me.TabPage1.Text = "Actas de finiquito"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(268, 4)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
    Me.Panel2.Size = New System.Drawing.Size(919, 624)
    Me.Panel2.TabIndex = 33
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.pnlConsulta, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(915, 624)
    Me.TableLayoutPanel1.TabIndex = 33
    '
    'Panel3
    '
    Me.pnlConsulta.Controls.Add(Me.ComboBoxLoteLiquidacion1)
    Me.pnlConsulta.Controls.Add(Me.dtfechasalida)
    Me.pnlConsulta.Controls.Add(Me.lblMensaje)
    Me.pnlConsulta.Controls.Add(Me.Label5)
    Me.pnlConsulta.Controls.Add(Me.Label3)
    Me.pnlConsulta.Controls.Add(Me.Label2)
    Me.pnlConsulta.Controls.Add(Me.Label1)
    Me.pnlConsulta.Controls.Add(Me.cbomotivosalida)
    Me.pnlConsulta.Controls.Add(Me.cbotipoliquidacion)
    Me.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlConsulta.Location = New System.Drawing.Point(4, 4)
    Me.pnlConsulta.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlConsulta.Name = "Panel3"
    Me.pnlConsulta.Size = New System.Drawing.Size(907, 162)
    Me.pnlConsulta.TabIndex = 34
    '
    'dtfechasalida
    '
    Me.dtfechasalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasalida.Location = New System.Drawing.Point(153, 95)
    Me.dtfechasalida.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfechasalida.Name = "dtfechasalida"
    Me.dtfechasalida.Size = New System.Drawing.Size(155, 22)
    Me.dtfechasalida.TabIndex = 6
    '
    'Label4
    '
    Me.lblMensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblMensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.lblMensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblMensaje.Name = "Label4"
    Me.lblMensaje.Size = New System.Drawing.Size(907, 26)
    Me.lblMensaje.TabIndex = 0
    Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(4, 98)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(112, 17)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Fecha de salida:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(4, 66)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(114, 17)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Motivo de salida:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(4, 37)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(131, 17)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Tipo de liquidación:"
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.dgdetliq)
    Me.Panel4.Controls.Add(Me.HeaderStrip2)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel4.Location = New System.Drawing.Point(4, 174)
    Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(907, 446)
    Me.Panel4.TabIndex = 35
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
    Me.dgdetliq.DataSource = Me.BSRubroDet
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdetliq.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgdetliq.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgdetliq.Location = New System.Drawing.Point(0, 26)
    Me.dgdetliq.Margin = New System.Windows.Forms.Padding(4)
    Me.dgdetliq.Name = "dgdetliq"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdetliq.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgdetliq.RowTemplate.Height = 25
    Me.dgdetliq.Size = New System.Drawing.Size(907, 420)
    Me.dgdetliq.TabIndex = 32
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.ToolStripSeparator1, Me.btncalcular, Me.ToolStripSeparator2, Me.btncerrar, Me.ToolStripSplitButton1})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(907, 26)
    Me.HeaderStrip2.TabIndex = 34
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
    'btncalcular
    '
    Me.btncalcular.Image = CType(resources.GetObject("btncalcular.Image"), System.Drawing.Image)
    Me.btncalcular.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncalcular.Name = "btncalcular"
    Me.btncalcular.Size = New System.Drawing.Size(82, 23)
    Me.btncalcular.Text = "Calcular"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
    '
    'btncerrar
    '
    Me.btncerrar.Image = My.Resources.Resources.save
    Me.btncerrar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncerrar.Name = "btncerrar"
    Me.btncerrar.Size = New System.Drawing.Size(252, 23)
    Me.btncerrar.Text = "Cerrar liquidación y generar pago"
    '
    'ToolStripSplitButton1
    '
    Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteLiquidacionToolStripMenuItem, Me.MedioDeAprobacionToolStripMenuItem})
    Me.ToolStripSplitButton1.Image = My.Resources.Resources.print
    Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
    Me.ToolStripSplitButton1.Size = New System.Drawing.Size(97, 23)
    Me.ToolStripSplitButton1.Text = "Reportes"
    '
    'ReporteLiquidacionToolStripMenuItem
    '
    Me.ReporteLiquidacionToolStripMenuItem.Name = "ReporteLiquidacionToolStripMenuItem"
    Me.ReporteLiquidacionToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
    Me.ReporteLiquidacionToolStripMenuItem.Text = "Reporte Liquidación"
    '
    'MedioDeAprobacionToolStripMenuItem
    '
    Me.MedioDeAprobacionToolStripMenuItem.Name = "MedioDeAprobacionToolStripMenuItem"
    Me.MedioDeAprobacionToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
    Me.MedioDeAprobacionToolStripMenuItem.Text = "Medio de Aprobación"
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(1199, 32)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(129, 29)
    Me.ToolStripLabel1.Text = "Liquidación"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
    Me.MenuStrip1.Size = New System.Drawing.Size(1199, 31)
    Me.MenuStrip1.TabIndex = 3
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'btnReporte
    '
    Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionToolStripMenuItem})
    Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
    Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReporte.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnReporte.MergeIndex = 5
    Me.btnReporte.Name = "btnReporte"
    Me.btnReporte.Size = New System.Drawing.Size(97, 24)
    Me.btnReporte.Text = "Reportes"
    '
    'LiquidacionToolStripMenuItem
    '
    Me.LiquidacionToolStripMenuItem.Name = "LiquidacionToolStripMenuItem"
    Me.LiquidacionToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
    Me.LiquidacionToolStripMenuItem.Text = "Liquidación de haberes"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(4, 128)
    Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(96, 17)
    Me.Label5.TabIndex = 7
    Me.Label5.Text = "Lote de pago:"
    '
    'cbomotivosalida
    '
    Me.cbomotivosalida.AbriralEntrar = False
    Me.cbomotivosalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomotivosalida.FormattingEnabled = True
    Me.cbomotivosalida.Location = New System.Drawing.Point(153, 63)
    Me.cbomotivosalida.Margin = New System.Windows.Forms.Padding(4)
    Me.cbomotivosalida.Name = "cbomotivosalida"
    Me.cbomotivosalida.OperadorDatos = Nothing
    Me.cbomotivosalida.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cbomotivosalida.ParametroDet = Nothing
    Me.cbomotivosalida.PuedeActualizar = True
    Me.cbomotivosalida.PuedeEliminar = True
    Me.cbomotivosalida.PuedeModificar = True
    Me.cbomotivosalida.PuedeNuevo = True
    Me.cbomotivosalida.Size = New System.Drawing.Size(333, 24)
    Me.cbomotivosalida.TabIndex = 4
    '
    'cbotipoliquidacion
    '
    Me.cbotipoliquidacion.AbriralEntrar = False
    Me.cbotipoliquidacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipoliquidacion.FormattingEnabled = True
    Me.cbotipoliquidacion.Location = New System.Drawing.Point(153, 33)
    Me.cbotipoliquidacion.Margin = New System.Windows.Forms.Padding(4)
    Me.cbotipoliquidacion.Name = "cbotipoliquidacion"
    Me.cbotipoliquidacion.OperadorDatos = Nothing
    Me.cbotipoliquidacion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cbotipoliquidacion.ParametroDet = Nothing
    Me.cbotipoliquidacion.PuedeActualizar = True
    Me.cbotipoliquidacion.PuedeEliminar = True
    Me.cbotipoliquidacion.PuedeModificar = True
    Me.cbotipoliquidacion.PuedeNuevo = True
    Me.cbotipoliquidacion.Size = New System.Drawing.Size(333, 24)
    Me.cbotipoliquidacion.TabIndex = 2
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
    Me.CtlBuscaEmpleados1.Size = New System.Drawing.Size(264, 624)
    Me.CtlBuscaEmpleados1.TabIndex = 1
    Me.CtlBuscaEmpleados1.Usuario = Nothing
    '
    'ComboBoxLoteLiquidacion1
    '
    Me.ComboBoxLoteLiquidacion1.BeneficiosSocialesLotePago = Nothing
    Me.ComboBoxLoteLiquidacion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxLoteLiquidacion1.FormattingEnabled = True
    Me.ComboBoxLoteLiquidacion1.Location = New System.Drawing.Point(153, 125)
    Me.ComboBoxLoteLiquidacion1.Name = "ComboBoxLoteLiquidacion1"
    Me.ComboBoxLoteLiquidacion1.PardetTipoBeneficio = Nothing
    Me.ComboBoxLoteLiquidacion1.Patrono = Nothing
    Me.ComboBoxLoteLiquidacion1.PuedeActualizar = True
    Me.ComboBoxLoteLiquidacion1.PuedeEliminar = True
    Me.ComboBoxLoteLiquidacion1.PuedeModificar = False
    Me.ComboBoxLoteLiquidacion1.PuedeNuevo = True
    Me.ComboBoxLoteLiquidacion1.Size = New System.Drawing.Size(155, 24)
    Me.ComboBoxLoteLiquidacion1.TabIndex = 8
    '
    'FrmLiquidacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1199, 693)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "FrmLiquidacion"
    Me.Text = "Liquidación"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.pnlConsulta.ResumeLayout(False)
    Me.pnlConsulta.PerformLayout()
    Me.Panel4.ResumeLayout(False)
    CType(Me.dgdetliq, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSRubroDet, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents BSRubroDet As System.Windows.Forms.BindingSource
  Friend WithEvents LiqdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqvalorcalcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents LiqvalorpagarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents dgdetliq As System.Windows.Forms.DataGridView
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents pnlConsulta As System.Windows.Forms.Panel
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbotipoliquidacion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cbomotivosalida As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents dtfechasalida As System.Windows.Forms.DateTimePicker
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btncerrar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btncalcular As System.Windows.Forms.ToolStripButton
  Friend WithEvents CtlBuscaEmpleados1 As WWTS.Roles.Controles.CtlBuscaEmpleados
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents LiquidacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents ReporteLiquidacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MedioDeAprobacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxLoteLiquidacion1 As ComboBoxLoteLiquidacion
End Class
