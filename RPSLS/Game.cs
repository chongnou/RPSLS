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
        public double PlayerOneOrPlayerTwoScore;

        public Game()
        {
            winCondition = 2;
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to RPSLS!\n");
            Console.WriteLine("Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock ");
            Console.WriteLine("\nThe game will be best out of 3.");
            Players();
            PlayWinner();
        }

        public void Players()
        {
            bool continueLooping = true;
            while (continueLooping)
            {
                Console.WriteLine("\nOne player or Two players? \n1 = One \n2 = Two");
                numberOfPlayers= Console.ReadLine();
                if (numberOfPlayers.ToLower() == "1")
                {
                    EnterName(numberOfPlayers);
                    playerOne = new Human(Console.ReadLine());
                    playerTwo = new Computer();
                    continueLooping = false;
                }
                else if (numberOfPlayers.ToLower() == "2")
                {
                    EnterName(numberOfPlayers);
                    playerOne = new Human(Console.ReadLine());
                    EnterName(numberOfPlayers);
                    playerTwo = new Human(Console.ReadLine());
                    continueLooping = false;
                }
                else
                {
                    Console.WriteLine("Enter 1 or 2 mang!\n");
                }
            }
        }

        public void EnterName(string option)
        {
            if (option.ToLower() == "1")
            {
                Console.WriteLine("\n[Player Vs Computer]");
                Console.WriteLine("Enter player one name:");
            }
            else if (option.ToLower() == "2")
            {
                if (PlayerOneOrPlayerTwoScore == 0)
                {
                    PlayerOneOrPlayerTwoScore++;
                    Console.WriteLine("\n[Player Vs Player]");
                    Console.WriteLine("Enter player one name:");
                }
                else if (PlayerOneOrPlayerTwoScore == 1)
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
            } while ((playerOne.score < 3) && (playerTwo.score < 3));

            if ((playerOne.score >= 3))
            {
                Console.WriteLine("\n" + playerOne.GetName() + " has won the game!");
            }
            else if ((playerTwo.score <= 3))
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
