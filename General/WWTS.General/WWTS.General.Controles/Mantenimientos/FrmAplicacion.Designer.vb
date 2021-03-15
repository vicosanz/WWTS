<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAplicacion
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
    Me.cboarea = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(104, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Área a la que aplica:"
    '
    'cboarea
    '
    Me.cboarea.AbriralEntrar = False
    Me.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboarea.FormattingEnabled = True
    Me.cboarea.Location = New System.Drawing.Point(135, 12)
    Me.cboarea.Name = "cboarea"
    Me.cboarea.OperadorDatos = Nothing
    Me.cboarea.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Area
    Me.cboarea.ParametroDet = Nothing
    Me.cboarea.PuedeActualizar = True
    Me.cboarea.PuedeEliminar = True
    Me.cboarea.PuedeModificar = True
    Me.cboarea.PuedeNuevo = True
    Me.cboarea.Size = New System.Drawing.Size(130, 21)
    Me.cboarea.TabIndex = 1
    '
    'FrmAplicacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 82)
    Me.Controls.Add(Me.cboarea)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmAplicacion"
    Me.Text = "Área Aplicada"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.cboarea, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboarea As WWTS.General.Controles.ComboBoxParametroDet
End Class
