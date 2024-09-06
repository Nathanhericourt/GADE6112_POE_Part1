using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    class EmptyTile :Tile
    {
        //Constructor accepting the Position parameters.
        public EmptyTile(Position p): base(p)
        {

        }
        //Override the get accessor.
        public override char Display
        {
            get { return '.'; }
        }
    }
}
