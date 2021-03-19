Imports WWTS.FichasMedicas.Reglas

Public Class CtlFactoresRiesgoTrabajoActual

  Private mFichaMedica As FichaMedica
  Public Property FichaMedica As FichaMedica
    Get
      Return mFichaMedica
    End Get
    Set(value As FichaMedica)
      mFichaMedica = value
      If Not value Is Nothing Then
        Actualizar()
      End If
    End Set
  End Property

  Public Sub Actualizar()
    CtlFactorRiesgoTrabajoActual1.Numeral = 1
    CtlFactorRiesgoTrabajoActual2.Numeral = 2
    CtlFactorRiesgoTrabajoActual3.Numeral = 3
    CtlFactorRiesgoTrabajoActual4.Numeral = 4
    CtlFactorRiesgoTrabajoActual1.FichaMedica = mFichaMedica
    CtlFactorRiesgoTrabajoActual2.FichaMedica = mFichaMedica
    CtlFactorRiesgoTrabajoActual3.FichaMedica = mFichaMedica
    CtlFactorRiesgoTrabajoActual4.FichaMedica = mFichaMedica
  End Sub

  Public Sub Mapear()
    CtlFactorRiesgoTrabajoActual1.Mapear()
    CtlFactorRiesgoTrabajoActual2.Mapear()
    CtlFactorRiesgoTrabajoActual3.Mapear()
    CtlFactorRiesgoTrabajoActual4.Mapear()
  End Sub

  Private Sub CtlFactorRiesgoTrabajoActual1_Load(sender As Object, e As EventArgs) Handles CtlFactorRiesgoTrabajoActual1.Load

  End Sub
End Class
