
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmPropietario
  Implements IMantenimiento

  Private mPropietario As Propietario
  Public Property Propietario() As Propietario
    Get
      Return mPropietario
    End Get
    Set(ByVal Value As Propietario)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Propietario")
      End If
      mPropietario = Value
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
    If Not Propietario Is Nothing Then
      Me.txtcodigo.Text = Propietario.Pro_codigo
      Me.txtnombre.Text = Propietario.Pro_nombre
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Propietario.Pro_codigo = Me.txtcodigo.Text
          Propietario.Pro_nombre = Me.txtnombre.Text
          If Not Propietario.Guardar() Then
            Throw New Exception(Propietario.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Propietario.Eliminar() Then
            Throw New Exception(Propietario.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
