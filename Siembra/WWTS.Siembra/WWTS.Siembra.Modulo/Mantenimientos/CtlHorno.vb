
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

Public Class CtlHorno
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlTerreno1.Op = value
    End Set
  End Property

  Private mHornos As HornoCollection
  Public Event CambioHorno()

  Public Property Horno() As Horno
    Get
      If mHornos Is Nothing OrElse mHornos.Count = 0 Then
        Return Nothing
      Else
        Return mHornos(IIf(Me.lstHorno.SelectedIndex = -1, 0, Me.lstHorno.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Horno)
      If Value Is Nothing Then
        Me.lstHorno.SelectedIndex = -1
      Else
        Me.CtlTerreno1.Terreno = Value.Terreno
        Cambiar_Terreno()
        For t As Integer = 0 To Me.lstHorno.Items.Count - 1
          If mHornos(t).Hor_codigo = Value.Hor_codigo Then
            Me.lstHorno.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioHorno()
    End Set
  End Property

  Public Sub llenar_datos()
    Me.CtlTerreno1.llenar_datos()
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmHorno
    fpat.Horno = New Horno(Op, "(Nuevo)", Me.CtlTerreno1.Terreno)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmHorno
    fpat.Horno = Me.mHornos(Me.lstHorno.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmHorno
    fpat.Horno = Me.mHornos(Me.lstHorno.SelectedIndex)
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
    If Me.lstHorno.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlTerreno1_CambioTerreno() Handles CtlTerreno1.CambioTerreno
    Cambiar_Terreno()
    RaiseEvent CambioHorno()
  End Sub

  Private Sub Cambiar_Terreno()
    If Me.CtlTerreno1.Terreno Is Nothing Then
      mHornos = Nothing
      Me.lstHorno.DataSource = mHornos
      Me.lstHorno.ValueMember = "Hor_codigo"
      Me.lstHorno.DisplayMember = "Hor_codigo"
    Else
      lstHorno.Enabled = False
      Me.lstHorno.BeginUpdate()
      Me.lstHorno.DataSource = Nothing
      Me.lstHorno.Items.Clear()
      Me.mHornos = Horno.RetornarHornos(Me.mOp, Me.CtlTerreno1.Terreno)
      Me.lstHorno.ValueMember = "Hor_codigo"
      Me.lstHorno.DisplayMember = "Hor_codigo"
      Me.lstHorno.DataSource = mHornos
      Me.lstHorno.EndUpdate()
      lstHorno.Enabled = True
    End If
  End Sub

  Private Sub lstHorno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHorno.SelectedIndexChanged
    If Not lstHorno.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioHorno()
  End Sub

End Class
