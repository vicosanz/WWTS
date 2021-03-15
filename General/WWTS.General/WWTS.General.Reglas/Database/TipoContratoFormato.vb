
Option Strict Off
Option Explicit On

Imports Infoware.Reglas
Imports System
Imports System.Xml
Imports System.Xml.Serialization


#Region "TipoContratoFormato"
Partial Public Class TipoContratoFormato
  Inherits _Database

  Private mPatron_Codigo As Integer = 0

  Private mTipCon_Codigo As Integer = 0

  Private mParame_Formato As Integer = 0

  Private mPardet_Formato As Integer = 0

  Private mTiCoFo_Archivo As String = ""

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Patron_Codigo() As Integer
    Get
      Return Me.mPatron_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mPatron_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property TipCon_Codigo() As Integer
    Get
      Return Me.mTipCon_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mTipCon_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Formato() As Integer
    Get
      Return Me.mParame_Formato
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Formato = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Formato() As Integer
    Get
      Return Me.mPardet_Formato
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Formato = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property TiCoFo_Archivo() As String
    Get
      Return Me.mTiCoFo_Archivo
    End Get
    Set(ByVal value As String)
      Me.mTiCoFo_Archivo = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
