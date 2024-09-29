using LakiaroCalculator.Src;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Customized_Tool
{
    public partial class GridControl : UserControl
    {
        Grid grid;
        Stack<int> keyLog;
        public GridControl()
        {
            InitializeComponent();
            grid = new Grid();
            this.tableLayoutPanel1.RowCount = grid.Height;
            this.tableLayoutPanel1.ColumnCount = grid.Width;

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            for (int i = 0; i < this.tableLayoutPanel1.ColumnCount; ++i)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64));
            }

            for (int i = 0; i < this.tableLayoutPanel1.RowCount; ++i)
            {
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
            }
            foreach (Cell cell in grid.CellList)
            {
                tableLayoutPanel1.Controls.Add(new CellButton(cell));
            }
        }

        public void ResetGridControl()
        {
            foreach(CellButton cellButton in tableLayoutPanel1.Controls)
            {
                cellButton.Clear();
            }
            this.grid.ResetGrid();
            GridUpdate();
        }



        public void GridUpdate()
        {
            foreach(int index in this.grid.RecList){
                ((CellButton)tableLayoutPanel1.Controls[index]).Recommend();
            }
        }
    }
}
