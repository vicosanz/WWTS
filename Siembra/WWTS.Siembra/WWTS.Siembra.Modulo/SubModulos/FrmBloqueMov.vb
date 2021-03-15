
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmBloqueMov
  Implements IMantenimiento

  Private mBloqueMov As BloqueMov
  Public Property BloqueMov() As BloqueMov
    Get
      Return mBloqueMov
    End Get
    Set(ByVal Value As BloqueMov)
      mBloqueMov = Value
      If Not Value Is Nothing Then
        Me.CtlCuarto1.op = mBloqueMov.OperadorDatos
        Me.CtlCuarto2.op = mBloqueMov.OperadorDatos
        Me.CtlCuarto1.llenar_datos()
        Me.CtlCuarto2.llenar_datos()

        Me.cbotipomov.DisplayMember = "Descripcion"
        Me.cbotipomov.ValueMember = "Numero"
        Me.cbotipomov.DataSource = Enumerados.TipoMovBloqueList
      End If
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
    If Not BloqueMov Is Nothing Then
      Me.cbotipomov.SelectedValue = CInt(mBloqueMov.Blm_tipo)
      Me.dtfecmov.Value = mBloqueMov.Blm_fecha
      Me.txtnumcajas.Text = mBloqueMov.Blm_numcajas.ToString()
      Me.txtcantlibras.Text = mBloqueMov.Blm_libras.ToString()
      Me.CtlCuarto1.Cuarto = mBloqueMov.Cuarto
      Me.CtlCuarto2.Cuarto = mBloqueMov.CuartoDestino
    End If

    Me.cbotipomov.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtfecmov.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtnumcajas.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtcantlibras.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlCuarto1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlCuarto2.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          mBloqueMov.Blm_tipo = CType(Me.cbotipomov.SelectedValue, Enumerados.TipoMovBloque)
          mBloqueMov.Blm_fecha = Me.dtfecmov.Value
          mBloqueMov.Blm_numcajas = CType(Me.txtnumcajas.Text, Integer)
          mBloqueMov.Blm_libras = Me.txtcantlibras.Text
          mBloqueMov.Cuarto = Me.CtlCuarto1.Cuarto
          mBloqueMov.CuartoDestino = Me.CtlCuarto2.Cuarto
          If Not BloqueMov.Guardar() Then
            Throw New Exception(BloqueMov.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not BloqueMov.Eliminar() Then
            Throw New Exception(BloqueMov.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub cbotipomov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipomov.SelectedIndexChanged
    pnldestino.Visible = CType(Me.cbotipomov.SelectedValue, Enumerados.TipoMovBloque) = Enumerados.TipoMovBloque.Transferencia
  End Sub
End Class
