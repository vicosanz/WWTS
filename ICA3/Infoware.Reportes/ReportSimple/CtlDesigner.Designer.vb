<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlDesigner
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlDesigner))
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.pnlbandaresumen = New System.Windows.Forms.Panel()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.btndelbr = New Infoware.Controles.Base.ButtonStd()
    Me.btnaddbr = New Infoware.Controles.Base.ButtonStd()
    Me.chkmostrarbarraresumen = New System.Windows.Forms.CheckBox()
    Me.pnlpiepagina = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Panel6 = New System.Windows.Forms.Panel()
    Me.btndelppag = New Infoware.Controles.Base.ButtonStd()
    Me.btnaddppag = New Infoware.Controles.Base.ButtonStd()
    Me.pnldetalles = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.btndeldet = New Infoware.Controles.Base.ButtonStd()
    Me.btnadddet = New Infoware.Controles.Base.ButtonStd()
    Me.CtlSeccionBandaResumen = New Infoware.Reportes.CtlSeccion()
    Me.CtlSeccionPiePagina = New Infoware.Reportes.CtlSeccion()
    Me.CtlSeccionDetalles = New Infoware.Reportes.CtlSeccion()
    Me.CtlSeccionEncabezado = New Infoware.Reportes.CtlSeccion()
    Me.CtlSeccionBandaTitulo = New Infoware.Reportes.CtlSeccion()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.cbopapel = New System.Windows.Forms.ComboBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.cboimpresoras = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.pnlbandatitulo = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.btndelbt = New Infoware.Controles.Base.ButtonStd()
    Me.btnaddbt = New Infoware.Controles.Base.ButtonStd()
    Me.chk_mostrarbarratitulo = New System.Windows.Forms.CheckBox()
    Me.pnlencabezado = New System.Windows.Forms.Panel()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.btndelenc = New Infoware.Controles.Base.ButtonStd()
    Me.btnaddenc = New Infoware.Controles.Base.ButtonStd()
    Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
    Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnabrir = New System.Windows.Forms.ToolStripButton()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.btnimprimir = New System.Windows.Forms.ToolStripButton()
    Me.lblnombrearchivo = New System.Windows.Forms.ToolStripLabel()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.pnlbandaresumen.SuspendLayout()
    Me.Panel7.SuspendLayout()
    Me.pnlpiepagina.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.pnldetalles.SuspendLayout()
    Me.Panel5.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.pnlbandatitulo.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.pnlencabezado.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.AutoSize = True
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 507.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.pnlbandaresumen, 1, 5)
    Me.TableLayoutPanel1.Controls.Add(Me.pnlpiepagina, 1, 4)
    Me.TableLayoutPanel1.Controls.Add(Me.pnldetalles, 1, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlSeccionBandaResumen, 0, 5)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlSeccionPiePagina, 0, 4)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlSeccionDetalles, 0, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlSeccionEncabezado, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlSeccionBandaTitulo, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.pnlbandatitulo, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.pnlencabezado, 1, 2)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 7
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(624, 466)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'pnlbandaresumen
    '
    Me.pnlbandaresumen.Controls.Add(Me.Label5)
    Me.pnlbandaresumen.Controls.Add(Me.Panel7)
    Me.pnlbandaresumen.Controls.Add(Me.chkmostrarbarraresumen)
    Me.pnlbandaresumen.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlbandaresumen.Location = New System.Drawing.Point(510, 377)
    Me.pnlbandaresumen.Name = "pnlbandaresumen"
    Me.pnlbandaresumen.Size = New System.Drawing.Size(111, 81)
    Me.pnlbandaresumen.TabIndex = 16
    '
    'Label5
    '
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label5.Location = New System.Drawing.Point(0, 40)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(111, 41)
    Me.Label5.TabIndex = 7
    Me.Label5.Text = "Banda de resumen"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel7
    '
    Me.Panel7.Controls.Add(Me.btndelbr)
    Me.Panel7.Controls.Add(Me.btnaddbr)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 17)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(111, 23)
    Me.Panel7.TabIndex = 9
    '
    'btndelbr
    '
    Me.btndelbr.Dock = System.Windows.Forms.DockStyle.Left
    Me.btndelbr.Location = New System.Drawing.Point(26, 0)
    Me.btndelbr.Name = "btndelbr"
    Me.btndelbr.Size = New System.Drawing.Size(26, 23)
    Me.btndelbr.TabIndex = 1
    Me.btndelbr.Text = "-"
    Me.btndelbr.UseVisualStyleBackColor = True
    '
    'btnaddbr
    '
    Me.btnaddbr.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnaddbr.Location = New System.Drawing.Point(0, 0)
    Me.btnaddbr.Name = "btnaddbr"
    Me.btnaddbr.Size = New System.Drawing.Size(26, 23)
    Me.btnaddbr.TabIndex = 0
    Me.btnaddbr.Text = "+"
    Me.btnaddbr.UseVisualStyleBackColor = True
    '
    'chkmostrarbarraresumen
    '
    Me.chkmostrarbarraresumen.AutoSize = True
    Me.chkmostrarbarraresumen.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkmostrarbarraresumen.Location = New System.Drawing.Point(0, 0)
    Me.chkmostrarbarraresumen.Name = "chkmostrarbarraresumen"
    Me.chkmostrarbarraresumen.Size = New System.Drawing.Size(111, 17)
    Me.chkmostrarbarraresumen.TabIndex = 10
    Me.chkmostrarbarraresumen.Text = "Mostrar barra resumen"
    Me.chkmostrarbarraresumen.UseVisualStyleBackColor = True
    '
    'pnlpiepagina
    '
    Me.pnlpiepagina.Controls.Add(Me.Label4)
    Me.pnlpiepagina.Controls.Add(Me.Panel6)
    Me.pnlpiepagina.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlpiepagina.Location = New System.Drawing.Point(510, 290)
    Me.pnlpiepagina.Name = "pnlpiepagina"
    Me.pnlpiepagina.Size = New System.Drawing.Size(111, 81)
    Me.pnlpiepagina.TabIndex = 15
    '
    'Label4
    '
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label4.Location = New System.Drawing.Point(0, 23)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(111, 58)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Pie de página"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel6
    '
    Me.Panel6.Controls.Add(Me.btndelppag)
    Me.Panel6.Controls.Add(Me.btnaddppag)
    Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel6.Location = New System.Drawing.Point(0, 0)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(111, 23)
    Me.Panel6.TabIndex = 9
    '
    'btndelppag
    '
    Me.btndelppag.Dock = System.Windows.Forms.DockStyle.Left
    Me.btndelppag.Location = New System.Drawing.Point(26, 0)
    Me.btndelppag.Name = "btndelppag"
    Me.btndelppag.Size = New System.Drawing.Size(26, 23)
    Me.btndelppag.TabIndex = 1
    Me.btndelppag.Text = "-"
    Me.btndelppag.UseVisualStyleBackColor = True
    '
    'btnaddppag
    '
    Me.btnaddppag.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnaddppag.Location = New System.Drawing.Point(0, 0)
    Me.btnaddppag.Name = "btnaddppag"
    Me.btnaddppag.Size = New System.Drawing.Size(26, 23)
    Me.btnaddppag.TabIndex = 0
    Me.btnaddppag.Text = "+"
    Me.btnaddppag.UseVisualStyleBackColor = True
    '
    'pnldetalles
    '
    Me.pnldetalles.Controls.Add(Me.Label3)
    Me.pnldetalles.Controls.Add(Me.Panel5)
    Me.pnldetalles.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnldetalles.Location = New System.Drawing.Point(510, 203)
    Me.pnldetalles.Name = "pnldetalles"
    Me.pnldetalles.Size = New System.Drawing.Size(111, 81)
    Me.pnldetalles.TabIndex = 14
    '
    'Label3
    '
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.Location = New System.Drawing.Point(0, 23)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(111, 58)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Detalles"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel5
    '
    Me.Panel5.Controls.Add(Me.btndeldet)
    Me.Panel5.Controls.Add(Me.btnadddet)
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel5.Location = New System.Drawing.Point(0, 0)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(111, 23)
    Me.Panel5.TabIndex = 9
    '
    'btndeldet
    '
    Me.btndeldet.Dock = System.Windows.Forms.DockStyle.Left
    Me.btndeldet.Location = New System.Drawing.Point(26, 0)
    Me.btndeldet.Name = "btndeldet"
    Me.btndeldet.Size = New System.Drawing.Size(26, 23)
    Me.btndeldet.TabIndex = 1
    Me.btndeldet.Text = "-"
    Me.btndeldet.UseVisualStyleBackColor = True
    '
    'btnadddet
    '
    Me.btnadddet.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnadddet.Location = New System.Drawing.Point(0, 0)
    Me.btnadddet.Name = "btnadddet"
    Me.btnadddet.Size = New System.Drawing.Size(26, 23)
    Me.btnadddet.TabIndex = 0
    Me.btnadddet.Text = "+"
    Me.btnadddet.UseVisualStyleBackColor = True
    '
    'CtlSeccionBandaResumen
    '
    Me.CtlSeccionBandaResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CtlSeccionBandaResumen.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlSeccionBandaResumen.Enabled = False
    Me.CtlSeccionBandaResumen.Location = New System.Drawing.Point(3, 377)
    Me.CtlSeccionBandaResumen.Name = "CtlSeccionBandaResumen"
    Me.CtlSeccionBandaResumen.ReportData = Nothing
    Me.CtlSeccionBandaResumen.Size = New System.Drawing.Size(501, 81)
    Me.CtlSeccionBandaResumen.TabIndex = 4
    Me.CtlSeccionBandaResumen.Ubicacion = Infoware.Reportes.enumUbicacion.BandaTitulo
    '
    'CtlSeccionPiePagina
    '
    Me.CtlSeccionPiePagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CtlSeccionPiePagina.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlSeccionPiePagina.Location = New System.Drawing.Point(3, 290)
    Me.CtlSeccionPiePagina.Name = "CtlSeccionPiePagina"
    Me.CtlSeccionPiePagina.ReportData = Nothing
    Me.CtlSeccionPiePagina.Size = New System.Drawing.Size(501, 81)
    Me.CtlSeccionPiePagina.TabIndex = 3
    Me.CtlSeccionPiePagina.Ubicacion = Infoware.Reportes.enumUbicacion.BandaTitulo
    '
    'CtlSeccionDetalles
    '
    Me.CtlSeccionDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CtlSeccionDetalles.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlSeccionDetalles.Location = New System.Drawing.Point(3, 203)
    Me.CtlSeccionDetalles.Name = "CtlSeccionDetalles"
    Me.CtlSeccionDetalles.ReportData = Nothing
    Me.CtlSeccionDetalles.Size = New System.Drawing.Size(501, 81)
    Me.CtlSeccionDetalles.TabIndex = 2
    Me.CtlSeccionDetalles.Ubicacion = Infoware.Reportes.enumUbicacion.BandaTitulo
    '
    'CtlSeccionEncabezado
    '
    Me.CtlSeccionEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CtlSeccionEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlSeccionEncabezado.Location = New System.Drawing.Point(3, 116)
    Me.CtlSeccionEncabezado.Name = "CtlSeccionEncabezado"
    Me.CtlSeccionEncabezado.ReportData = Nothing
    Me.CtlSeccionEncabezado.Size = New System.Drawing.Size(501, 81)
    Me.CtlSeccionEncabezado.TabIndex = 1
    Me.CtlSeccionEncabezado.Ubicacion = Infoware.Reportes.enumUbicacion.BandaTitulo
    '
    'CtlSeccionBandaTitulo
    '
    Me.CtlSeccionBandaTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CtlSeccionBandaTitulo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlSeccionBandaTitulo.Enabled = False
    Me.CtlSeccionBandaTitulo.Location = New System.Drawing.Point(3, 29)
    Me.CtlSeccionBandaTitulo.Name = "CtlSeccionBandaTitulo"
    Me.CtlSeccionBandaTitulo.ReportData = Nothing
    Me.CtlSeccionBandaTitulo.Size = New System.Drawing.Size(501, 81)
    Me.CtlSeccionBandaTitulo.TabIndex = 0
    Me.CtlSeccionBandaTitulo.Ubicacion = Infoware.Reportes.enumUbicacion.BandaTitulo
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.cbopapel)
    Me.Panel1.Controls.Add(Me.Label7)
    Me.Panel1.Controls.Add(Me.cboimpresoras)
    Me.Panel1.Controls.Add(Me.Label6)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(501, 20)
    Me.Panel1.TabIndex = 10
    '
    'cbopapel
    '
    Me.cbopapel.Dock = System.Windows.Forms.DockStyle.Left
    Me.cbopapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbopapel.FormattingEnabled = True
    Me.cbopapel.Location = New System.Drawing.Point(218, 0)
    Me.cbopapel.Name = "cbopapel"
    Me.cbopapel.Size = New System.Drawing.Size(125, 21)
    Me.cbopapel.TabIndex = 3
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
    Me.Label7.Location = New System.Drawing.Point(181, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(37, 13)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Papel:"
    '
    'cboimpresoras
    '
    Me.cboimpresoras.Dock = System.Windows.Forms.DockStyle.Left
    Me.cboimpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboimpresoras.FormattingEnabled = True
    Me.cboimpresoras.Location = New System.Drawing.Point(56, 0)
    Me.cboimpresoras.Name = "cboimpresoras"
    Me.cboimpresoras.Size = New System.Drawing.Size(125, 21)
    Me.cboimpresoras.TabIndex = 1
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
    Me.Label6.Location = New System.Drawing.Point(0, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(56, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Impresora:"
    '
    'pnlbandatitulo
    '
    Me.pnlbandatitulo.Controls.Add(Me.Label1)
    Me.pnlbandatitulo.Controls.Add(Me.Panel2)
    Me.pnlbandatitulo.Controls.Add(Me.chk_mostrarbarratitulo)
    Me.pnlbandatitulo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlbandatitulo.Location = New System.Drawing.Point(510, 29)
    Me.pnlbandatitulo.Name = "pnlbandatitulo"
    Me.pnlbandatitulo.Size = New System.Drawing.Size(111, 81)
    Me.pnlbandatitulo.TabIndex = 11
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Location = New System.Drawing.Point(0, 40)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(111, 41)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Banda de título"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btndelbt)
    Me.Panel2.Controls.Add(Me.btnaddbt)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 17)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(111, 23)
    Me.Panel2.TabIndex = 8
    '
    'btndelbt
    '
    Me.btndelbt.Dock = System.Windows.Forms.DockStyle.Left
    Me.btndelbt.Location = New System.Drawing.Point(26, 0)
    Me.btndelbt.Name = "btndelbt"
    Me.btndelbt.Size = New System.Drawing.Size(26, 23)
    Me.btndelbt.TabIndex = 1
    Me.btndelbt.Text = "-"
    Me.btndelbt.UseVisualStyleBackColor = True
    '
    'btnaddbt
    '
    Me.btnaddbt.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnaddbt.Location = New System.Drawing.Point(0, 0)
    Me.btnaddbt.Name = "btnaddbt"
    Me.btnaddbt.Size = New System.Drawing.Size(26, 23)
    Me.btnaddbt.TabIndex = 0
    Me.btnaddbt.Text = "+"
    Me.btnaddbt.UseVisualStyleBackColor = True
    '
    'chk_mostrarbarratitulo
    '
    Me.chk_mostrarbarratitulo.AutoSize = True
    Me.chk_mostrarbarratitulo.Dock = System.Windows.Forms.DockStyle.Top
    Me.chk_mostrarbarratitulo.Location = New System.Drawing.Point(0, 0)
    Me.chk_mostrarbarratitulo.Name = "chk_mostrarbarratitulo"
    Me.chk_mostrarbarratitulo.Size = New System.Drawing.Size(111, 17)
    Me.chk_mostrarbarratitulo.TabIndex = 7
    Me.chk_mostrarbarratitulo.Text = "Mostrar barra titulo"
    Me.chk_mostrarbarratitulo.UseVisualStyleBackColor = True
    '
    'pnlencabezado
    '
    Me.pnlencabezado.Controls.Add(Me.Label2)
    Me.pnlencabezado.Controls.Add(Me.Panel4)
    Me.pnlencabezado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlencabezado.Location = New System.Drawing.Point(510, 116)
    Me.pnlencabezado.Name = "pnlencabezado"
    Me.pnlencabezado.Size = New System.Drawing.Size(111, 81)
    Me.pnlencabezado.TabIndex = 12
    '
    'Label2
    '
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Location = New System.Drawing.Point(0, 23)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(111, 58)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Encabezado"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.btndelenc)
    Me.Panel4.Controls.Add(Me.btnaddenc)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel4.Location = New System.Drawing.Point(0, 0)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(111, 23)
    Me.Panel4.TabIndex = 9
    '
    'btndelenc
    '
    Me.btndelenc.Dock = System.Windows.Forms.DockStyle.Left
    Me.btndelenc.Location = New System.Drawing.Point(26, 0)
    Me.btndelenc.Name = "btndelenc"
    Me.btndelenc.Size = New System.Drawing.Size(26, 23)
    Me.btndelenc.TabIndex = 1
    Me.btndelenc.Text = "-"
    Me.btndelenc.UseVisualStyleBackColor = True
    '
    'btnaddenc
    '
    Me.btnaddenc.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnaddenc.Location = New System.Drawing.Point(0, 0)
    Me.btnaddenc.Name = "btnaddenc"
    Me.btnaddenc.Size = New System.Drawing.Size(26, 23)
    Me.btnaddenc.TabIndex = 0
    Me.btnaddenc.Text = "+"
    Me.btnaddenc.UseVisualStyleBackColor = True
    '
    'PageSetupDialog1
    '
    Me.PageSetupDialog1.Document = Me.PrintDocument1
    '
    'PrintDialog1
    '
    Me.PrintDialog1.Document = Me.PrintDocument1
    Me.PrintDialog1.UseEXDialog = True
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(638, 498)
    Me.TabControl1.TabIndex = 1
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(630, 472)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Diseño"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'PrintPreviewDialog1
    '
    Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
    Me.PrintPreviewDialog1.Enabled = True
    Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
    Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
    Me.PrintPreviewDialog1.Visible = False
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnabrir, Me.btnguardar, Me.btnimprimir, Me.lblnombrearchivo})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(638, 25)
    Me.ToolStrip1.TabIndex = 2
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnabrir
    '
    Me.btnabrir.Image = CType(resources.GetObject("btnabrir.Image"), System.Drawing.Image)
    Me.btnabrir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnabrir.Name = "btnabrir"
    Me.btnabrir.Size = New System.Drawing.Size(94, 22)
    Me.btnabrir.Text = "Abrir reporte"
    '
    'btnguardar
    '
    Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(117, 22)
    Me.btnguardar.Text = "Guardar cambios"
    '
    'btnimprimir
    '
    Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
    Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimir.Name = "btnimprimir"
    Me.btnimprimir.Size = New System.Drawing.Size(73, 22)
    Me.btnimprimir.Text = "Imprimir"
    '
    'lblnombrearchivo
    '
    Me.lblnombrearchivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.lblnombrearchivo.Name = "lblnombrearchivo"
    Me.lblnombrearchivo.Size = New System.Drawing.Size(83, 22)
    Me.lblnombrearchivo.Text = "NuevoArchivo"
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'CtlDesigner
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Window
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Name = "CtlDesigner"
    Me.Size = New System.Drawing.Size(638, 523)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.pnlbandaresumen.ResumeLayout(False)
    Me.pnlbandaresumen.PerformLayout()
    Me.Panel7.ResumeLayout(False)
    Me.pnlpiepagina.ResumeLayout(False)
    Me.Panel6.ResumeLayout(False)
    Me.pnldetalles.ResumeLayout(False)
    Me.Panel5.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.pnlbandatitulo.ResumeLayout(False)
    Me.pnlbandatitulo.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.pnlencabezado.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents CtlSeccionBandaTitulo As Infoware.Reportes.CtlSeccion
  Friend WithEvents CtlSeccionBandaResumen As Infoware.Reportes.CtlSeccion
  Friend WithEvents CtlSeccionPiePagina As Infoware.Reportes.CtlSeccion
  Friend WithEvents CtlSeccionDetalles As Infoware.Reportes.CtlSeccion
  Friend WithEvents CtlSeccionEncabezado As Infoware.Reportes.CtlSeccion
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
  Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents pnlbandatitulo As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents chk_mostrarbarratitulo As System.Windows.Forms.CheckBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents btndelbt As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnaddbt As Infoware.Controles.Base.ButtonStd
  Friend WithEvents pnlencabezado As System.Windows.Forms.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents btndelenc As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnaddenc As Infoware.Controles.Base.ButtonStd
  Friend WithEvents pnlpiepagina As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents btndelppag As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnaddppag As Infoware.Controles.Base.ButtonStd
  Friend WithEvents pnldetalles As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents btndeldet As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnadddet As Infoware.Controles.Base.ButtonStd
  Friend WithEvents pnlbandaresumen As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents btndelbr As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnaddbr As Infoware.Controles.Base.ButtonStd
  Friend WithEvents chkmostrarbarraresumen As System.Windows.Forms.CheckBox
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnabrir As System.Windows.Forms.ToolStripButton
  Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents cboimpresoras As System.Windows.Forms.ComboBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cbopapel As System.Windows.Forms.ComboBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents lblnombrearchivo As System.Windows.Forms.ToolStripLabel

End Class
