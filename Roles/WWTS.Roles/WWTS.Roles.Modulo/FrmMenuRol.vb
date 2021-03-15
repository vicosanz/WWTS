Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Controles.Base
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports Infoware.Reporteador

Public Class FrmMenuRol
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
      If Sistema Is Nothing Then
        Return Nothing
        Exit Property
      End If

      onnoFullScreen()

      _Toolstrip = Nothing
      _MenuStrip = Nothing
      _Control = Nothing

      If Not OpcionActual = Enumerados.EnumOpciones.ReportesRoles Then
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

      onCambioToolStripMenu()
      onCambioMenuStrip()
      Return _Control
    End Get
  End Property

  Private Sub FrmMenuEmpresa_AbrirNuevaVentana(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Me.AbrirNuevaVentana
    Dim mOpcion As Enumerados.EnumOpciones = CType(e.Node.Tag, Enumerados.EnumOpciones)
    Dim f As FrmFormaBase = RetornarOpcion(mOpcion, True)
    If f IsNot Nothing Then
      f.Show()
    End If
  End Sub

  Public Function RetornarOpcion(ByVal _Opcion As Enumerados.EnumOpciones, Optional ByVal _enNuevaVentana As Boolean = False) As FrmFormaBase
    Me.tvreportes.TabStop = False
    Select Case _Opcion
      Case Enumerados.EnumOpciones.InicioRoles
        Dim f As New FrmInicio(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
        '_Control = f.Pnlcuerpo
      Case Enumerados.EnumOpciones.Personal
        Dim f As New FrmMantenimientoEmpleado(Sistema, _Opcion)
        f.Sucursal = Me.BarraRegistroContable1.Sucursal
        mMostrarBarraModulo = True
        Me.BarraRegistroContable1.EmpresaVisible = True
        Me.BarraRegistroContable1.SucursalVisible = True
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.Prestamos_Anticipos
        Dim f As New FrmPrestamos(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.RegistrarAsistencias
        Dim f As New FrmAsistencias(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.BeneficiosSociales
        Dim f As New FrmBeneficios(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.Pagos
        Dim f As New FrmPagos(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.IESS
        Dim f As New FrmIess(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.ConfiguracionRoles
        Dim f As New FrmConfiguracion(Sistema, _Opcion)
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.ReportesRoles
        Me.tvreportes.TabStop = True
        mMostrarBarraModulo = False
        Me.BarraRegistroContable1.EmpresaVisible = False
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        If OpcionActual = mOpcionAnterior Then
          Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Reporteador)
          f.Reporte = mReporteActual
          Return f
        Else
          Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(Sistema.OperadorDatos, "REPR")

          Me.tvreportes.Nodes.Clear()
          Me.ImageList2.Images.Clear()
          Me.ImageList2.Images.Add("1", My.Resources.reporte)
          For Each _reporte As Infoware.Reporteador.Reporte In _reportes
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

  Public Overrides ReadOnly Property MenuStripModulo() As System.Windows.Forms.MenuStrip
    Get
      Return MyBase.MenuStripModulo
    End Get
  End Property

  Public Overrides Sub Aplicar_Restricciones()
    'Me.lblmodulo.Text = "Roles"
    Me.BarraRegistroContable1.Sistema = Sistema

    Me.tvopciones1.Nodes.Clear()
    'Me.tvreportes.Nodes.Clear()
    Me.ImageList1.Images.Clear()
    Me.ImageList2.Images.Clear()

    Dim contimg As Integer = 0
    For Each _restriccion As Restriccion In Sistema.Restricciones
      If _restriccion.Restri_Lectura Then 'CInt(_restriccion.Pardet_Opciones) >= 700 And CInt(_restriccion.Pardet_Opciones) < 750 And 
        Dim nodo As TreeNode
        Select Case _restriccion.Pardet_Opciones
          Case Enumerados.EnumOpciones.InicioRoles
            Me.ImageList1.Images.Add("InicioRoles", My.Resources.personal)

            nodo = New TreeNode
            nodo.Text = "Inicio"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.Personal
            Me.ImageList1.Images.Add("Personal", My.Resources.personal)

            nodo = New TreeNode
            nodo.Text = "Listado de Personal"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.Prestamos_Anticipos
            Me.ImageList1.Images.Add("Prestamos_Anticipos", My.Resources.prestamos)

            nodo = New TreeNode
            nodo.Text = "Préstamos/Anticipos"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.RegistrarAsistencias
            Me.ImageList1.Images.Add("RegistrarAsistencias", My.Resources.asistencia)

            nodo = New TreeNode
            nodo.Text = "Registrar asistencias"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.BeneficiosSociales
            Me.ImageList1.Images.Add("BeneficiosSociales", My.Resources.beneficios)

            nodo = New TreeNode
            nodo.Text = "Beneficios Sociales"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.Pagos
            Me.ImageList1.Images.Add("Pagos", My.Resources.pagos)

            nodo = New TreeNode
            nodo.Text = "Pagos"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.IESS
            Me.ImageList1.Images.Add("IESS", My.Resources.IESS)

            nodo = New TreeNode
            nodo.Text = "IESS"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.ConfiguracionRoles
            Me.ImageList1.Images.Add("ConfiguracionRoles", My.Resources.configuracion)

            nodo = New TreeNode
            nodo.Text = "Configuración"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.ReportesRoles
            Me.ImageList1.Images.Add("ReportesRoles", My.Resources.reporte)

            nodo = New TreeNode
            nodo.Text = "Reportes"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
        End Select
      End If
      If CInt(_restriccion.Pardet_Opciones) >= 750 And CInt(_restriccion.Pardet_Opciones) < 800 And _restriccion.Restri_Lectura Then
        'Dim nodo As TreeNode
        'Select Case _restriccion.Pardet_Opciones
        '  Case Enumerados.EnumOpciones.ListadoClientes
        '    Me.ImageList2.Images.Add("listadoclientes", My.Resources.Empresa)

        '    nodo = New TreeNode
        '    nodo.Text = "Nuevo cliente"
        '    nodo.Tag = _restriccion.Pardet_Opciones
        '    nodo.SelectedImageIndex = contimg2
        '    nodo.ImageIndex = contimg2
        '    contimg2 += 1
        '    Me.tvopciones.Nodes.Add(nodo)
        'End Select
      End If
    Next
    Me.TableLayoutPanel1.RowStyles(0).SizeType = SizeType.Absolute
    Me.TableLayoutPanel1.RowStyles(0).Height = (Me.tvopciones1.Nodes.Count) * 16 + 30

    'Me.pnlopciones.Height = (Me.tvopciones.Nodes.Count + 1) * 2

    If Me.tvopciones1.Nodes.Count > 0 Then
      Me.tvopciones1.SelectedNode = Me.tvopciones1.Nodes(0)
    End If
  End Sub


  Public Sub New(ByVal _Sistema As Sistema)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Sistema = _Sistema
    'Aplicar_Restricciones()
  End Sub

  Private Sub BarraRegistroContable1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraRegistroContable1.CambioDatos
    Me.Recargar()
  End Sub

  Private Sub tvreportes_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvreportes.AfterSelect
    ReporteActual = e.Node.Tag
  End Sub
End Class