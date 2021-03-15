<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeriodo
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
    Me.dtfecpago = New System.Windows.Forms.DateTimePicker()
    Me.chk_pagado = New System.Windows.Forms.CheckBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.ComboBoxParametroDet1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.comboMes = New System.Windows.Forms.ComboBox()
    Me.txt_anio = New Infoware.Controles.Base.TextBoxCalculator()
    Me.dtmarcaciondesde = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.dtmarcacionhasta = New System.Windows.Forms.DateTimePicker()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.chkesQuincena = New System.Windows.Forms.CheckBox()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dtfecpago
    '
    Me.dtfecpago.Location = New System.Drawing.Point(108, 118)
    Me.dtfecpago.Name = "dtfecpago"
    Me.dtfecpago.Size = New System.Drawing.Size(215, 20)
    Me.dtfecpago.TabIndex = 8
    '
    'chk_pagado
    '
    Me.chk_pagado.AutoSize = True
    Me.chk_pagado.Location = New System.Drawing.Point(108, 146)
    Me.chk_pagado.Name = "chk_pagado"
    Me.chk_pagado.Size = New System.Drawing.Size(63, 17)
    Me.chk_pagado.TabIndex = 9
    Me.chk_pagado.Text = "Pagado"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 65)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Periodo desde:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 121)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(82, 13)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Fecha de pago:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Location = New System.Drawing.Point(108, 62)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(215, 20)
    Me.dtfecdesde.TabIndex = 4
    '
    'dtfechasta
    '
    Me.dtfechasta.Location = New System.Drawing.Point(108, 90)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(215, 20)
    Me.dtfechasta.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 93)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(75, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Periodo hasta:"
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(108, 12)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(215, 21)
    Me.ComboBoxParametroDet1.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 15)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(73, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Periodo pago:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 174)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(29, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "Año:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 202)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(30, 13)
    Me.Label6.TabIndex = 12
    Me.Label6.Text = "Mes:"
    '
    'comboMes
    '
    Me.comboMes.FormattingEnabled = True
    Me.comboMes.Location = New System.Drawing.Point(108, 199)
    Me.comboMes.Name = "comboMes"
    Me.comboMes.Size = New System.Drawing.Size(215, 21)
    Me.comboMes.TabIndex = 13
    '
    'txt_anio
    '
    Me.txt_anio.Location = New System.Drawing.Point(108, 171)
    Me.txt_anio.Mensaje = ""
    Me.txt_anio.Name = "txt_anio"
    Me.txt_anio.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_anio.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_anio.PromptText = ""
    Me.txt_anio.Size = New System.Drawing.Size(75, 20)
    Me.txt_anio.TabIndex = 11
    Me.txt_anio.Text = "0"
    Me.txt_anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_anio.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_anio.Value = 0.0R
    '
    'dtmarcaciondesde
    '
    Me.dtmarcaciondesde.Location = New System.Drawing.Point(108, 227)
    Me.dtmarcaciondesde.Name = "dtmarcaciondesde"
    Me.dtmarcaciondesde.Size = New System.Drawing.Size(215, 20)
    Me.dtmarcaciondesde.TabIndex = 15
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 230)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(94, 13)
    Me.Label7.TabIndex = 14
    Me.Label7.Text = "Marcación Desde:"
    '
    'dtmarcacionhasta
    '
    Me.dtmarcacionhasta.Location = New System.Drawing.Point(108, 255)
    Me.dtmarcacionhasta.Name = "dtmarcacionhasta"
    Me.dtmarcacionhasta.Size = New System.Drawing.Size(215, 20)
    Me.dtmarcacionhasta.TabIndex = 17
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(12, 258)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(91, 13)
    Me.Label8.TabIndex = 16
    Me.Label8.Text = "Marcación Hasta:"
    '
    'chkesQuincena
    '
    Me.chkesQuincena.AutoSize = True
    Me.chkesQuincena.Location = New System.Drawing.Point(108, 39)
    Me.chkesQuincena.Name = "chkesQuincena"
    Me.chkesQuincena.Size = New System.Drawing.Size(72, 17)
    Me.chkesQuincena.TabIndex = 2
    Me.chkesQuincena.Text = "Quincena"
    '
    'FrmPeriodo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(335, 328)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.dtmarcacionhasta)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.dtmarcaciondesde)
    Me.Controls.Add(Me.txt_anio)
    Me.Controls.Add(Me.comboMes)
    Me.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Controls.Add(Me.dtfecpago)
    Me.Controls.Add(Me.chkesQuincena)
    Me.Controls.Add(Me.chk_pagado)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dtfecdesde)
    Me.Controls.Add(Me.dtfechasta)
    Me.Controls.Add(Me.Label3)
    Me.Name = "FrmPeriodo"
    Me.Text = "Periodos"
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.dtfechasta, 0)
    Me.Controls.SetChildIndex(Me.dtfecdesde, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.chk_pagado, 0)
    Me.Controls.SetChildIndex(Me.chkesQuincena, 0)
    Me.Controls.SetChildIndex(Me.dtfecpago, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxParametroDet1, 0)
    Me.Controls.SetChildIndex(Me.comboMes, 0)
    Me.Controls.SetChildIndex(Me.txt_anio, 0)
    Me.Controls.SetChildIndex(Me.dtmarcaciondesde, 0)
    Me.Controls.SetChildIndex(Me.Label7, 0)
    Me.Controls.SetChildIndex(Me.dtmarcacionhasta, 0)
    Me.Controls.SetChildIndex(Me.Label8, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dtfecpago As System.Windows.Forms.DateTimePicker
  Friend WithEvents chk_pagado As System.Windows.Forms.CheckBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxParametroDet1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents comboMes As System.Windows.Forms.ComboBox
  Friend WithEvents txt_anio As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents dtmarcaciondesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents dtmarcacionhasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents chkesQuincena As System.Windows.Forms.CheckBox

End Class
