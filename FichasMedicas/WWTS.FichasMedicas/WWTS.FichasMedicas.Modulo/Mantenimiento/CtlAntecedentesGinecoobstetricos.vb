Imports WWTS.FichasMedicas.Reglas

Public Class CtlAntecedentesGinecoobstetricos

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
    Ficha_FecMenarq.Value = mFichaMedica.Ficha_FecMenarq
    Ficha_FUM.Value = mFichaMedica.Ficha_FUM
    Ficha_Ciclos.Text = mFichaMedica.Ficha_Ciclos
    Ficha_Gestas.Text = mFichaMedica.Ficha_Gestas
    Ficha_Partos.Text = mFichaMedica.Ficha_Partos
    Ficha_Cesareas.Text = mFichaMedica.Ficha_Cesareas
    Ficha_Abortos.Text = mFichaMedica.Ficha_Abortos
    Ficha_HijosVivos.Text = mFichaMedica.Ficha_HijosVivos
    Ficha_HijosMuertos.Text = mFichaMedica.Ficha_HijosMuertos
    Ficha_VSA.Checked = mFichaMedica.Ficha_VSA
    Ficha_MPF.Checked = mFichaMedica.Ficha_MPF
    Ficha_MPFTipo1.Text = mFichaMedica.Ficha_MPFTipo1

    Ficha_Papanic.Checked = mFichaMedica.Ficha_Papanic
    Ficha_PapanicAnios.Text = mFichaMedica.Ficha_PapanicAnios
    Ficha_PapanicResult.Text = mFichaMedica.Ficha_PapanicResult

    Ficha_Colposcop.Checked = mFichaMedica.Ficha_Colposcop
    Ficha_ColposcopAnios.Text = mFichaMedica.Ficha_ColposcopAnios
    Ficha_ColposcopResult.Text = mFichaMedica.Ficha_ColposcopResult

    Ficha_EcoMamario.Checked = mFichaMedica.Ficha_EcoMamario
    Ficha_EcoMamarioAnios.Text = mFichaMedica.Ficha_EcoMamarioAnios
    Ficha_EcoMamarioResult.Text = mFichaMedica.Ficha_EcoMamarioResult

    Ficha_Mamogra.Checked = mFichaMedica.Ficha_Mamogra
    Ficha_MamograAnios.Text = mFichaMedica.Ficha_MamograAnios
    Ficha_MamograResult.Text = mFichaMedica.Ficha_MamograResult
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_FecMenarq = Ficha_FecMenarq.Value
    mFichaMedica.Ficha_FUM = Ficha_FUM.Value
    mFichaMedica.Ficha_Ciclos = Ficha_Ciclos.Text
    mFichaMedica.Ficha_Gestas = Ficha_Gestas.Text
    mFichaMedica.Ficha_Partos = Ficha_Partos.Text
    mFichaMedica.Ficha_Cesareas = Ficha_Cesareas.Text
    mFichaMedica.Ficha_Abortos = Ficha_Abortos.Text
    mFichaMedica.Ficha_HijosVivos = Ficha_HijosVivos.Text
    mFichaMedica.Ficha_HijosMuertos = Ficha_HijosMuertos.Text
    mFichaMedica.Ficha_VSA = Ficha_VSA.Checked
    mFichaMedica.Ficha_MPF = Ficha_MPF.Checked
    mFichaMedica.Ficha_MPFTipo1 = Ficha_MPFTipo1.Text

    mFichaMedica.Ficha_Papanic = Ficha_Papanic.Checked
    mFichaMedica.Ficha_PapanicAnios = Ficha_PapanicAnios.Text
    mFichaMedica.Ficha_PapanicResult = Ficha_PapanicResult.Text

    mFichaMedica.Ficha_Colposcop = Ficha_Colposcop.Checked
    mFichaMedica.Ficha_ColposcopAnios = Ficha_ColposcopAnios.Text
    mFichaMedica.Ficha_ColposcopResult = Ficha_ColposcopResult.Text

    mFichaMedica.Ficha_EcoMamario = Ficha_EcoMamario.Checked
    mFichaMedica.Ficha_EcoMamarioAnios = Ficha_EcoMamarioAnios.Text
    mFichaMedica.Ficha_EcoMamarioResult = Ficha_EcoMamarioResult.Text

    mFichaMedica.Ficha_Mamogra = Ficha_Mamogra.Checked
    mFichaMedica.Ficha_MamograAnios = Ficha_MamograAnios.Text
    mFichaMedica.Ficha_MamograResult = Ficha_MamograResult.Text
  End Sub
End Class
