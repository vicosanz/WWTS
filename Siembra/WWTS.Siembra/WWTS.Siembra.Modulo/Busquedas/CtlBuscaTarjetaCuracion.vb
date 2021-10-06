Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos

Public Class CtlBuscaTarjetaCuracion
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
            Me.CtlSeccionHorno1.Op = mOp
            Me.CtlSemilla1.Op = mOp
            If Not value Is Nothing Then
                Me.CtlZafra1.llenar_datos()
                Me.CtlTerreno1.llenar_datos()
                Me.CtlLote1.llenar_datos()
                Me.CtlSeccionHorno1.llenar_datos()
                Me.CtlSemilla1.llenar_datos()
                Me.dtfecensfin.Value = Now.Date
                Me.dtfecensini.Value = Now.Date
            End If
        End Set
    End Property

    Public Event CambioTarjeta As EventHandler
    Dim cambiarlistcheck As Boolean = False
    Dim cambiarcheck As Boolean = False
    Dim activarcambiocaja As Boolean = True
    Dim mTarjeta As Curacion = Nothing

    Public ReadOnly Property Curacion() As Curacion
        Get
            If tvtarjetas.Nodes.Count = 0 OrElse tvtarjetas.SelectedNode Is Nothing Then
                Return Nothing
            Else
                Return CType(tvtarjetas.SelectedNode.Tag, Curacion)
            End If
        End Get
    End Property
    Public ReadOnly Property Zafra() As ZafraSiembra
        Get
            Return Me.CtlZafra1.Zafra
        End Get
    End Property
    Public ReadOnly Property TarjetasSeleccionadas() As CuracionCollection
        Get
            Dim Tarjetas As New CuracionCollection
            For Each _node As TreeNode In tvtarjetas.Nodes
                If _node.Checked Then
                    Tarjetas.Add(CType(_node.Tag, Curacion))
                End If
            Next
            Return Tarjetas
        End Get
    End Property
    Public Sub llenar_datos(ByVal tipo As Integer)
        Me.tvtarjetas.Visible = False
        tvtarjetas.BeginUpdate()
        tvtarjetas.Nodes.Clear()
        Me.chktodos.Checked = False
        Dim tarjetas As CuracionCollection = Nothing

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
        Dim fecensini As Date
        Dim fecensfin As Date
        If Me.chkfechacuracion.Checked Then
            fecensini = Me.dtfecensini.Value.Date
            fecensfin = Me.dtfecensfin.Value.Date
            If fecensini > fecensfin Then
                MsgBox("Ingrese rango correcto de fecha de curación", MsgBoxStyle.Information, "Información")
                Exit Sub
            End If
        End If
        Dim _SeccionHorno As SeccionHorno = Nothing
        If Me.chksolohornosec.Checked Then
            _SeccionHorno = Me.CtlSeccionHorno1.SeccionHorno
        End If
        Dim _semilla As SemillaSiembra = Nothing
        If Me.chksolosemilla.Checked Then
            _semilla = Me.CtlSemilla1.Semilla
        End If
        Dim desde As Integer
        Dim hasta As Integer
        If Me.chknumerozafada.Checked Then
            desde = CInt(Me.txtdesde.Text)
            hasta = CInt(Me.txthasta.Text)
            If desde > hasta Then
                MsgBox("Ingrese rango correcto en número de embarque", MsgBoxStyle.Information, "Información")
                Exit Sub
            End If
        End If

        tarjetas = Curacion.RetornarCuracionsFiltro(Op, _zafra, _Terreno, _Lote, chkfechacuracion.Checked, fecensini, fecensfin, _SeccionHorno, _semilla, chknumerozafada.Checked, desde, hasta)

        Me.lblstatus.Text = "."
        If Not tarjetas Is Nothing Then
            activarcambiocaja = False
            Me.lblstatus.Text = tarjetas.Count.ToString.Trim & " tarjetas encontradas"
            For Each _tarj As Curacion In tarjetas
                Dim nodecaja As New TreeNode
                nodecaja.Text = "(" & _tarj.Cur_numero.ToString.Trim & ") " & _tarj.Lote.Terreno.Trr_nombre.Trim & " " & _tarj.Lote.Lot_codigo.ToString.Trim & "-" & _tarj.Semilla.Sem_nombre.Trim
                nodecaja.Tag = _tarj
                tvtarjetas.Nodes.Add(nodecaja)
            Next
            activarcambiocaja = True
        End If
        Me.tvtarjetas.EndUpdate()
        Me.tvtarjetas.Visible = True
        If tvtarjetas.Nodes.Count > 0 Then
            tvtarjetas.SelectedNode = tvtarjetas.Nodes(0)
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
    Private Sub chkfechaempaque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfechacuracion.CheckedChanged
        pnlfechacuracion.Visible = chkfechacuracion.Checked
        ajustarpaneles()
    End Sub
    Private Sub chksolohornosec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolohornosec.CheckedChanged
        pnlsolohorno.Visible = chksolohornosec.Checked
        ajustarpaneles()
    End Sub
    Private Sub chksolosemilla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolosemilla.CheckedChanged
        Me.pnlsolosemilla.Visible = chksolosemilla.Checked
        ajustarpaneles()
    End Sub
    Private Sub chknumerozafada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknumerozafada.CheckedChanged
        Me.pnlnumeroembarque.Visible = chknumerozafada.Checked
        ajustarpaneles()
    End Sub

    Sub ajustarpaneles()
        pnlbusqtarj.Height = pnlfin.Location.Y
    End Sub
