<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarLote
  Inherits Infoware.Consola.Base.FrmDialogoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboHacienda = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboTerreno = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboLote = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkNulo = New System.Windows.Forms.CheckBox()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 6)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(53, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Hacienda"
    '
    'cboHacienda
    '
    Me.cboHacienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboHacienda.FormattingEnabled = True
    Me.cboHacienda.Location = New System.Drawing.Point(93, 3)
    Me.cboHacienda.Name = "cboHacienda"
    Me.cboHacienda.OperadorDatos = Nothing
    Me.cboHacienda.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboHacienda.ParametroDet = Nothing
    Me.cboHacienda.PuedeActualizar = True
    Me.cboHacienda.PuedeEliminar = True
    Me.cboHacienda.PuedeModificar = True
    Me.cboHacienda.PuedeNuevo = True
    Me.cboHacienda.Size = New System.Drawing.Size(245, 21)
    Me.cboHacienda.TabIndex = 1
    '
    'cboTerreno
    '
    Me.cboTerreno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTerreno.FormattingEnabled = True
    Me.cboTerreno.Location = New System.Drawing.Point(93, 30)
    Me.cboTerreno.Name = "cboTerreno"
    Me.cboTerreno.OperadorDatos = Nothing
    Me.cboTerreno.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboTerreno.ParametroDet = Nothing
    Me.cboTerreno.PuedeActualizar = True
    Me.cboTerreno.PuedeEliminar = True
    Me.cboTerreno.PuedeModificar = True
    Me.cboTerreno.PuedeNuevo = True
    Me.cboTerreno.Size = New System.Drawing.Size(245, 21)
    Me.cboTerreno.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 33)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Terreno"
    '
    'cboLote
    '
    Me.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLote.FormattingEnabled = True
    Me.cboLote.Location = New System.Drawing.Point(93, 57)
    Me.cboLote.Name = "cboLote"
    Me.cboLote.OperadorDatos = Nothing
    Me.cboLote.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboLote.ParametroDet = Nothing
    Me.cboLote.PuedeActualizar = True
    Me.cboLote.PuedeEliminar = True
    Me.cboLote.PuedeModificar = True
    Me.cboLote.PuedeNuevo = True
    Me.cboLote.Size = New System.Drawing.Size(245, 21)
    Me.cboLote.TabIndex = 5
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 60)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(28, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Lote"
    '
    'chkNulo
    '
    Me.chkNulo.AutoSize = True
    Me.chkNulo.Location = New System.Drawing.Point(12, 12)
    Me.chkNulo.Name = "chkNulo"
    Me.chkNulo.Size = New System.Drawing.Size(101, 17)
    Me.chkNulo.TabIndex = 0
    Me.chkNulo.Text = "Dejar en blanco"
    Me.chkNulo.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.cboHacienda)
    Me.Panel2.Controls.Add(Me.cboTerreno)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.cboLote)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Location = New System.Drawing.Point(0, 35)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(353, 118)
    Me.Panel2.TabIndex = 1
    '
    'FrmCambiarLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(353, 196)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.chkNulo)
    Me.Name = "FrmCambiarLote"
    Me.Text = "Cambiar Lote"
    Me.Controls.SetChildIndex(Me.chkNulo, 0)
    Me.Controls.SetChildIndex(Me.Panel2, 0)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboHacienda As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents cboTerreno As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboLote As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkNulo As System.Windows.Forms.CheckBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
