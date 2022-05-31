using System;
using System.Collections.Generic;

namespace Unit02HiloGame
{
    /// <summary>
    /// A person who directs the game.
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Card Card;
        int currentcard;
        int nextcard;
        bool isPlaying = true;
        string guess;
        int totalScore;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            this.Card = new Card();
            totalScore = 200;
            nextcard = 0;
            currentcard = Card.new_card();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.WriteLine($"The Current Card is: {currentcard}");
            Console.Write("higher or lower (h/l) ");
            guess = Console.ReadLine();
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            nextcard = Card.new_card();
            Console.WriteLine($"Next Card: {nextcard}");
            if (guess == "h")
            {
                if (nextcard >= currentcard)
                {
                    totalScore = totalScore + 100;
                }
                else if (nextcard < currentcard)
                {
                    totalScore = totalScore - 75;
                }
            }
            else if (guess == "l")
            {
                if (nextcard < currentcard)
                {
                    totalScore = totalScore + 100;
                }
                else if (nextcard > currentcard)
                {
                    totalScore = totalScore - 75;
                }
            }
            if (totalScore <= 0)
            {
                isPlaying = false;
            }
            currentcard = nextcard;
        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your score is: {totalScore}\n");
            Console.WriteLine("Would you like to play again (y/n)?");
            string playagain = Console.ReadLine();
            if (playagain == "y")
            {
                isPlaying = true;
            }
            else
                isPlaying = false;
        }
    }
}
