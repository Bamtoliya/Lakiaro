using LakiaroCalculator.Src;
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
    public partial class TileTypeControl : UserControl
    {
        public TileTypeControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(this.Visible == true) this.Hide();
            ((Form1)FindForm()).Solver.Log.Push(new CellButton(((TileButton)sender).Cell));
            CellButton cSrc = ((Form1)FindForm()).Solver.Log.Pop();
            CellButton cDst = ((Form1)FindForm()).Solver.Log.Pop();
            cDst.Cell = cSrc.Cell;
            cDst.CellButtonUpdate();
            this.Hide();
        }
    }
}
