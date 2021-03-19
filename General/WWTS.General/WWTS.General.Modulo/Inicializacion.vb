Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports WWTS.General.Controles
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports System.Threading.Tasks

Public Class Inicializacion
  Implements IAplicacion

  Public Function Validacion(ByVal _Usuario As Infoware.Reglas.General.Usuario) As Boolean Implements Infoware.Consola.Base.IAplicacion.Validacion
    'MsgBox("Todo ok")
    Return True
  End Function

  'Public Sub CargarListaModulos(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal) Implements Infoware.Consola.Base.IAplicacion.CargarListaModulos
  '  'If _Sistema.Usuario.Restricciones.Rango(100, 199) Then
  '  '  _Principal.LeftSpine1.Items.Add(_Principal.CrearBotonModulo("Empresa", My.Resources.Resources.compania.ToBitmap, New IAplicacion.DelegadoCargarModulos(AddressOf CargarModuloEmpresa)))
  '  'End If
  '  If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
  '    _Principal.LeftSpine1.Items.Add(_Principal.CrearBotonModulo("Seguridad", New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Seguridad).Pardet_Imagen, New IAplicacion.DelegadoCargarModulos(AddressOf CargarModuloSeguridad)))
  '  End If
  '  If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
  '    _Principal.LeftSpine1.Items.Add(_Principal.CrearBotonModulo("Configuración", New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Configuracion).Pardet_Imagen, New IAplicacion.DelegadoCargarModulos(AddressOf CargarModuloConfiguracion)))
  '  End If
  'End Sub

  'Public Sub CargarModuloEmpresa(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal)
  '  _Principal.Text = "Empresa"
  '  Dim f As New FrmMenuEmpresa(_Sistema)
  '  _Principal.Cargar_IModulo(f)
  'End Sub

  'Public Sub CargarModuloSeguridad(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal)
  '  _Principal.Text = "Seguridad"
  '  Dim f As New FrmMenuSeguridad(_Sistema)
  '  _Principal.Cargar_IModulo(f)
  'End Sub

  'Public Sub CargarModuloConfiguracion(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal)
  '  _Principal.Text = "Configuración"
  '  Dim f As New FrmMenuConfiguracion(_Sistema)
  '  _Principal.Cargar_IModulo(f)
  'End Sub

  'Public Function CargarListaNuevos() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionNuevo) Implements Infoware.Consola.Base.IAplicacion.CargarListaNuevos
  '  Dim result As New List(Of OpcionNuevo)
  '  result.Add(New OpcionNuevo("Cliente", My.Resources.Cliente.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevoCliente), WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoClientes))

  '  result.Add(New OpcionNuevo("Proveedor", My.Resources.Proveedor.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevoProveedor), WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoProveedores))

  '  result.Add(New OpcionNuevo("Empresa", My.Resources.compania.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevaEmpresa), WWTS.General.Reglas.Enumerados.EnumOpciones.Empresa))

  '  'result.Add(New OpcionNuevo("Sucursal", My.Resources.compania.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevaSucursal), WWTS.General.Reglas.Enumerados.EnumOpciones.Sucursal))

  '  Return result
  'End Function

  'Sub NuevoCliente(ByVal _Sistema As Sistema)
  '  Dim f As New FrmMantenimientoCliente(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoClientes)
  '  f.Cliente = New WWTS.General.Reglas.Cliente(_Sistema.OperadorDatos, True)
  '  f.ShowDialog()
  'End Sub

  'Sub NuevoProveedor(ByVal _Sistema As Sistema)
  '  Dim f As New FrmMantenimientoProveedor(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoProveedores)
  '  f.Proveedor = New WWTS.General.Reglas.Proveedor(_Sistema.OperadorDatos, True)
  '  f.ShowDialog()
  'End Sub

  'Sub NuevaEmpresa(ByVal _Sistema As Sistema)
  '  Dim f As New FrmMantenimientoEmpresa(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.Empresa)
  '  f.Empresa = New WWTS.General.Reglas.Empresa(_Sistema.OperadorDatos, True)
  '  f.ShowDialog()
  'End Sub

  'Sub NuevaSucursal(ByVal _Sistema As Sistema)
  '  Dim f As New FrmMantenimientoSucursal(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.Sucursal)
  '  f.Sucursal = New WWTS.General.Reglas.Sucursal( _Sistema..OperadorDatos, True)
  '  f.ShowDialog()
  'End Sub

  'Public Function CargarListaBuscar() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionBuscar) Implements Infoware.Consola.Base.IAplicacion.CargarListaBuscar
  '  Dim result As New List(Of OpcionBuscar)
  '  'result.Add(New OpcionBuscar("Afiliado", New Infoware.Consola.Base.OpcionBuscar.DelegadoCargarOpcion(AddressOf BuscarAfiliado), WWTS.General.Reglas.Enumerados.EnumOpciones.Afiliados))

  '  Return result
  'End Function

  'Sub BuscarAfiliado(ByVal _Sistema As Sistema, ByVal _Texto As String)
  '  Dim f As New FrmListaAfiliados(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.Afiliados, False)

  '  f.Filtro = _Texto
  '  f.ShowDialog()
  'End Sub

  Public Function CargarListaGrupoOpciones(ByVal _Sistema As Infoware.Consola.Base.Sistema) As System.Collections.Generic.List(Of Infoware.Consola.Base.GrupoOpcion) Implements Infoware.Consola.Base.IAplicacion.CargarListaGrupoOpciones
    Dim _grupos As New List(Of GrupoOpcion)

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
      _grupos.AddRange(New WWTS.General.Modulo.Loader().CargarModuloSeguridad(_Sistema))
    End If
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
      _grupos.AddRange(New WWTS.General.Modulo.Loader().CargarModuloConfiguracion(_Sistema))
    End If

    Return _grupos
  End Function

  Public Event ActualizacionesMensaje As EventHandler(Of String) Implements IAplicacion.ActualizacionesMensaje

  Public Function ComprobarActualizaciones(ensamblado As String) As Task(Of Boolean) Implements IAplicacion.ComprobarActualizaciones
    Return Task.FromResult(False)
  End Function
End Class
