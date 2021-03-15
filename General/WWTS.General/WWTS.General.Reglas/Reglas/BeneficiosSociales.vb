
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "BeneficiosSociales"
Public Class BeneficiosSociales
  Inherits _Database

  Const _Procedimiento As String = "proc_BeneficiosSociales"

  Private mContrato As Contrato = Nothing

  Private mPardetTipoBeneficio As WWTSParametroDet = Nothing

  Private mPardetPeriodoPago As WWTSParametroDet = Nothing

  Private mPardetPersonaAdicional As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean, _BenSoc_FechaDesde As DateTime, _BenSoc_FechaHasta As DateTime)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    Me.BenSoc_FechaDesde = _BenSoc_FechaDesde
    Me.BenSoc_FechaHasta = _BenSoc_FechaHasta
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _Parame_TipoBeneficio As Integer, ByVal _Pardet_TipoBeneficio As Enumerados.enumTipoBeneficio, ByVal _BenSoc_Secuencia As Integer, ByVal _Nuevo As Boolean, _BenSoc_FechaDesde As DateTime, _BenSoc_FechaHasta As DateTime)
    Me.New(_OperadorDatos, False, _BenSoc_FechaDesde, _BenSoc_FechaHasta)
    Me.Contrato = _Contrato
    Me.Parame_TipoBeneficio = _Parame_TipoBeneficio
    Me.Pardet_TipoBeneficioEnum = _Pardet_TipoBeneficio
    Me.BenSoc_Secuencia = _BenSoc_Secuencia

    If Not _Nuevo Then
      If Not Me.Recargar() Then
        Throw New Exception("El objeto no puede ser cargado")
      End If
    End If
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _Parame_TipoBeneficio As Integer, ByVal _Pardet_TipoBeneficio As Enumerados.enumTipoBeneficio, ByVal _BenSoc_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Me.Contrato = _Contrato
    Me.Parame_TipoBeneficio = _Parame_TipoBeneficio
    Me.Pardet_TipoBeneficioEnum = _Pardet_TipoBeneficio
    Me.BenSoc_Secuencia = _BenSoc_Secuencia

    If Me.Recargar2 Then
    Else
      Throw New System.Exception("El objeto no puede ser cargado")
    End If
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Shadows Property Pardet_TipoBeneficioEnum() As Enumerados.enumTipoBeneficio
    Get
      Return CType(Pardet_TipoBeneficio, Enumerados.enumTipoBeneficio)
    End Get
    Set(ByVal value As Enumerados.enumTipoBeneficio)
      Pardet_TipoBeneficio = CInt(value)
    End Set
  End Property

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

  'PardetTipoBeneficio
  Public Overridable Property PardetTipoBeneficio() As WWTSParametroDet
    Get
      If Me.mPardetTipoBeneficio Is Nothing AndAlso Pardet_TipoBeneficio > 0 Then
        Me.mPardetTipoBeneficio = New WWTSParametroDet(OperadorDatos, Me.Parame_TipoBeneficio, Me.Pardet_TipoBeneficio)
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


  'PardetPersonaAdicional
  Public Overridable Property PardetPersonaAdicional() As WWTSParametroDet
    Get
      If Me.mPardetPersonaAdicional Is Nothing AndAlso Pardet_PersonaAdicional > 0 Then
        Me.mPardetPersonaAdicional = New WWTSParametroDet(OperadorDatos, Me.Parame_PersonaAdicional, Me.Pardet_PersonaAdicional)
      End If
      Return Me.mPardetPersonaAdicional
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetPersonaAdicional = value
      If value Is Nothing Then
        Parame_PersonaAdicional = 0
        Pardet_PersonaAdicional = 0
      Else
        Parame_PersonaAdicional = value.Parame_Codigo
        Pardet_PersonaAdicional = value.Pardet_Secuencia
      End If
    End Set
  End Property

#Region "Detalles"
  Private WithEvents mLicencias As LicenciaList = Nothing
  Public Property LicenciaVacaciones() As LicenciaList
    Get
      If mLicencias Is Nothing Then
        If EsNuevo Then
          mLicencias = New LicenciaList
        Else
          mLicencias = LicenciaList.ObtenerListaVacacionesxPeriodo(Me)
        End If
      End If
      Return mLicencias
    End Get
    Set(ByVal value As LicenciaList)
      mLicencias = value
    End Set
  End Property

  Private Sub mDetalles_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mLicencias.AddingNew
    'e.NewObject = New Licencia(Me)
  End Sub
