Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas

Public Class FrmReclutamiento

  Private mEmpleado As Empleado = Nothing
  Public Property Empledo() As Empleado
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(value As Empleado)
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
    Set(value As String)
      MyBase.combobuscar.Text = value
      MyBase.Hacer_busqueda()
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmReclutamiento_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmReclutamiento_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmReclutamiento_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New WWTS.General.Controles.FrmMantenimientoEmpleado(Sistema, Restriccion)
    f.Empleados = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
    RefrescarLista()
  End Sub

  Private Sub FrmReclutamiento_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmReclutamiento_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmReclutamiento_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(ListBindingSource.Current, Empleado).Eliminar() Then
      MsgBox("Error al eliminar" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    RefrescarLista()
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mEmpleadoList As EmpleadoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Reclutamiento"
    MyBase.AgregarLeyenda = "Agregar un nuevo candidato"

    Me.ListBindingSource.DataSource = GetType(EmpleadoList)
    If chckAspiracionSalarial.Checked Then
      mEmpleadoList = EmpleadoList.ObtenerPersonasReclutamiento(Sistema.OperadorDatos, cboArea.ParametroDet, IIf(chckSectorDomicilio.Checked, cboSectorDomicilio.ParametroDet, Nothing), txtAspSaldesde.Value, txtAspSalhasta.Value, IIf(chckGenero.Checked, cboGenero.ParametroDet, Nothing), txtNivelAcademico.Value, _filtro)
    Else
      mEmpleadoList = EmpleadoList.ObtenerPersonasReclutamiento(Sistema.OperadorDatos, cboArea.ParametroDet, IIf(chckSectorDomicilio.Checked, cboSectorDomicilio.ParametroDet, Nothing), Nothing, Nothing, IIf(chckGenero.Checked, cboGenero.ParametroDet, Nothing), txtNivelAcademico.Value, _filtro)
    End If

    'Dim mitemssort As New Infoware.Reglas.SortedView(mEmpleadoList)
    ListBindingSource.DataSource = mEmpleadoList 'mitemssort

    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "Entida_Codigo",
      .HeaderText = "Código",
      .Width = 50
    }
    Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "NombreCompleto",
      .HeaderText = "Nombre Completo",
      .Width = 250
    }
    Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "TelefonosString",
      .HeaderText = "Teléfono",
      .Width = 100
    }
    Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "CiudadDomicilioString",
      .HeaderText = "Ciudad Domicilio",
      .Width = 100
    }
    Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "SectorDomicilioString",
      .HeaderText = "Sector Domicilio",
      .Width = 75
    }
    Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn With {
      .DataPropertyName = "EstadoActualString",
      .HeaderText = "Estado Actual",
      .Width = 250
    }
    Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})

  End Sub

  Private Sub mEmpleadoList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mEmpleadoList.AddingNew
    Dim _Empleado As Empleado = New Empleado(Sistema.OperadorDatos, True)
    e.NewObject = _Empleado
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

  Private Sub FrmReclutamiento_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cboArea.OperadorDatos = Sistema.OperadorDatos
    Me.cboArea.Parametro = Enumerados.EnumParametros.Area
    Me.cboArea.Llenar_Datos()

    Me.cboSectorDomicilio.OperadorDatos = Sistema.OperadorDatos
    Me.cboSectorDomicilio.Parametro = Enumerados.EnumParametros.SectorDomicilio
    Me.cboSectorDomicilio.Llenar_Datos()

    Me.cboGenero.OperadorDatos = Sistema.OperadorDatos
    Me.cboGenero.Parametro = Enumerados.EnumParametros.Sexo
    Me.cboGenero.Llenar_Datos()

    Llenar_datos()
  End Sub

  Private Sub cboarea_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.CambioItem
    Llenar_datos()
  End Sub

  Private Sub checksector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckSectorDomicilio.CheckedChanged
    If chckSectorDomicilio.Checked Then
      Me.cboSectorDomicilio.Enabled = True
    Else
      Me.cboSectorDomicilio.Enabled = False
    End If
    Llenar_datos()
  End Sub

  Private Sub cboSectorDomicilio_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSectorDomicilio.CambioItem
    Llenar_datos()
  End Sub

  Private Sub checkAspiracionSalarial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckAspiracionSalarial.CheckedChanged
    If chckAspiracionSalarial.Checked Then
      Me.txtAspSaldesde.Enabled = True
      Me.txtAspSalhasta.Enabled = True
    Else
      Me.txtAspSaldesde.Enabled = False
      Me.txtAspSalhasta.Enabled = False
    End If
    Llenar_datos()
  End Sub

  Private Sub txtdesde_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAspSaldesde.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        Llenar_datos()
      Case Else
        e.Handled = False
    End Select
  End Sub

  Private Sub txthasta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAspSalhasta.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        Llenar_datos()
      Case Else
        e.Handled = False
    End Select
  End Sub

  Private Sub chckGenero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckGenero.CheckedChanged
    If chckGenero.Checked Then
      Me.cboGenero.Enabled = True
    Else
      Me.cboGenero.Enabled = False
    End If
    Llenar_datos()
  End Sub

  Private Sub cboGenero_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGenero.CambioItem
    Llenar_datos()
  End Sub

  Private Sub txtNivelAcademico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNivelAcademico.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        If txtNivelAcademico.Value > 2 Then
          MsgBox("El nivel debe ser entre 0 y 2" + Chr(13) + "0 : Todos" + Chr(13) + "1 : mínimo Bachilleres" + Chr(13) + "2 : mínimo Título Universitario", MsgBoxStyle.Information, "Información")
        Else
          Llenar_datos()
        End If
      Case Else
        e.Handled = False
    End Select
  End Sub
End Class
