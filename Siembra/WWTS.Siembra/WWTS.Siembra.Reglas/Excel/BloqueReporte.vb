Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop

Namespace ExcelReporte
  Public Class BloqueReporte
    Public Shared Sub ExportarExcel(ByVal Fuente As BloqueCollection)
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
        .Range("A1").Value = "Bloque"
        .Range("B1").Value = "Zafra"
        .Columns("C:G").ColumnWidth = 12
        .Range("C1").Value = "Hacienda"
        .Range("D1").Value = "Finca"
        .Range("E1").Value = "Lote"
        .Range("F1").Value = "Corte"
        .Range("G1").Value = "Semilla"
        .Columns("H:I").ColumnWidth = 14
        .Range("H1").Value = "Sano/Roto"
        .Range("I1").Value = "Limpio/Pintado"
        .Columns("J").ColumnWidth = 20
        .Range("J1").Value = "Observación"
        Dim t As Integer
        For t = 0 To Fuente.Count - 1
          .Range("A" & (t + 2).ToString).Value = Fuente(t).Blo_codigo
          .Range("B" & (t + 2).ToString).Value = Fuente(t).Zafra.Zaf_codigo
          .Range("C" & (t + 2).ToString).Value = Fuente(t).Lote.Terreno.Hacienda.Hac_nombre
          .Range("D" & (t + 2).ToString).Value = Fuente(t).Lote.Terreno.Trr_nombre
          .Range("E" & (t + 2).ToString).Value = Fuente(t).Lote.Lot_codigo
          .Range("F" & (t + 2).ToString).Value = Fuente(t).Corte.Cor_nombre
          .Range("G" & (t + 2).ToString).Value = Fuente(t).Semilla.Sem_nombre
          .Range("H" & (t + 2).ToString).Value = IIf(Fuente(t).Blo_essanooroto, "Sano", "Roto")
          .Range("I" & (t + 2).ToString).Value = IIf(Fuente(t).Blo_eslimpioopintado, "Limpio", "Pintado")
          .Range("J" & (t + 2).ToString).Value = Fuente(t).Blo_observacion
        Next
        excelApp.Visible = True
        .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintPreview()
      End With
    End Sub

  End Class
End Namespace

