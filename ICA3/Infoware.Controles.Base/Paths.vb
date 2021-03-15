Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Design

<Flags()> _
Friend Enum Corner
  None = 0
  TopLeft = 1
  TopRight = 2
  BottomLeft = 4
  BottomRight = 8
  All = TopLeft Or TopRight Or BottomLeft Or BottomRight
End Enum

''' -----------------------------------------------------------------------------
''' Project	 : XPCommonControls
''' Class	 : XPCommonControls.Paths
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' predefined paths for drawing routines
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[Mike]	14.03.2004	Created
''' </history>
''' -----------------------------------------------------------------------------
Friend Class Paths

#Region "RoundedRect"
  Public Shared Function RoundedRect(ByVal rect As RectangleF, Optional ByVal cornerradius As Integer = 5, Optional ByVal margin As Integer = 2, Optional ByVal roundedcorners As Corner = Corner.All) As Drawing2D.GraphicsPath
    Dim p As New Drawing2D.GraphicsPath
    Dim x As Single = rect.X, y As Single = rect.Y, w As Single = rect.Width, h As Single = rect.Height, m As Integer = margin, r As Integer = cornerradius

    p.StartFigure()
    'top left arc
    If CBool(roundedcorners And Corner.TopLeft) Then
      p.AddArc(New RectangleF(x + m, y + m, 2 * r, 2 * r), 180, 90)
    Else
      p.AddLine(New PointF(x + m, y + m + r), New PointF(x + m, y + m))
      p.AddLine(New PointF(x + m, y + m), New PointF(x + m + r, y + m))
    End If

    'top line
    p.AddLine(New PointF(x + m + r, y + m), New PointF(x + w - m - r, y + m))

    'top right arc
    If CBool(roundedcorners And Corner.TopRight) Then
      p.AddArc(New RectangleF(x + w - m - 2 * r, y + m, 2 * r, 2 * r), 270, 90)
    Else
      p.AddLine(New PointF(x + w - m - r, y + m), New PointF(x + w - m, y + m))
      p.AddLine(New PointF(x + w - m, y + m), New PointF(x + w - m, y + m + r))
    End If

    'right line
    p.AddLine(New PointF(x + w - m, y + m + r), New PointF(x + w - m, y + h - m - r))

    'bottom right arc
    If CBool(roundedcorners And Corner.BottomRight) Then
      p.AddArc(New RectangleF(x + w - m - 2 * r, y + h - m - 2 * r, 2 * r, 2 * r), 0, 90)
    Else
      p.AddLine(New PointF(x + w - m, y + h - m - r), New PointF(x + w - m, y + h - m))
      p.AddLine(New PointF(x + w - m, y + h - m), New PointF(x + w - m - r, y + h - m))
    End If

    'bottom line
    p.AddLine(New PointF(x + w - m - r, y + h - m), New PointF(x + m + r, y + h - m))

    'bottom left arc
    If CBool(roundedcorners And Corner.BottomLeft) Then
      p.AddArc(New RectangleF(x + m, y + h - m - 2 * r, 2 * r, 2 * r), 90, 90)
    Else
      p.AddLine(New PointF(x + m + r, y + h - m), New PointF(x + m, y + h - m))
      p.AddLine(New PointF(x + m, y + h - m), New PointF(x + m, y + h - m - r))
    End If

    'left line
    p.AddLine(New PointF(x + m, y + h - m - r), New PointF(x + m, y + m + r))

    'close figure...
    p.CloseFigure()

    Return p
  End Function

  'Public Shared Function RoundedRect(ByVal rect As RectangleF, ByVal cornerradius As Integer, ByVal margin As Integer) As Drawing2D.GraphicsPath
  '    Dim p As New Drawing2D.GraphicsPath
  '    Dim w As Integer = rect.Width, h As Integer = rect.Height, m As Integer = margin, r As Integer = cornerradius

  '    p.StartFigure()
  '    p.AddArc(New RectangleF(m, m, 2 * r, 2 * r), 180, 90)
  '    p.AddLine(New PointF(m + r, m), New PointF(w - m - r, m))
  '    p.AddArc(New RectangleF(w - m - 2 * r, m, 2 * r, 2 * r), 270, 90)
  '    p.AddLine(New PointF(w - m, m + r), New PointF(w - m, h - m - r))
  '    p.AddArc(New RectangleF(w - m - 2 * r, h - m - 2 * r, 2 * r, 2 * r), 0, 90)
  '    p.AddLine(New PointF(w - m - r, h - m), New PointF(m + r, h - m))
  '    p.AddArc(New RectangleF(m, h - m - 2 * r, 2 * r, 2 * r), 90, 90)
  '    p.AddLine(New PointF(m, h - m - r), New PointF(m, m + r))
  '    p.CloseFigure()

  '    Return p
  'End Function

  Public Shared Function RoundedRect(ByVal location As Point, ByVal size As Size, Optional ByVal cornerradius As Integer = 5, Optional ByVal margin As Integer = 2, Optional ByVal roundedcorners As Corner = Corner.All) As Drawing2D.GraphicsPath
    Return RoundedRect(New RectangleF(location.X, location.Y, size.Width, size.Height), cornerradius, margin, roundedcorners)
  End Function

  Public Shared Function RoundedRect(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, Optional ByVal cornerradius As Integer = 5, Optional ByVal margin As Integer = 2, Optional ByVal roundedcorners As Corner = Corner.All) As Drawing2D.GraphicsPath
    Return RoundedRect(New RectangleF(x, y, width, height), cornerradius, margin, roundedcorners)
  End Function

  Public Shared Function RoundedRect(ByVal rect As Rectangle, Optional ByVal cornerradius As Integer = 5, Optional ByVal margin As Integer = 2, Optional ByVal roundedcorners As Corner = Corner.All) As Drawing2D.GraphicsPath
    Return RoundedRect(New RectangleF(rect.Left, rect.Top, rect.Width, rect.Height), cornerradius, margin, roundedcorners)
  End Function

  Public Shared Function RoundedRect(ByVal location As PointF, ByVal size As SizeF, Optional ByVal cornerradius As Integer = 5, Optional ByVal margin As Integer = 2, Optional ByVal roundedcorners As Corner = Corner.All) As Drawing2D.GraphicsPath
    Return RoundedRect(New RectangleF(location.X, location.Y, size.Width, size.Height), cornerradius, margin, roundedcorners)
  End Function
#End Region

#Region "MSNLike"
  Public Shared Function MSNLike(ByVal rect As RectangleF, Optional ByVal tabwidth As Integer = 100, Optional ByVal tabheight As Integer = 20, Optional ByVal cornerradius As Integer = 5, Optional ByVal margin As Integer = 2, Optional ByVal roundedcorners As Corner = Corner.All) As Drawing2D.GraphicsPath
    Dim p As New Drawing2D.GraphicsPath
    Dim x As Single = rect.X, y As Single = rect.Y, w As Single = rect.Width, h As Single = rect.Height, m As Single = margin, r As Integer = cornerradius, tw As Integer = tabwidth, th As Integer = tabheight

    p.StartFigure()
    'top left arc
    If CBool(roundedcorners And Corner.TopLeft) Then
      p.AddArc(New RectangleF(x + m, y + m + th, 2 * r, 2 * r), 180, 90)
    Else
      p.AddLine(New PointF(x + m, y + m + r + th), New PointF(x + m, y + m + th))
      p.AddLine(New PointF(x + m, y + m + th), New PointF(x + m + r, y + m + th))
    End If

    'top line standard
    p.AddLine(New PointF(x + m + r, y + m + th), New PointF(x + w - m - tw - th, y + m + th))

    'bezier zwischen linie std und linie tab
    p.AddBezier( _
        New PointF(x + w - m - tw - th, y + m + th), _
        New PointF(x + w - m - tw, y + m + th), _
        New PointF(x + w - m - tw, y + m), _
        New PointF(x + w - m - tw + th, y + m))

    'linie tab bis ende
    p.AddLine(New PointF(x + w - m - tw + th, y + m), New PointF(x + w - m - r, y + m))

    'top right arc
    If CBool(roundedcorners And Corner.TopRight) Then
      p.AddArc(New RectangleF(x + w - m - 2 * r, y + m, 2 * r, 2 * r), 270, 90)
    Else
      p.AddLine(New PointF(x + w - m - r, y + m), New PointF(x + w - m, y + m))
      p.AddLine(New PointF(x + w - m, y + m), New PointF(x + w - m, y + m + r))
    End If

    'right line
    p.AddLine(New PointF(x + w - m, y + m + r), New PointF(x + w - m, y + h - m - r))

    'bottom right arc
    If CBool(roundedcorners And Corner.BottomRight) Then
      p.AddArc(New RectangleF(x + w - m - 2 * r, y + h - m - 2 * r, 2 * r, 2 * r), 0, 90)
    Else
      p.AddLine(New PointF(x + w - m, y + h - m - r), New PointF(x + w - m, y + h - m))
      p.AddLine(New PointF(x + w - m, y + h - m), New PointF(x + w - m - r, y + h - m))
    End If

    'bottom line
    p.AddLine(New PointF(x + w - m - r, y + h - m), New PointF(x + m + r, y + h - m))

    'bottom left arc
    If CBool(roundedcorners And Corner.BottomLeft) Then
      p.AddArc(New RectangleF(x + m, y + h - m - 2 * r, 2 * r, 2 * r), 90, 90)
    Else
      p.AddLine(New PointF(x + m + r, y + h - m), New PointF(x + m, y + h - m))
      p.AddLine(New PointF(x + m, y + h - m), New PointF(x + m, y + h - m - r))
    End If

    'left line
    p.AddLine(New PointF(x + m, y + h - m - r), New PointF(x + m, y + m + r))

    'close figure...
    p.CloseFigure()

    Return p
  End Function
#End Region
End Class
