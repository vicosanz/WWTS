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
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas


#Region "MovimientoInventario"
Public Class MovimientoInventario

  Const _Procedimiento As String = "proc_MovimientoInventario"

  Private mTipomovimientoinventario As TipoMovimientoInventario = Nothing

  Private mBodega As Bodega = Nothing

  Private mBodegaDsno As Bodega = Nothing

  Private mSucursal As Sucursal = Nothing

  Private mPardetTipoMovInv As WWTSParametroDet = Nothing

  Private mVenta As Venta = Nothing

  Private mCompra As Compra = Nothing

  Private mRegistroContable As RegistroContable = Nothing

  Private mCuentacontable As CuentaContable = Nothing

  Private mSubcuentacontable As WWTSParametroDet = Nothing

  Private mItem As Item = Nothing

  Public Event evCodigo_No_Existe As EventHandler

  Public Sub Codigo_No_Existe()
    RaiseEvent evCodigo_No_Existe(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _Pardet_Tipomovinv As Enumerados.enumTipoMovInv, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    Sucursal = _Sucursal
    Parame_Tipomovinv = Enumerados.EnumParametros.TipoMovInventario
    Pardet_Tipomovinv = _Pardet_Tipomovinv
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _Pardet_Tipomovinv As Enumerados.enumTipoMovInv, ByVal _Movinv_Secuencia As Integer)
    Me.New(_Sucursal, _Pardet_Tipomovinv, False)
    Movinv_Secuencia = _Movinv_Secuencia
    If Not Me.Recargar Then
      Throw New System.Exception("No se puede cargar objeto MovimientoInventario")
    End If
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipomovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    Sucursal = _Sucursal
    PardetTipoMovInv = _PardetTipomovinv
    Movinv_Secuencia = _Movinv_Secuencia
    If Not Me.Recargar Then
      Throw New System.Exception("No se puede cargar objeto MovimientoInventario")
    End If
  End Sub

  
  Public ReadOnly Property PardetTipoMovimientoString() As String
    Get
      If PardetTipoMovInv Is Nothing Then
        Return String.Empty
      Else
        Return PardetTipoMovInv.Pardet_Descripcion
      End If
    End Get
  End Property

  'Private mParteTecnicoMovimientosInventario As ParteTecnicoMovimientosInventario
  'Public Property ParteTecnicoMovimientosInventario() As ParteTecnicoMovimientosInventario
  '  Get
  '    Return mParteTecnicoMovimientosInventario
  '  End Get
  '  Set(ByVal value As ParteTecnicoMovimientosInventario)
  '    mParteTecnicoMovimientosInventario = value
  '  End Set
  'End Property


  Public ReadOnly Property Descripcion() As String
    Get
      Return String.Format("{0} {1} {2}", TipoMovimientoInventarioString, CompraVentaNumero, ClienteProveedorString)
    End Get
  End Property

  Public Overridable Shadows Property Pardet_TipomovinvEnum() As Enumerados.enumTipoMovInv
    Get
      Return CType(Pardet_Tipomovinv, Enumerados.enumTipoMovInv)
    End Get
    Set(ByVal value As Enumerados.enumTipoMovInv)
      Pardet_Tipomovinv = CInt(value)
    End Set
  End Property

  'Tipomovimientoinventario
  Public Overridable Property Tipomovimientoinventario() As TipoMovimientoInventario
    Get
      If Me.mTipomovimientoinventario Is Nothing Then
        Me.mTipomovimientoinventario = New TipoMovimientoInventario(OperadorDatos, Me.Parame_Tipomovinv, Pardet_Tipomovinv, Empres_Bodega, Sucurs_Bodega)
      End If
      Return Me.mTipomovimientoinventario
    End Get
    Set(ByVal value As TipoMovimientoInventario)
      Me.mTipomovimientoinventario = value
      Parame_Tipomovinv = value.Parame_Tipomovinv
      Pardet_Tipomovinv = value.Pardet_Tipomovinv
      Empres_Bodega = value.Empres_Codigo
      Sucurs_Bodega = value.Sucurs_Codigo
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo movimiento", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 105, True)> _
  Public ReadOnly Property TipoMovimientoInventarioString() As String
    Get
      If Tipomovimientoinventario Is Nothing Then
        Return String.Empty
      Else
        Return mTipomovimientoinventario.PardetTipoMovInv.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("N�mero", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Numero, 60, True)>
  Public ReadOnly Property Secuencia() As Integer
    Get
      Return Me.mMovinv_Secuencia
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Anulada", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 40, True)>
  Public ReadOnly Property Anulada() As Boolean
    Get
      Return Me.mMovinv_esAnulada
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("No Compra/Venta", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 105, True)> _
  Public ReadOnly Property CompraVentaNumero() As String
    Get
      If Compra IsNot Nothing Then
        Return Compra.Compra_Numero
      End If
      If Venta IsNot Nothing Then
        Return Venta.Venta_Numero
      End If
      Return 0
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Cliente/Proveedor", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property ClienteProveedorString() As String
    Get
      If ClienteProveedor Is Nothing Then
        Return String.Empty
      Else
        Return ClienteProveedor.NombreCompleto
      End If
    End Get
  End Property

  Public ReadOnly Property ClienteProveedor() As Entidad
    Get
      If Compra IsNot Nothing Then
        Return mCompra.Proveedor.Entidad
      ElseIf Venta IsNot Nothing Then
        Return mVenta.Cliente.Entidad
      Else
        Return Nothing
      End If
    End Get
  End Property

  'Sucursal
  Public Overridable Property Sucursal() As Sucursal
    Get
      If Me.mSucursal Is Nothing AndAlso Sucurs_Bodega > 0 Then
        Me.mSucursal = New Sucursal(New Empresa(OperadorDatos, Empres_Bodega), Sucurs_Bodega)
      End If
      Return Me.mSucursal
    End Get
    Set(ByVal value As Sucursal)
      Me.mSucursal = value
      Empres_Bodega = value.Empres_Codigo
      Sucurs_Bodega = value.Sucurs_Codigo
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoMovInv() As WWTSParametroDet
    Get
      If Me.mPardetTipoMovInv Is Nothing AndAlso Pardet_Tipomovinv > 0 Then
        Me.mPardetTipoMovInv = New WWTSParametroDet(OperadorDatos, Parame_Tipomovinv, Pardet_Tipomovinv)
      End If
      Return Me.mPardetTipoMovInv
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoMovInv = value
      Parame_Tipomovinv = value.Parame_Codigo
      Pardet_Tipomovinv = value.Pardet_Secuencia
    End Set
  End Property

