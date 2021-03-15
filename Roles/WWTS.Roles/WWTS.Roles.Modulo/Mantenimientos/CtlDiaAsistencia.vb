Imports Infoware.Datos
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas

Public Class CtlDiaAsistencia
#Region "Op"
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      If Not mOp Is Nothing Then
        Me.cboestado.OperadorDatos = mOp
        Me.cboestado.Parametro = Enumerados.EnumParametros.EstadoDiaLabor
        Me.cboestado.Llenar_Datos()
        Me.CtlTarea1.Op = mOp
        Me.CtlTarea1.llenar_datos()

        Me.CtlLabor1.Op = mOp
        Me.CtlLabor1.llenar_datos()
      End If
    End Set
  End Property
#End Region

  Private mDiaAsistencia As DiaAsistencia
  Public Property DiaAsistencia() As DiaAsistencia
    Get
      Return mDiaAsistencia
    End Get
    Set(ByVal Value As DiaAsistencia)
      mDiaAsistencia = Value
      llenar_datos()
    End Set
  End Property

  Public Event CambioDatos()
  Private cambiando As Boolean = False

  Public Sub llenar_datos()
    If mDiaAsistencia Is Nothing Then
      Exit Sub
    End If
    cambiando = True
    Me.CtlTarea1.Tarea = mDiaAsistencia.Tarea
    Me.chkasistencia.Checked = mDiaAsistencia.DiaAsi_Asistencia
    Me.cboestado.ParametroDet = mDiaAsistencia.PardetEstadoDia
    Me.txtjornada.Value = mDiaAsistencia.DiaAsi_Jornadaaux
    Me.txtsobret50.Value = mDiaAsistencia.DiaAsi_Sobret50aux
    Me.txtsobret100.Value = mDiaAsistencia.DiaAsi_Sobret100aux
    Me.txtsobret25.Value = mDiaAsistencia.DiaAsi_Sobret25aux

    'Me.txtintegrales.Text = mDiaAsistencia.DiaAsi_integrales
    Me.CtlLabor1.Labor = mDiaAsistencia.Labor
    Me.lbl_descrip.Text = Enumerados.DiaSemanaList.RetornarDescripcion(CInt(mDiaAsistencia.DiaAsi_Fecha.DayOfWeek)).Substring(0, 2) & ", " & mDiaAsistencia.DiaAsi_Fecha.Day
    If mDiaAsistencia Is Nothing Then
      Me.lblesnuevo.Visible = True
    Else
      Me.lblesnuevo.Visible = mDiaAsistencia.EsNuevo
    End If
    cambiando = False
    actualizar()
  End Sub

  Private Sub chkasistencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkasistencia.CheckedChanged
    If Not Me.chkasistencia.Checked Then
      Me.txtjornada.Value = 0
      Me.txtsobret25.Value = 0
      Me.txtsobret50.Value = 0
      Me.txtsobret100.Value = 0
      Me.chkasistencia.BackColor = System.Drawing.SystemColors.ButtonShadow
    Else
      Me.chkasistencia.BackColor = System.Drawing.SystemColors.Control
    End If
    actualizar()
  End Sub

  Private Sub cboestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboestado.CambioItem
    Dim tip As Enumerados.enumEstadoModeloLabor
    tip = CType(cboestado.ParametroDet.Pardet_Secuencia, Enumerados.enumEstadoModeloLabor)
    Select Case tip
      Case Enumerados.enumEstadoModeloLabor.Permiso
        Me.txtjornada.Value = 0
        Me.txtsobret25.Value = 0
        Me.txtsobret50.Value = 0
        Me.txtsobret100.Value = 0
    End Select
    actualizar()
  End Sub

  Private Sub txtsobretiempo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsobret50.TextChanged, txtsobret100.TextChanged, txtsobret25.TextChanged
    actualizar()
  End Sub

  Sub actualizar()
    If cambiando Then
      Exit Sub
    End If
    If mDiaAsistencia Is Nothing Then
      Exit Sub
    End If
    Try
      Dim tip As Enumerados.enumEstadoModeloLabor
      tip = CType(cboestado.ParametroDet.Pardet_Secuencia, Enumerados.enumEstadoModeloLabor)
      Me.Enabled = True
      Select Case tip
        Case Enumerados.enumEstadoModeloLabor.NoRegistra
          Me.lbl_descrip.BackColor = System.Drawing.Color.Aqua
          Me.chkasistencia.Checked = False
          Me.txtjornada.Value = 0
          Me.txtsobret25.Value = 0
          Me.txtsobret50.Value = 0
          Me.txtsobret100.Value = 0
          Me.Enabled = False
        Case Enumerados.enumEstadoModeloLabor.Normal
          Me.lbl_descrip.BackColor = System.Drawing.Color.LightSeaGreen
        Case Enumerados.enumEstadoModeloLabor.Feriado
          Me.lbl_descrip.BackColor = System.Drawing.Color.Fuchsia
        Case Enumerados.enumEstadoModeloLabor.Suspendido
          Me.lbl_descrip.BackColor = System.Drawing.Color.LightCoral
          Me.txtjornada.Value = 0
          Me.txtsobret25.Value = 0
          Me.txtsobret50.Value = 0
          Me.txtsobret100.Value = 0
        Case Enumerados.enumEstadoModeloLabor.Permiso
          Me.lbl_descrip.BackColor = System.Drawing.Color.LightSlateGray
        Case Enumerados.enumEstadoModeloLabor.Enfermedad_Maternidad
          Me.lbl_descrip.BackColor = System.Drawing.Color.LightSlateGray
          Me.chkasistencia.Checked = IIf(mDiaAsistencia.DiaAsi_Fecha.DayOfWeek = DayOfWeek.Saturday Or mDiaAsistencia.DiaAsi_Fecha.DayOfWeek = DayOfWeek.Sunday, False, True)
          Me.txtjornada.Value = IIf(mDiaAsistencia.DiaAsi_Fecha.DayOfWeek = DayOfWeek.Saturday Or mDiaAsistencia.DiaAsi_Fecha.DayOfWeek = DayOfWeek.Sunday, 0, Me.CtlTarea1.Tarea.Tarea_Meta)
          Me.txtsobret25.Value = 0
          Me.txtsobret50.Value = 0
          Me.txtsobret100.Value = 0
        Case Enumerados.enumEstadoModeloLabor.Vacaciones
          Me.lbl_descrip.BackColor = System.Drawing.Color.LightYellow
      End Select

      mDiaAsistencia.Tarea = Me.CtlTarea1.Tarea
      mDiaAsistencia.DiaAsi_Jornadaaux = Me.txtjornada.Value
      mDiaAsistencia.DiaAsi_Sobret100aux = Me.txtsobret100.Value
      mDiaAsistencia.DiaAsi_Sobret50aux = Me.txtsobret50.Value
      mDiaAsistencia.DiaAsi_Sobret25aux = Me.txtsobret25.Value
      mDiaAsistencia.DiaAsi_Asistencia = Not (mDiaAsistencia.DiaAsi_Jornadaaux = 0 And mDiaAsistencia.DiaAsi_Sobret50aux = 0 And mDiaAsistencia.DiaAsi_Sobret100aux = 0 And mDiaAsistencia.DiaAsi_Sobret25aux = 0)
      Me.chkasistencia.Checked = Not (mDiaAsistencia.DiaAsi_Jornadaaux = 0 And mDiaAsistencia.DiaAsi_Sobret50aux = 0 And mDiaAsistencia.DiaAsi_Sobret100aux = 0 And mDiaAsistencia.DiaAsi_Sobret25aux = 0)

      mDiaAsistencia.PardetEstadoDia = Me.cboestado.ParametroDet
      'Me.txtintegrales.Text = mDiaAsistencia.DiaAsi_integrales
      mDiaAsistencia.Labor = Me.CtlLabor1.Labor
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
    RaiseEvent CambioDatos()
  End Sub

  Private Sub txtjornada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjornada.TextChanged
    actualizar()
  End Sub

  Private Sub CtlTarea1_Cambio_Tarea() Handles CtlTarea1.CambioTarea
    If mDiaAsistencia Is Nothing OrElse mDiaAsistencia.Tarea Is Nothing OrElse mDiaAsistencia.Tarea.Tarea_Predeterminado = 0 Then
      Exit Sub
    End If
    Me.txtjornada.Value = mDiaAsistencia.Tarea.Tarea_Predeterminado
    actualizar()
  End Sub

  Private Sub CtlLabor1_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlLabor1.CambioLabor
    actualizar()
  End Sub
End Class
