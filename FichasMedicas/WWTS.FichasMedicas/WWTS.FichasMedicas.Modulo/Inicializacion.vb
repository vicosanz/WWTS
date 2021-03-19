Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports System.IO
Imports Squirrel
Imports System.Threading.Tasks
Imports Infoware.Updates

Public Class Inicializacion
  Implements IAplicacion

  Public Shared Sub Main()
    'ejecutar ica
    Dim RutaICA As String = ICA3Helper.LeerClave()

    If Not My.Computer.FileSystem.FileExists(RutaICA) Then
      If MsgBox("No se pudo encontrar ICA3, ¿Desea encontrarlo usted mismo?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Dim ofd As New OpenFileDialog With {
          .Filter = "ICA (ICA3.exe)|ICA3.exe|Todos los archivos (*.*)|*.*"
        }

        If ofd.ShowDialog = DialogResult.OK Then
          RutaICA = ofd.FileName
          ICA3Helper.GuardarClave(RutaICA)
          My.Settings.Save()
        Else
          End
        End If
      Else
        MsgBox("Debe instalar el Infoware.Consola.Adminitrator antes de poder utilizar el sistema", MsgBoxStyle.Exclamation, "Información")
        End
      End If
    End If

    Dim mProcess As Process
    mProcess = New Process
    mProcess.StartInfo.FileName = RutaICA
    mProcess.StartInfo.Arguments = String.Format("""{0}""", Reflection.Assembly.GetExecutingAssembly.Location)
    'mProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
    mProcess.EnableRaisingEvents = False

    mProcess.Start()
    End
    'mProcess.WaitForExit()
    'Do
    '  If Not mProcess.HasExited Then
    '  End If
    'Loop While Not mProcess.WaitForExit(1000)
  End Sub

  Public Function Validacion(_Usuario As Infoware.Reglas.General.Usuario) As Boolean Implements Infoware.Consola.Base.IAplicacion.Validacion
    Dim _parametrodet As New Infoware.Reglas.General.ParametroDet(_Usuario.OperadorDatos, 5, 1)
    If Not _parametrodet.Pardet_Descripcion = "Domus" And Not _parametrodet.Pardet_Descripcion = "SalesManager" Then
      MsgBox("Base de datos no compatible con esta aplicación")
      Return False
    End If
    _parametrodet = New Infoware.Reglas.General.ParametroDet(_Usuario.OperadorDatos, 1, 1)
    If Not _parametrodet.Pardet_DatoStr1 >= "1.0" Then
      MsgBox("Versión de base de datos debe actualizarse")
      Return False
    End If
    Return True
  End Function

  'Public Sub CargarListaModulos(_Principal As Infoware.Consola.Base.FrmPrincipal) Implements Infoware.Consola.Base.IAplicacion.CargarListaModulos
  '  If _Principal.Sistema.Usuario.Restricciones.Rango(1000, 1050) Then
  '    _Principal.LeftSpine1.Items.Add(_Principal.CrearBotonModulo("Fidelización", My.Resources.Resources.Empresa.ToBitmap, New IAplicacion.DelegadoCargarModulos(AddressOf CargarModulo)))
  '  End If
  'End Sub

  'Public Sub CargarModulo(_Principal As Infoware.Consola.Base.FrmPrincipal)
  '  _Principal.Text = "Fidelización"
  '  Dim f As New FrmMenuFidelizacion(_Principal.Sistema)
  '  _Principal.Cargar_IModulo(f)
  'End Sub

  'Public Function CargarListaNuevos() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionNuevo) Implements Infoware.Consola.Base.IAplicacion.CargarListaNuevos
  '  Dim result As New List(Of OpcionNuevo)
  '  result.Add(New OpcionNuevo("Afiliado", My.Resources.Empresa.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevoAfiliado), WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoAfiliados))

  '  Return result
  'End Function

  'Sub NuevoAfiliado(_Sistema As Sistema)
  '  Dim f As New FrmMantenimientoAfiliado(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoAfiliados)
  '  f.Afiliado = New WWTS.Fidelizacion.Reglas.Afiliado(_Sistema.OperadorDatos, True)
  '  f.ShowDialog()
  'End Sub

  'Public Function CargarListaBuscar() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionBuscar) Implements Infoware.Consola.Base.IAplicacion.CargarListaBuscar
  '  Dim result As New List(Of OpcionBuscar)
  '  result.Add(New OpcionBuscar("Afiliados", New Infoware.Consola.Base.OpcionBuscar.DelegadoCargarOpcion(AddressOf BuscarAfiliado), WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoAfiliados))

  '  result.Add(New OpcionBuscar("Premios", New Infoware.Consola.Base.OpcionBuscar.DelegadoCargarOpcion(AddressOf BuscarPremio), WWTS.General.Reglas.Enumerados.EnumOpciones.Premios))

  '  Return result
  'End Function

  'Sub BuscarAfiliado(_Sistema As Sistema, ByVal _Texto As String)
  '  Dim f As New FrmListaAfiliados(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.ListadoAfiliados, False)

  '  f.Filtro = _Texto
  '  f.ShowDialog()
  'End Sub

  'Sub BuscarPremio(_Sistema As Sistema, ByVal _Texto As String)
  '  Dim f As New FrmListaItems(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.Premios, False, Nothing)

  '  f.Filtro = _Texto
  '  f.ShowDialog()
  'End Sub

  Public Function CargarListaGrupoOpciones(_Sistema As Infoware.Consola.Base.Sistema) As System.Collections.Generic.List(Of Infoware.Consola.Base.GrupoOpcion) Implements Infoware.Consola.Base.IAplicacion.CargarListaGrupoOpciones
    Dim _grupos As New List(Of GrupoOpcion)

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.FichasMedicas) Then
      _grupos.AddRange(New Loader().CargarModuloFichasMedicas(_Sistema))
    End If

    Return _grupos
  End Function

  Public Event ActualizacionesMensaje As EventHandler(Of String) Implements IAplicacion.ActualizacionesMensaje

  Public Async Function ComprobarActualizaciones() As Task(Of Boolean) Implements IAplicacion.ComprobarActualizaciones
    Return Await BuscarActualizaciones()
  End Function

  Private Async Function BuscarActualizaciones() As Task(Of Boolean)
    Dim result As Boolean = False
    Using mgr As FUpdateManager = Await GitHubUpdateManager.GetUpdateManager("vicosanz", "FichasMedicasInstaller")
      Dim _updateInfo As UpdateInfo = Nothing
      Try
        _updateInfo = Await mgr.CheckForUpdate()
        If _updateInfo.ReleasesToApply.Any() Then
          RaiseEvent ActualizacionesMensaje(Me, "Nueva versión detectada. Instalando en segundo plano versión.")
          Await mgr.UpdateApp()
          RaiseEvent ActualizacionesMensaje(Me, "Aplicación actualizada. Por favor reinicie el programa para continuar.")
          result = True
        End If
      Catch ex As Exception
        RaiseEvent ActualizacionesMensaje(Me, ex.Message)
      End Try
    End Using
    Return result
  End Function
End Class
