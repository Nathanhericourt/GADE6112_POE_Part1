using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    internal class CharacterTile
    {
        // Assuming Tile is an existing class that CharacterTile will extend
        public abstract class CharacterTile : Tile
        {
            // Fields for hitpoints, maximum hitpoints, and attack power
            protected int hitpoints;
            protected int maximumHitpoints;
            protected int attackPower;

            // Field to store the character's vision
            protected Tile[] vision;

            // Constructor for CharacterTile
            public CharacterTile(Position position, int hitpoints, int attackPower) : base(position)
            {
                this.hitpoints = hitpoints;
                this.maximumHitpoints = hitpoints; // Initialize maximum hitpoints
                this.attackPower = attackPower; // Initialize attack power
                this.vision = new Tile[4]; // Initialize vision array to store 4 tiles
            }

            // Method to update the character's vision based on its position in the level
            public void UpdateVision(Level level)
            {
                // Assuming the Level class has a method to get the Tile array
                Tile[,] tileArray = level.GetTileArray();

                // Get the current position of the character
                int x = this.Position.X;
                int y = this.Position.Y;

                // Update vision based on the character's position
                // Assuming vision is in the order: [up, right, down, left]
                if (y > 0)
                {
                    vision[0] = tileArray[y - 1, x]; // Up
                }
                if (x < tileArray.GetLength(1) - 1)
                {
                    vision[1] = tileArray[y, x + 1]; // Right
                }
                if (y < tileArray.GetLength(0) - 1)
                {
                    vision[2] = tileArray[y + 1, x]; // Down
                }
                if (x > 0)
                {
                    vision[3] = tileArray[y, x - 1]; // Left
                }
            }
        }
    }
}
