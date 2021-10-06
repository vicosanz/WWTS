Public Class Enumerados
#Region "Opciones del sistema"
  Enum EnumModulos
    Empresa = 100
    Finanzas = 200
    Bancos = 300
    Inventario = 400
    Cuentas = 500
    Reclutamiento = 700
    Roles = 750
    Reporteador = 800
    Seguridad = 900
    Fidelizacion = 1000
    Slots = 1100
    MantenimientoSlots = 1200
    MantenimientoComponentes = 1300
    Mesas = 1400
    Siembra = 1500
    FichasMedicas = 1600
    Configuracion = 9000
  End Enum

  Enum EnumOpciones
    Sistema = 1
    PaginaInicio = 100
    Empresa = 110
    Sucursal = 111
    ListadoClientes = 112
    ListadoProveedores = 114
    ListadoEmpleados = 116
    ListadoPersonas = 118
    ListadoParametros = 120

    ListadoRegContables = 205
    ListadoCtaContables = 210
    ListadoSubCtaCtbles = 212
    ListadoMovimientosContables = 214
    ComprobanteDiario = 216
    LibroMayor = 223
    BalanceGeneral = 225
    PerdidaGanancia = 227
    ReportesContables = 299

    ListadoCtaBancarias = 310
    ChequesFirmados = 311
    ListadoTransacciones = 312
    ConciliacionBancaria = 314
    ReportesBancos = 399

    AnexoTransaccional = 322


    ListadoItems = 410
    ListadoBodegas = 412
    ListadoTiposPrecios = 414
    ListadoFormasPago = 415
    Secuenciales = 416
    SecuencialCompraVenta = 417
    MovimientoInventario = 418
    UnidadMedidaConversion = 420
    TPV = 422
    AsientosContablesInventario = 425
    ReportesInventario = 499


    Cuentas = 510
    EstadoCuenta = 520
    AnalisisCartera = 530
    ReportesCuentas = 599

    'vhss
    AreasCargos = 703
    'pedro
    Reclutamiento = 705
    'pedro
    Seleccion = 707
    'pedro
    TestxArea = 706
    Personal = 710
    Prestamos_Anticipos = 715
    RegistrarAsistencias = 720
    'pedro
    Quincena = 723
    'pedro
    Nomina = 724
    CuentaBancaria = 725
    'pedro
    RubrosxBeneficio = 726
    'pedro
    BeneficiosSociales = 727
    'pedro
    Liquidacion = 729
    Pagos = 730
    RubrosxCentroCosto = 731
    ReporteIESS1 = 733
    ReporteIESS2 = 734
    ReporteIESS3 = 736
    IESS = 735
    ImportacionMarcacion = 737
    ImpuestoRenta = 739
    ConfiguracionRoles = 740
    CargarConciliacion = 742
    Conciliacion = 743
    FormatosRoles = 745
    UsuariosRoles = 798
    ReportesRoles = 799

    Reporteador = 810
    Emailsautomatico = 815

    Usuarios = 910
    Auditoria = 912
    Licencias = 915

    ListadoAfiliados = 1001
    Premios = 1010
    RegistroIngreso = 1012
    RegistroPuntos = 1015
    MovimientosInventario = 1020
    Franjashorarios = 1095
    ReportesAfiliados = 1099

    ListadoSlots = 1101
    ListadoJuegos = 1102
    ListadoTipoCambioMoneda = 1103
    ListadoContratoSala = 1105
    ListadoAsociacionSala = 1107
    SucursalSala = 1108
    ContadoresSlot = 1109

    ContadoresSala = 1111
    LiquidacionSala = 1113
    ListadoSala = 1114
    ListadoUsuarioSlots = 1195
    UbicacionSlots = 1196
    ReportesSlots = 1199

    ListadoRecaudos = 1201
    ListaNovedades = 1206
    SlotsConNovedades = 1210
    MantenimientoParteTecnico = 1215
    ListaParteTecnico = 1220
    PlantillaComponentes = 1240
    ListaUsuariosMovimientos = 1245
    ReportesSlotsDañados = 1280
    ReportesRecaudo = 1290

    ListadoComponentes = 1305
    ListadoComponentesDanados = 1310
    ListadoOrdenReparacion = 1315

    ListadoFichas = 1405
    ListadoSitiosJuego = 1410
    ListadoJornada = 1415
    FichasxSitioJuego = 1420
    DashboardMesas = 1425

    EnsarteZafadura = 1505
        Fermentacion = 1510
        Curacion = 1512
        Rezago = 1515
    ConfiguracionSiembra = 1550
    ReportesSiembra = 1590
    ReportesPlanificacion = 1592

    FichasMedicas = 1605
    TiposFichasMedicas = 1610

    Modulos = 9005
    Opciones = 9010
  End Enum
