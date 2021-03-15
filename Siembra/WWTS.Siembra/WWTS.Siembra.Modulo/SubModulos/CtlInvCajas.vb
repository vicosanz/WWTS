

Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General

Public Class CtlInvCajas
  Private mRestriccion As Restriccion
  Public WriteOnly Property Restriccion() As Restriccion
    Set(ByVal value As Restriccion)
      mRestriccion = value
    End Set
  End Property

  Private mOp As OperadorDatos
  Private mInvcaja As InvCaja = Nothing
  Private mManipularSueldos As Boolean = True
  Public Event CreoNuevo As System.EventHandler
  Public Event AntesNuevo As System.EventHandler
  Public Event EliminoInvCaja As System.EventHandler

  Public Property op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal Value As OperadorDatos)
      mOp = Value
      Me.CtlZafra1.Op = mOp
      Me.CtlColorHoja1.Op = mOp
      Me.CtlBodega1.Op = mOp
      Me.CtlClaseHoja1.Op = mOp
      Me.CtlCorte1.Op = mOp
      Me.CtlTerreno1.Op = mOp
      Me.CtlSemilla1.Op = mOp
      If Not Value Is Nothing Then
        Me.CtlZafra1.llenar_datos()
        Me.CtlColorHoja1.llenar_datos()
        Me.CtlBodega1.llenar_datos()
        Me.CtlClaseHoja1.llenar_datos()
        Me.CtlCorte1.llenar_datos()
        Me.CtlTerreno1.llenar_datos()
        Me.CtlSemilla1.llenar_datos()
      End If
    End Set
  End Property

  Public Property Invcaja() As InvCaja
    Get
      Return mInvcaja
    End Get
    Set(ByVal Value As InvCaja)
      mInvcaja = Value
      If Not Value Is Nothing Then
        mapearInvCajaaForma()
      Else
        Limpiarforma()
      End If
    End Set
  End Property
  Sub Limpiarforma()
    Me.txtNumEmb.Text = String.Empty
    Me.txtNumEmp.Text = String.Empty
    Me.txtpesob.Text = "0"
    Me.txtpeson.Text = "0"
    Me.txtprecio.Text = "0"
    Me.txttara.Text = "0"
    Me.CtlCorte1.Corte = Nothing
    Me.CtlSemilla1.Semilla = Nothing
    Me.CtlClaseHoja1.ClaseHoja = Nothing
    Me.CtlColorHoja1.ColorHoja = Nothing
    Me.CtlTerreno1.Terreno = Nothing
    Me.CtlZafra1.Zafra = Nothing
    Me.CtlBodega1.Bodega = Nothing
    Me.pn1.Enabled = False
    Me.groupbox1.Enabled = False
    Me.pn3.Enabled = False
    Me.btneli.Enabled = False
    Me.btnguardar.Enabled = False
  End Sub

  Sub mapearInvCajaaForma()
    If mInvcaja Is Nothing Then
      Limpiarforma()
      Exit Sub
    End If
    Me.pictnuevo.Visible = Me.mInvcaja.esNuevo
    If mInvcaja.esNuevo Then
      Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
    Else
      Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
    End If

    Me.pictgrabar.Visible = Not Me.mInvcaja.esNuevo
    Me.btnguardar.Enabled = True
    Me.btneli.Enabled = Not Me.mInvcaja.esNuevo
    Me.pn1.Enabled = True
    Me.groupbox1.Enabled = True
    Me.pn3.Enabled = True

    Me.CtlZafra1.Zafra = mInvcaja.Zafra
    Me.txtNumEmp.Text = mInvcaja.Caj_empNum.ToString()
    Me.rdonatural.Checked = mInvcaja.Caj_tipoNC = Enumerados.TipoTabaco.Natural
    Me.rdocandela.Checked = mInvcaja.Caj_tipoNC = Enumerados.TipoTabaco.Candela
    Me.CtlTerreno1.Terreno = mInvcaja.Terreno
    Me.CtlColorHoja1.ColorHoja = mInvcaja.ColorHoja
    Me.CtlClaseHoja1.ClaseHoja = mInvcaja.ClaseHoja
    Me.CtlSemilla1.Semilla = mInvcaja.Semilla
    Me.CtlBodega1.Bodega = mInvcaja.Bodega
    Me.CtlCorte1.Corte = mInvcaja.Corte
    Me.txtprecio.Text = mInvcaja.Caj_Precio.ToString()
    Me.dtpFecha.Value = IIf(mInvcaja.Caj_Fechaempaque = Nothing, Now.Date, mInvcaja.Caj_Fechaempaque)
    Me.txtpesob.Text = mInvcaja.Caj_Peso.ToString()
    Me.txttara.Text = mInvcaja.Caj_Tara.ToString()

    Me.txtNumEmb.Text = mInvcaja.Caj_embNum.ToString()

    Me.txtpeson.Text = mInvcaja.PesoNeto.ToString()
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    RaiseEvent AntesNuevo(Me, System.EventArgs.Empty)
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      Dim nuevo As Boolean = mInvcaja.esNuevo
      If (Not mInvcaja.esNuevo) And (CInt(Me.txtNumEmp.Text) <> mInvcaja.Caj_empNum) Then
        mInvcaja.CambiarEmpaque(CInt(Me.txtNumEmp.Text))
      End If
      mapearFormaaInvCaja()
      If Not mInvcaja.Guardar() Then
        Throw New ArgumentException(mInvcaja.OperadorDatos.MsgError)
      Else
        Auditoria.Registrar_Auditoria(mRestriccion, IIf(nuevo, Auditoria.enumTipoAccion.Adicion, Auditoria.enumTipoAccion.Modificacion), String.Format("{0} Cajas de rezago {1} {2}", IIf(nuevo, "Creó", "Modificó"), mInvcaja.Zafra.Zaf_descripcion, mInvcaja.Caj_empNum))

        Me.txtNumEmp.Text = mInvcaja.Caj_empNum.ToString()
        Invcaja = mInvcaja
        If nuevo Then
          Dim _configsiembra As ConfigSiembra
          _configsiembra = New ConfigSiembra(Me.mOp)
          _configsiembra.AvanzarEmpaque()
          RaiseEvent CreoNuevo(mInvcaja, System.EventArgs.Empty)
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
      If Not mInvcaja.Eliminar() Then
        Throw New ArgumentException(mInvcaja.OperadorDatos.MsgError)
      Else
        Auditoria.Registrar_Auditoria(mRestriccion, Auditoria.enumTipoAccion.Eliminacion, String.Format("{0} Cajas de rezago {1} {2}", "Eliminó", mInvcaja.Zafra.Zaf_descripcion, mInvcaja.Caj_empNum))
      End If
      Me.Invcaja = Nothing

      RaiseEvent EliminoInvCaja(Me, System.EventArgs.Empty)
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Sub mapearFormaaInvCaja()
    If Not mInvcaja Is Nothing Then
      mInvcaja.Zafra = Me.CtlZafra1.Zafra
      mInvcaja.Caj_empNum = CInt(Me.txtNumEmp.Text)
      mInvcaja.Caj_tipoNC = IIf(rdonatural.Checked, Enumerados.TipoTabaco.Natural, Enumerados.TipoTabaco.Candela)
      mInvcaja.Terreno = Me.CtlTerreno1.Terreno
      mInvcaja.ColorHoja = Me.CtlColorHoja1.ColorHoja
      mInvcaja.ClaseHoja = Me.CtlClaseHoja1.ClaseHoja
      mInvcaja.Semilla = Me.CtlSemilla1.Semilla
      mInvcaja.Bodega = Me.CtlBodega1.Bodega
      mInvcaja.Corte = Me.CtlCorte1.Corte
      mInvcaja.Caj_Precio = CDec(Me.txtprecio.Text)
      mInvcaja.Caj_Fechaempaque = Me.dtpFecha.Value
      mInvcaja.Caj_Peso = CDec(Me.txtpesob.Text)
      mInvcaja.Caj_Tara = CDec(Me.txttara.Text)

      mInvcaja.Caj_embNum = CInt(Me.txtNumEmb.Text)
    End If
  End Sub

  Private Sub CtlInvCajas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.pn1.Enabled = False
    Me.groupbox1.Enabled = False
    Me.pn3.Enabled = False
    Me.pictgrabar.Visible = False
    Me.pictnuevo.Visible = False
  End Sub

  Private Sub txtTara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttara.TextChanged, txtpesob.TextChanged
    If Not mInvcaja Is Nothing Then
      Me.txtpeson.Text = (CDec(Me.txtpesob.Text) - CDec(Me.txttara.Text)).ToString()
    End If
  End Sub

  Private Sub CtlClaseHoja1_CambioClase() Handles CtlClaseHoja1.CambioClaseHoja
    If Me.CtlClaseHoja1.ClaseHoja Is Nothing Then
      Exit Sub
    End If
    Me.pnlcolor.Visible = Not Me.CtlClaseHoja1.ClaseHoja.Cla_codigo.Trim = "SIN ESCOGER"
  End Sub
End Class
