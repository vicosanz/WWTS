<ToolboxBitmap(GetType(Button))> _
Public Class ButtonStd
  Inherits Button


  Private Sub ButtonStd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    If Me.Height > 34 Then
      Me.Height = 46
    Else
      Me.Height = 23
    End If

    If Me.Width > 97 AndAlso Me.Width < 130 Then
      Me.Width = 120
    ElseIf Me.Width <= 97 AndAlso Me.Width > 40 Then
      Me.Width = 75
    ElseIf Me.Width <= 40 Then
      Me.Width = 26
    End If
  End Sub
End Class
