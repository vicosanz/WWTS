Imports System.Drawing
Imports System.Drawing.Printing

''' <summary>
''' This is a list of the possible text justification values
''' used by the 
''' <see cref="M:vbReport.ReportPageEventArgs.Write(System.String,vbReport.ReportLineJustification)" />
''' and
''' <see cref="M:vbReport.ReportPageEventArgs.WriteLine(System.String,vbReport.ReportLineJustification)" />
''' methods.
''' </summary>
Public Enum ReportLineJustification
  Left = 0
  Centered = 1
  Right = 2
End Enum


''' <summary>
''' The ReportPageEventArgs the type of the parameter provided by
''' the events raised from the <see cref="T:vbReport.ReportDocument" /> 
''' object. This class includes methods to simplify the process of
''' rendering text output into each page of the report.
''' </summary>
Public Class ReportPageEventArgs
  Inherits PrintPageEventArgs

  Private mFont As Font
  Private mBrush As Brush
  Private mPageNumber As Integer
  Private mX As Integer
  Private mY As Integer
  Private mFooterLines As Integer
  Private mLineHeight As Integer
  Private mPageBottom As Integer

  Public Property Font() As Font
    Get
      Return mFont
    End Get
    Set(ByVal value As Font)
      mFont = value
    End Set
  End Property

  Public Property FooterLines() As Integer
    Get
      Return mFooterLines
    End Get
    Set(ByVal value As Integer)
      mFooterLines = value
      mPageBottom = MarginBounds.Bottom - mFooterLines * mLineHeight - mLineHeight
      mLineHeight = CInt(mFont.GetHeight(Graphics))
    End Set
  End Property

  Friend Sub New(ByVal e As PrintPageEventArgs, _
      ByVal pageNumber As Integer, ByVal font As Font, _
      ByVal brush As Brush, ByVal _footerLines As Integer)

    MyBase.New(e.Graphics, e.MarginBounds, e.PageBounds, e.PageSettings)
    mPageNumber = pageNumber
    mFont = font
    mBrush = brush
    PositionToStart()
    FooterLines = _footerLines
  End Sub

