Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlDiagnostico
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
    Me.Ficha_Diag2 = New System.Windows.Forms.TextBox()
    Me.Ficha_Diag3 = New System.Windows.Forms.TextBox()
    Me.Ficha_Diag1 = New System.Windows.Forms.TextBox()
    Me.Ficha_DiagCIE3 = New System.Windows.Forms.TextBox()
    Me.Ficha_DiagCIE2 = New System.Windows.Forms.TextBox()
    Me.Ficha_DiagCIE1 = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Ficha_DiagDef1 = New System.Windows.Forms.CheckBox()
    Me.Ficha_DiagDef2 = New System.Windows.Forms.CheckBox()
    Me.Ficha_DiagDef3 = New System.Windows.Forms.CheckBox()
    Me.SuspendLayout()
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(114, 17)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "DIAGNÓSTICO"
    '
    'TextBox12
    '
    Me.Ficha_Diag2.Location = New System.Drawing.Point(6, 77)
    Me.Ficha_Diag2.Name = "TextBox12"
    Me.Ficha_Diag2.Size = New System.Drawing.Size(683, 22)
    Me.Ficha_Diag2.TabIndex = 5
    '
    'TextBox3
    '
    Me.Ficha_Diag3.Location = New System.Drawing.Point(6, 105)
    Me.Ficha_Diag3.Name = "TextBox3"
    Me.Ficha_Diag3.Size = New System.Drawing.Size(683, 22)
    Me.Ficha_Diag3.TabIndex = 8
    '
    'TextBox10
    '
    Me.Ficha_Diag1.Location = New System.Drawing.Point(6, 50)
    Me.Ficha_Diag1.Name = "TextBox10"
    Me.Ficha_Diag1.Size = New System.Drawing.Size(683, 22)
    Me.Ficha_Diag1.TabIndex = 2
    '
    'TextBox1
    '
    Me.Ficha_DiagCIE3.Location = New System.Drawing.Point(695, 105)
    Me.Ficha_DiagCIE3.Name = "TextBox1"
    Me.Ficha_DiagCIE3.Size = New System.Drawing.Size(209, 22)
    Me.Ficha_DiagCIE3.TabIndex = 9
    '
    'TextBox11
    '
    Me.Ficha_DiagCIE2.Location = New System.Drawing.Point(695, 77)
    Me.Ficha_DiagCIE2.Name = "TextBox11"
    Me.Ficha_DiagCIE2.Size = New System.Drawing.Size(209, 22)
    Me.Ficha_DiagCIE2.TabIndex = 6
    '
    'TextBox9
    '
    Me.Ficha_DiagCIE1.Location = New System.Drawing.Point(695, 50)
    Me.Ficha_DiagCIE1.Name = "TextBox9"
    Me.Ficha_DiagCIE1.Size = New System.Drawing.Size(209, 22)
    Me.Ficha_DiagCIE1.TabIndex = 3
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(700, 24)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(29, 17)
    Me.Label10.TabIndex = 1
    Me.Label10.Text = "CIE"
    '
    'CheckBox1
    '
    Me.Ficha_DiagDef1.AutoSize = True
    Me.Ficha_DiagDef1.Location = New System.Drawing.Point(911, 50)
    Me.Ficha_DiagDef1.Name = "CheckBox1"
    Me.Ficha_DiagDef1.Size = New System.Drawing.Size(88, 21)
    Me.Ficha_DiagDef1.TabIndex = 4
    Me.Ficha_DiagDef1.Text = "Definitivo"
    Me.Ficha_DiagDef1.UseVisualStyleBackColor = True
    '
    'CheckBox2
    '
    Me.Ficha_DiagDef2.AutoSize = True
    Me.Ficha_DiagDef2.Location = New System.Drawing.Point(911, 77)
    Me.Ficha_DiagDef2.Name = "CheckBox2"
    Me.Ficha_DiagDef2.Size = New System.Drawing.Size(88, 21)
    Me.Ficha_DiagDef2.TabIndex = 7
    Me.Ficha_DiagDef2.Text = "Definitivo"
    Me.Ficha_DiagDef2.UseVisualStyleBackColor = True
    '
    'CheckBox3
    '
    Me.Ficha_DiagDef3.AutoSize = True
    Me.Ficha_DiagDef3.Location = New System.Drawing.Point(911, 104)
    Me.Ficha_DiagDef3.Name = "CheckBox3"
    Me.Ficha_DiagDef3.Size = New System.Drawing.Size(88, 21)
    Me.Ficha_DiagDef3.TabIndex = 10
    Me.Ficha_DiagDef3.Text = "Definitivo"
    Me.Ficha_DiagDef3.UseVisualStyleBackColor = True
    '
    'CtlDiagnostico
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Ficha_DiagDef3)
    Me.Controls.Add(Me.Ficha_DiagDef2)
    Me.Controls.Add(Me.Ficha_DiagDef1)
    Me.Controls.Add(Me.Ficha_DiagCIE3)
    Me.Controls.Add(Me.Ficha_DiagCIE2)
    Me.Controls.Add(Me.Ficha_DiagCIE1)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Ficha_Diag2)
    Me.Controls.Add(Me.Ficha_Diag3)
    Me.Controls.Add(Me.Ficha_Diag1)
    Me.Controls.Add(Me.Label12)
    Me.Name = "CtlDiagnostico"
    Me.Size = New System.Drawing.Size(1056, 138)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label12 As Label
  Friend WithEvents Ficha_Diag2 As TextBox
  Friend WithEvents Ficha_Diag3 As TextBox
  Friend WithEvents Ficha_Diag1 As TextBox
  Friend WithEvents Ficha_DiagCIE3 As TextBox
  Friend WithEvents Ficha_DiagCIE2 As TextBox
  Friend WithEvents Ficha_DiagCIE1 As TextBox
  Friend WithEvents Label10 As Label
  Friend WithEvents Ficha_DiagDef1 As CheckBox
  Friend WithEvents Ficha_DiagDef2 As CheckBox
  Friend WithEvents Ficha_DiagDef3 As CheckBox
End Class
