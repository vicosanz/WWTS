Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
'Imports WWTS.Contabilidad.Reglas
Imports System.Data.SqlClient

Public Class FrmSolicPrestamo
#Region "IOpcion"
  Private mRubro As Rubro = Nothing
  Public WriteOnly Property Rubro() As Rubro
    Set(ByVal value As Rubro)
      mRubro = value
      If value IsNot Nothing Then
        Llenar_datos()
      End If
    End Set
  End Property
#End Region

  Private Sub Llenar_datos()
    MyBase.Titulo = "Solicitud"
    If mRubro Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpSolicPrestamo
      info.DataDefinition.FormulaFields("Titulo").Text = "'Solicitud de'"

      Dim ds As New DSSolicPrestamo
      ds = RetornarSolicPrestamoDS(mRubro)

      info.SetDataSource(ds)
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Function RetornarSolicPrestamoDS(ByVal _Rubro As Rubro) As DSSolicPrestamo
    Dim bReturn As Boolean = True
    Dim dsResult As New DSSolicPrestamo
    With _Rubro.OperadorDatos
      .AgregarParametro("@Entida_Codigo", _Rubro.Entida_Codigo)
      .AgregarParametro("@Patron_Codigo", _Rubro.Patron_Codigo)
      .AgregarParametro("@Contra_Secuencia", _Rubro.Contra_Secuencia)
      .AgregarParametro("@Rubro_Secuencia", _Rubro.Rubro_Secuencia)
      .Comando.CommandText = "proc_SolicPrestamo"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New DSSolicPrestamo
        DataAdapter.Fill(dsResult, "v_solicprestamo")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

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
End Class
