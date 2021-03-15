using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoware.Consola.Base
{
    public interface ISupportsEdit
    {
        bool UndoVisible { get; }

        bool CanUndo { get; }

        void Undo();

        bool RedoVisible { get; }

        bool CanRedo { get; }

        void Redo();

        bool CanCut { get; }

        void Cut();

        bool CanCopy { get; }

        void Copy();

        bool CanPaste { get; }

        void Paste();

        bool CanSelectAll { get; }

        void SelectAll();

        bool CanDelete { get; }

        void Delete();

        bool CanShowProperties { get; }

        void ShowProperties();
    }
}
