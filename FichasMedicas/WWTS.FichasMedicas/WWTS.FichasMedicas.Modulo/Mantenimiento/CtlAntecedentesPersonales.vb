Imports WWTS.FichasMedicas.Reglas

Public Class CtlAntecedentesPersonales

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
    Ficha_Antecedentes.Text = mFichaMedica.Ficha_Antecedentes
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_Antecedentes = Ficha_Antecedentes.Text
  End Sub
End Class
