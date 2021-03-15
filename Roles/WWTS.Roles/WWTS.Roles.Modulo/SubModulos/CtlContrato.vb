Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas

Public Class CtlContrato
  Private mUsuario As Infoware.Reglas.General.Usuario = Nothing
  Public Property Usuario() As Infoware.Reglas.General.Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Infoware.Reglas.General.Usuario)
      mUsuario = value
    End Set
  End Property

  Private mCargando As Boolean = False

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      'Me.CtlPatrono1.Op = mOp
      Me.CtlPatronoCombo1.Op = mOp
      If mOp IsNot Nothing Then
        mCargando = True

        Me.cboSubCentroCosto.OperadorDatos = mOp
        Me.cboSubCentroCosto.Parametro = Enumerados.EnumParametros.SubCentroCosto
        Me.cboSubCentroCosto.Llenar_Datos()

        Me.cboSeccion.OperadorDatos = mOp
        Me.cboSeccion.Parametro = Enumerados.EnumParametros.Seccion
        Me.cboSeccion.Llenar_Datos()

        Me.cboDepartamento.OperadorDatos = mOp
        Me.cboDepartamento.Parametro = Enumerados.EnumParametros.Departamento
        Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)

        Me.CtlArea1.Op = mOp
        Try
          Me.CtlArea1.Seccion = cboSeccion.ParametroDet
          Me.CtlArea1.Departamento = cboDepartamento.ParametroDet
          Me.CtlArea1.llenar_datos()
        Catch ex As Exception
        End Try

        Me.CtlCargo1.Op = mOp
        Try
          Me.CtlCargo1.Area = CtlArea1.Area
          Me.CtlCargo1.llenar_datos()
        Catch ex As Exception
        End Try

        'Me.CtlPatrono1.llenar_datos(mUsuario)
        Me.CtlPatronoCombo1.llenar_datos(mUsuario)

        Me.CtlTipoContrato1.Op = mOp
        Me.CtlTipoContrato1.Patrono = CtlPatronoCombo1.Patrono
        Me.CtlTipoContrato1.llenar_datos()

        Me.ComboBoxEmpresa1.Op = mOp
        Me.ComboBoxEmpresa1.Llenar_datos()

        Me.cbotipoliq.OperadorDatos = mOp
        Me.cbotipoliq.Parametro = Enumerados.EnumParametros.TipoLiquidacion
        Me.cbotipoliq.Llenar_Datos()

        Me.cbotiposalida.OperadorDatos = mOp
        Me.cbotiposalida.Parametro = Enumerados.EnumParametros.TipoSalida
        Me.cbotiposalida.Llenar_Datos()

        Me.ComboBoxEstadoContrato.OperadorDatos = mOp
        Me.ComboBoxEstadoContrato.Parametro = Enumerados.EnumParametros.EstadoContrato
        Me.ComboBoxEstadoContrato.Llenar_Datos()

        'tb.TabPages(0).Size = New Size(0, 0)
        'tb.TabPages.Remove(TabPage7)

        mCargando = False
      End If
    End Set
  End Property

  Public ReadOnly Property ContratoSeleccionado() As Contrato
    Get
      If Me.tvcontratos.SelectedNode Is Nothing Then
        Return Nothing
      Else
        Return CType(Me.tvcontratos.SelectedNode.Tag, Contrato)
      End If
    End Get
  End Property

  Private mEmpleado As Empleado = Nothing

  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(ByVal Value As Empleado)
      mEmpleado = Value

      Me.llenar_datos()
    End Set
  End Property

  Public WriteOnly Property Contrato As Contrato
    Set(ByVal value As Contrato)
      Dim _contratos As New ContratoList

      _contratos.Add(value)
      llenar_contratos(_contratos)

    End Set
  End Property

  Public Sub llenar_datos()
    Me.tvcontratos.Nodes.Clear()
    MapearContratoaForma(Nothing)
    If mEmpleado Is Nothing Then
      Me.HeaderStrip1.Enabled = False
    Else
      Me.HeaderStrip1.Enabled = True
      Dim Contratos As ContratoList
      If mUsuario Is Nothing Then
        Contratos = ContratoList.ObtenerLista(Me.mOp, Me.mEmpleado)
      Else
        Contratos = ContratoList.ObtenerListaxPatronoUsuario(Me.mOp, Me.mEmpleado, mUsuario)
      End If
      llenar_contratos(Contratos)
    End If
  End Sub

  Sub llenar_contratos(ByVal _contratos As ContratoList)
    Me.btnnuevo.Enabled = False
    If _contratos IsNot Nothing Then
      Me.btnnuevo.Enabled = True
      For Each _contrato As Contrato In _contratos
        Dim node As New TreeNode
        node.ImageIndex = IIf(_contrato.esCerrado, 0, 1)
        node.SelectedImageIndex = node.ImageIndex
        node.Text = _contrato.Tipocontrato.TipCon_Descripcion.Substring(0, 3) & "-" & _contrato.Contra_Desde
        node.Tag = _contrato
        Me.tvcontratos.Nodes.Add(node)
      Next
      If tvcontratos.Nodes.Count > 0 Then
        tvcontratos.SelectedNode = Me.tvcontratos.Nodes(0)
      End If
      'MapearContratoaForma(ContratoSeleccionado)
    End If
  End Sub

  Sub NuevoContrato()
    If Empleado.Emplea_FichaRoja Then
      MsgBox("Empleado tiene actualmente ficha roja", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Dim contrato As New Contrato(mOp, Me.mEmpleado)
    Dim node As New TreeNode
    node.ImageIndex = 1
    node.SelectedImageIndex = 1
    node.Text = "[Nuevo]"
    node.Tag = contrato
    Me.tvcontratos.Nodes.Add(node)
    Me.tvcontratos.SelectedNode = node

    Me.chkDescontarir.Enabled = True

    'Me.CtlPatrono1.llenar_datos(mUsuario)
    Me.CtlPatronoCombo1.llenar_datos(mUsuario)
  End Sub

  Sub Eliminar()
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Try
        If Not ContratoSeleccionado.Eliminar Then
          Throw New Exception(ContratoSeleccionado.OperadorDatos.MsgError)
        Else
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("Eliminó contrato {0}", ContratoSeleccionado.Empleado.NombreCompleto))
        End If
        Me.tvcontratos.SelectedNode.Remove()
        If tvcontratos.Nodes.Count > 0 Then
          Me.tvcontratos.SelectedNode = Me.tvcontratos.Nodes(0)
        End If
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End Try
    End If
  End Sub

  Private Sub tvcontratos_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvcontratos.AfterSelect
    If Not e.Node Is Nothing Then
      If tvcontratos.SelectedNode.Text = "[Nuevo]" Then

        chkDescontarir.Enabled = True

        CtlCargo1.Enabled = True
        CtlTipoContrato1.Enabled = True
        dtfecdesde.Enabled = True
        dtfechasta.Enabled = True
        Cerrado.Enabled = True
        cbotipoliq.Enabled = True
        cbotiposalida.Enabled = True
        'CtlPatrono1.Enabled = True
        CtlPatronoCombo1.Enabled = True
      Else
        Me.pnlotros.Visible = Restriccion.Restri_VerConfidencial
        'chkDescontarir.Enabled = Restriccion.Restri_VerConfidencial

        Me.pnlrubros.Enabled = Restriccion.Restri_VerConfidencial
        Me.pnlLlamadas.Enabled = Restriccion.Restri_VerConfidencial
        Me.CtlPeriodoVacacion1.Enabled = Restriccion.Restri_VerConfidencial
        Me.pnlLicencias.Enabled = Restriccion.Restri_VerConfidencial
        Me.pnldatos.Enabled = Restriccion.Restri_VerConfidencial
        'CtlCargo1.Enabled = Restriccion.Restri_VerConfidencial
        'CtlTipoContrato1.Enabled = Restriccion.Restri_VerConfidencial
        'dtfecdesde.Enabled = Restriccion.Restri_VerConfidencial
        'dtfechasta.Enabled = Restriccion.Restri_VerConfidencial
        'Cerrado.Enabled = Restriccion.Restri_VerConfidencial
        'cbotipoliq.Enabled = Restriccion.Restri_VerConfidencial
        'cbotiposalida.Enabled = Restriccion.Restri_VerConfidencial
        'CtlPatrono1.Enabled = Restriccion.Restri_VerConfidencial
        'CtlPatronoCombo1.Enabled = Restriccion.Restri_VerConfidencial
      End If

      MapearContratoaForma(ContratoSeleccionado)
    End If
  End Sub

  Dim cargoanterior As Cargo = Nothing
  Dim DepartamentoAnterior As ParametroDet = Nothing
  Dim AreaAnterior As ParametroDet = Nothing

  Sub MapearContratoaForma(ByVal contrato As Contrato)
    Me.HeaderStrip1.Enabled = True
    If contrato Is Nothing OrElse mEmpleado.EsNuevo Then
      Me.tb.Enabled = False
      Me.btneliminar.Enabled = False
      Me.btnguardar.Enabled = False
      Me.btnnuevo.Enabled = False 'Not (mEmpleado Is Nothing OrElse mEmpleado.EsNuevo)
      Me.btnimprimir.Enabled = False
      Exit Sub
    End If
    Me.tb.Enabled = True

    Me.btnnuevo.Enabled = Not ModoenSeleccion
    Me.btneliminar.Enabled = Not ModoenSeleccion
    Me.btnimprimir.Enabled = Not ModoenSeleccion
    Me.btnguardar.Enabled = True
    If ModoenSeleccion Then
      Me.btnguardar.Enabled = contrato.EsNuevo
      Me.CtlAdjunto1.Enabled = contrato.EsNuevo
      Me.HeaderStrip2.Enabled = contrato.EsNuevo
      Me.HeaderStrip3.Enabled = contrato.EsNuevo
    End If

    Me.cboSubCentroCosto.ParametroDet = contrato.PardetSubCentroCosto

    Me.dtfecdesde.Value = contrato.Contra_Desde
    Me.dtfechasta.Value = contrato.Contra_Hasta
    Me.Cerrado.Checked = contrato.esCerrado

    Try
      Me.cboSeccion.ParametroDet = contrato.PardetDepartamento.PardetPadre
    Catch ex As Exception
    End Try

    Me.cboDepartamento.ParametroDet = contrato.PardetDepartamento

    Try
      Me.CtlArea1.Seccion = contrato.PardetDepartamento.PardetPadre
      Me.CtlArea1.Departamento = contrato.PardetDepartamento
      Me.CtlArea1.llenar_datos()
      Dim _area As New Area(mOp, contrato.Parame_Departamento, contrato.Pardet_Departamento, contrato.Parame_Area, contrato.Pardet_Area)
      Me.CtlArea1.Area = _area
      Llenar_cargos()
    Catch ex As Exception
    End Try

    Try
      If Not contrato.EsNuevo Then
        Me.CtlCargo1.Cargo = contrato.Cargo
      Else
        Dim _cargo As New Cargo(mOp, cboDepartamento.ParametroDet.Parame_Codigo, cboDepartamento.ParametroDet.Pardet_Secuencia, CtlArea1.Area.Parame_Area, CtlArea1.Area.Pardet_Area, contrato.Cargo_Secuencia)
        Me.CtlCargo1.Cargo = _cargo
      End If
    Catch ex As Exception
    End Try

    DepartamentoAnterior = contrato.PardetDepartamento
    AreaAnterior = contrato.PardetArea
    cargoanterior = contrato.Cargo

    Me.cboSeccion.Enabled = Not ModoenSeleccion
    Me.cboDepartamento.Enabled = Not ModoenSeleccion
    Me.CtlArea1.Enabled = Not ModoenSeleccion

    'Me.CtlPatrono1.llenar_datos(mUsuario)
    Me.CtlPatronoCombo1.llenar_datos(mUsuario)
    'Me.CtlPatrono1.Patrono = contrato.Patrono
    Me.CtlPatronoCombo1.Patrono = contrato.Patrono

    Me.CtlTipoContrato1.Patrono = contrato.Patrono
    Me.CtlTipoContrato1.llenar_datos()
    Me.CtlTipoContrato1.TipoContrato = contrato.Tipocontrato

    Me.chkafiliess.Checked = contrato.Contra_afiliess
    Me.cbotipoliq.ParametroDet = contrato.PardetTipoLiquidacion
    Me.cbotiposalida.ParametroDet = contrato.PardetMotivoSalida

    Me.chkDescontarir.Checked = contrato.Contra_DescontarImpuestoRenta

    Me.chkpertsind.Checked = contrato.Contra_esSindicalista
    Me.chkjuicio.Checked = contrato.Contra_esJuicioLaboral
    Me.txtmotsal.Text = contrato.Contra_MotivoSalida
    Me.chkcertvot.Checked = contrato.Contra_certvot
    Me.chkcertsalud.Checked = contrato.Contra_certifsalud
    Me.chkrecordpolicial.Checked = contrato.Contra_recordpolicial
    Me.chkreglamentointerno.Checked = contrato.Contra_reglamentointerno
    Me.txtobservacion.Text = contrato.Contra_Observacion
    If contrato.Sucursal IsNot Nothing Then
      Me.ComboBoxEmpresa1.Empresa = contrato.Sucursal.Empresa
      Me.ComboBoxSucursal1.Sucursal = contrato.Sucursal
    End If
    Me.dtfecafiliess.Value = contrato.Contra_FechaAfiliacionIESS
    Me.txtevatrimestral.Value = contrato.Contra_EvaluacionTrimestral
    Me.txtevaanual.Value = contrato.Contra_EvaluacionAnual
    If contrato.PardetAdjuntoEvaluacion Is Nothing Then
      contrato.PardetAdjuntoEvaluacion = New WWTSParametroDet(contrato.OperadorDatos, Enumerados.EnumParametros.Adjuntos, True)
    End If
    Me.CtlAdjunto1.ParameAdjunto = contrato.PardetAdjuntoEvaluacion

    Me.ComboBoxEstadoContrato.ParametroDet = contrato.PardetEstadoContrato

    Selecc_Codigo = contrato.Selecc_Codigo
    If Not ModoenSeleccion Then
      If contrato.Selecc_Codigo = 0 Then
        Me.LnkSeleccion.Visible = False
      Else
        Me.LnkSeleccion.Visible = True
      End If
    End If

    CtlPeriodoVacacion1.Contrato = contrato
    chkMensualizarD3.Checked = contrato.Contra_MensualizarD3
    chkMensualizarD4.Checked = contrato.Contra_MensualizarD4
    chkMensualizarVac.Checked = contrato.Contra_MensualizarVac
    chkMensualizarFR.Checked = contrato.Contra_MensualizarFondoReserva

    mostrar_rubro()
    mostrar_llamadosatencion()
    mostrar_licencia()
    'mostrar_vacacion()
    mostrar_auditoria()
    mostrar_sueldos()
  End Sub

  Private mLlamadas As LlamadaAtencionList
  Sub mostrar_llamadosatencion()
    If ContratoSeleccionado Is Nothing Then
      Me.BSLlamadaAtencion.DataSource = Nothing
      Exit Sub
    End If
    Me.BSLlamadaAtencion.DataSource = GetType(WWTS.Roles.Reglas.LlamadaAtencion)
    mLlamadas = LlamadaAtencionList.ObtenerLista(ContratoSeleccionado.OperadorDatos, ContratoSeleccionado)
    Dim mitemssort As New Infoware.Reglas.SortedView(mLlamadas)
    BSLlamadaAtencion.DataSource = mitemssort
    Me.DataGridView2.AutoDiscover()
  End Sub

  Private mRubros As RubroList
  Sub mostrar_rubro()
    If ContratoSeleccionado Is Nothing Then
      Me.BSrubro.DataSource = Nothing
      Exit Sub
    End If
    Me.BSrubro.DataSource = GetType(Rubro)
    Dim _Parametro_Padre As New WWTSParametroDet(ContratoSeleccionado.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.DefinidoEnContrato)
    mRubros = RubroList.ObtenerListaxContrato(ContratoSeleccionado.OperadorDatos, ContratoSeleccionado, _Parametro_Padre, Nothing)
    Dim mitemssortrubro As New Infoware.Reglas.SortedView(mRubros)
    BSrubro.DataSource = mitemssortrubro
    Me.DataGridView3.AutoDiscover()
  End Sub

  Private mSueldos As SueldoMensualList
  Sub mostrar_sueldos()
    If ContratoSeleccionado Is Nothing Then
      Me.BSSueldos.DataSource = Nothing
      Exit Sub
    End If
    Me.BSSueldos.DataSource = GetType(SueldoMensual)
    mSueldos = SueldoMensualList.ObtenerLista(ContratoSeleccionado.OperadorDatos, ContratoSeleccionado)
    Dim mitemssortsueldos As New Infoware.Reglas.SortedView(mSueldos)
    BSSueldos.DataSource = mitemssortsueldos
    Me.dgsueldos.AutoDiscover()
  End Sub

  Private Sub Cerrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrado.CheckedChanged
    Me.pnlcierre.Visible = Cerrado.Checked
  End Sub

  Private guardo As Boolean = True
  Function GuardarContrato(ByVal nodo As TreeNode) As Boolean
    Try
      guardo = True
      If Not nodo Is Nothing Then
        If Not nodo.Tag Is Nothing Then
          Dim nuevo As Boolean = ContratoSeleccionado.EsNuevo
          MapearFormaaContrato(ContratoSeleccionado)
          If Not ContratoSeleccionado.Guardar Then
            Throw New Exception(ContratoSeleccionado.OperadorDatos.MsgError)
          Else
            Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{2}.{3}.{4} {0} contrato {1}", IIf(nuevo, "Creó", "Modificó"), mEmpleado.NombreCompleto, ContratoSeleccionado.Entida_Codigo, ContratoSeleccionado.Patron_Codigo, ContratoSeleccionado.Contra_Secuencia))
            If Not nuevo Then
              If (DepartamentoAnterior.Pardet_Padre <> ContratoSeleccionado.PardetDepartamento.PardetPadre.Pardet_Secuencia) _
                OrElse (DepartamentoAnterior.Pardet_Secuencia <> ContratoSeleccionado.Pardet_Departamento) _
                OrElse (AreaAnterior.Pardet_Secuencia <> ContratoSeleccionado.Pardet_Area) _
                OrElse (cargoanterior IsNot Nothing AndAlso cargoanterior.Cargo_Secuencia <> Me.CtlCargo1.Cargo.Cargo_Secuencia) Then

                Dim cargoanteriordescr As String = IIf(cargoanterior Is Nothing, "", cargoanterior.Cargo_Descripcion)
                Dim cargoactualdescr As String = IIf(ContratoSeleccionado.Cargo Is Nothing, "", ContratoSeleccionado.Cargo.Cargo_Descripcion)

                Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, _
                                              String.Format("{1}.{2}.{3} {0} Cambio de {4}/{5}/{6}/{7} a {8}/{9}/{10}/{11}", _
                                              mEmpleado.NombreCompleto, ContratoSeleccionado.Entida_Codigo, _
                                              ContratoSeleccionado.Patron_Codigo, ContratoSeleccionado.Contra_Secuencia, _
                                              DepartamentoAnterior.PardetPadre.Pardet_Descripcion, _
                                              DepartamentoAnterior.Pardet_Descripcion, AreaAnterior.Pardet_Descripcion, _
                                              cargoanteriordescr, ContratoSeleccionado.PardetDepartamento.PardetPadre.Pardet_Descripcion, _
                                              ContratoSeleccionado.PardetDepartamento.Pardet_Descripcion, _
                                              ContratoSeleccionado.PardetArea.Pardet_Descripcion, cargoactualdescr))
              End If
            End If
          End If
          Me.llenar_datos()
          Me.mostrar_auditoria()
          Return True
        End If
      End If
      Return True
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      guardo = False
      Return False
    End Try
  End Function

  Sub MapearFormaaContrato(ByRef contrato As Contrato)
    If contrato Is Nothing Then
      Exit Sub
    End If

    contrato.PardetSubCentroCosto = Me.cboSubCentroCosto.ParametroDet

    contrato.Contra_Desde = Me.dtfecdesde.Value
    contrato.Contra_Hasta = Me.dtfechasta.Value
    contrato.esCerrado = Me.Cerrado.Checked
    contrato.Tipocontrato = Me.CtlTipoContrato1.TipoContrato

    If cboDepartamento.ParametroDet IsNot Nothing Then
      contrato.PardetDepartamento = Me.cboDepartamento.ParametroDet
    Else
      MsgBox("Debe seleccionar un departamento", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    If CtlArea1.Area IsNot Nothing Then
      contrato.PardetArea = Me.CtlArea1.Area.PardetArea
    Else
      MsgBox("Debe seleccionar un area", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    If CtlCargo1.Cargo IsNot Nothing Then
      contrato.Cargo_Secuencia = Me.CtlCargo1.Cargo.Cargo_Secuencia
    Else
      contrato.Cargo = Nothing
      'MsgBox("Debe seleccionar un cargo", MsgBoxStyle.Critical, "Error")
      'Exit Sub
    End If

    If contrato.EsNuevo Then
      'contrato.Patrono = Me.CtlPatrono1.Patrono
      contrato.Patrono = Me.CtlPatronoCombo1.Patrono
    Else
      'contrato.PatronoNuevo = Me.CtlPatrono1.Patrono
      contrato.PatronoNuevo = Me.CtlPatronoCombo1.Patrono
    End If
    contrato.Contra_afiliess = Me.chkafiliess.Checked
    contrato.PardetTipoLiquidacion = Me.cbotipoliq.ParametroDet
    contrato.PardetMotivoSalida = Me.cbotiposalida.ParametroDet

    contrato.Contra_DescontarImpuestoRenta = Me.chkDescontarir.Checked

    contrato.Contra_esSindicalista = Me.chkpertsind.Checked
    contrato.Contra_esJuicioLaboral = Me.chkjuicio.Checked
    contrato.Contra_MotivoSalida = Me.txtmotsal.Text
    contrato.Contra_certvot = Me.chkcertvot.Checked
    contrato.Contra_certifsalud = Me.chkcertsalud.Checked
    contrato.Contra_recordpolicial = Me.chkrecordpolicial.Checked
    contrato.Contra_reglamentointerno = Me.chkreglamentointerno.Checked
    contrato.Sucursal = Me.ComboBoxSucursal1.Sucursal
    contrato.Contra_FechaAfiliacionIESS = Me.dtfecafiliess.Value
    contrato.Contra_Observacion = Me.txtobservacion.Text
    contrato.Contra_EvaluacionTrimestral = Me.txtevatrimestral.Value
    contrato.Contra_EvaluacionAnual = Me.txtevaanual.Value
    contrato.PardetAdjuntoEvaluacion = Me.CtlAdjunto1.ParameAdjunto

    contrato.PardetEstadoContrato = Me.ComboBoxEstadoContrato.ParametroDet

    contrato.Selecc_Codigo = Selecc_Codigo

    contrato.Contra_MensualizarD3 = chkMensualizarD3.Checked
    contrato.Contra_MensualizarD4 = chkMensualizarD4.Checked
    contrato.Contra_MensualizarVac = chkMensualizarVac.Checked
    contrato.Contra_MensualizarFondoReserva = chkMensualizarFR.Checked
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    NuevoContrato()
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    GuardarContrato(Me.tvcontratos.SelectedNode)
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If MsgBox("¿Está seguro que desea eliminar el contrato?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Eliminar()
    Me.llenar_datos()
  End Sub

  Private Sub CtlTipoContrato1_CambioItem(sender As Object, e As System.EventArgs) Handles CtlTipoContrato1.CambioItem
    Me.chkMensualizarD3.Checked = Me.CtlTipoContrato1.TipoContrato.TipCon_MensualizarD3
    Me.chkMensualizarD4.Checked = Me.CtlTipoContrato1.TipoContrato.TipCon_MensualizarD4
    Me.chkMensualizarVac.Checked = Me.CtlTipoContrato1.TipoContrato.TipCon_MensualizarVac
    Me.chkMensualizarFR.Checked = Me.CtlTipoContrato1.TipoContrato.TipCon_MensualizarFondoReserva
  End Sub

  Private Sub CtlTipoContrato1_CambioTipoContrato() Handles CtlTipoContrato1.CambioTipoContrato

    If Not CtlTipoContrato1.TipoContrato Is Nothing Then
      Select Case CtlTipoContrato1.TipoContrato.Pardet_TipoContrato
        Case Enumerados.enumTipoContrato.PorHoras

        Case Enumerados.enumTipoContrato.Temporada, Enumerados.enumTipoContrato.Fijo

        Case Else

      End Select
    End If
  End Sub

  Private mRestriccion As Restriccion
  Public ReadOnly Property Restriccion() As Restriccion
    Get
      If mRestriccion Is Nothing Then
        mRestriccion = CType(Me.ParentForm, FrmFormaBase).Sistema.Restricciones.Buscar(Enumerados.EnumOpciones.Personal)
      End If
      Return mRestriccion
    End Get
  End Property

  Private Sub ComboBoxEmpresa1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxEmpresa1.CambioItem
    Me.ComboBoxSucursal1.Empresa = Me.ComboBoxEmpresa1.Empresa
    Me.ComboBoxSucursal1.Llenar_datos()
  End Sub

  Private Sub chkafiliess_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkafiliess.CheckedChanged
    dtfecafiliess.Visible = Me.chkafiliess.Checked
  End Sub

  Private Sub btnnuevollamado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevollamado.Click
    If ContratoSeleccionado.EsNuevo Then
      If MsgBox("Para continuar debe guardar los cambios, ¿Desea guardar los cambios ahora?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
        btnguardar.PerformClick()
      Else
        Exit Sub
      End If
    End If

    If guardo Then
      Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
      Dim _llamada As LlamadaAtencion = New LlamadaAtencion(_sistema.OperadorDatos, True)
      _llamada.Contrato = ContratoSeleccionado

      Dim f As New FrmLlamadaAtencion(_sistema, Enumerados.EnumOpciones.Personal)
      f.LlamadaAtencion = _llamada
      f.ShowDialog()

      mostrar_llamadosatencion()
      mostrar_auditoria()
    End If
  End Sub

  Private Sub btnnuevorubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevorubro.Click
    If ContratoSeleccionado.EsNuevo Then
      If MsgBox("Para continuar debe guardar los cambios, ¿Desea guardar los cambios ahora?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
        btnguardar.PerformClick()
      Else
        Exit Sub
      End If
    End If

    If guardo Then
      Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
      Dim _parametro As New WWTSParametroDet(_sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.DefinidoEnContrato)
      Dim _rubro As Rubro = New Rubro(_sistema.OperadorDatos, True)
      _rubro.Contrato = ContratoSeleccionado

      Dim f As New FrmRubro(_sistema, Enumerados.EnumOpciones.Personal)
      f.Parametro = _parametro
      f.Rubro = _rubro
      f.ShowDialog()

      mostrar_rubro()
      mostrar_auditoria()
    End If
  End Sub

  Private Sub btneliminarllamado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarllamado.Click
    If BSLlamadaAtencion.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar este llamado de atención?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSLlamadaAtencion.Current, LlamadaAtencion).Eliminar Then
      MsgBox("Error al eliminar llamado de atención", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó Llamado de atención {0} {1}", CType(BSLlamadaAtencion.Current, LlamadaAtencion).Contrato.EmpleadoString, CType(BSLlamadaAtencion.Current, LlamadaAtencion).PardetTipoLlamadoString, CType(BSLlamadaAtencion.Current, LlamadaAtencion).Contrato.Entida_Codigo, CType(BSLlamadaAtencion.Current, LlamadaAtencion).Contrato.Patron_Codigo, CType(BSLlamadaAtencion.Current, LlamadaAtencion).Contrato.Contra_Secuencia))
    mostrar_llamadosatencion()
    mostrar_auditoria()
  End Sub

  Private Sub btneliminarrubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarrubro.Click
    If BSrubro.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar este rubro?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSrubro.Current, Rubro).Eliminar Then
      MsgBox("Error al eliminar rubro", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó Rubro {0} {1} de {5}", CType(BSrubro.Current, Rubro).Contrato.EmpleadoString, CType(BSrubro.Current, Rubro).PardetTipoRubroString, CType(BSrubro.Current, Rubro).Contrato.Entida_Codigo, CType(BSrubro.Current, Rubro).Contrato.Patron_Codigo, CType(BSrubro.Current, Rubro).Contrato.Contra_Secuencia, CType(BSrubro.Current, Rubro).Total))
    mostrar_rubro()
    mostrar_auditoria()
  End Sub

  Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
    If Not ModoenSeleccion Then
      abrir_llamado()
    End If
  End Sub

  Private Sub DataGridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.DoubleClick
    If Not ModoenSeleccion Then
      abrir_rubro()
    End If
  End Sub

  Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        abrir_llamado()
      Case Else
        e.Handled = False
    End Select

  End Sub

  Private Sub DataGridView3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView3.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        abrir_rubro()
      Case Else
        e.Handled = False
    End Select

  End Sub

  Sub abrir_llamado()
    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    If Me.BSLlamadaAtencion.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmLlamadaAtencion(_sistema, Enumerados.EnumOpciones.Personal)
    f.LlamadaAtencion = CType(BSLlamadaAtencion.Current, LlamadaAtencion)
    f.ShowDialog()

    mostrar_llamadosatencion()
    mostrar_auditoria()
  End Sub

  Sub abrir_rubro()
    If Me.BSrubro.Current Is Nothing Then
      Exit Sub
    End If

    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim _parametro As New WWTSParametroDet(_sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.DefinidoEnContrato)
    Dim f As New FrmRubro(_sistema, Enumerados.EnumOpciones.Personal)
    f.Parametro = _parametro
    f.Rubro = CType(BSrubro.Current, Rubro)
    f.ShowDialog()

    mostrar_rubro()
    mostrar_auditoria()
  End Sub

  Private Sub btnimprimirllamado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirllamado.Click
    If Me.BSLlamadaAtencion.Current Is Nothing Then
      Exit Sub
    End If

    Roles.Reglas.ExcelReporte.LlamadaAtencion.Imprimir_llamadaatencion(Me.BSLlamadaAtencion.Current)
  End Sub

  Private Sub ContratosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContratosToolStripMenuItem.Click
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato antes de imprimirlo.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Dim contratos As New ContratoList
      contratos.Add(ContratoSeleccionado)
      'Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_contratos(contratos)
      General.Reglas.Utilerias.CombinarCorrespondencia(ContratoSeleccionado, TipoContratoFormato.ObtenerFormato(ContratoSeleccionado.Tipocontrato, Enumerados.enumFormatoxTipoContrato.Contrato))
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió contrato de {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Private Sub CertificadosDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificadosDeTrabajoToolStripMenuItem.Click
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato antes de imprimir.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Dim contratos As New ContratoList
      contratos.Add(ContratoSeleccionado)
      Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_certificados(contratos)
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió certificado de trabajo de {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Sub mostrar_auditoria()
    If ContratoSeleccionado Is Nothing Then
      Exit Sub
    End If

    Me.DataGridView4.Columns.Clear()
    Me.DataGridView4.ReadOnly = True

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Usuari_Codigo"
    DataGridViewTextBoxColumn1.HeaderText = "Usuario"
    DataGridViewTextBoxColumn1.Width = 90
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Audito_Descripcion"
    DataGridViewTextBoxColumn1.HeaderText = "Descripción"
    DataGridViewTextBoxColumn1.Width = 525
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Audito_FechaHora"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha"
    DataGridViewTextBoxColumn1.Width = 115
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim _auditorias As AuditoriaList
    Dim cadena As String
    cadena = ContratoSeleccionado.Entida_Codigo.ToString.Trim + "." + ContratoSeleccionado.Patron_Codigo.ToString.Trim + "." + ContratoSeleccionado.Contra_Secuencia.ToString.Trim + " "
    _auditorias = AuditoriaList.ObtenerListaxDescripcion(Me.Op, cadena)
    Dim mitemsort As New Infoware.Reglas.SortedView(_auditorias)
    Me.BSauditorias.DataSource = mitemsort
  End Sub

  Private Sub btnabrirrubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirrubro.Click
    If BSrubro.Current Is Nothing Then
      Exit Sub
    End If
    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim _parametro As New WWTSParametroDet(_sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.DefinidoEnContrato)
    Dim f As New FrmRubro(_sistema, Enumerados.EnumOpciones.Personal)
    f.Parametro = _parametro
    f.Rubro = BSrubro.Current
    f.ShowDialog()
    mostrar_rubro()
    mostrar_auditoria()
  End Sub

  Private Sub cboseccion_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.CambioItem
    If Not mCargando Then
      Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)
      Me.CtlArea1.Seccion = cboSeccion.ParametroDet
      Me.CtlArea1.llenar_datos()
    End If
  End Sub

  Sub Llenar_cargos()
    Try
      Dim _area As New Area(mOp, Me.CtlArea1.Area.Parame_Departamento, Me.CtlArea1.Area.Pardet_Departamento, Me.CtlArea1.Area.Parame_Area, Me.CtlArea1.Area.Pardet_Area)
      Me.CtlCargo1.Area = _area
      Me.CtlCargo1.llenar_datos()
    Catch ex As Exception
      Me.CtlCargo1.Cargo = Nothing
    End Try
  End Sub

  Private Sub LnkSeleccion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkSeleccion.LinkClicked
    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim _seleccion As Seleccion = New Seleccion(mOp, Selecc_Codigo)
    Dim f As New FrmMantenimientoSeleccion(_sistema, Enumerados.EnumOpciones.Personal)
    f.ModoenContrato = True
    f.Seleccion = _seleccion
    f.ShowDialog()
  End Sub

  Private mselecc_codigo As Integer = 0
  Public Property Selecc_Codigo() As Integer
    Get
      Return Me.mselecc_codigo
    End Get
    Set(ByVal value As Integer)
      Me.mselecc_codigo = value
    End Set
  End Property

  Private Sub CtlArea1_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlArea1.CambioItem
    If Not mCargando Then
      Llenar_cargos()
    End If
  End Sub

  Private mModoenSeleccion As Boolean = False
  Public Property ModoenSeleccion As Boolean
    Get
      Return mModoenSeleccion
    End Get
    Set(ByVal value As Boolean)
      mModoenSeleccion = value
    End Set
  End Property

  Private mLicencias As LicenciaList
  Sub mostrar_licencia()
    If ContratoSeleccionado Is Nothing Then
      Me.BSLicencia.DataSource = Nothing
      Exit Sub
    End If
    Me.BSLicencia.DataSource = GetType(Licencia)
    mLicencias = LicenciaList.ObtenerListaxContrato(ContratoSeleccionado.OperadorDatos, ContratoSeleccionado)
    Dim mitems As New Infoware.Reglas.SortedView(mLicencias)
    BSLicencia.DataSource = mitems
    Me.DataGridView5.AutoDiscover()
  End Sub

  Private Sub btnnuevolicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevolicencia.Click
    If ContratoSeleccionado.EsNuevo Then
      If MsgBox("Para continuar debe guardar los cambios, ¿Desea guardar los cambios ahora?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
        btnguardar.PerformClick()
      Else
        Exit Sub
      End If
    End If

    If guardo Then
      Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
      Dim _licencia As Licencia = New Licencia(_sistema.OperadorDatos, True)
      _licencia.Contrato = ContratoSeleccionado
      Dim f As New FrmMantenimientoLicencia(_sistema, Enumerados.EnumOpciones.Personal)
      f.Licencia = _licencia
      f.ShowDialog()
      mostrar_licencia()
      'mostrar_vacacion()
    End If
  End Sub

  Private Sub btnabrirlicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirlicencia.Click, DataGridView5.DoubleClick
    If BSLicencia.Current Is Nothing Then
      Exit Sub
    End If
    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim f As New FrmMantenimientoLicencia(_sistema, Enumerados.EnumOpciones.Personal)
    f.Licencia = BSLicencia.Current
    f.ShowDialog()
    mostrar_licencia()
    'mostrar_vacacion()
  End Sub

  Private Sub btneliminarlicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarlicencia.Click
    If BSLicencia.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSLicencia.Current, Licencia).Eliminar Then
      MsgBox("Error al eliminar", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    mostrar_licencia()
  End Sub

  Private Sub cboDepartamento_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.CambioItem
    If Not mCargando Then
      Try
        Me.CtlArea1.Seccion = cboSeccion.ParametroDet
        Me.CtlArea1.Departamento = cboDepartamento.ParametroDet
        Me.CtlArea1.llenar_datos()
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private mVacaciones As BeneficiosSocialesList
  'Sub mostrar_vacacion()
  '  If ContratoSeleccionado Is Nothing Then
  '    Exit Sub
  '  End If

  '  Me.DataGridView6.Columns.Clear()
  '  Me.DataGridView6.ReadOnly = True

  '  Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  '  DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
  '  DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FechaDesde"
  '  DataGridViewTextBoxColumn1.HeaderText = "Fecha Desde"
  '  DataGridViewTextBoxColumn1.Width = 100
  '  Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

  '  DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
  '  DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FechaHasta"
  '  DataGridViewTextBoxColumn1.HeaderText = "Fecha Hasta"
  '  DataGridViewTextBoxColumn1.Width = 100
  '  Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

  '  DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
  '  DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Dias"
  '  DataGridViewTextBoxColumn1.HeaderText = "Días"
  '  DataGridViewTextBoxColumn1.Width = 50
  '  Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

  '  DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
  '  DataGridViewTextBoxColumn1.DataPropertyName = "DiasAcumulados"
  '  DataGridViewTextBoxColumn1.HeaderText = "Días Acumulados"
  '  DataGridViewTextBoxColumn1.Width = 75
  '  Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

  '  Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
  '  DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
  '  DataGridViewTextBoxColumn2.DataPropertyName = "BenSoc_Liquidado"
  '  DataGridViewTextBoxColumn2.HeaderText = "Liquidado"
  '  DataGridViewTextBoxColumn2.Width = 70
  '  Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

  '  mVacaciones = BeneficiosSocialesList.ObtenerListaxContrato(ContratoSeleccionado)
  '  Me.BSVacacion.DataSource = mVacaciones
  'End Sub

  'Private Sub btnnuevovacacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If ContratoSeleccionado.EsNuevo Then
  '    If MsgBox("Para continuar debe guardar los cambios, ¿Desea guardar los cambios ahora?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
  '      btnguardar.PerformClick()
  '    Else
  '      Exit Sub
  '    End If
  '  End If

  '  If guardo Then
  '    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
  '    Dim _vacacion As BeneficiosSociales = New BeneficiosSociales(_sistema.OperadorDatos, True, Nothing, Nothing)
  '    _vacacion.Contrato = ContratoSeleccionado
  '    Dim f As New FrmMantenimientoVacacion(_sistema, Enumerados.EnumOpciones.Personal)
  '    f.Vacacion = _vacacion
  '    f.ShowDialog()
  '    mostrar_vacacion()
  '  End If
  'End Sub

  'Private Sub btnabrirvacacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If BSVacacion.Current Is Nothing Then
  '    Exit Sub
  '  End If
  '  Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
  '  Dim f As New FrmMantenimientoVacacion(_sistema, Enumerados.EnumOpciones.Personal)
  '  f.Vacacion = BSVacacion.Current
  '  f.ShowDialog()
  '  mostrar_vacacion()
  'End Sub

  'Private Sub btneliminarvacacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If BSVacacion.Current Is Nothing Then
  '    Exit Sub
  '  End If
  '  If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
  '    Exit Sub
  '  End If
  '  If Not CType(BSVacacion.Current, BeneficiosSociales).Eliminar Then
  '    MsgBox("Error al eliminar", MsgBoxStyle.Critical, "Error")
  '    Exit Sub
  '  End If
  '  mostrar_vacacion()
  'End Sub

  Private Sub btnnuevomulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevomulta.Click
    If ContratoSeleccionado.EsNuevo Then
      Exit Sub
    End If

    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim _parametro As New WWTSParametroDet(_sistema.OperadorDatos, Enumerados.EnumParametros.Rubro, Enumerados.enumRubro.NoDefinidoEnContrato)
    Dim _rubro As Rubro = New Rubro(_sistema.OperadorDatos, True)
    _rubro.Contrato = ContratoSeleccionado
    _rubro.PardetTipoRubro = New WWTSParametroDet(_sistema.OperadorDatos, Enumerados.EnumParametros.TipoRubro, Enumerados.enumTipoRubroNoDefinidoContrato.Multa)

    Dim f As New FrmRubro(_sistema, Enumerados.EnumOpciones.Personal)
    f.Parametro = _parametro
    f.Rubro = _rubro
    'f.cborubro.ParametroDet = New WWTSParametroDet(_sistema.OperadorDatos, Enumerados.EnumParametros.TipoRubro, 5)
    f.ShowDialog()

  End Sub

  Private Sub btnabrirllamado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirllamado.Click
    If Not ModoenSeleccion Then
      abrir_llamado()
    End If
  End Sub

  Private Sub btnimprimirlicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirlicencia.Click
    If Me.BSLicencia.Current Is Nothing Then
      Exit Sub
    End If

    'Roles.Reglas.ExcelReporte.Licencia.Imprimir_licencia(Me.BSLicencia.Current)
    General.Reglas.Utilerias.CombinarCorrespondencia(Me.BSLicencia.Current, CType(BSLicencia.Current, Licencia).PardetLicencia.Pardet_DatoStr1)
  End Sub

  Private Sub CtlPatronoCombo1_CambioPatrono() Handles CtlPatronoCombo1.CambioPatrono
    Me.CtlTipoContrato1.Op = mOp
    Me.CtlTipoContrato1.Patrono = CtlPatronoCombo1.Patrono
    Me.CtlTipoContrato1.llenar_datos()
  End Sub

  Private Sub AperturaCuentaBancacriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaCuentaBancacriaToolStripMenuItem.Click
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Dim contratos As New ContratoList
      contratos.Add(ContratoSeleccionado)
      'Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_contratos(contratos)
      General.Reglas.Utilerias.CombinarCorrespondencia(ContratoSeleccionado, TipoContratoFormato.ObtenerFormato(ContratoSeleccionado.Tipocontrato, Enumerados.enumFormatoxTipoContrato.AperturaCuenta))
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió apertura cuenta bancaria de {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Private Sub AutorizaciónClaveIESSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorizaciónClaveIESSToolStripMenuItem.Click
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato antes de imprimir.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      'General.Reglas.Utilerias.CombinarCorrespondencia(ContratoSeleccionado, "\\192.168.2.64\carpetacompartida\formatos\modeloautorizacionclave.doc")
      'Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió autorización de clave IESS{0}", ContratoSeleccionado.Empleado.NombreCompleto))
      Dim contratos As New ContratoList
      contratos.Add(ContratoSeleccionado)
      'Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_contratos(contratos)
      General.Reglas.Utilerias.CombinarCorrespondencia(ContratoSeleccionado, TipoContratoFormato.ObtenerFormato(ContratoSeleccionado.Tipocontrato, Enumerados.enumFormatoxTipoContrato.Renuncia))
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió renuncia de {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Private Sub TransferenciaDeSalaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransferenciaDeSalaToolStripMenuItem.Click
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Dim contratos As New ContratoList
      contratos.Add(ContratoSeleccionado)
      'Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_contratos(contratos)
      Dim rutobj As String
      rutobj = "\\192.168.2.100\Sistemas\Formatos\beta\transferencia_sala-wwts.doc"
      General.Reglas.Utilerias.CombinarCorrespondencia(ContratoSeleccionado, rutobj)
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió Tansferencia Sala {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Private Sub TransaccionLaboralToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransaccionLaboralToolStripMenuItem.Click
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_TransaccionLaboral(ContratoSeleccionado)
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió Transacción Laboral {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Private Sub CtlTipoContrato1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CtlTipoContrato1.SelectedIndexChanged

  End Sub

  Private Sub CtlPeriodoVacacion1_Load(sender As System.Object, e As System.EventArgs) Handles CtlPeriodoVacacion1.Load

  End Sub

  Private Sub btnSueldosExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnSueldosExcel.Click
    Me.dgsueldos.Excel(EnumSalida.Excel)
  End Sub

  Private Sub btn_FondosReserva_Click(sender As System.Object, e As System.EventArgs) Handles btn_FondosReserva.Click
    Dim f As New Infoware.Reporteador.FrmLista(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Reporte = New Infoware.Reporteador.Reporte(Op, "REPR_Roles$Fondos_de_reserva")
    
    f.Valores = New Object() {CType(Me.ParentForm, FrmFormaBase).Sistema.Usuario.Usuari_Codigo, ContratoSeleccionado.Entida_Codigo, ContratoSeleccionado.Patron_Codigo, ContratoSeleccionado.Contra_Secuencia}
    f.ShowDialog()

  End Sub

  Private Sub CtlCargo1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CtlCargo1.SelectedIndexChanged

  End Sub
End Class
