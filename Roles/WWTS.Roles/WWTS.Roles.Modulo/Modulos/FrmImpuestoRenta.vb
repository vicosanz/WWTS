Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports Microsoft.Office.Interop

Public Class FrmImpuestoRenta
  Implements IOpcion

  Private mContrato As Contrato = Nothing
  Public Property Contrato() As Contrato
    Get
      Return mContrato
    End Get
    Set(ByVal Value As Contrato)
      mContrato = Value
    End Set
  End Property

  Private mGastosPersonalesList As GastosPersonalesList
  Sub Llenar_datos()

    If Contrato Is Nothing Then
      Me.bsGastosPersonales.DataSource = Nothing
      Exit Sub
    End If

    Me.DataGridViewGastos.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_mes_letra"
    DataGridViewTextBoxColumn1.HeaderText = "Mes"
    DataGridViewTextBoxColumn1.Width = 75
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Sueldo"
    DataGridViewTextBoxColumn1.HeaderText = "Sueldo"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_SubMaternidad"
    DataGridViewTextBoxColumn1.HeaderText = "SubMaternidad"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_SubEnfermedad"
    DataGridViewTextBoxColumn1.HeaderText = "SubEnfermedad"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Vacaciones"
    DataGridViewTextBoxColumn1.HeaderText = "Vacaciones"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Horas25"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 25%"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Horas50"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 50%"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Horas100"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 100%"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Horas100b"
    DataGridViewTextBoxColumn1.HeaderText = "Horas 100b%"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Bonos"
    DataGridViewTextBoxColumn1.HeaderText = "Bonos Produccion"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_BonoMeta"
    DataGridViewTextBoxColumn1.HeaderText = "Bono Meta"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_BonosOtros"
    DataGridViewTextBoxColumn1.HeaderText = "Bonificacion Especial"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_IngresoVivienda"
    DataGridViewTextBoxColumn1.HeaderText = "Vivienda"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_SueldoSinAp"
    DataGridViewTextBoxColumn1.HeaderText = "Sueldo Sin Ap"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_SobretiempoSinAp"
    DataGridViewTextBoxColumn1.HeaderText = "Sobretiempo Sin Ap"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_IngresoAlimentacion"
    DataGridViewTextBoxColumn1.HeaderText = "Alimentación"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Transporte"
    DataGridViewTextBoxColumn1.HeaderText = "Transporte"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Utilidades"
    DataGridViewTextBoxColumn1.HeaderText = "Utilidades"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Aporte"
    DataGridViewTextBoxColumn1.HeaderText = "Aporte IESS"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_SueldoOtros"
    DataGridViewTextBoxColumn1.HeaderText = "Sueldo Otros"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_SobretiempoOtros"
    DataGridViewTextBoxColumn1.HeaderText = "Sobretiempo Otros"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_VacacionesOtros"
    DataGridViewTextBoxColumn1.HeaderText = "Vacaciones Otros"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_UtilidadesOtros"
    DataGridViewTextBoxColumn1.HeaderText = "Utilidades Otros"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_AporteOtros"
    DataGridViewTextBoxColumn1.HeaderText = "Aporte Otros"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Vivienda"
    DataGridViewTextBoxColumn1.HeaderText = "Gastos Vivienda"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Salud"
    DataGridViewTextBoxColumn1.HeaderText = "Gastos Salud"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Educacion"
    DataGridViewTextBoxColumn1.HeaderText = "Gastos Educación"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Alimentacion"
    DataGridViewTextBoxColumn1.HeaderText = "Gastos Alimentación"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_Vestimenta"
    DataGridViewTextBoxColumn1.HeaderText = "Gastos Vestimenta"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Gastos_ImpuestoRenta"
    DataGridViewTextBoxColumn1.HeaderText = "Impuesto Renta"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    mGastosPersonalesList = GastosPersonalesList.ObtenerLista(Contrato, NumericAnio.Value, ComboBoxGastoPersonal.ParametroDet)
    If mGastosPersonalesList.Count = 0 Then
      Dim _sueldo As Rubro = Rubro.ObtenerSueldoxContrato(Contrato)
      Dim mIRlist As GastosPersonalesList = New GastosPersonalesList()
      Dim mIR As GastosPersonales

      Dim i As Integer
      For i = 1 To 12
        mIR = New GastosPersonales(Contrato.OperadorDatos, True)
        mIR.Entida_Codigo = Contrato.Entida_Codigo
        mIR.Patron_Codigo = Contrato.Patron_Codigo
        mIR.Contra_Secuencia = Contrato.Contra_Secuencia
        mIR.Gastos_Sueldo = _sueldo.Total
        mIR.Gastos_anio = NumericAnio.Value
        mIR.Gastos_mes = i
        mIR.PardetTipoGasto = ComboBoxGastoPersonal.ParametroDet
        '1 presupuestado --- 2 real
        If ComboBoxGastoPersonal.ParametroDet.Pardet_Secuencia = 1 Then
          mIR.Gastos_Sueldo = _sueldo.Total
        Else
          mIR.Gastos_Sueldo = 0
        End If
        mIRlist.Add(mIR)
      Next i

      bsGastosPersonales.DataSource = mIRlist
    Else
      bsGastosPersonales.DataSource = mGastosPersonalesList
    End If

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

  Private Sub FrmImpuestoRenta_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Impuesto Renta"

    Me.CtlBuscaEmpleados1.Usuario = Sistema.Usuario
    Me.CtlBuscaEmpleados1.Op = Sistema.OperadorDatos

    Me.ComboBoxGastoPersonal.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxGastoPersonal.Parametro = Enumerados.EnumParametros.TipoGastoPersonal
    Me.ComboBoxGastoPersonal.Llenar_Datos()

    Me.txtValorTope.Value = 11973

    Me.NumericAnio.Value = Date.Now.Year
  End Sub
