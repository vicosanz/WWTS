Public Class LblTextBoxStd
  Private mesPassword As Boolean = False
  Public Property esPassword() As Boolean
    Get
      Return Not Me.TextBoxStd1.PasswordChar = Nothing
    End Get
    Set(ByVal value As Boolean)
      If value Then
        Me.TextBoxStd1.PasswordChar = "*"
        Me.TextBoxStd1.UseSystemPasswordChar = True
      Else
        Me.TextBoxStd1.PasswordChar = Nothing
      End If
    End Set
  End Property

  Private mMultiLine As Boolean = False
  Public Property MultiLine() As Boolean
    Get
      Return mMultiLine
    End Get
    Set(ByVal value As Boolean)
      mMultiLine = value
      If mDireccion = enumDireccion.Derecha Then
        Me.TextBoxStd1.Multiline = False
      Else
        Me.TextBoxStd1.Multiline = value
      End If
    End Set
  End Property

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
      Return Me.TextBoxStd1.Text
    End Get
    Set(ByVal value As String)
      Me.TextBoxStd1.Text = value
    End Set
  End Property

  Private Sub LblTextBoxStd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    formatear()
  End Sub

  Sub formatear()
    If mDireccion = enumDireccion.Derecha Then
      Me.TextBoxStd1.Top = 0
      Me.TextBoxStd1.Left = 150
      Me.TextBoxStd1.Multiline = False
      Me.TextBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

      Me.Height = Me.TextBoxStd1.Height
      Select Case Me.TextBoxStd1.Width
        Case Is < 230
          Me.Width = 180 + Me.TextBoxStd1.Left
          Me.TextBoxStd1.Width = 180
        Case Is < 400
          Me.Width = 340 + Me.TextBoxStd1.Left
          Me.TextBoxStd1.Width = 340
      End Select
    Else
      Me.TextBoxStd1.Top = 20
      Me.TextBoxStd1.Left = 0
      Me.TextBoxStd1.Height = Me.Height - 20
      Me.TextBoxStd1.Multiline = mMultiLine
      Me.TextBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)

      If Not Me.TextBoxStd1.Multiline Then
        Me.Height = Me.TextBoxStd1.Height + Me.TextBoxStd1.Top
      Else
        Select Case Me.Height
          Case Is < 80
            Me.Height = 60
            'Me.TextBoxStd1.Height = Me.Height - Me.Top
        End Select
      End If
      'Me.Height = Me.TextBoxStd1.Height
      Select Case Me.Width
        Case Is < 250
          Me.Width = 150
          Me.TextBoxStd1.Width = 150
        Case Is < 400
          Me.Width = 330
          Me.TextBoxStd1.Width = 330
      End Select
    End If
  End Sub

  Private Sub TextBoxStd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxStd1.TextChanged

  End Sub
End Class
