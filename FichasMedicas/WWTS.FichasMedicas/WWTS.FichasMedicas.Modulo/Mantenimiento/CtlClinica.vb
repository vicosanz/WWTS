Imports WWTS.FichasMedicas.Reglas

Public Class CtlClinica
  Private mFichaMedica As FichaMedica
  Public Property FichaMedica As FichaMedica
    Get
      Return mFichaMedica
    End Get
    Set(value As FichaMedica)
      mFichaMedica = value

      If Not value Is Nothing Then
        ComboBoxParametroDetClinica.OperadorDatos = value.OperadorDatos
        ComboBoxParametroDetClinica.Parametro = General.Reglas.Enumerados.EnumParametros.Clinica
        ComboBoxParametroDetClinica.Llenar_Datos()

        Actualizar()
      End If
    End Set
  End Property

  Public Sub Actualizar()
    ComboBoxParametroDetClinica.ParametroDet = mFichaMedica.PardetClinica
    Ficha_ArchivoNum.Text = mFichaMedica.Ficha_ArchivoNum
  End Sub

  Public Sub Mapear()
    mFichaMedica.PardetClinica = ComboBoxParametroDetClinica.ParametroDet
    mFichaMedica.Ficha_ArchivoNum = Ficha_ArchivoNum.Text
  End Sub
End Class
