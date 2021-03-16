Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlTipoContrato
  Inherits Infoware.Controles.Base.ComboBoxDB

  Private mTipoContratos As TipoContratoList
  Public Event CambioTipoContrato()

  Private mPatrono As Patrono = Nothing
  Public Overridable Property Patrono() As Patrono
    Get
      If Me.mPatrono Is Nothing Then
        'Me.mPatrono = New Patrono(Op, True)
      End If
      Return Me.mPatrono
    End Get
    Set(ByVal value As Patrono)
      Me.mPatrono = value
      'Patron_Codigo = value.Patron_Codigo
    End Set
  End Property

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

  Public Property TipoContrato() As TipoContrato
    Get
      If mTipoContratos Is Nothing OrElse mTipoContratos.Count = 0 Then
        Return Nothing
      Else
        Return mTipoContratos(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As TipoContrato)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mTipoContratos(t).TipCon_Codigo = Value.TipCon_Codigo And mTipoContratos(t).Patron_Codigo = Value.Patron_Codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioTipoContrato()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _TipoContrato As TipoContrato = Nothing)
    If Patrono Is Nothing Then
      Exit Sub
    End If
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _TipoContrato Is Nothing Then
      mTipoContratos = TipoContratoList.ObtenerLista(Patrono)
    Else
      Me.mTipoContratos = New TipoContratoList
      Me.mTipoContratos.Add(_TipoContrato)
    End If
    Me.DataSource = mTipoContratos
    Me.ValueMember = "TipCon_codigo"
    Me.DisplayMember = "TipCon_descripcion"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mTipoContratos Is Nothing OrElse mTipoContratos.Count = 0, -1, 0)
    RaiseEvent CambioTipoContrato()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlTipoContrato_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlTipoContrato_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmTipoContrato(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.TipoContrato = mTipoContratos(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlTipoContrato_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmTipoContrato(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.TipoContrato = mTipoContratos(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlTipoContrato_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmTipoContrato(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.TipoContrato = New TipoContrato(mOp, Me.mPatrono.Patron_Codigo, True)
    f.TipoContrato.Patrono = mPatrono
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlTipoContrato_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioTipoContrato()
  End Sub
End Class

