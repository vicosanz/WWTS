
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Public Class Seleccion
  Inherits _Database

  Private mSelecc_Codigo As Integer = 0

  Private mSelecc_Fecha As Date = Now.Date

  Private mParame_Departamento As Integer = 0

  Private mPardet_Departamento As Integer = 0

  Private mParame_Area As Integer = 0

  Private mPardet_Area As Integer = 0

  Private mSelecc_Estado As Boolean = True

  Public Sub New()
    MyBase.New()
  End Sub

  Public Overridable Property Selecc_Codigo() As Integer
    Get
      Return Me.mSelecc_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mSelecc_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Selecc_Fecha() As Date
    Get
      Return Me.mSelecc_Fecha
    End Get
    Set(ByVal value As Date)
      Me.mSelecc_Fecha = value
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

  Public Overridable Property Selecc_Estado() As Boolean
    Get
      Return Me.mSelecc_Estado
    End Get
    Set(ByVal value As Boolean)
      Me.mSelecc_Estado = value
      EsModificado = True
    End Set
  End Property
End Class
