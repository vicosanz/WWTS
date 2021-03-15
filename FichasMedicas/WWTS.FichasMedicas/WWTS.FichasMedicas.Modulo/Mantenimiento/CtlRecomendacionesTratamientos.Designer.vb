<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlRecomendacionesTratamientos
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
    Me.Ficha_RecomTratamiento = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 23)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(82, 17)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Descripción"
    '
    'Ficha_RecomTratamiento
    '
    Me.Ficha_RecomTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_RecomTratamiento.Location = New System.Drawing.Point(150, 20)
    Me.Ficha_RecomTratamiento.Multiline = True
    Me.Ficha_RecomTratamiento.Name = "Ficha_RecomTratamiento"
    Me.Ficha_RecomTratamiento.Size = New System.Drawing.Size(562, 169)
    Me.Ficha_RecomTratamiento.TabIndex = 2
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(319, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "RECOMENDACIONES Y/O TRATAMIENTOS"
    '
    'CtlRecomendacionesTratamientos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Ficha_RecomTratamiento)
    Me.Controls.Add(Me.Label1)
    Me.Name = "CtlRecomendacionesTratamientos"
    Me.Size = New System.Drawing.Size(715, 192)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_RecomTratamiento As TextBox
  Friend WithEvents Label12 As Label
End Class
