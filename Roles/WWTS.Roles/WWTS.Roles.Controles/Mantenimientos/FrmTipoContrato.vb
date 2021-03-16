Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmTipoContrato
  Implements IMantenimiento

  Private mTipoContrato As TipoContrato
  Public Property TipoContrato() As TipoContrato
    Get
      Return mTipoContrato
    End Get
    Set(ByVal Value As TipoContrato)
      mTipoContrato = Value
      If Value IsNot Nothing Then
        Me.cbotipocontrato.OperadorDatos = Value.OperadorDatos
        Me.cbotipocontrato.Parametro = Enumerados.EnumParametros.TipoContrato
        Me.cbotipocontrato.Llenar_Datos()
        Me.cboperpago.OperadorDatos = Value.OperadorDatos
        Me.cboperpago.Parametro = Enumerados.EnumParametros.PeriodoPago
        Me.cboperpago.Llenar_Datos()
      End If

      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not TipoContrato Is Nothing Then
      Me.txtcodigo.Text = TipoContrato.TipCon_Codigo
      Me.txtdescripcion.Text = TipoContrato.TipCon_Descripcion
      Me.cboperpago.ParametroDet = TipoContrato.PardetPeriodoPago
      Me.cbotipocontrato.ParametroDet = TipoContrato.PardetTipoContrato
      Me.txttiempom.Text = TipoContrato.TipCon_Caducidadmeses

      Me.pnlnodestajo.Visible = Not TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo
      Me.pnlvalorhora.Visible = TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras

      'If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
      'Me.CtlLabor1.Labor = TipoContrato.Labor
      'Else
      'Me.btncontrato.Text = TipoContrato.TipCon_Contrato
      'Me.btnrenuncia.Text = TipoContrato.TipCon_Renuncia
      'Me.btndespido.Text = TipoContrato.TipCon_Despido
      'Me.btnsuspension.Text = TipoContrato.TipCon_Suspension
      'Me.btnllamada.Text = TipoContrato.TipCon_LlamadaAtencion
      'Me.btncertificado.Text = TipoContrato.TipCon_CertificadoTrabajo

      mostrarformatos()

      Me.chkficharojadespido.Checked = TipoContrato.TipCon_FichaRojaDespido
      Me.chkficharojarenuncia.Checked = TipoContrato.TipCon_FichaRojaRenuncia
      Me.chkturnosrotativos.Checked = TipoContrato.TipCon_TurnosRotativos
      'End If

      If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
        Me.txtvalorhora.Value = TipoContrato.TipCon_valorhora
        Me.txtvalorslv.Value = TipoContrato.TipCon_valorSLV
        Me.txtvalorssdf.Value = TipoContrato.TipCon_valorSSDF
      End If

      Me.txthorasdiarias.Value = TipoContrato.TipCon_HorasDiarias
      Me.txthorassemanales.Value = TipoContrato.TipCon_HorasSemanales

      Me.chkMensualizarD3.Checked = TipoContrato.TipCon_MensualizarD3
      Me.chkMensualizarD4.Checked = TipoContrato.TipCon_MensualizarD4
      Me.chkMensualizarVac.Checked = TipoContrato.TipCon_MensualizarVac
      Me.chkMensualizarFR.Checked = TipoContrato.TipCon_MensualizarFondoReserva
      Me.txtSueldoMaximo.Value = TipoContrato.TipCon_SueldoMaximo
    End If

    Me.txtcodigo.Enabled = False
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txtdescripcion.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txttiempom.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.cboperpago.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.cbotipocontrato.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion

    'Me.btncontrato.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.btnrenuncia.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.btndespido.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.btnsuspension.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.btnllamada.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    'Me.btncertificado.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkficharojadespido.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkficharojarenuncia.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion

    Me.txthorasdiarias.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.txthorassemanales.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion

    Me.chkMensualizarD3.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkMensualizarD4.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
    Me.chkMensualizarVac.Enabled = Not Direccion = IMantenimiento.Accion.Eliminacion
  End Sub

  'Private mlist As TipoContratoFormatoList
  Sub mostrarformatos()

    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetFormatoString"
    DataGridViewTextBoxColumn1.HeaderText = "Formato"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 150
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "TiCoFo_Archivo"
    DataGridViewTextBoxColumn1.HeaderText = "Archivo"
    DataGridViewTextBoxColumn1.ReadOnly = False
    DataGridViewTextBoxColumn1.Width = 310
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'mlist = TipoContratoFormatoList.ObtenerLista(Sistema.OperadorDatos, TipoContrato.Patron_Codigo, TipoContrato.TipCon_Codigo)
    BSFormatos.DataSource = mTipoContrato.TipoContratoFormatos
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          TipoContrato.TipCon_Codigo = Me.txtcodigo.Text
          TipoContrato.TipCon_Descripcion = Me.txtdescripcion.Text

          TipoContrato.TipCon_Caducidadmeses = Me.txttiempom.Text
          TipoContrato.PardetPeriodoPago = Me.cboperpago.ParametroDet
          TipoContrato.PardetTipoContrato = Me.cbotipocontrato.ParametroDet
          'If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Then
          'TipoContrato.Labor = Me.CtlLabor1.Labor
          'Else
          'TipoContrato.TipCon_Contrato = Me.btncontrato.Text
          'TipoContrato.TipCon_Renuncia = Me.btnrenuncia.Text
          'TipoContrato.TipCon_Despido = Me.btndespido.Text
          'TipoContrato.TipCon_Suspension = Me.btnsuspension.Text
          'TipoContrato.TipCon_LlamadaAtencion = Me.btnllamada.Text
          'TipoContrato.TipCon_CertificadoTrabajo = Me.btncertificado.Text
          TipoContrato.TipCon_FichaRojaDespido = Me.chkficharojadespido.Checked
          TipoContrato.TipCon_FichaRojaRenuncia = Me.chkficharojarenuncia.Checked
          TipoContrato.TipCon_TurnosRotativos = Me.chkturnosrotativos.Checked
          'End If
          'If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.Destajo Or TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
          If TipoContrato.Pardet_TipoContratoEnum = Enumerados.enumTipoContrato.PorHoras Then
            TipoContrato.TipCon_valorhora = Me.txtvalorhora.Value
            TipoContrato.TipCon_valorSLV = Me.txtvalorslv.Value
            TipoContrato.TipCon_valorSSDF = Me.txtvalorssdf.Value
          End If

          TipoContrato.TipCon_HorasDiarias = Me.txthorasdiarias.Value
          TipoContrato.TipCon_HorasSemanales = Me.txthorassemanales.Value

          TipoContrato.TipCon_MensualizarD3 = Me.chkMensualizarD3.Checked
          TipoContrato.TipCon_MensualizarD4 = Me.chkMensualizarD4.Checked
          TipoContrato.TipCon_MensualizarVac = Me.chkMensualizarVac.Checked
          TipoContrato.TipCon_MensualizarFondoReserva = Me.chkMensualizarFR.Checked
          TipoContrato.TipCon_SueldoMaximo = Me.txtSueldoMaximo.Value

          If Not TipoContrato.Guardar() Then
            Throw New Exception(TipoContrato.OperadorDatos.MsgError)
          End If

          'For Each _ticofo As TipoContratoFormato In BSFormatos
          '  If Not _ticofo.Guardar() Then
          '    Throw New Exception(_ticofo.OperadorDatos.MsgError)
          '  End If
          'Next
        Case IMantenimiento.Accion.Eliminacion
          If Not TipoContrato.Eliminar() Then
            Throw New Exception(TipoContrato.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  'Private Sub btncontrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  With ofd
  '    .InitialDirectory = Application.StartupPath & "\formatos\"
  '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
  '      Me.btncontrato.Text = .FileName
  '    End If
  '  End With
  'End Sub

  'Private Sub btnrenuncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  With ofd
  '    .InitialDirectory = Application.StartupPath & "\formatos\"
  '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
  '      Me.btnrenuncia.Text = .FileName
  '    End If
  '  End With
  'End Sub

  'Private Sub btndespido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  With ofd
  '    .InitialDirectory = Application.StartupPath & "\formatos\"
  '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
  '      Me.btndespido.Text = .FileName
  '    End If
  '  End With
  'End Sub

  'Private Sub btnsuspension_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  With ofd
  '    .InitialDirectory = Application.StartupPath & "\formatos\"
  '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
  '      Me.btnsuspension.Text = .FileName
  '    End If
  '  End With
  'End Sub

  'Private Sub btnllamada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  With ofd
  '    .InitialDirectory = Application.StartupPath & "\formatos\"
  '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
  '      Me.btnllamada.Text = .FileName
  '    End If
  '  End With
  'End Sub

  Private Sub cbotipocontrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipocontrato.SelectedIndexChanged
    Me.pnlnodestajo.Visible = Not cbotipocontrato.SelectedValue = Enumerados.enumTipoContrato.Destajo
    Me.pnlvalorhora.Visible = cbotipocontrato.SelectedValue = Enumerados.enumTipoContrato.Destajo Or cbotipocontrato.SelectedValue = Enumerados.enumTipoContrato.PorHoras
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region

  'Private Sub btncertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  With ofd
  '    .InitialDirectory = Application.StartupPath & "\formatos\"
  '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
  '      Me.btncertificado.Text = .FileName
  '    End If
  '  End With

  'End Sub

  Private Sub btnNuevoFormato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoFormato.Click
    Dim _TipoContratoFormato As TipoContratoFormato = New TipoContratoFormato(Sistema.OperadorDatos, True)
    _TipoContratoFormato.Tipocontrato = TipoContrato

    Dim f As New FrmTipoContratoFormato(Sistema, Enumerados.EnumOpciones.Personal)
    f.TipoContratoFormato = _TipoContratoFormato
    f.ShowDialog()

    mostrarformatos()
  End Sub

  Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
    If BSFormatos.Current IsNot Nothing Then
      Dim f As New FrmTipoContratoFormato(Sistema, Enumerados.EnumOpciones.Personal)
      f.TipoContratoFormato = BSFormatos.Current
      f.Direccion = IMantenimiento.Accion.Modificacion
      f.ShowDialog()

      mostrarformatos()
    End If
  End Sub
End Class
