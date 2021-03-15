Imports WWTS.General.Reglas
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop


Namespace ExcelReporte
  Public Class LiquidacionHaberes
    Public Shared Sub Imprimir_Liquidacion(ByVal _contrato As Contrato, ByVal _rubros As RubroDetList, ByVal _usuario As String)

      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)
        excelApp.Visible = False
        With excelWorksheet
          .Range("B1").Value = _contrato.PatronoString '" WWTS ECUADOR  S.A."
          .Range("B1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          .Range("B1:D1").Merge()
          .Range("B2").Value = "LIQUIDACION DE HABERES"
          .Range("B2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          .Range("B2:D2").Merge()
          .Range("A5").Value = "Nombre:"
          .Range("A6").Value = "F/Ingreso:"
          .Range("A7").Value = "F/Salida:"
          .Range("A8").Value = "Cargo:"
          .Range("A9").Value = "U/Sueldo:"
          .Range("A10").Value = "MOTIVO:"

          .Range("D5").Value = "Localidad:"
          '.Range("D5").Value = "Lugar de Trabajo:"
          '.Range("D6").Value = "Dpto:"
          .Range("D6").Value = "Sala:"
          .Range("D7").Value = "Cédula:"


          .Range("B12").Value = "Detalle de Haberes"
          .Range("B12:D12").Merge()


          Dim x As Integer = 0
          Dim ingresos As Decimal = 0
          Dim egresos As Decimal = 0

          For Each _rubdet As RubroDet In _rubros
            If Not _rubdet.Valor = 0 Then
              If _rubdet.PardetTipoRubro.Pardet_DatoDec1 = 1 And Not _rubdet.Pardet_TipoRubro = 11 Then
                .Range("B" & (14 + x).ToString).Value = _rubdet.TipoRubroString
                .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
                .Range("C" & (14 + x).ToString).Value = _rubdet.Valor
                ingresos += _rubdet.Valor
                x += 1
              End If
            End If
          Next

          x += 1
          .Range("B" & (14 + x).ToString).Value = "Sub-Total Liquidación de Haberes:"
          .Range("B" & (14 + x).ToString).Font.Bold = True
          .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          .Range("C" & (14 + x).ToString).Value = ingresos
          x += 2

          For Each _rubdet As RubroDet In _rubros
            If Not _rubdet.Valor = 0 Then
              If _rubdet.PardetTipoRubro.Pardet_DatoDec1 = -1 And Not _rubdet.Pardet_TipoRubro = 75 Then
                .Range("B" & (14 + x).ToString).Value = _rubdet.TipoRubroString
                .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
                .Range("C" & (14 + x).ToString).Value = _rubdet.Valor
                egresos += _rubdet.Valor
                x += 1
              ElseIf _rubdet.Pardet_TipoRubro = 11 Then
                .Range("B" & (14 + x).ToString).Value = _rubdet.TipoRubroString
                .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
                .Range("C" & (14 + x).ToString).Value = _rubdet.RubDet_Valor2 * (-1)
                egresos += _rubdet.Valor
                x += 1
              End If
            End If
          Next

          x += 1
          .Range("B" & (14 + x).ToString).Value = "Total Descuentos:"
          .Range("B" & (14 + x).ToString).Font.Bold = True
          .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          .Range("C" & (14 + x).ToString).Value = egresos

          x += 2
          .Range("B" & (14 + x).ToString).Value = "Neto Liquidación a Recibir:"
          .Range("B" & (14 + x).ToString).Font.Bold = True
          .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          .Range("C" & (14 + x).ToString).Value = (ingresos + egresos)

          x += 7
          .Range("A" & (14 + x).ToString).Value = "Elaborado por:"
          .Range("A" & (15 + x).ToString).Value = _usuario
          .Range("C" & (14 + x).ToString).Value = "Revisado por:"
          .Range("E" & (14 + x).ToString).Value = "Aprobado por:"

          x += 3
          .Range("A" & (14 + x).ToString).Value = "Fecha:"
          .Range("B" & (14 + x).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
          .Range("B" & (14 + x).ToString).Value = Now.Date.ToString("dd-MMM-yy")

          .Columns("B:B").ColumnWidth = 30
          .Range("B5").Value = _contrato.EmpleadoString
          .Range("B6").Value = _contrato.Contra_Desde.ToString("MMMM dd 'de' yyyy")
          .Range("B7").Value = _contrato.Contra_Hasta.ToString("MMMM dd 'de' yyyy")
          .Range("B8").Value = _contrato.CargoString
          '.Range("B9").NumberFormat = "0.00"
          .Range("B9").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
          .Range("B9").Value = "$ " + Rubro.ObtenerSueldoxContrato(_contrato).Total.ToString("0.00")
          .Range("B10").Value = _contrato.PardetMotivoSalida.Pardet_Descripcion

          .Range("E5").Value = _contrato.PardetDepartamento.PardetPadre.PardetPadre.Pardet_Descripcion
          .Range("E6").Value = _contrato.PardetDepartamento.PardetPadre.Pardet_Descripcion
          .Range("E7").NumberFormat = "@"
          .Range("E7").Value = _contrato.CedEmpleadoString





          '------

          '.Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          '.Range("A1").Font.Bold = True
          '.Range("A1:E1").Merge()
          ''.Range("A2").Value = "Periodo desde " & beneficio(0)..Periodo.PerPag_FechaDesde.ToShortDateString & " hasta " & Asistencias(0).Periodo.PerPag_FechaHasta.ToShortDateString
          '.Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          '.Range("A2:G2").Merge()
          '.Columns().ColumnWidth = 8
          '.Range("A5").Value = "Código"
          '.Columns("A:A").ColumnWidth = 12
          '.Columns("A:A").NumberFormat = "@"
          '.Range("B5").Value = "Cédula"
          '.Columns("B:B").NumberFormat = "@"
          '.Range("C5").Value = "Nombres y Apellidos"
          '.Columns("C:C").ColumnWidth = 13
          '.Range("D5").Value = "Sexo"

          '.Columns("E:H").NumberFormat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"

          '.Range("E5").Value = "Días Trabajados"
          '.Columns("E:E").ColumnWidth = 35
          '.Range("F5").Value = "Valor Acumulado"
          '.Range("G5").Value = "Valor a Pagar"
          'If _tipobenef.Pardet_Secuencia = CInt(Enumerados.enumTipoBeneficio.Vacaciones) Then
          '  .Range("H5").Value = "Días vacaciones"
          'End If
          'If _tipobenef.Pardet_Secuencia = CInt(Enumerados.enumTipoBeneficio.Utilidades) Then
          '  .Range("G5").Value = "Valor Utilidad"
          '  .Range("H5").Value = "Cargas"
          '  .Range("I5").Value = "Valor Cargas"
          '  .Range("J5").Value = "Valor Bono"
          '  .Range("K5").Value = "Valor Bono Cargas"
          'End If

          'Dim t As Integer
          'For t = 0 To Beneficio.Count - 1
          '  .Range("A" & (6 + t).ToString).Value = Beneficio(t).Entida_Codigo
          '  .Range("B" & (6 + t).ToString).Value = Beneficio(t).Contrato.Empleado.Cedula
          '  .Range("C" & (6 + t).ToString).Value = Beneficio(t).Contrato.Empleado.NombreCompleto
          '  .Range("D" & (6 + t).ToString).Value = Beneficio(t).Contrato.Empleado.SexoString
          '  .Range("E" & (6 + t).ToString).Value = Beneficio(t).Benefi_DiasTrab
          '  .Range("F" & (6 + t).ToString).Value = Beneficio(t).BeneficioCalculado.SueldosAcumulados
          '  .Range("G" & (6 + t).ToString).Value = Beneficio(t).Benefi_Valor
          '  If Beneficio(t).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
          '    .Range("H" & (6 + t).ToString).Value = Beneficio(t).Benefi_DiasVac
          '  End If
          '  If Beneficio(t).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Utilidades Then
          '    .Range("H" & (6 + t).ToString).Value = Beneficio(t).Contrato.Empleado.NumeroCargas
          '    .Range("I" & (6 + t).ToString).Value = Beneficio(t).Benefi_ValorCargas
          '    .Range("J" & (6 + t).ToString).Value = Beneficio(t).Benefi_ValorBono
          '    .Range("K" & (6 + t).ToString).Value = Beneficio(t).Benefi_ValorBonoCargas
          '  End If
          'Next

          'Dim _rango As Excel.Range
          '_rango = .Range("A5:E5")
          'If Beneficio(0).Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones Then
          '  _rango = .Range("A5:F5")
          'End If
          'With _rango
          '  .Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
          '  .Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone
          '  With .Borders(Excel.XlBordersIndex.xlEdgeLeft)
          '    .LineStyle = Excel.XlLineStyle.xlContinuous
          '    .Weight = Excel.XlBorderWeight.xlThin
          '    .ColorIndex = Excel.Constants.xlAutomatic
          '  End With
          '  With .Borders(Excel.XlBordersIndex.xlEdgeTop)
          '    .LineStyle = Excel.XlLineStyle.xlContinuous
          '    .Weight = Excel.XlBorderWeight.xlThin
          '    .ColorIndex = Excel.Constants.xlAutomatic
          '  End With
          '  With .Borders(Excel.XlBordersIndex.xlEdgeBottom)
          '    .LineStyle = Excel.XlLineStyle.xlContinuous
          '    .Weight = Excel.XlBorderWeight.xlThin
          '    .ColorIndex = Excel.Constants.xlAutomatic
          '  End With
          '  With .Borders(Excel.XlBordersIndex.xlEdgeRight)
          '    .LineStyle = Excel.XlLineStyle.xlContinuous
          '    .Weight = Excel.XlBorderWeight.xlThin
          '    .ColorIndex = Excel.Constants.xlAutomatic
          '  End With
          '  With .Borders(Excel.XlBordersIndex.xlInsideVertical)
          '    .LineStyle = Excel.XlLineStyle.xlContinuous
          '    .Weight = Excel.XlBorderWeight.xlThin
          '    .ColorIndex = Excel.Constants.xlAutomatic
          '  End With
          'End With

          '.Columns("B:B").EntireColumn.AutoFit()
          '.Columns("C:C").EntireColumn.AutoFit()
          '.Columns("D:D").EntireColumn.AutoFit()
          ''.Columns("E:E").NumberFormat = "0" & CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
          '.Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
          '.Columns("E:E").EntireColumn.AutoFit()
          '.Columns("F:F").EntireColumn.AutoFit()
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
        With excelWorksheet.PageSetup
          .PrintTitleRows = "$1:$5"
          .PrintTitleColumns = ""
          .LeftHeader = ""
          .CenterHeader = ""
          '.CenterHeader = "Página &P de &N"
          .RightHeader = ""
          .LeftFooter = ""
          '.LeftFooter = "Infoware"
          .CenterFooter = ""
          '.CenterFooter = "Página &P"
          .RightFooter = ""
          '.RightFooter = "&D"
        End With

        excelApp.Visible = True
        excelWorksheet.PrintPreview()
        'excelApp.Quit()
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub


    Public Shared Sub Imprimir_MedioAprobacion(ByVal _contrato As Contrato, ByVal _rubros As RubroDetList, ByVal _usuario As String)
      Dim _nombreHoja As String = "Hoja1"

      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)
        _nombreHoja = excelWorksheet.Name

        excelApp.Visible = False
        With excelWorksheet
          .Columns().ColumnWidth = 80
          .Columns().NumberFormat = "@"
          .Range("A1").Value = "Empleado"
          .Range("B1").Value = "ContratoDesde"
          .Range("C1").Value = "ContratoHasta"
          .Range("D1").Value = "Cargo"
          .Range("E1").Value = "Sueldo"
          .Range("F1").Value = "Sala"
          .Range("G1").Value = "LugarSala"
          .Range("H1").Value = "JefeInmediato"
          .Range("I1").Value = "MotivoSalida"
          .Range("J1").Value = "Liquidacion"
          .Range("K1").Value = "Fecha"

          .Range("A2").Value = _contrato.EmpleadoString
          .Range("B2").Value = _contrato.Contra_Desde.ToString("MMMM dd 'de' yyyy")
          .Range("C2").Value = _contrato.Contra_Hasta.ToString("MMMM dd 'de' yyyy")
          .Range("D2").Value = _contrato.CargoString
          .Range("E2").Value = Rubro.ObtenerSueldoxContrato(_contrato).Total.ToString("0.00")
          .Range("F2").Value = _contrato.PardetDepartamento.PardetPadre.Pardet_Descripcion
          .Range("G2").Value = _contrato.PardetDepartamento.PardetPadre.PardetPadre.Pardet_Descripcion
          .Range("H2").Value = _contrato.Cargo.JefeInmediatoEmpleadoActual
          .Range("I2").Value = _contrato.PardetMotivoSalida.Pardet_Descripcion

          For Each _rubdet As RubroDet In _rubros
            If _rubdet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar Then
              .Range("J2").Value = ((-1) * _rubdet.Valor).ToString("0.00")
            End If
          Next

          .Range("K2").Value = Now.Date.ToString("dd 'de' MMMM 'de' yyyy")
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftellamados.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim rutobj As String
        If _contrato.Patron_Codigo = 1 Then
          rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\MEDIO_DE_APROBACION_WWTS.doc"
        Else
          rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\MEDIO_DE_APROBACION_RUSIENSA.doc"
        End If

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(rutobj)
        'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
        WordApp.Visible = True
        WordDocument.Activate()
        With WordDocument.MailMerge
          .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
          .ViewMailMergeFieldCodes = False
          .Destination = 0     'nuevo documento
          .SuppressBlankLines = True
          With .DataSource
            .FirstRecord = 1
            .LastRecord = -16
          End With
          .Execute(Pause:=False)
        End With
        WordDocument.ActiveWindow.Close()
        'WordApp.ActiveWindow.Close()
        '    Connection:="Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" & rutfte & ";Mode=Read;Extended Properties=""HDR=YES;IMEX=1;"";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine T", SQLStatement:="SELECT * FROM `Hoja1$`", SQLStatement1:="", SubType:=1)

        'WordDocument()
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub

  End Class
End Namespace
