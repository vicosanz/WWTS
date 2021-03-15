Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos

Public Class CtlBuscaCajasRezago
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlZafra1.Op = mOp
      Me.CtlClaseHoja1.Op = mOp
      Me.CtlColorHoja1.Op = mOp
      Me.CtlSemilla1.Op = mOp
      Me.CtlBodega1.Op = mOp
      Me.CtlCorte1.Op = mOp
      Me.CtlTerreno1.Op = mOp
      If Not value Is Nothing Then
        Me.CtlZafra1.llenar_datos()
        Me.CtlClaseHoja1.llenar_datos()
        Me.CtlColorHoja1.llenar_datos()
        Me.CtlSemilla1.llenar_datos()
        Me.CtlBodega1.llenar_datos()
        Me.CtlCorte1.llenar_datos()
        Me.CtlTerreno1.llenar_datos()
        Me.dtfecempfin.Value = Now.Date
        Me.dtfecempini.Value = Now.Date
      End If
    End Set
  End Property

  Public Event CambioCaja As EventHandler
  Dim cambiarlistcheck As Boolean = False
  Dim cambiarcheck As Boolean = False
  Dim activarcambiocaja As Boolean = True
  Dim mcaja As InvCaja = Nothing
  Public ReadOnly Property CajasTv() As TreeView
    Get
      Return tvcajas
    End Get
  End Property

  Public ReadOnly Property InvCaja() As InvCaja
    Get
      If tvcajas.Nodes.Count = 0 Then
        Return Nothing
      Else
        If tvcajas.SelectedNode Is Nothing Then
          Return Nothing
        Else
          Return CType(tvcajas.SelectedNode.Tag, InvCaja)
        End If
      End If
    End Get
  End Property
  Public ReadOnly Property Zafra() As ZafraSiembra
    Get
      Return Me.CtlZafra1.Zafra
    End Get
  End Property
  Public ReadOnly Property TipoTabaco() As Enumerados.TipoTabaco
    Get
      If (rdotabcandela.Checked) Then
        Return Enumerados.TipoTabaco.Candela
      End If
      Return Enumerados.TipoTabaco.Natural
    End Get
  End Property
  Public ReadOnly Property CajasSeleccionadas() As InvCajaCollection
    Get
      Dim Cajas As New InvCajaCollection
      Dim t As Integer
      For t = 0 To Me.tvcajas.Nodes.Count - 1
        If tvcajas.Nodes(t).Checked Then
          Cajas.Add(CType(tvcajas.Nodes(t).Tag, InvCaja))
        End If
      Next
      Return Cajas
    End Get
  End Property
  Public Sub llenar_datos(ByVal tipo As Integer)
    Me.tvcajas.Visible = False
    tvcajas.BeginUpdate()
    tvcajas.Nodes.Clear()
    Me.chktodos.Checked = False
    Dim cajas As InvCajaCollection = Nothing

    Dim _tipotabaco As Enumerados.TipoTabaco = Enumerados.TipoTabaco.Candela
    If Me.rdotabnatural.Checked Then
      _tipotabaco = Enumerados.TipoTabaco.Natural
    End If
    Dim _zafra As ZafraSiembra = Nothing
    _zafra = Me.CtlZafra1.Zafra

    Dim _ClaseHoja As ClaseHoja = Nothing
    Dim _Noestaclase As Boolean = False
    If Me.chksoloclase.Checked Then
      _ClaseHoja = Me.CtlClaseHoja1.ClaseHoja
      _Noestaclase = Me.chknoestaclase.Checked
    End If

    Dim _color As ColorHoja = Nothing
    If Me.chksolocolor.Checked Then
      _color = Me.CtlColorHoja1.ColorHoja
    End If

    Dim _terreno As Terreno = Nothing
    If Me.chksolofinca.Checked Then
      _terreno = Me.CtlTerreno1.Terreno
    End If

    Dim _bodega As WWTS.Siembra.Reglas.BodegaTerreno = Nothing
    If Me.chksolobodega.Checked Then
      _bodega = Me.CtlBodega1.Bodega
    End If

    Dim _semilla As SemillaSiembra = Nothing
    If Me.chksolosemilla.Checked Then
      _semilla = Me.CtlSemilla1.Semilla
    End If

    Dim _corte As Corte = Nothing
    If Me.chksolocorte.Checked Then
      _corte = Me.CtlCorte1.Corte
    End If

    Dim fecempini As Date
    Dim fecempfin As Date
    If Me.chkfechaempaque.Checked Then
      fecempini = Me.dtfecempini.Value.Date
      fecempfin = Me.dtfecempfin.Value.Date
      If fecempini > fecempfin Then
        MsgBox("Ingrese rango correcto de fecha de empaque", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If
    End If

    Dim desde As Integer
    Dim hasta As Integer
    If chksolocajasembarcadas.CheckState = CheckState.Checked And Me.chknumeroembarque.Checked Then
      desde = CInt(Me.txtdesde.Text)
      hasta = CInt(Me.txthasta.Text)
      If desde > hasta Then
        MsgBox("Ingrese rango correcto en número de embarque", MsgBoxStyle.Information, "Información")
        Exit Sub
      End If
    End If

    cajas = InvCaja.RetornarInvCajaFiltro(Op, _tipotabaco, _semilla, _terreno, _bodega, _corte, _Noestaclase, _ClaseHoja, _color, _zafra, chkfechaempaque.Checked, fecempini, fecempfin, Me.chksolocajasembarcadas.CheckState, chknumeroembarque.Checked, desde, hasta)

    Me.lblstatus.Text = "."
    If Not cajas Is Nothing Then
      activarcambiocaja = False
      Me.lblstatus.Text = cajas.Count.ToString.Trim & " cajas encontradas"
      For Each _caja As InvCaja In cajas
        Dim nodecaja As New TreeNode
        nodecaja.Text = $"({_caja.Caj_empNum.ToString.Trim}) {IIf(_caja.Caj_tipoNC = Enumerados.TipoTabaco.Natural, "N", "C")}-{_caja.Terreno.Trr_nombre.Trim} {_caja.Semilla.Sem_nombre.Trim}"
        nodecaja.Tag = _caja
        tvcajas.Nodes.Add(nodecaja)
      Next
      activarcambiocaja = True
    End If
    Me.tvcajas.EndUpdate()
    Me.tvcajas.Visible = True
    If tvcajas.Nodes.Count > 0 Then
      tvcajas.SelectedNode = tvcajas.Nodes(0)
    End If
  End Sub

  Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    Me.llenar_datos(1)
  End Sub

#Region "Acoplarxxx"
  Private Sub chkfechaempaque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfechaempaque.CheckedChanged
    pnlfechaempaque.Visible = chkfechaempaque.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksoloclase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoloclase.CheckedChanged
    Me.pnlsoloclase.Visible = chksoloclase.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolocolor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolocolor.CheckedChanged
    Me.pnlsolocolor.Visible = chksolocolor.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolosemilla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolosemilla.CheckedChanged
    Me.pnlsolosemilla.Visible = chksolosemilla.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolobodega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolobodega.CheckedChanged
    Me.pnlsolobodega.Visible = chksolobodega.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolocorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolocorte.CheckedChanged
    Me.pnlsolocorte.Visible = chksolocorte.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolofinca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolofinca.CheckedChanged
    Me.pnlsolofinca.Visible = chksolofinca.Checked
    ajustarpaneles()
  End Sub
  Private Sub chksolocajasembarcadas_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chksolocajasembarcadas.CheckStateChanged
    Me.pnlsolocajasembarcadas.Visible = chksolocajasembarcadas.CheckState = CheckState.Checked
    ajustarpaneles()
  End Sub
  'Private Sub chkfechaembarque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Me.pnlfechaembarque.Visible = chkfechaembarque.Checked
  '  ajustarpaneles()
  'End Sub
  Private Sub chknumeroembarque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknumeroembarque.CheckedChanged
    Me.pnlnumeroembarque.Visible = chknumeroembarque.Checked
    ajustarpaneles()
  End Sub

  Sub ajustarpaneles()
    If chknumeroembarque.Checked Then
      pnlsolocajasembarcadas.Height = pnlnumeroembarque.Location.Y + pnlnumeroembarque.Height
    Else
      pnlsolocajasembarcadas.Height = chknumeroembarque.Location.Y + chknumeroembarque.Height
    End If

    pnlbusqcajas.Height = pnlfin.Location.Y
  End Sub
#End Region

  Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
    If cambiarlistcheck Then
      Exit Sub
    End If
    Dim t As Integer
    cambiarcheck = True
    For t = 0 To Me.tvcajas.Nodes.Count - 1
      Me.tvcajas.Nodes(t).Checked = Me.chktodos.Checked
    Next
    cambiarcheck = False
  End Sub

  Private Sub tvcajas_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvcajas.AfterCheck
    If cambiarcheck Then
      Exit Sub
    End If
    cambiarlistcheck = True
    Dim sicheck As Boolean = True
    Dim nocheck As Boolean = True
    Dim t As Integer
    For t = 0 To Me.tvcajas.Nodes.Count - 1
      If Me.tvcajas.Nodes(t).Checked Then
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

  Private Sub CtlBuscaCajasRezago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    chkfechaempaque.Checked = False
    ajustarpaneles()
  End Sub

  Private Sub tvcajas_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvcajas.AfterSelect
    If TypeOf e.Node.Tag Is InvCaja Then
      Me.mcaja = CType(e.Node.Tag, InvCaja)
    Else
      Me.mcaja = Nothing
    End If
    If activarcambiocaja Then
      RaiseEvent CambioCaja(Me, System.EventArgs.Empty)
    End If
  End Sub
  Private Sub seleccionarnodo(ByVal node As TreeNode, ByVal value As InvCaja)
    While Not node Is Nothing
      If TypeOf node.Tag Is InvCaja Then
        Dim mCaja As InvCaja
        mCaja = CType(node.Tag, InvCaja)

        If mCaja.Caj_embNum = value.Caj_embNum Then
          tvcajas.SelectedNode = node
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
    Dim _cajas As New InvCajaCollection
    For Each _nodo As TreeNode In Me.tvcajas.Nodes
      If _nodo.Checked Then
        _cajas.Add(CType(_nodo.Tag, InvCaja))
      End If
    Next

    If _cajas Is Nothing OrElse _cajas.Count = 0 Then
      Exit Sub
    End If

    If MsgBox("Desea ver el reporte en forma resumida", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
      ExcelReporte.InvCajaReporte.ExportarExcelresumido(_cajas, Nothing)
    Else
      ExcelReporte.InvCajaReporte.ExportarExceldetallado(_cajas)
    End If
  End Sub
  Private Sub mnu25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu25.Click
    seleccionarnodos(25)
  End Sub
  Sub seleccionarnodos(ByVal numero As Integer)
    Dim tv As TreeNode = Me.tvcajas.SelectedNode
    For t As Integer = 1 To numero
      tv.Checked = True
      tv = tv.NextNode
    Next
    Me.tvcajas.SelectedNode = tv
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
