
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports Infoware.Datos

Public Class CtlSeccionHorno
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlHorno1.Op = value
    End Set
  End Property

  Private mSeccionHornos As SeccionHornoCollection
  Public Event CambioSeccionHorno()

  Public Property SeccionHorno() As SeccionHorno
    Get
      If mSeccionHornos Is Nothing OrElse mSeccionHornos.Count = 0 Then
        Return Nothing
      Else
        Return mSeccionHornos(IIf(Me.lstseccionhorno.SelectedIndex = -1, 0, Me.lstseccionhorno.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As SeccionHorno)
      If Value Is Nothing Then
        Me.lstseccionhorno.SelectedIndex = -1
      Else
        Me.CtlHorno1.Horno = Value.Horno
        Cambiar_Horno()
        For t As Integer = 0 To Me.lstseccionhorno.Items.Count - 1
          If mSeccionHornos(t).Sec_codigo = Value.Sec_codigo Then
            Me.lstseccionhorno.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioSeccionHorno()
    End Set
  End Property

  Public Sub llenar_datos()
    Me.CtlHorno1.llenar_datos()
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmSeccionHorno
    fpat.SeccionHorno = New SeccionHorno(Op, Me.CtlHorno1.Horno)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmSeccionHorno
    fpat.SeccionHorno = Me.mSeccionHornos(Me.lstseccionhorno.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmSeccionHorno
    fpat.SeccionHorno = Me.mSeccionHornos(Me.lstseccionhorno.SelectedIndex)
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
    If Me.lstseccionhorno.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlHorno1_CambioHorno() Handles CtlHorno1.CambioHorno
    Cambiar_Horno()
    RaiseEvent CambioSeccionHorno()
  End Sub

  Private Sub Cambiar_Horno()
    If Me.CtlHorno1.Horno Is Nothing Then
      mSeccionHornos = Nothing
      Me.lstseccionhorno.DataSource = mSeccionHornos
      Me.lstseccionhorno.ValueMember = "Sec_codigo"
      Me.lstseccionhorno.DisplayMember = "Sec_codigo"
    Else
      lstseccionhorno.Enabled = False
      Me.lstseccionhorno.BeginUpdate()
      Me.lstseccionhorno.DataSource = Nothing
      Me.lstseccionhorno.Items.Clear()
      Me.mSeccionHornos = SeccionHorno.RetornarSeccionHornos(Me.mOp, Me.CtlHorno1.Horno)
      Me.lstseccionhorno.ValueMember = "Sec_codigo"
      Me.lstseccionhorno.DisplayMember = "Sec_codigo"
      Me.lstseccionhorno.DataSource = mSeccionHornos
      Me.lstseccionhorno.EndUpdate()
      lstseccionhorno.Enabled = True
    End If
  End Sub

  Private Sub lstSeccionHorno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstseccionhorno.SelectedIndexChanged
    If Not lstseccionhorno.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioSeccionHorno()
  End Sub
End Class
