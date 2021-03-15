<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaEmpleado
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
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.pnldescparc = New System.Windows.Forms.Panel()
    Me.chkficharoja = New System.Windows.Forms.CheckBox()
    Me.cbomayorque = New System.Windows.Forms.ComboBox()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtedad = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtcedula = New Infoware.Controles.Base.TextBoxStd()
    Me.Label38 = New System.Windows.Forms.Label()
    Me.Label39 = New System.Windows.Forms.Label()
    Me.Label41 = New System.Windows.Forms.Label()
    Me.Label37 = New System.Windows.Forms.Label()
    Me.txtnombre = New Infoware.Controles.Base.TextBoxStd()
    Me.Label49 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pb = New System.Windows.Forms.ProgressBar()
    Me.btnbuscar = New Infoware.Controles.Base.ButtonStd()
    Me.btnlimpiar = New Infoware.Controles.Base.ButtonStd()
    Me.tv = New System.Windows.Forms.DataGridView()
    Me.ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.HeaderStrip2.SuspendLayout()
    Me.pnldescparc.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.tv, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
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
    Me.HeaderStrip2.Size = New System.Drawing.Size(204, 19)
    Me.HeaderStrip2.TabIndex = 2
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(131, 16)
    Me.ToolStripLabel2.Text = "Búsqueda de Empleado"
    '
    'pnldescparc
    '
    Me.pnldescparc.Controls.Add(Me.chkficharoja)
    Me.pnldescparc.Controls.Add(Me.cbomayorque)
    Me.pnldescparc.Controls.Add(Me.txtcodigo)
    Me.pnldescparc.Controls.Add(Me.txtedad)
    Me.pnldescparc.Controls.Add(Me.txtcedula)
    Me.pnldescparc.Controls.Add(Me.Label38)
    Me.pnldescparc.Controls.Add(Me.Label39)
    Me.pnldescparc.Controls.Add(Me.Label41)
    Me.pnldescparc.Controls.Add(Me.Label37)
    Me.pnldescparc.Controls.Add(Me.txtnombre)
    Me.pnldescparc.Controls.Add(Me.Label49)
    Me.pnldescparc.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldescparc.Location = New System.Drawing.Point(0, 19)
    Me.pnldescparc.Name = "pnldescparc"
    Me.pnldescparc.Size = New System.Drawing.Size(204, 145)
    Me.pnldescparc.TabIndex = 3
    '
    'chkficharoja
    '
    Me.chkficharoja.AutoSize = True
    Me.chkficharoja.Checked = True
    Me.chkficharoja.CheckState = System.Windows.Forms.CheckState.Indeterminate
    Me.chkficharoja.Location = New System.Drawing.Point(51, 123)
    Me.chkficharoja.Name = "chkficharoja"
    Me.chkficharoja.Size = New System.Drawing.Size(72, 17)
    Me.chkficharoja.TabIndex = 10
    Me.chkficharoja.Text = "Ficha roja"
    Me.chkficharoja.ThreeState = True
    '
    'cbomayorque
    '
    Me.cbomayorque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomayorque.Items.AddRange(New Object() {"Mayor o igual a", "Menor o igual a"})
    Me.cbomayorque.Location = New System.Drawing.Point(51, 75)
    Me.cbomayorque.Name = "cbomayorque"
    Me.cbomayorque.Size = New System.Drawing.Size(104, 21)
    Me.cbomayorque.TabIndex = 7
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(51, 3)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(72, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcodigo.Value = 0.0R
    '
    'txtedad
    '
    Me.txtedad.Location = New System.Drawing.Point(51, 99)
    Me.txtedad.Mensaje = ""
    Me.txtedad.Name = "txtedad"
    Me.txtedad.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtedad.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtedad.PromptText = ""
    Me.txtedad.Size = New System.Drawing.Size(40, 20)
    Me.txtedad.TabIndex = 8
    Me.txtedad.Text = "0"
    Me.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtedad.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtedad.Value = 0.0R
    '
    'txtcedula
    '
    Me.txtcedula.Location = New System.Drawing.Point(51, 51)
    Me.txtcedula.Mensaje = ""
    Me.txtcedula.Name = "txtcedula"
    Me.txtcedula.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcedula.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcedula.PromptText = ""
    Me.txtcedula.Size = New System.Drawing.Size(96, 20)
    Me.txtcedula.TabIndex = 5
    '
    'Label38
    '
    Me.Label38.AutoSize = True
    Me.Label38.Location = New System.Drawing.Point(3, 27)
    Me.Label38.Name = "Label38"
    Me.Label38.Size = New System.Drawing.Size(47, 13)
    Me.Label38.TabIndex = 2
    Me.Label38.Text = "Nombre:"
    '
    'Label39
    '
    Me.Label39.AutoSize = True
    Me.Label39.Location = New System.Drawing.Point(3, 51)
    Me.Label39.Name = "Label39"
    Me.Label39.Size = New System.Drawing.Size(43, 13)
    Me.Label39.TabIndex = 4
    Me.Label39.Text = "Céd/Id:"
    '
    'Label41
    '
    Me.Label41.AutoSize = True
    Me.Label41.Location = New System.Drawing.Point(3, 75)
    Me.Label41.Name = "Label41"
    Me.Label41.Size = New System.Drawing.Size(35, 13)
    Me.Label41.TabIndex = 6
    Me.Label41.Text = "Edad:"
    '
    'Label37
    '
    Me.Label37.AutoSize = True
    Me.Label37.Location = New System.Drawing.Point(3, 3)
    Me.Label37.Name = "Label37"
    Me.Label37.Size = New System.Drawing.Size(43, 13)
    Me.Label37.TabIndex = 0
    Me.Label37.Text = "Código:"
    '
    'txtnombre
    '
    Me.txtnombre.Location = New System.Drawing.Point(51, 27)
    Me.txtnombre.Mensaje = ""
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnombre.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtnombre.PromptText = ""
    Me.txtnombre.Size = New System.Drawing.Size(112, 20)
    Me.txtnombre.TabIndex = 3
    '
    'Label49
    '
    Me.Label49.AutoSize = True
    Me.Label49.Location = New System.Drawing.Point(99, 99)
    Me.Label49.Name = "Label49"
    Me.Label49.Size = New System.Drawing.Size(30, 13)
    Me.Label49.TabIndex = 9
    Me.Label49.Text = "años"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pb)
    Me.Panel1.Controls.Add(Me.btnbuscar)
    Me.Panel1.Controls.Add(Me.btnlimpiar)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 164)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(204, 36)
    Me.Panel1.TabIndex = 4
    '
    'pb
    '
    Me.pb.Location = New System.Drawing.Point(6, 36)
    Me.pb.Name = "pb"
    Me.pb.Size = New System.Drawing.Size(204, 18)
    Me.pb.TabIndex = 2
    '
    'btnbuscar
    '
    Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnbuscar.Location = New System.Drawing.Point(18, 6)
    Me.btnbuscar.Name = "btnbuscar"
    Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
    Me.btnbuscar.TabIndex = 0
    Me.btnbuscar.Text = "&Buscar"
    '
    'btnlimpiar
    '
    Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlimpiar.Location = New System.Drawing.Point(99, 6)
    Me.btnlimpiar.Name = "btnlimpiar"
    Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
    Me.btnlimpiar.TabIndex = 1
    Me.btnlimpiar.Text = "&Atrás"
    '
    'tv
    '
    Me.tv.AllowUserToAddRows = False
    Me.tv.AllowUserToDeleteRows = False
    Me.tv.AllowUserToResizeRows = False
    Me.tv.AutoGenerateColumns = False
    Me.tv.DataSource = Me.ListBindingSource
    Me.tv.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tv.Location = New System.Drawing.Point(0, 200)
    Me.tv.MultiSelect = False
    Me.tv.Name = "tv"
    Me.tv.RowHeadersVisible = False
    Me.tv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.tv.Size = New System.Drawing.Size(204, 325)
    Me.tv.TabIndex = 5
    '
    'ListBindingSource
    '
    '
    'CtlBuscaEmpleado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Info
    Me.Controls.Add(Me.tv)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.pnldescparc)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlBuscaEmpleado"
    Me.Size = New System.Drawing.Size(204, 525)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.pnldescparc.ResumeLayout(False)
    Me.pnldescparc.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    CType(Me.tv, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents pnldescparc As System.Windows.Forms.Panel
  Friend WithEvents chkficharoja As System.Windows.Forms.CheckBox
  Friend WithEvents cbomayorque As System.Windows.Forms.ComboBox
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtedad As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtcedula As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label38 As System.Windows.Forms.Label
  Friend WithEvents Label39 As System.Windows.Forms.Label
  Friend WithEvents Label41 As System.Windows.Forms.Label
  Friend WithEvents Label37 As System.Windows.Forms.Label
  Friend WithEvents txtnombre As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label49 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents pb As System.Windows.Forms.ProgressBar
  Friend WithEvents btnbuscar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnlimpiar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents tv As System.Windows.Forms.DataGridView
  Friend WithEvents ListBindingSource As System.Windows.Forms.BindingSource

End Class
