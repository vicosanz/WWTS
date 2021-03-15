Imports Infoware.Datos
Imports WWTS.Roles.Reglas
Imports Infoware.Reglas
Imports WWTS.General.Reglas

Public Class CtlIR

  Private mOp As OperadorDatos
  Public Event CambioBanco()

  Public Property op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal Value As OperadorDatos)
      If Not Value Is Nothing Then
        mOp = Value
        Me.CtlPais1.OperadorDatos = mOp
        Me.CtlPais1.Parametro = Enumerados.EnumParametros.Pais
        Me.CtlPais1.llenar_datos()
      End If
    End Set
  End Property

  Private WithEvents mParamIRs As ImpuestoRentaList
  Private Sub mostrar_ParamIRs()
    If mOp Is Nothing OrElse CtlPais1.ParametroDet Is Nothing Then
      Exit Sub
    End If
    mParamIRs = ImpuestoRentaList.ObtenerLista(CtlPais1.ParametroDet, Me.dtfecactivo.Value)
    Me.dgParamIRs.DataSource = mParamIRs
  End Sub

  Private Sub mParamIRs_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mParamIRs.AddingNew
    Dim _pir As New ImpuestoRenta(mOp, Me.CtlPais1.ParametroDet)
    e.NewObject = _pir
  End Sub

  Private Sub CtlPais1_CambioPais(ByVal sender As Object, ByVal e As EventArgs) Handles CtlPais1.CambioItem, dtfecactivo.ValueChanged
    mostrar_ParamIRs()
  End Sub

  Private Sub dgParamIRs_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgParamIRs.RowValidating
    Try
      CType(ParamIRListBindingSource.DataSource(e.RowIndex), ImpuestoRenta).Guardar()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub dgParamIRs_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgParamIRs.UserDeletingRow
    Try
      If Not e.Row.IsNewRow Then
        e.Cancel = Not CType(ParamIRListBindingSource.DataSource(e.Row.Index), Prestamo).Eliminar()
      End If
    Catch ex As Exception
    End Try
  End Sub

  
End Class
