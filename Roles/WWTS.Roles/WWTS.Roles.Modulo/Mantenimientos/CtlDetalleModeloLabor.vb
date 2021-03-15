Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class CtlDetalleModeloLabor
  Private mOp As OperadorDatos
  Private mDetalleModeloLabor As DetalleModeloLabor

  Public Property op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal Value As OperadorDatos)
      mOp = Value
      If Not mOp Is Nothing Then
        Me.CtlTarea1.Op = mOp
        Me.CtlTarea1.llenar_datos()

        Me.cboEstadoDiaLabor.OperadorDatos = mOp
        Me.cboEstadoDiaLabor.Parametro = Enumerados.EnumParametros.EstadoDiaLabor
        Me.cboEstadoDiaLabor.Llenar_Datos()
      End If
    End Set
  End Property

  Public Property DetalleModeloLabor() As DetalleModeloLabor
    Get
      Return mDetalleModeloLabor
    End Get
    Set(ByVal Value As DetalleModeloLabor)
      mDetalleModeloLabor = Value
    End Set
  End Property

  Public Sub llenar_datos()
    Me.lblmensaje.Text = Enumerados.DiaSemanaList.RetornarDescripcion(CInt(Me.mDetalleModeloLabor.DeMoLa_diasemana))
    Me.txt_tarea.Text = Me.mDetalleModeloLabor.DeMoLa_tarea
    Me.txt_sobre50.Text = Me.mDetalleModeloLabor.DeMoLa_Sobre50
    Me.txt_sobre100.Text = Me.mDetalleModeloLabor.DeMoLa_Sobre100
    Me.txt_sobre25.Text = Me.mDetalleModeloLabor.DeMoLa_Sobre25
    Me.cboEstadoDiaLabor.ParametroDet = Me.mDetalleModeloLabor.PardetEstadoDia
    Me.CtlTarea1.Tarea = Me.mDetalleModeloLabor.Tarea
    Me.chkasistencia.Checked = Me.mDetalleModeloLabor.DeMoLa_Asistencia
  End Sub

  Public Sub Guardar()
    Try
      Me.mDetalleModeloLabor.Tarea = Me.CtlTarea1.Tarea
      Me.mDetalleModeloLabor.PardetEstadoDia = Me.cboEstadoDiaLabor.ParametroDet
      Me.mDetalleModeloLabor.DeMoLa_Tarea = CType(Me.txt_tarea.Text, Integer)
      Me.mDetalleModeloLabor.DeMoLa_Sobre50 = CType(Me.txt_sobre50.Text, Integer)
      Me.mDetalleModeloLabor.DeMoLa_Sobre100 = CType(Me.txt_sobre100.Text, Integer)
      Me.mDetalleModeloLabor.DeMoLa_Sobre25 = CType(Me.txt_sobre25.Text, Integer)
      Me.mDetalleModeloLabor.DeMoLa_Asistencia = Me.chkasistencia.Checked
      If Not Me.mDetalleModeloLabor.Guardar() Then
        Throw New Exception(Me.mDetalleModeloLabor.OperadorDatos.MsgError)
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub
End Class
