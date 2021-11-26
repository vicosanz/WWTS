Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Microsoft.Office.Interop
'Imports WWTS.General.Reglas
'Imports WWTS.Reporteador.Reglas
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports Infoware.Consola.Base.StructExcel

Public Class FrmLista
  Implements IOpcion

  Private mManInsert As String = ""
  Private Property PuedeAgregar() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManInsert)
    End Get
    Set(ByVal value As Boolean)
      mManInsert = value
    End Set
  End Property

  Private mManUpdate As String = ""
  Private Property PuedeModificar() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManUpdate)
    End Get
    Set(ByVal value As Boolean)
      mManUpdate = value
    End Set
  End Property

  Private mManDelete As String = ""
  Private Property PuedeEliminar() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManDelete)
    End Get
    Set(ByVal value As Boolean)
      mManDelete = value
    End Set
  End Property

  Private mAutoejecutable As Boolean = False
  Public ReadOnly Property PuedeAutoejecutar() As Boolean
    Get
      Return mAutoejecutable
    End Get
  End Property

  Private mEnviarMailAutomaticoyCerrar As Boolean = False
  Private mOriginalMessage As Microsoft.Office.Interop.Outlook.MailItem = Nothing

  Public Property EnviarMailAutomaticoyCerrar(Optional OriginalMessage As Microsoft.Office.Interop.Outlook.MailItem = Nothing) As Boolean
    Get
      Return mEnviarMailAutomaticoyCerrar
    End Get
    Set(ByVal value As Boolean)
      mEnviarMailAutomaticoyCerrar = value
      mOriginalMessage = OriginalMessage
    End Set
  End Property

#Region "IOpcion"
  Private mCargarFiltrosDefaults As Boolean = False
  Private mReporte As Reporte = Nothing
  Public WriteOnly Property Reporte() As Reporte
    Set(ByVal value As Reporte)
      mReporte = value
      If value IsNot Nothing Then
        ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
        Me.ToolStrip2.Visible = False

        mCargarFiltrosDefaults = True
        'Llenar_Filtros()
        'Llenar_Defaults()
      End If
    End Set
  End Property

  Private mValores As Object()
  Public Property Valores() As Object()
    Get
      Return mValores
    End Get
    Set(ByVal value As Object())
      mValores = value
      'If value IsNot Nothing Then
      '  tmrdatos.Enabled = True
      'End If
    End Set
  End Property
#End Region

