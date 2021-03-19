Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Microsoft.Office.Interop

Public Class FrmBeneficiosSociales
  Implements IOpcion

  Private Sub rdobennopag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdobennopag.CheckedChanged, rdocortadoa.CheckedChanged, rdorangoper.CheckedChanged
    If tbtipobenacum.SelectedTab IsNot tbotros Then
      Me.pnlperiododesde.Visible = True
      Me.pnlperiodohasta.Visible = True
      If rdobennopag.Checked Then
        Me.pnlperiododesde.Visible = False
        Me.pnlperiodohasta.Visible = False
      ElseIf rdocortadoa.Checked Then
        Me.pnlperiododesde.Visible = False
      End If
    End If
  End Sub

#Region "Cargar benef acum"
  Private Sub btnconsbenacum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsbenacum.Click
    If tbtipobenacum.SelectedTab Is tbd3g Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
    ElseIf tbtipobenacum.SelectedTab Is tbd4g Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
    ElseIf tbtipobenacum.SelectedTab Is tbvacg Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
    ElseIf tbtipobenacum.SelectedTab Is tbutig Then
      Mtcargarbenefacum(Enumerados.enumTipoBeneficio.Utilidades)
    ElseIf tbtipobenacum.SelectedTab Is tbotros Then
      'Mtcargarbenefacum(Enumerados.enumTipoBeneficio.)
      Mtcargarotropagos()
    End If
  End Sub

  Private Sub Mtcargarotropagos()

    Dim _contratos As ContratoList
    Try
      '_contratos = Me.CtlBuscaEmpleados1.RetornarContratoListChecked(CtlBuscaEmpleados1.CtlPatrono1.Patrono)
      _contratos = Me.CtlBuscaEmpleados1.RetornarUltimoContratoListChecked(CtlBuscaEmpleados1.CtlPatrono1.Patrono)
    Catch ex As Exception
      MsgBox("Seleccione al menos un registro de la lista de empleados", MsgBoxStyle.Information, "Información")
      Exit Sub
    End Try

    If _contratos.Count = 0 Then
      MsgBox("Seleccione al menos un registro de la lista de empleados", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim lista As New BeneficiosSocialesList
    For Each _contrato As Contrato In _contratos
      If _contrato IsNot Nothing Then
        Dim beneficiosocial As New BeneficiosSociales(Sistema.OperadorDatos, True, Nothing, Nothing)
        beneficiosocial.Entida_Codigo = _contrato.Entida_Codigo
        beneficiosocial.Patron_Codigo = _contrato.Patron_Codigo
        beneficiosocial.Contra_Secuencia = _contrato.Contra_Secuencia
        'beneficiosocial.Parame_TipoBeneficio = 
        'beneficiosocial.Pardet_TipoBeneficio = 
        beneficiosocial.BenSoc_Valor = 0
        lista.Add(beneficiosocial)
      End If
    Next

    'For Each _contrato As Contrato In _contratos
    '  If _contrato IsNot Nothing Then
    '    Dim beneficiosocial As New BeneficiosSociales(Sistema.OperadorDatos, True)
    '    beneficiosocial.Entida_Codigo = _contrato.Entida_Codigo
    '    beneficiosocial.Patron_Codigo = _contrato.Patron_Codigo
    '    beneficiosocial.Contra_Secuencia = _contrato.Contra_Secuencia
    '    beneficiosocial.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
    '    beneficiosocial.Pardet_TipoBeneficio = _tipobenef 'Enumerados.enumTipoBeneficio.DecimoTercero
    '    Dim beneficio As BeneficioSocialCalculado
    '    If Me.rdobennopag.Checked Then
    '      beneficio = New BeneficioSocialCalculado(Sistema.OperadorDatos, _contrato, _tipobenef)
    '    ElseIf Me.rdorangoper.Checked Then
    '      Dim a As String
    '      Dim b As String
    '      a = dtFechadesde.Value.ToShortDateString.Remove(0, 2)
    '      b = dtFechahasta.Value.ToShortDateString.Remove(0, 2)
    '      beneficio = New BeneficioSocialCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, a.Insert(0, "01"), ConcadenaDia(b))
    '    Else
    '      Dim b As String
    '      b = dtFechahasta.Value.ToShortDateString.Remove(0, 2)
    '      beneficio = New BeneficioSocialCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, ConcadenaDia(b))
    '    End If
    '    If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
    '      'beneficiosocial.BenSoc_Valor = beneficio.SueldosAcumulados
    '      beneficiosocial.DiasBeneficio = beneficio.DiasAcumulados
    '    Else
    '      beneficiosocial.BenSoc_Valor = beneficio.SueldosAcumulados
    '    End If

    '    If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
    '      beneficiosocial.BenSoc_FechaDesde = beneficio.FecDesde.ToShortDateString
    '      beneficiosocial.BenSoc_FechaHasta = beneficio.FecHasta.ToShortDateString
    '    End If

    '    lista.Add(beneficiosocial)
    '  End If
    'Next
    'Select Case _tipobenef
    '  Case Enumerados.enumTipoBeneficio.DecimoTercero
    '    bsD3.DataSource = lista
    '  Case Enumerados.enumTipoBeneficio.DecimoCuarto
    '    bsD4.DataSource = lista
    '  Case Enumerados.enumTipoBeneficio.Vacaciones
    '    bsVacacion.DataSource = lista
    '  Case Enumerados.enumTipoBeneficio.Utilidades
    '    bsUtilidad.DataSource = lista
    'End Select

    bsOtrosPagos.DataSource = lista

  End Sub

  'Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
  '  If CDec(txtUti.Text) <= 0 Then
  '    MsgBox("Ingresar valor de Utilidad", MsgBoxStyle.Critical, "Error")
  '    Exit Sub
  '  End If

  '  Dim _totaldias As Long = 0
  '  Dim _totaldiascargas As Long = 0
  '  For Each _item As ListViewItem In Me.lvUti.Items
  '    With CType(_item.Tag, BeneficioSocialCalculado)
  '      _totaldias += .DiasAcumulados
  '      _totaldiascargas += .DiasAcumulados * .Contrato.Empleado.NumeroCargas
  '      '_totaldiascargas += .DiasAcumulados * .Contrato.Empleado.Cargas
  '    End With
  '  Next

  '  If _totaldias = 0 Then
  '    MsgBox("No existen días trabajados", MsgBoxStyle.Information, "Información")
  '    Exit Sub
  '  End If

  '  'Dim _razonuti As Decimal = CDec(Me.txtUti.Text) * 0.1 / _totaldias
  '  'Dim _razonuticargas As Decimal = CDec(Me.txtUti.Text) * 0.05 / _totaldiascargas
  '  'Dim _razonutibono As Decimal = CDec(Me.txtutibono.Text) / _totaldias
  '  'Dim _razonutibonocargas As Decimal = CDec(Me.txtutibonocargas.Text) / _totaldiascargas
  '  Dim _razonuti As Decimal = CDec(Me.txtUti.Value) * 0.1 / _totaldias
  '  Dim _razonuticargas As Decimal = CDec(Me.txtUti.Value) * 0.05 / _totaldiascargas
  '  Dim _razonutibono As Decimal = CDec(Me.txtutibono.Value) / _totaldias
  '  Dim _razonutibonocargas As Decimal = CDec(Me.txtutibonocargas.Value) / _totaldiascargas

  '  For Each _item As ListViewItem In Me.lvUti.Items
  '    With CType(_item.Tag, BeneficioSocialCalculado)
  '      .UtilidadCalculada = _razonuti * .DiasAcumulados
  '      .UtilidadCargas = _razonuticargas * .Contrato.Empleado.NumeroCargas * .DiasAcumulados
  '      .UtilidadBono = _razonutibono * .DiasAcumulados
  '      .UtilidadBonoCargas = _razonutibonocargas * .Contrato.Empleado.NumeroCargas * .DiasAcumulados

  '      _item.SubItems(6).Text = .UtilidadCalculada.ToString("0.00")
  '      _item.SubItems(7).Text = .UtilidadCargas.ToString("0.00")
  '      _item.SubItems(8).Text = .UtilidadBono.ToString("0.00")
  '      _item.SubItems(9).Text = .UtilidadBonoCargas.ToString("0.00")
  '    End With
  '  Next
  'End Sub

  Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcularuti.Click
    If (txtUti.Value <= 0) Or (txtUtiBono.Value < 0) Or (txtUtiBonoCargas.Value < 0) Then
      MsgBox("Ingresar valor de Utilidad", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _totaldias As Decimal = 0
    Dim _totaldiascargas As Decimal = 0

    For Each _beneficio As BeneficiosSociales In bsUtilidad
      _totaldias += _beneficio.BenSoc_Dias '_beneficio.DiasBeneficio
      _totaldiascargas += _beneficio.NumeroCargas * _beneficio.BenSoc_Dias '_beneficio.DiasBeneficio
    Next

    If _totaldias = 0 Then
      MsgBox("No existen días trabajados", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim _razonuti As Decimal = (Me.txtUti.Value * 0.1) / _totaldias

    Dim _razonuticargas As Decimal
    If Not _totaldiascargas = 0 Then
      _razonuticargas = (Me.txtUti.Value * 0.05) / _totaldiascargas
    Else
      _razonuticargas = 0
    End If

    For Each _beneficio As BeneficiosSociales In bsUtilidad
      _beneficio.BenSoc_ValorEmpleado = _razonuti * _beneficio.BenSoc_Dias '_beneficio.DiasBeneficio
      _beneficio.BenSoc_ValorCargas = _razonuticargas * _beneficio.NumeroCargas * _beneficio.BenSoc_Dias '_beneficio.DiasBeneficio
      If _beneficio.PardetPersonaAdicional Is Nothing Then
        _beneficio.BenSoc_ValorBono = _beneficio.BenSoc_Dias * Me.txtUtiBono.Value
        _beneficio.BenSoc_ValorBonoCargas = _beneficio.BenSoc_Dias * _beneficio.NumeroCargas * Me.txtUtiBonoCargas.Value

        If _beneficio.BenSoc_ValorEmpleado + _beneficio.BenSoc_ValorCargas + _beneficio.BenSoc_ValorBono + _beneficio.BenSoc_ValorBonoCargas < Me.txtMinimoUtilidad.Value Then
          _beneficio.BenSoc_ValorBonoAlcance = Me.txtMinimoUtilidad.Value - (_beneficio.BenSoc_ValorEmpleado + _beneficio.BenSoc_ValorCargas + _beneficio.BenSoc_ValorBono + _beneficio.BenSoc_ValorBonoCargas)
        Else
          _beneficio.BenSoc_ValorBonoAlcance = 0
        End If
      End If
      _beneficio.BenSoc_Valor = _beneficio.BenSoc_ValorEmpleado + _beneficio.BenSoc_ValorCargas + _beneficio.BenSoc_ValorBono + _beneficio.BenSoc_ValorBonoCargas + _beneficio.BenSoc_ValorBonoAlcance
    Next
    DataGridViewUti.Invalidate()
  End Sub

  Private Sub Mtcargarbenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
    Dim _contratos As ContratoList
    Try
      _contratos = Me.CtlBuscaEmpleados1.RetornarUltimoContratoListChecked(CtlPatronoCombo1.Patrono)
      If _contratos.Count = 0 Then
        Throw New Exception
      End If
    Catch ex As Exception
      MsgBox("Seleccione al menos un registro de la lista de empleados", MsgBoxStyle.Information, "Información")
      Exit Sub
    End Try
    Dim _desde As Date = dtFechadesde.Value.Date
    Dim _hasta As Date = dtFechahasta.Value.Date
    _desde = _desde.AddDays(-_desde.Day + 1)
    _hasta = _hasta.AddDays(31)
    _hasta = _hasta.AddDays(-_hasta.Day)

    Dim lista As New BeneficiosSocialesList
    For Each _contrato As Contrato In _contratos
      If _contrato IsNot Nothing Then
        If (Not _tipobenef = Enumerados.enumTipoBeneficio.Utilidades) OrElse (_tipobenef = Enumerados.enumTipoBeneficio.Utilidades And CtlPatronoCombo1.Patrono.Patron_Codigo = _contrato.Patron_Codigo) Then

          Dim benefCalc As BeneficioSocialCalculado
          If Me.rdobennopag.Checked Then
            benefCalc = New BeneficioSocialCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, Nothing, Nothing)
          ElseIf Me.rdorangoper.Checked Then
            benefCalc = New BeneficioSocialCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, _desde, _hasta)
          Else
            benefCalc = New BeneficioSocialCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, Nothing, _hasta)
          End If

          Dim beneficiosocial As BeneficiosSociales
          If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
            Try
              beneficiosocial = New BeneficiosSociales(Sistema.OperadorDatos, _contrato, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Vacaciones, benefCalc.SecuenciaVacacion)
            Catch ex As Exception
              Continue For
            End Try
          Else
            beneficiosocial = New BeneficiosSociales(Sistema.OperadorDatos, True, _desde, _hasta)
            beneficiosocial.Entida_Codigo = _contrato.Entida_Codigo
            beneficiosocial.Patron_Codigo = _contrato.Patron_Codigo
            beneficiosocial.Contra_Secuencia = _contrato.Contra_Secuencia
            beneficiosocial.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
            beneficiosocial.Pardet_TipoBeneficio = _tipobenef
          End If

          Dim puedeagregar As Boolean = True
          Select Case _tipobenef
            Case Enumerados.enumTipoBeneficio.Utilidades
              beneficiosocial.BenSoc_Dias = benefCalc.DiasAcumulados
              beneficiosocial.BenSoc_DecimoTercero = benefCalc.Valord3
              beneficiosocial.BenSoc_DecimoCuarto = benefCalc.Valord4
              beneficiosocial.BenSoc_UtilidadAnterior = benefCalc.UtilidadAnterior
              beneficiosocial.BenSoc_Salarios = benefCalc.Sueldosacumulados
              beneficiosocial.BenSoc_FondoReserva = benefCalc.FondoReserva
              beneficiosocial.BenSoc_Comisiones = 0
              beneficiosocial.BenSoc_BeneficiosAdionales = 0
              beneficiosocial.BenSoc_AnticipoUtilidad = 0
              beneficiosocial.BenSoc_RetencionJudicial = 0
              beneficiosocial.BenSoc_ImpuestoRetencion = 0
              beneficiosocial.BenSoc_SalarioDigno = (403.9 / 30 * benefCalc.DiasAcumulados) - (benefCalc.Valord3 + benefCalc.Valord4 + benefCalc.UtilidadAnterior + benefCalc.Sueldosacumulados + benefCalc.FondoReserva)
              beneficiosocial.BenSoc_SalarioDigno = IIf(beneficiosocial.BenSoc_SalarioDigno < 0, 0, beneficiosocial.BenSoc_SalarioDigno)
            Case Enumerados.enumTipoBeneficio.DecimoTercero
              beneficiosocial.BenSoc_Valor = benefCalc.ValorCalculado
              beneficiosocial.BenSoc_ValorAcumulado = benefCalc.ValorAcumulado
              beneficiosocial.BenSoc_DiasAcumulados = benefCalc.DiasAcumulados
              If benefCalc.ValorAcumulado + benefCalc.DiasAcumulados = 0 Then
                puedeagregar = False
              End If
            Case Enumerados.enumTipoBeneficio.Vacaciones
              beneficiosocial.BenSoc_Dias = benefCalc.DiasCalculados
              beneficiosocial.BenSoc_Valor = benefCalc.ValorCalculado
              beneficiosocial.BenSoc_DiasAcumulados = benefCalc.DiasAcumulados
              beneficiosocial.BenSoc_ValorAcumulado = benefCalc.ValorAcumulado
              beneficiosocial.BenSoc_FechaDesde = benefCalc.FecDesde
              beneficiosocial.BenSoc_FechaHasta = benefCalc.FecHasta
            Case Enumerados.enumTipoBeneficio.DecimoCuarto
              beneficiosocial.BenSoc_DiasAcumulados = benefCalc.DiasAcumulados
              beneficiosocial.BenSoc_Valor = benefCalc.ValorCalculado
          End Select

          If puedeagregar Then
            If (Not _tipobenef = Enumerados.enumTipoBeneficio.Utilidades) OrElse (beneficiosocial.BenSoc_Dias > 0 AndAlso _tipobenef = Enumerados.enumTipoBeneficio.Utilidades) Then
              lista.Add(beneficiosocial)
            End If
          End If
        End If
      End If
    Next
    Select Case _tipobenef
      Case Enumerados.enumTipoBeneficio.DecimoTercero
        bsD3.DataSource = lista
      Case Enumerados.enumTipoBeneficio.DecimoCuarto
        bsD4.DataSource = lista
      Case Enumerados.enumTipoBeneficio.Vacaciones
        bsVacacion.DataSource = lista
      Case Enumerados.enumTipoBeneficio.Utilidades
        Dim mPersonasAdicionales As WWTSParametroDetList = WWTSParametroDetList.ObtenerLista(Sistema.OperadorDatos, Enumerados.EnumParametros.PersonalAdicionalUtilidades)
        For Each _pardetPersonaAdicional As WWTSParametroDet In mPersonasAdicionales
          If _pardetPersonaAdicional.Pardet_DatoBit1 Then
            Dim beneficiosocial As BeneficiosSociales = New BeneficiosSociales(Sistema.OperadorDatos, True, _desde, _hasta)
            beneficiosocial.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
            beneficiosocial.Pardet_TipoBeneficio = _tipobenef
            beneficiosocial.Patron_Codigo = Me.CtlPatronoCombo1.Patrono.Patron_Codigo
            beneficiosocial.BenSoc_Dias = _pardetPersonaAdicional.Pardet_DatoDec1
            beneficiosocial.BenSoc_NumeroCargas = _pardetPersonaAdicional.Pardet_DatoInt1
            beneficiosocial.PardetPersonaAdicional = _pardetPersonaAdicional
            lista.Add(beneficiosocial)
          End If
        Next
        bsUtilidad.DataSource = lista
    End Select

  End Sub

  'Private Function ConcadenaDia(ByVal _cadena As String) As String
  '  Dim resultado As String = ""
  '  resultado = _cadena
  '  Select Case dtFechahasta.Value.Month
  '    Case 1, 3, 5, 7, 8, 10, 12
  '      resultado = _cadena.Insert(0, "31")
  '    Case 4, 6, 9, 11
  '      resultado = _cadena.Insert(0, "30")
  '    Case 2
  '      If Date.IsLeapYear(dtFechahasta.Value.Year) Then
  '        resultado = _cadena.Insert(0, "29")
  '      Else
  '        resultado = _cadena.Insert(0, "28")
  '      End If
  '  End Select

  '  Return resultado
  'End Function

  'Private Sub Mtcargarbenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
  '  Dim lv As ListView = Nothing
  '  Select Case _tipobenef
  '    Case Enumerados.enumTipoBeneficio.DecimoTercero
  '      lv = lvd3
  '    Case Enumerados.enumTipoBeneficio.DecimoCuarto
  '      lv = lvd4
  '    Case Enumerados.enumTipoBeneficio.Vacaciones
  '      lv = lvvac
  '    Case Enumerados.enumTipoBeneficio.Utilidades
  '      lv = lvUti
  '  End Select
  '  lv.Items.Clear()
  '  Dim _contratos As ContratoList
  '  _contratos = Me.CtlBuscaEmpleados1.RetornarContratoListChecked
  '  For Each _contrato As Contrato In _contratos
  '    If _contrato IsNot Nothing Then
  '      Dim benefcalc As BeneficioCalculado
  '      If Me.rdobennopag.Checked Then
  '        benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef)
  '      ElseIf Me.rdocortadoa.Checked Then
  '        benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
  '      Else
  '        benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef, Me.numaniodesde.Value, CType(Me.cbomesdesde.SelectedValue, Enumerados.MesesDelAnio), Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
  '      End If

  '      If Not benefcalc.DiasAcumulados = 0 Then
  '        Dim item As New ListViewItem
  '        item.Text = (_contrato.Empleado.Entida_Codigo)
  '        item.SubItems.Add(_contrato.Empleado.Cedula)
  '        item.SubItems.Add(_contrato.Empleado.NombreCompleto)
  '        If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
  '          item.SubItems.Add(benefcalc.DiasAcumulados.ToString("0.00"))
  '          item.SubItems.Add((IIf(benefcalc.Contrato.Empleado.AniosTrabajados >= 1, "Si", "No")))
  '          item.SubItems.Add(benefcalc.Contrato.Empleado.Cargas)
  '          item.SubItems.Add((0).ToString("0.00"))
  '          item.SubItems.Add((0).ToString("0.00"))
  '          item.SubItems.Add((0).ToString("0.00"))
  '          item.SubItems.Add((0).ToString("0.00"))
  '          item.SubItems.Add((0).ToString("0.00"))
  '          item.SubItems.Add("")
  '          item.SubItems.Add("")
  '        Else
  '          If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
  '            item.SubItems.Add(benefcalc.Contrato.Empleado.AniosTrabajados.ToString("0.00"))
  '            item.SubItems.Add(benefcalc.DiasVacaciones.ToString("0.00"))
  '            item.SubItems.Add(Me.dtfecvacdesde.Value.Date.ToShortDateString)
  '            item.SubItems.Add(Me.dtfecvacdesde.Value.Date.AddDays(benefcalc.DiasVacaciones - 1).ToShortDateString)
  '          Else
  '            item.SubItems.Add(benefcalc.SueldosAcumulados.ToString("0.00"))
  '            item.SubItems.Add(benefcalc.IESSAcumulados.ToString("0.00"))
  '          End If
  '          item.SubItems.Add(benefcalc.DecimoCalculado.ToString("0.00"))
  '        End If
  '        item.Tag = benefcalc
  '        lv.Items.Add(item)

  '      End If
  '    End If
  '  Next
  'End Sub
