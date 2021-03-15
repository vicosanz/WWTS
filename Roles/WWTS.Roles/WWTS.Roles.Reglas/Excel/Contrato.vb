Imports Microsoft.Office.Interop
Imports WWTS.General.Reglas

Namespace ExcelReporte
  Public Class ContratoReporte
    Public Shared Sub ExportarExcel(ByVal Fuente As ContratoList, ByVal _versueldos As Boolean)
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
        .Range("J1").Value = "Sección"
        .Range("J1").ColumnWidth = 12
        .Range("K1").Value = "Labor"
        .Range("K1").ColumnWidth = 12
        .Range("L1").Value = "Patrono"
        .Range("L1").ColumnWidth = 12
        .Range("M1").Value = "Fecha entrada"
        .Range("M1").ColumnWidth = 15
        .Columns(13).NumberFormat = My.Application.Culture.DateTimeFormat.ShortDatePattern
        .Range("N1").Value = "Fecha salida"
        .Range("N1").ColumnWidth = 15
        .Columns(14).NumberFormat = My.Application.Culture.DateTimeFormat.ShortDatePattern
        .Range("O1").Value = "Edad"
        .Range("O1").ColumnWidth = 7
        .Range("P1").Value = "Tipo sangre"
        .Range("P1").ColumnWidth = 15
        .Range("Q1").Value = "Forma Pago"
        .Range("Q1").ColumnWidth = 15
        .Range("R1").Value = "Banco"
        .Range("R1").ColumnWidth = 15
        .Range("S1").Value = "Tipo Cta"
        .Range("S1").ColumnWidth = 15
        .Range("T1").Value = "Núm Cta"
        .Range("T1").ColumnWidth = 15
        If _versueldos Then
          .Range("U:W").NumberFormat = "0.00"
          .Range("U1").Value = "Sueldo"
          .Range("U1").ColumnWidth = 15
          .Range("V1").Value = "Adicional"
          .Range("V1").ColumnWidth = 15
          .Range("W1").Value = "Transporte"
          .Range("W1").ColumnWidth = 15
        End If

        Dim t As Integer
        For t = 0 To Fuente.Count - 1
          .Range("A" & (t + 2).ToString).Value = Fuente(t).Empleado.CodigoEmpleado
          .Range("B" & (t + 2).ToString).Value = Fuente(t).Empleado.NombreCompleto
          .Range("B" & (t + 2).ToString).WrapText = True
          .Range("C" & (t + 2).ToString).Value = Fuente(t).Empleado.Cedula
          .Range("D" & (t + 2).ToString).Value = Fuente(t).Empleado.SexoString
          .Range("E" & (t + 2).ToString).Value = Fuente(t).Empleado.EstadoCivilString
          .Range("F" & (t + 2).ToString).Value = Fuente(t).Empleado.DireccionesString
          .Range("F" & (t + 2).ToString).WrapText = True
          .Range("G" & (t + 2).ToString).Value = Fuente(t).Empleado.TelefonosString
          .Range("H" & (t + 2).ToString).Value = Fuente(t).Empleado.CarnetConadis
          .Range("I" & (t + 2).ToString).Value = Fuente(t).Empleado.Discapacidad
          '.Range("J" & (t + 2).ToString).Value = Fuente(t).Labor.Seccion.Pardet_Descripcion
          '.Range("K" & (t + 2).ToString).Value = Fuente(t).Labor.Labor_Descripcion
          .Range("J" & (t + 2).ToString).Value = Fuente(t).Cargo.SeccionString
          .Range("K" & (t + 2).ToString).Value = Fuente(t).Cargo.Cargo_Descripcion
          .Range("L" & (t + 2).ToString).Value = Fuente(t).Patrono.NombreCompleto
          .Range("M" & (t + 2).ToString).Value = Fuente(t).Contra_Desde
          If Fuente(t).esCerrado Then
            .Range("N" & (t + 2).ToString).Value = Fuente(t).Contra_Hasta
          End If
          .Range("O" & (t + 2).ToString).Value = Fuente(t).Empleado.Edad
          .Range("P" & (t + 2).ToString).Value = Fuente(t).Empleado.PardetTipoSangreString
          .Range("Q" & (t + 2).ToString).Value = Fuente(t).Empleado.PardetFormaPagoRol.Pardet_Descripcion
          If Fuente(t).Empleado.Pardet_FormaPagoRolEnum = Enumerados.enumFormaPagoRol.Deposito Then
            .Range("R" & (t + 2).ToString).Value = Fuente(t).Empleado.PardetBanco.Pardet_Descripcion
            .Range("S" & (t + 2).ToString).Value = Fuente(t).Empleado.PardetTipoCtaBancaria.Pardet_Descripcion
            .Range("T" & (t + 2).ToString).Value = Fuente(t).Empleado.Emplea_NumeroCuentaBancaria
          End If

          If _versueldos Then
            If Fuente(t).Tipocontrato.Pardet_TipoContrato = Enumerados.enumTipoContrato.PorHoras Then
              .Range("U" & (t + 2).ToString).Value = Fuente(t).Contra_ValorHora
            Else
              .Range("U" & (t + 2).ToString).Value = Fuente(t).Sueldo
            End If
            .Range("V" & (t + 2).ToString).Value = Fuente(t).Contra_Antiguedad
            .Range("W" & (t + 2).ToString).Value = Fuente(t).Transporte
          End If
        Next
        excelApp.Visible = True
        .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintPreview()
      End With
    End Sub

    Public Shared Sub Imprimir_contratosxxx(ByVal contratos As ContratoList)
      If contratos Is Nothing Then
        MsgBox("No existen contratos seleccionados", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If
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
          .Range("A1").Value = "Patrono"
          .Range("B1").Value = "RUCPatrono"
          .Range("C1").Value = "RepresLegal"
          .Range("D1").Value = "CedRepLegal"
          .Range("E1").Value = "Empleado"
          .Range("F1").Value = "CedEmpleado"
          .Range("G1").Value = "Provincia"
          .Range("H1").Value = "Canton"
          .Range("I1").Value = "Fecha"
          .Range("J1").Value = "Cargo"
          .Range("K1").Value = "Sueldo"
          .Range("L1").Value = "SueldoLetras"
          .Range("M1").Value = "TelEmpleado"
          For t As Integer = 0 To contratos.Count - 1
            .Range("A" & (t + 2).ToString).Value = contratos(t).Patrono.NombreCompleto
            .Range("B" & (t + 2).ToString).Value = contratos(t).Patrono.Entidadjuridica.Entidad.RUC
            .Range("C" & (t + 2).ToString).Value = contratos(t).Patrono.Entidadjuridica.RepresentanteLegalString
            If contratos(t).Patrono.Entidadjuridica.RepresentanteLegal Is Nothing Then
              .Range("D" & (t + 2).ToString).Value = "*N/A*"
            Else
              .Range("D" & (t + 2).ToString).Value = contratos(t).Patrono.Entidadjuridica.RepresentanteLegal.Entidad.Cedula
            End If
            .Range("E" & (t + 2).ToString).Value = contratos(t).Empleado.NombreCompleto
            .Range("F" & (t + 2).ToString).Value = contratos(t).Empleado.Cedula
            .Range("G" & (t + 2).ToString).Value = contratos(t).Patrono.PardetParroquia.PardetPadre.PardetPadre.Pardet_Descripcion
            .Range("H" & (t + 2).ToString).Value = contratos(t).Patrono.PardetParroquia.PardetPadre.Pardet_Descripcion
            .Range("I" & (t + 2).ToString).Value = contratos(t).Contra_Desde.ToLongDateString
            '.Range("J" & (t + 2).ToString).Value = contratos(t).Labor.Labor_Descripcion
            .Range("J" & (t + 2).ToString).Value = contratos(t).Cargo.Cargo_Descripcion
            .Range("K" & (t + 2).ToString).Value = contratos(t).Contra_Sueldo.ToString("0.00")
            .Range("L" & (t + 2).ToString).Value = contratos(t).Contra_SueldoenLetras
            .Range("M" & (t + 2).ToString).Value = contratos(t).Empleado.TelefonoCasaString
          Next
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecontratos.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(TipoContratoFormato.ObtenerFormato(contratos(0).Tipocontrato, Enumerados.enumFormatoxTipoContrato.Contrato))
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

    Public Shared Sub Imprimir_certificados(ByVal contratos As ContratoList)
      If contratos Is Nothing Then
        MsgBox("No existen contratos seleccionados", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If
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
          .Range("A1").Value = "Patrono"
          .Range("B1").Value = "RUCPatrono"
          .Range("C1").Value = "RepresLegal"
          .Range("D1").Value = "CedRepLegal"
          .Range("E1").Value = "Empleado"
          .Range("F1").Value = "CedEmpleado"
          .Range("G1").Value = "Provincia"
          .Range("H1").Value = "Canton"
          .Range("I1").Value = "FechaDesde"
          .Range("J1").Value = "FechaHasta"
          .Range("K1").Value = "Cargo"
          .Range("L1").Value = "Sueldo"
          .Range("M1").Value = "SueldoLetras"
          .Range("N1").Value = "Tiempo"
          For t As Integer = 0 To contratos.Count - 1
            .Range("A" & (t + 2).ToString).Value = contratos(t).Patrono.NombreCompleto
            .Range("B" & (t + 2).ToString).Value = contratos(t).Patrono.Entidadjuridica.Entidad.RUC
            .Range("C" & (t + 2).ToString).Value = contratos(t).Patrono.Entidadjuridica.RepresentanteLegalString
            .Range("D" & (t + 2).ToString).Value = contratos(t).Patrono.Entidadjuridica.RepresentanteLegal.Entidad.Cedula
            .Range("E" & (t + 2).ToString).Value = contratos(t).Empleado.NombreCompleto
            .Range("F" & (t + 2).ToString).Value = contratos(t).Empleado.Cedula
            .Range("G" & (t + 2).ToString).Value = contratos(t).Patrono.PardetParroquia.PardetPadre.PardetPadre.Pardet_Descripcion
            .Range("H" & (t + 2).ToString).Value = contratos(t).Patrono.PardetParroquia.PardetPadre.Pardet_Descripcion
            .Range("I" & (t + 2).ToString).Value = contratos(t).Contra_Desde.ToShortDateString
            If contratos(t).esCerrado Then
              .Range("J" & (t + 2).ToString).Value = contratos(t).Contra_Hasta.ToShortDateString
              .Range("N" & (t + 2).ToString).Value = "laboró"
            Else
              .Range("J" & (t + 2).ToString).Value = "la actualidad"
              .Range("N" & (t + 2).ToString).Value = "labora"
            End If
            '.Range("K" & (t + 2).ToString).Value = contratos(t).Labor.Labor_Descripcion
            .Range("K" & (t + 2).ToString).Value = contratos(t).Cargo.Cargo_Descripcion
            .Range("L" & (t + 2).ToString).Value = contratos(t).Contra_Sueldo.ToString("0.00")
            .Range("M" & (t + 2).ToString).Value = contratos(t).Contra_SueldoenLetras
          Next
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecertificados.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(TipoContratoFormato.ObtenerFormato(contratos(0).Tipocontrato, Enumerados.enumFormatoxTipoContrato.CertificadoTrabajo))
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


    Public Shared Sub Imprimir_TransaccionLaboral(ByVal _contrato As Contrato)
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
          .Range("A1").Value = "Nombre"
          .Range("B1").Value = "Contra_Desde"
          .Range("C1").Value = "Contra_Hasta"
          .Range("D1").Value = "Cargo"
          .Range("E1").Value = "Sueldo"
          .Range("F1").Value = "SueldoLetras"
          .Range("G1").Value = "Liquidacion"
          .Range("H1").Value = "LiquidacionLetras"
          .Range("I1").Value = "Liquidacion30"
          .Range("J1").Value = "Liquidacion35"

          .Range("A2").Value = _contrato.EmpleadoString
          .Range("B2").Value = _contrato.Contra_Desde.ToString("dd 'de' MMMM 'del' yyyy")
          .Range("C2").Value = _contrato.Contra_Hasta.ToString("dd 'de' MMMM 'del' yyyy")
          .Range("D2").Value = _contrato.CargoString
          .Range("E2").Value = Rubro.ObtenerSueldoxContrato(_contrato).Total.ToString("0.00")
          .Range("F2").Value = Utilerias.NumaLetras(Rubro.ObtenerSueldoxContrato(_contrato).Total)

          Dim mRubroDets As RubroDetList = Nothing
          mRubroDets = RubroDetList.ObtenerListaLiquidacion(_contrato.OperadorDatos, _contrato)

          Dim _liquidacion As Decimal = 0
          For Each _rubdet As RubroDet In mRubroDets
            If _rubdet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar Then
              .Range("G2").Value = ((-1) * _rubdet.Valor).ToString("0.00")
              _liquidacion = (-1) * _rubdet.Valor
              Exit For
            End If
          Next

          .Range("H2").Value = Utilerias.NumaLetras(_liquidacion)
          .Range("I2").Value = (Math.Round(_liquidacion * 0.3, 2)).ToString("0.00")
          .Range("J2").Value = (Math.Round(_liquidacion * 0.35, 2)).ToString("0.00")

          Dim _saldo As Decimal = 0
          _saldo = Math.Round(_liquidacion - Math.Round(_liquidacion * 0.3, 2) - Math.Round(_liquidacion * 0.35, 2), 2)

          Dim ingresos As Decimal = 0
          Dim egresos As Decimal = 0
          Dim cont As Integer = 0

          'Dim _suma As Decimal = 0
          'Dim _resta As Decimal = 0
          'Dim valorquincena As Decimal = 0
          'For Each _rubrodet As RubroDet In mRubroDets
          '  If _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = 1 And _rubrodet.Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena Then
          '    _suma += _rubrodet.RubDet_Valor
          '  ElseIf _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = -1 And _rubrodet.Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena Then
          '    _resta += _rubrodet.RubDet_Valor
          '  End If
          'Next

          'For Each _rubrodet As RubroDet In mRubroDets
          '  If _rubrodet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
          '    valorquincena = _rubrodet.RubDet_Valor
          '    _rubrodet.RubDet_Valor = (_suma - _resta)
          '  End If
          'Next

          For Each _rubdet As RubroDet In mRubroDets
            If Not _rubdet.Valor = 0 Then
              If _rubdet.PardetTipoRubro.Pardet_DatoDec1 = 1 And Not _rubdet.Pardet_TipoRubro = 11 Then
                ingresos += _rubdet.Valor
                cont += 1
              End If
            End If
          Next

          For Each _rubdet As RubroDet In mRubroDets
            If Not _rubdet.Valor = 0 Then
              If _rubdet.PardetTipoRubro.Pardet_DatoDec1 = -1 And Not _rubdet.Pardet_TipoRubro = 75 Then
                egresos += _rubdet.Valor
              ElseIf _rubdet.Pardet_TipoRubro = 11 Then
                egresos += _rubdet.RubDet_Valor2 * (-1)
              End If
            End If
          Next

          .Range("K1").Value = "Rubro1"
          .Range("L1").Value = "Valor1"
          .Range("M1").Value = "Rubro2"
          .Range("N1").Value = "Valor2"
          .Range("O1").Value = "Rubro3"
          .Range("P1").Value = "Valor3"
          .Range("Q1").Value = "Rubro4"
          .Range("R1").Value = "Valor4"
          .Range("S1").Value = "Rubro5"
          .Range("T1").Value = "Valor5"
          .Range("U1").Value = "Rubro6"
          .Range("V1").Value = "Valor6"
          .Range("W1").Value = "Rubro7"
          .Range("X1").Value = "Valor7"
          .Range("Y1").Value = "Rubro8"
          .Range("Z1").Value = "Valor8"
          .Range("AA1").Value = "Rubro9"
          .Range("AB1").Value = "Valor9"
          .Range("AC1").Value = "Rubro10"
          .Range("AD1").Value = "Valor10"
          .Range("AE1").Value = "Rubro11"
          .Range("AF1").Value = "Valor11"
          .Range("AG1").Value = "Rubro12"
          .Range("AH1").Value = "Valor12"
          .Range("AI1").Value = "Rubro13"
          .Range("AJ1").Value = "Valor13"
          .Range("AK1").Value = "Rubro14"
          .Range("AL1").Value = "Valor14"
          .Range("AM1").Value = "Rubro15"
          .Range("AN1").Value = "Valor15"
          Dim mRubroDetsP As RubroDetList = Nothing
          mRubroDetsP = RubroDetList.ObtenerListaLiquidacionPositivo(_contrato.OperadorDatos, _contrato)
          For t As Integer = 0 To mRubroDetsP.Count - 1
            Select Case t
              Case 0
                .Range("K2").Value = mRubroDetsP(t).TipoRubroString
                .Range("L2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 1
                .Range("M2").Value = mRubroDetsP(t).TipoRubroString
                .Range("N2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 2
                .Range("O2").Value = mRubroDetsP(t).TipoRubroString
                .Range("P2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 3
                .Range("Q2").Value = mRubroDetsP(t).TipoRubroString
                .Range("R2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 4
                .Range("S2").Value = mRubroDetsP(t).TipoRubroString
                .Range("T2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 5
                .Range("U2").Value = mRubroDetsP(t).TipoRubroString
                .Range("V2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 6
                .Range("W2").Value = mRubroDetsP(t).TipoRubroString
                .Range("X2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 7
                .Range("Y2").Value = mRubroDetsP(t).TipoRubroString
                .Range("Z2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 8
                .Range("AA2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AB2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 9
                .Range("AC2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AD2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 10
                .Range("AE2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AF2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 11
                .Range("AG2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AH2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 12
                .Range("AI2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AJ2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 13
                .Range("AK2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AL2").Value = mRubroDetsP(t).Valor.ToString("0.00")
              Case 14
                .Range("AM2").Value = mRubroDetsP(t).TipoRubroString
                .Range("AN2").Value = mRubroDetsP(t).Valor.ToString("0.00")
            End Select
          Next

          .Range("AO1").Value = "ingresos"
          .Range("AO2").Value = ingresos.ToString("0.00")

          .Range("AP1").Value = "Rubro16"
          .Range("AQ1").Value = "Valor16"
          .Range("AR1").Value = "Rubro17"
          .Range("AS1").Value = "Valor17"
          .Range("AT1").Value = "Rubro18"
          .Range("AU1").Value = "Valor18"
          .Range("AV1").Value = "Rubro19"
          .Range("AW1").Value = "Valor19"
          .Range("AX1").Value = "Rubro20"
          .Range("AY1").Value = "Valor20"
          .Range("AZ1").Value = "Rubro21"
          .Range("BA1").Value = "Valor21"
          .Range("BB1").Value = "Rubro22"
          .Range("BC1").Value = "Valor22"
          .Range("BD1").Value = "Rubro23"
          .Range("BE1").Value = "Valor23"
          .Range("BF1").Value = "Rubro24"
          .Range("BG1").Value = "Valor24"
          .Range("BH1").Value = "Rubro25"
          .Range("BI1").Value = "Valor25"
          Dim mRubroDetsN As RubroDetList = Nothing
          mRubroDetsN = RubroDetList.ObtenerListaLiquidacionNegativo(_contrato.OperadorDatos, _contrato)
          For s As Integer = 0 To mRubroDetsN.Count - 1
            Select Case s
              Case 0
                .Range("AP2").Value = mRubroDetsN(s).TipoRubroString
                If mRubroDetsN(s).Pardet_TipoRubro = 11 Then
                  .Range("AQ2").Value = (mRubroDetsN(s).RubDet_Valor2 * -1).ToString("0.00")
                Else
                  .Range("AQ2").Value = mRubroDetsN(s).Valor.ToString("0.00")
                End If
              Case 1
                .Range("AR2").Value = mRubroDetsN(s).TipoRubroString
                .Range("AS2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 2
                .Range("AT2").Value = mRubroDetsN(s).TipoRubroString
                .Range("AU2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 3
                .Range("AV2").Value = mRubroDetsN(s).TipoRubroString
                .Range("AW2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 4
                .Range("AX2").Value = mRubroDetsN(s).TipoRubroString
                .Range("AY2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 5
                .Range("AZ2").Value = mRubroDetsN(s).TipoRubroString
                .Range("BA2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 6
                .Range("BB2").Value = mRubroDetsN(s).TipoRubroString
                .Range("BC2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 7
                .Range("BD2").Value = mRubroDetsN(s).TipoRubroString
                .Range("BE2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 8
                .Range("BF2").Value = mRubroDetsN(s).TipoRubroString
                .Range("BG2").Value = mRubroDetsN(s).Valor.ToString("0.00")
              Case 9
                .Range("BH2").Value = mRubroDetsN(s).TipoRubroString
                .Range("BI2").Value = mRubroDetsN(s).Valor.ToString("0.00")
            End Select
          Next

          .Range("BJ1").Value = "egresos"
          .Range("BJ2").Value = egresos.ToString("0.00")

          .Range("BK1").Value = "Cedula"
          .Range("BK2").Value = _contrato.CedEmpleadoString

          .Range("BL1").Value = "saldo"
          .Range("BL2").Value = _saldo.ToString("0.00")

        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftetransaccionlaboral.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim rutobj As String
        rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\TRANSACCIO  LABORAL.doc"

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