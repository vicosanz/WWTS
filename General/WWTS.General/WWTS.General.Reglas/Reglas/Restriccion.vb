Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Datos
Imports Infoware.Reglas

Public Class Restriccion
  Implements IRegla

  Private Const _Procedimiento As String = "proc_Restriccion"
  Private mUsuario As Usuario = Nothing
  Private mPardetOpcion As ParametroDet = Nothing

#Region "Propiedades públicas de la clase"
 
  Public Property Usuario() As Usuario
    Get
      If mUsuario Is Nothing And Not Usuari_Codigo = String.Empty Then
        mUsuario = New Usuario(Me.OperadorDatos, Usuari_Codigo)
      End If
      Return mUsuario
    End Get
    Set(ByVal Value As Usuario)
      If Value Is Nothing Then
        Throw New ArgumentNullException("No se pudo enlazar Usuario")
      End If
      mUsuario = Value
      Usuari_Codigo = Value.Usuari_Codigo
    End Set
  End Property

  Public Shadows Property Pardet_OpcionesEnum() As Enumerados.EnumOpciones
    Get
      Return CType(Pardet_Opciones, Enumerados.EnumOpciones)
    End Get
    Set(ByVal value As Enumerados.EnumOpciones)
      Pardet_Opciones = CInt(value)
      mPardetOpcion = Nothing
    End Set
  End Property

  Public Property PardetOpcion() As ParametroDet
    Get
      If mPardetOpcion Is Nothing AndAlso Not Pardet_Opciones = 0 Then
        mPardetOpcion = New ParametroDet(Me.OperadorDatos, Enumerados.EnumParametros.Opciones, Pardet_Opciones)
      End If
      Return mPardetOpcion
    End Get
    Set(ByVal Value As ParametroDet)
      If Value Is Nothing Then
        Throw New ArgumentNullException("No se pudo enlazar ParametroDet")
      End If
      Me.mPardetOpcion = Value
      Pardet_Opciones = Value.Pardet_Secuencia
    End Set
  End Property

  Public ReadOnly Property PardetOpcionString() As String
    Get
      If PardetOpcion Is Nothing Then
        Return String.Empty
      Else
        Return mPardetOpcion.Pardet_Descripcion
      End If
    End Get
  End Property
#End Region

#Region "Constructores de la clase"
  Private Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _nuevo As Boolean)
    If _OperadorDatos Is Nothing Then
      Throw New InvalidOperationException("El operador de datos es nulo")
    End If

    OperadorDatos = _OperadorDatos
    EsNuevo = _nuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _ParametroDet As ParametroDet, ByVal _Usuario As Usuario)
    Me.New(_OperadorDatos, False)

    Me.Usuario = _Usuario
    Me.PardetOpcion = _ParametroDet
    If Not Me.Recargar Then
      'Throw New Exception("El objeto no puede ser cargado")
      EsNuevo = True
    End If
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Usuario As Usuario)
    Me.New(_OperadorDatos, True)
    Me.Usuario = _Usuario
  End Sub
#End Region

#Region "Métodos internos de la clase"
  Private Sub MapearDataRowaObjeto(ByVal Fila As DataRow) Implements IRegla.MapearDataRowaObjeto
    Me.Parame_Opciones = CType(Fila("Parame_Opciones"), Integer)
    Me.Pardet_Opciones = CType(Fila("Pardet_Opciones"), Integer)
    Me.Usuari_Codigo = CStr(Fila("Usuari_Codigo"))
    Me.Restri_Lectura = CBool(Fila("Restri_Lectura"))
    Me.Restri_Escritura = CBool(Fila("Restri_Escritura"))
    Me.Restri_Impresion = CBool(Fila("Restri_Impresion"))
    Me.Restri_VerConfidencial = CBool(Fila("Restri_VerConfidencial"))
    Me.mPardetOpcion = Nothing
    Me.mUsuario = Nothing
  End Sub

  Public Function Recargar() As Boolean Implements IRegla.Recargar
    Dim dsResult As New datatable
    Dim bResult As Boolean

    With Me.OperadorDatos
      .AgregarParametro("@accion", "C")
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .AgregarParametro("@Parame_Opciones", Parame_Opciones)
      .AgregarParametro("@Pardet_Opciones", Pardet_Opciones)
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

  Public Function Guardar() As Boolean Implements IRegla.Guardar
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim dsResult As New datatable
    Dim bReturn As Boolean
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    With OperadorDatos
      .AgregarParametro("@accion", sAccion)
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .AgregarParametro("@Parame_Opciones", Parame_Opciones)
      .AgregarParametro("@Pardet_Opciones", Pardet_Opciones)
      .AgregarParametro("@Restri_Lectura", Restri_Lectura)
      .AgregarParametro("@Restri_Escritura", Restri_Escritura)
      .AgregarParametro("@Restri_Impresion", Restri_Impresion)
      .AgregarParametro("@Restri_VerConfidencial", Restri_VerConfidencial)
      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()

      If bReturn Then
        If Not OperadorDatos.EstaenTransaccion Then
          AceptarCambios()
        End If
      End If
    End With
    Return bReturn
  End Function

  Public Overridable Function AceptarCambios() As Boolean
    EsNuevo = False
    EsModificado = False
  End Function

  Public Function Eliminar() As Boolean Implements IRegla.Eliminar
    Dim dsResult As New datatable
    Dim bReturn As Boolean
    With OperadorDatos
      .AgregarParametro("@accion", "E")
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .AgregarParametro("@Parame_Opciones", Parame_Opciones)
      .AgregarParametro("@Pardet_Opciones", Pardet_Opciones)
      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    Return bReturn
  End Function
