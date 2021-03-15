Imports WWTS.FichasMedicas.Reglas

Public Class CtlAptitudMedica

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
    Ficha_AptMedApto.Checked = mFichaMedica.Ficha_AptMedApto
    Ficha_AptMedAptoenOb.Checked = mFichaMedica.Ficha_AptMedAptoenOb
    Ficha_AptMedAptoconLim.Checked = mFichaMedica.Ficha_AptMedAptoconLim
    Ficha_AptMedNoApto.Checked = mFichaMedica.Ficha_AptMedNoApto

    Ficha_AptMedObservacion.Text = mFichaMedica.Ficha_AptMedObservacion
    Ficha_AptMedLimitacion.Text = mFichaMedica.Ficha_AptMedLimitacion
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_AptMedApto = Ficha_AptMedApto.Checked
    mFichaMedica.Ficha_AptMedAptoenOb = Ficha_AptMedAptoenOb.Checked
    mFichaMedica.Ficha_AptMedAptoconLim = Ficha_AptMedAptoconLim.Checked
    mFichaMedica.Ficha_AptMedNoApto = Ficha_AptMedNoApto.Checked

    mFichaMedica.Ficha_AptMedObservacion = Ficha_AptMedObservacion.Text
    mFichaMedica.Ficha_AptMedLimitacion = Ficha_AptMedLimitacion.Text
  End Sub
End Class
