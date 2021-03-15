<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConciliacion
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
    Me.components = New System.ComponentModel.Container()
    Me.Pnlcuerpo = New System.Windows.Forms.Panel()
    Me.CboCtaBancaria = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboBanco = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.btnEliminar = New Infoware.Controles.Base.ButtonStd()
    Me.btnProcesar = New Infoware.Controles.Base.ButtonStd()
    Me.btnbuscararch = New Infoware.Controles.Base.ButtonStd()
    Me.txtarchivo = New Infoware.Controles.Base.TextBoxStd()
    Me.lblmensaje = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.ofd = New System.Windows.Forms.OpenFileDialog()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Pnlcuerpo.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Pnlcuerpo
    '
    Me.Pnlcuerpo.Controls.Add(Me.CboCtaBancaria)
    Me.Pnlcuerpo.Controls.Add(Me.cboBanco)
    Me.Pnlcuerpo.Controls.Add(Me.btnEliminar)
    Me.Pnlcuerpo.Controls.Add(Me.btnProcesar)
    Me.Pnlcuerpo.Controls.Add(Me.btnbuscararch)
    Me.Pnlcuerpo.Controls.Add(Me.txtarchivo)
    Me.Pnlcuerpo.Controls.Add(Me.lblmensaje)
    Me.Pnlcuerpo.Controls.Add(Me.Label3)
    Me.Pnlcuerpo.Controls.Add(Me.Label2)
    Me.Pnlcuerpo.Controls.Add(Me.Label1)
    Me.Pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.Pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.Pnlcuerpo.Margin = New System.Windows.Forms.Padding(4)
    Me.Pnlcuerpo.Name = "Pnlcuerpo"
    Me.Pnlcuerpo.Size = New System.Drawing.Size(845, 567)
    Me.Pnlcuerpo.TabIndex = 0
    '
    'CboCtaBancaria
    '
    Me.CboCtaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CboCtaBancaria.FormattingEnabled = True
    Me.CboCtaBancaria.Location = New System.Drawing.Point(136, 167)
    Me.CboCtaBancaria.Name = "CboCtaBancaria"
    Me.CboCtaBancaria.OperadorDatos = Nothing
    Me.CboCtaBancaria.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CboCtaBancaria.ParametroDet = Nothing
    Me.CboCtaBancaria.PuedeActualizar = True
    Me.CboCtaBancaria.PuedeEliminar = True
    Me.CboCtaBancaria.PuedeModificar = True
    Me.CboCtaBancaria.PuedeNuevo = True
    Me.CboCtaBancaria.Size = New System.Drawing.Size(265, 24)
    Me.CboCtaBancaria.TabIndex = 1011
    '
    'cboBanco
    '
    Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboBanco.FormattingEnabled = True
    Me.cboBanco.Location = New System.Drawing.Point(136, 137)
    Me.cboBanco.Name = "cboBanco"
    Me.cboBanco.OperadorDatos = Nothing
    Me.cboBanco.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboBanco.ParametroDet = Nothing
    Me.cboBanco.PuedeActualizar = True
    Me.cboBanco.PuedeEliminar = True
    Me.cboBanco.PuedeModificar = True
    Me.cboBanco.PuedeNuevo = True
    Me.cboBanco.Size = New System.Drawing.Size(265, 24)
    Me.cboBanco.TabIndex = 1011
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(272, 257)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(120, 23)
    Me.btnEliminar.TabIndex = 1010
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'btnProcesar
    '
    Me.btnProcesar.Location = New System.Drawing.Point(136, 257)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(120, 23)
    Me.btnProcesar.TabIndex = 1010
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.UseVisualStyleBackColor = True
    '
    'btnbuscararch
    '
    Me.btnbuscararch.Location = New System.Drawing.Point(410, 106)
    Me.btnbuscararch.Margin = New System.Windows.Forms.Padding(4)
    Me.btnbuscararch.Name = "btnbuscararch"
    Me.btnbuscararch.Size = New System.Drawing.Size(26, 23)
    Me.btnbuscararch.TabIndex = 1009
    Me.btnbuscararch.Text = "..."
    '
    'txtarchivo
    '
    Me.txtarchivo.Location = New System.Drawing.Point(136, 108)
    Me.txtarchivo.Margin = New System.Windows.Forms.Padding(4)
    Me.txtarchivo.Mensaje = ""
    Me.txtarchivo.Name = "txtarchivo"
    Me.txtarchivo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtarchivo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtarchivo.PromptText = ""
    Me.txtarchivo.Size = New System.Drawing.Size(265, 22)
    Me.txtarchivo.TabIndex = 1008
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 31)
    Me.lblmensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(845, 54)
    Me.lblmensaje.TabIndex = 1006
    Me.lblmensaje.Text = "Seleccione el archivo de movimientos generado en el Banco del Pichincha para real" & _
    "izar una carga masiva de transacciones."
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(13, 170)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(116, 17)
    Me.Label3.TabIndex = 1007
    Me.Label3.Text = "Cuenta bancaria:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(13, 140)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(52, 17)
    Me.Label2.TabIndex = 1007
    Me.Label2.Text = "Banco:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 112)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(59, 17)
    Me.Label1.TabIndex = 1007
    Me.Label1.Text = "Archivo:"
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(845, 31)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(143, 28)
    Me.ToolStripLabel1.Text = "Configuración"
    '
    'ofd
    '
    Me.ofd.Filter = "Archivos de Microsoft Excel (*.xls, *.xlsx, *.xlsm)|*.xls;*.xlsx;*.xlsm|Todos los" & _
    " archivos (*.*)|*.*"
    Me.ofd.Title = "Seleccionar formato de contrato"
    '
    'FrmConciliacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(845, 567)
    Me.Controls.Add(Me.Pnlcuerpo)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "FrmConciliacion"
    Me.Text = "Configuración"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Pnlcuerpo.ResumeLayout(False)
    Me.Pnlcuerpo.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnbuscararch As Infoware.Controles.Base.ButtonStd
  Friend WithEvents txtarchivo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnProcesar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnEliminar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
  Friend WithEvents CboCtaBancaria As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents cboBanco As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
