using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    public class Empty_Tile : Tile 
    {
        public Empty_Tile(int position) : base(position)
        {
            
        }

        public override string Display
        {
            get { return "."; }
        }
    }
}
