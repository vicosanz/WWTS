Imports Infoware.Datos
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas

Public Class CtlFeriados

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

  Private WithEvents mFeriados As FeriadoList
  Private Sub mostrar_feriados()
    If mOp Is Nothing OrElse CtlPais1.ParametroDet Is Nothing Then
      Exit Sub
    End If
    mFeriados = FeriadoList.ObtenerLista(mOp, CtlPais1.ParametroDet)
    Me.dgferiados.DataSource = mFeriados
  End Sub

  Private Sub mFeriados_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mFeriados.AddingNew
    Dim _fer As New Feriado(mOp, Me.CtlPais1.ParametroDet, Now.Date)
    e.NewObject = _fer
  End Sub

  Private Sub CtlPais1_CambioPais(ByVal sender As Object, ByVal e As EventArgs) Handles CtlPais1.CambioItem
    mostrar_feriados()
  End Sub

  Private Sub dgferiados_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgferiados.RowValidating
    Try
      CType(FeriadoListBindingSource.DataSource(e.RowIndex), Feriado).Guardar()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub dgferiados_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgferiados.UserDeletingRow
    Try
      If Not e.Row.IsNewRow Then
        e.Cancel = Not CType(FeriadoListBindingSource.DataSource(e.Row.Index), Prestamo).Eliminar()
      End If
    Catch ex As Exception
    End Try
  End Sub
End Class
