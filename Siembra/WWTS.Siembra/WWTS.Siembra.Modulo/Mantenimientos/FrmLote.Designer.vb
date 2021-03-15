<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLote
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
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblmensaje = New System.Windows.Forms.Label
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtareat = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtareau = New Infoware.Controles.Base.TextBoxCalculator
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
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(91, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Area total terreno:"
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(273, 24)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(130, 31)
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(77, 20)
    Me.txtcodigo.TabIndex = 2
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'txtareat
    '
    Me.txtareat.Location = New System.Drawing.Point(130, 57)
    Me.txtareat.Name = "txtareat"
    Me.txtareat.Size = New System.Drawing.Size(100, 20)
    Me.txtareat.TabIndex = 4
    Me.txtareat.Text = "0"
    Me.txtareat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtareat.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 89)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(111, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Area utilizable terreno:"
    '
    'txtareau
    '
    Me.txtareau.Location = New System.Drawing.Point(130, 86)
    Me.txtareau.Name = "txtareau"
    Me.txtareau.Size = New System.Drawing.Size(100, 20)
    Me.txtareau.TabIndex = 6
    Me.txtareau.Text = "0"
    Me.txtareau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtareau.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    '
    'FrmLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 154)
    Me.Controls.Add(Me.txtareau)
    Me.Controls.Add(Me.txtareat)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmLote"
    Me.Text = "Lote"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.txtareat, 0)
    Me.Controls.SetChildIndex(Me.txtareau, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtareat As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtareau As Infoware.Controles.Base.TextBoxCalculator

End Class
