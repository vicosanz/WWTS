Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmRubrosxCentroCosto

  Private mRubrosxCentroCosto As RubrosxCentroCosto = Nothing
  Public Property RubrosxCentroCosto() As RubrosxCentroCosto
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(value As RubrosxCentroCosto)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each mRubrosxCentroCosto As RubrosxCentroCosto In Me.ListBindingSource.DataSource
          If mRubrosxCentroCosto.Pardet_CentroCosto = value.Pardet_CentroCosto And mRubrosxCentroCosto.Pardet_Rubro = value.Pardet_Rubro Then
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
  Private Sub FrmRubrosxCentroCosto_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmRubrosxCentroCosto_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmRubrosxCentroCosto_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoRubrosxCentroCosto(Sistema, Restriccion)
    f.RubrosxCentroCosto = ListBindingSource.Current
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
    RefrescarLista()
  End Sub

  Private Sub FrmRubrosxCentroCosto_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmRubrosxCentroCosto_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmRubrosxCentroCosto_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(ListBindingSource.Current, RubrosxCentroCosto).Eliminar() Then
      MsgBox("Error al eliminar" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    RefrescarLista()
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mRubrosxCentroCostoList As RubrosxCentroCostoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "rubros por centro de costo"
    MyBase.AgregarLeyenda = "Agregar un nuevo rubro por centro de costo"

    mRubrosxCentroCostoList = RubrosxCentroCostoList.ObtenerLista(Sistema.OperadorDatos, cboCentroCosto.ParametroDet)
    'Dim mitemssort As New Infoware.Reglas.SortedView(mTestSeleccionList)
    ListBindingSource.DataSource = mRubrosxCentroCostoList 'mitemssort
    DataGridView1.AutoDiscover()
  End Sub

  Private Sub mRubrosxCentroCostoList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mRubrosxCentroCostoList.AddingNew
    Dim mRubrosxCentroCosto As RubrosxCentroCosto = New RubrosxCentroCosto(Sistema.OperadorDatos, True)
    e.NewObject = mRubrosxCentroCosto
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

  Private Sub FrmRubrosxCentroCosto_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cboCentroCosto.OperadorDatos = Sistema.OperadorDatos
    Me.cboCentroCosto.Parametro = Enumerados.EnumParametros.GrupoContable
    Me.cboCentroCosto.Llenar_Datos()
    Llenar_datos()
  End Sub

  Private Sub cboCentroCosto_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.CambioItem
    Llenar_datos()
  End Sub
End Class