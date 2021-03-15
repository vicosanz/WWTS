<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTestxArea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxArea = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.ComboBoxTest = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Área:"
        '
        'ComboBoxArea
        '
        Me.ComboBoxArea.AbriralEntrar = False
        Me.ComboBoxArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxArea.FormattingEnabled = True
        Me.ComboBoxArea.Location = New System.Drawing.Point(49, 12)
        Me.ComboBoxArea.Name = "ComboBoxArea"
        Me.ComboBoxArea.OperadorDatos = Nothing
        Me.ComboBoxArea.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxArea.ParametroDet = Nothing
        Me.ComboBoxArea.PuedeActualizar = True
        Me.ComboBoxArea.PuedeEliminar = True
        Me.ComboBoxArea.PuedeModificar = True
        Me.ComboBoxArea.PuedeNuevo = True
        Me.ComboBoxArea.Size = New System.Drawing.Size(231, 21)
        Me.ComboBoxArea.TabIndex = 1
        '
        'ComboBoxTest
        '
        Me.ComboBoxTest.AbriralEntrar = False
        Me.ComboBoxTest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTest.FormattingEnabled = True
        Me.ComboBoxTest.Location = New System.Drawing.Point(49, 40)
        Me.ComboBoxTest.Name = "ComboBoxTest"
        Me.ComboBoxTest.OperadorDatos = Nothing
        Me.ComboBoxTest.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxTest.ParametroDet = Nothing
        Me.ComboBoxTest.PuedeActualizar = True
        Me.ComboBoxTest.PuedeEliminar = True
        Me.ComboBoxTest.PuedeModificar = True
        Me.ComboBoxTest.PuedeNuevo = True
        Me.ComboBoxTest.Size = New System.Drawing.Size(231, 21)
        Me.ComboBoxTest.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test:"
        '
        'FrmMantenimientoTestxArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 112)
        Me.Controls.Add(Me.ComboBoxTest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxArea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMantenimientoTestxArea"
        Me.Text = "Test por área"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxArea, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxTest, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxArea As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents ComboBoxTest As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
