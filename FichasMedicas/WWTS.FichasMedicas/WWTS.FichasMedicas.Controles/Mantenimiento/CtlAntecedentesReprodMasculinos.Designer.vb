Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlAntecedentesReprodMasculinos
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
    Me.Ficha_EcoProst = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntigProst = New System.Windows.Forms.CheckBox()
    Me.Ficha_EcoProstResult = New System.Windows.Forms.TextBox()
    Me.Ficha_EcoProstAnios = New System.Windows.Forms.TextBox()
    Me.Ficha_AntigProstResult = New System.Windows.Forms.TextBox()
    Me.Ficha_AntigProstAnios = New System.Windows.Forms.TextBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Ficha_HijosMuertos = New System.Windows.Forms.TextBox()
    Me.Ficha_HijosVivos = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Ficha_MPF = New System.Windows.Forms.CheckBox()
    Me.Ficha_MPFTipo1 = New System.Windows.Forms.TextBox()
    Me.Ficha_MPFTipo2 = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Ficha_EcoProst
    '
    Me.Ficha_EcoProst.AutoSize = True
    Me.Ficha_EcoProst.Location = New System.Drawing.Point(3, 75)
    Me.Ficha_EcoProst.Name = "Ficha_EcoProst"
    Me.Ficha_EcoProst.Size = New System.Drawing.Size(120, 21)
    Me.Ficha_EcoProst.TabIndex = 6
    Me.Ficha_EcoProst.Text = "Eco prostático"
    Me.Ficha_EcoProst.UseVisualStyleBackColor = True
    '
    'Ficha_AntigProst
    '
    Me.Ficha_AntigProst.AutoSize = True
    Me.Ficha_AntigProst.Location = New System.Drawing.Point(3, 48)
    Me.Ficha_AntigProst.Name = "Ficha_AntigProst"
    Me.Ficha_AntigProst.Size = New System.Drawing.Size(152, 21)
    Me.Ficha_AntigProst.TabIndex = 3
    Me.Ficha_AntigProst.Text = "Antígeno prostático"
    Me.Ficha_AntigProst.UseVisualStyleBackColor = True
    '
    'Ficha_EcoProstResult
    '
    Me.Ficha_EcoProstResult.Location = New System.Drawing.Point(239, 75)
    Me.Ficha_EcoProstResult.Name = "Ficha_EcoProstResult"
    Me.Ficha_EcoProstResult.Size = New System.Drawing.Size(443, 22)
    Me.Ficha_EcoProstResult.TabIndex = 8
    '
    'Ficha_EcoProstAnios
    '
    Me.Ficha_EcoProstAnios.Location = New System.Drawing.Point(161, 75)
    Me.Ficha_EcoProstAnios.Name = "Ficha_EcoProstAnios"
    Me.Ficha_EcoProstAnios.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_EcoProstAnios.TabIndex = 7
    '
    'Ficha_AntigProstResult
    '
    Me.Ficha_AntigProstResult.Location = New System.Drawing.Point(239, 48)
    Me.Ficha_AntigProstResult.Name = "Ficha_AntigProstResult"
    Me.Ficha_AntigProstResult.Size = New System.Drawing.Size(443, 22)
    Me.Ficha_AntigProstResult.TabIndex = 5
    '
    'Ficha_AntigProstAnios
    '
    Me.Ficha_AntigProstAnios.Location = New System.Drawing.Point(161, 48)
    Me.Ficha_AntigProstAnios.Name = "Ficha_AntigProstAnios"
    Me.Ficha_AntigProstAnios.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_AntigProstAnios.TabIndex = 4
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(244, 22)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(72, 17)
    Me.Label11.TabIndex = 2
    Me.Label11.Text = "Resultado"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(166, 22)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(55, 17)
    Me.Label10.TabIndex = 1
    Me.Label10.Text = "Tiempo"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(372, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "ANTECEDENTES REPRODUCTIVOS MASCULINOS"
    '
    'Ficha_HijosMuertos
    '
    Me.Ficha_HijosMuertos.Location = New System.Drawing.Point(84, 132)
    Me.Ficha_HijosMuertos.Name = "Ficha_HijosMuertos"
    Me.Ficha_HijosMuertos.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_HijosMuertos.TabIndex = 12
    '
    'Ficha_HijosVivos
    '
    Me.Ficha_HijosVivos.Location = New System.Drawing.Point(6, 132)
    Me.Ficha_HijosVivos.Name = "Ficha_HijosVivos"
    Me.Ficha_HijosVivos.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_HijosVivos.TabIndex = 11
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(81, 112)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(94, 17)
    Me.Label9.TabIndex = 10
    Me.Label9.Text = "Hijos muertos"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(3, 112)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(75, 17)
    Me.Label8.TabIndex = 9
    Me.Label8.Text = "Hijos vivos"
    '
    'Ficha_MPF
    '
    Me.Ficha_MPF.AutoSize = True
    Me.Ficha_MPF.Location = New System.Drawing.Point(6, 160)
    Me.Ficha_MPF.Name = "Ficha_MPF"
    Me.Ficha_MPF.Size = New System.Drawing.Size(208, 21)
    Me.Ficha_MPF.TabIndex = 13
    Me.Ficha_MPF.Text = "Método planificación familiar"
    Me.Ficha_MPF.UseVisualStyleBackColor = True
    '
    'Ficha_MPFTipo1
    '
    Me.Ficha_MPFTipo1.Location = New System.Drawing.Point(232, 160)
    Me.Ficha_MPFTipo1.Name = "Ficha_MPFTipo1"
    Me.Ficha_MPFTipo1.Size = New System.Drawing.Size(185, 22)
    Me.Ficha_MPFTipo1.TabIndex = 14
    '
    'Ficha_MPFTipo2
    '
    Me.Ficha_MPFTipo2.Location = New System.Drawing.Point(232, 188)
    Me.Ficha_MPFTipo2.Name = "Ficha_MPFTipo2"
    Me.Ficha_MPFTipo2.Size = New System.Drawing.Size(185, 22)
    Me.Ficha_MPFTipo2.TabIndex = 15
    '
    'CtlAntecedentesReprodMasculinos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_MPF)
    Me.Controls.Add(Me.Ficha_MPFTipo2)
    Me.Controls.Add(Me.Ficha_MPFTipo1)
    Me.Controls.Add(Me.Ficha_HijosMuertos)
    Me.Controls.Add(Me.Ficha_HijosVivos)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Ficha_EcoProst)
    Me.Controls.Add(Me.Ficha_AntigProst)
    Me.Controls.Add(Me.Ficha_EcoProstResult)
    Me.Controls.Add(Me.Ficha_EcoProstAnios)
    Me.Controls.Add(Me.Ficha_AntigProstResult)
    Me.Controls.Add(Me.Ficha_AntigProstAnios)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.Label10)
    Me.Name = "CtlAntecedentesReprodMasculinos"
    Me.Size = New System.Drawing.Size(707, 227)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Ficha_EcoProst As CheckBox
  Friend WithEvents Ficha_AntigProst As CheckBox
  Friend WithEvents Ficha_EcoProstResult As TextBox
  Friend WithEvents Ficha_EcoProstAnios As TextBox
  Friend WithEvents Ficha_AntigProstResult As TextBox
  Friend WithEvents Ficha_AntigProstAnios As TextBox
  Friend WithEvents Label11 As Label
  Friend WithEvents Label10 As Label
  Friend WithEvents Label12 As Label
  Friend WithEvents Ficha_HijosMuertos As TextBox
  Friend WithEvents Ficha_HijosVivos As TextBox
  Friend WithEvents Label9 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents Ficha_MPF As CheckBox
  Friend WithEvents Ficha_MPFTipo1 As TextBox
  Friend WithEvents Ficha_MPFTipo2 As TextBox
End Class
