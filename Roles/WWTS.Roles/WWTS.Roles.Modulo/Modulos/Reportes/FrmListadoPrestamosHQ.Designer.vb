<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoPrestamosHQ
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtDesde = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtHasta = New System.Windows.Forms.DateTimePicker()
    Me.btnMostrar = New System.Windows.Forms.Button()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()

    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(592, 417)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnMostrar)
    Me.Panel1.Controls.Add(Me.dtHasta)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.dtDesde)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
    Me.Panel1.Size = New System.Drawing.Size(592, 64)
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 14)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Desde:"
    '
    'dtDesde
    '
    Me.dtDesde.Location = New System.Drawing.Point(78, 8)
    Me.dtDesde.Name = "dtDesde"
    Me.dtDesde.Size = New System.Drawing.Size(200, 20)
    Me.dtDesde.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 40)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Hasta:"
    '
    'dtHasta
    '
    Me.dtHasta.Location = New System.Drawing.Point(78, 34)
    Me.dtHasta.Name = "dtHasta"
    Me.dtHasta.Size = New System.Drawing.Size(200, 20)
    Me.dtHasta.TabIndex = 1
    '
    'btnMostrar
    '
    Me.btnMostrar.Location = New System.Drawing.Point(316, 31)
    Me.btnMostrar.Name = "btnMostrar"
    Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
    Me.btnMostrar.TabIndex = 2
    Me.btnMostrar.Text = "Mostrar"
    Me.btnMostrar.UseVisualStyleBackColor = True
    '
    'FrmListadoPrestamosHQ
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(592, 466)
    Me.Name = "FrmListadoPrestamosHQ"
    Me.PuedeImprimir = True
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()

    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnMostrar As System.Windows.Forms.Button
  Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
