Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "RubrosxCentroCosto"
Public Class RubrosxCentroCosto
  Inherits _Database

  Const _Procedimiento As String = "proc_RubrosxCentroCosto"

  Private mPardetCentroCosto As WWTSParametroDet = Nothing

  Private mPardetRubro As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  'PardetCentroCosto
  Public Overridable Property PardetCentroCosto() As WWTSParametroDet
    Get
      If Me.mPardetCentroCosto Is Nothing AndAlso Pardet_CentroCosto > 0 Then
        Me.mPardetCentroCosto = New WWTSParametroDet(OperadorDatos, Parame_CentroCosto, Pardet_CentroCosto)
      End If
      Return Me.mPardetCentroCosto
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetCentroCosto = value
      If value Is Nothing Then
        Parame_CentroCosto = 0
        Pardet_CentroCosto = 0
      Else
        Parame_CentroCosto = value.Parame_Codigo
        Pardet_CentroCosto = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetRubro
  Public Overridable Property PardetRubro() As WWTSParametroDet
    Get
      If Me.mPardetRubro Is Nothing AndAlso Pardet_Rubro > 0 Then
        Me.mPardetRubro = New WWTSParametroDet(OperadorDatos, Parame_Rubro, Pardet_Rubro)
      End If
      Return Me.mPardetRubro
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetRubro = value
      If value Is Nothing Then
        Parame_Rubro = 0
        Pardet_Rubro = 0
      Else
        Parame_Rubro = value.Parame_Codigo
        Pardet_Rubro = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Centro Costo", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetCentroCostoString() As String
    Get
      Try
        If PardetCentroCosto Is Nothing Then
          Return String.Empty
        Else
          Return Me.PardetCentroCosto.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Rubro", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetTestSeleccionString() As String
    Get
      Try
        If PardetRubro Is Nothing Then
          Return String.Empty
        Else
          Return Me.PardetRubro.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Cuenta Contable", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property RubCen_CtaCtbleString() As String
    Get
      Return RubCen_CtaCtble
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_CentroCosto = CType(Fila("Parame_CentroCosto"), Integer)
    Pardet_CentroCosto = CType(Fila("Pardet_CentroCosto"), Integer)
    Parame_Rubro = CType(Fila("Parame_Rubro"), Integer)
    Pardet_Rubro = CType(Fila("Pardet_Rubro"), Integer)
    RubCen_CtaCtble = CType(Fila("RubCen_CtaCtble"), String)

    mPardetCentroCosto = Nothing
    mPardetRubro = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_CentroCosto", Parame_CentroCosto)
    OperadorDatos.AgregarParametro("@Pardet_CentroCosto", Pardet_CentroCosto)
    OperadorDatos.AgregarParametro("@Parame_Rubro", Parame_Rubro)
    OperadorDatos.AgregarParametro("@Pardet_Rubro", Pardet_Rubro)
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
    OperadorDatos.AgregarParametro("@Parame_CentroCosto", Parame_CentroCosto)
    OperadorDatos.AgregarParametro("@Pardet_CentroCosto", Pardet_CentroCosto)
    OperadorDatos.AgregarParametro("@Parame_Rubro", Parame_Rubro)
    OperadorDatos.AgregarParametro("@Pardet_Rubro", Pardet_Rubro)
    OperadorDatos.AgregarParametro("@RubCen_CtaCtble", RubCen_CtaCtble)
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
    OperadorDatos.AgregarParametro("@Parame_CentroCosto", Parame_CentroCosto)
    OperadorDatos.AgregarParametro("@Pardet_CentroCosto", Pardet_CentroCosto)
    OperadorDatos.AgregarParametro("@Parame_Rubro", Parame_Rubro)
    OperadorDatos.AgregarParametro("@Pardet_Rubro", Pardet_Rubro)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "RubrosxCentroCostoList"
Public Class RubrosxCentroCostoList
  Inherits System.ComponentModel.BindingList(Of RubrosxCentroCosto)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _PardetCentroCosto As WWTSParametroDet) As RubrosxCentroCostoList
    Dim oResult As RubrosxCentroCostoList = New RubrosxCentroCostoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Parame_CentroCosto", _PardetCentroCosto.Parame_Codigo)
      .AgregarParametro("@Pardet_CentroCosto", _PardetCentroCosto.Pardet_Secuencia)
      .Procedimiento = "proc_RubrosxCentroCosto"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RubrosxCentroCosto(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region