
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmSemilla
  Implements IMantenimiento

  Private mSemilla As SemillaSiembra
  Public Property Semilla() As SemillaSiembra
    Get
      Return mSemilla
    End Get
    Set(ByVal Value As SemillaSiembra)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Semilla")
      End If
      mSemilla = Value
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
    If Not Semilla Is Nothing Then
      Me.txtcodigo.Text = Semilla.Sem_codigo
      Me.txtnombre.Text = Semilla.Sem_nombre
      Me.txthojas.Text = Semilla.Sem_hojas.ToString()
      Me.chkcandela.Checked = Semilla.Sem_esCandela
      Me.chknatural.Checked = Semilla.Sem_esNatural
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txthojas.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkcandela.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chknatural.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Semilla.Sem_codigo = Me.txtcodigo.Text
          Semilla.Sem_nombre = Me.txtnombre.Text
          Semilla.Sem_hojas = Me.txthojas.Text
          Semilla.Sem_esNatural = Me.chknatural.Checked
          Semilla.Sem_esCandela = Me.chkcandela.Checked
          If Not Semilla.Guardar() Then
            Throw New Exception(Semilla.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Semilla.Eliminar() Then
            Throw New Exception(Semilla.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
