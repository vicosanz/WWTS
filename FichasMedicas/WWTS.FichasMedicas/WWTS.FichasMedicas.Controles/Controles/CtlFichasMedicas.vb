Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports WWTS.FichasMedicas.Reglas
Imports WWTS.General.Reglas

Public Class CtlFichasMedicas
  Private mFichasMedicas As FichaMedicaList

  Private mSistema As Sistema = Nothing
  Public ReadOnly Property Sistema As Sistema
    Get
      If mSistema Is Nothing Then
        Dim _control As Control = Me.Parent
        While _control IsNot Nothing And TypeOf _control IsNot FrmFormaBase
          _control = _control.Parent
        End While
        If _control Is Nothing Then
          Return Nothing
        End If
        mSistema = CType(_control, FrmFormaBase).Sistema
      End If
      Return mSistema
    End Get
  End Property

  Private mRestriccion As Restriccion = Nothing
  Public ReadOnly Property Restriccion As Restriccion
    Get
      If mRestriccion Is Nothing Then
        mRestriccion = Sistema.Restricciones.Buscar(Enumerados.EnumOpciones.FichasMedicas)
      End If
      Return mRestriccion
    End Get
  End Property

  Private mContrato As Contrato
  Public Property Contrato As Contrato
    Get
      Return mContrato
    End Get
    Set(value As Contrato)
      mContrato = value
      Mostrar_fichasmedicas()
    End Set
  End Property

  Public Property ModoenSeleccion As Boolean = False

  Sub Mostrar_fichasmedicas()
    If mContrato Is Nothing Then
      Me.BSFichas.DataSource = Nothing
      Exit Sub
    End If
    If ModoenSeleccion Then
      Me.HeaderStrip2.Enabled = Contrato.EsNuevo
    End If

    Me.BSFichas.DataSource = GetType(FichaMedica)
    mFichasMedicas = FichaMedicaList.ObtenerLista(mContrato.OperadorDatos, mContrato)
    Dim mitemssortfichamedica As New Infoware.Reglas.SortedView(mFichasMedicas)
    BSFichas.DataSource = mitemssortfichamedica
    Me.DataGridView3.AutoDiscover()
  End Sub

  Private Sub btneliminarficha_Click(sender As Object, e As EventArgs) Handles btneliminarficha.Click
    If BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea eliminar esta ficha?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Not CType(BSFichas.Current, FichaMedica).Eliminar Then
      MsgBox("Error al eliminar ficha", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
    Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("{2}.{3}.{4} Eliminó Ficha {0} {1}", CType(BSFichas.Current, FichaMedica).Contrato.EmpleadoString, CType(BSFichas.Current, FichaMedica).PardetTipoFicha.Descripcion, CType(BSFichas.Current, FichaMedica).Contrato.Entida_Codigo, CType(BSFichas.Current, FichaMedica).Contrato.Patron_Codigo, CType(BSFichas.Current, FichaMedica).Contrato.Contra_Secuencia))
    Mostrar_fichasmedicas()
  End Sub

  Sub abrir_ficha()
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoFichaMedica(Sistema, Enumerados.EnumOpciones.FichasMedicas) With {
      .FichaMedica = CType(BSFichas.Current, FichaMedica)
    }
    f.ShowDialog()

    Mostrar_fichasmedicas()
  End Sub

#Region "Abrir"
  Private Sub btnabrirficha_Click(sender As System.Object, ByVal e As System.EventArgs) Handles btnabrirficha.Click
    abrir_ficha()
  End Sub
#End Region
#Region "Duplicar"
  Private Sub DuplicarEnEsteContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarEnEsteContratoToolStripMenuItem.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If

    Dim fichaactual As FichaMedica = BSFichas.Current
    Dim nuevo As FichaMedica = fichaactual.Clone()
    BSFichas.Add(nuevo)
    BSFichas.MoveLast()
    abrir_ficha()
  End Sub

  Public Event IrAContractoActual As EventHandler

  Private Sub CrearCopiaEnContratoActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCopiaEnContratoActivoToolStripMenuItem.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If

    Dim fichaactual As FichaMedica = BSFichas.Current
    Dim nuevo As FichaMedica = fichaactual.Clone()

    If Not mContrato.Activo Then
      RaiseEvent IrAContractoActual(Me, Nothing)
    End If

    nuevo.Contrato = Contrato
    BSFichas.Add(nuevo)
    BSFichas.MoveLast()
    abrir_ficha()
  End Sub
#End Region
#Region "Nueva"
  Private Sub NuevaFicha(TipoFicha As Enumerados.TiposFichasMedicas)
    Dim nuevo As New FichaMedica(Sistema.OperadorDatos, True) With {
          .PardetTipoFicha = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoFichaMedica, TipoFicha),
          .Contrato = Contrato
        }
    BSFichas.Add(nuevo)
    BSFichas.MoveLast()
    abrir_ficha()
  End Sub

  Private Sub FichaPreocupacionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaPreocupacionalToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Preocupacional)
  End Sub

  Private Sub FichaOcupacionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaOcupacionalToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Ocupacional)
  End Sub

  Private Sub FichaDeReintegroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaDeReintegroToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Reingreso)
  End Sub

  Private Sub FichaDeRetiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaDeRetiroToolStripMenuItem.Click
    NuevaFicha(Enumerados.TiposFichasMedicas.Retiro)
  End Sub
#End Region

#Region "Imprimir"
  Private Sub btnimprimirficha_DropDownOpening(sender As Object, e As EventArgs) Handles btnimprimirficha.DropDownOpening
    btnpag1.Enabled = False
    btnpag2.Enabled = False
    btnpag3.Enabled = False
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    btnpag1.Enabled = True
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional OrElse ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      btnpag2.Enabled = True
      btnpag3.Enabled = True
    End If
  End Sub

  Private Sub btnpag1_Click(sender As Object, e As EventArgs) Handles btnpag1.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaPreocupacionalPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaOcupacionalPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Reingreso Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaReingresolPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Retiro Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaRetiroPag1(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 1))
    End If
  End Sub

  Private Sub btnpag2_Click(sender As Object, e As EventArgs) Handles btnpag2.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaPreocupacionalPag2(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 2))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaOcupacionalPag2(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 2))
    End If
  End Sub

  Private Sub btnpag3_Click(sender As Object, e As EventArgs) Handles btnpag3.Click
    If Me.BSFichas.Current Is Nothing Then
      Exit Sub
    End If
    Dim ficha As FichaMedica = Me.BSFichas.Current
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Preocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaPreocupacionalPag3(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 3))
    End If
    If ficha.Pardet_TipoFicha = Enumerados.TiposFichasMedicas.Ocupacional Then
      FichaMedicaExcel.CombinarCorrespondenciaFichaOcupacionalPag3(ficha, String.Format(ficha.PardetTipoFicha.Pardet_DatoStr1, 3))
    End If
  End Sub
#End Region

#Region "DataGrid"
  Private Sub DataGridView3_DoubleClick(sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.DoubleClick
    abrir_ficha()
  End Sub

  Private Sub DataGridView3_KeyDown(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView3.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        abrir_ficha()
      Case Else
        e.Handled = False
    End Select

  End Sub

#End Region
End Class
