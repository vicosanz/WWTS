Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Microsoft.Office.Interop

Public Class FrmLiquidacion
  Implements IOpcion

  Public ReadOnly Property Contrato As Contrato
    Get
      Return Me.CtlBuscaEmpleados1.Contrato
    End Get
  End Property

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
    Me.Text = "Liquidación"

    Me.CtlBuscaEmpleados1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados1.Op = Sistema.OperadorDatos

    Me.cbotipoliquidacion.OperadorDatos = Sistema.OperadorDatos
    Me.cbotipoliquidacion.Parametro = Enumerados.EnumParametros.TipoLiquidacion
    Me.cbotipoliquidacion.Llenar_Datos()

    Me.cbomotivosalida.OperadorDatos = Sistema.OperadorDatos
    Me.cbomotivosalida.Parametro = Enumerados.EnumParametros.TipoSalida
    Me.cbomotivosalida.Llenar_Datos()

    ' ''Me.ComboBoxFormaPago.OperadorDatos = Sistema.OperadorDatos
    ' ''Me.ComboBoxFormaPago.Parametro = Enumerados.EnumParametros.FormaPagoRol
    ' ''Me.ComboBoxFormaPago.Llenar_Datos()

    'Me.CtlCuentaBancaria1.llenar_datos()
  End Sub
#End Region