#End Region

#Region "Guardar benef acum"
  Private Sub btngrabarbenacum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim _tipobeneficio As String = String.Empty
    'If tbtipobenacum.SelectedTab Is tbd3 Then
    '  Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
    '  _tipobeneficio = "Décimo tercer sueldo"
    '  lvd3.Items.Clear()
    'ElseIf tbtipobenacum.SelectedTab Is tbd4 Then
    '  Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
    '  _tipobeneficio = "Décimo cuarto sueldo"
    '  lvd4.Items.Clear()
    'ElseIf tbtipobenacum.SelectedTab Is tbvac Then
    '  Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
    '  _tipobeneficio = "Vacaciones"
    '  lvvac.Items.Clear()
    'Else
    '  Mtgrabarbenefacum(Enumerados.enumTipoBeneficio.Utilidades)
    '  _tipobeneficio = "Utilidades"
    '  lvUti.Items.Clear()
    'End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{0} {1}", "Dió de baja beneficios ", _tipobeneficio))
  End Sub

  'Private Sub Mtgrabarbenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
  '  Dim _contratos As ContratoList
  '  _contratos = Me.CtlBuscaEmpleados1.RetornarContratoListChecked(CtlPatronoCombo1.Patrono)
  '  For Each _contrato As Contrato In _contratos
  '    Dim benefcalc As BeneficioCalculado
  '    benefcalc = New BeneficioCalculado(Sistema.OperadorDatos, _contrato, _tipobenef)
  '    If Not benefcalc.DiasAcumulados = 0 Then
  '      Dim beneficio As New Beneficio(Sistema.OperadorDatos, _contrato, _tipobenef, 1, True)
  '      If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
  '        beneficio.Benefi_Valor = benefcalc.UtilidadCalculada + benefcalc.UtilidadCargas + benefcalc.UtilidadBono + benefcalc.UtilidadBonoCargas
  '      Else
  '        beneficio.Benefi_Valor = benefcalc.DecimoCalculado
  '      End If
  '      beneficio.Benefi_Valor = benefcalc.DecimoCalculado
  '      beneficio.Pardet_TipoBeneficioEnum = _tipobenef
  '      beneficio.Benefi_DiasCalc = benefcalc.DiasAcumulados
  '      beneficio.Benefi_DiasTrab = benefcalc.DiasAcumulados
  '      beneficio.Benefi_FechaDesde = benefcalc.FecDesde
  '      beneficio.Benefi_FechaHasta = benefcalc.FecHasta

  '      If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
  '        'Dim _aviso As New Permiso(Sistema.OperadorDatos, _contrato)
  '        '_aviso.Permis_FechaDesde = Me.dtfecvacdesde.Value.Date
  '        '_aviso.Permis_FechaHasta = Me.dtfecvacdesde.Value.Date.AddDays(benefcalc.DiasVacaciones)
  '        '_aviso.Pardet_TipoPermisoEnum = Enumerados.enumTipoPermiso.Vacaciones
  '        '_aviso.Guardar()
  '      End If
  '      If Me.rdobennopag.Checked Then
  '        beneficio.Guardar(Date.Now)
  '      ElseIf Me.rdocortadoa.Checked Then
  '        beneficio.Guardar(Date.Now, Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
  '      Else
  '        beneficio.Guardar(Date.Now, Me.numaniodesde.Value, CType(Me.cbomesdesde.SelectedValue, Enumerados.MesesDelAnio), Me.numaniohasta.Value, CType(Me.cbomeshasta.SelectedValue, Enumerados.MesesDelAnio))
  '      End If
  '    End If
  '  Next
  'End Sub
