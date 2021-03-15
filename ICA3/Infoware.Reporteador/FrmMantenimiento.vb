Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System.Windows.Forms

Public Class FrmMantenimiento
  'Private mElemento As DataRowView
  'Public Property Elemento(Optional ByVal _reporte As Reporte = Nothing) As DataRowView
  '  Get
  '    Return mElemento
  '  End Get
  '  Set(ByVal value As DataRowView)
  '    mElemento = value
  '    If value Is Nothing Then
  '      mEsNuevo = True
  '      Llenar_Defaults(_reporte)
  '    Else
  '      mEsNuevo = False
  '      'Llenar_Valores()
  '      tmrdatos.Enabled = True
  '    End If
  '  End Set
  'End Property

  Private mVolver As Boolean = False
  Public Property Volver() As Boolean
    Get
      Return mVolver
    End Get
    Set(ByVal value As Boolean)
      mVolver = value
    End Set
  End Property

#Region "IOpcion"
  Private mReporte As Reporte = Nothing
  Public WriteOnly Property Reporte() As Reporte
    Set(ByVal value As Reporte)
      mReporte = value
      If value IsNot Nothing Then
        Llenar_Filtros()
        tmrdatos.Enabled = True
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
      If value IsNot Nothing Then
        tmrdatos.Enabled = True
      End If
    End Set
  End Property
#End Region

