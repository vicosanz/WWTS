Imports Microsoft.Office.Interop
Imports WWTS.General.Reglas

Namespace ExcelReporte
  Public Class LlamadaAtencion
    Public Shared Sub Imprimir_llamadaatencion(ByVal _llamadaatencion As Roles.Reglas.LlamadaAtencion)
      Dim _nombreHoja As String = "Hoja1"

      If _llamadaatencion Is Nothing Then
        MsgBox("No existen Llamadas de atención seleccionadas", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If

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
          .Range("C1").Value = "Fecha"
          .Range("D1").Value = "Descripcion"
          .Range("E1").Value = "Articulos"

          .Range("A2").Value = _llamadaatencion.Contrato.EmpleadoString
          .Range("B2").Value = _llamadaatencion.PardetTipoLlamadoString
          .Range("C2").Value = _llamadaatencion.Llamad_Fecha.ToLongDateString
          .Range("D2").Value = _llamadaatencion.Llamad_Descripcion
          .Range("E2").Value = _llamadaatencion.PardetTipoLlamado.Pardet_Leyenda
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

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(TipoContratoFormato.ObtenerFormato(_llamadaatencion.Contrato.Tipocontrato, Enumerados.enumFormatoxTipoContrato.LlamadaAtencion))
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