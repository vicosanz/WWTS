<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImagenSQL
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
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(144, 124)
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.White
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Location = New System.Drawing.Point(3, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(144, 124)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Doble clic para insertar una imagen desde un archivo"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'ImagenSQL
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Name = "ImagenSQL"
    Me.Padding = New System.Windows.Forms.Padding(3)
    Me.Size = New System.Drawing.Size(150, 130)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
