Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlModeloLabor
  Inherits Infoware.Controles.Base.ComboBoxDB

  Private mModeloLabors As WWTSParametroDetList
  Public Event CambioModeloLabor()

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

  Public Property ModeloLabor() As WWTSParametroDet
    Get
      If mModeloLabors Is Nothing OrElse mModeloLabors.Count = 0 Then
        Return Nothing
      Else
        Return mModeloLabors(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As WWTSParametroDet)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mModeloLabors(t).Pardet_Secuencia = Value.Pardet_Secuencia Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioModeloLabor()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _ModeloLabor As WWTSParametroDet = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _ModeloLabor Is Nothing Then
      mModeloLabors = WWTSParametroDetList.ObtenerLista(mOp, Enumerados.EnumParametros.ModeloLabor)
    Else
      Me.mModeloLabors = New WWTSParametroDetList
      Me.mModeloLabors.Add(_ModeloLabor)
    End If
    Me.DataSource = mModeloLabors
    Me.ValueMember = "Pardet_Secuencia"
    Me.DisplayMember = "Pardet_Descripcion"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mModeloLabors Is Nothing OrElse mModeloLabors.Count = 0, -1, 0)
    RaiseEvent CambioModeloLabor()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlModeloLabor_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlModeloLabor_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmModeloLabor(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.ModeloLabor = mModeloLabors(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlModeloLabor_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmModeloLabor(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.ModeloLabor = mModeloLabors(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlModeloLabor_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmModeloLabor(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.ModeloLabor = New WWTSParametroDet(mOp, Enumerados.EnumParametros.ModeloLabor, True)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlModeloLabor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioModeloLabor()
  End Sub
End Class

