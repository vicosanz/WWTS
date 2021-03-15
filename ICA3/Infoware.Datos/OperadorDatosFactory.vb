Public Class OperadorDatosFactory
  Public Shared Function CrearInstancia(ByVal _proveedordatos As enumProveedorDatos, ByVal _servidor As String, ByVal _base As String, ByVal _usuario As String, ByVal _clave As String, ByVal _seguridadintegrada As Boolean) As OperadorDatos
    If _proveedordatos = enumProveedorDatos.SQL Then
      Return New SQLOperadorDatos(_servidor, _base, _usuario, _clave, _seguridadintegrada)
    ElseIf _proveedordatos = enumProveedorDatos.Sybase Then
      Return New SybaseOperadorDatos(_servidor, _base, _usuario, _clave, _seguridadintegrada)
    Else
      Throw New Exception("No es un operador de datos válido")
    End If
  End Function


End Class
