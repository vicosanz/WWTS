<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaAreas
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
    Me.ComboBoxSeccion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.checkDepartamento = New Infoware.Controles.Base.CheckBoxStd()
    Me.ComboBoxDepartamento = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.btnreporte = New Infoware.Controles.Base.ButtonStd()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 417)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnreporte)
    Me.Panel1.Controls.Add(Me.ComboBoxDepartamento)
    Me.Panel1.Controls.Add(Me.checkDepartamento)
    Me.Panel1.Controls.Add(Me.ComboBoxSeccion)
    Me.Panel1.Controls.Add(Me.Label18)
    Me.Panel1.Size = New System.Drawing.Size(692, 51)
    Me.Panel1.Visible = True
    '
    'ComboBoxSeccion
    '
    Me.ComboBoxSeccion.AbriralEntrar = False
    Me.ComboBoxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSeccion.FormattingEnabled = True
    Me.ComboBoxSeccion.Location = New System.Drawing.Point(67, 12)
    Me.ComboBoxSeccion.Name = "ComboBoxSeccion"
    Me.ComboBoxSeccion.OperadorDatos = Nothing
    Me.ComboBoxSeccion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.ComboBoxSeccion.ParametroDet = Nothing
    Me.ComboBoxSeccion.PuedeActualizar = True
    Me.ComboBoxSeccion.PuedeEliminar = True
    Me.ComboBoxSeccion.PuedeModificar = True
    Me.ComboBoxSeccion.PuedeNuevo = True
    Me.ComboBoxSeccion.Size = New System.Drawing.Size(130, 21)
    Me.ComboBoxSeccion.TabIndex = 1
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(12, 15)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(49, 13)
    Me.Label18.TabIndex = 0
    Me.Label18.Text = "Sección:"
    '
    'checkDepartamento
    '
    Me.checkDepartamento.AutoSize = True
    Me.checkDepartamento.Location = New System.Drawing.Point(238, 14)
    Me.checkDepartamento.Name = "checkDepartamento"
    Me.checkDepartamento.Size = New System.Drawing.Size(96, 17)
    Me.checkDepartamento.TabIndex = 2
    Me.checkDepartamento.Text = "Departamento:"
    Me.checkDepartamento.UseVisualStyleBackColor = True
    '
    'ComboBoxDepartamento
    '
    Me.ComboBoxDepartamento.AbriralEntrar = False
    Me.ComboBoxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxDepartamento.Enabled = False
    Me.ComboBoxDepartamento.FormattingEnabled = True
    Me.ComboBoxDepartamento.Location = New System.Drawing.Point(340, 12)
    Me.ComboBoxDepartamento.Name = "ComboBoxDepartamento"
    Me.ComboBoxDepartamento.OperadorDatos = Nothing
    Me.ComboBoxDepartamento.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxDepartamento.ParametroDet = Nothing
    Me.ComboBoxDepartamento.PuedeActualizar = True
    Me.ComboBoxDepartamento.PuedeEliminar = True
    Me.ComboBoxDepartamento.PuedeModificar = True
    Me.ComboBoxDepartamento.PuedeNuevo = True
    Me.ComboBoxDepartamento.Size = New System.Drawing.Size(130, 21)
    Me.ComboBoxDepartamento.TabIndex = 3
    '
    'btnreporte
    '
    Me.btnreporte.Image = My.Resources.Resources.report
    Me.btnreporte.Location = New System.Drawing.Point(535, 12)
    Me.btnreporte.Name = "btnreporte"
    Me.btnreporte.Size = New System.Drawing.Size(99, 23)
    Me.btnreporte.TabIndex = 4
    Me.btnreporte.Text = "  Organigrama"
    Me.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnreporte.UseVisualStyleBackColor = True
    '
    'FrmListaAreas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Name = "FrmListaAreas"
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
  Friend WithEvents ComboBoxSeccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents checkDepartamento As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents ComboBoxDepartamento As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents btnreporte As Infoware.Controles.Base.ButtonStd

End Class
