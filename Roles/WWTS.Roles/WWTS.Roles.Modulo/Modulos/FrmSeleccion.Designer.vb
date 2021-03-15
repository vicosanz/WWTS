<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccion
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Me.CheckBoxStd1 = New Infoware.Controles.Base.CheckBoxStd()
    Me.CheckBoxStd2 = New Infoware.Controles.Base.CheckBoxStd()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CheckBoxStd2)
    Me.Panel1.Controls.Add(Me.CheckBoxStd1)
    Me.Panel1.Visible = True
    '
    'CheckBoxStd1
    '
    Me.CheckBoxStd1.AutoSize = True
    Me.CheckBoxStd1.Checked = True
    Me.CheckBoxStd1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBoxStd1.Location = New System.Drawing.Point(40, 5)
    Me.CheckBoxStd1.Name = "CheckBoxStd1"
    Me.CheckBoxStd1.Size = New System.Drawing.Size(111, 17)
    Me.CheckBoxStd1.TabIndex = 0
    Me.CheckBoxStd1.Text = "Procesos Abiertos"
    Me.CheckBoxStd1.UseVisualStyleBackColor = True
    '
    'CheckBoxStd2
    '
    Me.CheckBoxStd2.AutoSize = True
    Me.CheckBoxStd2.Location = New System.Drawing.Point(40, 28)
    Me.CheckBoxStd2.Name = "CheckBoxStd2"
    Me.CheckBoxStd2.Size = New System.Drawing.Size(115, 17)
    Me.CheckBoxStd2.TabIndex = 1
    Me.CheckBoxStd2.Text = "Procesos Cerrados"
    Me.CheckBoxStd2.UseVisualStyleBackColor = True
    '
    'FrmSeleccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(778, 564)
    Me.Name = "FrmSeleccion"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Text = "FrmSeleccion"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CheckBoxStd2 As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents CheckBoxStd1 As Infoware.Controles.Base.CheckBoxStd
End Class
