Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Datos
Imports Infoware.Reglas

Public Class Usuario
  Implements IRegla

  Private Const _Procedimiento As String = "proc_Usuario"
  'Private mEmpleado As Empleado = Nothing

  Public ReadOnly Property Descripcion() As String
    Get
      Return String.Format("({0}) {1}", Usuari_Codigo.Trim, Usuari_Descripcion)
    End Get
  End Property

#Region "Restricciones"
  Private WithEvents mRestricciones As RestriccionList = Nothing
  Public Property Restricciones() As RestriccionList
    Get
      If mRestricciones Is Nothing Then
        If EsNuevo Then
          mRestricciones = New RestriccionList
          For Each _modulo As ParametroDet In ParametroDetList.ObtenerListaOrdenCodigo(OperadorDatos, 5)
            Dim _restric As New Restriccion(OperadorDatos, _modulo, Me)
            _restric.Restri_Lectura = True
            _restric.Restri_Ingreso = True
            _restric.Restri_Modificacion = True
            _restric.Restri_Eliminacion = True
            _restric.Restri_Impresion = True
            _restric.Restri_VerConfidencial = True
            mRestricciones.Add(_restric)
          Next
        Else
          mRestricciones = Restriccion.RetornarRestricciones(OperadorDatos, Me)
        End If
      End If
      Return mRestricciones
    End Get
    Set(ByVal value As RestriccionList)
      mRestricciones = value
    End Set
  End Property
#End Region

	'Empleado
	'Public Overridable Property Empleado() As Empleado
	'  Get
	'    If Me.mEmpleado Is Nothing AndAlso Not Entida_Empleado = 0 Then
	'      Try
	'        Me.mEmpleado = New Empleado(OperadorDatos, Entida_Empleado)
	'      Catch ex As Exception
	'        Me.mEmpleado = Nothing
	'      End Try
	'    End If
	'    Return Me.mEmpleado
	'  End Get
	'  Set(ByVal value As Empleado)
	'    Me.mEmpleado = value
	'    If value Is Nothing Then
	'      Entida_Empleado = 0
	'    Else
	'      Entida_Empleado = value.Entida_Codigo
	'    End If
	'  End Set
	'End Property

#Region "Constructores de la clase"
	Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Usuari_Codigo As String)
    Me.New(_OperadorDatos, False)
    Usuari_Codigo = _Usuari_Codigo
    If Not Me.Recargar Then
      Throw New Exception(String.Format("No existe el usuario {0}. Intente nuevamente", _Usuari_Codigo))
    End If
  End Sub
#End Region

#Region "Implementación de los métodos de persistencia"
  Public Overridable Function Recargar() As Boolean Implements IRegla.Recargar
    Dim dsResult As New DataTable
    Dim bResult As Boolean

    With Me.OperadorDatos
      .AgregarParametro("@accion", "C")
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .Procedimiento = _Procedimiento
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      Me.MapearDataRowaObjeto(dsResult.Rows(0))
      Return True
    Else
      Return False
    End If
  End Function
#End Region

