Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlAntecedentesGinecoobstetricos
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
    Me.Ficha_FecMenarq = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Ficha_Ciclos = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Ficha_FUM = New System.Windows.Forms.DateTimePicker()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Ficha_Gestas = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Ficha_Partos = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Ficha_Cesareas = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Ficha_Abortos = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Ficha_HijosVivos = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Ficha_HijosMuertos = New System.Windows.Forms.TextBox()
    Me.Ficha_VSA = New System.Windows.Forms.CheckBox()
    Me.Ficha_MPF = New System.Windows.Forms.CheckBox()
    Me.Ficha_MPFTipo1 = New System.Windows.Forms.TextBox()
    Me.Ficha_Papanic = New System.Windows.Forms.CheckBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Ficha_PapanicAnios = New System.Windows.Forms.TextBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Ficha_PapanicResult = New System.Windows.Forms.TextBox()
    Me.Ficha_ColposcopAnios = New System.Windows.Forms.TextBox()
    Me.Ficha_ColposcopResult = New System.Windows.Forms.TextBox()
    Me.Ficha_Colposcop = New System.Windows.Forms.CheckBox()
    Me.Ficha_EcoMamarioAnios = New System.Windows.Forms.TextBox()
    Me.Ficha_EcoMamarioResult = New System.Windows.Forms.TextBox()
    Me.Ficha_EcoMamario = New System.Windows.Forms.CheckBox()
    Me.Ficha_MamograAnios = New System.Windows.Forms.TextBox()
    Me.Ficha_MamograResult = New System.Windows.Forms.TextBox()
    Me.Ficha_Mamogra = New System.Windows.Forms.CheckBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(75, 17)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Menarquia"
    '
    'Ficha_FecMenarq
    '
    Me.Ficha_FecMenarq.Location = New System.Drawing.Point(150, 31)
    Me.Ficha_FecMenarq.Name = "Ficha_FecMenarq"
    Me.Ficha_FecMenarq.Size = New System.Drawing.Size(249, 22)
    Me.Ficha_FecMenarq.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(481, 28)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(45, 17)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Ciclos"
    '
    'Ficha_Ciclos
    '
    Me.Ficha_Ciclos.Location = New System.Drawing.Point(680, 31)
    Me.Ficha_Ciclos.Name = "Ficha_Ciclos"
    Me.Ficha_Ciclos.Size = New System.Drawing.Size(100, 22)
    Me.Ficha_Ciclos.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 56)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(135, 17)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Fecha última menstr"
    '
    'Ficha_FUM
    '
    Me.Ficha_FUM.Location = New System.Drawing.Point(150, 59)
    Me.Ficha_FUM.Name = "Ficha_FUM"
    Me.Ficha_FUM.Size = New System.Drawing.Size(249, 22)
    Me.Ficha_FUM.TabIndex = 6
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(3, 90)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(53, 17)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Gestas"
    '
    'Ficha_Gestas
    '
    Me.Ficha_Gestas.Location = New System.Drawing.Point(6, 110)
    Me.Ficha_Gestas.Name = "Ficha_Gestas"
    Me.Ficha_Gestas.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_Gestas.TabIndex = 8
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(85, 90)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(49, 17)
    Me.Label5.TabIndex = 9
    Me.Label5.Text = "Partos"
    '
    'Ficha_Partos
    '
    Me.Ficha_Partos.Location = New System.Drawing.Point(88, 110)
    Me.Ficha_Partos.Name = "Ficha_Partos"
    Me.Ficha_Partos.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_Partos.TabIndex = 10
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(166, 90)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(68, 17)
    Me.Label6.TabIndex = 11
    Me.Label6.Text = "Cesáreas"
    '
    'Ficha_Cesareas
    '
    Me.Ficha_Cesareas.Location = New System.Drawing.Point(169, 110)
    Me.Ficha_Cesareas.Name = "Ficha_Cesareas"
    Me.Ficha_Cesareas.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_Cesareas.TabIndex = 12
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(247, 90)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(57, 17)
    Me.Label7.TabIndex = 13
    Me.Label7.Text = "Abortos"
    '
    'Ficha_Abortos
    '
    Me.Ficha_Abortos.Location = New System.Drawing.Point(250, 110)
    Me.Ficha_Abortos.Name = "Ficha_Abortos"
    Me.Ficha_Abortos.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_Abortos.TabIndex = 14
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(342, 90)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(75, 17)
    Me.Label8.TabIndex = 15
    Me.Label8.Text = "Hijos vivos"
    '
    'Ficha_HijosVivos
    '
    Me.Ficha_HijosVivos.Location = New System.Drawing.Point(345, 110)
    Me.Ficha_HijosVivos.Name = "Ficha_HijosVivos"
    Me.Ficha_HijosVivos.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_HijosVivos.TabIndex = 16
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(420, 90)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(94, 17)
    Me.Label9.TabIndex = 17
    Me.Label9.Text = "Hijos muertos"
    '
    'Ficha_HijosMuertos
    '
    Me.Ficha_HijosMuertos.Location = New System.Drawing.Point(423, 110)
    Me.Ficha_HijosMuertos.Name = "Ficha_HijosMuertos"
    Me.Ficha_HijosMuertos.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_HijosMuertos.TabIndex = 18
    '
    'Ficha_VSA
    '
    Me.Ficha_VSA.AutoSize = True
    Me.Ficha_VSA.Location = New System.Drawing.Point(520, 111)
    Me.Ficha_VSA.Name = "Ficha_VSA"
    Me.Ficha_VSA.Size = New System.Drawing.Size(143, 21)
    Me.Ficha_VSA.TabIndex = 19
    Me.Ficha_VSA.Text = "Vida sexual activa"
    Me.Ficha_VSA.UseVisualStyleBackColor = True
    '
    'Ficha_MPF
    '
    Me.Ficha_MPF.AutoSize = True
    Me.Ficha_MPF.Location = New System.Drawing.Point(6, 138)
    Me.Ficha_MPF.Name = "Ficha_MPF"
    Me.Ficha_MPF.Size = New System.Drawing.Size(208, 21)
    Me.Ficha_MPF.TabIndex = 20
    Me.Ficha_MPF.Text = "Método planificación familiar"
    Me.Ficha_MPF.UseVisualStyleBackColor = True
    '
    'Ficha_MPFTipo1
    '
    Me.Ficha_MPFTipo1.Location = New System.Drawing.Point(232, 138)
    Me.Ficha_MPFTipo1.Name = "Ficha_MPFTipo1"
    Me.Ficha_MPFTipo1.Size = New System.Drawing.Size(185, 22)
    Me.Ficha_MPFTipo1.TabIndex = 21
    '
    'Ficha_Papanic
    '
    Me.Ficha_Papanic.AutoSize = True
    Me.Ficha_Papanic.Location = New System.Drawing.Point(6, 201)
    Me.Ficha_Papanic.Name = "Ficha_Papanic"
    Me.Ficha_Papanic.Size = New System.Drawing.Size(116, 21)
    Me.Ficha_Papanic.TabIndex = 24
    Me.Ficha_Papanic.Text = "Papanicolaou"
    Me.Ficha_Papanic.UseVisualStyleBackColor = True
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(147, 175)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(55, 17)
    Me.Label10.TabIndex = 22
    Me.Label10.Text = "Tiempo"
    '
    'Ficha_PapanicAnios
    '
    Me.Ficha_PapanicAnios.Location = New System.Drawing.Point(142, 201)
    Me.Ficha_PapanicAnios.Name = "Ficha_PapanicAnios"
    Me.Ficha_PapanicAnios.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_PapanicAnios.TabIndex = 25
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(225, 175)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(72, 17)
    Me.Label11.TabIndex = 23
    Me.Label11.Text = "Resultado"
    '
    'Ficha_PapanicResult
    '
    Me.Ficha_PapanicResult.Location = New System.Drawing.Point(220, 201)
    Me.Ficha_PapanicResult.Name = "Ficha_PapanicResult"
    Me.Ficha_PapanicResult.Size = New System.Drawing.Size(443, 22)
    Me.Ficha_PapanicResult.TabIndex = 26
    '
    'Ficha_ColposcopAnios
    '
    Me.Ficha_ColposcopAnios.Location = New System.Drawing.Point(142, 228)
    Me.Ficha_ColposcopAnios.Name = "Ficha_ColposcopAnios"
    Me.Ficha_ColposcopAnios.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_ColposcopAnios.TabIndex = 28
    '
    'Ficha_ColposcopResult
    '
    Me.Ficha_ColposcopResult.Location = New System.Drawing.Point(220, 228)
    Me.Ficha_ColposcopResult.Name = "Ficha_ColposcopResult"
    Me.Ficha_ColposcopResult.Size = New System.Drawing.Size(443, 22)
    Me.Ficha_ColposcopResult.TabIndex = 29
    '
    'Ficha_Colposcop
    '
    Me.Ficha_Colposcop.AutoSize = True
    Me.Ficha_Colposcop.Location = New System.Drawing.Point(6, 228)
    Me.Ficha_Colposcop.Name = "Ficha_Colposcop"
    Me.Ficha_Colposcop.Size = New System.Drawing.Size(107, 21)
    Me.Ficha_Colposcop.TabIndex = 27
    Me.Ficha_Colposcop.Text = "Colposcopia"
    Me.Ficha_Colposcop.UseVisualStyleBackColor = True
    '
    'Ficha_EcoMamarioAnios
    '
    Me.Ficha_EcoMamarioAnios.Location = New System.Drawing.Point(142, 255)
    Me.Ficha_EcoMamarioAnios.Name = "Ficha_EcoMamarioAnios"
    Me.Ficha_EcoMamarioAnios.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_EcoMamarioAnios.TabIndex = 31
    '
    'Ficha_EcoMamarioResult
    '
    Me.Ficha_EcoMamarioResult.Location = New System.Drawing.Point(220, 255)
    Me.Ficha_EcoMamarioResult.Name = "Ficha_EcoMamarioResult"
    Me.Ficha_EcoMamarioResult.Size = New System.Drawing.Size(443, 22)
    Me.Ficha_EcoMamarioResult.TabIndex = 32
    '
    'Ficha_EcoMamario
    '
    Me.Ficha_EcoMamario.AutoSize = True
    Me.Ficha_EcoMamario.Location = New System.Drawing.Point(6, 255)
    Me.Ficha_EcoMamario.Name = "Ficha_EcoMamario"
    Me.Ficha_EcoMamario.Size = New System.Drawing.Size(112, 21)
    Me.Ficha_EcoMamario.TabIndex = 30
    Me.Ficha_EcoMamario.Text = "Eco Mamario"
    Me.Ficha_EcoMamario.UseVisualStyleBackColor = True
    '
    'Ficha_MamograAnios
    '
    Me.Ficha_MamograAnios.Location = New System.Drawing.Point(142, 282)
    Me.Ficha_MamograAnios.Name = "Ficha_MamograAnios"
    Me.Ficha_MamograAnios.Size = New System.Drawing.Size(72, 22)
    Me.Ficha_MamograAnios.TabIndex = 34
    '
    'Ficha_MamograResult
    '
    Me.Ficha_MamograResult.Location = New System.Drawing.Point(220, 282)
    Me.Ficha_MamograResult.Name = "Ficha_MamograResult"
    Me.Ficha_MamograResult.Size = New System.Drawing.Size(443, 22)
    Me.Ficha_MamograResult.TabIndex = 35
    '
    'Ficha_Mamogra
    '
    Me.Ficha_Mamogra.AutoSize = True
    Me.Ficha_Mamogra.Location = New System.Drawing.Point(6, 282)
    Me.Ficha_Mamogra.Name = "Ficha_Mamogra"
    Me.Ficha_Mamogra.Size = New System.Drawing.Size(104, 21)
    Me.Ficha_Mamogra.TabIndex = 33
    Me.Ficha_Mamogra.Text = "Mamografía"
    Me.Ficha_Mamogra.UseVisualStyleBackColor = True
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(309, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "ANTECEDENTES GINECO OBSTÉTRICOS"
    '
    'CtlAntecedentesGinecoobstetricos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_Mamogra)
    Me.Controls.Add(Me.Ficha_EcoMamario)
    Me.Controls.Add(Me.Ficha_Colposcop)
    Me.Controls.Add(Me.Ficha_Papanic)
    Me.Controls.Add(Me.Ficha_MPF)
    Me.Controls.Add(Me.Ficha_VSA)
    Me.Controls.Add(Me.Ficha_MPFTipo1)
    Me.Controls.Add(Me.Ficha_MamograResult)
    Me.Controls.Add(Me.Ficha_HijosMuertos)
    Me.Controls.Add(Me.Ficha_EcoMamarioResult)
    Me.Controls.Add(Me.Ficha_HijosVivos)
    Me.Controls.Add(Me.Ficha_MamograAnios)
    Me.Controls.Add(Me.Ficha_ColposcopResult)
    Me.Controls.Add(Me.Ficha_EcoMamarioAnios)
    Me.Controls.Add(Me.Ficha_Abortos)
    Me.Controls.Add(Me.Ficha_ColposcopAnios)
    Me.Controls.Add(Me.Ficha_PapanicResult)
    Me.Controls.Add(Me.Ficha_PapanicAnios)
    Me.Controls.Add(Me.Ficha_Cesareas)
    Me.Controls.Add(Me.Ficha_Partos)
    Me.Controls.Add(Me.Ficha_Gestas)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Ficha_Ciclos)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Ficha_FUM)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Ficha_FecMenarq)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Label1)
    Me.Name = "CtlAntecedentesGinecoobstetricos"
    Me.Size = New System.Drawing.Size(965, 471)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_FecMenarq As DateTimePicker
  Friend WithEvents Label2 As Label
  Friend WithEvents Ficha_Ciclos As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Ficha_FUM As DateTimePicker
  Friend WithEvents Label4 As Label
  Friend WithEvents Ficha_Gestas As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Ficha_Partos As TextBox
  Friend WithEvents Label6 As Label
  Friend WithEvents Ficha_Cesareas As TextBox
  Friend WithEvents Label7 As Label
  Friend WithEvents Ficha_Abortos As TextBox
  Friend WithEvents Label8 As Label
  Friend WithEvents Ficha_HijosVivos As TextBox
  Friend WithEvents Label9 As Label
  Friend WithEvents Ficha_HijosMuertos As TextBox
  Friend WithEvents Ficha_VSA As CheckBox
  Friend WithEvents Ficha_MPF As CheckBox
  Friend WithEvents Ficha_MPFTipo1 As TextBox
  Friend WithEvents Ficha_Papanic As CheckBox
  Friend WithEvents Label10 As Label
  Friend WithEvents Ficha_PapanicAnios As TextBox
  Friend WithEvents Label11 As Label
  Friend WithEvents Ficha_PapanicResult As TextBox
  Friend WithEvents Ficha_ColposcopAnios As TextBox
  Friend WithEvents Ficha_ColposcopResult As TextBox
  Friend WithEvents Ficha_Colposcop As CheckBox
  Friend WithEvents Ficha_EcoMamarioAnios As TextBox
  Friend WithEvents Ficha_EcoMamarioResult As TextBox
  Friend WithEvents Ficha_EcoMamario As CheckBox
  Friend WithEvents Ficha_MamograAnios As TextBox
  Friend WithEvents Ficha_MamograResult As TextBox
  Friend WithEvents Ficha_Mamogra As CheckBox
  Friend WithEvents Label12 As Label
End Class
