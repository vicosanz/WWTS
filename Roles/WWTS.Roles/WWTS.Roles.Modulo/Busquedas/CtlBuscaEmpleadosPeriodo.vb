Imports Infoware.Datos
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class CtlBuscaEmpleadosPeriodo
  Private mUsuario As Infoware.Reglas.General.Usuario = Nothing
  Public Property Usuario() As Infoware.Reglas.General.Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Infoware.Reglas.General.Usuario)
      mUsuario = value
    End Set
  End Property

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      If Not value Is Nothing Then
        Me.CtlPatrono1.Op = mOp
        Me.CtlPatrono1.llenar_datos(mUsuario)

        Me.ComboBoxClaseEmpleado.OperadorDatos = mOp
        Me.ComboBoxClaseEmpleado.Parametro = Enumerados.EnumParametros.ClaseEmpleado
        Me.ComboBoxClaseEmpleado.Llenar_Datos()

        Me.CtlSeccion1.OperadorDatos = mOp
        Me.CtlSeccion1.Parametro = Enumerados.EnumParametros.Seccion
        Me.CtlSeccion1.Llenar_Datos()

        Me.CtlTipoContrato1.Op = mOp
        Me.CtlTipoContrato1.Patrono = Me.CtlPatrono1.Patrono
        Me.CtlTipoContrato1.llenar_datos()

        Me.CtlPeriodo1.Op = mOp
        Me.CtlPeriodo1.llenar_datos()
      End If
    End Set
  End Property

  Public Event CambioEmpleado As EventHandler
  Public Event CambioTipoContrato As EventHandler
  Public Event Generar As EventHandler

  Dim cambiarlistcheck As Boolean = False
  Dim cambiarcheck As Boolean = False

  Private mEmpleados As EmpleadoList = Nothing
  Private mContratos As ContratoList = Nothing
  Private mAsistencias As AsistenciaList = Nothing

  Public Enum enumTipoDato
    Empleado
    Contrato
    Asistencia
  End Enum

  Dim mTipoDato As enumTipoDato = enumTipoDato.Contrato

  Public ReadOnly Property Contrato() As Contrato
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Select Case mTipoDato
          Case enumTipoDato.Contrato
            Return ListBindingSource.Current
          Case enumTipoDato.Asistencia
            Return CType(ListBindingSource.Current, Asistencia).Contrato
          Case Else
            Return Nothing
        End Select
      End If
    End Get
  End Property

  Public ReadOnly Property Asistencia() As Asistencia
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Select Case mTipoDato
          Case enumTipoDato.Asistencia
            Return ListBindingSource.Current
          Case Else
            Return Nothing
        End Select
      End If
    End Get
  End Property

  Public ReadOnly Property Empleado() As Empleado
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Select Case mTipoDato
          Case enumTipoDato.Empleado
            Return ListBindingSource.Current
          Case Else
            Return Nothing
        End Select
      End If
    End Get
  End Property

  Public ReadOnly Property SonContratos() As Boolean
    Get
      Return mTipoDato
    End Get
  End Property

  Public ReadOnly Property SonAsistencias() As Boolean
    Get
      Return Not mTipoDato
    End Get
  End Property

  Public ReadOnly Property Periodo() As PeriodoPago
    Get
      Return Me.CtlPeriodo1.PeriodoPago
    End Get
  End Property

  Public ReadOnly Property TipoContrato() As TipoContrato
    Get
      If Me.chksolotipocontrato.Checked Then
        Return Me.CtlTipoContrato1.TipoContrato
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property Seccion() As WWTSParametroDet
    Get
      If Me.rdopersactsec.Checked Then
        Return Me.CtlSeccion1.ParametroDet
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property Patrono() As Patrono
    Get
      Return Me.CtlPatrono1.Patrono
    End Get
  End Property

  Public ReadOnly Property AsistenciasSeleccionadas() As AsistenciaList
    Get
      Dim Asistencias As New AsistenciaList
      Select Case mTipoDato
        Case enumTipoDato.Asistencia
          asistencias = mAsistencias.ListaSeleccionadas
        Case enumTipoDato.Contrato
          For Each _contrato As Contrato In mContratos.ListaSeleccionadas
            Dim _asis As Asistencia
            _asis = New Asistencia(Op, _contrato, Me.CtlPeriodo1.PeriodoPago)
            _asis.Tipocontrato = Me.CtlTipoContrato1.TipoContrato
            Asistencias.Add(_asis)
          Next
        Case enumTipoDato.Empleado
          For Each _empleado As Empleado In mEmpleados.ListaSeleccionadas
            Dim _asis As Asistencia
            _asis = New Asistencia(Op, _empleado, Me.CtlPatrono1.Patrono, Me.CtlPeriodo1.PeriodoPago)
            _asis.Tipocontrato = Me.CtlTipoContrato1.TipoContrato
            Asistencias.Add(_asis)
          Next
      End Select
      Return Asistencias
    End Get
  End Property

  Public ReadOnly Property ContratosSeleccionados() As ContratoList
    Get
      Return mContratos.ListaSeleccionadas
    End Get
  End Property

  Private mesLlenandoLista As Boolean = False

  Public Sub llenar_datos()
    Me.chktodos.Checked = False
    mesLlenandoLista = True

    Retornar_Empleados()
    Select Case mTipoDato
      Case enumTipoDato.Empleado
        If mEmpleados IsNot Nothing Then
          Me.lblstatus.Text = mEmpleados.Count.ToString.Trim & " Empleados encontradas"
        End If

        Me.tvEmpleados.Columns.Clear()

        Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
        DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        DataGridViewTextBoxColumn0.DataPropertyName = "Seleccionado"
        DataGridViewTextBoxColumn0.HeaderText = ""
        DataGridViewTextBoxColumn0.Width = 20
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
        DataGridViewTextBoxColumn1.HeaderText = "Nombre del empleado"
        DataGridViewTextBoxColumn1.Width = 250
        DataGridViewTextBoxColumn1.ReadOnly = True
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
        DataGridViewTextBoxColumn1.HeaderText = "Código"
        DataGridViewTextBoxColumn1.Width = 80
        DataGridViewTextBoxColumn1.ReadOnly = True
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        'Me.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Empleado)
        Dim mitemssort As New Infoware.Reglas.SortedView(mEmpleados)
        ListBindingSource.DataSource = mitemssort
        CambiarEmpleado(True)
      Case enumTipoDato.Contrato
        If mContratos IsNot Nothing Then
          Me.lblstatus.Text = mContratos.Count.ToString.Trim & " Empleados encontradas"
        End If

        Me.tvEmpleados.Columns.Clear()

        Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
        DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        DataGridViewTextBoxColumn0.DataPropertyName = "Seleccionado"
        DataGridViewTextBoxColumn0.HeaderText = ""
        DataGridViewTextBoxColumn0.Width = 20
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "EmpleadoString"
        DataGridViewTextBoxColumn1.HeaderText = "Nombre del empleado"
        DataGridViewTextBoxColumn1.Width = 250
        DataGridViewTextBoxColumn1.ReadOnly = True
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado"
        DataGridViewTextBoxColumn1.HeaderText = "Código"
        DataGridViewTextBoxColumn1.Width = 80
        DataGridViewTextBoxColumn1.ReadOnly = True
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        'Me.ListBindingSource.DataSource = GetType(WWTS.General.Reglas.Contrato)
        Dim mitemssort As New Infoware.Reglas.SortedView(mContratos)
        ListBindingSource.DataSource = mitemssort
        CambiarEmpleado(True)
      Case enumTipoDato.Asistencia
        If mAsistencias IsNot Nothing Then
          Me.lblstatus.Text = mAsistencias.Count.ToString.Trim & " Empleados encontradas"
        End If

        Me.tvEmpleados.Columns.Clear()

        Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
        DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        DataGridViewTextBoxColumn0.DataPropertyName = "Seleccionado"
        DataGridViewTextBoxColumn0.HeaderText = ""
        DataGridViewTextBoxColumn0.Width = 20
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "EmpleadoString"
        DataGridViewTextBoxColumn1.HeaderText = "Nombre del empleado"
        DataGridViewTextBoxColumn1.Width = 250
        DataGridViewTextBoxColumn1.ReadOnly = True
        Me.tvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        Me.ListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.Asistencia)
        Dim mitemssort As New Infoware.Reglas.SortedView(mAsistencias)
        ListBindingSource.DataSource = mitemssort
        CambiarEmpleado(True)
    End Select
    mesLlenandoLista = False
  End Sub

  Public Sub Retornar_Empleados()
    Dim cls_codigo As Integer = 0
    If Me.chksoloclase.Checked Then
      cls_codigo = Me.ComboBoxClaseEmpleado.ParametroDet.Pardet_Secuencia
    End If

    If Me.chksolograbados.Checked Then
      mTipoDato = enumTipoDato.Asistencia
      mAsistencias = AsistenciaList.RetornarAsistenciasPeriodo(Op, Me.CtlPatrono1.Patrono, IIf(Me.chksolotipocontrato.Checked, Me.CtlTipoContrato1.TipoContrato, Nothing), Me.CtlPeriodo1.PeriodoPago, Me.chknograbados.Checked)
      'Me.lblstatus.Text = "."
      'If Not asistencias Is Nothing Then
      '  Me.lblstatus.Text = asistencias.Count.ToString.Trim & " Empleados encontrados"
      '  For t As Integer = 0 To asistencias.Count - 1
      '    Dim nodeEmpleado As New TreeNode
      '    nodeEmpleado.Text = "(" & asistencias(t).Entida_Codigo & ") " & asistencias(t).Empleado.NombreCompleto
      '    nodeEmpleado.Tag = asistencias(t)
      '    tvEmpleados.Nodes.Add(nodeEmpleado)
      '  Next
      'End If
    Else
      If Not Me.chksolotipocontrato.Checked OrElse (Me.chksolotipocontrato.Checked AndAlso Not Me.CtlTipoContrato1.TipoContrato.Pardet_TipoContrato = Enumerados.enumTipoContrato.Destajo) Then
        Dim Patron_codigo As Integer = 0
        If Not Me.CtlPatrono1.Patrono Is Nothing Then
          Patron_codigo = Me.CtlPatrono1.Patrono.Patron_Codigo
        End If
        Dim seccio_codigo As Integer = 0
        If rdopersactsec.Checked Then
          seccio_codigo = Me.CtlSeccion1.ParametroDet.Pardet_Secuencia
        End If
        Dim TipCon_codigo As Integer = 0
        If Me.chksolotipocontrato.Checked Then
          TipCon_codigo = Me.CtlTipoContrato1.TipoContrato.TipCon_Codigo
        End If

        Dim fecdesde As Date
        fecdesde = Me.dtfecdesde.Value

        Dim fechasta As Date
        fechasta = Me.dtfechasta.Value

        mTipoDato = enumTipoDato.Contrato

        mContratos = ContratoList.RetornarPersonalActivoPeriodo(Op, Me.CtlPeriodo1.PeriodoPago.PerPag_FechaDesde, Me.CtlPeriodo1.PeriodoPago.PerPag_FechaHasta, Patron_codigo, IIf(rdopersactsec.Checked, 1, IIf(rdopersactfecing.Checked, 2, 3)), seccio_codigo, fecdesde, fechasta, cls_codigo, TipCon_codigo, Me.chkpersentreedad.Checked, Me.txtedadi.Text, Me.txtedadf.Text, Me.chknograbados.Checked, Me.CtlPeriodo1.PeriodoPago.PardetPeriodoPago)

        'Me.lblstatus.Text = "."
        'If Not contratos Is Nothing Then
        '  Me.lblstatus.Text = contratos.Count.ToString.Trim & " Empleados encontrados"
        '  For t As Integer = 0 To contratos.Count - 1
        '    Dim nodeEmpleado As New TreeNode
        '    nodeEmpleado.Text = "(" & contratos(t).Entida_Codigo & ") " & contratos(t).Empleado.NombreCompleto
        '    nodeEmpleado.Tag = contratos(t)
        '    tvEmpleados.Nodes.Add(nodeEmpleado)
        '  Next
        'End If
      Else
        mTipoDato = enumTipoDato.Empleado

        mEmpleados = EmpleadoList.RetornarPersonasSinContrato(Op, Me.CtlPeriodo1.PeriodoPago, cls_codigo, Me.chkpersentreedad.Checked, Me.txtedadi.Text, Me.txtedadf.Text)

        'Me.lblstatus.Text = "."
        'If Not Empleados Is Nothing Then
        '  Me.lblstatus.Text = Empleados.Count.ToString.Trim & " Empleados encontrados"
        '  For t As Integer = 0 To Empleados.Count - 1
        '    Dim nodeEmpleado As New TreeNode
        '    nodeEmpleado.Text = "(" & Empleados(t).Entida_Codigo & ") " & Empleados(t).NombreCompleto
        '    nodeEmpleado.Tag = Empleados(t)
        '    tvEmpleados.Nodes.Add(nodeEmpleado)
        '  Next
        'End If
      End If
      End If
    'Me.tvEmpleados.EndUpdate()
    'Me.tvEmpleados.Visible = True
    'puedecambiarEmpleado = True
    'If tvEmpleados.Nodes.Count > 0 Then
    '  tvEmpleados.SelectedNode = tvEmpleados.Nodes(0)
    'End If

    'RaiseEvent CambioEmpleado(tvEmpleados.SelectedNode, System.EventArgs.Empty)
  End Sub

  Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    Me.llenar_datos()
    'ajustarpnlpersact()
  End Sub

