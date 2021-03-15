Imports infoware.Datos
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class CtlLotePago
  Private mPatrono As Patrono = Nothing
  Public Property Patrono As Patrono
    Get
      Return mPatrono
    End Get
    Set(value As Patrono)
      mPatrono = value
      llenar_datos()
    End Set
  End Property

  Private mLotePagos As LotePagoList
  Public Event CambioLotePago()

  Public Property LotePago() As LotePago
    Get
      If mLotePagos Is Nothing OrElse mLotePagos.Count = 0 Then
        Return Nothing
      Else
        Return mLotePagos(IIf(Me.lstlpv.SelectedIndex = -1, 0, Me.lstlpv.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As LotePago)
      If Value Is Nothing Then
        Me.lstlpv.SelectedIndex = -1
      Else
        For t As Integer = 0 To Me.lstlpv.Items.Count - 1
          If mLotePagos(t).LotPag_Secuencia = Value.LotPag_Secuencia Then
            Me.lstlpv.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioLotePago()
    End Set
  End Property

  Private Sub LotePago_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    'Me.Height = Me.btnactualizar.Height
  End Sub

  Public Sub llenar_datos()
    lstlpv.Enabled = False
    If mPatrono Is Nothing Then
      Exit Sub
    End If
    Me.lstlpv.BeginUpdate()
    Me.lstlpv.DataSource = Nothing
    'Me.lstlpv.Items.Clear()
    Me.mLotePagos = LotePagoList.ObtenerLista(mPatrono, LotePagoList.enumReporteLotePago.NoCerrados)
    Me.lstlpv.DataSource = mLotePagos
    Me.lstlpv.ValueMember = "LotPag_Secuencia"
    Me.lstlpv.DisplayMember = "LotPag_FechaGeneracion"
    'me.lstlpv.DataBindings=
    Me.lstlpv.EndUpdate()
    lstlpv.Enabled = True
    Me.lstlpv.SelectedIndex = IIf(mLotePagos Is Nothing OrElse mLotePagos.Count = 0, -1, 0)
    RaiseEvent CambioLotePago()
  End Sub

  Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
    Me.llenar_datos()
  End Sub

  Private Sub lstlpv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstlpv.SelectedIndexChanged
    If Not lstlpv.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioLotePago()
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If Me.lstlpv.SelectedIndex = -1 Then
      Exit Sub
    Else
      If MsgBox("¿Está seguro que desea eliminar el lote?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Try
          If Not mLotePagos(Me.lstlpv.SelectedIndex).Eliminar() Then
            Throw New Exception(mLotePagos(Me.lstlpv.SelectedIndex).OperadorDatos.MsgError)
          End If
          Me.llenar_datos()
        Catch ex As Exception
          MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
      End If
    End If
  End Sub

  Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
    If Me.lstlpv.SelectedIndex = -1 Then
      Exit Sub
    Else
      If MsgBox("¿Está seguro que desea cerrar el lote?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Try
          mLotePagos(Me.lstlpv.SelectedIndex).LotPag_Cerrado = True
          If Not mLotePagos(Me.lstlpv.SelectedIndex).Guardar() Then
            Throw New Exception(mLotePagos(Me.lstlpv.SelectedIndex).OperadorDatos.MsgError)
          End If
          Me.llenar_datos()
        Catch ex As Exception
          MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
      End If
    End If
  End Sub
End Class
