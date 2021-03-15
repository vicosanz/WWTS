
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmEmbarque
  Implements IMantenimiento

  Private mEmbarque As Embarque
  Public Property Embarque() As Embarque
    Get
      Return mEmbarque
    End Get
    Set(ByVal Value As Embarque)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Embarque")
      End If
      mEmbarque = Value
      Me.CtlDestino1.Op = Me.mEmbarque.OperadorDatos
      Me.CtlDestino1.llenar_datos()
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
    If Not Embarque Is Nothing Then
      Me.txtcodigo.Text = Embarque.Emb_codigo
      Me.dtfecha.Value = IIf(Embarque.Emb_fecha = Nothing, Now.Date, Embarque.Emb_fecha)
      Me.CtlDestino1.Destino = Embarque.Destino
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.dtfecha.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlDestino1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Embarque.Emb_codigo = Me.txtcodigo.Text
          Embarque.Emb_fecha = Me.dtfecha.Value
          Embarque.Destino = Me.CtlDestino1.Destino
          If Not Embarque.Guardar() Then
            Throw New Exception(Embarque.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Embarque.Eliminar() Then
            Throw New Exception(Embarque.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
