<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
    Me.Pnlcuerpo = New System.Windows.Forms.Panel
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.CtlEmergPeriodoNegativo1 = New WWTS.Roles.Modulo.CtlEmergPeriodoNegativo
    Me.CtlEmergFijosTemporada1 = New WWTS.Roles.Modulo.CtlEmergFijosTemporada
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.CtlPatrono1 = New WWTS.Roles.Modulo.CtlPatrono
    Me.Label1 = New System.Windows.Forms.Label
    Me.CtlEmergTresFaltas1 = New WWTS.Roles.Modulo.CtlEmergTresFaltas
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.Pnlcuerpo.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.BackColor = System.Drawing.Color.Transparent
    Me.Pnlcuerpo.Controls.Add(Me.TableLayoutPanel2)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(677, 605)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.CtlEmergTresFaltas1, 1, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(677, 580)
    Me.TableLayoutPanel2.TabIndex = 3
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.CtlEmergPeriodoNegativo1, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlEmergFijosTemporada1, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(332, 574)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'CtlEmergPeriodoNegativo1
    '
    Me.CtlEmergPeriodoNegativo1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEmergPeriodoNegativo1.Location = New System.Drawing.Point(3, 117)
    Me.CtlEmergPeriodoNegativo1.Name = "CtlEmergPeriodoNegativo1"
    Me.CtlEmergPeriodoNegativo1.Op = Nothing
    Me.CtlEmergPeriodoNegativo1.Patrono = Nothing
    Me.CtlEmergPeriodoNegativo1.Size = New System.Drawing.Size(326, 223)
    Me.CtlEmergPeriodoNegativo1.TabIndex = 1
    '
    'CtlEmergFijosTemporada1
    '
    Me.CtlEmergFijosTemporada1.BackColor = System.Drawing.Color.Transparent
    Me.CtlEmergFijosTemporada1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEmergFijosTemporada1.Location = New System.Drawing.Point(3, 346)
    Me.CtlEmergFijosTemporada1.Name = "CtlEmergFijosTemporada1"
    Me.CtlEmergFijosTemporada1.Op = Nothing
    Me.CtlEmergFijosTemporada1.Patrono = Nothing
    Me.CtlEmergFijosTemporada1.Size = New System.Drawing.Size(326, 225)
    Me.CtlEmergFijosTemporada1.TabIndex = 0
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlPatrono1)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(326, 108)
    Me.Panel1.TabIndex = 2
    '
    'CtlPatrono1
    '
    Me.CtlPatrono1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CtlPatrono1.Location = New System.Drawing.Point(59, 6)
    Me.CtlPatrono1.Name = "CtlPatrono1"
    Me.CtlPatrono1.Op = Nothing
    Me.CtlPatrono1.Patrono = Nothing
    Me.CtlPatrono1.Size = New System.Drawing.Size(168, 99)
    Me.CtlPatrono1.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 6)
    Me.Label1.Margin = New System.Windows.Forms.Padding(3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Patrono:"
    '
    'CtlEmergTresFaltas1
    '
    Me.CtlEmergTresFaltas1.BackColor = System.Drawing.Color.Transparent
    Me.CtlEmergTresFaltas1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEmergTresFaltas1.Location = New System.Drawing.Point(341, 3)
    Me.CtlEmergTresFaltas1.Name = "CtlEmergTresFaltas1"
    Me.CtlEmergTresFaltas1.Op = Nothing
    Me.CtlEmergTresFaltas1.Patrono = Nothing
    Me.CtlEmergTresFaltas1.Size = New System.Drawing.Size(333, 574)
    Me.CtlEmergTresFaltas1.TabIndex = 3
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(677, 25)
    Me.HeaderStrip1.TabIndex = 4
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(119, 22)
    Me.ToolStripLabel1.Text = "Roles de pago"
    '
    'FrmInicio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(677, 605)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Name = "FrmInicio"
    Me.Text = "FrmInicio"
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents CtlEmergFijosTemporada1 As CtlEmergFijosTemporada
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents CtlEmergPeriodoNegativo1 As CtlEmergPeriodoNegativo
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlPatrono1 As CtlPatrono
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents CtlEmergTresFaltas1 As CtlEmergTresFaltas
End Class
