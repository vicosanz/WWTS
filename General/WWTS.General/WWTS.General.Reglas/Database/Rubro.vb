
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class Rubro
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mPatron_Codigo As Integer = 0

  Private mContra_Secuencia As Integer = 0

  Private mRubro_Secuencia As Integer = 0

  Private mParame_TipoRubro As Integer = 765

  Private mPardet_TipoRubro As Integer = 0

  Private mRubro_EnQuincena As Decimal = 0

  Private mRubro_EnFindeMes As Decimal = 0

  Private mRubro_esInfinito As Boolean = False

  Private mRubro_ValorTope As Decimal = 0

  Private mRubro_GravaIESS As Boolean = False

  Private mRubro_FechaDesde As Date = Now.Date

  Private mRubro_Activo As Boolean = True

  Private mRubro_Observacion As String = String.Empty

  Private mRubro_VacacionSecuencia As Integer = -1

  Private mRubro_GoceVacaciones As Boolean = True

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

  Public Overridable Property Rubro_EnQuincena() As Decimal
    Get
      Return Me.mRubro_EnQuincena
    End Get
    Set(ByVal value As Decimal)
      Me.mRubro_EnQuincena = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_EnFindeMes() As Decimal
    Get
      Return Me.mRubro_EnFindeMes
    End Get
    Set(ByVal value As Decimal)
      Me.mRubro_EnFindeMes = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_esInfinito() As Boolean
    Get
      Return Me.mRubro_esInfinito
    End Get
    Set(ByVal value As Boolean)
      Me.mRubro_esInfinito = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_ValorTope() As Decimal
    Get
      Return Me.mRubro_ValorTope
    End Get
    Set(ByVal value As Decimal)
      Me.mRubro_ValorTope = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_GravaIESS() As Boolean
    Get
      Return Me.mRubro_GravaIESS
    End Get
    Set(ByVal value As Boolean)
      Me.mRubro_GravaIESS = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_FechaDesde() As Date
    Get
      Return Me.mRubro_FechaDesde
    End Get
    Set(ByVal value As Date)
      Me.mRubro_FechaDesde = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_Activo() As Boolean
    Get
      Return Me.mRubro_Activo
    End Get
    Set(ByVal value As Boolean)
      Me.mRubro_Activo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_Observacion() As String
    Get
      Return Me.mRubro_Observacion
    End Get
    Set(ByVal value As String)
      Me.mRubro_Observacion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_VacacionSecuencia() As Integer
    Get
      Return Me.mRubro_VacacionSecuencia
    End Get
    Set(ByVal value As Integer)
      Me.mRubro_VacacionSecuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Rubro_GoceVacaciones() As Boolean
    Get
      Return Me.mRubro_GoceVacaciones
    End Get
    Set(ByVal value As Boolean)
      Me.mRubro_GoceVacaciones = value
      EsModificado = True
    End Set
  End Property
End Class
