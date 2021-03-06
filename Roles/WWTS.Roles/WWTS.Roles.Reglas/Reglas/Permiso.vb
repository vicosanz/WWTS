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


#Region "Permiso"
Public Class Permiso

    Const _Procedimiento As String = "proc_Permiso"

  Private mContrato As Contrato = Nothing

  Private mPardetTipoPermiso As WWTSParametroDet = Nothing
    
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
        MyBase.New
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato)
    Me.New(_OperadorDatos, True)
    Me.Contrato = _Contrato
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer, ByVal _Patron_Codigo As Integer, ByVal _Contra_Secuencia As Integer, ByVal _Permis_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Entida_Codigo = _Entida_Codigo
    Patron_Codigo = _Patron_Codigo
    Contra_Secuencia = _Contra_Secuencia
    Permis_Secuencia = _Permis_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Permiso")
    End If
  End Sub

  'Contrato
  Public Overridable Property Contrato() As Contrato
    Get
      If Me.mContrato Is Nothing AndAlso Patron_Codigo > 0 Then
        Me.mContrato = New Contrato(OperadorDatos, Entida_Codigo, Patron_Codigo, Contra_Secuencia)
      End If
      Return Me.mContrato
    End Get
    Set(ByVal value As Contrato)
      Me.mContrato = Value
      Entida_Codigo = Value.Entida_Codigo
      Patron_Codigo = Value.Patron_Codigo
      Contra_Secuencia = Value.Contra_Secuencia
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetTipoPermiso() As WWTSParametroDet
    Get
      If mPardetTipoPermiso Is Nothing AndAlso Pardet_TipoPermiso <> 0 Then
        mPardetTipoPermiso = New WWTSParametroDet(OperadorDatos, Parame_TipoPermiso, Pardet_TipoPermiso)
      End If
      Return Me.mPardetTipoPermiso
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoPermiso = value
      Parame_TipoPermiso = value.Parame_Codigo
      Pardet_TipoPermiso = value.Pardet_Secuencia
    End Set
  End Property

  Public ReadOnly Property PardetTipoPermisoString() As String
    Get
      If PardetTipoPermiso Is Nothing Then
        Return String.Empty
      Else
        Return PardetTipoPermiso.Pardet_Descripcion
      End If
    End Get
  End Property

  Public Overridable Property Pardet_TipoPermisoEnum() As Enumerados.enumTipoPermiso
    Get
      Return CType(Pardet_TipoPermiso, Enumerados.enumTipoPermiso)
    End Get
    Set(ByVal value As Enumerados.enumTipoPermiso)
      Pardet_TipoPermiso = CInt(value)
    End Set
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Contra_Secuencia = CType(Fila("Contra_Secuencia"), Integer)
    Permis_Secuencia = CType(Fila("Permis_Secuencia"), Integer)
    Parame_TipoPermiso = CType(Fila("Parame_TipoPermiso"), Integer)
    Pardet_TipoPermiso = CType(Fila("Pardet_TipoPermiso"), Integer)
    Permis_FechaDesde = CType(Fila("Permis_FechaDesde"), Date)
    Permis_FechaHasta = CType(Fila("Permis_FechaHasta"), Date)
    mContrato = Nothing
    mPardetTipoPermiso = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Permis_Secuencia", Permis_Secuencia)
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
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Permis_Secuencia", Permis_Secuencia)
    OperadorDatos.AgregarParametro("@Parame_TipoPermiso", Parame_TipoPermiso)
    OperadorDatos.AgregarParametro("@Pardet_TipoPermiso", Pardet_TipoPermiso)
    OperadorDatos.AgregarParametro("@Permis_FechaDesde", Permis_FechaDesde)
    OperadorDatos.AgregarParametro("@Permis_FechaHasta", Permis_FechaHasta)
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
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Permis_Secuencia", Permis_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "PermisoList"
Public Class PermisoList
    Inherits System.ComponentModel.BindingList(Of Permiso)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _contrato As Contrato, ByVal _desde As Date, ByVal _hasta As Date) As PermisoList
    Dim oResult As New PermisoList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable
    With _OperadorDatos
      .AgregarParametro("@accion", "f")
      .AgregarParametro("@Entida_Codigo", _contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _contrato.Patron_Codigo)
      '.AgregarParametro("@Empres_Codigo", _contrato.Empres_Codigo)
      .AgregarParametro("@Contra_Secuencia", _contrato.Contra_Secuencia)
      .AgregarParametro("@desde", _desde.Date)
      .AgregarParametro("@hasta", _hasta.Date)

      .Procedimiento = "proc_Permiso"
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New Permiso(_OperadorDatos, False)
        _obj.MapearDataRowaObjeto(_dr)
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _patrono As Patrono, ByVal _empleado As Empleado, ByVal _desde As DateTime, ByVal _hasta As DateTime) As PermisoList
    Dim oResult As New PermisoList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable
    With _OperadorDatos
      .AgregarParametro("@accion", "FF")
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@Entida_Codigo", _empleado.Entida_Codigo)
      .AgregarParametro("@desde", _desde)
      .AgregarParametro("@hasta", _hasta)
      .Procedimiento = "proc_Permiso"
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New Permiso(_OperadorDatos, False)
        _obj.MapearDataRowaObjeto(_dr)
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function

    Public Sub New()
    End Sub
End Class
#End Region
