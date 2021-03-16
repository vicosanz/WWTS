<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatrono
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
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label1 = New System.Windows.Forms.Label
    Me.txt_patronal = New Infoware.Controles.Base.TextBoxStd
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.CtlBuscaEntidad21 = New WWTS.General.Controles.CtlBuscaEntidad2
    Me.CtlUbicacion1 = New WWTS.General.Controles.CtlUbicacion
    Me.Label3 = New System.Windows.Forms.Label
    Me.txt_cuentabancaria = New Infoware.Controles.Base.TextBoxStd
    Me.SuspendLayout()
    '
    'txtcodigo
    '
    Me.txtcodigo.Enabled = False
    Me.txtcodigo.Location = New System.Drawing.Point(142, 9)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(54, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcodigo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcodigo.Value = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'txt_patronal
    '
    Me.txt_patronal.Location = New System.Drawing.Point(142, 339)
    Me.txt_patronal.Mensaje = ""
    Me.txt_patronal.Name = "txt_patronal"
    Me.txt_patronal.Size = New System.Drawing.Size(114, 20)
    Me.txt_patronal.TabIndex = 6
    Me.txt_patronal.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 342)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(58, 13)
    Me.Label5.TabIndex = 5
    Me.Label5.Text = "# patronal:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 62)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(55, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Parroquia:"
    '
    'CtlBuscaEntidad21
    '
    Me.CtlBuscaEntidad21.Entidad = Nothing
    Me.CtlBuscaEntidad21.EntidadJuridica = Nothing
    Me.CtlBuscaEntidad21.EntidadNatural = Nothing
    Me.CtlBuscaEntidad21.EntidadText = "Patrono"
    Me.CtlBuscaEntidad21.Location = New System.Drawing.Point(15, 35)
    Me.CtlBuscaEntidad21.Name = "CtlBuscaEntidad21"
    Me.CtlBuscaEntidad21.OperadorDatos = Nothing
    Me.CtlBuscaEntidad21.Size = New System.Drawing.Size(349, 21)
    Me.CtlBuscaEntidad21.TabIndex = 2
    Me.CtlBuscaEntidad21.TipoEntidad = WWTS.General.Controles.CtlBuscaEntidad2.EnumTipoEntidad.EntidadJuridica
    '
    'CtlUbicacion1
    '
    Me.CtlUbicacion1.HideSelection = False
    Me.CtlUbicacion1.Location = New System.Drawing.Point(142, 62)
    Me.CtlUbicacion1.Name = "CtlUbicacion1"
    Me.CtlUbicacion1.Op = Nothing
    Me.CtlUbicacion1.Parroquia = Nothing
    Me.CtlUbicacion1.Size = New System.Drawing.Size(222, 271)
    Me.CtlUbicacion1.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 368)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(88, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Cuenta bancaria:"
    '
    'txt_cuentabancaria
    '
    Me.txt_cuentabancaria.Location = New System.Drawing.Point(142, 365)
    Me.txt_cuentabancaria.Mensaje = ""
    Me.txt_cuentabancaria.Name = "txt_cuentabancaria"
    Me.txt_cuentabancaria.Size = New System.Drawing.Size(114, 20)
    Me.txt_cuentabancaria.TabIndex = 8
    Me.txt_cuentabancaria.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'FrmPatrono
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(372, 433)
    Me.Controls.Add(Me.CtlUbicacion1)
    Me.Controls.Add(Me.CtlBuscaEntidad21)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txt_cuentabancaria)
    Me.Controls.Add(Me.txt_patronal)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label5)
    Me.Name = "FrmPatrono"
    Me.Text = "Patronos"
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.txt_patronal, 0)
    Me.Controls.SetChildIndex(Me.txt_cuentabancaria, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.CtlBuscaEntidad21, 0)
    Me.Controls.SetChildIndex(Me.CtlUbicacion1, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txt_patronal As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents CtlBuscaEntidad21 As WWTS.General.Controles.CtlBuscaEntidad2
  Friend WithEvents CtlUbicacion1 As WWTS.General.Controles.CtlUbicacion
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txt_cuentabancaria As Infoware.Controles.Base.TextBoxStd

End Class
