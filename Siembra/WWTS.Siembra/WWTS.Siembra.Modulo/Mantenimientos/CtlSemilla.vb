Imports System.ComponentModel

Imports WWTS.Siembra.Reglas
Imports WWTS.General.Modulo
Imports Infoware.Datos

<ToolboxItem(True)> _
Public Class CtlSemilla
  Inherits Infoware.Controles.Base.ComboBoxDB
  Implements IDatos

  Private mSemillas As SemillaSiembraCollection
  Public Event CambioSemilla()

#Region "Op"
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
    End Set
  End Property
#End Region

  Public Property Semilla() As SemillaSiembra
    Get
      If mSemillas Is Nothing OrElse mSemillas.Count = 0 Then
        Return Nothing
      Else
        Return mSemillas(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As SemillaSiembra)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mSemillas(t).Sem_codigo = Value.Sem_codigo Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioSemilla()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Semilla As SemillaSiembra = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Semilla Is Nothing Then
      mSemillas = SemillaSiembra.RetornarSemillas(mOp)
    Else
      Me.mSemillas = New SemillaSiembraCollection
      Me.mSemillas.Add(_Semilla)
    End If
    Me.DataSource = mSemillas
    Me.ValueMember = "Sem_codigo"
    Me.DisplayMember = "Sem_nombre"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mSemillas Is Nothing OrElse mSemillas.Count = 0, -1, 0)
    RaiseEvent CambioSemilla()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlSemilla_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlSemilla_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New FrmSemilla
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Semilla = mSemillas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlSemilla_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New FrmSemilla
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Semilla = mSemillas(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlSemilla_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New FrmSemilla
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Semilla = New SemillaSiembra(mOp, "Nuevo")
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlSemilla_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioSemilla()
  End Sub
End Class

