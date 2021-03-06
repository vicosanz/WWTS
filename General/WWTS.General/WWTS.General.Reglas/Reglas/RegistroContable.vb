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


#Region "RegistroContable"
Public Class RegistroContable

  Const _Procedimiento As String = "proc_RegistroContable"

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _RegCtb_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    RegCtb_Secuencia = _RegCtb_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto RegistroContable")
    End If
  End Sub

  <Infoware.Reportes.CampoReporteAtributo("Descripción", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 300, True)> _
  Public ReadOnly Property Descripcion() As String
    Get
      Return String.Format("({0}) {1}", RegCtb_Anio, RegCtb_Descripcion)
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    RegCtb_Secuencia = CType(Fila("RegCtb_Secuencia"), Integer)
    RegCtb_Anio = CType(Fila("RegCtb_Anio"), Integer)
    RegCtb_Descripcion = CType(Fila("RegCtb_Descripcion"), String)
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.datatable = New System.Data.datatable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@RegCtb_Secuencia", RegCtb_Secuencia)
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
    OperadorDatos.AgregarParametro("@RegCtb_Secuencia", RegCtb_Secuencia)
    OperadorDatos.AgregarParametro("@RegCtb_Anio", RegCtb_Anio)
    OperadorDatos.AgregarParametro("@RegCtb_Descripcion", RegCtb_Descripcion)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        RegCtb_Secuencia = Result
      End If
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
    OperadorDatos.AgregarParametro("@RegCtb_Secuencia", RegCtb_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "RegistroContableList"
Public Class RegistroContableList
  Inherits System.ComponentModel.BindingList(Of RegistroContable)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As RegistroContableList
    Dim oResult As RegistroContableList = New RegistroContableList
    Dim bReturn As Boolean
    Dim ds As datatable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_RegistroContable"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New RegistroContable(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
