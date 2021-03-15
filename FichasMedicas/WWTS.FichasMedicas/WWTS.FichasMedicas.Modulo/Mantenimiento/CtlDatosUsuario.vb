Imports WWTS.FichasMedicas.Reglas

Public Class CtlDatosUsuario
  Private mFichaMedica As FichaMedica
  Public Property FichaMedica As FichaMedica
    Get
      Return mFichaMedica
    End Get
    Set(value As FichaMedica)
      mFichaMedica = value

      If Not value Is Nothing Then
        ComboBoxParametroDetGenero.OperadorDatos = value.OperadorDatos
        ComboBoxParametroDetGenero.Parametro = General.Reglas.Enumerados.EnumParametros.Genero
        ComboBoxParametroDetGenero.Llenar_Datos()

        ComboBoxParametroDetReligion.OperadorDatos = value.OperadorDatos
        ComboBoxParametroDetReligion.Parametro = General.Reglas.Enumerados.EnumParametros.Religion
        ComboBoxParametroDetReligion.Llenar_Datos()

        Actualizar()
      End If
    End Set
  End Property

  Public Sub Actualizar()
    ComboBoxParametroDetReligion.ParametroDet = mFichaMedica.PardetReligion
    ComboBoxParametroDetGenero.ParametroDet = mFichaMedica.PardetGenero
  End Sub

  Public Sub Mapear()
    mFichaMedica.PardetReligion = ComboBoxParametroDetReligion.ParametroDet
    mFichaMedica.PardetGenero = ComboBoxParametroDetGenero.ParametroDet
  End Sub
End Class
