Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.General.Controles
Imports WeifenLuo.WinFormsUI.Docking

Public Class Loader
#Region "Empresa"
  Function CargarModuloEmpresa(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Empresa) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Empresa), CargarOpcionesEmpresa(_Sistema, False), CargarOpcionesEmpresa(_Sistema, True), CargarOpcionesEmpresaRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesEmpresa(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.Empresa
              If _restriccion.Restri_Ingreso Then
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarNuevaEmpresa, "Nueva Empresa"))
              End If
            Case Enumerados.EnumOpciones.Empresa
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarEmpresa))
            Case Enumerados.EnumOpciones.Sucursal
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarSucursal))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesEmpresaRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    'For Each _restriccion As Restriccion In _Sistema.Restricciones
    '  If _restriccion.Restri_Lectura Then
    '    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
    '      Case Enumerados.EnumOpciones.Empresa
    '        If _restriccion.Restri_Ingreso Then
    '          _opciones.Add(New Opcion(_restriccion, AddressOf CargarNuevaEmpresa, "Nueva Empresa"))
    '        End If
    '        'Case Enumerados.EnumOpciones.Sucursal
    '        '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarSucursal))
    '    End Select
    '  End If
    'Next
    Return _opciones
  End Function

  Function CargarEmpresa(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmMantenimientoEmpresa(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarNuevaEmpresa(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmMantenimientoEmpresa(_Sistema, _Restriccion) With {
      .Empresa = New Empresa(_Sistema.OperadorDatos, True)
    }
    Return f
  End Function

  Function CargarSucursal(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmListaSucursales(_Sistema, _Restriccion, False, Nothing)
    Return f
  End Function
#End Region

#Region "Seguridad"
  Function CargarModuloSeguridad(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Seguridad), CargarOpcionesSeguridad(_Sistema, False), CargarOpcionesSeguridad(_Sistema, True), CargarOpcionesSeguridadRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesSeguridad(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.Usuarios
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarUsuario))
            Case Enumerados.EnumOpciones.Auditoria
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarAuditoria))
            Case Enumerados.EnumOpciones.Licencias
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarLicencias))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesSeguridadRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)
    Return _opciones
  End Function

  Function CargarUsuario(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmListaUsuarios(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarAuditoria(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmAuditoria(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarLicencias(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New General.Controles.FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.Licencias
    Return f
  End Function
#End Region

#Region "Configuracion"
  Function CargarModuloConfiguracion(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Configuracion), CargarOpcionesConfiguracion(_Sistema, False), CargarOpcionesConfiguracion(_Sistema, True), CargarOpcionesConfiguracionRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesConfiguracion(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.Modulos
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarModulos))
            Case Enumerados.EnumOpciones.Opciones
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarOpciones))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesConfiguracionRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)
    Return _opciones
  End Function

  Function CargarModulos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New General.Controles.FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.Modulos
    f.PuedeNuevo = False
    Return f
  End Function

  Function CargarOpciones(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New General.Controles.FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.Opciones
    f.PuedeNuevo = False
    Return f
  End Function
#End Region

End Class
