<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFermentacion
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
    Me.components = New System.ComponentModel.Container()
    Me.PnlCuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlBloque1 = New CtlBloque()
    Me.CtlBuscaBloqueFermentacion1 = New CtlBuscaBloqueFermentacion()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.crvsaldocujes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.CtlZafra1 = New CtlZafra()
    Me.dtcortadoensal = New System.Windows.Forms.DateTimePicker()
    Me.chkcortadoensal = New System.Windows.Forms.CheckBox()
    Me.btnmostrarsaldo = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.rdoDetallado = New System.Windows.Forms.RadioButton()
    Me.RadioButton1 = New System.Windows.Forms.RadioButton()

    Me.PnlCuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'PnlCuerpo
    '
    Me.PnlCuerpo.Controls.Add(Me.TabControl1)
    Me.PnlCuerpo.Controls.Add(Me.HeaderStrip1)
    Me.PnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PnlCuerpo.Location = New System.Drawing.Point(0, 0)
    Me.PnlCuerpo.Name = "PnlCuerpo"
    Me.PnlCuerpo.Size = New System.Drawing.Size(885, 699)
    Me.PnlCuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(885, 674)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlBloque1)
    Me.TabPage1.Controls.Add(Me.CtlBuscaBloqueFermentacion1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(636, 295)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Bloques"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlBloque1
    '
    Me.CtlBloque1.BackColor = System.Drawing.Color.Transparent
    Me.CtlBloque1.Bloque = Nothing
    Me.CtlBloque1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlBloque1.Location = New System.Drawing.Point(190, 3)
    Me.CtlBloque1.Name = "CtlBloque1"
    Me.CtlBloque1.op = Nothing
    Me.CtlBloque1.Size = New System.Drawing.Size(443, 289)
    Me.CtlBloque1.TabIndex = 1
    '
    'CtlBuscaBloqueFermentacion1
    '
    Me.CtlBuscaBloqueFermentacion1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaBloqueFermentacion1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaBloqueFermentacion1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaBloqueFermentacion1.Name = "CtlBuscaBloqueFermentacion1"
    Me.CtlBuscaBloqueFermentacion1.Op = Nothing
    Me.CtlBuscaBloqueFermentacion1.Size = New System.Drawing.Size(187, 289)
    Me.CtlBuscaBloqueFermentacion1.TabIndex = 0
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.crvsaldocujes)
    Me.TabPage2.Controls.Add(Me.Panel2)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(877, 648)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Saldos de tabaco en cuartos"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'crvsaldocujes
    '
    Me.crvsaldocujes.ActiveViewIndex = -1
    Me.crvsaldocujes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvsaldocujes.Cursor = System.Windows.Forms.Cursors.Default
    Me.crvsaldocujes.DisplayStatusBar = False
    Me.crvsaldocujes.DisplayToolbar = False
    Me.crvsaldocujes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvsaldocujes.Location = New System.Drawing.Point(3, 94)
    Me.crvsaldocujes.Name = "crvsaldocujes"
    Me.crvsaldocujes.Size = New System.Drawing.Size(871, 551)
    Me.crvsaldocujes.TabIndex = 5
    Me.crvsaldocujes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.Info
    Me.Panel2.Controls.Add(Me.RadioButton1)
    Me.Panel2.Controls.Add(Me.rdoDetallado)
    Me.Panel2.Controls.Add(Me.CtlZafra1)
    Me.Panel2.Controls.Add(Me.dtcortadoensal)
    Me.Panel2.Controls.Add(Me.chkcortadoensal)
    Me.Panel2.Controls.Add(Me.btnmostrarsaldo)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(3, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(871, 91)
    Me.Panel2.TabIndex = 4
    '
    'CtlZafra1
    '
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(73, 10)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(121, 21)
    Me.CtlZafra1.TabIndex = 7
    Me.CtlZafra1.Zafra = Nothing
    '
    'dtcortadoensal
    '
    Me.dtcortadoensal.Enabled = False
    Me.dtcortadoensal.Location = New System.Drawing.Point(260, 36)
    Me.dtcortadoensal.Name = "dtcortadoensal"
    Me.dtcortadoensal.Size = New System.Drawing.Size(216, 20)
    Me.dtcortadoensal.TabIndex = 5
    '
    'chkcortadoensal
    '
    Me.chkcortadoensal.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkcortadoensal.Location = New System.Drawing.Point(244, 12)
    Me.chkcortadoensal.Name = "chkcortadoensal"
    Me.chkcortadoensal.Size = New System.Drawing.Size(104, 16)
    Me.chkcortadoensal.TabIndex = 4
    Me.chkcortadoensal.Text = "Cortado al"
    '
    'btnmostrarsaldo
    '
    Me.btnmostrarsaldo.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrarsaldo.Location = New System.Drawing.Point(508, 58)
    Me.btnmostrarsaldo.Name = "btnmostrarsaldo"
    Me.btnmostrarsaldo.Size = New System.Drawing.Size(75, 23)
    Me.btnmostrarsaldo.TabIndex = 6
    Me.btnmostrarsaldo.Text = "&Mostrar"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(22, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(35, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Zafra:"
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(885, 25)
    Me.HeaderStrip1.TabIndex = 3
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(114, 22)
    Me.ToolStripLabel1.Text = "Fermentación"
    '
    'rdoDetallado
    '
    Me.rdoDetallado.AutoSize = True
    Me.rdoDetallado.Checked = True
    Me.rdoDetallado.Location = New System.Drawing.Point(73, 41)
    Me.rdoDetallado.Name = "rdoDetallado"
    Me.rdoDetallado.Size = New System.Drawing.Size(70, 17)
    Me.rdoDetallado.TabIndex = 8
    Me.rdoDetallado.TabStop = True
    Me.rdoDetallado.Text = "Detallado"
    Me.rdoDetallado.UseVisualStyleBackColor = True
    '
    'RadioButton1
    '
    Me.RadioButton1.AutoSize = True
    Me.RadioButton1.Location = New System.Drawing.Point(73, 64)
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.Size = New System.Drawing.Size(72, 17)
    Me.RadioButton1.TabIndex = 8
    Me.RadioButton1.Text = "Resumido"
    Me.RadioButton1.UseVisualStyleBackColor = True
    '
    'FrmFermentacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(885, 699)
    Me.Controls.Add(Me.PnlCuerpo)
    Me.Name = "FrmFermentacion"
    Me.Text = "Fermentación"

    Me.PnlCuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PnlCuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaBloqueFermentacion1 As CtlBuscaBloqueFermentacion
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents CtlBloque1 As CtlBloque
  Friend WithEvents crvsaldocujes As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents dtcortadoensal As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkcortadoensal As System.Windows.Forms.CheckBox
  Friend WithEvents btnmostrarsaldo As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDetallado As System.Windows.Forms.RadioButton
End Class