#End Region

#Region "Parametros"
  Enum EnumParametros
    Modulos = 4
    Opciones = 5
    TipoAccion = 10

    TipoObjeto = 100
    TipoEntidad = 110
    TipoLugar = 115
    TipoIdentificacion = 120
    TipoDireccion = 125
    'pedro
    SectorDomicilio = 127
    TipoOtrosDatos = 130

    TipoTelefono = 131
    TipoEmail = 132

    Sexo = 140
    EstadoCivil = 141

    TipoContribuyente = 145

    TipoEmpleado = 150

    Pais = 200
    Provincia = 210
    Ciudad = 220
    Parroquia = 230

    Banco = 300
    CuentaBancaria = 301
    TipoCtaBan = 310
    TarjetaCredito = 305
    TipoCtaCtble = 315
    SubCuenta = 316

    Grupo = 400
    Marca = 410
    TipoInventario = 420
    TipoBodega = 425
    TipoSucursal = 426
    UnidadMedida = 430

    TipoMovInventario = 440
    TipoCompra = 441
    TipoVenta = 442
    TipoAsientoAutomatico = 443

    TipoPrecio = 450
    TipoFormaPago = 460

    TipoMovPagos = 470

    TipoCompteContabilidad = 600
    TipoMovimientoBancario = 605

    RutasRoles = 700
    ClaseEmpleado = 705
    TipoDiscapacidad = 707
    Nacionalidad = 710
    TipoSangre = 715
    'pedro
    Bachiller = 717
    'pedro
    TituloSuperior = 718
    FormaPagoRol = 720
    MotivoPago = 722
    SeguroCorporativo = 724
    TipoCargafamiliar = 725
    PeriodoPago = 730
    'pedro
    TipoPeriodoPago = 731
    TipoContrato = 735
    TipoContratoFormato = 736
    'pedro
    EstadoContrato = 737
    EstadoDiaLabor = 740
    TipoLiquidacion = 745
    TipoSalida = 750
    'pedro
    Licencia = 751
    TipoPermiso = 752
    TipoLlamado = 753
    'pedro
    GravedadLLamdo = 754
    Beneficio = 755
    TipoBeneficio = 756
    TipoPrestamo = 757

    'pedro
    Departamento = 759
    Seccion = 760
    GrupoContable = 761
    Escalafon = 762
    'pedro
    Area = 763
    'pedro
    Rubro = 764
    'pedro
    TipoRubro = 765
    PersonalAdicionalUtilidades = 766
    'pedro
    ActividadSectorial = 770
    'pedro
    ResultadoSeleccion = 780
    'pedro
    SeleccionTest = 781
    TipoGastoPersonal = 790
    ModeloLabor = 800

    CentroCosto = 810
    SubCentroCosto = 811

    ConfiguracionAfiliado = 1000
    TipoAfiliacion = 1001
    FranjaHorarios = 1003
    Ocupacion = 1005
    TipoActividadPuntos = 1010
    Mesa = 1020
    Juego = 1025

    Adjuntos = 2000
    Adjuntosdetalle = 2005

    MarcaSlot = 5000
    ModeloSlot = 5005
    MonedaSlot = 5010
    EmpresaSlot = 5015
    AsociacionSlot = 5020
    SalaSlot = 5025
    EstadoSlot = 5030
    FormulaSlot = 5035
    TipoNovedad = 5060
    Novedad = 5061
    EstadoNovedad = 5065
    EstadoParteTecnico = 5066
    EstadoOrdenreparacion = 5067
    EstadoReparacionComponentes = 5068
    TipoComponente = 5070

    ConceptoCuadreBoveda = 6005
    TurnoSala = 6010

    FichasMesas = 6100
    ClaseSitio = 6104
    TipoSitio = 6105
    TipoTransaccionMesa = 6110

    Hacienda = 900
    Terreno = 905
    Lote = 910
        Horno = 915
        TipoTabaco = 917
        Bodega = 920

    CicloEnsarte = 820

    Licencias = 15000

    TipoFichaMedica = 16000
    Genero = 16005
    Religion = 16010
    Clinica = 16020
  End Enum
