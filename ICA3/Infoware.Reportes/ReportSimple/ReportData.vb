Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

<Serializable()> _
Public Class ReportData
#Region "Data"
  Private mHeader As Type
  <XmlIgnore()> _
  Public Property Header() As Type
    Get
      Return mHeader
    End Get
    Set(ByVal value As Type)
      mHeader = value
    End Set
  End Property

  Private mHeaderData As Object = Nothing
  <XmlIgnore()> _
  Public Property HeaderData() As Object
    Get
      Return mHeaderData
    End Get
    Set(ByVal value As Object)
      mHeaderData = value
      If value IsNot Nothing Then
        mHeader = value.GetType
      End If
    End Set
  End Property

  Private mDetails As Type
  <XmlIgnore()> _
  Public Property Details() As Type
    Get
      Return mDetails
    End Get
    Set(ByVal value As Type)
      mDetails = value
    End Set
  End Property

  Private mDetailsData As IList = Nothing
  <XmlIgnore()> _
  Public Property DetailsData() As Object
    Get
      Return mDetailsData
    End Get
    Set(ByVal value As Object)
      mDetailsData = value
      If value Is Nothing OrElse CType(value, IList).Count = 0 Then
        mDetails = Nothing
      Else
        mDetails = CType(value, IList).Item(0).GetType
      End If
    End Set
  End Property
#End Region

#Region "Sections"
  Public Function ReportSection(ByVal _enumUbicacion As enumUbicacion) As ReportSection
    Select Case _enumUbicacion
      Case enumUbicacion.BandaTitulo
        Return ReportSectionBandaTitulo
      Case enumUbicacion.Encabezado
        Return ReportSectionEncabezado
      Case enumUbicacion.Detalles
        Return ReportSectionDetalles
      Case enumUbicacion.PiePagina
        Return ReportSectionPiePagina
      Case enumUbicacion.BandaResumen
        Return ReportSectionBandaResumen
      Case Else
        Return Nothing
    End Select
  End Function

  Private mReportSectionBandaTitulo As New ReportSection
  Public Property ReportSectionBandaTitulo() As ReportSection
    Get
      Return mReportSectionBandaTitulo
    End Get
    Set(ByVal value As ReportSection)
      mReportSectionBandaTitulo = value
    End Set
  End Property

  Private mReportSectionEncabezado As New ReportSection
  Public Property ReportSectionEncabezado() As ReportSection
    Get
      Return mReportSectionEncabezado
    End Get
    Set(ByVal value As ReportSection)
      mReportSectionEncabezado = value
    End Set
  End Property

  Private mReportSectionDetalles As New ReportSection
  Public Property ReportSectionDetalles() As ReportSection
    Get
      Return mReportSectionDetalles
    End Get
    Set(ByVal value As ReportSection)
      mReportSectionDetalles = value
    End Set
  End Property

  Private mReportSectionPiePagina As New ReportSection
  Public Property ReportSectionPiePagina() As ReportSection
    Get
      Return mReportSectionPiePagina
    End Get
    Set(ByVal value As ReportSection)
      mReportSectionPiePagina = value
    End Set
  End Property

  Private mReportSectionBandaResumen As New ReportSection
  Public Property ReportSectionBandaResumen() As ReportSection
    Get
      Return mReportSectionBandaResumen
    End Get
    Set(ByVal value As ReportSection)
      mReportSectionBandaResumen = value
    End Set
  End Property
#End Region

#Region "Mostrar"
  Private mMostrarBandaTitulo As Boolean = False
  Public Property MostrarBandaTitulo() As Boolean
    Get
      Return mMostrarBandaTitulo
    End Get
    Set(ByVal value As Boolean)
      mMostrarBandaTitulo = value
    End Set
  End Property

  Private mMostrarBandaResumen As Boolean = False
  Public Property MostrarBandaResumen() As Boolean
    Get
      Return mMostrarBandaResumen
    End Get
    Set(ByVal value As Boolean)
      mMostrarBandaResumen = value
    End Set
  End Property
#End Region

#Region "Impresora"
  Private mImpresora As String = String.Empty
  Public Property Impresora() As String
    Get
      Return mImpresora
    End Get
    Set(ByVal value As String)
      mImpresora = value
    End Set
  End Property

  Private mPapel As String = String.Empty
  Public Property Papel() As String
    Get
      Return mPapel
    End Get
    Set(ByVal value As String)
      mPapel = value
    End Set
  End Property
#End Region

  Public Shared Sub SerializeList(ByVal _ReportData As ReportData, ByVal filename As String)
    Dim x As XmlSerializer = New XmlSerializer(GetType(ReportData))
    Dim writer As TextWriter = New StreamWriter(filename)
    x.Serialize(writer, _ReportData)
    writer.Close()
  End Sub

  Public Shared Function DeSerializeList(ByVal filename As String) As ReportData
    Dim oResult As New ReportData
    Try
      Dim myFileStream As FileStream = New FileStream(filename, FileMode.Open)
      Dim reader As New XmlTextReader(myFileStream)
      Dim serializer As New XmlSerializer(GetType(ReportData))
      If serializer.CanDeserialize(reader) Then
        oResult = serializer.Deserialize(reader)
      End If
      myFileStream.Close()
    Catch ex As Exception
    End Try
    Return oResult
  End Function
End Class

Public Enum enumUbicacion
  BandaTitulo
  Encabezado
  Detalles
  PiePagina
  BandaResumen
End Enum

<Serializable()> _
Public Class ReportSection
  Private mReportFields As ReportFieldList = New ReportFieldList
  Public Property ReportFields() As ReportFieldList
    Get
      Return mReportFields
    End Get
    Set(ByVal value As ReportFieldList)
      mReportFields = value
    End Set
  End Property

  Private mAltoBanda As Integer = 100
  Public Property AltoBanda() As Integer
    Get
      Return mAltoBanda
    End Get
    Set(ByVal value As Integer)
      mAltoBanda = value
    End Set
  End Property
End Class
