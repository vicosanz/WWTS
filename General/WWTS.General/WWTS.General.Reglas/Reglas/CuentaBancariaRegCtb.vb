Imports WWTS.General.Reglas

#Region "CuentaBancariaList"
Public Class CuentaBancariaRegCtb
  Inherits System.ComponentModel.BindingList(Of CuentaBancaria)

  Public Shared Function ObtenerLista(ByVal _Empresa As Empresa, ByVal _RegistroContable As RegistroContable, ByVal _fechahasta As Date, Optional ByVal _filtro As String = "") As CuentaBancariaList
    Dim oResult As CuentaBancariaList = New CuentaBancariaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _RegistroContable.OperadorDatos
      .AgregarParametro("@Accion", "Fs")
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .AgregarParametro("@RegCtb_Secuencia", _RegistroContable.RegCtb_Secuencia)
      .AgregarParametro("@fechahasta", _fechahasta)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_CuentaBancaria"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New CuentaBancaria(_Empresa, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
