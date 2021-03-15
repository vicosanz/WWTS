
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class SeleccionTest
  Inherits _Database

  Private mSelecc_Codigo As Integer = 0

  Private mEntida_Codigo As Integer = 0

  Private mParame_SeleccionTest As Integer = 0

  Private mPardet_SeleccionTest As Integer = 0

  Private mSelTes_Puntaje As Integer = 0

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

  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
      EsModificado = True
    End Set
  End Property

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

  Public Overridable Property SelTes_Puntaje() As Integer
    Get
      Return Me.mSelTes_Puntaje
    End Get
    Set(ByVal value As Integer)
      Me.mSelTes_Puntaje = value
      EsModificado = True
    End Set
  End Property
End Class
