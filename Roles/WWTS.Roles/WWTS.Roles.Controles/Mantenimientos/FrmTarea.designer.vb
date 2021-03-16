<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarea
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
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.txt_meta = New Infoware.Controles.Base.TextBoxCalculator
    Me.chk_sobreproduccion = New System.Windows.Forms.CheckBox
    Me.txt_porcsob = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label5 = New System.Windows.Forms.Label
    Me.txt_maximo = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label6 = New System.Windows.Forms.Label
    Me.txt_minimo = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label7 = New System.Windows.Forms.Label
    Me.txt_predeterminado = New Infoware.Controles.Base.TextBoxCalculator
    Me.SuspendLayout()
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(119, 9)
    Me.txtcodigo.MaxLength = 3
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(60, 20)
    Me.txtcodigo.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(119, 35)
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(168, 20)
    Me.txtdescripcion.TabIndex = 3
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
    Me.Label3.Location = New System.Drawing.Point(12, 65)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(34, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Meta:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 113)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(99, 13)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "%Sobreproducción:"
    '
    'txt_meta
    '
    Me.txt_meta.Location = New System.Drawing.Point(119, 62)
    Me.txt_meta.Name = "txt_meta"
    Me.txt_meta.Size = New System.Drawing.Size(100, 20)
    Me.txt_meta.TabIndex = 5
    Me.txt_meta.Text = "0"
    Me.txt_meta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_meta.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'chk_sobreproduccion
    '
    Me.chk_sobreproduccion.AutoSize = True
    Me.chk_sobreproduccion.Location = New System.Drawing.Point(119, 88)
    Me.chk_sobreproduccion.Name = "chk_sobreproduccion"
    Me.chk_sobreproduccion.Size = New System.Drawing.Size(143, 17)
    Me.chk_sobreproduccion.TabIndex = 6
    Me.chk_sobreproduccion.Text = "Calcula sobreproducción"
    '
    'txt_porcsob
    '
    Me.txt_porcsob.Location = New System.Drawing.Point(119, 110)
    Me.txt_porcsob.Name = "txt_porcsob"
    Me.txt_porcsob.Size = New System.Drawing.Size(100, 20)
    Me.txt_porcsob.TabIndex = 8
    Me.txt_porcsob.Text = "0"
    Me.txt_porcsob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_porcsob.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txt_porcsob.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 139)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(46, 13)
    Me.Label5.TabIndex = 9
    Me.Label5.Text = "Máximo:"
    '
    'txt_maximo
    '
    Me.txt_maximo.Location = New System.Drawing.Point(119, 136)
    Me.txt_maximo.Name = "txt_maximo"
    Me.txt_maximo.Size = New System.Drawing.Size(100, 20)
    Me.txt_maximo.TabIndex = 10
    Me.txt_maximo.Text = "0"
    Me.txt_maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_maximo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_maximo.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 165)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(45, 13)
    Me.Label6.TabIndex = 11
    Me.Label6.Text = "Mínimo:"
    '
    'txt_minimo
    '
    Me.txt_minimo.Location = New System.Drawing.Point(119, 162)
    Me.txt_minimo.Name = "txt_minimo"
    Me.txt_minimo.Size = New System.Drawing.Size(100, 20)
    Me.txt_minimo.TabIndex = 12
    Me.txt_minimo.Text = "0"
    Me.txt_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_minimo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_minimo.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 191)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(84, 13)
    Me.Label7.TabIndex = 13
    Me.Label7.Text = "Predeterminado:"
    '
    'txt_predeterminado
    '
    Me.txt_predeterminado.Location = New System.Drawing.Point(119, 188)
    Me.txt_predeterminado.Name = "txt_predeterminado"
    Me.txt_predeterminado.Size = New System.Drawing.Size(100, 20)
    Me.txt_predeterminado.TabIndex = 14
    Me.txt_predeterminado.Text = "0"
    Me.txt_predeterminado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_predeterminado.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_predeterminado.Value = New Decimal(New Integer() {0, 0, 0, 0})
    '
    'FrmTarea
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(299, 260)
    Me.Controls.Add(Me.chk_sobreproduccion)
    Me.Controls.Add(Me.txt_porcsob)
    Me.Controls.Add(Me.txt_predeterminado)
    Me.Controls.Add(Me.txt_minimo)
    Me.Controls.Add(Me.txt_maximo)
    Me.Controls.Add(Me.txt_meta)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmTarea"
    Me.Text = "Tareas"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label7, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.txt_meta, 0)
    Me.Controls.SetChildIndex(Me.txt_maximo, 0)
    Me.Controls.SetChildIndex(Me.txt_minimo, 0)
    Me.Controls.SetChildIndex(Me.txt_predeterminado, 0)
    Me.Controls.SetChildIndex(Me.txt_porcsob, 0)
    Me.Controls.SetChildIndex(Me.chk_sobreproduccion, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txt_meta As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents chk_sobreproduccion As System.Windows.Forms.CheckBox
  Friend WithEvents txt_porcsob As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txt_maximo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txt_minimo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txt_predeterminado As Infoware.Controles.Base.TextBoxCalculator

End Class
