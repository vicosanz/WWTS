
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

Public Class CtlLote
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

  Private mLotes As LoteTerrenoCollection
  Public Event CambioLote()

  Public Property Lote() As LoteTerreno
    Get
      If mLotes Is Nothing OrElse mLotes.Count = 0 Then
        Return Nothing
      Else
        Return mLotes(IIf(Me.lstlote.SelectedIndex = -1, 0, Me.lstlote.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As LoteTerreno)
      If Value Is Nothing Then
        Me.lstlote.SelectedIndex = -1
      Else
        Me.CtlTerreno1.Terreno = Value.Terreno
        Cambiar_Terreno()
        For t As Integer = 0 To Me.lstlote.Items.Count - 1
          If mLotes(t).Lot_codigo = Value.Lot_codigo Then
            Me.lstlote.SelectedIndex = t
            Exit For
          End If
        Next
        RaiseEvent CambioLote()
      End If
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _terreno As Terreno = Nothing)
    Me.CtlTerreno1.llenar_datos()
    Me.CtlTerreno1.Terreno = _terreno
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmLote
    fpat.Lote = New LoteTerreno(Op, Me.CtlTerreno1.Terreno)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmLote
    fpat.Lote = Me.mLotes(Me.lstlote.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmLote
    fpat.Lote = Me.mLotes(Me.lstlote.SelectedIndex)
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
    If Me.lstlote.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlTerreno1_CambioTerreno() Handles CtlTerreno1.CambioTerreno
    Cambiar_Terreno()
    RaiseEvent CambioLote()
  End Sub

  Private Sub Cambiar_Terreno()
    If Me.CtlTerreno1.Terreno Is Nothing Then
      mLotes = Nothing
      Me.lstlote.DataSource = mLotes
      Me.lstlote.ValueMember = "Lot_codigo"
      Me.lstlote.DisplayMember = "Lot_codigo"
    Else
      lstlote.Enabled = False
      Me.lstlote.BeginUpdate()
      Me.lstlote.DataSource = Nothing
      Me.lstlote.Items.Clear()
      Me.mLotes = LoteTerreno.RetornarLotes(Me.mOp, Me.CtlTerreno1.Terreno)
      Me.lstlote.ValueMember = "Lot_codigo"
      Me.lstlote.DisplayMember = "Lot_codigo"
      Me.lstlote.DataSource = mLotes
      Me.lstlote.EndUpdate()
      lstlote.Enabled = True
    End If
  End Sub

  Private Sub lstLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstlote.SelectedIndexChanged
    If Not lstlote.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioLote()
  End Sub

End Class
