<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoCargo
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.chkControlarHE = New Infoware.Controles.Base.CheckBoxStd()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtDescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.cboSeccionJefe = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboSeccion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Panel2 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cboDepartamentoJefe = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.CtlArea1Jefe = New CtlArea()
    Me.CtlCargo1Jefe = New CtlCargo()
    Me.chkTieneJefe = New Infoware.Controles.Base.CheckBoxStd()
    Me.cboDepartamento = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.CtlArea1 = New CtlArea()
    Me.CtlModeloLabor1 = New CtlModeloLabor()
    Me.ComboBoxActividadSectorial = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.cboEscalafon = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(20, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Sección:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(20, 71)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(32, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Área:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(20, 99)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(66, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Descripción:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(20, 126)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(71, 13)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "Modelo labor:"
    '
    'chkControlarHE
    '
    Me.chkControlarHE.AutoSize = True
    Me.chkControlarHE.Location = New System.Drawing.Point(110, 181)
    Me.chkControlarHE.Name = "chkControlarHE"
    Me.chkControlarHE.Size = New System.Drawing.Size(128, 17)
    Me.chkControlarHE.TabIndex = 12
    Me.chkControlarHE.Text = "Controlar horas extras"
    Me.chkControlarHE.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(10, 23)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(49, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Sección:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(10, 79)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(32, 13)
    Me.Label7.TabIndex = 4
    Me.Label7.Text = "Área:"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(10, 107)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(38, 13)
    Me.Label8.TabIndex = 6
    Me.Label8.Text = "Cargo:"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(110, 96)
    Me.txtDescripcion.Mensaje = ""
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtDescripcion.PromptText = ""
    Me.txtDescripcion.Size = New System.Drawing.Size(214, 20)
    Me.txtDescripcion.TabIndex = 7
    Me.txtDescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'cboSeccionJefe
    '
    Me.cboSeccionJefe.AbriralEntrar = False
    Me.cboSeccionJefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccionJefe.FormattingEnabled = True
    Me.cboSeccionJefe.Location = New System.Drawing.Point(98, 20)
    Me.cboSeccionJefe.Name = "cboSeccionJefe"
    Me.cboSeccionJefe.OperadorDatos = Nothing
    Me.cboSeccionJefe.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cboSeccionJefe.ParametroDet = Nothing
    Me.cboSeccionJefe.PuedeActualizar = True
    Me.cboSeccionJefe.PuedeEliminar = True
    Me.cboSeccionJefe.PuedeModificar = True
    Me.cboSeccionJefe.PuedeNuevo = True
    Me.cboSeccionJefe.Size = New System.Drawing.Size(210, 21)
    Me.cboSeccionJefe.TabIndex = 1
    '
    'cboSeccion
    '
    Me.cboSeccion.AbriralEntrar = False
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(110, 12)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.OperadorDatos = Nothing
    Me.cboSeccion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cboSeccion.ParametroDet = Nothing
    Me.cboSeccion.PuedeActualizar = True
    Me.cboSeccion.PuedeEliminar = True
    Me.cboSeccion.PuedeModificar = True
    Me.cboSeccion.PuedeNuevo = True
    Me.cboSeccion.Size = New System.Drawing.Size(212, 21)
    Me.cboSeccion.TabIndex = 1
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Label9)
    Me.Panel2.Controls.Add(Me.cboDepartamentoJefe)
    Me.Panel2.Controls.Add(Me.CtlArea1Jefe)
    Me.Panel2.Controls.Add(Me.cboSeccionJefe)
    Me.Panel2.Controls.Add(Me.Label6)
    Me.Panel2.Controls.Add(Me.CtlCargo1Jefe)
    Me.Panel2.Controls.Add(Me.Label7)
    Me.Panel2.Controls.Add(Me.Label8)
    Me.Panel2.Location = New System.Drawing.Point(12, 267)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(323, 135)
    Me.Panel2.TabIndex = 16
    Me.Panel2.TabStop = False
    Me.Panel2.Text = "Jefe Inmediato"
    Me.Panel2.Visible = False
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(10, 51)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(77, 13)
    Me.Label9.TabIndex = 2
    Me.Label9.Text = "Departamento:"
    '
    'cboDepartamentoJefe
    '
    Me.cboDepartamentoJefe.AbriralEntrar = False
    Me.cboDepartamentoJefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDepartamentoJefe.FormattingEnabled = True
    Me.cboDepartamentoJefe.Location = New System.Drawing.Point(98, 48)
    Me.cboDepartamentoJefe.Name = "cboDepartamentoJefe"
    Me.cboDepartamentoJefe.OperadorDatos = Nothing
    Me.cboDepartamentoJefe.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboDepartamentoJefe.ParametroDet = Nothing
    Me.cboDepartamentoJefe.PuedeActualizar = True
    Me.cboDepartamentoJefe.PuedeEliminar = True
    Me.cboDepartamentoJefe.PuedeModificar = True
    Me.cboDepartamentoJefe.PuedeNuevo = True
    Me.cboDepartamentoJefe.Size = New System.Drawing.Size(210, 21)
    Me.cboDepartamentoJefe.TabIndex = 3
    '
    'CtlArea1Jefe
    '
    Me.CtlArea1Jefe.AbriralEntrar = False
    Me.CtlArea1Jefe.Area = Nothing
    Me.CtlArea1Jefe.Departamento = Nothing
    Me.CtlArea1Jefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlArea1Jefe.FormattingEnabled = True
    Me.CtlArea1Jefe.Location = New System.Drawing.Point(98, 76)
    Me.CtlArea1Jefe.Name = "CtlArea1Jefe"
    Me.CtlArea1Jefe.Op = Nothing
    Me.CtlArea1Jefe.PuedeActualizar = True
    Me.CtlArea1Jefe.PuedeEliminar = True
    Me.CtlArea1Jefe.PuedeModificar = True
    Me.CtlArea1Jefe.PuedeNuevo = True
    Me.CtlArea1Jefe.Seccion = Nothing
    Me.CtlArea1Jefe.Size = New System.Drawing.Size(210, 21)
    Me.CtlArea1Jefe.TabIndex = 5
    '
    'CtlCargo1Jefe
    '
    Me.CtlCargo1Jefe.AbriralEntrar = False
    Me.CtlCargo1Jefe.Area = Nothing
    Me.CtlCargo1Jefe.Cargo = Nothing
    Me.CtlCargo1Jefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlCargo1Jefe.FormattingEnabled = True
    Me.CtlCargo1Jefe.Location = New System.Drawing.Point(98, 104)
    Me.CtlCargo1Jefe.Name = "CtlCargo1Jefe"
    Me.CtlCargo1Jefe.Op = Nothing
    Me.CtlCargo1Jefe.PuedeActualizar = True
    Me.CtlCargo1Jefe.PuedeEliminar = True
    Me.CtlCargo1Jefe.PuedeModificar = True
    Me.CtlCargo1Jefe.PuedeNuevo = True
    Me.CtlCargo1Jefe.Size = New System.Drawing.Size(210, 21)
    Me.CtlCargo1Jefe.TabIndex = 7
    '
    'chkTieneJefe
    '
    Me.chkTieneJefe.AutoSize = True
    Me.chkTieneJefe.Location = New System.Drawing.Point(110, 206)
    Me.chkTieneJefe.Name = "chkTieneJefe"
    Me.chkTieneJefe.Size = New System.Drawing.Size(76, 17)
    Me.chkTieneJefe.TabIndex = 13
    Me.chkTieneJefe.Text = "Tiene Jefe"
    Me.chkTieneJefe.UseVisualStyleBackColor = True
    '
    'cboDepartamento
    '
    Me.cboDepartamento.AbriralEntrar = False
    Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDepartamento.FormattingEnabled = True
    Me.cboDepartamento.Location = New System.Drawing.Point(110, 40)
    Me.cboDepartamento.Name = "cboDepartamento"
    Me.cboDepartamento.OperadorDatos = Nothing
    Me.cboDepartamento.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboDepartamento.ParametroDet = Nothing
    Me.cboDepartamento.PuedeActualizar = True
    Me.cboDepartamento.PuedeEliminar = True
    Me.cboDepartamento.PuedeModificar = True
    Me.cboDepartamento.PuedeNuevo = True
    Me.cboDepartamento.Size = New System.Drawing.Size(212, 21)
    Me.cboDepartamento.TabIndex = 3
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(20, 43)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(77, 13)
    Me.Label5.TabIndex = 2
    Me.Label5.Text = "Departamento:"
    '
    'CtlArea1
    '
    Me.CtlArea1.AbriralEntrar = False
    Me.CtlArea1.Area = Nothing
    Me.CtlArea1.Departamento = Nothing
    Me.CtlArea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlArea1.FormattingEnabled = True
    Me.CtlArea1.Location = New System.Drawing.Point(110, 68)
    Me.CtlArea1.Name = "CtlArea1"
    Me.CtlArea1.Op = Nothing
    Me.CtlArea1.PuedeActualizar = True
    Me.CtlArea1.PuedeEliminar = True
    Me.CtlArea1.PuedeModificar = True
    Me.CtlArea1.PuedeNuevo = True
    Me.CtlArea1.Seccion = Nothing
    Me.CtlArea1.Size = New System.Drawing.Size(212, 21)
    Me.CtlArea1.TabIndex = 5
    '
    'CtlModeloLabor1
    '
    Me.CtlModeloLabor1.AbriralEntrar = False
    Me.CtlModeloLabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlModeloLabor1.FormattingEnabled = True
    Me.CtlModeloLabor1.Location = New System.Drawing.Point(110, 123)
    Me.CtlModeloLabor1.ModeloLabor = Nothing
    Me.CtlModeloLabor1.Name = "CtlModeloLabor1"
    Me.CtlModeloLabor1.Op = Nothing
    Me.CtlModeloLabor1.PuedeActualizar = True
    Me.CtlModeloLabor1.PuedeEliminar = True
    Me.CtlModeloLabor1.PuedeModificar = True
    Me.CtlModeloLabor1.PuedeNuevo = True
    Me.CtlModeloLabor1.Size = New System.Drawing.Size(212, 21)
    Me.CtlModeloLabor1.TabIndex = 9
    '
    'ComboBoxActividadSectorial
    '
    Me.ComboBoxActividadSectorial.AbriralEntrar = False
    Me.ComboBoxActividadSectorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxActividadSectorial.FormattingEnabled = True
    Me.ComboBoxActividadSectorial.Location = New System.Drawing.Point(110, 152)
    Me.ComboBoxActividadSectorial.Name = "ComboBoxActividadSectorial"
    Me.ComboBoxActividadSectorial.OperadorDatos = Nothing
    Me.ComboBoxActividadSectorial.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxActividadSectorial.ParametroDet = Nothing
    Me.ComboBoxActividadSectorial.PuedeActualizar = True
    Me.ComboBoxActividadSectorial.PuedeEliminar = True
    Me.ComboBoxActividadSectorial.PuedeModificar = True
    Me.ComboBoxActividadSectorial.PuedeNuevo = True
    Me.ComboBoxActividadSectorial.Size = New System.Drawing.Size(212, 21)
    Me.ComboBoxActividadSectorial.TabIndex = 11
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(20, 152)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(90, 26)
    Me.Label10.TabIndex = 10
    Me.Label10.Text = "Código Actividad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sectorial IESS:"
    '
    'cboEscalafon
    '
    Me.cboEscalafon.AbriralEntrar = False
    Me.cboEscalafon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEscalafon.FormattingEnabled = True
    Me.cboEscalafon.Location = New System.Drawing.Point(110, 229)
    Me.cboEscalafon.Name = "cboEscalafon"
    Me.cboEscalafon.OperadorDatos = Nothing
    Me.cboEscalafon.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cboEscalafon.ParametroDet = Nothing
    Me.cboEscalafon.PuedeActualizar = True
    Me.cboEscalafon.PuedeEliminar = True
    Me.cboEscalafon.PuedeModificar = True
    Me.cboEscalafon.PuedeNuevo = True
    Me.cboEscalafon.Size = New System.Drawing.Size(210, 21)
    Me.cboEscalafon.TabIndex = 15
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(18, 232)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(57, 13)
    Me.Label11.TabIndex = 14
    Me.Label11.Text = "Escalafón:"
    '
    'FrmMantenimientoCargo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(347, 445)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.ComboBoxActividadSectorial)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.cboDepartamento)
    Me.Controls.Add(Me.CtlArea1)
    Me.Controls.Add(Me.chkTieneJefe)
    Me.Controls.Add(Me.CtlModeloLabor1)
    Me.Controls.Add(Me.txtDescripcion)
    Me.Controls.Add(Me.chkControlarHE)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cboEscalafon)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.Panel2)
    Me.Name = "FrmMantenimientoCargo"
    Me.Text = "Cargo"
    Me.Controls.SetChildIndex(Me.Panel2, 0)
    Me.Controls.SetChildIndex(Me.cboSeccion, 0)
    Me.Controls.SetChildIndex(Me.cboEscalafon, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label11, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.chkControlarHE, 0)
    Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
    Me.Controls.SetChildIndex(Me.CtlModeloLabor1, 0)
    Me.Controls.SetChildIndex(Me.chkTieneJefe, 0)
    Me.Controls.SetChildIndex(Me.CtlArea1, 0)
    Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxActividadSectorial, 0)
    Me.Controls.SetChildIndex(Me.Label10, 0)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboSeccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents chkControlarHE As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents cboSeccionJefe As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtDescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents CtlModeloLabor1 As CtlModeloLabor
  Friend WithEvents CtlCargo1Jefe As CtlCargo
  Friend WithEvents Panel2 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents chkTieneJefe As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents CtlArea1 As CtlArea
  Friend WithEvents CtlArea1Jefe As CtlArea
  Friend WithEvents cboDepartamento As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents cboDepartamentoJefe As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents ComboBoxActividadSectorial As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents cboEscalafon As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
