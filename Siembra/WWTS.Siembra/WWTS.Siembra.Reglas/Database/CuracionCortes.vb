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



#Region "CuracionCortes"
Partial Public Class CuracionCortes
    Inherits _Database

#Region "Campos variables"
    Private mCur_numero As Integer = 0
    Private mCurcorte_secuencia As Integer = 0
    Private mEns_numero As Integer = 0

#End Region

#Region "Propiedades p�blicas de la clase"

    <XmlAttribute()>
    Public Overridable Property Cur_numero() As Integer
        Get
            Return mCur_numero
        End Get
        Set(ByVal Value As Integer)
            mCur_numero = Value
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property Curcorte_secuencia As Integer
        Get
            Return mCurcorte_secuencia
        End Get
        Set(value As Integer)
            mCurcorte_secuencia = value
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property Ens_numero As Integer
        Get
            Return mEns_numero
        End Get
        Set(value As Integer)
            mEns_numero = value
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