#End Region

#Region "CtlBuscaEmpleados1"
  Private Sub CtlBuscaEmpleados1_CambioEmpleado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBuscaEmpleados1.CambioEmpleado
    Contrato = Me.CtlBuscaEmpleados1.Contrato
    bsGastosPersonales.DataSource = Nothing
  End Sub
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    DataGridViewGastos.EndEdit()
    If Validar() Then
      Sistema.OperadorDatos.ComenzarTransaccion()
      Try
        For Each _registro As GastosPersonales In bsGastosPersonales
          If Not _registro.Guardar() Then
            Throw New Exception(_registro.OperadorDatos.MsgError)
          End If
        Next

        Sistema.OperadorDatos.TerminarTransaccion()

        For Each _registro As GastosPersonales In bsGastosPersonales
          _registro.AceptarCambios()
        Next

        MsgBox("Se guardó satisfactoriamente", MsgBoxStyle.Information, "Información")
      Catch ex As Exception
        Sistema.OperadorDatos.CancelarTransaccion()
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Exit Sub
      End Try
    End If
  End Sub

  Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
    Llenar_datos()
  End Sub

  Public Function Validar() As Boolean
    Dim ingresos As Decimal = 0
    Dim egresos As Decimal = 0
    If txtValorTope.Value > 0 Then
      For Each _registro As GastosPersonales In bsGastosPersonales
        ingresos += _registro.SumaIngresos
        egresos += _registro.SumaGastos
      Next
      If egresos > (ingresos / 2) Or egresos > txtValorTope.Value Then
        MsgBox("La deducción total por gastos personales no podrá superar el 50% del total de sus ingresos gravados, ni tampoco un valor superior a $" + txtValorTope.Value.ToString, MsgBoxStyle.Critical, "Error")
        Return False
      Else
        If Me.NumericAnio.Value = 2011 Then
          Dim gastos As Decimal = 0
          Dim mreturn As Boolean = True

          For Each _fila As GastosPersonales In bsGastosPersonales
            gastos += _fila.Gastos_Vestimenta
          Next
          If gastos > 2993.25 Then
            MsgBox("Gastos de vestimenta, no podrán superar el límite del 0.325 de la fracción básica, es decir $2.993,25", MsgBoxStyle.Critical, "Error")
            mreturn = False
          End If

          gastos = 0
          For Each _fila As GastosPersonales In bsGastosPersonales
            gastos += _fila.Gastos_Vivienda
          Next
          If gastos > 2993.25 Then
            MsgBox("Gastos de vivienda, no podrán superar el límite del 0.325 de la fracción básica, es decir $2.993,25", MsgBoxStyle.Critical, "Error")
            mreturn = False
          End If

          gastos = 0
          For Each _fila As GastosPersonales In bsGastosPersonales
            gastos += _fila.Gastos_Educacion
          Next
          If gastos > 2993.25 Then
            MsgBox("Gastos de educación,no podrán superar el límite del 0.325 de la fracción básica, es decir $2.993,25", MsgBoxStyle.Critical, "Error")
            mreturn = False
          End If

          gastos = 0
          For Each _fila As GastosPersonales In bsGastosPersonales
            gastos += _fila.Gastos_Alimentacion
          Next
          If gastos > 2993.25 Then
            MsgBox("Gastos de alimentación, no podrán superar el límite del 0.325 de la fracción básica, es decir $2.993,25", MsgBoxStyle.Critical, "Error")
            mreturn = False
          End If

          gastos = 0
          For Each _fila As GastosPersonales In bsGastosPersonales
            gastos += _fila.Gastos_Salud
          Next
          If gastos > 11973 Then
            MsgBox("Gastos de salud, no podrán superar el límite del 1.3  de la fracción básica, es decir $11.973", MsgBoxStyle.Critical, "Error")
            mreturn = False
          End If
          If Not mreturn Then
            Return mreturn
          End If
        End If
      End If
      Return True
    Else
      MsgBox("Ingresar valor tope", MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub DataGridViewGastos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewGastos.CellEndEdit
    Validar()
  End Sub

  Private Sub FormatoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormatoToolStripMenuItem.Click
    Dim f As New FrmFormato(Sistema, Enumerados.EnumOpciones.Personal)
    f.ShowDialog()
  End Sub

End Class