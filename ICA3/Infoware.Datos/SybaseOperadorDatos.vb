Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Data.Common
Imports System.Data.OleDb

#Region "OperadorDatos"
<XmlInclude(GetType(OperadorDatos))> _
Public Class SybaseOperadorDatos
  Inherits OperadorDatos

#Region "Campos privados"
  Private mProcedimiento As String = String.Empty
  Private mMsgError As String
#End Region

#Region "Propiedades"
  <XmlAttribute()> _
  Public Overrides ReadOnly Property Proveedor As enumProveedorDatos
    Get
      Return enumProveedorDatos.Sybase
    End Get
  End Property

  <XmlIgnore()> _
  Public Overrides ReadOnly Property CadenaConexion() As String
    Get
      Return String.Format("Provider=ASAProv;Data Source={0}", Servidor)
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
  Private mDataAdapter As OleDbDataAdapter
  Private mTransaccion As OleDbTransaction
  Private mComando As OleDbCommand
  Private mComandoXML As OperadorDatosComando
  Private mEstaenTransaccion As Boolean = False
#End Region

#Region "Métodos"
  <XmlIgnore()> _
  Public Overrides Property Conexion() As DbConnection
    Get
      If mConexion Is Nothing Then
        mConexion = New OleDbConnection(CadenaConexion)
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
        mComando = New OleDbCommand
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

#Region "Transacciones"
  Public Overrides Function ComenzarTransaccion() As Boolean
    Try
      mMsgError = String.Empty
      'mConexion = New oledbConnection(CadenaConexion)
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
      mTransaccion.Dispose()
      mComando.Transaction = Nothing
      mEstaenTransaccion = False
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
      mTransaccion.Dispose()
      mComando.Transaction = Nothing
      mEstaenTransaccion = False
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

      reconfigurarparametros()

      Dim da As New OleDbDataAdapter(mComando)

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

      reconfigurarparametros()
      Dim da As New OleDbDataAdapter(mComando)

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
      reconfigurarparametros()

      Dim da As New OleDbDataAdapter(mComando)

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
      reconfigurarparametros()

      _estaabierta = Conexion.State = ConnectionState.Open
      If Not _estaabierta Then Conexion.Open()
      mComando.ExecuteNonQuery()
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
      reconfigurarparametros()
      _estaabierta = Conexion.State = ConnectionState.Open
      If Not _estaabierta Then Conexion.Open()
      obj = mComando.ExecuteScalar
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

  Public Overrides Sub ReconfigurarParametros()
    'Dim _op As New SybaseOperadorDatos
    '_op = Me.Clone

    Dim dsDatos As New DataTable
    Try
      Dim _comando As OleDbCommand
      _comando = New OleDbCommand
      _comando.CommandType = CommandType.StoredProcedure
      _comando.Connection = Conexion
      _comando.CommandTimeout = 180

      _comando.Transaction = mTransaccion
      _comando.CommandText = "Proc_ObtenerSPParametros"
      Dim oledbparam As New OleDbParameter
      oledbparam.DbType = DbType.String
      oledbparam.OleDbType = OleDbType.VarChar
      oledbparam.Value = Me.Comando.CommandText
      oledbparam.ParameterName = "@sp"
      oledbparam.Direction = ParameterDirection.Input

      _comando.Parameters.Add(oledbparam)
      _comando.Connection = Conexion

      Dim da As New OleDbDataAdapter(_comando)

      da.Fill(dsDatos)

      'If Loguear Then
      '  mOperadorDatosLog.LogEntry(mComando)
      'End If
    Catch ex As Exception
      mMsgError = ex.Message
      Me.OnDataOperationError(New OperadorDatosErrorEventArgs(ex, "OperadorDatos"))
      'RaiseEvent HuboError(Me, Nothing)
      Exit Sub
    End Try

    If dsDatos IsNot Nothing AndAlso dsDatos.Rows.Count > 0 Then
      Dim _parametrolist As New Dictionary(Of String, Object)
      For Each _param As OleDbParameter In Me.Comando.Parameters
        _parametrolist.Add(_param.ParameterName.ToLower.Trim, _param.Value)
      Next

      LimpiarParametros()

      For Each _row As DataRow In dsDatos.Rows
        Dim _colname As String = _row(0).ToString.ToLower.Trim
        If _colname.StartsWith("@") Then
          If _parametrolist.ContainsKey(_colname) Then
            Dim _colvalue As Object = Nothing
            _parametrolist.TryGetValue(_colname, _colvalue)
            AgregarParametro(_colname, _colvalue)
          Else
            AgregarParametro(_colname, Nothing)
          End If
        End If
      Next
    End If


  End Sub


  Public Overrides Function Ejecutar(ByRef xmlReader As XmlReader) As Boolean
    Throw New Exception("Ejecutar XMLReader no permitido en Sybase OLEDB")
    Return False
  End Function

  Public Overrides Sub AgregarParametro(ByVal nombre As String, ByVal valor As Object)
    Dim oledbparam As New OleDbParameter
    'If TypeOf valor Is DBNull Then
    '  Exit Sub
    'End If
    If TypeOf valor Is Decimal Or TypeOf valor Is Double Then
      oledbparam.DbType = DbType.Double
      oledbparam.OleDbType = OleDbType.Decimal
    End If
    If TypeOf valor Is String Then
      oledbparam.DbType = DbType.String
      oledbparam.OleDbType = OleDbType.VarChar
    End If
    If TypeOf valor Is Date Or TypeOf valor Is DateTime Then
      oledbparam.DbType = DbType.String
      oledbparam.OleDbType = OleDbType.VarChar
      oledbparam.Value = CType(valor, Date).ToString("yyyyMMdd HH:mm:ss")
    Else
      oledbparam.Value = valor
    End If
    oledbparam.ParameterName = nombre
    oledbparam.Direction = ParameterDirection.Input
    Comando.Parameters.Add(oledbparam)
  End Sub

  Public Overrides Sub AgregarParametroImagen(ByVal nombre As String, ByVal Imagen As String)
    Throw New Exception("Parámetro imagen no permitido en Sybase OLEDB")
    'Dim oledbparam As New OleDbParameter
    'If Imagen Is Nothing OrElse Imagen.Trim = String.Empty Then
    '  Exit Sub
    'End If
    'Dim foto() As Byte
    'Dim fs As FileStream = New FileStream(Imagen, FileMode.Open, FileAccess.Read)
    'Dim br As BinaryReader = New BinaryReader(fs)
    'foto = br.ReadBytes(fs.Length)
    'br.Close()
    'fs.Close()

    'oledbparam.OleDbType = OleDbType.
    'oledbparam.Size = foto.Length
    'oledbparam.Value = foto
    'oledbparam.ParameterName = nombre
    'oledbparam.Direction = ParameterDirection.Input
    'Comando.Parameters.Add(oledbparam)
  End Sub

  Public Overrides Sub LimpiarParametros()
    mComando.Parameters.Clear()
  End Sub

  Sub New()
    MyBase.New()
  End Sub

  Sub New(ByVal _servidor As String, ByVal _base As String, ByVal _usuario As String, ByVal _clave As String, ByVal _seguridadintegrada As Boolean)
    MyBase.New(_servidor, _base, _usuario, _clave, _seguridadintegrada)
  End Sub
#End Region

End Class


#End Region
