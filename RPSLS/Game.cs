using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public double winCondition;
        public string numberOfPlayers;
        public double PlayerOneOrPlayerTwoMessageTracker;

        public Game()
        {
            winCondition = 2;
        }

        public void MainMenu()
        {
            Console.WriteLine("--Welcome to RPSLS!--");
            Players();
            Play();
        }

        
    }
}
