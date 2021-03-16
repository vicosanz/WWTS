Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlPatronoCombo
  Inherits Infoware.Controles.Base.ComboBoxDB

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

  Private mUsuario As Infoware.Reglas.General.Usuario = Nothing
  Public Property Usuario() As Infoware.Reglas.General.Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Infoware.Reglas.General.Usuario)
      mUsuario = value
    End Set
  End Property

  Private mPatronos As PatronoList
  Public Event CambioPatrono()

  Public Property Patrono() As Patrono
    Get
      If mPatronos Is Nothing OrElse mPatronos.Count = 0 Then
        Return Nothing
      Else
        Return mPatronos(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Patrono)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mPatronos(t).Patron_Codigo = Value.Patron_Codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioPatrono()
    End Set
  End Property

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim fpat As New FrmPatrono(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Patrono = New Patrono(Op, True)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    If Usuario Is Nothing Then
      Me.llenar_datos()
    Else
      Me.llenar_datos(Usuario)
    End If
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim fpat As New FrmPatrono(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Patrono = Me.mPatronos(MyBase.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      If Usuario Is Nothing Then
        Me.llenar_datos()
      Else
        Me.llenar_datos(Usuario)
      End If
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim fpat As New FrmPatrono(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Patrono = Me.mPatronos(MyBase.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Modificacion
    If fpat.ShowDialog = DialogResult.OK Then
      If Usuario Is Nothing Then
        Me.llenar_datos()
      Else
        Me.llenar_datos(Usuario)
      End If
    End If
  End Sub

  Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    If Usuario Is Nothing Then
      Me.llenar_datos()
    Else
      Me.llenar_datos(Usuario)
    End If
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Public Sub llenar_datos(Optional ByVal _Usuario As Infoware.Reglas.General.Usuario = Nothing)
    mUsuario = _Usuario
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    Me.Items.Clear()
    If mUsuario Is Nothing Then
      Me.mPatronos = PatronoList.ObtenerLista(Me.mOp)
    Else
      Me.mPatronos = PatronoList.ObtenerListaxUsuario(mUsuario)
    End If
    Me.ValueMember = "Patron_Codigo"
    Me.DisplayMember = "NombreCompleto"
    Me.DataSource = mPatronos
    Me.EndUpdate()
    Me.Enabled = True
  End Sub

  Private Sub lstpatrono_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioPatrono()
  End Sub
End Class

