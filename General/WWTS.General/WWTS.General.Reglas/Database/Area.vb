
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Public Class Area
  Inherits _Database

  Private mParame_Departamento As Integer = 0

  Private mPardet_Departamento As Integer = 0

  Private mParame_Area As Integer = 0

  Private mPardet_Area As Integer = 0

  Private mArea_Dotacion As Integer = 0

  Public Sub New()
    MyBase.New()
  End Sub

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

  Public Overridable Property Area_Dotacion() As Integer
    Get
      Return Me.mArea_Dotacion
    End Get
    Set(ByVal value As Integer)
      Me.mArea_Dotacion = value
      EsModificado = True
    End Set
  End Property
End Class
