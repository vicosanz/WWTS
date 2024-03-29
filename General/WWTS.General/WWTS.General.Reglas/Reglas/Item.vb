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
Imports System.IO
Imports System.ComponentModel
Imports System.Xml.Serialization

#Region "Item"
Public Class Item

  Const _Procedimiento As String = "proc_Item"

  Private mPardetGrupo As WWTSParametroDet = Nothing

  Private mPardetMarca As WWTSParametroDet = Nothing

  Private mPardetMedida As WWTSParametroDet = Nothing

  Private mPardetTipoInventario As WWTSParametroDet = Nothing

  Private mPardetUnidadMedida As WWTSParametroDet = Nothing

  Private mItem_Imagen As System.Drawing.Image = Nothing

  Private mProveedor As Proveedor = Nothing

  Private mCambio_Imagen As Boolean = False


  Private mComponente As Componente
  Public Property Componente() As Componente
    Get
      If Me.Item_Codigo <> 0 Then
        Return New Componente(Me.OperadorDatos, False, Me.Item_Codigo)
      Else
        Return New Componente()
      End If
    End Get
    Set(ByVal value As Componente)
      mComponente = value
    End Set
  End Property



  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Item_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Item_Codigo = _Item_Codigo
    If Not Me.Recargar Then
      Throw New Exception(OperadorDatos.MsgError)
    End If
  End Sub

  'WWTSParametroDet
  Public Overridable Property PardetGrupo() As WWTSParametroDet
    Get
      If Me.mPardetGrupo Is Nothing AndAlso Pardet_Grupo > 0 Then
        Me.mPardetGrupo = New WWTSParametroDet(OperadorDatos, Parame_Grupo, Pardet_Grupo)
      End If
      Return Me.mPardetGrupo
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetGrupo = value
      Parame_Grupo = value.Parame_Codigo
      Pardet_Grupo = value.Pardet_Secuencia
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetMarca() As WWTSParametroDet
    Get
      If Me.mPardetMarca Is Nothing AndAlso Pardet_Marca > 0 Then
        Me.mPardetMarca = New WWTSParametroDet(OperadorDatos, Parame_Marca, Pardet_Marca)
      End If
      Return Me.mPardetMarca
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetMarca = value
      If value Is Nothing Then
        Throw New Exception("Debe seleccionar una marca")
      End If
      Parame_Marca = value.Parame_Codigo
      Pardet_Marca = value.Pardet_Secuencia
    End Set
  End Property

  'Proveedor
  Public Overridable Property Proveedor() As Proveedor
    Get
      If Me.mProveedor Is Nothing AndAlso Entida_Proveedor > 0 Then
        Me.mProveedor = New Proveedor(OperadorDatos, Entida_Proveedor)
      End If
      Return Me.mProveedor
    End Get
    Set(ByVal value As Proveedor)
      Me.mProveedor = value
      If value Is Nothing Then
        Entida_Proveedor = 0
      Else
        Entida_Proveedor = value.Entida_Codigo
      End If
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoInventario() As WWTSParametroDet
    Get
      If Me.mPardetTipoInventario Is Nothing AndAlso Pardet_Tipoinventario > 0 Then
        Me.mPardetTipoInventario = New WWTSParametroDet(OperadorDatos, Parame_Tipoinventario, Pardet_Tipoinventario)
      End If
      Return Me.mPardetTipoInventario
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoInventario = value
      Parame_Tipoinventario = value.Parame_Codigo
      Pardet_Tipoinventario = value.Pardet_Secuencia
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetUnidadMedida() As WWTSParametroDet
    Get
      If Me.mPardetUnidadMedida Is Nothing AndAlso Pardet_Unidadmedida > 0 Then
        Me.mPardetUnidadMedida = New WWTSParametroDet(OperadorDatos, Parame_Unidadmedida, Pardet_Unidadmedida)
      End If
      Return Me.mPardetUnidadMedida
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetUnidadMedida = value
      Parame_Unidadmedida = value.Parame_Codigo
      Pardet_Unidadmedida = value.Pardet_Secuencia
    End Set
  End Property

  'Item_Imagen
  Public Overridable ReadOnly Property Item_ImagenStream() As Byte()
    Get
      Dim imagen() As Byte
      Dim Result As Object = Nothing
      Dim bReturn As Boolean = True
      OperadorDatos.AgregarParametro("@accion", "Pl")
      OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
      OperadorDatos.Procedimiento = _Procedimiento
      bReturn = OperadorDatos.Ejecutar(Result)
      OperadorDatos.LimpiarParametros()
      Try
        imagen = CType(Result, Byte())
      Catch ex As System.Exception
        imagen = Nothing
      End Try
      Return imagen
    End Get
  End Property

  'Item_Imagen
  Public Overridable ReadOnly Property Item_Imagen(Optional ByVal heightwidth As Integer = 0) As System.Drawing.Image
    Get
      If mItem_Imagen Is Nothing Then
        Try
          Dim imagen() As Byte
          imagen = Item_ImagenStream
          Dim ms As New MemoryStream
          ms.Write(imagen, 0, imagen.GetUpperBound(0) + 1)
          mItem_Imagen = System.Drawing.Image.FromStream(ms)
          ms.Close()
        Catch ex As System.Exception
          mItem_Imagen = Nothing
        End Try
      End If
      If heightwidth > 0 AndAlso mItem_Imagen IsNot Nothing Then
        Dim imagenbm = New System.Drawing.Bitmap(mItem_Imagen)
        Return imagenbm.GetThumbnailImage(heightwidth, heightwidth, Nothing, New IntPtr())
      Else
        Return mItem_Imagen
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

  ' <XmlAttribute()> _
  '<Infoware.Reportes.CampoReporteAtributo("C�digo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 50, True)> _
  Public Overridable Property Item_Codigo() As Integer
    Get
      Return Me.mItem_Codigo
      'Return Me.mItem_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mItem_Codigo = value
      EsModificado = True
    End Set
  End Property


  <XmlAttribute()> _
