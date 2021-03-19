Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.Data.SqlClient

Public Class FrmNomina
  Implements IOpcion

#Region "CtlBuscaEmpleadosPeriodo1"
  Private Sub CtlBuscaEmpleadosPeriodo1_CambioEmpleado(ByVal sender As Object, ByVal e As EventArgs) Handles CtlBuscaEmpleadosPeriodo1.CambioEmpleado
    Contrato = Me.CtlBuscaEmpleadosPeriodo1.Contrato
  End Sub

  Private Sub CtlBuscaEmpleadosPeriodo1_Generar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleadosPeriodo1.Generar
    Dim contratos As ContratoList
    contratos = CType(sender, ContratoList)
    If contratos Is Nothing Then
      MsgBox("Seleccione al menos un empleado", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    For Each _contrato As Contrato In contratos
      Contrato = _contrato
      btngrabar_Click(sender, e)
    Next
  End Sub

  Private ReadOnly Property TipoPeriodoPago As Enumerados.enumTipoPeriodoPago
    Get
      Return IIf(Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena, Enumerados.enumTipoPeriodoPago.Quincena, Enumerados.enumTipoPeriodoPago.FindeMes)
    End Get
  End Property

  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(value As Contrato)
      mContrato = Value
      Me.Panel1.Enabled = Not CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esPagado
      llenar_datos()
    End Set
  End Property
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

  Private Sub FrmNomina_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Inicializar
    Me.Text = "Nómina"
    Me.CtlBuscaEmpleadosPeriodo1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleadosPeriodo1.Op = Sistema.OperadorDatos
  End Sub


  Private Sub FrmNomina_AplicarRestricciones(sender As Object, e As EventArgs) Handles MyBase.AplicarRestricciones
    HeaderStrip1.Enabled = Restriccion.Restri_VerConfidencial
  End Sub
#End Region

#Region "Funciones"
  Private Function CrearRubro(_rubrobuscado As Integer, Optional _esGravaIESS As Boolean = False) As Rubro
    For Each _rubro1 As Rubro In mRubros
      If _rubro1.Pardet_TipoRubro = _rubrobuscado Then
        Return _rubro1
      End If
    Next

    Dim _rubro As New Rubro(Sistema.OperadorDatos, True)
    _rubro.Entida_Codigo = Contrato.Entida_Codigo
    _rubro.Patron_Codigo = Contrato.Patron_Codigo
    _rubro.Contra_Secuencia = Contrato.Contra_Secuencia
    _rubro.Rubro_GravaIESS = _esGravaIESS
    _rubro.PardetTipoRubro = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoRubro, _rubrobuscado)
    _rubro.Guardar()
    mRubros.Add(_rubro)
    Return _rubro
  End Function

  Private Function BuscarRubroDet(_rubrodetbuscado As Integer) As RubroDet
    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.Pardet_TipoRubro = _rubrodetbuscado AndAlso _rubrodet.Pardet_TipoPeriodoPago = TipoPeriodoPago AndAlso Not _rubrodet.Existe = 2 Then
        Return _rubrodet
      End If
    Next
    Return Nothing
  End Function

  Private Function CrearRubroDet(_rubro As Rubro, _rubrodetbuscado As Integer) As RubroDet
    Dim _rubdet As RubroDet = BuscarRubroDet(_rubrodetbuscado)
    If _rubdet Is Nothing Then
      _rubdet = New RubroDet(Sistema.OperadorDatos, True)
      _rubdet.Entida_Codigo = Contrato.Entida_Codigo
      _rubdet.Patron_Codigo = Contrato.Patron_Codigo
      _rubdet.Contra_Secuencia = Contrato.Contra_Secuencia
      _rubdet.Rubro_Secuencia = _rubro.Rubro_Secuencia
      _rubdet.PerPag_FechaDesde = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
      _rubdet.Parame_PeriodoPago = Contrato.Tipocontrato.Parame_PeriodoPago
      _rubdet.Pardet_PeriodoPago = Contrato.Tipocontrato.Pardet_PeriodoPago
      _rubdet.Parame_TipoPeriodoPago = Enumerados.EnumParametros.TipoPeriodoPago
      _rubdet.Pardet_TipoPeriodoPago = TipoPeriodoPago
      _rubdet.Parame_TipoRubro = Enumerados.EnumParametros.TipoRubro
      _rubdet.Pardet_TipoRubro = _rubrodetbuscado
      _rubdet.Parame_Departamento = Contrato.Parame_Departamento
      _rubdet.Pardet_Departamento = Contrato.Pardet_Departamento
      _rubdet.Parame_Area = Contrato.Parame_Area
      _rubdet.Pardet_Area = Contrato.Pardet_Area
      _rubdet.Cargo_Secuencia = Contrato.Cargo_Secuencia
      _rubdet.Parame_SubCentroCosto = Contrato.Parame_SubCentroCosto
      _rubdet.Pardet_SubCentroCosto = Contrato.Pardet_SubCentroCosto
      mRubroDets.Add(_rubdet)
    End If
    Return _rubdet
  End Function

  Private Sub leyenda()
    lbl_descripcion.Text = String.Empty
    If CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esPagado Then
      lbl_descripcion.Text = "Periodo Cerrado."
    End If

    If Contrato IsNot Nothing And BSRubroDet IsNot Nothing Then
      Dim _existe As Boolean = False
      For Each _rubrodet As RubroDet In BSRubroDet
        If _rubrodet.RubDet_Secuencia = 0 Then
          _existe = True
          Exit For
        End If
      Next

      If _existe Then
        lbl_descripcion.Text = "Registro no guardado"
      End If
    End If
  End Sub

  Private Sub MostrarBalance()
    If Contrato Is Nothing OrElse BSRubroDet.DataSource Is Nothing Then
      Exit Sub
    End If

    Dim _suma As Decimal = 0
    Dim _resta As Decimal = 0

    For Each _rubrodet As RubroDet In BSRubroDet
      If _rubrodet.RubDet_CalculadoenQ OrElse (Not _rubrodet.PardetTipoRubro.Pardet_Padre = Enumerados.enumRubro.ComplementosAsientosContables AndAlso (Not _rubrodet.RubDet_PagarEnFDM AndAlso Not (TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena AndAlso _rubrodet.RubDet_PagarEnFDM))) Then
        If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo Then
          _suma += Math.Round(_rubrodet.RubDet_Valor, 2)
        ElseIf _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = 1 OrElse _rubrodet.RubDet_CalculadoenQ Then
          _suma += Math.Round(_rubrodet.Valor, 2)
        ElseIf _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = -1 Then
          _resta += Math.Round(_rubrodet.RubDet_Valor, 2)
        End If
      End If
    Next

    txtIngresos.Text = _suma.ToString("0.00")
    txtEgresos.Text = _resta.ToString("0.00")
    txtTotal.Text = (_suma - _resta).ToString("0.00")

    If (_suma - _resta) < 0 Then
      lbl_descripcion.Text = "Resultado Negativo"
      'If Contrato.Contra_MensualizarD3 OrElse Contrato.Contra_MensualizarD4 OrElse Contrato.Contra_MensualizarVac Then
      '  lbl_descripcion.Text += ". Guarde los registros para calcular los beneficios mensualizados"
      'End If
      lbl_descripcion.BackColor = Color.Coral
    End If
  End Sub

  Private Sub PagarLiquidacion_CheckedChanged(sender As Object, e As System.EventArgs) Handles PagarLiquidacion.CheckedChanged
    If PagarLiquidacion.Checked Then
      PagarLiquidacion.Text = "Pagar en Liquidación"
      PagarLiquidacion.ForeColor = Color.Red
    Else
      PagarLiquidacion.Text = "Pagar en Nómina"
      PagarLiquidacion.ForeColor = Color.Black
    End If
  End Sub

  Private Sub lbl_descripcion_TextChanged(sender As Object, e As System.EventArgs) Handles lbl_descripcion.TextChanged
    Me.lbl_descripcion.Visible = Not String.IsNullOrWhiteSpace(lbl_descripcion.Text)
    Me.lbl_descripcion.BackColor = System.Drawing.SystemColors.Info
  End Sub

  Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    For Each _cell As DataGridViewCell In Me.DataGridView1.Rows(e.RowIndex).Cells
      If CType(Me.BSRubroDet.DataSource, RubroDetList)(e.RowIndex).PardetTipoRubro.Pardet_Padre = Enumerados.enumRubro.ComplementosAsientosContables Then
        _cell.Style.BackColor = Color.LightCyan
      ElseIf CType(Me.BSRubroDet.DataSource, RubroDetList)(e.RowIndex).PardetTipoRubro.Pardet_Padre = Enumerados.enumRubro.ComplementoNominaMensualizados Then
        _cell.Style.BackColor = Color.LightGoldenrodYellow
      ElseIf CType(Me.BSRubroDet.DataSource, RubroDetList)(e.RowIndex).PardetTipoRubro.Pardet_Padre = Enumerados.enumRubro.Liquidacion Then
        _cell.Style.BackColor = Color.LightSteelBlue
      ElseIf CType(Me.BSRubroDet.DataSource, RubroDetList)(e.RowIndex).Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena Then
        _cell.Style.BackColor = Color.LightSkyBlue
      End If
    Next
  End Sub

  Private Function ObtenerAportablePersonalIESS() As Decimal
    Dim _asidets As AsistenciaDetList = AsistenciaDetList.ObtenerLista(Sistema.OperadorDatos, mContrato, CtlBuscaEmpleadosPeriodo1.Periodo)
    Dim _rubrodetSueldo As RubroDet = CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroDefinidoContrato.Sueldo), Enumerados.enumTipoRubroDefinidoContrato.Sueldo)

    Dim valores As Decimal = 0
    Dim _submater As Boolean = False
    For Each _asidet As AsistenciaDet In _asidets
      If _asidet.Pardet_Licencia = Enumerados.enumLicencia.Maternidad Then 'And _asidet.AsiDet_LicenciaDias > 3) 
        _submater = True
      End If
    Next
    For Each _rubrodetalle As RubroDet In mRubroDets
      If Not _submater Then
        If _rubrodetalle.Rubro.GravaIESS And _rubrodetSueldo.RubDet_GoceVacaciones Then
          valores += _rubrodetalle.RubDet_Valor
        End If
      Else
        Select Case _rubrodetalle.Pardet_TipoRubro
          Case Enumerados.enumTipoRubroDefinidoContrato.Sueldo,
            Enumerados.enumTipoRubroComplementosNomina.Horas25, Enumerados.enumTipoRubroComplementosNomina.Horas50,
            Enumerados.enumTipoRubroComplementosNomina.Horas100, Enumerados.enumTipoRubroComplementosNomina.Horas100b,
            Enumerados.enumTipoRubroComplementosNomina.SubEnfermedad, Enumerados.enumTipoRubroComplementosNomina.SubMaternidad
            valores += _rubrodetalle.RubDet_Valor
        End Select
      End If
    Next
    Return valores
  End Function

  Private Function ObtenerValorAnticipo() As Decimal
    Dim valores As Decimal = 0
    For Each _rubrodetalle As RubroDet In mRubroDets
      If _rubrodetalle.Pardet_TipoRubro = Enumerados.enumTipoRubroNoDefinidoContrato.Anticipos Then
        valores += _rubrodetalle.Valor
      End If
    Next
    Return valores
  End Function

  Sub CalcularAportePersonalIESS(valores As Decimal)
    For Each _rubrodetalle As RubroDet In mRubroDets
      If _rubrodetalle.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS Then
        _rubrodetalle.RubDet_Valor = Math.Round(valores * (mConfigroles.Cnfrol_porciesspersonal / 100), 2)
        DataGridView1.Invalidate()
        Exit For
      End If
    Next
  End Sub

  Sub CalcularFondoReserva(valores As Decimal)
    If (DateDiff(DateInterval.Month, Contrato.Contra_Desde, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde)) + 1 >= 13 _
        And Contrato.Contra_MensualizarFondoReserva Then
      For Each _rubrodetalle As RubroDet In mRubroDets
        If _rubrodetalle.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNominaMensualizados.FondoReserva Then
          _rubrodetalle.RubDet_Valor = Math.Round(valores * (0.0833), 2)
          DataGridView1.Invalidate()
          Exit For
        End If
      Next
      'Exit For
    End If
    'End If
    'Next
  End Sub
