Imports Infoware.Datos
Imports WWTS.Roles.Reglas
Imports Infoware.Reglas
Imports WWTS.General.Reglas

Public Class CtlConfigRoles

  Private mOp As OperadorDatos
  Private mConfigRoles As ConfigRoles = Nothing
  Public Event CambioBanco()

  Public Property op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal Value As OperadorDatos)
      If Not Value Is Nothing Then
        mOp = Value
        Me.CtlPais1.OperadorDatos = mOp
        Me.CtlPais1.Parametro = Enumerados.EnumParametros.Pais
        Me.CtlPais1.llenar_datos()
      End If
    End Set
  End Property

  Private Sub mostrar_ConfigRoles()
    If mOp Is Nothing OrElse CtlPais1.ParametroDet Is Nothing Then
      Exit Sub
    End If
    mConfigRoles = New ConfigRoles(Me.op, Me.CtlPais1.ParametroDet, False)
    Me.pnlConfigRoles.Visible = True
    Me.txtsalariomv.Value = mConfigRoles.Cnfrol_salariomv
    Me.txtvalorhora.Value = mConfigRoles.Cnfrol_valorhora
    Me.txtcompsal.Value = mConfigRoles.Cnfrol_compsal
    Me.txtiesspersonal.Value = mConfigRoles.Cnfrol_porciesspersonal
    Me.txtiesspatronal.Value = mConfigRoles.Cnfrol_porciesspatronal
    Me.txtiece.Value = mConfigRoles.Cnfrol_porciece
    Me.txtsecap.Value = mConfigRoles.Cnfrol_porcsecap
    Me.txtiessporhoras.Value = mConfigRoles.Cnfrol_porciessporhora
    Me.txtvalorhoraiess.Value = mConfigRoles.Cnfrol_valorhoraiess
    Me.txtporcsubmatenf.Value = mConfigRoles.Cnfrol_porcpagsubmatenf

    Me.txtfactor25.Value = mConfigRoles.Cnfrol_factorHora25
    Me.txtfactor50.Value = mConfigRoles.Cnfrol_factorHora50
    Me.txtfactor100.Value = mConfigRoles.Cnfrol_factorHora100
    Me.chkMensualizFM.Checked = mConfigRoles.Cnfrol_MensualizFM
  End Sub

  Private Sub CtlPais1_CambioPais(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlPais1.CambioItem
    mostrar_ConfigRoles()
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      mConfigRoles.PardetPais = Me.CtlPais1.ParametroDet
      mConfigRoles.CnfRol_salariomv = Me.txtsalariomv.Value
      mConfigRoles.CnfRol_valorhora = Me.txtvalorhora.Value
      mConfigRoles.CnfRol_compsal = Me.txtcompsal.Value
      mConfigRoles.CnfRol_porciesspersonal = Me.txtiesspersonal.Value
      mConfigRoles.CnfRol_porciesspatronal = Me.txtiesspatronal.Value
      mConfigRoles.CnfRol_porciece = Me.txtiece.Value
      mConfigRoles.CnfRol_porcsecap = Me.txtsecap.Value
      mConfigRoles.CnfRol_porciessporhora = Me.txtiessporhoras.Value
      mConfigRoles.CnfRol_valorhoraiess = Me.txtvalorhoraiess.Value
      mConfigRoles.CnfRol_porcpagsubmatenf = Me.txtporcsubmatenf.Value

      mConfigRoles.Cnfrol_factorHora25 = Me.txtfactor25.Value
      mConfigRoles.Cnfrol_factorHora50 = Me.txtfactor50.Value
      mConfigRoles.Cnfrol_factorHora100 = Me.txtfactor100.Value

      mConfigRoles.Cnfrol_MensualizFM = Me.chkMensualizFM.Checked

      If Not mConfigRoles.Guardar Then
        Throw New Exception(mConfigRoles.OperadorDatos.MsgError)
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    mostrar_ConfigRoles()
  End Sub
End Class