#End Region

#Region "Métodos compartidos"
  'Public Shared Function RetornarDataGridStyle(ByVal _op As OperadorDatos, ByVal _dg As DataGrid, ByVal _ReadOnly As Boolean) As DataGridTableStyle
  '  Dim TS As New DataGridTableStyle
  '  If _dg.DataSource Is Nothing Then
  '    Return TS
  '    Exit Function
  '  End If
  '  TS.MappingName = _dg.DataSource.GetType.Name

  'Dim TC1 As New DataGridTextBoxColumn
  '  TC1.MappingName = "Pardet_Opciones"
  '  TC1.HeaderText = "Módulo"
  '  TC1.Width = 125
  '  TC1.ReadOnly = True
  '  TS.GridColumnStyles.Add(TC1)

  '  Dim TC2 As New DataGridBoolColumn
  '  TC2.NullValue = False
  '  TC2.MappingName = "Restri_Lectura"
  '  TC2.HeaderText = "Lectura"
  '  TC2.Width = 85
  '  TC2.ReadOnly = _ReadOnly
  '  TS.GridColumnStyles.Add(TC2)

  '  Dim TC3 As New DataGridBoolColumn
  '  TC3.NullValue = False
  '  TC3.MappingName = "Restri_Escritura"
  '  TC3.HeaderText = "Escritura"
  '  TC3.Width = 85
  '  TC3.ReadOnly = _ReadOnly
  '  TS.GridColumnStyles.Add(TC3)

  '  Dim TC4 As New DataGridBoolColumn
  '  TC4.NullValue = False
  '  TC4.MappingName = "Restri_Impresion"
  '  TC4.HeaderText = "Impresión"
  '  TC4.Width = 85
  '  TC4.ReadOnly = _ReadOnly
  '  TS.GridColumnStyles.Add(TC4)

  '  Dim TC5 As New DataGridBoolColumn
  '  TC5.NullValue = False
  '  TC5.MappingName = "Restri_VerConfidencial"
  '  TC5.HeaderText = "Confidencial"
  '  TC5.Width = 85
  '  TC5.ReadOnly = _ReadOnly
  '  TS.GridColumnStyles.Add(TC5)

  '  Return TS
  'End Function

  Public Shared Function RetornarRestricciones(ByVal _OperadorDatos As OperadorDatos, ByVal _Usuario As Usuario) As RestriccionList
    Dim oResult As New RestriccionList
    Dim bReturn As Boolean
    Dim dsResult As New datatable
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@Usuari_Codigo", _Usuario.Usuari_Codigo)
      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      For Each _dr As DataRow In dsResult.Rows
        Dim _obj As New Restriccion(_OperadorDatos, False)
        _obj.MapearDataRowaObjeto(_dr)
        oResult.Add(_obj)
      Next
    End If
    Return oResult
  End Function
#End Region
End Class

Public Class RestriccionList
  Inherits System.ComponentModel.BindingList(Of Restriccion)
  Public Sub New()

  End Sub

  Public Function Buscar(ByVal _opcion As Enumerados.EnumOpciones) As Restriccion
    For Each _restriccion As Restriccion In Me.Items
      If _restriccion.Pardet_Opciones = _opcion Then
        Return _restriccion
      End If
    Next
    Return Nothing
  End Function
End Class


