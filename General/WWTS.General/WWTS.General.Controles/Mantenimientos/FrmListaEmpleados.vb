Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmListaEmpleados
#Region "IOpcion"
  Private mOperadorDatos As OperadorDatos = Nothing
  Public WriteOnly Property OperadorDatos() As OperadorDatos
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      If value IsNot Nothing Then
        Llenar_datos()
      End If
    End Set
  End Property
#End Region

  Private mEmpleado As Empleado = Nothing
  Public Property Empleado() As Empleado
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Empleado)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Empleado As Empleado In Me.ListBindingSource.DataSource
          If _Empleado.Entida_Codigo = value.Entida_Codigo Then
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
  Private Sub FrmListaEmpleados_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaEmpleados_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaEmpleados_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoEmpleado(Sistema, Restriccion)
    'f.OperadorDatos = mOperadorDatos
    f.Empleados = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaEmpleados_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaEmpleados_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaEmpleados_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mEmpleados Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mEmpleado As Empleado
    mEmpleado = ListBindingSource.Current
    If mEmpleado.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Empleado" & Environment.NewLine & mOperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

#End Region

#Region "Llenardatos"
  Private WithEvents mEmpleados As EmpleadoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Empleados"
    MyBase.AgregarLeyenda = "Agregar un nuevo Empleado"

    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Emplea_Visible"
    DataGridViewTextBoxColumn0.HeaderText = "Activo"
    DataGridViewTextBoxColumn0.Width = 50
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    DataGridViewTextBoxColumn1.HeaderText = "Nombre de Empleado"
    DataGridViewTextBoxColumn1.Width = 250
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "TipoEmpleadoString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo de empleado"
    DataGridViewTextBoxColumn1.Width = 125
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DireccionesString"
    DataGridViewTextBoxColumn1.HeaderText = "Direcci�n"
    DataGridViewTextBoxColumn1.Width = 250
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "TelefonosString"
    DataGridViewTextBoxColumn1.HeaderText = "Tel�fono"
    DataGridViewTextBoxColumn1.Width = 250
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Empleado)
    mEmpleados = EmpleadoList.ObtenerLista(mOperadorDatos, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mEmpleados)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mEmpleados_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mEmpleados.AddingNew
    Dim _Empleado As Empleado = New Empleado(mOperadorDatos, True)
    e.NewObject = _Empleado
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
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region
End Class
