Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmRubroAdicionalNomina
  Implements IMantenimiento

  Private mRubro As Rubro
  Public Property Rubro() As Rubro
    Get
      Return mRubro
    End Get
    Set(ByVal Value As Rubro)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un Rubro")
      End If
      mRubro = Value
      Me.cborubro.OperadorDatos = Value.OperadorDatos
      Me.cborubro.Parametro = Enumerados.EnumParametros.TipoRubro
      Me.cborubro.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, mParametro)

      Refrescar_forma()
    End Set
  End Property

  Private mRubroDet As RubroDet = Nothing
  Public Property RubroDet() As RubroDet
    Get
      Return mRubroDet
    End Get
    Set(ByVal Value As RubroDet)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un RubroDet")
      End If
      mRubroDet = Value
    End Set
  End Property

  Private mPeriodoPago As PeriodoPago
  Public Property PeriodoPago() As PeriodoPago
    Get
      Return mPeriodoPago
    End Get
    Set(ByVal Value As PeriodoPago)
      If Value Is Nothing Then
        Throw New NullReferenceException("Debe instanciar un PeriodoPago")
      End If
      mPeriodoPago = Value
    End Set
  End Property

  Private mEsQuincena As Boolean
  Public Property EsQuincena() As Boolean
    Get
      Return mEsQuincena
    End Get
    Set(ByVal Value As Boolean)
      mEsQuincena = Value
    End Set
  End Property

  Private mParametro As WWTSParametroDet
  Public Property Parametro() As WWTSParametroDet
    Get
      Return mParametro
    End Get
    Set(ByVal value As WWTSParametroDet)
      mParametro = value
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
    If Not Rubro Is Nothing Then
      Me.cborubro.ParametroDet = Rubro.PardetTipoRubro
      Me.txtvalor.Value = Rubro.Rubro_EnFindeMes
    End If

    Me.cborubro.Enabled = Rubro.EsNuevo
  End Sub

  Private Sub FrmRubro_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = Rubro.EsNuevo
          Rubro.PardetTipoRubro = Me.cborubro.ParametroDet
          If EsQuincena Then
            Rubro.Rubro_EnQuincena = Me.txtvalor.Value
            Rubro.Rubro_EnFindeMes = 0
          Else
            Rubro.Rubro_EnQuincena = 0
            Rubro.Rubro_EnFindeMes = Me.txtvalor.Value
          End If
          Rubro.Rubro_esInfinito = False
          Rubro.Rubro_ValorTope = Me.txtvalor.Value
          Rubro.Rubro_GravaIESS = Me.cborubro.ParametroDet.Pardet_DatoBit1
          Rubro.Rubro_FechaDesde = PeriodoPago.PerPag_FechaDesde
          Rubro.Rubro_Activo = True

          If String.IsNullOrWhiteSpace(Me.txtObservacion.Text.Trim()) Then
            MsgBox("Debe ingresar una observación", MsgBoxStyle.Information, "Error")
            txtObservacion.Select()
            e.Cancel = True
            Exit Sub
          End If

          Rubro.Rubro_Observacion = Me.txtObservacion.Text

          If Not Rubro.Guardar() Then
            Throw New Exception(Rubro.OperadorDatos.MsgError)
          End If

          Dim _rubrodet As RubroDet = New RubroDet(Rubro)
          RubroDet = _rubrodet
          mRubroDet.RubDet_Observacion = Me.txtObservacion.Text
          mRubroDet.RubDet_Valor = Me.txtvalor.Value
          mRubroDet.PerPag_FechaDesde = PeriodoPago.PerPag_FechaDesde
          mRubroDet.PardetPeriodoPago = PeriodoPago.PardetPeriodoPago
          If EsQuincena Then
            mRubroDet.PardetTipoPeriodoPago = New WWTSParametroDet(Rubro.OperadorDatos, Enumerados.EnumParametros.TipoPeriodoPago, Enumerados.enumTipoPeriodoPago.Quincena)
          Else
            mRubroDet.PardetTipoPeriodoPago = New WWTSParametroDet(Rubro.OperadorDatos, Enumerados.EnumParametros.TipoPeriodoPago, Enumerados.enumTipoPeriodoPago.FindeMes)
          End If
          mRubroDet.RubDet_Fecha = Now.Date
          mRubroDet.PardetTipoRubro = Rubro.PardetTipoRubro

          'If mRubroDet.Guardar() Then
          '  Throw New Exception(RubroDet.OperadorDatos.MsgError)
          'End If

          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, String.Format("{3}.{4}.{5} {0} Rubro {2} {1} de {6} a {7}", IIf(esnuevo, "Creó", "Modificó"), Rubro.Contrato.EmpleadoString, Rubro.PardetTipoRubroString, Rubro.Contrato.Entida_Codigo, Rubro.Contrato.Patron_Codigo, Rubro.Contrato.Contra_Secuencia, IIf(EsQuincena, Rubro.Rubro_EnQuincena.ToString("0.00"), Rubro.Rubro_EnFindeMes.ToString("0.00")), Rubro.Total.ToString("0.00")))
        Case IMantenimiento.Accion.Eliminacion
          If Not Rubro.Eliminar() Then
            Throw New Exception(Rubro.OperadorDatos.MsgError)
          End If
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("Eliminó Rubro {0} {1}", Rubro.Contrato.EmpleadoString, Rubro.PardetTipoRubroString))
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

End Class
