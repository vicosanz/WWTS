<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoSeleccion
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
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
    Me.Label4 = New System.Windows.Forms.Label()
    Me.dtfecha = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Pnl3 = New System.Windows.Forms.Panel()
    Me.DataGridView1 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnnuevodetalle = New System.Windows.Forms.ToolStripButton()
    Me.btnabrirdetalle = New System.Windows.Forms.ToolStripButton()
    Me.btneliminardetalle = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnaprobardetalle = New System.Windows.Forms.ToolStripButton()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.btnEstado = New Infoware.Controles.Base.ButtonStd()
    Me.lblEstado = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboDepartamento = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.CtlArea1 = New WWTS.Roles.Modulo.CtlArea()
    Me.cboSeccion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.Pnl3.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(20, 99)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(40, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Fecha:"
    '
    'dtfecha
    '
    Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecha.Location = New System.Drawing.Point(106, 96)
    Me.dtfecha.Name = "dtfecha"
    Me.dtfecha.Size = New System.Drawing.Size(130, 20)
    Me.dtfecha.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(20, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Sección:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(20, 71)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(32, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Área:"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Pnl3)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(859, 323)
    Me.Panel1.TabIndex = 3
    '
    'Pnl3
    '
    Me.Pnl3.Controls.Add(Me.DataGridView1)
    Me.Pnl3.Controls.Add(Me.HeaderStrip1)
    Me.Pnl3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnl3.Location = New System.Drawing.Point(0, 126)
    Me.Pnl3.Name = "Pnl3"
    Me.Pnl3.Size = New System.Drawing.Size(859, 197)
    Me.Pnl3.TabIndex = 1
    '
    'DataGridView1
    '
    Me.DataGridView1.AgruparRepetidos = False
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31})
    Me.DataGridView1.DataSource = Me.BindingSource2
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(0, 21)
    Me.DataGridView1.Name = "DataGridView1"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridView1.Size = New System.Drawing.Size(859, 176)
    Me.DataGridView1.TabIndex = 1
    '
    'DataGridViewTextBoxColumn30
    '
    Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
    '
    'DataGridViewTextBoxColumn31
    '
    Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnnuevodetalle, Me.btnabrirdetalle, Me.btneliminardetalle, Me.ToolStripSeparator2, Me.btnaprobardetalle})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(859, 21)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(96, 18)
    Me.ToolStripLabel1.Text = "Selección Detalle"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 21)
    '
    'btnnuevodetalle
    '
    Me.btnnuevodetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevodetalle.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.nuevo
    Me.btnnuevodetalle.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevodetalle.Name = "btnnuevodetalle"
    Me.btnnuevodetalle.Size = New System.Drawing.Size(23, 18)
    Me.btnnuevodetalle.Text = "Nuevo"
    '
    'btnabrirdetalle
    '
    Me.btnabrirdetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnabrirdetalle.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.abrir
    Me.btnabrirdetalle.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnabrirdetalle.Name = "btnabrirdetalle"
    Me.btnabrirdetalle.Size = New System.Drawing.Size(23, 18)
    Me.btnabrirdetalle.Text = "Abrir"
    Me.btnabrirdetalle.ToolTipText = "Abrir"
    '
    'btneliminardetalle
    '
    Me.btneliminardetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminardetalle.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.eliminar
    Me.btneliminardetalle.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminardetalle.Name = "btneliminardetalle"
    Me.btneliminardetalle.Size = New System.Drawing.Size(23, 18)
    Me.btneliminardetalle.Text = "Eliminar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 21)
    '
    'btnaprobardetalle
    '
    Me.btnaprobardetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnaprobardetalle.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.APROBAR
    Me.btnaprobardetalle.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnaprobardetalle.Name = "btnaprobardetalle"
    Me.btnaprobardetalle.Size = New System.Drawing.Size(23, 18)
    Me.btnaprobardetalle.Text = "Aprobar"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btnEstado)
    Me.Panel2.Controls.Add(Me.lblEstado)
    Me.Panel2.Controls.Add(Me.Label5)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.cboDepartamento)
    Me.Panel2.Controls.Add(Me.CtlArea1)
    Me.Panel2.Controls.Add(Me.cboSeccion)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.dtfecha)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(859, 126)
    Me.Panel2.TabIndex = 0
    '
    'btnEstado
    '
    Me.btnEstado.Location = New System.Drawing.Point(460, 60)
    Me.btnEstado.Name = "btnEstado"
    Me.btnEstado.Size = New System.Drawing.Size(100, 21)
    Me.btnEstado.TabIndex = 10
    Me.btnEstado.Text = "Cambiar Estado"
    Me.btnEstado.UseVisualStyleBackColor = True
    '
    'lblEstado
    '
    Me.lblEstado.AutoSize = True
    Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEstado.Location = New System.Drawing.Point(465, 35)
    Me.lblEstado.Name = "lblEstado"
    Me.lblEstado.Size = New System.Drawing.Size(118, 15)
    Me.lblEstado.TabIndex = 9
    Me.lblEstado.Text = "Estado Selección"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(371, 37)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(96, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Estado Selección: "
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(20, 43)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(77, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Departamento:"
    '
    'cboDepartamento
    '
    Me.cboDepartamento.AbriralEntrar = False
    Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDepartamento.FormattingEnabled = True
    Me.cboDepartamento.Location = New System.Drawing.Point(106, 40)
    Me.cboDepartamento.Name = "cboDepartamento"
    Me.cboDepartamento.OperadorDatos = Nothing
    Me.cboDepartamento.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboDepartamento.ParametroDet = Nothing
    Me.cboDepartamento.PuedeActualizar = True
    Me.cboDepartamento.PuedeEliminar = True
    Me.cboDepartamento.PuedeModificar = True
    Me.cboDepartamento.PuedeNuevo = True
    Me.cboDepartamento.Size = New System.Drawing.Size(130, 21)
    Me.cboDepartamento.TabIndex = 3
    '
    'CtlArea1
    '
    Me.CtlArea1.AbriralEntrar = False
    Me.CtlArea1.Area = Nothing
    Me.CtlArea1.Departamento = Nothing
    Me.CtlArea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlArea1.FormattingEnabled = True
    Me.CtlArea1.Location = New System.Drawing.Point(106, 68)
    Me.CtlArea1.Name = "CtlArea1"
    Me.CtlArea1.Op = Nothing
    Me.CtlArea1.PuedeActualizar = True
    Me.CtlArea1.PuedeEliminar = True
    Me.CtlArea1.PuedeModificar = True
    Me.CtlArea1.PuedeNuevo = True
    Me.CtlArea1.Seccion = Nothing
    Me.CtlArea1.Size = New System.Drawing.Size(130, 21)
    Me.CtlArea1.TabIndex = 5
    '
    'cboSeccion
    '
    Me.cboSeccion.AbriralEntrar = False
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(106, 12)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.OperadorDatos = Nothing
    Me.cboSeccion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cboSeccion.ParametroDet = Nothing
    Me.cboSeccion.PuedeActualizar = True
    Me.cboSeccion.PuedeEliminar = True
    Me.cboSeccion.PuedeModificar = True
    Me.cboSeccion.PuedeNuevo = True
    Me.cboSeccion.Size = New System.Drawing.Size(130, 21)
    Me.cboSeccion.TabIndex = 1
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
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
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
    'FrmMantenimientoSeleccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(859, 372)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoSeleccion"
    Me.PuedeGuardaryCerrar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento de Selección"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Pnl3.ResumeLayout(False)
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboSeccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Pnl3 As System.Windows.Forms.Panel
  Friend WithEvents DataGridView1 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnabrirdetalle As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnnuevodetalle As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btneliminardetalle As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnaprobardetalle As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlArea1 As WWTS.Roles.Modulo.CtlArea
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboDepartamento As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnEstado As Infoware.Controles.Base.ButtonStd
  Friend WithEvents lblEstado As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
