Imports WWTS.FichasMedicas.Reglas

Public Class CtlConstantesVitales

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
    Ficha_ConstVitPresArt.Text = mFichaMedica.Ficha_ConstVitPresArt
    Ficha_ConstVitTemp.Text = mFichaMedica.Ficha_ConstVitTemp
    Ficha_ConstVitFrecCard.Text = mFichaMedica.Ficha_ConstVitFrecCard
    Ficha_ConstVitSatOxi.Text = mFichaMedica.Ficha_ConstVitSatOxi
    Ficha_ConstVitFrecResp.Text = mFichaMedica.Ficha_ConstVitFrecResp
    Ficha_ConstVitPeso.Text = mFichaMedica.Ficha_ConstVitPeso
    Ficha_ConstVitTalla.Text = mFichaMedica.Ficha_ConstVitTalla
    Ficha_ConstVitIMC.Text = mFichaMedica.Ficha_ConstVitIMC
    Ficha_ConstVitPeriAbdo.Text = mFichaMedica.Ficha_ConstVitPeriAbdo
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_ConstVitPresArt = Ficha_ConstVitPresArt.Text
    mFichaMedica.Ficha_ConstVitTemp = Ficha_ConstVitTemp.Text
    mFichaMedica.Ficha_ConstVitFrecCard = Ficha_ConstVitFrecCard.Text
    mFichaMedica.Ficha_ConstVitSatOxi = Ficha_ConstVitSatOxi.Text
    mFichaMedica.Ficha_ConstVitFrecResp = Ficha_ConstVitFrecResp.Text
    mFichaMedica.Ficha_ConstVitPeso = Ficha_ConstVitPeso.Text
    mFichaMedica.Ficha_ConstVitTalla = Ficha_ConstVitTalla.Text
    mFichaMedica.Ficha_ConstVitIMC = Ficha_ConstVitIMC.Text
    mFichaMedica.Ficha_ConstVitPeriAbdo = Ficha_ConstVitPeriAbdo.Text
  End Sub
End Class
