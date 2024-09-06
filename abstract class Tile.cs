using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
  abstract class Tile
  {
        //Making a private field of type position.
        private Position _position;

        public Tile(Position position)
        {
            _position = position;
        }
        public int X
        {
            get { return _position.X; }
            set { _position.X = value; }
        }
        public int Y
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }
        //Abstract Property with char type.
        public abstract char Display { get; }

        //constructor to assign parameter to position field.
        /*public Tile(Position position)
        {
            X = position.X;
            Y = position.Y;
        }*/
  }
}