#Region "Llenardatos"
  Sub Llenar_Filtros()
    Me.Tabla = mReporte.NombreReporte
    'Me.DocSalida = mReporte.RetornarDocSalida
    Application.DoEvents()

    Me.TableLayoutPanel1.RowStyles.Clear()
    Dim num As Integer = 0
    For Each _param As ParametroReporte In mReporte.Parametros
      num += 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))

      If Not _param.Oculto Then
        Select Case _param.TipoDatoNet
          Case ParametroReporte.EnumTipoDato.Logico ', ParametroReporte.EnumTipoDato.Combo
          Case Else
            Dim _etiqueta As New Label()
            _etiqueta.Text = _param.NombreColumna
            _etiqueta.Dock = DockStyle.Top
            Me.TableLayoutPanel1.Controls.Add(_etiqueta, 0, num - 1)
            _etiqueta.BringToFront()
        End Select
      End If

      Select Case _param.TipoDatoNet
        Case ParametroReporte.EnumTipoDato.Texto
          Dim _texto As New Infoware.Controles.Base.TextBoxStd
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          _texto.ReadOnly = _param.SoloLectura
          _texto.Text = _param.Valor
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Entero
          Dim _texto As New Infoware.Controles.Base.TextBoxCalculator
          _texto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          _texto.ReadOnly = _param.SoloLectura
          _texto.Value = _param.Valor
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Decimales
          Dim _texto As New Infoware.Controles.Base.TextBoxCalculator
          _texto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
          _texto.NumeroDecimales = _param.Decimales
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          _texto.ReadOnly = _param.SoloLectura
          _texto.Value = _param.Valor
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Fecha
          Dim _texto As New Infoware.Controles.Base.DateTimePickerStd
          _texto.Format = DateTimePickerFormat.Short
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          _texto.Enabled = Not _param.SoloLectura
          Try
            _texto.Value = _param.Valor
          Catch ex As Exception
          End Try
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Logico
          Dim _texto As New Infoware.Controles.Base.CheckBoxStd
          _texto.Text = _param.NombreColumna
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          _texto.Enabled = Not _param.SoloLectura
          _texto.Checked = _param.Valor
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
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          Application.DoEvents()
          _texto.SelectedValue = _param.Valor
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
          If _param.Oculto Then
            Me.Panel1.Controls.Add(_texto)
          Else
            Me.TableLayoutPanel1.Controls.Add(_texto, 1, num - 1)
          End If
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          _texto.SelectedValue = _param.Valor
          AddHandler _texto.Validated, AddressOf Actualizar_combos
      End Select
    Next

    'mManInsert = mReporte.RetornarManInsert
    'mManUpdate = mReporte.RetornarManUpdate

    'If PuedeAgregar Then
    '  'agregar boton
    '  Dim _panel As New Panel
    '  _panel.Dock = DockStyle.Top
    '  _panel.Width = 15
    '  Me.Panel1.Controls.Add(_panel)
    '  _panel.BringToFront()

    '  Dim _boton As New Button
    '  _boton.Dock = DockStyle.Top
    '  '_boton.Padding = New Padding(0, 100, 0, 0)
    '  _boton.Text = "Agregar"
    '  '_boton.Tag = _param
    '  Me.Panel1.Controls.Add(_boton)
    '  _boton.BringToFront()
    '  '_boton.Visible = Not _param.Oculto
    '  AddHandler _boton.Click, AddressOf Abrir_Mantenimiento
    'End If

    Actualizar_combos(Me, Nothing)
  End Sub

  Private Sub Llenar_Valores()
    'Application.DoEvents()
    'mReporte.RetornarRegistroxDataRow(Elemento)
    For t As Integer = Me.TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
      Dim _control As Control = Me.TableLayoutPanel1.Controls(t)
      If TypeOf _control.Tag Is ParametroReporte Then
        Dim _param As ParametroReporte
        _param = _control.Tag
        Try

          Dim mvalor As Object = _param.Valor

          If mvalor IsNot Nothing Then
            _control.Enabled = Not (_param.Clave And Not mReporte.EsNuevo)

            If TypeOf _control Is ComboBox Then
              If _param.TipoDatoNet = ParametroReporte.EnumTipoDato.ComboActualizable Then
                Actualizar_combos(Me, Nothing)
              End If
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
        Catch ex As Exception

        End Try

      End If
    Next

  End Sub

  Private Sub Llenar_Defaults(ByVal _reporte As Reporte)
    For t As Integer = Me.TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
      Dim _control As Control = Me.TableLayoutPanel1.Controls(t)
      If TypeOf _control.Tag Is ParametroReporte Then
        Dim _param As ParametroReporte
        _param = _control.Tag
        Dim mvalor As Object
        mvalor = mReporte.RetornarValorDefault(_param.NombreParametro)

        If _reporte IsNot Nothing Then
          For Each _paramrep As ParametroReporte In _reporte.Parametros
            If _param.NombreColumna.Trim.ToUpper = _paramrep.NombreColumna.Trim.ToUpper Then
              If _paramrep.Valor IsNot Nothing Then
                mvalor = _paramrep.Valor
              End If
            End If
          Next
        End If

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
        For t As Integer = Me.TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
          Dim _control As Control = Me.TableLayoutPanel1.Controls(t)
          If _param Is _control.Tag Then
            Dim valor As Object = CType(_control, ComboBox).SelectedValue

            Actualizar_valoresAux()
            Dim _dssec As DataTable
            _dssec = mReporte.RetornarSubListaDataTableconParametrosAux(_param.NombreParametro)

            Dim cbo As ComboBox = CType(_control, ComboBox)
            cbo.DisplayMember = _dssec.Columns(1).ColumnName
            cbo.ValueMember = _dssec.Columns(0).ColumnName
            cbo.DataSource = _dssec
            Try
              cbo.SelectedValue = valor
            Catch ex As Exception
            End Try

            Try
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

  'Private Sub PonerValores()
  '  Try
  '    For h As Integer = 0 To mValores.Length - 1
  '      'If mReporte.Parametros(t).Oculto Then
  '      mReporte.Parametros(h).Valor = mValores(h)
  '      'End If
  '      For t As Integer = Me.TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
  '        Dim _control As Control = Me.TableLayoutPanel1.Controls(t)
  '        If mReporte.Parametros(h) Is _control.Tag Then
  '          If TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
  '            If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
  '              CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value = mValores(h)
  '            Else
  '              _control.Text = mValores(h)
  '            End If
  '          End If
  '          If TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
  '            CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value = mValores(h)
  '          End If
  '          If TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
  '            CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked = mValores(h)
  '          End If
  '          If TypeOf _control Is ComboBox Then
  '            If mReporte.Parametros(h).TipoDatoNet = ParametroReporte.EnumTipoDato.ComboActualizable Then
  '              Actualizar_combos(Me, Nothing)
  '            End If
  '            CType(_control, ComboBox).SelectedValue = mValores(h)
  '          End If
  '        End If
  '      Next
  '    Next

  '    Actualizar_combos(Me, Nothing)
  '    'btnejecutar_Click(Me, Nothing)
  '  Catch ex As Exception
  '  End Try
  'End Sub

  'Sub habilitar(ByVal sender As Object, ByVal e As EventArgs)
  '  If TypeOf sender Is CheckBox Then
  '    Dim _check As CheckBox
  '    _check = CType(sender, CheckBox)
  '    CType(_check.Tag, ComboBox).Enabled = _check.Checked
  '  End If
  'End Sub
