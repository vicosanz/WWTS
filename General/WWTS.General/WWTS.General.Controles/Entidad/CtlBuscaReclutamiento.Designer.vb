<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaReclutamiento
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
    Me.btn_entidad = New Infoware.Controles.Base.ButtonStd()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TextBox1 = New Infoware.Controles.Base.TextBoxStd()
    Me.btnadd = New Infoware.Controles.Base.ButtonStd()
    CType(Me.EntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'EntidadBindingSource
    '
    Me.EntidadBindingSource.DataSource = GetType(WWTS.General.Reglas.Entidad)
    '
    'btn_entidad
    '
    Me.btn_entidad.ContextMenuStrip = Me.ContextMenuStrip1
    Me.btn_entidad.Location = New System.Drawing.Point(0, 0)
    Me.btn_entidad.Name = "btn_entidad"
    Me.btn_entidad.Size = New System.Drawing.Size(120, 23)
    Me.btn_entidad.TabIndex = 0
    Me.btn_entidad.TabStop = False
    Me.btn_entidad.Text = "Entidad"
    Me.btn_entidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btn_entidad.UseVisualStyleBackColor = True
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem, Me.BuscarToolStripMenuItem})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 48)
    '
    'QuitarToolStripMenuItem
    '
    Me.QuitarToolStripMenuItem.Image = Global.WWTS.General.Controles.My.Resources.Resources.eliminar
    Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
    Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
    Me.QuitarToolStripMenuItem.Text = "&Quitar"
    '
    'BuscarToolStripMenuItem
    '
    Me.BuscarToolStripMenuItem.Image = Global.WWTS.General.Controles.My.Resources.Resources.find
    Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
    Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
    Me.BuscarToolStripMenuItem.Text = "Buscar"
    '
    'TextBox1
    '
    Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
    Me.TextBox1.Location = New System.Drawing.Point(124, 1)
    Me.TextBox1.Mensaje = ""
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBox1.PromptText = ""
    Me.TextBox1.ReadOnly = True
    Me.TextBox1.Size = New System.Drawing.Size(189, 20)
    Me.TextBox1.TabIndex = 1
    '
    'btnadd
    '
    Me.btnadd.Location = New System.Drawing.Point(96, 0)
    Me.btnadd.Name = "btnadd"
    Me.btnadd.Size = New System.Drawing.Size(26, 23)
    Me.btnadd.TabIndex = 2
    Me.btnadd.TabStop = False
    Me.btnadd.Text = "+"
    Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnadd.UseVisualStyleBackColor = True
    '
    'CtlBuscaReclutamiento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.btnadd)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.btn_entidad)
    Me.Name = "CtlBuscaReclutamiento"
    Me.Size = New System.Drawing.Size(314, 23)
    CType(Me.EntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents EntidadBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents btn_entidad As Infoware.Controles.Base.ButtonStd
  Friend WithEvents TextBox1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnadd As Infoware.Controles.Base.ButtonStd

End Class
