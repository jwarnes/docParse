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
    public class ToolStripText : ToolStripControlHost
    {
        private TextBox textBox;

        public ToolStripText()
            : base(new TextBox())
        {
            this.textBox = this.Control as TextBox;
        }

    }
}
