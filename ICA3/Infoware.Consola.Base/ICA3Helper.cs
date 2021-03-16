using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoware.Consola.Base
{
    public static class ICA3Helper
    {
        public static string GetDirectorioRaiz()
        {
            string result = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ICA3");

            Directory.CreateDirectory(result);
            return result;
        }

        public static string GetDirectorioConfig()
        {
            string result = Path.Combine(ICA3Helper.GetDirectorioRaiz(), "Configuracion");

            Directory.CreateDirectory(result);
            return result;
        }

        public static string GetConfigFile()
        {
            return Path.Combine(ICA3Helper.GetDirectorioConfig(), "Link.config");
        }

        public static void GuardarClave(string valor)
        {
            File.WriteAllText(ICA3Helper.GetConfigFile(), valor);
        }

        public static string LeerClave()
        {
            string result = "";
            try
            {
                result = File.ReadAllText(ICA3Helper.GetConfigFile());
            }
            catch (Exception)
            {
            }
            return result;
        }
    }
}
