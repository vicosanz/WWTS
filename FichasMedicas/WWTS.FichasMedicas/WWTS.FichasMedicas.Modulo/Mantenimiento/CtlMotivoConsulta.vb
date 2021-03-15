Imports WWTS.FichasMedicas.Reglas

Public Class CtlMotivoConsulta

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
    Ficha_MotivoConsulta.Text = mFichaMedica.Ficha_MotivoConsulta
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_MotivoConsulta = Ficha_MotivoConsulta.Text
  End Sub
End Class
