<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlSeccionHorno
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
    Me.CtlHorno1 = New CtlHorno
    Me.lstseccionhorno = New System.Windows.Forms.ComboBox
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnunuevo = New System.Windows.Forms.ToolStripMenuItem
    Me.mnumodificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnueliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuactualizar = New System.Windows.Forms.ToolStripMenuItem
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'CtlHorno1
    '
    Me.CtlHorno1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlHorno1.Horno = Nothing
    Me.CtlHorno1.Location = New System.Drawing.Point(0, 0)
    Me.CtlHorno1.Name = "CtlHorno1"
    Me.CtlHorno1.Op = Nothing
    Me.CtlHorno1.Size = New System.Drawing.Size(150, 71)
    Me.CtlHorno1.TabIndex = 0
    '
    'lstseccionhorno
    '
    Me.lstseccionhorno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.lstseccionhorno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.lstseccionhorno.ContextMenuStrip = Me.ContextMenuStrip1
    Me.lstseccionhorno.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstseccionhorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.lstseccionhorno.FormattingEnabled = True
    Me.lstseccionhorno.Location = New System.Drawing.Point(0, 71)
    Me.lstseccionhorno.Name = "lstseccionhorno"
    Me.lstseccionhorno.Size = New System.Drawing.Size(150, 79)
    Me.lstseccionhorno.TabIndex = 1
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnunuevo, Me.mnumodificar, Me.mnueliminar, Me.ToolStripMenuItem1, Me.mnuactualizar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(122, 98)
    '
    'mnunuevo
    '
    Me.mnunuevo.Image = My.Resources.nuevo
    Me.mnunuevo.Name = "mnunuevo"
    Me.mnunuevo.Size = New System.Drawing.Size(121, 22)
    Me.mnunuevo.Text = "&Nuevo"
    '
    'mnumodificar
    '
    Me.mnumodificar.Image = My.Resources.abrir
    Me.mnumodificar.Name = "mnumodificar"
    Me.mnumodificar.Size = New System.Drawing.Size(121, 22)
    Me.mnumodificar.Text = "&Modificar"
    '
    'mnueliminar
    '
    Me.mnueliminar.Image = My.Resources.eliminar
    Me.mnueliminar.Name = "mnueliminar"
    Me.mnueliminar.Size = New System.Drawing.Size(121, 22)
    Me.mnueliminar.Text = "&Eliminar"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(118, 6)
    '
    'mnuactualizar
    '
    Me.mnuactualizar.Name = "mnuactualizar"
    Me.mnuactualizar.Size = New System.Drawing.Size(121, 22)
    Me.mnuactualizar.Text = "&Actualizar"
    '
    'CtlSeccionHorno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lstseccionhorno)
    Me.Controls.Add(Me.CtlHorno1)
    Me.Name = "CtlSeccionHorno"
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CtlHorno1 As CtlHorno
  Friend WithEvents lstseccionhorno As System.Windows.Forms.ComboBox
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnunuevo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnumodificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnueliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuactualizar As System.Windows.Forms.ToolStripMenuItem

End Class
