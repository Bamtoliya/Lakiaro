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
        Thin = 4,
        End = 8
    }


    public enum RootDirection
    {
        North = 'N',
        South = 'S',
        West = 'W',
        East = 'E',
        End = 'C'
    }

    #endregion
    public class Cell
    {
        TileType tileType;
        RootType rootType;
        //Dictionary<int, Root> 

        public Cell()
        {
            this.tileType = TileType.None;
            this.rootType = RootType.None;
        }

        public Cell(TileType _tileType)
        {
            this.tileType = _tileType;
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
