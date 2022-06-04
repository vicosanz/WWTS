Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Consola.Base
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FrmMantenimientoFichasMedicas
  Implements IOpcion

#Region "Parametros"
  Public Property Empleados() As BindingSource
    Get
      Return ListBindingSource
    End Get
    Set(value As BindingSource)
      ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mEmpleado As Empleado = Nothing
  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(value As Empleado)
      mEmpleado = value
      'If MyBase.ListBindingSource.DataSource Is Nothing Then
      Dim _Empleados As New EmpleadoList
      _Empleados.Add(mEmpleado)
      'MyBase.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Empleado)
      ListBindingSource.DataSource = _Empleados
      'Me.CtlContrato1.Enabled = True
      'End If
      'llenar_datos()
    End Set
  End Property

  Public ReadOnly Property ToolStrip As ToolStrip Implements IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property MenuStrip As MenuStrip Implements IOpcion.MenuStrip
    Get
      Return MenuStrip2
    End Get
  End Property

  Public ReadOnly Property Control As Control Implements IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    mEmpleado = Empleados.Current
    Me.CtlFichasMedicasPreocupacionales1.Contrato = Nothing
    Me.CtlFichasMedicasPreocupacionales1.Empleado = mEmpleado
    Me.CtlFichasMedicasPreocupacionales1.Enabled = True
    Me.CtlContrato1.Empleado = mEmpleado
    'Me.CtlContrato1.HeaderStrip1.Enabled = True
  End Sub

  Private Sub CtlContrato1_DespuesContratoSeleccionado(sender As Object, e As EventArgs) Handles CtlContrato1.DespuesContratoSeleccionado
    Me.CtlFichasMedicasPreocupacionales1.Contrato = Me.CtlContrato1.ContratoSeleccionado()
  End Sub

  Sub mapear_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoEmpleado_FormClosing(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'Cancelar_Nuevo()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

  Private Sub CtlBuscaEmpleados1_CambioEmpleado(sender As Object, ByVal e As EventArgs) Handles CtlBuscaEmpleados1.CambioEmpleado
    Recargar_Empleado()
  End Sub

  Sub Recargar_Empleado()
    Me.Empleado = Me.CtlBuscaEmpleados1.Empleado
  End Sub

#Region "New"
  Public Sub New(_Sistema As Sistema, ByVal _Restriccion As Restriccion)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(_Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub

  Private Sub FrmMantenimientoEmpleado_Inicializar(sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Fichas Médicas"
    Me.CtlBuscaEmpleados1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados1.Op = Sistema.OperadorDatos
    Me.CtlContrato1.Usuario = Sistema.Usuario
    Me.CtlContrato1.Op = Sistema.OperadorDatos
  End Sub
#End Region

  Private Sub ListadoEmpleadoDiscapacidadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoEmpleadoDiscapacidadToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ReportesRoles) With {
      .Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Empleados_con_discapacidad"),
      .Valores = New Object() {Sistema.Usuario.Usuari_Codigo}
    }
    f.ShowDialog()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Actualizar(sender As Object, e As EventArgs) Handles ListBindingSource.CurrentChanged
    llenar_datos()
  End Sub

  Private Sub CtlContrato1_Load(sender As Object, e As EventArgs)

  End Sub

  Private Sub CtlFichasMedicasPreocupacionales1_DespuesAjuntaraContrato(sender As Object, e As EventArgs) Handles CtlFichasMedicasPreocupacionales1.DespuesAjuntaraContrato
    CtlContrato1.llenar_datos()
  End Sub
End Class
