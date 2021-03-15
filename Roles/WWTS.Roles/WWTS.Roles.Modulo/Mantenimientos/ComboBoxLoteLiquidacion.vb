Imports Infoware.Datos
Imports Infoware.Controles.Base
Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
'Imports WWTS.Inventario.Reglas
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class ComboBoxLoteLiquidacion
  Inherits ComboBoxDB

  Private mPatrono As Patrono = Nothing
  Public Property Patrono() As Patrono
    Get
      Return mPatrono
    End Get
    Set(ByVal value As Patrono)
      mPatrono = value
    End Set
  End Property

  Private mPardetTipoBeneficio As WWTSParametroDet = Nothing
  Public Property PardetTipoBeneficio() As WWTSParametroDet
    Get
      Return mPardetTipoBeneficio
    End Get
    Set(ByVal value As WWTSParametroDet)
      mPardetTipoBeneficio = value
    End Set
  End Property

  Private mBeneficiosSocialesLotePagos As BeneficiosSocialesLotePagoList
  Public Property BeneficiosSocialesLotePago() As BeneficiosSocialesLotePago
    Get
      If mBeneficiosSocialesLotePagos Is Nothing OrElse mBeneficiosSocialesLotePagos.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mBeneficiosSocialesLotePagos(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As BeneficiosSocialesLotePago)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.BenLot_Codigo
      End If
    End Set
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = False
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Public Sub Llenar_datos()
    MyBase.DisplayMember = "BenLot_Codigo"
    MyBase.ValueMember = "BenLot_Codigo"
    mBeneficiosSocialesLotePagos = BeneficiosSocialesLotePagoList.ObtenerLista(mPatrono, mPardetTipoBeneficio)
    MyBase.DataSource = mBeneficiosSocialesLotePagos
  End Sub

  Private Sub ComboBoxLoteLiquidacion_ComandoActualizar(sender As Object, e As System.EventArgs) Handles Me.ComandoActualizar
    Llenar_datos()
  End Sub

  Private Sub ComboBoxLoteLiquidacion_ComandoEliminar(sender As Object, e As System.EventArgs) Handles Me.ComandoEliminar
    Try
      mBeneficiosSocialesLotePagos(MyBase.SelectedIndex).Eliminar()
      Llenar_datos()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub ComboBoxLoteLiquidacion_ComandoNuevo(sender As Object, e As System.EventArgs) Handles Me.ComandoNuevo
    If mPatrono Is Nothing Then
      Exit Sub
    End If
    Dim _lote As New BeneficiosSocialesLotePago(mPatrono.OperadorDatos, True)
    _lote.Patron_Codigo = mPatrono.Patron_Codigo
    _lote.PardetTipoBeneficio = mPardetTipoBeneficio
    _lote.BenLot_FechaGeneracion = Now.Date
    _lote.Guardar()
    Llenar_datos()
  End Sub
End Class

