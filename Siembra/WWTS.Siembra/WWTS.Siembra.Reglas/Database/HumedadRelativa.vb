'------------------------------------------------------------------------------
' <auto-generated>
'     Este c�digo fue generado por una herramienta.
'     Versi�n del motor en tiempo de ejecuci�n:2.0.50727.42
'
'     Los cambios en este archivo podr�an causar un comportamiento incorrecto y se perder�n si
'     se vuelve a generar el c�digo.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas



#Region "HumedadRelativa"
Partial Public Class HumedadRelativa
    Inherits _Database

#Region "Campos variables"
    Private mHumRel_Dry As Integer = 0
    Private mHumRel_Wet As Integer = 0
    Private mHumRel_Valor As Integer = 0

#End Region

#Region "Propiedades p�blicas de la clase"

    <XmlAttribute()>
    Public Overridable Property HumRel_Dry() As Integer
        Get
            Return mHumRel_Dry
        End Get
        Set(ByVal Value As Integer)
            mHumRel_Dry = Value
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property HumRel_Wet() As Integer
        Get
            Return mHumRel_Wet
        End Get
        Set(ByVal Value As Integer)
            mHumRel_Wet = Value
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property HumRel_Valor() As Integer
        Get
            Return mHumRel_Valor
        End Get
        Set(ByVal Value As Integer)
            mHumRel_Valor = Value
        End Set
    End Property
#End Region

#Region "Constructores de la clase"
    Public Sub New()
        MyBase.New()
    End Sub
#End Region
End Class
#End Region