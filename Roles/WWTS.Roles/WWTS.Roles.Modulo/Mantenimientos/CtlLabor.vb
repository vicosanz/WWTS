Imports Infoware.Consola.Base
Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class CtlLabor

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      If value IsNot Nothing Then
        Me.CtlSeccion1.Parametro = Enumerados.EnumParametros.Seccion
        Me.CtlSeccion1.OperadorDatos = value
        Me.CtlSeccion1.Llenar_Datos()
      End If
    End Set
  End Property

  Private mLabors As LaborList
  Public Event CambioLabor As EventHandler

  Public Property Labor() As Labor
    Get
      If mLabors Is Nothing OrElse mLabors.Count = 0 Then
        Return Nothing
      Else
        Return mLabors(IIf(Me.lstLabor.SelectedIndex = -1, 0, Me.lstLabor.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Labor)
      If Value Is Nothing Then
        Me.lstLabor.SelectedIndex = -1
      Else
        Me.CtlSeccion1.ParametroDet = Value.Seccion
        Cambiar_Seccion()
        For t As Integer = 0 To Me.lstLabor.Items.Count - 1
          If mLabors(t).Labor_Codigo = Value.Labor_Codigo Then
            Me.lstLabor.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioLabor(Me, Nothing)
    End Set
  End Property

  Public Sub llenar_datos()
    Me.CtlSeccion1.Llenar_Datos()
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim fpat As New FrmLabor(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Labor = New Labor(Op, Me.CtlSeccion1.ParametroDet)
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

    Dim fpat As New FrmLabor(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Labor = Me.mLabors(Me.lstLabor.SelectedIndex)
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

    Dim fpat As New FrmLabor(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    fpat.Labor = Me.mLabors(Me.lstLabor.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Modificacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuactualizar.Click
    Me.llenar_datos()
  End Sub

  Private Sub menu_Popup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Me.mnunuevo.Visible = True
    Me.mnueliminar.Visible = True
    Me.mnumodificar.Visible = True
    If Me.lstLabor.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlSeccion1_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlSeccion1.CambioItem
    Cambiar_Seccion()
    RaiseEvent CambioLabor(Me, Nothing)
  End Sub

  Private Sub Cambiar_Seccion()
    lstLabor.Enabled = False
    Me.lstLabor.BeginUpdate()
    Me.lstLabor.DataSource = Nothing
    Me.lstLabor.Items.Clear()
    If Me.CtlSeccion1.ParametroDet Is Nothing Then
      mLabors = Nothing
    Else
      Me.mLabors = LaborList.ObtenerLista(Me.mOp, Me.CtlSeccion1.ParametroDet)
    End If
    Me.lstLabor.DataSource = mLabors
    Me.lstLabor.ValueMember = "Labor_Codigo"
    Me.lstLabor.DisplayMember = "Labor_Descripcion"
    Me.lstLabor.EndUpdate()
    lstLabor.Enabled = True
  End Sub

  Private Sub lstLabor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLabor.SelectedIndexChanged
    If Not lstLabor.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioLabor(Me, Nothing)
  End Sub
End Class
