Imports System.ComponentModel
Imports System.Windows.Forms.SendKeys
Imports System.Drawing
Imports System.Windows.Forms

Public Enum EnumTipoTexto
  Ninguno
  SoloTexto
  SoloNumeros
End Enum

<ToolboxBitmap(GetType(TextBox))> _
Public Class TextBoxStd
  Inherits System.Windows.Forms.TextBox

  'Windows message constants
  Const WM_SETFOCUS As Integer = 7
  Const WM_KILLFOCUS As Integer = 8
  Const WM_ERASEBKGND As Integer = 14
  Const WM_PAINT As Integer = 15

  Protected _TipoTexto As EnumTipoTexto = EnumTipoTexto.Ninguno
  Private _drawPrompt As Boolean = True
  Private _promptText As String = String.Empty
  Private _promptColor As Color = SystemColors.GrayText
  Private _promptFont As Font = Nothing

  <Browsable(True), Category("Behavior"), DefaultValue(EnumTipoTexto.Ninguno), _
  Description("Indica si acepta solo texto sin números")> _
  Public Property TipoTexto() As EnumTipoTexto
    Get
      Return _TipoTexto
    End Get
    Set(ByVal Value As EnumTipoTexto)
      _TipoTexto = Value
    End Set
  End Property

  <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), Category("Appearance"), Description("The prompt text to display when there is nothing in the Text property.")> _
  Public Property PromptText() As String
    Get
      Return _promptText
    End Get
    Set(ByVal value As String)
      _promptText = value.Trim
      Me.Invalidate()
    End Set
  End Property

  <Browsable(true),EditorBrowsable(EditorBrowsableState.Always),Category("Appearance"),Description("The ForeColor to use when displaying the PromptText.")> _
  Public Property PromptForeColor() As Color
    Get
      Return _promptColor
    End Get
    Set(ByVal value As Color)
      _promptColor = value
      Me.Invalidate()
    End Set
  End Property

  <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), Category("Appearance"), Description("The Font to use when displaying the PromptText.")> _
  Public Property PromptFont() As Font
    Get
      Return _promptFont
    End Get
    Set(ByVal value As Font)
      _promptFont = value
      Me.Invalidate()
    End Set
  End Property

  Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    MyBase.OnPaint(e)

    ' Only draw the prompt in the OnPaint event and when the Text property is empty
    If _drawPrompt AndAlso Me.Text.Length = 0 Then
      DrawTextPrompt(e.Graphics)
    End If
  End Sub

  Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
    Select Case m.Msg
      Case WM_SETFOCUS
        _drawPrompt = False
      Case WM_KILLFOCUS
        _drawPrompt = True
    End Select

    MyBase.WndProc(m)

    'Only draw the prompt on the WM_PAINT event and when the Text property is empty
    If m.Msg = WM_PAINT AndAlso _drawPrompt AndAlso Me.Text.Length = 0 AndAlso Not Me.GetStyle(ControlStyles.UserPaint) Then
      DrawTextPrompt()
    End If
  End Sub

  ''' <summary>
  ''' Overload to automatically create the Graphics region before drawing the text prompt
  ''' </summary>
  ''' <remarks>The Graphics region is disposed after drawing the prompt.</remarks>
  Protected Sub DrawTextPrompt()
    Dim g As Graphics = Me.CreateGraphics()
    DrawTextPrompt(g)
  End Sub

  ''' <summary>
  ''' Draws the PromptText in the TextBox.ClientRectangle using the PromptFont and PromptForeColor
  ''' </summary>
  ''' <param name="g">The Graphics region to draw the prompt on</param>
  Protected Sub DrawTextPrompt(ByVal g As Graphics)
    Dim flags As TextFormatFlags = TextFormatFlags.NoPadding Or TextFormatFlags.Top Or TextFormatFlags.EndEllipsis
    Dim rect As Rectangle = Me.ClientRectangle

    'Offset the rectangle based on the HorizontalAlignment, 
    'otherwise the display looks a little strange
    Select Case TextAlign
      Case HorizontalAlignment.Center
        flags = flags Or TextFormatFlags.HorizontalCenter
        rect.Offset(0, 1)
      Case HorizontalAlignment.Left
        flags = flags Or TextFormatFlags.Left
        rect.Offset(1, 1)
      Case HorizontalAlignment.Right
        flags = flags Or TextFormatFlags.Right
        rect.Offset(0, 1)
    End Select

    ' Draw the prompt text using TextRenderer
    TextRenderer.DrawText(g, _promptText, _promptFont, rect, _promptColor, Me.BackColor, flags)
  End Sub

  Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    MyBase.OnKeyPress(e)
    Dim strMasknoTexto As String
    strMasknoTexto = "0123456789+*-/\^().,!ªº@·$%&=?¿¡¨{}[]^*`ç<>_:""'"
    Dim strMaskNumeros As String
    strMaskNumeros = "0123456789/" & vbBack

    'Si el caracter presionado está permitido
    If TipoTexto = EnumTipoTexto.SoloTexto And strMasknoTexto.IndexOf(e.KeyChar) >= 0 Then
      e.Handled = True
    End If

    If TipoTexto = EnumTipoTexto.SoloNumeros And strMaskNumeros.IndexOf(e.KeyChar) < 0 Then
      e.Handled = True
    End If

    If (e.KeyChar = vbCr And Not Me.Multiline) OrElse (e.KeyChar = vbCr And (Me.ReadOnly OrElse Not Me.Enabled)) Then
      Send("{TAB}")
      e.Handled = True
    Else
      MyBase.OnKeyPress(e)
    End If
  End Sub

  Private Sub TextBoxStd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If Not Me.Multiline Then
      Select Case e.KeyCode
        Case Keys.Up
          Send("+{TAB}")
          e.Handled = True
        Case Keys.Down
          Send("{TAB}")
          e.Handled = True
      End Select
    End If
  End Sub

  Private mMensaje As String = ""
  Public Property Mensaje() As String
    Get
      Return mMensaje
    End Get
    Set(ByVal value As String)
      mMensaje = value
    End Set
  End Property

  Private mError As New ErrorProvider

  Public Sub PonerMensaje()
    mError.SetError(Me, mMensaje)
  End Sub

  Public Sub QuitarMensaje()
    mError.SetError(Me, "")
  End Sub

  Private Sub TextBoxStd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    Me.BackColor = SystemColors.Info
    Me.ForeColor = SystemColors.InfoText
  End Sub

  Private Sub TextBoxStd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
    If Me.ReadOnly OrElse Not Me.Enabled Then
      Me.BackColor = SystemColors.Control
      Me.ForeColor = SystemColors.ControlText
    Else
      Me.BackColor = SystemColors.Window
      Me.ForeColor = SystemColors.WindowText
    End If
  End Sub

  Public Sub New()
    Me.PromptFont = Me.Font
  End Sub
End Class