#End Region
#Region "Sexo"
  Enum EnumSexo
    Masculino = 1
    Femenino = 2
  End Enum
#End Region

#Region "Rutas"
  Enum enumRutas
    Fotos = 1
    Sobres_pago = 2
  End Enum

#End Region
  'pedro
#Region "Rubro"
  Enum enumRubro
    DefinidoEnContrato = 1
    NoDefinidoEnContrato = 2
    AdicionalesNomina = 6
    ComplementosAsientosContables = 5
    ComplementoNominaMensualizados = 8
    Liquidacion = 7
  End Enum
#End Region

  'pedro
#Region "TipoRubroVarios"
  Enum enumTipoRubroVarios
    Quincena = 11
  End Enum
#End Region

  'pedro
#Region "TipoRubroComplementosNomina"
  Enum enumTipoRubroComplementosNomina
    Horas25 = 8
    Horas50 = 9
    Horas100 = 10
    Vacacion = 12
    SubMaternidad = 13
    SubEnfermedad = 14
    Horas100b = 24
    AportePersonalIESS = 28
    ImpuestoRenta = 35
  End Enum
#End Region

#Region "TipoRubroComplementosNominaMensualizados"
  Enum enumTipoRubroComplementosNominaMensualizados
    FondoReserva = 34
    D3Mensualizado = 81
    D4Mensualizado = 82
    VacacionesMensualizado = 83
  End Enum
#End Region

#Region "TipoRubroComplementosLiquidacion"
  Enum enumTipoRubroComplementosLiquidacion
    UltimoSueldo = 86
    Art185 = 62
    Art188 = 63
    Art181 = 64
    Art190 = 65
    'Art154 = 79
    D3 = 87
    D4 = 88
    Vac = 89
    LiquidacionaPagar = 75
    bonificacion = 76
    otros_I_E = 90
  End Enum
#End Region

#Region "TipoRubroComplementosAsientoContable"
  Enum enumTipoRubroComplementosAsientoContable
    NominaPorPagar = 37
    AnticipoPago = 86
    D3D = 41
    D3H = 38
    D4D = 42
    D4H = 39
    VacacionesD = 43
    VacacionesH = 40
    FondoReservaD = 84
    FondoReservaH = 58
    AportePatronalD = 49
    AportePatronalH = 50
    IECED = 51
    IECEH = 52
    SECAPD = 53
    SECAPH = 54
  End Enum
#End Region

#Region "TipoRubroNoDefinidoContrato"
  Enum enumTipoRubroNoDefinidoContrato
    PrestamoPersonal = 6
    FaltasInjustificadas = 23
    Devoluciones = 31
    Anticipos = 85
    Multa = 44
  End Enum
#End Region

#Region "TipoRubroDefinidoContrato"
  Enum enumTipoRubroDefinidoContrato
    Sueldo = 1
    Alimentacion = 2
    Transporte = 7
    BonoMeta = 33
    Vivienda = 30
    AporteIESSFamiliares = 80
  End Enum
#End Region

#Region "TipoRubroAdicionalesNomina"
  Enum enumTipoRubroAdicionalesNomina
    SueldoSinAp = 45
    SobretiempoSinAp = 66
  End Enum
#End Region

  'pedro
#Region "TipoPeriodoPago"
  Enum enumTipoPeriodoPago
    Quincena = 1
    FindeMes = 2
  End Enum
