<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaClientes
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Me.ToolTipImage1 = New Infoware.Controles.Base.ToolTipImage()
    Me.btnmostrar = New Infoware.Controles.Base.ButtonStd()
    Me.BarraEmpresa1 = New WWTS.Aplicacion.Controles.BarraEmpresa()
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.btnmostrar)
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(611, 408)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.btnmostrar, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'Panel1
    '
    Me.Panel1.Location = New System.Drawing.Point(0, 40)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
    Me.Panel1.Size = New System.Drawing.Size(611, 51)
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(56, 97)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(26, 23)
    Me.btnmostrar.TabIndex = 7
    Me.btnmostrar.Text = "Button1"
    Me.btnmostrar.UseVisualStyleBackColor = True
    Me.btnmostrar.Visible = False
    '
    'BarraEmpresa1
    '
    Me.BarraEmpresa1.Empresa = Nothing
    Me.BarraEmpresa1.EmpresaVisible = True
    Me.BarraEmpresa1.FiltroTalleres = False
    Me.BarraEmpresa1.Location = New System.Drawing.Point(0, 0)
    Me.BarraEmpresa1.Name = "BarraEmpresa1"
    Me.BarraEmpresa1.RegContableVisible = False
    Me.BarraEmpresa1.RegistroContable = Nothing
    Me.BarraEmpresa1.Sistema = Nothing
    Me.BarraEmpresa1.Size = New System.Drawing.Size(611, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = True
    Me.BarraEmpresa1.TabIndex = 4
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmListaClientes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(611, 482)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmListaClientes"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnmostrar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents ToolTipImage1 As Infoware.Controles.Base.ToolTipImage
  Friend WithEvents BarraEmpresa1 As WWTS.Aplicacion.Controles.BarraEmpresa
End Class