#End Region

#Region "Pagos benef acum"
  Private Sub btngenpagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
    If MsgBox("Esta operación no puede ser reversada. ¿Está seguro que desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Dim _tipobeneficio As String = String.Empty
    If tbtipobenacum.SelectedTab Is tbd3g Then
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.DecimoTercero)
      _tipobeneficio = "Décimo tercer sueldo"
    ElseIf tbtipobenacum.SelectedTab Is tbd4g Then
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.DecimoCuarto)
      _tipobeneficio = "Décimo cuarto sueldo"
    ElseIf tbtipobenacum.SelectedTab Is tbvacg Then
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.Vacaciones)
      _tipobeneficio = "Vacaciones"
    ElseIf tbtipobenacum.SelectedTab Is tbotros Then
      grabarPagootros()
    Else
      grabarPagobenefacum(Enumerados.enumTipoBeneficio.Utilidades)
      _tipobeneficio = "Utilidades"

    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{0} {1}", "Generó pagos de beneficios ", _tipobeneficio))
  End Sub

  Sub grabarPagootros()
    Dim bs As BindingSource = Nothing
    Dim _tipobeneficio As String = String.Empty

    bs = bsOtrosPagos
    _tipobeneficio = ComboBoxOtrosPagos.ParametroDet.Pardet_Descripcion

    If bs.Count = 0 Then
      MsgBox("Debe existir Empleados en la lista", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Sistema.OperadorDatos.ComenzarTransaccion()
    Try
      Dim _lote As New BeneficiosSocialesLotePago(Sistema.OperadorDatos, True)
      _lote.Patron_Codigo = CtlBuscaEmpleados1.CtlPatrono1.Patrono.Patron_Codigo
      '_lote.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
      '_lote.Pardet_TipoBeneficio = _tipobenef

      _lote.PardetTipoBeneficio = ComboBoxOtrosPagos.ParametroDet

      If Not _lote.Guardar() Then
        Throw New Exception(_lote.OperadorDatos.MsgError)
      End If

      For Each _beneficio As BeneficiosSociales In bs
        _beneficio.BenLot_Codigo = _lote.BenLot_Codigo
        Try
          If Not _beneficio.Guardar Then
            Throw New Exception(_beneficio.OperadorDatos.MsgError)
          End If
        Catch ex As Exception
          Sistema.OperadorDatos.CancelarTransaccion()
          MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
          Exit For
        End Try
      Next
      MsgBox("Se ha generado un lote de pago para " + _tipobeneficio + Chr(13) + "Grabo Satisfactoriamente", MsgBoxStyle.Information, "Información")
      Sistema.OperadorDatos.TerminarTransaccion()

      For Each _beneficio As BeneficiosSociales In bs
        _beneficio.AceptarCambios()
      Next

      bs.DataSource = Nothing
      'otrospagos(ComboBoxOtrosPagos.ParametroDet)
    Catch ex As Exception
      '  MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      Sistema.OperadorDatos.CancelarTransaccion()
    End Try

  End Sub

  Sub grabarPagobenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
    If MsgBox("Se va a generar el pago de beneficios. ¿Está seguro que desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If

    Dim bs As BindingSource = Nothing
    Dim _tipobeneficio As String = String.Empty
    Select Case _tipobenef
      Case Enumerados.enumTipoBeneficio.DecimoTercero
        bs = bsD3
        _tipobeneficio = "Décimo tercer sueldo"
      Case Enumerados.enumTipoBeneficio.DecimoCuarto
        bs = bsD4
        _tipobeneficio = "Décimo cuarto sueldo"
      Case Enumerados.enumTipoBeneficio.Vacaciones
        bs = bsVacacion
        _tipobeneficio = "Vacaciones"
      Case Enumerados.enumTipoBeneficio.Utilidades
        bs = bsUtilidad
        _tipobeneficio = "Utilidades"
    End Select

    If bs.Count = 0 Then
      MsgBox("Debe existir Empleados en la lista", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Sistema.OperadorDatos.ComenzarTransaccion()
    Try
      Dim _lote As New BeneficiosSocialesLotePago(Sistema.OperadorDatos, True)
      If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
        _lote.Patron_Codigo = CtlPatronoCombo1.Patrono.Patron_Codigo
      Else
        _lote.Patron_Codigo = CtlBuscaEmpleados1.CtlPatrono1.Patrono.Patron_Codigo
      End If
      _lote.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
      _lote.Pardet_TipoBeneficio = _tipobenef

      If Not _lote.Guardar() Then
        Throw New Exception(_lote.OperadorDatos.MsgError)
      End If

      For Each _beneficio As BeneficiosSociales In bs
        _beneficio.BenLot_Codigo = _lote.BenLot_Codigo

        Dim _desde As Date = dtFechadesde.Value.Date
        Dim _hasta As Date = dtFechahasta.Value.Date
        _desde = _desde.AddDays(-_desde.Day + 1)
        _hasta = _hasta.AddDays(31)
        _hasta = _hasta.AddDays(-_hasta.Day)

        If _tipobenef = Enumerados.enumTipoBeneficio.Vacaciones Then
          _beneficio.BenSoc_Liquidado = True
          _beneficio.cortado = 1
          _beneficio.desde = _beneficio.BenSoc_FechaDesde
          _beneficio.hasta = _beneficio.BenSoc_FechaHasta
        Else
          If Me.rdobennopag.Checked Then
          ElseIf Me.rdorangoper.Checked Then
            _beneficio.cortado = 1
            _beneficio.desde = _desde
            _beneficio.hasta = _hasta
          Else
            _beneficio.cortado = 2
            _beneficio.hasta = _hasta
          End If
        End If

        If _tipobenef = Enumerados.enumTipoBeneficio.DecimoTercero AndAlso _beneficio.BenSoc_DiasAcumulados + _beneficio.BenSoc_ValorAcumulado = 0 Then
          'no se puede guardar valores en blanco
        Else
          If Not _beneficio.Guardar Then
            Throw New Exception(_beneficio.OperadorDatos.MsgError)
          End If
        End If
      Next
      Sistema.OperadorDatos.TerminarTransaccion()

      For Each _beneficio As BeneficiosSociales In bs
        _beneficio.AceptarCambios()
      Next

      MsgBox("Se ha generado un lote de pago para " + _tipobeneficio + Chr(13) + "Grabo Satisfactoriamente", MsgBoxStyle.Information, "Información")

      
      bs.DataSource = Nothing
      'benpag(_tipobenef)
    Catch ex As Exception
      Sistema.OperadorDatos.CancelarTransaccion()
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  'Sub grabarPagobenefacum(ByVal _tipobenef As Enumerados.enumTipoBeneficio)
  '  Dim lv As ListView = Nothing
  '  Select Case _tipobenef
  '    Case Enumerados.enumTipoBeneficio.DecimoTercero
  '      lv = lvd3
  '    Case Enumerados.enumTipoBeneficio.DecimoCuarto
  '      lv = lvd4
  '    Case Enumerados.enumTipoBeneficio.Vacaciones
  '      lv = lvvac
  '    Case Enumerados.enumTipoBeneficio.Utilidades
  '      lv = lvUti
  '  End Select
  '  If lv.Items.Count = 0 Then
  '    MsgBox("Debe existir Empleados en la lista", MsgBoxStyle.Information, "Información")
  '    Exit Sub
  '  End If

  '  Dim LotePago As New LotePago(Sistema.OperadorDatos, Now.Date)
  '  If Not LotePago.Guardar Then
  '    MsgBox(LotePago.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
  '    Exit Sub
  '  End If

  '  For Each _listitem As ListViewItem In lv.Items
  '    Dim _benef As BeneficioCalculado
  '    _benef = CType(_listitem.Tag, BeneficioCalculado)
  '    Dim PagoVario As New DetalleLotePago(Sistema.OperadorDatos, LotePago, _benef.Contrato.Empleado)
  '    PagoVario.Pardet_MotivoPagoEnum = _tipobenef
  '    If _tipobenef = Enumerados.enumTipoBeneficio.Utilidades Then
  '      PagoVario.DeLoPa_Valor = _benef.UtilidadCalculada + _benef.UtilidadCargas + _benef.UtilidadBono + _benef.UtilidadBonoCargas
  '    Else
  '      PagoVario.DeLoPa_Valor = _benef.DecimoCalculado
  '    End If
  '    If PagoVario.DeLoPa_Valor >= 5 Then
  '      PagoVario.PardetFormaPagoRol = _benef.Contrato.Empleado.PardetFormaPagoRol
  '    Else
  '      PagoVario.Pardet_FormaPagoRolEnum = Enumerados.enumFormaPagoRol.Efectivo
  '    End If

  '    PagoVario.Patrono = _benef.Contrato.Patrono
  '    Select Case _tipobenef
  '      Case Enumerados.enumTipoBeneficio.DecimoTercero
  '        PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.DecimoTercero
  '      Case Enumerados.enumTipoBeneficio.DecimoCuarto
  '        PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.DecimoCuarto
  '      Case Enumerados.enumTipoBeneficio.Vacaciones
  '        PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.Vacaciones
  '      Case Enumerados.enumTipoBeneficio.Utilidades
  '        PagoVario.Pardet_MotivoPagoEnum = Enumerados.enumMotivoPago.Utilidades
  '    End Select
  '    'PagoVario.Delopa_mostrarenprovisiones = False
  '    Try
  '      If Not PagoVario.Guardar Then
  '        Throw New Exception(PagoVario.OperadorDatos.MsgError)
  '      End If
  '    Catch ex As Exception
  '      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
  '    End Try
  '  Next
  'End Sub
#End Region

#Region "Exportar"
  Private Sub btnexportarbenac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
    Dim _tipobeneficio As String = String.Empty
    If tbtipobenacum.SelectedTab Is tbd3g Then
      DataGridViewD3.Excel(EnumSalida.Excel)
    ElseIf tbtipobenacum.SelectedTab Is tbd4g Then
      DataGridViewD4.Excel(EnumSalida.Excel)
    ElseIf tbtipobenacum.SelectedTab Is tbvacg Then
      DataGridViewVaca.Excel(EnumSalida.Excel)
    Else
      DataGridViewUti.Excel(EnumSalida.Excel)
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("{0} {1}", "Exportó beneficios ", _tipobeneficio))
  End Sub

#End Region

  Private Sub tbtipobenacum_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtipobenacum.SelectedIndexChanged
    If tbtipobenacum.SelectedTab Is tbotros OrElse tbtipobenacum.SelectedTab Is tbvacg Then
      Me.pnlrangoperiodos.Visible = False
    Else
      Me.pnlrangoperiodos.Visible = True
    End If
    rdobennopag_CheckedChanged(sender, e)
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

  Private Sub FrmBeneficios_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Beneficios Sociales"

    Me.CtlBuscaEmpleados1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados1.Op = Sistema.OperadorDatos

    Me.CtlBuscaEmpleados2.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados2.Op = Sistema.OperadorDatos

    Me.ComboBoxOtrosPagos.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxOtrosPagos.Parametro = Enumerados.EnumParametros.Beneficio
    Me.ComboBoxOtrosPagos.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Beneficio, 2))

    Me.CtlPatronoCombo1.Op = Sistema.OperadorDatos
    Me.CtlPatronoCombo1.llenar_datos(Sistema.Usuario)

    Llenar_D3()
    Llenar_D4()
    Llenar_Vacacion()
    Llenar_Utilidad()

    Llenar_OtrosPagos()
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


