using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace LakiaroCalculator.Customized_Tool
{
    public partial class RootTypeControl : UserControl
    {
        public RootTypeControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RootType Button Clicked");
            if (this.Visible == true) this.Hide();
            ((Form1)FindForm()).Solver.Log.Push(new CellButton(((RootButton)sender).Cell));
            CellButton cSrc = ((Form1)FindForm()).Solver.Log.Pop();
            CellButton cDst = ((Form1)FindForm()).Solver.Log.Pop();
            cDst.Cell = cSrc.Cell;
            ((Form1)FindForm()).Solver.Log.Push(cDst);
            DirectionControlRender(cDst);
            cDst.CellButtonUpdate();
        }

        private void DirectionControlRender(CellButton cDst)
        {
            Point newLocation = new Point(cDst.Location.X, cDst.Location.Y + 64);
            if (cDst.Location.X >= 640)
            {
                newLocation.X = cDst.Location.X - 128;
                if (cDst.Location.Y >= 704)
                {
                    newLocation.Y = cDst.Location.Y - 192;
                }
            }
            else if (cDst.Location.Y >= 704)
            {
                newLocation.Y = cDst.Location.Y - 192;
            }
            ((Form1)FindForm()).TmpControl = new DirectionControl();
            ((Form1)FindForm()).TmpControl.Location = newLocation;
            ((Form1)FindForm()).Controls.Add(((Form1)FindForm()).TmpControl);
            ((Form1)FindForm()).TmpControl.BringToFront();
        }
    }
}

