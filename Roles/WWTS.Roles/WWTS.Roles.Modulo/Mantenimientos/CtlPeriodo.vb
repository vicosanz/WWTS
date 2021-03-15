Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports WWTS.Roles.Reglas
Imports WWTS.General.Reglas
Imports System.ComponentModel
Imports WWTS.General.Modulo

<ToolboxItem(True)> _
Public Class CtlPeriodo
  Inherits Infoware.Controles.Base.ListDB

  Private mPeriodoPagos As PeriodoPagoList
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

  Private mPardetPeriodoPago As WWTSParametroDet = Nothing
  Public Property PardetPeriodoPago() As WWTSParametroDet
    Get
      Return mPardetPeriodoPago
    End Get
    Set(ByVal Value As WWTSParametroDet)
      mPardetPeriodoPago = Value
    End Set
  End Property

  Public Property PeriodoPago() As PeriodoPago
    Get
      If mPeriodoPagos Is Nothing OrElse mPeriodoPagos.Count = 0 Then
        Return Nothing
      Else
        Return mPeriodoPagos(IIf(MyBase.SelectedIndex = -1, 0, MyBase.SelectedIndex))
      End If
    End Get
    Set(ByVal Value As PeriodoPago)
      If Value Is Nothing Then
        MyBase.SelectedIndex = -1
      Else
        For t As Integer = 0 To MyBase.Items.Count - 1
          If mPeriodoPagos(t).PerPag_FechaDesde = Value.PerPag_FechaDesde Then
            MyBase.SelectedIndex = t
            Exit For
          End If
        Next
      End If
      RaiseEvent CambioPeriodo()
    End Set
  End Property

  Public Sub llenar_datos(Optional ByVal _Periodo As PeriodoPago = Nothing)
    If mOp Is Nothing Then
      Exit Sub
    End If
    Me.Enabled = False
    Me.BeginUpdate()
    Me.DataSource = Nothing
    If _Periodo Is Nothing Then
      mPeriodoPagos = PeriodoPagoList.ObtenerLista(mOp, mPardetPeriodoPago)
    Else
      Me.mPeriodoPagos = New PeriodoPagoList
      Me.mPeriodoPagos.Add(_Periodo)
    End If
    Me.DataSource = mPeriodoPagos
    Me.ValueMember = "PerPag_FechaDesde"
    Me.DisplayMember = "Descripcion"
    Me.EndUpdate()
    Me.Enabled = True
    Me.SelectedIndex = IIf(mPeriodoPagos Is Nothing OrElse mPeriodoPagos.Count = 0, -1, 0)
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

    Dim f As New FrmPeriodo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.PeriodoPago = mPeriodoPagos(MyBase.SelectedIndex)
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

    Dim f As New FrmPeriodo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.PeriodoPago = mPeriodoPagos(MyBase.SelectedIndex)
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

    Dim f As New FrmPeriodo(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Personal)
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.PeriodoPago = New PeriodoPago(mOp, True)
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

