Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class ReportSimple
  Inherits ReportDocument

  Private mReportData As ReportData = Nothing
  Public Property ReportData() As ReportData
    Get
      Return mReportData
    End Get
    Set(ByVal value As ReportData)
      mReportData = value
      FormatearHoja()
    End Set
  End Property

  Private Sub ReportSimple_ReportBegin(ByVal sender As Object, ByVal e As ReportPageEventArgs) Handles Me.ReportBegin
    mRow = 0
  End Sub

  Public Overrides Sub ImprimirBandaTitulo(ByVal e As ReportPageEventArgs)
    If mReportData.MostrarBandaTitulo Then
      With e
        .CurrentY += mReportData.ReportSectionBandaTitulo.AltoBanda
      End With
    End If
  End Sub

  Public Overrides Sub ImprimirEncabezado(ByVal e As ReportPageEventArgs)
    With e
      For Each _field As ReportField In mReportData.ReportSectionEncabezado.ReportFields
        If _field.Campo = String.Empty Then
          .WriteField(_field.Etiqueta, _field)
        Else
          .WriteField(MyBase.GetField(mReportData.HeaderData, _field.Campo), _field)
        End If
      Next
      .CurrentY += mReportData.ReportSectionEncabezado.AltoBanda
    End With
  End Sub

  Private mRow As Integer = 0
  Public Overrides Sub ImprimirDetalle(ByVal e As ReportPageEventArgs)
    If mReportData.DetailsData Is Nothing Then
      e.HasMorePages = False
      Exit Sub
    End If
    Dim _lista As IList = CType(mReportData.DetailsData, IList)
    With e
      While Not FindePagina(e) AndAlso mRow < _lista.Count
        For Each _field As ReportField In mReportData.ReportSectionDetalles.ReportFields
          If _field.Campo = String.Empty Then
            .WriteField(_field.Etiqueta, _field)
          Else
            .WriteField(MyBase.GetField(_lista(mRow), _field.Campo), _field)
          End If
        Next
        .CurrentY += mReportData.ReportSectionDetalles.AltoBanda
        mRow += 1
      End While

      e.HasMorePages = mRow < _lista.Count
    End With
  End Sub

  Public Overrides Sub ImprimirPiedePagina(ByVal e As ReportPageEventArgs)
    With e
      .CurrentY = .PageBounds.Bottom - mReportData.ReportSectionPiePagina.AltoBanda
      For Each _field As ReportField In mReportData.ReportSectionPiePagina.ReportFields
        If _field.Campo = String.Empty Then
          .WriteField(_field.Etiqueta, _field)
        Else
          .WriteField(MyBase.GetField(mReportData.HeaderData, _field.Campo), _field)
        End If
      Next
      .CurrentY += mReportData.ReportSectionPiePagina.AltoBanda
    End With
  End Sub

  Public Overrides Sub ImprimirBandaResumen(ByVal e As ReportPageEventArgs)
    If mReportData.MostrarBandaResumen Then
      With e
        For Each _field As ReportField In mReportData.ReportSectionBandaResumen.ReportFields
          If _field.Campo = String.Empty Then
            .WriteField(_field.Etiqueta, _field)
          Else
            .WriteField(MyBase.GetField(mReportData.HeaderData, _field.Campo), _field)
          End If
        Next
        .CurrentY += mReportData.ReportSectionBandaResumen.AltoBanda
      End With
    End If
  End Sub

  Private Function FindePagina(ByVal e As ReportPageEventArgs) As Boolean
    Return e.CurrentY > e.PageBounds.Bottom - mReportData.ReportSectionPiePagina.AltoBanda - mReportData.ReportSectionDetalles.AltoBanda
  End Function

  Public Overrides Function PuedeImprimirResumen(ByVal e As ReportPageEventArgs) As Boolean
    Return e.CurrentY + mReportData.ReportSectionBandaResumen.AltoBanda < e.PageBounds.Bottom - mReportData.ReportSectionPiePagina.AltoBanda
  End Function

  Private Sub ReportSimple_PrintPageBegin(ByVal sender As Object, ByVal e As ReportPageEventArgs) Handles Me.PrintPageBegin
    e.CurrentX = 0
    e.CurrentY = 0
  End Sub

  Private Sub FormatearHoja()
    If Not mReportData.Impresora = String.Empty Then
      PrinterSettings.PrinterName = mReportData.Impresora
      For Each _size As System.Drawing.Printing.PaperSize In PrinterSettings.PaperSizes
        If _size.PaperName.Trim.ToUpper = mReportData.Papel.Trim.ToUpper Then
          DefaultPageSettings.PaperSize = _size
        End If
      Next
    End If
    Me.TieneBandaTitulo = mReportData.MostrarBandaTitulo
    Me.TieneBandaResumen = mReportData.MostrarBandaResumen
  End Sub

  Public Sub VistaPrevia()
    Dim PrintPreviewDialog1 As New PrintPreviewDialog
    PrintPreviewDialog1.Text = "Vista preliminar"
    PrintPreviewDialog1.WindowState = FormWindowState.Maximized
    PrintPreviewDialog1.Document = Me
    PrintPreviewDialog1.ShowDialog()
  End Sub

  Public Sub Imprimir()
    Me.Print()
  End Sub
End Class