#Region "Detalles"
  Private WithEvents mDetalles As MovimientoInventarioDetList = Nothing
  Public Property Detalles() As MovimientoInventarioDetList
    Get
      If mDetalles Is Nothing Then
        If EsNuevo Then
          mDetalles = New MovimientoInventarioDetList
          mDetalles.AddNew()
        Else
          mDetalles = MovimientoInventarioDetList.ObtenerLista(Me)
        End If
      End If
      Return mDetalles
    End Get
    Set(ByVal value As MovimientoInventarioDetList)
      mDetalles = value
    End Set
  End Property

  Private Sub mDetalles_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mDetalles.AddingNew
    e.NewObject = New MovimientoInventarioDet(Me, True)
  End Sub
#End Region

#Region "DetalleSerie"
  Public ReadOnly Property DetalleSerie() As MovimientoInventarioDetSerieList
    Get
      Dim _detalle As New MovimientoInventarioDetSerieList
      For Each _det As MovimientoInventarioDet In Me.Detalles
        If _det.Item IsNot Nothing AndAlso Not String.IsNullOrEmpty(_det.Item.Item_CodigoAuxiliar) Then
          If _det.Item.Item_esRegistroSerie Then
            For Each _serie As MovimientoInventarioDetSerie In _det.DetallesSeries
              _detalle.Add(_serie)
            Next
          Else
            If _det.Moinde_CantidadStd = CInt(_det.Moinde_CantidadStd) Then
              For t As Integer = 1 To _det.Moinde_CantidadStd
                Dim _serie As New MovimientoInventarioDetSerie
                _serie.Movimientoinventariodet = _det
                _detalle.Add(_serie)
              Next
            End If
          End If
        End If
      Next
      Return _detalle
    End Get
  End Property
#End Region

