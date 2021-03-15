Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports Infoware.Controles.General

Public Class FrmTest
  Implements IMantenimiento

  Private mSeleccionTest As SeleccionTest
  Public Property SeleccionTest() As SeleccionTest
    Get
      Return mSeleccionTest
    End Get
    Set(ByVal Value As SeleccionTest)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar una SeleccionTest")
      End If
      mSeleccionTest = Value
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
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If SeleccionTest IsNot Nothing Then
      Me.ComboBoxTest.ParametroDet = SeleccionTest.PardetSeleccionTest
      Me.TextBoxCalculator1.Value = SeleccionTest.Puntaje
    End If

    Me.ComboBoxTest.Enabled = SeleccionTest.EsNuevo
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = SeleccionTest.EsNuevo
          SeleccionTest.PardetSeleccionTest = Me.ComboBoxTest.ParametroDet
          SeleccionTest.SelTes_Puntaje = Me.TextBoxCalculator1.Value
          If SeleccionTest.SelTes_Puntaje > 100 Then
            MsgBox("El puntaje del test no  puede ser mayor a 100", MsgBoxStyle.Information, "Información")
            e.Cancel = True
            Exit Sub
          End If
          'If Not SeleccionTest.Guardar() Then
          '  Throw New Exception(SeleccionTest.OperadorDatos.MsgError)
          'End If
        Case IMantenimiento.Accion.Eliminacion
          'If Not SeleccionTest.Eliminar() Then
          '  Throw New Exception(SeleccionTest.OperadorDatos.MsgError)
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