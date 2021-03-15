Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class TestxArea
  Inherits _Database

  Private mParame_SeleccionTest As Integer = 0

  Private mPardet_SeleccionTest As Integer = 0

  Private mParame_Area As Integer = 0

  Private mPardet_Area As Integer = 0

  Public Overridable Property Parame_SeleccionTest() As Integer
    Get
      Return Me.mParame_SeleccionTest
    End Get
    Set(ByVal value As Integer)
      Me.mParame_SeleccionTest = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_SeleccionTest() As Integer
    Get
      Return Me.mPardet_SeleccionTest
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_SeleccionTest = value
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
End Class
