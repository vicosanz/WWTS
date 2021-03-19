Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.General.Controles
Imports WWTS.Roles.Reglas
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop
Imports Infoware.Controles.Base
Imports WWTS.General.Modulo

Public Class FrmPagos
  Implements IOpcion

  Private mPagoVarios As LotePagoVarioDetalleList = Nothing
  Private mLotePago As LotePago = Nothing
  Public Property LotePago() As LotePago
    Get
      Return mLotePago
    End Get
    Set(value As LotePago)
      mLotePago = Value
    End Set
  End Property

  Private Sub CtlPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ajustartamano()
  End Sub

  Private Sub chkconcepto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkconcepto.CheckedChanged
    pnlconcepto.Visible = Me.chkconcepto.Checked
    Dim enumMotivoPago As Enumerados.enumMotivoPago
    If Not cboconcepto.SelectedValue Is Nothing Then
      enumMotivoPago = CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago)
      pnlseltipocontrato.Visible = (enumMotivoPago = Enumerados.enumMotivoPago.Nomina And chkconcepto.Checked)
    Else
      pnlseltipocontrato.Visible = False
    End If
    ajustartamano()
  End Sub

  Sub ajustartamano()
    If pnlconcepto.Visible Then
      pnlgroupconcepto.Height = pnlconcepto.Top + pnlconcepto.Height
    Else
      pnlgroupconcepto.Height = chkconcepto.Top + chkconcepto.Height
    End If

    If pnltipocontrato.Visible Then
      pnlseltipocontrato.Height = pnltipocontrato.Top + pnltipocontrato.Height
    Else
      pnlseltipocontrato.Height = chktipocontrato.Top + chktipocontrato.Height
    End If
    Me.pnlajustable.Height = Me.cboCtaBancaria.Top + Me.cboCtaBancaria.Height
  End Sub

  Private Sub btnmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrar.Click
    If Me.cboCtaBancaria.ParametroDet Is Nothing Then
      MsgBox("Debe seleccionar una cuenta bancaria", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    Try
      Dim info As ReportClass
      info = New crpListadocheques

      Dim _listacheque As String = String.Empty
      If Me.chkconcepto.Checked Then
        _listacheque = cboconcepto.ParametroDet.Pardet_Descripcion
      End If

      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de cheques " & _listacheque & "'"

      info.DataDefinition.FormulaFields("fecdesde").Text = "'" & Me.dtfecdesde.Value.ToShortDateString & "'"
      info.DataDefinition.FormulaFields("fechasta").Text = "'" & Me.dtfechasta.Value.ToShortDateString & "'"

      info.DataDefinition.FormulaFields("filtro1").Text = "''"
      If chkconcepto.Checked Then
        info.DataDefinition.FormulaFields("filtro2").Text = "'" & cboconcepto.ParametroDet.Pardet_Descripcion & "'"
        If CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago) = Enumerados.enumMotivoPago.Nomina Then
          If chktipocontrato.Checked Then
            info.DataDefinition.FormulaFields("filtro3").Text = "'" & CtlTipoContrato1.TipoContrato.TipCon_Descripcion.Trim & "'"
          End If
          info.DataDefinition.FormulaFields("filtro4").Text = "'" & CtlPatrono1.Patrono.NombreCompleto.Trim & "'"
        End If
      End If
      info.DataDefinition.FormulaFields("filtro5").Text = "'" & cboBanco.ParametroDet.Pardet_Descripcion & " " & cboCtaBancaria.ParametroDet.Pardet_Descripcion.Trim & "'"

      Dim ds As New DSListadocheques
      ds = RetornarListadoChequesDS(Sistema.OperadorDatos, _
                                    Not cbotipocheque.SelectedIndex = 1, _
                                    Not cbotipocheque.SelectedIndex = 2, _
                                    IIf(chkconcepto.Checked, Me.cboconcepto.ParametroDet, Nothing), _
                                    IIf(chkconcepto.Checked And chktipocontrato.Checked And CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago) = Enumerados.enumMotivoPago.Nomina, CtlTipoContrato1.TipoContrato, Nothing), _
                                    IIf(chkconcepto.Checked And CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago) = Enumerados.enumMotivoPago.Nomina, CtlPatrono1.Patrono, Nothing), Me.dtfecdesde.Value, dtfechasta.Value, Me.cboCtaBancaria.ParametroDet)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crvlistadocheques.Zoom(1)
        Me.crvlistadocheques.ReportSource = info
        Me.crvlistadocheques.DisplayToolbar = True
        Me.crvlistadocheques.ShowRefreshButton = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarListadoChequesDS(ByVal _OperadorDatos As OperadorDatos, ByVal _veranuladas As Boolean, ByVal _vernoanuladas As Boolean, ByVal _motivo As WWTSParametroDet, _
                                           ByVal _tipocontrato As TipoContrato, ByVal _patrono As Patrono, ByVal _fecdesde As Date, ByVal _fechasta As Date, ByVal _cuentabancaria As WWTSParametroDet) As DSListadocheques
    Dim bReturn As Boolean = True
    Dim dsResult As New DSListadocheques
    With _OperadorDatos
      .AgregarParametro("@veranuladas", _veranuladas)
      .AgregarParametro("@vernoanuladas", _vernoanuladas)
      If _motivo IsNot Nothing Then
        .AgregarParametro("@Parame_TipoPagoNomina", _motivo.Parame_Codigo)
        .AgregarParametro("@Pardet_TipoPagoNomina", _motivo.Pardet_Secuencia)
      End If
      If _tipocontrato IsNot Nothing Then
        .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      End If
      If _patrono IsNot Nothing Then
        .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      End If

      .AgregarParametro("@fecdesde", _fecdesde.Date)
      .AgregarParametro("@fechasta", _fechasta.Date)
      .AgregarParametro("@Parame_CuentaBancaria", _cuentabancaria.Parame_Codigo)
      .AgregarParametro("@Pardet_CuentaBancaria", _cuentabancaria.Pardet_Secuencia)
      .Procedimiento = "proc_ChequePago"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)

      Try
        dsResult = New DSListadocheques
        DataAdapter.Fill(dsResult, "v_listadocheques")
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

  Private Sub cboconcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboconcepto.SelectedIndexChanged
    Dim enumMotivoPago As Enumerados.enumMotivoPago
    If Not cboconcepto.SelectedValue Is Nothing Then
      enumMotivoPago = CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago)
      pnlseltipocontrato.Visible = (enumMotivoPago = Enumerados.enumMotivoPago.Nomina And chkconcepto.Checked)
      Me.CtlTipoContrato1.Patrono = Me.CtlPatrono1.Patrono
      Me.CtlTipoContrato1.llenar_datos()
    Else
      pnlseltipocontrato.Visible = False
    End If
    ajustartamano()
  End Sub

  Private Sub chktipocontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktipocontrato.CheckedChanged
    Me.pnltipocontrato.Visible = chktipocontrato.Checked
    ajustartamano()
  End Sub

  Private Sub btnnuevolote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevolote.Click
    Try
      Dim _lpv As New LotePago(Me.CtlPatrono2.Patrono, Now.Date)
      _lpv.LotPag_Cerrado = False
      If Not _lpv.Guardar() Then
        Throw New Exception(_lpv.OperadorDatos.MsgError)
      End If

      Me.CtlLotePago2.llenar_datos()
      Me.CtlLotePago2.LotePago = _lpv
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub CtlLotePago2_CambioLotePago() Handles CtlLotePago2.CambioLotePago
    llenar_LotePago()
  End Sub

  Sub llenar_LotePago()
    If CtlLotePago2.LotePago Is Nothing Then
      lvpagosvarios.Visible = False
      pnlmantloteaction.Visible = False
      lvpagosvarios.Items.Clear()
      Exit Sub
    End If

    lvpagosvarios.Visible = True
    pnlmantloteaction.Visible = True

    Dim _pgvs As New LotePagoVarioDetalleList
    _pgvs = LotePagoVarioDetalleList.ObtenerLista(Me.CtlLotePago2.LotePago)

    Me.btnnuevopago.Visible = True
    Me.btnlotepago.Visible = True
    Me.btnmodifpago.Visible = False
    Me.btnelimpago.Visible = False
    lvpagosvarios.Items.Clear()
    If Not _pgvs Is Nothing Then
      For Each _pgv As LotePagoVarioDetalle In _pgvs

        Dim _item As New ListViewItem
        _item.SubItems(0).Text = _pgv.Beneficiario
        _item.SubItems.Add(_pgv.LoPaDe_ValorPago.ToString("c"))
        _item.SubItems.Add(_pgv.LoPaDe_Observacion)
        _item.SubItems.Add(_pgv.PardetTipoPagoNomina.Pardet_Descripcion)
        _item.Tag = _pgv
        lvpagosvarios.Items.Add(_item)
        Me.btnmodifpago.Visible = True
        Me.btnelimpago.Visible = True
      Next
    End If
  End Sub

  Private Sub btnnuevopago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevopago.Click
    Dim _pgv As New LotePagoVarioDetalle(CtlLotePago2.LotePago)
    _pgv.PardetTipoPagoNomina = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.MotivoPago, Enumerados.enumMotivoPago.Prestamo)
    _pgv.LoPaDe_FechaPago = Now.Date
    Dim f As New FrmPagoVario
    f.PagoVario = _pgv
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.ShowDialog()
    llenar_LotePago()
  End Sub

  Private Sub btnmodifpago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodifpago.Click
    modificarpago()
  End Sub

  Private Sub btnelimpago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelimpago.Click
    If lvpagosvarios.SelectedItems.Count = 0 Then
      Exit Sub
    End If
    Dim _pgv As LotePagoVarioDetalle
    _pgv = CType(lvpagosvarios.SelectedItems(0).Tag, LotePagoVarioDetalle)
    Dim f As New FrmPagoVario
    f.PagoVario = _pgv
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.ShowDialog()
    llenar_LotePago()
  End Sub

  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    If Me.cboCtaBancaria.ParametroDet Is Nothing Then
      MsgBox("Debe seleccionar una cuenta bancaria", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    ExportarCheques()
  End Sub

  Private Sub ExportarCheques()
    Try
      Dim ds As DSListadocheques
      ds = RetornarListadoChequesDS(Sistema.OperadorDatos, _
                                    Not cbotipocheque.SelectedIndex = 1, _
                                    Not cbotipocheque.SelectedIndex = 2, _
                                    IIf(chkconcepto.Checked, Me.cboconcepto.ParametroDet, Nothing), _
                                    IIf(chkconcepto.Checked And chktipocontrato.Checked And CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago) = Enumerados.enumMotivoPago.Nomina, CtlTipoContrato1.TipoContrato, Nothing), _
                                    IIf(chkconcepto.Checked And CType(cboconcepto.SelectedValue, Enumerados.enumMotivoPago) = Enumerados.enumMotivoPago.Nomina, CtlPatrono1.Patrono, Nothing), Me.dtfecdesde.Value, dtfechasta.Value, Me.cboCtaBancaria.ParametroDet)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
         CType(excelBook.Worksheets(1), Excel.Worksheet)

        excelApp.Visible = False
        With excelWorksheet
          .Range("A1").Value = "Tipo"
          .Columns("A").ColumnWidth = 1
          .Range("B1").Value = "Codigo"
          .Columns("B").ColumnWidth = 7
          .Columns("B:B").numberformat = "@"
          .Columns("C:D").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern
          .Range("C1").Value = "Fechap"
          .Columns("C").ColumnWidth = 8
          .Range("D1").Value = "Fechas1"
          .Columns("D").ColumnWidth = 8
          .Range("E1").Value = "Document"
          .Columns("E").ColumnWidth = 6
          .Range("F1").Value = "Pagado"
          .Columns("F").ColumnWidth = 40
          .Range("G1").Value = "Credito"
          .Columns("G").ColumnWidth = 15
          .Columns("G:G").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
          .Range("H1").Value = "Banco"
          .Columns("H").ColumnWidth = 5
          .Range("I1").Value = "Cuenta"
          .Columns("I").ColumnWidth = 15
          .Columns("I:I").numberformat = "@"
          .Range("J1").Value = "Codigoid"
          .Columns("J").ColumnWidth = 3
          .Range("K1").Value = "Doc"
          .Columns("K").ColumnWidth = 6
          .Columns("L:L").numberformat = CurrentCulture.DateTimeFormat.ShortDatePattern
          .Range("L1").Value = "Fecha"
          .Columns("L").ColumnWidth = 8
          .Range("M1").Value = "Mes"
          .Columns("M").ColumnWidth = 3
          .Range("N1").Value = "Anio"
          .Columns("N").ColumnWidth = 5
          .Range("O1").Value = "Cs"
          .Columns("O").ColumnWidth = 1
          Dim t As Integer = 0
          For Each _dr As DataRow In ds.Tables(0).Rows
            Dim _tipocontrato As TipoContrato = Nothing
            Dim _codtipocont As Integer
            '_codtipocont = _dr("TipCon_Codigo")
            Dim obj As Object
            obj = _dr("TipCon_Codigo")
            If TypeOf obj Is DBNull Then
              _codtipocont = 0
            Else
              _codtipocont = CInt(obj)
              _tipocontrato = New TipoContrato(Sistema.OperadorDatos, Me.CtlPatrono1.Patrono.Patron_Codigo, _codtipocont)
            End If

            With .Range("A" & (t + 2).ToString)
              If _tipocontrato Is Nothing Then
                .Value = 7
              Else
                If _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Fijo And _tipocontrato.Pardet_PeriodoPagoEnum = Enumerados.enumPeriodoPago.Quincenal Then
                  .Value = 0
                ElseIf _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Fijo And Not _tipocontrato.Pardet_PeriodoPagoEnum = Enumerados.enumPeriodoPago.Quincenal Then
                  .Value = 1
                ElseIf _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
                  .Value = 2
                ElseIf _tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Temporada Then
                  .Value = 3
                End If
              End If
            End With
            Dim anulado As Boolean = False
            anulado = CBool(_dr("chv_anulado"))
            .Range("B" & (t + 2).ToString).Value = _dr("Entida_Codigo")
            .Range("C" & (t + 2).ToString).Value = _dr("pgv_fecha")
            .Range("D" & (t + 2).ToString).Value = _dr("prd_fecdesde")
            .Range("E" & (t + 2).ToString).Value = _dr("chq_numero")
            .Range("F" & (t + 2).ToString).Value = IIf(anulado, "A N U L A D O", _dr("beneficiario"))
            .Range("G" & (t + 2).ToString).Value = IIf(anulado, 0, _dr("LoPaDe_ValorPago"))
            .Range("H" & (t + 2).ToString).Value = _dr("ban_codigo")
            .Range("I" & (t + 2).ToString).Value = _dr("CtaBan_Numero")
            .Range("J" & (t + 2).ToString).Value = "NOA"
            .Range("K" & (t + 2).ToString).Value = _dr("chq_numero")
            .Range("L" & (t + 2).ToString).Value = _dr("pgv_fecha")
            .Range("M" & (t + 2).ToString).Value = CDate(_dr("pgv_fecha")).Month
            .Range("N" & (t + 2).ToString).Value = CDate(_dr("pgv_fecha")).Year
            .Range("O" & (t + 2).ToString).Value = "T"
            t += 1
          Next
        End With

        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CH" & Me.CtlPatrono1.Patrono.Patron_NumeroPatronal.Trim & Me.dtfecdesde.Value.Month.ToString.Trim & ".dbf"
        Try
          Kill(rutfte)
        Catch ex As Exception
        End Try

        excelBook.SaveAs(Filename:=rutfte, FileFormat:=Excel.XlFileFormat.xlDBF4, CreateBackup:=False)
        'excelBook.SaveAs(filename:=rutfte)
        'excelBook.Close()
        excelApp.Visible = True
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnlotepago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlotepago.Click
    Dim f As New FrmLotePago
    f.LotePago = Me.CtlLotePago2.LotePago
    If f.ShowDialog = Windows.Forms.DialogResult.OK Then
      llenar_LotePago()
    End If
  End Sub

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

  Private Sub FrmPagos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlTipoContrato1.Op = Sistema.OperadorDatos

    Me.CtlPatrono1.Op = Sistema.OperadorDatos
    Me.CtlPatrono2.Op = Sistema.OperadorDatos
    Me.CtlPatronoProv.Op = Sistema.OperadorDatos

    Me.cboconcepto.Parametro = Enumerados.EnumParametros.MotivoPago
    Me.cboconcepto.OperadorDatos = Sistema.OperadorDatos
    Me.cboconcepto.Llenar_Datos()

    Me.cboBanco.Parametro = Enumerados.EnumParametros.Banco
    Me.cboBanco.OperadorDatos = Sistema.OperadorDatos
    Me.cboBanco.Llenar_Datos()

    Me.cboCtaBancaria.Parametro = Enumerados.EnumParametros.CuentaBancaria
    Me.cboCtaBancaria.OperadorDatos = Sistema.OperadorDatos

    Me.CtlPatrono1.llenar_datos()
    Me.CtlPatrono2.llenar_datos()
    Me.CtlPatronoProv.llenar_datos()

    Me.CtlLotePago2.Patrono = Me.CtlPatrono2.Patrono
    Me.dgprovisiones.ReadOnly = True
    ajustartamano()
  End Sub
