
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmCuarto
  Implements IMantenimiento

  Private mCuarto As Cuarto
  Public Property Cuarto() As Cuarto
    Get
      Return mCuarto
    End Get
    Set(ByVal Value As Cuarto)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Cuarto")
      End If
      mCuarto = Value
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
    If Not Cuarto Is Nothing Then
      Me.txtcodigo.Text = Cuarto.Cto_codigo
      Me.txtdescripcion.Text = Cuarto.Cto_descripcion
      Me.txtarea.Text = Cuarto.Cto_area.ToString()
      Me.chkCaliente.Checked = Cuarto.Cto_escaliente
      Me.txttemperatura.Text = Cuarto.Cto_temperatura.ToString()
      Me.lblmensaje.Text = "Cuarto de la finca " & Cuarto.Terreno.Trr_nombre
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtarea.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkCaliente.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txttemperatura.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Cuarto.Cto_codigo = Me.txtcodigo.Text
          Cuarto.Cto_descripcion = Me.txtdescripcion.Text
          Cuarto.Cto_area = Me.txtarea.Text
          Cuarto.Cto_escaliente = Me.chkCaliente.Checked
          Cuarto.Cto_temperatura = Me.txttemperatura.Text
          If Not Cuarto.Guardar() Then
            Throw New Exception(Cuarto.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Cuarto.Eliminar() Then
            Throw New Exception(Cuarto.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
