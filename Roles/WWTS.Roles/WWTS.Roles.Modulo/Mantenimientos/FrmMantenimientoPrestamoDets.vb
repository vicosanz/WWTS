Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmMantenimientoPrestamoDetDets
#Region "IOpcion"
  Private mPrestamo As Prestamo = Nothing
  Public Property Prestamo() As Prestamo
    Get
      Return mPrestamo
    End Get
    Set(value As Prestamo)
      mPrestamo = value
      MyBase.Tabla = "Detalles de préstamo"
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property PrestamoDets() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mPrestamoDet As PrestamoDet = Nothing
  Public Property PrestamoDet() As PrestamoDet
    Get
      Return mPrestamoDet
    End Get
    Set(value As PrestamoDet)
      mPrestamoDet = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _PrestamoDets As New PrestamoDetList
        _PrestamoDets.Add(mPrestamoDet)
        MyBase.ListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.PrestamoDet)
        MyBase.ListBindingSource.DataSource = _PrestamoDets
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mPrestamo Is Nothing Then
      Exit Sub
    End If

    mPrestamoDet = PrestamoDets.Current
    Me.dtfecpago.Value = mPrestamoDet.DetPre_Fecha
    Me.txtvalorpag.Value = mPrestamoDet.DetPre_Valor
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoPrestamoDet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mPrestamoDet.EsNuevo
    If _esnuevo AndAlso PrestamoDets.Current IsNot Nothing Then
      PrestamoDets.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "PrestamoDets eventos"
  Private Sub FrmMantenimientoPrestamoDet_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _PrestamoDet As PrestamoDet = New PrestamoDet(mprestamo)
    e.NewObject = _PrestamoDet
  End Sub

  Private Sub FrmMantenimientoPrestamoDet_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoPrestamoDetDets_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mPrestamoDet.DetPre_Fecha = Me.dtfecpago.Value
    mPrestamoDet.DetPre_Valor = Me.txtvalorpag.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mPrestamoDet.EsNuevo
    If mPrestamoDet.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mPrestamoDet.Prestamo.Contrato.Empleado.NombreCompleto)

      Return True
    Else
      'PrestamoDets.CancelEdit()
      MsgBox("No se puede guardar detalle de Préstamo" & Environment.NewLine & mPrestamo.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoPrestamoDet_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPrestamoDet.Eliminar() AndAlso PrestamoDets.Current IsNot Nothing Then
      PrestamoDets.RemoveCurrent()
      Me.Close()
    Else
      'PrestamoDets.CancelEdit()
      MsgBox("No se puede eliminar detalle de Préstamo" & Environment.NewLine & mPrestamo.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoPrestamoDet_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPrestamoDet_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPrestamoDet_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPrestamoDet_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.PuedeGuardar = True
    Me.PuedeGuardaryCerrar = True
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.PuedeGuardar = True
    Me.PuedeGuardaryCerrar = True
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

End Class
