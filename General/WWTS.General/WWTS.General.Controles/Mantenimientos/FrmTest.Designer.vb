<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
    Me.TextBoxCalculator1 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.ComboBoxTest = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Descripción:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(15, 43)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Puntaje:"
    '
    'TextBoxCalculator1
    '
    Me.TextBoxCalculator1.Location = New System.Drawing.Point(90, 40)
    Me.TextBoxCalculator1.Mensaje = ""
    Me.TextBoxCalculator1.Name = "TextBoxCalculator1"
    Me.TextBoxCalculator1.NumeroDecimales = 0
    Me.TextBoxCalculator1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxCalculator1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBoxCalculator1.PromptText = ""
    Me.TextBoxCalculator1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.TextBoxCalculator1.Size = New System.Drawing.Size(130, 20)
    Me.TextBoxCalculator1.TabIndex = 3
    Me.TextBoxCalculator1.Text = "0"
    Me.TextBoxCalculator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.TextBoxCalculator1.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.TextBoxCalculator1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.TextBoxCalculator1.Value = 0.0R
    '
    'ComboBoxTest
    '
    Me.ComboBoxTest.AbriralEntrar = False
    Me.ComboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTest.FormattingEnabled = True
    Me.ComboBoxTest.Location = New System.Drawing.Point(90, 12)
    Me.ComboBoxTest.Name = "ComboBoxTest"
    Me.ComboBoxTest.OperadorDatos = Nothing
    Me.ComboBoxTest.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTest.ParametroDet = Nothing
    Me.ComboBoxTest.PuedeActualizar = True
    Me.ComboBoxTest.PuedeEliminar = True
    Me.ComboBoxTest.PuedeModificar = True
    Me.ComboBoxTest.PuedeNuevo = True
    Me.ComboBoxTest.Size = New System.Drawing.Size(130, 21)
    Me.ComboBoxTest.TabIndex = 1
    '
    'FrmTest
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(244, 112)
    Me.Controls.Add(Me.ComboBoxTest)
    Me.Controls.Add(Me.TextBoxCalculator1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmTest"
    Me.Text = "Test"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.TextBoxCalculator1, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxTest, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TextBoxCalculator1 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents ComboBoxTest As WWTS.General.Controles.ComboBoxParametroDet
End Class
