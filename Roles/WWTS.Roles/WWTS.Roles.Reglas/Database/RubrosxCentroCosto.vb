Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class RubrosxCentroCosto
  Inherits _Database

  Private mParame_CentroCosto As Integer = 0

  Private mPardet_CentroCosto As Integer = 0

  Private mParame_Rubro As Integer = 0

  Private mPardet_Rubro As Integer = 0

  Private mRubCen_CtaCtble As String = ""

  Public Overridable Property Parame_CentroCosto() As Integer
    Get
      Return Me.mParame_CentroCosto
    End Get
    Set(ByVal value As Integer)
      Me.mParame_CentroCosto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_CentroCosto() As Integer
    Get
      Return Me.mPardet_CentroCosto
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_CentroCosto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_Rubro() As Integer
    Get
      Return Me.mParame_Rubro
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Rubro = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Rubro() As Integer
    Get
      Return Me.mPardet_Rubro
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Rubro = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property RubCen_CtaCtble() As String
    Get
      Return Me.mRubCen_CtaCtble
    End Get
    Set(ByVal value As String)
      Me.mRubCen_CtaCtble = value
      EsModificado = True
    End Set
  End Property
End Class