#Region "Llenardatos"
  Function IsValidEmail(ByVal strIn As String) As Boolean
    ' Return true if strIn is in valid e-mail format.
    Return Regex.IsMatch(strIn, _
           "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
  End Function

  Private mProgramacion As Programacion

  Sub Llenar_Filtros()
    Me.Titulo = mReporte.NombreReporte
    Me.DocSalida = mReporte.RetornarDocSalida
    Me.AutoUpdate = mReporte.RetornarAutoRefresco

    Me.Panel1.Controls.Clear()
    Dim esSinFiltros As Boolean = True
    For Each _param As ParametroReporte In mReporte.Parametros
      If Not _param.Oculto Then
        esSinFiltros = False
      End If

      Dim _label1 As New Label
      _label1.Height = 5
      _label1.Dock = DockStyle.Top
      Me.Panel1.Controls.Add(_label1)
      _label1.BringToFront()
      _label1.Visible = Not _param.Oculto

      Select Case _param.TipoDatoNet
        Case ParametroReporte.EnumTipoDato.Logico ', ParametroReporte.EnumTipoDato.Combo
        Case Else
          Dim _etiqueta As New Label()
          _etiqueta.Text = _param.NombreColumna
          _etiqueta.Dock = DockStyle.Top
          Me.Panel1.Controls.Add(_etiqueta)
          _etiqueta.BringToFront()
          _etiqueta.Visible = Not _param.Oculto
      End Select

      Select Case _param.TipoDatoNet
        Case ParametroReporte.EnumTipoDato.Texto
          Dim _texto As New Infoware.Controles.Base.TextBoxStd
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Entero
          Dim _texto As New Infoware.Controles.Base.TextBoxCalculator
          _texto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Decimales
          Dim _texto As New Infoware.Controles.Base.TextBoxCalculator
          _texto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
          _texto.NumeroDecimales = _param.Decimales
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Fecha
          Dim _texto As New Infoware.Controles.Base.DateTimePickerStd
          _texto.Format = DateTimePickerFormat.Short
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Logico
          Dim _texto As New Infoware.Controles.Base.CheckBoxStd
          _texto.Text = _param.NombreColumna
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Combo
          Dim _texto As New ComboBox

          'Dim _selec As New Infoware.Controles.Base.CheckBoxStd
          '_selec.Text = _param.NombreCampo
          '_selec.Dock = DockStyle.Top
          '_selec.Tag = _texto
          '_selec.Checked = True
          'Me.Panel1.Controls.Add(_selec)
          '_selec.BringToFront()
          'AddHandler _selec.CheckedChanged, AddressOf habilitar

          _texto.DropDownStyle = ComboBoxStyle.DropDownList
          Dim _dssec As DataTable
          _dssec = mReporte.RetornarSubListaDataTable(_param.NombreParametro, Sistema.Usuario.Usuari_Codigo)

          If _dssec Is Nothing Then
            Throw New Exception(String.Format("Error al tratar de llenar lista {0}", _param.NombreColumna))
          End If
          _texto.DisplayMember = _dssec.Columns(1).ColumnName
          _texto.ValueMember = _dssec.Columns(0).ColumnName
          _texto.DataSource = _dssec

          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.ComboActualizable
          Dim _texto As New ComboBox

          _texto.DropDownStyle = ComboBoxStyle.DropDownList
          Dim _dssec As DataTable
          _dssec = mReporte.RetornarSubListaDataTable(_param.NombreParametro, Sistema.Usuario.Usuari_Codigo)

          _texto.DisplayMember = _dssec.Columns(1).ColumnName
          _texto.ValueMember = _dssec.Columns(0).ColumnName
          _texto.DataSource = _dssec

          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.Panel1.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
      End Select
    Next

    Me.Panel1.Visible = Not esSinFiltros
    mManInsert = mReporte.RetornarManInsert
    mManUpdate = mReporte.RetornarManUpdate
    mManDelete = mReporte.RetornarManDelete
    mAutoejecutable = mReporte.RetornarAutoejecutable

    Me.AutoMail = mReporte.RetornarEmailAutomatico(Restriccion.Usuari_Codigo)
    If Me.AutoMail Then
      Me.AutoMailAsunto = mReporte.RetornarEmailAsunto
      Me.AutoMailArchivo = mReporte.RetornarEmailArchivo
      Me.btnconfemail.Visible = True
      Me.AutoMailLista = mReporte.RetornarEmailLista
      mProgramacion = mReporte.RetornarEmailProgramacion
      If Not EnviarMailAutomaticoyCerrar Then 'para no activar el automail automatico
        Me.ProximoAutoMail = mProgramacion.ProximoEnvio(0)
      End If
    End If

    Me.Panel2.Visible = False
    Me.Panel2.Controls.Clear()
    'If PuedeAgregar OrElse PuedeEliminar Then
    '  'agregar boton
    '  Dim _panel As New Panel
    '  _panel.Dock = DockStyle.Top
    '  _panel.Height = 10
    '  Me.Panel1.Controls.Add(_panel)
    '  _panel.BringToFront()

    '  Me.Panel2.Visible = True

    'End If

    If PuedeAgregar Then
      Me.Panel2.Visible = True

      Dim _boton As New LinkLabel
      _boton.Dock = DockStyle.Left
      '_boton.Padding = New Padding(0, 100, 0, 0)
      _boton.Text = "Agregar un nuevo registro"
      '_boton.Tag = _param
      _boton.AutoSize = True
      Me.Panel2.Controls.Add(_boton)
      _boton.BringToFront()
      '_boton.Visible = Not _param.Oculto
      AddHandler _boton.LinkClicked, AddressOf Abrir_Mantenimiento

      Dim _panel As New Panel
      _panel.Dock = DockStyle.Left
      _panel.Width = 10
      _panel.Height = 10
      Me.Panel2.Controls.Add(_panel)
      _panel.BringToFront()
    End If

    If PuedeEliminar Then
      Me.Panel2.Visible = True

      'Dim _panel As New Panel
      '_panel.Dock = DockStyle.Top
      '_panel.Height = 10
      'Me.Panel1.Controls.Add(_panel)
      '_panel.BringToFront()

      Dim _boton As New LinkLabel
      _boton.Dock = DockStyle.Left
      '_boton.Padding = New Padding(0, 100, 0, 0)
      _boton.Text = "Eliminar el registro actual"
      '_boton.Tag = _param
      _boton.AutoSize = True
      Me.Panel2.Controls.Add(_boton)
      _boton.BringToFront()
      '_boton.Visible = Not _param.Oculto
      AddHandler _boton.LinkClicked, AddressOf Eliminar
    End If

    Actualizar_combos(Me, Nothing)
  End Sub

  Private Sub Llenar_Defaults()
    For Each _control As Control In Me.Panel1.Controls
      If TypeOf _control.Tag Is ParametroReporte Then
        Dim _param As ParametroReporte
        _param = _control.Tag
        Dim mvalor As Object = mReporte.RetornarValorDefault(_param.NombreParametro)

        If mvalor IsNot Nothing Then
          If TypeOf _control Is ComboBox Then
            CType(_control, ComboBox).SelectedValue = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
            CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
            CType(_control, Infoware.Controles.Base.TextBoxStd).Text = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
            CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
            CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked = mvalor
          End If
        End If
      End If
    Next
  End Sub

  Private Sub Abrir_Mantenimiento(ByVal sender As Object, ByVal e As EventArgs)
    Abrir_Mant(Nothing)
  End Sub

  Private Sub Eliminar(ByVal sender As Object, ByVal e As EventArgs)
    If Fila Is Nothing OrElse MsgBox("Está seguro que desea eliminar este registro", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Dim _reporte As New Reporte(mReporte.OperadorDatos, mManDelete)
    _reporte.RetornarRegistroxDataRow(Fila)
    If Not _reporte.Eliminar() Then
      MsgBox(String.Format("Error al eliminar. {0}", _reporte.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
    End If
    Ejecutar()
  End Sub

  'Private Function CrearReporteEliminar() As Reporte
  '  Dim _reporte As New Reporte(mReporte.OperadorDatos, mManDelete)
  '  For Each _control As Control In Me.Panel1.Controls
  '    If Not TypeOf _control Is Label AndAlso Not TypeOf _control Is Button AndAlso Not TypeOf _control Is Panel Then
  '      If Not TypeOf _control.Tag Is ComboBox Then
  '        Dim _param As ParametroReporte = _control.Tag

  '        For Each _paramrep As ParametroReporte In _reporte.Parametros
  '          If _paramrep.NombreColumna.Trim.ToUpper = _param.NombreColumna.Trim.ToUpper Then
  '            If Not _param.Oculto Then
  '              If TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
  '                _paramrep.Valor = _control.Text
  '              End If
  '              If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
  '                _paramrep.Valor = CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value
  '              End If
  '              If TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
  '                _paramrep.Valor = CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value.Date
  '              End If
  '              If TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
  '                _paramrep.Valor = CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked
  '              End If
  '              If TypeOf _control Is ComboBox Then
  '                _paramrep.Valor = IIf(CType(_control, ComboBox).Enabled, CType(_control, ComboBox).SelectedValue, Nothing)
  '              End If
  '            End If
  '          End If
  '        Next
  '      End If
  '    End If
  '  Next
  '  Return _reporte
  'End Function

  Public Sub Abrir_Mant(ByVal _Elemento As DataRowView)
    If mReporte Is Nothing Then
      Exit Sub
    End If
    Actualizar_valores()

    Dim _reporte As Reporte
    _reporte = New Reporte(mReporte.OperadorDatos, IIf(_Elemento Is Nothing, mManInsert, mManUpdate))
    _reporte.RetornarRegistroxDataRow(_Elemento)
    _reporte.ValidarReporte(Sistema.Usuario.Usuari_Codigo)

    Dim f As New FrmMantenimiento()
    f.Sistema = Sistema
    f.Restriccion = Restriccion
    f.PuedeGuardaryNuevo = PuedeAgregar
    f.Reporte = _reporte
    'f.Elemento(mReporte) = _Elemento
    f.ShowDialog()

    If f.Volver Then
      Abrir_Mant(Nothing)
    Else
      Ejecutar()
    End If
  End Sub

  Private Sub Actualizar_combos(ByVal sender As Object, ByVal e As EventArgs)
    For Each _param As ParametroReporte In mReporte.Parametros
      If _param.TipoDatoNet = ParametroReporte.EnumTipoDato.ComboActualizable Then
        For Each _control As Control In Me.Panel1.Controls
          If _param Is _control.Tag Then
            Dim valor As Object = IIf(CType(_control, ComboBox).Enabled, CType(_control, ComboBox).SelectedValue, Nothing)

            Actualizar_valores()
            Dim _dssec As DataTable
            _dssec = mReporte.RetornarSubListaDataTableconParametros(_param.NombreParametro)

            Dim cbo As ComboBox = CType(_control, ComboBox)
            cbo.DisplayMember = _dssec.Columns(1).ColumnName
            cbo.ValueMember = _dssec.Columns(0).ColumnName
            cbo.DataSource = _dssec
            Try
              cbo.SelectedValue = valor
              If cbo.SelectedIndex = -1 Then
                cbo.SelectedIndex = 0
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      End If
    Next
  End Sub

  Private Sub PonerValores()
    Try
      For t As Integer = 0 To mValores.Length - 1
        'If mReporte.Parametros(t).Oculto Then
        mReporte.Parametros(t).Valor = mValores(t)
        'End If
        For Each _control As Control In Me.Panel1.Controls
          If mReporte.Parametros(t) Is _control.Tag Then
            If TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
              If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
                CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value = mValores(t)
              Else
                _control.Text = mValores(t)
              End If
            End If
            If TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
              CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value = CDate(mValores(t))
            End If
            If TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
              CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked = mValores(t)
            End If
            If TypeOf _control Is ComboBox Then
              Actualizar_combos(Me, Nothing)
              CType(_control, ComboBox).SelectedValue = mValores(t)
            End If
          End If
        Next
      Next

      Actualizar_combos(Me, Nothing)
      btnejecutar_Click(Me, Nothing)
    Catch ex As Exception
    End Try
  End Sub

  'Sub habilitar(ByVal sender As Object, ByVal e As EventArgs)
  '  If TypeOf sender Is CheckBox Then
  '    Dim _check As CheckBox
  '    _check = CType(sender, CheckBox)
  '    CType(_check.Tag, ComboBox).Enabled = _check.Checked
  '  End If
  'End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Integer)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub
#End Region

  Private Sub Actualizar_valores()
    For Each _control As Control In Me.Panel1.Controls
      If Not TypeOf _control Is Label AndAlso Not TypeOf _control Is Button AndAlso Not TypeOf _control Is Panel Then
        If Not TypeOf _control.Tag Is ComboBox Then
          Dim _param As ParametroReporte = _control.Tag
          If Not _param.Oculto Then
            If TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
              _param.Valor = _control.Text
            End If
            If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
              _param.Valor = CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value
            End If
            If TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
              _param.Valor = CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value.Date
            End If
            If TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
              _param.Valor = CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked
            End If
            If TypeOf _control Is ComboBox Then
              _param.Valor = IIf(CType(_control, ComboBox).Enabled, CType(_control, ComboBox).SelectedValue, Nothing)
            End If
          End If
        End If
      End If
    Next
  End Sub

  Private Sub btnejecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnejecutar.Click
    Ejecutar()
  End Sub

  Public Sub Ejecutar()
    If mReporte Is Nothing Then
      Exit Sub
    End If
    Actualizar_valores()

    Dim _StructExcelList As New StructExcelList
    Me.TabControl1.Tag = _StructExcelList

    Dim _dssubtotales As New DataTable
    _dssubtotales = mReporte.RetornarInfoExcelSubtotales

    Dim _dspivot As New DataTable
    _dspivot = mReporte.RetornarInfoExcelTablaDinamica

    Dim _dstotalizar As New DataTable
    _dstotalizar = mReporte.RetornarInfoExcelTotalizar

    Dim _dsgraficar As New DataTable
    _dsgraficar = mReporte.RetornarInfoExcelGraficar

    Dim _dsnombrehojas As New DataTable
    _dsnombrehojas = mReporte.RetornarInfoNombreHojas

    mManInsert = mReporte.RetornarManInsert
    mManUpdate = mReporte.RetornarManUpdate
    mManDelete = mReporte.RetornarManDelete

    If _dssubtotales IsNot Nothing AndAlso _dssubtotales.Rows.Count > 0 Then
      For Each _row As DataRow In _dssubtotales.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        Dim _structsubtotal As StructSubtotales
        _structsubtotal.CampoAgrupado = _row(1)
        Select Case CStr(_row(2)).ToUpper.Trim
          Case "SUMA"
            _structsubtotal.Funcion = EnumFuncion.Suma
          Case "PROMEDIO"
            _structsubtotal.Funcion = EnumFuncion.Promedio
          Case "CUENTA"
            _structsubtotal.Funcion = EnumFuncion.Cuenta
          Case "MAXIMO"
            _structsubtotal.Funcion = EnumFuncion.Maximo
          Case "MINIMO"
            _structsubtotal.Funcion = EnumFuncion.Minimo
        End Select
        Dim _resultado As New List(Of Integer)
        For t As Integer = 3 To _dssubtotales.Columns.Count - 1
          _resultado.Add(CInt(_row(t)))
        Next
        _structsubtotal.CamposResultado = _resultado
        _struct.Subtotales.Add(_structsubtotal)
      Next
    End If

    If _dspivot IsNot Nothing AndAlso _dspivot.Rows.Count > 0 Then
      For Each _row As DataRow In _dspivot.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        Dim _structTablasDinamicas As New StructTablaDinamica
        _structTablasDinamicas.Pivots = New List(Of String)
        _structTablasDinamicas.PivotsColumns = New List(Of String)
        _structTablasDinamicas.PivotsPage = New List(Of String)
        _structTablasDinamicas.Campos = New List(Of StructCampoTablaDinamica)

        For t As Integer = 1 To _dspivot.Columns.Count - 1 Step 3
          If CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOT" Or CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOTROW" Then
            _structTablasDinamicas.Pivots.Add(CStr(_dspivot.Rows(0)(t + 1)).Trim)
          ElseIf CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOTCOLUMN" Then
            _structTablasDinamicas.PivotsColumns.Add(CStr(_dspivot.Rows(0)(t + 1)).Trim)
          ElseIf CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "DATAPIVOTFIELDASCOLUMN" Then
            _structTablasDinamicas.DataPivotFieldasColumn = True
          ElseIf CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOTPAGE" Then
            _structTablasDinamicas.PivotsPage.Add(CStr(_dspivot.Rows(0)(t + 1)).Trim)
          Else
            Dim _structcampotabladinamica As New StructCampoTablaDinamica
            _structcampotabladinamica.Campo = CStr(_dspivot.Rows(0)(t + 1)).Trim
            _structcampotabladinamica.Formato = CStr(_dspivot.Rows(0)(t + 2)).Trim
            Select Case CStr(_dspivot.Rows(0)(t)).Trim.ToUpper
              Case "SUMA"
                _structcampotabladinamica.Funcion = EnumFuncion.Suma
              Case "CUENTA"
                _structcampotabladinamica.Funcion = EnumFuncion.Cuenta
              Case "PROMEDIO"
                _structcampotabladinamica.Funcion = EnumFuncion.Promedio
              Case "MAXIMO"
                _structcampotabladinamica.Funcion = EnumFuncion.Maximo
              Case "MINIMO"
                _structcampotabladinamica.Funcion = EnumFuncion.Minimo
            End Select
            _structTablasDinamicas.Campos.Add(_structcampotabladinamica)
          End If
        Next

        _struct.TablaDinamica = _structTablasDinamicas
      Next
    End If

    If _dstotalizar IsNot Nothing AndAlso _dstotalizar.Rows.Count > 0 Then
      For Each _row As DataRow In _dstotalizar.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))
        For Each campo As String In CStr(_row(1)).Split(">")
          Dim _structtotalizar As New StructTotalizar
          Dim operador As String = campo.Substring(0, campo.IndexOf("|"))
          Dim numcampo As Integer = CInt(campo.Substring(campo.IndexOf("|") + 1))
          Select Case operador
            Case "SUMA"
              _structtotalizar.Funcion = EnumFuncion.Suma
            Case "PROMEDIO"
              _structtotalizar.Funcion = EnumFuncion.Promedio
            Case "CUENTA"
              _structtotalizar.Funcion = EnumFuncion.Cuenta
            Case "MAXIMO"
              _structtotalizar.Funcion = EnumFuncion.Maximo
            Case "MINIMO"
              _structtotalizar.Funcion = EnumFuncion.Minimo
          End Select
          _structtotalizar.Campo = numcampo
          _struct.Totalizar.Add(_structtotalizar)
        Next
      Next
    End If

    If _dsgraficar IsNot Nothing AndAlso _dsgraficar.Rows.Count > 0 Then
      For Each _row As DataRow In _dsgraficar.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        Dim _structgraficar As New StructGraficar
        _structgraficar.TipoGrafico = CInt(_row(1))
        _structgraficar.Orientacion = CInt(_row(2))
        _structgraficar.RelacionAncho = CDec(_row(3))
                _structgraficar.RelacionAlto = CDec(_row(4))
                _structgraficar.Titulo = CStr(_row(5))
                _struct.Graficar = _structgraficar
      Next
    End If

    If _dsnombrehojas IsNot Nothing AndAlso _dsnombrehojas.Rows.Count > 0 Then
      For Each _row As DataRow In _dsnombrehojas.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        _struct.NombreHoja = CStr(_row(1))
      Next
    End If

    Dim _DataSet As New DataSet
    _DataSet = mReporte.RetornarDataSet

    If _DataSet Is Nothing Then
      MsgBox(String.Format("Error al ejecutar consulta. {0}", mReporte.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
    End If

    Dim estilonum0 As New DataGridViewCellStyle()
    estilonum0.Format = "N0"
    estilonum0.Alignment = DataGridViewContentAlignment.MiddleRight

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"
    estilonum2.Alignment = DataGridViewContentAlignment.MiddleRight

    Me.TabControl1.TabPages.Clear()
    Dim count As Integer = 0
    For Each _table As DataTable In _DataSet.Tables
      'If count > 0 AndAlso (_table.Columns.Count = 2 OrElse _table.Columns.Count = 4) AndAlso count = _DataSet.Tables.Count - 1 Then
      '  Try
      '    For _countrow As Integer = 0 To _table.Rows.Count - 1
      '      Me.TabControl1.TabPages(_countrow).Text = _table.Rows(_countrow)(1)
      '      If _table.Columns.Count = 4 Then
      '        Dim _datosgraficos As New List(Of Integer)
      '        _datosgraficos.Add(_table.Rows(_countrow)(2))
      '        _datosgraficos.Add(_table.Rows(_countrow)(3))
      '        Me.TabControl1.TabPages(_countrow).Tag = _datosgraficos
      '      End If
      '    Next
      '  Catch ex As Exception
      '  End Try
      'Else
      count += 1
      Dim _tabpage As New TabPage
      Dim _dg As New DataGridView
      _dg.ReadOnly = True
      _dg.AllowUserToDeleteRows = False
      _dg.AllowUserToOrderColumns = False
      _dg.AllowUserToAddRows = False
      _dg.AllowUserToResizeRows = False
      AddHandler _dg.DoubleClick, AddressOf DataGridView1_DoubleClick
      AddHandler _dg.KeyDown, AddressOf DataGridView1_KeyDown

      _tabpage.Controls.Add(_dg)
      _dg.Dock = DockStyle.Fill
      Dim _bs As New BindingSource
      _dg.DataSource = _bs

      _dg.AutoGenerateColumns = True
      _bs.DataSource = _table.GetType
      _bs.DataSource = _table

      If String.IsNullOrEmpty(_StructExcelList.Devolver(count).NombreHoja) Then
        _tabpage.Text = "Resultado " & count.ToString.Trim
      Else
        _tabpage.Text = _StructExcelList.Devolver(count).NombreHoja
      End If

      For Each _col As DataGridViewColumn In _dg.Columns
        If _col.ValueType Is GetType(Decimal) Then
          If _col.HeaderText.ToUpper.Contains("__F") Then
            Dim estilonumN As New DataGridViewCellStyle()
            estilonumN.Format = _col.HeaderText.Substring(_col.HeaderText.ToUpper.IndexOf("__F") + 3)
            estilonumN.Alignment = DataGridViewContentAlignment.MiddleRight
            _col.DefaultCellStyle = estilonumN
            _col.HeaderText = _col.HeaderText.Substring(0, _col.HeaderText.ToUpper.IndexOf("__F"))
          Else
            _col.DefaultCellStyle = estilonum2
          End If
        End If
        If _col.ValueType Is GetType(Integer) Then
          _col.DefaultCellStyle = estilonum0
        End If
        _col.HeaderText = _col.HeaderText.Replace("_", " ")
      Next

      Me.TabControl1.TabPages.Add(_tabpage)

      If _table IsNot Nothing Then
        '_bs.DataMember = _table.TableName
        Me.lblmensaje.Text = String.Format("{0} registros seleccionados", _bs.Count)
      Else
        Me.lblmensaje.Text = "No existen registros en la vista actual"
      End If
      _dg.AutoResizeColumns()
      'End If
    Next
    ReiniciarProgressBar()
  End Sub

  Public Delegate Sub AbrirElemento(ByVal _fila As DataRowView)

  Private mobjAbrirElemento As AbrirElemento
  Public Property objAbrirElemento() As AbrirElemento
    Get
      Return mobjAbrirElemento
    End Get
    Set(ByVal value As AbrirElemento)
      mobjAbrirElemento = value
    End Set
  End Property

  Private Sub FrmLista_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    If Fila Is Nothing Then
      Exit Sub
    End If
    If PuedeModificar Then
      Abrir_Mant(Fila)
    End If
    If objAbrirElemento IsNot Nothing Then
      objAbrirElemento.Invoke(Fila)
    End If
  End Sub

  Public ReadOnly Property Fila() As DataRowView
    Get
      If Me.TabControl1.SelectedTab Is Nothing Then
        Return Nothing
      Else
        Return CType(Me.TabControl1.SelectedTab.Controls(0), DataGridView).DataSource.Current
      End If
    End Get
  End Property

  Private Sub FrmLista_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    Ejecutar()
  End Sub

  Private Sub tmrdatos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrdatos.Tick
    If mCargarFiltrosDefaults Then
      Llenar_Filtros()
      Llenar_Defaults()
      mCargarFiltrosDefaults = False
    End If
    If mValores IsNot Nothing Then
      PonerValores()
    End If
    If PuedeAutoejecutar Then
      Ejecutar()
    End If
    If EnviarMailAutomaticoyCerrar Then
      Me.AutoMailAsunto = mReporte.RetornarEmailAsunto
      Me.AutoMailArchivo = mReporte.RetornarEmailArchivo
      Me.AutoMailLista = mReporte.RetornarEmailLista

      Me.EnviarAutoMail(mOriginalMessage)
      Me.Close()
    End If
    Me.tmrdatos.Enabled = False
  End Sub

  Private Sub btnconfemail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfemail.Click
    Dim f As New FrmProgramacionEnvioMail With {
      .Sistema = Sistema,
      .Restriccion = Restriccion,
      .Reporte = mReporte
    }
    f.ShowDialog()
    EstablecerProximoAutoMail()
  End Sub

  Private Sub FrmLista_EnviandoAutoMail(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnviandoAutoMail
    EstablecerProximoAutoMail()
  End Sub

  Sub EstablecerProximoAutoMail()
    mProgramacion = mReporte.RetornarEmailProgramacion
    Me.ProximoAutoMail = mProgramacion.ProximoEnvio(3)
  End Sub
End Class
