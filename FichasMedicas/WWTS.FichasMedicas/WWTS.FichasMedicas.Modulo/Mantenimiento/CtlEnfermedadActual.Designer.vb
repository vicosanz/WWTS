<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlEnfermedadActual
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Ficha_EnfActual = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(127, 17)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Enfermedad actual"
    '
    'TextBox1
    '
    Me.Ficha_EnfActual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_EnfActual.Location = New System.Drawing.Point(150, 3)
    Me.Ficha_EnfActual.Multiline = True
    Me.Ficha_EnfActual.Name = "TextBox1"
    Me.Ficha_EnfActual.Size = New System.Drawing.Size(562, 186)
    Me.Ficha_EnfActual.TabIndex = 4
    '
    'CtlEnfermedadActual
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_EnfActual)
    Me.Controls.Add(Me.Label1)
    Me.Name = "CtlEnfermedadActual"
    Me.Size = New System.Drawing.Size(715, 192)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_EnfActual As TextBox
End Class
