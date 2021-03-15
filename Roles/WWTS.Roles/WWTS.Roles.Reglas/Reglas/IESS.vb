Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas

Public Class IESS
  Inherits _Database

#Region "Campos constantes"
  Private Const _Procedimiento As String = "proc_sueldomensual"
#End Region

#Region "Campos variables"
  Private mEntida_Codigo As Integer = 0
  Private mNombres As String = String.Empty
  Private mCedula As String = String.Empty
  Private mPer_ciess As String = String.Empty
  Private mAsistencia As Decimal = 0.0
  Private mFaltas As Decimal = 0.0
  Private mHtrab As Integer = 0
  Private mHlv As Integer = 0
  Private mHsdf As Integer = 0
  Private mValSueldo As Decimal = 0.0
  Private mValHorasExtras As Decimal = 0.0
  Private mValIESS As Decimal = 0.0
  Private mDesde As DateTime = Nothing
  Private mHasta As DateTime = Nothing
  Private mSueldo As Decimal = 0.0
  Private mAntiguedad As Decimal = 0.0
  Private mPatron_Codigo As Integer = 0
  Private mContra_Secuencia As Integer = 0
  Private mContrato As Contrato = Nothing
#End Region

#Region "Propiedades públicas de la clase"
  Public ReadOnly Property Entida_Codigo() As Integer
    Get
      Return mEntida_Codigo
    End Get
  End Property
  Public ReadOnly Property Nombres() As String
    Get
      Return mNombres
    End Get
  End Property
  Public ReadOnly Property Cedula() As String
    Get
      Return mCedula
    End Get
  End Property
  Public ReadOnly Property Per_ciess() As String
    Get
      Return mPer_ciess
    End Get
  End Property
  Public ReadOnly Property Asistencia() As Decimal
    Get
      Return mAsistencia
    End Get
  End Property
  Public ReadOnly Property Faltas() As Decimal
    Get
      Return mFaltas
    End Get
  End Property
  Public ReadOnly Property Htrab() As Integer
    Get
      Return mHtrab
    End Get
  End Property
  Public ReadOnly Property Hlv() As Integer
    Get
      Return mHlv
    End Get
  End Property
  Public ReadOnly Property Hsdf() As Integer
    Get
      Return mHsdf
    End Get
  End Property
  Public ReadOnly Property Desde() As DateTime
    Get
      Return mDesde
    End Get
  End Property
  Public ReadOnly Property Hasta() As DateTime
    Get
      Return mHasta
    End Get
  End Property
  Public ReadOnly Property DesdeStr() As String
    Get
      Return IIf(mDesde = Nothing, String.Empty, mDesde.ToShortDateString)
    End Get
  End Property
  Public ReadOnly Property HastaStr() As String
    Get
      Return IIf(mHasta = Nothing, String.Empty, mHasta.ToShortDateString)
    End Get
  End Property
  Public ReadOnly Property ValSueldo() As Decimal
    Get
      Return mValSueldo
    End Get
  End Property
  Public ReadOnly Property ValHorasExtras() As Decimal
    Get
      Return mValHorasExtras
    End Get
  End Property
  Public ReadOnly Property ValIESS() As Decimal
    Get
      Return mValIESS
    End Get
  End Property
  Public ReadOnly Property Sueldo() As Decimal
    Get
      Return mSueldo
    End Get
  End Property
  Public ReadOnly Property Antiguedad() As Decimal
    Get
      Return mAntiguedad
    End Get
  End Property
  Public ReadOnly Property Contrato() As Contrato
    Get
      If mContrato Is Nothing AndAlso Not mContra_Secuencia = 0 Then
        mContrato = New Contrato(OperadorDatos, Entida_Codigo, mPatron_Codigo, mContra_Secuencia)
      End If
      Return mContrato
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
    Me.mEntida_Codigo = CInt(Fila("Entida_Codigo"))
    Me.mNombres = CStr(Fila("Nombres"))
    Me.mCedula = CStr(Fila("Cedula"))
    Dim obj As Object
    obj = Fila("per_ciess")
    If TypeOf obj Is DBNull Then
      Me.mPer_ciess = ""
    Else
      Me.mPer_ciess = CStr(obj)
    End If
    Me.mAsistencia = CDec(Fila("Asistencia"))
    Me.mFaltas = CDec(Fila("Faltas"))
    Me.mHtrab = CInt(Fila("Htrab"))
    Me.mHlv = CInt(Fila("Hlv"))
    Me.mHsdf = CInt(Fila("Hsdf"))

    Me.mValSueldo = CDec(Fila("ValSueldo"))
    Me.mValHorasExtras = CDec(Fila("ValHorasExtras"))
    Me.mValIESS = CDec(Fila("ValIESS"))

    obj = Fila("Desde")
    If TypeOf obj Is DBNull Then
      mDesde = Nothing
    Else
      mDesde = CDate(obj)
    End If
    obj = Fila("Hasta")
    If TypeOf obj Is DBNull Then
      mHasta = Nothing
    Else
      mHasta = CDate(obj)
    End If

    Me.mSueldo = CDec(Fila("con_sueldo"))
    Me.mAntiguedad = CDec(Fila("con_antiguedad"))
    Me.mPatron_Codigo = CInt(Fila("Patron_Codigo"))
    Me.mContra_Secuencia = CInt(Fila("Contra_Secuencia"))
    Me.mContrato = Nothing
  End Sub
#End Region

#Region "Métodos compartidos"
  Public Shared Function RetornarIESSES(ByVal _OperadorDatos As OperadorDatos, ByVal _patrono As Patrono, ByVal _solocontrato As Boolean, ByVal _tipocontrato As TipoContrato, ByVal _desde As Date, ByVal _hasta As Date) As IESSList
    Dim oResult As New IESSList
    Dim bReturn As Boolean
    Dim dsResult As New DataTable
    With _OperadorDatos
      .AgregarParametro("@accion", "IE")
      .AgregarParametro("@Patron_Codigo", _patrono.Patron_Codigo)
      If _solocontrato Then
        .AgregarParametro("@TipCon_Codigo", _tipocontrato.TipCon_Codigo)
      End If
      .AgregarParametro("@desde", _desde.Date)
      .AgregarParametro("@hasta", _hasta.Date)
      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso dsResult IsNot Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New IESS(_OperadorDatos)
        _obj.MapearDataRowaObjeto(_dr)
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function
#End Region
End Class

Public Class IESSList
  Inherits System.ComponentModel.BindingList(Of IESS)
  Public Sub New()

  End Sub

End Class