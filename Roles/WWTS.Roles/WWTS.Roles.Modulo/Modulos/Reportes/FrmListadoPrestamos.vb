Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
'Imports WWTS.Contabilidad.Reglas
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmListadoPrestamos
#Region "IOpcion"
  Enum enumTipoReporte
    Detallado = 1
    Resumido = 2
  End Enum

  Private mTipoReporte As enumTipoReporte = enumTipoReporte.Detallado
  Public Property TipoReporte As enumTipoReporte
    Get
      Return mTipoReporte
    End Get
    Set(value As enumTipoReporte)
      mTipoReporte = value
    End Set
  End Property

  Private mPatrono As Patrono = Nothing
  Public WriteOnly Property Patrono() As Patrono
    Set(ByVal value As Patrono)
      mPatrono = value
      If value IsNot Nothing Then
        Llenar_datos()
      End If
    End Set
  End Property
#End Region

  Private Sub Llenar_datos()
    MyBase.Titulo = "Reporte de préstamos"
    If mPatrono Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New ReportDocument
      If mTipoReporte = enumTipoReporte.Detallado Then
        info = New crpprestamodet
      Else
        info = New crpprestamores
      End If

      info.DataDefinition.FormulaFields("titulo").Text = "'" & "Reporte de préstamos" & "'"
      info.DataDefinition.FormulaFields("cortadoal").Text = "'" & Me.DateTimePicker1.Value.ToShortDateString & "'"
      info.DataDefinition.FormulaFields("hacienda").Text = "'" & mPatrono.NombreCompleto & "'"

      Dim ds As DataSet
      If mTipoReporte = enumTipoReporte.Detallado Then
        ds = New DSdetallesprestamos
        ds = RetornarPrestamosDetalleDS(mPatrono, Me.DateTimePicker1.Value)
      Else
        ds = New dsresumenprestamo
        ds = RetornarPrestamosResumenDS(mPatrono, Me.DateTimePicker1.Value)
      End If

      info.SetDataSource(ds)
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Function RetornarPrestamosDetalleDS(ByVal _Patrono As Patrono, _CortadoAl As Date) As DSdetallesprestamos
    Dim bReturn As Boolean = True
    Dim dsResult As New DSdetallesprestamos
    With _Patrono.OperadorDatos
      .AgregarParametro("@Patron_Codigo", _Patrono.Patron_Codigo)
      .AgregarParametro("@Cortado_al", _CortadoAl.Date)

      .Comando.CommandText = "proc_PrestamosDetalle"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New DSdetallesprestamos
        DataAdapter.Fill(dsResult, "v_detallesprestamos")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

  Private Function RetornarPrestamosResumenDS(ByVal _Patrono As Patrono, _CortadoAl As Date) As dsresumenprestamo
    Dim bReturn As Boolean = True
    Dim dsResult As New dsresumenprestamo
    With _Patrono.OperadorDatos
      .AgregarParametro("@Patron_Codigo", _Patrono.Patron_Codigo)
      .AgregarParametro("@Cortado_al", _CortadoAl.Date)
      .Comando.CommandText = "proc_PrestamosResumen"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New dsresumenprestamo
        DataAdapter.Fill(dsResult, "v_resumenprestamo")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

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

  Private Sub btnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrar.Click
    Llenar_datos()
  End Sub
End Class
