Imports WWTS.FichasMedicas.Reglas

Public Class CtlRecomendacionesTratamientos

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
    Ficha_RecomTratamiento.Text = mFichaMedica.Ficha_RecomTratamiento
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_RecomTratamiento = Ficha_RecomTratamiento.Text
  End Sub
End Class
