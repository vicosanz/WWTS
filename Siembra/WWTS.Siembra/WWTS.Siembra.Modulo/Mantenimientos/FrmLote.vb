
Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports WWTS.General.Controles

Public Class FrmLote
  Implements IMantenimiento

  Private mLote As LoteTerreno
  Public Property Lote() As LoteTerreno
    Get
      Return mLote
    End Get
    Set(ByVal Value As LoteTerreno)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Lote")
      End If
      mLote = Value
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
    If Not Lote Is Nothing Then
      Me.txtcodigo.Text = Lote.Lot_codigo.ToString()
      Me.txtareat.Text = Lote.Lot_areaT.ToString()
      Me.txtareau.Text = Lote.Lot_areaU.ToString()
      Me.lblmensaje.Text = "Lote del terreno " & Lote.Terreno.Trr_nombre
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtareat.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtareau.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Lote.Lot_codigo = Me.txtcodigo.Text
          Lote.Lot_areaT = Me.txtareat.Text
          Lote.Lot_areaU = Me.txtareau.Text
          If Not Lote.Guardar() Then
            Throw New Exception(Lote.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Lote.Eliminar() Then
            Throw New Exception(Lote.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub
End Class