<Infoware.Reportes.CampoReporteAtributo("C�digo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public Overridable Property Item_CodigoAuxiliarString() As String
    Get
      Return Me.mItem_CodigoAuxiliar
      'Return Me.mItem_Codigo
    End Get
    Set(ByVal value As String)
      Me.mItem_CodigoAuxiliar = value
      EsModificado = True
    End Set
  End Property



  <XmlAttribute()> _
  <Infoware.Reportes.CampoReporteAtributo("Descripci�n", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 170, True)> _
  Public Overridable Property Item_Descripcion() As String
    Get
      Return Me.mItem_Descripcion
    End Get
    Set(ByVal value As String)
      Me.mItem_Descripcion = value
      EsModificado = True
    End Set
  End Property

  '<XmlAttribute()> _
  '<Infoware.Reportes.CampoReporteAtributo("Descripci�n", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 170, True)> _
  Public ReadOnly Property DescripcionVisible() As String
    Get
      Return String.Format("{0} - {1} - {2} - {3}", Me.Item_CodigoAuxiliar, Me.GrupoString, Me.MarcaString, Me.Item_Descripcion)
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo Componente", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 220, True)> _
  Public ReadOnly Property TipoComponenteString() As String
    Get
      If Componente.ParameTipoComponente IsNot Nothing Then
        Return Me.Componente.ParameTipoComponente.Pardet_Descripcion
      Else
        Return ""
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Grupo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 220, True)>
  Public ReadOnly Property GrupoString() As String
    Get
      If PardetGrupo Is Nothing Then
        Return String.Empty
      ElseIf PardetGrupo.PardetPadre Is Nothing Then
        Return mPardetGrupo.Pardet_Descripcion
      Else
        Return String.Format("{0} - {1}", mPardetGrupo.PardetPadre.Pardet_Descripcion, mPardetGrupo.Pardet_Descripcion)
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("GrupoSin_", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 220, True)>
  Public ReadOnly Property GrupoSin_String() As String
    Get
      If PardetGrupo Is Nothing Then
        Return String.Empty
      ElseIf PardetGrupo.PardetPadre Is Nothing Then
        Return mPardetGrupo.Pardet_Descripcion
      Else
        Return String.Format("{0} {1}", mPardetGrupo.PardetPadre.Pardet_Descripcion, mPardetGrupo.Pardet_Descripcion)
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Marca", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 130, True)>
  Public ReadOnly Property MarcaString() As String
    Get
      If PardetMarca Is Nothing Then
        Return String.Empty
      Else
        Return mPardetMarca.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Serie", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 50, True)> _
  Public ReadOnly Property SerieString() As String
    Get
      If Me.Item_esRegistroSerie Then
        Return "Si"
      Else
        Return "No"
      End If
    End Get
  End Property

  Public ReadOnly Property TipoInventarioString() As String
    Get
      If PardetTipoInventario Is Nothing Then
        Return String.Empty
      Else
        Return mPardetTipoInventario.Pardet_Descripcion
      End If
    End Get
  End Property

  Public ReadOnly Property UnidadMedidaString() As String
    Get
      If PardetUnidadMedida Is Nothing Then
        Return String.Empty
      Else
        Return mPardetUnidadMedida.Pardet_Descripcion
      End If
    End Get
  End Property

  Public ReadOnly Property BuscarValor(ByVal _tipomovinv As Enumerados.enumTipoMovInv, ByVal _sucursal As Sucursal, ByVal _PardetTipoPrecio As WWTSParametroDet, ByVal _porciva As Decimal, ByVal _bodega As Bodega) As Decimal
    Get
      Dim _valor As Decimal = 0
      Select Case _tipomovinv
        Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
          Dim _ItemxTipoPrecio As ItemxTipoPrecio
          Try
            _ItemxTipoPrecio = New ItemxTipoPrecio(Me, _sucursal, _PardetTipoPrecio)
            _valor = _ItemxTipoPrecio.IteTip_Valor
            If Item_esIvaIncluido Then
              _valor = _valor / (1 + _porciva / 100)
            End If
          Catch ex As Exception
            _valor = 0
          End Try
        Case Else
          Try
            Dim _itemxbodega As New ItemxBodega(Me, _bodega)
            _valor = _itemxbodega.Itebod_Costopromedio
          Catch ex As Exception
            _valor = 0
          End Try
      End Select
      Return _valor
    End Get
  End Property

  'Private mItemxTipoPrecios As ItemxTipoPrecioList = Nothing
  Public ReadOnly Property ItemxTipoPrecios(ByVal _Sucursal As Sucursal) As ItemxTipoPrecioList
    Get
      'If mItemxTipoPrecios Is Nothing Then
      '  mItemxTipoPrecios = ItemxTipoPrecioList.ObtenerLista(Me, mSucursal)
      'End If
      'Return mItemxTipoPrecios
      If _Sucursal Is Nothing Then
        Return Nothing
      End If
      Return ItemxTipoPrecioList.ObtenerLista(Me, _Sucursal)
    End Get
  End Property

  'Private mItemxBodegas As ItemxBodegaList = Nothing
  Public ReadOnly Property ItemxBodegas(Optional ByVal _Sucursal As Sucursal = Nothing) As ItemxBodegaList
    Get
      'If mItemxBodegas Is Nothing Then
      '  mItemxBodegas = ItemxBodegaList.ObtenerLista(Me)
      'End If
      'Return mItemxBodegas
      If _Sucursal Is Nothing Then
        Return Nothing
      End If
      Return ItemxBodegaList.ObtenerLista(Me, _Sucursal)
    End Get
  End Property