#End Region

#Region "Nuevo, Abrir, Eliminar"
  Private Sub btnnuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevo.Click
    Dim _parametro As New WWTSParametroDet(Contrato.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.AdicionalesNomina)
    Dim _rubro As Rubro = New Rubro(Contrato.OperadorDatos, True)
    _rubro.Contrato = Contrato

    Dim f As New FrmRubroAdicionalNomina(Sistema, Enumerados.EnumOpciones.Personal)
    f.Parametro = _parametro
    f.Rubro = _rubro
    f.PeriodoPago = CtlBuscaEmpleadosPeriodo1.Periodo
    f.EsQuincena = (TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena)
    f.ShowDialog()

    If f.RubroDet IsNot Nothing Then
      mRubroDets.Add(f.RubroDet)
      DataGridView1.Invalidate()
      MostrarBalance()
    End If
  End Sub

  Private Sub btnabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrir.Click, DataGridView1.DoubleClick
    If BSRubroDet.Current Is Nothing OrElse Not Restriccion.Restri_VerConfidencial Then
      Exit Sub
    End If

    If Not (CType(BSRubroDet.Current, RubroDet).Pardet_TipoPeriodoPago = TipoPeriodoPago AndAlso CType(BSRubroDet.Current, RubroDet).Grabado) Then
      Dim f As New FrmRubroDet(Sistema, Restriccion) With {
        .RubroDet = BSRubroDet.Current,
        .GuardarEnMemoria = True
      }
      f.RestriccionesQuincena()
      f.ShowDialog()
      DataGridView1.Invalidate()
      f.Dispose()
      CType(BSRubroDet.Current, RubroDet).RubDet_Valor2 = CType(BSRubroDet.Current, RubroDet).RubDet_Valor
      CType(BSRubroDet.Current, RubroDet).RubDet_Cantidad2 = CType(BSRubroDet.Current, RubroDet).RubDet_Cantidad

      Dim valores As Decimal = ObtenerAportablePersonalIESS()
      If Not BSRubroDet.Current.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS Then
        CalcularAportePersonalIESS(valores)
      End If
      If Not BSRubroDet.Current.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNominaMensualizados.FondoReserva Then
        CalcularFondoReserva(valores)
      End If
      CalcularNominaAPagar()
      MostrarBalance()
    End If
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If Contrato IsNot Nothing And BSRubroDet IsNot Nothing Then
      If MsgBox("¿Está seguro que desea borrar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
        Exit Sub
      End If

      Try
        RubroDetList.EliminarxTipoPeriodoPago(Contrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo, TipoPeriodoPago)
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Eliminacion, String.Format("Eliminó Nómina: {0} {1} {2}", Contrato.EmpleadoString, Me.CtlBuscaEmpleadosPeriodo1.Periodo.Descripcion, TipoPeriodoPago.ToString))
      Catch ex As Exception
        MsgBox("No se pudo eliminar nómina" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      End Try

      BSRubroDet.DataSource = Nothing
      txtIngresos.Text = "0,00"
      txtEgresos.Text = "0,00"
      txtTotal.Text = "0,00"
      Me.Panel1.Enabled = False
    End If
  End Sub

  Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
    If Contrato IsNot Nothing And BSRubroDet IsNot Nothing Then

      Sistema.OperadorDatos.ComenzarTransaccion()
      Try
        For Each _rubrodet As RubroDet In BSRubroDet
          'Select Case _rubrodet.Pardet_TipoRubro
          'Case Enumerados.enumTipoRubroComplementosNominaMensualizados.D3Mensualizado, Enumerados.enumTipoRubroComplementosNominaMensualizados.D4Mensualizado, Enumerados.enumTipoRubroComplementosNominaMensualizados.VacacionesMensualizado
          '  '_rubrodet.Eliminar()
          'Case Else
          'If Contrato.Contra_MensualizarD3 Then
          '  _rubrodet.RubDet_PagadoD3 = Nothing
          'End If
          'If Contrato.Contra_MensualizarD4 Then
          '  _rubrodet.RubDet_PagadoD4 = Nothing
          'End If
          'If Contrato.Contra_MensualizarVac Then
          '  _rubrodet.RubDet_PagadoVac = Nothing
          'End If
          If _rubrodet.RubDet_Secuencia = 0 Then
            _rubrodet.EsNuevo = True
            _rubrodet.PerPag_FechaDesde = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
            _rubrodet.RubDet_Nota = _rubrodet.RubDet_Nota + " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
          End If

          If _rubrodet.Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes And _rubrodet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo Then
            _rubrodet.RubDet_ValorFinal = CDec(txtTotal.Text)
          End If
          If PagarLiquidacion.Checked Then
            _rubrodet.RubDet_PagarenLiq = True
          Else
            _rubrodet.RubDet_PagarenLiq = False
          End If

          _rubrodet.RubDet_AcumularFondoReserva = Not Contrato.Contra_MensualizarFondoReserva

          _rubrodet.Parame_Departamento = Contrato.Parame_Departamento
          _rubrodet.Pardet_Departamento = Contrato.Pardet_Departamento
          _rubrodet.Parame_Area = Contrato.Parame_Area
          _rubrodet.Pardet_Area = Contrato.Pardet_Area
          _rubrodet.Cargo_Secuencia = Contrato.Cargo_Secuencia
          _rubrodet.Parame_SubCentroCosto = Contrato.Parame_SubCentroCosto
          _rubrodet.Pardet_SubCentroCosto = Contrato.Pardet_SubCentroCosto

          If Contrato.Contra_MensualizarD3 Then
            _rubrodet.RubDet_PagadoD3 = Now
          End If
          If Contrato.Contra_MensualizarD4 Then
            _rubrodet.RubDet_PagadoD4 = Now
          End If
          If Contrato.Contra_MensualizarVac Then
            _rubrodet.RubDet_PagadoVac = Now
          End If

          If Not _rubrodet.Guardar() Then
            Throw New Exception(_rubrodet.OperadorDatos.MsgError)
          End If

          'grabar gastos personales
          'If mgastospersonalespresupuestado IsNot Nothing Then
          '  If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo Then
          '    mgastospersonalespresupuestado.Gastos_Sueldo = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.SubMaternidad Then
          '    mgastospersonalespresupuestado.Gastos_SubMaternidad = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.SubEnfermedad Then
          '    mgastospersonalespresupuestado.Gastos_SubEnfermedad = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas25 Then
          'mirp.Gastos_Horas25 = Math.Round(_rubrodet.RubDet_Valor, 2)
          '          ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas50 Then
          'mirp.Gastos_Horas50 = Math.Round(_rubrodet.RubDet_Valor, 2)
          '          ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas100 Then
          'mirp.Gastos_Horas100 = Math.Round(_rubrodet.RubDet_Valor, 2)
          '          ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas100b Then
          'mirp.Gastos_Horas100b = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion Then
          '    mgastospersonalespresupuestado.Gastos_Vacaciones = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.BonoMeta Then
          '    mgastospersonalespresupuestado.Gastos_BonoMeta = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Vivienda Then
          '    mgastospersonalespresupuestado.Gastos_IngresoVivienda = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroAdicionalesNomina.SueldoSinAp Then
          '    mgastospersonalespresupuestado.Gastos_SueldoSinAp = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroAdicionalesNomina.SobretiempoSinAp Then
          '    mgastospersonalespresupuestado.Gastos_SobretiempoSinAp = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Alimentacion Then
          '    mgastospersonalespresupuestado.Gastos_IngresoAlimentacion += Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Transporte Then
          '    mgastospersonalespresupuestado.Gastos_Transporte = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS Then
          '    mgastospersonalespresupuestado.Gastos_Aporte = Math.Round(_rubrodet.RubDet_Valor, 2)
          '  End If
          'End If

          'End Select
        Next

        If mgastospersonalespresupuestado IsNot Nothing Then
          If Not mgastospersonalespresupuestado.Guardar() Then
            Throw New Exception(mgastospersonalespresupuestado.OperadorDatos.MsgError)
          End If
        End If

        Sistema.OperadorDatos.TerminarTransaccion()

        For Each _rubrodet As RubroDet In BSRubroDet
          _rubrodet.Rubro.AceptarCambios()
          _rubrodet.AceptarCambios()
        Next

        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Modificacion, String.Format("Generó Nómina: {0}", Contrato.EmpleadoString))

        llenar_datos()
        MostrarBalance()
        lbl_descripcion.Text = String.Empty
      Catch ex As Exception
        Sistema.OperadorDatos.CancelarTransaccion()
        MsgBox("No se pudo guardar nómina" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End If
    'buscar_rubrodet()
    'calcular()
  End Sub
#End Region

  Private mgastospersonalespresupuestado As GastosPersonales = Nothing

  Private mRubros As RubroList
  Private mRubroDets As RubroDetList
  Dim mConfigroles As ConfigRoles

  Private Sub FormatearGrid()
    Me.DataGridView1.Columns.Clear()

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"

    Dim estilonum0 As New DataGridViewCellStyle()
    estilonum0.Format = "N0"

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Grabado"
    DataGridViewTextBoxColumn1.HeaderText = "Grabado"
    DataGridViewTextBoxColumn1.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "TipoRubroString"
    DataGridViewTextBoxColumn2.HeaderText = "Tipo Rubro"
    DataGridViewTextBoxColumn2.Width = 155
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "enFDM"
    DataGridViewTextBoxColumn1.HeaderText = "FDM"
    DataGridViewTextBoxColumn1.Width = 40
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Valor"
    DataGridViewTextBoxColumn2.HeaderText = "Valor"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "RubDet_Cantidad"
    DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
    DataGridViewTextBoxColumn2.HeaderText = "Fecha"
    DataGridViewTextBoxColumn2.Width = 80
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Observacion"
    DataGridViewTextBoxColumn2.HeaderText = "Observación"
    DataGridViewTextBoxColumn2.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Saldo"
    DataGridViewTextBoxColumn2.HeaderText = "Saldo"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Nota"
    DataGridViewTextBoxColumn2.HeaderText = "Nota"
    DataGridViewTextBoxColumn2.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "SubCentroCostoString"
    DataGridViewTextBoxColumn2.HeaderText = "SubCentroCosto"
    DataGridViewTextBoxColumn2.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "RubDet_Valor2"
    DataGridViewTextBoxColumn2.HeaderText = "Valor beneficios"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "RubDet_Cantidad2"
    DataGridViewTextBoxColumn2.HeaderText = "Cantidad beneficios"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})
  End Sub

  Private Sub llenar_datos()
    If Contrato Is Nothing Then
      Me.BSRubroDet.DataSource = Nothing
      Exit Sub
    End If
    FormatearGrid()

    mRubros = RubroList.ObtenerListaxContrato(Sistema.OperadorDatos, mContrato)
    If TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena Then
      mRubroDets = RubroDetList.ObtenerListaQuincena(Sistema.OperadorDatos, Contrato, CtlBuscaEmpleadosPeriodo1.Periodo)
    Else
      mRubroDets = RubroDetList.ObtenerListaFinMes(Sistema.OperadorDatos, Contrato, CtlBuscaEmpleadosPeriodo1.Periodo)
    End If

    Dim _existeprestamograbado As Boolean = False
    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.Grabado AndAlso _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroNoDefinidoContrato.PrestamoPersonal Then
        _existeprestamograbado = True
      End If
    Next

    Dim _contprestamos As Integer = 0
    Dim i As Integer = 0
    While i < mRubroDets.Count
      If mRubroDets(i).Pardet_TipoRubro = Enumerados.enumTipoRubroNoDefinidoContrato.PrestamoPersonal Then
        If _existeprestamograbado Then
          If Not mRubroDets(i).Grabado Then
            mRubroDets.RemoveAt(i)
          Else
            i += 1
          End If
        Else
          _contprestamos += 1
          If _contprestamos > 1 Then
            mRubroDets.RemoveAt(i)
          Else
            i += 1
          End If
        End If
      Else
        i += 1
      End If
    End While

    mConfigroles = New ConfigRoles(Sistema.OperadorDatos, Contrato.Patrono.Pais, False)

    Dim _existeh25 As Boolean = False

    PagarLiquidacion.Checked = False
    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.RubDet_PagarenLiq Then
        Me.PagarLiquidacion.Checked = True
      End If

      If _rubrodet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas25 Then
        _existeh25 = True
      End If
    Next

    Dim _sueldo As Rubro = Rubro.ObtenerSueldoxContrato(Contrato)
    If Not _existeh25 Then
      Dim _asiste As Asistencia = New Asistencia(Sistema.OperadorDatos, Contrato, CtlBuscaEmpleadosPeriodo1.Periodo)

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.Horas25, True), Enumerados.enumTipoRubroComplementosNomina.Horas25)
        .RubDet_Valor = Math.Round(_asiste.Asiste_H25 * ((_sueldo.Total) / 30 / 8) * mConfigroles.Cnfrol_factorHora25, 2)
        .RubDet_Cantidad = _asiste.Asiste_H25
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.Horas50, True), Enumerados.enumTipoRubroComplementosNomina.Horas50)
        .RubDet_Valor = Math.Round(_asiste.Asiste_H50 * ((_sueldo.Total) / 30 / 8) * mConfigroles.Cnfrol_factorHora50, 2)
        .RubDet_Cantidad = _asiste.Asiste_H50
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.Horas100, True), Enumerados.enumTipoRubroComplementosNomina.Horas100)
        .RubDet_Valor = Math.Round(_asiste.Asiste_H100 * ((_sueldo.Total) / 30 / 8) * mConfigroles.Cnfrol_factorHora100, 2)
        .RubDet_Cantidad = _asiste.Asiste_H100
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.Horas100b, True), Enumerados.enumTipoRubroComplementosNomina.Horas100b)
        .RubDet_Valor = Math.Round(_asiste.Asiste_H100b * ((_sueldo.Total) / 30 / 8) * mConfigroles.Cnfrol_factorHora100, 2)
        .RubDet_Cantidad = _asiste.Asiste_H100b
      End With

      'Dim diasfalta As Integer = _asiste.Asiste_Faltas
      'If diasfalta > 1 Then
      '  With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroNoDefinidoContrato.FaltasInjustificadas), Enumerados.enumTipoRubroNoDefinidoContrato.FaltasInjustificadas)
      '    .RubDet_Valor = Math.Round((_sueldo.Total / 30) * (diasfalta), 2)
      '    .RubDet_Cantidad = diasfalta
      '  End With
      'End If
    End If

    Dim _asidets As AsistenciaDetList = AsistenciaDetList.ObtenerLista(Sistema.OperadorDatos, mContrato, CtlBuscaEmpleadosPeriodo1.Periodo)

    Dim mDiasTrabajados As Decimal = 0
    Dim mDiasBeneficios As Decimal = 0
    If Not _existeh25 Then
      Dim dias As Integer = 0
      Try
        Dim _asis As Asistencia = New Asistencia(Sistema.OperadorDatos, Contrato, CtlBuscaEmpleadosPeriodo1.Periodo)
        dias = _asis.Asiste_Faltas
      Catch
        dias = 0
      End Try

      Dim _totaldias As Integer = 15
      Dim _rubdetSueldo As RubroDet = BuscarRubroDet(Enumerados.enumTipoRubroDefinidoContrato.Sueldo)
      If _rubdetSueldo IsNot Nothing Then
        mDiasTrabajados = _rubdetSueldo.RubDet_Cantidad
        mDiasBeneficios = _rubdetSueldo.RubDet_Cantidad

        For Each _asidet As AsistenciaDet In _asidets
          If _asidet.Pardet_Licencia = Enumerados.enumLicencia.Enfermedad Then 'And _asidet.AsiDet_LicenciaDias > 3
            mDiasTrabajados -= _asidet.AsiDet_LicenciaDias

            Dim _valor As Decimal = Math.Round(((_sueldo.Total * (mConfigroles.Cnfrol_porcpagsubmatenf) / 100) / 30) * _asidet.AsiDet_LicenciaDias, 2)
            If _valor > 0 Then
              With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.SubEnfermedad, True), Enumerados.enumTipoRubroComplementosNomina.SubEnfermedad)
                .RubDet_Valor = _valor
                .RubDet_Cantidad = _asidet.AsiDet_LicenciaDias
              End With
            End If
          ElseIf _asidet.Pardet_Licencia = Enumerados.enumLicencia.Maternidad Then 'And _asidet.AsiDet_LicenciaDias > 3 
            mDiasTrabajados -= _asidet.AsiDet_LicenciaDias

            Dim _valor As Decimal = Math.Round(((_sueldo.Total * (mConfigroles.Cnfrol_porcpagsubmatenf) / 100) / 30) * _asidet.AsiDet_LicenciaDias, 2)
            If _valor > 0 Then
              With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.SubMaternidad, True), Enumerados.enumTipoRubroComplementosNomina.SubMaternidad)
                .RubDet_Valor = _valor
                .RubDet_Cantidad = _asidet.AsiDet_LicenciaDias
              End With
            End If
          ElseIf _asidet.Pardet_Licencia = Enumerados.enumLicencia.SinSueldo Then
            mDiasTrabajados -= _asidet.AsiDet_LicenciaDias
            mDiasBeneficios -= _asidet.AsiDet_LicenciaDias
          ElseIf _asidet.Pardet_Licencia = Enumerados.enumLicencia.Vacaciones Then ' AndAlso _asidet.AsiDet_LicenciaDias = 15 Then
            'mDiasTrabajados -= _asidet.AsiDet_LicenciaDias
            Dim _valor As Decimal = Math.Round((_sueldo.Total / 30) * _asidet.AsiDet_LicenciaDias, 2)
            With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.Vacacion, True), Enumerados.enumTipoRubroComplementosNomina.Vacacion)
              .RubDet_Valor = 0 '_valor
              .RubDet_Cantidad = 0 '_asidet.AsiDet_LicenciaDias
              .RubDet_Valor2 = _valor
              .RubDet_Cantidad2 = _asidet.AsiDet_LicenciaDias
            End With
          End If
        Next
        '_rubrodet.RubDet_Cantidad -= dias
        If _rubdetSueldo.RubDet_Secuencia = 0 Then
          _rubdetSueldo.RubDet_Cantidad2 = mDiasBeneficios
          _rubdetSueldo.RubDet_Cantidad = mDiasTrabajados

          _rubdetSueldo.RubDet_Valor2 = Math.Round((_rubdetSueldo.RubDet_Valor / _totaldias) * mDiasBeneficios, 2)
          _rubdetSueldo.RubDet_Valor = Math.Round((_rubdetSueldo.RubDet_Valor / _totaldias) * mDiasTrabajados, 2)
        End If

        Dim _rubdetTransporte As RubroDet = BuscarRubroDet(Enumerados.enumTipoRubroDefinidoContrato.Transporte)
        If _rubdetTransporte IsNot Nothing Then
          _rubdetTransporte.RubDet_Valor = Math.Round((_rubdetTransporte.RubDet_Valor / _totaldias) * mDiasTrabajados, 2)
        End If
      End If
    End If

    Dim _rubrodetSueldo As RubroDet = CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroDefinidoContrato.Sueldo), Enumerados.enumTipoRubroDefinidoContrato.Sueldo)

    If _rubrodetSueldo IsNot Nothing AndAlso _rubrodetSueldo.EsNuevo Then
      Dim valoresAportables As Decimal = ObtenerAportablePersonalIESS()

      Dim _contratos As ContratoList = ContratoList.ObtenerLista(Sistema.OperadorDatos, Contrato.Empleado)
      Dim _diascontratos As Integer = 0
      For Each _contrato As Contrato In _contratos
        Dim _desde As Date = _contrato.Contra_Desde
        Dim _hasta As Date = IIf(Not _contrato.esCerrado OrElse _contrato.Contra_Hasta >= Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, _contrato.Contra_Hasta)

        _diascontratos += DateDiff(DateInterval.Day, _desde, _hasta) + 1
      Next

      Dim _diasfr As Decimal = _diascontratos + mDiasTrabajados - 360
      _diasfr = IIf(_diasfr > mDiasTrabajados, mDiasTrabajados, _diasfr)
      If _diasfr > 0 Then
        Dim _frrubro As Integer = Enumerados.enumTipoRubroComplementosNominaMensualizados.FondoReserva
        If Not Contrato.Contra_MensualizarFondoReserva Then
          _frrubro = Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaD
        End If

        Dim mFDM As Boolean = IIf(_frrubro = Enumerados.enumTipoRubroComplementosNominaMensualizados.FondoReserva AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena, mConfigroles.Cnfrol_MensualizFM, False)
        Dim mObservacion As String = IIf(mFDM, String.Format("Calculado en el periodo {0}, pagadero en Fin de mes", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString), "")
        With CrearRubroDet(CrearRubro(_frrubro), _frrubro)
          .RubDet_Valor = Math.Round((valoresAportables / mDiasTrabajados * _diasfr) / 12, 2)
          .RubDet_Cantidad = _diasfr
          .RubDet_PagarEnFDM = mFDM
          .RubDet_Observacion = mObservacion
        End With

        'If Not (Contrato.Contra_MensualizarFondoReserva AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena AndAlso Not mConfigroles.Cnfrol_MensualizFM) OrElse (TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes And Not Contrato.Contra_MensualizarFondoReserva) Then
        If Contrato.Contra_MensualizarFondoReserva AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes Then
        ElseIf Contrato.Contra_MensualizarFondoReserva AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena AndAlso Not mConfigroles.Cnfrol_MensualizFM Then
        Else
          With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaH), Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaH)
            .RubDet_Valor = Math.Round((valoresAportables / mDiasTrabajados * _diasfr) / 12, 2)
            .RubDet_Cantidad = _diasfr
            .RubDet_PagarEnFDM = mFDM
            .RubDet_Observacion = mObservacion
          End With
        End If
        'If Contrato.Contra_MensualizarFondoReserva Then
        '  With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaPorPagar), Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaPorPagar)
        '    .RubDet_Valor = Math.Round((valoresAportables / mDiasTrabajados * _diasfr) / 12, 2)
        '    .RubDet_Cantidad = _diasfr
        '  End With
        '  With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaPagado), Enumerados.enumTipoRubroComplementosAsientoContable.FondoReservaPagado)
        '    .RubDet_Valor = Math.Round((valoresAportables / mDiasTrabajados * _diasfr) / 12, 2)
        '    .RubDet_Cantidad = _diasfr
        '  End With

        'End If
      End If

      '******************IESS*************************
      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS), Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porciesspersonal / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porciesspersonal
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.AportePatronalD), Enumerados.enumTipoRubroComplementosAsientoContable.AportePatronalD)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porciesspatronal / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porciesspatronal
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.SECAPD), Enumerados.enumTipoRubroComplementosAsientoContable.SECAPD)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porcsecap / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porcsecap
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.IECED), Enumerados.enumTipoRubroComplementosAsientoContable.IECED)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porciece / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porciece
      End With



      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.AportePatronalH), Enumerados.enumTipoRubroComplementosAsientoContable.AportePatronalH)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porciesspatronal / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porciesspatronal
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.SECAPH), Enumerados.enumTipoRubroComplementosAsientoContable.SECAPH)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porcsecap / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porcsecap
      End With

      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.IECEH), Enumerados.enumTipoRubroComplementosAsientoContable.IECEH)
        .RubDet_Valor = Math.Round(valoresAportables * mConfigroles.Cnfrol_porciece / 100, 2)
        .RubDet_Valor2 = mConfigroles.Cnfrol_porciece
      End With



      'Dim valoresAnticipo As Decimal = ObtenerValorAnticipo()

      'With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.AnticipoPago), Enumerados.enumTipoRubroComplementosAsientoContable.AnticipoPago)
      '  .RubDet_Valor = valoresAnticipo
      'End With


      Dim valorSueldo As Decimal = 0
      Dim rubrodetsueldo As RubroDet = BuscarRubroDet(Enumerados.enumTipoRubroDefinidoContrato.Sueldo)
      If rubrodetsueldo IsNot Nothing Then
        valorSueldo = rubrodetsueldo.RubDet_Valor
      End If
      Dim _rubdet As RubroDet = BuscarRubroDet(Enumerados.enumTipoRubroDefinidoContrato.AporteIESSFamiliares)
      If _rubdet IsNot Nothing Then
        _rubdet.RubDet_Valor = valorSueldo * _rubdet.RubDet_Valor2 / 100
      End If

      CalcularBeneficiosMensualizados()

      CalcularNominaAPagar()
    End If


    '******************Gastos personales*************************
    For Each _mrubrodet As RubroDet In mRubroDets
      If _mrubrodet.RubDet_Secuencia = 0 And _mrubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo Then
        If Contrato IsNot Nothing AndAlso Contrato.Contra_afiliess AndAlso Contrato.Contra_DescontarImpuestoRenta Then
          'tabla  -- 1 presupuestado -- 2 real 

          Dim pardet2 As WWTSParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoGastoPersonal, 2)
          Dim GastosPersonalesReal As GastosPersonalesList = GastosPersonalesList.ObtenerLista(Contrato, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.Year, pardet2)

          Dim pardet1 As WWTSParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoGastoPersonal, 1)
          Dim GastosPersonalesPresupuestado As GastosPersonalesList = GastosPersonalesList.ObtenerLista(Contrato, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.Year, pardet1)

          Dim ingresos As Decimal = 0
          Dim gastos As Decimal = 0
          'REAL sino presupuestado sino el default
          If GastosPersonalesReal.Count = 0 Then
            If GastosPersonalesPresupuestado.Count = 0 Then

              Dim fraccionbasica As Decimal = 0

              For Each _rubrodet As RubroDet In mRubroDets
                If _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = 1 AndAlso Not _rubrodet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNominaMensualizados.FondoReserva _
                    AndAlso Not _rubrodet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroNoDefinidoContrato.Devoluciones Then
                  fraccionbasica += _rubrodet.RubDet_Valor
                End If
              Next

              Dim ImpuestoRenta As ImpuestoRenta = ImpuestoRentaList.ObtenerListaDividido12(Me.Contrato.Patrono.Pais, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, fraccionbasica)

              If ImpuestoRenta IsNot Nothing Then
                Dim irm As Decimal = ((fraccionbasica - (ImpuestoRenta.ImpRen_SueldoDesde / 12)) * ImpuestoRenta.ImpRen_PorcFraccionExcedente / 100) + (ImpuestoRenta.ImpRen_FraccionBasica / 12)
                With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta), Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta)
                  .RubDet_Valor = Math.Round(irm, 2)
                End With
              End If
              'fin default

            Else
              'tabla  -- 1 presupuestado -- 2 real ... sacar datos del presupuestado y actualizo en el real
              'presupuestado
              ingresos = 0
              gastos = 0

              For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
                If mirp.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirp.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
                  mirp.Gastos_IngresoAlimentacion = 0
                  mirp.Gastos_Transporte = 0
                  For Each _rubrodet As RubroDet In mRubroDets
                    If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo Then
                      mirp.Gastos_Sueldo = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.SubMaternidad Then
                      mirp.Gastos_SubMaternidad = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.SubEnfermedad Then
                      mirp.Gastos_SubEnfermedad = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas25 Then
                      mirp.Gastos_Horas25 = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas50 Then
                      mirp.Gastos_Horas50 = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas100 Then
                      mirp.Gastos_Horas100 = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas100b Then
                      mirp.Gastos_Horas100b = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion And _rubrodet.RubDet_GoceVacaciones = True Then
                      mirp.Gastos_Vacaciones = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion And _rubrodet.RubDet_GoceVacaciones = False Then
                      mirp.Gastos_Vacaciones = 0
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.BonoMeta Then
                      mirp.Gastos_BonoMeta = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Vivienda Then
                      mirp.Gastos_IngresoVivienda = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroAdicionalesNomina.SueldoSinAp Then
                      mirp.Gastos_SueldoSinAp = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroAdicionalesNomina.SobretiempoSinAp Then
                      mirp.Gastos_SobretiempoSinAp = Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Alimentacion Then
                      mirp.Gastos_IngresoAlimentacion += Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Transporte Then
                      mirp.Gastos_Transporte += Math.Round(_rubrodet.RubDet_Valor, 2)
                    ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS Then
                      mirp.Gastos_Aporte = Math.Round(_rubrodet.RubDet_Valor, 2)
                    End If
                  Next
                End If
              Next

              For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
                'ver si hay real entonces no tomar presupuestado

                ingresos += mirp.SumaIngresos()
                gastos += mirp.SumaGastos()
              Next

              'mgastospersonalesreal = GastosPersonalesPresupuestado
              'For Each mir As GastosPersonales In mgastospersonalesreal
              '  mir.Pardet_TipodeGasto = 2
              '  mir.EsNuevo = True
              '  mir.Guardar()
              'Next

              For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
                If mirp.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirp.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
                  mgastospersonalespresupuestado = mirp
                  mgastospersonalespresupuestado.Pardet_TipodeGasto = 2
                  mgastospersonalespresupuestado.EsModificado = True
                  mgastospersonalespresupuestado.EsNuevo = False
                  Exit For
                End If
              Next

              Dim fraccionbasica As Decimal = ingresos - gastos

              Dim ImpuestoRenta As ImpuestoRenta = ImpuestoRentaList.ObtenerLista(Me.Contrato.Patrono.Pais, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, fraccionbasica)

              If ImpuestoRenta IsNot Nothing Then
                Dim irm As Decimal = ((fraccionbasica - (ImpuestoRenta.ImpRen_SueldoDesde)) * ImpuestoRenta.ImpRen_PorcFraccionExcedente / 100) + ImpuestoRenta.ImpRen_FraccionBasica
                With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta), Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta)
                  .RubDet_Valor = Math.Round((irm / 12), 2)
                End With

                For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
                  If mirp.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirp.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
                    For Each _rubrodet As RubroDet In mRubroDets
                      If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta Then
                        mirp.Gastos_ImpuestoRenta = Math.Round(_rubrodet.RubDet_Valor, 2)
                        Exit For
                      End If
                    Next
                    Exit For
                  End If
                Next

              End If
              'fin presupuestado

            End If
            'Presupuestado - real
          Else
            Dim band As Integer = 0
            'tabla  -- 1 presupuestado -- 2 real 
            'real

            'For Each mirr As GastosPersonales In GastosPersonalesReal
            '  If mirr.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirr.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
            '    If mirr.Gastos_Sueldo = 0 Then
            '      band = 1
            '      Exit For
            '    End If
            '  End If
            'Next

            ingresos = 0
            gastos = 0

            For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
              If mirp.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirp.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
                mirp.Gastos_IngresoAlimentacion = 0
                mirp.Gastos_Transporte = 0
                For Each _rubrodet As RubroDet In mRubroDets
                  If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo Then
                    mirp.Gastos_Sueldo = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.SubMaternidad Then
                    mirp.Gastos_SubMaternidad = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.SubEnfermedad Then
                    mirp.Gastos_SubEnfermedad = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas25 Then
                    mirp.Gastos_Horas25 = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas50 Then
                    mirp.Gastos_Horas50 = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas100 Then
                    mirp.Gastos_Horas100 = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Horas100b Then
                    mirp.Gastos_Horas100b = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion And _rubrodet.RubDet_GoceVacaciones = True Then
                    mirp.Gastos_Vacaciones = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion And _rubrodet.RubDet_GoceVacaciones = False Then
                    mirp.Gastos_Vacaciones = 0
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.BonoMeta Then
                    mirp.Gastos_BonoMeta = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Vivienda Then
                    mirp.Gastos_IngresoVivienda = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroAdicionalesNomina.SueldoSinAp Then
                    mirp.Gastos_SueldoSinAp = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroAdicionalesNomina.SobretiempoSinAp Then
                    mirp.Gastos_SobretiempoSinAp = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Alimentacion Then
                    mirp.Gastos_IngresoAlimentacion += Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Transporte Then
                    mirp.Gastos_Transporte = Math.Round(_rubrodet.RubDet_Valor, 2)
                  ElseIf _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.AportePersonalIESS Then
                    mirp.Gastos_Aporte = Math.Round(_rubrodet.RubDet_Valor, 2)
                  End If
                Next
              End If
            Next

            'If band = 1 Then
            For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
              'ver si hay real entonces no tomar presupuestado
              For Each mirr As GastosPersonales In GastosPersonalesReal
                If mirp.Gastos_mes = mirr.Gastos_mes Then
                  If mirr.Gastos_Sueldo <> 0 Or mirr.Gastos_SubEnfermedad <> 0 Or mirr.Gastos_SubMaternidad <> 0 Then
                    ingresos += mirr.SumaIngresos()
                    gastos += mirr.SumaGastos()
                  Else
                    ingresos += mirp.SumaIngresos()
                    gastos += mirp.SumaGastos()
                  End If
                End If
              Next
            Next

            'For Each mir As GastosPersonales In GastosPersonalesPresupuestado
            '  If mir.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mir.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
            '    mgastospersonalespresupuestado = mir
            '    mgastospersonalespresupuestado.Pardet_TipodeGasto = 2
            '    mgastospersonalespresupuestado.EsModificado = True
            '    mgastospersonalespresupuestado.EsNuevo = False
            '    Exit For
            '  End If
            'Next
            'Else
            'For Each mir As GastosPersonales In GastosPersonalesReal
            '  ingresos += mir.SumaIngresos()
            '  gastos += mir.SumaGastos()
            'Next

            For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
              If mirp.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirp.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
                mgastospersonalespresupuestado = mirp
                mgastospersonalespresupuestado.Pardet_TipodeGasto = 2
                mgastospersonalespresupuestado.EsModificado = True
                mgastospersonalespresupuestado.EsNuevo = False
                Exit For
              End If
            Next
            'End If

            Dim fraccionbasica As Decimal = ingresos - gastos

            Dim ImpuestoRenta As ImpuestoRenta = ImpuestoRentaList.ObtenerLista(Me.Contrato.Patrono.Pais, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta, fraccionbasica)

            If ImpuestoRenta IsNot Nothing Then
              Dim irm As Decimal = ((fraccionbasica - (ImpuestoRenta.ImpRen_SueldoDesde)) * ImpuestoRenta.ImpRen_PorcFraccionExcedente / 100) + ImpuestoRenta.ImpRen_FraccionBasica
              With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta), Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta)
                .RubDet_Valor = Math.Round((irm / 12), 2)
              End With

              For Each mirp As GastosPersonales In GastosPersonalesPresupuestado
                If mirp.Gastos_mes = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes And mirp.Gastos_anio = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio Then
                  For Each _rubrodet As RubroDet In mRubroDets
                    If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.ImpuestoRenta Then
                      mirp.Gastos_ImpuestoRenta = Math.Round(_rubrodet.RubDet_Valor, 2)
                      Exit For
                    End If
                  Next
                  Exit For
                End If
              Next
            End If
          End If
        End If
        Exit For
      End If
    Next

    BSRubroDet.DataSource = mRubroDets

    leyenda()
    MostrarBalance()
  End Sub

  Private Sub CalcularBeneficiosMensualizados()
    '******************Beneficios Sociales Mensualizados*************************
    Dim rubsxben As RubroxBeneficioList = Nothing
    Dim dias As Integer = 0
    Dim valores As Decimal = 0

    rubsxben = RubroxBeneficioList.ObtenerLista(Sistema.OperadorDatos, New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.DecimoTercero))
    dias = 0
    valores = 0
    For Each _rub As RubroxBeneficio In rubsxben
      If _rub.RubBen_Activo Then
        For Each _rubdet1 As RubroDet In mRubroDets
          If _rub.Pardet_TipoRubro = _rubdet1.Pardet_TipoRubro Then
            dias += IIf(_rubdet1.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo, _rubdet1.RubDet_Cantidad2, 0)
            valores += IIf(_rubdet1.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo, _rubdet1.RubDet_Valor2, _rubdet1.RubDet_Valor) * _rubdet1.PardetTipoRubro.Pardet_DatoDec1
          End If
        Next
      End If
    Next
    Dim _d3men As Integer = Enumerados.enumTipoRubroComplementosNominaMensualizados.D3Mensualizado
    If Not Contrato.Contra_MensualizarD3 Then
      _d3men = Enumerados.enumTipoRubroComplementosAsientoContable.D3D
    End If
    Dim mFDM As Boolean = IIf(_d3men = Enumerados.enumTipoRubroComplementosNominaMensualizados.D3Mensualizado AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena, mConfigroles.Cnfrol_MensualizFM, False)
    Dim mObservacion As String = IIf(mFDM, String.Format("Calculado en el periodo {0}, pagadero en Fin de mes", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString), "")

    With CrearRubroDet(CrearRubro(_d3men), _d3men)
      .RubDet_Valor = valores / 12
      .RubDet_Cantidad = dias
      .RubDet_Nota = " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
      .RubDet_PagarEnFDM = mFDM
      .RubDet_Observacion = mObservacion
    End With

    If Contrato.Contra_MensualizarD3 AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes Then
    ElseIf Contrato.Contra_MensualizarD3 AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena AndAlso Not mConfigroles.Cnfrol_MensualizFM Then
    Else
      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.D3H), Enumerados.enumTipoRubroComplementosAsientoContable.D3H)
        .RubDet_Valor = valores / 12
        .RubDet_Cantidad = dias
        .RubDet_Nota = " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
        .RubDet_PagarEnFDM = mFDM
        .RubDet_Observacion = mObservacion
      End With
    End If

    'If Not (_d3men = Enumerados.enumTipoRubroComplementosNominaMensualizados.D3Mensualizado AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena AndAlso Not mConfigroles.Cnfrol_MensualizFM) OrElse (TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes And Not Contrato.Contra_MensualizarD3) Then
    'End If



    rubsxben = RubroxBeneficioList.ObtenerLista(Sistema.OperadorDatos, New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.DecimoCuarto))
    dias = 0
    valores = 0
    For Each _rub As RubroxBeneficio In rubsxben
      If _rub.RubBen_Activo Then
        For Each _rubdet1 As RubroDet In mRubroDets
          If _rub.Pardet_TipoRubro = _rubdet1.Pardet_TipoRubro Then
            dias += IIf(_rubdet1.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo, _rubdet1.RubDet_Cantidad2, 0)
            valores += _rubdet1.RubDet_Valor
          End If
        Next
      End If
    Next
    Dim _smv As Decimal = mConfigroles.Cnfrol_salariomv
    Dim _d4men As Integer = Enumerados.enumTipoRubroComplementosNominaMensualizados.D4Mensualizado
    If Not Contrato.Contra_MensualizarD4 Then
      _d4men = Enumerados.enumTipoRubroComplementosAsientoContable.D4D
    End If
    mFDM = IIf(_d4men = Enumerados.enumTipoRubroComplementosNominaMensualizados.D4Mensualizado AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena, mConfigroles.Cnfrol_MensualizFM, False)
    mObservacion = IIf(mFDM, String.Format("Calculado en el periodo {0}, pagadero en Fin de mes", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString), "")

    With CrearRubroDet(CrearRubro(_d4men), _d4men)
      .RubDet_Valor = (_smv / 360) * dias
      .RubDet_Cantidad = dias
      .RubDet_Nota = " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
      .RubDet_PagarEnFDM = mFDM
      .RubDet_Observacion = mObservacion
    End With

    'If Not (_d4men = Enumerados.enumTipoRubroComplementosNominaMensualizados.D4Mensualizado AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena AndAlso Not mConfigroles.Cnfrol_MensualizFM) OrElse (TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes And Not Contrato.Contra_MensualizarD4) Then

    If Contrato.Contra_MensualizarD4 AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes Then
    ElseIf Contrato.Contra_MensualizarD4 AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena AndAlso Not mConfigroles.Cnfrol_MensualizFM Then
    Else
      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.D4H), Enumerados.enumTipoRubroComplementosAsientoContable.D4H)
        .RubDet_Valor = (_smv / 360) * dias
        .RubDet_Cantidad = dias
        .RubDet_Nota = " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
        .RubDet_PagarEnFDM = mFDM
        .RubDet_Observacion = mObservacion
      End With
    End If


    rubsxben = RubroxBeneficioList.ObtenerLista(Sistema.OperadorDatos, New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Vacaciones))
    dias = 0
    valores = 0
    For Each _rub As RubroxBeneficio In rubsxben
      If _rub.RubBen_Activo Then
        For Each _rubdet1 As RubroDet In mRubroDets
          If _rub.Pardet_TipoRubro = _rubdet1.Pardet_TipoRubro Then
            dias += IIf(_rubdet1.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo, _rubdet1.RubDet_Cantidad2, 0)
            valores += IIf(_rubdet1.Pardet_TipoRubro = Enumerados.enumTipoRubroDefinidoContrato.Sueldo, _rubdet1.RubDet_Valor2, _rubdet1.RubDet_Valor) * _rubdet1.PardetTipoRubro.Pardet_DatoDec1
          End If
        Next
      End If
    Next
    Dim _vacmen As Integer = Enumerados.enumTipoRubroComplementosNominaMensualizados.VacacionesMensualizado
    If Not Contrato.Contra_MensualizarVac Then
      _vacmen = Enumerados.enumTipoRubroComplementosAsientoContable.VacacionesD
    End If
    mFDM = IIf(_vacmen = Enumerados.enumTipoRubroComplementosNominaMensualizados.VacacionesMensualizado AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena, mConfigroles.Cnfrol_MensualizFM, False)
    mObservacion = IIf(mFDM, String.Format("Calculado en el periodo {0}, pagadero en Fin de mes", Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString), "")

    With CrearRubroDet(CrearRubro(_vacmen), _vacmen)
      .RubDet_Valor = valores / 24
      .RubDet_Cantidad = dias
      .RubDet_Nota = " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
      .RubDet_PagarEnFDM = mFDM
      .RubDet_Observacion = mObservacion
    End With

    'If Not (_vacmen = Enumerados.enumTipoRubroComplementosNominaMensualizados.VacacionesMensualizado AndAlso Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esQuincena AndAlso Not mConfigroles.Cnfrol_MensualizFM) OrElse (TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes And Not Contrato.Contra_MensualizarVac) Then
    If Contrato.Contra_MensualizarVac AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes Then
    ElseIf Contrato.Contra_MensualizarVac AndAlso TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena AndAlso Not mConfigroles.Cnfrol_MensualizFM Then
    Else
      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.VacacionesH), Enumerados.enumTipoRubroComplementosAsientoContable.VacacionesH)
        .RubDet_Valor = valores / 24
        .RubDet_Cantidad = dias
        .RubDet_Nota = " Generado en nómina, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
        .RubDet_PagarEnFDM = mFDM
        .RubDet_Observacion = mObservacion
      End With
    End If
  End Sub

