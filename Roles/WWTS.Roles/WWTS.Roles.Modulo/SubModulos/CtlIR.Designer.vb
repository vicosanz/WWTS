<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlIR
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
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.dtfecactivo = New System.Windows.Forms.DateTimePicker
    Me.CtlPais1 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.dgParamIRs = New Infoware.Consola.Base.DataGridViewAutoDiscover
    Me.ImpRenFraccionBasicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ImpRenSecuenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ImpRenFechaDesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ImpRenSueldoHastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PardetPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.EsNuevoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.ImpRenSueldoDesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ParamePaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.EsModificadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.OperadorDatosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ImpRenFechaHastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ParametrodetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ParamIRListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.Panel1.SuspendLayout()
    CType(Me.dgParamIRs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ParamIRListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.dtfecactivo)
    Me.Panel1.Controls.Add(Me.CtlPais1)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(513, 45)
    Me.Panel1.TabIndex = 0
    '
    'dtfecactivo
    '
    Me.dtfecactivo.Location = New System.Drawing.Point(313, 10)
    Me.dtfecactivo.Name = "dtfecactivo"
    Me.dtfecactivo.Size = New System.Drawing.Size(211, 20)
    Me.dtfecactivo.TabIndex = 2
    '
    'CtlPais1
    '
    Me.CtlPais1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlPais1.FormattingEnabled = True
    Me.CtlPais1.Location = New System.Drawing.Point(80, 10)
    Me.CtlPais1.Name = "CtlPais1"
    Me.CtlPais1.OperadorDatos = Nothing
    Me.CtlPais1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlPais1.ParametroDet = Nothing
    Me.CtlPais1.PuedeActualizar = True
    Me.CtlPais1.PuedeEliminar = True
    Me.CtlPais1.PuedeModificar = True
    Me.CtlPais1.PuedeNuevo = True
    Me.CtlPais1.Size = New System.Drawing.Size(161, 21)
    Me.CtlPais1.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(261, 13)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Activo a"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(33, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "País"
    '
    'dgParamIRs
    '
    Me.dgParamIRs.AllowUserToOrderColumns = True
    Me.dgParamIRs.AutoGenerateColumns = False
    Me.dgParamIRs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgParamIRs.DataSource = Me.ParamIRListBindingSource
    Me.dgParamIRs.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgParamIRs.Location = New System.Drawing.Point(0, 45)
    Me.dgParamIRs.Name = "dgParamIRs"
    Me.dgParamIRs.RowTemplate.Height = 25
    Me.dgParamIRs.Size = New System.Drawing.Size(513, 356)
    Me.dgParamIRs.TabIndex = 1
    '
    'ImpRenFraccionBasicaDataGridViewTextBoxColumn
    '
    Me.ImpRenFraccionBasicaDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_FraccionBasica"
    Me.ImpRenFraccionBasicaDataGridViewTextBoxColumn.HeaderText = "ImpRen_FraccionBasica"
    Me.ImpRenFraccionBasicaDataGridViewTextBoxColumn.Name = "ImpRenFraccionBasicaDataGridViewTextBoxColumn"
    '
    'ImpRenSecuenciaDataGridViewTextBoxColumn
    '
    Me.ImpRenSecuenciaDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_Secuencia"
    Me.ImpRenSecuenciaDataGridViewTextBoxColumn.HeaderText = "ImpRen_Secuencia"
    Me.ImpRenSecuenciaDataGridViewTextBoxColumn.Name = "ImpRenSecuenciaDataGridViewTextBoxColumn"
    '
    'ImpRenFechaDesdeDataGridViewTextBoxColumn
    '
    Me.ImpRenFechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_FechaDesde"
    Me.ImpRenFechaDesdeDataGridViewTextBoxColumn.HeaderText = "ImpRen_FechaDesde"
    Me.ImpRenFechaDesdeDataGridViewTextBoxColumn.Name = "ImpRenFechaDesdeDataGridViewTextBoxColumn"
    '
    'ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn
    '
    Me.ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_PorcFraccionExcedente"
    Me.ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn.HeaderText = "ImpRen_PorcFraccionExcedente"
    Me.ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn.Name = "ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn"
    '
    'ImpRenSueldoHastaDataGridViewTextBoxColumn
    '
    Me.ImpRenSueldoHastaDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_SueldoHasta"
    Me.ImpRenSueldoHastaDataGridViewTextBoxColumn.HeaderText = "ImpRen_SueldoHasta"
    Me.ImpRenSueldoHastaDataGridViewTextBoxColumn.Name = "ImpRenSueldoHastaDataGridViewTextBoxColumn"
    '
    'PardetPaisDataGridViewTextBoxColumn
    '
    Me.PardetPaisDataGridViewTextBoxColumn.DataPropertyName = "Pardet_Pais"
    Me.PardetPaisDataGridViewTextBoxColumn.HeaderText = "Pardet_Pais"
    Me.PardetPaisDataGridViewTextBoxColumn.Name = "PardetPaisDataGridViewTextBoxColumn"
    '
    'EsNuevoDataGridViewCheckBoxColumn
    '
    Me.EsNuevoDataGridViewCheckBoxColumn.DataPropertyName = "EsNuevo"
    Me.EsNuevoDataGridViewCheckBoxColumn.HeaderText = "EsNuevo"
    Me.EsNuevoDataGridViewCheckBoxColumn.Name = "EsNuevoDataGridViewCheckBoxColumn"
    '
    'ImpRenSueldoDesdeDataGridViewTextBoxColumn
    '
    Me.ImpRenSueldoDesdeDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_SueldoDesde"
    Me.ImpRenSueldoDesdeDataGridViewTextBoxColumn.HeaderText = "ImpRen_SueldoDesde"
    Me.ImpRenSueldoDesdeDataGridViewTextBoxColumn.Name = "ImpRenSueldoDesdeDataGridViewTextBoxColumn"
    '
    'ParamePaisDataGridViewTextBoxColumn
    '
    Me.ParamePaisDataGridViewTextBoxColumn.DataPropertyName = "Parame_Pais"
    Me.ParamePaisDataGridViewTextBoxColumn.HeaderText = "Parame_Pais"
    Me.ParamePaisDataGridViewTextBoxColumn.Name = "ParamePaisDataGridViewTextBoxColumn"
    '
    'EsModificadoDataGridViewCheckBoxColumn
    '
    Me.EsModificadoDataGridViewCheckBoxColumn.DataPropertyName = "EsModificado"
    Me.EsModificadoDataGridViewCheckBoxColumn.HeaderText = "EsModificado"
    Me.EsModificadoDataGridViewCheckBoxColumn.Name = "EsModificadoDataGridViewCheckBoxColumn"
    '
    'OperadorDatosDataGridViewTextBoxColumn
    '
    Me.OperadorDatosDataGridViewTextBoxColumn.DataPropertyName = "OperadorDatos"
    Me.OperadorDatosDataGridViewTextBoxColumn.HeaderText = "OperadorDatos"
    Me.OperadorDatosDataGridViewTextBoxColumn.Name = "OperadorDatosDataGridViewTextBoxColumn"
    '
    'ImpRenFechaHastaDataGridViewTextBoxColumn
    '
    Me.ImpRenFechaHastaDataGridViewTextBoxColumn.DataPropertyName = "ImpRen_FechaHasta"
    Me.ImpRenFechaHastaDataGridViewTextBoxColumn.HeaderText = "ImpRen_FechaHasta"
    Me.ImpRenFechaHastaDataGridViewTextBoxColumn.Name = "ImpRenFechaHastaDataGridViewTextBoxColumn"
    '
    'ParametrodetDataGridViewTextBoxColumn
    '
    Me.ParametrodetDataGridViewTextBoxColumn.DataPropertyName = "Parametrodet"
    Me.ParametrodetDataGridViewTextBoxColumn.HeaderText = "Parametrodet"
    Me.ParametrodetDataGridViewTextBoxColumn.Name = "ParametrodetDataGridViewTextBoxColumn"
    '
    'ParamIRListBindingSource
    '
    Me.ParamIRListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.ImpuestoRentaList)
    '
    'CtlIR
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.dgParamIRs)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "CtlIR"
    Me.Size = New System.Drawing.Size(513, 401)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.dgParamIRs, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ParamIRListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents CtlPais1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents dgParamIRs As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents ParamIRListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents PirsueldodesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PirsueldohastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PirfraccionbasicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PirporcfracexcedenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dtfecactivo As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ImpRenFraccionBasicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImpRenSecuenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImpRenFechaDesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImpRenPorcFraccionExcedenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImpRenSueldoHastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PardetPaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EsNuevoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents ImpRenSueldoDesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ParamePaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EsModificadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents OperadorDatosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImpRenFechaHastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ParametrodetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
