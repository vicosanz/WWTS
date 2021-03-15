Imports Infoware.Reglas.General

Public Class CtlRestricciones
  Inherits DataGridView

  Private mFactorTamanio As Decimal = 1
  Public Property FactorTamanio() As Decimal
    Get
      Return mFactorTamanio
    End Get
    Set(ByVal value As Decimal)
      mFactorTamanio = value
    End Set
  End Property

  Private mUsuario As Usuario
  Public Property Usuario() As Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Usuario)
      mUsuario = value
      If value IsNot Nothing Then
        Llenar_detalles()
      End If
    End Set
  End Property

  Public ReadOnly Property Restriccion() As Restriccion
    Get
      Dim _restric As Restriccion = Nothing
      If Me.CurrentRow IsNot Nothing Then
        _restric = mUsuario.Restricciones(Me.CurrentRow.Index)
      End If
      Return _restric
    End Get
  End Property

  'Private mAplicacionDatos As AplicacionDatos
  'Public Property AplicacionDatos() As AplicacionDatos
  '  Get
  '    Return mAplicacionDatos
  '  End Get
  '  Set(ByVal value As AplicacionDatos)
  '    mAplicacionDatos = value
  '  End Set
  'End Property

  Private WithEvents BindingSourceDetalles As BindingSource

#Region "Detalles de Restricciones"
  Private Sub Llenar_detalles()
    Me.BindingSourceDetalles.DataSource = GetType(Infoware.Reglas.General.RestriccionList)
    BindingSourceDetalles.DataSource = mUsuario.Restricciones
    MyBase.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetOpcionString"
    DataGridViewTextBoxColumn1.HeaderText = "Opción"
    DataGridViewTextBoxColumn1.Width = 180
    DataGridViewTextBoxColumn1.ReadOnly = True
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Lectura"
    DataGridViewTextBoxColumn0.HeaderText = "Lectura"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Escritura"
    DataGridViewTextBoxColumn0.HeaderText = "Escritura"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Impresion"
    DataGridViewTextBoxColumn0.HeaderText = "Impresión"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_VerConfidencial"
    DataGridViewTextBoxColumn0.HeaderText = "Confidencial"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'If mUsuario.Restricciones.Count = 0 Then
    '  BindingSourceDetalles.AddNew()
    'End If
    'actualizar_totales()
  End Sub

  'Private Sub MyBase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyBase.CellEndEdit
  '  'actualizar_totales()
  'End Sub

  'Private Sub Mybase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
  '  'AbrirDetalle()
  'End Sub

  'Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
  '  Select Case e.KeyCode
  '    Case Keys.Enter
  '      e.Handled = True
  '      If BindingSourceDetalles.Current IsNot Nothing Then
  '        AbrirDetalle()
  '      End If
  '    Case Keys.Insert
  '      e.Handled = True
  '      Me.BindingSourceDetalles.AddNew()
  '      AbrirDetalle()
  '    Case Keys.Delete
  '      e.Handled = True
  '      If BindingSourceDetalles.Current IsNot Nothing Then
  '        Me.BindingSourceDetalles.RemoveCurrent()
  '        actualizar_totales()
  '      End If
  '  End Select
  'End Sub

  'Private Sub AbrirDetalle()
  '  Dim f As New FrmMantenimientoMovimientoContableDet
  '  f.Usuario = mUsuario
  '  f.AplicacionDatos(Enumerados.EnumOpciones.Usuario) = AplicacionDatos
  '  If BindingSourceDetalles.Count = 0 Then
  '    BindingSourceDetalles.AddNew()
  '  End If
  '  f.MovimientoContableDets = BindingSourceDetalles
  '  f.ShowDialog()
  '  'BindingSourceDetalles.EndEdit()
  '  MyBase.Refresh()
  '  actualizar_totales()
  'End Sub

  'Public Event Cambio_MovimientoDets As EventHandler
  'Private Sub actualizar_totales()
  '  RaiseEvent Cambio_MovimientoDets(Me, Nothing)
  'End Sub
#End Region

  Public Sub New()
    BindingSourceDetalles = New BindingSource
    MyBase.DataSource = BindingSourceDetalles
    MyBase.AutoGenerateColumns = False
    MyBase.AllowUserToAddRows = False
    MyBase.AllowUserToDeleteRows = False
    MyBase.ReadOnly = False
  End Sub
End Class
