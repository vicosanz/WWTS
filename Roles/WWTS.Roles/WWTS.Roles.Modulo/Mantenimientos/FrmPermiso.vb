Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmPermiso
  Implements IMantenimiento

  Private mPermiso As Permiso
  Public Property Permiso() As Permiso
    Get
      Return mPermiso
    End Get
    Set(ByVal Value As Permiso)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Permiso")
      End If
      mPermiso = Value

      Me.cbotipopermiso.OperadorDatos = Value.OperadorDatos
      Me.cbotipopermiso.Parametro = Enumerados.EnumParametros.TipoPermiso
      Me.cbotipopermiso.Llenar_Datos()

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
    If Not Permiso Is Nothing Then
      Me.cbotipopermiso.ParametroDet = Permiso.PardetTipoPermiso
      Me.dtfecdesde.Value = Permiso.Permis_FechaDesde
      Me.dtfechasta.Value = Permiso.Permis_FechaHasta
      Me.lblmensaje.Text = String.Format("Permiso para {0}", Permiso.Contrato.Empleado.NombreCompleto)
    End If
    Me.cbotipopermiso.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtfecdesde.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtfechasta.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Permiso.PardetTipoPermiso = Me.cbotipopermiso.ParametroDet
          Permiso.Permis_FechaDesde = Me.dtfecdesde.Value
          Permiso.Permis_FechaHasta = Me.dtfechasta.Value
          If Not Permiso.Guardar() Then
            Throw New Exception(Permiso.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Permiso.Eliminar() Then
            Throw New Exception(Permiso.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
#End Region
End Class
