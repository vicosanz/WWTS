
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class GastosPersonales
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mPatron_Codigo As Integer = 0

  Private mContra_Secuencia As Integer = 0

  Private mGastos_anio As Integer = 0

  Private mGastos_mes As Integer = 0

  Private mParame_TipodeGasto As Integer = 0

  Private mPardet_TipodeGasto As Integer = 0

  Private mGastos_Sueldo As Decimal = 0

  Private mGastos_SubEnfermedad As Decimal = 0

  Private mGastos_SubMaternidad As Decimal = 0

  Private mGastos_Vacaciones As Decimal = 0

  Private mGastos_Horas25 As Decimal = 0

  Private mGastos_Horas50 As Decimal = 0

  Private mGastos_Horas100 As Decimal = 0

  Private mGastos_Horas100b As Decimal = 0

  Private mGastos_Sobretiempo As Decimal = 0

  Private mGastos_Bonos As Decimal = 0 'bono de produccion

  Private mGastos_BonoMeta As Decimal = 0

  Private mGastos_BonosOtros As Decimal = 0 'bonificacion especial

  Private mGastos_IngresoVivienda As Decimal = 0

  Private mGastos_SueldoSinAp As Decimal = 0

  Private mGastos_SobretiempoSinAp As Decimal = 0

  Private mGastos_IngresoAlimentacion As Decimal = 0

  Private mGastos_Transporte As Decimal = 0

  Private mGastos_Utilidades As Decimal = 0

  Private mGastos_SueldoOtros As Decimal = 0

  Private mGastos_SobretiempoOtros As Decimal = 0


  Private mGastos_VacacionesOtros As Decimal = 0

  Private mGastos_UtilidadesOtros As Decimal = 0

  Private mGastos_AporteOtros As Decimal = 0


  Private mGastos_Aporte As Decimal = 0

  Private mGastos_Vivienda As Decimal = 0

  Private mGastos_Salud As Decimal = 0

  Private mGastos_Educacion As Decimal = 0

  Private mGastos_Alimentacion As Decimal = 0

  Private mGastos_Vestimenta As Decimal = 0


  Private mGastos_ImpuestoRenta As Decimal = 0

  Public Sub New()
    MyBase.New()
  End Sub

  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Patron_Codigo() As Integer
    Get
      Return Me.mPatron_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mPatron_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Contra_Secuencia() As Integer
    Get
      Return Me.mContra_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mContra_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_anio() As Integer
    Get
      Return Me.mGastos_anio
    End Get
    Set(ByVal value As Integer)
      Me.mGastos_anio = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_mes() As Integer
    Get
      Return Me.mGastos_mes
    End Get
    Set(ByVal value As Integer)
      Me.mGastos_mes = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_TipodeGasto() As Integer
    Get
      Return Me.mParame_TipodeGasto
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipodeGasto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_TipodeGasto() As Integer
    Get
      Return Me.mPardet_TipodeGasto
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipodeGasto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Sueldo() As Decimal
    Get
      Return Me.mGastos_Sueldo
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Sueldo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Horas25() As Decimal
    Get
      Return Me.mGastos_Horas25
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Horas25 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Horas50() As Decimal
    Get
      Return Me.mGastos_Horas50
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Horas50 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Horas100() As Decimal
    Get
      Return Me.mGastos_Horas100
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Horas100 = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Horas100b() As Decimal
    Get
      Return Me.mGastos_Horas100b
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Horas100b = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Bonos() As Decimal 'bono produccion
    Get
      Return Me.mGastos_Bonos
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Bonos = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_SueldoOtros() As Decimal
    Get
      Return Me.mGastos_SueldoOtros
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_SueldoOtros = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_SobretiempoOtros() As Decimal
    Get
      Return Me.mGastos_SobretiempoOtros
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_SobretiempoOtros = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_BonosOtros() As Decimal 'bonificacion especial
    Get
      Return Me.mGastos_BonosOtros
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_BonosOtros = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Vivienda() As Decimal
    Get
      Return Me.mGastos_Vivienda
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Vivienda = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Educacion() As Decimal
    Get
      Return Me.mGastos_Educacion
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Educacion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Salud() As Decimal
    Get
      Return Me.mGastos_Salud
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Salud = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Vestimenta() As Decimal
    Get
      Return Me.mGastos_Vestimenta
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Vestimenta = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_IngresoAlimentacion() As Decimal
    Get
      Return Me.mGastos_IngresoAlimentacion
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_IngresoAlimentacion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Transporte() As Decimal
    Get
      Return Me.mGastos_Transporte
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Transporte = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Vacaciones() As Decimal
    Get
      Return Me.mGastos_Vacaciones
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Vacaciones = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Aporte() As Decimal
    Get
      Return Me.mGastos_Aporte
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Aporte = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Alimentacion() As Decimal
    Get
      Return Me.mGastos_Alimentacion
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Alimentacion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_Utilidades() As Decimal
    Get
      Return Me.mGastos_Utilidades
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_Utilidades = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_IngresoVivienda() As Decimal
    Get
      Return Me.mGastos_IngresoVivienda
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_IngresoVivienda = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_SubEnfermedad() As Decimal
    Get
      Return Me.mGastos_SubEnfermedad
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_SubEnfermedad = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_SubMaternidad() As Decimal
    Get
      Return Me.mGastos_SubMaternidad
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_SubMaternidad = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_BonoMeta() As Decimal
    Get
      Return Me.mGastos_BonoMeta
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_BonoMeta = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_SueldoSinAp() As Decimal
    Get
      Return Me.mGastos_SueldoSinAp
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_SueldoSinAp = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_SobretiempoSinAp() As Decimal
    Get
      Return Me.mGastos_SobretiempoSinAp
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_SobretiempoSinAp = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_VacacionesOtros() As Decimal
    Get
      Return Me.mGastos_VacacionesOtros
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_VacacionesOtros = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_UtilidadesOtros() As Decimal
    Get
      Return Me.mGastos_UtilidadesOtros
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_UtilidadesOtros = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Gastos_AporteOtros() As Decimal
    Get
      Return Me.mGastos_AporteOtros
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_AporteOtros = value
      EsModificado = True
    End Set
  End Property


  Public Overridable Property Gastos_ImpuestoRenta() As Decimal
    Get
      Return Me.mGastos_ImpuestoRenta
    End Get
    Set(ByVal value As Decimal)
      Me.mGastos_ImpuestoRenta = value
      EsModificado = True
    End Set
  End Property

End Class
