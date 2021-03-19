Imports WWTS.FichasMedicas.Reglas

Public Class CtlAntecedentesReprodMasculinos

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
    Ficha_AntigProst.Checked = mFichaMedica.Ficha_AntigProst
    Ficha_AntigProstAnios.Text = mFichaMedica.Ficha_AntigProstAnios
    Ficha_AntigProstResult.Text = mFichaMedica.Ficha_AntigProstResult

    Ficha_EcoProst.Checked = mFichaMedica.Ficha_EcoProst
    Ficha_EcoProstAnios.Text = mFichaMedica.Ficha_EcoProstAnios
    Ficha_EcoProstResult.Text = mFichaMedica.Ficha_EcoProstResult

    Ficha_HijosVivos.Text = mFichaMedica.Ficha_HijosVivos
    Ficha_HijosMuertos.Text = mFichaMedica.Ficha_HijosMuertos

    Ficha_MPF.Checked = mFichaMedica.Ficha_MPF
    Ficha_MPFTipo1.Text = mFichaMedica.Ficha_MPFTipo1
    Ficha_MPFTipo2.Text = mFichaMedica.Ficha_MPFTipo2
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_AntigProst = Ficha_AntigProst.Checked
    mFichaMedica.Ficha_AntigProstAnios = Ficha_AntigProstAnios.Text
    mFichaMedica.Ficha_AntigProstResult = Ficha_AntigProstResult.Text

    mFichaMedica.Ficha_EcoProst = Ficha_EcoProst.Checked
    mFichaMedica.Ficha_EcoProstAnios = Ficha_EcoProstAnios.Text
    mFichaMedica.Ficha_EcoProstResult = Ficha_EcoProstResult.Text

    mFichaMedica.Ficha_HijosVivos = Ficha_HijosVivos.Text
    mFichaMedica.Ficha_HijosMuertos = Ficha_HijosMuertos.Text

    mFichaMedica.Ficha_MPF = Ficha_MPF.Checked
    mFichaMedica.Ficha_MPFTipo1 = Ficha_MPFTipo1.Text
    mFichaMedica.Ficha_MPFTipo2 = Ficha_MPFTipo2.Text
  End Sub
End Class
