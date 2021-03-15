<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTestxArea
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboarea = New WWTS.General.Controles.ComboBoxParametroDet()
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcuerpo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboarea)
        Me.Panel1.Visible = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Área:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboarea
        '
        Me.cboarea.AbriralEntrar = False
        Me.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboarea.FormattingEnabled = True
        Me.cboarea.Location = New System.Drawing.Point(50, 12)
        Me.cboarea.Name = "cboarea"
        Me.cboarea.OperadorDatos = Nothing
        Me.cboarea.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Area
        Me.cboarea.ParametroDet = Nothing
        Me.cboarea.PuedeActualizar = True
        Me.cboarea.PuedeEliminar = True
        Me.cboarea.PuedeModificar = True
        Me.cboarea.PuedeNuevo = True
        Me.cboarea.Size = New System.Drawing.Size(168, 21)
        Me.cboarea.TabIndex = 1
        '
        'FrmTestxArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 564)
        Me.Name = "FrmTestxArea"
        Me.PuedeEliminar = True
        Me.PuedeImprimir = True
        Me.PuedeNuevo = True
        Me.PuedeRefrescar = True
        Me.Text = "Test por Área"
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcuerpo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboarea As WWTS.General.Controles.ComboBoxParametroDet
End Class
