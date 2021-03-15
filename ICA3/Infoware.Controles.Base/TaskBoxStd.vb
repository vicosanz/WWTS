Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Drawing.Imaging

'<Designer(GetType(TaskBoxStdDesigner)), DesignTimeVisibleAttribute(True)> _
Public Class TaskBoxStd

  Public Sub New()
    MyBase.New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    SetStyle(ControlStyles.ResizeRedraw, True)
    SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    SetStyle(ControlStyles.UserPaint, True)
    SetStyle(ControlStyles.DoubleBuffer, True)
    SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    SetStyle(ControlStyles.ContainerControl, True)

    MyBase.BackColor = Color.Transparent
  End Sub

  Private mIcon As Icon

  <Description("Icon"), _
    Category("Appearance"), _
    Localizable(True), _
    DefaultValue(GetType(Icon), "")> _
    Public Property Icon() As Icon
    Get
      Return mIcon
    End Get
    Set(ByVal value As Icon)
      mIcon = value
      Me.Invalidate()
    End Set
  End Property

  Private mExpanded As Boolean = True

  <Description("Shows the toolbox expanded or collapsed"), _
  Category("Appearance"), _
  DefaultValue(True)> _
  Public Property IsExpanded() As Boolean
    Get
      Return mExpanded
    End Get
    Set(ByVal value As Boolean)
      mExpanded = value
      ChangeHeight()
      Me.Invalidate()
    End Set
  End Property

  Private mModoMini As Boolean = False

  <Description("Shows the toolbox expanded or collapsed"), _
  Category("Appearance"), _
  DefaultValue(False)> _
  Public Property IsModoMini() As Boolean
    Get
      Return mModoMini
    End Get
    Set(ByVal value As Boolean)
      mModoMini = value
      AjustarTamanio()
      Me.Invalidate()
    End Set
  End Property

  Private mChevronRight As Boolean = True

  <Description("Muestra el colapsador en la derecha o izquierda"), _
  Category("Appearance"), _
  DefaultValue(True)> _
  Public Property isChevronRight() As Boolean
    Get
      Return mChevronRight
    End Get
    Set(ByVal value As Boolean)
      mChevronRight = value
      Me.Invalidate()
    End Set
  End Property

  Private mHighlighted As Boolean = False
  <Description("Shows the toolbox highlighted (selected)"), _
  Category("Appearance"), _
  DefaultValue(False)> _
  Public Property Highlighted() As Boolean
    Get
      Return mHighlighted
    End Get
    Set(ByVal value As Boolean)
      mHighlighted = value
    End Set
  End Property

  Private mintHeight As Integer
  Private Sub ChangeHeight()
    If Not mExpanded Then
      ' Remember height so we can restore it later.
      mintHeight = Me.Height

      ' Set the new height and let others know we have been collapsed
      Me.Height = minheight
      OnCollapsed(New EventArgs)
      HideChildControls()
    Else
      Me.Height = mintHeight
      OnExpanded(New EventArgs)
      ShowChildControls()
    End If
  End Sub

  Private mControlState As New Hashtable

  Private Sub HideChildControls()
    mControlState.Clear()
    For Each child As Control In Me.Controls
      mControlState.Add(child.Name, child.Visible)
      If child.Top > regionantes + minheight Then
        child.Visible = False
      End If
    Next
  End Sub

  Private Sub ShowChildControls()
    For Each child As Control In Me.Controls
      If mControlState.ContainsKey(child.Name) Then
        child.Visible = CBool(mControlState.Item(child.Name))
      Else
        child.Visible = True
      End If
    Next
  End Sub

  Private mstrHeaderText As String = ""
  <Description("Caption text."), DefaultValue("Title"), Category("Appearance"), Browsable(True), Localizable(True)> _
  Public Property HeaderText() As String
    Get
      Return mstrHeaderText
    End Get
    Set(ByVal value As String)
      mstrHeaderText = value
      Me.Invalidate()
    End Set
  End Property

  <Description("returns the usable region as Rectangle"), Browsable(False)> _
  Friend ReadOnly Property WorkspaceRect() As Rectangle
    Get
      Return New Rectangle(3, minheight + 1, Me.Width - 7, Me.Height - minheight - 4)
    End Get
  End Property

