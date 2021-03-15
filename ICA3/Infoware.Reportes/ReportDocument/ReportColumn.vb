''' <summary>
''' Defines a column into whch text can be rendered on a line
''' of a table when the <see cref="T:vbReport.ReportDocument" />
''' is bound to a datasource.
''' </summary>
Public Class ReportColumn
  Private mTitulo As String = String.Empty
  Public Property Titulo() As String
    Get
      Return mTitulo
    End Get
    Set(ByVal value As String)
      mTitulo = value
    End Set
  End Property

  Private mAnchoPorc As Decimal = 0%
  Public Property AnchoPorc() As Decimal
    Get
      Return mAnchoPorc
    End Get
    Set(ByVal value As Decimal)
      mAnchoPorc = value
    End Set
  End Property

  Private mLeft As Decimal = 0
  Public Property Left() As Decimal
    Get
      Return mLeft
    End Get
    Set(ByVal value As Decimal)
      mLeft = value
    End Set
  End Property

  Private mAncho As Decimal = 100
  Public Property Ancho() As Decimal
    Get
      Return mAncho
    End Get
    Set(ByVal value As Decimal)
      mAncho = value
    End Set
  End Property

  Private mField As String = String.Empty
  Public Property Field() As String
    Get
      Return mField
    End Get
    Set(ByVal value As String)
      mField = value
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

  Private mFormat As String = ""
  Public Property Format() As String
    Get
      Return mFormat
    End Get
    Set(ByVal value As String)
      mFormat = value
    End Set
  End Property

  Private mTotalizar As Boolean = False
  Public Property Totalizar() As Boolean
    Get
      Return mTotalizar
    End Get
    Set(ByVal value As Boolean)
      mTotalizar = value
    End Set
  End Property

  Public Enum EnumTipoTotal
    Suma = 0
    Promedio = 1
    Contar = 2
  End Enum

  Private mTipoTotal As EnumTipoTotal = EnumTipoTotal.Suma
  Public Property TipoTotal() As EnumTipoTotal
    Get
      Return mTipoTotal
    End Get
    Set(ByVal value As EnumTipoTotal)
      mTipoTotal = value
    End Set
  End Property

  Private mSuma As Decimal
  Public Property Suma() As Decimal
    Get
      Return mSuma
    End Get
    Set(ByVal value As Decimal)
      mSuma = value
    End Set
  End Property

  Private mConteo As Decimal
  Public Property Conteo() As Decimal
    Get
      Return mConteo
    End Get
    Set(ByVal value As Decimal)
      mConteo = value
    End Set
  End Property

  Public ReadOnly Property Resultado() As Decimal
    Get
      Select Case mTipoTotal
        Case EnumTipoTotal.Suma
          Return mSuma
        Case EnumTipoTotal.Contar
          Return mConteo
        Case EnumTipoTotal.Promedio
          If mConteo = 0 Then
            Return 0
          Else
            Return mSuma / mConteo
          End If
        Case Else
          Return 0
      End Select
    End Get
  End Property
End Class

Public Class ReportColumnCollection
  Inherits List(Of ReportColumn)

  Private mEspacioEntreColumnas As Decimal = 0
  Public Property EspacioEntreColumnas() As Decimal
    Get
      Return mEspacioEntreColumnas
    End Get
    Set(ByVal value As Decimal)
      mEspacioEntreColumnas = value
    End Set
  End Property

  Public Overloads Sub Add(ByVal _titulo As String)
    Dim _col As New ReportColumn
    _col.Titulo = _titulo
    Me.Add(_col)
  End Sub
End Class

Public Enum EnumJustificacion
  Left = 0
  Centered = 1
  Right = 2
End Enum
