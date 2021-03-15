Imports Microsoft.Office.Interop
Imports WWTS.General.Reglas
Imports Infoware.Reportes
Imports System.Reflection

Public Class Utilerias
  Public Shared Function NumaLetras(ByVal num As Double) As String
    Dim Result As String = String.Empty
    Dim dec As String
    Dim ent As String

    num = Math.Abs(num)
    ent = Int(num).ToString.Trim
    dec = (Int(Math.Round(Math.Round(num - Int(num), 5) * 100))).ToString("00")

    Dim t As Integer
    For t = 0 To ent.Length - 1
      Dim refpos As Integer = ent.Length - t
      Dim pos3 As Integer = refpos Mod 3

      Dim txtparc As String = ""
      Select Case pos3
        Case 1
          Dim ok As Boolean = True
          If t > 0 Then
            If ent.Chars(t - 1) = "1" Then
              ok = False
            End If
          End If
          If ok Then
            Select Case ent.Chars(t)
              Case "1" : txtparc = "un "
              Case "2" : txtparc = "dos "
              Case "3" : txtparc = "tres "
              Case "4" : txtparc = "cuatro "
              Case "5" : txtparc = "cinco "
              Case "6" : txtparc = "seis "
              Case "7" : txtparc = "siete "
              Case "8" : txtparc = "ocho "
              Case "9" : txtparc = "nueve "
              Case "0" : txtparc = " "
            End Select
          End If
        Case 2
          Select Case ent.Chars(t)
            Case "1"
              Select Case ent.Chars(t + 1)
                Case "1" : txtparc = "once "
                Case "2" : txtparc = "doce "
                Case "3" : txtparc = "trece "
                Case "4" : txtparc = "catorce "
                Case "5" : txtparc = "quince "
                Case "6" : txtparc = "dieciseis "
                Case "7" : txtparc = "diecisiete "
                Case "8" : txtparc = "dieciocho "
                Case "9" : txtparc = "diecinueve "
                Case "0" : txtparc = "diez "
              End Select
            Case "2" : txtparc = IIf(ent.Chars(t + 1) = "0", "veinte ", "veinti")
            Case "3" : txtparc = "treinta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "4" : txtparc = "cuarenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "5" : txtparc = "cincuenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "6" : txtparc = "sesenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "7" : txtparc = "setenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "8" : txtparc = "ochenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "9" : txtparc = "noventa " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "0" : txtparc = ""
          End Select
        Case 0
          Select Case ent.Chars(t)
            Case "1" : txtparc = IIf(ent.Chars(t + 1) = "0" And ent.Chars(t + 2) = "0", "cien ", "ciento ")
            Case "2" : txtparc = "doscientos "
            Case "3" : txtparc = "trescientos "
            Case "4" : txtparc = "cuatrocientos "
            Case "5" : txtparc = "quinientos "
            Case "6" : txtparc = "seiscientos "
            Case "7" : txtparc = "setecientos "
            Case "8" : txtparc = "ochocientos "
            Case "9" : txtparc = "novecientos "
            Case "0" : txtparc = ""
          End Select
      End Select

      Result += txtparc

      Select Case refpos
        Case 4 : Result = Result & "mil "
        Case 7
          If Val(ent.Substring(0, ent.Length - 7 + 1)) > 1 Then
            Result = Result & "millones "
          Else
            Result = Result & "millón "
          End If
        Case 10 : Result = Result & "mil "
        Case 13
          If Val(ent.Substring(0, ent.Length - 13 + 1)) > 1 Then
            Result = Result & "billones "
          Else
            Result = Result & "billón "
          End If
        Case 16 : Result = Result & "mil "
        Case 19
          If Val(ent.Substring(0, ent.Length - 19 + 1)) > 1 Then
            Result = Result & "trillones "
          Else
            Result = Result & "trillón "
          End If
      End Select
    Next

    Result = Result & dec & "/100"
    Return Result
  End Function

  Public Shared Function listameses() As Object()
    Dim meses() As Object
    meses = New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Return meses
  End Function

  Public Shared Sub CombinarCorrespondencia(ByVal _objeto As Object, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Dim _list As IList
    Dim SourceType As Type
    If TypeOf _objeto Is IList Then
      _list = CType(_objeto, IList)
      SourceType = _list(0).GetType()
    Else
      _list = New System.ComponentModel.BindingList(Of Object)
      _list.Add(_objeto)
      SourceType = _objeto.GetType
    End If

    Dim _campos As New List(Of CampoReporteAtributo)
    '<Infoware.Reportes.CampoReporteAtributo("Cliente", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 350, True)> _

    For Each mInfo As PropertyInfo In SourceType.GetProperties
      Dim attrCustom As CampoReporteAtributo = Nothing

      For Each attr As Attribute In Attribute.GetCustomAttributes(mInfo)
        If TypeOf attr Is CampoReporteAtributo Then
          attrCustom = CType(attr, CampoReporteAtributo)
          attrCustom.Campo = mInfo.Name
        End If
      Next

      If attrCustom IsNot Nothing AndAlso Not attrCustom.Ignorar Then
        If mInfo.PropertyType.BaseType Is GetType(Object) Or mInfo.PropertyType.BaseType Is GetType(ValueType) Then
          _campos.Add(attrCustom)
        End If
      End If
    Next

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
        .Columns.NumberFormat = "@"
        Dim t As Integer = 0
        For Each _campo As CampoReporteAtributo In _campos
          t += 1
          .Cells(1, t).value = _campo.Etiqueta
          .Columns(t).columnwidth = IIf(_campo.Tamano / 6.8 > 255, 255, _campo.Tamano / 6.8)
          Select Case _campo.TipoDato
            'Case CampoReporteAtributo.EnumTipoDato.Decimales
            '  .Columns(t).numberformat = "0" & Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator & "00"
            'Case CampoReporteAtributo.EnumTipoDato.Numero
            '  .Columns(t).numberformat = "0"
            Case Else
              .Columns(t).numberformat = "@"
          End Select
        Next

        Dim _row As Integer = 1
        For Each _fila As Object In _list
          t = 0
          _row += 1
          For Each _campo As CampoReporteAtributo In _campos
            t += 1
            Dim obj As Object = GetField(_fila, _campo.Campo)
            Select Case _campo.TipoDato
              Case CampoReporteAtributo.EnumTipoDato.Logico
                .Cells(_row, t).value = IIf(CType(obj, Boolean), "Sí", "No")
              Case CampoReporteAtributo.EnumTipoDato.Decimales
                .Cells(_row, t).value = CDec(obj).ToString("0.00")
              Case CampoReporteAtributo.EnumTipoDato.Fecha
                .Cells(_row, t).value = CDate(obj).ToShortDateString
              Case Else
                .Cells(_row, t).value = obj.ToString
            End Select
          Next
        Next
      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacion.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
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

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  Public Shared Function GetField(ByVal obj As Object, ByVal FieldName As String) As Object
    If TypeOf obj Is DataRowView Then
      ' this is a DataRowView from a DataView
      Return CType(obj, DataRowView).Item(FieldName)

    ElseIf TypeOf obj Is ValueType AndAlso obj.GetType.IsPrimitive Then
      ' this is a primitive value type
      Return obj

    ElseIf TypeOf obj Is String Then
      ' this is a simple string
      Return CStr(obj)

    Else
      ' this is an object or Structure
      Try
        Dim sourcetype As Type = obj.GetType

        ' see if the field is a property
        Dim prop As PropertyInfo = sourcetype.GetProperty(FieldName)

        If prop Is Nothing OrElse Not prop.CanRead Then
          ' no readable property of that name exists - check for a field
          Dim field As FieldInfo = sourcetype.GetField(FieldName)

          If field Is Nothing Then
            ' no field exists either, return the field name
            ' as a debugging indicator
            Return "Campo no válido " & FieldName

          Else
            ' got a field, return its value
            If field.GetValue(obj) Is Nothing Then
              Return String.Empty
            Else
              Return field.GetValue(obj)
            End If
          End If

        Else
          ' found a property, return its value
          Return prop.GetValue(obj, Nothing)
        End If

      Catch ex As Exception
        Return ex.Message
      End Try
    End If
  End Function

End Class
