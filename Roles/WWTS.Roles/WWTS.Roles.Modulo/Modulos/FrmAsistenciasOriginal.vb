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

Public Class FrmAsistenciasO
  Implements IOpcion

  Private Sub FrmAsistencias_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    'Me.CtlAsistencia1.ManipularRestriccion = Restriccion.Restri_VerConfidencial

    Me.CtlBuscaEmpleadosPeriodo1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleadosPeriodo1.Op = Sistema.OperadorDatos

    Me.CtlAsistencia1.Op = Sistema.OperadorDatos
    Me.CtlSeccion1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlClase1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlPatrono2.Op = Sistema.OperadorDatos
    Me.CtlPatrono3.Op = Sistema.OperadorDatos
    Me.CtlPeriodo2.Op = Sistema.OperadorDatos
    Me.CtlClase2.OperadorDatos = Sistema.OperadorDatos
    Me.CtlClase3.OperadorDatos = Sistema.OperadorDatos
    Me.CtlTipoContrato1.Op = Sistema.OperadorDatos
    Me.cbosexo.OperadorDatos = Sistema.OperadorDatos
    Me.cbosexo2.OperadorDatos = Sistema.OperadorDatos
    Me.cbosexo3.OperadorDatos = Sistema.OperadorDatos

    Me.cbosemana.SelectedIndex = 0
    Me.CtlSeccion1.Parametro = Enumerados.EnumParametros.Seccion
    Me.CtlSeccion1.Llenar_Datos()

    Me.CtlClase1.Parametro = Enumerados.EnumParametros.ClaseEmpleado
    Me.CtlClase1.Llenar_Datos()

    Me.CtlClase2.Parametro = Enumerados.EnumParametros.ClaseEmpleado
    Me.CtlClase2.Llenar_Datos()

    Me.CtlClase3.Parametro = Enumerados.EnumParametros.ClaseEmpleado
    Me.CtlClase3.Llenar_Datos()

    Me.cbosexo.Parametro = Enumerados.EnumParametros.Sexo
    Me.cbosexo.Llenar_Datos()

    Me.cbosexo2.Parametro = Enumerados.EnumParametros.Sexo
    Me.cbosexo2.Llenar_Datos()

    Me.cbosexo3.Parametro = Enumerados.EnumParametros.Sexo
    Me.cbosexo3.Llenar_Datos()

    Me.CtlPatrono2.llenar_datos()
    Me.CtlPatrono3.llenar_datos()
    Me.CtlPeriodo2.llenar_datos()
    Me.CtlTipoContrato1.llenar_datos()

    Me.CtlSeccion1.Enabled = False
    Me.CtlClase1.Enabled = False
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
    _asist.Tipocontrato = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato
    _asist.Recargar()
    Me.CtlAsistencia1.Asistencia = _asist
  End Sub

  Private Sub CtlBuscaEmpleadosPeriodo1_Generar(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleadosPeriodo1.Generar
    Dim asistencias As AsistenciaList
    asistencias = CType(sender, AsistenciaList)
    If asistencias Is Nothing Then
      MsgBox("Seleccione al menos un empleado", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    For Each _asis As Asistencia In asistencias
      Me.CtlAsistencia1.Asistencia = _asis
      Me.CtlAsistencia1.Generar()
    Next
  End Sub
#End Region

#Region "Listado de firmas"
  Private Sub btnlistfirmatarea_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistfirmatarea.Click
    Dim _AgruparSeccion As Boolean = MsgBox("¿Desea agrupar por sección y labor?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes
    Try
      Dim info As ReportClass
      If _AgruparSeccion Then
        info = New crpListadoFirmasTarea
      Else
        info = New crpListadoFirmasTarea2
      End If

      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de firmas para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      info.DataDefinition.FormulaFields("fecdesde").Text = String.Format("'{0}'", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString)
      info.DataDefinition.FormulaFields("fechasta").Text = String.Format("'{0}'", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString)
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim _fecha As DateTime = Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
      For t As Integer = 1 To 7
        info.DataDefinition.FormulaFields("diasemana" & t).Text = String.Format("'{0}'", _fecha.ToString("dddd"))
        _fecha = _fecha.AddDays(1)
      Next

      Dim ds As New DSListadoFirmasTareas
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.Pardet_Descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarListadoFirmaTareaDS(Sistema.OperadorDatos, _AgruparSeccion, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, Me.chkno0neto.Checked, Me.chknoninguncero.Checked)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperFanfoldUS
        Me.crv_resumenperiodo.Zoom(1)
        Me.crv_resumenperiodo.ReportSource = info
        Me.crv_resumenperiodo.DisplayToolbar = True
        Me.crv_resumenperiodo.ShowRefreshButton = False
        'Me.crv_resumenperiodo.DisplayGroupTree = False
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió Listado de firmas de tareas", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub
  Private Sub btnlistfirma_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistfirma.Click
    Try
      Dim info As ReportClass

      Select Case CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum
        Case Enumerados.enumTipoContrato.Temporada
          info = New crpListadoFirmasD3Vac
        Case Enumerados.enumTipoContrato.Destajo
          info = New crpListadoFirmasDestajo
        Case Enumerados.enumTipoContrato.PorHoras
          info = New crpListadoFirmasporHoras
        Case Else
          info = New crpListadoFirmas
      End Select

      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de firmas para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim ds As New DSlistadofirmas
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.Pardet_Descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarListadoFirmaDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, Me.chkno0neto.Checked, Me.chknoninguncero.Checked)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperFanfoldUS
        Me.crv_resumenperiodo.Zoom(1)
        Me.crv_resumenperiodo.ReportSource = info
        Me.crv_resumenperiodo.DisplayToolbar = True
        Me.crv_resumenperiodo.ShowRefreshButton = False
        'Me.crv_resumenperiodo.DisplayGroupTree = False
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió Listado de firmas", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Enum tipolistadofirmas
    Todos = 0
    Seccion = 1
    Sexo = 2
  End Enum
  Public Function RetornarListadoFirmaTareaDS(ByVal _OperadorDatos As OperadorDatos, ByVal _AgruparSeccion As Boolean, ByVal _tiporeporte As tipolistadofirmas, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _seccion As WWTSParametroDet, ByVal _sexo As String, ByVal _nomostrarcerosnetos As Boolean, ByVal _nomostrarninguncero As Boolean) As DSListadoFirmasTareas
    Dim bReturn As Boolean = True
    Dim dsResult As New DSListadoFirmasTareas
    With _OperadorDatos
      If _AgruparSeccion Then
        .AgregarParametro("@accion", "tar")
      Else
        .AgregarParametro("@accion", "ta2")
      End If
      .AgregarParametro("@esdestajo", _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo)
      Select Case _tiporeporte
        Case tipolistadofirmas.Seccion
          .AgregarParametro("@Parame_Seccion", _seccion.Parame_Codigo)
          .AgregarParametro("@Pardet_Seccion", _seccion.Pardet_Secuencia)
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        .AgregarParametro("@cls_codigo", _clase.Pardet_Secuencia)
      End If
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@fechainicio", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@fechafin", _periodo.PerPag_FechaHasta)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .AgregarParametro("@nomostrarcerosnetos", _nomostrarcerosnetos)
      .AgregarParametro("@nomostrarninguncero", _nomostrarninguncero)
      .Comando.CommandText = "proc_asistencia"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSListadoFirmasTareas
        DataAdapter.Fill(dsResult, "vw_tareas")
      Catch ex As Exception
        'bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

  Public Function RetornarListadoFirmaDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _seccion As WWTSParametroDet, ByVal _sexo As Integer, ByVal _nomostrarcerosnetos As Boolean, ByVal _nomostrarninguncero As Boolean) As DSlistadofirmas
    Dim bReturn As Boolean = True
    Dim dsResult As New DSlistadofirmas
    With _OperadorDatos
      .AgregarParametro("@accion", "lis")
      .AgregarParametro("@esdestajo", _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo)
      Select Case _tiporeporte
        Case tipolistadofirmas.Seccion
          .AgregarParametro("@Parame_Seccion", _seccion.Parame_Codigo)
          .AgregarParametro("@Pardet_Seccion", _seccion.Pardet_Secuencia)
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@Pardet_Sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        '.AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .AgregarParametro("@nomostrarcerosnetos", _nomostrarcerosnetos)
      .AgregarParametro("@nomostrarninguncero", _nomostrarninguncero)
      .Comando.CommandText = "proc_asistencia"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSlistadofirmas
        DataAdapter.Fill(dsResult, "v_resumenperiodo")
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

  Private Sub btnlistresumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistresumen.Click
    Try
      Dim info As New crpResumenPago
      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de resumen para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim ds As New DSlistadofirmas
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.Pardet_Descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarListadoFirmaDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, Me.chkno0neto.Checked, Me.chknoninguncero.Checked)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crv_resumenperiodo.Zoom(1)
        Me.crv_resumenperiodo.ReportSource = info
        Me.crv_resumenperiodo.DisplayToolbar = True
        Me.crv_resumenperiodo.ShowRefreshButton = False
        'Me.crv_resumenperiodo.DisplayGroupTree = False
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió Listado de resumen", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnlistresumentarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistresumentarea.Click
    Try
      Dim info As New crpTareaAgrupada
      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de resumen para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      info.DataDefinition.FormulaFields("fecdesde").Text = String.Format("'{0}'", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString)
      info.DataDefinition.FormulaFields("fechasta").Text = String.Format("'{0}'", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString)
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim ds As New DSTareaAgrupada
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.Pardet_Descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarTareaAgrupadaDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, Me.chkno0neto.Checked, Me.chknoninguncero.Checked)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crv_resumenperiodo.Zoom(1)
        Me.crv_resumenperiodo.ReportSource = info
        Me.crv_resumenperiodo.DisplayToolbar = True
        Me.crv_resumenperiodo.ShowRefreshButton = False
        'Me.crv_resumenperiodo.DisplayGroupTree = False
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió Listado de resumen", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarTareaAgrupadaDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _seccion As WWTSParametroDet, ByVal _sexo As String, ByVal _nomostrarcerosnetos As Boolean, ByVal _nomostrarninguncero As Boolean) As DSTareaAgrupada
    Dim bReturn As Boolean = True
    Dim dsResult As New DSTareaAgrupada
    With _OperadorDatos
      .AgregarParametro("@accion", "tag")
      .AgregarParametro("@esdestajo", _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo)
      Select Case _tiporeporte
        Case tipolistadofirmas.Seccion
          .AgregarParametro("@Parame_Seccion", _seccion.Parame_Codigo)
          .AgregarParametro("@Pardet_Seccion", _seccion.Pardet_Secuencia)
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        .AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@fechainicio", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@fechafin", _periodo.PerPag_FechaHasta)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .AgregarParametro("@nomostrarcerosnetos", _nomostrarcerosnetos)
      .AgregarParametro("@nomostrarninguncero", _nomostrarninguncero)
      .Comando.CommandText = "proc_asistencia"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSTareaAgrupada
        DataAdapter.Fill(dsResult, "vw_tareag")
      Catch ex As Exception
        'bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

