Imports WWTS.FichasMedicas.Reglas

Public Class CtlCausaSalida

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
    Ficha_CausaSalida.Text = mFichaMedica.Ficha_CausaSalida
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_CausaSalida = Ficha_CausaSalida.Text
  End Sub
End Class
