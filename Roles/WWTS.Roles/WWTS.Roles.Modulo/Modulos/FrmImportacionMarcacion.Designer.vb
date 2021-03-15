<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportacionMarcacion
  Inherits Infoware.Consola.Base.FrmFormaBase

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportacionMarcacion))
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.txtcodigosala = New Infoware.Controles.Base.TextBoxCalculator()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.fechahasta = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.fechadesde = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Button1 = New Infoware.Controles.Base.ButtonStd()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Panel2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.Panel2.Controls.Add(Me.txtcodigosala)
    Me.Panel2.Controls.Add(Me.GroupBox1)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.fechahasta)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.fechadesde)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(225, 474)
    Me.Panel2.TabIndex = 0
    '
    'txtcodigosala
    '
    Me.txtcodigosala.Location = New System.Drawing.Point(85, 127)
    Me.txtcodigosala.MaxLength = 2
    Me.txtcodigosala.Mensaje = ""
    Me.txtcodigosala.Name = "txtcodigosala"
    Me.txtcodigosala.NumeroDecimales = 0
    Me.txtcodigosala.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigosala.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigosala.PromptText = ""
    Me.txtcodigosala.Size = New System.Drawing.Size(120, 20)
    Me.txtcodigosala.TabIndex = 5
    Me.txtcodigosala.Text = "0"
    Me.txtcodigosala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcodigosala.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtcodigosala.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtcodigosala.Value = 0.0R
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Location = New System.Drawing.Point(10, 180)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(195, 144)
    Me.GroupBox1.TabIndex = 6
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Código de Sala"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 25)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(157, 39)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "   2  -  Magic Seven (Escobedo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   3  -  Central Park (Amazonas)"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(10, 130)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(67, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Código Sala:"
    '
    'fechahasta
    '
    Me.fechahasta.CustomFormat = "dd - MMMM - yyyy"
    Me.fechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.fechahasta.Location = New System.Drawing.Point(55, 87)
    Me.fechahasta.Name = "fechahasta"
    Me.fechahasta.Size = New System.Drawing.Size(150, 20)
    Me.fechahasta.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(10, 90)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Hasta:"
    '
    'fechadesde
    '
    Me.fechadesde.CustomFormat = "dd - MMMM - yyyy"
    Me.fechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.fechadesde.Location = New System.Drawing.Point(55, 47)
    Me.fechadesde.Name = "fechadesde"
    Me.fechadesde.Size = New System.Drawing.Size(150, 20)
    Me.fechadesde.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(10, 50)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Desde:"
    '
    'Button1
    '
    Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
    Me.Button1.Location = New System.Drawing.Point(419, 50)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(100, 25)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "Ejecutar"
    Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(300, 55)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(109, 13)
    Me.Label5.TabIndex = 1
    Me.Label5.Text = "Importar Marcaciones"
    '
    'FrmImportacionMarcacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(608, 474)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Panel2)
    Me.Name = "FrmImportacionMarcacion"
    Me.Text = "FrmImportacionMarcacion"
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents fechadesde As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents fechahasta As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Button1 As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtcodigosala As Infoware.Controles.Base.TextBoxCalculator
End Class
