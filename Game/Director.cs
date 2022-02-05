using System;
using System.Collections.Generic;

namespace Unit2.CardGame
{

    
    public class Director
    {
        public bool isPlaying = true;
        public string again = "y";

        public int currentScore = 300;
        public Card turn = new Card();

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
              turn.DrawTwo();
              turn.High_or_Low();
        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
            
            currentScore += turn.computeScore(); //computes the score according to the guess received in Card.
            Console.WriteLine($"Your score is: {currentScore}");
            
            if (currentScore <= 0)
            {
                Console.WriteLine("Game Over!");
                isPlaying = false;
            }

            else
            {
                Console.WriteLine("Play again?");
                again = Console.ReadLine();
                isPlaying = (again == "y");
            }
        }
    }
}