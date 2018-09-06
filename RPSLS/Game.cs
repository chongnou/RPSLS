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

        public void Players()
        {
            bool continueLooping = true;
            while (continueLooping)
            {
                Console.WriteLine("\nOne player or Two players? \n1) One \n2) Two");
                numberOfPlayers= Console.ReadLine();
                if (numberOfPlayers.ToLower() == "1")
                {
                    EnterName(numberOfPlayers);
                    playerOne = new Human(Console.ReadLine());
                    playerTwo = new Computer();
                    continueLooping = false;
                }
                else if (numberOfPlayers.ToLower() == "b2")
                {
                    EnterName(numberOfPlayers);
                    playerOne = new Human(Console.ReadLine());
                    EnterName(numberOfPlayers);
                    playerTwo = new Human(Console.ReadLine());
                    continueLooping = false;
                }
                else
                {
                    Console.WriteLine("Note: Invalid input.");
                }
            }
        }

        public void EnterName(string option)
        {
            if (option.ToLower() == "a")
            {
                Console.WriteLine("\n[Player Vs Computer]");
                Console.WriteLine("Enter player one name:");
            }
            else if (option.ToLower() == "b")
            {
                if (PlayerOneOrPlayerTwoMessageTracker == 0)
                {
                    PlayerOneOrPlayerTwoMessageTracker++;
                    Console.WriteLine("\n[Player Vs Player]");
                    Console.WriteLine("Enter player one name:");
                }
                else if (PlayerOneOrPlayerTwoMessageTracker == 1)
                {
                    Console.WriteLine("Enter player two name:");
                }
            }
        }
    }
}
