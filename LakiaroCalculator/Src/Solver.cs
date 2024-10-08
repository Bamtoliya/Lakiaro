using LakiaroCalculator.Customized_Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Src
{
    
    public class Solver
    {
        #region Variables
        Form1 form;
        GridControl gridControl;
        List<TableLayoutPanelCellPosition> recIndexs = new List<TableLayoutPanelCellPosition>();
        List<int> possibleRoots = new List<int>();
        bool level;
        const int flowerSize = 4;
        Stack<CellButton> log;

        int nDirts = 0, cDirts = 0;
        int nRoots = 0, cRoots = 0;
        int nRocks = 0, cRocks = 0;

        public int NDirts { get => nDirts; set => nDirts = value; }
        public int CDirts { get => cDirts; set => cDirts = value; }
        public int NRoots { get => nRoots; set => nRoots = value; }
        public int CRoots { get => cRoots; set => cRoots = value; }
        public int NRocks { get => nRocks; set => nRocks = value; }
        public int CRocks { get => cRocks; set => cRocks = value; }
        public bool Level { get => level; set => level = value; }
        public Stack<CellButton> Log { get => log; set => log = value; }
        public GridControl GridControl { get => gridControl; set => gridControl = value; }
        public Form1 Form { get => form; set => form = value; }
        #endregion

        #region Constructor
        public Solver()
        {
            log = new Stack<CellButton>();
            level = false;
        }

        public Solver(bool level)
        {
            this.level = level;
            log = new Stack<CellButton>();
        }

        #endregion

        public void Solve(bool level)
        {
            Console.WriteLine("Solver.Solve(bool) Called");
            if (level)
            {
                FirstRec();
                GridUpdate();
            }
            else
            {
                FirstRec();
                GridUpdate();
            }
        }
        //Calculate Possible Roots Count
        private void CacluateRoots(object sender, EventArgs e)
        {
            
        }
        public List<int> CalculateRoots()
        {
            possibleRoots.Clear();
            int minRoots = nRoots / 9;
            int maxRoots = nRoots / 6;

            possibleRoots.Add(minRoots);
            possibleRoots.Add(maxRoots);

            return possibleRoots;
        }

        //First Solve Logic test
        public void FirstRec()
        {
            if (level)
            {

            }
            else
            {
                //Need to replace with loop condition
                recIndexs.Add(new TableLayoutPanelCellPosition(3, 3));
                recIndexs.Add(new TableLayoutPanelCellPosition(8, 3));
                recIndexs.Add(new TableLayoutPanelCellPosition(8, 8));
                recIndexs.Add(new TableLayoutPanelCellPosition(3, 8));

                recIndexs.Add(new TableLayoutPanelCellPosition(1, 4));
                recIndexs.Add(new TableLayoutPanelCellPosition(1, 7));

                recIndexs.Add(new TableLayoutPanelCellPosition(4, 1));
                recIndexs.Add(new TableLayoutPanelCellPosition(7, 1));

                recIndexs.Add(new TableLayoutPanelCellPosition(10, 4));
                recIndexs.Add(new TableLayoutPanelCellPosition(10, 7));

                recIndexs.Add(new TableLayoutPanelCellPosition(4, 10));
                recIndexs.Add(new TableLayoutPanelCellPosition(7, 10));
            }
        }

        public void GridUpdate()
        {
            foreach(TableLayoutPanelCellPosition index in recIndexs)
            {
                if (GridControl.Grid[index.Column, index.Row].Cell.TileType != TileType.Flower)
                {
                    GridControl.Grid[index.Column, index.Row].Cell.TileType = TileType.Recommend;
                    GridControl.Grid[index.Column, index.Row].CellButtonUpdate();
                }
            }
        }

        public void ResetGrid()
        {
            foreach(CellButton cellButton in GridControl.Grid)
            {
                if(cellButton.Cell.TileType != TileType.Flower)
                {
                    cellButton.BackColor = System.Drawing.Color.SkyBlue;
                    cellButton.Cell.TileType = TileType.None;
                    cellButton.Cell.RootType = RootType.None;
                    cellButton.Image = null;
                    cellButton.Text = "";
                }
            }
            Console.WriteLine("ResetGrid Called");
        }
    }
}
