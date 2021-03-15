Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmTestxArea

  Private mSeleccion As Seleccion = Nothing
  Public Property Seleccion() As Seleccion
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Seleccion)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Seleccion As Seleccion In Me.ListBindingSource.DataSource
          If _Seleccion.Selecc_Codigo = value.Selecc_Codigo Then
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
  Private Sub FrmTestSeleccion_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    'Abrir_Mantenimiento()
  End Sub

  Private Sub FrmTestSeleccion_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmTestSeleccion_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoTestxArea(Sistema, Restriccion)
    f.TestSeleccion = ListBindingSource.Current
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
    RefrescarLista()
  End Sub

  Private Sub FrmTestSeleccion_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmTestSeleccion_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmTestSeleccion_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(ListBindingSource.Current, TestxArea).Eliminar() Then
      MsgBox("Error al eliminar" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    RefrescarLista()
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mTestSeleccionList As TestxAreaList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "test por área"
    MyBase.AgregarLeyenda = "Agregar un nuevo test a un área"

    mTestSeleccionList = TestxAreaList.ObtenerLista(Sistema.OperadorDatos, cboarea.ParametroDet, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mTestSeleccionList)
    ListBindingSource.DataSource = mitemssort
    DataGridView1.AutoDiscover()
  End Sub

  Private Sub mTestSeleccionList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mTestSeleccionList.AddingNew
    Dim _TestSeleccion As TestxArea = New TestxArea(Sistema.OperadorDatos, True)
    e.NewObject = _TestSeleccion
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion, _busqueda)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda)
  End Sub
#End Region

  Private Sub FrmTestSeleccion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cboarea.OperadorDatos = Sistema.OperadorDatos
    Me.cboarea.Parametro = Enumerados.EnumParametros.Area
    Me.cboarea.Llenar_Datos()
    Llenar_datos()
  End Sub

  Private Sub cboarea_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboarea.CambioItem
    Llenar_datos()
  End Sub
End Class