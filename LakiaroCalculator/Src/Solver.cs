using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakiaroCalculator.Src
{
    public class Solver
    {
        #region 
        Grid grid;
        List<Cell> recList;

        int nDirts, cDirts = 0;
        int nRoots, cRoots = 0;
        int nRocks, cRocks = 0;

        public Solver()
        {
            grid = new Grid();
            recList = new List<Cell>();
        }
        
        public Solver(Grid _grid)
        {
            this.grid = _grid;
            recList = new List<Cell>();
        }

        public void Solve(bool level)
        {

        }
    }
}
