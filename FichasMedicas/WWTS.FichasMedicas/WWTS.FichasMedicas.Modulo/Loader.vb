Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.General.Controles
Imports WWTS.General.Modulo
Imports WeifenLuo.WinFormsUI.Docking

Public Class Loader
#Region "FichasMedicas"
  Function CargarModuloFichasMedicas(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.FichasMedicas) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.FichasMedicas), CargarOpcionesFichasMedicas(_Sistema, False), CargarOpcionesFichasMedicas(_Sistema, True), CargarOpcionesFichasMedicasRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesFichasMedicas(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.FichasMedicas
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarFichasMedicas))
            Case Enumerados.EnumOpciones.TiposFichasMedicas
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarTiposFichasMedicas))
          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

  Function CargarOpcionesFichasMedicasRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If _restriccion.Restri_Lectura Then
        Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
          Case Enumerados.EnumOpciones.ReportesContables
            Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPFM")

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
      .Reporte = _Opcion.Tag
    }
    Return f
  End Function

  Function CargarFichasMedicas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmMantenimientoEmpleado(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarTiposFichasMedicas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
    Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False) With {
      .Parame_Codigo = Enumerados.EnumParametros.TipoFichaMedica,
      .PuedeNuevo = False
    }
    Return f
  End Function
  'Function CargarFranjashorarios(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As IDockContent
  'Dim f As New General.Controles.FrmListaParametroDets(_Sistema, _Restriccion, False)
  'f.Parame_Codigo = Enumerados.EnumParametros.FranjaHorarios
  'Return f
  'End Function
#End Region

End Class
