using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_Part1_ST10094307
{
    public partial class Form1 : Form
    {
        private readonly GameEngine_class gameEngine;
        public Form1()
        {
            InitializeComponent();
            gameEngine = GameEngine_class(10);
            UpdateDisplay();
        }

        private GameEngine_class GameEngine_class(int v)
        {
            return new GameEngine_class(v);
        }

        private void UpdateDisplay()
        {
            lblDisplay.Text = gameEngine.ToString();
        }
    }
}
