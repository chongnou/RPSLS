using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        List<string> Gestures;

        public Human(string name)
        {
            this.name = name;
            this.score = 0;
        }

        public override string Gesture()
        {
            bool continueLooping = true;
            while (continueLooping)
            {
                Console.WriteLine("\n" + name + " What would you like to throw? Ex: rock, paper, scissors, lizard, or spock.");
                string theGesture;
                theGesture = Console.ReadLine();
                Gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
                for (int i = 0; i < Gestures.Count; i++)
                {
                    if (Gestures[i] == theGesture.ToLower())
                    {
                        gesture = Gestures[i];
                        continueLooping = false;
                    }
                }
            }
            Console.WriteLine("\n" + name + " shape: " + gesture);
            return gesture;
        }
    }
}
