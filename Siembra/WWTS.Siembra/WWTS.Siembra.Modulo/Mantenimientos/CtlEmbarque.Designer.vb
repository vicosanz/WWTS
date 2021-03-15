<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEmbarque
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
    Me.CtlZafra1 = New WWTS.Siembra.Modulo.CtlZafra
    Me.lstEmbarque = New System.Windows.Forms.ListBox
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnunuevo = New System.Windows.Forms.ToolStripMenuItem
    Me.mnumodificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnueliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuactualizar = New System.Windows.Forms.ToolStripMenuItem
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'CtlZafra1
    '
    Me.CtlZafra1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.Location = New System.Drawing.Point(0, 0)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(158, 21)
    Me.CtlZafra1.TabIndex = 0
    Me.CtlZafra1.Zafra = Nothing
    '
    'lstEmbarque
    '
    Me.lstEmbarque.ContextMenuStrip = Me.ContextMenuStrip1
    Me.lstEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstEmbarque.FormattingEnabled = True
    Me.lstEmbarque.Location = New System.Drawing.Point(0, 21)
    Me.lstEmbarque.Name = "lstEmbarque"
    Me.lstEmbarque.Size = New System.Drawing.Size(158, 95)
    Me.lstEmbarque.TabIndex = 1
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
    'CtlEmbarque
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lstEmbarque)
    Me.Controls.Add(Me.CtlZafra1)
    Me.Name = "CtlEmbarque"
    Me.Size = New System.Drawing.Size(158, 119)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CtlZafra1 As WWTS.Siembra.Modulo.CtlZafra
  Friend WithEvents lstEmbarque As System.Windows.Forms.ListBox
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnunuevo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnumodificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnueliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuactualizar As System.Windows.Forms.ToolStripMenuItem

End Class
