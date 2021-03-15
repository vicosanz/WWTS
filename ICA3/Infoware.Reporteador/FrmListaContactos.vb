Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System.Windows.Forms

Public Class FrmListaContactos
  Private mContacto As Contacto = Nothing
  Public Property Contacto() As Contacto
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Contacto)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Contacto As Contacto In Me.ListBindingSource.DataSource
          If _Contacto.Correo = value.Correo Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public Function CorreosSeleccionados() As CorreosElectronicos
    Dim _oresult As New CorreosElectronicos
    For Each _contacto As Contacto In mContactos
      If _contacto.Seleccionado Then
        _oresult.Add(New CorreoElectronico(_contacto.Correo))
      End If
    Next
    Return _oresult
  End Function

#Region "Eventos"
  Private Sub FrmListaContactos_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaContactos_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaContactos_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mContactos As ContactoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Contactos"
    MyBase.AgregarLeyenda = ""

    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoCompteString"
    'DataGridViewTextBoxColumn1.HeaderText = "Tipo comprobante"
    'DataGridViewTextBoxColumn1.Width = 200
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "MovCtb_Secuencia"
    'DataGridViewTextBoxColumn1.HeaderText = "Número"
    'DataGridViewTextBoxColumn1.Width = 80
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "MovCtb_Fecha"
    'DataGridViewTextBoxColumn1.HeaderText = "Fecha"
    'DataGridViewTextBoxColumn1.Width = 100
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "MovCtb_Observacion"
    'DataGridViewTextBoxColumn1.HeaderText = "Observación"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim DataGridViewCheckBoxColumn1 As New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewCheckBoxColumn1.DataPropertyName = "MovCtb_esMayorizado"
    'DataGridViewCheckBoxColumn1.HeaderText = "Mayorizado"
    'DataGridViewCheckBoxColumn1.Width = 80
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewCheckBoxColumn1})

    Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    Me.DataGridView1.MultiSelect = True

    Me.ListBindingSource.DataSource = GetType(Contacto)
    mContactos = ContactoList.ObtenerLista(mReporte, mCorreos, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mContactos)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Sub Mayorizar(ByVal _estado As Boolean)
    If Me.DataGridView1.SelectedRows.Count > 0 Then

      For Each _fila As DataGridViewRow In Me.DataGridView1.SelectedRows
        Dim _movcon As Contacto
        _movcon = CType(Me.DataGridView1.DataSource(_fila.Index), Contacto)
        _movcon.Seleccionado = _estado
      Next
    End If
    'Me.DataGridView1.Refresh()
    Me.DataGridView1.Invalidate()
  End Sub
#End Region

#Region "New"
  Private mReporte As Reporte = Nothing
  Private mCorreos As CorreosElectronicos = Nothing

  Public Property Reporte As Reporte
    Get
      Return mReporte
    End Get
    Set(value As Reporte)
      mReporte = value
    End Set
  End Property

  Public Property Correos As CorreosElectronicos
    Get
      Return mCorreos
    End Get
    Set(value As CorreosElectronicos)
      mCorreos = value
    End Set
  End Property

  Private Sub FrmListaContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.PuedeNuevo = False
    Me.PuedeEliminar = False

    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False

    Llenar_datos()
  End Sub

#End Region

  Private Sub FrmListaContactos_AplicarRestricciones(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AplicarRestricciones
    Me.btnmayorizar.Enabled = Restriccion.Restri_VerConfidencial
    Me.btndemayorizar.Enabled = Restriccion.Restri_VerConfidencial
  End Sub

  Private Sub btnconciliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmayorizar.Click
    Mayorizar(True)
  End Sub

  Private Sub btndeconciliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndemayorizar.Click
    Mayorizar(False)
  End Sub


End Class
