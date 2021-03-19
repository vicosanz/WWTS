Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.Data.SqlClient

Public Class FrmQuincena

  Private Sub FrmQuincena_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs)
    Me.Text = "Quincena"
    Me.CtlBuscaEmpleadosPeriodo1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleadosPeriodo1.Op = Sistema.OperadorDatos

    HeaderStrip2.Enabled = Restriccion.Restri_VerConfidencial
  End Sub

  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(value As Contrato)
      mContrato = Value
      Me.Panel1.Enabled = Not Value Is Nothing
      If Panel1.Enabled Then
        Me.Panel1.Enabled = Not CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esPagado
      End If
      lbl_descripcion.Visible = False
      If CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_esPagado Then
        lbl_descripcion.Text = "Periodo Cerrado."
        lbl_descripcion.Visible = True
      End If
      buscar_rubrodet()
      leyenda()
      calcular()
    End Set
  End Property

  Private mRubroDetSueldo As RubroDet
  Public Property RubroDetSueldo() As RubroDet
    Get
      Return mRubroDetSueldo
    End Get
    Set(value As RubroDet)
      mRubroDetSueldo = value
    End Set
  End Property

  Private mRubroDetQuincena As RubroDet = Nothing
  Public Property RubroDetQuincena() As RubroDet
    Get
      Return mRubroDetQuincena
    End Get
    Set(value As RubroDet)
      mRubroDetQuincena = value
    End Set
  End Property

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
#End Region

  Private mRubroDets As RubroDetList
  Sub buscar_rubrodet()
    If Contrato Is Nothing Then
      Me.BSRubroDet.DataSource = Nothing
      Exit Sub
    End If

    RubroQuincena()

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
    DataGridViewTextBoxColumn2.Width = 125
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Valor"
    DataGridViewTextBoxColumn2.HeaderText = "Valor"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "RubDet_Cantidad"
    DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
    DataGridViewTextBoxColumn2.DefaultCellStyle = estilonum0
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
      DataGridViewTextBoxColumn2.DataPropertyName = "Nota"
      DataGridViewTextBoxColumn2.HeaderText = "Nota"
      DataGridViewTextBoxColumn2.Width = 150
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

      DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn2.DataPropertyName = "SubCentroCostoString"
      DataGridViewTextBoxColumn2.HeaderText = "SubCentroCosto"
      DataGridViewTextBoxColumn2.Width = 150
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

      Dim fechacorte As Date = DateAdd(DateInterval.Day, 14, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde)

    mRubroDets = RubroDetList.ObtenerListaQuincena(Sistema.OperadorDatos, Contrato, CtlBuscaEmpleadosPeriodo1.Periodo)

      Dim band As Integer = 0
      For Each _rubdet As RubroDet In mRubroDets
        If _rubdet.Rubro.Pardet_TipoRubro = 11 Then
          band = 1
        End If
      Next

      For Each _rubdet As RubroDet In mRubroDets
        If _rubdet.Rubro.Pardet_TipoRubro = 1 Then
          RubroDetSueldo = _rubdet
          If band = 0 Then
            For Each _rubro As Rubro In RubroList.ObtenerListaxContrato(Sistema.OperadorDatos, mContrato)
              If _rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
                _rubdet.Rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena
                _rubdet.Rubro_Secuencia = _rubro.Rubro_Secuencia
                _rubdet.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena

                Dim _licencias As LicenciaList = New LicenciaList
                _licencias = LicenciaList.ObtenerLista(Sistema.OperadorDatos, Contrato, CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde, fechacorte)
                If _licencias.Count > 0 Then
                  _rubdet.RubDet_Valor = 0
                  _rubdet.RubDet_Nota = "*** Sueldo $0 por Licencia ***"
                End If
                Exit For
              End If
            Next
          End If
        End If
      Next

      If band = 1 Then
        mRubroDets.Remove(RubroDetSueldo)
      End If

      'Dim items As New Infoware.Reglas.SortedView(mRubroDets)
      'BSRubroDet.DataSource = items

      BSRubroDet.DataSource = mRubroDets
  End Sub

  Private _suma, _resta As Decimal
  Sub calcular()
    If BSRubroDet.DataSource Is Nothing Then
      Exit Sub
    End If
    _suma = 0
    _resta = 0
    For Each _rubrodet As RubroDet In BSRubroDet
      If _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = 1 Then
        _suma += Math.Round(_rubrodet.RubDet_Valor, 2)
			ElseIf _rubrodet.Rubro.PardetTipoRubro.Pardet_DatoDec1 = -1 Then
        _resta += Math.Round(_rubrodet.RubDet_Valor, 2)
      End If
    Next
    txtIngresos.Text = _suma.ToString("0.00")
    txtEgresos.Text = _resta.ToString("0.00")
    txtTotal.Text = (_suma - _resta).ToString("0.00")

    If (_suma - _resta) < 0 Then
      lbl_descripcion.Text += ", Resultado Negativo"
      lbl_descripcion.BackColor = Color.Coral
      lbl_descripcion.Visible = True
    Else
      lbl_descripcion.BackColor = System.Drawing.SystemColors.Info
    End If
  End Sub

  Private Sub btnabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrir.Click, DataGridView1.DoubleClick
    If BSRubroDet.Current Is Nothing Then
      Exit Sub
    End If

    If Not Restriccion.Restri_VerConfidencial Then
      Exit Sub
    End If

    Dim f As New FrmRubroDet(Sistema, Restriccion)
    f.RubroDet = BSRubroDet.Current
    f.GuardarEnMemoria = True
    f.RestriccionesQuincena()
    f.ShowDialog()
    DataGridView1.Invalidate()
    f.Dispose()
    calcular()
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If Contrato IsNot Nothing And BSRubroDet IsNot Nothing Then
      If MsgBox("¿Está seguro que desea deshacer la quincena?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
        Exit Sub
      End If

      Sistema.OperadorDatos.ComenzarTransaccion()
      Try
        For Each _rubrodet As RubroDet In BSRubroDet
          If Not _rubrodet.Eliminar() Then
            Throw New Exception(_rubrodet.OperadorDatos.MsgError)
          End If
        Next
        Sistema.OperadorDatos.TerminarTransaccion()
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Eliminacion, String.Format("Eliminó Quincena: {0}", Contrato.EmpleadoString))
      Catch ex As Exception
        Sistema.OperadorDatos.CancelarTransaccion()
        MsgBox("No se puedo eliminar quincena" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      End Try

      If RubroDetSueldo IsNot Nothing Then
        RubroDetSueldo = Nothing
      End If

      BSRubroDet.DataSource = Nothing
      txtIngresos.Text = "0,00"
      txtEgresos.Text = "0,00"
      txtTotal.Text = "0,00"
    End If
  End Sub

  Sub leyenda()
    If Contrato IsNot Nothing And BSRubroDet IsNot Nothing Then
      Dim band As Integer = 0
      For Each _rubrodet As RubroDet In BSRubroDet
        If _rubrodet.RubDet_Secuencia = 0 Then
          band = 1
        End If
      Next
      If band = 1 Then
        lbl_descripcion.Visible = True
        lbl_descripcion.Text = "Registro no guardado"
      End If
    End If
  End Sub

  Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
    If Contrato IsNot Nothing And BSRubroDet IsNot Nothing Then
      Sistema.OperadorDatos.ComenzarTransaccion()
      Try
        Dim _valorquincena As Decimal = 0
        For Each _rubrodet As RubroDet In BSRubroDet
          _valorquincena += _rubrodet.Valor
        Next

        For Each _rubrodet As RubroDet In BSRubroDet
          If _rubrodet.RubDet_Secuencia = 0 Then
            _rubrodet.EsNuevo = True
            _rubrodet.PerPag_FechaDesde = CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde
            _rubrodet.RubDet_Nota = _rubrodet.RubDet_Nota + " Generado en quincena, periodo " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaDesde.ToShortDateString + " - " + CtlBuscaEmpleadosPeriodo1.Periodo.PerPag_FechaHasta.ToShortDateString
          End If

          If _rubrodet.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
            _rubrodet.RubDet_Cantidad2 = _rubrodet.RubDet_Cantidad
            _rubrodet.RubDet_Valor2 = _valorquincena
            _rubrodet.RubDet_ValorFinal = CDec(txtTotal.Text)
          End If

          _rubrodet.Parame_Departamento = Contrato.Parame_Departamento
          _rubrodet.Pardet_Departamento = Contrato.Pardet_Departamento
          _rubrodet.Parame_Area = Contrato.Parame_Area
          _rubrodet.Pardet_Area = Contrato.Pardet_Area
          _rubrodet.Cargo_Secuencia = Contrato.Cargo_Secuencia
          _rubrodet.Parame_SubCentroCosto = Contrato.Parame_SubCentroCosto
          _rubrodet.Pardet_SubCentroCosto = Contrato.Pardet_SubCentroCosto

          If Not _rubrodet.Guardar() Then
            Throw New Exception(_rubrodet.OperadorDatos.MsgError)
          End If
        Next

        Sistema.OperadorDatos.TerminarTransaccion()

        For Each _rubrodet As RubroDet In BSRubroDet
          _rubrodet.Rubro.AceptarCambios()
          _rubrodet.AceptarCambios()
        Next

        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Modificacion, String.Format("Generó Quincena: {0}", Contrato.EmpleadoString))
        buscar_rubrodet()
        lbl_descripcion.Visible = False
      Catch ex As Exception
        Sistema.OperadorDatos.CancelarTransaccion()
        MsgBox("No se puedo guardar quincena" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End If
  End Sub

  Private Sub QuincenaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuincenaToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Quincena)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Quincena")
    f.ShowDialog()
  End Sub

  Private Sub RubroQuincena()
    Dim bandera As Integer = 0

    Dim _rubrolist As RubroList = RubroList.ObtenerListaxContrato(Sistema.OperadorDatos, mContrato)
    For Each _rubro As Rubro In _rubrolist
      If _rubro.Pardet_TipoRubro = Enumerados.enumTipoRubroVarios.Quincena Then
        bandera = 1
      End If
    Next

    If bandera = 0 Then
      Dim _rubro As Rubro = New Rubro(Sistema.OperadorDatos, True)
      _rubro.Entida_Codigo = Contrato.Entida_Codigo
      _rubro.Patron_Codigo = Contrato.Patron_Codigo
      _rubro.Contra_Secuencia = Contrato.Contra_Secuencia
      _rubro.PardetTipoRubro = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoRubro, Enumerados.enumTipoRubroVarios.Quincena)
      _rubro.Guardar()
    End If
  End Sub

  Private Sub btnnuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevo.Click
    Dim _parametro As New WWTSParametroDet(Contrato.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.AdicionalesNomina)
    Dim _rubro As Rubro = New Rubro(Contrato.OperadorDatos, True)
    _rubro.Contrato = Contrato

    Dim f As New FrmRubroAdicionalNomina(Sistema, Enumerados.EnumOpciones.Personal)
    f.Parametro = _parametro
    f.Rubro = _rubro
    f.PeriodoPago = CtlBuscaEmpleadosPeriodo1.Periodo
    f.EsQuincena = True
    f.ShowDialog()

    If f.RubroDet IsNot Nothing Then
      mRubroDets.Add(f.RubroDet)
      DataGridView1.Invalidate()
      calcular()
    End If
    'BSRubroDet.DataSource = mRubroDets
  End Sub
End Class
