<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoFichaMedica
    Inherits Infoware.Consola.Base.FrmDialogoBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CtlAccidentesTrabajo1 = New WWTS.FichasMedicas.Controles.CtlAccidentesTrabajo()
        Me.CtlAntecedentesTrabajosAnteriores2 = New WWTS.FichasMedicas.Controles.CtlAntecedentesTrabajosAnteriores()
        Me.CtlHabitosToxicos1 = New WWTS.FichasMedicas.Controles.CtlHabitosToxicos()
        Me.CtlAntecedentesReprodMasculinos1 = New WWTS.FichasMedicas.Controles.CtlAntecedentesReprodMasculinos()
        Me.CtlAntecedentesGinecoobstetricos1 = New WWTS.FichasMedicas.Controles.CtlAntecedentesGinecoobstetricos()
        Me.CtlAntecedentesPersonales1 = New WWTS.FichasMedicas.Controles.CtlAntecedentesPersonales()
        Me.CtlActividadesFactoresRiesgo1 = New WWTS.FichasMedicas.Controles.CtlActividadesFactoresRiesgo()
        Me.CtlEnfermedadActual1 = New WWTS.FichasMedicas.Controles.CtlEnfermedadActual()
        Me.CtlMotivoConsulta1 = New WWTS.FichasMedicas.Controles.CtlMotivoConsulta()
        Me.CtlCausaSalida1 = New WWTS.FichasMedicas.Controles.CtlCausaSalida()
        Me.CtlDatosUsuario1 = New WWTS.FichasMedicas.Controles.CtlDatosUsuario()
        Me.CtlClinica1 = New WWTS.FichasMedicas.Controles.CtlClinica()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CtlFactoresRiesgoTrabajoActual1 = New WWTS.FichasMedicas.Controles.CtlFactoresRiesgoTrabajoActual()
        Me.CtlAntecedentesFamiliares1 = New WWTS.FichasMedicas.Controles.CtlAntecedentesFamiliares()
        Me.CtlConstantesVitales1 = New WWTS.FichasMedicas.Controles.CtlConstantesVitales()
        Me.CtlActividadesExtraLaborales1 = New WWTS.FichasMedicas.Controles.CtlActividadesExtraLaborales()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CtlRevisionOrganosSistemas1 = New WWTS.FichasMedicas.Controles.CtlRevisionOrganosSistemas()
        Me.CtlExamenFisicoRegional1 = New WWTS.FichasMedicas.Controles.CtlExamenFisicoRegional()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CtlRecomendacionesTratamientos1 = New WWTS.FichasMedicas.Controles.CtlRecomendacionesTratamientos()
        Me.CtlEvaluacionMedicaRetiro1 = New WWTS.FichasMedicas.Controles.CtlEvaluacionMedicaRetiro()
        Me.CtlAptitudMedica1 = New WWTS.FichasMedicas.Controles.CtlAptitudMedica()
        Me.CtlDiagnostico1 = New WWTS.FichasMedicas.Controles.CtlDiagnostico()
        Me.CtlResultadosExamenes1 = New WWTS.FichasMedicas.Controles.CtlResultadosExamenes()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1016, 595)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.CtlAccidentesTrabajo1)
        Me.TabPage1.Controls.Add(Me.CtlAntecedentesTrabajosAnteriores2)
        Me.TabPage1.Controls.Add(Me.CtlHabitosToxicos1)
        Me.TabPage1.Controls.Add(Me.CtlAntecedentesReprodMasculinos1)
        Me.TabPage1.Controls.Add(Me.CtlAntecedentesGinecoobstetricos1)
        Me.TabPage1.Controls.Add(Me.CtlAntecedentesPersonales1)
        Me.TabPage1.Controls.Add(Me.CtlActividadesFactoresRiesgo1)
        Me.TabPage1.Controls.Add(Me.CtlEnfermedadActual1)
        Me.TabPage1.Controls.Add(Me.CtlMotivoConsulta1)
        Me.TabPage1.Controls.Add(Me.CtlCausaSalida1)
        Me.TabPage1.Controls.Add(Me.CtlDatosUsuario1)
        Me.TabPage1.Controls.Add(Me.CtlClinica1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1008, 569)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Antecedentes personales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CtlAccidentesTrabajo1
        '
        Me.CtlAccidentesTrabajo1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAccidentesTrabajo1.FichaMedica = Nothing
        Me.CtlAccidentesTrabajo1.Location = New System.Drawing.Point(3, 2159)
        Me.CtlAccidentesTrabajo1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAccidentesTrabajo1.Name = "CtlAccidentesTrabajo1"
        Me.CtlAccidentesTrabajo1.Size = New System.Drawing.Size(985, 421)
        Me.CtlAccidentesTrabajo1.TabIndex = 11
        '
        'CtlAntecedentesTrabajosAnteriores2
        '
        Me.CtlAntecedentesTrabajosAnteriores2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAntecedentesTrabajosAnteriores2.FichaMedica = Nothing
        Me.CtlAntecedentesTrabajosAnteriores2.Location = New System.Drawing.Point(3, 1371)
        Me.CtlAntecedentesTrabajosAnteriores2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAntecedentesTrabajosAnteriores2.Name = "CtlAntecedentesTrabajosAnteriores2"
        Me.CtlAntecedentesTrabajosAnteriores2.Size = New System.Drawing.Size(985, 788)
        Me.CtlAntecedentesTrabajosAnteriores2.TabIndex = 10
        '
        'CtlHabitosToxicos1
        '
        Me.CtlHabitosToxicos1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlHabitosToxicos1.FichaMedica = Nothing
        Me.CtlHabitosToxicos1.Location = New System.Drawing.Point(3, 959)
        Me.CtlHabitosToxicos1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlHabitosToxicos1.Name = "CtlHabitosToxicos1"
        Me.CtlHabitosToxicos1.Size = New System.Drawing.Size(985, 412)
        Me.CtlHabitosToxicos1.TabIndex = 9
        '
        'CtlAntecedentesReprodMasculinos1
        '
        Me.CtlAntecedentesReprodMasculinos1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAntecedentesReprodMasculinos1.FichaMedica = Nothing
        Me.CtlAntecedentesReprodMasculinos1.Location = New System.Drawing.Point(3, 744)
        Me.CtlAntecedentesReprodMasculinos1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAntecedentesReprodMasculinos1.Name = "CtlAntecedentesReprodMasculinos1"
        Me.CtlAntecedentesReprodMasculinos1.Size = New System.Drawing.Size(985, 215)
        Me.CtlAntecedentesReprodMasculinos1.TabIndex = 8
        '
        'CtlAntecedentesGinecoobstetricos1
        '
        Me.CtlAntecedentesGinecoobstetricos1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAntecedentesGinecoobstetricos1.FichaMedica = Nothing
        Me.CtlAntecedentesGinecoobstetricos1.Location = New System.Drawing.Point(3, 432)
        Me.CtlAntecedentesGinecoobstetricos1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAntecedentesGinecoobstetricos1.Name = "CtlAntecedentesGinecoobstetricos1"
        Me.CtlAntecedentesGinecoobstetricos1.Size = New System.Drawing.Size(985, 312)
        Me.CtlAntecedentesGinecoobstetricos1.TabIndex = 7
        '
        'CtlAntecedentesPersonales1
        '
        Me.CtlAntecedentesPersonales1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAntecedentesPersonales1.FichaMedica = Nothing
        Me.CtlAntecedentesPersonales1.Location = New System.Drawing.Point(3, 375)
        Me.CtlAntecedentesPersonales1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAntecedentesPersonales1.Name = "CtlAntecedentesPersonales1"
        Me.CtlAntecedentesPersonales1.Size = New System.Drawing.Size(985, 57)
        Me.CtlAntecedentesPersonales1.TabIndex = 6
        '
        'CtlActividadesFactoresRiesgo1
        '
        Me.CtlActividadesFactoresRiesgo1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlActividadesFactoresRiesgo1.FichaMedica = Nothing
        Me.CtlActividadesFactoresRiesgo1.Location = New System.Drawing.Point(3, 248)
        Me.CtlActividadesFactoresRiesgo1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlActividadesFactoresRiesgo1.Name = "CtlActividadesFactoresRiesgo1"
        Me.CtlActividadesFactoresRiesgo1.Size = New System.Drawing.Size(985, 127)
        Me.CtlActividadesFactoresRiesgo1.TabIndex = 5
        '
        'CtlEnfermedadActual1
        '
        Me.CtlEnfermedadActual1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlEnfermedadActual1.FichaMedica = Nothing
        Me.CtlEnfermedadActual1.Location = New System.Drawing.Point(3, 194)
        Me.CtlEnfermedadActual1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlEnfermedadActual1.Name = "CtlEnfermedadActual1"
        Me.CtlEnfermedadActual1.Size = New System.Drawing.Size(985, 54)
        Me.CtlEnfermedadActual1.TabIndex = 4
        '
        'CtlMotivoConsulta1
        '
        Me.CtlMotivoConsulta1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlMotivoConsulta1.FichaMedica = Nothing
        Me.CtlMotivoConsulta1.Location = New System.Drawing.Point(3, 151)
        Me.CtlMotivoConsulta1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlMotivoConsulta1.Name = "CtlMotivoConsulta1"
        Me.CtlMotivoConsulta1.Size = New System.Drawing.Size(985, 43)
        Me.CtlMotivoConsulta1.TabIndex = 3
        '
        'CtlCausaSalida1
        '
        Me.CtlCausaSalida1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlCausaSalida1.FichaMedica = Nothing
        Me.CtlCausaSalida1.Location = New System.Drawing.Point(3, 121)
        Me.CtlCausaSalida1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlCausaSalida1.Name = "CtlCausaSalida1"
        Me.CtlCausaSalida1.Size = New System.Drawing.Size(985, 30)
        Me.CtlCausaSalida1.TabIndex = 2
        '
        'CtlDatosUsuario1
        '
        Me.CtlDatosUsuario1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlDatosUsuario1.FichaMedica = Nothing
        Me.CtlDatosUsuario1.Location = New System.Drawing.Point(3, 62)
        Me.CtlDatosUsuario1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlDatosUsuario1.Name = "CtlDatosUsuario1"
        Me.CtlDatosUsuario1.Size = New System.Drawing.Size(985, 59)
        Me.CtlDatosUsuario1.TabIndex = 1
        '
        'CtlClinica1
        '
        Me.CtlClinica1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlClinica1.FichaMedica = Nothing
        Me.CtlClinica1.Location = New System.Drawing.Point(3, 3)
        Me.CtlClinica1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlClinica1.Name = "CtlClinica1"
        Me.CtlClinica1.Size = New System.Drawing.Size(985, 59)
        Me.CtlClinica1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CtlFactoresRiesgoTrabajoActual1)
        Me.TabPage2.Controls.Add(Me.CtlAntecedentesFamiliares1)
        Me.TabPage2.Controls.Add(Me.CtlConstantesVitales1)
        Me.TabPage2.Controls.Add(Me.CtlActividadesExtraLaborales1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1008, 553)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos/Enfermedades/Riesgos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CtlFactoresRiesgoTrabajoActual1
        '
        Me.CtlFactoresRiesgoTrabajoActual1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlFactoresRiesgoTrabajoActual1.FichaMedica = Nothing
        Me.CtlFactoresRiesgoTrabajoActual1.Location = New System.Drawing.Point(3, 303)
        Me.CtlFactoresRiesgoTrabajoActual1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlFactoresRiesgoTrabajoActual1.Name = "CtlFactoresRiesgoTrabajoActual1"
        Me.CtlFactoresRiesgoTrabajoActual1.Size = New System.Drawing.Size(985, 2686)
        Me.CtlFactoresRiesgoTrabajoActual1.TabIndex = 3
        '
        'CtlAntecedentesFamiliares1
        '
        Me.CtlAntecedentesFamiliares1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAntecedentesFamiliares1.FichaMedica = Nothing
        Me.CtlAntecedentesFamiliares1.Location = New System.Drawing.Point(3, 191)
        Me.CtlAntecedentesFamiliares1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAntecedentesFamiliares1.Name = "CtlAntecedentesFamiliares1"
        Me.CtlAntecedentesFamiliares1.Size = New System.Drawing.Size(985, 112)
        Me.CtlAntecedentesFamiliares1.TabIndex = 2
        '
        'CtlConstantesVitales1
        '
        Me.CtlConstantesVitales1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlConstantesVitales1.FichaMedica = Nothing
        Me.CtlConstantesVitales1.Location = New System.Drawing.Point(3, 69)
        Me.CtlConstantesVitales1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlConstantesVitales1.Name = "CtlConstantesVitales1"
        Me.CtlConstantesVitales1.Size = New System.Drawing.Size(985, 122)
        Me.CtlConstantesVitales1.TabIndex = 1
        '
        'CtlActividadesExtraLaborales1
        '
        Me.CtlActividadesExtraLaborales1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlActividadesExtraLaborales1.FichaMedica = Nothing
        Me.CtlActividadesExtraLaborales1.Location = New System.Drawing.Point(3, 3)
        Me.CtlActividadesExtraLaborales1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlActividadesExtraLaborales1.Name = "CtlActividadesExtraLaborales1"
        Me.CtlActividadesExtraLaborales1.Size = New System.Drawing.Size(985, 66)
        Me.CtlActividadesExtraLaborales1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.CtlRevisionOrganosSistemas1)
        Me.TabPage3.Controls.Add(Me.CtlExamenFisicoRegional1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1008, 553)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalles"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CtlRevisionOrganosSistemas1
        '
        Me.CtlRevisionOrganosSistemas1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlRevisionOrganosSistemas1.FichaMedica = Nothing
        Me.CtlRevisionOrganosSistemas1.Location = New System.Drawing.Point(3, 452)
        Me.CtlRevisionOrganosSistemas1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlRevisionOrganosSistemas1.Name = "CtlRevisionOrganosSistemas1"
        Me.CtlRevisionOrganosSistemas1.Size = New System.Drawing.Size(985, 153)
        Me.CtlRevisionOrganosSistemas1.TabIndex = 1
        '
        'CtlExamenFisicoRegional1
        '
        Me.CtlExamenFisicoRegional1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlExamenFisicoRegional1.FichaMedica = Nothing
        Me.CtlExamenFisicoRegional1.Location = New System.Drawing.Point(3, 3)
        Me.CtlExamenFisicoRegional1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlExamenFisicoRegional1.Name = "CtlExamenFisicoRegional1"
        Me.CtlExamenFisicoRegional1.Size = New System.Drawing.Size(985, 449)
        Me.CtlExamenFisicoRegional1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.CtlRecomendacionesTratamientos1)
        Me.TabPage4.Controls.Add(Me.CtlEvaluacionMedicaRetiro1)
        Me.TabPage4.Controls.Add(Me.CtlAptitudMedica1)
        Me.TabPage4.Controls.Add(Me.CtlDiagnostico1)
        Me.TabPage4.Controls.Add(Me.CtlResultadosExamenes1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1008, 569)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Resultado"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CtlRecomendacionesTratamientos1
        '
        Me.CtlRecomendacionesTratamientos1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlRecomendacionesTratamientos1.FichaMedica = Nothing
        Me.CtlRecomendacionesTratamientos1.Location = New System.Drawing.Point(3, 731)
        Me.CtlRecomendacionesTratamientos1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlRecomendacionesTratamientos1.Name = "CtlRecomendacionesTratamientos1"
        Me.CtlRecomendacionesTratamientos1.Size = New System.Drawing.Size(985, 192)
        Me.CtlRecomendacionesTratamientos1.TabIndex = 4
        '
        'CtlEvaluacionMedicaRetiro1
        '
        Me.CtlEvaluacionMedicaRetiro1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlEvaluacionMedicaRetiro1.FichaMedica = Nothing
        Me.CtlEvaluacionMedicaRetiro1.Location = New System.Drawing.Point(3, 597)
        Me.CtlEvaluacionMedicaRetiro1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlEvaluacionMedicaRetiro1.Name = "CtlEvaluacionMedicaRetiro1"
        Me.CtlEvaluacionMedicaRetiro1.Size = New System.Drawing.Size(985, 134)
        Me.CtlEvaluacionMedicaRetiro1.TabIndex = 3
        '
        'CtlAptitudMedica1
        '
        Me.CtlAptitudMedica1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlAptitudMedica1.FichaMedica = Nothing
        Me.CtlAptitudMedica1.Location = New System.Drawing.Point(3, 368)
        Me.CtlAptitudMedica1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlAptitudMedica1.Name = "CtlAptitudMedica1"
        Me.CtlAptitudMedica1.Size = New System.Drawing.Size(985, 229)
        Me.CtlAptitudMedica1.TabIndex = 2
        '
        'CtlDiagnostico1
        '
        Me.CtlDiagnostico1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlDiagnostico1.FichaMedica = Nothing
        Me.CtlDiagnostico1.Location = New System.Drawing.Point(3, 230)
        Me.CtlDiagnostico1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlDiagnostico1.Name = "CtlDiagnostico1"
        Me.CtlDiagnostico1.Size = New System.Drawing.Size(985, 138)
        Me.CtlDiagnostico1.TabIndex = 1
        '
        'CtlResultadosExamenes1
        '
        Me.CtlResultadosExamenes1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlResultadosExamenes1.FichaMedica = Nothing
        Me.CtlResultadosExamenes1.Location = New System.Drawing.Point(3, 3)
        Me.CtlResultadosExamenes1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtlResultadosExamenes1.Name = "CtlResultadosExamenes1"
        Me.CtlResultadosExamenes1.Size = New System.Drawing.Size(985, 227)
        Me.CtlResultadosExamenes1.TabIndex = 0
        '
        'FrmMantenimientoFichaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1016, 625)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmMantenimientoFichaMedica"
        Me.Text = "Ficha Médica"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CtlDatosUsuario1 As CtlDatosUsuario
    Friend WithEvents CtlMotivoConsulta1 As CtlMotivoConsulta
    Friend WithEvents CtlCausaSalida1 As CtlCausaSalida
    Friend WithEvents CtlEnfermedadActual1 As CtlEnfermedadActual
    Friend WithEvents CtlAntecedentesPersonales1 As CtlAntecedentesPersonales
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CtlAntecedentesReprodMasculinos1 As CtlAntecedentesReprodMasculinos
    Friend WithEvents CtlAntecedentesGinecoobstetricos1 As CtlAntecedentesGinecoobstetricos
    Friend WithEvents CtlHabitosToxicos1 As CtlHabitosToxicos
    Friend WithEvents CtlAccidentesTrabajo1 As CtlAccidentesTrabajo
    Friend WithEvents CtlConstantesVitales1 As CtlConstantesVitales
    Friend WithEvents CtlAntecedentesFamiliares1 As CtlAntecedentesFamiliares
    Friend WithEvents CtlAntecedentesTrabajosAnteriores2 As CtlAntecedentesTrabajosAnteriores
    Friend WithEvents CtlFactoresRiesgoTrabajoActual1 As CtlFactoresRiesgoTrabajoActual
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CtlExamenFisicoRegional1 As CtlExamenFisicoRegional
    Friend WithEvents CtlRevisionOrganosSistemas1 As CtlRevisionOrganosSistemas
    Friend WithEvents CtlActividadesExtraLaborales1 As CtlActividadesExtraLaborales
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CtlRecomendacionesTratamientos1 As CtlRecomendacionesTratamientos
    Friend WithEvents CtlAptitudMedica1 As CtlAptitudMedica
    Friend WithEvents CtlDiagnostico1 As CtlDiagnostico
    Friend WithEvents CtlResultadosExamenes1 As CtlResultadosExamenes
    Friend WithEvents CtlActividadesFactoresRiesgo1 As CtlActividadesFactoresRiesgo
    Friend WithEvents CtlClinica1 As CtlClinica
    Friend WithEvents CtlEvaluacionMedicaRetiro1 As CtlEvaluacionMedicaRetiro
End Class
