<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewCheck
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.Lista = New System.Windows.Forms.ListView
    Me.chktodos = New System.Windows.Forms.CheckBox
    Me.SuspendLayout()
    '
    'Lista
    '
    Me.Lista.CheckBoxes = True
    Me.Lista.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Lista.Location = New System.Drawing.Point(0, 0)
    Me.Lista.Name = "Lista"
    Me.Lista.Size = New System.Drawing.Size(543, 383)
    Me.Lista.TabIndex = 0
    Me.Lista.UseCompatibleStateImageBehavior = False
    Me.Lista.View = System.Windows.Forms.View.Details
    '
    'chktodos
    '
    Me.chktodos.AutoSize = True
    Me.chktodos.Location = New System.Drawing.Point(3, 3)
    Me.chktodos.Name = "chktodos"
    Me.chktodos.Size = New System.Drawing.Size(15, 14)
    Me.chktodos.TabIndex = 1
    Me.chktodos.UseVisualStyleBackColor = True
    '
    'ListViewCheck
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.chktodos)
    Me.Controls.Add(Me.Lista)
    Me.Name = "ListViewCheck"
    Me.Size = New System.Drawing.Size(543, 383)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents chktodos As System.Windows.Forms.CheckBox
  Public WithEvents Lista As System.Windows.Forms.ListView

End Class