#Region "Pagos"
  Private WithEvents mPagosEliminados As New PagosDetList
  Public ReadOnly Property PagosEliminados() As PagosDetList
    Get
      Return mPagosEliminados
    End Get
  End Property

  Private WithEvents mPagos As PagosDetList = Nothing
  Public Property Pagos(Optional ByVal Recargar As Boolean = False) As PagosDetList
    Get
      If Recargar OrElse mPagos Is Nothing Then
        If EsNuevo Then
          mPagos = New PagosDetList
          mPagos.AddNew()
        Else
          mPagos = PagosDetList.ObtenerLista(Me)
          mPagosEliminados = New PagosDetList
        End If
      End If
      Return mPagos
    End Get
    Set(ByVal value As PagosDetList)
      mPagos = value
    End Set
  End Property

  Private Sub mPagos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mPagos.AddingNew
    Dim _pagdet As New PagosDet(Me, True)
    _pagdet.Pagdet_FechaPago = Me.Movinv_Fecha
    e.NewObject = _pagdet
  End Sub
#End Region

  <Infoware.Reportes.CampoReporteAtributo("FechaVencimiento", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha)>
  Public ReadOnly Property FechaVencimiento() As DateTime
    Get
      If Compra IsNot Nothing Then
        Return Compra.FechaVencimiento
      End If
      If Venta IsNot Nothing Then
        Return Venta.FechaVencimiento
      End If
      Return Now.Date
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("FormaPago", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto)>
  Public ReadOnly Property FormaPago() As String
    Get
      If Compra IsNot Nothing Then
        If Compra.PardetTipoPago IsNot Nothing Then
          Return Compra.PardetTipoPago.Pardet_Descripcion
        End If
      ElseIf Venta IsNot Nothing Then
        If Venta.PardetTipoPago IsNot Nothing Then
          Return Venta.PardetTipoPago.Pardet_Descripcion
        End If
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("GuiaRemision", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto)>
  Public ReadOnly Property GuiaRemision() As String
    Get
      If Venta IsNot Nothing Then
        Return Venta.Venta_GuiaRemision
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("OrdenCompra", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto)>
  Public ReadOnly Property OrdenCompra() As String
    Get
      If Venta IsNot Nothing Then
        Return Venta.Venta_OrdenCompra
      End If
      Return String.Empty
    End Get
  End Property


  <Infoware.Reportes.CampoReporteAtributo("Atencion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto)>
  Public ReadOnly Property Atencion() As String
    Get
      If Venta IsNot Nothing AndAlso Venta.Cliente IsNot Nothing AndAlso
        Venta.Cliente.Entidad IsNot Nothing AndAlso Venta.Cliente.Entidad.Entidadjuridica IsNot Nothing Then
        Return Venta.Cliente.Entidad.Entidadjuridica.ContactoString
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Subtotal", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales)>
  Public Overridable ReadOnly Property Subtotal() As Decimal
    Get
      If Detalles Is Nothing Then
        Return 0
      Else
        Dim _descto As Decimal = 0
        For Each _detalle As MovimientoInventarioDet In mDetalles
          _descto += _detalle.SubTotal
        Next
        Return _descto
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("TotalDescto", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales)> _
  Public Overridable ReadOnly Property TotalDescto() As Decimal
    Get
      If Detalles Is Nothing Then
        Return 0
      Else
        Dim _descto As Decimal = 0
        For Each _detalle As MovimientoInventarioDet In mDetalles
          _descto += _detalle.Descuento
        Next
        Return _descto
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Base0", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales)> _
  Public Overridable ReadOnly Property Base0() As Decimal
    Get
      If Detalles Is Nothing Then
        Return 0
      Else
        Dim _base0 As Decimal = 0
        For Each _detalle As MovimientoInventarioDet In mDetalles
          If Not _detalle.Moinde_Aplicaiva Then
            _base0 += _detalle.Total
          End If
        Next
        Return _base0
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("BaseIVA", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales)> _
  Public Overridable ReadOnly Property BaseGravadaIVA() As Decimal
    Get
      If Detalles Is Nothing Then
        Return 0
      Else
        Dim _basegrav As Decimal = 0
        For Each _detalle As MovimientoInventarioDet In mDetalles
          If _detalle.Moinde_Aplicaiva Then
            _basegrav += _detalle.Total
          End If
        Next
        Return _basegrav
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("BaseImpRetFte", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales)> _
  Public Overridable ReadOnly Property BaseImponibleRetFte() As Decimal
    Get
      If Detalles Is Nothing Then
        Return 0
      Else
        Dim _totaldoc As Decimal = 0
        For Each _detalle As MovimientoInventarioDet In mDetalles
          _totaldoc += _detalle.Total
        Next
        Return _totaldoc
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Total Iva", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales)> _
  Public Overridable ReadOnly Property TotalIva() As Decimal
    Get
      Return BaseGravadaIVA * (Movinv_porcIVA / 100)
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Total General", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 80, True)> _
  Public Overridable ReadOnly Property TotalGeneral() As Decimal
    Get
      Return BaseImponibleRetFte + TotalIva
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Valor Pendiente", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 80, True)> _
  Public ReadOnly Property ValorPendiente() As Decimal
    Get
      Dim valor As Decimal = 0
      If Pagos IsNot Nothing Then
        For Each _pago As PagosDet In Pagos
          valor += _pago.Pagdet_Valor
        Next
      End If
      Return valor
    End Get
  End Property

  Public Property Venta() As Venta
    Get
      If mVenta Is Nothing And (Pardet_Tipomovinv = Enumerados.enumTipoMovInv.Venta Or Pardet_Tipomovinv = Enumerados.enumTipoMovInv.DevVenta) Then
        Try
          mVenta = New Venta(Sucursal, PardetTipoMovInv, Movinv_Secuencia, True)
        Catch ex As Exception
          mVenta = Nothing
        End Try
      End If
      Return mVenta
    End Get
    Set(ByVal value As Venta)
      mVenta = value
    End Set
  End Property

  Public Property Compra() As Compra
    Get
      If mCompra Is Nothing And (Pardet_Tipomovinv = Enumerados.enumTipoMovInv.Compra Or Pardet_Tipomovinv = Enumerados.enumTipoMovInv.DevCompra) Then
        Try
          mCompra = New Compra(Sucursal, PardetTipoMovInv, Movinv_Secuencia, True)
        Catch ex As Exception
          mCompra = Nothing
        End Try
      End If
      Return mCompra
    End Get
    Set(ByVal value As Compra)
      mCompra = value
    End Set
  End Property

  Public ReadOnly Property SustentoTributario() As String
    Get
      If Compra Is Nothing Then
        Return String.Empty
      Else
        Return mCompra.SRI_creditotributario
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("No_CompraVentaLargo")> _
  Public ReadOnly Property CompraVentaString() As String
    Get
      If Compra IsNot Nothing Then
        Return String.Format("{0} - {1}", mCompra.PardetTipoCompra.Pardet_Descripcion, mCompra.Compra_Numero)
      ElseIf Venta IsNot Nothing Then
        Return String.Format("{0} - {1}", mVenta.PardetTipoVenta.Pardet_Descripcion, mVenta.Venta_Numero)
      Else
        Return String.Empty
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Direccion_ClienteProveedor")> _
  Public ReadOnly Property ClienteProveedorDireccion() As String
    Get
      If Compra IsNot Nothing Then
        Return mCompra.DireccionString
      End If
      If Venta IsNot Nothing Then
        Return mVenta.DireccionString
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Ciudad_ClienteProveedor")> _
  Public ReadOnly Property ClienteProveedorCiudad() As String
    Get
      If Compra IsNot Nothing Then
        Return mCompra.CiudadString
      End If
      If Venta IsNot Nothing Then
        Return mVenta.CiudadString
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Telefono_ClienteProveedor")> _
  Public ReadOnly Property ClienteProveedorTelefono() As String
    Get
      If Compra IsNot Nothing Then
        Return mCompra.TelefonoString
      End If
      If Venta IsNot Nothing Then
        Return mVenta.TelefonoString
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Identificacion_ClienteProveedor")> _
  Public ReadOnly Property ClienteProveedorIdentificacion() As String
    Get
      If Compra IsNot Nothing Then
        Return mCompra.Proveedor.Entidad.IdentificacionesString
      End If
      If Venta IsNot Nothing Then
        Return mVenta.Cliente.Entidad.IdentificacionesString
      End If
      Return String.Empty
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Total Pagar Letras")> _
  Public ReadOnly Property TotalaPagarenLetras() As String
    Get
      Return Utilerias.NumaLetras(Math.Abs(TotalGeneral))
    End Get
  End Property

  'Bodega
  Public Overridable Overloads Property Bodega() As Bodega
    Get
      If Me.mBodega Is Nothing AndAlso Bodega_Codigo > 0 Then
        Me.mBodega = New Bodega(New Sucursal(New Empresa(OperadorDatos, Me.Empres_Bodega), Me.Sucurs_Bodega), Me.Bodega_Codigo)
      End If
      Return Me.mBodega
    End Get
    Set(ByVal value As Bodega)
      Me.mBodega = value
      Try
        Empres_Bodega = value.Empres_Codigo
        Sucurs_Bodega = value.Sucurs_Codigo
        Bodega_Codigo = value.Bodega_Codigo
      Catch ex As Exception
        Throw New Exception("No Existe Bodega/Empresa Relacionada")
      End Try
      
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Bodega", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 90, True)> _
  Public ReadOnly Property BodegaString() As String
    Get
      If Bodega Is Nothing Then
        Return String.Empty
      Else
        Return mBodega.NombreCompleto
      End If
    End Get
  End Property

  'Bodega
  Public Overridable Overloads Property BodegaDsno() As Bodega
    Get
      If Me.mBodegaDsno Is Nothing AndAlso Bodega_Bodegadestino > 0 Then
        Me.mBodegaDsno = New Bodega(New Sucursal(New Empresa(OperadorDatos, Me.Empres_Bodega), Me.Sucurs_Bodegadestino), Me.Bodega_Bodegadestino)
      End If
      Return Me.mBodegaDsno
    End Get
    Set(ByVal value As Bodega)
      Me.mBodegaDsno = value
      If value Is Nothing Then
        Sucurs_Bodegadestino = 0
        Bodega_Bodegadestino = 0
      Else
        Empres_Bodega = value.Empres_Codigo
        Sucurs_Bodegadestino = value.Sucurs_Codigo
        Bodega_Bodegadestino = value.Bodega_Codigo
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Bodega Destino", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 90, True)> _
  Public ReadOnly Property BodegaDsnoString() As String
    Get
      If BodegaDsno Is Nothing Then
        Return String.Empty
      Else
        Return mBodegaDsno.NombreCompleto
      End If
    End Get
  End Property

  'RegistroContable
  Public Overridable Property RegistroContable() As RegistroContable
    Get
      If Me.mRegistroContable Is Nothing AndAlso Not RegCtb_Secuencia = 0 Then
        Me.mRegistroContable = New RegistroContable(OperadorDatos, Me.RegCtb_Secuencia)
      End If
      Return Me.mRegistroContable
    End Get
    Set(ByVal value As RegistroContable)
      Me.mRegistroContable = value
      If value Is Nothing Then
        Throw New exception("Debe ingresar un registro contable")
      End If
      RegCtb_Secuencia = Me.mRegistroContable.RegCtb_Secuencia
    End Set
  End Property

  'Cuentacontable
  Public Overridable Property CuentaContable() As CuentaContable
    Get
      If mCuentacontable Is Nothing AndAlso Not CtaCtb_Codigo = String.Empty Then
        mCuentacontable = New CuentaContable(OperadorDatos, Me.CtaCtb_Codigo)
      End If
      Return Me.mCuentacontable
    End Get
    Set(ByVal value As CuentaContable)
      Me.mCuentacontable = value
      If value Is Nothing Then
        Me.CtaCtb_Codigo = String.Empty
      Else
        Me.CtaCtb_Codigo = value.CtaCtb_Codigo
      End If
    End Set
  End Property

  Public ReadOnly Property CuentaContableString() As String
    Get
      If CuentaContable Is Nothing Then
        Return String.Empty
      Else
        Return String.Format("{0} {1}", CtaCtb_Codigo, CuentaContable.CtaCtb_Descripcion)
      End If
    End Get
  End Property

  'Subcuentacontable
  Public Overridable Property SubCuentaContable() As WWTSParametroDet
    Get
      If mSubcuentacontable Is Nothing AndAlso Pardet_SubCuenta > 0 Then
        mSubcuentacontable = New WWTSParametroDet(OperadorDatos, Me.Parame_SubCuenta, Me.Pardet_SubCuenta)
      End If
      Return Me.mSubcuentacontable
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mSubcuentacontable = value
      If value Is Nothing Then
        Me.Pardet_SubCuenta = 0
      Else
        Me.Parame_SubCuenta = value.Parame_Codigo
        Me.Pardet_SubCuenta = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public Overridable ReadOnly Property SubCuentaContableString() As String
    Get
      If SubCuentaContable Is Nothing Then
        Return String.Empty
      Else
        Return mSubcuentacontable.Pardet_Descripcion
      End If
    End Get
  End Property

  'Item
  Public Overridable Property Item() As Item
    Get
      If Me.mItem Is Nothing AndAlso Item_Codigo > 0 Then
        Me.mItem = New Item(OperadorDatos, Item_Codigo)
      End If
      Return mItem
    End Get
    Set(ByVal value As Item)
      Me.mItem = value
      If value Is Nothing Then
        Item_Codigo = 0
      Else
        Item_Codigo = value.Item_Codigo
      End If
    End Set
  End Property

  Private mNovedad_Secuencia As Integer = 0
  Public Property Novedad_Secuencia() As Integer
    Get
      Return mNovedad_Secuencia
    End Get
    Set(ByVal value As Integer)
      mNovedad_Secuencia = value
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Activo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 90, True)> _
  Public ReadOnly Property ActivoString() As String
    Get
      If Item Is Nothing Then
        Return String.Empty
      Else
        Return mItem.Item_Descripcion
      End If
    End Get
  End Property


  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_Tipomovinv = CType(Fila("Parame_Tipomovinv"), Integer)
    Pardet_Tipomovinv = CType(Fila("Pardet_Tipomovinv"), Integer)
    Empres_Bodega = CType(Fila("Empres_Bodega"), Integer)
    Sucurs_Bodega = CType(Fila("Sucurs_Bodega"), Integer)
    Movinv_Secuencia = CType(Fila("Movinv_Secuencia"), Integer)
    Bodega_Codigo = CType(Fila("Bodega_Codigo"), Integer)
    Movinv_autorizado = CBool(Fila("Movinv_autorizado"))

    Dim obj As Object
    obj = Fila("Sucurs_Bodegadestino")
    If TypeOf obj Is DBNull Then
      Sucurs_Bodegadestino = 0
      Bodega_Bodegadestino = 0
    Else
      Sucurs_Bodegadestino = CType(Fila("Sucurs_Bodegadestino"), Integer)
      obj = Fila("Bodega_Bodegadestino")
      If TypeOf obj Is DBNull Then
        Sucurs_Bodegadestino = 0
        Bodega_Bodegadestino = 0
      Else
        Bodega_Bodegadestino = CType(Fila("Bodega_Bodegadestino"), Integer)
      End If
    End If
    Movinv_Fecha = CType(Fila("Movinv_Fecha"), Date)
    Movinv_Observaciones = CType(Fila("Movinv_Observaciones"), String)
    Movinv_porcIVA = CType(Fila("Movinv_porcIVA"), Decimal)
    Movinv_Descto = CType(Fila("Movinv_Descto"), Decimal)
    SRI_iva = CType(Fila("SRI_iva"), Integer)
    Movinv_esAnulada = CType(Fila("Movinv_esAnulada"), Boolean)
    Try
      RegCtb_Secuencia = CInt(Fila("RegCtb_Secuencia"))
    Catch ex As Exception
      RegCtb_Secuencia = 0
    End Try
    Try
      mCtaCtb_Codigo = CStr(Fila("CtaCtb_Codigo"))
    Catch ex As Exception
      mCtaCtb_Codigo = String.Empty
    End Try
    Try
      mParame_SubCuenta = CInt(Fila("Parame_SubCuenta"))
      mPardet_SubCuenta = CInt(Fila("Pardet_SubCuenta"))
    Catch ex As Exception
      mParame_SubCuenta = 0
      mPardet_SubCuenta = 0
    End Try

    If TypeOf Fila("Item_Codigo") Is DBNull Then
      mItem_Codigo = 0
    Else
      mItem_Codigo = CInt(Fila("Item_Codigo"))
    End If

    If TypeOf Fila("Slot_Secuencia") Is DBNull Then
      Slot_Secuencia = 0
    Else
      Slot_Secuencia = CInt(Fila("Slot_Secuencia"))
    End If

    mItem = Nothing
    mTipomovimientoinventario = Nothing
    mPardetTipoMovInv = Nothing
    mBodega = Nothing
    mBodegaDsno = Nothing
    mDetalles = Nothing
    mRegistroContable = Nothing
    mCuentacontable = Nothing
    mSubcuentacontable = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
    OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_Tipomovinv)
    OperadorDatos.AgregarParametro("@Empres_Bodega", Empres_Bodega)
    OperadorDatos.AgregarParametro("@Sucurs_Bodega", Sucurs_Bodega)
    OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)
    OperadorDatos.AgregarParametro("@Slot_Secuencia", Slot_Secuencia)

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

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
    OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_Tipomovinv)
    OperadorDatos.AgregarParametro("@Empres_Bodega", Empres_Bodega)
    OperadorDatos.AgregarParametro("@Sucurs_Bodega", Sucurs_Bodega)
    OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)
    OperadorDatos.AgregarParametro("@Bodega_Codigo", Bodega_Codigo)
    If Pardet_Tipomovinv = Enumerados.enumTipoMovInv.Transferencia Then
      OperadorDatos.AgregarParametro("@Sucurs_Bodegadestino", Sucurs_Bodegadestino)
      OperadorDatos.AgregarParametro("@Bodega_Bodegadestino", Bodega_Bodegadestino)
    End If
    OperadorDatos.AgregarParametro("@Movinv_Fecha", Movinv_Fecha)
    OperadorDatos.AgregarParametro("@Movinv_Observaciones", Movinv_Observaciones)
    OperadorDatos.AgregarParametro("@SRI_iva", SRI_iva)
    OperadorDatos.AgregarParametro("@Movinv_porcIVA", Movinv_porcIVA)
    OperadorDatos.AgregarParametro("@Movinv_Descto", Movinv_Descto)
    OperadorDatos.AgregarParametro("@Movinv_esAnulada", Movinv_esAnulada)
    OperadorDatos.AgregarParametro("@Movinv_autorizado", Movinv_autorizado)
    If Item_Codigo > 0 Then
      OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
    End If

    If RegCtb_Secuencia > 0 Then
      OperadorDatos.AgregarParametro("@RegCtb_Secuencia", RegCtb_Secuencia)
    End If
    If Not CtaCtb_Codigo = String.Empty Then
      OperadorDatos.AgregarParametro("@CtaCtb_Codigo", CtaCtb_Codigo)
    End If
    If Parame_SubCuenta > 0 Then
      OperadorDatos.AgregarParametro("@Parame_SubCuenta", Parame_SubCuenta)
      OperadorDatos.AgregarParametro("@Pardet_SubCuenta", Pardet_SubCuenta)
    End If
    If Pardet_Tipomovinv = Enumerados.enumTipoMovInv.EnsambleSlot Or Pardet_Tipomovinv = Enumerados.enumTipoMovInv.DesensambleSlot Then
      OperadorDatos.AgregarParametro("@Slot_Secuencia", Slot_Secuencia)
    End If
    
    OperadorDatos.Procedimiento = _Procedimiento

    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Movinv_Secuencia = Result
      End If

      'If Detalles.Count = 1 And Detalles(0).Item_Codigo = 0 Then
      '  OperadorDatos.CancelarTransaccion()
      '  Throw New Exception("Debe Agregar al Menos Un Detalle Para Continuar")
      '  Return False
      'End If

      'guardar detalles 
      For Each _detalle As MovimientoInventarioDet In Detalles
        _detalle.MovimientoInventario = Me
        _detalle.EsNuevo = True

        If _detalle.Item Is Nothing Then

          'If Not _detalle.Item.Item_esRegistroSerie Then
          _detalle.DetallesSeries.Clear()
          'End If

        End If

        If Not _detalle.Item_Codigo = 0 And Not _detalle.Moinde_Cantidad = 0 Then

          If Not _detalle.Item.Item_esRegistroSerie Then

            _detalle.DetallesSeries.Clear()

          End If

          If _detalle.Item.Item_esRegistroSerie And _detalle.DetallesSeries.Count = 0 Then
            Throw New Exception("Debe Agregar al Menos Un Detalle Para Continuar, Item" + _detalle.Item.Item_Descripcion)
            bReturn = False
            Exit For
          End If

          If Not _detalle.Guardar() Then
            bReturn = False
            Exit For
          End If
          'Else
          '  Throw New Exception("Debe Agregar al Menos Un Detalle Para Continuar, Item" + _detalle.Item.Item_Descripcion)
          '  bReturn = False
          '  Exit For
        End If
      Next

      If Not OperadorDatos.EstaenTransaccion Then
        EsNuevo = False
        EsModificado = False
      End If
    End If

    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambios()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Function GuardarPagos() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    'guardar pagos
    For Each _pago As PagosDet In Pagos
      _pago.MovimientoInventario = Me
      If Not _pago.Pagdet_Valor = 0 Then
        If Not _pago.Guardar() Then
          bReturn = False
          Exit For
        End If
      End If
    Next

    For Each _pago As PagosDet In PagosEliminados
      _pago.MovimientoInventario = Me
      If Not _pago.Eliminar Then
        bReturn = False
        Exit For
      End If
    Next

    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambiosPagos()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Function AceptarCambios() As Boolean
    EsNuevo = False
    EsModificado = False

    For Each _detalle As MovimientoInventarioDet In Detalles
      _detalle.AceptarCambios()
    Next
    Return True
  End Function

  Public Overridable Function AceptarCambiosPagos() As Boolean
    'guardar pagos
    For Each _pago As PagosDet In Pagos
      _pago.AceptarCambios()
    Next
    Return True
  End Function

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If

    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
    OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_Tipomovinv)
    OperadorDatos.AgregarParametro("@Empres_Bodega", Empres_Bodega)
    OperadorDatos.AgregarParametro("@Sucurs_Bodega", Sucurs_Bodega)
    OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "MovimientoInventarioList"
