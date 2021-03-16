<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlAsistencia
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlAsistencia))
    Me.lbl_descrip = New System.Windows.Forms.Label()
    Me.pnlguardar = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.btnexcel = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnrefrescar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.btneliminar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnCambiarArea = New System.Windows.Forms.ToolStripButton()
    Me.btnCambiarLote = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnModeloLabor = New System.Windows.Forms.ToolStripButton()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.CtlFotoPersona1 = New Infoware.Controles.Base.ImagenSQL()
    Me.pnlAsistencia = New System.Windows.Forms.Panel()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.BSAsistencia = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnldatos = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txthoras0 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txthoras100b = New System.Windows.Forms.Label()
    Me.txthoras100 = New System.Windows.Forms.Label()
    Me.txthoras50 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txthoras25 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtdiastrab = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtdiasinac = New System.Windows.Forms.NumericUpDown()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtdiasfaltasintegrales = New System.Windows.Forms.Label()
    Me.txtdiasfaltas = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtdiasintegrales = New System.Windows.Forms.Label()
    Me.DataGridView2 = New System.Windows.Forms.DataGridView()
    Me.BSAsistenciaDet = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label13 = New System.Windows.Forms.Label()
    Me.cboSubCentroCosto = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.pnlguardar.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.pnlAsistencia.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnldatos.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.txtdiasinac, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSAsistenciaDet, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lbl_descrip
    '
    Me.lbl_descrip.BackColor = System.Drawing.SystemColors.Info
    Me.lbl_descrip.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbl_descrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_descrip.Location = New System.Drawing.Point(84, 3)
    Me.lbl_descrip.Name = "lbl_descrip"
    Me.lbl_descrip.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
    Me.lbl_descrip.Size = New System.Drawing.Size(773, 42)
    Me.lbl_descrip.TabIndex = 0
    Me.lbl_descrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.lbl_descrip.Visible = False
    '
    'pnlguardar
    '
    Me.pnlguardar.Controls.Add(Me.Panel2)
    Me.pnlguardar.Controls.Add(Me.HeaderStrip1)
    Me.pnlguardar.Controls.Add(Me.lbl_descrip)
    Me.pnlguardar.Controls.Add(Me.Panel1)
    Me.pnlguardar.Controls.Add(Me.CtlFotoPersona1)
    Me.pnlguardar.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlguardar.Location = New System.Drawing.Point(0, 0)
    Me.pnlguardar.Name = "pnlguardar"
    Me.pnlguardar.Padding = New System.Windows.Forms.Padding(3)
    Me.pnlguardar.Size = New System.Drawing.Size(860, 127)
    Me.pnlguardar.TabIndex = 1
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.cboSubCentroCosto)
    Me.Panel2.Controls.Add(Me.dtfechasta)
    Me.Panel2.Controls.Add(Me.Label12)
    Me.Panel2.Controls.Add(Me.dtfecdesde)
    Me.Panel2.Controls.Add(Me.Label13)
    Me.Panel2.Controls.Add(Me.Label11)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(84, 45)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(773, 55)
    Me.Panel2.TabIndex = 5
    '
    'dtfechasta
    '
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(291, 32)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(107, 20)
    Me.dtfechasta.TabIndex = 5
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(252, 32)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(33, 13)
    Me.Label12.TabIndex = 4
    Me.Label12.Text = "hasta"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(138, 32)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(107, 20)
    Me.dtfecdesde.TabIndex = 3
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(8, 32)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(130, 13)
    Me.Label11.TabIndex = 2
    Me.Label11.Text = "Se puede modificar desde"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.HeaderStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnexcel, Me.ToolStripSeparator1, Me.btnrefrescar, Me.ToolStripSeparator4, Me.btnguardar, Me.btneliminar, Me.ToolStripSeparator2, Me.btnCambiarArea, Me.btnCambiarLote, Me.ToolStripSeparator3, Me.btnModeloLabor})
    Me.HeaderStrip1.Location = New System.Drawing.Point(84, 103)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(773, 21)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.Text = "Opciones"
    '
    'btnexcel
    '
    Me.btnexcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnexcel.Image = My.Resources.Resources.docexcel
    Me.btnexcel.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnexcel.Name = "btnexcel"
    Me.btnexcel.Size = New System.Drawing.Size(23, 18)
    Me.btnexcel.Text = "Exportar a Excel"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 21)
    '
    'btnrefrescar
    '
    Me.btnrefrescar.Image = CType(resources.GetObject("btnrefrescar.Image"), System.Drawing.Image)
    Me.btnrefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnrefrescar.Name = "btnrefrescar"
    Me.btnrefrescar.Size = New System.Drawing.Size(165, 18)
    Me.btnrefrescar.Text = "Calcular Horas Biométrico"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 21)
    '
    'btnguardar
    '
    Me.btnguardar.Image = My.Resources.Resources.save
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(123, 18)
    Me.btnguardar.Text = "Guardar asistencia"
    '
    'btneliminar
    '
    Me.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminar.Image = My.Resources.Resources.eliminar
    Me.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(23, 18)
    Me.btneliminar.Text = "Eliminar asistencia"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 21)
    '
    'btnCambiarArea
    '
    Me.btnCambiarArea.Image = My.Resources.Resources.APROBAR
    Me.btnCambiarArea.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCambiarArea.Name = "btnCambiarArea"
    Me.btnCambiarArea.Size = New System.Drawing.Size(99, 18)
    Me.btnCambiarArea.Text = "Cambiar Area"
    '
    'btnCambiarLote
    '
    Me.btnCambiarLote.Image = My.Resources.Resources.APROBAR
    Me.btnCambiarLote.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCambiarLote.Name = "btnCambiarLote"
    Me.btnCambiarLote.Size = New System.Drawing.Size(98, 18)
    Me.btnCambiarLote.Text = "Cambiar Lote"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 21)
    '
    'btnModeloLabor
    '
    Me.btnModeloLabor.Image = My.Resources.Resources.open
    Me.btnModeloLabor.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnModeloLabor.Name = "btnModeloLabor"
    Me.btnModeloLabor.Size = New System.Drawing.Size(114, 18)
    Me.btnModeloLabor.Text = "Modelo de labor"
    '
    'Panel1
    '
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Location = New System.Drawing.Point(74, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(10, 121)
    Me.Panel1.TabIndex = 4
    '
    'CtlFotoPersona1
    '
    Me.CtlFotoPersona1.ArchivoImagen = ""
    Me.CtlFotoPersona1.BackColor = System.Drawing.Color.Transparent
    Me.CtlFotoPersona1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlFotoPersona1.Enabled = False
    Me.CtlFotoPersona1.Imagen = Nothing
    Me.CtlFotoPersona1.Location = New System.Drawing.Point(3, 3)
    Me.CtlFotoPersona1.Name = "CtlFotoPersona1"
    Me.CtlFotoPersona1.Padding = New System.Windows.Forms.Padding(3)
    Me.CtlFotoPersona1.Size = New System.Drawing.Size(71, 121)
    Me.CtlFotoPersona1.TabIndex = 3
    '
    'pnlAsistencia
    '
    Me.pnlAsistencia.Controls.Add(Me.DataGridView1)
    Me.pnlAsistencia.Controls.Add(Me.pnldatos)
    Me.pnlAsistencia.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlAsistencia.Location = New System.Drawing.Point(0, 127)
    Me.pnlAsistencia.Name = "pnlAsistencia"
    Me.pnlAsistencia.Size = New System.Drawing.Size(860, 488)
    Me.pnlAsistencia.TabIndex = 3
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.DataSource = Me.BSAsistencia
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(860, 328)
    Me.DataGridView1.TabIndex = 1
    '
    'pnldatos
    '
    Me.pnldatos.Controls.Add(Me.TabControl1)
    Me.pnldatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnldatos.Location = New System.Drawing.Point(0, 328)
    Me.pnldatos.Name = "pnldatos"
    Me.pnldatos.Size = New System.Drawing.Size(860, 160)
    Me.pnldatos.TabIndex = 2
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(860, 160)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
    Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
    Me.TabPage1.Controls.Add(Me.DataGridView2)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(852, 134)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Detalle"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.26316!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.73684!))
    Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.txthoras0, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.txthoras100b, 1, 4)
    Me.TableLayoutPanel2.Controls.Add(Me.txthoras100, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.txthoras50, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.txthoras25, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 4)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(379, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 5
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(228, 100)
    Me.TableLayoutPanel2.TabIndex = 21
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(3, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(83, 13)
    Me.Label6.TabIndex = 8
    Me.Label6.Text = "Horas normales:"
    '
    'txthoras0
    '
    Me.txthoras0.Location = New System.Drawing.Point(186, 0)
    Me.txthoras0.Name = "txthoras0"
    Me.txthoras0.Size = New System.Drawing.Size(39, 15)
    Me.txthoras0.TabIndex = 9
    Me.txthoras0.Text = "0"
    Me.txthoras0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(3, 20)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(93, 13)
    Me.Label7.TabIndex = 10
    Me.Label7.Text = "Horas sobret 25%:"
    '
    'txthoras100b
    '
    Me.txthoras100b.Location = New System.Drawing.Point(186, 80)
    Me.txthoras100b.Name = "txthoras100b"
    Me.txthoras100b.Size = New System.Drawing.Size(39, 15)
    Me.txthoras100b.TabIndex = 17
    Me.txthoras100b.Text = "0"
    Me.txthoras100b.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txthoras100
    '
    Me.txthoras100.Location = New System.Drawing.Point(186, 60)
    Me.txthoras100.Name = "txthoras100"
    Me.txthoras100.Size = New System.Drawing.Size(39, 15)
    Me.txthoras100.TabIndex = 15
    Me.txthoras100.Text = "0"
    Me.txthoras100.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txthoras50
    '
    Me.txthoras50.Location = New System.Drawing.Point(186, 40)
    Me.txthoras50.Name = "txthoras50"
    Me.txthoras50.Size = New System.Drawing.Size(39, 15)
    Me.txthoras50.TabIndex = 13
    Me.txthoras50.Text = "0"
    Me.txthoras50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(3, 60)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(172, 13)
    Me.Label9.TabIndex = 14
    Me.Label9.Text = "Horas sobret 100% suplementarias:"
    '
    'txthoras25
    '
    Me.txthoras25.Location = New System.Drawing.Point(186, 20)
    Me.txthoras25.Name = "txthoras25"
    Me.txthoras25.Size = New System.Drawing.Size(39, 15)
    Me.txthoras25.TabIndex = 11
    Me.txthoras25.Text = "0"
    Me.txthoras25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(3, 40)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(93, 13)
    Me.Label8.TabIndex = 12
    Me.Label8.Text = "Horas sobret 50%:"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(3, 80)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(170, 13)
    Me.Label10.TabIndex = 16
    Me.Label10.Text = "Horas sobret 100% extraordinarias:"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.68085!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.31915!))
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.txtdiastrab, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
    Me.TableLayoutPanel1.Controls.Add(Me.txtdiasinac, 1, 5)
    Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
    Me.TableLayoutPanel1.Controls.Add(Me.txtdiasfaltasintegrales, 1, 4)
    Me.TableLayoutPanel1.Controls.Add(Me.txtdiasfaltas, 1, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.txtdiasintegrales, 1, 2)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 6
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(173, 127)
    Me.TableLayoutPanel1.TabIndex = 20
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(85, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Días trabajados:"
    '
    'txtdiastrab
    '
    Me.txtdiastrab.Location = New System.Drawing.Point(123, 0)
    Me.txtdiastrab.Name = "txtdiastrab"
    Me.txtdiastrab.Size = New System.Drawing.Size(47, 15)
    Me.txtdiastrab.TabIndex = 1
    Me.txtdiastrab.Text = "0"
    Me.txtdiastrab.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(3, 100)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(78, 13)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Días inactivos:"
    '
    'txtdiasinac
    '
    Me.txtdiasinac.Location = New System.Drawing.Point(123, 103)
    Me.txtdiasinac.Name = "txtdiasinac"
    Me.txtdiasinac.Size = New System.Drawing.Size(47, 20)
    Me.txtdiasinac.TabIndex = 7
    Me.txtdiasinac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(3, 80)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(113, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Días Faltas Integrales:"
    '
    'txtdiasfaltasintegrales
    '
    Me.txtdiasfaltasintegrales.Location = New System.Drawing.Point(123, 80)
    Me.txtdiasfaltasintegrales.Name = "txtdiasfaltasintegrales"
    Me.txtdiasfaltasintegrales.Size = New System.Drawing.Size(47, 15)
    Me.txtdiasfaltasintegrales.TabIndex = 19
    Me.txtdiasfaltasintegrales.Text = "0"
    Me.txtdiasfaltasintegrales.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'txtdiasfaltas
    '
    Me.txtdiasfaltas.Location = New System.Drawing.Point(123, 60)
    Me.txtdiasfaltas.Name = "txtdiasfaltas"
    Me.txtdiasfaltas.Size = New System.Drawing.Size(47, 15)
    Me.txtdiasfaltas.TabIndex = 3
    Me.txtdiasfaltas.Text = "0"
    Me.txtdiasfaltas.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(64, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Días Faltas:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 40)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(82, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Días Integrales:"
    '
    'txtdiasintegrales
    '
    Me.txtdiasintegrales.Location = New System.Drawing.Point(123, 40)
    Me.txtdiasintegrales.Name = "txtdiasintegrales"
    Me.txtdiasintegrales.Size = New System.Drawing.Size(47, 15)
    Me.txtdiasintegrales.TabIndex = 19
    Me.txtdiasintegrales.Text = "0"
    Me.txtdiasintegrales.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'DataGridView2
    '
    Me.DataGridView2.AllowUserToAddRows = False
    Me.DataGridView2.AutoGenerateColumns = False
    Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView2.DataSource = Me.BSAsistenciaDet
    Me.DataGridView2.Location = New System.Drawing.Point(182, 0)
    Me.DataGridView2.Name = "DataGridView2"
    Me.DataGridView2.RowHeadersVisible = False
    Me.DataGridView2.Size = New System.Drawing.Size(191, 128)
    Me.DataGridView2.TabIndex = 18
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(8, 8)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(90, 13)
    Me.Label13.TabIndex = 0
    Me.Label13.Text = "Centro de costos:"
    '
    'cboSubCentroCosto
    '
    Me.cboSubCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSubCentroCosto.FormattingEnabled = True
    Me.cboSubCentroCosto.Location = New System.Drawing.Point(138, 5)
    Me.cboSubCentroCosto.Name = "cboSubCentroCosto"
    Me.cboSubCentroCosto.OperadorDatos = Nothing
    Me.cboSubCentroCosto.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboSubCentroCosto.ParametroDet = Nothing
    Me.cboSubCentroCosto.PuedeActualizar = True
    Me.cboSubCentroCosto.PuedeEliminar = True
    Me.cboSubCentroCosto.PuedeModificar = True
    Me.cboSubCentroCosto.PuedeNuevo = True
    Me.cboSubCentroCosto.Size = New System.Drawing.Size(260, 21)
    Me.cboSubCentroCosto.TabIndex = 1
    '
    'CtlAsistencia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlAsistencia)
    Me.Controls.Add(Me.pnlguardar)
    Me.Name = "CtlAsistencia"
    Me.Size = New System.Drawing.Size(860, 615)
    Me.pnlguardar.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.pnlAsistencia.ResumeLayout(False)
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnldatos.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    CType(Me.txtdiasinac, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSAsistenciaDet, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lbl_descrip As System.Windows.Forms.Label
  Friend WithEvents pnlguardar As System.Windows.Forms.Panel
  'Friend WithEvents CtlLabor1 As CtlLabor
  'Friend WithEvents Label25 As System.Windows.Forms.Label
  'Friend WithEvents btncambiar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents AvitipoavisoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents AvifecdesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents AvifechastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlFotoPersona1 As Infoware.Controles.Base.ImagenSQL
  Friend WithEvents BSAsistencia As System.Windows.Forms.BindingSource
  Friend WithEvents pnlAsistencia As System.Windows.Forms.Panel
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents btnexcel As System.Windows.Forms.ToolStripButton
  Friend WithEvents pnldatos As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txthoras50 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txthoras25 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txthoras0 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txthoras100 As System.Windows.Forms.Label
  Friend WithEvents txthoras100b As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents BSAsistenciaDet As System.Windows.Forms.BindingSource
  Friend WithEvents txtdiasfaltas As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtdiasinac As System.Windows.Forms.NumericUpDown
  Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
  Friend WithEvents txtdiastrab As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdiasfaltasintegrales As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnrefrescar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCambiarArea As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCambiarLote As System.Windows.Forms.ToolStripButton
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtdiasintegrales As System.Windows.Forms.Label
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnModeloLabor As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents cboSubCentroCosto As WWTS.General.Controles.ComboBoxParametroDet

End Class
