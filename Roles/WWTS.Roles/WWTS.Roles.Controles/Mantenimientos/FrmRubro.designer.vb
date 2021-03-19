<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRubro
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
    Me.components = New System.ComponentModel.Container()
    Me.txtvalortope = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtfindemes = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtquincena = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cborubro = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.chckesinfinito = New System.Windows.Forms.CheckBox()
    Me.chckgravaiess = New System.Windows.Forms.CheckBox()
    Me.chckactivo = New System.Windows.Forms.CheckBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txtObservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.pnlPrestamo = New System.Windows.Forms.Panel()
    Me.btnImprSolicitud = New Infoware.Controles.Base.ButtonStd()

    Me.pnlPrestamo.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtvalortope
    '
    Me.txtvalortope.Location = New System.Drawing.Point(112, 58)
    Me.txtvalortope.Mensaje = ""
    Me.txtvalortope.Name = "txtvalortope"
    Me.txtvalortope.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalortope.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalortope.PromptText = ""
    Me.txtvalortope.Size = New System.Drawing.Size(130, 20)
    Me.txtvalortope.TabIndex = 5
    Me.txtvalortope.Text = "0,00"
    Me.txtvalortope.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalortope.Value = 0.0R
    '
    'txtfindemes
    '
    Me.txtfindemes.Location = New System.Drawing.Point(111, 112)
    Me.txtfindemes.Mensaje = ""
    Me.txtfindemes.Name = "txtfindemes"
    Me.txtfindemes.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtfindemes.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtfindemes.PromptText = ""
    Me.txtfindemes.Size = New System.Drawing.Size(130, 20)
    Me.txtfindemes.TabIndex = 9
    Me.txtfindemes.Text = "0,00"
    Me.txtfindemes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtfindemes.Value = 0.0R
    '
    'txtquincena
    '
    Me.txtquincena.Location = New System.Drawing.Point(111, 85)
    Me.txtquincena.Mensaje = ""
    Me.txtquincena.Name = "txtquincena"
    Me.txtquincena.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtquincena.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtquincena.PromptText = ""
    Me.txtquincena.Size = New System.Drawing.Size(130, 20)
    Me.txtquincena.TabIndex = 7
    Me.txtquincena.Text = "0,00"
    Me.txtquincena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtquincena.Value = 0.0R
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 61)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(62, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Valor Tope:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 35)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(56, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Es Infinito:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 115)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(78, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "En Fin de Mes:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 88)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "En Quincena:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(39, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Rubro:"
    '
    'cborubro
    '
    Me.cborubro.AbriralEntrar = False
    Me.cborubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cborubro.FormattingEnabled = True
    Me.cborubro.Location = New System.Drawing.Point(111, 6)
    Me.cborubro.Name = "cborubro"
    Me.cborubro.OperadorDatos = Nothing
    Me.cborubro.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoRubro
    Me.cborubro.ParametroDet = Nothing
    Me.cborubro.PuedeActualizar = True
    Me.cborubro.PuedeEliminar = True
    Me.cborubro.PuedeModificar = True
    Me.cborubro.PuedeNuevo = True
    Me.cborubro.Size = New System.Drawing.Size(218, 21)
    Me.cborubro.TabIndex = 1
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 140)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(82, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Aportable IESS:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(112, 163)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(130, 20)
    Me.dtfecdesde.TabIndex = 13
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 166)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(83, 13)
    Me.Label7.TabIndex = 12
    Me.Label7.Text = "Fecha vigencia:"
    '
    'chckesinfinito
    '
    Me.chckesinfinito.AutoSize = True
    Me.chckesinfinito.Location = New System.Drawing.Point(112, 34)
    Me.chckesinfinito.Name = "chckesinfinito"
    Me.chckesinfinito.Size = New System.Drawing.Size(29, 17)
    Me.chckesinfinito.TabIndex = 3
    Me.chckesinfinito.Text = " "
    Me.chckesinfinito.UseVisualStyleBackColor = True
    '
    'chckgravaiess
    '
    Me.chckgravaiess.AutoSize = True
    Me.chckgravaiess.Enabled = False
    Me.chckgravaiess.Location = New System.Drawing.Point(111, 139)
    Me.chckgravaiess.Name = "chckgravaiess"
    Me.chckgravaiess.Size = New System.Drawing.Size(29, 17)
    Me.chckgravaiess.TabIndex = 11
    Me.chckgravaiess.Text = " "
    Me.chckgravaiess.UseVisualStyleBackColor = True
    '
    'chckactivo
    '
    Me.chckactivo.AutoSize = True
    Me.chckactivo.Location = New System.Drawing.Point(111, 190)
    Me.chckactivo.Name = "chckactivo"
    Me.chckactivo.Size = New System.Drawing.Size(29, 17)
    Me.chckactivo.TabIndex = 15
    Me.chckactivo.Text = " "
    Me.chckactivo.UseVisualStyleBackColor = True
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(12, 191)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(40, 13)
    Me.Label8.TabIndex = 14
    Me.Label8.Text = "Activo:"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(12, 214)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(72, 13)
    Me.Label9.TabIndex = 16
    Me.Label9.Text = "Factor Rubro:"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(109, 214)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(69, 13)
    Me.Label10.TabIndex = 17
    Me.Label10.Text = "Factor Rubro"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(12, 240)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(70, 13)
    Me.Label11.TabIndex = 18
    Me.Label11.Text = "Observación:"
    '
    'txtObservacion
    '
    Me.txtObservacion.Location = New System.Drawing.Point(111, 235)
    Me.txtObservacion.Mensaje = ""
    Me.txtObservacion.Multiline = True
    Me.txtObservacion.Name = "txtObservacion"
    Me.txtObservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtObservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtObservacion.PromptText = ""
    Me.txtObservacion.Size = New System.Drawing.Size(218, 67)
    Me.txtObservacion.TabIndex = 19
    '
    'pnlPrestamo
    '
    Me.pnlPrestamo.Controls.Add(Me.btnImprSolicitud)
    Me.pnlPrestamo.Location = New System.Drawing.Point(0, 308)
    Me.pnlPrestamo.Name = "pnlPrestamo"
    Me.pnlPrestamo.Size = New System.Drawing.Size(341, 34)
    Me.pnlPrestamo.TabIndex = 1001
    Me.pnlPrestamo.Visible = False
    '
    'btnImprSolicitud
    '
    Me.btnImprSolicitud.Location = New System.Drawing.Point(111, 4)
    Me.btnImprSolicitud.Name = "btnImprSolicitud"
    Me.btnImprSolicitud.Size = New System.Drawing.Size(218, 23)
    Me.btnImprSolicitud.TabIndex = 0
    Me.btnImprSolicitud.Text = "Imprimir Solicitud"
    Me.btnImprSolicitud.UseVisualStyleBackColor = True
    '
    'FrmRubro
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(341, 383)
    Me.Controls.Add(Me.pnlPrestamo)
    Me.Controls.Add(Me.txtObservacion)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.chckactivo)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.chckgravaiess)
    Me.Controls.Add(Me.chckesinfinito)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.dtfecdesde)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cborubro)
    Me.Controls.Add(Me.txtvalortope)
    Me.Controls.Add(Me.txtfindemes)
    Me.Controls.Add(Me.txtquincena)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmRubro"
    Me.Text = "Rubro"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.txtquincena, 0)
    Me.Controls.SetChildIndex(Me.txtfindemes, 0)
    Me.Controls.SetChildIndex(Me.txtvalortope, 0)
    Me.Controls.SetChildIndex(Me.cborubro, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.dtfecdesde, 0)
    Me.Controls.SetChildIndex(Me.Label7, 0)
    Me.Controls.SetChildIndex(Me.chckesinfinito, 0)
    Me.Controls.SetChildIndex(Me.chckgravaiess, 0)
    Me.Controls.SetChildIndex(Me.Label8, 0)
    Me.Controls.SetChildIndex(Me.chckactivo, 0)
    Me.Controls.SetChildIndex(Me.Label9, 0)
    Me.Controls.SetChildIndex(Me.Label10, 0)
    Me.Controls.SetChildIndex(Me.Label11, 0)
    Me.Controls.SetChildIndex(Me.txtObservacion, 0)
    Me.Controls.SetChildIndex(Me.pnlPrestamo, 0)

    Me.pnlPrestamo.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cborubro As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents txtvalortope As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtfindemes As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtquincena As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents chckesinfinito As System.Windows.Forms.CheckBox
  Friend WithEvents chckgravaiess As System.Windows.Forms.CheckBox
  Friend WithEvents chckactivo As System.Windows.Forms.CheckBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txtObservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents pnlPrestamo As System.Windows.Forms.Panel
  Friend WithEvents btnImprSolicitud As Infoware.Controles.Base.ButtonStd

End Class
