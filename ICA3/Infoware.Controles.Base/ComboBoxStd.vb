Imports System.Windows.Forms.SendKeys
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.ComponentModel
Imports System.ComponentModel.Design

'<Designer(GetType(ComboBoxStdDesigner))> _
<ToolboxBitmap(GetType(ComboBox))> _
Public Class ComboBoxStd
  Inherits System.Windows.Forms.ComboBox

  Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If e.KeyChar = vbCr Then
      Send("{TAB}")
      e.Handled = True
    Else
      MyBase.OnKeyPress(e)
    End If
  End Sub

  'Private Sub TextBoxStd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
  '  Select Case e.KeyCode
  '    Case Keys.Up
  '      Send("+{TAB}")
  '      e.Handled = True
  '    Case Keys.Down
  '      Send("{TAB}")
  '      e.Handled = True
  '  End Select
  'End Sub

  Protected _AbriralEntrar As Boolean = True

  <Browsable(True), Category("Behavior"), DefaultValue(True), _
 TypeConverter(), Description("Abre el combobox cuando ingresa")> _
Public Property AbriralEntrar() As Boolean
    Get
      Return _AbriralEntrar
    End Get
    Set(ByVal Value As Boolean)
      _AbriralEntrar = Value
    End Set
  End Property

  Private Sub ComboBoxStd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    If _AbriralEntrar And Not mEstaMouse Then
      System.Windows.Forms.SendKeys.Send("{F4}")
    End If
  End Sub

  Private Sub ComboBoxStd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    Select Case e.KeyCode
      Case Keys.Left
        Send("+{TAB}")
        e.Handled = True
      Case Keys.Right
        Send("{TAB}")
        e.Handled = True
    End Select
  End Sub

  Private mEstaMouse As Boolean = False
  Private Sub ComboBoxStd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
    mEstaMouse = True
  End Sub

  Private Sub ComboBoxStd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
    mEstaMouse = False
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

'Public Class ComboBoxStdDesigner
'  Inherits ParentControlDesigner

'  Public Overrides ReadOnly Property Verbs() As DesignerVerbCollection
'    Get
'      Dim _verbs As DesignerVerbCollection = New DesignerVerbCollection
'      Dim _verb As New DesignerVerb("Abrir/No abrir combo al entrar", New EventHandler(AddressOf handleAbreCombo))
'      _verb.Checked = CType(Me.Control, ComboBoxStd).AbriralEntrar
'      If _verb.Checked Then
'        _verb.Description = "No abrir combo al entrar"
'      Else
'        _verb.Description = "Abrir combo al entrar"
'      End If
'      _verbs.Add(_verb)

'      Return _verbs
'    End Get
'  End Property

'  Private Sub handleAbreCombo(ByVal sender As Object, ByVal e As EventArgs)
'    Dim _combo As ComboBoxStd = CType(Me.Control, ComboBoxStd)

'    Dim h As IDesignerHost = CType(GetService(GetType(IDesignerHost)), IDesignerHost)
'    Dim c As IComponentChangeService = CType(GetService(GetType(IComponentChangeService)), IComponentChangeService)

'    Dim dt As DesignerTransaction = h.CreateTransaction("Abre Combo")


'    If (_combo.Parent IsNot Nothing) Then
'      Dim _control As Control = _combo.Parent
'      c.OnComponentChanging(_control, Nothing)

'      Dim _verb As DesignerVerb = CType(sender, DesignerVerb)
'      _verb.Checked = Not _verb.Checked
'      If _verb.Checked Then
'        _verb.Description = "No abrir combo al entrar"
'      Else
'        _verb.Description = "Abrir combo al entrar"
'      End If
'      _combo.AbriralEntrar = _verb.Checked


'      c.OnComponentChanged(_control, Nothing, Nothing, Nothing)
'      _combo.AbriralEntrar = True
'    End If

'    dt.Commit()
'  End Sub

'End Class