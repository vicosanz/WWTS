Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas

Public Class CtlPeriodoVacacion

  Private mContratoSeleccionado As Contrato
  Public Property Contrato() As Contrato
    Get
      Return mContratoSeleccionado
    End Get
    Set(ByVal value As Contrato)
      mContratoSeleccionado = value
      mostrar_vacacion()
    End Set
  End Property

  Private Sub btnnuevovacacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevovacacion.Click
    If Contrato.EsNuevo Then
      MsgBox("Debe guardar los cambios para continuar", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim _vacacion As BeneficiosSociales = New BeneficiosSociales(_sistema.OperadorDatos, True, Now.Date, Now.Date)
    _vacacion.Contrato = Contrato
    _vacacion.BenSoc_Dias = 15
    Dim f As New WWTS.Roles.Controles.FrmMantenimientoVacacion(_sistema, Enumerados.EnumOpciones.Personal) With {
      .Vacacion = _vacacion
    }
    f.ShowDialog()
    mostrar_vacacion()
  End Sub

  Private Sub btnabrirvacacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirvacacion.Click, DataGridView6.DoubleClick
    If BSperiodo.Current Is Nothing Then
      Exit Sub
    End If
    Dim _sistema As Sistema = CType(Me.ParentForm, FrmFormaBase).Sistema
    Dim f As New WWTS.Roles.Controles.FrmMantenimientoVacacion(_sistema, Enumerados.EnumOpciones.Personal) With {
      .Vacacion = BSperiodo.Current
    }
    f.ShowDialog()
    mostrar_vacacion()
  End Sub

  Private Sub btneliminarvacacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarvacacion.Click
    If BSperiodo.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSperiodo.Current, BeneficiosSociales).Eliminar Then
      MsgBox("Error al eliminar", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    mostrar_vacacion()
  End Sub

  Private mVacaciones As BeneficiosSocialesList
  Sub mostrar_vacacion()
    If Contrato Is Nothing Then
      Exit Sub
    End If

    Me.DataGridView6.Columns.Clear()
    Me.DataGridView6.ReadOnly = True

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FechaDesde"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha Desde"
    DataGridViewTextBoxColumn1.Width = 100
    Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_FechaHasta"
    DataGridViewTextBoxColumn1.HeaderText = "Fecha Hasta"
    DataGridViewTextBoxColumn1.Width = 100
    Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BenSoc_Dias"
    DataGridViewTextBoxColumn1.HeaderText = "Días"
    DataGridViewTextBoxColumn1.Width = 50
    Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "DiasAcumulados"
    DataGridViewTextBoxColumn1.HeaderText = "Días Acumulados"
    DataGridViewTextBoxColumn1.Width = 75
    Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn2.DataPropertyName = "BenSoc_Liquidado"
    DataGridViewTextBoxColumn2.HeaderText = "Liquidado"
    DataGridViewTextBoxColumn2.Width = 70
    Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn2})

    mVacaciones = BeneficiosSocialesList.ObtenerListaxContrato(Contrato)
    Me.BSperiodo.DataSource = mVacaciones
  End Sub

  Public Event ClickPeriodo As EventHandler

  Private Sub DataGridViewPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView6.Click
    RaiseEvent ClickPeriodo(sender, e)
  End Sub
End Class
