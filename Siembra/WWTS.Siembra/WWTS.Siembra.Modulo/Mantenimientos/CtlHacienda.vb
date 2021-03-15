Imports System.ComponentModel
Imports Infoware.Datos
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlHacienda
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mHaciendas As HaciendaCollection
  Public Event CambioHacienda()

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

  Public Property Hacienda() As Hacienda
    Get
      If mHaciendas Is Nothing OrElse mHaciendas.Count = 0 Then
        Return Nothing
      Else
        Return mHaciendas(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Hacienda)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mHaciendas(t).Hac_codigo = Value.Hac_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
        RaiseEvent CambioHacienda()
      End If
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _hacienda As Hacienda = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _hacienda Is Nothing Then
      mHaciendas = Hacienda.RetornarHaciendas(mOp)
    Else
      Me.mHaciendas = New HaciendaCollection
      Me.mHaciendas.Add(_hacienda)
    End If
    Me.DataSource = mHaciendas
    Me.ValueMember = "Hac_codigo"
    Me.DisplayMember = "Hac_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mHaciendas Is Nothing OrElse mHaciendas.Count = 0, -1, 0)
    RaiseEvent CambioHacienda()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlHacienda_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlHacienda_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmHacienda
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Hacienda = mHaciendas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlHacienda_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmHacienda
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Hacienda = mHaciendas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlHacienda_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmHacienda
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Hacienda = New Hacienda(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlHacienda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioHacienda()
  End Sub
End Class

