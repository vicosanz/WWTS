Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoTestxArea
  Implements IMantenimiento

  Private mTestSeleccion As TestxArea
  Public Property TestSeleccion() As TestxArea
    Get
      Return mTestSeleccion
    End Get
    Set(value As TestxArea)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un TestxArea")
      End If
      mTestSeleccion = Value
      Me.ComboBoxArea.OperadorDatos = Value.OperadorDatos
      Me.ComboBoxArea.Parametro = Enumerados.EnumParametros.Area
      Me.ComboBoxArea.Llenar_Datos()

      Me.ComboBoxTest.OperadorDatos = Value.OperadorDatos
      Me.ComboBoxTest.Parametro = Enumerados.EnumParametros.SeleccionTest
      Me.ComboBoxTest.Llenar_Datos()
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If TestSeleccion IsNot Nothing Then
      Me.ComboBoxArea.ParametroDet = TestSeleccion.PardetArea
      Me.ComboBoxTest.ParametroDet = TestSeleccion.PardetSeleccionTest
    End If

    ComboBoxArea.Enabled = TestSeleccion.EsNuevo
    ComboBoxTest.Enabled = TestSeleccion.EsNuevo
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = TestSeleccion.EsNuevo
          TestSeleccion.PardetArea = Me.ComboBoxArea.ParametroDet
          TestSeleccion.PardetSeleccionTest = Me.ComboBoxTest.ParametroDet
          If Not TestSeleccion.Guardar() Then
            Throw New Exception(TestSeleccion.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not TestSeleccion.Eliminar() Then
            Throw New Exception(TestSeleccion.OperadorDatos.MsgError)
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