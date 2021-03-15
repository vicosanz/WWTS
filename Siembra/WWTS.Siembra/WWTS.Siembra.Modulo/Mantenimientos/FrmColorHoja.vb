
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo

Public Class FrmColorHoja
  Implements IMantenimiento

  Private mColorHoja As ColorHoja
  Public Property ColorHoja() As ColorHoja
    Get
      Return mColorHoja
    End Get
    Set(ByVal Value As ColorHoja)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un ColorHoja")
      End If
      mColorHoja = Value
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
    If Not ColorHoja Is Nothing Then
      Me.txtcodigo.Text = ColorHoja.Col_codigo
      Me.txtnombre.Text = ColorHoja.Col_nombre
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          ColorHoja.Col_codigo = Me.txtcodigo.Text
          ColorHoja.Col_nombre = Me.txtnombre.Text
          If Not ColorHoja.Guardar() Then
            Throw New Exception(ColorHoja.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not ColorHoja.Eliminar() Then
            Throw New Exception(ColorHoja.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
