<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmZafra
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
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd
    Me.Label2 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(96, 9)
    Me.txtcodigo.MaxLength = 3
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(60, 20)
    Me.txtcodigo.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 23)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(96, 39)
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(168, 20)
    Me.txtdescripcion.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(12, 39)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 23)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'FrmZafra
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 110)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmZafra"
    Me.Text = "Zafra"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
