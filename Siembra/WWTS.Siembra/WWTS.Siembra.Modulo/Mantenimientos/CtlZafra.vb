Imports System.ComponentModel
Imports Infoware.Datos
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlZafra
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mZafras As ZafraSiembraCollection
  Public Event CambioZafra()

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

  Public Property Zafra() As ZafraSiembra
    Get
      If mZafras Is Nothing OrElse mZafras.Count = 0 Then
        Return Nothing
      Else
        Return mZafras(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As ZafraSiembra)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mZafras(t).Zaf_codigo = Value.Zaf_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioZafra()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Zafra As ZafraSiembra = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Zafra Is Nothing Then
      mZafras = ZafraSiembra.RetornarZafras(mOp)
    Else
      Me.mZafras = New ZafraSiembraCollection
      Me.mZafras.Add(_Zafra)
    End If
    Me.DataSource = mZafras
    Me.ValueMember = "Zaf_codigo"
    Me.DisplayMember = "Zaf_descripcion"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mZafras Is Nothing OrElse mZafras.Count = 0, -1, 0)
    RaiseEvent CambioZafra()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlZafra_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlZafra_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmZafra
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Zafra = mZafras(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlZafra_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmZafra
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Zafra = mZafras(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlZafra_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmZafra
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Zafra = New ZafraSiembra(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlZafra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioZafra()
  End Sub
End Class

