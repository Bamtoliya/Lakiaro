using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator
{
    public class CellButton : Button
    {
        public CellButton()
        {
            this.MinimumSize = new Size(64, 64);
        }
    }
}
