using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LakiaroCalculator.Customized_Tool;
using LakiaroCalculator.Src;


namespace LakiaroCalculator
{
    
    public partial class Form1 : Form
    {
        Solver solver;
        bool level;

        public Form1()
        {
            InitializeComponent();
            level = toggleButton1.Checked;
            solver = new Solver(level);
            if (level) gridControl1.Size = gridControl1.MaximumSize;
            else gridControl1.Size = gridControl1.MinimumSize;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            solver.ResetGrid();
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            level = toggleButton1.Checked;
            solver = new Solver(level);
        }

        // Detail for Later
        /**
        private void Cell_Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            mouseIsDown = true;
        }

        private void Cell_Button_MouseMove(object sender, MouseEventArgs e)
        {

            
            if (mouseIsDown)
            {
                Button tempButton = (Button)sender;
                Point point = this.PointToClient(Cursor.Position);
                DrawPoint((point.X), (point.Y), Color.Red);
            }
        }

        private void Cell_Button_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        public void DrawPoint(int x, int y, Color color)
        {
            Graphics g = this.button9.CreateGraphics();
            Pen pen = new Pen(color);
            g.DrawRectangle(pen, x, y, 3, 3);
        }**/
    }
}
