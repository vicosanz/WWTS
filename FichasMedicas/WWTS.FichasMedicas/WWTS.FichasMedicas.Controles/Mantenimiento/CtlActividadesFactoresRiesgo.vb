Imports WWTS.FichasMedicas.Reglas

Public Class CtlActividadesFactoresRiesgo

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
    Ficha_FactRieActividad1.Text = mFichaMedica.Ficha_FactRieActividad1
    Ficha_FactRieActividad2.Text = mFichaMedica.Ficha_FactRieActividad2
    Ficha_FactRieActividad3.Text = mFichaMedica.Ficha_FactRieActividad3
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_FactRieActividad1 = Ficha_FactRieActividad1.Text
    mFichaMedica.Ficha_FactRieActividad2 = Ficha_FactRieActividad2.Text
    mFichaMedica.Ficha_FactRieActividad3 = Ficha_FactRieActividad3.Text
  End Sub
End Class
