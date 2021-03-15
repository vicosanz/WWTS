<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermiso
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
    Me.components = New System.ComponentModel.Container
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblmensaje = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker
    Me.cbotipopermiso = New WWTS.General.Controles.ComboBoxParametroDet
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(85, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Tipo de permiso:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 74)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(41, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Desde:"
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(335, 24)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 100)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(38, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Hasta:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Location = New System.Drawing.Point(103, 70)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(213, 20)
    Me.dtfecdesde.TabIndex = 4
    '
    'dtfechasta
    '
    Me.dtfechasta.Location = New System.Drawing.Point(103, 96)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(213, 20)
    Me.dtfechasta.TabIndex = 6
    '
    'cbotipopermiso
    '
    Me.cbotipopermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipopermiso.FormattingEnabled = True
    Me.cbotipopermiso.Location = New System.Drawing.Point(103, 43)
    Me.cbotipopermiso.Name = "cbotipopermiso"
    Me.cbotipopermiso.OperadorDatos = Nothing
    Me.cbotipopermiso.Parametro = General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipopermiso.ParametroDet = Nothing
    Me.cbotipopermiso.PuedeActualizar = True
    Me.cbotipopermiso.PuedeEliminar = True
    Me.cbotipopermiso.PuedeModificar = True
    Me.cbotipopermiso.PuedeNuevo = True
    Me.cbotipopermiso.Size = New System.Drawing.Size(213, 21)
    Me.cbotipopermiso.TabIndex = 2
    '
    'FrmPermiso
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(335, 169)
    Me.Controls.Add(Me.cbotipopermiso)
    Me.Controls.Add(Me.dtfechasta)
    Me.Controls.Add(Me.dtfecdesde)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmPermiso"
    Me.Text = "Permiso"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.dtfecdesde, 0)
    Me.Controls.SetChildIndex(Me.dtfechasta, 0)
    Me.Controls.SetChildIndex(Me.cbotipopermiso, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents cbotipopermiso As WWTS.General.Controles.ComboBoxParametroDet

End Class
