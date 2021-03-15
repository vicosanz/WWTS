Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "Rubro"
Public Class Rubro
  Inherits _Database

  Const _Procedimiento As String = "proc_rubro"

  Private mContrato As Contrato = Nothing

  Private mPardetTipoRubro As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer, ByVal _Patron_Codigo As Integer, ByVal _Contra_Secuencia As Integer, ByVal _Rubro_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Entida_Codigo = _Entida_Codigo
    Patron_Codigo = _Patron_Codigo
    Contra_Secuencia = _Contra_Secuencia
    Rubro_Secuencia = _Rubro_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Rubro")
    End If
  End Sub

  'Contrato
  Public Overridable Property Contrato() As Contrato
    Get
      If Me.mContrato Is Nothing AndAlso Contra_Secuencia > 0 Then
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

  'PardetTipoRubro
  Public Overridable Property PardetTipoRubro() As WWTSParametroDet
    Get
      If Me.mPardetTipoRubro Is Nothing AndAlso Pardet_TipoRubro > 0 Then
        Me.mPardetTipoRubro = New WWTSParametroDet(OperadorDatos, Parame_TipoRubro, Me.Pardet_TipoRubro)
      End If
      Return Me.mPardetTipoRubro
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoRubro = value
      If value Is Nothing Then
        Parame_TipoRubro = 0
        Pardet_TipoRubro = 0
      Else
        Parame_TipoRubro = value.Parame_Codigo
        Pardet_TipoRubro = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo Rubro", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetTipoRubroString() As String
    Get
      If PardetTipoRubro Is Nothing Then
        Return String.Empty
      Else
        Return Me.PardetTipoRubro.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Total", CampoReporteAtributo.EnumTipoDato.Decimales, 70, True)> _
  Public ReadOnly Property Total() As Decimal
    Get
      If (Rubro_EnFindeMes + Rubro_EnQuincena) > Rubro_ValorTope Then
        Return (Rubro_EnQuincena + Rubro_EnFindeMes)
      Else
        Return Rubro_ValorTope
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("En Quincena", CampoReporteAtributo.EnumTipoDato.Decimales, 70, True)> _
  Public ReadOnly Property Quincena() As Decimal
    Get
      Return Rubro_EnQuincena
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("En Fin de Mes", CampoReporteAtributo.EnumTipoDato.Decimales, 70, True)> _
  Public ReadOnly Property FinMes() As Decimal
    Get
      Return Rubro_EnFindeMes
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Es Infinito", CampoReporteAtributo.EnumTipoDato.Logico, 50, True)> _
  Public ReadOnly Property esInfinito() As Boolean
    Get
      Return Rubro_esInfinito
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Valor Tope", CampoReporteAtributo.EnumTipoDato.Decimales, 70, True)> _
  Public ReadOnly Property ValorTope() As Decimal
    Get
      Return Rubro_ValorTope
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Aportable IESS", CampoReporteAtributo.EnumTipoDato.Logico, 50, True)> _
  Public ReadOnly Property GravaIESS() As Boolean
    Get
      Return Rubro_GravaIESS
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Vigencia", CampoReporteAtributo.EnumTipoDato.Fecha, 100, True)> _
  Public ReadOnly Property FechaVigencia() As Date
    Get
      Return Rubro_FechaDesde
    End Get
  End Property

#Region "Detalles"
  Private WithEvents mRubroDets As RubroDetList = Nothing
  Public Property RubroDets() As RubroDetList
    Get
      If mRubroDets Is Nothing Then
        If EsNuevo Then
          mRubroDets = New RubroDetList
        Else
          mRubroDets = RubroDetList.ObtenerListaxRubro(OperadorDatos, Me)
        End If
      End If
      Return mRubroDets
    End Get
    Set(ByVal value As RubroDetList)
      mRubroDets = value
    End Set
  End Property

  Private Sub mDetalles_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mRubroDets.AddingNew
    e.NewObject = New RubroDet(Me)
  End Sub