#Region "Saldos bodega"
  Private mBodegas As BodegaList = Nothing
  Public ReadOnly Property Bodegas() As BodegaList
    Get
      If mBodegas Is Nothing Then
        mBodegas = BodegaList.ObtenerLista(OperadorDatos)
      End If
      Return mBodegas
    End Get
  End Property

  Public ReadOnly Property SaldoBodega(ByVal _Bodega As Bodega) As Decimal
    Get
      If Me.Item_Estangible Then
        Try
          Dim _ItemxBodega As New ItemxBodega(Me, _Bodega)
          Return _ItemxBodega.Itebod_Cantidad
        Catch ex As Exception
        End Try
      End If
      Return 0
    End Get
  End Property

  Public ReadOnly Property SaldoBodega(ByVal _NumBodega As Integer) As Decimal
    Get
      If Bodegas.Count >= _NumBodega Then
        Return SaldoBodega(mBodegas(_NumBodega))
      Else
        Return 0
      End If
    End Get
  End Property

  Public ReadOnly Property SaldoBodega1() As Decimal
    Get
      Return SaldoBodega(0)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega2() As Decimal
    Get
      Return SaldoBodega(1)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega3() As Decimal
    Get
      Return SaldoBodega(2)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega4() As Decimal
    Get
      Return SaldoBodega(3)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega5() As Decimal
    Get
      Return SaldoBodega(4)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega6() As Decimal
    Get
      Return SaldoBodega(5)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega7() As Decimal
    Get
      Return SaldoBodega(6)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega8() As Decimal
    Get
      Return SaldoBodega(7)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega9() As Decimal
    Get
      Return SaldoBodega(8)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega10() As Decimal
    Get
      Return SaldoBodega(9)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega11() As Decimal
    Get
      Return SaldoBodega(10)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega12() As Decimal
    Get
      Return SaldoBodega(11)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega13() As Decimal
    Get
      Return SaldoBodega(12)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega14() As Decimal
    Get
      Return SaldoBodega(13)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega15() As Decimal
    Get
      Return SaldoBodega(14)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega16() As Decimal
    Get
      Return SaldoBodega(15)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega17() As Decimal
    Get
      Return SaldoBodega(16)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega18() As Decimal
    Get
      Return SaldoBodega(17)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega19() As Decimal
    Get
      Return SaldoBodega(18)
    End Get
  End Property

  Public ReadOnly Property SaldoBodega20() As Decimal
    Get
      Return SaldoBodega(19)
    End Get
  End Property

 

