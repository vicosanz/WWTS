Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas

Public Class AcumSueldo
  Inherits _Database

#Region "Campos constantes"
  Private Const _Procedimiento As String = "proc_sueldomensual"
#End Region

#Region "Campos variables"
  Private mEntida_Codigo As Integer = 0
  Private mPatron_Codigo As Integer = 0
  Private mContra_Secuencia As Integer = -1
  Private mContrato As Contrato = Nothing

  Private mSueMen_diastrab As Decimal = 0.0
  Private mSueMen_diasvac As Decimal = 0.0
  Private mSueMen_sueldo As Decimal = 0.0
  Private mSueMen_antiguedad As Decimal = 0.0
  Private mSueMen_vacaciones As Decimal = 0.0

  Private mDecimoTercero As Decimal = 0.0
  Private mDecimoCuarto As Decimal = 0.0

  Private mDecimoTerceroCalculado As Decimal = 0.0
  Private mDecimoCuartoCalculado As Decimal = 0.0
  Private mVacacionesCalculado As Decimal = 0.0
#End Region

#Region "Propiedades públicas de la clase"
  Public ReadOnly Property Contrato() As Contrato
    Get
      If mContrato Is Nothing And mPatron_Codigo <> 0 And mEntida_Codigo <> 0 And mContra_Secuencia > 0 Then
        mContrato = New Contrato(Me.OperadorDatos, mEntida_Codigo, mPatron_Codigo, Me.mContra_Secuencia)
      End If
      Return mContrato
    End Get
  End Property
  Public ReadOnly Property SueMen_diastrab() As Decimal
    Get
      Return mSueMen_diastrab
    End Get
  End Property
  Public ReadOnly Property SueMen_diasvac() As Decimal
    Get
      Return mSueMen_diasvac
    End Get
  End Property
  Public ReadOnly Property SueMen_sueldo() As Decimal
    Get
      Return mSueMen_sueldo
    End Get
  End Property
  Public ReadOnly Property SueMen_antiguedad() As Decimal
    Get
      Return mSueMen_antiguedad
    End Get
  End Property
  Public ReadOnly Property SueMen_vacaciones() As Decimal
    Get
      Return mSueMen_vacaciones
    End Get
  End Property
  Public ReadOnly Property DecimoTercero() As Decimal
    Get
      Return mDecimoTercero
    End Get
  End Property
  Public ReadOnly Property DecimoCuarto() As Decimal
    Get
      Return mDecimoCuarto
    End Get
  End Property
  Public ReadOnly Property DecimoTerceroCalculado() As Decimal
    Get
      Return mDecimoTerceroCalculado
    End Get
  End Property
  Public ReadOnly Property DecimoCuartoCalculado() As Decimal
    Get
      Return mDecimoCuartoCalculado
    End Get
  End Property
  Public ReadOnly Property VacacionesCalculado() As Decimal
    Get
      Return mVacacionesCalculado
    End Get
  End Property

  Public ReadOnly Property Entida_Codigo() As Integer
    Get
      Try
        Return Contrato.Entida_Codigo
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public ReadOnly Property Nombres() As String
    Get
      Try
        Return Contrato.Empleado.NombreCompleto
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public ReadOnly Property Cedula() As String
    Get
      Try
        Return Contrato.Empleado.Entidadnatural.Entidad.Cedula
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property
#End Region

#Region "Constructores de la clase"
  Private Sub New(ByVal _OperadorDatos As OperadorDatos)
    If _OperadorDatos Is Nothing Then
      Throw New InvalidOperationException("El operador de datos es nulo")
    End If
    OperadorDatos = _OperadorDatos
  End Sub
#End Region

#Region "Métodos internos de la clase"
  Private Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    mEntida_Codigo = CInt(Fila("Entida_Codigo"))
    mPatron_Codigo = CInt(Fila("Patron_Codigo"))
    mContra_Secuencia = CInt(Fila("Contra_Secuencia"))
    mContrato = Nothing

    mSueMen_diastrab = CDec(Fila("SueMen_diastrab"))
    mSueMen_diasvac = CDec(Fila("SueMen_diasvac"))
    mSueMen_sueldo = CDec(Fila("SueMen_sueldo"))
    mSueMen_antiguedad = CDec(Fila("SueMen_antiguedad"))
    mSueMen_vacaciones = CDec(Fila("SueMen_vacaciones"))

    mDecimoTercero = CDec(Fila("DecimoTercero"))
    mDecimoCuarto = CDec(Fila("DecimoCuarto"))

    mDecimoTerceroCalculado = CDec(Fila("DecimoTerceroCalculado"))
    'mDecimoCuartoCalculado = CDec(Fila("DecimoCuartoCalculado"))
    Dim _configroles As New ConfigRoles(OperadorDatos, Contrato.Patrono.PardetParroquia.PardetPadre.PardetPadre.PardetPadre, False)
    mDecimoCuartoCalculado = _configroles.Cnfrol_salariomv / 360 * (mSueMen_diastrab + mSueMen_diasvac)
    mVacacionesCalculado = CDec(Fila("VacacionesCalculado"))
  End Sub
#End Region

#Region "Métodos compartidos"
  Public Shared Function RetornarAcumSueldos(ByVal _OperadorDatos As OperadorDatos, ByVal _solopatrono As Boolean, ByVal _patrono As Patrono, ByVal _solocontrato As Boolean, ByVal _tipocontrato As TipoContrato, ByVal _aniodesde As Integer, ByVal _mesdesde As Integer, ByVal _aniohasta As Integer, ByVal _meshasta As Integer) As AcumSueldoList
    Dim oResult As New AcumSueldoList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable

    Dim _fecdesde As DateTime
    Dim _fechasta As DateTime
    _fecdesde = DateSerial(_aniodesde, _mesdesde, 1)
    _fechasta = DateSerial(_aniohasta + IIf(_mesdesde = 12, 1, 0), IIf(_mesdesde = 12, 1, _mesdesde + 1), 1).AddDays(-1)

    With _OperadorDatos
      .AgregarParametro("@accion", "acsu")
      If _solopatrono Then
        .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      End If
      If _solocontrato Then
        .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      End If
      .AgregarParametro("@aniodesde", _aniodesde)
      .AgregarParametro("@mesdesde", _mesdesde)
      .AgregarParametro("@aniohasta", _aniohasta)
      .AgregarParametro("@meshasta", _meshasta)
      .AgregarParametro("@desde", _fecdesde)
      .AgregarParametro("@hasta", _fechasta)
      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New AcumSueldo(_OperadorDatos)
        _obj.MapearDataRowaObjeto(_dr)
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function
#End Region
End Class

Public Class AcumSueldoList
  Inherits System.ComponentModel.BindingList(Of AcumSueldo)
  Public Sub New()
  End Sub
End Class