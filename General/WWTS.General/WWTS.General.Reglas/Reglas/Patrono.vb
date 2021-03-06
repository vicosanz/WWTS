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

#Region "Patrono"
Public Class Patrono

  Const _Procedimiento As String = "proc_Patrono"

  Private mEntidadjuridica As EntidadJuridica = Nothing

  Private mParametrodet As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Patron_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Patron_Codigo = _Patron_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Patrono")
    End If
  End Sub

  'Entidadjuridica
  Public Overridable Property Entidadjuridica() As EntidadJuridica
    Get
      If Me.mEntidadjuridica Is Nothing AndAlso Entida_Patrono > 0 Then
        Me.mEntidadjuridica = New EntidadJuridica(OperadorDatos, Entida_Patrono)
      End If
      Return Me.mEntidadjuridica
    End Get
    Set(ByVal value As EntidadJuridica)
      If value IsNot Nothing Then
        Me.mEntidadjuridica = value
        Entida_Patrono = value.Entida_Codigo
      End If
    End Set
  End Property

  Public ReadOnly Property Pais() As WWTSParametroDet
    Get
      If Provincia Is Nothing Then
        Return Nothing
      Else
        Return Provincia.PardetPadre
      End If
    End Get
  End Property

  Public ReadOnly Property Provincia() As WWTSParametroDet
    Get
      If Ciudad Is Nothing Then
        Return Nothing
      Else
        Return Ciudad.PardetPadre
      End If
    End Get
  End Property

  Public ReadOnly Property Ciudad() As WWTSParametroDet
    Get
      If PardetParroquia Is Nothing Then
        Return Nothing
      Else
        Return PardetParroquia.PardetPadre
      End If
    End Get
  End Property

  Public ReadOnly Property NombreCompleto() As String
    Get
      If Entidadjuridica Is Nothing Then
        Return String.Empty
      Else
        Return Entidadjuridica.NombreCompleto
      End If
    End Get
  End Property

  'Parametrodet
  Public Overridable Property PardetParroquia() As WWTSParametroDet
    Get
      If Me.mParametrodet Is Nothing AndAlso Pardet_Parroquia > 0 Then
        Me.mParametrodet = New WWTSParametroDet(OperadorDatos, Parame_Parroquia, Pardet_Parroquia)
      End If
      Return Me.mParametrodet

    End Get
    Set(ByVal value As WWTSParametroDet)
      If value IsNot Nothing Then
        Me.mParametrodet = value
        Parame_Parroquia = value.Parame_Codigo
        Pardet_Parroquia = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public ReadOnly Property Ruc() As String
    Get
      If Entidadjuridica Is Nothing Then
        Return String.Empty
      Else
        Return Entidadjuridica.Entidad.RUC
      End If
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Entida_Patrono = CType(Fila("Entida_Patrono"), Integer)
    Parame_Parroquia = CType(Fila("Parame_Parroquia"), Integer)
    Pardet_Parroquia = CType(Fila("Pardet_Parroquia"), Integer)
    Patron_NumeroPatronal = CType(Fila("Patron_NumeroPatronal"), String)
    Patron_NumeroCuentaBancaria = CStr(Fila("Patron_NumeroCuentaBancaria"))
    Patron_CodigoContable = CType(Fila("Patron_CodigoContable"), String)
    mEntidadjuridica = Nothing
    mParametrodet = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.datatable = New System.Data.datatable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
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
    OperadorDatos.AgregarParametro("@Entida_Patrono", Entida_Patrono)
    OperadorDatos.AgregarParametro("@Parame_Parroquia", Parame_Parroquia)
    OperadorDatos.AgregarParametro("@Pardet_Parroquia", Pardet_Parroquia)
    OperadorDatos.AgregarParametro("@Patron_NumeroPatronal", Patron_NumeroPatronal)
    OperadorDatos.AgregarParametro("@Patron_NumeroCuentaBancaria", Patron_NumeroCuentaBancaria)
    OperadorDatos.AgregarParametro("@Patron_CodigoContable", Patron_CodigoContable)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Patron_Codigo = Result
      End If
      EsNuevo = False
      EsModificado = False
    End If
    Return bReturn
  End Function

  Public Overridable Function Eliminar() As Boolean
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "PatronoList"
Public Class PatronoList
  Inherits System.ComponentModel.BindingList(Of Patrono)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As PatronoList
    Dim oResult As PatronoList = New PatronoList
    Dim bReturn As Boolean
    Dim ds As datatable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Patrono"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Patrono(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaxUsuario(ByVal _Usuario As Usuario, Optional ByVal _filtro As String = "") As PatronoList
    Dim oResult As PatronoList = New PatronoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Usuario.OperadorDatos
      .AgregarParametro("@Accion", "Fu")
      .AgregarParametro("@Usuari_Codigo", _Usuario.Usuari_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Patrono"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Patrono(_Usuario.OperadorDatos, False)
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
