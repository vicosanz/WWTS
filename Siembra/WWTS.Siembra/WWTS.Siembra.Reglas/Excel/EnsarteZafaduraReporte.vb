Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop

Namespace ExcelReporte
  Public Class EnsarteZafaduraReporte
    Public Shared Sub ExportarExcel(ByVal Fuente As EnsarteZafaduraCollection)
      If Fuente Is Nothing OrElse Fuente.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
        Return
      End If
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)

      excelApp.Visible = False
      With excelWorksheet
        .Rows(1).FONT.BOLD = True
        .Columns().ColumnWidth = 5
        .Columns().NumberFormat = "@"
        .Range("A1").Value = "Tarjeta"
        .Range("B1").Value = "Zafra"
        .Range("C1").Value = "Etapa"
        .Columns("C:C").NumberFormat = "0"
        .Range("D1").Value = "Hacienda"
        .Range("E1").Value = "Finca"
        .Range("F1").Value = "Lote"
        .Range("D:F").ColumnWidth = 12
        .Range("G1").Value = "F_Ensarte"
        .Range("G1").ColumnWidth = 12
        .Range("G1").NumberFormat = CurrentCulture.DateTimeFormat.ShortDatePattern
        .Range("H1").Value = "Corte"
        .Range("H1").NumberFormat = "0"
        .Range("I1").Value = "Horno"
        .Range("I1").ColumnWidth = 10
        .Range("J1").Value = "Sección"
        .Range("J1").ColumnWidth = 10
        .Range("K:L").NumberFormat = "0"
        .Range("K1").Value = "Cujes_Natural"
        .Range("L1").Value = "Cujes_Candela"
        .Range("M:N").NumberFormat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Range("M1").Value = "Libras_Natural"
        .Range("N1").Value = "Libras_Candela"
        .Range("O:P").NumberFormat = CurrentCulture.DateTimeFormat.ShortDatePattern
        .Range("O1").Value = "Fecha_Zaf_Natural"
        .Range("P1").Value = "Fecha_Zaf_Candela"
        .Range("Q1").Value = "Tipo_Semilla"
        Dim t As Integer
        For t = 0 To Fuente.Count - 1
          .Range("A" & (t + 2).ToString).Value = Fuente(t).Ens_numero
          .Range("B" & (t + 2).ToString).Value = Fuente(t).Zafra.Zaf_codigo
          '.Range("C" & (t + 2).ToString).Value = Fuente(t).DetEtapa.Etapa.Eta_codigo
          .Range("D" & (t + 2).ToString).Value = Fuente(t).Lote.Terreno.Hacienda.Hac_nombre
          .Range("E" & (t + 2).ToString).Value = Fuente(t).Lote.Terreno.Trr_nombre
          .Range("F" & (t + 2).ToString).Value = Fuente(t).Lote.Lot_codigo
          .Range("G" & (t + 2).ToString).Value = Fuente(t).Ens_fechaensarte
          .Range("H" & (t + 2).ToString).Value = Fuente(t).Corte.Cor_nombre
          .Range("I" & (t + 2).ToString).Value = Fuente(t).SeccionHorno.Horno.Hor_descripcion
          .Range("J" & (t + 2).ToString).Value = Fuente(t).SeccionHorno.Sec_codigo
          .Range("K" & (t + 2).ToString).Value = Fuente(t).Ens_cujesnatural
          .Range("L" & (t + 2).ToString).Value = Fuente(t).Ens_cujescandela
          .Range("M" & (t + 2).ToString).Value = Fuente(t).Ens_libnatural
          .Range("N" & (t + 2).ToString).Value = Fuente(t).Ens_libcandela
          .Range("O" & (t + 2).ToString).Value = Fuente(t).Ens_fechazafnatural
          .Range("P" & (t + 2).ToString).Value = Fuente(t).Ens_fechazafcandela
          .Range("Q" & (t + 2).ToString).Value = Fuente(t).Semilla.Sem_nombre
        Next

        'If Not _resumen Is Nothing Then
        '	.Range("F" & (t + 3).ToString).Value = "CAJAS"
        '	Dim _totalcajas As Integer = 0
        '	Dim _totpesos As Decimal = 0
        '	Dim _tottaras As Decimal = 0
        '	For Each _detresumen As ResumenInvCaja In _resumen
        '		.Range("F" & (t + 4).ToString).Value = _detresumen.NumCajas.ToString
        '		.Range("G" & (t + 4).ToString).Value = _detresumen.Semilla.Sem_nombre
        '		.Range("I" & (t + 4).ToString).Value = _detresumen.Terreno.Trr_nombre
        '		.Range("K" & (t + 4).ToString).Value = _detresumen.Peso.ToString("0.00")
        '		.Range("L" & (t + 4).ToString).Value = _detresumen.Tara.ToString("0.00")
        '		.Range("M" & (t + 4).ToString).Value = _detresumen.PesoNeto.ToString("0.00")
        '		_totalcajas += _detresumen.NumCajas
        '		_totpesos += _detresumen.Peso
        '		_tottaras += _detresumen.Tara
        '		t += 1
        '	Next
        '	.Range("F" & (t + 4).ToString).Value = _totalcajas.ToString
        '	.Range("K" & (t + 4).ToString).Value = _totpesos.ToString("0.00")
        '	.Range("L" & (t + 4).ToString).Value = _tottaras.ToString("0.00")
        '	.Range("M" & (t + 4).ToString).Value = (_totpesos - _tottaras).ToString("0.00")
        'End If
        excelApp.Visible = True
        .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintPreview()
      End With
    End Sub

  End Class
End Namespace