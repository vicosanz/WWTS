Imports System.Windows.Forms.SendKeys
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(MaskedTextBox))> _
Public Class MaskedTextBoxStd
  Inherits System.Windows.Forms.MaskedTextBox

  Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If e.KeyChar = vbCr Then
      Send("{TAB}")
      e.Handled = True
    Else
      MyBase.OnKeyPress(e)
    End If
  End Sub

  Private Sub MaskedTextBoxStd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    Me.SelectionStart = 0
    Me.SelectionLength = Me.Text.Length + 1
  End Sub

  Private Sub TextBoxStd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    Select Case e.KeyCode
      Case Keys.Up
        Send("+{TAB}")
        e.Handled = True
      Case Keys.Down
        Send("{TAB}")
        e.Handled = True
    End Select
  End Sub
End Class
