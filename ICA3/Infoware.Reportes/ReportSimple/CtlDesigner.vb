Public Class CtlDesigner
  Public Event CambioDatosEvent As EventHandler

  Private mCambioDatos As Boolean = False
  Public Property CambioDatos() As Boolean
    Get
      Return mCambioDatos
    End Get
    Set(ByVal value As Boolean)
      mCambioDatos = value
    End Set
  End Property

#Region "Data"
  Private mArchivoReporte As String = String.Empty
  Public Property ArchivoReporte() As String
    Get
      Return mArchivoReporte
    End Get
    Set(ByVal value As String)
      If Not String.IsNullOrEmpty(value) Then
        mArchivoReporte = value
        ReportData = New ReportData
        ReportData = Reportes.ReportData.DeSerializeList(value)
        Me.lblnombrearchivo.Text = value
      End If
    End Set
  End Property

  Private mReportData As ReportData = Nothing
  Public Property ReportData() As ReportData
    Get
      Return mReportData
    End Get
    Set(ByVal value As ReportData)
      If value IsNot Nothing Then
        mReportData = value
        mReportData.HeaderData = mCabecera
        mReportData.DetailsData = mDetalles
        Actualizar()
      End If
    End Set
  End Property

  Private mCabecera As Object
  Public Property Cabecera() As Object
    Get
      Return mCabecera
    End Get
    Set(ByVal value As Object)
      If value IsNot Nothing Then
        mCabecera = value
        mReportData.HeaderData = value
        Actualizar()
      End If
    End Set
  End Property

  Private mDetalles As Object
  Public Property Detalles() As IList
    Get
      Return mDetalles
    End Get
    Set(ByVal value As IList)
      If value IsNot Nothing Then
        mDetalles = value
        mReportData.DetailsData = value
        Actualizar()
      End If
    End Set
  End Property

  Private Sub Actualizar()
    Me.CtlSeccionBandaTitulo.ReportData = mReportData
    Me.CtlSeccionBandaTitulo.Ubicacion = enumUbicacion.BandaTitulo

    Me.CtlSeccionEncabezado.ReportData = mReportData
    Me.CtlSeccionEncabezado.Ubicacion = enumUbicacion.Encabezado

    Me.CtlSeccionDetalles.ReportData = mReportData
    Me.CtlSeccionDetalles.Ubicacion = enumUbicacion.Detalles

    Me.CtlSeccionPiePagina.ReportData = mReportData
    Me.CtlSeccionPiePagina.Ubicacion = enumUbicacion.PiePagina

    Me.CtlSeccionBandaResumen.ReportData = mReportData
    Me.CtlSeccionBandaResumen.Ubicacion = enumUbicacion.BandaResumen

    Me.TableLayoutPanel1.RowStyles(1).Height = mReportData.ReportSectionBandaTitulo.AltoBanda
    Me.TableLayoutPanel1.RowStyles(2).Height = mReportData.ReportSectionEncabezado.AltoBanda
    Me.TableLayoutPanel1.RowStyles(3).Height = mReportData.ReportSectionDetalles.AltoBanda
    Me.TableLayoutPanel1.RowStyles(4).Height = mReportData.ReportSectionPiePagina.AltoBanda
    Me.TableLayoutPanel1.RowStyles(5).Height = mReportData.ReportSectionBandaResumen.AltoBanda

    Me.chk_mostrarbarratitulo.Checked = mReportData.MostrarBandaTitulo
    Me.chkmostrarbarraresumen.Checked = mReportData.MostrarBandaResumen
    ActualizardatosImpresora()
  End Sub

  Private Sub ActualizardatosImpresora()
    If mReportData.Impresora = String.Empty OrElse mReportData.Papel Is Nothing Then
      Me.cboimpresoras.SelectedIndex = -1
    Else
      Me.cboimpresoras.SelectedItem = mReportData.Impresora

      Me.cbopapel.SelectedItem = mReportData.Papel
    End If
  End Sub

  Private Sub cboimpresoras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboimpresoras.SelectedIndexChanged
    If Me.cboimpresoras.SelectedIndex = -1 Then
      Exit Sub
    End If
    Me.PageSetupDialog1.PrinterSettings.PrinterName = Me.cboimpresoras.Items(Me.cboimpresoras.SelectedIndex)
    mReportData.Impresora = Me.cboimpresoras.Items(Me.cboimpresoras.SelectedIndex)

    Me.cbopapel.Items.Clear()
    For Each _papel As System.Drawing.Printing.PaperSize In Me.PageSetupDialog1.PrinterSettings.PaperSizes
      Me.cbopapel.Items.Add(_papel.PaperName)
    Next


    onCambioDatos()
  End Sub

  Private Sub cbopapel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopapel.SelectedIndexChanged
    If Me.cbopapel.SelectedIndex = -1 Then
      Exit Sub
    End If

    For Each _size As System.Drawing.Printing.PaperSize In Me.PageSetupDialog1.PrinterSettings.PaperSizes
      If _size.PaperName.Trim.ToUpper = Me.cbopapel.Items(Me.cbopapel.SelectedIndex).Trim.ToUpper Then
        Me.PageSetupDialog1.PageSettings.PaperSize = _size
        Me.TableLayoutPanel1.ColumnStyles(0).Width = _size.Width
        mReportData.Papel = _size.PaperName
      End If
    Next
    onCambioDatos()
  End Sub
#End Region

