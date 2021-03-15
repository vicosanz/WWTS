Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Drawing.Imaging

'<Designer(GetType(ImagenSQLDesigner)), DesignTimeVisibleAttribute(True)> _
Public Class ImagenSQL

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

    Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

    Dim ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Dim ObtenerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Dim CambiarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Dim QuitarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip
    ObtenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    CambiarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    QuitarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem

    '
    'ContextMenuStrip1
    '
    ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {CambiarImagenToolStripMenuItem, ObtenerToolStripMenuItem, QuitarImagenToolStripMenuItem})
    ContextMenuStrip1.Name = "ContextMenuStrip1"
    ContextMenuStrip1.Size = New System.Drawing.Size(151, 48)
    '
    'ObtenerToolStripMenuItem
    '
    ObtenerToolStripMenuItem.Name = "ObtenerToolStripMenuItem"
    ObtenerToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
    ObtenerToolStripMenuItem.Text = "&Desde escáner o cámara..."
    ObtenerToolStripMenuItem.Image = My.Resources.Resources.Escaner.ToBitmap
    '
    'CambiarImagenToolStripMenuItem
    '
    CambiarImagenToolStripMenuItem.Name = "CambiarImagenToolStripMenuItem"
    CambiarImagenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
    CambiarImagenToolStripMenuItem.Text = "Desde &archivo..."
    CambiarImagenToolStripMenuItem.Image = My.Resources.Resources.imagen.ToBitmap
    '
    'QuitarImagenToolStripMenuItem
    '
    QuitarImagenToolStripMenuItem.Name = "QuitarImagenToolStripMenuItem"
    QuitarImagenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
    QuitarImagenToolStripMenuItem.Text = "&Quitar imagen"
    QuitarImagenToolStripMenuItem.Image = My.Resources.Resources.eliminar.ToBitmap

    AddHandler CambiarImagenToolStripMenuItem.Click, AddressOf Cargar_DesdeArchivo
    AddHandler ObtenerToolStripMenuItem.Click, AddressOf Cargar_DesdeWIA
    AddHandler QuitarImagenToolStripMenuItem.Click, AddressOf QuitarImagen
    Me.ContextMenuStrip = ContextMenuStrip1

  End Sub

  Public Event CambioImagen As EventHandler

#Region "Adornos"
  Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    MyBase.OnPaint(e)

    Dim pct As New ProfessionalColorTable
    Dim lrectTop As New RectangleF(0, 0, Me.Width, Me.Height / 2 + 1)
    Dim lrectBottom As New RectangleF(0, Me.Height / 2 - 1, Me.Width, Me.Height / 2 + 2)

    Dim lbrushTop As New LinearGradientBrush(lrectTop, pct.MenuItemPressedGradientBegin, pct.MenuItemPressedGradientMiddle, LinearGradientMode.Vertical)

    Dim gpTop As New GraphicsPath
    gpTop = Paths.RoundedRect(lrectTop, 5, 0, Corner.TopLeft Or Corner.TopRight)
    e.Graphics.FillPath(lbrushTop, gpTop)
    gpTop.Dispose()
    lbrushTop.Dispose()

    Dim lbrushBottom As New LinearGradientBrush(lrectBottom, pct.MenuItemPressedGradientMiddle, pct.MenuItemPressedGradientBegin, LinearGradientMode.Vertical)

    Dim gpBottom As New GraphicsPath
    gpBottom = Paths.RoundedRect(lrectBottom, 5, 0, Corner.BottomLeft Or Corner.BottomRight)
    e.Graphics.FillPath(lbrushBottom, gpBottom)
    gpBottom.Dispose()
    lbrushBottom.Dispose()

  End Sub
#End Region

  Private mArchivoImagen As String = String.Empty
  Public Property ArchivoImagen() As String
    Get
      Return mArchivoImagen
    End Get
    Set(ByVal value As String)
      Try
        If value = String.Empty Then
          Me.PictureBox1.Image = Nothing
        Else
          Me.PictureBox1.Image = Drawing.Image.FromFile(value)
        End If
        mArchivoImagen = value
        Me.Label1.Visible = False
        RaiseEvent CambioImagen(Me, Nothing)
      Catch ex As Exception
        MsgBox("Error cargando imagen", MsgBoxStyle.Critical, "Error")
        Me.Label1.Visible = True
      End Try
    End Set
  End Property

  Public Property Imagen() As Image
    Get
      Return Me.PictureBox1.Image
    End Get
    Set(ByVal value As Image)
      Me.PictureBox1.Image = value
    End Set
  End Property

  Private Sub QuitarImagen(ByVal sender As Object, ByVal e As EventArgs)
    ArchivoImagen = String.Empty
  End Sub

  Private Sub Cargar_DesdeArchivo(ByVal sender As Object, ByVal e As EventArgs)
    Dim openFileDialog1 As New OpenFileDialog
    openFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
    openFileDialog1.Filter = "Todos los archivos de imágenes (*.jpg; *.bmp)|*.jpg; *.bmp|Todos los archivo (*.*)|*.*"
    openFileDialog1.FilterIndex = 1
    openFileDialog1.FileName = String.Empty
    openFileDialog1.RestoreDirectory = True

    If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
      ArchivoImagen = openFileDialog1.FileName
    End If
  End Sub

  Private Sub Cargar_DesdeWIA(ByVal sender As Object, ByVal e As EventArgs)
    Dim f As New FrmAdquirirImagen
    If f.ShowDialog = DialogResult.OK Then
      ArchivoImagen = f.ImageFileName
    End If
  End Sub

  Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick, PictureBox1.DoubleClick
    Cargar_DesdeArchivo(Me, Nothing)
  End Sub
End Class

'Public Class ImagenSQLDesigner
'  Inherits BaseDesigner

'  Private m_Control As ImagenSQL

'  Public Sub New()
'    MyBase.New()
'  End Sub

'  Public Overrides Sub Initialize(ByVal component As System.ComponentModel.IComponent)
'    MyBase.Initialize(component)
'    m_Control = CType(Me.Control, ImagenSQL)
'  End Sub

'  Protected Overrides Sub OnPaintAdornments(ByVal pe As PaintEventArgs)
'    MyBase.OnPaintAdornments(pe)
'    'pe.Graphics.DrawRectangle(m_WorkspacePen, m_Control.WorkspaceRect)
'  End Sub
'End Class
