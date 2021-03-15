<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEmergTresFaltas
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
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.chkcontratoactivo = New System.Windows.Forms.CheckBox
    Me.cbomes = New System.Windows.Forms.ComboBox
    Me.numanio = New System.Windows.Forms.NumericUpDown
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.lvneg = New System.Windows.Forms.ListView
    Me.clmcodigo = New System.Windows.Forms.ColumnHeader
    Me.clmnombres = New System.Windows.Forms.ColumnHeader
    Me.clmcedula = New System.Windows.Forms.ColumnHeader
    Me.clmfaltas = New System.Windows.Forms.ColumnHeader
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.crvlisfaltames = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.HeaderStrip2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.numanio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
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
    Me.HeaderStrip2.Size = New System.Drawing.Size(475, 19)
    Me.HeaderStrip2.TabIndex = 3
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(106, 16)
    Me.ToolStripLabel2.Text = "Tres faltas en el mes"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chkcontratoactivo)
    Me.Panel1.Controls.Add(Me.cbomes)
    Me.Panel1.Controls.Add(Me.numanio)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 19)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(475, 58)
    Me.Panel1.TabIndex = 10
    '
    'chkcontratoactivo
    '
    Me.chkcontratoactivo.AutoSize = True
    Me.chkcontratoactivo.Checked = True
    Me.chkcontratoactivo.CheckState = System.Windows.Forms.CheckState.Indeterminate
    Me.chkcontratoactivo.Location = New System.Drawing.Point(7, 34)
    Me.chkcontratoactivo.Name = "chkcontratoactivo"
    Me.chkcontratoactivo.Size = New System.Drawing.Size(196, 17)
    Me.chkcontratoactivo.TabIndex = 6
    Me.chkcontratoactivo.Text = "Sólo empleados con contrato activo"
    Me.chkcontratoactivo.ThreeState = True
    '
    'cbomes
    '
    Me.cbomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomes.Location = New System.Drawing.Point(130, 7)
    Me.cbomes.Name = "cbomes"
    Me.cbomes.Size = New System.Drawing.Size(105, 21)
    Me.cbomes.TabIndex = 5
    '
    'numanio
    '
    Me.numanio.Location = New System.Drawing.Point(39, 8)
    Me.numanio.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
    Me.numanio.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
    Me.numanio.Name = "numanio"
    Me.numanio.Size = New System.Drawing.Size(49, 20)
    Me.numanio.TabIndex = 3
    Me.numanio.Value = New Decimal(New Integer() {2005, 0, 0, 0})
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(94, 10)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(30, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Mes:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(4, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Año:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 77)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(475, 220)
    Me.TabControl1.TabIndex = 11
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.lvneg)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(467, 194)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Mostrar datos"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'lvneg
    '
    Me.lvneg.AllowColumnReorder = True
    Me.lvneg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmcodigo, Me.clmnombres, Me.clmcedula, Me.clmfaltas})
    Me.lvneg.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvneg.FullRowSelect = True
    Me.lvneg.Location = New System.Drawing.Point(3, 3)
    Me.lvneg.Name = "lvneg"
    Me.lvneg.Size = New System.Drawing.Size(461, 188)
    Me.lvneg.TabIndex = 8
    Me.lvneg.UseCompatibleStateImageBehavior = False
    Me.lvneg.View = System.Windows.Forms.View.Details
    '
    'clmcodigo
    '
    Me.clmcodigo.Text = "Código"
    Me.clmcodigo.Width = 55
    '
    'clmnombres
    '
    Me.clmnombres.Text = "Nombres Completos"
    Me.clmnombres.Width = 200
    '
    'clmcedula
    '
    Me.clmcedula.Text = "Cédula"
    Me.clmcedula.Width = 75
    '
    'clmfaltas
    '
    Me.clmfaltas.Text = "Faltas"
    Me.clmfaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.clmfaltas.Width = 50
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.crvlisfaltames)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(467, 194)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Imprimir"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'crvlisfaltames
    '
    Me.crvlisfaltames.ActiveViewIndex = -1
    Me.crvlisfaltames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvlisfaltames.DisplayGroupTree = False
    Me.crvlisfaltames.DisplayStatusBar = False
    Me.crvlisfaltames.DisplayToolbar = False
    Me.crvlisfaltames.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvlisfaltames.Location = New System.Drawing.Point(3, 3)
    Me.crvlisfaltames.Name = "crvlisfaltames"
    Me.crvlisfaltames.SelectionFormula = ""
    Me.crvlisfaltames.Size = New System.Drawing.Size(461, 188)
    Me.crvlisfaltames.TabIndex = 0
    Me.crvlisfaltames.ViewTimeSelectionFormula = ""
    '
    'CtlEmergTresFaltas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.HeaderStrip2)
    Me.Name = "CtlEmergTresFaltas"
    Me.Size = New System.Drawing.Size(475, 297)
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.numanio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Controles.Especiales.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents chkcontratoactivo As System.Windows.Forms.CheckBox
  Friend WithEvents cbomes As System.Windows.Forms.ComboBox
  Friend WithEvents numanio As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents lvneg As System.Windows.Forms.ListView
  Friend WithEvents clmcodigo As System.Windows.Forms.ColumnHeader
  Friend WithEvents clmnombres As System.Windows.Forms.ColumnHeader
  Friend WithEvents clmfaltas As System.Windows.Forms.ColumnHeader
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents crvlisfaltames As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents clmcedula As System.Windows.Forms.ColumnHeader

End Class
