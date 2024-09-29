using System.Collections.Generic;

namespace LakiaroCalculator.Src
{

    // Flower Width & Height = 4
    // Height   / 2 +- 2 = Flower
    // Width    / 2 +- 2 = Flower
    public class Grid
    {
        const int flowerSize = 4;
        int height = 0;
        int width = 0;
        List<Cell> cellList;
        List<int> recList;
        bool level;

        public Grid()
        {
            this.height = 12;
            this.width = 12;
            this.level = false;
            cellList = new List<Cell>();
            recList = new List<int>();
            // Create the tiles
            for (int i = 0; i < height; ++i)
            {
                for(int j = 0; j < width; ++j)
                {
                    if(i >= ((height/2) - 2) && i < ((height/2) + 2))
                    {
                        if (j >= ((width / 2) - 2) && j < ((width / 2) + 2))
                        {
                            cellList.Add(new Cell(TileType.Flower));
                        } 
                        else
                        {
                            cellList.Add(new Cell(TileType.None));
                        }
                    } 
                    else
                    {
                        cellList.Add(new Cell(TileType.None));
                    }
                }
            }

            FirstRec();
            foreach(int index in recList)
            {
                cellList[index].TileType = TileType.Recommend;
            }
        }

        public Grid(bool level)
        {
            if (!level)
            {
            }
        }

        public void ResetGrid()
        {
            recList.Clear();
            FirstRec();
            foreach(Cell cell in cellList)
            {
                cell.Clear();
            }
        }

        public void gridUpdate()
        {
            foreach(Cell cell in cellList)
            {
                cell.cellUpdate();
            }
        }


        //First Solve Logic test
        public void FirstRec()
        {
            if (!level)
            {
                recList.Add(width * (((height - flowerSize) / 2) - 1)   + (((width - flowerSize) / 2) - 1));
                recList.Add(width * (height - flowerSize) / 2           - (width - flowerSize) / 2);
                recList.Add(width * (height - flowerSize)               + (((width - flowerSize) / 2) - 1));    
                recList.Add(width * (height - flowerSize + 1)           - (width - flowerSize) / 2);

                //Need to replace with formula?
                recList.Add(16);
                recList.Add(19);
                recList.Add(49);
                recList.Add(58);
                recList.Add(85);
                recList.Add(94);
                recList.Add(124);
                recList.Add(127);
            }
        }

        public void SecondRec()
        {
            recList.Add(16);
            recList.Add(19);
            recList.Add(49);
            recList.Add(58);
            recList.Add(85);
            recList.Add(94);
            recList.Add(124);
            recList.Add(127);
        }

        

        public List<Cell> CellList { get => cellList; set => cellList = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public bool Level { get => level; set => level = value; }
        public List<int> RecList { get => recList; set => recList = value; }
    }
}
