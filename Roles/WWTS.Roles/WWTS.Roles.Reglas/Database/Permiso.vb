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



#Region "Permiso"
Partial Public Class Permiso
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mPatron_Codigo As Integer = 0

  Private mContra_Secuencia As Integer = 0

  Private mPermis_Secuencia As Integer = 0

  Private mParame_TipoPermiso As Integer = 0

  Private mPardet_TipoPermiso As Integer = 0

  Private mPermis_FechaDesde As Date = Now.Date

  Private mPermis_FechaHasta As Date = Now.Date

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
      EsModificado = True
    End Set
  End Property

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
  Public Overridable Property Contra_Secuencia() As Integer
    Get
      Return Me.mContra_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mContra_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Permis_Secuencia() As Integer
    Get
      Return Me.mPermis_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mPermis_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoPermiso() As Integer
    Get
      Return Me.mParame_TipoPermiso
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoPermiso = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoPermiso() As Integer
    Get
      Return Me.mPardet_TipoPermiso
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoPermiso = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Permis_FechaDesde() As Date
    Get
      Return Me.mPermis_FechaDesde
    End Get
    Set(ByVal value As Date)
      Me.mPermis_FechaDesde = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Permis_FechaHasta() As Date
    Get
      Return Me.mPermis_FechaHasta
    End Get
    Set(ByVal value As Date)
      Me.mPermis_FechaHasta = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region

