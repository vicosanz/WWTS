Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmPeriodo
  Implements IMantenimiento

  Public Property PardetPeriodoPago() As WWTSParametroDet
    Get
      Return Me.ComboBoxParametroDet1.ParametroDet
    End Get
    Set(ByVal value As WWTSParametroDet)
      ComboBoxParametroDet1.ParametroDet = value
    End Set
  End Property

  Private mPeriodoPago As PeriodoPago
  Public Property PeriodoPago() As PeriodoPago
    Get
      Return mPeriodoPago
    End Get
    Set(ByVal Value As PeriodoPago)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Periodo Pago")
      End If
      mPeriodoPago = Value
      Me.ComboBoxParametroDet1.OperadorDatos = Value.OperadorDatos
      Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.PeriodoPago
      Me.ComboBoxParametroDet1.Llenar_Datos()

      Me.comboMes.DataSource = Enumerados.MesesdelAnioList
      Me.comboMes.DisplayMember = "Descripcion"
      Me.comboMes.ValueMember = "Numero"

      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not PeriodoPago Is Nothing Then
      ComboBoxParametroDet1.ParametroDet = PeriodoPago.PardetPeriodoPago
      Me.dtfecdesde.Value = PeriodoPago.PerPag_FechaDesde
      Me.dtfechasta.Value = PeriodoPago.PerPag_FechaHasta
      Me.dtfecpago.Value = PeriodoPago.PerPag_FechaPago
      Me.chk_pagado.Checked = PeriodoPago.PerPag_esPagado
      Me.chkesQuincena.Checked = PeriodoPago.PerPag_esQuincena
      Me.comboMes.SelectedValue = PeriodoPago.PerPag_mes
      Me.txt_anio.Value = PeriodoPago.PerPag_anio
      Me.dtmarcaciondesde.Value = PeriodoPago.PerPag_FechaDesdeMarcacion
      Me.dtmarcacionhasta.Value = PeriodoPago.PerPag_FechaHastaMarcacion
    End If
    Me.ComboBoxParametroDet1.Enabled = Direccion = IMantenimiento.Accion.Ingreso
    Me.dtfecdesde.Enabled = Direccion = IMantenimiento.Accion.Ingreso
    Me.dtfechasta.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtfecpago.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chk_pagado.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkesQuincena.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.comboMes.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txt_anio.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtmarcaciondesde.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.dtmarcacionhasta.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          PeriodoPago.PardetPeriodoPago = ComboBoxParametroDet1.ParametroDet
          PeriodoPago.PerPag_FechaDesde = dtfecdesde.Value
          PeriodoPago.PerPag_FechaHasta = dtfechasta.Value
          PeriodoPago.PerPag_FechaPago = Me.dtfecpago.Value
          PeriodoPago.PerPag_esPagado = Me.chk_pagado.Checked
          PeriodoPago.PerPag_esQuincena = Me.chkesQuincena.Checked
          PeriodoPago.PerPag_mes = Me.comboMes.SelectedValue
          PeriodoPago.PerPag_anio = Me.txt_anio.Value
          PeriodoPago.PerPag_FechaDesdeMarcacion = dtmarcaciondesde.Value
          PeriodoPago.PerPag_FechaHastaMarcacion = dtmarcacionhasta.Value
          If Not PeriodoPago.Guardar() Then
            Throw New Exception(PeriodoPago.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not PeriodoPago.Eliminar() Then
            Throw New Exception(PeriodoPago.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
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
#End Region

End Class
