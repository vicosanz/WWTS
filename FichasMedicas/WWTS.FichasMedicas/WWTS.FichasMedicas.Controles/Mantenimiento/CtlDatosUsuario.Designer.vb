Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlDatosUsuario
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
    Me.ComboBoxParametroDetGenero = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.ComboBoxParametroDetReligion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(59, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Religión"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 33)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(135, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Identidad de género"
    '
    'ComboBoxParametroDetGenero
    '
    Me.ComboBoxParametroDetGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDetGenero.FormattingEnabled = True
    Me.ComboBoxParametroDetGenero.Location = New System.Drawing.Point(150, 33)
    Me.ComboBoxParametroDetGenero.Name = "ComboBoxParametroDetGenero"
    Me.ComboBoxParametroDetGenero.OperadorDatos = Nothing
    Me.ComboBoxParametroDetGenero.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDetGenero.ParametroDet = Nothing
    Me.ComboBoxParametroDetGenero.PuedeActualizar = True
    Me.ComboBoxParametroDetGenero.PuedeEliminar = True
    Me.ComboBoxParametroDetGenero.PuedeModificar = True
    Me.ComboBoxParametroDetGenero.PuedeNuevo = True
    Me.ComboBoxParametroDetGenero.Size = New System.Drawing.Size(232, 24)
    Me.ComboBoxParametroDetGenero.TabIndex = 3
    '
    'ComboBoxParametroDetReligion
    '
    Me.ComboBoxParametroDetReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDetReligion.FormattingEnabled = True
    Me.ComboBoxParametroDetReligion.Location = New System.Drawing.Point(150, 3)
    Me.ComboBoxParametroDetReligion.Name = "ComboBoxParametroDetReligion"
    Me.ComboBoxParametroDetReligion.OperadorDatos = Nothing
    Me.ComboBoxParametroDetReligion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDetReligion.ParametroDet = Nothing
    Me.ComboBoxParametroDetReligion.PuedeActualizar = True
    Me.ComboBoxParametroDetReligion.PuedeEliminar = True
    Me.ComboBoxParametroDetReligion.PuedeModificar = True
    Me.ComboBoxParametroDetReligion.PuedeNuevo = True
    Me.ComboBoxParametroDetReligion.Size = New System.Drawing.Size(232, 24)
    Me.ComboBoxParametroDetReligion.TabIndex = 1
    '
    'CtlDatosUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBoxParametroDetGenero)
    Me.Controls.Add(Me.ComboBoxParametroDetReligion)
    Me.Name = "CtlDatosUsuario"
    Me.Size = New System.Drawing.Size(841, 79)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents ComboBoxParametroDetReligion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As Label
  Friend WithEvents ComboBoxParametroDetGenero As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As Label
End Class
