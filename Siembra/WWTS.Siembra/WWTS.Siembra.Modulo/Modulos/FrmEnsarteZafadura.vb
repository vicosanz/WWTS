
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General

Public Class FrmEnsarteZafadura
  Implements IOpcion

  Private Sub FrmAsistencias_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlBuscaTarjetaEnsZaf1.Op = Sistema.OperadorDatos
    Me.CtlTarjEnsarte1.Op = Sistema.OperadorDatos
    Me.CtlZafra1.Op = Sistema.OperadorDatos
    Me.CtlZafra2.Op = Sistema.OperadorDatos
    Me.CtlZafra3.Op = Sistema.OperadorDatos
    Me.cboCicloEnsarte.OperadorDatos = Sistema.OperadorDatos
    Me.cboCicloEnsarte.Parametro = Enumerados.EnumParametros.CicloEnsarte
    Me.cboCicloEnsarte.Llenar_Datos()
    Me.CtlZafra1.llenar_datos()
    Me.CtlZafra2.llenar_datos()
    Me.CtlZafra3.llenar_datos()
    CtlTarjEnsarte1.Restriccion = Restriccion
  End Sub

  Private Sub CtlTarjEnsarte1_AntesNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlTarjEnsarte1.AntesNuevo
    Dim _ensarteZafadura As EnsarteZafadura
    Dim _ensant As EnsarteZafadura
    _ensant = Me.CtlTarjEnsarte1.EnsarteZafadura
    _ensarteZafadura = New EnsarteZafadura(Sistema.OperadorDatos, True)
    If Not _ensant Is Nothing AndAlso Not _ensant.Lote Is Nothing AndAlso Not _ensant.Corte Is Nothing Then
      _ensarteZafadura.Lote = _ensant.Lote
      _ensarteZafadura.Corte = _ensant.Corte
    End If
    _ensarteZafadura.Zafra = Me.CtlBuscaTarjetaEnsZaf1.Zafra
    Me.CtlTarjEnsarte1.EnsarteZafadura = _ensarteZafadura
  End Sub

  Private Sub CtlBuscaTarjetaEnsZaf1_CambioTarjeta(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaTarjetaEnsZaf1.CambioTarjeta
    Me.CtlTarjEnsarte1.EnsarteZafadura = Me.CtlBuscaTarjetaEnsZaf1.EnsarteZafadura
  End Sub

  Private Sub CtlTarjEnsarte1_EliminoTarjeta(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlTarjEnsarte1.EliminoTarjeta
    Me.CtlBuscaTarjetaEnsZaf1.llenar_datos(1)
  End Sub

  Private Sub btnmostrarsaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarsaldo.Click
    Try
      Dim info As ReportClass
      info = New crpSaldoCujesLbs
      info.DataDefinition.FormulaFields("Titulo").Text = "'Saldo de cujes en horno - " & IIf(Me.rdotabnat.Checked, "Tabaco Natural", "Tabaco Candela") & " - Zafra " & Me.CtlZafra1.Zafra.Zaf_descripcion & "'"
      If Me.chkcortadoensal.Checked Then
        info.DataDefinition.FormulaFields("FechaCorte").Text = "'Cortado al :" & Me.dtcortadoensal.Value.Date.ToShortDateString & "'"
      End If

      Dim ds As New DSSaldoCujes
      Dim _cortadoensal As Date = Nothing
      If Me.chkcortadoensal.Checked Then
        _cortadoensal = Me.dtcortadoensal.Value.Date
      End If
      ds = RetornarSaldoCujes(Sistema.OperadorDatos, Me.CtlZafra1.Zafra, IIf(Me.rdotabnat.Checked, Enumerados.TipoTabaco.Natural, Enumerados.TipoTabaco.Candela), _cortadoensal)

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
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3}", "Imprimió saldo de cujes en hornos", CtlZafra1.Zafra.Zaf_descripcion, IIf(rdotabnat.Checked, "Tabaco Natural", "Tabaco Candela"), IIf(Me.chkcortadoensal.Checked, Me.dtcortadoensal.Value.ToShortDateString, "")))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarSaldoCujes(ByVal _OperadorDatos As OperadorDatos, ByVal _zafra As ZafraSiembra, ByVal _tipotabaco As Enumerados.TipoTabaco, ByVal _cortadoensal As Date) As DSSaldoCujes
    Dim bReturn As Boolean = True
    Dim dsResult As New DSSaldoCujes
    With _OperadorDatos
      .AgregarParametro("@accion", "sc")
      .AgregarParametro("@zaf_codigo", _zafra.Zaf_codigo)
      .AgregarParametro("@estabaconatural", _tipotabaco = Enumerados.TipoTabaco.Natural)
      If Not _cortadoensal = Nothing Then
        .AgregarParametro("@fechacorteens", _cortadoensal)
      End If
      .Procedimiento = "proc_EnsarteZafadura"
      .Comando.CommandText = .Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)

      Try
        dsResult = New DSSaldoCujes
        DataAdapter.Fill(dsResult, "vw_saldocujes")
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

  Private Sub chkcortadoensal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcortadoensal.CheckedChanged
    Me.dtcortadoensal.Enabled = Me.chkcortadoensal.Checked
  End Sub

  Private Sub btnmostrarzaf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarzaf.Click
    Try
      Dim info As ReportClass
      info = New crpTabacoZafado
      info.DataDefinition.FormulaFields("Titulo").Text = "'Reporte de Tabaco Zafado - " & IIf(Me.rdotabnatzaf.Checked, "Tabaco Natural", "Tabaco Candela") & " - Zafra " & Me.CtlZafra3.Zafra.Zaf_descripcion & "'"
      If Me.chkcortadozafal.Checked Then
        info.DataDefinition.FormulaFields("FechaCorte").Text = "'Cortado al :" & Me.dtcortadozafal.Value.Date.ToShortDateString & "'"
      End If

      Dim ds As New DSSaldoCujes
      Dim _cortadozafal As Date = Nothing
      If Me.chkcortadozafal.Checked Then
        _cortadozafal = Me.dtcortadozafal.Value.Date
      End If
      ds = RetornarTabacoZafado(Sistema.OperadorDatos, Me.CtlZafra3.Zafra, IIf(Me.rdotabnatzaf.Checked, Enumerados.TipoTabaco.Natural, Enumerados.TipoTabaco.Candela), _cortadozafal)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        info.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        Me.crvtabacozafado.Zoom(1)
        Me.crvtabacozafado.ReportSource = info
        Me.crvtabacozafado.DisplayToolbar = True
        Me.crvtabacozafado.ShowRefreshButton = False
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3}", "Imprimió reporte de tabaco zafado", CtlZafra3.Zafra.Zaf_descripcion, IIf(rdotabnatzaf.Checked, "Tabaco Natural", "Tabaco Candela"), IIf(Me.chkcortadozafal.Checked, Me.dtcortadozafal.Value.ToShortDateString, "")))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub chkcortadozafal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcortadozafal.CheckedChanged
    Me.dtcortadozafal.Enabled = Me.chkcortadozafal.Checked
  End Sub

  Public Function RetornarTabacoZafado(ByVal _OperadorDatos As OperadorDatos, ByVal _zafra As ZafraSiembra, ByVal _tipotabaco As Enumerados.TipoTabaco, ByVal _cortadoensal As Date) As DSSaldoCujes
    Dim bReturn As Boolean = True
    Dim dsResult As New DSSaldoCujes
    With _OperadorDatos
      .AgregarParametro("@accion", "tz")
      .AgregarParametro("@zaf_codigo", _zafra.Zaf_codigo)
      .AgregarParametro("@estabaconatural", _tipotabaco = Enumerados.TipoTabaco.Natural)
      If Not _cortadoensal = Nothing Then
        .AgregarParametro("@fechacorteens", _cortadoensal)
      End If
      .Procedimiento = "proc_EnsarteZafadura"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)

      Try
        dsResult = New DSSaldoCujes
        DataAdapter.Fill(dsResult, "vw_saldocujes")
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

  Private Sub btnmostrardispo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrardispo.Click
    Try
      Dim info As ReportDocument
      info = New crpDisponibilidadCujes
      info.DataDefinition.FormulaFields("Titulo").Text = "'Reporte de Disponibilidad de Cujes - " & "Zafra " & Me.CtlZafra2.Zafra.Zaf_descripcion & "'"
      If Me.chkhastadispo.Checked Then
        info.DataDefinition.FormulaFields("FechaCorte").Text = "'Tabaco ensartado hasta :" & Me.dtfechastadispo.Value.Date.ToShortDateString & "'"
      End If

      Dim ds As New DSdispocujes
      Dim _cortadoensal As Date = Nothing
      If Me.chkhastadispo.Checked Then
        _cortadoensal = Me.dtfechastadispo.Value.Date
      End If
      ds = RetornarDisponibilidadCujes(Sistema.OperadorDatos, Me.CtlZafra2.Zafra, _cortadoensal, cboCicloEnsarte.ParametroDet)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        info.PrintOptions.PaperOrientation = PaperOrientation.Portrait
        Me.crvdispo.Zoom(1)
        Me.crvdispo.ReportSource = info
        Me.crvdispo.DisplayToolbar = True
        Me.crvdispo.ShowRefreshButton = False
        'Me.crvdispo.DisplayGroupTree = False
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, String.Format("{0} {1} {2}", "Imprimió Disponibilidad en cujes", CtlZafra2.Zafra.Zaf_descripcion, IIf(Me.chkhastadispo.Checked, Me.dtfechastadispo.Value.ToShortDateString, "")))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  Private Sub chkhastadispo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhastadispo.CheckedChanged
    Me.dtfechastadispo.Enabled = Me.chkhastadispo.Checked
  End Sub

  Public Function RetornarDisponibilidadCujes(ByVal _OperadorDatos As OperadorDatos, ByVal _zafra As ZafraSiembra, ByVal _cortadoensal As Date, _pardet_CicloEnsarte As WWTSParametroDet) As DSdispocujes
    Dim dsResult As New DSdispocujes
    Dim bReturn As Boolean = True
    With _OperadorDatos
      .AgregarParametro("@accion", "dc")
      .AgregarParametro("@zaf_codigo", _zafra.Zaf_codigo)
      If Not _cortadoensal = Nothing Then
        .AgregarParametro("@fechacorteens", _cortadoensal)
      End If
      .AgregarParametro("@Parame_CicloEnsarte", _pardet_CicloEnsarte.Parame_Codigo)
      .AgregarParametro("@Pardet_CicloEnsarte", _pardet_CicloEnsarte.Pardet_Secuencia)

      .Procedimiento = "proc_EnsarteZafadura"
      .Comando.CommandText = .Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)

      Try
        dsResult = New DSdispocujes
        DataAdapter.Fill(dsResult, "vw_dispocujes")
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