#Region "Llenardatos"
  Sub Llenar_D3()

    Me.DataGridViewD3.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Código"
    DataGridViewTextBoxColumn1.Width = 70
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CedulaEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Cédula"
    DataGridViewTextBoxColumn1.Width = 75
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Empleado"
    DataGridViewTextBoxColumn1.Width = 190
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorAcumulado"
    DataGridViewTextBoxColumn1.HeaderText = "Sueldos acumulados"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_DiasAcumulados"
    DataGridViewTextBoxColumn1.HeaderText = "Dias"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewD3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Sub Llenar_D4()
    Me.DataGridViewD4.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Código"
    DataGridViewTextBoxColumn1.Width = 70
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CedulaEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Cédula"
    DataGridViewTextBoxColumn1.Width = 75
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Empleado"
    DataGridViewTextBoxColumn1.Width = 190
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewD4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_DiasAcumulados"
    DataGridViewTextBoxColumn1.HeaderText = "Dias Acumulados"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewD4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Sub Llenar_Vacacion()
    Me.DataGridViewVaca.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Código"
    DataGridViewTextBoxColumn1.Width = 70
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CedulaEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Cédula"
    DataGridViewTextBoxColumn1.Width = 75
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Empleado"
    DataGridViewTextBoxColumn1.Width = 190
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Dias"
    DataGridViewTextBoxColumn1.HeaderText = "Dias"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorAcumulado"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Acumulado"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_DiasAcumulados"
    DataGridViewTextBoxColumn1.HeaderText = "Dias Acumulados"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FechaDesde"
    DataGridViewTextBoxColumn1.HeaderText = "Desde"
    DataGridViewTextBoxColumn1.Width = 110
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FechaHasta"
    DataGridViewTextBoxColumn1.HeaderText = "Hasta"
    DataGridViewTextBoxColumn1.Width = 110
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Sub Llenar_Utilidad()

    Me.DataGridViewUti.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Código"
    DataGridViewTextBoxColumn1.Width = 70
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CedulaEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Cédula"
    DataGridViewTextBoxColumn1.Width = 75
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Empleado"
    DataGridViewTextBoxColumn1.Width = 190
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "DiasBeneficio"
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Dias"
    DataGridViewTextBoxColumn1.HeaderText = "Días Trabajados"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NumeroCargas"
    DataGridViewTextBoxColumn1.HeaderText = "Cargas"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Utilidad"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorCargas"
    DataGridViewTextBoxColumn1.HeaderText = "Utilidad Cargas"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorBono"
    DataGridViewTextBoxColumn1.HeaderText = "Bono"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorBonoCargas"
    DataGridViewTextBoxColumn1.HeaderText = "Bono Cargas"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ValorBonoAlcance"
    DataGridViewTextBoxColumn1.HeaderText = "Bono Alcance"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Total"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})







    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_DecimoTercero"
    DataGridViewTextBoxColumn1.HeaderText = "D3"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_DecimoCuarto"
    DataGridViewTextBoxColumn1.HeaderText = "D4"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_UtilidadAnterior"
    DataGridViewTextBoxColumn1.HeaderText = "Utilidad"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Salarios"
    DataGridViewTextBoxColumn1.HeaderText = "Salarios"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FondoReserva"
    DataGridViewTextBoxColumn1.HeaderText = "Fondo Reserva"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Comisiones"
    DataGridViewTextBoxColumn1.HeaderText = "Comisiones"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_BeneficiosAdionales"
    DataGridViewTextBoxColumn1.HeaderText = "Beneficios Adicionales"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_AnticipoUtilidad"
    DataGridViewTextBoxColumn1.HeaderText = "Anticipo Utilidad"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_RetencionJudicial"
    DataGridViewTextBoxColumn1.HeaderText = "Retención Judicial"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_ImpuestoRetencion"
    DataGridViewTextBoxColumn1.HeaderText = "Impuesto Retención"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_SalarioDigno"
    DataGridViewTextBoxColumn1.HeaderText = "Salario Digno"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewUti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

  End Sub
