using System;

namespace Unit02HiloGame
{
    public class Card
    {
        int value = 0;

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Card() { }

        /// <summary>
        /// Generates a new random value and calculates the points for the die.
        /// </summary>
        public int new_card()
        {
            Random random = new Random();
            value = random.Next(1, 14);
            return value;
        }
    }
}
