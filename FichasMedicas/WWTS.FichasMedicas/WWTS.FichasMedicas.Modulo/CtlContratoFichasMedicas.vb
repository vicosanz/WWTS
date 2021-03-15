Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports WWTS.Roles.Modulo
Imports WWTS.FichasMedicas.Reglas

Public Class CtlContratoFichasMedicas
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

        Me.cbotipoliq.OperadorDatos = mOp
        Me.cbotipoliq.Parametro = Enumerados.EnumParametros.TipoLiquidacion
        Me.cbotipoliq.Llenar_Datos()

        Me.cbotiposalida.OperadorDatos = mOp
        Me.cbotiposalida.Parametro = Enumerados.EnumParametros.TipoSalida
        Me.cbotiposalida.Llenar_Datos()

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
    If _contratos IsNot Nothing Then
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
        'chkDescontarir.Enabled = Restriccion.Restri_VerConfidencial

        Me.pnlrubros.Enabled = Restriccion.Restri_VerConfidencial

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
      Exit Sub
    End If
    Me.tb.Enabled = True

    If ModoenSeleccion Then
      Me.HeaderStrip2.Enabled = contrato.EsNuevo
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

    Me.cbotipoliq.ParametroDet = contrato.PardetTipoLiquidacion
    Me.cbotiposalida.ParametroDet = contrato.PardetMotivoSalida

    If contrato.PardetAdjuntoEvaluacion Is Nothing Then
      contrato.PardetAdjuntoEvaluacion = New WWTSParametroDet(contrato.OperadorDatos, Enumerados.EnumParametros.Adjuntos, True)
    End If


    Selecc_Codigo = contrato.Selecc_Codigo
    If Not ModoenSeleccion Then
      If contrato.Selecc_Codigo = 0 Then
      Else
      End If
    End If

    mostrar_fichasmedicas()
  End Sub


  Private mFichasMedicas As FichaMedicaList
  Sub mostrar_fichasmedicas()
    If ContratoSeleccionado Is Nothing Then
      Me.BSFichas.DataSource = Nothing
      Exit Sub
    End If
    Me.BSFichas.DataSource = GetType(FichaMedica)
    mFichasMedicas = FichaMedicaList.ObtenerLista(ContratoSeleccionado.OperadorDatos, ContratoSeleccionado)
    Dim mitemssortfichamedica As New Infoware.Reglas.SortedView(mFichasMedicas)
    BSFichas.DataSource = mitemssortfichamedica
    Me.DataGridView3.AutoDiscover()
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

                Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion,
                                              String.Format("{1}.{2}.{3} {0} Cambio de {4}/{5}/{6}/{7} a {8}/{9}/{10}/{11}",
                                              mEmpleado.NombreCompleto, ContratoSeleccionado.Entida_Codigo,
                                              ContratoSeleccionado.Patron_Codigo, ContratoSeleccionado.Contra_Secuencia,
                                              DepartamentoAnterior.PardetPadre.Pardet_Descripcion,
                                              DepartamentoAnterior.Pardet_Descripcion, AreaAnterior.Pardet_Descripcion,
                                              cargoanteriordescr, ContratoSeleccionado.PardetDepartamento.PardetPadre.Pardet_Descripcion,
                                              ContratoSeleccionado.PardetDepartamento.Pardet_Descripcion,
                                              ContratoSeleccionado.PardetArea.Pardet_Descripcion, cargoactualdescr))
              End If
            End If
          End If
          Me.llenar_datos()
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
    contrato.PardetTipoLiquidacion = Me.cbotipoliq.ParametroDet
    contrato.PardetMotivoSalida = Me.cbotiposalida.ParametroDet

    contrato.Selecc_Codigo = Selecc_Codigo
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    NuevoContrato()
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    GuardarContrato(Me.tvcontratos.SelectedNode)
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If MsgBox("¿Está seguro que desea eliminar el contrato?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Eliminar()
    Me.llenar_datos()
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



  Private Sub btneliminarficha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarficha.Click
    If BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar esta ficha?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSFichas.Current, FichaMedica).Eliminar Then
      MsgBox("Error al eliminar ficha", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó Ficha {0} {1}", CType(BSFichas.Current, FichaMedica).Contrato.EmpleadoString, CType(BSFichas.Current, FichaMedica).PardetTipoFicha.Descripcion, CType(BSFichas.Current, FichaMedica).Contrato.Entida_Codigo, CType(BSFichas.Current, FichaMedica).Contrato.Patron_Codigo, CType(BSFichas.Current, FichaMedica).Contrato.Contra_Secuencia))
    mostrar_fichasmedicas()
  End Sub

  Private Sub DataGridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.DoubleClick
    If Not ModoenSeleccion Then
      abrir_ficha()
    End If
  End Sub

  Private Sub DataGridView3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView3.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        abrir_ficha()
      Case Else
        e.Handled = False
    End Select

  End Sub

  Sub abrir_ficha()
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoFichaMedica(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.FichasMedicas)
    f.FichaMedica = CType(BSFichas.Current, FichaMedica)
    f.ShowDialog()

    mostrar_fichasmedicas()
  End Sub


  Private Sub ContratosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

  Private Sub CertificadosDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If ContratoSeleccionado Is Nothing OrElse ContratoSeleccionado.EsNuevo Then
      If ContratoSeleccionado.EsNuevo Then
        MsgBox("No está guardado el contrato. Primero guarde el contrato antes de imprimir.", MsgBoxStyle.Information, "Información")
      End If
      Exit Sub
    End If
    If Not Me.tvcontratos.SelectedNode Is Nothing Then
      Dim contratos As New ContratoList
      contratos.Add(ContratoSeleccionado)
      WWTS.Roles.Reglas.ExcelReporte.ContratoReporte.Imprimir_certificados(contratos)
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Impresion, String.Format("Imprimió certificado de trabajo de {0}", ContratoSeleccionado.Empleado.NombreCompleto))
    End If
  End Sub

  Private Sub btnabrirficha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirficha.Click
    abrir_ficha()
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

  Private Sub LnkSeleccion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
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

  Private Sub CtlPatronoCombo1_CambioPatrono() Handles CtlPatronoCombo1.CambioPatrono
    Me.CtlTipoContrato1.Op = mOp
    Me.CtlTipoContrato1.Patrono = CtlPatronoCombo1.Patrono
    Me.CtlTipoContrato1.llenar_datos()
  End Sub

  Private Sub AperturaCuentaBancacriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

  Private Sub AutorizaciónClaveIESSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

  Private Sub FichaPreocupacionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaPreocupacionalToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Preocupacional)
  End Sub

  Private Sub NuevaFicha(TipoFicha As Enumerados.TiposFichasMedicas)
    Dim nuevo As New FichaMedica(mOp, True) With {
          .PardetTipoFicha = New WWTSParametroDet(mOp, Enumerados.EnumParametros.TipoFichaMedica, TipoFicha),
          .Contrato = ContratoSeleccionado
        }
    BSFichas.Add(nuevo)
    BSFichas.MoveLast()
    abrir_ficha()
  End Sub

  Private Sub FichaOcupacionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaOcupacionalToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Ocupacional)
  End Sub

  Private Sub FichaDeReintegroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaDeReintegroToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Reingreso)
  End Sub

  Private Sub FichaDeRetiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaDeRetiroToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Retiro)
  End Sub

  Private Sub btnimprimirficha_DropDownOpening(sender As Object, e As EventArgs) Handles btnimprimirficha.DropDownOpening
    btnpag1.Enabled = False
    btnpag2.Enabled = False
    btnpag3.Enabled = False
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    btnpag1.Enabled = True
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional OrElse ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      btnpag2.Enabled = True
      btnpag3.Enabled = True
    End If
  End Sub

  Private Sub btnpag1_Click(sender As Object, e As EventArgs) Handles btnpag1.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaPreocupacionalPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaOcupacionalPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Reingreso Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaReingresolPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Retiro Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaRetiroPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
  End Sub

  Private Sub btnpag2_Click(sender As Object, e As EventArgs) Handles btnpag2.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaPreocupacionalPag2(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 2))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaOcupacionalPag2(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 2))
    End If
  End Sub

  Private Sub btnpag3_Click(sender As Object, e As EventArgs) Handles btnpag3.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaPreocupacionalPag3(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 3))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaOcupacionalPag3(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 3))
    End If
  End Sub
End Class
