Public Interface IMantenimiento
  Enum Accion
    Ingreso
    Modificacion
    Eliminacion
  End Enum
  Property Direccion() As Accion
  Sub Refrescar_forma()

End Interface
