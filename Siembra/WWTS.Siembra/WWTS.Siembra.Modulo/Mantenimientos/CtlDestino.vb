
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

Public Class CtlDestino
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlPais1.OperadorDatos = value
      If Not value Is Nothing Then
        Me.CtlPais1.llenar_datos()
      End If
    End Set
  End Property

  Private mDestinos As DestinoCollection
  Public Event CambioDestino()

  Public Property Destino() As Destino
    Get
      If mDestinos Is Nothing OrElse mDestinos.Count = 0 Then
        Return Nothing
      Else
        Return mDestinos(IIf(Me.lstDestino.SelectedIndex = -1, 0, Me.lstDestino.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Destino)
      If Value Is Nothing Then
        Me.lstDestino.SelectedIndex = -1
      Else
        Me.CtlPais1.ParametroDet = Value.Pais
        Cambiar_Pais()
        For t As Integer = 0 To Me.lstDestino.Items.Count - 1
          If mDestinos(t).Des_codigo = Value.Des_codigo Then
            Me.lstDestino.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioDestino()
    End Set
  End Property

  Public Sub llenar_datos()
    Me.CtlPais1.llenar_datos()
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmDestino
    fpat.Destino = New Destino(Op, "(Nuevo)", True)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmDestino
    fpat.Destino = Me.mDestinos(Me.lstDestino.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmDestino
    fpat.Destino = Me.mDestinos(Me.lstDestino.SelectedIndex)
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
    If Me.lstDestino.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlPais1_CambioPais() Handles CtlPais1.CambioItem
    Cambiar_Pais()
    RaiseEvent CambioDestino()
  End Sub

  Private Sub Cambiar_Pais()
    If Me.CtlPais1.ParametroDet Is Nothing Then
      mDestinos = Nothing
      Me.lstDestino.DataSource = mDestinos
      Me.lstDestino.ValueMember = "Des_codigo"
      Me.lstDestino.DisplayMember = "Des_nombre"
    Else
      lstDestino.Enabled = False
      Me.lstDestino.BeginUpdate()
      Me.lstDestino.DataSource = Nothing
      Me.lstDestino.Items.Clear()
      Me.mDestinos = Destino.RetornarDestinos(Me.mOp, Me.CtlPais1.ParametroDet)
      Me.lstDestino.ValueMember = "Des_codigo"
      Me.lstDestino.DisplayMember = "Des_nombre"
      Me.lstDestino.DataSource = mDestinos
      Me.lstDestino.EndUpdate()
      lstDestino.Enabled = True
    End If
  End Sub

  Private Sub lstDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDestino.SelectedIndexChanged
    If Not lstDestino.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioDestino()
  End Sub

End Class
