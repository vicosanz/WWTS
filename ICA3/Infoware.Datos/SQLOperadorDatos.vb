Imports System.Text
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Data.Common
Imports System.Collections.Generic

#Region "OperadorDatos"
<XmlInclude(GetType(OperadorDatos))> _
Public Class SQLOperadorDatos
  Inherits OperadorDatos

#Region "Campos privados"
  Private mProcedimiento As String = String.Empty
  Private mMsgError As String
#End Region

#Region "Propiedades"
  <XmlAttribute()> _
  Public Overrides ReadOnly Property Proveedor As enumProveedorDatos
    Get
      Return enumProveedorDatos.SQL
    End Get
  End Property

  <XmlIgnore()> _
  Public Overrides ReadOnly Property CadenaConexion() As String
    Get
      If SeguridadIntegrada Then
        Return String.Format("Server={0};Database={1};Trusted_Connection=True;", Servidor, Base)
      End If
      Return String.Format("Server={0};Database={1};User Id={2};Password={3};", Servidor, Base, Usuario, ClaveAux)
    End Get
  End Property

  <XmlIgnore()> _
  Public Overrides Property Procedimiento() As String
    Get
      Return mProcedimiento
    End Get
    Set(ByVal value As String)
      mProcedimiento = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Overrides ReadOnly Property MsgError() As String
    Get
      Return mMsgError
    End Get
  End Property

  <XmlIgnore()> _
  Public Overrides ReadOnly Property Descripcion() As String
    Get
      Return Base & " en " & Servidor
    End Get
  End Property
#End Region

#Region "Variables internas"
  Private mConexion As DbConnection
  Private mDataAdapter As SqlDataAdapter
  Private mTransaccion As SqlTransaction
  Private mComando As SqlCommand
  Private mComandoXMLTransaccion As List(Of OperadorDatosComando)
  Private mComandoXML As OperadorDatosComando
  Private mEstaenTransaccion As Boolean = False
#End Region

#Region "Métodos"
  <XmlIgnore()> _
  Public Overrides Property Conexion() As DbConnection
    Get
      If mConexion Is Nothing Then
        mConexion = New SqlConnection(CadenaConexion)
      End If
      Return mConexion
    End Get
    Set(ByVal value As DbConnection)
      mConexion = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Overrides ReadOnly Property Comando() As DbCommand
    Get
      If mComando Is Nothing Then
        mComando = New SqlCommand
        mComando.CommandType = CommandType.StoredProcedure
        mComando.Connection = Conexion
        mComando.CommandTimeout = 180
      End If
      Return mComando
    End Get
  End Property

  <XmlIgnore()> _
  Public Overrides Property ComandoXML() As OperadorDatosComando
    Get
      If mComandoXML Is Nothing Then
        mComandoXML = New OperadorDatosComando
      End If
      Return mComandoXML
    End Get
    Set(value As OperadorDatosComando)
      Comando.Parameters.Clear()
      For Each _param As OperadorDatosComandoParametro In value.Parametros
        AgregarParametro(_param.Nombre, _param.Valor)
      Next
      Procedimiento = value.Procedimiento
    End Set
  End Property

  <XmlIgnore()> _
  Public ReadOnly Property ComandoXMLTransaccion() As List(Of OperadorDatosComando)
    Get
      If mComandoXMLTransaccion Is Nothing Then
        mComandoXMLTransaccion = New List(Of OperadorDatosComando)
      End If
      Return mComandoXMLTransaccion
    End Get
  End Property

#Region "Transacciones"
  Public Overrides Function ComenzarTransaccion() As Boolean
    Try
      mMsgError = String.Empty
      'mConexion = New SqlConnection(CadenaConexion)
      If Conexion.State = ConnectionState.Closed Then
        Conexion.Open()
      End If
      mTransaccion = Conexion.BeginTransaction
      mComando.Transaction = mTransaccion
      mEstaenTransaccion = True
      Return True
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      Return False
    End Try
  End Function

  Public Overrides Function TerminarTransaccion() As Boolean
    Dim result As Boolean = True
    Try
      mMsgError = String.Empty
      mTransaccion.Commit()
      mComando.Transaction = Nothing
      mEstaenTransaccion = False

      For Each _comando As OperadorDatosComando In ComandoXMLTransaccion
        _comando.SerializeList(DirectorioReplicacion, SufijoReplicacion)
      Next
      ComandoXMLTransaccion.Clear()
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      result = False
    Finally
      If Conexion.State = ConnectionState.Open Then
        Conexion.Close()
      End If
    End Try
    Return result
  End Function

  Public Overrides Function CancelarTransaccion() As Boolean
    Dim result As Boolean = True
    Try
      'mMsgError = String.Empty
      mTransaccion.Rollback()
      mComando.Transaction = Nothing
      mEstaenTransaccion = False
      ComandoXMLTransaccion.Clear()
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      result = False
    Finally
      If Conexion.State = ConnectionState.Open Then
        Conexion.Close()
      End If
    End Try
    Return result
  End Function

  <XmlIgnore()> _
  Public Overrides ReadOnly Property EstaenTransaccion() As Boolean
    Get
      Return mEstaenTransaccion
    End Get
  End Property
