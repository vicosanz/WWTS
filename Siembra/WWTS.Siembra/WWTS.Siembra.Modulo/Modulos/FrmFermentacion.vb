
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports Infoware.Reglas.General
Imports Infoware.Datos
Imports Infoware.Consola.Base

Public Class FrmFermentacion
  Implements IOpcion

  Private Sub FrmAsistencias_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlBloque1.op = Sistema.OperadorDatos
    Me.CtlBuscaBloqueFermentacion1.Op = Sistema.OperadorDatos
    Me.CtlZafra1.Op = Sistema.OperadorDatos
    Me.CtlZafra1.llenar_datos()
    Me.CtlBloque1.Restriccion = Restriccion
  End Sub

  Private Sub CtlBloque1_AntesNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBloque1.AntesNuevo
    Me.CtlBloque1.Bloque = New Bloque(Sistema.OperadorDatos, Me.CtlBuscaBloqueFermentacion1.Zafra)
  End Sub

  Private Sub CtlBuscaBloqueFermentacion1_CambioBloque(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaBloqueFermentacion1.CambioBloque
    Me.CtlBloque1.Bloque = Me.CtlBuscaBloqueFermentacion1.Bloque
  End Sub

  Private Sub chkcortadoensal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcortadoensal.CheckedChanged
    Me.dtcortadoensal.Enabled = Me.chkcortadoensal.Checked
  End Sub

  Private Sub btnmostrarsaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarsaldo.Click
    Try
      Dim info As ReportClass
      info = New crpTabacoFermentacion
      info.DataDefinition.FormulaFields("Titulo").Text = "'Saldo de tabaco en cuartos - " & " - Zafra " & Me.CtlZafra1.Zafra.Zaf_descripcion & "'"
      If Me.chkcortadoensal.Checked Then
        info.DataDefinition.FormulaFields("FechaCorte").Text = "'Cortado al :" & Me.dtcortadoensal.Value.Date.ToShortDateString & "'"
      End If

      Dim ds As New DSTabacoFermentacion
      Dim _cortadoensal As Date = Nothing
      If Me.chkcortadoensal.Checked Then
        _cortadoensal = Me.dtcortadoensal.Value.Date
      End If
      ds = RetornarSaldoCuartos(Sistema.OperadorDatos, Me.CtlZafra1.Zafra, _cortadoensal, Me.rdoDetallado.Checked)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        info.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        Me.crvsaldocujes.Zoom(1)
        Me.crvsaldocujes.ReportSource = info
        Me.crvsaldocujes.DisplayToolbar = True
        Me.crvsaldocujes.ShowRefreshButton = False
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, String.Format("{0} {1} {2}", "Imprimió Saldo de tabaco en cuartos", Me.CtlZafra1.Zafra.Zaf_descripcion, IIf(Me.chkcortadoensal.Checked, Me.dtcortadoensal.Value.ToShortDateString, "")))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarSaldoCuartos(ByVal _OperadorDatos As OperadorDatos, ByVal _zafra As ZafraSiembra, ByVal _cortadoensal As Date, _detallado As Boolean) As DSTabacoFermentacion
    Dim dsResult As New DSTabacoFermentacion
    Dim bReturn As Boolean = True
    With _OperadorDatos
      .AgregarParametro("@accion", "tf")
      .AgregarParametro("@zaf_codigo", _zafra.Zaf_codigo)
      If Not _cortadoensal = Nothing Then
        .AgregarParametro("@fechacortemov", _cortadoensal)
      End If
      .AgregarParametro("@detallado", _detallado)
      .Procedimiento = "proc_Bloque"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)

      Try
        dsResult = New DSTabacoFermentacion
        DataAdapter.Fill(dsResult, "vw_bloques")
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
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return PnlCuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Nothing 'MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

End Class