#Region "Acoplar"
  Private Sub rdodescparc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ajustarpnlpersact()
  End Sub

  Sub ajustarpnlpersact()
    Me.pnlfiltrar.Height = pnlfiltrarfin.Location.Y
    If pnlfiltrar.Visible Then
      Me.pnlpersac.Height = pnlfiltrar.Location.Y + pnlfiltrar.Height
    Else
      Me.pnlpersac.Height = Me.CtlPatrono1.Location.Y + Me.CtlPatrono1.Height
    End If

    'If pnlpersentreedad.Visible = True Then
    '  Me.pnlpersac.Height = pnlpersentreedad.Location.Y + pnlpersentreedad.Height
    'Else
    '  Me.pnlpersac.Height = chkpersentreedad.Location.Y + chkpersentreedad.Height
    'End If
  End Sub

  Private Sub rdopersactsec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdopersactsec.CheckedChanged
    ajustarpersact()
  End Sub
  Sub ajustarpersact()
    Me.pnlpersactsec.Visible = Me.rdopersactsec.Checked
    Me.pnlpersactfecing.Visible = Me.rdopersactfecing.Checked
    pnlseccionfecing.Height = Me.pnlseccionfecingfin.Location.Y
    ajustarpnlpersact()
  End Sub

  Private Sub rdopersactfecing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdopersactfecing.CheckedChanged
    ajustarpersact()
  End Sub

  Private Sub chksoloclase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoloclase.CheckedChanged
    Me.pnlsoloclase.Visible = chksoloclase.Checked
    ajustarpnlpersact()
  End Sub

  'Private Sub chksolocontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '    Me.pnlsolocontrato.Visible = chksolocontrato.Checked
  '    ajustarpnlpersact()
  'End Sub

  Private Sub chkpersentreedad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpersentreedad.CheckedChanged
    Me.pnlpersentreedad.Visible = chkpersentreedad.Checked
    ajustarpnlpersact()
  End Sub
