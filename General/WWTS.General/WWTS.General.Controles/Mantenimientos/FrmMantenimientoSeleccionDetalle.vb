Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports Infoware.Controles.General

Public Class FrmMantenimientoSeleccionDetalle

#Region "Parametros"
  Public Property SeleccionDetalles() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mSeleccionDet As SeleccionDet = Nothing
  Public Property SeleccionDet() As SeleccionDet
    Get
      Return mSeleccionDet
    End Get
    Set(ByVal value As SeleccionDet)
      mSeleccionDet = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _SeleccionDetList As New SeleccionDetList
        _SeleccionDetList.Add(mSeleccionDet)
        MyBase.ListBindingSource.DataSource = GetType(SeleccionDet)
        MyBase.ListBindingSource.DataSource = _SeleccionDetList
      End If
    End Set
  End Property

  Private mCargando As Boolean = False

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    Dim mArea = New Area(Sistema.OperadorDatos, mSeleccionDet.Seleccion.Parame_Departamento, mSeleccionDet.Seleccion.Pardet_Departamento, mSeleccionDet.Seleccion.Parame_Area, mSeleccionDet.Seleccion.Pardet_Area)
    Me.CtlSeleccion1.llenar_datos(mArea)

    mSeleccionDet = SeleccionDetalles.Current
    If mSeleccionDet Is Nothing Then
      Exit Sub
    End If

    Try
      Me.CtlBuscaReclutamiento1.EntidadNatural = mSeleccionDet.Empleado.Entidadnatural
    Catch ex As Exception
    End Try

    Me.CtlSeleccion1.Seleccion = mSeleccionDet.Seleccion
    Me.dtfecha.Value = mSeleccionDet.SelDet_FechaHora
    Me.txtObservaciones.Text = mSeleccionDet.SelDet_Observaciones
    Me.cboResultadoSeleccion.ParametroDet = mSeleccionDet.PardetResultadoSeleccion
    Me.checkaprobadorrhh.Checked = mSeleccionDet.SelDet_esAprobadoRRHH
    Me.checkaprobadodpto.Checked = mSeleccionDet.SelDet_esAprobadoDpto

    Dim _parametro As New WWTSParametroDet(Sistema.OperadorDatos, mSeleccionDet.Seleccion.PardetDepartamento.Parame_Padre, mSeleccionDet.Seleccion.PardetDepartamento.Pardet_Padre)
    Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, _parametro)
    Me.cboDepartamento.ParametroDet = mSeleccionDet.Seleccion.PardetDepartamento
    Me.cboDepartamento.Enabled = False

    Me.CtlBuscaReclutamiento1.Enabled = mSeleccionDet.EsNuevo
    Me.CtlSeleccion1.Enabled = False

    Me.CtlBuscaReclutamiento1.Area = mArea

    Me.PuedeEliminar = Not mSeleccionDet.EsNuevo

    If ModoenContrato Then
      dtfecha.Enabled = Not ModoenContrato
      txtObservaciones.Enabled = Not ModoenContrato
      cboResultadoSeleccion.Enabled = Not ModoenContrato
      checkaprobadorrhh.Enabled = Not ModoenContrato
      checkaprobadodpto.Enabled = Not ModoenContrato
      HeaderStrip1.Enabled = Not ModoenContrato
    End If

    Try
      Me.ComboBoxSeccion.ParametroDet = mSeleccionDet.PardetDepartamentoCargo.PardetPadre
    Catch ex As Exception
    End Try

    Me.ComboBoxDepartamento.ParametroDet = mSeleccionDet.PardetDepartamentoCargo

    Try
      Me.CtlAreaSeleccion1.Seccion = mSeleccionDet.PardetDepartamentoCargo.PardetPadre
      Me.CtlAreaSeleccion1.Departamento = mSeleccionDet.PardetDepartamentoCargo
      Me.CtlAreaSeleccion1.llenar_datos()
      mArea = New Area(Sistema.OperadorDatos, mSeleccionDet.Parame_DepartamentoCargo, mSeleccionDet.Pardet_DepartamentoCargo, mSeleccionDet.Parame_AreaCargo, mSeleccionDet.Pardet_AreaCargo)
      Me.CtlAreaSeleccion1.Area = mArea
    Catch ex As Exception
    End Try

    Try
      Me.CtlCargoSeleccion1.Area = CtlAreaSeleccion1.Area
      Me.CtlCargoSeleccion1.llenar_datos(CtlAreaSeleccion1.Area)
      Dim _cargo As New Cargo(Sistema.OperadorDatos, mSeleccionDet.Parame_DepartamentoCargo, mSeleccionDet.Pardet_DepartamentoCargo, mSeleccionDet.Parame_AreaCargo, mSeleccionDet.Pardet_AreaCargo, mSeleccionDet.Cargo_Secuencia)
      CtlCargoSeleccion1.Cargo = _cargo
    Catch ex As Exception
    End Try

    ComboBoxSeccion.Enabled = mSeleccionDet.EsNuevo Or Restriccion.Restri_VerConfidencial
    ComboBoxDepartamento.Enabled = mSeleccionDet.EsNuevo Or Restriccion.Restri_VerConfidencial
    CtlAreaSeleccion1.Enabled = mSeleccionDet.EsNuevo Or Restriccion.Restri_VerConfidencial
    CtlCargoSeleccion1.Enabled = mSeleccionDet.EsNuevo Or Restriccion.Restri_VerConfidencial

    If Not SeleccionDet.EsNuevo Then
      Label7.Text = mSeleccionDet.Cargo_EmpleadoActual
    End If

    mostrar_SeleccionTest()

    If Not mSeleccionDet.Seleccion.Selecc_Estado Then
      Estado_Cerrado()
    End If
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoSeleccionDetalle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mSeleccionDet.EsNuevo
    If _esnuevo AndAlso SeleccionDetalles.Current IsNot Nothing Then
      SeleccionDetalles.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Eventos"
  Private Sub FrmMantenimientoSeleccionDetalle_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _SeleccionDet As SeleccionDet = New SeleccionDet(Sistema.OperadorDatos, True)
    e.NewObject = _SeleccionDet
  End Sub

  Private Sub FrmMantenimientoSeleccionDetalle_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoSeleccionDetalle_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mSeleccionDet.Selecc_Codigo = CtlSeleccion1.Seleccion.Selecc_Codigo

    If CtlBuscaReclutamiento1.EntidadNatural Is Nothing Then
      Throw New Exception("Debe seleccionar un candidato primero")
    End If
    mSeleccionDet.Entida_Codigo = CtlBuscaReclutamiento1.EntidadNatural.Entida_Codigo

    mSeleccionDet.SelDet_FechaHora = dtfecha.Value
    mSeleccionDet.SelDet_Observaciones = txtObservaciones.Text
    mSeleccionDet.PardetResultadoSeleccion = cboResultadoSeleccion.ParametroDet
    mSeleccionDet.SelDet_esAprobadoRRHH = checkaprobadorrhh.Checked
    mSeleccionDet.SelDet_esAprobadoDpto = checkaprobadodpto.Checked

    mSeleccionDet.PardetDepartamentoCargo = ComboBoxDepartamento.ParametroDet
    mSeleccionDet.Area = CtlAreaSeleccion1.Area
    mSeleccionDet.Cargo_Secuencia = CtlCargoSeleccion1.Cargo.Cargo_Secuencia
    mSeleccionDet.Cargo_EmpleadoActual = Label7.Text
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_datos()
      Dim _esnuevo As Boolean = mSeleccionDet.EsNuevo
      If Not mSeleccionDet.Cargo_EmpleadoActual.Contains("*** Libre ***") Then
        'MsgBox("No existe empleado ocupando ese cargo", MsgBoxStyle.Information, "Información")
        Throw New Exception("Existe empleado ocupando el cargo que solicita la selección")
        'guardo = False
        'Return False
      End If
      If mSeleccionDet.Guardar() Then
        'guardo = True
        'For Each _selecciontest As SeleccionTest In BSTest
        '  '_selecciontest.EsNuevo = _esnuevo
        '  _selecciontest.Entida_Codigo = mSeleccionDet.Entida_Codigo
        '  _selecciontest.Guardar()
        'Next
        Return True
      Else
        'MsgBox("No se puede guardar el detalle de selección" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        Throw New Exception("No se puedo guardar el detalle de selección" & Environment.NewLine & mSeleccionDet.OperadorDatos.MsgError)
        'guardo = False
        'Return False
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      'guardo = False
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoArea_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If SeleccionDetalles.Current IsNot Nothing AndAlso mSeleccionDet.Eliminar() Then
      If SeleccionDetalles.Count > 1 Then
        SeleccionDetalles.RemoveCurrent()
      End If
      Me.Close()
    Else
      MsgBox("No se puede eliminar detalle de selección" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoSeleccionDetalle_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoSeleccionDetalle_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoSeleccionDetalle_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoSeleccionDetalle_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
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

  Private Sub FrmMantenimientoSeleccionDetalle_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Selección Detalle"

    Me.PuedeGuardaryNuevo = False
    Me.PuedeMover = False

    Me.CtlSeleccion1.Op = Sistema.OperadorDatos

    Me.cboResultadoSeleccion.OperadorDatos = Sistema.OperadorDatos
    Me.cboResultadoSeleccion.Parametro = Enumerados.EnumParametros.ResultadoSeleccion
    Me.cboResultadoSeleccion.Llenar_Datos()

    Me.CtlBuscaReclutamiento1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaReclutamiento1.llenar_datos()
    Me.CtlBuscaReclutamiento1.btnadd.Visible = False

    Me.cboDepartamento.OperadorDatos = Sistema.OperadorDatos
    Me.cboDepartamento.Parametro = Enumerados.EnumParametros.Departamento

    Me.ComboBoxSeccion.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxSeccion.Parametro = Enumerados.EnumParametros.Seccion
    Me.ComboBoxSeccion.Llenar_Datos()

    Me.ComboBoxDepartamento.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxDepartamento.Parametro = Enumerados.EnumParametros.Departamento
    Me.ComboBoxDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, ComboBoxSeccion.ParametroDet)

    Me.CtlAreaSeleccion1.Op = Sistema.OperadorDatos

    Try
      Me.CtlAreaSeleccion1.Seccion = ComboBoxSeccion.ParametroDet
      Me.CtlAreaSeleccion1.Departamento = ComboBoxDepartamento.ParametroDet
      Me.CtlAreaSeleccion1.llenar_datos()
    Catch ex As Exception
    End Try

    Me.CtlCargoSeleccion1.Op = Sistema.OperadorDatos
    Try
      Me.CtlCargoSeleccion1.Area = CtlAreaSeleccion1.Area
      Me.CtlCargoSeleccion1.llenar_datos(CtlAreaSeleccion1.Area)
    Catch ex As Exception
    End Try

    Label7.Text = " "
  End Sub
