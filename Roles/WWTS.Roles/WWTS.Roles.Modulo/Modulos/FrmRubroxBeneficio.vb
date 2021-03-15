Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Consola.Base


Public Class FrmRubroxBeneficio

#Region "Llenardatos"
  Private WithEvents mRubrosxBeneficioList As RubroxBeneficioList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Tabla = "Rubros por beneficio"

    If Me.ComboBoxBeneficios.ParametroDet Is Nothing Then
      Exit Sub
    End If

    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetRubroString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo Rubro"
    DataGridViewTextBoxColumn1.Width = 150
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewCheckBoxColumn1.DataPropertyName = "RubBen_Activo"
    DataGridViewCheckBoxColumn1.HeaderText = "Activo"
    DataGridViewCheckBoxColumn1.Width = 50
    DataGridViewCheckBoxColumn1.ReadOnly = False
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewCheckBoxColumn1})

    mRubrosxBeneficioList = RubroxBeneficioList.ObtenerLista(Sistema.OperadorDatos, Me.ComboBoxBeneficios.ParametroDet, _filtro)
    ListBindingSource.DataSource = mRubrosxBeneficioList
  End Sub

  Private Sub mRubrosxBeneficioList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mRubrosxBeneficioList.AddingNew
    Dim _RubrosxBeneficio As RubroxBeneficio = New RubroxBeneficio(Sistema.OperadorDatos, True)
    e.NewObject = _RubrosxBeneficio
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoEmpleado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Return True
  End Function
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmRubrosxBeneficio_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    DataGridView1.EndEdit()
    Sistema.OperadorDatos.ComenzarTransaccion()
    Try
      For Each _RubroxBeneficio As RubroxBeneficio In ListBindingSource
        If Not _RubroxBeneficio.Guardar() Then
          Throw New Exception(_RubroxBeneficio.OperadorDatos.MsgError)
        End If
      Next
      Sistema.OperadorDatos.TerminarTransaccion()

      For Each _RubroxBeneficio As RubroxBeneficio In ListBindingSource
        _RubroxBeneficio.AceptarCambios()
      Next

      Return True
    Catch ex As Exception
      Sistema.OperadorDatos.CancelarTransaccion()
      MsgBox("No se puede guardar" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoEmpleado_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoEmpleado_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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

  Private Sub FrmRubrosxBeneficio_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.PuedeMover = False
    Me.PuedeGuardar = True
    Me.PuedeNuevo = False
    Me.PuedeEliminar = False
    Me.PuedeGuardaryNuevo = False

    Me.ComboBoxBeneficios.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxBeneficios.Parametro = Enumerados.EnumParametros.Beneficio
    Me.ComboBoxBeneficios.Llenar_Datos()

    Llenar_datos()

  End Sub
#End Region

  Private Sub FrmRubrosxBeneficio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.ListBindingSource = Nothing
  End Sub

  Private Sub ComboBoxBeneficios_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxBeneficios.CambioItem
    Llenar_datos()
  End Sub

End Class