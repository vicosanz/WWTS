Imports System.Xml
Imports System.Xml.Serialization
Imports System.Drawing

<Serializable()> _
Public Class ReportField
  Private mEtiqueta As String = String.Empty

  Public Property Etiqueta() As String
    Get
      Return mEtiqueta
    End Get
    Set(ByVal value As String)
      mEtiqueta = value
    End Set
  End Property

  Private mLocation As Point = New Point(0, 0)
  Public Property Location() As Point
    Get
      Return mLocation
    End Get
    Set(ByVal value As Point)
      If value.X < 0 Then
        value.X = 0
      End If
      If value.Y < 0 Then
        value.Y = 0
      End If
      mLocation = value
    End Set
  End Property

  Private mSize As Size = New Size(100, 20)
  Public Property Size() As Size
    Get
      Return mSize
    End Get
    Set(ByVal value As Size)
      mSize = value
    End Set
  End Property

  Private mCampo As String = String.Empty
  Public Property Campo() As String
    Get
      Return mCampo
    End Get
    Set(ByVal value As String)
      mCampo = value
    End Set
  End Property

  Private mFont As Font = New Font("Arial", 10)
  <XmlIgnore()> _
  Public Property Font() As Font
    Get
      Return mFont
    End Get
    Set(ByVal value As Font)
      mFont = value
    End Set
  End Property

  Public Property FontName() As String
    Get
      Return mFont.FontFamily.Name
    End Get
    Set(ByVal value As String)
      mFont = New Font(value, mFont.Size)
    End Set
  End Property

  Public Property FontSize() As Single
    Get
      Return mFont.Size
    End Get
    Set(ByVal value As Single)
      mFont = New Font(mFont.FontFamily.Name, value)
    End Set
  End Property

  Public Property FontStyle() As Integer
    Get
      Return mFont.Style
    End Get
    Set(ByVal value As Integer)
      mFont = New Font(mFont.FontFamily.Name, mFont.Size, CType(value, Drawing.FontStyle))
    End Set
  End Property

  Private mFormat As String = ""
  Public Property Format() As String
    Get
      Return mFormat
    End Get
    Set(ByVal value As String)
      mFormat = value
    End Set
  End Property

  Private mJustificacion As EnumJustificacion = EnumJustificacion.Left
  Public Property Justificacion() As EnumJustificacion
    Get
      Return mJustificacion
    End Get
    Set(ByVal value As EnumJustificacion)
      mJustificacion = value
    End Set
  End Property

  Public Sub New()
  End Sub

  Public Sub New(ByVal _Etiqueta As String, ByVal _campo As String, ByVal _location As Point, Optional ByVal _font As Font = Nothing)
    Etiqueta = _Etiqueta
    Location = _location
    Campo = _campo
    'Ubicacion = _ubicacion
    If _font IsNot Nothing Then Font = _font
  End Sub
End Class

<Serializable()> _
Public Class ReportFieldList
  Inherits List(Of ReportField)
End Class

