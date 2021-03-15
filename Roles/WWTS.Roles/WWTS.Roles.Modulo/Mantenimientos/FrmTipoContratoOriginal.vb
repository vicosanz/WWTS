Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmTipoContratoOriginal
  Implements IMantenimiento

  Private mTipoContrato As TipoContrato
  Public Property TipoContrato() As TipoContrato
    Get
      Return mTipoContrato
    End Get
    Set(ByVal Value As TipoContrato)
      mTipoContrato = Value
      If Value IsNot Nothing Then
        Me.cbotipocontrato.OperadorDatos = Value.OperadorDatos
        Me.cbotipocontrato.Parametro = Enumerados.EnumParametros.TipoContrato
        Me.cbotipocontrato.Llenar_Datos()
        Me.cboperpago.OperadorDatos = Value.OperadorDatos
        Me.cboperpago.Parametro = Enumerados.EnumParametros.PeriodoPago
        Me.cboperpago.Llenar_Datos()
      End If

      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not TipoContrato Is Nothing Then
      Me.txtcodigo.Text = TipoContrato.TipCon_Codigo
      Me.txtdescripcion.Text = TipoContrato.TipCon_Descripcion
      Me.cboperpago.ParametroDet = TipoContrato.PardetPeriodoPago
      Me.cbotipocontrato.ParametroDet = TipoContrato.PardetTipoContrato
      Me.txttiempom.Text = TipoContrato.TipCon_Caducidadmeses

      Me.pnlnodestajo.Visible = Not TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo
      Me.pnlvalorhora.Visible = TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras

      'If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
      'Me.CtlLabor1.Labor = TipoContrato.Labor
      'Else
      'Me.btncontrato.Text = TipoContrato.TipCon_Contrato
      'Me.btnrenuncia.Text = TipoContrato.TipCon_Renuncia
      'Me.btndespido.Text = TipoContrato.TipCon_Despido
      'Me.btnsuspension.Text = TipoContrato.TipCon_Suspension
      'Me.btnllamada.Text = TipoContrato.TipCon_LlamadaAtencion
      'Me.btncertificado.Text = TipoContrato.TipCon_CertificadoTrabajo
      Me.chkficharojadespido.Checked = TipoContrato.TipCon_FichaRojaDespido
      Me.chkficharojarenuncia.Checked = TipoContrato.TipCon_FichaRojaRenuncia
      Me.chkturnosrotativos.Checked = TipoContrato.TipCon_TurnosRotativos
      'End If

      If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
        Me.txtvalorhora.Value = TipoContrato.TipCon_valorhora
        Me.txtvalorslv.Value = TipoContrato.TipCon_valorSLV
        Me.txtvalorssdf.Value = TipoContrato.TipCon_valorSSDF
      End If

      Me.txthorasdiarias.Value = TipoContrato.TipCon_HorasDiarias
      Me.txthorassemanales.Value = TipoContrato.TipCon_HorasSemanales
    End If

    Me.txtcodigo.Enabled = False
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txttiempom.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.cboperpago.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.cbotipocontrato.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion

    Me.btncontrato.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.btnrenuncia.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.btndespido.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.btnsuspension.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.btnllamada.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.btncertificado.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkficharojadespido.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkficharojarenuncia.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion

    Me.txthorasdiarias.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txthorassemanales.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          TipoContrato.TipCon_Codigo = Me.txtcodigo.Text
          TipoContrato.TipCon_Descripcion = Me.txtdescripcion.Text

          TipoContrato.TipCon_Caducidadmeses = Me.txttiempom.Text
          TipoContrato.PardetPeriodoPago = Me.cboperpago.ParametroDet
          TipoContrato.PardetTipoContrato = Me.cbotipocontrato.ParametroDet
          'If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
          'TipoContrato.Labor = Me.CtlLabor1.Labor
          'Else
          'TipoContrato.TipCon_Contrato = Me.btncontrato.Text
          'TipoContrato.TipCon_Renuncia = Me.btnrenuncia.Text
          'TipoContrato.TipCon_Despido = Me.btndespido.Text
          'TipoContrato.TipCon_Suspension = Me.btnsuspension.Text
          'TipoContrato.TipCon_LlamadaAtencion = Me.btnllamada.Text
          'TipoContrato.TipCon_CertificadoTrabajo = Me.btncertificado.Text
          TipoContrato.TipCon_FichaRojaDespido = Me.chkficharojadespido.Checked
          TipoContrato.TipCon_FichaRojaRenuncia = Me.chkficharojarenuncia.Checked
          TipoContrato.TipCon_TurnosRotativos = Me.chkturnosrotativos.Checked
          'End If
          'If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
          If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
            TipoContrato.TipCon_valorhora = Me.txtvalorhora.Value
            TipoContrato.TipCon_valorSLV = Me.txtvalorslv.Value
            TipoContrato.TipCon_valorSSDF = Me.txtvalorssdf.Value
          End If

          TipoContrato.TipCon_HorasDiarias = Me.txthorasdiarias.Value
          TipoContrato.TipCon_HorasSemanales = Me.txthorassemanales.Value

          If Not TipoContrato.Guardar() Then
            Throw New Exception(TipoContrato.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not TipoContrato.Eliminar() Then
            Throw New Exception(TipoContrato.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub btncontrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontrato.Click
    With ofd
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btncontrato.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnrenuncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrenuncia.Click
    With ofd
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btnrenuncia.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btndespido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndespido.Click
    With ofd
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btndespido.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnsuspension_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsuspension.Click
    With ofd
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btnsuspension.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnllamada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnllamada.Click
    With ofd
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btnllamada.Text = .FileName
      End If
    End With
  End Sub

  Private Sub cbotipocontrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipocontrato.SelectedIndexChanged
    Me.pnlnodestajo.Visible = Not cbotipocontrato.SelectedValue = Enumerados.enumTipoContrato.Destajo
    Me.pnlvalorhora.Visible = cbotipocontrato.SelectedValue = Enumerados.enumTipoContrato.Destajo Or cbotipocontrato.SelectedValue = Enumerados.enumTipoContrato.PorHoras
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region

  Private Sub btncertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncertificado.Click
    With ofd
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btncertificado.Text = .FileName
      End If
    End With

  End Sub
End Class
