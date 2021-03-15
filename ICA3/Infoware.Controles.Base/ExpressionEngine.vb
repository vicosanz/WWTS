Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports System.Text
Imports System.Reflection

Public Class ExpressionEngine
  Private oEnsamblado As System.Reflection.Assembly

  Public Sub New()

  End Sub

  Public Function PrecompilarAssembly(ByVal Funcion As String, _
 ByVal ParametrosList() As String, ByVal NameSpaceList() As String) As Boolean

    Dim mStrings As String
    Dim mParametros As String = String.Empty
    'Definimos un objeto de tipo StringBuilder que contendra el código a compilar
    Dim CodigoFuente As New StringBuilder()

    'Agregamos los Imports necesarios a nuestro codigo fuente 
    For Each mStrings In NameSpaceList
      CodigoFuente.Append("Imports " & mStrings & vbCr)
    Next

    'Preparamos un string con los parametros que usará el metodo Eval 
    'de de la clase EvalClase 
    For Each mStrings In ParametrosList
      mParametros &= ", " & mStrings
    Next

    mParametros = Trim(mParametros)
    If mParametros.Length > 0 Then
      mParametros = Trim(Mid(mParametros, 2))
    End If

    'Terminamos de construir la clase a compilar
    CodigoFuente.Append("Public Class EvalClase" & vbCr)
    CodigoFuente.Append(" Public Shared Function Eval(" & _
       mParametros & ") as Object" & vbCr)
    CodigoFuente.Append(" Return " & Funcion & vbCr)
    CodigoFuente.Append(" End Function " & vbCr)
    CodigoFuente.Append("End Class " & vbCr)

    'Creamos una instancia de la clase VBCodeProvider 
    'que usaremos para obtener una referencia a una interfaz ICodeCompiler
    Dim oCProvider As New VBCodeProvider()
    'Dim oCompiler As ICodeCompiler = oCProvider.CreateCompiler

    'Usamos la clase CompilerParameters para pasar parámetros al compilador
    'En particular, definimos que el assembly sea compilado en memoria.
    Dim oCParam As New CompilerParameters()
    oCParam.GenerateInMemory = True

    'Creamos un objeto CompilerResult que obtendrá los resultados de la compilación
    Dim oCResult As CompilerResults
    oCResult = oCProvider.CompileAssemblyFromSource(oCParam, CodigoFuente.ToString)

    'Comprobamos que no existan errores de compilación.
    'Dim oCError As CompilerError
    If oCResult.Errors.Count > 0 Then
      'Si existen errores los mostramos.
      'Si bien, podriamos implementar un mejor método para visualizar 
      'los errores de compilación, este nos servirá por los momentos.
      'For Each oCError In oCResult.Errors
      '  MsgBox(oCError.ErrorText.ToString)
      'Next
      Return False
    Else
      'Como el ensamblado se generó en memoria, debemos obtener 
      'una referencia al ensamblado generado, para esto usamos 
      'la propiedad CompiledAssembly
      oEnsamblado = oCResult.CompiledAssembly
      Return True
    End If
  End Function

  Public Function Evaluar(ByVal ParamArray Parametros() As Object) As Object
    If oEnsamblado Is Nothing Then
      Return Nothing
    Else
      'Instanciamos la clase EvalClase de nuestro assembly 
      'creando un tipo a partir de ella.
      Dim oClass As Type = oEnsamblado.GetType("EvalClase")

      'Usamos GetMethod para accesar al método Eval, e invocamos este con los parametros necesarios.
      Return oClass.GetMethod("Eval").Invoke(Nothing, Parametros)
    End If
  End Function

End Class

