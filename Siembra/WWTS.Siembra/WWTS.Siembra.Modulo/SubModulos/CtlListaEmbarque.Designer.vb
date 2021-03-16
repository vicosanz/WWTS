<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlListaEmbarque
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
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.Label1 = New System.Windows.Forms.Label
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.chklv = New System.Windows.Forms.CheckBox
    Me.lvcajas = New System.Windows.Forms.ListView
    Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
    Me.ofd = New System.Windows.Forms.OpenFileDialog
    Me.Label2 = New System.Windows.Forms.Label
    Me.btnimportar = New System.Windows.Forms.Button
    Me.lvresumen = New System.Windows.Forms.ListView
    Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.btnexportar = New System.Windows.Forms.Button
    Me.CtlEmbarque1 = New CtlEmbarque
    Me.Panel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "     Empaque"
    Me.ColumnHeader2.Width = 72
    '
    'ColumnHeader9
    '
    Me.ColumnHeader9.Text = "Embarque"
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Clase"
    Me.ColumnHeader3.Width = 67
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(136, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(100, 16)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Resumen"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.chklv)
    Me.Panel2.Controls.Add(Me.lvcajas)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 132)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(571, 282)
    Me.Panel2.TabIndex = 5
    '
    'chklv
    '
    Me.chklv.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chklv.Location = New System.Drawing.Point(4, 4)
    Me.chklv.Name = "chklv"
    Me.chklv.Size = New System.Drawing.Size(12, 14)
    Me.chklv.TabIndex = 0
    '
    'lvcajas
    '
    Me.lvcajas.CheckBoxes = True
    Me.lvcajas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
    Me.lvcajas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvcajas.FullRowSelect = True
    Me.lvcajas.HideSelection = False
    Me.lvcajas.Location = New System.Drawing.Point(0, 0)
    Me.lvcajas.MultiSelect = False
    Me.lvcajas.Name = "lvcajas"
    Me.lvcajas.Size = New System.Drawing.Size(571, 282)
    Me.lvcajas.TabIndex = 1
    Me.lvcajas.UseCompatibleStateImageBehavior = False
    Me.lvcajas.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Color"
    Me.ColumnHeader4.Width = 112
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Corte"
    Me.ColumnHeader1.Width = 40
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Semilla"
    Me.ColumnHeader5.Width = 56
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "Finca"
    '
    'ColumnHeader7
    '
    Me.ColumnHeader7.Text = "Peso"
    Me.ColumnHeader7.Width = 50
    '
    'ColumnHeader8
    '
    Me.ColumnHeader8.Text = "N/C"
    Me.ColumnHeader8.Width = 35
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(4, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(100, 16)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Embarque:"
    '
    'btnimportar
    '
    Me.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnimportar.Location = New System.Drawing.Point(220, 4)
    Me.btnimportar.Name = "btnimportar"
    Me.btnimportar.Size = New System.Drawing.Size(150, 23)
    Me.btnimportar.TabIndex = 3
    Me.btnimportar.Text = "&Importar números embarque"
    '
    'lvresumen
    '
    Me.lvresumen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvresumen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
    Me.lvresumen.Location = New System.Drawing.Point(136, 48)
    Me.lvresumen.MultiSelect = False
    Me.lvresumen.Name = "lvresumen"
    Me.lvresumen.Size = New System.Drawing.Size(431, 80)
    Me.lvresumen.TabIndex = 5
    Me.lvresumen.UseCompatibleStateImageBehavior = False
    Me.lvresumen.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader10
    '
    Me.ColumnHeader10.Text = "Cajas"
    Me.ColumnHeader10.Width = 43
    '
    'ColumnHeader11
    '
    Me.ColumnHeader11.Text = "Finca"
    '
    'ColumnHeader12
    '
    Me.ColumnHeader12.Text = "n/c"
    Me.ColumnHeader12.Width = 32
    '
    'ColumnHeader13
    '
    Me.ColumnHeader13.Text = "Semilla"
    '
    'ColumnHeader14
    '
    Me.ColumnHeader14.Text = "Peso"
    Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader14.Width = 65
    '
    'ColumnHeader15
    '
    Me.ColumnHeader15.Text = "Tara"
    Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader15.Width = 65
    '
    'ColumnHeader16
    '
    Me.ColumnHeader16.Text = "Neto"
    Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader16.Width = 65
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlEmbarque1)
    Me.Panel1.Controls.Add(Me.btnexportar)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.btnimportar)
    Me.Panel1.Controls.Add(Me.lvresumen)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(571, 132)
    Me.Panel1.TabIndex = 0
    '
    'btnexportar
    '
    Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnexportar.Location = New System.Drawing.Point(136, 4)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(75, 23)
    Me.btnexportar.TabIndex = 2
    Me.btnexportar.Text = "&Exportar"
    '
    'CtlEmbarque1
    '
    Me.CtlEmbarque1.Embarque = Nothing
    Me.CtlEmbarque1.Location = New System.Drawing.Point(7, 23)
    Me.CtlEmbarque1.Name = "CtlEmbarque1"
    Me.CtlEmbarque1.Op = Nothing
    Me.CtlEmbarque1.Size = New System.Drawing.Size(123, 103)
    Me.CtlEmbarque1.TabIndex = 1
    '
    'CtlListaEmbarque
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "CtlListaEmbarque"
    Me.Size = New System.Drawing.Size(571, 414)
    Me.Panel2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents chklv As System.Windows.Forms.CheckBox
  Friend WithEvents lvcajas As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnimportar As System.Windows.Forms.Button
  Friend WithEvents lvresumen As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents CtlEmbarque1 As CtlEmbarque

End Class
