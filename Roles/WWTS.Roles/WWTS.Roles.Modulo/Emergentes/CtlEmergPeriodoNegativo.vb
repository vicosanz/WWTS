Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Datos
Imports System.Data.SqlClient

Public Class CtlEmergPeriodoNegativo
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      CrearBarras()
    End Set
  End Property

  Private dsResult As DataSet
  Private mPatrono As Patrono

  Public Property Patrono() As Patrono
    Get
      Return mPatrono
    End Get
    Set(ByVal Value As Patrono)
      mPatrono = Value
      CrearBarras()
    End Set
  End Property

  Private Sub CrearBarras()
    If mOp Is Nothing Or mpatrono Is Nothing Then
      Exit Sub
    End If

    Dim bReturn As Boolean = True
    With mOp
      .AgregarParametro("@accion", "neg")
      .AgregarParametro("@Patron_Codigo", mPatrono.Patron_Codigo)
      .Procedimiento = "proc_asistencia"
       
      Try
        dsResult = New DataSet
        mOp.Ejecutar(dsResult)
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With

    Me.lblmensaje.Text = ""
    Me.lvneg.Items.Clear()
    If bReturn Then
      If Not dsResult Is Nothing AndAlso dsResult.Tables(0).Rows.Count > 0 Then
        For Each _dr As DataRow In dsResult.Tables(0).Rows
          Dim _item As New ListViewItem
          _item.Text = CStr(_dr("TipCon_descripcion"))
          _item.SubItems.Add(CDate(_dr("PerPag_FechaDesde")))
          _item.SubItems.Add(CStr(_dr("PerPag_periodopago")))
          _item.SubItems.Add(CInt(_dr("registros")))
          Me.lvneg.Items.Add(_item)
        Next
        Me.lblmensaje.Text = "Ingrese a módulo de asistencias para repararlo"
      End If
    End If
  End Sub
End Class
