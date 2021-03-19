Imports Infoware.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports WWTS.General.Modulo

Public Class FrmPagoVario
  Implements IMantenimiento

  Private mPagoVario As LotePagoVarioDetalle
  Public Property PagoVario() As LotePagoVarioDetalle
    Get
      Return mPagoVario
    End Get
    Set(value As LotePagoVarioDetalle)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Detalle Lote Pago")
      End If
      mPagoVario = Value
      If Not mPagoVario.OperadorDatos Is Nothing Then
        Me.CtlBuscaEmpleado1.Op = mPagoVario.OperadorDatos

        Me.cbotipopago.OperadorDatos = Value.OperadorDatos
        Me.cbotipopago.Parametro = Enumerados.EnumParametros.MotivoPago
        Me.cbotipopago.Llenar_Datos()
      End If
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not PagoVario Is Nothing Then
      If PagoVario.Empleado Is Nothing Then
        Me.txtbeneficiario.Text = ""
        Me.rdosincodigo.Checked = True
        Me.txtbeneficiario.Enabled = True
        Me.btnpersona.Text = "Clic aquí para seleccionar una persona"
        Me.btnpersona.Enabled = False
      Else
        Me.rdoconcodigo.Checked = True
        Me.txtbeneficiario.Enabled = False
        Me.btnpersona.Text = PagoVario.Empleado.NombreCompleto
        Me.btnpersona.Enabled = True
      End If
      Me.txtvalor.Text = PagoVario.LoPaDe_ValorPago.ToString("0.00")
      Me.txtobservacion.Text = PagoVario.LoPaDe_Observacion
      Me.cbotipopago.ParametroDet = PagoVario.PardetTipoPagoNomina
      Me.chkmostrarenprovisiones.Checked = PagoVario.LoPaDe_MostrarEnProvisiones
    End If

    Me.rdoconcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.rdosincodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtvalor.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtobservacion.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.cbotipopago.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If Me.rdosincodigo.Checked Then
            PagoVario.LoPaDe_Beneficiario = txtbeneficiario.Text
            PagoVario.Empleado = Nothing
          Else
            PagoVario.LoPaDe_Beneficiario = String.Empty
            PagoVario.Empleado = Me.CtlBuscaEmpleado1.Empleado
          End If
          PagoVario.LoPaDe_ValorPago = txtvalor.Value
          PagoVario.LoPaDe_Observacion = Me.txtobservacion.Text
          PagoVario.PardetTipoPagoNomina = Me.cbotipopago.ParametroDet
          PagoVario.LoPaDe_MostrarEnProvisiones = Me.chkmostrarenprovisiones.Checked
          If Not PagoVario.Guardar() Then
            Throw New Exception(PagoVario.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not PagoVario.Eliminar() Then
            Throw New Exception(PagoVario.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub rdoconcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoconcodigo.CheckedChanged
    Me.btnpersona.Enabled = Me.rdoconcodigo.Checked
  End Sub

  Private Sub btnpersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpersona.Click
    Me.CtlBuscaEmpleado1.Visible = True
    Me.CtlBuscaEmpleado1.Dock = DockStyle.Fill
    Me.CtlBuscaEmpleado1.Select()
  End Sub

  Private Sub CtlBuscaEmpleado1_BotonAtras(ByVal sender As Object, ByVal e As EventArgs) Handles CtlBuscaEmpleado1.BotonAtras
    Try
      Me.mPagoVario.Empleado = CtlBuscaEmpleado1.Empleado
      If mPagoVario.Empleado Is Nothing Then
        Me.btnpersona.Text = "Clic aquí para seleccionar una persona"
      Else
        Me.btnpersona.Text = Me.mPagoVario.Empleado.NombreCompleto
      End If
      Me.CtlBuscaEmpleado1.Visible = False
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub
End Class
