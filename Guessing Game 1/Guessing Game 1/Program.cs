using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Guessing_Game_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            string guessString;
            int Min = 1;
            int Max = 11;
            string result = null;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(Min, Min);

            Write("Choose a number between 1-10>>>");
            guessString = ReadLine();
            guess = Convert.ToInt32(guessString);

            if (guess < Max && guess >= Min)

                if (randomNumber == guess)
                {
                    result = "You win, you guessed " + randomNumber;
                }
                else if (guess > randomNumber)
                {
                    result = "You guessed to high";
                }
                else if (guess < randomNumber)
                {
                    result = "You guessed to low";
                }
                else
                    result = "Error";
            DisplayString(result);

        }
        static void DisplayString(string r)
        {
            WriteLine(r);
        }

    }
}