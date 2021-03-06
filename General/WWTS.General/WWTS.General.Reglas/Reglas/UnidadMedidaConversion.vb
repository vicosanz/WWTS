'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas

#Region "UnidadMedidaConversion"
Public Class UnidadMedidaConversion

  Const _Procedimiento As String = "proc_UnidadMedidaConversion"

  Private mPardetUnidadMedidaFte As WWTSParametroDet = Nothing

  Private mPardetUnidadMedidaDestino As WWTSParametroDet = Nothing

  Public Sub New(ByVal _PardetUnidadMedidaFte As WWTSParametroDet, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _PardetUnidadMedidaFte.OperadorDatos
    PardetUnidadMedidaFte = _PardetUnidadMedidaFte
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _PardetUnidadMedidaFte As WWTSParametroDet, ByVal _PardetUnidadMedidaDsno As WWTSParametroDet)
    Me.New(_PardetUnidadMedidaFte, False)
    PardetUnidadMedidaDsno = _PardetUnidadMedidaDsno
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto UnidadMedidaConversion")
    End If
  End Sub

  'WWTSParametroDet
  Public Overridable Property PardetUnidadMedidaFte() As WWTSParametroDet
    Get
      If Me.mPardetUnidadMedidaFte Is Nothing AndAlso Pardet_Unidadmedida > 0 Then
        Me.mPardetUnidadMedidaFte = New WWTSParametroDet(OperadorDatos, Parame_Unidadmedida, Pardet_Unidadmedida)
      End If
      Return Me.mPardetUnidadMedidaFte
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetUnidadMedidaFte = value
      Parame_Unidadmedida = value.Parame_Codigo
      Pardet_Unidadmedida = value.Pardet_Secuencia
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("De", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 130, True)> _
  Public ReadOnly Property PardetUnidadMedidaFteString() As String
    Get
      If PardetUnidadMedidaFte Is Nothing Then
        Return String.Empty
      Else
        Return PardetUnidadMedidaFte.Pardet_Descripcion
      End If
    End Get
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetUnidadMedidaDsno() As WWTSParametroDet
    Get
      If Me.mPardetUnidadMedidaDestino Is Nothing AndAlso Pardet_Unidadmedidadestino > 0 Then
        Me.mPardetUnidadMedidaDestino = New WWTSParametroDet(OperadorDatos, Parame_unidadmedidadestino, Pardet_Unidadmedidadestino)
      End If
      Return Me.mPardetUnidadMedidaDestino
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetUnidadMedidaDestino = value
      Parame_unidadmedidadestino = value.Parame_Codigo
      Pardet_Unidadmedidadestino = value.Pardet_Secuencia
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("a", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 130, True)> _
  Public ReadOnly Property PardetUnidadMedidaDsnoString() As String
    Get
      If PardetUnidadMedidaDsno Is Nothing Then
        Return String.Empty
      Else
        Return PardetUnidadMedidaDsno.Pardet_Descripcion
      End If
    End Get
  End Property

  Public ReadOnly Property Descripcion() As String
    Get
      If PardetUnidadMedidaFte Is Nothing OrElse PardetUnidadMedidaDsno Is Nothing Then
        Return String.Empty
      Else
        Return String.Format("de {0} a {1}", PardetUnidadMedidaFteString, PardetUnidadMedidaDsnoString)
      End If
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_Unidadmedida = CType(Fila("Parame_Unidadmedida"), Integer)
    Pardet_Unidadmedida = CType(Fila("Pardet_Unidadmedida"), Integer)
    Parame_unidadmedidadestino = CType(Fila("Parame_unidadmedidadestino"), Integer)
    Pardet_Unidadmedidadestino = CType(Fila("Pardet_Unidadmedidadestino"), Integer)
    Unmeco_Factor = CType(Fila("Unmeco_Factor"), Decimal)
    mPardetUnidadMedidaFte = Nothing
    mPardetUnidadMedidaDestino = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_Unidadmedida", Parame_Unidadmedida)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedida", Pardet_Unidadmedida)
    OperadorDatos.AgregarParametro("@Parame_unidadmedidadestino", Parame_unidadmedidadestino)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedidadestino", Pardet_Unidadmedidadestino)
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
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Parame_Unidadmedida", Parame_Unidadmedida)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedida", Pardet_Unidadmedida)
    OperadorDatos.AgregarParametro("@Parame_unidadmedidadestino", Parame_unidadmedidadestino)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedidadestino", Pardet_Unidadmedidadestino)
    OperadorDatos.AgregarParametro("@Unmeco_Factor", Unmeco_Factor)
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
    OperadorDatos.AgregarParametro("@Parame_Unidadmedida", Parame_Unidadmedida)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedida", Pardet_Unidadmedida)
    OperadorDatos.AgregarParametro("@Parame_unidadmedidadestino", Parame_unidadmedidadestino)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedidadestino", Pardet_Unidadmedidadestino)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "UnidadMedidaConversionList"
Public Class UnidadMedidaConversionList
  Inherits System.ComponentModel.BindingList(Of UnidadMedidaConversion)

  Public Shared Function ObtenerLista(ByVal _UnidadMedidaFte As WWTSParametroDet) As UnidadMedidaConversionList
    Dim oResult As UnidadMedidaConversionList = New UnidadMedidaConversionList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _UnidadMedidaFte.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Parame_Unidadmedida", _UnidadMedidaFte.Parame_Codigo)
      .AgregarParametro("@Pardet_Unidadmedida", _UnidadMedidaFte.Pardet_Secuencia)
      .Procedimiento = "proc_UnidadMedidaConversion"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New UnidadMedidaConversion(_UnidadMedidaFte, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
