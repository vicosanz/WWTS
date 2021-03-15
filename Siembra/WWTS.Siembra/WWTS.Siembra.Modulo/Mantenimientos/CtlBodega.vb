Imports System.ComponentModel

Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlBodega
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mBodegas As WWTS.Siembra.Reglas.BodegaTerrenoCollection
  Public Event CambioBodega()

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

  Public Property Bodega() As WWTS.Siembra.Reglas.BodegaTerreno
    Get
      If mBodegas Is Nothing OrElse mBodegas.Count = 0 Then
        Return Nothing
      Else
        Return mBodegas(CType(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex), Integer))
      End If
    End Get
    Set(ByVal Value As WWTS.Siembra.Reglas.BodegaTerreno)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mBodegas(t).Bod_codigo = Value.Bod_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioBodega()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Bodega As WWTS.Siembra.Reglas.BodegaTerreno = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Bodega Is Nothing Then
      mBodegas = BodegaTerreno.RetornarBodegas(mOp)
    Else
      Me.mBodegas = New BodegaTerrenoCollection
      Me.mBodegas.Add(_Bodega)
    End If
    Me.DataSource = mBodegas
    Me.ValueMember = "Bod_codigo"
    Me.DisplayMember = "Bod_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = CType(IIf(mBodegas Is Nothing OrElse mBodegas.Count = 0, -1, 0), Integer)
    RaiseEvent CambioBodega()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlBodega_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlBodega_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmBodega
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Bodega = mBodegas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlBodega_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmBodega
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Bodega = mBodegas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlBodega_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmBodega
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Bodega = New BodegaTerreno(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlBodega_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioBodega()
  End Sub
End Class