#End Region

#Region "TipoEntidad"
  Enum EnumTipoEntidad
    Natural = 1
    Juridica = 2
    Lugar = 3
  End Enum
#End Region

#Region "TipoLugar"
  Enum EnumTipoLugar
    Sucursal = 1
    Bodega = 2
  End Enum
#End Region

#Region "TipoOtrosDatos"
  Enum enumTipoOtrosDatos
    Telefono = 1
    Email = 2
    TelefonoDomicilio = 3
    Celular = 8
  End Enum
#End Region

#Region "TipoDireccion"
  Enum enumTipoDireccion
    Trabajo = 1
    Domicilio = 2
  End Enum
#End Region

#Region "TipoTelefono"
  Enum enumTipoTelefono
    Trabajo = 1
    Fax = 2
    Domicilio = 3
  End Enum
#End Region

#Region "TipoEmail"
  Enum enumTipoEmail
    Trabajo = 1
    Trabajo1 = 2
    Domicilio = 3
  End Enum
#End Region

#Region "TipoIdentificacion"
  Enum enumTipoIdentificacion
    RUC = 1
    Cedula = 2
    Pasaporte = 3
    CedulaMilitar = 4
    LicenciaConducir = 5
    
    PrefijoFacturas = 6

    CarnetSeguro = 7
    CodigoEmpleado = 10
    CodigoPatronal = 11
    Conadis = 12
  End Enum
#End Region

#Region "TipoMovInv"
  Enum enumTipoMovInv
    InvInicial = 1
    Compra = 2
    DevVenta = 4
    AjustePos = 5
    Cxc = 8
    OrdenDesensamble = 6
    Transferencia = 9
    Venta = 10
    Consumo = 11
    MalEstado = 12
    DevCompra = 13
    AjusteNeg = 14
    OrdenProduccion = 15
    Cortesia = 16
    Cxp = 18
    EnsambleSlot = 19
    DesensambleSlot = 3
  End Enum
#End Region

#Region "TipoCompra"
  Enum enumTipoCompra
    Compra = 1
    Importacion = 2
    Liqcompra = 3
  End Enum
#End Region

#Region "TipoVenta"
  Enum enumTipoVenta
    Factura = 1
    NotaVenta = 2
    TicketPOS = 3
  End Enum
#End Region

#Region "TipoFormaPago"
  Enum enumTipoFormaPago
    Contado = 1
  End Enum
#End Region

#Region "TipoPrecio"
  Enum enumTipoPrecio
    PrecioContado = 1
  End Enum
#End Region

#Region "TipoMov  "
  Enum enumTipoMovPagos
    Documento = 99
    Efectivo = 1
    Cheque = 2
    Tarjetadecredito = 3
    Comisiontarjeta = 4
    Notadedebito = 5
    Notadecredito = 6
    Depositobancario = 7
    Multaprotesto = 8
    Retencionfuente = 9
    RetencionIVA = 10
  End Enum
#End Region

#Region "TipoInventario"
  Enum EnumTipoInventario
    ParaVenta = 2
    ProductoTerminado = 3
    ActivoFijo = 4
    Obsequio = 5
  End Enum
#End Region

#Region "TipoCuentaContable"
  Enum enumTipoCuentaContable
    Bancos = 1
    CxC = 2
    CxP = 3
    RetFte = 4
    RetIVA = 5
  End Enum
#End Region

#Region "TipoMovimientoBancario"
  Enum enumTipoMovimientoBancario
    Cheque = 1
    Deposito = 2
    ND = 3
    NC = 4
  End Enum
#End Region


  '#Region "Opciones Nuevo"
  '  Public Enum EnumOpcionesNuevo
  '    Afiliado
  '    Persona
  '    Cliente
  '    Proveedor
  '    Empleado
  '    Item
  '    Sucursal
  '    Bodega
  '    MovimientoInventario
  '    CuentaBancaria
  '    RegistroContable
  '    CuentaContable
  '    SubCuentaContable
  '    MovimientoContable
  '  End Enum
  '#End Region

