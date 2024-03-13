<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCuracion
    Inherits Infoware.Consola.Base.FrmFormaBase

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
        Me.PnlCuerpo = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CtlTarjCuracion1 = New Siembra.CtlTarjCuracion()
        Me.CtlBuscaTarjetaCuracion1 = New Siembra.CtlBuscaTarjetaCuracion()
        Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PnlCuerpo.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.HeaderStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlCuerpo
        '
        Me.PnlCuerpo.Controls.Add(Me.TabControl1)
        Me.PnlCuerpo.Controls.Add(Me.HeaderStrip1)
        Me.PnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCuerpo.Location = New System.Drawing.Point(0, 0)
        Me.PnlCuerpo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlCuerpo.Name = "PnlCuerpo"
        Me.PnlCuerpo.Size = New System.Drawing.Size(1126, 805)
        Me.PnlCuerpo.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1126, 764)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CtlTarjCuracion1)
        Me.TabPage1.Controls.Add(Me.CtlBuscaTarjetaCuracion1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1118, 727)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tarjeta de curación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CtlTarjCuracion1
        '
        Me.CtlTarjCuracion1.BackColor = System.Drawing.Color.Transparent
        Me.CtlTarjCuracion1.Curacion = Nothing
        Me.CtlTarjCuracion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlTarjCuracion1.Location = New System.Drawing.Point(272, 5)
        Me.CtlTarjCuracion1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CtlTarjCuracion1.Name = "CtlTarjCuracion1"
        Me.CtlTarjCuracion1.Op = Nothing
        Me.CtlTarjCuracion1.Size = New System.Drawing.Size(842, 717)
        Me.CtlTarjCuracion1.TabIndex = 1
        '
        'CtlBuscaTarjetaCuracion1
        '
        Me.CtlBuscaTarjetaCuracion1.BackColor = System.Drawing.SystemColors.Info
        Me.CtlBuscaTarjetaCuracion1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtlBuscaTarjetaCuracion1.Location = New System.Drawing.Point(4, 5)
        Me.CtlBuscaTarjetaCuracion1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CtlBuscaTarjetaCuracion1.Name = "CtlBuscaTarjetaCuracion1"
        Me.CtlBuscaTarjetaCuracion1.Op = Nothing
        Me.CtlBuscaTarjetaCuracion1.Size = New System.Drawing.Size(268, 717)
        Me.CtlBuscaTarjetaCuracion1.TabIndex = 0
        '
        'HeaderStrip1
        '
        Me.HeaderStrip1.AutoSize = False
        Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
        Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip1.Name = "HeaderStrip1"
        Me.HeaderStrip1.Size = New System.Drawing.Size(1126, 41)
        Me.HeaderStrip1.TabIndex = 2
        Me.HeaderStrip1.Text = "HeaderStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(145, 35)
        Me.ToolStripLabel1.Text = "Curación"
        '
        'FrmCuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 805)
        Me.Controls.Add(Me.PnlCuerpo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCuracion"
        Me.Text = "Curación"
        Me.PnlCuerpo.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.HeaderStrip1.ResumeLayout(False)
        Me.HeaderStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlCuerpo As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CtlBuscaTarjetaCuracion1 As CtlBuscaTarjetaCuracion
    Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CtlTarjCuracion1 As CtlTarjCuracion
End Class
