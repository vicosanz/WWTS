Option Strict Off
Option Explicit On

Imports Infoware.Datos

Public Class AsientosAutomaticos
  Public Shared Function AsientoCompras(ByVal _Empresa As Empresa, ByVal _Todos As Boolean, ByVal _desde As DateTime, ByVal _hasta As DateTime, ByVal _detalle As String, ByVal _TipoCompte As Integer, ByVal _RegistroContable As RegistroContable) As Boolean
    Dim bReturn As Boolean = True
    Dim ds As DataTable = Nothing
    With _Empresa.OperadorDatos
      .AgregarParametro("@Todos", _Todos)
      .AgregarParametro("@Desde", _desde.Date)
      .AgregarParametro("@Hasta", _hasta.Date)
      .AgregarParametro("@Detalle", _detalle)
      .AgregarParametro("@Pardet_TipoCompte", _TipoCompte)
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .AgregarParametro("@RegCtb_Secuencia", _RegistroContable.RegCtb_Secuencia)

      .Procedimiento = "proc_ASIENTO_DE_COMPRAS"
      bReturn = .Ejecutar()
      .LimpiarParametros()
    End With
    Return bReturn
  End Function

  Public Shared Function AsientoVentas(ByVal _Empresa As Empresa, ByVal _Todos As Boolean, ByVal _desde As DateTime, ByVal _hasta As DateTime, ByVal _detalle As String, ByVal _TipoCompte As Integer, ByVal _RegistroContable As RegistroContable) As Boolean
    Dim bReturn As Boolean = True
    Dim ds As DataTable = Nothing
    With _Empresa.OperadorDatos
      .AgregarParametro("@Todos", _Todos)
      .AgregarParametro("@Desde", _desde.Date)
      .AgregarParametro("@Hasta", _hasta.Date)
      .AgregarParametro("@Detalle", _detalle)
      .AgregarParametro("@Pardet_TipoCompte", _TipoCompte)
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .AgregarParametro("@RegCtb_Secuencia", _RegistroContable.RegCtb_Secuencia)

      .Procedimiento = "proc_ASIENTO_DE_VENTAS"
      bReturn = .Ejecutar()
      .LimpiarParametros()
    End With
    Return bReturn
  End Function

End Class
