Imports WWTS.General.Reglas
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop


Namespace ExcelReporte
  Public Class BeneficioReporte
    Public Shared Sub Imprimir_ListadoBeneficios(ByVal beneficio As BeneficiosSocialesList, ByVal _tipobenef As WWTSParametroDet)
      If beneficio Is Nothing OrElse beneficio.Count = 0 Then
        MsgBox("No existen beneficios seleccionados", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If

      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)
        excelApp.Visible = False
        With excelWorksheet
          .Range("A1").Value = "Listado de " & _tipobenef.Pardet_Descripcion
          .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          .Range("A1").Font.Bold = True
          .Range("A1:E1").Merge()
          '.Range("A2").Value = "Periodo desde " & beneficio(0)..Periodo.PerPag_FechaDesde.ToShortDateString & " hasta " & Asistencias(0).Periodo.PerPag_FechaHasta.ToShortDateString
          .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          .Range("A2:G2").Merge()
          .Columns().ColumnWidth = 8
          .Range("A5").Value = "Código"
          .Columns("A:A").ColumnWidth = 12
          .Columns("A:A").NumberFormat = "@"
          .Range("B5").Value = "Cédula"
          .Columns("B:B").NumberFormat = "@"
          .Range("C5").Value = "Nombres y Apellidos"
          .Columns("C:C").ColumnWidth = 13
          .Range("D5").Value = "Sexo"

          .Columns("E:H").NumberFormat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"

          .Range("E5").Value = "Días Trabajados"
          .Columns("E:E").ColumnWidth = 35
          .Range("F5").Value = "Valor Acumulado"
          .Range("G5").Value = "Valor a Pagar"
          If _tipobenef.Pardet_Secuencia = CInt(Enumerados.enumTipoBeneficio.Vacaciones) Then
            .Range("H5").Value = "Días vacaciones"
          End If
          If _tipobenef.Pardet_Secuencia = CInt(Enumerados.enumTipoBeneficio.Utilidades) Then
            .Range("G5").Value = "Valor Utilidad"
            .Range("H5").Value = "Cargas"
            .Range("I5").Value = "Valor Cargas"
            .Range("J5").Value = "Valor Bono"
            .Range("K5").Value = "Valor Bono Cargas"
          End If

          Dim t As Integer
          For t = 0 To beneficio.Count - 1
            .Range("A" & (6 + t).ToString).Value = beneficio(t).Entida_Codigo
            .Range("B" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.Cedula
            .Range("C" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.NombreCompleto
            .Range("D" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.SexoString
            .Range("E" & (6 + t).ToString).Value = beneficio(t).BenSoc_Dias
            .Range("F" & (6 + t).ToString).Value = beneficio(t).BenSoc_ValorBono
            .Range("G" & (6 + t).ToString).Value = beneficio(t).BenSoc_Valor
            If beneficio(t).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
              .Range("H" & (6 + t).ToString).Value = beneficio(t).BenSoc_Dias
            End If
            If beneficio(t).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Utilidades Then
              .Range("H" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.NumeroCargas
              .Range("I" & (6 + t).ToString).Value = beneficio(t).BenSoc_ValorCargas
              .Range("J" & (6 + t).ToString).Value = beneficio(t).BenSoc_ValorBono
              .Range("K" & (6 + t).ToString).Value = beneficio(t).BenSoc_ValorBonoCargas
            End If
          Next

          Dim _rango As Excel.Range
          _rango = .Range("A5:E5")
          If beneficio(0).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
            _rango = .Range("A5:F5")
          End If
          With _rango
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
          End With

          .Columns("B:B").EntireColumn.AutoFit()
          .Columns("C:C").EntireColumn.AutoFit()
          .Columns("D:D").EntireColumn.AutoFit()
          '.Columns("E:E").NumberFormat = "0" & CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
          .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
          .Columns("E:E").EntireColumn.AutoFit()
          .Columns("F:F").EntireColumn.AutoFit()
          'Dim array(5, 0) As Integer
          'array(0, 0) = 0
          'array(1, 0) = 1
          'array(2, 0) = 2
          'array(4, 0) = 4
          'array(5, 0) = 5

          '.Range("E6").Subtotal(GroupBy:=1, _
          'Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=array(5, 0), _
          'Replace:=True, PageBreaks:=False, SummaryBelowData:=True)

        End With
        'With excelWorksheet.PageSetup
        '  .PrintTitleRows = "$1:$5"
        '  .PrintTitleColumns = ""
        '  '.LeftHeader = ""
        '  '.CenterHeader = "Página &P de &N"
        '  '.RightHeader = ""
        '  '.LeftFooter = "Infoware"
        '  '.CenterFooter = "Página &P"
        '  '.RightFooter = "&D"
        'End With

        excelApp.Visible = True
        'excelWorksheet.PrintPreview()
        'excelApp.Quit()
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub

    'Public Shared Sub Imprimir_ReciboUtilidadBono(ByVal beneficio As BeneficioList, ByVal _tipobenef As Enumerados.enumTipoBeneficio)
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
    '      .Columns().ColumnWidth = 8
    '      .Range("A5").Value = "Código"
    '      .Columns("A:A").ColumnWidth = 12
    '      .Columns("A:A").NumberFormat = "@"
    '      .Range("B5").Value = "Cédula"
    '      .Columns("B:B").NumberFormat = "@"
    '      .Range("C5").Value = "Nombres y Apellidos"
    '      .Columns("C:C").ColumnWidth = 13
    '      .Range("D5").Value = "Responsable"
    '      .Columns("E:E").NumberFormat = "@"
    '      .Range("E5").Value = "Valor"

    '      Dim t As Integer
    '      For t = 0 To beneficio.Count - 1
    '        .Range("A" & (6 + t).ToString).Value = beneficio(t).Entida_Codigo
    '        .Range("B" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.Cedula
    '        .Range("C" & (6 + t).ToString).Value = beneficio(t).Contrato.Empleado.NombreCompleto
    '        .Range("D" & (6 + t).ToString).Value = beneficio(t).Contrato.Patrono.NombreCompleto
    '        If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
    '          .Range("E" & (6 + t).ToString).Value = Decimal.Round(beneficio(t).Benefi_ValorBono + beneficio(t).Benefi_ValorBonoCargas, 2).ToString("0.00")
    '        Else
    '          .Range("E" & (6 + t).ToString).Value = Decimal.Round(beneficio(t).Benefi_Valor, 2).ToString("0.00")
    '        End If
    '      Next

    '      .Columns("B:B").EntireColumn.AutoFit()
    '      .Columns("C:C").EntireColumn.AutoFit()
    '      .Columns("D:D").EntireColumn.AutoFit()
    '      .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '      .Columns("E:E").EntireColumn.AutoFit()
    '      .Columns("F:F").EntireColumn.AutoFit()
    '    End With
    '    Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\fterecibenef.xls"
    '    Try
    '      Kill(rutfte)
    '    Catch ex As Exception
    '    End Try

    '    excelBook.SaveAs(Filename:=rutfte)
    '    excelBook.Close()
    '    excelApp.Visible = True
    '    excelApp.Quit()

    '    Dim rutobj As String
    '    If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
    '      rutobj = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\formatos\Formato cancelacion Bonos.doc"
    '    Else
    '      rutobj = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\formatos\formato cancelacion de vaciones.doc"
    '    End If


    '    Dim WordApp As New Word.Application
    '    Dim WordDocument As Word.Document = WordApp.Documents.Open(rutobj)


    '    'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
    '    WordApp.Visible = True
    '    WordDocument.Activate()
    '    With WordDocument.MailMerge
    '      .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `Hoja1$`")
    '      .ViewMailMergeFieldCodes = False
    '      .Destination = 0     'nuevo documento
    '      .SuppressBlankLines = True
    '      With .DataSource
    '        .FirstRecord = 1
    '        .LastRecord = -16
    '      End With
    '      .Execute(Pause:=False)
    '    End With
    '    WordDocument.ActiveWindow.Close()
    '    'WordApp.ActiveWindow.Close()
    '    '    Connection:="Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" & rutfte & ";Mode=Read;Extended Properties=""HDR=YES;IMEX=1;"";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine T", SQLStatement:="SELECT * FROM `Hoja1$`", SQLStatement1:="", SubType:=1)

    '    'WordDocument()
    '  Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '  End Try
    'End Sub

    'Public Shared Sub Imprimir_ReciboVacaciones(ByVal beneficio As BeneficioList, ByVal _tipobenef As Enumerados.enumTipoBeneficio)
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
    '      .Columns().ColumnWidth = 8
    '      .Range("A1").Value = "Código"
    '      .Columns("A:A").ColumnWidth = 12
    '      .Columns("A:A").NumberFormat = "@"
    '      .Range("B1").Value = "Cédula"
    '      .Columns("B:B").NumberFormat = "@"
    '      .Range("C1").Value = "Nombres y Apellidos"
    '      .Columns("C:C").ColumnWidth = 13
    '      .Range("D1").Value = "Responsable"
    '      .Columns("E:E").NumberFormat = "@"
    '      .Range("E1").Value = "Valor"
    '      .Range("F1").Value = "Desde"
    '      .Range("G1").Value = "Hasta"
    '      .Columns("H:H").NumberFormat = "@"
    '      .Range("H1").Value = "Dias Vacaciones"
    '      Dim t As Integer
    '      For t = 0 To beneficio.Count - 1
    '        .Range("A" & (2 + t).ToString).Value = beneficio(t).Entida_Codigo
    '        .Range("B" & (2 + t).ToString).Value = beneficio(t).Contrato.Empleado.Cedula
    '        .Range("C" & (2 + t).ToString).Value = beneficio(t).Contrato.Empleado.NombreCompleto
    '        .Range("D" & (2 + t).ToString).Value = beneficio(t).Contrato.Patrono.NombreCompleto
    '        .Range("E" & (2 + t).ToString).Value = Decimal.Round(beneficio(t).Benefi_Valor, 2).ToString("0.00")
    '        .Range("F" & (2 + t).ToString).Value = beneficio(t).Benefi_FechaDesde
    '        .Range("G" & (2 + t).ToString).Value = beneficio(t).Benefi_FechaHasta
    '        .Range("H" & (2 + t).ToString).Value = beneficio(t).Benefi_DiasVac
    '      Next

    '      .Columns("B:B").EntireColumn.AutoFit()
    '      .Columns("C:C").EntireColumn.AutoFit()
    '      .Columns("D:D").EntireColumn.AutoFit()
    '      .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '      .Columns("E:E").EntireColumn.AutoFit()
    '      .Columns("F:F").EntireColumn.AutoFit()
    '    End With
    '    Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\fterecibvac.xls"
    '    Try
    '      Kill(rutfte)
    '    Catch ex As Exception
    '    End Try

    '    excelBook.SaveAs(Filename:=rutfte)
    '    excelBook.Close()
    '    excelApp.Visible = True
    '    excelApp.Quit()

    '    Dim rutobj As String
    '    rutobj = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\formatos\formato cancelacion de vaciones.doc"

    '    Dim WordApp As New Word.Application
    '    Dim WordDocument As Word.Document = WordApp.Documents.Open(rutobj)


    '    'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
    '    WordApp.Visible = True
    '    WordDocument.Activate()
    '    With WordDocument.MailMerge
    '      .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `Hoja1$`")
    '      .ViewMailMergeFieldCodes = False
    '      .Destination = 0     'nuevo documento
    '      .SuppressBlankLines = True
    '      With .DataSource
    '        .FirstRecord = 1
    '        .LastRecord = -16
    '      End With
    '      .Execute(Pause:=False)
    '    End With
    '    WordDocument.ActiveWindow.Close()
    '    'WordApp.ActiveWindow.Close()
    '    '    Connection:="Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" & rutfte & ";Mode=Read;Extended Properties=""HDR=YES;IMEX=1;"";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine T", SQLStatement:="SELECT * FROM `Hoja1$`", SQLStatement1:="", SubType:=1)

    '    'WordDocument()
    '  Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '  End Try
    'End Sub

  End Class
End Namespace