Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class CtlBuscaEmpleados
  Private mUsuario As Infoware.Reglas.General.Usuario = Nothing
  Public Property Usuario() As Infoware.Reglas.General.Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Infoware.Reglas.General.Usuario)
      mUsuario = value
    End Set
  End Property

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      If Not value Is Nothing Then
        Me.ComboBoxClase1.OperadorDatos = mOp
        Me.ComboBoxClase1.Parametro = Enumerados.EnumParametros.ClaseEmpleado
        Me.ComboBoxClase1.Llenar_Datos()

        Me.CtlPatrono1.Op = mOp
        Me.CtlPatrono1.llenar_datos(mUsuario)

        Me.CtlSeccion1.OperadorDatos = mOp
        Me.CtlSeccion1.Parametro = Enumerados.EnumParametros.Seccion
        Me.CtlSeccion1.Llenar_Datos()

        Me.CtlTipoContrato1.Op = mOp
        Me.CtlTipoContrato1.Patrono = Me.CtlPatrono1.Patrono
        Me.CtlTipoContrato1.llenar_datos()

        Me.numanioact.Value = Now.Year
        Me.numanioinac.Value = Now.Year
      End If
    End Set
  End Property

  Public Property Patrono As Patrono
    Get
      Return CtlPatrono1.Patrono
    End Get
    Set(value As Patrono)
      CtlPatrono1.Patrono = value
    End Set
  End Property

  Private mDeshabSelect As Boolean = False
  Public Event CambioEmpleado As eventhandler
  Public Event CambioPatrono As eventhandler

  Dim cambiarlistcheck As Boolean = False
  Dim cambiarcheck As Boolean = False

  Public Property Empleado() As Empleado
    Get
      If BindingSource.Current Is Nothing Then
        Return Nothing
      Else
        If mesEmpleado Then
          Return BindingSource.Current
        Else
          Return CType(BindingSource.Current, Contrato).Empleado
        End If
      End If
    End Get
    Set(ByVal value As Empleado)
      If value IsNot Nothing Then
        mEmpleados = New EmpleadoList
        mEmpleados.Add(value)
        Me.BindingSource.DataSource = mEmpleados
        MostrarEmpleados()
      Else
        Me.BindingSource.DataSource = Nothing
      End If
    End Set
  End Property

  Public ReadOnly Property Contrato() As Contrato
    Get
      If TypeOf (BindingSource.Current) Is Empleado Then
        Return CType(BindingSource.Current, Empleado).UltimoContrato(Me.CtlPatrono1.Patrono)
      Else
        Return CType(BindingSource.Current, Contrato)
      End If
    End Get
  End Property

  'Public ReadOnly Property EmpleadosTv() As TreeView
  '  Get
  '    Return Me.tvEmpleados
  '  End Get
  'End Property
  Public Property BindingSource As BindingSource
    Get
      Return ListBindingSource
    End Get
    Set(value As BindingSource)
      ListBindingSource = value
      Me.tvEmpleados.DataSource = ListBindingSource
    End Set
  End Property

  Private mEmpleados As EmpleadoList = Nothing
  Private mContratos As ContratoList = Nothing
  Private mesEmpleado As Boolean = True
  Private mesLlenandoLista As Boolean = False
  Public Sub llenar_datos(ByVal salida As Integer)
    If Op Is Nothing Then
      Exit Sub
    End If
    Retornar_Empleados()
    Me.lblstatus.Text = "."
    If mesEmpleado Then
      If mEmpleados IsNot Nothing Then
        Me.lblstatus.Text = mEmpleados.Count.ToString.Trim & " Empleados encontradas"
      End If
    Else
      If mContratos IsNot Nothing Then
        Me.lblstatus.Text = mContratos.Count.ToString.Trim & " Empleados encontradas"
      End If
    End If

    Select Case salida
      Case 1
        If mesEmpleado Then
          MostrarEmpleados()
        Else
          Me.tvEmpleados.Columns.Clear()

          Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
          DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
          DataGridViewTextBoxColumn0.DataPropertyName = "Seleccionado"
          DataGridViewTextBoxColumn0.HeaderText = ""
          DataGridViewTextBoxColumn0.Width = 20
          Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

          Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
          DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
          DataGridViewTextBoxColumn1.DataPropertyName = "EmpleadoString"
          DataGridViewTextBoxColumn1.HeaderText = "Nombre del empleado"
          DataGridViewTextBoxColumn1.Width = 250
          DataGridViewTextBoxColumn1.ReadOnly = True
          Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

          DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
          DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
          DataGridViewTextBoxColumn1.HeaderText = "Código"
          DataGridViewTextBoxColumn1.Width = 80
          DataGridViewTextBoxColumn1.ReadOnly = True
          Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

          mesLlenandoLista = True
          Dim mitemssort As New Infoware.Reglas.SortedView(mContratos)
          BindingSource.DataSource = mitemssort
        End If
        mesLlenandoLista = False
        CambiarEmpleado(True)
      Case 3
        Me.tvEmpleados.EndEdit()
        If mesEmpleado Then
          ExcelReporte.EmpleadoReporte.ExportarExcel(mEmpleados, chkficharoja.CheckState = CheckState.Checked)
        Else
          ExcelReporte.ContratoReporte.ExportarExcel(mContratos, chkincsueldos.Checked)
        End If
    End Select
    mDeshabSelect = False
  End Sub

  Private Sub MostrarEmpleados()
    Me.tvEmpleados.Columns.Clear()

    Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Seleccionado"
    DataGridViewTextBoxColumn0.HeaderText = ""
    DataGridViewTextBoxColumn0.Width = 20
    Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    DataGridViewTextBoxColumn1.HeaderText = "Nombre del empleado"
    DataGridViewTextBoxColumn1.Width = 250
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
    DataGridViewTextBoxColumn1.HeaderText = "Código"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    mesLlenandoLista = True
    Dim mitemssort As New Infoware.Reglas.SortedView(mEmpleados)
    BindingSource.DataSource = mitemssort
    mesLlenandoLista = False
    CambiarEmpleado(True)
  End Sub

  Public Sub Retornar_Empleados()
    mDeshabSelect = True
    Me.lblstatus.Text = ""
    Me.chktodos.Checked = False
    mEmpleados = Nothing
    mContratos = Nothing

    If rdodescparc.Checked Then
      lnkresumen.Text = "Descripción parcial:" & vbCrLf
      If Not Me.txtcodigo.Text.Trim = String.Empty Then
        lnkresumen.Text += "Código = " & Me.txtcodigo.Text & vbCrLf
      End If
      If Not Me.txtnombre.Text.Trim = String.Empty Then
        lnkresumen.Text += "Nombre = " & Me.txtnombre.Text & vbCrLf
      End If
      If Not Me.txtcedula.Text.Trim = String.Empty Then
        lnkresumen.Text += "Cédula = " & Me.txtcedula.Text & vbCrLf
      End If
      If Not CType(Me.txtedad.Text, Integer) Then
        lnkresumen.Text += IIf(cbomayorque.SelectedIndex = 0, "Mayor que", "Menor que") & " " & CInt(Me.txtedad.Text).ToString("0") & vbCrLf
      End If
      If Not Me.chkficharoja.CheckState = CheckState.Indeterminate Then
        lnkresumen.Text += IIf(chkficharoja.CheckState = CheckState.Checked, "Con ", "Sin ") & "ficha roja"
      End If
      If lnkresumen.Text = String.Empty Then
        lnkresumen.Text = "Todas las Empleados registrados"
      End If
      pnlresumen.Visible = True
      pnlbusqueda.Visible = False
      mEmpleados = EmpleadoList.ObtenerLista(Op, Me.txtnombre.Text, Me.txtcodigo.Value, Me.txtcedula.Text, CInt(Me.txtedad.Text), Me.cbomayorque.SelectedIndex = 0, Me.chkficharoja.CheckState)
      mesEmpleado = True
    ElseIf rdopersact.Checked Then
      lnkresumen.Text = "Empleados activos: " & dtfecactivo.Value.Date.ToShortDateString & vbCrLf
      Dim _Patrono As Patrono = Nothing
      If Not Me.CtlPatrono1.Patrono Is Nothing Then
        _Patrono = Me.CtlPatrono1.Patrono
        lnkresumen.Text += "Patrono = " & _Patrono.NombreCompleto & vbCrLf
      End If
      Dim _Seccion As WWTSParametroDet = Nothing
      If rdopersactsec.Checked Then
        _Seccion = Me.CtlSeccion1.ParametroDet
        lnkresumen.Text += "Sección = " & _Seccion.Pardet_Descripcion & vbCrLf
      End If
      Dim _Clase As WWTSParametroDet = Nothing
      If Me.chksoloclase.Checked Then
        _Clase = Me.ComboBoxClase1.ParametroDet
        lnkresumen.Text += "Clase = " & _Clase.Pardet_Descripcion & vbCrLf
      End If
      Dim _TipoContrato As TipoContrato = Nothing
      If Me.chkSoloContrato.Checked Then
        _TipoContrato = Me.CtlTipoContrato1.TipoContrato
        lnkresumen.Text += "Tipo de contrato = " & _TipoContrato.TipCon_Descripcion & vbCrLf
      End If
      Dim fecdesde As Date
      Dim fechasta As Date
      If rdopersactfecing.Checked Then
        fecdesde = Me.dtfecdesde.Value.Date
        fechasta = Me.dtfechasta.Value.Date
        lnkresumen.Text += "Fecha de entrada = " & fecdesde.ToShortDateString & " - " & fechasta.ToShortDateString & vbCrLf
      End If
      If rdopersactfecsal.Checked Then
        fecdesde = Me.dtfecdesdesal.Value.Date
        fechasta = Me.dtfechastasal.Value.Date
        lnkresumen.Text += "Fecha de salida = " & fecdesde.ToShortDateString & " - " & fechasta.ToShortDateString & vbCrLf
      End If
      If Not Me.chkDiscapacidad.CheckState = CheckState.Indeterminate Then
        lnkresumen.Text += chkDiscapacidad.Text
      End If
      pnlresumen.Visible = True
      pnlbusqueda.Visible = False

      mContratos = ContratoList.RetornarEmpleadosActivos(Op, Me.dtfecactivo.Value.Date, _Patrono, IIf(rdopersactsec.Checked, 1, IIf(rdopersactfecing.Checked, 2, IIf(rdopersactfecsal.Checked, 3, 4))), _Seccion, fecdesde, fechasta, _Clase, _TipoContrato, Me.chkpersentreedad.Checked, Me.txtedadi.Text, Me.txtedadf.Text)
      mesEmpleado = False
    Else 'Empleadol inactivo
      lnkresumen.Text = "Empleados inactivos el año " & Me.numanioinac.Value & vbCrLf
      If Me.chkanioactivo.Checked Then
        lnkresumen.Text += "que estuvo activo el año " & Me.numanioact.Value & vbCrLf
      End If
      pnlresumen.Visible = True
      pnlbusqueda.Visible = False

      If chkanioactivo.Checked Then
        mContratos = ContratoList.RetornarEmpleadosInactivos(Op, numanioinac.Value, numanioact.Value)
        mesEmpleado = False
      Else
        mEmpleados = EmpleadoList.RetornarEmpleadosInactivos(Op, numanioinac.Value)
        mesEmpleado = True
      End If
    End If
  End Sub

  Private Sub CtlBuscaEmpleados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cbomayorque.SelectedIndex = 0
    Me.dtfecdesde.Value = Now.Date
    Me.dtfechasta.Value = Now.Date
    Me.dtfecdesdesal.Value = Now.Date
    Me.dtfechastasal.Value = Now.Date
    rdopersact.Checked = True
    ajustarpaneles()
  End Sub

  'Private Sub tvEmpleados_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tvEmpleados.RowEnter
  '  If Not mDeshabSelect Then
  '    RaiseEvent CambioEmpleado()
  '  End If
  'End Sub

  Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    Me.llenar_datos(1)
  End Sub

