Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
'Imports WWTS.Controles.Base
Imports WWTS.General.Reglas
Imports Infoware.Controles.General

Public Class CtlEmpleado
  Private mOperadorDatos As OperadorDatos
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      If value IsNot Nothing Then
        Me.ComboBoxTipoSangre.OperadorDatos = value
        Me.ComboBoxTipoSangre.Parametro = Enumerados.EnumParametros.TipoSangre
        Me.ComboBoxTipoSangre.Llenar_Datos()

        Me.CtlUbicacion1.Op = value
        Me.CtlUbicacion1.llenar_datos()

        Me.ComboBoxTipoEmpleado.OperadorDatos = value
        Me.ComboBoxTipoEmpleado.Parametro = Enumerados.EnumParametros.TipoEmpleado
        Me.ComboBoxTipoEmpleado.Llenar_Datos()

        Me.ComboBoxFormaPagoRol.OperadorDatos = value
        Me.ComboBoxFormaPagoRol.Parametro = Enumerados.EnumParametros.FormaPagoRol
        Me.ComboBoxFormaPagoRol.Llenar_Datos()

        Me.ComboBoxBanco.OperadorDatos = value
        Me.ComboBoxBanco.Parametro = Enumerados.EnumParametros.Banco
        Me.ComboBoxBanco.Llenar_Datos()

        Me.ComboBoxTipoCtaBancaria.OperadorDatos = value
        Me.ComboBoxTipoCtaBancaria.Parametro = Enumerados.EnumParametros.TipoCtaBan
        Me.ComboBoxTipoCtaBancaria.Llenar_Datos()

        Me.ComboBoxDiscapacidad.OperadorDatos = value
        Me.ComboBoxDiscapacidad.Parametro = Enumerados.EnumParametros.TipoDiscapacidad
        Me.ComboBoxDiscapacidad.Llenar_Datos()

        Me.ComboBoxSeguroCorporativo.OperadorDatos = value
        Me.ComboBoxSeguroCorporativo.Parametro = Enumerados.EnumParametros.SeguroCorporativo
        Me.ComboBoxSeguroCorporativo.Llenar_Datos()

        Me.cboSectorDomicilio.OperadorDatos = value
        Me.cboSectorDomicilio.Parametro = Enumerados.EnumParametros.SectorDomicilio
        Me.cboSectorDomicilio.Llenar_Datos()

        Me.ComboBoxBachiller.OperadorDatos = value
        Me.ComboBoxBachiller.Parametro = Enumerados.EnumParametros.Bachiller
        Me.ComboBoxBachiller.Llenar_Datos()

        Me.ComboBoxTitulo.OperadorDatos = value
        Me.ComboBoxTitulo.Parametro = Enumerados.EnumParametros.TituloSuperior
        Me.ComboBoxTitulo.Llenar_Datos()

      End If
    End Set
  End Property

  Private mEmpleado As Empleado = Nothing
  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(ByVal value As Empleado)
      mEmpleado = value
      'If value IsNot Nothing Then
      Llenar_datos()
      'End If
    End Set
  End Property

  Public Sub Llenar_datos()
    If mEmpleado Is Nothing Then
      Me.Enabled = False
      Exit Sub
    End If
    Me.Enabled = True
    Me.CtlEntidadNatural1.TipoEntidadNatural = CtlEntidadNatural.enumTipoEntidadNatural.Empleado
    Me.CtlEntidadNatural1.Entidad = mEmpleado.Entidadnatural.Entidad

    Me.txtprimaria.Text = mEmpleado.Emplea_Primaria
    Me.txtprianio.Text = mEmpleado.Emplea_Primariaanio
    Me.txtsecundaria.Text = mEmpleado.Emplea_Secundaria
    Me.txtsecanio.Text = mEmpleado.Emplea_Secundariaanio
    Me.txtbachiller.Text = mEmpleado.Emplea_Bachiller
    Me.txtsuperior.Text = mEmpleado.Emplea_Superior
    Me.txtsupanio.Text = mEmpleado.Emplea_Superioranio
    Me.txttitulo.Text = mEmpleado.Emplea_Titulo
    Me.txtcursos.Text = mEmpleado.Emplea_Cursos
    Me.txtrefper.Text = mEmpleado.Emplea_ReferPersonales
    Me.txtreflab.Text = mEmpleado.Emplea_ReferLaborales

    Me.ComboBoxTipoSangre.ParametroDet = mEmpleado.PardetTipoSangre
    Me.CtlUbicacion1.Parroquia = mEmpleado.PardetParroquia
    Me.txtavisoemer.Text = mEmpleado.Emplea_Emergencia
    Me.txtenfermedad.Text = mEmpleado.Emplea_Enfermedad
    Me.chkFichaRoja.Checked = mEmpleado.Emplea_FichaRoja
    Me.chkexclfam.Checked = mEmpleado.Emplea_ExcluirFamiliares
    Me.ComboBoxTipoEmpleado.ParametroDet = mEmpleado.PardetTipoEmpleado
    Me.ComboBoxFormaPagoRol.ParametroDet = mEmpleado.PardetFormaPagoRol
    Me.ComboBoxBanco.ParametroDet = mEmpleado.PardetBanco
    Me.ComboBoxTipoCtaBancaria.ParametroDet = mEmpleado.PardetTipoCtaBancaria
    Me.ComboBoxDiscapacidad.ParametroDet = mEmpleado.PardetTipoDiscapacidad
    Me.ComboBoxSeguroCorporativo.ParametroDet = mEmpleado.PardetSeguroCorporativo
    Me.chkdiscaauditiva.Checked = mEmpleado.Emplea_DiscaAuditiva
    Me.chkdiscafisica.Checked = mEmpleado.Emplea_DiscaFisica
    Me.chkdiscaintelectual.Checked = mEmpleado.Emplea_DiscaIntelectual
    Me.chkdiscalinguistica.Checked = mEmpleado.Emplea_DiscaLenguaje
    Me.chkdiscapsicologica.Checked = mEmpleado.Emplea_DiscaPsicologica
    Me.chkdiscavisual.Checked = mEmpleado.Emplea_DiscaVisual

    Me.txtnumcta.Text = mEmpleado.Emplea_NumeroCuentaBancaria
    Me.txtpresquirog.Value = mEmpleado.Emplea_DesctoPrestQuirogMensual
    Me.txtjubpatronal.Value = mEmpleado.Emplea_JubilacionPatronal
    Me.dtfecafiliess.Value = mEmpleado.Emplea_FechaAfiliacionIESS

    Me.CtlFotoPersona1.Imagen = Me.Empleado.Entidadnatural.Entidad.Entida_Imagen
    If Not Empleado.EsNuevo AndAlso Me.CtlFotoPersona1.Imagen Is Nothing Then
      Dim _codempleado As String = String.Empty
      For Each _id As EntidadIdentificacion In Me.Empleado.Entidadnatural.Entidad.Identificaciones
        If _id.Pardet_TipoidentificacionEnum = Enumerados.enumTipoIdentificacion.CodigoEmpleado Then
          _codempleado = _id.Identi_Numero.Trim
        End If
      Next
      Dim _archivofoto As String = My.Computer.FileSystem.CombinePath((New WWTSParametroDet(mEmpleado.OperadorDatos, Enumerados.EnumParametros.RutasRoles, Enumerados.enumRutas.Fotos)).Pardet_DatoStr1, _codempleado + ".jpg")
      If Not String.IsNullOrWhiteSpace(_codempleado) AndAlso My.Computer.FileSystem.FileExists(_archivofoto) Then
        Me.CtlFotoPersona1.ArchivoImagen = _archivofoto
      End If
    End If

    Me.cboSectorDomicilio.ParametroDet = mEmpleado.PardetSectorDomicilio
    Me.txtAspiracionSalarial.Value = mEmpleado.Emplea_AspiracionSalarial

    If mEmpleado.PardetAdjuntoArchivos Is Nothing Then
      mEmpleado.PardetAdjuntoArchivos = New WWTSParametroDet(Empleado.OperadorDatos, Enumerados.EnumParametros.Adjuntos, True)
    End If
    Me.CtlAdjunto1.ParameAdjunto = mEmpleado.PardetAdjuntoArchivos

    If mEmpleado.PardetBachiller IsNot Nothing Then
      'chckBachiller.Checked = True
      Me.ComboBoxBachiller.ParametroDet = mEmpleado.PardetBachiller
    End If

    If mEmpleado.PardetTitulo IsNot Nothing Then
      'chckTitulo.Checked = True
      Me.ComboBoxTitulo.ParametroDet = mEmpleado.PardetTitulo
      'Me.txtEspecializacion.Text = mEmpleado.Emplea_TituloEspealizacion
    End If

    If Me.txtbachiller.Text <> String.Empty Then
      chckBachiller.Checked = True
    End If

    If Me.txttitulo.Text <> String.Empty Then
      chckTitulo.Checked = True
    End If


    Actualizar_cargas()
    mostrar_Aplicaciones()
    mostrar_ContratosTerminados()
    mostrar_SeleccionDet()
  End Sub

  Sub Actualizar_cargas()
    If mOperadorDatos Is Nothing Then
      Exit Sub
    End If

    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompletoPariente"
    DataGridViewTextBoxColumn1.HeaderText = "Nombre de Persona"
    DataGridViewTextBoxColumn1.Width = 200
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "TipoCargaString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo de carga"
    DataGridViewTextBoxColumn1.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "EdadPariente"
    DataGridViewTextBoxColumn1.HeaderText = "Edad (a�os)"
    DataGridViewTextBoxColumn1.Width = 125
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "CarEmp_estaSeguroCorporativo"
    DataGridViewTextBoxColumn2.HeaderText = "Seguro M�dico Corporativo"
    DataGridViewTextBoxColumn2.Width = 100
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    Me.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.CargasxEmpleado)
    Dim mitemssort As New Infoware.Reglas.SortedView(mEmpleado.CargasxEmpleados)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Public Sub Mapear_datos()
    Me.CtlEntidadNatural1.Mapear_datos()
    mEmpleado.Entidadnatural.Entidad = Me.CtlEntidadNatural1.Entidad

    mEmpleado.Emplea_Primaria = Me.txtprimaria.Text
    mEmpleado.Emplea_Primariaanio = Me.txtprianio.Text
    mEmpleado.Emplea_Secundaria = Me.txtsecundaria.Text
    mEmpleado.Emplea_Secundariaanio = Me.txtsecanio.Text
    'mEmpleado.Emplea_Bachiller = Me.txtbachiller.Text
    mEmpleado.Emplea_Superior = Me.txtsuperior.Text
    mEmpleado.Emplea_Superioranio = Me.txtsupanio.Text
    'mEmpleado.Emplea_Titulo = Me.txttitulo.Text
    mEmpleado.Emplea_Cursos = Me.txtcursos.Text
    mEmpleado.Emplea_ReferPersonales = Me.txtrefper.Text
    mEmpleado.Emplea_ReferLaborales = Me.txtreflab.Text

    mEmpleado.PardetTipoSangre = Me.ComboBoxTipoSangre.ParametroDet
    mEmpleado.PardetParroquia = Me.CtlUbicacion1.Parroquia
    mEmpleado.Emplea_Emergencia = Me.txtavisoemer.Text
    mEmpleado.Emplea_Enfermedad = Me.txtenfermedad.Text
    mEmpleado.Emplea_FichaRoja = Me.chkFichaRoja.Checked
    mEmpleado.Emplea_ExcluirFamiliares = Me.chkexclfam.Checked
    mEmpleado.PardetTipoEmpleado = Me.ComboBoxTipoEmpleado.ParametroDet
    mEmpleado.PardetFormaPagoRol = Me.ComboBoxFormaPagoRol.ParametroDet
    mEmpleado.PardetBanco = Me.ComboBoxBanco.ParametroDet
    mEmpleado.PardetTipoCtaBancaria = Me.ComboBoxTipoCtaBancaria.ParametroDet
    mEmpleado.PardetTipoDiscapacidad = Me.ComboBoxDiscapacidad.ParametroDet
    mEmpleado.PardetSeguroCorporativo = Me.ComboBoxSeguroCorporativo.ParametroDet
    mEmpleado.Emplea_DiscaAuditiva = Me.chkdiscaauditiva.Checked
    mEmpleado.Emplea_DiscaFisica = Me.chkdiscafisica.Checked
    mEmpleado.Emplea_DiscaIntelectual = Me.chkdiscaintelectual.Checked
    mEmpleado.Emplea_DiscaLenguaje = Me.chkdiscalinguistica.Checked
    mEmpleado.Emplea_DiscaPsicologica = Me.chkdiscapsicologica.Checked
    mEmpleado.Emplea_DiscaVisual = Me.chkdiscavisual.Checked

    mEmpleado.Emplea_NumeroCuentaBancaria = Me.txtnumcta.Text
    mEmpleado.Emplea_DesctoPrestQuirogMensual = Me.txtpresquirog.Value
    mEmpleado.Emplea_JubilacionPatronal = Me.txtjubpatronal.Value
    mEmpleado.Emplea_FechaAfiliacionIESS = Me.dtfecafiliess.Value

    mEmpleado.PardetSectorDomicilio = Me.cboSectorDomicilio.ParametroDet
    mEmpleado.PardetAdjuntoArchivos = Me.CtlAdjunto1.ParameAdjunto
    mEmpleado.Emplea_AspiracionSalarial = Me.txtAspiracionSalarial.Value

    If chckBachiller.Checked Then
      mEmpleado.PardetBachiller = Me.ComboBoxBachiller.ParametroDet
      mEmpleado.Emplea_Bachiller = Me.txtbachiller.Text
    Else
      mEmpleado.PardetBachiller = Nothing
      mEmpleado.Emplea_Bachiller = String.Empty
    End If

    If chckTitulo.Checked Then
      mEmpleado.PardetTitulo = Me.ComboBoxTitulo.ParametroDet
      mEmpleado.Emplea_Titulo = Me.txttitulo.Text
      mEmpleado.Emplea_TituloEspealizacion = Me.txtEspecializacion.Text
    Else
      mEmpleado.PardetTitulo = Nothing
      mEmpleado.Emplea_Titulo = String.Empty
      mEmpleado.Emplea_TituloEspealizacion = ""
    End If
  End Sub

  Private Sub btnnuevacarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevacarga.Click
    If mEmpleado.EsNuevo Then
      If Not (MsgBox("Para continuar debe guardar los cambios, �Desea guardar los cambios ahora?", MsgBoxStyle.YesNo, "Informaci�n") = MsgBoxResult.Yes AndAlso Guardar_datos()) Then
        Exit Sub
      End If
    End If

    Dim _carga As New CargasxEmpleado(mOperadorDatos, mEmpleado, True)
    Dim f As New FrmCarga(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListadoEmpleados)
    f.CargaEmpleado = _carga
    f.Direccion = IMantenimiento.Accion.Ingreso
    If f.ShowDialog() = DialogResult.OK Then
      mEmpleado.CargasxEmpleados.Add(_carga)
      Actualizar_cargas()
    End If
  End Sub

  Private Sub btnabrircarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrircarga.Click
    If Me.ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmCarga(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListadoEmpleados)
    f.CargaEmpleado = Me.ListBindingSource.Current
    f.Direccion = IMantenimiento.Accion.Ingreso
    If f.ShowDialog() = DialogResult.OK Then
      Me.DataGridView1.Refresh()
    End If
  End Sub

  Private Sub btneliminarcarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcarga.Click
    If Me.ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmCarga(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListadoEmpleados)
    f.CargaEmpleado = Me.ListBindingSource.Current
    f.Direccion = IMantenimiento.Accion.Eliminacion
    If f.ShowDialog() = DialogResult.OK AndAlso ListBindingSource.Current IsNot Nothing Then
      Me.ListBindingSource.RemoveCurrent()
      Me.DataGridView1.Refresh()
    End If
  End Sub

  Private Sub CtlFotoPersona1_CambioImagen(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlFotoPersona1.CambioImagen
    If (Empleado Is Nothing) Then
      Exit Sub
    End If
    Try
      Me.Empleado.Entidadnatural.Entidad.ArchivoImagen = Me.CtlFotoPersona1.ArchivoImagen
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CtlEntidadNatural1_Repetido(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlEntidadNatural1.Repetido
    Me.Empleado.Entidadnatural = Me.CtlEntidadNatural1.Entidad.Entidadnatural
  End Sub

  Private Sub btnNuevoAplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoAplicacion.Click
    'If mEmpleado.EsNuevo Then
    '  If MsgBox("Para continuar debe guardar los cambios, � Desea guardar ?", MsgBoxStyle.YesNo, "Informaci�n") = MsgBoxResult.Yes Then
    '    Guardar_datos()
    '  Else
    '    Exit Sub
    '  End If
    'End If

    'If guardo Then
    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim _aplicacionempleado As AplicacionEmpleado = New AplicacionEmpleado(_sistema.OperadorDatos, True)
    _aplicacionempleado.Empleado = Empleado

    Dim f As New FrmAplicacion(_sistema, True)
    f.AplicacionEmpleado = _aplicacionempleado
    f.Direccion = IMantenimiento.Accion.Ingreso
    If f.ShowDialog() = DialogResult.OK Then
      For Each _aplicacion As AplicacionEmpleado In mEmpleado.Aplicaciones
        If _aplicacion.Pardet_Area = _aplicacionempleado.Pardet_Area Then
          Exit Sub
        End If
      Next
      mEmpleado.Aplicaciones.Add(_aplicacionempleado)
    End If
    mostrar_Aplicaciones()
    'End If
  End Sub

  Private mAplicacionEmpleadoList As AplicacionEmpleadoList
  Sub mostrar_Aplicaciones()
    Me.BSaplicacion.DataSource = GetType(AplicacionEmpleadoList)
    mAplicacionEmpleadoList = mEmpleado.Aplicaciones 'AplicacionEmpleadoList.ObtenerListaxEmpleado(mOperadorDatos, Empleado)
    BSaplicacion.DataSource = mAplicacionEmpleadoList
    Me.DataGridView2.AutoDiscover()
  End Sub

  Private Sub btnEliminarAplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAplicacion.Click
    If Me.BSaplicacion.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("�Est� seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    mEmpleado.AplicacionesEliminadas.Add(Me.BSaplicacion.Current)
    Me.BSaplicacion.RemoveCurrent()
    'If Not CType(BSaplicacion.Current, AplicacionEmpleado).Eliminar() Then
    '  MsgBox("Error al eliminar", MsgBoxStyle.Critical, "Error")
    '  Exit Sub
    'End If
    mostrar_Aplicaciones()
  End Sub

  Sub mostrar_ContratosTerminados()

    Me.DataGridView4.Columns.Clear()
    Me.DataGridView4.ReadOnly = True

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Contra_Desde"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha Desde"
    DataGridViewTextBoxColumn1.Width = 100
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Contra_Hasta"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha Hasta"
    DataGridViewTextBoxColumn1.Width = 100
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "MotivoSalidaString"
    DataGridViewTextBoxColumn1.HeaderText = "Motivo Salida"
    DataGridViewTextBoxColumn1.Width = 200
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoLiquidacionString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo Finiquito"
    DataGridViewTextBoxColumn1.Width = 125
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Contra_Observacion"
    DataGridViewTextBoxColumn1.HeaderText = "Observaciones"
    DataGridViewTextBoxColumn1.Width = 200
    Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim Contratos As ContratoList
    Contratos = ContratoList.ObtenerListaContratosTerminados(mOperadorDatos, Empleado)
    Dim itemsort As New Infoware.Reglas.SortedView(Contratos)
    BScontratosterminados.DataSource = itemsort
  End Sub

  Sub mostrar_SeleccionDet()
    Dim SeleccionDets As SeleccionDetList
    SeleccionDets = SeleccionDetList.ObtenerLista(mOperadorDatos, Empleado)
    Dim itemsort As New Infoware.Reglas.SortedView(SeleccionDets)
    BSselecciondetalle.DataSource = itemsort
    Me.DataGridView3.AutoDiscover()
  End Sub

  'Private guardo As Boolean = True
  Function Guardar_datos() As Boolean
    Try
      'guardo = True
      Mapear_datos()
      Dim _esnuevo As Boolean = mEmpleado.EsNuevo
      If mEmpleado.Guardar() Then
        Return True
      End If
    Catch ex As Exception
      MsgBox("No se puede guardar Empleado" & Environment.NewLine & ex.Message & Environment.NewLine & mOperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub chckBachiller_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckBachiller.CheckedChanged
    If chckBachiller.Checked Then
      Me.ComboBoxBachiller.Enabled = True
      Me.txtbachiller.Enabled = True
    Else
      Me.ComboBoxBachiller.Enabled = False
      Me.txtbachiller.Enabled = False
    End If
  End Sub

  Private Sub chckTitulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckTitulo.CheckedChanged
    If chckTitulo.Checked Then
      Me.ComboBoxTitulo.Enabled = True
      Me.txttitulo.Enabled = True
      Me.txtEspecializacion.Enabled = True
    Else
      Me.ComboBoxTitulo.Enabled = False
      Me.txttitulo.Enabled = False
      Me.txtEspecializacion.Enabled = False
    End If
  End Sub
End Class
