using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    public abstract class Tile
    {
        private Position _position;

        public int x
        {
            get { return _position.X; }
            set { _position.X = value; }
        }
        public int y
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }
    }
}
