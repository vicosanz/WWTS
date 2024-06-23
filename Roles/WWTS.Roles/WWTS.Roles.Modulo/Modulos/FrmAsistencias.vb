Imports System
Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop

Public Class FrmAsistencias
  Implements IOpcion

  Private Sub FrmAsistencias_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar

    Me.CtlBuscaEmpleadosPeriodo1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleadosPeriodo1.Op = Sistema.OperadorDatos

    Me.CtlAsistencia1.Op = Sistema.OperadorDatos
  End Sub

#Region "CtlBuscaEmpleadosPeriodo1"
  Private Sub CtlBuscaEmpleadosPeriodo1_CambioEmpleado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleadosPeriodo1.CambioEmpleado
    Dim _asist As Asistencia
    If CtlBuscaEmpleadosPeriodo1.SonContratos Then
      _asist = New Asistencia(Sistema.OperadorDatos, Me.CtlBuscaEmpleadosPeriodo1.Contrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
    ElseIf CtlBuscaEmpleadosPeriodo1.SonAsistencias Then
      _asist = Me.CtlBuscaEmpleadosPeriodo1.Asistencia
    Else
      _asist = New Asistencia(Sistema.OperadorDatos, Me.CtlBuscaEmpleadosPeriodo1.Empleado, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
      _asist.Patrono = Me.CtlBuscaEmpleadosPeriodo1.Patrono
    End If
    _asist.Recargar()
    Me.CtlAsistencia1.Asistencia = _asist
  End Sub

  Private Sub CtlBuscaEmpleadosPeriodo1_Generar(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleadosPeriodo1.GenerarAsistencia
    Dim contratos As ContratoList
    contratos = CType(sender, ContratoList)
    If contratos Is Nothing Then
      MsgBox("Seleccione al menos un empleado", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    For Each _contrato As Contrato In contratos
      Dim _asist As Asistencia
      _asist = New Asistencia(Sistema.OperadorDatos, _contrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
      _asist.Recargar()
      _asist.Calcular(True, True)
      Me.CtlAsistencia1.Asistencia = _asist
      Me.CtlAsistencia1.Generar()
    Next
  End Sub

  Private Sub CtlBuscaEmpleadosPeriodo1_GenerarAsistenciaAreaLote(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleadosPeriodo1.GenerarAsistenciaAreaLote
    Dim contratos As ContratoList
    contratos = CType(sender, ContratoList)
    If contratos Is Nothing Then
      MsgBox("Seleccione al menos un empleado", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    Dim f As New FrmCambiarAreaLote(Sistema, Enumerados.EnumOpciones.RegistrarAsistencias)

    If f.ShowDialog = DialogResult.OK Then
      For Each _contrato As Contrato In contratos
        Dim _asist As Asistencia
        _asist = New Asistencia(Sistema.OperadorDatos, _contrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
        _asist.Recargar()
        _asist.Calcular(True, True)
        Me.CtlAsistencia1.Asistencia = _asist
        Me.CtlAsistencia1.Generar(f.Area, f.Lote)
      Next
    End If


  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Me.MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

  Private Sub ListadoTomaAsistenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoTomaAsistenciaToolStripMenuItem.Click
    If Not (Me.CtlBuscaEmpleadosPeriodo1.rdopersactsec.Checked AndAlso Me.CtlBuscaEmpleadosPeriodo1.CtlSeccion1.ParametroDet IsNot Nothing) Then
      MsgBox("Debe seleccionar una sección primero", MsgBoxStyle.Exclamation, "Error")
      Exit Sub
    End If

    Me.CtlBuscaEmpleadosPeriodo1.llenar_datos()

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet
        .Range("A2").Value = "REPORTE PARA TOMA DE ASISTENCIA"
        .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        .Range("A2").Font.Bold = True
        .Range("A2:F2").Merge()

        .Range("A3").Value = "Día:"
        .Range("A4").Value = "Sección:"
        .Range("A5").Value = "Jefe sección:"
        .Range("C5").Value = "Firma:"
        .Range("A3").Font.Bold = True
        .Range("A4").Font.Bold = True
        .Range("A5").Font.Bold = True
        .Range("C5").Font.Bold = True

        .Range("B3").Value = Enumerados.DiaSemanaList.RetornarDescripcion(CInt(Me.CtlAsistencia1.Desde.DayOfWeek)) & " - " & Me.CtlAsistencia1.Desde.ToLongDateString
        .Range("B4").Value = Me.CtlBuscaEmpleadosPeriodo1.CtlSeccion1.ParametroDet.Pardet_Descripcion
        .Range("B5").Value = Me.CtlBuscaEmpleadosPeriodo1.CtlSeccion1.ParametroDet.Pardet_DatoStr1

        .Columns().ColumnWidth = 80
        .Rows().RowHeight = 18
        .Range("A6").Value = "Código"
        .Columns("A:A").ColumnWidth = 10
        .Columns("A:A").numberformat = "@"
        .Range("B6").Value = "Nombres y Apellidos"
        .Columns("B:B").ColumnWidth = 43
        .Range("C6").Value = "Labor"
        .Columns("C:C").ColumnWidth = 17
        .Range("D6").Value = "Horas"
        .Columns("D:D").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Columns("D:D").ColumnWidth = 6
        .Range("E6").Value = "Sobret"
        .Columns("E:E").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        .Columns("E:E").ColumnWidth = 6
        .Range("F6").Value = "Observación"
        .Columns("F:F").ColumnWidth = 16

        Dim t As Integer = 0
        For Each _tipocont As TipoContrato In TipoContratoList.ObtenerLista(Me.CtlBuscaEmpleadosPeriodo1.Patrono)
          Dim primero As Boolean = True
          For Each _cont As Contrato In Me.CtlBuscaEmpleadosPeriodo1.Contratos
            If (Not _cont Is Nothing) AndAlso _cont.Tipocontrato.TipCon_Codigo = _tipocont.TipCon_Codigo Then
              If primero Then
                primero = False
                t += 1
                .Cells(7 + t, 1).value = _tipocont.TipCon_Descripcion
                .Cells(7 + t, 1).font.bold = True
                t += 1
              End If

              .Cells(7 + t, 1).value = _cont.Empleado.CodigoEmpleado
              .Cells(7 + t, 2).value = _cont.Empleado.NombreCompleto
              .Cells(7 + t, 3).value = "_________________"
              .Cells(7 + t, 4).value = "______"
              .Cells(7 + t, 5).value = "______"
              .Cells(7 + t, 6).value = "________________"

              'With .Range("C" & (8 + t).ToString & ":F" & (8 + t).ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
              '  .LineStyle = Excel.XlLineStyle.xlContinuous
              '  .Weight = Excel.XlBorderWeight.xlThin
              '  .ColorIndex = Excel.Constants.xlAutomatic
              'End With
              t += 1
            End If
          Next
        Next
        Dim _adicionales As Integer = (t Mod 35)
        If _adicionales > 0 Then
          For h As Integer = 1 To 35 - _adicionales
            .Cells(7 + t, 1).value = "__________"
            .Cells(7 + t, 2).value = "___________________________________________"
            .Cells(7 + t, 3).value = "_________________"
            .Cells(7 + t, 4).value = "______"
            .Cells(7 + t, 5).value = "______"
            .Cells(7 + t, 6).value = "________________"
            t += 1
          Next
        End If

        With .Range("A6:F6")
          .Font.Bold = True
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

        '.Columns("B:B").EntireColumn.AutoFit()
        '.Columns("C:C").EntireColumn.AutoFit()
        '.Columns("D:D").EntireColumn.AutoFit()
        '.Columns("E:E").NumberFormat = "0" & CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
        '.Columns("E:E").EntireColumn.AutoFit()
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
        .PrintTitleRows = "$1:$7"
        .LeftMargin = 5
        .RightMargin = 5
        .TopMargin = 20
        .BottomMargin = 20
        .PrintTitleColumns = ""
        .LeftHeader = ""
        .CenterHeader = "Página &P de &N"
        .RightHeader = ""
        '.LeftFooter = "Infoware"
        '.CenterFooter = "Página &P"
        '.RightFooter = "&D"
      End With

      excelApp.Visible = True
      excelWorksheet.PrintPreview()
      'excelApp.Quit()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub
End Class