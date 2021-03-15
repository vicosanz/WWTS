 
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Data.Common

Public Enum enumProveedorDatos
  NoDefinido = -1
  SQL = 0
  Oracle = 1
  Sybase = 2
End Enum

#Region "OperadorDatos"
'<XmlInclude(GetType(OperadorDatos))> _
Public MustInherit Class OperadorDatos
  Implements ICloneable

#Region "Campos privados"
  Private mServidor As String = ""
  Private mUsuario As String = String.Empty
  Private mClave As String = String.Empty
  Private mBase As String = String.Empty
  Private mSeguridadIntegrada As Boolean = True
  Private mGuardarContrasena As Boolean = True
  Private mDirectorioReplicacion As String = String.Empty
  Private mSufijoReplicacion As String = String.Empty
  Private mReplicarComando As Boolean = True
#End Region

#Region "Propiedades"
  <XmlAttribute()> _
  Overridable ReadOnly Property Proveedor() As enumProveedorDatos
    Get
      Return enumProveedorDatos.NoDefinido
    End Get
  End Property

  <XmlAttribute()> _
  Public Property Servidor() As String
    Get
      Return mServidor
    End Get
    Set(ByVal value As String)
      If value Is Nothing OrElse value.Trim = String.Empty Then
        Throw New Exception("El servidor no puede estar vacío")
      End If
      mServidor = value
      Conexion = Nothing
    End Set
  End Property

  <XmlAttribute()> _
  Public Property Usuario() As String
    Get
      Return mUsuario
    End Get
    Set(ByVal value As String)
      'If value Is Nothing OrElse value.Trim = String.Empty Then
      '  Throw New Exception("El usuario no puede estar vacío")
      'End If
      mUsuario = value
      Conexion = Nothing
    End Set
  End Property

  <XmlAttribute()> _
  Public Property GuardarContrasena() As Boolean
    Get
      Return mGuardarContrasena
    End Get
    Set(ByVal value As Boolean)
      mGuardarContrasena = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Property ClaveAux() As String
    Get
      Return mClave
    End Get
    Set(ByVal value As String)
      mClave = value
      Conexion = Nothing
    End Set
  End Property

  <XmlAttribute()> _
  Public Property Clave() As String
    Get
      If GuardarContrasena Then
        Return mClave
      Else
        Return String.Empty
      End If
    End Get
    Set(ByVal value As String)
      If GuardarContrasena Then
        mClave = value
      End If
    End Set
  End Property

  <XmlAttribute()> _
  Public Property Base() As String
    Get
      Return mBase
    End Get
    Set(ByVal value As String)
      'If value Is Nothing OrElse value.Trim = String.Empty Then
      '  Throw New Exception("El nombre de la base de datos no puede estar vacío")
      'End If
      mBase = value
      Conexion = Nothing
    End Set
  End Property

  <XmlAttribute()> _
  Public Property SeguridadIntegrada() As Boolean
    Get
      Return mSeguridadIntegrada
    End Get
    Set(ByVal value As Boolean)
      mSeguridadIntegrada = value
      Conexion = Nothing
    End Set
  End Property

  <XmlAttribute()> _
  Public Property DirectorioReplicacion() As String
    Get
      Return mDirectorioReplicacion
    End Get
    Set(ByVal value As String)
      mDirectorioReplicacion = value
    End Set
  End Property

  <XmlAttribute()> _
  Public Property SufijoReplicacion() As String
    Get
      Return mSufijoReplicacion
    End Get
    Set(ByVal value As String)
      mSufijoReplicacion = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Property ReplicarComando() As Boolean
    Get
      Return mReplicarComando
    End Get
    Set(ByVal value As Boolean)
      mReplicarComando = value
    End Set
  End Property

  <XmlIgnore()> _
  MustOverride ReadOnly Property CadenaConexion() As String

  <XmlIgnore()> _
  MustOverride Property Procedimiento() As String

  <XmlIgnore()> _
  MustOverride ReadOnly Property MsgError() As String

  <XmlIgnore()> _
  MustOverride ReadOnly Property Descripcion() As String


#End Region