#Region "TipoAccion"
  Enum enumTipoAccion
    IngresoSistema = 1
    SalidaSistema = 2
    Adicion = 3
    Modificacion = 4
    Eliminacion = 5
    Impresion = 6
    Confidencial = 7
  End Enum
#End Region

#Region "Tipo de contrato"
  Enum enumTipoContrato
    Fijo = 1
    Temporada = 2
    PorHoras = 3
    Destajo = 4
  End Enum
#End Region

#Region "FormatoxTipoContrao"
  Enum enumFormatoxTipoContrato
    Contrato = 1
    Renuncia = 2
    Despido = 3
    Suspension = 4
    LlamadaAtencion = 5
    CertificadoTrabajo = 6
    AperturaCuenta = 7
    'Renuncia = 8
  End Enum
#End Region

#Region "Tipos de Fichas Medicas"
  Enum TiposFichasMedicas
    Preocupacional = 1
    Ocupacional = 2
    Reingreso = 3
    Retiro = 4
  End Enum
#End Region

  Public Shared Function RetornarDifFecha(ByVal fechamayor As Date, ByVal fechamenor As Date) As String
    Dim diasdiff As Integer
    diasdiff = DateDiff(DateInterval.Day, fechamenor, fechamayor)
    Select Case diasdiff
      Case 0
        Return "Hoy"
      Case 1
        Return "Ayer"
      Case -1
        Return "Mañana"
      Case Else
        Dim leyenda As String = IIf(diasdiff < 0, "Faltan ", "hace ")
        diasdiff = Math.Abs(diasdiff)

        While diasdiff > 0
          Select Case diasdiff
            Case Is > 365
              leyenda += Int(diasdiff / 365) & " años "
              diasdiff -= Int(diasdiff / 365) * 365
            Case Is > 270
              leyenda += Int(diasdiff / 30) & " meses "
              diasdiff -= Int(diasdiff / 30) * 30
            Case Is > 6
              leyenda += Int(diasdiff / 7) & " semanas "
              diasdiff -= Int(diasdiff / 7) * 7
            Case Else
              leyenda += diasdiff & " dias "
              diasdiff -= diasdiff
          End Select
        End While
        Return leyenda
    End Select
  End Function

#Region "Meses del año"
  Enum MesesDelAnio As Byte
    Enero = 1
    Febrero = 2
    Marzo = 3
    Abril = 4
    Mayo = 5
    Junio = 6
    Julio = 7
    Agosto = 8
    Septiembre = 9
    Octubre = 10
    Noviembre = 11
    Diciembre = 12
  End Enum
  Public Shared Function MesesdelAnioList() As ElementoList
    Dim oResult As New ElementoList
    oResult.Add(New Elemento(MesesDelAnio.Enero, "Enero", "ENE"))
    oResult.Add(New Elemento(MesesDelAnio.Febrero, "Febrero", "FEB"))
    oResult.Add(New Elemento(MesesDelAnio.Marzo, "Marzo", "MAR"))
    oResult.Add(New Elemento(MesesDelAnio.Abril, "Abril", "ABR"))
    oResult.Add(New Elemento(MesesDelAnio.Mayo, "Mayo", "MAY"))
    oResult.Add(New Elemento(MesesDelAnio.Junio, "Junio", "JUN"))
    oResult.Add(New Elemento(MesesDelAnio.Julio, "Julio", "JUL"))
    oResult.Add(New Elemento(MesesDelAnio.Agosto, "Agosto", "AGO"))
    oResult.Add(New Elemento(MesesDelAnio.Septiembre, "Septiembre", "SEP"))
    oResult.Add(New Elemento(MesesDelAnio.Octubre, "Octubre", "OCT"))
    oResult.Add(New Elemento(MesesDelAnio.Noviembre, "Noviembre", "NOV"))
    oResult.Add(New Elemento(MesesDelAnio.Diciembre, "Diciembre", "DIC"))
    Return oResult
  End Function
#End Region

#Region "Tipo de beneficios"
  Enum enumTipoBeneficio As Byte
    DecimoTercero = 1
    DecimoCuarto = 2
    Vacaciones = 3
    Utilidades = 4
    Liquidacion = 5
  End Enum
