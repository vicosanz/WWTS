<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlLotePago
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlLotePago))
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnactualizar = New System.Windows.Forms.ToolStripButton()
    Me.btneliminar = New System.Windows.Forms.ToolStripButton()
    Me.btncerrar = New System.Windows.Forms.ToolStripButton()
    Me.lstlpv = New System.Windows.Forms.ListBox()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnactualizar, Me.btneliminar, Me.btncerrar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(24, 123)
    Me.ToolStrip1.TabIndex = 0
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnactualizar
    '
    Me.btnactualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
    Me.btnactualizar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnactualizar.Name = "btnactualizar"
    Me.btnactualizar.Size = New System.Drawing.Size(21, 20)
    Me.btnactualizar.Text = "Actualizar"
    '
    'btneliminar
    '
    Me.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminar.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.eliminar
    Me.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(21, 20)
    Me.btneliminar.Text = "Eliminar"
    '
    'btncerrar
    '
    Me.btncerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btncerrar.Image = Global.WWTS.Roles.Modulo.My.Resources.Resources.cerraricono
    Me.btncerrar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncerrar.Name = "btncerrar"
    Me.btncerrar.Size = New System.Drawing.Size(21, 20)
    Me.btncerrar.Text = "Cerrar"
    '
    'lstlpv
    '
    Me.lstlpv.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstlpv.FormattingEnabled = True
    Me.lstlpv.Location = New System.Drawing.Point(24, 0)
    Me.lstlpv.Name = "lstlpv"
    Me.lstlpv.Size = New System.Drawing.Size(126, 123)
    Me.lstlpv.TabIndex = 1
    '
    'CtlLotePago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lstlpv)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Name = "CtlLotePago"
    Me.Size = New System.Drawing.Size(150, 123)
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btneliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btncerrar As System.Windows.Forms.ToolStripButton
  Friend WithEvents lstlpv As System.Windows.Forms.ListBox
  Friend WithEvents btnactualizar As System.Windows.Forms.ToolStripButton

End Class
