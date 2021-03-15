Imports WWTS.FichasMedicas.Reglas

Public Class CtlAccidentesTrabajo

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
    Ficha_AntTrabCalif.Checked = mFichaMedica.Ficha_AntTrabCalif
    Ficha_AntTrabCalifDescripcion.Text = mFichaMedica.Ficha_AntTrabCalifDescripcion
    Ficha_AntTrabCalifFecha.Value = mFichaMedica.Ficha_AntTrabCalifFecha
    Ficha_AntTrabCalifObservacion.Text = mFichaMedica.Ficha_AntTrabCalifObservacion
    Ficha_AntTrabCalifNoReportado.Text = mFichaMedica.Ficha_AntTrabCalifNoReportado
    Ficha_EnfProfCalif.Checked = mFichaMedica.Ficha_EnfProfCalif
    Ficha_EnfProfCalifDescripcion.Text = mFichaMedica.Ficha_EnfProfCalifDescripcion
    Ficha_EnfProfCalifFecha.Value = mFichaMedica.Ficha_EnfProfCalifFecha
    Ficha_EnfProfCalifObservacion.Text = mFichaMedica.Ficha_EnfProfCalifObservacion
    Ficha_EnfProfCalifNoReportado.Text = mFichaMedica.Ficha_EnfProfCalifNoReportado
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_AntTrabCalif = Ficha_AntTrabCalif.Checked
    mFichaMedica.Ficha_AntTrabCalifDescripcion = Ficha_AntTrabCalifDescripcion.Text
    mFichaMedica.Ficha_AntTrabCalifFecha = Ficha_AntTrabCalifFecha.Value
    mFichaMedica.Ficha_AntTrabCalifObservacion = Ficha_AntTrabCalifObservacion.Text
    mFichaMedica.Ficha_AntTrabCalifNoReportado = Ficha_AntTrabCalifNoReportado.Text
    mFichaMedica.Ficha_EnfProfCalif = Ficha_EnfProfCalif.Checked
    mFichaMedica.Ficha_EnfProfCalifDescripcion = Ficha_EnfProfCalifDescripcion.Text
    mFichaMedica.Ficha_EnfProfCalifFecha = Ficha_EnfProfCalifFecha.Value
    mFichaMedica.Ficha_EnfProfCalifObservacion = Ficha_EnfProfCalifObservacion.Text
    mFichaMedica.Ficha_EnfProfCalifNoReportado = Ficha_EnfProfCalifNoReportado.Text
  End Sub
End Class
