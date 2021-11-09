
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base

Public Class FrmMetereologia
    Implements IDatos, IOpcion

    Private mOp As OperadorDatos
    Public Property Op() As OperadorDatos Implements IDatos.Op
        Get
            Return mOp
        End Get
        Set(ByVal value As OperadorDatos)
            mOp = value
            Me.CtlTerreno1.Op = Op
            Me.CtlTerreno1.llenar_datos()
        End Set
    End Property

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            For Each medicion As Metereologia In mediciones
                If Not medicion.Guardar Then
                    Throw New Exception(medicion.OperadorDatos.MsgError)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Llenar_datos()
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
#End Region

    Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        Op = Sistema.OperadorDatos
    End Sub

    Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
        Get
            Return Panel1
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

    Dim mediciones As MetereologiaCollection
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Llenar_datos()
    End Sub

    Private Sub Llenar_datos()
        mediciones = Metereologia.RetornarMetereologiaFiltro(mOp, CtlTerreno1.Terreno, LblDatePickerStd1.Value.Date)
        If mediciones.Count() = 0 Then
            For h As Integer = 0 To 23
                Dim medicion As New Metereologia(mOp, CtlTerreno1.Terreno, LblDatePickerStd1.Value.Date, h, True)
                mediciones.Add(medicion)
            Next
        End If
        BSMediciones.DataSource = mediciones
        DGMediciones.AutoDiscover()
    End Sub
End Class