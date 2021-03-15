
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmHacienda
  Implements IMantenimiento

  Private mHacienda As Hacienda
  Public Property Hacienda() As Hacienda
    Get
      Return mHacienda
    End Get
    Set(ByVal Value As Hacienda)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Hacienda")
      End If
      mHacienda = Value
      Me.CtlUbicacion1.Op = Me.mHacienda.OperadorDatos
      Me.CtlUbicacion1.llenar_datos()
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
    If Not Hacienda Is Nothing Then
      Me.txtcodigo.Text = Hacienda.Hac_codigo
      Me.txtdescripcion.Text = Hacienda.Hac_nombre
      Me.txtsufijo.Text = Hacienda.Hac_sufijo
      Me.CtlUbicacion1.Parroquia = Hacienda.Parroquia
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtsufijo.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlUbicacion1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Hacienda.Hac_codigo = Me.txtcodigo.Text
          Hacienda.Hac_nombre = Me.txtdescripcion.Text
          Hacienda.Hac_sufijo = Me.txtsufijo.Text
          Hacienda.Parroquia = Me.CtlUbicacion1.Parroquia
          If Not Hacienda.Guardar() Then
            Throw New Exception(Hacienda.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Hacienda.Eliminar() Then
            Throw New Exception(Hacienda.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
