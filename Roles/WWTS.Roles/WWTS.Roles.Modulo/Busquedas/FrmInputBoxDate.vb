Public Class FrmInputBoxDate
  Public Property Title() As String
    Get
      Return Me.Text
    End Get
    Set(ByVal Value As String)
      Me.Text = Value
    End Set
  End Property

  Public Property Fecha() As Date
    Get
      Return Me.MonthCalendar1.SelectionStart
    End Get
    Set(ByVal Value As Date)
      Me.MonthCalendar1.SelectionStart = Value
    End Set
  End Property


End Class