<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlHorno
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.CtlTerreno1 = New CtlTerreno
    Me.lstHorno = New System.Windows.Forms.ListBox
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnunuevo = New System.Windows.Forms.ToolStripMenuItem
    Me.mnumodificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnueliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuactualizar = New System.Windows.Forms.ToolStripMenuItem
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'CtlTerreno1
    '
    Me.CtlTerreno1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlTerreno1.Location = New System.Drawing.Point(0, 0)
    Me.CtlTerreno1.Name = "CtlTerreno1"
    Me.CtlTerreno1.Op = Nothing
    Me.CtlTerreno1.Size = New System.Drawing.Size(102, 119)
    Me.CtlTerreno1.TabIndex = 0
    Me.CtlTerreno1.Terreno = Nothing
    '
    'lstHorno
    '
    Me.lstHorno.ContextMenuStrip = Me.ContextMenuStrip1
    Me.lstHorno.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstHorno.FormattingEnabled = True
    Me.lstHorno.Location = New System.Drawing.Point(102, 0)
    Me.lstHorno.Name = "lstHorno"
    Me.lstHorno.Size = New System.Drawing.Size(56, 108)
    Me.lstHorno.TabIndex = 1
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnunuevo, Me.mnumodificar, Me.mnueliminar, Me.ToolStripMenuItem1, Me.mnuactualizar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 120)
    '
    'mnunuevo
    '
    Me.mnunuevo.Image = My.Resources.nuevo
    Me.mnunuevo.Name = "mnunuevo"
    Me.mnunuevo.Size = New System.Drawing.Size(152, 22)
    Me.mnunuevo.Text = "&Nuevo"
    '
    'mnumodificar
    '
    Me.mnumodificar.Image = My.Resources.abrir
    Me.mnumodificar.Name = "mnumodificar"
    Me.mnumodificar.Size = New System.Drawing.Size(152, 22)
    Me.mnumodificar.Text = "&Modificar"
    '
    'mnueliminar
    '
    Me.mnueliminar.Image = My.Resources.eliminar
    Me.mnueliminar.Name = "mnueliminar"
    Me.mnueliminar.Size = New System.Drawing.Size(152, 22)
    Me.mnueliminar.Text = "&Eliminar"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
    '
    'mnuactualizar
    '
    Me.mnuactualizar.Name = "mnuactualizar"
    Me.mnuactualizar.Size = New System.Drawing.Size(152, 22)
    Me.mnuactualizar.Text = "&Actualizar"
    '
    'CtlHorno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lstHorno)
    Me.Controls.Add(Me.CtlTerreno1)
    Me.Name = "CtlHorno"
    Me.Size = New System.Drawing.Size(158, 119)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CtlTerreno1 As CtlTerreno
  Friend WithEvents lstHorno As System.Windows.Forms.ListBox
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnunuevo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnumodificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnueliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuactualizar As System.Windows.Forms.ToolStripMenuItem

End Class
