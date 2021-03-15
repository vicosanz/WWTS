<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LblTextBoxStd
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label
    Me.TextBoxStd1 = New Infoware.Controles.Base.TextBoxStd
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(0, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(39, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Label1"
    '
    'TextBoxStd1
    '
    Me.TextBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxStd1.Location = New System.Drawing.Point(150, 0)
    Me.TextBoxStd1.Mensaje = ""
    Me.TextBoxStd1.Name = "TextBoxStd1"
    Me.TextBoxStd1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxStd1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBoxStd1.PromptText = ""
    Me.TextBoxStd1.Size = New System.Drawing.Size(190, 20)
    Me.TextBoxStd1.TabIndex = 1
    Me.TextBoxStd1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'LblTextBoxStd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TextBoxStd1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "LblTextBoxStd"
    Me.Size = New System.Drawing.Size(340, 22)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Public WithEvents TextBoxStd1 As Infoware.Controles.Base.TextBoxStd

End Class
