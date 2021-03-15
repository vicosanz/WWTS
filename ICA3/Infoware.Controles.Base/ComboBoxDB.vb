Imports System.ComponentModel
<ToolboxItem(False)> _
Public Class ComboBoxDB
  Inherits ComboBoxStd

  Public Event CambioItem As EventHandler
  Public Event ComandoNuevo As EventHandler
  Public Event ComandoModificar As EventHandler
  Public Event ComandoEliminar As EventHandler
  Public Event ComandoActualizar As EventHandler

#Region "Propiedades"
  Private mPuedeNuevo As Boolean = True
  Public Property PuedeNuevo() As Boolean
    Get
      Return mPuedeNuevo
    End Get
    Set(ByVal value As Boolean)
      mPuedeNuevo = value
    End Set
  End Property
  Private mPuedeModificar As Boolean = True
  Public Property PuedeModificar() As Boolean
    Get
      Return mPuedeModificar
    End Get
    Set(ByVal value As Boolean)
      mPuedeModificar = value
    End Set
  End Property
  Private mPuedeEliminar As Boolean = True
  Public Property PuedeEliminar() As Boolean
    Get
      Return mPuedeEliminar
    End Get
    Set(ByVal value As Boolean)
      mPuedeEliminar = value
    End Set
  End Property
  Private mPuedeActualizar As Boolean = True
  Public Property PuedeActualizar() As Boolean
    Get
      Return mPuedeActualizar
    End Get
    Set(ByVal value As Boolean)
      mPuedeActualizar = value
    End Set
  End Property
#End Region

  Private Sub UCComboDataBase_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataSourceChanged, Me.SelectedIndexChanged
    RaiseEvent CambioItem(Me, Nothing)
  End Sub

#Region "New"
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Private components As System.ComponentModel.IContainer
  Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuseparador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuseparador1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuActualizar As System.Windows.Forms.ToolStripMenuItem

  Public Sub New()
    Me.DropDownStyle = ComboBoxStyle.DropDownList
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
    Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuseparador = New System.Windows.Forms.ToolStripSeparator
    Me.mnuActualizar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuseparador1 = New System.Windows.Forms.ToolStripSeparator
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuModificar, Me.mnuseparador, Me.mnuEliminar, Me.mnuseparador1, Me.mnuActualizar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
    '
    'mnuNuevo
    '
    Me.mnuNuevo.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.mnuNuevo.Name = "mnuNuevo"
    Me.mnuNuevo.Size = New System.Drawing.Size(117, 22)
    Me.mnuNuevo.Text = "&Nuevo"
    '
    'mnuModificar
    '
    Me.mnuModificar.Image = My.Resources.Resources.abrir.ToBitmap
    Me.mnuModificar.Name = "mnuModificar"
    Me.mnuModificar.Size = New System.Drawing.Size(117, 22)
    Me.mnuModificar.Text = "&Modificar"
    '
    'mnuEliminar
    '
    Me.mnuEliminar.Image = My.Resources.Resources.eliminar.ToBitmap
    Me.mnuEliminar.Name = "mnuEliminar"
    Me.mnuEliminar.Size = New System.Drawing.Size(117, 22)
    Me.mnuEliminar.Text = "&Eliminar"
    '
    'mnuseparador
    '
    Me.mnuseparador.Name = "mnuseparador"
    Me.mnuseparador.Size = New System.Drawing.Size(114, 6)
    '
    'mnuActualizar
    '
    'Me.mnuActualizar.Image = My.Resources.Resources.Abriricono
    Me.mnuActualizar.Name = "mnuActualizar"
    Me.mnuActualizar.Size = New System.Drawing.Size(117, 22)
    Me.mnuActualizar.Text = "&Actualizar"
    '
    'mnuseparador1
    '
    Me.mnuseparador1.Name = "mnuseparador"
    Me.mnuseparador1.Size = New System.Drawing.Size(114, 6)
    '
    'UCComboDataBase
    '
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

    Me.ContextMenuStrip = Me.ContextMenuStrip1

  End Sub
#End Region

  Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Me.mnuNuevo.Visible = PuedeNuevo
    Me.mnuModificar.Visible = PuedeModificar
    Me.mnuseparador.Visible = PuedeEliminar
    Me.mnuEliminar.Visible = PuedeEliminar
    Me.mnuseparador1.Visible = (PuedeNuevo Or PuedeModificar Or PuedeEliminar) And PuedeActualizar
    Me.mnuActualizar.Visible = PuedeActualizar
    If Me.SelectedIndex = -1 Then
      Me.mnuModificar.Visible = False
      Me.mnuseparador.Visible = False
      Me.mnuEliminar.Visible = False
    End If
  End Sub

  Private Sub mnuNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuNuevo.Click
    RaiseEvent ComandoNuevo(Me, Nothing)
  End Sub

  Private Sub mnuModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuModificar.Click
    RaiseEvent ComandoModificar(Me, Nothing)
  End Sub

  Private Sub mnuEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
    RaiseEvent ComandoEliminar(Me, Nothing)
  End Sub

  Private Sub mnuActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuActualizar.Click
    RaiseEvent ComandoActualizar(Me, Nothing)
  End Sub
End Class
