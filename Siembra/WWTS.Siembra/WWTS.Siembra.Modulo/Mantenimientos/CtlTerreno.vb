
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports Infoware.Datos

Public Class CtlTerreno
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlHacienda1.Op = value
    End Set
  End Property

  Private mTerrenos As TerrenoCollection
  Public Event CambioTerreno()

  Public Property Terreno() As Terreno
    Get
      If mTerrenos Is Nothing OrElse mTerrenos.Count = 0 Then
        Return Nothing
      Else
        Return mTerrenos(IIf(Me.lstterreno.SelectedIndex = -1, 0, Me.lstterreno.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Terreno)
      If Value Is Nothing Then
        Me.lstterreno.SelectedIndex = -1
      Else
        Me.CtlHacienda1.Hacienda = Value.Hacienda
        Cambiar_Hacienda()
        For t As Integer = 0 To Me.lstterreno.Items.Count - 1
          If mTerrenos(t).Trr_codigo = Value.Trr_codigo Then
            Me.lstterreno.SelectedIndex = t
            Exit For
          End If
        Next
        RaiseEvent CambioTerreno()
      End If
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal mHacienda As Hacienda = Nothing)
    Me.CtlHacienda1.llenar_datos(mHacienda)
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmTerreno
    fpat.Terreno = New Terreno(Op, "(Nuevo)", Me.CtlHacienda1.Hacienda)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmTerreno
    fpat.Terreno = Me.mTerrenos(Me.lstterreno.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmTerreno
    fpat.Terreno = Me.mTerrenos(Me.lstterreno.SelectedIndex)
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
    If Me.lstterreno.SelectedIndex = -1 Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlHacienda1_CambioHacienda() Handles CtlHacienda1.CambioHacienda
    Cambiar_Hacienda()
    RaiseEvent CambioTerreno()
  End Sub

  Private Sub Cambiar_Hacienda()
    If Me.CtlHacienda1.Hacienda Is Nothing Then
      mTerrenos = Nothing
      Me.lstterreno.DataSource = mTerrenos
      Me.lstterreno.ValueMember = "Trr_codigo"
      Me.lstterreno.DisplayMember = "Trr_nombre"
    Else
      lstterreno.Enabled = False
      Me.lstterreno.BeginUpdate()
      Me.lstterreno.DataSource = Nothing
      Me.lstterreno.Items.Clear()
      Me.mTerrenos = Terreno.RetornarTerrenos(Me.mOp, Me.CtlHacienda1.Hacienda)
      Me.lstterreno.ValueMember = "Trr_codigo"
      Me.lstterreno.DisplayMember = "Trr_nombre"
      Me.lstterreno.DataSource = mTerrenos
      Me.lstterreno.EndUpdate()
      lstterreno.Enabled = True
    End If
  End Sub

  Private Sub lstTerreno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstterreno.SelectedIndexChanged
    If Not lstterreno.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioTerreno()
  End Sub
End Class