#Region "Cambios"
  Private Sub btnaddbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddbt.Click
    Me.TableLayoutPanel1.RowStyles(1).Height += 1
    mReportData.ReportSectionBandaTitulo.AltoBanda = Me.TableLayoutPanel1.RowStyles(1).Height
    onCambioDatos()
  End Sub

  Private Sub btndelbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelbt.Click
    Me.TableLayoutPanel1.RowStyles(1).Height -= 1
    mReportData.ReportSectionBandaTitulo.AltoBanda = Me.TableLayoutPanel1.RowStyles(1).Height
    onCambioDatos()
  End Sub

  Private Sub btnaddenc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddenc.Click
    Me.TableLayoutPanel1.RowStyles(2).Height += 1
    mReportData.ReportSectionEncabezado.AltoBanda = Me.TableLayoutPanel1.RowStyles(2).Height
    onCambioDatos()
  End Sub

  Private Sub btndelenc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelenc.Click
    Me.TableLayoutPanel1.RowStyles(2).Height -= 1
    mReportData.ReportSectionEncabezado.AltoBanda = Me.TableLayoutPanel1.RowStyles(2).Height
    onCambioDatos()
  End Sub

  Private Sub btnadddet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadddet.Click
    Me.TableLayoutPanel1.RowStyles(3).Height += 1
    mReportData.ReportSectionDetalles.AltoBanda = Me.TableLayoutPanel1.RowStyles(3).Height
    onCambioDatos()
  End Sub

  Private Sub btndeldet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeldet.Click
    Me.TableLayoutPanel1.RowStyles(3).Height -= 1
    mReportData.ReportSectionDetalles.AltoBanda = Me.TableLayoutPanel1.RowStyles(3).Height
    onCambioDatos()
  End Sub

  Private Sub btnaddppag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddppag.Click
    Me.TableLayoutPanel1.RowStyles(4).Height += 1
    mReportData.ReportSectionPiePagina.AltoBanda = Me.TableLayoutPanel1.RowStyles(4).Height
    onCambioDatos()
  End Sub

  Private Sub btndelppag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelppag.Click
    Me.TableLayoutPanel1.RowStyles(4).Height -= 1
    mReportData.ReportSectionPiePagina.AltoBanda = Me.TableLayoutPanel1.RowStyles(4).Height
    onCambioDatos()
  End Sub

  Private Sub btnaddbr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddbr.Click
    Me.TableLayoutPanel1.RowStyles(5).Height += 1
    mReportData.ReportSectionBandaResumen.AltoBanda = Me.TableLayoutPanel1.RowStyles(5).Height
    onCambioDatos()
  End Sub

  Private Sub btndelbr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelbr.Click
    Me.TableLayoutPanel1.RowStyles(5).Height -= 1
    mReportData.ReportSectionBandaResumen.AltoBanda = Me.TableLayoutPanel1.RowStyles(5).Height
    onCambioDatos()
  End Sub

  Private Sub chk_mostrarbarratitulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrarbarratitulo.CheckedChanged
    Me.CtlSeccionBandaTitulo.Enabled = Me.chk_mostrarbarratitulo.Checked
    mReportData.MostrarBandaTitulo = Me.chk_mostrarbarratitulo.Checked
    onCambioDatos()
  End Sub

  Private Sub chkmostrarresumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmostrarbarraresumen.CheckedChanged
    Me.CtlSeccionBandaResumen.Enabled = Me.chkmostrarbarraresumen.Checked
    mReportData.MostrarBandaResumen = Me.chkmostrarbarraresumen.Checked
    onCambioDatos()
  End Sub

  'Private Sub btnimpresora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.PageSetupDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
  '    mReportData.Papel = Me.PageSetupDialog1.PageSettings.PaperSize.PaperName

  '    mReportData.Impresora = Me.PageSetupDialog1.PrinterSettings.PrinterName
  '    ActualizardatosImpresora()
  '  End If
  'End Sub
#End Region

#Region "Abrir/Guardar/Imprimir"
  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    guardar_cambios()
  End Sub

  Public Function Guardar_Cambios() As Boolean
    SaveFileDialog1.Filter = "Reporte Simple (*.rps)|*.rps|Todos los archivos (*.*)|*.*"
    SaveFileDialog1.FilterIndex = 1
    SaveFileDialog1.RestoreDirectory = True
    SaveFileDialog1.FileName = ArchivoReporte

    Try
      If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        Reportes.ReportData.SerializeList(mReportData, Me.SaveFileDialog1.FileName)
        mCambioDatos = False
        Return True
      End If
    Catch ex As Exception
    End Try
    Return False
  End Function

  Private Sub btnabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrir.Click
    OpenFileDialog1.Filter = "Reporte Simple (*.rps)|*.rps|Todos los archivos (*.*)|*.*"
    OpenFileDialog1.FilterIndex = 1
    OpenFileDialog1.RestoreDirectory = True

    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
      ArchivoReporte = Me.OpenFileDialog1.FileName
    End If
  End Sub

  Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
    vistaprevia()
  End Sub

  Public Sub VistaPrevia()
    Dim report As New ReportSimple
    report.ReportData = mReportData
    report.VistaPrevia()
  End Sub

  Public Sub Imprimir()
    Dim report As New ReportSimple
    report.ReportData = mReportData
    report.imprimir()
  End Sub
#End Region

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.cboimpresoras.Items.Clear()
    For Each _impresora As String In Drawing.Printing.PrinterSettings.InstalledPrinters
      Me.cboimpresoras.Items.Add(_impresora)
    Next
  End Sub

  Private Sub CtlSeccionBandaTitulo_CambioDatosEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlSeccionBandaTitulo.CambioDatosEvent, CtlSeccionEncabezado.CambioDatosEvent, CtlSeccionDetalles.CambioDatosEvent, CtlSeccionPiePagina.CambioDatosEvent, CtlSeccionBandaResumen.CambioDatosEvent
    onCambioDatos()
  End Sub

  Public Sub onCambioDatos()
    mCambioDatos = True
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub
End Class
