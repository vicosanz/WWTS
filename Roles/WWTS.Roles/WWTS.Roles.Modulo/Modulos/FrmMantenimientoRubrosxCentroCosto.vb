Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoRubrosxCentroCosto
  Implements IMantenimiento

  Private mRubrosxCentroCosto As RubrosxCentroCosto
  Public Property RubrosxCentroCosto() As RubrosxCentroCosto
    Get
      Return mRubrosxCentroCosto
    End Get
    Set(value As RubrosxCentroCosto)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un RubrosxCentroCosto")
      End If
      mRubrosxCentroCosto = Value
      Me.ComboBoxCentroCosto.OperadorDatos = Value.OperadorDatos
      Me.ComboBoxCentroCosto.Parametro = Enumerados.EnumParametros.GrupoContable
      Me.ComboBoxCentroCosto.Llenar_Datos()

      Me.ComboBoxRubro.OperadorDatos = Value.OperadorDatos
      Me.ComboBoxRubro.Parametro = Enumerados.EnumParametros.TipoRubro
      Me.ComboBoxRubro.Llenar_Datos()
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
    If RubrosxCentroCosto IsNot Nothing Then
      Me.ComboBoxCentroCosto.ParametroDet = RubrosxCentroCosto.PardetCentroCosto
      Me.ComboBoxRubro.ParametroDet = RubrosxCentroCosto.PardetRubro
      Me.txtCtaCtble.Text = RubrosxCentroCosto.RubCen_CtaCtble
    End If

    ComboBoxCentroCosto.Enabled = RubrosxCentroCosto.EsNuevo
    ComboBoxRubro.Enabled = RubrosxCentroCosto.EsNuevo
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = RubrosxCentroCosto.EsNuevo
          RubrosxCentroCosto.PardetCentroCosto = Me.ComboBoxCentroCosto.ParametroDet
          RubrosxCentroCosto.PardetRubro = Me.ComboBoxRubro.ParametroDet
          RubrosxCentroCosto.RubCen_CtaCtble = Me.txtCtaCtble.Text
          If Not RubrosxCentroCosto.Guardar() Then
            Throw New Exception(RubrosxCentroCosto.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not RubrosxCentroCosto.Eliminar() Then
            Throw New Exception(RubrosxCentroCosto.OperadorDatos.MsgError)
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