

Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Datos
Imports Infoware.Consola.Base

Public Class CtlTarjCuracion

    Private mRestriccion As Restriccion
    Public WriteOnly Property Restriccion() As Restriccion
        Set(ByVal value As Restriccion)
            mRestriccion = value
        End Set
    End Property

    Private mOp As OperadorDatos
    Public Property Op() As OperadorDatos
        Get
            Return mOp
        End Get
        Set(ByVal value As OperadorDatos)
            mOp = value
            Me.CtlZafra1.Op = mOp
            Me.CtlLote1.Op = mOp
            Me.CtlSeccionHorno1.Op = mOp
            Me.CtlSemilla1.Op = mOp
            Me.cboTipoTabaco.OperadorDatos = mOp
            If Not value Is Nothing Then
                Me.cboTipoTabaco.Parametro = Enumerados.EnumParametros.TipoTabaco
                Me.cboTipoTabaco.Llenar_Datos()
                Me.CtlZafra1.llenar_datos()
                Me.CtlLote1.llenar_datos()
                Me.CtlSeccionHorno1.llenar_datos()
                Me.CtlSemilla1.llenar_datos()
            End If
        End Set
    End Property

    Private mCuracion As Curacion = Nothing
    Private mManipularSueldos As Boolean = True
    Public Event CreoNuevo As System.EventHandler
    Public Event AntesNuevo As System.EventHandler
    Public Event EliminoTarjeta As System.EventHandler

    Public Property Curacion() As Curacion
        Get
            Return mCuracion
        End Get
        Set(ByVal Value As Curacion)
            mCuracion = Value
            If Not Value Is Nothing Then
                mapearInvCajaaForma()
            Else
                Limpiarforma()
            End If
        End Set
    End Property

    Sub Limpiarforma()
        Me.txtNumEns.Text = String.Empty
        Me.CtlZafra1.Zafra = Nothing
        Me.CtlLote1.Lote = Nothing
        Me.CtlSeccionHorno1.SeccionHorno = Nothing
        Me.CtlSemilla1.Semilla = Nothing
        Me.pn1.Enabled = False
        Me.pn3.Enabled = False
        Me.GroupBox1.Enabled = False
        Me.btneli.Enabled = False
        Me.btnguardar.Enabled = False
        Me.TSCortes.Enabled = False
    End Sub
    Sub mapearInvCajaaForma()
        If mCuracion Is Nothing Then
            Limpiarforma()
            Exit Sub
        End If
        Me.nuevo.Visible = Me.mCuracion.EsNuevo
        Me.grabar.Visible = Not Me.mCuracion.EsNuevo
        Me.btnguardar.Enabled = True
        Me.btneli.Enabled = Not Me.mCuracion.EsNuevo
        Me.pn1.Enabled = mCuracion.EsNuevo
        Me.pn3.Enabled = True
        Me.GroupBox1.Enabled = True

        Me.btnDetalles.Visible = Me.mCuracion.EsNuevo

        Me.CtlZafra1.Zafra = mCuracion.Zafra
        Me.cboTipoTabaco.ParametroDet = mCuracion.PardetTipoTabaco
        Me.txtNumEns.Text = mCuracion.Cur_numero.ToString()
        Me.CtlLote1.Lote = mCuracion.Lote
        Me.CtlSeccionHorno1.SeccionHorno = mCuracion.SeccionHorno
        Me.CtlSemilla1.Semilla = mCuracion.Semilla
        Me.dtpFecha.Value = CType(IIf(mCuracion.Cur_fecha = Nothing, Now.Date, mCuracion.Cur_fecha), Date)
        Me.dtpFechaInicio.Value = CType(IIf(mCuracion.Cur_fechaingreso = Nothing, Now.Date, mCuracion.Cur_fechaingreso), Date)

        BSDetalles.DataSource = mCuracion.Detalles
        DGDetalles.AutoDiscover()

        Me.TSCortes.Enabled = True
        BSCortes.DataSource = mCuracion.Cortes
        DGCortes.AutoDiscover()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        RaiseEvent AntesNuevo(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            If mCuracion.Detalles.Count() = 0 Then
                Throw New Exception("Debe generar los detalles primero")
            End If

            Dim nuevo As Boolean = mCuracion.EsNuevo
            'If (Not mCuracion.esNuevo) And (CInt(Me.txtNumEns.Text) <> mCuracion.Ens_numero) Then
            '	mCuracion.CambiarEmpaque(CInt(Me.txtNumEns.Text))
            'End If
            mapearFormaaInvCaja()
            If Not mCuracion.Guardar() Then
                Throw New ArgumentException(mCuracion.OperadorDatos.MsgError)
            Else
                Auditoria.Registrar_Auditoria(mRestriccion, Auditoria.enumTipoAccion.Adicion, String.Format("{0} Tarjeta de ensarte {1} {2}", IIf(nuevo, "Creó", "Modificó"), mCuracion.Zafra.Zaf_descripcion, mCuracion.Cur_numero))

                Me.txtNumEns.Text = mCuracion.Cur_numero.ToString()
                Curacion = mCuracion
                If nuevo Then
                    Dim _configsiembra As ConfigSiembra
                    _configsiembra = New ConfigSiembra(Me.mOp)
                    _configsiembra.AvanzarCuracion()
                    RaiseEvent CreoNuevo(mCuracion, System.EventArgs.Empty)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneli.Click
        If Not MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNoCancel, "Pregunta") = MsgBoxResult.Yes Then
            Exit Sub
        End If
        Try
            mapearFormaaInvCaja()
            If Not mCuracion.Eliminar() Then
                Throw New ArgumentException(mCuracion.OperadorDatos.MsgError)
            Else
                Auditoria.Registrar_Auditoria(mRestriccion, Auditoria.enumTipoAccion.Eliminacion, String.Format("{0} Tarjeta de ensarte {1} {2}", "Eliminó", mCuracion.Zafra.Zaf_descripcion, mCuracion.Cur_numero))
            End If
            Me.Curacion = Nothing

            RaiseEvent EliminoTarjeta(Me, System.EventArgs.Empty)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mapearFormaaInvCaja()
        If Not mCuracion Is Nothing Then
            mCuracion.Zafra = Me.CtlZafra1.Zafra
            mCuracion.PardetTipoTabaco = Me.cboTipoTabaco.ParametroDet
            mCuracion.Cur_numero = CInt(Me.txtNumEns.Text)
            mCuracion.Cur_fecha = Me.dtpFecha.Value
            mCuracion.Cur_fechaingreso = Me.dtpFechaInicio.Value
            mCuracion.Lote = Me.CtlLote1.Lote
            mCuracion.Semilla = Me.CtlSemilla1.Semilla
            mCuracion.SeccionHorno = Me.CtlSeccionHorno1.SeccionHorno
        End If
    End Sub

    Private Sub CtlTarjCuracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.pn1.Enabled = False
        Me.pn3.Enabled = False
        Me.GroupBox1.Enabled = False
        Me.grabar.Visible = False
        Me.nuevo.Visible = False
    End Sub

    Private Sub btnDetalles_Click(sender As Object, e As EventArgs) Handles btnDetalles.Click
        If Me.cboTipoTabaco.ParametroDet Is Nothing Then
            Exit Sub
        End If
        mapearFormaaInvCaja()
        Dim detalles As New CuracionDetalleCollection
        If mCuracion.Pardet_TipoTabaco = 1 Then 'natural
            For d As Integer = 0 To 31
                For h As Integer = 1 To 24
                    If (d = 0 AndAlso h < 18) Then
                    Else
                        Dim detalle As New CuracionDetalle(mOp, mCuracion, dtpFechaInicio.Value.AddDays(d), h, True)
                        detalles.Add(detalle)
                    End If
                Next
            Next
        End If
        If mCuracion.Pardet_TipoTabaco = 2 Then 'candela
            For d As Integer = 0 To 3
                For h As Integer = 1 To 24
                    If (d = 0 AndAlso h < 18) Then
                    Else
                        Dim detalle As New CuracionDetalle(mOp, mCuracion, dtpFechaInicio.Value.AddDays(d), h, True)
                        If (d = 0 AndAlso h = 18) Then
                            detalle.Curdet_preest = 84
                        End If
                        If (d = 0 AndAlso h = 24) Then
                            detalle.Curdet_preest = 102
                        End If

                        If (d = 1 AndAlso h = 6) Then
                            detalle.Curdet_preest = 110
                        End If
                        If (d = 1 AndAlso h = 12) Then
                            detalle.Curdet_preest = 118
                        End If
                        If (d = 1 AndAlso h = 18) Then
                            detalle.Curdet_preest = 126
                        End If
                        If (d = 1 AndAlso h = 24) Then
                            detalle.Curdet_preest = 134
                        End If

                        If (d = 2 AndAlso h = 6) Then
                            detalle.Curdet_preest = 140
                        End If
                        If (d = 2 AndAlso h = 12) Then
                            detalle.Curdet_preest = 146
                        End If
                        If (d = 2 AndAlso h = 18) Then
                            detalle.Curdet_preest = 152
                        End If
                        If (d = 2 AndAlso h = 24) Then
                            detalle.Curdet_preest = 158
                        End If

                        If (d = 3 AndAlso h = 6) Then
                            detalle.Curdet_preest = 164
                        End If
                        detalles.Add(detalle)
                    End If
                Next
            Next
        End If
        mCuracion.Detalles = detalles
        BSDetalles.DataSource = mCuracion.Detalles
        DGDetalles.AutoDiscover()
    End Sub

    Private Sub btnnuevocorte_Click(sender As Object, e As EventArgs) Handles btnnuevocorte.Click
        mCuracion.Cortes.Add(New CuracionCortes(mOp, mCuracion, 0, True))
        DGCortes.AutoDiscover()
    End Sub

    Private Sub btneliminarcorte_Click(sender As Object, e As EventArgs) Handles btneliminarcorte.Click
        Dim corte As CuracionCortes = BSCortes.Current
        If corte IsNot Nothing Then
            If corte.EsNuevo Then
                BSCortes.RemoveCurrent()
            Else
                If corte.Eliminar() Then
                    BSCortes.RemoveCurrent()
                End If
            End If
        End If
    End Sub
End Class
