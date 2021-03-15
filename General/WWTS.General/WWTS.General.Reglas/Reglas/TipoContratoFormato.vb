
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas.Enumerados

#Region "TipoContratoFormato"
Public Class TipoContratoFormato

  Const _Procedimiento As String = "proc_TipoContratoFormato"

  Private mPardetFormato As WWTSParametroDet = Nothing

  Private mTipocontrato As TipoContrato = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _TipCon_Codigo As Integer, ByVal _Patron_Codigo As Integer, ByVal _Parame_Formato As Integer, ByVal _Pardet_Formato As Integer)
    Me.New(_OperadorDatos, False)
    TipCon_Codigo = _TipCon_Codigo
    Patron_Codigo = _Patron_Codigo
    Parame_Formato = _Parame_Formato
    Pardet_Formato = _Pardet_Formato
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto TipoContrato")
    End If
  End Sub

  Public Property PardetFormato() As WWTSParametroDet
    Get
      If mPardetFormato Is Nothing AndAlso Pardet_Formato <> 0 Then
        mPardetFormato = New WWTSParametroDet(OperadorDatos, Me.Parame_Formato, Me.Pardet_Formato)
      End If
      Return mPardetFormato
    End Get
    Set(ByVal value As WWTSParametroDet)
      mPardetFormato = value
      Parame_Formato = value.Parame_Codigo
      Pardet_Formato = value.Pardet_Secuencia
    End Set
  End Property

  'Tipocontrato
  Public Overridable Property Tipocontrato() As TipoContrato
    Get
      If Me.mTipocontrato Is Nothing AndAlso TipCon_Codigo > 0 Then
        Me.mTipocontrato = New TipoContrato(OperadorDatos, Patron_Codigo, TipCon_Codigo)
      End If
      Return Me.mTipocontrato
    End Get
    Set(ByVal value As TipoContrato)
      Me.mTipocontrato = value
      Patron_Codigo = value.Patron_Codigo
      TipCon_Codigo = value.TipCon_Codigo
    End Set
  End Property

  Public ReadOnly Property PardetFormatoString() As String
    Get
      If PardetFormato Is Nothing Then
        Return String.Empty
      Else
        Return PardetFormato.Pardet_Descripcion
      End If
    End Get
  End Property


  Public Shared Function ObtenerFormato(ByVal _TipoContrato As TipoContrato, ByVal _enumFormatoxTipoContrato As enumFormatoxTipoContrato) As String
    Dim oResult As String = String.Empty
    Try
      Dim _fila As New TipoContratoFormato(_TipoContrato.OperadorDatos, _TipoContrato.TipCon_Codigo, _TipoContrato.Patron_Codigo, EnumParametros.TipoContratoFormato, _enumFormatoxTipoContrato)
      oResult = _fila.TiCoFo_Archivo
    Catch ex As Exception
    End Try
    Return oResult
  End Function

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    TipCon_Codigo = CType(Fila("TipCon_Codigo"), Integer)
    Parame_Formato = CType(Fila("Parame_Formato"), Integer)
    Pardet_Formato = CType(Fila("Pardet_Formato"), Integer)
    TiCoFo_Archivo = CType(Fila("TiCoFo_Archivo"), String)

    mPardetFormato = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.DataTable = New System.Data.DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@TipCon_Codigo", TipCon_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Formato", Parame_Formato)
    OperadorDatos.AgregarParametro("@Pardet_Formato", Pardet_Formato)
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
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@TipCon_Codigo", TipCon_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Formato", Parame_Formato)
    OperadorDatos.AgregarParametro("@Pardet_Formato", Pardet_Formato)
    OperadorDatos.AgregarParametro("@TiCoFo_Archivo", TiCoFo_Archivo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        TipCon_Codigo = Result
      End If
      EsNuevo = False
      EsModificado = False
    End If
    Return bReturn
  End Function

  Public Overridable Function AceptarCambios() As Boolean
    EsNuevo = False
    EsModificado = False

    Return True
  End Function

  Public Overridable Function Eliminar() As Boolean
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@TipCon_Codigo", TipCon_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Formato", Parame_Formato)
    OperadorDatos.AgregarParametro("@Pardet_Formato", Pardet_Formato)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "TipoContratoFormatoList"
Public Class TipoContratoFormatoList
  Inherits System.ComponentModel.BindingList(Of TipoContratoFormato)
  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _Patron_Codigo As Integer, ByVal _TipCon_Codigo As Integer, Optional ByVal _filtro As String = "") As TipoContratoFormatoList
    Dim oResult As TipoContratoFormatoList = New TipoContratoFormatoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Patron_Codigo", _Patron_Codigo)
      .AgregarParametro("@TipCon_Codigo", _TipCon_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_TipoContratoFormato"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New TipoContratoFormato(_OperadorDatos, False)
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
