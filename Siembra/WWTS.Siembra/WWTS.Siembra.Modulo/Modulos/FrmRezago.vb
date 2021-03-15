

Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Infoware.Reglas.General
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Microsoft.Office.Interop

Public Class FrmRezago
  Implements IOpcion

  Private Sub FrmAsistencias_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlInvCajas1.op = Sistema.OperadorDatos
    Me.CtlBuscaCajasRezago1.Op = Sistema.OperadorDatos
    Me.CtlZafra1.Op = Sistema.OperadorDatos
    Me.CtlHacienda1.Op = Sistema.OperadorDatos
    Me.CtlListaEmbarque1.Op = Sistema.OperadorDatos
    Me.CtlZafra1.llenar_datos()
    Me.CtlHacienda1.llenar_datos()
    Me.CtlListaEmbarque1.llenar_datos()

    Me.CtlInvCajas1.Restriccion = Restriccion
  End Sub

  Dim cambiarcheck As Boolean
  Dim cambiarlistcheck As Boolean


  Private Sub CtlBuscaCajasRezago1_CambioCaja(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaCajasRezago1.CambioCaja
    Me.CtlInvCajas1.Invcaja = Me.CtlBuscaCajasRezago1.InvCaja
  End Sub

  Private Sub CtrInvCajas1_EliminoInvCaja(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlInvCajas1.EliminoInvCaja
    Me.CtlBuscaCajasRezago1.llenar_datos(1)
  End Sub

  Sub habilitar(ByVal lv As ListView)
    Dim t As Integer
    Dim existe As Boolean = False
    For t = 0 To lv.Items.Count - 1
      If lv.Items(t).Checked Then
        existe = True
      End If
    Next
  End Sub

  Private Sub CtlInvCajas1_AntesNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlInvCajas1.AntesNuevo
    Dim _invcaja As InvCaja
    Dim _cajaant As InvCaja
    _cajaant = Me.CtlInvCajas1.Invcaja
    _invcaja = New InvCaja(Sistema.OperadorDatos, True)
    If Not _cajaant Is Nothing Then
      _invcaja.Semilla = _cajaant.Semilla
      _invcaja.Terreno = _cajaant.Terreno
      _invcaja.Bodega = _cajaant.Bodega
    End If
    _invcaja.Zafra = Me.CtlBuscaCajasRezago1.Zafra
    _invcaja.Caj_tipoNC = Me.CtlBuscaCajasRezago1.TipoTabaco
    Me.CtlInvCajas1.Invcaja = _invcaja
  End Sub

  Private Sub btnmostraretiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostraretiq.Click
    mostrar_etiquetas(Me.numdesde.Value, Me.numhasta.Value, IIf(chkzafra.Checked, Me.CtlZafra1.Zafra, Nothing), IIf(chkponersigla.Checked, Me.CtlHacienda1.Hacienda, Nothing))
  End Sub

  Private Sub mostrar_etiquetas(ByVal _desde As Long, ByVal _hasta As Long, Optional ByVal _Zafra As ZafraSiembra = Nothing, Optional ByVal _hacienda As Hacienda = Nothing)
    If _desde > _hasta Then
      MsgBox("Error en rango de números de etiquetas", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Range("A1").Value = "Zafra"
        .Columns("A:A").NumberFormat = "@"
        .Range("B1").Value = "Numero"
        .Columns("B:B").NumberFormat = "0"
        .Range("C1").Value = "Hacienda"
        .Columns("C:C").NumberFormat = "@"

        Dim h As Integer = 0
        For t As Integer = _desde To _hasta
          If Not _Zafra Is Nothing Then
            .Range("A" & (h + 2).ToString).Value = _Zafra.Zaf_codigo
          End If
          .Range("B" & (h + 2).ToString).Value = t
          If Not _hacienda Is Nothing Then
            .Range("C" & (h + 2).ToString).Value = _hacienda.Hac_codigo.Substring(0, 1)
          End If
          h += 1
        Next
      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\fteetiquetas.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim _config As New ConfigSiembra(Sistema.OperadorDatos)

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(IIf(_config.Cfs_rutaetiq.Trim = String.Empty, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\formatos\etiquetarezago.doc", _config.Cfs_rutaetiq))

      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, String.Format("{0} {1} desde {2} hasta {3} hacienda {4}", "Imprimió etiquetas", Me.CtlZafra1.Zafra.Zaf_descripcion, Me.numdesde.Value, Me.numhasta.Value, Me.CtlHacienda1.Hacienda.Hac_nombre))

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnlistaempaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistaempaque.Click
    Try
      Dim info As ReportClass
      info = New crpListaEmpaque

      info.DataDefinition.FormulaFields("Titulo").Text = "'TABACO EN BODEGA FINCA " & Me.CtlHacienda1.Hacienda.Hac_nombre & "'"
      info.DataDefinition.FormulaFields("Leyenda").Text = "'COSECHA " & Me.CtlZafra1.Zafra.Zaf_codigo & " TABACO CANDELA/NATURAL'"

      Dim ds As New DSListaEmpaque
      Dim tabla As DataTable
      tabla = ds.Tables(0)
      Dim cont As Integer = 0
      For t As Integer = Me.numdesde.Value To Me.numhasta.Value
        Dim fila As DataRow
        fila = tabla.NewRow()
        fila("empaque") = t
        cont += 1
        fila("hoja") = Int((cont - 1) / 40) + 1
        tabla.Rows.Add(fila)
      Next
      tabla.AcceptChanges()

      If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
        MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      Else
        info.SetDataSource(ds)
        info.PrintOptions.PaperSize = PaperSize.PaperFanfoldUS
        Me.crvlistaempaque.Zoom(1)
        Me.crvlistaempaque.ReportSource = info
        Me.crvlistaempaque.DisplayToolbar = True
        Me.crvlistaempaque.ShowRefreshButton = False
        'Me.crvlistaempaque.DisplayGroupTree = False
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, String.Format("{0} {1} desde {2} hasta {3} hacienda {4}", "Imprimió listado de empaque", Me.CtlZafra1.Zafra.Zaf_descripcion, Me.numdesde.Value, Me.numhasta.Value, Me.CtlHacienda1.Hacienda.Hac_nombre))

    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

  Private Sub btnanadiraemb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanadiraemb.Click
    'me.CtlListaEmbarque1
    Dim _Cajas As InvCajaCollection
    _Cajas = Me.CtlBuscaCajasRezago1.CajasSeleccionadas()
    If _Cajas.Count = 0 Then
      Exit Sub
    End If
    Dim _cajasembarcadas As Boolean = False
    For Each _caja As InvCaja In _Cajas
      If _caja.Embarque Is Nothing Then
        _caja.Embarque = Me.CtlListaEmbarque1.Embarque
        _caja.Guardar()
      Else
        _cajasembarcadas = True
      End If
    Next
    Me.CtlListaEmbarque1.llenar_datos()

    If _cajasembarcadas Then
      MsgBox("Existen cajas que ya han sido embarcadas y se han omitido", MsgBoxStyle.Information, "Información")
    End If
  End Sub

  Private Sub btnremoverdeemb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremoverdeemb.Click
    Dim _cajas As InvCajaCollection
    _cajas = Me.CtlListaEmbarque1.Cajasseleccionadas()
    For Each _caja As InvCaja In _cajas
      _caja.Embarque = Nothing
      _caja.Guardar()
    Next
    Me.CtlListaEmbarque1.llenar_datos()
  End Sub

  Private Sub btnimpretiqplancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimpretiqplancha.Click
    If numdesde.Value > Me.numhasta.Value Then
      Exit Sub
    End If
    Dim _dsetiqueta As New dsEtiquetaRezago
    For t As Integer = CType(numdesde.Value, Integer) To CType(numhasta.Value, Integer)
      Dim _fila As dsEtiquetaRezago.vwEtiquetaRezagoRow
      _fila = _dsetiqueta.vwEtiquetaRezago.NewvwEtiquetaRezagoRow
      If Me.chkponersigla.Checked Then
        _fila.Hacienda = Me.CtlHacienda1.Hacienda.Hac_nombre.Trim.Substring(0, 1)
      End If
      _fila.Zafra = Me.CtlZafra1.Zafra.Zaf_codigo
      _fila.Numero = t
      _dsetiqueta.vwEtiquetaRezago.AddvwEtiquetaRezagoRow(_fila)
    Next
    _dsetiqueta.AcceptChanges()
    previoimpretiqplancha(_dsetiqueta)
  End Sub

  Private Sub previoimpretiqplancha(ByVal _dsetiqueta As dsEtiquetaRezago)
    Try
      Dim info As New crpEtiquetaRezago
      info.SetDataSource(_dsetiqueta)

      Me.crvlistaempaque.Zoom(1)
      info.PrintOptions.PaperSize = PaperSize.PaperA4
      Me.crvlistaempaque.ReportSource = info
      Me.crvlistaempaque.DisplayToolbar = True
      Me.crvlistaempaque.ShowRefreshButton = False
      'Me.crvlistaempaque.DisplayGroupTree = False
    Catch Exp As LoadSaveReportException
      MsgBox("Incorrect path for loading report.", _
       MsgBoxStyle.Critical, "Load Report Error")
    Catch Exp As Exception
      MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
    End Try
  End Sub


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _Restriccion)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual))
  End Sub
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return pnlCuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Nothing 'Me.MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

End Class