#End Region

  Public ReadOnly Property DiasUtilizados() As Integer
    Get
      Dim _diasUtil As Integer = 0
      For Each _vacacion As Licencia In LicenciaVacaciones
        _diasUtil += (DateDiff(DateInterval.Day, _vacacion.FechaDesde, _vacacion.FechaHasta) + 1)
      Next
      Return _diasUtil
    End Get
  End Property

  'Public ReadOnly Property Saldo() As Decimal
  '  Get
  '    Return (Total - TotalPagado)
  '  End Get
  'End Property

  Public ReadOnly Property Periodo() As String
    Get
      Return String.Format("{0}  -  {1}", Me.BenSoc_FechaDesde.ToShortDateString, Me.BenSoc_FechaHasta.ToShortDateString)
    End Get
  End Property

  Public ReadOnly Property PeriodoVacDiasPendientes() As String
    Get
      Return String.Format("{0}  -  {1} ({2} días, {3} pendientes)", Me.BenSoc_FechaDesde.ToShortDateString, Me.BenSoc_FechaHasta.ToShortDateString, Me.BenSoc_Dias.ToString, (Me.BenSoc_Dias - Me.DiasUtilizados).ToString)
    End Get
  End Property

  Public ReadOnly Property CedulaEmpleado() As String
    Get
      If PardetPersonaAdicional IsNot Nothing Then
        Return PardetPersonaAdicional.Pardet_DatoStr1
      End If
      If Contrato Is Nothing OrElse Contrato.Empleado Is Nothing Then
        Return String.Empty
      End If
      Return Contrato.Empleado.Cedula
    End Get
  End Property

  Public ReadOnly Property CodigoEmpleado() As String
    Get
      If Contrato Is Nothing OrElse Contrato.Empleado Is Nothing Then
        Return String.Empty
      End If
      Return Contrato.Empleado.CodigoEmpleado
    End Get
  End Property

  Public ReadOnly Property NombreEmpleado() As String
    Get
      If PardetPersonaAdicional IsNot Nothing Then
        Return String.Format("{0} {1}", PardetPersonaAdicional.Pardet_DatoStr3, PardetPersonaAdicional.Pardet_Descripcion)
      End If
      If Contrato Is Nothing OrElse Contrato.Empleado Is Nothing Then
        Return String.Empty
      End If
      Return Contrato.Empleado.NombreCompleto
    End Get
  End Property

  ''Private mNumeroCargas As Integer = -1
  Public ReadOnly Property NumeroCargas() As Integer
    Get
      If mBenSoc_NumeroCargas = -1 Then
        mBenSoc_NumeroCargas = Contrato.Empleado.NumeroCargasUtilidad(BenSoc_FechaDesde, BenSoc_FechaHasta)
      End If
      Return mBenSoc_NumeroCargas
    End Get
  End Property

  Private mdias
  Public Property DiasBeneficio() As Integer
    Get
      Return mdias
    End Get
    Set(ByVal value As Integer)
      mdias = value
    End Set
  End Property

  Private mcortado As Integer = 0
  Public Property cortado() As Integer
    Get
      Return mcortado
    End Get
    Set(ByVal value As Integer)
      mcortado = value
    End Set
  End Property

  Private mdesde As Date = Date.Now
  Public Property desde() As Date
    Get
      Return mdesde
    End Get
    Set(ByVal value As Date)
      mdesde = value
    End Set
  End Property

  Private mhasta As Date = Date.Now
  Public Property hasta() As Date
    Get
      Return mhasta
    End Get
    Set(ByVal value As Date)
      mhasta = value
    End Set
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Contra_Secuencia = CType(Fila("Contra_Secuencia"), Integer)
    Parame_TipoBeneficio = CType(Fila("Parame_TipoBeneficio"), Integer)
    Pardet_TipoBeneficio = CType(Fila("Pardet_TipoBeneficio"), Integer)
    BenSoc_Secuencia = CType(Fila("BenSoc_Secuencia"), Integer)
    BenSoc_Valor = (CType(Fila("BenSoc_Valor"), Decimal))
    BenSoc_ValorEmpleado = CDec(Fila("BenSoc_ValorEmpleado"))
    BenSoc_ValorCargas = CDec(Fila("BenSoc_ValorCargas"))
    BenSoc_ValorBono = CType(Fila("BenSoc_ValorBono"), Decimal)
    BenSoc_ValorBonoCargas = CType(Fila("BenSoc_ValorBonoCargas"), Decimal)
    BenSoc_ValorBonoAlcance = CType(Fila("BenSoc_ValorBonoAlcance"), Decimal)
    BenSoc_FechaDesde = CType(Fila("BenSoc_FechaDesde"), Date)
    BenSoc_FechaHasta = CType(Fila("BenSoc_FechaHasta"), Date)
    BenSoc_Dias = CType(Fila("BenSoc_Dias"), Integer)
    BenSoc_Liquidado = CType(Fila("BenSoc_Liquidado"), Boolean)
    If BenSoc_Liquidado Then
      Try
        PerPag_FechaDesde = CType(Fila("PerPag_FechaDesde"), Date)
        Parame_PeriodoPago = CType(Fila("Parame_PeriodoPago"), Integer)
        Pardet_PeriodoPago = CType(Fila("Pardet_PeriodoPago"), Integer)
      Catch ex As Exception
        PerPag_FechaDesde = Date.Now
      End Try
    End If

    If TypeOf Fila("Parame_PersonaAdicional") Is DBNull Then
      Parame_PersonaAdicional = 0
      Pardet_PersonaAdicional = 0
    Else
      Parame_PersonaAdicional = CInt(Fila("Parame_PersonaAdicional"))
      Pardet_PersonaAdicional = CInt(Fila("Pardet_PersonaAdicional"))
    End If
    BenSoc_Observacion = CType(Fila("BenSoc_Observacion"), String)

    Try
      BenLot_Codigo = CType(Fila("BenLot_Codigo"), Integer)
    Catch ex As Exception
      BenLot_Codigo = 0
    End Try

    Try
      mBenSoc_NumeroCargas = CInt(Fila("BenSoc_NumeroCargas"))
    Catch ex As Exception
      mBenSoc_NumeroCargas = 0
    End Try

    BenSoc_GoceVacaciones = CType(Fila("BenSoc_GoceVacaciones"), Boolean)
    If BenSoc_GoceVacaciones Then
      Try
        BenSoc_FechaDesdeGoceVacaciones = CType(Fila("BenSoc_FechaDesdeGoceVacaciones"), Date)
        BenSoc_FechaHastaGoceVacaciones = CType(Fila("BenSoc_FechaHastaGoceVacaciones"), Date)
      Catch ex As Exception
        BenSoc_FechaDesdeGoceVacaciones = Date.Now
        BenSoc_FechaHastaGoceVacaciones = Date.Now
      End Try
    End If



    If TypeOf Fila("BenSoc_DecimoTercero") Is DBNull Then
      BenSoc_DecimoTercero = 0
    Else
      BenSoc_DecimoTercero = CDec(Fila("BenSoc_DecimoTercero"))
    End If


    If TypeOf Fila("BenSoc_DecimoCuarto") Is DBNull Then
      BenSoc_DecimoCuarto = 0
    Else
      BenSoc_DecimoCuarto = CDec(Fila("BenSoc_DecimoCuarto"))
    End If


    If TypeOf Fila("BenSoc_UtilidadAnterior") Is DBNull Then
      BenSoc_UtilidadAnterior = 0
    Else
      BenSoc_UtilidadAnterior = CDec(Fila("BenSoc_UtilidadAnterior"))
    End If


    If TypeOf Fila("BenSoc_Salarios") Is DBNull Then
      BenSoc_Salarios = 0
    Else
      BenSoc_Salarios = CDec(Fila("BenSoc_Salarios"))
    End If


    If TypeOf Fila("BenSoc_FondoReserva") Is DBNull Then
      BenSoc_FondoReserva = 0
    Else
      BenSoc_FondoReserva = CDec(Fila("BenSoc_FondoReserva"))
    End If


    If TypeOf Fila("BenSoc_Comisiones") Is DBNull Then
      BenSoc_Comisiones = 0
    Else
      BenSoc_Comisiones = CDec(Fila("BenSoc_Comisiones"))
    End If


    If TypeOf Fila("BenSoc_BeneficiosAdionales") Is DBNull Then
      BenSoc_BeneficiosAdionales = 0
    Else
      BenSoc_BeneficiosAdionales = CDec(Fila("BenSoc_BeneficiosAdionales"))
    End If


    If TypeOf Fila("BenSoc_AnticipoUtilidad") Is DBNull Then
      BenSoc_AnticipoUtilidad = 0
    Else
      BenSoc_AnticipoUtilidad = CDec(Fila("BenSoc_AnticipoUtilidad"))
    End If


    If TypeOf Fila("BenSoc_RetencionJudicial") Is DBNull Then
      BenSoc_RetencionJudicial = 0
    Else
      BenSoc_RetencionJudicial = CDec(Fila("BenSoc_RetencionJudicial"))
    End If


    If TypeOf Fila("BenSoc_ImpuestoRetencion") Is DBNull Then
      BenSoc_ImpuestoRetencion = 0
    Else
      BenSoc_ImpuestoRetencion = CDec(Fila("BenSoc_ImpuestoRetencion"))
    End If

    If TypeOf Fila("BenSoc_SalarioDigno") Is DBNull Then
      BenSoc_SalarioDigno = 0
    Else
      BenSoc_SalarioDigno = CDec(Fila("BenSoc_SalarioDigno"))
    End If


    mContrato = Nothing
    mPardetTipoBeneficio = Nothing
    mPardetPeriodoPago = Nothing
    mPardetPersonaAdicional = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenSoc_Secuencia", BenSoc_Secuencia)
    OperadorDatos.AgregarParametro("@BenSoc_FechaDesde", mBenSoc_FechaDesde)
    OperadorDatos.AgregarParametro("@BenSoc_FechaHasta", mBenSoc_FechaHasta)
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

  Public Overridable Function Recargar2() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "CC")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenSoc_Secuencia", BenSoc_Secuencia)
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
    If Entida_Codigo = 0 Then
      OperadorDatos.AgregarParametro("@Parame_PersonaAdicional", Parame_PersonaAdicional)
      OperadorDatos.AgregarParametro("@Pardet_PersonaAdicional", Pardet_PersonaAdicional)
    Else
      OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
      OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    End If
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenSoc_Secuencia", BenSoc_Secuencia)
    OperadorDatos.AgregarParametro("@BenSoc_Valor", BenSoc_Valor)
    OperadorDatos.AgregarParametro("@BenSoc_ValorAcumulado", BenSoc_ValorAcumulado)
    OperadorDatos.AgregarParametro("@BenSoc_NumeroCargas", BenSoc_NumeroCargas)
    OperadorDatos.AgregarParametro("@BenSoc_ValorEmpleado", BenSoc_ValorEmpleado)
    OperadorDatos.AgregarParametro("@BenSoc_ValorCargas", BenSoc_ValorCargas)
    OperadorDatos.AgregarParametro("@BenSoc_ValorBono", BenSoc_ValorBono)
    OperadorDatos.AgregarParametro("@BenSoc_ValorBonoCargas", BenSoc_ValorBonoCargas)
    OperadorDatos.AgregarParametro("@BenSoc_ValorBonoAlcance", BenSoc_ValorBonoAlcance)
    OperadorDatos.AgregarParametro("@BenSoc_FechaDesde", BenSoc_FechaDesde)
    OperadorDatos.AgregarParametro("@BenSoc_FechaHasta", BenSoc_FechaHasta)
    OperadorDatos.AgregarParametro("@BenSoc_Dias", BenSoc_Dias)
    OperadorDatos.AgregarParametro("@BenSoc_DiasAcumulados", BenSoc_DiasAcumulados)
    OperadorDatos.AgregarParametro("@BenSoc_Liquidado", BenSoc_Liquidado)
    If BenSoc_Liquidado Then
      OperadorDatos.AgregarParametro("@PerPag_FechaDesde", PerPag_FechaDesde.Date)
      OperadorDatos.AgregarParametro("@Parame_PeriodoPago", Parame_PeriodoPago)
      OperadorDatos.AgregarParametro("@Pardet_PeriodoPago", Pardet_PeriodoPago)
    End If
    OperadorDatos.AgregarParametro("@BenSoc_GoceVacaciones", BenSoc_GoceVacaciones)
    If BenSoc_GoceVacaciones Then
      OperadorDatos.AgregarParametro("@BenSoc_FechaDesdeGoceVacaciones", BenSoc_FechaDesdeGoceVacaciones.Date)
      OperadorDatos.AgregarParametro("@BenSoc_FechaHastaGoceVacaciones", BenSoc_FechaHastaGoceVacaciones.Date)
    End If
    OperadorDatos.AgregarParametro("@BenSoc_Observacion", BenSoc_Observacion)

    OperadorDatos.AgregarParametro("@BenSoc_DecimoTercero", BenSoc_DecimoTercero)
    OperadorDatos.AgregarParametro("@BenSoc_DecimoCuarto", BenSoc_DecimoCuarto)
    OperadorDatos.AgregarParametro("@BenSoc_UtilidadAnterior", BenSoc_UtilidadAnterior)
    OperadorDatos.AgregarParametro("@BenSoc_Salarios", BenSoc_Salarios)
    OperadorDatos.AgregarParametro("@BenSoc_FondoReserva", BenSoc_FondoReserva)
    OperadorDatos.AgregarParametro("@BenSoc_Comisiones", BenSoc_Comisiones)
    OperadorDatos.AgregarParametro("@BenSoc_BeneficiosAdionales", BenSoc_BeneficiosAdionales)
    OperadorDatos.AgregarParametro("@BenSoc_AnticipoUtilidad", BenSoc_AnticipoUtilidad)
    OperadorDatos.AgregarParametro("@BenSoc_RetencionJudicial", BenSoc_RetencionJudicial)
    OperadorDatos.AgregarParametro("@BenSoc_ImpuestoRetencion", BenSoc_ImpuestoRetencion)
    OperadorDatos.AgregarParametro("@BenSoc_SalarioDigno", BenSoc_SalarioDigno)

    If BenLot_Codigo <> 0 Then
      OperadorDatos.AgregarParametro("@BenLot_Codigo", BenLot_Codigo)
    End If

    If cortado = 1 Then
      OperadorDatos.AgregarParametro("@cortado", 1)
      OperadorDatos.AgregarParametro("@desde", desde)
      OperadorDatos.AgregarParametro("@hasta", hasta)
    ElseIf cortado = 2 Then
      OperadorDatos.AgregarParametro("@cortado", 2)
      OperadorDatos.AgregarParametro("@hasta", hasta)
    End If

    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        BenSoc_Secuencia = Result
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
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@BenSoc_Secuencia", BenSoc_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "BeneficiosSocialesList"
Public Class BeneficiosSocialesList
  Inherits System.ComponentModel.BindingList(Of BeneficiosSociales)

  Public Shared Function ObtenerListaxContrato(ByVal _Contrato As Contrato, Optional ByVal _filtro As String = "") As BeneficiosSocialesList
    Dim oResult As BeneficiosSocialesList = New BeneficiosSocialesList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Contrato.OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_BeneficiosSociales"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New BeneficiosSociales(_Contrato.OperadorDatos, False, Nothing, Nothing)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  'Public Shared Function ObtenerListaxLote(ByVal _lote As BeneficiosSocialesLotePago, Optional ByVal _filtro As String = "") As BeneficiosSocialesList
  '  Dim oResult As BeneficiosSocialesList = New BeneficiosSocialesList
  '  Dim bReturn As Boolean
  '  Dim ds As DataTable = Nothing
  '  With _lote.OperadorDatos
  '    .AgregarParametro("@accion", "FL")
  '    .AgregarParametro("@BeSoLoPa_Codigo", _lote.BeSoLoPa_Codigo)
  '    .AgregarParametro("@filtro", _filtro)
  '    .Procedimiento = "proc_BeneficiosSociales"
  '    bReturn = .Ejecutar(ds)
  '    .LimpiarParametros()
  '  End With
  '  If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
  '    For Each _dr As DataRow In ds.Rows
  '      Dim _fila As New BeneficiosSociales(_lote.OperadorDatos, False)
  '      _fila.MapearDataRowaObjeto(_dr)
  '      oResult.Add(_fila)
  '    Next
  '  End If
  '  Return oResult
  'End Function

