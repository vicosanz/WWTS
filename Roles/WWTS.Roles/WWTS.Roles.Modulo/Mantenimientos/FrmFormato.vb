Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmFormato
  Implements IMantenimiento


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

  Private Sub FrmFormato_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlPatrono1.Op = Sistema.OperadorDatos
    Me.CtlPatrono1.llenar_datos(Sistema.Usuario)

    Me.CtlPeriodo1.Op = Sistema.OperadorDatos
    Me.CtlPeriodo1.PardetPeriodoPago = New WWTSParametroDet(Sistema.OperadorDatos, 730, 4)
    Me.CtlPeriodo1.llenar_datos()

    Me.ComboBoxTipo.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipo.Parametro = Enumerados.EnumParametros.TipoGastoPersonal
    Me.ComboBoxTipo.Llenar_Datos()
  End Sub
#End Region

  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get

    End Get
    Set(value As IMantenimiento.Accion)

    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma

  End Sub

  Private Sub btnEjecutar_Click(sender As System.Object, e As System.EventArgs) Handles btnEjecutar.Click
    ExcelReporte.ImpuestoRenta.Imprimir_Formato(CtlPatrono1.Patrono, CtlPeriodo1.PeriodoPago, ComboBoxTipo.ParametroDet)
  End Sub
End Class