
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Partial Public Class SeleccionDet
  Inherits _Database

  Private mSelecc_Codigo As Integer = 0

  Private mEntida_Codigo As Integer = 0

  Private mSelDet_FechaHora As DateTime = Now.Date

  Private mSelDet_Observaciones As String = ""

  Private mParame_ResultadoSeleccion As Integer = 0

  Private mPardet_ResultadoSeleccion As Integer = 0

  Private mSelDet_esAprobadoRRHH As Boolean = False

  Private mSelDet_esAprobadoDpto As Boolean = False

  Private mParame_DepartamentoCargo As Integer = 0

  Private mPardet_DepartamentoCargo As Integer = 0

  Private mParame_AreaCargo As Integer = 0

  Private mPardet_AreaCargo As Integer = 0

  Private mCargo_Secuencia As Integer = 0

  Private mCargo_EmpleadoActual As String = ""

  Public Sub New()
    MyBase.New()
  End Sub

  Public Overridable Property Selecc_Codigo() As Integer
    Get
      Return Me.mSelecc_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mSelecc_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property SelDet_FechaHora() As Date
    Get
      Return Me.mSelDet_FechaHora
    End Get
    Set(ByVal value As Date)
      Me.mSelDet_FechaHora = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property SelDet_Observaciones() As String
    Get
      Return Me.mSelDet_Observaciones
    End Get
    Set(ByVal value As String)
      Me.mSelDet_Observaciones = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_ResultadoSeleccion() As Integer
    Get
      Return Me.mParame_ResultadoSeleccion
    End Get
    Set(ByVal value As Integer)
      Me.mParame_ResultadoSeleccion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_ResultadoSeleccion() As Integer
    Get
      Return Me.mPardet_ResultadoSeleccion
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_ResultadoSeleccion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property SelDet_esAprobadoRRHH() As Boolean
    Get
      Return Me.mSelDet_esAprobadoRRHH
    End Get
    Set(ByVal value As Boolean)
      Me.mSelDet_esAprobadoRRHH = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property SelDet_esAprobadoDpto() As Boolean
    Get
      Return Me.mSelDet_esAprobadoDpto
    End Get
    Set(ByVal value As Boolean)
      Me.mSelDet_esAprobadoDpto = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_AreaCargo() As Integer
    Get
      Return Me.mParame_AreaCargo
    End Get
    Set(ByVal value As Integer)
      Me.mParame_AreaCargo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_AreaCargo() As Integer
    Get
      Return Me.mPardet_AreaCargo
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_AreaCargo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_DepartamentoCargo() As Integer
    Get
      Return Me.mParame_DepartamentoCargo
    End Get
    Set(ByVal value As Integer)
      Me.mParame_DepartamentoCargo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_DepartamentoCargo() As Integer
    Get
      Return Me.mPardet_DepartamentoCargo
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_DepartamentoCargo = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Cargo_Secuencia() As Integer
    Get
      Return Me.mCargo_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mCargo_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Cargo_EmpleadoActual() As String
    Get
      Return Me.mCargo_EmpleadoActual
    End Get
    Set(ByVal value As String)
      Me.mCargo_EmpleadoActual = value
      EsModificado = True
    End Set
  End Property
End Class
