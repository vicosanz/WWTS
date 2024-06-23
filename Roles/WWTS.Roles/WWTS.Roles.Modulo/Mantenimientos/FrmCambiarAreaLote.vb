Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.General.Modulo

Public Class FrmCambiarAreaLote
  Implements IMantenimiento

  Public Property Area() As WWTSParametroDet
    Get
      Return Me.ComboBoxParametroDet1.ParametroDet
    End Get
    Set(value As WWTSParametroDet)
      Me.ComboBoxParametroDet1.ParametroDet = value
    End Set
  End Property

  Public Property Lote() As WWTSParametroDet
    Get
      Return Me.cboLote.ParametroDet
    End Get
    Set(value As WWTSParametroDet)
      Me.cboHacienda.ParametroDet = value.PardetPadre.PardetPadre
      Me.cboTerreno.ParametroDet = value.PardetPadre
      Me.cboLote.ParametroDet = value
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

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.ComboBoxParametroDet1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.Area
    Me.ComboBoxParametroDet1.Llenar_Datos()

    Me.cboHacienda.OperadorDatos = Sistema.OperadorDatos
    Me.cboTerreno.OperadorDatos = Sistema.OperadorDatos
    Me.cboLote.OperadorDatos = Sistema.OperadorDatos
    Me.cboHacienda.Parametro = Enumerados.EnumParametros.Hacienda
    Me.cboTerreno.Parametro = Enumerados.EnumParametros.Terreno
    Me.cboLote.Parametro = Enumerados.EnumParametros.Lote
    Me.cboHacienda.Llenar_Datos()

  End Sub
#End Region

  Private Sub cboHacienda_CambioItem(sender As Object, e As System.EventArgs) Handles cboHacienda.CambioItem
    Me.cboTerreno.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, Me.cboHacienda.ParametroDet)
  End Sub

  Private Sub cboTerreno_CambioItem(sender As Object, e As System.EventArgs) Handles cboTerreno.CambioItem
    Me.cboLote.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, Me.cboTerreno.ParametroDet)
  End Sub

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
End Class