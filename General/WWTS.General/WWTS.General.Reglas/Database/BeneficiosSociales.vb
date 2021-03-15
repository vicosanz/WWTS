
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class BeneficiosSociales
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mPatron_Codigo As Integer = 0

  Private mContra_Secuencia As Integer = 0

  Private mParame_TipoBeneficio As Integer = 0

  Private mPardet_TipoBeneficio As Integer = 0

  Private mBenSoc_Secuencia As Integer = 0

  Private mBenSoc_Valor As Decimal = 0

  Private mBenSoc_NumeroCargas As Integer = -1

  Private mBenSoc_ValorEmpleado As Decimal = 0

  Private mBenSoc_ValorCargas As Decimal = 0

  Private mBenSoc_ValorBono As Decimal = 0

  Private mBenSoc_ValorBonoCargas As Decimal = 0

  Private mBenSoc_ValorBonoAlcance As Decimal = 0

  Private mBenSoc_FechaDesde As Date = Now.Date

  Private mBenSoc_FechaHasta As Date = Now.Date

  Private mBenSoc_Dias As Integer = 0

  Private mBenSoc_Liquidado As Boolean = False

  Private mPerPag_FechaDesde As Date = Now.Date

  Private mParame_PeriodoPago As Integer = 0

  Private mPardet_PeriodoPago As Integer = 0

  Private mParame_PersonaAdicional As Integer = 0

  Private mPardet_PersonaAdicional As Integer = 0

  Private mBenSoc_Observacion As String = ""

  Private mBenLot_Codigo As Integer = 0

  Private mBenSoc_GoceVacaciones As Boolean = True

  Private mBenSoc_FechaDesdeGoceVacaciones As Date = Now.Date

  Private mBenSoc_FechaHastaGoceVacaciones As Date = Now.Date

  Private mBenSoc_DiasAcumulados As Integer = 0

  Private mBenSoc_ValorAcumulado As Decimal = 0

  Private mBenSoc_DecimoTercero As Decimal = 0

  Private mBenSoc_DecimoCuarto As Decimal = 0

  Private mBenSoc_UtilidadAnterior As Decimal = 0

  Private mBenSoc_Salarios As Decimal = 0

  Private mBenSoc_FondoReserva As Decimal = 0

  Private mBenSoc_Comisiones As Decimal = 0

  Private mBenSoc_BeneficiosAdionales As Decimal = 0

  Private mBenSoc_AnticipoUtilidad As Decimal = 0

  Private mBenSoc_RetencionJudicial As Decimal = 0

  Private mBenSoc_ImpuestoRetencion As Decimal = 0

  Private mBenSoc_SalarioDigno As Decimal = 0

  Public Sub New()
    MyBase.New()
  End Sub

  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Patron_Codigo() As Integer
    Get
      Return Me.mPatron_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mPatron_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Contra_Secuencia() As Integer
    Get
      Return Me.mContra_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mContra_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_TipoBeneficio() As Integer
    Get
      Return Me.mParame_TipoBeneficio
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoBeneficio = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_TipoBeneficio() As Integer
    Get
      Return Me.mPardet_TipoBeneficio
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoBeneficio = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Secuencia() As Integer
    Get
      Return Me.mBenSoc_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mBenSoc_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Valor() As Decimal
    Get
      Return Me.mBenSoc_Valor
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_Valor = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ValorAcumulado() As Decimal
    Get
      Return Me.mBenSoc_ValorAcumulado
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_ValorAcumulado = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_NumeroCargas() As Integer
    Get
      Return Me.mBenSoc_NumeroCargas
    End Get
    Set(ByVal value As Integer)
      Me.mBenSoc_NumeroCargas = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ValorEmpleado() As Decimal
    Get
      Return Me.mBenSoc_ValorEmpleado
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_ValorEmpleado = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ValorCargas() As Decimal
    Get
      Return Me.mBenSoc_ValorCargas
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_ValorCargas = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ValorBono() As Decimal
    Get
      Return Me.mBenSoc_ValorBono
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_ValorBono = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ValorBonoCargas() As Decimal
    Get
      Return Me.mBenSoc_ValorBonoCargas
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_ValorBonoCargas = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ValorBonoAlcance() As Decimal
    Get
      Return Me.mBenSoc_ValorBonoAlcance
    End Get
    Set(ByVal value As Decimal)
      Me.mBenSoc_ValorBonoAlcance = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_FechaDesde() As Date
    Get
      Return Me.mBenSoc_FechaDesde
    End Get
    Set(ByVal value As Date)
      Me.mBenSoc_FechaDesde = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_FechaHasta() As Date
    Get
      Return Me.mBenSoc_FechaHasta
    End Get
    Set(ByVal value As Date)
      Me.mBenSoc_FechaHasta = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Dias() As Integer
    Get
      Return Me.mBenSoc_Dias
    End Get
    Set(ByVal value As Integer)
      Me.mBenSoc_Dias = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_DiasAcumulados() As Integer
    Get
      Return Me.mBenSoc_DiasAcumulados
    End Get
    Set(ByVal value As Integer)
      Me.mBenSoc_DiasAcumulados = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Liquidado() As Boolean
    Get
      Return Me.mBenSoc_Liquidado
    End Get
    Set(ByVal value As Boolean)
      Me.mBenSoc_Liquidado = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property PerPag_FechaDesde() As Date
    Get
      Return Me.mPerPag_FechaDesde
    End Get
    Set(ByVal value As Date)
      Me.mPerPag_FechaDesde = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_PeriodoPago() As Integer
    Get
      Return Me.mParame_PeriodoPago
    End Get
    Set(ByVal value As Integer)
      Me.mParame_PeriodoPago = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_PeriodoPago() As Integer
    Get
      Return Me.mPardet_PeriodoPago
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_PeriodoPago = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_PersonaAdicional() As Integer
    Get
      Return Me.mParame_PersonaAdicional
    End Get
    Set(ByVal value As Integer)
      Me.mParame_PersonaAdicional = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_PersonaAdicional() As Integer
    Get
      Return Me.mPardet_PersonaAdicional
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_PersonaAdicional = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Observacion() As String
    Get
      Return Me.mBenSoc_Observacion
    End Get
    Set(ByVal value As String)
      Me.mBenSoc_Observacion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenLot_Codigo() As Integer
    Get
      Return Me.mBenLot_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mBenLot_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_GoceVacaciones() As Boolean
    Get
      Return Me.mBenSoc_GoceVacaciones
    End Get
    Set(ByVal value As Boolean)
      Me.mBenSoc_GoceVacaciones = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_FechaDesdeGoceVacaciones() As Date
    Get
      Return Me.mBenSoc_FechaDesdeGoceVacaciones
    End Get
    Set(ByVal value As Date)
      Me.mBenSoc_FechaDesdeGoceVacaciones = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_FechaHastaGoceVacaciones() As Date
    Get
      Return Me.mBenSoc_FechaHastaGoceVacaciones
    End Get
    Set(ByVal value As Date)
      Me.mBenSoc_FechaHastaGoceVacaciones = value
      EsModificado = True
    End Set
  End Property



  Public Overridable Property BenSoc_DecimoTercero As Decimal
    Get
      Return mBenSoc_DecimoTercero
    End Get
    Set(value As Decimal)
      mBenSoc_DecimoTercero = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_DecimoCuarto As Decimal
    Get
      Return mBenSoc_DecimoCuarto
    End Get
    Set(value As Decimal)
      mBenSoc_DecimoCuarto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_UtilidadAnterior As Decimal
    Get
      Return mBenSoc_UtilidadAnterior
    End Get
    Set(value As Decimal)
      mBenSoc_UtilidadAnterior = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Salarios As Decimal
    Get
      Return mBenSoc_Salarios
    End Get
    Set(value As Decimal)
      mBenSoc_Salarios = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_FondoReserva As Decimal
    Get
      Return mBenSoc_FondoReserva
    End Get
    Set(value As Decimal)
      mBenSoc_FondoReserva = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_Comisiones As Decimal
    Get
      Return mBenSoc_Comisiones
    End Get
    Set(value As Decimal)
      mBenSoc_Comisiones = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_BeneficiosAdionales As Decimal
    Get
      Return mBenSoc_BeneficiosAdionales
    End Get
    Set(value As Decimal)
      mBenSoc_BeneficiosAdionales = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_AnticipoUtilidad As Decimal
    Get
      Return mBenSoc_AnticipoUtilidad
    End Get
    Set(value As Decimal)
      mBenSoc_AnticipoUtilidad = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_RetencionJudicial As Decimal
    Get
      Return mBenSoc_RetencionJudicial
    End Get
    Set(value As Decimal)
      mBenSoc_RetencionJudicial = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_ImpuestoRetencion As Decimal
    Get
      Return mBenSoc_ImpuestoRetencion
    End Get
    Set(value As Decimal)
      mBenSoc_ImpuestoRetencion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property BenSoc_SalarioDigno As Decimal
    Get
      Return mBenSoc_SalarioDigno
    End Get
    Set(value As Decimal)
      mBenSoc_SalarioDigno = value
      EsModificado = True
    End Set
  End Property


End Class
