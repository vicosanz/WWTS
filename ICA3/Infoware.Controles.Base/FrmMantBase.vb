Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FrmMantBase
  Public Event AntesAceptar As CancelEventHandler
  Public Event AntesCancelar As CancelEventHandler

  Public Property TextoAceptar() As String
    Get
      Return OK_Button.Text
    End Get
    Set(ByVal value As String)
      OK_Button.Text = value
    End Set
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Dim ev As New CancelEventArgs
    RaiseEvent AntesAceptar(Me, ev)
    If Not ev.Cancel Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Dim ev As New CancelEventArgs
    RaiseEvent AntesCancelar(Me, ev)
    If Not ev.Cancel Then
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
    End If
  End Sub

  Private Sub FrmMantBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

  End Sub
End Class
