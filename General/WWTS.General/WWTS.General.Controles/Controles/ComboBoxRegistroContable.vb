Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
'Imports Infoware.Controles.Base
Imports WWTS.General.Reglas
'Imports WWTS.Contabilidad.Reglas
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class ComboBoxRegistroContable
  Inherits ComboBoxDB

  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      Llenar_datos()
    End Set
  End Property

  Private mRegistroContables As RegistroContableList
  Public Property RegistroContable() As RegistroContable
    Get
      If mRegistroContables Is Nothing OrElse mRegistroContables.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mRegistroContables(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As RegistroContable)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.RegCtb_Secuencia
      End If
    End Set
  End Property

  Public Property RegistroContables() As RegistroContableList
    Get
      Return mRegistroContables
    End Get
    Set(ByVal value As RegistroContableList)
      mRegistroContables = value
    End Set
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = False
    MyBase.PuedeModificar = False
    MyBase.PuedeEliminar = False
    MyBase.PuedeActualizar = False
  End Sub

  Public Sub Llenar_datos()
    If mOperadorDatos Is Nothing Then
      MyBase.DataSource = Nothing
    Else
      MyBase.DisplayMember = "RegCtb_Descripcion"
      MyBase.ValueMember = "RegCtb_Secuencia"
      mRegistroContables = RegistroContableList.ObtenerLista(mOperadorDatos)
      MyBase.DataSource = mRegistroContables
    End If
  End Sub
End Class

