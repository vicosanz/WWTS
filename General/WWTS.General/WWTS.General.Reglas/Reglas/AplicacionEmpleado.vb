
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "AplicacionEmpleado"
Public Class AplicacionEmpleado
  Inherits _Database

  Const _Procedimiento As String = "proc_AplicacionEmpleado"

  Private mEmpleado As Empleado = Nothing

  Private mPardetArea As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  'Empleado
  Public Overridable Property Empleado() As Empleado
    Get
      If Me.mEmpleado Is Nothing AndAlso Entida_Codigo > 0 Then
        Me.mEmpleado = New Empleado(OperadorDatos, Entida_Codigo)
      End If
      Return Me.mEmpleado
    End Get
    Set(ByVal value As Empleado)
      Me.mEmpleado = value
      Entida_Codigo = value.Entida_Codigo
    End Set
  End Property

  'PardetArea
  Public Overridable Property PardetArea() As WWTSParametroDet
    Get
      If Me.mPardetArea Is Nothing AndAlso Pardet_Area > 0 Then
        Me.mPardetArea = New WWTSParametroDet(OperadorDatos, Parame_Area, Me.Pardet_Area)
      End If
      Return Me.mPardetArea
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetArea = value
      If value Is Nothing Then
        Parame_Area = 0
        Pardet_Area = 0
      Else
        Parame_Area = value.Parame_Codigo
        Pardet_Area = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Área Aplicada", CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property PardetAreaString() As String
    Get
      Try
        If PardetArea Is Nothing Then
          Return String.Empty
        Else
          Return PardetArea.Pardet_Descripcion
        End If
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Parame_Area = CType(Fila("Parame_Area"), Integer)
    Pardet_Area = CType(Fila("Pardet_Area"), Integer)

    mEmpleado = Nothing
    mPardetArea = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
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
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
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
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "AplicacionEmpleadoList"
Public Class AplicacionEmpleadoList
  Inherits System.ComponentModel.BindingList(Of AplicacionEmpleado)

  Public Shared Function ObtenerListaxEmpleado(ByVal _Empleado As Empleado, Optional ByVal _filtro As String = "") As AplicacionEmpleadoList
    Dim oResult As AplicacionEmpleadoList = New AplicacionEmpleadoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Empleado.OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Entida_Codigo", _Empleado.Entida_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_AplicacionEmpleado"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New AplicacionEmpleado(_Empleado.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