Public Class MovimientoInventarioList
  Inherits System.ComponentModel.BindingList(Of MovimientoInventario)

  Public Shared Function ObtenerLista(ByVal _Sucursal As Sucursal, ByVal _porfecha As Boolean, ByVal _Desde As DateTime, ByVal _Hasta As DateTime, Optional ByVal _PardetTipoMovInv As WWTSParametroDet = Nothing, Optional ByVal _PardetTipoCompraVenta As WWTSParametroDet = Nothing, Optional ByVal _SoloPendientes As Boolean = False, Optional ByVal _filtro As String = "") As MovimientoInventarioList
    Dim oResult As MovimientoInventarioList = New MovimientoInventarioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Sucursal.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Empres_Bodega", _Sucursal.Empres_Codigo)
      .AgregarParametro("@Sucurs_Bodega", _Sucursal.Sucurs_Codigo)
      If _porfecha Then
        .AgregarParametro("@fecdesde", _Desde.Date)
        .AgregarParametro("@fechasta", _Hasta.Date)
      End If
      If _PardetTipoMovInv IsNot Nothing Then
        .AgregarParametro("@Parame_Tipomovinv", _PardetTipoMovInv.Parame_Codigo)
        .AgregarParametro("@Pardet_Tipomovinv", _PardetTipoMovInv.Pardet_Secuencia)
        Dim _tipomovinv As Enumerados.enumTipoMovInv = CType(_PardetTipoMovInv.Pardet_Secuencia, Enumerados.enumTipoMovInv)
        Select Case _tipomovinv
          Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.Venta
          Case Else
            _SoloPendientes = False
        End Select
      Else
        _SoloPendientes = False
      End If
      If _PardetTipoCompraVenta IsNot Nothing Then
        .AgregarParametro("@Parame_Tipocompraventa", _PardetTipoCompraVenta.Parame_Codigo)
        .AgregarParametro("@Pardet_Tipocompraventa", _PardetTipoCompraVenta.Pardet_Secuencia)
      End If

      .AgregarParametro("@SoloPendientes", _SoloPendientes)
      If Not _filtro = String.Empty Then
        .AgregarParametro("@filtro", _filtro)
      End If
      .Procedimiento = "proc_MovimientoInventario"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New MovimientoInventario(_Sucursal, Enumerados.enumTipoMovInv.InvInicial, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
