Imports System.Xml.Serialization
Imports System.IO
Imports System.Text
Imports Infoware.Datos

Public Class Programacion
  Private mListo As Boolean = False
  Public Property Listo() As Boolean
    Get
      Return mListo
    End Get
    Set(ByVal value As Boolean)
      mListo = value
    End Set
  End Property

  Enum enumSucede
    Diario
    Semanal
    Mensual
  End Enum

  Private mSucede As enumSucede

  Public Property Sucede() As enumSucede
    Get
      Return mSucede
    End Get
    Set(ByVal value As enumSucede)
      mSucede = value
    End Set
  End Property

  Private mSucedeCada As Integer = 1

  Public Property SucedeCada() As Integer
    Get
      Return mSucedeCada
    End Get
    Set(ByVal value As Integer)
      mSucedeCada = value
    End Set
  End Property

  Private mSucedeSemanalLunes As Boolean = False

  Public Property SucedeSemanalLunes() As Boolean
    Get
      Return mSucedeSemanalLunes
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalLunes = value
    End Set
  End Property

  Private mSucedeSemanalMartes As Boolean = False

  Public Property SucedeSemanalMartes() As Boolean
    Get
      Return mSucedeSemanalMartes
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalMartes = value
    End Set
  End Property

  Private mSucedeSemanalMiercoles As Boolean = False

  Public Property SucedeSemanalMiercoles() As Boolean
    Get
      Return mSucedeSemanalMiercoles
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalMiercoles = value
    End Set
  End Property

  Private mSucedeSemanalJueves As Boolean = False

  Public Property SucedeSemanalJueves() As Boolean
    Get
      Return mSucedeSemanalJueves
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalJueves = value
    End Set
  End Property

  Private mSucedeSemanalViernes As Boolean = False

  Public Property SucedeSemanalViernes() As Boolean
    Get
      Return mSucedeSemanalViernes
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalViernes = value
    End Set
  End Property

  Private mSucedeSemanalSabado As Boolean = False

  Public Property SucedeSemanalSabado() As Boolean
    Get
      Return mSucedeSemanalSabado
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalSabado = value
    End Set
  End Property

  Private mSucedeSemanalDomingo As Boolean = True

  Public Property SucedeSemanalDomingo() As Boolean
    Get
      Return mSucedeSemanalDomingo
    End Get
    Set(ByVal value As Boolean)
      mSucedeSemanalDomingo = value
    End Set
  End Property

  Public Enum enumMensualTipo
    eldia
    primer
  End Enum

  Private mMensualTipo As enumMensualTipo = enumMensualTipo.eldia

  Public Property MensualTipo() As enumMensualTipo
    Get
      Return mMensualTipo
    End Get
    Set(ByVal value As enumMensualTipo)
      mMensualTipo = value
    End Set
  End Property

  Private mMensualeldia As Integer = 1

  Public Property Mensualeldia() As Integer
    Get
      Return mMensualeldia
    End Get
    Set(ByVal value As Integer)
      mMensualeldia = value
    End Set
  End Property

  Public Enum enumMensualSemana
    Primer
    Segundo
    Tercer
    Cuarto
    Ultimo
  End Enum

  Private mMensualSemana As enumMensualSemana = enumMensualSemana.Primer

  Public Property MensualSemana() As enumMensualSemana
    Get
      Return mMensualSemana
    End Get
    Set(ByVal value As enumMensualSemana)
      mMensualSemana = value
    End Set
  End Property

  Public Enum enumdiaSemana
    Lunes
    Martes
    Miercoles
    Jueves
    Viernes
    Sabado
    Domingo
  End Enum

  Private mMensualDiaSemana As enumdiaSemana = enumdiaSemana.Domingo

  Public Property MensualDiaSemana() As enumdiaSemana
    Get
      Return mMensualDiaSemana
    End Get
    Set(ByVal value As enumdiaSemana)
      mMensualDiaSemana = value
    End Set
  End Property

  Public Enum enumFrecuenciaTipo
    unavez
    cada
  End Enum

  Private mFrecuenciaTipo As enumFrecuenciaTipo = enumFrecuenciaTipo.unavez

  Public Property FrecuenciaTipo() As enumFrecuenciaTipo
    Get
      Return mFrecuenciaTipo
    End Get
    Set(ByVal value As enumFrecuenciaTipo)
      mFrecuenciaTipo = value
    End Set
  End Property

  Private mFrecuenciaHora As Date = Now

  Public Property FrecuenciaHora() As Date
    Get
      Return mFrecuenciaHora
    End Get
    Set(ByVal value As Date)
      mFrecuenciaHora = value
    End Set
  End Property

  Private mFrecuenciaMinutos As Long = 60

  Public Property FrecuenciaMinutos() As Long
    Get
      Return mFrecuenciaMinutos
    End Get
    Set(ByVal value As Long)
      mFrecuenciaMinutos = value
    End Set
  End Property

  <XmlIgnore()> _
  Public ReadOnly Property FrecuenciaHoras() As Integer
    Get
      If mFrecuenciaMinutos Mod 60 = 0 Then
        Return mFrecuenciaMinutos / 60
      Else
        Return 0
      End If
    End Get
  End Property

  Private mFrecuenciaHoraInicio As Date = Now

  Public Property FrecuenciaHoraInicio() As Date
    Get
      Return mFrecuenciaHoraInicio
    End Get
    Set(ByVal value As Date)
      mFrecuenciaHoraInicio = value
    End Set
  End Property

  Private mFrecuenciaHoraFin As Date = Now

  Public Property FrecuenciaHoraFin() As Date
    Get
      Return mFrecuenciaHoraFin
    End Get
    Set(ByVal value As Date)
      mFrecuenciaHoraFin = value
    End Set
  End Property

  Private mDuracionFechaInicio As Date = Now.Date

  Public Property DuracionFechaInicio() As Date
    Get
      Return mDuracionFechaInicio
    End Get
    Set(ByVal value As Date)
      mDuracionFechaInicio = value.Date
    End Set
  End Property

  Private mDuracionFechaFin As Date = Nothing

  Public Property DuracionFechaFin() As Date
    Get
      Return mDuracionFechaFin
    End Get
    Set(ByVal value As Date)
      If Not value = Nothing Then
        value = value.Date
      End If
      mDuracionFechaFin = value
    End Set
  End Property

  Public Sub ResetProximoEnvio()
    mFechaProximoEnvio = Nothing
  End Sub

  Private mFechaProximoEnvio As Date = Nothing
  <XmlIgnore()> _
  Public ReadOnly Property FechaProximoEnvio(ByVal _minutosagregados As Integer) As Date
    Get
      If mFechaProximoEnvio = Nothing OrElse mFechaProximoEnvio < Now Then
        mFechaProximoEnvio = ProximoEnvio(_minutosagregados)
      End If
      Return mFechaProximoEnvio
    End Get
  End Property

  Public Function ProximoEnvio(ByVal _minutosagregados As Integer) As Date
    If Not Listo Then
      Return Nothing
    End If
    Dim _fechareferencia As Date = DuracionFechaInicio
    If Now > DuracionFechaInicio Then
      _fechareferencia = Now.AddMinutes(_minutosagregados)
    End If

    'If _fechareferencia > FrecuenciaFechaFin Then
    '  Return Nothing
    'End If

    Dim _fechacadainicio As Date = DuracionFechaInicio.Date
    Dim _fechacadafin As Date = DuracionFechaInicio.Date

    While True
      If Sucede = enumSucede.Semanal Then
        _fechacadainicio = _fechacadainicio.AddDays(-CInt(_fechacadainicio.DayOfWeek))
        _fechacadafin = _fechacadainicio.AddDays(6)
      End If
      If Sucede = enumSucede.Mensual Then
        _fechacadainicio = _fechacadainicio.AddDays(-_fechacadainicio.Day + 1)
        _fechacadafin = _fechacadainicio.AddDays(32)
        _fechacadafin = _fechacadafin.AddDays(-_fechacadafin.Day)
      End If
      _fechacadafin = _fechacadafin.AddDays(1)

      If (_fechacadainicio > _fechareferencia) OrElse (_fechacadainicio <= _fechareferencia AndAlso _fechacadafin > _fechareferencia) Then ' si se paso o esta en rango
        If _fechareferencia < _fechacadainicio Then
          _fechareferencia = _fechacadainicio
        End If

        Select Case Sucede
          Case enumSucede.Diario
            '_fechareferencia = _fechacadainicio.Date
            Dim _fecha As Date = Frecuenciadiariamatch(_fechareferencia)
            If Not _fecha = Nothing Then
              _fechareferencia = _fecha
              If (Not DuracionFechaFin = Nothing) AndAlso _fechareferencia.Date > DuracionFechaFin Then
                Return Nothing
              Else
                Return _fechareferencia
              End If
            End If
          Case enumSucede.Semanal
            Dim _fechasemana As Date = _fechareferencia
            Dim t As Integer = _fechasemana.DayOfWeek

            While Not t > 6
              Dim _match As Boolean = False
              Select Case _fechasemana.DayOfWeek
                Case DayOfWeek.Sunday
                  _match = SucedeSemanalDomingo
                Case DayOfWeek.Monday
                  _match = SucedeSemanalLunes
                Case DayOfWeek.Tuesday
                  _match = SucedeSemanalMartes
                Case DayOfWeek.Wednesday
                  _match = SucedeSemanalMiercoles
                Case DayOfWeek.Thursday
                  _match = SucedeSemanalJueves
                Case DayOfWeek.Friday
                  _match = SucedeSemanalViernes
                Case DayOfWeek.Saturday
                  _match = SucedeSemanalSabado
              End Select

              If _match Then 'encontro el dia de la semana proximo a hacerlo
                Dim _fecha As Date = Frecuenciadiariamatch(_fechasemana)
                If Not _fecha = Nothing Then
                  _fechareferencia = _fecha
                  If (Not DuracionFechaFin = Nothing) AndAlso _fechareferencia.Date > DuracionFechaFin Then
                    Return Nothing
                  Else
                    Return _fechareferencia
                  End If
                End If
              End If

              _fechasemana = _fechasemana.AddDays(1)
              t += 1
            End While

          Case enumSucede.Mensual
            Select Case MensualTipo
              Case enumMensualTipo.eldia
                Dim _fecha As Date = _fechacadainicio.Date.AddDays(Mensualeldia - 1)
                If _fechareferencia.Date <= _fecha.Date Then
                  _fecha = Frecuenciadiariamatch(_fecha)
                  If Not _fecha = Nothing Then
                    _fechareferencia = _fecha
                    If (Not DuracionFechaFin = Nothing) AndAlso _fechareferencia.Date > DuracionFechaFin Then
                      Return Nothing
                    Else
                      Return _fechareferencia
                    End If
                  End If
                End If

              Case enumMensualTipo.primer
                Dim _fechames As Date = _fechacadainicio.Date
                Dim _diabuscado As Date = Nothing
                Dim _countencontrado As Integer = 0
                While _fechames <= _fechacadafin.Date
                  If CInt(_fechames.DayOfWeek) = MensualDiaSemana Then
                    _countencontrado += 1
                    _diabuscado = _fechames
                    Select Case MensualSemana
                      Case enumMensualSemana.Primer
                        If _countencontrado = 1 Then
                          Exit While
                        End If
                      Case enumMensualSemana.Segundo
                        If _countencontrado = 2 Then
                          Exit While
                        End If
                      Case enumMensualSemana.Tercer
                        If _countencontrado = 3 Then
                          Exit While
                        End If
                      Case enumMensualSemana.Cuarto
                        If _countencontrado = 4 Then
                          Exit While
                        End If
                    End Select
                  End If
                  _fechames = _fechames.AddDays(1)

                End While

                Dim _fecha As Date = Frecuenciadiariamatch(_diabuscado)
                If Not _fecha = Nothing Then
                  _fechareferencia = _fecha
                  If (Not DuracionFechaFin = Nothing) AndAlso _fechareferencia.Date > DuracionFechaFin Then
                    Return Nothing
                  Else
                    Return _fechareferencia
                  End If
                End If


            End Select
        End Select

        'Exit While
      End If

      'buscar siguiente rango
      Select Case Sucede
        Case enumSucede.Diario
          _fechacadainicio = _fechacadainicio.AddDays(SucedeCada)
          _fechacadafin = _fechacadafin.AddDays(SucedeCada)
        Case enumSucede.Semanal
          _fechacadainicio = _fechacadainicio.AddDays(7 * SucedeCada)
          _fechacadafin = _fechacadafin.AddDays(7 * SucedeCada)
        Case enumSucede.Mensual
          _fechacadainicio = _fechacadainicio.AddMonths(SucedeCada)
          _fechacadafin = _fechacadafin.AddMonths(SucedeCada)
      End Select

    End While

    Return Nothing

    'Loop While _fechacadafin <= _fechareferencia

  End Function

  Public Function Frecuenciadiariamatch(ByVal _fechareferencia As Date) As Date
    Dim fechaaux As Date = Nothing

    Select Case FrecuenciaTipo
      Case enumFrecuenciaTipo.unavez
        fechaaux = _fechareferencia.Date.Add(FrecuenciaHora.TimeOfDay)
        If fechaaux >= _fechareferencia Then
          Return fechaaux
        End If

      Case enumFrecuenciaTipo.cada
        fechaaux = _fechareferencia.Date.Add(FrecuenciaHoraInicio.TimeOfDay)

        Dim _frecuenciahorafin As Date = _fechareferencia.Date.Add(FrecuenciaHoraFin.TimeOfDay)
        If _frecuenciahorafin < fechaaux Then
          _frecuenciahorafin = _frecuenciahorafin.AddDays(1)
        End If

        While fechaaux <= _frecuenciahorafin
          If fechaaux >= _fechareferencia Then
            Return fechaaux
          End If

          fechaaux = fechaaux.AddMinutes(FrecuenciaMinutos)
        End While
    End Select
    Return Nothing
  End Function

  Public Function aXml() As String
    Dim Output As StringWriter = New StringWriter(New StringBuilder())
    Dim Ret As String = ""

    Try
      Dim s As XmlSerializer = New XmlSerializer(Me.GetType())
      s.Serialize(Output, Me)
      Ret = Output.ToString
    Catch
    End Try

    Return Ret
  End Function

  Public Shared Function deXml(ByVal _xml As String) As Programacion
    Dim input As StringReader = New StringReader(_xml)
    Dim output As New Programacion
    Try
      Dim s As XmlSerializer = New XmlSerializer(output.GetType)
      output = s.Deserialize(input)
    Catch
    End Try

    Return output
  End Function
