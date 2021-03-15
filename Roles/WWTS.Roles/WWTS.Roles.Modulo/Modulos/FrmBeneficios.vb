Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Microsoft.Office.Interop

Public Class FrmBeneficios
  Implements IOpcion

#Region "Acta de finiquito"
  Private Sub btnfiniquito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiniquito.Click
    chkfiniq.Checked = False
    Mtcargarfiniq()
  End Sub

  Private Sub Mtcargarfiniq()
    lvfiniq.Items.Clear()
    Dim _contratos As ContratoList
    _contratos = Me.CtlBuscaEmpleados1.RetornarContratoListChecked
    For Each _contrato As Contrato In _contratos
      Dim item As New ListViewItem
      item.Text = (_contrato.Empleado.Entida_Codigo)
      item.SubItems.Add(_contrato.Empleado.Cedula)
      item.SubItems.Add(_contrato.Empleado.NombreCompleto)
      item.Tag = LiquidacionList.ObtenerLista(Sistema.OperadorDatos, _contrato, cbotipoliq.SelectedValue)
      lvfiniq.Items.Add(item)
    Next
  End Sub

  Private Sub lvfiniq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvfiniq.SelectedIndexChanged
    Me.dgdetliq.DataSource = Nothing
    If lvfiniq.SelectedItems.Count > 0 AndAlso Not lvfiniq.SelectedItems(0).Tag Is Nothing Then
      Me.dgdetliq.DataSource = CType(lvfiniq.SelectedItems(0).Tag, LiquidacionList)
    End If
  End Sub

  Private Sub btnlistafiniq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistafiniq.Click
    If CtlCuentaBancaria1.CuentaBancaria Is Nothing Then
      MsgBox("Debe seleccionar una cuenta bancaria", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    For Each _item As ListViewItem In lvfiniq.Items
      If _item.Checked Then
        Dim _liqs As LiquidacionList = _item.Tag
        If _liqs.Count > 0 Then
          ImprimirFiniquito(_liqs)
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1}", "Imprimió finiquito de ", _liqs(0).Contrato.Empleado.NombreCompleto))
        End If
      End If
    Next

  End Sub
  Private Sub ImprimirFiniquito(ByVal _liqs As LiquidacionList)
    If _liqs Is Nothing OrElse _liqs.Count = 0 Then
      Exit Sub
    End If
    Dim _contrato As Contrato = _liqs(0).Contrato
    Dim valortotal As Decimal = 0
    For Each _liq As Liquidacion In _liqs
      valortotal += _liq.Liquid_ValorPagado
    Next

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      excelApp.Visible = False
      With excelWorksheet
        .Range("A1").Value = "Canton"
        .Range("B1").Value = "FechaDesde"
        .Range("C1").Value = "FechaHasta"
        .Range("D1").Value = "Patrono"
        .Range("E1").Value = "Representante"
        .Range("F1").Value = "CedRepre"
        .Columns("F:F").NumberFormat = "@"
        .Range("G1").Value = "Empleado"
        .Range("H1").Value = "CedEmpleado"
        .Columns("H:H").NumberFormat = "@"
        .Range("I1").Value = "Diastrab"
        .Range("J1").Value = "Total"
        .Columns("J:J").NumberFormat = "@"
        .Range("K1").Value = "Totalletras"
        .Range("L1").Value = "Banco"
        .Range("M1").Value = "Concepto1"
        .Range("N1").Value = "Valor1"
        .Columns("N:N").NumberFormat = "@"
        .Range("O1").Value = "Concepto2"
        .Range("P1").Value = "Valor2"
        .Columns("P:P").NumberFormat = "@"
        .Range("Q1").Value = "Concepto3"
        .Range("R1").Value = "Valor3"
        .Columns("R:R").NumberFormat = "@"
        .Range("S1").Value = "Concepto4"
        .Range("T1").Value = "Valor4"
        .Columns("T:T").NumberFormat = "@"
        .Range("U1").Value = "Concepto5"
        .Range("V1").Value = "Valor5"
        .Columns("V:V").NumberFormat = "@"
        .Range("W1").Value = "Concepto6"
        .Range("X1").Value = "Valor6"
        .Columns("X:X").NumberFormat = "@"
        .Range("Y1").Value = "Concepto7"
        .Range("Z1").Value = "Valor7"
        .Range("AA1").Value = "FechaInicio"
        .Range("AB1").Value = "Provincia"
        .Range("AC1").Value = "Hacienda"
        .Range("AD1").Value = "UltimoSldo"
        .Columns("AD:AD").NumberFormat = "@"
        .Range("AE1").Value = "UltSldoDesde"
        .Range("AF1").Value = "UltSldoHasta"

        '--------------------------------------------------
        .Range("A2").Value = _contrato.Patrono.PardetParroquia.PardetPadre.Pardet_Descripcion
        .Range("B2").Value = _contrato.Contra_Desde.ToLongDateString
        .Range("C2").Value = dtfecliq.Value.ToLongDateString
        .Range("D2").Value = _contrato.Patrono.NombreCompleto.Trim
        .Range("E2").Value = _contrato.Patrono.Entidadjuridica.RepresentanteLegalString
        .Range("F2").Value = _contrato.Patrono.Entidadjuridica.Entidad.Cedula
        .Range("G2").Value = _contrato.Empleado.NombreCompleto.Trim
        .Range("H2").Value = _contrato.Empleado.Cedula.Trim
        .Range("J2").Value = valortotal.ToString("0.00")
        .Range("K2").Value = Utilerias.NumaLetras(valortotal).ToUpper
        .Range("L2").Value = Me.CtlCuentaBancaria1.CuentaBancaria.PardetBanco.Pardet_Descripcion

        Dim lin As Integer = 0
        For Each _liq As Liquidacion In _liqs
          If _liq.Liquid_ValorPagado <> 0 Then
            lin += 1
            Select Case lin
              Case 1
                .Range("M2").Value = _liq.Liquid_descripcion
                .Range("N2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
              Case 2
                .Range("O2").Value = _liq.Liquid_descripcion
                .Range("P2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
              Case 3
                .Range("Q2").Value = _liq.Liquid_descripcion
                .Range("R2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
              Case 4
                .Range("S2").Value = _liq.Liquid_descripcion
                .Range("T2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
              Case 5
                .Range("U2").Value = _liq.Liquid_descripcion
                .Range("V2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
              Case 6
                .Range("W2").Value = _liq.Liquid_descripcion
                .Range("X2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
              Case 7
                .Range("Y2").Value = _liq.Liquid_descripcion
                .Range("Z2").Value = _liq.Liquid_ValorPagado.ToString("0.00")
            End Select
          End If
        Next
        Dim _contratos As ContratoList = ContratoList.ObtenerLista(Sistema.OperadorDatos, _contrato.Empleado)
        If Not _contratos Is Nothing Then
          .Range("AA2").Value = _contratos(_contratos.Count - 1).Contra_Desde.ToLongDateString
        End If
        Dim _ultcontrato As Contrato = Nothing
        _ultcontrato = _contrato.Empleado.BuscarUltimoContrato
        If Not _ultcontrato Is Nothing Then
          .Range("AB2").Value = _ultcontrato.Patrono.Provincia.Pardet_Descripcion
          '.Range("AC2").Value = _ultcontrato.Patrono.Hacienda.Hac_nombre.Trim
          Dim ultsldo As Decimal = IIf(_ultcontrato.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras, _contrato.Contra_ValorHora, _contrato.Contra_Sueldo)
          .Range("AD2").Value = ultsldo.ToString("0.00")
        End If
        Dim _desdeus As Date
        Dim _hastaus As Date
        Dim _sldopdtes As AsistenciaList
        _sldopdtes = AsistenciaList.RetornarSueldosLiquidacion(Sistema.OperadorDatos, _contrato)
        If Not (_sldopdtes Is Nothing OrElse _sldopdtes.Count = 0) Then
          _desdeus = _sldopdtes(0).Periodopago.PerPag_FechaDesde
          _hastaus = _sldopdtes(_sldopdtes.Count - 1).Periodopago.PerPag_FechaHasta
        End If
        .Range("AE2").Value = _desdeus.ToLongDateString
        .Range("AF2").Value = _hastaus.ToLongDateString
        .Range("I2").Value = _contrato.Empleado.Diastrabajados()
      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\fteliquidacion.xls"
      Dim rutobj As String = String.Empty

      Select Case CType(Me.cbotipoliq.SelectedValue, Enumerados.EnumTipoLiquidacion)
        Case Enumerados.EnumTipoLiquidacion.Despido
          rutobj = _contrato.Tipocontrato.TipCon_Despido
        Case Enumerados.EnumTipoLiquidacion.Renuncia
          rutobj = _contrato.Tipocontrato.TipCon_Renuncia
        Case Enumerados.EnumTipoLiquidacion.Suspension
          rutobj = _contrato.Tipocontrato.TipCon_Suspension
      End Select

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
        .Destination = 0    'nuevo documento
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

  Private Sub btnpagofiniq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagofiniq.Click
    Try
      Dim _lotepago As LotePago
      _lotepago = New LotePago(Sistema.OperadorDatos, Now.Date)
      If Not _lotepago.Guardar() Then
        Throw New Exception(_lotepago.OperadorDatos.MsgError)
      End If

      For Each _item As ListViewItem In lvfiniq.Items
        If _item.Checked AndAlso Not _item.Tag Is Nothing Then
          Dim _liqs As LiquidacionList
          _liqs = CType(_item.Tag, LiquidacionList)

          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Adicion, String.Format("{0} {1}", "Generó pago de finiquito de ", _liqs(0).Contrato.Empleado.NombreCompleto))

          Dim valortotal As Decimal
          For Each _liq As Liquidacion In _liqs
            valortotal += _liq.Liquid_ValorPagado
          Next

          Dim _pagovario As DetalleLotePago
          _pagovario = New DetalleLotePago(Sistema.OperadorDatos, _lotepago, _liqs(0).Contrato.Empleado)
          _pagovario.DeLoPa_Valor = valortotal
          _pagovario.DeLoPa_Fecha = dtfeccheque.Value
          _pagovario.Patrono = _liqs(0).Contrato.Patrono
          Select Case CType(cbotipoliq.SelectedValue, Enumerados.EnumTipoLiquidacion)
            Case Enumerados.EnumTipoLiquidacion.Despido
              _pagovario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.LiquidacionxDespido
            Case Enumerados.EnumTipoLiquidacion.Renuncia
              If _liqs(0).Contrato.Tipocontrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
                _pagovario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.LiquidacionxRenunciaHoras
              Else
                _pagovario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.LiquidacionxRenuncia
              End If
            Case Enumerados.EnumTipoLiquidacion.Suspension
              _pagovario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.LiquidacionxSuspension
          End Select

          If Not _pagovario.Guardar() Then
            Throw New Exception(_pagovario.OperadorDatos.MsgError)
          End If

          _liqs(0).Contrato.Contra_Hasta = dtfecliq.Value
          _liqs(0).Contrato.esCerrado = True
          _liqs(0).Contrato.PardetTipoLiquidacion = Me.cbotipoliq.ParametroDet
          _liqs(0).Contrato.PardetMotivoSalida = Me.cbotiposalida.ParametroDet
          If Not _liqs(0).Contrato.Guardar() Then
            Throw New Exception(_liqs(0).Contrato.OperadorDatos.MsgError)
          End If

          Dim benefcalc As BeneficioCalculado
          benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _liqs(0).Contrato, Enumerados.enumTipoBeneficio.DecimoTercero)
          If Not benefcalc.DiasAcumulados = 0 Then
            Dim beneficio As New Beneficio(Sistema.OperadorDatos, _liqs(0).Contrato, Enumerados.enumTipoBeneficio.DecimoTercero, 1, True)
            beneficio.Benefi_Valor = benefcalc.DecimoCalculado
            beneficio.Pardet_TipoBeneficioEnum = Enumerados.enumTipoBeneficio.DecimoTercero
            beneficio.Benefi_DiasCalc = benefcalc.DiasAcumulados
            beneficio.Benefi_DiasTrab = benefcalc.DiasAcumulados
            beneficio.Benefi_FechaDesde = benefcalc.FecDesde
            beneficio.Benefi_FechaHasta = benefcalc.FecHasta
            beneficio.Guardar(Me.dtfecliq.Value)
          End If

          benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _liqs(0).Contrato, Enumerados.enumTipoBeneficio.DecimoCuarto)
          If Not benefcalc.DiasAcumulados = 0 Then
            Dim beneficio As New Beneficio(Sistema.OperadorDatos, _liqs(0).Contrato, Enumerados.enumTipoBeneficio.DecimoCuarto, 1, True)
            beneficio.Benefi_Valor = benefcalc.DecimoCalculado
            beneficio.Pardet_TipoBeneficioEnum = Enumerados.enumTipoBeneficio.DecimoCuarto
            beneficio.Benefi_DiasCalc = benefcalc.DiasAcumulados
            beneficio.Benefi_DiasTrab = benefcalc.DiasAcumulados
            beneficio.Benefi_FechaDesde = benefcalc.FecDesde
            beneficio.Benefi_FechaHasta = benefcalc.FecHasta
            beneficio.Guardar(Me.dtfecliq.Value)
          End If

          benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _liqs(0).Contrato, Enumerados.enumTipoBeneficio.Vacaciones)
          If Not benefcalc.DiasAcumulados = 0 Then
            Dim beneficio As New Beneficio(Sistema.OperadorDatos, _liqs(0).Contrato, Enumerados.enumTipoBeneficio.Vacaciones, 1, True)
            beneficio.Benefi_Valor = benefcalc.DecimoCalculado
            beneficio.Pardet_TipoBeneficioEnum = Enumerados.enumTipoBeneficio.Vacaciones
            beneficio.Benefi_DiasCalc = benefcalc.DiasAcumulados
            beneficio.Benefi_DiasTrab = benefcalc.DiasAcumulados
            beneficio.Benefi_FechaDesde = benefcalc.FecDesde
            beneficio.Benefi_FechaHasta = benefcalc.FecHasta
            beneficio.Guardar(Me.dtfecliq.Value)
          End If

          Dim prestamos As PrestamoList
          prestamos = PrestamoList.ObtenerLista(_liqs(0).Contrato.OperadorDatos, _liqs(0).Contrato, PrestamoList.enumReportePrestamo.NoCancelados)
          If Not prestamos Is Nothing Then
            For Each _prest As Prestamo In prestamos
              Dim pagoprest As New PrestamoDet(_prest)
              pagoprest.DetPre_Valor = _prest.Presta_ValorAprobado - _prest.TotalPagado
              pagoprest.DetPre_Fecha = Me.dtfecliq.Value
              pagoprest.Guardar()
            Next
          End If
        End If
      Next
      MsgBox("Proceso terminado", MsgBoxStyle.Information, "Información")
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub
#End Region

  Private Sub rdobennopag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdobennopag.CheckedChanged, rdocortadoa.CheckedChanged, rdorangoper.CheckedChanged
    Me.pnlperiododesde.Visible = True
    Me.pnlperiodohasta.Visible = True
    If rdobennopag.Checked Then
      Me.pnlperiododesde.Visible = False
      Me.pnlperiodohasta.Visible = False
    ElseIf rdocortadoa.Checked Then
      Me.pnlperiododesde.Visible = False
    End If
  End Sub

#Region "Cargar benef acum"
  Private Sub btnconsbenacum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsbenacum.Click
    If tbtipobenacum.SelectedTab Is tbd3 Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
    ElseIf tbtipobenacum.SelectedTab Is tbd4 Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
    ElseIf tbtipobenacum.SelectedTab Is tbvac Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
    Else
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.Utilidades)
    End If
  End Sub

  Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
    If CDec(txtUti.Text) <= 0 Then
      MsgBox("Ingresar valor de Utilidad", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _totaldias As Long = 0
    Dim _totaldiascargas As Long = 0
    For Each _item As ListViewItem In Me.lvUti.Items
      With CType(_item.Tag, BeneficioCalculado)
        _totaldias += .DiasAcumulados
        _totaldiascargas += .DiasAcumulados * .Contrato.Empleado.Cargas
      End With
    Next

    If _totaldias = 0 Then
      MsgBox("No existen días trabajados", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim _razonuti As Decimal = CDec(Me.txtUti.Text) * 0.1 / _totaldias
    Dim _razonuticargas As Decimal = CDec(Me.txtUti.Text) * 0.05 / _totaldiascargas
    Dim _razonutibono As Decimal = CDec(Me.txtutibono.Text) / _totaldias
    Dim _razonutibonocargas As Decimal = CDec(Me.txtutibonocargas.Text) / _totaldiascargas

    For Each _item As ListViewItem In Me.lvUti.Items
      With CType(_item.Tag, BeneficioCalculado)
        .UtilidadCalculada = _razonuti * .DiasAcumulados
        .UtilidadCargas = _razonuticargas * .Contrato.Empleado.Cargas * .DiasAcumulados
        .UtilidadBono = _razonutibono * .DiasAcumulados
        .UtilidadBonoCargas = _razonutibonocargas * .Contrato.Empleado.Cargas * .DiasAcumulados

        _item.SubItems(6).Text = .UtilidadCalculada.ToString("0.00")
        _item.SubItems(7).Text = .UtilidadCargas.ToString("0.00")
        _item.SubItems(8).Text = .UtilidadBono.ToString("0.00")
        _item.SubItems(9).Text = .UtilidadBonoCargas.ToString("0.00")
      End With
    Next
  End Sub

  Private Sub Mtcargarbenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
    Dim lv As ListView = Nothing
    Select Case _tipobenef
      Case Enumerados.enumTipoBeneficio.DecimoTercero
        lv = lvd3
      Case Enumerados.enumTipoBeneficio.DecimoCuarto
        lv = lvd4
      Case Enumerados.enumTipoBeneficio.Vacaciones
        lv = lvvac
      Case Enumerados.enumTipoBeneficio.Utilidades
        lv = lvUti
    End Select
    lv.Items.Clear()
    Dim _contratos As ContratoList
    _contratos = Me.CtlBuscaEmpleados1.RetornarContratoListChecked
    For Each _contrato As Contrato In _contratos
      If _contrato IsNot Nothing Then
        Dim benefcalc As BeneficioCalculado
        If Me.rdobennopag.Checked Then
          benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef)
        ElseIf Me.rdocortadoa.Checked Then
          benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
        Else
          benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, Me.numaniodesde.Value, CType(Me.cbomesdesde.SelectedValue, Enumerados.MesesDelAnio), Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
        End If

        If Not benefcalc.DiasAcumulados = 0 Then
          Dim item As New ListViewItem
          item.Text = (_contrato.Empleado.Entida_Codigo)
          item.SubItems.Add(_contrato.Empleado.Cedula)
          item.SubItems.Add(_contrato.Empleado.NombreCompleto)
          If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
            item.SubItems.Add(benefcalc.DiasAcumulados.ToString("0.00"))
            item.SubItems.Add((IIf(benefcalc.Contrato.Empleado.AniosTrabajados >= 1, "Si", "No")))
            item.SubItems.Add(benefcalc.Contrato.Empleado.Cargas)
            item.SubItems.Add((0).ToString("0.00"))
            item.SubItems.Add((0).ToString("0.00"))
            item.SubItems.Add((0).ToString("0.00"))
            item.SubItems.Add((0).ToString("0.00"))
            item.SubItems.Add((0).ToString("0.00"))
            item.SubItems.Add("")
            item.SubItems.Add("")
          Else
            If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
              item.SubItems.Add(benefcalc.Contrato.Empleado.AniosTrabajados.ToString("0.00"))
              item.SubItems.Add(benefcalc.DiasVacaciones.ToString("0.00"))
              item.SubItems.Add(Me.dtfecvacdesde.Value.Date.ToShortDateString)
              item.SubItems.Add(Me.dtfecvacdesde.Value.Date.AddDays(benefcalc.DiasVacaciones - 1).ToShortDateString)
            Else
              item.SubItems.Add(benefcalc.SueldosAcumulados.ToString("0.00"))
              item.SubItems.Add(benefcalc.IESSAcumulados.ToString("0.00"))
            End If
            item.SubItems.Add(benefcalc.DecimoCalculado.ToString("0.00"))
          End If
          item.Tag = benefcalc
          lv.Items.Add(item)

        End If
      End If
    Next
  End Sub
#End Region

#Region "Guardar benef acum"
  Private Sub btngrabarbenacum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabarbenacum.Click
    Dim _tipobeneficio As String = String.Empty
    If tbtipobenacum.SelectedTab Is tbd3 Then
      Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
      _tipobeneficio = "Décimo tercer sueldo"
      lvd3.Items.Clear()
    ElseIf tbtipobenacum.SelectedTab Is tbd4 Then
      Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
      _tipobeneficio = "Décimo cuarto sueldo"
      lvd4.Items.Clear()
    ElseIf tbtipobenacum.SelectedTab Is tbvac Then
      Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
      _tipobeneficio = "Vacaciones"
      lvvac.Items.Clear()
    Else
      Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.Utilidades)
      _tipobeneficio = "Utilidades"
      lvUti.Items.Clear()
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{0} {1}", "Dió de baja beneficios ", _tipobeneficio))
  End Sub

  Private Sub Mtgrabarbenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
    Dim _contratos As ContratoList
    _contratos = Me.CtlBuscaEmpleados1.RetornarContratoListChecked
    For Each _contrato As Contrato In _contratos
      Dim benefcalc As BeneficioCalculado
      benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef)
      If Not benefcalc.DiasAcumulados = 0 Then
        Dim beneficio As New Beneficio(Sistema.OperadorDatos, _contrato, _tipobenef, 1, True)
        If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
          beneficio.Benefi_Valor = benefcalc.UtilidadCalculada + benefcalc.UtilidadCargas + benefcalc.UtilidadBono + benefcalc.UtilidadBonoCargas
        Else
          beneficio.Benefi_Valor = benefcalc.DecimoCalculado
        End If
        beneficio.Benefi_Valor = benefcalc.DecimoCalculado
        beneficio.Pardet_TipoBeneficioEnum = _tipobenef
        beneficio.Benefi_DiasCalc = benefcalc.DiasAcumulados
        beneficio.Benefi_DiasTrab = benefcalc.DiasAcumulados
        beneficio.Benefi_FechaDesde = benefcalc.FecDesde
        beneficio.Benefi_FechaHasta = benefcalc.FecHasta

        If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
          Dim _aviso As New Permiso(Sistema.OperadorDatos, _contrato)
          _aviso.Permis_FechaDesde = Me.dtfecvacdesde.Value.Date
          _aviso.Permis_FechaHasta = Me.dtfecvacdesde.Value.Date.AddDays(benefcalc.DiasVacaciones)
          _aviso.Pardet_TipoPermisoEnum = Enumerados.enumTipoPermiso.Vacaciones
          _aviso.Guardar()
        End If
        If Me.rdobennopag.Checked Then
          beneficio.Guardar(Date.Now)
        ElseIf Me.rdocortadoa.Checked Then
          beneficio.Guardar(Date.Now, Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
        Else
          beneficio.Guardar(Date.Now, Me.numaniodesde.Value, CType(Me.cbomesdesde.SelectedValue, Enumerados.MesesDelAnio), Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
        End If
      End If
    Next
  End Sub
#End Region

#Region "Pagos benef acum"
  Private Sub btngenpagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenpagos.Click
    Dim _tipobeneficio As String = String.Empty
    If tbtipobenacum.SelectedTab Is tbd3 Then
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
      _tipobeneficio = "Décimo tercer sueldo"
    ElseIf tbtipobenacum.SelectedTab Is tbd4 Then
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
      _tipobeneficio = "Décimo cuarto sueldo"
    ElseIf tbtipobenacum.SelectedTab Is tbvac Then
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
      _tipobeneficio = "Vacaciones"
    Else
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.Utilidades)
      _tipobeneficio = "Utilidades"
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{0} {1}", "Generó pagos de beneficios ", _tipobeneficio))
  End Sub

  Sub grabarPagobenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
    Dim lv As ListView = Nothing
    Select Case _tipobenef
      Case Enumerados.enumTipoBeneficio.DecimoTercero
        lv = lvd3
      Case Enumerados.enumTipoBeneficio.DecimoCuarto
        lv = lvd4
      Case Enumerados.enumTipoBeneficio.Vacaciones
        lv = lvvac
      Case Enumerados.enumTipoBeneficio.Utilidades
        lv = lvUti
    End Select
    If lv.Items.Count = 0 Then
      MsgBox("Debe existir Empleados en la lista", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim LotePago As New LotePago(Sistema.OperadorDatos, Now.Date)
    If Not LotePago.Guardar Then
      MsgBox(LotePago.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    For Each _listitem As ListViewItem In lv.Items
      Dim _benef As BeneficioCalculado
      _benef = CType(_listitem.Tag, BeneficioCalculado)
      Dim PagoVario As New DetalleLotePago(Sistema.OperadorDatos, LotePago, _benef.Contrato.Empleado)
      PagoVario.Pardet_MotivoPagoEnum = _tipobenef
      If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
        PagoVario.DeLoPa_Valor = _benef.UtilidadCalculada + _benef.UtilidadCargas + _benef.UtilidadBono + _benef.UtilidadBonoCargas
      Else
        PagoVario.DeLoPa_Valor = _benef.DecimoCalculado
      End If
      If PagoVario.DeLoPa_Valor >= 5 Then
        PagoVario.PardetFormaPagoRol = _benef.Contrato.Empleado.PardetFormaPagoRol
      Else
        PagoVario.Pardet_FormaPagoRolEnum = Enumerados.enumFormaPagoRol.Efectivo
      End If

      PagoVario.Patrono = _benef.Contrato.Patrono
      Select Case _tipobenef
        Case Enumerados.enumTipoBeneficio.DecimoTercero
          PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.DecimoTercero
        Case Enumerados.enumTipoBeneficio.DecimoCuarto
          PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.DecimoCuarto
        Case Enumerados.enumTipoBeneficio.Vacaciones
          PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.Vacaciones
        Case Enumerados.enumTipoBeneficio.Utilidades
          PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.Utilidades
      End Select
      'PagoVario.Delopa_mostrarenprovisiones = False
      Try
        If Not PagoVario.Guardar Then
          Throw New Exception(PagoVario.OperadorDatos.MsgError)
        End If
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    Next
  End Sub
#End Region

#Region "Exportar"
  Private Sub btnexportarbenac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportarbenac.Click
    Dim _tipobeneficio As String = String.Empty
    If tbtipobenacum.SelectedTab Is tbd3 Then
      Exportarbenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
      _tipobeneficio = "Décimo tercer sueldo"
    ElseIf tbtipobenacum.SelectedTab Is tbd4 Then
      Exportarbenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
      _tipobeneficio = "Décimo cuarto sueldo"
    ElseIf tbtipobenacum.SelectedTab Is tbvac Then
      Exportarbenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
      _tipobeneficio = "Vacaciones"
    Else
      Exportarbenefacum(Enumerados.enumTipoBeneficio.Utilidades)
      _tipobeneficio = "Utilidades"
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1}", "Exportó beneficios ", _tipobeneficio))
  End Sub

  Private Sub Exportarbenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
    Dim lv As ListView = Nothing
    Select Case _tipobenef
      Case Enumerados.enumTipoBeneficio.DecimoTercero
        lv = lvd3
      Case Enumerados.enumTipoBeneficio.DecimoCuarto
        lv = lvd4
      Case Enumerados.enumTipoBeneficio.Vacaciones
        lv = lvvac
      Case Enumerados.enumTipoBeneficio.Utilidades
        lv = lvUti
    End Select
    Dim benefs As New BeneficioList
    For Each _listitem As ListViewItem In lv.Items
      Dim _benef As BeneficioCalculado
      _benef = CType(_listitem.Tag, BeneficioCalculado)
      Dim _item As Beneficio
      _item = New Beneficio(Sistema.OperadorDatos, _benef.Contrato, _tipobenef, 0, True)
      _item.Benefi_DiasTrab = _benef.DiasAcumulados
      _item.Benefi_DiasCalc = _benef.DiasAcumulados
      If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
        _item.Benefi_Valor = _benef.UtilidadCalculada
        _item.Benefi_ValorCargas = _benef.UtilidadCargas
        _item.Benefi_ValorBono = _benef.UtilidadBono
        _item.Benefi_ValorBonoCargas = _benef.UtilidadBonoCargas
      Else
        _item.Benefi_Valor = _benef.DecimoCalculado
      End If
      If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
        _item.Benefi_DiasVac = _benef.DiasVacaciones
      End If
      _item.BeneficioCalculado = _benef
      benefs.Add(_item)
    Next
    Dim _pardettipobenef As New ParametroDet(Sistema.OperadorDatos, CInt(Enumerados.EnumParametros.Tipobeneficio), CInt(_tipobenef))
    ExcelReporte.BeneficioReporte.Imprimir_ListadoBeneficios(benefs, _pardettipobenef)
  End Sub
#End Region

  Private Sub tbtipobenacum_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtipobenacum.SelectedIndexChanged
    Me.btnRecibosBono.Visible = (Me.tbtipobenacum.SelectedTab Is tbuti)
    Me.btnRecibosVac.Visible = (Me.tbtipobenacum.SelectedTab Is tbvac)
  End Sub

  Private Sub btnRecibosVac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibosVac.Click
    Dim lv As ListView = Nothing
    If tbtipobenacum.SelectedTab Is tbvac Then
      lv = lvvac
    End If

    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1}", "Imprimió recibos de", "Vacaciones"))

    Dim benefs As New BeneficioList
    For Each _listitem As ListViewItem In lv.Items
      Dim _benef As BeneficioCalculado
      _benef = CType(_listitem.Tag, BeneficioCalculado)
      Dim _item As Beneficio
      _item = New Beneficio(Sistema.OperadorDatos, _benef.Contrato, Enumerados.enumTipoBeneficio.Utilidades, 0, True)
      _item.Benefi_DiasTrab = _benef.DiasAcumulados
      _item.Benefi_DiasCalc = _benef.DiasAcumulados
      _item.Benefi_FechaDesde = Me.dtfecvacdesde.Value.Date.ToShortDateString
      _item.Benefi_FechaHasta = Me.dtfecvacdesde.Value.Date.AddDays(_benef.DiasVacaciones - 1)

      _item.Benefi_DiasVac = _benef.DiasVacaciones
      _item.Benefi_Valor = _benef.DecimoCalculado

      benefs.Add(_item)
    Next
    ExcelReporte.BeneficioReporte.Imprimir_ReciboVacaciones(benefs, Enumerados.enumTipoBeneficio.Vacaciones)
  End Sub

  Private Sub btnRecibosBono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibosBono.Click
    Dim _tipobeneficio As String = String.Empty
    Dim lv As ListView = Nothing
    If tbtipobenacum.SelectedTab Is tbuti Then
      lv = lvUti
      _tipobeneficio = "Utilidades"
    Else
      lv = lvvac
      _tipobeneficio = "Vacaciones"
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1}", "Imprimió recibos de bonos de ", _tipobeneficio))

    Dim benefs As New BeneficioList
    For Each _listitem As ListViewItem In lv.Items
      Dim _benef As BeneficioCalculado
      _benef = CType(_listitem.Tag, BeneficioCalculado)
      Dim _item As Beneficio
      _item = New Beneficio(Sistema.OperadorDatos, _benef.Contrato, Enumerados.enumTipoBeneficio.Utilidades, 0, True)
      _item.Benefi_DiasTrab = _benef.DiasAcumulados
      _item.Benefi_DiasCalc = _benef.DiasAcumulados

      If tbtipobenacum.SelectedTab Is tbuti Then
        _item.Benefi_Valor = _benef.UtilidadCalculada
        _item.Benefi_ValorCargas = _benef.UtilidadCargas
        _item.Benefi_ValorBono = _benef.UtilidadBono
        _item.Benefi_ValorBonoCargas = _benef.UtilidadBonoCargas
      Else
        _item.Benefi_Valor = _benef.DecimoCalculado
      End If

      benefs.Add(_item)
    Next
    ExcelReporte.BeneficioReporte.Imprimir_ReciboUtilidadBono(benefs, IIf(tbtipobenacum.SelectedTab Is tbuti, Enumerados.enumTipoBeneficio.Utilidades, Enumerados.enumTipoBeneficio.Vacaciones))
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmBeneficios_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmBeneficios_Inicializar(Me, Nothing)
  End Sub

  Private Sub FrmBeneficios_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlBuscaEmpleados1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados1.Op = Sistema.OperadorDatos

    Me.cbotipoliq.OperadorDatos = Sistema.OperadorDatos
    Me.cbotipoliq.Parametro = Enumerados.EnumParametros.TipoLiquidacion
    Me.cbotipoliq.Llenar_Datos()

    Me.cbotiposalida.OperadorDatos = Sistema.OperadorDatos
    Me.cbotiposalida.Parametro = Enumerados.EnumParametros.TipoSalida
    Me.cbotiposalida.Llenar_Datos()

    Me.numaniodesde.Value = Now.Year
    Me.numaniohasta.Value = Now.Year

    Me.cbomesdesde.ValueMember = "Numero"
    Me.cbomesdesde.DisplayMember = "Descripcion"
    Me.cbomesdesde.DataSource = Enumerados.MesesdelAnioList
    Me.cbomesdesde.SelectedValue = Now.Month

    Me.cbomeshasta.ValueMember = "Numero"
    Me.cbomeshasta.DisplayMember = "Descripcion"
    Me.cbomeshasta.DataSource = Enumerados.MesesdelAnioList
    Me.cbomeshasta.SelectedValue = Now.Month

    Me.CtlCuentaBancaria1.llenar_datos()
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