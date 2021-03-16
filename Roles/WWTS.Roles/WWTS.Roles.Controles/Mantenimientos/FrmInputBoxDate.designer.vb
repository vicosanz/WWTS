<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInputBoxDate
    Inherits System.Windows.Forms.Form

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
    Me.btncancelar = New Infoware.Controles.Base.ButtonStd
    Me.btnaceptar = New Infoware.Controles.Base.ButtonStd
    Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
    Me.SuspendLayout()
    '
    'btncancelar
    '
    Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btncancelar.Location = New System.Drawing.Point(187, 37)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(75, 23)
    Me.btncancelar.TabIndex = 5
    Me.btncancelar.Text = "&Cancelar"
    '
    'btnaceptar
    '
    Me.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnaceptar.Location = New System.Drawing.Point(187, 9)
    Me.btnaceptar.Name = "btnaceptar"
    Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
    Me.btnaceptar.TabIndex = 4
    Me.btnaceptar.Text = "&Aceptar"
    '
    'MonthCalendar1
    '
    Me.MonthCalendar1.Location = New System.Drawing.Point(7, 9)
    Me.MonthCalendar1.MaxSelectionCount = 1
    Me.MonthCalendar1.Name = "MonthCalendar1"
    Me.MonthCalendar1.TabIndex = 3
    '
    'FrmInputBoxDate
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(269, 174)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnaceptar)
    Me.Controls.Add(Me.MonthCalendar1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "FrmInputBoxDate"
    Me.Text = "Ingrese una fecha"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btncancelar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnaceptar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