#End Region

#Region "Dia de la semana"
  Enum DiasSemana As Byte
    Lunes = System.DayOfWeek.Monday
    Martes = System.DayOfWeek.Tuesday
    Miercoles = System.DayOfWeek.Wednesday
    Jueves = System.DayOfWeek.Thursday
    Viernes = System.DayOfWeek.Friday
    Sabado = System.DayOfWeek.Saturday
    Domingo = System.DayOfWeek.Sunday
  End Enum
  Public Shared Function DiaSemanaList() As ElementoList
    Dim oResult As New ElementoList
    oResult.Add(New Elemento(DayOfWeek.Monday, "Lunes", "LU"))
    oResult.Add(New Elemento(DayOfWeek.Tuesday, "Martes", "MA"))
    oResult.Add(New Elemento(DayOfWeek.Wednesday, "Miércoles", "MI"))
    oResult.Add(New Elemento(DayOfWeek.Thursday, "Jueves", "JU"))
    oResult.Add(New Elemento(DayOfWeek.Friday, "Viernes", "VI"))
    oResult.Add(New Elemento(DayOfWeek.Saturday, "Sábado", "SA"))
    oResult.Add(New Elemento(DayOfWeek.Sunday, "Domingo", "DO"))
    Return oResult
  End Function
#End Region

#Region "Periodo de pago"
  Enum enumPeriodoPago As Byte
    Quincenal = 1
    Semanal = 2
    Bisemanal = 3
    Mensual = 4
  End Enum
#End Region

#Region "Modelo de labor"
  Enum enumEstadoModeloLabor As Byte
    NoRegistra = 9
    Normal = 1
    Feriado = 2
    'Suspendido = 3
    SinSueldo = 3
    Permiso = 4
    Vacaciones = 5
    Enfermedad_Maternidad = 6
    'Enfermedad = 6
    DiaLibre = 7
    Maternidad = 8
  End Enum
#End Region

#Region "Motivo Pago"
  Enum enumMotivoPago As Byte
    Nomina = 1
    Prestamo = 2
    'JubilacionPatronal = 0
    'Prestamo = 1
    'DecimoTercero = 2
    'DecimoCuarto = 3
    'Vacaciones = 4
    'Utilidades = 5
    'Sueldos = 6
    'ChequeVario = 7
    'LiquidacionxDespido = 8
    'LiquidacionxRenuncia = 9
    'LiquidacionxRenunciaHoras = 10
    'HonorariosJuiciosLaborales = 11
    'AjusteAdm = 12
    'AjusteFijo = 13
    'AjusteHoras = 14
    'AjusteDestajo = 15
    'AjusteTemporada = 16
    'GastosLegalesInspectoria = 17
    'ServiciosPrestados = 18
    'GastosMedicos = 19
    'CarnetAfiliacion = 20
    'Contribucion = 21
    'SentenciaJuiciosLaborales = 22
    'LiquidacionxSuspension = 23
    'CambiodeCheque = 24
  End Enum
#End Region

#Region "Licencia"
  Enum enumLicencia As Byte
    Maternidad = 1
    Enfermedad = 2
    Vacaciones = 3
    SinSueldo = 4
  End Enum
#End Region

#Region "Tipo de permiso"
  Enum enumTipoPermiso As Byte
    Enfermedad = 1
    Maternidad = 2
    Vacaciones = 3
    Permiso = 4
  End Enum
#End Region

#Region "Tipo de prestamo"
  Enum enumTipoPrestamo As Byte
    Prestamo = 1
    Anticipo = 2
    Faltantes = 3
  End Enum
#End Region

#Region "Tipo de liquidación"
  Enum EnumTipoLiquidacion As Byte
    NoLiquidado = 0
    Despido = 1
    Renuncia = 2
    Suspension = 3
  End Enum
#End Region

#Region "Forma de pago"
  Enum enumFormaPagoRol As Byte
    Cheque = 1
    Efectivo = 2
    Deposito = 3
  End Enum
#End Region