#End Region

  Private Sub DataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewD3.DoubleClick, DataGridViewD4.DoubleClick, DataGridViewVaca.DoubleClick
    abrir_detalle()
  End Sub

  Sub abrir_detalle()
    Dim bs As BindingSource = Nothing
    If tbtipobenacum.SelectedTab Is tbd3g Then
      bs = bsD3
    ElseIf tbtipobenacum.SelectedTab Is tbd4g Then
      bs = bsD4
    ElseIf tbtipobenacum.SelectedTab Is tbvacg Then
      bs = bsVacacion
    ElseIf tbtipobenacum.SelectedTab Is tbutig Then
      bs = bsUtilidad
    End If

    If bs.Current Is Nothing Then
      Exit Sub
    End If

    Dim _desde As Date = dtFechadesde.Value.Date
    Dim _hasta As Date = dtFechahasta.Value.Date
    _desde = _desde.AddDays(-_desde.Day + 1)
    _hasta = _hasta.AddDays(31)
    _hasta = _hasta.AddDays(-_hasta.Day)

    Dim f As New FrmMantenimientoBeneficio(Sistema, Enumerados.EnumOpciones.BeneficiosSociales)
    If Me.rdobennopag.Checked Then
      f.consulta = 1
    ElseIf Me.rdorangoper.Checked Then
      f.consulta = 2
      f.desde = _desde
      f.hasta = _hasta
    Else
      f.consulta = 3
      f.hasta = _hasta
    End If
    If tbtipobenacum.SelectedTab Is tbd4g Then
      f.Pardet_TipoBeneficioEnum = Enumerados.enumTipoBeneficio.DecimoCuarto
    End If
    f.BeneficioSocial = bs.Current

    f.ShowDialog()
    If tbtipobenacum.SelectedTab Is tbd3g Then
      DataGridViewD3.Invalidate()
    ElseIf tbtipobenacum.SelectedTab Is tbd4g Then
      DataGridViewD4.Invalidate()
    ElseIf tbtipobenacum.SelectedTab Is tbvacg Then
      DataGridViewVaca.Invalidate()
    ElseIf tbtipobenacum.SelectedTab Is tbutig Then
      DataGridViewUti.Invalidate()
    End If
  End Sub

