<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportSimple
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
    Me.CtlDesigner1 = New Infoware.Reportes.CtlDesigner
    Me.SuspendLayout()
    '
    'CtlDesigner1
    '
    Me.CtlDesigner1.ArchivoReporte = ""
    Me.CtlDesigner1.BackColor = System.Drawing.SystemColors.Window
    Me.CtlDesigner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CtlDesigner1.Cabecera = Nothing
    Me.CtlDesigner1.Detalles = Nothing
    Me.CtlDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlDesigner1.Location = New System.Drawing.Point(0, 0)
    Me.CtlDesigner1.Name = "CtlDesigner1"
    Me.CtlDesigner1.ReportData = Nothing
    Me.CtlDesigner1.Size = New System.Drawing.Size(766, 514)
    Me.CtlDesigner1.TabIndex = 0
    '
    'FrmReportSimple
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(766, 514)
    Me.Controls.Add(Me.CtlDesigner1)
    Me.Name = "FrmReportSimple"
    Me.Text = "Diseñador de reportes"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CtlDesigner1 As Infoware.Reportes.CtlDesigner
End Class
