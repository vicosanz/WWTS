Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class CtlBuscaEmpleado
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(value As OperadorDatos)
      mOp = value
    End Set
  End Property

  Public Event CambioEmpleado As EventHandler
  Public Event BotonAtras As EventHandler

  Private mEmpleado As Empleado = Nothing
  Public ReadOnly Property Empleado() As Empleado
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
  End Property

  'Private Sub seleccionarnodo(ByVal node As TreeNode, ByVal value As Empleado)
  '  While Not node Is Nothing
  '    If TypeOf node.Tag Is Empleado Then
  '      Dim mPer As Empleado
  '      mPer = node.Tag

  '      If mPer.Entida_Codigo = value.Entida_Codigo Then
  '        tv.SelectedNode = node
  '        node.EnsureVisible()
  '      End If
  '    End If
  '    If node.GetNodeCount(False) > 0 Then
  '      seleccionarnodo(node.Nodes(0), value)
  '    End If
  '    node = node.NextNode
  '  End While
  'End Sub

  Public Sub llenar_datos()
    Retornar_Empleados()
    'Me.lblstatus.Text = "."
    'If mEmpleados IsNot Nothing Then
    '  Me.lblstatus.Text = mEmpleados.Count.ToString.Trim & " Empleados encontradas"
    'End If
    Me.tv.Columns.Clear()

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Seleccionado"
    'DataGridViewTextBoxColumn0.HeaderText = ""
    'DataGridViewTextBoxColumn0.Width = 20
    'Me.tv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    DataGridViewTextBoxColumn1.HeaderText = "Nombre del empleado"
    DataGridViewTextBoxColumn1.Width = 250
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.tv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Empleado)
    Dim mitemssort As New Infoware.Reglas.SortedView(mEmpleados)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Dim mEmpleados As EmpleadoList

  Public Sub Retornar_Empleados()
    mEmpleados = EmpleadoList.ObtenerLista(Op, Me.txtnombre.Text, Me.txtcodigo.Value, Me.txtcedula.Text, Me.txtedad.Value, Me.cbomayorque.SelectedIndex = 0, chkficharoja.CheckState)
    'RaiseEvent CambioEmpleado()
  End Sub

  Private Sub ListBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBindingSource.CurrentChanged
    RaiseEvent CambioEmpleado(Me, Nothing)
  End Sub

  Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    Me.llenar_datos()
  End Sub

  Private Sub CtlBuscaEmpleado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cbomayorque.SelectedIndex = 0
  End Sub

  Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
    RaiseEvent BotonAtras(Me, Nothing)
  End Sub
End Class
