Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmMantenimientoContrato

#Region "Parametros"
  Private mSeleccion As Seleccion = Nothing
  Public Property Seleccion() As Seleccion
    Get
      Return mSeleccion
    End Get
    Set(ByVal value As Seleccion)
      mSeleccion = value
    End Set
  End Property

  Private mSeleccionDet As SeleccionDet = Nothing
  Public Property SeleccionDet() As SeleccionDet
    Get
      Return mSeleccionDet
    End Get
    Set(ByVal value As SeleccionDet)
      mSeleccionDet = value
      llenar_datos()
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    Me.CtlContrato1.Empleado = New Empleado(Sistema.OperadorDatos, mSeleccionDet.Entida_Codigo)
    Me.CtlContrato1.NuevoContrato()

    Me.CtlContrato1.ContratoSeleccionado.PardetDepartamento = mSeleccion.PardetDepartamento
    Me.CtlContrato1.ContratoSeleccionado.PardetArea = mSeleccion.PardetArea
    Me.CtlContrato1.ContratoSeleccionado.Selecc_Codigo = mSeleccion.Selecc_Codigo

    Me.CtlContrato1.ModoenSeleccion = True
  End Sub
#End Region

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

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.PuedeGuardaryNuevo = False
    Me.PuedeGuardaryCerrar = False
    Me.PuedeMover = False
    Me.PuedeEliminar = False
    Me.ToolStrip1.Visible = False

    Me.CtlContrato1.Usuario = Sistema.Usuario
    Me.CtlContrato1.Op = Sistema.OperadorDatos
  End Sub
#End Region

End Class