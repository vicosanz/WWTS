Imports System.Windows.Forms.SendKeys
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.ComponentModel
Imports System.ComponentModel.Design

<ToolboxBitmap(GetType(DateTimePicker))> _
Public Class DateTimePickerStd
  Inherits DateTimePicker

  Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If e.KeyChar = vbCr Then
      Send("{TAB}")
      e.Handled = True
    Else
      MyBase.OnKeyPress(e)
    End If
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

  Private Sub TextBoxStd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    Me.BackColor = SystemColors.Info
    Me.ForeColor = SystemColors.InfoText
  End Sub

  Private Sub TextBoxStd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
    Me.BackColor = SystemColors.Window
    Me.ForeColor = SystemColors.WindowText
  End Sub
End Class
