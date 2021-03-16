Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmMantenimientoSeleccion

#Region "Parametros"
  Public Property Seleccions() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mSeleccion As Seleccion = Nothing
  Public Property Seleccion() As Seleccion
    Get
      Return mSeleccion
    End Get
    Set(ByVal value As Seleccion)
      mSeleccion = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _SeleccionList As New SeleccionList
        _SeleccionList.Add(mSeleccion)
        MyBase.ListBindingSource.DataSource = GetType(Seleccion)
        MyBase.ListBindingSource.DataSource = _SeleccionList
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    If Seleccions.Current Is Nothing Then
      Exit Sub
    End If

    mSeleccion = Seleccions.Current
    Try
      Me.cboSeccion.ParametroDet = mSeleccion.PardetDepartamento.PardetPadre
    Catch ex As Exception
    End Try

    Me.cboDepartamento.ParametroDet = mSeleccion.PardetDepartamento

    Try
      Me.CtlArea1.Seccion = mSeleccion.PardetDepartamento.PardetPadre
      Me.CtlArea1.Departamento = mSeleccion.PardetDepartamento
      Me.CtlArea1.llenar_datos()
      Dim _area As New Area(mSeleccion.OperadorDatos, mSeleccion.Parame_Departamento, mSeleccion.Pardet_Departamento, mSeleccion.Parame_Area, mSeleccion.Pardet_Area)
      Me.CtlArea1.Area = _area
    Catch ex As Exception
    End Try

    If mSeleccion.EsNuevo Then
      Me.dtfecha.Value = mSeleccion.ObtenerFecha().Date
    Else
      Me.dtfecha.Value = mSeleccion.Selecc_Fecha
    End If

    Me.cboSeccion.Enabled = mSeleccion.EsNuevo
    Me.cboDepartamento.Enabled = mSeleccion.EsNuevo
    Me.CtlArea1.Enabled = mSeleccion.EsNuevo

    Me.Pnl3.Enabled = Not mSeleccion.EsNuevo

    Me.dtfecha.Enabled = Restriccion.Restri_VerConfidencial
    Me.btnaprobardetalle.Enabled = Restriccion.Restri_VerConfidencial

    If mSeleccion.Selecc_Estado Then
      Me.lblEstado.Text = "Abierto"
      Me.lblEstado.ForeColor = Color.Green
      Me.btnEstado.Text = "Cerrar Selección"
    Else
      Me.lblEstado.Text = "Cerrado"
      Me.lblEstado.ForeColor = Color.Red
      Me.btnEstado.Text = "Abrir Selección"
    End If

    Me.btnEstado.Enabled = Not mSeleccion.EsNuevo

    If ModoenContrato Then
      btnnuevodetalle.Enabled = Not ModoenContrato
      btneliminardetalle.Enabled = Not ModoenContrato
      btnaprobardetalle.Enabled = Not ModoenContrato
    End If
    RefrescarLista()

    If Not mSeleccion.Selecc_Estado Then
      Me.btnnuevodetalle.Enabled = mSeleccion.Selecc_Estado
      Me.btneliminardetalle.Enabled = mSeleccion.Selecc_Estado
      Me.btnaprobardetalle.Enabled = mSeleccion.Selecc_Estado
      Me.dtfecha.Enabled = mSeleccion.Selecc_Estado
      Me.btnEstado.Enabled = Restriccion.Restri_VerConfidencial
      Me.PuedeEliminar = mSeleccion.Selecc_Estado
    End If

  End Sub

  Sub RefrescarLista()
    Me.BindingSource2.DataSource = GetType(SeleccionDet)
    Dim SeleccionDets As SeleccionDetList
    SeleccionDets = SeleccionDetList.ObtenerListaFiltrada(mSeleccion.OperadorDatos, mSeleccion)
    Dim mitemssort As New Infoware.Reglas.SortedView(SeleccionDets)
    BindingSource2.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoSeleccion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mSeleccion.EsNuevo
    If _esnuevo AndAlso Seleccions.Current IsNot Nothing Then
      Seleccions.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Eventos"
  Private Sub FrmMantenimientoSeleccion_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Seleccion As Seleccion = New Seleccion(Sistema.OperadorDatos, True)
    e.NewObject = _Seleccion
  End Sub

  Private Sub FrmMantenimientoSeleccion_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoSeleccion_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mSeleccion.PardetDepartamento = Me.cboDepartamento.ParametroDet
    mSeleccion.PardetArea = Me.CtlArea1.Area.PardetArea
    mSeleccion.Selecc_Fecha = Me.dtfecha.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mSeleccion.EsNuevo

    If mSeleccion.PardetDepartamento Is Nothing Then
      MsgBox("Debe escoger un departamento", MsgBoxStyle.Critical, "Error")
      Return False
    End If

    If mSeleccion.Guardar() Then
      llenar_datos()
      Return True
    Else
      MsgBox("No se puede guardar Selección" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
    Return False
  End Function

  Private Sub FrmMantenimientoSeleccion_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If Seleccions.Current IsNot Nothing AndAlso mSeleccion.Eliminar() Then
      If Seleccions.Count > 1 Then
        Seleccions.RemoveCurrent()
      End If
      Me.Close()
    Else
      MsgBox("No se puede eliminar Selección" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoSeleccion_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoSeleccion_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoSeleccion_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoSeleccion_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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

  Private mCargando As Boolean = False

  Private Sub FrmMantenimientoSeleccion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Selección"

    Me.PuedeGuardar = True

    mCargando = True
    Me.cboSeccion.OperadorDatos = Sistema.OperadorDatos
    Me.cboSeccion.Parametro = Enumerados.EnumParametros.Seccion
    Me.cboSeccion.Llenar_Datos()

    Me.cboDepartamento.OperadorDatos = Sistema.OperadorDatos
    Me.cboDepartamento.Parametro = Enumerados.EnumParametros.Departamento
    Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)

    Me.CtlArea1.Op = Sistema.OperadorDatos
    Try
      Me.CtlArea1.Seccion = cboSeccion.ParametroDet
      Me.CtlArea1.Departamento = cboDepartamento.ParametroDet
      Me.CtlArea1.llenar_datos()
    Catch ex As Exception
    End Try
    mCargando = False

    Me.lblEstado.ForeColor = Color.Green
  End Sub
#End Region

  Private Sub FrmMantenimientoSeleccion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

  Private Sub btnabrirdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirdetalle.Click, DataGridView1.DoubleClick
    If BindingSource2.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New WWTS.General.Controles.FrmMantenimientoSeleccionDetalle(Sistema, Enumerados.EnumOpciones.Seleccion)
    f.ModoenContrato = ModoenContrato
    f.SeleccionDet = BindingSource2.Current
    f.ShowDialog()
    RefrescarLista()
  End Sub

  Private Sub btnnuevodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevodetalle.Click
    Dim _SeleccionDet As New SeleccionDet(Sistema.OperadorDatos, True)
    _SeleccionDet.Seleccion = CType(ListBindingSource.Current, Seleccion)

    Dim f As New WWTS.General.Controles.FrmMantenimientoSeleccionDetalle(Sistema, Enumerados.EnumOpciones.Seleccion)
    f.SeleccionDet = _SeleccionDet
    f.ShowDialog()
    f.Dispose()
    RefrescarLista()
  End Sub

  Private Sub btneliminardetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminardetalle.Click
    If BindingSource2.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If CType(BindingSource2.Current, SeleccionDet).Eliminar Then
      Me.BindingSource2.RemoveCurrent()
    Else
      MsgBox("Error al eliminar el Seleccion Detalle " & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub btnaprobardetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaprobardetalle.Click
    If BindingSource2.Current Is Nothing Then
      Exit Sub
    End If

    If Not CType(BindingSource2.Current, SeleccionDet).EsGanador Then
      Dim f As New FrmMantenimientoContrato(Sistema, Enumerados.EnumOpciones.Seleccion) With {
        .Seleccion = ListBindingSource.Current,
        .SeleccionDet = BindingSource2.Current
      }
      f.ShowDialog()
      RefrescarLista()
    End If
  End Sub

  Private Sub cboSeccion_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.CambioItem
    If Not mCargando Then
      Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)
    End If
  End Sub

  Private mModoenContrato As Boolean = False
  Public Property ModoenContrato As Boolean
    Get
      Return mModoenContrato
    End Get
    Set(ByVal value As Boolean)
      mModoenContrato = value
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

  Private Sub btnEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstado.Click
    If mSeleccion.Selecc_Estado Then
      mSeleccion.Selecc_Estado = False
      If mSeleccion.Guardar() Then
        Me.lblEstado.Text = "Cerrado"
        Me.lblEstado.ForeColor = Color.Red
        Me.btnEstado.Text = "Abrir Selección"
        Cambia_Estado(mSeleccion.Selecc_Estado)
        llenar_datos()
      Else
        MsgBox("No se puedo cambiar el estado" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      End If
    Else
      mSeleccion.Selecc_Estado = True
      If mSeleccion.Guardar() Then
        Me.lblEstado.Text = "Abierto"
        Me.lblEstado.ForeColor = Color.Green
        Me.btnEstado.Text = "Cerrar Selección"
        Cambia_Estado(mSeleccion.Selecc_Estado)
        llenar_datos()
      Else
        MsgBox("No se puedo cambiar el estado" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      End If
    End If

  End Sub

  Sub Cambia_Estado(ByVal _estado As Boolean)
    Me.btnnuevodetalle.Enabled = _estado
    Me.btneliminardetalle.Enabled = _estado
    Me.btnaprobardetalle.Enabled = _estado
    Me.dtfecha.Enabled = _estado
    Me.PuedeEliminar = _estado
  End Sub
End Class