#Region "tab vacacion"
  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(value As Contrato)
      bsperiodovacacion.Clear()
      mContrato = Value
      CtlPeriodoVacacion1.Contrato = Value
      Me.CtlPeriodoVacacion1.Enabled = Not Value Is Nothing
      periodovacacion()
    End Set
  End Property

#Region "CtlBuscaEmpleados2"
  Private Sub CtlBuscaEmpleados2_CambioEmpleado(ByVal sender As Object, ByVal e As EventArgs)
    Contrato = Me.CtlBuscaEmpleados2.Contrato
  End Sub
#End Region

  Private mperiodovacacionlist As RubroDetList = Nothing
  Sub periodovacacion()

    Me.DataGridViewVacaDetalle.Columns.Clear()
    Me.DataGridViewVacaDetalle.ReadOnly = True

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoRubroString"
    DataGridViewTextBoxColumn1.HeaderText = "Rubro"
    DataGridViewTextBoxColumn1.Width = 90
    Me.DataGridViewVacaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PerPag_FechaDesde"
    DataGridViewTextBoxColumn1.HeaderText = "Periodo"
    DataGridViewTextBoxColumn1.Width = 90
    Me.DataGridViewVacaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "RubDet_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewVacaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "diasvacacion"
    DataGridViewTextBoxColumn1.HeaderText = "Dias"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewVacaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "valorvacacion"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Vacacion"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewVacaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim _beneficio As BeneficiosSociales = CtlPeriodoVacacion1.BSperiodo.Current
    If _beneficio IsNot Nothing Then
      mperiodovacacionlist = RubroDetList.ObtenerListaPeriodoVacacion(_beneficio)
      For Each _rubrodet As RubroDet In mperiodovacacionlist
        _rubrodet.calculodiasvacacion(_beneficio.BenSoc_FechaDesde, _beneficio.BenSoc_FechaHasta)
        _rubrodet.calculovalorvacacion(_beneficio.BenSoc_FechaDesde, _beneficio.BenSoc_FechaHasta)
      Next

      bsperiodovacacion.DataSource = mperiodovacacionlist
    Else
      bsperiodovacacion.DataSource = Nothing
    End If
  End Sub

  Private Sub DataGridView6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlPeriodoVacacion1.ClickPeriodo
    If CtlPeriodoVacacion1.BSperiodo.Current Is Nothing Then
      Exit Sub
    End If
    periodovacacion()
  End Sub