#End Region

    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If cambiarlistcheck Then
            Exit Sub
        End If
        Dim t As Integer
        cambiarcheck = True
        For t = 0 To Me.tvtarjetas.Nodes.Count - 1
            Me.tvtarjetas.Nodes(t).Checked = Me.chktodos.Checked
        Next
        cambiarcheck = False
    End Sub

    Private Sub tvtarjetas_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvtarjetas.AfterCheck
        If cambiarcheck Then
            Exit Sub
        End If
        cambiarlistcheck = True
        Dim sicheck As Boolean = True
        Dim nocheck As Boolean = True
        Dim t As Integer
        For t = 0 To Me.tvtarjetas.Nodes.Count - 1
            If Me.tvtarjetas.Nodes(t).Checked Then
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

    Private Sub CtlBuscaTarjetaCuracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ResumeLayout(False)
        chkfechacuracion.Checked = False
        ajustarpaneles()
    End Sub

    Private Sub tvtarjetas_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvtarjetas.AfterSelect
        If TypeOf e.Node.Tag Is Curacion Then
            Me.mTarjeta = CType(e.Node.Tag, Curacion)
        Else
            Me.mTarjeta = Nothing
        End If
        If activarcambiocaja Then
            RaiseEvent CambioTarjeta(Me, System.EventArgs.Empty)
        End If
    End Sub
    Private Sub seleccionarnodo(ByVal node As TreeNode, ByVal value As Curacion)
        While Not node Is Nothing
            If TypeOf node.Tag Is Curacion Then
                Dim mTarjeta As Curacion
                mTarjeta = CType(node.Tag, Curacion)

                If mTarjeta.Cur_numero = value.Cur_numero Then
                    tvtarjetas.SelectedNode = node
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
        Dim _tarjetas As New CuracionCollection
        For Each _nodo As TreeNode In Me.tvtarjetas.Nodes
            If _nodo.Checked Then
                _tarjetas.Add(CType(_nodo.Tag, Curacion))
            End If
        Next

        If _tarjetas Is Nothing OrElse _tarjetas.Count = 0 Then
            Exit Sub
        End If

        ExcelReporte.CuracionReporte.ExportarExcel(_tarjetas)
        'If MsgBox("Desea ver el reporte en forma resumida", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        '	Curacion.ExportarExcelresumido(_tarjetas)
        'Else
        '	Curacion.ExportarExceldetallado(_tarjetas)
        'End If
    End Sub

  Private Sub mnu25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu25.Click
    seleccionarnodos(25)
  End Sub
  Sub seleccionarnodos(ByVal numero As Integer)
    Dim tv As TreeNode = Me.tvtarjetas.SelectedNode
    For t As Integer = 1 To numero
      tv.Checked = True
      tv = tv.NextNode
    Next
    Me.tvtarjetas.SelectedNode = tv
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
