<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDestino
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
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtnombre = New Infoware.Controles.Base.TextBoxStd
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.CtlPais1 = New WWTS.General.Controles.ComboBoxParametroDet
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
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'txtnombre
    '
    Me.txtnombre.Location = New System.Drawing.Point(96, 35)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(165, 20)
    Me.txtnombre.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(47, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Nombre:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(13, 64)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(32, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "País:"
    '
    'CtlPais1
    '
    Me.CtlPais1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlPais1.FormattingEnabled = True
    Me.CtlPais1.Location = New System.Drawing.Point(96, 61)
    Me.CtlPais1.Name = "CtlPais1"
    Me.CtlPais1.OperadorDatos = Nothing
    Me.CtlPais1.ParametroDet = Nothing
    Me.CtlPais1.PuedeActualizar = True
    Me.CtlPais1.PuedeEliminar = True
    Me.CtlPais1.PuedeModificar = True
    Me.CtlPais1.PuedeNuevo = True
    Me.CtlPais1.Size = New System.Drawing.Size(165, 21)
    Me.CtlPais1.TabIndex = 5
    '
    'FrmDestino
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 130)
    Me.Controls.Add(Me.CtlPais1)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtnombre)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmDestino"
    Me.Text = "Destinos"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtnombre, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.CtlPais1, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtnombre As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents CtlPais1 As WWTS.General.Controles.ComboBoxParametroDet

End Class
