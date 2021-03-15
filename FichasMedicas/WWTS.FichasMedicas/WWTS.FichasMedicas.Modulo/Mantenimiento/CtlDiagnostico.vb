Imports WWTS.FichasMedicas.Reglas

Public Class CtlDiagnostico

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
    Ficha_Diag1.Text = mFichaMedica.Ficha_Diag1
    Ficha_Diag2.Text = mFichaMedica.Ficha_Diag2
    Ficha_Diag3.Text = mFichaMedica.Ficha_Diag3
    Ficha_DiagCIE1.Text = mFichaMedica.Ficha_DiagCIE1
    Ficha_DiagCIE2.Text = mFichaMedica.Ficha_DiagCIE2
    Ficha_DiagCIE3.Text = mFichaMedica.Ficha_DiagCIE3
    Ficha_DiagDef1.Checked = mFichaMedica.Ficha_DiagDef1
    Ficha_DiagDef2.Checked = mFichaMedica.Ficha_DiagDef2
    Ficha_DiagDef3.Checked = mFichaMedica.Ficha_DiagDef3
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_Diag1 = Ficha_Diag1.Text
    mFichaMedica.Ficha_Diag2 = Ficha_Diag2.Text
    mFichaMedica.Ficha_Diag3 = Ficha_Diag3.Text
    mFichaMedica.Ficha_DiagCIE1 = Ficha_DiagCIE1.Text
    mFichaMedica.Ficha_DiagCIE2 = Ficha_DiagCIE2.Text
    mFichaMedica.Ficha_DiagCIE3 = Ficha_DiagCIE3.Text
    mFichaMedica.Ficha_DiagDef1 = Ficha_DiagDef1.Checked
    mFichaMedica.Ficha_DiagDef2 = Ficha_DiagDef2.Checked
    mFichaMedica.Ficha_DiagDef3 = Ficha_DiagDef3.Checked
  End Sub
End Class
