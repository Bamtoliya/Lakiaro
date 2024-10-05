using LakiaroCalculator.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Customized_Tool
{
    public class TileButton : Button
    {
        Cell cell;

        public TileButton(TileType tileType)
        {
            Console.WriteLine(LakiaroCalculator.Properties.Resources.Dirt.Tag);
            this.cell = new Cell(tileType);
            this.Text = "";
        }

        public TileButton()
        {

        }

        public Cell Cell { get => cell; set => cell = value; }
    }
}
