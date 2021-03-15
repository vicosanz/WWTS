<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoContrato
  Inherits Infoware.Consola.Base.FrmDialogoBase

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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.txtvalorssdf = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtvalorslv = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtvalorhora = New Infoware.Controles.Base.TextBoxCalculator()
    Me.lblvalorhora = New System.Windows.Forms.Label()
    Me.lblsoblv = New System.Windows.Forms.Label()
    Me.lblsobsdf = New System.Windows.Forms.Label()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.txttiempom = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cboperpago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cbotipocontrato = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ofd = New System.Windows.Forms.OpenFileDialog()
    Me.pnlvalorhora = New System.Windows.Forms.Panel()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.chkMensualizarFR = New System.Windows.Forms.CheckBox()
    Me.chkMensualizarVac = New System.Windows.Forms.CheckBox()
    Me.chkMensualizarD4 = New System.Windows.Forms.CheckBox()
    Me.chkMensualizarD3 = New System.Windows.Forms.CheckBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.txthorassemanales = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txthorasdiarias = New Infoware.Controles.Base.TextBoxCalculator()
    Me.chkficharojadespido = New System.Windows.Forms.CheckBox()
    Me.chkturnosrotativos = New System.Windows.Forms.CheckBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.chkficharojarenuncia = New System.Windows.Forms.CheckBox()
    Me.pnlnodestajo = New System.Windows.Forms.Panel()
    Me.btnNuevoFormato = New Infoware.Controles.Base.ButtonStd()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.BSFormatos = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtSueldoMaximo = New Infoware.Controles.Base.TextBoxCalculator()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.pnlvalorhora.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.pnlnodestajo.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSFormatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtvalorssdf
    '
    Me.txtvalorssdf.Location = New System.Drawing.Point(132, 55)
    Me.txtvalorssdf.Mensaje = ""
    Me.txtvalorssdf.Name = "txtvalorssdf"
    Me.txtvalorssdf.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalorssdf.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalorssdf.PromptText = ""
    Me.txtvalorssdf.Size = New System.Drawing.Size(92, 20)
    Me.txtvalorssdf.TabIndex = 5
    Me.txtvalorssdf.Text = "0,00"
    Me.txtvalorssdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalorssdf.Value = 0.0R
    '
    'txtvalorslv
    '
    Me.txtvalorslv.Location = New System.Drawing.Point(132, 29)
    Me.txtvalorslv.Mensaje = ""
    Me.txtvalorslv.Name = "txtvalorslv"
    Me.txtvalorslv.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalorslv.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalorslv.PromptText = ""
    Me.txtvalorslv.Size = New System.Drawing.Size(92, 20)
    Me.txtvalorslv.TabIndex = 3
    Me.txtvalorslv.Text = "0,00"
    Me.txtvalorslv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalorslv.Value = 0.0R
    '
    'txtvalorhora
    '
    Me.txtvalorhora.Location = New System.Drawing.Point(132, 3)
    Me.txtvalorhora.Mensaje = ""
    Me.txtvalorhora.Name = "txtvalorhora"
    Me.txtvalorhora.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalorhora.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalorhora.PromptText = ""
    Me.txtvalorhora.Size = New System.Drawing.Size(92, 20)
    Me.txtvalorhora.TabIndex = 1
    Me.txtvalorhora.Text = "0,00"
    Me.txtvalorhora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalorhora.Value = 0.0R
    '
    'lblvalorhora
    '
    Me.lblvalorhora.Location = New System.Drawing.Point(12, 6)
    Me.lblvalorhora.Name = "lblvalorhora"
    Me.lblvalorhora.Size = New System.Drawing.Size(120, 20)
    Me.lblvalorhora.TabIndex = 0
    Me.lblvalorhora.Text = "Valor hora:"
    '
    'lblsoblv
    '
    Me.lblsoblv.Location = New System.Drawing.Point(12, 32)
    Me.lblsoblv.Name = "lblsoblv"
    Me.lblsoblv.Size = New System.Drawing.Size(120, 20)
    Me.lblsoblv.TabIndex = 2
    Me.lblsoblv.Text = "Valor Sob. L-V"
    '
    'lblsobsdf
    '
    Me.lblsobsdf.Location = New System.Drawing.Point(12, 58)
    Me.lblsobsdf.Name = "lblsobsdf"
    Me.lblsobsdf.Size = New System.Drawing.Size(120, 20)
    Me.lblsobsdf.TabIndex = 4
    Me.lblsobsdf.Text = "Valor Sob. S-D-F"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.txttiempom)
    Me.Panel2.Controls.Add(Me.Label6)
    Me.Panel2.Controls.Add(Me.Label5)
    Me.Panel2.Controls.Add(Me.cboperpago)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.cbotipocontrato)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.txtcodigo)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(616, 141)
    Me.Panel2.TabIndex = 0
    '
    'txttiempom
    '
    Me.txttiempom.Location = New System.Drawing.Point(132, 114)
    Me.txttiempom.Mensaje = ""
    Me.txttiempom.Name = "txttiempom"
    Me.txttiempom.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttiempom.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttiempom.PromptText = ""
    Me.txttiempom.Size = New System.Drawing.Size(38, 20)
    Me.txttiempom.TabIndex = 9
    Me.txttiempom.Text = "0"
    Me.txttiempom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttiempom.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txttiempom.Value = 0.0R
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(176, 117)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(48, 23)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "meses"
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(12, 117)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(120, 23)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Vigencia contrato:"
    '
    'cboperpago
    '
    Me.cboperpago.DisplayMember = "Descripcion"
    Me.cboperpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboperpago.Location = New System.Drawing.Point(132, 87)
    Me.cboperpago.Name = "cboperpago"
    Me.cboperpago.OperadorDatos = Nothing
    Me.cboperpago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboperpago.ParametroDet = Nothing
    Me.cboperpago.PuedeActualizar = True
    Me.cboperpago.PuedeEliminar = True
    Me.cboperpago.PuedeModificar = True
    Me.cboperpago.PuedeNuevo = True
    Me.cboperpago.Size = New System.Drawing.Size(150, 21)
    Me.cboperpago.TabIndex = 7
    Me.cboperpago.ValueMember = "Codigo"
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(12, 90)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(120, 23)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Periodo de pago:"
    '
    'cbotipocontrato
    '
    Me.cbotipocontrato.DisplayMember = "Descripcion"
    Me.cbotipocontrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipocontrato.Location = New System.Drawing.Point(132, 60)
    Me.cbotipocontrato.Name = "cbotipocontrato"
    Me.cbotipocontrato.OperadorDatos = Nothing
    Me.cbotipocontrato.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipocontrato.ParametroDet = Nothing
    Me.cbotipocontrato.PuedeActualizar = True
    Me.cbotipocontrato.PuedeEliminar = True
    Me.cbotipocontrato.PuedeModificar = True
    Me.cbotipocontrato.PuedeNuevo = True
    Me.cbotipocontrato.Size = New System.Drawing.Size(150, 21)
    Me.cbotipocontrato.TabIndex = 5
    Me.cbotipocontrato.ValueMember = "Codigo"
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(12, 63)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(120, 23)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Tipo de contrato:"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(12, 37)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(120, 23)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(132, 34)
    Me.txtdescripcion.MaxLength = 18
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(220, 20)
    Me.txtdescripcion.TabIndex = 3
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(132, 8)
    Me.txtcodigo.MaxLength = 5
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(54, 20)
    Me.txtcodigo.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(12, 11)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(120, 23)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'ofd
    '
    Me.ofd.FileName = "Seleccionar archivo"
    '
    'pnlvalorhora
    '
    Me.pnlvalorhora.Controls.Add(Me.txtvalorssdf)
    Me.pnlvalorhora.Controls.Add(Me.lblvalorhora)
    Me.pnlvalorhora.Controls.Add(Me.txtvalorslv)
    Me.pnlvalorhora.Controls.Add(Me.lblsobsdf)
    Me.pnlvalorhora.Controls.Add(Me.txtvalorhora)
    Me.pnlvalorhora.Controls.Add(Me.lblsoblv)
    Me.pnlvalorhora.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlvalorhora.Location = New System.Drawing.Point(0, 397)
    Me.pnlvalorhora.Name = "pnlvalorhora"
    Me.pnlvalorhora.Size = New System.Drawing.Size(616, 87)
    Me.pnlvalorhora.TabIndex = 3
    Me.pnlvalorhora.Visible = False
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.Label8)
    Me.Panel3.Controls.Add(Me.txtSueldoMaximo)
    Me.Panel3.Controls.Add(Me.chkMensualizarFR)
    Me.Panel3.Controls.Add(Me.chkMensualizarVac)
    Me.Panel3.Controls.Add(Me.chkMensualizarD4)
    Me.Panel3.Controls.Add(Me.chkMensualizarD3)
    Me.Panel3.Controls.Add(Me.Label14)
    Me.Panel3.Controls.Add(Me.txthorassemanales)
    Me.Panel3.Controls.Add(Me.Label11)
    Me.Panel3.Controls.Add(Me.txthorasdiarias)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(0, 484)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(616, 180)
    Me.Panel3.TabIndex = 4
    '
    'chkMensualizarFR
    '
    Me.chkMensualizarFR.AutoSize = True
    Me.chkMensualizarFR.Location = New System.Drawing.Point(132, 125)
    Me.chkMensualizarFR.Name = "chkMensualizarFR"
    Me.chkMensualizarFR.Size = New System.Drawing.Size(173, 17)
    Me.chkMensualizarFR.TabIndex = 7
    Me.chkMensualizarFR.Text = "Mensualizar Fondo de Reserva"
    Me.chkMensualizarFR.UseVisualStyleBackColor = True
    '
    'chkMensualizarVac
    '
    Me.chkMensualizarVac.AutoSize = True
    Me.chkMensualizarVac.Location = New System.Drawing.Point(132, 102)
    Me.chkMensualizarVac.Name = "chkMensualizarVac"
    Me.chkMensualizarVac.Size = New System.Drawing.Size(141, 17)
    Me.chkMensualizarVac.TabIndex = 6
    Me.chkMensualizarVac.Text = "Mensualizar Vacaciones"
    Me.chkMensualizarVac.UseVisualStyleBackColor = True
    '
    'chkMensualizarD4
    '
    Me.chkMensualizarD4.AutoSize = True
    Me.chkMensualizarD4.Location = New System.Drawing.Point(132, 79)
    Me.chkMensualizarD4.Name = "chkMensualizarD4"
    Me.chkMensualizarD4.Size = New System.Drawing.Size(154, 17)
    Me.chkMensualizarD4.TabIndex = 5
    Me.chkMensualizarD4.Text = "Mensualizar Décimo cuarto"
    Me.chkMensualizarD4.UseVisualStyleBackColor = True
    '
    'chkMensualizarD3
    '
    Me.chkMensualizarD3.AutoSize = True
    Me.chkMensualizarD3.Location = New System.Drawing.Point(132, 56)
    Me.chkMensualizarD3.Name = "chkMensualizarD3"
    Me.chkMensualizarD3.Size = New System.Drawing.Size(157, 17)
    Me.chkMensualizarD3.TabIndex = 4
    Me.chkMensualizarD3.Text = "Mensualizar Décimo tercero"
    Me.chkMensualizarD3.UseVisualStyleBackColor = True
    '
    'Label14
    '
    Me.Label14.Location = New System.Drawing.Point(12, 32)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(120, 20)
    Me.Label14.TabIndex = 2
    Me.Label14.Text = "Horas Semanales:"
    '
    'txthorassemanales
    '
    Me.txthorassemanales.Location = New System.Drawing.Point(132, 29)
    Me.txthorassemanales.Mensaje = ""
    Me.txthorassemanales.Name = "txthorassemanales"
    Me.txthorassemanales.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txthorassemanales.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txthorassemanales.PromptText = ""
    Me.txthorassemanales.Size = New System.Drawing.Size(92, 20)
    Me.txthorassemanales.TabIndex = 3
    Me.txthorassemanales.Text = "0"
    Me.txthorassemanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthorassemanales.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txthorassemanales.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txthorassemanales.Value = 0.0R
    '
    'Label11
    '
    Me.Label11.Location = New System.Drawing.Point(12, 6)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(120, 20)
    Me.Label11.TabIndex = 0
    Me.Label11.Text = "Horas Diarias:"
    '
    'txthorasdiarias
    '
    Me.txthorasdiarias.Location = New System.Drawing.Point(132, 3)
    Me.txthorasdiarias.Mensaje = ""
    Me.txthorasdiarias.Name = "txthorasdiarias"
    Me.txthorasdiarias.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txthorasdiarias.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txthorasdiarias.PromptText = ""
    Me.txthorasdiarias.Size = New System.Drawing.Size(92, 20)
    Me.txthorasdiarias.TabIndex = 1
    Me.txthorasdiarias.Text = "0"
    Me.txthorasdiarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthorasdiarias.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txthorasdiarias.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txthorasdiarias.Value = 0.0R
    '
    'chkficharojadespido
    '
    Me.chkficharojadespido.AutoSize = True
    Me.chkficharojadespido.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkficharojadespido.Location = New System.Drawing.Point(132, 208)
    Me.chkficharojadespido.Name = "chkficharojadespido"
    Me.chkficharojadespido.Size = New System.Drawing.Size(139, 18)
    Me.chkficharojadespido.TabIndex = 4
    Me.chkficharojadespido.Text = "Ficha roja con despido"
    '
    'chkturnosrotativos
    '
    Me.chkturnosrotativos.AutoSize = True
    Me.chkturnosrotativos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkturnosrotativos.Location = New System.Drawing.Point(132, 232)
    Me.chkturnosrotativos.Name = "chkturnosrotativos"
    Me.chkturnosrotativos.Size = New System.Drawing.Size(108, 18)
    Me.chkturnosrotativos.TabIndex = 5
    Me.chkturnosrotativos.Text = "Turnos rotativos"
    '
    'Label7
    '
    Me.Label7.Location = New System.Drawing.Point(12, 9)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(120, 23)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Formatos:"
    '
    'chkficharojarenuncia
    '
    Me.chkficharojarenuncia.AutoSize = True
    Me.chkficharojarenuncia.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkficharojarenuncia.Location = New System.Drawing.Point(132, 184)
    Me.chkficharojarenuncia.Name = "chkficharojarenuncia"
    Me.chkficharojarenuncia.Size = New System.Drawing.Size(143, 18)
    Me.chkficharojarenuncia.TabIndex = 3
    Me.chkficharojarenuncia.Text = "Ficha roja con renuncia"
    '
    'pnlnodestajo
    '
    Me.pnlnodestajo.Controls.Add(Me.btnNuevoFormato)
    Me.pnlnodestajo.Controls.Add(Me.DataGridView1)
    Me.pnlnodestajo.Controls.Add(Me.chkficharojarenuncia)
    Me.pnlnodestajo.Controls.Add(Me.Label7)
    Me.pnlnodestajo.Controls.Add(Me.chkturnosrotativos)
    Me.pnlnodestajo.Controls.Add(Me.chkficharojadespido)
    Me.pnlnodestajo.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlnodestajo.Location = New System.Drawing.Point(0, 141)
    Me.pnlnodestajo.Name = "pnlnodestajo"
    Me.pnlnodestajo.Size = New System.Drawing.Size(616, 256)
    Me.pnlnodestajo.TabIndex = 1
    '
    'btnNuevoFormato
    '
    Me.btnNuevoFormato.Location = New System.Drawing.Point(132, 9)
    Me.btnNuevoFormato.Name = "btnNuevoFormato"
    Me.btnNuevoFormato.Size = New System.Drawing.Size(120, 23)
    Me.btnNuevoFormato.TabIndex = 1
    Me.btnNuevoFormato.Text = "Nuevo Formato"
    Me.btnNuevoFormato.UseVisualStyleBackColor = True
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.DataSource = Me.BSFormatos
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
    Me.DataGridView1.Location = New System.Drawing.Point(132, 38)
    Me.DataGridView1.Name = "DataGridView1"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.DataGridView1.RowHeadersVisible = False
    Me.DataGridView1.Size = New System.Drawing.Size(472, 140)
    Me.DataGridView1.TabIndex = 2
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(12, 151)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(120, 20)
    Me.Label8.TabIndex = 8
    Me.Label8.Text = "Sueldo máximo:"
    '
    'txtSueldoMaximo
    '
    Me.txtSueldoMaximo.Location = New System.Drawing.Point(132, 148)
    Me.txtSueldoMaximo.Mensaje = ""
    Me.txtSueldoMaximo.Name = "txtSueldoMaximo"
    Me.txtSueldoMaximo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSueldoMaximo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtSueldoMaximo.PromptText = ""
    Me.txtSueldoMaximo.Size = New System.Drawing.Size(92, 20)
    Me.txtSueldoMaximo.TabIndex = 9
    Me.txtSueldoMaximo.Text = "0"
    Me.txtSueldoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtSueldoMaximo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtSueldoMaximo.Value = 0.0R
    '
    'FrmTipoContrato
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(616, 703)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.pnlvalorhora)
    Me.Controls.Add(Me.pnlnodestajo)
    Me.Controls.Add(Me.Panel2)
    Me.Name = "FrmTipoContrato"
    Me.Text = "Tipos de contrato"
    Me.Controls.SetChildIndex(Me.Panel2, 0)
    Me.Controls.SetChildIndex(Me.pnlnodestajo, 0)
    Me.Controls.SetChildIndex(Me.pnlvalorhora, 0)
    Me.Controls.SetChildIndex(Me.Panel3, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnlvalorhora.ResumeLayout(False)
    Me.pnlvalorhora.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.pnlnodestajo.ResumeLayout(False)
    Me.pnlnodestajo.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSFormatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblvalorhora As System.Windows.Forms.Label
  Friend WithEvents lblsoblv As System.Windows.Forms.Label
  Friend WithEvents lblsobsdf As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cboperpago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cbotipocontrato As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtvalorssdf As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtvalorslv As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtvalorhora As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txttiempom As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
  Friend WithEvents pnlvalorhora As System.Windows.Forms.Panel
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txthorassemanales As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txthorasdiarias As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents chkficharojadespido As System.Windows.Forms.CheckBox
  Friend WithEvents chkturnosrotativos As System.Windows.Forms.CheckBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents chkficharojarenuncia As System.Windows.Forms.CheckBox
  Friend WithEvents pnlnodestajo As System.Windows.Forms.Panel
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents BSFormatos As System.Windows.Forms.BindingSource
  Friend WithEvents btnNuevoFormato As Infoware.Controles.Base.ButtonStd
  Friend WithEvents chkMensualizarVac As System.Windows.Forms.CheckBox
  Friend WithEvents chkMensualizarD4 As System.Windows.Forms.CheckBox
  Friend WithEvents chkMensualizarD3 As System.Windows.Forms.CheckBox
  Friend WithEvents chkMensualizarFR As System.Windows.Forms.CheckBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtSueldoMaximo As Infoware.Controles.Base.TextBoxCalculator

End Class
