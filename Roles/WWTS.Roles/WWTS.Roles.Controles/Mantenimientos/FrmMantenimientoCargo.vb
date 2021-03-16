Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports WWTS.General.Reglas
Imports WWTS.Roles.Reglas
Imports WWTS.General.Modulo

Public Class FrmMantenimientoCargo
  Implements IMantenimiento

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

  Private mCargando As Boolean = False

  Private mCargo As Cargo
  Public Property Cargo() As Cargo
    Get
      Return mCargo
    End Get
    Set(ByVal value As Cargo)
      mCargo = value
      If value IsNot Nothing Then
        'mCargando = True
        'Me.cboSeccion.OperadorDatos = value.OperadorDatos
        'Me.cboSeccion.Parametro = Enumerados.EnumParametros.Seccion
        'Me.cboSeccion.Llenar_Datos()

        'Me.cboDepartamento.OperadorDatos = value.OperadorDatos
        'Me.cboDepartamento.Parametro = Enumerados.EnumParametros.Departamento
        'Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)

        'Me.CtlArea1.Op = value.OperadorDatos
        'Me.CtlArea1.Seccion = cboSeccion.ParametroDet
        'Me.CtlArea1.llenar_datos()

        'Me.CtlModeloLabor1.Op = value.OperadorDatos
        'Me.CtlModeloLabor1.llenar_datos()

        'Me.cboSeccionJefe.OperadorDatos = value.OperadorDatos
        'Me.cboSeccionJefe.Parametro = Enumerados.EnumParametros.Seccion
        'Me.cboSeccionJefe.Llenar_Datos()

        'Me.cboDepartamentoJefe.OperadorDatos = value.OperadorDatos
        'Me.cboDepartamentoJefe.Parametro = Enumerados.EnumParametros.Departamento
        'Me.cboDepartamentoJefe.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccionJefe.ParametroDet)

        'Me.CtlArea1Jefe.Op = value.OperadorDatos
        'Me.CtlArea1Jefe.Seccion = cboSeccionJefe.ParametroDet
        'Me.CtlArea1Jefe.Departamento = cboDepartamentoJefe.ParametroDet
        'Try
        '  Me.CtlArea1Jefe.llenar_datos()
        'Catch ex As Exception
        'End Try

        'Me.CtlCargo1Jefe.Op = value.OperadorDatos
        'Try
        '  Me.CtlCargo1Jefe.llenar_datos(CtlArea1Jefe.Area)
        'Catch ex As Exception
        'End Try

        'mCargando = False
        Refrescar_forma()
      End If
    End Set
  End Property

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    Try
      Me.cboSeccion.ParametroDet = Cargo.PardetDepartamento.PardetPadre
    Catch ex As Exception
    End Try

    Me.cboDepartamento.ParametroDet = Cargo.PardetDepartamento

    Try
      Me.CtlArea1.Seccion = Cargo.PardetDepartamento.PardetPadre
      Me.CtlArea1.Departamento = Cargo.PardetDepartamento
      Me.CtlArea1.llenar_datos()
      Me.CtlArea1.Area = Cargo.Area
    Catch ex As Exception
    End Try

    Me.txtDescripcion.Text = Cargo.Cargo_Descripcion
    Me.txtDescripcion.Select()

    Me.ComboBoxActividadSectorial.ParametroDet = Cargo.PardetActividadSectorial

    Me.CtlModeloLabor1.ModeloLabor = Cargo.PardetModeloLabor
    Me.chkControlarHE.Checked = Cargo.Cargo_ControlarHorasExtras

    Me.cboSeccion.Enabled = Cargo.EsNuevo
    Me.cboDepartamento.Enabled = Cargo.EsNuevo
    Me.CtlArea1.Enabled = Cargo.EsNuevo

    Me.chkTieneJefe.Checked = Cargo.PardetDepartamentoJefe IsNot Nothing
    Try
      Me.cboSeccionJefe.ParametroDet = Cargo.PardetDepartamentoJefe.PardetPadre
    Catch ex As Exception
    End Try

    Me.cboDepartamentoJefe.ParametroDet = Cargo.PardetDepartamentoJefe

    Try
      Me.CtlArea1Jefe.Seccion = Cargo.PardetDepartamentoJefe.PardetPadre
      Me.CtlArea1Jefe.Departamento = Cargo.PardetDepartamentoJefe
      Me.CtlArea1Jefe.llenar_datos()
      Me.CtlArea1Jefe.Area = Cargo.AreaJefe
    Catch ex As Exception
    End Try

    Try
      Me.CtlCargo1Jefe.Area = CtlArea1Jefe.Area
      Me.CtlCargo1Jefe.llenar_datos()
      'If Not Cargo.EsNuevo Then
      'Me.CtlCargo1Jefe.Cargo = Cargo.CargoJefe
      'Else
      Dim _cargo As New Cargo(Sistema.OperadorDatos, cboDepartamentoJefe.ParametroDet.Parame_Codigo, cboDepartamentoJefe.ParametroDet.Pardet_Secuencia, CtlArea1Jefe.Area.Parame_Area, CtlArea1Jefe.Area.Pardet_Area, Cargo.Cargo_Secuencia)
      Me.CtlCargo1Jefe.Cargo = _cargo
      'End If
    Catch ex As Exception
    End Try

    Me.cboEscalafon.ParametroDet = Cargo.PardetEscalafon
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Dim bandera As Integer = 0
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          Dim esnuevo As Boolean = Cargo.EsNuevo

          If cboDepartamento.ParametroDet IsNot Nothing Then
            Cargo.PardetDepartamento = Me.cboDepartamento.ParametroDet
          Else
            MsgBox("Debe seleccionar un departamento", MsgBoxStyle.Information, "Información")
            e.Cancel = True
            Exit Sub
          End If
          If CtlArea1.Area IsNot Nothing Then
            Cargo.Area = Me.CtlArea1.Area
          Else
            MsgBox("Debe seleccionar un area", MsgBoxStyle.Information, "Información")
            e.Cancel = True
            Exit Sub
          End If
          Cargo.Cargo_Descripcion = Me.txtDescripcion.Text
          Cargo.PardetActividadSectorial = Me.ComboBoxActividadSectorial.ParametroDet
          Cargo.PardetModeloLabor = Me.CtlModeloLabor1.ModeloLabor
          Cargo.Cargo_ControlarHorasExtras = Me.chkControlarHE.Checked
          If Me.chkTieneJefe.Checked Then
            If cboDepartamentoJefe.ParametroDet IsNot Nothing Then
              Cargo.PardetDepartamentoJefe = Me.cboDepartamentoJefe.ParametroDet
            Else
              MsgBox("Debe seleccionar un departamento para el jefe inmediato", MsgBoxStyle.Information, "Información")
              e.Cancel = True
              Exit Sub
            End If
            If CtlArea1Jefe.Area IsNot Nothing Then
              Cargo.AreaJefe = Me.CtlArea1Jefe.Area
            Else
              MsgBox("Debe seleccionar un area para el jefe inmediato", MsgBoxStyle.Information, "Información")
              e.Cancel = True
              Exit Sub
            End If
            If CtlCargo1Jefe.Cargo IsNot Nothing Then
              Cargo.Cargo_SecuenciaJefe = Me.CtlCargo1Jefe.Cargo.Cargo_Secuencia
            Else
              MsgBox("Debe seleccionar un cargo para el jefe inmediato", MsgBoxStyle.Information, "Información")
              e.Cancel = True
              Exit Sub
            End If
          Else
            Cargo.PardetDepartamentoJefe = Nothing
            Cargo.PardetAreaJefe = Nothing
            Cargo.Cargo_SecuenciaJefe = 0
          End If
          Cargo.PardetEscalafon = Me.cboEscalafon.ParametroDet
          If Not Cargo.Guardar() Then
            Throw New Exception(Cargo.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not Cargo.Eliminar() Then
            Throw New Exception(Cargo.OperadorDatos.MsgError)
          End If
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

  Private Sub FrmMantenimientoCargo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cboSeccion.OperadorDatos = Sistema.OperadorDatos
    Me.cboSeccion.Parametro = Enumerados.EnumParametros.Seccion
    Me.cboSeccion.Llenar_Datos()

    Me.cboDepartamento.OperadorDatos = Sistema.OperadorDatos
    Me.cboDepartamento.Parametro = Enumerados.EnumParametros.Departamento
    Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)

    Me.CtlArea1.Op = Sistema.OperadorDatos
    Try
      Me.CtlArea1.Seccion = cboSeccion.ParametroDet
      Me.CtlArea1.Departamento = cboDepartamento.ParametroDet
      Me.CtlArea1.llenar_datos()
    Catch ex As Exception
    End Try

    Me.CtlModeloLabor1.Op = Sistema.OperadorDatos
    Me.CtlModeloLabor1.llenar_datos()

    Me.ComboBoxActividadSectorial.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxActividadSectorial.Parametro = Enumerados.EnumParametros.ActividadSectorial
    Me.ComboBoxActividadSectorial.Llenar_Datos()

    Me.cboSeccionJefe.OperadorDatos = Sistema.OperadorDatos
    Me.cboSeccionJefe.Parametro = Enumerados.EnumParametros.Seccion
    Me.cboSeccionJefe.Llenar_Datos()

    Me.cboDepartamentoJefe.OperadorDatos = Sistema.OperadorDatos
    Me.cboDepartamentoJefe.Parametro = Enumerados.EnumParametros.Departamento
    Me.cboDepartamentoJefe.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccionJefe.ParametroDet)

    Me.CtlArea1Jefe.Op = Sistema.OperadorDatos
    Try
      Me.CtlArea1Jefe.Seccion = cboSeccionJefe.ParametroDet
      Me.CtlArea1Jefe.Departamento = cboDepartamentoJefe.ParametroDet
      Me.CtlArea1Jefe.llenar_datos()
    Catch ex As Exception
    End Try

    Me.CtlCargo1Jefe.Op = Sistema.OperadorDatos
    Try
      Me.CtlCargo1Jefe.Area = CtlArea1Jefe.Area
      Me.CtlCargo1Jefe.llenar_datos()
    Catch ex As Exception
    End Try

    Me.cboEscalafon.OperadorDatos = Sistema.OperadorDatos
    Me.cboEscalafon.Parametro = Enumerados.EnumParametros.Escalafon
    Me.cboEscalafon.Llenar_Datos()
  End Sub
