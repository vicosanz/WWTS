using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public partial class FrmListaSimpleBase : FrmFormaBase, IOpcion
    {
        public BindingSource ListBindingSource
        {
            get => BindingSource;
            set
            {
                BindingSource = value;
                if (value != null)
                {
                    BindingSource.CurrentChanged += Actualizar_Click;
                }
            }
        }
        
        public string Titulo
        {
            set
            {
                string _titulo = value;
                Text = _titulo;
                ToolStriptitulo.Text = _titulo;
            }
        }

        public string AutoMailAsunto { get; set; }
        public string AutoMailArchivo { get; set; }
        public string AutoMailLista { get; set; }

        private string mDocSalida;
        public string DocSalida
        {
            get
            {
                return mDocSalida;
            }
            set
            {
                mDocSalida = value;
                btnword.Visible = !string.IsNullOrWhiteSpace(value);
                WordToolStripMenuItem1.Visible = !string.IsNullOrWhiteSpace(value);
            }
        }

        #region RestriccionesPorCodigo

        private bool mPuedeImprimir = true;
        public bool PuedeImprimir
        {
            get { return mPuedeImprimir; }
            set
            {
                mPuedeImprimir = value;
                btnimprimir.Visible = value;
                ImprimirToolStripMenuItem.Visible = value;
            }
        }
        #endregion

        private int mAutoUpdate = 0;
        public int AutoUpdate
        {
            get
            {
                return mAutoUpdate;
            }
            set
            {
                mAutoUpdate = value;
                if (value == 0)
                {
                    Timer1.Enabled = false;
                    ToolStripProgressBar1.Visible = false;
                }
                else
                {
                    Timer1.Interval = 500;
                    ToolStripProgressBar1.Visible = true;
                    ToolStripProgressBar1.Minimum = 0;
                    ToolStripProgressBar1.Maximum = value * 2;
                    ToolStripProgressBar1.Step = 1;
                    ToolStripProgressBar1.Value = 0;
                    Timer1.Enabled = true;
                }
            }
        }

        public bool AutoMail { get; set; } = false;

        private bool mEnviandoMail = false;

        private DateTime? mProximoAutoMail = null;
        public DateTime? ProximoAutoMail
        {
            get
            {
                return mProximoAutoMail;
            }
            set
            {
                mProximoAutoMail = value;
                if (value != null)
                {
                    mEnviandoMail = false;
                    Timer2.Interval = 10000;
                    Timer2.Enabled = true;
                    btnenviomails.Visible = true;
                    btnenviomails.Text = $"El envío se realizará {mProximoAutoMail?.ToShortDateString()} {mProximoAutoMail?.ToShortTimeString()}";
                }
                else
                {
                    Timer2.Enabled = false;
                    btnenviomails.Text = "No se ha definido envío automático";
                }
            }
        }
        public ToolStrip ToolStrip => ToolStrip1;

        public MenuStrip MenuStrip => MenuStrip1;

        public Control Control => pnlcuerpo;

        public FrmListaSimpleBase()
        {
            InitializeComponent();

            AplicarRestricciones += FrmReporteBase_AplicarRestricciones;
        }

        private void FrmReporteBase_AplicarRestricciones(object sender, EventArgs e)
        {
            btnimprimir.Enabled = Restriccion.Restri_Impresion;
            ImprimirToolStripMenuItem.Enabled = Restriccion.Restri_Impresion;

            ExportarToolStripMenuItem.Enabled = Restriccion.Restri_Impresion;
            btnexportar.Enabled = Restriccion.Restri_Impresion;

            btncorreo.Enabled = Restriccion.Restri_Impresion;
            CorreoToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion;

            btnword.Enabled = Restriccion.Restri_Impresion;
            WordToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion;
        }


        #region ExportarReporte
        private void Exportar_Click(object sender, EventArgs e)
        {
            ExportarReporte();
        }

        private void ExportarReporte()
        {
            EnviarExcel();
        }
        #endregion

        #region Excel
        public event EventHandler DespuesExportarTexto;

        private string EnviarExcel(EnumSalida _output = EnumSalida.Excel,
        string _docmerge = "",
        string _archivosalida = "",
        bool _mostrarmensajes = true)
        {
            if (TabControl1.TabPages.Count == 0)
                return string.Empty;
            bool hasrows = false;
            foreach (Control tabPage in TabControl1.TabPages)
            {
                if (((DataGridView)tabPage.Controls[0]).RowCount > 0)
                {
                    hasrows = true;
                    break;
                }
            }
            if (!hasrows)
                return string.Empty;
            bool empty = true;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                ScreenUpdating = false
            };
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            bool _esTxt = false;
            int idtab = 0;
            try
            {
                foreach (TabPage tabPage in TabControl1.TabPages)
                {
                    DataGridView dg = (DataGridView)tabPage.Controls[0];
                    Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = idtab + 1 > workbook.Worksheets.Count ? workbook.Worksheets.Add(After: workbook.Worksheets[idtab]) : workbook.Worksheets[idtab + 1];
                    excelWorksheet.Name = tabPage.Text;
                    DataTable data = (DataTable)((BindingSource)dg.DataSource).DataSource;

                    for (int t = 1; t <= dg.ColumnCount; t++)
                    {
                        if (string.Equals(dg.Columns[t - 1].HeaderText.Trim().ToLower(), "txt_salida"))
                        {
                            _esTxt = true;
                            break;
                        }
                    }
                    if (!_esTxt)
                    {
                        int icol = 1;
                        for (int t = 1; t <= dg.ColumnCount; t++)
                        {
                            if (!Equals(dg.Columns[t - 1].HeaderText[0], "_"))
                            {
                                excelWorksheet.Cells[1, icol].Value = dg.Columns[t - 1].HeaderText;
                                excelWorksheet.Columns[icol].columnwidth = dg.Columns[t - 1].Width / 6.8 > byte.MaxValue ? byte.MaxValue : dg.Columns[t - 1].Width / 6.8;
                                if (dg.Columns[t - 1].HeaderText.ToUpper().IndexOf("FECHA_HORA") >= 0)
                                    excelWorksheet.Columns[icol].numberformat = "m/d/yy h:mm;@";
                                else if (_output != EnumSalida.MailMerge && data.Columns[t - 1].DataType == typeof(decimal) | data.Columns[t - 1].DataType == typeof(double))
                                    excelWorksheet.Columns[icol].numberformat = "0.00";
                                else if (_output != EnumSalida.MailMerge && data.Columns[t - 1].DataType == typeof(int) | data.Columns[t - 1].DataType == typeof(byte))
                                    excelWorksheet.Columns[icol].numberformat = "0";
                                else if (_output != EnumSalida.MailMerge && data.Columns[t - 1].DataType == typeof(DateTime))
                                    excelWorksheet.Columns[icol].numberformat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
                                else
                                    excelWorksheet.Columns[icol].numberformat = "@";
                                ++icol;
                            }
                        }
                    }
                    int _fila = 0;
                    if (_esTxt)
                        _fila = -1;

                    if (empty && data.Rows.Count > 0)
                        empty = false;
                    if (data.Rows.Count > 1000 || this.TabControl1.TabPages.Count > 3)
                    {
                        if (data.Rows.Count > 0)
                        {
                            dg.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
                            dg.SelectAll();
                            Clipboard.SetDataObject(dg.GetClipboardContent(), true);
                            dg.ClearSelection();
                            excelWorksheet.Cells[_fila + 2, 1].select();
                            excelWorksheet.Paste();
                        }
                    }
                    else
                    {

                        foreach (DataRow row in data.Rows)
                        {
                            _fila++;
                            int icol = 1;
                            for (int t = 1; t <= dg.ColumnCount; t++)
                            {
                                if (!Equals(dg.Columns[t - 1].HeaderText[0], "_"))
                                {
                                    object objectValue = row[t - 1];
                                    if (objectValue is bool boolval)
                                    {
                                        excelWorksheet.Cells[_fila + 1, icol].Value = boolval ? "Sí" : "No";
                                    }
                                    else if (objectValue is Array)
                                    {

                                    }
                                    else
                                    {
                                        if (!(objectValue is DBNull))
                                        {
                                            switch (_output)
                                            {
                                                case EnumSalida.MailMerge when data.Columns[t - 1].DataType == typeof(decimal) | data.Columns[t - 1].DataType == typeof(double):
                                                    excelWorksheet.Cells[_fila + 1, icol].Value = double.Parse(objectValue.ToString()).ToString("0.00");
                                                    break;
                                                case EnumSalida.MailMerge when data.Columns[t - 1].DataType == typeof(int) | data.Columns[t - 1].DataType == typeof(byte):
                                                    excelWorksheet.Cells[_fila + 1, icol].Value = double.Parse(objectValue.ToString()).ToString("0");
                                                    break;
                                                case EnumSalida.MailMerge when data.Columns[t - 1].DataType == typeof(DateTime):
                                                    excelWorksheet.Cells[_fila + 1, icol].Value = string.Format(objectValue.ToString(), CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
                                                    break;
                                                default:
                                                    excelWorksheet.Cells[_fila + 1, icol].Value = objectValue;
                                                    break;
                                            }
                                        }
                                    }
                                    icol++;
                                }
                            }
                        }

                    }
                    if (!_esTxt)
                    {
                        excelWorksheet.Cells[1, 1].AutoFormat(Format: Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatList3, Number: true, Font: true, Alignment: true, Border: true, Pattern: true, Width: true);
                    }

                    StructExcel structExcel = ((StructExcelList)this.TabControl1.Tag).Devolver(idtab + 1);
                    if (structExcel.Subtotales != null && structExcel.Subtotales.Count > 0)
                    {
                        foreach (StructExcel.StructSubtotales _subtotal in structExcel.Subtotales)
                        {
                            int[] _resultados = new int[_subtotal.CamposResultado.Count - 1];
                            int index = 0;
                            foreach (int num3 in _subtotal.CamposResultado)
                            {
                                _resultados[index] = num3;
                                ++index;
                            }

                            Microsoft.Office.Interop.Excel.XlConsolidationFunction _operacion = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlCount;
                            switch (_subtotal.Funcion)
                            {
                                case StructExcel.EnumFuncion.Suma:
                                    _operacion = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlSum;
                                    break;
                                case StructExcel.EnumFuncion.Promedio:
                                    _operacion = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlAverage;
                                    break;
                                case StructExcel.EnumFuncion.Cuenta:
                                    _operacion = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlCount;
                                    break;
                                case StructExcel.EnumFuncion.Maximo:
                                    _operacion = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlMax;
                                    break;
                                case StructExcel.EnumFuncion.Minimo:
                                    _operacion = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlMin;
                                    break;
                            }
                            if (_fila > 0)
                            {
                                excelWorksheet.Cells[1, 1].Subtotal(GroupBy: _subtotal.CampoAgrupado, Function: _operacion, TotalList: _resultados, Replace: true, PageBreaks: false, SummaryBelowData: true);
                            }
                        }
                    }
                    else if (structExcel.Totalizar != null && structExcel.Totalizar.Count > 0)
                    {
                        bool _ocupoprimeracolumna = false;
                        foreach (StructExcel.StructTotalizar _totalizar in structExcel.Totalizar)
                        {
                            if (_totalizar.Campo == 1)
                                _ocupoprimeracolumna = true;
                            string _formula = "";
                            switch (_totalizar.Funcion)
                            {
                                case StructExcel.EnumFuncion.Suma:
                                    _formula = "=SUM(R{1}C{0}:R{2}C{0})";
                                    break;
                                case StructExcel.EnumFuncion.Promedio:
                                    _formula = "=AVERAGE(R{1}C{0}:R{2}C{0})";
                                    break;
                                case StructExcel.EnumFuncion.Cuenta:
                                    _formula = "=COUNT(R{1}C{0}:R{2}C{0})";
                                    break;
                                case StructExcel.EnumFuncion.Maximo:
                                    _formula = "=MAX(R{1}C{0}:R{2}C{0})";
                                    break;
                                case StructExcel.EnumFuncion.Minimo:
                                    _formula = "=MIN(R{1}C{0}:R{2}C{0})";
                                    break;
                            }
                            excelWorksheet.Cells[data.Rows.Count + 2, _totalizar.Campo].FormulaR1C1 = string.Format(_formula, (_totalizar.Campo).ToString().Trim(), (2).ToString().Trim(), (data.Rows.Count + 1).ToString().Trim());
                        }
                        if (!_ocupoprimeracolumna)
                            excelWorksheet.Cells[data.Rows.Count + 2, 1] = "Totales";
                        excelWorksheet.Cells[1, 1].AutoFormat(Format: Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatList3, Number: true, Font: true, Alignment: true, Border: true, Pattern: true, Width: true);
                    }
                    else if (structExcel.TablaDinamica.Campos != null && structExcel.TablaDinamica.Campos.Count > 0)
                    {
                        workbook.PivotCaches().Add(Microsoft.Office.Interop.Excel.XlPivotTableSourceType.xlDatabase, SourceData: $"'{excelWorksheet.Name}'!R1C1:R{(dg.RowCount + 1).ToString().Trim()}C{dg.ColumnCount.ToString().Trim()}").
                            CreatePivotTable(TableDestination: "", TableName: $"Tabla dinámica {tabPage.Text}", DefaultVersion: Microsoft.Office.Interop.Excel.XlPivotTableVersionList.xlPivotTableVersion10);
                        Microsoft.Office.Interop.Excel.Worksheet activeSheet = workbook.ActiveSheet;
                        Microsoft.Office.Interop.Excel.PivotTable pivotTable1 = activeSheet.PivotTables($"Tabla dinámica {tabPage.Text}");

                        activeSheet.PivotTableWizard(activeSheet.Cells[3, 1]);
                        int num3 = 0;
                        foreach (string pivot in structExcel.TablaDinamica.Pivots)
                        {
                            pivotTable1.PivotFields(pivot).Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlRowField;
                            ++num3;
                            pivotTable1.PivotFields(pivot).Position = num3;
                        }
                        int num4 = 0;
                        foreach (string pivotsColumn in structExcel.TablaDinamica.PivotsColumns)
                        {
                            pivotTable1.PivotFields(pivotsColumn).Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlColumnField;
                            ++num4;
                            pivotTable1.PivotFields(pivotsColumn).Position = num4;
                        }
                        int num6 = 0;
                        foreach (string str in structExcel.TablaDinamica.PivotsPage)
                        {
                            pivotTable1.PivotFields(str).Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlPageField;
                            ++num6;
                            pivotTable1.PivotFields(str).Position = num6;
                        }
                        foreach (StructExcel.StructCampoTablaDinamica _item in structExcel.TablaDinamica.Campos)
                        {
                            Microsoft.Office.Interop.Excel.XlConsolidationFunction _proceso = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlCount;
                            switch (_item.Funcion)
                            {
                                case StructExcel.EnumFuncion.Suma:
                                    _proceso = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlSum;
                                    break;
                                case StructExcel.EnumFuncion.Promedio:
                                    _proceso = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlAverage;
                                    break;
                                case StructExcel.EnumFuncion.Cuenta:
                                    _proceso = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlCount;
                                    break;
                                case StructExcel.EnumFuncion.Maximo:
                                    _proceso = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlMax;
                                    break;
                                case StructExcel.EnumFuncion.Minimo:
                                    _proceso = Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlMin;
                                    break;
                            }
                            pivotTable1.AddDataField(pivotTable1.PivotFields(_item.Campo), $"{_item.Funcion} de {_item.Campo}", _proceso);
                            if (string.Equals(_item.Formato.Trim(), string.Empty))
                            {
                                pivotTable1.PivotFields($"{_item.Funcion} de {_item.Campo}").numberformat = _item.Formato;
                            }
                        }
                        if (structExcel.TablaDinamica.DataPivotFieldasColumn)
                            pivotTable1.DataPivotField.Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlColumnField;
                        workbook.ShowPivotTableFieldList = false;
                    }
                    if (structExcel.Graficar.TipoGrafico != 0)
                    {
                        Microsoft.Office.Interop.Excel.Chart chart1 = excelApp.Charts.Add();
                        chart1.ChartType = (Microsoft.Office.Interop.Excel.XlChartType)structExcel.Graficar.TipoGrafico;
                        chart1.SetSourceData(Source: excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[dg.RowCount + 1, dg.ColumnCount]],
                            PlotBy: structExcel.Graficar.Orientacion);
                        chart1.Location(Where: Microsoft.Office.Interop.Excel.XlChartLocation.xlLocationAsObject, Name: tabPage.Text);
                        try
                        {
                            chart1.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory).TickLabelSpacingIsAuto = true;
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            chart1.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory).TickLabelSpacing = 1;
                        }
                        catch (Exception)
                        {
                        }
                        excelWorksheet.Shapes.Item(1).Left = 0;
                        excelWorksheet.Shapes.Item(1).Top = 15 * data.Rows.Count + 3;
                        excelWorksheet.Shapes.Item(1).Height = excelWorksheet.Shapes.Item(1).Height * Convert.ToSingle(structExcel.Graficar.RelacionAlto);
                        excelWorksheet.Shapes.Item(1).Width = excelWorksheet.Shapes.Item(1).Width * Convert.ToSingle(structExcel.Graficar.RelacionAncho);
                    }
                    ++idtab;
                }
                workbook.Worksheets[1].select();
                excelApp.ScreenUpdating = true;
                if (_esTxt)
                {
                    string _salida = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Salida.txt");
                    try
                    {
                        File.Delete(_salida);
                    }
                    catch (Exception)
                    {
                    }
                    excelApp.Visible = false;
                    excelApp.ActiveWorkbook.SaveAs(Filename: _salida, FileFormat: Microsoft.Office.Interop.Excel.XlFileFormat.xlTextMSDOS, CreateBackup: false);
                    Auditoria.Registrar_Auditoria(this.Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Txt");
                    excelApp.ActiveWorkbook.Close(false);
                    excelApp.Quit();

                    Process.Start(_salida);
                    DespuesExportarTexto?.Invoke(this, null);
                    if (_mostrarmensajes)
                    {
                        MessageBox.Show($"Archivo generado correctamente en {_salida}", "Información");
                    }
                }
                else
                {
                    switch (_output)
                    {
                        case EnumSalida.Correo:
                            excelApp.Visible = true;
                            excelApp.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogSendMail].Show();
                            Auditoria.Registrar_Auditoria(this.Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel y enviar por mail");
                            break;
                        case EnumSalida.MailMerge:
                            string rutfte = Path.Combine(Path.GetTempPath(), "temp.xlsx");
                            try
                            {
                                if (File.Exists(rutfte))
                                    File.Delete(rutfte);
                            }
                            catch (Exception)
                            {
                                throw new Exception($"No se puede eliminar el archivo temporal {rutfte}, posiblemente esté en uso");
                            }
                            workbook.SaveAs(Filename: rutfte);
                            workbook.Close();
                            excelApp.Quit();

                            Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
                            Microsoft.Office.Interop.Word.Document WordDocument = WordApp.Documents.Open(_docmerge);
                            WordApp.Visible = true;
                            WordDocument.Activate();
                            WordDocument.MailMerge.OpenDataSource(Name: rutfte,
                                                                  Connection: $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={rutfte};",
                                                                  SQLStatement: "SELECT * FROM `{Me.TabControl1.TabPages(0).Text}$`");
                            WordDocument.MailMerge.ViewMailMergeFieldCodes = 0;
                            WordDocument.MailMerge.Destination = Microsoft.Office.Interop.Word.WdMailMergeDestination.wdSendToNewDocument;
                            WordDocument.MailMerge.SuppressBlankLines = true;

                            WordDocument.MailMerge.DataSource.FirstRecord = 1;
                            WordDocument.MailMerge.DataSource.LastRecord = -16;
                            WordDocument.MailMerge.Execute(Pause: false);
                            WordDocument.ActiveWindow.Close();
                            Auditoria.Registrar_Auditoria(this.Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel y combinó correspondencia");
                            break;
                        case EnumSalida.Archivo:
                            excelApp.Visible = false;
                            string path = "";
                            if (!empty)
                            {
                                if (string.IsNullOrEmpty(_archivosalida))
                                {
                                    path = $"{Path.GetTempFileName().ToLower().Replace(".tmp", "")}{".xlsx"}";
                                }
                                else
                                {
                                    path = Path.Combine(Path.GetTempPath(), _archivosalida + ".xlsx");
                                    bool ok = false;
                                    int num2 = 0;
                                    while (!ok)
                                    {
                                        if (File.Exists(path))
                                        {
                                            try
                                            {
                                                File.Delete(path);
                                                ok = true;
                                            }
                                            catch (Exception)
                                            {
                                                ok = false;
                                                ++num2;
                                                path = Path.Combine(Path.GetTempPath(), _archivosalida + num2.ToString().Trim() + ".xlsx");
                                            }
                                        }
                                        else
                                            ok = true;
                                    }
                                }
                                workbook.SaveAs(Filename: path);
                                Auditoria.Registrar_Auditoria(this.Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a archivo");
                            }
                            workbook.Close();
                            excelApp.Quit();
                            return path;
                        default:
                            excelApp.Visible = true;
                            Auditoria.Registrar_Auditoria(this.Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                if (_mostrarmensajes)
                {
                    MessageBox.Show($"Error al exporta a Microsoft Excel. {ex.Message}", "Error");
                }
            }
            return null;
        }
        #endregion
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Imprimir
        private void Imprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
        }

        private void ImprimirReporte()
        {
            TabPage _tab = TabControl1.TabPages[0];
            DataGridView _dg = (DataGridView)_tab.Controls[0];
            ImprimiReporte(_dg);
            Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion);
        }
        #endregion

        #region Ayuda
        private void Ayuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }
        #endregion


        #region Word
        private void Word_Click(object sender, EventArgs e)
        {
            EnviarExcel(EnumSalida.MailMerge, mDocSalida);
        }
        #endregion

        #region Correo
        private void Correo_Click(object sender, EventArgs e)
        {
            EnviarExcel(EnumSalida.Correo);
        }
        #endregion

        public event EventHandler Actualizar;
        private void Actualizar_Click(object sender, EventArgs e)
        {
            Actualizar?.Invoke(this, null);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ToolStripProgressBar1.Increment(1);
            if (ToolStripProgressBar1.Value >= ToolStripProgressBar1.Maximum)
            {
                ToolStripProgressBar1.Value = 0;
                Actualizar?.Invoke(this, null);
            }
        }

        public void ReiniciarProgressBar()
        {
            ToolStripProgressBar1.Value = 0;
        }

        #region Abrir
        public event EventHandler Abrir;
        public void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Abrir?.Invoke(this, null); 
        }

        public void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Enter:
                    e.Handled = true;
                    Abrir?.Invoke(this, null);
                    break;
            }
        }

        #endregion

        public event EventHandler EnviandoAutoMail;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (mProximoAutoMail is null)
            {
                return;
            }
            try
            {
                int minutosfaltan = Math.Abs((int)(mProximoAutoMail?.Subtract(DateTime.Now).Hours * 60 + mProximoAutoMail?.Subtract(DateTime.Now).Minutes));

                if (!mEnviandoMail && mProximoAutoMail?.Subtract(DateTime.Now).Days == 0 && minutosfaltan < 1 && minutosfaltan > -1)
                {
                    mEnviandoMail = true;
                    EnviarAutoMail();
                    btnenviomails.Text = "No se ha definido envío automático";
                    EnviandoAutoMail?.Invoke(this, null);
                }
            }
            catch (Exception)
            {
            }
        }

        protected void EnviarAutoMail(Microsoft.Office.Interop.Outlook.MailItem OriginalMessage = null)
        {
            Actualizar?.Invoke(this, null);

            if (string.IsNullOrWhiteSpace(AutoMailLista) && OriginalMessage is null)
            {
                return;
            }

            Timer2.Enabled = false;
            string sSource = EnviarExcel(EnumSalida.Archivo, "", AutoMailArchivo, false);
            if (string.IsNullOrWhiteSpace(sSource) || !File.Exists(sSource))
            {
                return;
            }

            Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem oMsg;
            if (OriginalMessage != null)
            {
                oMsg = OriginalMessage.ReplyAll();

            }
            else
            {
                oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                oMsg.Subject = AutoMailAsunto;
                oMsg.Body = Text;
                oMsg.To = AutoMailLista;
            }

            string sDisplayName = "Archivo.xlsx";
            int sBodyLen = oMsg.Body.Length;
            Microsoft.Office.Interop.Outlook.Attachments oAttachs = oMsg.Attachments;
            Microsoft.Office.Interop.Outlook.Attachment oAttach = oAttachs.Add(sSource, null, sBodyLen + 1, sDisplayName);
            oMsg.Send();

            oApp = null;
            oMsg = null;
            oAttach = null;
            oAttachs = null;
        }

    }
}
