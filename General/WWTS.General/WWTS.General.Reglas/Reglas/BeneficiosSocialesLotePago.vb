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
Imports WWTS.General.Reglas

#Region "BeneficiosSocialesLotePago"
Public Class BeneficiosSocialesLotePago

  Const _Procedimiento As String = "proc_BeneficiosSocialesLotePago"

  Private mPardetTipoBeneficio As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Patron_Codigo As Integer, ByVal _Parame_TipoBeneficio As Integer, ByVal _Pardet_TipoBeneficio As Integer, ByVal _BenLot_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Patron_Codigo = _Patron_Codigo
    Parame_TipoBeneficio = _Parame_TipoBeneficio
    Pardet_TipoBeneficio = _Pardet_TipoBeneficio
    BenLot_Codigo = _BenLot_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto LotePago")
    End If
  End Sub

  'PardetTipoBeneficio
  Public Overridable Property PardetTipoBeneficio() As WWTSParametroDet
    Get
      If Me.mPardetTipoBeneficio Is Nothing AndAlso Pardet_TipoBeneficio > 0 Then
        Me.mPardetTipoBeneficio = New WWTSParametroDet(OperadorDatos, Parame_TipoBeneficio, Pardet_TipoBeneficio)
      End If
      Return Me.mPardetTipoBeneficio
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoBeneficio = value
      If value Is Nothing Then
        Parame_TipoBeneficio = 0
        Pardet_TipoBeneficio = 0
      Else
        Parame_TipoBeneficio = value.Parame_Codigo
        Pardet_TipoBeneficio = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Parame_TipoBeneficio = CType(Fila("Parame_TipoBeneficio"), Integer)
    Pardet_TipoBeneficio = CType(Fila("Pardet_TipoBeneficio"), Integer)
    BenLot_Codigo = CType(Fila("BenLot_Codigo"), Integer)
    BenLot_FechaGeneracion = CType(Fila("BenLot_FechaGeneracion"), Date)
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenLot_Codigo", BenLot_Codigo)
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
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenLot_Codigo", BenLot_Codigo)
    OperadorDatos.AgregarParametro("@BenLot_FechaGeneracion", BenLot_FechaGeneracion)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        BenLot_Codigo = Result
      End If
      EsNuevo = False
      EsModificado = False
    End If
    Return bReturn
  End Function

  Public Overridable Function Eliminar() As Boolean
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenLot_Codigo", BenLot_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "BeneficiosSocialesLotePagoList"
Public Class BeneficiosSocialesLotePagoList
  Inherits System.ComponentModel.BindingList(Of BeneficiosSocialesLotePago)

  Public Shared Function ObtenerLista(ByVal _Patrono As Patrono, ByVal _PardetBeneficio As WWTSParametroDet) As BeneficiosSocialesLotePagoList
    Dim oResult As New BeneficiosSocialesLotePagoList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable
    If _patrono IsNot Nothing Then
      With _Patrono.OperadorDatos
        .AgregarParametro("@accion", "f")
        .AgregarParametro("@Patron_Codigo", _Patrono.Patron_Codigo)
        .AgregarParametro("@Parame_TipoBeneficio", _PardetBeneficio.Parame_Codigo)
        .AgregarParametro("@Pardet_TipoBeneficio", _PardetBeneficio.Pardet_Secuencia)
        .Procedimiento = "proc_BeneficiosSocialesLotePago"
        bReturn = .Ejecutar(dsResult)
        .LimpiarParametros()
      End With
      If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
        For Each _dr As DataRow In dsResult.Rows
          Dim _obj As New BeneficiosSocialesLotePago(_Patrono.OperadorDatos, False)
          _obj.MapearDataRowaObjeto(_dr)
          oResult.Add(_obj)
        Next
      End If
    End If
    Return oResult
  End Function
End Class
#End Region
