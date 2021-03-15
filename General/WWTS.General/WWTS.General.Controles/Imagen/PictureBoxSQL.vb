Imports System.Drawing

Public Class PictureBoxSQL
  Inherits PictureBox

  Public Event CambioImagen As EventHandler

  Private mArchivoImagen As String
  Public Property ArchivoImagen() As String
    Get
      Return mArchivoImagen
    End Get
    Set(ByVal value As String)
      Try
        If value = String.Empty Then
          Me.Image = Nothing
        Else
          Me.Image = Drawing.Image.FromFile(value)
        End If
        mArchivoImagen = value
        RaiseEvent CambioImagen(Me, Nothing)
      Catch ex As Exception
        MsgBox("Error cargando imagen", MsgBoxStyle.Critical, "Error")
      End Try
    End Set
  End Property

  Private mImagen As Image
  Public Property Imagen() As Image
    Get
      Return mImagen
    End Get
    Set(ByVal value As Image)
      mImagen = value
    End Set
  End Property

  Public Sub New()
    Me.SizeMode = PictureBoxSizeMode.Zoom

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
    '
    'CambiarImagenToolStripMenuItem
    '
    CambiarImagenToolStripMenuItem.Name = "CambiarImagenToolStripMenuItem"
    CambiarImagenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
    CambiarImagenToolStripMenuItem.Text = "Desde &archivo..."
    '
    'QuitarImagenToolStripMenuItem
    '
    QuitarImagenToolStripMenuItem.Name = "QuitarImagenToolStripMenuItem"
    QuitarImagenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
    QuitarImagenToolStripMenuItem.Text = "&Quitar imagen"

    AddHandler CambiarImagenToolStripMenuItem.Click, AddressOf Cargar_DesdeArchivo
    AddHandler ObtenerToolStripMenuItem.Click, AddressOf Cargar_DesdeWIA
    AddHandler QuitarImagenToolStripMenuItem.Click, AddressOf QuitarImagen
    Me.ContextMenuStrip = ContextMenuStrip1
  End Sub

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
End Class
