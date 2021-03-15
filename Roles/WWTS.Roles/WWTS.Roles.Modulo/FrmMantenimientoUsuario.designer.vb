Imports WWTS.General.Controles

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoUsuario
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
    Me.components = New System.ComponentModel.Container
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.BindingSourceEmpresas = New System.Windows.Forms.BindingSource(Me.components)
    Me.BindingSourcePatronos = New System.Windows.Forms.BindingSource(Me.components)
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.DGPatronos = New System.Windows.Forms.DataGridView
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    CType(Me.BindingSourceEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSourcePatronos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.DGPatronos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Panel1.Size = New System.Drawing.Size(602, 472)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.txtcodigo)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(5, 4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(592, 59)
    Me.Panel2.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(7, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(133, 6)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 34)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(133, 31)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(296, 20)
    Me.txtdescripcion.TabIndex = 3
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.DGPatronos)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(5, 63)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(592, 405)
    Me.GroupBox2.TabIndex = 4
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Patronos"
    '
    'DGSalas
    '
    Me.DGPatronos.AllowUserToAddRows = False
    Me.DGPatronos.AllowUserToDeleteRows = False
    Me.DGPatronos.AutoGenerateColumns = False
    Me.DGPatronos.BackgroundColor = System.Drawing.SystemColors.Window
    Me.DGPatronos.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.DGPatronos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DGPatronos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DGPatronos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DGPatronos.DataSource = Me.BindingSourcePatronos
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DGPatronos.DefaultCellStyle = DataGridViewCellStyle2
    Me.DGPatronos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DGPatronos.Location = New System.Drawing.Point(3, 16)
    Me.DGPatronos.MultiSelect = False
    Me.DGPatronos.Name = "DGSalas"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DGPatronos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DGPatronos.RowTemplate.Height = 25
    Me.DGPatronos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.DGPatronos.Size = New System.Drawing.Size(586, 386)
    Me.DGPatronos.StandardTab = True
    Me.DGPatronos.TabIndex = 3
    '
    'FrmMantenimientoUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(602, 521)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoUsuario"
    Me.PuedeGuardaryCerrar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    CType(Me.BindingSourceEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSourcePatronos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    CType(Me.DGPatronos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents BindingSourceEmpresas As System.Windows.Forms.BindingSource
  Friend WithEvents BindingSourcePatronos As System.Windows.Forms.BindingSource
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Private WithEvents DGPatronos As System.Windows.Forms.DataGridView

End Class