#End Region

  Public ReadOnly Property TotalPagado() As Decimal
    Get
      Dim _pagado As Decimal = 0
      For Each _pago As RubroDet In RubroDets
        _pagado += _pago.RubDet_Valor
      Next
      Return _pagado
    End Get
  End Property

  Public ReadOnly Property Saldo() As Decimal
    Get
      Return (Total - TotalPagado)
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Contra_Secuencia = CType(Fila("Contra_Secuencia"), Integer)
    Rubro_Secuencia = CType(Fila("Rubro_Secuencia"), Integer)
    Parame_TipoRubro = CType(Fila("Parame_TipoRubro"), Integer)
    Pardet_TipoRubro = CType(Fila("Pardet_TipoRubro"), Integer)
    Rubro_EnQuincena = CType(Fila("Rubro_EnQuincena"), Decimal)
    Rubro_EnFindeMes = CType(Fila("Rubro_EnFindeMes"), Decimal)
    Rubro_esInfinito = CType(Fila("Rubro_esInfinito"), Boolean)
    Rubro_ValorTope = CType(Fila("Rubro_ValorTope"), Decimal)
    Rubro_GravaIESS = CType(Fila("Rubro_GravaIESS"), Boolean)
    Rubro_FechaDesde = CType(Fila("Rubro_FechaDesde"), Date)
    Rubro_Activo = CType(Fila("Rubro_Activo"), Boolean)
    Rubro_Observacion = CStr(Fila("Rubro_Observacion"))
    Rubro_VacacionSecuencia = CInt(Fila("Rubro_VacacionSecuencia"))
    Rubro_GoceVacaciones = CBool(Fila("Rubro_GoceVacaciones"))
    mContrato = Nothing
    mPardetTipoRubro = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Rubro_Secuencia", Rubro_Secuencia)
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
    OperadorDatos.AgregarParametro("@Rubro_Secuencia", Rubro_Secuencia)
    OperadorDatos.AgregarParametro("@Parame_TipoRubro", Parame_TipoRubro)
    OperadorDatos.AgregarParametro("@Pardet_TipoRubro", Pardet_TipoRubro)
    OperadorDatos.AgregarParametro("@Rubro_EnQuincena", Rubro_EnQuincena)
    OperadorDatos.AgregarParametro("@Rubro_EnFindeMes", Rubro_EnFindeMes)
    OperadorDatos.AgregarParametro("@Rubro_esInfinito", Rubro_esInfinito)
    OperadorDatos.AgregarParametro("@Rubro_ValorTope", Rubro_ValorTope)
    OperadorDatos.AgregarParametro("@Rubro_GravaIESS", Rubro_GravaIESS)
    OperadorDatos.AgregarParametro("@Rubro_FechaDesde", Rubro_FechaDesde)
    OperadorDatos.AgregarParametro("@Rubro_Activo", Rubro_Activo)
    OperadorDatos.AgregarParametro("@Rubro_Observacion", Rubro_Observacion)
    OperadorDatos.AgregarParametro("@Rubro_VacacionSecuencia", Rubro_VacacionSecuencia)
    OperadorDatos.AgregarParametro("@Rubro_GoceVacaciones", Rubro_GoceVacaciones)

    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Rubro_Secuencia = Result
      End If
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
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Rubro_Secuencia", Rubro_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function


  Public Shared Function ObtenerSueldoxContrato(ByVal _Contrato As Contrato) As Rubro
    Dim oResult As Rubro = New Rubro
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Contrato.OperadorDatos
      .AgregarParametro("@accion", "FS")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .Procedimiento = "proc_rubro"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      'For Each _dr As DataRow In ds.Rows
      Dim _fila As New Rubro(_Contrato.OperadorDatos, False)
      '_fila.MapearDataRowaObjeto(_dr)
      _fila.MapearDataRowaObjeto(ds.Rows(0))
      'oResult.Add(_fila)
      oResult = _fila
      'Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerSueldoxContratoMes(ByVal _Contrato As Contrato, ByVal _fecha As Date) As Rubro
    Dim oResult As Rubro = New Rubro
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Contrato.OperadorDatos
      .AgregarParametro("@accion", "FT")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      '.AgregarParametro("@fecha", _fecha.AddMonths(-1).Year.ToString + _fecha.AddMonths(-1).Month.ToString + "01")
      .AgregarParametro("@fecha", _fecha.AddDays(-_fecha.Day + 1))
      .Procedimiento = "proc_rubro"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      'For Each _dr As DataRow In ds.Rows
      Dim _fila As New Rubro(_Contrato.OperadorDatos, False)
      '_fila.MapearDataRowaObjeto(_dr)
      _fila.MapearDataRowaObjeto(ds.Rows(0))
      'oResult.Add(_fila)
      oResult = _fila
      'Next
    End If
    Return oResult
  End Function
End Class
#End Region

#Region "RubroList"
Public Class RubroList
  Inherits System.ComponentModel.BindingList(Of Rubro)

  Public Shared Function ObtenerListaxContrato(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, Optional ByVal _PardetPadre As WWTSParametroDet = Nothing, Optional ByVal _PardetRubro As WWTSParametroDet = Nothing, Optional ByVal _filtro As String = "") As RubroList
    Dim oResult As RubroList = New RubroList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FC")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      If _PardetPadre IsNot Nothing Then
        .AgregarParametro("@Parame_Padre", _PardetPadre.Parame_Codigo)
        .AgregarParametro("@Pardet_Padre", _PardetPadre.Pardet_Secuencia)
      End If
      If _PardetRubro IsNot Nothing Then
        .AgregarParametro("@Parame_TipoRubro", _PardetRubro.Parame_Codigo)
        .AgregarParametro("@Pardet_TipoRubro", _PardetRubro.Pardet_Secuencia)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_rubro"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Rubro(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region