<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoCliente
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.chk_formapago = New Infoware.Controles.Base.CheckBoxStd()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.grplistaprecios = New System.Windows.Forms.GroupBox()
    Me.DGListaPrecios = New System.Windows.Forms.DataGridView()
    Me.BindingSourceListaPrecios = New System.Windows.Forms.BindingSource(Me.components)
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.chk_tipoprecio = New Infoware.Controles.Base.CheckBoxStd()
    Me.CtlPersona1 = New WWTS.General.Controles.CtlPersona()
    Me.ComboBoxFormaPago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.CtlBuscaEmpleado1 = New WWTS.General.Controles.CtlBuscaEmpleado()
    Me.ComboBoxTipoPrecio = New WWTS.General.Controles.ComboBoxParametroDet()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.grplistaprecios.SuspendLayout()
    CType(Me.DGListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSourceListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 49)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(650, 514)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlPersona1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(642, 488)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Datos principales"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.chk_formapago)
    Me.TabPage2.Controls.Add(Me.ComboBoxFormaPago)
    Me.TabPage2.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(642, 488)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Adicionales"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'chk_formapago
    '
    Me.chk_formapago.AutoSize = True
    Me.chk_formapago.BackColor = System.Drawing.Color.Transparent
    Me.chk_formapago.ForeColor = System.Drawing.SystemColors.ControlText
    Me.chk_formapago.Location = New System.Drawing.Point(8, 39)
    Me.chk_formapago.Name = "chk_formapago"
    Me.chk_formapago.Size = New System.Drawing.Size(97, 17)
    Me.chk_formapago.TabIndex = 1
    Me.chk_formapago.Text = "Forma de pago"
    Me.chk_formapago.UseVisualStyleBackColor = False
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.grplistaprecios)
    Me.TabPage3.Controls.Add(Me.Panel1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(642, 488)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Lista de precio"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'grplistaprecios
    '
    Me.grplistaprecios.Controls.Add(Me.DGListaPrecios)
    Me.grplistaprecios.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grplistaprecios.Location = New System.Drawing.Point(3, 34)
    Me.grplistaprecios.Name = "grplistaprecios"
    Me.grplistaprecios.Size = New System.Drawing.Size(636, 451)
    Me.grplistaprecios.TabIndex = 1
    Me.grplistaprecios.TabStop = False
    Me.grplistaprecios.Text = "Lista de precios"
    '
    'DGListaPrecios
    '
    Me.DGListaPrecios.AllowUserToAddRows = False
    Me.DGListaPrecios.AllowUserToDeleteRows = False
    Me.DGListaPrecios.AutoGenerateColumns = False
    Me.DGListaPrecios.BackgroundColor = System.Drawing.SystemColors.Window
    Me.DGListaPrecios.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.DGListaPrecios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DGListaPrecios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DGListaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DGListaPrecios.DataSource = Me.BindingSourceListaPrecios
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DGListaPrecios.DefaultCellStyle = DataGridViewCellStyle2
    Me.DGListaPrecios.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DGListaPrecios.Location = New System.Drawing.Point(3, 16)
    Me.DGListaPrecios.MultiSelect = False
    Me.DGListaPrecios.Name = "DGListaPrecios"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DGListaPrecios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DGListaPrecios.RowTemplate.Height = 25
    Me.DGListaPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.DGListaPrecios.Size = New System.Drawing.Size(630, 432)
    Me.DGListaPrecios.StandardTab = True
    Me.DGListaPrecios.TabIndex = 0
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chk_tipoprecio)
    Me.Panel1.Controls.Add(Me.ComboBoxTipoPrecio)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(636, 31)
    Me.Panel1.TabIndex = 0
    '
    'chk_tipoprecio
    '
    Me.chk_tipoprecio.AutoSize = True
    Me.chk_tipoprecio.BackColor = System.Drawing.Color.Transparent
    Me.chk_tipoprecio.ForeColor = System.Drawing.SystemColors.ControlText
    Me.chk_tipoprecio.Location = New System.Drawing.Point(7, 8)
    Me.chk_tipoprecio.Name = "chk_tipoprecio"
    Me.chk_tipoprecio.Size = New System.Drawing.Size(119, 17)
    Me.chk_tipoprecio.TabIndex = 0
    Me.chk_tipoprecio.Text = "Facturar siempre de"
    Me.chk_tipoprecio.UseVisualStyleBackColor = False
    '
    'CtlPersona1
    '
    Me.CtlPersona1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPersona1.Entidad = Nothing
    Me.CtlPersona1.Location = New System.Drawing.Point(3, 3)
    Me.CtlPersona1.Name = "CtlPersona1"
    Me.CtlPersona1.PuedeElegirTipoEntidad = False
    Me.CtlPersona1.PuedeRegistrarPersonacomo = False
    Me.CtlPersona1.PuedeSRI = True
    Me.CtlPersona1.Size = New System.Drawing.Size(636, 482)
    Me.CtlPersona1.TabIndex = 0
    '
    'ComboBoxFormaPago
    '
    Me.ComboBoxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxFormaPago.Enabled = False
    Me.ComboBoxFormaPago.FormattingEnabled = True
    Me.ComboBoxFormaPago.Location = New System.Drawing.Point(131, 37)
    Me.ComboBoxFormaPago.Name = "ComboBoxFormaPago"
    Me.ComboBoxFormaPago.OperadorDatos = Nothing
    Me.ComboBoxFormaPago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoPrecio
    Me.ComboBoxFormaPago.ParametroDet = Nothing
    Me.ComboBoxFormaPago.PuedeActualizar = True
    Me.ComboBoxFormaPago.PuedeEliminar = True
    Me.ComboBoxFormaPago.PuedeModificar = True
    Me.ComboBoxFormaPago.PuedeNuevo = True
    Me.ComboBoxFormaPago.Size = New System.Drawing.Size(191, 21)
    Me.ComboBoxFormaPago.TabIndex = 2
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Vendedor:"
    Me.CtlBuscaEmpleado1.ItemText = "Vendedor:"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(8, 6)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(314, 25)
    Me.CtlBuscaEmpleado1.TabIndex = 0
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = WWTS.General.Controles.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'ComboBoxTipoPrecio
    '
    Me.ComboBoxTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoPrecio.Enabled = False
    Me.ComboBoxTipoPrecio.FormattingEnabled = True
    Me.ComboBoxTipoPrecio.Location = New System.Drawing.Point(130, 6)
    Me.ComboBoxTipoPrecio.Name = "ComboBoxTipoPrecio"
    Me.ComboBoxTipoPrecio.OperadorDatos = Nothing
    Me.ComboBoxTipoPrecio.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoPrecio
    Me.ComboBoxTipoPrecio.ParametroDet = Nothing
    Me.ComboBoxTipoPrecio.PuedeActualizar = True
    Me.ComboBoxTipoPrecio.PuedeEliminar = True
    Me.ComboBoxTipoPrecio.PuedeModificar = True
    Me.ComboBoxTipoPrecio.PuedeNuevo = True
    Me.ComboBoxTipoPrecio.Size = New System.Drawing.Size(191, 21)
    Me.ComboBoxTipoPrecio.TabIndex = 1
    '
    'FrmMantenimientoCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(650, 563)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "FrmMantenimientoCliente"
    Me.PuedeGuardaryCerrar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
    Me.grplistaprecios.ResumeLayout(False)
    CType(Me.DGListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSourceListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlPersona1 As WWTS.General.Controles.CtlPersona
  Friend WithEvents CtlBuscaEmpleado1 As WWTS.General.Controles.CtlBuscaEmpleado
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents chk_tipoprecio As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents ComboBoxTipoPrecio As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents chk_formapago As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents ComboBoxFormaPago As ComboBoxParametroDet
  Friend WithEvents TabPage3 As TabPage
  Friend WithEvents grplistaprecios As GroupBox
  Private WithEvents DGListaPrecios As DataGridView
  Friend WithEvents Panel1 As Panel
  Friend WithEvents BindingSourceListaPrecios As BindingSource
End Class