#Region "Write"
  ''' <summary>
  ''' Writes some text to the report starting at the current cursor location.
  ''' The cursor is moved to the right, but not down to the next line.
  ''' </summary>
  ''' <param name="Text">The text to render.</param>
  Public Sub Write(ByVal Text As String)

    Graphics.DrawString(Text, mFont, mBrush, mX, mY)
    mX += CInt(Graphics.MeasureString(Text, mFont).Width)

  End Sub

  ''' <summary>
  ''' Writes text to the report on the current line, but justified based on
  ''' the justification parameter value. 
  ''' The cursor is moved to the right, but not down to the next line.
  ''' </summary>
  ''' <param name="Text">The text to render.</param>
  ''' <param name="Justification">Indicates the justification for the text.</param>
  Public Sub Write(ByVal Text As String, _
      ByVal Justification As ReportLineJustification)

    Select Case Justification
      Case ReportLineJustification.Left
        mX = MarginBounds.Left
      Case ReportLineJustification.Centered
        mX = MarginBounds.Left + CInt(MarginBounds.Width / 2 - _
          Graphics.MeasureString(Text, mFont).Width / 2)
      Case ReportLineJustification.Right
        mX = CInt(MarginBounds.Right - Graphics.MeasureString(Text, mFont).Width)
    End Select
    Write(Text)
  End Sub

  ''' <summary>
  ''' This method writes text into a specific column within the report on
  ''' the current line. It uses a <see cref="T:vbReport.ReportColumn" />
  ''' object to define the X position and width of the column. The cursor
  ''' is not moved by calling this method.
  ''' </summary>
  ''' <param name="Text">The text to render into the column.</param>
  ''' <param name="column">The <see cref="T:vbReport.ReportColumn" /> object defining this column.</param>
  Public Sub WriteColumn(ByVal Text As Object, ByVal column As ReportColumn)
    If Text Is Nothing Then
      Text = String.Empty
    End If

    Dim x As Integer = MarginBounds.Left + column.Left
    Graphics.FillRectangle(Brushes.White, New Rectangle(x, mY, column.Ancho, mLineHeight))

    Dim anchotexto As Integer = Graphics.MeasureString(Text.ToString, mFont).Width
    If TypeOf Text Is String Then
      Text = Text.ToString.Trim
      While anchotexto > column.Ancho
        Dim longitud As Integer = Text.Length
        If longitud = 0 Then
          Exit While
        Else
          Text = Text.Substring(0, longitud - 1)
        End If
        anchotexto = Graphics.MeasureString(Text.ToString, mFont).Width
      End While
    End If
    If Not column.Format.Trim = String.Empty AndAlso (TypeOf Text Is Integer OrElse TypeOf Text Is Decimal OrElse TypeOf Text Is Long) Then
      If column.Totalizar Then
        column.Suma += CDec(Text)
        column.Conteo += 1
      End If
      Text = CDec(Text).ToString(column.Format).ToString
    End If
    If TypeOf Text Is Boolean Then
      Text = IIf(CBool(Text), "Sí", "No")
    End If
    anchotexto = Graphics.MeasureString(Text.ToString, mFont).Width

    Select Case column.Justificacion
      Case EnumJustificacion.Centered
        x = (x + (column.Ancho / 2)) - (anchotexto / 2)
      Case EnumJustificacion.Right
        x = (x + column.Ancho) - anchotexto
    End Select

    If Not TypeOf text Is Dbnull Then
      Graphics.DrawString(Text, mFont, mBrush, x, mY)
    End If
  End Sub

  Public Sub WriteField(ByVal Text As Object, ByVal _Field As ReportField)
    'Graphics.DrawString(Text, _font, mBrush, _bounds.X, _bounds.Y)
    If Text Is Nothing Then
      Text = String.Empty
    End If
    Graphics.FillRectangle(Brushes.White, New Rectangle(New Point(mX + _Field.Location.X, mY + _Field.Location.Y), _Field.Size))

    Dim anchotexto As Integer = Graphics.MeasureString(Text.ToString, _Field.Font).Width
    If TypeOf Text Is String Then
      Text = Text.ToString.Trim
      While anchotexto > _Field.Size.Width
        Dim longitud As Integer = Text.Length
        If longitud = 0 Then
          Exit While
        Else
          Text = Text.Substring(0, longitud - 1)
        End If
        anchotexto = Graphics.MeasureString(Text.ToString, _Field.Font).Width
      End While
    End If
    If Not _Field.Format.Trim = String.Empty AndAlso (TypeOf Text Is Integer OrElse TypeOf Text Is Decimal OrElse TypeOf Text Is Long) Then
      'If column.Totalizar Then
      '  column.Suma += CDec(Text)
      '  column.Conteo += 1
      'End If
      Text = CDec(Text).ToString(_Field.Format).ToString
    End If
    If TypeOf Text Is Boolean Then
      Text = IIf(CBool(Text), "Sí", "No")
    End If
    anchotexto = Graphics.MeasureString(Text.ToString, _Field.Font).Width

    Dim x As Integer = _Field.Location.X
    Select Case _Field.Justificacion
      Case EnumJustificacion.Centered
        x = (x + (_Field.Size.Width / 2)) - (anchotexto / 2)
      Case EnumJustificacion.Right
        x = (x + _Field.Size.Width) - anchotexto
    End Select

    If Not TypeOf text Is dbnull Then
      Graphics.DrawString(Text, _Field.Font, mBrush, mX + x, mY + _Field.Location.Y)
    End If
  End Sub

  ''' <summary>
  ''' Moves the cursor down one line and to the left side of the page.
  ''' </summary>
  Public Sub WriteLine()

    mX = MarginBounds.Left
    mY += mLineHeight

  End Sub
  ''' <summary>
  ''' Writes text to the report starting at the current cursor location and 
  ''' then moves the cursor down one line and to the left side of the page.
  ''' </summary>
  ''' <param name="Text">The text to render.</param>
  Public Sub WriteLine(ByVal Text As String)

    Graphics.DrawString(Text, mFont, mBrush, mX, mY)
    WriteLine()

  End Sub
  ''' <summary>
  ''' Writes text to the report on the current line, but justified based on
  ''' the justification parameter value. 
  ''' The cursor is moved to the right, but not down to the next line.
  ''' </summary>
  ''' <param name="Text">The text to render.</param>
  ''' <param name="Justification">Indicates the justification for the text.</param>
  Public Sub WriteLine(ByVal Text As String, _
      ByVal Justification As ReportLineJustification)

    Select Case Justification
      Case ReportLineJustification.Left
        mX = MarginBounds.Left

      Case ReportLineJustification.Centered
        mX = MarginBounds.Left + CInt(MarginBounds.Width / 2 - _
          Graphics.MeasureString(Text, mFont).Width / 2)

      Case ReportLineJustification.Right
        mX = CInt(MarginBounds.Right - Graphics.MeasureString(Text, mFont).Width)

    End Select
    Write(Text)
    WriteLine()

  End Sub

  Public Sub WriteLine(ByVal Text As String, _
    ByVal Justification As ReportLineJustification, ByVal _font As Font)
    Dim _fontanterior As Font = mFont
    mFont = _font
    WriteLine(Text, Justification)
    mFont = _fontanterior
  End Sub

  ''' <summary>
  ''' Draws a horizontal line across the width of the page on the current
  ''' line. After the line is drawn the cursor is moved down one line and
  ''' to the left side of the page.
  ''' </summary>
  Public Sub HorizontalRule()

    Dim y As Integer = mY + CInt(mLineHeight / 2)

    Graphics.DrawLine(Pens.Black, MarginBounds.Left, y, MarginBounds.Right, y)
    WriteLine()

  End Sub
