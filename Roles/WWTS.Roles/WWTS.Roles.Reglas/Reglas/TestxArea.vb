Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "TestxArea"
Public Class TestxArea
  Inherits _Database

  Const _Procedimiento As String = "proc_TestxArea"

  Private mPardetArea As WWTSParametroDet = Nothing

  Private mPardetSeleccionTest As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

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

  'PardetTestSeleccion
  Public Overridable Property PardetSeleccionTest() As WWTSParametroDet
    Get
      If Me.mPardetSeleccionTest Is Nothing AndAlso Pardet_SeleccionTest > 0 Then
        Me.mPardetSeleccionTest = New WWTSParametroDet(OperadorDatos, Parame_SeleccionTest, Pardet_SeleccionTest)
      End If
      Return Me.mPardetSeleccionTest
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetSeleccionTest = value
      If value Is Nothing Then
        Parame_SeleccionTest = 0
        Pardet_SeleccionTest = 0
      Else
        Parame_SeleccionTest = value.Parame_Codigo
        Pardet_SeleccionTest = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Área", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
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

  <Infoware.Reportes.CampoReporteAtributo("Test", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetTestSeleccionString() As String
    Get
      Try
        If PardetSeleccionTest Is Nothing Then
          Return String.Empty
        Else
          Return Me.PardetSeleccionTest.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_Area = CType(Fila("Parame_Area"), Integer)
    Pardet_Area = CType(Fila("Pardet_Area"), Integer)
    Parame_SeleccionTest = CType(Fila("Parame_SeleccionTest"), Integer)
    Pardet_SeleccionTest = CType(Fila("Pardet_SeleccionTest"), Integer)

    mPardetArea = Nothing
    mPardetSeleccionTest = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Parame_SeleccionTest", Parame_SeleccionTest)
    OperadorDatos.AgregarParametro("@Pardet_SeleccionTest", Pardet_SeleccionTest)
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
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Parame_SeleccionTest", Parame_SeleccionTest)
    OperadorDatos.AgregarParametro("@Pardet_SeleccionTest", Pardet_SeleccionTest)
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
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Parame_SeleccionTest", Parame_SeleccionTest)
    OperadorDatos.AgregarParametro("@Pardet_SeleccionTest", Pardet_SeleccionTest)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "TestxAreaList"
Public Class TestxAreaList
  Inherits System.ComponentModel.BindingList(Of TestxArea)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _PardetArea As WWTSParametroDet, Optional ByVal _filtro As String = "") As TestxAreaList
    Dim oResult As TestxAreaList = New TestxAreaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Parame_Area", _PardetArea.Parame_Codigo)
      .AgregarParametro("@Pardet_Area", _PardetArea.Pardet_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_TestxArea"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New TestxArea(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region