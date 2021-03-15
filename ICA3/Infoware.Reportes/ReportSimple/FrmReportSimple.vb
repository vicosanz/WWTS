Public Class FrmReportSimple
  Private mArchivoReporte As String = String.Empty
  Private mEstaLlenando As Boolean = False
  Public Property ArchivoReporte() As String
    Get
      Return mArchivoReporte
    End Get
    Set(ByVal value As String)
      If Not String.IsNullOrEmpty(value) Then
        mArchivoReporte = value
        mEstaLlenando = True
        Me.CtlDesigner1.ArchivoReporte = value
        mEstaLlenando = False
      End If
    End Set
  End Property

  Private mCabecera As Object = Nothing
  Public Property Cabecera() As Object
    Get
      Return mCabecera
    End Get
    Set(ByVal value As Object)
      If value IsNot Nothing Then
        mCabecera = value
        Me.CtlDesigner1.Cabecera = value
      End If
    End Set
  End Property

  Private mDetalles As Object = Nothing
  Public Property Detalles() As IList
    Get
      Return mDetalles
    End Get
    Set(ByVal value As IList)
      If value IsNot Nothing Then
        mDetalles = value
        Me.CtlDesigner1.Detalles = value
      End If
    End Set
  End Property

  Public Sub VistaPrevia()
    Me.CtlDesigner1.VistaPrevia()
  End Sub

  Public Sub Imprimir()
    Me.CtlDesigner1.imprimir()
  End Sub

  Private Sub CtlDesigner1_CambioDatosEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlDesigner1.CambioDatosEvent
    If mEstaLlenando Then
      Exit Sub
    End If
  End Sub

  Private Sub FrmReportSimple_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If CtlDesigner1.CambioDatos Then
      If MsgBox("El reporte ha cambiado. ¿Desea guardar los cambios?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        If Not Me.CtlDesigner1.Guardar_Cambios Then
          e.Cancel = True
        Else
          CtlDesigner1.CambioDatos = False
        End If
      End If
    End If
  End Sub
End Class