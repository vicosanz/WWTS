Imports System.Windows.Forms
Imports System.Drawing
Imports System.Reflection

Public Class CtlSeccion
  Public Event CambioDatosEvent As EventHandler

  Private mUbicacion As enumUbicacion
  Public Property Ubicacion() As enumUbicacion
    Get
      Return mUbicacion
    End Get
    Set(ByVal value As enumUbicacion)
      mUbicacion = value
      AutoDiscover()
    End Set
  End Property

  Private Sub AutoDiscover()
    If mReportData Is Nothing OrElse mReportData.Header Is Nothing Then
      Exit Sub
    End If

    Dim SourceType As Type
    Me.AgregarCampoToolStripMenuItem1.DropDownItems.Clear()
    If mUbicacion = enumUbicacion.Detalles And mReportData.Details IsNot Nothing Then
      SourceType = mReportData.Details
    Else
      SourceType = mReportData.Header
    End If

    For Each mInfo As PropertyInfo In SourceType.GetProperties
      Dim attrCustom As CampoReporteAtributo = Nothing

      For Each attr As Attribute In Attribute.GetCustomAttributes(mInfo)
        If TypeOf attr Is CampoReporteAtributo Then
          attrCustom = CType(attr, CampoReporteAtributo)
          attrCustom.Campo = mInfo.Name
        End If
      Next

      If attrCustom IsNot Nothing AndAlso Not attrCustom.Ignorar Then
        If mInfo.PropertyType.BaseType Is GetType(Object) Or mInfo.PropertyType.BaseType Is GetType(ValueType) Then
          Dim _item As New System.Windows.Forms.ToolStripMenuItem
          _item.Text = attrCustom.Etiqueta
          _item.Tag = attrCustom
          Me.AgregarCampoToolStripMenuItem1.DropDownItems.Add(_item)
          AddHandler _item.Click, AddressOf AgregarCampoToolStripMenuItem_Click
          'mColumns.Add(props(column).Name)
        End If
      End If
    Next
  End Sub

  Private mReportData As ReportData
  Public Property ReportData() As ReportData
    Get
      Return mReportData
    End Get
    Set(ByVal value As ReportData)
      mReportData = value
      AutoDiscover()
      MostrarCampos()
    End Set
  End Property

  Private Sub MostrarCampos()
    If mReportData Is Nothing OrElse mReportData.ReportSection(mUbicacion).ReportFields Is Nothing Then
      Exit Sub
    End If
    While True
      Dim encontro As Boolean = False
      For Each _control As Control In Me.Controls
        If TypeOf _control Is TextBox Then
          Me.Controls.Remove(_control)
          encontro = True
        End If
      Next
      If Not encontro Then
        Exit While
      End If
    End While

    For Each _campo As ReportField In mReportData.ReportSection(mUbicacion).ReportFields
      Dim _TextBox As New System.Windows.Forms.TextBox
      _TextBox.Location = _campo.Location
      _TextBox.AutoSize = False
      _TextBox.Size = _campo.Size
      _TextBox.Text = _campo.Etiqueta
      _TextBox.Font = _campo.Font
      Select Case _campo.Justificacion
        Case EnumJustificacion.Centered
          _TextBox.TextAlign = HorizontalAlignment.Center
        Case EnumJustificacion.Left
          _TextBox.TextAlign = HorizontalAlignment.Left
        Case EnumJustificacion.Right
          _TextBox.TextAlign = HorizontalAlignment.Right
      End Select
      _TextBox.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
      _TextBox.ContextMenuStrip = Me.ContextMenuEditarCampo
      _TextBox.Tag = _campo
      _TextBox.ReadOnly = Not _campo.Campo = String.Empty

      AddHandler _TextBox.MouseDown, AddressOf mover_campodown
      AddHandler _TextBox.MouseMove, AddressOf mover_campomove
      AddHandler _TextBox.MouseUp, AddressOf mover_campoup
      AddHandler _TextBox.TextChanged, AddressOf mover_campotextchanged
      'AddHandler _TextBox.LostFocus, AddressOf mover_LostFocus
      Me.Controls.Add(_TextBox)
    Next
  End Sub

  Private mEstaMoviendoCampo As Boolean = False
  Private mRelPoint As System.Drawing.Point
  Private mTextBox As TextBox
  Private mCampo As ReportField

  Private Sub mover_campodown(ByVal sender As Object, ByVal e As MouseEventArgs)
    Dim _TextBox As TextBox
    _TextBox = CType(sender, TextBox)
    mTextBox = _TextBox
    mCampo = CType(mTextBox.Tag, ReportField)
    mTextBox.ReadOnly = Not mCampo.Campo = String.Empty
    mEstaMoviendoCampo = True
    mRelPoint = e.Location
  End Sub

  Private Sub mover_campomove(ByVal sender As Object, ByVal e As MouseEventArgs)
    If Not mEstaMoviendoCampo Then
      Exit Sub
    End If
    Dim _TextBox As TextBox
    _TextBox = CType(sender, TextBox)
    _TextBox.Location = New System.Drawing.Point(IIf(e.X + _TextBox.Left - mRelPoint.X < 0, 0, e.X + _TextBox.Left - mRelPoint.X), IIf(e.Y + _TextBox.Top - mRelPoint.Y < 0, 0, e.Y + _TextBox.Top - mRelPoint.Y))
  End Sub

  Private Sub mover_campoup(ByVal sender As Object, ByVal e As MouseEventArgs)
    If Not mEstaMoviendoCampo Then
      Exit Sub
    End If
    mEstaMoviendoCampo = False
    mCampo.Location = mTextBox.Location
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub mover_campotextchanged(ByVal sender As Object, ByVal e As EventArgs)
    Dim _TextBox As TextBox
    _TextBox = CType(sender, TextBox)
    mTextBox = _TextBox
    mCampo = CType(mTextBox.Tag, ReportField)
    mCampo.Etiqueta = mTextBox.Text
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub AgregarCampoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarEtiquetaToolStripMenuItem.Click
    Dim _menuitem As System.Windows.Forms.ToolStripMenuItem
    _menuitem = CType(sender, System.Windows.Forms.ToolStripMenuItem)

    Dim attr As CampoReporteAtributo

    Dim _campo As ReportField = Nothing
    If _menuitem.Tag Is Nothing Then
      _campo = New ReportField("Nuevo", "", New System.Drawing.Point(UltimoClick.X, UltimoClick.Y))
    ElseIf TypeOf _menuitem.Tag Is CampoReporteAtributo Then
      attr = CType(_menuitem.Tag, CampoReporteAtributo)
      _campo = New ReportField(attr.Etiqueta, attr.Campo, New System.Drawing.Point(UltimoClick.X, UltimoClick.Y))
      Select Case attr.TipoDato
        Case CampoReporteAtributo.EnumTipoDato.Texto
          _campo.Format = ""
        Case CampoReporteAtributo.EnumTipoDato.Numero
          _campo.Format = "N0"
          _campo.Justificacion = EnumJustificacion.Right
        Case CampoReporteAtributo.EnumTipoDato.Decimales
          _campo.Format = "N2"
          _campo.Justificacion = EnumJustificacion.Right
        Case CampoReporteAtributo.EnumTipoDato.Fecha
          '_campo.Format = "d"
      End Select
      'Else
      '  _campo = New ReportField(_menuitem.Text, New System.Drawing.Point(UltimoClick.X, UltimoClick.Y), _menuitem.Text)
    End If
    mReportData.ReportSection(mUbicacion).ReportFields.Add(_campo)
    MostrarCampos()
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private UltimoClick As Point
  Private Sub CtlSeccion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
    UltimoClick = e.Location
  End Sub

  Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
    FontDialog1.Font = mTextBox.Font
    If FontDialog1.ShowDialog() = DialogResult.OK Then
      mTextBox.Font = FontDialog1.Font
      mCampo.Font = FontDialog1.Font
      mCampo.Size = New Size(mCampo.Size.Width, mCampo.Font.Height)
      mTextBox.Height = mCampo.Font.Height
      'mCampo.Size = mTextBox.Size
      RaiseEvent CambioDatosEvent(Me, Nothing)
    End If
  End Sub

  Private Sub AjustarTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustarTextoToolStripMenuItem.Click
    mTextBox.Width += CInt(ToolStripTextBox1.Text)
    mCampo.Size = mTextBox.Size
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub DisminuirAnchoTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisminuirAnchoTextoToolStripMenuItem.Click
    If mTextBox.Width - CInt(ToolStripTextBox1.Text) > 10 Then
      mTextBox.Width -= CInt(ToolStripTextBox1.Text)
      mCampo.Size = mTextBox.Size
      RaiseEvent CambioDatosEvent(Me, Nothing)
    End If
  End Sub

  Private Sub ToolStripTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ToolStripTextBox1.Validating
    With Me.ToolStripTextBox1
      .Text = CType(IIf(.Text.Trim = String.Empty, 0, .Text), Integer).ToString
    End With
  End Sub

  Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
    mReportData.ReportSection(mUbicacion).ReportFields.Remove(mCampo)
    MostrarCampos()
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub IzquierdaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IzquierdaToolStripMenuItem.Click
    mTextBox.TextAlign = HorizontalAlignment.Left
    mCampo.Justificacion = EnumJustificacion.Left
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub CentroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentroToolStripMenuItem.Click
    mTextBox.TextAlign = HorizontalAlignment.Center
    mCampo.Justificacion = EnumJustificacion.Centered
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub DerechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DerechaToolStripMenuItem.Click
    mTextBox.TextAlign = HorizontalAlignment.Right
    mCampo.Justificacion = EnumJustificacion.Right
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub DosDecimalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosDecimalesToolStripMenuItem.Click
    mCampo.Format = "N2"
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub

  Private Sub AplicarFormatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplicarFormatoToolStripMenuItem.Click
    mCampo.Format = Me.ToolStripTextBoxFormato.Text
    RaiseEvent CambioDatosEvent(Me, Nothing)
  End Sub
End Class
