Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlCargo
  Inherits Infoware.Controles.Base.ComboBoxDB

  Private mCargoList As CargoList
  Public Event CambioCargo()

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

  Private mArea As Area
  Public Property Area As Area
    Get
      Return mArea
    End Get
    Set(ByVal value As Area)
      mArea = value
    End Set
  End Property

  Public Property Cargo() As Cargo
    Get
      If mCargoList Is Nothing OrElse mCargoList.Count = 0 Then
        Return Nothing
      Else
        Return mCargoList(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Cargo)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mCargoList(t).Pardet_Departamento = Value.Pardet_Departamento And mCargoList(t).Pardet_Area = Value.Pardet_Area And mCargoList(t).Cargo_Secuencia = Value.Cargo_Secuencia Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioCargo()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Area As Area = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    mCargoList = CargoList.ObtenerLista(_Area)
    Me.DataSource = mCargoList
    Me.ValueMember = "Cargo_Secuencia"
    Me.DisplayMember = "Cargo_Descripcion"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mCargoList Is Nothing OrElse mCargoList.Count = 0, -1, 0)
    RaiseEvent CambioCargo()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlCargo_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos(mArea)
  End Sub

  Private Sub CtlCargo_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoCargo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Cargo = CType(mCargoList(MyBase.SelectedIndex), Cargo)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos(mArea)
    End If
  End Sub

  Private Sub CtlCargo_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoCargo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Cargo = CType(mCargoList(MyBase.SelectedIndex), Cargo)
    f.Direccion = IMantenimiento.Accion.Modificacion
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos(mArea)
    End If
  End Sub

  Private Sub CtlCargo_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    If mArea Is Nothing Then
      MsgBox("Debe crear una asignación de área para esa sección antes de crear el cargo", vbInformation, "Error")
      Exit Sub
    End If

    Dim f As New FrmMantenimientoCargo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.AreasCargos)
    Dim _Cargo As New Cargo(mOp, True)
    _Cargo.Area = mArea
    f.Cargo = _Cargo
    f.Direccion = IMantenimiento.Accion.Ingreso
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos(mArea)
    End If
  End Sub

  Private Sub CtlCargo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioCargo()
  End Sub
End Class

