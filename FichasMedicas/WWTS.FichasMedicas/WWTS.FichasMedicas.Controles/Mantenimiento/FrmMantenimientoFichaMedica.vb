Imports System.ComponentModel
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.FichasMedicas.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Reglas

Public Class FrmMantenimientoFichaMedica
  Implements IMantenimiento

  Private mFichaMedica As FichaMedica

  Public Property FichaMedica As FichaMedica
    Get
      Return mFichaMedica
    End Get
    Set(value As FichaMedica)
      mFichaMedica = value
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Private mCargando As Boolean = False

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    CtlClinica1.Visible = False
    CtlClinica1.Enabled = False
    CtlDatosUsuario1.Visible = False
    CtlDatosUsuario1.Enabled = False
    CtlMotivoConsulta1.Visible = False
    CtlMotivoConsulta1.Enabled = False
    CtlAntecedentesPersonales1.Visible = False
    CtlAntecedentesPersonales1.Enabled = False
    CtlHabitosToxicos1.Visible = False
    CtlHabitosToxicos1.Enabled = False
    CtlAntecedentesTrabajosAnteriores2.Visible = False
    CtlAntecedentesTrabajosAnteriores2.Enabled = False
    CtlAccidentesTrabajo1.Visible = False
    CtlAccidentesTrabajo1.Enabled = False
    CtlAntecedentesFamiliares1.Visible = False
    CtlAntecedentesFamiliares1.Enabled = False
    CtlFactoresRiesgoTrabajoActual1.Visible = False
    CtlFactoresRiesgoTrabajoActual1.Enabled = False
    CtlActividadesExtraLaborales1.Visible = False
    CtlActividadesExtraLaborales1.Enabled = False
    CtlEnfermedadActual1.Visible = False
    CtlEnfermedadActual1.Enabled = False
    CtlRevisionOrganosSistemas1.Visible = False
    CtlRevisionOrganosSistemas1.Enabled = False
    CtlConstantesVitales1.Visible = False
    CtlConstantesVitales1.Enabled = False
    CtlExamenFisicoRegional1.Visible = False
    CtlExamenFisicoRegional1.Enabled = False
    CtlResultadosExamenes1.Visible = False
    CtlResultadosExamenes1.Enabled = False
    CtlDiagnostico1.Visible = False
    CtlDiagnostico1.Enabled = False
    CtlAptitudMedica1.Visible = False
    CtlAptitudMedica1.Enabled = False
    CtlRecomendacionesTratamientos1.Visible = False
    CtlRecomendacionesTratamientos1.Enabled = False
    CtlAntecedentesGinecoobstetricos1.Visible = False
    CtlAntecedentesGinecoobstetricos1.Enabled = False
    CtlAntecedentesReprodMasculinos1.Visible = False
    CtlAntecedentesReprodMasculinos1.Enabled = False

    CtlActividadesFactoresRiesgo1.Visible = False
    CtlActividadesFactoresRiesgo1.Enabled = False
    CtlCausaSalida1.Visible = False
    CtlCausaSalida1.Enabled = False
    CtlEvaluacionMedicaRetiro1.Visible = False
    CtlEvaluacionMedicaRetiro1.Enabled = False

    CtlClinica1.FichaMedica = mFichaMedica
    CtlDatosUsuario1.FichaMedica = mFichaMedica
    CtlMotivoConsulta1.FichaMedica = mFichaMedica
    CtlAntecedentesPersonales1.FichaMedica = mFichaMedica
    CtlHabitosToxicos1.FichaMedica = mFichaMedica
    CtlAntecedentesTrabajosAnteriores2.FichaMedica = mFichaMedica
    CtlAccidentesTrabajo1.FichaMedica = mFichaMedica
    CtlAntecedentesFamiliares1.FichaMedica = mFichaMedica
    CtlFactoresRiesgoTrabajoActual1.FichaMedica = mFichaMedica
    CtlActividadesExtraLaborales1.FichaMedica = mFichaMedica
    CtlEnfermedadActual1.FichaMedica = mFichaMedica
    CtlRevisionOrganosSistemas1.FichaMedica = mFichaMedica
    CtlConstantesVitales1.FichaMedica = mFichaMedica
    CtlExamenFisicoRegional1.FichaMedica = mFichaMedica
    CtlResultadosExamenes1.FichaMedica = mFichaMedica
    CtlDiagnostico1.FichaMedica = mFichaMedica
    CtlAptitudMedica1.FichaMedica = mFichaMedica
    CtlRecomendacionesTratamientos1.FichaMedica = mFichaMedica
    CtlAntecedentesGinecoobstetricos1.FichaMedica = mFichaMedica
    CtlAntecedentesReprodMasculinos1.FichaMedica = mFichaMedica

    CtlActividadesFactoresRiesgo1.FichaMedica = mFichaMedica
    CtlCausaSalida1.FichaMedica = mFichaMedica
    CtlEvaluacionMedicaRetiro1.FichaMedica = mFichaMedica
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      CtlClinica1.Visible = True
      CtlClinica1.Enabled = True
      CtlDatosUsuario1.Visible = True
      CtlDatosUsuario1.Enabled = True
      CtlMotivoConsulta1.Visible = True
      CtlMotivoConsulta1.Enabled = True
      CtlAntecedentesPersonales1.Visible = True
      CtlAntecedentesPersonales1.Enabled = True

      If mFichaMedica.Empleado.Entidadnatural.Pardet_Sexo = Enumerados.EnumSexo.Femenino Then
        CtlAntecedentesGinecoobstetricos1.Visible = True
        CtlAntecedentesGinecoobstetricos1.Enabled = True
      End If
      If mFichaMedica.Empleado.Entidadnatural.Pardet_Sexo = Enumerados.EnumSexo.Masculino Then
        CtlAntecedentesReprodMasculinos1.Visible = True
        CtlAntecedentesReprodMasculinos1.Enabled = True
      End If
      CtlHabitosToxicos1.Visible = True
      CtlHabitosToxicos1.Enabled = True
      CtlAntecedentesTrabajosAnteriores2.Visible = True
      CtlAntecedentesTrabajosAnteriores2.Enabled = True
      CtlAccidentesTrabajo1.Visible = True
      CtlAccidentesTrabajo1.Enabled = True
      CtlAntecedentesFamiliares1.Visible = True
      CtlAntecedentesFamiliares1.Enabled = True
      CtlFactoresRiesgoTrabajoActual1.Visible = True
      CtlFactoresRiesgoTrabajoActual1.Enabled = True
      CtlActividadesExtraLaborales1.Visible = True
      CtlActividadesExtraLaborales1.Enabled = True
      CtlEnfermedadActual1.Visible = True
      CtlEnfermedadActual1.Enabled = True
      CtlRevisionOrganosSistemas1.Visible = True
      CtlRevisionOrganosSistemas1.Enabled = True
      CtlConstantesVitales1.Visible = True
      CtlConstantesVitales1.Enabled = True
      CtlExamenFisicoRegional1.Visible = True
      CtlExamenFisicoRegional1.Enabled = True
      CtlResultadosExamenes1.Visible = True
      CtlResultadosExamenes1.Enabled = True
      CtlDiagnostico1.Visible = True
      CtlDiagnostico1.Enabled = True
      CtlAptitudMedica1.Visible = True
      CtlAptitudMedica1.Enabled = True
      CtlRecomendacionesTratamientos1.Visible = True
      CtlRecomendacionesTratamientos1.Enabled = True
    End If
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      CtlClinica1.Visible = True
      CtlClinica1.Enabled = True
      CtlMotivoConsulta1.Visible = True
      CtlMotivoConsulta1.Enabled = True
      CtlAntecedentesPersonales1.Visible = True
      CtlAntecedentesPersonales1.Enabled = True
      CtlHabitosToxicos1.Visible = True
      CtlHabitosToxicos1.Enabled = True
      CtlAccidentesTrabajo1.Visible = True
      CtlAccidentesTrabajo1.Enabled = True
      CtlAntecedentesFamiliares1.Visible = True
      CtlAntecedentesFamiliares1.Enabled = True
      CtlFactoresRiesgoTrabajoActual1.Visible = True
      CtlFactoresRiesgoTrabajoActual1.Enabled = True
      CtlEnfermedadActual1.Visible = True
      CtlEnfermedadActual1.Enabled = True
      CtlRevisionOrganosSistemas1.Visible = True
      CtlRevisionOrganosSistemas1.Enabled = True
      CtlConstantesVitales1.Visible = True
      CtlConstantesVitales1.Enabled = True
      CtlExamenFisicoRegional1.Visible = True
      CtlExamenFisicoRegional1.Enabled = True
      CtlResultadosExamenes1.Visible = True
      CtlResultadosExamenes1.Enabled = True
      CtlDiagnostico1.Visible = True
      CtlDiagnostico1.Enabled = True
      CtlAptitudMedica1.Visible = True
      CtlAptitudMedica1.Enabled = True
      CtlRecomendacionesTratamientos1.Visible = True
      CtlRecomendacionesTratamientos1.Enabled = True
    End If
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Reingreso Then
      CtlClinica1.Visible = True
      CtlClinica1.Enabled = True
      CtlCausaSalida1.Visible = True
      CtlCausaSalida1.Enabled = True
      CtlMotivoConsulta1.Visible = True
      CtlMotivoConsulta1.Enabled = True
      CtlEnfermedadActual1.Visible = True
      CtlEnfermedadActual1.Enabled = True
      CtlConstantesVitales1.Visible = True
      CtlConstantesVitales1.Enabled = True
      CtlExamenFisicoRegional1.Visible = True
      CtlExamenFisicoRegional1.Enabled = True
      CtlResultadosExamenes1.Visible = True
      CtlResultadosExamenes1.Enabled = True
      CtlDiagnostico1.Visible = True
      CtlDiagnostico1.Enabled = True
      CtlAptitudMedica1.Visible = True
      CtlAptitudMedica1.Enabled = True
      CtlRecomendacionesTratamientos1.Visible = True
      CtlRecomendacionesTratamientos1.Enabled = True
    End If
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Retiro Then
      CtlClinica1.Visible = True
      CtlClinica1.Enabled = True
      CtlCausaSalida1.Visible = True
      CtlCausaSalida1.Enabled = True
      CtlActividadesFactoresRiesgo1.Visible = True
      CtlActividadesFactoresRiesgo1.Enabled = True
      CtlMotivoConsulta1.Visible = True
      CtlMotivoConsulta1.Enabled = True
      CtlAntecedentesPersonales1.Visible = True
      CtlAntecedentesPersonales1.Enabled = True
      CtlAccidentesTrabajo1.Visible = True
      CtlAccidentesTrabajo1.Enabled = True
      CtlConstantesVitales1.Visible = True
      CtlConstantesVitales1.Enabled = True
      CtlExamenFisicoRegional1.Visible = True
      CtlExamenFisicoRegional1.Enabled = True
      CtlResultadosExamenes1.Visible = True
      CtlResultadosExamenes1.Enabled = True
      CtlDiagnostico1.Visible = True
      CtlDiagnostico1.Enabled = True
      CtlEvaluacionMedicaRetiro1.Visible = True
      CtlEvaluacionMedicaRetiro1.Enabled = True
      CtlRecomendacionesTratamientos1.Visible = True
      CtlRecomendacionesTratamientos1.Enabled = True
    End If
  End Sub

  Public Sub Mapear()
    If CtlClinica1.Enabled Then
      CtlClinica1.Mapear()
    End If
    If CtlDatosUsuario1.Enabled Then
      CtlDatosUsuario1.Mapear()
    End If
    If CtlMotivoConsulta1.Enabled Then
      CtlMotivoConsulta1.Mapear()
    End If
    If CtlAntecedentesPersonales1.Enabled Then
      CtlAntecedentesPersonales1.Mapear()
    End If
    If CtlHabitosToxicos1.Enabled Then
      CtlHabitosToxicos1.Mapear()
    End If
    If CtlAntecedentesTrabajosAnteriores2.Enabled Then
      CtlAntecedentesTrabajosAnteriores2.Mapear()
    End If
    If CtlAccidentesTrabajo1.Enabled Then
      CtlAccidentesTrabajo1.Mapear()
    End If
    If CtlAntecedentesFamiliares1.Enabled Then
      CtlAntecedentesFamiliares1.Mapear()
    End If
    If CtlFactoresRiesgoTrabajoActual1.Enabled Then
      CtlFactoresRiesgoTrabajoActual1.Mapear()
    End If
    If CtlActividadesExtraLaborales1.Enabled Then
      CtlActividadesExtraLaborales1.Mapear()
    End If
    If CtlEnfermedadActual1.Enabled Then
      CtlEnfermedadActual1.Mapear()
    End If
    If CtlRevisionOrganosSistemas1.Enabled Then
      CtlRevisionOrganosSistemas1.Mapear()
    End If
    If CtlConstantesVitales1.Enabled Then
      CtlConstantesVitales1.Mapear()
    End If
    If CtlExamenFisicoRegional1.Enabled Then
      CtlExamenFisicoRegional1.Mapear()
    End If
    If CtlResultadosExamenes1.Enabled Then
      CtlResultadosExamenes1.Mapear()
    End If
    If CtlDiagnostico1.Enabled Then
      CtlDiagnostico1.Mapear()
    End If
    If CtlAptitudMedica1.Enabled Then
      CtlAptitudMedica1.Mapear()
    End If
    If CtlRecomendacionesTratamientos1.Enabled Then
      CtlRecomendacionesTratamientos1.Mapear()
    End If
    If CtlAntecedentesGinecoobstetricos1.Enabled Then
      CtlAntecedentesGinecoobstetricos1.Mapear()
    End If
    If CtlAntecedentesReprodMasculinos1.Enabled Then
      CtlAntecedentesReprodMasculinos1.Mapear()
    End If
    If CtlActividadesFactoresRiesgo1.Enabled Then
      CtlActividadesFactoresRiesgo1.Mapear()
    End If
    If CtlCausaSalida1.Enabled Then
      CtlCausaSalida1.Mapear()
    End If
    If CtlEvaluacionMedicaRetiro1.Enabled Then
      CtlEvaluacionMedicaRetiro1.Mapear()
    End If
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub

  Private Sub FrmMantenimientoFichaMedica_AntesAceptar(sender As Object, e As CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Mapear()
          Dim nuevo As Boolean = mFichaMedica.EsNuevo
          mFichaMedica.Ficha_FechaModificacion = Now
          If Not mFichaMedica.Guardar() Then
            Throw New Exception(mFichaMedica.OperadorDatos.MsgError)
          End If
          If mFichaMedica.Contrato Is Nothing Then
            Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion,
                      String.Format("{3} {0} Ficha {1} {2}", IIf(nuevo, "Creó", "Modificó"), mFichaMedica.Empleado.NombreCompleto, mFichaMedica.PardetTipoFicha.Descripcion,
                          mFichaMedica.Entida_Codigo))
          Else
            Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion,
                      String.Format("{3}.{4}.{5} {0} Ficha {1} {2}", IIf(nuevo, "Creó", "Modificó"), mFichaMedica.Empleado.NombreCompleto, mFichaMedica.PardetTipoFicha.Descripcion,
                          mFichaMedica.Entida_Codigo, mFichaMedica.Contrato.Patron_Codigo, mFichaMedica.Contrato.Contra_Secuencia))
          End If

        Case IMantenimiento.Accion.Eliminacion
          If Not mFichaMedica.Eliminar() Then
            Throw New Exception(mFichaMedica.OperadorDatos.MsgError)
          End If
          If mFichaMedica.Contrato Is Nothing Then
            Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion,
                      String.Format("{2} Eliminó Ficha {0} {1}", mFichaMedica.Empleado.NombreCompleto, mFichaMedica.PardetTipoFicha.Descripcion, mFichaMedica.Entida_Codigo))
          Else
            Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion,
                      String.Format("{2}.{3}.{4} Eliminó Ficha {0} {1}", mFichaMedica.Empleado.NombreCompleto, mFichaMedica.PardetTipoFicha.Descripcion, mFichaMedica.Entida_Codigo,
                          mFichaMedica.Contrato.Patron_Codigo, mFichaMedica.Contrato.Contra_Secuencia))
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
#End Region
End Class