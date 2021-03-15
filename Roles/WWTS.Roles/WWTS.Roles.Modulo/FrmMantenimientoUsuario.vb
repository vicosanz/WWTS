Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmMantenimientoUsuario
  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Usuario"

  End Sub

#Region "Parametros"
  Public Property Usuarios() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mUsuario As WWTSUsuario = Nothing
  Public Property Usuario() As WWTSUsuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As WWTSUsuario)
      mUsuario = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _Usuarios As New WWTSUsuarioList
        _Usuarios.Add(mUsuario)
        MyBase.ListBindingSource.DataSource = GetType(WWTSUsuario)
        MyBase.ListBindingSource.DataSource = _Usuarios
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    mUsuario = Usuarios.Current
    Me.txtcodigo.Enabled = mUsuario.EsNuevo

    Me.txtcodigo.Text = mUsuario.Usuari_Codigo
    Me.txtdescripcion.Text = mUsuario.Usuari_Descripcion

    Llenar_detallesPatronos()
  End Sub

  Sub Llenar_detallesPatronos()
    Me.DGPatronos.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PatronoString"
    DataGridViewTextBoxColumn1.HeaderText = "Patrono"
    DataGridViewTextBoxColumn1.Width = 160
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DGPatronos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn

    DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewCheckBoxColumn1.DataPropertyName = "PatUsu_Activo"
    DataGridViewCheckBoxColumn1.HeaderText = "Activo"
    DataGridViewCheckBoxColumn1.Width = 50
    DataGridViewCheckBoxColumn1.ReadOnly = False

    Me.DGPatronos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewCheckBoxColumn1})

    BindingSourcePatronos.DataSource = GetType(PatronoxUsuarioList)
    BindingSourcePatronos.DataSource = PatronoxUsuarioList.ObtenerLista(Sistema.OperadorDatos, mUsuario, False)
  End Sub

#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mUsuario.EsNuevo
    If _esnuevo AndAlso Usuarios.Current IsNot Nothing Then
      Usuarios.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Usuarios eventos"
  Private Sub FrmMantenimientoUsuario_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Usuario As WWTSUsuario = New WWTSUsuario(Sistema.OperadorDatos, True)
    e.NewObject = _Usuario
  End Sub

  Private Sub FrmMantenimientoUsuario_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoUsuario_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mUsuario.Usuari_Codigo = Me.txtcodigo.Text
    mUsuario.Usuari_Descripcion = Me.txtdescripcion.Text

    Me.DGPatronos.EndEdit()
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mUsuario.EsNuevo
    If mUsuario.Usuari_Codigo = Restriccion.Usuari_Codigo Then
      If Not mUsuario.Restricciones.Buscar(Enumerados.EnumOpciones.Usuarios).Restri_Modificacion Then
        MsgBox("No se puede quitar el privilegio de modificación de usuarios a si mismo, debe hacerlo otro usuario", MsgBoxStyle.Critical, "Error")
        Return False
      End If
    End If

    If mUsuario.Guardar() Then

      For Each _patrono As PatronoxUsuario In Me.DGPatronos.DataSource
        _patrono.Guardar()
      Next

      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mUsuario.Usuari_Descripcion)

      If mUsuario.Usuari_Codigo = Restriccion.Usuari_Codigo Then
        MsgBox("Los cambios efectuados serán efectivos en el próximo reinicio del sistema", MsgBoxStyle.Information, "Información")
      End If
      Return True
    Else
      'Usuarios.CancelEdit()
      MsgBox("No se puede guardar Usuario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoUsuario_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mUsuario.Usuari_Codigo = Me.Restriccion.Usuari_Codigo Then
      MsgBox("No se puede eliminar el usuario actual", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    If mUsuario.Eliminar() AndAlso Usuarios.Current IsNot Nothing Then
      Usuarios.RemoveCurrent()
      Me.Close()
    Else
      'Usuarios.CancelEdit()
      MsgBox("No se puede eliminar Usuario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoUsuario_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUsuario_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUsuario_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUsuario_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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
End Class
