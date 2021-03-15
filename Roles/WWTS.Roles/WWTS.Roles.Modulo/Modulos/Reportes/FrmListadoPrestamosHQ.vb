Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
'Imports WWTS.Contabilidad.Reglas
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmListadoPrestamosHQ
#Region "IOpcion"
  Enum enumTipoReporte
    Hipotecario = 16
    Quirografario = 22
  End Enum

  Private mTipoReporte As enumTipoReporte = enumTipoReporte.Hipotecario
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
    If mPatrono Is Nothing Then
      Exit Sub
    End If
    Try
      Dim paramTipoPrestamo As WWTSParametroDet
      paramTipoPrestamo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoRubro, mTipoReporte)
      MyBase.Titulo = String.Format("Reporte de préstamos {0}", paramTipoPrestamo.Pardet_Descripcion)

      Dim info As New ReportDocument
      info = New crpprestamoHQ

      info.DataDefinition.FormulaFields("titulo").Text = String.Format("'Reporte de préstamos {0}'", paramTipoPrestamo.Pardet_Descripcion)
      info.DataDefinition.FormulaFields("desde").Text = String.Format("'{0}'", Me.dtDesde.Value.ToShortDateString)
      info.DataDefinition.FormulaFields("hasta").Text = String.Format("'{0}'", Me.dtHasta.Value.ToShortDateString)
      info.DataDefinition.FormulaFields("patrono").Text = "'" & mPatrono.NombreCompleto & "'"

      Dim ds As DataSet
      ds = New DSprestamosHQ
      ds = RetornarPrestamosHQDS(mPatrono, Me.dtDesde.Value, Me.dtHasta.Value, mTipoReporte)

      info.SetDataSource(ds)
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Function RetornarPrestamosHQDS(ByVal _Patrono As Patrono, _Desde As Date, _Hasta As Date, _Tipo As enumTipoReporte) As DSprestamosHQ
    Dim bReturn As Boolean = True
    Dim dsResult As New DSprestamosHQ
    With _Patrono.OperadorDatos
      .AgregarParametro("@Patron_Codigo", _Patrono.Patron_Codigo)
      .AgregarParametro("@Desde", _Desde.Date)
      .AgregarParametro("@Hasta", _Hasta.Date)
      .AgregarParametro("@Pardet_TipoRubro", _Tipo)
      .Comando.CommandText = "proc_PrestamosHQ"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New DSprestamosHQ
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
