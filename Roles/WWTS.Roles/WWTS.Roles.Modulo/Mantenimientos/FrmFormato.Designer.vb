<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormato
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
    Me.ComboBoxTipo = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.btnEjecutar = New Infoware.Controles.Base.ButtonStd()
    Me.CtlPeriodo1 = New CtlPeriodo()
    Me.CtlPatrono1 = New WWTS.Roles.Controles.CtlPatrono()
    Me.SuspendLayout()
    '
    'ComboBoxTipo
    '
    Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipo.FormattingEnabled = True
    Me.ComboBoxTipo.Location = New System.Drawing.Point(100, 143)
    Me.ComboBoxTipo.Name = "ComboBoxTipo"
    Me.ComboBoxTipo.OperadorDatos = Nothing
    Me.ComboBoxTipo.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipo.ParametroDet = Nothing
    Me.ComboBoxTipo.PuedeActualizar = True
    Me.ComboBoxTipo.PuedeEliminar = True
    Me.ComboBoxTipo.PuedeModificar = True
    Me.ComboBoxTipo.PuedeNuevo = True
    Me.ComboBoxTipo.Size = New System.Drawing.Size(200, 21)
    Me.ComboBoxTipo.TabIndex = 1003
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(30, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 13)
    Me.Label1.TabIndex = 1004
    Me.Label1.Text = "Patrono:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(30, 81)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 26)
    Me.Label2.TabIndex = 1005
    Me.Label2.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de pago:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(30, 143)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(31, 13)
    Me.Label3.TabIndex = 1006
    Me.Label3.Text = "Tipo:"
    '
    'btnEjecutar
    '
    Me.btnEjecutar.Location = New System.Drawing.Point(225, 170)
    Me.btnEjecutar.Name = "btnEjecutar"
    Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
    Me.btnEjecutar.TabIndex = 1007
    Me.btnEjecutar.Text = "Ejecutar"
    Me.btnEjecutar.UseVisualStyleBackColor = True
    '
    'CtlPeriodo1
    '
    Me.CtlPeriodo1.FormattingEnabled = True
    Me.CtlPeriodo1.Location = New System.Drawing.Point(100, 81)
    Me.CtlPeriodo1.Name = "CtlPeriodo1"
    Me.CtlPeriodo1.Op = Nothing
    Me.CtlPeriodo1.PardetPeriodoPago = Nothing
    Me.CtlPeriodo1.PeriodoPago = Nothing
    Me.CtlPeriodo1.PuedeActualizar = True
    Me.CtlPeriodo1.PuedeEliminar = True
    Me.CtlPeriodo1.PuedeModificar = True
    Me.CtlPeriodo1.PuedeNuevo = True
    Me.CtlPeriodo1.Size = New System.Drawing.Size(200, 56)
    Me.CtlPeriodo1.TabIndex = 1008
    '
    'CtlPatrono1
    '
    Me.CtlPatrono1.Location = New System.Drawing.Point(100, 15)
    Me.CtlPatrono1.Name = "CtlPatrono1"
    Me.CtlPatrono1.Op = Nothing
    Me.CtlPatrono1.Patrono = Nothing
    Me.CtlPatrono1.Size = New System.Drawing.Size(200, 60)
    Me.CtlPatrono1.TabIndex = 1002
    Me.CtlPatrono1.Usuario = Nothing
    '
    'FrmFormato
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(353, 236)
    Me.Controls.Add(Me.CtlPeriodo1)
    Me.Controls.Add(Me.btnEjecutar)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBoxTipo)
    Me.Controls.Add(Me.CtlPatrono1)
    Me.Name = "FrmFormato"
    Me.Text = "FrmFormato"
    Me.Controls.SetChildIndex(Me.CtlPatrono1, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxTipo, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.btnEjecutar, 0)
    Me.Controls.SetChildIndex(Me.CtlPeriodo1, 0)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlPatrono1 As WWTS.Roles.Controles.CtlPatrono
  Friend WithEvents ComboBoxTipo As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnEjecutar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents CtlPeriodo1 As CtlPeriodo
End Class
