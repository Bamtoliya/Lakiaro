using LakiaroCalculator.Src;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LakiaroCalculator.Customized_Tool
{
    public partial class GridControl : UserControl
    {
        CellButton[,] grid;
        int width;
        int height;
        
        public GridControl()
        {
            InitializeComponent();
            this.width = 12;
            this.height = 12;
            grid = new CellButton[Height, width];
            this.tableLayoutPanel1.RowCount = this.width;
            this.tableLayoutPanel1.ColumnCount = this.height;

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            for (int i = 0; i < this.tableLayoutPanel1.ColumnCount; ++i)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
            }

            ConstructCellButtons(this.width, this.height);            
        }

        public GridControl(bool level)
        {
            InitializeComponent();
            if(!level)
            {
                this.width = 12;
                this.height = 12;                
            }
            else
            {
                this.width = 14;
                this.height = 14;
            }

            grid = new CellButton[Height, width];
            this.tableLayoutPanel1.RowCount = this.width;
            this.tableLayoutPanel1.ColumnCount = this.height;

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            for (int i = 0; i < this.tableLayoutPanel1.ColumnCount; ++i)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
            }

            ConstructCellButtons(this.height, this.width);            
        }

        public void ResetGridControl()
        {
            foreach(CellButton cellButton in tableLayoutPanel1.Controls)
            {
                cellButton.Clear();
            }
        }

        public void Test()
        {

        }


        public void ConstructCellButtons(int _height, int _width)
        {
            for (int i = 0; i < _height; ++i)
            {
                for (int j = 0; j < _width; ++j)
                {
                    if (i >= ((_height / 2) - 2) && i < ((_height / 2) + 2))
                    {
                        if (j >= ((_width / 2) - 2) && j < ((_width / 2) + 2))
                        {
                            grid[i, j] = new CellButton(TileType.Flower);
                        }
                        else
                        {
                            grid[i, j] = new CellButton(TileType.None);
                        }
                    }
                    else
                    {
                        grid[i, j] = new CellButton(TileType.None);
                    }
                    tableLayoutPanel1.Controls.Add(grid[i, j]);
                }
            }
        }


        /*public void GridUpdate()
        {
            foreach(int index in this.grid.RecList){
                ((CellButton)tableLayoutPanel1.Controls[index]).Recommend();
            }
        }*/
    }
}
