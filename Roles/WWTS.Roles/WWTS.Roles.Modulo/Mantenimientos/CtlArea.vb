Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class CtlArea
  Inherits Infoware.Controles.Base.ComboBoxDB

  Private mAreaList As AreaList
  Public Event CambioArea()

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

  Private mSeccion As WWTSParametroDet
  Public Property Seccion As WWTSParametroDet
    Get
      Return mSeccion
    End Get
    Set(ByVal value As WWTSParametroDet)
      mSeccion = value
    End Set
  End Property

  Private mDepartamento As WWTSParametroDet = Nothing
  Public Property Departamento As WWTSParametroDet
    Get
      Return mDepartamento
    End Get
    Set(ByVal value As WWTSParametroDet)
      mDepartamento = value
    End Set
  End Property

  Public Property Area() As Area
    Get
      If mAreaList Is Nothing OrElse mAreaList.Count = 0 Then
        Return Nothing
      Else
        Return mAreaList(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Area)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mAreaList(t).Pardet_Departamento = Value.Pardet_Departamento And mAreaList(t).Pardet_Area = Value.Pardet_Area Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioArea()
    End Set
  End Property

  Public Sub llenar_datos()
    If mDepartamento Is Nothing Then
      Exit Sub
    End If
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    mAreaList = AreaList.ObtenerLista(mOp, mSeccion, mDepartamento)
    Me.DataSource = mAreaList
    Me.ValueMember = "Pardet_Area"
    Me.DisplayMember = "AreaString"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mAreaList Is Nothing OrElse mAreaList.Count = 0, -1, 0)
    RaiseEvent CambioArea()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = False
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlArea_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    llenar_datos()
  End Sub

  Private Sub CtlArea_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoArea(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.AreasCargos)
    f.Area = New Area(mSeccion.OperadorDatos, Area.Parame_Departamento, Area.Pardet_Departamento, Area.Parame_Area, Area.Pardet_Area)
    f.cboseccion.ParametroDet = mSeccion
    f.cboseccion.Enabled = False
    f.cboarea.ParametroDet = Area.PardetArea
    f.cboseccion.Enabled = False
    f.txtdotacion.Enabled = False
    f.PuedeGuardar = False
    f.PuedeGuardaryCerrar = False
    f.PuedeGuardaryNuevo = False
    f.ShowDialog()
    f.Dispose()
  End Sub

  Private Sub CtlArea_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoArea(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.AreasCargos)
    f.Area = New Area(mSeccion.OperadorDatos, Area.Parame_Departamento, Area.Pardet_Departamento, Area.Parame_Area, Area.Pardet_Area)
    f.cboseccion.ParametroDet = mSeccion
    f.cbodepartamento.ParametroDet = Area.PardetDepartamento
    f.cboarea.ParametroDet = Area.PardetArea
    f.ShowDialog()
    f.Dispose()
  End Sub

  Private Sub CtlArea_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoArea(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.AreasCargos)
    f.Area = New Area(mSeccion.OperadorDatos, True)
    f.cboseccion.ParametroDet = mSeccion
    f.ShowDialog()
    f.Dispose()
  End Sub

  Private Sub CtlArea_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioArea()
  End Sub
End Class