#Region "Acoplar"
  Private Sub rdodescparc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdodescparc.CheckedChanged, rdopersact.CheckedChanged, rdopersinac.CheckedChanged
    ajustarpaneles()
  End Sub

  Sub ajustarpaneles()
    Me.pnldescparc.Visible = rdodescparc.Checked
    Me.pnlpersac.Visible = rdopersact.Checked
    Me.pnlpersinac.Visible = rdopersinac.Checked
    ajustarpnlpersact()
    ajustarpnlpersinact()
  End Sub

  Sub ajustarpnlpersact()
    If chkpersentreedad.Checked Then
      Me.pnlpersac.Height = Me.pnlpersentreedad.Top + Me.pnlpersentreedad.Height
    Else
      Me.pnlpersac.Height = Me.chkpersentreedad.Top + Me.chkpersentreedad.Height
    End If
    If rdopersinac.Checked Then
      Me.pnlbusqueda.Height = Me.pnlpersinac.Top + Me.pnlpersinac.Height
    Else
      Me.pnlbusqueda.Height = Me.rdopersinac.Top + Me.rdopersinac.Height
    End If
  End Sub

  Sub ajustarpnlpersinact()
    If chkanioactivo.Checked Then
      Me.pnlpersinac.Height = Me.pnlanioactivo.Top + Me.pnlanioactivo.Height
    Else
      Me.pnlpersinac.Height = Me.chkanioactivo.Top + Me.chkanioactivo.Height
    End If
    If rdopersinac.Checked Then
      Me.pnlbusqueda.Height = Me.pnlpersinac.Top + Me.pnlpersinac.Height
    Else
      Me.pnlbusqueda.Height = Me.rdopersinac.Top + Me.rdopersinac.Height
    End If
  End Sub

  Private Sub rdopersactsec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdopersactsec.CheckedChanged, rdopersactfecing.CheckedChanged, rdopersactfecsal.CheckedChanged, rdopersacttodos.CheckedChanged
    ajustarpersact()
  End Sub

  Sub ajustarpersact()
    Me.pnlpersactsec.Visible = Me.rdopersactsec.Checked
    Me.pnlpersactfecing.Visible = Me.rdopersactfecing.Checked
    Me.pnlpersactfecsal.Visible = Me.rdopersactfecsal.Checked
    ajustarpnlpersact()
  End Sub

  Private Sub chksoloclase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoloclase.CheckedChanged
    Me.pnlsoloclase.Visible = chksoloclase.Checked
    ajustarpnlpersact()
  End Sub

  Private Sub chksolocontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSoloContrato.CheckedChanged
    Me.pnlsoloPatrono.Visible = chkSoloContrato.Checked
    ajustarpnlpersact()
  End Sub

  Private Sub chkpersentreedad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpersentreedad.CheckedChanged
    Me.pnlpersentreedad.Visible = chkpersentreedad.Checked
    ajustarpnlpersact()
  End Sub

  Private Sub chkanioactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkanioactivo.CheckedChanged
    Me.pnlanioactivo.Visible = chkanioactivo.Checked
    ajustarpnlpersinact()
  End Sub

