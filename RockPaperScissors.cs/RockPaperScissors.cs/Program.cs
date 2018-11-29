using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RockPaperScissors.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(0, 2);
            int userNumber;
           

            Console.WriteLine("Rock, Paper, Scissors!");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine("You chose Rock! ");
            }
            else if (userNumber == 1)
            {
                Console.WriteLine("You chose Paper! ");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("You chose Scissors! ");
            }
            if (number == 0)
            {
                Console.WriteLine("The computer chose Rock! ");
            }
            else  if (userNumber == 1)
            {
                Console.WriteLine("The computer chose Paper! ");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("The computer chose Paper! ");
            }
            if (userNumber == 1)
            {
                if (number == 1)
                {
                    WriteLine("Draw!");
                }
                else if (number == 0)
                {
                    WriteLine("You Win!");
                }
                else if (number == 2)
                {
                    WriteLine("You Lose!");
                }
            }
            if (userNumber == 2)
            {
                if (number == 2)
                {
                    WriteLine("Draw!");
                }
                else if (number == 1)
                {
                    WriteLine("You Win!");
                }
                else if (number == 0)
                {
                    WriteLine("You Lose!");
                }
            }
                if (userNumber == 0)
                {
                    if (number == 0)
                    {
                        WriteLine("Draw!");
                    }
                    else if (number == 2)
                    {
                        WriteLine("You Win!");
                    }
                    else if (number == 1)
                    {
                        WriteLine("You Lose!");
                    }
                }

            }












        }


















    }
    