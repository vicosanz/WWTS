﻿'------------------------------------------------------------------------------
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


#Region "Cheque"
Partial Public Class Cheque
  Inherits _Database

  Private mEmpres_Codigo As Integer = 0

  Private mParame_Banco As Integer = 0

  Private mPardet_Banco As Integer = 0

  Private mCtaBan_Numero As Integer = 0

  Private mCheque_Numero As Integer = 0

  Private mCheque_Anulado As Boolean = False

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Empres_Codigo() As Integer
    Get
      Return mEmpres_Codigo
    End Get
    Set(ByVal value As Integer)
      mEmpres_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Banco() As Integer
    Get
      Return mParame_Banco
    End Get
    Set(ByVal value As Integer)
      mParame_Banco = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Banco() As Integer
    Get
      Return mPardet_Banco
    End Get
    Set(ByVal value As Integer)
      mPardet_Banco = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property CtaBan_Numero() As Integer
    Get
      Return mCtaBan_Numero
    End Get
    Set(ByVal value As Integer)
      mCtaBan_Numero = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Cheque_Numero() As Integer
    Get
      Return mCheque_Numero
    End Get
    Set(ByVal value As Integer)
      mCheque_Numero = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Cheque_Anulado() As Boolean
    Get
      Return mCheque_Anulado
    End Get
    Set(ByVal value As Boolean)
      mCheque_Anulado = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
