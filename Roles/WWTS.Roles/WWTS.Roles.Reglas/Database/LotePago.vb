'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas



#Region "LotePago"
Partial Public Class LotePago
  Inherits _Database

  Private mPatron_Codigo As Integer = 0

  Private mLotPag_Secuencia As Integer = 0

  Private mLotPag_FechaGeneracion As Date = Now.Date

  Private mLotPag_Cerrado As Boolean = True

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
  Public Overridable Property LotPag_Secuencia() As Integer
    Get
      Return Me.mLotPag_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mLotPag_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property LotPag_FechaGeneracion() As Date
    Get
      Return Me.mLotPag_FechaGeneracion
    End Get
    Set(ByVal value As Date)
      Me.mLotPag_FechaGeneracion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property LotPag_Cerrado() As Boolean
    Get
      Return Me.mLotPag_Cerrado
    End Get
    Set(ByVal value As Boolean)
      Me.mLotPag_Cerrado = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region

