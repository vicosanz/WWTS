<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnsarteZafadura
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
    Me.PnlCuerpo = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.crvsaldocujes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.rdotabcand = New System.Windows.Forms.RadioButton()
    Me.rdotabnat = New System.Windows.Forms.RadioButton()
    Me.dtcortadoensal = New System.Windows.Forms.DateTimePicker()
    Me.chkcortadoensal = New System.Windows.Forms.CheckBox()
    Me.btnmostrarsaldo = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.crvdispo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.cboCicloEnsarte = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.dtfechastadispo = New System.Windows.Forms.DateTimePicker()
    Me.chkhastadispo = New System.Windows.Forms.CheckBox()
    Me.btnmostrardispo = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.crvtabacozafado = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.rdotabcandzaf = New System.Windows.Forms.RadioButton()
    Me.rdotabnatzaf = New System.Windows.Forms.RadioButton()
    Me.dtcortadozafal = New System.Windows.Forms.DateTimePicker()
    Me.chkcortadozafal = New System.Windows.Forms.CheckBox()
    Me.btnmostrarzaf = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.HeaderStrip1 = New Infoware.Consola.Base.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.CtlTarjEnsarte1 = New CtlTarjEnsarte()
    Me.CtlBuscaTarjetaEnsZaf1 = New CtlBuscaTarjetaEnsZaf()
    Me.CtlZafra1 = New CtlZafra()
    Me.CtlZafra2 = New CtlZafra()
    Me.CtlZafra3 = New CtlZafra()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PnlCuerpo.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'PnlCuerpo
    '
    Me.PnlCuerpo.Controls.Add(Me.TabControl1)
    Me.PnlCuerpo.Controls.Add(Me.HeaderStrip1)
    Me.PnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PnlCuerpo.Location = New System.Drawing.Point(0, 0)
    Me.PnlCuerpo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PnlCuerpo.Name = "PnlCuerpo"
    Me.PnlCuerpo.Size = New System.Drawing.Size(1126, 805)
    Me.PnlCuerpo.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1126, 780)
    Me.TabControl1.TabIndex = 3
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlTarjEnsarte1)
    Me.TabPage1.Controls.Add(Me.CtlBuscaTarjetaEnsZaf1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage1.Size = New System.Drawing.Size(1118, 754)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Tarjeta de ensarte"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.crvsaldocujes)
    Me.TabPage2.Controls.Add(Me.Panel1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage2.Size = New System.Drawing.Size(1118, 754)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Saldo de cujes en hornos"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'crvsaldocujes
    '
    Me.crvsaldocujes.ActiveViewIndex = -1
    Me.crvsaldocujes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvsaldocujes.Cursor = System.Windows.Forms.Cursors.Default
    Me.crvsaldocujes.DisplayStatusBar = False
    Me.crvsaldocujes.DisplayToolbar = False
    Me.crvsaldocujes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvsaldocujes.Location = New System.Drawing.Point(4, 113)
    Me.crvsaldocujes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.crvsaldocujes.Name = "crvsaldocujes"
    Me.crvsaldocujes.SelectionFormula = ""
    Me.crvsaldocujes.Size = New System.Drawing.Size(1110, 636)
    Me.crvsaldocujes.TabIndex = 3
    Me.crvsaldocujes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    Me.crvsaldocujes.ToolPanelWidth = 300
    Me.crvsaldocujes.ViewTimeSelectionFormula = ""
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.Info
    Me.Panel1.Controls.Add(Me.rdotabcand)
    Me.Panel1.Controls.Add(Me.rdotabnat)
    Me.Panel1.Controls.Add(Me.CtlZafra1)
    Me.Panel1.Controls.Add(Me.dtcortadoensal)
    Me.Panel1.Controls.Add(Me.chkcortadoensal)
    Me.Panel1.Controls.Add(Me.btnmostrarsaldo)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(4, 5)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1110, 108)
    Me.Panel1.TabIndex = 2
    '
    'rdotabcand
    '
    Me.rdotabcand.AutoSize = True
    Me.rdotabcand.Location = New System.Drawing.Point(99, 72)
    Me.rdotabcand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.rdotabcand.Name = "rdotabcand"
    Me.rdotabcand.Size = New System.Drawing.Size(103, 17)
    Me.rdotabcand.TabIndex = 8
    Me.rdotabcand.Text = "Tabaco candela"
    Me.rdotabcand.UseVisualStyleBackColor = True
    '
    'rdotabnat
    '
    Me.rdotabnat.AutoSize = True
    Me.rdotabnat.Checked = True
    Me.rdotabnat.Location = New System.Drawing.Point(99, 45)
    Me.rdotabnat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.rdotabnat.Name = "rdotabnat"
    Me.rdotabnat.Size = New System.Drawing.Size(97, 17)
    Me.rdotabnat.TabIndex = 8
    Me.rdotabnat.TabStop = True
    Me.rdotabnat.Text = "Tabaco natural"
    Me.rdotabnat.UseVisualStyleBackColor = True
    '
    'dtcortadoensal
    '
    Me.dtcortadoensal.Enabled = False
    Me.dtcortadoensal.Location = New System.Drawing.Point(358, 44)
    Me.dtcortadoensal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.dtcortadoensal.Name = "dtcortadoensal"
    Me.dtcortadoensal.Size = New System.Drawing.Size(222, 20)
    Me.dtcortadoensal.TabIndex = 5
    '
    'chkcortadoensal
    '
    Me.chkcortadoensal.AutoSize = True
    Me.chkcortadoensal.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkcortadoensal.Location = New System.Drawing.Point(343, 16)
    Me.chkcortadoensal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.chkcortadoensal.Name = "chkcortadoensal"
    Me.chkcortadoensal.Size = New System.Drawing.Size(80, 18)
    Me.chkcortadoensal.TabIndex = 4
    Me.chkcortadoensal.Text = "Cortado al"
    '
    'btnmostrarsaldo
    '
    Me.btnmostrarsaldo.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrarsaldo.Location = New System.Drawing.Point(606, 63)
    Me.btnmostrarsaldo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnmostrarsaldo.Name = "btnmostrarsaldo"
    Me.btnmostrarsaldo.Size = New System.Drawing.Size(112, 35)
    Me.btnmostrarsaldo.TabIndex = 6
    Me.btnmostrarsaldo.Text = "&Mostrar"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(18, 18)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(35, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Zafra:"
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.crvdispo)
    Me.TabPage3.Controls.Add(Me.Panel3)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage3.Size = New System.Drawing.Size(1118, 754)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Disponibilidad en cujes"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'crvdispo
    '
    Me.crvdispo.ActiveViewIndex = -1
    Me.crvdispo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvdispo.Cursor = System.Windows.Forms.Cursors.Default
    Me.crvdispo.DisplayStatusBar = False
    Me.crvdispo.DisplayToolbar = False
    Me.crvdispo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvdispo.Location = New System.Drawing.Point(4, 97)
    Me.crvdispo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.crvdispo.Name = "crvdispo"
    Me.crvdispo.SelectionFormula = ""
    Me.crvdispo.Size = New System.Drawing.Size(1110, 652)
    Me.crvdispo.TabIndex = 5
    Me.crvdispo.ViewTimeSelectionFormula = ""
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.SystemColors.Info
    Me.Panel3.Controls.Add(Me.cboCicloEnsarte)
    Me.Panel3.Controls.Add(Me.Label12)
    Me.Panel3.Controls.Add(Me.CtlZafra2)
    Me.Panel3.Controls.Add(Me.dtfechastadispo)
    Me.Panel3.Controls.Add(Me.chkhastadispo)
    Me.Panel3.Controls.Add(Me.btnmostrardispo)
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(4, 5)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(1110, 92)
    Me.Panel3.TabIndex = 4
    '
    'cboCicloEnsarte
    '
    Me.cboCicloEnsarte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCicloEnsarte.FormattingEnabled = True
    Me.cboCicloEnsarte.Location = New System.Drawing.Point(129, 47)
    Me.cboCicloEnsarte.Name = "cboCicloEnsarte"
    Me.cboCicloEnsarte.OperadorDatos = Nothing
    Me.cboCicloEnsarte.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboCicloEnsarte.ParametroDet = Nothing
    Me.cboCicloEnsarte.PuedeActualizar = True
    Me.cboCicloEnsarte.PuedeEliminar = True
    Me.cboCicloEnsarte.PuedeModificar = True
    Me.cboCicloEnsarte.PuedeNuevo = True
    Me.cboCicloEnsarte.Size = New System.Drawing.Size(180, 21)
    Me.cboCicloEnsarte.TabIndex = 3
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(18, 49)
    Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(69, 13)
    Me.Label12.TabIndex = 2
    Me.Label12.Text = "Ciclo Ensarte"
    '
    'dtfechastadispo
    '
    Me.dtfechastadispo.Enabled = False
    Me.dtfechastadispo.Location = New System.Drawing.Point(432, 49)
    Me.dtfechastadispo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.dtfechastadispo.Name = "dtfechastadispo"
    Me.dtfechastadispo.Size = New System.Drawing.Size(322, 20)
    Me.dtfechastadispo.TabIndex = 5
    '
    'chkhastadispo
    '
    Me.chkhastadispo.AutoSize = True
    Me.chkhastadispo.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkhastadispo.Location = New System.Drawing.Point(408, 12)
    Me.chkhastadispo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.chkhastadispo.Name = "chkhastadispo"
    Me.chkhastadispo.Size = New System.Drawing.Size(159, 18)
    Me.chkhastadispo.TabIndex = 4
    Me.chkhastadispo.Text = "Tabaco ensartado hasta el"
    '
    'btnmostrardispo
    '
    Me.btnmostrardispo.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrardispo.Location = New System.Drawing.Point(780, 12)
    Me.btnmostrardispo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnmostrardispo.Name = "btnmostrardispo"
    Me.btnmostrardispo.Size = New System.Drawing.Size(112, 35)
    Me.btnmostrardispo.TabIndex = 6
    Me.btnmostrardispo.Text = "&Mostrar"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(18, 18)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(35, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Zafra:"
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.crvtabacozafado)
    Me.TabPage4.Controls.Add(Me.Panel2)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TabPage4.Size = New System.Drawing.Size(1118, 754)
    Me.TabPage4.TabIndex = 3
    Me.TabPage4.Text = "Reporte de tabaco zafado"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'crvtabacozafado
    '
    Me.crvtabacozafado.ActiveViewIndex = -1
    Me.crvtabacozafado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvtabacozafado.Cursor = System.Windows.Forms.Cursors.Default
    Me.crvtabacozafado.DisplayStatusBar = False
    Me.crvtabacozafado.DisplayToolbar = False
    Me.crvtabacozafado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvtabacozafado.Location = New System.Drawing.Point(4, 112)
    Me.crvtabacozafado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.crvtabacozafado.Name = "crvtabacozafado"
    Me.crvtabacozafado.SelectionFormula = ""
    Me.crvtabacozafado.Size = New System.Drawing.Size(1110, 637)
    Me.crvtabacozafado.TabIndex = 5
    Me.crvtabacozafado.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    Me.crvtabacozafado.ViewTimeSelectionFormula = ""
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.Info
    Me.Panel2.Controls.Add(Me.rdotabcandzaf)
    Me.Panel2.Controls.Add(Me.rdotabnatzaf)
    Me.Panel2.Controls.Add(Me.CtlZafra3)
    Me.Panel2.Controls.Add(Me.dtcortadozafal)
    Me.Panel2.Controls.Add(Me.chkcortadozafal)
    Me.Panel2.Controls.Add(Me.btnmostrarzaf)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(4, 5)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1110, 107)
    Me.Panel2.TabIndex = 4
    '
    'rdotabcandzaf
    '
    Me.rdotabcandzaf.AutoSize = True
    Me.rdotabcandzaf.Location = New System.Drawing.Point(99, 72)
    Me.rdotabcandzaf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.rdotabcandzaf.Name = "rdotabcandzaf"
    Me.rdotabcandzaf.Size = New System.Drawing.Size(103, 17)
    Me.rdotabcandzaf.TabIndex = 10
    Me.rdotabcandzaf.Text = "Tabaco candela"
    Me.rdotabcandzaf.UseVisualStyleBackColor = True
    '
    'rdotabnatzaf
    '
    Me.rdotabnatzaf.AutoSize = True
    Me.rdotabnatzaf.Checked = True
    Me.rdotabnatzaf.Location = New System.Drawing.Point(99, 45)
    Me.rdotabnatzaf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.rdotabnatzaf.Name = "rdotabnatzaf"
    Me.rdotabnatzaf.Size = New System.Drawing.Size(97, 17)
    Me.rdotabnatzaf.TabIndex = 9
    Me.rdotabnatzaf.TabStop = True
    Me.rdotabnatzaf.Text = "Tabaco natural"
    Me.rdotabnatzaf.UseVisualStyleBackColor = True
    '
    'dtcortadozafal
    '
    Me.dtcortadozafal.Enabled = False
    Me.dtcortadozafal.Location = New System.Drawing.Point(361, 43)
    Me.dtcortadozafal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.dtcortadozafal.Name = "dtcortadozafal"
    Me.dtcortadozafal.Size = New System.Drawing.Size(216, 20)
    Me.dtcortadozafal.TabIndex = 5
    '
    'chkcortadozafal
    '
    Me.chkcortadozafal.AutoSize = True
    Me.chkcortadozafal.Location = New System.Drawing.Point(343, 17)
    Me.chkcortadozafal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.chkcortadozafal.Name = "chkcortadozafal"
    Me.chkcortadozafal.Size = New System.Drawing.Size(74, 17)
    Me.chkcortadozafal.TabIndex = 4
    Me.chkcortadozafal.Text = "Cortado al"
    '
    'btnmostrarzaf
    '
    Me.btnmostrarzaf.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnmostrarzaf.Location = New System.Drawing.Point(603, 62)
    Me.btnmostrarzaf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnmostrarzaf.Name = "btnmostrarzaf"
    Me.btnmostrarzaf.Size = New System.Drawing.Size(112, 35)
    Me.btnmostrarzaf.TabIndex = 6
    Me.btnmostrarzaf.Text = "&Mostrar"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(18, 18)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(35, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Zafra:"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
    Me.HeaderStrip1.Size = New System.Drawing.Size(1126, 25)
    Me.HeaderStrip1.TabIndex = 2
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(143, 22)
    Me.ToolStripLabel1.Text = "Ensarte/Zafadura"
    '
    'CtlTarjEnsarte1
    '
    Me.CtlTarjEnsarte1.BackColor = System.Drawing.Color.Transparent
    Me.CtlTarjEnsarte1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTarjEnsarte1.EnsarteZafadura = Nothing
    Me.CtlTarjEnsarte1.Location = New System.Drawing.Point(272, 5)
    Me.CtlTarjEnsarte1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.CtlTarjEnsarte1.Name = "CtlTarjEnsarte1"
    Me.CtlTarjEnsarte1.Op = Nothing
    Me.CtlTarjEnsarte1.Size = New System.Drawing.Size(842, 744)
    Me.CtlTarjEnsarte1.TabIndex = 1
    '
    'CtlBuscaTarjetaEnsZaf1
    '
    Me.CtlBuscaTarjetaEnsZaf1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaTarjetaEnsZaf1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBuscaTarjetaEnsZaf1.Location = New System.Drawing.Point(4, 5)
    Me.CtlBuscaTarjetaEnsZaf1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.CtlBuscaTarjetaEnsZaf1.Name = "CtlBuscaTarjetaEnsZaf1"
    Me.CtlBuscaTarjetaEnsZaf1.Op = Nothing
    Me.CtlBuscaTarjetaEnsZaf1.Size = New System.Drawing.Size(268, 744)
    Me.CtlBuscaTarjetaEnsZaf1.TabIndex = 0
    '
    'CtlZafra1
    '
    Me.CtlZafra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra1.FormattingEnabled = True
    Me.CtlZafra1.Location = New System.Drawing.Point(99, 14)
    Me.CtlZafra1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.CtlZafra1.Name = "CtlZafra1"
    Me.CtlZafra1.Op = Nothing
    Me.CtlZafra1.PuedeActualizar = True
    Me.CtlZafra1.PuedeEliminar = True
    Me.CtlZafra1.PuedeModificar = True
    Me.CtlZafra1.PuedeNuevo = True
    Me.CtlZafra1.Size = New System.Drawing.Size(180, 21)
    Me.CtlZafra1.TabIndex = 7
    Me.CtlZafra1.Zafra = Nothing
    '
    'CtlZafra2
    '
    Me.CtlZafra2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra2.FormattingEnabled = True
    Me.CtlZafra2.Location = New System.Drawing.Point(129, 15)
    Me.CtlZafra2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.CtlZafra2.Name = "CtlZafra2"
    Me.CtlZafra2.Op = Nothing
    Me.CtlZafra2.PuedeActualizar = True
    Me.CtlZafra2.PuedeEliminar = True
    Me.CtlZafra2.PuedeModificar = True
    Me.CtlZafra2.PuedeNuevo = True
    Me.CtlZafra2.Size = New System.Drawing.Size(180, 21)
    Me.CtlZafra2.TabIndex = 1
    Me.CtlZafra2.Zafra = Nothing
    '
    'CtlZafra3
    '
    Me.CtlZafra3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlZafra3.FormattingEnabled = True
    Me.CtlZafra3.Location = New System.Drawing.Point(99, 14)
    Me.CtlZafra3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.CtlZafra3.Name = "CtlZafra3"
    Me.CtlZafra3.Op = Nothing
    Me.CtlZafra3.PuedeActualizar = True
    Me.CtlZafra3.PuedeEliminar = True
    Me.CtlZafra3.PuedeModificar = True
    Me.CtlZafra3.PuedeNuevo = True
    Me.CtlZafra3.Size = New System.Drawing.Size(180, 21)
    Me.CtlZafra3.TabIndex = 7
    Me.CtlZafra3.Zafra = Nothing
    '
    'FrmEnsarteZafadura
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1126, 805)
    Me.Controls.Add(Me.PnlCuerpo)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "FrmEnsarteZafadura"
    Me.Text = "Ensarte/Zafadura"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PnlCuerpo.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.TabPage4.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PnlCuerpo As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaTarjetaEnsZaf1 As CtlBuscaTarjetaEnsZaf
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents HeaderStrip1 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents CtlTarjEnsarte1 As CtlTarjEnsarte
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents rdotabcand As System.Windows.Forms.RadioButton
  Friend WithEvents rdotabnat As System.Windows.Forms.RadioButton
  Friend WithEvents CtlZafra1 As CtlZafra
  Friend WithEvents dtcortadoensal As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkcortadoensal As System.Windows.Forms.CheckBox
  Friend WithEvents btnmostrarsaldo As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents crvsaldocujes As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents crvdispo As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents CtlZafra2 As CtlZafra
  Friend WithEvents dtfechastadispo As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkhastadispo As System.Windows.Forms.CheckBox
  Friend WithEvents btnmostrardispo As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents crvtabacozafado As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents rdotabcandzaf As System.Windows.Forms.RadioButton
  Friend WithEvents rdotabnatzaf As System.Windows.Forms.RadioButton
  Friend WithEvents CtlZafra3 As CtlZafra
  Friend WithEvents dtcortadozafal As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkcortadozafal As System.Windows.Forms.CheckBox
  Friend WithEvents btnmostrarzaf As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboCicloEnsarte As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
