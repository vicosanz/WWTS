<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListaReporte
  Inherits Infoware.Consola.Base.FrmReporteBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaReporte))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnejecutar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblmensaje = New System.Windows.Forms.ToolStripLabel()
        Me.btnconfemail = New System.Windows.Forms.ToolStripButton()
        Me.tmrdatos = New System.Windows.Forms.Timer(Me.components)
        Me.pnlcuerpo.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Panel1.Padding = New System.Windows.Forms.Padding(12, 9, 12, 9)
        Me.Panel1.Size = New System.Drawing.Size(225, 585)
        Me.Panel1.TabIndex = 0
        '
        'pnlcuerpo
        '
        Me.pnlcuerpo.Location = New System.Drawing.Point(0, 96)
        Me.pnlcuerpo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.pnlcuerpo.Size = New System.Drawing.Size(1038, 621)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnejecutar, Me.ToolStripSeparator1, Me.lblmensaje, Me.btnconfemail})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 62)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(1038, 34)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnejecutar
        '
        Me.btnejecutar.Image = CType(resources.GetObject("btnejecutar.Image"), System.Drawing.Image)
        Me.btnejecutar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnejecutar.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.btnejecutar.MergeIndex = 5
        Me.btnejecutar.Name = "btnejecutar"
        Me.btnejecutar.Size = New System.Drawing.Size(172, 29)
        Me.btnejecutar.Text = "Ejecutar consulta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ToolStripSeparator1.MergeIndex = 5
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'lblmensaje
        '
        Me.lblmensaje.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.lblmensaje.MergeIndex = 5
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(303, 29)
        Me.lblmensaje.Text = "No existen registros en la vista actual"
        '
        'btnconfemail
        '
        Me.btnconfemail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnconfemail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnconfemail.Name = "btnconfemail"
        Me.btnconfemail.Size = New System.Drawing.Size(34, 29)
        Me.btnconfemail.Text = "Configurar envío email automático"
        Me.btnconfemail.Visible = False
        '
        'tmrdatos
        '
        Me.tmrdatos.Enabled = True
        Me.tmrdatos.Interval = 350
        '
        'FrmListaReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(1038, 717)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.Name = "FrmListaReporte"
        Me.Text = "Reportes externos"
        Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
        Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
        Me.pnlcuerpo.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnejecutar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents lblmensaje As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnconfemail As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrdatos As Timer
End Class
