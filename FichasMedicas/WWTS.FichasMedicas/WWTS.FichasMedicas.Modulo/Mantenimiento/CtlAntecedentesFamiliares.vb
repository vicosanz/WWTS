Imports WWTS.FichasMedicas.Reglas

Public Class CtlAntecedentesFamiliares

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
    Ficha_AntFamEnfCard.Checked = mFichaMedica.Ficha_AntFamEnfCard
    Ficha_AntFamEnfMet.Checked = mFichaMedica.Ficha_AntFamEnfMet
    Ficha_AntFamEnfNeu.Checked = mFichaMedica.Ficha_AntFamEnfNeu
    Ficha_AntFamEnfOnc.Checked = mFichaMedica.Ficha_AntFamEnfOnc
    Ficha_AntFamEnfInf.Checked = mFichaMedica.Ficha_AntFamEnfInf
    Ficha_AntFamEnfHer.Checked = mFichaMedica.Ficha_AntFamEnfHer
    Ficha_AntFamEnfDisc.Checked = mFichaMedica.Ficha_AntFamEnfDisc
    Ficha_AntFamEnfOtro.Checked = mFichaMedica.Ficha_AntFamEnfOtro
    Ficha_AntFamObservacion.Text = mFichaMedica.Ficha_AntFamObservacion
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_AntFamEnfCard = Ficha_AntFamEnfCard.Checked
    mFichaMedica.Ficha_AntFamEnfMet = Ficha_AntFamEnfMet.Checked
    mFichaMedica.Ficha_AntFamEnfNeu = Ficha_AntFamEnfNeu.Checked
    mFichaMedica.Ficha_AntFamEnfOnc = Ficha_AntFamEnfOnc.Checked
    mFichaMedica.Ficha_AntFamEnfInf = Ficha_AntFamEnfInf.Checked
    mFichaMedica.Ficha_AntFamEnfHer = Ficha_AntFamEnfHer.Checked
    mFichaMedica.Ficha_AntFamEnfDisc = Ficha_AntFamEnfDisc.Checked
    mFichaMedica.Ficha_AntFamEnfOtro = Ficha_AntFamEnfOtro.Checked
    mFichaMedica.Ficha_AntFamObservacion = Ficha_AntFamObservacion.Text
  End Sub
End Class
