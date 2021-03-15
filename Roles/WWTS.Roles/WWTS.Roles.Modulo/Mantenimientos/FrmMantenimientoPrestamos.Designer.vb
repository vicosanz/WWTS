<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPrestamos
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.cbotipoprestamo = New WWTS.General.Controles.ComboBoxParametroDet
    Me.pnlaprobado = New System.Windows.Forms.Panel
    Me.dtfecaprobacion = New System.Windows.Forms.DateTimePicker
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtvaloraprob = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtmotivo = New Infoware.Controles.Base.TextBoxStd
    Me.chkaprobado = New System.Windows.Forms.CheckBox
    Me.chkurgente = New System.Windows.Forms.CheckBox
    Me.txtcuota = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtvalorsolic = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.dtfecsolicitud = New System.Windows.Forms.DateTimePicker
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnlaprobado.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.cbotipoprestamo)
    Me.Panel1.Controls.Add(Me.pnlaprobado)
    Me.Panel1.Controls.Add(Me.Label7)
    Me.Panel1.Controls.Add(Me.txtmotivo)
    Me.Panel1.Controls.Add(Me.chkaprobado)
    Me.Panel1.Controls.Add(Me.chkurgente)
    Me.Panel1.Controls.Add(Me.txtcuota)
    Me.Panel1.Controls.Add(Me.txtvalorsolic)
    Me.Panel1.Controls.Add(Me.Label5)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.dtfecsolicitud)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(560, 288)
    Me.Panel1.TabIndex = 0
    '
    'cbotipoprestamo
    '
    Me.cbotipoprestamo.AbriralEntrar = False
    Me.cbotipoprestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipoprestamo.FormattingEnabled = True
    Me.cbotipoprestamo.Location = New System.Drawing.Point(126, 40)
    Me.cbotipoprestamo.Name = "cbotipoprestamo"
    Me.cbotipoprestamo.OperadorDatos = Nothing
    Me.cbotipoprestamo.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipoprestamo.ParametroDet = Nothing
    Me.cbotipoprestamo.PuedeActualizar = True
    Me.cbotipoprestamo.PuedeEliminar = True
    Me.cbotipoprestamo.PuedeModificar = True
    Me.cbotipoprestamo.PuedeNuevo = True
    Me.cbotipoprestamo.Size = New System.Drawing.Size(220, 21)
    Me.cbotipoprestamo.TabIndex = 3
    '
    'pnlaprobado
    '
    Me.pnlaprobado.Controls.Add(Me.dtfecaprobacion)
    Me.pnlaprobado.Controls.Add(Me.Label2)
    Me.pnlaprobado.Controls.Add(Me.txtvaloraprob)
    Me.pnlaprobado.Controls.Add(Me.Label6)
    Me.pnlaprobado.Location = New System.Drawing.Point(0, 189)
    Me.pnlaprobado.Name = "pnlaprobado"
    Me.pnlaprobado.Size = New System.Drawing.Size(474, 54)
    Me.pnlaprobado.TabIndex = 12
    Me.pnlaprobado.Visible = False
    '
    'dtfecaprobacion
    '
    Me.dtfecaprobacion.Location = New System.Drawing.Point(126, 0)
    Me.dtfecaprobacion.Name = "dtfecaprobacion"
    Me.dtfecaprobacion.Size = New System.Drawing.Size(220, 20)
    Me.dtfecaprobacion.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(111, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Fecha de aprobación:"
    '
    'txtvaloraprob
    '
    Me.txtvaloraprob.Location = New System.Drawing.Point(126, 26)
    Me.txtvaloraprob.Mensaje = ""
    Me.txtvaloraprob.Name = "txtvaloraprob"
    Me.txtvaloraprob.Size = New System.Drawing.Size(119, 20)
    Me.txtvaloraprob.TabIndex = 3
    Me.txtvaloraprob.Text = "0,00"
    Me.txtvaloraprob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvaloraprob.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvaloraprob.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvaloraprob.Value = 0
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 29)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(82, 13)
    Me.Label6.TabIndex = 2
    Me.Label6.Text = "Valor aprobado:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 43)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(92, 13)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Tipo de préstamo:"
    '
    'txtmotivo
    '
    Me.txtmotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtmotivo.Location = New System.Drawing.Point(126, 118)
    Me.txtmotivo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtmotivo.Mensaje = ""
    Me.txtmotivo.Name = "txtmotivo"
    Me.txtmotivo.Size = New System.Drawing.Size(422, 20)
    Me.txtmotivo.TabIndex = 9
    Me.txtmotivo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'chkaprobado
    '
    Me.chkaprobado.AutoSize = True
    Me.chkaprobado.Location = New System.Drawing.Point(126, 166)
    Me.chkaprobado.Name = "chkaprobado"
    Me.chkaprobado.Size = New System.Drawing.Size(72, 17)
    Me.chkaprobado.TabIndex = 11
    Me.chkaprobado.Text = "Aprobado"
    Me.chkaprobado.UseVisualStyleBackColor = True
    '
    'chkurgente
    '
    Me.chkurgente.AutoSize = True
    Me.chkurgente.Location = New System.Drawing.Point(126, 143)
    Me.chkurgente.Name = "chkurgente"
    Me.chkurgente.Size = New System.Drawing.Size(64, 17)
    Me.chkurgente.TabIndex = 10
    Me.chkurgente.Text = "Urgente"
    Me.chkurgente.UseVisualStyleBackColor = True
    '
    'txtcuota
    '
    Me.txtcuota.Location = New System.Drawing.Point(126, 93)
    Me.txtcuota.Mensaje = ""
    Me.txtcuota.Name = "txtcuota"
    Me.txtcuota.Size = New System.Drawing.Size(119, 20)
    Me.txtcuota.TabIndex = 7
    Me.txtcuota.Text = "0,00"
    Me.txtcuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcuota.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtcuota.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcuota.Value = 0
    '
    'txtvalorsolic
    '
    Me.txtvalorsolic.Location = New System.Drawing.Point(126, 67)
    Me.txtvalorsolic.Mensaje = ""
    Me.txtvalorsolic.Name = "txtvalorsolic"
    Me.txtvalorsolic.Size = New System.Drawing.Size(119, 20)
    Me.txtvalorsolic.TabIndex = 5
    Me.txtvalorsolic.Text = "0,00"
    Me.txtvalorsolic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalorsolic.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorsolic.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalorsolic.Value = 0
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 121)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(42, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Motivo:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 96)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(94, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Cuota por periodo:"
    '
    'dtfecsolicitud
    '
    Me.dtfecsolicitud.Location = New System.Drawing.Point(126, 14)
    Me.dtfecsolicitud.Name = "dtfecsolicitud"
    Me.dtfecsolicitud.Size = New System.Drawing.Size(220, 20)
    Me.dtfecsolicitud.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 70)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(81, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Valor solicitado:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 18)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(96, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Fecha de solicitud:"
    '
    'FrmMantenimientoPrestamos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(560, 337)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoPrestamos"
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.Text = "Mantenimiento de Solicitudes"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.pnlaprobado.ResumeLayout(False)
    Me.pnlaprobado.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents dtfecaprobacion As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfecsolicitud As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents chkurgente As System.Windows.Forms.CheckBox
  Friend WithEvents txtcuota As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtvalorsolic As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents pnlaprobado As System.Windows.Forms.Panel
  Friend WithEvents txtvaloraprob As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtmotivo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents chkaprobado As System.Windows.Forms.CheckBox
  Friend WithEvents cbotipoprestamo As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
