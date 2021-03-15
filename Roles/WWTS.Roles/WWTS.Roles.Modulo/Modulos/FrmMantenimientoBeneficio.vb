Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoBeneficio
  Implements IMantenimiento

  Private mBeneficioSocial As BeneficiosSociales
  Public Property BeneficioSocial() As BeneficiosSociales
    Get
      Return mBeneficioSocial
    End Get
    Set(ByVal Value As BeneficiosSociales)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar una Beneficio")
      End If
      mBeneficioSocial = Value
      llenar_datos()
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Private mtemporal As Decimal
  Public Property temporal() As Decimal
    Get
      Return mtemporal
    End Get
    Set(ByVal value As Decimal)
      mtemporal = value
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If BeneficioSocial IsNot Nothing Then
      Me.txtcodigo.Text = BeneficioSocial.Entida_Codigo
      Me.txtcedula.Text = BeneficioSocial.Contrato.Empleado.Cedula
      Me.txtempleado.Text = BeneficioSocial.Contrato.Empleado.NombreCompleto
      Me.txtmonto.Value = BeneficioSocial.BenSoc_Valor
      Me.txtdias.Value = BeneficioSocial.BenSoc_Dias
      temporal = BeneficioSocial.BenSoc_Valor
      Me.txtobservacion.Text = BeneficioSocial.BenSoc_Observacion
    End If
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If temporal.ToString("0.00") <> Me.txtmonto.Value Then
            If String.IsNullOrWhiteSpace(Me.txtobservacion.Text.Trim()) Then
              MsgBox("Debe ingresar una observación", MsgBoxStyle.Information, "Error")
              txtobservacion.Select()
              e.Cancel = True
              Exit Sub
            End If
          End If
          BeneficioSocial.BenSoc_Valor = Me.txtmonto.Value
          BeneficioSocial.BenSoc_Dias = Me.txtdias.Value
          BeneficioSocial.BenSoc_Observacion = Me.txtobservacion.Text

        Case IMantenimiento.Accion.Eliminacion

      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
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

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitSistema(_Sistema, _OpcionActual)
  End Sub
#End Region

  Private mRubroDetList As RubroDetList = Nothing
  Sub llenar_datos()
    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Entida_Codigo"
    'DataGridViewTextBoxColumn1.HeaderText = "Código"
    'DataGridViewTextBoxColumn1.Width = 60
    'DataGridViewTextBoxColumn1.ReadOnly = True
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoRubroString"
    DataGridViewTextBoxColumn1.HeaderText = "Rubro"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PerPag_FechaDesde"
    DataGridViewTextBoxColumn1.HeaderText = "Periodo"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Select Case BeneficioSocial.Pardet_TipoBeneficioEnum
      Case Enumerados.enumTipoBeneficio.DecimoTercero, Enumerados.enumTipoBeneficio.DecimoCuarto, Enumerados.enumTipoBeneficio.Vacaciones
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "RubDet_Cantidad"
        DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        DataGridViewTextBoxColumn1.Width = 60
        DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End Select

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "RubDet_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 80
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    If consulta = 1 Then
      mRubroDetList = RubroDetList.ObtenerListaBeneficios(Sistema.OperadorDatos, mBeneficioSocial.Contrato, BeneficioSocial.Pardet_TipoBeneficioEnum, Nothing, Nothing)
    ElseIf consulta = 2 Then
      mRubroDetList = RubroDetList.ObtenerListaBeneficios(Sistema.OperadorDatos, mBeneficioSocial.Contrato, BeneficioSocial.Pardet_TipoBeneficioEnum, desde, hasta)
    Else
      mRubroDetList = RubroDetList.ObtenerListaBeneficios(Sistema.OperadorDatos, mBeneficioSocial.Contrato, BeneficioSocial.Pardet_TipoBeneficioEnum, Nothing, hasta)
    End If
    BSdetalle.DataSource = mRubroDetList
  End Sub

  Private mconsulta As Integer
  Public Property consulta As Integer
    Get
      Return mconsulta
    End Get
    Set(ByVal value As Integer)
      mconsulta = value
    End Set
  End Property
  Private mdesde As Date
  Public Property desde As Date
    Get
      Return mdesde
    End Get
    Set(ByVal value As Date)
      mdesde = value
    End Set
  End Property
  Private mhasta As Date
  Public Property hasta As Date
    Get
      Return mhasta
    End Get
    Set(ByVal value As Date)
      mhasta = value
    End Set
  End Property
  Private mtipobeneficio As Enumerados.enumTipoBeneficio
  Public Property Pardet_TipoBeneficioEnum() As Enumerados.enumTipoBeneficio
    Get
      Return mtipobeneficio
    End Get
    Set(ByVal value As Enumerados.enumTipoBeneficio)
      mtipobeneficio = value
    End Set
  End Property
End Class