#End Region

#Region "Reporte contable"
  'Private Sub Mostrar_contable()
  '  Dim nompag As Decimal = 0
  '  Dim prespag As Decimal = 0
  '  Dim iesspag As Decimal = 0
  '  Dim prstqpag As Decimal = 0
  '  Dim fondrespag As Decimal = 0
  '  Dim d3pag As Decimal = 0
  '  Dim d4pag As Decimal = 0
  '  Dim vacpag As Decimal = 0
  '  Dim ajuste As Decimal = 0
  '  Dim totpagiess As Decimal = 0
  '  Dim totprestamos As Decimal = 0
  '  Dim totmultas As Decimal = 0
  '  Dim movims As New MovimCtbleCollection

  '  Try
  '    Dim config As New ConfigRoles(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Hacienda.Parroquia.Canton.Provincia.pais, False)

  '    Dim gr As Type = GetType(Enumerados.GrupoCtble)
  '    For Each grctble As Enumerados.GrupoCtble In [Enum].GetValues(gr)
  '      Dim tc As Type = GetType(Enumerados.enumTipoContrato)
  '      For Each tipcontr As Enumerados.enumTipoContrato In [Enum].GetValues(tc)
  '        Dim sueldxperiodos As SueldosxPeriodoCollection
  '        sueldxperiodos = SueldosxPeriodo.RetornarSueldosxPeriodosxTipoContratoxZafra(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.Periodo, grctble, tipcontr, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato)
  '        Dim tipctactble As Enumerados.TipoCtaCtble
  '        Select Case CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_tipo
  '          Case Enumerados.enumTipoContrato.Fijo
  '            tipctactble = Enumerados.TipoCtaCtble.Sueldos
  '          Case Enumerados.enumTipoContrato.Temporada
  '            tipctactble = Enumerados.TipoCtaCtble.Salarios
  '          Case Enumerados.enumTipoContrato.PorHoras, Enumerados.enumTipoContrato.Destajo
  '            tipctactble = Enumerados.TipoCtaCtble.PorHoras
  '        End Select

  '        If Not sueldxperiodos Is Nothing Then
  '          '------------------------SUELDOS, SALARIOS, POR HORAS
  '          For Each sueldxperiodo As SueldosxPeriodo In sueldxperiodos
  '            If sueldxperiodo.Sueldo + sueldxperiodo.Sobretiempo <> 0 Then
  '              Dim cuenta As New CuentaCtble(mOp, grctble, sueldxperiodo.Zafra, tipctactble, False)
  '              Dim movimctble As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '              movimctble.CuentaCtble = cuenta
  '              movimctble.Mcb_orden = 1
  '              movimctble.Mcb_costohn = sueldxperiodo.Sueldo
  '              movimctble.Mcb_costohs = sueldxperiodo.Sobretiempo
  '              movimctble.Mcb_totalp = sueldxperiodo.Sueldo + sueldxperiodo.Sobretiempo
  '              movims.Add(movimctble)
  '              nompag += sueldxperiodo.Sueldo + sueldxperiodo.Sobretiempo
  '              ajuste += sueldxperiodo.Sueldo + sueldxperiodo.Sobretiempo
  '            End If
  '          Next
  '        End If
  '      Next

  '      Dim sueldxzafras As SueldosxPeriodoCollection
  '      sueldxzafras = SueldosxPeriodo.RetornarSueldosxPeriodosxZafra(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.Periodo, grctble, CtlBuscaEmpleadosPeriodo1.TipoContrato)

  '      If Not sueldxzafras Is Nothing Then
  '        '------------------COMPENSACION SALARIAL
  '        For Each sueldxzafra As SueldosxPeriodo In sueldxzafras
  '          If sueldxzafra.ICS <> 0 Then
  '            Dim cuenta As New CuentaCtble(mOp, grctble, sueldxzafra.Zafra, Enumerados.TipoCtaCtble.CompSalarial, False)
  '            Dim movimctble As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '            movimctble.CuentaCtble = cuenta
  '            movimctble.Mcb_orden = 1
  '            movimctble.Mcb_otros = sueldxzafra.ICS
  '            movimctble.Mcb_totalp = sueldxzafra.ICS
  '            movims.Add(movimctble)
  '            nompag += sueldxzafra.ICS
  '            ajuste += sueldxzafra.ICS
  '          End If
  '        Next

  '        For Each sueldxzafra As SueldosxPeriodo In sueldxzafras
  '          '----------------ANTIGUEDAD
  '          If sueldxzafra.Adicional <> 0 Then
  '            Dim cuenta As New CuentaCtble(mOp, grctble, sueldxzafra.Zafra, Enumerados.TipoCtaCtble.Antiguedad, False)
  '            Dim movimctble As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '            movimctble.CuentaCtble = cuenta
  '            movimctble.Mcb_orden = 1
  '            movimctble.Mcb_otros = sueldxzafra.Adicional
  '            movimctble.Mcb_totalp = sueldxzafra.Adicional
  '            movims.Add(movimctble)
  '            nompag += sueldxzafra.Adicional
  '            ajuste += sueldxzafra.Adicional
  '          End If
  '        Next

  '        For Each sueldxzafra As SueldosxPeriodo In sueldxzafras
  '          '--------------------TRANSPORTE
  '          If sueldxzafra.Transporte <> 0 Then
  '            Dim cuenta As New CuentaCtble(mOp, grctble, sueldxzafra.Zafra, Enumerados.TipoCtaCtble.Transporte, False)
  '            Dim movimctble As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '            movimctble.CuentaCtble = cuenta
  '            movimctble.Mcb_orden = 1
  '            movimctble.Mcb_otros = sueldxzafra.Transporte
  '            movimctble.Mcb_totalp = sueldxzafra.Transporte
  '            movims.Add(movimctble)
  '            nompag += sueldxzafra.Transporte
  '            ajuste += sueldxzafra.Transporte
  '          End If
  '        Next
  '      End If

  '      Dim sueldxtipocontrato As SueldosxPeriodo
  '      sueldxtipocontrato = SueldosxPeriodo.RetornarSueldosxPeriodosxTipoContrato(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.Periodo, grctble, CtlBuscaEmpleadosPeriodo1.TipoContrato)

  '      If Not sueldxtipocontrato Is Nothing Then
  '        totmultas += sueldxtipocontrato.Multas

  '        If sueldxtipocontrato.Prestamo <> 0 Then
  '          '------------------------PRESTAMOSPORPAGAR
  '          Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Ninguno, Nothing, Enumerados.TipoCtaCtble.PrestamoxPagar, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 1
  '          movimctblex.Mcb_otros = -sueldxtipocontrato.Prestamo
  '          movimctblex.Mcb_totalp = -sueldxtipocontrato.Prestamo
  '          movims.Add(movimctblex)
  '          nompag -= sueldxtipocontrato.Prestamo
  '          prespag += sueldxtipocontrato.Prestamo
  '          ajuste -= sueldxtipocontrato.Prestamo
  '          totprestamos += sueldxtipocontrato.Prestamo
  '        End If

  '        'IESS POR HORAS
  '        If CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
  '        ElseIf CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
  '          If sueldxtipocontrato.Ingresos <> 0 Then
  '            '---------------------IESSJORNALEROS
  '            Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.IESSJornaleros, False)
  '            Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '            movimctblex.CuentaCtble = cuentaX
  '            movimctblex.Mcb_orden = 2
  '            movimctblex.Mcb_otros = sueldxtipocontrato.Ingresos * config.CnfRol_porciessporhora / 100
  '            movimctblex.Mcb_totalp = sueldxtipocontrato.Ingresos * config.CnfRol_porciessporhora / 100
  '            movims.Add(movimctblex)
  '            iesspag += sueldxtipocontrato.Ingresos * config.CnfRol_porciessporhora / 100
  '            totpagiess += sueldxtipocontrato.Ingresos * config.CnfRol_porciessporhora / 100
  '            ajuste += sueldxtipocontrato.Ingresos * config.CnfRol_porciessporhora / 100
  '          End If
  '        Else
  '          If sueldxtipocontrato.IESS <> 0 Then
  '            '---------------------IESS SALARIOS
  '            Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.IESSSalarios, False)
  '            Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '            movimctblex.CuentaCtble = cuentaX
  '            movimctblex.Mcb_orden = 1
  '            movimctblex.Mcb_otros = -sueldxtipocontrato.IESS
  '            movimctblex.Mcb_totalp = -sueldxtipocontrato.IESS
  '            movims.Add(movimctblex)
  '            'movimctblex.Guardar()
  '            nompag -= sueldxtipocontrato.IESS
  '            totpagiess += sueldxtipocontrato.IESS
  '            ajuste -= sueldxtipocontrato.IESS
  '          End If

  '          If sueldxtipocontrato.IESS <> 0 Then
  '            '------------------------IESS PATRONAL
  '            Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.IESSPatronal, False)
  '            Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '            movimctblex.CuentaCtble = cuentaX
  '            movimctblex.Mcb_orden = 2
  '            movimctblex.Mcb_totalp = sueldxtipocontrato.Ingresos * config.CnfRol_porciesspatronal / 100
  '            movims.Add(movimctblex)
  '            iesspag += sueldxtipocontrato.Ingresos * config.CnfRol_porciesspatronal / 100
  '            ajuste += sueldxtipocontrato.Ingresos * config.CnfRol_porciesspatronal / 100
  '          End If
  '        End If
  '      End If

  '      If Not (CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo) Then
  '        If sueldxtipocontrato.PrestamoQuirog <> 0 Then
  '          '------------------------Prestamo Quirografario
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.PrestamoQuirografario, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = -sueldxtipocontrato.PrestamoQuirog
  '          movims.Add(movimctblex)
  '          'movimctblex.Guardar()
  '          nompag -= sueldxtipocontrato.PrestamoQuirog
  '          'prstqpag += sueldxtipocontrato.PrestamoQuirog
  '          ajuste -= sueldxtipocontrato.PrestamoQuirog
  '        End If

  '        If sueldxtipocontrato.ImpuestoRenta <> 0 Then
  '          '------------------------Impuesto a la Renta
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.ImpuestoRenta, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = -sueldxtipocontrato.ImpuestoRenta
  '          movims.Add(movimctblex)
  '          'movimctblex.Guardar()
  '          nompag -= sueldxtipocontrato.ImpuestoRenta
  '          'prstqpag += sueldxtipocontrato.PrestamoQuirog
  '          ajuste -= sueldxtipocontrato.ImpuestoRenta
  '        End If
  '      End If

  '      'no IESS POR HORAS Y no destajo
  '      If Not (CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Or CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo) Then
  '        If sueldxtipocontrato.IESS <> 0 Then
  '          '------------------------SECAP
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.SECAP, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = sueldxtipocontrato.Ingresos * config.CnfRol_porcsecap / 100
  '          movims.Add(movimctblex)
  '          'movimctblex.Guardar()
  '          iesspag += sueldxtipocontrato.Ingresos * config.CnfRol_porcsecap / 100
  '          ajuste += sueldxtipocontrato.Ingresos * config.CnfRol_porcsecap / 100
  '        End If

  '        If sueldxtipocontrato.IESS <> 0 Then
  '          '-----------------------IECE
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.IECE, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = sueldxtipocontrato.Ingresos * config.CnfRol_porciece / 100
  '          movims.Add(movimctblex)
  '          iesspag += sueldxtipocontrato.Ingresos * config.CnfRol_porciece / 100
  '          ajuste += sueldxtipocontrato.Ingresos * config.CnfRol_porciece / 100
  '        End If

  '        If sueldxtipocontrato.Ingresos <> 0 Then
  '          '---------------------------DECIMO TERCERO
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.DecimoTercero, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '          movims.Add(movimctblex)
  '          If CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Fijo Then
  '            d3pag += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '          Else
  '            nompag += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '          End If
  '          ajuste += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '        End If

  '        If sueldxtipocontrato.Ingresos <> 0 Then
  '          '----------------------------VACACIONES
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.Vacaciones, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 24
  '          movims.Add(movimctblex)
  '          If CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Fijo Then
  '            vacpag += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 24
  '          Else
  '            nompag += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 24
  '          End If
  '          ajuste += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 24
  '        End If

  '        If sueldxtipocontrato.Ingresos <> 0 Then
  '          '----------------------------DECIMO CUARTO
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.DecimoCuarto, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = config.CnfRol_salariomv / 360 * sueldxtipocontrato.Diastrab
  '          movims.Add(movimctblex)
  '          d4pag += config.CnfRol_salariomv / 360 * sueldxtipocontrato.Diastrab
  '          ajuste += config.CnfRol_salariomv / 360 * sueldxtipocontrato.Diastrab
  '        End If

  '        If sueldxtipocontrato.Ingresos <> 0 Then
  '          '---------------------------FONDOS DE RESERVA
  '          Dim cuentaX As New CuentaCtble(mOp, grctble, Nothing, Enumerados.TipoCtaCtble.FondosReserva, False)
  '          Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '          movimctblex.CuentaCtble = cuentaX
  '          movimctblex.Mcb_orden = 2
  '          movimctblex.Mcb_totalp = (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '          movims.Add(movimctblex)
  '          'If CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Fijo  Then
  '          fondrespag += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '          'Else
  '          'nompag += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '          'End If
  '          ajuste += (sueldxtipocontrato.Ingresos + sueldxtipocontrato.ICS) / 12
  '        End If
  '      End If
  '    Next

  '    If nompag <> 0 Then
  '      Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.NominaxPagar, False)
  '      Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '      movimctblex.CuentaCtble = cuentaX
  '      movimctblex.Mcb_orden = 2
  '      movimctblex.Mcb_otros = totmultas
  '      movimctblex.Mcb_costohn = -nompag
  '      movimctblex.Mcb_totalp = -nompag + totmultas
  '      movims.Add(movimctblex)
  '      ajuste += -nompag
  '    End If

  '    'PRESTAMOS QUIROGRAFARIOS POR PAGAR
  '    'If prstqpag <> 0 Then
  '    '  Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.PrestamosQuirogxPagar, False)
  '    '  Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '    '  movimctblex.CuentaCtble = cuentaX
  '    '  movimctblex.Mcb_orden = 2
  '    '  movimctblex.Mcb_totalp = -prstqpag
  '    '  'movimctblex.Guardar()
  '    '  movims.Add(movimctblex)
  '    '  ajuste += -prstqpag
  '    'End If

  '    'IESS POR HORAS
  '    If CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Or CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
  '      If iesspag <> 0 Then
  '        Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.IESSJornxPagar, False)
  '        Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '        movimctblex.CuentaCtble = cuentaX
  '        movimctblex.Mcb_orden = 2
  '        movimctblex.Mcb_totalp = -iesspag
  '        'movimctblex.Guardar()
  '        movims.Add(movimctblex)
  '        ajuste += -iesspag
  '      End If
  '    Else
  '      If d3pag <> 0 Then
  '        Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.DecTerceroxPagar, False)
  '        Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '        movimctblex.CuentaCtble = cuentaX
  '        movimctblex.Mcb_orden = 2
  '        movimctblex.Mcb_totalp = -d3pag
  '        'movimctblex.Guardar()
  '        movims.Add(movimctblex)
  '        ajuste += -d3pag
  '      End If

  '      If d4pag <> 0 Then
  '        Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.DecCuartoxPagar, False)
  '        Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '        movimctblex.CuentaCtble = cuentaX
  '        movimctblex.Mcb_orden = 2
  '        movimctblex.Mcb_totalp = -d4pag
  '        'movimctblex.Guardar()
  '        movims.Add(movimctblex)
  '        ajuste += -d4pag
  '      End If

  '      If vacpag <> 0 Then
  '        Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.VacacionesxPagar, False)
  '        Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '        movimctblex.CuentaCtble = cuentaX
  '        movimctblex.Mcb_orden = 2
  '        movimctblex.Mcb_totalp = -vacpag
  '        'movimctblex.Guardar()
  '        movims.Add(movimctblex)
  '        ajuste += -vacpag
  '      End If

  '      If iesspag <> 0 Then
  '        Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.IESSSalaxPagar, False)
  '        Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '        movimctblex.CuentaCtble = cuentaX
  '        movimctblex.Mcb_orden = 2
  '        movimctblex.Mcb_totalp = -iesspag
  '        'movimctblex.Guardar()
  '        movims.Add(movimctblex)
  '        ajuste += -iesspag
  '      End If

  '      If fondrespag <> 0 Then
  '        Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.FondosReservaxPagar, False)
  '        Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '        movimctblex.CuentaCtble = cuentaX
  '        movimctblex.Mcb_orden = 2
  '        movimctblex.Mcb_totalp = -fondrespag
  '        'movimctblex.Guardar()
  '        movims.Add(movimctblex)
  '        ajuste += -fondrespag
  '      End If
  '    End If

  '    If ajuste <> 0 Then
  '      Dim cuentaX As New CuentaCtble(mOp, Enumerados.GrupoCtble.Totales, Nothing, Enumerados.TipoCtaCtble.AjusteNomina, False)
  '      Dim movimctblex As New MovimCtble(mOp, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
  '      movimctblex.CuentaCtble = cuentaX
  '      movimctblex.Mcb_orden = 2
  '      movimctblex.Mcb_totalp = -ajuste
  '      'movimctblex.Guardar()
  '      movims.Add(movimctblex)
  '    End If

  '    Dim ds As New DSasientocontable
  '    Dim buenos As Integer = 0
  '    Dim tabla As DataTable
  '    tabla = ds
  '    For Each _movim As MovimCtble In movims
  '      Dim fila As DataRow
  '      fila = tabla.NewRow()
  '      fila("cbl_grupoctble") = _movim.Cbl_grupoctble
  '      fila("mcb_orden") = _movim.Mcb_orden
  '      fila("cbl_numcta") = _movim.Cbl_numcta
  '      fila("zaf_codigo") = _movim.Zaf_codigo
  '      fila("cbl_detalle") = _movim.Cbl_detalle
  '      fila("mcb_costohn") = _movim.Mcb_costohn
  '      fila("mcb_costohs") = _movim.Mcb_costohs
  '      fila("mcb_otros") = _movim.Mcb_otros
  '      fila("mcb_totalp") = _movim.Mcb_totalp
  '      tabla.Rows.Add(fila)
  '      buenos += 1
  '    Next
  '    tabla.AcceptChanges()
  '    PrevioContable(ds, totpagiess, totprestamos, totmultas)
  '  Catch ex As Exception
  '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
  '  End Try
  'End Sub

  'Private Sub PrevioContable(ByVal ds As DSasientocontable, ByVal _totaliess As Decimal, ByVal _totprestamos As Decimal, ByVal _totmultas As Decimal)
  '  Try
  '    Dim info As New crpReporteContable
  '    info.SetDataSource(ds)
  '    info.DataDefinition.FormulaFields("Titulo").Text = "'Reporte Auxiliar para Contabilidad'"

  '    Dim pv As New ParameterValues
  '    Dim pdv As New ParameterDiscreteValue
  '    pdv.Value = Me.CtlBuscaEmpleadosPeriodo1.Patrono.Hacienda.Hac_nombre
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("hacienda").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("patrono").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("TipoContrato").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("Desde").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("Hasta").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaPago
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("Fechapago").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = _totaliess
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("totpagiess").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = _totprestamos
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("totprestamos").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = _totmultas
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("totmultas").ApplyCurrentValues(pv)

  '    Dim dscheques as DataTable
  '    dscheques = SueldosxPeriodo.RetornarInformacionCheques(mOp, CtlBuscaEmpleadosPeriodo1.Patrono, CtlBuscaEmpleadosPeriodo1.Periodo, CtlBuscaEmpleadosPeriodo1.TipoContrato)
  '    Dim totpagagocheque As Decimal = 0
  '    Dim mincheque As Integer = 0
  '    Dim maxcheque As Integer = 0
  '    If Not dscheques Is Nothing AndAlso dscheques.Tables.Count > 0 AndAlso dscheques.Rows.Count > 0 Then
  '      With dscheques.Rows(0)
  '        Dim obj As Object
  '        obj = .Item("totpagadocheque")
  '        If Not TypeOf obj Is DBNull Then
  '          totpagagocheque = CDec(obj)
  '        End If
  '        obj = .Item("mincheque")
  '        If Not TypeOf obj Is DBNull Then
  '          mincheque = CInt(obj)
  '        End If
  '        obj = .Item("maxcheque")
  '        If Not TypeOf obj Is DBNull Then
  '          maxcheque = CInt(obj)
  '        End If
  '      End With
  '    End If

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = totpagagocheque
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("totpagadocheque").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = mincheque
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("mincheque").ApplyCurrentValues(pv)

  '    pv = New ParameterValues
  '    pdv = New ParameterDiscreteValue
  '    pdv.Value = maxcheque
  '    pv.Add(pdv)
  '    info.DataDefinition.ParameterFields("maxcheque").ApplyCurrentValues(pv)

  '    Me.crv_contable.Zoom(1)
  '    info.PrintOptions.PaperSize = PaperSize.PaperA4
  '    Me.crv_contable.ReportSource = info
  '    Me.crv_contable.DisplayToolbar = True
  '    Me.crv_contable.ShowRefreshButton = False
  '    Me.crv_contable.DisplayGroupTree = False
  '  Catch Exp As LoadSaveReportException
  '    MsgBox("Incorrect path for loading report.", _
  '     MsgBoxStyle.Critical, "Load Report Error")
  '  Catch Exp As Exception
  '    MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
  '  End Try
  'End Sub
