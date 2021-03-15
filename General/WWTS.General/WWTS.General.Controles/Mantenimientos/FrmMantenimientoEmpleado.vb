Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmMantenimientoEmpleado
  '#Region "IOpcion"
  '  Private mOperadorDatos As OperadorDatos = Nothing
  '  Public Property OperadorDatos() As OperadorDatos
  '    Get
  '      Return mOperadorDatos
  '    End Get
  '    Set(ByVal value As OperadorDatos)
  '      mOperadorDatos = value
  '      MyBase.Tabla = "Empleado"
  '    End Set
  '  End Property
  '#End Region

#Region "Parametros"
  Public Property Empleados() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mEmpleado As Empleado = Nothing
  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(ByVal value As Empleado)
      mEmpleado = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _Empleados As New EmpleadoList
        _Empleados.Add(mEmpleado)
        MyBase.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Empleado)
        MyBase.ListBindingSource.DataSource = _Empleados
      End If
    End Set
  End Property

  Sub llenar_datos()
    'If mOperadorDatos Is Nothing Then
    '  Exit Sub
    'End If

    mEmpleado = Empleados.Current
    Me.CtlEmpleado1.Empleado = mEmpleado
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoEmpleado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
    'If Cancelar_Nuevo() Then
    '  e.Cancel = False
    'Else
    '  If CtlEmpleado1.BSaplicacion.Count = 0 Then
    '    MsgBox("Debe llenar por lo menos un área aplicada", MsgBoxStyle.Information, "Información")
    '    e.Cancel = True
    '  Else
    '    e.Cancel = False
    '  End If
    'End If
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mEmpleado.EsNuevo
    If _esnuevo AndAlso Empleados.Current IsNot Nothing Then
      Empleados.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Empleados eventos"
  Private Sub FrmMantenimientoEmpleado_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Empleado As Empleado = New Empleado(Sistema.OperadorDatos, True)
    e.NewObject = _Empleado
  End Sub

  Private Sub FrmMantenimientoEmpleado_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoEmpleado_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    'e.Cancel = Not Guardar_datos()
    If Not Guardar_datos() Then
      e.Cancel = True
    End If
  End Sub

  Private Sub Mapear_datos()
    Me.CtlEmpleado1.Mapear_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_datos()
      If CtlEmpleado1.BSaplicacion.Count = 0 Then
        Throw New Exception("Debe llenar por lo menos un área aplicada")
      End If
      Dim _esnuevo As Boolean = mEmpleado.EsNuevo
      If mEmpleado.Guardar() Then
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mEmpleado.NombreCompleto)

        Return True
      Else
        Throw New Exception(" ")
      End If
    Catch ex As Exception
      MsgBox("No se puede guardar Empleado" & Environment.NewLine & ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoEmpleado_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mEmpleado.Eliminar() AndAlso Empleados.Current IsNot Nothing Then
      If Empleados.Count > 1 Then
        Empleados.RemoveCurrent()
      End If
      Me.Close()
    Else
      'Empleados.CancelEdit()
      MsgBox("No se puede eliminar Empleado" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoEmpleado_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing

  End Sub

  Private Sub FrmMantenimientoEmpleado_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlEmpleado1.OperadorDatos = Sistema.OperadorDatos
    MyBase.Tabla = "Empleado"

    Me.PuedeGuardar = True
  End Sub
End Class
