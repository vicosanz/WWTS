<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdquirirImagen
  Inherits System.Windows.Forms.Form

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdquirirImagen))
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnadquirir = New System.Windows.Forms.ToolStripButton()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.btneliminar = New System.Windows.Forms.ToolStripButton()
    Me.picfoto = New System.Windows.Forms.PictureBox()
    Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnadquirir, Me.btnguardar, Me.btneliminar, Me.ToolStripComboBox1})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(514, 25)
    Me.ToolStrip1.TabIndex = 0
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnadquirir
    '
    Me.btnadquirir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnadquirir.Image = CType(resources.GetObject("btnadquirir.Image"), System.Drawing.Image)
    Me.btnadquirir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnadquirir.Name = "btnadquirir"
    Me.btnadquirir.Size = New System.Drawing.Size(23, 22)
    Me.btnadquirir.Text = "Adquirir imagen"
    '
    'btnguardar
    '
    Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(23, 22)
    Me.btnguardar.Text = "Guardar imagen"
    '
    'btneliminar
    '
    Me.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
    Me.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(23, 22)
    Me.btneliminar.Text = "Eliminar imagen"
    '
    'picfoto
    '
    Me.picfoto.BackColor = System.Drawing.SystemColors.Window
    Me.picfoto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.picfoto.Location = New System.Drawing.Point(0, 25)
    Me.picfoto.Name = "picfoto"
    Me.picfoto.Size = New System.Drawing.Size(514, 354)
    Me.picfoto.TabIndex = 1
    Me.picfoto.TabStop = False
    '
    'ToolStripComboBox1
    '
    Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
    Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
    '
    'FrmAdquirirImagen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(514, 379)
    Me.Controls.Add(Me.picfoto)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Name = "FrmAdquirirImagen"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.Text = "Adquirir imagen"
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    CType(Me.picfoto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnadquirir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents picfoto As System.Windows.Forms.PictureBox
  Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
End Class
