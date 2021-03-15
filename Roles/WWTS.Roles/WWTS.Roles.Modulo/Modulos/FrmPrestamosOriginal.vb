Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class FrmPrestamosCopy
  Implements IOpcion

  Private tiposprestamos As WWTSParametroDetList

  Private Sub FrmPrestamos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Préstamos/Anticipos"
    Me.CtlBuscaEmpleado1.Op = Sistema.OperadorDatos
    Me.cboversolicitud.SelectedIndex = 2
    Me.cboverprestamos.SelectedIndex = 2
    Me.comboEmpresa1.Op = Sistema.OperadorDatos
    Me.comboEmpresa1.Llenar_datos()

    tiposprestamos = WWTSParametroDetList.ObtenerLista(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoPrestamo)
    Dim _todos As New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoPrestamo, True)
    _todos.Parame_Codigo = 0
    _todos.Pardet_Descripcion = "Mostrar todos"
    tiposprestamos.Insert(0, _todos)
    Me.cbotipo.ComboBox.DataSource = tiposprestamos
    Me.cbotipo.ComboBox.DisplayMember = "Pardet_Descripcion"
    Me.cbotipo.ComboBox.ValueMember = "Pardet_Secuencia"
    Me.cbotipo.ComboBox.SelectedValue = 1
  End Sub

  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(ByVal Value As Contrato)
      mContrato = Value
      Me.TableLayoutPanel1.Enabled = Not Value Is Nothing
      buscar_solicitudes()
      buscar_prestamos()
    End Set
  End Property

  Private Sub CtlBuscaEmpleado1_CambioEmpleado(ByVal sender As Object, ByVal e As EventArgs) Handles CtlBuscaEmpleado1.CambioEmpleado
    Contrato = Me.CtlBuscaEmpleado1.Contrato
  End Sub

