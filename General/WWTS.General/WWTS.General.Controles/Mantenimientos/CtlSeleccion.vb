Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class CtlSeleccion
  Inherits Infoware.Controles.Base.ComboBoxDB

  Private mSeleccionList As SeleccionList
  Public Event CambioSeleccion()

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

  Public Property Seleccion() As Seleccion
    Get
      If mSeleccionList Is Nothing OrElse mSeleccionList.Count = 0 Then
        Return Nothing
      Else
        Return mSeleccionList(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Seleccion)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mSeleccionList(t).Selecc_Codigo = Value.Selecc_Codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioSeleccion()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Area As Area = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    'If _Area Is Nothing Then
    '  mCargoList = CargoList.ObtenerLista(_Area)
    'Else
    '  Me.mCargoList = New CargoList
    'End If
    mSeleccionList = SeleccionList.ObtenerListaxArea(mOp, _Area)
    Me.DataSource = mSeleccionList
    Me.ValueMember = "Selecc_Codigo"
    Me.DisplayMember = "PardetAreaString"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mSeleccionList Is Nothing OrElse mSeleccionList.Count = 0, -1, 0)
    RaiseEvent CambioSeleccion()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = False
    MyBase.PuedeModificar = False
    MyBase.PuedeEliminar = False
    MyBase.PuedeActualizar = True
  End Sub

  'Private Sub CtlSeleccion_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
  '  'Me.llenar_datos()
  'End Sub

  'Private Sub CtlSeleccion_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
  '  Dim _control As Control = Me.Parent
  '  While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
  '    _control = _control.Parent
  '  End While
  '  If _control Is Nothing Then
  '    Exit Sub
  '  End If

  '  'Dim f As New FrmMantenimientoCargo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal, Enumerados.EnumOpciones.ListadoEmpleados)
  '  'f.Cargo = CType(mCargoList(MyBase.SelectedIndex), Cargo)
  '  'f.Direccion = IMantenimiento.Accion.Eliminacion
  '  'If f.ShowDialog() = DialogResult.OK Then
  '  '  llenar_datos()
  '  'End If
  'End Sub

  'Private Sub CtlSeleccion_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
  '  Dim _control As Control = Me.Parent
  '  While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
  '    _control = _control.Parent
  '  End While
  '  If _control Is Nothing Then
  '    Exit Sub
  '  End If

  '  'Dim f As New FrmMantenimientoCargo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal, Enumerados.EnumOpciones.ListadoEmpleados)
  '  'f.Cargo = CType(mCargoList(MyBase.SelectedIndex), Cargo)
  '  'f.Direccion = IMantenimiento.Accion.Modificacion
  '  'If f.ShowDialog() = DialogResult.OK Then
  '  '  llenar_datos()
  '  'End If
  'End Sub

  'Private Sub CtlSeleccion_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
  '  Dim _control As Control = Me.Parent
  '  While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
  '    _control = _control.Parent
  '  End While
  '  If _control Is Nothing Then
  '    Exit Sub
  '  End If

  '  'Dim f As New FrmMantenimientoCargo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.AreasCargos)
  '  'Dim _Cargo As New Cargo(mOp, True)
  '  ''_Cargo.Area = CType(mCargoList(MyBase.SelectedIndex), Cargo).Area
  '  '_Cargo.Area = New Area(mOp, 760, 1, 763, 1)
  '  'f.Cargo = _Cargo
  '  'f.Direccion = IMantenimiento.Accion.Ingreso
  '  'If f.ShowDialog() = DialogResult.OK Then
  '  '  llenar_datos()
  '  'End If
  'End Sub

  Private Sub CtlSeleccion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioSeleccion()
  End Sub
End Class

