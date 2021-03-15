Imports Infoware.Reglas.General
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmDestino
  Implements IMantenimiento

  Private mDestino As Destino
  Public Property Destino() As Destino
    Get
      Return mDestino
    End Get
    Set(ByVal Value As Destino)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Destino")
      End If
      mDestino = Value
      Me.CtlPais1.OperadorDatos = Me.mDestino.OperadorDatos
      Me.CtlPais1.Llenar_Datos()
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
    If Not Destino Is Nothing Then
      Me.txtcodigo.Text = Destino.Des_codigo
      Me.txtnombre.Text = Destino.Des_nombre
      Me.CtlPais1.ParametroDet = Destino.Pais
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlPais1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Destino.Des_codigo = Me.txtcodigo.Text
          Destino.Des_nombre = Me.txtnombre.Text
          Destino.Pais = Me.CtlPais1.ParametroDet
          If Not Destino.Guardar() Then
            Throw New Exception(Destino.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Destino.Eliminar() Then
            Throw New Exception(Destino.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
