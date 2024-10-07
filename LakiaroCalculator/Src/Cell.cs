using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakiaroCalculator.Src
{

    #region Enums
    public enum TileType : ushort
    {
        None = 0,
        Recommend = 32,
        Root = 16,
        Rock = 8,
        Dirt = 4,
        Flower = 2,
        Question = 1
    }

    public enum RootType : ushort
    {
        None = 0,
        Thick = 1,
        Narrow = 2,
        Thin = 3,
        End = 4
    }
    #endregion

    public class Cell
    {
        public TileType tileType;
        public RootType rootType;
        public string direction = "";

        public Cell()
        {
            this.tileType = TileType.None;
            this.rootType = RootType.None;
            this.direction = "";
    }

        public Cell(TileType _tileType)
        {
            this.tileType = _tileType;
            this.rootType = RootType.None;
            this.direction = "";
        }

        public Cell(RootType _rootType)
        {
            this.tileType = TileType.Root;
            this.rootType = _rootType;
            this.direction = "";
        }

        public TileType TileType { get => tileType; set => tileType = value; }
        public RootType RootType { get => rootType; set => rootType = value; }

        public void Clear()
        {
            if(this.TileType != TileType.Flower)
            {
                this.tileType = TileType.None;
                this.rootType = RootType.None;
            }
        }
    }

    
}