#Region "Controles"
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
#End Region

  Private valorquincena As Decimal = 0

  Private Sub btncalcular_Click(sender As System.Object, e As System.EventArgs) Handles btncalcular.Click
    Calcular()
  End Sub

  Private Sub Calcular()
    If Contrato Is Nothing Then
      Exit Sub
    End If
    Dim mObservacion As String = "Liquidación"

    mRubros = RubroList.ObtenerListaxContrato(Sistema.OperadorDatos, Contrato)
    mRubroDets = RubroDetList.ObtenerListaLiquidacion(Sistema.OperadorDatos, Contrato)

    Dim _suma As Decimal = 0
    Dim _resta As Decimal = 0
    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = 1 And _rubrodet.Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena Then
        _suma += _rubrodet.RubDet_Valor
      ElseIf _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = -1 And _rubrodet.Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena Then
        _resta += _rubrodet.RubDet_Valor
      End If
    Next

    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
        valorquincena = _rubrodet.RubDet_Valor
        _rubrodet.RubDet_Valor = (_suma - _resta)
      End If
    Next

    If Contrato.esCerrado Then
      For Each _rubrodet As RubroDet In mRubroDets
        If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
          valorquincena = _rubrodet.RubDet_Valor
          _rubrodet.RubDet_Valor = _rubrodet.RubDet_Valor2
        End If
      Next

      llenarRubros()
      Me.btncerrar.Enabled = False
      CambioSignoRubroQuincena()
      Exit Sub
    End If

    Dim mnomxpagar As RubroDet = BuscarRubroDet(Enumerados.enumTipoRubroComplementosAsientoContable.NominaPorPagar)
    If mnomxpagar IsNot Nothing Then
      With CrearRubroDet(CrearRubro(Enumerados.enumTipoRubroComplementosLiquidacion.UltimoSueldo), Enumerados.enumTipoRubroComplementosLiquidacion.UltimoSueldo)
        .RubDet_Valor = mnomxpagar.RubDet_Valor
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    Dim beneficio As BeneficioSocialCalculado

    beneficio = New BeneficioSocialCalculado(Sistema.OperadorDatos, Contrato, Enumerados.enumTipoBeneficio.DecimoTercero, Nothing, Nothing)

    Dim _d3men As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.D3
    With CrearRubroDet(CrearRubro(_d3men), _d3men)
      .RubDet_Valor = beneficio.ValorCalculado
      .RubDet_Cantidad = beneficio.DiasAcumulados
      .RubDet_Nota = mObservacion
      .RubDet_Fecha = Me.dtfechasalida.Value.Date
      .RubDet_PagarEnFDM = True
      .RubDet_Observacion = mObservacion
    End With

    beneficio = New BeneficioSocialCalculado(Sistema.OperadorDatos, Contrato, Enumerados.enumTipoBeneficio.DecimoCuarto, Nothing, Nothing)

    Dim _d4men As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.D4
    With CrearRubroDet(CrearRubro(_d4men), _d4men)
      .RubDet_Valor = beneficio.ValorCalculado
      .RubDet_Cantidad = beneficio.DiasAcumulados
      .RubDet_Nota = mObservacion
      .RubDet_Fecha = Me.dtfechasalida.Value.Date
      .RubDet_PagarEnFDM = True
      .RubDet_Observacion = mObservacion
    End With

    beneficio = New BeneficioSocialCalculado(Sistema.OperadorDatos, Contrato, Enumerados.enumTipoBeneficio.Vacaciones, Nothing, Nothing)

    Dim _vacmen As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.Vac
    With CrearRubroDet(CrearRubro(_vacmen), _vacmen)
      .RubDet_Valor = beneficio.ValorCalculado
      .RubDet_Cantidad = beneficio.DiasAcumulados
      .RubDet_Nota = mObservacion
      .RubDet_Fecha = Me.dtfechasalida.Value.Date
      .RubDet_PagarEnFDM = True
      .RubDet_Observacion = mObservacion
    End With

    '1 terminación de contrato
    '2 renuncia
    '3 despido
    '4 desahucio
    '5 abandono
    '6 visto bueno
    '7 fallecimiento

    Dim _art185 As Boolean = False
    Dim _art188 As Boolean = False
    Dim _art181 As Boolean = False
    Dim _art190 As Boolean = False
    'Dim _art154 As Boolean = False
    Dim _bonificacion As Boolean = False
    'Dim _otros_i_e As Boolean = False

    Select Case CType(Me.cbomotivosalida.ParametroDet.Pardet_Secuencia, Enumerados.enumMotivoSalida)
      Case Enumerados.enumMotivoSalida.TerminacionContrato
        _art185 = True
        _art181 = True
        _bonificacion = True
      Case Enumerados.enumMotivoSalida.Renuncia
        _art190 = True
        _bonificacion = True
        '_otros_i_e = True
      Case Enumerados.enumMotivoSalida.Despido
        _art188 = True
        _art185 = True
        '_art154 = True
      Case Enumerados.enumMotivoSalida.Desahucio
        _art185 = True
      Case Enumerados.enumMotivoSalida.Abandono
        _art190 = True
      Case Enumerados.enumMotivoSalida.VistoBueno
      Case Enumerados.enumMotivoSalida.Fallecimiento

    End Select

    If _bonificacion Then
      '_valor = Math.Round(Contrato.SueldoMes(dtfechasalida.Value) * 0.25 * Math.Floor(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365), 2)

      Dim _boni As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.bonificacion
      With CrearRubroDet(CrearRubro(_boni), _boni)
        .RubDet_Valor = 0
        .RubDet_Cantidad = beneficio.DiasAcumulados
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    If True Then
      Dim _valor As Decimal = 0

      Dim _otrosie As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.otros_I_E
      With CrearRubroDet(CrearRubro(_otrosie), _otrosie)
        .RubDet_Valor = _valor
        .RubDet_Cantidad = 0
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    If _art185 Then
      Dim _cantidad As Integer = Math.Floor(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365)
      Dim _valor As Decimal = Math.Round(Contrato.Sueldo() * 0.25 * _cantidad, 2)
      '_valor = Math.Round(Contrato.SueldoMes(dtfechasalida.Value) * 0.25 * Math.Floor(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365), 2)

      Dim art185 As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.Art185
      With CrearRubroDet(CrearRubro(art185), art185)
        .RubDet_Valor = _valor
        .RubDet_Cantidad = _cantidad
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    If _art188 Then
      Dim _cantidad As Integer = IIf(Math.Ceiling(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365) <= 3, 3, Math.Ceiling(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365))
      Dim _valor As Decimal = Math.Round(Contrato.Sueldo() * _cantidad, 2)
      '_valor = Math.Round(Contrato.SueldoMes(dtfechasalida.Value) * IIf(Math.Ceiling(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365) <= 3, 3, Math.Ceiling(Me.dtfechasalida.Value.Date.Subtract(Contrato.Contra_Desde).Days / 365)), 2)

      Dim art188 As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.Art188
      With CrearRubroDet(CrearRubro(art188), art188)
        .RubDet_Valor = _valor
        .RubDet_Cantidad = _cantidad
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    'If _art154 Then
    '  _valor = Math.Round(Contrato.Sueldo() * 12, 2)

    '  Dim art154 As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.Art154
    '  With CrearRubroDet(CrearRubro(art154), art154)
    '    .RubDet_Valor = _valor
    '    .RubDet_Cantidad = 0
    '    .RubDet_Nota = mObservacion
    '    .RubDet_Fecha = Me.dtfechasalida.Value.Date
    '    .RubDet_PagarEnFDM = True
    '    .RubDet_Observacion = mObservacion
    '  End With
    'End If

    If _art181 Then
      Dim dias As Integer = 0
      Dim fecha As Date = Contrato.Contra_Desde
      While fecha < Me.dtfechasalida.Value.Date
        If Me.dtfechasalida.Value.Year * 100 + Me.dtfechasalida.Value.Month > fecha.Year * 100 + fecha.Month Then
          dias += 30 - fecha.Day + 1
          fecha = fecha.AddDays(-fecha.Day + 1)
          fecha = fecha.AddMonths(1)
        Else
          dias += Me.dtfechasalida.Value.Day - fecha.Day + 1
          fecha = Me.dtfechasalida.Value.Date
        End If
      End While

      Dim _valor As Decimal = Math.Round((Contrato.Sueldo / 360 * (360 - dias)) * 0.5, 2)

      Dim art181 As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.Art181
      With CrearRubroDet(CrearRubro(art181), art181)
        .RubDet_Valor = _valor
        .RubDet_Cantidad = 360 - dias
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    If _art190 Then
      Dim _valor As Decimal = Math.Round(Contrato.Sueldo / 30 * 15, 2)

      Dim art190 As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.Art190
      With CrearRubroDet(CrearRubro(art190), art190)
        .RubDet_Valor = _valor
        .RubDet_Cantidad = 0
        .RubDet_Nota = mObservacion
        .RubDet_Fecha = Me.dtfechasalida.Value.Date
        .RubDet_PagarEnFDM = True
        .RubDet_Observacion = mObservacion
      End With
    End If

    Dim _valorapagar As Decimal = 0
    For Each _rd As RubroDet In mRubroDets
      If _rd.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
        _valorapagar -= _rd.Valor
      Else
        _valorapagar += _rd.Valor
      End If
    Next

    Dim liqxpagar As Integer = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar
    With CrearRubroDet(CrearRubro(liqxpagar), liqxpagar)
      .RubDet_Valor = _valorapagar
      .RubDet_Cantidad = 0
      .RubDet_Nota = mObservacion
      .RubDet_Fecha = Me.dtfechasalida.Value.Date
      .RubDet_PagarEnFDM = True
      .RubDet_Observacion = mObservacion
    End With

    CambioSignoRubroQuincena()

    llenarRubros()

    Me.btncerrar.Enabled = True
  End Sub

  Sub CambioSignoRubroQuincena()
    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
        _rubrodet.RubDet_Valor = -_rubrodet.RubDet_Valor
      End If
    Next
    dgdetliq.Invalidate()
  End Sub

  Private mRubros As RubroList
  Private mRubroDets As RubroDetList = Nothing

  Sub llenarRubros()

    Me.dgdetliq.Columns.Clear()

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"

    Dim estilonum0 As New DataGridViewCellStyle()
    estilonum0.Format = "N0"

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Grabado"
    DataGridViewTextBoxColumn1.HeaderText = "Grabado"
    DataGridViewTextBoxColumn1.Width = 50
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "TipoRubroString"
    DataGridViewTextBoxColumn2.HeaderText = "Tipo Rubro"
    DataGridViewTextBoxColumn2.Width = 175
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Valor"
    DataGridViewTextBoxColumn2.HeaderText = "Valor"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 80
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "RubDet_Cantidad"
    DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum0
    DataGridViewTextBoxColumn2.Width = 50
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
    DataGridViewTextBoxColumn2.HeaderText = "Fecha"
    DataGridViewTextBoxColumn2.Width = 80
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Observacion"
    DataGridViewTextBoxColumn2.HeaderText = "Observación"
    DataGridViewTextBoxColumn2.Width = 150
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Nota"
    DataGridViewTextBoxColumn2.HeaderText = "Nota"
    DataGridViewTextBoxColumn2.Width = 150
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "SubCentroCostoString"
    DataGridViewTextBoxColumn2.HeaderText = "SubCentroCosto"
    DataGridViewTextBoxColumn2.Width = 150
    Me.dgdetliq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    Me.BSRubroDet.DataSource = mRubroDets
  End Sub

  Private Sub CtlBuscaEmpleados1_CambioEmpleado(sender As Object, e As System.EventArgs) Handles CtlBuscaEmpleados1.CambioEmpleado
    RefrescarEmpleado()
  End Sub

  Private Sub btncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btncerrar.Click
    If Contrato Is Nothing OrElse Me.BSRubroDet.DataSource Is Nothing Then
      Exit Sub
    End If
    If ComboBoxLoteLiquidacion1.BeneficiosSocialesLotePago Is Nothing Then
      MsgBox("Debe seleccionar un lote de pago", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Try
      Sistema.OperadorDatos.ComenzarTransaccion()
      Dim _valor As Decimal = 0
      For Each _rubrodet As RubroDet In mRubroDets
        If _rubrodet.Rubro.EsNuevo Then
          If _rubrodet.Rubro.Guardar() Then
            _rubrodet.Rubro = _rubrodet.Rubro
          Else
            Throw New Exception(_rubrodet.Rubro.OperadorDatos.MsgError)
          End If
        End If

        If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar Then
          _valor = _rubrodet.RubDet_Valor
        End If

        If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
          '_rubrodet.RubDet_Valor = valorquincena
        ElseIf Not _rubrodet.Guardar Then
          Throw New Exception(_rubrodet.OperadorDatos.MsgError)
        End If
      Next

      Contrato.Contra_Hasta = Me.dtfechasalida.Value.Date
      Contrato.PardetMotivoSalida = Me.cbomotivosalida.ParametroDet
      Contrato.PardetTipoLiquidacion = Me.cbotipoliquidacion.ParametroDet
      Contrato.esCerrado = True
      Contrato.Guardar()

      Dim _beneficio As New BeneficiosSociales(Sistema.OperadorDatos, True)
      _beneficio.BenLot_Codigo = ComboBoxLoteLiquidacion1.BeneficiosSocialesLotePago.BenLot_Codigo
      _beneficio.Contrato = Contrato
      _beneficio.PardetTipoBeneficio = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Liquidacion)
      _beneficio.BenSoc_Valor = _valor
      _beneficio.Guardar()

      Sistema.OperadorDatos.TerminarTransaccion()

      For Each _rubrodet As RubroDet In mRubroDets
        _rubrodet.Rubro.AceptarCambios()
        _rubrodet.AceptarCambios()
      Next

      'capar d3 d4 vac
      RubroDetList.MarcarPagadosBeneficios(Contrato, Me.dtfechasalida.Value.Date, Nothing, Nothing)

      RefrescarEmpleado()
    Catch ex As Exception
      Sistema.OperadorDatos.CancelarTransaccion()
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub LiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LiquidacionToolStripMenuItem.Click
    If Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono Is Nothing Then
      Exit Sub
    End If

    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.BeneficiosSociales)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Beneficios_Sociales")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleados1.CtlPatrono1.Patrono.Patron_Codigo, 5}
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

  Private Sub btnabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgdetliq.DoubleClick 'btnabrir.Click,
    If BSRubroDet.Current Is Nothing OrElse Contrato.esCerrado Then
      Exit Sub
    End If

    If Not Restriccion.Restri_VerConfidencial Then
      Exit Sub
    End If

    If Not (CType(BSRubroDet.Current, RubroDet).Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.Quincena And CType(BSRubroDet.Current, RubroDet).Grabado) AndAlso Not CType(BSRubroDet.Current, RubroDet).Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar Then

      Dim f As New FrmRubroDet(Sistema, Restriccion) With {
        .RubroDet = BSRubroDet.Current,
        .GuardarEnMemoria = True
      }
      f.RestriccionesQuincena()
      f.ShowDialog()
      dgdetliq.Invalidate()
      f.Dispose()
      CType(BSRubroDet.Current, RubroDet).RubDet_Valor2 = CType(BSRubroDet.Current, RubroDet).RubDet_Valor
      CType(BSRubroDet.Current, RubroDet).RubDet_Cantidad2 = CType(BSRubroDet.Current, RubroDet).RubDet_Cantidad
      'If Not LiquidacionListBindingSource.Current.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Aporte9_35 Then
      '  ModificarAporte9_35()
      'End If
      'If Not LiquidacionListBindingSource.Current.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.FondoReserva Then
      '  ModificarFondoReserva()
      'End If
      CalcularValorLiquidacion()
    End If
  End Sub

  Private Sub CalcularValorLiquidacion()
    If Contrato Is Nothing OrElse BSRubroDet.DataSource Is Nothing Then
      Exit Sub
    End If

    Dim msuma As Decimal = 0
    Dim mrubdet As RubroDet = Nothing

    For Each _rubrodet As RubroDet In BSRubroDet
      If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosLiquidacion.LiquidacionaPagar Then
        mrubdet = _rubrodet
      Else
        msuma += _rubrodet.Valor
      End If
    Next

    If mrubdet IsNot Nothing AndAlso mrubdet.EsNuevo Then
      mrubdet.RubDet_Valor = msuma
      mrubdet.Rubro.Rubro_ValorTope = msuma
    End If
  End Sub

  Private Sub ReporteLiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteLiquidacionToolStripMenuItem.Click
    If BSRubroDet.DataSource Is Nothing Then
      MsgBox("No existe información para el reporte", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    ExcelReporte.LiquidacionHaberes.Imprimir_Liquidacion(Contrato, BSRubroDet.DataSource, Sistema.UsuarioString)
  End Sub

  Private Sub MedioDeAprobacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MedioDeAprobacionToolStripMenuItem.Click
    If BSRubroDet.DataSource Is Nothing Then
      MsgBox("No existe información para el reporte", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    ExcelReporte.LiquidacionHaberes.Imprimir_MedioAprobacion(Contrato, BSRubroDet.DataSource, Sistema.UsuarioString)
  End Sub

  Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgdetliq.CellFormatting
    For Each _cell As DataGridViewCell In dgdetliq.Rows(e.RowIndex).Cells
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

  Private Function CrearRubroDet(_rubro As Rubro, _rubrodetbuscado As Integer) As RubroDet
    Dim _rubdet As RubroDet = BuscarRubroDet(_rubrodetbuscado)
    If _rubdet Is Nothing Then
      _rubdet = New RubroDet(Sistema.OperadorDatos, True)
      _rubdet.Entida_Codigo = Contrato.Entida_Codigo
      _rubdet.Patron_Codigo = Contrato.Patron_Codigo
      _rubdet.Contra_Secuencia = Contrato.Contra_Secuencia
      _rubdet.Rubro_Secuencia = _rubro.Rubro_Secuencia
      '_rubdet.PerPag_FechaDesde = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
      _rubdet.Parame_PeriodoPago = Contrato.Tipocontrato.Parame_PeriodoPago
      _rubdet.Pardet_PeriodoPago = Contrato.Tipocontrato.Pardet_PeriodoPago
      _rubdet.Parame_TipoPeriodoPago = Enumerados.EnumParametros.TipoPeriodoPago
      _rubdet.Pardet_TipoPeriodoPago = Enumerados.enumTipoPeriodoPago.FindeMes
      _rubdet.Parame_TipoRubro = Enumerados.EnumParametros.TipoRubro
      _rubdet.Pardet_TipoRubro = _rubrodetbuscado
      _rubdet.Parame_Departamento = Contrato.Parame_Departamento
      _rubdet.Pardet_Departamento = Contrato.Pardet_Departamento
      _rubdet.Parame_Area = Contrato.Parame_Area
      _rubdet.Pardet_Area = Contrato.Pardet_Area
      _rubdet.Cargo_Secuencia = Contrato.Cargo_Secuencia
      _rubdet.Parame_SubCentroCosto = Contrato.Parame_SubCentroCosto
      _rubdet.Pardet_SubCentroCosto = Contrato.Pardet_SubCentroCosto
      _rubdet.RubDet_PagarenLiq = True

      mRubroDets.Add(_rubdet)
    End If
    Return _rubdet
  End Function

  Private Function BuscarRubroDet(_rubrodetbuscado As Integer) As RubroDet
    For Each _rubrodet As RubroDet In mRubroDets
      If _rubrodet.Pardet_TipoRubro = _rubrodetbuscado AndAlso Not _rubrodet.Existe = 2 Then
        Return _rubrodet
      End If
    Next
    Return Nothing
  End Function

  Private Sub cambiarPatrono(_Patrono As Patrono)
    If Contrato.Patrono IsNot Nothing AndAlso (ComboBoxLoteLiquidacion1.Patrono Is Nothing OrElse Contrato.Patron_Codigo <> ComboBoxLoteLiquidacion1.Patrono.Patron_Codigo) Then
      Me.ComboBoxLoteLiquidacion1.Patrono = Contrato.Patrono
      Me.ComboBoxLoteLiquidacion1.PardetTipoBeneficio = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Liquidacion)
      Me.ComboBoxLoteLiquidacion1.Llenar_datos()
    End If
  End Sub

  Private Sub RefrescarEmpleado()
    If Contrato Is Nothing Then
      Exit Sub
    End If
    cambiarPatrono(Contrato.Patrono)

    Me.btncerrar.Enabled = False
    Me.lblMensaje.Text = String.Format("{0}, Contrato desde:{1}", Me.CtlBuscaEmpleados1.Empleado.NombreCompleto, Contrato.Contra_Desde.ToShortDateString)
    Me.BSRubroDet.DataSource = Nothing

    pnlConsulta.Enabled = Not Contrato.esCerrado
    btncalcular.Enabled = Not Contrato.esCerrado

    If Contrato.esCerrado Then
      Me.lblMensaje.Text = String.Format("{0}, Contrato desde:{1} hasta:{2}", Me.CtlBuscaEmpleados1.Empleado.NombreCompleto, Contrato.Contra_Desde.ToShortDateString, Contrato.Contra_Hasta.ToShortDateString)
      dtfechasalida.Value = Contrato.Contra_Hasta
      cbotipoliquidacion.ParametroDet = Contrato.PardetTipoLiquidacion
      cbomotivosalida.ParametroDet = Contrato.PardetMotivoSalida
      Calcular()
    End If
  End Sub

End Class