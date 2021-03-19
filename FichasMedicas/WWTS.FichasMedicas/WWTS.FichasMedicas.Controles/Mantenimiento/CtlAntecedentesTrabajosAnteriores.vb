Imports WWTS.FichasMedicas.Reglas

Public Class CtlAntecedentesTrabajosAnteriores

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
    CtlAntecedentesTrabajoAnterior1.Numeral = 1
    CtlAntecedentesTrabajoAnterior2.Numeral = 2
    CtlAntecedentesTrabajoAnterior3.Numeral = 3
    CtlAntecedentesTrabajoAnterior4.Numeral = 4
    CtlAntecedentesTrabajoAnterior1.FichaMedica = mFichaMedica
    CtlAntecedentesTrabajoAnterior2.FichaMedica = mFichaMedica
    CtlAntecedentesTrabajoAnterior3.FichaMedica = mFichaMedica
    CtlAntecedentesTrabajoAnterior4.FichaMedica = mFichaMedica
  End Sub

  Public Sub Mapear()
    CtlAntecedentesTrabajoAnterior1.Mapear()
    CtlAntecedentesTrabajoAnterior2.Mapear()
    CtlAntecedentesTrabajoAnterior3.Mapear()
    CtlAntecedentesTrabajoAnterior4.Mapear()
  End Sub
End Class
