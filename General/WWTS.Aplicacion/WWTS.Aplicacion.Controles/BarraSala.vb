Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Slots.Reglas

Public Class BarraSala
  Inherits System.Windows.Forms.ToolStrip

#Region "New"
  Sub New()
    MyBase.New()

    cbosala = New System.Windows.Forms.ToolStripComboBox

    Me.cbosala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbosala.Name = "cbosala"
    Me.cbosala.Size = New System.Drawing.Size(121, 25)
    Me.cbosala.MergeAction = MergeAction.Insert
    Me.cbosala.MergeIndex = 0

    Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {cbosala})
  End Sub
#End Region

#Region "Componentes"
  Friend WithEvents cbosala As System.Windows.Forms.ToolStripComboBox
#End Region

  Private mSistema As Sistema
  Public Property Sistema() As Sistema
    Get
      Return mSistema
    End Get
    Set(ByVal value As Sistema)
      mSistema = value
      If value IsNot Nothing Then
        Llenar_datos()
      End If
    End Set
  End Property

#Region "Sala"
  Private mSalas As SalaxUsuarioList = Nothing

  Public Property Sala() As SalaxUsuario
    Get
      Try
        Return mSalas(Me.cbosala.ComboBox.SelectedIndex)
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
    Set(ByVal value As SalaxUsuario)
      Me.cbosala.SelectedItem = value
    End Set
  End Property

  Private mSalaVisible As Boolean = True
  Public Property SalaVisible() As Boolean
    Get
      Return mSalaVisible
    End Get
    Set(ByVal value As Boolean)
      mSalaVisible = value
      Me.cbosala.Visible = mSalaVisible
    End Set
  End Property
#End Region

  Private mEstaLlenando As Boolean = False
  Public Sub Llenar_datos()
    mEstaLlenando = True

    Dim _usuario As WWTSUsuario
    _usuario = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)


    mSalas = SalaxUsuarioList.ObtenerLista(mSistema.OperadorDatos, _usuario, True)
    Me.cbosala.ComboBox.DisplayMember = "Sala"
    Me.cbosala.ComboBox.ValueMember = "Pardet_Sala"
    Me.cbosala.ComboBox.DataSource = mSalas

    Try
      Me.cbosala.SelectedIndex = My.Settings.salaactual
    Catch ex As Exception
    End Try

    mEstaLlenando = False
  End Sub

  Public Event CambioDatos As EventHandler

  Private Sub cbosala_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosala.SelectedIndexChanged
    GuardarCambios()
  End Sub

  Sub GuardarCambios()
    If mEstaLlenando Then
      Exit Sub
    End If
    My.Settings.salaactual = Me.cbosala.SelectedIndex
    My.Settings.Save()
    RaiseEvent CambioDatos(Me, Nothing)
  End Sub
End Class
