using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Part1_ST10094307
{
    public class GameEngine_class
    {
        private Level currentLevel;
        private int numberOfLevels;
        private Random random;

        private const int MIN_SIZE = 10;
        private const int MAX_SIZE = 20;

        public GameEngine_class(int numberOfLevels)
        {
            this.numberOfLevels = numberOfLevels;
            random = new Random();

            int width = random.Next(MIN_SIZE, MAX_SIZE + 1);
            int height = random.Next(MIN_SIZE, MAX_SIZE + 1);
            currentLevel = new Level(width, height);
        }

        public override string ToString()
        {
            return currentLevel.ToString();
        }
    }

}
