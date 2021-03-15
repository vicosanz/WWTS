Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class CtlPatrono

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
    End Set
  End Property

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
        Return mPatronos(IIf(Me.lstpatrono.SelectedIndex = -1, 0, Me.lstpatrono.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Patrono)
      If Value Is Nothing Then
        Me.lstpatrono.SelectedIndex = -1
      Else
        For t As Integer = 0 To Me.lstpatrono.Items.Count - 1
          If mPatronos(t).Patron_Codigo = Value.Patron_Codigo Then
            Me.lstpatrono.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioPatrono()
    End Set
  End Property

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
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
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim fpat As New FrmPatrono(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Patrono = Me.mPatronos(Me.lstpatrono.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim fpat As New FrmPatrono(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Patrono = Me.mPatronos(Me.lstpatrono.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Modificacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuactualizar.Click
    If Usuario Is Nothing Then
      Me.llenar_datos()
    Else
      Me.llenar_datos(Usuario)
    End If

  End Sub

  Private Sub menu_Popup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Me.mnunuevo.Visible = True
    Me.mnueliminar.Visible = True
    Me.mnumodificar.Visible = True
    If Me.lstpatrono.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Public Sub llenar_datos(Optional ByVal _Usuario As Infoware.Reglas.General.Usuario = Nothing)
    mUsuario = _Usuario
    lstpatrono.Enabled = False
    Me.lstpatrono.BeginUpdate()
    Me.lstpatrono.DataSource = Nothing
    Me.lstpatrono.Items.Clear()
    If mUsuario Is Nothing Then
      Me.mPatronos = PatronoList.ObtenerLista(Me.mOp)
    Else
      Me.mPatronos = PatronoList.ObtenerListaxUsuario(mUsuario)
    End If
    Me.lstpatrono.ValueMember = "Patron_Codigo"
    Me.lstpatrono.DisplayMember = "NombreCompleto"
    Me.lstpatrono.DataSource = mPatronos
    Me.lstpatrono.EndUpdate()
    lstpatrono.Enabled = True
  End Sub

  Private Sub lstpatrono_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstpatrono.SelectedIndexChanged
    If Not lstpatrono.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioPatrono()
  End Sub
End Class
