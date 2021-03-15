<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaContactos
  Inherits Infoware.Consola.Base.FrmListaBase

  'Form overrides dispose to clean up the component list.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaContactos))
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnmayorizar = New System.Windows.Forms.ToolStripButton()
    Me.btndemayorizar = New System.Windows.Forms.ToolStripButton()
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(7, 4, 7, 4)
    Me.Panel1.Size = New System.Drawing.Size(923, 63)
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 82)
    Me.pnlcuerpo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.pnlcuerpo.Size = New System.Drawing.Size(923, 492)
    '
    'ToolStrip2
    '
    Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnmayorizar, Me.btndemayorizar})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 55)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(923, 27)
    Me.ToolStrip2.TabIndex = 5
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 1
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
    '
    'btnmayorizar
    '
    Me.btnmayorizar.Image = CType(resources.GetObject("btnmayorizar.Image"), System.Drawing.Image)
    Me.btnmayorizar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnmayorizar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnmayorizar.MergeIndex = 10
    Me.btnmayorizar.Name = "btnmayorizar"
    Me.btnmayorizar.Size = New System.Drawing.Size(109, 24)
    Me.btnmayorizar.Text = "Seleccionar"
    '
    'btndemayorizar
    '
    Me.btndemayorizar.Image = CType(resources.GetObject("btndemayorizar.Image"), System.Drawing.Image)
    Me.btndemayorizar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btndemayorizar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btndemayorizar.MergeIndex = 11
    Me.btndemayorizar.Name = "btndemayorizar"
    Me.btndemayorizar.Size = New System.Drawing.Size(74, 24)
    Me.btndemayorizar.Text = "Quitar"
    '
    'FrmListaContactos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.ClientSize = New System.Drawing.Size(923, 574)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "FrmListaContactos"
    Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnmayorizar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btndemayorizar As System.Windows.Forms.ToolStripButton

End Class
