﻿using LakiaroCalculator.Src;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LakiaroCalculator.Customized_Tool
{
    struct Root
    {
        short type;
        char direction;
        public short Type { get => type; set => type = value; }
        public char Direction { get => direction; set => direction = value; }
    }
    public class CellButton : Button
    {
        #region Declare
        Cell cell;

        public Cell Cell { get => cell; set => cell = value; }
        #endregion

        #region Constructor
        public CellButton()
        {
            this.BackColor = Color.SkyBlue;
            this.Margin = new Padding(0);
            this.MinimumSize = new Size(64, 64);
            this.Text = "";
        }

        public CellButton(Cell _cell)
        {
            this.cell = _cell;
            switch (_cell.TileType)
            {
                case Src.TileType.Flower:
                    this.BackColor = Color.Red;
                    break;
                case Src.TileType.Recommend:
                    this.BackColor = Color.LightGreen;
                    break;
                default:
                    this.BackColor = Color.SkyBlue;
                    break;
            }
            this.Margin = new Padding(0);
            this.MinimumSize = new Size(64, 64);
            this.Text = "";
        }

        public CellButton(TileType tileType)
        {
            this.cell = new Cell(tileType);
            switch (cell.TileType)
            {
                case Src.TileType.Flower:
                    this.BackColor = Color.Red;
                    break;
                case Src.TileType.Recommend:
                    this.BackColor = Color.LightGreen;
                    break;
                default:
                    this.BackColor = Color.SkyBlue;
                    break;
            }
            this.Margin = new Padding(0);
            this.MinimumSize = new Size(64, 64);
            this.Text = "";
        }
        #endregion

        public void cellButtonUpdate()
        {
            switch (this.cell.TileType)
            {
                case TileType.Dirt:
                    this.BackColor = Color.Orange;
                    this.BackgroundImage = LakiaroCalculator.Properties.Resources.Dirt;
                    break;
                case TileType.Recommend:
                    this.BackColor = Color.LightGreen;
                    break;
                case TileType.Question:
                    this.Image = LakiaroCalculator.Properties.Resources.Question;
                    break;
                case TileType.Rock:
                    this.Image = LakiaroCalculator.Properties.Resources.Rock;
                    break;
                case TileType.Root:
                    this.BackColor = Color.Brown;
                    break;
                default:
                    this.Image = null;
                    this.BackColor = Color.LightSkyBlue;
                    break;
            }
            this.Update();
            /*this.cell.tileType
            this.Image = LakiaroCalculator.Properties.Resources._9.ToString();*/
        }

        #region MouseClick
        // After click call other panel 
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (this.cell.TileType != Src.TileType.Flower)
            {
                switch (mevent.Button)
                {
                    case MouseButtons.Left:
                        MouseLeftClick(mevent);
                        break;
                    case MouseButtons.Right:
                        MouseRightClick(mevent);
                        break;
                    case MouseButtons.Middle:
                        MouseMiddleClick();
                        break;
                }
                base.OnMouseDown(mevent);
            }
        }


        private void MouseLeftClick(MouseEventArgs mevent)
        {
            this.BackColor = Color.Red;
        }
        private void MouseRightClick(MouseEventArgs mevent)
        {
            Form1 fTmp = (Form1)FindForm();
            //Console.WriteLine(this.Parent);
            ((Form1)FindForm()).Solver.Log.Push(this);
            this.BackColor = Color.Black;
            if(fTmp.TmpControl != null)
            {
                fTmp.Controls.Remove(fTmp.TmpControl);
                fTmp.TmpControl.Dispose();
            }
            fTmp.TmpControl = new TileTypeControl();
            Point newLocation = new Point(this.Location.X, this.Location.Y + 64);
            if (this.Location.X >= 640)
            {
                newLocation.X = this.Location.X - 128;
                if (this.Location.Y >= 704)
                {
                    newLocation.Y = this.Location.Y - 64;
                }
            }
            else if (this.Location.Y >= 704)
            {
                newLocation.Y = this.Location.Y - 64;
            }
            fTmp.TmpControl.Location = newLocation;

            fTmp.Controls.Add(fTmp.TmpControl);
            fTmp.TmpControl.BringToFront();
            fTmp.TmpControl.Show();
        }
        private void MouseMiddleClick()
        {
            this.Image = LakiaroCalculator.Properties.Resources.Question;
            this.BackColor = Color.SkyBlue;
            this.cell.TileType = Src.TileType.Question;
            this.cell.RootType = Src.RootType.None;
        }

        /*
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

        */

        

        #endregion

        #region Recommend
        public void Recommend()
        {
            this.cell.TileType = Src.TileType.Recommend;
            this.BackColor = Color.LightGreen;
        }

        #endregion

        public void Clear()
        {
            this.Image = null;
            this.cell.Clear();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CellButton
            // 
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(64, 64);
            this.ResumeLayout(false);

        }
    }
}
