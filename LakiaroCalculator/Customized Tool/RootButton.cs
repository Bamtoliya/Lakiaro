using LakiaroCalculator.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Customized_Tool
{
    public class RootButton : Button
    {
        Cell cell;

        public RootButton(RootType rootType)
        {
            Console.WriteLine(LakiaroCalculator.Properties.Resources.Dirt.Tag);
            this.cell = new Cell(rootType);
            this.Text = "";
        }

        public RootButton()
        {

        }

        public Cell Cell { get => cell; set => cell = value; }
    }
}
