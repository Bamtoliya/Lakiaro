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


namespace LakiaroCalculator
{
    
    public partial class Form1 : Form
    {
        public bool mouseIsDown = false;

        //Stack for change Cell Button
        public Stack<CellButton> log = new Stack<CellButton>();

        public Form1()
        {
            InitializeComponent();

            //Hide Panels when Initialize
            RootsPanel.Hide();
            TilesPanel.Hide();
            DirectionPanel.Hide();
        }

        //Calculate Possible Roots Count
        private void CacluateRoots(object sender, EventArgs e)
        {
            int minRoots = ((int)RootsInput.Value)/9;
            int maxRoots = ((int)RootsInput.Value)/6;
            
            PossibleRoots.Text = String.Format("Possible Roots: {0:d} ~ {1:d}", minRoots, maxRoots);
        }

        private void Cell_Button_Clicked(object sender, MouseEventArgs e)
        {
            RootsPanel.Hide();
            TilesPanel.Hide();
            DirectionPanel.Hide();
            
            switch (e.Button){
                case MouseButtons.Left:
                    Cell_Button_LeftClick(sender, e);
                    break;
                case MouseButtons.Right:
                    Cell_Button_RightClick(sender, e);
                    break;
                case MouseButtons.Middle:
                    Cell_Button_MiddleClick(sender, e);
                    break;

            }
        }

        //Left Click Function of Cell Button 
        private void Cell_Button_RightClick(object sender, MouseEventArgs e)
        {
            if (RootsPanel.Visible == false)
            {
                CellButton tempButton = (CellButton)sender;
                
                Point Location = new Point((((Button)sender).Parent.Location.X + ((Button)sender).Width + 10), ((Button)sender).Height);

                RootsPanel.BringToFront();
                RootsPanel.Location = Location;
                RootsPanel.Show();

                log.Push(tempButton);
            }
            else
            {
                TilesPanel.Hide();
            }
        }


        //Right Click Function of Cell Button 
        private void Cell_Button_LeftClick(object sender, MouseEventArgs e)
        {   
            if (TilesPanel.Visible == false)
            {
                CellButton tempButton = (CellButton)sender;

                Point Location = new Point((((Button)sender).Parent.Location.X + ((Button)sender).Width + 10), ((Button)sender).Height);

                TilesPanel.BringToFront();
                TilesPanel.Location = Location;
                TilesPanel.Show();
                log.Push(tempButton);
            }
            else
            {
                TilesPanel.Hide();
            }
        }


        //Middle Click Function of Cell Button 
        private void Cell_Button_MiddleClick(object sender, MouseEventArgs e)
        {
            CellButton tempButton = (CellButton)sender;
            tempButton.Type = ((short)TileType.Question);
            log.Push(tempButton);
            log.First().Image = LakiaroCalculator.Properties.Resources.Question_Mark;
        }

        private void TileButtonClicked(object sender, EventArgs e) 
        {
            CellButton TileButton = (CellButton)sender;
            log.First().Image = TileButton.Image;
            log.First().Direction.Clear();
            log.Clear();
            TilesPanel.Hide();
        }

        private void RootButtonClicked(object sender, EventArgs e)
        {
            CellButton RootButton = (CellButton)sender;
            log.First().Image = RootButton.Image;
            log.First().RootType = RootButton.RootType;
            DirectionPanel.Location = RootsPanel.Location;
            RootsPanel.Hide();
            if (log.First().Direction.Count >= 2) log.First().Direction.Clear();
            DirectionPanel.Show();
            DirectionPanel.BringToFront();
        }


        private void DirectionButtonCliked(object sender, MouseEventArgs e)
        {
            CellButton tempButton = (CellButton)sender;
            if (log.First().Direction.Count < 2)
            {
                Root tempRoot = new Root
                {
                    Direction = (char)tempButton.Type
                };

                log.First().Direction.Add(log.First().Direction.Count, tempRoot);
            }

            if(log.First().Direction.Count >= 2)
            {
                string temp;
                //log.First().Image = LakiaroCalculator.Properties.Resources.
                //log.Clear();
                DirectionPanel.Hide();
            }
        }

        private void DirectionCheck(CellButton sender)
        {
            switch (log.First().RootType)
            {
                case RootType.Thick:
                    log.First().Image = 
                    break;
                case RootType.Narrow:

                    break;
                case RootType.Thin:

                    break;
                case RootType.End:

                    break;
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
    }
}
