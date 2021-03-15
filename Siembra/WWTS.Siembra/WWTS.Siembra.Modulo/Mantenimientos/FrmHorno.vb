
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmHorno
  Implements IMantenimiento

  Private mHorno As Horno
  Public Property Horno() As Horno
    Get
      Return mHorno
    End Get
    Set(ByVal Value As Horno)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Horno")
      End If
      mHorno = Value
      Me.CtlTerreno1.Op = Value.OperadorDatos
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
    If Not Horno Is Nothing Then
      Me.txtcodigo.Text = Horno.Hor_codigo
      Me.txtnombre.Text = Horno.Hor_descripcion
      Me.CtlTerreno1.Terreno = Horno.Terreno
      Me.txtnumaposentos.Text = Horno.Hor_numaposento.ToString()
      Me.txtcujes.Text = Horno.Hor_cujes.ToString()
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.CtlTerreno1.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtnumaposentos.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtcujes.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Horno.Hor_codigo = Me.txtcodigo.Text
          Horno.Hor_descripcion = Me.txtnombre.Text
          Horno.Terreno = Me.CtlTerreno1.Terreno
          Horno.Hor_numaposento = CInt(Me.txtnumaposentos.Text)
          Horno.Hor_cujes = CInt(Me.txtcujes.Text)
          If Not Horno.Guardar() Then
            Throw New Exception(Horno.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Horno.Eliminar() Then
            Throw New Exception(Horno.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