#End Region

  Private Sub btnexporTarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    Me.llenar_datos(3)
  End Sub

  Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
    If cambiarlistcheck Then
      Exit Sub
    End If
    cambiarcheck = True
    If mesEmpleado Then
      For Each _empleado As Empleado In mEmpleados
        _empleado.Seleccionado = Me.chktodos.Checked
      Next
    Else
      For Each _contrato As Contrato In mContratos
        _contrato.Seleccionado = Me.chktodos.Checked
      Next
    End If
    If chktodos.Checked Then
      Me.mnuimpcont.Enabled = (Not mesEmpleado) And chkSoloContrato.Checked
      Me.mnuimpetiq.Enabled = True
      Me.mnudocfalta.Enabled = True
      Me.mnurepasis.Enabled = (Not mesEmpleado) And rdopersactsec.Checked
    Else
      Me.mnuimpcont.Enabled = False
      Me.mnuimpetiq.Enabled = False
      Me.mnudocfalta.Enabled = False
      Me.mnurepasis.Enabled = False
    End If
    cambiarcheck = False
    Me.tvEmpleados.Refresh()
  End Sub

  Private Sub tvEmpleados_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles tvEmpleados.CellBeginEdit
    Me.tvEmpleados.EndEdit()
    If cambiarcheck Then
      Exit Sub
    End If
    cambiarlistcheck = True
    Dim sicheck As Boolean = True
    Dim nocheck As Boolean = True
    If mesEmpleado Then
      For Each _empleado As Empleado In mEmpleados
        If _empleado.Seleccionado Then
          nocheck = False
        Else
          sicheck = False
        End If
      Next
    Else
      For Each _contrato As Contrato In mContratos
        If _contrato.Seleccionado Then
          nocheck = False
        Else
          sicheck = False
        End If
      Next
    End If

    Me.mnuimpcont.Enabled = (Not mesEmpleado) And chkSoloContrato.Checked
    Me.mnurepasis.Enabled = (Not mesEmpleado) And rdopersactsec.Checked
    Me.mnuimpetiq.Enabled = True
    Me.mnudocfalta.Enabled = True
    If sicheck Then
      Me.chktodos.CheckState = CheckState.Checked
    ElseIf nocheck Then
      Me.chktodos.CheckState = CheckState.Unchecked
      Me.mnuimpcont.Enabled = False
      Me.mnuimpetiq.Enabled = False
      Me.mnudocfalta.Enabled = False
      Me.mnurepasis.Enabled = False
    Else
      Me.chktodos.Checked = True
      Me.chktodos.CheckState = CheckState.Indeterminate
    End If
    cambiarlistcheck = False
  End Sub

  Private Sub mnuimpcont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuimpcont.Click
    Me.tvEmpleados.EndEdit()
    If Me.chktodos.Checked = False OrElse mContratos.ListaSeleccionadas.Count = 0 Then
      Exit Sub
    End If
    General.Reglas.Utilerias.CombinarCorrespondencia(mContratos.ListaSeleccionadas, TipoContratoFormato.ObtenerFormato(mContratos.ListaSeleccionadas(0).Tipocontrato, Enumerados.enumFormatoxTipoContrato.Contrato))
  End Sub

  Private Sub mnuimpetiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuimpetiq.Click
    If Me.chktodos.Checked = False Then
      Exit Sub
    End If
    Dim Empleados As EmpleadoList
    If mesEmpleado Then
      Empleados = mEmpleados.ListaSeleccionadas
    Else
      Empleados = mContratos.ListaEmpleadosSeleccionados
    End If

    Dim dsEtiq As New DSetiquetas
    For Each _Empleado As Empleado In Empleados
      Dim _row As DSetiquetas.v_EtiquetaRow = dsEtiq.v_Etiqueta.Newv_EtiquetaRow
      _row.empleado = String.Format("({0}) {1}", _Empleado.Entida_Codigo, _Empleado.NombreCompleto.Trim)
      _row.cedula = _Empleado.Cedula.Trim

      dsEtiq.v_Etiqueta.Addv_EtiquetaRow(_row)
    Next
    dsEtiq.AcceptChanges()

    Try
      Dim info As New crpEtiquetas
      info.SetDataSource(dsEtiq)

      Dim _control As Control = Me.Parent
      While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
        _control = _control.Parent
      End While
      If _control Is Nothing Then
        Exit Sub
      End If

      Dim f As New FrmReporteBase(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
      'f.CrystalReportViewer1.Zoom(1)
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

      f.ReporteDatos = info
      'f.CrystalReportViewer1.DisplayToolbar = True
      'f.CrystalReportViewer1.ShowRefreshButton = False
      'f.CrystalReportViewer1.DisplayGroupTree = False
      f.ShowDialog()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
    End Try
    'Dim f As New frmimpetiquetas
    'If f.ShowDialog = DialogResult.OK Then
    '  ExcelReporte.EmpleadoReporte.Imprimir_etiquetas(Empleados, f.txtetiqueta.Text, f.numcol.Value, f.numfilas.Value, f.numespcol.Value, f.numespfil.Value)
    'End If
  End Sub

  Private Sub mnudocfalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudocfalta.Click
    If Me.chktodos.Checked = False Then
      Exit Sub
    End If
    Dim Empleados As EmpleadoList
    If mesEmpleado Then
      Empleados = mEmpleados.ListaSeleccionadas
    Else
      Empleados = mContratos.ListaEmpleadosSeleccionados
    End If

    ExcelReporte.EmpleadoReporte.ListarDocumentosFaltantes(Empleados)
  End Sub

  Private Sub mnurepasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurepasis.Click
    Dim f As New FrmInputBoxDate
    f.Title = "Reporte fechado a"
    f.Fecha = Now.Date
    If f.ShowDialog = DialogResult.OK Then
      'ExcelReporte.EmpleadoReporte.TomarAsistencia(Me.mOp, f.Fecha, RetornarContratoListChecked, Me.CtlSeccion1.ParametroDet)
    End If
  End Sub

  Public Function RetornarEmpleadoListChecked() As EmpleadoList
    Dim Empleados As EmpleadoList
    If mesEmpleado Then
      Empleados = mEmpleados.ListaSeleccionadas
    Else
      Empleados = mContratos.ListaEmpleadosSeleccionados
    End If
    Return Empleados
  End Function

  Public Function RetornarContratoListChecked(ByVal _patrono As Patrono) As ContratoList
    If rdopersact.Checked Then
      _patrono = CtlPatrono1.Patrono
    End If
    Dim Contratos As ContratoList
    If mesEmpleado Then
      Contratos = mEmpleados.ListaContratoActivoSeleccionados(_patrono)
    Else
      Contratos = mContratos.ListaSeleccionadas
    End If
    Return Contratos
  End Function

  Public Function RetornarUltimoContratoListChecked(ByVal _patrono As Patrono) As ContratoList
    If rdopersact.Checked Then
      _patrono = CtlPatrono1.Patrono
    End If
    Dim Contratos As ContratoList
    If mesEmpleado Then
      Contratos = mEmpleados.ListaUltimoContratoSeleccionados(_patrono)
    Else
      Contratos = mContratos.ListaSeleccionadas
    End If
    Return Contratos
  End Function

  Private Sub lnkresumen_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkresumen.LinkClicked
    Me.pnlresumen.Visible = False
    Me.pnlbusqueda.Visible = True
  End Sub

  Private Sub BindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBindingSource.CurrentChanged
    CambiarEmpleado()
  End Sub

  Private Sub CtlPatrono1_CambioPatrono() Handles CtlPatrono1.CambioPatrono
    CambiarPatrono(True)
    Me.CtlTipoContrato1.Op = mOp
    Me.CtlTipoContrato1.Patrono = Me.CtlPatrono1.Patrono
    Me.CtlTipoContrato1.llenar_datos()
  End Sub

  Private Sub chkDiscapacidad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDiscapacidad.CheckedChanged
    Select Case chkDiscapacidad.CheckState
      Case CheckState.Indeterminate
        Me.chkDiscapacidad.Text = "No tomar en cuenta discapacidad"
      Case CheckState.Checked
        Me.chkDiscapacidad.Text = "Empleados con discapacidad"
      Case CheckState.Unchecked
        Me.chkDiscapacidad.Text = "Empleados sin discapacidad"
    End Select
  End Sub

  Private Sub CambiarEmpleado(Optional _forzar As Boolean = False)
    If _forzar OrElse Not mesLlenandoLista Then
      RaiseEvent CambioEmpleado(Me, Nothing)
    End If
  End Sub

  Private Sub CambiarPatrono(Optional _forzar As Boolean = False)
    RaiseEvent CambioPatrono(Me, Nothing)
  End Sub

  Public Event CambioFuenteDatos As EventHandler

  Private Sub BindingSource_DataSourceChanged(sender As Object, e As EventArgs) Handles ListBindingSource.DataSourceChanged
    RaiseEvent CambioFuenteDatos(Me, Nothing)
  End Sub
End Class
