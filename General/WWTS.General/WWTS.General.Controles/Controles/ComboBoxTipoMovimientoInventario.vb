Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
Imports WWTS.General.Reglas
Imports System.ComponentModel
Imports WWTS.Slots.Reglas

<ToolboxItem(True)> _
Public Class ComboBoxTipoMovimientoInventario
  Inherits ComboBoxDB
  Implements IDatos

  Private mOp As OperadorDatos = Nothing
  Public Property Op() As Infoware.Datos.OperadorDatos Implements Infoware.Datos.IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As Infoware.Datos.OperadorDatos)
      mOp = value
      Llenar_datos()
    End Set
  End Property

  Private mTipoInventarios As TipoInventarioxUsuarioList
  Public Property TipoInventario() As TipoInventarioxUsuario
    Get
      If mTipoInventarios Is Nothing OrElse mTipoInventarios.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mTipoInventarios(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As TipoInventarioxUsuario)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.ParameTipoInventario.Pardet_Descripcion
      End If
    End Set
  End Property

  Public ReadOnly Property PardetTipoMovimientoInventario As WWTSParametroDet
    Get
      If TipoInventario.ParameTipoInventario Is Nothing Then
        Return Nothing
      Else
        Return TipoInventario.ParameTipoInventario
      End If
    End Get
  End Property

  Private mUsuario As String
  Public Property Usuario() As String
    Get
      Return mUsuario
    End Get
    Set(ByVal value As String)
      mUsuario = value
    End Set
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = False
    MyBase.PuedeModificar = False
    MyBase.PuedeEliminar = False
    MyBase.PuedeActualizar = False
  End Sub

  Public Sub Llenar_datos()
    If mOp Is Nothing Then
      MyBase.DataSource = Nothing
    Else
      MyBase.DisplayMember = "TipoInventarioString"
      MyBase.ValueMember = "TipoInventarioInt"
      mTipoInventarios = TipoInventarioxUsuarioList.ObtenerListaPorUsuario(Me.Op, Usuario)
      MyBase.DataSource = mTipoInventarios
      'RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub
End Class

