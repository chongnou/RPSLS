using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        List<string> Gestures;
        public Computer()
        {
            this.name = "Computer";
            this.score = 0;
        }

        public override string Gesture()
        {
            Gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            Random random = new Random();
            int randomIndex = random.Next(0, 5);
            string randomListGesture = Gestures[randomIndex];
            Console.WriteLine(name + " Shape: " + randomListGesture);
            return randomListGesture;
        }
    }
}
