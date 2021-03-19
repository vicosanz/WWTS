Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlAntecedentesFamiliares
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
    Me.Ficha_AntFamEnfCard = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfMet = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfNeu = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfOnc = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfInf = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfHer = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfDisc = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamEnfOtro = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntFamObservacion = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Ficha_AntFamEnfCard
    '
    Me.Ficha_AntFamEnfCard.AutoSize = True
    Me.Ficha_AntFamEnfCard.Location = New System.Drawing.Point(3, 20)
    Me.Ficha_AntFamEnfCard.Name = "Ficha_AntFamEnfCard"
    Me.Ficha_AntFamEnfCard.Size = New System.Drawing.Size(129, 21)
    Me.Ficha_AntFamEnfCard.TabIndex = 1
    Me.Ficha_AntFamEnfCard.Text = "Cardio-vascular"
    Me.Ficha_AntFamEnfCard.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfMet
    '
    Me.Ficha_AntFamEnfMet.AutoSize = True
    Me.Ficha_AntFamEnfMet.Location = New System.Drawing.Point(138, 20)
    Me.Ficha_AntFamEnfMet.Name = "Ficha_AntFamEnfMet"
    Me.Ficha_AntFamEnfMet.Size = New System.Drawing.Size(98, 21)
    Me.Ficha_AntFamEnfMet.TabIndex = 2
    Me.Ficha_AntFamEnfMet.Text = "Metabólica"
    Me.Ficha_AntFamEnfMet.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfNeu
    '
    Me.Ficha_AntFamEnfNeu.AutoSize = True
    Me.Ficha_AntFamEnfNeu.Location = New System.Drawing.Point(242, 20)
    Me.Ficha_AntFamEnfNeu.Name = "Ficha_AntFamEnfNeu"
    Me.Ficha_AntFamEnfNeu.Size = New System.Drawing.Size(106, 21)
    Me.Ficha_AntFamEnfNeu.TabIndex = 3
    Me.Ficha_AntFamEnfNeu.Text = "Neurológica"
    Me.Ficha_AntFamEnfNeu.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfOnc
    '
    Me.Ficha_AntFamEnfOnc.AutoSize = True
    Me.Ficha_AntFamEnfOnc.Location = New System.Drawing.Point(354, 20)
    Me.Ficha_AntFamEnfOnc.Name = "Ficha_AntFamEnfOnc"
    Me.Ficha_AntFamEnfOnc.Size = New System.Drawing.Size(101, 21)
    Me.Ficha_AntFamEnfOnc.TabIndex = 4
    Me.Ficha_AntFamEnfOnc.Text = "Oncológica"
    Me.Ficha_AntFamEnfOnc.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfInf
    '
    Me.Ficha_AntFamEnfInf.AutoSize = True
    Me.Ficha_AntFamEnfInf.Location = New System.Drawing.Point(461, 20)
    Me.Ficha_AntFamEnfInf.Name = "Ficha_AntFamEnfInf"
    Me.Ficha_AntFamEnfInf.Size = New System.Drawing.Size(93, 21)
    Me.Ficha_AntFamEnfInf.TabIndex = 5
    Me.Ficha_AntFamEnfInf.Text = "Infecciosa"
    Me.Ficha_AntFamEnfInf.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfHer
    '
    Me.Ficha_AntFamEnfHer.AutoSize = True
    Me.Ficha_AntFamEnfHer.Location = New System.Drawing.Point(560, 20)
    Me.Ficha_AntFamEnfHer.Name = "Ficha_AntFamEnfHer"
    Me.Ficha_AntFamEnfHer.Size = New System.Drawing.Size(166, 21)
    Me.Ficha_AntFamEnfHer.TabIndex = 6
    Me.Ficha_AntFamEnfHer.Text = "Hereditaria/congénita"
    Me.Ficha_AntFamEnfHer.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfDisc
    '
    Me.Ficha_AntFamEnfDisc.AutoSize = True
    Me.Ficha_AntFamEnfDisc.Location = New System.Drawing.Point(732, 20)
    Me.Ficha_AntFamEnfDisc.Name = "Ficha_AntFamEnfDisc"
    Me.Ficha_AntFamEnfDisc.Size = New System.Drawing.Size(130, 21)
    Me.Ficha_AntFamEnfDisc.TabIndex = 7
    Me.Ficha_AntFamEnfDisc.Text = "Discapacidades"
    Me.Ficha_AntFamEnfDisc.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamEnfOtro
    '
    Me.Ficha_AntFamEnfOtro.AutoSize = True
    Me.Ficha_AntFamEnfOtro.Location = New System.Drawing.Point(868, 20)
    Me.Ficha_AntFamEnfOtro.Name = "Ficha_AntFamEnfOtro"
    Me.Ficha_AntFamEnfOtro.Size = New System.Drawing.Size(65, 21)
    Me.Ficha_AntFamEnfOtro.TabIndex = 8
    Me.Ficha_AntFamEnfOtro.Text = "Otros"
    Me.Ficha_AntFamEnfOtro.UseVisualStyleBackColor = True
    '
    'Ficha_AntFamObservacion
    '
    Me.Ficha_AntFamObservacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_AntFamObservacion.Location = New System.Drawing.Point(150, 47)
    Me.Ficha_AntFamObservacion.Multiline = True
    Me.Ficha_AntFamObservacion.Name = "Ficha_AntFamObservacion"
    Me.Ficha_AntFamObservacion.Size = New System.Drawing.Size(846, 59)
    Me.Ficha_AntFamObservacion.TabIndex = 10
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(3, 44)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(82, 17)
    Me.Label6.TabIndex = 9
    Me.Label6.Text = "Descripción"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(225, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "ANTECEDENTES FAMILIARES"
    '
    'CtlAntecedentesFamiliares
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Ficha_AntFamObservacion)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Ficha_AntFamEnfOtro)
    Me.Controls.Add(Me.Ficha_AntFamEnfDisc)
    Me.Controls.Add(Me.Ficha_AntFamEnfHer)
    Me.Controls.Add(Me.Ficha_AntFamEnfInf)
    Me.Controls.Add(Me.Ficha_AntFamEnfOnc)
    Me.Controls.Add(Me.Ficha_AntFamEnfNeu)
    Me.Controls.Add(Me.Ficha_AntFamEnfMet)
    Me.Controls.Add(Me.Ficha_AntFamEnfCard)
    Me.Name = "CtlAntecedentesFamiliares"
    Me.Size = New System.Drawing.Size(999, 112)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Ficha_AntFamEnfCard As CheckBox
  Friend WithEvents Ficha_AntFamEnfMet As CheckBox
  Friend WithEvents Ficha_AntFamEnfNeu As CheckBox
  Friend WithEvents Ficha_AntFamEnfOnc As CheckBox
  Friend WithEvents Ficha_AntFamEnfInf As CheckBox
  Friend WithEvents Ficha_AntFamEnfHer As CheckBox
  Friend WithEvents Ficha_AntFamEnfDisc As CheckBox
  Friend WithEvents Ficha_AntFamEnfOtro As CheckBox
  Friend WithEvents Ficha_AntFamObservacion As TextBox
  Friend WithEvents Label6 As Label
  Friend WithEvents Label12 As Label
End Class
