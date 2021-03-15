Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "RubroDet"
Public Class RubroDet
  Inherits _Database

  Const _Procedimiento As String = "proc_RubroDet"

  Private mRubro As Rubro = Nothing

  Private mPardetPeriodoPago As WWTSParametroDet = Nothing

  Private mPardetTipoPeriodoPago As WWTSParametroDet = Nothing

  Private mPardetTipoRubro As WWTSParametroDet = Nothing

  Private mPeriodopago As PeriodoPago = Nothing

  Private mPardetSubCentroCosto As WWTSParametroDet = Nothing

  Private mContrato As Contrato = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _rubro As Rubro)
    Me.New(_rubro.OperadorDatos, True)
    Rubro = _rubro
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer, ByVal _Patron_Codigo As Integer, ByVal _Contra_Secuencia As Integer, ByVal _Rubro_Secuencia As Integer, ByVal _RubDet_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Entida_Codigo = _Entida_Codigo
    Patron_Codigo = _Patron_Codigo
    Contra_Secuencia = _Contra_Secuencia
    Rubro_Secuencia = _Rubro_Secuencia
    RubDet_Secuencia = _RubDet_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto RubroDet")
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

  'Rubro
  Public Overridable Property Rubro() As Rubro
    Get
      If Me.mRubro Is Nothing AndAlso Rubro_Secuencia > 0 Then
        Me.mRubro = New Rubro(OperadorDatos, Entida_Codigo, Patron_Codigo, Contra_Secuencia, Rubro_Secuencia)
      End If
      Return Me.mRubro
    End Get
    Set(ByVal value As Rubro)
      Me.mRubro = value
      Entida_Codigo = value.Entida_Codigo
      Patron_Codigo = value.Patron_Codigo
      Contra_Secuencia = value.Contra_Secuencia
      Rubro_Secuencia = value.Rubro_Secuencia
    End Set
  End Property

  'PardetPeriodoPago
  Public Overridable Property PardetPeriodoPago() As WWTSParametroDet
    Get
      If Me.mPardetPeriodoPago Is Nothing AndAlso Pardet_PeriodoPago > 0 Then
        Me.mPardetPeriodoPago = New WWTSParametroDet(OperadorDatos, Me.Parame_PeriodoPago, Me.Pardet_PeriodoPago)
      End If
      Return Me.mPardetPeriodoPago
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetPeriodoPago = value
      If value Is Nothing Then
        Parame_PeriodoPago = 0
        Pardet_PeriodoPago = 0
      Else
        Parame_PeriodoPago = value.Parame_Codigo
        Pardet_PeriodoPago = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetTipoPeriodoPago
  Public Overridable Property PardetTipoPeriodoPago() As WWTSParametroDet
    Get
      If Me.mPardetTipoPeriodoPago Is Nothing AndAlso Pardet_TipoPeriodoPago > 0 Then
        Me.mPardetTipoPeriodoPago = New WWTSParametroDet(OperadorDatos, Me.Parame_TipoPeriodoPago, Me.Pardet_TipoPeriodoPago)
      End If
      Return Me.mPardetTipoPeriodoPago
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoPeriodoPago = value
      If value Is Nothing Then
        Parame_TipoPeriodoPago = 0
        Pardet_TipoPeriodoPago = 0
      Else
        Parame_TipoPeriodoPago = value.Parame_Codigo
        Pardet_TipoPeriodoPago = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetTipoRubro
  Public Overridable Property PardetTipoRubro() As WWTSParametroDet
    Get
      If Me.mPardetTipoRubro Is Nothing AndAlso Pardet_TipoRubro > 0 Then
        Me.mPardetTipoRubro = New WWTSParametroDet(OperadorDatos, Me.Parame_TipoRubro, Me.Pardet_TipoRubro)
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

  'PeriodoPago
  Public Overridable Property PeriodoPago() As PeriodoPago
    Get
      If Me.mPeriodopago Is Nothing AndAlso Pardet_PeriodoPago > 0 Then
        Me.mPeriodopago = New PeriodoPago(OperadorDatos, PerPag_FechaDesde, Parame_PeriodoPago, Pardet_PeriodoPago)
      End If
      Return Me.mPeriodopago
    End Get
    Set(ByVal value As PeriodoPago)
      Me.mPeriodopago = value
      PerPag_FechaDesde = value.PerPag_FechaDesde
      Parame_PeriodoPago = value.Parame_PeriodoPago
      Pardet_PeriodoPago = value.Pardet_PeriodoPago
    End Set
  End Property

  'PardetSubCentroCosto
  Public Overridable Property PardetSubCentroCosto() As WWTSParametroDet
    Get
      If Me.mPardetSubCentroCosto Is Nothing AndAlso Pardet_SubCentroCosto > 0 Then
        Me.mPardetSubCentroCosto = New WWTSParametroDet(OperadorDatos, Me.Parame_SubCentroCosto, Me.Pardet_SubCentroCosto)
      End If
      Return Me.mPardetSubCentroCosto
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetSubCentroCosto = value
      If value Is Nothing Then
        Parame_SubCentroCosto = 0
        Pardet_SubCentroCosto = 0
      Else
        Parame_SubCentroCosto = value.Parame_Codigo
        Pardet_SubCentroCosto = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public ReadOnly Property Grabado() As Boolean
    Get
      If Me.RubDet_Secuencia <> 0 Then
        Return True
      Else
        Return False
      End If
    End Get
  End Property

  Public ReadOnly Property Secuencia() As Integer
    Get
      Return Me.RubDet_Secuencia
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo Rubro", CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property TipoRubroString() As String
    Get
      Return Me.Rubro.PardetTipoRubroString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("FDM", CampoReporteAtributo.EnumTipoDato.Logico, 60, True)> _
  Public ReadOnly Property enFDM() As Boolean
    Get
      Return Me.RubDet_PagarEnFDM
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Valor", CampoReporteAtributo.EnumTipoDato.Decimales, 70, True)> _
  Public ReadOnly Property Valor() As Decimal
    Get
      If PardetTipoRubro Is Nothing Then
        Return RubDet_Valor
      Else
        Return Me.RubDet_Valor * PardetTipoRubro.Pardet_DatoDec1
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha", CampoReporteAtributo.EnumTipoDato.Fecha, 150, True)> _
  Public ReadOnly Property Fecha() As Date
    Get
      Return Me.RubDet_Fecha.Date
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Observación", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property Observacion() As String
    Get
      Return Me.RubDet_Observacion
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("DQu", CampoReporteAtributo.EnumTipoDato.Logico, 60, True)> _
  Public ReadOnly Property desdeQ() As Boolean
    Get
      Return Me.RubDet_CalculadoenQ
    End Get
  End Property

  Public ReadOnly Property SubCentroCostoString() As String
    Get
      If PardetSubCentroCosto IsNot Nothing Then
        Return Me.PardetSubCentroCosto.Pardet_Descripcion
      Else
        Return String.Empty
      End If
    End Get
  End Property

  Public ReadOnly Property Nota() As String
    Get
      If RubDet_Nota Is Nothing Then
        Return String.Empty
      Else
        Return Me.RubDet_Nota
      End If
    End Get
  End Property

  Public ReadOnly Property PardetTipoRubroString() As String
    Get
      If PardetTipoRubro Is Nothing Then
        Return String.Empty
      Else
        Return Me.PardetTipoRubro.Pardet_Descripcion
      End If
    End Get
  End Property

  Dim mvalorvacacion As Decimal = 0
  Public Property valorvacacion() As Decimal
    Get
      Return Me.mvalorvacacion
    End Get
    Set(ByVal value As Decimal)
      Me.mvalorvacacion = value
      EsModificado = True
    End Set
  End Property

  Dim mdiasvacacion As Integer = 0
  Public Property diasvacacion() As Integer
    Get
      Return Me.mdiasvacacion
    End Get
    Set(ByVal value As Integer)
      Me.mdiasvacacion = value
      EsModificado = True
    End Set
  End Property

  Sub calculodiasvacacion(ByVal fdesde As DateTime, ByVal fhasta As DateTime)
    If fdesde.Year = PerPag_FechaDesde.Year And fdesde.Month = PerPag_FechaDesde.Month Then
      If fdesde.Day > 30 Then
        diasvacacion = 1
      ElseIf fdesde.Month = 2 And (fhasta.Day = 28 Or fhasta.Day = 29) Then
        diasvacacion = 1
      Else
        diasvacacion = (30 - fdesde.Day) + 1
      End If
    ElseIf fhasta.Year = PerPag_FechaDesde.Year And fhasta.Month = PerPag_FechaDesde.Month Then
      If fhasta.Day > 30 Then
        diasvacacion = 30
      ElseIf fhasta.Month = 2 And (fhasta.Day = 28 Or fhasta.Day = 29) Then
        diasvacacion = 30
      Else
        diasvacacion = fhasta.Day
      End If
    Else
      diasvacacion = 30
    End If
  End Sub

  Sub calculovalorvacacion(ByVal fdesde As DateTime, ByVal fhasta As DateTime)
    If fdesde.Year = PerPag_FechaDesde.Year And fdesde.Month = PerPag_FechaDesde.Month Then
      If Contrato.Contra_Desde = fdesde Then
        If Pardet_TipoRubro = 1 Then
          valorvacacion = Math.Round(RubDet_Valor2 / 24, 2)
        Else
          valorvacacion = Math.Round(RubDet_Valor / 24, 2)
        End If
      Else
        If fdesde.Day > 30 Then
          If Pardet_TipoRubro = 1 Then
            valorvacacion = Math.Round((RubDet_Valor2 / 30) / 24, 2)
          Else
            valorvacacion = Math.Round((RubDet_Valor / 30) / 24, 2)
          End If
        ElseIf fdesde.Month = 2 And (fhasta.Day = 28 Or fhasta.Day = 29) Then
          If Pardet_TipoRubro = 1 Then
            valorvacacion = Math.Round((RubDet_Valor2 / 30) / 24, 2)
          Else
            valorvacacion = Math.Round((RubDet_Valor / 30) / 24, 2)
          End If
        Else
          If Pardet_TipoRubro = 1 Then
            valorvacacion = Math.Round((RubDet_Valor2 * (30 - fdesde.Day + 1) / 30) / 24, 2)
          Else
            valorvacacion = Math.Round((RubDet_Valor * (30 - fdesde.Day + 1) / 30) / 24, 2)
          End If
        End If
      End If
    ElseIf fhasta.Year = PerPag_FechaDesde.Year And fhasta.Month = PerPag_FechaDesde.Month Then
      If fhasta.Day > 30 Then
        If Pardet_TipoRubro = 1 Then
          valorvacacion = Math.Round(RubDet_Valor2 / 24, 2)
        Else
          valorvacacion = Math.Round(RubDet_Valor / 24, 2)
        End If
      ElseIf fhasta.Month = 2 And (fhasta.Day = 28 Or fhasta.Day = 29) Then
        If Pardet_TipoRubro = 1 Then
          valorvacacion = Math.Round(RubDet_Valor2 / 24, 2)
        Else
          valorvacacion = Math.Round(RubDet_Valor / 24, 2)
        End If
      Else
        If Pardet_TipoRubro = 1 Then
          If RubDet_PagarenLiq = True Then
            valorvacacion = Math.Round(RubDet_Valor2 / 24, 2)
          Else
            valorvacacion = Math.Round((RubDet_Valor2 * fhasta.Day / 30) / 24, 2)
          End If
        Else
          If RubDet_PagarenLiq = True Then
            valorvacacion = Math.Round(RubDet_Valor / 24, 2)
          Else
            valorvacacion = Math.Round((RubDet_Valor * fhasta.Day / 30) / 24, 2)
          End If
        End If
      End If
    Else
      If Pardet_TipoRubro = 1 Then
        valorvacacion = Math.Round(RubDet_Valor2 / 24, 2)
      Else
        valorvacacion = Math.Round(RubDet_Valor / 24, 2)
      End If
    End If
  End Sub

  Public ReadOnly Property Saldo() As Decimal
    Get
      If Me.Rubro.Rubro_esInfinito = False Then
        If Pardet_TipoRubro = Enumerados.enumTipoRubroNoDefinidoContrato.PrestamoPersonal Then
          Return Me.Rubro.Saldo
        Else
          Return 0
        End If
      Else
        Return 0
      End If
    End Get
  End Property

  Private mExiste As Integer = 0
  Public Property Existe As Integer
    Get
      Return mExiste
    End Get
    Set(value As Integer)
      mExiste = value
    End Set
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Contra_Secuencia = CType(Fila("Contra_Secuencia"), Integer)
    Rubro_Secuencia = CType(Fila("Rubro_Secuencia"), Integer)
    RubDet_Secuencia = CType(Fila("RubDet_Secuencia"), Integer)
    RubDet_Valor = CType(Fila("RubDet_Valor"), Decimal)
    Try
      PerPag_FechaDesde = CType(Fila("PerPag_FechaDesde"), Date)
      Parame_PeriodoPago = CType(Fila("Parame_PeriodoPago"), Integer)
      Pardet_PeriodoPago = CType(Fila("Pardet_PeriodoPago"), Integer)
    Catch ex As Exception
      PerPag_FechaDesde = Nothing
    End Try
    If TypeOf Fila("RubDet_PagarEnFDM") Is DBNull Then
      RubDet_PagarEnFDM = False
    Else
      RubDet_PagarEnFDM = CBool(Fila("RubDet_PagarEnFDM"))
    End If
    If TypeOf Fila("RubDet_CalculadoenQ") Is DBNull Then
      RubDet_CalculadoenQ = False
    Else
      RubDet_CalculadoenQ = CBool(Fila("RubDet_CalculadoenQ"))
    End If
    'PerPag_FechaDesde = CType(Fila("PerPag_FechaDesde"), Date)
    'Parame_PeriodoPago = CType(Fila("Parame_PeriodoPago"), Integer)
    'Pardet_PeriodoPago = CType(Fila("Pardet_PeriodoPago"), Integer)
    Parame_TipoPeriodoPago = CType(Fila("Parame_TipoPeriodoPago"), Integer)
    Pardet_TipoPeriodoPago = CType(Fila("Pardet_TipoPeriodoPago"), Integer)
    RubDet_Observacion = CType(Fila("RubDet_Observacion"), String)
    RubDet_Fecha = CType(Fila("RubDet_Fecha"), Date)
    RubDet_ValorFinal = CType(Fila("RubDet_ValorFinal"), Decimal)
    RubDet_Nota = CType(Fila("RubDet_Nota"), String)
    If TypeOf Fila("RubDet_Cantidad") Is dbnull Then
      rubdet_cantidad = 0
    Else
      RubDet_Cantidad = CDec(Fila("RubDet_Cantidad"))
    End If
    Parame_TipoRubro = CType(Fila("Parame_TipoRubro"), Integer)
    Pardet_TipoRubro = CType(Fila("Pardet_TipoRubro"), Integer)
    RubDet_PagarenLiq = CType(Fila("RubDet_PagarenLiq"), Boolean)

    Try
      Parame_Departamento = CType(Fila("Parame_Departamento"), Integer)
      Pardet_Departamento = CType(Fila("Pardet_Departamento"), Integer)
      Parame_Area = CType(Fila("Parame_Area"), Integer)
      Pardet_Area = CType(Fila("Pardet_Area"), Integer)
      Cargo_Secuencia = CType(Fila("Cargo_Secuencia"), Integer)
      Parame_SubCentroCosto = CType(Fila("Parame_SubCentroCosto"), Integer)
      Pardet_SubCentroCosto = CType(Fila("Pardet_SubCentroCosto"), Integer)
    Catch ex As Exception
      Parame_Departamento = 0
      Pardet_Departamento = 0
      Parame_Area = 0
      Pardet_Area = 0
      Cargo_Secuencia = 0
      Parame_SubCentroCosto = 0
      Pardet_SubCentroCosto = 0
    End Try

    If TypeOf Fila("RubDet_Cantidad2") Is DBNull Then
      RubDet_Cantidad2 = -1
    Else
      RubDet_Cantidad2 = CDec(Fila("RubDet_Cantidad2"))
    End If

    If TypeOf Fila("RubDet_Valor2") Is DBNull Then
      RubDet_Valor2 = -1
    Else
      RubDet_Valor2 = CType(Fila("RubDet_Valor2"), Decimal)
    End If

    RubDet_AcumularFondoReserva = CType(Fila("RubDet_AcumularFondoReserva"), Boolean)

    RubDet_GoceVacaciones = CBool(Fila("RubDet_GoceVacaciones"))

    If TypeOf Fila("RubDet_PagadoD3") Is DBNull Then
      RubDet_PagadoD3 = Nothing
    Else
      RubDet_PagadoD3 = CType(Fila("RubDet_PagadoD3"), DateTime)
    End If
    If TypeOf Fila("RubDet_PagadoD4") Is DBNull Then
      RubDet_PagadoD4 = Nothing
    Else
      RubDet_PagadoD4 = CType(Fila("RubDet_PagadoD4"), DateTime)
    End If
    If TypeOf Fila("RubDet_PagadoVac") Is DBNull Then
      RubDet_PagadoVac = Nothing
    Else
      RubDet_PagadoVac = CType(Fila("RubDet_PagadoVac"), DateTime)
    End If

    Try
      Existe = CDec(Fila("Existe"))
    Catch ex As Exception
      mExiste = 1
    End Try
    EsNuevo = Not mExiste = 1
    mPardetPeriodoPago = Nothing
    mPardetTipoPeriodoPago = Nothing
    mRubro = Nothing
    mPardetTipoRubro = Nothing
    mContrato = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Rubro_Secuencia", Rubro_Secuencia)
    OperadorDatos.AgregarParametro("@RubDet_Secuencia", RubDet_Secuencia)
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
    OperadorDatos.AgregarParametro("@RubDet_Secuencia", RubDet_Secuencia)
    OperadorDatos.AgregarParametro("@RubDet_Valor", RubDet_Valor)
    If Not PerPag_FechaDesde = Nothing Then
      OperadorDatos.AgregarParametro("@PerPag_FechaDesde", PerPag_FechaDesde.Date)
      OperadorDatos.AgregarParametro("@Parame_PeriodoPago", Parame_PeriodoPago)
      OperadorDatos.AgregarParametro("@Pardet_PeriodoPago", Pardet_PeriodoPago)
    End If
    OperadorDatos.AgregarParametro("@RubDet_PagarEnFDM", RubDet_PagarEnFDM)
    OperadorDatos.AgregarParametro("@RubDet_CalculadoenQ", RubDet_CalculadoenQ)
    OperadorDatos.AgregarParametro("@Parame_TipoPeriodoPago", Parame_TipoPeriodoPago)
    OperadorDatos.AgregarParametro("@Pardet_TipoPeriodoPago", Pardet_TipoPeriodoPago)
    OperadorDatos.AgregarParametro("@RubDet_Observacion", RubDet_Observacion)
    OperadorDatos.AgregarParametro("@RubDet_Fecha", RubDet_Fecha.Date)
    OperadorDatos.AgregarParametro("@RubDet_ValorFinal", RubDet_ValorFinal)
    OperadorDatos.AgregarParametro("@RubDet_Nota", RubDet_Nota)
    OperadorDatos.AgregarParametro("@RubDet_Cantidad", RubDet_Cantidad)
    OperadorDatos.AgregarParametro("@Parame_TipoRubro", Parame_TipoRubro)
    OperadorDatos.AgregarParametro("@Pardet_TipoRubro", Pardet_TipoRubro)
    OperadorDatos.AgregarParametro("@RubDet_PagarenLiq", RubDet_PagarenLiq)

    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Cargo_Secuencia", Cargo_Secuencia)
    OperadorDatos.AgregarParametro("@Parame_SubCentroCosto", Parame_SubCentroCosto)
    OperadorDatos.AgregarParametro("@Pardet_SubCentroCosto", Pardet_SubCentroCosto)

    If Not RubDet_Cantidad2 = -1 Then
      OperadorDatos.AgregarParametro("@RubDet_Cantidad2", RubDet_Cantidad2)
    End If
    If Not RubDet_Valor2 = -1 Then
      OperadorDatos.AgregarParametro("@RubDet_Valor2", RubDet_Valor2)
    End If

    OperadorDatos.AgregarParametro("@RubDet_AcumularFondoReserva", RubDet_AcumularFondoReserva)

    OperadorDatos.AgregarParametro("@RubDet_GoceVacaciones", RubDet_GoceVacaciones)
    If Not RubDet_PagadoD3 = Nothing Then
      OperadorDatos.AgregarParametro("@RubDet_PagadoD3", RubDet_PagadoD3)
    End If
    If Not RubDet_PagadoD4 = Nothing Then
      OperadorDatos.AgregarParametro("@RubDet_PagadoD4", RubDet_PagadoD4)
    End If
    If Not RubDet_PagadoVac = Nothing Then
      OperadorDatos.AgregarParametro("@RubDet_PagadoVac", RubDet_PagadoVac)
    End If

    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        RubDet_Secuencia = Result
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
    OperadorDatos.AgregarParametro("@RubDet_Secuencia", RubDet_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function

  Public Shared Function UpdatePeriodoVacacion(ByVal _beneficio As BeneficiosSociales) As Boolean
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing

    Dim _fechadesde As Date = _beneficio.BenSoc_FechaDesde
    _fechadesde = _fechadesde.AddDays(-_fechadesde.Day + 1)

    With _beneficio.OperadorDatos
      .AgregarParametro("@accion", "UV")
      .AgregarParametro("@Entida_Codigo", _beneficio.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _beneficio.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _beneficio.Contra_Secuencia)
      .AgregarParametro("@desde", _fechadesde)
      .AgregarParametro("@hasta", _beneficio.BenSoc_FechaHasta)
      .AgregarParametro("@BenSoc_Secuencia", _beneficio.BenSoc_Secuencia)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    'If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
    '  For Each _dr As DataRow In ds.Rows
    '    Dim _fila As New RubroDet(_beneficio.OperadorDatos, False)
    '    _fila.MapearDataRowaObjeto(_dr)
    '    oResult.Add(_fila)
    '  Next
    'End If
    Return bReturn
  End Function

  Public Shared Function UpdatePeriodoVacacion(ByVal _rubro As Rubro) As Boolean
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing

    'Dim _fechadesde As Date = _beneficio.BenSoc_FechaDesde
    '_fechadesde = _fechadesde.AddDays(-_fechadesde.Day + 1)

    With _rubro.OperadorDatos
      .AgregarParametro("@accion", "UVV")
      .AgregarParametro("@Entida_Codigo", _rubro.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _rubro.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _rubro.Contra_Secuencia)
      .AgregarParametro("@desde", _rubro.Rubro_FechaDesde)
      '.AgregarParametro("@hasta", _rubro.BenSoc_FechaHasta)
      .AgregarParametro("@BenSoc_Secuencia", _rubro.Rubro_VacacionSecuencia)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    'If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
    '  For Each _dr As DataRow In ds.Rows
    '    Dim _fila As New RubroDet(_beneficio.OperadorDatos, False)
    '    _fila.MapearDataRowaObjeto(_dr)
    '    oResult.Add(_fila)
    '  Next
    'End If
    Return bReturn
  End Function
End Class
#End Region

#Region "RubroDetList"
Public Class RubroDetList
  Inherits System.ComponentModel.BindingList(Of RubroDet)

  Public Shared Function ObtenerListaxRubro(ByVal _OperadorDatos As OperadorDatos, ByVal _Rubro As Rubro, Optional ByVal _filtro As String = "") As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FR")
      .AgregarParametro("@Entida_Codigo", _Rubro.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Rubro.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Rubro.Contra_Secuencia)
      .AgregarParametro("@Rubro_Secuencia", _Rubro.Rubro_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaQuincena(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, _PeriodoPago As PeriodoPago, Optional ByVal _filtro As String = "") As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FQ")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@PerPag_FechaDesde", _PeriodoPago.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _PeriodoPago.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _PeriodoPago.Pardet_PeriodoPago)
      .AgregarParametro("@Parame_TipoPeriodoPago", Enumerados.EnumParametros.TipoPeriodoPago) 'Periodo - Quincena
      .AgregarParametro("@Pardet_TipoPeriodoPago", Enumerados.enumTipoPeriodoPago.Quincena)
      .AgregarParametro("@fechacorte", _PeriodoPago.PerPag_FechaHasta)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaFinMes(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, _PeriodoPago As PeriodoPago, Optional ByVal _filtro As String = "") As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FM")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@PerPag_FechaDesde", _PeriodoPago.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _PeriodoPago.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _PeriodoPago.Pardet_PeriodoPago)
      .AgregarParametro("@Parame_TipoPeriodoPago", Enumerados.EnumParametros.TipoPeriodoPago) 'Periodo - FindeMes
      .AgregarParametro("@Pardet_TipoPeriodoPago", Enumerados.enumTipoPeriodoPago.FindeMes)
      .AgregarParametro("@fechacorte", _PeriodoPago.PerPag_FechaHasta)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaLiquidacion(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, Optional ByVal _filtro As String = "") As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FL")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaLiquidacionPositivo(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, Optional ByVal _filtro As String = "") As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FP")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaLiquidacionNegativo(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, Optional ByVal _filtro As String = "") As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FN")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  'Public Shared Function ObtenerListaBeneficios(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _TipoBeneficio As Enumerados.enumTipoBeneficio) As RubroDetList
  '  Dim oResult As RubroDetList = New RubroDetList
  '  Dim bReturn As Boolean
  '  Dim ds As DataTable = Nothing
  '  With _OperadorDatos
  '    .AgregarParametro("@accion", "FB")
  '    .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
  '    .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
  '    .AgregarParametro("@contra_Secuencia", _Contrato.Contra_Secuencia)
  '    .AgregarParametro("@Pardet_TipoBeneficio", _TipoBeneficio)
  '    .Procedimiento = "proc_RubroDet"
  '    bReturn = .Ejecutar(ds)
  '    .LimpiarParametros()
  '  End With
  '  If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
  '    For Each _dr As DataRow In ds.Rows
  '      Dim _fila As New RubroDet(_OperadorDatos, False)
  '      _fila.MapearDataRowaObjeto(_dr)
  '      oResult.Add(_fila)
  '    Next
  '  End If
  '  Return oResult
  'End Function

  Public Shared Function ObtenerListaBeneficios(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _TipoBeneficio As Enumerados.enumTipoBeneficio, ByVal _desde As Date, ByVal _hasta As Date) As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FB")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@Pardet_TipoBeneficio", _TipoBeneficio)
      If Not (_desde = Nothing And _hasta = Nothing) Then
        If _desde = Nothing Then
          .AgregarParametro("@cortado", 2)
        Else
          .AgregarParametro("@cortado", 1)
          .AgregarParametro("@desde", _desde)
        End If
        .AgregarParametro("@hasta", _hasta)
      End If

      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  'Public Shared Function ObtenerListaBeneficios(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _TipoBeneficio As Enumerados.enumTipoBeneficio, ByVal _hasta As Date) As RubroDetList
  '  Dim oResult As RubroDetList = New RubroDetList
  '  Dim bReturn As Boolean
  '  Dim ds As DataTable = Nothing
  '  With _OperadorDatos
  '    .AgregarParametro("@accion", "FB")
  '    .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
  '    .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
  '    .AgregarParametro("@contra_Secuencia", _Contrato.Contra_Secuencia)
  '    .AgregarParametro("@Pardet_TipoBeneficio", _TipoBeneficio)
  '    .AgregarParametro("@cortado", 2)
  '    .AgregarParametro("@hasta", _hasta)
  '    .Procedimiento = "proc_RubroDet"
  '    bReturn = .Ejecutar(ds)
  '    .LimpiarParametros()
  '  End With
  '  If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
  '    For Each _dr As DataRow In ds.Rows
  '      Dim _fila As New RubroDet(_OperadorDatos, False)
  '      _fila.MapearDataRowaObjeto(_dr)
  '      oResult.Add(_fila)
  '    Next
  '  End If
  '  Return oResult
  'End Function

  Public Shared Function ObtenerListaPeriodoVacacion(ByVal _beneficio As BeneficiosSociales) As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing

    Dim _fechadesde As Date = _beneficio.BenSoc_FechaDesde
    _fechadesde = _fechadesde.AddDays(-_fechadesde.Day + 1)

    With _beneficio.OperadorDatos
      .AgregarParametro("@accion", "FV")
      .AgregarParametro("@Entida_Codigo", _beneficio.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _beneficio.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _beneficio.Contra_Secuencia)
      .AgregarParametro("@desde", _fechadesde)
      .AgregarParametro("@hasta", _beneficio.BenSoc_FechaHasta)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_beneficio.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  'Public Shared Function ObtenerListaPeriodoValoresVacacion(ByVal _beneficio As BeneficiosSociales) As RubroDetList
  '  Dim oResult As RubroDetList = New RubroDetList
  '  Dim bReturn As Boolean
  '  Dim ds As DataTable = Nothing

  '  Dim _fechadesde As Date = _beneficio.BenSoc_FechaDesde
  '  _fechadesde = _fechadesde.AddDays(-_fechadesde.Day + 1)

  '  With _beneficio.OperadorDatos
  '    .AgregarParametro("@accion", "FVV")
  '    .AgregarParametro("@Entida_Codigo", _beneficio.Entida_Codigo)
  '    .AgregarParametro("@Patron_Codigo", _beneficio.Patron_Codigo)
  '    .AgregarParametro("@Contra_Secuencia", _beneficio.Contra_Secuencia)
  '    .AgregarParametro("@desde", _fechadesde)
  '    .AgregarParametro("@hasta", _beneficio.BenSoc_FechaHasta)
  '    .Procedimiento = "proc_RubroDet"
  '    bReturn = .Ejecutar(ds)
  '    .LimpiarParametros()
  '  End With
  '  If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
  '    For Each _dr As DataRow In ds.Rows
  '      Dim _fila As New RubroDet(_beneficio.OperadorDatos, False)
  '      _fila.MapearDataRowaObjeto(_dr)
  '      oResult.Add(_fila)
  '    Next
  '  End If
  '  Return oResult
  'End Function

  Public Shared Function ObtenerListaPeriodoValoresVacacionReporte(ByVal _beneficio As BeneficiosSociales) As RubroDetList
    Dim oResult As RubroDetList = New RubroDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing

    Dim _fechadesde As Date = _beneficio.BenSoc_FechaDesde
    _fechadesde = _fechadesde.AddDays(-_fechadesde.Day + 1)

    With _beneficio.OperadorDatos
      .AgregarParametro("@accion", "FVR")
      .AgregarParametro("@Entida_Codigo", _beneficio.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _beneficio.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _beneficio.Contra_Secuencia)
      .AgregarParametro("@desde", _fechadesde)
      .AgregarParametro("@hasta", _beneficio.BenSoc_FechaHasta)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroDet(_beneficio.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function EliminarxTipoPeriodoPago(_Contrato As Contrato, _PeriodoPago As PeriodoPago, _enumTipoPeriodoPago As Enumerados.enumTipoPeriodoPago)
    Dim bReturn As Boolean = False

    With _Contrato.OperadorDatos
      .AgregarParametro("@accion", "EP")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@Pardet_TipoPeriodoPago", _enumTipoPeriodoPago)
      .AgregarParametro("@PerPag_FechaDesde", _PeriodoPago.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _PeriodoPago.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _PeriodoPago.Pardet_PeriodoPago)
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar()
      .LimpiarParametros()
    End With

    Return bReturn
  End Function

  Public Shared Function MarcarPagadosBeneficios(_contrato As Contrato, _fechaCierre As Date, _desde As Date, _hasta As Date) As Boolean
    Dim bReturn As Boolean = False

    With _contrato.OperadorDatos
      .AgregarParametro("@accion", "mb")
      .AgregarParametro("@Entida_Codigo", _contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _contrato.Contra_Secuencia)
      .AgregarParametro("@rubdet_pagadod3", _fechaCierre.Date)
      .AgregarParametro("@rubdet_pagadod4", _fechaCierre.Date)
      .AgregarParametro("@rubdet_pagadovac", _fechaCierre.Date)
      If Not (_desde = Nothing And _hasta = Nothing) Then
        If _desde = Nothing Then
          .AgregarParametro("@cortado", 2)
        Else
          .AgregarParametro("@cortado", 1)
          .AgregarParametro("@desde", _desde)
        End If
        .AgregarParametro("@hasta", _hasta)
      End If
      .Procedimiento = "proc_RubroDet"
      bReturn = .Ejecutar()
      .LimpiarParametros()
    End With

    Return bReturn
  End Function

End Class
#End Region