using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Reportes;
using Microsoft.Office.Interop.Excel;

namespace Infoware.Consola.Base
{
    public class DataGridViewAutoDiscover : DataGridView
    {
        private ContextMenuStrip ContextMenuStrip1;

        public bool AgruparRepetidos { get; set; }

        public void AutoDiscover()
        {
            if (DesignMode)
            {
                return;
            }
            Invalidate();
            ContextMenuStrip = ContextMenuStrip1;
            ContextMenuStrip1.Items.Clear();
            try
            {
                IList data = (IList)DataSource;
                Type SourceType = data[0].GetType();
                foreach (PropertyInfo mInfo in SourceType.GetProperties())
                {
                    CampoReporteAtributo campoReporteAtributo = null;
                    foreach (Attribute attr in Attribute.GetCustomAttributes(mInfo))
                    {
                        if (attr is CampoReporteAtributo)
                        {
                            campoReporteAtributo = (CampoReporteAtributo)attr;
                            campoReporteAtributo.Campo = mInfo.Name;
                        }
                    }
                    if (campoReporteAtributo != null && !campoReporteAtributo.Ignorar &&
                        mInfo.PropertyType.BaseType == typeof(object) | mInfo.PropertyType.BaseType == typeof(ValueType))
                    {
                        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
                        {
                            Text = campoReporteAtributo.Etiqueta,
                            Tag = (object)campoReporteAtributo,
                            CheckOnClick = true
                        };
                        bool flag = false;
                        int columnCount = this.ColumnCount;
                        int num = 1;
                        while (num <= columnCount)
                        {
                            if (Columns[num - 1].DataPropertyName.ToUpper().Trim() == campoReporteAtributo.Campo.ToUpper().Trim())
                            {
                                flag = true;
                                break;
                            }
                            ++num;
                        }
                        toolStripMenuItem.Checked = flag | campoReporteAtributo.Predeterminado;
                        toolStripMenuItem.Enabled = !campoReporteAtributo.Predeterminado;
                        this.ContextMenuStrip1.Items.Add((ToolStripItem)toolStripMenuItem);
                        toolStripMenuItem.Click += new EventHandler(this.SeleccionarCampos);
                    }
                }
                if (Columns.Count != 0 && Columns[0].Name != "none")
                    return;
                this.SeleccionarCampos(this, null);
            }
            catch (Exception)
            {
                this.Columns.Clear();
                this.Columns.Add("none", "No existen registros a presentar");
            }
        }

        public event EventHandler DespuesSeleccionarCampos;

