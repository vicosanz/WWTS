Public Class LblComboBoxStd
  Private mDireccion As enumDireccion = enumDireccion.Derecha
  Public Property Direccion() As enumDireccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As enumDireccion)
      mDireccion = value
      formatear()
    End Set
  End Property

  Public Property Caption() As String
    Get
      Return Me.Label1.Text
    End Get
    Set(ByVal value As String)
      Me.Label1.Text = value
    End Set
  End Property

  Public Overrides Property Text() As String
    Get
      Return Me.ComboBoxStd1.Text
    End Get
    Set(ByVal value As String)
      Me.ComboBoxStd1.Text = value
    End Set
  End Property

  Private Sub LblComboBoxStd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    formatear()
  End Sub

  Sub formatear()
    If mDireccion = enumDireccion.Derecha Then
      Me.ComboBoxStd1.Top = 0
      Me.ComboBoxStd1.Left = 150
      Me.ComboBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

      Me.Height = Me.ComboBoxStd1.Height
      Select Case Me.ComboBoxStd1.Width
        Case Is < 230
          Me.Width = 180 + Me.ComboBoxStd1.Left
          Me.ComboBoxStd1.Width = 180
        Case Is < 400
          Me.Width = 340 + Me.ComboBoxStd1.Left
          Me.ComboBoxStd1.Width = 340
      End Select
    Else
      Me.ComboBoxStd1.Top = 20
      Me.ComboBoxStd1.Left = 0
      Me.ComboBoxStd1.Height = Me.Height - 20
      Me.ComboBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)

      Me.Height = Me.ComboBoxStd1.Height + Me.ComboBoxStd1.Top
      'Me.Height = Me.ComboBoxStd1.Height
      Select Case Me.Width
        Case Is < 250
          Me.Width = 150
          Me.ComboBoxStd1.Width = 150
        Case Is < 400
          Me.Width = 330
          Me.ComboBoxStd1.Width = 330
      End Select
    End If
  End Sub

  Public Event CambioItem As EventHandler

  Private Sub ComboBoxStd1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxStd1.SelectedValueChanged
    RaiseEvent CambioItem(Me, Nothing)
  End Sub

  Public Event AbrioCombo As EventHandler

  Private Sub ComboBoxStd1_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxStd1.DropDown
    RaiseEvent AbrioCombo(Me, Nothing)
  End Sub


End Class
