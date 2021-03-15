Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas

Public Class FrmConfiguracion
  Implements IOpcion

  Private mControl As UserControl

  Private Sub FrmConfRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    llenar_lista()
  End Sub

  Sub llenar_lista()
    Me.tvconfigurar.Nodes.Clear()
    'Me.tvconfigurar.Nodes.Add("Feriados")
    'Me.tvconfigurar.Nodes.Add("Impuesto Renta")
    Me.tvconfigurar.Nodes.Add("Parámetros del Seguro Social")
    'Me.tvconfigurar.Nodesms.Add("Cuentas contables")
    Me.tvconfigurar.SelectedNode = Me.tvconfigurar.Nodes(0)
  End Sub

  Private Sub tvconfigurar_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvconfigurar.AfterSelect
    mostrar(e.Node.Text)
  End Sub

  Sub mostrar(ByVal opcion As String)
    Select Case opcion
      'Case "Feriados"
      '  Try
      '    mControl.Dispose()
      '  Catch ex As Exception
      '  End Try
      '  mControl = New CtlFeriados
      '  CType(mControl, CtlFeriados).op = Sistema.OperadorDatos
      '  pnlopcion.Controls.Add(mControl)
      '  mControl.Dock = DockStyle.Fill
      '  mControl.BringToFront()
      'Case "Impuesto Renta"
      '  Try
      '    mControl.Dispose()
      '  Catch ex As Exception
      '  End Try
      '  mControl = New CtlIR
      '  CType(mControl, CtlIR).op = Sistema.OperadorDatos
      '  pnlopcion.Controls.Add(mControl)
      '  mControl.Dock = DockStyle.Fill
      '  mControl.BringToFront()
      Case "Parámetros del Seguro Social"
        Try
          mControl.Dispose()
        Catch ex As Exception
        End Try
        mControl = New CtlConfigRoles
        CType(mControl, CtlConfigRoles).op = Sistema.OperadorDatos
        pnlopcion.Controls.Add(mControl)
        mControl.Dock = DockStyle.Fill
        mControl.BringToFront()
        'Case "Cuentas contables"
        '  Try
        '    mControl.Dispose()
        '  Catch ex As Exception
        '  End Try
        '  mControl = New CtlCuentaCtble
        '  CType(mControl, CtlCuentaCtble).op = Op
        '  pnlopcion.Controls.Add(mControl)
        '  mControl.Dock = DockStyle.Fill
        '  mControl.BringToFront()
    End Select
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
    Me.Text = "Configuración"
    llenar_lista()
  End Sub

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
End Class