Imports System.ComponentModel

Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlClaseHoja
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mClaseHojas As ClaseHojaCollection
  Public Event CambioClaseHoja()

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

  Public Property ClaseHoja() As ClaseHoja
    Get
      If mClaseHojas Is Nothing OrElse mClaseHojas.Count = 0 Then
        Return Nothing
      Else
        Return mClaseHojas(CType(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex), Integer))
      End If
    End Get
    Set(ByVal Value As ClaseHoja)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mClaseHojas(t).Cla_codigo = Value.Cla_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioClaseHoja()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _ClaseHoja As ClaseHoja = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _ClaseHoja Is Nothing Then
      mClaseHojas = ClaseHoja.RetornarClaseHojas(mOp)
    Else
      Me.mClaseHojas = New ClaseHojaCollection
      Me.mClaseHojas.Add(_ClaseHoja)
    End If
    Me.DataSource = mClaseHojas
    Me.ValueMember = "Cla_codigo"
    Me.DisplayMember = "Cla_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = CType(IIf(mClaseHojas Is Nothing OrElse mClaseHojas.Count = 0, -1, 0), Integer)
    RaiseEvent CambioClaseHoja()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
    MyBase.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
    MyBase.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
  End Sub

  Private Sub CtlClaseHoja_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlClaseHoja_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmClaseHoja
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.ClaseHoja = mClaseHojas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlClaseHoja_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmClaseHoja
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.ClaseHoja = mClaseHojas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlClaseHoja_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmClaseHoja
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.ClaseHoja = New ClaseHoja(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlClaseHoja_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioClaseHoja()
  End Sub
End Class

