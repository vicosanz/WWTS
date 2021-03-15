<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLista
  Inherits Infoware.Consola.Base.FrmListaSimpleBase

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
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLista))
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
    Me.btnejecutar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.lblmensaje = New System.Windows.Forms.ToolStripLabel
    Me.btnconfemail = New System.Windows.Forms.ToolStripButton
    Me.tmrdatos = New System.Windows.Forms.Timer(Me.components)
    Me.pnlcuerpo.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 392)
    '
    'Panel1
    '
    Me.Panel1.AutoScroll = True
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Size = New System.Drawing.Size(150, 367)
    Me.Panel1.TabIndex = 0
    Me.Panel1.Visible = True
    '
    'Timer1
    '
    '
    'Panel2
    '
    Me.Panel2.Location = New System.Drawing.Point(150, 25)
    Me.Panel2.Size = New System.Drawing.Size(542, 22)
    Me.Panel2.TabIndex = 1
    '
    'Timer2
    '
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnejecutar, Me.ToolStripSeparator1, Me.lblmensaje, Me.btnconfemail})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 49)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(692, 25)
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
    Me.btnejecutar.Size = New System.Drawing.Size(110, 22)
    Me.btnejecutar.Text = "Ejecutar consulta"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 5
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'lblmensaje
    '
    Me.lblmensaje.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.lblmensaje.MergeIndex = 5
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(187, 22)
    Me.lblmensaje.Text = "No existen registros en la vista actual"
    '
    'btnconfemail
    '
    Me.btnconfemail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnconfemail.Image = My.Resources.Resources.configure.ToBitmap
    Me.btnconfemail.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnconfemail.Name = "btnconfemail"
    Me.btnconfemail.Size = New System.Drawing.Size(23, 22)
    Me.btnconfemail.Text = "Configurar envío email automático"
    Me.btnconfemail.Visible = False
    '
    'tmrdatos
    '
    Me.tmrdatos.Enabled = True
    Me.tmrdatos.Interval = 350
    '
    'FrmLista
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Name = "FrmLista"
    Me.PuedeImprimir = True
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
  Friend WithEvents tmrdatos As System.Windows.Forms.Timer
  Friend WithEvents btnconfemail As System.Windows.Forms.ToolStripButton

End Class
