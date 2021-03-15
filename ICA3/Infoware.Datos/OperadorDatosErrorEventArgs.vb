Imports System
Imports System.Data.SqlClient

Public Class OperadorDatosErrorEventArgs
  Inherits EventArgs

#Region "Campos Públicos Readonly de la Clase"
  Public Number As Integer
  Public Message As String
  Public Gravity As Byte
  Public State As Byte
  Public Procedure As String
  Public Source As String
  Public TypeName As String
#End Region

#Region "Constructores de la clase"
  Public Sub New(ByVal e As Exception, ByVal source As String) '
    Me.Message = e.Message
    Me.Source = source
    Me.TypeName = e.GetType().Name

    Me.Number = 0
    Me.Gravity = 0
    Me.State = 0
    Me.Procedure = String.Empty
  End Sub 'New

  Public Sub New(ByVal sqlError As SqlError)
    Me.Number = sqlError.Number
    Me.Message = sqlError.Message
    Me.Gravity = sqlError.Class
    Me.State = sqlError.State
    Me.Procedure = sqlError.Procedure
    Me.Source = sqlError.Source
    Me.TypeName = sqlError.GetType().Name
  End Sub 'New
#End Region
End Class

Public Delegate Sub OperadorDatosErrorEventHandler(ByVal sender As Object, ByVal e As OperadorDatosErrorEventArgs)
