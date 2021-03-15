<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRubroAdicionalNomina
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
    Me.txtvalor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cborubro = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.txtObservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'txtvalor
    '
    Me.txtvalor.Location = New System.Drawing.Point(119, 40)
    Me.txtvalor.Mensaje = ""
    Me.txtvalor.Name = "txtvalor"
    Me.txtvalor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalor.PromptText = ""
    Me.txtvalor.Size = New System.Drawing.Size(130, 20)
    Me.txtvalor.TabIndex = 3
    Me.txtvalor.Text = "0.00"
    Me.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalor.Value = 0.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(20, 43)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(34, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Valor:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(20, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(39, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Rubro:"
    '
    'cborubro
    '
    Me.cborubro.AbriralEntrar = False
    Me.cborubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cborubro.FormattingEnabled = True
    Me.cborubro.Location = New System.Drawing.Point(119, 12)
    Me.cborubro.Name = "cborubro"
    Me.cborubro.OperadorDatos = Nothing
    Me.cborubro.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoRubro
    Me.cborubro.ParametroDet = Nothing
    Me.cborubro.PuedeActualizar = True
    Me.cborubro.PuedeEliminar = True
    Me.cborubro.PuedeModificar = True
    Me.cborubro.PuedeNuevo = True
    Me.cborubro.Size = New System.Drawing.Size(130, 21)
    Me.cborubro.TabIndex = 1
    '
    'txtObservacion
    '
    Me.txtObservacion.Location = New System.Drawing.Point(120, 67)
    Me.txtObservacion.Mensaje = ""
    Me.txtObservacion.Multiline = True
    Me.txtObservacion.Name = "txtObservacion"
    Me.txtObservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtObservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtObservacion.PromptText = ""
    Me.txtObservacion.Size = New System.Drawing.Size(262, 92)
    Me.txtObservacion.TabIndex = 5
    Me.txtObservacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(20, 67)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(70, 13)
    Me.Label11.TabIndex = 4
    Me.Label11.Text = "Observación:"
    '
    'FrmRubroAdicionalNomina
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(388, 203)
    Me.Controls.Add(Me.txtObservacion)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.cborubro)
    Me.Controls.Add(Me.txtvalor)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmRubroAdicionalNomina"
    Me.Text = "Adicionales"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.txtvalor, 0)
    Me.Controls.SetChildIndex(Me.cborubro, 0)
    Me.Controls.SetChildIndex(Me.Label11, 0)
    Me.Controls.SetChildIndex(Me.txtObservacion, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cborubro As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents txtvalor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtObservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
