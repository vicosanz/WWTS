Imports WWTS.Roles.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmMantenimientoArea

#Region "Parametros"
  Public Property Areas() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mArea As Area = Nothing
  Public Property Area() As Area
    Get
      Return mArea
    End Get
    Set(ByVal value As Area)
      mArea = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _Areas As New AreaList
        _Areas.Add(mArea)
        MyBase.ListBindingSource.DataSource = GetType(Area)
        MyBase.ListBindingSource.DataSource = _Areas
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    mArea = Areas.Current

    Try
      Me.cboseccion.ParametroDet = mArea.PardetDepartamento.PardetPadre
    Catch
    End Try
    Me.cboarea.ParametroDet = mArea.PardetArea
    Me.txtdotacion.Value = mArea.Area_Dotacion

    Me.cbodepartamento.ParametroDet = mArea.PardetDepartamento
    Me.cbodepartamento.Select()

    Me.cboseccion.Enabled = mArea.EsNuevo
    Me.cbodepartamento.Enabled = mArea.EsNuevo
    Me.cboarea.Enabled = mArea.EsNuevo
    Me.cbodepartamento.Enabled = mArea.EsNuevo

    Me.pnlcargos.Enabled = Not mArea.EsNuevo

    Me.txtdotacion.Enabled = Restriccion.Restri_VerConfidencial
    Me.btnnuevocargo.Enabled = Restriccion.Restri_VerConfidencial
    Me.btnmodificarcargo.Enabled = Restriccion.Restri_VerConfidencial
    Me.btneliminarcargo.Enabled = Restriccion.Restri_VerConfidencial

    RefrescarListaCargos()
  End Sub

  Sub RefrescarListaCargos()
    Me.BindingSource2.DataSource = GetType(Cargo)

    Dim mitemssort As New Infoware.Reglas.SortedView(mArea.Cargos)
    BindingSource2.DataSource = mitemssort
    Me.DataGridView2.AutoDiscover()
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoArea_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mArea.EsNuevo
    If _esnuevo AndAlso Areas.Current IsNot Nothing Then
      Areas.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Eventos"
  Private Sub FrmMantenimientoArea_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Area As Area = New Area(Sistema.OperadorDatos, True)
    e.NewObject = _Area
  End Sub

  Private Sub FrmMantenimientoArea_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoArea_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mArea.PardetArea = Me.cboarea.ParametroDet
    mArea.Area_Dotacion = Me.txtdotacion.Value
    mArea.PardetDepartamento = Me.cbodepartamento.ParametroDet
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mArea.EsNuevo

    If mArea.PardetDepartamento Is Nothing Then
      MsgBox("Debe seleccionar un departamento", MsgBoxStyle.Information, "Información")
      Exit Function
    End If

    If mArea.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), String.Format("{0}, {1}, dotación {2}", mArea.SeccionString, mArea.AreaString, mArea.Area_Dotacion))
      llenar_datos()
      Return True
    Else
      MsgBox("No se puede guardar Area" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoArea_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If Areas.Current IsNot Nothing AndAlso mArea.Eliminar() Then
      If Areas.Count > 1 Then
        Areas.RemoveCurrent()
      End If
      Me.Close()
    Else
      MsgBox("No se puede eliminar Area" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoArea_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoArea_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoArea_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoArea_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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

  Private Sub FrmMantenimientoArea_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Asignar área a sección"

    Me.PuedeGuardar = True

    Me.cboseccion.OperadorDatos = Sistema.OperadorDatos
    Me.cboseccion.Parametro = Enumerados.EnumParametros.Seccion
    Me.cboseccion.Llenar_Datos()

    Me.cbodepartamento.OperadorDatos = Sistema.OperadorDatos
    Me.cbodepartamento.Parametro = Enumerados.EnumParametros.Departamento
    Me.cbodepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboseccion.ParametroDet)

    Me.cboarea.OperadorDatos = Sistema.OperadorDatos
    Me.cboarea.Parametro = Enumerados.EnumParametros.Area
    Me.cboarea.Llenar_Datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoArea_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

  Private Sub btnnuevocargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevocargo.Click
    Dim _Cargo As New Cargo(Sistema.OperadorDatos, True)
    _Cargo.Area = mArea

    Dim f As New WWTS.Roles.Controles.FrmMantenimientoCargo(Sistema, Enumerados.EnumOpciones.AreasCargos)
    f.Cargo = _Cargo
    f.ShowDialog()

    RefrescarListaCargos()
  End Sub

  Private Sub btneliminarcargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcargo.Click
    If BindingSource2.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If CType(BindingSource2.Current, Cargo).Eliminar Then
      Me.BindingSource2.RemoveCurrent()
    Else
      MsgBox("Error al eliminar el cargo " & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub btnmodificarcargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarcargo.Click, DataGridView2.DoubleClick
    If Not Restriccion.Restri_VerConfidencial Then
      Exit Sub
    End If
    If BindingSource2.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New WWTS.Roles.Controles.FrmMantenimientoCargo(Sistema, Enumerados.EnumOpciones.AreasCargos)
    f.Cargo = BindingSource2.Current
    f.ShowDialog()
    RefrescarListaCargos()
  End Sub

  Private Sub cboseccion_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboseccion.CambioItem
    Me.cbodepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboseccion.ParametroDet)
  End Sub
End Class