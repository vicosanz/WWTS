Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Consola.Base

Public Class FrmMantenimientoPrestamos
#Region "IOpcion"
  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(value As Contrato)
      mContrato = value
      MyBase.Tabla = "Préstamo"
      If value IsNot Nothing Then
        Me.cbotipoprestamo.OperadorDatos = value.OperadorDatos
        Me.cbotipoprestamo.Parametro = Enumerados.EnumParametros.TipoPrestamo
        Me.cbotipoprestamo.Llenar_Datos()
      End If
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property Prestamos() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mPrestamo As Prestamo = Nothing
  Public Property Prestamo() As Prestamo
    Get
      Return mPrestamo
    End Get
    Set(value As Prestamo)
      mPrestamo = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _Prestamos As New PrestamoList
        _Prestamos.Add(mPrestamo)
        MyBase.ListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.Prestamo)
        MyBase.ListBindingSource.DataSource = _Prestamos
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mContrato Is Nothing Then
      Exit Sub
    End If

    mPrestamo = Prestamos.Current
    Me.dtfecsolicitud.Value = mPrestamo.Presta_FechaSolicitud
    Me.txtvalorsolic.Value = mPrestamo.Presta_ValorSolicitado
    Me.txtcuota.Value = mPrestamo.Presta_ValorCuota
    Me.txtmotivo.Text = mPrestamo.Presta_Motivo
    Me.chkurgente.Checked = mPrestamo.Presta_Urgente
    Me.chkaprobado.Checked = mPrestamo.Presta_esAprobado
    Me.cbotipoprestamo.ParametroDet = mPrestamo.PardetTipoPrestamo

    Me.dtfecaprobacion.Value = mPrestamo.Presta_FechaAprobacion
    Me.txtvaloraprob.Value = mPrestamo.Presta_ValorAprobado
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoPrestamo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mPrestamo.EsNuevo
    If _esnuevo AndAlso Prestamos.Current IsNot Nothing Then
      Prestamos.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Prestamos eventos"
  Private Sub FrmMantenimientoPrestamo_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Prestamo As Prestamo = New Prestamo(mContrato)
    e.NewObject = _Prestamo
  End Sub

  Private Sub FrmMantenimientoPrestamo_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoPrestamo_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mPrestamo.Presta_FechaSolicitud = Me.dtfecsolicitud.Value
    mPrestamo.Presta_ValorSolicitado = Me.txtvalorsolic.Value
    mPrestamo.Presta_ValorCuota = Me.txtcuota.Value
    mPrestamo.Presta_Motivo = Me.txtmotivo.Text
    mPrestamo.Presta_Urgente = Me.chkurgente.Checked
    mPrestamo.Presta_esAprobado = Me.chkaprobado.Checked
    mPrestamo.PardetTipoPrestamo = Me.cbotipoprestamo.ParametroDet

    mPrestamo.Presta_FechaAprobacion = Me.dtfecaprobacion.Value
    mPrestamo.Presta_ValorAprobado = Me.txtvaloraprob.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mPrestamo.EsNuevo
    If mPrestamo.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mPrestamo.Contrato.Empleado.NombreCompleto)

      Return True
    Else
      'Prestamos.CancelEdit()
      MsgBox("No se puede guardar Préstamo" & Environment.NewLine & mContrato.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoPrestamo_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPrestamo.Eliminar() AndAlso Prestamos.Current IsNot Nothing Then
      Prestamos.RemoveCurrent()
      Me.Close()
    Else
      'Prestamos.CancelEdit()
      MsgBox("No se puede eliminar Prestamo" & Environment.NewLine & mContrato.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoPrestamo_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPrestamo_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPrestamo_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPrestamo_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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

  Private Sub chkaprobado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkaprobado.CheckedChanged
    Me.pnlaprobado.Visible = Me.chkaprobado.Checked
    If Me.chkaprobado.Checked And Me.txtvaloraprob.Value = 0 Then
      Me.txtvaloraprob.Value = Me.txtvalorsolic.Value
    End If
  End Sub
End Class
