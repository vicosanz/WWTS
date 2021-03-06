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


#Region "Prestamo"
Public Class Prestamo

  Const _Procedimiento As String = "proc_Prestamo"
    
  Private mContrato As Contrato = Nothing

  Private mPardetTipoPrestamo As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer, ByVal _Patron_Codigo As Integer, ByVal _Contra_Secuencia As Integer, ByVal _Presta_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Entida_Codigo = _Entida_Codigo
    Patron_Codigo = _Patron_Codigo
    Contra_Secuencia = _Contra_Secuencia

    Presta_Secuencia = _Presta_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Prestamo")
    End If
  End Sub

  Public Sub New(ByVal _Contrato As Contrato)
    Me.New(_Contrato.OperadorDatos, True)
    Contrato = _Contrato
  End Sub

  'Contrato
  Public Overridable Property Contrato() As Contrato
    Get
      If Me.mContrato Is Nothing AndAlso Entida_Codigo > 0 Then
        Me.mContrato = New Contrato(OperadorDatos, Entida_Codigo, Patron_Codigo, Contra_Secuencia)
      End If
      Return Me.mContrato
    End Get
    Set(ByVal value As Contrato)
      Me.mContrato = value
      Entida_Codigo = value.Entida_Codigo
      Patron_Codigo = value.Patron_Codigo
      Contra_Secuencia = value.Contra_Secuencia
    End Set
  End Property

  Public Property PardetTipoPrestamo() As WWTSParametroDet
    Get
      If mPardetTipoPrestamo Is Nothing AndAlso Pardet_TipoPrestamo <> 0 Then
        mPardetTipoPrestamo = New WWTSParametroDet(OperadorDatos, Parame_TipoPrestamo, Pardet_TipoPrestamo)
      End If
      Return mPardetTipoPrestamo
    End Get
    Set(ByVal value As WWTSParametroDet)
      mPardetTipoPrestamo = value
      Parame_TipoPrestamo = value.Parame_Codigo
      Pardet_TipoPrestamo = value.Pardet_Secuencia
    End Set
  End Property

  Public ReadOnly Property PardetTipoPrestamoString() As String
    Get
      If PardetTipoPrestamo Is Nothing Then
        Return String.Empty
      Else
        Return Me.PardetTipoPrestamo.Pardet_Descripcion
      End If
    End Get
  End Property

#Region "Detalles"
  Private WithEvents mPrestamoDets As PrestamoDetList = Nothing
  Public Property PrestamoDets() As PrestamoDetList
    Get
      If mPrestamoDets Is Nothing Then
        If EsNuevo Then
          mPrestamoDets = New PrestamoDetList
          'mPrestamoDets.AddNew()
        Else
          mPrestamoDets = PrestamoDetList.ObtenerLista(Me)
        End If
      End If
      Return mPrestamoDets
    End Get
    Set(ByVal value As PrestamoDetList)
      mPrestamoDets = value
    End Set
  End Property

  Private Sub mDetalles_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mPrestamoDets.AddingNew
    e.NewObject = New PrestamoDet(Me)
  End Sub
