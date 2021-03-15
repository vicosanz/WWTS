Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Infoware.Datos
Imports System.Data.SqlClient

Public Class CtlEmergFijosTemporada
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
    If mOp Is Nothing Or mPatrono Is Nothing Then
      Exit Sub
    End If

    Dim bReturn As Boolean = True

    With mOp
      .AgregarParametro("@accion", "es")
      .AgregarParametro("@fecactivo", Now.Date)
      .AgregarParametro("@Patron_Codigo", mPatrono.Patron_Codigo)
      .Procedimiento = "proc_contrato"
      Try
        dsResult = New DataSet
        .Ejecutar(dsResult)
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With

    limpiar_controls(Me)
    If bReturn Then
      If Not dsResult Is Nothing AndAlso dsResult.Tables(0).Rows.Count > 0 Then
        Dim colores(6) As System.Drawing.Color
        colores(0) = Color.Red
        colores(1) = Color.Green
        colores(2) = Color.Blue
        colores(3) = Color.Yellow
        colores(4) = Color.Olive
        colores(5) = Color.Pink
        Dim totcontratos As Integer = 0
        For Each _dr As DataRow In dsResult.Tables(0).Rows
          totcontratos += CInt(_dr("contratos"))
        Next
        Dim t As Integer = 0

        Dim contfijo As Integer = 0
        Dim conttemp As Integer = 0
        Dim contporh As Integer = 0

        For Each _dr As DataRow In dsResult.Tables(0).Rows
          Dim numcontratos As Integer = CInt(_dr("contratos"))
          Dim codtipocontrato As Integer = CInt(_dr("TipCon_Codigo"))
          Dim tipocontrato As New TipoContrato(Me.mOp, codtipocontrato)
          Select Case tipocontrato.Pardet_TipoContrato
            Case Enumerados.enumTipoContrato.Fijo
              contfijo += numcontratos
            Case Enumerados.enumTipoContrato.Temporada
              conttemp += numcontratos
            Case Enumerados.enumTipoContrato.PorHoras
              contporh += numcontratos
          End Select

          Dim lbl_tipo As New System.Windows.Forms.Label
          Dim porcfijo As New System.Windows.Forms.Label
          Dim barfijo As New Infoware.Controles.Base.GradientPanel
          Dim pnlfijo As New System.Windows.Forms.Panel

          barfijo.SuspendLayout()
          pnlfijo.SuspendLayout()
          SuspendLayout()

          lbl_tipo.Location = New System.Drawing.Point(8, 8)
          'lbl_tipo.Name = "lbl_tipo"
          lbl_tipo.Size = New System.Drawing.Size(112, 24)
          lbl_tipo.Text = _dr("TipCon_descripcion")
          lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
          lbl_tipo.Tag = "del"

          porcfijo.BackColor = System.Drawing.Color.Transparent
          porcfijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          porcfijo.Location = New System.Drawing.Point(0, 0)
          'Me.porcfijo.Name = "porcfijo"
          porcfijo.Size = New System.Drawing.Size(200 * numcontratos / totcontratos, 24)
          porcfijo.Text = CStr(numcontratos)
          porcfijo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
          porcfijo.Tag = "del"

          barfijo.Controls.Add(porcfijo)
          barfijo.EndColor = colores(t Mod 5)
          barfijo.Location = New System.Drawing.Point(120, 8)
          'barfijo.Name = "barfijo"
          barfijo.Size = New System.Drawing.Size(180 * numcontratos / totcontratos, 24)
          barfijo.Tag = "del"

          pnlfijo.Controls.Add(lbl_tipo)
          pnlfijo.Controls.Add(barfijo)
          pnlfijo.Location = New System.Drawing.Point(1, (t * 28))
          'pnlfijo.Name = "pnlfijo"
          pnlfijo.Size = New System.Drawing.Size(300, 34)
          pnlfijo.Tag = "del"

          Me.XpCaptionPane1.Controls.Add(pnlfijo)
          pnlfijo.Controls.Add(lbl_tipo)
          pnlfijo.Controls.Add(barfijo)

          barfijo.ResumeLayout()
          pnlfijo.ResumeLayout()
          Me.ResumeLayout()
          t += 1
        Next
        Me.Height = ((t - 1) * 28) + lblmensaje.Height + 55
        Me.lblmensaje.Text = "Fijos " & contfijo.ToString.Trim & " Temporada " & conttemp.ToString.Trim & " Por horas " & contporh.ToString.Trim
        If (contfijo + conttemp) * 0.75 < contporh Then
          Me.lblmensaje.Text += " Excedido por " & contporh - ((contfijo + conttemp) * 0.75)
        End If
      End If
    End If

  End Sub

  Sub limpiar_controls(ByVal controles As Control)
    For Each _control As Control In controles.Controls
      If Not _control Is Nothing Then
        If Not _control.Controls Is Nothing Then
          limpiar_controls(_control)
        End If
        If _control.Tag = "del" Then
          controles.Controls.Remove(_control)
        End If
      End If
    Next
  End Sub
  Private Sub CtlPatrono1_CambioPatrono()
    CrearBarras()
  End Sub
End Class
