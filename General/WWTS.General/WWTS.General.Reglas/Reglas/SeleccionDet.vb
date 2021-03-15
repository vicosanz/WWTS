
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "SeleccionDet"
Public Class SeleccionDet
  Inherits _Database

  Const _Procedimiento As String = "proc_SeleccionDet"

  Private mEmpleado As Empleado = Nothing

  Private mSeleccion As Seleccion = Nothing

  Private mPardetResultadoSeleccion As WWTSParametroDet = Nothing

  Private mPardetDepartamentoCargo As WWTSParametroDet = Nothing

  Private mPardetAreaCargo As WWTSParametroDet = Nothing

  Private mArea As Area = Nothing

  Private mCargo As Cargo = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Selecc_Codigo As Integer, ByVal _Entida_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Selecc_Codigo = _Entida_Codigo
    Entida_Codigo = _Entida_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Selección Detalle")
    End If
  End Sub

  'Empleado
  Public Overridable Property Empleado() As Empleado
    Get
      If Me.mEmpleado Is Nothing AndAlso Entida_Codigo > 0 Then
        Me.mEmpleado = New Empleado(OperadorDatos, Entida_Codigo)
      End If
      Return Me.mEmpleado
    End Get
    Set(ByVal value As Empleado)
      Me.mEmpleado = value
      Entida_Codigo = value.Entida_Codigo
    End Set
  End Property

  'Seleccion
  Public Overridable Property Seleccion() As Seleccion
    Get
      If Me.mSeleccion Is Nothing AndAlso Selecc_Codigo > 0 Then
        Me.mSeleccion = New Seleccion(OperadorDatos, Selecc_Codigo)
      End If
      Return Me.mSeleccion
    End Get
    Set(ByVal value As Seleccion)
      Me.mSeleccion = value
      Selecc_Codigo = value.Selecc_Codigo
    End Set
  End Property

  'PardetResultadoSeleccion
  Public Overridable Property PardetResultadoSeleccion() As WWTSParametroDet
    Get
      If Me.mPardetResultadoSeleccion Is Nothing AndAlso Pardet_ResultadoSeleccion > 0 Then
        Me.mPardetResultadoSeleccion = New WWTSParametroDet(OperadorDatos, Parame_ResultadoSeleccion, Me.Pardet_ResultadoSeleccion)
      End If
      Return Me.mPardetResultadoSeleccion
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetResultadoSeleccion = value
      If value Is Nothing Then
        Parame_ResultadoSeleccion = 0
        Pardet_ResultadoSeleccion = 0
      Else
        Parame_ResultadoSeleccion = value.Parame_Codigo
        Pardet_ResultadoSeleccion = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetDepartamentoCargo
  Public Overridable Property PardetDepartamentoCargo() As WWTSParametroDet
    Get
      If Me.mPardetDepartamentoCargo Is Nothing AndAlso Pardet_DepartamentoCargo > 0 Then
        Me.mPardetDepartamentoCargo = New WWTSParametroDet(OperadorDatos, Parame_DepartamentoCargo, Pardet_DepartamentoCargo)
      End If
      Return Me.mPardetDepartamentoCargo
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetDepartamentoCargo = value
      If value Is Nothing Then
        Parame_DepartamentoCargo = 0
        Pardet_DepartamentoCargo = 0
      Else
        Parame_DepartamentoCargo = value.Parame_Codigo
        Pardet_DepartamentoCargo = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public Overridable Property Area As Area
    Get
      If mArea Is Nothing AndAlso Pardet_AreaCargo > 0 Then
        mArea = New Area(OperadorDatos, Parame_DepartamentoCargo, Pardet_DepartamentoCargo, Parame_AreaCargo, Pardet_AreaCargo)
      End If
      Return mArea
    End Get
    Set(ByVal value As Area)
      mArea = value
      Parame_DepartamentoCargo = value.Parame_Departamento
      Pardet_DepartamentoCargo = value.Pardet_Departamento
      Parame_AreaCargo = value.Parame_Area
      Pardet_AreaCargo = value.Pardet_Area
    End Set
  End Property

  'Cargo
  Public Overridable Property Cargo() As Cargo
    Get
      If Me.mCargo Is Nothing AndAlso Cargo_Secuencia > 0 Then
        Me.mCargo = New Cargo(OperadorDatos, Parame_DepartamentoCargo, Pardet_DepartamentoCargo, Parame_AreaCargo, Pardet_AreaCargo, Cargo_Secuencia)
      End If
      Return Me.mCargo
    End Get
    Set(ByVal value As Cargo)
      Me.mCargo = value
      If value Is Nothing Then
        Parame_DepartamentoCargo = 0
        Pardet_DepartamentoCargo = 0
        Parame_AreaCargo = 0
        Pardet_AreaCargo = 0
        Cargo_Secuencia = 0
      Else
        Parame_DepartamentoCargo = mCargo.Parame_Departamento
        Pardet_DepartamentoCargo = mCargo.Pardet_Departamento
        Parame_AreaCargo = mCargo.Parame_Area
        Pardet_AreaCargo = mCargo.Pardet_Area
        Cargo_Secuencia = mCargo.Cargo_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Persona", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property EmpleadoString() As String
    Get
      Return Me.Empleado.NombreCompleto
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Área", CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property AreaString() As String
    Get
      Return Me.Seleccion.PardetAreaString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha", CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public ReadOnly Property Fecha() As Date
    Get
      Return Me.SelDet_FechaHora
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Observaciones", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property Observaciones() As String
    Get
      Return Me.SelDet_Observaciones
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Resultado", CampoReporteAtributo.EnumTipoDato.Texto, 75, True)> _
  Public ReadOnly Property PardetResultadoSeleccionString() As String
    Get
      If PardetResultadoSeleccion Is Nothing Then
        Return String.Empty
      Else
        Return Me.PardetResultadoSeleccion.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Aprobado RRHH", CampoReporteAtributo.EnumTipoDato.Logico, 55, True)> _
  Public ReadOnly Property AprobadoRRHH() As Boolean
    Get
      Return Me.SelDet_esAprobadoRRHH
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Aprobado Dpto", CampoReporteAtributo.EnumTipoDato.Logico, 55, True)> _
  Public ReadOnly Property AprobadoDpto() As Boolean
    Get
      Return Me.SelDet_esAprobadoDpto
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Ganador", CampoReporteAtributo.EnumTipoDato.Logico, 50, True)> _
  Public ReadOnly Property GanadorConcurso() As Boolean
    Get
      Return Me.EsGanador()
    End Get
  End Property

