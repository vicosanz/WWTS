Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmListaClientes
  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      Llenar_datos()
    End Set
  End Property

  Private mCliente As Cliente = Nothing
  Public Property Cliente() As Cliente
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Cliente)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Cliente As Cliente In Me.ListBindingSource.DataSource
          If _Cliente.Entida_Codigo = value.Entida_Codigo Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public Property Filtro() As String
    Get
      Return MyBase.combobuscar.Text
    End Get
    Set(ByVal value As String)
      MyBase.combobuscar.Text = value
      MyBase.Hacer_busqueda()
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaClientes_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaClientes_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaClientes_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoCliente(Sistema, Restriccion, mSucursal) With {
      .Clientes = ListBindingSource
    }
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaClientes_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaClientes_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaClientes_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mClientes Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mcliente As Cliente
    mcliente = ListBindingSource.Current
    If mcliente.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar cliente" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

#End Region

#Region "Llenardatos"
  Private WithEvents mClientes As ClienteList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Clientes"
    MyBase.AgregarLeyenda = "Agregar un nuevo cliente"

    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Client_Visible"
    'DataGridViewTextBoxColumn0.HeaderText = "Activo"
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    'DataGridViewTextBoxColumn1.HeaderText = "Nombre de Cliente"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "DireccionesString"
    'DataGridViewTextBoxColumn1.HeaderText = "Dirección"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TelefonosString"
    'DataGridViewTextBoxColumn1.HeaderText = "Teléfono"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Cliente)
    mClientes = ClienteList.ObtenerLista(Sistema.OperadorDatos, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mClientes)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mClientes_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mClientes.AddingNew
    Dim _cliente As Cliente = New Cliente(Sistema.OperadorDatos, True)
    e.NewObject = _cliente
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion, _busqueda)
    AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
    FrmListaClientes_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda)
  End Sub

  Private Sub FrmListaClientes_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
    Llenar_datos()
  End Sub
#End Region

  Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    If DesignMode Then
      Exit Sub
    End If
    If e.ColumnIndex = -1 Or e.ColumnIndex <> 0 Or e.RowIndex = -1 Then
      Me.btnmostrar.Visible = False
      Me.ToolTipImage1.Hide(Me.btnmostrar)
      Exit Sub
    End If
    Me.btnmostrar.Visible = True
    Dim rec As Rectangle = Me.DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
    Me.btnmostrar.Location = New Point(e.Location.X + rec.X + Me.DataGridView1.Location.X, e.Location.Y + rec.Y + DataGridView1.Location.Y)

    Dim _Cliente As Cliente
    '_item = mItems(e.RowIndex)
    _Cliente = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)
    Me.ToolTipImage1.SetToolTipImageTitle(Me.btnmostrar, "Cliente")
    Me.ToolTipImage1.SetToolTipImageImage(Me.btnmostrar, _Cliente.Entidad.Entida_Imagen(100))
    Me.ToolTipImage1.SetToolTipImageText(Me.btnmostrar, _Cliente.NombreCompleto)
    'Me.ToolTipImage1.SetToolTipImageIcon(Me.btnmostrar, _item.PardetGrupo.Pardet_Imagen(25))
    Me.ToolTipImage1.Show("Descripción", Me.btnmostrar)
  End Sub

End Class
