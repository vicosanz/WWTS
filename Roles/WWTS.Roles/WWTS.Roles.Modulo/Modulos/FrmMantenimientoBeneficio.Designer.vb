<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoBeneficio
  Inherits Infoware.Consola.Base.FrmDialogoBase

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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtcedula = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtempleado = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtobservacion = New System.Windows.Forms.TextBox()
    Me.txtmonto = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtcodigo = New System.Windows.Forms.TextBox()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.BSdetalle = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtdias = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label7 = New System.Windows.Forms.Label()

    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 42)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Cédula:"
    '
    'txtcedula
    '
    Me.txtcedula.Enabled = False
    Me.txtcedula.Location = New System.Drawing.Point(115, 38)
    Me.txtcedula.Name = "txtcedula"
    Me.txtcedula.Size = New System.Drawing.Size(100, 20)
    Me.txtcedula.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 69)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(57, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Empleado:"
    '
    'txtempleado
    '
    Me.txtempleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtempleado.Enabled = False
    Me.txtempleado.Location = New System.Drawing.Point(115, 66)
    Me.txtempleado.Name = "txtempleado"
    Me.txtempleado.Size = New System.Drawing.Size(373, 20)
    Me.txtempleado.TabIndex = 5
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 96)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(40, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Monto:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 148)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(70, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Observación:"
    '
    'txtobservacion
    '
    Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtobservacion.Location = New System.Drawing.Point(115, 145)
    Me.txtobservacion.Multiline = True
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.Size = New System.Drawing.Size(373, 75)
    Me.txtobservacion.TabIndex = 11
    '
    'txtmonto
    '
    Me.txtmonto.Location = New System.Drawing.Point(115, 93)
    Me.txtmonto.Mensaje = ""
    Me.txtmonto.Name = "txtmonto"
    Me.txtmonto.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtmonto.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtmonto.PromptText = ""
    Me.txtmonto.Size = New System.Drawing.Size(100, 20)
    Me.txtmonto.TabIndex = 7
    Me.txtmonto.Text = "0,00"
    Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtmonto.Value = 0.0R
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 15)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(43, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Código:"
    '
    'txtcodigo
    '
    Me.txtcodigo.Enabled = False
    Me.txtcodigo.Location = New System.Drawing.Point(115, 12)
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
    Me.txtcodigo.TabIndex = 1
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
    Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.DataSource = Me.BSdetalle
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridView1.Location = New System.Drawing.Point(15, 244)
    Me.DataGridView1.Name = "DataGridView1"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridView1.RowHeadersVisible = False
    Me.DataGridView1.Size = New System.Drawing.Size(473, 256)
    Me.DataGridView1.TabIndex = 13
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(15, 227)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(40, 13)
    Me.Label6.TabIndex = 12
    Me.Label6.Text = "Detalle"
    '
    'txtdias
    '
    Me.txtdias.Location = New System.Drawing.Point(115, 119)
    Me.txtdias.Mensaje = ""
    Me.txtdias.Name = "txtdias"
    Me.txtdias.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdias.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdias.PromptText = ""
    Me.txtdias.Size = New System.Drawing.Size(100, 20)
    Me.txtdias.TabIndex = 9
    Me.txtdias.Text = "0"
    Me.txtdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdias.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtdias.Value = 0.0R
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 122)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(33, 13)
    Me.Label7.TabIndex = 8
    Me.Label7.Text = "Días:"
    '
    'FrmMantenimientoBeneficio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(500, 550)
    Me.Controls.Add(Me.txtdias)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.DataGridView1)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtmonto)
    Me.Controls.Add(Me.txtobservacion)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtempleado)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtcedula)
    Me.Name = "FrmMantenimientoBeneficio"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento Beneficio"
    Me.Controls.SetChildIndex(Me.txtcedula, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtempleado, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.txtobservacion, 0)
    Me.Controls.SetChildIndex(Me.txtmonto, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.DataGridView1, 0)
    Me.Controls.SetChildIndex(Me.Label6, 0)
    Me.Controls.SetChildIndex(Me.Label7, 0)
    Me.Controls.SetChildIndex(Me.txtdias, 0)

    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSdetalle, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtcedula As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtempleado As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
  Friend WithEvents txtmonto As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents BSdetalle As System.Windows.Forms.BindingSource
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtdias As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
