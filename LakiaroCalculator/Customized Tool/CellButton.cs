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
        public event System.EventHandler CellChanged;
        protected virtual void OnCellChanged()
        {
            Console.WriteLine("CellChanged ");
            if (CellChanged != null) CellChanged(this, EventArgs.Empty);
        }

        public Cell Cell { get => cell; 
            set
            {
                cell = value;
                OnCellChanged();
            }
        }
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

        public void CellButtonUpdate()
        {
            switch (this.cell.TileType)
            {
                case TileType.Dirt:
                    this.BackColor = Color.Empty;
                    this.Image = LakiaroCalculator.Properties.Resources.Dirt;   
                    break;
                case TileType.Question:
                    this.BackColor = Color.Empty;
                    this.Image = LakiaroCalculator.Properties.Resources.Question;
                    break;
                case TileType.Rock:
                    this.BackColor = Color.Empty;
                    this.Image = LakiaroCalculator.Properties.Resources.Rock;
                    break;
                case TileType.Root:
                    this.BackColor = Color.Orange;
                    RootDirectionUpdate();
                    break;
                case TileType.Recommend:
                    this.Image = null;
                    this.BackColor = Color.LightGreen;
                    break;
                case TileType.None:
                    this.Image = null;
                    this.BackColor = Color.SkyBlue;
                    break;
                default:
                    this.Image = null;
                    this.BackColor = Color.Empty;
                    break;
            }
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
            Form1 fTmp = (Form1)FindForm();
            ((Form1)FindForm()).Solver.Log.Clear();
            ((Form1)FindForm()).Solver.Log.Push(this);
            this.BackColor = Color.Purple;
            if (fTmp.TmpControl != null)
            {
                fTmp.Controls.Remove(fTmp.TmpControl);
                fTmp.TmpControl.Hide();
            }
            fTmp.TmpControl = new RootTypeControl();
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
            CellButtonUpdate();
        }
        private void MouseRightClick(MouseEventArgs mevent)
        {
            Form1 fTmp = (Form1)FindForm();
            if(((Form1)FindForm()).Solver.Log.Count != 0)
            {
                ((Form1)FindForm()).Solver.Log.Pop().Cell.TileType = TileType.None;
            }
            ((Form1)FindForm()).Solver.Log.Clear();
            ((Form1)FindForm()).Solver.Log.Push(this);
            if(fTmp.TmpControl != null)
            {
                fTmp.Controls.Remove(fTmp.TmpControl);
                fTmp.TmpControl.Hide();
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
            CellButtonUpdate();
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

        #region RootDecide
        private void RootDirectionUpdate()
        {
            Console.Write(" RootDirectionUpdate Called ");
            string strTmp = this.cell.RootType.GetHashCode() + this.cell.direction;
            Console.Write(this.cell.RootType.GetHashCode() + this.cell.direction + strTmp.Length);
            switch (this.cell.RootType)
            {
                case RootType.Thick:
                case RootType.Thin:
                    if (strTmp.Length == 3)
                    {
                        Console.WriteLine(" Try to update image ");
                        if (LakiaroCalculator.Properties.Resources.ResourceManager.GetObject(strTmp) as Image != null)
                        {
                            this.Image = LakiaroCalculator.Properties.Resources.ResourceManager.GetObject(strTmp) as Image;
                        } 
                        else
                        {
                            string reversedDirection = new string(this.cell.direction.Reverse().ToArray());
                            strTmp = this.cell.RootType.GetHashCode() + reversedDirection;
                            this.Image = LakiaroCalculator.Properties.Resources.ResourceManager.GetObject(strTmp) as Image;
                        }
                    }                                        
                    else Console.WriteLine("invalidInput to cell.Direction");
                    break;
                case RootType.Narrow:
                    if (strTmp.Length == 3)
                        this.Image = LakiaroCalculator.Properties.Resources.ResourceManager.GetObject(strTmp) as Image;
                    else Console.WriteLine("invalidInput to cell.Direction");
                    break;
                case RootType.End:
                    if(strTmp.Length == 2)
                        this.Image = LakiaroCalculator.Properties.Resources.ResourceManager.GetObject(strTmp) as Image;
                    else Console.WriteLine("invalidInput to cell.Direction");
                    break;
                default:
                    Console.WriteLine("invalid Input to cell.Direction");
                    break;
            }
            if(this.cell.direction.Length > 0 && this.cell.RootType != RootType.None)
            {
                for(int i = 0; i < this.cell.direction.Length; ++i)
                {
                    PredictRootDirection(this.cell.direction[i]);
                }
            }
        }


        //Row = Height
        //Col = Width
        private void PredictRootDirection(char c)
        {
            Console.WriteLine(this.Parent);

            TableLayoutPanelCellPosition cPTmp = ((TableLayoutPanel)this.Parent).GetPositionFromControl(this);
            Console.Write("Current Cell:\t" + cPTmp.Row + " | " + cPTmp.Column);
            char cTmp = ' ';
            switch (c)
            {
                case 'N':
                    cTmp = 'S';
                    if(cPTmp.Row > 0 )
                    {
                        Console.Write(" Target Cell:\t" + (cPTmp.Row - 1) + " | " + cPTmp.Column);
                        CellButton targetCellButton = ((Form1)TopLevelControl).Solver.GridControl.Grid[cPTmp.Row - 1, cPTmp.Column];
                        if (targetCellButton.Cell.TileType != TileType.Flower)
                        {
                            targetCellButton.Cell.TileType = TileType.Root;
                            targetCellButton.Cell.direction += cTmp;
                            targetCellButton.CellButtonUpdate();
                        }
                    }
                    break;
                case 'S':
                    cTmp = 'N';
                    if (cPTmp.Row < ((TableLayoutPanel)this.Parent).Height)
                    {
                        Console.Write(" Target Cell:\t" + (cPTmp.Row + 1) + " | " + cPTmp.Column);
                        CellButton targetCellButton = ((Form1)TopLevelControl).Solver.GridControl.Grid[cPTmp.Row + 1, cPTmp.Column];
                        if (targetCellButton.Cell.TileType != TileType.Flower)
                        {
                            targetCellButton.Cell.TileType = TileType.Root;
                            targetCellButton.Cell.direction += cTmp;
                            targetCellButton.CellButtonUpdate();
                        }
                    }
                        
                    break;
                case 'W':
                    cTmp = 'E';
                    if (cPTmp.Column > 0)
                    {
                        Console.Write(" Target Cell:\t" + cPTmp.Row + " | " + (cPTmp.Column -1));
                        CellButton targetCellButton = ((Form1)TopLevelControl).Solver.GridControl.Grid[cPTmp.Row, cPTmp.Column - 1];
                        if (targetCellButton.Cell.TileType != TileType.Flower)
                        {
                            targetCellButton.Cell.TileType = TileType.Root;
                            targetCellButton.Cell.direction += cTmp;
                            targetCellButton.CellButtonUpdate();
                        }
                    }
                        
                    break;
                case 'E':
                    cTmp = 'W';
                    if (cPTmp.Column < ((TableLayoutPanel)this.Parent).Width)
                    {
                        Console.Write(" Target Cell:\t" + cPTmp.Row + " | " + (cPTmp.Column + 1));
                        CellButton targetCellButton = ((Form1)TopLevelControl).Solver.GridControl.Grid[cPTmp.Row, cPTmp.Column + 1];
                        if (targetCellButton.Cell.TileType != TileType.Flower)
                        {
                            targetCellButton.Cell.TileType = TileType.Root;
                            targetCellButton.Cell.direction += cTmp;
                            targetCellButton.CellButtonUpdate();
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Error Catch");
                    break;
            }
        }

        //Get the neihbor tile's root type if it 
        private void PredictRootType(CellButton target)
        {
            //Get directions of cell and 
            //get Root type of each directions
            //if they are different = narrow
            //if thery are different and one is thin and end then thin
            //if they are same Thick or Thin assign the same
            //if 
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
