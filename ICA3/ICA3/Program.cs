using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace ICA3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckForUpdatesAsync();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void CheckForUpdatesAsync()
        {
#if DEBUG
#else
            //UpdateInfo updateInfo = null;
            try
            {
                using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/vicosanz/ICA3Installer"))
                {
                    //updateInfo = mgr.Result.CheckForUpdate().ConfigureAwait(false);
                    //Mostrarmensaje($"Nueva versión detectada. Instalando en segundo plano versión {updateInfo.FutureReleaseEntry.Version}.");
                    mgr.Result.UpdateApp().ConfigureAwait(false);
                    //Mostrarmensaje($"Aplicación actualizada a la versión {updateInfo.FutureReleaseEntry.Version}. Por favor reinicie el programa para continuar.");
                }
            }
            catch (Exception)
            {
                //if (updateInfo is null)
                //{
                //}
                //else
                //{
                //    Mostrarmensaje($"ERROR actualizando a la versión {updateInfo.FutureReleaseEntry.Version}. {ex.Message}");
                //}
            }
#endif
        }
    }
}
