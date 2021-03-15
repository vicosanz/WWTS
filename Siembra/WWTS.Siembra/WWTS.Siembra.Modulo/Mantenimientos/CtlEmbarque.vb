
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

Public Class CtlEmbarque
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlZafra1.Op = value
      If Not value Is Nothing Then
        Me.CtlZafra1.llenar_datos()
      End If
    End Set
  End Property

  Private mEmbarques As EmbarqueCollection
  Public Event CambioEmbarque()

  Public Property Embarque() As Embarque
    Get
      If mEmbarques Is Nothing OrElse mEmbarques.Count = 0 Then
        Return Nothing
      Else
        Return mEmbarques(IIf(Me.lstEmbarque.SelectedIndex = -1, 0, Me.lstEmbarque.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Embarque)
      If Value Is Nothing Then
        Me.lstEmbarque.SelectedIndex = -1
      Else
        Me.CtlZafra1.Zafra = Value.Zafra
        Cambiar_Zafra()
        For t As Integer = 0 To Me.lstEmbarque.Items.Count - 1
          If mEmbarques(t).Emb_codigo = Value.Emb_codigo Then
            Me.lstEmbarque.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioEmbarque()
    End Set
  End Property

  Public Sub llenar_datos()
    Me.CtlZafra1.llenar_datos()
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmEmbarque
    fpat.Embarque = New Embarque(Op, Me.CtlZafra1.Zafra)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmEmbarque
    fpat.Embarque = Me.mEmbarques(Me.lstEmbarque.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmEmbarque
    fpat.Embarque = Me.mEmbarques(Me.lstEmbarque.SelectedIndex)
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
    If Me.lstEmbarque.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlZafra1_CambioZafra() Handles CtlZafra1.CambioZafra
    Cambiar_Zafra()
    RaiseEvent CambioEmbarque()
  End Sub

  Private Sub Cambiar_Zafra()
    If Me.CtlZafra1.Zafra Is Nothing Then
      mEmbarques = Nothing
      Me.lstEmbarque.DataSource = mEmbarques
      Me.lstEmbarque.ValueMember = "Emb_codigo"
      Me.lstEmbarque.DisplayMember = "Descripcion"
    Else
      lstEmbarque.Enabled = False
      Me.lstEmbarque.BeginUpdate()
      Me.lstEmbarque.DataSource = Nothing
      Me.lstEmbarque.Items.Clear()
      Me.mEmbarques = Embarque.RetornarEmbarques(Me.mOp, Me.CtlZafra1.Zafra)
      Me.lstEmbarque.ValueMember = "Emb_codigo"
      Me.lstEmbarque.DisplayMember = "Descripcion"
      Me.lstEmbarque.DataSource = mEmbarques
      Me.lstEmbarque.EndUpdate()
      lstEmbarque.Enabled = True
    End If
  End Sub

  Private Sub lstEmbarque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmbarque.SelectedIndexChanged
    If Not lstEmbarque.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioEmbarque()
  End Sub

End Class
