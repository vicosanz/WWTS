Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop
Imports WWTS.General.Reglas
Imports Infoware.Datos

Namespace ExcelReporte
  Public Class InvCajaReporte
    Public Shared Sub ExportarExceldetallado(ByVal Fuente As InvCajaCollection)
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
        .Columns().ColumnWidth = 7
        .Range("A1").Value = "Zafra"
        .Columns("A:A").NumberFormat = "@"
        .Range("B1").Value = "Empaque"
        .Range("C1").Value = "Fecha empaque"
        .Columns("C:C").NumberFormat = CurrentCulture.DateTimeFormat.ShortDatePattern     ' "m/d/yyyy"
        .Range("C1").ColumnWidth = 12
        .Range("D1").Value = "Embarque"
        .Range("E1").Value = "Fecha embarque"
        .Range("E1").ColumnWidth = 12
        .Columns("E:E").NumberFormat = CurrentCulture.DateTimeFormat.ShortDatePattern
        .Range("F1").Value = "Tipo"
        .Range("G1").Value = "Clase"
        .Range("G1").ColumnWidth = 10
        .Columns("G:G").NumberFormat = "@"
        .Range("H1").Value = "Color"
        .Range("H1").ColumnWidth = 16
        .Columns("H:H").NumberFormat = "@"
        .Range("I1").Value = "Corte"
        .Range("I1").ColumnWidth = 6
        .Columns("I:I").NumberFormat = "@"
        .Range("J1").Value = "Semilla"
        .Range("K1").Value = "Finca"
        .Range("L1").Value = "Peso"
        .Range("L1").ColumnWidth = 10
        .Columns("L:N").NumberFormat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Range("M1").Value = "Tara"
        .Range("M1").ColumnWidth = 10
        .Range("N1").Value = "Neto"
        .Range("N1").ColumnWidth = 10
        .Range("O1").Value = "Bodega"
        .Range("O1").ColumnWidth = 12
        Dim t As Integer
        For t = 0 To Fuente.Count - 1
          .Range("A" & (t + 2).ToString).Value = Fuente(t).Zafra.Zaf_codigo
          .Range("B" & (t + 2).ToString).Value = Fuente(t).Caj_empNum
          If Not Fuente(t).Caj_Fechaempaque = Nothing Then
            .Range("C" & (t + 2).ToString).Value = Fuente(t).Caj_Fechaempaque.ToShortDateString
          End If
          .Range("D" & (t + 2).ToString).Value = Fuente(t).Caj_embNum
          If Not Fuente(t).Embarque Is Nothing Then
            .Range("E" & (t + 2).ToString).Value = Fuente(t).Embarque.Emb_fecha.ToShortDateString
          End If
          .Range("F" & (t + 2).ToString).Value = Enumerados.TipoTabacoList.RetornarDescripcion(CInt(Fuente(t).Caj_tipoNC))
          .Range("G" & (t + 2).ToString).Value = Fuente(t).ClaseHoja.Cla_nombre
          If Not Fuente(t).ColorHoja Is Nothing Then
            .Range("H" & (t + 2).ToString).Value = Fuente(t).ColorHoja.Col_nombre
          End If
          .Range("I" & (t + 2).ToString).Value = Fuente(t).Corte.Cor_nombre
          .Range("J" & (t + 2).ToString).Value = Fuente(t).Semilla.Sem_nombre
          .Range("K" & (t + 2).ToString).Value = Fuente(t).Terreno.Trr_nombre
          .Range("L" & (t + 2).ToString).Value = Fuente(t).Caj_Peso
          .Range("M" & (t + 2).ToString).Value = Fuente(t).Caj_Tara
          .Range("N" & (t + 2).ToString).Value = Fuente(t).PesoNeto
          .Range("O" & (t + 2).ToString).Value = Fuente(t).Bodega.Bod_nombre
        Next
        excelApp.Visible = True
        .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintPreview()
      End With
    End Sub

    Public Shared Sub ExportarExcelresumido(ByVal Fuente As InvCajaCollection, ByVal _resumen As ResumenInvCajaCollection)
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
        .Range("A1").Value = "#"
        .Range("B1").Value = "Mixta"
        .Range("B1").ColumnWidth = 1
        .Range("C1").Value = "Empaque"
        .Columns("C:C").NumberFormat = "0"
        .Range("D1").Value = "Zafra"
        .Range("E1").Value = "Embarque"
        .Range("F1").Value = "Clase"
        .Range("F1").ColumnWidth = 12
        .Range("G1").Value = "Color"
        .Range("G1").ColumnWidth = 24
        .Range("H1").Value = "Corte"
        .Range("H1").ColumnWidth = 2
        .Range("I1").Value = "Semilla"
        .Range("I1").ColumnWidth = 10
        .Range("J1").Value = "Finca"
        .Range("J1").ColumnWidth = 10
        .Columns("J:J").NumberFormat = "@"
        .Columns("K:O").NumberFormat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Range("K1").Value = "Peso"
        .Range("L1").Value = "Tara"
        .Range("M1").Value = "Neto"
        .Range("N1").Value = "Precio"
        .Range("O1").Value = "Valor_t"
        Dim t As Integer
        For t = 0 To Fuente.Count - 1
          .Range("A" & (t + 2).ToString).Value = t + 1
          .Range("B" & (t + 2).ToString).Value = ""
          .Range("C" & (t + 2).ToString).Value = Fuente(t).Caj_empNum
          .Range("D" & (t + 2).ToString).Value = Fuente(t).Zafra.Zaf_codigo
          .Range("E" & (t + 2).ToString).Value = Fuente(t).Caj_embNum
          If Not Fuente(t).ClaseHoja Is Nothing Then
            .Range("F" & (t + 2).ToString).Value = Fuente(t).ClaseHoja.Cla_nombre
          End If
          If Not Fuente(t).ColorHoja Is Nothing Then
            .Range("G" & (t + 2).ToString).Value = Fuente(t).ColorHoja.Col_nombre
          End If
          .Range("H" & (t + 2).ToString).Value = Fuente(t).Corte.Cor_nombre
          .Range("I" & (t + 2).ToString).Value = Fuente(t).Semilla.Sem_nombre
          .Range("J" & (t + 2).ToString).Value = Fuente(t).Terreno.Trr_nombre
          .Range("K" & (t + 2).ToString).Value = Fuente(t).Caj_Peso
          .Range("L" & (t + 2).ToString).Value = Fuente(t).Caj_Tara
          .Range("M" & (t + 2).ToString).Value = Fuente(t).PesoNeto
          .Range("N" & (t + 2).ToString).Value = Fuente(t).Caj_Precio
        Next

        If Not _resumen Is Nothing Then
          .Range("F" & (t + 3).ToString).Value = "CAJAS"
          Dim _totalcajas As Integer = 0
          Dim _totpesos As Decimal = 0
          Dim _tottaras As Decimal = 0
          For Each _detresumen As ResumenInvCaja In _resumen
            .Range("F" & (t + 4).ToString).Value = _detresumen.NumCajas.ToString
            .Range("G" & (t + 4).ToString).Value = _detresumen.Semilla.Sem_nombre
            .Range("I" & (t + 4).ToString).Value = _detresumen.Terreno.Trr_nombre
            .Range("K" & (t + 4).ToString).Value = _detresumen.Peso.ToString("0.00")
            .Range("L" & (t + 4).ToString).Value = _detresumen.Tara.ToString("0.00")
            .Range("M" & (t + 4).ToString).Value = _detresumen.PesoNeto.ToString("0.00")
            _totalcajas += _detresumen.NumCajas
            _totpesos += _detresumen.Peso
            _tottaras += _detresumen.Tara
            t += 1
          Next
          .Range("F" & (t + 4).ToString).Value = _totalcajas.ToString
          .Range("K" & (t + 4).ToString).Value = _totpesos.ToString("0.00")
          .Range("L" & (t + 4).ToString).Value = _tottaras.ToString("0.00")
          .Range("M" & (t + 4).ToString).Value = (_totpesos - _tottaras).ToString("0.00")
        End If
        excelApp.Visible = True
        .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintPreview()
      End With
    End Sub

    Public Shared Sub CapturarExcel(ByVal _OperadorDatos As OperadorDatos, ByVal archivo As String)
      Dim excelApp As New Excel.Application
      Dim t As Integer = 2
      Try
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Open(archivo)
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)

        Dim colzafra As Integer = 0
        Dim colempaque As Integer = 0
        Dim colembarque As Integer = 0

        excelApp.Visible = False
        With excelWorksheet
          For s As Integer = 1 To 20
            If Not .Cells(1, s).value Is Nothing Then
              Select Case .Cells(1, s).value.ToString.ToUpper.Trim
                Case "ZAFRA"
                  colzafra = s
                Case "EMPAQUE"
                  colempaque = s
                Case "EMBARQUE"
                  colembarque = s
              End Select
            End If
          Next

          If colzafra + colempaque + colembarque = 0 Then
            MsgBox("El archivo importado no contiene las columnas ZAFRA, EMPAQUE y/o EMBARQUE. Rectifíquelo y vuelva a intentarlo")
            excelApp.Quit()
            Exit Sub
          End If

          While Not (.Cells(t, colzafra).value Is Nothing And .Cells(t, colempaque).value Is Nothing)
            Dim _zafra As String = .Cells(t, colzafra).value
            Dim _empaque As Integer = Convert.ToInt16(.Cells(t, colempaque).value)
            If Not .Cells(t, colembarque).value Is Nothing Then
              Dim _embarque As Integer = CInt(.Cells(t, colembarque).value)

              Dim _caja As InvCaja
              _caja = New InvCaja(_OperadorDatos, New ZafraSiembra(_OperadorDatos, _zafra, False), _empaque, False)
              _caja.Caj_embNum = _embarque
              _caja.Guardar()
            End If
            t += 1
          End While
        End With
        excelApp.Visible = True
        excelApp.Quit()
        excelApp.Quit()
      Catch ex As Exception
        MsgBox(ex.Message & vbCrLf & "No se puede continuar. Error en línea " & t, MsgBoxStyle.Critical, "Error")
        excelApp.Quit()
      End Try
    End Sub
  End Class

End Namespace
