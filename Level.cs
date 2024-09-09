using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{

    // Class to represent a Level in the game
    public class Level
    {
        // Enum to represent different types of tiles
        public enum TileType
        {
           Empty,
           Wall,
        }
        public class Tile
        {
            public TileType Type { get; private set; }
            public string Display { get; internal set; }

            public Tile(TileType type)
            {
                Type = type;
            }

            internal static Tile CreateTile(TileType wall)
            {
                throw new NotImplementedException();
            }
        }
        // Private fields
        private Tile[,] tiles; //2d Array
        private int width;
        private int height;
        //properties

        public int Width
        { 
            get { return width; } 
            set { width = value; } 
        }
        public int Height
        {
            get { return height; } 
            set { height = value; } 
        }
        private Tile[,] TileArray
        { 
            get { return TileArray; } 
            set { TileArray = value; } 
        }

        // Constructor
        public Level(int width, int height)
        {
            this.width = width;
            this.height = height;
            tiles = new Tile[width, height];
            InitialiseTiles(); // Empty all tiles
        }

        // Private method to create a tile
        public static Tile CreateTile(TileType type)
        {
            switch (type)
            {
                case TileType.Wall:
                    return new Tile(TileType.Wall);
                case TileType.Empty:
                default:
                    return new Tile(TileType.Empty);
                   // Additional cases for other tile types can be added here
            }   
        }

        // Method to initialize all tiles to empty
        private void InitialiseTiles()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                    {
                        tiles[x, y] = Tile.CreateTile(TileType.Wall);
                    }
                    else
                    {
                        tiles[x, y] = Tile.CreateTile(TileType.Empty);
                    }
                }
            }
        }

        // Override ToString method to provide a visual representation of the level
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // Loop through each row
            for (int y = 0; y < height; y++)
            {
                // Loop through each column
                for (int x = 0; x < width; x++)
                {
                    sb.Append(tiles[x, y].Display); // Access Tile's Display property
                }
                sb.AppendLine(); // New line after each row
            }
            return sb.ToString(); // Return the constructed string
        }
    }
}