#End Region

  Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
    If cambiarlistcheck Then
      Exit Sub
    End If
    cambiarcheck = True
    Select Case mTipoDato
      Case enumTipoDato.Asistencia
        For Each _asis As Asistencia In mAsistencias
          _asis.Seleccionado = chktodos.Checked
        Next
      Case enumTipoDato.Contrato
        For Each _contr As Contrato In mContratos
          _contr.Seleccionado = chktodos.Checked
        Next
      Case enumTipoDato.Empleado
        For Each _empl As Empleado In mEmpleados
          _empl.Seleccionado = chktodos.Checked
        Next
    End Select

    If chktodos.Checked Then
      Me.mnugenerar.Enabled = True
    Else
      Me.mnugenerar.Enabled = False
    End If
    Me.tvEmpleados.Refresh()
    cambiarcheck = False
  End Sub

  Private Sub tvEmpleados_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles tvEmpleados.CellBeginEdit
  End Sub

  Private Sub mnugenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnugenerar.Click
    RaiseEvent Generar(Me.ContratosSeleccionados, System.EventArgs.Empty)
  End Sub

  Private Sub CtlBuscaEmpleadosPeriodo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    rdopersacttodos.Checked = True
    ajustarpnlpersact()
  End Sub

  Private Sub CtlTipoContrato1_CambioTipoContrato() Handles CtlTipoContrato1.CambioTipoContrato
    If Not Me.CtlTipoContrato1.TipoContrato Is Nothing Then
      Me.CtlPeriodo1.PardetPeriodoPago = Me.CtlTipoContrato1.TipoContrato.PardetPeriodoPago
      Me.CtlPeriodo1.llenar_datos()

      Me.pnlseccionfecing.Visible = Not Me.CtlTipoContrato1.TipoContrato.Pardet_TipoContrato = Enumerados.enumTipoContrato.Destajo
      ajustarpnlpersact()
      RaiseEvent CambioTipoContrato(Me, System.EventArgs.Empty)
    End If
  End Sub

  Private Sub CtlPeriodo1_CambioPeriodo() Handles CtlPeriodo1.CambioPeriodo
    Me.ListBindingSource.DataSource = Nothing
  End Sub

  Private Sub ListBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBindingSource.CurrentChanged
    CambiarEmpleado()
  End Sub

  Private Sub CambiarEmpleado(Optional _forzar As Boolean = False)
    If _forzar OrElse Not mesLlenandoLista Then
      RaiseEvent CambioEmpleado(Me, Nothing)
    End If
  End Sub

  Private Sub chksolograbados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolograbados.CheckedChanged
    Me.pnlfiltrar.Visible = Not Me.chksolograbados.Checked
    ajustarpnlpersact()
  End Sub

  Private Sub CtlTipoContrato1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlTipoContrato1.SelectedIndexChanged

  End Sub

  Private Sub tvEmpleados_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tvEmpleados.CellEndEdit

  End Sub

  Private Sub tvEmpleados_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tvEmpleados.CellLeave

  End Sub

  Private Sub tvEmpleados_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tvEmpleados.CellMouseUp
    Me.tvEmpleados.EndEdit()
    Me.tvEmpleados.EndEdit()
    If cambiarcheck Then
      Exit Sub
    End If
    Me.tvEmpleados.EndEdit()
    cambiarlistcheck = True
    Dim sicheck As Boolean = True
    Dim nocheck As Boolean = True
    Select Case mTipoDato
      Case enumTipoDato.Empleado
        For Each _empleado As Empleado In mEmpleados
          If _empleado.Seleccionado Then
            nocheck = False
          Else
            sicheck = False
          End If
        Next
      Case enumTipoDato.Contrato
        For Each _contrato As Contrato In mContratos
          If _contrato.Seleccionado Then
            nocheck = False
          Else
            sicheck = False
          End If
        Next
      Case enumTipoDato.Asistencia
        For Each _asis As Asistencia In mAsistencias
          If _asis.Seleccionado Then
            nocheck = False
          Else
            sicheck = False
          End If
        Next
    End Select

    Me.mnugenerar.Enabled = True
    If sicheck Then
      Me.chktodos.CheckState = CheckState.Checked
    ElseIf nocheck Then
      Me.chktodos.CheckState = CheckState.Unchecked
      Me.mnugenerar.Enabled = False
    Else
      Me.chktodos.Checked = True
      Me.chktodos.CheckState = CheckState.Indeterminate
    End If
    cambiarlistcheck = False

  End Sub

  Private Sub tvEmpleados_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tvEmpleados.CellValueChanged

  End Sub

  Private Sub tvEmpleados_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles tvEmpleados.CellValuePushed

  End Sub

  Private Sub chksolotipocontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolotipocontrato.CheckedChanged
    Me.pnltipocontrato.Visible = chksolotipocontrato.Checked
    ajustarpnlpersact()
  End Sub

  
  Private Sub CtlPatrono1_CambioPatrono() Handles CtlPatrono1.CambioPatrono
    CtlTipoContrato1.Op = mOp
    CtlTipoContrato1.Patrono = CtlPatrono1.Patrono
    CtlTipoContrato1.llenar_datos()
  End Sub
End Class