#End Region

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
      Return Nothing
    End Get
  End Property

  Private Sub mnulistapagos_Click(sender As System.Object, e As System.EventArgs) Handles mnulistapagos.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Pagos)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Listado_pagos")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlPatrono2.Patrono.Patron_Codigo}
    f.ShowDialog()
  End Sub

  Private Sub CtlPatrono2_CambioPatrono() Handles CtlPatrono2.CambioPatrono
    Me.CtlLotePago2.Patrono = Me.CtlPatrono2.Patrono
  End Sub

  Private Sub lvpagosvarios_DoubleClick(sender As Object, e As System.EventArgs) Handles lvpagosvarios.DoubleClick
    modificarpago()
  End Sub

  Private Sub modificarpago()
    If lvpagosvarios.SelectedItems.Count = 0 Then
      Exit Sub
    End If
    Dim _pgv As LotePagoVarioDetalle
    _pgv = CType(lvpagosvarios.SelectedItems(0).Tag, LotePagoVarioDetalle)
    Dim f As New FrmPagoVario
    f.PagoVario = _pgv
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.ShowDialog()
    llenar_LotePago()
  End Sub

  Private Sub mnuPagoCheque_Click(sender As System.Object, e As System.EventArgs) Handles mnuPagoCheque.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Pagos)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Pago_Vario_Cheque")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlPatrono2.Patrono.Patron_Codigo}
    f.ShowDialog()
  End Sub

  Private WithEvents mProvisiones As ProvisionList = Nothing

  Private Sub btnmostrarprov_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrarprov.Click
    mProvisiones = ProvisionList.ObtenerLista(Me.CtlPatronoProv.Patrono, Me.dtfecdesdeprov.Value, Me.dtfechastaprov.Value)
    Me.dgprovisiones.ReadOnly = False
    ProvisionCollectionBindingSource.DataSource = mProvisiones
    If mProvisiones.Count = 0 Then
      mProvisiones.AddNew()
    End If
    Me.dgprovisiones.AutoDiscover()
    'mProvisiones.AddNew()
  End Sub

  Private Sub mProvisiones_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mProvisiones.AddingNew
    Dim _provision As New Provision(Me.CtlPatronoProv.Patrono, True)
    e.NewObject = _provision
    Me.dgprovisiones.AutoDiscover()
  End Sub

  Private Sub dgprovisiones_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgprovisiones.RowValidating
    Try
      CType(ProvisionCollectionBindingSource.DataSource(e.RowIndex), Provision).Guardar()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub dgprovisiones_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgprovisiones.UserDeletingRow
    If Not e.Row.IsNewRow Then
      e.Cancel = Not CType(ProvisionCollectionBindingSource.DataSource(e.Row.Index), Provision).Eliminar()
    End If
  End Sub

  Private Sub tabprovisiones_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tabprovisiones.SelectedIndexChanged
    If tabprovisiones.SelectedTab Is tbreporteprov Then
      mostrar_reporteprovisiones()
    End If
  End Sub

  Sub mostrar_reporteprovisiones()
    Try
      Dim info As New crpProvisiones
      Dim ds As New DSprovisiones

      info.DataDefinition.FormulaFields("patrono").Text = "'" & Me.CtlPatrono2.Patrono.NombreCompleto & "'"
      info.DataDefinition.FormulaFields("desde").Text = "'" & Me.dtfecdesdeprov.Value.ToShortDateString & "'"
      info.DataDefinition.FormulaFields("hasta").Text = "'" & Me.dtfechastaprov.Value.ToShortDateString & "'"

      ds = RetornarProvisionesDS(CtlPatronoProv.Patrono, Me.dtfecdesdeprov.Value, dtfechastaprov.Value)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crv_provision.Zoom(1)

        Me.crv_provision.ReportSource = info
        Me.crv_provision.DisplayToolbar = True
        Me.crv_provision.ShowRefreshButton = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  Public Function RetornarProvisionesDS(ByVal _patrono As Patrono, ByVal _fecdesde As Date, ByVal _fechasta As Date) As DSprovisiones
    Dim bReturn As Boolean = True
    Dim dsResult As New DSprovisiones
    With _patrono.OperadorDatos
      .AgregarParametro("@accion", "rp")
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      .AgregarParametro("@fecdesde", _fecdesde.Date)
      .AgregarParametro("@fechasta", _fechasta.Date)
      .Procedimiento = "proc_provision"

      .Comando.CommandText = "proc_provision"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)

      Try
        dsResult = New DSprovisiones
        DataAdapter.Fill(dsResult, "v_provisiones")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      'For Each _dr As DSprovisiones.v_ProvisionesRow In dsResult.v_Provisiones.Rows
      '  If Not (_dr.pgv_motivo = "PROV" Or _dr.pgv_motivo = "SUEL ") Then
      '    '_dr.tcn_descripcion = Enumerados.TipoChequeList.RetornarDescripcion(_dr.pgv_motivo)
      '  End If
      'Next
      'dsResult.AcceptChanges()
      Return dsResult
    End If
    Return Nothing
  End Function

  Private Sub cboBanco_CambioItem(sender As Object, e As System.EventArgs) Handles cboBanco.CambioItem
    Me.cboCtaBancaria.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, Me.cboBanco.ParametroDet)
  End Sub

  Private Sub CtlPatrono1_CambioPatrono() Handles CtlPatrono1.CambioPatrono
    Me.CtlTipoContrato1.Patrono = Me.CtlPatrono1.Patrono
    Me.CtlTipoContrato1.llenar_datos()
  End Sub
End Class