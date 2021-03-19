Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.General.Modulo

Public Class FrmCambiarArea
  Implements IMantenimiento

  Public Property Area() As WWTSParametroDet
    Get
      Return Me.ComboBoxParametroDet1.ParametroDet
    End Get
    Set(value As WWTSParametroDet)
      Me.ComboBoxParametroDet1.ParametroDet = Value
    End Set
  End Property

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)

  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub

  Private Sub FrmCambiarArea_AntesAceptar(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar

  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.ComboBoxParametroDet1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.Area
    Me.ComboBoxParametroDet1.Llenar_Datos()
  End Sub
#End Region

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma

  End Sub
End Class