#End Region

  Private mModoenContrato As Boolean = False
  Public Property ModoenContrato As Boolean
    Get
      Return mModoenContrato
    End Get
    Set(ByVal value As Boolean)
      mModoenContrato = value
    End Set
  End Property

  Private mSeleccionTestList As SeleccionTestList
  Sub mostrar_SeleccionTest()
    Me.BSTest.DataSource = GetType(SeleccionTestList)
    mSeleccionTestList = SeleccionDet.testlist 'SeleccionTestList.ObtenerListaxArea(SeleccionDet, mSeleccionDet.Seleccion.PardetArea)
    For Each _test As SeleccionTest In mSeleccionTestList
      If _test.Puntaje = (-1) Then
        _test.EsNuevo = True
      End If
    Next
    BSTest.DataSource = mSeleccionTestList
    Me.DataGridView1.AutoDiscover()
  End Sub

  'Private guardo As Boolean = True
  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    'If mSeleccionDet.EsNuevo Then
    '  If MsgBox("Para continuar debe guardar los cambios, ¿ Desea guardar ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
    '    Guardar_datos()
    '  Else
    '    Exit Sub
    '  End If
    'End If

    'If guardo Then
    Dim _selecciontest As SeleccionTest = New SeleccionTest(Sistema.OperadorDatos, True)
    _selecciontest.SeleccionDet = SeleccionDet

    Dim f As New FrmTest(Sistema, True)
    f.SeleccionTest = _selecciontest
    f.Direccion = IMantenimiento.Accion.Ingreso
    'f.ShowDialog()
    If f.ShowDialog() = DialogResult.OK Then
      For Each _test As SeleccionTest In SeleccionDet.testlist
        If _test.Pardet_SeleccionTest = _selecciontest.Pardet_SeleccionTest Then
          Exit Sub
        End If
      Next
      SeleccionDet.testlist.Add(_selecciontest)
    End If
    mostrar_SeleccionTest()
    'End If
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If Me.BSTest.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    SeleccionDet.testlisteliminadas.Add(Me.BSTest.Current)
    Me.BSTest.RemoveCurrent()
    'If Not CType(BSTest.Current, SeleccionTest).Eliminar() Then
    '  MsgBox("Error al eliminar", MsgBoxStyle.Critical, "Error")
    '  Exit Sub
    'End If
    mostrar_SeleccionTest()
  End Sub

  Private Sub btnabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrir.Click
    'If mSeleccionDet.EsNuevo Then
    '  If MsgBox("Para continuar debe guardar los cambios, ¿ Desea guardar ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
    '    Guardar_datos()
    '  Else
    '    Exit Sub
    '  End If
    'End If

    If BSTest.Current Is Nothing Then
      Exit Sub
    End If
    'If guardo Then

    Dim f As New FrmTest(Sistema, Enumerados.EnumOpciones.Personal)
    f.SeleccionTest = BSTest.Current
    f.ShowDialog()
    mostrar_SeleccionTest()
    'End If
  End Sub

  Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
    If mSeleccionDet.Seleccion.Selecc_Estado Then
      If Not ModoenContrato Then
        btnabrir_Click(sender, e)
      End If
    End If
  End Sub

  Private Sub ComboBoxSeccion_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSeccion.CambioItem
    If Not mCargando Then
      Me.ComboBoxDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, ComboBoxSeccion.ParametroDet)
    End If
  End Sub

  Private Sub ComboBoxDepartamento_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDepartamento.CambioItem
    If Not mCargando Then
      Try
        Me.CtlAreaSeleccion1.Seccion = ComboBoxSeccion.ParametroDet
        Me.CtlAreaSeleccion1.Departamento = ComboBoxDepartamento.ParametroDet
        Me.CtlAreaSeleccion1.llenar_datos()
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private Sub CtlAreaSeleccion1_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlAreaSeleccion1.CambioItem
    If Not mCargando Then
      Llenar_cargos()
    End If
  End Sub

  Sub Llenar_cargos()
    Try
      Dim _area As New Area(Sistema.OperadorDatos, Me.CtlAreaSeleccion1.Area.Parame_Departamento, Me.CtlAreaSeleccion1.Area.Pardet_Departamento, Me.CtlAreaSeleccion1.Area.Parame_Area, Me.CtlAreaSeleccion1.Area.Pardet_Area)

      Me.CtlCargoSeleccion1.Area = _area
      Me.CtlCargoSeleccion1.llenar_datos(_area)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CtlCargoSeleccion1_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlCargoSeleccion1.CambioItem
    Try
      Label7.Text = CtlCargoSeleccion1.Cargo.EmpleadoActual
    Catch ex As Exception
      Label7.Text = " "
    End Try
  End Sub

  Sub Estado_Cerrado()
    Me.dtfecha.Enabled = False
    Me.txtObservaciones.Enabled = False
    Me.cboResultadoSeleccion.Enabled = False
    Me.checkaprobadorrhh.Enabled = False
    Me.checkaprobadodpto.Enabled = False
    Me.ComboBoxSeccion.Enabled = False
    Me.ComboBoxDepartamento.Enabled = False
    Me.CtlAreaSeleccion1.Enabled = False
    Me.CtlCargoSeleccion1.Enabled = False
    Me.HeaderStrip1.Enabled = False
    Me.PuedeEliminar = False
  End Sub
End Class