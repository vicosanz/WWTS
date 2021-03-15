
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class RubroDet
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mPatron_Codigo As Integer = 0

  Private mContra_Secuencia As Integer = 0

  Private mRubro_Secuencia As Integer = 0

  Private mRubDet_Secuencia As Integer = 0

  Private mRubDet_Valor As Decimal = 0

  Private mPerPag_FechaDesde As Date = Nothing

  Private mParame_PeriodoPago As Integer = 0

  Private mPardet_PeriodoPago As Integer = 0

  Private mRubDet_PagarEnFDM As Boolean = False

  Private mRubDet_CalculadoenQ As Boolean = False

  Private mParame_TipoPeriodoPago As Integer = 0

  Private mPardet_TipoPeriodoPago As Integer = 0

  Private mRubDet_Observacion As String = ""

  Private mRubDet_Fecha As Date = Now.Date

  Private mRubDet_ValorFinal As Decimal = 0

  Private mRubDet_Nota As String = ""

  Private mRubDet_Cantidad As Decimal = 0

  Private mParame_TipoRubro As Integer = 0

  Private mPardet_TipoRubro As Integer = 0

  Private mRubDet_PagarenLiq As Boolean = False

  Private mParame_Departamento As Integer = 0

  Private mPardet_Departamento As Integer = 0

  Private mParame_Area As Integer = 0

  Private mPardet_Area As Integer = 0

  Private mCargo_Secuencia As Integer = 0

  Private mParame_SubCentroCosto As Integer = 0

  Private mPardet_SubCentroCosto As Integer = 0

  Private mRubDet_Cantidad2 As Decimal = 0

  Private mRubDet_Valor2 As Decimal = 0

  Private mRubDet_AcumularFondoReserva As Boolean = False

  Private mRubDet_GoceVacaciones As Boolean = True

  Private mRubDet_PagadoD3 As DateTime = Nothing

  Private mRubDet_PagadoD4 As DateTime = Nothing

  Private mRubDet_PagadoVac As DateTime = Nothing

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

  Public Overridable Property Rubro_Secuencia() As Integer
    Get
      Return Me.mRubro_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mRubro_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Secuencia() As Integer
    Get
      Return Me.mRubDet_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mRubDet_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Valor() As Decimal
    Get
      Return Me.mRubDet_Valor
    End Get
    Set(ByVal value As Decimal)
      Me.mRubDet_Valor = value
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

  Public Overridable Property RubDet_PagarEnFDM() As Boolean
    Get
      Return Me.mRubDet_PagarEnFDM
    End Get
    Set(ByVal value As Boolean)
      Me.mRubDet_PagarEnFDM = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_CalculadoenQ() As Boolean
    Get
      Return Me.mRubDet_CalculadoenQ
    End Get
    Set(ByVal value As Boolean)
      Me.mRubDet_CalculadoenQ = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_TipoPeriodoPago() As Integer
    Get
      Return Me.mParame_TipoPeriodoPago
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoPeriodoPago = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_TipoPeriodoPago() As Integer
    Get
      Return Me.mPardet_TipoPeriodoPago
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoPeriodoPago = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Observacion() As String
    Get
      Return Me.mRubDet_Observacion
    End Get
    Set(ByVal value As String)
      Me.mRubDet_Observacion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Fecha() As Date
    Get
      Return Me.mRubDet_Fecha
    End Get
    Set(ByVal value As Date)
      Me.mRubDet_Fecha = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_ValorFinal() As Decimal
    Get
      Return Me.mRubDet_ValorFinal
    End Get
    Set(ByVal value As Decimal)
      Me.mRubDet_ValorFinal = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Nota() As String
    Get
      Return Me.mRubDet_Nota
    End Get
    Set(ByVal value As String)
      Me.mRubDet_Nota = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Cantidad() As Decimal
    Get
      Return Me.mRubDet_Cantidad
    End Get
    Set(ByVal value As Decimal)
      Me.mRubDet_Cantidad = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_TipoRubro() As Integer
    Get
      Return Me.mParame_TipoRubro
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoRubro = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_TipoRubro() As Integer
    Get
      Return Me.mPardet_TipoRubro
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoRubro = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_PagarenLiq() As Boolean
    Get
      Return Me.mRubDet_PagarenLiq
    End Get
    Set(ByVal value As Boolean)
      Me.mRubDet_PagarenLiq = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_Departamento() As Integer
    Get
      Return Me.mParame_Departamento
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Departamento = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Departamento() As Integer
    Get
      Return Me.mPardet_Departamento
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Departamento = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_Area() As Integer
    Get
      Return Me.mParame_Area
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Area = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Area() As Integer
    Get
      Return Me.mPardet_Area
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Area = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Cargo_Secuencia() As Integer
    Get
      Return Me.mCargo_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mCargo_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_SubCentroCosto() As Integer
    Get
      Return Me.mParame_SubCentroCosto
    End Get
    Set(ByVal value As Integer)
      Me.mParame_SubCentroCosto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_SubCentroCosto() As Integer
    Get
      Return Me.mPardet_SubCentroCosto
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_SubCentroCosto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Cantidad2() As Decimal
    Get
      Return Me.mRubDet_Cantidad2
    End Get
    Set(ByVal value As Decimal)
      Me.mRubDet_Cantidad2 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_Valor2() As Decimal
    Get
      Return Me.mRubDet_Valor2
    End Get
    Set(ByVal value As Decimal)
      Me.mRubDet_Valor2 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_AcumularFondoReserva() As Boolean
    Get
      Return Me.mRubDet_AcumularFondoReserva
    End Get
    Set(ByVal value As Boolean)
      Me.mRubDet_AcumularFondoReserva = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_GoceVacaciones() As Boolean
    Get
      Return Me.mRubDet_GoceVacaciones
    End Get
    Set(ByVal value As Boolean)
      Me.mRubDet_GoceVacaciones = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_PagadoD3() As DateTime
    Get
      Return Me.mRubDet_PagadoD3
    End Get
    Set(ByVal value As DateTime)
      Me.mRubDet_PagadoD3 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_PagadoD4() As DateTime
    Get
      Return Me.mRubDet_PagadoD4
    End Get
    Set(ByVal value As DateTime)
      Me.mRubDet_PagadoD4 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubDet_PagadoVac() As DateTime
    Get
      Return Me.mRubDet_PagadoVac
    End Get
    Set(ByVal value As DateTime)
      Me.mRubDet_PagadoVac = value
      EsModificado = True
    End Set
  End Property

End Class
