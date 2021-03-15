
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmBodega
  Implements IMantenimiento

  Private mBodega As WWTS.Siembra.Reglas.BodegaTerreno
  Public Property Bodega() As WWTS.Siembra.Reglas.BodegaTerreno
    Get
      Return mBodega
    End Get
    Set(ByVal Value As WWTS.Siembra.Reglas.BodegaTerreno)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Bodega")
      End If
      mBodega = Value
      Me.CtlTerreno1.Op = mBodega.OperadorDatos
      Me.CtlTerreno1.llenar_datos()
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
    If Not Bodega Is Nothing Then
      Me.txtcodigo.Text = Bodega.Bod_codigo
      Me.txtnombre.Text = Bodega.Bod_nombre
      Me.txtubicacion.Text = Bodega.Bod_ubicacion
      Me.CtlTerreno1.Terreno = Bodega.Terreno
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtubicacion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlTerreno1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Bodega.Bod_codigo = Me.txtcodigo.Text
          Bodega.Bod_nombre = Me.txtnombre.Text
          Bodega.Bod_ubicacion = Me.txtubicacion.Text
          Bodega.Terreno = Me.CtlTerreno1.Terreno
          If Not Bodega.Guardar() Then
            Throw New Exception(Bodega.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Bodega.Eliminar() Then
            Throw New Exception(Bodega.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
