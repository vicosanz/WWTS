<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMetereologia
    Inherits Infoware.Consola.Base.FrmFormaBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.CtlTerreno1 = New Siembra.CtlTerreno()
        Me.LblDatePickerStd1 = New Infoware.Controles.Base.LblDatePickerStd()
        Me.btnMostrar = New Infoware.Controles.Base.ButtonStd()
        Me.DGMediciones = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.BSMediciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.HeaderStrip1.SuspendLayout()
        CType(Me.DGMediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSMediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.HeaderStrip1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 722)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnguardar)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 683)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 39)
        Me.Panel2.TabIndex = 4
        '
        'btnguardar
        '
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnguardar.Location = New System.Drawing.Point(12, 6)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 23)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "&Guardar"
        '
        'btncancelar
        '
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncancelar.Location = New System.Drawing.Point(106, 6)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 23)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "&Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGMediciones)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 479)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mediciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMostrar)
        Me.GroupBox1.Controls.Add(Me.LblDatePickerStd1)
        Me.GroupBox1.Controls.Add(Me.CtlTerreno1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Finca:"
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
        Me.HeaderStrip1.Size = New System.Drawing.Size(624, 25)
        Me.HeaderStrip1.TabIndex = 0
        Me.HeaderStrip1.Text = "HeaderStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripLabel1.Text = "Metereología"
        '
        'ofd
        '
        Me.ofd.FileName = "Seleccionar archivo"
        '
        'CtlTerreno1
        '
        Me.CtlTerreno1.Location = New System.Drawing.Point(162, 26)
        Me.CtlTerreno1.Name = "CtlTerreno1"
        Me.CtlTerreno1.Op = Nothing
        Me.CtlTerreno1.Size = New System.Drawing.Size(135, 116)
        Me.CtlTerreno1.TabIndex = 2
        Me.CtlTerreno1.Terreno = Nothing
        '
        'LblDatePickerStd1
        '
        Me.LblDatePickerStd1.Caption = "Fecha:"
        Me.LblDatePickerStd1.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
        Me.LblDatePickerStd1.Location = New System.Drawing.Point(12, 148)
        Me.LblDatePickerStd1.Name = "LblDatePickerStd1"
        Me.LblDatePickerStd1.Size = New System.Drawing.Size(330, 20)
        Me.LblDatePickerStd1.TabIndex = 3
        Me.LblDatePickerStd1.Value = New Date(2021, 10, 6, 18, 3, 46, 754)
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(361, 145)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'DGMediciones
        '
        Me.DGMediciones.AgruparRepetidos = False
        Me.DGMediciones.AllowUserToAddRows = False
        Me.DGMediciones.AllowUserToDeleteRows = False
        Me.DGMediciones.AutoGenerateColumns = False
        Me.DGMediciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMediciones.DataSource = Me.BSMediciones
        Me.DGMediciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGMediciones.Location = New System.Drawing.Point(3, 16)
        Me.DGMediciones.Name = "DGMediciones"
        Me.DGMediciones.Size = New System.Drawing.Size(618, 460)
        Me.DGMediciones.TabIndex = 2
        '
        'FrmMetereologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 722)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMetereologia"
        Me.Text = "Metereología"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.HeaderStrip1.ResumeLayout(False)
        Me.HeaderStrip1.PerformLayout()
        CType(Me.DGMediciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSMediciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents DGMediciones As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents BSMediciones As BindingSource
    Friend WithEvents btnMostrar As Infoware.Controles.Base.ButtonStd
    Friend WithEvents LblDatePickerStd1 As Infoware.Controles.Base.LblDatePickerStd
    Friend WithEvents CtlTerreno1 As CtlTerreno
End Class
