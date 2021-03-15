Imports Infoware.Datos
Imports Infoware.Controles.Base
'Imports Infoware.Modulos.Base

Public Class FrmConexion
  Implements IMantenimiento

  Private mOperadorDatos As OperadorDatos
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      Refrescar_forma()
    End Set
  End Property

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
    End Set
  End Property

  Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not OperadorDatos Is Nothing Then
      Me.txtservidor.Text = OperadorDatos.Servidor
      Me.txtbase.Text = OperadorDatos.Base
      Me.txtusuario.Text = OperadorDatos.Usuario
      Me.txtclave.Text = OperadorDatos.Clave
      Me.chkseguridadintegrada.Checked = OperadorDatos.SeguridadIntegrada
    End If

    Dim _complete As New AutoCompleteStringCollection
    Dim x As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
    For Each _dr As DataRow In x.GetDataSources.Rows
      Dim _servidor As String
      If TypeOf _dr(1) Is DBNull Then
        _servidor = String.Format("{0}", _dr(0).trim)
      Else
        _servidor = String.Format("{0}{1}{2}", _dr(0).trim, "\", _dr(1).trim)
      End If
      _complete.Add(_servidor)
      Me.txtservidor.Items.Add(_servidor)
    Next

    Me.txtservidor.AutoCompleteCustomSource = _complete

    Me.txtservidor.Enabled = True
    Me.txtbase.Enabled = True
    Me.txtusuario.Enabled = True
    Me.txtclave.Enabled = True
    Me.chkseguridadintegrada.Enabled = True

    Select Case mDireccion
      Case IMantenimiento.Accion.Ingreso
        MyBase.TextoAceptar = "Ingresar"
      Case IMantenimiento.Accion.Eliminacion
        Me.txtservidor.Enabled = False
        Me.txtbase.Enabled = False
        Me.txtusuario.Enabled = False
        Me.txtclave.Enabled = False
        Me.chkseguridadintegrada.Enabled = False
        MyBase.TextoAceptar = "Eliminar"
      Case IMantenimiento.Accion.Modificacion
        MyBase.TextoAceptar = "Modificar"
        Me.txtservidor.Enabled = True
        Me.txtbase.Enabled = True
        Me.txtusuario.Enabled = True
        Me.txtclave.Enabled = True
        Me.chkseguridadintegrada.Enabled = True
    End Select
  End Sub

  Private Sub FrmConexion_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          OperadorDatos = OperadorDatosFactory.CrearInstancia(enumProveedorDatos.SQL, Me.txtservidor.Text, Me.txtbase.Text, Me.txtusuario.Text, Me.txtclave.Text, Me.chkseguridadintegrada.Checked)
          'OperadorDatos.Servidor = Me.txtservidor.Text
          'OperadorDatos.Base = Me.txtbase.Text
          'OperadorDatos.Usuario = Me.txtusuario.Text
          'OperadorDatos.Clave = Me.txtclave.Text
          'OperadorDatos.SeguridadIntegrada = Me.chkseguridadintegrada.Checked
        Case IMantenimiento.Accion.Eliminacion
      End Select
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      e.Cancel = True
    End Try
  End Sub

 
  Private Sub txtservidor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservidor.SelectedIndexChanged

  End Sub
End Class
