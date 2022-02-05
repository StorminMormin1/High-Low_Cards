using System;

namespace Unit2.CardGame
{
    public class Card
    {
        //stuff

        public int _currentCard = 0;
        public int _nextCard = 0;

        public string _guess = "H";
        public int _points = 300;

        public string _result = "A";

        public Card()
        {
        //stuff
        }

        public void DrawTwo()
        {
            //draws two new random cards (numbers)
            Random random = new Random();
            _currentCard = random.Next(1, 14);
            _nextCard = random.Next(1, 14);

            //makes sure the cards aren't exactly the same
            while (_currentCard == _nextCard)
            {
                _nextCard = random.Next(1, 14);
            }

            Console.WriteLine($"The card is: {_currentCard}");

            Console.WriteLine("Higher or lower? [H/L]");
            _guess = Console.ReadLine();
            _guess = _guess.ToUpper(); //saves the string guess from user
        }
        
        public void High_or_Low()
        {
            //finds the real result whether card1 is higher or lower than nextCard
            if (_currentCard > _nextCard)
            {
                _result = "L";
            }

            else if (_currentCard < _nextCard)
            {
                _result = "H";
            }
        }

        public int computeScore()
        {
            Console.WriteLine($"Next card was {_nextCard}");
            if (_guess == _result)
            {
                _points = 100;
            }

            else
            {
                _points = - 75;
            }
            return _points;
        }
    }
}