

Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports WWTS.General.Modulo

Public Class CtlCuarto
  Implements IDatos
  Private mOp As OperadorDatos
  Private mCuartos As CuartoCollection
  Private mHacienda As Hacienda
  Public Event CambioCuarto()

  Public Property op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal Value As OperadorDatos)
      mOp = Value
      Me.CtlTerreno1.Op = Value
    End Set
  End Property

  Public Property Cuarto() As Cuarto
    Get
      If mCuartos Is Nothing OrElse mCuartos.Count = 0 Then
        Return Nothing
      Else
        Return mCuartos(IIf(Me.lstCuarto.SelectedIndex = -1, 0, Me.lstCuarto.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As Cuarto)
      If Value Is Nothing Then
        Me.lstCuarto.SelectedIndex = -1
      Else
        CtlTerreno1.Terreno = Value.Terreno
        Cambiar_Terreno()
        For t As Integer = 0 To Me.lstCuarto.Items.Count - 1
          If mCuartos(t).Cto_codigo = Value.Cto_codigo Then
            Me.lstCuarto.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioCuarto()
    End Set
  End Property

  Public Property Hacienda() As Hacienda
    Get
      Return mHacienda
    End Get
    Set(ByVal Value As Hacienda)
      mHacienda = Value
    End Set
  End Property

  Public Sub llenar_datos()
    Me.CtlTerreno1.llenar_datos(mHacienda)
  End Sub

  Private Sub mnunuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunuevo.Click
    Dim fpat As New FrmCuarto
    fpat.Cuarto = New Cuarto(op, Me.CtlTerreno1.Terreno)
    fpat.Direccion = IMantenimiento.Accion.Ingreso
    fpat.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnueliminar.Click
    Dim fpat As New FrmCuarto
    fpat.Cuarto = Me.mCuartos(Me.lstCuarto.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Eliminacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnumodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodificar.Click
    Dim fpat As New FrmCuarto
    fpat.Cuarto = Me.mCuartos(Me.lstCuarto.SelectedIndex)
    fpat.Direccion = IMantenimiento.Accion.Modificacion
    If fpat.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub menu_Popup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Me.mnunuevo.Visible = True
    Me.mnueliminar.Visible = True
    Me.mnumodificar.Visible = True
    If mCuartos Is Nothing Then
      Me.mnueliminar.Visible = False
      Me.mnumodificar.Visible = False
    End If
  End Sub

  Private Sub CtlTerreno_CambioTerreno() Handles CtlTerreno1.CambioTerreno
    Cambiar_Terreno()
    RaiseEvent CambioCuarto()
  End Sub

  Private Sub Cambiar_Terreno()
    If Me.CtlTerreno1.Terreno Is Nothing Then
      mCuartos = Nothing
      Me.lstCuarto.DataSource = mCuartos
      Me.lstCuarto.ValueMember = "Cto_codigo"
      Me.lstCuarto.DisplayMember = "Cto_descripcion"
    Else
      Me.lstCuarto.Enabled = False
      Me.lstCuarto.BeginUpdate()
      Me.lstCuarto.DataSource = Nothing
      Me.lstCuarto.Items.Clear()
      Me.mCuartos = Cuarto.RetornarCuartos(Me.mOp, CtlTerreno1.Terreno)
      Me.lstCuarto.ValueMember = "Cto_codigo"
      Me.lstCuarto.DisplayMember = "Cto_descripcion"
      Me.lstCuarto.DataSource = mCuartos
      Me.lstCuarto.EndUpdate()
      Me.lstCuarto.Enabled = True
    End If
  End Sub

  Private Sub lstCuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCuarto.SelectedIndexChanged
    If Not lstCuarto.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioCuarto()
  End Sub
End Class
