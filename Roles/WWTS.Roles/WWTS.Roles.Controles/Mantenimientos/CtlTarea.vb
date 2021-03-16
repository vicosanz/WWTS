Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlTarea
  Inherits Infoware.Controles.Base.ListDB

  Private mTareas As TareaList
  Public Event CambioTarea()

#Region "Op"
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
    End Set
  End Property
#End Region

  Public Property Tarea() As Tarea
    Get
      If mTareas Is Nothing OrElse mTareas.Count = 0 Then
        Return Nothing
      Else
        Return mTareas(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Tarea)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mTareas(t).Tarea_Codigo = Value.Tarea_Codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioTarea()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Tarea As Tarea = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Tarea Is Nothing Then
      mTareas = TareaList.ObtenerLista(mOp)
    Else
      Me.mTareas = New TareaList
      Me.mTareas.Add(_Tarea)
    End If
    Me.DataSource = mTareas
    Me.ValueMember = "Tarea_codigo"
    Me.DisplayMember = "Tarea_descripcion"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mTareas Is Nothing OrElse mTareas.Count = 0, -1, 0)
    RaiseEvent CambioTarea()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlTarea_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlTarea_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmTarea(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Tarea = mTareas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlTarea_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmTarea(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Tarea = mTareas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlTarea_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmTarea(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Tarea = New Tarea(mOp, True)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlTarea_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioTarea()
  End Sub
End Class

