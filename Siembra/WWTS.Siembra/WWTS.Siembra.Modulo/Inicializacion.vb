Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports System.IO
Imports System.Threading.Tasks
Imports Squirrel
Imports Infoware.Updates

Public Class Inicializacion
  Implements Infoware.Consola.Base.IAplicacion

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
    Dim mProcess As System.Diagnostics.Process
    mProcess = New System.Diagnostics.Process
    mProcess.StartInfo.FileName = RutaICA
    mProcess.StartInfo.Arguments = String.Format("""{0}""", System.Reflection.Assembly.GetExecutingAssembly.Location)
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

  Private Shared Async Function CheckForUpdates() As Task
    Try
      Using mgr As UpdateManager = Await UpdateManager.GitHubUpdateManager("https://github.com/vicosanz/SiembraInstaller")
        Await mgr.UpdateApp()
      End Using
    Catch ex As Exception

    End Try
  End Function

  Public Function Validacion(ByVal _Usuario As Infoware.Reglas.General.Usuario) As Boolean Implements Infoware.Consola.Base.IAplicacion.Validacion
    'MsgBox("Todo ok")
    Return True
  End Function

  'Public Sub CargarListaModulos(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal) Implements Infoware.Consola.Base.IAplicacion.CargarListaModulos
  '  If _Principal.Sistema.Usuario.Restricciones.Rango(700, 799) Then
  '    _Principal.LeftSpine1.Items.Add(_Principal.CrearBotonModulo("Roles de pago", My.Resources.Resources.pagos.ToBitmap, New IAplicacion.DelegadoCargarModulos(AddressOf CargarModulo)))
  '  End If
  'End Sub

  'Public Sub CargarModulo(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal)
  '  _Principal.Text = "Roles de pago"
  '  Dim f As New FrmMenuRol(_Principal.Sistema)
  '  _Principal.Cargar_IModulo(f)
  'End Sub

  'Public Function CargarListaNuevos() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionNuevo) Implements Infoware.Consola.Base.IAplicacion.CargarListaNuevos
  '  Dim result As New List(Of OpcionNuevo)
  '  'result.Add(New OpcionNuevo("Roles de pago", My.Resources.pagos.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevoAfiliado), WWTS.General.Reglas.Enumerados.EnumOpciones.Afiliados))

  '  Return result
  'End Function

  ''Sub NuevoAfiliado(ByVal _Sistema As Sistema)
  ''  Dim f As New FrmMantenimientoAfiliado(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.Afiliados)
  ''  f.Afiliado = New WWTS.Fidelizacion.Reglas.Afiliado(_Sistema.OperadorDatos, True)
  ''  f.ShowDialog()
  ''End Sub

  'Public Function CargarListaBuscar() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionBuscar) Implements Infoware.Consola.Base.IAplicacion.CargarListaBuscar
  '  Dim result As New List(Of OpcionBuscar)
  '  'result.Add(New OpcionBuscar("Afiliado", New Infoware.Consola.Base.OpcionBuscar.DelegadoCargarOpcion(AddressOf BuscarAfiliado), WWTS.General.Reglas.Enumerados.EnumOpciones.Afiliados))

  '  Return result
  'End Function

  ''Sub BuscarAfiliado(ByVal _Sistema As Sistema, ByVal _Texto As String)
  ''  Dim f As New FrmListaAfiliados(_Sistema, WWTS.General.Reglas.Enumerados.EnumOpciones.Afiliados, False)

  ''  f.Filtro = _Texto
  ''  f.ShowDialog()
  ''End Sub

  Public Function CargarListaGrupoOpciones(ByVal _Sistema As Infoware.Consola.Base.Sistema) As System.Collections.Generic.List(Of Infoware.Consola.Base.GrupoOpcion) Implements Infoware.Consola.Base.IAplicacion.CargarListaGrupoOpciones
    Dim _grupos As New List(Of GrupoOpcion)

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Siembra) Then
      _grupos.AddRange(New Loader().CargarModuloSiembra(_Sistema))
    End If

    Return _grupos
  End Function

  Public Event ActualizacionesMensaje As EventHandler(Of String) Implements IAplicacion.ActualizacionesMensaje

  Public Async Function ComprobarActualizaciones(ensamblado As String) As Task(Of Boolean) Implements IAplicacion.ComprobarActualizaciones
    Dim result As Boolean = False
    Using mgr As FUpdateManager = Await GitHubUpdateManager.GetUpdateManager("vicosanz", "SiembraInstaller", ensamblado)
      Dim _nombreAplicacion = Path.GetFileNameWithoutExtension(ensamblado)
      Dim _updateInfo As UpdateInfo = Nothing
      Try
        _updateInfo = Await mgr.CheckForUpdate()
        If _updateInfo.ReleasesToApply.Any() Then
          RaiseEvent ActualizacionesMensaje(Me, $"Nueva versión {_nombreAplicacion} detectada. Instalando en segundo plano versión.")
          Await mgr.UpdateApp()
          RaiseEvent ActualizacionesMensaje(Me, $"Aplicación {_nombreAplicacion} actualizada. Por favor reinicie el programa para continuar.")
          result = True
        End If
      Catch ex As Exception
        RaiseEvent ActualizacionesMensaje(Me, ex.Message)
      End Try
    End Using
    Return result
  End Function
End Class
