<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlLabor
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlLabor))
    Me.CtlSeccion1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.lstLabor = New System.Windows.Forms.ListBox()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnunuevo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnumodificar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnueliminar = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuactualizar = New System.Windows.Forms.ToolStripMenuItem()
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'CtlSeccion1
    '
    Me.CtlSeccion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlSeccion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlSeccion1.FormattingEnabled = True
    Me.CtlSeccion1.Location = New System.Drawing.Point(0, 0)
    Me.CtlSeccion1.Name = "CtlSeccion1"
    Me.CtlSeccion1.OperadorDatos = Nothing
    Me.CtlSeccion1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlSeccion1.ParametroDet = Nothing
    Me.CtlSeccion1.PuedeActualizar = True
    Me.CtlSeccion1.PuedeEliminar = True
    Me.CtlSeccion1.PuedeModificar = True
    Me.CtlSeccion1.PuedeNuevo = True
    Me.CtlSeccion1.Size = New System.Drawing.Size(150, 21)
    Me.CtlSeccion1.TabIndex = 0
    '
    'lstLabor
    '
    Me.lstLabor.ContextMenuStrip = Me.ContextMenuStrip1
    Me.lstLabor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstLabor.FormattingEnabled = True
    Me.lstLabor.Location = New System.Drawing.Point(0, 21)
    Me.lstLabor.Name = "lstLabor"
    Me.lstLabor.Size = New System.Drawing.Size(150, 148)
    Me.lstLabor.TabIndex = 1
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnunuevo, Me.mnumodificar, Me.mnueliminar, Me.ToolStripMenuItem1, Me.mnuactualizar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 98)
    '
    'mnunuevo
    '
    Me.mnunuevo.Image = My.Resources.Resources._new
    Me.mnunuevo.Name = "mnunuevo"
    Me.mnunuevo.Size = New System.Drawing.Size(132, 22)
    Me.mnunuevo.Text = "&Nuevo"
    '
    'mnumodificar
    '
    Me.mnumodificar.Image = My.Resources.Resources.open
    Me.mnumodificar.Name = "mnumodificar"
    Me.mnumodificar.Size = New System.Drawing.Size(132, 22)
    Me.mnumodificar.Text = "&Modificar"
    '
    'mnueliminar
    '
    Me.mnueliminar.Image = My.Resources.Resources.eliminar
    Me.mnueliminar.Name = "mnueliminar"
    Me.mnueliminar.Size = New System.Drawing.Size(132, 22)
    Me.mnueliminar.Text = "&Eliminar"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 6)
    '
    'mnuactualizar
    '
    Me.mnuactualizar.Image = CType(resources.GetObject("mnuactualizar.Image"), System.Drawing.Image)
    Me.mnuactualizar.Name = "mnuactualizar"
    Me.mnuactualizar.Size = New System.Drawing.Size(132, 22)
    Me.mnuactualizar.Text = "&Actualizar"
    '
    'CtlLabor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lstLabor)
    Me.Controls.Add(Me.CtlSeccion1)
    Me.Name = "CtlLabor"
    Me.Size = New System.Drawing.Size(150, 169)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CtlSeccion1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents lstLabor As System.Windows.Forms.ListBox
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnumodificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnueliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuactualizar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnunuevo As System.Windows.Forms.ToolStripMenuItem

End Class
