Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlAccidentesTrabajo
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
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Ficha_AntTrabCalif = New System.Windows.Forms.CheckBox()
    Me.Ficha_AntTrabCalifDescripcion = New System.Windows.Forms.TextBox()
    Me.Ficha_AntTrabCalifFecha = New System.Windows.Forms.DateTimePicker()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Ficha_AntTrabCalifObservacion = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Ficha_AntTrabCalifNoReportado = New System.Windows.Forms.TextBox()
    Me.Ficha_EnfProfCalif = New System.Windows.Forms.CheckBox()
    Me.Ficha_EnfProfCalifDescripcion = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Ficha_EnfProfCalifFecha = New System.Windows.Forms.DateTimePicker()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Ficha_EnfProfCalifObservacion = New System.Windows.Forms.TextBox()
    Me.Ficha_EnfProfCalifNoReportado = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(206, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "ACCIDENTES DE TRABAJO"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(3, 212)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(266, 17)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "ENFERMEDADES PROFESIONALES"
    '
    'Ficha_AntTrabCalif
    '
    Me.Ficha_AntTrabCalif.AutoSize = True
    Me.Ficha_AntTrabCalif.Location = New System.Drawing.Point(6, 20)
    Me.Ficha_AntTrabCalif.Name = "Ficha_AntTrabCalif"
    Me.Ficha_AntTrabCalif.Size = New System.Drawing.Size(448, 21)
    Me.Ficha_AntTrabCalif.TabIndex = 1
    Me.Ficha_AntTrabCalif.Text = "Fué calificado por el Instituto de Seguridad Social correspondiente"
    Me.Ficha_AntTrabCalif.UseVisualStyleBackColor = True
    '
    'Ficha_AntTrabCalifDescripcion
    '
    Me.Ficha_AntTrabCalifDescripcion.Location = New System.Drawing.Point(6, 47)
    Me.Ficha_AntTrabCalifDescripcion.Name = "Ficha_AntTrabCalifDescripcion"
    Me.Ficha_AntTrabCalifDescripcion.Size = New System.Drawing.Size(448, 22)
    Me.Ficha_AntTrabCalifDescripcion.TabIndex = 2
    '
    'Ficha_AntTrabCalifFecha
    '
    Me.Ficha_AntTrabCalifFecha.Location = New System.Drawing.Point(556, 47)
    Me.Ficha_AntTrabCalifFecha.Name = "Ficha_AntTrabCalifFecha"
    Me.Ficha_AntTrabCalifFecha.Size = New System.Drawing.Size(249, 22)
    Me.Ficha_AntTrabCalifFecha.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(470, 50)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(47, 17)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Fecha"
    '
    'Ficha_AntTrabCalifObservacion
    '
    Me.Ficha_AntTrabCalifObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_AntTrabCalifObservacion.Location = New System.Drawing.Point(150, 75)
    Me.Ficha_AntTrabCalifObservacion.Multiline = True
    Me.Ficha_AntTrabCalifObservacion.Name = "Ficha_AntTrabCalifObservacion"
    Me.Ficha_AntTrabCalifObservacion.Size = New System.Drawing.Size(742, 59)
    Me.Ficha_AntTrabCalifObservacion.TabIndex = 6
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(3, 72)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(88, 17)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "Observación"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 137)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(93, 34)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "No calificado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o reportado"
    '
    'Ficha_AntTrabCalifNoReportado
    '
    Me.Ficha_AntTrabCalifNoReportado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_AntTrabCalifNoReportado.Location = New System.Drawing.Point(150, 140)
    Me.Ficha_AntTrabCalifNoReportado.Multiline = True
    Me.Ficha_AntTrabCalifNoReportado.Name = "Ficha_AntTrabCalifNoReportado"
    Me.Ficha_AntTrabCalifNoReportado.Size = New System.Drawing.Size(742, 59)
    Me.Ficha_AntTrabCalifNoReportado.TabIndex = 8
    '
    'CheckBox1
    '
    Me.Ficha_EnfProfCalif.AutoSize = True
    Me.Ficha_EnfProfCalif.Location = New System.Drawing.Point(6, 232)
    Me.Ficha_EnfProfCalif.Name = "CheckBox1"
    Me.Ficha_EnfProfCalif.Size = New System.Drawing.Size(448, 21)
    Me.Ficha_EnfProfCalif.TabIndex = 10
    Me.Ficha_EnfProfCalif.Text = "Fué calificado por el Instituto de Seguridad Social correspondiente"
    Me.Ficha_EnfProfCalif.UseVisualStyleBackColor = True
    '
    'TextBox2
    '
    Me.Ficha_EnfProfCalifDescripcion.Location = New System.Drawing.Point(6, 259)
    Me.Ficha_EnfProfCalifDescripcion.Name = "TextBox2"
    Me.Ficha_EnfProfCalifDescripcion.Size = New System.Drawing.Size(448, 22)
    Me.Ficha_EnfProfCalifDescripcion.TabIndex = 11
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(470, 262)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(47, 17)
    Me.Label4.TabIndex = 12
    Me.Label4.Text = "Fecha"
    '
    'DateTimePicker1
    '
    Me.Ficha_EnfProfCalifFecha.Location = New System.Drawing.Point(556, 259)
    Me.Ficha_EnfProfCalifFecha.Name = "DateTimePicker1"
    Me.Ficha_EnfProfCalifFecha.Size = New System.Drawing.Size(249, 22)
    Me.Ficha_EnfProfCalifFecha.TabIndex = 13
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(3, 284)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(88, 17)
    Me.Label5.TabIndex = 14
    Me.Label5.Text = "Observación"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(3, 349)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(93, 34)
    Me.Label7.TabIndex = 16
    Me.Label7.Text = "No calificado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o reportado"
    '
    'TextBox3
    '
    Me.Ficha_EnfProfCalifObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_EnfProfCalifObservacion.Location = New System.Drawing.Point(150, 287)
    Me.Ficha_EnfProfCalifObservacion.Multiline = True
    Me.Ficha_EnfProfCalifObservacion.Name = "TextBox3"
    Me.Ficha_EnfProfCalifObservacion.Size = New System.Drawing.Size(742, 59)
    Me.Ficha_EnfProfCalifObservacion.TabIndex = 15
    '
    'TextBox4
    '
    Me.Ficha_EnfProfCalifNoReportado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ficha_EnfProfCalifNoReportado.Location = New System.Drawing.Point(150, 352)
    Me.Ficha_EnfProfCalifNoReportado.Multiline = True
    Me.Ficha_EnfProfCalifNoReportado.Name = "TextBox4"
    Me.Ficha_EnfProfCalifNoReportado.Size = New System.Drawing.Size(742, 59)
    Me.Ficha_EnfProfCalifNoReportado.TabIndex = 17
    '
    'CtlAccidentesTrabajo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_EnfProfCalifNoReportado)
    Me.Controls.Add(Me.Ficha_AntTrabCalifNoReportado)
    Me.Controls.Add(Me.Ficha_EnfProfCalifObservacion)
    Me.Controls.Add(Me.Ficha_AntTrabCalifObservacion)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Ficha_EnfProfCalifFecha)
    Me.Controls.Add(Me.Ficha_AntTrabCalifFecha)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Ficha_EnfProfCalifDescripcion)
    Me.Controls.Add(Me.Ficha_AntTrabCalifDescripcion)
    Me.Controls.Add(Me.Ficha_EnfProfCalif)
    Me.Controls.Add(Me.Ficha_AntTrabCalif)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label12)
    Me.Name = "CtlAccidentesTrabajo"
    Me.Size = New System.Drawing.Size(898, 526)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label12 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Ficha_AntTrabCalif As CheckBox
  Friend WithEvents Ficha_AntTrabCalifDescripcion As TextBox
  Friend WithEvents Ficha_AntTrabCalifFecha As DateTimePicker
  Friend WithEvents Label3 As Label
  Friend WithEvents Ficha_AntTrabCalifObservacion As TextBox
  Friend WithEvents Label6 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Ficha_AntTrabCalifNoReportado As TextBox
  Friend WithEvents Ficha_EnfProfCalif As CheckBox
  Friend WithEvents Ficha_EnfProfCalifDescripcion As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Ficha_EnfProfCalifFecha As DateTimePicker
  Friend WithEvents Label5 As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents Ficha_EnfProfCalifObservacion As TextBox
  Friend WithEvents Ficha_EnfProfCalifNoReportado As TextBox
End Class
