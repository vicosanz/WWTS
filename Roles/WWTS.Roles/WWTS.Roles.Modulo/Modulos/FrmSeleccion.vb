Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmSeleccion

  Private mSeleccion As Seleccion = Nothing
  Public Property Seleccion() As Seleccion
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(value As Seleccion)
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
    Set(value As String)
      MyBase.combobuscar.Text = value
      MyBase.Hacer_busqueda()
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmSeleccion_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmSeleccion_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmSeleccion_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New WWTS.Roles.Controles.FrmMantenimientoSeleccion(Sistema, Restriccion) With {
      .Seleccions = ListBindingSource
    }
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
    Llenar_datos()
  End Sub

  Private Sub FrmSeleccion_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmSeleccion_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmSeleccion_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(ListBindingSource.Current, Seleccion).Eliminar() Then
      MsgBox("Error al eliminar" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    RefrescarLista()
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mSeleccionList As SeleccionList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    If (Sistema Is Nothing) Then
      Exit Sub
    End If
    MyBase.Titulo = "selección"
    MyBase.AgregarLeyenda = "Agregar una nueva selección"

    ListBindingSource.DataSource = GetType(Seleccion)
    mSeleccionList = SeleccionList.ObtenerLista(Sistema.OperadorDatos, IIf(CheckBoxStd1.Checked, True, False), IIf(CheckBoxStd2.Checked, False, True), _filtro)
    ListBindingSource.DataSource = mSeleccionList
    DataGridView1.AutoDiscover()
  End Sub

  Private Sub mSeleccionList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mSeleccionList.AddingNew
    Dim _Seleccion As Seleccion = New Seleccion(Sistema.OperadorDatos, True)
    e.NewObject = _Seleccion
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

  Private Sub FrmSeleccion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Llenar_datos()
  End Sub

  Private Sub CheckBoxStd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStd1.CheckedChanged
    Llenar_datos()
  End Sub

  Private Sub CheckBoxStd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStd2.CheckedChanged
    Llenar_datos()
  End Sub
End Class