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

Public Class FrmListaReporte
  Implements IOpcion

#Region "IOpcion"
  Private mCargarFiltrosDefaults As Boolean = False
  Private mReporte As Reporte = Nothing
  Public Property Reporte() As Reporte
    Get
      Return mReporte
    End Get
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
  Private mProgramacion As Programacion

  Sub Llenar_Filtros()
    Me.Titulo = mReporte.NombreReporte

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
    'If PuedeAgregar OrElse PuedeEliminar Then
    '  'agregar boton
    '  Dim _panel As New Panel
    '  _panel.Dock = DockStyle.Top
    '  _panel.Height = 10
    '  Me.Panel1.Controls.Add(_panel)
    '  _panel.BringToFront()

    '  Me.Panel2.Visible = True

    'End If

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

    If objLlenar_Reporte IsNot Nothing Then
      objLlenar_Reporte.Invoke(Me)
    End If
  End Sub

  Public Delegate Sub Llenar_Reporte(reporte As FrmListaReporte)

  Private mobjLlenar_Reporte As Llenar_Reporte
  Public Property objLlenar_Reporte() As Llenar_Reporte
    Get
      Return mobjLlenar_Reporte
    End Get
    Set(ByVal value As Llenar_Reporte)
      mobjLlenar_Reporte = value
    End Set
  End Property

  Private Sub tmrdatos_Tick(sender As Object, e As EventArgs) Handles tmrdatos.Tick
    If mCargarFiltrosDefaults Then
      Llenar_Filtros()
      Llenar_Defaults()
      mCargarFiltrosDefaults = False
    End If
    If mValores IsNot Nothing Then
      PonerValores()
    End If
    Me.tmrdatos.Enabled = False
  End Sub
End Class
