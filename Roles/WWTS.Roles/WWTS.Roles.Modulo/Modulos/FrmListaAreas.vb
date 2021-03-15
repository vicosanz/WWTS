Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmListaAreas
  Private mArea As Area = Nothing
  Public Property Area() As Area
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Area)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Area As Area In Me.ListBindingSource.DataSource
          If _Area.Pardet_Departamento = value.Pardet_Departamento And _Area.Pardet_Area = value.Pardet_Area Then
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
  Private Sub FrmListaAreas_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaAreas_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaAreas_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoArea(Sistema, Restriccion)
    f.Areas = ListBindingSource
    f.cboseccion.ParametroDet = Me.ComboBoxSeccion.ParametroDet
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
    Llenar_datos()
  End Sub

  Private Sub FrmListaAreas_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaAreas_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaAreas_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mAreas Is Nothing Then
      Exit Sub
    End If
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Dim mArea As Area
    mArea = ListBindingSource.Current
    If mArea.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Area" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
    RefrescarLista()
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mAreas As AreaList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Asignación de áreas a secciones"
    MyBase.AgregarLeyenda = "Agregar una nueva Asignación de área a sección"

    If Me.ComboBoxSeccion.ParametroDet Is Nothing Then
      Exit Sub
    End If

    Me.ListBindingSource.DataSource = GetType(Area)

    mAreas = AreaList.ObtenerLista(Sistema.OperadorDatos, Me.ComboBoxSeccion.ParametroDet, IIf(checkDepartamento.Checked, Me.ComboBoxDepartamento.ParametroDet, Nothing), _filtro)

    'Dim mitemssort As New Infoware.Reglas.SortedView(mAreas)
    'ListBindingSource.DataSource = mitemssort
    ListBindingSource.DataSource = mAreas
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mAreas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mAreas.AddingNew
    Dim _Area As Area = New Area(Sistema.OperadorDatos, True)
    e.NewObject = _Area
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

  Private Sub FrmListaAreas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.ComboBoxSeccion.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxSeccion.Parametro = Enumerados.EnumParametros.Seccion
    Me.ComboBoxSeccion.Llenar_Datos()

    Me.ComboBoxDepartamento.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxDepartamento.Parametro = Enumerados.EnumParametros.Departamento
    Me.ComboBoxDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, ComboBoxSeccion.ParametroDet)
    Llenar_datos()
  End Sub

  Private Sub ComboBoxSeccion_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSeccion.CambioItem
    Me.ComboBoxDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, ComboBoxSeccion.ParametroDet)
    Llenar_datos()
  End Sub

  Private Sub checkDepartamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkDepartamento.CheckedChanged
    If checkDepartamento.Checked Then
      Me.ComboBoxDepartamento.Enabled = True
    Else
      Me.ComboBoxDepartamento.Enabled = False
    End If
    Llenar_datos()
  End Sub

  Private Sub ComboBoxDepartamento_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDepartamento.CambioItem
    Llenar_datos()
  End Sub

  Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.AreasCargos)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "REPR_Personal$Organigrama")
    f.Valores = New Object() {Sistema.Usuario.Usuari_Codigo, ComboBoxSeccion.ParametroDet.Pardet_Secuencia, 1}
    f.Show()
  End Sub
End Class
