Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.General.Controles
Imports WWTS.General.Modulo
Imports WeifenLuo.WinFormsUI.Docking

Public Class Loader

#Region "Reclutamiento"
  Function CargarModuloReclutamiento(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Reclutamiento) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Reclutamiento), CargarOpcionesReclutamiento(_Sistema, False), CargarOpcionesReclutamiento(_Sistema, True), CargarOpcionesReclutamientoRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesReclutamiento(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.AreasCargos
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarAreaCargos))
            Case Enumerados.EnumOpciones.Reclutamiento
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReclutamiento))
            Case Enumerados.EnumOpciones.Seleccion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarSeleccion))
            Case Enumerados.EnumOpciones.TestxArea
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarTestxArea))
            Case Enumerados.EnumOpciones.Personal
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarPersonal))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesReclutamientoRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    'For Each _restriccion As Restriccion In _Sistema.Restricciones
    '  If _restriccion.Restri_Lectura Then
    '    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
    '      Case Enumerados.EnumOpciones.ReportesRoles
    '        Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPR")

    '        For Each _reporte As Infoware.Reporteador.Reporte In _reportes
    '          _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
    '        Next

    '    End Select
    '  End If
    'Next
    Return _opciones
  End Function

  'Function CargarReporte(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
  '  Dim f As New Infoware.Reporteador.FrmLista(_Sistema, _Restriccion)
  '  f.Reporte = _Opcion.Tag
  '  Return f
  'End Function

  'Function CargarInicioRoles(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
  '  Dim f As New FrmInicio(_Sistema, _Restriccion)
  '  Return f
  'End Function

  Function CargarAreaCargos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmListaAreas(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarReclutamiento(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmReclutamiento(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarTestxArea(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmTestxArea(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarSeleccion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmSeleccion(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarPersonal(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmMantenimientoEmpleado(_Sistema, _Restriccion)
    Return f
  End Function
#End Region

#Region "Roles"
  Function CargarModuloRoles(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Roles) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Roles), CargarOpcionesRoles(_Sistema, False), CargarOpcionesRoles(_Sistema, True), CargarOpcionesRolesRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesRoles(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.Prestamos_Anticipos
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarAnticipos))
            Case Enumerados.EnumOpciones.RegistrarAsistencias
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarAsistencias))
              'Case Enumerados.EnumOpciones.Quincena
              '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarQuincena))
            Case Enumerados.EnumOpciones.Nomina
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarNomina))
            Case Enumerados.EnumOpciones.CuentaBancaria
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarCuentasBancarias))
            Case Enumerados.EnumOpciones.RubrosxBeneficio
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarRubrosxBeneficio))
            Case Enumerados.EnumOpciones.BeneficiosSociales
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarBeneficios))
            Case Enumerados.EnumOpciones.Liquidacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarLiquidacion))
            Case Enumerados.EnumOpciones.Pagos
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarPagos))
            Case Enumerados.EnumOpciones.RubrosxCentroCosto
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarRubrosxCentroCosto))
            Case Enumerados.EnumOpciones.ReporteIESS1
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteIESSEntradaSalida))
            Case Enumerados.EnumOpciones.ReporteIESS2
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteIESSVariacionExtras))
            Case Enumerados.EnumOpciones.ReporteIESS3
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteIESSDiasNoTrabajados))
            Case Enumerados.EnumOpciones.ImportacionMarcacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarImportarMarcacion))
            Case Enumerados.EnumOpciones.ImpuestoRenta
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarImpuestoRenta))
            Case Enumerados.EnumOpciones.IESS
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarIESS))
            Case Enumerados.EnumOpciones.UsuariosRoles
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarUsuariosRoles))
            Case Enumerados.EnumOpciones.ConfiguracionRoles
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarConfiguracion))
            Case Enumerados.EnumOpciones.CargarConciliacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarConciliacion))
            Case Enumerados.EnumOpciones.Conciliacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteConciliacion))
            Case Enumerados.EnumOpciones.FormatosRoles
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarRutas))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesRolesRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If _restriccion.Restri_Lectura Then
        Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
          Case Enumerados.EnumOpciones.ReportesRoles
            Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPR")

            For Each _reporte As Infoware.Reporteador.Reporte In _reportes
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
            Next

        End Select
      End If
    Next
    Return _opciones
  End Function

  Function CargarReporte(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, _Restriccion)
    f.Reporte = _Opcion.Tag
    Return f
  End Function

  'Function CargarInicioRoles(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
  '  Dim f As New FrmInicio(_Sistema, _Restriccion)
  '  Return f
  'End Function

  Function CargarAnticipos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmPrestamos(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarAsistencias(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmAsistencias(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarQuincena(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmQuincena(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarNomina(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmNomina(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarCuentasBancarias(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New General.Controles.FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.CuentaBancaria
    f.PuedeNuevo = True
    Return f
  End Function

  Function CargarRutas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New General.Controles.FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.RutasRoles
    f.PuedeNuevo = False
    Return f
  End Function

  Function CargarRubrosxBeneficio(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmRubroxBeneficio(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarBeneficios(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    'Dim f As New FrmBeneficios(_Sistema, _Restriccion)
    Dim f As New FrmBeneficiosSociales(_Sistema, _Restriccion)
    Return f
  End Function


  Function CargarLiquidacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmLiquidacion(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarPagos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmPagos(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarRubrosxCentroCosto(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmRubrosxCentroCosto(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarReporteIESSEntradaSalida(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, Enumerados.EnumOpciones.ReportesRoles)
    Dim _reporte As New Infoware.Reporteador.Reporte(_Sistema.OperadorDatos, "REPR_Roles$IESS_Entrada_y_Salida")
    _reporte.ValidarReporte(_Sistema.UsuarioString)
    f.Reporte = _reporte
    Return f
  End Function

  Function CargarReporteIESSVariacionExtras(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, Enumerados.EnumOpciones.ReportesRoles)
    Dim _reporte As New Infoware.Reporteador.Reporte(_Sistema.OperadorDatos, "REPR_Roles$IESS_Variacion_por_extras")
    _reporte.ValidarReporte(_Sistema.UsuarioString)
    f.Reporte = _reporte
    Return f
  End Function

  Function CargarReporteIESSDiasNoTrabajados(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, Enumerados.EnumOpciones.ReportesRoles)
    Dim _reporte As New Infoware.Reporteador.Reporte(_Sistema.OperadorDatos, "REPR_Roles$IESS_Dias_no_laborados")
    _reporte.ValidarReporte(_Sistema.UsuarioString)
    f.Reporte = _reporte
    Return f
  End Function

  Function CargarReporteConciliacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, Enumerados.EnumOpciones.ReportesRoles)
    Dim _reporte As New Infoware.Reporteador.Reporte(_Sistema.OperadorDatos, "REPR_Roles$Conciliacion_Bancaria")
    _reporte.ValidarReporte(_Sistema.UsuarioString)
    f.Reporte = _reporte
    Return f
  End Function

  Function CargarImportarMarcacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    'Dim f As New Infoware.Reporteador.FrmLista(_Sistema, Enumerados.EnumOpciones.ReportesInventario)
    'Dim _reporte As New Infoware.Reporteador.Reporte(_Sistema.OperadorDatos, "proc_ImportacionMarcacion")
    '_reporte.ValidarReporte(_Sistema.UsuarioString)
    'f.Reporte = _reporte
    'Return f
    Dim f As New FrmImportacionMarcacion(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarImpuestoRenta(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmImpuestoRenta(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarIESS(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmIess(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarUsuariosRoles(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmListaUsuarios(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarConfiguracion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmConfiguracion(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarConciliacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmConciliacion(_Sistema, _Restriccion)
    Return f
  End Function
#End Region

End Class
