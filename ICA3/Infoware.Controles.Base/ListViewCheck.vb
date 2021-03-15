Imports System.Windows.Forms
Public Class ListViewCheck
  Inherits System.Windows.Forms.UserControl

  Delegate Sub ListaCheckEventHandler(ByVal sender As Object, ByVal e As ListaCheckEventArgs)
  Public Event CambioCheck As ListaCheckEventHandler
  Public Event CambioSelectIndex As EventHandler
  Dim _activadochecktodos As Boolean = True

  Public ReadOnly Property EstadoCheck() As ListaCheckEnum
    Get
      If Me.chktodos.CheckState = CheckState.Checked Then
        Return ListaCheckEnum.Todos
      ElseIf Me.chktodos.CheckState = CheckState.Unchecked Then
        Return ListaCheckEnum.Ninguno
      Else
        Return ListaCheckEnum.Algunos
      End If
    End Get
  End Property

  Private Sub Lista_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lista.ItemCheck
    Dim _todos As Boolean = True
    Dim _ninguno As Boolean = True
    For t As Integer = 0 To Me.Lista.Items.Count - 1
      Dim _item As ListViewItem
      _item = Me.Lista.Items(t)
      Dim _check As Boolean
      If e.Index = t Then
        _check = e.NewValue
      Else
        _check = _item.Checked
      End If
      If _check Then
        _ninguno = False
      Else
        _todos = False
      End If
    Next

    _activadochecktodos = False
    Dim _listacheck As ListaCheckEventArgs
    If _todos Then
      _listacheck = New ListaCheckEventArgs(ListaCheckEnum.Todos)
      Me.chktodos.CheckState = CheckState.Checked
    ElseIf _ninguno Then
      _listacheck = New ListaCheckEventArgs(ListaCheckEnum.Ninguno)
      Me.chktodos.CheckState = CheckState.Unchecked
    Else
      _listacheck = New ListaCheckEventArgs(ListaCheckEnum.Algunos)
      Me.chktodos.CheckState = CheckState.Indeterminate
    End If
    _activadochecktodos = True
    RaiseEvent CambioCheck(Me, _listacheck)
  End Sub

  Private Sub chktodos_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chktodos.CheckStateChanged
    If Not _activadochecktodos Then
      Exit Sub
    End If
    Me.chktodos.Enabled = True
    Dim _cambiar As Boolean
    _cambiar = (chktodos.CheckState = CheckState.Checked)
    For Each _item As ListViewItem In Me.Lista.Items
      _item.Checked = _cambiar
    Next
    _activadochecktodos = False
    Me.chktodos.Checked = _cambiar
    _activadochecktodos = True
  End Sub

  Private Sub Lista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista.SelectedIndexChanged
    RaiseEvent CambioSelectIndex(Me, Nothing)
  End Sub
End Class

Public Enum ListaCheckEnum
  Todos
  Algunos
  Ninguno
End Enum
Public Class ListaCheckEventArgs
  Inherits EventArgs
  Public ListaCheckEnum As ListaCheckEnum
  Public Sub New(ByVal _ListaCheckEnum As ListaCheckEnum)
    ListaCheckEnum = _ListaCheckEnum
  End Sub
End Class