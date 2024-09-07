using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    public class Position //changed from internal to public
    {
        public int X { get; set; } //changed from public to private and intialised X and get and set, and changed case
        public int Y { get; set; } //changed from public to private and intialised Y and get and set, and changed case

        public Position(int x,int y) //constructor
        {
            X = x; //changed case
            X = y; //changed case
        }

        public int x
        {
            get { return x; }
            set { x = value; }
        }
        public int y 
        {
            get { return y; }
            set { y = value; }
        }

        
    }   
}
