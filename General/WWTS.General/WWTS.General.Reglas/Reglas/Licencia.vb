Option Strict Off
Option Explicit On

Imports Infoware.Datos
'Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "Licencia"
Public Class Licencia
  Inherits _Database

  Const _Procedimiento As String = "proc_Licencia"

  Private mContrato As Contrato = Nothing

  Private mPardetLicencia As WWTSParametroDet = Nothing

  Private mesCerrado As Boolean = False

  Private mesVacacion As Boolean = False

  Private mPardetTipoBeneficio As WWTSParametroDet = Nothing

  Private mPardetAdjuntoLicencia As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer, ByVal _Patron_Codigo As Integer, ByVal _Contra_Secuencia As Integer, ByVal _Licenc_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Entida_Codigo = _Entida_Codigo
    Patron_Codigo = _Patron_Codigo
    Contra_Secuencia = _Contra_Secuencia
    Licenc_Secuencia = _Licenc_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Licencia")
    End If
  End Sub

  'Contrato
  Public Overridable Property Contrato() As Contrato
    Get
      If Me.mContrato Is Nothing AndAlso Contra_Secuencia > 0 Then
        Me.mContrato = New Contrato(OperadorDatos, Entida_Codigo, Patron_Codigo, Contra_Secuencia)
      End If
      Return Me.mContrato
    End Get
    Set(ByVal value As Contrato)
      Me.mContrato = value
      Entida_Codigo = value.Entida_Codigo
      Patron_Codigo = value.Patron_Codigo
      Contra_Secuencia = value.Contra_Secuencia
    End Set
  End Property

  'PardetLicencia
  Public Overridable Property PardetLicencia() As WWTSParametroDet
    Get
      If Me.mPardetLicencia Is Nothing AndAlso Pardet_Licencia > 0 Then
        Me.mPardetLicencia = New WWTSParametroDet(OperadorDatos, Parame_Licencia, Pardet_Licencia)
      End If
      Return Me.mPardetLicencia
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetLicencia = value
      If value Is Nothing Then
        Parame_Licencia = 0
        Pardet_Licencia = 0
      Else
        Parame_Licencia = value.Parame_Codigo
        Pardet_Licencia = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetAdjuntoLicencia
  Public Overridable Property PardetAdjuntoLicencia() As WWTSParametroDet
    Get
      If Me.mPardetAdjuntoLicencia Is Nothing AndAlso Pardet_AdjuntoLicencia > 0 Then
        Me.mPardetAdjuntoLicencia = New WWTSParametroDet(OperadorDatos, Parame_AdjuntoLicencia, Pardet_AdjuntoLicencia)
      End If
      Return Me.mPardetAdjuntoLicencia
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetAdjuntoLicencia = value
      If value Is Nothing Then
        Parame_AdjuntoLicencia = 0
        Pardet_AdjuntoLicencia = 0
      Else
        Parame_AdjuntoLicencia = value.Parame_Codigo
        Pardet_AdjuntoLicencia = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public Property esCerrado() As Boolean
    Get
      Return mesCerrado
    End Get
    Set(ByVal Value As Boolean)
      mesCerrado = Value
    End Set
  End Property

  Public Property esVacacion() As Boolean
    Get
      Return mesVacacion
    End Get
    Set(ByVal Value As Boolean)
      mesVacacion = Value
    End Set
  End Property

  'PardetTipoBeneficio
  Public Overridable Property PardetTipoBeneficio() As WWTSParametroDet
    Get
      If Me.mPardetTipoBeneficio Is Nothing AndAlso Pardet_TipoBeneficio > 0 Then
        Me.mPardetTipoBeneficio = New WWTSParametroDet(OperadorDatos, Me.Parame_TipoBeneficio, Me.Pardet_TipoBeneficio)
      End If
      Return Me.mPardetTipoBeneficio
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoBeneficio = value
      If value Is Nothing Then
        Parame_TipoBeneficio = 0
        Pardet_TipoBeneficio = 0
      Else
        Parame_TipoBeneficio = value.Parame_Codigo
        Pardet_TipoBeneficio = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo Licencia", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetLicenciaString() As String
    Get
      If PardetLicencia Is Nothing Then
        Return String.Empty
      Else
        Return PardetLicencia.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Desde", CampoReporteAtributo.EnumTipoDato.Fecha, 100, True)> _
  Public ReadOnly Property FechaDesde() As Date
    Get
      Return Licenc_Desde
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Hasta", CampoReporteAtributo.EnumTipoDato.Fecha, 100, True)> _
  Public ReadOnly Property FechaHasta() As Date
    Get
      If esCerrado Then
        Return Licenc_Hasta
      Else
        Return Nothing
      End If
    End Get
  End Property

  Public Overridable Property Pardet_LicenciaEnum() As Enumerados.enumLicencia
    Get
      Return CType(Pardet_Licencia, Enumerados.enumLicencia)
    End Get
    Set(ByVal value As Enumerados.enumLicencia)
      Pardet_Licencia = CInt(value)
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Nombre Empleado", CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property NombreEmpleado() As String
    Get
      Return Me.Contrato.EmpleadoString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Desde Larga", CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property FechaDesdeString() As String
    Get
      Return Licenc_Desde.ToLongDateString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Hasta Larga", CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property FechaHastaString() As String
    Get
      If esCerrado Then
        Return Licenc_Hasta.ToLongDateString
      Else
        Return String.Empty
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Solicitud", CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property FechaHoyString() As String
    Get
      If esCerrado Then
        Return Now.Date.ToString("dd 'de' MMMMM 'de' yyyy")
      Else
        Return String.Empty
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Patrono", CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property PatronoString() As String
    Get
      Return Contrato.PatronoString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("CedEmpleado", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property CedEmpleadoString() As String
    Get
      Return Contrato.CedEmpleadoString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha Ingreso", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property FechaIngresoString() As String
    Get
      Return Contrato.Contra_Desde.ToString("dd/MM/yyyy")
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Cargo", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property CargoString() As String
    Get
      Return Contrato.CargoString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Local", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property LocalString() As String
    Get
      Return Contrato.PardetDepartamento.PardetPadre.Pardet_Descripcion
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Ciudad", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property CiudadString() As String
    Get
      Return Contrato.PardetDepartamento.PardetPadre.PardetPadre.Pardet_Descripcion
    End Get
  End Property

  Private mPeriodo As BeneficiosSociales = Nothing
  'Periodo
  Public ReadOnly Property Periodo() As BeneficiosSociales
    Get
      If Me.mPeriodo Is Nothing AndAlso BenSoc_Secuencia > 0 Then
        Me.mPeriodo = New BeneficiosSociales(OperadorDatos, Contrato, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Vacaciones, BenSoc_Secuencia, False, Licenc_Desde, Licenc_Hasta)
      End If
      Return Me.mPeriodo
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Periodo", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property PeriodoVacacionString() As String
    Get
      Return Periodo.BenSoc_FechaDesde.Year.ToString() + " - " + Periodo.BenSoc_FechaHasta.Year.ToString()
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Días", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property DiasString() As String
    Get
      Return (DateDiff(DateInterval.Day, FechaDesde, FechaHasta) + 1).ToString()
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Jefe inmediato", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property JefeinmediatoString() As String
    Get
      Return Contrato.Cargo.JefeInmediatoEmpleadoActual
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Días Totales", CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property DiasTotalesString() As String
    Get
      Return Periodo.BenSoc_Dias - Periodo.DiasUtilizados + (DateDiff(DateInterval.Day, FechaDesde, FechaHasta) + 1)
      'Return (DateDiff(DateInterval.Day, FechaDesde, FechaHasta) + 1).ToString()
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Contra_Secuencia = CType(Fila("Contra_Secuencia"), Integer)
    Licenc_Secuencia = CType(Fila("Licenc_Secuencia"), Integer)
    Licenc_Desde = CType(Fila("Licenc_Desde"), Date)
    Try
      Licenc_Hasta = CType(Fila("Licenc_Hasta"), Date)
      mesCerrado = True
    Catch
      Licenc_Hasta = Now.Date
      mesCerrado = False
    End Try
    Parame_Licencia = CType(Fila("Parame_Licencia"), Integer)
    Pardet_Licencia = CType(Fila("Pardet_Licencia"), Integer)
    Try
      Parame_TipoBeneficio = CType(Fila("Parame_TipoBeneficio"), Integer)
      Pardet_TipoBeneficio = CType(Fila("Pardet_TipoBeneficio"), Integer)
      BenSoc_Secuencia = CType(Fila("BenSoc_Secuencia"), Integer)
      Licenc_VacacionAprobado = CType(Fila("Licenc_VacacionAprobado"), Boolean)
      mesVacacion = True
    Catch
      Parame_TipoBeneficio = 0
      Pardet_TipoBeneficio = 0
      BenSoc_Secuencia = 0
      Licenc_VacacionAprobado = False
      mesVacacion = False
    End Try

    Try
      Parame_AdjuntoLicencia = CInt(Fila("Parame_AdjuntoLicencia"))
      Pardet_AdjuntoLicencia = CInt(Fila("Pardet_AdjuntoLicencia"))
    Catch ex As Exception
      Parame_AdjuntoLicencia = 0
      Pardet_AdjuntoLicencia = 0
    End Try

    mContrato = Nothing
    mPardetLicencia = Nothing
    mPardetTipoBeneficio = Nothing
    mPardetAdjuntoLicencia = Nothing
    mPeriodo = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Licenc_Secuencia", Licenc_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If

    If PardetAdjuntoLicencia IsNot Nothing AndAlso PardetAdjuntoLicencia.PardetHijos IsNot Nothing Then
      If (PardetAdjuntoLicencia.EsNuevo AndAlso PardetAdjuntoLicencia.PardetHijos.Count > 0) Or (Not PardetAdjuntoLicencia.EsNuevo AndAlso PardetAdjuntoLicencia.PardetHijos.Count + PardetAdjuntoLicencia.PardetHijosEli.Count > 0) Then
        bReturn = PardetAdjuntoLicencia.Guardar
        If bReturn Then
          Parame_AdjuntoLicencia = PardetAdjuntoLicencia.Parame_Codigo
          Pardet_AdjuntoLicencia = PardetAdjuntoLicencia.Pardet_Secuencia
        End If
      End If
    End If

    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Licenc_Secuencia", Licenc_Secuencia)
    OperadorDatos.AgregarParametro("@Licenc_Desde", Licenc_Desde)
    If mesCerrado Then
      OperadorDatos.AgregarParametro("@Licenc_Hasta", Licenc_Hasta)
    End If
    OperadorDatos.AgregarParametro("@Parame_Licencia", Parame_Licencia)
    OperadorDatos.AgregarParametro("@Pardet_Licencia", Pardet_Licencia)
    If mesVacacion Then
      OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
      OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
      OperadorDatos.AgregarParametro("@BenSoc_Secuencia", BenSoc_Secuencia)
      OperadorDatos.AgregarParametro("@Licenc_VacacionAprobado", Licenc_VacacionAprobado)
    End If
    If Pardet_AdjuntoLicencia > 0 Then
      OperadorDatos.AgregarParametro("@Parame_AdjuntoLicencia", Parame_AdjuntoLicencia)
      OperadorDatos.AgregarParametro("@Pardet_AdjuntoLicencia", Pardet_AdjuntoLicencia)
    End If
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      EsNuevo = False
      EsModificado = False
    End If
    Return bReturn
  End Function

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Licenc_Secuencia", Licenc_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "LicenciaList"
Public Class LicenciaList
  Inherits System.ComponentModel.BindingList(Of Licencia)

  Public Shared Function ObtenerListaxContrato(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, Optional ByVal _filtro As String = "") As LicenciaList
    Dim oResult As LicenciaList = New LicenciaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FC")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Licencia"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Licencia(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  'para asistencias
  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _Contrato As Contrato, ByVal _desde As Date, ByVal _hasta As Date) As LicenciaList
    Dim oResult As New LicenciaList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable
    With _OperadorDatos
      .AgregarParametro("@accion", "FA")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@desde", _desde.Date)
      .AgregarParametro("@hasta", _hasta.Date)
      .Procedimiento = "proc_Licencia"
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New Licencia(_OperadorDatos, False)
        _obj.MapearDataRowaObjeto(_dr)
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function

  'vacaciones por periodo
  Public Shared Function ObtenerListaVacacionesxPeriodo(ByVal _Beneficio As BeneficiosSociales, Optional ByVal _filtro As String = "") As LicenciaList
    Dim oResult As LicenciaList = New LicenciaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Beneficio.OperadorDatos
      .AgregarParametro("@accion", "FV")
      .AgregarParametro("@BenSoc_Secuencia", _Beneficio.BenSoc_Secuencia)
      .AgregarParametro("@Entida_Codigo", _Beneficio.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Beneficio.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Beneficio.Contra_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Licencia"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Licencia(_Beneficio.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region