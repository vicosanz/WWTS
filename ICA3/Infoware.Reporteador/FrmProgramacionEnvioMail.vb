Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System.Windows.Forms

Public Class FrmProgramacionEnvioMail

  Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdodiario.CheckedChanged, rdosemanal.CheckedChanged, rdomensual.CheckedChanged
    Me.grpdiario.Visible = Me.rdodiario.Checked
    Me.grpmensual.Visible = Me.rdomensual.Checked
    Me.grpsemanal.Visible = Me.rdosemanal.Checked
  End Sub

#Region "New"
  Dim mReporte As Reporte
  Public Property Reporte As Reporte
    Get
      Return mReporte
    End Get
    Set(value As Reporte)
      mReporte = value
    End Set
  End Property

  Private Sub FrmProgramacionEnvioMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  End Sub

  Private Sub FrmProgramacionEnvioMail_AplicarRestricciones(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AplicarRestricciones
    Me.Tabla = "Programación"
    Me.txtemails.Text = mReporte.RetornarEmailLista
    Programacion = mReporte.RetornarEmailProgramacion
    Correos = CorreosElectronicos.destring(mReporte.RetornarEmailLista)
  End Sub
#End Region

  Private mProgramacion As New Programacion
  Public Property Programacion() As Programacion
    Get
      Return mProgramacion
    End Get
    Set(ByVal value As Programacion)
      mProgramacion = value
      llenar_datos()
    End Set
  End Property

  Sub llenar_datos()
    Me.rdodiario.Checked = mProgramacion.Sucede = Reporteador.Programacion.enumSucede.Diario
    Me.rdomensual.Checked = mProgramacion.Sucede = Reporteador.Programacion.enumSucede.Mensual
    Me.rdosemanal.Checked = mProgramacion.Sucede = Reporteador.Programacion.enumSucede.Semanal
    If rdodiario.Checked Then
      Me.numdiariocada.Value = mProgramacion.SucedeCada
    ElseIf rdosemanal.Checked Then
      Me.numsemanalcada.Value = mProgramacion.SucedeCada
    Else
      Me.nummensualcada.Value = mProgramacion.SucedeCada
    End If

    Me.chksemanallun.Checked = mProgramacion.SucedeSemanalLunes
    Me.chksemanalmar.Checked = mProgramacion.SucedeSemanalMartes
    Me.chksemanalmie.Checked = mProgramacion.SucedeSemanalMiercoles
    Me.chksemanaljue.Checked = mProgramacion.SucedeSemanalJueves
    Me.chksemanalvie.Checked = mProgramacion.SucedeSemanalViernes
    Me.chksemanalsab.Checked = mProgramacion.SucedeSemanalSabado
    Me.chksemanaldom.Checked = mProgramacion.SucedeSemanalDomingo

    Me.rdomensualeldia.Checked = mProgramacion.MensualTipo = Reporteador.Programacion.enumMensualTipo.eldia
    Me.rdomensualelprimer.Checked = mProgramacion.MensualTipo = Reporteador.Programacion.enumMensualTipo.primer

    Me.nummensualdia.Value = mProgramacion.Mensualeldia
    Me.cbomensualorden.SelectedIndex = mProgramacion.MensualSemana
    Me.cbomensualdiasemana.SelectedIndex = mProgramacion.MensualDiaSemana

    Me.rdofrecuenciaunavez.Checked = mProgramacion.FrecuenciaTipo = Reporteador.Programacion.enumFrecuenciaTipo.unavez
    Me.rdofrecuenciasucedecada.Checked = mProgramacion.FrecuenciaTipo = Reporteador.Programacion.enumFrecuenciaTipo.cada
    Me.dtfrecuenciaalas.Value = mProgramacion.FrecuenciaHora
    Me.numfrecuenciacada.Value = IIf(mProgramacion.FrecuenciaHoras > 0, mProgramacion.FrecuenciaHoras, mProgramacion.FrecuenciaMinutos)
    Me.cbofrecuenciacadatipo.SelectedIndex = IIf(mProgramacion.FrecuenciaHoras > 0 Or mProgramacion.FrecuenciaMinutos = 0, 0, 1)
    Me.dtfrecuenciacadadesde.Value = mProgramacion.FrecuenciaHoraInicio
    Me.dtfrecuenciacadahasta.Value = mProgramacion.FrecuenciaHoraFin

    Me.dtduracionfechadesde.Value = mProgramacion.DuracionFechaInicio
    Me.dtduracionfechahasta.Checked = Not mProgramacion.DuracionFechaFin = Nothing
    If Not mProgramacion.DuracionFechaFin = Nothing Then
      Me.dtduracionfechahasta.Value = mProgramacion.DuracionFechaFin
    End If
    Me.chklisto.Checked = mProgramacion.Listo
  End Sub

  Sub mapear_datos()
    If Me.rdodiario.Checked Then
      mProgramacion.Sucede = Reporteador.Programacion.enumSucede.Diario
    End If
    If Me.rdomensual.Checked Then
      mProgramacion.Sucede = Reporteador.Programacion.enumSucede.Mensual
    End If
    If Me.rdosemanal.Checked Then
      mProgramacion.Sucede = Reporteador.Programacion.enumSucede.Semanal
    End If

    If rdodiario.Checked Then
      mProgramacion.SucedeCada = Me.numdiariocada.Value
    ElseIf rdosemanal.Checked Then
      mProgramacion.SucedeCada = Me.numsemanalcada.Value
    Else
      mProgramacion.SucedeCada = Me.nummensualcada.Value
    End If

    mProgramacion.SucedeSemanalLunes = Me.chksemanallun.Checked
    mProgramacion.SucedeSemanalMartes = Me.chksemanalmar.Checked
    mProgramacion.SucedeSemanalMiercoles = Me.chksemanalmie.Checked
    mProgramacion.SucedeSemanalJueves = Me.chksemanaljue.Checked
    mProgramacion.SucedeSemanalViernes = Me.chksemanalvie.Checked
    mProgramacion.SucedeSemanalSabado = Me.chksemanalsab.Checked
    mProgramacion.SucedeSemanalDomingo = Me.chksemanaldom.Checked

    If Me.rdomensualeldia.Checked Then
      mProgramacion.MensualTipo = Reporteador.Programacion.enumMensualTipo.eldia
    End If
    If Me.rdomensualelprimer.Checked Then
      mProgramacion.MensualTipo = Reporteador.Programacion.enumMensualTipo.primer
    End If

    mProgramacion.Mensualeldia = Me.nummensualdia.Value
    mProgramacion.MensualSemana = Me.cbomensualorden.SelectedIndex
    mProgramacion.MensualDiaSemana = Me.cbomensualdiasemana.SelectedIndex

    If Me.rdofrecuenciaunavez.Checked Then
      mProgramacion.FrecuenciaTipo = Reporteador.Programacion.enumFrecuenciaTipo.unavez
    End If
    If Me.rdofrecuenciasucedecada.Checked Then
      mProgramacion.FrecuenciaTipo = Reporteador.Programacion.enumFrecuenciaTipo.cada
    End If

    mProgramacion.FrecuenciaHora = Me.dtfrecuenciaalas.Value
    mProgramacion.FrecuenciaMinutos = Me.numfrecuenciacada.Value * IIf(Me.cbofrecuenciacadatipo.SelectedIndex = 0, 60, 1)
    mProgramacion.FrecuenciaHoraInicio = Me.dtfrecuenciacadadesde.Value
    mProgramacion.FrecuenciaHoraFin = Me.dtfrecuenciacadahasta.Value

    mProgramacion.DuracionFechaInicio = Me.dtduracionfechadesde.Value
    mProgramacion.DuracionFechaFin = IIf(Me.dtduracionfechahasta.Checked, Me.dtduracionfechahasta.Value, Nothing)
    mProgramacion.Listo = Me.chklisto.Checked
  End Sub

  Private Sub FrmProgramacionEnvioMail_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Guardar
    Try
      mapear_datos()
      mReporte.GuardarEmailProgramacion(mProgramacion)
      mProgramacion.ResetProximoEnvio()
      mReporte.GuardarEmailLista(Me.txtemails.Text)
      Me.Close()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private mCorreos As New CorreosElectronicos
  Public Property Correos() As CorreosElectronicos
    Get
      Return mCorreos
    End Get
    Set(ByVal value As CorreosElectronicos)
      mCorreos = value
      Me.txtemails.Text = mCorreos.astring
    End Set
  End Property

  Private Sub btnbuscarcorreos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarcorreos.Click
    Dim f As New FrmListaContactos With {
      .Sistema = Sistema,
      .Restriccion = Restriccion,
      .Reporte = Reporte,
      .Correos = Correos,
      .EsBusqueda = True
    }
    f.ShowDialog()
    Correos = f.CorreosSeleccionados
  End Sub

End Class