#Region "Solicitudes"
  Private WithEvents mSolicitudes As PrestamoList = Nothing

  Sub buscar_solicitudes()
    Me.btnaprobarsolic.Enabled = False
    Me.btnprintsolic.Enabled = False
    If Not mContrato Is Nothing Then
      mSolicitudes = PrestamoList.ObtenerLista(Sistema.OperadorDatos, mContrato, IIf(cboversolicitud.SelectedIndex = 2, PrestamoList.enumReportePrestamo.Todos, IIf(cboversolicitud.SelectedIndex = 0, PrestamoList.enumReportePrestamo.Aprobados, PrestamoList.enumReportePrestamo.NoAprobados)), Nothing, Nothing, IIf(Me.cbotipo.SelectedIndex = 0, Nothing, tiposprestamos(Me.cbotipo.SelectedIndex)))
      Me.dgsolicitudes.ReadOnly = False
    Else
      mSolicitudes = New PrestamoList
      Me.dgsolicitudes.ReadOnly = True
    End If

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"

    Me.dgsolicitudes.Columns.Clear()
    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_Secuencia"
    DataGridViewTextBoxColumn1.HeaderText = "#"
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Presta_Urgente"
    DataGridViewTextBoxColumn2.HeaderText = "Urgente"
    DataGridViewTextBoxColumn2.Width = 50
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_FechaSolicitud"
    DataGridViewTextBoxColumn1.HeaderText = "Fec.Solic."
    DataGridViewTextBoxColumn1.Width = 80
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_FechaAprobacion"
    DataGridViewTextBoxColumn1.HeaderText = "Fec.Aprob."
    DataGridViewTextBoxColumn1.Width = 80
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_ValorSolicitado"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Solic."
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_ValorCuota"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Cuota"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Presta_esAprobado"
    DataGridViewTextBoxColumn2.HeaderText = "Aprobado"
    DataGridViewTextBoxColumn2.Width = 50
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_ValorAprobado"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Aprob."
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_Motivo"
    DataGridViewTextBoxColumn1.HeaderText = "Observaciones"
    DataGridViewTextBoxColumn1.Width = 150
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoPrestamoString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo"
    DataGridViewTextBoxColumn1.Width = 150
    Me.dgsolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.SolicitudPrestamoListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.Prestamo)
    Dim mitemssort As New Infoware.Reglas.SortedView(mSolicitudes)
    SolicitudPrestamoListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub dgsolicitudes_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsolicitudes.RowEnter
    If e.RowIndex >= 0 Then
      Me.btnprintsolic.Enabled = True
      Try
        If Not CType(SolicitudPrestamoListBindingSource.Current, Prestamo).Presta_esAprobado Then
          Me.btnaprobarsolic.Enabled = Restriccion.Restri_VerConfidencial
        End If
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private Sub btnnuevasolic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevasolic.Click
    Me.SolicitudPrestamoListBindingSource.AddNew()
    Me.SolicitudPrestamoListBindingSource.MoveLast()
    Abrir_MantenimientoSolicitudes()
  End Sub

  Private Sub dgsolicitudes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsolicitudes.DoubleClick, btnabrirsolic.Click
    Abrir_MantenimientoSolicitudes()
  End Sub

  Private Sub SolicitudPrestamoListBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SolicitudPrestamoListBindingSource.AddingNew
    Dim _prestamo As New Prestamo(mContrato)
    e.NewObject = _prestamo
  End Sub

  Private Sub dgsolicitudes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgsolicitudes.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        Abrir_MantenimientoSolicitudes()
      Case Keys.Insert
        e.Handled = True
        Me.SolicitudPrestamoListBindingSource.AddNew()
        Me.SolicitudPrestamoListBindingSource.MoveLast()
        Abrir_MantenimientoSolicitudes()
    End Select
  End Sub

  Sub Abrir_MantenimientoSolicitudes()
    If Me.SolicitudPrestamoListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoPrestamos(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoClientes)
    f.Contrato = mContrato
    f.Prestamos = SolicitudPrestamoListBindingSource
    f.ShowDialog()
    If SolicitudPrestamoListBindingSource.Count <= 1 Then
      buscar_solicitudes()
    End If
    f.Dispose()
  End Sub

  Private Sub cboversolicitud_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboversolicitud.SelectedIndexChanged
    buscar_solicitudes()
  End Sub

  Private Sub btnelisolic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelisolic.Click
    If SolicitudPrestamoListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim _prestamo As Prestamo = CType(Me.SolicitudPrestamoListBindingSource.Current, Prestamo)
    Try
      If Not _prestamo.Cancelado Then
        Throw New Exception("No se pueden eliminar las solicitudes no canceladas")
      End If
      If Not _prestamo.Eliminar() Then
        Throw New Exception("No se puede eliminar la solicitud")
      End If

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Eliminó solicitud # {0} de {1} valor {2}", _prestamo.Presta_Secuencia, _prestamo.Contrato.Empleado.NombreCompleto, _prestamo.Presta_ValorAprobado))
      Me.SolicitudPrestamoListBindingSource.RemoveCurrent()
      Me.buscar_prestamos()
    Catch ex As Exception
      MsgBox(String.Format("{0}. {1}", ex.Message, Sistema.OperadorDatos.MsgError), MsgBoxStyle.Information, "Información")
    End Try
  End Sub
#End Region

