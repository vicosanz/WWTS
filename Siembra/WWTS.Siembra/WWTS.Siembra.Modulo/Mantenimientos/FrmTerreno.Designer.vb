<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTerreno
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
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtareat = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtareau = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.CtlPropietario1 = New WWTS.Siembra.Modulo.CtlPropietario
    Me.CtlHacienda1 = New WWTS.Siembra.Modulo.CtlHacienda
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
    Me.txtnombre.Size = New System.Drawing.Size(168, 20)
    Me.txtnombre.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(13, 64)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(55, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Area total:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 90)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(75, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Area utilizable:"
    '
    'txtareat
    '
    Me.txtareat.Location = New System.Drawing.Point(96, 61)
    Me.txtareat.Name = "txtareat"
    Me.txtareat.Size = New System.Drawing.Size(100, 20)
    Me.txtareat.TabIndex = 5
    Me.txtareat.Text = "0"
    Me.txtareat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtareat.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    '
    'txtareau
    '
    Me.txtareau.Location = New System.Drawing.Point(96, 87)
    Me.txtareau.Name = "txtareau"
    Me.txtareau.Size = New System.Drawing.Size(100, 20)
    Me.txtareau.TabIndex = 7
    Me.txtareau.Text = "0"
    Me.txtareau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtareau.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(13, 116)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(60, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Propietario:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(13, 145)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(56, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Hacienda:"
    '
    'CtlPropietario1
    '
    Me.CtlPropietario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlPropietario1.FormattingEnabled = True
    Me.CtlPropietario1.Location = New System.Drawing.Point(96, 113)
    Me.CtlPropietario1.Name = "CtlPropietario1"
    Me.CtlPropietario1.Op = Nothing
    Me.CtlPropietario1.Propietario = Nothing
    Me.CtlPropietario1.PuedeActualizar = True
    Me.CtlPropietario1.PuedeEliminar = True
    Me.CtlPropietario1.PuedeModificar = True
    Me.CtlPropietario1.PuedeNuevo = True
    Me.CtlPropietario1.Size = New System.Drawing.Size(121, 21)
    Me.CtlPropietario1.TabIndex = 9
    '
    'CtlHacienda1
    '
    Me.CtlHacienda1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlHacienda1.FormattingEnabled = True
    Me.CtlHacienda1.Hacienda = Nothing
    Me.CtlHacienda1.Location = New System.Drawing.Point(96, 142)
    Me.CtlHacienda1.Name = "CtlHacienda1"
    Me.CtlHacienda1.Op = Nothing
    Me.CtlHacienda1.PuedeActualizar = True
    Me.CtlHacienda1.PuedeEliminar = True
    Me.CtlHacienda1.PuedeModificar = True
    Me.CtlHacienda1.PuedeNuevo = True
    Me.CtlHacienda1.Size = New System.Drawing.Size(121, 21)
    Me.CtlHacienda1.TabIndex = 11
    '
    'FrmTerreno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(276, 211)
    Me.Controls.Add(Me.CtlHacienda1)
    Me.Controls.Add(Me.CtlPropietario1)
    Me.Controls.Add(Me.txtareau)
    Me.Controls.Add(Me.txtareat)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtnombre)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmTerreno"
    Me.Text = "Terrenos"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtnombre, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.txtareat, 0)
    Me.Controls.SetChildIndex(Me.txtareau, 0)
    Me.Controls.SetChildIndex(Me.CtlPropietario1, 0)
    Me.Controls.SetChildIndex(Me.CtlHacienda1, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtnombre As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtareat As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtareau As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents CtlPropietario1 As WWTS.Siembra.Modulo.CtlPropietario
  Friend WithEvents CtlHacienda1 As WWTS.Siembra.Modulo.CtlHacienda

End Class
