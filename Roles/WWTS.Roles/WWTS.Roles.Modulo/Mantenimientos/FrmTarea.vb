Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmTarea
  Implements IMantenimiento

  Private mTarea As Tarea
  Public Property Tarea() As Tarea
    Get
      Return mTarea
    End Get
    Set(ByVal Value As Tarea)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Tarea")
      End If
      mTarea = Value
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
    If Not Tarea Is Nothing Then
      Me.txtcodigo.Text = Tarea.Tarea_Codigo
      Me.txtdescripcion.Text = Tarea.Tarea_Descripcion
      Me.txt_meta.Text = Tarea.Tarea_Meta
      Me.chk_sobreproduccion.Checked = Tarea.Tarea_SobreProduccion
      Me.txt_porcsob.Text = Tarea.Tarea_PorcSobreProduccion
    End If
    Me.txtcodigo.Enabled = Not mDireccion = IMantenimiento.Accion.Modificacion
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txt_meta.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chk_sobreproduccion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txt_porcsob.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txt_maximo.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txt_minimo.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txt_predeterminado.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Tarea.Tarea_Codigo = Me.txtcodigo.Text
          Tarea.Tarea_Descripcion = Me.txtdescripcion.Text
          Tarea.Tarea_Meta = Me.txt_meta.Text
          Tarea.Tarea_SobreProduccion = Me.chk_sobreproduccion.Checked
          Tarea.Tarea_PorcSobreProduccion = Me.txt_porcsob.Text
          If Not Tarea.Guardar() Then
            Throw New Exception(Tarea.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Tarea.Eliminar() Then
            Throw New Exception(Tarea.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region
End Class
