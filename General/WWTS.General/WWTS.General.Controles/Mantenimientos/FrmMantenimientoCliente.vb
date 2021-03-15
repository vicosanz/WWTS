Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmMantenimientoCliente
  '#Region "IOpcion"
  '  Private mOperadorDatos As OperadorDatos = Nothing
  '  Public Property OperadorDatos() As OperadorDatos
  '    Get
  '      Return mOperadorDatos
  '    End Get
  '    Set(ByVal value As OperadorDatos)
  '      mOperadorDatos = value
  '      MyBase.Tabla = "Cliente"

  '      Me.ComboBoxTipoPrecio.Parametro = Enumerados.EnumParametros.TipoPrecio
  '      Me.ComboBoxTipoPrecio.Op = value
  '      Me.ComboBoxTipoPrecio.Llenar_Datos()

  '      Me.CtlBuscaEmpleado1.OperadorDatos = value

  '    End Set
  '  End Property
  '#End Region

#Region "Parametros"
  Public Property Clientes() As BindingSource
    Get
      Return MyBase.ListBindingSource
    End Get
    Set(ByVal value As BindingSource)
      MyBase.ListBindingSource = value
      llenar_datos()
    End Set
  End Property

  Private mCliente As Cliente = Nothing
  Public Property Cliente() As Cliente
    Get
      Return mCliente
    End Get
    Set(ByVal value As Cliente)
      mCliente = value
      If MyBase.ListBindingSource.DataSource Is Nothing Then
        Dim _clientes As New ClienteList
        _clientes.Add(mCliente)
        MyBase.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Cliente)
        MyBase.ListBindingSource.DataSource = _clientes
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mCliente = Clientes.Current
    Me.CtlPersona1.Entidad = mCliente.Entidad
    Me.CtlBuscaEmpleado1.Empleado = mCliente.Empleado
    Me.chk_formapago.Checked = mCliente.PardetFormaPago IsNot Nothing
    Me.ComboBoxFormaPago.ParametroDet = mCliente.PardetFormaPago
    Me.chk_tipoprecio.Checked = mCliente.PardetTipoPrecio IsNot Nothing
    Me.ComboBoxTipoPrecio.ParametroDet = mCliente.PardetTipoPrecio
  End Sub

  Sub Llenar_detallesListaPrecios()
    Me.DGListaPrecios.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "ItemString",
      .HeaderText = "Item",
      .ReadOnly = True,
      .Width = 380
    }
    DGListaPrecios.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "IteTip_Valor",
      .HeaderText = "Valor",
      .Width = 60
    }
    Dim estilonum2 As New DataGridViewCellStyle With {
      .Format = "N2"
    }
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    DGListaPrecios.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.BindingSourceListaPrecios.DataSource = GetType(ItemxTipoPrecioList)
    'mMovimientoInventarioDets = 
    BindingSourceListaPrecios.DataSource = ItemxTipoPrecioList.ObtenerLista(ComboBoxTipoPrecio.ParametroDet, mSucursal)
  End Sub

#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoCliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mCliente.EsNuevo
    If _esnuevo AndAlso Clientes.Current IsNot Nothing Then
      Clientes.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Clientes eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _cliente As Cliente = New Cliente(Sistema.OperadorDatos, True)
    e.NewObject = _cliente
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoCliente_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    Me.CtlPersona1.Mapear_datos()
    mCliente.Empleado = Me.CtlBuscaEmpleado1.Empleado
    If Me.chk_tipoprecio.Checked Then
      mCliente.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet
    Else
      mCliente.PardetTipoPrecio = Nothing
    End If
    If Me.chk_formapago.Checked Then
      mCliente.PardetFormaPago = Me.ComboBoxFormaPago.ParametroDet
    Else
      mCliente.PardetFormaPago = Nothing
    End If
    Me.DGListaPrecios.EndEdit()
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mCliente.EsNuevo
    If mCliente.Guardar() Then
      If chk_tipoprecio.Checked Then
        For Each itp As ItemxTipoPrecio In Me.BindingSourceListaPrecios.DataSource
          If itp.EsModificado Then
            itp.Guardar()
          End If
        Next
      End If
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mCliente.NombreCompleto)

      Return True
    Else
      'Clientes.CancelEdit()
      MsgBox("No se puede guardar cliente" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoCliente_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mCliente.Eliminar() AndAlso Clientes.Current IsNot Nothing Then
      Clientes.RemoveCurrent()
      Me.Close()
    Else
      'Clientes.CancelEdit()
      MsgBox("No se puede eliminar cliente" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoCliente_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoCliente_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoCliente_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoCliente_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

  Private Sub chk_tipoprecio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tipoprecio.CheckedChanged
    Me.ComboBoxTipoPrecio.Enabled = Me.chk_tipoprecio.Checked
  End Sub

  Private Sub chk_formapago_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_formapago.CheckedChanged
    Me.ComboBoxFormaPago.Enabled = Me.chk_formapago.Checked
  End Sub

#Region "New"
  Private mSucursal As Sucursal
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    mSucursal = _Sucursal
    Me.CtlPersona1.PuedeElegirTipoEntidad = True
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal)
  End Sub

  Private Sub FrmMantenimientoCliente_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Cliente"

    Me.ComboBoxTipoPrecio.Parametro = Enumerados.EnumParametros.TipoPrecio
    Me.ComboBoxTipoPrecio.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipoPrecio.Llenar_Datos()

    Me.ComboBoxFormaPago.Parametro = Enumerados.EnumParametros.TipoFormaPago
    Me.ComboBoxFormaPago.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxFormaPago.Llenar_Datos()

    Me.CtlBuscaEmpleado1.OperadorDatos = Sistema.OperadorDatos
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

  Private Sub ComboBoxTipoPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoPrecio.SelectedIndexChanged

  End Sub

  Private Sub ComboBoxTipoPrecio_CambioItem(sender As Object, e As EventArgs) Handles ComboBoxTipoPrecio.CambioItem, chk_tipoprecio.CheckedChanged
    grplistaprecios.Visible = Me.chk_tipoprecio.Checked
    If Me.chk_tipoprecio.Checked Then
      Llenar_detallesListaPrecios()
    End If
  End Sub
End Class