#Region "Test"
  Private mtestlist As SeleccionTestList = Nothing

  Public ReadOnly Property testlist As SeleccionTestList
    Get
      If mtestlist Is Nothing Then
        mtestlist = SeleccionTestList.ObtenerListaxArea(Me, Me.Seleccion.PardetArea)
      End If
      Return mtestlist
    End Get
  End Property

  Private mtestlisteliminadas As SeleccionTestList = Nothing

  Public ReadOnly Property testlisteliminadas As SeleccionTestList
    Get
      If mtestlisteliminadas Is Nothing Then
        mtestlisteliminadas = New SeleccionTestList
      End If
      Return mtestlisteliminadas
    End Get
  End Property
#End Region

  Function EsGanador() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "G")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaEsGanador(Result.Rows(0))
    Catch ex As System.Exception
      bReturn = False
    End Try
    If mEsGanador = 1 Then
      Return True
    Else
      Return False
    End If
    Return bReturn
  End Function

  Private mEsGanador As Integer
  Public Overridable Sub MapearDataRowaEsGanador(ByVal Fila As DataRow)
    mEsGanador = CType(Fila("EsGanador"), Integer)
  End Sub

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Selecc_Codigo = CType(Fila("Selecc_Codigo"), Integer)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    SelDet_FechaHora = CType(Fila("SelDet_FechaHora"), Date)
    SelDet_Observaciones = CType(Fila("SelDet_Observaciones"), String)
    Parame_ResultadoSeleccion = CType(Fila("Parame_ResultadoSeleccion"), Integer)
    Pardet_ResultadoSeleccion = CType(Fila("Pardet_ResultadoSeleccion"), Integer)
    SelDet_esAprobadoRRHH = CType(Fila("SelDet_esAprobadoRRHH"), Boolean)
    SelDet_esAprobadoDpto = CType(Fila("SelDet_esAprobadoDpto"), Boolean)
    Try
      Parame_DepartamentoCargo = CType(Fila("Parame_DepartamentoCargo"), Integer)
      Pardet_DepartamentoCargo = CType(Fila("Pardet_DepartamentoCargo"), Integer)
      Parame_AreaCargo = CType(Fila("Parame_AreaCargo"), Integer)
      Pardet_AreaCargo = CType(Fila("Pardet_AreaCargo"), Integer)
      Cargo_Secuencia = CType(Fila("Cargo_Secuencia"), Integer)
      Cargo_EmpleadoActual = CType(Fila("Cargo_EmpleadoActual"), String)
    Catch ex As Exception
      Parame_DepartamentoCargo = 0
      Pardet_DepartamentoCargo = 0
      Parame_AreaCargo = 0
      Pardet_AreaCargo = 0
      Cargo_Secuencia = 0
      Cargo_EmpleadoActual = ""
    End Try

    mPardetResultadoSeleccion = Nothing
    mEmpleado = Nothing
    mSeleccion = Nothing
    mCargo = Nothing
    mPardetDepartamentoCargo = Nothing
    mPardetAreaCargo = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If

    OperadorDatos.ComenzarTransaccion()

    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@SelDet_FechaHora", SelDet_FechaHora)
    OperadorDatos.AgregarParametro("@SelDet_Observaciones", SelDet_Observaciones)
    OperadorDatos.AgregarParametro("@Parame_ResultadoSeleccion", Parame_ResultadoSeleccion)
    OperadorDatos.AgregarParametro("@Pardet_ResultadoSeleccion", Pardet_ResultadoSeleccion)
    OperadorDatos.AgregarParametro("@SelDet_esAprobadoRRHH", SelDet_esAprobadoRRHH)
    OperadorDatos.AgregarParametro("@SelDet_esAprobadoDpto", SelDet_esAprobadoDpto)
    OperadorDatos.AgregarParametro("@Parame_DepartamentoCargo", Parame_DepartamentoCargo)
    OperadorDatos.AgregarParametro("@Pardet_DepartamentoCargo", Pardet_DepartamentoCargo)
    OperadorDatos.AgregarParametro("@Parame_AreaCargo", Parame_AreaCargo)
    OperadorDatos.AgregarParametro("@Pardet_AreaCargo", Pardet_AreaCargo)
    OperadorDatos.AgregarParametro("@Cargo_Secuencia", Cargo_Secuencia)
    OperadorDatos.AgregarParametro("@Cargo_EmpleadoActual", Cargo_EmpleadoActual)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    
    If bReturn Then
      For Each _test As SeleccionTest In testlist
        If Me.EsNuevo Then
          _test.EsNuevo = True
        End If
        _test.Entida_Codigo = Entida_Codigo
        If Not _test.Guardar Then
          bReturn = False
          Exit For
        End If
      Next

      For Each _test As SeleccionTest In testlisteliminadas
        _test.Entida_Codigo = Entida_Codigo
        If Not _test.Eliminar Then
          bReturn = False
          Exit For
        End If
      Next
    End If

    If bReturn Then
      EsNuevo = False
      EsModificado = False
    End If

    If bReturn Then
      OperadorDatos.TerminarTransaccion()
      AceptarCambios()
    Else
      OperadorDatos.CancelarTransaccion()
    End If

    Return bReturn
  End Function

  Public Overridable Function AceptarCambios() As Boolean
    EsNuevo = False
    EsModificado = False

    For Each _test As SeleccionTest In testlist
      _test.AceptarCambios()
    Next

    mtestlisteliminadas = Nothing
  End Function

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "SeleccionDetList"
Public Class SeleccionDetList
  Inherits System.ComponentModel.BindingList(Of SeleccionDet)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _Empleado As Empleado, Optional ByVal _filtro As String = "") As SeleccionDetList
    Dim oResult As SeleccionDetList = New SeleccionDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Entida_Codigo", _Empleado.Entida_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_SeleccionDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New SeleccionDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaFiltrada(ByVal _OperadorDatos As OperadorDatos, ByVal _Seleccion As Seleccion, Optional ByVal _filtro As String = "") As SeleccionDetList
    Dim oResult As SeleccionDetList = New SeleccionDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FA")
      .AgregarParametro("@Selecc_Codigo", _Seleccion.Selecc_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_SeleccionDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New SeleccionDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region