End Class
#End Region


Public Class BeneficioSocialCalculado
  Inherits _Database

#Region "Campos constantes"
  Private Const _Procedimiento As String = "proc_BeneficiosSociales"
#End Region
#Region "Campos variables"
  Private mContrato As Contrato = Nothing
  Private mTipoBeneficio As Enumerados.enumTipoBeneficio = Enumerados.enumTipoBeneficio.DecimoTercero
  Private mDiasAcumulados As Double = 0
  Private mDiasCalculados As Double = 0
  Private mValorAcumulado As Decimal = 0
  Private mValorCalculado As Decimal = 0
  Private mFecDesde As DateTime = Now.Date
  Private mFecHasta As DateTime = Now.Date
  Private mUtilidadCalculada As Decimal = 0
  Private mUtilidadCargas As Decimal = 0
  Private mUtilidadBono As Decimal = 0
  Private mUtilidadBonoCargas As Decimal = 0
  Private mSecuenciaVacacion As Integer = 0
  Private mValord3 As Decimal = 0
  Private mValord4 As Decimal = 0
  Private mSueldosacumulados As Decimal = 0
  Private mFondoReserva As Decimal = 0
  Private mUtilidadAnterior As Decimal = 0

  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(ByVal Value As Contrato)
      If Value Is Nothing Then
        Throw New ArgumentNullException("No se pudo enlazar Contrato")
      End If
      Me.mContrato = Value
    End Set
  End Property
  Public Property TipoBeneficioEnum() As Enumerados.enumTipoBeneficio
    Get
      Return CType(mTipoBeneficio, Enumerados.enumTipoBeneficio)
    End Get
    Set(ByVal Value As Enumerados.enumTipoBeneficio)
      mTipoBeneficio = CInt(Value)
    End Set
  End Property
  Public ReadOnly Property DecimoCalculado() As Decimal
    Get
      Select Case mTipoBeneficio
        Case Enumerados.enumTipoBeneficio.DecimoCuarto
          Dim config As ConfigRoles
          config = New ConfigRoles(Me.OperadorDatos, mContrato.Patrono.PardetParroquia.PardetPadre.PardetPadre.PardetPadre, False)
          Return config.Cnfrol_salariomv / 360 * DiasAcumulados
        Case Enumerados.enumTipoBeneficio.DecimoTercero
          Return ValorAcumulado
        Case Enumerados.enumTipoBeneficio.Vacaciones
          Return ValorAcumulado
      End Select
    End Get
  End Property
  Public Property DiasAcumulados() As Double
    Get
      Return mDiasAcumulados
    End Get
    Set(ByVal Value As Double)
      mDiasAcumulados = Value
    End Set
  End Property

  Public Property DiasCalculados() As Double
    Get
      Return mDiasCalculados
    End Get
    Set(ByVal Value As Double)
      mDiasCalculados = Value
    End Set
  End Property
  Public Property ValorAcumulado() As Decimal
    Get
      Return mValorAcumulado
    End Get
    Set(ByVal Value As Decimal)
      mValorAcumulado = Value
    End Set
  End Property
  Public Property ValorCalculado() As Decimal
    Get
      Return mValorCalculado
    End Get
    Set(ByVal Value As Decimal)
      mValorCalculado = Value
    End Set
  End Property
  Public Property FecDesde() As DateTime
    Get
      Return mFecDesde
    End Get
    Set(ByVal Value As DateTime)
      mFecDesde = Value
    End Set
  End Property
  Public Property FecHasta() As DateTime
    Get
      Return mFecHasta
    End Get
    Set(ByVal Value As DateTime)
      mFecHasta = Value
    End Set
  End Property
  Public Property UtilidadCalculada() As Decimal
    Get
      Return mUtilidadCalculada
    End Get
    Set(ByVal value As Decimal)
      mUtilidadCalculada = value
    End Set
  End Property
  Public Property UtilidadCargas() As Decimal
    Get
      Return mUtilidadCargas
    End Get
    Set(ByVal value As Decimal)
      mUtilidadCargas = value
    End Set
  End Property
  Public Property UtilidadBono() As Decimal
    Get
      Return mUtilidadBono
    End Get
    Set(ByVal value As Decimal)
      mUtilidadBono = value
    End Set
  End Property
  Public Property UtilidadBonoCargas() As Decimal
    Get
      Return mUtilidadBonoCargas
    End Get
    Set(ByVal value As Decimal)
      mUtilidadBonoCargas = value
    End Set
  End Property
  Public Property SecuenciaVacacion() As Integer
    Get
      Return mSecuenciaVacacion
    End Get
    Set(ByVal value As Integer)
      mSecuenciaVacacion = value
    End Set
  End Property

  Public Property Valord3 As Decimal
    Get
      Return mValord3
    End Get
    Set(value As Decimal)
      mValord3 = value
    End Set
  End Property
  Public Property Valord4 As Decimal
    Get
      Return mValord4
    End Get
    Set(value As Decimal)
      mValord4 = value
    End Set
  End Property
  Public Property Sueldosacumulados As Decimal
    Get
      Return mSueldosacumulados
    End Get
    Set(value As Decimal)
      mSueldosacumulados = value
    End Set
  End Property
  Public Property FondoReserva As Decimal
    Get
      Return mFondoReserva
    End Get
    Set(value As Decimal)
      mFondoReserva = value
    End Set
  End Property
  Public Property UtilidadAnterior As Decimal
    Get
      Return mUtilidadAnterior
    End Get
    Set(value As Decimal)
      mUtilidadAnterior = value
    End Set
  End Property