#End Region

  Public Overrides Function Ejecutar(ByRef dsDatos As DataSet) As Boolean
    Try
      mMsgError = String.Empty
      mComando.CommandText = mProcedimiento
      mComando.Connection = Conexion

      Dim da As New SqlDataAdapter(mComando)

      dsDatos = New DataSet
      da.Fill(dsDatos)
      Return True
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      Return False
    End Try
  End Function

  Public Overrides Function Ejecutar(ByRef dsDatos As DataSet, srcTable As String) As Boolean
    Try
      mMsgError = String.Empty
      mComando.CommandText = mProcedimiento
      mComando.Connection = Conexion

      Dim da As New SqlDataAdapter(mComando)

      dsDatos = New DataSet
      da.Fill(dsDatos, srcTable)
      Return True
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      Return False
    End Try
  End Function

  Public Overrides Function Ejecutar(ByRef dsDatos As DataTable) As Boolean
    Try
      mMsgError = String.Empty
      mComando.CommandText = mProcedimiento
      mComando.Connection = Conexion
      Dim da As New SqlDataAdapter(mComando)

      dsDatos = New DataTable
      da.Fill(dsDatos)

      'If Loguear Then
      '  mOperadorDatosLog.LogEntry(mComando)
      'End If
      Return True
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      Return False
    End Try
  End Function

  Public Overrides Function Ejecutar() As Boolean
    Dim _estaabierta As Boolean
    Try
      mMsgError = String.Empty
      mComando.CommandText = mProcedimiento
      mComando.Connection = Conexion
      _estaabierta = Conexion.State = ConnectionState.Open
      If Not _estaabierta Then Conexion.Open()
      mComando.ExecuteNonQuery()

      'Guardar ejecución
      If ReplicarComando AndAlso Not String.IsNullOrWhiteSpace(DirectorioReplicacion) Then
        mComandoXML.Procedimiento = mProcedimiento
        If EstaenTransaccion Then
          ComandoXMLTransaccion.Add(mComandoXML)
        Else
          mComandoXML.SerializeList(DirectorioReplicacion, SufijoReplicacion)
        End If
      End If
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      Return False
    Finally
      If Not _estaabierta Then Conexion.Close()
    End Try
    Return True
  End Function

  Public Overrides Function Ejecutar(ByRef obj As Object) As Boolean
    Dim _estaabierta As Boolean
    Try
      mMsgError = String.Empty
      mComando.CommandText = mProcedimiento
      mComando.Connection = Conexion
      _estaabierta = Conexion.State = ConnectionState.Open
      If Not _estaabierta Then Conexion.Open()
      obj = mComando.ExecuteScalar

      'Guardar ejecución
      If ReplicarComando AndAlso Not String.IsNullOrWhiteSpace(DirectorioReplicacion) Then
        mComandoXML.Procedimiento = mProcedimiento
        If EstaenTransaccion Then
          ComandoXMLTransaccion.Add(mComandoXML)
        Else
          mComandoXML.SerializeList(DirectorioReplicacion, SufijoReplicacion)
        End If
      End If
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      obj = Nothing
      Return False
    Finally
      If Not _estaabierta Then Conexion.Close()
    End Try
    Return True
  End Function

  Public Overrides Function Ejecutar(ByRef xmlReader As XmlReader) As Boolean
    Dim _estaabierta As Boolean
    Dim result As Boolean = True
    Try
      mMsgError = String.Empty
      mComando.CommandText = mProcedimiento
      mComando.Connection = Conexion
      _estaabierta = Conexion.State = ConnectionState.Open
      If Not _estaabierta Then Conexion.Open()
      xmlReader = mComando.ExecuteXmlReader
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      xmlReader = Nothing
      result = False
    Finally
      If Not _estaabierta Then Conexion.Close()
    End Try
    Return result
  End Function

  Public Overrides Sub AgregarParametro(ByVal nombre As String, ByVal valor As Object)
    Dim sqlparam As New SqlParameter
    If TypeOf valor Is DBNull Then
      Exit Sub
    End If
    If TypeOf valor Is Decimal Or TypeOf valor Is Double Then
      sqlparam.DbType = DbType.Double
      sqlparam.SqlDbType = SqlDbType.Decimal
    End If
    sqlparam.Value = valor
    sqlparam.ParameterName = nombre
    sqlparam.Direction = ParameterDirection.Input
    Comando.Parameters.Add(sqlparam)
    ComandoXML.Parametros.Add(New OperadorDatosComandoParametro(nombre, valor))
  End Sub

  Public Overrides Sub AgregarParametroImagen(ByVal nombre As String, ByVal Imagen As String)
    Dim sqlparam As New SqlParameter
    If Imagen Is Nothing OrElse Imagen.Trim = String.Empty Then
      Exit Sub
    End If
    Dim foto() As Byte
    Dim fs As FileStream = New FileStream(Imagen, FileMode.Open, FileAccess.Read)
    Dim br As BinaryReader = New BinaryReader(fs)
    foto = br.ReadBytes(fs.Length)
    br.Close()
    fs.Close()

    sqlparam.SqlDbType = SqlDbType.Image
    sqlparam.Size = foto.Length
    sqlparam.Value = foto
    sqlparam.ParameterName = nombre
    sqlparam.Direction = ParameterDirection.Input
    Comando.Parameters.Add(sqlparam)
  End Sub

  Public Overrides Sub LimpiarParametros()
    mComando.Parameters.Clear()
    mComandoXML = New OperadorDatosComando
    ReplicarComando = False
  End Sub

  Sub New()
    MyBase.New()
  End Sub

  Sub New(ByVal _servidor As String, ByVal _base As String, ByVal _usuario As String, ByVal _clave As String, ByVal _seguridadintegrada As Boolean)
    MyBase.New(_servidor, _base, _usuario, _clave, _seguridadintegrada)
  End Sub
#End Region

  Public Overrides Sub ReconfigurarParametros()

  End Sub
End Class


#End Region
