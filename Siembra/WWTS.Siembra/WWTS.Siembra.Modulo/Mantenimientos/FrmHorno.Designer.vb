<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorno
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
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd
    Me.txtnombre = New Infoware.Controles.Base.TextBoxStd
    Me.CtlTerreno1 = New WWTS.Siembra.Modulo.CtlTerreno
    Me.txtnumaposentos = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtcujes = New Infoware.Controles.Base.TextBoxCalculator
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
    Me.Label2.Location = New System.Drawing.Point(12, 35)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(47, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Nombre:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 59)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(47, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Terreno:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 135)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(60, 13)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Aposentos:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 161)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(36, 13)
    Me.Label5.TabIndex = 9
    Me.Label5.Text = "Cujes:"
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(86, 6)
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(74, 20)
    Me.txtcodigo.TabIndex = 2
    '
    'txtnombre
    '
    Me.txtnombre.Location = New System.Drawing.Point(86, 32)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(175, 20)
    Me.txtnombre.TabIndex = 4
    '
    'CtlTerreno1
    '
    Me.CtlTerreno1.Location = New System.Drawing.Point(86, 59)
    Me.CtlTerreno1.Name = "CtlTerreno1"
    Me.CtlTerreno1.Op = Nothing
    Me.CtlTerreno1.Size = New System.Drawing.Size(175, 67)
    Me.CtlTerreno1.TabIndex = 6
    Me.CtlTerreno1.Terreno = Nothing
    '
    'txtnumaposentos
    '
    Me.txtnumaposentos.Location = New System.Drawing.Point(86, 132)
    Me.txtnumaposentos.Name = "txtnumaposentos"
    Me.txtnumaposentos.Size = New System.Drawing.Size(89, 20)
    Me.txtnumaposentos.TabIndex = 8
    Me.txtnumaposentos.Text = "0"
    Me.txtnumaposentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtnumaposentos.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'txtcujes
    '
    Me.txtcujes.Location = New System.Drawing.Point(86, 158)
    Me.txtcujes.Name = "txtcujes"
    Me.txtcujes.Size = New System.Drawing.Size(89, 20)
    Me.txtcujes.TabIndex = 10
    Me.txtcujes.Text = "0"
    Me.txtcujes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcujes.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'FrmHorno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 227)
    Me.Controls.Add(Me.txtcujes)
    Me.Controls.Add(Me.txtnumaposentos)
    Me.Controls.Add(Me.CtlTerreno1)
    Me.Controls.Add(Me.txtnombre)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmHorno"
    Me.Text = "Horno"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.txtnombre, 0)
    Me.Controls.SetChildIndex(Me.CtlTerreno1, 0)
    Me.Controls.SetChildIndex(Me.txtnumaposentos, 0)
    Me.Controls.SetChildIndex(Me.txtcujes, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtnombre As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents CtlTerreno1 As WWTS.Siembra.Modulo.CtlTerreno
  Friend WithEvents txtnumaposentos As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtcujes As Infoware.Controles.Base.TextBoxCalculator

End Class
