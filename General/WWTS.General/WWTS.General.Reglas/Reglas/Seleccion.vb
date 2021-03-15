
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "Seleccion"
Partial Public Class Seleccion
  Inherits _Database

  Const _Procedimiento As String = "proc_Seleccion"

  Private mPardetDepartamento As WWTSParametroDet = Nothing

  Private mPardetArea As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Selecc_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Selecc_Codigo = _Selecc_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Selección")
    End If
  End Sub

  'PardetDepartamento
  Public Overridable Property PardetDepartamento() As WWTSParametroDet
    Get
      If Me.mPardetDepartamento Is Nothing AndAlso Pardet_Departamento > 0 Then
        Me.mPardetDepartamento = New WWTSParametroDet(OperadorDatos, Parame_Departamento, Pardet_Departamento)
      End If
      Return Me.mPardetDepartamento
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetDepartamento = value
      If value Is Nothing Then
        Parame_Departamento = 0
        Pardet_Departamento = 0
      Else
        Parame_Departamento = value.Parame_Codigo
        Pardet_Departamento = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetArea
  Public Overridable Property PardetArea() As WWTSParametroDet
    Get
      If Me.mPardetArea Is Nothing AndAlso Pardet_Area > 0 Then
        Me.mPardetArea = New WWTSParametroDet(OperadorDatos, Parame_Area, Me.Pardet_Area)
      End If
      Return Me.mPardetArea
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetArea = value
      If value Is Nothing Then
        Parame_Area = 0
        Parame_Area = 0
      Else
        Parame_Area = value.Parame_Codigo
        Pardet_Area = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Sección", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property PardetSeccionString() As String
    Get
      Try
        If PardetDepartamento Is Nothing Then
          Return String.Empty
        Else
          Return Me.PardetDepartamento.PardetPadre.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Departamento", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property DepartamentoString As String
    Get
      Try
        If PardetDepartamento Is Nothing Then
          Return String.Empty
        Else
          Return PardetDepartamento.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Área", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property PardetAreaString() As String
    Get
      Try
        If PardetArea Is Nothing Then
          Return String.Empty
        Else
          Return Me.PardetArea.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha", CampoReporteAtributo.EnumTipoDato.Fecha, 150, True)> _
  Public ReadOnly Property FechaString() As String
    Get
      Return Me.Selecc_Fecha
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Estado", CampoReporteAtributo.EnumTipoDato.Fecha, 150, True)> _
  Public ReadOnly Property EstadoString() As String
    Get
      If Selecc_Estado Then
        Return "Abierto"
      Else
        Return "Cerrado"
      End If
    End Get
  End Property

  Public Function ObtenerFecha() As Date
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Date = Now.Date

    With Me.OperadorDatos
      .AgregarParametro("@accion", "OF")
      .Procedimiento = "proc_Seleccion"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDate(dsResult.Rows(0)("Fecha")).Date
    End If
    Return oResult
  End Function

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Selecc_Codigo = CType(Fila("Selecc_Codigo"), Integer)
    Selecc_Fecha = CType(Fila("Selecc_Fecha"), Date)
    Parame_Departamento = CType(Fila("Parame_Departamento"), Integer)
    Pardet_Departamento = CType(Fila("Pardet_Departamento"), Integer)
    Parame_Area = CType(Fila("Parame_Area"), Integer)
    Pardet_Area = CType(Fila("Pardet_Area"), Integer)
    Selecc_Estado = CType(Fila("Selecc_Estado"), Boolean)
    
    mPardetDepartamento = Nothing
    mPardetArea = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
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
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Selecc_Fecha", Selecc_Fecha)
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Selecc_Estado", Selecc_Estado)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      EsNuevo = False
      EsModificado = False
    End If
    Return bReturn
  End Function

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "SeleccionList"
Public Class SeleccionList
  Inherits System.ComponentModel.BindingList(Of Seleccion)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _abierto As Boolean, ByVal _cerrado As Boolean, Optional ByVal _filtro As String = "") As SeleccionList
    Dim oResult As SeleccionList = New SeleccionList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      If _abierto Then
        .AgregarParametro("@abierto", _abierto)
      End If
      If Not _cerrado Then
        .AgregarParametro("@cerrado", _cerrado)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Seleccion"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Seleccion(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaxArea(ByVal _OperadorDatos As OperadorDatos, ByVal _Area As Area, Optional ByVal _filtro As String = "") As SeleccionList
    Dim oResult As SeleccionList = New SeleccionList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FA")
      .AgregarParametro("@Parame_Area", _Area.Parame_Area)
      .AgregarParametro("@Pardet_Area", _Area.Pardet_Area)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Seleccion"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Seleccion(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
