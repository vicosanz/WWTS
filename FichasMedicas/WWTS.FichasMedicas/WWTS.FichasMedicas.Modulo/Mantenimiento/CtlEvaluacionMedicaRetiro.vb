Imports WWTS.FichasMedicas.Reglas

Public Class CtlEvaluacionMedicaRetiro

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
    Ficha_EvMedRetiroObservacion.Text = mFichaMedica.Ficha_EvMedRetiroObservacion
    Ficha_EvMedRetiro.Checked = mFichaMedica.Ficha_EvMedRetiro
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_EvMedRetiroObservacion = Ficha_EvMedRetiroObservacion.Text
    mFichaMedica.Ficha_EvMedRetiro = Ficha_EvMedRetiro.Checked
  End Sub
End Class
