<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlDiaAsistencia
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
    Me.chkasistencia = New System.Windows.Forms.CheckBox
    Me.lbl_descrip = New System.Windows.Forms.Label
    Me.cboestado = New WWTS.General.Controles.ComboBoxParametroDet
    Me.lblesnuevo = New System.Windows.Forms.Label
    Me.txtjornada = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtsobret50 = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtsobret100 = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtsobret25 = New Infoware.Controles.Base.TextBoxCalculator
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.CtlTarea1 = New WWTS.Roles.Modulo.CtlTarea
    Me.CtlLabor1 = New WWTS.Roles.Modulo.CtlLabor
    Me.SuspendLayout()
    '
    'chkasistencia
    '
    Me.chkasistencia.AutoSize = True
    Me.chkasistencia.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.chkasistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkasistencia.Location = New System.Drawing.Point(36, 0)
    Me.chkasistencia.Name = "chkasistencia"
    Me.chkasistencia.Size = New System.Drawing.Size(51, 16)
    Me.chkasistencia.TabIndex = 1
    Me.chkasistencia.Text = "Asistió"
    Me.chkasistencia.UseVisualStyleBackColor = False
    '
    'lbl_descrip
    '
    Me.lbl_descrip.BackColor = System.Drawing.Color.White
    Me.lbl_descrip.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbl_descrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_descrip.Location = New System.Drawing.Point(0, 0)
    Me.lbl_descrip.Name = "lbl_descrip"
    Me.lbl_descrip.Size = New System.Drawing.Size(84, 15)
    Me.lbl_descrip.TabIndex = 0
    Me.lbl_descrip.Text = "MI, 31"
    Me.lbl_descrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cboestado
    '
    Me.cboestado.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboestado.Location = New System.Drawing.Point(0, 15)
    Me.cboestado.Name = "cboestado"
    Me.cboestado.OperadorDatos = Nothing
    Me.cboestado.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboestado.ParametroDet = Nothing
    Me.cboestado.PuedeActualizar = True
    Me.cboestado.PuedeEliminar = True
    Me.cboestado.PuedeModificar = True
    Me.cboestado.PuedeNuevo = True
    Me.cboestado.Size = New System.Drawing.Size(84, 20)
    Me.cboestado.TabIndex = 2
    '
    'lblesnuevo
    '
    Me.lblesnuevo.BackColor = System.Drawing.SystemColors.Info
    Me.lblesnuevo.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblesnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblesnuevo.Location = New System.Drawing.Point(0, 117)
    Me.lblesnuevo.Name = "lblesnuevo"
    Me.lblesnuevo.Size = New System.Drawing.Size(84, 12)
    Me.lblesnuevo.TabIndex = 9
    Me.lblesnuevo.Text = "No grabado"
    Me.lblesnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtjornada
    '
    Me.txtjornada.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtjornada.Location = New System.Drawing.Point(60, 35)
    Me.txtjornada.Mensaje = ""
    Me.txtjornada.Name = "txtjornada"
    Me.txtjornada.Size = New System.Drawing.Size(24, 18)
    Me.txtjornada.TabIndex = 4
    Me.txtjornada.Text = "0"
    Me.txtjornada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtjornada.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtjornada.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.ToolTip1.SetToolTip(Me.txtjornada, "Horas normales")
    Me.txtjornada.Value = 0
    '
    'txtsobret50
    '
    Me.txtsobret50.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtsobret50.Location = New System.Drawing.Point(60, 51)
    Me.txtsobret50.Mensaje = ""
    Me.txtsobret50.Name = "txtsobret50"
    Me.txtsobret50.Size = New System.Drawing.Size(24, 18)
    Me.txtsobret50.TabIndex = 5
    Me.txtsobret50.Text = "0"
    Me.txtsobret50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtsobret50.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtsobret50.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.ToolTip1.SetToolTip(Me.txtsobret50, "Horas 50%")
    Me.txtsobret50.Value = 0
    '
    'txtsobret100
    '
    Me.txtsobret100.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtsobret100.Location = New System.Drawing.Point(60, 67)
    Me.txtsobret100.Mensaje = ""
    Me.txtsobret100.Name = "txtsobret100"
    Me.txtsobret100.Size = New System.Drawing.Size(24, 18)
    Me.txtsobret100.TabIndex = 6
    Me.txtsobret100.Text = "0"
    Me.txtsobret100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtsobret100.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtsobret100.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.ToolTip1.SetToolTip(Me.txtsobret100, "Horas 100%")
    Me.txtsobret100.Value = 0
    '
    'txtsobret25
    '
    Me.txtsobret25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtsobret25.Location = New System.Drawing.Point(60, 83)
    Me.txtsobret25.Mensaje = ""
    Me.txtsobret25.Name = "txtsobret25"
    Me.txtsobret25.Size = New System.Drawing.Size(24, 18)
    Me.txtsobret25.TabIndex = 7
    Me.txtsobret25.Text = "0"
    Me.txtsobret25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtsobret25.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtsobret25.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.ToolTip1.SetToolTip(Me.txtsobret25, "Horas 25%")
    Me.txtsobret25.Value = 0
    '
    'CtlTarea1
    '
    Me.CtlTarea1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlTarea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CtlTarea1.FormattingEnabled = True
    Me.CtlTarea1.ItemHeight = 9
    Me.CtlTarea1.Location = New System.Drawing.Point(0, 35)
    Me.CtlTarea1.Margin = New System.Windows.Forms.Padding(0)
    Me.CtlTarea1.Name = "CtlTarea1"
    Me.CtlTarea1.Op = Nothing
    Me.CtlTarea1.PuedeActualizar = True
    Me.CtlTarea1.PuedeEliminar = True
    Me.CtlTarea1.PuedeModificar = True
    Me.CtlTarea1.PuedeNuevo = True
    Me.CtlTarea1.Size = New System.Drawing.Size(57, 58)
    Me.CtlTarea1.TabIndex = 3
    Me.CtlTarea1.Tarea = Nothing
    '
    'CtlLabor1
    '
    Me.CtlLabor1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.CtlLabor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CtlLabor1.Labor = Nothing
    Me.CtlLabor1.Location = New System.Drawing.Point(0, 96)
    Me.CtlLabor1.Name = "CtlLabor1"
    Me.CtlLabor1.Op = Nothing
    Me.CtlLabor1.Size = New System.Drawing.Size(84, 21)
    Me.CtlLabor1.TabIndex = 8
    '
    'CtlDiaAsistencia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtsobret25)
    Me.Controls.Add(Me.txtsobret100)
    Me.Controls.Add(Me.txtsobret50)
    Me.Controls.Add(Me.txtjornada)
    Me.Controls.Add(Me.CtlTarea1)
    Me.Controls.Add(Me.CtlLabor1)
    Me.Controls.Add(Me.cboestado)
    Me.Controls.Add(Me.chkasistencia)
    Me.Controls.Add(Me.lbl_descrip)
    Me.Controls.Add(Me.lblesnuevo)
    Me.Margin = New System.Windows.Forms.Padding(0)
    Me.Name = "CtlDiaAsistencia"
    Me.Size = New System.Drawing.Size(84, 129)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents chkasistencia As System.Windows.Forms.CheckBox
  Friend WithEvents lbl_descrip As System.Windows.Forms.Label
  Friend WithEvents cboestado As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlTarea1 As CtlTarea
  Friend WithEvents CtlLabor1 As CtlLabor
  Friend WithEvents lblesnuevo As System.Windows.Forms.Label
  Friend WithEvents txtjornada As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtsobret50 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtsobret100 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtsobret25 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
