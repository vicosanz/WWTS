Imports WWTS.Roles.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmRubroDet

#Region "Parametros"
  Public Property RubroDetList() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mRubroDet As RubroDet = Nothing
  Public Property RubroDet() As RubroDet
    Get
      Return mRubroDet
    End Get
    Set(ByVal value As RubroDet)
      mRubroDet = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _RubroDets As New RubroDetList
        _RubroDets.Add(mRubroDet)
        MyBase.ListBindingSource.DataSource = GetType(RubroDet)
        MyBase.ListBindingSource.DataSource = _RubroDets
      End If
    End Set
  End Property

  Private mRubro As Rubro = Nothing
  Public Property Rubro() As Rubro
    Get
      Return mRubro
    End Get
    Set(ByVal value As Rubro)
      mRubro = value
    End Set
  End Property

  Private mGuardarEnMemoria As Boolean = False
  Public Property GuardarEnMemoria() As Boolean
    Get
      Return mGuardarEnMemoria
    End Get
    Set(ByVal value As Boolean)
      mGuardarEnMemoria = value
    End Set
  End Property

  Private mtemporal As Decimal
  Public Property temporal() As Decimal
    Get
      Return mtemporal
    End Get
    Set(ByVal value As Decimal)
      mtemporal = value
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    mRubroDet = RubroDetList.Current
    If mrubrodet Is Nothing Then
      Exit Sub
    End If
    Me.txtValor.Value = mRubroDet.RubDet_Valor
    temporal = mRubroDet.RubDet_Valor
    Try
      Me.dtPeriodoPagofecha.Value = mRubroDet.PerPag_FechaDesde
    Catch ex As Exception
      Me.dtPeriodoPagofecha.Value = Now.Date
    End Try

    Me.ComboBoxPeriodoPago.ParametroDet = mRubroDet.PardetPeriodoPago
    Me.ComboBoxTipoPeriodoPago.ParametroDet = mRubroDet.PardetTipoPeriodoPago
    Me.txtObservacion.Text = mRubroDet.RubDet_Observacion
    Me.dtRubDetfecha.Value = mRubroDet.RubDet_Fecha
    Me.txtCantidad.Value = mRubroDet.RubDet_Cantidad
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmRubroDet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mRubroDet.EsNuevo
    If _esnuevo AndAlso RubroDetList.Current IsNot Nothing Then
      RubroDetList.RemoveCurrent()
    End If
    Return _esnuevo
  End Function

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub
#End Region

#Region "Eventos"
  Private Sub FrmRubroDet_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _RubroDet As RubroDet = New RubroDet(Sistema.OperadorDatos, True)
    e.NewObject = _RubroDet
  End Sub

  Private Sub FrmRubroDet_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmRubroDet_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private valor As Decimal
  Private Sub Mapear_datos()
    valor = RubroDet.RubDet_Valor
    mRubroDet.RubDet_Valor = Me.txtValor.Value
    mRubroDet.PerPag_FechaDesde = Me.dtPeriodoPagofecha.Value
    mRubroDet.PardetPeriodoPago = Me.ComboBoxPeriodoPago.ParametroDet
    mRubroDet.PardetTipoPeriodoPago = Me.ComboBoxTipoPeriodoPago.ParametroDet
    mRubroDet.RubDet_Observacion = Me.txtObservacion.Text
    mRubroDet.RubDet_Fecha = Me.dtRubDetfecha.Value
    If Not GuardarEnMemoria Then
      mRubroDet.PardetTipoRubro = Me.RubroDet.Rubro.PardetTipoRubro
    End If
    mRubroDet.RubDet_Cantidad = Me.txtCantidad.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Dim _esnuevo As Boolean = mRubroDet.EsNuevo
    If GuardarEnMemoria Then
      If temporal.ToString("0.00") <> Me.txtValor.Value Then
        If String.IsNullOrWhiteSpace(Me.txtObservacion.Text.Trim()) Then
          MsgBox("Debe ingresar una observación", MsgBoxStyle.Information, "Error")
          txtObservacion.Select()
          Return False
        End If
      End If
    End If

    Mapear_datos()

    If Not GuardarEnMemoria Then
      If mRubroDet.Guardar() Then
        Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{3}.{4}.{5} {0} RubroDetalle {2} {1} de {6} a {7}", IIf(_esnuevo, "Creó", "Modificó"), RubroDet.Rubro.Contrato.EmpleadoString, RubroDet.Rubro.PardetTipoRubroString, RubroDet.Rubro.Contrato.Entida_Codigo, RubroDet.Rubro.Contrato.Patron_Codigo, RubroDet.Rubro.Contrato.Contra_Secuencia, valor.ToString("0.00"), RubroDet.RubDet_Valor.ToString("0.00")))
        Return True
      Else
        MsgBox("No se puede guardar el detalle de rubro" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        Return False
      End If
    Else
      Return True
    End If
  End Function

  Private Sub FrmRubroDet_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If RubroDetList.Current IsNot Nothing AndAlso mRubroDet.Eliminar() Then
      If RubroDetList.Count > 1 Then
        RubroDetList.RemoveCurrent()
      End If
      Me.Close()
    Else
      MsgBox("No se puede eliminar el detalle de rubro" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmRubroDet_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmRubroDet_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmRubroDet_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmRubroDet_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

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

  Private Sub FrmRubroDet_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    'MyBase.Tabla = ""

    Me.PuedeGuardar = True

    Me.ComboBoxPeriodoPago.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxPeriodoPago.Parametro = Enumerados.EnumParametros.PeriodoPago
    Me.ComboBoxPeriodoPago.Llenar_Datos()

    Me.ComboBoxTipoPeriodoPago.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipoPeriodoPago.Parametro = Enumerados.EnumParametros.TipoPeriodoPago
    Me.ComboBoxTipoPeriodoPago.Llenar_Datos()
  End Sub
#End Region

  Public Sub RestriccionesQuincena()
    Me.PuedeGuardaryNuevo = False
    Me.dtPeriodoPagofecha.Enabled = False
    Me.ComboBoxPeriodoPago.Enabled = False
    Me.ComboBoxTipoPeriodoPago.Enabled = False
    Me.dtRubDetfecha.Enabled = False
  End Sub

End Class