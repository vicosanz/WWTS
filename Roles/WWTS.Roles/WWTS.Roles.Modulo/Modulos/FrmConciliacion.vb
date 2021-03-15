Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic.CompilerServices
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmConciliacion
  Implements IOpcion

  Public ReadOnly Property ToolStrip As ToolStrip Implements IOpcion.ToolStrip
    Get
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property MenuStrip As MenuStrip Implements IOpcion.MenuStrip
    Get
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property Control As Control Implements IOpcion.Control
    Get
      Return Pnlcuerpo
    End Get
  End Property


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

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Text = "Configuración"
    Me.cboBanco.Parametro = Enumerados.EnumParametros.Banco
    Me.CboCtaBancaria.Parametro = Enumerados.EnumParametros.CuentaBancaria
    Me.CboCtaBancaria.OperadorDatos = Me.Sistema.OperadorDatos
    Me.cboBanco.OperadorDatos = Me.Sistema.OperadorDatos
    Me.cboBanco.Llenar_Datos()
  End Sub

  Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
    If String.IsNullOrWhiteSpace(Me.txtarchivo.Text) Then
      MsgBox("Debe seleccionar un archivo válido", MsgBoxStyle.Critical, "Error")
    ElseIf (Me.CboCtaBancaria.ParametroDet Is Nothing) Then
      MsgBox("Debe seleccionar una cuenta bancaria", MsgBoxStyle.Critical, "Error")
    Else
      If Not Me.validar() Then
        Return
      End If
      MsgBox("Proceso terminado", MsgBoxStyle.Information, "Información")
      Me.txtarchivo.Text = String.Empty
    End If
  End Sub

  Private Function validar() As Boolean
    Dim application = New Microsoft.Office.Interop.Excel.Application
    Dim flag As Boolean
    Try
      Dim workbook As Workbook = application.Workbooks.Open(Me.txtarchivo.Text)
      Dim name As String = My.Computer.FileSystem.GetFileInfo(Me.txtarchivo.Text).Name
      Dim worksheet1 As Worksheet = workbook.Worksheets(0)
      application.Visible = False
      With worksheet1
        If Not CStr(.Range("A1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser FECHA")
        End If
        If Not CStr(.Range("B1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser CODIGO")
        End If
        If Not CStr(.Range("C1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser CONCEPTO")
        End If
        If Not CStr(.Range("D1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser TIPO")
        End If
        If Not CStr(.Range("E1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser DOCUMENTO")
        End If
        If Not CStr(.Range("F1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser OFICINA")
        End If
        If Not CStr(.Range("G1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser MONTO")
        End If
        If Not CStr(.Range("H1").Value).ToUpper = "FECHA" Then
          Throw New InvalidExpressionException("La columna A1 debe ser SALDO")
        End If
        Dim t As Integer = 2
        While Not (.Range("A" & t.ToString.Trim).Value Is Nothing And .Range("B" & t.ToString.Trim).Value Is Nothing)
          Dim datetime As DateTime = New DateTime()
          Dim num2 As Integer = 0
          Dim empty1 As String = String.Empty
          Dim empty2 As String = String.Empty
          Dim num3 As Integer = 0
          Dim empty3 As String = String.Empty
          Dim num4 As Decimal = 0
          Dim num5 As Decimal = 0

          If Not .Range("A" & t.ToString.Trim).Value Is Nothing Then
            datetime = CDate(.Range("A" & t.ToString.Trim).Value)
          End If
          If Not .Range("B" & t.ToString.Trim).Value Is Nothing Then
            num2 = CStr(.Range("B" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("C" & t.ToString.Trim).Value Is Nothing Then
            empty1 = CStr(.Range("C" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("D" & t.ToString.Trim).Value Is Nothing Then
            empty2 = CStr(.Range("D" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("E" & t.ToString.Trim).Value Is Nothing Then
            num3 = CInt(.Range("E" & t.ToString.Trim).Value)
          End If
          If Not .Range("F" & t.ToString.Trim).Value Is Nothing Then
            empty3 = CStr(.Range("F" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("G" & t.ToString.Trim).Value Is Nothing Then
            num4 = CDec(.Range("G" & t.ToString.Trim).Value)
          End If
          If Not .Range("H" & t.ToString.Trim).Value Is Nothing Then
            num5 = CDec(.Range("H" & t.ToString.Trim).Value)
          End If
          If num2 > 0 Then
            Try
              Dim conciliacion As Conciliacion = New Conciliacion(Me.Sistema.OperadorDatos, True)
              conciliacion.PardetCuentaBancaria = Me.CboCtaBancaria.ParametroDet
              conciliacion.Concil_Lote = name
              conciliacion.Concil_Fecha = datetime
              conciliacion.Concil_Codigo = num2
              conciliacion.Concil_Concepto = empty1
              conciliacion.Concil_Tipo = empty2
              conciliacion.Concil_Documento = num3
              conciliacion.Concil_Oficina = empty3
              conciliacion.Concil_Monto = num4
              conciliacion.Concil_Saldo = num5
              If Not conciliacion.Guardar() Then
                Throw New Exception(conciliacion.OperadorDatos.MsgError)
              End If
            Catch ex As Exception
              Throw New Exception(ex.Message)
            End Try
          End If
          t += 1
        End While
        application.Visible = True
        application.Quit()
        application.Quit()
        flag = True
      End With
    Catch ex As Exception
      MsgBox(ex.Message & vbCrLf & "No se puede continuar.", MsgBoxStyle.Critical, "Error")
      application.Quit()
      flag = False
    End Try
    Return flag
  End Function

  Private Sub btnbuscararch_Click(sender As Object, e As EventArgs) Handles btnbuscararch.Click
    Dim ofd As OpenFileDialog = Me.ofd
    ofd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
    If ofd.ShowDialog() = DialogResult.OK Then
      Me.txtarchivo.Text = ofd.FileName
    End If
  End Sub

  Private Sub cboBanco_CambioItem(sender As Object, e As EventArgs) Handles cboBanco.CambioItem
    Me.CboCtaBancaria.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, Me.cboBanco.ParametroDet)
  End Sub

  Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    If String.IsNullOrWhiteSpace(Me.txtarchivo.Text) Then
      MsgBox("Debe seleccionar un archivo válido", MsgBoxStyle.Critical, "Error")
    ElseIf Me.CboCtaBancaria.ParametroDet Is Nothing Then
      MsgBox("Debe seleccionar una cuenta bancaria", MsgBoxStyle.Critical, "Error")
    Else
      If Not Me.eliminar() Then
        Return
      End If
      MsgBox("Proceso terminado", MsgBoxStyle.Information, "Información")
      Me.txtarchivo.Text = String.Empty
    End If
  End Sub

  Private Function eliminar() As Boolean
    Dim flag As Boolean
    Try
      flag = ConciliacionList.Eliminar(Me.Sistema.OperadorDatos, My.Computer.FileSystem.GetFileInfo(Me.txtarchivo.Text).Name, Me.CboCtaBancaria.ParametroDet)
    Catch ex As Exception
      MsgBox(ex.Message + vbCrLf + "No se puede continuar", MsgBoxStyle.Critical, "Error")
      flag = False
    End Try
    Return flag
  End Function
End Class
