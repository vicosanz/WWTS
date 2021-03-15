Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.General.Controles
Imports WWTS.General.Modulo
Imports WeifenLuo.WinFormsUI.Docking

Public Class Loader

#Region "Siembra"
  Function CargarModuloSiembra(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Siembra) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Siembra), CargarOpcionesSiembra(_Sistema, False), CargarOpcionesSiembra(_Sistema, True), CargarOpcionesSiembraRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesSiembra(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.EnsarteZafadura
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarEnsarteZafadura))
            Case Enumerados.EnumOpciones.Fermentacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarFermentacion))
            Case Enumerados.EnumOpciones.Rezago
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarRezago))
            Case Enumerados.EnumOpciones.ConfiguracionSiembra
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarConfiguracion))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesSiembraRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If _restriccion.Restri_Lectura Then
        Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
          Case Enumerados.EnumOpciones.ReportesSiembra
            Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPS")

            For Each _reporte As Infoware.Reporteador.Reporte In _reportes
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
            Next
          Case Enumerados.EnumOpciones.ReportesPlanificacion
            Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPP")

            For Each _reporte As Infoware.Reporteador.Reporte In _reportes
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
            Next

        End Select
      End If
    Next
    Return _opciones
  End Function

  Function CargarReporte(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, _Restriccion) With {
      .Reporte = CType(_Opcion.Tag, Infoware.Reporteador.Reporte)
    }
    Return f
  End Function

  'Function CargarInicioRoles(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
  '  Dim f As New FrmInicio(_Sistema, _Restriccion)
  '  Return f
  'End Function

  Function CargarEnsarteZafadura(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmEnsarteZafadura(_Sistema, _Restriccion)
    Return f
  End Function

  Private Function CargarFermentacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmFermentacion(_Sistema, _Restriccion)
    Return f
  End Function

  Private Function CargarRezago(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmRezago(_Sistema, _Restriccion)
    Return f
  End Function

  Private Function CargarConfiguracion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmConfiguracion(_Sistema, _Restriccion)
    Return f
  End Function

#End Region

End Class
