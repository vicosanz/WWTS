Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.General.Modulo

Public Class FrmCambiarLote
  Implements IMantenimiento

  Public Property Lote() As WWTSParametroDet
    Get
      If chkNulo.Checked Then
        Return Nothing
      End If
      Return Me.cboLote.ParametroDet
    End Get
    Set(ByVal Value As WWTSParametroDet)
      If Value Is Nothing Then
        Me.chkNulo.Checked = True
      Else
        Me.chkNulo.Checked = False
        Me.cboHacienda.ParametroDet = Value.PardetPadre.PardetPadre
        Me.cboTerreno.ParametroDet = Value.PardetPadre
        Me.cboLote.ParametroDet = Value
      End If
    End Set
  End Property

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

  Private Sub FrmCambiarLote_AntesAceptar(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar

  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cboHacienda.OperadorDatos = Sistema.OperadorDatos
    Me.cboTerreno.OperadorDatos = Sistema.OperadorDatos
    Me.cboLote.OperadorDatos = Sistema.OperadorDatos
    Me.cboHacienda.Parametro = Enumerados.EnumParametros.Hacienda
    Me.cboTerreno.Parametro = Enumerados.EnumParametros.Terreno
    Me.cboLote.Parametro = Enumerados.EnumParametros.Lote
    Me.cboHacienda.Llenar_Datos()
  End Sub
#End Region

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma

  End Sub

  Private Sub FrmCambiarLote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub cboHacienda_CambioItem(sender As Object, e As System.EventArgs) Handles cboHacienda.CambioItem
    Me.cboTerreno.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, Me.cboHacienda.ParametroDet)
  End Sub

  Private Sub cboTerreno_CambioItem(sender As Object, e As System.EventArgs) Handles cboTerreno.CambioItem
    Me.cboLote.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, Me.cboTerreno.ParametroDet)
  End Sub

  Private Sub chkNulo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNulo.CheckedChanged
    Me.Panel2.Enabled = Not Me.chkNulo.Checked
  End Sub
End Class