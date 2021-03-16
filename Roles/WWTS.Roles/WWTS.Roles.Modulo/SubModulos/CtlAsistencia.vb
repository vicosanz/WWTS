Imports Microsoft.Office.Interop
Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports System.Reflection
Imports WWTS.General.Modulo

Public Class CtlAsistencia
  Public ReadOnly Property Sistema As Sistema
    Get
      Dim _control As Control = Me.Parent
      While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
        _control = _control.Parent
      End While
      If _control Is Nothing Then
        Return Nothing
      End If
      Return CType(_control, FrmFormaBase).Sistema
    End Get
  End Property

  Public Property Desde As Date
    Get
      Return Me.dtfecdesde.Value
    End Get
    Set(value As Date)
      Me.dtfecdesde.Value = value
    End Set
  End Property

  Public Property Hasta As Date
    Get
      Return Me.dtfechasta.Value
    End Get
    Set(value As Date)
      Me.dtfechasta.Value = value
    End Set
  End Property

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value

      If value IsNot Nothing Then
        ColumnasAsistencia()

        Dim _diasvac As New ElementoList
        _diasvac.Add(New Elemento(0, "0", ""))
        _diasvac.Add(New Elemento(15, "15", ""))

        Dim _diasfal As New ElementoList
        _diasfal.Add(New Elemento(0, "0", ""))
        _diasfal.Add(New Elemento(2, "2", ""))

        'cbodiasfaltas.DataSource = _diasfal
        'cbodiasfaltas.DisplayMember = "Descripcion"
        'cbodiasfaltas.ValueMember = "Numero"

        Me.cboSubCentroCosto.OperadorDatos = mOp
        Me.cboSubCentroCosto.Parametro = Enumerados.EnumParametros.SubCentroCosto
        Me.cboSubCentroCosto.Llenar_Datos()
      End If
    End Set
  End Property

  Private mContrato As Contrato = Nothing
  Private mPeriodo As PeriodoPago = Nothing
  Private mEmpleado As Empleado = Nothing
  Private mPatrono As Patrono = Nothing
  Private mTipoContrato As TipoContrato = Nothing
  Private mAsistencia As Asistencia = Nothing
  Dim okcalcular As Boolean = False

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

      If Value IsNot Nothing Then
        dtfecdesde.MinDate = DateTimePicker.MinimumDateTime
        dtfechasta.MinDate = DateTimePicker.MinimumDateTime
        dtfecdesde.MaxDate = DateTimePicker.MaximumDateTime
        dtfechasta.MaxDate = DateTimePicker.MaximumDateTime

        If dtfecdesde.Value.Date < mPeriodo.PerPag_FechaDesdeMarcacion OrElse dtfecdesde.Value.Date > mPeriodo.PerPag_FechaHastaMarcacion Then
          dtfecdesde.Value = mPeriodo.PerPag_FechaDesdeMarcacion
        End If
        If dtfechasta.Value.Date < mPeriodo.PerPag_FechaDesdeMarcacion OrElse dtfechasta.Value.Date > mPeriodo.PerPag_FechaHastaMarcacion Then
          dtfechasta.Value = mPeriodo.PerPag_FechaHastaMarcacion
        End If
        If dtfechasta.Value.Date < dtfecdesde.Value.Date Then
          dtfechasta.Value = dtfecdesde.Value.Date
        End If

        dtfecdesde.MinDate = mPeriodo.PerPag_FechaDesdeMarcacion
        dtfechasta.MinDate = mPeriodo.PerPag_FechaDesdeMarcacion
        dtfecdesde.MaxDate = mPeriodo.PerPag_FechaHastaMarcacion
        dtfechasta.MaxDate = mPeriodo.PerPag_FechaHastaMarcacion

      End If

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

        dtfecdesde.MinDate = DateTimePicker.MinimumDateTime
        dtfechasta.MinDate = DateTimePicker.MinimumDateTime
        dtfecdesde.MaxDate = DateTimePicker.MaximumDateTime
        dtfechasta.MaxDate = DateTimePicker.MaximumDateTime

        If dtfecdesde.Value.Date < mPeriodo.PerPag_FechaDesdeMarcacion OrElse dtfecdesde.Value.Date > mPeriodo.PerPag_FechaHastaMarcacion Then
          dtfecdesde.Value = mPeriodo.PerPag_FechaDesdeMarcacion
        End If
        If dtfechasta.Value.Date < mPeriodo.PerPag_FechaDesdeMarcacion OrElse dtfechasta.Value.Date > mPeriodo.PerPag_FechaHastaMarcacion Then
          dtfechasta.Value = mPeriodo.PerPag_FechaHastaMarcacion
        End If
        If dtfechasta.Value.Date < dtfecdesde.Value.Date Then
          dtfechasta.Value = dtfecdesde.Value.Date
        End If

        dtfecdesde.MinDate = mPeriodo.PerPag_FechaDesdeMarcacion
        dtfechasta.MinDate = mPeriodo.PerPag_FechaDesdeMarcacion
        dtfecdesde.MaxDate = mPeriodo.PerPag_FechaHastaMarcacion
        dtfechasta.MaxDate = mPeriodo.PerPag_FechaHastaMarcacion

      End If
      llenar_datos()
    End Set
  End Property
