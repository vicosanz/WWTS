<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRezago
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
    Me.pnlCuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabControl2 = New System.Windows.Forms.TabControl()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.CtlInvCajas1 = New CtlInvCajas()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.CtlListaEmbarque1 = New CtlListaEmbarque()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.btnanadiraemb = New System.Windows.Forms.Button()
    Me.btnremoverdeemb = New System.Windows.Forms.Button()
    Me.CtlBuscaCajasRezago1 = New CtlBuscaCajasRezago()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.crvlistaempaque = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.CtlHacienda1 = New CtlHacienda()
    Me.CtlZafra1 = New CtlZafra()
    Me.chkzafra = New System.Windows.Forms.CheckBox()
    Me.chkponersigla = New System.Windows.Forms.CheckBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.numdesde = New System.Windows.Forms.NumericUpDown()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.numhasta = New System.Windows.Forms.NumericUpDown()
    Me.btnimpretiqplancha = New System.Windows.Forms.Button()
    Me.btnmostraretiq = New System.Windows.Forms.Button()
    Me.btnlistaempaque = New System.Windows.Forms.Button()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlCuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabControl2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.Panel2.SuspendLayout()
    CType(Me.numdesde, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numhasta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlCuerpo
    '
    Me.pnlCuerpo.Controls.Add(Me.TabControl1)
    Me.pnlCuerpo.Controls.Add(Me.HeaderStrip1)
    Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlCuerpo.Location = New System.Drawing.Point(0, 0)
    Me.pnlCuerpo.Name = "pnlCuerpo"
    Me.pnlCuerpo.Size = New System.Drawing.Size(784, 386)
    Me.pnlCuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(784, 361)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TabControl2)
    Me.TabPage1.Controls.Add(Me.CtlBuscaCajasRezago1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(776, 335)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Cajas"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabControl2
    '
    Me.TabControl2.Controls.Add(Me.TabPage3)
    Me.TabControl2.Controls.Add(Me.TabPage4)
    Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl2.Location = New System.Drawing.Point(173, 3)
    Me.TabControl2.Name = "TabControl2"
    Me.TabControl2.SelectedIndex = 0
    Me.TabControl2.Size = New System.Drawing.Size(600, 329)
    Me.TabControl2.TabIndex = 1
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.CtlInvCajas1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(592, 303)
    Me.TabPage3.TabIndex = 0
    Me.TabPage3.Text = "Registro de cajas"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'CtlInvCajas1
    '
    Me.CtlInvCajas1.BackColor = System.Drawing.Color.Transparent
    Me.CtlInvCajas1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlInvCajas1.Invcaja = Nothing
    Me.CtlInvCajas1.Location = New System.Drawing.Point(3, 3)
    Me.CtlInvCajas1.Name = "CtlInvCajas1"
    Me.CtlInvCajas1.op = Nothing
    Me.CtlInvCajas1.Size = New System.Drawing.Size(586, 297)
    Me.CtlInvCajas1.TabIndex = 0
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.CtlListaEmbarque1)
    Me.TabPage4.Controls.Add(Me.Panel3)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(592, 303)
    Me.TabPage4.TabIndex = 1
    Me.TabPage4.Text = "Listas de embarques"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'CtlListaEmbarque1
    '
    Me.CtlListaEmbarque1.BackColor = System.Drawing.Color.Transparent
    Me.CtlListaEmbarque1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlListaEmbarque1.Embarque = Nothing
    Me.CtlListaEmbarque1.Location = New System.Drawing.Point(3, 35)
    Me.CtlListaEmbarque1.Name = "CtlListaEmbarque1"
    Me.CtlListaEmbarque1.Op = Nothing
    Me.CtlListaEmbarque1.Size = New System.Drawing.Size(586, 265)
    Me.CtlListaEmbarque1.TabIndex = 3
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.btnanadiraemb)
    Me.Panel3.Controls.Add(Me.btnremoverdeemb)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(3, 3)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(586, 32)
    Me.Panel3.TabIndex = 2
    '
    'btnanadiraemb
    '
    Me.btnanadiraemb.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnanadiraemb.Location = New System.Drawing.Point(3, 3)
    Me.btnanadiraemb.Name = "btnanadiraemb"
    Me.btnanadiraemb.Size = New System.Drawing.Size(104, 23)
    Me.btnanadiraemb.TabIndex = 0
    Me.btnanadiraemb.Text = "Añadir "
    '
    'btnremoverdeemb
    '
    Me.btnremoverdeemb.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnremoverdeemb.Location = New System.Drawing.Point(119, 3)
    Me.btnremoverdeemb.Name = "btnremoverdeemb"
    Me.btnremoverdeemb.Size = New System.Drawing.Size(104, 23)
    Me.btnremoverdeemb.TabIndex = 0
    Me.btnremoverdeemb.Text = "&Remover"
    '
    'CtlBuscaCajasRezago1
    '
    Me.CtlBuscaCajasRezago1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaCajasRezago1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaCajasRezago1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaCajasRezago1.Name = "CtlBuscaCajasRezago1"
    Me.CtlBuscaCajasRezago1.Op = Nothing
    Me.CtlBuscaCajasRezago1.Size = New System.Drawing.Size(170, 329)
    Me.CtlBuscaCajasRezago1.TabIndex = 0
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.crvlistaempaque)
    Me.TabPage2.Controls.Add(Me.Panel2)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(776, 335)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Etiquetas"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'crvlistaempaque
    '
    Me.crvlistaempaque.ActiveViewIndex = -1
    Me.crvlistaempaque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvlistaempaque.CachedPageNumberPerDoc = 10
    Me.crvlistaempaque.DisplayStatusBar = False
    Me.crvlistaempaque.DisplayToolbar = False
    Me.crvlistaempaque.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvlistaempaque.Location = New System.Drawing.Point(3, 119)
    Me.crvlistaempaque.Name = "crvlistaempaque"
    Me.crvlistaempaque.SelectionFormula = ""
    Me.crvlistaempaque.Size = New System.Drawing.Size(770, 213)
    Me.crvlistaempaque.TabIndex = 2
    Me.crvlistaempaque.ViewTimeSelectionFormula = ""
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.Info
    Me.Panel2.Controls.Add(Me.CtlHacienda1)
    Me.Panel2.Controls.Add(Me.CtlZafra1)
    Me.Panel2.Controls.Add(Me.chkzafra)
    Me.Panel2.Controls.Add(Me.chkponersigla)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.numdesde)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.numhasta)
    Me.Panel2.Controls.Add(Me.btnimpretiqplancha)
    Me.Panel2.Controls.Add(Me.btnmostraretiq)
    Me.Panel2.Controls.Add(Me.btnlistaempaque)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(3, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(770, 116)
    Me.Panel2.TabIndex = 1
    '
    'CtlHacienda1
    '
    Me.CtlHacienda1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlHacienda1.FormattingEnabled = True
    Me.CtlHacienda1.Hacienda = Nothing
    Me.CtlHacienda1.Location = New System.Drawing.Point(85, 62)
    Me.CtlHacienda1.Name = "CtlHacienda1"
    Me.CtlHacienda1.Op = Nothing
    Me.CtlHacienda1.PuedeActualizar = True
    Me.CtlHacienda1.PuedeEliminar = True
    Me.CtlHacienda1.PuedeModificar = True
    Me.CtlHacienda1.PuedeNuevo = True
    Me.CtlHacienda1.Size = New System.Drawing.Size(121, 21)
    Me.CtlHacienda1.TabIndex = 7
    '
    'CtlZafra1
    '
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(85, 8)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(121, 21)
    Me.CtlZafra1.TabIndex = 1
    Me.CtlZafra1.Zafra = Nothing
    '
    'chkzafra
    '
    Me.chkzafra.AutoSize = True
    Me.chkzafra.Location = New System.Drawing.Point(11, 10)
    Me.chkzafra.Name = "chkzafra"
    Me.chkzafra.Size = New System.Drawing.Size(51, 17)
    Me.chkzafra.TabIndex = 0
    Me.chkzafra.Text = "Zafra"
    '
    'chkponersigla
    '
    Me.chkponersigla.AutoSize = True
    Me.chkponersigla.Location = New System.Drawing.Point(11, 64)
    Me.chkponersigla.Name = "chkponersigla"
    Me.chkponersigla.Size = New System.Drawing.Size(72, 17)
    Me.chkponersigla.TabIndex = 6
    Me.chkponersigla.Text = "Hacienda"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(177, 38)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(38, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Hasta:"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'numdesde
    '
    Me.numdesde.Location = New System.Drawing.Point(85, 36)
    Me.numdesde.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
    Me.numdesde.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numdesde.Name = "numdesde"
    Me.numdesde.Size = New System.Drawing.Size(76, 20)
    Me.numdesde.TabIndex = 3
    Me.numdesde.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(8, 36)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(41, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Desde:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'numhasta
    '
    Me.numhasta.Location = New System.Drawing.Point(237, 36)
    Me.numhasta.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
    Me.numhasta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numhasta.Name = "numhasta"
    Me.numhasta.Size = New System.Drawing.Size(76, 20)
    Me.numhasta.TabIndex = 5
    Me.numhasta.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'btnimpretiqplancha
    '
    Me.btnimpretiqplancha.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnimpretiqplancha.Location = New System.Drawing.Point(356, 77)
    Me.btnimpretiqplancha.Name = "btnimpretiqplancha"
    Me.btnimpretiqplancha.Size = New System.Drawing.Size(168, 23)
    Me.btnimpretiqplancha.TabIndex = 10
    Me.btnimpretiqplancha.Text = "&Imprimir etiquetas Plancha"
    '
    'btnmostraretiq
    '
    Me.btnmostraretiq.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostraretiq.Location = New System.Drawing.Point(356, 40)
    Me.btnmostraretiq.Name = "btnmostraretiq"
    Me.btnmostraretiq.Size = New System.Drawing.Size(168, 23)
    Me.btnmostraretiq.TabIndex = 9
    Me.btnmostraretiq.Text = "&Imprimir etiquetas Word"
    '
    'btnlistaempaque
    '
    Me.btnlistaempaque.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnlistaempaque.Location = New System.Drawing.Point(356, 8)
    Me.btnlistaempaque.Name = "btnlistaempaque"
    Me.btnlistaempaque.Size = New System.Drawing.Size(108, 23)
    Me.btnlistaempaque.TabIndex = 8
    Me.btnlistaempaque.Text = "&Lista de empaque"
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(784, 25)
    Me.HeaderStrip1.TabIndex = 3
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 22)
    Me.ToolStripLabel1.Text = "Rezago"
    '
    'FrmRezago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(784, 386)
    Me.Controls.Add(Me.pnlCuerpo)
    Me.Name = "FrmRezago"
    Me.Text = "Rezago"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlCuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabControl2.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage4.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    CType(Me.numdesde, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numhasta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents CtlInvCajas1 As CtlInvCajas
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaCajasRezago1 As CtlBuscaCajasRezago
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents crvlistaempaque As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents CtlHacienda1 As CtlHacienda
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents chkponersigla As System.Windows.Forms.CheckBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents numdesde As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents numhasta As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnmostraretiq As System.Windows.Forms.Button
  Friend WithEvents btnlistaempaque As System.Windows.Forms.Button
  Friend WithEvents CtlListaEmbarque1 As CtlListaEmbarque
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents btnanadiraemb As System.Windows.Forms.Button
  Friend WithEvents btnremoverdeemb As System.Windows.Forms.Button
  Friend WithEvents btnimpretiqplancha As System.Windows.Forms.Button
  Friend WithEvents chkzafra As System.Windows.Forms.CheckBox
End Class
