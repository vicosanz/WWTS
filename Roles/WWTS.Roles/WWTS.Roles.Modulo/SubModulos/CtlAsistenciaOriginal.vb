Imports Microsoft.Office.Interop
Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports System.Reflection

Public Class CtlAsistenciaO
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value

      If value IsNot Nothing Then
        'Me.CtlLabor1.Op = value
        'Me.CtlLabor1.llenar_datos()

        ColumnasPermiso()
        ColumnasAsistencia()

        Me.chkverdias(System.DayOfWeek.Monday) = Me.chklunes
        Me.chkverdias(System.DayOfWeek.Tuesday) = Me.chkmartes
        Me.chkverdias(System.DayOfWeek.Wednesday) = Me.chkmiercoles
        Me.chkverdias(System.DayOfWeek.Thursday) = Me.chkjueves
        Me.chkverdias(System.DayOfWeek.Friday) = Me.chkviernes
        Me.chkverdias(System.DayOfWeek.Saturday) = Me.chksabado
        Me.chkverdias(System.DayOfWeek.Sunday) = Me.chkdomingo

        Me.chkverdias(System.DayOfWeek.Monday + 7) = Me.chklunes2
        Me.chkverdias(System.DayOfWeek.Tuesday + 7) = Me.chkmartes2
        Me.chkverdias(System.DayOfWeek.Wednesday + 7) = Me.chkmiercoles2
        Me.chkverdias(System.DayOfWeek.Thursday + 7) = Me.chkjueves2
        Me.chkverdias(System.DayOfWeek.Friday + 7) = Me.chkviernes2
        Me.chkverdias(System.DayOfWeek.Saturday + 7) = Me.chksabado2
        Me.chkverdias(System.DayOfWeek.Sunday + 7) = Me.chkdomingo2

        Me.ElementoListBindingSource.DataSource = ParametroDetList.ObtenerLista(mOp, Enumerados.EnumParametros.TipoPermiso)

        Dim _diasvac As New ElementoList
        _diasvac.Add(New Elemento(0, "0", ""))
        _diasvac.Add(New Elemento(15, "15", ""))

        cbodiasvac.DataSource = _diasvac
        cbodiasvac.DisplayMember = "Descripcion"
        cbodiasvac.ValueMember = "Numero"

        Dim _diasfal As New ElementoList
        _diasfal.Add(New Elemento(0, "0", ""))
        _diasfal.Add(New Elemento(2, "2", ""))

        cbodiasfaltas.DataSource = _diasfal
        cbodiasfaltas.DisplayMember = "Descripcion"
        cbodiasfaltas.ValueMember = "Numero"
      End If
    End Set
  End Property

  Private mContrato As Contrato = Nothing
  Private mPeriodo As PeriodoPago = Nothing
  Private mEmpleado As Empleado = Nothing
  Private mPatrono As Patrono = Nothing
  Private mTipoContrato As TipoContrato = Nothing
  Private mAsistencia As Asistencia = Nothing
  'Private diasasistencias(16) As CtlDiaAsistencia
  Private chkverdias(14) As CheckBox
  Dim okcalcular As Boolean = False

  Public WriteOnly Property ManipularRestriccion() As Boolean
    Set(ByVal Value As Boolean)
      Me.chkdescontarprest.Enabled = Value
      Me.chkdescontarprestquirog.Enabled = Value
      Me.chkdescontarseguro.Enabled = Value
    End Set
  End Property

#Region "Propiedades"
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(ByVal Value As Contrato)
      mContrato = Value
      If Value Is Nothing Then
        mEmpleado = Nothing
      Else
        mEmpleado = Value.Empleado
        mPatrono = Value.Patrono
        mTipoContrato = Value.Tipocontrato
      End If
      mAsistencia = Nothing
      llenar_datos()
    End Set
  End Property

  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(ByVal Value As Empleado)
      mEmpleado = Value
      mContrato = Nothing
      mTipoContrato = Nothing
      mPatrono = Nothing
      mAsistencia = Nothing
      llenar_datos()
    End Set
  End Property

  Public Property patrono() As Patrono
    Get
      Return mPatrono
    End Get
    Set(ByVal Value As Patrono)
      mPatrono = Value
      mContrato = Nothing
      mAsistencia = Nothing
      llenar_datos()
    End Set
  End Property

  Public Property Periodo() As PeriodoPago
    Get
      Return mPeriodo
    End Get
    Set(ByVal Value As PeriodoPago)
      mPeriodo = Value
      'mContrato = Nothing
      mAsistencia = Nothing
      llenar_datos()
    End Set
  End Property

  Public Property TipoContrato() As TipoContrato
    Get
      Return mTipoContrato
    End Get
    Set(ByVal Value As TipoContrato)
      mTipoContrato = Value
      mAsistencia = Nothing
      mContrato = Nothing
      llenar_datos()
    End Set
  End Property

  Public Property Asistencia() As Asistencia
    Get
      Return mAsistencia
    End Get
    Set(ByVal Value As Asistencia)
      mAsistencia = Value
      If Value Is Nothing Then
        mContrato = Nothing
        mPeriodo = Nothing
      Else
        mPatrono = mAsistencia.Patrono
        mContrato = mAsistencia.Contrato
        mEmpleado = mAsistencia.Empleado
        mPeriodo = mAsistencia.Periodopago
        mTipoContrato = mAsistencia.Tipocontrato
      End If
      llenar_datos()
    End Set
  End Property
