<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoVario
  Inherits Infoware.Consola.Base.FrmDialogoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.cbotipopago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.btnpersona = New Infoware.Controles.Base.ButtonStd()
    Me.rdoconcodigo = New System.Windows.Forms.RadioButton()
    Me.txtbeneficiario = New Infoware.Controles.Base.TextBoxStd()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.rdosincodigo = New System.Windows.Forms.RadioButton()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtvalor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.CtlBuscaEmpleado1 = New CtlBuscaEmpleado()
    Me.chkmostrarenprovisiones = New System.Windows.Forms.CheckBox()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cbotipopago
    '
    Me.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipopago.Location = New System.Drawing.Point(93, 202)
    Me.cbotipopago.Name = "cbotipopago"
    Me.cbotipopago.OperadorDatos = Nothing
    Me.cbotipopago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipopago.ParametroDet = Nothing
    Me.cbotipopago.PuedeActualizar = True
    Me.cbotipopago.PuedeEliminar = True
    Me.cbotipopago.PuedeModificar = True
    Me.cbotipopago.PuedeNuevo = True
    Me.cbotipopago.Size = New System.Drawing.Size(291, 21)
    Me.cbotipopago.TabIndex = 12
    '
    'btnpersona
    '
    Me.btnpersona.Location = New System.Drawing.Point(32, 36)
    Me.btnpersona.Name = "btnpersona"
    Me.btnpersona.Size = New System.Drawing.Size(352, 44)
    Me.btnpersona.TabIndex = 1
    Me.btnpersona.Text = "Clic aquí para seleccionar persona"
    Me.btnpersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'rdoconcodigo
    '
    Me.rdoconcodigo.AutoSize = True
    Me.rdoconcodigo.Checked = True
    Me.rdoconcodigo.Location = New System.Drawing.Point(12, 12)
    Me.rdoconcodigo.Name = "rdoconcodigo"
    Me.rdoconcodigo.Size = New System.Drawing.Size(136, 17)
    Me.rdoconcodigo.TabIndex = 0
    Me.rdoconcodigo.TabStop = True
    Me.rdoconcodigo.Text = "Beneficiario con código"
    '
    'txtbeneficiario
    '
    Me.txtbeneficiario.Enabled = False
    Me.txtbeneficiario.Location = New System.Drawing.Point(108, 112)
    Me.txtbeneficiario.Mensaje = ""
    Me.txtbeneficiario.Name = "txtbeneficiario"
    Me.txtbeneficiario.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbeneficiario.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbeneficiario.PromptText = ""
    Me.txtbeneficiario.Size = New System.Drawing.Size(276, 20)
    Me.txtbeneficiario.TabIndex = 4
    '
    'txtobservacion
    '
    Me.txtobservacion.Location = New System.Drawing.Point(93, 176)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(291, 20)
    Me.txtobservacion.TabIndex = 8
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(38, 115)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Beneficiario:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 153)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(34, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Valor:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 179)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(70, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Observación:"
    '
    'rdosincodigo
    '
    Me.rdosincodigo.AutoSize = True
    Me.rdosincodigo.Location = New System.Drawing.Point(12, 86)
    Me.rdosincodigo.Name = "rdosincodigo"
    Me.rdosincodigo.Size = New System.Drawing.Size(131, 17)
    Me.rdosincodigo.TabIndex = 2
    Me.rdosincodigo.Text = "Beneficiario sin código"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(9, 205)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(73, 13)
    Me.Label5.TabIndex = 11
    Me.Label5.Text = "Tipo de pago:"
    '
    'txtvalor
    '
    Me.txtvalor.Location = New System.Drawing.Point(93, 150)
    Me.txtvalor.Mensaje = ""
    Me.txtvalor.Name = "txtvalor"
    Me.txtvalor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalor.PromptText = ""
    Me.txtvalor.Size = New System.Drawing.Size(100, 20)
    Me.txtvalor.TabIndex = 6
    Me.txtvalor.Text = "0,00"
    Me.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalor.Value = 0.0R
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleado1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(0, 0)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Op = Nothing
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(10, 349)
    Me.CtlBuscaEmpleado1.TabIndex = 1001
    Me.CtlBuscaEmpleado1.Visible = False
    '
    'chkmostrarenprovisiones
    '
    Me.chkmostrarenprovisiones.AutoSize = True
    Me.chkmostrarenprovisiones.Location = New System.Drawing.Point(93, 230)
    Me.chkmostrarenprovisiones.Name = "chkmostrarenprovisiones"
    Me.chkmostrarenprovisiones.Size = New System.Drawing.Size(132, 17)
    Me.chkmostrarenprovisiones.TabIndex = 1002
    Me.chkmostrarenprovisiones.Text = "Mostrar en provisiones"
    Me.chkmostrarenprovisiones.UseVisualStyleBackColor = True
    '
    'FrmPagoVario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(396, 386)
    Me.Controls.Add(Me.chkmostrarenprovisiones)
    Me.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.Controls.Add(Me.txtvalor)
    Me.Controls.Add(Me.cbotipopago)
    Me.Controls.Add(Me.btnpersona)
    Me.Controls.Add(Me.rdoconcodigo)
    Me.Controls.Add(Me.txtbeneficiario)
    Me.Controls.Add(Me.txtobservacion)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.rdosincodigo)
    Me.Controls.Add(Me.Label5)
    Me.Name = "FrmPagoVario"
    Me.Text = "Pagos Varios"
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.rdosincodigo, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtobservacion, 0)
    Me.Controls.SetChildIndex(Me.txtbeneficiario, 0)
    Me.Controls.SetChildIndex(Me.rdoconcodigo, 0)
    Me.Controls.SetChildIndex(Me.btnpersona, 0)
    Me.Controls.SetChildIndex(Me.cbotipopago, 0)
    Me.Controls.SetChildIndex(Me.txtvalor, 0)
    Me.Controls.SetChildIndex(Me.CtlBuscaEmpleado1, 0)
    Me.Controls.SetChildIndex(Me.chkmostrarenprovisiones, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbotipopago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents btnpersona As Infoware.Controles.Base.ButtonStd
  Friend WithEvents rdoconcodigo As System.Windows.Forms.RadioButton
  Friend WithEvents txtbeneficiario As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents rdosincodigo As System.Windows.Forms.RadioButton
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtvalor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents CtlBuscaEmpleado1 As CtlBuscaEmpleado
  Friend WithEvents chkmostrarenprovisiones As System.Windows.Forms.CheckBox

End Class
