﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuRol
  Inherits Infoware.Consola.Base.FrmModuloBase

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
    Me.BarraRegistroContable1 = New WWTS.Aplicacion.Controles.BarraEmpresa
    Me.tvreportes = New System.Windows.Forms.TreeView
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'tvopciones1
    '
    Me.tvopciones1.LineColor = System.Drawing.Color.Black
    '
    'ImageList1
    '
    Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
    Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.ImageList1.ImageStream = Nothing
    '
    'ImageList2
    '
    Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
    Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
    Me.ImageList2.ImageStream = Nothing
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.tvreportes)
    Me.Panel1.Controls.Add(Me.BarraRegistroContable1)
    Me.Panel1.Size = New System.Drawing.Size(453, 186)
    '
    'BarraRegistroContable1
    '
    Me.BarraRegistroContable1.Sistema = Nothing
    Me.BarraRegistroContable1.Empresa = Nothing
    Me.BarraRegistroContable1.EmpresaVisible = True
    Me.BarraRegistroContable1.Location = New System.Drawing.Point(15, 5)
    Me.BarraRegistroContable1.Name = "BarraRegistroContable1"
    Me.BarraRegistroContable1.RegContableVisible = True
    Me.BarraRegistroContable1.RegistroContable = Nothing
    Me.BarraRegistroContable1.Size = New System.Drawing.Size(437, 25)
    Me.BarraRegistroContable1.Sucursal = Nothing
    Me.BarraRegistroContable1.SucursalVisible = True
    Me.BarraRegistroContable1.TabIndex = 0
    Me.BarraRegistroContable1.Text = "BarraRegistroContable1"
    Me.BarraRegistroContable1.Visible = False
    '
    'tvreportes
    '
    Me.tvreportes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tvreportes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvreportes.HideSelection = False
    Me.tvreportes.ImageIndex = 0
    Me.tvreportes.ImageList = Me.ImageList2
    Me.tvreportes.LineColor = System.Drawing.Color.White
    Me.tvreportes.Location = New System.Drawing.Point(15, 5)
    Me.tvreportes.Name = "tvreportes"
    Me.tvreportes.SelectedImageIndex = 0
    Me.tvreportes.ShowLines = False
    Me.tvreportes.ShowPlusMinus = False
    Me.tvreportes.ShowRootLines = False
    Me.tvreportes.Size = New System.Drawing.Size(437, 180)
    Me.tvreportes.TabIndex = 1
    '
    'FrmMenuRol
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(453, 434)
    Me.Name = "FrmMenuRol"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BarraRegistroContable1 As WWTS.Aplicacion.Controles.BarraEmpresa
  Friend WithEvents tvreportes As System.Windows.Forms.TreeView

End Class