#Region "Reportes"
  Private Sub mnuPagoEfectivoMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuPagoEfectivo.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Pago_efectivo")
    Dim _tipocontrato As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing Then
      _tipocontrato = Nothing
    Else
      _tipocontrato = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Codigo
    End If
    Dim _seccion As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing Then
      _seccion = Nothing
    Else
      _seccion = Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia
    End If

    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, _tipocontrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, _seccion}
    f.ShowDialog()
  End Sub

  Private Sub mnuPagoChequeMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuPagoCheque.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Pago_cheque")
    Dim _tipocontrato As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing Then
      _tipocontrato = Nothing
    Else
      _tipocontrato = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Codigo
    End If
    Dim _seccion As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing Then
      _seccion = Nothing
    Else
      _seccion = Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia
    End If

    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, _tipocontrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, _seccion}
    f.ShowDialog()
  End Sub

  Private Sub mnuPagoDeposito_Click(sender As System.Object, e As System.EventArgs) Handles mnuPagoDeposito.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Pago_deposito")
    Dim _tipocontrato As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing Then
      _tipocontrato = Nothing
    Else
      _tipocontrato = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Codigo
    End If
    Dim _seccion As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing Then
      _seccion = Nothing
    Else
      _seccion = Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia
    End If

    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, _tipocontrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, _seccion}
    f.ShowDialog()
  End Sub

  'Private Sub EncriptarBanco(sender As System.Object, e As System.EventArgs)
  '  Dim _entradatxt As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Salida.txt")
  '  Dim _salidacry As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Salida.cry")

  '  Try
  '    Dim obj As New clsEncriptacion()
  '    obj.Encrypt(_entradatxt, _salidacry)

  '    MsgBox("El archivo ha sido encriptado con el siguiente nombre " + _salidacry, MsgBoxStyle.Information, "Información")
  '  Catch ex As Exception
  '    MsgBox("Hubo un error al tratar de encriptar el archivo " + _entradatxt + ". " + ex.Message, MsgBoxStyle.Critical, "Error")
  '  End Try
  'End Sub
