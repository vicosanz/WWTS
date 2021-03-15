<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConexion
  Inherits Infoware.Controles.General.FrmMantBase

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
    Me.txtservidor = New Infoware.Controles.Base.ComboBoxStd
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtbase = New Infoware.Controles.Base.TextBoxStd
    Me.txtusuario = New Infoware.Controles.Base.TextBoxStd
    Me.txtclave = New Infoware.Controles.Base.TextBoxStd
    Me.chkseguridadintegrada = New Infoware.Controles.Base.CheckBoxStd
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtservidor
    '
    Me.txtservidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.txtservidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
    Me.txtservidor.Location = New System.Drawing.Point(96, 11)
    Me.txtservidor.Name = "txtservidor"
    Me.txtservidor.Size = New System.Drawing.Size(166, 21)
    Me.txtservidor.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Servidor:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 40)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(78, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Base de datos:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 67)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(46, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Usuario:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 92)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(64, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "&Contraseña:"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtbase
    '
    Me.txtbase.Location = New System.Drawing.Point(96, 37)
    Me.txtbase.Mensaje = ""
    Me.txtbase.Name = "txtbase"
    Me.txtbase.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbase.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbase.PromptText = ""
    Me.txtbase.Size = New System.Drawing.Size(166, 20)
    Me.txtbase.TabIndex = 3
    Me.txtbase.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtusuario
    '
    Me.txtusuario.Location = New System.Drawing.Point(96, 63)
    Me.txtusuario.Mensaje = ""
    Me.txtusuario.Name = "txtusuario"
    Me.txtusuario.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtusuario.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtusuario.PromptText = ""
    Me.txtusuario.Size = New System.Drawing.Size(166, 20)
    Me.txtusuario.TabIndex = 5
    Me.txtusuario.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtclave
    '
    Me.txtclave.Location = New System.Drawing.Point(96, 89)
    Me.txtclave.Mensaje = ""
    Me.txtclave.Name = "txtclave"
    Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtclave.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtclave.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtclave.PromptText = ""
    Me.txtclave.Size = New System.Drawing.Size(166, 20)
    Me.txtclave.TabIndex = 7
    Me.txtclave.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtclave.UseSystemPasswordChar = True
    '
    'chkseguridadintegrada
    '
    Me.chkseguridadintegrada.AutoSize = True
    Me.chkseguridadintegrada.Location = New System.Drawing.Point(96, 115)
    Me.chkseguridadintegrada.Name = "chkseguridadintegrada"
    Me.chkseguridadintegrada.Size = New System.Drawing.Size(121, 17)
    Me.chkseguridadintegrada.TabIndex = 8
    Me.chkseguridadintegrada.Text = "Seguridad integrada"
    Me.chkseguridadintegrada.UseVisualStyleBackColor = True
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 70)
    '
    'NuevoToolStripMenuItem
    '
    Me.NuevoToolStripMenuItem.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
    Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
    Me.NuevoToolStripMenuItem.Text = "&Nuevo"
    '
    'ModificarToolStripMenuItem
    '
    Me.ModificarToolStripMenuItem.Image = My.Resources.Resources.abrir.ToBitmap
    Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
    Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
    Me.ModificarToolStripMenuItem.Text = "&Modificar"
    '
    'EliminarToolStripMenuItem
    '
    Me.EliminarToolStripMenuItem.Image = My.Resources.Resources.eliminar.ToBitmap
    Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
    Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
    Me.EliminarToolStripMenuItem.Text = "&Eliminar"
    '
    'FrmConexion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 184)
    Me.Controls.Add(Me.chkseguridadintegrada)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtclave)
    Me.Controls.Add(Me.txtusuario)
    Me.Controls.Add(Me.txtbase)
    Me.Controls.Add(Me.txtservidor)
    Me.Name = "FrmConexion"
    Me.Text = "Conexión a base de datos"
    Me.Controls.SetChildIndex(Me.txtservidor, 0)
    Me.Controls.SetChildIndex(Me.txtbase, 0)
    Me.Controls.SetChildIndex(Me.txtusuario, 0)
    Me.Controls.SetChildIndex(Me.txtclave, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.chkseguridadintegrada, 0)
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtservidor As Infoware.Controles.Base.ComboBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtbase As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtusuario As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtclave As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents chkseguridadintegrada As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
