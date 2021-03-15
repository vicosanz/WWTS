Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Controles.Base
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports Infoware.Controles.General

Public Class FrmCarga
  Implements IMantenimiento

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

  Private mCargaEmpleado As CargasxEmpleado
  Public Property CargaEmpleado() As CargasxEmpleado
    Get
      Return mCargaEmpleado
    End Get
    Set(ByVal value As CargasxEmpleado)
      mCargaEmpleado = value
      If value IsNot Nothing Then
        Me.ComboBoxTipoCarga.OperadorDatos = value.OperadorDatos
        Me.ComboBoxTipoCarga.Parametro = Enumerados.EnumParametros.TipoCargafamiliar
        Me.ComboBoxTipoCarga.Llenar_Datos()

        Me.CtlBuscaEntidad21.OperadorDatos = value.OperadorDatos
        Me.CtlBuscaEntidad21.llenar_datos()

        Me.checkSeguroCorporativo.Checked = mCargaEmpleado.CarEmp_estaSeguroCorporativo
        refrescar_forma()
      End If
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    Me.CtlBuscaEntidad21.TipoEntidad = CtlBuscaEntidad2.EnumTipoEntidad.EntidadNatural
    If Not mCargaEmpleado Is Nothing Then
      Me.CtlBuscaEntidad21.EntidadNatural = mCargaEmpleado.EntidadnaturalPariente
      Me.ComboBoxTipoCarga.ParametroDet = mCargaEmpleado.ParameTipoCarga
      Me.checkSeguroCorporativo.Checked = mCargaEmpleado.CarEmp_estaSeguroCorporativo
    End If
    Me.CtlBuscaEntidad21.Enabled = True
    Me.ComboBoxTipoCarga.Enabled = True
    Me.checkSeguroCorporativo.Enabled = True

    Select Case mDireccion
      Case IMantenimiento.Accion.Ingreso
        MyBase.TextoAceptar = "Ingresar"
      Case IMantenimiento.Accion.Eliminacion
        Me.CtlBuscaEntidad21.Enabled = False
        Me.ComboBoxTipoCarga.Enabled = False
        Me.checkSeguroCorporativo.Enabled = False
        MyBase.TextoAceptar = "Eliminar"
      Case IMantenimiento.Accion.Modificacion
        MyBase.TextoAceptar = "Modificar"
    End Select
  End Sub

  Private Sub FrmCarga_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    If Me.CtlBuscaEntidad21.EntidadNatural Is Nothing Then
      MsgBox("Debe seleccionar una persona", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If Not mCargaEmpleado Is Nothing Then
            mCargaEmpleado.EntidadnaturalPariente = Me.CtlBuscaEntidad21.EntidadNatural
            mCargaEmpleado.ParameTipoCarga = Me.ComboBoxTipoCarga.ParametroDet
            mCargaEmpleado.CarEmp_estaSeguroCorporativo = Me.checkSeguroCorporativo.Checked
          End If
          If Not mCargaEmpleado.Guardar() Then
            Throw New Exception(mCargaEmpleado.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not mCargaEmpleado.Eliminar() Then
            Throw New Exception(mCargaEmpleado.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox("No se pudo completar la operación" + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "Error")
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
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub
#End Region

End Class
