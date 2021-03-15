Public Interface IRegla
#Region "Acciones"
  Sub MapearDataRowaObjeto(ByVal _dr As DataRow)
  Function Guardar() As Boolean
  Function Eliminar() As Boolean
  Function Recargar() As Boolean
#End Region
End Interface
