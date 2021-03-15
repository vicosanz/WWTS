Imports Infoware.Reglas.General
Imports WWTS.General.Reglas
Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports WWTS.General.Controles

Public Class FrmMenuEmpresa
  Dim _Toolstrip As ToolStrip = Nothing
  Dim _MenuStrip As MenuStrip = Nothing
  Dim _Control As Control = Nothing

  Public Overrides ReadOnly Property ControlCuerpo() As System.Windows.Forms.Control
    Get
      If Sistema Is Nothing Then
        Return Nothing
        Exit Property
      End If

      onnoFullScreen()

      _Toolstrip = Nothing
      _MenuStrip = Nothing
      _Control = Nothing

      Dim mOpcion As Enumerados.EnumOpciones = CType(OpcionActual, Enumerados.EnumOpciones)

      Dim f As IOpcion = RetornarOpcion(mOpcion)
      If f IsNot Nothing Then
        _Toolstrip = f.ToolStrip
        _MenuStrip = f.MenuStrip
        _Control = f.Control
      End If

      onCambioToolStripMenu()
      onCambioMenuStrip()
      Return _Control
    End Get
  End Property

  Private Sub FrmMenuEmpresa_AbrirNuevaVentana(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Me.AbrirNuevaVentana
    Dim mOpcion As Enumerados.EnumOpciones = CType(e.Node.Tag, Enumerados.EnumOpciones)
    Dim f As FrmFormaBase = RetornarOpcion(mOpcion, True)
    If f IsNot Nothing Then
      f.Show()
    End If
  End Sub

  Public Function RetornarOpcion(ByVal mOpcion As Enumerados.EnumOpciones, Optional ByVal _enNuevaVentana As Boolean = False) As FrmFormaBase
    Select Case mOpcion
      Case Enumerados.EnumOpciones.Empresa
        If BarraRegistroContable1.Empresa Is Nothing Then
          MsgBox("No se ha especificado una empresa", MsgBoxStyle.Critical, "Error")
          Return Nothing
        End If
        Dim f As New FrmMantenimientoEmpresa(Sistema, mOpcion, False)
        f.Empresa = Me.BarraRegistroContable1.Empresa
        mMostrarBarraModulo = True
        Me.BarraRegistroContable1.EmpresaVisible = True
        Me.BarraRegistroContable1.SucursalVisible = False
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Enumerados.EnumOpciones.Sucursal
        If BarraRegistroContable1.Empresa Is Nothing Then
          MsgBox("No se ha especificado una empresa", MsgBoxStyle.Critical, "Error")
          Return Nothing
        End If
        Dim f As New FrmListaSucursales(Sistema, Enumerados.EnumOpciones.Sucursal, False, BarraRegistroContable1.Empresa)
        'Dim f As New FrmMantenimientoSucursal(Sistema, mOpcion)
        'If BarraRegistroContable1.Sucursal Is Nothing Then
        '  f.Sucursal = New Sucursal(Me.BarraRegistroContable1.Empresa, True)
        'Else
        '  f.Sucursal = Me.BarraRegistroContable1.Sucursal
        'End If
        mMostrarBarraModulo = True
        Me.BarraRegistroContable1.EmpresaVisible = True
        Me.BarraRegistroContable1.SucursalVisible = True
        Me.BarraRegistroContable1.RegContableVisible = False
        Return f
      Case Else
        Return Nothing
    End Select
  End Function

  Public Overrides ReadOnly Property ToolStripMenu() As System.Windows.Forms.ToolStrip
    Get
      Return _Toolstrip
    End Get
  End Property

  Public Overrides ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip
    Get
      Return _MenuStrip
    End Get
  End Property

  Public Overrides Sub Aplicar_Restricciones()
    'Me.lblmodulo.Text = "Empresa"
    Me.BarraRegistroContable1.Sistema = Sistema
    tvopciones1.Nodes.Clear()
    'tvopciones2.Nodes.Clear()
    ImageList1.Images.Clear()
    ImageList2.Images.Clear()

    Dim contimg As Integer = 0
    Dim contimg2 As Integer = 0
    For Each _restriccion As Restriccion In Sistema.Restricciones
      If _restriccion.Restri_Lectura Then '_restriccion.Pardet_Opciones >= 100 And _restriccion.Pardet_Opciones < 200 And 
        Dim nodo As TreeNode
        Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
          Case Enumerados.EnumOpciones.Empresa
            Me.ImageList1.Images.Add("empresa", My.Resources.compania)

            nodo = New TreeNode
            nodo.Text = "Empresa"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
          Case Enumerados.EnumOpciones.Sucursal
            Me.ImageList1.Images.Add("sucursal", My.Resources.compania)

            nodo = New TreeNode
            nodo.Text = "Sucursal"
            nodo.Tag = _restriccion.Pardet_Opciones
            nodo.SelectedImageIndex = contimg
            nodo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones1.Nodes.Add(nodo)
        End Select
      End If
    Next

    Me.TableLayoutPanel1.RowStyles(0).SizeType = SizeType.Absolute
    Me.TableLayoutPanel1.RowStyles(0).Height = (Me.tvopciones1.Nodes.Count) * 16 + 30

    If Me.tvopciones1.Nodes.Count > 0 Then
      Me.tvopciones1.SelectedNode = Me.tvopciones1.Nodes(0)
    End If
    MyBase.Aplicar_Restricciones()
  End Sub

  Private mMostrarBarraModulo As Boolean = True
  Public Overrides ReadOnly Property ToolStripModulo() As System.Windows.Forms.ToolStrip
    Get
      If mMostrarBarraModulo Then
        Me.BarraRegistroContable1.Llenar_datos()
        Return Me.BarraRegistroContable1
      Else
        Return Nothing
      End If
    End Get
  End Property

  Public Sub New(ByVal _Sistema As Sistema)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Sistema = _Sistema
    'Aplicar_Restricciones()
  End Sub

  Private Sub BarraRegistroContable1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraRegistroContable1.CambioDatos
    Me.Recargar()
  End Sub
End Class
