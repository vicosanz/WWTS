<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoLicencia
  Inherits Infoware.Consola.Base.FrmDialogoBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.dtfechadesde = New System.Windows.Forms.DateTimePicker()
    Me.dtfechahasta = New System.Windows.Forms.DateTimePicker()
    Me.chckFechafin = New Infoware.Controles.Base.CheckBoxStd()
    Me.ComboBoxLicencia = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.pnlvacacion = New Infoware.Controles.Base.GroupBoxHeader()
    Me.CtlVacacion1 = New CtlBeneficiosSociales()
    Me.CtlAdjunto1 = New WWTS.General.Controles.CtlAdjunto()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.chckaprobado = New Infoware.Controles.Base.CheckBoxStd()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlvacacion.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(27, 53)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(53, 17)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Desde:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(27, 86)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 17)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Hasta:"
    Me.Label2.Visible = False
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(27, 18)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(96, 17)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Tipo Licencia:"
    '
    'dtfechadesde
    '
    Me.dtfechadesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechadesde.Location = New System.Drawing.Point(133, 49)
    Me.dtfechadesde.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfechadesde.Name = "dtfechadesde"
    Me.dtfechadesde.Size = New System.Drawing.Size(172, 22)
    Me.dtfechadesde.TabIndex = 3
    '
    'dtfechahasta
    '
    Me.dtfechahasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechahasta.Location = New System.Drawing.Point(133, 82)
    Me.dtfechahasta.Margin = New System.Windows.Forms.Padding(4)
    Me.dtfechahasta.Name = "dtfechahasta"
    Me.dtfechahasta.Size = New System.Drawing.Size(172, 22)
    Me.dtfechahasta.TabIndex = 6
    Me.dtfechahasta.Visible = False
    '
    'chckFechafin
    '
    Me.chckFechafin.AutoSize = True
    Me.chckFechafin.Location = New System.Drawing.Point(323, 53)
    Me.chckFechafin.Margin = New System.Windows.Forms.Padding(4)
    Me.chckFechafin.Name = "chckFechafin"
    Me.chckFechafin.Size = New System.Drawing.Size(88, 21)
    Me.chckFechafin.TabIndex = 4
    Me.chckFechafin.Text = "Fecha fin"
    Me.chckFechafin.UseVisualStyleBackColor = True
    '
    'ComboBoxLicencia
    '
    Me.ComboBoxLicencia.AbriralEntrar = False
    Me.ComboBoxLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxLicencia.FormattingEnabled = True
    Me.ComboBoxLicencia.Location = New System.Drawing.Point(133, 15)
    Me.ComboBoxLicencia.Margin = New System.Windows.Forms.Padding(4)
    Me.ComboBoxLicencia.Name = "ComboBoxLicencia"
    Me.ComboBoxLicencia.OperadorDatos = Nothing
    Me.ComboBoxLicencia.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxLicencia.ParametroDet = Nothing
    Me.ComboBoxLicencia.PuedeActualizar = True
    Me.ComboBoxLicencia.PuedeEliminar = True
    Me.ComboBoxLicencia.PuedeModificar = True
    Me.ComboBoxLicencia.PuedeNuevo = True
    Me.ComboBoxLicencia.Size = New System.Drawing.Size(172, 24)
    Me.ComboBoxLicencia.TabIndex = 1
    '
    'pnlvacacion
    '
    Me.pnlvacacion.Controls.Add(Me.CtlVacacion1)
    Me.pnlvacacion.Location = New System.Drawing.Point(27, 277)
    Me.pnlvacacion.Margin = New System.Windows.Forms.Padding(4)
    Me.pnlvacacion.Name = "pnlvacacion"
    Me.pnlvacacion.Padding = New System.Windows.Forms.Padding(4)
    Me.pnlvacacion.Size = New System.Drawing.Size(304, 123)
    Me.pnlvacacion.TabIndex = 10
    Me.pnlvacacion.TabStop = False
    Me.pnlvacacion.Text = "Periodo Vacación"
    Me.pnlvacacion.Visible = False
    '
    'CtlVacacion1
    '
    Me.CtlVacacion1.Contrato = Nothing
    Me.CtlVacacion1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlVacacion1.FormattingEnabled = True
    Me.CtlVacacion1.ItemHeight = 16
    Me.CtlVacacion1.Location = New System.Drawing.Point(4, 19)
    Me.CtlVacacion1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlVacacion1.Name = "CtlVacacion1"
    Me.CtlVacacion1.Op = Nothing
    Me.CtlVacacion1.PuedeActualizar = True
    Me.CtlVacacion1.PuedeEliminar = True
    Me.CtlVacacion1.PuedeModificar = True
    Me.CtlVacacion1.PuedeNuevo = True
    Me.CtlVacacion1.Size = New System.Drawing.Size(296, 100)
    Me.CtlVacacion1.TabIndex = 0
    Me.CtlVacacion1.Vacacion = Nothing
    '
    'CtlAdjunto1
    '
    Me.CtlAdjunto1.Location = New System.Drawing.Point(133, 116)
    Me.CtlAdjunto1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlAdjunto1.Name = "CtlAdjunto1"
    Me.CtlAdjunto1.ParameAdjunto = Nothing
    Me.CtlAdjunto1.Size = New System.Drawing.Size(268, 122)
    Me.CtlAdjunto1.TabIndex = 8
    Me.CtlAdjunto1.UseCompatibleStateImageBehavior = False
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(27, 119)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(67, 17)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Adjuntos:"
    '
    'chckaprobado
    '
    Me.chckaprobado.AutoSize = True
    Me.chckaprobado.Location = New System.Drawing.Point(133, 247)
    Me.chckaprobado.Margin = New System.Windows.Forms.Padding(4)
    Me.chckaprobado.Name = "chckaprobado"
    Me.chckaprobado.Size = New System.Drawing.Size(92, 21)
    Me.chckaprobado.TabIndex = 9
    Me.chckaprobado.Text = "Aprobado"
    Me.chckaprobado.UseVisualStyleBackColor = True
    Me.chckaprobado.Visible = False
    '
    'FrmMantenimientoLicencia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(426, 452)
    Me.Controls.Add(Me.chckaprobado)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.chckFechafin)
    Me.Controls.Add(Me.CtlAdjunto1)
    Me.Controls.Add(Me.ComboBoxLicencia)
    Me.Controls.Add(Me.pnlvacacion)
    Me.Controls.Add(Me.dtfechahasta)
    Me.Controls.Add(Me.dtfechadesde)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5)
    Me.Name = "FrmMantenimientoLicencia"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Licencia / Permiso"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.dtfechadesde, 0)
    Me.Controls.SetChildIndex(Me.dtfechahasta, 0)
    Me.Controls.SetChildIndex(Me.pnlvacacion, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxLicencia, 0)
    Me.Controls.SetChildIndex(Me.CtlAdjunto1, 0)
    Me.Controls.SetChildIndex(Me.chckFechafin, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.chckaprobado, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlvacacion.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents dtfechadesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfechahasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents ComboBoxLicencia As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chckFechafin As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents pnlvacacion As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents CtlVacacion1 As CtlBeneficiosSociales
  Friend WithEvents CtlAdjunto1 As WWTS.General.Controles.CtlAdjunto
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents chckaprobado As Infoware.Controles.Base.CheckBoxStd
End Class
