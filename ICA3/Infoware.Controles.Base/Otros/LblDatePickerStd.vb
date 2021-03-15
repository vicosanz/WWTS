Public Class LblDatePickerStd
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

  Public Property Value() As Date
    Get
      Return Me.DateTimePickerStd1.Value
    End Get
    Set(ByVal value As Date)
      Me.DateTimePickerStd1.Value = value
    End Set
  End Property

  Private Sub LblTextBoxStd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    formatear()
  End Sub

  Sub formatear()
    If mDireccion = enumDireccion.Derecha Then
      Me.DateTimePickerStd1.Top = 0
      Me.DateTimePickerStd1.Left = 150
      Me.DateTimePickerStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

      Me.Height = Me.DateTimePickerStd1.Height
      Select Case Me.DateTimePickerStd1.Width
        Case Is < 230
          Me.Width = 180 + Me.DateTimePickerStd1.Left
          Me.DateTimePickerStd1.Width = 180
        Case Is < 400
          Me.Width = 340 + Me.DateTimePickerStd1.Left
          Me.DateTimePickerStd1.Width = 340
      End Select
    Else
      Me.DateTimePickerStd1.Top = 20
      Me.DateTimePickerStd1.Left = 0
      Me.DateTimePickerStd1.Height = Me.Height - 20
      Me.DateTimePickerStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)

      'If Not Me.DateTimePickerStd1.Multiline Then
      Me.Height = Me.DateTimePickerStd1.Height + Me.DateTimePickerStd1.Top
      'Else
      '  Select Case Me.Height
      '    Case Is < 80
      '      Me.Height = 60
      '      'Me.DateTimePickerStd1.Height = Me.Height - Me.Top
      '  End Select
      'End If
      'Me.Height = Me.DateTimePickerStd1.Height
      Select Case Me.Width
        Case Is < 250
          Me.Width = 150
          Me.DateTimePickerStd1.Width = 150
        Case Is < 400
          Me.Width = 330
          Me.DateTimePickerStd1.Width = 330
      End Select
    End If
  End Sub
End Class
