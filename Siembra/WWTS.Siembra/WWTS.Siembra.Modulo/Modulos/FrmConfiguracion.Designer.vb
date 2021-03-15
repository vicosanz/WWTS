<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
  Inherits Infoware.Consola.Base.FrmFormaBase

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
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.btnguardar = New System.Windows.Forms.Button
    Me.btncancelar = New System.Windows.Forms.Button
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.btnrutaetiqueta = New System.Windows.Forms.Button
    Me.txttara = New Infoware.Controles.Base.TextBoxCalculator
    Me.txtempaque = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.txtbloques = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label2 = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.txtensarte = New Infoware.Controles.Base.TextBoxCalculator
    Me.Label1 = New System.Windows.Forms.Label
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.ofd = New System.Windows.Forms.OpenFileDialog
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Transparent
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.GroupBox3)
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.GroupBox1)
    Me.Panel1.Controls.Add(Me.HeaderStrip1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(462, 351)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btnguardar)
    Me.Panel2.Controls.Add(Me.btncancelar)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 239)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(462, 39)
    Me.Panel2.TabIndex = 4
    '
    'btnguardar
    '
    Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnguardar.Location = New System.Drawing.Point(114, 6)
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(75, 23)
    Me.btnguardar.TabIndex = 0
    Me.btnguardar.Text = "&Guardar"
    '
    'btncancelar
    '
    Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btncancelar.Location = New System.Drawing.Point(263, 6)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(75, 23)
    Me.btncancelar.TabIndex = 1
    Me.btncancelar.Text = "&Cancelar"
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.btnrutaetiqueta)
    Me.GroupBox3.Controls.Add(Me.txttara)
    Me.GroupBox3.Controls.Add(Me.txtempaque)
    Me.GroupBox3.Controls.Add(Me.Label5)
    Me.GroupBox3.Controls.Add(Me.Label4)
    Me.GroupBox3.Controls.Add(Me.Label3)
    Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox3.Location = New System.Drawing.Point(0, 131)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(462, 108)
    Me.GroupBox3.TabIndex = 3
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Rezago"
    '
    'btnrutaetiqueta
    '
    Me.btnrutaetiqueta.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnrutaetiqueta.Location = New System.Drawing.Point(149, 71)
    Me.btnrutaetiqueta.Name = "btnrutaetiqueta"
    Me.btnrutaetiqueta.Size = New System.Drawing.Size(282, 23)
    Me.btnrutaetiqueta.TabIndex = 5
    Me.btnrutaetiqueta.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'txttara
    '
    Me.txttara.Location = New System.Drawing.Point(149, 45)
    Me.txttara.Name = "txttara"
    Me.txttara.Size = New System.Drawing.Size(100, 20)
    Me.txttara.TabIndex = 3
    Me.txttara.Text = "0"
    Me.txttara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttara.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    '
    'txtempaque
    '
    Me.txtempaque.Location = New System.Drawing.Point(149, 19)
    Me.txtempaque.Name = "txtempaque"
    Me.txtempaque.Size = New System.Drawing.Size(100, 20)
    Me.txtempaque.TabIndex = 1
    Me.txtempaque.Text = "0"
    Me.txtempaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtempaque.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 74)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(117, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Ruta formato etiquetas:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 48)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(70, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Peso de tara:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 22)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(125, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Secuencial de empaque:"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txtbloques)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox2.Location = New System.Drawing.Point(0, 78)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(462, 53)
    Me.GroupBox2.TabIndex = 2
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Fermentación"
    '
    'txtbloques
    '
    Me.txtbloques.Location = New System.Drawing.Point(149, 19)
    Me.txtbloques.Name = "txtbloques"
    Me.txtbloques.Size = New System.Drawing.Size(100, 20)
    Me.txtbloques.TabIndex = 1
    Me.txtbloques.Text = "0"
    Me.txtbloques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtbloques.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 22)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(118, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Secuencial de bloques:"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtensarte)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(462, 53)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Ensarte/Zafadura"
    '
    'txtensarte
    '
    Me.txtensarte.Location = New System.Drawing.Point(149, 19)
    Me.txtensarte.Name = "txtensarte"
    Me.txtensarte.Size = New System.Drawing.Size(100, 20)
    Me.txtensarte.TabIndex = 1
    Me.txtensarte.Text = "0"
    Me.txtensarte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtensarte.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(116, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Secuencial de ensarte:"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(462, 25)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
    Me.ToolStripLabel1.Text = "Configuración"
    '
    'ofd
    '
    Me.ofd.FileName = "Seleccionar archivo"
    '
    'FrmConfiguracion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(462, 351)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmConfiguracion"
    Me.Text = "Configuración"
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents txtempaque As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents txtbloques As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtensarte As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txttara As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents btnrutaetiqueta As System.Windows.Forms.Button
  Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents btnguardar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
End Class
