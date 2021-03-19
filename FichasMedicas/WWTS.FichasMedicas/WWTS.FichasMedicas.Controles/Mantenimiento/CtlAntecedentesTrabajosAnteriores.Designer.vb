Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlAntecedentesTrabajosAnteriores
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
    Me.Label12 = New System.Windows.Forms.Label()
    Me.CtlAntecedentesTrabajoAnterior1 = New CtlAntecedentesTrabajoAnterior()
    Me.CtlAntecedentesTrabajoAnterior2 = New CtlAntecedentesTrabajoAnterior()
    Me.CtlAntecedentesTrabajoAnterior3 = New CtlAntecedentesTrabajoAnterior()
    Me.CtlAntecedentesTrabajoAnterior4 = New CtlAntecedentesTrabajoAnterior()
    Me.SuspendLayout()
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(0, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(233, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "ANTECEDENTES DE TRABAJO"
    '
    'CtlAntecedentesTrabajoAnterior1
    '
    Me.CtlAntecedentesTrabajoAnterior1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlAntecedentesTrabajoAnterior1.FichaMedica = Nothing
    Me.CtlAntecedentesTrabajoAnterior1.Location = New System.Drawing.Point(0, 17)
    Me.CtlAntecedentesTrabajoAnterior1.Name = "CtlAntecedentesTrabajoAnterior1"
    Me.CtlAntecedentesTrabajoAnterior1.Numeral = 1
    Me.CtlAntecedentesTrabajoAnterior1.Size = New System.Drawing.Size(1081, 191)
    Me.CtlAntecedentesTrabajoAnterior1.TabIndex = 1
    '
    'CtlAntecedentesTrabajoAnterior2
    '
    Me.CtlAntecedentesTrabajoAnterior2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlAntecedentesTrabajoAnterior2.FichaMedica = Nothing
    Me.CtlAntecedentesTrabajoAnterior2.Location = New System.Drawing.Point(0, 208)
    Me.CtlAntecedentesTrabajoAnterior2.Name = "CtlAntecedentesTrabajoAnterior2"
    Me.CtlAntecedentesTrabajoAnterior2.Numeral = 1
    Me.CtlAntecedentesTrabajoAnterior2.Size = New System.Drawing.Size(1081, 191)
    Me.CtlAntecedentesTrabajoAnterior2.TabIndex = 2
    '
    'CtlAntecedentesTrabajoAnterior3
    '
    Me.CtlAntecedentesTrabajoAnterior3.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlAntecedentesTrabajoAnterior3.FichaMedica = Nothing
    Me.CtlAntecedentesTrabajoAnterior3.Location = New System.Drawing.Point(0, 399)
    Me.CtlAntecedentesTrabajoAnterior3.Name = "CtlAntecedentesTrabajoAnterior3"
    Me.CtlAntecedentesTrabajoAnterior3.Numeral = 1
    Me.CtlAntecedentesTrabajoAnterior3.Size = New System.Drawing.Size(1081, 191)
    Me.CtlAntecedentesTrabajoAnterior3.TabIndex = 3
    '
    'CtlAntecedentesTrabajoAnterior4
    '
    Me.CtlAntecedentesTrabajoAnterior4.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlAntecedentesTrabajoAnterior4.FichaMedica = Nothing
    Me.CtlAntecedentesTrabajoAnterior4.Location = New System.Drawing.Point(0, 590)
    Me.CtlAntecedentesTrabajoAnterior4.Name = "CtlAntecedentesTrabajoAnterior4"
    Me.CtlAntecedentesTrabajoAnterior4.Numeral = 1
    Me.CtlAntecedentesTrabajoAnterior4.Size = New System.Drawing.Size(1081, 191)
    Me.CtlAntecedentesTrabajoAnterior4.TabIndex = 4
    '
    'CtlAntecedentesTrabajosAnteriores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.CtlAntecedentesTrabajoAnterior4)
    Me.Controls.Add(Me.CtlAntecedentesTrabajoAnterior3)
    Me.Controls.Add(Me.CtlAntecedentesTrabajoAnterior2)
    Me.Controls.Add(Me.CtlAntecedentesTrabajoAnterior1)
    Me.Controls.Add(Me.Label12)
    Me.Name = "CtlAntecedentesTrabajosAnteriores"
    Me.Size = New System.Drawing.Size(1081, 758)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label12 As Label
  Friend WithEvents CtlAntecedentesTrabajoAnterior1 As CtlAntecedentesTrabajoAnterior
  Friend WithEvents CtlAntecedentesTrabajoAnterior2 As CtlAntecedentesTrabajoAnterior
  Friend WithEvents CtlAntecedentesTrabajoAnterior3 As CtlAntecedentesTrabajoAnterior
  Friend WithEvents CtlAntecedentesTrabajoAnterior4 As CtlAntecedentesTrabajoAnterior
End Class
