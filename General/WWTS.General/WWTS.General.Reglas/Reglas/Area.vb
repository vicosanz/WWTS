
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "Area"
Partial Public Class Area
  Inherits _Database

  Const _Procedimiento As String = "proc_area"

  Private mPardetDepartamento As WWTSParametroDet = Nothing

  Private mPardetArea As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Parame_Departamento As Integer, ByVal _Pardet_Departamento As Integer, ByVal _Parame_Area As Integer, ByVal _Pardet_Area As Integer)
    Me.New(_OperadorDatos, False)
    Parame_Departamento = _Parame_Departamento
    Pardet_Departamento = _Pardet_Departamento
    Parame_Area = _Parame_Area
    Pardet_Area = _Pardet_Area
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Área")
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
        Me.mPardetArea = New WWTSParametroDet(OperadorDatos, Parame_Area, Pardet_Area)
      End If
      Return Me.mPardetArea
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetArea = value
      If value Is Nothing Then
        Parame_Area = 0
        Pardet_Area = 0
      Else
        Parame_Area = value.Parame_Codigo
        Pardet_Area = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public ReadOnly Property Cargos As CargoList
    Get
      Return CargoList.ObtenerLista(Me)
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Sección", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property SeccionString As String
    Get
      Try
        If PardetDepartamento Is Nothing Then
          Return String.Empty
        Else
          Return PardetDepartamento.PardetPadre.Pardet_Descripcion
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
  Public ReadOnly Property AreaString As String
    Get
      Try
        If PardetArea Is Nothing Then
          Return String.Empty
        Else
          Return PardetArea.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Dotación", CampoReporteAtributo.EnumTipoDato.Numero, 150, True)> _
  Public ReadOnly Property Dotacion As Integer
    Get
      Return Area_Dotacion
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_Departamento = CType(Fila("Parame_Departamento"), Integer)
    Pardet_Departamento = CType(Fila("Pardet_Departamento"), Integer)
    Parame_Area = CType(Fila("Parame_Area"), Integer)
    Pardet_Area = CType(Fila("Pardet_Area"), Integer)
    Area_Dotacion = CType(Fila("Area_Dotacion"), Integer)
    
    mPardetDepartamento = Nothing
    mPardetArea = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
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
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Area_Dotacion", Area_Dotacion)
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
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "AreaList"
Public Class AreaList
  Inherits System.ComponentModel.BindingList(Of Area)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _PardetSeccion As WWTSParametroDet, Optional ByVal _PardetDepartamento As WWTSParametroDet = Nothing, Optional ByVal _filtro As String = "") As AreaList
    Dim oResult As AreaList = New AreaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Parame_Seccion", _PardetSeccion.Parame_Codigo)
      .AgregarParametro("@Pardet_Seccion", _PardetSeccion.Pardet_Secuencia)
      If _PardetDepartamento IsNot Nothing Then
        .AgregarParametro("@Parame_Departamento", _PardetDepartamento.Parame_Codigo)
        .AgregarParametro("@Pardet_Departamento", _PardetDepartamento.Pardet_Secuencia)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_area"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Area(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region