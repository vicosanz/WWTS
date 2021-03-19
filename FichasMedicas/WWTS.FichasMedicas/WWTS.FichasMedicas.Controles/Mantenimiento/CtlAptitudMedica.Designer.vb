Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlAptitudMedica
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Ficha_AptMedObservacion = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Ficha_AptMedLimitacion = New System.Windows.Forms.TextBox()
    Me.Ficha_AptMedApto = New System.Windows.Forms.RadioButton()
    Me.Ficha_AptMedAptoenOb = New System.Windows.Forms.RadioButton()
    Me.Ficha_AptMedAptoconLim = New System.Windows.Forms.RadioButton()
    Me.Ficha_AptMedNoApto = New System.Windows.Forms.RadioButton()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 55)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(103, 17)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Observaciones"
    '
    'Ficha_AptMedObservacion
    '
    Me.Ficha_AptMedObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_AptMedObservacion.Location = New System.Drawing.Point(150, 55)
    Me.Ficha_AptMedObservacion.Multiline = True
    Me.Ficha_AptMedObservacion.Name = "Ficha_AptMedObservacion"
    Me.Ficha_AptMedObservacion.Size = New System.Drawing.Size(562, 82)
    Me.Ficha_AptMedObservacion.TabIndex = 6
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(282, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "APTITUD MÉDICA PARA EL TRABAJO"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 143)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(86, 17)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Limitaciones"
    '
    'Ficha_AptMedLimitacion
    '
    Me.Ficha_AptMedLimitacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_AptMedLimitacion.Location = New System.Drawing.Point(150, 143)
    Me.Ficha_AptMedLimitacion.Multiline = True
    Me.Ficha_AptMedLimitacion.Name = "Ficha_AptMedLimitacion"
    Me.Ficha_AptMedLimitacion.Size = New System.Drawing.Size(562, 82)
    Me.Ficha_AptMedLimitacion.TabIndex = 8
    '
    'Ficha_AptMedApto
    '
    Me.Ficha_AptMedApto.AutoSize = True
    Me.Ficha_AptMedApto.Location = New System.Drawing.Point(150, 28)
    Me.Ficha_AptMedApto.Name = "Ficha_AptMedApto"
    Me.Ficha_AptMedApto.Size = New System.Drawing.Size(58, 21)
    Me.Ficha_AptMedApto.TabIndex = 1
    Me.Ficha_AptMedApto.TabStop = True
    Me.Ficha_AptMedApto.Text = "Apto"
    Me.Ficha_AptMedApto.UseVisualStyleBackColor = True
    '
    'Ficha_AptMedAptoenOb
    '
    Me.Ficha_AptMedAptoenOb.AutoSize = True
    Me.Ficha_AptMedAptoenOb.Location = New System.Drawing.Point(231, 28)
    Me.Ficha_AptMedAptoenOb.Name = "Ficha_AptMedAptoenOb"
    Me.Ficha_AptMedAptoenOb.Size = New System.Drawing.Size(159, 21)
    Me.Ficha_AptMedAptoenOb.TabIndex = 2
    Me.Ficha_AptMedAptoenOb.TabStop = True
    Me.Ficha_AptMedAptoenOb.Text = "Apto en observación"
    Me.Ficha_AptMedAptoenOb.UseVisualStyleBackColor = True
    '
    'Ficha_AptMedAptoconLim
    '
    Me.Ficha_AptMedAptoconLim.AutoSize = True
    Me.Ficha_AptMedAptoconLim.Location = New System.Drawing.Point(405, 28)
    Me.Ficha_AptMedAptoconLim.Name = "Ficha_AptMedAptoconLim"
    Me.Ficha_AptMedAptoconLim.Size = New System.Drawing.Size(162, 21)
    Me.Ficha_AptMedAptoconLim.TabIndex = 3
    Me.Ficha_AptMedAptoconLim.TabStop = True
    Me.Ficha_AptMedAptoconLim.Text = "Apto con limitaciones"
    Me.Ficha_AptMedAptoconLim.UseVisualStyleBackColor = True
    '
    'Ficha_AptMedNoApto
    '
    Me.Ficha_AptMedNoApto.AutoSize = True
    Me.Ficha_AptMedNoApto.Location = New System.Drawing.Point(584, 28)
    Me.Ficha_AptMedNoApto.Name = "Ficha_AptMedNoApto"
    Me.Ficha_AptMedNoApto.Size = New System.Drawing.Size(79, 21)
    Me.Ficha_AptMedNoApto.TabIndex = 4
    Me.Ficha_AptMedNoApto.TabStop = True
    Me.Ficha_AptMedNoApto.Text = "No apto"
    Me.Ficha_AptMedNoApto.UseVisualStyleBackColor = True
    '
    'CtlAptitudMedica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_AptMedNoApto)
    Me.Controls.Add(Me.Ficha_AptMedAptoconLim)
    Me.Controls.Add(Me.Ficha_AptMedAptoenOb)
    Me.Controls.Add(Me.Ficha_AptMedApto)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Ficha_AptMedLimitacion)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Ficha_AptMedObservacion)
    Me.Controls.Add(Me.Label1)
    Me.Name = "CtlAptitudMedica"
    Me.Size = New System.Drawing.Size(715, 229)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_AptMedObservacion As TextBox
  Friend WithEvents Label12 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Ficha_AptMedLimitacion As TextBox
  Friend WithEvents Ficha_AptMedApto As RadioButton
  Friend WithEvents Ficha_AptMedAptoenOb As RadioButton
  Friend WithEvents Ficha_AptMedAptoconLim As RadioButton
  Friend WithEvents Ficha_AptMedNoApto As RadioButton
End Class
