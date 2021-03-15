Imports WWTS.FichasMedicas.Reglas

Public Class CtlRevisionOrganosSistemas

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
    Ficha_RevOrgSistPiel.Checked = mFichaMedica.Ficha_RevOrgSistPiel
    Ficha_RevOrgSistOrg.Checked = mFichaMedica.Ficha_RevOrgSistOrg
    Ficha_RevOrgSistResp.Checked = mFichaMedica.Ficha_RevOrgSistResp
    Ficha_RevOrgSistCard.Checked = mFichaMedica.Ficha_RevOrgSistCard
    Ficha_RevOrgSistDig.Checked = mFichaMedica.Ficha_RevOrgSistDig
    Ficha_RevOrgSistGen.Checked = mFichaMedica.Ficha_RevOrgSistGen
    Ficha_RevOrgSistMus.Checked = mFichaMedica.Ficha_RevOrgSistMus
    Ficha_RevOrgSistEnd.Checked = mFichaMedica.Ficha_RevOrgSistEnd
    Ficha_RevOrgSistHem.Checked = mFichaMedica.Ficha_RevOrgSistHem
    Ficha_RevOrgSistNerv.Checked = mFichaMedica.Ficha_RevOrgSistNerv
    Ficha_RevOrgSistObservacion.Text = mFichaMedica.Ficha_RevOrgSistObservacion
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_RevOrgSistPiel = Ficha_RevOrgSistPiel.Checked
    mFichaMedica.Ficha_RevOrgSistOrg = Ficha_RevOrgSistOrg.Checked
    mFichaMedica.Ficha_RevOrgSistResp = Ficha_RevOrgSistResp.Checked
    mFichaMedica.Ficha_RevOrgSistCard = Ficha_RevOrgSistCard.Checked
    mFichaMedica.Ficha_RevOrgSistDig = Ficha_RevOrgSistDig.Checked
    mFichaMedica.Ficha_RevOrgSistGen = Ficha_RevOrgSistGen.Checked
    mFichaMedica.Ficha_RevOrgSistMus = Ficha_RevOrgSistMus.Checked
    mFichaMedica.Ficha_RevOrgSistEnd = Ficha_RevOrgSistEnd.Checked
    mFichaMedica.Ficha_RevOrgSistHem = Ficha_RevOrgSistHem.Checked
    mFichaMedica.Ficha_RevOrgSistNerv = Ficha_RevOrgSistNerv.Checked
    mFichaMedica.Ficha_RevOrgSistObservacion = Ficha_RevOrgSistObservacion.Text
  End Sub
End Class
