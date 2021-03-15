<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
  Inherits Infoware.Consola.Base.FrmFormaBase

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
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.pnlopcion = New System.Windows.Forms.Panel()
    Me.tvconfigurar = New System.Windows.Forms.TreeView()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.pnlopcion)
    Me.Pnlcuerpo.Controls.Add(Me.tvconfigurar)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(845, 567)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'pnlopcion
    '
    Me.pnlopcion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlopcion.Location = New System.Drawing.Point(215, 32)
    Me.pnlopcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.pnlopcion.Name = "pnlopcion"
    Me.pnlopcion.Size = New System.Drawing.Size(630, 535)
    Me.pnlopcion.TabIndex = 3
    '
    'tvconfigurar
    '
    Me.tvconfigurar.Dock = System.Windows.Forms.DockStyle.Left
    Me.tvconfigurar.HideSelection = False
    Me.tvconfigurar.Location = New System.Drawing.Point(0, 32)
    Me.tvconfigurar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.tvconfigurar.Name = "tvconfigurar"
    Me.tvconfigurar.ShowRootLines = False
    Me.tvconfigurar.Size = New System.Drawing.Size(215, 535)
    Me.tvconfigurar.TabIndex = 2
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(845, 32)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(155, 29)
    Me.ToolStripLabel1.Text = "Configuración"
    '
    'FrmConfiguracion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(845, 567)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "FrmConfiguracion"
    Me.Text = "Configuración"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents tvconfigurar As System.Windows.Forms.TreeView
  Friend WithEvents pnlopcion As System.Windows.Forms.Panel
End Class
