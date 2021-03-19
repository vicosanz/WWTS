Imports WWTS.FichasMedicas.Reglas

Public Class CtlEnfermedadActual

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
    Ficha_EnfActual.Text = mFichaMedica.Ficha_EnfActual
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_EnfActual = Ficha_EnfActual.Text
  End Sub
End Class
