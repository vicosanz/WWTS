<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRubroxBeneficio
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

  'Form overrides dispose to clean up the component list.
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.ComboBoxBeneficios = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.DataGridView1)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.HeaderStrip1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(770, 517)
    Me.Panel1.TabIndex = 3
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(770, 25)
    Me.HeaderStrip1.TabIndex = 2
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
    Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.DataSource = Me.ListBindingSource
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(0, 64)
    Me.DataGridView1.MultiSelect = False
    Me.DataGridView1.Name = "DataGridView1"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.DataGridView1.RowTemplate.Height = 25
    Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.DataGridView1.Size = New System.Drawing.Size(770, 453)
    Me.DataGridView1.StandardTab = True
    Me.DataGridView1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.Panel2.Controls.Add(Me.ComboBoxBeneficios)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 25)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(770, 39)
    Me.Panel2.TabIndex = 0
    '
    'ComboBoxBeneficios
    '
    Me.ComboBoxBeneficios.AbriralEntrar = False
    Me.ComboBoxBeneficios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxBeneficios.FormattingEnabled = True
    Me.ComboBoxBeneficios.Location = New System.Drawing.Point(91, 6)
    Me.ComboBoxBeneficios.Name = "ComboBoxBeneficios"
    Me.ComboBoxBeneficios.OperadorDatos = Nothing
    Me.ComboBoxBeneficios.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxBeneficios.ParametroDet = Nothing
    Me.ComboBoxBeneficios.PuedeActualizar = True
    Me.ComboBoxBeneficios.PuedeEliminar = True
    Me.ComboBoxBeneficios.PuedeModificar = True
    Me.ComboBoxBeneficios.PuedeNuevo = True
    Me.ComboBoxBeneficios.Size = New System.Drawing.Size(198, 21)
    Me.ComboBoxBeneficios.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(7, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tipo Beneficio:"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(174, 22)
    Me.ToolStripLabel1.Text = "Rubros por beneficio"
    '
    'FrmRubroxBeneficio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(770, 566)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmRubroxBeneficio"
    Me.PuedeGuardar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.Text = "Rubros por beneficio"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxBeneficios As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
