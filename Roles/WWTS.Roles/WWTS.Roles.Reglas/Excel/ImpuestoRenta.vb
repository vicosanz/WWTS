Imports WWTS.General.Reglas
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop


Namespace ExcelReporte
  Public Class ImpuestoRenta
    Public Shared Sub Imprimir_Formato(ByVal _patrono As Patrono, ByVal _periodo As PeriodoPago, ByVal _pardet As WWTSParametroDet)
      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)
        excelApp.Visible = False

        Dim gp As New GastosPersonales(_patrono.OperadorDatos, True)

        With excelWorksheet
          .Range("B2").Value = _patrono.NombreCompleto
          .Range("B4").Value = "FORMATO ANEXO RELACION DEPENDENCIA"

          .Range("A7").Value = "(A)"
          .Range("A7").Font.Bold = True
          .Range("B7").Value = "INGRESOS MENSUALES SEGÚN NOMINA"
          .Range("B7").Font.Bold = True
          .Range("B7").Interior.Color = RGB(255, 255, 0)

          .Range("B9").Value = "Sueldos"
          .Range("C9").Value = gp.Uno(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B10").Value = "Sueldos Subsidios - Maternidad"
          .Range("C10").Value = gp.Dos(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B11").Value = "Sueldos Subsidios - Enfermedad"
          .Range("C11").Value = gp.Tres(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B12").Value = "Vacaciones"
          .Range("C12").Value = gp.Cuatro(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B13").Value = "Horas Extras 25%"
          .Range("C13").Value = gp.Cinco(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B14").Value = "Horas Extras 50%"
          .Range("C14").Value = gp.Seis(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B15").Value = "Horas Extras 100%"
          .Range("C15").Value = gp.Siete(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B16").Value = "Horas Extras 100%b"
          .Range("C16").Value = gp.Ocho(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B17").Value = "' = SUELDOS Y SALARIOS"
          .Range("B17").Font.Bold = True
          .Range("B17").Interior.Color = RGB(204, 255, 255)
          .Range("C17").Value = gp.Nueve(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B18").Value = "Bono Extraordinario de Producción"
          .Range("C18").Value = gp.Diez(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B19").Value = "Bono Meta"
          .Range("C19").Value = gp.Once(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B20").Value = "Bonificación Especial"
          .Range("C20").Value = gp.Doce(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B21").Value = "Bono Vivienda"
          .Range("C21").Value = gp.Trece(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B22").Value = "Sueldo sin Aportación al IESS"
          .Range("C22").Value = gp.Catorce(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B23").Value = "Horas Extras sin Aportación al IESS"
          .Range("C23").Value = gp.Quince(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B24").Value = "Alimentación"
          .Range("C24").Value = gp.Diezseis(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B25").Value = "Transporte"
          .Range("C25").Value = gp.Diezsiete(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B26").Value = "' = SOBRESUELDOS, COMISIONES Y OTRAS REMUNERACIONES"
          .Range("B26").Font.Bold = True
          .Range("B26").Interior.Color = RGB(204, 255, 255)
          .Range("C26").Value = gp.Diezocho(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B28").Value = "PARTICIPACION UTILIDADES"
          .Range("B28").Interior.Color = RGB(204, 255, 255)
          .Range("C28").Value = gp.Dieznueve(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B30").Value = "TOTAL INGRESOS"
          .Range("B30").Font.Bold = True
          .Range("B30").Interior.Color = RGB(204, 255, 255)
          .Range("C30").Value = gp.Veinte(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("A32").Value = "(B)"
          .Range("A32").Font.Bold = True
          .Range("B32").Value = "(-) APORTE IESS"
          .Range("B32").Font.Bold = True
          .Range("B32").Interior.Color = RGB(255, 255, 0)
          .Range("B33").Value = "APORTE INDIVIDUAL IESS 9,35%"
          .Range("C33").Value = gp.Veinteuno(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B35").Value = "SUBTOTAL"
          .Range("B35").Font.Bold = True
          .Range("C35").Value = gp.Veintedos(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("A37").Value = "(C)"
          .Range("A37").Font.Bold = True
          .Range("B37").Value = "(-) GASTOS PERSONALES DEDUCIBLES"
          .Range("B37").Font.Bold = True
          .Range("B37").Interior.Color = RGB(255, 255, 0)
          .Range("B38").Value = "Vivienda"
          .Range("C38").Value = gp.Veintetres(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B39").Value = "Salud"
          .Range("C39").Value = gp.Veintecuatro(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B40").Value = "Educación"
          .Range("C40").Value = gp.Veintecinco(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B41").Value = "Alimentación"
          .Range("C41").Value = gp.Veinteseis(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B42").Value = "Vestimenta"
          .Range("C42").Value = gp.Veintesiete(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B43").Value = "TOTAL GASTOS DEDUCIBLES"
          .Range("B43").Font.Bold = True
          .Range("C43").Value = gp.Veinteocho(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B46").Value = "SUBTOTAL " & _patrono.NombreCompleto
          .Range("B46").Font.Bold = True
          .Range("B46").Interior.Color = RGB(255, 255, 0)
          .Range("C46").Value = gp.Veintedos(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia) - gp.Veinteocho(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)


          .Range("A49").Value = "(D)"
          .Range("A49").Font.Bold = True
          .Range("B49").Value = "(+) INGRESOS GRAVADOS GENERADOS  OTROS EMPLEADORES"
          .Range("B49").Font.Bold = True
          .Range("B37").Interior.Color = RGB(255, 255, 0)
          .Range("B50").Value = "Sueldos"
          .Range("C50").Value = gp.Veintenueve(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B51").Value = "Sueldos Subsidios"
          .Range("C51").Value = 0
          .Range("B52").Value = "Vacaciones"
          .Range("C52").Value = gp.Treinta(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("B53").Value = "Horas Extras"
          .Range("C53").Value = gp.Treintauno(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)
          .Range("A54").Value = "1"
          .Range("B54").Value = "' = SUELDOS Y SALARIOS"
          .Range("B54").Font.Bold = True
          .Range("B54").Interior.Color = RGB(204, 255, 255)
          .Range("C54").Value = gp.Treintados(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B56").Value = "Bono Extraordinario de Producción"
          .Range("C56").Value = 0
          .Range("B57").Value = "Bono Meta"
          .Range("C57").Value = 0
          .Range("B58").Value = "Bonificación Especial"
          .Range("C58").Value = 0
          .Range("B59").Value = "Sueldo sin Aportación al IESS"
          .Range("C59").Value = 0
          .Range("B60").Value = "Horas Extras sin Aportación al IESS"
          .Range("C60").Value = 0
          .Range("B61").Value = "Alimentación"
          .Range("C61").Value = 0
          .Range("B62").Value = "Transporte"
          .Range("C62").Value = 0
          .Range("A63").Value = "2"
          .Range("B63").Value = "' = SOBRESUELDOS, COMISIONES Y OTRAS REMUNERACIONES"
          .Range("B63").Font.Bold = True
          .Range("B63").Interior.Color = RGB(204, 255, 255)
          .Range("C63").Value = 0

          .Range("A65").Value = "3"
          .Range("B65").Value = "PARTICIPACION UTILIDADES"
          .Range("B65").Interior.Color = RGB(204, 255, 255)
          .Range("C65").Value = gp.Treintatres(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B67").Value = "TOTAL INGRESOS OTROS EMPLEADORES"
          .Range("B67").Font.Bold = True
          .Range("B67").Interior.Color = RGB(204, 255, 255)
          .Range("C67").Value = gp.Treintados(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia) + gp.Treintatres(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("A69").Value = "(E)"
          .Range("A69").Font.Bold = True
          .Range("B69").Value = "(-) APORTE IESS"
          .Range("B69").Font.Bold = True
          .Range("B69").Interior.Color = RGB(255, 255, 0)
          .Range("B70").Value = "APORTE INDIVIDUAL IESS 9,35%"
          .Range("C70").Value = gp.Treintacuatro(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)


          .Range("A73").Value = "(F)"
          .Range("A73").Font.Bold = True
          .Range("B73").Value = "(-) GASTOS PERSONALES DEDUCIBLES"
          .Range("B73").Font.Bold = True
          .Range("B73").Interior.Color = RGB(255, 255, 0)
          .Range("B74").Value = "Vivienda"
          .Range("C74").Value = 0
          .Range("B75").Value = "Salud"
          .Range("C75").Value = 0
          .Range("B76").Value = "Educación"
          .Range("C76").Value = 0
          .Range("B77").Value = "Alimentación"
          .Range("C77").Value = 0
          .Range("B78").Value = "Vestimenta"
          .Range("C78").Value = 0
          .Range("B79").Value = "TOTAL GASTOS DEDUCIBLES"
          .Range("B79").Font.Bold = True
          .Range("C79").Value = 0

          .Range("B81").Value = "SUBTOTAL OTROS EMPLEADORES"
          .Range("B81").Font.Bold = True
          .Range("B81").Interior.Color = RGB(255, 255, 0)
          .Range("C81").Value = gp.Treintacinco(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B83").Value = "BASE IMPONIBLE PARA EL S.R.I."
          .Range("B83").Font.Bold = True
          .Range("C83").Value = gp.Veintedos(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia) - gp.Veinteocho(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia) + gp.Treintacinco(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B85").Value = "IMPUESTO A LA RENTA CAUSADO"
          .Range("B85").Font.Bold = True
          .Range("C85").Value = gp.Treintaseis(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)

          .Range("B87").Value = "IMPUESTO A LA RENTA RETENIDO"
          .Range("B87").Font.Bold = True
          .Range("C87").Value = gp.Treintaseis(_periodo.PerPag_FechaDesde, _patrono.Patron_Codigo, _pardet.Pardet_Secuencia)


          .Columns("B:B").EntireColumn.AutoFit()
          .Columns("C:C").NumberFormat = "0.00"


          '.Range("B1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          '.Range("B1:D1").Merge()
          '.Range("B2").Value = "LIQUIDACION DE HABERES"
          '.Range("B2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
          '.Range("B2:D2").Merge()
          '.Range("A5").Value = "Nombre:"
          '.Range("A6").Value = "F/Ingreso:"
          '.Range("A7").Value = "F/Salida:"
          '.Range("A8").Value = "Cargo:"
          '.Range("A9").Value = "U/Sueldo:"
          '.Range("A10").Value = "MOTIVO:"

          '.Range("D5").Value = "Localidad:"
          ''.Range("D5").Value = "Lugar de Trabajo:"
          ''.Range("D6").Value = "Dpto:"
          '.Range("D6").Value = "Sala:"
          '.Range("D7").Value = "Cédula:"


          '.Range("B12").Value = "Detalle de Haberes"
          '.Range("B12:D12").Merge()


          'Dim x As Integer = 0
          'Dim ingresos As Decimal = 0
          'Dim egresos As Decimal = 0

          'For Each _rubdet As RubroDet In _rubros
          '  If Not _rubdet.Valor = 0 Then
          '    If _rubdet.PardetTipoRubro.Pardet_DatoDec1 = 1 And Not _rubdet.Pardet_TipoRubro = 11 Then
          '      .Range("B" & (14 + x).ToString).Value = _rubdet.TipoRubroString
          '      .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          '      .Range("C" & (14 + x).ToString).Value = _rubdet.Valor
          '      ingresos += _rubdet.Valor
          '      x += 1
          '    End If
          '  End If
          'Next

          'x += 1
          '.Range("B" & (14 + x).ToString).Value = "Sub-Total Liquidación de Haberes:"
          '.Range("B" & (14 + x).ToString).Font.Bold = True
          '.Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          '.Range("C" & (14 + x).ToString).Value = ingresos
          'x += 2

          'For Each _rubdet As RubroDet In _rubros
          '  If Not _rubdet.Valor = 0 Then
          '    If _rubdet.PardetTipoRubro.Pardet_DatoDec1 = -1 And Not _rubdet.Pardet_TipoRubro = 75 Then
          '      .Range("B" & (14 + x).ToString).Value = _rubdet.TipoRubroString
          '      .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          '      .Range("C" & (14 + x).ToString).Value = _rubdet.Valor
          '      egresos += _rubdet.Valor
          '      x += 1
          '    ElseIf _rubdet.Pardet_TipoRubro = 11 Then
          '      .Range("B" & (14 + x).ToString).Value = _rubdet.TipoRubroString
          '      .Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          '      .Range("C" & (14 + x).ToString).Value = _rubdet.RubDet_Valor2 * (-1)
          '      egresos += _rubdet.Valor
          '      x += 1
          '    End If
          '  End If
          'Next

          'x += 1
          '.Range("B" & (14 + x).ToString).Value = "Total Descuentos:"
          '.Range("B" & (14 + x).ToString).Font.Bold = True
          '.Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          '.Range("C" & (14 + x).ToString).Value = egresos

          'x += 2
          '.Range("B" & (14 + x).ToString).Value = "Neto Liquidación a Recibir:"
          '.Range("B" & (14 + x).ToString).Font.Bold = True
          '.Range("C" & (14 + x).ToString).NumberFormat = "0.00"
          '.Range("C" & (14 + x).ToString).Value = (ingresos + egresos)

          'x += 7
          '.Range("A" & (14 + x).ToString).Value = "Elaborado por:"
          '.Range("A" & (15 + x).ToString).Value = _usuario
          '.Range("C" & (14 + x).ToString).Value = "Revisado por:"
          '.Range("E" & (14 + x).ToString).Value = "Aprobado por:"

          'x += 3
          '.Range("A" & (14 + x).ToString).Value = "Fecha:"
          '.Range("B" & (14 + x).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
          '.Range("B" & (14 + x).ToString).Value = Now.Date.ToString("dd-MMM-yy")

          '.Columns("B:B").ColumnWidth = 30
          '.Range("B5").Value = _contrato.EmpleadoString
          '.Range("B6").Value = _contrato.Contra_Desde.ToString("MMMM dd 'de' yyyy")
          '.Range("B7").Value = _contrato.Contra_Hasta.ToString("MMMM dd 'de' yyyy")
          '.Range("B8").Value = _contrato.CargoString
          ''.Range("B9").NumberFormat = "0.00"
          '.Range("B9").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
          '.Range("B9").Value = "$ " + Rubro.ObtenerSueldoxContrato(_contrato).Total.ToString("0.00")
          '.Range("B10").Value = _contrato.PardetMotivoSalida.Pardet_Descripcion

          '.Range("E5").Value = _contrato.PardetDepartamento.PardetPadre.PardetPadre.Pardet_Descripcion
          '.Range("E6").Value = _contrato.PardetDepartamento.PardetPadre.Pardet_Descripcion
          '.Range("E7").NumberFormat = "@"
          '.Range("E7").Value = _contrato.CedEmpleadoString





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
        'With excelWorksheet.PageSetup
        '  .PrintTitleRows = "$1:$5"
        '  .PrintTitleColumns = ""
        '  .LeftHeader = ""
        '  .CenterHeader = ""
        '  '.CenterHeader = "Página &P de &N"
        '  .RightHeader = ""
        '  .LeftFooter = ""
        '  '.LeftFooter = "Infoware"
        '  .CenterFooter = ""
        '  '.CenterFooter = "Página &P"
        '  .RightFooter = ""
        '  '.RightFooter = "&D"
        'End With

        excelApp.Visible = True
        'excelWorksheet.PrintPreview()
        'excelApp.Quit()
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub

    'Public Shared Sub Imprimir_MedioAprobacion(ByVal _contrato As Contrato, ByVal _rubros As RubroDetList, ByVal _usuario As String)

    '  Try
    '    Dim excelApp As New Excel.Application
    '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
    '    Dim excelWorksheet As Excel.Worksheet = _
    '     CType(excelBook.Worksheets(1), Excel.Worksheet)

    '    excelApp.Visible = False
    '    With excelWorksheet
    '      .Columns().ColumnWidth = 80
    '      .Columns().NumberFormat = "@"
    '      .Range("A1").Value = "Empleado"
    '      .Range("B1").Value = "ContratoDesde"
    '      .Range("C1").Value = "ContratoHasta"
    '      .Range("D1").Value = "Cargo"
    '      .Range("E1").Value = "Sueldo"
    '      .Range("F1").Value = "Sala"
    '      .Range("G1").Value = "LugarSala"
    '      .Range("H1").Value = "JefeInmediato"
    '      .Range("I1").Value = "MotivoSalida"
    '      .Range("J1").Value = "Liquidacion"
    '      .Range("K1").Value = "Fecha"

    '      .Range("A2").Value = _contrato.EmpleadoString
    '      .Range("B2").Value = _contrato.Contra_Desde.ToString("MMMM dd 'de' yyyy")
    '      .Range("C2").Value = _contrato.Contra_Hasta.ToString("MMMM dd 'de' yyyy")
    '      .Range("D2").Value = _contrato.CargoString
    '      .Range("E2").Value = Rubro.ObtenerSueldoxContrato(_contrato).Total.ToString("0.00")
    '      .Range("F2").Value = _contrato.PardetDepartamento.PardetPadre.Pardet_Descripcion
    '      .Range("G2").Value = _contrato.PardetDepartamento.PardetPadre.PardetPadre.Pardet_Descripcion
    '      .Range("H2").Value = _contrato.Cargo.JefeInmediatoEmpleadoActual
    '      .Range("I2").Value = _contrato.PardetMotivoSalida.Pardet_Descripcion

    '      For Each _rubdet As RubroDet In _rubros
    '        If _rubdet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar Then
    '          .Range("J2").Value = ((-1) * _rubdet.Valor).ToString("0.00")
    '        End If
    '      Next

    '      .Range("K2").Value = Now.Date.ToString("dd 'de' MMMM 'de' yyyy")
    '    End With

    '    Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftellamados.xls"
    '    Try
    '      Kill(rutfte)
    '    Catch ex As Exception
    '    End Try

    '    excelBook.SaveAs(Filename:=rutfte)
    '    excelBook.Close()
    '    excelApp.Visible = True
    '    excelApp.Quit()

    '    Dim rutobj As String
    '    If _contrato.Patron_Codigo = 1 Then
    '      rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\MEDIO_DE_APROBACION_WWTS.doc"
    '    Else
    '      rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\MEDIO_DE_APROBACION_RUSIENSA.doc"
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

  End Class
End Namespace
