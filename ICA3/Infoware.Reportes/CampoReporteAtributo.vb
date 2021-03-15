<AttributeUsage(AttributeTargets.Property, allowmultiple:=False)> _
Public Class CampoReporteAtributo
  Inherits Attribute

  Private mTipoDato As EnumTipoDato = EnumTipoDato.Texto
  Private mIgnorar As Boolean = False
  Private mEtiqueta As String = ""
  Private mCampo As String = ""
  Private mTamano As Integer = 100
  Private mPredeterminado As Boolean = False

  Public Property TipoDato() As EnumTipoDato
    Get
      Return mTipoDato
    End Get
    Set(ByVal value As EnumTipoDato)
      mTipoDato = value
    End Set
  End Property

  Public Property Ignorar() As Boolean
    Get
      Return mIgnorar
    End Get
    Set(ByVal value As Boolean)
      mIgnorar = value
    End Set
  End Property

  Public Property Etiqueta() As String
    Get
      Return mEtiqueta
    End Get
    Set(ByVal value As String)
      mEtiqueta = value
    End Set
  End Property

  Public Property Campo() As String
    Get
      Return mCampo
    End Get
    Set(ByVal value As String)
      mCampo = value
    End Set
  End Property

  Public Property Tamano() As String
    Get
      Return mTamano
    End Get
    Set(ByVal value As String)
      mTamano = value
    End Set
  End Property

  Public Property Predeterminado() As Boolean
    Get
      Return mPredeterminado
    End Get
    Set(ByVal value As Boolean)
      mPredeterminado = value
    End Set
  End Property

  Public Sub New(ByVal _Etiqueta As String, Optional ByVal _TipoDato As EnumTipoDato = EnumTipoDato.Texto, Optional ByVal _Tamano As Integer = 100, Optional ByVal _Predeterminado As Boolean = False)
    mEtiqueta = _Etiqueta
    mIgnorar = False
    mTipoDato = _TipoDato
    mTamano = _Tamano
    mPredeterminado = _Predeterminado
  End Sub

  Public Sub New(ByVal _Ignorar As Boolean)
    mIgnorar = _Ignorar
  End Sub

  Public Enum EnumTipoDato
    Texto = 1
    Numero = 2
    Decimales = 3
    Fecha = 4
    Logico = 5
    Boton = 6
  End Enum
End Class
