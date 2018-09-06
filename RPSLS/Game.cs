using RPSLS;
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
            PlayWinner();
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

        public void PlayWinner()
        {
            do
            {
                Winner(playerOne.Gesture(), playerTwo.Gesture());
            } while ((playerOne.score < 2) && (playerTwo.score < 2));

            if ((playerOne.score >= 2))
            {
                Console.WriteLine("\n" + playerOne.GetName() + " has won the game!");
            }
            else if ((playerTwo.score <= 2))
            {
                Console.WriteLine("\n" + playerTwo.GetName() + " has won the game!");
            }
        }

        public void Winner(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == "rock")
            {
                if ((playerTwoGesture == "scissors") || (playerTwoGesture == "lizard"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "paper")
            {
                if ((playerTwoGesture == "rock") || (playerTwoGesture == "spock"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "scissors")
            {
                if ((playerTwoGesture == "paper") || (playerTwoGesture == "lizard"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "lizard")
            {
                if ((playerTwoGesture == "spock") || (playerTwoGesture == "paper"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "spock")
            {
                if ((playerTwoGesture == "scissors") || (playerTwoGesture == "rock"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
        }
    }
}
