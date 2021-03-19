<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuarto
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
    Me.txtdescripcion = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtcodigo = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblmensaje = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtarea = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txttemperatura = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chkCaliente = New System.Windows.Forms.CheckBox()

    Me.SuspendLayout()
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(104, 62)
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(216, 20)
    Me.txtdescripcion.TabIndex = 4
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label4.Location = New System.Drawing.Point(12, 65)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(66, 13)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Descripción:"
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(104, 36)
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(76, 20)
    Me.txtcodigo.TabIndex = 2
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label3.Location = New System.Drawing.Point(12, 117)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(70, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Temperatura:"
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(332, 24)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label1.Location = New System.Drawing.Point(12, 39)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Código:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.Label2.Location = New System.Drawing.Point(12, 91)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(82, 13)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Area del cuarto:"
    '
    'txtarea
    '
    Me.txtarea.Location = New System.Drawing.Point(104, 88)
    Me.txtarea.Mensaje = ""
    Me.txtarea.Name = "txtarea"
    Me.txtarea.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtarea.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtarea.PromptText = ""
    Me.txtarea.Size = New System.Drawing.Size(100, 20)
    Me.txtarea.TabIndex = 6
    Me.txtarea.Text = "0"
    Me.txtarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtarea.Value = 0.0R
    '
    'txttemperatura
    '
    Me.txttemperatura.Location = New System.Drawing.Point(104, 114)
    Me.txttemperatura.Mensaje = ""
    Me.txttemperatura.Name = "txttemperatura"
    Me.txttemperatura.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttemperatura.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttemperatura.PromptText = ""
    Me.txttemperatura.Size = New System.Drawing.Size(100, 20)
    Me.txttemperatura.TabIndex = 8
    Me.txttemperatura.Text = "0"
    Me.txttemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttemperatura.Value = 0.0R
    '
    'chkCaliente
    '
    Me.chkCaliente.AutoSize = True
    Me.chkCaliente.Location = New System.Drawing.Point(104, 141)
    Me.chkCaliente.Name = "chkCaliente"
    Me.chkCaliente.Size = New System.Drawing.Size(97, 17)
    Me.chkCaliente.TabIndex = 1001
    Me.chkCaliente.Text = "Cuarto caliente"
    Me.chkCaliente.UseVisualStyleBackColor = True
    '
    'FrmCuarto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(332, 210)
    Me.Controls.Add(Me.chkCaliente)
    Me.Controls.Add(Me.txttemperatura)
    Me.Controls.Add(Me.txtarea)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmCuarto"
    Me.Text = "Cuartos"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.txtarea, 0)
    Me.Controls.SetChildIndex(Me.txttemperatura, 0)
    Me.Controls.SetChildIndex(Me.chkCaliente, 0)

    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtarea As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txttemperatura As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents chkCaliente As System.Windows.Forms.CheckBox

End Class
