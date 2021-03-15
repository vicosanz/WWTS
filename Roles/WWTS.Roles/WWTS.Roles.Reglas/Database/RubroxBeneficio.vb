Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class RubroxBeneficio
  Inherits _Database

  Private mParame_TipoBeneficio As Integer = 0

  Private mPardet_TipoBeneficio As Integer = 0

  Private mParame_TipoRubro As Integer = 0

  Private mPardet_TipoRubro As Integer = 0

  Private mRubBen_Activo As Boolean = False

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

  Public Overridable Property RubBen_Activo() As Boolean
    Get
      Return Me.mRubBen_Activo
    End Get
    Set(ByVal value As Boolean)
      Me.mRubBen_Activo = value
      EsModificado = True
    End Set
  End Property
End Class
