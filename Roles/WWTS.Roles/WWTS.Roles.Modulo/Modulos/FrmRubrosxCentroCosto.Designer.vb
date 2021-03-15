<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRubrosxCentroCosto
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
    Me.cboCentroCosto = New WWTS.General.Controles.ComboBoxParametroDet()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.cboCentroCosto)
    Me.Panel1.Size = New System.Drawing.Size(778, 42)
    Me.Panel1.Visible = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(8, 13)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(71, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Centro Costo:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cboCentroCosto
    '
    Me.cboCentroCosto.AbriralEntrar = False
    Me.cboCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCentroCosto.FormattingEnabled = True
    Me.cboCentroCosto.Location = New System.Drawing.Point(85, 10)
    Me.cboCentroCosto.Name = "cboCentroCosto"
    Me.cboCentroCosto.OperadorDatos = Nothing
    Me.cboCentroCosto.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Area
    Me.cboCentroCosto.ParametroDet = Nothing
    Me.cboCentroCosto.PuedeActualizar = True
    Me.cboCentroCosto.PuedeEliminar = True
    Me.cboCentroCosto.PuedeModificar = True
    Me.cboCentroCosto.PuedeNuevo = True
    Me.cboCentroCosto.Size = New System.Drawing.Size(172, 21)
    Me.cboCentroCosto.TabIndex = 1
    '
    'FrmRubrosxCentroCosto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(778, 564)
    Me.Name = "FrmRubrosxCentroCosto"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Text = "Rubros por centro de costo"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboCentroCosto As WWTS.General.Controles.ComboBoxParametroDet
End Class
