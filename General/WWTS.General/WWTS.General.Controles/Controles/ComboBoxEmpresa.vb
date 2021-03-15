Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
Imports WWTS.General.Reglas
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class ComboBoxEmpresa
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

  Private mEmpresas As EmpresaList
  Public Property Empresa() As Empresa
    Get
      If mEmpresas Is Nothing OrElse mEmpresas.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mEmpresas(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Empresa)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.Empres_Codigo
      End If
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
      MyBase.DisplayMember = "NombreCompleto"
      MyBase.ValueMember = "Empres_Codigo"
      mEmpresas = EmpresaList.ObtenerLista(mOp)
      MyBase.DataSource = mEmpresas
      'RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub
End Class

