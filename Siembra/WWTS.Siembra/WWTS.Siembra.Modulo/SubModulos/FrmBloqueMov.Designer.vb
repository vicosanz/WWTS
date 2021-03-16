<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloqueMov
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
    Me.dtfecmov = New System.Windows.Forms.DateTimePicker
    Me.pnldestino = New System.Windows.Forms.Panel
    Me.CtlCuarto2 = New CtlCuarto
    Me.Label5 = New System.Windows.Forms.Label
    Me.cbotipomov = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.txtnumcajas = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtcantlibras = New Infoware.Controles.Base.TextBoxCalculator
    Me.CtlCuarto1 = New CtlCuarto
    Me.pnldestino.SuspendLayout()
    Me.SuspendLayout()
    '
    'dtfecmov
    '
    Me.dtfecmov.Location = New System.Drawing.Point(108, 36)
    Me.dtfecmov.Name = "dtfecmov"
    Me.dtfecmov.Size = New System.Drawing.Size(200, 20)
    Me.dtfecmov.TabIndex = 1004
    '
    'pnldestino
    '
    Me.pnldestino.Controls.Add(Me.CtlCuarto2)
    Me.pnldestino.Controls.Add(Me.Label5)
    Me.pnldestino.Location = New System.Drawing.Point(12, 208)
    Me.pnldestino.Name = "pnldestino"
    Me.pnldestino.Size = New System.Drawing.Size(288, 95)
    Me.pnldestino.TabIndex = 1008
    '
    'CtlCuarto2
    '
    Me.CtlCuarto2.Cuarto = Nothing
    Me.CtlCuarto2.Hacienda = Nothing
    Me.CtlCuarto2.Location = New System.Drawing.Point(96, 0)
    Me.CtlCuarto2.Name = "CtlCuarto2"
    Me.CtlCuarto2.op = Nothing
    Me.CtlCuarto2.Size = New System.Drawing.Size(137, 88)
    Me.CtlCuarto2.TabIndex = 1010
    '
    'Label5
    '
    Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label5.Location = New System.Drawing.Point(0, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(88, 20)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Al cuarto:"
    '
    'cbotipomov
    '
    Me.cbotipomov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipomov.Location = New System.Drawing.Point(108, 9)
    Me.cbotipomov.Name = "cbotipomov"
    Me.cbotipomov.Size = New System.Drawing.Size(156, 21)
    Me.cbotipomov.TabIndex = 1002
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label2.Location = New System.Drawing.Point(12, 12)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(31, 13)
    Me.Label2.TabIndex = 1001
    Me.Label2.Text = "Tipo:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label3.Location = New System.Drawing.Point(12, 114)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(41, 13)
    Me.Label3.TabIndex = 1007
    Me.Label3.Text = "Cuarto:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label1.Location = New System.Drawing.Point(12, 40)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 1003
    Me.Label1.Text = "Fecha:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label4.Location = New System.Drawing.Point(12, 65)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(90, 13)
    Me.Label4.TabIndex = 1005
    Me.Label4.Text = "Número de cajas:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label6.Location = New System.Drawing.Point(12, 91)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(79, 13)
    Me.Label6.TabIndex = 1006
    Me.Label6.Text = "Cantidad libras:"
    '
    'txtnumcajas
    '
    Me.txtnumcajas.Location = New System.Drawing.Point(108, 62)
    Me.txtnumcajas.Name = "txtnumcajas"
    Me.txtnumcajas.Size = New System.Drawing.Size(100, 20)
    Me.txtnumcajas.TabIndex = 1009
    Me.txtnumcajas.Text = "0"
    Me.txtnumcajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtnumcajas.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'txtcantlibras
    '
    Me.txtcantlibras.Location = New System.Drawing.Point(108, 88)
    Me.txtcantlibras.Name = "txtcantlibras"
    Me.txtcantlibras.Size = New System.Drawing.Size(100, 20)
    Me.txtcantlibras.TabIndex = 1009
    Me.txtcantlibras.Text = "0"
    Me.txtcantlibras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcantlibras.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    '
    'CtlCuarto1
    '
    Me.CtlCuarto1.Cuarto = Nothing
    Me.CtlCuarto1.Hacienda = Nothing
    Me.CtlCuarto1.Location = New System.Drawing.Point(108, 114)
    Me.CtlCuarto1.Name = "CtlCuarto1"
    Me.CtlCuarto1.op = Nothing
    Me.CtlCuarto1.Size = New System.Drawing.Size(137, 88)
    Me.CtlCuarto1.TabIndex = 1010
    '
    'FrmBloqueMov
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(319, 343)
    Me.Controls.Add(Me.CtlCuarto1)
    Me.Controls.Add(Me.txtcantlibras)
    Me.Controls.Add(Me.txtnumcajas)
    Me.Controls.Add(Me.dtfecmov)
    Me.Controls.Add(Me.pnldestino)
    Me.Controls.Add(Me.cbotipomov)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label6)
    Me.Name = "FrmBloqueMov"
    Me.Text = "Bloques"
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.cbotipomov, 0)
    Me.Controls.SetChildIndex(Me.pnldestino, 0)
    Me.Controls.SetChildIndex(Me.dtfecmov, 0)
    Me.Controls.SetChildIndex(Me.txtnumcajas, 0)
    Me.Controls.SetChildIndex(Me.txtcantlibras, 0)
    Me.Controls.SetChildIndex(Me.CtlCuarto1, 0)
    Me.pnldestino.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dtfecmov As System.Windows.Forms.DateTimePicker
  Friend WithEvents pnldestino As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cbotipomov As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtnumcajas As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtcantlibras As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents CtlCuarto2 As CtlCuarto
  Friend WithEvents CtlCuarto1 As CtlCuarto

End Class