#Region "TipoActividad"
  Enum enumTipoActividad
    Ingreso = 1
    Cambiodinerofichas = 2
    Cambiofichasdinero = 3
    Canje = 4
  End Enum
#End Region

#Region "enumContratoSalaDoc"
  Enum enumContratoSalaDoc As Byte
    Instalacion = 2
    Baja = 5
  End Enum
#End Region

#Region "MotivoSalida"
  Enum enumMotivoSalida
    TerminacionContrato = 1
    Renuncia = 2
    Despido = 3
    Desahucio = 4
    Abandono = 5
    VistoBueno = 6
    Fallecimiento = 7

  End Enum
#End Region

#Region "TipoNovedad"
  Enum enumNovedad
    Grave = 1
    Leve = 2
  End Enum
#End Region

#Region "TipoTransaccion"
  Enum enumTipoTransaccion
    AperturaMesa = 1
    Drop = 2
  End Enum
#End Region


#Region "Tipo de tabaco"
  Enum TipoTabaco
    Natural = 0
    Candela = 1
  End Enum
  Public Shared Function TipoTabacoList() As ElementoList
    Dim oResult As New ElementoList
    oResult.Add(New Elemento(TipoTabaco.Natural, "Natural", "N"))
    oResult.Add(New Elemento(TipoTabaco.Candela, "Candela", "C"))
    Return oResult
  End Function
#End Region

#Region "Tipo Movimientos de Bloque"
  Enum TipoMovBloque
    Ingreso = 0
    Transferencia = 1
    Rezagando = 2
    Embarcado = 3
  End Enum
  Public Shared Function TipoMovBloqueList() As ElementoList
    Dim oResult As New ElementoList
    oResult.Add(New Elemento(TipoMovBloque.Ingreso, "Ingreso", "I"))
    oResult.Add(New Elemento(TipoMovBloque.Transferencia, "Transferencia", "T"))
    oResult.Add(New Elemento(TipoMovBloque.Rezagando, "Rezagando", "R"))
    oResult.Add(New Elemento(TipoMovBloque.Embarcado, "Embarcado", "E"))
    Return oResult
  End Function
#End Region
End Class

Public Class Elemento
  Private mNumero As Integer
  Private mDescripcion As String
  Private mCaracter As String

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal Value As Integer)
      mNumero = Value
    End Set
  End Property
  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal Value As String)
      mDescripcion = Value
    End Set
  End Property
  Public Property Caracter() As String
    Get
      Return mCaracter
    End Get
    Set(ByVal Value As String)
      mCaracter = Value
    End Set
  End Property

  Public Sub New(ByVal _numero As Integer, ByVal _descripcion As String, ByVal _caracter As String)
    mNumero = _numero
    mDescripcion = _descripcion
    mCaracter = _caracter
  End Sub
End Class

Public Class ElementoList
  Inherits System.ComponentModel.BindingList(Of Elemento)
  Public Sub New()
  End Sub

  Public Function RetornarDescripcion(ByVal _numero As Integer) As String
    Dim oResult As String = String.Empty
    For Each _elemento As Elemento In Me.Items
      If _elemento.Numero = _numero Then
        Return _elemento.Descripcion
      End If
    Next
    Return oResult
  End Function

  Public Function RetornarDescripcion(ByVal _caracter As String) As String
    Dim oResult As String = String.Empty
    For Each _elemento As Elemento In Me.Items
      If _elemento.Caracter.Trim = _caracter.Trim Then
        Return _elemento.Descripcion
      End If
    Next
    Return oResult
  End Function

  Public Function RetornarNumero(ByVal _valor As String) As Integer
    Dim oResult As Integer = 0
    For Each _elemento As Elemento In Me.Items
      If _elemento.Caracter.Trim = _valor.Trim Then
        Return _elemento.Numero
      End If
    Next
    Return oResult
  End Function

  Public Function RetornarCaracter(ByVal _numero As Integer) As String
    Dim oResult As String = String.Empty
    For Each _elemento As Elemento In Me.Items
      If _elemento.Numero = _numero Then
        Return _elemento.Caracter
      End If
    Next
    Return oResult
  End Function

End Class
