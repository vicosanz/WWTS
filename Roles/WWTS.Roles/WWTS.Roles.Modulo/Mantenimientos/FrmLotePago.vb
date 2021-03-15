Imports Infoware.Reglas
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports System.Globalization.CultureInfo
Imports Microsoft.Office.Interop
Imports WWTS.General.Modulo

Public Class FrmLotePago
  Implements IMantenimiento

  Private mLotePago As LotePago
  Public Property LotePago() As LotePago
    Get
      Return mLotePago
    End Get
    Set(ByVal Value As LotePago)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un LotePago")
      End If
      mLotePago = Value

      Me.cbotipopago.OperadorDatos = Value.OperadorDatos
      Me.cbotipopago.Parametro = Enumerados.EnumParametros.MotivoPago
      Me.cbotipopago.Llenar_Datos()

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
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          validar()
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    MsgBox("Si desea ingresar un pago a una persona sin código, entonces llene el campo de NOMBRE y deje vacio el campo CODIGO", MsgBoxStyle.Information, "Información")
    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 15
        .Range("A1").Value = "Codigo"
        '.Columns("A:A").NumberFormat = "@"
        .Range("B1").Value = "Nombre"
        .Columns("B:B").ColumnWidth = 35
        .Range("C1").Value = "Valor"
        .Columns("C:C").numberformat = "0" & CurrentCulture.NumberFormat.CurrencyDecimalSeparator & "00"
      End With
      excelApp.Visible = True
    Catch ex As Exception
    End Try
  End Sub

  Private Sub btnbuscararch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscararch.Click
    With ofd
      .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Temp
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.txtarchivo.Text = .FileName
      End If
    End With
  End Sub

  Function validar() As Boolean
    Dim excelApp As New Excel.Application
    Try
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Open(Me.txtarchivo.Text)
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)

      excelApp.Visible = False
      With excelWorksheet
        If Not CStr(.Range("A1").Value).ToUpper = "CODIGO" Then
          Throw New InvalidExpressionException("La columna A1 debe ser CODIGO")
        End If
        If Not CStr(.Range("B1").Value).ToUpper = "NOMBRE" Then
          Throw New InvalidExpressionException("La columna B1 debe ser NOMBRE")
        End If
        If Not CStr(.Range("C1").Value).ToUpper = "VALOR" Then
          Throw New InvalidExpressionException("La columna C1 debe ser VALOR")
        End If
        Dim t As Integer = 2
        While Not (.Range("A" & t.ToString.Trim).Value Is Nothing And .Range("B" & t.ToString.Trim).Value Is Nothing)
          Dim codigo As String = String.Empty
          Dim nombre As String = String.Empty
          Dim valor As Decimal = 0.0

          If Not .Range("A" & t.ToString.Trim).Value Is Nothing Then
            codigo = CStr(.Range("A" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("B" & t.ToString.Trim).Value Is Nothing Then
            nombre = CStr(.Range("B" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("C" & t.ToString.Trim).Value Is Nothing Then
            valor = CDec(.Range("C" & t.ToString.Trim).Value)
          End If
          If Not String.IsNullOrWhiteSpace(codigo) Then
            Try
              Dim ident As New EntidadIdentificacion(LotePago.OperadorDatos, New WWTSParametroDet(LotePago.OperadorDatos, Enumerados.EnumParametros.TipoIdentificacion, Enumerados.enumTipoIdentificacion.CodigoEmpleado), codigo)
              Dim pers As New Empleado(Me.LotePago.OperadorDatos, ident.Entida_Codigo)
            Catch ex As Exception
              Throw New InvalidExpressionException("El código " & codigo & " no se encuentra" & vbCrLf & "Error en la fila " & t.ToString.Trim)
            End Try
          End If

          If valor <= 0 Then
            Throw New InvalidExpressionException("El valor del pago no puede ser negativo o cero" & vbCrLf & "Error en la fila " & t.ToString.Trim)
          End If
          t += 1
        End While

        t = 2
        While Not (.Range("A" & t.ToString.Trim).Value Is Nothing And .Range("B" & t.ToString.Trim).Value Is Nothing)
          Dim codigo As String = String.Empty
          Dim nombre As String = String.Empty
          Dim valor As Decimal = 0.0

          If Not .Range("A" & t.ToString.Trim).Value Is Nothing Then
            codigo = CStr(.Range("A" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("B" & t.ToString.Trim).Value Is Nothing Then
            nombre = CStr(.Range("B" & t.ToString.Trim).Value).Trim
          End If
          If Not .Range("C" & t.ToString.Trim).Value Is Nothing Then
            valor = CDec(.Range("C" & t.ToString.Trim).Value)
          End If

          Dim pagovario As New LotePagoVarioDetalle(mLotePago)
          If Not String.IsNullOrWhiteSpace(codigo) Then
            Dim _iden As EntidadIdentificacion
            Try
              _iden = New EntidadIdentificacion(LotePago.OperadorDatos, New WWTSParametroDet(LotePago.OperadorDatos, Enumerados.EnumParametros.TipoIdentificacion, Enumerados.enumTipoIdentificacion.CodigoEmpleado), codigo)
              pagovario.Entida_Codigo = _iden.Entida_Codigo
            Catch ex As Exception
              _iden = Nothing
            End Try
          End If
          pagovario.LoPaDe_Beneficiario = nombre

          pagovario.LoPaDe_ValorPago = valor
          pagovario.PardetTipoPagoNomina = Me.cbotipopago.ParametroDet
          pagovario.LoPaDe_Observacion = Me.txtobservacion.Text
          If Not pagovario.Guardar Then
            Throw New Exception(pagovario.OperadorDatos.MsgError)
          End If
          t += 1
        End While
      End With
      excelApp.Visible = True
      excelApp.Quit()
      excelApp.Quit()
      Return True
    Catch ex As Exception
      MsgBox(ex.Message & vbCrLf & "No se puede continuar.", MsgBoxStyle.Critical, "Error")
      excelApp.Quit()
      Return False
    End Try
  End Function

  Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Open(Me.txtarchivo.Text)
      Dim excelWorksheet As Excel.Worksheet = _
       CType(excelBook.Worksheets(1), Excel.Worksheet)

      excelApp.Visible = True
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub FrmLotePago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class
