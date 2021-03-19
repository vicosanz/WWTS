Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoBeneficioVacacion
  Implements IMantenimiento

  Private mVacacion As BeneficiosSociales
  Public Property Vacacion() As BeneficiosSociales
    Get
      Return mVacacion
    End Get
    Set(value As BeneficiosSociales)
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
    Set(value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Private mtemporal As Decimal
  Public Property temporal() As Decimal
    Get
      Return mtemporal
    End Get
    Set(value As Decimal)
      mtemporal = value
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not Vacacion Is Nothing Then
      Me.dtfechadesde.Value = Vacacion.BenSoc_FechaDesde
      Me.dtfechahasta.Value = Vacacion.BenSoc_FechaHasta

      txtValorFinal.Value = txtValorVacacion.Value '- txtAporte935.Value
      temporal = txtValorFinal.Value
    End If
    'Me.dtfechadesde.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.dtfechahasta.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.dtPeriodoPagoDesde.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.ComboBoxPeriodoPago.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
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

  Private Sub FrmMantenimientoBeneficioVacacion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    CtlPeriodo1.Op = Sistema.OperadorDatos
    CtlPeriodo1.PardetPeriodoPago = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.PeriodoPago, Enumerados.enumPeriodoPago.Mensual)
    CtlPeriodo1.llenar_datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoLicencia_AntesAceptar(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion

          If temporal.ToString("0.00") <> Me.txtValorFinal.Value Then
            If String.IsNullOrWhiteSpace(Me.txtObservacion.Text.Trim()) Then
              MsgBox("Debe ingresar una observación", MsgBoxStyle.Information, "Error")
              txtObservacion.Select()
              e.Cancel = True
              Exit Sub
            End If
          End If

          Sistema.OperadorDatos.ComenzarTransaccion()

          Dim mRubro As Rubro = New Rubro(Sistema.OperadorDatos, True)
          mRubro.Contrato = Vacacion.Contrato
          mRubro.Parame_TipoRubro = Enumerados.EnumParametros.TipoRubro
          mRubro.Pardet_TipoRubro = Enumerados.enumTipoRubroComplementosNomina.Vacacion
          mRubro.Rubro_EnQuincena = 0
          mRubro.Rubro_EnFindeMes = Me.txtValorFinal.Value
          mRubro.Rubro_esInfinito = False
          mRubro.Rubro_ValorTope = Me.txtValorFinal.Value
          mRubro.Rubro_GravaIESS = True
          mRubro.Rubro_FechaDesde = CtlPeriodo1.PeriodoPago.PerPag_FechaDesde
          mRubro.Rubro_Activo = True
          mRubro.Rubro_VacacionSecuencia = Vacacion.BenSoc_Secuencia
          mRubro.Rubro_GoceVacaciones = Me.checkgocevacaciones.Checked

          If Not mRubro.Guardar() Then
            Throw New Exception(mRubro.OperadorDatos.MsgError)
          End If

          'Dim mrubrodet As RubroDet = New RubroDet(mRubro)
          'mRubroDet.RubDet_Observacion = Me.txtObservacion.Text
          'mrubrodet.RubDet_Valor = Me.txtValorFinal.Value
          'mrubrodet.PerPag_FechaDesde = CtlPeriodo1.PeriodoPago.PerPag_FechaDesde
          'mrubrodet.PardetPeriodoPago = CtlPeriodo1.PeriodoPago.PardetPeriodoPago
          'mrubrodet.PardetTipoPeriodoPago = New WWTSParametroDet(mRubro.OperadorDatos, Enumerados.EnumParametros.TipoPeriodoPago, Enumerados.enumTipoPeriodoPago.FindeMes)
          'mRubroDet.RubDet_Fecha = Now.Date
          'mrubrodet.PardetTipoRubro = mRubro.PardetTipoRubro

          Vacacion.BenSoc_Liquidado = True
          Vacacion.PerPag_FechaDesde = CtlPeriodo1.PeriodoPago.PerPag_FechaDesde
          Vacacion.PardetPeriodoPago = CtlPeriodo1.PeriodoPago.PardetPeriodoPago
          Vacacion.BenSoc_Valor = Me.txtValorFinal.Value
          Vacacion.BenSoc_GoceVacaciones = Me.checkgocevacaciones.Checked
          If Vacacion.BenSoc_GoceVacaciones Then
            Vacacion.BenSoc_FechaDesdeGoceVacaciones = Me.dtfechadesdegocevaca.Value
            Vacacion.BenSoc_FechaHastaGoceVacaciones = Me.dtfechahastagocevaca.Value
          End If
          Vacacion.Guardar()

          RubroDet.UpdatePeriodoVacacion(Vacacion)

          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{3}.{4}.{5} {0} Rubro {2} {1} de {6}", IIf(mRubro.EsNuevo, "Creó", "Modificó"), mRubro.Contrato.EmpleadoString, mRubro.PardetTipoRubroString, mRubro.Contrato.Entida_Codigo, mRubro.Contrato.Patron_Codigo, mRubro.Contrato.Contra_Secuencia, mRubro.Rubro_EnFindeMes.ToString("0.00")))

          Sistema.OperadorDatos.TerminarTransaccion()

        Case IMantenimiento.Accion.Eliminacion
          'If Not Vacacion.Eliminar() Then
          '  Throw New Exception(Vacacion.OperadorDatos.MsgError)
          'End If
      End Select
    Catch ex As Exception
      Sistema.OperadorDatos.CancelarTransaccion()
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub checkgocevacaciones_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkgocevacaciones.CheckedChanged
    If checkgocevacaciones.Checked Then
      PnlGoceVacaciones.Visible = True
    Else
      PnlGoceVacaciones.Visible = False
    End If
  End Sub
End Class