        public void SeleccionarCampos(object sender, EventArgs e)
        {
            this.Columns.Clear();

            foreach (ToolStripMenuItem toolStripMenuItem in this.ContextMenuStrip1.Items)
            {
                CampoReporteAtributo tag = (CampoReporteAtributo)toolStripMenuItem.Tag;
                if (toolStripMenuItem.Checked || tag.Predeterminado)
                {
                    DataGridViewColumn dataGridViewColumn = null;
                    switch (tag.TipoDato)
                    {
                        case CampoReporteAtributo.EnumTipoDato.Texto:
                            dataGridViewColumn = new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = tag.Campo,
                                HeaderText = tag.Etiqueta,
                                Width = Int32.Parse(tag.Tamano)
                            };
                            break;
                        case CampoReporteAtributo.EnumTipoDato.Numero:
                            DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle
                            {
                                Format = "N0"
                            };
                            dataGridViewColumn = new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = tag.Campo,
                                DefaultCellStyle = gridViewCellStyle1,
                                HeaderText = tag.Etiqueta,
                                Width = Int32.Parse(tag.Tamano)
                            };
                            break;
                        case CampoReporteAtributo.EnumTipoDato.Decimales:
                            DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle
                            {
                                Format = "N2"
                            };
                            dataGridViewColumn = new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = tag.Campo,
                                DefaultCellStyle = gridViewCellStyle2,
                                HeaderText = tag.Etiqueta,
                                Width = Int32.Parse(tag.Tamano)
                            };
                            break;
                        case CampoReporteAtributo.EnumTipoDato.Fecha:
                            dataGridViewColumn = new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = tag.Campo,
                                HeaderText = tag.Etiqueta,
                                Width = Int32.Parse(tag.Tamano)
                            };
                            break;
                        case CampoReporteAtributo.EnumTipoDato.Logico:
                            dataGridViewColumn = new DataGridViewCheckBoxColumn
                            {
                                DataPropertyName = tag.Campo,
                                HeaderText = tag.Etiqueta,
                                Width = Int32.Parse(tag.Tamano)
                            };
                            break;
                        case CampoReporteAtributo.EnumTipoDato.Boton:
                            dataGridViewColumn = new DataGridViewButtonColumn
                            {
                                DataPropertyName = tag.Campo,
                                HeaderText = tag.Etiqueta,
                                Width = Int32.Parse(tag.Tamano)
                            };
                            break;
                    }
                    this.Columns.Add(dataGridViewColumn);
                }
            }

            DespuesSeleccionarCampos?.Invoke(this, null);
        }

        private void DataGridViewAutoDiscover_DataSourceChanged(object sender, EventArgs e) => this.AutoDiscover();

        public void Merge()
        {
            if (!this.AgruparRepetidos)
                return;
            this.RowHeadersVisible = false;
            if (this.DisplayedRowCount(true) == 0)
                return;
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Label)
                    control.Dispose();
            }
            string _texto = ">>>>";
            int index = -1;
            int left = 0;
            int top = 0;
            int width = 0;
            int height1 = 0;

            foreach (DataGridViewRow row in Rows)
            {
                ++index;
                if (row.Displayed)
                {
                    object objectValue = GetField(((IList)DataSource)[index], Columns[0].DataPropertyName);
                    System.Drawing.Rectangle displayRectangle;
                    if (!string.Equals(objectValue, _texto))
                    {
                        if (!string.Equals(_texto, ">>>>"))
                        {
                            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label
                            {
                                Text = _texto,
                                Font = new System.Drawing.Font(this.DefaultCellStyle.Font, this.DefaultCellStyle.Font.Style)
                            };
                            label1.SetBounds(left, top, width, height1);
                            this.Controls.Add(label1);
                        }
                        displayRectangle = this.GetRowDisplayRectangle(row.Index, false);
                        left = displayRectangle.Left;
                        displayRectangle = this.GetRowDisplayRectangle(row.Index, false);
                        top = displayRectangle.Top;
                        displayRectangle = this.GetColumnDisplayRectangle(0, false);
                        width = displayRectangle.Right - left - 1;
                        displayRectangle = this.GetRowDisplayRectangle(row.Index, false);
                        height1 = displayRectangle.Size.Height - 1;
                        _texto = (string)objectValue;
                    }
                    else
                    {
                        height1 += this.GetRowDisplayRectangle(row.Index, false).Size.Height;
                    }
                }
            }
            if (!string.Equals(_texto, ">>>>>"))
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label
                {
                    Text = _texto,
                    Font = new System.Drawing.Font(this.DefaultCellStyle.Font, this.DefaultCellStyle.Font.Style),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                label1.SetBounds(left, top, width, height1);
                Controls.Add(label1);
            }
        }

        public object GetField(object obj, string FieldName)
        {
            try
            {
                Type type = obj.GetType();
                PropertyInfo property = type.GetProperty(FieldName);
                if (property is null || !property.CanRead)
                {
                    FieldInfo field = type.GetField(FieldName);
                    if (field is null)
                    {
                        return string.Format("No such value {0}", FieldName);
                    }
                    else
                    {
                        return field.GetValue(obj);
                    }
                }
                else
                {
                    return property.GetValue(obj, null);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void DataGridView1_Paint(object sender, PaintEventArgs e) => this.Merge();

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) => this.Merge();

        public DataGridViewAutoDiscover()
        {
            this.DataSourceChanged += new EventHandler(this.DataGridViewAutoDiscover_DataSourceChanged);
            this.Paint += new PaintEventHandler(this.DataGridView1_Paint);
            this.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
            this.AgruparRepetidos = false;
            this.ContextMenuStrip1 = new ContextMenuStrip();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void Excel(
          EnumSalida _output,
          string _docmerge = "",
          ProgressBar _progressbar = null)
        {
            try
            {
                IList data = (IList)DataSource;
                if (data is null || data.Count == 0)
                {
                    throw new Exception("No existen registros a exportar");
                }

                Type dets = data[0].GetType();

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application
                {
                    Visible = false,
                    ScreenUpdating = false
                };
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet1 = (Worksheet)workbook.Worksheets.Item[1];
                int columnCount1 = ColumnCount;
                int num1 = 1;
                while (num1 <= columnCount1)
                {
                    worksheet1.Cells[1, num1].Value = Columns[num1 - 1].HeaderText;
                    worksheet1.Columns[num1].columnwidth = Columns[num1 - 1].Width / 6.8 > 255 ? 255 : Columns[num1 - 1].Width / 6.8;

                    PropertyInfo property = dets.GetProperty(this.Columns[num1 - 1].DataPropertyName);
                    if (property != null)
                    {
                        if (_output != EnumSalida.MailMerge && property.PropertyType == typeof(decimal) | property.PropertyType == typeof(double))
                            worksheet1.Columns[num1].numberformat = "0.00";
                        else if (_output != EnumSalida.MailMerge && property.PropertyType == typeof(int) | property.PropertyType == typeof(byte))
                            worksheet1.Columns[num1].numberformat = "0";
                        else
                            worksheet1.Columns[num1].numberformat = "@";
                    }
                    ++num1;
                }
                if (_progressbar != null)
                {
                    _progressbar.Visible = true;
                    _progressbar.Maximum = data.Count;
                    _progressbar.Minimum = 0;
                    _progressbar.Value = 0;
                }
                int num2 = 0;
                int count = data.Count;
                int _fila = 1;
                while (_fila <= count)
                {
                    ++num2;
                    if (_progressbar != null)
                        _progressbar.Value = num2;
                    int columnCount2 = this.ColumnCount;
                    int icol = 1;
                    while (icol <= columnCount2)
                    {
                        object objectValue = GetField(data[_fila - 1], Columns[icol - 1].DataPropertyName);
                        if (objectValue is bool boolvalue)
                        {
                            worksheet1.Cells[_fila + 1, icol].Value = boolvalue ? "Sí" : "No";
                        }
                        else
                        {
                            PropertyInfo property = dets.GetProperty(Columns[icol - 1].DataPropertyName);
                            switch (_output)
                            {
                                case EnumSalida.MailMerge when property.PropertyType == typeof(decimal) | property.PropertyType == typeof(double):
                                    worksheet1.Cells[_fila + 1, icol].value = double.Parse((string)objectValue).ToString("0.00");
                                    break;
                                case EnumSalida.MailMerge when property.PropertyType == typeof(int) | property.PropertyType == typeof(byte):
                                    worksheet1.Cells[_fila + 1, icol].value = double.Parse((string)objectValue).ToString("0.00");
                                    break;
                                default:
                                    worksheet1.Cells[_fila + 1, icol].value = objectValue;
                                    break;
                            }

                        }
                        ++icol;
                    }
                    ++_fila;
                }
                if (_progressbar != null)
                    _progressbar.Visible = false;
                excelApp.Visible = true;
                excelApp.ScreenUpdating = true;
                switch (_output)
                {
                    case EnumSalida.Correo:
                        excelApp.Dialogs[XlBuiltInDialog.xlDialogSendMail].Show();
                        break;
                    case EnumSalida.MailMerge:
                        string rutfte = Path.Combine(Path.GetTempPath(), "temp.xlsx");
                        try
                        {
                            File.Delete(rutfte);
                        }
                        catch (Exception)
                        {
                            throw new Exception($"No se puede eliminar el archivo temporal {rutfte}, posiblemente esté en uso");
                        }
                        workbook.SaveAs(rutfte);
                        workbook.Close();
                        excelApp.Quit();
                        Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
                        Microsoft.Office.Interop.Word.Document WordDocument = WordApp.Documents.Open(_docmerge);
                        WordApp.Visible = true;
                        WordDocument.Activate();
                        WordDocument.MailMerge.OpenDataSource(Name: rutfte,
                                                              Connection: $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={rutfte};",
                                                              SQLStatement: "SELECT * FROM `Hoja1$`");
                        WordDocument.MailMerge.ViewMailMergeFieldCodes = 0;
                        WordDocument.MailMerge.Destination = Microsoft.Office.Interop.Word.WdMailMergeDestination.wdSendToNewDocument;
                        WordDocument.MailMerge.SuppressBlankLines = true;
                        WordDocument.MailMerge.DataSource.FirstRecord = 1;
                        WordDocument.MailMerge.DataSource.LastRecord = -16;
                        WordDocument.MailMerge.Execute(Pause: false);
                        WordDocument.ActiveWindow.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede exporta a Microsoft Excel. {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
