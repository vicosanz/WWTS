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
using WeifenLuo.WinFormsUI.Docking;

namespace Infoware.Consola.Base
{
    public partial class FrmFormaBase : DockContent 
    {
        private Sistema mSistema;
        public Sistema Sistema
        {
            get => mSistema;
            set
            {
                mSistema = value;
                if (mSistema != null)
                {
                    Inicializar?.Invoke(this, null);
                }
            }
        }

        public event EventHandler Inicializar;
        public event EventHandler AplicarRestricciones;

        private Restriccion mRestriccion = null;
        public Restriccion Restriccion {
            get
            {
                return mRestriccion;
            }
            set
            {
                mRestriccion = value;
                if (!mRestriccion.Restri_Ingreso)
                {
                    Close();
                }
                AplicarRestricciones?.Invoke(this, null);
            }
        }

        public FrmFormaBase()
        {
            InitializeComponent();

            ParentChanged += FrmFormaBase_ParentChanged;
        }

        public FrmFormaBase(Sistema sistema)
        {
            InitializeComponent();
            ParentChanged += FrmFormaBase_ParentChanged;
            Sistema = sistema;
        }

        private void FrmFormaBase_ParentChanged(object sender, EventArgs e)
        {
            try
            {
                if (MainMenuStrip is null)
                {
                    return;
                }
                MainMenuStrip.Visible = !(Parent is MdiClient);
            }
            catch (Exception)
            {
            }
        }

        public void InitSistema(Sistema sistema, Restriccion restriccion)
        {
            Sistema = sistema;
            Restriccion = restriccion;
        }

        public void InitSistema(Sistema sistema, int opcionActual)
        {
            Sistema = sistema;
            Restriccion = sistema.Restricciones.Buscar(opcionActual);
        }

        protected bool ImprimiReporte(DataGridView _dg)
        {
            Reportes.ReportDocument doc = new Reportes.ReportDocument
            {
                Titulo = Text
            };

            if (_dg.ColumnCount > 5)
                doc.DefaultPageSettings.Landscape = true;

            doc.DataGridView = _dg;
            PrintPreviewDialog previo = new PrintPreviewDialog
            {
                Document = doc,
            };
            previo.Document.DocumentName = Text;
            previo.Text = Text;
            previo.WindowState = FormWindowState.Maximized;
            previo.ShowDialog();
            return true;
        }

        protected void Ayuda()
        {
            if (Restriccion is null || string.IsNullOrWhiteSpace(Restriccion.PardetOpcion.Pardet_Leyenda))
            {
                FrmAyuda f = new FrmAyuda()
                {
                    Titulo = Text,
                    Descripcion = Restriccion.PardetOpcion.Pardet_Leyenda
                };
                f.ShowDialog();
            }
        }
    }
}
