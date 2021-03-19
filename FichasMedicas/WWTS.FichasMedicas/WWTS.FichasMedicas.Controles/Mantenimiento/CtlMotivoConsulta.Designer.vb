<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlMotivoConsulta
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(disposing As Boolean)
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Ficha_MotivoConsulta = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(128, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Motivo de Consulta"
    '
    'Ficha_MotivoConsulta
    '
    Me.Ficha_MotivoConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_MotivoConsulta.Location = New System.Drawing.Point(150, 3)
    Me.Ficha_MotivoConsulta.Multiline = True
    Me.Ficha_MotivoConsulta.Name = "Ficha_MotivoConsulta"
    Me.Ficha_MotivoConsulta.Size = New System.Drawing.Size(562, 186)
    Me.Ficha_MotivoConsulta.TabIndex = 1
    '
    'CtlMotivoConsulta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_MotivoConsulta)
    Me.Controls.Add(Me.Label1)
    Me.Name = "CtlMotivoConsulta"
    Me.Size = New System.Drawing.Size(715, 192)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_MotivoConsulta As TextBox
End Class
