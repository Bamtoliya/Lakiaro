using System.Collections.Generic;
using System.Windows.Forms;

namespace LakiaroCalculator.Src
{

    // Flower Width & Height = 4
    // Height   / 2 +- 2 = Flower
    // Width    / 2 +- 2 = Flower
    public class Grid
    {
        int height = 0;
        int width = 0;
        Cell[, ] cellList;

        public Grid()
        {
            this.height = 12;
            this.width = 12;
            cellList = new Cell[this.height , this.width];
            CreateGrid(this.height, this.width);
        }

        public Grid(bool level)
        {
            if (level)
            {
                this.height = 14;
                this.width = 14;
                cellList = new Cell[this.height, this.width];
                CreateGrid(this.height, this.width);
            }
            else
            {
                this.height = 12;
                this.width = 12;
                cellList = new Cell[this.height, this.width];
                CreateGrid(this.height, this.width);
            }
        }

        public void CreateGrid(int _height, int _width)
        {
            for (int i = 0; i < _height; ++i)
            {
                for (int j = 0; j < _width; ++j)
                {
                    if (i >= ((_height / 2) - 2) && i < ((_height / 2) + 2))
                    {
                        if (j >= ((_width / 2) - 2) && j < ((_width / 2) + 2))
                        {
                            cellList[i, j] = new Cell(TileType.Flower);
                        }
                        else
                        {
                            cellList[i, j] = new Cell(TileType.None);
                        }
                    }
                    else
                    {
                        cellList[i, j] = new Cell(TileType.None);
                    }
                }
            }

        }

        public void ResetGrid()
        {
            foreach(Cell cell in cellList)
            {
                cell.Clear();
            }
        }

        public void gridUpdate()
        {
        }

        public Cell[, ] CellList { get => cellList; set => cellList = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}
