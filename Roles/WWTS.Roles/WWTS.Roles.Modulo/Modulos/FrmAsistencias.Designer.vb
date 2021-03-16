<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsistencias
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsistencias))
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlAsistencia1 = New CtlAsistencia()
    Me.CtlBuscaEmpleadosPeriodo1 = New CtlBuscaEmpleadosMarcacion()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
    Me.ListadoTomaAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.TabControl1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(1080, 571)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1080, 546)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlAsistencia1)
    Me.TabPage1.Controls.Add(Me.CtlBuscaEmpleadosPeriodo1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(1072, 520)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Mantenimiento Registro de asistencia"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlAsistencia1
    '
    Me.CtlAsistencia1.Asistencia = Nothing
    Me.CtlAsistencia1.Contrato = Nothing
    Me.CtlAsistencia1.Desde = New Date(2014, 8, 14, 9, 11, 48, 476)
    Me.CtlAsistencia1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlAsistencia1.Empleado = Nothing
    Me.CtlAsistencia1.Enabled = False
    Me.CtlAsistencia1.Hasta = New Date(2014, 8, 14, 9, 11, 48, 472)
    Me.CtlAsistencia1.Location = New System.Drawing.Point(223, 3)
    Me.CtlAsistencia1.Name = "CtlAsistencia1"
    Me.CtlAsistencia1.Op = Nothing
    Me.CtlAsistencia1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
    Me.CtlAsistencia1.patrono = Nothing
    Me.CtlAsistencia1.Periodo = Nothing
    Me.CtlAsistencia1.Size = New System.Drawing.Size(846, 514)
    Me.CtlAsistencia1.TabIndex = 1
    Me.CtlAsistencia1.TipoContrato = Nothing
    '
    'CtlBuscaEmpleadosPeriodo1
    '
    Me.CtlBuscaEmpleadosPeriodo1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleadosPeriodo1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleadosPeriodo1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaEmpleadosPeriodo1.Name = "CtlBuscaEmpleadosPeriodo1"
    Me.CtlBuscaEmpleadosPeriodo1.Op = Nothing
    Me.CtlBuscaEmpleadosPeriodo1.Size = New System.Drawing.Size(220, 514)
    Me.CtlBuscaEmpleadosPeriodo1.TabIndex = 0
    Me.CtlBuscaEmpleadosPeriodo1.Usuario = Nothing
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(1080, 25)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(183, 22)
    Me.ToolStripLabel1.Text = "Registro de asistencia"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(780, 27)
    Me.MenuStrip1.TabIndex = 3
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'btnReporte
    '
    Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoTomaAsistenciaToolStripMenuItem})
    Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
    Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReporte.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnReporte.MergeIndex = 5
    Me.btnReporte.Name = "btnReporte"
    Me.btnReporte.Size = New System.Drawing.Size(82, 20)
    Me.btnReporte.Text = "Reportes"
    '
    'ListadoTomaAsistenciaToolStripMenuItem
    '
    Me.ListadoTomaAsistenciaToolStripMenuItem.Name = "ListadoTomaAsistenciaToolStripMenuItem"
    Me.ListadoTomaAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
    Me.ListadoTomaAsistenciaToolStripMenuItem.Text = "Listado toma asistencia"
    '
    'FrmAsistencias
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1080, 571)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Name = "FrmAsistencias"
    Me.Text = "Registro de asistencia"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaEmpleadosPeriodo1 As CtlBuscaEmpleadosMarcacion
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents CtlAsistencia1 As CtlAsistencia
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents ListadoTomaAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
