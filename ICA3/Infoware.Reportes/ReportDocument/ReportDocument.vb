Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Windows.Forms

Public Class ReportDocument
  Inherits PrintDocument

#Region " Event declarations "

  ''' <summary>
  ''' Raised once immediately before anything is printed to the report. The cursor is on the first line of the first page.
  ''' </summary>
  Public Event ReportBegin(ByVal sender As Object, _
    ByVal e As ReportPageEventArgs)
  ''' <summary>
  ''' Raised for each page immediately before anything is printed to that page. The cursor is on the first line of the page.
  ''' </summary>
  Public Event PrintPageBegin(ByVal sender As Object, _
    ByVal e As ReportPageEventArgs)
  ''' <summary>
  ''' Raised for each page immediately after the header for the page has been printed. The cursor is on the first line of the report body.
  ''' </summary>
  Public Event PrintPageBodyStart(ByVal sender As Object, _
    ByVal e As ReportPageEventArgs)
  ''' <summary>
  ''' Raised for each page immediately before the footer for the page is printed. The cursor is on the first line of the header.
  ''' </summary>
  Public Event PrintPageBodyEnd(ByVal sender As Object, _
    ByVal e As ReportPageEventArgs)
  ''' <summary>
  ''' Raised for each page after the footer has been printed. The cursor is past the end of the footer, typically into the bottom margin of the page.
  ''' </summary>
  Public Event PrintPageEnd(ByVal sender As Object, _
    ByVal e As ReportPageEventArgs)
  ''' <summary>
  ''' Raised once at the very end of the report after all other printing is complete. The cursor is past the end of the footer on the last page, typically into the bottom margin of the page.
  ''' </summary>
  Public Event ReportEnd(ByVal sender As Object, _
    ByVal e As ReportPageEventArgs)

#End Region

#Region "Banda de título"
  Private mTieneBandaTitulo As Boolean = False
  Public Property TieneBandaTitulo() As Boolean
    Get
      Return mTieneBandaTitulo
    End Get
    Set(ByVal value As Boolean)
      mTieneBandaTitulo = value
    End Set
  End Property

  Private mNuevaPaginaBandaTitulo As Boolean = False
  Public Property NuevaPaginaBandaTitulo() As Boolean
    Get
      Return mNuevaPaginaBandaTitulo
    End Get
    Set(ByVal value As Boolean)
      mNuevaPaginaBandaTitulo = value
    End Set
  End Property

  Public Overridable Sub ImprimirBandaTitulo(ByVal e As ReportPageEventArgs)
    With e
      .WriteLine(String.Format("Creado por {0}", My.Application.Info.ProductName))
    End With
  End Sub
#End Region

#Region "Banda de resumen"
  Private mTieneBandaResumen As Boolean = False
  Public Property TieneBandaResumen() As Boolean
    Get
      Return mTieneBandaResumen
    End Get
    Set(ByVal value As Boolean)
      mTieneBandaResumen = value
    End Set
  End Property

  Private mNuevaPaginaBandaResumen As Boolean = False
  Public Property NuevaPaginaBandaResumen() As Boolean
    Get
      Return mNuevaPaginaBandaResumen
    End Get
    Set(ByVal value As Boolean)
      mNuevaPaginaBandaResumen = value
    End Set
  End Property

  Public Overridable Sub ImprimirBandaResumen(ByVal e As ReportPageEventArgs)
    With e
      .HorizontalRule()
      .WriteLine()
      For index As Integer = 0 To mColumns.Count - 1
        If mColumns(index).Totalizar Then
          .WriteColumn(mColumns(index).Resultado, mColumns(index))
        End If
      Next
      .WriteLine()
    End With
  End Sub
#End Region

#Region "Columnas"
  Private mColumns As New ReportColumnCollection()
  Private Sub Recalcular_columnas(ByVal e As ReportPageEventArgs)
    If mColumns IsNot Nothing Then
      Dim mleft As Integer = 0
      For index As Integer = 0 To mColumns.Count - 1
        If mColumns(index).Totalizar Then
          mColumns(index).Suma = 0
          mColumns(index).Conteo = 0
        End If

        mColumns(index).Left = mleft + mColumns.EspacioEntreColumnas

        If mColumns(index).AnchoPorc > 0 Then
          mColumns(index).Ancho = e.MarginBounds.Width * mColumns(index).AnchoPorc
        End If
        mleft += mColumns(index).Ancho
      Next
    End If
  End Sub
#End Region

