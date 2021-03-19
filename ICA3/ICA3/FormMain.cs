using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICA3.Toolboxes;
using Infoware.Consola.Base;
using Infoware.Updates;
using Squirrel;
using WeifenLuo.WinFormsUI.Docking;

namespace ICA3
{
    public partial class FormMain : Infoware.Consola.Base.FormBaseMain
    {
        private ToolBoxSistemas mToolBoxSistemas;
        private ToolBoxModulos mToolBoxModulos;
        private ToolBoxFavoritos mToolBoxFavoritos;
        private ToolBoxReportes mToolBoxReportes;

        private DeserializeDockContent m_deserializeDockContent;
        private string dockPanelConfigFile;

        #region Themes
        private void EnableVSRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme)
        {
            vsToolStripExtender1.SetStyle(MenuStrip, version, theme);
            vsToolStripExtender1.SetStyle(BarraEstandar, version, theme);
        }

        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        #endregion

        #region Init
        public FormMain()
        {
            InitializeComponent();

            CheckForUpdatesAsync().ConfigureAwait(false);
            Assembly asm = Assembly.GetExecutingAssembly();
            string ApplicationTitle = ((AssemblyTitleAttribute)asm.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title;
            if (string.IsNullOrWhiteSpace(ApplicationTitle))
            {
                ApplicationTitle = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().FullName);
            }
            string mDirectorioConfig = ICA3Helper.GetDirectorioConfig();

            if (ICA3Helper.LeerClave() != Assembly.GetExecutingAssembly().Location)
            {
                ICA3Helper.GuardarClave(Assembly.GetExecutingAssembly().Location);
            }

            vsToolStripExtender1.DefaultRenderer = _toolStripProfessionalRenderer;

            ThemeBase themeBase = vS2015BlueTheme1;
            MainDockPanel.Theme = themeBase;
            EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, themeBase);

            mToolBoxSistemas = new ToolBoxSistemas()
            {
                DirectorioConfig = mDirectorioConfig
            };
            mToolBoxModulos = new ToolBoxModulos();
            mToolBoxFavoritos = new ToolBoxFavoritos();
            mToolBoxReportes = new ToolBoxReportes();

            mToolBoxSistemas.AbrirSitema += MToolBoxSistemas_AbrirSitema;
            mToolBoxSistemas.DesconectarSistema += MToolBoxModulos_DesconectarSistema;
            mToolBoxModulos.DesconectarSistema += MToolBoxModulos_DesconectarSistema;
            mToolBoxModulos.MensajeError += MToolBoxModulos_MensajeError;
            mToolBoxModulos.CambioFavoritos += MToolBoxModulos_CambioFavoritos;
            mToolBoxFavoritos.CambioFavoritos += MToolBoxFavoritos_CambioFavoritos;

