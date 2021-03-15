Imports WWTS.FichasMedicas.Reglas

Public Class CtlAntecedentesTrabajoAnterior

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

  Private mNumeral As Integer = 1
  Public Property Numeral As Integer
    Get
      Return mNumeral
    End Get
    Set(value As Integer)
      mNumeral = value
    End Set
  End Property

  Public Sub Actualizar()
    If mNumeral = 1 Then
      Ficha_AntEmplEmpresa.Text = mFichaMedica.Ficha_AntEmplEmpresa1
      Ficha_AntEmplPuesto.Text = mFichaMedica.Ficha_AntEmplPuesto1
      Ficha_AntEmplActividad.Text = mFichaMedica.Ficha_AntEmplActividad1
      Ficha_AntEmplTrabMeses.Text = mFichaMedica.Ficha_AntEmplTrabMeses1
      Ficha_AntEmplRieFis.Checked = mFichaMedica.Ficha_AntEmplRieFis1
      Ficha_AntEmplRieMec.Checked = mFichaMedica.Ficha_AntEmplRieMec1
      Ficha_AntEmplRieQui.Checked = mFichaMedica.Ficha_AntEmplRieQui1
      Ficha_AntEmplRieBio.Checked = mFichaMedica.Ficha_AntEmplRieBio1
      Ficha_AntEmplRieErg.Checked = mFichaMedica.Ficha_AntEmplRieErg1
      Ficha_AntEmplRiePsi.Checked = mFichaMedica.Ficha_AntEmplRiePsi1
      Ficha_AntEmplObs.Text = mFichaMedica.Ficha_AntEmplObs1
    ElseIf mNumeral = 2 Then
      Ficha_AntEmplEmpresa.Text = mFichaMedica.Ficha_AntEmplEmpresa2
      Ficha_AntEmplPuesto.Text = mFichaMedica.Ficha_AntEmplPuesto2
      Ficha_AntEmplActividad.Text = mFichaMedica.Ficha_AntEmplActividad2
      Ficha_AntEmplTrabMeses.Text = mFichaMedica.Ficha_AntEmplTrabMeses2
      Ficha_AntEmplRieFis.Checked = mFichaMedica.Ficha_AntEmplRieFis2
      Ficha_AntEmplRieMec.Checked = mFichaMedica.Ficha_AntEmplRieMec2
      Ficha_AntEmplRieQui.Checked = mFichaMedica.Ficha_AntEmplRieQui2
      Ficha_AntEmplRieBio.Checked = mFichaMedica.Ficha_AntEmplRieBio2
      Ficha_AntEmplRieErg.Checked = mFichaMedica.Ficha_AntEmplRieErg2
      Ficha_AntEmplRiePsi.Checked = mFichaMedica.Ficha_AntEmplRiePsi2
      Ficha_AntEmplObs.Text = mFichaMedica.Ficha_AntEmplObs2
    ElseIf mNumeral = 3 Then
      Ficha_AntEmplEmpresa.Text = mFichaMedica.Ficha_AntEmplEmpresa3
      Ficha_AntEmplPuesto.Text = mFichaMedica.Ficha_AntEmplPuesto3
      Ficha_AntEmplActividad.Text = mFichaMedica.Ficha_AntEmplActividad3
      Ficha_AntEmplTrabMeses.Text = mFichaMedica.Ficha_AntEmplTrabMeses3
      Ficha_AntEmplRieFis.Checked = mFichaMedica.Ficha_AntEmplRieFis3
      Ficha_AntEmplRieMec.Checked = mFichaMedica.Ficha_AntEmplRieMec3
      Ficha_AntEmplRieQui.Checked = mFichaMedica.Ficha_AntEmplRieQui3
      Ficha_AntEmplRieBio.Checked = mFichaMedica.Ficha_AntEmplRieBio3
      Ficha_AntEmplRieErg.Checked = mFichaMedica.Ficha_AntEmplRieErg3
      Ficha_AntEmplRiePsi.Checked = mFichaMedica.Ficha_AntEmplRiePsi3
      Ficha_AntEmplObs.Text = mFichaMedica.Ficha_AntEmplObs3
    ElseIf mNumeral = 4 Then
      Ficha_AntEmplEmpresa.Text = mFichaMedica.Ficha_AntEmplEmpresa4
      Ficha_AntEmplPuesto.Text = mFichaMedica.Ficha_AntEmplPuesto4
      Ficha_AntEmplActividad.Text = mFichaMedica.Ficha_AntEmplActividad4
      Ficha_AntEmplTrabMeses.Text = mFichaMedica.Ficha_AntEmplTrabMeses4
      Ficha_AntEmplRieFis.Checked = mFichaMedica.Ficha_AntEmplRieFis4
      Ficha_AntEmplRieMec.Checked = mFichaMedica.Ficha_AntEmplRieMec4
      Ficha_AntEmplRieQui.Checked = mFichaMedica.Ficha_AntEmplRieQui4
      Ficha_AntEmplRieBio.Checked = mFichaMedica.Ficha_AntEmplRieBio4
      Ficha_AntEmplRieErg.Checked = mFichaMedica.Ficha_AntEmplRieErg4
      Ficha_AntEmplRiePsi.Checked = mFichaMedica.Ficha_AntEmplRiePsi4
      Ficha_AntEmplObs.Text = mFichaMedica.Ficha_AntEmplObs4
    End If
  End Sub

  Public Sub Mapear()
    If mNumeral = 1 Then
      mFichaMedica.Ficha_AntEmplEmpresa1 = Ficha_AntEmplEmpresa.Text
      mFichaMedica.Ficha_AntEmplPuesto1 = Ficha_AntEmplPuesto.Text
      mFichaMedica.Ficha_AntEmplActividad1 = Ficha_AntEmplActividad.Text
      mFichaMedica.Ficha_AntEmplTrabMeses1 = Ficha_AntEmplTrabMeses.Text
      mFichaMedica.Ficha_AntEmplRieFis1 = Ficha_AntEmplRieFis.Checked
      mFichaMedica.Ficha_AntEmplRieMec1 = Ficha_AntEmplRieMec.Checked
      mFichaMedica.Ficha_AntEmplRieQui1 = Ficha_AntEmplRieQui.Checked
      mFichaMedica.Ficha_AntEmplRieBio1 = Ficha_AntEmplRieBio.Checked
      mFichaMedica.Ficha_AntEmplRieErg1 = Ficha_AntEmplRieErg.Checked
      mFichaMedica.Ficha_AntEmplRiePsi1 = Ficha_AntEmplRiePsi.Checked
      mFichaMedica.Ficha_AntEmplObs1 = Ficha_AntEmplObs.Text
    ElseIf mNumeral = 2 Then
      mFichaMedica.Ficha_AntEmplEmpresa2 = Ficha_AntEmplEmpresa.Text
      mFichaMedica.Ficha_AntEmplPuesto2 = Ficha_AntEmplPuesto.Text
      mFichaMedica.Ficha_AntEmplActividad2 = Ficha_AntEmplActividad.Text
      mFichaMedica.Ficha_AntEmplTrabMeses2 = Ficha_AntEmplTrabMeses.Text
      mFichaMedica.Ficha_AntEmplRieFis2 = Ficha_AntEmplRieFis.Checked
      mFichaMedica.Ficha_AntEmplRieMec2 = Ficha_AntEmplRieMec.Checked
      mFichaMedica.Ficha_AntEmplRieQui2 = Ficha_AntEmplRieQui.Checked
      mFichaMedica.Ficha_AntEmplRieBio2 = Ficha_AntEmplRieBio.Checked
      mFichaMedica.Ficha_AntEmplRieErg2 = Ficha_AntEmplRieErg.Checked
      mFichaMedica.Ficha_AntEmplRiePsi2 = Ficha_AntEmplRiePsi.Checked
      mFichaMedica.Ficha_AntEmplObs2 = Ficha_AntEmplObs.Text
    ElseIf mNumeral = 3 Then
      mFichaMedica.Ficha_AntEmplEmpresa3 = Ficha_AntEmplEmpresa.Text
      mFichaMedica.Ficha_AntEmplPuesto3 = Ficha_AntEmplPuesto.Text
      mFichaMedica.Ficha_AntEmplActividad3 = Ficha_AntEmplActividad.Text
      mFichaMedica.Ficha_AntEmplTrabMeses3 = Ficha_AntEmplTrabMeses.Text
      mFichaMedica.Ficha_AntEmplRieFis3 = Ficha_AntEmplRieFis.Checked
      mFichaMedica.Ficha_AntEmplRieMec3 = Ficha_AntEmplRieMec.Checked
      mFichaMedica.Ficha_AntEmplRieQui3 = Ficha_AntEmplRieQui.Checked
      mFichaMedica.Ficha_AntEmplRieBio3 = Ficha_AntEmplRieBio.Checked
      mFichaMedica.Ficha_AntEmplRieErg3 = Ficha_AntEmplRieErg.Checked
      mFichaMedica.Ficha_AntEmplRiePsi3 = Ficha_AntEmplRiePsi.Checked
      mFichaMedica.Ficha_AntEmplObs3 = Ficha_AntEmplObs.Text
    ElseIf mNumeral = 4 Then
      mFichaMedica.Ficha_AntEmplEmpresa4 = Ficha_AntEmplEmpresa.Text
      mFichaMedica.Ficha_AntEmplPuesto4 = Ficha_AntEmplPuesto.Text
      mFichaMedica.Ficha_AntEmplActividad4 = Ficha_AntEmplActividad.Text
      mFichaMedica.Ficha_AntEmplTrabMeses4 = Ficha_AntEmplTrabMeses.Text
      mFichaMedica.Ficha_AntEmplRieFis4 = Ficha_AntEmplRieFis.Checked
      mFichaMedica.Ficha_AntEmplRieMec4 = Ficha_AntEmplRieMec.Checked
      mFichaMedica.Ficha_AntEmplRieQui4 = Ficha_AntEmplRieQui.Checked
      mFichaMedica.Ficha_AntEmplRieBio4 = Ficha_AntEmplRieBio.Checked
      mFichaMedica.Ficha_AntEmplRieErg4 = Ficha_AntEmplRieErg.Checked
      mFichaMedica.Ficha_AntEmplRiePsi4 = Ficha_AntEmplRiePsi.Checked
      mFichaMedica.Ficha_AntEmplObs4 = Ficha_AntEmplObs.Text
    End If
  End Sub
End Class