#Region "Encabezado"
  Private mTitulo As String = String.Empty
  Public Property Titulo() As String
    Get
      Return mTitulo
    End Get
    Set(ByVal value As String)
      mTitulo = value
    End Set
  End Property

  Public Overridable Sub ImprimirEncabezado(ByVal e As ReportPageEventArgs)
    With e
      .WriteLine()
      .WriteLine(mTitulo, ReportLineJustification.Centered, New Font(e.Font.FontFamily, e.Font.Size + 2, CType(FontStyle.Bold + FontStyle.Underline, FontStyle)))
      .Write(Now.ToShortDateString, ReportLineJustification.Right)
      .WriteLine()
      .Write(Now.ToShortTimeString, ReportLineJustification.Right)
      .WriteLine()
      .WriteLine()
      Dim _font As Font = e.Font
      e.Font = New Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold)
      For index As Integer = 0 To mColumns.Count - 1
        .WriteColumn(mColumns(index).Titulo, mColumns(index))
      Next
      e.Font = _font
      .WriteLine()
      .HorizontalRule()
    End With
  End Sub
#End Region

#Region "Pie de pagina"
  Public Overridable Sub AntesImprimirPiedePagina(ByVal e As ReportPageEventArgs)
    e.CurrentY = e.PageBottom
    e.FooterLines = mFooterLines
  End Sub

  Private mFooterLines As Integer = 2
  Public Property FooterLines() As Integer
    Get
      Return mFooterLines
    End Get
    Set(ByVal value As Integer)
      mFooterLines = value
    End Set
  End Property

  Public Overridable Sub ImprimirPiedePagina(ByVal e As ReportPageEventArgs)
    With e
      .HorizontalRule()
      ' .WriteLine()
      .Write(My.Application.Info.ProductName)
      .Write(String.Format("Pág.# {0}", e.PageNumber), ReportLineJustification.Right)
    End With
  End Sub
#End Region

#Region "Imprimir"
  Private mFont As Font
  Public Property Font() As Font
    Get
      If mFont Is Nothing Then
        mFont = New Font("Courier New", 10)
      End If
      Return mFont
    End Get
    Set(ByVal Value As Font)
      mFont = Value
    End Set
  End Property

  Private mBrush As Brush = Brushes.Black
  Public Property Brush() As Brush
    Get
      Return mBrush
    End Get
    Set(ByVal Value As Brush)
      mBrush = Value
    End Set
  End Property

  Private mPageNumber As Integer = 0
  Private mRow As Integer = 0
  Private Sub ReportDocument_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeginPrint
    mPageNumber = 0
    mRow = 0
  End Sub

  Private mEstaImprimiendoPie As Boolean = False
  Private Sub ReportDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Me.PrintPage
    mPageNumber += 1
    Dim page As New ReportPageEventArgs(e, mPageNumber, Font, Brush, FooterLines)

    RaiseEvent PrintPageBegin(Me, page)
    If mPageNumber = 1 Then
      Recalcular_columnas(page)

      mEstaImprimiendoPie = False
      RaiseEvent ReportBegin(Me, page)

      If TieneBandaTitulo Then
        ImprimirBandaTitulo(page)

        If NuevaPaginaBandaTitulo Then
          e.HasMorePages = True
          Exit Sub
        End If
      End If
    End If

    ImprimirEncabezado(page)
    If Not mEstaImprimiendoPie Then
      ImprimirDetalle(page)

      e.Cancel = page.Cancel
      e.HasMorePages = page.HasMorePages
      If Not page.HasMorePages Then
        mEstaImprimiendoPie = True

        If TieneBandaResumen And (NuevaPaginaBandaResumen Or Not PuedeImprimirResumen(page)) Then
          AntesImprimirPiedePagina(page)
          ImprimirPiedePagina(page)
          e.HasMorePages = True
          Exit Sub
        End If
      Else
        AntesImprimirPiedePagina(page)
        ImprimirPiedePagina(page)
      End If
    End If

    If mEstaImprimiendoPie Then
      If TieneBandaResumen Then
        ImprimirBandaResumen(page)
      End If
      AntesImprimirPiedePagina(page)
      ImprimirPiedePagina(page)
      e.HasMorePages = False
      RaiseEvent ReportEnd(Me, page)
    End If
  End Sub

  Public Overridable Function PuedeImprimirResumen(ByVal e As ReportPageEventArgs) As Boolean
    Return True
  End Function

  Public Overridable Sub ImprimirDetalle(ByVal e As ReportPageEventArgs)
    Dim InnerSource As IList = InnerDataSource()
    Dim Field As Integer

    ' we're about to print the page
    'RaiseEvent PrintPageBegin(Me, e)

    ' we're about to print the body of the page
    RaiseEvent PrintPageBodyStart(Me, e)

    ' if we're data bound automatically generate the output
    ' based on the data from the data source
    If Not mDataSource Is Nothing AndAlso mColumns.Count > 0 Then
      ' load the data into the control
      While Not e.EndOfPage AndAlso mRow < InnerSource.Count
        ' load all subfields
        For Field = 0 To mColumns.Count - 1
          e.WriteColumn(GetField(InnerSource.Item(mRow), mColumns(Field).Field), mColumns(Field))
        Next
        e.WriteLine()
        mRow += 1
      End While

      e.HasMorePages = mRow < InnerSource.Count
    End If
    ' we're done generating the body of this page
    RaiseEvent PrintPageBodyEnd(Me, e)

    ' we're all done with the page
    RaiseEvent PrintPageEnd(Me, e)
  End Sub

