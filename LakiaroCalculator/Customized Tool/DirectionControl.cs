using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Customized_Tool
{
    public partial class DirectionControl : UserControl
    {
        public DirectionControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CellButton cTmp = ((Form1)FindForm()).Solver.Log.First<CellButton>();
            
            cTmp.Cell.direction += ((Button)sender).Text[0];
            if (cTmp.Cell.RootType == Src.RootType.End || cTmp.Cell.direction.Length == 2) this.Hide();
        }
    }
}
