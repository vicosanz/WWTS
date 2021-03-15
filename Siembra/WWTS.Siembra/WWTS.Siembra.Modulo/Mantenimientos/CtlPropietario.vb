Imports System.ComponentModel

Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlPropietario
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mPropietarios As PropietarioCollection
  Public Event CambioPropietario()

#Region "Op"
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
    End Set
  End Property
#End Region

  Public Property Propietario() As Propietario
    Get
      If mPropietarios Is Nothing OrElse mPropietarios.Count = 0 Then
        Return Nothing
      Else
        Return mPropietarios(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Propietario)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mPropietarios(t).Pro_codigo = Value.Pro_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioPropietario()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Propietario As Propietario = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Propietario Is Nothing Then
      mPropietarios = Propietario.RetornarPropietarios(mOp)
    Else
      Me.mPropietarios = New PropietarioCollection
      Me.mPropietarios.Add(_Propietario)
    End If
    Me.DataSource = mPropietarios
    Me.ValueMember = "Pro_codigo"
    Me.DisplayMember = "Pro_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mPropietarios Is Nothing OrElse mPropietarios.Count = 0, -1, 0)
    RaiseEvent CambioPropietario()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlPropietario_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlPropietario_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmPropietario
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Propietario = mPropietarios(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlPropietario_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmPropietario
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Propietario = mPropietarios(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlPropietario_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmPropietario
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Propietario = New Propietario(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlPropietario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioPropietario()
  End Sub
End Class

