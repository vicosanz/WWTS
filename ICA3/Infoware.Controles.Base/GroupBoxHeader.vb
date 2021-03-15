Public Class GroupBoxHeader
  Inherits GroupBox

  Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    Dim Format As StringFormat = New StringFormat
    Format.Trimming = StringTrimming.Character
    Format.Alignment = StringAlignment.Near
    If (Me.RightToLeft = RightToLeft.Yes) Then
      Format.FormatFlags = Format.FormatFlags And StringFormatFlags.DirectionRightToLeft
    End If

    Dim stringSize As SizeF = e.Graphics.MeasureString(Text, Font, ClientRectangle.Size, Format)

    If (Enabled) Then
      Dim br As Brush = New SolidBrush(ForeColor)
      e.Graphics.DrawString(Text, Font, br, ClientRectangle, Format)
      br.Dispose()
	  Else
      ControlPaint.DrawStringDisabled(e.Graphics, Text, Font, BackColor, ClientRectangle, Format)
    End If

    Dim forePen As Pen = New Pen(ControlPaint.LightLight(BackColor), SystemInformation.BorderSize.Height)
    Dim forePenDark As Pen = New Pen(ControlPaint.Dark(BackColor), SystemInformation.BorderSize.Height)
    Dim lineLeft As Point = New Point(ClientRectangle.Left, ClientRectangle.Top + CInt(Font.Height / 2.0F))
    Dim lineRight As Point = New Point(ClientRectangle.Right, ClientRectangle.Top + CInt(Font.Height / 2.0F))
    If (Not Me.RightToLeft = RightToLeft.Yes) Then
      lineLeft.X += CInt(stringSize.Width)
    Else
      lineRight.X -= CInt(stringSize.Width)
    End If

    If (FlatStyle = FlatStyle.Flat) Then
      e.Graphics.DrawLine(forePenDark, lineLeft, lineRight)
    Else
      e.Graphics.DrawLine(forePenDark, lineLeft, lineRight)
      lineLeft.Offset(0, CInt(Math.Ceiling(CDbl(SystemInformation.BorderSize.Height) / 2.0F)))
      lineRight.Offset(0, CInt(Math.Ceiling(CDbl(SystemInformation.BorderSize.Height) / 2.0F)))
      e.Graphics.DrawLine(forePen, lineLeft, lineRight)
    End If
    forePen.Dispose()
    forePenDark.Dispose()
  End Sub
End Class