#Region "Custom Painting"
  Private regionantes As Integer = 16
  Private minheight As Integer = 50

  Private Sub AjustarTamanio()
    If mModoMini = False Then
      regionantes = 16
      minheight = 50
    Else
      regionantes = 5
      minheight = 30
    End If
    Me.Padding = New System.Windows.Forms.Padding(4, minheight + 2, 4, 4)
  End Sub

  Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    MyBase.OnPaint(e)

    Dim pct As New ProfessionalColorTable

    e.Graphics.SmoothingMode = SmoothingMode.HighQuality

    Dim lrectHeader As New RectangleF(0, regionantes, Me.Width, minheight - regionantes)
    Dim lrectHeaderText As RectangleF
    Dim lrectAll As New RectangleF(0, regionantes, Me.Width, Me.Height - regionantes)

    Dim gp As New GraphicsPath
    'Dim lbrushHeader As New LinearGradientBrush(lrectHeader, mThemeFormat.LeftHeaderColor, mThemeFormat.RightHeaderColor, LinearGradientMode.Horizontal)
    Dim lbrushHeader As New LinearGradientBrush(lrectHeader, pct.MenuItemPressedGradientBegin, pct.MenuItemPressedGradientEnd, LinearGradientMode.Horizontal)

    'Dim lpenBorder As New Pen(mThemeFormat.BorderColor, 1)
    Dim lpenBorder As New Pen(pct.ImageMarginGradientMiddle, 1)
    Dim stringFmt As New StringFormat

    stringFmt.Alignment = StringAlignment.Near
    stringFmt.LineAlignment = StringAlignment.Center
    stringFmt.Trimming = StringTrimming.EllipsisCharacter
    stringFmt.FormatFlags = StringFormatFlags.NoWrap

    lpenBorder.Alignment = PenAlignment.Inset

    'body
    If mExpanded Then
      gp = Paths.RoundedRect(lrectAll, 3, 1, Corner.All)
      'e.Graphics.FillPath(New SolidBrush(mThemeFormat.BodyColor), gp)
      e.Graphics.FillPath(New SolidBrush(pct.ImageMarginGradientMiddle), gp)
    End If

    'titelleiste
    If mExpanded Then
      gp = Paths.RoundedRect(lrectHeader, 3, 1, Corner.TopLeft Or Corner.TopRight)
    Else
      gp = Paths.RoundedRect(lrectHeader, 3, 1, Corner.All)
    End If
    e.Graphics.FillPath(lbrushHeader, gp)

    ' Draw the outline around the work area
    If mExpanded Then
      gp = Paths.RoundedRect(lrectAll, 3, 1, Corner.All)
    End If
    e.Graphics.DrawPath(lpenBorder, gp)

    'draw icon
    If (mIcon IsNot Nothing AndAlso Not mModoMini) OrElse Not mChevronRight Then
      If mChevronRight Then
        e.Graphics.DrawIcon(New Icon(mIcon, New Size(32, 32)), New Rectangle(4, 8, 32, 32))
      End If
      lrectHeaderText = New RectangleF(40, regionantes + 2 - IIf(mModoMini, 2, 0), Me.Width - 42, 24)
    Else
      lrectHeaderText = New RectangleF(16, regionantes + 2 - IIf(mModoMini, 2, 0), Me.Width - 32, 24)
    End If

    Dim _rectchevron As Rectangle
    If mChevronRight Then
      _rectchevron = New Rectangle(Me.Width - 24, regionantes + 7 - IIf(mModoMini, 4, 0), 21, 21)
    Else
      _rectchevron = New Rectangle(10, regionantes + 7 - IIf(mModoMini, 4, 0), 21, 21)
    End If

    e.Graphics.DrawImage(CType(IIf(mExpanded, IIf(mHighlighted, My.Resources.NormalColor_Generic_up_over, My.Resources.NormalColor_Generic_up), IIf(mHighlighted, My.Resources.NormalColor_Generic_down_over, My.Resources.NormalColor_Generic_down)), Image), _rectchevron)

    e.Graphics.DrawString(mstrHeaderText, SystemFonts.CaptionFont, CType(IIf(mHighlighted, New SolidBrush(SystemColors.InactiveCaptionText), New SolidBrush(SystemColors.InfoText)), SolidBrush), lrectHeaderText, stringFmt)

    'dispose all objects
    lrectHeader = Nothing
    lrectHeaderText = Nothing
    'lrectBody = Nothing
    lrectAll = Nothing
    gp.Dispose()
    lbrushHeader.Dispose()
    lpenBorder.Dispose()
    stringFmt.Dispose()
  End Sub
#End Region

#Region "Mouse Actions"
  Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
    ' Change cursor to hand when over caption area.
    Dim bChanged As Boolean = False

    If e.Y <= minheight Then
      Windows.Forms.Cursor.Current = Cursors.Hand
      If mHighlighted = False Then
        mHighlighted = True
        bChanged = True
      End If
    Else
      Windows.Forms.Cursor.Current = Cursors.Default
      If mHighlighted = True Then
        mHighlighted = False
        bChanged = True
      End If
    End If

    If bChanged Then
      Me.Invalidate()
    End If

  End Sub

  Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
    ' Don't do anything if did not click on caption.
    If e.Y > minheight Then
      Return
    End If

    ' Toggle expanded flag.
    mExpanded = Not mExpanded

    ' Expand or collapse the control based on its current state
    ChangeHeight()
    Me.Refresh()
  End Sub

  Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
    If mHighlighted Then
      mHighlighted = False
      Me.Invalidate()
    End If
  End Sub
#End Region

#Region "events"
  Public Event Collapsed(ByVal sender As Object, ByVal e As EventArgs)
  Public Event Expanded(ByVal sender As Object, ByVal e As EventArgs)

  Protected Overridable Sub OnCollapsed(ByVal e As EventArgs)
    RaiseEvent Collapsed(Me, e)
  End Sub

  Protected Overridable Sub OnExpanded(ByVal e As EventArgs)
    RaiseEvent Expanded(Me, e)
  End Sub
#End Region
End Class

'Public Class TaskBoxStdDesigner
'  Inherits BaseDesigner

'  Private m_Control As TaskBoxStd

'  Public Sub New()
'    MyBase.New()
'  End Sub

'  Public Overrides Sub Initialize(ByVal component As System.ComponentModel.IComponent)
'    MyBase.Initialize(component)
'    m_Control = CType(Me.Control, TaskBoxStd)
'  End Sub

'  Protected Overrides Sub OnPaintAdornments(ByVal pe As PaintEventArgs)
'    MyBase.OnPaintAdornments(pe)
'    pe.Graphics.DrawRectangle(m_WorkspacePen, m_Control.WorkspaceRect)
'  End Sub
'End Class
