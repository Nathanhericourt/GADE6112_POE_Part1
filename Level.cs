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
           Wall
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
        private Tile CreateTile(TileType type, Position position)
        {
            Tile tile = null;

            switch (type)
            {
                case TileType.Empty:
                    tile = new Tile(TileType.Empty, position);
                    break;
                    case TileType.Wall:
                    tile = new Tile(TileType.Wall, position);
                    break;
                    // Additional cases for other tile types can be added here
            }

            // Place the tile in the level's layout
            tiles[position.X, position.Y] = tile;

            return tile;
        }

        // Method to initialize all tiles to empty
        public void InitialiseTiles()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Position position = new int(x, y);
                   
                    CreateTile(TileType.Empty, position);
                }
            }
        }

        // Helper method to update the tile at a specific position
        /*public void UpdateTile(Position position, TileType newType)
        {
            if (position.X >= 0 && position.X < width && position.Y >= 0 && position.Y < height)
            {
                CreateTile(newType, position);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds.");
            }
        }*/
             

        // Method to get a tile at a specific position
        /*public Tile GetTile(Position position)
        {
            if (position.X >= 0 && position.X < width && position.Y >= 0 && position.Y < height)
            {
                return tiles[position.X, position.Y];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds.");
            }
        }*/


        // Overloaded version of CreateTile that accepts x and y integers
        private Tile CreateTile(TileType type, int x, int y)
        {
            // Create a new Position object and call the existing CreateTile method
            return CreateTile(type, new Position(x, y));
        }

        // Method to initialize all tiles to EmptyTiles
        public void InitialiseTiles()
        {
            // Loop through each position in the 2D array and set to EmptyTile
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    CreateTile(TileType.Empty, x, y);
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

