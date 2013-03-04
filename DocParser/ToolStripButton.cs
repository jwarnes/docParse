using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DocParser
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip |
                                           ToolStripItemDesignerAvailability.ContextMenuStrip |
                                           ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripButton : ToolStripControlHost
    {
        private Button button;

        public ToolStripButton()
            : base(new Button())
        {
            this.button = this.Control as Button;
        }

    }
}