#End Region

  Private WithEvents _Avisos As PermisoList

  Private Sub ColumnasPermiso()
    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoPermisoString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo de permiso"
    DataGridViewTextBoxColumn1.Width = 200
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Permis_FechaDesde"
    DataGridViewTextBoxColumn1.HeaderText = "Desde"
    DataGridViewTextBoxColumn1.Width = 120
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Permis_FechaHasta"
    DataGridViewTextBoxColumn1.HeaderText = "Hasta"
    DataGridViewTextBoxColumn1.Width = 120
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Private Sub ColumnasAsistencia()
    Dim BSEstadoDia As New BindingSource
    BSEstadoDia.DataSource = ParametroDetList.ObtenerLista(mOp, Enumerados.EnumParametros.EstadoDiaLabor)

    Dim BSTarea As New BindingSource
    BSTarea.DataSource = TareaList.ObtenerLista(mOp)

    Dim BSLabor As New BindingSource
    BSLabor.DataSource = LaborList.ObtenerLista(mOp)

    Me.DataGridView2.Columns.Clear()

    Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "esNuevo"
    DataGridViewTextBoxColumn0.HeaderText = "Sin guardar"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 48
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "FechaString"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 110
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "WebHorainicio"
    DataGridViewTextBoxColumn1.HeaderText = "Entrada"
    DataGridViewTextBoxColumn1.Width = 70
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "WebHoraFin"
    DataGridViewTextBoxColumn1.HeaderText = "Salida"
    DataGridViewTextBoxColumn1.Width = 70
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "DiaAsi_Asistencia"
    DataGridViewTextBoxColumn0.HeaderText = "Asistió"
    DataGridViewTextBoxColumn0.Width = 50
    DataGridViewTextBoxColumn0.ReadOnly = True
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Pardet_EstadoDia"
    DataGridViewTextBoxColumn2.DataSource = BSEstadoDia
    DataGridViewTextBoxColumn2.DisplayMember = "Pardet_Descripcion"
    DataGridViewTextBoxColumn2.ValueMember = "Pardet_Secuencia"
    DataGridViewTextBoxColumn2.HeaderText = "Estado"
    DataGridViewTextBoxColumn2.Width = 90
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    'DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
    'DataGridViewTextBoxColumn2.DataPropertyName = "Tarea_codigo"
    'DataGridViewTextBoxColumn2.DataSource = BSTarea
    'DataGridViewTextBoxColumn2.DisplayMember = "Tarea_descripcion"
    'DataGridViewTextBoxColumn2.ValueMember = "Tarea_codigo"
    'DataGridViewTextBoxColumn2.HeaderText = "Tarea"
    'DataGridViewTextBoxColumn2.Width = 90
    'Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    Dim estilonum0 As New DataGridViewCellStyle()
    estilonum0.Format = "N0"

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Jornada"
    DataGridViewTextBoxColumn1.HeaderText = "Horas normales"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret25"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 25"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret50"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 50"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret100"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 100 Sup"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret100b"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 100 Ext"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
    'DataGridViewTextBoxColumn2.DataPropertyName = "CodigoLargo"
    'DataGridViewTextBoxColumn2.DataSource = BSLabor
    'DataGridViewTextBoxColumn2.DisplayMember = "DescripcionLarga"
    'DataGridViewTextBoxColumn2.ValueMember = "CodigoLargo"
    'DataGridViewTextBoxColumn2.HeaderText = "Sección/Labor"
    'DataGridViewTextBoxColumn2.Width = 220
    'Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebAsistencia"
    DataGridViewTextBoxColumn0.HeaderText = "Asistencia"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebDialibre"
    DataGridViewTextBoxColumn0.HeaderText = "Día libre"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebFeriado"
    DataGridViewTextBoxColumn0.HeaderText = "Feriado"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebPermiso"
    DataGridViewTextBoxColumn0.HeaderText = "Permiso"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebVacacion"
    DataGridViewTextBoxColumn0.HeaderText = "Vacación"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebEnfermedad"
    DataGridViewTextBoxColumn0.HeaderText = "Enfermedad"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "WebLactancia"
    DataGridViewTextBoxColumn0.HeaderText = "Lactancia"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Permis_FechaDesde"
    'DataGridViewTextBoxColumn1.HeaderText = "Desde"
    'DataGridViewTextBoxColumn1.Width = 120
    'Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Permis_FechaHasta"
    'DataGridViewTextBoxColumn1.HeaderText = "Hasta"
    'DataGridViewTextBoxColumn1.Width = 120
    'Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Private Sub llenar_datos(Optional ByVal _actualizarsueldos As Boolean = False, Optional ByVal _actualizarhoras As Boolean = False)
    Me.Enabled = False
    'Me.Panel1.Visible = False
    If mPatrono Is Nothing Then
      Exit Sub
    End If
    okcalcular = False
    If (mContrato Is Nothing And mPatrono Is Nothing) Or mPeriodo Is Nothing Then
      tbVistaasistencia.Visible = False
      Exit Sub
    End If

    Me.Enabled = True
    If mContrato IsNot Nothing Then
      _Avisos = PermisoList.ObtenerLista(mOp, mContrato, mPeriodo.PerPag_FechaDesde, mPeriodo.PerPag_FechaHasta)

      Me.PermisoListBindingSource.DataSource = _Avisos
    Else
      Me.PermisoListBindingSource.DataSource = Nothing
    End If

    Me.CtlFotoPersona1.Imagen = mEmpleado.Entidadnatural.Entidad.Entida_Imagen
    Me.pnllabor.Visible = Not mContrato Is Nothing
    If Not mContrato Is Nothing Then
      'Me.CtlLabor1.Labor = mContrato.Labor
    End If

    tbVistaasistencia.Visible = True
    If mAsistencia Is Nothing Then
      If Not mContrato Is Nothing Then
        mAsistencia = New Asistencia(Me.mOp, mContrato, mPeriodo)
      Else
        mAsistencia = New Asistencia(mOp, mEmpleado, mPatrono, mPeriodo)
        mAsistencia.Tipocontrato = mTipoContrato
      End If
      mAsistencia.Periodopago = mPeriodo
    End If
    Me.lbl_descrip.Visible = True
    Me.pnlguardar.Visible = True
    Me.tbVistaasistencia.Visible = True
    Me.DataGridView2.Enabled = Not mPeriodo.PerPag_esPagado

    If mPeriodo.PerPag_esPagado Then
      If mAsistencia.EsNuevo Then
        Me.lbl_descrip.Text = "Periodo cerrado. No existe un registro de asistencias para " & Me.mContrato.Empleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesde.ToShortDateString
        Me.pnlguardar.Visible = False
        Me.tbVistaasistencia.Visible = False
        Exit Sub
      End If
    End If
    Me.Asistencia.Dias = Nothing
    'For t As Integer = 1 To 16
    '  Me.diasasistencias(t).Visible = False
    '  Me.diasasistencias(t).Tag = "No"
    'Next

    'Me.chkdescontarprest.Checked = mAsistencia.Asiste_DescontarPrestamo
    'Me.chkdescontarprestquirog.Checked = mAsistencia.Asiste_DescontarPrestQuirog
    'Me.chkdescontarseguro.Checked = mAsistencia.Asiste_DescontarSeguro
    'Me.chkpagarenliq.Checked = mAsistencia.Asiste_esParteLiq
    'If mAsistencia.EsNuevo Then
    '  Me.chkdescontarir.Checked = mAsistencia.Contrato.Contra_DescontarImpuestoRenta
    'Else
    '  Me.chkdescontarir.Checked = mAsistencia.Asiste_DescontarImpuestoRenta
    'End If

    'Me.txtmultas.Text = mAsistencia.Asiste_Multa

    If mAsistencia.EsNuevo Or _actualizarsueldos Then
      Me.lbl_descrip.Text = "No existe un registro de asistencias para " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesde.ToShortDateString
      'If mTipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
      'Me.CtlZafra1.Zafra = mTipoContrato.Zafra
      'Me.mAsistencia.Asiste_SueldoBase = mTipoContrato.TipCon_valorhora * 8 * 30
      'Me.mAsistencia.Asiste_ValHExhora50 = mTipoContrato.TipCon_valorSLV
      'Me.mAsistencia.Asiste_ValHExhora100 = mTipoContrato.TipCon_valorSSDF
      'Me.mAsistencia.Asiste_AdicionalMensual = 0
      'Me.mAsistencia.Asiste_TransporteMensual = 0
      'Me.mAsistencia.Asiste_TurnosRotativos = mTipoContrato.TipCon_TurnosRotativos
      'Else
      'Me.CtlZafra1.Zafra = mContrato.Labor.Seccion.Zafra
      '  If mTipoContrato.TipCon_valorhora = 0 Then
      '    Me.mAsistencia.Asiste_SueldoBase = IIf(mTipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, mContrato.Contra_ValorHora * 8 * 30, mContrato.Contra_Sueldo)
      '  Else
      '    Me.mAsistencia.Asiste_SueldoBase = mTipoContrato.TipCon_valorhora * 8 * 30
      '  End If

      '  If mTipoContrato.TipCon_valorSLV = 0 Then
      '    Me.mAsistencia.Asiste_ValHExhora50 = mContrato.Contra_ValorHexLV
      '  Else
      '    Me.mAsistencia.Asiste_ValHExhora50 = mTipoContrato.TipCon_valorSLV
      '  End If

      '  If mTipoContrato.TipCon_valorSSDF = 0 Then
      '    Me.mAsistencia.Asiste_ValHExhora100 = mContrato.Contra_ValorHexSDF
      '  Else
      '    Me.mAsistencia.Asiste_ValHExhora100 = mTipoContrato.TipCon_valorSSDF
      '  End If

      '  Me.mAsistencia.Asiste_AdicionalMensual = mContrato.Contra_Antiguedad
      '  Me.mAsistencia.Asiste_TransporteMensual = mContrato.Contra_Transporte
      '  Me.mAsistencia.Asiste_TurnosRotativos = mContrato.Tipocontrato.TipCon_TurnosRotativos
      'End If
      'Me.chkdescontarprest.Checked = mAsistencia.Asiste_DescontarPrestamo
      'Me.chkdescontarprestquirog.Checked = mAsistencia.Asiste_DescontarPrestQuirog
      'Me.chkdescontarseguro.Checked = mAsistencia.Asiste_DescontarSeguro
      'Me.chkpagarenliq.Checked = mAsistencia.Asiste_esParteLiq


      'Dim conf As ConfigRoles
      'conf = New ConfigRoles(Me.Op, mPatrono.Pais, False)
      'Me.mAsistencia.Asiste_PorcentajeIESS = conf.Cnfrol_porciesspersonal
      'Me.mAsistencia.Asiste_PorcSubMatEnf = conf.Cnfrol_porcpagsubmatenf
      'Me.mAsistencia.Asiste_ICSMensual = conf.Cnfrol_compsal

      For Each _dia As DiaAsistencia In Asistencia.Dias
        _dia.Asistencia = Me.Asistencia
      Next
    Else
      Me.lbl_descrip.Text = "Empleado " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesde.ToShortDateString
      'Me.CtlZafra1.Zafra = Me.mAsistencia.Zafra
    End If

    Dim feriados As New FeriadoList
    feriados = FeriadoList.ObtenerLista(Me.mOp, mPatrono.Pais, mPeriodo.PerPag_FechaDesde, mPeriodo.PerPag_FechaHasta)

    Dim permisos As New PermisoList
    permisos = PermisoList.ObtenerLista(mOp, mPatrono, mEmpleado, mPeriodo.PerPag_FechaDesde, mPeriodo.PerPag_FechaHasta)

    Dim _dias As DiaAsistenciaList = mAsistencia.Dias(mAsistencia.EsNuevo)
    Dim _diasactivos As New DiaAsistenciaList
    For t As Integer = 1 To mPeriodo.IntervaloDias
      Dim diaasis As DiaAsistencia
      diaasis = _dias(t - 1)
      Dim fecha As Date
      fecha = mPeriodo.PerPag_FechaDesde.AddDays(t - 1)
      Dim diasem As System.DayOfWeek = fecha.DayOfWeek

      If (mAsistencia.EsNuevo And Not mAsistencia.Contrato Is Nothing) AndAlso (diaasis.DiaAsi_Fecha.CompareTo(mAsistencia.Contrato.Contra_Desde) < 0) Then
        diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra
        diaasis.DiaAsi_Asistencia = False
        diaasis.DiaAsi_Jornadaaux = 0
        diaasis.DiaAsi_Sobret25aux = 0
        diaasis.DiaAsi_Sobret50aux = 0
        diaasis.DiaAsi_Sobret100aux = 0
        diaasis.DiaAsi_Sobret100baux = 0
      ElseIf _actualizarhoras OrElse (chkverdias(diasem + IIf(t > 7, 7, 0)).Checked And diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra) Then

        Dim _diaweb As DiaAsistenciaWeb
        _diaweb = New DiaAsistenciaWeb(mEmpleado.OperadorDatos, mEmpleado, mPatrono, fecha)
        If Not _diaweb.EsNuevo Then
          diaasis.DiaAsi_Jornadaaux = _diaweb.DiAsWe_H0
          diaasis.DiaAsi_Sobret25aux = _diaweb.DiAsWe_H25
          diaasis.DiaAsi_Sobret50aux = _diaweb.DiAsWe_H50
          diaasis.DiaAsi_Sobret100aux = _diaweb.DiAsWe_H100
          diaasis.DiaAsi_Sobret100baux = _diaweb.DiAsWe_HLibre
          diaasis.DiaAsi_Asistencia = _diaweb.Asistencia
          diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Normal
          If _diaweb.Dialibre Then
            diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.DiaLibre
          End If
          If _diaweb.Feriado Then
            diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Feriado
          End If
          If _diaweb.Permiso Then
            diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Permiso
          End If
          If _diaweb.Vacacion Then
            diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Vacaciones
          End If
          If _diaweb.Enfermedad Then
            diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Enfermedad_Maternidad
          End If
        Else
          'Dim _lab As Labor
          Dim _cargo As Cargo
          'If mTipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
          '_lab = mTipoContrato.Labor
          'Else
          '_lab = mContrato.Labor
          _cargo = mContrato.Cargo
          'End If
          'diaasis.Labor = _lab
          diaasis.Cargo = _cargo

          Dim dml As DetalleModeloLabor = New DetalleModeloLabor(Me.mOp, diasem, _cargo.PardetModeloLabor) '_lab.PardetModeloLabor)
          If dml.EsNuevo Then
            MsgBox("Hubo un error al tratar de recuperar la Modelo de Labor " & dml.PardetModeloLabor.Pardet_Descripcion & " de la labor " & _cargo.Cargo_Descripcion) '_lab.Labor_Descripcion)
          Else
            diaasis.Tarea = dml.Tarea
            diaasis.DiaAsi_Asistencia = dml.DeMoLa_Asistencia
            diaasis.Pardet_EstadoDiaEnum = dml.Pardet_EstadoDiaEnum
            diaasis.DiaAsi_Jornadaaux = dml.DeMoLa_Tarea
            diaasis.DiaAsi_Sobret25aux = dml.DeMoLa_Sobre25
            diaasis.DiaAsi_Sobret50aux = dml.DeMoLa_Sobre50
            diaasis.DiaAsi_Sobret100aux = dml.DeMoLa_Sobre100
            diaasis.DiaAsi_Sobret100baux = 0 'dml.DeMoLa_Sobre100b
            diaasis.DiaAsi_integrales = 0
          End If
        End If

        If Not feriados Is Nothing Then
          For Each _fer As Feriado In feriados
            If _fer.Feriad_Fecha = fecha Then
              diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Feriado
            End If
            If Not mContrato Is Nothing Then
              If _fer.Feriad_Fecha < mContrato.Contra_Desde Then
                diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra
              End If
              If _fer.Feriad_Fecha > mContrato.Contra_Hasta Then
                diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra
              End If
            End If
          Next
        End If
        If Not permisos Is Nothing Then
          For Each _per As Permiso In permisos
            If fecha >= _per.Permis_FechaDesde And fecha <= _per.Permis_FechaHasta Then
              Select Case _per.Pardet_TipoPermisoEnum
                Case Enumerados.enumTipoPermiso.Enfermedad
                  diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Enfermedad_Maternidad
                Case Enumerados.enumTipoPermiso.Maternidad
                  diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Enfermedad_Maternidad
                Case Enumerados.enumTipoPermiso.Vacaciones
                  diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Vacaciones
                Case Enumerados.enumTipoPermiso.Permiso
                  diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Permiso
              End Select

            End If
          Next
        End If
      End If

      If chkverdias(diasem + IIf(t > 7, 7, 0)).Checked Then
        _diasactivos.Add(diaasis)
      End If
      'diasasistencias(t).DiaAsistencia = diaasis
      'diasasistencias(t).Visible = chkverdias(diasem + IIf(t > 7, 7, 0)).Checked
      'diasasistencias(t).Enabled = Not mPeriodo.PerPag_esPagado
      'diasasistencias(t).Tag = "Si"
    Next
    Me.BSAsistencia.DataSource = _diasactivos

    okcalcular = True
    If mAsistencia.EsNuevo Then
      Calcular(True, mAsistencia.EsNuevo)
    End If
    mostrarcalculo()
    'Me.Panel1.Visible = True
  End Sub

  Private Sub Btnrecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecalcular.Click
    'Generar()
    If mAsistencia Is Nothing Then
      Exit Sub
    End If

    llenar_datos(True, True)
    'If mTipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
    '  'Me.CtlZafra1.Zafra = mTipoContrato.Zafra
    '  Me.mAsistencia.Asiste_SueldoBase = mTipoContrato.TipCon_valorhora * 8 * 30
    '  Me.mAsistencia.Asiste_ValHExhora50 = mTipoContrato.TipCon_valorSLV
    '  Me.mAsistencia.Asiste_ValHExhora100 = mTipoContrato.TipCon_valorSSDF
    '  Me.mAsistencia.Asiste_AdicionalMensual = 0
    '  Me.mAsistencia.Asiste_TransporteMensual = 0
    '  Me.mAsistencia.Asiste_TurnosRotativos = mTipoContrato.TipCon_TurnosRotativos
    'Else
    '  'Me.CtlZafra1.Zafra = mContrato.Labor.Seccion.Zafra
    '  Me.mAsistencia.Asiste_SueldoBase = IIf(mTipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, mContrato.Contra_ValorHora * 8 * 30, mContrato.Contra_Sueldo)
    '  Me.mAsistencia.Asiste_ValHExhora50 = mContrato.Contra_ValorHexLV
    '  Me.mAsistencia.Asiste_ValHExhora100 = mContrato.Contra_ValorHexSDF
    '  Me.mAsistencia.Asiste_AdicionalMensual = mContrato.Contra_Antiguedad
    '  Me.mAsistencia.Asiste_TransporteMensual = mContrato.Contra_Transporte
    '  Me.mAsistencia.Asiste_TurnosRotativos = mContrato.Tipocontrato.TipCon_TurnosRotativos
    'End If

    'Dim conf As ConfigRoles
    'conf = New ConfigRoles(Me.Op, mPatrono.Pais, False)
    'Me.mAsistencia.Asiste_PorcentajeIESS = conf.Cnfrol_porciesspersonal
    'Me.mAsistencia.Asiste_PorcSubMatEnf = conf.Cnfrol_porcpagsubmatenf
    'Me.mAsistencia.Asiste_ICSMensual = conf.Cnfrol_compsal

    'Dim t As Integer = 0
    'Dim _diasactivos As New DiaAsistenciaList
    'For Each _dia As DiaAsistencia In mAsistencia.Dias(True)
    '  _dia.Asistencia = mAsistencia
    '  t += 1
    '  If chkverdias(_dia.DiaAsi_Fecha.DayOfWeek + IIf(t > 7, 7, 0)).Checked Then
    '    _diasactivos.Add(_dia)
    '  End If
    'Next
    'Me.BSAsistencia.DataSource = _diasactivos

    Calcular(True, True)
    Me.tbVistaasistencia.SelectedIndex = 1
  End Sub

  Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    Guardar()
  End Sub

  Private Sub Calcular(ByVal _solocalculo As Boolean, Optional ByVal _recalcularhoras As Boolean = False)
    If Not okcalcular Then
      Exit Sub
    End If
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    mAsistencia.Calcular(_solocalculo, _recalcularhoras)
    mostrarcalculo()
  End Sub

  Sub mostrarcalculo()
    'MsgBox("a")
    Me.txtdiastrab.Text = mAsistencia.Asiste_Dias.ToString("0.00")
    Me.txtdiasint.Text = mAsistencia.Asiste_DiasIntegrales.ToString("0.00")
    'Me.cbodiasvac.SelectedValue = mAsistencia.Asiste_DiasVac
    Me.cbodiasfaltas.SelectedValue = CInt(mAsistencia.Asiste_Faltas)
    Me.txtdiasinac.Value = mAsistencia.Asiste_DiasInactivos
    Me.txthoras0.Text = mAsistencia.Asiste_H0.ToString("0.00")
    Me.txthoras25.Text = mAsistencia.Asiste_H25.ToString("0.00")
    Me.txthoras50.Text = mAsistencia.Asiste_H50.ToString("0.00")
    Me.txthoras100.Text = mAsistencia.Asiste_H100.ToString("0.00")
    Me.txthoras100b.Text = mAsistencia.Asiste_H100b.ToString("0.00")
    'Me.txtsueldo.Text = (mAsistencia.Asiste_S0 - mAsistencia.Asiste_SubMatEnf).ToString("0.00")
    'Me.txtsobret25.Text = mAsistencia.Asiste_S25.ToString("0.00")
    'Me.txtsobret50.Text = mAsistencia.Asiste_S50.ToString("0.00")
    'Me.txtsobret100.Text = mAsistencia.Asiste_S100.ToString("0.00")
    'Me.txtsobret100b.Text = mAsistencia.Asiste_S100b.ToString("0.00")
    'Me.txtcompsal.Text = mAsistencia.Asiste_ICS.ToString("0.00")
    'Me.txtadicional.Text = mAsistencia.Asiste_AdicionalP.ToString("0.00")
    'Me.txtotrosingresos.Value = mAsistencia.Asiste_OtrosIngresos
    'Me.txtotrosingresosnoap.Value = mAsistencia.Asiste_OtrosIngresosnoAp
    'Me.txttransporte.Text = mAsistencia.Asiste_TranspP.ToString("0.00")
    'Me.txtd3.Text = mAsistencia.Asiste_D3Pag.ToString("0.00")
    'Me.txtd4.Text = mAsistencia.Asiste_D4Pag.ToString("0.00")
    'Me.txtvac.Text = mAsistencia.Asiste_VacPag.ToString("0.00")
    'Me.txttotalingresos.Text = mAsistencia.Total_ingresos.ToString("0.00")
    'Me.txtiess.Text = mAsistencia.Asiste_IESS.ToString("0.00")
    'Me.txtprestamos.Text = mAsistencia.Asiste_Prestamo.ToString("0.00")
    'Me.txtprestamoquirog.Text = mAsistencia.Asiste_PrestamoQuirog.ToString("0.00")
    'Me.txtmultas.Value = mAsistencia.Asiste_Multa
    'Me.txtimpuestorenta.Text = mAsistencia.Asiste_ImpuestoRenta.ToString("0.00")
    'Me.txtfaltantes.Text = mAsistencia.Asiste_Faltantes.ToString("0.00")
    'Me.txtdesctofaltas.Text = mAsistencia.Asiste_DesctoFaltas.ToString("0.00")
    'Me.txtanticipo.Text = mAsistencia.Asiste_Anticipos.ToString("0.00")
    'Me.txtseguro.Text = mAsistencia.Asiste_SeguroCorporativo.ToString("0.00")
    'Me.txttotalegresos.Text = mAsistencia.Total_egresos.ToString("0.00")
    'Me.txttotalperiodo.Text = mAsistencia.Total_periodo.ToString("0.00")
    'Me.lblerror.Visible = mAsistencia.Total_periodo <= 0
  End Sub

  'Private Sub CtlDiaAsistencia_CambioDatos()
  '  Calcular(True, mAsistencia.EsNuevo)
  'End Sub

  Private Sub txtmultas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmultas.Validated, txtotrosingresos.Validated, txtotrosingresosnoap.Validated, cbodiasvac.SelectedIndexChanged, cbodiasfaltas.SelectedIndexChanged, txtdiasinac.Validated
    If Not mAsistencia Is Nothing Then
      '¡mAsistencia.Asiste_transp = CType(Me.txttransporte.Text, Double)
      'mAsistencia.Asiste_DiasVac = Me.cbodiasvac.SelectedValue
      mAsistencia.Asiste_Faltas = Me.cbodiasfaltas.SelectedValue
      mAsistencia.Asiste_DiasInactivos = Me.txtdiasinac.Value
      'mAsistencia.Asiste_Multa = Me.txtmultas.Value
      'mAsistencia.Asiste_OtrosIngresos = Me.txtotrosingresos.Value
      'mAsistencia.Asiste_OtrosIngresosnoAp = Me.txtotrosingresosnoap.Value
      'mAsistencia.Asiste_SueldoPagar = mAsistencia.Total_periodo
      Calcular(True, False)
    End If
  End Sub

  Public Sub Generar()
    ''  Me.CtlZafra1.Zafra = mContrato.Labor.Seccion.Zafra
    ''Me.mAsistencia.Asiste_sueldobase = IIf(mContrato.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, mContrato.Contra_valorhora * 8 * 30, mContrato.Contra_sueldo)
    ''Me.mAsistencia.Asiste_AdicionalMensual = mContrato.Contra_antiguedad
    ''  Me.mAsistencia.Asiste_TransporteMensual = mContrato.Contra_transporte
    ''  Me.mAsistencia.TipoContrato = mContrato.TipoContrato
    'Dim conf As ConfigRoles
    'conf = New ConfigRoles(Me.Op, mPatrono.Pais, False)
    'Me.mAsistencia.Asiste_PorcentajeIESS = conf.Cnfrol_porciesspersonal
    'Me.mAsistencia.Asiste_PorcSubMatEnf = conf.Cnfrol_porcpagsubmatenf
    'Me.mAsistencia.Asiste_ICSMensual = conf.Cnfrol_compsal

    ''Me.CtlZafra1.Zafra = mContrato.Labor.Seccion.Zafra
    'Me.mAsistencia.Asiste_SueldoBase = IIf(mContrato.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, mContrato.Contra_ValorHora * 8 * 30, mContrato.Contra_Sueldo)
    'Me.mAsistencia.Asiste_ValHExhora50 = mContrato.Contra_ValorHexLV
    'Me.mAsistencia.Asiste_ValHExhora100 = mContrato.Contra_ValorHexSDF
    'Me.mAsistencia.Asiste_AdicionalMensual = mContrato.Contra_Antiguedad
    'Me.mAsistencia.Asiste_TransporteMensual = mContrato.Contra_Transporte
    'Me.mAsistencia.Tipocontrato = mContrato.Tipocontrato
    'Calcular(False, False)
    Btnrecalcular_Click(Me, Nothing)
    '    llenar_datos(True, True)
    Guardar()
  End Sub

  Public Sub Guardar()
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    mAsistencia.Contrato.Contra_DescontarImpuestoRenta = Me.chkdescontarir.Checked
    mAsistencia.Contrato.Guardar()

    Me.tbVistaasistencia.SelectedTab = TabPage1
    Calcular(False, False)
    If Me.mAsistencia.Guardar Then
      For Each _diaasis As DiaAsistencia In Me.BSAsistencia.DataSource
        Try
          If (Not _diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra) Then
            _diaasis.Guardar()
          Else
            _diaasis.Eliminar()
          End If
        Catch ex As Exception

        End Try
      Next

      'creando sueldos mensuales
      If Not (TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo) Then
        Dim sueldos As SueldoMensualList
        sueldos = SueldoMensualList.RetornarSueldoMensualesRecalculados(Me.mOp, mEmpleado, patrono, TipoContrato, Periodo.PerPag_FechaDesde.Year, Periodo.PerPag_FechaDesde.Month)
        If Not sueldos Is Nothing AndAlso sueldos.Count > 0 Then
          For Each _sueldo As SueldoMensual In sueldos
            _sueldo.Guardar()
          Next
        End If

        If Periodo.PerPag_FechaDesde.Year <> Periodo.PerPag_FechaHasta.Year Or Periodo.PerPag_FechaDesde.Month <> Periodo.PerPag_FechaHasta.Month Then
          sueldos = SueldoMensualList.RetornarSueldoMensualesRecalculados(Me.mOp, mEmpleado, patrono, TipoContrato, Periodo.PerPag_FechaHasta.Year, Periodo.PerPag_FechaHasta.Month)

          If Not sueldos Is Nothing AndAlso sueldos.Count > 0 Then
            For Each _sueldo As SueldoMensual In sueldos
              _sueldo.Guardar()
            Next
          End If
        End If
      End If

      'Me.lbl_descrip.Text = "Empleado " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesde.ToShortDateString
      llenar_datos()
    Else
      MsgBox(mAsistencia.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Desea eliminar el registro de asistencia?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
      mAsistencia.Eliminar()
      Asistencia = Nothing
    End If
  End Sub

  Private Sub chkdescontarprest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdescontarprest.CheckedChanged
    If Not mAsistencia Is Nothing Then
      'mAsistencia.Asiste_DescontarPrestamo = chkdescontarprest.Checked
    End If
  End Sub

  Private Sub chkdescontarprestquirog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdescontarprestquirog.CheckedChanged, chkdescontarir.CheckedChanged
    If Not mAsistencia Is Nothing Then
      'mAsistencia.Asiste_DescontarPrestQuirog = chkdescontarprestquirog.Checked
    End If
  End Sub

  Private Sub chkdescontarseguro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkdescontarseguro.CheckedChanged
    If Not mAsistencia Is Nothing Then
      'mAsistencia.Asiste_DescontarSeguro = chkdescontarseguro.Checked
    End If
  End Sub

  Private Sub chkpagarenliq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpagarenliq.CheckedChanged
    If Not mAsistencia Is Nothing Then
      'mAsistencia.Asiste_esParteLiq = chkpagarenliq.Checked
    End If
  End Sub

  'Private Sub btncambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar.Click
  '  If CtlLabor1.Visible And Not mContrato Is Nothing Then
  '    'mContrato.Labor = CtlLabor1.Labor
  '    mContrato.Guardar()
  '  End If
  'End Sub

  Private Sub chklunes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklunes.CheckedChanged, chkmartes.CheckedChanged, chkmiercoles.CheckedChanged, chkjueves.CheckedChanged, chkviernes.CheckedChanged, chksabado.CheckedChanged, chkdomingo.CheckedChanged
    If Me.chklunes.Checked Or Me.chkmartes.Checked Or Me.chkmiercoles.Checked Or Me.chkjueves.Checked Or Me.chkviernes.Checked Then
      Me.chksabado.Checked = True
      Me.chkdomingo.Checked = True
    End If
    llenar_datos()
  End Sub

  Private Sub chklunes2_Checked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklunes2.CheckedChanged, chkmartes2.CheckedChanged, chkmiercoles2.CheckedChanged, chkjueves2.CheckedChanged, chkviernes2.CheckedChanged, chksabado2.CheckedChanged, chkdomingo2.CheckedChanged
    If Me.chklunes2.Checked Or Me.chkmartes2.Checked Or Me.chkmiercoles2.Checked Or Me.chkjueves2.Checked Or Me.chkviernes2.Checked Then
      Me.chksabado2.Checked = True
      Me.chkdomingo2.Checked = True
    End If
    llenar_datos()
  End Sub

  Private Sub _Avisos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles _Avisos.AddingNew
    If mContrato IsNot Nothing Then
      Dim _aviso As New Permiso(mOp, mContrato)
      e.NewObject = _aviso
    End If
  End Sub

  Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow

  End Sub

  Private Sub DataGridView1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DataGridView1.Validating
    If PermisoListBindingSource.Current Is Nothing Then
      Exit Sub
    Else
      Dim _aviso As Permiso = CType(PermisoListBindingSource.Current, Permiso)
      e.Cancel = Not _aviso.Guardar()
    End If
  End Sub

  Private Sub btnnuevopermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevopermiso.Click
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmPermiso(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal, Enumerados.EnumOpciones.ListadoEmpleados)
    f.Permiso = New Permiso(Op, Me.Contrato)
    f.Direccion = IMantenimiento.Accion.Ingreso
    If f.ShowDialog() = DialogResult.OK Then
      PermisoListBindingSource.Add(f.Permiso)
    End If
  End Sub

  Private Sub btnabrirpermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirpermiso.Click
    If PermisoListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmPermiso(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal, Enumerados.EnumOpciones.ListadoEmpleados)
    f.Permiso = PermisoListBindingSource.Current
    f.Direccion = IMantenimiento.Accion.Modificacion
    If f.ShowDialog() = DialogResult.OK Then
      Me.DataGridView1.Refresh()
    End If
  End Sub

  Private Sub btneliminarpermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarpermiso.Click
    If PermisoListBindingSource.Current Is Nothing Then
      Exit Sub
    Else
      Dim _aviso As Permiso = CType(PermisoListBindingSource.Current, Permiso)
      If _aviso.Eliminar() Then
        PermisoListBindingSource.RemoveCurrent()
      End If
    End If
  End Sub

  Private Sub DataGridView2_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting

    'End Sub

    'Private Sub DataGridView2_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView2.RowPrePaint
    If Me.BSAsistencia.DataSource Is Nothing Then
      Exit Sub
    End If
    Dim semana As Integer = CType(Me.BSAsistencia.DataSource, DiaAsistenciaList)(e.RowIndex).Semana
    For Each _cell As DataGridViewCell In Me.DataGridView2.Rows(e.RowIndex).Cells
      Select Case semana
        Case 1
          _cell.Style.BackColor = Color.LightBlue
        Case 2
          _cell.Style.BackColor = Color.LightCoral
        Case 3
          _cell.Style.BackColor = Color.LightCyan
        Case 4
          _cell.Style.BackColor = Color.LightGray
        Case 5
          _cell.Style.BackColor = Color.LightGreen
      End Select
    Next

  End Sub

  Private Sub DataGridView2_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowValidated
    Calcular(True, False)
  End Sub

  Private Sub txtmultas_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmultas.TextChanged

  End Sub

  Private Sub txtotrosingresos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtotrosingresos.TextChanged, txtotrosingresosnoap.TextChanged

  End Sub

  Public Sub New()

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    Inicializar()
  End Sub

  Sub Inicializar()

  End Sub

  Private Sub btnexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcel.Click
    EnviarExcel()
  End Sub

  Private Sub EnviarExcel()
    Try
      Dim data As IList = CType(Me.DataGridView2.DataSource.DataSource, IList)

      If data Is Nothing OrElse data.Count = 0 Then
        Throw New Exception("No existen registros a exportar")
        Exit Sub
      End If

      Dim dets As Type
      dets = data.Item(0).GetType

      Dim excelApp As New Excel.Application
      excelApp.Visible = False
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet
        For t As Integer = 1 To Me.DataGridView2.ColumnCount
          .Cells(1, t).Value = Me.DataGridView2.Columns(t - 1).HeaderText
          .Columns(t).columnwidth = IIf(Me.DataGridView2.Columns(t - 1).Width / 6.8 > 255, 255, Me.DataGridView2.Columns(t - 1).Width / 6.8)

          Dim _pro As System.Reflection.PropertyInfo
          _pro = dets.GetProperty(Me.DataGridView2.Columns(t - 1).DataPropertyName)

          If _pro IsNot Nothing Then
            If (_pro.PropertyType Is GetType(Decimal) Or _pro.PropertyType Is GetType(Double)) Then
              .Columns(t).numberformat = "0" & Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator & "00"
            ElseIf (_pro.PropertyType Is GetType(Integer) Or _pro.PropertyType Is GetType(Byte)) Then
              .Columns(t).numberformat = "0"
            Else
              'If Not _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(String) Or _pro.PropertyType Is GetType(Boolean)) Then
              .Columns(t).numberformat = "@"
            End If
          End If
        Next

        For _row As Integer = 1 To data.Count
          'Dim vals As Object
          'vals = typeDs.GetProperty("Item").GetValue(Me.DataGridView2.DataSource.DataSource, New Object() {_row - 1})

          For t As Integer = 1 To Me.DataGridView2.ColumnCount
            'Dim _pro As System.Reflection.PropertyInfo
            '_pro = vals.GetType.GetProperty(Me.DataGridView2.Columns(t - 1).DataPropertyName)
            Dim valor As Object
            valor = GetField(data.Item(_row - 1), Me.DataGridView2.Columns(t - 1).DataPropertyName)
            If TypeOf valor Is Boolean Then
              .Cells(_row + 1, t).Value = IIf(CBool(valor), "Sí", "No")
            Else
              Dim _pro As System.Reflection.PropertyInfo
              _pro = dets.GetProperty(Me.DataGridView2.Columns(t - 1).DataPropertyName)

              If _pro IsNot Nothing Then
                '.Cells(_row + 1, t).Value = valor
                If (_pro.PropertyType Is GetType(Decimal) Or _pro.PropertyType Is GetType(Double)) Then
                  .Cells(_row + 1, t).value = Val(valor).ToString("0.00")
                ElseIf (_pro.PropertyType Is GetType(Integer) Or _pro.PropertyType Is GetType(Byte)) Then
                  .Cells(_row + 1, t).value = Val(valor).ToString("0")
                Else 'data.Columns(t - 1).DataType Is GetType(String) Or data.Columns(t - 1).DataType Is GetType(Boolean) Then
                  .Cells(_row + 1, t).Value = valor
                End If
              End If
            End If
          Next
        Next
      End With
      excelApp.Visible = True
      'excelWorksheet.PrintPreview()
      'excelApp.Quit()
    Catch ex As Exception
      MsgBox("No se puede exporta a Microsoft Excel. " & ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
    End Try
  End Sub

#Region " GetField "

  Public Function GetField(ByVal obj As Object, ByVal FieldName As String) As Object
    Try
      Dim sourcetype As Type = obj.GetType
      Dim prop As PropertyInfo = sourcetype.GetProperty(FieldName)
      If prop Is Nothing OrElse Not prop.CanRead Then
        ' no readable property of that name exists - check for a field
        Dim field As FieldInfo = sourcetype.GetField(FieldName)

        If field Is Nothing Then
          Return "No such value " & FieldName
        Else
          Return field.GetValue(obj)
        End If
      Else
        ' found a property, return its value
        Return prop.GetValue(obj, Nothing)
      End If
    Catch ex As Exception
      Return ex.Message
    End Try
  End Function

#End Region
End Class