#End Region

  Private Sub ColumnasAsistencia()
    Dim BSEstadoDia As New BindingSource
    BSEstadoDia.DataSource = ParametroDetList.ObtenerLista(mOp, Enumerados.EnumParametros.EstadoDiaLabor)

    'Dim BSTarea As New BindingSource
    'BSTarea.DataSource = TareaList.ObtenerLista(mOp)

    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "noesNuevo"
    DataGridViewTextBoxColumn0.HeaderText = "Grabado"
    DataGridViewTextBoxColumn0.ReadOnly = True
    DataGridViewTextBoxColumn0.Width = 48
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "FechaString"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 110
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "WebHorainicio"
    DataGridViewTextBoxColumn1.HeaderText = "Entrada"
    DataGridViewTextBoxColumn1.Width = 70
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "WebHoraFin"
    DataGridViewTextBoxColumn1.HeaderText = "Salida"
    DataGridViewTextBoxColumn1.Width = 70
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "DiaAsi_Asistencia"
    DataGridViewTextBoxColumn0.HeaderText = "Asistió"
    DataGridViewTextBoxColumn0.Width = 50
    DataGridViewTextBoxColumn0.ReadOnly = True
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Pardet_EstadoDia"
    DataGridViewTextBoxColumn2.DataSource = BSEstadoDia
    DataGridViewTextBoxColumn2.DisplayMember = "Pardet_Descripcion"
    DataGridViewTextBoxColumn2.ValueMember = "Pardet_Secuencia"
    DataGridViewTextBoxColumn2.HeaderText = "Estado"
    DataGridViewTextBoxColumn2.Width = 90
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

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
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Jornadaaux"
    DataGridViewTextBoxColumn1.HeaderText = "Horas normales"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret25aux"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 25"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret50aux"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 50"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret100aux"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 100 Sup"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiaAsi_Sobret100baux"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 100 Ext"
    DataGridViewTextBoxColumn1.Width = 48
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebAsistencia"
    'DataGridViewTextBoxColumn0.HeaderText = "Asistencia"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebDialibre"
    'DataGridViewTextBoxColumn0.HeaderText = "Día libre"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebFeriado"
    'DataGridViewTextBoxColumn0.HeaderText = "Feriado"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebPermiso"
    'DataGridViewTextBoxColumn0.HeaderText = "Permiso"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebVacacion"
    'DataGridViewTextBoxColumn0.HeaderText = "Vacación"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebEnfermedad"
    'DataGridViewTextBoxColumn0.HeaderText = "Enfermedad"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebLactancia"
    'DataGridViewTextBoxColumn0.HeaderText = "Lactancia"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "WebEmbarazo"
    'DataGridViewTextBoxColumn0.HeaderText = "Embarazo"
    'DataGridViewTextBoxColumn0.ReadOnly = True
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Area"
    DataGridViewTextBoxColumn1.HeaderText = "Area"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Lote"
    DataGridViewTextBoxColumn1.HeaderText = "Lote"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Private Sub llenar_datos(Optional ByVal _actualizarsueldos As Boolean = False, Optional ByVal _actualizarhoras As Boolean = False)
    Me.Enabled = False
    If mPatrono Is Nothing Then
      Exit Sub
    End If
    okcalcular = False
    If (mContrato Is Nothing And mPatrono Is Nothing) Or mPeriodo Is Nothing Then
      pnlAsistencia.Enabled = False
      Exit Sub
    End If

    Me.Enabled = True
    pnlAsistencia.Enabled = True

    Me.CtlFotoPersona1.Imagen = mEmpleado.Entidadnatural.Entidad.Entida_Imagen
    If Not Empleado.EsNuevo AndAlso Me.CtlFotoPersona1.Imagen Is Nothing Then
      Dim _codempleado As String = String.Empty
      For Each _id As EntidadIdentificacion In Me.Empleado.Entidadnatural.Entidad.Identificaciones
        If _id.Pardet_TipoidentificacionEnum = Enumerados.enumTipoIdentificacion.CodigoEmpleado Then
          _codempleado = _id.Identi_Numero.Trim
        End If
      Next
      Dim _archivofoto As String = My.Computer.FileSystem.CombinePath((New WWTSParametroDet(mEmpleado.OperadorDatos, Enumerados.EnumParametros.RutasRoles, Enumerados.enumRutas.Fotos)).Pardet_DatoStr1, _codempleado + ".jpg")
      If Not String.IsNullOrWhiteSpace(_codempleado) AndAlso My.Computer.FileSystem.FileExists(_archivofoto) Then
        Me.CtlFotoPersona1.ArchivoImagen = _archivofoto
      End If
    End If

    If mAsistencia Is Nothing Then
      If Not mContrato Is Nothing Then
        mAsistencia = New Asistencia(Me.mOp, mContrato, mPeriodo)
      Else
        mAsistencia = New Asistencia(mOp, mEmpleado, mPatrono, mPeriodo)
        mAsistencia.Tipocontrato = mTipoContrato
      End If
      mAsistencia.Periodopago = mPeriodo
    End If
    Me.cboSubCentroCosto.ParametroDet = mAsistencia.PardetSubCentroCosto
    Me.lbl_descrip.Visible = True
    Me.DataGridView1.Enabled = Not mPeriodo.PerPag_esPagado

    pnlguardar.Enabled = True
    If mPeriodo.PerPag_esPagado Then
      If mAsistencia.EsNuevo Then
        Me.lbl_descrip.Text = "Periodo cerrado. No existe un registro de asistencias para " & Me.mContrato.Empleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesdeMarcacion.ToShortDateString
        Me.pnlguardar.Enabled = False
        Me.pnlAsistencia.Enabled = False
        Exit Sub
      End If
    End If
    Me.Asistencia.Dias = Nothing

    If mAsistencia.EsNuevo Then
      If mContrato.Tipocontrato.TipCon_TurnosRotativos Then
        Me.lbl_descrip.Text = "No existe un registro de asistencias para " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesdeMarcacion.ToShortDateString & ", controlar horas extras,  turno rotativo"
        Me.lbl_descrip.BackColor = Color.LightCoral
        Me.mAsistencia.Asiste_TurnosRotativos = mContrato.Tipocontrato.TipCon_TurnosRotativos
      Else
        Dim modeloLabordescr As String = ""
        If mContrato.Cargo IsNot Nothing Then
          modeloLabordescr = Me.mContrato.Cargo.PardetModeloLabor.Pardet_Descripcion
        End If
        Me.lbl_descrip.Text = "No existe un registro de asistencias para " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesdeMarcacion.ToShortDateString & ", no controlar horas extras, turno no rotativo" &
          IIf(Me.mContrato.Cargo Is Nothing, "", ", modelo labor: " + modeloLabordescr)
        Me.lbl_descrip.BackColor = Color.LightBlue
      End If

      For Each _dia As DiaAsistencia In Asistencia.Dias
        _dia.Asistencia = Me.Asistencia
      Next
    Else
      If mContrato.Tipocontrato.TipCon_TurnosRotativos Then
        Me.lbl_descrip.Text = "Empleado " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesdeMarcacion.ToShortDateString & ", controlar horas extras, turno rotativo"
        Me.lbl_descrip.BackColor = Color.LightSeaGreen
      Else
        Me.lbl_descrip.Text = "Empleado " & Me.mEmpleado.NombreCompleto & " en la fecha " & Me.mPeriodo.PerPag_FechaDesdeMarcacion.ToShortDateString & ", no controlar horas extras, turno no rotativo, modelo labor: " & Me.mContrato.Cargo.PardetModeloLabor.Pardet_Descripcion
        Me.lbl_descrip.BackColor = Color.LightSteelBlue
      End If
    End If

    Dim feriados As New FeriadoList
    feriados = FeriadoList.ObtenerLista(Me.mOp, mPatrono.Pais, mPeriodo.PerPag_FechaDesde, mPeriodo.PerPag_FechaHasta)

    'Dim permisos As New PermisoList
    'permisos = PermisoList.ObtenerLista(mOp, mPatrono, mEmpleado, mPeriodo.PerPag_FechaDesde, mPeriodo.PerPag_FechaHasta)
    Dim licencias As New LicenciaList
    licencias = LicenciaList.ObtenerLista(mOp, mContrato, mPeriodo.PerPag_FechaDesde, mPeriodo.PerPag_FechaHasta)

    Dim _dias As DiaAsistenciaList = mAsistencia.DiasMarcacion(mAsistencia.EsNuevo)
    Dim _diasactivos As New DiaAsistenciaList
    Dim _diasmarcacion As Integer = dtfechasta.Value.Date.Subtract(mPeriodo.PerPag_FechaDesdeMarcacion).Days + 1
    For t As Integer = 1 To _diasmarcacion
      Dim diaasis As DiaAsistencia
      diaasis = _dias(t - 1)
      Dim fecha As Date
      fecha = mPeriodo.PerPag_FechaDesdeMarcacion.AddDays(t - 1)
      Dim diasem As System.DayOfWeek = fecha.DayOfWeek

      If (mAsistencia.EsNuevo And Not mAsistencia.Contrato Is Nothing) AndAlso (diaasis.DiaAsi_Fecha.CompareTo(mAsistencia.Contrato.Contra_Desde) < 0) Then
        diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra
        diaasis.DiaAsi_Asistencia = False
        diaasis.DiaAsi_Jornadaaux = 0
        diaasis.DiaAsi_Sobret25aux = 0
        diaasis.DiaAsi_Sobret50aux = 0
        diaasis.DiaAsi_Sobret100aux = 0
        diaasis.DiaAsi_Sobret100baux = 0
      ElseIf _actualizarhoras OrElse diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra Then
        If mContrato.Tipocontrato.TipCon_TurnosRotativos Then
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
            If _diaweb.Embarazo Then
              diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Maternidad
            End If
          Else
            Dim _cargo As Cargo
            _cargo = mContrato.Cargo
            diaasis.Cargo = _cargo

            Dim dml As DetalleModeloLabor = New DetalleModeloLabor(Me.mOp, diasem, _cargo.PardetModeloLabor)
            If dml.EsNuevo Then
              MsgBox("Hubo un error al tratar de recuperar el Modelo de Labor " & dml.PardetModeloLabor.Pardet_Descripcion & " de la labor " & _cargo.Cargo_Descripcion)
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

          If Not licencias Is Nothing Then
            For Each _licencia As Licencia In licencias
              If fecha >= _licencia.Licenc_Desde And fecha <= _licencia.Licenc_Hasta Then
                Select Case _licencia.Pardet_LicenciaEnum
                  Case Enumerados.enumLicencia.Enfermedad
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Enfermedad_Maternidad
                  Case Enumerados.enumLicencia.Maternidad
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Maternidad
                  Case Enumerados.enumLicencia.Vacaciones
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Vacaciones
                  Case Enumerados.enumLicencia.SinSueldo
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.SinSueldo
                End Select

              End If
            Next
          End If
        Else
          Dim _diaweb As DiaAsistenciaWeb
          _diaweb = New DiaAsistenciaWeb(mEmpleado.OperadorDatos, mEmpleado, mPatrono, fecha)
          If Not _diaweb.EsNuevo Then
            Dim _cargo As Cargo
            _cargo = mContrato.Cargo
            diaasis.Cargo = _cargo

            Dim dml As DetalleModeloLabor = New DetalleModeloLabor(Me.mOp, diasem, _cargo.PardetModeloLabor)

            'diaasis.DiaAsi_Jornadaaux = _diaweb.DiAsWe_H0
            diaasis.DiaAsi_Jornadaaux = dml.DeMoLa_Tarea
            diaasis.DiaAsi_Sobret25aux = dml.DeMoLa_Sobre25
            diaasis.DiaAsi_Sobret50aux = dml.DeMoLa_Sobre50
            diaasis.DiaAsi_Sobret100aux = dml.DeMoLa_Sobre100
            diaasis.DiaAsi_Sobret100baux = 0 'dml.DeMoLa_Sobre100b
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
            If _diaweb.Embarazo Then
              diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Maternidad
            End If
          Else
            Dim _cargo As Cargo
            _cargo = mContrato.Cargo
            diaasis.Cargo = _cargo

            Dim dml As DetalleModeloLabor = New DetalleModeloLabor(Me.mOp, diasem, _cargo.PardetModeloLabor)
            If dml.EsNuevo Then
              MsgBox("Hubo un error al tratar de recuperar el Modelo de Labor " & dml.PardetModeloLabor.Pardet_Descripcion & " de la labor " & _cargo.Cargo_Descripcion)
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
          If Not licencias Is Nothing Then
            For Each _licencia As Licencia In licencias
              If fecha >= _licencia.Licenc_Desde And fecha <= _licencia.Licenc_Hasta Then
                Select Case _licencia.Pardet_LicenciaEnum
                  Case Enumerados.enumLicencia.Enfermedad
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Enfermedad_Maternidad
                  Case Enumerados.enumLicencia.Maternidad
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Maternidad
                  Case Enumerados.enumLicencia.Vacaciones
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.Vacaciones
                  Case Enumerados.enumLicencia.SinSueldo
                    diaasis.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.SinSueldo
                End Select

              End If
            Next
          End If

        End If
      End If

      _diasactivos.Add(diaasis)

    Next
    Me.BSAsistencia.DataSource = _diasactivos

    For t As Integer = 1 To Me.BSAsistencia.Count
      Dim _dia As DiaAsistencia = BSAsistencia(t - 1)
      Me.DataGridView1.Rows(t - 1).ReadOnly = Not (_dia.DiaAsi_Fecha >= dtfecdesde.Value.Date AndAlso _dia.DiaAsi_Fecha <= dtfechasta.Value.Date)
      _dia.PuedeModificar = (_dia.DiaAsi_Fecha >= dtfecdesde.Value.Date AndAlso _dia.DiaAsi_Fecha <= dtfechasta.Value.Date)
      If _dia.EsNuevo AndAlso Not _dia.PuedeModificar Then
        _dia.Pardet_EstadoDiaEnum = Enumerados.enumEstadoModeloLabor.NoRegistra
        _dia.DiaAsi_Jornadaaux = 0
      End If
    Next

    okcalcular = True
    If mAsistencia.EsNuevo Then
      Calcular(True, mAsistencia.EsNuevo)
    End If
    mostrarcalculo()
  End Sub

  Private Sub btnrecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefrescar.Click
    If mAsistencia Is Nothing Then
      Exit Sub
    End If

    'llenar_datos(True, True)
    BSAsistencia.DataSource = Nothing
    'mAsistencia = Nothing
    llenar_datos(False, True)

    Calcular(True, True)
  End Sub

  Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    Guardar()
  End Sub

  Public Sub Calcular(ByVal _solocalculo As Boolean, Optional ByVal _recalcularhoras As Boolean = False)
    If Not okcalcular OrElse mAsistencia Is Nothing Then
      Exit Sub
    End If
    mAsistencia.Calcular(_solocalculo, _recalcularhoras)
    mostrarcalculo(_recalcularhoras)
  End Sub

  Sub mostrarcalculo(Optional ByVal _recalcularhoras As Boolean = False)
    Me.txtdiastrab.Text = mAsistencia.Asiste_Dias.ToString("0.00")
    Me.txtdiasintegrales.Text = mAsistencia.Asiste_DiasIntegrales.ToString("0.00")
    'Me.txtdiasint.Text = mAsistencia.Asiste_DiasIntegrales.ToString("0.00")
    'Me.cbodiasvac.SelectedValue = mAsistencia.Asiste_DiasVac
    'Me.cbodiasfaltas.SelectedValue = CInt(mAsistencia.Asiste_Faltas)
    Me.txtdiasfaltas.Text = mAsistencia.Asiste_Faltas.ToString("0.00")
    Me.txtdiasfaltasintegrales.Text = mAsistencia.Asiste_FaltasIntegrales.ToString("0.00")
    Me.txtdiasinac.Value = mAsistencia.Asiste_DiasInactivos
    Me.txthoras0.Text = mAsistencia.Asiste_H0.ToString("0.00")
    Me.txthoras25.Text = mAsistencia.Asiste_H25.ToString("0.00")
    Me.txthoras50.Text = mAsistencia.Asiste_H50.ToString("0.00")
    Me.txthoras100.Text = mAsistencia.Asiste_H100.ToString("0.00")
    Me.txthoras100b.Text = mAsistencia.Asiste_H100b.ToString("0.00")

    If mAsistencia.EsNuevo OrElse _recalcularhoras Then
      Me.BSAsistenciaDet.DataSource = mAsistencia.AsistenciaDetList()
    Else
      Me.BSAsistenciaDet.DataSource = AsistenciaDetList.ObtenerLista(mAsistencia.OperadorDatos, mAsistencia)
    End If

    Me.DataGridView2.Columns.Clear()
    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetLicenciaString"
    DataGridViewTextBoxColumn1.HeaderText = "Detalle"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 110
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "AsiDet_LicenciaDias"
    DataGridViewTextBoxColumn1.HeaderText = "Días"
    DataGridViewTextBoxColumn1.ReadOnly = False
    DataGridViewTextBoxColumn1.Width = 50
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Public Sub Generar()
    'btnrecalcular_Click(Me, Nothing)
    llenar_datos() 'False, True
    mostrarcalculo()
    Guardar()
  End Sub

  Public Sub Guardar()
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    mAsistencia.Contrato.Guardar()
    mAsistencia.PardetSubCentroCosto = Me.cboSubCentroCosto.ParametroDet

    'Calcular(False, False)
    Try
      If Not Me.mAsistencia.Guardar Then
        'MsgBox(mAsistencia.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        Throw New Exception(mAsistencia.OperadorDatos.MsgError)
      End If
      llenar_datos()
    Catch ex As Exception
      MsgBox("No se puedo guardar el registro de asistencia" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If mAsistencia Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar el registro de asistencia?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
      mAsistencia.OperadorDatos.ComenzarTransaccion()
      Try
        For Each _asidet As AsistenciaDet In Me.BSAsistenciaDet.DataSource
          If Not _asidet.Eliminar() Then
            Throw New Exception(_asidet.OperadorDatos.MsgError)
          End If
        Next
        For Each _diaasis As DiaAsistencia In Me.BSAsistencia.DataSource
          If Not _diaasis.Eliminar() Then
            Throw New Exception(_diaasis.OperadorDatos.MsgError)
          End If
        Next
        If Not mAsistencia.Eliminar() Then
          Throw New Exception(mAsistencia.OperadorDatos.MsgError)
        End If
        mAsistencia.OperadorDatos.TerminarTransaccion()
        Asistencia = Nothing
      Catch ex As Exception
        mAsistencia.OperadorDatos.CancelarTransaccion()
        MsgBox("No se puedo guardar el registro de asistencia" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End If
  End Sub

  Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    If Me.BSAsistencia.DataSource Is Nothing Then
      Exit Sub
    End If
    Dim _dia As DiaAsistencia = CType(Me.BSAsistencia.DataSource, DiaAsistenciaList)(e.RowIndex)

    Dim semana As Integer = _dia.Semana
    For Each _cell As DataGridViewCell In Me.DataGridView1.Rows(e.RowIndex).Cells
      If Not _dia.PuedeModificar Then
        _cell.Style.BackColor = Color.LightYellow
      Else
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
      End If
    Next
  End Sub

  Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
    Calcular(True, True)
    'mostrarcalculo(True)
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
      Dim data As IList = CType(Me.DataGridView1.DataSource.DataSource, IList)

      If data Is Nothing OrElse data.Count = 0 Then
        Throw New Exception("No existen registros a exportar")
        Exit Sub
      End If

      Dim dets As Type
      dets = data.Item(0).GetType

      Dim excelApp As New Excel.Application With {
        .Visible = False
      }
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet
        For t As Integer = 1 To Me.DataGridView1.ColumnCount
          .Cells(1, t).Value = Me.DataGridView1.Columns(t - 1).HeaderText
          .Columns(t).columnwidth = IIf(Me.DataGridView1.Columns(t - 1).Width / 6.8 > 255, 255, Me.DataGridView1.Columns(t - 1).Width / 6.8)

          Dim _pro As System.Reflection.PropertyInfo
          _pro = dets.GetProperty(Me.DataGridView1.Columns(t - 1).DataPropertyName)

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

          For t As Integer = 1 To Me.DataGridView1.ColumnCount
            'Dim _pro As System.Reflection.PropertyInfo
            '_pro = vals.GetType.GetProperty(Me.DataGridView2.Columns(t - 1).DataPropertyName)
            Dim valor As Object
            valor = GetField(data.Item(_row - 1), Me.DataGridView1.Columns(t - 1).DataPropertyName)
            If TypeOf valor Is Boolean Then
              .Cells(_row + 1, t).Value = IIf(CBool(valor), "Sí", "No")
            Else
              Dim _pro As System.Reflection.PropertyInfo
              _pro = dets.GetProperty(Me.DataGridView1.Columns(t - 1).DataPropertyName)

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


  Private Sub btnCambiarArea_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarArea.Click
    If Me.DataGridView1.SelectedRows.Count > 0 OrElse Me.DataGridView1.SelectedCells.Count > 0 Then
      Dim f As New FrmCambiarArea(Sistema, Enumerados.EnumOpciones.RegistrarAsistencias)
      If Me.DataGridView1.SelectedRows.Count > 0 Then
        f.Area = CType(Me.BSAsistencia.Item(Me.DataGridView1.SelectedRows(0).Index), DiaAsistencia).PardetArea
      Else
        f.Area = CType(Me.BSAsistencia.Item(Me.DataGridView1.SelectedCells(0).RowIndex), DiaAsistencia).PardetArea
      End If

      If f.ShowDialog = DialogResult.OK Then
        For Each _row As DataGridViewRow In Me.DataGridView1.SelectedRows
          CType(Me.BSAsistencia.Item(_row.Index), DiaAsistencia).PardetArea = f.Area
        Next
        For Each _cell As DataGridViewCell In Me.DataGridView1.SelectedCells
          CType(Me.BSAsistencia.Item(_cell.RowIndex), DiaAsistencia).PardetArea = f.Area
        Next
      End If
      Me.DataGridView1.Invalidate()
    End If
  End Sub

  Private Sub btnCambiarLote_Click(sender As Object, e As System.EventArgs) Handles btnCambiarLote.Click
    If Me.DataGridView1.SelectedRows.Count > 0 OrElse Me.DataGridView1.SelectedCells.Count > 0 Then
      Dim f As New FrmCambiarLote(Sistema, Enumerados.EnumOpciones.RegistrarAsistencias)
      If Me.DataGridView1.SelectedRows.Count > 0 Then
        f.Lote = CType(Me.BSAsistencia.Item(Me.DataGridView1.SelectedRows(0).Index), DiaAsistencia).PardetLote
      Else
        f.Lote = CType(Me.BSAsistencia.Item(Me.DataGridView1.SelectedCells(0).RowIndex), DiaAsistencia).PardetLote
      End If
      If f.ShowDialog = DialogResult.OK Then
        For Each _row As DataGridViewRow In Me.DataGridView1.SelectedRows
          CType(Me.BSAsistencia.Item(_row.Index), DiaAsistencia).PardetLote = f.Lote
        Next
        For Each _cell As DataGridViewCell In Me.DataGridView1.SelectedCells
          CType(Me.BSAsistencia.Item(_cell.RowIndex), DiaAsistencia).PardetLote = f.Lote
        Next
        Contrato.PardetLote = f.Lote
        Contrato.Guardar()
      End If
      Me.DataGridView1.Invalidate()
    End If
  End Sub

  Private Sub btnModeloLabor_Click(sender As System.Object, e As System.EventArgs) Handles btnModeloLabor.Click
    If mContrato Is Nothing Then
      Exit Sub
    End If
    Dim f As New WWTS.Roles.Controles.FrmModeloLabor(Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.ModeloLabor = mContrato.Cargo.PardetModeloLabor
    f.ShowDialog()
  End Sub

  Private Sub dtfecdesde_ValueChanged(sender As Object, e As System.EventArgs) Handles dtfecdesde.ValueChanged, dtfechasta.ValueChanged
    If dtfechasta.Value.Date < dtfecdesde.Value.Date Then
      dtfechasta.Value = dtfecdesde.Value.Date
    End If
    llenar_datos()
    Calcular(True, True)
  End Sub
End Class
