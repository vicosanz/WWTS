

Imports WWTS.General.Reglas
Imports WWTS.Siembra.Reglas
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.General.Modulo

Public Class CtlBloque

  Private mRestriccion As Restriccion
  Public WriteOnly Property Restriccion() As Restriccion
    Set(ByVal value As Restriccion)
      mRestriccion = value
    End Set
  End Property

  Private mOp As OperadorDatos
  Public Property op() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal Value As OperadorDatos)
      mOp = Value
      Me.CtlZafra1.Op = mOp
      Me.CtlLote1.Op = mOp
      Me.CtlCorte1.Op = mOp
      Me.CtlSemilla1.Op = mOp
      If Not Value Is Nothing Then
        Me.CtlZafra1.llenar_datos()
        Me.CtlLote1.llenar_datos()
        Me.CtlCorte1.llenar_datos()
        Me.CtlSemilla1.llenar_datos()
      End If
    End Set
  End Property

  Private mBloque As Bloque = Nothing
  Private mManipularSueldos As Boolean = True
  Public Event CreoNuevo As System.EventHandler
  Public Event AntesNuevo As System.EventHandler
  Public Event EliminoBloque As System.EventHandler

  Public Property Bloque() As Bloque
    Get
      Return mBloque
    End Get
    Set(ByVal Value As Bloque)
      mBloque = Value
      If Not Value Is Nothing Then
        mapearBloqueaForma()

        'Inicializar_DataGrid()
      Else
        Limpiarforma()
      End If
    End Set
  End Property

  Sub Limpiarforma()
    Me.txtNumBloque.Text = String.Empty
    Me.CtlZafra1.Zafra = Nothing
    Me.CtlCorte1.Corte = Nothing
    Me.CtlSemilla1.Semilla = Nothing
    Me.CtlLote1.Lote = Nothing
    Me.rdosano.Checked = True
    Me.rdolimpio.Checked = True

    Me.pn1.Enabled = False
    Me.pn3.Enabled = False
    Me.GroupBox1.Enabled = False
    Me.btneli.Enabled = False
    Me.btnguardar.Enabled = False

    Me.grpmovimientos.Visible = False
  End Sub

  Sub mapearBloqueaForma()
    If mBloque Is Nothing Then
      Limpiarforma()
      Exit Sub
    End If
    Me.nuevo.Visible = Me.mBloque.EsNuevo
    Me.grabar.Visible = Not Me.mBloque.EsNuevo
    Me.btnguardar.Enabled = True
    Me.btneli.Enabled = Not Me.mBloque.EsNuevo
    Me.pn1.Enabled = True
    Me.pn3.Enabled = True
    Me.GroupBox1.Enabled = True

    Me.txtNumBloque.Text = mBloque.Blo_codigo.ToString()
    Me.CtlZafra1.Zafra = mBloque.Zafra
    Me.CtlCorte1.Corte = mBloque.Corte
    Me.CtlSemilla1.Semilla = mBloque.Semilla
    Me.CtlLote1.Lote = mBloque.Lote
    Me.rdosano.Checked = mBloque.Blo_essanooroto = True
    Me.rdoroto.Checked = mBloque.Blo_essanooroto = False
    Me.rdolimpio.Checked = mBloque.Blo_eslimpioopintado = True
    Me.rdopintado.Checked = mBloque.Blo_eslimpioopintado = False
    Me.txtobservaciones.Text = mBloque.Blo_observacion

    Me.grpmovimientos.Visible = Not mBloque.EsNuevo
    Actualizar_movimientos()
  End Sub
  Sub Actualizar_movimientos()
    Me.ElementoListBindingSource.DataSource = Enumerados.TipoMovBloqueList

    Dim _bloquemovs As BloqueMovCollection
    _bloquemovs = BloqueMov.RetornarBloqueMovsFiltro(Me.mOp, mBloque)
    Me.BloqueMovCollectionBindingSource.DataSource = _bloquemovs
  End Sub

  Sub mapearFormaaBloque()
    If Not mBloque Is Nothing Then
      mBloque.Blo_codigo = Me.txtNumBloque.Text
      mBloque.Zafra = Me.CtlZafra1.Zafra
      mBloque.Corte = Me.CtlCorte1.Corte
      mBloque.Semilla = Me.CtlSemilla1.Semilla
      mBloque.Lote = Me.CtlLote1.Lote
      mBloque.Blo_essanooroto = Me.rdosano.Checked
      mBloque.Blo_eslimpioopintado = Me.rdolimpio.Checked
      mBloque.Blo_observacion = Me.txtobservaciones.Text
    End If
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    RaiseEvent AntesNuevo(Me, System.EventArgs.Empty)
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      Dim nuevo As Boolean = mBloque.EsNuevo
      'If (Not mBloque.esNuevo) And (CInt(Me.txtNumEns.Text) <> mBloque.Ens_numero) Then
      '	mBloque.CambiarEmpaque(CInt(Me.txtNumEns.Text))
      'End If
      mapearFormaaBloque()
      If Not mBloque.Guardar() Then
        Throw New ArgumentException(mBloque.OperadorDatos.MsgError)
      Else
        Auditoria.Registrar_Auditoria(mRestriccion, IIf(nuevo, Auditoria.enumTipoAccion.Adicion, Auditoria.enumTipoAccion.Modificacion), String.Format("{0} bloque {1} {2}", IIf(nuevo, "Creó", "Modificó"), mBloque.Zafra.Zaf_descripcion, mBloque.Blo_codigo))

        Me.txtNumBloque.Text = mBloque.Blo_codigo
        Bloque = mBloque
        If nuevo Then
          Dim _configsiembra As ConfigSiembra
          _configsiembra = New ConfigSiembra(Me.mOp)
          _configsiembra.AvanzarBloque()
          RaiseEvent CreoNuevo(mBloque, System.EventArgs.Empty)
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
      mapearFormaaBloque()
      If Not mBloque.Eliminar() Then
        Throw New ArgumentException(mBloque.OperadorDatos.MsgError)
      Else
        Auditoria.Registrar_Auditoria(mRestriccion, Auditoria.enumTipoAccion.Eliminacion, String.Format("{0} bloque {1} {2}", "Eliminó", mBloque.Zafra.Zaf_descripcion, mBloque.Blo_codigo))
      End If
      Me.Bloque = Nothing

      RaiseEvent EliminoBloque(Me, System.EventArgs.Empty)
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub CtlBloque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.pn1.Enabled = False
    Me.pn3.Enabled = False
    Me.GroupBox1.Enabled = False
    Me.grabar.Visible = False
    Me.nuevo.Visible = False
  End Sub

  Private Sub btnanadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanadir.Click
    Dim _bloquemov As BloqueMov
    _bloquemov = New BloqueMov(mOp, Me.Bloque)

    Dim f As New FrmBloqueMov
    f.BloqueMov = _bloquemov
    f.Direccion = IMantenimiento.Accion.Ingreso
    If f.ShowDialog = DialogResult.OK Then
      Actualizar_movimientos()
    End If
  End Sub

  Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
    If Me.dgmovimientos.CurrentRow.Index = -1 Then
      Exit Sub
    End If
    Dim f As New FrmBloqueMov
    f.BloqueMov = CType(BloqueMovCollectionBindingSource.DataSource(dgmovimientos.CurrentRow.Index), BloqueMov)
    f.Direccion = IMantenimiento.Accion.Modificacion
    If f.ShowDialog = DialogResult.OK Then
      Actualizar_movimientos()
    End If
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If Me.dgmovimientos.CurrentRow.Index = -1 Then
      Exit Sub
    End If
    Dim f As New FrmBloqueMov
    f.BloqueMov = CType(Me.BloqueMovCollectionBindingSource.DataSource(Me.dgmovimientos.CurrentRow.Index), BloqueMov)
    f.Direccion = IMantenimiento.Accion.Eliminacion
    If f.ShowDialog = DialogResult.OK Then
      Actualizar_movimientos()
    End If

  End Sub

End Class
