Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop

Namespace ExcelReporte
  Public Class EmpleadoReporte
    Public Shared Sub ExportarExcel(ByVal Fuente As EmpleadoList, ByVal _vermotivosalida As Boolean)
      If Fuente Is Nothing Then
        Return
      End If
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 21.71
        .Columns().NumberFormat = "@"
        .Rows("1:1").Font.Bold = True
        .Range("A1").Value = "Código"
        .Range("A1").ColumnWidth = 7
        .Range("B1").Value = "Nombres Completos"
        .Range("B1").ColumnWidth = 35
        .Range("C1").Value = "Cédula"
        .Range("C1").ColumnWidth = 11
        .Range("D1").Value = "Sexo"
        .Range("D1").ColumnWidth = 5
        .Range("E1").Value = "Estado Civil"
        .Range("E1").ColumnWidth = 5
        .Range("F1").Value = "Dirección"
        .Range("F1").ColumnWidth = 30
        .Range("G1").Value = "Teléfono"
        .Range("G1").ColumnWidth = 13
        .Range("H1").Value = "Carnet Conadis"
        .Range("H1").ColumnWidth = 13
        .Range("I1").Value = "Discapacidad"
        .Range("I1").ColumnWidth = 12
        .Range("J1").Value = "Tipo sangre"
        .Range("J1").ColumnWidth = 15
        .Range("K1").Value = "Edad"
        .Range("K1").ColumnWidth = 7
        .Range("L1").Value = "Forma Pago"
        .Range("L1").ColumnWidth = 15
        .Range("M1").Value = "Banco"
        .Range("M1").ColumnWidth = 15
        .Range("N1").Value = "Tipo Cta"
        .Range("N1").ColumnWidth = 15
        .Range("O1").Value = "Núm Cta"
        .Range("O1").ColumnWidth = 15
        If _vermotivosalida Then
          .Range("P1").Value = "Motivo salida"
          .Range("P1").ColumnWidth = 30
        End If

        Dim t As Integer
        For t = 0 To Fuente.Count - 1
          .Range("A" & (t + 2).ToString).Value = Fuente(t).CodigoEmpleado
          .Range("B" & (t + 2).ToString).Value = Fuente(t).NombreCompleto
          .Range("B" & (t + 2).ToString).WrapText = True
          .Range("C" & (t + 2).ToString).Value = Fuente(t).Cedula
          .Range("D" & (t + 2).ToString).Value = Fuente(t).SexoString
          .Range("E" & (t + 2).ToString).Value = Fuente(t).EstadoCivilString
          .Range("F" & (t + 2).ToString).Value = Fuente(t).DireccionesString
          .Range("F" & (t + 2).ToString).WrapText = True
          .Range("G" & (t + 2).ToString).Value = Fuente(t).TelefonosString
          .Range("H" & (t + 2).ToString).Value = Fuente(t).CarnetConadis
          .Range("I" & (t + 2).ToString).Value = Fuente(t).Discapacidad
          .Range("J" & (t + 2).ToString).Value = Fuente(t).PardetTipoSangreString
          .Range("K" & (t + 2).ToString).Value = Fuente(t).Edad

          .Range("L" & (t + 2).ToString).Value = Fuente(t).PardetFormaPagoRol.Pardet_Descripcion
          If Fuente(t).Pardet_FormaPagoRolEnum = Enumerados.enumFormaPagoRol.Deposito Then
            .Range("M" & (t + 2).ToString).Value = Fuente(t).PardetBanco.Pardet_Descripcion
            .Range("N" & (t + 2).ToString).Value = Fuente(t).PardetTipoCtaBancaria.Pardet_Descripcion
            .Range("O" & (t + 2).ToString).Value = Fuente(t).Emplea_NumeroCuentaBancaria
          End If
          If _vermotivosalida Then
            If Not Fuente(t).UltimoContrato(Nothing) Is Nothing Then
              .Range("P" & (t + 2).ToString).Value = Fuente(t).UltimoContrato(Nothing).Contra_MotivoSalida
            End If
          End If
        Next
        excelApp.Visible = True
        '.PageSetup.PrintArea = "A1:J" & (UBound(Fuente) + 2).ToString
        '.PageSetup.FitToPagesWide = 1
        .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintPreview()
      End With

    End Sub

    Public Shared Sub Imprimir_etiquetas(ByVal Empleados As EmpleadoList, ByVal formato As String, ByVal cols As Integer, ByVal fils As Integer, ByVal espaciocol As Integer, ByVal espaciofil As Integer)
      If Empleados Is Nothing Then
        MsgBox("No existen Empleados seleccionadas", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If

      Dim WordApp As New Word.Application
      Dim worddocument1 As Word.Document = WordApp.Documents.Add()
      WordApp.Visible = True
      WordApp.MailingLabel.DefaultPrintBarCode = False
      WordApp.MailingLabel.CreateNewDocument(Name:=formato, Address:="", _
       AutoText:="", LaserTray:=0, _
       ExtractAddress:=False, PrintEPostageLabel:=False, Vertical:=False)
      worddocument1.ActiveWindow.Close()

      Dim WordDocument As Word.Document = WordApp.ActiveDocument

      Try
        Dim rango As Word.Range
        WordDocument.Activate()

        Dim i As Integer = 0
        Dim vuelta As Integer = 0
        While i <= Empleados.Count - 1
          Dim f As Integer = 1
          While f <= fils And i <= Empleados.Count - 1
            Dim c As Integer = 1
            While c <= cols And i <= Empleados.Count - 1
              rango = WordDocument.Tables(1).Cell(f + vuelta * fils, c).Range
              rango.Font.Bold = True
              rango.Font.Size = 10
              rango.Text = "(" & Empleados(i).Entida_Codigo & ") " & Empleados(i).NombreCompleto & vbCrLf & _
               Empleados(i).Cedula
              c += 1 + espaciocol
              i += 1
            End While
            f += 1 + espaciofil
          End While
          vuelta += 1
          If i <= Empleados.Count - 1 Then
            Dim x As Integer
            For x = 1 To fils
              WordDocument.Tables(1).Rows.Add()
            Next
          End If
        End While
        'WordDocument.ActiveWindow.Close()

      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub

    Public Shared Sub Imprimir_ListadoPagoPeriodo(ByVal Asistencias As AsistenciaList)
      If Asistencias Is Nothing Then
        MsgBox("No existen Asistencias seleccionadas", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If

      If Asistencias.Count = 0 Then
        MsgBox("Debe Seleccionar una Asistencia", MsgBoxStyle.Information, "Información")
      End If
      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)
        excelApp.Visible = False
        With excelWorksheet
          .Range("A1").Value = "Listado de Sueldos " & Asistencias(0).Periodopago.PardetPeriodoPago.Pardet_Descripcion
          .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          .Range("A1").Font.Bold = True
          .Range("A1:G1").Merge()
          .Range("A2").Value = "Periodo desde " & Asistencias(0).Periodopago.PerPag_FechaDesde.ToShortDateString & " hasta " & Asistencias(0).Periodopago.PerPag_FechaHasta.ToShortDateString
          .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          .Range("A2:G2").Merge()
          .Columns().ColumnWidth = 80
          .Range("A5").Value = "Patrono"
          .Columns("A:A").ColumnWidth = 12
          .Range("B5").Value = "Código"
          .Columns("B:B").ColumnWidth = 8
          .Columns("B:B").NumberFormat = "@"
          .Range("C5").Value = "Cédula"
          .Columns("C:C").ColumnWidth = 13
          .Columns("C:C").NumberFormat = "@"
          .Range("D5").Value = "Nombres y Apellidos"
          .Columns("D:D").ColumnWidth = 35
          .Range("E5").Value = "Asis"
          .Columns("E:E").ColumnWidth = 5
          .Range("F5").Value = "Cheque No."
          .Columns("F:F").ColumnWidth = 8
          .Range("G5").Value = "Valor a Pagar"
          .Columns("G:G").ColumnWidth = 8

          Dim t As Integer
          For t = 0 To Asistencias.Count - 1
            .Range("A" & (6 + t).ToString).Value = Asistencias(t).Contrato.Patrono.NombreCompleto
            .Range("B" & (6 + t).ToString).Value = Asistencias(t).Contrato.Entida_Codigo
            .Range("C" & (6 + t).ToString).Value = Asistencias(t).Contrato.Empleado.Cedula
            .Range("D" & (6 + t).ToString).Value = Asistencias(t).Contrato.Empleado.NombreCompleto
            .Range("E" & (6 + t).ToString).Value = Asistencias(t).Asiste_Dias.ToString("0.00")
            .Range("F" & (6 + t).ToString).Value = 0
            '.Range("G" & (6 + t).ToString).Value = Asistencias(t).Asiste_SueldoPagar.ToString("0.00")
          Next

          With .Range("A5:G5")
            .Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
            .Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone
            With .Borders(Excel.XlBordersIndex.xlEdgeLeft)
              .LineStyle = Excel.XlLineStyle.xlContinuous
              .Weight = Excel.XlBorderWeight.xlThin
              .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With .Borders(Excel.XlBordersIndex.xlEdgeTop)
              .LineStyle = Excel.XlLineStyle.xlContinuous
              .Weight = Excel.XlBorderWeight.xlThin
              .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With .Borders(Excel.XlBordersIndex.xlEdgeBottom)
              .LineStyle = Excel.XlLineStyle.xlContinuous
              .Weight = Excel.XlBorderWeight.xlThin
              .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With .Borders(Excel.XlBordersIndex.xlEdgeRight)
              .LineStyle = Excel.XlLineStyle.xlContinuous
              .Weight = Excel.XlBorderWeight.xlThin
              .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With .Borders(Excel.XlBordersIndex.xlInsideVertical)
              .LineStyle = Excel.XlLineStyle.xlContinuous
              .Weight = Excel.XlBorderWeight.xlThin
              .ColorIndex = Excel.Constants.xlAutomatic
            End With
            'With .Borders(Excel.XlBordersIndex.xlInsideHorizontal)
            '  .LineStyle = Excel.XlLineStyle.xlContinuous
            '  .Weight = Excel.XlBorderWeight.xlThin
            '  .ColorIndex = Excel.Constants.xlAutomatic
            'End With
          End With

          '.Columns("A:A").EntireColumn.AutoFit()
          .Columns("B:B").EntireColumn.AutoFit()
          .Columns("C:C").EntireColumn.AutoFit()
          .Columns("D:D").EntireColumn.AutoFit()
          .Columns("E:E").EntireColumn.AutoFit()
          .Columns("F:F").EntireColumn.AutoFit()
          .Columns("G:G").NumberFormat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
          .Columns("G:G").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
          .Columns("G:G").EntireColumn.AutoFit()
          Dim array(7, 0) As Integer
          array(0, 0) = 0
          array(1, 0) = 1
          array(2, 0) = 2
          array(3, 0) = 3
          array(4, 0) = 4
          array(5, 0) = 5
          array(6, 0) = 6
          array(7, 0) = 7
          .Range("A6").Subtotal(GroupBy:=1, _
           Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=array(7, 0), _
           Replace:=True, PageBreaks:=False, SummaryBelowData:=True)

          '.Range("A6").AutoFormat(Format:=Excel.XlRangeAutoFormat.xlRangeAutoFormatSimple, Number:=True, Font _
          '  :=True, Alignment:=True, Border:=True, Pattern:=True, Width:=True)
        End With
        With excelWorksheet.PageSetup
          .PrintTitleRows = "$1:$5"
          .PrintTitleColumns = ""
          .LeftHeader = ""
          .CenterHeader = "Página &P de &N"
          .RightHeader = ""
          .LeftFooter = "Infoware"
          .CenterFooter = "Página &P"
          .RightFooter = "&D"
        End With
        'Dim gPath As Path
        'Dim gDirApp As String
        'gDirApp = gPath.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location())
        'Dim rutfte As String = gDirApp & "\temp\ftecontratos.xls"
        'Kill(rutfte)

        'excelBook.SaveAs(filename:=rutfte)
        'excelBook.Close()

        excelApp.Visible = True
        excelWorksheet.PrintPreview()
        'excelApp.Quit()
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try


    End Sub
    'Public Shared Sub Imprimir_ListadoBeneficios(ByVal beneficio As BeneficioList, ByVal titulo As String)
    '  If beneficio Is Nothing OrElse beneficio.Count = 0 Then
    '    MsgBox("No existen beneficios seleccionados", MsgBoxStyle.Information, "Información")
    '    Exit Sub
    '  End If

    '  Try
    '    Dim excelApp As New Excel.Application
    '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
    '    Dim excelWorksheet As Excel.Worksheet = _
    '     CType(excelBook.Worksheets(1), Excel.Worksheet)
    '    excelApp.Visible = False
    '    With excelWorksheet
    '      .Range("A1").Value = titulo    '& Enumerados.ConvPeriodoPagoaChar(beneficio(0).Periodo.PerPag_periodopago)
    '      .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '      .Range("A1").Font.Bold = True
    '      .Range("A1:E1").Merge()
    '      '.Range("A2").Value = "Periodo desde " & beneficio(0)..Periodo.PerPag_FechaDesde.ToShortDateString & " hasta " & Asistencias(0).Periodo.PerPag_FechaHasta.ToShortDateString
    '      .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '      .Range("A2:G2").Merge()
    '      .Columns().ColumnWidth = 8
    '      .Range("A5").Value = "Código"
    '      .Columns("A:A").ColumnWidth = 12
    '      .Columns("A:A").NumberFormat = "@"
    '      .Range("B5").Value = "Cédula"
    '      .Columns("B:B").NumberFormat = "@"
    '      .Range("C5").Value = "Nombres y Apellidos"
    '      .Columns("C:C").ColumnWidth = 13
    '      .Range("D5").Value = "Sexo"

    '      .Range("E5").Value = "Días Trabajados"
    '      .Columns("E:E").ColumnWidth = 35
    '      .Range("F5").Value = "Valor Acumulado"
    '      .Range("G5").Value = "Valor a Pagar"
    '      If beneficio(0).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
    '        .Columns("H:H").value = "Días vacaciones"
    '      End If
    '      Dim t As Integer
    '      For t = 0 To beneficio.Count - 1
    '        .Range("A" & (6 + t).ToString).Value = beneficio(t).Entida_Codigo
    '        .Range("B" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.Cedula
    '        .Range("C" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.NombreCompleto
    '        .Range("D" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.SexoString
    '        .Range("E" & (6 + t).ToString).Value = beneficio(t).Benefi_diastrab
    '        .Range("F" & (6 + t).ToString).Value = beneficio(t).BeneficioCalculado.SueldosAcumulados
    '        .Range("G" & (6 + t).ToString).Value = beneficio(t).Benefi_valor
    '        If beneficio(t).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
    '          .Range("H" & (6 + t).ToString).Value = beneficio(t).Benefi_DiasVac
    '        End If
    '      Next

    '      Dim _rango As Excel.Range
    '      _rango = .Range("A5:E5")
    '      If beneficio(0).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
    '        _rango = .Range("A5:F5")
    '      End If
    '      With _rango
    '        .Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
    '        .Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone
    '        With .Borders(Excel.XlBordersIndex.xlEdgeLeft)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlEdgeTop)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlEdgeBottom)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlEdgeRight)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlInsideVertical)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '      End With

    '      .Columns("B:B").EntireColumn.AutoFit()
    '      .Columns("C:C").EntireColumn.AutoFit()
    '      .Columns("D:D").EntireColumn.AutoFit()
    '      '.Columns("E:E").NumberFormat = "0" & CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
    '      .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '      .Columns("E:E").EntireColumn.AutoFit()
    '      .Columns("F:F").EntireColumn.AutoFit()
    '      'Dim array(5, 0) As Integer
    '      'array(0, 0) = 0
    '      'array(1, 0) = 1
    '      'array(2, 0) = 2
    '      'array(4, 0) = 4
    '      'array(5, 0) = 5

    '      '.Range("E6").Subtotal(GroupBy:=1, _
    '      'Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=array(5, 0), _
    '      'Replace:=True, PageBreaks:=False, SummaryBelowData:=True)

    '    End With
    '    With excelWorksheet.PageSetup
    '      .PrintTitleRows = "$1:$5"
    '      .PrintTitleColumns = ""
    '      .LeftHeader = ""
    '      .CenterHeader = "Página &P de &N"
    '      .RightHeader = ""
    '      .LeftFooter = "Infoware"
    '      .CenterFooter = "Página &P"
    '      .RightFooter = "&D"
    '    End With

    '    excelApp.Visible = True
    '    excelWorksheet.PrintPreview()
    '    'excelApp.Quit()
    '  Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '  End Try
    'End Sub
    Public Shared Sub ListarDocumentosFaltantes(ByVal Empleados As EmpleadoList)
      If Empleados Is Nothing Then
        MsgBox("No existen Empleados seleccionadas", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If

      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)

        excelApp.Visible = False
        With excelWorksheet
          .Columns().ColumnWidth = 13
          .Range("A1").Value = "Código"
          .Columns("A:A").NumberFormat = "@"
          .Columns("A:A").ColumnWidth = 8
          .Range("B1").Value = "Cédula"
          .Columns("B:B").NumberFormat = "@"
          .Range("C1").Value = "Nombres Completos"
          .Columns("C:C").NumberFormat = "@"
          .Columns("C:C").ColumnWidth = 25
          .Range("D1").Value = "Edad"
          .Columns("D:D").NumberFormat = "0"
          .Range("E1").Value = "Sexo"
          .Columns("E:E").NumberFormat = "@"
          .Range("F1").Value = "Tipo sangre"
          .Range("G1").Value = "CertifSalud"
          .Range("H1").Value = "Libreta Militar"
          .Columns("H:H").NumberFormat = "@"
          .Range("I1").Value = "Foto"
          .Columns("I:I").ColumnWidth = 8
          .Range("J1").Value = "Estado civil"
          .Range("K1").Value = "Cargas familiares"
          .Columns("K:K").NumberFormat = "0"
          .Range("L1").Value = "Certif. Votación"
          .Range("M1").Value = "Certif. Salud"
          Dim t As Integer = 0
          For Each _Empleado As Empleado In Empleados
            t += 1
            .Range("A" & (t + 1).ToString).Value = _Empleado.Entida_Codigo
            .Range("B" & (t + 1).ToString).Value = _Empleado.Cedula
            .Range("C" & (t + 1).ToString).Value = _Empleado.NombreCompleto
            .Range("D" & (t + 1).ToString).Value = _Empleado.Edad.ToString(0)
            .Range("E" & (t + 1).ToString).Value = _Empleado.SexoString
            .Range("F" & (t + 1).ToString).Value = _Empleado.PardetTipoSangreString
            .Range("G" & (t + 1).ToString).Value = ""
            .Range("H" & (t + 1).ToString).Value = _Empleado.CedulaMilitar
            '.Range("I" & (t + 1).ToString).Value = IIf(_Empleado.ExisteFoto, "Existente", "No existente")
            .Range("J" & (t + 1).ToString).Value = _Empleado.EstadoCivilString
            .Range("K" & (t + 1).ToString).Value = _Empleado.NumeroCargas
            Dim _certvot As String = ""
            If Not _Empleado.ContratoActivo(Nothing) Is Nothing Then
              _certvot = IIf(_Empleado.ContratoActivo(Nothing).Contra_certvot, "Sí", "No")
            End If
            Dim _certsalud As String = ""
            If Not _Empleado.ContratoActivo(Nothing) Is Nothing Then
              _certsalud = IIf(_Empleado.ContratoActivo(Nothing).Contra_certifsalud, "Sí", "No")
            End If
            .Range("L" & (t + 1).ToString).Value = _certvot
            .Range("M" & (t + 1).ToString).Value = _certsalud
          Next
        End With
        excelApp.Visible = True
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub
    'Public Shared Sub TomarAsistencia(ByVal _OperadorDatos As OperadorDatos, ByVal _fecha As Date, ByVal _contratos As ContratoList, ByVal _seccion As WWTSParametroDet)
    '  Try
    '    Dim excelApp As New Excel.Application
    '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
    '    Dim excelWorksheet As Excel.Worksheet = _
    '     CType(excelBook.Worksheets(1), Excel.Worksheet)
    '    excelApp.Visible = False
    '    With excelWorksheet
    '      .Range("A1").Value = "REPORTE PARA TOMA DE ASISTENCIA"
    '      .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '      .Range("A1").Font.Bold = True
    '      .Range("A1:F1").Merge()

    '      .Range("A2").Value = "Día:"
    '      .Range("A3").Value = "Sección:"
    '      .Range("A4").Value = "Jefe sección:"
    '      .Range("A2").Font.Bold = True
    '      .Range("A3").Font.Bold = True
    '      .Range("A4").Font.Bold = True

    '      .Range("B2").Value = Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fecha.DayOfWeek)) & " - " & _fecha.ToLongDateString
    '      .Range("B3").Value = _seccion.Pardet_Descripcion
    '      '.Range("B4").Value = _seccion.Empleado.NombreCompleto

    '      .Columns().ColumnWidth = 80
    '      .Rows().RowHeight = 18
    '      .Range("A6").Value = "Código"
    '      .Columns("A:A").ColumnWidth = 10
    '      .Columns("A:A").numberformat = "@"
    '      .Range("B6").Value = "Nombres y Apellidos"
    '      .Columns("B:B").ColumnWidth = 43
    '      .Range("C6").Value = "Labor"
    '      .Columns("C:C").ColumnWidth = 17
    '      .Range("D6").Value = "Horas"
    '      .Columns("D:D").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '      .Columns("D:D").ColumnWidth = 6
    '      .Range("E6").Value = "Sobret"
    '      .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '      .Columns("E:E").ColumnWidth = 6
    '      .Range("F6").Value = "Observación"
    '      .Columns("F:F").ColumnWidth = 16

    '      Dim t As Integer = 0
    '      For Each _tipocont As TipoContrato In TipoContratoList.ObtenerLista(_OperadorDatos)
    '        Dim primero As Boolean = True
    '        For Each _cont As Contrato In _contratos
    '          If (Not _cont Is Nothing) AndAlso _cont.Tipocontrato.TipCon_Codigo = _tipocont.TipCon_Codigo Then
    '            If primero Then
    '              primero = False
    '              t += 1
    '              .Cells(7 + t, 1).value = _tipocont.TipCon_Descripcion
    '              .Cells(7 + t, 1).font.bold = True
    '              t += 1
    '            End If

    '            .Cells(7 + t, 1).value = _cont.Empleado.Entida_Codigo
    '            .Cells(7 + t, 2).value = _cont.Empleado.NombreCompleto
    '            .Cells(7 + t, 3).value = "_________________"
    '            .Cells(7 + t, 4).value = "______"
    '            .Cells(7 + t, 5).value = "______"
    '            .Cells(7 + t, 6).value = "________________"

    '            'With .Range("C" & (8 + t).ToString & ":F" & (8 + t).ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
    '            '  .LineStyle = Excel.XlLineStyle.xlContinuous
    '            '  .Weight = Excel.XlBorderWeight.xlThin
    '            '  .ColorIndex = Excel.Constants.xlAutomatic
    '            'End With
    '            t += 1
    '          End If
    '        Next
    '      Next

    '      For h As Integer = 1 To 35
    '        .Cells(7 + t, 1).value = "__________"
    '        .Cells(7 + t, 2).value = "___________________________________________"
    '        .Cells(7 + t, 3).value = "_________________"
    '        .Cells(7 + t, 4).value = "______"
    '        .Cells(7 + t, 5).value = "______"
    '        .Cells(7 + t, 6).value = "________________"
    '        t += 1
    '      Next

    '      With .Range("A6:F6")
    '        .Font.Bold = True
    '        .Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
    '        .Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone
    '        With .Borders(Excel.XlBordersIndex.xlEdgeLeft)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlEdgeTop)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlEdgeBottom)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlEdgeRight)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '        With .Borders(Excel.XlBordersIndex.xlInsideVertical)
    '          .LineStyle = Excel.XlLineStyle.xlContinuous
    '          .Weight = Excel.XlBorderWeight.xlThin
    '          .ColorIndex = Excel.Constants.xlAutomatic
    '        End With
    '      End With

    '      '.Columns("B:B").EntireColumn.AutoFit()
    '      '.Columns("C:C").EntireColumn.AutoFit()
    '      '.Columns("D:D").EntireColumn.AutoFit()
    '      '.Columns("E:E").NumberFormat = "0" & CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
    '      '.Columns("E:E").EntireColumn.AutoFit()
    '      'Dim array(5, 0) As Integer
    '      'array(0, 0) = 0
    '      'array(1, 0) = 1
    '      'array(2, 0) = 2
    '      'array(4, 0) = 4
    '      'array(5, 0) = 5

    '      '.Range("E6").Subtotal(GroupBy:=1, _
    '      'Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=array(5, 0), _
    '      'Replace:=True, PageBreaks:=False, SummaryBelowData:=True)

    '    End With
    '    With excelWorksheet.PageSetup
    '      .PrintTitleRows = "$1:$7"
    '      .LeftMargin = 5
    '      .RightMargin = 5
    '      .TopMargin = 20
    '      .BottomMargin = 20
    '      .PrintTitleColumns = ""
    '      .LeftHeader = ""
    '      .CenterHeader = "Página &P de &N"
    '      .RightHeader = ""
    '      .LeftFooter = "Infoware"
    '      .CenterFooter = "Página &P"
    '      .RightFooter = "&D"
    '    End With

    '    excelApp.Visible = True
    '    excelWorksheet.PrintPreview()
    '    'excelApp.Quit()
    '  Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '  End Try
    'End Sub

  End Class

End Namespace