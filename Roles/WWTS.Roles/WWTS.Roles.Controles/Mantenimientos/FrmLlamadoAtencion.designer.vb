<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLlamadaAtencion
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
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.dtfecha = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.chcksancionado = New System.Windows.Forms.CheckBox()
    Me.cbogravedadllamado = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cbotipollamado = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.SuspendLayout()
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(15, 15)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(40, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Fecha:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(15, 70)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(66, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(174, 67)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Multiline = True
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(320, 89)
    Me.txtdescripcion.TabIndex = 5
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(15, 42)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(144, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Tipo de llamada de atención:"
    '
    'dtfecha
    '
    Me.dtfecha.Location = New System.Drawing.Point(174, 12)
    Me.dtfecha.Name = "dtfecha"
    Me.dtfecha.Size = New System.Drawing.Size(200, 20)
    Me.dtfecha.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 166)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(155, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Gravedad llamada de atención:"
    '
    'chcksancionado
    '
    Me.chcksancionado.AutoSize = True
    Me.chcksancionado.Location = New System.Drawing.Point(174, 191)
    Me.chcksancionado.Name = "chcksancionado"
    Me.chcksancionado.Size = New System.Drawing.Size(83, 17)
    Me.chcksancionado.TabIndex = 8
    Me.chcksancionado.Text = "Sancionado"
    Me.chcksancionado.UseVisualStyleBackColor = True
    '
    'cbogravedadllamado
    '
    Me.cbogravedadllamado.AbriralEntrar = False
    Me.cbogravedadllamado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbogravedadllamado.FormattingEnabled = True
    Me.cbogravedadllamado.Location = New System.Drawing.Point(174, 163)
    Me.cbogravedadllamado.Name = "cbogravedadllamado"
    Me.cbogravedadllamado.OperadorDatos = Nothing
    Me.cbogravedadllamado.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbogravedadllamado.ParametroDet = Nothing
    Me.cbogravedadllamado.PuedeActualizar = True
    Me.cbogravedadllamado.PuedeEliminar = True
    Me.cbogravedadllamado.PuedeModificar = True
    Me.cbogravedadllamado.PuedeNuevo = True
    Me.cbogravedadllamado.Size = New System.Drawing.Size(130, 21)
    Me.cbogravedadllamado.TabIndex = 7
    '
    'cbotipollamado
    '
    Me.cbotipollamado.AbriralEntrar = False
    Me.cbotipollamado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipollamado.FormattingEnabled = True
    Me.cbotipollamado.Location = New System.Drawing.Point(174, 39)
    Me.cbotipollamado.Name = "cbotipollamado"
    Me.cbotipollamado.OperadorDatos = Nothing
    Me.cbotipollamado.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipollamado.ParametroDet = Nothing
    Me.cbotipollamado.PuedeActualizar = True
    Me.cbotipollamado.PuedeEliminar = True
    Me.cbotipollamado.PuedeModificar = True
    Me.cbotipollamado.PuedeNuevo = True
    Me.cbotipollamado.Size = New System.Drawing.Size(320, 21)
    Me.cbotipollamado.TabIndex = 3
    '
    'FrmLlamadaAtencion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(504, 247)
    Me.Controls.Add(Me.chcksancionado)
    Me.Controls.Add(Me.cbogravedadllamado)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dtfecha)
    Me.Controls.Add(Me.cbotipollamado)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label5)
    Me.Name = "FrmLlamadaAtencion"
    Me.Text = "Llamada de atención:"
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.cbotipollamado, 0)
    Me.Controls.SetChildIndex(Me.dtfecha, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.cbogravedadllamado, 0)
    Me.Controls.SetChildIndex(Me.chcksancionado, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents cbotipollamado As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbogravedadllamado As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chcksancionado As System.Windows.Forms.CheckBox

End Class