#End Region

#Region "Cursor"
  ''' <summary>
  ''' Sets or returns the current X position (left to right) of the
  ''' cursor on the page.
  ''' </summary>
  ''' <value>The horizontal position of the cursor.</value>
  Public Property CurrentX() As Integer
    Get
      Return mX
    End Get
    Set(ByVal Value As Integer)
      mX = Value
    End Set
  End Property

  ''' <summary>
  ''' Sets or returns the current Y position (top to bottom) of the
  ''' cursor on the page.
  ''' </summary>
  ''' <value>The vertical position of the cursor.</value>
  Public Property CurrentY() As Integer
    Get
      Return mY
    End Get
    Set(ByVal Value As Integer)
      mY = Value
    End Set
  End Property

  ''' <summary>
  ''' Moves the cursor to the top left corner of the page.
  ''' </summary>
  Public Sub PositionToStart()
    mX = MarginBounds.Left
    mY = MarginBounds.Top
  End Sub
#End Region

  ''' <summary>
  ''' Returns the Y value correspondign to the bottom of the page
  ''' body. This is the position immediately above the start of the 
  ''' page footer.
  ''' </summary>
  ''' <value>The Y value of the bottom of the page.</value>
  Public ReadOnly Property PageBottom() As Integer
    Get
      Return mPageBottom + mLineHeight
    End Get
  End Property

  ''' <summary>
  ''' Returns True if the cursor's current location is beyond the bottom of
  ''' the page body. This doesn't mean we're into the bottom margin, but may
  ''' indicate that the cursor in the page's footer region.
  ''' </summary>
  ''' <value>A Boolean indicating whether the cursor is past the end of the page.</value>
  Public ReadOnly Property EndOfPage() As Boolean
    Get
      Return mY >= mPageBottom
    End Get
  End Property

  ''' <summary>
  ''' Returns the page number of the current page. This value is automatically
  ''' incremented as each new page is rendered.
  ''' </summary>
  ''' <value>The current page number.</value>
  Public ReadOnly Property PageNumber() As Integer
    Get
      Return mPageNumber
    End Get
  End Property

End Class