#Region "Métodos"
  <XmlIgnore()> _
  MustOverride Property Conexion() As DbConnection

  <XmlIgnore()> _
  MustOverride ReadOnly Property Comando() As DbCommand

  <XmlIgnore()> _
  MustOverride Property ComandoXML() As OperadorDatosComando

  MustOverride Function ComenzarTransaccion() As Boolean

  MustOverride Function TerminarTransaccion() As Boolean

  MustOverride Function CancelarTransaccion() As Boolean

  <XmlIgnore()> _
  MustOverride ReadOnly Property EstaenTransaccion() As Boolean

  MustOverride Function Ejecutar(ByRef dsDatos As DataSet) As Boolean

  MustOverride Function Ejecutar(ByRef dsDatos As DataSet, srcTable As String) As Boolean

  MustOverride Function Ejecutar(ByRef dsDatos As DataTable) As Boolean

  MustOverride Function Ejecutar() As Boolean

  MustOverride Function Ejecutar(ByRef obj As Object) As Boolean

  MustOverride Function Ejecutar(ByRef xmlReader As XmlReader) As Boolean

  MustOverride Sub AgregarParametro(ByVal nombre As String, ByVal valor As Object)

  MustOverride Sub AgregarParametroImagen(ByVal nombre As String, ByVal Imagen As String)

  MustOverride Sub ReconfigurarParametros()

  MustOverride Sub LimpiarParametros()

#End Region

#Region "New"
  Protected Sub New()
    ' TODO: Complete member initialization 
  End Sub

  Protected Sub New(ByVal _servidor As String, ByVal _base As String, ByVal _usuario As String, ByVal _clave As String, ByVal _seguridadintegrada As Boolean)

    Servidor = _servidor
    Base = _base
    Usuario = _usuario
    ClaveAux = _clave
    SeguridadIntegrada = _seguridadintegrada

    'mConexion = New SqlConnection(CadenaConexion)
    'mComando = New SqlCommand
    'mComando.CommandType = CommandType.StoredProcedure
    'mComando.Connection = mConexion
  End Sub
#End Region

  Public Function Clone() As Object Implements System.ICloneable.Clone
    Select Case Proveedor
      Case enumProveedorDatos.SQL
        Return New SQLOperadorDatos(Servidor, Base, Usuario, ClaveAux, SeguridadIntegrada)
      Case enumProveedorDatos.Sybase
        Return New SybaseOperadorDatos(Servidor, Base, Usuario, ClaveAux, SeguridadIntegrada)
      Case Else
        Throw New Exception("Proveedor de datos inválido")
    End Select
  End Function

#Region "evento DataOperationError"
  Public Event OperadorDatosError As OperadorDatosErrorEventHandler

  Protected Overridable Sub OnDataOperationError(ByVal e As OperadorDatosErrorEventArgs)
    If Not e Is Nothing Then
      RaiseEvent OperadorDatosError(Me, e)
    End If
  End Sub
#End Region
End Class

#End Region


#Region "OperadorDatosList"
Public Class OperadorDatosList
  Inherits System.ComponentModel.BindingList(Of OperadorDatos)

  Public Sub axml(ByVal filename As String)
    Dim x As XmlSerializer = New XmlSerializer(Me.GetType, New Type() {GetType(SQLOperadorDatos), GetType(SybaseOperadorDatos)})
    Dim writer As TextWriter = New StreamWriter(filename)
    x.Serialize(writer, Me)
    writer.Close()
    writer.Dispose()
  End Sub

  Public Shared Function dexml(ByVal filename As String) As OperadorDatosList
    Dim oResult As New OperadorDatosList
    Dim myFileStream As FileStream = Nothing
    Dim reader As XmlTextReader = Nothing
    Dim serializer As XmlSerializer = Nothing
    Try
      myFileStream = New FileStream(filename, FileMode.Open)
      reader = New XmlTextReader(myFileStream)
      serializer = New XmlSerializer(GetType(OperadorDatosList), New Type() {GetType(SQLOperadorDatos), GetType(SybaseOperadorDatos)})
      If serializer.CanDeserialize(reader) Then
        oResult = serializer.Deserialize(reader)
      End If
      reader.Close()
      myFileStream.Close()
    Catch ex As Exception
    Finally
    End Try
    Return oResult
  End Function
End Class
#End Region
