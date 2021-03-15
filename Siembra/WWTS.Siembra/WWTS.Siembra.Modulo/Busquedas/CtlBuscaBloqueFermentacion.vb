Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos

Public Class CtlBuscaBloqueFermentacion
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlZafra1.Op = mOp
      Me.CtlTerreno1.Op = mOp
      Me.CtlLote1.Op = mOp
      Me.CtlSemilla1.Op = mOp
      Me.CtlCorte1.Op = mOp
      If Not value Is Nothing Then
        Me.CtlZafra1.llenar_datos()
        Me.CtlTerreno1.llenar_datos()
        Me.CtlLote1.llenar_datos()
        Me.CtlSemilla1.llenar_datos()
        Me.CtlCorte1.llenar_datos()
        Me.cbotipomovinv.DisplayMember = "Descripcion"
        Me.cbotipomovinv.ValueMember = "Numero"
        Me.cbotipomovinv.DataSource = Enumerados.TipoMovBloqueList
        Me.dtfecbloqfin.Value = Now.Date
        Me.dtfecbloqini.Value = Now.Date
      End If
    End Set
  End Property

  Public Event CambioBloque As EventHandler
  Dim cambiarlistcheck As Boolean = False
  Dim cambiarcheck As Boolean = False
  Dim activarcambiocaja As Boolean = True
  Dim mBloque As Bloque = Nothing

  Public ReadOnly Property Bloque() As Bloque
    Get
      If tvbloques.Nodes.Count = 0 OrElse tvbloques.SelectedNode Is Nothing Then
        Return Nothing
      Else
        Return CType(tvbloques.SelectedNode.Tag, Bloque)
      End If
    End Get
  End Property
  Public ReadOnly Property Zafra() As ZafraSiembra
    Get
      Return Me.CtlZafra1.Zafra
    End Get
  End Property
  Public ReadOnly Property bloquesSeleccionadas() As BloqueCollection
    Get
      Dim bloques As New BloqueCollection
      For Each _node As TreeNode In tvbloques.Nodes
        If _node.Checked Then
          bloques.Add(CType(_node.Tag, Bloque))
        End If
      Next
      Return bloques
    End Get
  End Property
  Public Sub llenar_datos(ByVal tipo As Integer)
    Me.tvbloques.Visible = False
    tvbloques.BeginUpdate()
    tvbloques.Nodes.Clear()
    Me.chktodos.Checked = False
    Dim bloques As BloqueCollection = Nothing

    Dim _zafra As ZafraSiembra = Nothing
    _zafra = Me.CtlZafra1.Zafra
    Dim _Terreno As Terreno = Nothing
    If Me.chksolofinca.Checked Then
      _Terreno = Me.CtlTerreno1.Terreno
    End If
    Dim _Lote As LoteTerreno = Nothing
    If Me.chksololote.Checked Then
      _Lote = Me.CtlLote1.Lote
    End If
    Dim fecbloqini As Date
    Dim fecbloqfin As Date
    If Me.chkfechatipomov.Checked Then
      fecbloqini = Me.dtfecbloqini.Value.Date
      fecbloqfin = Me.dtfecbloqfin.Value.Date
      If fecbloqini > fecbloqfin Then
        MsgBox("Ingrese rango correcto de fecha de bloque", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If
    End If
    Dim _semilla As SemillaSiembra = Nothing
    If Me.chksolosemilla.Checked Then
      _semilla = Me.CtlSemilla1.Semilla
    End If
    Dim _corte As Corte = Nothing
    If Me.chksolocorte.Checked Then
      _corte = Me.CtlCorte1.Corte
    End If
    Dim desde As Integer
    Dim hasta As Integer
    If Me.chknumerobloque.Checked Then
      desde = CInt(Me.txtdesde.Text)
      hasta = CInt(Me.txthasta.Text)
      If desde > hasta Then
        MsgBox("Ingrese rango correcto en número de bloque", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If
    End If

    bloques = Bloque.RetornarBloquesFiltro(Op, _zafra, _Terreno, _Lote, chkfechatipomov.Checked,
                                           CType(cbotipomovinv.SelectedValue, Enumerados.TipoMovBloque),
                                           fecbloqini, fecbloqfin, _semilla, _corte, chknumerobloque.Checked, desde, hasta)

    Me.lblstatus.Text = "."
    If Not bloques Is Nothing Then
      activarcambiocaja = False
      Me.lblstatus.Text = bloques.Count.ToString.Trim & " bloques encontradas"
      For Each _bloq As Bloque In bloques
        Dim nodecaja As New TreeNode
        nodecaja.Text = "(" & _bloq.Blo_codigo.ToString.Trim & ") " & _bloq.Lote.Terreno.Trr_nombre.Trim & " " & _bloq.Lote.Lot_codigo.ToString.Trim & "-" & _bloq.Semilla.Sem_nombre.Trim
        nodecaja.Tag = _bloq
        tvbloques.Nodes.Add(nodecaja)
      Next
      activarcambiocaja = True
    End If
    Me.tvbloques.EndUpdate()
    Me.tvbloques.Visible = True
    If tvbloques.Nodes.Count > 0 Then
      tvbloques.SelectedNode = tvbloques.Nodes(0)
    End If
  End Sub

  Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    Me.llenar_datos(1)
  End Sub

#Region "Acoplarxxx"
  Private Sub chksolofinca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolofinca.CheckedChanged
    If chksolofinca.Checked Then
      Me.chksololote.Checked = Not chksolofinca.Checked
    End If
    Me.pnlsolofinca.Visible = chksolofinca.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksololote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksololote.CheckedChanged
    If chksololote.Checked Then
      Me.chksolofinca.Checked = Not chksololote.Checked
    End If
    Me.pnlsololote.Visible = chksololote.Checked
    ajustarpaneles()
  End Sub
  Private Sub chkfechaingreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfechatipomov.CheckedChanged
    pnlfechatipomov.Visible = chkfechatipomov.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolosemilla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolosemilla.CheckedChanged
    Me.pnlsolosemilla.Visible = chksolosemilla.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolocorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolocorte.CheckedChanged
    Me.pnlsolocorte.Visible = chksolocorte.Checked
    ajustarpaneles()
  End Sub
  Private Sub chknumerobloque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknumerobloque.CheckedChanged
    Me.pnlnumeroembarque.Visible = chknumerobloque.Checked
    ajustarpaneles()
  End Sub
  Sub ajustarpaneles()
    pnlbusqbloque.Height = pnlfin.Location.Y
  End Sub
#End Region

  Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
    If cambiarlistcheck Then
      Exit Sub
    End If
    Dim t As Integer
    cambiarcheck = True
    For t = 0 To Me.tvbloques.Nodes.Count - 1
      Me.tvbloques.Nodes(t).Checked = Me.chktodos.Checked
    Next
    cambiarcheck = False
  End Sub

  Private Sub tvbloques_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvbloques.AfterCheck
    If cambiarcheck Then
      Exit Sub
    End If
    cambiarlistcheck = True
    Dim sicheck As Boolean = True
    Dim nocheck As Boolean = True
    Dim t As Integer
    For t = 0 To Me.tvbloques.Nodes.Count - 1
      If Me.tvbloques.Nodes(t).Checked Then
        nocheck = False
      Else
        sicheck = False
      End If
    Next

    If sicheck Then
      Me.chktodos.CheckState = CheckState.Checked
    ElseIf nocheck Then
      Me.chktodos.CheckState = CheckState.Unchecked
    Else
      Me.chktodos.Checked = True
      Me.chktodos.CheckState = CheckState.Indeterminate
    End If
    cambiarlistcheck = False
  End Sub

  Private Sub CtlBuscaBloqueFermentacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ResumeLayout(False)
    chkfechatipomov.Checked = False
    ajustarpaneles()
  End Sub

  Private Sub tvbloques_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvbloques.AfterSelect
    If TypeOf e.Node.Tag Is Bloque Then
      Me.mBloque = CType(e.Node.Tag, Bloque)
    Else
      Me.mBloque = Nothing
    End If
    If activarcambiocaja Then
      RaiseEvent CambioBloque(Me, System.EventArgs.Empty)
    End If
  End Sub
  Private Sub seleccionarnodo(ByVal node As TreeNode, ByVal value As Bloque)
    While Not node Is Nothing
      If TypeOf node.Tag Is Bloque Then
        Dim mBloque As Bloque
        mBloque = CType(node.Tag, Bloque)

        If mBloque.Blo_codigo = value.Blo_codigo Then
          tvbloques.SelectedNode = node
          node.EnsureVisible()
        End If
      End If
      If node.GetNodeCount(False) > 0 Then
        seleccionarnodo(node.Nodes(0), value)
      End If
      node = node.NextNode
    End While
  End Sub

  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    Dim _bloques As New BloqueCollection
    For Each _nodo As TreeNode In Me.tvbloques.Nodes
      If _nodo.Checked Then
        _bloques.Add(CType(_nodo.Tag, Bloque))
      End If
    Next

    If _bloques Is Nothing OrElse _bloques.Count = 0 Then
      Exit Sub
    End If

    ExcelReporte.BloqueReporte.ExportarExcel(_bloques)
    'If MsgBox("Desea ver el reporte en forma resumida", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
    '	Bloque.ExportarExcelresumido(_bloques)
    'Else
    '	Bloque.ExportarExceldetallado(_bloques)
    'End If
  End Sub

  Private Sub mnu25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu25.Click
    seleccionarnodos(25)
  End Sub
  Sub seleccionarnodos(ByVal numero As Integer)
    Dim tv As TreeNode = Me.tvbloques.SelectedNode
    For t As Integer = 1 To numero
      tv.Checked = True
      tv = tv.NextNode
    Next
    Me.tvbloques.SelectedNode = tv
  End Sub
  Private Sub mnu50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu50.Click
    seleccionarnodos(50)
  End Sub
  Private Sub mnu100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu100.Click
    seleccionarnodos(100)
  End Sub
  Private Sub mnu250_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu250.Click
    seleccionarnodos(250)
  End Sub
  Private Sub mnu500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu500.Click
    seleccionarnodos(500)
  End Sub
  Private Sub mnu1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu1000.Click
    seleccionarnodos(1000)
  End Sub



End Class