#Region "Métodos internos de la clase"
  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow) Implements IRegla.MapearDataRowaObjeto
    Usuari_Codigo = CStr(Fila("Usuari_Codigo"))
    Usuari_Descripcion = CStr(Fila("Usuari_Descripcion"))
    Usuari_Password = String.Empty
    Usuari_Mensaje = CStr(Fila("Usuari_Mensaje"))
    Usuari_RegEntSal = CBool(Fila("Usuari_RegEntSal"))
    Usuari_RegIngModEli = CBool(Fila("Usuari_RegIngModEli"))
    Usuari_RegImp = CBool(Fila("Usuari_RegImp"))
    Usuari_RegConfidencial = CBool(Fila("Usuari_RegConfidencial"))
    Try
      Usuari_CambiarContrasena = CBool(Fila("Usuari_CambiarContrasena"))
    Catch ex As Exception
      Usuari_CambiarContrasena = False
    End Try
  End Sub

  Public Overridable Function Guardar() As Boolean Implements IRegla.Guardar
    Dim dsResult As New DataTable
    Dim bReturn As Boolean
    Dim sAccion As String = String.Empty
    If EsNuevo Then
      sAccion = "I"
    Else
      sAccion = "M"
    End If

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    With OperadorDatos
      .AgregarParametro("@accion", sAccion)
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .AgregarParametro("@Usuari_Descripcion", Usuari_Descripcion)
      '.AgregarParametro("@Usuari_Password", Usuari_Password)
      .AgregarParametro("@Usuari_Mensaje", Usuari_Mensaje)
      .AgregarParametro("@Usuari_RegEntSal", Usuari_RegEntSal)
      .AgregarParametro("@Usuari_RegIngModEli", Usuari_RegIngModEli)
      .AgregarParametro("@Usuari_RegImp", Usuari_RegImp)
      .AgregarParametro("@Usuari_RegConfidencial", Usuari_RegConfidencial)
      .AgregarParametro("@Usuari_CambiarContrasena", Usuari_CambiarContrasena)

      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
      If bReturn Then
        For Each _restriccion As Restriccion In Restricciones
          _restriccion.Usuario = Me
          If Not _restriccion.Guardar() Then
            bReturn = False
            Exit For
          End If
        Next

        If Not OperadorDatos.EstaenTransaccion Then
          EsNuevo = False
          EsModificado = False
        End If
      End If
    End With

    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambios()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Function AceptarCambios() As Boolean
    EsNuevo = False
    EsModificado = False

    For Each _restriccion As Restriccion In mRestricciones
      _restriccion.AceptarCambios()
    Next
    Return True
  End Function

  Public Overridable Function CambiarContrasena() As Boolean
		Dim dsResult As New DataTable
		Dim bResult As Boolean
		With OperadorDatos
			.AgregarParametro("@accion", "MP")
			.AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
			.AgregarParametro("@Usuari_Password", Usuari_Password)
			.Procedimiento = _Procedimiento
			bResult = .Ejecutar(dsResult)
			.LimpiarParametros()
		End With
		If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
			Return CBool(dsResult.Rows(0)(0))
		Else
			Return False
		End If
	End Function

	Public Overridable Function Eliminar() As Boolean Implements IRegla.Eliminar
    Dim dsResult As New DataTable
    Dim bReturn As Boolean
    With OperadorDatos
      .AgregarParametro("@accion", "E")
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    Return bReturn
  End Function

  Public Function VerificarPassword(ByVal _password As String) As Boolean
    Dim dsResult As New datatable
    Dim bResult As Boolean

    With Me.OperadorDatos
      .AgregarParametro("@accion", "CP")
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .AgregarParametro("@Usuari_Password", _password)
      .Procedimiento = _Procedimiento
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      Return CBool(dsResult.Rows(0)(0))
    Else
      Return False
    End If
  End Function
#End Region

  '#Region "Métodos compartidos"
  '  Public Shared Function RetornarUsuarios(ByVal _OperadorDatos As OperadorDatos, ByVal _nombre As String) As UsuarioList
  '    Dim oResult As New UsuarioList
  '    Dim bReturn As Boolean
  '    Dim dsResult As New datatable
  '    With _OperadorDatos
  '      .AgregarParametro("@accion", "G")
  '      .AgregarParametro("@usu_nombre", _nombre)
  '      .Procedimiento = _Procedimiento
  '      bReturn = .Ejecutar(dsResult)
  '      .LimpiarParametros()
  '    End With
  '    If bReturn AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
  '      For Each _dr As DataRow In dsResult.Rows
  '        Dim _obj As New Usuario(_OperadorDatos, False)
  '        _obj.MapearDataRowaObjeto(_dr)
  '        _obj.EsNuevo = False
  '        oResult.Add(_obj)
  '      Next
  '    End If
  '    Return oResult
  '  End Function
  '#End Region

End Class

Public Class UsuarioList
  Inherits System.ComponentModel.BindingList(Of Usuario)
  Public Sub New()
  End Sub

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As UsuarioList
    Dim oResult As UsuarioList = New UsuarioList
    Dim bReturn As Boolean
    Dim ds As datatable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Usuario"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Usuario(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