End Class

Public Class Programaciones
  Inherits System.ComponentModel.BindingList(Of Programacion)

  Public Function aXml() As String
    Dim Output As StringWriter = New StringWriter(New StringBuilder())
    Dim Ret As String = ""

    Try
      Dim s As XmlSerializer = New XmlSerializer(Me.GetType())
      s.Serialize(Output, Me)
      Ret = Output.ToString
    Catch
    End Try

    Return Ret
  End Function
End Class

Public Class CorreoElectronico
  Private mCorreo As String = ""
  Public Property Correo() As String
    Get
      Return mCorreo
    End Get
    Set(ByVal value As String)
      mCorreo = value
    End Set
  End Property

  Public Sub New(ByVal _correo As String)
    Correo = _correo
  End Sub
End Class

Public Class CorreosElectronicos
  Inherits System.ComponentModel.BindingList(Of CorreoElectronico)

  Public Function astring() As String
    Dim Ret As String = ""

    For Each _correo As CorreoElectronico In Me
      If Not String.IsNullOrEmpty(Ret) Then
        Ret = Ret & "; "
      End If
      Ret = Ret & _correo.Correo
    Next

    Return Ret
  End Function

  Public Shared Function destring(ByVal _lista As String) As CorreosElectronicos
    Dim oresult As New CorreosElectronicos
    For Each _correo As String In _lista.Split(";")
      If Not String.IsNullOrEmpty(_correo.Trim) Then
        oresult.Add(New CorreoElectronico(_correo.Trim))
      End If
    Next
    Return oresult
  End Function
