using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Customized_Tool
{
    public enum TileType : short
    {

        Root = 16,
        Rock = 8,
        Dirt = 4,
        Flower = 2,
        Question = 1
    }
    
    public enum RootType : short
    {
        Thick = 1, 
        Narrow = 2,
        Thin = 4,
        End = 8
    }

    //Ascii Code
    // N = 78
    // S = 83
    // W = 87
    // E = 69
    // C = 67

    //NS //SE //WE
    //NE //SW
    //NW

    public enum RootDirection
    {
        North = 'N',
        South = 'S',
        West = 'W',
        East = 'E',
        End = 'C'
    }
    struct Root
    {
        short type;
        char direction;

        public short Type { get => type; set => type = value; }
        public char Direction { get => direction; set => direction = value; }
    }
    public class CellButton : Button
    {
        short tileType;
        RootType rootType;
        short type;
        Dictionary<int, Root> direction = new Dictionary<int, Root>();

        public CellButton()
        {
            this.type = 0;
            this.MinimumSize = new Size(64, 64);
        }

        public short Type { get => type; set => type = value; }
        public short TileType { get => tileType; set => tileType = value; }
        public RootType RootType { get => rootType; set => rootType = value; }
        internal Dictionary<int, Root> Direction { get => direction; set => direction = value; }
    }
}
