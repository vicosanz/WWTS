Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmPrestamos
  Implements IOpcion

  Private Sub FrmPrestamos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Préstamos/Anticipos"
    Me.CtlBuscaEmpleado1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleado1.Op = Sistema.OperadorDatos

    Me.ComboBoxTipo.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipo.Parametro = Enumerados.EnumParametros.TipoRubro
    Dim _parametro As New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.NoDefinidoEnContrato)
    Me.ComboBoxTipo.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, _parametro)
  End Sub

  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(ByVal Value As Contrato)
      mContrato = Value
      Me.TableLayoutPanel1.Enabled = Not Value Is Nothing
      buscar_rubro()
    End Set
  End Property

  Private Sub CtlBuscaEmpleado1_CambioEmpleado(ByVal sender As Object, ByVal e As EventArgs) Handles CtlBuscaEmpleado1.CambioEmpleado
    Contrato = Me.CtlBuscaEmpleado1.Contrato
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
      Return Nothing 'Me.ToolStrip1
    End Get
  End Property

  Private Sub checktipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checktipo.CheckedChanged
    If checktipo.Checked Then
      Me.ComboBoxTipo.Enabled = True
    Else
      Me.ComboBoxTipo.Enabled = False
    End If
    buscar_rubro()
    buscar_rubrodet()
  End Sub

  Private mRubros As RubroList
  Sub buscar_rubro()
    If Contrato Is Nothing Then
      Me.BSrubro.DataSource = Nothing
      Exit Sub
    End If

    Me.DataGridView1.Columns.Clear()

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoRubroString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo Rubro"
    DataGridViewTextBoxColumn1.Width = 125
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Total"
    DataGridViewTextBoxColumn1.HeaderText = "Total"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 60
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Quincena"
    DataGridViewTextBoxColumn1.HeaderText = "En Quincena"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 70
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "FinMes"
    DataGridViewTextBoxColumn1.HeaderText = "En Fin de Mes"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 70
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "esInfinito"
    DataGridViewTextBoxColumn2.HeaderText = "Es Infinito"
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "ValorTope"
    DataGridViewTextBoxColumn1.HeaderText = "Valor Tope"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 60
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "GravaIESS"
    DataGridViewTextBoxColumn2.HeaderText = "Grava IESS"
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "FechaVigencia"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha Vigencia"
    DataGridViewTextBoxColumn1.Width = 80
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TotalPagado"
    'DataGridViewTextBoxColumn1.HeaderText = "Total Pagado"
    'DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    'DataGridViewTextBoxColumn1.Width = 70
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "Rubro_Activo"
    DataGridViewTextBoxColumn2.HeaderText = "Activo"
    DataGridViewTextBoxColumn2.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Saldo"
    DataGridViewTextBoxColumn1.HeaderText = "Saldo"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 60
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Rubro_Observacion"
    DataGridViewTextBoxColumn1.HeaderText = "Observación"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DataGridViewTextBoxColumn1.Width = 200
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim _Parametro_Padre As New WWTSParametroDet(Contrato.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.NoDefinidoEnContrato)
    mRubros = RubroList.ObtenerListaxContrato(Contrato.OperadorDatos, Contrato, _Parametro_Padre, IIf(Me.checktipo.Checked, Me.ComboBoxTipo.ParametroDet, Nothing))
    Dim mitemssortrubro As New Infoware.Reglas.SortedView(mRubros)
    BSrubro.DataSource = mitemssortrubro
  End Sub

  Private Sub ComboBoxTipo_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipo.CambioItem
    buscar_rubro()
  End Sub

  Private Sub btnabrirrubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirrubro.Click, DataGridView1.DoubleClick
    If BSrubro.Current Is Nothing Then
      Exit Sub
    End If

    Dim _parametro As New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.NoDefinidoEnContrato)
    Dim f As New WWTS.Roles.Controles.FrmRubro(Sistema, Enumerados.EnumOpciones.Personal) With {
      .Parametro = _parametro,
      .Rubro = BSrubro.Current
    }
    f.ShowDialog()
    buscar_rubro()
  End Sub

  Private Sub btnnuevorubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevorubro.Click
    Dim _parametro As New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.NoDefinidoEnContrato)
    Dim _rubro As Rubro = New Rubro(Sistema.OperadorDatos, True)
    _rubro.Contrato = Contrato

    Dim f As New WWTS.Roles.Controles.FrmRubro(Sistema, Enumerados.EnumOpciones.Personal) With {
      .Parametro = _parametro,
      .Rubro = _rubro
    }
    f.ShowDialog()
    buscar_rubro()
  End Sub

  Private Sub btnnuevodet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevodet.Click
    If BSrubro.Current Is Nothing Then
      Exit Sub
    End If
    Me.BSRubroDet.AddNew()
    Me.BSRubroDet.MoveLast()
    Abrir_MantenimientoRubroDetalles()
  End Sub

  Sub Abrir_MantenimientoRubroDetalles()
    If Me.BSrubro.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmRubroDet(Sistema, Restriccion)
    Dim _rubro As Rubro = CType(BSrubro.Current, Rubro)
    f.Rubro = _rubro
    f.RubroDetList = BSRubroDet

    f.ShowDialog()
    If BSrubro.Count <= 1 Then
      buscar_rubrodet()
    End If
    buscar_rubro()
    buscar_rubrodet()
    f.Dispose()
  End Sub

  Private Sub BSRubroDet_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BSRubroDet.AddingNew
    Dim _rubrodet As New RubroDet(BSrubro.Current)
    e.NewObject = _rubrodet
  End Sub

  Private mRubroDets As RubroDetList
  Sub buscar_rubrodet()
    If Me.BSrubro.Current Is Nothing Then
      BSRubroDet.DataSource = Nothing
      Me.DataGridView2.ReadOnly = True
    Else

      Me.DataGridView2.Columns.Clear()

      Dim estilonum2 As New DataGridViewCellStyle()
      estilonum2.Format = "N2"

      Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Secuencia"
      DataGridViewTextBoxColumn1.HeaderText = "#"
      DataGridViewTextBoxColumn1.Width = 30
      Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Valor"
      DataGridViewTextBoxColumn1.HeaderText = "Valor"
      DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
      DataGridViewTextBoxColumn1.Width = 60
      Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
      DataGridViewTextBoxColumn1.HeaderText = "Fecha"
      DataGridViewTextBoxColumn1.Width = 100
      Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Observacion"
      DataGridViewTextBoxColumn1.HeaderText = "Observación"
      DataGridViewTextBoxColumn1.Width = 170
      Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Nota"
      DataGridViewTextBoxColumn1.HeaderText = "Nota"
      DataGridViewTextBoxColumn1.Width = 250
      Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

      Dim _rubro As Rubro = CType(BSrubro.Current, Rubro)
      mRubroDets = RubroDetList.ObtenerListaxRubro(Sistema.OperadorDatos, _rubro)
      Dim item As New Infoware.Reglas.SortedView(mRubroDets)
      BSRubroDet.DataSource = item
    End If
  End Sub

  Private Sub DataGridViewAuto1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
    buscar_rubrodet()
  End Sub

  Private Sub btnabrirdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirdet.Click, DataGridView2.DoubleClick
    If BSRubroDet.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmRubroDet(Sistema, Restriccion)
    Dim _rubro As Rubro = CType(BSrubro.Current, Rubro)
    f.RubroDet = BSRubroDet.Current
    f.ShowDialog()
    buscar_rubro()
    buscar_rubrodet()
    f.Dispose()
  End Sub

  Private Sub btnelirubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelirubro.Click
    If BSrubro.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If CType(BSrubro.Current, Rubro).Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion Then
      Sistema.OperadorDatos.ComenzarTransaccion()
      Dim _rubro As Rubro = CType(BSrubro.Current, Rubro)
      RubroDet.UpdatePeriodoVacacion(CType(BSrubro.Current, Rubro))
      Dim _vacacion As BeneficiosSociales = New BeneficiosSociales(Sistema.OperadorDatos, _rubro.Contrato, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Vacaciones, _rubro.Rubro_VacacionSecuencia)
      _vacacion.BenSoc_Liquidado = False
      _vacacion.Guardar()
      If Not CType(BSrubro.Current, Rubro).Eliminar Then
        Sistema.OperadorDatos.CancelarTransaccion()
        MsgBox("Error al eliminar el rubro " & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        Exit Sub
      End If
      Sistema.OperadorDatos.TerminarTransaccion()
    Else
      If Not CType(BSrubro.Current, Rubro).Eliminar Then
        MsgBox("Error al eliminar el rubro " & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        Exit Sub
      End If
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó Rubro {0} {1} de {5}", CType(BSrubro.Current, Rubro).Contrato.EmpleadoString, CType(BSrubro.Current, Rubro).PardetTipoRubroString, CType(BSrubro.Current, Rubro).Contrato.Entida_Codigo, CType(BSrubro.Current, Rubro).Contrato.Patron_Codigo, CType(BSrubro.Current, Rubro).Contrato.Contra_Secuencia, CType(BSrubro.Current, Rubro).Total))
    BSrubro.RemoveCurrent()
  End Sub

  Private Sub btnelidet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelidet.Click
    If BSRubroDet.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSRubroDet.Current, RubroDet).Eliminar Then
      MsgBox("Error al eliminar el detalle " & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó RubroDetalle {0} {1} de {5}", CType(BSRubroDet.Current, RubroDet).Rubro.Contrato.EmpleadoString, CType(BSRubroDet.Current, RubroDet).Rubro.PardetTipoRubroString, CType(BSRubroDet.Current, RubroDet).Rubro.Contrato.Entida_Codigo, CType(BSRubroDet.Current, RubroDet).Rubro.Contrato.Patron_Codigo, CType(BSRubroDet.Current, RubroDet).Rubro.Contrato.Contra_Secuencia, CType(BSRubroDet.Current, RubroDet).RubDet_Valor))
    BSRubroDet.RemoveCurrent()
    buscar_rubro()
    buscar_rubrodet()
  End Sub

  Private Sub checktodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checktodos.CheckedChanged
    Me.checktipo.Enabled = Not Me.checktodos.Checked
    Me.ComboBoxTipo.Enabled = Not Me.checktodos.Checked

    If checktodos.Checked Then
      'Me.ComboBoxTipo.Enabled = True
      mRubros = RubroList.ObtenerListaxContrato(Contrato.OperadorDatos, Contrato, Nothing, Nothing)
      BSrubro.DataSource = mRubros

      Dim _rubro As Rubro = CType(BSrubro.Current, Rubro)
      mRubroDets = RubroDetList.ObtenerListaxRubro(Sistema.OperadorDatos, _rubro)
      BSRubroDet.DataSource = mRubroDets
    Else
      'Me.ComboBoxTipo.Enabled = False
      buscar_rubro()
      buscar_rubrodet()
    End If
    'buscar_rubro()
    'buscar_rubrodet()
  End Sub

  Private Sub mnuPagoCheque_Click(sender As System.Object, e As System.EventArgs) Handles mnuPagoCheque.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Nomina)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Prestamos_Pago_cheque")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, Me.CtlBuscaEmpleado1.CtlPatrono1.Patrono.Patron_Codigo}
    f.ShowDialog()
  End Sub

  Private Sub mnuprestamosresumido_Click(sender As System.Object, e As System.EventArgs) Handles mnuprestamosresumido.Click
    Dim f As New FrmListadoPrestamos(Sistema, Restriccion)
    f.TipoReporte = FrmListadoPrestamos.enumTipoReporte.Resumido
    f.Patrono = Me.CtlBuscaEmpleado1.CtlPatrono1.Patrono
    f.ShowDialog()
  End Sub

  Private Sub mnuprestamosdetallado_Click(sender As System.Object, e As System.EventArgs) Handles mnuprestamosdetallado.Click
    Dim f As New FrmListadoPrestamos(Sistema, Restriccion)
    f.TipoReporte = FrmListadoPrestamos.enumTipoReporte.Detallado
    f.Patrono = Me.CtlBuscaEmpleado1.CtlPatrono1.Patrono
    f.ShowDialog()
  End Sub

  Private Sub mnuPrestamoHipotecario_Click(sender As System.Object, e As System.EventArgs) Handles mnuPrestamoHipotecario.Click
    Dim f As New FrmListadoPrestamosHQ(Sistema, Restriccion)
    f.TipoReporte = FrmListadoPrestamosHQ.enumTipoReporte.Hipotecario
    f.Patrono = Me.CtlBuscaEmpleado1.CtlPatrono1.Patrono
    f.ShowDialog()
  End Sub

  Private Sub mnuPrestamoQuirografario_Click(sender As System.Object, e As System.EventArgs) Handles mnuPrestamoQuirografario.Click
    Dim f As New FrmListadoPrestamosHQ(Sistema, Restriccion)
    f.TipoReporte = FrmListadoPrestamosHQ.enumTipoReporte.Quirografario
    f.Patrono = Me.CtlBuscaEmpleado1.CtlPatrono1.Patrono
    f.ShowDialog()
  End Sub
End Class
