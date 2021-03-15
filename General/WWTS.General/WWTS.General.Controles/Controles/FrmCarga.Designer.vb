Imports Infoware.Consola.Base

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarga
  Inherits FrmDialogoBase

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
    Me.CtlBuscaEntidad21 = New WWTS.General.Controles.CtlBuscaEntidad2()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ComboBoxTipoCarga = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.checkSeguroCorporativo = New Infoware.Controles.Base.CheckBoxStd()
    Me.SuspendLayout()
    '
    'CtlBuscaEntidad21
    '
    Me.CtlBuscaEntidad21.Entidad = Nothing
    Me.CtlBuscaEntidad21.EntidadJuridica = Nothing
    Me.CtlBuscaEntidad21.EntidadNatural = Nothing
    Me.CtlBuscaEntidad21.EntidadText = "Persona:"
    Me.CtlBuscaEntidad21.Location = New System.Drawing.Point(12, 12)
    Me.CtlBuscaEntidad21.Name = "CtlBuscaEntidad21"
    Me.CtlBuscaEntidad21.OperadorDatos = Nothing
    Me.CtlBuscaEntidad21.Size = New System.Drawing.Size(444, 25)
    Me.CtlBuscaEntidad21.TabIndex = 0
    Me.CtlBuscaEntidad21.TipoEntidad = WWTS.General.Controles.CtlBuscaEntidad2.EnumTipoEntidad.EntidadNatural
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(64, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Parentezco:"
    '
    'ComboBoxTipoCarga
    '
    Me.ComboBoxTipoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoCarga.FormattingEnabled = True
    Me.ComboBoxTipoCarga.Location = New System.Drawing.Point(139, 43)
    Me.ComboBoxTipoCarga.Name = "ComboBoxTipoCarga"
    Me.ComboBoxTipoCarga.OperadorDatos = Nothing
    Me.ComboBoxTipoCarga.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoCarga.ParametroDet = Nothing
    Me.ComboBoxTipoCarga.PuedeActualizar = True
    Me.ComboBoxTipoCarga.PuedeEliminar = True
    Me.ComboBoxTipoCarga.PuedeModificar = True
    Me.ComboBoxTipoCarga.PuedeNuevo = True
    Me.ComboBoxTipoCarga.Size = New System.Drawing.Size(209, 21)
    Me.ComboBoxTipoCarga.TabIndex = 2
    '
    'checkSeguroCorporativo
    '
    Me.checkSeguroCorporativo.AutoSize = True
    Me.checkSeguroCorporativo.Location = New System.Drawing.Point(139, 75)
    Me.checkSeguroCorporativo.Name = "checkSeguroCorporativo"
    Me.checkSeguroCorporativo.Size = New System.Drawing.Size(155, 17)
    Me.checkSeguroCorporativo.TabIndex = 3
    Me.checkSeguroCorporativo.Text = "Seguro Médico Corporativo"
    Me.checkSeguroCorporativo.UseVisualStyleBackColor = True
    '
    'FrmCarga
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(468, 135)
    Me.Controls.Add(Me.checkSeguroCorporativo)
    Me.Controls.Add(Me.ComboBoxTipoCarga)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.CtlBuscaEntidad21)
    Me.Name = "FrmCarga"
    Me.Text = "Carga familiar"
    Me.Controls.SetChildIndex(Me.CtlBuscaEntidad21, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxTipoCarga, 0)
    Me.Controls.SetChildIndex(Me.checkSeguroCorporativo, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlBuscaEntidad21 As WWTS.General.Controles.CtlBuscaEntidad2
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoCarga As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents checkSeguroCorporativo As Infoware.Controles.Base.CheckBoxStd

End Class
