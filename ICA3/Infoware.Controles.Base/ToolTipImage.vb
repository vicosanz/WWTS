Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.Collections

<ProvideProperty("ToolTipImageTitle", GetType(Control)), _
 ProvideProperty("ToolTipImageIcon", GetType(Control)), _
 ProvideProperty("ToolTipImageText", GetType(Control)), _
 ProvideProperty("ToolTipImageImage", GetType(Control)), _
 ProvideProperty("ToolTipImageFooter", GetType(Control))> _
Public Class ToolTipImage
  Inherits System.Windows.Forms.ToolTip

  Private ToolTipImageSize As Size
  Private posicionTitulo As New Point(0, 0)
  Private posicionIcono As New Point(0, 0)
  Private posicionTexto As New Point(0, 0)
  Private posicionImagen As New Point(0, 0)
  Private posicionPie As New Point(0, 0)
  Private posicionLinea As Integer
  Private tamEspacioSeparador As Integer = 10

  Private fuenteTitulo As New Font(SystemFonts.DialogFont, FontStyle.Bold)
  Private fuenteTexto As New Font(SystemFonts.DialogFont, FontStyle.Regular)
  Private fuentePie As New Font(SystemFonts.DialogFont, FontStyle.Bold)

  Private ToolTipImageTitleValues As New Hashtable()
  Private ToolTipImageIconValues As New Hashtable()
  Private ToolTipImageTextValues As New Hashtable()
  Private ToolTipImageImageValues As New Hashtable()
  Private ToolTipImageFooterValues As New Hashtable()

  Private _isToolTipImage As Boolean

  <Description("Indica si el ToolTip tomará la forma de un ToolTipImage"), _
   DefaultValue(True)> _
  Public Property IsToolTipImage() As Boolean
    Get
      Return _isToolTipImage
    End Get
    Set(ByVal value As Boolean)
      _isToolTipImage = value
      If value Then
        OwnerDraw = True
      End If
    End Set
  End Property

  <DefaultValue(True)> _
  Public Shadows Property OwnerDraw() As Boolean
    Get
      Return MyBase.OwnerDraw
    End Get
    Set(ByVal value As Boolean)
      MyBase.OwnerDraw = value
      If Not value Then
        IsToolTipImage = False
      End If
    End Set
  End Property

  ' Constructor, se inicializa IsToolTipImage en True, que a su vez cambia OwnerDraw a
  ' True para permitir que se ejecute el evento Draw
  Public Sub New()
    IsToolTipImage = True
  End Sub

  <Description("Determina el texto descriptivo que tendrá el ToolTipImage"), _
   DefaultValue(""), _
   Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))> _
  Public Function GetToolTipImageText(ByVal control As Control) As String
    If ToolTipImageTextValues.Contains(control) Then
      Return ToolTipImageTextValues(control).ToString()
    Else
      Return ""
    End If
  End Function

  Public Sub SetToolTipImageText(ByVal control As Control, ByVal text As String)
    If text Is Nothing Then
      text = ""
    End If
    If String.IsNullOrEmpty(text) Then
      ToolTipImageTextValues.Remove(control)
    Else
      If ToolTipImageTextValues.Contains(control) Then
        ToolTipImageTextValues(control) = text
      Else
        ToolTipImageTextValues.Add(control, text)
      End If
      ' Si la propiedad extensora ToolTip no tiene nada, se agrega el mismo texto
      ' de la propiedad extensora ToolTipImageText, ya que la propiedad ToolTip 
      ' es la que indica que el control tiene asociado un ToolTip
      If GetToolTip(control) = "" Then
        SetToolTip(control, text)
      End If
    End If
  End Sub

  <Description("Determina el titulo que tendrá el ToolTipImage"), _
   DefaultValue("")> _
  Public Function GetToolTipImageTitle(ByVal control As Control) As String
    If ToolTipImageTitleValues.Contains(control) Then
      Return ToolTipImageTitleValues(control).ToString()
    Else
      Return ""
    End If
  End Function

  Public Sub SetToolTipImageTitle(ByVal control As Control, ByVal title As String)
    If title Is Nothing Then
      title = ""
    End If
    If String.IsNullOrEmpty(title) Then
      ToolTipImageTitleValues.Remove(control)
    Else
      If ToolTipImageTitleValues.Contains(control) Then
        ToolTipImageTitleValues(control) = title
      Else
        ToolTipImageTitleValues.Add(control, title)
      End If
    End If
  End Sub

  <Description("Determina el icono que tendrá el ToolTipImage en la parte superior derecha"), _
   DefaultValue(GetType(Object), "")> _
  Public Function GetToolTipImageIcon(ByVal control As Control) As Image
    If ToolTipImageIconValues.Contains(control) Then
      Return CType(ToolTipImageIconValues(control), Image)
    Else
      Return Nothing
    End If
  End Function

  Public Sub SetToolTipImageIcon(ByVal control As Control, ByVal icon As Image)
    If icon Is Nothing Then
      ToolTipImageIconValues.Remove(control)
    Else
      If ToolTipImageIconValues.Contains(control) Then
        ToolTipImageIconValues(control) = icon
      Else
        ToolTipImageIconValues.Add(control, icon)
      End If
    End If
  End Sub

  <Description("Determina la imagen que tendrá el ToolTipImage"), _
   DefaultValue(GetType(Object), "")> _
  Public Function GetToolTipImageImage(ByVal control As Control) As Image
    If ToolTipImageImageValues.Contains(control) Then
      Return CType(ToolTipImageImageValues(control), Image)
    Else
      Return Nothing
    End If
  End Function

  Public Sub SetToolTipImageImage(ByVal control As Control, ByVal image As Image)
    If image Is Nothing Then
      ToolTipImageImageValues.Remove(control)
    Else
      If ToolTipImageImageValues.Contains(control) Then
        ToolTipImageImageValues(control) = image
      Else
        ToolTipImageImageValues.Add(control, image)
      End If
    End If
  End Sub

  <Description("Determina el pie que tendrá el ToolTipImage"), _
   DefaultValue("")> _
  Public Function GetToolTipImageFooter(ByVal control As Control) As String
    If ToolTipImageFooterValues.Contains(control) Then
      Return ToolTipImageFooterValues(control).ToString()
    Else
      Return ""
    End If
  End Function

  Public Sub SetToolTipImageFooter(ByVal control As Control, ByVal footer As String)
    If footer Is Nothing Then
      footer = ""
    End If
    If String.IsNullOrEmpty(footer) Then
      ToolTipImageFooterValues.Remove(control)
    Else
      If ToolTipImageFooterValues.Contains(control) Then
        ToolTipImageFooterValues(control) = footer
      Else
        ToolTipImageFooterValues.Add(control, footer)
      End If
    End If
  End Sub

  Private Function ObtenerTemaActual() As String
    Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\ThemeManager")
    If key IsNot Nothing Then
      If CBool(key.GetValue("ThemeActive")) Then
        Dim tema As String = CStr(key.GetValue("ColorName"))
        If tema IsNot Nothing Then
          Select Case tema
            Case "Metallic"
              Return "Plateado"
            Case "NormalColor"
              Return "Azul"
            Case "HomeStead"
              Return "Verde Olivo"
          End Select
        End If
      End If
    End If
    Return "Windows Clasico"
  End Function

  Private Sub ToolTipImage_Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs) Handles Me.Draw
    If IsToolTipImage And Not String.IsNullOrEmpty(GetToolTipImageText(e.AssociatedControl)) Then
      ' Dibujar fondo con un gradiente de acuerdo al tema de Windows XP
      Dim temaActual As String
      Dim linearGradBrush As LinearGradientBrush
      Dim color1 As Color
      Dim color2 As Color

      ' Identificar que tema se esta usando
      temaActual = ObtenerTemaActual()
      Select Case temaActual
        Case "Plateado"
          ' Si es Plateado
          color1 = Color.FromArgb(249, 249, 255)
          color2 = Color.FromArgb(164, 163, 190)
        Case "Azul"
          ' Si es Azul
          color1 = Color.FromArgb(227, 239, 255)
          color2 = Color.FromArgb(121, 161, 220)
        Case "Verde Olivo"
          ' Si es Verde Olivo
          color1 = Color.FromArgb(250, 251, 230)
          color2 = Color.FromArgb(164, 180, 120)
        Case "Windows Clasico"
          ' Si no tiene tema, usar el color del sistema para el ToolTip
          color1 = SystemColors.Info
          color2 = SystemColors.Info
      End Select
      ' Pintar el color de fondo
      linearGradBrush = New LinearGradientBrush( _
              New Point(0, 0), _
              New Point(0, ToolTipImageSize.Height), _
              color1, _
              color2)
      e.Graphics.FillRectangle(linearGradBrush, New Rectangle(0, 0, ToolTipImageSize.Width, ToolTipImageSize.Height))

      ' Dibujar borde con apariencia 3D
      e.Graphics.DrawLines( _
              SystemPens.ControlLightLight, New Point() { _
              New Point(0, ToolTipImageSize.Height - 1), _
              New Point(0, 0), _
              New Point(ToolTipImageSize.Width - 1, 0)})
      e.Graphics.DrawLines( _
              SystemPens.ControlDarkDark, New Point() { _
              New Point(0, ToolTipImageSize.Height - 1), _
              New Point(ToolTipImageSize.Width - 1, ToolTipImageSize.Height - 1), _
              New Point(ToolTipImageSize.Width - 1, 0)})

      ' Imprimir titulo, si existe
      If Not String.IsNullOrEmpty(GetToolTipImageTitle(e.AssociatedControl)) Then
        e.Graphics.DrawString(GetToolTipImageTitle(e.AssociatedControl), fuenteTitulo, New SolidBrush(Color.Black), posicionTitulo)
      End If

      ' Dibujar icono en la esquina superior derecha, si existe
      Dim icono As Bitmap = CType(GetToolTipImageIcon(e.AssociatedControl), Bitmap)
      If icono IsNot Nothing Then
        icono.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(icono, posicionIcono)
      End If

      ' Dibujar imagen descriptiva, si existe
      ' Si es una imagen ancha se mostrará horizontalmente y el texto descriptivo estará debajo de la imagen
      ' Si es una imagen alta se mostrará verticalmente y el texto descriptivo estará en la parte derecha de la imagen
      Dim imagen As Image = GetToolTipImageImage(e.AssociatedControl)
      If imagen IsNot Nothing Then
        'e.Graphics.DrawImage(imagen, posicionImagen)
        e.Graphics.DrawImage(imagen, New Rectangle(posicionImagen.X, posicionImagen.Y, imagen.Width, imagen.Height))
      End If

      ' Imprimir texto descriptivo
      ' El texto se imprime de acuerdo a si existe o no una imagen descriptiva
      ' La orientación del texto depende de donde se coloque la imagen descriptiva
      e.Graphics.DrawString(GetToolTipImageText(e.AssociatedControl), fuenteTexto, New SolidBrush(Color.Black), posicionTexto)

      ' Dibujar línea de separación e imprimir texto de pie de ToolTipImage, si existe
      If Not String.IsNullOrEmpty(GetToolTipImageFooter(e.AssociatedControl)) Then
        e.Graphics.DrawLine(New Pen(Color.Black), New Point(1, posicionLinea), New Point(ToolTipImageSize.Width - 1, posicionLinea))
        e.Graphics.DrawString(GetToolTipImageFooter(e.AssociatedControl), fuentePie, New SolidBrush(Color.Black), posicionPie)
      End If
    Else
      Dim sf As TextFormatFlags = TextFormatFlags.NoFullWidthCharacterBreak Or TextFormatFlags.VerticalCenter
      e.DrawBackground()
      e.DrawBorder()
      e.DrawText(sf)
    End If
  End Sub

  Public Event AntesPopup As EventHandler
  Private Sub ToolTipImage_Popup(ByVal sender As Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles Me.Popup
    RaiseEvent AntesPopup(Me, Nothing)
    If Not (IsToolTipImage And OwnerDraw And Not String.IsNullOrEmpty(GetToolTipImageText(e.AssociatedControl))) Then
      e.Cancel = True
      Exit Sub
    End If

    Dim hayTitulo As Boolean = False
    Dim hayIcono As Boolean = False
    Dim hayTexto As Boolean = False
    Dim hayImagen As Boolean = False
    Dim hayPie As Boolean = False

    ' Calcular el tamaño del ToolTipImage
    ' Obtener el tamaño individual de los elementos
    Dim tamTitulo As Size
    Dim tamTexto As Size
    Dim tamPie As Size
    Dim tamImagen As Size
    Dim tamIcono As Size
    Dim tamTabSeccion2 As Integer = tamEspacioSeparador

    If Not String.IsNullOrEmpty(GetToolTipImageTitle(e.AssociatedControl)) Then
      tamTitulo = TextRenderer.MeasureText(GetToolTipImageTitle(e.AssociatedControl), fuenteTitulo)
      hayTitulo = True
    End If

    Dim icono As Image
    icono = GetToolTipImageIcon(e.AssociatedControl)
    If icono IsNot Nothing Then
      tamIcono = icono.Size
      hayIcono = True
    End If

    tamTexto = TextRenderer.MeasureText(GetToolTipImageText(e.AssociatedControl), fuenteTexto)
    hayTexto = True

    Dim imagen As Image
    imagen = GetToolTipImageImage(e.AssociatedControl)
    If imagen IsNot Nothing Then
      tamImagen = imagen.Size
      hayImagen = True
    End If

    If Not String.IsNullOrEmpty(GetToolTipImageFooter(e.AssociatedControl)) Then
      tamPie = TextRenderer.MeasureText(GetToolTipImageFooter(e.AssociatedControl), fuentePie)
      hayPie = True
    End If

    If hayTitulo Or hayPie Then
      tamTabSeccion2 = tamEspacioSeparador + tamEspacioSeparador
    End If

    ' Calcular altura del ToolTipImage
    ToolTipImageSize.Height = tamEspacioSeparador

    ' Calcular altura del ToolTipImage - Sección 1
    If hayTitulo Or hayIcono Then
      If tamTitulo.Height >= tamIcono.Height Then
        ToolTipImageSize.Height += tamTitulo.Height + tamEspacioSeparador
      Else
        ToolTipImageSize.Height += tamIcono.Height + tamEspacioSeparador
      End If
    End If

    ' Calcular altura del ToolTipImage - Sección 2
    If hayTexto And hayImagen Then
      ' Identificar la orientación de la imagen
      If tamImagen.Height >= tamImagen.Width Then
        ' Orientación vertical
        If tamImagen.Height >= tamTexto.Height Then
          ToolTipImageSize.Height += tamImagen.Height + tamEspacioSeparador
        Else
          ToolTipImageSize.Height += tamTexto.Height + tamEspacioSeparador
        End If
      Else
        ' Orientación horizontal
        ToolTipImageSize.Height += tamImagen.Height + tamEspacioSeparador + tamTexto.Height + tamEspacioSeparador
      End If
    ElseIf hayTexto Then
      ToolTipImageSize.Height += tamTexto.Height + tamEspacioSeparador
    Else
      ToolTipImageSize.Height += tamImagen.Height + tamEspacioSeparador
    End If

    ' Calcular altura del ToolTipImage - Sección 3
    If hayPie Then
      ToolTipImageSize.Height += tamPie.Height + tamEspacioSeparador
    End If

    ' Calcular ancho del ToolTipImage
    Dim anchoSeccion1 As Integer
    Dim anchoSeccion2 As Integer
    Dim anchoSeccion3 As Integer

    ' Calcular ancho del ToolTipImage - Sección 1
    If hayTitulo And hayIcono Then
      anchoSeccion1 = tamEspacioSeparador + tamTitulo.Width + tamIcono.Width + tamEspacioSeparador
    ElseIf hayTitulo Then
      anchoSeccion1 = tamEspacioSeparador + tamTitulo.Width + tamEspacioSeparador
    Else
      anchoSeccion1 = tamEspacioSeparador + tamIcono.Width + tamEspacioSeparador
    End If

    ' Calcular ancho del ToolTipImage - Sección 2
    If hayTexto And hayImagen Then
      ' Identificar la orientación de la imagen
      If tamImagen.Height >= tamImagen.Width Then
        ' Orientación vertical
        anchoSeccion2 = tamTabSeccion2 + tamImagen.Width + tamEspacioSeparador + tamTexto.Width + tamEspacioSeparador
      Else
        ' Orientación horizontal
        If tamImagen.Width >= tamTexto.Width Then
          anchoSeccion2 = tamTabSeccion2 + tamImagen.Width + tamEspacioSeparador
        Else
          anchoSeccion2 = tamTabSeccion2 + tamTexto.Width + tamEspacioSeparador
        End If
      End If
    ElseIf hayTexto Then
      anchoSeccion2 = tamTabSeccion2 + tamTexto.Width + tamEspacioSeparador
    Else
      anchoSeccion2 = tamTabSeccion2 + tamImagen.Width + tamEspacioSeparador
    End If

    ' Calcular ancho del ToolTipImage - Seccion 3
    If hayPie Then
      anchoSeccion3 = tamEspacioSeparador + tamPie.Width + tamEspacioSeparador
    End If

    ' El ancho del ToolTipImage depende de la sección mas ancha
    If anchoSeccion1 >= anchoSeccion2 And anchoSeccion1 >= anchoSeccion3 Then
      ToolTipImageSize.Width = anchoSeccion1
    ElseIf anchoSeccion2 >= anchoSeccion1 And anchoSeccion2 >= anchoSeccion3 Then
      ToolTipImageSize.Width = anchoSeccion2
    Else
      ToolTipImageSize.Width = anchoSeccion3
    End If

    ' Calcular las posiciones de los elementos del ToolTipImage
    Dim inicioSeccion1 As New Point(tamEspacioSeparador, tamEspacioSeparador)
    Dim inicioSeccion2 As New Point(tamTabSeccion2, tamEspacioSeparador)
    Dim inicioSeccion3 As Point

    ' Calcular las posiciones de los elementos - Sección 1
    If hayTitulo Or hayIcono Then
      If tamTitulo.Height >= tamIcono.Height Then
        posicionTitulo = inicioSeccion1
        'posicionIcono = New Point(ToolTipImageSize.Width - 21, 7)
        posicionIcono = New Point(ToolTipImageSize.Width - tamEspacioSeparador - tamIcono.Width, posicionTitulo.Y + CInt(tamTitulo.Height / 2) - CInt(tamIcono.Height / 2))
        inicioSeccion2 = New Point(tamTabSeccion2, posicionTitulo.Y + tamTitulo.Height + tamEspacioSeparador)
      Else
        posicionIcono = New Point(ToolTipImageSize.Width - tamEspacioSeparador - tamIcono.Width, inicioSeccion1.Y)
        posicionTitulo = New Point(inicioSeccion1.X, posicionIcono.Y + CInt(tamIcono.Height / 2) - CInt(tamTitulo.Height / 2))
        inicioSeccion2 = New Point(tamTabSeccion2, posicionIcono.Y + tamIcono.Height + tamEspacioSeparador)
      End If
    End If

    ' Calcular las posiciones de los elementos - Sección 2
    If hayTexto And hayImagen Then
      If tamImagen.Height >= tamImagen.Width Then
        ' Orientación vertical
        posicionImagen = inicioSeccion2
        posicionTexto = New Point(posicionImagen.X + tamImagen.Width + tamEspacioSeparador, posicionImagen.Y)
        If tamImagen.Height >= tamTexto.Height Then
          inicioSeccion3 = New Point(tamEspacioSeparador, posicionImagen.Y + tamImagen.Height + tamEspacioSeparador)
        Else
          inicioSeccion3 = New Point(tamEspacioSeparador, posicionTexto.Y + tamTexto.Height + tamEspacioSeparador)
        End If
      Else
        ' Orientación horizontal
        If tamImagen.Width >= tamTexto.Width Then
          posicionImagen = inicioSeccion2
          posicionTexto = New Point(posicionImagen.X, posicionImagen.Y + tamImagen.Height + tamEspacioSeparador)
        Else
          posicionTexto = New Point(inicioSeccion2.X, inicioSeccion2.Y + tamImagen.Height + tamEspacioSeparador)
          posicionImagen = New Point(posicionTexto.X + CInt(tamTexto.Width / 2) - CInt(tamImagen.Width / 2), inicioSeccion2.Y)
        End If
        inicioSeccion3 = New Point(tamEspacioSeparador, posicionTexto.Y + tamTexto.Height + tamEspacioSeparador)
      End If
    ElseIf hayTexto Then
      posicionTexto = inicioSeccion2
      inicioSeccion3 = New Point(tamEspacioSeparador, posicionTexto.Y + tamTexto.Height + tamEspacioSeparador)
    Else
      posicionImagen = inicioSeccion2
      inicioSeccion3 = New Point(tamEspacioSeparador, posicionImagen.Y + tamImagen.Height + tamEspacioSeparador)
    End If

    ' Calcular las posiciones de los elementos - Sección 3
    If hayPie Then
      posicionLinea = inicioSeccion3.Y - CInt(tamEspacioSeparador / 2)
      inicioSeccion3.Y += 1
      posicionPie = inicioSeccion3
    End If
    e.ToolTipSize = ToolTipImageSize
    e.Cancel = False
  End Sub
End Class