#End Region

  Private Sub btnimprimirvacacion_Click(sender As System.Object, e As System.EventArgs) Handles btnimprimirvacacion.Click
    Dim _beneficio As BeneficiosSociales = CtlPeriodoVacacion1.BSperiodo.Current
    If _beneficio Is Nothing Then
      MsgBox("Debe seleccionar un periodo de vacaciones", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim mrubro As Rubro
    mrubro = Rubro.ObtenerSueldoxContrato(Contrato)

    Dim mvacacionlist = RubroDetList.ObtenerListaPeriodoValoresVacacionReporte(_beneficio)
    For Each _rubrodet As RubroDet In mvacacionlist
      _rubrodet.calculodiasvacacion(_beneficio.BenSoc_FechaDesde, _beneficio.BenSoc_FechaHasta)
      _rubrodet.calculovalorvacacion(_beneficio.BenSoc_FechaDesde, _beneficio.BenSoc_FechaHasta)
    Next

    ExcelReporte.Vacacion.Imprimir_vacacion(mContrato, mrubro, CtlPeriodoVacacion1.BSperiodo.Current, mvacacionlist, Sistema.UsuarioString)
  End Sub

  Private Sub btncalcularotros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcularotros.Click
    If CDec(TextBoxCalculator6.Text) <= 0 Then
      MsgBox("Ingresar valor", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    For Each _beneficio As BeneficiosSociales In bsOtrosPagos
      _beneficio.BenSoc_Valor = TextBoxCalculator6.Value
    Next
    'For Each _beneficio As BeneficiosSociales In bsUtilidad
    '  _beneficio.BenSoc_Valor = _razonuti * _beneficio.DiasBeneficio
    '  _beneficio.BenSoc_ValorCargas = _razonutibono * _beneficio.Contrato.Empleado.NumeroCargas * _beneficio.DiasBeneficio
    '  _beneficio.BenSoc_ValorBono = _razonutibono * _beneficio.DiasBeneficio
    '  _beneficio.BenSoc_ValorBonoCargas = _razonutibonocargas * _beneficio.Contrato.Empleado.NumeroCargas * _beneficio.DiasBeneficio
    'Next
    DataGridViewOtros.Invalidate()
  End Sub

  Sub Llenar_OtrosPagos()

    Me.DataGridViewOtros.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Código"
    DataGridViewTextBoxColumn1.Width = 70
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CedulaEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Cédula"
    DataGridViewTextBoxColumn1.Width = 75
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Empleado"
    DataGridViewTextBoxColumn1.Width = 190
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

  Private Sub BeneficioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeneficioToolStripMenuItem.Click
    If Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono Is Nothing Then
      Exit Sub
    End If
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.BeneficiosSociales)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Beneficios_Sociales")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono.Patron_Codigo}
    f.ShowDialog()
  End Sub

  Private Sub btnLiquidarVacaciones_Click(sender As System.Object, e As System.EventArgs) Handles btnLiquidarVacaciones.Click
    Dim _beneficio As BeneficiosSociales = CtlPeriodoVacacion1.BSperiodo.Current

    If _beneficio Is Nothing Then
      Exit Sub
    End If

    'Dim mvacacionlist As RubroDetList = RubroDetList.ObtenerListaPeriodoVacacion(_beneficio)
    Dim mvacacionlist As RubroDetList = RubroDetList.ObtenerListaPeriodoValoresVacacionReporte(_beneficio)
    For Each _rubrodet As RubroDet In mvacacionlist
      _rubrodet.calculodiasvacacion(_beneficio.BenSoc_FechaDesde, _beneficio.BenSoc_FechaHasta)
      _rubrodet.calculovalorvacacion(_beneficio.BenSoc_FechaDesde, _beneficio.BenSoc_FechaHasta)
    Next

    Dim valor As Decimal = 0

    For Each _rubrodet As RubroDet In mvacacionlist
      valor += Math.Round(_rubrodet.valorvacacion, 2)
    Next

    Dim f As New FrmMantenimientoBeneficioVacacion(Sistema, Enumerados.EnumOpciones.BeneficiosSociales)
    f.txtValorVacacion.Value = valor
    f.Vacacion = CtlPeriodoVacacion1.BSperiodo.Current
    f.checkgocevacaciones.Checked = True
    f.ShowDialog()
  End Sub

  Private Sub RecibosLiquidaciónVacacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecibosLiquidaciónVacacionesToolStripMenuItem.Click
    If Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono Is Nothing Then
      Exit Sub
    End If
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.BeneficiosSociales)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Recibo_Vacaciones")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono.Patron_Codigo}
    f.ShowDialog()
  End Sub

  Private Sub PersonalAdicionalParaUtilidadesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PersonalAdicionalParaUtilidadesToolStripMenuItem.Click
    If Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono Is Nothing Then
      Exit Sub
    End If
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.BeneficiosSociales)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Personal_adicional_Utilidades")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono.Patron_Codigo}
    f.ShowDialog()
  End Sub

  Private Sub FrmBeneficiosSociales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class