End Class

Public Class Contacto
  Private mSeleccionado As Boolean = False
  <Infoware.Reportes.CampoReporteAtributo("Seleccion", Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 65, True)> _
  Public Property Seleccionado() As Boolean
    Get
      Return mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      mSeleccionado = value
    End Set
  End Property

  Private mCorreo As String = ""
  <Infoware.Reportes.CampoReporteAtributo("email", Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public Property Correo() As String
    Get
      Return mCorreo
    End Get
    Set(ByVal value As String)
      mCorreo = value
    End Set
  End Property

  Private mNombre As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Nombre", Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property
End Class

Public Class ContactoList
  Inherits System.ComponentModel.BindingList(Of Contacto)

  Public Shared Function ObtenerLista(ByVal _reporte As Reporte, ByVal _correos As CorreosElectronicos, Optional ByVal _filtro As String = "") As ContactoList
    Dim oResult As ContactoList = New ContactoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _reporte.OperadorDatos
      .AgregarParametro("@Accion", "EmailTodos")
      .AgregarParametro("@AccionDatos", _filtro)
      .Procedimiento = _reporte.NombreProcedimiento
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Contacto()
        Try
          _fila.Correo = _dr(1)
        Catch ex As Exception
          _fila.Correo = ""
        End Try
        Try
          _fila.Nombre = _dr(0)
        Catch ex As Exception
          _fila.Nombre = ""
        End Try

        Dim _existe As Boolean = False
        For Each _correo As CorreoElectronico In _correos
          If _correo.Correo.ToLower.Trim = _fila.Correo Then
            _existe = True
            Exit For
          End If
        Next

        _fila.Seleccionado = _existe

        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

End Class