#End Region

#Region "Data"
  Public WriteOnly Property DataGridView() As DataGridView
    Set(ByVal value As DataGridView)
      If value IsNot Nothing Then
        Me.Font = New Font(value.Font.FontFamily, 10, value.Font.Style)
        If TypeOf value.DataSource.datasource Is Infoware.Reglas.SortedView Then
          AutoDiscover = False
          DataSource = CType(value.DataSource.datasource, Infoware.Reglas.SortedView)

          For Each _col As DataGridViewColumn In value.Columns
            Dim _repcol As New ReportColumn
            _repcol.Titulo = _col.HeaderText
            _repcol.Field = _col.DataPropertyName
            _repcol.Ancho = _col.Width
            _repcol.Format = _col.DefaultCellStyle.Format
            Select Case _col.DefaultCellStyle.Alignment
              Case DataGridViewContentAlignment.BottomLeft, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.TopLeft, DataGridViewContentAlignment.NotSet
                _repcol.Justificacion = EnumJustificacion.Left
              Case DataGridViewContentAlignment.BottomRight, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.TopRight
                _repcol.Justificacion = EnumJustificacion.Right
              Case DataGridViewContentAlignment.BottomCenter, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.TopCenter
                _repcol.Justificacion = EnumJustificacion.Centered
            End Select
            If _col.Tag IsNot Nothing Then
              Select Case _col.Tag.ToString.Trim.ToUpper
                Case "SUMA"
                  _repcol.Totalizar = True
                  _repcol.TipoTotal = ReportColumn.EnumTipoTotal.Suma
                Case "PROMEDIO"
                  _repcol.Totalizar = True
                  _repcol.TipoTotal = ReportColumn.EnumTipoTotal.Promedio
                Case "CONTAR"
                  _repcol.Totalizar = True
                  _repcol.TipoTotal = ReportColumn.EnumTipoTotal.Contar
              End Select
            End If
            mColumns.Add(_repcol)
          Next
        Else
          AutoDiscover = True
          DataSource = value.DataSource.datasource
        End If
      End If
    End Set
  End Property

