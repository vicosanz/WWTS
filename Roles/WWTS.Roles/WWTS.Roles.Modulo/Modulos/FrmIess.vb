Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.Globalization.CultureInfo
Imports System.IO
Imports Microsoft.Office.Interop

Public Class FrmIess
  Implements IOpcion

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(value As OperadorDatos)
      mOp = value
      Me.CtlPatrono1.Op = mOp
      Me.CtlPatrono2.Op = mOp
      Me.CtlPatrono3.Op = mOp
      Me.CtlPatrono4.Op = mOp
      Me.CtlTipoContrato1.Op = mOp
      Me.CtlTipoContrato2.Op = mOp
      Me.CtlTipoContrato3.Op = mOp
      Me.CtlTipoContrato4.Op = mOp

      Me.cbomes.ValueMember = "Numero"
      Me.cbomes.DisplayMember = "Descripcion"
      Me.cbomes.DataSource = Enumerados.MesesdelAnioList
      Me.cbomes.SelectedIndex = Month(Now.Date) - 1

      Me.cbomesdesde.ValueMember = "Numero"
      Me.cbomesdesde.DisplayMember = "Descripcion"
      Me.cbomesdesde.DataSource = Enumerados.MesesdelAnioList
      Me.cbomesdesde.SelectedIndex = Month(Now.Date) - 1

      Me.cbomeshasta.ValueMember = "Numero"
      Me.cbomeshasta.DisplayMember = "Descripcion"
      Me.cbomeshasta.DataSource = Enumerados.MesesdelAnioList
      Me.cbomeshasta.SelectedIndex = Month(Now.Date) - 1

      Me.numanio.Text = Year(Now.Date).ToString
      Me.numaniodesde.Text = Year(Now.Date).ToString
      Me.numaniohasta.Text = Year(Now.Date).ToString
      If Not mOp Is Nothing Then
        Me.CtlPatrono1.llenar_datos()
        Me.CtlPatrono2.llenar_datos()
        Me.CtlPatrono3.llenar_datos()
        Me.CtlPatrono4.llenar_datos()
        Me.CtlTipoContrato1.llenar_datos()
        Me.CtlTipoContrato2.llenar_datos()
        Me.CtlTipoContrato3.llenar_datos()
        Me.CtlTipoContrato4.llenar_datos()
      End If
    End Set
  End Property

  Private Sub btnrecmes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecmes.Click
    Dim desde As Date
    Dim hasta As Date
    desde = DateSerial(Me.numanio.Value, cbomes.SelectedIndex + 1, 1)
    hasta = DateSerial(IIf(cbomes.SelectedIndex + 2 > 12, Me.numanio.Value + 1, Me.numanio.Value), IIf(cbomes.SelectedIndex + 2 > 12, 1, cbomes.SelectedIndex + 2), 1)
    hasta = hasta.AddDays(-1)

    If chkvolverrec.Checked Then
      Dim _dias As New DiaAsistenciaList
      _dias = DiaAsistenciaList.ObtenerLista(Op, Me.CtlPatrono1.Patrono, desde, hasta)
      For Each _dia As DiaAsistencia In _dias
        _dia.Guardar()
      Next
      If MsgBox("Recalculo diario terminado. ¿Desea continuar recalculando el registro mensual de sueldos?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
        Exit Sub
      End If
    End If
    calcularmes(Me.numanio.Value, cbomes.SelectedIndex + 1)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Recalculo sueldos mensuales del mes", Me.cbomes.SelectedText, Me.numanio.Value, Me.CtlPatrono1.Patrono.NombreCompleto, Me.CtlTipoContrato1.TipoContrato.TipCon_Descripcion))

    mostrarmes()
  End Sub

  Sub calcularmes(ByVal _anio As Integer, ByVal _mes As Integer)
    Dim _sueldos As SueldoMensualList
    _sueldos = SueldoMensualList.RetornarSueldoMensualesRecalculados(Me.mOp, Nothing, Me.CtlPatrono1.Patrono, Me.CtlTipoContrato1.TipoContrato, _anio, _mes)
    If Not _sueldos Is Nothing Then
      For Each _sueldo As SueldoMensual In _sueldos
        _sueldo.Guardar()
      Next
    End If
  End Sub

  Private Sub btmostrarmes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmostrarmes.Click
    mostrarmes()
  End Sub

  Sub mostrarmes()
    Me.dgmes.DataSource = Nothing
    If Me.CtlPatrono1.Patrono Is Nothing Then
      Exit Sub
    End If
    Me.dgmes.DataSource = SueldoMensualList.RetornarSueldoMensuales(Op, Me.CtlPatrono1.Patrono, CtlTipoContrato1.TipoContrato, Me.numanio.Value, Me.cbomes.SelectedIndex + 1)
  End Sub

  Private Sub btnmostrariess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrariess.Click
    verificar30dias()

    Me.dgiess.DataSource = IESS.RetornarIESSES(mOp, Me.CtlPatrono2.Patrono, Me.chksolocontrato.Checked, Me.CtlTipoContrato2.TipoContrato, Me.dtdesde.Value, Me.dthasta.Value)
  End Sub

  Sub verificar30dias()
    Dim _diffecha As TimeSpan
    _diffecha = Me.dthasta.Value.Subtract(Me.dtdesde.Value)
    Me.lblerror.Text = ""
    Me.lblerror.Visible = False
    If Math.Abs(30 - (_diffecha.Days + 1)) > 3 Then
      Me.lblerror.Visible = True
      Me.lblerror.Text = "Usted ha seleccionado un número de días diferente a 30"
    End If
  End Sub

  Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
    Dim _listiess As IESSList
    verificar30dias()

    _listiess = IESS.RetornarIESSES(mOp, Me.CtlPatrono2.Patrono, Me.chksolocontrato.Checked, Me.CtlTipoContrato2.TipoContrato, Me.dtdesde.Value, Me.dthasta.Value)
    Imprimir_iess(_listiess, Me.CtlPatrono2.Patrono, Me.CtlTipoContrato2.TipoContrato, Me.dtdesde.Value.Date, Me.dthasta.Value.Date)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Exportó resumen del iess", Me.dtdesde.Value.ToShortDateString, Me.dthasta.Value.ToShortDateString, Me.CtlPatrono2.Patrono.NombreCompleto, IIf(Me.chksolocontrato.Checked, Me.CtlTipoContrato2.TipoContrato.TipCon_Descripcion, "")))
  End Sub

  Public Shared Sub Imprimir_iess(ByVal _listiess As IESSList, ByVal _patrono As Patrono, ByVal _tipocontrato As TipoContrato, ByVal _desde As Date, ByVal _hasta As Date)
    If _listiess Is Nothing Then
      MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet
        .Range("A1").Value = "Listado de IESS desde " & _desde.ToShortDateString & " hasta " & _hasta.ToShortDateString
        .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        .Range("A1").Font.Bold = True
        .Range("A1:N1").Merge()
        .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        .Range("A2:N2").Merge()
        .Range("A2").Value = "Patrono " & _patrono.NombreCompleto & " : Tipo de contrato " & _tipocontrato.TipCon_Descripcion
        .Columns().ColumnWidth = 80
        .Range("A5").Value = "Código"
        .Columns("A:A").ColumnWidth = 8
        .Columns("A:A").numberformat = "@"
        .Range("B5").Value = "Cédula"
        .Columns("B:B").ColumnWidth = 8
        .Columns("B:B").numberformat = "@"
        .Range("C5").Value = "Nombres y Apellidos"
        .Columns("C:C").ColumnWidth = 13
        .Range("D5").Value = "C. IESS"
        .Columns("D:D").ColumnWidth = 35
        .Columns("D:D").ColumnWidth = 8
        .Columns("D:D").numberformat = "@"
        .Range("E5").Value = "Asistencia"
        .Columns("E:E").ColumnWidth = 8
        .Columns("E:E").numberformat = "0"
        .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("F5").Value = "Faltas"
        .Columns("F:F").ColumnWidth = 8
        .Columns("F:F").numberformat = "0"
        .Columns("F:F").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("G5").Value = "H Trab"
        .Columns("G:G").ColumnWidth = 8
        .Columns("G:G").numberformat = "0"
        .Columns("G:G").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("H5").Value = "Sueldos"
        .Columns("H:H").ColumnWidth = 12
        .Columns("H:H").numberformat = "0"
        .Columns("H:H").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("I5").Value = "HLV"
        .Columns("I:I").ColumnWidth = 8
        .Columns("I:I").numberformat = "0"
        .Columns("I:I").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("J5").Value = "HSDF"
        .Columns("J:J").ColumnWidth = 8
        .Columns("J:J").numberformat = "0"
        .Columns("J:J").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("K5").Value = "Valor HE"
        .Columns("K:K").ColumnWidth = 12
        .Columns("K:K").numberformat = "0"
        .Columns("K:K").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("L5").Value = "IESS"
        .Columns("L:L").ColumnWidth = 12
        .Columns("L:L").numberformat = "0"
        .Columns("L:L").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("M5").Value = "Entrada"
        .Columns("M:M").ColumnWidth = 8
        .Columns("M:M").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern
        .Range("N5").Value = "Salida"
        .Columns("N:N").ColumnWidth = 8
        .Columns("N:N").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern

        Dim t As Integer = 0
        For Each _iess As IESS In _listiess
          .Cells(6 + t, 1).value = _iess.Entida_Codigo
          .Cells(6 + t, 2).value = _iess.Cedula
          .Cells(6 + t, 3).value = _iess.Nombres
          .Cells(6 + t, 4).value = _iess.Per_ciess
          .Cells(6 + t, 5).value = _iess.Asistencia
          .Cells(6 + t, 6).value = _iess.Faltas
          .Cells(6 + t, 7).value = _iess.Htrab

          .Cells(6 + t, 8).value = _iess.ValSueldo

          .Cells(6 + t, 9).value = _iess.Hlv
          .Cells(6 + t, 10).value = _iess.Hsdf

          .Cells(6 + t, 11).value = _iess.ValHorasExtras
          .Cells(6 + t, 12).value = _iess.ValIESS
          If Not _iess.Desde = Nothing Then .Cells(6 + t, 13).value = _iess.Desde
          If Not _iess.Hasta = Nothing Then .Cells(6 + t, 14).value = _iess.Hasta
          t += 1
        Next
        With .Range("A5:N5")
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
        .Columns("E:E").EntireColumn.AutoFit()
        .Columns("F:F").EntireColumn.AutoFit()
        .Columns("G:G").EntireColumn.AutoFit()
        .Columns("H:H").EntireColumn.AutoFit()
        .Columns("I:I").EntireColumn.AutoFit()
        .Columns("J:J").EntireColumn.AutoFit()
        .Columns("K:K").EntireColumn.AutoFit()
        .Columns("L:L").EntireColumn.AutoFit()
        .Columns("M:M").EntireColumn.AutoFit()
        .Columns("N:N").EntireColumn.AutoFit()
      End With
      With excelWorksheet.PageSetup
        .Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintTitleRows = "$1:$5"
        .PrintTitleColumns = ""
        .LeftHeader = ""
        .CenterHeader = "Página &P de &N"
        .RightHeader = ""
        .LeftFooter = "Infoware"
        .CenterFooter = "Página &P"
        .RightFooter = "&D"
      End With

      excelApp.Visible = True
      excelWorksheet.PrintPreview()
      'excelApp.Quit()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
    Dim iesscol As IESSList
    iesscol = IESS.RetornarIESSES(mOp, Me.CtlPatrono2.Patrono, Me.chksolocontrato.Checked, Me.CtlTipoContrato2.TipoContrato, Me.dtdesde.Value, Me.dthasta.Value)
    If iesscol Is Nothing OrElse iesscol.Count = 0 Then
      Exit Sub
    End If

    Dim _configroles As New ConfigRoles(Me.mOp, Me.CtlPatrono2.Patrono.Pais, False)
    Dim anioactual As Integer = Me.dthasta.Value.Year
    Dim mesactual As Integer = Me.dthasta.Value.Month

    FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
    If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

      Try
        Dim _archivoavisoentrada As String = FolderBrowserDialog1.SelectedPath & "\avisoent.txt"
        File.Delete(_archivoavisoentrada)
        Dim swaven As StreamWriter = File.CreateText(_archivoavisoentrada)

        Dim _archivoavisosalida As String = FolderBrowserDialog1.SelectedPath & "\avisosal.txt"
        File.Delete(_archivoavisosalida)
        Dim swavsa As StreamWriter = File.CreateText(_archivoavisosalida)

        Dim _archivodiasnolab As String = FolderBrowserDialog1.SelectedPath & "\diasnolab.txt"
        File.Delete(_archivodiasnolab)
        Dim swdinl As StreamWriter = File.CreateText(_archivodiasnolab)

        Dim _archivoextrasld As String = FolderBrowserDialog1.SelectedPath & "\extrasueldo.txt"
        File.Delete(_archivoextrasld)
        Dim swextsld As StreamWriter = File.CreateText(_archivoextrasld)

        For Each _iess As IESS In iesscol
          If Not _iess.Desde = Nothing Then
            swaven.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15}", Me.CtlPatrono2.Patrono.Ruc.Trim, "0001", anioactual, mesactual, "ENT", _iess.Cedula, _iess.Desde.ToString("yyyyMMdd"), _iess.Desde.ToString("yyyyMMdd"), "1", "R", "2", IIf(_iess.Contrato.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, "21", "06"), "TRABAJADOR AGRICOLA", "0105000101", CType(IIf(_iess.Contrato.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, _configroles.Cnfrol_valorhoraiess, _iess.Sueldo + _iess.Antiguedad), Decimal).ToString("0.00").Replace(",", "."), "P")
          End If
          If Not _iess.Hasta = Nothing Then
            swavsa.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", Me.CtlPatrono2.Patrono.Ruc.Trim, "0001", anioactual, mesactual, "SAL", _iess.Cedula, _iess.Hasta.ToString("yyyyMMdd"), _iess.Contrato.PardetMotivoSalida.Pardet_DatoStr1)
          End If

          If _iess.Faltas > 0 Then
            swdinl.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", Me.CtlPatrono2.Patrono.Ruc.Trim, "0001", anioactual, mesactual, "MND", _iess.Cedula, Me.dtdesde.Value.ToString("yyyyMMdd"), _iess.Faltas.ToString("00"))
          End If

          If _iess.ValHorasExtras > 0 Then
            swextsld.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", Me.CtlPatrono2.Patrono.Ruc.Trim, "0001", anioactual, mesactual, "INS", _iess.Cedula, _iess.ValHorasExtras.ToString("0.00").Replace(",", "."), "O")
          End If
        Next
        swaven.Close()
        swavsa.Close()
        swdinl.Close()
        swextsld.Close()

        Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Adicion, String.Format("{0} {1} {2} {3} {4}", "Generó resumen del iess", Me.dtdesde.Value.ToShortDateString, Me.dthasta.Value.ToShortDateString, Me.CtlPatrono2.Patrono.NombreCompleto, IIf(Me.chksolocontrato.Checked, Me.CtlTipoContrato2.TipoContrato.TipCon_Descripcion, "")))

      Catch ex As Exception
        MsgBox(ex.Message)
      End Try
      '***************************************
    End If


  End Sub

  Private Sub chksolocontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolocontrato.CheckedChanged
    Me.CtlTipoContrato2.Enabled = Me.chksolocontrato.Checked
  End Sub

  Private Sub chksolocontrato3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolocontrato3.CheckedChanged
    Me.CtlTipoContrato3.Enabled = Me.chksolocontrato3.Checked
  End Sub

  Private Sub btnmostraracum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostraracum.Click
    Me.dgsueldacum.DataSource = AcumSueldo.RetornarAcumSueldos(mOp, Me.chksolopatrono3.Checked, Me.CtlPatrono3.Patrono, Me.chksolocontrato3.Checked, Me.CtlTipoContrato3.TipoContrato, Me.numaniodesde.Value, Me.cbomesdesde.SelectedIndex + 1, Me.numaniohasta.Value, Me.cbomeshasta.SelectedIndex + 1)
  End Sub

  Private Sub btnexportaracum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportaracum.Click
    Dim _listacum As AcumSueldoList
    _listacum = AcumSueldo.RetornarAcumSueldos(mOp, Me.chksolopatrono3.Checked, Me.CtlPatrono3.Patrono, Me.chksolocontrato3.Checked, Me.CtlTipoContrato3.TipoContrato, Me.numaniodesde.Value, Me.cbomesdesde.SelectedIndex + 1, Me.numaniohasta.Value, Me.cbomeshasta.SelectedIndex + 1)
    Imprimir_acum(_listacum, Me.CtlPatrono3.Patrono, Me.CtlTipoContrato3.TipoContrato, Me.numaniodesde.Value, Me.cbomesdesde.SelectedIndex + 1, Me.numaniohasta.Value, Me.cbomeshasta.SelectedIndex + 1)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} desde {1} {2} hasta {3} {4} {5} {6}", "Exportó acumulados de sueldos", Me.cbomesdesde.SelectedText, Me.numaniodesde.Value, Me.cbomeshasta.SelectedText, Me.numaniohasta.Value, IIf(Me.chksolocontrato3.Checked, Me.CtlPatrono3.Patrono.NombreCompleto, ""), IIf(Me.chksolocontrato3.Checked, Me.CtlTipoContrato3.TipoContrato.TipCon_Descripcion, "")))
  End Sub

  Public Sub Imprimir_acum(ByVal _listacum As AcumSueldoList, ByVal _patrono As Patrono, ByVal _tipocontrato As TipoContrato, ByVal _aniodesde As Integer, ByVal _mesdesde As Integer, ByVal _aniohasta As Integer, ByVal _meshasta As Integer)
    If _listacum Is Nothing Then
      MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet
        .Range("A1").Value = "Listado de Sueldos acumulados desde " & _aniodesde.ToString & "-" & _mesdesde.ToString & " hasta " & _aniohasta.ToString & "-" & _meshasta.ToString
        .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        .Range("A1").Font.Bold = True
        .Range("A1:N1").Merge()
        .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        .Range("A2:N2").Merge()
        .Range("A2").Value = "Patrono " & _patrono.NombreCompleto & " : Tipo de contrato " & _tipocontrato.TipCon_Descripcion
        .Columns().ColumnWidth = 80
        .Range("A5").Value = "Código"
        .Columns("A:A").ColumnWidth = 8
        .Columns("A:A").numberformat = "@"
        .Range("B5").Value = "Cédula"
        .Columns("B:B").ColumnWidth = 8
        .Columns("B:B").numberformat = "@"
        .Range("C5").Value = "Nombres y Apellidos"
        .Columns("C:C").ColumnWidth = 13
        .Range("D5").Value = "Días trab"
        .Columns("D:D").ColumnWidth = 35
        .Columns("D:D").ColumnWidth = 8
        .Columns("D:D").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Range("E5").Value = "Días vac"
        .Columns("E:E").ColumnWidth = 8
        .Columns("E:E").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("F5").Value = "Sueldos"
        .Columns("F:F").ColumnWidth = 8
        .Columns("F:F").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("F:F").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("G5").Value = "Adicional"
        .Columns("G:G").ColumnWidth = 8
        .Columns("G:G").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("G:G").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("H5").Value = "Vacaciones"
        .Columns("H:H").ColumnWidth = 8
        .Columns("H:H").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("H:H").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("I5").Value = "DecimoTercero"
        .Columns("I:I").ColumnWidth = 8
        .Columns("I:I").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("I:I").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("J5").Value = "DecimoCuarto"
        .Columns("J:J").ColumnWidth = 8
        .Columns("J:J").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("J:J").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("K5").Value = "DecimoTerceroCalc"
        .Columns("K:K").ColumnWidth = 8
        .Columns("K:K").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("K:K").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("L5").Value = "DecimoCuartoCalc"
        .Columns("L:L").ColumnWidth = 8
        .Columns("L:L").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("L:L").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("M5").Value = "VacacionesCalc"
        .Columns("M:M").ColumnWidth = 8
        .Columns("M:M").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("M:M").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("N5").Value = "Direccion"
        .Columns("N:N").ColumnWidth = 100
        .Columns("N:N").numberformat = "@"

        .Range("O5").Value = "Tipo contrato"
        .Columns("O:O").ColumnWidth = 60
        .Columns("O:O").numberformat = "@"

        Dim t As Integer
        For Each _sueldo As AcumSueldo In _listacum
          .Cells(6 + t, 1).value = _sueldo.Entida_Codigo
          .Cells(6 + t, 2).value = _sueldo.Cedula
          .Cells(6 + t, 3).value = _sueldo.Nombres
          .Cells(6 + t, 4).value = _sueldo.SueMen_diastrab
          .Cells(6 + t, 5).value = _sueldo.SueMen_diasvac
          .Cells(6 + t, 6).value = _sueldo.SueMen_sueldo
          .Cells(6 + t, 7).value = _sueldo.SueMen_antiguedad
          .Cells(6 + t, 8).value = _sueldo.SueMen_vacaciones
          .Cells(6 + t, 9).value = _sueldo.DecimoTercero
          .Cells(6 + t, 10).value = _sueldo.DecimoCuarto
          .Cells(6 + t, 11).value = _sueldo.DecimoTerceroCalculado
          .Cells(6 + t, 12).value = _sueldo.DecimoCuartoCalculado
          .Cells(6 + t, 13).value = _sueldo.VacacionesCalculado
          .Cells(6 + t, 14).value = _sueldo.Contrato.Empleado.Entidadnatural.Entidad.DireccionesString
          .Cells(6 + t, 15).value = _sueldo.Contrato.Tipocontrato.TipCon_Descripcion
          t += 1
        Next
        With .Range("A5:j5")
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
        .Columns("E:E").EntireColumn.AutoFit()
        .Columns("F:F").EntireColumn.AutoFit()
        .Columns("G:G").EntireColumn.AutoFit()
        .Columns("H:H").EntireColumn.AutoFit()
        .Columns("I:I").EntireColumn.AutoFit()
        .Columns("J:J").EntireColumn.AutoFit()
        .Columns("K:K").EntireColumn.AutoFit()
        .Columns("L:L").EntireColumn.AutoFit()
        .Columns("M:M").EntireColumn.AutoFit()
      End With
      With excelWorksheet.PageSetup
        .Orientation = Excel.XlPageOrientation.xlLandscape
        .PrintTitleRows = "$1:$5"
        .PrintTitleColumns = ""
        .LeftHeader = ""
        .CenterHeader = "Página &P de &N"
        .RightHeader = ""
        .LeftFooter = "Infoware"
        .CenterFooter = "Página &P"
        .RightFooter = "&D"
      End With

      excelApp.Visible = True
      excelWorksheet.PrintPreview()
      'excelApp.Quit()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    If Me.CtlPatrono1.Patrono Is Nothing Then
      Exit Sub
    End If
    Dim sueldos As SueldoMensualList
    sueldos = SueldoMensualList.RetornarSueldoMensuales(Op, Me.CtlPatrono1.Patrono, CtlTipoContrato1.TipoContrato, Me.numanio.Value, Me.cbomes.SelectedIndex + 1)
    Exportar_sueldomensual(sueldos)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Exportó Sueldos mensuales del mes", Me.cbomes.SelectedText, Me.numanio.Value, Me.CtlPatrono1.Patrono.NombreCompleto, Me.CtlTipoContrato1.TipoContrato.TipCon_Descripcion))
  End Sub
  Public Sub Exportar_sueldomensual(ByVal _sueldos As SueldoMensualList)
    If _sueldos Is Nothing Then
      MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet

        .Columns().ColumnWidth = 80
        .Range("A1").Value = "Código"
        .Columns("A:A").ColumnWidth = 8
        .Columns("A:A").numberformat = "@"
        .Range("B1").Value = "Cédula"
        .Columns("B:B").ColumnWidth = 8
        .Columns("B:B").numberformat = "@"
        .Range("C1").Value = "Nombres y Apellidos"
        .Columns("C:C").ColumnWidth = 13
        .Range("D1").Value = "C. IESS"
        .Columns("D:D").ColumnWidth = 35
        .Columns("D:D").ColumnWidth = 8
        .Columns("D:D").numberformat = "@"
        .Range("E1").Value = "Dias trab"
        .Columns("E:E").ColumnWidth = 8
        .Columns("E:E").numberformat = "0"
        .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("F1").Value = "Días vac."
        .Columns("F:F").ColumnWidth = 8
        .Columns("F:F").numberformat = "0"
        .Columns("F:F").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("G1").Value = "Sueldo"
        .Columns("G:G").ColumnWidth = 12
        .Columns("G:G").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("G:G").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("H1").Value = "Adicional"
        .Columns("H:H").ColumnWidth = 12
        .Columns("H:H").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("H:H").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("I1").Value = "Vacaciones"
        .Columns("I:I").ColumnWidth = 8
        .Columns("I:I").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("I:I").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Range("J1").Value = "IESS Personal"
        .Columns("J:J").ColumnWidth = 12
        .Columns("J:J").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("J:J").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        .Range("K1").Value = "IESS Patronal"
        .Columns("K:K").ColumnWidth = 12
        .Columns("K:K").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        .Columns("K:K").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        Dim t As Integer = 0
        For Each _iess As SueldoMensual In _sueldos
          .Cells(2 + t, 1).value = _iess.Contrato.Empleado.Entida_Codigo
          .Cells(2 + t, 2).value = _iess.Contrato.Empleado.Cedula
          .Cells(2 + t, 3).value = _iess.Contrato.Empleado.NombreCompleto
          .Cells(2 + t, 4).value = _iess.Contrato.Empleado.CarnetSeguro
          .Cells(2 + t, 5).value = _iess.SueMen_DiasTrab
          .Cells(2 + t, 6).value = _iess.SueMen_DiasVac
          .Cells(2 + t, 7).value = _iess.SueMen_Sueldo

          .Cells(2 + t, 8).value = _iess.SueMen_Antiguedad

          .Cells(2 + t, 9).value = _iess.SueMen_Vacaciones
          .Cells(2 + t, 10).value = _iess.IESSPersonal

          .Cells(2 + t, 11).value = _iess.IESSPatronal
          t += 1
        Next
        .Columns("B:B").EntireColumn.AutoFit()
        .Columns("C:C").EntireColumn.AutoFit()
        .Columns("D:D").EntireColumn.AutoFit()
        .Columns("E:E").EntireColumn.AutoFit()
        .Columns("F:F").EntireColumn.AutoFit()
        .Columns("G:G").EntireColumn.AutoFit()
        .Columns("H:H").EntireColumn.AutoFit()
        .Columns("I:I").EntireColumn.AutoFit()
        .Columns("J:J").EntireColumn.AutoFit()
        .Columns("K:K").EntireColumn.AutoFit()
      End With
      With excelWorksheet.PageSetup
        .Orientation = Excel.XlPageOrientation.xlLandscape
        '  .PrintTitleRows = "$1:$5"
        .PrintTitleColumns = ""
        .LeftHeader = ""
        .CenterHeader = "Página &P de &N"
        .RightHeader = ""
        .LeftFooter = "Infoware"
        .CenterFooter = "Página &P"
        .RightFooter = "&D"
      End With

      excelApp.Visible = True
      excelWorksheet.PrintPreview()
      'excelApp.Quit()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub chksolopatrono3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolopatrono3.CheckedChanged
    Me.CtlPatrono3.Enabled = Me.chksolopatrono3.Checked
  End Sub

  Private WithEvents _RegistroIESSs As RegistroIESSList

  Private Sub btnmostrarregiess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarregiess.Click
    'Me.TipoContratoListBindingSource.DataSource = TipoContratoList.ObtenerLista(mOp)
    Me.PatronoListBindingSource.DataSource = PatronoList.ObtenerLista(mOp)
    _RegistroIESSs = RegistroIESSList.ObtenerLista(mOp, Me.CtlPatrono4.Patrono, Me.CtlTipoContrato4.TipoContrato)
    Me.RegistroIESSListBindingSource.DataSource = _RegistroIESSs
  End Sub

  Private Sub dgregiess_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgregiess.CellContentClick

  End Sub

  Private Sub dgregiess_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgregiess.RowValidating
    Dim _regiess As RegistroIESS
    If dgregiess.CurrentRow.Index = -1 Then
      Exit Sub
    End If
    _regiess = CType(Me.RegistroIESSListBindingSource.DataSource, RegistroIESSList)(dgregiess.CurrentRow.Index)
    e.Cancel = Not _regiess.Guardar

    If Not e.Cancel Then
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Adicion, String.Format("{0} {1} {2}", "Registró Pagos al IESS", _regiess.RegIES_Anio, _regiess.RegIES_Mes))
    End If
  End Sub

  Private Sub dgregiess_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgregiess.UserAddedRow

  End Sub

  Private Sub dgregiess_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgregiess.UserDeletingRow
    Dim _regiess As RegistroIESS
    If dgregiess.CurrentRow.Index = -1 Then
      Exit Sub
    End If
    _regiess = CType(Me.RegistroIESSListBindingSource.DataSource, RegistroIESSList)(dgregiess.CurrentRow.Index)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Adicion, String.Format("{0} {1} {2}", "Registró Pagos al IESS", _regiess.RegIES_Anio, _regiess.RegIES_Mes))

    e.Cancel = Not _regiess.Eliminar

    If Not e.Cancel Then
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{0} {1} {2}", "Eliminó Pagos al IESS", _regiess.RegIES_Anio, _regiess.RegIES_Mes))
    End If
  End Sub

  Private Sub _RegistroIESSs_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles _RegistroIESSs.AddingNew
    Dim _regiess As RegistroIESS
    _regiess = New RegistroIESS(mOp, Me.CtlPatrono4.Patrono, Me.CtlTipoContrato4.TipoContrato, Now.Year, Now.Month, True)
    e.NewObject = _regiess
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property
End Class