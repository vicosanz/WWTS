Imports WWTS.General.Controles

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoEmpleado
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoEmpleado))
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.CtlContrato1 = New CtlContratoFichasMedicas()
    Me.CtlBuscaEmpleados1 = New WWTS.Roles.Controles.CtlBuscaEmpleados()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStriptitulo = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
    Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
    Me.ListadoEmpleadoDiscapacidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.MenuStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.CtlContrato1)
    Me.Pnlcuerpo.Controls.Add(Me.CtlBuscaEmpleados1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 82)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(4)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(1097, 743)
    Me.Pnlcuerpo.TabIndex = 4
    '
    'CtlContrato1
    '
    Me.CtlContrato1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlContrato1.Empleado = Nothing
    Me.CtlContrato1.Location = New System.Drawing.Point(264, 32)
    Me.CtlContrato1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlContrato1.ModoenSeleccion = False
    Me.CtlContrato1.Name = "CtlContrato1"
    Me.CtlContrato1.Op = Nothing
    Me.CtlContrato1.Selecc_Codigo = 0
    Me.CtlContrato1.Size = New System.Drawing.Size(833, 711)
    Me.CtlContrato1.TabIndex = 4
    Me.CtlContrato1.Usuario = Nothing
    '
    'CtlBuscaEmpleados1
    '
    Me.CtlBuscaEmpleados1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaEmpleados1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaEmpleados1.Empleado = Nothing
    Me.CtlBuscaEmpleados1.Location = New System.Drawing.Point(0, 32)
    Me.CtlBuscaEmpleados1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlBuscaEmpleados1.Name = "CtlBuscaEmpleados1"
    Me.CtlBuscaEmpleados1.Op = Nothing
    Me.CtlBuscaEmpleados1.Patrono = Nothing
    Me.CtlBuscaEmpleados1.Size = New System.Drawing.Size(264, 711)
    Me.CtlBuscaEmpleados1.TabIndex = 2
    Me.CtlBuscaEmpleados1.Usuario = Nothing
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptitulo})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(1097, 32)
    Me.HeaderStrip1.TabIndex = 5
    Me.HeaderStrip1.TabStop = True
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStriptitulo
    '
    Me.ToolStriptitulo.Name = "ToolStriptitulo"
    Me.ToolStriptitulo.Size = New System.Drawing.Size(209, 29)
    Me.ToolStriptitulo.Text = "Lista de empleados"
    '
    'ToolStrip2
    '
    Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 57)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(1097, 25)
    Me.ToolStrip2.TabIndex = 5
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'MenuStrip2
    '
    Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
    Me.MenuStrip2.Location = New System.Drawing.Point(0, 91)
    Me.MenuStrip2.Name = "MenuStrip2"
    Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
    Me.MenuStrip2.Size = New System.Drawing.Size(1033, 33)
    Me.MenuStrip2.TabIndex = 6
    Me.MenuStrip2.Text = "MenuStrip2"
    Me.MenuStrip2.Visible = False
    '
    'btnReporte
    '
    Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoEmpleadoDiscapacidadToolStripMenuItem})
    Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
    Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReporte.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnReporte.MergeIndex = 5
    Me.btnReporte.Name = "btnReporte"
    Me.btnReporte.Size = New System.Drawing.Size(102, 26)
    Me.btnReporte.Text = "Reportes"
    '
    'ListadoEmpleadoDiscapacidadToolStripMenuItem
    '
    Me.ListadoEmpleadoDiscapacidadToolStripMenuItem.Name = "ListadoEmpleadoDiscapacidadToolStripMenuItem"
    Me.ListadoEmpleadoDiscapacidadToolStripMenuItem.Size = New System.Drawing.Size(389, 26)
    Me.ListadoEmpleadoDiscapacidadToolStripMenuItem.Text = "Listado de empleados con discapacidad física"
    '
    'FrmMantenimientoEmpleado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.ClientSize = New System.Drawing.Size(1097, 825)
    Me.Controls.Add(Me.MenuStrip2)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5)
    Me.Name = "FrmMantenimientoEmpleado"
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
    Me.Controls.SetChildIndex(Me.Pnlcuerpo, 0)
    Me.Controls.SetChildIndex(Me.MenuStrip2, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.MenuStrip2.ResumeLayout(False)
    Me.MenuStrip2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaEmpleados1 As WWTS.Roles.Controles.CtlBuscaEmpleados
  Friend WithEvents CtlContrato1 As CtlContratoFichasMedicas
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStriptitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
  Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents ListadoEmpleadoDiscapacidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
