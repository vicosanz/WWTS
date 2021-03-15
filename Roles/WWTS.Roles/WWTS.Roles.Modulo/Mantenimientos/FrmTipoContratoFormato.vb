Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmTipoContratoFormato
  Implements IMantenimiento

  Private mTipoContratoFormato As TipoContratoFormato
  Public Property TipoContratoFormato() As TipoContratoFormato
    Get
      Return mTipoContratoFormato
    End Get
    Set(ByVal Value As TipoContratoFormato)
      mTipoContratoFormato = Value
      If Value IsNot Nothing Then
        Me.ComboBoxTipoFormato.OperadorDatos = Value.OperadorDatos
        Me.ComboBoxTipoFormato.Parametro = Enumerados.EnumParametros.TipoContratoFormato
        Me.ComboBoxTipoFormato.Llenar_Datos()
      End If

      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not TipoContratoFormato Is Nothing Then
      ComboBoxTipoFormato.ParametroDet = TipoContratoFormato.PardetFormato
      btnTiCoFo_Archivo.Text = TipoContratoFormato.TiCoFo_Archivo

      ComboBoxTipoFormato.Enabled = TipoContratoFormato.EsNuevo
    End If
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          TipoContratoFormato.PardetFormato = ComboBoxTipoFormato.ParametroDet
          TipoContratoFormato.TiCoFo_Archivo = Me.btnTiCoFo_Archivo.Text
          If Not TipoContratoFormato.Guardar() Then
            Throw New Exception(TipoContratoFormato.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not TipoContratoFormato.Eliminar() Then
            Throw New Exception(TipoContratoFormato.OperadorDatos.MsgError)
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

  Private Sub btnTiCoFo_Archivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiCoFo_Archivo.Click
    With OpenFileDialog1
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btnTiCoFo_Archivo.Text = .FileName
      End If
    End With
  End Sub
End Class