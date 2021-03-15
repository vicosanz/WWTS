Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml

Public Class OperadorDatosComando
  Private mProcedimiento As String
  Public Property Procedimiento As String
    Get
      Return mProcedimiento
    End Get
    Set(value As String)
      mProcedimiento = value
    End Set
  End Property

  Private mParametros As List(Of OperadorDatosComandoParametro)
  Public Property Parametros As List(Of OperadorDatosComandoParametro)
    Get
      If mParametros Is Nothing Then
        mParametros = New List(Of OperadorDatosComandoParametro)
      End If
      Return mParametros
    End Get
    Set(value As List(Of OperadorDatosComandoParametro))
      mParametros = value
    End Set
  End Property

  Public Sub SerializeList(_Directorio As String, _Sufijo As String)
    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CombinePath(_Directorio, _Sufijo))
    Dim x As XmlSerializer = New XmlSerializer(GetType(OperadorDatosComando))
    For Each _subdir As String In My.Computer.FileSystem.GetDirectories(_Directorio, FileIO.SearchOption.SearchTopLevelOnly)
      If Not My.Computer.FileSystem.GetDirectoryInfo(_subdir).Name.ToUpper = _Sufijo.ToUpper Then
        Dim filename As String = My.Computer.FileSystem.CombinePath(_subdir, Now.ToString("yyyyMMddHHmm") + My.Computer.Clock.TickCount.ToString + _Sufijo)

        Dim writer As TextWriter = New StreamWriter(filename)
        x.Serialize(writer, Me)
        writer.Close()
      End If
    Next
  End Sub

  Public Shared Function DeSerializeList(ByVal filename As String) As OperadorDatosComando
    Dim oResult As New OperadorDatosComando
    Try
      Dim myFileStream As FileStream = New FileStream(filename, FileMode.Open)
      Dim reader As New XmlTextReader(myFileStream)
      Dim serializer As New XmlSerializer(GetType(OperadorDatosComando))
      If serializer.CanDeserialize(reader) Then
        oResult = serializer.Deserialize(reader)
      End If
      myFileStream.Close()
    Catch ex As Exception
    End Try
    Return oResult
  End Function

  Public Shared Sub ActualizarSistema(_OperadorDatos As OperadorDatos)
    Dim _operadorDatos2 As OperadorDatos = _OperadorDatos.Clone
    Dim _directSufijo As String = My.Computer.FileSystem.CombinePath(_OperadorDatos.DirectorioReplicacion, _OperadorDatos.SufijoReplicacion)
    Dim _directSufijoError As String = My.Computer.FileSystem.CombinePath(_directSufijo, "Error")
    My.Computer.FileSystem.CreateDirectory(_directSufijo)
    My.Computer.FileSystem.CreateDirectory(_directSufijoError)
    For Each _file As String In My.Computer.FileSystem.GetFiles(_directSufijo, FileIO.SearchOption.SearchTopLevelOnly)
      Dim _comandoxml As OperadorDatosComando = DeSerializeList(_file)
      _operadorDatos2.ComandoXML = _comandoxml
      If _operadorDatos2.Ejecutar Then
        My.Computer.FileSystem.DeleteFile(_file)
      Else
        My.Computer.FileSystem.MoveFile(_file, _directSufijoError)
      End If
    Next
  End Sub
End Class

Public Class OperadorDatosComandoParametro
  Private mNombre As String
  Public Property Nombre As String
    Get
      Return mNombre
    End Get
    Set(value As String)
      mNombre = value
    End Set
  End Property

  Private mValor As Object
  Public Property Valor As Object
    Get
      Return mValor
    End Get
    Set(value As Object)
      mValor = value
    End Set
  End Property

  Public Sub New()

  End Sub

  Public Sub New(_nombre As String, _valor As Object)
    Nombre = _nombre
    Valor = _valor
  End Sub
End Class
