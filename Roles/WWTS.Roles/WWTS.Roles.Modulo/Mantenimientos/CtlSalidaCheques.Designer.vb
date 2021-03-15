<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlSalidaCheques
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
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlSalidaCheques))
    Me.HeaderStrip2 = New Infoware.Docking.HeaderStrip
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
    Me.Label3 = New System.Windows.Forms.Label
    Me.rdoantes = New System.Windows.Forms.RadioButton
    Me.Label1 = New System.Windows.Forms.Label
    Me.numanuantes = New System.Windows.Forms.NumericUpDown
    Me.btnelim = New System.Windows.Forms.Button
    Me.btnanul = New System.Windows.Forms.Button
    Me.numdesde = New System.Windows.Forms.NumericUpDown
    Me.numhasta = New System.Windows.Forms.NumericUpDown
    Me.Label2 = New System.Windows.Forms.Label
    Me.numanudespues = New System.Windows.Forms.NumericUpDown
    Me.btnanular = New System.Windows.Forms.Button
    Me.rdodespues = New System.Windows.Forms.RadioButton
    Me.btnmodificar = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Label4 = New System.Windows.Forms.Label
    Me.ListViewCheck1 = New Infoware.Controles.Base.ListViewCheck
    Me.illv = New System.Windows.Forms.ImageList(Me.components)
    Me.CtlCuentaBancaria1 = New WWTS.General.Controles.CtlCuentaBancaria
    Me.HeaderStrip2.SuspendLayout()
    CType(Me.numanuantes, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numdesde, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numhasta, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numanudespues, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Tahoma", 8.25!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Docking.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(540, 19)
    Me.HeaderStrip2.TabIndex = 0
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(93, 16)
    Me.ToolStripLabel2.Text = "Salida de cheques"
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.SystemColors.Info
    Me.Label3.Location = New System.Drawing.Point(124, 32)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(188, 40)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Para insertar cheques anulados elija la dirección y el número de cheques anulados" & _
        " a ingresar"
    '
    'rdoantes
    '
    Me.rdoantes.Checked = True
    Me.rdoantes.Location = New System.Drawing.Point(156, 100)
    Me.rdoantes.Name = "rdoantes"
    Me.rdoantes.Size = New System.Drawing.Size(54, 18)
    Me.rdoantes.TabIndex = 11
    Me.rdoantes.TabStop = True
    Me.rdoantes.Text = "Antes"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(111, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Listar cheques desde:"
    '
    'numanuantes
    '
    Me.numanuantes.Location = New System.Drawing.Point(124, 76)
    Me.numanuantes.Name = "numanuantes"
    Me.numanuantes.Size = New System.Drawing.Size(42, 20)
    Me.numanuantes.TabIndex = 8
    Me.numanuantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.numanuantes.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'btnelim
    '
    Me.btnelim.Enabled = False
    Me.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnelim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnelim.ImageIndex = 2
    Me.btnelim.Location = New System.Drawing.Point(12, 36)
    Me.btnelim.Name = "btnelim"
    Me.btnelim.Size = New System.Drawing.Size(75, 23)
    Me.btnelim.TabIndex = 4
    Me.btnelim.Text = "&Eliminar"
    '
    'btnanul
    '
    Me.btnanul.Enabled = False
    Me.btnanul.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnanul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnanul.ImageIndex = 5
    Me.btnanul.Location = New System.Drawing.Point(168, 76)
    Me.btnanul.Name = "btnanul"
    Me.btnanul.Size = New System.Drawing.Size(100, 23)
    Me.btnanul.TabIndex = 9
    Me.btnanul.Text = "Insertar anulados"
    '
    'numdesde
    '
    Me.numdesde.Location = New System.Drawing.Point(126, 8)
    Me.numdesde.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
    Me.numdesde.Name = "numdesde"
    Me.numdesde.Size = New System.Drawing.Size(80, 20)
    Me.numdesde.TabIndex = 1
    Me.numdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.numdesde.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'numhasta
    '
    Me.numhasta.Location = New System.Drawing.Point(260, 10)
    Me.numhasta.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
    Me.numhasta.Name = "numhasta"
    Me.numhasta.Size = New System.Drawing.Size(80, 20)
    Me.numhasta.TabIndex = 3
    Me.numhasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.numhasta.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(218, 12)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(36, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "hasta:"
    '
    'numanudespues
    '
    Me.numanudespues.Enabled = False
    Me.numanudespues.Location = New System.Drawing.Point(272, 76)
    Me.numanudespues.Name = "numanudespues"
    Me.numanudespues.Size = New System.Drawing.Size(42, 20)
    Me.numanudespues.TabIndex = 10
    Me.numanudespues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.numanudespues.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'btnanular
    '
    Me.btnanular.Enabled = False
    Me.btnanular.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnanular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnanular.ImageIndex = 5
    Me.btnanular.Location = New System.Drawing.Point(12, 60)
    Me.btnanular.Name = "btnanular"
    Me.btnanular.Size = New System.Drawing.Size(75, 23)
    Me.btnanular.TabIndex = 5
    Me.btnanular.Text = "&Anular"
    '
    'rdodespues
    '
    Me.rdodespues.Location = New System.Drawing.Point(220, 100)
    Me.rdodespues.Name = "rdodespues"
    Me.rdodespues.Size = New System.Drawing.Size(72, 18)
    Me.rdodespues.TabIndex = 12
    Me.rdodespues.Text = "Después"
    '
    'btnmodificar
    '
    Me.btnmodificar.Enabled = False
    Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnmodificar.ImageIndex = 2
    Me.btnmodificar.Location = New System.Drawing.Point(12, 84)
    Me.btnmodificar.Name = "btnmodificar"
    Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
    Me.btnmodificar.TabIndex = 6
    Me.btnmodificar.Text = "&Modificar"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlCuentaBancaria1)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.btnmodificar)
    Me.Panel1.Controls.Add(Me.rdoantes)
    Me.Panel1.Controls.Add(Me.rdodespues)
    Me.Panel1.Controls.Add(Me.btnanular)
    Me.Panel1.Controls.Add(Me.numanuantes)
    Me.Panel1.Controls.Add(Me.numanudespues)
    Me.Panel1.Controls.Add(Me.btnelim)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.btnanul)
    Me.Panel1.Controls.Add(Me.numhasta)
    Me.Panel1.Controls.Add(Me.numdesde)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 19)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(540, 127)
    Me.Panel1.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(346, 12)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(85, 13)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "Cuenta bancaria"
    '
    'ListViewCheck1
    '
    Me.ListViewCheck1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ListViewCheck1.Location = New System.Drawing.Point(0, 146)
    Me.ListViewCheck1.Name = "ListViewCheck1"
    Me.ListViewCheck1.Size = New System.Drawing.Size(540, 228)
    Me.ListViewCheck1.TabIndex = 2
    '
    'illv
    '
    Me.illv.ImageStream = CType(resources.GetObject("illv.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.illv.TransparentColor = System.Drawing.Color.Transparent
    Me.illv.Images.SetKeyName(0, "")
    Me.illv.Images.SetKeyName(1, "")
    '
    'CtlCuentaBancaria1
    '
    Me.CtlCuentaBancaria1.CuentaBancaria = Nothing
    Me.CtlCuentaBancaria1.Location = New System.Drawing.Point(346, 32)
    Me.CtlCuentaBancaria1.Name = "CtlCuentaBancaria1"
    Me.CtlCuentaBancaria1.Empresa = Nothing
    Me.CtlCuentaBancaria1.Size = New System.Drawing.Size(186, 86)
    Me.CtlCuentaBancaria1.TabIndex = 14
    '
    'CtlSalidaCheques
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.ListViewCheck1)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlSalidaCheques"
    Me.Size = New System.Drawing.Size(540, 374)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    CType(Me.numanuantes, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numdesde, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numhasta, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numanudespues, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents rdoantes As System.Windows.Forms.RadioButton
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents numanuantes As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnelim As System.Windows.Forms.Button
  Friend WithEvents btnanul As System.Windows.Forms.Button
  Friend WithEvents numdesde As System.Windows.Forms.NumericUpDown
  Friend WithEvents numhasta As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents numanudespues As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnanular As System.Windows.Forms.Button
  Friend WithEvents rdodespues As System.Windows.Forms.RadioButton
  Friend WithEvents btnmodificar As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlCuentaBancaria1 As General.Controles.CtlCuentaBancaria
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents ListViewCheck1 As Infoware.Controles.Base.ListViewCheck
  Friend WithEvents illv As System.Windows.Forms.ImageList

End Class
