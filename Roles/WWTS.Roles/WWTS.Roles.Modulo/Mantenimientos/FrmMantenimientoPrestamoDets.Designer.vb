<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPrestamoDetDets
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.txtvalorpag = New Infoware.Controles.Base.TextBoxCalculator
    Me.dtfecpago = New System.Windows.Forms.DateTimePicker
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.txtvalorpag)
    Me.Panel1.Controls.Add(Me.dtfecpago)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(470, 81)
    Me.Panel1.TabIndex = 0
    '
    'txtvalorpag
    '
    Me.txtvalorpag.Location = New System.Drawing.Point(126, 40)
    Me.txtvalorpag.Name = "txtvalorpag"
    Me.txtvalorpag.Size = New System.Drawing.Size(119, 20)
    Me.txtvalorpag.TabIndex = 3
    Me.txtvalorpag.Text = "0,00"
    Me.txtvalorpag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalorpag.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorpag.Value = 0
    '
    'dtfecpago
    '
    Me.dtfecpago.Location = New System.Drawing.Point(126, 14)
    Me.dtfecpago.Name = "dtfecpago"
    Me.dtfecpago.Size = New System.Drawing.Size(220, 20)
    Me.dtfecpago.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 43)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(73, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Valor pagado:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 18)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(82, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Fecha de pago:"
    '
    'FrmMantenimientoPrestamoDetDets
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(470, 130)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoPrestamoDetDets"
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.Text = "Mantenimiento de Solicitudes"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents dtfecpago As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtvalorpag As Infoware.Controles.Base.TextBoxCalculator

End Class
