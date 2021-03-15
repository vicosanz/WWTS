
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "SeleccionTest"
Public Class SeleccionTest
  Inherits _Database

  Const _Procedimiento As String = "proc_SeleccionTest"

  Private mSeleccionDet As SeleccionDet = Nothing

  Private mPardetSeleccionTest As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  'SeleccionDet
  Public Overridable Property SeleccionDet() As SeleccionDet
    Get
      If Me.mSeleccionDet Is Nothing AndAlso Selecc_Codigo > 0 Then
        Me.mSeleccionDet = New SeleccionDet(OperadorDatos, Selecc_Codigo, Entida_Codigo)
      End If
      Return Me.mSeleccionDet
    End Get
    Set(ByVal value As SeleccionDet)
      Me.mSeleccionDet = value
      Selecc_Codigo = value.Selecc_Codigo
      Entida_Codigo = value.Entida_Codigo
    End Set
  End Property

  'PardetSeleccionTest
  Public Overridable Property PardetSeleccionTest() As WWTSParametroDet
    Get
      If Me.mPardetSeleccionTest Is Nothing AndAlso Pardet_SeleccionTest > 0 Then
        Me.mPardetSeleccionTest = New WWTSParametroDet(OperadorDatos, Parame_SeleccionTest, Me.Pardet_SeleccionTest)
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

  <Infoware.Reportes.CampoReporteAtributo("Test", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetSeleccionTestString() As String
    Get
      If PardetSeleccionTest Is Nothing Then
        Return String.Empty
      Else
        Return Me.PardetSeleccionTest.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Puntaje", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property Puntaje() As Integer
    Get
      Return SelTes_Puntaje
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Selecc_Codigo = CType(Fila("Selecc_Codigo"), Integer)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Parame_SeleccionTest = CType(Fila("Parame_SeleccionTest"), Integer)
    Pardet_SeleccionTest = CType(Fila("Pardet_SeleccionTest"), Integer)
    SelTes_Puntaje = CType(Fila("SelTes_Puntaje"), Integer)

    mSeleccionDet = Nothing
    mPardetSeleccionTest = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
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
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Parame_SeleccionTest", Parame_SeleccionTest)
    OperadorDatos.AgregarParametro("@Pardet_SeleccionTest", Pardet_SeleccionTest)
    OperadorDatos.AgregarParametro("@SelTes_Puntaje", SelTes_Puntaje)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If Not OperadorDatos.EstaenTransaccion Then
        AceptarCambios()
      End If
    End If
    Return bReturn
  End Function

  Public Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Selecc_Codigo", Selecc_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Parame_SeleccionTest", Parame_SeleccionTest)
    OperadorDatos.AgregarParametro("@Pardet_SeleccionTest", Pardet_SeleccionTest)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "SeleccionTestList"
Public Class SeleccionTestList
  Inherits System.ComponentModel.BindingList(Of SeleccionTest)

  Public Shared Function ObtenerLista(ByVal _SeleccionDet As SeleccionDet, Optional ByVal _filtro As String = "") As SeleccionTestList
    Dim oResult As SeleccionTestList = New SeleccionTestList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _SeleccionDet.OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Selecc_Codigo", _SeleccionDet.Selecc_Codigo)
      .AgregarParametro("@Entida_Codigo", _SeleccionDet.Entida_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_SeleccionTest"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New SeleccionTest(_SeleccionDet.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaxArea(ByVal _SeleccionDet As SeleccionDet, ByVal _PardetArea As WWTSParametroDet, Optional ByVal _filtro As String = "") As SeleccionTestList
    Dim oResult As SeleccionTestList = New SeleccionTestList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _SeleccionDet.OperadorDatos
      .AgregarParametro("@accion", "FA")
      If _SeleccionDet IsNot Nothing Then
        .AgregarParametro("@Selecc_Codigo", _SeleccionDet.Selecc_Codigo)
        .AgregarParametro("@Entida_Codigo", _SeleccionDet.Entida_Codigo)
      End If
      .AgregarParametro("@Parame_Area", _PardetArea.Parame_Codigo)
      .AgregarParametro("@Pardet_Area", _PardetArea.Pardet_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_SeleccionTest"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New SeleccionTest(_SeleccionDet.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
