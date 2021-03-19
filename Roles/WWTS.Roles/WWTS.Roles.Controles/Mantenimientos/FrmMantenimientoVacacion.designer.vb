<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoVacacion
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
    Me.components = New System.ComponentModel.Container()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfechadesde = New System.Windows.Forms.DateTimePicker()
    Me.dtfechahasta = New System.Windows.Forms.DateTimePicker()
    Me.txtDias = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chckLiquidado = New Infoware.Controles.Base.CheckBoxStd()
    Me.PnlLiquidado = New System.Windows.Forms.Panel()
    Me.PnlGoceVacaciones = New System.Windows.Forms.Panel()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.dtfechahastagocevaca = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.dtfechadesdegocevaca = New System.Windows.Forms.DateTimePicker()
    Me.checkgocevacaciones = New Infoware.Controles.Base.CheckBoxStd()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtValor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.ComboBoxPeriodoPago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.dtPeriodoPagoDesde = New System.Windows.Forms.DateTimePicker()

    Me.PnlLiquidado.SuspendLayout()
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
    Me.dtfechadesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechadesde.Location = New System.Drawing.Point(95, 12)
    Me.dtfechadesde.Name = "dtfechadesde"
    Me.dtfechadesde.Size = New System.Drawing.Size(130, 20)
    Me.dtfechadesde.TabIndex = 1
    '
    'dtfechahasta
    '
    Me.dtfechahasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechahasta.Location = New System.Drawing.Point(95, 39)
    Me.dtfechahasta.Name = "dtfechahasta"
    Me.dtfechahasta.Size = New System.Drawing.Size(130, 20)
    Me.dtfechahasta.TabIndex = 3
    '
    'txtDias
    '
    Me.txtDias.Location = New System.Drawing.Point(95, 66)
    Me.txtDias.Mensaje = ""
    Me.txtDias.Name = "txtDias"
    Me.txtDias.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDias.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtDias.PromptText = ""
    Me.txtDias.Size = New System.Drawing.Size(130, 20)
    Me.txtDias.TabIndex = 5
    Me.txtDias.Text = "0"
    Me.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtDias.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtDias.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtDias.Value = 0.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(20, 69)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(33, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Días:"
    '
    'chckLiquidado
    '
    Me.chckLiquidado.AutoSize = True
    Me.chckLiquidado.Enabled = False
    Me.chckLiquidado.Location = New System.Drawing.Point(95, 93)
    Me.chckLiquidado.Name = "chckLiquidado"
    Me.chckLiquidado.Size = New System.Drawing.Size(72, 17)
    Me.chckLiquidado.TabIndex = 6
    Me.chckLiquidado.Text = "Liquidado"
    Me.chckLiquidado.UseVisualStyleBackColor = True
    '
    'PnlLiquidado
    '
    Me.PnlLiquidado.Controls.Add(Me.PnlGoceVacaciones)
    Me.PnlLiquidado.Controls.Add(Me.checkgocevacaciones)
    Me.PnlLiquidado.Controls.Add(Me.Label6)
    Me.PnlLiquidado.Controls.Add(Me.txtValor)
    Me.PnlLiquidado.Controls.Add(Me.Label4)
    Me.PnlLiquidado.Controls.Add(Me.Label5)
    Me.PnlLiquidado.Controls.Add(Me.ComboBoxPeriodoPago)
    Me.PnlLiquidado.Controls.Add(Me.dtPeriodoPagoDesde)
    Me.PnlLiquidado.Location = New System.Drawing.Point(12, 117)
    Me.PnlLiquidado.Name = "PnlLiquidado"
    Me.PnlLiquidado.Size = New System.Drawing.Size(228, 172)
    Me.PnlLiquidado.TabIndex = 7
    Me.PnlLiquidado.Visible = False
    '
    'PnlGoceVacaciones
    '
    Me.PnlGoceVacaciones.Controls.Add(Me.Label8)
    Me.PnlGoceVacaciones.Controls.Add(Me.dtfechahastagocevaca)
    Me.PnlGoceVacaciones.Controls.Add(Me.Label7)
    Me.PnlGoceVacaciones.Controls.Add(Me.dtfechadesdegocevaca)
    Me.PnlGoceVacaciones.Location = New System.Drawing.Point(4, 105)
    Me.PnlGoceVacaciones.Name = "PnlGoceVacaciones"
    Me.PnlGoceVacaciones.Size = New System.Drawing.Size(221, 63)
    Me.PnlGoceVacaciones.TabIndex = 8
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(3, 44)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(71, 13)
    Me.Label8.TabIndex = 2
    Me.Label8.Text = "Fecha Hasta:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'dtfechahastagocevaca
    '
    Me.dtfechahastagocevaca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechahastagocevaca.Location = New System.Drawing.Point(83, 38)
    Me.dtfechahastagocevaca.Name = "dtfechahastagocevaca"
    Me.dtfechahastagocevaca.Size = New System.Drawing.Size(130, 20)
    Me.dtfechahastagocevaca.TabIndex = 3
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(3, 10)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(74, 13)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Fecha Desde:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'dtfechadesdegocevaca
    '
    Me.dtfechadesdegocevaca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechadesdegocevaca.Location = New System.Drawing.Point(82, 4)
    Me.dtfechadesdegocevaca.Name = "dtfechadesdegocevaca"
    Me.dtfechadesdegocevaca.Size = New System.Drawing.Size(130, 20)
    Me.dtfechadesdegocevaca.TabIndex = 1
    '
    'checkgocevacaciones
    '
    Me.checkgocevacaciones.AutoSize = True
    Me.checkgocevacaciones.Checked = True
    Me.checkgocevacaciones.CheckState = System.Windows.Forms.CheckState.Checked
    Me.checkgocevacaciones.Location = New System.Drawing.Point(83, 87)
    Me.checkgocevacaciones.Name = "checkgocevacaciones"
    Me.checkgocevacaciones.Size = New System.Drawing.Size(111, 17)
    Me.checkgocevacaciones.TabIndex = 7
    Me.checkgocevacaciones.Text = "Goce Vacaciones"
    Me.checkgocevacaciones.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(8, 64)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(34, 13)
    Me.Label6.TabIndex = 4
    Me.Label6.Text = "Valor:"
    '
    'txtValor
    '
    Me.txtValor.Location = New System.Drawing.Point(83, 61)
    Me.txtValor.Mensaje = ""
    Me.txtValor.Name = "txtValor"
    Me.txtValor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtValor.PromptText = ""
    Me.txtValor.Size = New System.Drawing.Size(130, 20)
    Me.txtValor.TabIndex = 5
    Me.txtValor.Text = "0,00"
    Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtValor.Value = 0.0R
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(8, 4)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(71, 26)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Periodo Pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desde:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(8, 36)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(74, 13)
    Me.Label5.TabIndex = 2
    Me.Label5.Text = "Periodo Pago:"
    '
    'ComboBoxPeriodoPago
    '
    Me.ComboBoxPeriodoPago.AbriralEntrar = False
    Me.ComboBoxPeriodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxPeriodoPago.FormattingEnabled = True
    Me.ComboBoxPeriodoPago.Location = New System.Drawing.Point(83, 33)
    Me.ComboBoxPeriodoPago.Name = "ComboBoxPeriodoPago"
    Me.ComboBoxPeriodoPago.OperadorDatos = Nothing
    Me.ComboBoxPeriodoPago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxPeriodoPago.ParametroDet = Nothing
    Me.ComboBoxPeriodoPago.PuedeActualizar = True
    Me.ComboBoxPeriodoPago.PuedeEliminar = True
    Me.ComboBoxPeriodoPago.PuedeModificar = True
    Me.ComboBoxPeriodoPago.PuedeNuevo = True
    Me.ComboBoxPeriodoPago.Size = New System.Drawing.Size(130, 21)
    Me.ComboBoxPeriodoPago.TabIndex = 3
    '
    'dtPeriodoPagoDesde
    '
    Me.dtPeriodoPagoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtPeriodoPagoDesde.Location = New System.Drawing.Point(83, 6)
    Me.dtPeriodoPagoDesde.Name = "dtPeriodoPagoDesde"
    Me.dtPeriodoPagoDesde.Size = New System.Drawing.Size(130, 20)
    Me.dtPeriodoPagoDesde.TabIndex = 1
    '
    'FrmMantenimientoVacacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(244, 332)
    Me.Controls.Add(Me.PnlLiquidado)
    Me.Controls.Add(Me.chckLiquidado)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtDias)
    Me.Controls.Add(Me.dtfechahasta)
    Me.Controls.Add(Me.dtfechadesde)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmMantenimientoVacacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Periodo Vacación"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.dtfechadesde, 0)
    Me.Controls.SetChildIndex(Me.dtfechahasta, 0)
    Me.Controls.SetChildIndex(Me.txtDias, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.chckLiquidado, 0)
    Me.Controls.SetChildIndex(Me.PnlLiquidado, 0)

    Me.PnlLiquidado.ResumeLayout(False)
    Me.PnlLiquidado.PerformLayout()
    Me.PnlGoceVacaciones.ResumeLayout(False)
    Me.PnlGoceVacaciones.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfechadesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfechahasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtDias As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chckLiquidado As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents PnlLiquidado As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxPeriodoPago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents dtPeriodoPagoDesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtValor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents checkgocevacaciones As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents PnlGoceVacaciones As System.Windows.Forms.Panel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents dtfechahastagocevaca As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents dtfechadesdegocevaca As System.Windows.Forms.DateTimePicker
End Class