#End Region

  Private Sub Actualizar_valores()
    For t As Integer = Me.TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
      Dim _control As Control = Me.TableLayoutPanel1.Controls(t)
      If Not TypeOf _control Is Label AndAlso Not TypeOf _control Is Button AndAlso Not TypeOf _control Is Panel Then
        If Not TypeOf _control.Tag Is ComboBox Then
          Dim _param As ParametroReporte = _control.Tag
          If Not _param.Oculto Then
            If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
              _param.Valor = CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value
            ElseIf TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
              _param.Valor = _control.Text
            ElseIf TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
              _param.Valor = CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value.Date
            ElseIf TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
              _param.Valor = CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked
            ElseIf TypeOf _control Is ComboBox Then
              _param.Valor = CType(_control, ComboBox).SelectedValue
            End If
          End If
        End If
      End If
    Next
  End Sub

  Private Sub Actualizar_valoresAux()
    For t As Integer = Me.TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
      Dim _control As Control = Me.TableLayoutPanel1.Controls(t)
      If Not TypeOf _control Is Label AndAlso Not TypeOf _control Is Button AndAlso Not TypeOf _control Is Panel Then
        If Not TypeOf _control.Tag Is ComboBox Then
          Dim _param As ParametroReporte = _control.Tag
          If Not _param.Oculto Then
            If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
              _param.ValorAux = CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value
            ElseIf TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
              _param.ValorAux = _control.Text
            ElseIf TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
              _param.ValorAux = CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value.Date
            ElseIf TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
              _param.ValorAux = CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked
            ElseIf TypeOf _control Is ComboBox Then
              _param.ValorAux = CType(_control, ComboBox).SelectedValue
            End If
          End If
        End If
      End If
    Next
  End Sub

  'Private Sub btnejecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnejecutar.Click
  '  Ejecutar()
  'End Sub

  Public Function Ejecutar() As Boolean
    If mReporte Is Nothing Then
      Return False
    End If
    Actualizar_valores()

    If Not mReporte.Guardar(mReporte.EsNuevo) Then
      MsgBox(String.Format("Error al guardar el registro. {0}", mReporte.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
      Return False
    Else
      mReporte.EsNuevo = False
      Return True
    End If
  End Function

  Private Sub FrmMantenimiento_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Guardar
    If Ejecutar() Then
      mVolver = False
      Me.Close()
    End If
  End Sub

  Private Sub FrmMantenimiento_GuardaryNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GuardaryNuevo
    If Ejecutar() Then
      mVolver = True
      Me.Close()
    End If
  End Sub

  Private Sub tmrdatos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrdatos.Tick
    'If tmrdatos.Interval = 300 Then
    '  tmrdatos.Interval = 200
    'Else
    '  tmrdatos.Interval = 300
    tmrdatos.Enabled = False
    'End If

    Llenar_Valores()

    Llenar_Valores()
  End Sub

End Class