#End Region

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Item_Codigo = CType(Fila("Item_Codigo"), Integer)
    Parame_Grupo = CType(Fila("Parame_Grupo"), Integer)
    Pardet_Grupo = CType(Fila("Pardet_Grupo"), Integer)
    Parame_Marca = CType(Fila("Parame_Marca"), Integer)
    Pardet_Marca = CType(Fila("Pardet_Marca"), Integer)
    Parame_Tipoinventario = CType(Fila("Parame_Tipoinventario"), Integer)
    Pardet_Tipoinventario = CType(Fila("Pardet_Tipoinventario"), Integer)
    Item_Aplicaiva = CType(Fila("Item_Aplicaiva"), Boolean)
    Item_Estangible = CType(Fila("Item_Estangible"), Boolean)
    Item_Descripcion = CType(Fila("Item_Descripcion"), String)
    Item_Ubicacion = CType(Fila("Item_Ubicacion"), String)
    Parame_Unidadmedida = CType(Fila("Parame_Unidadmedida"), Integer)
    Pardet_Unidadmedida = CType(Fila("Pardet_Unidadmedida"), Integer)
    Item_CodigoAuxiliar = CType(Fila("Item_CodigoAuxiliar"), String)
    Item_CodigoProveedor = CType(Fila("Item_CodigoProveedor"), String)
    Item_esIvaIncluido = CType(Fila("Item_esIvaIncluido"), Boolean)
    Item_esRegistroSerie = CType(Fila("Item_esRegistroSerie"), Boolean)
    Item_Largo = CType(Fila("Item_Largo"), Decimal)
    Item_Altura = CType(Fila("Item_Altura"), Decimal)
    Item_Ancho = CType(Fila("Item_Ancho"), Decimal)
    If Not TypeOf Fila("Entida_Proveedor") Is dbnull Then
      Entida_Proveedor = CInt(Fila("Entida_Proveedor"))
    Else
      Entida_Proveedor = 0
    End If
    mPardetGrupo = Nothing
    mPardetMarca = Nothing
    mPardetTipoInventario = Nothing
    mPardetUnidadMedida = Nothing
    'mItemxTipoPrecios = Nothing
    'mItemxBodegas = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
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
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Grupo", Parame_Grupo)
    OperadorDatos.AgregarParametro("@Pardet_Grupo", Pardet_Grupo)
    OperadorDatos.AgregarParametro("@Parame_Marca", Parame_Marca)
    OperadorDatos.AgregarParametro("@Pardet_Marca", Pardet_Marca)
    OperadorDatos.AgregarParametro("@Parame_Tipoinventario", Parame_Tipoinventario)
    OperadorDatos.AgregarParametro("@Pardet_Tipoinventario", Pardet_Tipoinventario)
    OperadorDatos.AgregarParametro("@Item_Aplicaiva", Item_Aplicaiva)
    OperadorDatos.AgregarParametro("@Item_Estangible", Item_Estangible)
    OperadorDatos.AgregarParametro("@Item_Descripcion", Item_Descripcion)
    OperadorDatos.AgregarParametro("@Item_Ubicacion", Item_Ubicacion)
    OperadorDatos.AgregarParametro("@Parame_Unidadmedida", Parame_Unidadmedida)
    OperadorDatos.AgregarParametro("@Pardet_Unidadmedida", Pardet_Unidadmedida)
    OperadorDatos.AgregarParametro("@Item_CodigoAuxiliar", Item_CodigoAuxiliar)
    OperadorDatos.AgregarParametro("@Item_CodigoProveedor", Item_CodigoProveedor)
    OperadorDatos.AgregarParametro("@Item_esIvaIncluido", Item_esIvaIncluido)
    OperadorDatos.AgregarParametro("@Item_esRegistroSerie", Item_esRegistroSerie)
    OperadorDatos.AgregarParametro("@Item_Largo", Item_Largo)
    OperadorDatos.AgregarParametro("@Item_Altura", Item_Altura)
    OperadorDatos.AgregarParametro("@Item_Ancho", Item_Ancho)

    If Entida_Proveedor > 0 Then
      OperadorDatos.AgregarParametro("@Entida_Proveedor", Entida_Proveedor)
    End If
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Item_Codigo = Result
      End If
      EsNuevo = False
      EsModificado = False

      If mCambio_Imagen Then
        Guardar_Imagen()
      End If
    End If
    Return bReturn
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
    OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
    OperadorDatos.AgregarParametroImagen("@Item_Imagen", mArchivoImagen)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar()
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      mItem_Imagen = Nothing
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
    OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "ItemList"
