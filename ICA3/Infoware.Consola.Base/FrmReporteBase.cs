using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Reglas.General;

namespace Infoware.Consola.Base
{
    public partial class FrmReporteBase : FrmFormaBase, IOpcion
    {
        public string Titulo
        {
            set
            {
                string _titulo = $"Reporte de {value}";
                Text = _titulo;
                ToolStriptitulo.Text = _titulo;
            }
        }

        public ToolStrip ToolStrip => ToolStrip1;

        public MenuStrip MenuStrip => MenuStrip1;

        public Control Control => pnlcuerpo;

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

        public Object ReporteDatos
        {
            get => crystalReportViewer1.ReportSource;
            set => crystalReportViewer1.ReportSource = value;
        }

        public FrmReporteBase()
        {
            InitializeComponent();
        }

        public FrmReporteBase(Sistema sistema, Restriccion restriccion)
        {
            InitializeComponent();

            InitSistema(sistema, restriccion);
        }

        public FrmReporteBase(Sistema sistema, int opcionActual)
        {
            InitializeComponent();

            InitSistema(sistema, opcionActual);
        }

        private void FrmReporteBase_AplicarRestricciones(object sender, EventArgs e)
        {
            btnimprimir.Enabled = Restriccion.Restri_Impresion;
            ImprimirToolStripMenuItem.Enabled = Restriccion.Restri_Impresion;

            ExportarToolStripMenuItem.Enabled = Restriccion.Restri_Impresion;
            btnexportar.Enabled = Restriccion.Restri_Impresion;
        }

        #region ExportarReporte
        private void ExportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarReporte();
        }

        private void ExportarReporte()
        {
            crystalReportViewer1.ExportReport();
            Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar reporte");
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            ExportarReporte();
        }
        #endregion

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Imprimir
        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
        }

        private void ImprimirReporte()
        {
            crystalReportViewer1.PrintReport();
            Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
        }
        #endregion

        #region Ayuda
        private void AyudaDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda();
        }

        private void ToolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }
        #endregion
    }
}
