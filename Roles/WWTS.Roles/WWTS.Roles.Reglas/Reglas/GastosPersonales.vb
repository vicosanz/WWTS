Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

#Region "GastosPersonales"
Public Class GastosPersonales
  Inherits _Database

  Const _Procedimiento As String = "proc_gastospersonales"

  Private mContrato As Contrato = Nothing

  Private mPardetTipoGasto As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  'PardetTipoGasto
  Public Overridable Property PardetTipoGasto() As WWTSParametroDet
    Get
      If Me.mPardetTipoGasto Is Nothing AndAlso Pardet_TipodeGasto > 0 Then
        Me.mPardetTipoGasto = New WWTSParametroDet(OperadorDatos, Parame_TipodeGasto, Pardet_TipodeGasto)
      End If
      Return Me.mPardetTipoGasto
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoGasto = value
      If value Is Nothing Then
        Parame_TipodeGasto = 0
        Pardet_TipodeGasto = 0
      Else
        Parame_TipodeGasto = value.Parame_Codigo
        Pardet_TipodeGasto = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'Contrato
  Public Overridable Property Contrato() As Contrato
    Get
      If Me.mContrato Is Nothing AndAlso Contra_Secuencia > 0 Then
        Me.mContrato = New Contrato(OperadorDatos, Entida_Codigo, Patron_Codigo, Contra_Secuencia)
      End If
      Return Me.mContrato
    End Get
    Set(ByVal value As Contrato)
      Me.mContrato = value
      Entida_Codigo = value.Entida_Codigo
      Patron_Codigo = value.Patron_Codigo
      Contra_Secuencia = value.Contra_Secuencia
    End Set
  End Property

  Public ReadOnly Property Gastos_mes_letra() As String
    Get
      Try
        Return Utilerias.listameses(Me.Gastos_mes)
      Catch
        Return String.Empty
      End Try
    End Get
  End Property

  Public Function SumaIngresos() As Decimal
    Dim dReturn As Decimal = 0
    dReturn = Gastos_Sueldo + Gastos_SubMaternidad + Gastos_SubEnfermedad + Gastos_Vacaciones + Gastos_Horas25 + Gastos_Horas50 + Gastos_Horas100 + Gastos_Horas100b + Gastos_Bonos + Gastos_BonoMeta + Gastos_BonosOtros + Gastos_IngresoVivienda + Gastos_SueldoSinAp + Gastos_SobretiempoSinAp + Gastos_IngresoAlimentacion + Gastos_Transporte + Gastos_SueldoOtros + Gastos_SobretiempoOtros + Gastos_Utilidades - Gastos_Aporte + Gastos_VacacionesOtros + Gastos_UtilidadesOtros - Gastos_AporteOtros
    Return dReturn
  End Function

  Public Function SumaGastos() As Decimal
    Dim dReturn As Decimal = 0
    dReturn = Gastos_Vivienda + Gastos_Salud + Gastos_Educacion + Gastos_Alimentacion + Gastos_Vestimenta
    Return dReturn
  End Function


  Public Function Uno(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "1")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Dos(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "2")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Tres(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "3")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Cuatro(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "4")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Cinco(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "5")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Seis(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "6")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Siete(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "7")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Ocho(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "8")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Nueve(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "9")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Diez(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "10")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Once(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "11")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Doce(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "12")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Trece(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "13")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Catorce(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "14")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Quince(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "15")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Diezseis(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "16")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Diezsiete(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "17")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Diezocho(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "18")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Dieznueve(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "19")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veinte(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "20")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veinteuno(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "21")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veintedos(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "22")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veintetres(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "23")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veintecuatro(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "24")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veintecinco(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "25")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veinteseis(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "26")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veintesiete(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "27")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veinteocho(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "28")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Veintenueve(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "29")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treinta(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "30")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treintauno(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "31")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treintados(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "32")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treintatres(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "33")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treintacuatro(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "34")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treintacinco(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "35")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function
  Public Function Treintaseis(ByVal cbo_Fecha_de_pago As Date, ByVal cbo_Patrono As Integer, ByVal cbo_Tipo As Integer) As Decimal
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As Decimal = 0

    With Me.OperadorDatos
      .AgregarParametro("@accion", "36")
      .AgregarParametro("@cbo_Fecha_de_pago", cbo_Fecha_de_pago)
      .AgregarParametro("@cbo_Patrono", cbo_Patrono)
      .AgregarParametro("@cbo_Tipo", cbo_Tipo)
      .Procedimiento = "proc_GastosPersonales"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CDec(dsResult.Rows(0)("valor"))
    End If
    Return oResult
  End Function






  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Patron_Codigo = CType(Fila("Patron_Codigo"), Integer)
    Contra_Secuencia = CType(Fila("Contra_Secuencia"), Integer)
    Gastos_anio = CType(Fila("Gastos_anio"), Integer)
    Gastos_mes = CType(Fila("Gastos_mes"), Integer)
    Parame_TipodeGasto = CType(Fila("Parame_TipodeGasto"), Integer)
    Pardet_TipodeGasto = CType(Fila("Pardet_TipodeGasto"), Integer)
    Gastos_Sueldo = CType(Fila("Gastos_Sueldo"), Decimal)
    Gastos_SubMaternidad = CType(Fila("Gastos_SubMaternidad"), Decimal)
    Gastos_SubEnfermedad = CType(Fila("Gastos_SubEnfermedad"), Decimal)
    Gastos_Vacaciones = CType(Fila("Gastos_Vacaciones"), Decimal)
    Gastos_Horas25 = CType(Fila("Gastos_Horas25"), Decimal)
    Gastos_Horas50 = CType(Fila("Gastos_Horas50"), Decimal)
    Gastos_Horas100 = CType(Fila("Gastos_Horas100"), Decimal)
    Gastos_Horas100b = CType(Fila("Gastos_Horas100b"), Decimal)
    Gastos_Bonos = CType(Fila("Gastos_Bonos"), Decimal) 'bono produccion
    Gastos_BonoMeta = CType(Fila("Gastos_BonoMeta"), Decimal)
    Gastos_BonosOtros = CType(Fila("Gastos_BonosOtros"), Decimal) 'bonificacion especial
    Gastos_IngresoVivienda = CType(Fila("Gastos_IngresoVivienda"), Decimal)
    Gastos_SueldoSinAp = CType(Fila("Gastos_SueldoSinAp"), Decimal)
    Gastos_SobretiempoSinAp = CType(Fila("Gastos_SobretiempoSinAp"), Decimal)
    Gastos_IngresoAlimentacion = CType(Fila("Gastos_IngresoAlimentacion"), Decimal)
    Gastos_Transporte = CType(Fila("Gastos_Transporte"), Decimal)
    Gastos_SueldoOtros = CType(Fila("Gastos_SueldoOtros"), Decimal)
    Gastos_SobretiempoOtros = CType(Fila("Gastos_SobretiempoOtros"), Decimal)
    Gastos_Utilidades = CType(Fila("Gastos_Utilidades"), Decimal)

    Gastos_VacacionesOtros = CType(Fila("Gastos_VacacionesOtros"), Decimal)
    Gastos_UtilidadesOtros = CType(Fila("Gastos_UtilidadesOtros"), Decimal)
    Gastos_AporteOtros = CType(Fila("Gastos_AporteOtros"), Decimal)

    Gastos_Aporte = CType(Fila("Gastos_Aporte"), Decimal)
    Gastos_Vivienda = CType(Fila("Gastos_Vivienda"), Decimal)
    Gastos_Salud = CType(Fila("Gastos_Salud"), Decimal)
    Gastos_Educacion = CType(Fila("Gastos_Educacion"), Decimal)
    Gastos_Alimentacion = CType(Fila("Gastos_Alimentacion"), Decimal)
    Gastos_Vestimenta = CType(Fila("Gastos_Vestimenta"), Decimal)

    Gastos_ImpuestoRenta = CType(Fila("Gastos_ImpuestoRenta"), Decimal)

    mPardetTipoGasto = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Gastos_anio", Gastos_anio)
    OperadorDatos.AgregarParametro("@Gastos_mes", Gastos_mes)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Gastos_anio", Gastos_anio)
    OperadorDatos.AgregarParametro("@Gastos_mes", Gastos_mes)
    OperadorDatos.AgregarParametro("@Parame_TipodeGasto", Parame_TipodeGasto)
    OperadorDatos.AgregarParametro("@Pardet_TipodeGasto", Pardet_TipodeGasto)
    OperadorDatos.AgregarParametro("@Gastos_Sueldo", Gastos_Sueldo)
    OperadorDatos.AgregarParametro("@Gastos_SubMaternidad", Gastos_SubMaternidad)
    OperadorDatos.AgregarParametro("@Gastos_SubEnfermedad", Gastos_SubEnfermedad)
    OperadorDatos.AgregarParametro("@Gastos_Vacaciones", Gastos_Vacaciones)
    OperadorDatos.AgregarParametro("@Gastos_Horas25", Gastos_Horas25)
    OperadorDatos.AgregarParametro("@Gastos_Horas50", Gastos_Horas50)
    OperadorDatos.AgregarParametro("@Gastos_Horas100", Gastos_Horas100)
    OperadorDatos.AgregarParametro("@Gastos_Horas100b", Gastos_Horas100b)
    OperadorDatos.AgregarParametro("@Gastos_Bonos", Gastos_Bonos) 'bono produccion
    OperadorDatos.AgregarParametro("@Gastos_BonoMeta", Gastos_BonoMeta)
    OperadorDatos.AgregarParametro("@Gastos_BonosOtros", Gastos_BonosOtros) 'bonificacion especial
    OperadorDatos.AgregarParametro("@Gastos_IngresoVivienda", Gastos_IngresoVivienda)
    OperadorDatos.AgregarParametro("@Gastos_SueldoSinAp", Gastos_SueldoSinAp)
    OperadorDatos.AgregarParametro("@Gastos_SobretiempoSinAp", Gastos_SobretiempoSinAp)
    OperadorDatos.AgregarParametro("@Gastos_IngresoAlimentacion", Gastos_IngresoAlimentacion)
    OperadorDatos.AgregarParametro("@Gastos_Transporte", Gastos_Transporte)
    OperadorDatos.AgregarParametro("@Gastos_SueldoOtros", Gastos_SueldoOtros)
    OperadorDatos.AgregarParametro("@Gastos_SobretiempoOtros", Gastos_SobretiempoOtros)
    OperadorDatos.AgregarParametro("@Gastos_Utilidades", Gastos_Utilidades)

    OperadorDatos.AgregarParametro("@Gastos_VacacionesOtros", Gastos_VacacionesOtros)
    OperadorDatos.AgregarParametro("@Gastos_UtilidadesOtros", Gastos_UtilidadesOtros)
    OperadorDatos.AgregarParametro("@Gastos_AporteOtros", Gastos_AporteOtros)

    OperadorDatos.AgregarParametro("@Gastos_Aporte", Gastos_Aporte)
    OperadorDatos.AgregarParametro("@Gastos_Vivienda", Gastos_Vivienda)
    OperadorDatos.AgregarParametro("@Gastos_Salud", Gastos_Salud)
    OperadorDatos.AgregarParametro("@Gastos_Educacion", Gastos_Educacion)
    OperadorDatos.AgregarParametro("@Gastos_Alimentacion", Gastos_Alimentacion)
    OperadorDatos.AgregarParametro("@Gastos_Vestimenta", Gastos_Vestimenta)

    OperadorDatos.AgregarParametro("@Gastos_ImpuestoRenta", Gastos_ImpuestoRenta)

    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      EsNuevo = False
      EsModificado = False
      If Not OperadorDatos.EstaenTransaccion Then
        AceptarCambios()
      End If
    End If
    Return bReturn
  End Function

  Public Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.AgregarParametro("@Patron_Codigo", Patron_Codigo)
    OperadorDatos.AgregarParametro("@Contra_Secuencia", Contra_Secuencia)
    OperadorDatos.AgregarParametro("@Gastos_anio", Gastos_anio)
    OperadorDatos.AgregarParametro("@Gastos_mes", Gastos_mes)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function

End Class
#End Region

#Region "GastosPersonalesList"
Public Class GastosPersonalesList
  Inherits System.ComponentModel.BindingList(Of GastosPersonales)

  Public Shared Function ObtenerLista(ByVal _Contrato As Contrato, ByVal _anio As Integer, ByVal _parametro As WWTSParametroDet, Optional ByVal _filtro As String = "") As GastosPersonalesList
    Dim oResult As GastosPersonalesList = New GastosPersonalesList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Contrato.OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Entida_Codigo", _Contrato.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Contrato.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Contrato.Contra_Secuencia)
      .AgregarParametro("@Gastos_anio", _anio)
      .AgregarParametro("@Parame_TipodeGasto", _parametro.Parame_Codigo)
      .AgregarParametro("@Pardet_TipodeGasto", _parametro.Pardet_Secuencia)
      '.AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_gastospersonales"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New GastosPersonales(_Contrato.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

End Class
#End Region