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
            //Console.WriteLine(sender);
            //Console.WriteLine(Parent);
            //((GridControl)Parent).
            ((TileButton)sender).OnClick();
            this.Hide();
        }
    }
}
