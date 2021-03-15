Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Datos
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class CtlEmergTresFaltas
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      If Not value Is Nothing Then
        cbomes.DisplayMember = "Descripcion"
        cbomes.ValueMember = "Numero"
        cbomes.DataSource = Enumerados.MesesdelAnioList
        cbomes.SelectedValue = Month(Now.Date())
        numanio.Value = Year(Now.Date())
      End If
    End Set
  End Property

  Private mPatrono As Patrono

  Public Property Patrono() As Patrono
    Get
      Return mPatrono
    End Get
    Set(ByVal Value As Patrono)
      mPatrono = Value
      Actualizar_datos()
    End Set
  End Property

  Sub Actualizar_datos()
    If mOp Is Nothing Or mPatrono Is Nothing Then
      Exit Sub
    End If
    If Me.TabControl1.SelectedIndex = 0 Then
      CrearBarras()
    Else
      Mostrarreporte()
    End If
  End Sub

  Private Sub CrearBarras()
    Dim dsResult As New DataSet

    Dim bReturn As Boolean = True
    With mOp
      .AgregarParametro("@accion", "3ft")
      .AgregarParametro("@Patron_Codigo", mPatrono.Patron_Codigo)
      .AgregarParametro("@anio", numanio.Value)
      .AgregarParametro("@mes", CInt(cbomes.SelectedValue))
      If Not Me.chkcontratoactivo.CheckState = CheckState.Indeterminate Then
        .AgregarParametro("@contratocerrado", Me.chkcontratoactivo.Checked)
      End If
      .Procedimiento = "proc_asistencia"

      Try
        .Ejecutar(dsResult)
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With

    Me.lvneg.Items.Clear()
    If bReturn Then
      If Not dsResult Is Nothing AndAlso dsResult.Tables(0).Rows.Count > 0 Then
        For Each _dr As DataRow In dsResult.Tables(0).Rows
          Dim _item As New ListViewItem
          _item.Text = CStr(_dr("Entida_Codigo"))
          _item.SubItems.Add(CStr(_dr("NombreCompleto")))
          _item.SubItems.Add(CStr(_dr("cedula")))
          _item.SubItems.Add(CInt(_dr("faltas")))
          Me.lvneg.Items.Add(_item)
        Next
      End If
    End If
  End Sub

  Private Sub numanio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numanio.ValueChanged
    Actualizar_datos()
  End Sub

  Private Sub cbomes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomes.SelectedIndexChanged
    If cbomes.SelectedIndex = -1 Then
      Exit Sub
    End If
    Actualizar_datos()
  End Sub

  Private Sub chkcontratoactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcontratoactivo.CheckedChanged
    Actualizar_datos()
  End Sub

  Private Sub Mostrarreporte()
    Try
      Dim info As ReportClass
      info = New crpLisFaltasmes

      Dim filtro As String = String.Empty

      info.DataDefinition.FormulaFields("Titulo").Text = "'Listado de faltas por mes'"
      info.DataDefinition.FormulaFields("Filtro").Text = "'" & IIf(Me.chkcontratoactivo.CheckState = CheckState.Indeterminate, "", IIf(Me.chkcontratoactivo.CheckState = CheckState.Checked, "Con contrato activo", "Sin contrato activo")) & "'"
      'info.DataDefinition.FormulaFields("Hacienda").Text = "'" & Patrono.Hacienda.Hac_nombre & "'"
      info.DataDefinition.FormulaFields("Patrono").Text = "'" & Patrono.Entidadjuridica.NombreCompleto & "'"
      info.DataDefinition.FormulaFields("aniomes").Text = "'" & Me.numanio.Value.ToString & " " & cbomes.SelectedText & "'"

      Dim ds As New DSlisfaltasmes

      ds = RetornarLisFaltasMesDS(mOp, Patrono, numanio.Value, cbomes.SelectedValue, Me.chkcontratoactivo.CheckState)

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperA4
        Me.crvlisfaltames.Zoom(1)
        Me.crvlisfaltames.ReportSource = info
        Me.crvlisfaltames.DisplayToolbar = True
        Me.crvlisfaltames.ShowRefreshButton = False
        Me.crvlisfaltames.DisplayGroupTree = False
        Me.crvlisfaltames.ShowGroupTreeButton = False
      End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Public Function RetornarLisFaltasMesDS(ByVal _OperadorDatos As OperadorDatos, ByVal _patrono As Patrono, ByVal _anio As Integer, ByVal _mes As Integer, ByVal _contratoactivo As System.Windows.Forms.CheckState) As DSlisfaltasmes
    Dim oResult As New DSlisfaltasmes
    Dim bReturn As Boolean = True
    Dim dsResult As New DSlisfaltasmes
    With _OperadorDatos
      .AgregarParametro("@accion", "3fp")
      .AgregarParametro("@Patron_Codigo", mPatrono.Patron_Codigo)
      .AgregarParametro("@anio", numanio.Value)
      .AgregarParametro("@mes", cbomes.SelectedValue)
      If Not Me.chkcontratoactivo.CheckState = CheckState.Indeterminate Then
        .AgregarParametro("@contratocerrado", Me.chkcontratoactivo.Checked)
      End If
      .Procedimiento = "proc_asistencia"

      .Comando.CommandText = _OperadorDatos.Procedimiento

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(_OperadorDatos.Comando)

      Try
        dsResult = New DSlisfaltasmes
        DataAdapter.Fill(dsResult, "v_alerta")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

  Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    Actualizar_datos()
  End Sub
End Class
