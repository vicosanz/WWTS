Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Consola.Base

Public Class FrmImportacionMarcacion

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub

  Private Sub FrmImportacionMarcacion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Importación Marcaciones"
    fechadesde.Value = DateAdd(DateInterval.Month, -1, Date.Now)
  End Sub
#End Region

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim bReturn As Boolean
    If txtcodigosala.Value = 2 Or txtcodigosala.Value = 3 Then
      bReturn = DiaAsistenciaList.EjecutarImportarMarcacion(Sistema.OperadorDatos, fechadesde.Value, fechahasta.Value, txtcodigosala.Value)
      MsgBox(IIf(bReturn, "Si", "No"), MsgBoxStyle.Information, "Información")
    Else
      MsgBox("No existe ese Código de sala", MsgBoxStyle.Critical, "ERROR")
    End If
  End Sub
End Class