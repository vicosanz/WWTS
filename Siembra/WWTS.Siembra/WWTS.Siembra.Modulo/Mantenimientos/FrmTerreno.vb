
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmTerreno
  Implements IMantenimiento

  Private mTerreno As Terreno
  Public Property Terreno() As Terreno
    Get
      Return mTerreno
    End Get
    Set(ByVal Value As Terreno)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Terreno")
      End If
      mTerreno = Value
      Me.CtlPropietario1.Op = Me.mTerreno.OperadorDatos
      Me.CtlPropietario1.llenar_datos()
      Me.CtlHacienda1.Op = Me.mTerreno.OperadorDatos
      Me.CtlHacienda1.llenar_datos()
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
    If Not Terreno Is Nothing Then
      Me.txtcodigo.Text = Terreno.Trr_codigo
      Me.txtnombre.Text = Terreno.Trr_nombre
      Me.txtareat.Text = Terreno.Trr_AreaT.ToString()
      Me.txtareau.Text = Terreno.Trr_AreaU.ToString()
      Me.CtlHacienda1.Hacienda = Terreno.Hacienda
      Me.CtlPropietario1.Propietario = Terreno.Propietario
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtnombre.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtareat.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtareau.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlHacienda1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlPropietario1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Terreno.Trr_codigo = Me.txtcodigo.Text
          Terreno.Trr_nombre = Me.txtnombre.Text
          Terreno.Trr_AreaT = Me.txtareat.Text
          Terreno.Trr_AreaU = Me.txtareau.Text
          Terreno.Propietario = Me.CtlPropietario1.Propietario
          Terreno.Hacienda = Me.CtlHacienda1.Hacienda
          If Not Terreno.Guardar() Then
            Throw New Exception(Terreno.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Terreno.Eliminar() Then
            Throw New Exception(Terreno.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
