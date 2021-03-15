<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoContratoOriginal
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
    Me.txtvalorssdf = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtvalorslv = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtvalorhora = New Infoware.Controles.Base.TextBoxCalculator()
    Me.lblvalorhora = New System.Windows.Forms.Label()
    Me.lblsoblv = New System.Windows.Forms.Label()
    Me.lblsobsdf = New System.Windows.Forms.Label()
    Me.pnlnodestajo = New System.Windows.Forms.Panel()
    Me.chkficharojarenuncia = New System.Windows.Forms.CheckBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.chkturnosrotativos = New System.Windows.Forms.CheckBox()
    Me.chkficharojadespido = New System.Windows.Forms.CheckBox()
    Me.btncertificado = New Infoware.Controles.Base.ButtonStd()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.btnllamada = New Infoware.Controles.Base.ButtonStd()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.btnsuspension = New Infoware.Controles.Base.ButtonStd()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btndespido = New Infoware.Controles.Base.ButtonStd()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.btnrenuncia = New Infoware.Controles.Base.ButtonStd()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.btncontrato = New Infoware.Controles.Base.ButtonStd()
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
    Me.Label14 = New System.Windows.Forms.Label()
    Me.txthorassemanales = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txthorasdiarias = New Infoware.Controles.Base.TextBoxCalculator()
    Me.pnlnodestajo.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.pnlvalorhora.SuspendLayout()
    Me.Panel3.SuspendLayout()
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
    Me.txtvalorssdf.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorssdf.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
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
    Me.txtvalorslv.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorslv.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
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
    Me.txtvalorhora.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorhora.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
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
    'pnlnodestajo
    '
    Me.pnlnodestajo.Controls.Add(Me.chkficharojarenuncia)
    Me.pnlnodestajo.Controls.Add(Me.Label7)
    Me.pnlnodestajo.Controls.Add(Me.chkturnosrotativos)
    Me.pnlnodestajo.Controls.Add(Me.chkficharojadespido)
    Me.pnlnodestajo.Controls.Add(Me.btncertificado)
    Me.pnlnodestajo.Controls.Add(Me.Label13)
    Me.pnlnodestajo.Controls.Add(Me.btnllamada)
    Me.pnlnodestajo.Controls.Add(Me.Label12)
    Me.pnlnodestajo.Controls.Add(Me.btnsuspension)
    Me.pnlnodestajo.Controls.Add(Me.Label10)
    Me.pnlnodestajo.Controls.Add(Me.btndespido)
    Me.pnlnodestajo.Controls.Add(Me.Label9)
    Me.pnlnodestajo.Controls.Add(Me.btnrenuncia)
    Me.pnlnodestajo.Controls.Add(Me.Label8)
    Me.pnlnodestajo.Controls.Add(Me.btncontrato)
    Me.pnlnodestajo.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlnodestajo.Location = New System.Drawing.Point(0, 141)
    Me.pnlnodestajo.Name = "pnlnodestajo"
    Me.pnlnodestajo.Size = New System.Drawing.Size(474, 256)
    Me.pnlnodestajo.TabIndex = 1
    '
    'chkficharojarenuncia
    '
    Me.chkficharojarenuncia.AutoSize = True
    Me.chkficharojarenuncia.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkficharojarenuncia.Location = New System.Drawing.Point(132, 122)
    Me.chkficharojarenuncia.Name = "chkficharojarenuncia"
    Me.chkficharojarenuncia.Size = New System.Drawing.Size(143, 18)
    Me.chkficharojarenuncia.TabIndex = 8
    Me.chkficharojarenuncia.Text = "Ficha roja con renuncia"
    '
    'Label7
    '
    Me.Label7.Location = New System.Drawing.Point(12, 9)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(120, 23)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Formato contrato:"
    '
    'chkturnosrotativos
    '
    Me.chkturnosrotativos.AutoSize = True
    Me.chkturnosrotativos.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkturnosrotativos.Location = New System.Drawing.Point(132, 170)
    Me.chkturnosrotativos.Name = "chkturnosrotativos"
    Me.chkturnosrotativos.Size = New System.Drawing.Size(108, 18)
    Me.chkturnosrotativos.TabIndex = 10
    Me.chkturnosrotativos.Text = "Turnos rotativos"
    '
    'chkficharojadespido
    '
    Me.chkficharojadespido.AutoSize = True
    Me.chkficharojadespido.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkficharojadespido.Location = New System.Drawing.Point(132, 146)
    Me.chkficharojadespido.Name = "chkficharojadespido"
    Me.chkficharojadespido.Size = New System.Drawing.Size(139, 18)
    Me.chkficharojadespido.TabIndex = 9
    Me.chkficharojadespido.Text = "Ficha roja con despido"
    '
    'btncertificado
    '
    Me.btncertificado.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btncertificado.Location = New System.Drawing.Point(132, 223)
    Me.btncertificado.Name = "btncertificado"
    Me.btncertificado.Size = New System.Drawing.Size(330, 23)
    Me.btncertificado.TabIndex = 14
    Me.btncertificado.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'Label13
    '
    Me.Label13.Location = New System.Drawing.Point(12, 226)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(120, 26)
    Me.Label13.TabIndex = 13
    Me.Label13.Text = "Formato certificado de trabajo:"
    '
    'btnllamada
    '
    Me.btnllamada.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnllamada.Location = New System.Drawing.Point(132, 194)
    Me.btnllamada.Name = "btnllamada"
    Me.btnllamada.Size = New System.Drawing.Size(330, 23)
    Me.btnllamada.TabIndex = 12
    Me.btnllamada.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(12, 197)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(120, 26)
    Me.Label12.TabIndex = 11
    Me.Label12.Text = "Formato llamada atención:"
    '
    'btnsuspension
    '
    Me.btnsuspension.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnsuspension.Location = New System.Drawing.Point(132, 93)
    Me.btnsuspension.Name = "btnsuspension"
    Me.btnsuspension.Size = New System.Drawing.Size(330, 23)
    Me.btnsuspension.TabIndex = 7
    Me.btnsuspension.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'Label10
    '
    Me.Label10.Location = New System.Drawing.Point(12, 96)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(120, 23)
    Me.Label10.TabIndex = 6
    Me.Label10.Text = "Formato suspensión:"
    '
    'btndespido
    '
    Me.btndespido.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btndespido.Location = New System.Drawing.Point(132, 64)
    Me.btndespido.Name = "btndespido"
    Me.btndespido.Size = New System.Drawing.Size(330, 23)
    Me.btndespido.TabIndex = 5
    Me.btndespido.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'Label9
    '
    Me.Label9.Location = New System.Drawing.Point(12, 67)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(120, 23)
    Me.Label9.TabIndex = 4
    Me.Label9.Text = "Formato despido:"
    '
    'btnrenuncia
    '
    Me.btnrenuncia.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnrenuncia.Location = New System.Drawing.Point(132, 35)
    Me.btnrenuncia.Name = "btnrenuncia"
    Me.btnrenuncia.Size = New System.Drawing.Size(330, 23)
    Me.btnrenuncia.TabIndex = 3
    Me.btnrenuncia.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(12, 38)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(120, 23)
    Me.Label8.TabIndex = 2
    Me.Label8.Text = "Formato renuncia:"
    '
    'btncontrato
    '
    Me.btncontrato.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btncontrato.Location = New System.Drawing.Point(132, 6)
    Me.btncontrato.Name = "btncontrato"
    Me.btncontrato.Size = New System.Drawing.Size(330, 23)
    Me.btncontrato.TabIndex = 1
    Me.btncontrato.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
    Me.Panel2.Size = New System.Drawing.Size(474, 141)
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
    Me.txttiempom.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
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
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
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
    Me.txtcodigo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
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
    Me.pnlvalorhora.Size = New System.Drawing.Size(474, 87)
    Me.pnlvalorhora.TabIndex = 3
    Me.pnlvalorhora.Visible = False
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.Label14)
    Me.Panel3.Controls.Add(Me.txthorassemanales)
    Me.Panel3.Controls.Add(Me.Label11)
    Me.Panel3.Controls.Add(Me.txthorasdiarias)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(0, 484)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(474, 60)
    Me.Panel3.TabIndex = 1001
    '
    'Label14
    '
    Me.Label14.Location = New System.Drawing.Point(12, 32)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(120, 20)
    Me.Label14.TabIndex = 4
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
    Me.txthorassemanales.TabIndex = 5
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
    Me.Label11.TabIndex = 2
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
    Me.txthorasdiarias.TabIndex = 3
    Me.txthorasdiarias.Text = "0"
    Me.txthorasdiarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txthorasdiarias.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txthorasdiarias.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txthorasdiarias.Value = 0.0R
    '
    'FrmTipoContrato
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(474, 593)
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
    Me.pnlnodestajo.ResumeLayout(False)
    Me.pnlnodestajo.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnlvalorhora.ResumeLayout(False)
    Me.pnlvalorhora.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblvalorhora As System.Windows.Forms.Label
  Friend WithEvents lblsoblv As System.Windows.Forms.Label
  Friend WithEvents lblsobsdf As System.Windows.Forms.Label
  Friend WithEvents pnlnodestajo As System.Windows.Forms.Panel
  Friend WithEvents chkficharojarenuncia As System.Windows.Forms.CheckBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents chkficharojadespido As System.Windows.Forms.CheckBox
  Friend WithEvents btnsuspension As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents btndespido As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents btnrenuncia As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents btncontrato As Infoware.Controles.Base.ButtonStd
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
  Friend WithEvents chkturnosrotativos As System.Windows.Forms.CheckBox
  Friend WithEvents btnllamada As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents btncertificado As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txthorassemanales As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txthorasdiarias As Infoware.Controles.Base.TextBoxCalculator

End Class
