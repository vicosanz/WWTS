Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Consola.Base
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class FrmMantenimientoEmpleado
  Implements IOpcion

#Region "Parametros"
  Public Property Empleados() As BindingSource
    Get
      Return ListBindingSource
    End Get
    Set(value As BindingSource)
      ListBindingSource = value
    End Set
  End Property

  Public ReadOnly Property Empleado() As Empleado
    Get
      If Empleados Is Nothing Then
        Return Nothing
      End If
      If TypeOf Empleados.Current Is Empleado Then
        Return Empleados.Current
      End If
      If TypeOf Empleados.Current Is Contrato Then
        Return CType(Empleados.Current, Contrato).Empleado
      End If
      Return Nothing
    End Get
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    Me.CtlEmpleado1.Empleado = Empleado
    Me.CtlContrato1.Empleado = Empleado
    'Me.CtlContrato1.HeaderStrip1.Enabled = True
  End Sub

  Sub mapear_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    Me.CtlEmpleado1.Mapear_datos()
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoEmpleado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = Empleado.EsNuevo
    If _esnuevo AndAlso Empleados.Current IsNot Nothing Then
      Empleados.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Empleados eventos"
  Private Sub FrmMantenimientoEmpleado_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Empleado As Empleado = New Empleado(Sistema.OperadorDatos, True)
    Me.ListBindingSource.Add(_Empleado)
    e.NewObject = _Empleado
  End Sub

  Private Sub FrmMantenimientoEmpleado_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoEmpleado_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      mapear_datos()
      Dim _esnuevo As Boolean = Empleado.EsNuevo
      If Empleado.Guardar() Then
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), Empleado.NombreCompleto)

        If _esnuevo Then
          Empleado.Recargar()
          Me.CtlBuscaEmpleados1.Empleado = Empleado
        End If
        Return True
      End If
    Catch ex As Exception
      MsgBox("No se puede guardar Empleado" & Environment.NewLine & ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoEmpleado_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If Empleados.Current IsNot Nothing AndAlso Empleado.Eliminar() Then
      Empleados.RemoveCurrent()
      Me.CtlBuscaEmpleados1.Empleado = Nothing
      Me.CtlEmpleado1.Empleado = Nothing
      Me.CtlContrato1.Empleado = Nothing
    Else
      'Empleados.CancelEdit()
      MsgBox("No se puede eliminar Empleado" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoEmpleado_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

  'Private Sub CtlBuscaEmpleados1_CambioEmpleado(ByVal sender As Object, ByVal e As EventArgs) Handles CtlBuscaEmpleados1.CambioEmpleado
  '  Recargar_Empleado()
  'End Sub

  'Sub Recargar_Empleado()
  '  Me.Empleado = Me.CtlBuscaEmpleados1.Empleado
  'End Sub

  Sub CargarHojaVida()
    If Me.CtlBuscaEmpleados1.Empleado Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpHojaVida
      Dim ds As New DSHojaVida
      ds = RetornarHojaVidaDS(Sistema.OperadorDatos, Me.CtlBuscaEmpleados1.Empleado)

      If ds Is Nothing OrElse ds.Tables("v_hojavida").Rows.Count <= 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        'Dim _fila As System.Data.DataRow
        '_fila = ds.v_hojavida.Rows(0)
        'Try
        '  _fila("foto") = Me.CtlBuscaEmpleados1.Empleado.Entidadnatural.Entidad.Entida_Imagen
        'Catch ex As Exception
        'End Try

        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        info.PrintOptions.PaperOrientation = PaperOrientation.Landscape

        Dim f As New FrmReporteBase(Sistema, Enumerados.EnumOpciones.Personal)
        f.Titulo = "Hoja de vida"
        f.ReporteDatos = info
        'f.CrystalReportViewer1.Zoom(1)
        'f.CrystalReportViewer1.DisplayToolbar = True
        'f.CrystalReportViewer1.ShowRefreshButton = False
        'f.CrystalReportViewer1.DisplayGroupTree = False
        f.ShowDialog()
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarHojaVidaDS(ByVal _OperadorDatos As OperadorDatos, ByVal _Empleado As Empleado) As DSHojaVida
    Dim bReturn As Boolean = True
    Dim dsResult As New DSHojaVida
    With _OperadorDatos
      .AgregarParametro("@accion", "hv")
      .AgregarParametro("@Entida_Codigo", _Empleado.Entida_Codigo)
      .Comando.CommandText = "proc_Empleado"
      Try
        Dim da As New SqlDataAdapter(.Comando)
        da.Fill(dsResult, "v_hojavida")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

  Private Sub btnhojadevida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhojadevida.Click
    CargarHojaVida()
  End Sub

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

  Private Sub FrmMantenimientoEmpleado_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.PuedeMover = False
    Me.PuedeGuardar = True
    Me.PuedeNuevo = True
    Me.PuedeEliminar = True
    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    ToolStripManager.Merge(Me.MenuStrip2, Me.MenuStrip1)
    Me.ToolStrip2.Visible = False
    Me.MenuStrip2.Visible = False

    MyBase.Tabla = "Empleados"
    Me.CtlBuscaEmpleados1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados1.Op = Sistema.OperadorDatos
    Me.CtlContrato1.Usuario = Sistema.Usuario
    Me.CtlContrato1.Op = Sistema.OperadorDatos
    Me.CtlEmpleado1.OperadorDatos = Sistema.OperadorDatos
  End Sub
#End Region

  Private Sub ListadoEmpleadoDiscapacidadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoEmpleadoDiscapacidadToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ReportesRoles)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Roles$Empleados_con_discapacidad")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo}
    f.ShowDialog()
  End Sub

  Private Sub CtlEmpleado1_Load(sender As System.Object, e As System.EventArgs) Handles CtlEmpleado1.Load

  End Sub

  Private Sub CtlBuscaEmpleados1_CambioFuenteDatos(sender As Object, e As EventArgs) Handles CtlBuscaEmpleados1.CambioFuenteDatos
    Empleados = CtlBuscaEmpleados1.ListBindingSource
  End Sub
End Class
