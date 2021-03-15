Imports WWTS.General.Reglas

Imports WWTS.Siembra.Reglas
Imports Infoware.Datos

Public Class CtlListaEmbarque
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Me.CtlEmbarque1.Op = value
      If Not value Is Nothing Then
        Me.CtlEmbarque1.llenar_datos()
      End If
    End Set
  End Property

  Dim cambiarcheck As Boolean = False
  Dim cambiarlistcheck As Boolean = False

  Public Property Embarque() As Embarque
    Get
      Return Me.CtlEmbarque1.Embarque
    End Get
    Set(ByVal Value As Embarque)
      Me.CtlEmbarque1.Embarque = Value
    End Set
  End Property

  Public ReadOnly Property Cajasseleccionadas() As InvCajaCollection
    Get
      Dim _cajas As New InvCajaCollection
      For Each _item As ListViewItem In Me.lvcajas.Items
        If _item.Checked Then
          _cajas.Add(CType(_item.Tag, InvCaja))
        End If
      Next
      Return _cajas
    End Get
  End Property

  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    Dim _cajas As New InvCajaCollection
    For Each _item As ListViewItem In Me.lvcajas.Items
      If _item.Checked Then
        _cajas.Add(CType(_item.Tag, InvCaja))
      End If
    Next
    If _cajas Is Nothing OrElse _cajas.Count = 0 Then
      Exit Sub
    End If
    If MsgBox("Desea ver el reporte en forma resumida", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
      Dim _rescajas As ResumenInvCajaCollection
      _rescajas = InvCaja.RetornarInvCajaFiltroResumen(Me.mOp, Me.CtlEmbarque1.Embarque)

      ExcelReporte.InvCajaReporte.ExportarExcelresumido(_cajas, _rescajas)
    Else
      ExcelReporte.InvCajaReporte.ExportarExceldetallado(_cajas)
    End If
  End Sub

  Private Sub CtlEmbarque1_CambioEmbarque() Handles CtlEmbarque1.CambioEmbarque
    llenar_datos()
  End Sub

  Public Sub llenar_datos()
    If mOp Is Nothing Or Me.CtlEmbarque1.Embarque Is Nothing Then
      Exit Sub
    End If
    Dim _cajas As InvCajaCollection
    _cajas = InvCaja.RetornarInvCajaFiltro(Me.mOp, Me.CtlEmbarque1.Embarque)
    Me.chklv.Checked = False
    Me.lvcajas.Items.Clear()
    If _cajas Is Nothing OrElse _cajas.Count = 0 Then
      Exit Sub
    End If
    For Each _caja As InvCaja In _cajas
      Dim _item As New ListViewItem(_caja.Caj_empNum.ToString())
      _item.SubItems.Add(_caja.Caj_embNum.ToString())
      _item.SubItems.Add(_caja.ClaseHoja.Cla_nombre)
      If _caja.ColorHoja Is Nothing Then
        _item.SubItems.Add("")
      Else
        _item.SubItems.Add(_caja.ColorHoja.Col_nombre)
      End If
      _item.SubItems.Add(_caja.Corte.Cor_nombre)
      _item.SubItems.Add(_caja.Semilla.Sem_nombre)
      _item.SubItems.Add(_caja.Terreno.Trr_nombre)
      _item.SubItems.Add(_caja.Caj_Peso.ToString("0.00"))
      _item.SubItems.Add(Enumerados.TipoTabacoList.RetornarDescripcion(CInt(_caja.Caj_tipoNC)))
      _item.Tag = _caja
      Me.lvcajas.Items.Add(_item)
    Next

    Dim _rescajas As ResumenInvCajaCollection
    _rescajas = InvCaja.RetornarInvCajaFiltroResumen(Me.mOp, Me.CtlEmbarque1.Embarque)
    If _rescajas Is Nothing OrElse _rescajas.Count = 0 Then
      Exit Sub
    End If

    Dim _sumpeso As Decimal = 0
    Dim _sumtara As Decimal = 0
    lvresumen.Items.Clear()
    For Each _rescaja As ResumenInvCaja In _rescajas
      Dim _item As New ListViewItem(_rescaja.NumCajas.ToString())
      _item.SubItems.Add(_rescaja.Terreno.Trr_nombre)
      _item.SubItems.Add(Enumerados.TipoTabacoList.RetornarDescripcion(CInt(_rescaja.Caj_tipoNC)))
      _item.SubItems.Add(_rescaja.Semilla.Sem_nombre)
      _item.SubItems.Add(_rescaja.Peso.ToString("0.00"))
      _item.SubItems.Add(_rescaja.Tara.ToString("0.00"))
      _item.SubItems.Add(_rescaja.PesoNeto.ToString("0.00"))
      _sumpeso += _rescaja.Peso
      _sumtara += _rescaja.Tara
      Me.lvresumen.Items.Add(_item)
    Next
    Try
      Dim _item As New ListViewItem
      _item.Font = New Font(_item.Font, FontStyle.Bold)
      _item.SubItems.Add("")
      _item.SubItems.Add("")
      _item.SubItems.Add("")
      _item.SubItems.Add(_sumpeso.ToString("0.00"))
      _item.SubItems.Add(_sumtara.ToString("0.00"))
      _item.SubItems.Add(Decimal.Subtract(_sumpeso, _sumtara).ToString("0.00"))
      lvresumen.Items.Add(_item)
    Catch
    End Try
  End Sub

  Private Sub chklv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklv.CheckedChanged
    If cambiarlistcheck Then
      Exit Sub
    End If
    Dim t As Integer
    cambiarcheck = True
    For t = 0 To Me.lvcajas.Items.Count - 1
      Me.lvcajas.Items(t).Checked = Me.chklv.Checked
    Next
    cambiarcheck = False
  End Sub

  Private Sub lvcajas_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvcajas.ItemCheck
    If cambiarcheck Then
      Exit Sub
    End If
    Me.cambiarlistcheck = True
    Dim sicheck As Boolean = True
    Dim nocheck As Boolean = True
    Dim t As Integer
    For t = 0 To Me.lvcajas.Items.Count - 1
      If e.Index = t Then
        If e.NewValue = CheckState.Checked Then
          nocheck = False
        Else
          sicheck = False
        End If
      Else
        If Me.lvcajas.Items(t).Checked Then
          nocheck = False
        Else
          sicheck = False
        End If
      End If
    Next
    If sicheck Then
      Me.chklv.CheckState = CheckState.Checked
    ElseIf nocheck Then
      Me.chklv.CheckState = CheckState.Unchecked
    Else
      Me.chklv.Checked = True
      Me.chklv.CheckState = CheckState.Indeterminate
    End If
    Me.cambiarlistcheck = False
  End Sub

  Private Sub btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportar.Click
    Dim archivo As String = String.Empty
    With ofd
      .Filter = """Archivos de Microsoft Excel (*.xls)|*xls|Todos los archivos (*.*)|*.*"""
      .Title = "Seleccionar archivo de cajas"

      .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Temp
      If .ShowDialog() = DialogResult.OK Then
        archivo = .FileName
      End If
    End With
    If archivo.Trim = String.Empty Then
      Exit Sub
    End If

    ExcelReporte.InvCajaReporte.CapturarExcel(mOp, archivo)

    Me.llenar_datos()
  End Sub

End Class
