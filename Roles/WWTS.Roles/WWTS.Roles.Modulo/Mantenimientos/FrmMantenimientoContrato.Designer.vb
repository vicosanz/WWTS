<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoContrato
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Me.CtlContrato1 = New WWTS.Roles.Modulo.CtlContrato()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'CtlContrato1
    '
    Me.CtlContrato1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlContrato1.Empleado = Nothing
    Me.CtlContrato1.Location = New System.Drawing.Point(0, 49)
    Me.CtlContrato1.ModoenSeleccion = False
    Me.CtlContrato1.Name = "CtlContrato1"
    Me.CtlContrato1.Op = Nothing
    Me.CtlContrato1.Selecc_Codigo = 0
    Me.CtlContrato1.Size = New System.Drawing.Size(773, 213)
    Me.CtlContrato1.TabIndex = 3
    Me.CtlContrato1.Usuario = Nothing
    '
    'FrmMantenimientoContrato
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(773, 262)
    Me.Controls.Add(Me.CtlContrato1)
    Me.Name = "FrmMantenimientoContrato"
    Me.PuedeGuardaryCerrar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento de Contrato"
    Me.Controls.SetChildIndex(Me.CtlContrato1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlContrato1 As WWTS.Roles.Modulo.CtlContrato
End Class
