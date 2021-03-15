Imports System.ComponentModel

Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlCorte
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mCortes As CorteCollection
  Public Event CambioCorte()

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

  Public Property Corte() As Corte
    Get
      If mCortes Is Nothing OrElse mCortes.Count = 0 Then
        Return Nothing
      Else
        Return mCortes(CType(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex), Integer))
      End If
    End Get
    Set(ByVal Value As Corte)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mCortes(t).Cor_codigo = Value.Cor_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioCorte()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Corte As Corte = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Corte Is Nothing Then
      mCortes = Corte.RetornarCortes(mOp)
    Else
      Me.mCortes = New CorteCollection
      Me.mCortes.Add(_Corte)
    End If
    Me.DataSource = mCortes
    Me.ValueMember = "Cor_codigo"
    Me.DisplayMember = "Cor_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = CType(IIf(mCortes Is Nothing OrElse mCortes.Count = 0, -1, 0), Integer)
    RaiseEvent CambioCorte()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlCorte_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlCorte_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmCorte
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Corte = mCortes(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlCorte_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmCorte
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Corte = mCortes(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlCorte_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmCorte
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Corte = New Corte(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlCorte_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioCorte()
  End Sub
End Class

