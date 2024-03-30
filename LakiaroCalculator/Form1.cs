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



namespace LakiaroCalculator
{
    
    public partial class Form1 : Form
    {
        public bool mouseIsDown = false;
        Button[] possibleStart = new Button[16];

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Change()
        {

        }

        private void Cell_Update(object sender, EventArgs e)
        {

        }

        private void Cell_button_Right_Clicked(object sender, EventArgs e)
        {

        }

        private void Cell_button_Wheel_Clicked(object sender, EventArgs e)
        {

        }

        private void Cell_Button_Clicked(object sender, EventArgs e)
        {
            //When Cell button clicked, call list of the possible tiles
            
            //Toggle On and Off the Button

            if (TilesPanel.Visible == false)
            {
                TilesPanel.Show();
                TilesPanel.Location = ((Button)sender).Location;
            }
            else
            {
                TilesPanel.Hide();
            }
        }

        
        // Detail fo Later
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
