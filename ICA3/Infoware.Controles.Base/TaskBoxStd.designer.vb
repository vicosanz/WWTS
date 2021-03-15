<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskBoxStd
  Inherits System.Windows.Forms.UserControl

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.ilTaskBox = New System.Windows.Forms.ImageList(Me.components)
    Me.SuspendLayout()
    '
    'ilTaskBox
    '
    Me.ilTaskBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.ilTaskBox.ImageSize = New System.Drawing.Size(16, 16)
    Me.ilTaskBox.TransparentColor = System.Drawing.Color.Transparent
    '
    'TaskBoxStd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Name = "TaskBoxStd"
    Me.Padding = New System.Windows.Forms.Padding(4, 51, 4, 4)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ilTaskBox As System.Windows.Forms.ImageList


End Class