#Region "Prestamos"
  Private WithEvents mPrestamos As PrestamoList = Nothing

  Sub buscar_prestamos()
    If Not mContrato Is Nothing Then
      mPrestamos = PrestamoList.ObtenerLista(Sistema.OperadorDatos, mContrato, IIf(cboverprestamos.SelectedIndex = 2, PrestamoList.enumReportePrestamo.Aprobados, IIf(cboverprestamos.SelectedIndex = 0, PrestamoList.enumReportePrestamo.Cancelados, PrestamoList.enumReportePrestamo.NoCancelados)), Nothing, Nothing, IIf(Me.cbotipo.SelectedIndex = 0, Nothing, tiposprestamos(Me.cbotipo.SelectedIndex)))
      Me.dgprestamos.ReadOnly = False
    Else
      mPrestamos = New PrestamoList
      Me.dgprestamos.ReadOnly = True
    End If

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"

    Me.dgprestamos.Columns.Clear()
    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_Secuencia"
    DataGridViewTextBoxColumn1.HeaderText = "#"
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_FechaAprobacion"
    DataGridViewTextBoxColumn1.HeaderText = "Fec.Aprob."
    DataGridViewTextBoxColumn1.Width = 80
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_ValorAprobado"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Aprob."
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Presta_ValorCuota"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Cuota"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "TotalPagado"
    DataGridViewTextBoxColumn1.HeaderText = "Total Pagado"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 55
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Cancelado"
    DataGridViewTextBoxColumn2.HeaderText = "Cancelado"
    DataGridViewTextBoxColumn2.Width = 55
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoPrestamoString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo"
    DataGridViewTextBoxColumn1.Width = 150
    Me.dgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.PrestamoListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.Prestamo)
    Dim mitemssort As New Infoware.Reglas.SortedView(mPrestamos)
    PrestamoListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub cboverprestamos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboverprestamos.SelectedIndexChanged
    buscar_prestamos()
  End Sub


  Private Sub dgprestamos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgprestamos.DoubleClick, btnabrirprest.Click
    Abrir_MantenimientoPrestamos()
  End Sub

  Private Sub dgprestamos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgprestamos.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        Abrir_MantenimientoPrestamos()
      Case Keys.Insert
        e.Handled = True
        Abrir_MantenimientoPrestamos()
    End Select
  End Sub

  Sub Abrir_MantenimientoPrestamos()
    If Me.PrestamoListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoPrestamos(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoClientes)
    f.Contrato = mContrato
    f.Prestamos = PrestamoListBindingSource
    f.ShowDialog()
    If PrestamoListBindingSource.Count <= 1 Then
      buscar_solicitudes()
    End If
    buscar_prestamos()
    f.Dispose()
  End Sub

  Private Sub btneliprest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliprest.Click
    If PrestamoListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim _prestamo As Prestamo = CType(PrestamoListBindingSource.Current, Prestamo)
    Try
      If _prestamo.TotalPagado > 0 Then
        If Not _prestamo.Cancelado Then
          Throw New Exception("No se pueden eliminar los préstamos no cancelados")
        End If
      End If
      If Not _prestamo.Eliminar() Then
        Throw New Exception("No se puede eliminar el préstamo")
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Eliminó préstamo # {0} de {1} valor {2}", _prestamo.Presta_Secuencia, _prestamo.Contrato.Empleado.NombreCompleto, _prestamo.Presta_ValorAprobado))
      Me.PrestamoListBindingSource.RemoveCurrent()
      Me.buscar_solicitudes()
    Catch ex As Exception
      MsgBox(String.Format("{0}. {1}", ex.Message, Sistema.OperadorDatos.MsgError), MsgBoxStyle.Information, "Información")
    End Try
  End Sub

  Private Sub dgprestamos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgprestamos.CurrentCellChanged
    buscar_detprestamos()
  End Sub
#End Region

