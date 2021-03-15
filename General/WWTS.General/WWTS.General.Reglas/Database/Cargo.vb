
Option Strict Off
Option Explicit On

Imports Infoware.Reglas

Public Class Cargo
  Inherits _Database

  Private mParame_Departamento As Integer = 0

  Private mPardet_Departamento As Integer = 0

  Private mParame_Area As Integer = 0

  Private mPardet_Area As Integer = 0

  Private mCargo_Secuencia As Integer = 0

  Private mCargo_Descripcion As String = ""

  Private mParame_ModeloLabor As Integer = 0

  Private mPardet_ModeloLabor As Integer = 0

  Private mCargo_ControlarHorasExtras As Boolean = False

  Private mParame_DepartamentoJefe As Integer = 0

  Private mPardet_DepartamentoJefe As Integer = 0

  Private mParame_AreaJefe As Integer = 0

  Private mPardet_AreaJefe As Integer = 0

  Private mCargo_SecuenciaJefe As Integer = 0

  Private mParame_ActividadSectorial As Integer = 0

  Private mPardet_ActividadSectorial As Integer = 0

  Private mParame_Escalafon As Integer = 0

  Private mPardet_Escalafon As Integer = 0

  Public Sub New()
    MyBase.New()
  End Sub

  Public Overridable Property Parame_Departamento() As Integer
    Get
      Return Me.mParame_Departamento
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Departamento = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Departamento() As Integer
    Get
      Return Me.mPardet_Departamento
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Departamento = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_Area() As Integer
    Get
      Return Me.mParame_Area
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Area = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Area() As Integer
    Get
      Return Me.mPardet_Area
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Area = value
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

  Public Overridable Property Cargo_Descripcion() As String
    Get
      Return Me.mCargo_Descripcion
    End Get
    Set(ByVal value As String)
      Me.mCargo_Descripcion = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_ModeloLabor() As Integer
    Get
      Return Me.mParame_ModeloLabor
    End Get
    Set(ByVal value As Integer)
      Me.mParame_ModeloLabor = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_ModeloLabor() As Integer
    Get
      Return Me.mPardet_ModeloLabor
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_ModeloLabor = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Cargo_ControlarHorasExtras() As Boolean
    Get
      Return Me.mCargo_ControlarHorasExtras
    End Get
    Set(ByVal value As Boolean)
      Me.mCargo_ControlarHorasExtras = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_DepartamentoJefe() As Integer
    Get
      Return Me.mParame_DepartamentoJefe
    End Get
    Set(ByVal value As Integer)
      Me.mParame_DepartamentoJefe = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_DepartamentoJefe() As Integer
    Get
      Return Me.mPardet_DepartamentoJefe
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_DepartamentoJefe = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_AreaJefe() As Integer
    Get
      Return Me.mParame_AreaJefe
    End Get
    Set(ByVal value As Integer)
      Me.mParame_AreaJefe = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_AreaJefe() As Integer
    Get
      Return Me.mPardet_AreaJefe
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_AreaJefe = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Cargo_SecuenciaJefe() As Integer
    Get
      Return Me.mCargo_SecuenciaJefe
    End Get
    Set(ByVal value As Integer)
      Me.mCargo_SecuenciaJefe = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_ActividadSectorial() As Integer
    Get
      Return Me.mParame_ActividadSectorial
    End Get
    Set(ByVal value As Integer)
      Me.mParame_ActividadSectorial = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_ActividadSectorial() As Integer
    Get
      Return Me.mPardet_ActividadSectorial
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_ActividadSectorial = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Parame_Escalafon() As Integer
    Get
      Return Me.mParame_Escalafon
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Escalafon = value
      EsModificado = True
    End Set
  End Property

  Public Overridable Property Pardet_Escalafon() As Integer
    Get
      Return Me.mPardet_Escalafon
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Escalafon = value
      EsModificado = True
    End Set
  End Property
End Class