#End Region

  Public ReadOnly Property Control As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

  Private Sub NominaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NominaToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Sobres_de_pago")
    Dim _tipocontrato As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing Then
      _tipocontrato = Nothing
    Else
      _tipocontrato = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Codigo
    End If
    Dim _seccion As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing Then
      _seccion = Nothing
    Else
      _seccion = Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia
    End If

    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, _tipocontrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, _seccion}
    'f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, IIf(Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing, Nothing, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContrato), Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, IIf(Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing, Nothing, Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia)}
    'f.ObjDespuesExportarTexto = AddressOf EncriptarBanco
    f.ShowDialog()
  End Sub

  Private Sub mnuSobreMensual_Click(sender As System.Object, e As System.EventArgs) Handles mnuSobreMensual.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Sobres_de_pago_Final")
    Dim _tipocontrato As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing Then
      _tipocontrato = Nothing
    Else
      _tipocontrato = Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.TipCon_Codigo
    End If
    Dim _seccion As Integer
    If Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing Then
      _seccion = Nothing
    Else
      _seccion = Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia
    End If

    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, _tipocontrato, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_anio, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_mes, _seccion}
    'f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, IIf(Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing, Nothing, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContrato), Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, IIf(Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing, Nothing, Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia)}
    'f.ObjDespuesExportarTexto = AddressOf EncriptarBanco
    f.ShowDialog()
  End Sub

  Private Sub AsientoContableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsientoContableToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Asiento_Contable_Roles_B")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Periodo.Pardet_PeriodoPago, Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde}
    'f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleadosPeriodo1.Patrono.Patron_Codigo, IIf(Me.CtlBuscaEmpleadosPeriodo1.TipoContrato Is Nothing, Nothing, Me.CtlBuscaEmpleadosPeriodo1.TipoContrato.Pardet_TipoContrato), Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, IIf(Me.CtlBuscaEmpleadosPeriodo1.Seccion Is Nothing, Nothing, Me.CtlBuscaEmpleadosPeriodo1.Seccion.Pardet_Secuencia)}
    'f.ObjDespuesExportarTexto = AddressOf EncriptarBanco
    f.ShowDialog()
  End Sub

  Private Sub DataGridView1_UserDeletedRow(sender As Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
    If Not Me.CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esPagado AndAlso DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.Index >= 0 Then
      CType(Me.BSRubroDet.DataSource, RubroDetList)(DataGridView1.CurrentRow.Index).Eliminar()
    End If
  End Sub

  Private Sub CalcularNominaAPagar()
    Dim valoresNominaAPagar As Decimal = ObtenerValorNominaAPagar()

    With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosAsientoContable.NominaPorPagar), Enumerados.enumTipoRubroComplementosAsientoContable.NominaPorPagar)
      .RubDet_Valor = valoresNominaAPagar
    End With
  End Sub

  Private Function ObtenerValorNominaAPagar() As Decimal
    Dim valores As Decimal = 0
    For Each _rubrodetalle As RubroDet In mRubroDets
      If _rubrodetalle.RubDet_CalculadoenQ _
        OrElse _
          (Not _
           ( _
            _rubrodetalle.PardetTipoRubro.Pardet_Padre = Enumerados.enumRubro.ComplementosAsientosContables _
            OrElse _
            (_rubrodetalle.PardetTipoRubro.Pardet_Padre = Enumerados.enumRubro.ComplementoNominaMensualizados AndAlso _rubrodetalle.RubDet_PagarEnFDM) _
           ) _
          ) Then
        valores += _rubrodetalle.Valor
      End If
    Next
    Return valores
  End Function

  Private Sub btnNoMensualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnNoMensualizar.Click
    Contrato.Contra_MensualizarD3 = False
    Contrato.Contra_MensualizarD4 = False
    Contrato.Contra_MensualizarFondoReserva = False
    Contrato.Contra_MensualizarVac = False
    llenar_datos()
  End Sub

  Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
    DataGridView1.Excel(EnumSalida.Excel)
  End Sub

End Class
