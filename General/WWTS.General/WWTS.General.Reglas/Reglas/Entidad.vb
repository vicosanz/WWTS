'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports System.IO
Imports System.ComponentModel
Imports Infoware.Reglas.General


#Region "Entidad"
Public Class Entidad

  Const _Procedimiento As String = "proc_Entidad"

  Private mParametrodet As WWTSParametroDet = Nothing

  Private mEntidadlugar As EntidadLugar = Nothing

  Private mEntidadjuridica As EntidadJuridica = Nothing

  Private mEntidadnatural As EntidadNatural = Nothing

  Private mEntida_Imagen As System.Drawing.Image = Nothing

  Private mCambio_Imagen As Boolean = False

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _TipoEntidad As Enumerados.EnumTipoEntidad, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
    Parame_Tipoentidad = Enumerados.EnumParametros.TipoEntidad
    Pardet_Tipoentidad = _TipoEntidad
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer)
    Me.New(_OperadorDatos, Enumerados.EnumTipoEntidad.Natural, False)
    Entida_Codigo = _Entida_Codigo
    EsNuevo = Not Me.Recargar
  End Sub

  'Parametrodet
  Public Overridable Property PardetTipoEntidad() As WWTSParametroDet
    Get
      If Me.mParametrodet Is Nothing AndAlso Pardet_Tipoentidad > 0 Then
        Me.mParametrodet = New WWTSParametroDet(OperadorDatos, Parame_Tipoentidad, Pardet_Tipoentidad)
      End If
      Return Me.mParametrodet
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mParametrodet = value
      Parame_Tipoentidad = value.Parame_Codigo
      Pardet_Tipoentidad = value.Pardet_Secuencia
    End Set
  End Property

  Public Shadows Property Pardet_TipoentidadEnum() As Enumerados.EnumTipoEntidad
    Get
      Return CType(Pardet_Tipoentidad, Enumerados.EnumTipoEntidad)
    End Get
    Set(ByVal value As Enumerados.EnumTipoEntidad)
      Pardet_Tipoentidad = CInt(value)
    End Set
  End Property

  'Entidadlugar
  Public Overridable Property Entidadlugar() As EntidadLugar
    Get
      If Me.mEntidadlugar Is Nothing AndAlso Not Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural AndAlso Not Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Juridica Then
        Me.mEntidadlugar = New EntidadLugar(OperadorDatos, Entida_Codigo)
      End If
      If mEntidadlugar IsNot Nothing Then
        mEntidadlugar.Entidad = Me
      End If
      Return Me.mEntidadlugar
    End Get
    Set(ByVal value As EntidadLugar)
      Me.mEntidadlugar = value
      If value IsNot Nothing Then
        Entida_Codigo = value.Entida_Codigo
      End If
    End Set
  End Property

  'Entidadjuridica
  Public Overridable Property Entidadjuridica() As EntidadJuridica
    Get
      If Me.mEntidadjuridica Is Nothing AndAlso Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Juridica Then
        Me.mEntidadjuridica = New EntidadJuridica(OperadorDatos, Entida_Codigo)
      End If
      If mEntidadjuridica IsNot Nothing Then
        mEntidadjuridica.Entidad = Me
      End If
      Return Me.mEntidadjuridica
    End Get
    Set(ByVal value As EntidadJuridica)
      Me.mEntidadjuridica = value
      If value IsNot Nothing Then
        Entida_Codigo = value.Entida_Codigo
      End If
    End Set
  End Property

  'Entidadnatural
  Public Overridable Property Entidadnatural() As EntidadNatural
    Get
      If Me.mEntidadnatural Is Nothing AndAlso Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural Then
        Me.mEntidadnatural = New EntidadNatural(OperadorDatos, Entida_Codigo)
      End If
      If mEntidadnatural IsNot Nothing Then
        mEntidadnatural.Entidad = Me
      End If
      Return Me.mEntidadnatural
    End Get
    Set(ByVal value As EntidadNatural)
      Me.mEntidadnatural = value
      If value IsNot Nothing Then
        Entida_Codigo = value.Entida_Codigo
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Nombre completo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 250, True)> _
  Public ReadOnly Property NombreCompleto() As String
    Get
      Dim nombre As String = String.Empty
      If Entidadnatural IsNot Nothing Then
        nombre = Entidadnatural.NombreCompleto
      ElseIf Entidadjuridica IsNot Nothing Then
        nombre = Entidadjuridica.NombreCompleto
      ElseIf Entidadlugar IsNot Nothing Then
        nombre = Entidadlugar.NombreCompleto
      End If
      Return nombre
    End Get
  End Property

  Public ReadOnly Property EsCliente() As Boolean
    Get
      Try
        Dim mCliente As Cliente = New Cliente(OperadorDatos, Me.Entida_Codigo)
        Return True
      Catch ex As Exception
        Return False
      End Try
    End Get
  End Property

  Public ReadOnly Property EsProveedor() As Boolean
    Get
      Try
        Dim mProveedor As Proveedor = New Proveedor(OperadorDatos, Me.Entida_Codigo)
        Return True
      Catch ex As Exception
        Return False
      End Try
    End Get
  End Property

  Public Overridable ReadOnly Property Entida_ImagenStream() As Byte()
    Get
      Dim imagen() As Byte
      Dim Result As Object = Nothing
      Dim bReturn As Boolean = True
      OperadorDatos.AgregarParametro("@accion", "Pl")
      OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
      OperadorDatos.Procedimiento = _Procedimiento
      bReturn = OperadorDatos.Ejecutar(Result)
      OperadorDatos.LimpiarParametros()
      Try
        imagen = CType(Result, Byte())
      Catch ex As System.Exception
        bReturn = False
        imagen = Nothing
      End Try
      Return imagen
    End Get
  End Property

  'Entida_Imagen
  Public Overridable ReadOnly Property Entida_Imagen(Optional ByVal heightwidth As Integer = 0) As System.Drawing.Image
    Get
      If mEntida_Imagen Is Nothing Then
        Try
          Dim imagen() As Byte
          imagen = Entida_ImagenStream
          If imagen Is Nothing Then
            Return mEntida_Imagen
          End If
          Dim ms As New MemoryStream
          ms.Write(imagen, 0, imagen.GetUpperBound(0) + 1)
          mEntida_Imagen = System.Drawing.Image.FromStream(ms)
          ms.Close()
        Catch ex As System.Exception
          mEntida_Imagen = Nothing
        End Try
      End If
      If heightwidth > 0 AndAlso mEntida_Imagen IsNot Nothing Then
        Dim imagenbm = New System.Drawing.Bitmap(mEntida_Imagen)
        Return imagenbm.GetThumbnailImage(heightwidth, heightwidth, Nothing, New IntPtr())
      Else
        Return mEntida_Imagen
      End If
    End Get
  End Property

  Private mArchivoImagen As String = String.Empty
  Public WriteOnly Property ArchivoImagen() As String
    Set(ByVal value As String)
      mArchivoImagen = value
      EsModificado = True
      mCambio_Imagen = True
    End Set
  End Property

