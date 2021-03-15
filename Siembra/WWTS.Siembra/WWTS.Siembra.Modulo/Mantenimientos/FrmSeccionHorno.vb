
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmSeccionHorno
  Implements IMantenimiento

  Private mSeccionHorno As SeccionHorno
  Public Property SeccionHorno() As SeccionHorno
    Get
      Return mSeccionHorno
    End Get
    Set(ByVal Value As SeccionHorno)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un SeccionHorno")
      End If
      mSeccionHorno = Value
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
    If Not SeccionHorno Is Nothing Then
      Me.txtcodigo.Value = SeccionHorno.Sec_codigo
      Me.lblmensaje.Text = "Sección del horno " & SeccionHorno.Horno.Hor_descripcion
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.pnlnuevo.Visible = (mDireccion = IMantenimiento.Accion.Ingreso)
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If Me.chkhasta.Checked Then
            If Me.txthasta.Value < Me.txtcodigo.Value Then
              Throw New Exception("El valor hasta debe ser superior al código")
            End If
            If txthasta.Value - Me.txtcodigo.Value > 30 Then
              If MsgBox("¿Está seguro que desea generar un lote grande de códigos?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Throw New Exception("Acción cancelada por el usuario")
              End If
            End If
          Else
            Me.txthasta.Value = Me.txtcodigo.Value
          End If

          For t As Integer = CInt(Me.txtcodigo.Value) To CInt(Me.txthasta.Value)
            SeccionHorno = New SeccionHorno(SeccionHorno.OperadorDatos, SeccionHorno.Horno, t.ToString(), True)
            If Not SeccionHorno.Guardar() Then
              Throw New Exception(SeccionHorno.OperadorDatos.MsgError)
            End If
          Next
        Case IMantenimiento.Accion.Eliminacion
          If Not SeccionHorno.Eliminar() Then
            Throw New Exception(SeccionHorno.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
