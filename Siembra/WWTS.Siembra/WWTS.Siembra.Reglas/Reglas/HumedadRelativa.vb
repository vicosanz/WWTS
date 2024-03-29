'------------------------------------------------------------------------------
' <auto-generated>
'     Este c�digo fue generado por una herramienta.
'     Versi�n del motor en tiempo de ejecuci�n:2.0.50727.42
'
'     Los cambios en este archivo podr�an causar un comportamiento incorrecto y se perder�n si
'     se vuelve a generar el c�digo.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports WWTS.General.Reglas

Public Class HumedadRelativa

#Region "Campos constantes"
    Private Const _Procedimiento As String = "proc_HumedadRelativa"
#End Region

#Region "Campos variables"
#End Region

#Region "Propiedades p�blicas de la clase"
#End Region

#Region "Constructores de la clase"
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _nuevo As Boolean)
        If _OperadorDatos Is Nothing Then
            Throw New InvalidOperationException("El operador de datos es nulo")
        End If

        OperadorDatos = _OperadorDatos
        EsNuevo = _nuevo
    End Sub

    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _HumRel_Dry As Integer, ByVal _HumRel_Wet As Integer, ByVal _Nuevo As Boolean)
        If _OperadorDatos Is Nothing Then
            Throw New InvalidOperationException("El operador de datos es nulo")
        End If
        OperadorDatos = _OperadorDatos
        HumRel_Dry = _HumRel_Dry
        HumRel_Wet = _HumRel_Wet
        EsNuevo = _Nuevo
        If Not _Nuevo Then
            If Not Me.Recargar Then
                Throw New Exception("El objeto no puede ser cargado")
            End If
        End If
    End Sub
#End Region

#Region "Implementaci�n de los m�todos de persistencia"
    Public Function Recargar() As Boolean
        Dim dsResult As New DataSet
        Dim bResult As Boolean

        With OperadorDatos
            .AgregarParametro("@accion", "C")
            .AgregarParametro("@HumRel_Dry", mHumRel_Dry)
            .AgregarParametro("@HumRel_Wet", mHumRel_Wet)
            .Procedimiento = _Procedimiento
            bResult = .Ejecutar(dsResult)
            .LimpiarParametros()
        End With
        If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Tables.Count > 0 AndAlso dsResult.Tables(0).Rows.Count > 0 Then
            Me.MapearDataRowaObjeto(dsResult.Tables(0).Rows(0))
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "M�todos internos de la clase"
    Private Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
        mHumRel_Dry = CInt(Fila("HumRel_Dry"))
        mHumRel_Wet = CInt(Fila("HumRel_Wet"))
        mHumRel_Valor = CInt(Fila("HumRel_Valor"))
    End Sub

    Public Function Guardar() As Boolean
        Dim dsResult As New DataSet
        Dim bReturn As Boolean

        Dim sAccion As String = String.Empty
        If EsNuevo Then
            sAccion = "I"
        Else
            sAccion = "M"
        End If
        With OperadorDatos
            .AgregarParametro("@accion", sAccion)
            .AgregarParametro("@HumRel_Dry", mHumRel_Dry)
            .AgregarParametro("@HumRel_Wet", mHumRel_Wet)
            .AgregarParametro("@HumRel_Valor", mHumRel_Valor)
            .Procedimiento = _Procedimiento
            bReturn = .Ejecutar(dsResult)
            .LimpiarParametros()
            If bReturn Then
                If Not OperadorDatos.EstaenTransaccion Then
                    EsNuevo = False
                    EsModificado = False
                End If
            End If
        End With
        Return bReturn
    End Function

    Public Function Eliminar() As Boolean
        Dim dsResult As New DataSet
        Dim bReturn As Boolean
        With OperadorDatos
            .AgregarParametro("@accion", "E")
            .AgregarParametro("@HumRel_Dry", mHumRel_Dry)
            .AgregarParametro("@HumRel_Wet", mHumRel_Wet)
            .Procedimiento = _Procedimiento
            bReturn = .Ejecutar(dsResult)
            .LimpiarParametros()
        End With
        Return bReturn
    End Function
#End Region

#Region "M�todos compartidos"
#End Region
End Class

Public Class HumedadRelativaCollection
    Inherits System.ComponentModel.BindingList(Of HumedadRelativa)
    Public Sub New()
	End Sub

End Class
