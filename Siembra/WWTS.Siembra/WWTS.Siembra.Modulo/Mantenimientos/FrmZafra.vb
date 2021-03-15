
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmZafra
  Implements IMantenimiento

  Private mZafra As ZafraSiembra
  Public Property Zafra() As ZafraSiembra
    Get
      Return mZafra
    End Get
    Set(ByVal Value As ZafraSiembra)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Zafra")
      End If
      mZafra = Value
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
    If Not Zafra Is Nothing Then
      Me.txtcodigo.Text = Zafra.Zaf_codigo
      Me.txtdescripcion.Text = Zafra.Zaf_descripcion
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Zafra.Zaf_codigo = Me.txtcodigo.Text
          Zafra.Zaf_descripcion = Me.txtdescripcion.Text
          If Not Zafra.Guardar() Then
            Throw New Exception(Zafra.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Zafra.Eliminar() Then
            Throw New Exception(Zafra.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
