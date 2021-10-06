
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General

Public Class FrmCuracion
    Implements IOpcion

    Private Sub FrmCuracion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        Me.CtlBuscaTarjetaCuracion1.Op = Sistema.OperadorDatos
        Me.CtlTarjCuracion1.Op = Sistema.OperadorDatos
        CtlTarjCuracion1.Restriccion = Restriccion
    End Sub

    Private Sub CtlTarjCuracion1_AntesNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlTarjCuracion1.AntesNuevo
        Dim _Curacion As Curacion
        Dim _anterior As Curacion
        _anterior = Me.CtlTarjCuracion1.Curacion
        _Curacion = New Curacion(Sistema.OperadorDatos, True)
        If Not _anterior Is Nothing AndAlso Not _anterior.Lote Is Nothing Then
            _Curacion.Lote = _anterior.Lote
        End If
        _Curacion.Zafra = Me.CtlBuscaTarjetaCuracion1.Zafra
        Me.CtlTarjCuracion1.Curacion = _Curacion
    End Sub

    Private Sub CtlBuscaTarjetaCuracion1_CambioTarjeta(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaTarjetaCuracion1.CambioTarjeta
        Me.CtlTarjCuracion1.Curacion = Me.CtlBuscaTarjetaCuracion1.Curacion
    End Sub

    Private Sub CtlTarjCuracion1_EliminoTarjeta(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlTarjCuracion1.EliminoTarjeta
        Me.CtlBuscaTarjetaCuracion1.llenar_datos(1)
    End Sub

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
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return PnlCuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Nothing 'MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

End Class