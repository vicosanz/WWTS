Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmLabor
  Implements IMantenimiento

  Private mLabor As Labor
  Public Property Labor() As Labor
    Get
      Return mLabor
    End Get
    Set(ByVal Value As Labor)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Labor")
      End If
      mLabor = Value

      Me.CtlModeloLabor1.Op = Value.OperadorDatos
      Me.CtlModeloLabor1.llenar_datos()

      Me.CtlCargoSeccion.OperadorDatos = Value.OperadorDatos
      'Me.CtlCargoSeccion.Parametro = Enumerados.EnumParametros.CargoSeccion
      Me.CtlCargoSeccion.Llenar_Datos()

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

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not Labor Is Nothing Then
      Me.txtcodigo.Text = Labor.Labor_Codigo
      Me.txtdescripcion.Text = Labor.Labor_Descripcion
      Me.CtlModeloLabor1.ModeloLabor = Labor.PardetModeloLabor
      Me.CtlCargoSeccion.ParametroDet = Labor.PardetCargoSeccion
      Me.chkcontrolarhe.Checked = Labor.Labor_ControlarHorasExtras
      Me.lblmensaje.Text = "Labor de la Sección " & Labor.Seccion.Pardet_Descripcion
    End If
    Me.txtcodigo.Enabled = False
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlModeloLabor1.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.CtlCargoSeccion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkcontrolarhe.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Labor.Labor_Codigo = Me.txtcodigo.Text
          Labor.Labor_Descripcion = Me.txtdescripcion.Text
          Labor.PardetModeloLabor = Me.CtlModeloLabor1.ModeloLabor
          Labor.PardetCargoSeccion = Me.CtlCargoSeccion.ParametroDet
          Labor.Labor_ControlarHorasExtras = Me.chkcontrolarhe.Checked
          If Not Labor.Guardar() Then
            Throw New Exception(Labor.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Labor.Eliminar() Then
            Throw New Exception(Labor.OperadorDatos.MsgError)
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
