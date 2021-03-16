Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmLlamadaAtencion
  Implements IMantenimiento

  Private mLlamadaAtencion As LlamadaAtencion
  Public Property LlamadaAtencion() As LlamadaAtencion
    Get
      Return mLlamadaAtencion
    End Get
    Set(ByVal Value As LlamadaAtencion)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un LlamadaAtencion")
      End If
      mLlamadaAtencion = Value
      Me.cbotipollamado.OperadorDatos = Value.OperadorDatos
      Me.cbotipollamado.Parametro = Enumerados.EnumParametros.TipoLlamado
      Me.cbotipollamado.Llenar_Datos()

      Me.cbogravedadllamado.OperadorDatos = Value.OperadorDatos
      Me.cbogravedadllamado.Parametro = Enumerados.EnumParametros.GravedadLLamdo
      Me.cbogravedadllamado.Llenar_Datos()
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
    If Not LlamadaAtencion Is Nothing Then
      Me.dtfecha.Value = LlamadaAtencion.Llamad_Fecha
      Me.cbotipollamado.ParametroDet = LlamadaAtencion.PardetTipoLlamado
      Me.txtdescripcion.Text = LlamadaAtencion.Llamad_Descripcion
      Me.cbogravedadllamado.ParametroDet = LlamadaAtencion.PardetGravedadLlamado
      Me.chcksancionado.Checked = LlamadaAtencion.Llamad_Sancionado
    End If
    Me.dtfecha.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.cbotipollamado.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txtdescripcion.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.cbogravedadllamado.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.chcksancionado.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = LlamadaAtencion.EsNuevo
          LlamadaAtencion.Llamad_Fecha = Me.dtfecha.Value
          LlamadaAtencion.PardetTipoLlamado = Me.cbotipollamado.ParametroDet
          LlamadaAtencion.Llamad_Descripcion = Me.txtdescripcion.Text
          LlamadaAtencion.PardetGravedadLlamado = Me.cbogravedadllamado.ParametroDet
          LlamadaAtencion.Llamad_Sancionado = Me.chcksancionado.Checked
          If Not LlamadaAtencion.Guardar() Then
            Throw New Exception(LlamadaAtencion.OperadorDatos.MsgError)
          End If
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{3}.{4}.{5} {0} Llamado atención {1} {2}", IIf(esnuevo, "Creó", "Modificó"), LlamadaAtencion.Contrato.EmpleadoString, LlamadaAtencion.PardetTipoLlamadoString, LlamadaAtencion.Contrato.Entida_Codigo, LlamadaAtencion.Contrato.Patron_Codigo, LlamadaAtencion.Contrato.Contra_Secuencia))
        Case IMantenimiento.Accion.Eliminacion
          If Not LlamadaAtencion.Eliminar() Then
            Throw New Exception(LlamadaAtencion.OperadorDatos.MsgError)
          End If
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("Eliminó Llamado atención {0} {1}", LlamadaAtencion.Contrato.EmpleadoString, LlamadaAtencion.PardetTipoLlamadoString))
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

  Private Sub cbotipollamado_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotipollamado.CambioItem
    If mLlamadaAtencion.EsNuevo Then
      Me.txtdescripcion.Text = Me.cbotipollamado.ParametroDet.Pardet_DatoStr1
    End If
  End Sub
End Class
