Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoLicencia
  Implements IMantenimiento

  Private mLicencia As Licencia
  Public Property Licencia() As Licencia
    Get
      Return mLicencia
    End Get
    Set(ByVal Value As Licencia)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Licencia")
      End If
      mLicencia = Value
      Me.ComboBoxLicencia.OperadorDatos = Value.OperadorDatos
      Me.ComboBoxLicencia.Parametro = Enumerados.EnumParametros.Licencia
      Me.ComboBoxLicencia.Llenar_Datos()
      Me.CtlVacacion1.Op = Value.OperadorDatos
      Me.CtlVacacion1.Contrato = Value.Contrato
      Me.CtlVacacion1.llenar_datos()
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
    If Not Licencia Is Nothing Then
      Me.ComboBoxLicencia.ParametroDet = Licencia.PardetLicencia
      Me.dtfechadesde.Value = Licencia.Licenc_Desde
      Me.dtfechahasta.Value = Licencia.Licenc_Hasta
      Me.chckFechafin.Checked = Licencia.esCerrado
      If Me.chckFechafin.Checked Then
        Label2.Visible = True
        dtfechahasta.Visible = True
      End If
      If Licencia.esVacacion Then
        chckFechafin.Enabled = False
        chckaprobado.Checked = Licencia.Licenc_VacacionAprobado
        pnlvacacion.Visible = Licencia.esVacacion
        Dim _vacacion As New BeneficiosSociales(Licencia.OperadorDatos, Licencia.Contrato, Enumerados.EnumParametros.Beneficio, Enumerados.enumTipoBeneficio.Vacaciones, Licencia.BenSoc_Secuencia, False, Now.Date, Now.Date)
        Me.CtlVacacion1.Vacacion = _vacacion
      End If
      If Licencia.PardetAdjuntoLicencia Is Nothing Then
        Licencia.PardetAdjuntoLicencia = New WWTSParametroDet(Licencia.OperadorDatos, Enumerados.EnumParametros.Adjuntos, True)
      End If
      Me.CtlAdjunto1.ParameAdjunto = Licencia.PardetAdjuntoLicencia
    End If

    Me.ComboBoxLicencia.Enabled = Licencia.EsNuevo
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

  Private Sub chckFechafin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckFechafin.CheckedChanged
    If chckFechafin.Checked Then
      Label2.Visible = True
      dtfechahasta.Visible = True
    Else
      Label2.Visible = False
      dtfechahasta.Visible = False
    End If
  End Sub

  Private Sub FrmMantenimientoLicencia_AntesAceptar(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = Licencia.EsNuevo
          Licencia.PardetLicencia = Me.ComboBoxLicencia.ParametroDet
          Licencia.Licenc_Desde = Me.dtfechadesde.Value
          Licencia.esCerrado = Me.chckFechafin.Checked
          If Licencia.esCerrado Then
            Licencia.Licenc_Hasta = Me.dtfechahasta.Value
            If dtfechadesde.Value > dtfechahasta.Value Then
              MsgBox("Fecha desde no puede ser mayor que fecha hasta", MsgBoxStyle.Information, "Error")
              e.Cancel = True
              Exit Sub
            End If
          End If
          Licencia.esVacacion = Me.pnlvacacion.Visible
          If Licencia.esVacacion Then
            'If dtfechadesde.Value < CtlVacacion1.Vacacion.BenSoc_FechaDesde Or dtfechahasta.Value < CtlVacacion1.Vacacion.BenSoc_FechaDesde Or dtfechadesde.Value > CtlVacacion1.Vacacion.BenSoc_FechaHasta Or dtfechahasta.Value > CtlVacacion1.Vacacion.BenSoc_FechaHasta Then
            '  MsgBox("Error en la fecha", MsgBoxStyle.Information, "Error")
            '  e.Cancel = True
            '  Exit Sub
            'End If
            Licencia.Licenc_VacacionAprobado = chckaprobado.Checked
            Licencia.Parame_TipoBeneficio = Enumerados.EnumParametros.Beneficio
            Licencia.Pardet_TipoBeneficio = Enumerados.enumTipoBeneficio.Vacaciones
            Licencia.BenSoc_Secuencia = Me.CtlVacacion1.Vacacion.BenSoc_Secuencia
          End If
          Licencia.PardetAdjuntoLicencia = Me.CtlAdjunto1.ParameAdjunto
          If Not Licencia.Guardar() Then
            Throw New Exception(Licencia.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Licencia.Eliminar() Then
            Throw New Exception(Licencia.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub ComboBoxLicencia_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxLicencia.CambioItem
    If ComboBoxLicencia.ParametroDet.Pardet_Secuencia = Enumerados.enumLicencia.Vacaciones Then
      pnlvacacion.Visible = True
      chckFechafin.Checked = True
      chckFechafin.Enabled = False
      chckaprobado.Visible = True
    Else
      pnlvacacion.Visible = False
      chckFechafin.Checked = False
      chckFechafin.Enabled = True
      chckaprobado.Visible = False
    End If
  End Sub

  Private Sub CtlVacacion1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CtlVacacion1.SelectedIndexChanged

  End Sub
End Class