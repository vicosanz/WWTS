Imports WWTS.FichasMedicas.Reglas

Public Class CtlResultadosExamenes

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
    Ficha_ResExaGen1.Text = mFichaMedica.Ficha_ResExaGen1
    Ficha_ResExaGen2.Text = mFichaMedica.Ficha_ResExaGen2
    Ficha_ResExaGen3.Text = mFichaMedica.Ficha_ResExaGen3
    Ficha_ResExaGen4.Text = mFichaMedica.Ficha_ResExaGen4
    Ficha_ResExaGenFec1.Value = mFichaMedica.Ficha_ResExaGenFec1
    Ficha_ResExaGenFec2.Value = mFichaMedica.Ficha_ResExaGenFec2
    Ficha_ResExaGenFec3.Value = mFichaMedica.Ficha_ResExaGenFec3
    Ficha_ResExaGenFec4.Value = mFichaMedica.Ficha_ResExaGenFec4
    Ficha_ResExaGenRes1.Text = mFichaMedica.Ficha_ResExaGenRes1
    Ficha_ResExaGenRes2.Text = mFichaMedica.Ficha_ResExaGenRes2
    Ficha_ResExaGenRes3.Text = mFichaMedica.Ficha_ResExaGenRes3
    Ficha_ResExaGenRes4.Text = mFichaMedica.Ficha_ResExaGenRes4
    Ficha_ResExaGenObservacion.Text = mFichaMedica.Ficha_ResExaGenObservacion
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_ResExaGen1 = Ficha_ResExaGen1.Text
    mFichaMedica.Ficha_ResExaGen2 = Ficha_ResExaGen2.Text
    mFichaMedica.Ficha_ResExaGen3 = Ficha_ResExaGen3.Text
    mFichaMedica.Ficha_ResExaGen4 = Ficha_ResExaGen4.Text
    mFichaMedica.Ficha_ResExaGenFec1 = Ficha_ResExaGenFec1.Value
    mFichaMedica.Ficha_ResExaGenFec2 = Ficha_ResExaGenFec2.Value
    mFichaMedica.Ficha_ResExaGenFec3 = Ficha_ResExaGenFec3.Value
    mFichaMedica.Ficha_ResExaGenFec4 = Ficha_ResExaGenFec4.Value
    mFichaMedica.Ficha_ResExaGenRes1 = Ficha_ResExaGenRes1.Text
    mFichaMedica.Ficha_ResExaGenRes2 = Ficha_ResExaGenRes2.Text
    mFichaMedica.Ficha_ResExaGenRes3 = Ficha_ResExaGenRes3.Text
    mFichaMedica.Ficha_ResExaGenRes4 = Ficha_ResExaGenRes4.Text
    mFichaMedica.Ficha_ResExaGenObservacion = Ficha_ResExaGenObservacion.Text
  End Sub
End Class
