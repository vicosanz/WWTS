Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmPatrono
  Implements IMantenimiento

  Private mPatrono As Patrono
  Public Property Patrono() As Patrono
    Get
      Return mPatrono
    End Get
    Set(ByVal Value As Patrono)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Patrono")
      End If
      mPatrono = Value
      Me.CtlUbicacion1.Op = Value.OperadorDatos
      Me.CtlUbicacion1.llenar_datos()
      Me.CtlBuscaEntidad21.OperadorDatos = Value.OperadorDatos
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
    If Not Patrono Is Nothing Then
      Me.txtcodigo.Text = Patrono.Patron_Codigo
      Me.CtlBuscaEntidad21.EntidadJuridica = Patrono.Entidadjuridica
      Me.CtlUbicacion1.Parroquia = Patrono.PardetParroquia
      Me.txt_patronal.Text = Patrono.Patron_NumeroPatronal
      Me.txt_cuentabancaria.Text = Patrono.Patron_NumeroCuentaBancaria
    End If
    Me.txtcodigo.Enabled = False
    Me.CtlBuscaEntidad21.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.CtlUbicacion1.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txt_patronal.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
    Me.txt_cuentabancaria.Enabled = Not mDireccion = IMantenimiento.Accion.Eliminacion
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Patrono.Patron_Codigo = Me.txtcodigo.Text
          Patrono.Entidadjuridica = Me.CtlBuscaEntidad21.EntidadJuridica
          Patrono.PardetParroquia = Me.CtlUbicacion1.Parroquia
          Patrono.Patron_NumeroPatronal = Me.txt_patronal.Text
          Patrono.Patron_NumeroCuentaBancaria = Me.txt_cuentabancaria.Text
          If Not Patrono.Guardar() Then
            Throw New Exception(Patrono.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Patrono.Eliminar() Then
            Throw New Exception(Patrono.OperadorDatos.MsgError)
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
