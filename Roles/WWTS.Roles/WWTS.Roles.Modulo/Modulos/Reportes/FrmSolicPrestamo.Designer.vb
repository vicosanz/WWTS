<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicPrestamo
  Inherits Infoware.Consola.Base.FrmReporteBase

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
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 64)
    Me.pnlcuerpo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.pnlcuerpo.Size = New System.Drawing.Size(888, 653)
    '
    'Panel1
    '
    Me.Panel1.Location = New System.Drawing.Point(0, 58)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
    Me.Panel1.Size = New System.Drawing.Size(888, 58)
    Me.Panel1.Visible = False
    '
    'FrmSolicPrestamo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.ClientSize = New System.Drawing.Size(888, 717)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.Name = "FrmSolicPrestamo"
    Me.PuedeImprimir = True
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

End Class
