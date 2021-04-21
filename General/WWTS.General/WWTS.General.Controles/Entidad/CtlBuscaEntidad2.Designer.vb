<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlBuscaEntidad2
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.btn_entidad = New Infoware.Controles.Base.ButtonStd()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TextBox1 = New Infoware.Controles.Base.TextBoxStd()
    Me.EntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.ContextMenuStrip1.SuspendLayout()
    CType(Me.EntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn_entidad
    '
    Me.btn_entidad.ContextMenuStrip = Me.ContextMenuStrip1
    Me.btn_entidad.Location = New System.Drawing.Point(0, -1)
    Me.btn_entidad.Margin = New System.Windows.Forms.Padding(4)
    Me.btn_entidad.Name = "btn_entidad"
    Me.btn_entidad.Size = New System.Drawing.Size(160, 23)
    Me.btn_entidad.TabIndex = 0
    Me.btn_entidad.TabStop = False
    Me.btn_entidad.Text = "Entidad"
    Me.btn_entidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btn_entidad.UseVisualStyleBackColor = True
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem, Me.EditarToolStripMenuItem1, Me.BuscarToolStripMenuItem})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 82)
    '
    'QuitarToolStripMenuItem
    '
    Me.QuitarToolStripMenuItem.Image = Global.WWTS.General.Controles.My.Resources.Resources.eliminar
    Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
    Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
    Me.QuitarToolStripMenuItem.Text = "&Quitar"
    '
    'EditarToolStripMenuItem1
    '
    Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
    Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(125, 26)
    Me.EditarToolStripMenuItem1.Text = "&Editar"
    '
    'BuscarToolStripMenuItem
    '
    Me.BuscarToolStripMenuItem.Image = Global.WWTS.General.Controles.My.Resources.Resources.find
    Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
    Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
    Me.BuscarToolStripMenuItem.Text = "Buscar"
    '
    'TextBox1
    '
    Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
    Me.TextBox1.Location = New System.Drawing.Point(165, 1)
    Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
    Me.TextBox1.Mensaje = ""
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBox1.PromptText = ""
    Me.TextBox1.ReadOnly = True
    Me.TextBox1.Size = New System.Drawing.Size(319, 22)
    Me.TextBox1.TabIndex = 1
    '
    'EntidadBindingSource
    '
    Me.EntidadBindingSource.DataSource = GetType(WWTS.General.Reglas.Entidad)
    '
    'CtlBuscaEntidad2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.btn_entidad)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "CtlBuscaEntidad2"
    Me.Size = New System.Drawing.Size(488, 27)
    Me.ContextMenuStrip1.ResumeLayout(False)
    CType(Me.EntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents EntidadBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents btn_entidad As Infoware.Controles.Base.ButtonStd
  Friend WithEvents TextBox1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