#Region "Identificaciones"
  Private WithEvents mIdentificaciones As EntidadIdentificacionList = Nothing
  Public Property Identificaciones() As EntidadIdentificacionList
    Get
      If mIdentificaciones Is Nothing Then
        mIdentificaciones = EntidadIdentificacionList.ObtenerLista(OperadorDatos, Me)
      End If
      Return mIdentificaciones
    End Get
    Set(ByVal value As EntidadIdentificacionList)
      mIdentificaciones = value
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Identificaciones", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, False)> _
  Public ReadOnly Property IdentificacionesString() As String
    Get
      Dim _result As String = String.Empty
      For Each _ident As EntidadIdentificacion In Identificaciones
        _result += _ident.Identi_Numero & "  "
      Next
      Return _result
    End Get
  End Property
  Public ReadOnly Property Identificacion() As EntidadIdentificacion
    Get
      Dim _result As EntidadIdentificacion = Nothing
      For Each _ident As EntidadIdentificacion In Identificaciones
        If Not _ident.Identi_Numero.Trim = String.Empty AndAlso Not _ident.PardetTipoIdent.Pardet_DatoStr1 = String.Empty Then
          If _result Is Nothing Then
            _result = _ident
          End If
        End If
      Next
      Return _result
    End Get
  End Property
  Public ReadOnly Property SRICodigo_Identificacion() As String
    Get
      Dim _ident As EntidadIdentificacion = Identificacion
      If _ident Is Nothing OrElse _ident.PardetTipoIdent.Pardet_DatoStr1.Trim = String.Empty Then
        Return "F"
      Else
        Return _ident.PardetTipoIdent.Pardet_DatoStr1
      End If
    End Get
  End Property
  Private Sub mIdentificaciones_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mIdentificaciones.AddingNew
    Dim _identificacion As New EntidadIdentificacion(OperadorDatos, True)
    _identificacion.Entidad = Me
    e.NewObject = _identificacion
  End Sub

  Public ReadOnly Property RUC() As String
    Get
      For Each _ident As EntidadIdentificacion In Identificaciones
        If _ident.Pardet_Tipoidentificacion = Enumerados.enumTipoIdentificacion.RUC Then
          Return _ident.Identi_Numero
        End If
      Next
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("C�dula", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property Cedula() As String
    Get
      For Each _ident As EntidadIdentificacion In Identificaciones
        If _ident.Pardet_Tipoidentificacion = Enumerados.enumTipoIdentificacion.Cedula Then
          Return _ident.Identi_Numero
        End If
      Next
      Return String.Empty
    End Get
  End Property

  Public ReadOnly Property CodigoEmpleado() As String
    Get
      For Each _ident As EntidadIdentificacion In Identificaciones
        If _ident.Pardet_Tipoidentificacion = Enumerados.enumTipoIdentificacion.CodigoEmpleado Then
          Return _ident.Identi_Numero
        End If
      Next
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("C�dula militar", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, False)> _
  Public ReadOnly Property CedulaMilitar() As String
    Get
      For Each _ident As EntidadIdentificacion In Identificaciones
        If _ident.Pardet_Tipoidentificacion = Enumerados.enumTipoIdentificacion.CedulaMilitar Then
          Return _ident.Identi_Numero
        End If
      Next
      Return String.Empty
    End Get
  End Property

  Public ReadOnly Property CarnetSeguro() As String
    Get
      For Each _ident As EntidadIdentificacion In Identificaciones
        If _ident.Pardet_Tipoidentificacion = Enumerados.enumTipoIdentificacion.CarnetSeguro Then
          Return _ident.Identi_Numero
        End If
      Next
      Return String.Empty
    End Get
  End Property

  Public ReadOnly Property CarnetConadis() As String
    Get
      For Each _ident As EntidadIdentificacion In Identificaciones
        If _ident.Pardet_Tipoidentificacion = Enumerados.enumTipoIdentificacion.Conadis Then
          Return _ident.Identi_Numero
        End If
      Next
      Return String.Empty
    End Get
  End Property
#End Region

#Region "Direcciones"
  Private WithEvents mDirecciones As EntidadDireccionList = Nothing
  Public Property Direcciones() As EntidadDireccionList
    Get
      If mDirecciones Is Nothing Then
        mDirecciones = EntidadDireccionList.ObtenerLista(OperadorDatos, Me)
      End If
      Return mDirecciones
    End Get
    Set(ByVal value As EntidadDireccionList)
      mDirecciones = value
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Direcci�n", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property DireccionesString() As String
    Get
      Dim _result As String = String.Empty
      For Each _direc As EntidadDireccion In Direcciones
        If Not _direc.Direcc_Calleprincipal.Trim = String.Empty Then
          If Not _result = String.Empty Then
            _result += ", "
          End If
          _result += _direc.Descripcion
        End If
      Next
      Return _result
    End Get
  End Property

  Private Sub mDirecciones_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mDirecciones.AddingNew
    Dim _direccion As New EntidadDireccion(OperadorDatos, True)
    _direccion.Entidad = Me
    e.NewObject = _direccion
  End Sub

  Public ReadOnly Property DireccionDomicilioString() As String
    Get
      For Each _direccion As EntidadDireccion In Direcciones
        If _direccion.Pardet_Tipodireccion = Enumerados.enumTipoDireccion.Domicilio Then
          Return _direccion.DescripcionCorta
        End If
      Next
      Return Nothing
    End Get
  End Property

  'pedro
  Public ReadOnly Property CiudadDomicilioString() As String
    Get
      If CiudadDomicilio Is Nothing Then
        Return String.Empty
      Else
        Return CiudadDomicilio.CiudadString
      End If
    End Get
  End Property
  Public ReadOnly Property CiudadDomicilio() As EntidadDireccion
    Get
      For Each _direccion As EntidadDireccion In Direcciones
        If _direccion.Pardet_Tipodireccion = Enumerados.enumTipoDireccion.Domicilio Then
          Return _direccion
        End If
      Next
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property CiudadString() As String
    Get
      If DireccionTrabajo Is Nothing Then
        Return String.Empty
      Else
        Return DireccionTrabajo.CiudadString
      End If
    End Get
  End Property

  Public ReadOnly Property DireccionTrabajo() As EntidadDireccion
    Get
      For Each _direccion As EntidadDireccion In Direcciones
        If _direccion.Pardet_Tipodireccion = Enumerados.enumTipoDireccion.Trabajo Then
          Return _direccion
        End If
      Next
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property DireccionTrabajoString() As String
    Get
      If DireccionTrabajo Is Nothing Then
        Return String.Empty
      Else
        Return DireccionTrabajo.Descripcion
      End If
    End Get
  End Property
#End Region

#Region "Otros datos"
  Private WithEvents mOtrosDatos As EntidadDatosList = Nothing
  Public Property OtrosDatos() As EntidadDatosList
    Get
      If mOtrosDatos Is Nothing Then
        mOtrosDatos = EntidadDatosList.ObtenerLista(OperadorDatos, Me)
      End If
      Return mOtrosDatos
    End Get
    Set(ByVal value As EntidadDatosList)
      mOtrosDatos = value
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tel�fono", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property TelefonosString() As String
    Get
      Dim _result As String = String.Empty
      For Each _datos As EntidadDatos In OtrosDatos
        If _datos.Pardet_Tipodatos = Enumerados.enumTipoOtrosDatos.Telefono Or _datos.Pardet_Tipodatos = Enumerados.enumTipoOtrosDatos.TelefonoDomicilio Or _datos.Pardet_Tipodatos = Enumerados.enumTipoOtrosDatos.Celular AndAlso Not _datos.Entdat_Descripcion.Trim = String.Empty Then
          If Not _result = String.Empty Then
            _result += ", "
          End If
          _result += _datos.Entdat_Descripcion
        End If
      Next
      Return _result
    End Get
  End Property
  Public ReadOnly Property TelefonoCasaString() As String
    Get
      Dim _result As String = String.Empty
      For Each _datos As EntidadDatos In OtrosDatos
        If _datos.Pardet_Tipodatos = Enumerados.enumTipoOtrosDatos.TelefonoDomicilio Then
          _result += _datos.Entdat_Descripcion
        End If
      Next
      Return _result
    End Get
  End Property
  Public ReadOnly Property EmailsString() As String
    Get
      Dim _result As String = String.Empty
      For Each _datos As EntidadDatos In OtrosDatos
        If _datos.Pardet_Tipodatos = Enumerados.enumTipoOtrosDatos.Email AndAlso Not _datos.Entdat_Descripcion.Trim = String.Empty Then
          If Not _result = String.Empty Then
            _result += ", "
          End If
          _result += _datos.Entdat_Descripcion
        End If
      Next
      Return _result
    End Get
  End Property

  Private Sub mOtrosDatos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mOtrosDatos.AddingNew
    Dim _datos As New EntidadDatos(OperadorDatos, True)
    _datos.Pardet_Tipodatos = Enumerados.enumTipoOtrosDatos.Telefono
    _datos.Entidad = Me
    e.NewObject = _datos
  End Sub

  Public ReadOnly Property Email() As String
    Get
      For Each _otrosdatos As EntidadDatos In OtrosDatos
        If _otrosdatos.Parame_Tipodatos = Enumerados.EnumParametros.TipoEmail Then
          If _otrosdatos.Pardet_Tipodatos = Enumerados.enumTipoEmail.Trabajo Then
            Return _otrosdatos.Entdat_Descripcion
          End If
        End If
      Next
      Return String.Empty
    End Get
  End Property

  Public ReadOnly Property Fax() As String
    Get
      For Each _otrosdatos As EntidadDatos In OtrosDatos
        If _otrosdatos.Parame_Tipodatos = Enumerados.EnumParametros.TipoTelefono Then
          If _otrosdatos.Pardet_Tipodatos = Enumerados.enumTipoTelefono.Fax Then
            Return _otrosdatos.Entdat_Descripcion
          End If
        End If
      Next
      Return String.Empty
    End Get
  End Property

  Public ReadOnly Property Telefono() As String
    Get
      For Each _otrosdatos As EntidadDatos In OtrosDatos
        If _otrosdatos.Parame_Tipodatos = Enumerados.EnumParametros.TipoTelefono Then
          If _otrosdatos.Pardet_Tipodatos = Enumerados.enumTipoTelefono.Trabajo Then
            Return _otrosdatos.Entdat_Descripcion
          End If
        End If
      Next
      Return String.Empty
    End Get
  End Property
#End Region

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Parame_Tipoentidad = CType(Fila("Parame_Tipoentidad"), Integer)
    Pardet_Tipoentidad = CType(Fila("Pardet_Tipoentidad"), Integer)
    Entida_AutorizacionFactura = CStr(Fila("Entida_AutorizacionFactura"))
    Entida_CaducidadFactura = CStr(Fila("Entida_CaducidadFactura"))
    Entida_AutorizacionNotaVenta = CStr(Fila("Entida_AutorizacionNotaVenta"))
    Entida_CaducidadNotaVenta = CStr(Fila("Entida_CaducidadNotaVenta"))
    Entida_AutorizacionRetencion = CStr(Fila("Entida_AutorizacionRetencion"))
    Entida_CaducidadRetencion = CStr(Fila("Entida_CaducidadRetencion"))
    mParametrodet = Nothing
    mEntidadlugar = Nothing
    mEntidadjuridica = Nothing
    mEntidadnatural = Nothing
    mDirecciones = Nothing
    mIdentificaciones = Nothing
    mOtrosDatos = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.datatable = New System.Data.datatable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
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
    'If Not EsNuevo And Not EsModificado Then
    '  Return True
    'End If
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Tipoentidad", Parame_Tipoentidad)
    OperadorDatos.AgregarParametro("@Pardet_Tipoentidad", Pardet_Tipoentidad)
    OperadorDatos.AgregarParametro("@Entida_AutorizacionFactura", Entida_AutorizacionFactura)
    OperadorDatos.AgregarParametro("@Entida_CaducidadFactura", Entida_CaducidadFactura)
    OperadorDatos.AgregarParametro("@Entida_AutorizacionNotaVenta", Entida_AutorizacionNotaVenta)
    OperadorDatos.AgregarParametro("@Entida_CaducidadNotaVenta", Entida_CaducidadNotaVenta)
    OperadorDatos.AgregarParametro("@Entida_AutorizacionRetencion", Entida_AutorizacionRetencion)
    OperadorDatos.AgregarParametro("@Entida_CaducidadRetencion", Entida_CaducidadRetencion)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Entida_Codigo = Result
      End If

      'guardar direcciones
      For Each _direccion As EntidadDireccion In Direcciones
        _direccion.Entida_Codigo = Entida_Codigo
        If _direccion.Direcc_Calleprincipal.Trim = String.Empty Then
          If Not _direccion.Eliminar() Then
            bReturn = False
          End If
        Else
          If Not _direccion.Guardar() Then
            bReturn = False
          End If
        End If
      Next

      For Each _ident As EntidadIdentificacion In Identificaciones
        _ident.Entida_Codigo = Entida_Codigo
        If _ident.Identi_Numero.Trim = String.Empty Then
          If Not _ident.Eliminar Then
            bReturn = False
          End If
        Else
          If Not _ident.Guardar Then
            bReturn = False
          End If
        End If
      Next

      For Each _otros As EntidadDatos In OtrosDatos
        _otros.Entida_Codigo = Entida_Codigo
        If _otros.Entdat_Descripcion.Trim = String.Empty Then
          If Not _otros.Eliminar Then
            bReturn = False
          End If
        Else
          If Not _otros.Guardar Then
            bReturn = False
          End If
        End If
      Next

      If Not OperadorDatos.EstaenTransaccion Then
        EsNuevo = False
        EsModificado = False
      End If

      If mCambio_Imagen Then
        Guardar_Imagen()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Function AceptarCambios() As Boolean
    EsNuevo = False
    EsModificado = False

    Select Case Pardet_Tipoentidad
      Case Enumerados.EnumTipoEntidad.Natural
        Entidadnatural.AceptarCambios(False)
      Case Enumerados.EnumTipoEntidad.Juridica
        Entidadjuridica.AceptarCambios(False)
      Case Enumerados.EnumTipoEntidad.Lugar
        Entidadlugar.AceptarCambios(False)
    End Select

    For Each _direccion As EntidadDireccion In Direcciones
      _direccion.AceptarCambios()
    Next

    For Each _ident As EntidadIdentificacion In Identificaciones
      _ident.AceptarCambios()
    Next

    For Each _otros As EntidadDatos In OtrosDatos
      _otros.AceptarCambios()
    Next
  End Function

  Public Overridable Function Guardar_Imagen() As Boolean
    If EsNuevo Then
      Return False
    End If
    If Not mCambio_Imagen Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "ps")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametroImagen("@Entida_Imagen", mArchivoImagen)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar()
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      mEntida_Imagen = Nothing
      mCambio_Imagen = False
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
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "EntidadList"
Public Class EntidadList
  Inherits System.ComponentModel.BindingList(Of Entidad)

  Enum enumTipoObjeto
    Persona = 0
    Natural = 1
    Juridica = 2
    Lugar = 3
  End Enum

  Public Shared Function ObtenerLista(ByVal _op As OperadorDatos, ByVal _enumtipoobjeto As enumTipoObjeto, Optional ByVal _filtro As String = "") As EntidadList
    Dim oResult As EntidadList = New EntidadList
    Dim bReturn As Boolean
    Dim ds As datatable = Nothing
    With _op
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@TipoPersona", _enumtipoobjeto)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Entidad"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Entidad(_op, Enumerados.EnumTipoEntidad.Natural, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
