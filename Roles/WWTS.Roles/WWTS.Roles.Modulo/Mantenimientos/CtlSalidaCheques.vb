Imports Infoware.Reglas
Imports Infoware.Datos
Imports Infoware.Controles.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Controles

Public Class CtlSalidaCheques

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      'CtlCuentaBancaria1.Op = value
      If Not mOp Is Nothing Then
        Me.CtlCuentaBancaria1.llenar_datos()
      End If
    End Set
  End Property

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    creacion()
  End Sub

  Sub creacion()
    Dim clmpersona As System.Windows.Forms.ColumnHeader
    Dim clmvalor As System.Windows.Forms.ColumnHeader
    Dim clmfecha As System.Windows.Forms.ColumnHeader
    Dim clmanulado As System.Windows.Forms.ColumnHeader
    Dim ClmCheque As System.Windows.Forms.ColumnHeader
    Dim clmmotivo As System.Windows.Forms.ColumnHeader

    ClmCheque = New System.Windows.Forms.ColumnHeader
    clmanulado = New System.Windows.Forms.ColumnHeader
    clmpersona = New System.Windows.Forms.ColumnHeader
    clmvalor = New System.Windows.Forms.ColumnHeader
    clmfecha = New System.Windows.Forms.ColumnHeader
    clmmotivo = New System.Windows.Forms.ColumnHeader

    ClmCheque.Text = "# Cheque"
    ClmCheque.Width = 85
    clmanulado.Text = "Anulado"
    clmpersona.Text = "Persona"
    clmpersona.Width = 225
    clmvalor.Text = "Valor"
    clmvalor.Width = 75
    clmfecha.Text = "Fecha"
    clmfecha.Width = 85
    clmmotivo.Text = "Motivo"

    Me.ListViewCheck1.Lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ClmCheque, clmanulado, clmpersona, clmvalor, clmfecha, clmmotivo})
    Me.ListViewCheck1.Lista.SmallImageList = Me.illv
  End Sub

  Private mChequeDesde As Integer
  Private mChequeHasta As Integer

  Dim mChequePagos As ChequePagoList
  Dim cambiarcheck As Boolean = False
  Dim cambiarlistcheck As Boolean = False

  Private mCuentaBancaria As Cuentabancaria
  Public Property CuentaBancaria() As Cuentabancaria
    Get
      Return mCuentaBancaria
    End Get
    Set(ByVal Value As Cuentabancaria)
      mCuentaBancaria = Value
      Me.CtlCuentaBancaria1.CuentaBancaria = Value
    End Set
  End Property

  Public Property ChequeDesde() As Integer
    Get
      Return mChequeDesde
    End Get
    Set(ByVal Value As Integer)
      mChequeDesde = Value
      Me.numdesde.Value = Value
    End Set
  End Property

  Public Property ChequeHasta() As Integer
    Get
      Return mChequeHasta
    End Get
    Set(ByVal Value As Integer)
      mChequeHasta = Value
      Me.numhasta.Value = Value
    End Set
  End Property

  Public Sub llenar_datos()
    Me.ListViewCheck1.Lista.Items.Clear()
    If mOp Is Nothing Then
      Exit Sub
    End If
    If Me.CtlCuentaBancaria1.CuentaBancaria Is Nothing Then
      Exit Sub
    End If
    Me.ListViewCheck1.Lista.BeginUpdate()
    'Me.chktodos.Checked = False
    mChequePagos = ChequePagoList.ObtenerLista(Me.mOp, Me.mCuentaBancaria, Me.mChequeDesde, Me.mChequeHasta)
    If Not mChequePagos Is Nothing Then
      For Each _chqv As ChequePago In mChequePagos
        Dim item As New ListViewItem
        item.ImageIndex = IIf(_chqv.ChePag_esAnulado, 1, 0)
        item.SubItems(0).Text = _chqv.ChePag_Numero
        item.SubItems.Add(IIf(_chqv.ChePag_esAnulado, "Sí", "No"))
        If Not _chqv.Detallelotepago Is Nothing Then
          If _chqv.Detallelotepago.Empleado IsNot Nothing Then
            item.SubItems.Add(_chqv.Detallelotepago.Empleado.NombreCompleto)
          Else
            item.SubItems.Add("")
          End If
          item.SubItems.Add(_chqv.Detallelotepago.DeLoPa_Valor.ToString("c"))
          item.SubItems.Add(_chqv.Detallelotepago.DeLoPa_Fecha.ToString("d"))
          item.SubItems.Add(_chqv.Detallelotepago.PardetMotivoPago.Pardet_Descripcion)
        End If
        item.Checked = False
        Me.ListViewCheck1.Lista.Items.Add(item)
      Next
    End If
    habilitar()
    Me.ListViewCheck1.Lista.EndUpdate()
  End Sub

  Sub habilitar()
    Me.btnanular.Enabled = Not Me.ListViewCheck1.EstadoCheck = ListaCheckEnum.Ninguno
    Me.btnelim.Enabled = Not Me.ListViewCheck1.EstadoCheck = ListaCheckEnum.Ninguno
    Me.btnanul.Enabled = (Me.ListViewCheck1.Lista.SelectedItems.Count > 0)
    Me.btnmodificar.Enabled = (Me.ListViewCheck1.Lista.SelectedItems.Count > 0)
  End Sub

  Private Sub ListViewCheck1_CambioCheck(ByVal sender As Object, ByVal e As ListaCheckEventArgs) Handles ListViewCheck1.CambioCheck
    habilitar()
  End Sub

  Private Sub lvcheques_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewCheck1.CambioSelectIndex
    habilitar()
  End Sub

  Private Sub btnanul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanul.Click
    If Me.ListViewCheck1.Lista.SelectedItems.Count = 0 Then
      Exit Sub
    End If
    Dim _pagovario As LotePagoVarioDetalle
    _pagovario = Me.mChequePagos(Me.ListViewCheck1.Lista.SelectedIndices(0)).Detallelotepago
    ChequePagoList.InsertarAnulados(Me.mOp, Me.mCuentaBancaria, Me.rdoantes.Checked, Me.mChequePagos(Me.ListViewCheck1.Lista.SelectedIndices(0)).ChePag_Numero, IIf(Me.rdoantes.Checked, Me.numanuantes.Value, Me.numanudespues.Value), _pagovario)
    llenar_datos()
  End Sub

  Private Sub btnelim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
    If MsgBox("Al eliminar un cheque automáticamente los cheques siguientes ocuparán el espacio dejado. ¿Está seguro que desea eliminar los cheques seleccionados?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    For t As Integer = Me.ListViewCheck1.Lista.Items.Count - 1 To 0 Step -1
      If Me.ListViewCheck1.Lista.Items(t).Checked Then
        Try
          If Not mChequePagos(t).Eliminar Then
            Throw New Exception(mChequePagos(t).OperadorDatos.MsgError)
          End If
        Catch ex As Exception
          MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
      End If
    Next
    llenar_datos()
  End Sub

  Private Sub numhasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numhasta.ValueChanged, numhasta.Leave
    Me.mChequeHasta = Me.numhasta.Value
    llenar_datos()
  End Sub

  Private Sub numdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numdesde.ValueChanged, numdesde.Leave
    Me.mChequeDesde = Me.numdesde.Value
    llenar_datos()
  End Sub

  Private Sub CtlCtaBancaria1_CambioCtaBancaria(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlCuentaBancaria1.CambioCuentaBancaria
    Me.mCuentaBancaria = Me.CtlCuentaBancaria1.CuentaBancaria
    llenar_datos()
  End Sub

  Private Sub rdoantes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoantes.CheckedChanged
    Me.numanuantes.Enabled = rdoantes.Checked
    Me.numanudespues.Enabled = Not rdoantes.Checked
  End Sub

  Private Sub btnanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanular.Click
    If MsgBox("Al anular un cheque se marcará y se respetará su numeración y la de los siguientes. ¿Está seguro que desea anular los cheques seleccionados?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    For t As Integer = Me.ListViewCheck1.Lista.Items.Count - 1 To 0 Step -1
      If Me.ListViewCheck1.Lista.Items(t).Checked Then
        Try
          If Not mChequePagos(t).Anular Then
            Throw New Exception(mChequePagos(t).OperadorDatos.MsgError)
          End If
        Catch ex As Exception
          MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
      End If
    Next
    llenar_datos()
  End Sub

  Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
    Dim f As New frmcheque
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.ChequePago = Me.mChequePagos(Me.ListViewCheck1.Lista.SelectedIndices(0))
    If f.ShowDialog = DialogResult.OK Then
      llenar_datos()
    End If
  End Sub

End Class
