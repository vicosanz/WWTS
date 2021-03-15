<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRubroDet
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Me.txtValor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtPeriodoPagofecha = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtObservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.dtRubDetfecha = New System.Windows.Forms.DateTimePicker()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.ComboBoxTipoPeriodoPago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.ComboBoxPeriodoPago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtCantidad = New Infoware.Controles.Base.TextBoxCalculator()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtValor
    '
    Me.txtValor.Location = New System.Drawing.Point(132, 62)
    Me.txtValor.Mensaje = ""
    Me.txtValor.Name = "txtValor"
    Me.txtValor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtValor.PromptText = ""
    Me.txtValor.Size = New System.Drawing.Size(130, 20)
    Me.txtValor.TabIndex = 1
    Me.txtValor.Text = "0.00"
    Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtValor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtValor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtValor.Value = 0.0R
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(20, 65)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(34, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Valor:"
    '
    'dtPeriodoPagofecha
    '
    Me.dtPeriodoPagofecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtPeriodoPagofecha.Location = New System.Drawing.Point(132, 89)
    Me.dtPeriodoPagofecha.Name = "dtPeriodoPagofecha"
    Me.dtPeriodoPagofecha.Size = New System.Drawing.Size(130, 20)
    Me.dtPeriodoPagofecha.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(20, 92)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(108, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Periodo Pago Desde:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(20, 119)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(74, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Periodo Pago:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(20, 147)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(98, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Tipo Periodo Pago:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(20, 175)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(70, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Observación:"
    '
    'txtObservacion
    '
    Me.txtObservacion.Location = New System.Drawing.Point(132, 172)
    Me.txtObservacion.Mensaje = ""
    Me.txtObservacion.Multiline = True
    Me.txtObservacion.Name = "txtObservacion"
    Me.txtObservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtObservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtObservacion.PromptText = ""
    Me.txtObservacion.Size = New System.Drawing.Size(275, 50)
    Me.txtObservacion.TabIndex = 9
    Me.txtObservacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'dtRubDetfecha
    '
    Me.dtRubDetfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtRubDetfecha.Location = New System.Drawing.Point(132, 229)
    Me.dtRubDetfecha.Name = "dtRubDetfecha"
    Me.dtRubDetfecha.Size = New System.Drawing.Size(130, 20)
    Me.dtRubDetfecha.TabIndex = 11
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(20, 232)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(40, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Fecha:"
    '
    'ComboBoxTipoPeriodoPago
    '
    Me.ComboBoxTipoPeriodoPago.AbriralEntrar = False
    Me.ComboBoxTipoPeriodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoPeriodoPago.FormattingEnabled = True
    Me.ComboBoxTipoPeriodoPago.Location = New System.Drawing.Point(132, 144)
    Me.ComboBoxTipoPeriodoPago.Name = "ComboBoxTipoPeriodoPago"
    Me.ComboBoxTipoPeriodoPago.OperadorDatos = Nothing
    Me.ComboBoxTipoPeriodoPago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoPeriodoPago.ParametroDet = Nothing
    Me.ComboBoxTipoPeriodoPago.PuedeActualizar = True
    Me.ComboBoxTipoPeriodoPago.PuedeEliminar = True
    Me.ComboBoxTipoPeriodoPago.PuedeModificar = True
    Me.ComboBoxTipoPeriodoPago.PuedeNuevo = True
    Me.ComboBoxTipoPeriodoPago.Size = New System.Drawing.Size(130, 21)
    Me.ComboBoxTipoPeriodoPago.TabIndex = 7
    '
    'ComboBoxPeriodoPago
    '
    Me.ComboBoxPeriodoPago.AbriralEntrar = False
    Me.ComboBoxPeriodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxPeriodoPago.FormattingEnabled = True
    Me.ComboBoxPeriodoPago.Location = New System.Drawing.Point(132, 116)
    Me.ComboBoxPeriodoPago.Name = "ComboBoxPeriodoPago"
    Me.ComboBoxPeriodoPago.OperadorDatos = Nothing
    Me.ComboBoxPeriodoPago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxPeriodoPago.ParametroDet = Nothing
    Me.ComboBoxPeriodoPago.PuedeActualizar = True
    Me.ComboBoxPeriodoPago.PuedeEliminar = True
    Me.ComboBoxPeriodoPago.PuedeModificar = True
    Me.ComboBoxPeriodoPago.PuedeNuevo = True
    Me.ComboBoxPeriodoPago.Size = New System.Drawing.Size(130, 21)
    Me.ComboBoxPeriodoPago.TabIndex = 5
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(20, 259)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(52, 13)
    Me.Label7.TabIndex = 12
    Me.Label7.Text = "Cantidad:"
    '
    'txtCantidad
    '
    Me.txtCantidad.Location = New System.Drawing.Point(132, 256)
    Me.txtCantidad.Mensaje = ""
    Me.txtCantidad.Name = "txtCantidad"
    Me.txtCantidad.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCantidad.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtCantidad.PromptText = ""
    Me.txtCantidad.Size = New System.Drawing.Size(130, 20)
    Me.txtCantidad.TabIndex = 13
    Me.txtCantidad.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtCantidad.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtCantidad.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtCantidad.Value = 0.0R
    '
    'FrmRubroDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(424, 282)
    Me.Controls.Add(Me.txtCantidad)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.dtRubDetfecha)
    Me.Controls.Add(Me.txtObservacion)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.ComboBoxTipoPeriodoPago)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.ComboBoxPeriodoPago)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dtPeriodoPagofecha)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtValor)
    Me.Name = "FrmRubroDet"
    Me.PuedeGuardar = True
    Me.PuedeGuardaryCerrar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Rubro Detalle"
    Me.Controls.SetChildIndex(Me.txtValor, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.dtPeriodoPagofecha, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxPeriodoPago, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxTipoPeriodoPago, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.txtObservacion, 0)
    Me.Controls.SetChildIndex(Me.dtRubDetfecha, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.Label7, 0)
    Me.Controls.SetChildIndex(Me.txtCantidad, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtValor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtPeriodoPagofecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxPeriodoPago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoPeriodoPago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtObservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents dtRubDetfecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtCantidad As Infoware.Controles.Base.TextBoxCalculator
End Class
