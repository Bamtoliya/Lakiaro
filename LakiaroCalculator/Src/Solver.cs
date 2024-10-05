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
        GridControl grid;
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
        #endregion

        #region Constructor
        public Solver()
        {
            grid = new GridControl();
            log = new Stack<CellButton>();
        }

        public Solver(bool level)
        {
            grid = new GridControl(level);
            log = new Stack<CellButton>();
        }

        #endregion

        public void Solve(bool level)
        {
            if(level)
            {
                
            }
            else
            {
                FirstRec();
                gridUpdate();
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

                /*recIndexs.Add(width * (((height - flowerSize) / 2) - 1) + (((width - flowerSize) / 2) - 1));
                recIndexs.Add(width * (height - flowerSize) / 2 - (width - flowerSize) / 2);
                recIndexs.Add(width * (height - flowerSize) + (((width - flowerSize) / 2) - 1));
                recIndexs.Add(width * (height - flowerSize + 1) - (width - flowerSize) / 2);

                //Need to replace with formula?
                recIndexs.Add(16);
                recIndexs.Add(19);
                recIndexs.Add(49);
                recIndexs.Add(58);
                recIndexs.Add(85);
                recIndexs.Add(94);
                recIndexs.Add(124);
                recIndexs.Add(127);*/
            }
            else
            {
                recIndexs.Add(new TableLayoutPanelCellPosition(4, 4));
            }
        }

        public void gridUpdate()
        {
            foreach(TableLayoutPanelCellPosition index in recIndexs)
            {
                //this.grid.CellList[index.Row, index.Column].TileType = TileType.Recommend;
            }
        }

        public void ResetGrid()
        {
            Console.WriteLine("ResetGrid Called");
        }
    }
}
