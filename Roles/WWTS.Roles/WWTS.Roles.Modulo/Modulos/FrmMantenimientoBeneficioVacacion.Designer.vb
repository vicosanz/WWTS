<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoBeneficioVacacion
  Inherits Infoware.Consola.Base.FrmDialogoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfechadesde = New System.Windows.Forms.DateTimePicker()
    Me.dtfechahasta = New System.Windows.Forms.DateTimePicker()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtValorVacacion = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtAporte935 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtValorFinal = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtObservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.checkgocevacaciones = New Infoware.Controles.Base.CheckBoxStd()
    Me.PnlGoceVacaciones = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.dtfechahastagocevaca = New System.Windows.Forms.DateTimePicker()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.dtfechadesdegocevaca = New System.Windows.Forms.DateTimePicker()
    Me.CtlPeriodo1 = New CtlPeriodo()
    Me.PnlGoceVacaciones.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(20, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Desde:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(20, 42)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Hasta:"
    '
    'dtfechadesde
    '
    Me.dtfechadesde.Enabled = False
    Me.dtfechadesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechadesde.Location = New System.Drawing.Point(102, 12)
    Me.dtfechadesde.Name = "dtfechadesde"
    Me.dtfechadesde.Size = New System.Drawing.Size(130, 20)
    Me.dtfechadesde.TabIndex = 1
    '
    'dtfechahasta
    '
    Me.dtfechahasta.Enabled = False
    Me.dtfechahasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechahasta.Location = New System.Drawing.Point(102, 39)
    Me.dtfechahasta.Name = "dtfechahasta"
    Me.dtfechahasta.Size = New System.Drawing.Size(130, 20)
    Me.dtfechahasta.TabIndex = 3
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(20, 150)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(82, 13)
    Me.Label6.TabIndex = 6
    Me.Label6.Text = "Valor Vacación:"
    '
    'txtValorVacacion
    '
    Me.txtValorVacacion.Location = New System.Drawing.Point(102, 147)
    Me.txtValorVacacion.Mensaje = ""
    Me.txtValorVacacion.Name = "txtValorVacacion"
    Me.txtValorVacacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValorVacacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtValorVacacion.PromptText = ""
    Me.txtValorVacacion.Size = New System.Drawing.Size(130, 20)
    Me.txtValorVacacion.TabIndex = 7
    Me.txtValorVacacion.Text = "0.00"
    Me.txtValorVacacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtValorVacacion.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtValorVacacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtValorVacacion.Value = 0.0R
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(20, 85)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(74, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Periodo Pago:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(20, 176)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(73, 13)
    Me.Label7.TabIndex = 8
    Me.Label7.Text = "Aporte 9.35%:"
    Me.Label7.Visible = False
    '
    'txtAporte935
    '
    Me.txtAporte935.Enabled = False
    Me.txtAporte935.Location = New System.Drawing.Point(102, 173)
    Me.txtAporte935.Mensaje = ""
    Me.txtAporte935.Name = "txtAporte935"
    Me.txtAporte935.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAporte935.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtAporte935.PromptText = ""
    Me.txtAporte935.Size = New System.Drawing.Size(130, 20)
    Me.txtAporte935.TabIndex = 9
    Me.txtAporte935.Text = "0.00"
    Me.txtAporte935.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtAporte935.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtAporte935.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtAporte935.Value = 0.0R
    Me.txtAporte935.Visible = False
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(20, 202)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(59, 13)
    Me.Label8.TabIndex = 10
    Me.Label8.Text = "Valor Final:"
    '
    'txtValorFinal
    '
    Me.txtValorFinal.Location = New System.Drawing.Point(102, 199)
    Me.txtValorFinal.Mensaje = ""
    Me.txtValorFinal.Name = "txtValorFinal"
    Me.txtValorFinal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValorFinal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtValorFinal.PromptText = ""
    Me.txtValorFinal.Size = New System.Drawing.Size(130, 20)
    Me.txtValorFinal.TabIndex = 11
    Me.txtValorFinal.Text = "0.00"
    Me.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtValorFinal.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtValorFinal.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtValorFinal.Value = 0.0R
    '
    'txtObservacion
    '
    Me.txtObservacion.Location = New System.Drawing.Point(102, 225)
    Me.txtObservacion.Mensaje = ""
    Me.txtObservacion.Multiline = True
    Me.txtObservacion.Name = "txtObservacion"
    Me.txtObservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtObservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtObservacion.PromptText = ""
    Me.txtObservacion.Size = New System.Drawing.Size(275, 75)
    Me.txtObservacion.TabIndex = 13
    Me.txtObservacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(20, 225)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(70, 13)
    Me.Label9.TabIndex = 12
    Me.Label9.Text = "Observación:"
    '
    'checkgocevacaciones
    '
    Me.checkgocevacaciones.AutoSize = True
    Me.checkgocevacaciones.Location = New System.Drawing.Point(102, 308)
    Me.checkgocevacaciones.Name = "checkgocevacaciones"
    Me.checkgocevacaciones.Size = New System.Drawing.Size(111, 17)
    Me.checkgocevacaciones.TabIndex = 14
    Me.checkgocevacaciones.Text = "Goce Vacaciones"
    Me.checkgocevacaciones.UseVisualStyleBackColor = True
    '
    'PnlGoceVacaciones
    '
    Me.PnlGoceVacaciones.Controls.Add(Me.Label3)
    Me.PnlGoceVacaciones.Controls.Add(Me.dtfechahastagocevaca)
    Me.PnlGoceVacaciones.Controls.Add(Me.Label5)
    Me.PnlGoceVacaciones.Controls.Add(Me.dtfechadesdegocevaca)
    Me.PnlGoceVacaciones.Location = New System.Drawing.Point(102, 328)
    Me.PnlGoceVacaciones.Name = "PnlGoceVacaciones"
    Me.PnlGoceVacaciones.Size = New System.Drawing.Size(215, 60)
    Me.PnlGoceVacaciones.TabIndex = 15
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 44)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(71, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Fecha Hasta:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'dtfechahastagocevaca
    '
    Me.dtfechahastagocevaca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechahastagocevaca.Location = New System.Drawing.Point(83, 38)
    Me.dtfechahastagocevaca.Name = "dtfechahastagocevaca"
    Me.dtfechahastagocevaca.Size = New System.Drawing.Size(130, 20)
    Me.dtfechahastagocevaca.TabIndex = 3
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(3, 10)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(74, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Fecha Desde:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'dtfechadesdegocevaca
    '
    Me.dtfechadesdegocevaca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechadesdegocevaca.Location = New System.Drawing.Point(82, 4)
    Me.dtfechadesdegocevaca.Name = "dtfechadesdegocevaca"
    Me.dtfechadesdegocevaca.Size = New System.Drawing.Size(130, 20)
    Me.dtfechadesdegocevaca.TabIndex = 1
    '
    'CtlPeriodo1
    '
    Me.CtlPeriodo1.FormattingEnabled = True
    Me.CtlPeriodo1.Location = New System.Drawing.Point(102, 80)
    Me.CtlPeriodo1.Name = "CtlPeriodo1"
    Me.CtlPeriodo1.Op = Nothing
    Me.CtlPeriodo1.PardetPeriodoPago = Nothing
    Me.CtlPeriodo1.PeriodoPago = Nothing
    Me.CtlPeriodo1.PuedeActualizar = True
    Me.CtlPeriodo1.PuedeEliminar = True
    Me.CtlPeriodo1.PuedeModificar = True
    Me.CtlPeriodo1.PuedeNuevo = True
    Me.CtlPeriodo1.Size = New System.Drawing.Size(195, 56)
    Me.CtlPeriodo1.TabIndex = 5
    '
    'FrmMantenimientoBeneficioVacacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(394, 427)
    Me.Controls.Add(Me.PnlGoceVacaciones)
    Me.Controls.Add(Me.checkgocevacaciones)
    Me.Controls.Add(Me.CtlPeriodo1)
    Me.Controls.Add(Me.txtObservacion)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtValorFinal)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtAporte935)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtValorVacacion)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.dtfechahasta)
    Me.Controls.Add(Me.dtfechadesde)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmMantenimientoBeneficioVacacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Periodo Vacación"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.dtfechadesde, 0)
    Me.Controls.SetChildIndex(Me.dtfechahasta, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.txtValorVacacion, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.txtAporte935, 0)
    Me.Controls.SetChildIndex(Me.Label7, 0)
    Me.Controls.SetChildIndex(Me.txtValorFinal, 0)
    Me.Controls.SetChildIndex(Me.Label8, 0)
    Me.Controls.SetChildIndex(Me.Label9, 0)
    Me.Controls.SetChildIndex(Me.txtObservacion, 0)
    Me.Controls.SetChildIndex(Me.CtlPeriodo1, 0)
    Me.Controls.SetChildIndex(Me.checkgocevacaciones, 0)
    Me.Controls.SetChildIndex(Me.PnlGoceVacaciones, 0)
    Me.PnlGoceVacaciones.ResumeLayout(False)
    Me.PnlGoceVacaciones.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfechadesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfechahasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtValorVacacion As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtAporte935 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtValorFinal As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtObservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents CtlPeriodo1 As CtlPeriodo
  Friend WithEvents checkgocevacaciones As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents PnlGoceVacaciones As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents dtfechahastagocevaca As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents dtfechadesdegocevaca As System.Windows.Forms.DateTimePicker
End Class
