Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.ComponentModel

Public Enum EnumTipoNumero
  Entero
  Decimales
  EnterosPositivos
End Enum

Public Class TextBoxCalculator
  Inherits TextBoxStd

  Protected ExpressionEngine As New ExpressionEngine

  'Indica si calculamos automaticamente el resultado al salir del control
  Protected _CalculateOnLeave As Boolean = True

  'Inidica si calculamos automaticamente el resultado al presionar ENTER
  Protected _CalculateOnPressEnter As Boolean = True

  Protected _TipoNumero As EnumTipoNumero = EnumTipoNumero.Decimales

  Protected _NumeroDecimales As Integer = 2
  '''-----------------------------------------------------------------------------
  ''' <summary>
  ''' Inidica si calculamos automaticamente el resultado al presionar ENTER
  ''' </summary>
  ''' <value></value>
  ''' <remarks></remarks>
  ''' <history>
  ''' 	[gbonansea] 	23/09/2004	Created
  ''' </history>
  '''-----------------------------------------------------------------------------
  <Browsable(True), Category("Behavior"), DefaultValue(True), _
  Description("Calculate expression when the ENTER key is pressed")> _
  Public Property CalculateOnPressEnter() As Boolean
    Get
      Return _CalculateOnPressEnter
    End Get
    Set(ByVal Value As Boolean)
      _CalculateOnPressEnter = Value
    End Set
  End Property

  '''-----------------------------------------------------------------------------
  ''' <summary>
  ''' Indica si calculamos automaticamente el resultado al salir del control
  ''' </summary>
  ''' <value></value>
  ''' <remarks></remarks>
  ''' <history>
  ''' 	[gbonansea] 	23/09/2004	Created
  ''' </history>
  '''-----------------------------------------------------------------------------
  <Browsable(True), Category("Behavior"), DefaultValue(True), _
  Description("Calculate expression the user lived the control")> _
  Public Property CalculateOnLeave() As Boolean
    Get
      Return _CalculateOnLeave
    End Get
    Set(ByVal Value As Boolean)
      _CalculateOnLeave = Value
    End Set
  End Property

  <Browsable(True), Category("Behavior"), DefaultValue(EnumTipoNumero.Decimales), _
  Description("Indica si el número es entero o double")> _
  Public Property TipoNumero() As EnumTipoNumero
    Get
      Return _TipoNumero
    End Get
    Set(ByVal Value As EnumTipoNumero)
      _TipoNumero = Value
    End Set
  End Property

  <Browsable(True), Category("Behavior"), DefaultValue(2), _
  Description("Indica el número de decimales")> _
  Public Property NumeroDecimales() As Integer
    Get
      Return _NumeroDecimales
    End Get
    Set(ByVal Value As Integer)
      _NumeroDecimales = Value
    End Set
  End Property

  '''-----------------------------------------------------------------------------
  ''' <summary>
  ''' Calculo el resultado
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  ''' <history>
  ''' 	[gbonansea] 	23/09/2004	Created
  ''' </history>
  '''-----------------------------------------------------------------------------
  Public Function GetResult() As Double
    Dim strExpression As String
    strExpression = MyBase.Text

    'Si no hay ninguna expresion retornamos 0
    If strExpression = "" Then
      Return 0
    Else
      'Reemplazo el caracter separador double del sistema por el .
      'strExpression = strExpression.Replace(".", CurrentCulture.NumberFormat.NumberDecimalSeparator)
      'strExpression = strExpression.Replace(",", CurrentCulture.NumberFormat.NumberDecimalSeparator)

      Dim strMask As String = "+*-/\^E()"

      Try
        Dim formula As Boolean = False
        For t As Integer = 0 To strMask.Length - 1
          If strExpression.Substring(1).IndexOf(strMask.Chars(t)) >= 0 Then
            formula = True
          End If
        Next
        If Not formula Then
          Return CDbl(strExpression)
        Else
          '.Replace(",", ".")
          If ExpressionEngine.PrecompilarAssembly(strExpression.Replace(",", "."), New String() {}, New String() {"System.Math"}) Then
            Return CDbl(ExpressionEngine.Evaluar(New Object() {}))
          End If
        End If
      Catch ex As Exception
      End Try
      Return 0
    End If
  End Function

  '''-----------------------------------------------------------------------------
  ''' <summary>
  ''' Calcula el resultado de la expresion
  ''' </summary>
  ''' <remarks></remarks>
  ''' <history>
  ''' 	[gbonansea] 	13/09/2004	Created
  ''' </history>
  '''-----------------------------------------------------------------------------
  Public Sub Calculate()
    Dim strResultado As Double

    If Not MyBase.Text = String.Empty Then
      'Calculo el resultado
      strResultado = Me.GetResult
      'Reemplazo la formula por el resultado
      Me.Value = strResultado
    End If
  End Sub


  '''-----------------------------------------------------------------------------
  ''' <summary>
  ''' sobreescribimos el evento OnKeyPress para permitir solo caracteres numericos
  ''' </summary>
  ''' <remarks></remarks>
  ''' <history>
  ''' 	[gbonansea] 	13/09/2004	Created
  ''' </history>
  '''-----------------------------------------------------------------------------
  Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    MyBase.OnKeyPress(e)
    Dim strMask As String
    strMask = "0123456789+*-/\^E().," & vbBack '& CurrentCulture.NumberFormat.NumberDecimalSeparator

    If ".,".IndexOf(e.KeyChar) >= 0 And Not e.KeyChar = CurrentCulture.NumberFormat.NumberDecimalSeparator Then
      e.KeyChar = CurrentCulture.NumberFormat.NumberDecimalSeparator
    End If
    'Si el carater es el ENTER realizo el calculo
    If _CalculateOnPressEnter AndAlso e.KeyChar = vbCr Then
      Calculate()
    End If

    'Si el caracter presionado está permitido
    If strMask.IndexOf(e.KeyChar) < 0 Then
      e.Handled = True
    End If

    If e.KeyChar = vbCr Then
      'SendKeys.Send("{TAB}")
      e.Handled = True
    End If
  End Sub

  '''-----------------------------------------------------------------------------
  ''' <summary>
  ''' Sobreescribrimos el evento Leave que se ejecuta cuando salimos del TextBox
  ''' </summary>
  ''' <remarks></remarks>
  ''' <history>
  ''' 	[gbonansea] 	23/09/2004	Created
  ''' </history>
  '''-----------------------------------------------------------------------------
  Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
    MyBase.OnLeave(e)

    'Si esta activado el calcular en este evento
    If CalculateOnLeave Then
      Calculate()
    End If
  End Sub

  Protected Overrides Sub OnEnter(ByVal e As System.EventArgs)
    MyBase.OnEnter(e)
  End Sub

  'Public Overrides Property Text() As String
  '  Get
  '    Return Value
  '  End Get
  '  Set(ByVal _value As String)
  '    Value = CDbl(_value)
  '  End Set
  'End Property

  Public Property Value() As Double
    Get
      'Try
      '  If _TipoNumero = EnumTipoNumero.Entero Then
      '    Return CInt(IIf(MyBase.Text.Trim = String.Empty, "0", MyBase.Text))
      '  Else
      '    Return CDec(IIf(MyBase.Text.Trim = String.Empty, "0", MyBase.Text))
      '  End If
      'Catch ex As Exception
      '  Return 0
      'End Try
      Return GetResult()
    End Get
    Set(ByVal value As Double)
      Try
        Select Case _TipoNumero
          Case EnumTipoNumero.Entero
            MyBase.Text = CStr(CInt(value))
          Case EnumTipoNumero.EnterosPositivos
            MyBase.Text = CStr(Math.Abs(CInt(value)))
          Case EnumTipoNumero.Decimales
            MyBase.Text = CStr(value)
        End Select
      Catch ex As Exception
        MyBase.Text = "0"
      End Try
      formatear()
    End Set
  End Property

  Private Sub TextBoxCalculator_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
    formatear()
  End Sub

  Private Sub formatear()
    Try
      If _TipoNumero = EnumTipoNumero.Entero OrElse _TipoNumero = EnumTipoNumero.EnterosPositivos Then
        MyBase.Text = CInt(IIf(Me.Text.Trim = String.Empty, "0", Me.Text)).ToString
      Else
        MyBase.Text = CDec(IIf(Me.Text.Trim = String.Empty, "0", Me.Text)).ToString("N" & _NumeroDecimales.ToString.Trim)
      End If
    Catch ex As Exception
      MyBase.Text = "0"
    End Try
  End Sub
End Class
