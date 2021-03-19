Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlClinica
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(disposing As Boolean)
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
    Me.Label2 = New System.Windows.Forms.Label()
    Me.ComboBoxParametroDetClinica = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Ficha_ArchivoNum = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Clínica"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 33)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(128, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Número de archivo"
    '
    'ComboBoxParametroDetClinica
    '
    Me.ComboBoxParametroDetClinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDetClinica.FormattingEnabled = True
    Me.ComboBoxParametroDetClinica.Location = New System.Drawing.Point(150, 3)
    Me.ComboBoxParametroDetClinica.Name = "ComboBoxParametroDetClinica"
    Me.ComboBoxParametroDetClinica.OperadorDatos = Nothing
    Me.ComboBoxParametroDetClinica.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDetClinica.ParametroDet = Nothing
    Me.ComboBoxParametroDetClinica.PuedeActualizar = True
    Me.ComboBoxParametroDetClinica.PuedeEliminar = True
    Me.ComboBoxParametroDetClinica.PuedeModificar = True
    Me.ComboBoxParametroDetClinica.PuedeNuevo = True
    Me.ComboBoxParametroDetClinica.Size = New System.Drawing.Size(232, 24)
    Me.ComboBoxParametroDetClinica.TabIndex = 1
    '
    'Ficha_AntTrabCalifDescripcion
    '
    Me.Ficha_ArchivoNum.Location = New System.Drawing.Point(150, 33)
    Me.Ficha_ArchivoNum.Name = "Ficha_AntTrabCalifDescripcion"
    Me.Ficha_ArchivoNum.Size = New System.Drawing.Size(232, 22)
    Me.Ficha_ArchivoNum.TabIndex = 3
    '
    'CtlClinica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_ArchivoNum)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBoxParametroDetClinica)
    Me.Name = "CtlClinica"
    Me.Size = New System.Drawing.Size(838, 79)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents ComboBoxParametroDetClinica As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Ficha_ArchivoNum As TextBox
End Class
