Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmModeloLabor
  Implements IMantenimiento

  Private mModeloLabor As WWTSParametroDet
  Public Property ModeloLabor() As WWTSParametroDet
    Get
      Return mModeloLabor
    End Get
    Set(ByVal Value As WWTSParametroDet)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Modelo Labor")
      End If
      mModeloLabor = Value
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Sub Actualizar_detalles()
    If Me.mModeloLabor Is Nothing Then
      Exit Sub
    End If

    Me.CtlDetalleModeloLabor1.op = Me.mModeloLabor.OperadorDatos
    Me.CtlDetalleModeloLabor2.op = Me.mModeloLabor.OperadorDatos
    Me.CtlDetalleModeloLabor3.op = Me.mModeloLabor.OperadorDatos
    Me.CtlDetalleModeloLabor4.op = Me.mModeloLabor.OperadorDatos
    Me.CtlDetalleModeloLabor5.op = Me.mModeloLabor.OperadorDatos
    Me.CtlDetalleModeloLabor6.op = Me.mModeloLabor.OperadorDatos
    Me.CtlDetalleModeloLabor7.op = Me.mModeloLabor.OperadorDatos

    Me.CtlDetalleModeloLabor1.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Lunes, Me.mModeloLabor)
    Me.CtlDetalleModeloLabor2.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Martes, Me.mModeloLabor)
    Me.CtlDetalleModeloLabor3.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Miercoles, Me.mModeloLabor)
    Me.CtlDetalleModeloLabor4.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Jueves, Me.mModeloLabor)
    Me.CtlDetalleModeloLabor5.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Viernes, Me.mModeloLabor)
    Me.CtlDetalleModeloLabor6.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Sabado, Me.mModeloLabor)
    Me.CtlDetalleModeloLabor7.DetalleModeloLabor = New DetalleModeloLabor(Me.mModeloLabor.OperadorDatos, Enumerados.DiasSemana.Domingo, Me.mModeloLabor)

    Me.CtlDetalleModeloLabor1.llenar_datos()
    Me.CtlDetalleModeloLabor2.llenar_datos()
    Me.CtlDetalleModeloLabor3.llenar_datos()
    Me.CtlDetalleModeloLabor4.llenar_datos()
    Me.CtlDetalleModeloLabor5.llenar_datos()
    Me.CtlDetalleModeloLabor6.llenar_datos()
    Me.CtlDetalleModeloLabor7.llenar_datos()
  End Sub

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not ModeloLabor Is Nothing Then
      Me.txtcodigo.Value = ModeloLabor.Pardet_Secuencia
      Me.txtdescripcion.Text = ModeloLabor.Pardet_Descripcion
    End If
    Me.txtcodigo.Enabled = False
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.Panel2.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Actualizar_detalles()
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          ModeloLabor.Pardet_Secuencia = Me.txtcodigo.Value
          ModeloLabor.Pardet_Descripcion = Me.txtdescripcion.Text
          If Not ModeloLabor.Guardar() Then
            Throw New Exception(ModeloLabor.OperadorDatos.MsgError)
          End If
          If mDireccion = IMantenimiento.Accion.Modificacion Then
            Me.CtlDetalleModeloLabor1.Guardar()
            Me.CtlDetalleModeloLabor2.Guardar()
            Me.CtlDetalleModeloLabor3.Guardar()
            Me.CtlDetalleModeloLabor4.Guardar()
            Me.CtlDetalleModeloLabor5.Guardar()
            Me.CtlDetalleModeloLabor6.Guardar()
            Me.CtlDetalleModeloLabor7.Guardar()
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not ModeloLabor.Eliminar() Then
            Throw New Exception(ModeloLabor.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region
End Class
