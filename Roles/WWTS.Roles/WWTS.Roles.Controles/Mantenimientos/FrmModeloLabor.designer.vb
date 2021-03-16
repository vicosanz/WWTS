<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModeloLabor
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
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.CtlDetalleModeloLabor1 = New CtlDetalleModeloLabor()
    Me.CtlDetalleModeloLabor2 = New CtlDetalleModeloLabor()
    Me.CtlDetalleModeloLabor3 = New CtlDetalleModeloLabor()
    Me.CtlDetalleModeloLabor4 = New CtlDetalleModeloLabor()
    Me.CtlDetalleModeloLabor5 = New CtlDetalleModeloLabor()
    Me.CtlDetalleModeloLabor6 = New CtlDetalleModeloLabor()
    Me.CtlDetalleModeloLabor7 = New CtlDetalleModeloLabor()
    Me.Panel2 = New System.Windows.Forms.Panel()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(96, 9)
    Me.txtcodigo.MaxLength = 3
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(60, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcodigo.Value = 0.0R
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 23)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(96, 39)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(272, 20)
    Me.txtdescripcion.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(12, 39)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 23)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'CtlDetalleModeloLabor1
    '
    Me.CtlDetalleModeloLabor1.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor1.Location = New System.Drawing.Point(15, 3)
    Me.CtlDetalleModeloLabor1.Name = "CtlDetalleModeloLabor1"
    Me.CtlDetalleModeloLabor1.op = Nothing
    Me.CtlDetalleModeloLabor1.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor1.TabIndex = 0
    '
    'CtlDetalleModeloLabor2
    '
    Me.CtlDetalleModeloLabor2.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor2.Location = New System.Drawing.Point(196, 3)
    Me.CtlDetalleModeloLabor2.Name = "CtlDetalleModeloLabor2"
    Me.CtlDetalleModeloLabor2.op = Nothing
    Me.CtlDetalleModeloLabor2.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor2.TabIndex = 1
    '
    'CtlDetalleModeloLabor3
    '
    Me.CtlDetalleModeloLabor3.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor3.Location = New System.Drawing.Point(377, 3)
    Me.CtlDetalleModeloLabor3.Name = "CtlDetalleModeloLabor3"
    Me.CtlDetalleModeloLabor3.op = Nothing
    Me.CtlDetalleModeloLabor3.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor3.TabIndex = 2
    '
    'CtlDetalleModeloLabor4
    '
    Me.CtlDetalleModeloLabor4.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor4.Location = New System.Drawing.Point(15, 151)
    Me.CtlDetalleModeloLabor4.Name = "CtlDetalleModeloLabor4"
    Me.CtlDetalleModeloLabor4.op = Nothing
    Me.CtlDetalleModeloLabor4.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor4.TabIndex = 3
    '
    'CtlDetalleModeloLabor5
    '
    Me.CtlDetalleModeloLabor5.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor5.Location = New System.Drawing.Point(196, 151)
    Me.CtlDetalleModeloLabor5.Name = "CtlDetalleModeloLabor5"
    Me.CtlDetalleModeloLabor5.op = Nothing
    Me.CtlDetalleModeloLabor5.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor5.TabIndex = 4
    '
    'CtlDetalleModeloLabor6
    '
    Me.CtlDetalleModeloLabor6.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor6.Location = New System.Drawing.Point(377, 151)
    Me.CtlDetalleModeloLabor6.Name = "CtlDetalleModeloLabor6"
    Me.CtlDetalleModeloLabor6.op = Nothing
    Me.CtlDetalleModeloLabor6.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor6.TabIndex = 5
    '
    'CtlDetalleModeloLabor7
    '
    Me.CtlDetalleModeloLabor7.DetalleModeloLabor = Nothing
    Me.CtlDetalleModeloLabor7.Location = New System.Drawing.Point(15, 299)
    Me.CtlDetalleModeloLabor7.Name = "CtlDetalleModeloLabor7"
    Me.CtlDetalleModeloLabor7.op = Nothing
    Me.CtlDetalleModeloLabor7.Size = New System.Drawing.Size(175, 142)
    Me.CtlDetalleModeloLabor7.TabIndex = 6
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor1)
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor2)
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor3)
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor4)
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor5)
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor6)
    Me.Panel2.Controls.Add(Me.CtlDetalleModeloLabor7)
    Me.Panel2.Location = New System.Drawing.Point(0, 65)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(560, 448)
    Me.Panel2.TabIndex = 4
    '
    'FrmModeloLabor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(560, 556)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.Panel2)
    Me.Name = "FrmModeloLabor"
    Me.Text = "Modelo de Labor"
    Me.Controls.SetChildIndex(Me.Panel2, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents CtlDetalleModeloLabor1 As CtlDetalleModeloLabor
  Friend WithEvents CtlDetalleModeloLabor2 As CtlDetalleModeloLabor
  Friend WithEvents CtlDetalleModeloLabor3 As CtlDetalleModeloLabor
  Friend WithEvents CtlDetalleModeloLabor4 As CtlDetalleModeloLabor
  Friend WithEvents CtlDetalleModeloLabor5 As CtlDetalleModeloLabor
  Friend WithEvents CtlDetalleModeloLabor6 As CtlDetalleModeloLabor
  Friend WithEvents CtlDetalleModeloLabor7 As CtlDetalleModeloLabor
  Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
