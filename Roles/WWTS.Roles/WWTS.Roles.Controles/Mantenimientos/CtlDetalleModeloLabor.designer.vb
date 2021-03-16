<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlDetalleModeloLabor
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.lblmensaje = New System.Windows.Forms.Label
    Me.CtlTarea1 = New CtlTarea
    Me.chkasistencia = New System.Windows.Forms.CheckBox
    Me.cboEstadoDiaLabor = New WWTS.General.Controles.ComboBoxParametroDet
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.txt_tarea = New Infoware.Controles.Base.TextBoxCalculator
    Me.txt_sobre50 = New Infoware.Controles.Base.TextBoxCalculator
    Me.txt_sobre25 = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label1 = New System.Windows.Forms.Label
    Me.txt_sobre100 = New Infoware.Controles.Base.TextBoxCalculator
    Me.SuspendLayout()
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(175, 21)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'CtlTarea1
    '
    Me.CtlTarea1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlTarea1.FormattingEnabled = True
    Me.CtlTarea1.Location = New System.Drawing.Point(0, 21)
    Me.CtlTarea1.Name = "CtlTarea1"
    Me.CtlTarea1.Op = Nothing
    Me.CtlTarea1.PuedeActualizar = True
    Me.CtlTarea1.PuedeEliminar = True
    Me.CtlTarea1.PuedeModificar = True
    Me.CtlTarea1.PuedeNuevo = True
    Me.CtlTarea1.Size = New System.Drawing.Size(62, 108)
    Me.CtlTarea1.TabIndex = 1
    Me.CtlTarea1.Tarea = Nothing
    '
    'chkasistencia
    '
    Me.chkasistencia.AutoSize = True
    Me.chkasistencia.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkasistencia.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkasistencia.Location = New System.Drawing.Point(62, 21)
    Me.chkasistencia.Name = "chkasistencia"
    Me.chkasistencia.Padding = New System.Windows.Forms.Padding(1)
    Me.chkasistencia.Size = New System.Drawing.Size(113, 20)
    Me.chkasistencia.TabIndex = 2
    Me.chkasistencia.Text = "Asistencia"
    '
    'cboEstadoDiaLabor
    '
    Me.cboEstadoDiaLabor.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboEstadoDiaLabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEstadoDiaLabor.Location = New System.Drawing.Point(62, 41)
    Me.cboEstadoDiaLabor.Name = "cboEstadoDiaLabor"
    Me.cboEstadoDiaLabor.OperadorDatos = Nothing
    Me.cboEstadoDiaLabor.Parametro = General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboEstadoDiaLabor.ParametroDet = Nothing
    Me.cboEstadoDiaLabor.PuedeActualizar = True
    Me.cboEstadoDiaLabor.PuedeEliminar = True
    Me.cboEstadoDiaLabor.PuedeModificar = True
    Me.cboEstadoDiaLabor.PuedeNuevo = True
    Me.cboEstadoDiaLabor.Size = New System.Drawing.Size(113, 21)
    Me.cboEstadoDiaLabor.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(62, 66)
    Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(38, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Tarea:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(62, 85)
    Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(64, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Sobret 50%:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(62, 123)
    Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(64, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "Sobret 25%:"
    '
    'txt_tarea
    '
    Me.txt_tarea.Location = New System.Drawing.Point(137, 63)
    Me.txt_tarea.Name = "txt_tarea"
    Me.txt_tarea.Size = New System.Drawing.Size(37, 20)
    Me.txt_tarea.TabIndex = 5
    Me.txt_tarea.Text = "0"
    Me.txt_tarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_tarea.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_tarea.Value = 0
    '
    'txt_sobre50
    '
    Me.txt_sobre50.Location = New System.Drawing.Point(137, 82)
    Me.txt_sobre50.Name = "txt_sobre50"
    Me.txt_sobre50.Size = New System.Drawing.Size(37, 20)
    Me.txt_sobre50.TabIndex = 7
    Me.txt_sobre50.Text = "0"
    Me.txt_sobre50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_sobre50.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_sobre50.Value = 0
    '
    'txt_sobre25
    '
    Me.txt_sobre25.Location = New System.Drawing.Point(137, 120)
    Me.txt_sobre25.Name = "txt_sobre25"
    Me.txt_sobre25.Size = New System.Drawing.Size(37, 20)
    Me.txt_sobre25.TabIndex = 11
    Me.txt_sobre25.Text = "0"
    Me.txt_sobre25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_sobre25.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_sobre25.Value = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(62, 104)
    Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(70, 13)
    Me.Label1.TabIndex = 8
    Me.Label1.Text = "Sobret 100%:"
    '
    'txt_sobre100
    '
    Me.txt_sobre100.Location = New System.Drawing.Point(137, 101)
    Me.txt_sobre100.Name = "txt_sobre100"
    Me.txt_sobre100.Size = New System.Drawing.Size(37, 20)
    Me.txt_sobre100.TabIndex = 9
    Me.txt_sobre100.Text = "0"
    Me.txt_sobre100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txt_sobre100.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txt_sobre100.Value = 0
    '
    'CtlDetalleModeloLabor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txt_sobre25)
    Me.Controls.Add(Me.txt_sobre100)
    Me.Controls.Add(Me.txt_sobre50)
    Me.Controls.Add(Me.txt_tarea)
    Me.Controls.Add(Me.cboEstadoDiaLabor)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.chkasistencia)
    Me.Controls.Add(Me.CtlTarea1)
    Me.Controls.Add(Me.lblmensaje)
    Me.Name = "CtlDetalleModeloLabor"
    Me.Size = New System.Drawing.Size(175, 140)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents CtlTarea1 As CtlTarea
  Friend WithEvents chkasistencia As System.Windows.Forms.CheckBox
  Friend WithEvents cboEstadoDiaLabor As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txt_tarea As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txt_sobre50 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txt_sobre25 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txt_sobre100 As Infoware.Controles.Base.TextBoxCalculator

End Class
