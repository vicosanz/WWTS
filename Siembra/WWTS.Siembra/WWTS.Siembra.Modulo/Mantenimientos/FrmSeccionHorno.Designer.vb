<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeccionHorno
  Inherits Infoware.Consola.Base.FrmDialogoBase

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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblmensaje = New System.Windows.Forms.Label()
    Me.pnlnuevo = New System.Windows.Forms.Panel()
    Me.txthasta = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chkhasta = New System.Windows.Forms.CheckBox()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlnuevo.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Código:"
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 49)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(273, 24)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlnuevo
    '
    Me.pnlnuevo.Controls.Add(Me.txthasta)
    Me.pnlnuevo.Controls.Add(Me.chkhasta)
    Me.pnlnuevo.Location = New System.Drawing.Point(0, 50)
    Me.pnlnuevo.Name = "pnlnuevo"
    Me.pnlnuevo.Size = New System.Drawing.Size(273, 38)
    Me.pnlnuevo.TabIndex = 3
    '
    'txthasta
    '
    Me.txthasta.Location = New System.Drawing.Point(89, 5)
    Me.txthasta.Mensaje = ""
    Me.txthasta.Name = "txthasta"
    Me.txthasta.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txthasta.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txthasta.PromptText = ""
    Me.txthasta.Size = New System.Drawing.Size(75, 20)
    Me.txthasta.TabIndex = 1
    Me.txthasta.Text = "0"
    Me.txthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthasta.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txthasta.Value = 0.0R
    '
    'chkhasta
    '
    Me.chkhasta.AutoSize = True
    Me.chkhasta.Location = New System.Drawing.Point(15, 7)
    Me.chkhasta.Name = "chkhasta"
    Me.chkhasta.Size = New System.Drawing.Size(52, 17)
    Me.chkhasta.TabIndex = 0
    Me.chkhasta.Text = "hasta"
    Me.chkhasta.UseVisualStyleBackColor = True
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(89, 31)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(75, 20)
    Me.txtcodigo.TabIndex = 2
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcodigo.Value = 0.0R
    '
    'FrmSeccionHorno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 164)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.pnlnuevo)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmSeccionHorno"
    Me.Text = "Sección Horno"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.pnlnuevo, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlnuevo.ResumeLayout(False)
    Me.pnlnuevo.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents pnlnuevo As System.Windows.Forms.Panel
  Friend WithEvents txthasta As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents chkhasta As System.Windows.Forms.CheckBox
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator

End Class