#Region "Detalles de prestamos"
  Sub buscar_detprestamos()
    If PrestamoListBindingSource.DataSource Is Nothing OrElse Me.PrestamoListBindingSource.Current Is Nothing Then
      PrestamoDetListBindingSource.DataSource = Nothing
      Me.dgdetalles.ReadOnly = True
    Else

      Dim estilonum2 As New DataGridViewCellStyle()
      estilonum2.Format = "N2"

      Me.dgdetalles.Columns.Clear()
      Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "DetPre_Secuencia"
      DataGridViewTextBoxColumn1.HeaderText = "#"
      DataGridViewTextBoxColumn1.Width = 50
      Me.dgdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "DetPre_Fecha"
      DataGridViewTextBoxColumn1.HeaderText = "Fec.Pago"
      DataGridViewTextBoxColumn1.Width = 80
      Me.dgdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "DetPre_Valor"
      DataGridViewTextBoxColumn1.HeaderText = "Valor Pagado"
      DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
      DataGridViewTextBoxColumn1.Width = 50
      Me.dgdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      Me.PrestamoDetListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.PrestamoDet)
      Dim mitemssort As New Infoware.Reglas.SortedView(CType(PrestamoListBindingSource.Current, Prestamo).PrestamoDets)
      PrestamoDetListBindingSource.DataSource = mitemssort

      Me.dgdetalles.ReadOnly = False
    End If
  End Sub

  Private Sub btnnuevodet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevodet.Click
    If PrestamoListBindingSource.Current Is Nothing OrElse CType(PrestamoListBindingSource.Current, Prestamo).Pardet_TipoPrestamo = 5 Then
      Exit Sub
    End If
    Me.PrestamoDetListBindingSource.AddNew()
    Me.PrestamoDetListBindingSource.MoveLast()
    Abrir_MantenimientoDetalles()
  End Sub

  Private Sub PrestamoDetListBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PrestamoDetListBindingSource.AddingNew
    Dim _prestdet As New PrestamoDet(PrestamoListBindingSource.Current)
    e.NewObject = _prestdet
  End Sub

  Private Sub dgdetalles_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdetalles.DoubleClick, btnabrirdet.Click
    If PrestamoListBindingSource.Current Is Nothing OrElse CType(PrestamoListBindingSource.Current, Prestamo).Pardet_TipoPrestamo = 5 Then
      Exit Sub
    End If
    Abrir_MantenimientoDetalles()
  End Sub

  Private Sub dgdetalles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgdetalles.KeyDown
    If PrestamoListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        Abrir_MantenimientoDetalles()
      Case Keys.Insert
        e.Handled = True
        Me.PrestamoDetListBindingSource.AddNew()
        Me.PrestamoDetListBindingSource.MoveLast()
        Abrir_MantenimientoDetalles()
    End Select
  End Sub

  Sub Abrir_MantenimientoDetalles()
    If Me.PrestamoDetListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoPrestamoDetDets(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoClientes)
    Dim _prestamo As Prestamo = CType(PrestamoListBindingSource.Current, Prestamo)
    f.Prestamo = _prestamo
    f.PrestamoDets = PrestamoDetListBindingSource
    f.ShowDialog()
    If SolicitudPrestamoListBindingSource.Count <= 1 Then
      buscar_detprestamos()
    End If
    f.Dispose()
  End Sub

  Private Sub btnelidet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelidet.Click
    If PrestamoListBindingSource.Current Is Nothing OrElse CType(PrestamoListBindingSource.Current, Prestamo).Pardet_TipoPrestamo = 5 Then
      Exit Sub
    End If
    Dim _prestamodet As PrestamoDet = CType(PrestamoDetListBindingSource.Current, PrestamoDet)
    Try
      If Not _prestamodet.Eliminar() Then
        Throw New Exception("No se puede eliminar el detalle del préstamo")
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Eliminó detalle del préstamo # {0} de {1} valor {2}", _prestamodet.Presta_Secuencia, _prestamodet.Prestamo.Contrato.Empleado.NombreCompleto, _prestamodet.DetPre_Valor))
      Me.PrestamoDetListBindingSource.RemoveCurrent()
    Catch ex As Exception
      MsgBox(String.Format("{0}. {1}", ex.Message, Sistema.OperadorDatos.MsgError), MsgBoxStyle.Information, "Información")
    End Try
  End Sub
#End Region

#Region "Aprobar"
  Private Sub btnaprobarsolic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaprobarsolic.Click
    Try
      Dim _solicitud As Prestamo
      _solicitud = CType(SolicitudPrestamoListBindingSource.DataSource(Me.dgsolicitudes.CurrentRow.Index), Prestamo)

      _solicitud.Presta_esAprobado = True
      _solicitud.Presta_FechaAprobacion = Now.Date
      If _solicitud.Presta_ValorAprobado = 0 Then
        _solicitud.Presta_ValorAprobado = _solicitud.Presta_ValorSolicitado
      End If
      _solicitud.Guardar()

      buscar_prestamos()

      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Adicion, String.Format("Aprobó solicitud {0} de {1}", _solicitud.Presta_Secuencia, _solicitud.Contrato.Empleado.NombreCompleto))

    Catch ex As Exception
      If Not dgsolicitudes.CurrentRow Is Nothing Then
        Me.dgsolicitudes.CurrentRow.ErrorText = "No se pudo aprobar el préstamo"
      End If
    End Try
  End Sub
