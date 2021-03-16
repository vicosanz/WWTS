<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmbarque
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator
    Me.dtfecha = New System.Windows.Forms.DateTimePicker
    Me.CtlDestino1 = New CtlDestino
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Código:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Fecha:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(13, 64)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(46, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Destino:"
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(96, 9)
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(68, 20)
    Me.txtcodigo.TabIndex = 2
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'dtfecha
    '
    Me.dtfecha.Location = New System.Drawing.Point(96, 35)
    Me.dtfecha.Name = "dtfecha"
    Me.dtfecha.Size = New System.Drawing.Size(204, 20)
    Me.dtfecha.TabIndex = 4
    '
    'CtlDestino1
    '
    Me.CtlDestino1.Destino = Nothing
    Me.CtlDestino1.Location = New System.Drawing.Point(96, 64)
    Me.CtlDestino1.Name = "CtlDestino1"
    Me.CtlDestino1.Op = Nothing
    Me.CtlDestino1.Size = New System.Drawing.Size(204, 92)
    Me.CtlDestino1.TabIndex = 6
    '
    'FrmEmbarque
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(312, 204)
    Me.Controls.Add(Me.CtlDestino1)
    Me.Controls.Add(Me.dtfecha)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmEmbarque"
    Me.Text = "Embarques"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.dtfecha, 0)
    Me.Controls.SetChildIndex(Me.CtlDestino1, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents CtlDestino1 As CtlDestino

End Class
