<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaEmpleado
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
    Me.components = New System.ComponentModel.Container()
    Me.EntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.btn_Item = New Infoware.Controles.Base.ButtonStd()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.btnadd = New Infoware.Controles.Base.ButtonStd()
    CType(Me.EntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'EntidadBindingSource
    '
    Me.EntidadBindingSource.DataSource = GetType(WWTS.General.Reglas.Entidad)
    '
    'btn_Item
    '
    Me.btn_Item.ContextMenuStrip = Me.ContextMenuStrip1
    Me.btn_Item.Location = New System.Drawing.Point(0, -1)
    Me.btn_Item.Name = "btn_Item"
    Me.btn_Item.Size = New System.Drawing.Size(120, 23)
    Me.btn_Item.TabIndex = 0
    Me.btn_Item.TabStop = False
    Me.btn_Item.Text = "Empleado"
    Me.btn_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btn_Item.UseVisualStyleBackColor = True
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem, Me.BuscarToolStripMenuItem})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 48)
    '
    'QuitarToolStripMenuItem
    '
    Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
    Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
    Me.QuitarToolStripMenuItem.Text = "&Quitar"
    '
    'BuscarToolStripMenuItem
    '
    Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
    Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
    Me.BuscarToolStripMenuItem.Text = "Buscar"
    '
    'ComboBox1
    '
    Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(124, 0)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(190, 21)
    Me.ComboBox1.TabIndex = 2
    '
    'btnadd
    '
    Me.btnadd.Location = New System.Drawing.Point(96, -1)
    Me.btnadd.Name = "btnadd"
    Me.btnadd.Size = New System.Drawing.Size(26, 23)
    Me.btnadd.TabIndex = 3
    Me.btnadd.TabStop = False
    Me.btnadd.Text = "+"
    Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnadd.UseVisualStyleBackColor = True
    '
    'CtlBuscaEmpleado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.btnadd)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.btn_Item)
    Me.Name = "CtlBuscaEmpleado"
    Me.Size = New System.Drawing.Size(314, 22)
    CType(Me.EntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents EntidadBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents btn_Item As Infoware.Controles.Base.ButtonStd
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents btnadd As Infoware.Controles.Base.ButtonStd

End Class
