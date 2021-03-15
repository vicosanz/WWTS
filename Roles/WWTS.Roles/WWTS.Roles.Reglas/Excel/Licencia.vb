Imports Microsoft.Office.Interop
Imports WWTS.General.Reglas

Namespace ExcelReporte
  Public Class Licencia
    Public Shared Sub Imprimir_licencia(ByVal _licencia As WWTS.General.Reglas.Licencia)
      If _licencia Is Nothing Then
        MsgBox("No existen Licencias seleccionadas", MsgBoxStyle.Information, "Información")
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
          .Range("A1").Value = "Empleado"
          .Range("B1").Value = "Asunto"
          .Range("C1").Value = "Desde"
          .Range("D1").Value = "Hasta"

          .Range("A2").Value = _licencia.Contrato.EmpleadoString
          .Range("B2").Value = "Licencia " + _licencia.PardetLicenciaString
          .Range("C2").Value = _licencia.Licenc_Desde.ToLongDateString
          .Range("D2").Value = _licencia.Licenc_Hasta.ToLongDateString
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftelicencia.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(_licencia.PardetLicencia.Pardet_DatoStr1)
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