#End Region
#Region "Constructores"
  'Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _TipoBeneficio As Enumerados.enumTipoBeneficio)
  '  If _OperadorDatos Is Nothing Then
  '    Throw New InvalidOperationException("El Operador de datos es nulo")
  '  End If
  '  OperadorDatos = _OperadorDatos
  '  Contrato = _Contrato
  '  TipoBeneficioEnum = _TipoBeneficio
  '  If Not Recargar() Then
  '    'Throw New Exception("El objeto no puede ser cargado")
  '  End If
  'End Sub
  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _TipoBeneficio As Enumerados.enumTipoBeneficio, ByVal _desde As DateTime, ByVal _hasta As DateTime)
    If _OperadorDatos Is Nothing Then
      Throw New InvalidOperationException("El Operador de datos es nulo")
    End If
    OperadorDatos = _OperadorDatos
    Contrato = _Contrato
    TipoBeneficioEnum = _TipoBeneficio
    If Not Recargar(_desde, _hasta) Then
      'Throw New Exception("El objeto no puede ser cargado")
    End If
  End Sub
  'Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _TipoBeneficio As Enumerados.enumTipoBeneficio, ByVal _hasta As DateTime)
  '  If _OperadorDatos Is Nothing Then
  '    Throw New InvalidOperationException("El Operador de datos es nulo")
  '  End If
  '  OperadorDatos = _OperadorDatos
  '  Contrato = _Contrato
  '  TipoBeneficioEnum = _TipoBeneficio
  '  If Not Recargar(_hasta) Then
  '    'Throw New Exception("El objeto no puede ser cargado")
  '  End If
  'End Sub
