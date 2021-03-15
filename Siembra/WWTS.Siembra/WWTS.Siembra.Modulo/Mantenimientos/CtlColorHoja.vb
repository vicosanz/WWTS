Imports System.ComponentModel

Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlColorHoja
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mColorHojas As ColorHojaCollection
  Public Event CambioColorHoja()

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

  Public Property ColorHoja() As ColorHoja
    Get
      If mColorHojas Is Nothing OrElse mColorHojas.Count = 0 Then
        Return Nothing
      Else
        Return mColorHojas(CType(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex), Integer))
      End If
    End Get
    Set(ByVal Value As ColorHoja)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mColorHojas(t).Col_codigo = Value.Col_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioColorHoja()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _ColorHoja As ColorHoja = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _ColorHoja Is Nothing Then
      mColorHojas = ColorHoja.RetornarColorHojas(mOp)
    Else
      Me.mColorHojas = New ColorHojaCollection
      Me.mColorHojas.Add(_ColorHoja)
    End If
    Me.DataSource = mColorHojas
    Me.ValueMember = "Col_codigo"
    Me.DisplayMember = "Col_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    SelectedIndex = CType(IIf(mColorHojas Is Nothing OrElse mColorHojas.Count = 0, -1, 0), Integer)
    RaiseEvent CambioColorHoja()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
    MyBase.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
    MyBase.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
  End Sub

  Private Sub CtlColorHoja_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlColorHoja_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmColorHoja
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.ColorHoja = mColorHojas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlColorHoja_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmColorHoja
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.ColorHoja = mColorHojas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlColorHoja_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmColorHoja
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.ColorHoja = New ColorHoja(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlColorHoja_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioColorHoja()
  End Sub
End Class

