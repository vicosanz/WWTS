<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheque
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblmensaje = New System.Windows.Forms.Label
    Me.cbotipopago = New WWTS.General.Controles.ComboBoxParametroDet
    Me.chkmostrarprov = New System.Windows.Forms.CheckBox
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 63)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Código:"
    '
    'txtobservacion
    '
    Me.txtobservacion.Location = New System.Drawing.Point(96, 87)
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.Size = New System.Drawing.Size(290, 20)
    Me.txtobservacion.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 90)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Descripción:"
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(394, 48)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cbotipopago
    '
    Me.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipopago.FormattingEnabled = True
    Me.cbotipopago.Location = New System.Drawing.Point(96, 60)
    Me.cbotipopago.Name = "cbotipopago"
    Me.cbotipopago.Size = New System.Drawing.Size(168, 21)
    Me.cbotipopago.TabIndex = 2
    '
    'chkmostrarprov
    '
    Me.chkmostrarprov.AutoSize = True
    Me.chkmostrarprov.Location = New System.Drawing.Point(96, 120)
    Me.chkmostrarprov.Name = "chkmostrarprov"
    Me.chkmostrarprov.Size = New System.Drawing.Size(132, 17)
    Me.chkmostrarprov.TabIndex = 5
    Me.chkmostrarprov.Text = "Mostrar en provisiones"
    Me.chkmostrarprov.UseVisualStyleBackColor = True
    '
    'FrmCheque
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(394, 187)
    Me.Controls.Add(Me.chkmostrarprov)
    Me.Controls.Add(Me.cbotipopago)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtobservacion)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmCheque"
    Me.Text = "Cheques"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtobservacion, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.cbotipopago, 0)
    Me.Controls.SetChildIndex(Me.chkmostrarprov, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents cbotipopago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chkmostrarprov As System.Windows.Forms.CheckBox

End Class