#End Region
#Region "Implementación de los métodos de persistencia"
  'Public Function Recargar() As Boolean
  '  Dim dsResult As New DataTable
  '  Dim bResult As Boolean

  '  With Me.OperadorDatos
  '    .AgregarParametro("@accion", "CB")
  '    .AgregarParametro("@Contra_Secuencia", Contrato.Contra_Secuencia)
  '    .AgregarParametro("@Entida_Codigo", Contrato.Entida_Codigo)
  '    .AgregarParametro("@Patron_codigo", Contrato.Patron_Codigo)
  '    .AgregarParametro("@Pardet_Tipobeneficio", Me.TipoBeneficioEnum)
  '    .Procedimiento = _Procedimiento
  '    bResult = .Ejecutar(dsResult)
  '    .LimpiarParametros()
  '  End With
  '  If bResult AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
  '    Me.MapearDataRowaObjeto(dsResult.Rows(0))
  '    Return True
  '  Else
  '    Return False
  '  End If
  'End Function
  Public Function Recargar(ByVal _desde As DateTime, ByVal _hasta As DateTime) As Boolean
    Dim dsResult As New DataTable
    Dim bResult As Boolean

    With Me.OperadorDatos
      .AgregarParametro("@accion", "CB")
      .AgregarParametro("@Contra_Secuencia", Contrato.Contra_Secuencia)
      .AgregarParametro("@Entida_Codigo", Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_codigo", Contrato.Patron_Codigo)
      .AgregarParametro("@Pardet_TipoBeneficio", Me.TipoBeneficioEnum)
      If _desde = Nothing AndAlso Not _hasta = Nothing Then
        .AgregarParametro("@cortado", 2)
      ElseIf Not _desde = Nothing AndAlso Not _hasta = Nothing Then
        .AgregarParametro("@cortado", 1)
      End If
      If Not _desde = Nothing Then
        .AgregarParametro("@desde", _desde)
      End If
      If Not _hasta = Nothing Then
        .AgregarParametro("@hasta", _hasta)
      End If
      .Procedimiento = _Procedimiento
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bResult AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      Me.MapearDataRowaObjeto(dsResult.Rows(0))
      Return True
    Else
      Return False
    End If
  End Function
  'Public Function Recargar(ByVal _hasta As DateTime) As Boolean
  '  Dim dsResult As New DataTable
  '  Dim bResult As Boolean

  '  With Me.OperadorDatos
  '    .AgregarParametro("@accion", "CB")
  '    .AgregarParametro("@Contra_Secuencia", Contrato.Contra_Secuencia)
  '    .AgregarParametro("@Entida_Codigo", Contrato.Entida_Codigo)
  '    .AgregarParametro("@Patron_codigo", Contrato.Patron_Codigo)
  '    .AgregarParametro("@Pardet_TipoBeneficio", Me.TipoBeneficioEnum)
  '    .AgregarParametro("@cortado", 2)
  '    .AgregarParametro("@hasta", _hasta)
  '    .Procedimiento = _Procedimiento
  '    bResult = .Ejecutar(dsResult)
  '    .LimpiarParametros()
  '  End With
  '  If bResult AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
  '    Me.MapearDataRowaObjeto(dsResult.Rows(0))
  '    Return True
  '  Else
  '    Return False
  '  End If
  'End Function
#End Region
#Region "Métodos internos de la clase"
  Private Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Select Case mTipoBeneficio
      Case Enumerados.enumTipoBeneficio.DecimoTercero
        Me.mDiasAcumulados = CInt(Fila("diasperiodo"))
        Me.mValorAcumulado = CDec(Fila("valorperiodo"))
        Me.mValorCalculado = CDec(Fila("valord3"))
      Case Enumerados.enumTipoBeneficio.DecimoCuarto
        Me.mDiasAcumulados = CInt(Fila("diasperiodo"))
        Me.mValorCalculado = CDec(Fila("valord4"))
      Case Enumerados.enumTipoBeneficio.Vacaciones
        Me.mDiasAcumulados = CInt(Fila("diasperiodo"))
        Me.mDiasCalculados = CInt(Fila("diasvac"))
        Me.mValorAcumulado = CDec(Fila("valorperiodo"))
        Me.mValorCalculado = CDec(Fila("valorvac"))
        Me.mFecDesde = CDate(Fila("desde"))
        Me.mFecHasta = CDate(Fila("hasta"))
        Me.mSecuenciaVacacion = CInt(Fila("BenSoc_Secuencia"))
      Case Enumerados.enumTipoBeneficio.Utilidades
        Me.mDiasAcumulados = CInt(Fila("diasuti"))
        mValord3 = CDec(Fila("Valord3"))
        mValord4 = CDec(Fila("Valord4"))
        mSueldosacumulados = CDec(Fila("SueldosAcumulados"))
        mFondoReserva = CDec(Fila("FondoReserva"))
        mUtilidadAnterior = CDec(Fila("UtilidadAnterior"))
    End Select
  End Sub
#End Region
End Class