<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReclutamiento
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Me.Label2 = New System.Windows.Forms.Label()
    Me.chckSectorDomicilio = New Infoware.Controles.Base.CheckBoxStd()
    Me.chckAspiracionSalarial = New Infoware.Controles.Base.CheckBoxStd()
    Me.txtAspSaldesde = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtAspSalhasta = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chckGenero = New Infoware.Controles.Base.CheckBoxStd()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNivelAcademico = New Infoware.Controles.Base.TextBoxCalculator()
    Me.cboGenero = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboSectorDomicilio = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboArea = New WWTS.General.Controles.ComboBoxParametroDet()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(884, 417)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.txtNivelAcademico)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.cboGenero)
    Me.Panel1.Controls.Add(Me.chckGenero)
    Me.Panel1.Controls.Add(Me.txtAspSalhasta)
    Me.Panel1.Controls.Add(Me.txtAspSaldesde)
    Me.Panel1.Controls.Add(Me.chckAspiracionSalarial)
    Me.Panel1.Controls.Add(Me.cboSectorDomicilio)
    Me.Panel1.Controls.Add(Me.chckSectorDomicilio)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.cboArea)
    Me.Panel1.Size = New System.Drawing.Size(884, 68)
    Me.Panel1.Visible = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(35, 15)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(32, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Área:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'chckSectorDomicilio
    '
    Me.chckSectorDomicilio.AutoSize = True
    Me.chckSectorDomicilio.Location = New System.Drawing.Point(35, 42)
    Me.chckSectorDomicilio.Name = "chckSectorDomicilio"
    Me.chckSectorDomicilio.Size = New System.Drawing.Size(105, 17)
    Me.chckSectorDomicilio.TabIndex = 6
    Me.chckSectorDomicilio.Text = "Sector Domicilio:"
    Me.chckSectorDomicilio.UseVisualStyleBackColor = True
    '
    'chckAspiracionSalarial
    '
    Me.chckAspiracionSalarial.AutoSize = True
    Me.chckAspiracionSalarial.Location = New System.Drawing.Point(303, 36)
    Me.chckAspiracionSalarial.Name = "chckAspiracionSalarial"
    Me.chckAspiracionSalarial.Size = New System.Drawing.Size(75, 30)
    Me.chckAspiracionSalarial.TabIndex = 8
    Me.chckAspiracionSalarial.Text = "Aspiración" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salarial:"
    Me.chckAspiracionSalarial.UseVisualStyleBackColor = True
    '
    'txtAspSaldesde
    '
    Me.txtAspSaldesde.Enabled = False
    Me.txtAspSaldesde.Location = New System.Drawing.Point(381, 40)
    Me.txtAspSaldesde.Mensaje = ""
    Me.txtAspSaldesde.Name = "txtAspSaldesde"
    Me.txtAspSaldesde.NumeroDecimales = 0
    Me.txtAspSaldesde.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAspSaldesde.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtAspSaldesde.PromptText = "Desde"
    Me.txtAspSaldesde.Size = New System.Drawing.Size(50, 20)
    Me.txtAspSaldesde.TabIndex = 9
    Me.txtAspSaldesde.Text = "0"
    Me.txtAspSaldesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtAspSaldesde.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtAspSaldesde.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtAspSaldesde.Value = 0.0R
    '
    'txtAspSalhasta
    '
    Me.txtAspSalhasta.Enabled = False
    Me.txtAspSalhasta.Location = New System.Drawing.Point(451, 40)
    Me.txtAspSalhasta.Mensaje = ""
    Me.txtAspSalhasta.Name = "txtAspSalhasta"
    Me.txtAspSalhasta.NumeroDecimales = 0
    Me.txtAspSalhasta.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAspSalhasta.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtAspSalhasta.PromptText = "Hasta"
    Me.txtAspSalhasta.Size = New System.Drawing.Size(50, 20)
    Me.txtAspSalhasta.TabIndex = 10
    Me.txtAspSalhasta.Text = "0"
    Me.txtAspSalhasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtAspSalhasta.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtAspSalhasta.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtAspSalhasta.Value = 0.0R
    '
    'chckGenero
    '
    Me.chckGenero.AutoSize = True
    Me.chckGenero.Location = New System.Drawing.Point(403, 14)
    Me.chckGenero.Name = "chckGenero"
    Me.chckGenero.Size = New System.Drawing.Size(64, 17)
    Me.chckGenero.TabIndex = 4
    Me.chckGenero.Text = "Género:"
    Me.chckGenero.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(229, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(90, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Nivel Académico:"
    '
    'txtNivelAcademico
    '
    Me.txtNivelAcademico.Location = New System.Drawing.Point(323, 12)
    Me.txtNivelAcademico.Mensaje = ""
    Me.txtNivelAcademico.Name = "txtNivelAcademico"
    Me.txtNivelAcademico.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNivelAcademico.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtNivelAcademico.PromptText = ""
    Me.txtNivelAcademico.Size = New System.Drawing.Size(50, 20)
    Me.txtNivelAcademico.TabIndex = 3
    Me.txtNivelAcademico.Text = "0"
    Me.txtNivelAcademico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtNivelAcademico.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtNivelAcademico.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtNivelAcademico.Value = 0.0R
    '
    'cboGenero
    '
    Me.cboGenero.AbriralEntrar = False
    Me.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGenero.Enabled = False
    Me.cboGenero.FormattingEnabled = True
    Me.cboGenero.Location = New System.Drawing.Point(471, 12)
    Me.cboGenero.Name = "cboGenero"
    Me.cboGenero.OperadorDatos = Nothing
    Me.cboGenero.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboGenero.ParametroDet = Nothing
    Me.cboGenero.PuedeActualizar = True
    Me.cboGenero.PuedeEliminar = True
    Me.cboGenero.PuedeModificar = True
    Me.cboGenero.PuedeNuevo = True
    Me.cboGenero.Size = New System.Drawing.Size(129, 21)
    Me.cboGenero.TabIndex = 5
    '
    'cboSectorDomicilio
    '
    Me.cboSectorDomicilio.AbriralEntrar = False
    Me.cboSectorDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSectorDomicilio.Enabled = False
    Me.cboSectorDomicilio.FormattingEnabled = True
    Me.cboSectorDomicilio.Location = New System.Drawing.Point(144, 40)
    Me.cboSectorDomicilio.Name = "cboSectorDomicilio"
    Me.cboSectorDomicilio.OperadorDatos = Nothing
    Me.cboSectorDomicilio.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cboSectorDomicilio.ParametroDet = Nothing
    Me.cboSectorDomicilio.PuedeActualizar = True
    Me.cboSectorDomicilio.PuedeEliminar = True
    Me.cboSectorDomicilio.PuedeModificar = True
    Me.cboSectorDomicilio.PuedeNuevo = True
    Me.cboSectorDomicilio.Size = New System.Drawing.Size(129, 21)
    Me.cboSectorDomicilio.TabIndex = 7
    '
    'cboArea
    '
    Me.cboArea.AbriralEntrar = False
    Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboArea.FormattingEnabled = True
    Me.cboArea.Location = New System.Drawing.Point(70, 12)
    Me.cboArea.Name = "cboArea"
    Me.cboArea.OperadorDatos = Nothing
    Me.cboArea.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Area
    Me.cboArea.ParametroDet = Nothing
    Me.cboArea.PuedeActualizar = True
    Me.cboArea.PuedeEliminar = True
    Me.cboArea.PuedeModificar = True
    Me.cboArea.PuedeNuevo = True
    Me.cboArea.Size = New System.Drawing.Size(129, 21)
    Me.cboArea.TabIndex = 1
    '
    'FrmReclutamiento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(884, 466)
    Me.Name = "FrmReclutamiento"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboSectorDomicilio As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboArea As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chckSectorDomicilio As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents txtAspSalhasta As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtAspSaldesde As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents chckAspiracionSalarial As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chckGenero As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents cboGenero As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents txtNivelAcademico As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