#Region " DataSource/DataMember "
  Private mAutoDiscover As Boolean

  Private mDataSource As Object
  ''' <summary>
  ''' By setting this property we provide the report with a data source. The
  ''' data in the data source will be rendered into the report in tabular
  ''' format based on the columns defined in the <see cref="P:vbReport.ReportDocument.Columns" />
  ''' property.
  ''' </summary>
  ''' <value>A valid data source.</value>
  <Category("Data"), RefreshProperties(RefreshProperties.Repaint), TypeConverter("System.Windows.Forms.Design.DataSourceConverter," & "System.Design")> Public Property DataSource() As Object
    Get
      Return mDataSource
    End Get
    Set(ByVal Value As Object)
      mDataSource = Value
      SetSource()
      If mAutoDiscover Then
        DoAutoDiscover()
      End If
      'mRow = 0
    End Set
  End Property

  Private mDataMember As String
  ''' <summary>
  ''' The DataMember property allows us to easily set a single column
  ''' of data to be displayed when the report is bound to a data source.
  ''' If we want to display multiple columns of data in the report
  ''' we should use the <see cref="P:vbReport.ReportDocument.Columns" />
  ''' property to define the columns.
  ''' </summary>
  ''' <value>A valid data source.</value>
  <Category("Data"), Editor("System.Windows.Forms.Design.DataMemberListEditor," & "System.Design", GetType(System.Drawing.Design.UITypeEditor))> Public Property DataMember() As String
    Get
      Return mDataMember
    End Get
    Set(ByVal Value As String)
      mDataMember = Value
      SetSource()
      If mAutoDiscover Then
        DoAutoDiscover()
      End If
      'mRow = 0
    End Set
  End Property

  Private WithEvents mBindingList As IBindingList
  Private Sub SetSource()
    Dim InnerSource As IList = InnerDataSource()
    If TypeOf InnerSource Is IBindingList Then
      mBindingList = CType(InnerSource, IBindingList)
    Else
      mBindingList = Nothing
    End If
  End Sub

  Private Function InnerDataSource() As IList
    If TypeOf mDataSource Is DataSet Then
      If Len(mDataMember) > 0 Then
        Return CType(CType(mDataSource, DataSet).Tables(mDataMember), IListSource).GetList
      Else
        Return CType(CType(mDataSource, DataSet).Tables(0), IListSource).GetList
      End If
    ElseIf TypeOf mDataSource Is IListSource Then
      Return CType(mDataSource, IListSource).GetList
    Else
      Return CType(mDataSource, IList)
    End If
  End Function
#End Region

#Region " AutoDiscover "

  <Category("Data")> _
  Public Property AutoDiscover() As Boolean
    Get
      Return mAutoDiscover
    End Get
    Set(ByVal Value As Boolean)
      If mAutoDiscover = False AndAlso Value = True Then
        mAutoDiscover = Value
        DoAutoDiscover()
      Else
        mAutoDiscover = Value
        If mAutoDiscover = False Then
          mColumns.Clear()
        End If
      End If
    End Set
  End Property

  Private Sub DoAutoDiscover()
    Dim InnerSource As IList = InnerDataSource()
    mColumns.Clear()
    If InnerSource Is Nothing Then Exit Sub
    If TypeOf InnerSource Is DataView Then
      DoAutoDiscover(CType(InnerSource, DataView))
    Else
      DoAutoDiscover(InnerSource)
    End If
  End Sub

  Private Sub DoAutoDiscover(ByVal ds As DataView)

    Dim field As Integer
    Dim col As ReportColumn

    For field = 0 To ds.Table.Columns.Count - 1
      col = New ReportColumn()
      col.Titulo = ds.Table.Columns(field).Caption
      col.Field = ds.Table.Columns(field).ColumnName
      mColumns.Add(col)
    Next
    'mColumns.SetEvenSpacing(650)
  End Sub

  Private Sub DoAutoDiscover(ByVal ds As IList)
    If ds.Count > 0 Then
      ' retrieve the first item from the list
      Dim obj As Object = ds.Item(0)

      If TypeOf obj Is ValueType AndAlso obj.GetType.IsPrimitive Then
        ' the value is a primitive value type
        Dim col As ReportColumn
        col = New ReportColumn()
        col.Titulo = "Value"
        mColumns.Add(col)

      ElseIf TypeOf obj Is String Then
        ' the value is a simple string
        Dim col As ReportColumn
        col = New ReportColumn()
        col.Titulo = "Text"
        mColumns.Add(col)

      Else
        ' the value is an object or Structure
        Dim SourceType As Type = obj.GetType
        Dim column As Integer

        ' retrieve a list of all public properties
        Dim props As PropertyInfo() = SourceType.GetProperties()
        If UBound(props) >= 0 Then
          For column = 0 To UBound(props)
            mColumns.Add(props(column).Name)
          Next
        End If

        ' retrieve a list of all public fields
        Dim fields As FieldInfo() = SourceType.GetFields()
        If UBound(fields) >= 0 Then
          For column = 0 To UBound(fields)
            mColumns.Add(fields(column).Name)
          Next
        End If
      End If
    End If
  End Sub

#End Region

#Region " GetField "

  Public Function GetField(ByVal obj As Object, ByVal FieldName As String) As Object
    If TypeOf obj Is DataRowView Then
      ' this is a DataRowView from a DataView
      Return CType(obj, DataRowView).Item(FieldName)

    ElseIf TypeOf obj Is ValueType AndAlso obj.GetType.IsPrimitive Then
      ' this is a primitive value type
      Return obj

    ElseIf TypeOf obj Is String Then
      ' this is a simple string
      Return CStr(obj)

    Else
      ' this is an object or Structure
      Try
        Dim sourcetype As Type = obj.GetType

        ' see if the field is a property
        Dim prop As PropertyInfo = sourcetype.GetProperty(FieldName)

        If prop Is Nothing OrElse Not prop.CanRead Then
          ' no readable property of that name exists - check for a field
          Dim field As FieldInfo = sourcetype.GetField(FieldName)

          If field Is Nothing Then
            ' no field exists either, return the field name
            ' as a debugging indicator
            Return "Campo no válido " & FieldName

          Else
            ' got a field, return its value
            If field.GetValue(obj) Is Nothing Then
              Return String.Empty
            Else
              Return field.GetValue(obj)
            End If
          End If

        Else
          ' found a property, return its value
          Return prop.GetValue(obj, Nothing)
        End If

      Catch ex As Exception
        Return ex.Message
      End Try
    End If
  End Function

#End Region
#End Region
End Class


