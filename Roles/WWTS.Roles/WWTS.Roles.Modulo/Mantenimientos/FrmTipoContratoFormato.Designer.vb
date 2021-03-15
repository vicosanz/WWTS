<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoContratoFormato
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
    Me.ComboBoxTipoFormato = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnTiCoFo_Archivo = New Infoware.Controles.Base.ButtonStd()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.CachedcrpTareaAgrupada1 = New WWTS.Roles.Modulo.CachedcrpTareaAgrupada()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 17)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tipo de Formato:"
    '
    'ComboBoxTipoFormato
    '
    Me.ComboBoxTipoFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoFormato.FormattingEnabled = True
    Me.ComboBoxTipoFormato.Location = New System.Drawing.Point(115, 15)
    Me.ComboBoxTipoFormato.Name = "ComboBoxTipoFormato"
    Me.ComboBoxTipoFormato.OperadorDatos = Nothing
    Me.ComboBoxTipoFormato.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoFormato.ParametroDet = Nothing
    Me.ComboBoxTipoFormato.PuedeActualizar = True
    Me.ComboBoxTipoFormato.PuedeEliminar = True
    Me.ComboBoxTipoFormato.PuedeModificar = True
    Me.ComboBoxTipoFormato.PuedeNuevo = True
    Me.ComboBoxTipoFormato.Size = New System.Drawing.Size(151, 21)
    Me.ComboBoxTipoFormato.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(15, 52)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Archivo:"
    '
    'btnTiCoFo_Archivo
    '
    Me.btnTiCoFo_Archivo.Location = New System.Drawing.Point(115, 50)
    Me.btnTiCoFo_Archivo.Name = "btnTiCoFo_Archivo"
    Me.btnTiCoFo_Archivo.Size = New System.Drawing.Size(267, 23)
    Me.btnTiCoFo_Archivo.TabIndex = 3
    Me.btnTiCoFo_Archivo.UseVisualStyleBackColor = True
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "Seleccionar Archivo"
    '
    'FrmTipoContratoFormato
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(394, 122)
    Me.Controls.Add(Me.btnTiCoFo_Archivo)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBoxTipoFormato)
    Me.Name = "FrmTipoContratoFormato"
    Me.Text = "Mantenimiento de Formatos"
    Me.Controls.SetChildIndex(Me.ComboBoxTipoFormato, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.btnTiCoFo_Archivo, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoFormato As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnTiCoFo_Archivo As Infoware.Controles.Base.ButtonStd
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents CachedcrpTareaAgrupada1 As WWTS.Roles.Modulo.CachedcrpTareaAgrupada
End Class
