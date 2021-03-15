<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEmergFijosTemporada
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
    Me.XpCaptionPane1 = New System.Windows.Forms.Panel
    Me.lblmensaje = New System.Windows.Forms.Label
    Me.HeaderStrip2.SuspendLayout()
    Me.XpCaptionPane1.SuspendLayout()
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
    Me.ToolStripLabel2.Size = New System.Drawing.Size(143, 16)
    Me.ToolStripLabel2.Text = "Contador de personal activo"
    '
    'XpCaptionPane1
    '
    Me.XpCaptionPane1.BackColor = System.Drawing.Color.Transparent
    Me.XpCaptionPane1.Controls.Add(Me.lblmensaje)
    Me.XpCaptionPane1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.XpCaptionPane1.Location = New System.Drawing.Point(0, 19)
    Me.XpCaptionPane1.Name = "XpCaptionPane1"
    Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
    Me.XpCaptionPane1.Size = New System.Drawing.Size(328, 149)
    Me.XpCaptionPane1.TabIndex = 4
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.lblmensaje.Location = New System.Drawing.Point(1, 132)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(326, 16)
    Me.lblmensaje.TabIndex = 1
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CtlEmergFijosTemporada
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.XpCaptionPane1)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlEmergFijosTemporada"
    Me.Size = New System.Drawing.Size(328, 168)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.XpCaptionPane1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Controles.Especiales.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents XpCaptionPane1 As System.Windows.Forms.Panel
  Friend WithEvents lblmensaje As System.Windows.Forms.Label

End Class