#End Region

#Region "Generar lote de pagos"
  Private Sub btngenerarlote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerarlote.Click
    Dim _seccion As WWTSParametroDet = Nothing
    Dim _sexo As String = Nothing
    Dim _clase As WWTSParametroDet = Nothing
    Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
    If Me.rdosoloseccion.Checked Then
      _seccion = Me.CtlSeccion1.ParametroDet
      _tipolistadofirmas = tipolistadofirmas.Seccion
    ElseIf Me.rdosolosexo.Checked Then
      _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
      _tipolistadofirmas = tipolistadofirmas.Sexo
    End If
    If chksoloclase.Checked Then
      _clase = Me.CtlClase1.ParametroDet
    End If

    Dim asiscol As New AsistenciaList
    asiscol = AsistenciaList.RetornarListadoFirma(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, True, True)

    If asiscol Is Nothing Then
      MsgBox("No existen personas en el periodo", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    For Each _asis As Asistencia In asiscol
      'If _asis.Asiste_SueldoPagar <= 0 Then
      '  MsgBox("No pueden existir personas con sueldos menores o iguales a 0. Revise " & _asis.Empleado.NombreCompleto, MsgBoxStyle.Critical, "Error")
      '  Exit Sub
      'End If
    Next
    Dim LotePago As New LotePago(Sistema.OperadorDatos, Now.Date)
    If Not LotePago.Guardar Then
      MsgBox(LotePago.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    For Each _asis As Asistencia In asiscol
      Dim pagovario As New DetalleLotePago(Sistema.OperadorDatos, LotePago, _asis)
      'pagovario.DeLoPa_Valor = _asis.Asiste_SueldoPagar
      pagovario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.Sueldos
      pagovario.DeLoPa_Fecha = _asis.Periodopago.PerPag_FechaPago
      pagovario.PardetFormaPagoRol = _asis.Empleado.PardetFormaPagoRol
      pagovario.Asistencia = _asis
      pagovario.DeLoPa_esPagado = False
      Try
        If Not pagovario.Guardar Then
          Throw New Exception(pagovario.OperadorDatos.MsgError)
        End If
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    Next
    MsgBox("Finalizada la generación del lote de pagos", MsgBoxStyle.Information, "Información")
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Generó lote de pagos periodo {0} patrono {1} Tipo de contrato {2}", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion))
  End Sub
#End Region

#Region "Recibo de pago"
  Public Function RetornarReciboPagoDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _seccion As WWTSParametroDet, ByVal _sexo As WWTSParametroDet) As DSReciboPago
    Dim bReturn As Boolean = True
    Dim dsResult As New DSReciboPago
    With _OperadorDatos
      .AgregarParametro("@accion", "per")
      .AgregarParametro("@esdestajo", _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo)
      Select Case _tiporeporte
        Case tipolistadofirmas.Seccion
          '.AgregarParametro("@Parame_Seccion", _seccion.Parame_Codigo)
          .AgregarParametro("@Pardet_Seccion", _seccion.Pardet_Secuencia)
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        '.AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      If Not _sexo Is Nothing Then
        '.AgregarParametro("@Parame_sexo", _sexo.Parame_Codigo)
        .AgregarParametro("@Pardet_sexo", _sexo.Pardet_Secuencia)
      End If
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@anio", _periodo.PerPag_anio)
      .AgregarParametro("@mes", _periodo.PerPag_mes)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .Procedimiento = "proc_asistencia"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSReciboPago
        DataAdapter.Fill(dsResult, "v_recibopago")
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

  Private Sub btnrecibospago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecibospago.Click
    Try
      'Dim info As New crpResumenPago
      'info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de resumen para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      'info.DataDefinition.FormulaFields("Filtro").Text = "''"
      'info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim ds As New DSReciboPago
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As WWTSParametroDet = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        'info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.pardet_descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.ParametroDet
        'info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarReciboPagoDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo)

      Dim rangoprdos As New PeriodoPagoList
      rangoprdos = PeriodoPagoList.ObtenerLista(Sistema.OperadorDatos, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PardetPeriodoPago, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio)
      If rangoprdos Is Nothing OrElse rangoprdos.Count = 0 Then
        MsgBox("Error al tratar de seleccionar periodos por mes", MsgBoxStyle.Critical, "Error")
        Exit Sub
      End If

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)

        excelApp.Visible = False
        With excelWorksheet
          .Columns().ColumnWidth = 80
          .Columns().NumberFormat = "@"
          .Range("A1").Value = "Entida_Codigo"
          .Range("B1").Value = "NombreCompleto"
          .Range("C1").Value = "Cedula"
          .Range("D1").Value = "desde"
          .Range("E1").Value = "hasta"
          .Range("F1").Value = "Seccion"
          '.Range("G1").Value = "Labor"
          .Range("H1").Value = "Patrono"
          .Range("I1").Value = "diario"
          .Range("J1").Value = "diasintegrales"
          .Range("K1").Value = "hlv"
          .Range("L1").Value = "hsdf"
          .Range("M1").Value = "htrab"
          .Range("N1").Value = "smb"
          .Range("O1").Value = "slv"
          .Range("P1").Value = "ssdf"
          .Range("Q1").Value = "ics"
          .Range("R1").Value = "adicionalp"
          .Range("S1").Value = "transpp"
          .Range("T1").Value = "iess"
          .Range("U1").Value = "prestamo"
          .Range("V1").Value = "multa"
          .Range("W1").Value = "sueldopagar"
          .Range("X1").Value = "pagofecha1"
          .Range("Y1").Value = "pagocheque1"
          .Range("Z1").Value = "pagosueldo1"
          .Range("AA1").Value = "pagofecha2"
          .Range("AB1").Value = "pagocheque2"
          .Range("AC1").Value = "pagosueldo2"
          .Range("AD1").Value = "pagofecha3"
          .Range("AE1").Value = "pagocheque3"
          .Range("AF1").Value = "pagosueldo3"
          .Range("AG1").Value = "pagofecha4"
          .Range("AH1").Value = "pagocheque4"
          .Range("AI1").Value = "pagosueldo4"
          .Range("AJ1").Value = "pagofecha5"
          .Range("AK1").Value = "pagocheque5"
          .Range("AL1").Value = "pagosueldo5"
          .Range("AM1").Value = "totalsueldos"
          .Range("AN1").Value = "prestamoquirog"
          .Range("AO1").Value = "impuestorenta"
          .Range("AP1").Value = "d3pag"
          .Range("AQ1").Value = "d4pag"
          .Range("AR1").Value = "vacpag"

          Dim t As Integer = 0
          For Each _dr As DSReciboPago.v_recibopagoRow In ds.v_recibopago.Rows
            .Range("A" & (t + 2).ToString).Value = _dr.Entida_Codigo
            .Range("B" & (t + 2).ToString).Value = _dr.Entnat_Apellidopaterno.Trim & " " & _dr.Entnat_Apellidomaterno.Trim & " " & _dr.Entnat_Nombres.Trim
            .Range("C" & (t + 2).ToString).Value = _dr.Cedula
            .Range("D" & (t + 2).ToString).Value = _dr.PerPag_fechadesde.Date.ToShortDateString
            .Range("E" & (t + 2).ToString).Value = _dr.PerPag_fechahasta.Date.ToShortDateString
            .Range("F" & (t + 2).ToString).Value = _dr.Seccion
            '.Range("G" & (t + 2).ToString).Value = _dr.Labor
            .Range("H" & (t + 2).ToString).Value = _dr.Patrono
            .Range("I" & (t + 2).ToString).Value = _dr.Asiste_diario
            .Range("J" & (t + 2).ToString).Value = _dr.Asiste_diasintegrales
            .Range("K" & (t + 2).ToString).Value = _dr.Asiste_hlv
            .Range("L" & (t + 2).ToString).Value = _dr.Asiste_hsdf
            .Range("M" & (t + 2).ToString).Value = _dr.Asiste_htrab
            .Range("N" & (t + 2).ToString).Value = _dr.Asiste_smb.ToString("0.00")
            .Range("O" & (t + 2).ToString).Value = _dr.Asiste_slv.ToString("0.00")
            .Range("P" & (t + 2).ToString).Value = _dr.Asiste_ssdf.ToString("0.00")
            .Range("Q" & (t + 2).ToString).Value = _dr.Asiste_ics.ToString("0.00")
            .Range("R" & (t + 2).ToString).Value = _dr.Asiste_adicionalp.ToString("0.00")
            .Range("S" & (t + 2).ToString).Value = _dr.Asiste_transpp.ToString("0.00")
            .Range("T" & (t + 2).ToString).Value = _dr.Asiste_iess.ToString("0.00")
            .Range("U" & (t + 2).ToString).Value = _dr.Asiste_prestamo.ToString("0.00")
            .Range("V" & (t + 2).ToString).Value = _dr.Asiste_multa.ToString("0.00")
            .Range("W" & (t + 2).ToString).Value = _dr.Asiste_sueldopagar.ToString("0.00")
            .Range("AN" & (t + 2).ToString).Value = _dr.Asiste_prestamoquirog.ToString("0.00")
            .Range("AO" & (t + 2).ToString).Value = _dr.Asiste_impuestorenta.ToString("0.00")
            .Range("AP" & (t + 2).ToString).Value = _dr.Asiste_d3pag.ToString("0.00")
            .Range("AQ" & (t + 2).ToString).Value = _dr.Asiste_d4pag.ToString("0.00")
            .Range("AR" & (t + 2).ToString).Value = _dr.Asiste_vacpag.ToString("0.00")
            'Dim dscheques as DataTable
            'dscheques = ChequePago.RetornarChequesPeriodo(mOp, New Empleado(mOp, CInt(_dr("Entida_Codigo"))), Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes)

            'If Not dscheques Is Nothing AndAlso dscheques.Tables.Count > 0 AndAlso dscheques.Rows.Count > 0 Then
            '  Dim h As Integer = 0
            '  Dim totcheques As Decimal = 0
            '  For Each _drch As DataRow In dscheques.Rows
            '    h += 1
            '    Dim fechach As DateTime
            '    fechach = CDate(_drch("pgv_fecha"))
            '    Dim numche As Integer
            '    numche = CInt(_drch("chq_numero"))
            '    Dim valorche As Decimal
            '    valorche = CDec(_drch("pgv_valor"))
            '    totcheques += valorche

            '    Select Case h
            '      Case 1
            '        .Range("W" & (t + 2).ToString).Value = fechach
            '        .Range("X" & (t + 2).ToString).Value = numche
            '        .Range("Y" & (t + 2).ToString).Value = valorche.ToString("0.00")
            '      Case 2
            '        .Range("Z" & (t + 2).ToString).Value = fechach
            '        .Range("AA" & (t + 2).ToString).Value = numche
            '        .Range("AB" & (t + 2).ToString).Value = valorche.ToString("0.00")
            '      Case 3
            '        .Range("AC" & (t + 2).ToString).Value = fechach
            '        .Range("AD" & (t + 2).ToString).Value = numche
            '        .Range("AE" & (t + 2).ToString).Value = valorche.ToString("0.00")
            '      Case 4
            '        .Range("AF" & (t + 2).ToString).Value = fechach
            '        .Range("AG" & (t + 2).ToString).Value = numche
            '        .Range("AH" & (t + 2).ToString).Value = valorche.ToString("0.00")
            '      Case 5
            '        .Range("AI" & (t + 2).ToString).Value = fechach
            '        .Range("AJ" & (t + 2).ToString).Value = numche
            '        .Range("AK" & (t + 2).ToString).Value = valorche.ToString("0.00")
            '    End Select
            '  Next
            '  .Range("AL" & (t + 2).ToString).Value = totcheques.ToString("0.00")
            'End If
            t += 1
          Next
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\fterecibopago.xls"
        Dim rutobj As String = Sistema.DirectorioRaiz & "\Formatos\Recibos_de_pago.doc"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(rutobj)
        'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
        WordApp.Visible = True
        WordDocument.Activate()
        With WordDocument.MailMerge
          .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `Hoja1$`")
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
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Generó recibos de pagos periodo {0} patrono {1} Tipo de contrato {2}", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarReciboPagoSemanalDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _seccion As WWTSParametroDet, ByVal _sexo As String) As DSReciboPago
    Dim bReturn As Boolean = True
    Dim dsResult As New DSReciboPago
    With _OperadorDatos
      .AgregarParametro("@accion", "rps")
      .AgregarParametro("@esdestajo", _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo)
      Select Case _tiporeporte
        Case tipolistadofirmas.Seccion
          .AgregarParametro("@Parame_Seccion", _seccion.Parame_Codigo)
          .AgregarParametro("@Pardet_Seccion", _seccion.Pardet_Secuencia)
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        .AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      ''.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      '.AgregarParametro("@anio", _periodo.PerPag_anio)
      '.AgregarParametro("@mes", _periodo.PerPag_mes)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .Procedimiento = "proc_asistencia"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSReciboPago
        DataAdapter.Fill(dsResult, "v_recibopago")
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

  Private Sub btnrecibosemanal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecibosemanal.Click
    Try
      'Dim info As New crpResumenPago
      'info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de resumen para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      'info.DataDefinition.FormulaFields("Filtro").Text = "''"
      'info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim ds As New DSReciboPago
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        'info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.pardet_descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        'info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarReciboPagoSemanalDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo)

      Dim rangoprdos As New PeriodoPagoList
      rangoprdos = PeriodoPagoList.ObtenerLista(Sistema.OperadorDatos, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PardetPeriodoPago, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio)
      If rangoprdos Is Nothing OrElse rangoprdos.Count = 0 Then
        MsgBox("Error al tratar de seleccionar periodos por mes", MsgBoxStyle.Critical, "Error")
        Exit Sub
      End If

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)

        excelApp.Visible = False
        With excelWorksheet
          .Columns().ColumnWidth = 80
          .Range("A1").Value = "Entida_Codigo"
          .Columns("A:A").NumberFormat = "@"
          .Range("B1").Value = "NombreCompleto"
          .Range("C1").Value = "Cedula"
          .Columns("C:E").NumberFormat = "@"
          .Range("D1").Value = "desde"
          .Range("E1").Value = "hasta"
          .Range("F1").Value = "pardet_descripcion"
          .Range("G1").Value = "NombreCompleto"
          .Range("H1").Value = "asi_diario"
          .Range("I1").Value = "asi_diainteg"
          .Range("J1").Value = "asi_hlv"
          .Range("K1").Value = "asi_hsdf"
          .Range("L1").Value = "asi_htrab"
          .Range("M1").Value = "asi_smb"
          .Columns("M:V").NumberFormat = "@"
          .Range("N1").Value = "asi_slv"
          .Range("O1").Value = "asi_ssdf"
          .Range("P1").Value = "asi_ics"
          .Range("Q1").Value = "asi_adicionalp"
          .Range("R1").Value = "asi_transpp"
          .Range("S1").Value = "asi_iess"
          .Range("T1").Value = "asi_prestamo"
          .Range("U1").Value = "asi_multa"
          .Range("V1").Value = "asi_sueldopagar"

          .Range("W1").Value = "pagofecha1"
          .Range("X1").Value = "pagometa1"
          .Range("Y1").Value = "pagotarea1"
          .Range("Z1").Value = "pagotareacant1"
          .Range("AA1").Value = "pagosueldo1"
          .Columns("AA:AA").NumberFormat = "@"

          .Range("AB1").Value = "pagofecha2"
          .Range("AC1").Value = "pagometa2"
          .Range("AD1").Value = "pagotarea2"
          .Range("AE1").Value = "pagotareacant2"
          .Range("AF1").Value = "pagosueldo2"
          .Columns("AF:AF").NumberFormat = "@"

          .Range("AG1").Value = "pagofecha3"
          .Range("AH1").Value = "pagometa3"
          .Range("AI1").Value = "pagotarea3"
          .Range("AJ1").Value = "pagotareacant3"
          .Range("AK1").Value = "pagosueldo3"
          .Columns("AK:AK").NumberFormat = "@"

          .Range("AL1").Value = "pagofecha4"
          .Range("AM1").Value = "pagometa4"
          .Range("AN1").Value = "pagotarea4"
          .Range("AO1").Value = "pagotareacant4"
          .Range("AP1").Value = "pagosueldo4"
          .Columns("AP:AP").NumberFormat = "@"

          .Range("AQ1").Value = "pagofecha5"
          .Range("AR1").Value = "pagometa5"
          .Range("AS1").Value = "pagotarea5"
          .Range("AT1").Value = "pagotareacant5"
          .Range("AU1").Value = "pagosueldo5"
          .Columns("AU:AU").NumberFormat = "@"

          .Range("AV1").Value = "pagofecha6"
          .Range("AW1").Value = "pagometa6"
          .Range("AX1").Value = "pagotarea6"
          .Range("AY1").Value = "pagotareacant6"
          .Range("AZ1").Value = "pagosueldo6"
          .Columns("AZ:AZ").NumberFormat = "@"

          .Range("BA1").Value = "pagofecha7"
          .Range("BB1").Value = "pagometa7"
          .Range("BC1").Value = "pagotarea7"
          .Range("BD1").Value = "pagotareacant7"
          .Range("BE1").Value = "pagosueldo7"
          .Columns("BE:BL").NumberFormat = "@"

          .Range("BF1").Value = "totaltarea"
          .Range("BG1").Value = "totalsueldos"

          .Range("BH1").Value = "prestquirog"
          .Range("BI1").Value = "impuestorenta"
          .Range("BJ1").Value = "d3pag"
          .Range("BK1").Value = "d4pag"
          .Range("BL1").Value = "vacpag"

          Dim t As Integer = 0
          For Each _dr As DataRow In ds.Tables(0).Rows
            .Range("A" & (t + 2).ToString).Value = CStr(_dr("Entida_Codigo"))
            .Range("B" & (t + 2).ToString).Value = CStr(_dr("per_paterno")).Trim & " " & CStr(_dr("per_materno")).Trim & " " & CStr(_dr("per_nombres")).Trim
            .Range("C" & (t + 2).ToString).Value = CStr(_dr("cedula"))
            .Range("D" & (t + 2).ToString).Value = CDate(_dr("PerPag_FechaDesde")).Date.ToShortDateString
            .Range("E" & (t + 2).ToString).Value = CDate(_dr("PerPag_FechaHasta")).Date.ToShortDateString
            .Range("F" & (t + 2).ToString).Value = CStr(_dr("pardet_descripcion"))
            .Range("G" & (t + 2).ToString).Value = CStr(_dr("NombreCompleto"))
            .Range("H" & (t + 2).ToString).Value = CDec(_dr("asi_diario"))
            .Range("I" & (t + 2).ToString).Value = CDec(_dr("asi_diainteg"))
            .Range("J" & (t + 2).ToString).Value = CDec(_dr("asi_hlv"))
            .Range("K" & (t + 2).ToString).Value = CDec(_dr("asi_hsdf"))
            .Range("L" & (t + 2).ToString).Value = CDec(_dr("asi_htrab"))
            .Range("M" & (t + 2).ToString).Value = CDec(_dr("asi_smb")).ToString("0.00")
            .Range("N" & (t + 2).ToString).Value = CDec(_dr("asi_slv")).ToString("0.00")
            .Range("O" & (t + 2).ToString).Value = CDec(_dr("asi_ssdf")).ToString("0.00")
            .Range("P" & (t + 2).ToString).Value = CDec(_dr("asi_ics")).ToString("0.00")
            .Range("Q" & (t + 2).ToString).Value = CDec(_dr("asi_adicionalp")).ToString("0.00")
            .Range("R" & (t + 2).ToString).Value = CDec(_dr("asi_transpp")).ToString("0.00")
            .Range("S" & (t + 2).ToString).Value = CDec(_dr("asi_iess")).ToString("0.00")
            .Range("T" & (t + 2).ToString).Value = CDec(_dr("asi_prestamo")).ToString("0.00")
            .Range("U" & (t + 2).ToString).Value = CDec(_dr("asi_multa")).ToString("0.00")
            .Range("V" & (t + 2).ToString).Value = CDec(_dr("asi_sueldopagar")).ToString("0.00")
            .Range("BH" & (t + 2).ToString).Value = CDec(_dr("asi_prestamoquirog")).ToString("0.00")
            .Range("BI" & (t + 2).ToString).Value = CDec(_dr("asi_impuestorenta")).ToString("0.00")
            .Range("BJ" & (t + 2).ToString).Value = CDec(_dr("asi_d3pag")).ToString("0.00")
            .Range("BK" & (t + 2).ToString).Value = CDec(_dr("asi_d4pag")).ToString("0.00")
            .Range("BL" & (t + 2).ToString).Value = CDec(_dr("asi_vacpag")).ToString("0.00")

            Dim _asistencia As New Asistencia(Sistema.OperadorDatos, New Empleado(Sistema.OperadorDatos, CInt(_dr("Entida_Codigo"))), Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.Periodo)
            If _asistencia IsNot Nothing Then
              Dim h As Integer = 0
              Dim totcant As Decimal = 0
              Dim totdia As Decimal = 0
              For Each _dia As DiaAsistencia In _asistencia.Dias
                Dim mMostrar As Boolean = True
                If (_dia.DiaAsi_Fecha.DayOfWeek = DayOfWeek.Saturday Or _dia.DiaAsi_Fecha.DayOfWeek = DayOfWeek.Sunday) And Not _dia.DiaAsi_Asistencia Then
                  mMostrar = False
                End If
                If mMostrar Then
                  h += 1
                  If h > 7 Then
                    Exit For
                  End If
                  Dim fechach As DateTime = _dia.DiaAsi_Fecha
                  Dim meta As Integer = _dia.Tarea.Tarea_Meta
                  Dim tarea As String = _dia.Tarea.Tarea_Descripcion
                  If Not _dia.DiaAsi_Asistencia Then
                    tarea = "--FALTA--"
                    meta = 0
                  End If
                  Dim cant As Decimal = _dia.DiaAsi_Jornada + _dia.DiaAsi_Sobret50 + _dia.DiaAsi_Sobret100 + _dia.DiaAsi_Sobret25
                  'Dim valor As Decimal = _dia.TotalDiario
                  totcant += cant
                  'totdia += valor

                  Select Case h
                    Case 1
                      .Range("W" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("X" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("Y" & (t + 2).ToString).Value = tarea
                      .Range("Z" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("AA" & (t + 2).ToString).Value = valor.ToString("0.00")
                    Case 2
                      .Range("AB" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("AC" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("AD" & (t + 2).ToString).Value = tarea
                      .Range("AE" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("AF" & (t + 2).ToString).Value = valor.ToString("0.00")
                    Case 3
                      .Range("AG" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("AH" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("AI" & (t + 2).ToString).Value = tarea
                      .Range("AJ" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("AK" & (t + 2).ToString).Value = valor.ToString("0.00")
                    Case 4
                      .Range("AL" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("AM" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("AN" & (t + 2).ToString).Value = tarea
                      .Range("AO" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("AP" & (t + 2).ToString).Value = valor.ToString("0.00")
                    Case 5
                      .Range("AQ" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("AR" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("AS" & (t + 2).ToString).Value = tarea
                      .Range("AT" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("AU" & (t + 2).ToString).Value = valor.ToString("0.00")
                    Case 6
                      .Range("AV" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("AW" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("AX" & (t + 2).ToString).Value = tarea
                      .Range("AY" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("AZ" & (t + 2).ToString).Value = valor.ToString("0.00")
                    Case 7
                      .Range("BA" & (t + 2).ToString).Value = fechach.ToLongDateString
                      .Range("BB" & (t + 2).ToString).Value = meta.ToString("0")
                      .Range("BC" & (t + 2).ToString).Value = tarea
                      .Range("BD" & (t + 2).ToString).Value = cant.ToString("0.00")
                      '.Range("BE" & (t + 2).ToString).Value = valor.ToString("0.00")
                  End Select
                End If
              Next
              .Range("BF" & (t + 2).ToString).Value = totcant.ToString("0.00")
              .Range("BG" & (t + 2).ToString).Value = totdia.ToString("0.00")
            End If
            t += 1
          Next
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\fterecibopagosemanal.xls"
        Dim rutobj As String = Sistema.DirectorioRaiz & "\Formatos\Recibos_de_pago_Semanal.doc"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        excelBook.Close()
        excelApp.Visible = True
        excelApp.Quit()

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(rutobj)
        'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
        WordApp.Visible = True
        WordDocument.Activate()
        With WordDocument.MailMerge
          .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `Hoja1$`")
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
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Generó recibos de pagos semanal periodo {0} patrono {1} Tipo de contrato {2}", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub
#End Region

  Private Sub chksoloclase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoloclase.CheckedChanged
    Me.CtlClase1.Enabled = Me.chksoloclase.Checked
  End Sub

  Private Sub rdosoloseccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdosoloseccion.CheckedChanged
    Me.CtlSeccion1.Enabled = rdosoloseccion.Checked
  End Sub

  Private Sub rdosolosexo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdosolosexo.CheckedChanged
    Me.cbosexo.Enabled = rdosolosexo.Checked
  End Sub

  Private Sub CtlBuscaEmpleadosPeriodo1_CambioTipoContrato(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleadosPeriodo1.CambioTipoContrato
    Me.rdosoloseccion.Enabled = Not Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo
    Me.CtlSeccion1.Enabled = Not Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo And rdosoloseccion.Checked
    Me.cbosemana.Enabled = Not Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_PeriodoPagoEnum = Enumerados.enumPeriodoPago.Semanal
    'Me.CtlSeccion1.Enabled = rdosoloseccion.Checked
  End Sub

#Region "Reporte de asistencias y faltas"
  Private Sub btnasisfaltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasisfaltas.Click
    imprimir_asistfaltas(False)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió Listado de asistencia", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))
  End Sub

  Sub imprimir_asistfaltas(ByVal _solofaltas As Boolean)
    Try
      Dim info As ReportClass
      info = New crpListadoAsistFaltas

      Dim _fechadesde As DateTime = Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
      If Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_PeriodoPagoEnum = Enumerados.enumPeriodoPago.Semanal Then
        info.DataDefinition.FormulaFields("Filtro").Text = "''"
      Else
        If Me.cbosemana.SelectedIndex = 0 Then
          info.DataDefinition.FormulaFields("Filtro").Text = "'Primera semana'"
        Else
          info.DataDefinition.FormulaFields("Filtro").Text = "'Segunda semana'"
          _fechadesde = _fechadesde.AddDays(7)
        End If
      End If

      info.DataDefinition.FormulaFields("fechads1").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.DayOfWeek)) & "'"
      info.DataDefinition.FormulaFields("fechads2").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.AddDays(1).DayOfWeek)) & "'"
      info.DataDefinition.FormulaFields("fechads3").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.AddDays(2).DayOfWeek)) & "'"
      info.DataDefinition.FormulaFields("fechads4").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.AddDays(3).DayOfWeek)) & "'"
      info.DataDefinition.FormulaFields("fechads5").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.AddDays(4).DayOfWeek)) & "'"
      info.DataDefinition.FormulaFields("fechads6").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.AddDays(5).DayOfWeek)) & "'"
      info.DataDefinition.FormulaFields("fechads7").Text = "'" & Enumerados.DiaSemanaList.RetornarDescripcion(CInt(_fechadesde.AddDays(6).DayOfWeek)) & "'"

      info.DataDefinition.FormulaFields("fecha1").Text = "'" & _fechadesde.ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fecha2").Text = "'" & _fechadesde.AddDays(1).ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fecha3").Text = "'" & _fechadesde.AddDays(2).ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fecha4").Text = "'" & _fechadesde.AddDays(3).ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fecha5").Text = "'" & _fechadesde.AddDays(4).ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fecha6").Text = "'" & _fechadesde.AddDays(5).ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fecha7").Text = "'" & _fechadesde.AddDays(6).ToShortDateString & "'"

      If _solofaltas Then
        info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de faltas para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      Else
        info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de asistencias para personal " & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion & "'"
      End If

      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"

      Dim ds As New DSasisfaltas
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.Pardet_Descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      ds = RetornarListadoAsisFaltasDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, _fechadesde, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, _solofaltas)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperFanfoldUS
        Me.crv_resumenperiodo.Zoom(1)
        Me.crv_resumenperiodo.ReportSource = info
        Me.crv_resumenperiodo.DisplayToolbar = True
        Me.crv_resumenperiodo.ShowRefreshButton = False
        'Me.crv_resumenperiodo.DisplayGroupTree = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnfaltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfaltas.Click
    imprimir_asistfaltas(True)

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió Listado de faltas", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))
  End Sub

  Public Function RetornarListadoAsisFaltasDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago, ByVal _fechainicio As Date, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _seccion As WWTSParametroDet, ByVal _sexo As String, ByVal _solofaltas As Boolean) As DSasisfaltas
    Dim bReturn As Boolean = True
    Dim dsResult As New DSasisfaltas
    With _OperadorDatos
      .AgregarParametro("@accion", "dia")
      .AgregarParametro("@esdestajo", _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo)
      .AgregarParametro("@solofaltas", _solofaltas)
      .AgregarParametro("@fechainicio", _fechainicio.Date)
      Select Case _tiporeporte
        Case tipolistadofirmas.Seccion
          .AgregarParametro("@Parame_Seccion", _seccion.Parame_Codigo)
          .AgregarParametro("@Pardet_Seccion", _seccion.Pardet_Secuencia)
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        .AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .Procedimiento = "proc_asistencia"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSasisfaltas
        DataAdapter.Fill(dsResult, "vw_asisfaltas")
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
#End Region

  Private Sub btncontador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontador.Click
    Try
      Dim info As ReportClass
      info = New crpContadorAsis

      info.DataDefinition.FormulaFields("Titulo").Text = "'Contador de personal'"
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlPatrono2.Patrono.NombreCompleto & "'"
      info.DataDefinition.FormulaFields("fecdesde").Text = "'" & Me.CtlPeriodo2.PeriodoPago.PerPag_FechaDesde.ToShortDateString & "'"

      Dim ds As New DSContador
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosolosexo2.Checked Then
        _sexo = Me.cbosexo2.SelectedItem.Substring(0, 1)
        info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo2.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase2.Checked Then
        _clase = Me.CtlClase2.ParametroDet
      End If

      ds = RetornarContadorAsistenciaDS(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlPeriodo2.PeriodoPago, Me.CtlPatrono2.Patrono, _clase, _sexo)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crvcontador.Zoom(1)
        Me.crvcontador.ReportSource = info
        Me.crvcontador.DisplayToolbar = True
        Me.crvcontador.ShowRefreshButton = False
        'Me.crvcontador.DisplayGroupTree = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarContadorAsistenciaDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _periodo As PeriodoPago, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _sexo As String) As DSContador
    Dim bReturn As Boolean = True
    Dim dsResult As New DSContador
    With _OperadorDatos
      .AgregarParametro("@accion", "sec")
      .AgregarParametro("@fechainicio", _periodo.PerPag_FechaDesde)
      Select Case _tiporeporte
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        .AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      ''.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .Procedimiento = "proc_asistencia"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSContador
        DataAdapter.Fill(dsResult, "vw_contador")
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

  Private Sub btngastosseccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngastosseccion.Click
    Try
      Dim info As ReportClass
      info = New crpListadoxSeccion

      Dim filtro As String = String.Empty

      info.DataDefinition.FormulaFields("Titulo").Text = "'Análisis de gastos por sección'"
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlPatrono3.Patrono.NombreCompleto & "'"

      Dim pv As New ParameterValues
      Dim pdv As New ParameterDiscreteValue
      pdv.Value = Me.dtfecdesde.Value
      pv.Add(pdv)
      info.DataDefinition.ParameterFields("fecdesde").ApplyCurrentValues(pv)

      pv = New ParameterValues
      pdv = New ParameterDiscreteValue
      pdv.Value = Me.dtfechasta.Value
      pv.Add(pdv)
      info.DataDefinition.ParameterFields("fechasta").ApplyCurrentValues(pv)

      Dim ds As New DSlistadoxseccion
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipocontrato As TipoContrato = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosolosexo3.Checked Then
        _sexo = Me.cbosexo3.SelectedItem.Substring(0, 1)
        filtro = Me.cbosexo3.SelectedItem & " "
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase3.Checked Then
        _clase = Me.CtlClase3.ParametroDet
        filtro += "Clase:" & _clase.Pardet_Descripcion & " "
      End If
      If chksolotipocontrato.Checked Then
        _tipocontrato = Me.CtlTipoContrato1.TipoContrato
        filtro += "Tipo de contrato:" & _tipocontrato.TipCon_Descripcion & " "
      End If
      info.DataDefinition.FormulaFields("Filtro").Text = "'" & filtro & "'"

      ds = RetornarAnalisisGastosDS(Sistema.OperadorDatos, _tipolistadofirmas, dtfecdesde.Value.Date, dtfechasta.Value.Date, Me.CtlPatrono3.Patrono, _clase, _sexo, _tipocontrato)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperFanfoldUS
        Me.crvgastosporseccion.Zoom(1)
        Me.crvgastosporseccion.ReportSource = info
        Me.crvgastosporseccion.DisplayToolbar = True
        Me.crvgastosporseccion.ShowRefreshButton = False
        'Me.crvgastosporseccion.DisplayGroupTree = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  Public Function RetornarAnalisisGastosDS(ByVal _OperadorDatos As OperadorDatos, ByVal _tiporeporte As tipolistadofirmas, ByVal _fecdesde As DateTime, ByVal _fechasta As DateTime, ByVal _patrono As Patrono, ByVal _clase As WWTSParametroDet, ByVal _sexo As String, ByVal _tipocontrato As TipoContrato) As DSlistadoxseccion
    Dim bReturn As Boolean = True
    Dim dsResult As New DSlistadoxseccion
    With _OperadorDatos
      .AgregarParametro("@accion", "LSC")
      .AgregarParametro("@fechainicio", _fecdesde)
      .AgregarParametro("@fechafin", _fechasta)
      Select Case _tiporeporte
        Case tipolistadofirmas.Sexo
          .AgregarParametro("@sexo", _sexo)
      End Select
      If Not _clase Is Nothing Then
        .AgregarParametro("@Parame_Clase", _clase.Parame_Codigo)
        .AgregarParametro("@Pardet_Clase", _clase.Pardet_Secuencia)
      End If
      If Not _tipocontrato Is Nothing Then
        .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      End If
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .Procedimiento = "proc_asistencia"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSlistadoxseccion
        DataAdapter.Fill(dsResult, "v_resumenperiodo")
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

  Private Sub rdosolosexo2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdosolosexo2.CheckedChanged
    Me.cbosexo2.Enabled = Me.rdosolosexo2.Checked
  End Sub

  Private Sub rdosolosexo3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdosolosexo3.CheckedChanged
    Me.cbosexo3.Enabled = Me.rdosolosexo3.Checked
  End Sub

  Private Sub chksoloclase2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoloclase2.CheckedChanged
    Me.CtlClase2.Enabled = Me.chksoloclase2.Checked
  End Sub

  Private Sub chksoloclase3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoloclase3.CheckedChanged
    Me.CtlClase3.Enabled = Me.chksoloclase3.Checked
  End Sub

  Private Sub chksolotipocontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolotipocontrato.CheckedChanged
    Me.CtlTipoContrato1.Enabled = Me.chksolotipocontrato.Checked
  End Sub

  'Private Sub btnmostrarctble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarctble.Click
  '  Mostrar_contable()

  '  Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió resumen contable", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))
  'End Sub

#Region "Préstamo quirografario"
  Private Sub btnprestquirog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprestquirog.Click
    Mostrar_listprestquirog()

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Imprimió préstamo quirografario", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))
  End Sub

  Private Sub Mostrar_listprestquirog()
    Try
      Dim info As ReportClass
      info = New crpListaprestquirog

      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de descuentos de préstamos quirografarios'"
      info.DataDefinition.FormulaFields("Filtro").Text = "''"
      info.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto & "'"
      info.DataDefinition.FormulaFields("desde").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString & "'"
      info.DataDefinition.FormulaFields("hasta").Text = "'" & Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString & "'"

      Dim ds As New dslistaprestquirog

      ds = RetornarListadoPrestQuirogDS(Sistema.OperadorDatos, Me.CtlBuscaEmpleadosPeriodo1.Patrono, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crv_contable.Zoom(1)
        Me.crv_contable.ReportSource = info
        Me.crv_contable.DisplayToolbar = True
        Me.crv_contable.ShowRefreshButton = False
        'Me.crv_contable.DisplayGroupTree = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  Public Function RetornarListadoPrestQuirogDS(ByVal _OperadorDatos As OperadorDatos, ByVal _patrono As Patrono, ByVal _tipocontrato As TipoContrato, ByVal _periodo As PeriodoPago) As dslistaprestquirog
    Dim bReturn As Boolean = True
    Dim dsResult As New dslistaprestquirog
    With _OperadorDatos
      .AgregarParametro("@accion", "LPQ")
      '.AgregarParametro("@hac_codigo", _patrono.Hac_codigo)
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      .AgregarParametro("@PerPag_FechaDesde", _periodo.PerPag_FechaDesde)
      .AgregarParametro("@Parame_PeriodoPago", _periodo.Parame_PeriodoPago)
      .AgregarParametro("@Pardet_PeriodoPago", _periodo.Pardet_PeriodoPago)
      .Comando.CommandText = "proc_asistencia"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New dslistaprestquirog
        DataAdapter.Fill(dsResult, "vw_listaprestquirog")
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
#End Region

  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    Try
      Dim _result As New AsistenciaList
      Dim _seccion As WWTSParametroDet = Nothing
      Dim _sexo As String = Nothing
      Dim _clase As WWTSParametroDet = Nothing
      Dim _tipolistadofirmas As tipolistadofirmas = tipolistadofirmas.Todos
      If Me.rdosoloseccion.Checked Then
        _seccion = Me.CtlSeccion1.ParametroDet
        'info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.CtlSeccion1.ParametroDet.pardet_descripcion & "'"
        _tipolistadofirmas = tipolistadofirmas.Seccion
      ElseIf Me.rdosolosexo.Checked Then
        _sexo = Me.cbosexo.SelectedItem.Substring(0, 1)
        'info.DataDefinition.FormulaFields("Filtro").Text = "'" & Me.cbosexo.SelectedItem & "'"
        _tipolistadofirmas = tipolistadofirmas.Sexo
      End If
      If chksoloclase.Checked Then
        _clase = Me.CtlClase1.ParametroDet
      End If

      _result = AsistenciaList.RetornarListadoFirma(Sistema.OperadorDatos, _tipolistadofirmas, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, Me.CtlBuscaEmpleadosPeriodo1.Patrono, _clase, _seccion, _sexo, Me.chkno0neto.Checked, Me.chknoninguncero.Checked)

      If _result Is Nothing OrElse _result.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)

        excelApp.Visible = False
        With excelWorksheet
          .Columns("A:Z").ColumnWidth = 10

          .Range("A1").Value = "TipoContrato"
          .Columns("B:C").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern
          .Range("B1").Value = "Fechaingreso"
          .Range("C1").Value = "Fechasalida"

          .Columns("D:F").numberformat = "@"
          .Columns("D:D").ColumnWidth = 13
          .Range("D1").Value = "Cedula"
          .Range("E1").Value = "Codigo"
          .Columns("F:F").ColumnWidth = 150
          .Range("F1").Value = "Nombres"

          .Columns("G:U").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
          .Range("G1").Value = "Sueldobase"
          .Range("H1").Value = "Adicional"
          .Range("I1").Value = "Transporte"
          .Range("J1").Value = "Sobret"
          .Range("K1").Value = "IESS"
          .Range("L1").Value = "d3" '10
          .Range("M1").Value = "d4"
          .Range("N1").Value = "Vacaciones"
          .Range("O1").Value = "FondoReserva"
          .Range("P1").Value = "Utilidades"
          .Range("Q1").Value = "Bonos"
          .Range("R1").Value = "Prestamos"
          .Range("S1").Value = "PrestamoQuirog"
          .Range("T1").Value = "CancelacionPrestamos"
          .Range("U1").Value = "Multas"
          .Range("V1").Value = "ImpuestoRenta"

          .Columns("W:W").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern
          .Range("W1").Value = "FechaPago"

          .Columns("X:Y").numberformat = "0"
          .Range("X1").Value = "ChequeNo"

          .Range("Y1").Value = "DiasLaborables"
          .Columns("Z:AA").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
          .Range("Z1").Value = "HoraE50p"
          .Range("AA1").Value = "HorasE100p"
          .Columns("AB:AB").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern
          .Range("AB1").Value = "FechaPeriodo"

          Dim t As Integer = 0
          For Each _asis As Asistencia In _result
            If Not _asis.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
              .Cells(2 + t, 1).value = _asis.Tipocontrato.TipCon_Codigo
              .Cells(2 + t, 2).value = _asis.Contrato.Contra_Desde.ToShortDateString
              If _asis.Contrato.Contra_Hasta = Nothing Then
                .Cells(2 + t, 3).value = _asis.Contrato.Contra_Hasta.ToShortDateString
              End If
            End If

            .Cells(2 + t, 4).value = _asis.Empleado.Cedula
            .Cells(2 + t, 5).value = _asis.Empleado.Entida_Codigo
            .Cells(2 + t, 6).value = _asis.Empleado.NombreCompleto
            '.Cells(2 + t, 7).value = _asis.Asiste_S0
            '.Cells(2 + t, 8).value = _asis.Asiste_AdicionalP
            '.Cells(2 + t, 9).value = _asis.Asiste_TranspP
            '.Cells(2 + t, 10).value = _asis.Asiste_S50 + _asis.Asiste_S100

            .Cells(2 + t, 11).value = 0
            .Cells(2 + t, 12).value = 0
            .Cells(2 + t, 13).value = 0
            .Cells(2 + t, 14).value = 0
            .Cells(2 + t, 15).value = 0

            If Not (_asis.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or _asis.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras) Then
              If _asis.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Temporada Then
                '.Cells(2 + t, 12).value = _asis.Asiste_D3Pag
                '.Cells(2 + t, 14).value = _asis.Asiste_VacPag
              Else
                '.Cells(2 + t, 12).value = _asis.Total_ingresos / 12
                '.Cells(2 + t, 14).value = _asis.Total_ingresos / 24
              End If

              Dim config As ConfigRoles
              config = New ConfigRoles(Sistema.OperadorDatos, _asis.Contrato.Patrono.Pais, False)

              .Cells(2 + t, 13).value = config.Cnfrol_salariomv / 360 * (_asis.Asiste_Dias + _asis.Asiste_DiasIntegrales)

              '.Cells(2 + t, 15).value = _asis.Total_ingresos / 12
            End If
            .Cells(2 + t, 16).value = 0
            .Cells(2 + t, 17).value = 0 'BONOS
            .Cells(2 + t, 18).value = _asis.Prestado 'PRESTAMOS
            '.Cells(2 + t, 19).value = _asis.Asiste_PrestamoQuirog
            '.Cells(2 + t, 20).value = _asis.Asiste_Prestamo
            '.Cells(2 + t, 21).value = _asis.Asiste_Multa
            '.Cells(2 + t, 22).value = _asis.Asiste_ImpuestoRenta
            .Cells(2 + t, 23).value = _asis.Periodopago.PerPag_FechaPago
            '.Cells(2 + t, 24).value = _asis.Chq_numero

            .Cells(2 + t, 25).value = _asis.Asiste_Dias
            .Cells(2 + t, 26).value = _asis.Asiste_H50
            .Cells(2 + t, 27).value = _asis.Asiste_H100
            .Cells(2 + t, 28).value = _asis.PerPag_FechaDesde.ToShortDateString

            t += 1
          Next
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\LP" & Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_NumeroPatronal.Trim.Substring(0, 3) & Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion.Trim.Substring(0, 3) & Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.Year.ToString.Trim & Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.Month.ToString.Trim & Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.Day.ToString.Trim & ".dbf"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte, FileFormat:=Excel.XlFileFormat.xlDBF4, CreateBackup:=False)

        excelApp.Visible = True
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1} {2} {3} {4}", "Exportó resumen", Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Descripcion, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, Me.CtlBuscaEmpleadosPeriodo1.Patrono.NombreCompleto))
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmAsistencias_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
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