#End Region

  Private Sub btnprintsolic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintsolic.Click
    'imprimir_solicitud()
  End Sub

  'Sub imprimir_solicitud()
  '  Try
  '    Dim _solicitud As Prestamo
  '    _solicitud = CType(SolicitudPrestamoListBindingSource.DataSource(Me.dgsolicitudes.CurrentRow.Index), Prestamo)

  '    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió solicitud {0} de {1}", _solicitud.Presta_Secuencia, _solicitud.Empleado.NombreCompleto))

  '    Dim ds As New DSSolicPrestamo
  '    Dim tabla As DataTable
  '    tabla = ds.Tables("v_solicprestamo")
  '    Dim fila As DataRow
  '    fila = tabla.NewRow()
  '    fila("numsolic") = _solicitud.Presta_Secuencia
  '    fila("fechasolic") = _solicitud.Presta_FechaSolicitud
  '    fila("Entida_Codigo") = _solicitud.Entida_Codigo
  '    fila("cedula") = _solicitud.Empleado.Cedula
  '    fila("per_nombre") = _solicitud.Empleado.NombreCompleto
  '    If Not _solicitud.Empleado.ContratoActivo Is Nothing Then
  '      fila("pardet_descripcion") = _solicitud.Empleado.ContratoActivo.Labor.Seccion.pardet_descripcion
  '    End If
  '    fila("valorsolic") = _solicitud.Presta_ValorSolicitado
  '    fila("valorcuota") = _solicitud.Presta_ValorCuota
  '    fila("motivo") = _solicitud.Presta_Motivo

  '    Dim prestamospend As New PrestamoList
  '    prestamospend = PrestamoList.ObtenerLista(Me.mOp, _solicitud.Empleado, PrestamoList.enumReportePrestamo.NoCancelados)
  '    If Not prestamospend Is Nothing Then
  '      For Each _prestamopend As Prestamo In prestamospend
  '        fila("prs_codigo") = _prestamopend.Presta_Secuencia
  '        fila("valorprestado") = _prestamopend.Presta_ValorAprobado
  '        fila("saldoprestamo") = _prestamopend.Presta_ValorAprobado - _prestamopend.TotalPagado
  '        fila("motivoprs") = _prestamopend.Presta_Motivo

  '        Dim pagos As New PrestamoDetList
  '        pagos = PrestamoDetList.ObtenerLista(_prestamopend)
  '        If Not pagos Is Nothing Then
  '          For Each _pago As PrestamoDet In pagos
  '            fila("fechapago") = _pago.DetPre_Fecha
  '          Next
  '        End If
  '      Next
  '    End If
  '    tabla.Rows.Add(fila)
  '    tabla.AcceptChanges()

  '    PrevioSolicitud(ds)

  '  Catch ex As Exception
  '    MsgBox("No existen datos para mostrar", MsgBoxStyle.Information, "Información")
  '  End Try
  'End Sub

  'Private Sub PrevioSolicitud(ByVal ds As DSSolicPrestamo)
  '  Try
  '    Dim info As New crpSolicPrestamo
  '    info.SetDataSource(ds)
  '    info.DataDefinition.FormulaFields("Titulo").Text = "'Solicitud de préstamo'"

  '    info.PrintOptions.PaperSize = PaperSize.PaperA4
  '    Me.crvsolic.Zoom(1)
  '    Me.crvsolic.ReportSource = info
  '    Me.crvsolic.DisplayToolbar = True
  '    Me.crvsolic.ShowRefreshButton = False
  '    Me.crvsolic.DisplayGroupTree = False
  '    'Me.TabControl1.SelectedIndex = 1
  '  Catch ex As Exception
  '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
  '  End Try
  'End Sub

  Private Sub TbSolicitud_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '  If TbSolicitud.SelectedTab Is tbimprimir Then
    '    imprimir_solicitud()
    '  End If
  End Sub

  Private Sub btninfdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfdet.Click
    reporte(1)
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió informe detallado cortado al {0} de la Empresa {1}", Me.dtfeccorte.Value.ToShortDateString, Me.comboEmpresa1.Empresa.NombreCompleto))
  End Sub

  Private Sub btninfres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfres.Click
    reporte(2)
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió informe resumido cortado al {0} de la Empresa {1}", Me.dtfeccorte.Value.ToShortDateString, Me.comboEmpresa1.Empresa.NombreCompleto))
  End Sub

  Sub reporte(ByVal tipo As Integer)
    'Dim pvCollection As New CrystalDecisions.Shared.ParameterValues
    'Dim pdvcortadoal As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Dim pdvEmpresa As New CrystalDecisions.Shared.ParameterDiscreteValue

    Dim rpt As New ReportDocument
    If tipo = 1 Then
      rpt = New crpprestamodet
    Else
      rpt = New crpprestamores
    End If
    Try
      rpt.DataDefinition.FormulaFields("titulo").Text = "'" & "Reporte de préstamos" & "'"
      rpt.DataDefinition.FormulaFields("cortadoal").Text = "'" & Me.dtfeccorte.Value.ToShortDateString & "'"
      rpt.DataDefinition.FormulaFields("Empresa").Text = "'" & Me.comboEmpresa1.Empresa.NombreCompleto & "'"

      Dim ds As DataSet
      If tipo = 1 Then
        ds = New DSdetallesprestamos
        ds = RetornarPrestamosDetalleDS(Sistema.OperadorDatos, dtfeccorte.Value, Me.comboEmpresa1.Empresa)
      Else
        ds = New dsresumenprestamo
        ds = RetornarPrestamosResumenDS(Sistema.OperadorDatos, dtfeccorte.Value, Me.comboEmpresa1.Empresa)
      End If
      If ds Is Nothing Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        rpt.SetDataSource(ds)
        rpt.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crvlistadoprestamos.ReportSource = rpt
        Me.crvlistadoprestamos.Zoom(1)
        'Me.crvlistadoprestamos.DisplayGroupTree = False
        Me.crvlistadoprestamos.ShowRefreshButton = False
        Me.crvlistadoprestamos.DisplayToolbar = True
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Public Function RetornarPrestamosResumenDS(ByVal _OperadorDatos As OperadorDatos, ByVal _fecha As DateTime, ByVal _Empresa As Empresa) As dsresumenprestamo
    Dim bReturn As Boolean = True
    Dim dsResult As New dsresumenprestamo
    With _OperadorDatos
      .AgregarParametro("@accion", "rrp")
      .AgregarParametro("@fechacorte", _fecha)
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .Procedimiento = "proc_prestamo"

      .Comando.CommandText = _OperadorDatos.Procedimiento

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

  Public Function RetornarPrestamosDetalleDS(ByVal _OperadorDatos As OperadorDatos, ByVal _fecha As DateTime, ByVal _Empresa As Empresa) As DSdetallesprestamos
    Dim bReturn As Boolean = True
    Dim dsResult As New DSdetallesprestamos
    With _OperadorDatos
      .AgregarParametro("@accion", "rdp")
      .AgregarParametro("@fechacorte", _fecha)
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .Procedimiento = "proc_prestamo"

      .Comando.CommandText = _OperadorDatos.Procedimiento

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

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmPrestamos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub
#End Region

  Private Sub CtlBuscaEmpleado1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleado1.Load

  End Sub

  Private Sub cbotipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotipo.SelectedIndexChanged
    buscar_solicitudes()
    buscar_prestamos()
  End Sub

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Me.ToolStrip1
    End Get
  End Property
End Class