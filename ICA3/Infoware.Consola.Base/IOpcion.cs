using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoware.Consola.Base
{
    public interface IOpcion
    {
        ToolStrip ToolStrip { get; }

        MenuStrip MenuStrip { get; }

        Control Control { get; }
    }
}
