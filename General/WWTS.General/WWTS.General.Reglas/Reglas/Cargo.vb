

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports Infoware.Reglas
Imports Infoware.Reportes

Partial Public Class Cargo
  Inherits _Database

  Const _Procedimiento As String = "proc_cargo"

  Private mArea As Area = Nothing

  Private mAreaJefe As Area = Nothing

  Private mPardetDepartamento As WWTSParametroDet = Nothing

  Private mPardetArea As WWTSParametroDet = Nothing

  Private mPardetModeloLabor As WWTSParametroDet = Nothing

  Private mPardetDepartamentoJefe As WWTSParametroDet = Nothing

  Private mPardetAreaJefe As WWTSParametroDet = Nothing

  Private mCargoJefe As Cargo = Nothing

  Private mPardetActividadSectorial As WWTSParametroDet = Nothing

  Private mPardetEscalafon As WWTSParametroDet = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Parame_Departamento As Integer, ByVal _Pardet_Departamento As Integer, ByVal _Parame_Area As Integer, ByVal _Pardet_Area As Integer, ByVal _Cargo_Secuencia As Integer)
    Me.New(_OperadorDatos, False)
    Parame_Departamento = _Parame_Departamento
    Pardet_Departamento = _Pardet_Departamento
    Parame_Area = _Parame_Area
    Pardet_Area = _Pardet_Area
    Cargo_Secuencia = _Cargo_Secuencia
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Cargo")
    End If
  End Sub

  Public Overridable Property Area As Area
    Get
      If mArea Is Nothing AndAlso Pardet_Area > 0 Then
        mArea = New Area(OperadorDatos, Parame_Departamento, Pardet_Departamento, Parame_Area, Pardet_Area)
      End If
      Return mArea
    End Get
    Set(ByVal value As Area)
      mArea = value
      Parame_Departamento = value.Parame_Departamento
      Pardet_Departamento = value.Pardet_Departamento
      Parame_Area = value.Parame_Area
      Pardet_Area = value.Pardet_Area
    End Set
  End Property

  Public Overridable Property AreaJefe As Area
    Get
      If mAreaJefe Is Nothing AndAlso Pardet_AreaJefe > 0 Then
        mAreaJefe = New Area(OperadorDatos, Parame_DepartamentoJefe, Pardet_DepartamentoJefe, Parame_AreaJefe, Pardet_AreaJefe)
      End If
      Return mAreaJefe
    End Get
    Set(ByVal value As Area)
      mAreaJefe = value
      If value Is Nothing Then
        Parame_DepartamentoJefe = 0
        Pardet_DepartamentoJefe = 0
        Parame_AreaJefe = 0
        Pardet_AreaJefe = 0
      Else
        Parame_DepartamentoJefe = value.Parame_Departamento
        Pardet_DepartamentoJefe = value.Pardet_Departamento
        Parame_AreaJefe = value.Parame_Area
        Pardet_AreaJefe = value.Pardet_Area
      End If
    End Set
  End Property

  'PardetArea
  Public Overridable Property PardetArea() As WWTSParametroDet
    Get
      If Me.mPardetArea Is Nothing AndAlso Pardet_Area > 0 Then
        Me.mPardetArea = New WWTSParametroDet(OperadorDatos, Parame_Area, Pardet_Area)
      End If
      Return Me.mPardetArea
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetArea = value
      If value Is Nothing Then
        Parame_Area = 0
        Pardet_Area = 0
      Else
        Parame_Area = value.Parame_Codigo
        Pardet_Area = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetModeloLabor
  Public Overridable Property PardetModeloLabor() As WWTSParametroDet
    Get
      If Me.mPardetModeloLabor Is Nothing AndAlso Pardet_ModeloLabor > 0 Then
        Me.mPardetModeloLabor = New WWTSParametroDet(OperadorDatos, Parame_ModeloLabor, Pardet_ModeloLabor)
      End If
      Return Me.mPardetModeloLabor
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetModeloLabor = value
      If value Is Nothing Then
        Parame_ModeloLabor = 0
        Pardet_ModeloLabor = 0
      Else
        Parame_ModeloLabor = value.Parame_Codigo
        Pardet_ModeloLabor = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetAreaJefe
  Public Overridable Property PardetAreaJefe() As WWTSParametroDet
    Get
      If Me.mPardetAreaJefe Is Nothing AndAlso Pardet_AreaJefe > 0 Then
        Me.mPardetAreaJefe = New WWTSParametroDet(OperadorDatos, Parame_AreaJefe, Pardet_AreaJefe)
      End If
      Return Me.mPardetAreaJefe
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetAreaJefe = value
      If value Is Nothing Then
        Parame_AreaJefe = 0
        Pardet_AreaJefe = 0
      Else
        Parame_AreaJefe = value.Parame_Codigo
        Pardet_AreaJefe = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'CargoJefe
  Public Overridable Property CargoJefe() As Cargo
    Get
      If Me.mCargoJefe Is Nothing AndAlso Cargo_SecuenciaJefe > 0 Then
        Me.mCargoJefe = New Cargo(OperadorDatos, Parame_DepartamentoJefe, Pardet_DepartamentoJefe, Parame_AreaJefe, Pardet_AreaJefe, Cargo_SecuenciaJefe)
      End If
      Return Me.mCargoJefe
    End Get
    Set(ByVal value As Cargo)
      Me.mCargoJefe = value
      If value Is Nothing Then
        Parame_DepartamentoJefe = 0
        Pardet_DepartamentoJefe = 0
        Parame_AreaJefe = 0
        Pardet_AreaJefe = 0
        Cargo_SecuenciaJefe = 0
      Else
        Parame_DepartamentoJefe = mCargoJefe.Parame_Departamento
        Pardet_DepartamentoJefe = mCargoJefe.Pardet_Departamento
        Parame_AreaJefe = mCargoJefe.Parame_AreaJefe
        Pardet_AreaJefe = mCargoJefe.Pardet_AreaJefe
        Cargo_SecuenciaJefe = mCargoJefe.Cargo_Secuencia
      End If
    End Set
  End Property

  'PardetDepartamento
  Public Overridable Property PardetDepartamento() As WWTSParametroDet
    Get
      If Me.mPardetDepartamento Is Nothing AndAlso Pardet_Departamento > 0 Then
        Me.mPardetDepartamento = New WWTSParametroDet(OperadorDatos, Parame_Departamento, Pardet_Departamento)
      End If
      Return Me.mPardetDepartamento
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetDepartamento = value
      If value Is Nothing Then
        Parame_Departamento = 0
        Pardet_Departamento = 0
      Else
        Parame_Departamento = value.Parame_Codigo
        Pardet_Departamento = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetDepartamentoJefe
  Public Overridable Property PardetDepartamentoJefe() As WWTSParametroDet
    Get
      If Me.mPardetDepartamentoJefe Is Nothing AndAlso Pardet_DepartamentoJefe > 0 Then
        Me.mPardetDepartamentoJefe = New WWTSParametroDet(OperadorDatos, Parame_DepartamentoJefe, Pardet_DepartamentoJefe)
      End If
      Return Me.mPardetDepartamentoJefe
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetDepartamentoJefe = value
      If value Is Nothing Then
        Parame_DepartamentoJefe = 0
        Pardet_DepartamentoJefe = 0
      Else
        Parame_DepartamentoJefe = value.Parame_Codigo
        Pardet_DepartamentoJefe = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetActividadSectorial
  Public Overridable Property PardetActividadSectorial() As WWTSParametroDet
    Get
      If Me.mPardetActividadSectorial Is Nothing AndAlso Pardet_ActividadSectorial > 0 Then
        Me.mPardetActividadSectorial = New WWTSParametroDet(OperadorDatos, Parame_ActividadSectorial, Pardet_ActividadSectorial)
      End If
      Return Me.mPardetActividadSectorial
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetActividadSectorial = value
      If value Is Nothing Then
        Parame_ActividadSectorial = 0
        Pardet_ActividadSectorial = 0
      Else
        Parame_ActividadSectorial = value.Parame_Codigo
        Pardet_ActividadSectorial = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'PardetEscalafon
  Public Overridable Property PardetEscalafon() As WWTSParametroDet
    Get
      If Me.mPardetEscalafon Is Nothing AndAlso Pardet_Escalafon > 0 Then
        Me.mPardetEscalafon = New WWTSParametroDet(OperadorDatos, Parame_Escalafon, Pardet_Escalafon)
      End If
      Return Me.mPardetEscalafon
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetEscalafon = value
      Parame_Escalafon = value.Parame_Codigo
      Pardet_Escalafon = value.Pardet_Secuencia
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Sección", CampoReporteAtributo.EnumTipoDato.Texto, 125, True)> _
  Public ReadOnly Property SeccionString As String
    Get
      If PardetDepartamento Is Nothing Then
        Return String.Empty
      Else
        Return PardetDepartamento.PardetPadre.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Área", CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public ReadOnly Property AreaString As String
    Get
      If PardetArea Is Nothing Then
        Return String.Empty
      Else
        Return PardetArea.Pardet_Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Cargo", CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public ReadOnly Property CargoString As String
    Get
      Return Cargo_Descripcion
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Empleado Actual", CampoReporteAtributo.EnumTipoDato.Texto, 170, True)> _
  Public ReadOnly Property EmpleadoActual As String
    Get
      Return EmpleadoCargo()
    End Get
  End Property


  <Infoware.Reportes.CampoReporteAtributo("Cargo Jefe Inmediato", CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property JefeInmediato As String
    Get
      If CargoJefe Is Nothing Then
        Return "*** Libre ***"
      Else
        Dim cadena As String = ""
        cadena += CargoJefe.Cargo_Descripcion
        Try
          cadena += " / " + CargoJefe.Area.PardetArea.Pardet_Descripcion
        Catch ex As Exception
          cadena += " / "
        End Try
        Try
          cadena += " / " + CargoJefe.Area.PardetDepartamento.PardetPadre.Pardet_Descripcion
        Catch ex As Exception
          cadena += " / "
        End Try
        Return cadena
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Empleado Actual", CampoReporteAtributo.EnumTipoDato.Texto, 170, True)> _
  Public ReadOnly Property JefeInmediatoEmpleadoActual As String
    Get
      Return JefeCargo()
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Escalafón", CampoReporteAtributo.EnumTipoDato.Texto, 125, True)> _
    Public ReadOnly Property EscalafonString As String
    Get
      If PardetEscalafon Is Nothing Then
        Return String.Empty
      Else
        Return PardetEscalafon.Pardet_Descripcion
      End If
    End Get
  End Property

  Public Function EmpleadoCargo() As String
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As String = "*** Libre ***"

    With Me.OperadorDatos
      .AgregarParametro("@accion", "EC")
      .AgregarParametro("@Parame_Departamento", Parame_Departamento)
      .AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
      .AgregarParametro("@Parame_Area", Parame_Area)
      .AgregarParametro("@Pardet_Area", Pardet_Area)
      .AgregarParametro("@Cargo_Secuencia", Cargo_Secuencia)
      .Procedimiento = "proc_cargo"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CStr(dsResult.Rows(0)("NombreCompleto"))
    End If
    Return oResult
  End Function

  Public Function JefeCargo() As String
    Dim dsResult As New DataTable
    Dim bResult As Boolean
    Dim oResult As String = "*** Libre ***"

    With Me.OperadorDatos
      .AgregarParametro("@accion", "EC")
      .AgregarParametro("@Parame_Departamento", Parame_DepartamentoJefe)
      .AgregarParametro("@Pardet_Departamento", Pardet_DepartamentoJefe)
      .AgregarParametro("@Parame_Area", Parame_AreaJefe)
      .AgregarParametro("@Pardet_Area", Pardet_AreaJefe)
      .AgregarParametro("@Cargo_Secuencia", Cargo_SecuenciaJefe)
      .Procedimiento = "proc_cargo"
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With

    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      oResult = CStr(dsResult.Rows(0)("NombreCompleto"))
    End If
    Return oResult
  End Function

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Parame_Departamento = CType(Fila("Parame_Departamento"), Integer)
    Pardet_Departamento = CType(Fila("Pardet_Departamento"), Integer)
    Parame_Area = CType(Fila("Parame_Area"), Integer)
    Pardet_Area = CType(Fila("Pardet_Area"), Integer)
    Cargo_Secuencia = CType(Fila("Cargo_Secuencia"), Integer)
    Cargo_Descripcion = CType(Fila("Cargo_Descripcion"), String)
    Parame_ModeloLabor = CType(Fila("Parame_ModeloLabor"), Integer)
    Pardet_ModeloLabor = CType(Fila("Pardet_ModeloLabor"), Integer)
    Cargo_ControlarHorasExtras = CType(Fila("Cargo_ControlarHorasExtras"), Boolean)
    Parame_DepartamentoJefe = 0
    Pardet_DepartamentoJefe = 0
    If Not TypeOf Fila("Parame_DepartamentoJefe") Is dbnull Then
      Parame_DepartamentoJefe = CType(Fila("Parame_DepartamentoJefe"), Integer)
    End If
    If Not TypeOf Fila("Pardet_DepartamentoJefe") Is dbnull Then
      Pardet_DepartamentoJefe = CType(Fila("Pardet_DepartamentoJefe"), Integer)
    End If
    Parame_AreaJefe = 0
    Pardet_AreaJefe = 0
    If Not TypeOf Fila("Parame_AreaJefe") Is dbnull Then
      Parame_AreaJefe = CInt(Fila("Parame_AreaJefe"))
    End If
    If Not TypeOf Fila("Pardet_AreaJefe") Is dbnull Then
      Pardet_AreaJefe = CInt(Fila("Pardet_AreaJefe"))
    End If
    Cargo_SecuenciaJefe = 0
    If Not TypeOf Fila("Cargo_SecuenciaJefe") Is dbnull Then
      Cargo_SecuenciaJefe = CInt(Fila("Cargo_SecuenciaJefe"))
    End If
    Parame_ActividadSectorial = CType(Fila("Parame_ActividadSectorial"), Integer)
    Pardet_ActividadSectorial = CType(Fila("Pardet_ActividadSectorial"), Integer)

    Parame_Escalafon = CType(Fila("Parame_Escalafon"), Integer)
    Pardet_Escalafon = CType(Fila("Pardet_Escalafon"), Integer)

    mPardetDepartamento = Nothing
    mPardetArea = Nothing
    mPardetModeloLabor = Nothing
    mPardetDepartamentoJefe = Nothing
    mPardetAreaJefe = Nothing
    mArea = Nothing
    mAreaJefe = Nothing
    mCargoJefe = Nothing
    mPardetActividadSectorial = Nothing
    mPardetEscalafon = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Cargo_Secuencia", Cargo_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Cargo_Secuencia", Cargo_Secuencia)
    OperadorDatos.AgregarParametro("@Cargo_Descripcion", Cargo_Descripcion)
    OperadorDatos.AgregarParametro("@Parame_ModeloLabor", Parame_ModeloLabor)
    OperadorDatos.AgregarParametro("@Pardet_ModeloLabor", Pardet_ModeloLabor)
    OperadorDatos.AgregarParametro("@Cargo_ControlarHorasExtras", Cargo_ControlarHorasExtras)
    If Pardet_DepartamentoJefe > 0 And Pardet_AreaJefe > 0 And Cargo_SecuenciaJefe > 0 Then
      OperadorDatos.AgregarParametro("@Parame_DepartamentoJefe", Parame_DepartamentoJefe)
      OperadorDatos.AgregarParametro("@Pardet_DepartamentoJefe", Pardet_DepartamentoJefe)
      OperadorDatos.AgregarParametro("@Parame_AreaJefe", Parame_AreaJefe)
      OperadorDatos.AgregarParametro("@Pardet_AreaJefe", Pardet_AreaJefe)
      OperadorDatos.AgregarParametro("@Cargo_SecuenciaJefe", Cargo_SecuenciaJefe)
    End If
    OperadorDatos.AgregarParametro("Parame_ActividadSectorial", Parame_ActividadSectorial)
    OperadorDatos.AgregarParametro("Pardet_ActividadSectorial", Pardet_ActividadSectorial)

    OperadorDatos.AgregarParametro("Parame_Escalafon", Parame_Escalafon)
    OperadorDatos.AgregarParametro("Pardet_Escalafon", Pardet_Escalafon)

    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      EsNuevo = False
      EsModificado = False
    End If
    Return bReturn
  End Function

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Parame_Departamento", Parame_Departamento)
    OperadorDatos.AgregarParametro("@Pardet_Departamento", Pardet_Departamento)
    OperadorDatos.AgregarParametro("@Parame_Area", Parame_Area)
    OperadorDatos.AgregarParametro("@Pardet_Area", Pardet_Area)
    OperadorDatos.AgregarParametro("@Cargo_Secuencia", Cargo_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class


Public Class CargoList
  Inherits System.ComponentModel.BindingList(Of Cargo)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As CargoList
    Dim oResult As CargoList = New CargoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_cargo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Cargo(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerLista(ByVal _Area As Area, Optional ByVal _filtro As String = "") As CargoList
    Dim oResult As CargoList = New CargoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Area.OperadorDatos
      .AgregarParametro("@accion", "FA")
      .AgregarParametro("@Parame_Departamento", _Area.Parame_Departamento)
      .AgregarParametro("@Pardet_Departamento", _Area.Pardet_Departamento)
      .AgregarParametro("@Parame_Area", _Area.Parame_Area)
      .AgregarParametro("@Pardet_Area", _Area.Pardet_Area)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_cargo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Cargo(_Area.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerListaSubordinados(ByVal _Cargo As Cargo, Optional ByVal _filtro As String = "") As CargoList
    Dim oResult As CargoList = New CargoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Cargo.OperadorDatos
      .AgregarParametro("@accion", "FS")
      .AgregarParametro("@Parame_DepartamentoJefe", _Cargo.Parame_DepartamentoJefe)
      .AgregarParametro("@Pardet_DepartamentoJefe", _Cargo.Pardet_DepartamentoJefe)
      .AgregarParametro("@Parame_AreaJefe", _Cargo.Parame_AreaJefe)
      .AgregarParametro("@Pardet_AreaJefe", _Cargo.Pardet_AreaJefe)
      .AgregarParametro("@Cargo_SecuenciaJefe", _Cargo.Cargo_SecuenciaJefe)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_cargo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Cargo(_Cargo.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerCargos(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As CargoList
    Dim oResult As CargoList = New CargoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@accion", "FT")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_cargo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Cargo(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class