#End Region

  Public ReadOnly Property TotalPagado() As Decimal
    Get
      Dim _pagado As Decimal = 0
      For Each _pago As PrestamoDet In PrestamoDets
        _pagado += _pago.DetPre_Valor
      Next
      Return _pagado
    End Get
  End Property

  Public ReadOnly Property Cancelado() As Boolean
    Get
      Return TotalPagado >= Me.Presta_ValorAprobado
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CInt(Fila("Patron_Codigo"))
    Contra_Secuencia = CInt(Fila("Contra_Secuencia"))
    Presta_Secuencia = CType(Fila("Presta_Secuencia"), Integer)
    Presta_FechaAprobacion = CType(Fila("Presta_FechaAprobacion"), Date)
    Presta_FechaSolicitud = CType(Fila("Presta_FechaSolicitud"), Date)
    Presta_ValorSolicitado = CType(Fila("Presta_ValorSolicitado"), Decimal)
    Presta_ValorCuota = CType(Fila("Presta_ValorCuota"), Decimal)
    Presta_ValorAprobado = CType(Fila("Presta_ValorAprobado"), Decimal)
    Presta_Motivo = CType(Fila("Presta_Motivo"), String)
    Presta_esAprobado = CType(Fila("Presta_esAprobado"), Boolean)
    Presta_Urgente = CType(Fila("Presta_Urgente"), Boolean)
    Parame_TipoPrestamo = CInt(Fila("Parame_TipoPrestamo"))
    Pardet_TipoPrestamo = CInt(Fila("Pardet_TipoPrestamo"))
    mContrato = Nothing
    mPardetTipoPrestamo = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Presta_Secuencia", Presta_Secuencia)
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
    OperadorDatos.AgregarParametro("@Presta_Secuencia", Presta_Secuencia)
    OperadorDatos.AgregarParametro("@Presta_FechaAprobacion", Presta_FechaAprobacion)
    OperadorDatos.AgregarParametro("@Presta_FechaSolicitud", Presta_FechaSolicitud)
    OperadorDatos.AgregarParametro("@Presta_ValorSolicitado", Presta_ValorSolicitado)
    OperadorDatos.AgregarParametro("@Presta_ValorCuota", Presta_ValorCuota)
    OperadorDatos.AgregarParametro("@Presta_ValorAprobado", Presta_ValorAprobado)
    OperadorDatos.AgregarParametro("@Presta_Motivo", Presta_Motivo)
    OperadorDatos.AgregarParametro("@Presta_esAprobado", Presta_esAprobado)
    OperadorDatos.AgregarParametro("@Presta_Urgente", Presta_Urgente)
    OperadorDatos.AgregarParametro("@Parame_TipoPrestamo", Parame_TipoPrestamo)
    OperadorDatos.AgregarParametro("@Pardet_TipoPrestamo", Pardet_TipoPrestamo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Presta_Secuencia = Result
      End If
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
    OperadorDatos.AgregarParametro("@Presta_Secuencia", Presta_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "PrestamoList"
Public Class PrestamoList
  Inherits System.ComponentModel.BindingList(Of Prestamo)

  Enum enumReportePrestamo As Byte
    Todos = 0
    Aprobados = 1
    NoAprobados = 2
    Cancelados = 3
    NoCancelados = 4
  End Enum

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _rep As enumReportePrestamo, Optional ByVal _desde As DateTime = Nothing, Optional ByVal _hasta As DateTime = Nothing, Optional ByVal _tipoprestamo As WWTSParametroDet = Nothing) As PrestamoList
    Dim oResult As New PrestamoList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable
    With _OperadorDatos
      Select Case _rep
        Case enumReportePrestamo.Todos
          .AgregarParametro("@accion", "G")
        Case enumReportePrestamo.Aprobados
          .AgregarParametro("@accion", "GA")
        Case enumReportePrestamo.NoAprobados
          .AgregarParametro("@accion", "GNA")
        Case enumReportePrestamo.Cancelados
          .AgregarParametro("@accion", "GC")
        Case enumReportePrestamo.NoCancelados
          .AgregarParametro("@accion", "GNC")
      End Select
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      If Not (_desde = Nothing And _hasta = Nothing) Then
        .AgregarParametro("@desde", _desde.Date)
        .AgregarParametro("@hasta", _hasta.Date)
      End If
      If _tipoprestamo IsNot Nothing Then
        .AgregarParametro("@Pardet_TipoPrestamo", _tipoprestamo.Pardet_Secuencia)
      End If
      '.AgregarParametro("@Pardet_TipoPrestamo", _tipoprestamo)
      .Procedimiento = "proc_Prestamo"
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New Prestamo(_OperadorDatos, False)
        _obj.MapearDataRowaObjeto(_dr)
        _obj.Recargar()
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function

  'Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _rep As enumReportePrestamo, ByVal _tipoprestamo As Enumerados.enumTipoPrestamo, Optional ByVal _desde As DateTime = Nothing, Optional ByVal _hasta As DateTime = Nothing) As PrestamoList
  '  Dim oResult As New PrestamoList
  '  Dim bReturn As Boolean
  '  Dim dsResult As New DataTable
  '  With _OperadorDatos
  '    Select Case _rep
  '      Case enumReportePrestamo.Todos
  '        .AgregarParametro("@accion", "G")
  '      Case enumReportePrestamo.Aprobados
  '        .AgregarParametro("@accion", "GA")
  '      Case enumReportePrestamo.NoAprobados
  '        .AgregarParametro("@accion", "GNA")
  '      Case enumReportePrestamo.Cancelados
  '        .AgregarParametro("@accion", "GC")
  '      Case enumReportePrestamo.NoCancelados
  '        .AgregarParametro("@accion", "GNC")
  '    End Select
  '    .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
  '    .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
  '    .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
  '    If Not (_desde = Nothing And _hasta = Nothing) Then
  '      .AgregarParametro("@desde", _desde.Date)
  '      .AgregarParametro("@hasta", _hasta.Date)
  '    End If
  '    .AgregarParametro("@Pardet_TipoPrestamo", CInt(_tipoprestamo))
  '    .Procedimiento = "proc_Prestamo"
  '    bReturn = .Ejecutar(dsResult)
  '    .LimpiarParametros()
  '  End With
  '  If bReturn AndAlso dsResult Isnot Nothing AndAlso dsResult.Rows.Count > 0 Then
  '    For Each _dr As DataRow In dsResult.Rows
  '      Dim _obj As New Prestamo(_OperadorDatos, False)
  '      _obj.MapearDataRowaObjeto(_dr)
  '      _obj.Recargar()
  '      oResult.Add(_obj)
  '    Next
  '  End If
  '  Return oResult
  'End Function

  Public Sub New()
  End Sub
End Class
#End Region
