Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports WWTS.Reporteador.Reglas

Public Class FrmMenuCuentas
  Dim _Toolstrip As ToolStrip = Nothing
  Dim _MenuStrip As MenuStrip = Nothing
  Dim _Control As Control = Nothing

  Private mOpcionAnterior As Integer = 0
  Private mEstaQuitandoReportes As Boolean = False

  Private mReporteActual As Reporte = Nothing

  Public WriteOnly Property ReporteActual() As Reporte
    Set(ByVal value As Reporte)
      Dim cambio As Boolean = False
      If mReporteActual IsNot Nothing Then
        If Not mReporteActual.NombreReporte = value.NombreReporte Then
          cambio = True
        End If
      Else
        cambio = True
      End If
      mReporteActual = value
      If cambio Then
        Me.Recargar()
      End If
    End Set
  End Property

  Public Overrides ReadOnly Property ControlCuerpo() As System.Windows.Forms.Control
    Get
      If AplicacionDatos Is Nothing Then
        Return Nothing
        Exit Property
      End If

      onnoFullScreen()

      _Toolstrip = Nothing
      _MenuStrip = Nothing
      _Control = Nothing

      If Not OpcionActual = Enumerados.EnumOpciones.ReportesAfiliados Then
        mReporteActual = Nothing
        mEstaQuitandoReportes = True
        mOpcionAnterior = OpcionActual
        tvreportes.Nodes.Clear()
        mEstaQuitandoReportes = False
      End If

      Dim mOpcion As Enumerados.EnumOpciones = CType(OpcionActual, Enumerados.EnumOpciones)

      Dim f As IOpcion = RetornarOpcion(mOpcion)
      If f IsNot Nothing Then
        _Toolstrip = f.ToolStrip
        _MenuStrip = f.MenuStrip
        _Control = f.Control
      End If

      If mOpcion = Enumerados.EnumOpciones.RegistroIngreso Then
        onFullScreen()
      End If

      onCambioToolStripMenu()
      onCambioMenuStrip()
      Return _Control
    End Get
  End Property


  Private Sub FrmMenuSeguridad_AbrirNuevaVentana(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Me.AbrirNuevaVentana
    Dim mOpcion As Enumerados.EnumOpciones = CType(e.Node.Tag, Enumerados.EnumOpciones)
    Dim f As FrmFormaBase = RetornarOpcion(mOpcion)
    If f IsNot Nothing Then
      f.Show()
    End If
  End Sub

  Public Function RetornarOpcion(ByVal mOpcion As Enumerados.EnumOpciones) As FrmFormaBase
    Select Case mOpcion
      Case Enumerados.EnumOpciones.ListadoClientes
        Dim f As New General.Controles.FrmListaClientes(AplicacionDatos, mOpcion, False)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.ListadoProveedores
        Dim f As New General.Controles.FrmListaProveedores(AplicacionDatos, mOpcion, False)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.EstadoCuenta
        Dim f As New FrmEstadoCuenta(AplicacionDatos, mOpcion, BarraRegistroContable1.Empresa)
        mMostrarBarraModulo = True
        Me.BarraRegistroContable1.EmpresaVisible = True
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.AnalisisCartera
        Dim f As New FrmAnalisisCartera(AplicacionDatos, mOpcion, BarraRegistroContable1.Empresa)
        mMostrarBarraModulo = True
        Me.BarraRegistroContable1.EmpresaVisible = True
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
        'Case Enumerados.EnumOpciones.ListadoBodegas
        '  Dim f As New FrmListaBodegas(AplicacionDatos, mOpcion, False, Me.BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.ListadoTiposPrecios
        '  Dim f As New General.Controles.FrmListaParametroDets(AplicacionDatos, mOpcion, False)
        '  f.Parame_Codigo = Enumerados.EnumParametros.TipoPrecio
        '  mMostrarBarraModulo = False
        '  Return f
        'Case Enumerados.EnumOpciones.ListadoFormasPago
        '  Dim f As New General.Controles.FrmListaParametroDets(AplicacionDatos, mOpcion, False)
        '  f.Parame_Codigo = Enumerados.EnumParametros.TipoFormaPago
        '  mMostrarBarraModulo = False
        '  Return f
        'Case Enumerados.EnumOpciones.Secuenciales
        '  Dim f As New FrmListaTipoMovimientoInventarios(AplicacionDatos, mOpcion, False, Me.BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.SecuencialCompraVenta
        '  Dim f As New FrmListaTipoMovimientoCompraVentas(AplicacionDatos, mOpcion, False, Me.BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.MovimientoInventario
        '  Dim f As New FrmListaMovimientosInventarios(AplicacionDatos, mOpcion, False, Me.BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.UnidadMedidaConversion
        '  Dim f As New FrmListaUnidadMedidaConversiones(AplicacionDatos, mOpcion, False)
        '  mMostrarBarraModulo = False
        '  Return f
        'Case Enumerados.EnumOpciones.TPV
        'Dim _restrictpv As Restriccion
        '_restrictpv = AplicacionDatos.Restricciones.Buscar(Enumerados.EnumOpciones.TPV)
        'If _restrictpv.Usuario.Entida_Empleado = 0 Then
        '  MsgBox("No se puede relacionar el usuario actual con un vendedor", MsgBoxStyle.Critical, "Error")
        '  Return Nothing
        'End If
        'If Cajero Is Nothing Then
        '  MsgBox("Para comenzar a trabajar necesitará iniciar sesión de caja", MsgBoxStyle.Information, "Información")
        '  Return Nothing
        'End If
        'If Not mSesionCajero = _restrictpv.Usuario.Entida_Empleado Then
        '  MsgBox(String.Format("Debe cerrar la sesión de caja de {0} para continuar", Cajero.NombreCompleto), MsgBoxStyle.Information, "Información")
        '  Return Nothing
        'End If
        'onFullScreen()
        'Dim f As New FrmPuntodeVenta(AplicacionDatos, mOpcion, Me.BarraRegistroContable1.Sucursal)
        ''f.Empleado = Cajero
        'Return f
        'Case Enumerados.EnumOpciones.AsientosContablesInventario
        '  Dim f As New FrmAsientosAutomaticos(AplicacionDatos, mOpcion, Me.BarraRegistroContable1.Empresa)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = False
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.Premios
        '  If BarraRegistroContable1.Sucursal Is Nothing Then
        '    MsgBox("No se ha especificado una sucursal", MsgBoxStyle.Critical, "Error")
        '    Return Nothing
        '  End If
        '  Dim f As New FrmListaItems(AplicacionDatos, mOpcion, False, BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.RegistroIngreso
        '  Dim f As New FrmRegistroIngreso(AplicacionDatos, mOpcion) 'FrmListaPuntosLog(AplicacionDatos, mOpcion, False, BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = False
        '  Me.BarraRegistroContable1.EmpresaVisible = False
        '  Me.BarraRegistroContable1.SucursalVisible = False
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.RegistroPuntos
        '  If BarraRegistroContable1.Sucursal Is Nothing Then
        '    MsgBox("No se ha especificado una sucursal", MsgBoxStyle.Critical, "Error")
        '    Return Nothing
        '  End If
        '  Dim f As New FrmListaPuntosLog(AplicacionDatos, mOpcion, False, BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
        'Case Enumerados.EnumOpciones.MovimientosInventario
        '  If BarraRegistroContable1.Sucursal Is Nothing Then
        '    MsgBox("No se ha especificado una sucursal", MsgBoxStyle.Critical, "Error")
        '    Return Nothing
        '  End If
        '  Dim f As New Inventario.Modulo.FrmListaMovimientosInventarios(AplicacionDatos, mOpcion, False, BarraRegistroContable1.Sucursal)
        '  mMostrarBarraModulo = True
        '  Me.BarraRegistroContable1.EmpresaVisible = True
        '  Me.BarraRegistroContable1.SucursalVisible = True
        '  Me.BarraRegistroContable1.RegContableVisible = False
        '  Return f
      Case Enumerados.EnumOpciones.ReportesCuentas
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False

        If OpcionActual = mOpcionAnterior Then
          Dim f As New WWTS.Reporteador.Modulo.FrmLista(AplicacionDatos, Enumerados.EnumOpciones.Reporteador)
          f.Reporte = mReporteActual
          '_Toolstrip = f.ToolStrip1
          '_MenuStrip = f.MenuStrip1
          '_Control = f.pnlcuerpo
          Return f
        Else
          Dim _reportes As ReporteList = ReporteList.ObtenerLista(AplicacionDatos.OperadorDatos, "REPC")

          Me.tvreportes.Nodes.Clear()
          Me.ImageList2.Images.Clear()
          Me.ImageList2.Images.Add("1", My.Resources.report)
          For Each _reporte As Reporte In _reportes
            Dim nodo As TreeNode
            nodo = New TreeNode
            nodo.Text = _reporte.NombreReporte
            nodo.Tag = _reporte
            nodo.SelectedImageIndex = 0
            nodo.ImageIndex = 0
            Me.tvreportes.Nodes.Add(nodo)
          Next
          mOpcionAnterior = OpcionActual
          'Me.pnltareas.Height = (Me.tvtareas.Nodes.Count + 1) * 24
          If Me.tvreportes.Nodes.Count > 0 Then
            Me.tvreportes.SelectedNode = Me.tvreportes.Nodes(0)
          End If
          Return Nothing
        End If
      Case Else
        Return Nothing
    End Select
  End Function

  Private mMostrarBarraModulo As Boolean = True
  Public Overrides ReadOnly Property ToolStripModulo() As System.Windows.Forms.ToolStrip
    Get
      If mMostrarBarraModulo Then
        Me.BarraRegistroContable1.Llenar_datos()
        Return Me.BarraRegistroContable1
      Else
        Return Nothing
      End If
    End Get
  End Property

  Public Overrides ReadOnly Property ToolStripMenu() As System.Windows.Forms.ToolStrip
    Get
      Return _Toolstrip
    End Get
  End Property

  Public Overrides ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip
    Get
      Return _MenuStrip
    End Get
  End Property

  Public Overrides Sub Aplicar_Restricciones()
    Me.lblmodulo.Text = "Cuentas"
    Me.BarraRegistroContable1.AplicacionDatos = AplicacionDatos

    tvopciones1.Nodes.Clear()
    'tvopciones2.Nodes.Clear()
    ImageList1.Images.Clear()
    ImageList2.Images.Clear()

    Dim contimg As Integer = 0
    Dim contimg2 As Integer = 0
    For Each _restriccion As Restriccion In AplicacionDatos.Restricciones
      If _restriccion.Pardet_Opciones >= 100 And _restriccion.Pardet_Opciones < 399 And _restriccion.Restri_Lectura Then
        Dim nodo As TreeNode
        Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
          Case Enumerados.EnumOpciones.ListadoClientes
            Me.ImageList1.Images.Add("clientes", My.Resources.Cliente)

            nodo = New TreeNode
            nodo.Text = "Listado de clientes"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.ListadoProveedores
            Me.ImageList1.Images.Add("proveedores", My.Resources.Proveedor)

            nodo = New TreeNode
            nodo.Text = "Listado de proveedores"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.EstadoCuenta
            Me.ImageList1.Images.Add("EstadoCuenta", My.Resources.report)

            nodo = New TreeNode
            nodo.Text = "Estado Cuenta"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.AnalisisCartera
            Me.ImageList1.Images.Add("AnalisisCartera", My.Resources.report)

            nodo = New TreeNode
            nodo.Text = "Analisis de Cartera"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.ReportesCuentas
            Me.ImageList1.Images.Add("ReportesCuentas", My.Resources.report)

            nodo = New TreeNode
            nodo.Text = "Reportes"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
        End Select
      End If
      'If CInt(_restriccion.Pardet_Opciones) >= 150 And CInt(_restriccion.Pardet_Opciones) < 200 And _restriccion.Res_lectura Then
      '  Dim nodo As TreeNode
      '  Select Case _restriccion.Pardet_Opciones
      '    Case Enumerados.EnumOpciones.ListadoClientes
      '      Me.ImageList2.Images.Add("listadoclientes", My.Resources.Empresa)

      '      nodo = New TreeNode
      '      nodo.Text = "Nuevo cliente"
      '      nodo.Tag = _restriccion.Pardet_Opciones
      '      nodo.SelectedImageIndex = contimg2
      '      nodo.ImageIndex = contimg2
      '      contimg2 += 1
      '      Me.tvopciones.Nodes.Add(nodo)
      '  End Select
      'End If
    Next

    Me.TableLayoutPanel1.RowStyles(0).SizeType = SizeType.Absolute
    Me.TableLayoutPanel1.RowStyles(0).Height = (Me.tvopciones1.Nodes.Count) * 16 + 30

    If Me.tvopciones1.Nodes.Count > 0 Then
      Me.tvopciones1.SelectedNode = Me.tvopciones1.Nodes(0)
    End If
    MyBase.Aplicar_Restricciones()
  End Sub

  Public Sub New(ByVal _AplicacionDatos As AplicacionDatos)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    AplicacionDatos = _AplicacionDatos
    'Aplicar_Restricciones()
  End Sub

  Private Sub FrmMenuCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub tvreportes_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvreportes.AfterSelect
    ReporteActual = e.Node.Tag
  End Sub

  Private Sub BarraRegistroContable1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraRegistroContable1.CambioDatos
    Me.Recargar()
  End Sub

  Private Sub BarraRegistroContable1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles BarraRegistroContable1.ItemClicked

  End Sub
End Class