            OnPantallaCompleta += new EventHandler<bool>(PantallaCompletaToogle);
            menuStrip1.Visible = false;
            ViewToolStripMenuItem.DropDownItems.Add(toolStripMenuItemSep);
            ViewToolStripMenuItem.DropDownItems.Add(barrasOtrasVentanasToolStripMenuItem);
            MenuStrip.Items.Insert(3, ventanaToolStripMenuItem);
            //ToolStripManager.Merge(menuStrip1, MenuStrip);
            toolStrip1.Visible = false;
            ToolStripManager.Merge(toolStrip1, BarraEstandar);

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);

            dockPanelConfigFile = Path.Combine(mDirectorioConfig, "DockPanel.config");

            try
            {
                if (File.Exists(dockPanelConfigFile))
                {
                    MainDockPanel.LoadFromXml(dockPanelConfigFile, m_deserializeDockContent);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                ResetLayout();
            }
        }

        private async Task CheckForUpdatesAsync()
        {
            using (var mgr = await GitHubUpdateManager.GetUpdateManager("vicosanz", "ICA3Installer"))
            {
                UpdateInfo updateInfo = null;
                try
                {
                    updateInfo = await mgr.CheckForUpdate();
                    if (updateInfo.ReleasesToApply.Any())
                    {
                        Mostrarmensaje("Nueva versión detectada. Instalando en segundo plano versión.");

                        await mgr.UpdateApp();
                        Mostrarmensaje("Aplicación actualizada. Por favor reinicie el programa para continuar.");
                    }
                }
                catch (Exception ex)
                {
                    if (updateInfo is null)
                    {
                        Mostrarmensaje($"No se puede revisar las actualizaciones. {ex.Message}");
                    }
                    else
                    {
                        Mostrarmensaje($"ERROR actualizando a la versión {updateInfo.FutureReleaseEntry}. {ex.Message}");
                    }
                }
            }
        }

        private void MToolBoxFavoritos_CambioFavoritos(object sender, EventArgs e)
        {
            mToolBoxFavoritos.AgregarSistema(mToolBoxFavoritos.SistemaActual, true);
        }

        private void MToolBoxModulos_CambioFavoritos(object sender, EventArgs e)
        {
            mToolBoxFavoritos.AgregarSistema(mToolBoxModulos.SistemaActual, true);
        }

        private void MToolBoxModulos_MensajeError(object sender, string e)
        {
            Mostrarmensaje(e);
        }

        private void Mostrarmensaje(string msgError)
        {
            lblok.Visible = false;
            lblerror.Visible = true;
            if (msgError.Length <= 150)
            {
                lblerror.Text = msgError;
            }
            else
            {
                lblerror.Text = msgError.Substring(0, 150);
            }
            tmr_error.Enabled = true;
        }

        private void MToolBoxModulos_DesconectarSistema(object sender, Sistema sistema)
        {
            mToolBoxSistemas.CerrarSistema(sistema);
            mToolBoxFavoritos.CerrarSistema(sistema);
            mToolBoxReportes.CerrarSistema(sistema);
            mToolBoxModulos.CerrarSistema(sistema);
        }

        private void MToolBoxSistemas_AbrirSitema(object sender, EventArgs e)
        {
            mToolBoxModulos.AgregarSistema(mToolBoxSistemas.SistemaSeleccionado);
            mToolBoxFavoritos.AgregarSistema(mToolBoxSistemas.SistemaSeleccionado, false);
            mToolBoxReportes.AgregarSistema(mToolBoxSistemas.SistemaSeleccionado);
        }

        private void ResetLayout()
        {
            mToolBoxReportes?.Show(MainDockPanel, DockState.DockLeft);
            mToolBoxModulos?.Show(mToolBoxReportes.Pane, DockAlignment.Top, 0.6);
            mToolBoxFavoritos?.Show(MainDockPanel, DockState.DockRightAutoHide);
            mToolBoxSistemas?.Show(mToolBoxModulos.Pane, DockAlignment.Top, 0.3);
        }
        #endregion

        #region Docking
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(ToolBoxSistemas).ToString())
                return mToolBoxSistemas;
            else if (persistString == typeof(ToolBoxModulos).ToString())
                return mToolBoxModulos;
            else if (persistString == typeof(ToolBoxFavoritos).ToString())
                return mToolBoxFavoritos;
            else if (persistString == typeof(ToolBoxReportes).ToString())
                return mToolBoxReportes;
            else
            {
                // DummyDoc overrides GetPersistString to add extra information into persistString.
                // Any DockContent may override this value to add any needed information for deserialization.

                string[] parsedStrings = persistString.Split(new char[] { ',' });
                if (parsedStrings.Length != 3)
                    return null;

                //if (parsedStrings[0] != typeof(DummyDoc).ToString())
                //    return null;

                //DummyDoc dummyDoc = new DummyDoc();
                //if (parsedStrings[1] != string.Empty)
                //    dummyDoc.FileName = parsedStrings[1];
                //if (parsedStrings[2] != string.Empty)
                //    dummyDoc.Text = parsedStrings[2];

                //return dummyDoc;
                return null;
            }
        }

        #endregion

        #region PantallaCompleta
        private void PantallaCompletaToogle(object sender, bool status)
        {
            if (status)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                SistemasVisible(false);
                ModulosVisible(false);
                FavoritosVisible(false);
                ReportesVisible(false);
            }
            else
            {
                SistemasVisible(true);
                ModulosVisible(true);
                FavoritosVisible(true);
                ReportesVisible(true);
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        #endregion

        #region ToolboxToogles
        private void ReportesVisible(bool status)
        {
            if (status)
            {
                mToolBoxReportes?.Show(MainDockPanel);
            }
            else
            {
                mToolBoxReportes?.Hide();
            }
        }

        private void FavoritosVisible(bool status)
        {
            if (status)
            {
                mToolBoxFavoritos?.Show(MainDockPanel);
            }
            else
            {
                mToolBoxFavoritos?.Hide();
            }
        }

        private void ModulosVisible(bool status)
        {
            if (status)
            {
                mToolBoxModulos?.Show(MainDockPanel);
            }
            else
            {
                mToolBoxModulos?.Hide();
            }
        }

        private void SistemasVisible(bool status)
        {
            if (status)
            {
                mToolBoxSistemas?.Show(MainDockPanel);
            }
            else
            {
                mToolBoxSistemas?.Hide();
            }
        }
        #endregion

        #region ToolboxMenuEvents
        private void MenuSistemas_Click(object sender, EventArgs e)
        {
            SistemasVisible(true);
        }

        private void MenuExplorador_Click(object sender, EventArgs e)
        {
            ModulosVisible(true);
        }

        private void MenuFavoritos_Click(object sender, EventArgs e)
        {
            FavoritosVisible(true);
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            ReportesVisible(true);
        }

        private void SistemasToolStrip_Click(object sender, EventArgs e)
        {
            SistemasVisible(true);
            mToolBoxSistemas.Activate();
        }

        private void ModulosToolStrip_Click(object sender, EventArgs e)
        {
            ModulosVisible(true);
        }

        private void FavoritosToolStrip_Click(object sender, EventArgs e)
        {
            FavoritosVisible(true);
        }

        private void ReportesToolStrip_Click(object sender, EventArgs e)
        {
            ReportesVisible(true);
        }
        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        #region Closing
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            FavoritosVisible(true);
            ReportesVisible(true);
            ModulosVisible(true);
            SistemasVisible(true);

            MainDockPanel.SaveAsXml(dockPanelConfigFile);
            CloseAllDocuments();
        }

        private void CloseAllDocuments()
        {
            if (MainDockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in MainDockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
            }
        }
        #endregion

        private void RestablecerEsquemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetLayout();
        }

        private void tmr_error_Tick(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            lblok.Visible = true;
            tmr_error.Enabled = false;
        }
    }
}
