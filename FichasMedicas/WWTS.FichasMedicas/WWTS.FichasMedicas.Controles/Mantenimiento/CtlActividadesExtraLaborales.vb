Imports WWTS.FichasMedicas.Reglas

Public Class CtlActividadesExtraLaborales

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
    Ficha_ActExtrLab.Text = mFichaMedica.Ficha_ActExtrLab
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_ActExtrLab = Ficha_ActExtrLab.Text
  End Sub
End Class
