Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoVacacion
  Implements IMantenimiento

  Private mVacacion As BeneficiosSociales
  Public Property Vacacion() As BeneficiosSociales
    Get
      Return mVacacion
    End Get
    Set(ByVal Value As BeneficiosSociales)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Vacacion")
      End If
      mVacacion = Value
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not Vacacion Is Nothing Then
      Me.dtfechadesde.Value = Vacacion.BenSoc_FechaDesde
      Me.dtfechahasta.Value = Vacacion.BenSoc_FechaHasta
      Me.txtDias.Value = Vacacion.BenSoc_Dias
      Me.chckLiquidado.Checked = Vacacion.BenSoc_Liquidado
      If chckLiquidado.Checked Then
        Me.dtPeriodoPagoDesde.Value = Vacacion.PerPag_FechaDesde
        Me.ComboBoxPeriodoPago.ParametroDet = Vacacion.PardetPeriodoPago
        Me.checkgocevacaciones.Checked = Vacacion.BenSoc_GoceVacaciones
        If checkgocevacaciones.Checked Then
          Me.dtfechadesdegocevaca.Value = Vacacion.BenSoc_FechaDesdeGoceVacaciones
          Me.dtfechahastagocevaca.Value = Vacacion.BenSoc_FechaHastaGoceVacaciones
        Else
          Me.dtfechadesdegocevaca.Value = Date.Now
          Me.dtfechahastagocevaca.Value = Date.Now
        End If
      Else
        Me.dtPeriodoPagoDesde.Value = Date.Now
      End If
      Me.txtValor.Value = Vacacion.BenSoc_Valor
    End If
    Me.dtfechadesde.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtfechahasta.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtDias.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.chckLiquidado.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtPeriodoPagoDesde.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.ComboBoxPeriodoPago.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub

  Private Sub FrmMantenimientoVacacion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    ComboBoxPeriodoPago.OperadorDatos = Sistema.OperadorDatos
    ComboBoxPeriodoPago.Parametro = Enumerados.EnumParametros.PeriodoPago
    ComboBoxPeriodoPago.Llenar_Datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoLicencia_AntesAceptar(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = Vacacion.EsNuevo
          Vacacion.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
          Vacacion.Pardet_TipoBeneficioEnum = Enumerados.enumTipoBeneficio.Vacaciones
          Vacacion.BenSoc_FechaDesde = Me.dtfechadesde.Value
          Vacacion.BenSoc_FechaHasta = Me.dtfechahasta.Value
          If dtfechadesde.Value > dtfechahasta.Value Then
            MsgBox("Fecha desde no puede ser mayor que fecha hasta", MsgBoxStyle.Information, "Error")
            e.Cancel = True
            Exit Sub
          End If
          Vacacion.BenSoc_Dias = Me.txtDias.Value
          Vacacion.BenSoc_Liquidado = Me.chckLiquidado.Checked
          If Vacacion.BenSoc_Liquidado Then
            Vacacion.PerPag_FechaDesde = Me.dtPeriodoPagoDesde.Value
            Vacacion.PardetPeriodoPago = Me.ComboBoxPeriodoPago.ParametroDet
            Vacacion.BenSoc_GoceVacaciones = Me.checkgocevacaciones.Checked
            If Vacacion.BenSoc_GoceVacaciones Then
              Vacacion.BenSoc_FechaDesdeGoceVacaciones = Me.dtfechadesdegocevaca.Value
              Vacacion.BenSoc_FechaHastaGoceVacaciones = Me.dtfechahastagocevaca.Value
            End If
          Else
            Vacacion.BenSoc_GoceVacaciones = True
          End If
          Vacacion.BenSoc_Valor = Me.txtValor.Value
          If Not Vacacion.Guardar() Then
            Throw New Exception(Vacacion.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Vacacion.Eliminar() Then
            Throw New Exception(Vacacion.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub chckLiquidado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckLiquidado.CheckedChanged
    If chckLiquidado.Checked Then
      PnlLiquidado.Visible = True
    Else
      PnlLiquidado.Visible = False
    End If
  End Sub

  Private Sub checkgocevacaciones_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkgocevacaciones.CheckedChanged
    If checkgocevacaciones.Checked Then
      PnlGoceVacaciones.Visible = True
    Else
      PnlGoceVacaciones.Visible = False
    End If
  End Sub

  Private Sub FrmMantenimientoVacacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class