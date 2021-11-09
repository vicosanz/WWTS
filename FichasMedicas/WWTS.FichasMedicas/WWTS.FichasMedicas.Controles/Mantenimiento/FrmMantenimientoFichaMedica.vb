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
    CtlDatosUsuario1.Visible = False
    CtlMotivoConsulta1.Visible = False
    CtlAntecedentesPersonales1.Visible = False
    CtlHabitosToxicos1.Visible = False
    CtlAntecedentesTrabajosAnteriores2.Visible = False
    CtlAccidentesTrabajo1.Visible = False
    CtlAntecedentesFamiliares1.Visible = False
    CtlFactoresRiesgoTrabajoActual1.Visible = False
    CtlActividadesExtraLaborales1.Visible = False
    CtlEnfermedadActual1.Visible = False
    CtlRevisionOrganosSistemas1.Visible = False
    CtlConstantesVitales1.Visible = False
    CtlExamenFisicoRegional1.Visible = False
    CtlResultadosExamenes1.Visible = False
    CtlDiagnostico1.Visible = False
    CtlAptitudMedica1.Visible = False
    CtlRecomendacionesTratamientos1.Visible = False
    CtlAntecedentesGinecoobstetricos1.Visible = False
    CtlAntecedentesReprodMasculinos1.Visible = False

    CtlActividadesFactoresRiesgo1.Visible = False
    CtlCausaSalida1.Visible = False
    CtlEvaluacionMedicaRetiro1.Visible = False

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
      CtlDatosUsuario1.Visible = True
      CtlMotivoConsulta1.Visible = True
      CtlAntecedentesPersonales1.Visible = True

      If mFichaMedica.Contrato.Empleado.Entidadnatural.Pardet_Sexo = Enumerados.EnumSexo.Femenino Then
        CtlAntecedentesGinecoobstetricos1.Visible = True
      End If
      If mFichaMedica.Contrato.Empleado.Entidadnatural.Pardet_Sexo = Enumerados.EnumSexo.Masculino Then
        CtlAntecedentesReprodMasculinos1.Visible = True
      End If
      CtlHabitosToxicos1.Visible = True
      CtlAntecedentesTrabajosAnteriores2.Visible = True
      CtlAccidentesTrabajo1.Visible = True
      CtlAntecedentesFamiliares1.Visible = True
      CtlFactoresRiesgoTrabajoActual1.Visible = True
      CtlActividadesExtraLaborales1.Visible = True
      CtlEnfermedadActual1.Visible = True
      CtlRevisionOrganosSistemas1.Visible = True
      CtlConstantesVitales1.Visible = True
      CtlExamenFisicoRegional1.Visible = True
      CtlResultadosExamenes1.Visible = True
      CtlDiagnostico1.Visible = True
      CtlAptitudMedica1.Visible = True
      CtlRecomendacionesTratamientos1.Visible = True

    End If
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      CtlClinica1.Visible = True
      CtlMotivoConsulta1.Visible = True
      CtlAntecedentesPersonales1.Visible = True
      CtlHabitosToxicos1.Visible = True
      CtlAccidentesTrabajo1.Visible = True
      CtlAntecedentesFamiliares1.Visible = True
      CtlFactoresRiesgoTrabajoActual1.Visible = True
      CtlEnfermedadActual1.Visible = True
      CtlRevisionOrganosSistemas1.Visible = True
      CtlConstantesVitales1.Visible = True
      CtlExamenFisicoRegional1.Visible = True
      CtlResultadosExamenes1.Visible = True
      CtlDiagnostico1.Visible = True
      CtlAptitudMedica1.Visible = True
      CtlRecomendacionesTratamientos1.Visible = True
    End If
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Reingreso Then
      CtlClinica1.Visible = True
      CtlCausaSalida1.Visible = True
      CtlMotivoConsulta1.Visible = True
      CtlEnfermedadActual1.Visible = True
      CtlConstantesVitales1.Visible = True
      CtlExamenFisicoRegional1.Visible = True
      CtlResultadosExamenes1.Visible = True
      CtlDiagnostico1.Visible = True
      CtlAptitudMedica1.Visible = True
      CtlRecomendacionesTratamientos1.Visible = True
    End If
    If mFichaMedica.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Retiro Then
      CtlClinica1.Visible = True
      CtlCausaSalida1.Visible = True
      CtlActividadesFactoresRiesgo1.Visible = True
      CtlMotivoConsulta1.Visible = True
      CtlAntecedentesPersonales1.Visible = True
      CtlAccidentesTrabajo1.Visible = True
      CtlConstantesVitales1.Visible = True
      CtlExamenFisicoRegional1.Visible = True
      CtlResultadosExamenes1.Visible = True
      CtlDiagnostico1.Visible = True
      CtlEvaluacionMedicaRetiro1.Visible = True
      CtlRecomendacionesTratamientos1.Visible = True
    End If
  End Sub

  Public Sub Mapear()
    If CtlClinica1.Visible Then
      CtlClinica1.Mapear()
    End If
    If CtlDatosUsuario1.Visible Then
      CtlDatosUsuario1.Mapear()
    End If
    If CtlMotivoConsulta1.Visible Then
      CtlMotivoConsulta1.Mapear()
    End If
    If CtlAntecedentesPersonales1.Visible Then
      CtlAntecedentesPersonales1.Mapear()
    End If
    If CtlHabitosToxicos1.Visible Then
      CtlHabitosToxicos1.Mapear()
    End If
    If CtlAntecedentesTrabajosAnteriores2.Visible Then
      CtlAntecedentesTrabajosAnteriores2.Mapear()
    End If
    If CtlAccidentesTrabajo1.Visible Then
      CtlAccidentesTrabajo1.Mapear()
    End If
    If CtlAntecedentesFamiliares1.Visible Then
      CtlAntecedentesFamiliares1.Mapear()
    End If
    If CtlFactoresRiesgoTrabajoActual1.Visible Then
      CtlFactoresRiesgoTrabajoActual1.Mapear()
    End If
    If CtlActividadesExtraLaborales1.Visible Then
      CtlActividadesExtraLaborales1.Mapear()
    End If
    If CtlEnfermedadActual1.Visible Then
      CtlEnfermedadActual1.Mapear()
    End If
    If CtlRevisionOrganosSistemas1.Visible Then
      CtlRevisionOrganosSistemas1.Mapear()
    End If
    If CtlConstantesVitales1.Visible Then
      CtlConstantesVitales1.Mapear()
    End If
    If CtlExamenFisicoRegional1.Visible Then
      CtlExamenFisicoRegional1.Mapear()
    End If
    If CtlResultadosExamenes1.Visible Then
      CtlResultadosExamenes1.Mapear()
    End If
    If CtlDiagnostico1.Visible Then
      CtlDiagnostico1.Mapear()
    End If
    If CtlAptitudMedica1.Visible Then
      CtlAptitudMedica1.Mapear()
    End If
    If CtlRecomendacionesTratamientos1.Visible Then
      CtlRecomendacionesTratamientos1.Mapear()
    End If
    If CtlAntecedentesGinecoobstetricos1.Visible Then
      CtlAntecedentesGinecoobstetricos1.Mapear()
    End If
    If CtlAntecedentesReprodMasculinos1.Visible Then
      CtlAntecedentesReprodMasculinos1.Mapear()
    End If
    If CtlActividadesFactoresRiesgo1.Visible Then
      CtlActividadesFactoresRiesgo1.Mapear()
    End If
    If CtlCausaSalida1.Visible Then
      CtlCausaSalida1.Mapear()
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

                    If Not mFichaMedica.Guardar() Then
                        Throw New Exception(mFichaMedica.OperadorDatos.MsgError)
                    End If
                    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{3}.{4}.{5} {0} Ficha {1} {2}", IIf(nuevo, "Creó", "Modificó"), mFichaMedica.Contrato.EmpleadoString, mFichaMedica.PardetTipoFicha.Descripcion, mFichaMedica.Contrato.Entida_Codigo, mFichaMedica.Contrato.Patron_Codigo, mFichaMedica.Contrato.Contra_Secuencia))

                Case IMantenimiento.Accion.Eliminacion
                    If Not mFichaMedica.Eliminar() Then
                        Throw New Exception(mFichaMedica.OperadorDatos.MsgError)
                    End If
                    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó Ficha {0} {1}", mFichaMedica.Contrato.EmpleadoString, mFichaMedica.PardetTipoFicha.Descripcion, mFichaMedica.Contrato.Entida_Codigo, mFichaMedica.Contrato.Patron_Codigo, mFichaMedica.Contrato.Contra_Secuencia))
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            e.Cancel = True
        End Try
    End Sub
#End Region
End Class