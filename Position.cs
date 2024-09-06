using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    internal class Position
    {
        private int x, y;

        public Position(int _x,int _y) //constructor
        {
            _x = x;
            _y = y;
        }

        public int X 
        {
            get { return x; }
            set { x = value; }
        }
        public int Y 
        {
            get { return y; }
            set { y = value; }
        }

        
    }   
}
