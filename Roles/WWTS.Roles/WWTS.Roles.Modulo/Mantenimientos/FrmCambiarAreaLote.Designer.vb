<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCambiarAreaLote
  Inherits Infoware.Consola.Base.FrmDialogoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.ComboBoxParametroDet1 = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboHacienda = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboTerreno = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboLote = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(176, 65)
    Me.ComboBoxParametroDet1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(446, 32)
    Me.ComboBoxParametroDet1.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(22, 70)
    Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(54, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Area"
    '
    'cboHacienda
    '
    Me.cboHacienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboHacienda.FormattingEnabled = True
    Me.cboHacienda.Location = New System.Drawing.Point(176, 125)
    Me.cboHacienda.Margin = New System.Windows.Forms.Padding(6)
    Me.cboHacienda.Name = "cboHacienda"
    Me.cboHacienda.OperadorDatos = Nothing
    Me.cboHacienda.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboHacienda.ParametroDet = Nothing
    Me.cboHacienda.PuedeActualizar = True
    Me.cboHacienda.PuedeEliminar = True
    Me.cboHacienda.PuedeModificar = True
    Me.cboHacienda.PuedeNuevo = True
    Me.cboHacienda.Size = New System.Drawing.Size(446, 32)
    Me.cboHacienda.TabIndex = 1003
    '
    'cboTerreno
    '
    Me.cboTerreno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTerreno.FormattingEnabled = True
    Me.cboTerreno.Location = New System.Drawing.Point(176, 174)
    Me.cboTerreno.Margin = New System.Windows.Forms.Padding(6)
    Me.cboTerreno.Name = "cboTerreno"
    Me.cboTerreno.OperadorDatos = Nothing
    Me.cboTerreno.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboTerreno.ParametroDet = Nothing
    Me.cboTerreno.PuedeActualizar = True
    Me.cboTerreno.PuedeEliminar = True
    Me.cboTerreno.PuedeModificar = True
    Me.cboTerreno.PuedeNuevo = True
    Me.cboTerreno.Size = New System.Drawing.Size(446, 32)
    Me.cboTerreno.TabIndex = 1005
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(22, 230)
    Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(50, 25)
    Me.Label3.TabIndex = 1006
    Me.Label3.Text = "Lote"
    '
    'cboLote
    '
    Me.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLote.FormattingEnabled = True
    Me.cboLote.Location = New System.Drawing.Point(176, 224)
    Me.cboLote.Margin = New System.Windows.Forms.Padding(6)
    Me.cboLote.Name = "cboLote"
    Me.cboLote.OperadorDatos = Nothing
    Me.cboLote.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboLote.ParametroDet = Nothing
    Me.cboLote.PuedeActualizar = True
    Me.cboLote.PuedeEliminar = True
    Me.cboLote.PuedeModificar = True
    Me.cboLote.PuedeNuevo = True
    Me.cboLote.Size = New System.Drawing.Size(446, 32)
    Me.cboLote.TabIndex = 1007
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(22, 180)
    Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(81, 25)
    Me.Label2.TabIndex = 1004
    Me.Label2.Text = "Terreno"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(22, 130)
    Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(95, 25)
    Me.Label4.TabIndex = 1002
    Me.Label4.Text = "Hacienda"
    '
    'FrmCambiarAreaLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(647, 399)
    Me.Controls.Add(Me.cboHacienda)
    Me.Controls.Add(Me.cboTerreno)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cboLote)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Margin = New System.Windows.Forms.Padding(11, 11, 11, 11)
    Me.Name = "FrmCambiarAreaLote"
    Me.Text = "Cambiar Area y lote"
    Me.Controls.SetChildIndex(Me.ComboBoxParametroDet1, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.cboLote, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.cboTerreno, 0)
    Me.Controls.SetChildIndex(Me.cboHacienda, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ComboBoxParametroDet1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboHacienda As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents cboTerreno As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label3 As Label
  Friend WithEvents cboLote As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As Label
  Friend WithEvents Label4 As Label
End Class
