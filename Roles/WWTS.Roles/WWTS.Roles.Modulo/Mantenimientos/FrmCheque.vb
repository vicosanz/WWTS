Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas

Public Class FrmCheque
  Implements IMantenimiento

  Private mChequePago As ChequePago
  Public Property ChequePago() As ChequePago
    Get
      Return mChequePago
    End Get
    Set(ByVal Value As ChequePago)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un ChequePago")
      End If
      mChequePago = Value
      Me.cbotipopago.OperadorDatos = Value.OperadorDatos
      Me.cbotipopago.Parametro = Enumerados.EnumParametros.MotivoPago
      Me.cbotipopago.Llenar_Datos()
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
    If Not ChequePago Is Nothing Then
      Me.cbotipopago.ParametroDet = ChequePago.Detallelotepago.PardetMotivoPago
      Me.txtobservacion.Text = ChequePago.Detallelotepago.DeLoPa_Observacion
      'Me.chkmostrarprov.Checked = ChequePago.Detallelotepago.Delopa_mostrarenprovisiones
      Me.lblmensaje.Text = "Cheque #" & ChequePago.ChePag_Numero.ToString.Trim & " a "
      If ChequePago.Detallelotepago.Empleado Is Nothing Then
        Me.lblmensaje.Text += ""
      Else
        Me.lblmensaje.Text += ChequePago.Detallelotepago.Empleado.NombreCompleto
      End If
    End If
    Me.cbotipopago.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtobservacion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkmostrarprov.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          ChequePago.Detallelotepago.PardetMotivoPago = Me.cbotipopago.ParametroDet
          ChequePago.Detallelotepago.DeLoPa_Observacion = Me.txtobservacion.Text
          'ChequePago.Detallelotepago.Delopa_mostrarenprovisiones = Me.chkmostrarprov.Checked
          If Not ChequePago.Detallelotepago.Guardar() Then
            Throw New Exception(ChequePago.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

End Class
