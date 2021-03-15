<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlEvaluacionMedicaRetiro
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
    Me.Ficha_EvMedRetiroObservacion = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Ficha_EvMedRetiro = New System.Windows.Forms.CheckBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 47)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(103, 17)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Observaciones"
    '
    'Ficha_EvMedRetiroObservacion
    '
    Me.Ficha_EvMedRetiroObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_EvMedRetiroObservacion.Location = New System.Drawing.Point(150, 47)
    Me.Ficha_EvMedRetiroObservacion.Multiline = True
    Me.Ficha_EvMedRetiroObservacion.Name = "Ficha_EvMedRetiroObservacion"
    Me.Ficha_EvMedRetiroObservacion.Size = New System.Drawing.Size(562, 82)
    Me.Ficha_EvMedRetiroObservacion.TabIndex = 3
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(256, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "EVALUACIÓN MÉDICA DE RETIRO"
    '
    'Ficha_EvMedRetiro
    '
    Me.Ficha_EvMedRetiro.AutoSize = True
    Me.Ficha_EvMedRetiro.Location = New System.Drawing.Point(6, 20)
    Me.Ficha_EvMedRetiro.Name = "Ficha_EvMedRetiro"
    Me.Ficha_EvMedRetiro.Size = New System.Drawing.Size(180, 21)
    Me.Ficha_EvMedRetiro.TabIndex = 1
    Me.Ficha_EvMedRetiro.Text = "Se realizó la evaluación"
    Me.Ficha_EvMedRetiro.UseVisualStyleBackColor = True
    '
    'CtlEvaluacionMedicaRetiro
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_EvMedRetiro)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Ficha_EvMedRetiroObservacion)
    Me.Controls.Add(Me.Label1)
    Me.Name = "CtlEvaluacionMedicaRetiro"
    Me.Size = New System.Drawing.Size(715, 134)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_EvMedRetiroObservacion As TextBox
  Friend WithEvents Label12 As Label
  Friend WithEvents Ficha_EvMedRetiro As CheckBox
End Class
