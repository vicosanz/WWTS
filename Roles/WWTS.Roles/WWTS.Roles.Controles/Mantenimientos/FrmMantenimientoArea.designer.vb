<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoArea
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pnlcargos = New System.Windows.Forms.Panel()
    Me.DataGridView2 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnnuevocargo = New System.Windows.Forms.ToolStripButton()
    Me.btnmodificarcargo = New System.Windows.Forms.ToolStripButton()
    Me.btneliminarcargo = New System.Windows.Forms.ToolStripButton()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cbodepartamento = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboseccion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.cboarea = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.txtdotacion = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnlcargos.SuspendLayout()
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip2.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlcargos)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(880, 313)
    Me.Panel1.TabIndex = 3
    '
    'pnlcargos
    '
    Me.pnlcargos.Controls.Add(Me.DataGridView2)
    Me.pnlcargos.Controls.Add(Me.HeaderStrip2)
    Me.pnlcargos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcargos.Location = New System.Drawing.Point(0, 124)
    Me.pnlcargos.Name = "pnlcargos"
    Me.pnlcargos.Size = New System.Drawing.Size(880, 189)
    Me.pnlcargos.TabIndex = 1
    '
    'DataGridView2
    '
    Me.DataGridView2.AgruparRepetidos = False
    Me.DataGridView2.AllowUserToAddRows = False
    Me.DataGridView2.AllowUserToDeleteRows = False
    Me.DataGridView2.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27})
    Me.DataGridView2.DataSource = Me.BindingSource2
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView2.Location = New System.Drawing.Point(0, 21)
    Me.DataGridView2.Name = "DataGridView2"
    Me.DataGridView2.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridView2.Size = New System.Drawing.Size(880, 168)
    Me.DataGridView2.TabIndex = 1
    '
    'DataGridViewTextBoxColumn26
    '
    Me.DataGridViewTextBoxColumn26.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
    Me.DataGridViewTextBoxColumn26.ReadOnly = True
    '
    'DataGridViewTextBoxColumn27
    '
    Me.DataGridViewTextBoxColumn27.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
    Me.DataGridViewTextBoxColumn27.ReadOnly = True
    '
    'HeaderStrip2
    '
    Me.HeaderStrip2.AutoSize = False
    Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
    Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
    Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.btnnuevocargo, Me.btnmodificarcargo, Me.btneliminarcargo})
    Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip2.Name = "HeaderStrip2"
    Me.HeaderStrip2.Size = New System.Drawing.Size(880, 21)
    Me.HeaderStrip2.TabIndex = 0
    Me.HeaderStrip2.Text = "Opciones"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(44, 18)
    Me.ToolStripLabel2.Text = "Cargos"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 21)
    '
    'btnnuevocargo
    '
    Me.btnnuevocargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevocargo.Image = My.Resources.Resources._new
    Me.btnnuevocargo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevocargo.Name = "btnnuevocargo"
    Me.btnnuevocargo.Size = New System.Drawing.Size(23, 18)
    Me.btnnuevocargo.Text = "Nuevo"
    '
    'btnmodificarcargo
    '
    Me.btnmodificarcargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnmodificarcargo.Image = My.Resources.Resources.open
    Me.btnmodificarcargo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnmodificarcargo.Name = "btnmodificarcargo"
    Me.btnmodificarcargo.Size = New System.Drawing.Size(23, 18)
    Me.btnmodificarcargo.Text = "Abrir"
    '
    'btneliminarcargo
    '
    Me.btneliminarcargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliminarcargo.Image = My.Resources.Resources.delete
    Me.btneliminarcargo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliminarcargo.Name = "btneliminarcargo"
    Me.btneliminarcargo.Size = New System.Drawing.Size(23, 18)
    Me.btneliminarcargo.Text = "Eliminar"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.cbodepartamento)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.cboseccion)
    Me.Panel2.Controls.Add(Me.cboarea)
    Me.Panel2.Controls.Add(Me.txtdotacion)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(880, 124)
    Me.Panel2.TabIndex = 0
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 97)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(53, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Dotación:"
    '
    'cbodepartamento
    '
    Me.cbodepartamento.AbriralEntrar = False
    Me.cbodepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbodepartamento.FormattingEnabled = True
    Me.cbodepartamento.Location = New System.Drawing.Point(102, 38)
    Me.cbodepartamento.Name = "cbodepartamento"
    Me.cbodepartamento.OperadorDatos = Nothing
    Me.cbodepartamento.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbodepartamento.ParametroDet = Nothing
    Me.cbodepartamento.PuedeActualizar = True
    Me.cbodepartamento.PuedeEliminar = True
    Me.cbodepartamento.PuedeModificar = True
    Me.cbodepartamento.PuedeNuevo = True
    Me.cbodepartamento.Size = New System.Drawing.Size(130, 21)
    Me.cbodepartamento.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Sección:"
    '
    'cboseccion
    '
    Me.cboseccion.AbriralEntrar = False
    Me.cboseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboseccion.FormattingEnabled = True
    Me.cboseccion.Location = New System.Drawing.Point(102, 10)
    Me.cboseccion.Name = "cboseccion"
    Me.cboseccion.OperadorDatos = Nothing
    Me.cboseccion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Seccion
    Me.cboseccion.ParametroDet = Nothing
    Me.cboseccion.PuedeActualizar = True
    Me.cboseccion.PuedeEliminar = True
    Me.cboseccion.PuedeModificar = True
    Me.cboseccion.PuedeNuevo = True
    Me.cboseccion.Size = New System.Drawing.Size(130, 21)
    Me.cboseccion.TabIndex = 1
    '
    'cboarea
    '
    Me.cboarea.AbriralEntrar = False
    Me.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboarea.FormattingEnabled = True
    Me.cboarea.Location = New System.Drawing.Point(102, 66)
    Me.cboarea.Name = "cboarea"
    Me.cboarea.OperadorDatos = Nothing
    Me.cboarea.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.Area
    Me.cboarea.ParametroDet = Nothing
    Me.cboarea.PuedeActualizar = True
    Me.cboarea.PuedeEliminar = True
    Me.cboarea.PuedeModificar = True
    Me.cboarea.PuedeNuevo = True
    Me.cboarea.Size = New System.Drawing.Size(130, 21)
    Me.cboarea.TabIndex = 5
    '
    'txtdotacion
    '
    Me.txtdotacion.Location = New System.Drawing.Point(102, 94)
    Me.txtdotacion.Mensaje = ""
    Me.txtdotacion.Name = "txtdotacion"
    Me.txtdotacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdotacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdotacion.PromptText = ""
    Me.txtdotacion.Size = New System.Drawing.Size(75, 20)
    Me.txtdotacion.TabIndex = 7
    Me.txtdotacion.Text = "0"
    Me.txtdotacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdotacion.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtdotacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtdotacion.Value = 0.0R
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 41)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(77, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Departamento:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 69)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(32, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Área:"
    '
    'DataGridViewTextBoxColumn25
    '
    Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
    Me.DataGridViewTextBoxColumn25.ReadOnly = True
    '
    'DataGridViewTextBoxColumn24
    '
    Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
    Me.DataGridViewTextBoxColumn24.ReadOnly = True
    '
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    Me.DataGridViewTextBoxColumn23.ReadOnly = True
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    Me.DataGridViewTextBoxColumn22.ReadOnly = True
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    Me.DataGridViewTextBoxColumn21.ReadOnly = True
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    Me.DataGridViewTextBoxColumn20.ReadOnly = True
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    Me.DataGridViewTextBoxColumn19.ReadOnly = True
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.ReadOnly = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.ReadOnly = True
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.ReadOnly = True
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.ReadOnly = True
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.ReadOnly = True
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.ReadOnly = True
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.ReadOnly = True
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'FrmMantenimientoArea
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(880, 362)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoArea"
    Me.PuedeGuardaryCerrar = True
    Me.PuedeGuardaryNuevo = True
    Me.PuedeMover = True
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Asignar Área a Sección"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.pnlcargos.ResumeLayout(False)
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip2.ResumeLayout(False)
    Me.HeaderStrip2.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtdotacion As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboarea As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboseccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents DataGridView2 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnnuevocargo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliminarcargo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnmodificarcargo As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
  Friend WithEvents pnlcargos As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cbodepartamento As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
