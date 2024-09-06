using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
   

    public class Level
    {
        // Private fields
        private Tile[,] tiles; // 2D array of Tiles
        private int width; // Width of the level
        private int height; // Height of the level

        // Enum to represent different types of tiles
        public enum TileType
        {
            Empty // Placeholder for now; more types can be added later
        }

        // Properties for width and height (optional, based on your needs)
        public int Width { get { return width; } }
        public int Height { get { return height; } }

        // Constructor
        public Level(int width, int height)
        {
            // Initialize width and height
            this.width = width;
            this.height = height;

            // Initialize the 2D array of tiles with the given dimensions
            tiles = new Tile[width, height];

            // Initialize all tiles to EmptyTiles
            InitialiseTiles();
        }

        // Private method to create a Tile based on the TileType and Position
        private Tile CreateTile(TileType type, Position position)
        {
            Tile newTile;

            // Switch statement to create a Tile based on the TileType
            switch (type)
            {
                case TileType.Empty:
                    newTile = new EmptyTile(position);
                    break;
                default:
                    newTile = new EmptyTile(position); 
                    break;
            }

            // Place the created tile in the 2D array based on its position
            tiles[position.X, position.Y] = newTile;

            return newTile; // Return the created Tile object
        }

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

