Imports Infoware.Datos
Imports Infoware.Controles.Base
'Imports Infoware.Modulos.Base
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class ComboBoxConexion
  Inherits ComboBoxDB

  Private mArchivoxml As String
  Public Property Archivoxml() As String
    Get
      Return mArchivoxml
    End Get
    Set(ByVal value As String)
      mArchivoxml = value
    End Set
  End Property

  Private mConexiones As OperadorDatosList

  Public ReadOnly Property OperadorDatos() As OperadorDatos
    Get
      If mConexiones Is Nothing OrElse mConexiones.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mConexiones(MyBase.SelectedIndex)
      End If
    End Get
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = False
  End Sub

  Public Sub Llenar_datos()
    MyBase.DisplayMember = "Descripcion"
    mConexiones = OperadorDatosList.dexml(Archivoxml)
    MyBase.DataSource = mConexiones
  End Sub

  Private Sub CtlConexion_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmConexion
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.OperadorDatos = mConexiones(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      mConexiones.RemoveAt(MyBase.SelectedIndex)
      mConexiones.axml(Archivoxml)
      Llenar_datos()
    End If
  End Sub

  Private Sub CtlConexion_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmConexion
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.OperadorDatos = mConexiones(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      mConexiones.axml(Archivoxml)
      Llenar_datos()
    End If
  End Sub

  Private Sub CtlConexion_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmConexion
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.OperadorDatos = Nothing ' New OperadorDatos("(local)", "salesmanager", "sa", String.Empty, True)
    If f.ShowDialog() = DialogResult.OK Then
      mConexiones.Add(f.OperadorDatos)
      mConexiones.axml(Archivoxml)
      MyBase.DataSource = Nothing
      MyBase.DisplayMember = "Descripcion"
      MyBase.DataSource = mConexiones
      Llenar_datos()
    End If
  End Sub
End Class