Public Class ItemList
  Inherits BindingList(Of Item)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _grupo As WWTSParametroDet = Nothing, Optional ByVal _tipoinventario As WWTSParametroDet = Nothing, Optional ByVal _filtro As String = "") As ItemList
    Dim oResult As ItemList = New ItemList
    Dim bReturn As Boolean
    Dim ds As New DataTable
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      If _grupo IsNot Nothing Then
        .AgregarParametro("@Parame_Grupo", _grupo.Parame_Codigo)
        .AgregarParametro("@Pardet_Grupo", _grupo.Pardet_Secuencia)
      End If
      If _tipoinventario IsNot Nothing Then
        .AgregarParametro("@Parame_TipoInventario", _tipoinventario.Parame_Codigo)
        .AgregarParametro("@Pardet_TipoInventario", _tipoinventario.Pardet_Secuencia)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Item"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Item(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerLista(ByVal _Sucursal As Sucursal, ByVal _pardetTipoPrecio As WWTSParametroDet, Optional ByVal _filtro As String = "") As ItemList
    Dim oResult As ItemList = New ItemList
    Dim bReturn As Boolean
    Dim ds As New DataTable
    With _Sucursal.OperadorDatos
      .AgregarParametro("@Accion", "FP")
      .AgregarParametro("@Parame_TipoPrecio", _pardetTipoPrecio.Parame_Codigo)
      .AgregarParametro("@Pardet_TipoPrecio", _pardetTipoPrecio.Pardet_Secuencia)
      .AgregarParametro("@Empres_Codigo", _Sucursal.Empres_Codigo)
      .AgregarParametro("@Sucurs_Codigo", _Sucursal.Sucurs_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Item"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Item(_Sucursal.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaxTipoInventario(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _tipoinventario As WWTSParametroDet = Nothing, Optional ByVal _filtro As String = "") As ItemList
    Dim oResult As ItemList = New ItemList
    Dim bReturn As Boolean
    Dim ds As New DataTable
    With _OperadorDatos
      .AgregarParametro("@Accion", "FT")
      If _tipoinventario IsNot Nothing Then
        .AgregarParametro("@Parame_Tipoinventario", _tipoinventario.Parame_Codigo)
        .AgregarParametro("@Pardet_Tipoinventario", _tipoinventario.Pardet_Secuencia)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Item"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Item(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaxTipoInventarioCompatible(ByVal _OperadorDatos As OperadorDatos, ByVal SlotSecuencia As Integer, ByVal ParameModelo As Integer, ByVal PardetModelo As Integer, Optional ByVal _tipoinventario As WWTSParametroDet = Nothing, Optional ByVal _filtro As String = "") As ItemList
    Dim oResult As ItemList = New ItemList
    Dim bReturn As Boolean
    Dim ds As New DataTable
    With _OperadorDatos
      .AgregarParametro("@Accion", "FTC")
      If _tipoinventario IsNot Nothing Then
        .AgregarParametro("@Parame_Tipoinventario", _tipoinventario.Parame_Codigo)
        .AgregarParametro("@Pardet_Tipoinventario", _tipoinventario.Pardet_Secuencia)
        .AgregarParametro("@Parame_Modelo", ParameModelo)
        .AgregarParametro("@Pardet_Modelo", PardetModelo)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Item"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Item(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaGruposxTipoInventario(ByVal _OperadorDatos As OperadorDatos, ByVal _tipoinventario As WWTSParametroDet, Optional ByVal _filtro As String = "") As WWTSParametroDetList
    Dim oResult As WWTSParametroDetList = New WWTSParametroDetList
    Dim bReturn As Boolean
    Dim ds As New DataTable
    With _OperadorDatos
      .AgregarParametro("@Accion", "LGT")
      If _tipoinventario IsNot Nothing Then
        .AgregarParametro("@Pardet_Tipoinventario", _tipoinventario.Pardet_Secuencia)
      End If
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Item"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New WWTSParametroDet(_OperadorDatos, Enumerados.EnumParametros.Grupo, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function


  Public Sub New()
  End Sub
End Class
#End Region
