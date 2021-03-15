Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Datos

Public MustInherit Class _Database
  Private mEsNuevo As Boolean = True
  Private mEsModificado As Boolean = False
  Private mEsEliminado As Boolean = False
  Private mOperadorDatos As OperadorDatos = Nothing
  ''' <summary>
  ''' EsNuevo
  ''' </summary>
  ''' <remarks>Indica si el registro es nuevo o es uno ya existente</remarks>
  <XmlIgnore()> _
  Property EsNuevo() As Boolean
    Get
      Return mEsNuevo
    End Get
    Set(ByVal value As Boolean)
      mEsNuevo = value
    End Set
  End Property

  <XmlIgnore()> _
  Property EsModificado() As Boolean
    Get
      Return mEsModificado
    End Get
    Set(ByVal value As Boolean)
      mEsModificado = value
    End Set
  End Property

  <XmlIgnore()> _
  Property EsEliminado() As Boolean
    Get
      Return mEsEliminado
    End Get
    Set(ByVal value As Boolean)
      mEsEliminado = value
    End Set
  End Property

  <XmlIgnore()> _
  Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
    End Set
  End Property

  Public Sub New()
  End Sub
End Class
