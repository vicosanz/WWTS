Imports Microsoft.Office.Interop
Imports WWTS.General.Reglas

Namespace ExcelReporte
  Public Class Vacacion
    'Public Shared Sub Imprimir_vacacion(ByVal _contrato As Contrato, ByVal _sueldo As Rubro, ByVal _beneficio As BeneficiosSociales, ByVal _rubdetlistvalores As RubroDetList, ByVal _rubdetlistdias As RubroDetList, ByVal _usuario As String)
    Public Shared Sub Imprimir_vacacion(ByVal _contrato As Contrato, ByVal _sueldo As Rubro, ByVal _beneficio As BeneficiosSociales, ByVal _rubdetvacalist As RubroDetList, ByVal _usuario As String)
      Dim _nombreHoja As String = "Hoja1"

      Try
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)
        _nombreHoja = excelWorksheet.Name

        excelApp.Visible = False
        With excelWorksheet
          .Columns().NumberFormat = "@"
          .Range("A1").Value = "Nombre"
          .Range("B1").Value = "Fecha1"
          .Range("C1").Value = "Cargo"
          .Range("D1").Value = "Localidad"
          .Range("E1").Value = "Local"
          .Range("F1").Value = "Sueldo"
          .Range("G1").Value = "Fecha2"
          .Range("H1").Value = "Fecha3"
          .Range("I1").Value = "Fecha4"
          .Range("J1").Value = "Usuario"
          .Range("K1").Value = "Cedula"
          .Range("L1").Value = "Mes1"
          .Range("M1").Value = "Mes2"
          .Range("N1").Value = "Mes3"
          .Range("O1").Value = "Mes4"
          .Range("P1").Value = "Mes5"
          .Range("Q1").Value = "Mes6"
          .Range("R1").Value = "Mes7"
          .Range("S1").Value = "Mes8"
          .Range("T1").Value = "Mes9"
          .Range("U1").Value = "Mes10"
          .Range("V1").Value = "Mes11"
          .Range("W1").Value = "Mes12"
          .Range("X1").Value = "Mes13"
          .Range("Y1").Value = "MesValor1"
          .Range("Z1").Value = "MesValor2"
          .Range("AA1").Value = "MesValor3"
          .Range("AB1").Value = "MesValor4"
          .Range("AC1").Value = "MesValor5"
          .Range("AD1").Value = "MesValor6"
          .Range("AE1").Value = "MesValor7"
          .Range("AF1").Value = "MesValor8"
          .Range("AG1").Value = "MesValor9"
          .Range("AH1").Value = "MesValor10"
          .Range("AI1").Value = "MesValor11"
          .Range("AJ1").Value = "MesValor12"
          .Range("AK1").Value = "MesValor13"
          .Range("AL1").Value = "MesVaca1"
          .Range("AM1").Value = "MesVaca2"
          .Range("AN1").Value = "MesVaca3"
          .Range("AO1").Value = "MesVaca4"
          .Range("AP1").Value = "MesVaca5"
          .Range("AQ1").Value = "MesVaca6"
          .Range("AR1").Value = "MesVaca7"
          .Range("AS1").Value = "MesVaca8"
          .Range("AT1").Value = "MesVaca9"
          .Range("AU1").Value = "MesVaca10"
          .Range("AV1").Value = "MesVaca11"
          .Range("AW1").Value = "MesVaca12"
          .Range("AX1").Value = "MesVaca13"
          .Range("AY1").Value = "subtotal"
          .Range("AZ1").Value = "aporte"
          .Range("BA1").Value = "total"
          .Range("BB1").Value = "totalsueldo"
          .Range("BC1").Value = "MesDias1"
          .Range("BD1").Value = "MesDias2"
          .Range("BE1").Value = "MesDias3"
          .Range("BF1").Value = "MesDias4"
          .Range("BG1").Value = "MesDias5"
          .Range("BH1").Value = "MesDias6"
          .Range("BI1").Value = "MesDias7"
          .Range("BJ1").Value = "MesDias8"
          .Range("BK1").Value = "MesDias9"
          .Range("BL1").Value = "MesDias10"
          .Range("BM1").Value = "MesDias11"
          .Range("BN1").Value = "MesDias12"
          .Range("BO1").Value = "MesDias13"
          .Range("BP1").Value = "totaldias"

          .Range("BQ1").Value = "Fecha5"
          .Range("BR1").Value = "Fecha6"

          .Range("A2").Value = _contrato.EmpleadoString
          .Range("B2").Value = _contrato.FechaString
          .Range("C2").Value = _contrato.CargoString
          .Range("D2").Value = _contrato.PardetDepartamento.PardetPadre.PardetPadre.Pardet_Descripcion
          .Range("E2").Value = _contrato.PardetDepartamento.PardetPadre.Pardet_Descripcion
          .Range("F2").Value = Math.Round((_sueldo.Rubro_EnFindeMes + _sueldo.Rubro_EnQuincena), 2)
          .Range("G2").Value = _beneficio.BenSoc_FechaDesde.ToString("dd-MMM-yy")
          .Range("H2").Value = _beneficio.BenSoc_FechaHasta.ToString("dd-MMM-yy")
          .Range("I2").Value = Now.Date.ToString("dd-MMM-yy")
          .Range("J2").Value = _usuario
          .Range("K2").Value = _contrato.CedEmpleadoString

          Dim t As Integer
          Dim totalsueldo As Decimal = 0
          Dim subtotal As Decimal = 0
          Dim totaldias As Integer = 0
          For t = 0 To _rubdetvacalist.Count - 1
            Select Case t
              Case 0 '1
                .Range("L2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("Y2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AL2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BC2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 1 '2
                .Range("M2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("Z2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AM2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BD2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 2 '3
                .Range("N2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AA2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AN2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BE2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 3 '4
                .Range("O2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AB2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AO2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BF2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 4 '5
                .Range("P2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AC2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AP2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BG2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 5 '6
                .Range("Q2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AD2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AQ2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BH2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 6 '7
                .Range("R2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AE2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AR2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BI2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 7 '8
                .Range("S2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AF2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AS2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BJ2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 8 '9
                .Range("T2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AG2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AT2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BK2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 9 '10
                .Range("U2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AH2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AU2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BL2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 10 '11
                .Range("V2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AI2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AV2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BM2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 11 '12
                .Range("W2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AJ2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AW2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BN2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
              Case 12 '13
                .Range("X2").Value = _rubdetvacalist(t).PerPag_FechaDesde.ToString("MMM-yyyy")
                .Range("AK2").Value = _rubdetvacalist(t).RubDet_Valor.ToString("0.00")
                .Range("AX2").Value = _rubdetvacalist(t).valorvacacion.ToString("0.00")
                .Range("BO2").Value = _rubdetvacalist(t).diasvacacion
                totaldias += _rubdetvacalist(t).diasvacacion
                totalsueldo += _rubdetvacalist(t).RubDet_Valor
                subtotal += Math.Round(_rubdetvacalist(t).valorvacacion, 2)
            End Select
          Next

          Dim aporte As Decimal = 0
          Dim total As Decimal = 0
          'aporte = subtotal * 0.0935
          aporte = _beneficio.BenSoc_Valor * 0.0935
          total = subtotal - Math.Round(aporte, 2)

          '.Range("AY2").Value = Math.Round(subtotal, 2)
          .Range("AY2").Value = _beneficio.BenSoc_Valor.ToString("0.00")
          .Range("AZ2").Value = aporte.ToString("0.00")
          .Range("BA2").Value = total.ToString("0.00")
          .Range("BB2").Value = totalsueldo.ToString("0.00")

          .Range("BP2").Value = totaldias

          If _beneficio.BenSoc_GoceVacaciones Then
            .Range("BQ2").Value = _beneficio.BenSoc_FechaDesdeGoceVacaciones.ToString("dd-MMM-yy")
            .Range("BR2").Value = _beneficio.BenSoc_FechaHastaGoceVacaciones.ToString("dd-MMM-yy")
          Else
            .Range("BQ2").Value = ""
            .Range("BR2").Value = ""
          End If

        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftevacacion.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim rutobj As String
        'rutobj = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\modelovaca.doc"
        rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\reporte_vacacion.doc"

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
        'Connection:="Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" & rutfte & ";Mode=Read;Extended Properties=""HDR=YES;IMEX=1;"";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine T", SQLStatement:="SELECT * FROM `Hoja1$`", SQLStatement1:="", SubType:=1)

        'WordDocument()
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End Sub

  End Class
End Namespace