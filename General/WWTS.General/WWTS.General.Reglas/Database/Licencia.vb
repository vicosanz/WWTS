
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class Licencia
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mPatron_Codigo As Integer = 0

  Private mContra_Secuencia As Integer = 0

  Private mLicenc_Secuencia As Integer = 0

  Private mLicenc_Desde As Date = Now.Date

  Private mLicenc_Hasta As Date = Now.Date

  Private mParame_Licencia As Integer = 0

  Private mPardet_Licencia As Integer = 0

  Private mParame_TipoBeneficio As Integer = 0

  Private mPardet_TipoBeneficio As Integer = 0

  Private mBenSoc_Secuencia As Integer = 0

  Private mParame_AdjuntoLicencia As Integer = 0

  Private mPardet_AdjuntoLicencia As Integer = 0

  Private mLicenc_VacacionAprobado As Boolean = False

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

  Public Overridable Property Licenc_Secuencia() As Integer
    Get
      Return Me.mLicenc_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mLicenc_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Licenc_Desde() As Date
    Get
      Return Me.mLicenc_Desde
    End Get
    Set(ByVal value As Date)
      Me.mLicenc_Desde = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Licenc_Hasta() As Date
    Get
      Return Me.mLicenc_Hasta
    End Get
    Set(ByVal value As Date)
      Me.mLicenc_Hasta = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_Licencia() As Integer
    Get
      Return Me.mParame_Licencia
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Licencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Licencia() As Integer
    Get
      Return Me.mPardet_Licencia
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Licencia = value
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

  Public Overridable Property Parame_AdjuntoLicencia() As Integer
    Get
      Return Me.mParame_AdjuntoLicencia
    End Get
    Set(ByVal value As Integer)
      Me.mParame_AdjuntoLicencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_AdjuntoLicencia() As Integer
    Get
      Return Me.mPardet_AdjuntoLicencia
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_AdjuntoLicencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Licenc_VacacionAprobado() As Boolean
    Get
      Return Me.mLicenc_VacacionAprobado
    End Get
    Set(ByVal value As Boolean)
      Me.mLicenc_VacacionAprobado = value
      EsModificado = True
    End Set
  End Property
End Class
