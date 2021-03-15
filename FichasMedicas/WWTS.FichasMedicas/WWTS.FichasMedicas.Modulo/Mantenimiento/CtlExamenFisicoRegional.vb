Imports WWTS.FichasMedicas.Reglas

Public Class CtlExamenFisicoRegional

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
    Ficha_ExaFis1a.Checked = mFichaMedica.Ficha_ExaFis1a
    Ficha_ExaFis1b.Checked = mFichaMedica.Ficha_ExaFis1b
    Ficha_ExaFis1c.Checked = mFichaMedica.Ficha_ExaFis1c

    Ficha_ExaFis2a.Checked = mFichaMedica.Ficha_ExaFis2a
    Ficha_ExaFis2b.Checked = mFichaMedica.Ficha_ExaFis2b
    Ficha_ExaFis2c.Checked = mFichaMedica.Ficha_ExaFis2c
    Ficha_ExaFis2d.Checked = mFichaMedica.Ficha_ExaFis2d
    Ficha_ExaFis2e.Checked = mFichaMedica.Ficha_ExaFis2e

    Ficha_ExaFis3a.Checked = mFichaMedica.Ficha_ExaFis3a
    Ficha_ExaFis3b.Checked = mFichaMedica.Ficha_ExaFis3b
    Ficha_ExaFis3c.Checked = mFichaMedica.Ficha_ExaFis3c

    Ficha_ExaFis4a.Checked = mFichaMedica.Ficha_ExaFis4a
    Ficha_ExaFis4b.Checked = mFichaMedica.Ficha_ExaFis4b
    Ficha_ExaFis4c.Checked = mFichaMedica.Ficha_ExaFis4c
    Ficha_ExaFis4d.Checked = mFichaMedica.Ficha_ExaFis4d
    Ficha_ExaFis4e.Checked = mFichaMedica.Ficha_ExaFis4e

    Ficha_ExaFis5a.Checked = mFichaMedica.Ficha_ExaFis5a
    Ficha_ExaFis5b.Checked = mFichaMedica.Ficha_ExaFis5b
    Ficha_ExaFis5c.Checked = mFichaMedica.Ficha_ExaFis5c
    Ficha_ExaFis5d.Checked = mFichaMedica.Ficha_ExaFis5d

    Ficha_ExaFis6a.Checked = mFichaMedica.Ficha_ExaFis6a
    Ficha_ExaFis6b.Checked = mFichaMedica.Ficha_ExaFis6b

    Ficha_ExaFis7a.Checked = mFichaMedica.Ficha_ExaFis7a
    Ficha_ExaFis7b.Checked = mFichaMedica.Ficha_ExaFis7b

    Ficha_ExaFis8a.Checked = mFichaMedica.Ficha_ExaFis8a
    Ficha_ExaFis8b.Checked = mFichaMedica.Ficha_ExaFis8b

    Ficha_ExaFis9a.Checked = mFichaMedica.Ficha_ExaFis9a
    Ficha_ExaFis9b.Checked = mFichaMedica.Ficha_ExaFis9b

    Ficha_ExaFis10a.Checked = mFichaMedica.Ficha_ExaFis10a
    Ficha_ExaFis10b.Checked = mFichaMedica.Ficha_ExaFis10b
    Ficha_ExaFis10c.Checked = mFichaMedica.Ficha_ExaFis10c

    Ficha_ExaFis11a.Checked = mFichaMedica.Ficha_ExaFis11a
    Ficha_ExaFis11b.Checked = mFichaMedica.Ficha_ExaFis11b

    Ficha_ExaFis12a.Checked = mFichaMedica.Ficha_ExaFis12a
    Ficha_ExaFis12b.Checked = mFichaMedica.Ficha_ExaFis12b
    Ficha_ExaFis12c.Checked = mFichaMedica.Ficha_ExaFis12c

    Ficha_ExaFis13a.Checked = mFichaMedica.Ficha_ExaFis13a
    Ficha_ExaFis13b.Checked = mFichaMedica.Ficha_ExaFis13b
    Ficha_ExaFis13c.Checked = mFichaMedica.Ficha_ExaFis13c
    Ficha_ExaFis13d.Checked = mFichaMedica.Ficha_ExaFis13d

    Ficha_ExaFisObservacion.Text = mFichaMedica.Ficha_ExaFisObservacion
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_ExaFis1a = Ficha_ExaFis1a.Checked
    mFichaMedica.Ficha_ExaFis1b = Ficha_ExaFis1b.Checked
    mFichaMedica.Ficha_ExaFis1c = Ficha_ExaFis1c.Checked

    mFichaMedica.Ficha_ExaFis2a = Ficha_ExaFis2a.Checked
    mFichaMedica.Ficha_ExaFis2b = Ficha_ExaFis2b.Checked
    mFichaMedica.Ficha_ExaFis2c = Ficha_ExaFis2c.Checked
    mFichaMedica.Ficha_ExaFis2d = Ficha_ExaFis2d.Checked
    mFichaMedica.Ficha_ExaFis2e = Ficha_ExaFis2e.Checked

    mFichaMedica.Ficha_ExaFis3a = Ficha_ExaFis3a.Checked
    mFichaMedica.Ficha_ExaFis3b = Ficha_ExaFis3b.Checked
    mFichaMedica.Ficha_ExaFis3c = Ficha_ExaFis3c.Checked

    mFichaMedica.Ficha_ExaFis4a = Ficha_ExaFis4a.Checked
    mFichaMedica.Ficha_ExaFis4b = Ficha_ExaFis4b.Checked
    mFichaMedica.Ficha_ExaFis4c = Ficha_ExaFis4c.Checked
    mFichaMedica.Ficha_ExaFis4d = Ficha_ExaFis4d.Checked
    mFichaMedica.Ficha_ExaFis4e = Ficha_ExaFis4e.Checked

    mFichaMedica.Ficha_ExaFis5a = Ficha_ExaFis5a.Checked
    mFichaMedica.Ficha_ExaFis5b = Ficha_ExaFis5b.Checked
    mFichaMedica.Ficha_ExaFis5c = Ficha_ExaFis5c.Checked
    mFichaMedica.Ficha_ExaFis5d = Ficha_ExaFis5d.Checked

    mFichaMedica.Ficha_ExaFis6a = Ficha_ExaFis6a.Checked
    mFichaMedica.Ficha_ExaFis6b = Ficha_ExaFis6b.Checked

    mFichaMedica.Ficha_ExaFis7a = Ficha_ExaFis7a.Checked
    mFichaMedica.Ficha_ExaFis7b = Ficha_ExaFis7b.Checked

    mFichaMedica.Ficha_ExaFis8a = Ficha_ExaFis8a.Checked
    mFichaMedica.Ficha_ExaFis8b = Ficha_ExaFis8b.Checked

    mFichaMedica.Ficha_ExaFis9a = Ficha_ExaFis9a.Checked
    mFichaMedica.Ficha_ExaFis9b = Ficha_ExaFis9b.Checked

    mFichaMedica.Ficha_ExaFis10a = Ficha_ExaFis10a.Checked
    mFichaMedica.Ficha_ExaFis10b = Ficha_ExaFis10b.Checked
    mFichaMedica.Ficha_ExaFis10c = Ficha_ExaFis10c.Checked

    mFichaMedica.Ficha_ExaFis11a = Ficha_ExaFis11a.Checked
    mFichaMedica.Ficha_ExaFis11b = Ficha_ExaFis11b.Checked

    mFichaMedica.Ficha_ExaFis12a = Ficha_ExaFis12a.Checked
    mFichaMedica.Ficha_ExaFis12b = Ficha_ExaFis12b.Checked
    mFichaMedica.Ficha_ExaFis12c = Ficha_ExaFis12c.Checked

    mFichaMedica.Ficha_ExaFis13a = Ficha_ExaFis13a.Checked
    mFichaMedica.Ficha_ExaFis13b = Ficha_ExaFis13b.Checked
    mFichaMedica.Ficha_ExaFis13c = Ficha_ExaFis13c.Checked
    mFichaMedica.Ficha_ExaFis13d = Ficha_ExaFis13d.Checked

    mFichaMedica.Ficha_ExaFisObservacion = Ficha_ExaFisObservacion.Text
  End Sub
End Class
