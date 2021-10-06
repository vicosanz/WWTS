

Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Datos
Imports Infoware.Consola.Base

Public Class CtlTarjEnsarte

  Private mRestriccion As Restriccion
  Public WriteOnly Property Restriccion() As Restriccion
    Set(ByVal value As Restriccion)
      mRestriccion = value
    End Set
  End Property

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlZafra1.Op = mOp
      Me.CtlLote1.Op = mOp
      Me.CtlCorte1.Op = mOp
      Me.CtlSeccionHorno1.Op = mOp
      Me.CtlSemilla1.Op = mOp
      Me.cboCicloEnsarte.OperadorDatos = mOp
      If Not value Is Nothing Then
        Me.cboCicloEnsarte.Parametro = Enumerados.EnumParametros.CicloEnsarte
        Me.cboCicloEnsarte.Llenar_Datos()
        Me.CtlZafra1.llenar_datos()
        Me.CtlLote1.llenar_datos()
        Me.CtlCorte1.llenar_datos()
        Me.CtlSeccionHorno1.llenar_datos()
        Me.CtlSemilla1.llenar_datos()
      End If
    End Set
  End Property

  Private mEnsarteZafadura As EnsarteZafadura = Nothing
  Private mManipularSueldos As Boolean = True
  Public Event CreoNuevo As System.EventHandler
  Public Event AntesNuevo As System.EventHandler
  Public Event EliminoTarjeta As System.EventHandler

  Public Property EnsarteZafadura() As EnsarteZafadura
    Get
      Return mEnsarteZafadura
    End Get
    Set(ByVal Value As EnsarteZafadura)
      mEnsarteZafadura = Value
      If Not Value Is Nothing Then
        mapearInvCajaaForma()
      Else
        Limpiarforma()
      End If
    End Set
  End Property

  Sub Limpiarforma()
    Me.txtNumEns.Text = String.Empty
    Me.CtlCorte1.Corte = Nothing
    Me.CtlZafra1.Zafra = Nothing
    Me.CtlLote1.Lote = Nothing
    Me.CtlSeccionHorno1.SeccionHorno = Nothing
    Me.CtlSemilla1.Semilla = Nothing
    Me.txtcujesnat.Text = "0"
    Me.txtcujescand.Text = "0"
    Me.pn1.Enabled = False
    Me.pn3.Enabled = False
    Me.GroupBox1.Enabled = False
    Me.btneli.Enabled = False
    Me.btnguardar.Enabled = False
    Me.chkestazafada.Checked = False
  End Sub
  Sub mapearInvCajaaForma()
    If mEnsarteZafadura Is Nothing Then
      Limpiarforma()
      Exit Sub
    End If
    Me.nuevo.Visible = Me.mEnsarteZafadura.EsNuevo
    Me.grabar.Visible = Not Me.mEnsarteZafadura.EsNuevo
    Me.btnguardar.Enabled = True
    Me.btneli.Enabled = Not Me.mEnsarteZafadura.EsNuevo
        Me.pn1.Enabled = mEnsarteZafadura.EsNuevo
        Me.pn3.Enabled = True
    Me.GroupBox1.Enabled = True

    Me.CtlZafra1.Zafra = mEnsarteZafadura.Zafra
    Me.cboCicloEnsarte.ParametroDet = mEnsarteZafadura.PardetCicloEnsarte
    Me.txtNumEns.Text = mEnsarteZafadura.Ens_numero.ToString()
    Me.CtlCorte1.Corte = mEnsarteZafadura.Corte
    Me.CtlLote1.Lote = mEnsarteZafadura.Lote
    Me.CtlSeccionHorno1.SeccionHorno = mEnsarteZafadura.SeccionHorno
    Me.CtlSemilla1.Semilla = mEnsarteZafadura.Semilla
    Me.dtpFecha.Value = CType(IIf(mEnsarteZafadura.Ens_fechaensarte = Nothing, Now.Date, mEnsarteZafadura.Ens_fechaensarte), Date)
    Me.txtcujescand.Text = mEnsarteZafadura.Ens_cujescandela.ToString()
    Me.txtcujesnat.Text = mEnsarteZafadura.Ens_cujesnatural.ToString()
    Me.chkestazafada.Checked = mEnsarteZafadura.Ens_estazafadocand Or mEnsarteZafadura.Ens_estazafadonat
    Me.dtfeczafcand.Value = CType(IIf(mEnsarteZafadura.Ens_fechazafcandela = Nothing, Now.Date, mEnsarteZafadura.Ens_fechazafcandela), Date)
    Me.txtlibzafcand.Text = mEnsarteZafadura.Ens_libcandela.ToString("0.00")
    Me.dtfeczafnat.Value = CType(IIf(mEnsarteZafadura.Ens_fechazafnatural = Nothing, Now.Date, mEnsarteZafadura.Ens_fechazafnatural), Date)
    Me.txtlibzafnat.Text = mEnsarteZafadura.Ens_libnatural.ToString("0.00")
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    RaiseEvent AntesNuevo(Me, System.EventArgs.Empty)
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      Dim nuevo As Boolean = mEnsarteZafadura.EsNuevo
      'If (Not mEnsarteZafadura.esNuevo) And (CInt(Me.txtNumEns.Text) <> mEnsarteZafadura.Ens_numero) Then
      '	mEnsarteZafadura.CambiarEmpaque(CInt(Me.txtNumEns.Text))
      'End If
      mapearFormaaInvCaja()
      If Not mEnsarteZafadura.Guardar() Then
        Throw New ArgumentException(mEnsarteZafadura.OperadorDatos.MsgError)
      Else
        Auditoria.Registrar_Auditoria(mRestriccion, Auditoria.enumTipoAccion.Adicion, String.Format("{0} Tarjeta de ensarte {1} {2}", IIf(nuevo, "Creó", "Modificó"), mEnsarteZafadura.Zafra.Zaf_descripcion, mEnsarteZafadura.Ens_numero))

        Me.txtNumEns.Text = mEnsarteZafadura.Ens_numero.ToString()
        EnsarteZafadura = mEnsarteZafadura
        If nuevo Then
          Dim _configsiembra As ConfigSiembra
          _configsiembra = New ConfigSiembra(Me.mOp)
          _configsiembra.AvanzarEnsarte()
          RaiseEvent CreoNuevo(mEnsarteZafadura, System.EventArgs.Empty)
        End If
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub btneli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneli.Click
    If Not MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNoCancel, "Pregunta") = MsgBoxResult.Yes Then
      Exit Sub
    End If
    Try
      mapearFormaaInvCaja()
      If Not mEnsarteZafadura.Eliminar() Then
        Throw New ArgumentException(mEnsarteZafadura.OperadorDatos.MsgError)
      Else
        Auditoria.Registrar_Auditoria(mRestriccion, Auditoria.enumTipoAccion.Eliminacion, String.Format("{0} Tarjeta de ensarte {1} {2}", "Eliminó", mEnsarteZafadura.Zafra.Zaf_descripcion, mEnsarteZafadura.Ens_numero))
      End If
      Me.EnsarteZafadura = Nothing

      RaiseEvent EliminoTarjeta(Me, System.EventArgs.Empty)
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Sub mapearFormaaInvCaja()
    If Not mEnsarteZafadura Is Nothing Then
      mEnsarteZafadura.Zafra = Me.CtlZafra1.Zafra
      mEnsarteZafadura.PardetCicloEnsarte = Me.cboCicloEnsarte.ParametroDet
      mEnsarteZafadura.Ens_numero = CInt(Me.txtNumEns.Text)
      mEnsarteZafadura.Corte = Me.CtlCorte1.Corte
      mEnsarteZafadura.Ens_fechaensarte = Me.dtpFecha.Value
      mEnsarteZafadura.Lote = Me.CtlLote1.Lote
      mEnsarteZafadura.Semilla = Me.CtlSemilla1.Semilla
      mEnsarteZafadura.SeccionHorno = Me.CtlSeccionHorno1.SeccionHorno
      mEnsarteZafadura.Ens_cujesnatural = CType(Me.txtcujesnat.Text, Integer)
      mEnsarteZafadura.Ens_cujescandela = CType(Me.txtcujescand.Text, Integer)

      If Not chkestazafada.Checked Then
        Me.txtlibzafnat.Text = (0).ToString("0.00")
        Me.txtlibzafcand.Text = (0).ToString("0.00")
      End If
      mEnsarteZafadura.Ens_fechazafnatural = Me.dtfeczafnat.Value
      mEnsarteZafadura.Ens_libnatural = CDec(Me.txtlibzafnat.Text)
      mEnsarteZafadura.Ens_fechazafcandela = Me.dtfeczafcand.Value
      mEnsarteZafadura.Ens_libcandela = CDec(Me.txtlibzafcand.Text)
    End If
  End Sub

  Private Sub CtlTarjEnsarte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.pn1.Enabled = False
    Me.pn3.Enabled = False
    Me.GroupBox1.Enabled = False
    Me.grabar.Visible = False
    Me.nuevo.Visible = False
  End Sub

  Private Sub chkestazafada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkestazafada.CheckedChanged
    Me.grpzafada.Visible = Me.chkestazafada.Checked
  End Sub

  Private Sub txtcujesnat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcujesnat.TextChanged
    grptabnat.Enabled = Not CInt(Me.txtcujesnat.Text) = 0
  End Sub

  Private Sub txtcujescand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcujescand.TextChanged
    grptabcand.Enabled = Not CInt(Me.txtcujescand.Text) = 0
  End Sub

End Class
