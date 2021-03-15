Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "RubroxBeneficio"
Public Class RubroxBeneficio
  Inherits _Database

  Const _Procedimiento As String = "proc_RubroxBeneficio"

  Private mPardetTipoBeneficio As WWTSParametroDet = Nothing

  Private mPardetTipoRubro As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  'PardetTipoBeneficio
  Public Overridable Property PardetTipoBeneficio() As WWTSParametroDet
    Get
      If Me.mPardetTipoBeneficio Is Nothing AndAlso Pardet_TipoBeneficio > 0 Then
        Me.mPardetTipoBeneficio = New WWTSParametroDet(OperadorDatos, Parame_TipoBeneficio, Pardet_TipoBeneficio)
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

  'PardetTipoRubro
  Public Overridable Property PardetTipoRubro() As WWTSParametroDet
    Get
      If Me.mPardetTipoRubro Is Nothing AndAlso Pardet_TipoRubro > 0 Then
        Me.mPardetTipoRubro = New WWTSParametroDet(OperadorDatos, Parame_TipoRubro, Pardet_TipoRubro)
      End If
      Return Me.mPardetTipoRubro
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoRubro = value
      If value Is Nothing Then
        Parame_TipoRubro = 0
        Pardet_TipoRubro = 0
      Else
        Parame_TipoRubro = value.Parame_Codigo
        Pardet_TipoRubro = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Public ReadOnly Property PardetRubroString() As String
    Get
      Try
        If PardetTipoRubro Is Nothing Then
          Return String.Empty
        Else
          Return Me.PardetTipoRubro.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_TipoBeneficio = CType(Fila("Parame_TipoBeneficio"), Integer)
    Pardet_TipoBeneficio = CType(Fila("Pardet_TipoBeneficio"), Integer)
    Parame_TipoRubro = CType(Fila("Parame_TipoRubro"), Integer)
    Pardet_TipoRubro = CType(Fila("Pardet_TipoRubro"), Integer)
    RubBen_Activo = CType(Fila("RubBen_Activo"), Boolean)

    mPardetTipoBeneficio = Nothing
    mPardetTipoRubro = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Parame_TipoRubro", Parame_TipoRubro)
    OperadorDatos.AgregarParametro("@Pardet_TipoRubro", Pardet_TipoRubro)
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
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Parame_TipoRubro", Parame_TipoRubro)
    OperadorDatos.AgregarParametro("@Pardet_TipoRubro", Pardet_TipoRubro)
    OperadorDatos.AgregarParametro("@RubBen_Activo", RubBen_Activo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If Not OperadorDatos.EstaenTransaccion Then
        AceptarCambios()
      End If
    End If
    Return bReturn
  End Function

  Public Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Parame_TipoBeneficio", Parame_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Pardet_TipoBeneficio", Pardet_TipoBeneficio)
    OperadorDatos.AgregarParametro("@Parame_TipoRubro", Parame_TipoRubro)
    OperadorDatos.AgregarParametro("@Pardet_TipoRubro", Pardet_TipoRubro)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "RubroxBeneficioList"
Public Class RubroxBeneficioList
  Inherits System.ComponentModel.BindingList(Of RubroxBeneficio)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _PardetTipoBeneficio As WWTSParametroDet, Optional ByVal _filtro As String = "") As RubroxBeneficioList
    Dim oResult As RubroxBeneficioList = New RubroxBeneficioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Parame_TipoBeneficio", _PardetTipoBeneficio.Parame_Codigo)
      .AgregarParametro("@Pardet_TipoBeneficio", _PardetTipoBeneficio.Pardet_Secuencia)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RubroxBeneficio"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubroxBeneficio(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region