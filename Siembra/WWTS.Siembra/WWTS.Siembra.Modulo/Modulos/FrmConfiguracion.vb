
Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base

Public Class FrmConfiguracion
  Implements IDatos, IOpcion

  Private mOp As OperadorDatos
  Public Property Op() As OperadorDatos Implements IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
      Llenar_datos()
    End Set
  End Property

  Private mConfigSiembra As ConfigSiembra

  Sub Llenar_datos()
    If mOp Is Nothing Then
      Exit Sub
    End If
    mConfigSiembra = New ConfigSiembra(Me.Op)
    Me.txtempaque.Text = mConfigSiembra.Cfs_empaque.ToString("0")
    Me.txttara.Text = mConfigSiembra.Cfs_tara.ToString("0.00")
    Me.btnrutaetiqueta.Text = mConfigSiembra.Cfs_rutaetiq
    Me.txtensarte.Text = mConfigSiembra.Cfs_ensarte.ToString("0")
    Me.txtbloques.Text = mConfigSiembra.Cfs_bloque.ToString("0")
  End Sub

  Private Sub btnrutaetiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrutaetiqueta.Click
    With ofd
      .Title = "Ruta de formato de etiqueta"
      .CheckFileExists = True
      .InitialDirectory = Application.StartupPath & "\formatos\"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.btnrutaetiqueta.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      mConfigSiembra.Cfs_empaque = CInt(Me.txtempaque.Text)
      mConfigSiembra.Cfs_tara = CDec(Me.txttara.Text)
      mConfigSiembra.Cfs_rutaetiq = Me.btnrutaetiqueta.Text
      mConfigSiembra.Cfs_ensarte = CInt(Me.txtensarte.Text)
      mConfigSiembra.Cfs_bloque = CInt(Me.txtbloques.Text)

      If Not mConfigSiembra.Guardar Then
        Throw New Exception(mConfigSiembra.OperadorDatos.MsgError)
      End If
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
End Class