#End Region

  Private Sub cboSeccion_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.CambioItem
    If Not mCargando Then
      Me.cboDepartamento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccion.ParametroDet)
    End If
  End Sub

  Private Sub cboDepartamento_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.CambioItem
    If Not mCargando Then
      Try
        Me.CtlArea1.Seccion = cboSeccion.ParametroDet
        Me.CtlArea1.Departamento = cboDepartamento.ParametroDet
        Me.CtlArea1.llenar_datos()
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private Sub cboSeccionJefe_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccionJefe.CambioItem
    If Not mCargando Then
      Me.cboDepartamentoJefe.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, cboSeccionJefe.ParametroDet)
    End If
  End Sub

  Private Sub cboDepartamentoJefe_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamentoJefe.CambioItem
    If Not mCargando Then
      Try
        Me.CtlArea1Jefe.Seccion = cboSeccionJefe.ParametroDet
        Me.CtlArea1Jefe.Departamento = cboDepartamentoJefe.ParametroDet
        Me.CtlArea1Jefe.llenar_datos()
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private Sub CtlArea1Jefe_CambioItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlArea1Jefe.CambioItem
    If Not mCargando Then
      Llenar_cargos()
    End If
  End Sub

  Sub Llenar_cargos()
    Try
      Dim _area As New Area(Cargo.OperadorDatos, Me.CtlArea1Jefe.Area.Parame_Departamento, Me.CtlArea1Jefe.Area.Pardet_Departamento, Me.CtlArea1Jefe.Area.Parame_Area, Me.CtlArea1Jefe.Area.Pardet_Area)

      Me.CtlCargo1Jefe.Area = _area
      Me.CtlCargo1Jefe.llenar_datos()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub chkTieneJefe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTieneJefe.CheckedChanged
    Me.Panel2.Visible = Me.chkTieneJefe.Checked
  End Sub
End Class