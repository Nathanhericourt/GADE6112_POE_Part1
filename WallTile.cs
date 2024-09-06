using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    /*something needs to be here*/ class WallTile : Tile
    {
        private WallTile(Position position):
            base(position)
        { }
        public override char Display
        {
            get { return '|'; }
        }
    }
}
