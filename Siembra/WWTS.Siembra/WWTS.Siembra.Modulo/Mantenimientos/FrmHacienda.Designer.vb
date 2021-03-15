Imports WWTS.General.Controles

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHacienda
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
    Me.components = New System.ComponentModel.Container
    Me.txtcodigo = New System.Windows.Forms.TextBox
    Me.txtdescripcion = New System.Windows.Forms.TextBox
    Me.txtsufijo = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.CtlUbicacion1 = New CtlUbicacion
    Me.SuspendLayout()
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(100, 6)
    Me.txtcodigo.MaxLength = 5
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(72, 20)
    Me.txtcodigo.TabIndex = 1
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(100, 34)
    Me.txtdescripcion.MaxLength = 18
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(168, 20)
    Me.txtdescripcion.TabIndex = 3
    '
    'txtsufijo
    '
    Me.txtsufijo.Location = New System.Drawing.Point(100, 62)
    Me.txtsufijo.MaxLength = 1
    Me.txtsufijo.Name = "txtsufijo"
    Me.txtsufijo.Size = New System.Drawing.Size(24, 20)
    Me.txtsufijo.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 20)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(12, 37)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 20)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(12, 65)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(72, 20)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Sufijo:"
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(12, 94)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(72, 20)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Ubicación:"
    '
    'CtlUbicacion1
    '
    Me.CtlUbicacion1.Location = New System.Drawing.Point(15, 117)
    Me.CtlUbicacion1.Name = "CtlUbicacion1"
    Me.CtlUbicacion1.Op = Nothing
    Me.CtlUbicacion1.Size = New System.Drawing.Size(253, 220)
    Me.CtlUbicacion1.TabIndex = 7
    '
    'FrmHacienda
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(281, 389)
    Me.Controls.Add(Me.CtlUbicacion1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.txtsufijo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label3)
    Me.Name = "FrmHacienda"
    Me.Text = "Hacienda"
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtsufijo, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.CtlUbicacion1, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
  Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
  Friend WithEvents txtsufijo As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents CtlUbicacion1 As CtlUbicacion

End Class
