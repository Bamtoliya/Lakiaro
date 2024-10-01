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
            this.cell = new Cell(tileType);
        }

        public TileButton()
        {

        }

        public Cell Cell { get => cell; set => cell = value; }

        public Cell OnClick()
        {
            Console.WriteLine(Parent);
            Console.WriteLine(Parent.Parent);
            Console.WriteLine(Parent.Parent.Parent);

            //(GridControl)
            //Console.WriteLine(this.cell.TileType);
            return this.cell;
        }
    }
}
