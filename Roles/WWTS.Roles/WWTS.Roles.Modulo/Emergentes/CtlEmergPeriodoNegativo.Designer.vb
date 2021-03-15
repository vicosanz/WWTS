<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEmergPeriodoNegativo
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
    Me.HeaderStrip2 = New Infoware.Controles.Especiales.HeaderStrip
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
    Me.lvneg = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.lblmensaje = New System.Windows.Forms.Label
    Me.HeaderStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Tahoma", 8.25!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Controles.Especiales.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(328, 19)
    Me.HeaderStrip2.TabIndex = 3
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(167, 16)
    Me.ToolStripLabel2.Text = "Personal con periodo en negativo"
    '
    'lvneg
    '
    Me.lvneg.AllowColumnReorder = True
    Me.lvneg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
    Me.lvneg.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvneg.FullRowSelect = True
    Me.lvneg.Location = New System.Drawing.Point(0, 19)
    Me.lvneg.Name = "lvneg"
    Me.lvneg.Size = New System.Drawing.Size(328, 133)
    Me.lvneg.TabIndex = 7
    Me.lvneg.UseCompatibleStateImageBehavior = False
    Me.lvneg.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Tipo de contrato"
    Me.ColumnHeader1.Width = 105
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Periodo"
    Me.ColumnHeader2.Width = 72
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Tipo"
    Me.ColumnHeader3.Width = 38
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "#"
    Me.ColumnHeader4.Width = 43
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblmensaje.Location = New System.Drawing.Point(0, 152)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(328, 16)
    Me.lblmensaje.TabIndex = 6
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CtlEmergPeriodoNegativo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lvneg)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlEmergPeriodoNegativo"
    Me.Size = New System.Drawing.Size(328, 168)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Controles.Especiales.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents lvneg As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents lblmensaje As System.Windows.Forms.Label

End Class
