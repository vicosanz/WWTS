
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo

Public Class FrmCorte
  Implements IMantenimiento

  Private mCorte As Corte
  Public Property Corte() As Corte
    Get
      Return mCorte
    End Get
    Set(ByVal Value As Corte)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Corte")
      End If
      mCorte = Value
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
    If Not Corte Is Nothing Then
      Me.txtcodigo.Text = Corte.Cor_codigo
      Me.txtnombre.Text = Corte.Cor_nombre
      Me.txtcolor.Text = Corte.Cor_color
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtcolor.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Corte.Cor_codigo = Me.txtcodigo.Text
          Corte.Cor_nombre = Me.txtnombre.Text
          Corte.Cor_color = Me.txtcolor.Text
          If Not Corte.Guardar() Then
            Throw New Exception(Corte.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Corte.Eliminar() Then
            Throw New Exception(Corte.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
