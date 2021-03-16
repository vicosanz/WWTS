<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlPeriodoVacacion
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.HeaderStrip5 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnnuevovacacion = New System.Windows.Forms.ToolStripButton()
    Me.btnabrirvacacion = New System.Windows.Forms.ToolStripButton()
    Me.btneliminarvacacion = New System.Windows.Forms.ToolStripButton()
    Me.DataGridView6 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSperiodo = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn198 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.HeaderStrip5.SuspendLayout()
    CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSperiodo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'HeaderStrip5
    '
    Me.HeaderStrip5.AutoSize = False
    Me.HeaderStrip5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip5.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip5.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.ToolStripSeparator5, Me.btnnuevovacacion, Me.btnabrirvacacion, Me.btneliminarvacacion})
    Me.HeaderStrip5.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip5.Name = "HeaderStrip5"
    Me.HeaderStrip5.Size = New System.Drawing.Size(520, 21)
    Me.HeaderStrip5.TabIndex = 1
    Me.HeaderStrip5.Text = "HeaderStrip5"
    '
    'ToolStripLabel4
    '
    Me.ToolStripLabel4.Name = "ToolStripLabel4"
    Me.ToolStripLabel4.Size = New System.Drawing.Size(99, 18)
    Me.ToolStripLabel4.Text = "Periodo Vacación"
    '
    'ToolStripSeparator5
    '
    Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 21)
    '
    'btnnuevovacacion
    '
    Me.btnnuevovacacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevovacacion.Image = My.Resources.Resources._new
    Me.btnnuevovacacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevovacacion.Name = "btnnuevovacacion"
    Me.btnnuevovacacion.Size = New System.Drawing.Size(23, 18)
    Me.btnnuevovacacion.Text = "Nuevo"
    '
    'btnabrirvacacion
    '
    Me.btnabrirvacacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnabrirvacacion.Image = My.Resources.Resources.open
    Me.btnabrirvacacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnabrirvacacion.Name = "btnabrirvacacion"
    Me.btnabrirvacacion.Size = New System.Drawing.Size(23, 18)
    Me.btnabrirvacacion.Text = "Abrir"
    '
    'btneliminarvacacion
    '
    Me.btneliminarvacacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminarvacacion.Image = My.Resources.Resources.eliminar
    Me.btneliminarvacacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminarvacacion.Name = "btneliminarvacacion"
    Me.btneliminarvacacion.Size = New System.Drawing.Size(23, 18)
    Me.btneliminarvacacion.Text = "Eliminar"
    '
    'DataGridView6
    '
    Me.DataGridView6.AgruparRepetidos = False
    Me.DataGridView6.AllowUserToAddRows = False
    Me.DataGridView6.AutoGenerateColumns = False
    Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
    Me.DataGridView6.DataSource = Me.BSperiodo
    Me.DataGridView6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView6.Location = New System.Drawing.Point(0, 21)
    Me.DataGridView6.Name = "DataGridView6"
    Me.DataGridView6.Size = New System.Drawing.Size(520, 149)
    Me.DataGridView6.TabIndex = 2
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn198
    '
    Me.DataGridViewTextBoxColumn198.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn198.Name = "DataGridViewTextBoxColumn198"
    '
    'CtlPeriodoVacacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.DataGridView6)
    Me.Controls.Add(Me.HeaderStrip5)
    Me.Name = "CtlPeriodoVacacion"
    Me.Size = New System.Drawing.Size(520, 170)
    Me.HeaderStrip5.ResumeLayout(False)
    Me.HeaderStrip5.PerformLayout()
    CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSperiodo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents HeaderStrip5 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnnuevovacacion As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnabrirvacacion As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminarvacacion As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridView6 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn198 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSperiodo As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
