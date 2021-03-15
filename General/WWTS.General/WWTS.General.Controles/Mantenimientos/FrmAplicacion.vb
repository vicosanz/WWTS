Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports Infoware.Controles.General

Public Class FrmAplicacion
  Implements IMantenimiento

  Private mAplicacionEmpleado As AplicacionEmpleado
  Public Property AplicacionEmpleado() As AplicacionEmpleado
    Get
      Return mAplicacionEmpleado
    End Get
    Set(ByVal Value As AplicacionEmpleado)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar una AplicacionEmpleado")
      End If
      mAplicacionEmpleado = Value
      Me.cboarea.OperadorDatos = Value.OperadorDatos
      Me.cboarea.Parametro = Enumerados.EnumParametros.Area
      Me.cboarea.Llenar_Datos()
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

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma

  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = AplicacionEmpleado.EsNuevo
          AplicacionEmpleado.PardetArea = Me.cboarea.ParametroDet
          'If Not AplicacionEmpleado.Guardar() Then
          '  Throw New Exception(AplicacionEmpleado.OperadorDatos.MsgError)
          'End If
        Case IMantenimiento.Accion.Eliminacion
          'If Not AplicacionEmpleado.Eliminar() Then
          '  Throw New Exception(AplicacionEmpleado.OperadorDatos.MsgError)
          'End If
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

    InitSistema(_Sistema, _Restriccion)
    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region
End Class