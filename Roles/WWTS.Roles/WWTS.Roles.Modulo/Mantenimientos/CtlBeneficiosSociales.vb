Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlBeneficiosSociales
  Inherits Infoware.Controles.Base.ListDB

  Private mBeneficosSocialesList As BeneficiosSocialesList
  Public Event CambioPeriodo()

#Region "Op"
  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
    End Set
  End Property
#End Region

  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(ByVal Value As Contrato)
      mContrato = Value
    End Set
  End Property

  Public Property Vacacion() As BeneficiosSociales
    Get
      If mBeneficosSocialesList Is Nothing OrElse mBeneficosSocialesList.Count = 0 Then
        Return Nothing
      Else
        Return mBeneficosSocialesList(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As BeneficiosSociales)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mBeneficosSocialesList(t).BenSoc_Secuencia = Value.BenSoc_Secuencia Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioPeriodo()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _BeneficosSociales As BeneficiosSociales = Nothing)
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _BeneficosSociales Is Nothing Then
      mBeneficosSocialesList = BeneficiosSocialesList.ObtenerListaxContrato(Contrato)
    Else
      Me.mBeneficosSocialesList = New BeneficiosSocialesList
      Me.mBeneficosSocialesList.Add(_BeneficosSociales)
    End If
    Me.DataSource = mBeneficosSocialesList
    Me.ValueMember = "BenSoc_Secuencia"
    Me.DisplayMember = "PeriodoVacDiasPendientes"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mBeneficosSocialesList Is Nothing OrElse mBeneficosSocialesList.Count = 0, -1, 0)
    RaiseEvent CambioPeriodo()
  End Sub

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = True
  End Sub

  Private Sub CtlPeriodo_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Me.llenar_datos()
  End Sub

  Private Sub CtlPeriodo_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoVacacion(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.Vacacion = mBeneficosSocialesList(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlPeriodo_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoVacacion(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.Vacacion = mBeneficosSocialesList(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlPeriodo_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoVacacion(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.Vacacion = New BeneficiosSociales(mOp, True, Nothing, Nothing)
    f.Vacacion.Contrato = Contrato
    If f.ShowDialog() = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

  Private Sub CtlPeriodo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    If Not Me.Enabled Then
      Exit Sub
    End If
    RaiseEvent CambioPeriodo()
  End Sub
End Class

