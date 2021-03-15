Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmRubro
  Implements IMantenimiento

  Private mRubro As Rubro
  Public Property Rubro() As Rubro
    Get
      Return mRubro
    End Get
    Set(ByVal Value As Rubro)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Rubro")
      End If
      mRubro = Value
      Me.cborubro.OperadorDatos = Value.OperadorDatos
      Me.cborubro.Parametro = Enumerados.EnumParametros.TipoRubro
      Me.cborubro.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, mParametro)

      Refrescar_forma()
    End Set
  End Property

  Private mParametro As WWTSParametroDet
  Public Property Parametro() As WWTSParametroDet
    Get
      Return mParametro
    End Get
    Set(ByVal value As WWTSParametroDet)
      mParametro = value
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
    If Not Rubro Is Nothing Then
      Me.cborubro.ParametroDet = Rubro.PardetTipoRubro
      Me.txtquincena.Value = Rubro.Rubro_EnQuincena
      Me.txtfindemes.Value = Rubro.Rubro_EnFindeMes
      Me.chckesinfinito.Checked = Rubro.Rubro_esInfinito
      If Me.chckesinfinito.Checked Then
        Me.txtvalortope.Enabled = False
      End If
      Me.txtvalortope.Value = Rubro.Rubro_ValorTope
      Me.chckgravaiess.Checked = Rubro.Rubro_GravaIESS
      Me.dtfecdesde.Value = Rubro.Rubro_FechaDesde
      Me.chckactivo.Checked = Rubro.Rubro_Activo
      Me.txtObservacion.Text = Rubro.Rubro_Observacion
    End If

    Me.cborubro.Enabled = Rubro.EsNuevo
    Me.chckgravaiess.Checked = Me.cborubro.ParametroDet.Pardet_DatoBit1
    MostrarImprimirPrestamo()
  End Sub

  Private Sub FrmRubro_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If Not Guardar() Then
            e.Cancel = True
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Rubro.Eliminar() Then
            Throw New Exception(Rubro.OperadorDatos.MsgError)
          End If
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("Eliminó Rubro {0} {1}", Rubro.Contrato.EmpleadoString, Rubro.PardetTipoRubroString))
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Function Guardar() As Boolean
    Dim esnuevo As Boolean = Rubro.EsNuevo
    Dim total As Decimal = Rubro.Total
    Rubro.PardetTipoRubro = Me.cborubro.ParametroDet
    Rubro.Rubro_EnQuincena = Me.txtquincena.Value
    Rubro.Rubro_EnFindeMes = Me.txtfindemes.Value
    Rubro.Rubro_esInfinito = Me.chckesinfinito.Checked
    Rubro.Rubro_ValorTope = Me.txtvalortope.Value
    Rubro.Rubro_GravaIESS = Me.chckgravaiess.Checked
    Rubro.Rubro_FechaDesde = Me.dtfecdesde.Value
    Rubro.Rubro_Activo = Me.chckactivo.Checked
    Rubro.Rubro_Observacion = Me.txtObservacion.Text
    If Rubro.Rubro_FechaDesde < Rubro.Contrato.Contra_Desde Then
      MsgBox("Error en la fecha", MsgBoxStyle.Information, "Error")
      Return False
    End If
    If Not Rubro.Rubro_esInfinito Then
      If VerificarValorTope(Rubro.Rubro_EnQuincena, Rubro.Rubro_EnFindeMes, Rubro.Rubro_ValorTope) Then
        MsgBox("Error en el Valor Tope", MsgBoxStyle.Information, "Error")
        Return False
      End If
    End If
    If Not Rubro.Guardar() Then
      Throw New Exception(Rubro.OperadorDatos.MsgError)
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{3}.{4}.{5} {0} Rubro {2} {1} de {6} a {7}", IIf(esnuevo, "Creó", "Modificó"), Rubro.Contrato.EmpleadoString, Rubro.PardetTipoRubroString, Rubro.Contrato.Entida_Codigo, Rubro.Contrato.Patron_Codigo, Rubro.Contrato.Contra_Secuencia, total.ToString("0.00"), Rubro.Total.ToString("0.00")))
    Return True
  End Function

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

  Private Sub checkesinfinito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckesinfinito.CheckedChanged
    If Me.chckesinfinito.Checked Then
      Me.txtvalortope.Enabled = False
      Me.txtvalortope.Value = 0
    Else
      Me.txtvalortope.Enabled = True
    End If
  End Sub

  Private Sub cborubro_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cborubro.CambioItem
    If Me.cborubro.ParametroDet Is Nothing Then
      Exit Sub
    End If
    If (Me.cborubro.ParametroDet.Pardet_Secuencia = Enumerados.enumTipoRubroNoDefinidoContrato.PrestamoPersonal OrElse Me.cborubro.ParametroDet.Pardet_Secuencia = Enumerados.enumTipoRubroNoDefinidoContrato.Anticipos) Then
      chckesinfinito.Checked = False
      chckesinfinito.Enabled = False
      If Rubro.EsNuevo Then
        chckactivo.Checked = False
      Else
        chckactivo.Checked = Rubro.Rubro_Activo
      End If
    Else
      chckesinfinito.Enabled = True
      chckactivo.Checked = Rubro.Rubro_Activo
    End If
    Me.chckgravaiess.Checked = Me.cborubro.ParametroDet.Pardet_DatoBit1
    Label10.Text = Me.cborubro.ParametroDet.Pardet_DatoDec1.ToString("0.00")
    MostrarImprimirPrestamo()
  End Sub

  Private Function VerificarValorTope(ByVal _valor1 As Integer, ByVal _valor2 As Integer, ByVal _valor3 As Integer) As Boolean
    If (_valor1 + _valor2) > _valor3 Then
      Return True
    End If
    Return False
  End Function

  Private Sub chckactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chckactivo.CheckedChanged
    MostrarImprimirPrestamo()
  End Sub

  Sub MostrarImprimirPrestamo()
    Me.pnlPrestamo.Visible = Not Me.chckactivo.Checked AndAlso (Me.cborubro.ParametroDet.Pardet_Secuencia = Enumerados.enumTipoRubroNoDefinidoContrato.PrestamoPersonal OrElse Me.cborubro.ParametroDet.Pardet_Secuencia = Enumerados.enumTipoRubroNoDefinidoContrato.Anticipos)
  End Sub

  Private Sub btnImprSolicitud_Click(sender As System.Object, e As System.EventArgs) Handles btnImprSolicitud.Click
    Guardar()
    Dim f As New FrmSolicPrestamo(Sistema, Restriccion)
    f.Rubro = Rubro
    f.ShowDialog()
  End Sub

End Class
