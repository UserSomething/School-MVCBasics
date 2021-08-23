using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCBasics.Models
{
    public class NumberGuessingGame
    {
        public NumberGuessingGame(int userGuess)
        {
            UserGuess = userGuess;
            NumberToGuess = CreateRandomNumber();
        }

        public int UserGuess { get; set; }
        public int NumberToGuess { get; set; }

        private int CreateRandomNumber()
        {
            Random randomNum = new();
            int numberToGuess = randomNum.Next(1, 101);

            return numberToGuess;
        }

        public string GuessResult()
        {
            if (UserGuess < NumberToGuess)
            {
                return "The number is too small.";
            }
            else if (UserGuess > NumberToGuess)
            {
                return "The number is too big.";
            }
            else
            {
                return "You win!";
            }
        }
    }
}
